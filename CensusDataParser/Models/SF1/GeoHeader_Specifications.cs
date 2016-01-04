#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2015 4:24 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: GeoHeader_Specifications.cs
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

namespace CensusDataParser.Models.SF1
{
	#region Using Directives
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.Data.OleDb;
	using System.Globalization;
	using Enumerators;
	#endregion

	public class GeoHeader_Specifications
	{
		[Display(Name = "DATA DICTIONARY REFERENCE", ShortName = "DATA DICTIONARY REFERENCE", Order = 2)]
		public string DATA_DICTIONARY_REFERENCE { get; set; }

		[Display(Name = "DATA TYPE", ShortName = "DATA TYPE", Order = 5)]
		public string DATA_TYPE { get; set; }

		[Display(Name = "FIELD", ShortName = "FIELD", Order = 1)]
		public string FIELD { get; set; }

		[Display(Name = "FIELD SIZE", ShortName = "FIELD SIZE", Order = 4)]
		public string FIELD_SIZE { get; set; }

		[Display(Name = "ID", ShortName = "ID", Order = 0)]
		public int? ID { get; set; }

		[Display(Name = "STARTING POSITION", ShortName = "STARTING POSITION", Order = 3)]
		public string STARTING_POSITION { get; set; }

		public GeoHeader_Specifications()
		{
			// Empty constructor to ensure JSON operability
		}

		public GeoHeader_Specifications(OleDbDataReader row, CensusFileType summaryFileType)
		{
			switch (summaryFileType)
			{
				case CensusFileType.SummaryTwo:
					if (row[0] != DBNull.Value)
					{
						ID = (int)row[0];
					}
					if (row[1] != DBNull.Value)
					{
						FIELD = (string)row[1];
					}
					if (row[2] != DBNull.Value)
					{
						DATA_DICTIONARY_REFERENCE = (string)row[2];
					}
					if (row[3] != DBNull.Value)
					{
						STARTING_POSITION = (string)row[3];
					}
					if (row[4] != DBNull.Value)
					{
						FIELD_SIZE = (string)row[4];
					}
					if (row[5] != DBNull.Value)
					{
						DATA_TYPE = (string)row[5];
					}
					break;
				case CensusFileType.Redistricting:
				case CensusFileType.DemographicProfile:
					if (row[0] != DBNull.Value)
					{
						FIELD = (string)row[0];
					}
					if (row[1] != DBNull.Value)
					{
						DATA_DICTIONARY_REFERENCE = (string)row[1];
					}
					if (row[2] != DBNull.Value)
					{
						FIELD_SIZE = (row[2] as double?)?.ToString(CultureInfo.InvariantCulture) ?? (row[2] as decimal?)?.ToString(CultureInfo.InvariantCulture);
					}
					break;
				case CensusFileType.AdvanceGroupQuarters:
				case CensusFileType.SummaryOne:
				case CensusFileType.IslandAreas_DPSF:
				case CensusFileType.AIANSummaryFile:
				case CensusFileType.SF1CongressionalDistricts113:
				case CensusFileType.IslandAreas_IASF:
				case CensusFileType.IslandAreasDetailedCrossTabulations:
				case CensusFileType.IslandAreas_PUMS:
				case CensusFileType.Stateside_PUMS:
					throw new NotImplementedException("The Geography Field Specifications table is not included in this specific dataset.");
				default:
					throw new ArgumentOutOfRangeException(nameof(summaryFileType), summaryFileType, null);
			}
		}

		#region Overrides of Object
		/// <summary>
		///     Returns a string that represents the current object.
		/// </summary>
		/// <returns>
		///     A string that represents the current object.
		/// </returns>
		public override string ToString() { return $"{DATA_DICTIONARY_REFERENCE} | {DATA_TYPE} | {FIELD_SIZE} | {FIELD}"; }
		#endregion
	}
}
