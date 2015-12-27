#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 5:31 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1_00031.cs
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

    public class SF1_00031
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
        public int? PCT012L001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 6)]
        public int? PCT012L002 { get; set; }

        [Display(Name = "Under 1 year", ShortName = "Under 1 year", Order = 7)]
        public int? PCT012L003 { get; set; }

        [Display(Name = "1 year", ShortName = "1 year", Order = 8)]
        public int? PCT012L004 { get; set; }

        [Display(Name = "2 years", ShortName = "2 years", Order = 9)]
        public int? PCT012L005 { get; set; }

        [Display(Name = "3 years", ShortName = "3 years", Order = 10)]
        public int? PCT012L006 { get; set; }

        [Display(Name = "4 years", ShortName = "4 years", Order = 11)]
        public int? PCT012L007 { get; set; }

        [Display(Name = "5 years", ShortName = "5 years", Order = 12)]
        public int? PCT012L008 { get; set; }

        [Display(Name = "6 years", ShortName = "6 years", Order = 13)]
        public int? PCT012L009 { get; set; }

        [Display(Name = "7 years", ShortName = "7 years", Order = 14)]
        public int? PCT012L010 { get; set; }

        [Display(Name = "8 years", ShortName = "8 years", Order = 15)]
        public int? PCT012L011 { get; set; }

        [Display(Name = "9 years", ShortName = "9 years", Order = 16)]
        public int? PCT012L012 { get; set; }

        [Display(Name = "10 years", ShortName = "10 years", Order = 17)]
        public int? PCT012L013 { get; set; }

        [Display(Name = "11 years", ShortName = "11 years", Order = 18)]
        public int? PCT012L014 { get; set; }

        [Display(Name = "12 years", ShortName = "12 years", Order = 19)]
        public int? PCT012L015 { get; set; }

        [Display(Name = "13 years", ShortName = "13 years", Order = 20)]
        public int? PCT012L016 { get; set; }

        [Display(Name = "14 years", ShortName = "14 years", Order = 21)]
        public int? PCT012L017 { get; set; }

        [Display(Name = "15 years", ShortName = "15 years", Order = 22)]
        public int? PCT012L018 { get; set; }

        [Display(Name = "16 years", ShortName = "16 years", Order = 23)]
        public int? PCT012L019 { get; set; }

        [Display(Name = "17 years", ShortName = "17 years", Order = 24)]
        public int? PCT012L020 { get; set; }

        [Display(Name = "18 years", ShortName = "18 years", Order = 25)]
        public int? PCT012L021 { get; set; }

        [Display(Name = "19 years", ShortName = "19 years", Order = 26)]
        public int? PCT012L022 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 27)]
        public int? PCT012L023 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 28)]
        public int? PCT012L024 { get; set; }

        [Display(Name = "22 years", ShortName = "22 years", Order = 29)]
        public int? PCT012L025 { get; set; }

        [Display(Name = "23 years", ShortName = "23 years", Order = 30)]
        public int? PCT012L026 { get; set; }

        [Display(Name = "24 years", ShortName = "24 years", Order = 31)]
        public int? PCT012L027 { get; set; }

        [Display(Name = "25 years", ShortName = "25 years", Order = 32)]
        public int? PCT012L028 { get; set; }

        [Display(Name = "26 years", ShortName = "26 years", Order = 33)]
        public int? PCT012L029 { get; set; }

        [Display(Name = "27 years", ShortName = "27 years", Order = 34)]
        public int? PCT012L030 { get; set; }

        [Display(Name = "28 years", ShortName = "28 years", Order = 35)]
        public int? PCT012L031 { get; set; }

        [Display(Name = "29 years", ShortName = "29 years", Order = 36)]
        public int? PCT012L032 { get; set; }

        [Display(Name = "30 years", ShortName = "30 years", Order = 37)]
        public int? PCT012L033 { get; set; }

        [Display(Name = "31 years", ShortName = "31 years", Order = 38)]
        public int? PCT012L034 { get; set; }

        [Display(Name = "32 years", ShortName = "32 years", Order = 39)]
        public int? PCT012L035 { get; set; }

        [Display(Name = "33 years", ShortName = "33 years", Order = 40)]
        public int? PCT012L036 { get; set; }

        [Display(Name = "34 years", ShortName = "34 years", Order = 41)]
        public int? PCT012L037 { get; set; }

        [Display(Name = "35 years", ShortName = "35 years", Order = 42)]
        public int? PCT012L038 { get; set; }

        [Display(Name = "36 years", ShortName = "36 years", Order = 43)]
        public int? PCT012L039 { get; set; }

        [Display(Name = "37 years", ShortName = "37 years", Order = 44)]
        public int? PCT012L040 { get; set; }

        [Display(Name = "38 years", ShortName = "38 years", Order = 45)]
        public int? PCT012L041 { get; set; }

        [Display(Name = "39 years", ShortName = "39 years", Order = 46)]
        public int? PCT012L042 { get; set; }

        [Display(Name = "40 years", ShortName = "40 years", Order = 47)]
        public int? PCT012L043 { get; set; }

        [Display(Name = "41 years", ShortName = "41 years", Order = 48)]
        public int? PCT012L044 { get; set; }

        [Display(Name = "42 years", ShortName = "42 years", Order = 49)]
        public int? PCT012L045 { get; set; }

        [Display(Name = "43 years", ShortName = "43 years", Order = 50)]
        public int? PCT012L046 { get; set; }

        [Display(Name = "44 years", ShortName = "44 years", Order = 51)]
        public int? PCT012L047 { get; set; }

        [Display(Name = "45 years", ShortName = "45 years", Order = 52)]
        public int? PCT012L048 { get; set; }

        [Display(Name = "46 years", ShortName = "46 years", Order = 53)]
        public int? PCT012L049 { get; set; }

        [Display(Name = "47 years", ShortName = "47 years", Order = 54)]
        public int? PCT012L050 { get; set; }

        [Display(Name = "48 years", ShortName = "48 years", Order = 55)]
        public int? PCT012L051 { get; set; }

        [Display(Name = "49 years", ShortName = "49 years", Order = 56)]
        public int? PCT012L052 { get; set; }

        [Display(Name = "50 years", ShortName = "50 years", Order = 57)]
        public int? PCT012L053 { get; set; }

        [Display(Name = "51 years", ShortName = "51 years", Order = 58)]
        public int? PCT012L054 { get; set; }

        [Display(Name = "52 years", ShortName = "52 years", Order = 59)]
        public int? PCT012L055 { get; set; }

        [Display(Name = "53 years", ShortName = "53 years", Order = 60)]
        public int? PCT012L056 { get; set; }

        [Display(Name = "54 years", ShortName = "54 years", Order = 61)]
        public int? PCT012L057 { get; set; }

        [Display(Name = "55 years", ShortName = "55 years", Order = 62)]
        public int? PCT012L058 { get; set; }

        [Display(Name = "56 years", ShortName = "56 years", Order = 63)]
        public int? PCT012L059 { get; set; }

        [Display(Name = "57 years", ShortName = "57 years", Order = 64)]
        public int? PCT012L060 { get; set; }

        [Display(Name = "58 years", ShortName = "58 years", Order = 65)]
        public int? PCT012L061 { get; set; }

        [Display(Name = "59 years", ShortName = "59 years", Order = 66)]
        public int? PCT012L062 { get; set; }

        [Display(Name = "60 years", ShortName = "60 years", Order = 67)]
        public int? PCT012L063 { get; set; }

        [Display(Name = "61 years", ShortName = "61 years", Order = 68)]
        public int? PCT012L064 { get; set; }

        [Display(Name = "62 years", ShortName = "62 years", Order = 69)]
        public int? PCT012L065 { get; set; }

        [Display(Name = "63 years", ShortName = "63 years", Order = 70)]
        public int? PCT012L066 { get; set; }

        [Display(Name = "64 years", ShortName = "64 years", Order = 71)]
        public int? PCT012L067 { get; set; }

        [Display(Name = "65 years", ShortName = "65 years", Order = 72)]
        public int? PCT012L068 { get; set; }

        [Display(Name = "66 years", ShortName = "66 years", Order = 73)]
        public int? PCT012L069 { get; set; }

        [Display(Name = "67 years", ShortName = "67 years", Order = 74)]
        public int? PCT012L070 { get; set; }

        [Display(Name = "68 years", ShortName = "68 years", Order = 75)]
        public int? PCT012L071 { get; set; }

        [Display(Name = "69 years", ShortName = "69 years", Order = 76)]
        public int? PCT012L072 { get; set; }

        [Display(Name = "70 years", ShortName = "70 years", Order = 77)]
        public int? PCT012L073 { get; set; }

        [Display(Name = "71 years", ShortName = "71 years", Order = 78)]
        public int? PCT012L074 { get; set; }

        [Display(Name = "72 years", ShortName = "72 years", Order = 79)]
        public int? PCT012L075 { get; set; }

        [Display(Name = "73 years", ShortName = "73 years", Order = 80)]
        public int? PCT012L076 { get; set; }

        [Display(Name = "74 years", ShortName = "74 years", Order = 81)]
        public int? PCT012L077 { get; set; }

        [Display(Name = "75 years", ShortName = "75 years", Order = 82)]
        public int? PCT012L078 { get; set; }

        [Display(Name = "76 years", ShortName = "76 years", Order = 83)]
        public int? PCT012L079 { get; set; }

        [Display(Name = "77 years", ShortName = "77 years", Order = 84)]
        public int? PCT012L080 { get; set; }

        [Display(Name = "78 years", ShortName = "78 years", Order = 85)]
        public int? PCT012L081 { get; set; }

        [Display(Name = "79 years", ShortName = "79 years", Order = 86)]
        public int? PCT012L082 { get; set; }

        [Display(Name = "80 years", ShortName = "80 years", Order = 87)]
        public int? PCT012L083 { get; set; }

        [Display(Name = "81 years", ShortName = "81 years", Order = 88)]
        public int? PCT012L084 { get; set; }

        [Display(Name = "82 years", ShortName = "82 years", Order = 89)]
        public int? PCT012L085 { get; set; }

        [Display(Name = "83 years", ShortName = "83 years", Order = 90)]
        public int? PCT012L086 { get; set; }

        [Display(Name = "84 years", ShortName = "84 years", Order = 91)]
        public int? PCT012L087 { get; set; }

        [Display(Name = "85 years", ShortName = "85 years", Order = 92)]
        public int? PCT012L088 { get; set; }

        [Display(Name = "86 years", ShortName = "86 years", Order = 93)]
        public int? PCT012L089 { get; set; }

        [Display(Name = "87 years", ShortName = "87 years", Order = 94)]
        public int? PCT012L090 { get; set; }

        [Display(Name = "88 years", ShortName = "88 years", Order = 95)]
        public int? PCT012L091 { get; set; }

        [Display(Name = "89 years", ShortName = "89 years", Order = 96)]
        public int? PCT012L092 { get; set; }

        [Display(Name = "90 years", ShortName = "90 years", Order = 97)]
        public int? PCT012L093 { get; set; }

        [Display(Name = "91 years", ShortName = "91 years", Order = 98)]
        public int? PCT012L094 { get; set; }

        [Display(Name = "92 years", ShortName = "92 years", Order = 99)]
        public int? PCT012L095 { get; set; }

        [Display(Name = "93 years", ShortName = "93 years", Order = 100)]
        public int? PCT012L096 { get; set; }

        [Display(Name = "94 years", ShortName = "94 years", Order = 101)]
        public int? PCT012L097 { get; set; }

        [Display(Name = "95 years", ShortName = "95 years", Order = 102)]
        public int? PCT012L098 { get; set; }

        [Display(Name = "96 years", ShortName = "96 years", Order = 103)]
        public int? PCT012L099 { get; set; }

        [Display(Name = "97 years", ShortName = "97 years", Order = 104)]
        public int? PCT012L100 { get; set; }

        [Display(Name = "98 years", ShortName = "98 years", Order = 105)]
        public int? PCT012L101 { get; set; }

        [Display(Name = "99 years", ShortName = "99 years", Order = 106)]
        public int? PCT012L102 { get; set; }

        [Display(Name = "100 to 104 years", ShortName = "100 to 104 years", Order = 107)]
        public int? PCT012L103 { get; set; }

        [Display(Name = "105 to 109 years", ShortName = "105 to 109 years", Order = 108)]
        public int? PCT012L104 { get; set; }

        [Display(Name = "110 years and over", ShortName = "110 years and over", Order = 109)]
        public int? PCT012L105 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 110)]
        public int? PCT012L106 { get; set; }

        [Display(Name = "Under 1 year", ShortName = "Under 1 year", Order = 111)]
        public int? PCT012L107 { get; set; }

        [Display(Name = "1 year", ShortName = "1 year", Order = 112)]
        public int? PCT012L108 { get; set; }

        [Display(Name = "2 years", ShortName = "2 years", Order = 113)]
        public int? PCT012L109 { get; set; }

        [Display(Name = "3 years", ShortName = "3 years", Order = 114)]
        public int? PCT012L110 { get; set; }

        [Display(Name = "4 years", ShortName = "4 years", Order = 115)]
        public int? PCT012L111 { get; set; }

        [Display(Name = "5 years", ShortName = "5 years", Order = 116)]
        public int? PCT012L112 { get; set; }

        [Display(Name = "6 years", ShortName = "6 years", Order = 117)]
        public int? PCT012L113 { get; set; }

        [Display(Name = "7 years", ShortName = "7 years", Order = 118)]
        public int? PCT012L114 { get; set; }

        [Display(Name = "8 years", ShortName = "8 years", Order = 119)]
        public int? PCT012L115 { get; set; }

        [Display(Name = "9 years", ShortName = "9 years", Order = 120)]
        public int? PCT012L116 { get; set; }

        [Display(Name = "10 years", ShortName = "10 years", Order = 121)]
        public int? PCT012L117 { get; set; }

        [Display(Name = "11 years", ShortName = "11 years", Order = 122)]
        public int? PCT012L118 { get; set; }

        [Display(Name = "12 years", ShortName = "12 years", Order = 123)]
        public int? PCT012L119 { get; set; }

        [Display(Name = "13 years", ShortName = "13 years", Order = 124)]
        public int? PCT012L120 { get; set; }

        [Display(Name = "14 years", ShortName = "14 years", Order = 125)]
        public int? PCT012L121 { get; set; }

        [Display(Name = "15 years", ShortName = "15 years", Order = 126)]
        public int? PCT012L122 { get; set; }

        [Display(Name = "16 years", ShortName = "16 years", Order = 127)]
        public int? PCT012L123 { get; set; }

        [Display(Name = "17 years", ShortName = "17 years", Order = 128)]
        public int? PCT012L124 { get; set; }

        [Display(Name = "18 years", ShortName = "18 years", Order = 129)]
        public int? PCT012L125 { get; set; }

        [Display(Name = "19 years", ShortName = "19 years", Order = 130)]
        public int? PCT012L126 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 131)]
        public int? PCT012L127 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 132)]
        public int? PCT012L128 { get; set; }

        [Display(Name = "22 years", ShortName = "22 years", Order = 133)]
        public int? PCT012L129 { get; set; }

        [Display(Name = "23 years", ShortName = "23 years", Order = 134)]
        public int? PCT012L130 { get; set; }

        [Display(Name = "24 years", ShortName = "24 years", Order = 135)]
        public int? PCT012L131 { get; set; }

        [Display(Name = "25 years", ShortName = "25 years", Order = 136)]
        public int? PCT012L132 { get; set; }

        [Display(Name = "26 years", ShortName = "26 years", Order = 137)]
        public int? PCT012L133 { get; set; }

        [Display(Name = "27 years", ShortName = "27 years", Order = 138)]
        public int? PCT012L134 { get; set; }

        [Display(Name = "28 years", ShortName = "28 years", Order = 139)]
        public int? PCT012L135 { get; set; }

        [Display(Name = "29 years", ShortName = "29 years", Order = 140)]
        public int? PCT012L136 { get; set; }

        [Display(Name = "30 years", ShortName = "30 years", Order = 141)]
        public int? PCT012L137 { get; set; }

        [Display(Name = "31 years", ShortName = "31 years", Order = 142)]
        public int? PCT012L138 { get; set; }

        [Display(Name = "32 years", ShortName = "32 years", Order = 143)]
        public int? PCT012L139 { get; set; }

        [Display(Name = "33 years", ShortName = "33 years", Order = 144)]
        public int? PCT012L140 { get; set; }

        [Display(Name = "34 years", ShortName = "34 years", Order = 145)]
        public int? PCT012L141 { get; set; }

        [Display(Name = "35 years", ShortName = "35 years", Order = 146)]
        public int? PCT012L142 { get; set; }

        [Display(Name = "36 years", ShortName = "36 years", Order = 147)]
        public int? PCT012L143 { get; set; }

        [Display(Name = "37 years", ShortName = "37 years", Order = 148)]
        public int? PCT012L144 { get; set; }

        [Display(Name = "38 years", ShortName = "38 years", Order = 149)]
        public int? PCT012L145 { get; set; }

        [Display(Name = "39 years", ShortName = "39 years", Order = 150)]
        public int? PCT012L146 { get; set; }

        [Display(Name = "40 years", ShortName = "40 years", Order = 151)]
        public int? PCT012L147 { get; set; }

        [Display(Name = "41 years", ShortName = "41 years", Order = 152)]
        public int? PCT012L148 { get; set; }

        [Display(Name = "42 years", ShortName = "42 years", Order = 153)]
        public int? PCT012L149 { get; set; }

        [Display(Name = "43 years", ShortName = "43 years", Order = 154)]
        public int? PCT012L150 { get; set; }

        [Display(Name = "44 years", ShortName = "44 years", Order = 155)]
        public int? PCT012L151 { get; set; }

        [Display(Name = "45 years", ShortName = "45 years", Order = 156)]
        public int? PCT012L152 { get; set; }

        [Display(Name = "46 years", ShortName = "46 years", Order = 157)]
        public int? PCT012L153 { get; set; }

        [Display(Name = "47 years", ShortName = "47 years", Order = 158)]
        public int? PCT012L154 { get; set; }

        [Display(Name = "48 years", ShortName = "48 years", Order = 159)]
        public int? PCT012L155 { get; set; }

        [Display(Name = "49 years", ShortName = "49 years", Order = 160)]
        public int? PCT012L156 { get; set; }

        [Display(Name = "50 years", ShortName = "50 years", Order = 161)]
        public int? PCT012L157 { get; set; }

        [Display(Name = "51 years", ShortName = "51 years", Order = 162)]
        public int? PCT012L158 { get; set; }

        [Display(Name = "52 years", ShortName = "52 years", Order = 163)]
        public int? PCT012L159 { get; set; }

        [Display(Name = "53 years", ShortName = "53 years", Order = 164)]
        public int? PCT012L160 { get; set; }

        [Display(Name = "54 years", ShortName = "54 years", Order = 165)]
        public int? PCT012L161 { get; set; }

        [Display(Name = "55 years", ShortName = "55 years", Order = 166)]
        public int? PCT012L162 { get; set; }

        [Display(Name = "56 years", ShortName = "56 years", Order = 167)]
        public int? PCT012L163 { get; set; }

        [Display(Name = "57 years", ShortName = "57 years", Order = 168)]
        public int? PCT012L164 { get; set; }

        [Display(Name = "58 years", ShortName = "58 years", Order = 169)]
        public int? PCT012L165 { get; set; }

        [Display(Name = "59 years", ShortName = "59 years", Order = 170)]
        public int? PCT012L166 { get; set; }

        [Display(Name = "60 years", ShortName = "60 years", Order = 171)]
        public int? PCT012L167 { get; set; }

        [Display(Name = "61 years", ShortName = "61 years", Order = 172)]
        public int? PCT012L168 { get; set; }

        [Display(Name = "62 years", ShortName = "62 years", Order = 173)]
        public int? PCT012L169 { get; set; }

        [Display(Name = "63 years", ShortName = "63 years", Order = 174)]
        public int? PCT012L170 { get; set; }

        [Display(Name = "64 years", ShortName = "64 years", Order = 175)]
        public int? PCT012L171 { get; set; }

        [Display(Name = "65 years", ShortName = "65 years", Order = 176)]
        public int? PCT012L172 { get; set; }

        [Display(Name = "66 years", ShortName = "66 years", Order = 177)]
        public int? PCT012L173 { get; set; }

        [Display(Name = "67 years", ShortName = "67 years", Order = 178)]
        public int? PCT012L174 { get; set; }

        [Display(Name = "68 years", ShortName = "68 years", Order = 179)]
        public int? PCT012L175 { get; set; }

        [Display(Name = "69 years", ShortName = "69 years", Order = 180)]
        public int? PCT012L176 { get; set; }

        [Display(Name = "70 years", ShortName = "70 years", Order = 181)]
        public int? PCT012L177 { get; set; }

        [Display(Name = "71 years", ShortName = "71 years", Order = 182)]
        public int? PCT012L178 { get; set; }

        [Display(Name = "72 years", ShortName = "72 years", Order = 183)]
        public int? PCT012L179 { get; set; }

        [Display(Name = "73 years", ShortName = "73 years", Order = 184)]
        public int? PCT012L180 { get; set; }

        [Display(Name = "74 years", ShortName = "74 years", Order = 185)]
        public int? PCT012L181 { get; set; }

        [Display(Name = "75 years", ShortName = "75 years", Order = 186)]
        public int? PCT012L182 { get; set; }

        [Display(Name = "76 years", ShortName = "76 years", Order = 187)]
        public int? PCT012L183 { get; set; }

        [Display(Name = "77 years", ShortName = "77 years", Order = 188)]
        public int? PCT012L184 { get; set; }

        [Display(Name = "78 years", ShortName = "78 years", Order = 189)]
        public int? PCT012L185 { get; set; }

        [Display(Name = "79 years", ShortName = "79 years", Order = 190)]
        public int? PCT012L186 { get; set; }

        [Display(Name = "80 years", ShortName = "80 years", Order = 191)]
        public int? PCT012L187 { get; set; }

        [Display(Name = "81 years", ShortName = "81 years", Order = 192)]
        public int? PCT012L188 { get; set; }

        [Display(Name = "82 years", ShortName = "82 years", Order = 193)]
        public int? PCT012L189 { get; set; }

        [Display(Name = "83 years", ShortName = "83 years", Order = 194)]
        public int? PCT012L190 { get; set; }

        [Display(Name = "84 years", ShortName = "84 years", Order = 195)]
        public int? PCT012L191 { get; set; }

        [Display(Name = "85 years", ShortName = "85 years", Order = 196)]
        public int? PCT012L192 { get; set; }

        [Display(Name = "86 years", ShortName = "86 years", Order = 197)]
        public int? PCT012L193 { get; set; }

        [Display(Name = "87 years", ShortName = "87 years", Order = 198)]
        public int? PCT012L194 { get; set; }

        [Display(Name = "88 years", ShortName = "88 years", Order = 199)]
        public int? PCT012L195 { get; set; }

        [Display(Name = "89 years", ShortName = "89 years", Order = 200)]
        public int? PCT012L196 { get; set; }

        [Display(Name = "90 years", ShortName = "90 years", Order = 201)]
        public int? PCT012L197 { get; set; }

        [Display(Name = "91 years", ShortName = "91 years", Order = 202)]
        public int? PCT012L198 { get; set; }

        [Display(Name = "92 years", ShortName = "92 years", Order = 203)]
        public int? PCT012L199 { get; set; }

        [Display(Name = "93 years", ShortName = "93 years", Order = 204)]
        public int? PCT012L200 { get; set; }

        [Display(Name = "94 years", ShortName = "94 years", Order = 205)]
        public int? PCT012L201 { get; set; }

        [Display(Name = "95 years", ShortName = "95 years", Order = 206)]
        public int? PCT012L202 { get; set; }

        [Display(Name = "96 years", ShortName = "96 years", Order = 207)]
        public int? PCT012L203 { get; set; }

        [Display(Name = "97 years", ShortName = "97 years", Order = 208)]
        public int? PCT012L204 { get; set; }

        [Display(Name = "98 years", ShortName = "98 years", Order = 209)]
        public int? PCT012L205 { get; set; }

        [Display(Name = "99 years", ShortName = "99 years", Order = 210)]
        public int? PCT012L206 { get; set; }

        [Display(Name = "100 to 104 years", ShortName = "100 to 104 years", Order = 211)]
        public int? PCT012L207 { get; set; }

        [Display(Name = "105 to 109 years", ShortName = "105 to 109 years", Order = 212)]
        public int? PCT012L208 { get; set; }

        [Display(Name = "110 years and over", ShortName = "110 years and over", Order = 213)]
        public int? PCT012L209 { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}
