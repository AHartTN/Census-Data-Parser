#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 5:31 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1_00047.cs
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

    public class SF1_00047
    {
        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
        public string CHARITER { get; set; }

        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
        public string CIFSN { get; set; }

        [Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
        public string FILEID { get; set; }

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

        [Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 11)]
        public int? HCT0010007 { get; set; }

        [Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 12)]
        public int? HCT0010008 { get; set; }

        [Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 13)]
        public int? HCT0010009 { get; set; }

        [Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 14)]
        public int? HCT0010010 { get; set; }

        [Display(Name = "Hispanic or Latino householder:", ShortName = "Hispanic or Latino householder:", Order = 15)]
        public int? HCT0010011 { get; set; }

        [Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 16)]
        public int? HCT0010012 { get; set; }

        [Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 17)]
        public int? HCT0010013 { get; set; }

        [Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 18)]
        public int? HCT0010014 { get; set; }

        [Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 19)]
        public int? HCT0010015 { get; set; }

        [Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 20)]
        public int? HCT0010016 { get; set; }

        [Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 21)]
        public int? HCT0010017 { get; set; }

        [Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 22)]
        public int? HCT0010018 { get; set; }

        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 23)]
        public int? HCT0010019 { get; set; }

        [Display(Name = "Not Hispanic or Latino householder:", ShortName = "Not Hispanic or Latino householder:", Order = 24)]
        public int? HCT0010020 { get; set; }

        [Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 25)]
        public int? HCT0010021 { get; set; }

        [Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 26)]
        public int? HCT0010022 { get; set; }

        [Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 27)]
        public int? HCT0010023 { get; set; }

        [Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 28)]
        public int? HCT0010024 { get; set; }

        [Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 29)]
        public int? HCT0010025 { get; set; }

        [Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 30)]
        public int? HCT0010026 { get; set; }

        [Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 31)]
        public int? HCT0010027 { get; set; }

        [Display(Name = "Hispanic or Latino householder:", ShortName = "Hispanic or Latino householder:", Order = 32)]
        public int? HCT0010028 { get; set; }

        [Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 33)]
        public int? HCT0010029 { get; set; }

        [Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 34)]
        public int? HCT0010030 { get; set; }

        [Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 35)]
        public int? HCT0010031 { get; set; }

        [Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 36)]
        public int? HCT0010032 { get; set; }

        [Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 37)]
        public int? HCT0010033 { get; set; }

        [Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 38)]
        public int? HCT0010034 { get; set; }

        [Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 39)]
        public int? HCT0010035 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 40)]
        public int? HCT0020001 { get; set; }

        [Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 41)]
        public int? HCT0020002 { get; set; }

        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 42)]
        public int? HCT0020003 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 43)]
        public int? HCT0020004 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 44)]
        public int? HCT0020005 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 45)]
        public int? HCT0020006 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 46)]
        public int? HCT0020007 { get; set; }

        [Display(Name = "Renter-occupied:", ShortName = "Renter-occupied:", Order = 47)]
        public int? HCT0020008 { get; set; }

        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 48)]
        public int? HCT0020009 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 49)]
        public int? HCT0020010 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 50)]
        public int? HCT0020011 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 51)]
        public int? HCT0020012 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 52)]
        public int? HCT0020013 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 53)]
        public int? HCT0030001 { get; set; }

        [Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 54)]
        public int? HCT0030002 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 55)]
        public int? HCT0030003 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 56)]
        public int? HCT0030004 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 57)]
        public int? HCT0030005 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 58)]
        public int? HCT0030006 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 59)]
        public int? HCT0030007 { get; set; }

        [Display(Name = "Renter-occupied:", ShortName = "Renter-occupied:", Order = 60)]
        public int? HCT0030008 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 61)]
        public int? HCT0030009 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 62)]
        public int? HCT0030010 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 63)]
        public int? HCT0030011 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 64)]
        public int? HCT0030012 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 65)]
        public int? HCT0030013 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 66)]
        public int? HCT0040001 { get; set; }

        [Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 67)]
        public int? HCT0040002 { get; set; }

        [Display(Name = "With children under 18 years:", ShortName = "With children under 18 years:", Order = 68)]
        public int? HCT0040003 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 69)]
        public int? HCT0040004 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 70)]
        public int? HCT0040005 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 71)]
        public int? HCT0040006 { get; set; }

        [Display(Name = "No children under 18 years", ShortName = "No children under 18 years", Order = 72)]
        public int? HCT0040007 { get; set; }

        [Display(Name = "Renter-occupied:", ShortName = "Renter-occupied:", Order = 73)]
        public int? HCT0040008 { get; set; }

        [Display(Name = "With children under 18 years:", ShortName = "With children under 18 years:", Order = 74)]
        public int? HCT0040009 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 75)]
        public int? HCT0040010 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 76)]
        public int? HCT0040011 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 77)]
        public int? HCT0040012 { get; set; }

        [Display(Name = "No children under 18 years", ShortName = "No children under 18 years", Order = 78)]
        public int? HCT0040013 { get; set; }

        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
        public int? LOGRECNO { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}
