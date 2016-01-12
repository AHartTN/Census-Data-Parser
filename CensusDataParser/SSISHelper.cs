#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/06/2016 4:44 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SSISHelper.cs
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
	using System;
	using System.Collections.Generic;
	using System.Configuration;
	using System.Data.Entity.ModelConfiguration;
	using System.IO;
	using System.Linq;
	using Extensions;
	using Microsoft.SqlServer.Dts.Runtime;
	using Microsoft.SqlServer.Dts.Runtime.Wrapper;
	using Application = Microsoft.SqlServer.Dts.Runtime.Application;
	using DTSPackageType = Microsoft.SqlServer.Dts.Runtime.DTSPackageType;
	using Package = Microsoft.SqlServer.Dts.Runtime.Package;

	public class SSISHelper
	{
		#region Extensions
		public static string ConnectionManagerExtension => ConfigurationManager.AppSettings["SSISConnectionManagerExtension"].Trim('.');
		public static string ProjectFileExtension => ConfigurationManager.AppSettings["SSISProjectFileExtension"].Trim('.');
		public static string PackageFileExtension => ConfigurationManager.AppSettings["SSISPackageFileExtension"].Trim('.');
		#endregion Extensions

		#region Project Path Properties
		public static string ProjectDirectoryPath => ConfigurationManager.AppSettings["SSISProjectFilePath"].Trim('\\');
		public static string ProjectFileName => ConfigurationManager.AppSettings["SSISProjectFileName"];
		public static string FullProjectFileName => $"{ProjectFileName}.{ProjectFileExtension}";
		public static string FullProjectFilePath => $"{ProjectDirectoryPath}\\{FullProjectFileName}";
		#endregion Project Path Properties

		#region Package Path Properties
		public static string PackageDirectoryPath => ConfigurationManager.AppSettings["SSISPackageFilePath"].Trim('\\');
		public static string PackageFileName => ConfigurationManager.AppSettings["SSISPackageFileName"];
		public static string FullPackageFileName => $"{PackageFileName}.{PackageFileExtension}";
		public static string FullPackageFilePath => $"{PackageDirectoryPath}\\{FullPackageFileName}";
		#endregion Package Path Properties

		#region Output Properties
		public static string CensusProjectDirectoryPath => $"{Program.OutputPath}\\Projects";
		public static string CensusProjectFilePath => $"{CensusProjectDirectoryPath}\\{FullProjectFileName}";

		public static string CensusPackageDirectoryPath => $"{Program.OutputPath}\\Packages";
		public static string CensusPackageFilePath => $"{CensusPackageDirectoryPath}\\{FullPackageFileName}";
		#endregion

		#region Not Implemented Yet
		public static string CensusTasksDirectoryPath => $"{Program.OutputPath}\\Tasks";
		public static string CensusEventsDirectoryPath => $"{Program.OutputPath}\\Events";
		#endregion Not Implemented Yet

		#region Full Paths
		//public static string ProjectFilePath => FullProjectFilePath;
		//public static string PackageFilePath => FullPackageFilePath;
		public static string ProjectFilePath => CensusProjectFilePath;
		public static string PackageFilePath => CensusPackageFilePath;
		#endregion

		#region Stream Names
		public static string DefaultConnectionStreamName = $"{DefaultConnectionName}.{ConnectionManagerExtension}";
		public static string DefaultPackageStreamName = $"{PackageFileName}.{PackageFileExtension}";
		public static string DefaultProjectStreamName = $"{ProjectFileName}.{ProjectFileExtension}";
		#endregion

		#region Constants/Defaults
		public const int CodePage = 1252;
		public const int LocaleID = 1033;
		public const string RowDelimiter = "\r\n";
		public const string ColumnDelimiter = ",";
		public const string ProjectName = "Anthony Hart's 2010 Census Data Parser";
		public const string ProjectDescription = "This SSIS Project was automatically generated and/or updated via Anthony Hart's 2010 US Census Data Parser (http://www.github.com/ahartrc/census-data-parser)";
		public const string DefaultPackageName = "Census Data Package";
		public const string DefaultPackageDescription = "This is the default package for parsing the 2010 Census data. All necessary functionality is located within this package.";
		public const string DefaultConnectionName = "Default SSIS Connection for ADO.NET";
		public const string DefaultConnectionDescription = "Provides an ADO.NET database connection to the default database as outlined in the connection string specified in the configuration file";
		//public string OleDBConnectionString => $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={FilePath}";
		#endregion Constants/Defaults

		public FileInfo ProjectFileInfo => new FileInfo(ProjectFilePath);
		public FileInfo PackageFileInfo => new FileInfo(PackageFilePath);

		public Application CensusApplication { get; set; }
		public Package CensusPackage { get; set; }
		public Connections CensusPackageConnections => CensusPackage.Connections;
		public ConnectionManager DefaultConnection => CensusPackageConnections[DefaultConnectionName];

		public ConnectionManagerItem SourceConnection { get; set; }
		public ConnectionManagerItem DestinationConnection { get; set; }

		public SSISHelper() { Initialize(); }

		private void Initialize()
		{
			CensusApplication = new Application(); // Needed?

			bool packageInitialized = InitializePackage();
			Console.WriteLine(packageInitialized
								  ? "Package Initialized successfully"
								  : "The package has failed to initialize!");

			if (!packageInitialized)
				throw new Exception("Unable to initialize project! Project necessary to continue!");

			InitializeTasks();


			//bool projectInitialized = InitializeProject();
			//Console.WriteLine(projectInitialized
			//					  ? "Project Initialized successfully"
			//					  : "The project has failed to initialize!");

			//if (!projectInitialized)
			//	throw new Exception("Unable to initialize project! Project necessary to continue!");

			Save();
		}

		//private bool InitializeProject()
		//{
		//	bool success = false;
		//	try
		//	{
		//		FileInfo filePath = new FileInfo(ProjectFilePath);

		//		if (filePath.Directory == null)
		//		{
		//			throw new DirectoryNotFoundException($"The directory provided in the project file path does not appear to be a valid directory.");
		//		}

		//		if (!filePath.Directory.Exists)
		//			filePath.Directory.Create();

		//		CensusProject = filePath.Exists
		//							? Project.OpenProject(ProjectFilePath, Project.AccessMode.ReadWrite, null, new DefaultEvents())
		//							: Project.CreateProject(ProjectFilePath);

		//		CensusProject.Name = ProjectName;
		//		CensusProject.CreatorName = "Anthony Hart";
		//		CensusProject.Description = ProjectDescription;

		//		CensusProject.Save();

		//		success = CensusProject == null;
		//	}
		//	catch (Exception e)
		//	{
		//		Console.WriteLine(e);
		//	}
		//	finally
		//	{
		//		Console.WriteLine($"Project Initialization: {(success ? "Succeeded" : "Failed")}");
		//	}
		//	return success;
		//}

		private bool InitializePackage()
		{
			bool success = false;
			try
			{
				FileInfo filePath = new FileInfo(PackageFilePath);

				if (filePath.Directory == null)
				{
					throw new DirectoryNotFoundException($"The directory provided in the package file path does not appear to be a valid directory.");
				}

				if (!filePath.Directory.Exists)
					filePath.Directory.Create();

				CensusPackage = File.Exists(PackageFilePath)
					? CensusApplication.LoadPackage(PackageFilePath, new DefaultEvents())
					: new Package();

				CensusPackage.Name = DefaultPackageName;
				CensusPackage.CreatorName = "Anthony Hart";
				CensusPackage.Description = DefaultPackageDescription;
				CensusPackage.PackageType = DTSPackageType.Default;

				ConnectionManager manager = GetDefaultConnection();

				Save();

				success = CensusPackage != null && manager != null;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}

			return success;
		}

		private void InitializeTasks()
		{
			var a0 = CensusPackage.CertificateContext;
			var a1 = CensusPackage.CertificateObject;
			var a2 = CensusPackage.CheckSignatureOnLoad;
			var a3 = CensusPackage.CheckpointFileName;
			var a4 = CensusPackage.CheckpointUsage;
			var a5 = CensusPackage.Configurations;
			var a6 = CensusPackage.CreationDate;
			var a7 = CensusPackage.CreatorComputerName;
			var a8 = CensusPackage.CreatorName;
			var a9 = CensusPackage.Connections;
			var b0 = CensusPackage.DesignEvents;
			var b1 = CensusPackage.DesignTimeProperties;
			var b2 = CensusPackage.DumpDescriptor;
			var b3 = CensusPackage.DumpOnAnyError;
			var b4 = CensusPackage.EnableConfigurations;
			var b5 = CensusPackage.EnableDump;
			var b6 = CensusPackage.EncryptCheckpoints;
			var b7 = CensusPackage.Errors;
			var b8 = CensusPackage.Executables;
			var b9 = CensusPackage.ExtendedProperties;
			var c0 = CensusPackage.FailPackageOnFailure;
			var c1 = CensusPackage.HasExpressions;
			var c2 = CensusPackage.IgnoreConfigurationsOnLoad;
			var c3 = CensusPackage.InteractiveMode;
			var c4 = CensusPackage.LogProviders;
			var c5 = CensusPackage.MaxConcurrentExecutables;
			var c6 = CensusPackage.OfflineMode;
			//var c7 = CensusPackage.PackagePassword;
			var c8 = CensusPackage.PackagePriorityClass;
			var c9 = CensusPackage.PackageType;
			var d0 = CensusPackage.PackageUpgradeOptions;
			var d1 = CensusPackage.Parameters;
			var d2 = CensusPackage.PrecedenceConstraints;
			var d3 = CensusPackage.Project;
			var d4 = CensusPackage.Properties;
			var d5 = CensusPackage.ProtectionLevel;
			var d6 = CensusPackage.SafeRecursiveProjectPackageExecution;
			var d7 = CensusPackage.SaveCheckpoints;
			var d8 = CensusPackage.SuppressConfigurationWarnings;
			var d9 = CensusPackage.UpdateObjects;
			var e0 = CensusPackage.VersionBuild;
			var e1 = CensusPackage.VersionComments;
			var e2 = CensusPackage.VersionGUID;
			var e3 = CensusPackage.VersionMajor;
			var e4 = CensusPackage.VersionMinor;
			var e5 = CensusPackage.Warnings;
			var e6 = CensusPackage.CreationName;
			var e7 = CensusPackage.DebugMode;
			var e8 = CensusPackage.DelayValidation;
			var e9 = CensusPackage.Description;
			var f0 = CensusPackage.Disable;
			var f1 = CensusPackage.DisableEventHandlers;
			var f2 = CensusPackage.EventHandlers;
			var f3 = CensusPackage.EventInfos;
			var f4 = CensusPackage.ExecutionDuration;
			var f5 = CensusPackage.ExecutionResult;
			var f6 = CensusPackage.ExecutionStatus;
			var f7 = CensusPackage.FailParentOnFailure;
			var f8 = CensusPackage.FailParentOnFailure;
			var f9 = CensusPackage.Variables;
			var g0 = CensusPackage.VariableDispenser;
			var g1 = CensusPackage.TransactionOption;
			var g2 = CensusPackage.SuspendRequired;
			var g3 = CensusPackage.StopTime;
			var g4 = CensusPackage.StartTime;
			var g5 = CensusPackage.Site;
			var g6 = CensusPackage.Parent;
			var g7 = CensusPackage.Name;
			var g8 = CensusPackage.MaximumErrorCount;
			var g9 = CensusPackage.LoggingOptions;
			var h0 = CensusPackage.LoggingMode;
			var h1 = CensusPackage.LogEntryInfos;
			var h2 = CensusPackage.LocaleID;
			var h3 = CensusPackage.IsolationLevel;
			var h4 = CensusPackage.IsDefaultLocaleID;
			var h5 = CensusPackage.ID;
			var h6 = CensusPackage.ForcedExecutionValue;
			var h7 = CensusPackage.ForceExecutionValue;
			var h8 = CensusPackage.ForceExecutionResult;

			Console.WriteLine();

		}

		private void GetColumns<T>(ref IDTSConnectionManagerFlatFile100 manager, EntityTypeConfiguration<T> map) where T : class
		{
			foreach (object column in manager.Columns)
			{
				manager.Columns.Remove(column);
			}

			Type type = typeof(T);
			T instance = (T)Activator.CreateInstance(type);

			IEnumerable<Tuple<string, string, int?, int?>> columnInfo = map.GetColumnInfo()
																   .OrderBy(o => o.Item3);

			Dictionary<string, int> numberLengths = new Dictionary<string, int>
													{
														{"LOGRECNO", 7},
														{"AREALAND", 14},
														{"AREAWATR", 14},
														{"POP100", 9},
														{"HU100", 9}
													};

			foreach (Tuple<string, string, int?, int?> column in columnInfo)
			{
				//Console.WriteLine(column);

				int? columnWidth = numberLengths.ContainsKey(column.Item1)
									   ? numberLengths[column.Item1]
									   : column.Item4;

				if (!columnWidth.HasValue)
				{
					throw new ArgumentException($"Invalid Column width on {column.Item1}");
				}

				dynamic ffColumnObject = manager.Columns.Add();

				IDTSConnectionManagerFlatFileColumn100 ffColumn = (IDTSConnectionManagerFlatFileColumn100)ffColumnObject;
				ffColumn.DataType = column.Item2.Equals("NVARCHAR")
										? DataType.DT_STR
										: DataType.DT_I4;
				ffColumn.ColumnType = "FixedWidth";
				ffColumn.ColumnWidth = columnWidth.Value;
				ffColumn.MaximumWidth = ffColumn.ColumnWidth;

				IDTSName100 columnName = ffColumnObject as IDTSName100;
				if (columnName != null)
				{
					columnName.Name = column.Item1;
					columnName.Description = instance.GetName(column.Item1);
				}
			}
			dynamic ffTerminatingColumnObject = manager.Columns.Add();
			IDTSConnectionManagerFlatFileColumn100 ffTerminatingColumn = (IDTSConnectionManagerFlatFileColumn100)ffTerminatingColumnObject;
			ffTerminatingColumn.DataType = DataType.DT_STR;
			ffTerminatingColumn.ColumnWidth = 1;
			ffTerminatingColumn.MaximumWidth = 1;

			IDTSName100 terminatingColumnName = ffTerminatingColumnObject as IDTSName100;
			if (terminatingColumnName != null)
			{
				terminatingColumnName.Name = "TERMINATOR";
				terminatingColumnName.Description = "A single space terminating column to ensure all record rows are matching lengths";
			}
		}

		private ConnectionManager GetDefaultConnection()
		{
			foreach (var connection in CensusPackageConnections.Cast<ConnectionManager>().Where(connection => connection.Name == DefaultConnectionName))
			{
				CensusPackageConnections.Remove(connection);
			}

			ConnectionManager manager = CensusPackageConnections.Add("ADO.NET:SQL");

			if (manager == null)
				throw new ArgumentException("Unable to retrieve or create the default connection for the package!");

			manager.Name = DefaultConnectionName;
			manager.Description = DefaultConnectionDescription;
			manager.ConnectionString = Program.DefaultConnectionString;

			return manager;
		}

		public ConnectionManager GetFlatFileConnection<T>(string path, EntityTypeConfiguration<T> map, bool updateExisting = false) where T : class
		{
			if (string.IsNullOrWhiteSpace(path)
				|| !File.Exists(path))
			{
				throw new ArgumentException($"'{path}' is not a valid flat file path.");
			}

			FileInfo fileInfo = new FileInfo(path);

			string name = $"SSIS Flat File Connection Manager for {fileInfo.Name}";
			string description = $"Provides an SSIS connection to {path}";
			string streamName = $"{fileInfo.Name}.{ConnectionManagerExtension}";

			foreach (var connection in CensusPackageConnections.Cast<ConnectionManager>().Where(connection => connection.Name == name))
			{
				CensusPackageConnections.Remove(connection);
			}

			ConnectionManager manager = CensusPackageConnections.Add("FLATFILE");
			manager.ConnectionString = path;
			manager.Name = name;
			manager.Description = description;

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

			Save();

			return manager;
		}

		public void AddFlatFileConnection<T>(string path, EntityTypeConfiguration<T> map, bool updateExisting = false) where T : class
		{
			ConnectionManager manager = GetFlatFileConnection(path, map, updateExisting);
			Console.Write($"\rAdded {manager.Name} to the flat file connections");
		}

		public void Save()
		{
			SavePackages();
		}

		private void SavePackages()
		{
			//foreach (PackageItem package in CensusProject.PackageItems)
			//{
			//	string filePath = $"{PackageDirectoryPath}\\{package.StreamName}";

			FileInfo fileInfo = new FileInfo(PackageFilePath);

			if (fileInfo.Directory == null)
				throw new ArgumentException($"{PackageFilePath} is not a valid package path");

			if (!fileInfo.Directory.Exists)
				fileInfo.Directory.Create();

			if (fileInfo.Exists)
				fileInfo.Delete();

			CensusApplication.SaveToXml(PackageFilePath, CensusPackage, null);
			//}
		}
	}
}
