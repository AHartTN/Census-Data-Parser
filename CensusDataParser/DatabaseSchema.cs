#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2015 4:24 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: DatabaseSchema.cs
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
	using System.Collections.Generic;
	using System.Configuration;
	using System.Linq;
	using Enumerators;
	#endregion

	public class DatabaseSchema
	{
		public string ClassString
		{
			get
			{
				string output = $"namespace {ContextNamespaceString}";
				output += "\r\n{";
				output += "\r\n\t#region Using Directives";
				output += "\r\n\tusing Binding;";
				output += "\r\n\tusing Mapping;";
				output += "\r\n\tusing System;";
				output += "\r\n\tusing System.Data.Entity;";
				output += "\r\n\t#endregion Using Directives";
				output += $"\r\n\r\n\tpublic class {Name} : DbContext";
				output += "\r\n\t{";
				output += $"\r\n\t\tpublic {Name}() : base(\"name={ConnectionName}\") {{ }}";
				output += $"\r\n{GroupedTablesString}";
				output += "\r\n\r\n\t\tprotected override void OnModelCreating(DbModelBuilder modelBuilder)\r\n\t\t{";
				output += GroupedTableMapsString;
				output += "\r\n\t\t}";
				output += CreateDatabaseMethodString;
				output += "\r\n\t}\r\n}";
				return output;
			}
		}

		public string ContextNamespaceString => $"{BaseNamespace}.{Namespace}.Context";

		public string CreateDatabaseMethodString
		{
			get
			{
				string output = "\r\n\r\n\t\tpublic static bool CreateDatabase()";
				output += "\r\n\t\t{";
				output += "\r\n\t\t\ttry";
				output += "\r\n\t\t\t{";
				output += $"\r\n\t\t\t\tusing (var db = new {Name}())";
				output += "\r\n\t\t\t\t{";
				output += "\r\n\t\t\t\t\treturn db.Database.Exists() || db.Database.CreateIfNotExists();";
				output += "\r\n\t\t\t\t}";
				output += "\r\n\t\t\t}";
				output += "\r\n\t\t\tcatch (Exception ex)";
				output += "\r\n\t\t\t{";
				output += "\r\n\t\t\t\tthrow new InvalidOperationException(\"The database could not be initialized!\", ex);";
				output += "\r\n\t\t\t}";
				output += "\r\n\t\t}";
				return output;
			}
		}

		public string GroupedTableMapsString => GroupedTables.Aggregate("", (current, table) => current + $"\r\n\t\t\t#region {table.Key}{table.Aggregate("", (c, t) => c + $"\r\n\t\t\tmodelBuilder.Configurations.Add(new {t.ClassName}Map());")}\r\n\t\t\t#endregion {table.Key}");

		private IEnumerable<IGrouping<CensusFileType, TableSchema>> GroupedTables => Tables.GroupBy(g => g.FileType);

		public string GroupedTablesString => GroupedTables.Aggregate("", (current, table) => current + $"\r\n\t\t#region {table.Key}{table.Aggregate("", (c, t) => c + $"\r\n\t\tpublic virtual DbSet<{t.ClassName}> {t.ClassName}Records {{ get; set; }}")}\r\n\t\t#endregion {table.Key}");
		public string TableMapsString => Tables.Aggregate("", (current, table) => current + $"\r\n\t\t\tmodelBuilder.Configurations.Add(new {table.ClassName}Map());");

		public string TablesString => Tables.Aggregate("", (current, table) => current + $"\r\n\t\tpublic virtual DbSet<{table.ClassName}> {table.ClassName}Records {{ get; set; }}");
		public string BaseNamespace { get; set; } = Program.BaseNamespace;
		public string ConnectionName { get; set; } = "DefaultConnection";
		public string Name { get; set; }
		public string Namespace { get; set; } = Program.Namespace;

		public IEnumerable<TableSchema> Tables { get; set; }
	}
}
