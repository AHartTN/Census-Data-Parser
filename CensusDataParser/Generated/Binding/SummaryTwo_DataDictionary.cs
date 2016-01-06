#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/06/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryTwo_DataDictionary.cs
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

namespace CensusDataParser.Generated.Binding
{
	#region Using Directives
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.Data.OleDb;
	#endregion

	public class SummaryTwo_DataDictionary : BaseModel
	{
		#region Properties
		[Display(Name = "SORT ID", ShortName = "SORT ID", Order = 0)]
		public int SORT_ID { get; set; }

		[Display(Name = "TABLE", ShortName = "TABLE", Order = 1)]
		public string TABLE { get; set; }

		[Display(Name = "SEGMENT", ShortName = "SEGMENT", Order = 2)]
		public string SEGMENT { get; set; }

		[Display(Name = "FIELD NAME", ShortName = "FIELD NAME", Order = 3)]
		public string FIELD_NAME { get; set; }

		[Display(Name = "FIELD CODE", ShortName = "FIELD CODE", Order = 4)]
		public string FIELD_CODE { get; set; }
		#endregion Properties

		#region Constructors
		public SummaryTwo_DataDictionary(string csvLine) : base(csvLine) { }

		public SummaryTwo_DataDictionary(string[] values) : base(values) { }

		public SummaryTwo_DataDictionary(OleDbDataReader reader)
		{
			if (reader[0] != DBNull.Value)
			{
				SORT_ID = (int)reader[0];
			}
			if (reader[1] != DBNull.Value)
			{
				TABLE = (string)reader[1];
			}
			if (reader[2] != DBNull.Value)
			{
				SEGMENT = (string)reader[2];
			}
			if (reader[3] != DBNull.Value)
			{
				FIELD_NAME = (string)reader[3];
			}
			if (reader[4] != DBNull.Value)
			{
				FIELD_CODE = (string)reader[4];
			}
		}
		#endregion Constructors
	}
}
