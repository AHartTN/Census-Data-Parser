#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/31/2015 2:56 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: TableSchema.cs
// 
// Anthony Hart ("ANTHONY") CONFIDENTIAL
// 
// Unpublished Copyright (c) 1985-2015 Anthony Hart, All Rights Reserved.
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
    using System.Configuration;
    using System.Data;
    using System.Linq;
    using Enumerators;
    using Extensions;
    #endregion

    public class TableSchema
    {
        public string UsingDirectivesString = UsingDirectives.Aggregate("#region Using Directives", (current, usingDirective) => current + $"\r\n\t\tusing {usingDirective};") + "\r\n\t\t#endregion Using Directives";
        public string AttributeString => string.Join("\r\n\t\t", AttributeStrings);

        public string[] AttributeStrings => new[] { $"[Table(\"{CleanName}\")]" };

        public string[] BaseConstructors => new[] { $"public {CleanName}(string csvLine) : base(csvLine) {{}}", $"public {CleanName}(string[] values) : base(values) {{}}" };
        public string BaseConstructorsString => string.Join("\r\n\r\n\t\t\t", BaseConstructors);

        public string CleanName
        {
            get
            {
                string tableName = Name.Replace("mod", "")
                                       .Replace(" ", "_");

                for (int i = 0; i < 100; i++)
                {
                    tableName = tableName.Replace($"PT{i}", "")
                                         .Replace($"PART{i}", "")
                                         .Replace($"Part{i}", "");
                }

                if (string.IsNullOrWhiteSpace(tableName))
                {
                    tableName = Name.Replace("mod", "")
                                    .Replace(" ", "_");
                }

                tableName = tableName.Trim('*', '_')
                                     .Trim();
                return tableName;
            }
        }

        public string DisplayName => CleanName.Replace("_", " ");

        public string FullName
        {
            get
            {
                string output = "";
                if (!string.IsNullOrWhiteSpace(Catalog)
                    && !string.IsNullOrWhiteSpace(Schema))
                {
                    output += $"{Catalog}.{Schema}.";
                }
                else if (string.IsNullOrWhiteSpace(Catalog)
                         && !string.IsNullOrWhiteSpace(Schema))
                {
                    output += $"{Schema}.";
                }
                else if (!string.IsNullOrWhiteSpace(Catalog)
                         && string.IsNullOrWhiteSpace(Schema))
                {
                    output += $"{Catalog}.dbo.";
                }
                output += CleanName;
                return output;
            }
        }

        public string HeaderString => $"public partial class {CleanName} : BaseModel";

        public string NamespaceString => $"namespace {Enum.GetName(typeof(CensusFileType), FileType)}";

        public string PropertiesString => string.Join("\r\n\r\n\t\t\t", Columns?.OrderBy(o => o.Index).Select(s => s?.ToString()) ?? new string[] { });

        public string ReaderConstructor => Columns?.Select((column, index) => new
        {
            Column = column,
            Index = index
        })
                                                   .Aggregate($"public {CleanName}(OleDbDataReader reader, CensusFileType fileType)\r\n\t\t\t{{", (current, a) => current + $"\r\n\t\t\t\tif(reader[{a.Index}] != DBNull.Value)\r\n\t\t\t\t{{\r\n\t\t\t\t\t{a.Column.CleanName} = ({a.Column.DataTypeString})reader[{a.Index}];\r\n\t\t\t\t}}") + "\r\n\t\t\t}";

        public string BaseNamespace { get; set; } = typeof(Program).Namespace;
        public string Catalog { get; set; } = ConfigurationManager.AppSettings["DefaultCatalog"];

        public IEnumerable<ColumnSchema> Columns { get; set; }

        public DateTime? Date_Created { get; set; }
        public DateTime? Date_Modified { get; set; }
        public string Description { get; set; }

        public CensusFileType FileType { get; set; }

        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Namespace { get; set; } = ConfigurationManager.AppSettings["DefaultNamespace"];

        public string PropID { get; set; }
        public string Schema { get; set; } = ConfigurationManager.AppSettings["DefaultSchema"];
        public string Type { get; set; }

        public static string[] UsingDirectives = { "System", "System.Collections.Generic", "System.ComponentModel", "System.ComponentModel.DataAnnotations", "System.ComponentModel.DataAnnotations.Schema", "System.Data.OleDb", "Enumerators" };

        public TableSchema()
        {
            // Empty constructor to ensure JSON operability
        }

        public TableSchema(CensusFileType fileType, DataRow row)
        {
            FileType = fileType;

            if (row[0] != DBNull.Value)
            {
                Catalog = (string)row[0];
            }
            if (row[1] != DBNull.Value)
            {
                Schema = (string)row[1];
            }
            if (row[2] != DBNull.Value)
            {
                Name = (string)row[2];
            }
            if (row[3] != DBNull.Value)
            {
                Type = (string)row[3];
            }
            if (row[4] != DBNull.Value)
            {
                Guid = (Guid)row[4];
            }
            if (row[5] != DBNull.Value)
            {
                Description = (string)row[5];
            }
            if (row[6] != DBNull.Value)
            {
                PropID = (string)row[6];
            }
            if (row[7] != DBNull.Value)
            {
                Date_Created = (DateTime?)row[7];
            }
            if (row[8] != DBNull.Value)
            {
                Date_Modified = (DateTime?)row[8];
            }
        }

        public TableSchema(string name, string catalog, IEnumerable<ColumnSchema> columns, string schema = "dbo")
        {
            if (string.IsNullOrWhiteSpace(name)
                || catalog.IsNullOrWhiteSpace())
            {
                throw new ArgumentException("Table must have a valid table name and catalog");
            }

            Name = name;
            Catalog = catalog;
            Schema = schema;
            Columns = columns;
            Date_Created = DateTime.UtcNow;
            Date_Modified = DateTime.UtcNow;
        }

        #region Overrides of Object
        /// <summary>
        ///     Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        ///     A string that represents the current object.
        /// </returns>
        public override string ToString() { return $"{NamespaceString}\r\n\t{{\r\n\t\t{UsingDirectivesString}\r\n\r\n\t\t{AttributeString}\r\n\t\t{HeaderString}\r\n\t\t{{\r\n\t\t\t#region Properties\r\n\t\t\t{PropertiesString}\r\n\t\t\t#endregion Properties\r\n\r\n\t\t\t#region Constructors\r\n\t\t\t{BaseConstructorsString}\r\n\r\n\t\t\t{ReaderConstructor}\r\n\t\t\t#endregion Constructors\r\n\t\t}}\r\n\t}}"; }
        #endregion
    }
}
