#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 5:32 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1_00004.cs
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

    public class SF1_00004
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
        public int? P0100001 { get; set; }

        [Display(Name = "Population of one race:", ShortName = "Population of one race:", Order = 6)]
        public int? P0100002 { get; set; }

        [Display(Name = "White alone", ShortName = "White alone", Order = 7)]
        public int? P0100003 { get; set; }

        [Display(Name = "Black or African American alone", ShortName = "Black or African American alone", Order = 8)]
        public int? P0100004 { get; set; }

        [Display(Name = "American Indian and Alaska Native alone", ShortName = "American Indian and Alaska Native alone", Order = 9)]
        public int? P0100005 { get; set; }

        [Display(Name = "Asian alone", ShortName = "Asian alone", Order = 10)]
        public int? P0100006 { get; set; }

        [Display(Name = "Native Hawaiian and Other Pacific Islander alone", ShortName = "Native Hawaiian and Other Pacific Islander alone", Order = 11)]
        public int? P0100007 { get; set; }

        [Display(Name = "Some Other Race alone", ShortName = "Some Other Race alone", Order = 12)]
        public int? P0100008 { get; set; }

        [Display(Name = "Two or More Races:", ShortName = "Two or More Races:", Order = 13)]
        public int? P0100009 { get; set; }

        [Display(Name = "Population of two races:", ShortName = "Population of two races:", Order = 14)]
        public int? P0100010 { get; set; }

        [Display(Name = "White; Black or African American", ShortName = "White; Black or African American", Order = 15)]
        public int? P0100011 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native", ShortName = "White; American Indian and Alaska Native", Order = 16)]
        public int? P0100012 { get; set; }

        [Display(Name = "White; Asian", ShortName = "White; Asian", Order = 17)]
        public int? P0100013 { get; set; }

        [Display(Name = "White; Native Hawaiian and Other Pacific Islander", ShortName = "White; Native Hawaiian and Other Pacific Islander", Order = 18)]
        public int? P0100014 { get; set; }

        [Display(Name = "White; Some Other Race", ShortName = "White; Some Other Race", Order = 19)]
        public int? P0100015 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native", ShortName = "Black or African American; American Indian and Alaska Native", Order = 20)]
        public int? P0100016 { get; set; }

        [Display(Name = "Black or African American; Asian", ShortName = "Black or African American; Asian", Order = 21)]
        public int? P0100017 { get; set; }

        [Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander", Order = 22)]
        public int? P0100018 { get; set; }

        [Display(Name = "Black or African American; Some Other Race", ShortName = "Black or African American; Some Other Race", Order = 23)]
        public int? P0100019 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Asian", ShortName = "American Indian and Alaska Native; Asian", Order = 24)]
        public int? P0100020 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 25)]
        public int? P0100021 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Some Other Race", ShortName = "American Indian and Alaska Native; Some Other Race", Order = 26)]
        public int? P0100022 { get; set; }

        [Display(Name = "Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Asian; Native Hawaiian and Other Pacific Islander", Order = 27)]
        public int? P0100023 { get; set; }

        [Display(Name = "Asian; Some Other Race", ShortName = "Asian; Some Other Race", Order = 28)]
        public int? P0100024 { get; set; }

        [Display(Name = "Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 29)]
        public int? P0100025 { get; set; }

        [Display(Name = "Population of three races:", ShortName = "Population of three races:", Order = 30)]
        public int? P0100026 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native", ShortName = "White; Black or African American; American Indian and Alaska Native", Order = 31)]
        public int? P0100027 { get; set; }

        [Display(Name = "White; Black or African American; Asian", ShortName = "White; Black or African American; Asian", Order = 32)]
        public int? P0100028 { get; set; }

        [Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander", Order = 33)]
        public int? P0100029 { get; set; }

        [Display(Name = "White; Black or African American; Some Other Race", ShortName = "White; Black or African American; Some Other Race", Order = 34)]
        public int? P0100030 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Asian", ShortName = "White; American Indian and Alaska Native; Asian", Order = 35)]
        public int? P0100031 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 36)]
        public int? P0100032 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Some Other Race", ShortName = "White; American Indian and Alaska Native; Some Other Race", Order = 37)]
        public int? P0100033 { get; set; }

        [Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander", Order = 38)]
        public int? P0100034 { get; set; }

        [Display(Name = "White; Asian; Some Other Race", ShortName = "White; Asian; Some Other Race", Order = 39)]
        public int? P0100035 { get; set; }

        [Display(Name = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 40)]
        public int? P0100036 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian", ShortName = "Black or African American; American Indian and Alaska Native; Asian", Order = 41)]
        public int? P0100037 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 42)]
        public int? P0100038 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Some Other Race", Order = 43)]
        public int? P0100039 { get; set; }

        [Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 44)]
        public int? P0100040 { get; set; }

        [Display(Name = "Black or African American; Asian; Some Other Race", ShortName = "Black or African American; Asian; Some Other Race", Order = 45)]
        public int? P0100041 { get; set; }

        [Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 46)]
        public int? P0100042 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 47)]
        public int? P0100043 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Asian; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Some Other Race", Order = 48)]
        public int? P0100044 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 49)]
        public int? P0100045 { get; set; }

        [Display(Name = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 50)]
        public int? P0100046 { get; set; }

        [Display(Name = "Population of four races:", ShortName = "Population of four races:", Order = 51)]
        public int? P0100047 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian", Order = 52)]
        public int? P0100048 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 53)]
        public int? P0100049 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Some Other Race", Order = 54)]
        public int? P0100050 { get; set; }

        [Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 55)]
        public int? P0100051 { get; set; }

        [Display(Name = "White; Black or African American; Asian; Some Other Race", ShortName = "White; Black or African American; Asian; Some Other Race", Order = 56)]
        public int? P0100052 { get; set; }

        [Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 57)]
        public int? P0100053 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 58)]
        public int? P0100054 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Some Other Race", Order = 59)]
        public int? P0100055 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 60)]
        public int? P0100056 { get; set; }

        [Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 61)]
        public int? P0100057 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 62)]
        public int? P0100058 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 63)]
        public int? P0100059 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 64)]
        public int? P0100060 { get; set; }

        [Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 65)]
        public int? P0100061 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 66)]
        public int? P0100062 { get; set; }

        [Display(Name = "Population of five races:", ShortName = "Population of five races:", Order = 67)]
        public int? P0100063 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 68)]
        public int? P0100064 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 69)]
        public int? P0100065 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 70)]
        public int? P0100066 { get; set; }

        [Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 71)]
        public int? P0100067 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 72)]
        public int? P0100068 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 73)]
        public int? P0100069 { get; set; }

        [Display(Name = "Population of six races:", ShortName = "Population of six races:", Order = 74)]
        public int? P0100070 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 75)]
        public int? P0100071 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 76)]
        public int? P0110001 { get; set; }

        [Display(Name = "Hispanic or Latino", ShortName = "Hispanic or Latino", Order = 77)]
        public int? P0110002 { get; set; }

        [Display(Name = "Not Hispanic or Latino:", ShortName = "Not Hispanic or Latino:", Order = 78)]
        public int? P0110003 { get; set; }

        [Display(Name = "Population of one race:", ShortName = "Population of one race:", Order = 79)]
        public int? P0110004 { get; set; }

        [Display(Name = "White alone", ShortName = "White alone", Order = 80)]
        public int? P0110005 { get; set; }

        [Display(Name = "Black or African American alone", ShortName = "Black or African American alone", Order = 81)]
        public int? P0110006 { get; set; }

        [Display(Name = "American Indian and Alaska Native alone", ShortName = "American Indian and Alaska Native alone", Order = 82)]
        public int? P0110007 { get; set; }

        [Display(Name = "Asian alone", ShortName = "Asian alone", Order = 83)]
        public int? P0110008 { get; set; }

        [Display(Name = "Native Hawaiian and Other Pacific Islander alone", ShortName = "Native Hawaiian and Other Pacific Islander alone", Order = 84)]
        public int? P0110009 { get; set; }

        [Display(Name = "Some Other Race alone", ShortName = "Some Other Race alone", Order = 85)]
        public int? P0110010 { get; set; }

        [Display(Name = "Two or More Races:", ShortName = "Two or More Races:", Order = 86)]
        public int? P0110011 { get; set; }

        [Display(Name = "Population of two races:", ShortName = "Population of two races:", Order = 87)]
        public int? P0110012 { get; set; }

        [Display(Name = "White; Black or African American", ShortName = "White; Black or African American", Order = 88)]
        public int? P0110013 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native", ShortName = "White; American Indian and Alaska Native", Order = 89)]
        public int? P0110014 { get; set; }

        [Display(Name = "White; Asian", ShortName = "White; Asian", Order = 90)]
        public int? P0110015 { get; set; }

        [Display(Name = "White; Native Hawaiian and Other Pacific Islander", ShortName = "White; Native Hawaiian and Other Pacific Islander", Order = 91)]
        public int? P0110016 { get; set; }

        [Display(Name = "White; Some Other Race", ShortName = "White; Some Other Race", Order = 92)]
        public int? P0110017 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native", ShortName = "Black or African American; American Indian and Alaska Native", Order = 93)]
        public int? P0110018 { get; set; }

        [Display(Name = "Black or African American; Asian", ShortName = "Black or African American; Asian", Order = 94)]
        public int? P0110019 { get; set; }

        [Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander", Order = 95)]
        public int? P0110020 { get; set; }

        [Display(Name = "Black or African American; Some Other Race", ShortName = "Black or African American; Some Other Race", Order = 96)]
        public int? P0110021 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Asian", ShortName = "American Indian and Alaska Native; Asian", Order = 97)]
        public int? P0110022 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 98)]
        public int? P0110023 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Some Other Race", ShortName = "American Indian and Alaska Native; Some Other Race", Order = 99)]
        public int? P0110024 { get; set; }

        [Display(Name = "Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Asian; Native Hawaiian and Other Pacific Islander", Order = 100)]
        public int? P0110025 { get; set; }

        [Display(Name = "Asian; Some Other Race", ShortName = "Asian; Some Other Race", Order = 101)]
        public int? P0110026 { get; set; }

        [Display(Name = "Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 102)]
        public int? P0110027 { get; set; }

        [Display(Name = "Population of three races:", ShortName = "Population of three races:", Order = 103)]
        public int? P0110028 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native", ShortName = "White; Black or African American; American Indian and Alaska Native", Order = 104)]
        public int? P0110029 { get; set; }

        [Display(Name = "White; Black or African American; Asian", ShortName = "White; Black or African American; Asian", Order = 105)]
        public int? P0110030 { get; set; }

        [Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander", Order = 106)]
        public int? P0110031 { get; set; }

        [Display(Name = "White; Black or African American; Some Other Race", ShortName = "White; Black or African American; Some Other Race", Order = 107)]
        public int? P0110032 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Asian", ShortName = "White; American Indian and Alaska Native; Asian", Order = 108)]
        public int? P0110033 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 109)]
        public int? P0110034 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Some Other Race", ShortName = "White; American Indian and Alaska Native; Some Other Race", Order = 110)]
        public int? P0110035 { get; set; }

        [Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander", Order = 111)]
        public int? P0110036 { get; set; }

        [Display(Name = "White; Asian; Some Other Race", ShortName = "White; Asian; Some Other Race", Order = 112)]
        public int? P0110037 { get; set; }

        [Display(Name = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 113)]
        public int? P0110038 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian", ShortName = "Black or African American; American Indian and Alaska Native; Asian", Order = 114)]
        public int? P0110039 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 115)]
        public int? P0110040 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Some Other Race", Order = 116)]
        public int? P0110041 { get; set; }

        [Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 117)]
        public int? P0110042 { get; set; }

        [Display(Name = "Black or African American; Asian; Some Other Race", ShortName = "Black or African American; Asian; Some Other Race", Order = 118)]
        public int? P0110043 { get; set; }

        [Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 119)]
        public int? P0110044 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 120)]
        public int? P0110045 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Asian; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Some Other Race", Order = 121)]
        public int? P0110046 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 122)]
        public int? P0110047 { get; set; }

        [Display(Name = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 123)]
        public int? P0110048 { get; set; }

        [Display(Name = "Population of four races:", ShortName = "Population of four races:", Order = 124)]
        public int? P0110049 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian", Order = 125)]
        public int? P0110050 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 126)]
        public int? P0110051 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Some Other Race", Order = 127)]
        public int? P0110052 { get; set; }

        [Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 128)]
        public int? P0110053 { get; set; }

        [Display(Name = "White; Black or African American; Asian; Some Other Race", ShortName = "White; Black or African American; Asian; Some Other Race", Order = 129)]
        public int? P0110054 { get; set; }

        [Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 130)]
        public int? P0110055 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 131)]
        public int? P0110056 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Some Other Race", Order = 132)]
        public int? P0110057 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 133)]
        public int? P0110058 { get; set; }

        [Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 134)]
        public int? P0110059 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 135)]
        public int? P0110060 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 136)]
        public int? P0110061 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 137)]
        public int? P0110062 { get; set; }

        [Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 138)]
        public int? P0110063 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 139)]
        public int? P0110064 { get; set; }

        [Display(Name = "Population of five races:", ShortName = "Population of five races:", Order = 140)]
        public int? P0110065 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 141)]
        public int? P0110066 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 142)]
        public int? P0110067 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 143)]
        public int? P0110068 { get; set; }

        [Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 144)]
        public int? P0110069 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 145)]
        public int? P0110070 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 146)]
        public int? P0110071 { get; set; }

        [Display(Name = "Population of six races:", ShortName = "Population of six races:", Order = 147)]
        public int? P0110072 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 148)]
        public int? P0110073 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 149)]
        public int? P0120001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 150)]
        public int? P0120002 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 151)]
        public int? P0120003 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 152)]
        public int? P0120004 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 153)]
        public int? P0120005 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 154)]
        public int? P0120006 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 155)]
        public int? P0120007 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 156)]
        public int? P0120008 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 157)]
        public int? P0120009 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 158)]
        public int? P0120010 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 159)]
        public int? P0120011 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 160)]
        public int? P0120012 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 161)]
        public int? P0120013 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 162)]
        public int? P0120014 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 163)]
        public int? P0120015 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 164)]
        public int? P0120016 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 165)]
        public int? P0120017 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 166)]
        public int? P0120018 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 167)]
        public int? P0120019 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 168)]
        public int? P0120020 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 169)]
        public int? P0120021 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 170)]
        public int? P0120022 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 171)]
        public int? P0120023 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 172)]
        public int? P0120024 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 173)]
        public int? P0120025 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 174)]
        public int? P0120026 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 175)]
        public int? P0120027 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 176)]
        public int? P0120028 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 177)]
        public int? P0120029 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 178)]
        public int? P0120030 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 179)]
        public int? P0120031 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 180)]
        public int? P0120032 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 181)]
        public int? P0120033 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 182)]
        public int? P0120034 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 183)]
        public int? P0120035 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 184)]
        public int? P0120036 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 185)]
        public int? P0120037 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 186)]
        public int? P0120038 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 187)]
        public int? P0120039 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 188)]
        public int? P0120040 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 189)]
        public int? P0120041 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 190)]
        public int? P0120042 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 191)]
        public int? P0120043 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 192)]
        public int? P0120044 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 193)]
        public int? P0120045 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 194)]
        public int? P0120046 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 195)]
        public int? P0120047 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 196)]
        public int? P0120048 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 197)]
        public int? P0120049 { get; set; }

        [Display(Name = "Both sexes", ShortName = "Both sexes", Order = 198)]
        public double? P0130001 { get; set; }

        [Display(Name = "Male", ShortName = "Male", Order = 199)]
        public double? P0130002 { get; set; }

        [Display(Name = "Female", ShortName = "Female", Order = 200)]
        public double? P0130003 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 201)]
        public int? P0140001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 202)]
        public int? P0140002 { get; set; }

        [Display(Name = "Under 1 year", ShortName = "Under 1 year", Order = 203)]
        public int? P0140003 { get; set; }

        [Display(Name = "1 year", ShortName = "1 year", Order = 204)]
        public int? P0140004 { get; set; }

        [Display(Name = "2 years", ShortName = "2 years", Order = 205)]
        public int? P0140005 { get; set; }

        [Display(Name = "3 years", ShortName = "3 years", Order = 206)]
        public int? P0140006 { get; set; }

        [Display(Name = "4 years", ShortName = "4 years", Order = 207)]
        public int? P0140007 { get; set; }

        [Display(Name = "5 years", ShortName = "5 years", Order = 208)]
        public int? P0140008 { get; set; }

        [Display(Name = "6 years", ShortName = "6 years", Order = 209)]
        public int? P0140009 { get; set; }

        [Display(Name = "7 years", ShortName = "7 years", Order = 210)]
        public int? P0140010 { get; set; }

        [Display(Name = "8 years", ShortName = "8 years", Order = 211)]
        public int? P0140011 { get; set; }

        [Display(Name = "9 years", ShortName = "9 years", Order = 212)]
        public int? P0140012 { get; set; }

        [Display(Name = "10 years", ShortName = "10 years", Order = 213)]
        public int? P0140013 { get; set; }

        [Display(Name = "11 years", ShortName = "11 years", Order = 214)]
        public int? P0140014 { get; set; }

        [Display(Name = "12 years", ShortName = "12 years", Order = 215)]
        public int? P0140015 { get; set; }

        [Display(Name = "13 years", ShortName = "13 years", Order = 216)]
        public int? P0140016 { get; set; }

        [Display(Name = "14 years", ShortName = "14 years", Order = 217)]
        public int? P0140017 { get; set; }

        [Display(Name = "15 years", ShortName = "15 years", Order = 218)]
        public int? P0140018 { get; set; }

        [Display(Name = "16 years", ShortName = "16 years", Order = 219)]
        public int? P0140019 { get; set; }

        [Display(Name = "17 years", ShortName = "17 years", Order = 220)]
        public int? P0140020 { get; set; }

        [Display(Name = "18 years", ShortName = "18 years", Order = 221)]
        public int? P0140021 { get; set; }

        [Display(Name = "19 years", ShortName = "19 years", Order = 222)]
        public int? P0140022 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 223)]
        public int? P0140023 { get; set; }

        [Display(Name = "Under 1 year", ShortName = "Under 1 year", Order = 224)]
        public int? P0140024 { get; set; }

        [Display(Name = "1 year", ShortName = "1 year", Order = 225)]
        public int? P0140025 { get; set; }

        [Display(Name = "2 years", ShortName = "2 years", Order = 226)]
        public int? P0140026 { get; set; }

        [Display(Name = "3 years", ShortName = "3 years", Order = 227)]
        public int? P0140027 { get; set; }

        [Display(Name = "4 years", ShortName = "4 years", Order = 228)]
        public int? P0140028 { get; set; }

        [Display(Name = "5 years", ShortName = "5 years", Order = 229)]
        public int? P0140029 { get; set; }

        [Display(Name = "6 years", ShortName = "6 years", Order = 230)]
        public int? P0140030 { get; set; }

        [Display(Name = "7 years", ShortName = "7 years", Order = 231)]
        public int? P0140031 { get; set; }

        [Display(Name = "8 years", ShortName = "8 years", Order = 232)]
        public int? P0140032 { get; set; }

        [Display(Name = "9 years", ShortName = "9 years", Order = 233)]
        public int? P0140033 { get; set; }

        [Display(Name = "10 years", ShortName = "10 years", Order = 234)]
        public int? P0140034 { get; set; }

        [Display(Name = "11 years", ShortName = "11 years", Order = 235)]
        public int? P0140035 { get; set; }

        [Display(Name = "12 years", ShortName = "12 years", Order = 236)]
        public int? P0140036 { get; set; }

        [Display(Name = "13 years", ShortName = "13 years", Order = 237)]
        public int? P0140037 { get; set; }

        [Display(Name = "14 years", ShortName = "14 years", Order = 238)]
        public int? P0140038 { get; set; }

        [Display(Name = "15 years", ShortName = "15 years", Order = 239)]
        public int? P0140039 { get; set; }

        [Display(Name = "16 years", ShortName = "16 years", Order = 240)]
        public int? P0140040 { get; set; }

        [Display(Name = "17 years", ShortName = "17 years", Order = 241)]
        public int? P0140041 { get; set; }

        [Display(Name = "18 years", ShortName = "18 years", Order = 242)]
        public int? P0140042 { get; set; }

        [Display(Name = "19 years", ShortName = "19 years", Order = 243)]
        public int? P0140043 { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}
