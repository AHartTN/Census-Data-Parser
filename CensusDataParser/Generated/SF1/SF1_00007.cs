#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 5:32 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1_00007.cs
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

    public class SF1_00007
    {
        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
        public string CHARITER { get; set; }

        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
        public string CIFSN { get; set; }

        [Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
        public string FILEID { get; set; }

        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
        public int? LOGRECNO { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 11)]
        public int? P012A001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 12)]
        public int? P012A002 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 13)]
        public int? P012A003 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 14)]
        public int? P012A004 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 15)]
        public int? P012A005 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 16)]
        public int? P012A006 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 17)]
        public int? P012A007 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 18)]
        public int? P012A008 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 19)]
        public int? P012A009 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 20)]
        public int? P012A010 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 21)]
        public int? P012A011 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 22)]
        public int? P012A012 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 23)]
        public int? P012A013 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 24)]
        public int? P012A014 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 25)]
        public int? P012A015 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 26)]
        public int? P012A016 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 27)]
        public int? P012A017 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 28)]
        public int? P012A018 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 29)]
        public int? P012A019 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 30)]
        public int? P012A020 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 31)]
        public int? P012A021 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 32)]
        public int? P012A022 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 33)]
        public int? P012A023 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 34)]
        public int? P012A024 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 35)]
        public int? P012A025 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 36)]
        public int? P012A026 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 37)]
        public int? P012A027 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 38)]
        public int? P012A028 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 39)]
        public int? P012A029 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 40)]
        public int? P012A030 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 41)]
        public int? P012A031 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 42)]
        public int? P012A032 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 43)]
        public int? P012A033 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 44)]
        public int? P012A034 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 45)]
        public int? P012A035 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 46)]
        public int? P012A036 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 47)]
        public int? P012A037 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 48)]
        public int? P012A038 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 49)]
        public int? P012A039 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 50)]
        public int? P012A040 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 51)]
        public int? P012A041 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 52)]
        public int? P012A042 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 53)]
        public int? P012A043 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 54)]
        public int? P012A044 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 55)]
        public int? P012A045 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 56)]
        public int? P012A046 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 57)]
        public int? P012A047 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 58)]
        public int? P012A048 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 59)]
        public int? P012A049 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 60)]
        public int? P012B001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 61)]
        public int? P012B002 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 62)]
        public int? P012B003 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 63)]
        public int? P012B004 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 64)]
        public int? P012B005 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 65)]
        public int? P012B006 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 66)]
        public int? P012B007 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 67)]
        public int? P012B008 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 68)]
        public int? P012B009 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 69)]
        public int? P012B010 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 70)]
        public int? P012B011 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 71)]
        public int? P012B012 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 72)]
        public int? P012B013 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 73)]
        public int? P012B014 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 74)]
        public int? P012B015 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 75)]
        public int? P012B016 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 76)]
        public int? P012B017 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 77)]
        public int? P012B018 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 78)]
        public int? P012B019 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 79)]
        public int? P012B020 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 80)]
        public int? P012B021 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 81)]
        public int? P012B022 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 82)]
        public int? P012B023 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 83)]
        public int? P012B024 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 84)]
        public int? P012B025 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 85)]
        public int? P012B026 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 86)]
        public int? P012B027 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 87)]
        public int? P012B028 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 88)]
        public int? P012B029 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 89)]
        public int? P012B030 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 90)]
        public int? P012B031 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 91)]
        public int? P012B032 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 92)]
        public int? P012B033 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 93)]
        public int? P012B034 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 94)]
        public int? P012B035 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 95)]
        public int? P012B036 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 96)]
        public int? P012B037 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 97)]
        public int? P012B038 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 98)]
        public int? P012B039 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 99)]
        public int? P012B040 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 100)]
        public int? P012B041 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 101)]
        public int? P012B042 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 102)]
        public int? P012B043 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 103)]
        public int? P012B044 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 104)]
        public int? P012B045 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 105)]
        public int? P012B046 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 106)]
        public int? P012B047 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 107)]
        public int? P012B048 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 108)]
        public int? P012B049 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 109)]
        public int? P012C001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 110)]
        public int? P012C002 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 111)]
        public int? P012C003 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 112)]
        public int? P012C004 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 113)]
        public int? P012C005 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 114)]
        public int? P012C006 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 115)]
        public int? P012C007 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 116)]
        public int? P012C008 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 117)]
        public int? P012C009 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 118)]
        public int? P012C010 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 119)]
        public int? P012C011 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 120)]
        public int? P012C012 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 121)]
        public int? P012C013 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 122)]
        public int? P012C014 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 123)]
        public int? P012C015 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 124)]
        public int? P012C016 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 125)]
        public int? P012C017 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 126)]
        public int? P012C018 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 127)]
        public int? P012C019 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 128)]
        public int? P012C020 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 129)]
        public int? P012C021 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 130)]
        public int? P012C022 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 131)]
        public int? P012C023 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 132)]
        public int? P012C024 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 133)]
        public int? P012C025 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 134)]
        public int? P012C026 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 135)]
        public int? P012C027 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 136)]
        public int? P012C028 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 137)]
        public int? P012C029 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 138)]
        public int? P012C030 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 139)]
        public int? P012C031 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 140)]
        public int? P012C032 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 141)]
        public int? P012C033 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 142)]
        public int? P012C034 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 143)]
        public int? P012C035 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 144)]
        public int? P012C036 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 145)]
        public int? P012C037 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 146)]
        public int? P012C038 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 147)]
        public int? P012C039 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 148)]
        public int? P012C040 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 149)]
        public int? P012C041 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 150)]
        public int? P012C042 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 151)]
        public int? P012C043 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 152)]
        public int? P012C044 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 153)]
        public int? P012C045 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 154)]
        public int? P012C046 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 155)]
        public int? P012C047 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 156)]
        public int? P012C048 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 157)]
        public int? P012C049 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 158)]
        public int? P012D001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 159)]
        public int? P012D002 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 160)]
        public int? P012D003 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 161)]
        public int? P012D004 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 162)]
        public int? P012D005 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 163)]
        public int? P012D006 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 164)]
        public int? P012D007 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 165)]
        public int? P012D008 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 166)]
        public int? P012D009 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 167)]
        public int? P012D010 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 168)]
        public int? P012D011 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 169)]
        public int? P012D012 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 170)]
        public int? P012D013 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 171)]
        public int? P012D014 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 172)]
        public int? P012D015 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 173)]
        public int? P012D016 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 174)]
        public int? P012D017 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 175)]
        public int? P012D018 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 176)]
        public int? P012D019 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 177)]
        public int? P012D020 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 178)]
        public int? P012D021 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 179)]
        public int? P012D022 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 180)]
        public int? P012D023 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 181)]
        public int? P012D024 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 182)]
        public int? P012D025 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 183)]
        public int? P012D026 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 184)]
        public int? P012D027 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 185)]
        public int? P012D028 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 186)]
        public int? P012D029 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 187)]
        public int? P012D030 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 188)]
        public int? P012D031 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 189)]
        public int? P012D032 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 190)]
        public int? P012D033 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 191)]
        public int? P012D034 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 192)]
        public int? P012D035 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 193)]
        public int? P012D036 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 194)]
        public int? P012D037 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 195)]
        public int? P012D038 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 196)]
        public int? P012D039 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 197)]
        public int? P012D040 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 198)]
        public int? P012D041 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 199)]
        public int? P012D042 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 200)]
        public int? P012D043 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 201)]
        public int? P012D044 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 202)]
        public int? P012D045 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 203)]
        public int? P012D046 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 204)]
        public int? P012D047 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 205)]
        public int? P012D048 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 206)]
        public int? P012D049 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 207)]
        public int? P012E001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 208)]
        public int? P012E002 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 209)]
        public int? P012E003 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 210)]
        public int? P012E004 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 211)]
        public int? P012E005 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 212)]
        public int? P012E006 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 213)]
        public int? P012E007 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 214)]
        public int? P012E008 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 215)]
        public int? P012E009 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 216)]
        public int? P012E010 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 217)]
        public int? P012E011 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 218)]
        public int? P012E012 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 219)]
        public int? P012E013 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 220)]
        public int? P012E014 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 221)]
        public int? P012E015 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 222)]
        public int? P012E016 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 223)]
        public int? P012E017 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 224)]
        public int? P012E018 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 225)]
        public int? P012E019 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 226)]
        public int? P012E020 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 227)]
        public int? P012E021 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 228)]
        public int? P012E022 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 229)]
        public int? P012E023 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 230)]
        public int? P012E024 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 231)]
        public int? P012E025 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 232)]
        public int? P012E026 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 233)]
        public int? P012E027 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 234)]
        public int? P012E028 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 235)]
        public int? P012E029 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 236)]
        public int? P012E030 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 237)]
        public int? P012E031 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 238)]
        public int? P012E032 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 239)]
        public int? P012E033 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 240)]
        public int? P012E034 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 241)]
        public int? P012E035 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 242)]
        public int? P012E036 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 243)]
        public int? P012E037 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 244)]
        public int? P012E038 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 245)]
        public int? P012E039 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 246)]
        public int? P012E040 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 247)]
        public int? P012E041 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 248)]
        public int? P012E042 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 249)]
        public int? P012E043 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 250)]
        public int? P012E044 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 251)]
        public int? P012E045 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 252)]
        public int? P012E046 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 253)]
        public int? P012E047 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 254)]
        public int? P012E048 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 255)]
        public int? P012E049 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public int? P0500001 { get; set; }

        [Display(Name = "Allocated", ShortName = "Allocated", Order = 6)]
        public int? P0500002 { get; set; }

        [Display(Name = "Not allocated", ShortName = "Not allocated", Order = 7)]
        public int? P0500003 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 8)]
        public int? P0510001 { get; set; }

        [Display(Name = "No items allocated", ShortName = "No items allocated", Order = 9)]
        public int? P0510002 { get; set; }

        [Display(Name = "One or more items allocated", ShortName = "One or more items allocated", Order = 10)]
        public int? P0510003 { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}
