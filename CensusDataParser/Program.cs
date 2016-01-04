#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2015 4:24 PM
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
	using System.Collections;
	using System.Collections.Generic;
	using System.Configuration;
	using System.Data.Entity.ModelConfiguration;
	using System.Data.Entity.ModelConfiguration.Configuration;
	using System.Data.Entity.ModelConfiguration.Utilities;
	using System.Linq;
	using System.Reflection;
	using Enumerators;
	using Generated.Binding;
	using Generated.Context;
	using Generated.Mapping;
	#endregion

	public class Program
	{
		public const BindingFlags BindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
		public static string OutputPath => ConfigurationManager.AppSettings["OutputPath"];

		private static void Main(string[] args)
		{
			Console.BufferHeight = short.MaxValue - 1;
			Console.BufferWidth = Console.BufferWidth * 50;

			Dictionary<string, int> columnOrders = GetColumnOrders(new SummaryOne_GEO_HEADER_SF1Map());
			Console.WriteLine(columnOrders.Count);
			//CensusDataHelper.OutputSchemaStrings(directory: OutputPath, allTables: true);

			if (RawCensusDataEntities.CreateDatabase())
			{
				//CensusDataHelper.ProcessData(CensusFileType.Redistricting);
				//CensusDataHelper.ProcessData(CensusFileType.DemographicProfile);
				CensusDataHelper.ProcessData(CensusFileType.SummaryOne);

				//CensusDataHelper.ProcessData(CensusFileType.SummaryTwo);
				//CensusDataHelper.ProcessData(CensusFileType.SF1CongressionalDistricts113);
			}

			Console.WriteLine("END OF APPLICATION");
		}

		public static Dictionary<string, int> GetColumnOrders<T>(EntityTypeConfiguration<T> map) where T : class
		{
			Type modelType = typeof(T);
			object configuration = map.GetType().GetProperty("Configuration", BindFlags).GetValue(map);
			Type configurationType = configuration.GetType();
			PropertyInfo propertiesConfiguration = configurationType.GetProperty("PrimitivePropertyConfigurations", BindFlags);
			IEnumerable propertyValues = propertiesConfiguration.GetValue(configuration) as IEnumerable;

			if (propertyValues == null)
				return null;

			foreach (object propertyValue in propertyValues)
			{
				Type propertyValueType = propertyValue.GetType();
				PropertyInfo keyProperty = propertyValueType.GetProperty("Key", BindFlags);
				PropertyInfo valueProperty = propertyValueType.GetProperty("Value", BindFlags);

				object keyValue = keyProperty.GetValue(propertyValue);
				object valueValue = valueProperty.GetValue(propertyValue);

				Console.WriteLine();
			}

			return null;
		}
	}
}
