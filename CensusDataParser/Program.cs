#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2015 2:41 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: Program.cs
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
	using System.Configuration;
	using System.Linq;
	using Enumerators;
	using Extensions;
	using Generated.Context;
	using Helpers;
	#endregion

	#region Using Directives
	#endregion

	public class Program
	{
		public static string BaseCatalog => ConfigurationManager.AppSettings["DefaultCatalog"];
		public static string BaseNamespace => typeof(Program).Namespace;
		public static string BaseSchema => ConfigurationManager.AppSettings["DefaultSchema"];
		public static string ConnectionString => ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
		public static string DefaultConnectionString => ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
		public static string DefaultDatabase => ConfigurationManager.AppSettings["DefaultCatalog"];
		public static string LocalRootPath => ConfigurationManager.AppSettings["LocalRootPath"];
		public static string Namespace => ConfigurationManager.AppSettings["DefaultNamespace"];
		public static string OutputPath => ConfigurationManager.AppSettings["OutputPath"];
		public static bool UseFtp => bool.Parse(ConfigurationManager.AppSettings["UseFTP"]);

		private static void Main(string[] args)
		{
			Initialize(args);

			//ProcessCensusSchema();
			ProcessCensusData();

			Console.WriteLine("END OF APPLICATION");
			Console.ReadLine();
		}

		private static void Initialize(string[] args)
		{
			Console.Write("INITIALIZING APPLICATION");

			Console.BufferHeight = short.MaxValue - 1;
			Console.BufferWidth *= 50;

			ProcessArgs(args);

			Console.WriteLine("\rINITIALIZATION COMPLETE\t\t\t\t\t");
		}

		private static void ProcessArgs(string[] args)
		{
			Console.Write("PROCESSING ARGUMENTS");
			foreach (string arg in args.Select((argument, index) => $"Argument {index}: {argument}"))
			{
				Console.WriteLine("Argument: {0}", arg);
			}
			Console.WriteLine("\rARGUMENT PROCESSING COMPLETE\t\t\t\t\t");
		}

		public static void ProcessCensusData()
		{
			try
			{
				if (RawCensusDataEntities.CreateDatabase())
				{
					CensusDataHelper.ProcessData(CensusFileType.SummaryOne);
					CensusDataHelper.ProcessData(CensusFileType.SummaryTwo);

					// WORK IN PROGRESS
					//foreach (CensusFileType fileType in default(CensusFileType).GetEnums())
					//{
					//	CensusDataHelper.ProcessCensusData(fileType);
					//}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.InnerException);
				Console.WriteLine(e);
				throw;
			}
		}

		public static void ProcessCensusSchema()
		{
			try
			{
				Console.Write("PROCESSING CENSUS SCHEMA");
				CensusDataHelper.OutputSchemaStrings(directory: OutputPath, allTables: true);
				Console.WriteLine("\rCENSUS SCHEMA PROCESSING COMPLETE\t\t\t\t\t");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.InnerException);
				Console.WriteLine(e);
				throw;
			}
		}
	}
}
