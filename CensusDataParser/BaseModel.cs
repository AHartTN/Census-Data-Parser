#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2015 4:24 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: BaseModel.cs
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
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.Globalization;
	using System.Linq;
	using System.Reflection;
	using Extensions;
	#endregion

	public class BaseModel
	{
		public BaseModel()
		{
			// Empty for EF/JSON Interoperability
		}

		public BaseModel(string csvLine) { PopulateFromCsvString(csvLine); }

		public BaseModel(IEnumerable<string> values) { PopulateFromCollection(values); }

		private PropertyInfo GetProperty(int index)
		{
			return (from property in GetType()
				        .GetProperties()
			        let displayAttribute = property.GetCustomAttribute<DisplayAttribute>()
			        let idx = displayAttribute.Order
			        where idx == index
			        select property).FirstOrDefault();
		}

		public void PopulateFromCollection(IEnumerable<string> items)
		{
			foreach (var item in items.Select((s, i) => new
			                                            {
				                                            Value = s,
				                                            Index = i
			                                            }))
			{
				PropertyInfo property = GetProperty(item.Index);

				object value = item.Value;
				Type t = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;

				// May include scientific notation in decimals.
				// We need to make sure all decimals are clean before parsing
				if (t == typeof (decimal))
				{
					value = decimal.Parse(item.Value, NumberStyles.Any)
					               .ToString(CultureInfo.InvariantCulture);
				}

				object safeValue = Convert.ChangeType(value, t, CultureInfo.InvariantCulture);
				property.SetValue(this, safeValue, null);
			}
		}

		public void PopulateFromCsvString(string csvLine)
		{
			IEnumerable<string> values = csvLine.SplitCSV();
			PopulateFromCollection(values);
		}

		public void PopulateFromDelimitedString(string delimitedString, char delimiter) { PopulateFromCollection(delimitedString.Split(delimiter)); }
	}
}
