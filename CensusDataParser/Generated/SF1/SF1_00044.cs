#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 5:31 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1_00044.cs
// 
// Anthony Hart ("ANTHONY") CONFIDENTIAL
// 
// Unpublished Copyright (c) 1985-2015 Anthony Hart, All Rights Reserved.
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

namespace CensusDataParser.Generated.SF1
{
    #region Using Directives
    using System.ComponentModel.DataAnnotations;
    #endregion

    public class SF1_00044
    {
        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
        public string CHARITER { get; set; }

        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
        public string CIFSN { get; set; }

        [Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
        public string FILEID { get; set; }

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

        [Display(Name = "Total", ShortName = "Total", Order = 72)]
        public double? H0120001 { get; set; }

        [Display(Name = "Owner occupied", ShortName = "Owner occupied", Order = 73)]
        public double? H0120002 { get; set; }

        [Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 74)]
        public double? H0120003 { get; set; }

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

        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
        public int? LOGRECNO { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}
