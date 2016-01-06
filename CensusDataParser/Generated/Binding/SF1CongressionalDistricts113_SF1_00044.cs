#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/06/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1CongressionalDistricts113_SF1_00044.cs
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

	public class SF1CongressionalDistricts113_SF1_00044 : BaseModel
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
		public int? H0030001 { get; set; }

		[Display(Name = "Occupied", ShortName = "Occupied", Order = 6)]
		public int? H0030002 { get; set; }

		[Display(Name = "Vacant", ShortName = "Vacant", Order = 7)]
		public int? H0030003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 8)]
		public int? H0040001 { get; set; }

		[Display(Name = "Owned with a mortgage or a loan", ShortName = "Owned with a mortgage or a loan", Order = 9)]
		public int? H0040002 { get; set; }

		[Display(Name = "Owned free and clear", ShortName = "Owned free and clear", Order = 10)]
		public int? H0040003 { get; set; }

		[Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 11)]
		public int? H0040004 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 12)]
		public int? H0050001 { get; set; }

		[Display(Name = "For rent", ShortName = "For rent", Order = 13)]
		public int? H0050002 { get; set; }

		[Display(Name = "Rented, not occupied", ShortName = "Rented, not occupied", Order = 14)]
		public int? H0050003 { get; set; }

		[Display(Name = "For sale only", ShortName = "For sale only", Order = 15)]
		public int? H0050004 { get; set; }

		[Display(Name = "Sold, not occupied", ShortName = "Sold, not occupied", Order = 16)]
		public int? H0050005 { get; set; }

		[Display(Name = "For seasonal, recreational, or occasional use", ShortName = "For seasonal, recreational, or occasional use", Order = 17)]
		public int? H0050006 { get; set; }

		[Display(Name = "For migrant workers", ShortName = "For migrant workers", Order = 18)]
		public int? H0050007 { get; set; }

		[Display(Name = "Other vacant", ShortName = "Other vacant", Order = 19)]
		public int? H0050008 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 20)]
		public int? H0060001 { get; set; }

		[Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 21)]
		public int? H0060002 { get; set; }

		[Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 22)]
		public int? H0060003 { get; set; }

		[Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 23)]
		public int? H0060004 { get; set; }

		[Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 24)]
		public int? H0060005 { get; set; }

		[Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 25)]
		public int? H0060006 { get; set; }

		[Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 26)]
		public int? H0060007 { get; set; }

		[Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 27)]
		public int? H0060008 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 28)]
		public int? H0070001 { get; set; }

		[Display(Name = "Not Hispanic or Latino householder:", ShortName = "Not Hispanic or Latino householder:", Order = 29)]
		public int? H0070002 { get; set; }

		[Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 30)]
		public int? H0070003 { get; set; }

		[Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 31)]
		public int? H0070004 { get; set; }

		[Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 32)]
		public int? H0070005 { get; set; }

		[Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 33)]
		public int? H0070006 { get; set; }

		[Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 34)]
		public int? H0070007 { get; set; }

		[Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 35)]
		public int? H0070008 { get; set; }

		[Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 36)]
		public int? H0070009 { get; set; }

		[Display(Name = "Hispanic or Latino householder:", ShortName = "Hispanic or Latino householder:", Order = 37)]
		public int? H0070010 { get; set; }

		[Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 38)]
		public int? H0070011 { get; set; }

		[Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 39)]
		public int? H0070012 { get; set; }

		[Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 40)]
		public int? H0070013 { get; set; }

		[Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 41)]
		public int? H0070014 { get; set; }

		[Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 42)]
		public int? H0070015 { get; set; }

		[Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 43)]
		public int? H0070016 { get; set; }

		[Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 44)]
		public int? H0070017 { get; set; }

		[Display(Name = "Total races tallied for householders:", ShortName = "Total races tallied for householders:", Order = 45)]
		public int? H0080001 { get; set; }

		[Display(Name = "White alone or in combination with one or more other races", ShortName = "White alone or in combination with one or more other races", Order = 46)]
		public int? H0080002 { get; set; }

		[Display(Name = "Black or African American alone or in combination with one or more other races", ShortName = "Black or African American alone or in combination with one or more other races", Order = 47)]
		public int? H0080003 { get; set; }

		[Display(Name = "American Indian and Alaska Native alone or in combination with one or more other races", ShortName = "American Indian and Alaska Native alone or in combination with one or more other races", Order = 48)]
		public int? H0080004 { get; set; }

		[Display(Name = "Asian alone or in combination with one or more other races", ShortName = "Asian alone or in combination with one or more other races", Order = 49)]
		public int? H0080005 { get; set; }

		[Display(Name = "Native Hawaiian and Other Pacific Islander alone or in combination with one or more other races", ShortName = "Native Hawaiian and Other Pacific Islander alone or in combination with one or more other races", Order = 50)]
		public int? H0080006 { get; set; }

		[Display(Name = "Some Other Race alone or in combination with one or more other races", ShortName = "Some Other Race alone or in combination with one or more other races", Order = 51)]
		public int? H0080007 { get; set; }

		[Display(Name = "Total races tallied for householders:", ShortName = "Total races tallied for householders:", Order = 52)]
		public int? H0090001 { get; set; }

		[Display(Name = "Total races tallied for Not Hispanic or Latino householders:", ShortName = "Total races tallied for Not Hispanic or Latino householders:", Order = 53)]
		public int? H0090002 { get; set; }

		[Display(Name = "White alone or in combination with one or more other races", ShortName = "White alone or in combination with one or more other races", Order = 54)]
		public int? H0090003 { get; set; }

		[Display(Name = "Black or African American alone or in combination with one or more other races", ShortName = "Black or African American alone or in combination with one or more other races", Order = 55)]
		public int? H0090004 { get; set; }

		[Display(Name = "American Indian and Alaska Native alone or in combination with one or more other races", ShortName = "American Indian and Alaska Native alone or in combination with one or more other races", Order = 56)]
		public int? H0090005 { get; set; }

		[Display(Name = "Asian alone or in combination with one or more other races", ShortName = "Asian alone or in combination with one or more other races", Order = 57)]
		public int? H0090006 { get; set; }

		[Display(Name = "Native Hawaiian and Other Pacific Islander alone or in combination with one or more other races", ShortName = "Native Hawaiian and Other Pacific Islander alone or in combination with one or more other races", Order = 58)]
		public int? H0090007 { get; set; }

		[Display(Name = "Some Other Race alone or in combination with one or more other races", ShortName = "Some Other Race alone or in combination with one or more other races", Order = 59)]
		public int? H0090008 { get; set; }

		[Display(Name = "Total races tallied for Hispanic or Latino householders:", ShortName = "Total races tallied for Hispanic or Latino householders:", Order = 60)]
		public int? H0090009 { get; set; }

		[Display(Name = "White alone or in combination with one or more other races", ShortName = "White alone or in combination with one or more other races", Order = 61)]
		public int? H0090010 { get; set; }

		[Display(Name = "Black or African American alone or in combination with one or more other races", ShortName = "Black or African American alone or in combination with one or more other races", Order = 62)]
		public int? H0090011 { get; set; }

		[Display(Name = "American Indian and Alaska Native alone or in combination with one or more other races", ShortName = "American Indian and Alaska Native alone or in combination with one or more other races", Order = 63)]
		public int? H0090012 { get; set; }

		[Display(Name = "Asian alone or in combination with one or more other races", ShortName = "Asian alone or in combination with one or more other races", Order = 64)]
		public int? H0090013 { get; set; }

		[Display(Name = "Native Hawaiian and Other Pacific Islander alone or in combination with one or more other races", ShortName = "Native Hawaiian and Other Pacific Islander alone or in combination with one or more other races", Order = 65)]
		public int? H0090014 { get; set; }

		[Display(Name = "Some Other Race alone or in combination with one or more other races", ShortName = "Some Other Race alone or in combination with one or more other races", Order = 66)]
		public int? H0090015 { get; set; }

		[Display(Name = "Total", ShortName = "Total", Order = 67)]
		public int? H0100001 { get; set; }

		[Display(Name = "Total population in occupied housing units:", ShortName = "Total population in occupied housing units:", Order = 68)]
		public int? H0110001 { get; set; }

		[Display(Name = "Owned with a mortgage or a loan", ShortName = "Owned with a mortgage or a loan", Order = 69)]
		public int? H0110002 { get; set; }

		[Display(Name = "Owned free and clear", ShortName = "Owned free and clear", Order = 70)]
		public int? H0110003 { get; set; }

		[Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 71)]
		public int? H0110004 { get; set; }

		[Display(Name = "Total", ShortName = "Total", Order = 72)]
		public decimal? H0120001 { get; set; }

		[Display(Name = "Owner occupied", ShortName = "Owner occupied", Order = 73)]
		public decimal? H0120002 { get; set; }

		[Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 74)]
		public decimal? H0120003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 75)]
		public int? H0130001 { get; set; }

		[Display(Name = "1-person household", ShortName = "1-person household", Order = 76)]
		public int? H0130002 { get; set; }

		[Display(Name = "2-person household", ShortName = "2-person household", Order = 77)]
		public int? H0130003 { get; set; }

		[Display(Name = "3-person household", ShortName = "3-person household", Order = 78)]
		public int? H0130004 { get; set; }

		[Display(Name = "4-person household", ShortName = "4-person household", Order = 79)]
		public int? H0130005 { get; set; }

		[Display(Name = "5-person household", ShortName = "5-person household", Order = 80)]
		public int? H0130006 { get; set; }

		[Display(Name = "6-person household", ShortName = "6-person household", Order = 81)]
		public int? H0130007 { get; set; }

		[Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 82)]
		public int? H0130008 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 83)]
		public int? H0140001 { get; set; }

		[Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 84)]
		public int? H0140002 { get; set; }

		[Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 85)]
		public int? H0140003 { get; set; }

		[Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 86)]
		public int? H0140004 { get; set; }

		[Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 87)]
		public int? H0140005 { get; set; }

		[Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 88)]
		public int? H0140006 { get; set; }

		[Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 89)]
		public int? H0140007 { get; set; }

		[Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 90)]
		public int? H0140008 { get; set; }

		[Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 91)]
		public int? H0140009 { get; set; }

		[Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 92)]
		public int? H0140010 { get; set; }

		[Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 93)]
		public int? H0140011 { get; set; }

		[Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 94)]
		public int? H0140012 { get; set; }

		[Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 95)]
		public int? H0140013 { get; set; }

		[Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 96)]
		public int? H0140014 { get; set; }

		[Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 97)]
		public int? H0140015 { get; set; }

		[Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 98)]
		public int? H0140016 { get; set; }

		[Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 99)]
		public int? H0140017 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 100)]
		public int? H0150001 { get; set; }

		[Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 101)]
		public int? H0150002 { get; set; }

		[Display(Name = "Not Hispanic or Latino householder", ShortName = "Not Hispanic or Latino householder", Order = 102)]
		public int? H0150003 { get; set; }

		[Display(Name = "Hispanic or Latino householder", ShortName = "Hispanic or Latino householder", Order = 103)]
		public int? H0150004 { get; set; }

		[Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 104)]
		public int? H0150005 { get; set; }

		[Display(Name = "Not Hispanic or Latino householder", ShortName = "Not Hispanic or Latino householder", Order = 105)]
		public int? H0150006 { get; set; }

		[Display(Name = "Hispanic or Latino householder", ShortName = "Hispanic or Latino householder", Order = 106)]
		public int? H0150007 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 107)]
		public int? H0160001 { get; set; }

		[Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 108)]
		public int? H0160002 { get; set; }

		[Display(Name = "1-person household", ShortName = "1-person household", Order = 109)]
		public int? H0160003 { get; set; }

		[Display(Name = "2-person household", ShortName = "2-person household", Order = 110)]
		public int? H0160004 { get; set; }

		[Display(Name = "3-person household", ShortName = "3-person household", Order = 111)]
		public int? H0160005 { get; set; }

		[Display(Name = "4-person household", ShortName = "4-person household", Order = 112)]
		public int? H0160006 { get; set; }

		[Display(Name = "5-person household", ShortName = "5-person household", Order = 113)]
		public int? H0160007 { get; set; }

		[Display(Name = "6-person household", ShortName = "6-person household", Order = 114)]
		public int? H0160008 { get; set; }

		[Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 115)]
		public int? H0160009 { get; set; }

		[Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 116)]
		public int? H0160010 { get; set; }

		[Display(Name = "1-person household", ShortName = "1-person household", Order = 117)]
		public int? H0160011 { get; set; }

		[Display(Name = "2-person household", ShortName = "2-person household", Order = 118)]
		public int? H0160012 { get; set; }

		[Display(Name = "3-person household", ShortName = "3-person household", Order = 119)]
		public int? H0160013 { get; set; }

		[Display(Name = "4-person household", ShortName = "4-person household", Order = 120)]
		public int? H0160014 { get; set; }

		[Display(Name = "5-person household", ShortName = "5-person household", Order = 121)]
		public int? H0160015 { get; set; }

		[Display(Name = "6-person household", ShortName = "6-person household", Order = 122)]
		public int? H0160016 { get; set; }

		[Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 123)]
		public int? H0160017 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 124)]
		public int? H0170001 { get; set; }

		[Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 125)]
		public int? H0170002 { get; set; }

		[Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 126)]
		public int? H0170003 { get; set; }

		[Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 127)]
		public int? H0170004 { get; set; }

		[Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 128)]
		public int? H0170005 { get; set; }

		[Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 129)]
		public int? H0170006 { get; set; }

		[Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 130)]
		public int? H0170007 { get; set; }

		[Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 131)]
		public int? H0170008 { get; set; }

		[Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 132)]
		public int? H0170009 { get; set; }

		[Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 133)]
		public int? H0170010 { get; set; }

		[Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 134)]
		public int? H0170011 { get; set; }

		[Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 135)]
		public int? H0170012 { get; set; }

		[Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 136)]
		public int? H0170013 { get; set; }

		[Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 137)]
		public int? H0170014 { get; set; }

		[Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 138)]
		public int? H0170015 { get; set; }

		[Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 139)]
		public int? H0170016 { get; set; }

		[Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 140)]
		public int? H0170017 { get; set; }

		[Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 141)]
		public int? H0170018 { get; set; }

		[Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 142)]
		public int? H0170019 { get; set; }

		[Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 143)]
		public int? H0170020 { get; set; }

		[Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 144)]
		public int? H0170021 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 145)]
		public int? H0180001 { get; set; }

		[Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 146)]
		public int? H0180002 { get; set; }

		[Display(Name = "Family households:", ShortName = "Family households:", Order = 147)]
		public int? H0180003 { get; set; }

		[Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 148)]
		public int? H0180004 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 149)]
		public int? H0180005 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 150)]
		public int? H0180006 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 151)]
		public int? H0180007 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 152)]
		public int? H0180008 { get; set; }

		[Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 153)]
		public int? H0180009 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 154)]
		public int? H0180010 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 155)]
		public int? H0180011 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 156)]
		public int? H0180012 { get; set; }

		[Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 157)]
		public int? H0180013 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 158)]
		public int? H0180014 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 159)]
		public int? H0180015 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 160)]
		public int? H0180016 { get; set; }

		[Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 161)]
		public int? H0180017 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 162)]
		public int? H0180018 { get; set; }

		[Display(Name = "Living alone:", ShortName = "Living alone:", Order = 163)]
		public int? H0180019 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 164)]
		public int? H0180020 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 165)]
		public int? H0180021 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 166)]
		public int? H0180022 { get; set; }

		[Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 167)]
		public int? H0180023 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 168)]
		public int? H0180024 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 169)]
		public int? H0180025 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 170)]
		public int? H0180026 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 171)]
		public int? H0180027 { get; set; }

		[Display(Name = "Living alone:", ShortName = "Living alone:", Order = 172)]
		public int? H0180028 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 173)]
		public int? H0180029 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 174)]
		public int? H0180030 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 175)]
		public int? H0180031 { get; set; }

		[Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 176)]
		public int? H0180032 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 177)]
		public int? H0180033 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 178)]
		public int? H0180034 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 179)]
		public int? H0180035 { get; set; }

		[Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 180)]
		public int? H0180036 { get; set; }

		[Display(Name = "Family households:", ShortName = "Family households:", Order = 181)]
		public int? H0180037 { get; set; }

		[Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 182)]
		public int? H0180038 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 183)]
		public int? H0180039 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 184)]
		public int? H0180040 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 185)]
		public int? H0180041 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 186)]
		public int? H0180042 { get; set; }

		[Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 187)]
		public int? H0180043 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 188)]
		public int? H0180044 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 189)]
		public int? H0180045 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 190)]
		public int? H0180046 { get; set; }

		[Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 191)]
		public int? H0180047 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 192)]
		public int? H0180048 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 193)]
		public int? H0180049 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 194)]
		public int? H0180050 { get; set; }

		[Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 195)]
		public int? H0180051 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 196)]
		public int? H0180052 { get; set; }

		[Display(Name = "Living alone:", ShortName = "Living alone:", Order = 197)]
		public int? H0180053 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 198)]
		public int? H0180054 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 199)]
		public int? H0180055 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 200)]
		public int? H0180056 { get; set; }

		[Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 201)]
		public int? H0180057 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 202)]
		public int? H0180058 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 203)]
		public int? H0180059 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 204)]
		public int? H0180060 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 205)]
		public int? H0180061 { get; set; }

		[Display(Name = "Living alone:", ShortName = "Living alone:", Order = 206)]
		public int? H0180062 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 207)]
		public int? H0180063 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 208)]
		public int? H0180064 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 209)]
		public int? H0180065 { get; set; }

		[Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 210)]
		public int? H0180066 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 211)]
		public int? H0180067 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 212)]
		public int? H0180068 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 213)]
		public int? H0180069 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 214)]
		public int? H0190001 { get; set; }

		[Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 215)]
		public int? H0190002 { get; set; }

		[Display(Name = "With children under 18 years", ShortName = "With children under 18 years", Order = 216)]
		public int? H0190003 { get; set; }

		[Display(Name = "No children under 18 years", ShortName = "No children under 18 years", Order = 217)]
		public int? H0190004 { get; set; }

		[Display(Name = "Renter-occupied:", ShortName = "Renter-occupied:", Order = 218)]
		public int? H0190005 { get; set; }

		[Display(Name = "With children under 18 years", ShortName = "With children under 18 years", Order = 219)]
		public int? H0190006 { get; set; }

		[Display(Name = "No children under 18 years", ShortName = "No children under 18 years", Order = 220)]
		public int? H0190007 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 221)]
		public int? H0200001 { get; set; }

		[Display(Name = "Substituted", ShortName = "Substituted", Order = 222)]
		public int? H0200002 { get; set; }

		[Display(Name = "Not substituted", ShortName = "Not substituted", Order = 223)]
		public int? H0200003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 224)]
		public int? H0210001 { get; set; }

		[Display(Name = "Allocated", ShortName = "Allocated", Order = 225)]
		public int? H0210002 { get; set; }

		[Display(Name = "Not allocated", ShortName = "Not allocated", Order = 226)]
		public int? H0210003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 227)]
		public int? H0220001 { get; set; }

		[Display(Name = "Allocated", ShortName = "Allocated", Order = 228)]
		public int? H0220002 { get; set; }

		[Display(Name = "Not allocated", ShortName = "Not allocated", Order = 229)]
		public int? H0220003 { get; set; }

		[Display(Name = "Population in occupied housing units:", ShortName = "Population in occupied housing units:", Order = 230)]
		public int? H011A0001 { get; set; }

		[Display(Name = "Owned with a mortgage or a loan", ShortName = "Owned with a mortgage or a loan", Order = 231)]
		public int? H011A0002 { get; set; }

		[Display(Name = "Owned free and clear", ShortName = "Owned free and clear", Order = 232)]
		public int? H011A0003 { get; set; }

		[Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 233)]
		public int? H011A0004 { get; set; }

		[Display(Name = "Population in occupied housing units:", ShortName = "Population in occupied housing units:", Order = 234)]
		public int? H011B0001 { get; set; }

		[Display(Name = "Owned with a mortgage or a loan", ShortName = "Owned with a mortgage or a loan", Order = 235)]
		public int? H011B0002 { get; set; }

		[Display(Name = "Owned free and clear", ShortName = "Owned free and clear", Order = 236)]
		public int? H011B0003 { get; set; }

		[Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 237)]
		public int? H011B0004 { get; set; }

		[Display(Name = "Population in occupied housing units:", ShortName = "Population in occupied housing units:", Order = 238)]
		public int? H011C0001 { get; set; }

		[Display(Name = "Owned with a mortgage or a loan", ShortName = "Owned with a mortgage or a loan", Order = 239)]
		public int? H011C0002 { get; set; }

		[Display(Name = "Owned free and clear", ShortName = "Owned free and clear", Order = 240)]
		public int? H011C0003 { get; set; }

		[Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 241)]
		public int? H011C0004 { get; set; }

		[Display(Name = "Population in occupied housing units:", ShortName = "Population in occupied housing units:", Order = 242)]
		public int? H011D0001 { get; set; }

		[Display(Name = "Owned with a mortgage or a loan", ShortName = "Owned with a mortgage or a loan", Order = 243)]
		public int? H011D0002 { get; set; }

		[Display(Name = "Owned free and clear", ShortName = "Owned free and clear", Order = 244)]
		public int? H011D0003 { get; set; }

		[Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 245)]
		public int? H011D0004 { get; set; }

		[Display(Name = "Population in occupied housing units:", ShortName = "Population in occupied housing units:", Order = 246)]
		public int? H011E0001 { get; set; }

		[Display(Name = "Owned with a mortgage or a loan", ShortName = "Owned with a mortgage or a loan", Order = 247)]
		public int? H011E0002 { get; set; }

		[Display(Name = "Owned free and clear", ShortName = "Owned free and clear", Order = 248)]
		public int? H011E0003 { get; set; }

		[Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 249)]
		public int? H011E0004 { get; set; }

		[Display(Name = "Population in occupied housing units:", ShortName = "Population in occupied housing units:", Order = 250)]
		public int? H011F0001 { get; set; }

		[Display(Name = "Owned with a mortgage or a loan", ShortName = "Owned with a mortgage or a loan", Order = 251)]
		public int? H011F0002 { get; set; }

		[Display(Name = "Owned free and clear", ShortName = "Owned free and clear", Order = 252)]
		public int? H011F0003 { get; set; }

		[Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 253)]
		public int? H011F0004 { get; set; }
		#endregion Properties

		#region Constructors
		public SF1CongressionalDistricts113_SF1_00044(string csvLine) : base(csvLine) { }

		public SF1CongressionalDistricts113_SF1_00044(string[] values) : base(values) { }

		public SF1CongressionalDistricts113_SF1_00044(OleDbDataReader reader)
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
				H0030001 = (int?)reader[5];
			}
			if (reader[6] != DBNull.Value)
			{
				H0030002 = (int?)reader[6];
			}
			if (reader[7] != DBNull.Value)
			{
				H0030003 = (int?)reader[7];
			}
			if (reader[8] != DBNull.Value)
			{
				H0040001 = (int?)reader[8];
			}
			if (reader[9] != DBNull.Value)
			{
				H0040002 = (int?)reader[9];
			}
			if (reader[10] != DBNull.Value)
			{
				H0040003 = (int?)reader[10];
			}
			if (reader[11] != DBNull.Value)
			{
				H0040004 = (int?)reader[11];
			}
			if (reader[12] != DBNull.Value)
			{
				H0050001 = (int?)reader[12];
			}
			if (reader[13] != DBNull.Value)
			{
				H0050002 = (int?)reader[13];
			}
			if (reader[14] != DBNull.Value)
			{
				H0050003 = (int?)reader[14];
			}
			if (reader[15] != DBNull.Value)
			{
				H0050004 = (int?)reader[15];
			}
			if (reader[16] != DBNull.Value)
			{
				H0050005 = (int?)reader[16];
			}
			if (reader[17] != DBNull.Value)
			{
				H0050006 = (int?)reader[17];
			}
			if (reader[18] != DBNull.Value)
			{
				H0050007 = (int?)reader[18];
			}
			if (reader[19] != DBNull.Value)
			{
				H0050008 = (int?)reader[19];
			}
			if (reader[20] != DBNull.Value)
			{
				H0060001 = (int?)reader[20];
			}
			if (reader[21] != DBNull.Value)
			{
				H0060002 = (int?)reader[21];
			}
			if (reader[22] != DBNull.Value)
			{
				H0060003 = (int?)reader[22];
			}
			if (reader[23] != DBNull.Value)
			{
				H0060004 = (int?)reader[23];
			}
			if (reader[24] != DBNull.Value)
			{
				H0060005 = (int?)reader[24];
			}
			if (reader[25] != DBNull.Value)
			{
				H0060006 = (int?)reader[25];
			}
			if (reader[26] != DBNull.Value)
			{
				H0060007 = (int?)reader[26];
			}
			if (reader[27] != DBNull.Value)
			{
				H0060008 = (int?)reader[27];
			}
			if (reader[28] != DBNull.Value)
			{
				H0070001 = (int?)reader[28];
			}
			if (reader[29] != DBNull.Value)
			{
				H0070002 = (int?)reader[29];
			}
			if (reader[30] != DBNull.Value)
			{
				H0070003 = (int?)reader[30];
			}
			if (reader[31] != DBNull.Value)
			{
				H0070004 = (int?)reader[31];
			}
			if (reader[32] != DBNull.Value)
			{
				H0070005 = (int?)reader[32];
			}
			if (reader[33] != DBNull.Value)
			{
				H0070006 = (int?)reader[33];
			}
			if (reader[34] != DBNull.Value)
			{
				H0070007 = (int?)reader[34];
			}
			if (reader[35] != DBNull.Value)
			{
				H0070008 = (int?)reader[35];
			}
			if (reader[36] != DBNull.Value)
			{
				H0070009 = (int?)reader[36];
			}
			if (reader[37] != DBNull.Value)
			{
				H0070010 = (int?)reader[37];
			}
			if (reader[38] != DBNull.Value)
			{
				H0070011 = (int?)reader[38];
			}
			if (reader[39] != DBNull.Value)
			{
				H0070012 = (int?)reader[39];
			}
			if (reader[40] != DBNull.Value)
			{
				H0070013 = (int?)reader[40];
			}
			if (reader[41] != DBNull.Value)
			{
				H0070014 = (int?)reader[41];
			}
			if (reader[42] != DBNull.Value)
			{
				H0070015 = (int?)reader[42];
			}
			if (reader[43] != DBNull.Value)
			{
				H0070016 = (int?)reader[43];
			}
			if (reader[44] != DBNull.Value)
			{
				H0070017 = (int?)reader[44];
			}
			if (reader[45] != DBNull.Value)
			{
				H0080001 = (int?)reader[45];
			}
			if (reader[46] != DBNull.Value)
			{
				H0080002 = (int?)reader[46];
			}
			if (reader[47] != DBNull.Value)
			{
				H0080003 = (int?)reader[47];
			}
			if (reader[48] != DBNull.Value)
			{
				H0080004 = (int?)reader[48];
			}
			if (reader[49] != DBNull.Value)
			{
				H0080005 = (int?)reader[49];
			}
			if (reader[50] != DBNull.Value)
			{
				H0080006 = (int?)reader[50];
			}
			if (reader[51] != DBNull.Value)
			{
				H0080007 = (int?)reader[51];
			}
			if (reader[52] != DBNull.Value)
			{
				H0090001 = (int?)reader[52];
			}
			if (reader[53] != DBNull.Value)
			{
				H0090002 = (int?)reader[53];
			}
			if (reader[54] != DBNull.Value)
			{
				H0090003 = (int?)reader[54];
			}
			if (reader[55] != DBNull.Value)
			{
				H0090004 = (int?)reader[55];
			}
			if (reader[56] != DBNull.Value)
			{
				H0090005 = (int?)reader[56];
			}
			if (reader[57] != DBNull.Value)
			{
				H0090006 = (int?)reader[57];
			}
			if (reader[58] != DBNull.Value)
			{
				H0090007 = (int?)reader[58];
			}
			if (reader[59] != DBNull.Value)
			{
				H0090008 = (int?)reader[59];
			}
			if (reader[60] != DBNull.Value)
			{
				H0090009 = (int?)reader[60];
			}
			if (reader[61] != DBNull.Value)
			{
				H0090010 = (int?)reader[61];
			}
			if (reader[62] != DBNull.Value)
			{
				H0090011 = (int?)reader[62];
			}
			if (reader[63] != DBNull.Value)
			{
				H0090012 = (int?)reader[63];
			}
			if (reader[64] != DBNull.Value)
			{
				H0090013 = (int?)reader[64];
			}
			if (reader[65] != DBNull.Value)
			{
				H0090014 = (int?)reader[65];
			}
			if (reader[66] != DBNull.Value)
			{
				H0090015 = (int?)reader[66];
			}
			if (reader[67] != DBNull.Value)
			{
				H0100001 = (int?)reader[67];
			}
			if (reader[68] != DBNull.Value)
			{
				H0110001 = (int?)reader[68];
			}
			if (reader[69] != DBNull.Value)
			{
				H0110002 = (int?)reader[69];
			}
			if (reader[70] != DBNull.Value)
			{
				H0110003 = (int?)reader[70];
			}
			if (reader[71] != DBNull.Value)
			{
				H0110004 = (int?)reader[71];
			}
			if (reader[72] != DBNull.Value)
			{
				H0120001 = (decimal?)reader[72];
			}
			if (reader[73] != DBNull.Value)
			{
				H0120002 = (decimal?)reader[73];
			}
			if (reader[74] != DBNull.Value)
			{
				H0120003 = (decimal?)reader[74];
			}
			if (reader[75] != DBNull.Value)
			{
				H0130001 = (int?)reader[75];
			}
			if (reader[76] != DBNull.Value)
			{
				H0130002 = (int?)reader[76];
			}
			if (reader[77] != DBNull.Value)
			{
				H0130003 = (int?)reader[77];
			}
			if (reader[78] != DBNull.Value)
			{
				H0130004 = (int?)reader[78];
			}
			if (reader[79] != DBNull.Value)
			{
				H0130005 = (int?)reader[79];
			}
			if (reader[80] != DBNull.Value)
			{
				H0130006 = (int?)reader[80];
			}
			if (reader[81] != DBNull.Value)
			{
				H0130007 = (int?)reader[81];
			}
			if (reader[82] != DBNull.Value)
			{
				H0130008 = (int?)reader[82];
			}
			if (reader[83] != DBNull.Value)
			{
				H0140001 = (int?)reader[83];
			}
			if (reader[84] != DBNull.Value)
			{
				H0140002 = (int?)reader[84];
			}
			if (reader[85] != DBNull.Value)
			{
				H0140003 = (int?)reader[85];
			}
			if (reader[86] != DBNull.Value)
			{
				H0140004 = (int?)reader[86];
			}
			if (reader[87] != DBNull.Value)
			{
				H0140005 = (int?)reader[87];
			}
			if (reader[88] != DBNull.Value)
			{
				H0140006 = (int?)reader[88];
			}
			if (reader[89] != DBNull.Value)
			{
				H0140007 = (int?)reader[89];
			}
			if (reader[90] != DBNull.Value)
			{
				H0140008 = (int?)reader[90];
			}
			if (reader[91] != DBNull.Value)
			{
				H0140009 = (int?)reader[91];
			}
			if (reader[92] != DBNull.Value)
			{
				H0140010 = (int?)reader[92];
			}
			if (reader[93] != DBNull.Value)
			{
				H0140011 = (int?)reader[93];
			}
			if (reader[94] != DBNull.Value)
			{
				H0140012 = (int?)reader[94];
			}
			if (reader[95] != DBNull.Value)
			{
				H0140013 = (int?)reader[95];
			}
			if (reader[96] != DBNull.Value)
			{
				H0140014 = (int?)reader[96];
			}
			if (reader[97] != DBNull.Value)
			{
				H0140015 = (int?)reader[97];
			}
			if (reader[98] != DBNull.Value)
			{
				H0140016 = (int?)reader[98];
			}
			if (reader[99] != DBNull.Value)
			{
				H0140017 = (int?)reader[99];
			}
			if (reader[100] != DBNull.Value)
			{
				H0150001 = (int?)reader[100];
			}
			if (reader[101] != DBNull.Value)
			{
				H0150002 = (int?)reader[101];
			}
			if (reader[102] != DBNull.Value)
			{
				H0150003 = (int?)reader[102];
			}
			if (reader[103] != DBNull.Value)
			{
				H0150004 = (int?)reader[103];
			}
			if (reader[104] != DBNull.Value)
			{
				H0150005 = (int?)reader[104];
			}
			if (reader[105] != DBNull.Value)
			{
				H0150006 = (int?)reader[105];
			}
			if (reader[106] != DBNull.Value)
			{
				H0150007 = (int?)reader[106];
			}
			if (reader[107] != DBNull.Value)
			{
				H0160001 = (int?)reader[107];
			}
			if (reader[108] != DBNull.Value)
			{
				H0160002 = (int?)reader[108];
			}
			if (reader[109] != DBNull.Value)
			{
				H0160003 = (int?)reader[109];
			}
			if (reader[110] != DBNull.Value)
			{
				H0160004 = (int?)reader[110];
			}
			if (reader[111] != DBNull.Value)
			{
				H0160005 = (int?)reader[111];
			}
			if (reader[112] != DBNull.Value)
			{
				H0160006 = (int?)reader[112];
			}
			if (reader[113] != DBNull.Value)
			{
				H0160007 = (int?)reader[113];
			}
			if (reader[114] != DBNull.Value)
			{
				H0160008 = (int?)reader[114];
			}
			if (reader[115] != DBNull.Value)
			{
				H0160009 = (int?)reader[115];
			}
			if (reader[116] != DBNull.Value)
			{
				H0160010 = (int?)reader[116];
			}
			if (reader[117] != DBNull.Value)
			{
				H0160011 = (int?)reader[117];
			}
			if (reader[118] != DBNull.Value)
			{
				H0160012 = (int?)reader[118];
			}
			if (reader[119] != DBNull.Value)
			{
				H0160013 = (int?)reader[119];
			}
			if (reader[120] != DBNull.Value)
			{
				H0160014 = (int?)reader[120];
			}
			if (reader[121] != DBNull.Value)
			{
				H0160015 = (int?)reader[121];
			}
			if (reader[122] != DBNull.Value)
			{
				H0160016 = (int?)reader[122];
			}
			if (reader[123] != DBNull.Value)
			{
				H0160017 = (int?)reader[123];
			}
			if (reader[124] != DBNull.Value)
			{
				H0170001 = (int?)reader[124];
			}
			if (reader[125] != DBNull.Value)
			{
				H0170002 = (int?)reader[125];
			}
			if (reader[126] != DBNull.Value)
			{
				H0170003 = (int?)reader[126];
			}
			if (reader[127] != DBNull.Value)
			{
				H0170004 = (int?)reader[127];
			}
			if (reader[128] != DBNull.Value)
			{
				H0170005 = (int?)reader[128];
			}
			if (reader[129] != DBNull.Value)
			{
				H0170006 = (int?)reader[129];
			}
			if (reader[130] != DBNull.Value)
			{
				H0170007 = (int?)reader[130];
			}
			if (reader[131] != DBNull.Value)
			{
				H0170008 = (int?)reader[131];
			}
			if (reader[132] != DBNull.Value)
			{
				H0170009 = (int?)reader[132];
			}
			if (reader[133] != DBNull.Value)
			{
				H0170010 = (int?)reader[133];
			}
			if (reader[134] != DBNull.Value)
			{
				H0170011 = (int?)reader[134];
			}
			if (reader[135] != DBNull.Value)
			{
				H0170012 = (int?)reader[135];
			}
			if (reader[136] != DBNull.Value)
			{
				H0170013 = (int?)reader[136];
			}
			if (reader[137] != DBNull.Value)
			{
				H0170014 = (int?)reader[137];
			}
			if (reader[138] != DBNull.Value)
			{
				H0170015 = (int?)reader[138];
			}
			if (reader[139] != DBNull.Value)
			{
				H0170016 = (int?)reader[139];
			}
			if (reader[140] != DBNull.Value)
			{
				H0170017 = (int?)reader[140];
			}
			if (reader[141] != DBNull.Value)
			{
				H0170018 = (int?)reader[141];
			}
			if (reader[142] != DBNull.Value)
			{
				H0170019 = (int?)reader[142];
			}
			if (reader[143] != DBNull.Value)
			{
				H0170020 = (int?)reader[143];
			}
			if (reader[144] != DBNull.Value)
			{
				H0170021 = (int?)reader[144];
			}
			if (reader[145] != DBNull.Value)
			{
				H0180001 = (int?)reader[145];
			}
			if (reader[146] != DBNull.Value)
			{
				H0180002 = (int?)reader[146];
			}
			if (reader[147] != DBNull.Value)
			{
				H0180003 = (int?)reader[147];
			}
			if (reader[148] != DBNull.Value)
			{
				H0180004 = (int?)reader[148];
			}
			if (reader[149] != DBNull.Value)
			{
				H0180005 = (int?)reader[149];
			}
			if (reader[150] != DBNull.Value)
			{
				H0180006 = (int?)reader[150];
			}
			if (reader[151] != DBNull.Value)
			{
				H0180007 = (int?)reader[151];
			}
			if (reader[152] != DBNull.Value)
			{
				H0180008 = (int?)reader[152];
			}
			if (reader[153] != DBNull.Value)
			{
				H0180009 = (int?)reader[153];
			}
			if (reader[154] != DBNull.Value)
			{
				H0180010 = (int?)reader[154];
			}
			if (reader[155] != DBNull.Value)
			{
				H0180011 = (int?)reader[155];
			}
			if (reader[156] != DBNull.Value)
			{
				H0180012 = (int?)reader[156];
			}
			if (reader[157] != DBNull.Value)
			{
				H0180013 = (int?)reader[157];
			}
			if (reader[158] != DBNull.Value)
			{
				H0180014 = (int?)reader[158];
			}
			if (reader[159] != DBNull.Value)
			{
				H0180015 = (int?)reader[159];
			}
			if (reader[160] != DBNull.Value)
			{
				H0180016 = (int?)reader[160];
			}
			if (reader[161] != DBNull.Value)
			{
				H0180017 = (int?)reader[161];
			}
			if (reader[162] != DBNull.Value)
			{
				H0180018 = (int?)reader[162];
			}
			if (reader[163] != DBNull.Value)
			{
				H0180019 = (int?)reader[163];
			}
			if (reader[164] != DBNull.Value)
			{
				H0180020 = (int?)reader[164];
			}
			if (reader[165] != DBNull.Value)
			{
				H0180021 = (int?)reader[165];
			}
			if (reader[166] != DBNull.Value)
			{
				H0180022 = (int?)reader[166];
			}
			if (reader[167] != DBNull.Value)
			{
				H0180023 = (int?)reader[167];
			}
			if (reader[168] != DBNull.Value)
			{
				H0180024 = (int?)reader[168];
			}
			if (reader[169] != DBNull.Value)
			{
				H0180025 = (int?)reader[169];
			}
			if (reader[170] != DBNull.Value)
			{
				H0180026 = (int?)reader[170];
			}
			if (reader[171] != DBNull.Value)
			{
				H0180027 = (int?)reader[171];
			}
			if (reader[172] != DBNull.Value)
			{
				H0180028 = (int?)reader[172];
			}
			if (reader[173] != DBNull.Value)
			{
				H0180029 = (int?)reader[173];
			}
			if (reader[174] != DBNull.Value)
			{
				H0180030 = (int?)reader[174];
			}
			if (reader[175] != DBNull.Value)
			{
				H0180031 = (int?)reader[175];
			}
			if (reader[176] != DBNull.Value)
			{
				H0180032 = (int?)reader[176];
			}
			if (reader[177] != DBNull.Value)
			{
				H0180033 = (int?)reader[177];
			}
			if (reader[178] != DBNull.Value)
			{
				H0180034 = (int?)reader[178];
			}
			if (reader[179] != DBNull.Value)
			{
				H0180035 = (int?)reader[179];
			}
			if (reader[180] != DBNull.Value)
			{
				H0180036 = (int?)reader[180];
			}
			if (reader[181] != DBNull.Value)
			{
				H0180037 = (int?)reader[181];
			}
			if (reader[182] != DBNull.Value)
			{
				H0180038 = (int?)reader[182];
			}
			if (reader[183] != DBNull.Value)
			{
				H0180039 = (int?)reader[183];
			}
			if (reader[184] != DBNull.Value)
			{
				H0180040 = (int?)reader[184];
			}
			if (reader[185] != DBNull.Value)
			{
				H0180041 = (int?)reader[185];
			}
			if (reader[186] != DBNull.Value)
			{
				H0180042 = (int?)reader[186];
			}
			if (reader[187] != DBNull.Value)
			{
				H0180043 = (int?)reader[187];
			}
			if (reader[188] != DBNull.Value)
			{
				H0180044 = (int?)reader[188];
			}
			if (reader[189] != DBNull.Value)
			{
				H0180045 = (int?)reader[189];
			}
			if (reader[190] != DBNull.Value)
			{
				H0180046 = (int?)reader[190];
			}
			if (reader[191] != DBNull.Value)
			{
				H0180047 = (int?)reader[191];
			}
			if (reader[192] != DBNull.Value)
			{
				H0180048 = (int?)reader[192];
			}
			if (reader[193] != DBNull.Value)
			{
				H0180049 = (int?)reader[193];
			}
			if (reader[194] != DBNull.Value)
			{
				H0180050 = (int?)reader[194];
			}
			if (reader[195] != DBNull.Value)
			{
				H0180051 = (int?)reader[195];
			}
			if (reader[196] != DBNull.Value)
			{
				H0180052 = (int?)reader[196];
			}
			if (reader[197] != DBNull.Value)
			{
				H0180053 = (int?)reader[197];
			}
			if (reader[198] != DBNull.Value)
			{
				H0180054 = (int?)reader[198];
			}
			if (reader[199] != DBNull.Value)
			{
				H0180055 = (int?)reader[199];
			}
			if (reader[200] != DBNull.Value)
			{
				H0180056 = (int?)reader[200];
			}
			if (reader[201] != DBNull.Value)
			{
				H0180057 = (int?)reader[201];
			}
			if (reader[202] != DBNull.Value)
			{
				H0180058 = (int?)reader[202];
			}
			if (reader[203] != DBNull.Value)
			{
				H0180059 = (int?)reader[203];
			}
			if (reader[204] != DBNull.Value)
			{
				H0180060 = (int?)reader[204];
			}
			if (reader[205] != DBNull.Value)
			{
				H0180061 = (int?)reader[205];
			}
			if (reader[206] != DBNull.Value)
			{
				H0180062 = (int?)reader[206];
			}
			if (reader[207] != DBNull.Value)
			{
				H0180063 = (int?)reader[207];
			}
			if (reader[208] != DBNull.Value)
			{
				H0180064 = (int?)reader[208];
			}
			if (reader[209] != DBNull.Value)
			{
				H0180065 = (int?)reader[209];
			}
			if (reader[210] != DBNull.Value)
			{
				H0180066 = (int?)reader[210];
			}
			if (reader[211] != DBNull.Value)
			{
				H0180067 = (int?)reader[211];
			}
			if (reader[212] != DBNull.Value)
			{
				H0180068 = (int?)reader[212];
			}
			if (reader[213] != DBNull.Value)
			{
				H0180069 = (int?)reader[213];
			}
			if (reader[214] != DBNull.Value)
			{
				H0190001 = (int?)reader[214];
			}
			if (reader[215] != DBNull.Value)
			{
				H0190002 = (int?)reader[215];
			}
			if (reader[216] != DBNull.Value)
			{
				H0190003 = (int?)reader[216];
			}
			if (reader[217] != DBNull.Value)
			{
				H0190004 = (int?)reader[217];
			}
			if (reader[218] != DBNull.Value)
			{
				H0190005 = (int?)reader[218];
			}
			if (reader[219] != DBNull.Value)
			{
				H0190006 = (int?)reader[219];
			}
			if (reader[220] != DBNull.Value)
			{
				H0190007 = (int?)reader[220];
			}
			if (reader[221] != DBNull.Value)
			{
				H0200001 = (int?)reader[221];
			}
			if (reader[222] != DBNull.Value)
			{
				H0200002 = (int?)reader[222];
			}
			if (reader[223] != DBNull.Value)
			{
				H0200003 = (int?)reader[223];
			}
			if (reader[224] != DBNull.Value)
			{
				H0210001 = (int?)reader[224];
			}
			if (reader[225] != DBNull.Value)
			{
				H0210002 = (int?)reader[225];
			}
			if (reader[226] != DBNull.Value)
			{
				H0210003 = (int?)reader[226];
			}
			if (reader[227] != DBNull.Value)
			{
				H0220001 = (int?)reader[227];
			}
			if (reader[228] != DBNull.Value)
			{
				H0220002 = (int?)reader[228];
			}
			if (reader[229] != DBNull.Value)
			{
				H0220003 = (int?)reader[229];
			}
			if (reader[230] != DBNull.Value)
			{
				H011A0001 = (int?)reader[230];
			}
			if (reader[231] != DBNull.Value)
			{
				H011A0002 = (int?)reader[231];
			}
			if (reader[232] != DBNull.Value)
			{
				H011A0003 = (int?)reader[232];
			}
			if (reader[233] != DBNull.Value)
			{
				H011A0004 = (int?)reader[233];
			}
			if (reader[234] != DBNull.Value)
			{
				H011B0001 = (int?)reader[234];
			}
			if (reader[235] != DBNull.Value)
			{
				H011B0002 = (int?)reader[235];
			}
			if (reader[236] != DBNull.Value)
			{
				H011B0003 = (int?)reader[236];
			}
			if (reader[237] != DBNull.Value)
			{
				H011B0004 = (int?)reader[237];
			}
			if (reader[238] != DBNull.Value)
			{
				H011C0001 = (int?)reader[238];
			}
			if (reader[239] != DBNull.Value)
			{
				H011C0002 = (int?)reader[239];
			}
			if (reader[240] != DBNull.Value)
			{
				H011C0003 = (int?)reader[240];
			}
			if (reader[241] != DBNull.Value)
			{
				H011C0004 = (int?)reader[241];
			}
			if (reader[242] != DBNull.Value)
			{
				H011D0001 = (int?)reader[242];
			}
			if (reader[243] != DBNull.Value)
			{
				H011D0002 = (int?)reader[243];
			}
			if (reader[244] != DBNull.Value)
			{
				H011D0003 = (int?)reader[244];
			}
			if (reader[245] != DBNull.Value)
			{
				H011D0004 = (int?)reader[245];
			}
			if (reader[246] != DBNull.Value)
			{
				H011E0001 = (int?)reader[246];
			}
			if (reader[247] != DBNull.Value)
			{
				H011E0002 = (int?)reader[247];
			}
			if (reader[248] != DBNull.Value)
			{
				H011E0003 = (int?)reader[248];
			}
			if (reader[249] != DBNull.Value)
			{
				H011E0004 = (int?)reader[249];
			}
			if (reader[250] != DBNull.Value)
			{
				H011F0001 = (int?)reader[250];
			}
			if (reader[251] != DBNull.Value)
			{
				H011F0002 = (int?)reader[251];
			}
			if (reader[252] != DBNull.Value)
			{
				H011F0003 = (int?)reader[252];
			}
			if (reader[253] != DBNull.Value)
			{
				H011F0004 = (int?)reader[253];
			}
		}
		#endregion Constructors
	}
}
