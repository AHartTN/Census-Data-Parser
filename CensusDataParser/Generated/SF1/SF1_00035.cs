#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 5:31 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1_00035.cs
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

    public class SF1_00035
    {
        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
        public string CHARITER { get; set; }

        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
        public string CIFSN { get; set; }

        [Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
        public string FILEID { get; set; }

        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
        public int? LOGRECNO { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public int? PCT013A001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 6)]
        public int? PCT013A002 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 7)]
        public int? PCT013A003 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 8)]
        public int? PCT013A004 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 9)]
        public int? PCT013A005 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 10)]
        public int? PCT013A006 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 11)]
        public int? PCT013A007 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 12)]
        public int? PCT013A008 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 13)]
        public int? PCT013A009 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 14)]
        public int? PCT013A010 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 15)]
        public int? PCT013A011 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 16)]
        public int? PCT013A012 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 17)]
        public int? PCT013A013 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 18)]
        public int? PCT013A014 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 19)]
        public int? PCT013A015 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 20)]
        public int? PCT013A016 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 21)]
        public int? PCT013A017 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 22)]
        public int? PCT013A018 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 23)]
        public int? PCT013A019 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 24)]
        public int? PCT013A020 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 25)]
        public int? PCT013A021 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 26)]
        public int? PCT013A022 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 27)]
        public int? PCT013A023 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 28)]
        public int? PCT013A024 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 29)]
        public int? PCT013A025 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 30)]
        public int? PCT013A026 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 31)]
        public int? PCT013A027 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 32)]
        public int? PCT013A028 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 33)]
        public int? PCT013A029 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 34)]
        public int? PCT013A030 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 35)]
        public int? PCT013A031 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 36)]
        public int? PCT013A032 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 37)]
        public int? PCT013A033 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 38)]
        public int? PCT013A034 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 39)]
        public int? PCT013A035 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 40)]
        public int? PCT013A036 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 41)]
        public int? PCT013A037 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 42)]
        public int? PCT013A038 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 43)]
        public int? PCT013A039 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 44)]
        public int? PCT013A040 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 45)]
        public int? PCT013A041 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 46)]
        public int? PCT013A042 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 47)]
        public int? PCT013A043 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 48)]
        public int? PCT013A044 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 49)]
        public int? PCT013A045 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 50)]
        public int? PCT013A046 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 51)]
        public int? PCT013A047 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 52)]
        public int? PCT013A048 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 53)]
        public int? PCT013A049 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 54)]
        public int? PCT013B001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 55)]
        public int? PCT013B002 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 56)]
        public int? PCT013B003 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 57)]
        public int? PCT013B004 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 58)]
        public int? PCT013B005 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 59)]
        public int? PCT013B006 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 60)]
        public int? PCT013B007 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 61)]
        public int? PCT013B008 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 62)]
        public int? PCT013B009 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 63)]
        public int? PCT013B010 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 64)]
        public int? PCT013B011 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 65)]
        public int? PCT013B012 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 66)]
        public int? PCT013B013 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 67)]
        public int? PCT013B014 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 68)]
        public int? PCT013B015 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 69)]
        public int? PCT013B016 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 70)]
        public int? PCT013B017 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 71)]
        public int? PCT013B018 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 72)]
        public int? PCT013B019 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 73)]
        public int? PCT013B020 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 74)]
        public int? PCT013B021 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 75)]
        public int? PCT013B022 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 76)]
        public int? PCT013B023 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 77)]
        public int? PCT013B024 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 78)]
        public int? PCT013B025 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 79)]
        public int? PCT013B026 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 80)]
        public int? PCT013B027 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 81)]
        public int? PCT013B028 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 82)]
        public int? PCT013B029 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 83)]
        public int? PCT013B030 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 84)]
        public int? PCT013B031 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 85)]
        public int? PCT013B032 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 86)]
        public int? PCT013B033 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 87)]
        public int? PCT013B034 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 88)]
        public int? PCT013B035 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 89)]
        public int? PCT013B036 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 90)]
        public int? PCT013B037 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 91)]
        public int? PCT013B038 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 92)]
        public int? PCT013B039 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 93)]
        public int? PCT013B040 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 94)]
        public int? PCT013B041 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 95)]
        public int? PCT013B042 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 96)]
        public int? PCT013B043 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 97)]
        public int? PCT013B044 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 98)]
        public int? PCT013B045 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 99)]
        public int? PCT013B046 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 100)]
        public int? PCT013B047 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 101)]
        public int? PCT013B048 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 102)]
        public int? PCT013B049 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 103)]
        public int? PCT013C001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 104)]
        public int? PCT013C002 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 105)]
        public int? PCT013C003 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 106)]
        public int? PCT013C004 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 107)]
        public int? PCT013C005 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 108)]
        public int? PCT013C006 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 109)]
        public int? PCT013C007 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 110)]
        public int? PCT013C008 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 111)]
        public int? PCT013C009 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 112)]
        public int? PCT013C010 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 113)]
        public int? PCT013C011 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 114)]
        public int? PCT013C012 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 115)]
        public int? PCT013C013 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 116)]
        public int? PCT013C014 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 117)]
        public int? PCT013C015 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 118)]
        public int? PCT013C016 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 119)]
        public int? PCT013C017 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 120)]
        public int? PCT013C018 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 121)]
        public int? PCT013C019 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 122)]
        public int? PCT013C020 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 123)]
        public int? PCT013C021 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 124)]
        public int? PCT013C022 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 125)]
        public int? PCT013C023 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 126)]
        public int? PCT013C024 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 127)]
        public int? PCT013C025 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 128)]
        public int? PCT013C026 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 129)]
        public int? PCT013C027 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 130)]
        public int? PCT013C028 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 131)]
        public int? PCT013C029 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 132)]
        public int? PCT013C030 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 133)]
        public int? PCT013C031 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 134)]
        public int? PCT013C032 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 135)]
        public int? PCT013C033 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 136)]
        public int? PCT013C034 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 137)]
        public int? PCT013C035 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 138)]
        public int? PCT013C036 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 139)]
        public int? PCT013C037 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 140)]
        public int? PCT013C038 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 141)]
        public int? PCT013C039 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 142)]
        public int? PCT013C040 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 143)]
        public int? PCT013C041 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 144)]
        public int? PCT013C042 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 145)]
        public int? PCT013C043 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 146)]
        public int? PCT013C044 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 147)]
        public int? PCT013C045 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 148)]
        public int? PCT013C046 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 149)]
        public int? PCT013C047 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 150)]
        public int? PCT013C048 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 151)]
        public int? PCT013C049 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 152)]
        public int? PCT013D001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 153)]
        public int? PCT013D002 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 154)]
        public int? PCT013D003 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 155)]
        public int? PCT013D004 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 156)]
        public int? PCT013D005 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 157)]
        public int? PCT013D006 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 158)]
        public int? PCT013D007 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 159)]
        public int? PCT013D008 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 160)]
        public int? PCT013D009 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 161)]
        public int? PCT013D010 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 162)]
        public int? PCT013D011 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 163)]
        public int? PCT013D012 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 164)]
        public int? PCT013D013 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 165)]
        public int? PCT013D014 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 166)]
        public int? PCT013D015 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 167)]
        public int? PCT013D016 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 168)]
        public int? PCT013D017 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 169)]
        public int? PCT013D018 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 170)]
        public int? PCT013D019 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 171)]
        public int? PCT013D020 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 172)]
        public int? PCT013D021 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 173)]
        public int? PCT013D022 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 174)]
        public int? PCT013D023 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 175)]
        public int? PCT013D024 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 176)]
        public int? PCT013D025 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 177)]
        public int? PCT013D026 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 178)]
        public int? PCT013D027 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 179)]
        public int? PCT013D028 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 180)]
        public int? PCT013D029 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 181)]
        public int? PCT013D030 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 182)]
        public int? PCT013D031 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 183)]
        public int? PCT013D032 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 184)]
        public int? PCT013D033 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 185)]
        public int? PCT013D034 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 186)]
        public int? PCT013D035 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 187)]
        public int? PCT013D036 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 188)]
        public int? PCT013D037 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 189)]
        public int? PCT013D038 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 190)]
        public int? PCT013D039 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 191)]
        public int? PCT013D040 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 192)]
        public int? PCT013D041 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 193)]
        public int? PCT013D042 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 194)]
        public int? PCT013D043 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 195)]
        public int? PCT013D044 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 196)]
        public int? PCT013D045 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 197)]
        public int? PCT013D046 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 198)]
        public int? PCT013D047 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 199)]
        public int? PCT013D048 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 200)]
        public int? PCT013D049 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 201)]
        public int? PCT013E001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 202)]
        public int? PCT013E002 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 203)]
        public int? PCT013E003 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 204)]
        public int? PCT013E004 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 205)]
        public int? PCT013E005 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 206)]
        public int? PCT013E006 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 207)]
        public int? PCT013E007 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 208)]
        public int? PCT013E008 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 209)]
        public int? PCT013E009 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 210)]
        public int? PCT013E010 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 211)]
        public int? PCT013E011 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 212)]
        public int? PCT013E012 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 213)]
        public int? PCT013E013 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 214)]
        public int? PCT013E014 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 215)]
        public int? PCT013E015 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 216)]
        public int? PCT013E016 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 217)]
        public int? PCT013E017 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 218)]
        public int? PCT013E018 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 219)]
        public int? PCT013E019 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 220)]
        public int? PCT013E020 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 221)]
        public int? PCT013E021 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 222)]
        public int? PCT013E022 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 223)]
        public int? PCT013E023 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 224)]
        public int? PCT013E024 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 225)]
        public int? PCT013E025 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 226)]
        public int? PCT013E026 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 227)]
        public int? PCT013E027 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 228)]
        public int? PCT013E028 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 229)]
        public int? PCT013E029 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 230)]
        public int? PCT013E030 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 231)]
        public int? PCT013E031 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 232)]
        public int? PCT013E032 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 233)]
        public int? PCT013E033 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 234)]
        public int? PCT013E034 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 235)]
        public int? PCT013E035 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 236)]
        public int? PCT013E036 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 237)]
        public int? PCT013E037 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 238)]
        public int? PCT013E038 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 239)]
        public int? PCT013E039 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 240)]
        public int? PCT013E040 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 241)]
        public int? PCT013E041 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 242)]
        public int? PCT013E042 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 243)]
        public int? PCT013E043 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 244)]
        public int? PCT013E044 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 245)]
        public int? PCT013E045 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 246)]
        public int? PCT013E046 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 247)]
        public int? PCT013E047 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 248)]
        public int? PCT013E048 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 249)]
        public int? PCT013E049 { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}
