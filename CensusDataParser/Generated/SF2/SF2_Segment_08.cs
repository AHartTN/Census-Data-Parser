#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 5:32 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF2_Segment_08.cs
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

    public class SF2_Segment_08
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
        public int? PCO0010001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 6)]
        public int? PCO0010002 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 7)]
        public int? PCO0010003 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 8)]
        public int? PCO0010004 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 9)]
        public int? PCO0010005 { get; set; }

        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 10)]
        public int? PCO0010006 { get; set; }

        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 11)]
        public int? PCO0010007 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 12)]
        public int? PCO0010008 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 13)]
        public int? PCO0010009 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 14)]
        public int? PCO0010010 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 15)]
        public int? PCO0010011 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 16)]
        public int? PCO0010012 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 17)]
        public int? PCO0010013 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 18)]
        public int? PCO0010014 { get; set; }

        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 19)]
        public int? PCO0010015 { get; set; }

        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 20)]
        public int? PCO0010016 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 21)]
        public int? PCO0010017 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 22)]
        public int? PCO0010018 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 23)]
        public int? PCO0010019 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 24)]
        public int? PCO0010020 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 25)]
        public int? PCO0010021 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 26)]
        public int? PCO0010022 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 27)]
        public int? PCO0010023 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 28)]
        public int? PCO0010024 { get; set; }

        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 29)]
        public int? PCO0010025 { get; set; }

        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 30)]
        public int? PCO0010026 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 31)]
        public int? PCO0010027 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 32)]
        public int? PCO0010028 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 33)]
        public int? PCO0010029 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 34)]
        public int? PCO0010030 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 35)]
        public int? PCO0010031 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 36)]
        public int? PCO0010032 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 37)]
        public int? PCO0010033 { get; set; }

        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 38)]
        public int? PCO0010034 { get; set; }

        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 39)]
        public int? PCO0010035 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 40)]
        public int? PCO0010036 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 41)]
        public int? PCO0010037 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 42)]
        public int? PCO0010038 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 43)]
        public int? PCO0010039 { get; set; }

        [Display(Name = "Total (101-106, 201-203, 301, 401-405):", ShortName = "Total (101-106, 201-203, 301, 401-405):", Order = 44)]
        public int? PCO0020001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 45)]
        public int? PCO0020002 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 46)]
        public int? PCO0020003 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 47)]
        public int? PCO0020004 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 48)]
        public int? PCO0020005 { get; set; }

        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 49)]
        public int? PCO0020006 { get; set; }

        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 50)]
        public int? PCO0020007 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 51)]
        public int? PCO0020008 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 52)]
        public int? PCO0020009 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 53)]
        public int? PCO0020010 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 54)]
        public int? PCO0020011 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 55)]
        public int? PCO0020012 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 56)]
        public int? PCO0020013 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 57)]
        public int? PCO0020014 { get; set; }

        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 58)]
        public int? PCO0020015 { get; set; }

        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 59)]
        public int? PCO0020016 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 60)]
        public int? PCO0020017 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 61)]
        public int? PCO0020018 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 62)]
        public int? PCO0020019 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 63)]
        public int? PCO0020020 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 64)]
        public int? PCO0020021 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 65)]
        public int? PCO0020022 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 66)]
        public int? PCO0020023 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 67)]
        public int? PCO0020024 { get; set; }

        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 68)]
        public int? PCO0020025 { get; set; }

        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 69)]
        public int? PCO0020026 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 70)]
        public int? PCO0020027 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 71)]
        public int? PCO0020028 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 72)]
        public int? PCO0020029 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 73)]
        public int? PCO0020030 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 74)]
        public int? PCO0020031 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 75)]
        public int? PCO0020032 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 76)]
        public int? PCO0020033 { get; set; }

        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 77)]
        public int? PCO0020034 { get; set; }

        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 78)]
        public int? PCO0020035 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 79)]
        public int? PCO0020036 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 80)]
        public int? PCO0020037 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 81)]
        public int? PCO0020038 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 82)]
        public int? PCO0020039 { get; set; }

        [Display(Name = "Total (101-106):", ShortName = "Total (101-106):", Order = 83)]
        public int? PCO0030001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 84)]
        public int? PCO0030002 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 85)]
        public int? PCO0030003 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 86)]
        public int? PCO0030004 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 87)]
        public int? PCO0030005 { get; set; }

        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 88)]
        public int? PCO0030006 { get; set; }

        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 89)]
        public int? PCO0030007 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 90)]
        public int? PCO0030008 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 91)]
        public int? PCO0030009 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 92)]
        public int? PCO0030010 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 93)]
        public int? PCO0030011 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 94)]
        public int? PCO0030012 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 95)]
        public int? PCO0030013 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 96)]
        public int? PCO0030014 { get; set; }

        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 97)]
        public int? PCO0030015 { get; set; }

        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 98)]
        public int? PCO0030016 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 99)]
        public int? PCO0030017 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 100)]
        public int? PCO0030018 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 101)]
        public int? PCO0030019 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 102)]
        public int? PCO0030020 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 103)]
        public int? PCO0030021 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 104)]
        public int? PCO0030022 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 105)]
        public int? PCO0030023 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 106)]
        public int? PCO0030024 { get; set; }

        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 107)]
        public int? PCO0030025 { get; set; }

        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 108)]
        public int? PCO0030026 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 109)]
        public int? PCO0030027 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 110)]
        public int? PCO0030028 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 111)]
        public int? PCO0030029 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 112)]
        public int? PCO0030030 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 113)]
        public int? PCO0030031 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 114)]
        public int? PCO0030032 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 115)]
        public int? PCO0030033 { get; set; }

        [Display(Name = "Total (201-203):", ShortName = "Total (201-203):", Order = 116)]
        public int? PCO0040001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 117)]
        public int? PCO0040002 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 118)]
        public int? PCO0040003 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 119)]
        public int? PCO0040004 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 120)]
        public int? PCO0040005 { get; set; }

        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 121)]
        public int? PCO0040006 { get; set; }

        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 122)]
        public int? PCO0040007 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 123)]
        public int? PCO0040008 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 124)]
        public int? PCO0040009 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 125)]
        public int? PCO0040010 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 126)]
        public int? PCO0040011 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 127)]
        public int? PCO0040012 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 128)]
        public int? PCO0040013 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 129)]
        public int? PCO0040014 { get; set; }

        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 130)]
        public int? PCO0040015 { get; set; }

        [Display(Name = "Total (301):", ShortName = "Total (301):", Order = 131)]
        public int? PCO0050001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 132)]
        public int? PCO0050002 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 133)]
        public int? PCO0050003 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 134)]
        public int? PCO0050004 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 135)]
        public int? PCO0050005 { get; set; }

        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 136)]
        public int? PCO0050006 { get; set; }

        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 137)]
        public int? PCO0050007 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 138)]
        public int? PCO0050008 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 139)]
        public int? PCO0050009 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 140)]
        public int? PCO0050010 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 141)]
        public int? PCO0050011 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 142)]
        public int? PCO0050012 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 143)]
        public int? PCO0050013 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 144)]
        public int? PCO0050014 { get; set; }

        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 145)]
        public int? PCO0050015 { get; set; }

        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 146)]
        public int? PCO0050016 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 147)]
        public int? PCO0050017 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 148)]
        public int? PCO0050018 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 149)]
        public int? PCO0050019 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 150)]
        public int? PCO0050020 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 151)]
        public int? PCO0050021 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 152)]
        public int? PCO0050022 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 153)]
        public int? PCO0050023 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 154)]
        public int? PCO0050024 { get; set; }

        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 155)]
        public int? PCO0050025 { get; set; }

        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 156)]
        public int? PCO0050026 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 157)]
        public int? PCO0050027 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 158)]
        public int? PCO0050028 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 159)]
        public int? PCO0050029 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 160)]
        public int? PCO0050030 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 161)]
        public int? PCO0050031 { get; set; }

        [Display(Name = "Total (401-405):", ShortName = "Total (401-405):", Order = 162)]
        public int? PCO0060001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 163)]
        public int? PCO0060002 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 164)]
        public int? PCO0060003 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 165)]
        public int? PCO0060004 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 166)]
        public int? PCO0060005 { get; set; }

        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 167)]
        public int? PCO0060006 { get; set; }

        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 168)]
        public int? PCO0060007 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 169)]
        public int? PCO0060008 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 170)]
        public int? PCO0060009 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 171)]
        public int? PCO0060010 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 172)]
        public int? PCO0060011 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 173)]
        public int? PCO0060012 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 174)]
        public int? PCO0060013 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 175)]
        public int? PCO0060014 { get; set; }

        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 176)]
        public int? PCO0060015 { get; set; }

        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 177)]
        public int? PCO0060016 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 178)]
        public int? PCO0060017 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 179)]
        public int? PCO0060018 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 180)]
        public int? PCO0060019 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 181)]
        public int? PCO0060020 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 182)]
        public int? PCO0060021 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 183)]
        public int? PCO0060022 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 184)]
        public int? PCO0060023 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 185)]
        public int? PCO0060024 { get; set; }

        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 186)]
        public int? PCO0060025 { get; set; }

        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 187)]
        public int? PCO0060026 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 188)]
        public int? PCO0060027 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 189)]
        public int? PCO0060028 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 190)]
        public int? PCO0060029 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 191)]
        public int? PCO0060030 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 192)]
        public int? PCO0060031 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 193)]
        public int? PCO0060032 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 194)]
        public int? PCO0060033 { get; set; }

        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 195)]
        public int? PCO0060034 { get; set; }

        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 196)]
        public int? PCO0060035 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 197)]
        public int? PCO0060036 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 198)]
        public int? PCO0060037 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 199)]
        public int? PCO0060038 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 200)]
        public int? PCO0060039 { get; set; }

        [Display(Name = "Total (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Total (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 201)]
        public int? PCO0070001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 202)]
        public int? PCO0070002 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 203)]
        public int? PCO0070003 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 204)]
        public int? PCO0070004 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 205)]
        public int? PCO0070005 { get; set; }

        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 206)]
        public int? PCO0070006 { get; set; }

        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 207)]
        public int? PCO0070007 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 208)]
        public int? PCO0070008 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 209)]
        public int? PCO0070009 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 210)]
        public int? PCO0070010 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 211)]
        public int? PCO0070011 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 212)]
        public int? PCO0070012 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 213)]
        public int? PCO0070013 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 214)]
        public int? PCO0070014 { get; set; }

        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 215)]
        public int? PCO0070015 { get; set; }

        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 216)]
        public int? PCO0070016 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 217)]
        public int? PCO0070017 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 218)]
        public int? PCO0070018 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 219)]
        public int? PCO0070019 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 220)]
        public int? PCO0070020 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 221)]
        public int? PCO0070021 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 222)]
        public int? PCO0070022 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 223)]
        public int? PCO0070023 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 224)]
        public int? PCO0070024 { get; set; }

        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 225)]
        public int? PCO0070025 { get; set; }

        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 226)]
        public int? PCO0070026 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 227)]
        public int? PCO0070027 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 228)]
        public int? PCO0070028 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 229)]
        public int? PCO0070029 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 230)]
        public int? PCO0070030 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 231)]
        public int? PCO0070031 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 232)]
        public int? PCO0070032 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 233)]
        public int? PCO0070033 { get; set; }

        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 234)]
        public int? PCO0070034 { get; set; }

        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 235)]
        public int? PCO0070035 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 236)]
        public int? PCO0070036 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 237)]
        public int? PCO0070037 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 238)]
        public int? PCO0070038 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 239)]
        public int? PCO0070039 { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}
