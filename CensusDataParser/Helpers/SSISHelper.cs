#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2016 3:35 PM
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

namespace CensusDataParser.Helpers
{
    #region Using Directives
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Configuration;
    using System.Data;
    using System.Data.Entity.ModelConfiguration;
    using System.IO;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using Extensions;
    using Microsoft.SqlServer.Dts.Pipeline.Wrapper;
    using Microsoft.SqlServer.Dts.Runtime;
    using Microsoft.SqlServer.Dts.Runtime.Wrapper;
    using Models;
    using Application = Microsoft.SqlServer.Dts.Runtime.Application;
    using DTSCheckpointUsage = Microsoft.SqlServer.Dts.Runtime.DTSCheckpointUsage;
    using DTSExecResult = Microsoft.SqlServer.Dts.Runtime.DTSExecResult;
    using DTSExecStatus = Microsoft.SqlServer.Dts.Runtime.DTSExecStatus;
    using DTSForcedExecResult = Microsoft.SqlServer.Dts.Runtime.DTSForcedExecResult;
    using DTSLoggingMode = Microsoft.SqlServer.Dts.Runtime.DTSLoggingMode;
    using DTSPackageType = Microsoft.SqlServer.Dts.Runtime.DTSPackageType;
    using DTSPriorityClass = Microsoft.SqlServer.Dts.Runtime.DTSPriorityClass;
    using DTSProtectionLevel = Microsoft.SqlServer.Dts.Runtime.DTSProtectionLevel;
    using DTSTransactionOption = Microsoft.SqlServer.Dts.Runtime.DTSTransactionOption;
    using Package = Microsoft.SqlServer.Dts.Runtime.Package;
    using TaskHost = Microsoft.SqlServer.Dts.Runtime.TaskHost;
    using VariableDispenser = Microsoft.SqlServer.Dts.Runtime.VariableDispenser;
    #endregion

    public class SSISHelper
    {
        #region Properties

        #region Constants/Defaults
        public const int CodePage = 1252;
        public const int LocaleID = 1033;
        public const string RowDelimiter = "\r\n";
        public const string ColumnDelimiter = ",";
        public const string ProjectName = "Anthony Hart's 2010 Census Data Parser";
        public const string ProjectDescription = "This SSIS Project was automatically generated and/or updated via Anthony Hart's 2010 US Census Data Parser (http://www.github.com/ahartrc/census-data-parser)";
        public const string DefaultPackageName = "Census Data Package";
        public const string DefaultPackageDescription = "This is the default package for parsing the 2010 Census data. All necessary functionality is located within this package.";
        public const string DefaultConnectionName = "Default SSIS Connection for ADO NET";
        public const string DefaultConnectionDescription = "Provides an ADO.NET database connection to the default database as outlined in the connection string specified in the configuration file";

        //public string OleDBConnectionString => $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={FilePath}";
        #endregion Constants/Defaults

        #region Stream Names
        public static string DefaultConnectionStreamName = $"{DefaultConnectionName}.{ConnectionManagerExtension}";
        public static string DefaultPackageStreamName = $"{PackageFileName}.{PackageFileExtension}";
        public static string DefaultProjectStreamName = $"{ProjectFileName}.{ProjectFileExtension}";
        #endregion

        #region Extensions
        public static string ConnectionManagerExtension => ConfigurationManager.AppSettings["SSISConnectionManagerExtension"].Trim('.');
        public static string ProjectFileExtension => ConfigurationManager.AppSettings["SSISProjectFileExtension"].Trim('.');
        public static string PackageFileExtension => ConfigurationManager.AppSettings["SSISPackageFileExtension"].Trim('.');
        #endregion Extensions

        #region Paths

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

        #region Output Paths
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
        public static string ProjectFilePath => FullProjectFilePath;
        public static string PackageFilePath => FullPackageFilePath;

        //public static string ProjectFilePath => CensusProjectFilePath;
        //public static string PackageFilePath => CensusPackageFilePath;
        #endregion

        #endregion Paths

        #region SSIS Properties
        public static PipelineComponentInfo ADONETDestinationComponentInfo => CensusApplication.PipelineComponentInfos["ADO NET Destination"];
        public static PipelineComponentInfo FlatFileSourceComponentInfo => CensusApplication.PipelineComponentInfos["Flat File Source"];
        public Connections CensusPackageConnections => CensusPackage.Connections;
        public Executables CensusPackageExecutables => CensusPackage.Executables;
        public ConnectionManager DefaultConnection => CensusPackageConnections[DefaultConnectionName];
        public FileInfo PackageFileInfo => new FileInfo(PackageFilePath);
        public FileInfo ProjectFileInfo => new FileInfo(ProjectFilePath);
        public static Application CensusApplication { get; set; }
        public Package CensusPackage { get; set; }
        public ConnectionManagerItem DestinationConnection { get; set; }
        public ConnectionManagerItem SourceConnection { get; set; }
        #endregion SSIS Properties

