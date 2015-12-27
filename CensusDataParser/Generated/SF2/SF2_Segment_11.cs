#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 5:32 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF2_Segment_11.cs
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

namespace CensusDataParser.Generated.SF2
{
    #region Using Directives
    using System.ComponentModel.DataAnnotations;
    #endregion

    public class SF2_Segment_11
    {
        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
        public string CHARITER { get; set; }

        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
        public string CIFSN { get; set; }

        [Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
        public string FILEID { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public int? HCT0020001 { get; set; }

        [Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 6)]
        public int? HCT0020002 { get; set; }

        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 7)]
        public int? HCT0020003 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 8)]
        public int? HCT0020004 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 9)]
        public int? HCT0030001 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 10)]
        public int? HCT0040001 { get; set; }

        [Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 11)]
        public int? HCT0040002 { get; set; }

        [Display(Name = "With children under 18 years:", ShortName = "With children under 18 years:", Order = 12)]
        public int? HCT0040003 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 13)]
        public int? HCT0040004 { get; set; }

        [Display(Name = "Total", ShortName = "Total", Order = 14)]
        public double? HCT0050001 { get; set; }

        [Display(Name = "Owner occupied", ShortName = "Owner occupied", Order = 15)]
        public double? HCT0050002 { get; set; }

        [Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 16)]
        public double? HCT0050003 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 17)]
        public int? HCT0060001 { get; set; }

        [Display(Name = "1-person household", ShortName = "1-person household", Order = 18)]
        public int? HCT0060002 { get; set; }

        [Display(Name = "2-person household", ShortName = "2-person household", Order = 19)]
        public int? HCT0060003 { get; set; }

        [Display(Name = "3-person household", ShortName = "3-person household", Order = 20)]
        public int? HCT0060004 { get; set; }

        [Display(Name = "4-person household", ShortName = "4-person household", Order = 21)]
        public int? HCT0060005 { get; set; }

        [Display(Name = "5-person household", ShortName = "5-person household", Order = 22)]
        public int? HCT0060006 { get; set; }

        [Display(Name = "6-person household", ShortName = "6-person household", Order = 23)]
        public int? HCT0060007 { get; set; }

        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 24)]
        public int? HCT0060008 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 25)]
        public int? HCT0070001 { get; set; }

        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 26)]
        public int? HCT0070002 { get; set; }

        [Display(Name = "1-person household", ShortName = "1-person household", Order = 27)]
        public int? HCT0070003 { get; set; }

        [Display(Name = "2-person household", ShortName = "2-person household", Order = 28)]
        public int? HCT0070004 { get; set; }

        [Display(Name = "3-person household", ShortName = "3-person household", Order = 29)]
        public int? HCT0070005 { get; set; }

        [Display(Name = "4-person household", ShortName = "4-person household", Order = 30)]
        public int? HCT0070006 { get; set; }

        [Display(Name = "5-person household", ShortName = "5-person household", Order = 31)]
        public int? HCT0070007 { get; set; }

        [Display(Name = "6-person household", ShortName = "6-person household", Order = 32)]
        public int? HCT0070008 { get; set; }

        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 33)]
        public int? HCT0070009 { get; set; }

        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 34)]
        public int? HCT0070010 { get; set; }

        [Display(Name = "1-person household", ShortName = "1-person household", Order = 35)]
        public int? HCT0070011 { get; set; }

        [Display(Name = "2-person household", ShortName = "2-person household", Order = 36)]
        public int? HCT0070012 { get; set; }

        [Display(Name = "3-person household", ShortName = "3-person household", Order = 37)]
        public int? HCT0070013 { get; set; }

        [Display(Name = "4-person household", ShortName = "4-person household", Order = 38)]
        public int? HCT0070014 { get; set; }

        [Display(Name = "5-person household", ShortName = "5-person household", Order = 39)]
        public int? HCT0070015 { get; set; }

        [Display(Name = "6-person household", ShortName = "6-person household", Order = 40)]
        public int? HCT0070016 { get; set; }

        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 41)]
        public int? HCT0070017 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 42)]
        public int? HCT0080001 { get; set; }

        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 43)]
        public int? HCT0080002 { get; set; }

        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 44)]
        public int? HCT0080003 { get; set; }

        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 45)]
        public int? HCT0080004 { get; set; }

        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 46)]
        public int? HCT0080005 { get; set; }

        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 47)]
        public int? HCT0080006 { get; set; }

        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 48)]
        public int? HCT0080007 { get; set; }

        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 49)]
        public int? HCT0080008 { get; set; }

        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 50)]
        public int? HCT0080009 { get; set; }

        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 51)]
        public int? HCT0080010 { get; set; }

        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 52)]
        public int? HCT0080011 { get; set; }

        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 53)]
        public int? HCT0080012 { get; set; }

        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 54)]
        public int? HCT0080013 { get; set; }

        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 55)]
        public int? HCT0080014 { get; set; }

        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 56)]
        public int? HCT0080015 { get; set; }

        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 57)]
        public int? HCT0080016 { get; set; }

        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 58)]
        public int? HCT0080017 { get; set; }

        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 59)]
        public int? HCT0080018 { get; set; }

        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 60)]
        public int? HCT0080019 { get; set; }

        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 61)]
        public int? HCT0080020 { get; set; }

        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 62)]
        public int? HCT0080021 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 63)]
        public int? HCT0090001 { get; set; }

        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 64)]
        public int? HCT0090002 { get; set; }

        [Display(Name = "Family households:", ShortName = "Family households:", Order = 65)]
        public int? HCT0090003 { get; set; }

        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 66)]
        public int? HCT0090004 { get; set; }

        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 67)]
        public int? HCT0090005 { get; set; }

        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 68)]
        public int? HCT0090006 { get; set; }

        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 69)]
        public int? HCT0090007 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 70)]
        public int? HCT0090008 { get; set; }

        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 71)]
        public int? HCT0090009 { get; set; }

        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 72)]
        public int? HCT0090010 { get; set; }

        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 73)]
        public int? HCT0090011 { get; set; }

        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 74)]
        public int? HCT0090012 { get; set; }

        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 75)]
        public int? HCT0090013 { get; set; }

        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 76)]
        public int? HCT0090014 { get; set; }

        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 77)]
        public int? HCT0090015 { get; set; }

        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 78)]
        public int? HCT0090016 { get; set; }

        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 79)]
        public int? HCT0090017 { get; set; }

        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 80)]
        public int? HCT0090018 { get; set; }

        [Display(Name = "Living alone:", ShortName = "Living alone:", Order = 81)]
        public int? HCT0090019 { get; set; }

        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 82)]
        public int? HCT0090020 { get; set; }

        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 83)]
        public int? HCT0090021 { get; set; }

        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 84)]
        public int? HCT0090022 { get; set; }

        [Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 85)]
        public int? HCT0090023 { get; set; }

        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 86)]
        public int? HCT0090024 { get; set; }

        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 87)]
        public int? HCT0090025 { get; set; }

        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 88)]
        public int? HCT0090026 { get; set; }

        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 89)]
        public int? HCT0090027 { get; set; }

        [Display(Name = "Living alone:", ShortName = "Living alone:", Order = 90)]
        public int? HCT0090028 { get; set; }

        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 91)]
        public int? HCT0090029 { get; set; }

        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 92)]
        public int? HCT0090030 { get; set; }

        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 93)]
        public int? HCT0090031 { get; set; }

        [Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 94)]
        public int? HCT0090032 { get; set; }

        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 95)]
        public int? HCT0090033 { get; set; }

        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 96)]
        public int? HCT0090034 { get; set; }

        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 97)]
        public int? HCT0090035 { get; set; }

        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 98)]
        public int? HCT0090036 { get; set; }

        [Display(Name = "Family households:", ShortName = "Family households:", Order = 99)]
        public int? HCT0090037 { get; set; }

        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 100)]
        public int? HCT0090038 { get; set; }

        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 101)]
        public int? HCT0090039 { get; set; }

        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 102)]
        public int? HCT0090040 { get; set; }

        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 103)]
        public int? HCT0090041 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 104)]
        public int? HCT0090042 { get; set; }

        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 105)]
        public int? HCT0090043 { get; set; }

        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 106)]
        public int? HCT0090044 { get; set; }

        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 107)]
        public int? HCT0090045 { get; set; }

        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 108)]
        public int? HCT0090046 { get; set; }

        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 109)]
        public int? HCT0090047 { get; set; }

        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 110)]
        public int? HCT0090048 { get; set; }

        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 111)]
        public int? HCT0090049 { get; set; }

        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 112)]
        public int? HCT0090050 { get; set; }

        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 113)]
        public int? HCT0090051 { get; set; }

        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 114)]
        public int? HCT0090052 { get; set; }

        [Display(Name = "Living alone:", ShortName = "Living alone:", Order = 115)]
        public int? HCT0090053 { get; set; }

        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 116)]
        public int? HCT0090054 { get; set; }

        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 117)]
        public int? HCT0090055 { get; set; }

        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 118)]
        public int? HCT0090056 { get; set; }

        [Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 119)]
        public int? HCT0090057 { get; set; }

        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 120)]
        public int? HCT0090058 { get; set; }

        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 121)]
        public int? HCT0090059 { get; set; }

        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 122)]
        public int? HCT0090060 { get; set; }

        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 123)]
        public int? HCT0090061 { get; set; }

        [Display(Name = "Living alone:", ShortName = "Living alone:", Order = 124)]
        public int? HCT0090062 { get; set; }

        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 125)]
        public int? HCT0090063 { get; set; }

        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 126)]
        public int? HCT0090064 { get; set; }

        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 127)]
        public int? HCT0090065 { get; set; }

        [Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 128)]
        public int? HCT0090066 { get; set; }

        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 129)]
        public int? HCT0090067 { get; set; }

        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 130)]
        public int? HCT0090068 { get; set; }

        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 131)]
        public int? HCT0090069 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 132)]
        public int? HCT0100001 { get; set; }

        [Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 133)]
        public int? HCT0100002 { get; set; }

        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 134)]
        public int? HCT0100003 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 135)]
        public int? HCT0100004 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 136)]
        public int? HCT0100005 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 137)]
        public int? HCT0100006 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 138)]
        public int? HCT0100007 { get; set; }

        [Display(Name = "Renter-occupied:", ShortName = "Renter-occupied:", Order = 139)]
        public int? HCT0100008 { get; set; }

        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 140)]
        public int? HCT0100009 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 141)]
        public int? HCT0100010 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 142)]
        public int? HCT0100011 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 143)]
        public int? HCT0100012 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 144)]
        public int? HCT0100013 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 145)]
        public int? HCT0110001 { get; set; }

        [Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 146)]
        public int? HCT0110002 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 147)]
        public int? HCT0110003 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 148)]
        public int? HCT0110004 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 149)]
        public int? HCT0110005 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 150)]
        public int? HCT0110006 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 151)]
        public int? HCT0110007 { get; set; }

        [Display(Name = "Renter-occupied:", ShortName = "Renter-occupied:", Order = 152)]
        public int? HCT0110008 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 153)]
        public int? HCT0110009 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 154)]
        public int? HCT0110010 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 155)]
        public int? HCT0110011 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 156)]
        public int? HCT0110012 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 157)]
        public int? HCT0110013 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 158)]
        public int? HCT0120001 { get; set; }

        [Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 159)]
        public int? HCT0120002 { get; set; }

        [Display(Name = "With children under 18 years:", ShortName = "With children under 18 years:", Order = 160)]
        public int? HCT0120003 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 161)]
        public int? HCT0120004 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 162)]
        public int? HCT0120005 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 163)]
        public int? HCT0120006 { get; set; }

        [Display(Name = "No children under 18 years", ShortName = "No children under 18 years", Order = 164)]
        public int? HCT0120007 { get; set; }

        [Display(Name = "Renter-occupied:", ShortName = "Renter-occupied:", Order = 165)]
        public int? HCT0120008 { get; set; }

        [Display(Name = "With children under 18 years:", ShortName = "With children under 18 years:", Order = 166)]
        public int? HCT0120009 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 167)]
        public int? HCT0120010 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 168)]
        public int? HCT0120011 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 169)]
        public int? HCT0120012 { get; set; }

        [Display(Name = "No children under 18 years", ShortName = "No children under 18 years", Order = 170)]
        public int? HCT0120013 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 171)]
        public int? HCT0130001 { get; set; }

        [Display(Name = "Substituted", ShortName = "Substituted", Order = 172)]
        public int? HCT0130002 { get; set; }

        [Display(Name = "Not substituted", ShortName = "Not substituted", Order = 173)]
        public int? HCT0130003 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 174)]
        public int? HCT0140001 { get; set; }

        [Display(Name = "Allocated", ShortName = "Allocated", Order = 175)]
        public int? HCT0140002 { get; set; }

        [Display(Name = "Not allocated", ShortName = "Not allocated", Order = 176)]
        public int? HCT0140003 { get; set; }

        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
        public int? LOGRECNO { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}
