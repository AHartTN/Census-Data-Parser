#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/06/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryTwo_SF2_Segment_10.cs
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

	public class SummaryTwo_SF2_Segment_10 : BaseModel
	{
		#region Properties
		[Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
		public string FILEID { get; set; }

		[Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
		public string STUSAB { get; set; }

		[Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
		public string CHARITER { get; set; }

		[Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
		public string CIFSN { get; set; }

		[Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
		public int LOGRECNO { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 5)]
		public int? HCT0010001 { get; set; }

		[Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 6)]
		public int? HCT0010002 { get; set; }

		[Display(Name = "Not Hispanic or Latino householder:", ShortName = "Not Hispanic or Latino householder:", Order = 7)]
		public int? HCT0010003 { get; set; }

		[Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 8)]
		public int? HCT0010004 { get; set; }

		[Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 9)]
		public int? HCT0010005 { get; set; }

		[Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 10)]
		public int? HCT0010006 { get; set; }
		#endregion Properties

		#region Constructors
		public SummaryTwo_SF2_Segment_10(string csvLine) : base(csvLine) { }

		public SummaryTwo_SF2_Segment_10(string[] values) : base(values) { }

		public SummaryTwo_SF2_Segment_10(OleDbDataReader reader)
		{
			if (reader[0] != DBNull.Value)
			{
				FILEID = (string)reader[0];
			}
			if (reader[1] != DBNull.Value)
			{
				STUSAB = (string)reader[1];
			}
			if (reader[2] != DBNull.Value)
			{
				CHARITER = (string)reader[2];
			}
			if (reader[3] != DBNull.Value)
			{
				CIFSN = (string)reader[3];
			}
			if (reader[4] != DBNull.Value)
			{
				LOGRECNO = (int)reader[4];
			}
			if (reader[5] != DBNull.Value)
			{
				HCT0010001 = (int?)reader[5];
			}
			if (reader[6] != DBNull.Value)
			{
				HCT0010002 = (int?)reader[6];
			}
			if (reader[7] != DBNull.Value)
			{
				HCT0010003 = (int?)reader[7];
			}
			if (reader[8] != DBNull.Value)
			{
				HCT0010004 = (int?)reader[8];
			}
			if (reader[9] != DBNull.Value)
			{
				HCT0010005 = (int?)reader[9];
			}
			if (reader[10] != DBNull.Value)
			{
				HCT0010006 = (int?)reader[10];
			}
		}
		#endregion Constructors
	}
}
