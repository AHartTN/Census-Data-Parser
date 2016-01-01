#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/31/2015 2:56 PM
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
    using System.IO.Compression;
    using System.Linq;
    using Enumerators;
    using Helpers;
    using Models.SF1;
    #endregion

    public class CensusDataParser : BaseModel
    {
        #region Properties

        #region Archive Paths
        public static readonly string[] DataFilePaths = {CensusDataPaths.AssembledSummary1Path, CensusDataPaths.AssembledSummary2Path};
        public static readonly string[] AllDataArchivePaths = {CensusDataPaths.AssembledRedistrictingPath, CensusDataPaths.AssembledDemographicProfilePath, CensusDataPaths.AssembledSummary1Path, CensusDataPaths.AssembledSummary2Path, CensusDataPaths.AssembledCongressionalDistrictsPath};
        #endregion Archive Paths

        #region Census File Category Schemas
        public static readonly AccessFile CongressionalDistrictsAccessFile = new AccessFile(CensusDataPaths.CongressionalDistrictsAccessFile, CensusFileType.SF1CongressionalDistricts113);
        public static readonly AccessFile DemographicProfileAccessFile = new AccessFile(CensusDataPaths.DemographicProfileAccessFile, CensusFileType.DemographicProfile);
        public static readonly AccessFile RedistrictingAccessFile = new AccessFile(CensusDataPaths.RedistrictingAccessFile, CensusFileType.Redistricting);
        public static readonly AccessFile Summary1AccessFile = new AccessFile(CensusDataPaths.Summary1AccessFile, CensusFileType.SummaryOne);
        public static readonly AccessFile Summary2AccessFile = new AccessFile(CensusDataPaths.Summary2AccessFile, CensusFileType.SummaryTwo);
        #endregion Census File Category Schemas

        #region Schema Structures
        public static readonly IEnumerable<TableSchema> TableSchemas = Summary1AccessFile.DataTableSchemas.Union(Summary2AccessFile.DataTableSchemas);

        public static readonly IEnumerable<TableSchema> AllTableSchemas = RedistrictingAccessFile.DataTableSchemas.Union(DemographicProfileAccessFile.DataTableSchemas)
                                                                                                 .Union(Summary1AccessFile.DataTableSchemas)
                                                                                                 .Union(Summary2AccessFile.DataTableSchemas)
                                                                                                 .Union(CongressionalDistrictsAccessFile.DataTableSchemas);

        public static readonly IEnumerable<DATA_FIELD_DESCRIPTORS> DataDescriptors = RedistrictingAccessFile.DataDescriptors.Union(DemographicProfileAccessFile.DataDescriptors)
                                                                                                            .Union(Summary1AccessFile.DataDescriptors)
                                                                                                            .Union(Summary2AccessFile.DataDescriptors)
                                                                                                            .Union(CongressionalDistrictsAccessFile.DataDescriptors);

        public static readonly IEnumerable<GeoHeader_Specifications> GeoDataDescriptors = RedistrictingAccessFile.GeoDataDescriptors.Union(DemographicProfileAccessFile.GeoDataDescriptors)
                                                                                                                 .Union(Summary2AccessFile.GeoDataDescriptors);
        #endregion Schema Structures

        #region Data Archives
        public static readonly IEnumerable<FileInfo> DataArchives = DataFilePaths.SelectMany(s => new DirectoryInfo(s).EnumerateFiles("*.zip", SearchOption.AllDirectories));

        public static readonly IEnumerable<FileInfo> CongressionalDistrictDataArchives = DataArchives.Where(w => DataFilePaths.Aggregate(w.FullName, (current, dataPath) => current.Replace(dataPath, ""))
                                                                                                                              .Trim('\\')
                                                                                                                              .Trim()
                                                                                                                              .Split('\\')[1].Split('.')[1] == "s13");

        public static readonly IEnumerable<FileInfo> DemographicProfileDataArchives = DataArchives.Where(w => DataFilePaths.Aggregate(w.FullName, (current, dataPath) => current.Replace(dataPath, ""))
                                                                                                                           .Trim('\\')
                                                                                                                           .Trim()
                                                                                                                           .Split('\\')[1].Split('.')[1] == "dp");

        public static readonly IEnumerable<FileInfo> RedistrictingDataArchives = DataArchives.Where(w => DataFilePaths.Aggregate(w.FullName, (current, dataPath) => current.Replace(dataPath, ""))
                                                                                                                      .Trim('\\')
                                                                                                                      .Trim()
                                                                                                                      .Split('\\')[1].Split('.')[1] == "pl");

        public static readonly IEnumerable<FileInfo> Summary1DataArchives = DataArchives.Where(w => DataFilePaths.Aggregate(w.FullName, (current, dataPath) => current.Replace(dataPath, ""))
                                                                                                                 .Trim('\\')
                                                                                                                 .Trim()
                                                                                                                 .Split('\\')[1].Split('.')[1] == "sf1");

        public static readonly IEnumerable<FileInfo> Summary2DataArchives = DataArchives.Where(w => DataFilePaths.Aggregate(w.FullName, (current, dataPath) => current.Replace(dataPath, ""))
                                                                                                                 .Trim('\\')
                                                                                                                 .Trim()
                                                                                                                 .Split('\\')[1].Split('.')[1] == "sf2");

        public static readonly IEnumerable<FileInfo> UrbanUpdateDataArchives = DataArchives.Where(w => DataFilePaths.Aggregate(w.FullName, (current, dataPath) => current.Replace(dataPath, ""))
                                                                                                                    .Trim('\\')
                                                                                                                    .Trim()
                                                                                                                    .Split('\\')[1].Split('.')[1] == "ur1");
        #endregion

        #region AllData Archives
        public static readonly IEnumerable<FileInfo> AllDataArchives = AllDataArchivePaths.SelectMany(s => new DirectoryInfo(s).EnumerateFiles("*.zip", SearchOption.AllDirectories));

        public static readonly IEnumerable<FileInfo> AllCongressionalDistrictDataArchives = AllDataArchives.Where(w => AllDataArchivePaths.Aggregate(w.FullName, (current, dataPath) => current.Replace(dataPath, ""))
                                                                                                                                          .Trim('\\')
                                                                                                                                          .Trim()
                                                                                                                                          .Split('\\')[1].Split('.')[1] == "s13");

        public static readonly IEnumerable<FileInfo> AllDemographicProfileDataArchives = AllDataArchives.Where(w => AllDataArchivePaths.Aggregate(w.FullName, (current, dataPath) => current.Replace(dataPath, ""))
                                                                                                                                       .Trim('\\')
                                                                                                                                       .Trim()
                                                                                                                                       .Split('\\')[1].Split('.')[1] == "dp");

        public static readonly IEnumerable<FileInfo> AllRedistrictingDataArchives = AllDataArchives.Where(w => AllDataArchivePaths.Aggregate(w.FullName, (current, dataPath) => current.Replace(dataPath, ""))
                                                                                                                                  .Trim('\\')
                                                                                                                                  .Trim()
                                                                                                                                  .Split('\\')[1].Split('.')[1] == "pl");

        public static readonly IEnumerable<FileInfo> AllSummary1DataArchives = AllDataArchives.Where(w => AllDataArchivePaths.Aggregate(w.FullName, (current, dataPath) => current.Replace(dataPath, ""))
                                                                                                                             .Trim('\\')
                                                                                                                             .Trim()
                                                                                                                             .Split('\\')[1].Split('.')[1] == "sf1");

        public static readonly IEnumerable<FileInfo> AllSummary2DataArchives = AllDataArchives.Where(w => AllDataArchivePaths.Aggregate(w.FullName, (current, dataPath) => current.Replace(dataPath, ""))
                                                                                                                             .Trim('\\')
                                                                                                                             .Trim()
                                                                                                                             .Split('\\')[1].Split('.')[1] == "sf2");

        public static readonly IEnumerable<FileInfo> AllUrbanUpdateDataArchives = AllDataArchives.Where(w => AllDataArchivePaths.Aggregate(w.FullName, (current, dataPath) => current.Replace(dataPath, ""))
                                                                                                                                .Trim('\\')
                                                                                                                                .Trim()
                                                                                                                                .Split('\\')[1].Split('.')[1] == "ur1");
        #endregion AllData Archives

        //#region Data Files
        //public static readonly List<Tuple<string, string, IEnumerable<ZipArchiveEntry>>> RedistrictingDataFiles = (from file in RedistrictingDataArchives
        //                                                                                                           select file.FullName
        //                                                                                                           into fullFileName
        //                                                                                                           let aggregatedFileName = DataFilePaths.Aggregate(fullFileName, (current, dataPath) => current.Replace(dataPath, ""))
        //                                                                                                                                                 .Trim('\\')
        //                                                                                                                                                 .Trim()
        //                                                                                                           let state = aggregatedFileName.Split('\\')[0]
        //                                                                                                           let fileName = aggregatedFileName.Split('\\')[1]
        //                                                                                                           let name = fileName.Split('.')[0]
        //                                                                                                           let archive = ZipFile.OpenRead(fullFileName)
        //                                                                                                           let entries = archive.Entries
        //                                                                                                           select new Tuple<string, string, IEnumerable<ZipArchiveEntry>>(name.Replace("2010", ""), state.Replace("_", ""), entries)).ToList();

        //public static readonly List<Tuple<string, string, IEnumerable<ZipArchiveEntry>>> DemographicProfileDataFiles = (from file in DemographicProfileDataArchives
        //                                                                                                                select file.FullName
        //                                                                                                                into fullFileName
        //                                                                                                                let aggregatedFileName = DataFilePaths.Aggregate(fullFileName, (current, dataPath) => current.Replace(dataPath, ""))
        //                                                                                                                                                      .Trim('\\')
        //                                                                                                                                                      .Trim()
        //                                                                                                                let state = aggregatedFileName.Split('\\')[0]
        //                                                                                                                let fileName = aggregatedFileName.Split('\\')[1]
        //                                                                                                                let name = fileName.Split('.')[0]
        //                                                                                                                let archive = ZipFile.OpenRead(fullFileName)
        //                                                                                                                let entries = archive.Entries
        //                                                                                                                select new Tuple<string, string, IEnumerable<ZipArchiveEntry>>(name.Replace("2010", ""), state.Replace("_", ""), entries)).ToList();

        //public static readonly List<Tuple<string, string, IEnumerable<ZipArchiveEntry>>> Summary1DataFiles = (from file in Summary1DataArchives
        //                                                                                                      select file.FullName
        //                                                                                                      into fullFileName
        //                                                                                                      let aggregatedFileName = DataFilePaths.Aggregate(fullFileName, (current, dataPath) => current.Replace(dataPath, ""))
        //                                                                                                                                            .Trim('\\')
        //                                                                                                                                            .Trim()
        //                                                                                                      let state = aggregatedFileName.Split('\\')[0]
        //                                                                                                      let fileName = aggregatedFileName.Split('\\')[1]
        //                                                                                                      let name = fileName.Split('.')[0]
        //                                                                                                      let archive = ZipFile.OpenRead(fullFileName)
        //                                                                                                      let entries = archive.Entries
        //                                                                                                      select new Tuple<string, string, IEnumerable<ZipArchiveEntry>>(name.Replace("2010", ""), state.Replace("_", ""), entries)).ToList();

        //public static readonly List<Tuple<string, string, IEnumerable<ZipArchiveEntry>>> Summary2DataFiles = (from file in Summary2DataArchives
        //                                                                                                      select file.FullName
        //                                                                                                      into fullFileName
        //                                                                                                      let aggregatedFileName = DataFilePaths.Aggregate(fullFileName, (current, dataPath) => current.Replace(dataPath, ""))
        //                                                                                                                                            .Trim('\\')
        //                                                                                                                                            .Trim()
        //                                                                                                      let state = aggregatedFileName.Split('\\')[0]
        //                                                                                                      let fileName = aggregatedFileName.Split('\\')[1]
        //                                                                                                      let name = fileName.Split('.')[0]
        //                                                                                                      let archive = ZipFile.OpenRead(fullFileName)
        //                                                                                                      let entries = archive.Entries
        //                                                                                                      select new Tuple<string, string, IEnumerable<ZipArchiveEntry>>(name.Replace("2010", ""), state.Replace("_", ""), entries)).ToList();

        //public static readonly List<Tuple<string, string, IEnumerable<ZipArchiveEntry>>> CongressionalDistrictDataFiles = (from file in CongressionalDistrictDataArchives
        //                                                                                                                   select file.FullName
        //                                                                                                                   into fullFileName
        //                                                                                                                   let aggregatedFileName = DataFilePaths.Aggregate(fullFileName, (current, dataPath) => current.Replace(dataPath, ""))
        //                                                                                                                                                         .Trim('\\')
        //                                                                                                                                                         .Trim()
        //                                                                                                                   let state = aggregatedFileName.Split('\\')[0]
        //                                                                                                                   let fileName = aggregatedFileName.Split('\\')[1]
        //                                                                                                                   let name = fileName.Split('.')[0]
        //                                                                                                                   let archive = ZipFile.OpenRead(fullFileName)
        //                                                                                                                   let entries = archive.Entries
        //                                                                                                                   select new Tuple<string, string, IEnumerable<ZipArchiveEntry>>(name.Replace("2010", ""), state.Replace("_", ""), entries)).ToList();
        //#endregion Data Files
        #endregion

        #region Data Retrieval
        public static void ProcessData(CensusFileType fileType)
        {
            switch (fileType)
            {
                case CensusFileType.Redistricting:
                    ProcessRedistrictingFileData();
                    break;
                case CensusFileType.DemographicProfile:
                    ProcessDemographicProfileFileData();
                    break;
                case CensusFileType.SummaryOne:
                    ProcessSummary1FileData();
                    break;
                case CensusFileType.SummaryTwo:
                    ProcessSummary2FileData();
                    break;
                case CensusFileType.SF1CongressionalDistricts113:
                    ProcessCongressionalDistrictsFileData();
                    break;
                case CensusFileType.AdvanceGroupQuarters:
                case CensusFileType.IslandAreas_DPSF:
                case CensusFileType.AIANSummaryFile:
                case CensusFileType.IslandAreas_IASF:
                case CensusFileType.IslandAreasDetailedCrossTabulations:
                case CensusFileType.IslandAreas_PUMS:
                case CensusFileType.Stateside_PUMS:
                    Console.WriteLine($"{fileType} is not supported as there is no access file outlining the CSV schemas.");
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(fileType), fileType, null);
            }
        }

        public static void ProcessRedistrictingFileData()
        {
            List<Tuple<string, string, IEnumerable<ZipArchiveEntry>>> RedistrictingDataFiles = (from file in RedistrictingDataArchives
                                                                                                select file.FullName
                                                                                                into fullFileName
                                                                                                let aggregatedFileName = DataFilePaths.Aggregate(fullFileName, (current, dataPath) => current.Replace(dataPath, ""))
                                                                                                                                      .Trim('\\')
                                                                                                                                      .Trim()
                                                                                                let state = aggregatedFileName.Split('\\')[0]
                                                                                                let fileName = aggregatedFileName.Split('\\')[1]
                                                                                                let name = fileName.Split('.')[0]
                                                                                                let archive = ZipFile.OpenRead(fullFileName)
                                                                                                let entries = archive.Entries
                                                                                                select new Tuple<string, string, IEnumerable<ZipArchiveEntry>>(name.Replace("2010", ""), state.Replace("_", ""), entries)).ToList();

            foreach (Tuple<string, string, IEnumerable<ZipArchiveEntry>> file in RedistrictingDataFiles)
            {
                Console.WriteLine($"{file.Item1} | {file.Item2} | {file.Item3.Count()}");
                foreach (ZipArchiveEntry entry in file.Item3)
                {
                    Console.WriteLine($"\t{entry.Name} | {entry.CompressedLength} | {entry.Length} | {entry.LastWriteTime}");

                    //using (StreamReader sr = new StreamReader(entry.Open()))
                    //{
                    //    while (!sr.EndOfStream)
                    //    {

                    //    }
                    //}
                }
            }
        }

        public static void ProcessDemographicProfileFileData()
        {
            List<Tuple<string, string, IEnumerable<ZipArchiveEntry>>> DemographicProfileDataFiles = (from file in DemographicProfileDataArchives
                                                                                                     select file.FullName
                                                                                                     into fullFileName
                                                                                                     let aggregatedFileName = DataFilePaths.Aggregate(fullFileName, (current, dataPath) => current.Replace(dataPath, ""))
                                                                                                                                           .Trim('\\')
                                                                                                                                           .Trim()
                                                                                                     let state = aggregatedFileName.Split('\\')[0]
                                                                                                     let fileName = aggregatedFileName.Split('\\')[1]
                                                                                                     let name = fileName.Split('.')[0]
                                                                                                     let archive = ZipFile.OpenRead(fullFileName)
                                                                                                     let entries = archive.Entries
                                                                                                     select new Tuple<string, string, IEnumerable<ZipArchiveEntry>>(name.Replace("2010", ""), state.Replace("_", ""), entries)).ToList();

            foreach (Tuple<string, string, IEnumerable<ZipArchiveEntry>> file in DemographicProfileDataFiles)
            {
                Console.WriteLine($"{file.Item1} | {file.Item2} | {file.Item3.Count()}");
                foreach (ZipArchiveEntry entry in file.Item3)
                {
                    Console.WriteLine($"\t{entry.Name} | {entry.CompressedLength} | {entry.Length} | {entry.LastWriteTime}");

                    //using (StreamReader sr = new StreamReader(entry.Open()))
                    //{
                    //    while (!sr.EndOfStream)
                    //    {

                    //    }
                    //}
                }
            }
        }

        public static void ProcessSummary1FileData()
        {
            List<Tuple<string, string, IEnumerable<ZipArchiveEntry>>> Summary1DataFiles = (from file in Summary1DataArchives
                                                                                           select file.FullName
                                                                                           into fullFileName
                                                                                           let aggregatedFileName = DataFilePaths.Aggregate(fullFileName, (current, dataPath) => current.Replace(dataPath, ""))
                                                                                                                                 .Trim('\\')
                                                                                                                                 .Trim()
                                                                                           let state = aggregatedFileName.Split('\\')[0]
                                                                                           let fileName = aggregatedFileName.Split('\\')[1]
                                                                                           let name = fileName.Split('.')[0]
                                                                                           let archive = ZipFile.OpenRead(fullFileName)
                                                                                           let entries = archive.Entries
                                                                                           select new Tuple<string, string, IEnumerable<ZipArchiveEntry>>(name.Replace("2010", ""), state.Replace("_", ""), entries)).ToList();

            foreach (Tuple<string, string, IEnumerable<ZipArchiveEntry>> file in Summary1DataFiles)
            {
                Console.WriteLine($"{file.Item1} | {file.Item2} | {file.Item3.Count()}");
                foreach (ZipArchiveEntry entry in file.Item3)
                {
                    Console.WriteLine($"\t{entry.Name} | {entry.CompressedLength} | {entry.Length} | {entry.LastWriteTime}");

                    //using (StreamReader sr = new StreamReader(entry.Open()))
                    //{
                    //    while (!sr.EndOfStream)
                    //    {

                    //    }
                    //}
                }
            }
        }

        public static void ProcessSummary2FileData()
        {
            List<Tuple<string, string, IEnumerable<ZipArchiveEntry>>> Summary2DataFiles = (from file in Summary2DataArchives
                                                                                           select file.FullName
                                                                                           into fullFileName
                                                                                           let aggregatedFileName = DataFilePaths.Aggregate(fullFileName, (current, dataPath) => current.Replace(dataPath, ""))
                                                                                                                                 .Trim('\\')
                                                                                                                                 .Trim()
                                                                                           let state = aggregatedFileName.Split('\\')[0]
                                                                                           let fileName = aggregatedFileName.Split('\\')[1]
                                                                                           let name = fileName.Split('.')[0]
                                                                                           let archive = ZipFile.OpenRead(fullFileName)
                                                                                           let entries = archive.Entries
                                                                                           select new Tuple<string, string, IEnumerable<ZipArchiveEntry>>(name.Replace("2010", ""), state.Replace("_", ""), entries)).ToList();

            foreach (Tuple<string, string, IEnumerable<ZipArchiveEntry>> file in Summary2DataFiles)
            {
                Console.WriteLine($"{file.Item1} | {file.Item2} | {file.Item3.Count()}");
                foreach (ZipArchiveEntry entry in file.Item3)
                {
                    Console.WriteLine($"\t{entry.Name} | {entry.CompressedLength} | {entry.Length} | {entry.LastWriteTime}");

                    //using (StreamReader sr = new StreamReader(entry.Open()))
                    //{
                    //    while (!sr.EndOfStream)
                    //    {

                    //    }
                    //}
                }
            }
        }

        public static void ProcessCongressionalDistrictsFileData()
        {
            List<Tuple<string, string, IEnumerable<ZipArchiveEntry>>> CongressionalDistrictDataFiles = (from file in CongressionalDistrictDataArchives
                                                                                                        select file.FullName
                                                                                                        into fullFileName
                                                                                                        let aggregatedFileName = DataFilePaths.Aggregate(fullFileName, (current, dataPath) => current.Replace(dataPath, ""))
                                                                                                                                              .Trim('\\')
                                                                                                                                              .Trim()
                                                                                                        let state = aggregatedFileName.Split('\\')[0]
                                                                                                        let fileName = aggregatedFileName.Split('\\')[1]
                                                                                                        let name = fileName.Split('.')[0]
                                                                                                        let archive = ZipFile.OpenRead(fullFileName)
                                                                                                        let entries = archive.Entries
                                                                                                        select new Tuple<string, string, IEnumerable<ZipArchiveEntry>>(name.Replace("2010", ""), state.Replace("_", ""), entries)).ToList();
            foreach (Tuple<string, string, IEnumerable<ZipArchiveEntry>> file in CongressionalDistrictDataFiles)
            {
                Console.WriteLine($"{file.Item1} | {file.Item2} | {file.Item3.Count()}");
                foreach (ZipArchiveEntry entry in file.Item3)
                {
                    Console.WriteLine($"\t{entry.Name} | {entry.CompressedLength} | {entry.Length} | {entry.LastWriteTime}");

                    //using (StreamReader sr = new StreamReader(entry.Open()))
                    //{
                    //    while (!sr.EndOfStream)
                    //    {

                    //    }
                    //}
                }
            }
        }
        #endregion Data Retrieval

        #region Schema Retrieval
        public static string GetSchemaString()
        {
            string rootNamespace = typeof (Program).Namespace;
            string namespaceString = $"namespace {rootNamespace}.Generated";
            string usingDirectives = "\t#region Using Directives\r\n\tusing System;\r\n\tusing System.Collections.Generic;\r\n\tusing System.ComponentModel.DataAnnotations;\r\n\tusing System.ComponentModel.DataAnnotations.Schema;\r\n\tusing System.Data.OleDb;\r\n\tusing Enumerators;\r\n\t#endregion";

            IEnumerable<string> schemaStrings = GetSchemaStrings();
            string output = schemaStrings.Aggregate($"{namespaceString}\r\n{{\r\n", (current, schemaString) => current + $"\r\n\r\n\t{schemaString}") + "\r\n}";

            return output;
        }

        private static IEnumerable<string> GetSchemaStrings() { return TableSchemas.Select(schema => schema.ToString()); }

        public static void OutputSchemaString(bool outputToConsole = true, string filePath = null)
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

        //public static IEnumerable<ColumnSchema> SetColumnDescriptors(IEnumerable<ColumnSchema> columns)
        //{
        //    DATA_FIELD_DESCRIPTORS[] dataDescriptors = DataDescriptors.ToArray();
        //    GeoHeader_Specifications[] geoDataDescriptors = GeoDataDescriptors.ToArray();

        //    foreach (ColumnSchema column in columns)
        //    {
        //        switch (column.Name)
        //        {
        //            case "P024006":
        //                column.Name = "P0240006";
        //                break;
        //            case "SDELEM":
        //                column.Name = "SDELM";
        //                break;
        //            default:
        //                column.Name = column.Name.Trim();
        //                break;
        //        }

        //        column.Descriptor = dataDescriptors.FirstOrDefault(f => string.Equals(f.FIELD_CODE?.Trim(), column.Name, StringComparison.OrdinalIgnoreCase));
        //        column.GeoDescriptor = geoDataDescriptors.FirstOrDefault(f => string.Equals(f.DATA_DICTIONARY_REFERENCE?.Trim(), column.Name, StringComparison.OrdinalIgnoreCase));

        //        string[] skipFields = { "DESC", "DECIMAL", "FIELD", "ID", "ITEM", "ITERATIONS", "LEN", "NOTE", "SEGMENT", "SORT_ID", "STUB", "TABLE" };

        //        if (column.Descriptor == null
        //            && column.GeoDescriptor == null
        //            && !column.Name.Contains(" ")
        //            && !skipFields.Contains(column.Name.ToUpperInvariant()))
        //        {
        //            Console.WriteLine($"Column missing Descriptors: {column}");
        //        }

        //        yield return column;
        //    }
        //}
        #endregion Schema Retrieval
    }
}
