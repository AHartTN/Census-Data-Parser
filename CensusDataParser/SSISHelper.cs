#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/06/2016 4:44 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SSISHelper.cs
// 
// Anthony Hart ("ANTHONY") CONFIDENTIAL
// 
// Unpublished Copyright (c) 1985-2016 Anthony Hart, All Rights Reserved.
// 
// === NOTICE ===
// All information contained herein is, and remains the property of ANTHONY. The intellectual and technical concepts contained
// herein are proprietary to ANTHONY and may be covered by U.S. and Foreign Patents, patents in process, and are protected by trade secret or copyright law.
// Dissemination of this information or reproduction of this material is strictly forbidden unless prior written permission is obtained
// from ANTHONY. Access to the source code contained herein is hereby forbidden to anyone except current ANTHONY employees, managers or contractors who have executed 
// Confidentiality and Non-disclosure agreements explicitly covering such access. 
// 
// The copyright notice above does not evidence any actual or intended publication or disclosure of this source code, which includes 
// information that is confidential and/or proprietary, and is a trade secret, of ANTHONY. ANY REPRODUCTION, MODIFICATION, DISTRIBUTION, PUBLIC PERFORMANCE, 
// OR PUBLIC DISPLAY OF OR THROUGH USE OF THIS SOURCE CODE WITHOUT THE EXPRESS WRITTEN CONSENT OF ANTHONY IS STRICTLY PROHIBITED, AND IN VIOLATION OF APPLICABLE 
// LAWS AND INTERNATIONAL TREATIES. THE RECEIPT OR POSSESSION OF THIS SOURCE CODE AND/OR RELATED INFORMATION DOES NOT CONVEY OR IMPLY ANY RIGHTS 
// TO REPRODUCE, DISCLOSE OR DISTRIBUTE ITS CONTENTS, OR TO MANUFACTURE, USE, OR SELL ANYTHING THAT IT MAY DESCRIBE, IN WHOLE OR IN PART.
// 
// ANTHONY reserves the right to make public any and all contents of this file at the sole discretion of ANTHONY. In such case, licensing included with said publication(s) will supercede this notice only if made public by ANTHONY.
// 
// DISCLAIMERS (When Implemented):
// MAF/TIGER SHAPEFILES AND CENSUS DATA OBTAINED FROM THE US CENSUS BUREAU VIA FTP.
// http://www.census.gov
// ftp://ftp.census.gov
// 
// CRIME/POLICE INFORMATION OBTAINED FROM THE FEDERAL BUREAU OF INVESTIGATIONS VIA HTTP
// http://www.fbi.gov
#endregion

namespace CensusDataParser
{
	#region Using Directives
	using System;
	using System.Collections.Generic;
	using System.Data.Entity.ModelConfiguration;
	using System.IO;
	using System.Linq;
	using Extensions;
	using Microsoft.SqlServer.Dts.Runtime;
	using Microsoft.SqlServer.Dts.Runtime.Wrapper;
	using Application = Microsoft.SqlServer.Dts.Runtime.Application;
	using Package = Microsoft.SqlServer.Dts.Runtime.Package;
	#endregion

	public class SSISHelper
	{
		//public string OleDBConnectionString => $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={FilePath}";
		public Application CensusApplication { get; set; }
		public Connections CensusConnections { get; set; }
		public Package CensusPackage { get; set; }
		public Dictionary<string, Executable> CensusTasks { get; set; }
		public ConnectionManager DefaultConnection { get; set; }
		public Dictionary<string, ConnectionManager> FlatFileConnections { get; set; }
		public const int CodePage = 1252;
		public const int LocaleID = 1033;
		public const string RowDelimiter = @"\r\n";

		public SSISHelper() { Initialize(); }

		public void AddFlatFileConnection<T>(string path, EntityTypeConfiguration<T> map, bool updateExisting = false) where T : class
		{
			using (ConnectionManager manager = GetFlatFileConnection(path, map, updateExisting))
			{
				Console.Write($"\rAdded {manager.Name} to the flat file connections");
			}
		}

