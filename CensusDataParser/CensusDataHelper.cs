#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2015 4:24 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: CensusDataHelper.cs
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
	using System.CodeDom;
	using System.Collections.Generic;
	using System.Configuration;
	using System.Data;
	using System.Data.Entity.ModelConfiguration;
	using System.Data.SqlClient;
	using System.IO;
	using System.IO.Compression;
	using System.Linq;
	using Enumerators;
	using Extensions;
	using Generated.Binding;
	using Generated.Context;
	using Generated.Mapping;
	using Helpers;
	using Microsoft.SqlServer.Server;
	using Models.SF1;
	#endregion

	public class CensusDataHelper : BaseModel
	{
		#region Properties

		#region Helpers
		public static SSISHelper SSISApp = new SSISHelper();
		public static RawCensusDataEntities DB = new RawCensusDataEntities();
		#endregion Helpers

		#region Archive Paths
		public static readonly string[] DataArchivePaths = { CensusDataPaths.AssembledSummary1Path, CensusDataPaths.AssembledSummary2Path };
		public static readonly string[] AllDataArchivePaths = { CensusDataPaths.AssembledRedistrictingPath, CensusDataPaths.AssembledDemographicProfilePath, CensusDataPaths.AssembledSummary1Path, CensusDataPaths.AssembledSummary2Path, CensusDataPaths.AssembledCongressionalDistrictsPath };
		#endregion Archive Paths

		#region Access Files
		public static readonly AccessFile CongressionalDistrictsAccessFile = new AccessFile(CensusDataPaths.CongressionalDistrictsAccessFile, CensusFileType.SF1CongressionalDistricts113);
		public static readonly AccessFile DemographicProfileAccessFile = new AccessFile(CensusDataPaths.DemographicProfileAccessFile, CensusFileType.DemographicProfile);
		public static readonly AccessFile RedistrictingAccessFile = new AccessFile(CensusDataPaths.RedistrictingAccessFile, CensusFileType.Redistricting);
		public static readonly AccessFile Summary1AccessFile = new AccessFile(CensusDataPaths.Summary1AccessFile, CensusFileType.SummaryOne);
		public static readonly AccessFile Summary2AccessFile = new AccessFile(CensusDataPaths.Summary2AccessFile, CensusFileType.SummaryTwo);
		#endregion Access Files

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
		public static readonly IEnumerable<FileInfo> DataArchives = DataArchivePaths.SelectMany(s => new DirectoryInfo(s).EnumerateFiles("*.zip", SearchOption.AllDirectories));

		public static Dictionary<string, IEnumerable<ZipArchiveEntry>> DemographicProfileDataArchives => DataArchives.Where(dataArchive => dataArchive.Name.Split('.')[1].ToUpperInvariant() == CensusFileType.DemographicProfile.GetShortName())
																													 .ToDictionary(dataArchive => dataArchive.Name.Split('.')[0].Substring(0, 2), dataArchive => ZipFile.OpenRead(dataArchive.FullName)
																																																						.Entries.Where(w => !w.Name.EndsWith(".txt")));

		public static Dictionary<string, IEnumerable<ZipArchiveEntry>> RedistrictingDataArchives => DataArchives.Where(dataArchive => dataArchive.Name.Split('.')[1].ToUpperInvariant() == CensusFileType.Redistricting.GetShortName())
																												.ToDictionary(dataArchive => dataArchive.Name.Split('.')[0].Substring(0, 2), dataArchive => ZipFile.OpenRead(dataArchive.FullName)
																																																				   .Entries.Where(w => !w.Name.EndsWith(".txt")));

		public static Dictionary<string, IEnumerable<ZipArchiveEntry>> CongressionalDistrictDataArchives => DataArchives.Where(dataArchive => dataArchive.Name.Split('.')[1].ToUpperInvariant() == CensusFileType.SF1CongressionalDistricts113.GetShortName())
																														.ToDictionary(dataArchive => dataArchive.Name.Split('.')[0].Substring(0, 2), dataArchive => ZipFile.OpenRead(dataArchive.FullName)
																																																						   .Entries.Where(w => !w.Name.EndsWith(".txt")));

		public static Dictionary<string, IEnumerable<ZipArchiveEntry>> Summary1DataFiles => DataArchives.Where(dataArchive => dataArchive.Name.Split('.')[1].ToUpperInvariant() == CensusFileType.SummaryOne.GetShortName())
																										.ToDictionary(dataArchive => dataArchive.Name.Split('.')[0].Substring(0, 2), dataArchive => ZipFile.OpenRead(dataArchive.FullName)
																																																		   .Entries.Where(w => !w.Name.EndsWith(".txt")));

		public static Dictionary<string, IEnumerable<ZipArchiveEntry>> Summary2DataFiles => DataArchives.Where(dataArchive => dataArchive.Name.Split('.')[1].ToUpperInvariant() == CensusFileType.SummaryTwo.GetShortName())
																										.ToDictionary(dataArchive => dataArchive.Name.Split('.')[0].Substring(0, 2), dataArchive => ZipFile.OpenRead(dataArchive.FullName)
																																																		   .Entries.Where(w => !w.Name.EndsWith(".txt")));

		public static Dictionary<string, IEnumerable<ZipArchiveEntry>> UrbanUpdateDataArchives => DataArchives.Where(dataArchive => dataArchive.Name.Split('.')[1].ToUpperInvariant() == CensusFileType.UrbanAreaUpdate.GetShortName())
																											  .ToDictionary(dataArchive => dataArchive.Name.Split('.')[0].Substring(0, 2), dataArchive => ZipFile.OpenRead(dataArchive.FullName)
																																																				 .Entries.Where(w => !w.Name.EndsWith(".txt")));
		#endregion

		#region AllData Archives
		public static readonly IEnumerable<FileInfo> AllDataArchives = AllDataArchivePaths.SelectMany(s => new DirectoryInfo(s).EnumerateFiles("*.zip", SearchOption.AllDirectories));

		public static Dictionary<string, IEnumerable<ZipArchiveEntry>> AllDemographicProfileDataArchives => AllDataArchives.Where(dataArchive => dataArchive.Name.Split('.')[1].ToUpperInvariant() == CensusFileType.DemographicProfile.GetShortName())
																														   .ToDictionary(dataArchive => dataArchive.Name.Split('.')[0].Substring(0, 2), dataArchive => ZipFile.OpenRead(dataArchive.FullName)
																																																							  .Entries.Where(w => !w.Name.EndsWith(".txt")));

		public static Dictionary<string, IEnumerable<ZipArchiveEntry>> AllRedistrictingDataArchives => AllDataArchives.Where(dataArchive => dataArchive.Name.Split('.')[1].ToUpperInvariant() == CensusFileType.Redistricting.GetShortName())
																													  .ToDictionary(dataArchive => dataArchive.Name.Split('.')[0].Substring(0, 2), dataArchive => ZipFile.OpenRead(dataArchive.FullName)
																																																						 .Entries.Where(w => !w.Name.EndsWith(".txt")));

		public static Dictionary<string, IEnumerable<ZipArchiveEntry>> AllCongressionalDistrictDataArchives => AllDataArchives.Where(dataArchive => dataArchive.Name.Split('.')[1].ToUpperInvariant() == CensusFileType.SF1CongressionalDistricts113.GetShortName())
																															  .ToDictionary(dataArchive => dataArchive.Name.Split('.')[0].Substring(0, 2), dataArchive => ZipFile.OpenRead(dataArchive.FullName)
																																																								 .Entries.Where(w => !w.Name.EndsWith(".txt")));

		public static Dictionary<string, IEnumerable<ZipArchiveEntry>> AllSummary1DataFiles => AllDataArchives.Where(dataArchive => dataArchive.Name.Split('.')[1].ToUpperInvariant() == CensusFileType.SummaryOne.GetShortName())
																											  .ToDictionary(dataArchive => dataArchive.Name.Split('.')[0].Substring(0, 2), dataArchive => ZipFile.OpenRead(dataArchive.FullName)
																																																				 .Entries.Where(w => !w.Name.EndsWith(".txt")));

		public static Dictionary<string, IEnumerable<ZipArchiveEntry>> AllSummary2DataFiles => AllDataArchives.Where(dataArchive => dataArchive.Name.Split('.')[1].ToUpperInvariant() == CensusFileType.SummaryTwo.GetShortName())
																											  .ToDictionary(dataArchive => dataArchive.Name.Split('.')[0].Substring(0, 2), dataArchive => ZipFile.OpenRead(dataArchive.FullName)
																																																				 .Entries.Where(w => !w.Name.EndsWith(".txt")));

		public static Dictionary<string, IEnumerable<ZipArchiveEntry>> AllUrbanUpdateDataArchives => AllDataArchives.Where(dataArchive => dataArchive.Name.Split('.')[1].ToUpperInvariant() == CensusFileType.UrbanAreaUpdate.GetShortName())
																													.ToDictionary(dataArchive => dataArchive.Name.Split('.')[0].Substring(0, 2), dataArchive => ZipFile.OpenRead(dataArchive.FullName)
																																																					   .Entries.Where(w => !w.Name.EndsWith(".txt")));
		#endregion AllData Archives

		#region Data Files

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
		#endregion Data Files

		#endregion Properties

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
				case CensusFileType.UrbanAreaUpdate:
					Console.WriteLine($"{fileType} is not supported as there is no access file outlining the CSV schemas.");
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(fileType), fileType, null);
			}
		}

		public static void ProcessRedistrictingFileData() { }

		public static void ProcessDemographicProfileFileData() { }

		public static void ProcessSummary1FileData()
		{
			string fileTypeName = CensusFileType.SummaryOne.GetName();
			string fileTypeShortName = CensusFileType.SummaryOne.GetShortName();

			foreach (KeyValuePair<string, IEnumerable<ZipArchiveEntry>> file in Summary1DataFiles)
			{
				Console.WriteLine($"{file.Key} | {file.Value.Count()} files");
				foreach (ZipArchiveEntry entry in file.Value)
				{
					Console.WriteLine($"Processing {entry.FullName}");
					Console.WriteLine($"\t{entry.Name} | {entry.CompressedLength} | {entry.Length} | {entry.LastWriteTime}");

					bool isGeo = entry.Name.ToLowerInvariant()
									  .Contains("geo");
					string name = isGeo ? GetGeoType(CensusFileType.SummaryOne)
										: entry.Name.Replace("20101", "")
													.Replace("2010", "")
													.Replace($".{CensusFileType.SummaryOne.GetShortName().ToLowerInvariant()}", "")
													.Replace(file.Key, $"{fileTypeShortName}_");

					string outputFilePath = $"{Program.OutputPath}\\{entry.Name}";

					string tableName = $"[{Program.DefaultDatabase}].[{fileTypeName}].[{name}]";


					int rowsAffected = 0;

					if (isGeo)
					{
						if (!File.Exists(outputFilePath))
						{
							using (StreamReader sr = new StreamReader(entry.Open()))
							{
								using (FileStream sw = File.Create(outputFilePath))
								{
									Console.Write($"Copying file to {outputFilePath}. . . Please wait!");
									sr.BaseStream.CopyTo(sw);
								}

							}
						}

						Console.WriteLine($"\rFile copied successfully.\t\t\t\t\t");
						Console.Write($"\rProcessing {entry.Name} as a Flat File into {tableName}\t\t\t\t\t");
						string mapName = $"{Program.BaseNamespace}.{Program.Namespace}.Mapping.{fileTypeName}_{name}Map";

						Type mapType = Type.GetType(mapName);
						dynamic map = mapType == null ? null : Activator.CreateInstance(mapType);

						SSISApp.AddFlatFileConnection(outputFilePath, map);
						SSISApp.CensusApplication.SaveToXml(@"C:\Users\Anthony\Documents\Visual Studio 2013\Projects\GISSIS\GISSIS\Package.dtsx", SSISApp.CensusPackage, null);
					}
					else
					{
						rowsAffected += 0; //SqlHelper.BulkCSVInsert(tableName, outputFilePath);
					}
					Console.WriteLine($"\r{rowsAffected} records affected from processing {entry.Name} into {tableName}\t\t\t\t\t");

					// TODO: toggle between flat file and csv formatting from here


					//if (File.Exists(outputFilePath))
					//File.Delete(outputFilePath);
				}
			}
		}


		public static string GetGeoType(CensusFileType fileType)
		{
			switch (fileType)
			{
				case CensusFileType.Redistricting:
					return "PL_Geo_Header";
				case CensusFileType.DemographicProfile:
					return "Geo_Header";
				case CensusFileType.SummaryOne:
				case CensusFileType.SF1CongressionalDistricts113:
					return "GEO_HEADER_SF1";
				case CensusFileType.SummaryTwo:
					return "GeoHeader_Specifications";
				case CensusFileType.UrbanAreaUpdate:
				case CensusFileType.AdvanceGroupQuarters:
				case CensusFileType.IslandAreas_DPSF:
				case CensusFileType.AIANSummaryFile:
				case CensusFileType.IslandAreas_IASF:
				case CensusFileType.IslandAreasDetailedCrossTabulations:
				case CensusFileType.IslandAreas_PUMS:
				case CensusFileType.Stateside_PUMS:
					return null;
				default:
					throw new ArgumentOutOfRangeException(nameof(fileType), fileType, null);
			}
		}

		public static void ProcessSummary2FileData() { }

		public static void ProcessCongressionalDistrictsFileData() { }
		#endregion Data Retrieval

		#region Schema Retrieval
		public static IEnumerable<string> GetSchemaStrings() { return AllTableSchemas.Select(schema => schema.ToString()); }

		public static void OutputSchemaStrings(bool outputToConsole = true, string directory = null, bool allTables = false)
		{
			string outputPath = Program.OutputPath;

			DatabaseSchema dbSchema = new DatabaseSchema
			{
				Name = "RawCensusDataEntities",
				Tables = allTables
													   ? AllTableSchemas
													   : TableSchemas
			};

			if (!string.IsNullOrWhiteSpace(directory))
			{
				FileHelper.WriteToFile(new FileInfo($"{outputPath}\\Context\\{dbSchema.Name}.cs"), dbSchema.ClassString);
			}

			foreach (TableSchema tableSchema in dbSchema.Tables)
			{
				if (!string.IsNullOrWhiteSpace(directory))
				{
					FileHelper.WriteToFile(new FileInfo($"{outputPath}\\Binding\\{tableSchema.ClassName}.cs"), tableSchema.ClassString);
					FileHelper.WriteToFile(new FileInfo($"{outputPath}\\Mapping\\{tableSchema.ClassName}Map.cs"), tableSchema.MappingString);
				}

				if (outputToConsole)
				{
					Console.WriteLine(tableSchema.ClassString);
					Console.WriteLine(tableSchema.MappingString);
				}
			}
		}
		#endregion Schema Retrieval
	}
}
