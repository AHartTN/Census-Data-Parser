#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2016 3:35 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: TableSchema.cs
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

namespace CensusDataParser.Models
{
    #region Using Directives
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Enumerators;
    using Extensions;
    #endregion

    public class TableSchema
    {
        public string[] BaseConstructors => new[] {$"public {ClassName}() {{ }}", $"public {ClassName}(string csvLine) : base(csvLine) {{ }}", $"public {ClassName}(string[] values) : base(values) {{ }}"};
        public string BaseConstructorsString => string.Join("\r\n\r\n\t\t", BaseConstructors);

        public string BindingBaseNamespaceString => $"{BaseNamespace}.{Namespace}.Binding";

        public string BindingHeaderString => $"public class {ClassName} : BaseModel";
        public string BindingNamespaceString => $"{BindingBaseNamespaceString}";

        public string ClassName => $"{FileTypeString}_{CleanName}";

        public string ClassString
        {
            get
            {
                string output = $"namespace {BindingNamespaceString}";
                output += "\r\n{";
                output += $"\r\n\t{UsingDirectivesString}";
                output += $"\r\n\r\n\t{BindingHeaderString}";
                output += "\r\n\t{\r\n\t\t#region Properties";
                output += $"\r\n\t\t{PropertiesString}";
                output += "\r\n\t\t#endregion Properties\r\n\r\n\t\t#region Constructors";
                output += $"\r\n\t\t{BaseConstructorsString}";
                output += $"\r\n\r\n\t\t{ReaderConstructor}";
                output += "\r\n\t\t#endregion Constructors";
                output += "\r\n\t}\r\n}";
                return output;
            }
        }

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
        public string FileTypeString => FileType.GetName();

        public string FluentAPIPropertyStrings => Columns.Aggregate("", (current, column) => current + column.FluentAPIMapString);

        public string MappingBaseNamespaceString => $"{BaseNamespace}.{Namespace}.Mapping";
        public string MappingHeaderString => $"public class {ClassName}Map : EntityTypeConfiguration<{ClassName}>";

        public string MappingKeyString => string.Join(", ", Columns.Where(w => w.IsKey || ColumnSchema.KeyColumns.Contains(w.CleanName))
                                                                   .Select(s => $"k.{s.CleanName}"));

        public string MappingNamespaceString => $"{MappingBaseNamespaceString}";

        public string MappingString
        {
            get
            {
                string output = $"namespace {MappingNamespaceString}";
                output += "\r\n{";
                output += $"\r\n\t{UsingDirectivesString}";
                output += $"\r\n\r\n\t{MappingHeaderString}";
                output += "\r\n\t{";
                output += $"\r\n\t\tpublic {ClassName}Map()";
                output += "\r\n\t\t{";
                output += $"\r\n\t\t\tToTable(\"{CleanName}\", \"{FileTypeString}\");";
                if (!string.IsNullOrWhiteSpace(MappingKeyString))
                {
                    output += $"\r\n\r\n\t\t\tHasKey(k => new {{{MappingKeyString}}});";
                }
                output += FluentAPIPropertyStrings;
                output += "\r\n\t\t}\r\n\t}\r\n}";
                return output;
            }
        }

        public string PropertiesString => string.Join("\r\n\r\n\t\t", Columns?.OrderBy(o => o.Index)
                                                                              .Select(s => s?.ToString()) ?? new string[] {});

        public string ReaderConstructor => Columns?.Select((column, index) => new
                                                                              {
                                                                                  Column = column,
                                                                                  Index = index
                                                                              })
                                                   .Aggregate($"public {ClassName}(OleDbDataReader reader)\r\n\t\t{{", (current, a) => current + $"\r\n\t\t\tif(reader[{a.Index}] != DBNull.Value)\r\n\t\t\t{{\r\n\t\t\t\t{a.Column.CleanName} = ({a.Column.TypeString})reader[{a.Index}];\r\n\t\t\t}}") + "\r\n\t\t}";

        public string[] UsingDirectives => new[] {"System", "System.Collections.Generic", "System.ComponentModel", "System.ComponentModel.DataAnnotations", "System.ComponentModel.DataAnnotations.Schema", "System.Data.Entity", "System.Data.Entity.ModelConfiguration", "System.Data.OleDb", "Enumerators", BindingNamespaceString.Replace($"{BaseNamespace}.", ""), MappingNamespaceString.Replace($"{BaseNamespace}.", ""), "Models"};

        public string UsingDirectivesString => UsingDirectives.Aggregate("#region Using Directives", (current, usingDirective) => current + $"\r\n\tusing {usingDirective};") + "\r\n\t#endregion Using Directives";

        public string BaseNamespace { get; set; } = Program.BaseNamespace;
        public string Catalog { get; set; } = Program.BaseCatalog;

        public IEnumerable<ColumnSchema> Columns { get; set; }

        public DateTime? Date_Created { get; set; }
        public DateTime? Date_Modified { get; set; }
        public string Description { get; set; }

        public CensusFileType FileType { get; set; }

        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Namespace { get; set; } = Program.Namespace;

        public string PropID { get; set; }
        public string Schema { get; set; } = Program.BaseSchema;
        public string Type { get; set; }

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
    }
}