        #endregion Properties

        #region Methods

        #region Constructors
        public SSISHelper() { Initialize(); }
        #endregion Constructors

        #region Initialization
        private void Initialize()
        {
            CensusApplication = new Application();

            bool packageInitialized = InitializePackage();
            Console.WriteLine(packageInitialized
                                  ? "Package Initialized successfully"
                                  : "The package has failed to initialize!");

            if (!packageInitialized)
            {
                throw new Exception("Unable to initialize project! Project necessary to continue!");
            }

            InitializeTasks();

            //bool projectInitialized = InitializeProject();
            //Console.WriteLine(projectInitialized
            //					  ? "Project Initialized successfully"
            //					  : "The project has failed to initialize!");

            //if (!projectInitialized)
            //	throw new Exception("Unable to initialize project!");

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
            bool success;
            try
            {
                FileInfo filePath = new FileInfo(PackageFilePath);

                if (filePath.Directory == null)
                {
                    throw new DirectoryNotFoundException($"The directory provided in the package file path does not appear to be a valid directory.");
                }

                if (!filePath.Directory.Exists)
                {
                    filePath.Directory.Create();
                }

                CensusPackage = File.Exists(PackageFilePath)
                                    ? CensusApplication.LoadPackage(PackageFilePath, new DefaultEvents())
                                    : new Package();

                CensusPackage.Name = DefaultPackageName;
                CensusPackage.CreatorName = "Anthony Hart";
                CensusPackage.Description = DefaultPackageDescription;
                CensusPackage.PackageType = DTSPackageType.Default;
                CensusPackage.DesignEvents = new SSISEventHandler();

                ConnectionManager manager = GetDefaultConnection();

                Save();

                success = CensusPackage != null && manager != null && manager == DefaultConnection;
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
            long a0 = CensusPackage.CertificateContext;
            X509Certificate a1 = CensusPackage.CertificateObject;
            bool a2 = CensusPackage.CheckSignatureOnLoad;
            string a3 = CensusPackage.CheckpointFileName;
            DTSCheckpointUsage a4 = CensusPackage.CheckpointUsage;
            Configurations a5 = CensusPackage.Configurations;
            DateTime a6 = CensusPackage.CreationDate;
            string a7 = CensusPackage.CreatorComputerName;
            string a8 = CensusPackage.CreatorName;
            Connections a9 = CensusPackage.Connections;
            IDTSEvents b0 = CensusPackage.DesignEvents;
            string b1 = CensusPackage.DesignTimeProperties;
            string b2 = CensusPackage.DumpDescriptor;
            bool b3 = CensusPackage.DumpOnAnyError;
            bool b4 = CensusPackage.EnableConfigurations;
            bool b5 = CensusPackage.EnableDump;
            bool b6 = CensusPackage.EncryptCheckpoints;
            DtsErrors b7 = CensusPackage.Errors;
            Executables b8 = CensusPackage.Executables;
            ExtendedProperties b9 = CensusPackage.ExtendedProperties;
            bool c0 = CensusPackage.FailPackageOnFailure;
            bool c1 = CensusPackage.HasExpressions;
            bool c2 = CensusPackage.IgnoreConfigurationsOnLoad;
            bool c3 = CensusPackage.InteractiveMode;
            LogProviders c4 = CensusPackage.LogProviders;
            int c5 = CensusPackage.MaxConcurrentExecutables;
            bool c6 = CensusPackage.OfflineMode;

            //var c7 = CensusPackage.PackagePassword;
            DTSPriorityClass c8 = CensusPackage.PackagePriorityClass;
            DTSPackageType c9 = CensusPackage.PackageType;
            PackageUpgradeOptions d0 = CensusPackage.PackageUpgradeOptions;
            Parameters d1 = CensusPackage.Parameters;
            PrecedenceConstraints d2 = CensusPackage.PrecedenceConstraints;
            IDTSProject100 d3 = CensusPackage.Project;
            DtsProperties d4 = CensusPackage.Properties;
            DTSProtectionLevel d5 = CensusPackage.ProtectionLevel;
            bool d6 = CensusPackage.SafeRecursiveProjectPackageExecution;
            bool d7 = CensusPackage.SaveCheckpoints;
            bool d8 = CensusPackage.SuppressConfigurationWarnings;
            bool d9 = CensusPackage.UpdateObjects;
            int e0 = CensusPackage.VersionBuild;
            string e1 = CensusPackage.VersionComments;
            string e2 = CensusPackage.VersionGUID;
            int e3 = CensusPackage.VersionMajor;
            int e4 = CensusPackage.VersionMinor;
            DtsWarnings e5 = CensusPackage.Warnings;
            string e6 = CensusPackage.CreationName;
            bool e7 = CensusPackage.DebugMode;
            bool e8 = CensusPackage.DelayValidation;
            string e9 = CensusPackage.Description;
            bool f0 = CensusPackage.Disable;
            bool f1 = CensusPackage.DisableEventHandlers;
            DtsEventHandlers f2 = CensusPackage.EventHandlers;
            EventInfos f3 = CensusPackage.EventInfos;
            int f4 = CensusPackage.ExecutionDuration;
            DTSExecResult f5 = CensusPackage.ExecutionResult;
            DTSExecStatus f6 = CensusPackage.ExecutionStatus;
            bool f7 = CensusPackage.FailParentOnFailure;
            bool f8 = CensusPackage.FailParentOnFailure;
            Variables f9 = CensusPackage.Variables;
            VariableDispenser g0 = CensusPackage.VariableDispenser;
            DTSTransactionOption g1 = CensusPackage.TransactionOption;
            bool g2 = CensusPackage.SuspendRequired;
            DateTime g3 = CensusPackage.StopTime;
            DateTime g4 = CensusPackage.StartTime;
            ISite g5 = CensusPackage.Site;
            DtsContainer g6 = CensusPackage.Parent;
            string g7 = CensusPackage.Name;
            int g8 = CensusPackage.MaximumErrorCount;
            LoggingOptions g9 = CensusPackage.LoggingOptions;
            DTSLoggingMode h0 = CensusPackage.LoggingMode;
            LogEntryInfos h1 = CensusPackage.LogEntryInfos;
            int h2 = CensusPackage.LocaleID;
            IsolationLevel h3 = CensusPackage.IsolationLevel;
            bool h4 = CensusPackage.IsDefaultLocaleID;
            string h5 = CensusPackage.ID;
            object h6 = CensusPackage.ForcedExecutionValue;
            bool h7 = CensusPackage.ForceExecutionValue;
            DTSForcedExecResult h8 = CensusPackage.ForceExecutionResult;

            Console.WriteLine();
        }
        #endregion Initialization

        #region Saving
        public void Save() { SavePackages(); }

        private void SavePackages()
        {
            //foreach (PackageItem package in CensusProject.PackageItems)
            //{
            //	string filePath = $"{PackageDirectoryPath}\\{package.StreamName}";

            FileInfo fileInfo = new FileInfo(PackageFilePath);

            if (fileInfo.Directory == null)
            {
                throw new ArgumentException($"{PackageFilePath} is not a valid package path");
            }

            if (!fileInfo.Directory.Exists)
            {
                fileInfo.Directory.Create();
            }

            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }

            CensusApplication.SaveToXml(PackageFilePath, CensusPackage, null);

            //}
        }
        #endregion Saving

