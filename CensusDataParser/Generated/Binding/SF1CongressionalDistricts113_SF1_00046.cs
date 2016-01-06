#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/06/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1CongressionalDistricts113_SF1_00046.cs
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

	public class SF1CongressionalDistricts113_SF1_00046 : BaseModel
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
		public int? H017D0001 { get; set; }

		[Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 6)]
		public int? H017D0002 { get; set; }

		[Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 7)]
		public int? H017D0003 { get; set; }

		[Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 8)]
		public int? H017D0004 { get; set; }

		[Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 9)]
		public int? H017D0005 { get; set; }

		[Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 10)]
		public int? H017D0006 { get; set; }

		[Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 11)]
		public int? H017D0007 { get; set; }

		[Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 12)]
		public int? H017D0008 { get; set; }

		[Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 13)]
		public int? H017D0009 { get; set; }

		[Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 14)]
		public int? H017D0010 { get; set; }

		[Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 15)]
		public int? H017D0011 { get; set; }

		[Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 16)]
		public int? H017D0012 { get; set; }

		[Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 17)]
		public int? H017D0013 { get; set; }

		[Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 18)]
		public int? H017D0014 { get; set; }

		[Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 19)]
		public int? H017D0015 { get; set; }

		[Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 20)]
		public int? H017D0016 { get; set; }

		[Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 21)]
		public int? H017D0017 { get; set; }

		[Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 22)]
		public int? H017D0018 { get; set; }

		[Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 23)]
		public int? H017D0019 { get; set; }

		[Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 24)]
		public int? H017D0020 { get; set; }

		[Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 25)]
		public int? H017D0021 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 26)]
		public int? H017E0001 { get; set; }

		[Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 27)]
		public int? H017E0002 { get; set; }

		[Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 28)]
		public int? H017E0003 { get; set; }

		[Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 29)]
		public int? H017E0004 { get; set; }

		[Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 30)]
		public int? H017E0005 { get; set; }

		[Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 31)]
		public int? H017E0006 { get; set; }

		[Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 32)]
		public int? H017E0007 { get; set; }

		[Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 33)]
		public int? H017E0008 { get; set; }

		[Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 34)]
		public int? H017E0009 { get; set; }

		[Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 35)]
		public int? H017E0010 { get; set; }

		[Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 36)]
		public int? H017E0011 { get; set; }

		[Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 37)]
		public int? H017E0012 { get; set; }

		[Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 38)]
		public int? H017E0013 { get; set; }

		[Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 39)]
		public int? H017E0014 { get; set; }

		[Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 40)]
		public int? H017E0015 { get; set; }

		[Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 41)]
		public int? H017E0016 { get; set; }

		[Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 42)]
		public int? H017E0017 { get; set; }

		[Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 43)]
		public int? H017E0018 { get; set; }

		[Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 44)]
		public int? H017E0019 { get; set; }

		[Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 45)]
		public int? H017E0020 { get; set; }

		[Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 46)]
		public int? H017E0021 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 47)]
		public int? H017F0001 { get; set; }

		[Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 48)]
		public int? H017F0002 { get; set; }

		[Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 49)]
		public int? H017F0003 { get; set; }

		[Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 50)]
		public int? H017F0004 { get; set; }

		[Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 51)]
		public int? H017F0005 { get; set; }

		[Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 52)]
		public int? H017F0006 { get; set; }

		[Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 53)]
		public int? H017F0007 { get; set; }

		[Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 54)]
		public int? H017F0008 { get; set; }

		[Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 55)]
		public int? H017F0009 { get; set; }

		[Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 56)]
		public int? H017F0010 { get; set; }

		[Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 57)]
		public int? H017F0011 { get; set; }

		[Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 58)]
		public int? H017F0012 { get; set; }

		[Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 59)]
		public int? H017F0013 { get; set; }

		[Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 60)]
		public int? H017F0014 { get; set; }

		[Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 61)]
		public int? H017F0015 { get; set; }

		[Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 62)]
		public int? H017F0016 { get; set; }

		[Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 63)]
		public int? H017F0017 { get; set; }

		[Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 64)]
		public int? H017F0018 { get; set; }

		[Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 65)]
		public int? H017F0019 { get; set; }

		[Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 66)]
		public int? H017F0020 { get; set; }

		[Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 67)]
		public int? H017F0021 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 68)]
		public int? H017G0001 { get; set; }

		[Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 69)]
		public int? H017G0002 { get; set; }

		[Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 70)]
		public int? H017G0003 { get; set; }

		[Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 71)]
		public int? H017G0004 { get; set; }

		[Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 72)]
		public int? H017G0005 { get; set; }

		[Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 73)]
		public int? H017G0006 { get; set; }

		[Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 74)]
		public int? H017G0007 { get; set; }

		[Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 75)]
		public int? H017G0008 { get; set; }

		[Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 76)]
		public int? H017G0009 { get; set; }

		[Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 77)]
		public int? H017G0010 { get; set; }

		[Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 78)]
		public int? H017G0011 { get; set; }

		[Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 79)]
		public int? H017G0012 { get; set; }

		[Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 80)]
		public int? H017G0013 { get; set; }

		[Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 81)]
		public int? H017G0014 { get; set; }

		[Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 82)]
		public int? H017G0015 { get; set; }

		[Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 83)]
		public int? H017G0016 { get; set; }

		[Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 84)]
		public int? H017G0017 { get; set; }

		[Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 85)]
		public int? H017G0018 { get; set; }

		[Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 86)]
		public int? H017G0019 { get; set; }

		[Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 87)]
		public int? H017G0020 { get; set; }

		[Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 88)]
		public int? H017G0021 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 89)]
		public int? H017H0001 { get; set; }

		[Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 90)]
		public int? H017H0002 { get; set; }

		[Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 91)]
		public int? H017H0003 { get; set; }

		[Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 92)]
		public int? H017H0004 { get; set; }

		[Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 93)]
		public int? H017H0005 { get; set; }

		[Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 94)]
		public int? H017H0006 { get; set; }

		[Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 95)]
		public int? H017H0007 { get; set; }

		[Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 96)]
		public int? H017H0008 { get; set; }

		[Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 97)]
		public int? H017H0009 { get; set; }

		[Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 98)]
		public int? H017H0010 { get; set; }

		[Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 99)]
		public int? H017H0011 { get; set; }

		[Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 100)]
		public int? H017H0012 { get; set; }

		[Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 101)]
		public int? H017H0013 { get; set; }

		[Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 102)]
		public int? H017H0014 { get; set; }

		[Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 103)]
		public int? H017H0015 { get; set; }

		[Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 104)]
		public int? H017H0016 { get; set; }

		[Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 105)]
		public int? H017H0017 { get; set; }

		[Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 106)]
		public int? H017H0018 { get; set; }

		[Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 107)]
		public int? H017H0019 { get; set; }

		[Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 108)]
		public int? H017H0020 { get; set; }

		[Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 109)]
		public int? H017H0021 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 110)]
		public int? H017I0001 { get; set; }

		[Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 111)]
		public int? H017I0002 { get; set; }

		[Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 112)]
		public int? H017I0003 { get; set; }

		[Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 113)]
		public int? H017I0004 { get; set; }

		[Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 114)]
		public int? H017I0005 { get; set; }

		[Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 115)]
		public int? H017I0006 { get; set; }

		[Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 116)]
		public int? H017I0007 { get; set; }

		[Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 117)]
		public int? H017I0008 { get; set; }

		[Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 118)]
		public int? H017I0009 { get; set; }

		[Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 119)]
		public int? H017I0010 { get; set; }

		[Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 120)]
		public int? H017I0011 { get; set; }

		[Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 121)]
		public int? H017I0012 { get; set; }

		[Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 122)]
		public int? H017I0013 { get; set; }

		[Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 123)]
		public int? H017I0014 { get; set; }

		[Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 124)]
		public int? H017I0015 { get; set; }

		[Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 125)]
		public int? H017I0016 { get; set; }

		[Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 126)]
		public int? H017I0017 { get; set; }

		[Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 127)]
		public int? H017I0018 { get; set; }

		[Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 128)]
		public int? H017I0019 { get; set; }

		[Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 129)]
		public int? H017I0020 { get; set; }

		[Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 130)]
		public int? H017I0021 { get; set; }
		#endregion Properties

		#region Constructors
		public SF1CongressionalDistricts113_SF1_00046(string csvLine) : base(csvLine) { }

		public SF1CongressionalDistricts113_SF1_00046(string[] values) : base(values) { }

		public SF1CongressionalDistricts113_SF1_00046(OleDbDataReader reader)
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
				H017D0001 = (int?)reader[5];
			}
			if (reader[6] != DBNull.Value)
			{
				H017D0002 = (int?)reader[6];
			}
			if (reader[7] != DBNull.Value)
			{
				H017D0003 = (int?)reader[7];
			}
			if (reader[8] != DBNull.Value)
			{
				H017D0004 = (int?)reader[8];
			}
			if (reader[9] != DBNull.Value)
			{
				H017D0005 = (int?)reader[9];
			}
			if (reader[10] != DBNull.Value)
			{
				H017D0006 = (int?)reader[10];
			}
			if (reader[11] != DBNull.Value)
			{
				H017D0007 = (int?)reader[11];
			}
			if (reader[12] != DBNull.Value)
			{
				H017D0008 = (int?)reader[12];
			}
			if (reader[13] != DBNull.Value)
			{
				H017D0009 = (int?)reader[13];
			}
			if (reader[14] != DBNull.Value)
			{
				H017D0010 = (int?)reader[14];
			}
			if (reader[15] != DBNull.Value)
			{
				H017D0011 = (int?)reader[15];
			}
			if (reader[16] != DBNull.Value)
			{
				H017D0012 = (int?)reader[16];
			}
			if (reader[17] != DBNull.Value)
			{
				H017D0013 = (int?)reader[17];
			}
			if (reader[18] != DBNull.Value)
			{
				H017D0014 = (int?)reader[18];
			}
			if (reader[19] != DBNull.Value)
			{
				H017D0015 = (int?)reader[19];
			}
			if (reader[20] != DBNull.Value)
			{
				H017D0016 = (int?)reader[20];
			}
			if (reader[21] != DBNull.Value)
			{
				H017D0017 = (int?)reader[21];
			}
			if (reader[22] != DBNull.Value)
			{
				H017D0018 = (int?)reader[22];
			}
			if (reader[23] != DBNull.Value)
			{
				H017D0019 = (int?)reader[23];
			}
			if (reader[24] != DBNull.Value)
			{
				H017D0020 = (int?)reader[24];
			}
			if (reader[25] != DBNull.Value)
			{
				H017D0021 = (int?)reader[25];
			}
			if (reader[26] != DBNull.Value)
			{
				H017E0001 = (int?)reader[26];
			}
			if (reader[27] != DBNull.Value)
			{
				H017E0002 = (int?)reader[27];
			}
			if (reader[28] != DBNull.Value)
			{
				H017E0003 = (int?)reader[28];
			}
			if (reader[29] != DBNull.Value)
			{
				H017E0004 = (int?)reader[29];
			}
			if (reader[30] != DBNull.Value)
			{
				H017E0005 = (int?)reader[30];
			}
			if (reader[31] != DBNull.Value)
			{
				H017E0006 = (int?)reader[31];
			}
			if (reader[32] != DBNull.Value)
			{
				H017E0007 = (int?)reader[32];
			}
			if (reader[33] != DBNull.Value)
			{
				H017E0008 = (int?)reader[33];
			}
			if (reader[34] != DBNull.Value)
			{
				H017E0009 = (int?)reader[34];
			}
			if (reader[35] != DBNull.Value)
			{
				H017E0010 = (int?)reader[35];
			}
			if (reader[36] != DBNull.Value)
			{
				H017E0011 = (int?)reader[36];
			}
			if (reader[37] != DBNull.Value)
			{
				H017E0012 = (int?)reader[37];
			}
			if (reader[38] != DBNull.Value)
			{
				H017E0013 = (int?)reader[38];
			}
			if (reader[39] != DBNull.Value)
			{
				H017E0014 = (int?)reader[39];
			}
			if (reader[40] != DBNull.Value)
			{
				H017E0015 = (int?)reader[40];
			}
			if (reader[41] != DBNull.Value)
			{
				H017E0016 = (int?)reader[41];
			}
			if (reader[42] != DBNull.Value)
			{
				H017E0017 = (int?)reader[42];
			}
			if (reader[43] != DBNull.Value)
			{
				H017E0018 = (int?)reader[43];
			}
			if (reader[44] != DBNull.Value)
			{
				H017E0019 = (int?)reader[44];
			}
			if (reader[45] != DBNull.Value)
			{
				H017E0020 = (int?)reader[45];
			}
			if (reader[46] != DBNull.Value)
			{
				H017E0021 = (int?)reader[46];
			}
			if (reader[47] != DBNull.Value)
			{
				H017F0001 = (int?)reader[47];
			}
			if (reader[48] != DBNull.Value)
			{
				H017F0002 = (int?)reader[48];
			}
			if (reader[49] != DBNull.Value)
			{
				H017F0003 = (int?)reader[49];
			}
			if (reader[50] != DBNull.Value)
			{
				H017F0004 = (int?)reader[50];
			}
			if (reader[51] != DBNull.Value)
			{
				H017F0005 = (int?)reader[51];
			}
			if (reader[52] != DBNull.Value)
			{
				H017F0006 = (int?)reader[52];
			}
			if (reader[53] != DBNull.Value)
			{
				H017F0007 = (int?)reader[53];
			}
			if (reader[54] != DBNull.Value)
			{
				H017F0008 = (int?)reader[54];
			}
			if (reader[55] != DBNull.Value)
			{
				H017F0009 = (int?)reader[55];
			}
			if (reader[56] != DBNull.Value)
			{
				H017F0010 = (int?)reader[56];
			}
			if (reader[57] != DBNull.Value)
			{
				H017F0011 = (int?)reader[57];
			}
			if (reader[58] != DBNull.Value)
			{
				H017F0012 = (int?)reader[58];
			}
			if (reader[59] != DBNull.Value)
			{
				H017F0013 = (int?)reader[59];
			}
			if (reader[60] != DBNull.Value)
			{
				H017F0014 = (int?)reader[60];
			}
			if (reader[61] != DBNull.Value)
			{
				H017F0015 = (int?)reader[61];
			}
			if (reader[62] != DBNull.Value)
			{
				H017F0016 = (int?)reader[62];
			}
			if (reader[63] != DBNull.Value)
			{
				H017F0017 = (int?)reader[63];
			}
			if (reader[64] != DBNull.Value)
			{
				H017F0018 = (int?)reader[64];
			}
			if (reader[65] != DBNull.Value)
			{
				H017F0019 = (int?)reader[65];
			}
			if (reader[66] != DBNull.Value)
			{
				H017F0020 = (int?)reader[66];
			}
			if (reader[67] != DBNull.Value)
			{
				H017F0021 = (int?)reader[67];
			}
			if (reader[68] != DBNull.Value)
			{
				H017G0001 = (int?)reader[68];
			}
			if (reader[69] != DBNull.Value)
			{
				H017G0002 = (int?)reader[69];
			}
			if (reader[70] != DBNull.Value)
			{
				H017G0003 = (int?)reader[70];
			}
			if (reader[71] != DBNull.Value)
			{
				H017G0004 = (int?)reader[71];
			}
			if (reader[72] != DBNull.Value)
			{
				H017G0005 = (int?)reader[72];
			}
			if (reader[73] != DBNull.Value)
			{
				H017G0006 = (int?)reader[73];
			}
			if (reader[74] != DBNull.Value)
			{
				H017G0007 = (int?)reader[74];
			}
			if (reader[75] != DBNull.Value)
			{
				H017G0008 = (int?)reader[75];
			}
			if (reader[76] != DBNull.Value)
			{
				H017G0009 = (int?)reader[76];
			}
			if (reader[77] != DBNull.Value)
			{
				H017G0010 = (int?)reader[77];
			}
			if (reader[78] != DBNull.Value)
			{
				H017G0011 = (int?)reader[78];
			}
			if (reader[79] != DBNull.Value)
			{
				H017G0012 = (int?)reader[79];
			}
			if (reader[80] != DBNull.Value)
			{
				H017G0013 = (int?)reader[80];
			}
			if (reader[81] != DBNull.Value)
			{
				H017G0014 = (int?)reader[81];
			}
			if (reader[82] != DBNull.Value)
			{
				H017G0015 = (int?)reader[82];
			}
			if (reader[83] != DBNull.Value)
			{
				H017G0016 = (int?)reader[83];
			}
			if (reader[84] != DBNull.Value)
			{
				H017G0017 = (int?)reader[84];
			}
			if (reader[85] != DBNull.Value)
			{
				H017G0018 = (int?)reader[85];
			}
			if (reader[86] != DBNull.Value)
			{
				H017G0019 = (int?)reader[86];
			}
			if (reader[87] != DBNull.Value)
			{
				H017G0020 = (int?)reader[87];
			}
			if (reader[88] != DBNull.Value)
			{
				H017G0021 = (int?)reader[88];
			}
			if (reader[89] != DBNull.Value)
			{
				H017H0001 = (int?)reader[89];
			}
			if (reader[90] != DBNull.Value)
			{
				H017H0002 = (int?)reader[90];
			}
			if (reader[91] != DBNull.Value)
			{
				H017H0003 = (int?)reader[91];
			}
			if (reader[92] != DBNull.Value)
			{
				H017H0004 = (int?)reader[92];
			}
			if (reader[93] != DBNull.Value)
			{
				H017H0005 = (int?)reader[93];
			}
			if (reader[94] != DBNull.Value)
			{
				H017H0006 = (int?)reader[94];
			}
			if (reader[95] != DBNull.Value)
			{
				H017H0007 = (int?)reader[95];
			}
			if (reader[96] != DBNull.Value)
			{
				H017H0008 = (int?)reader[96];
			}
			if (reader[97] != DBNull.Value)
			{
				H017H0009 = (int?)reader[97];
			}
			if (reader[98] != DBNull.Value)
			{
				H017H0010 = (int?)reader[98];
			}
			if (reader[99] != DBNull.Value)
			{
				H017H0011 = (int?)reader[99];
			}
			if (reader[100] != DBNull.Value)
			{
				H017H0012 = (int?)reader[100];
			}
			if (reader[101] != DBNull.Value)
			{
				H017H0013 = (int?)reader[101];
			}
			if (reader[102] != DBNull.Value)
			{
				H017H0014 = (int?)reader[102];
			}
			if (reader[103] != DBNull.Value)
			{
				H017H0015 = (int?)reader[103];
			}
			if (reader[104] != DBNull.Value)
			{
				H017H0016 = (int?)reader[104];
			}
			if (reader[105] != DBNull.Value)
			{
				H017H0017 = (int?)reader[105];
			}
			if (reader[106] != DBNull.Value)
			{
				H017H0018 = (int?)reader[106];
			}
			if (reader[107] != DBNull.Value)
			{
				H017H0019 = (int?)reader[107];
			}
			if (reader[108] != DBNull.Value)
			{
				H017H0020 = (int?)reader[108];
			}
			if (reader[109] != DBNull.Value)
			{
				H017H0021 = (int?)reader[109];
			}
			if (reader[110] != DBNull.Value)
			{
				H017I0001 = (int?)reader[110];
			}
			if (reader[111] != DBNull.Value)
			{
				H017I0002 = (int?)reader[111];
			}
			if (reader[112] != DBNull.Value)
			{
				H017I0003 = (int?)reader[112];
			}
			if (reader[113] != DBNull.Value)
			{
				H017I0004 = (int?)reader[113];
			}
			if (reader[114] != DBNull.Value)
			{
				H017I0005 = (int?)reader[114];
			}
			if (reader[115] != DBNull.Value)
			{
				H017I0006 = (int?)reader[115];
			}
			if (reader[116] != DBNull.Value)
			{
				H017I0007 = (int?)reader[116];
			}
			if (reader[117] != DBNull.Value)
			{
				H017I0008 = (int?)reader[117];
			}
			if (reader[118] != DBNull.Value)
			{
				H017I0009 = (int?)reader[118];
			}
			if (reader[119] != DBNull.Value)
			{
				H017I0010 = (int?)reader[119];
			}
			if (reader[120] != DBNull.Value)
			{
				H017I0011 = (int?)reader[120];
			}
			if (reader[121] != DBNull.Value)
			{
				H017I0012 = (int?)reader[121];
			}
			if (reader[122] != DBNull.Value)
			{
				H017I0013 = (int?)reader[122];
			}
			if (reader[123] != DBNull.Value)
			{
				H017I0014 = (int?)reader[123];
			}
			if (reader[124] != DBNull.Value)
			{
				H017I0015 = (int?)reader[124];
			}
			if (reader[125] != DBNull.Value)
			{
				H017I0016 = (int?)reader[125];
			}
			if (reader[126] != DBNull.Value)
			{
				H017I0017 = (int?)reader[126];
			}
			if (reader[127] != DBNull.Value)
			{
				H017I0018 = (int?)reader[127];
			}
			if (reader[128] != DBNull.Value)
			{
				H017I0019 = (int?)reader[128];
			}
			if (reader[129] != DBNull.Value)
			{
				H017I0020 = (int?)reader[129];
			}
			if (reader[130] != DBNull.Value)
			{
				H017I0021 = (int?)reader[130];
			}
		}
		#endregion Constructors
	}
}