		private void GetColumns<T>(ref IDTSConnectionManagerFlatFile100 manager, EntityTypeConfiguration<T> map) where T : class
		{
			foreach (object column in manager.Columns)
			{
				manager.Columns.Remove(column);
			}

			IEnumerable<Tuple<string, int?, int?>> columnInfo = map.GetColumnInfo()
			                                                       .OrderBy(o => o.Item2);

			Dictionary<string, int> numberLengths = new Dictionary<string, int>
			                                        {
				                                        {"LOGRECNO", 7},
				                                        {"AREALAND", 14},
				                                        {"AREAWATR", 14},
				                                        {"POP100", 9},
				                                        {"HU100", 9}
			                                        };

			foreach (Tuple<string, int?, int?> column in columnInfo)
			{
				int? columnWidth = numberLengths.ContainsKey(column.Item1)
					                   ? numberLengths[column.Item1]
					                   : column.Item3;

				if (!columnWidth.HasValue)
				{
					throw new ArgumentException($"Invalid Column width on {column.Item1}");
				}

				IDTSConnectionManagerFlatFileColumn100 ffColumn = manager.Columns.Add();
				ffColumn.DataType = column.Item3.HasValue
					                    ? DataType.DT_STR
					                    : DataType.DT_NUMERIC;
				ffColumn.ColumnType = "FixedWidth";
				ffColumn.ColumnWidth = columnWidth.Value;

				//ffColumn.MaximumWidth = ffColumn.ColumnWidth;
			}
			IDTSConnectionManagerFlatFileColumn100 endColumn = manager.Columns.Add();
			endColumn.ColumnType = "FixedWidth";
			endColumn.ColumnWidth = 1;
		}

		private ConnectionManager GetDefaultConnection()
		{
			ConnectionManager manager = CensusPackage.Connections.Add("ADO.NET:SQL");
			manager.ConnectionString = Program.DefaultConnectionString;
			manager.Name = "Default SSIS Connection Manager for ADO.NET";
			manager.Description = "ADO.NET Database connection to the default database";

			return manager;
		}

		public ConnectionManager GetFlatFileConnection<T>(string path, EntityTypeConfiguration<T> map, bool updateExisting = false) where T : class
		{
			if (string.IsNullOrWhiteSpace(path)
			    || !File.Exists(path))
			{
				throw new ArgumentException($"'{path}' is not a valid flat file path.");
			}

			bool exists = FlatFileConnections.ContainsKey(path);

			if (exists)
			{
				return FlatFileConnections[path];
			}

			ConnectionManager manager = CensusPackage.Connections.Add("FLATFILE");
			manager.ConnectionString = path;
			manager.Name = $"SSIS Flat File Connection Manager for {path}";
			manager.Description = $"Flat file connection to {path}";

			IDTSConnectionManagerFlatFile100 ffManager = manager.InnerObject as IDTSConnectionManagerFlatFile100;
			if (ffManager != null)
			{
				ffManager.AlwaysCheckForRowDelimiters = true;
				ffManager.ColumnNamesInFirstDataRow = false;
				ffManager.Unicode = false;
				ffManager.CodePage = CodePage;
				ffManager.LocaleID = LocaleID;
				ffManager.RowDelimiter = RowDelimiter;
				ffManager.Format = "FixedWidth";
				GetColumns(ref ffManager, map);
			}

			FlatFileConnections.Add(path, manager);

			return FlatFileConnections[path];
		}

		private void Initialize()
		{
			string testPackagePath = @"C:\Users\Anthony\Documents\Visual Studio 2013\Projects\GISSIS\GISSIS\Package.dtsx";

			CensusApplication = new Application();

			//CensusPackage = new Package();
			CensusPackage = CensusApplication.LoadPackage(testPackagePath, null);
			CensusConnections = CensusPackage.Connections;
			DefaultConnection = GetDefaultConnection();
			FlatFileConnections = new Dictionary<string, ConnectionManager>();
			CensusTasks = new Dictionary<string, Executable>();

			//var test = GetFlatFileConnection(@"F:\Output\algeo2010.sf1", new SummaryOne_GEO_HEADER_SF1Map());
		}

		private void PopulateTasks()
		{
			// TODO: 
			// TODO: 
			// TODO: 
			// TODO: 
			// TODO: 
			// TODO: 
			// TODO: 
			// TODO: 
			// TODO: 
			// TODO: 
			// TODO: 
			// TODO: 
			// TODO: 
		}
	}
}
