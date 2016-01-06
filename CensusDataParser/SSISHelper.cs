namespace CensusDataParser
{
	using System;
	using System.Collections.Generic;
	using System.Data.Entity.ModelConfiguration;
	using System.IO;
	using System.Linq;
	using Microsoft.SqlServer.Dts.Runtime;
	using Microsoft.SqlServer.Dts.Runtime.Wrapper;
	using Application = Microsoft.SqlServer.Dts.Runtime.Application;
	using Package = Microsoft.SqlServer.Dts.Runtime.Package;

	public class SSISHelper
	{
		public const int LocaleID = 1033;
		public const int CodePage = 1252;
		public const string RowDelimiter = @"\r\n";


		//public string OleDBConnectionString => $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={FilePath}";
		public Application CensusApplication { get; set; }
		public Package CensusPackage { get; set; }
		public Connections CensusConnections { get; set; }
		public ConnectionManager DefaultConnection { get; set; }
		public Dictionary<string, ConnectionManager> FlatFileConnections { get; set; }
		public Dictionary<string, Executable> CensusTasks { get; set; }

		public SSISHelper()
		{
			Initialize();
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
			if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
				throw new ArgumentException($"'{path}' is not a valid flat file path.");

			bool exists = FlatFileConnections.ContainsKey(path);

			if (exists)
				return FlatFileConnections[path];

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
				manager.Columns.Remove(column);

			IEnumerable<Tuple<string, int?, int?>> columnInfo = map.GetColumnInfo().OrderBy(o => o.Item2);

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

				if(!columnWidth.HasValue)
					throw new ArgumentException($"Invalid Column width on {column.Item1}");


				IDTSConnectionManagerFlatFileColumn100 ffColumn = manager.Columns.Add();
				ffColumn.DataType = column.Item3.HasValue ? DataType.DT_STR : DataType.DT_NUMERIC;
				ffColumn.ColumnType = "FixedWidth";
				ffColumn.ColumnWidth = columnWidth.Value;
				//ffColumn.MaximumWidth = ffColumn.ColumnWidth;
			}
			IDTSConnectionManagerFlatFileColumn100 endColumn = manager.Columns.Add();
			endColumn.ColumnType = "FixedWidth";
			endColumn.ColumnWidth = 1;
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
