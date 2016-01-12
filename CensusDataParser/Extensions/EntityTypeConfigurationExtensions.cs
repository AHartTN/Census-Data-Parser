#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/06/2016 4:41 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: EntityTypeConfigurationExtensions.cs
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

namespace CensusDataParser.Extensions
{
	#region Using Directives
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Data.Entity.ModelConfiguration;
	#endregion

	public static class EntityTypeConfigurationExtensions
	{
		public static IEnumerable<Tuple<string, string, int?, int?>> GetColumnInfo<T>(this EntityTypeConfiguration<T> map) where T : class
		{
			object configuration = map.GetPropertyValue("Configuration");
			IEnumerable properties = configuration?.GetPropertyValue("PrimitivePropertyConfigurations") as IEnumerable;

			if (properties == null)
			{
				yield break;
			}
			foreach (object property in properties)
			{
				string propertyString = $"{property.GetPropertyValue("Key")}";
				string columnType = property.GetPropertyValue("Value")
										   .GetPropertyValue("ColumnType") as string;
				int? columnIndex = property.GetPropertyValue("Value")
										   .GetPropertyValue("ColumnOrder") as int?;
				int? maxLength = property.GetPropertyValue("Value")
				                         .GetPropertyValue("MaxLength") as int?;

				yield return new Tuple<string, string, int?, int?>(propertyString, columnType, columnIndex, maxLength);
			}
		}
	}
}
