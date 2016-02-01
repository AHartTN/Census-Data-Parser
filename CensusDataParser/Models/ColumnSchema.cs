#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2016 3:36 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: ColumnSchema.cs
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
    using Helpers;
    using SF1;
    #endregion

    public class ColumnSchema
    {
        //public string AttributeString => GetAttributeString();
        public string AttributeString => $"[Display(Name = \"{DisplayName}\", ShortName = \"{DisplayName}\", Order = {Index})]";

        public string CleanBaseName => BaseName.Replace(" ", "_")
                                               .Trim('_', '*')
                                               .Trim();

        public string CleanName => Name.Replace(" ", "_")
                                       .Trim('_', '*')
                                       .Trim();

        public string DatabaseTypeString => DataType.ToString()
                                                    .Replace("System.", "")
                                                    .Replace("Nullable<", "")
                                                    .Replace(">", "")
                                                    .Replace("String", "NVARCHAR")
                                                    .Replace("Int16", "SMALLINT")
                                                    .Replace("Int32", "INT")
                                                    .Replace("Int64", "BIGINT")
                                                    .Replace("Guid", "UNIQUEIDENTIFIER")
                                                    .Replace("Boolean", "BIT")
                                                    .Replace("DateTime", "DATETIME")
                                                    .Replace("Double", "DECIMAL")
                                                    .ToUpperInvariant();

        public DATA_FIELD_DESCRIPTORS Descriptor => CensusDataHelper.DataDescriptors.FirstOrDefault(f => f.FIELD_CODE == Name);

        public string DescriptorName => Descriptor?.FIELD_NAME?.Trim('_')
                                                   .Trim();

        public string DisplayName => DescriptorName ?? GeoDescriptorName ?? CleanName.Replace("_", " ");

        public string FluentAPIMapString => GetFluentAPIMapString();

        public GeoHeader_Specifications GeoDescriptor => CensusDataHelper.GeoDataDescriptors.FirstOrDefault(f => f.DATA_DICTIONARY_REFERENCE == Name);

        public string GeoDescriptorName => GeoDescriptor?.FIELD?.Trim('_')
                                                         .Trim();

        public string PropertyString => $"public {TypeString} {CleanName} {{ get; set; }}";

        public string TypeString => DataType.ToString()
                                            .Replace("System.", "")
                                            .Replace("Nullable<", "")
                                            .Replace(">", "")
                                            .Replace("Boolean", "bool")
                                            .Replace("Byte", "byte")
                                            .Replace("Char", "char")
                                            .Replace("Decimal", "decimal")
                                            .Replace("Double", "decimal")
                                            .Replace("float", "float")
                                            .Replace("Int16", "short")
                                            .Replace("Int32", "int")
                                            .Replace("Int64", "long")
                                            .Replace("String", "string") + (!IsKey && !KeyColumns.Contains(CleanName) && AllowDbNull && DataType != typeof (string)
                                                                                ? "?"
                                                                                : "");

        public bool AllowDbNull { get; set; } = true;
        public string BaseCatalog { get; set; } = Program.BaseCatalog;

        public string BaseName { get; set; }
        public string BaseSchema { get; set; } = Program.BaseSchema;
        public string BaseTable { get; set; }

        public Type DataType { get; set; }
        public int Index { get; set; }
        public bool IsAutoIncrement { get; set; }
        public bool IsKey { get; set; }
        public bool IsLong { get; set; }
        public bool IsReadOnly { get; set; } = true;
        public bool IsRowVersion { get; set; }
        public bool IsUnique { get; set; }

        public string Name { get; set; }
        public short Precision { get; set; }
        public int ProviderType { get; set; }
        public short Scale { get; set; }
        public int Size { get; set; }
        public static readonly string[] KeyColumns = {"ID", "FILEID", "STUSAB", "CHARITER", "CIFSN", "LOGRECNO", "STUB", "ITEM", "SEGMENT", "DESC", "SORT_ID", "TABLE_NUMBER", "TABLE", "FIELD_CODE"};

        // Access file isn't perfect. We need to adjust the length of specific columns to ensure proper flat file importing
        public static Dictionary<string, int> CustomFieldLengths = new Dictionary<string, int>
                                                                   {
                                                                       {"LOGRECNO", 7},
                                                                       {"AREALAND", 14},
                                                                       {"AREAWATR", 14},
                                                                       {"POP100", 9},
                                                                       {"HU100", 9}
                                                                   };

        public ColumnSchema()
        {
            // Empty constructor to ensure JSON operability
        }

        public ColumnSchema(DataRow row)
        {
            if (row[0] != DBNull.Value)
            {
                Name = (string)row[0];
            }
            if (row[1] != DBNull.Value)
            {
                Index = (int)row[1];
            }
            if (row[2] != DBNull.Value)
            {
                Size = (int)row[2];
            }
            if (row[3] != DBNull.Value)
            {
                Precision = (short)row[3];
            }
            if (row[4] != DBNull.Value)
            {
                Scale = (short)row[4];
            }
            if (row[5] != DBNull.Value)
            {
                DataType = DataType == typeof (double)
                               ? typeof (decimal)
                               : (Type)row[5];
            }
            if (row[6] != DBNull.Value)
            {
                ProviderType = (int)row[6];
            }
            if (row[7] != DBNull.Value)
            {
                IsLong = (bool)row[7];
            }
            if (row[8] != DBNull.Value)
            {
                AllowDbNull = (bool)row[8];
            }
            if (row[9] != DBNull.Value)
            {
                IsReadOnly = (bool)row[9];
            }
            if (row[10] != DBNull.Value)
            {
                IsRowVersion = (bool)row[10];
            }
            if (row[11] != DBNull.Value)
            {
                IsUnique = (bool)row[11];
            }
            if (row[12] != DBNull.Value)
            {
                IsKey = (bool)row[12];
            }
            if (row[13] != DBNull.Value)
            {
                IsAutoIncrement = (bool)row[13];
            }
            if (row[14] != DBNull.Value)
            {
                BaseSchema = (string)row[14];
            }
            if (row[15] != DBNull.Value)
            {
                BaseCatalog = (string)row[15];
            }
            if (row[16] != DBNull.Value)
            {
                BaseTable = (string)row[16];
            }
            if (row[17] != DBNull.Value)
            {
                BaseName = (string)row[17];
            }

            if (IsLong)
            {
                DataType = typeof (long);
            }
            else if (Name == "AREALAND"
                     || Name == "AREAWATR")
            {
                DataType = typeof (string);
            }

            if (CustomFieldLengths.ContainsKey(Name))
            {
                Size = CustomFieldLengths[Name];
            }
        }

        public string GetAttributeString()
        {
            string output = "";

            if (IsKey || KeyColumns.Contains(CleanName))
            {
                output += "[Key]\r\n\t\t";
            }
            if (DataType == typeof (string))
            {
                output += $"[MaxLength({Size})]\r\n\t\t";
            }

            output += $"[ReadOnly({IsReadOnly.ToString() .ToLower()})]\r\n\t\t";
            output += $"[Column(\"{CleanName}\", Order = {Index})]\r\n\t\t";

            output += IsAutoIncrement
                          ? $"[DatabaseGenerated(DatabaseGeneratedOption.Identity)]\r\n\t\t"
                          : $"[DatabaseGenerated(DatabaseGeneratedOption.None)]\r\n\t\t";

            output += $"[Display(Name = \"{DisplayName}\", ShortName = \"{DisplayName}\", Order = {Index})]";

            return output;
        }

        public string GetFluentAPIMapString()
        {
            string output = $"\r\n\r\n\t\t\tProperty(p => p.{CleanName})";
            output += $"\r\n\t\t\t\t.HasColumnName(\"{CleanName}\")";
            output += $"\r\n\t\t\t\t.HasColumnOrder({Index})";
            output += $"\r\n\t\t\t\t.HasColumnType(\"{DatabaseTypeString}\")";
            output += $"\r\n\t\t\t\t.HasDatabaseGeneratedOption(DatabaseGeneratedOption.{(IsAutoIncrement ? "Identity" : "None")})";

            if (DataType == typeof (string))
            {
                output += $"\r\n\t\t\t\t.HasMaxLength({Size})";
            }

            output += $"\r\n\t\t\t\t.HasParameterName(\"{CleanName}\")";

            output += !IsKey && !KeyColumns.Contains(CleanName) && AllowDbNull
                          ? $"\r\n\t\t\t\t.IsOptional()"
                          : $"\r\n\t\t\t\t.IsRequired()";
            output += ";";

            return output;
        }

        public ColumnSchema SetIndex(int index)
        {
            Index = index;
            return this;
        }

        #region Overrides of Object
        /// <summary>
        ///     Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        ///     A string that represents the current object.
        /// </returns>
        public override string ToString() { return $"{AttributeString}\r\n\t\t{PropertyString}"; }
        #endregion
    }
}
