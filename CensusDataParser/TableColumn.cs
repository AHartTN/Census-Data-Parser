#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 1:38 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: TableColumn.cs
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
    using System.Data;
    #endregion

    public class TableColumn
    {
        public bool AllowDbNull { get; set; }
        public string BaseCatalogName { get; set; }
        public string BaseColumnName { get; set; }
        public string BaseSchemaName { get; set; }
        public string BaseTableName { get; set; }
        public Type DataType { get; set; }
        public DATA_FIELD_DESCRIPTORS Descriptor { get; set; }
        public GeoHeader_Specifications GeoDescriptor { get; set; }
        public int Index { get; set; }
        public bool IsAutoIncrement { get; set; }
        public bool IsKey { get; set; }
        public bool IsLong { get; set; }
        public bool IsReadOnly { get; set; }
        public bool IsRowVersion { get; set; }
        public bool IsUnique { get; set; }
        public string Name { get; set; }
        public short Precision { get; set; }
        public int ProviderType { get; set; }
        public short Scale { get; set; }
        public int Size { get; set; }

        public TableColumn()
        {
            // Empty constructor to ensure JSON operability
        }

        public TableColumn(DataRow row)
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
                DataType = (Type)row[5];
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
                BaseSchemaName = (string)row[14];
            }
            if (row[15] != DBNull.Value)
            {
                BaseCatalogName = (string)row[15];
            }
            if (row[16] != DBNull.Value)
            {
                BaseTableName = (string)row[16];
            }
            if (row[17] != DBNull.Value)
            {
                BaseColumnName = (string)row[17];
            }
        }

        public TableColumn SetIndex(int index)
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
        public override string ToString()
        {
            string columnName = Name.Replace(" ", "_")
                                    .Trim('_', '*')
                                    .Trim();
            string displayName = Descriptor?.FIELD_NAME.Trim('_')
                                            .Trim() ?? GeoDescriptor?.FIELD.Trim('_')
                                                                     .Trim() ?? Name;
            string dataType = AllowDbNull
                                  ? $"System.Nullable<{DataType}>"
                                  : $"{DataType}";

            string attributeString = $"[Display(Name = \"{displayName}\", ShortName = \"{displayName}\", Order = {Index}){(IsKey ? ", Key" : "")}]";
            string propertyString = $"public {dataType} {columnName} {{ get; set; }}";
            return $"\t{attributeString}\r\n\t{propertyString}";
        }
        #endregion
    }
}