        #region SSIS Operations
        public DTSExecResult ProcessFlatFile<T>(string path, EntityTypeConfiguration<T> map, bool updateExisting = false) where T : class
        {
            Executable exe = AddFlatFileConnection(path, map, updateExisting);
            return exe.Execute(CensusPackageConnections, CensusPackage.Variables, new SSISEventHandler(), null, null);
        }

        public Executable AddFlatFileConnection<T>(string path, EntityTypeConfiguration<T> map, bool updateExisting = false) where T : class
        {
            ConnectionManager manager = GetFlatFileConnection(path, map, updateExisting);
            Executable executable = AddTask(map, manager);

            Save();
            Console.Write($"\rAdded {manager.Name} to the flat file connections");

            return executable;
        }

        public Executable AddTask<T>(EntityTypeConfiguration<T> map, ConnectionManager manager) where T : class
        {
            FileInfo fileInfo = new FileInfo(manager.ConnectionString);
            string fileName = fileInfo.Name.Substring(0, fileInfo.Name.Length - 4);
            string dataFlowName = $"Data Flow from {fileName} to {map.GetTableName()} in the {map.GetSchemaName()} Schema";
            string dataFlowDescription = $"This data flow task will transfer the records from {manager.ConnectionString} to the {map.GetFullTableName()}";

            Executable executable = CensusPackageExecutables.Contains(dataFlowName)
                                        ? CensusPackageExecutables[dataFlowName]
                                        : CensusPackageExecutables.Add("STOCK:PipelineTask");
            TaskHost task = executable as TaskHost;

            if (task == null)
            {
                throw new ArgumentException("Failed to retrieve executable as TaskHost!");
            }

            task.Name = dataFlowName;
            task.Description = dataFlowDescription;

            MainPipe dataFlow = task.InnerObject as MainPipe;

            if (dataFlow == null)
            {
                throw new ArgumentException("Unable to retrieve task as a MainPipe!");
            }

            dataFlow.ComponentMetaDataCollection.RemoveAll();
            dataFlow.Events = DtsConvert.GetExtendedInterface(new SSISComponentEventHandler());

            #region Source
            IDTSComponentMetaData100 source = dataFlow.ComponentMetaDataCollection.New();
            source.Name = $"{FlatFileSourceComponentInfo.Name} reference to {fileName}";
            source.Description = $"This component will read all of the records located in {fileInfo.FullName}";
            source.ContactInfo = "Anthony Hart | anthony@anthonyhart.info";
            source.ComponentClassID = FlatFileSourceComponentInfo.CreationName;

            CManagedComponentWrapper sourceWrapper = source.Instantiate();
            sourceWrapper.ProvideComponentProperties();

            source.RuntimeConnectionCollection[0].ConnectionManager = DtsConvert.GetExtendedInterface(manager);
            source.RuntimeConnectionCollection[0].ConnectionManagerID = manager.ID;

            source.RuntimeConnectionCollection[0].Name = "FlatFileConnection";
            source.RuntimeConnectionCollection[0].Description = manager.Description;

            sourceWrapper.SetComponentProperty("RetainNulls", true);
            //sourceWrapper.SetComponentProperty("FastParse", true);

            sourceWrapper.AcquireConnections(null);
            sourceWrapper.ReinitializeMetaData();
            sourceWrapper.ReleaseConnections();
            #endregion Source

            #region Destination
            IDTSComponentMetaData100 destination = dataFlow.ComponentMetaDataCollection.New();
            destination.Name = $"{ADONETDestinationComponentInfo.Name} reference to {map.GetTableName()} in the {map.GetSchemaName()} Schema";
            destination.Description = $"This component will import all of the records that were read from the {FlatFileSourceComponentInfo.Name} component into the {map.GetFullTableName()} table";
            destination.ContactInfo = "Anthony Hart | anthony@anthonyhart.info";
            destination.ComponentClassID = ADONETDestinationComponentInfo.CreationName;

            CManagedComponentWrapper destinationWrapper = destination.Instantiate();
            destinationWrapper.ProvideComponentProperties();

            destination.RuntimeConnectionCollection[0].ConnectionManager = DtsConvert.GetExtendedInterface(DefaultConnection);
            destination.RuntimeConnectionCollection[0].ConnectionManagerID = DefaultConnection.ID;
            destination.RuntimeConnectionCollection[0].Name = "IDbConnection";
            destination.RuntimeConnectionCollection[0].Description = DefaultConnection.Description;

            destinationWrapper.SetComponentProperty("CommandTimeout", 600);
            destinationWrapper.SetComponentProperty("TableOrViewName", map.GetFullTableName());

            destinationWrapper.AcquireConnections(null);
            destinationWrapper.ReinitializeMetaData();
            destinationWrapper.ReleaseConnections();
            #endregion Destination

            #region Pathing
            IDTSPath100 path = dataFlow.PathCollection.New();
            path.AttachPathAndPropagateNotifications(source.OutputCollection[0], destination.InputCollection[0]);
            #endregion

            #region Column Mapping
            IDTSInput100 input = destination.InputCollection[0];
            IDTSVirtualInput100 virtualInput = input.GetVirtualInput();

            foreach (IDTSVirtualInputColumn100 vColumn in virtualInput.VirtualInputColumnCollection)
            {
                IDTSInputColumn100 vCol = destinationWrapper.SetUsageType(input.ID, virtualInput, vColumn.LineageID, vColumn.Name == "TERMINATOR" ? DTSUsageType.UT_IGNORED : DTSUsageType.UT_READWRITE);
                if (vCol != null)
                {
                    destinationWrapper.MapInputColumn(input.ID, vCol.ID, input.ExternalMetadataColumnCollection[vCol.Name].ID);
                }
            }
            #endregion Column Mapping

            return executable;
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
            ConnectionManager manager = CensusPackageConnections.Contains(DefaultConnectionName) ? CensusPackageConnections[DefaultConnectionName] : CensusPackageConnections.Add("ADO.NET:SQL");

            if (manager == null)
            {
                throw new ArgumentException("Unable to retrieve or create the default connection for the package!");
            }

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

            string fileName = fileInfo.Name.Replace(fileInfo.Extension, "")
                                      .Trim('.');

            string name = $"SSIS Flat File Connection Manager for {fileName}";
            string description = $"Provides an SSIS connection to {path}";
            string streamName = $"{fileInfo.Name}.{ConnectionManagerExtension}";

            ConnectionManager manager = CensusPackageConnections.Contains(name) ? CensusPackageConnections[name] : CensusPackageConnections.Add("FLATFILE");
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

            return manager;
        }
        #endregion SSIS Operations

        #endregion Methods
    }
}
