﻿#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 1:14 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: CensusDataParser.cs
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
    using System.IO;
    using System.Linq;
    using Helpers;
    #endregion

    public class CensusDataParser
    {
        public static readonly CensusFile CongressionalDistrictsFile = new CensusFile(CensusDataURLs.CongressionalDistrictsAccessFile, CensusFileType.SF1CongressionalDistricts113);
        public static readonly CensusFile DemographicProfileFile = new CensusFile(CensusDataURLs.DemographicProfileAccessFile, CensusFileType.DemographicProfile);
        public static readonly CensusFile RedistrictingFile = new CensusFile(CensusDataURLs.RedistrictingAccessFile, CensusFileType.Redistricting);
        public static readonly CensusFile Summary1File = new CensusFile(CensusDataURLs.Summary1AccessFile, CensusFileType.SummaryOne);
        public static readonly CensusFile Summary2File = new CensusFile(CensusDataURLs.Summary2AccessFile, CensusFileType.SummaryTwo);

        public static string GetSchemaString()
        {
            string output = GetSchemaStrings()
                                .Aggregate("namespace CensusDataParser\r\n{\r\nusing System.ComponentModel.DataAnnotation;\r\n\r\n", (current, schemaString) => current + $"\r\n{schemaString}") + "\r\n}";

            return output;
        }

        public static IEnumerable<string> GetSchemaStrings()
        {
            //IEnumerable<KeyValuePair<string, IEnumerable<TableColumn>>> Tables = Summary1File.DataTables.Union(Summary2File.DataTables);
            //IEnumerable<KeyValuePair<string, IEnumerable<TableColumn>>> AllTables = RedistrictingFile.DataTables.Union(DemographicProfileFile.DataTables)
            //                                                                                         .Union(Summary1File.DataTables)
            //                                                                                         .Union(Summary2File.DataTables)
            //                                                                                         .Union(CongressionalDistrictsFile.DataTables);
            foreach (KeyValuePair<string, IEnumerable<TableColumn>> table in AllTables)
            {
                IEnumerable<TableColumn> columns = SetColumnDescriptors(table.Value.OrderBy(o => o.Index));

                string tableName = table.Key.Replace("mod", "")
                                        .Replace(" ", "_")
                                        .Trim('*', '_')
                                        .Trim();

                for (int i = 0; i < 100; i++)
                {
                    tableName = tableName.Replace($"PT{i}", "")
                                         .Replace($"PART{i}", "");
                }

                tableName = tableName.Trim();

                if (string.IsNullOrWhiteSpace(tableName))
                {
                    tableName = table.Key.Replace("mod", "")
                                     .Replace(" ", "_")
                                     .Trim('*', '_')
                                     .Trim();
                }

                string output = columns.Aggregate($"public class {tableName}\r\n{{", (current, column) => current + $"\r\n{column}") + "\r\n}";
                yield return output;
            }
        }

        public static void OutputSchemaStrings(bool outputToConsole = true, string filePath = null)
        {
            string schemaString = GetSchemaString();
            if (!string.IsNullOrWhiteSpace(filePath))
            {
                FileInfo file = new FileInfo(filePath);

                if (file.Exists)
                {
                    file.Delete();
                }

                FileHelper.AppendToFile(file, schemaString);
            }

            if (outputToConsole)
            {
                Console.WriteLine(schemaString);
            }
        }

        public static readonly IEnumerable<KeyValuePair<string, IEnumerable<TableColumn>>> Tables = Summary1File.DataTables.Union(Summary2File.DataTables);

        public static readonly IEnumerable<KeyValuePair<string, IEnumerable<TableColumn>>> AllTables = RedistrictingFile.DataTables.Union(DemographicProfileFile.DataTables)
                                                                                                 .Union(Summary1File.DataTables)
                                                                                                 .Union(Summary2File.DataTables)
                                                                                                 .Union(CongressionalDistrictsFile.DataTables);

        public static IEnumerable<DATA_FIELD_DESCRIPTORS> DataDescriptors = RedistrictingFile.DataDescriptors.Union(DemographicProfileFile.DataDescriptors)
                                                                                                 .Union(Summary1File.DataDescriptors)
                                                                                                 .Union(Summary2File.DataDescriptors)
                                                                                                 .Union(CongressionalDistrictsFile.DataDescriptors);

        public static IEnumerable<GeoHeader_Specifications> GeoDataDescriptors = RedistrictingFile.GeoDataDescriptors.Union(DemographicProfileFile.GeoDataDescriptors)
                                                                                                 .Union(Summary2File.GeoDataDescriptors);

        public static IEnumerable<TableColumn> SetColumnDescriptors(IEnumerable<TableColumn> columns)
        {
            //IEnumerable<DATA_FIELD_DESCRIPTORS> DataDescriptors = RedistrictingFile.DataDescriptors.Union(DemographicProfileFile.DataDescriptors)
            //                                                                       .Union(Summary1File.DataDescriptors)
            //                                                                       .Union(Summary2File.DataDescriptors)
            //                                                                       .Union(CongressionalDistrictsFile.DataDescriptors);
            //IEnumerable<GeoHeader_Specifications> GeoDataDescriptors = RedistrictingFile.GeoDataDescriptors.Union(DemographicProfileFile.GeoDataDescriptors)
            //                                                                            .Union(Summary2File.GeoDataDescriptors);

            DATA_FIELD_DESCRIPTORS[] dataDescriptors = DataDescriptors.ToArray();
            GeoHeader_Specifications[] geoDataDescriptors = GeoDataDescriptors.ToArray();

            foreach (TableColumn column in columns)
            {
                if (column.Name == "P024006")
                {
                    column.Name = "P0240006";
                }
                else if (column.Name == "SDELEM")
                {
                    column.Name = "SDELM";
                }
                else
                {
                    column.Name = column.Name.Trim();
                }

                column.Descriptor = dataDescriptors?.FirstOrDefault(f => string.Equals(f.FIELD_CODE?.Trim(), column.Name?.Trim(), StringComparison.OrdinalIgnoreCase));
                column.GeoDescriptor = geoDataDescriptors?.FirstOrDefault(f => string.Equals(f.DATA_DICTIONARY_REFERENCE?.Trim(), column.Name?.Trim(), StringComparison.OrdinalIgnoreCase));

                string[] skipFields = { "DESC", "DECIMAL", "FIELD", "ID", "ITEM", "ITERATIONS", "LEN", "NOTE", "SEGMENT", "SORT_ID", "STUB", "TABLE" };

                if (column.Descriptor == null
                    && column.GeoDescriptor == null
                    && !column.Name.Contains(" ")
                    && !skipFields.Contains(column.Name.ToUpperInvariant()))
                {
                    Console.WriteLine($"Column missing Descriptors: {column}");
                }

                yield return column;
            }
        }
    }
}
