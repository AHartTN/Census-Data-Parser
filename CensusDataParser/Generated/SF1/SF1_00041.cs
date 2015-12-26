#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 4:09 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1_00041.cs
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

    public class SF1_00041
    {
        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
        public string CHARITER { get; set; }

        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
        public string CIFSN { get; set; }

        [Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
        public string FILEID { get; set; }

        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
        public int? LOGRECNO { get; set; }

        [Display(Name = "Total (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Total (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 5)]
        public int? PCO0070001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 6)]
        public int? PCO0070002 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 7)]
        public int? PCO0070003 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 8)]
        public int? PCO0070004 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 9)]
        public int? PCO0070005 { get; set; }

        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 10)]
        public int? PCO0070006 { get; set; }

        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 11)]
        public int? PCO0070007 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 12)]
        public int? PCO0070008 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 13)]
        public int? PCO0070009 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 14)]
        public int? PCO0070010 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 15)]
        public int? PCO0070011 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 16)]
        public int? PCO0070012 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 17)]
        public int? PCO0070013 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 18)]
        public int? PCO0070014 { get; set; }

        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 19)]
        public int? PCO0070015 { get; set; }

        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 20)]
        public int? PCO0070016 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 21)]
        public int? PCO0070017 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 22)]
        public int? PCO0070018 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 23)]
        public int? PCO0070019 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 24)]
        public int? PCO0070020 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 25)]
        public int? PCO0070021 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 26)]
        public int? PCO0070022 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 27)]
        public int? PCO0070023 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 28)]
        public int? PCO0070024 { get; set; }

        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 29)]
        public int? PCO0070025 { get; set; }

        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 30)]
        public int? PCO0070026 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 31)]
        public int? PCO0070027 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 32)]
        public int? PCO0070028 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 33)]
        public int? PCO0070029 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 34)]
        public int? PCO0070030 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 35)]
        public int? PCO0070031 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 36)]
        public int? PCO0070032 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 37)]
        public int? PCO0070033 { get; set; }

        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 38)]
        public int? PCO0070034 { get; set; }

        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 39)]
        public int? PCO0070035 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 40)]
        public int? PCO0070036 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 41)]
        public int? PCO0070037 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 42)]
        public int? PCO0070038 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 43)]
        public int? PCO0070039 { get; set; }

        [Display(Name = "Total (501):", ShortName = "Total (501):", Order = 44)]
        public int? PCO0080001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 45)]
        public int? PCO0080002 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 46)]
        public int? PCO0080003 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 47)]
        public int? PCO0080004 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 48)]
        public int? PCO0080005 { get; set; }

        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 49)]
        public int? PCO0080006 { get; set; }

        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 50)]
        public int? PCO0080007 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 51)]
        public int? PCO0080008 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 52)]
        public int? PCO0080009 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 53)]
        public int? PCO0080010 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 54)]
        public int? PCO0080011 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 55)]
        public int? PCO0080012 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 56)]
        public int? PCO0080013 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 57)]
        public int? PCO0080014 { get; set; }

        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 58)]
        public int? PCO0080015 { get; set; }

        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 59)]
        public int? PCO0080016 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 60)]
        public int? PCO0080017 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 61)]
        public int? PCO0080018 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 62)]
        public int? PCO0080019 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 63)]
        public int? PCO0080020 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 64)]
        public int? PCO0080021 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 65)]
        public int? PCO0080022 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 66)]
        public int? PCO0080023 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 67)]
        public int? PCO0080024 { get; set; }

        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 68)]
        public int? PCO0080025 { get; set; }

        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 69)]
        public int? PCO0080026 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 70)]
        public int? PCO0080027 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 71)]
        public int? PCO0080028 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 72)]
        public int? PCO0080029 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 73)]
        public int? PCO0080030 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 74)]
        public int? PCO0080031 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 75)]
        public int? PCO0080032 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 76)]
        public int? PCO0080033 { get; set; }

        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 77)]
        public int? PCO0080034 { get; set; }

        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 78)]
        public int? PCO0080035 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 79)]
        public int? PCO0080036 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 80)]
        public int? PCO0080037 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 81)]
        public int? PCO0080038 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 82)]
        public int? PCO0080039 { get; set; }

        [Display(Name = "Total (601-602):", ShortName = "Total (601-602):", Order = 83)]
        public int? PCO0090001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 84)]
        public int? PCO0090002 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 85)]
        public int? PCO0090003 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 86)]
        public int? PCO0090004 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 87)]
        public int? PCO0090005 { get; set; }

        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 88)]
        public int? PCO0090006 { get; set; }

        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 89)]
        public int? PCO0090007 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 90)]
        public int? PCO0090008 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 91)]
        public int? PCO0090009 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 92)]
        public int? PCO0090010 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 93)]
        public int? PCO0090011 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 94)]
        public int? PCO0090012 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 95)]
        public int? PCO0090013 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 96)]
        public int? PCO0090014 { get; set; }

        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 97)]
        public int? PCO0090015 { get; set; }

        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 98)]
        public int? PCO0090016 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 99)]
        public int? PCO0090017 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 100)]
        public int? PCO0090018 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 101)]
        public int? PCO0090019 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 102)]
        public int? PCO0090020 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 103)]
        public int? PCO0090021 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 104)]
        public int? PCO0090022 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 105)]
        public int? PCO0090023 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 106)]
        public int? PCO0090024 { get; set; }

        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 107)]
        public int? PCO0090025 { get; set; }

        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 108)]
        public int? PCO0090026 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 109)]
        public int? PCO0090027 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 110)]
        public int? PCO0090028 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 111)]
        public int? PCO0090029 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 112)]
        public int? PCO0090030 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 113)]
        public int? PCO0090031 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 114)]
        public int? PCO0090032 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 115)]
        public int? PCO0090033 { get; set; }

        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 116)]
        public int? PCO0090034 { get; set; }

        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 117)]
        public int? PCO0090035 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 118)]
        public int? PCO0090036 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 119)]
        public int? PCO0090037 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 120)]
        public int? PCO0090038 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 121)]
        public int? PCO0090039 { get; set; }

        [Display(Name = "Total (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Total (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 122)]
        public int? PCO0100001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 123)]
        public int? PCO0100002 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 124)]
        public int? PCO0100003 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 125)]
        public int? PCO0100004 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 126)]
        public int? PCO0100005 { get; set; }

        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 127)]
        public int? PCO0100006 { get; set; }

        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 128)]
        public int? PCO0100007 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 129)]
        public int? PCO0100008 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 130)]
        public int? PCO0100009 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 131)]
        public int? PCO0100010 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 132)]
        public int? PCO0100011 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 133)]
        public int? PCO0100012 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 134)]
        public int? PCO0100013 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 135)]
        public int? PCO0100014 { get; set; }

        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 136)]
        public int? PCO0100015 { get; set; }

        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 137)]
        public int? PCO0100016 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 138)]
        public int? PCO0100017 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 139)]
        public int? PCO0100018 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 140)]
        public int? PCO0100019 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 141)]
        public int? PCO0100020 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 142)]
        public int? PCO0100021 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 143)]
        public int? PCO0100022 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 144)]
        public int? PCO0100023 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 145)]
        public int? PCO0100024 { get; set; }

        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 146)]
        public int? PCO0100025 { get; set; }

        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 147)]
        public int? PCO0100026 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 148)]
        public int? PCO0100027 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 149)]
        public int? PCO0100028 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 150)]
        public int? PCO0100029 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 151)]
        public int? PCO0100030 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 152)]
        public int? PCO0100031 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 153)]
        public int? PCO0100032 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 154)]
        public int? PCO0100033 { get; set; }

        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 155)]
        public int? PCO0100034 { get; set; }

        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 156)]
        public int? PCO0100035 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 157)]
        public int? PCO0100036 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 158)]
        public int? PCO0100037 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 159)]
        public int? PCO0100038 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 160)]
        public int? PCO0100039 { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}
