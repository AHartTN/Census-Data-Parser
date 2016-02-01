#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2016 3:36 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: AccessFile.cs
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
    using System.Data.OleDb;
    using System.Linq;
    using Enumerators;
    using Newtonsoft.Json;
    using SF1;
    using SF2;
    #endregion

    public class AccessFile
    {
        public List<string> SkipList = new List<string>();
        public OleDbConnection Connection => new OleDbConnection(ConnectionString);

        public string ConnectionString => $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={FilePath}";

        public IEnumerable<TableSchema> DataTableSchemas => TableSchemas.Where(w => !SkipList.Contains(w.Name))
                                                                        .Select(SetColumnSchemas);

        public IEnumerable<TableSchema> TableSchemas
        {
            get
            {
                using (OleDbConnection conn = Connection)
                {
                    conn.Open();
                    DataTable tableSchema = conn.GetSchema("Tables");
                    conn.Close();
                    IEnumerable<TableSchema> rows = tableSchema?.Rows?.Cast<DataRow>()
                                                                .Select(row => new TableSchema(FileType, row))
                                                                .Where(table => !table.Name.StartsWith("MSys"))
                                                                .OrderBy(o => o.Name);
                    return rows;
                }
            }
        }

        public string FilePath { get; set; }
        public CensusFileType FileType { get; set; }
        public const string CensusHeaderJson = "[{\"Name\":\"FILEID\", \"Index\":0, \"Size\":255, \"Precision\":255, \"Scale\":255, \"DataType\":\"System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\", \"ProviderType\":202, \"IsLong\":false, \"AllowDbNull\":true, \"IsReadOnly\":false, \"IsRowVersion\":false, \"IsUnique\":false, \"IsKey\":false, \"IsAutoIncrement\":false, \"BaseSchemaName\":null, \"BaseCatalogName\":null, \"BaseTableName\":null, \"BaseColumnName\":null, \"Descriptor\":null},{\"Name\":\"STUSAB\",\"Index\":1,\"Size\":255,\"Precision\":255,\"Scale\":255,\"DataType\":\"System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\",\"ProviderType\":202,\"IsLong\":false,\"AllowDbNull\":true,\"IsReadOnly\":false,\"IsRowVersion\":false,\"IsUnique\":false,\"IsKey\":false,\"IsAutoIncrement\":false,\"BaseSchemaName\":null,\"BaseCatalogName\":null,\"BaseTableName\":null,\"BaseColumnName\":null,\"Descriptor\":null},{\"Name\":\"CHARITER\",\"Index\":2,\"Size\":255,\"Precision\":255,\"Scale\":255,\"DataType\":\"System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\",\"ProviderType\":202,\"IsLong\":false,\"AllowDbNull\":true,\"IsReadOnly\":false,\"IsRowVersion\":false,\"IsUnique\":false,\"IsKey\":false,\"IsAutoIncrement\":false,\"BaseSchemaName\":null,\"BaseCatalogName\":null,\"BaseTableName\":null,\"BaseColumnName\":null,\"Descriptor\":null},{\"Name\":\"CIFSN\",\"Index\":3,\"Size\":255,\"Precision\":255,\"Scale\":255,\"DataType\":\"System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\",\"ProviderType\":202,\"IsLong\":false,\"AllowDbNull\":true,\"IsReadOnly\":false,\"IsRowVersion\":false,\"IsUnique\":false,\"IsKey\":false,\"IsAutoIncrement\":false,\"BaseSchemaName\":null,\"BaseCatalogName\":null,\"BaseTableName\":null,\"BaseColumnName\":null,\"Descriptor\":null}]";

        public AccessFile()
        {
            // Empty constructor to ensure JSON operability
        }

        public AccessFile(string filePath, CensusFileType fileType)
        {
            FilePath = filePath;
            FileType = fileType;
        }

        public IEnumerable<T> GetCollection<T>(string tableName) where T : new()
        {
            if (string.IsNullOrWhiteSpace(tableName))
            {
                return null;
            }

            List<T> items = new List<T>();
            string command = $"SELECT * FROM [{tableName}]";
            using (OleDbConnection conn = Connection)
            {
                using (OleDbCommand cmd = new OleDbCommand(command, conn))
                {
                    conn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();

                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            T item = (T)Activator.CreateInstance(typeof (T), reader, FileType);
                            items.Add(item);
                        }
                    }

                    conn.Close();
                }
            }
            return items;
        }

        public IEnumerable<ColumnSchema> GetColumnSchemas(string tableName)
        {
            if (string.IsNullOrWhiteSpace(tableName))
            {
                return null;
            }

            List<ColumnSchema> columnSchemas = new List<ColumnSchema>();

            if (tableName.EndsWith("mod"))
            {
                IEnumerable<ColumnSchema> columns = JsonConvert.DeserializeObject<IEnumerable<ColumnSchema>>(CensusHeaderJson);
                columnSchemas.AddRange(columns);
            }

            string command = $"SELECT TOP 1 * FROM [{tableName}] A";
            using (OleDbConnection conn = Connection)
            {
                using (OleDbCommand cmd = new OleDbCommand(command, conn))
                {
                    conn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    DataTable schema = reader?.GetSchemaTable();

                    if (schema == null)
                    {
                        conn.Close();
                        return null;
                    }

                    columnSchemas.AddRange(from DataRow row in schema.Rows select new ColumnSchema(row));

                    if (tableName.EndsWith("PT1")
                        || tableName.EndsWith("PART1")
                        || tableName.EndsWith("Part1"))
                    {
                        for (int i = 2; i <= TableSchemas.Count(); i++)
                        {
                            string tblName = tableName.Replace("PT1", $"PT{i}")
                                                      .Replace("PART1", $"PART{i}")
                                                      .Replace("Part1", $"Part{i}");

                            foreach (TableSchema table in TableSchemas.Where(w => w.Name.EndsWith(tblName)))
                            {
                                IEnumerable<ColumnSchema> columns = GetColumnSchemas(table.Name);
                                columns = columns.Skip(5);
                                columnSchemas.AddRange(columns);
                                SkipList.Add(table.Name);
                            }
                        }
                    }

                    conn.Close();

                    for (int i = 0; i < columnSchemas.Count; i++)
                    {
                        columnSchemas[i].Index = i;

                        switch (columnSchemas[i].Name)
                        {
                            case "P024006":
                                columnSchemas[i].Name = "P0240006";
                                break;
                            case "SDELEM":
                                columnSchemas[i].Name = "SDELM";
                                break;
                            default:
                                columnSchemas[i].Name = columnSchemas[i].Name.Trim();
                                break;
                        }

                        //   string[] skipFields = { "DESC", "DECIMAL", "FIELD", "ID", "ITEM", "ITERATIONS", "LEN", "NOTE", "SEGMENT", "SORT_ID", "STUB", "TABLE" };

                        //   if (columnSchemas[i].Descriptor == null
                        //&& columnSchemas[i].GeoDescriptor == null
                        //&& !columnSchemas[i].Name.Contains(" ")
                        //&& !skipFields.Contains(columnSchemas[i].Name.ToUpperInvariant()))
                        //   {
                        //       Console.WriteLine($"Column missing Descriptors: {columnSchemas[i]}");
                        //   }
                    }

                    return columnSchemas;
                }
            }
        }

        public TableSchema SetColumnSchemas(TableSchema schema)
        {
            if (schema == null)
            {
                return null;
            }

            schema.Columns = GetColumnSchemas(schema.Name);
            return schema;
        }

        #region Overrides of Object
        /// <summary>
        ///     Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        ///     A string that represents the current object.
        /// </returns>
        public override string ToString() { return $"{FileType} | {FilePath}"; }
        #endregion

        #region Tables

        #region TableGroup
        public string TableGroupTable => FileType == CensusFileType.SummaryTwo
                                             ? "*Table Names"
                                             : null;

        public IEnumerable<Table_Names> TableGroups => GetCollection<Table_Names>(TableGroupTable);
        #endregion TableGroup

        #region DataDescriptorsTable
        public string DataDescriptorsTable => FileType == CensusFileType.Redistricting || FileType == CensusFileType.DemographicProfile
                                                  ? "Table"
                                                  : FileType == CensusFileType.SummaryOne || FileType == CensusFileType.SF1CongressionalDistricts113
                                                        ? "DATA_FIELD_DESCRIPTORS"
                                                        : FileType == CensusFileType.SummaryTwo
                                                              ? "DataDictionary"
                                                              : null;

        public IEnumerable<DATA_FIELD_DESCRIPTORS> DataDescriptors => GetCollection<DATA_FIELD_DESCRIPTORS>(DataDescriptorsTable);
        #endregion DataDescriptorsTable

        #region DataDescriptorNotesTable
        public string DataDescriptorNotesTable => FileType == CensusFileType.SummaryTwo
                                                      ? "DataDictionary_NOTES"
                                                      : null;

        public IEnumerable<DataDictionary_NOTES> DataDescriptorNotes => GetCollection<DataDictionary_NOTES>(DataDescriptorNotesTable);
        #endregion DataDescriptorNotesTable

        #region GeoDescriptorsTable
        public string GeoDescriptorsTable => FileType == CensusFileType.Redistricting
                                                 ? "header"
                                                 : FileType == CensusFileType.DemographicProfile
                                                       ? "Header"
                                                       : FileType == CensusFileType.SummaryTwo
                                                             ? "GeoHeader_Specifications"
                                                             : null;

        public IEnumerable<GeoHeader_Specifications> GeoDataDescriptors => GetCollection<GeoHeader_Specifications>(GeoDescriptorsTable);
        #endregion GeoDescriptorsTable

        #region GeoTable
        public string GeoTable => FileType == CensusFileType.Redistricting
                                      ? "PL_Geo_Header"
                                      : FileType == CensusFileType.DemographicProfile
                                            ? "Geo_Header"
                                            : FileType == CensusFileType.SummaryOne
                                                  ? "GEO_HEADER_SF1"
                                                  : FileType == CensusFileType.SummaryTwo
                                                        ? "SF2_GeoHeader"
                                                        : FileType == CensusFileType.SF1CongressionalDistricts113
                                                              ? "GEO_HEADER_SF1"
                                                              : null;

        public IEnumerable<ColumnSchema> GeocolumnSchemas => GetColumnSchemas(GeoTable);
        #endregion GeoTable

        #region IterationsTable
        public string IterationsTable => FileType == CensusFileType.SummaryTwo
                                             ? "Iterations_List"
                                             : null;

        public IEnumerable<Iterations_List> Iterations => GetCollection<Iterations_List>(IterationsTable);
        #endregion IterationsTable

        #region IterationNotesTable
        public string IterationNotesTable => FileType == CensusFileType.SummaryTwo
                                                 ? "Iterations_NOTES"
                                                 : null;

        public IEnumerable<Iterations_NOTES> IterationNotes => GetCollection<Iterations_NOTES>(IterationNotesTable);
        #endregion IterationNotesTable

        #endregion Tables
    }
}
