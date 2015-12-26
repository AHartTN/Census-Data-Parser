#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 4:11 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1_00003.cs
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

    public class SF1_00003
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
        public int? P0030001 { get; set; }

        [Display(Name = "Population of one race:", ShortName = "Population of one race:", Order = 6)]
        public int? P0030002 { get; set; }

        [Display(Name = "White alone", ShortName = "White alone", Order = 7)]
        public int? P0030003 { get; set; }

        [Display(Name = "Black or African American alone", ShortName = "Black or African American alone", Order = 8)]
        public int? P0030004 { get; set; }

        [Display(Name = "American Indian and Alaska Native alone", ShortName = "American Indian and Alaska Native alone", Order = 9)]
        public int? P0030005 { get; set; }

        [Display(Name = "Asian alone", ShortName = "Asian alone", Order = 10)]
        public int? P0030006 { get; set; }

        [Display(Name = "Native Hawaiian and Other Pacific Islander alone", ShortName = "Native Hawaiian and Other Pacific Islander alone", Order = 11)]
        public int? P0030007 { get; set; }

        [Display(Name = "Some Other Race alone", ShortName = "Some Other Race alone", Order = 12)]
        public int? P0030008 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 13)]
        public int? P0040001 { get; set; }

        [Display(Name = "Hispanic or Latino", ShortName = "Hispanic or Latino", Order = 14)]
        public int? P0040002 { get; set; }

        [Display(Name = "Not Hispanic or Latino:", ShortName = "Not Hispanic or Latino:", Order = 15)]
        public int? P0040003 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 16)]
        public int? P0050001 { get; set; }

        [Display(Name = "Not Hispanic or Latino:", ShortName = "Not Hispanic or Latino:", Order = 17)]
        public int? P0050002 { get; set; }

        [Display(Name = "White alone", ShortName = "White alone", Order = 18)]
        public int? P0050003 { get; set; }

        [Display(Name = "Black or African American alone", ShortName = "Black or African American alone", Order = 19)]
        public int? P0050004 { get; set; }

        [Display(Name = "American Indian and Alaska Native alone", ShortName = "American Indian and Alaska Native alone", Order = 20)]
        public int? P0050005 { get; set; }

        [Display(Name = "Asian alone", ShortName = "Asian alone", Order = 21)]
        public int? P0050006 { get; set; }

        [Display(Name = "Native Hawaiian and Other Pacific Islander alone", ShortName = "Native Hawaiian and Other Pacific Islander alone", Order = 22)]
        public int? P0050007 { get; set; }

        [Display(Name = "Some Other Race alone", ShortName = "Some Other Race alone", Order = 23)]
        public int? P0050008 { get; set; }

        [Display(Name = "Two or More Races", ShortName = "Two or More Races", Order = 24)]
        public int? P0050009 { get; set; }

        [Display(Name = "Hispanic or Latino:", ShortName = "Hispanic or Latino:", Order = 25)]
        public int? P0050010 { get; set; }

        [Display(Name = "White alone", ShortName = "White alone", Order = 26)]
        public int? P0050011 { get; set; }

        [Display(Name = "Black or African American alone", ShortName = "Black or African American alone", Order = 27)]
        public int? P0050012 { get; set; }

        [Display(Name = "American Indian and Alaska Native alone", ShortName = "American Indian and Alaska Native alone", Order = 28)]
        public int? P0050013 { get; set; }

        [Display(Name = "Asian alone", ShortName = "Asian alone", Order = 29)]
        public int? P0050014 { get; set; }

        [Display(Name = "Native Hawaiian and Other Pacific Islander alone", ShortName = "Native Hawaiian and Other Pacific Islander alone", Order = 30)]
        public int? P0050015 { get; set; }

        [Display(Name = "Some Other Race alone", ShortName = "Some Other Race alone", Order = 31)]
        public int? P0050016 { get; set; }

        [Display(Name = "Two or More Races", ShortName = "Two or More Races", Order = 32)]
        public int? P0050017 { get; set; }

        [Display(Name = "Total races tallied:", ShortName = "Total races tallied:", Order = 33)]
        public int? P0060001 { get; set; }

        [Display(Name = "White alone or in combination with one or more other races", ShortName = "White alone or in combination with one or more other races", Order = 34)]
        public int? P0060002 { get; set; }

        [Display(Name = "Black or African American alone or in combination with one or more other races", ShortName = "Black or African American alone or in combination with one or more other races", Order = 35)]
        public int? P0060003 { get; set; }

        [Display(Name = "American Indian and Alaska Native alone or in combination with one or more other races", ShortName = "American Indian and Alaska Native alone or in combination with one or more other races", Order = 36)]
        public int? P0060004 { get; set; }

        [Display(Name = "Asian alone or in combination with one or more other races", ShortName = "Asian alone or in combination with one or more other races", Order = 37)]
        public int? P0060005 { get; set; }

        [Display(Name = "Native Hawaiian and Other Pacific Islander alone or in combination with one or more other races", ShortName = "Native Hawaiian and Other Pacific Islander alone or in combination with one or more other races", Order = 38)]
        public int? P0060006 { get; set; }

        [Display(Name = "Some Other Race alone or in combination with one or more other races", ShortName = "Some Other Race alone or in combination with one or more other races", Order = 39)]
        public int? P0060007 { get; set; }

        [Display(Name = "Total races tallied:", ShortName = "Total races tallied:", Order = 40)]
        public int? P0070001 { get; set; }

        [Display(Name = "Not Hispanic or Latino:", ShortName = "Not Hispanic or Latino:", Order = 41)]
        public int? P0070002 { get; set; }

        [Display(Name = "White alone or in combination with one or more other races", ShortName = "White alone or in combination with one or more other races", Order = 42)]
        public int? P0070003 { get; set; }

        [Display(Name = "Black or African American alone or in combination with one or more other races", ShortName = "Black or African American alone or in combination with one or more other races", Order = 43)]
        public int? P0070004 { get; set; }

        [Display(Name = "American Indian and Alaska Native alone or in combination with one or more other races", ShortName = "American Indian and Alaska Native alone or in combination with one or more other races", Order = 44)]
        public int? P0070005 { get; set; }

        [Display(Name = "Asian alone or in combination with one or more other races", ShortName = "Asian alone or in combination with one or more other races", Order = 45)]
        public int? P0070006 { get; set; }

        [Display(Name = "Native Hawaiian and Other Pacific Islander alone or in combination with one or more other races", ShortName = "Native Hawaiian and Other Pacific Islander alone or in combination with one or more other races", Order = 46)]
        public int? P0070007 { get; set; }

        [Display(Name = "Some Other Race alone or in combination with one or more other races", ShortName = "Some Other Race alone or in combination with one or more other races", Order = 47)]
        public int? P0070008 { get; set; }

        [Display(Name = "Hispanic or Latino:", ShortName = "Hispanic or Latino:", Order = 48)]
        public int? P0070009 { get; set; }

        [Display(Name = "White alone or in combination with one or more other races", ShortName = "White alone or in combination with one or more other races", Order = 49)]
        public int? P0070010 { get; set; }

        [Display(Name = "Black or African American alone or in combination with one or more other races", ShortName = "Black or African American alone or in combination with one or more other races", Order = 50)]
        public int? P0070011 { get; set; }

        [Display(Name = "American Indian and Alaska Native alone or in combination with one or more other races", ShortName = "American Indian and Alaska Native alone or in combination with one or more other races", Order = 51)]
        public int? P0070012 { get; set; }

        [Display(Name = "Asian alone or in combination with one or more other races", ShortName = "Asian alone or in combination with one or more other races", Order = 52)]
        public int? P0070013 { get; set; }

        [Display(Name = "Native Hawaiian and Other Pacific Islander alone or in combination with one or more other races", ShortName = "Native Hawaiian and Other Pacific Islander alone or in combination with one or more other races", Order = 53)]
        public int? P0070014 { get; set; }

        [Display(Name = "Some Other Race alone or in combination with one or more other races", ShortName = "Some Other Race alone or in combination with one or more other races", Order = 54)]
        public int? P0070015 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 55)]
        public int? P0080001 { get; set; }

        [Display(Name = "Population of one race:", ShortName = "Population of one race:", Order = 56)]
        public int? P0080002 { get; set; }

        [Display(Name = "White alone", ShortName = "White alone", Order = 57)]
        public int? P0080003 { get; set; }

        [Display(Name = "Black or African American alone", ShortName = "Black or African American alone", Order = 58)]
        public int? P0080004 { get; set; }

        [Display(Name = "American Indian and Alaska Native alone", ShortName = "American Indian and Alaska Native alone", Order = 59)]
        public int? P0080005 { get; set; }

        [Display(Name = "Asian alone", ShortName = "Asian alone", Order = 60)]
        public int? P0080006 { get; set; }

        [Display(Name = "Native Hawaiian and Other Pacific Islander alone", ShortName = "Native Hawaiian and Other Pacific Islander alone", Order = 61)]
        public int? P0080007 { get; set; }

        [Display(Name = "Some Other Race alone", ShortName = "Some Other Race alone", Order = 62)]
        public int? P0080008 { get; set; }

        [Display(Name = "Two or More Races:", ShortName = "Two or More Races:", Order = 63)]
        public int? P0080009 { get; set; }

        [Display(Name = "Population of two races:", ShortName = "Population of two races:", Order = 64)]
        public int? P0080010 { get; set; }

        [Display(Name = "White; Black or African American", ShortName = "White; Black or African American", Order = 65)]
        public int? P0080011 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native", ShortName = "White; American Indian and Alaska Native", Order = 66)]
        public int? P0080012 { get; set; }

        [Display(Name = "White; Asian", ShortName = "White; Asian", Order = 67)]
        public int? P0080013 { get; set; }

        [Display(Name = "White; Native Hawaiian and Other Pacific Islander", ShortName = "White; Native Hawaiian and Other Pacific Islander", Order = 68)]
        public int? P0080014 { get; set; }

        [Display(Name = "White; Some Other Race", ShortName = "White; Some Other Race", Order = 69)]
        public int? P0080015 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native", ShortName = "Black or African American; American Indian and Alaska Native", Order = 70)]
        public int? P0080016 { get; set; }

        [Display(Name = "Black or African American; Asian", ShortName = "Black or African American; Asian", Order = 71)]
        public int? P0080017 { get; set; }

        [Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander", Order = 72)]
        public int? P0080018 { get; set; }

        [Display(Name = "Black or African American; Some Other Race", ShortName = "Black or African American; Some Other Race", Order = 73)]
        public int? P0080019 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Asian", ShortName = "American Indian and Alaska Native; Asian", Order = 74)]
        public int? P0080020 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 75)]
        public int? P0080021 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Some Other Race", ShortName = "American Indian and Alaska Native; Some Other Race", Order = 76)]
        public int? P0080022 { get; set; }

        [Display(Name = "Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Asian; Native Hawaiian and Other Pacific Islander", Order = 77)]
        public int? P0080023 { get; set; }

        [Display(Name = "Asian; Some Other Race", ShortName = "Asian; Some Other Race", Order = 78)]
        public int? P0080024 { get; set; }

        [Display(Name = "Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 79)]
        public int? P0080025 { get; set; }

        [Display(Name = "Population of three races:", ShortName = "Population of three races:", Order = 80)]
        public int? P0080026 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native", ShortName = "White; Black or African American; American Indian and Alaska Native", Order = 81)]
        public int? P0080027 { get; set; }

        [Display(Name = "White; Black or African American; Asian", ShortName = "White; Black or African American; Asian", Order = 82)]
        public int? P0080028 { get; set; }

        [Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander", Order = 83)]
        public int? P0080029 { get; set; }

        [Display(Name = "White; Black or African American; Some Other Race", ShortName = "White; Black or African American; Some Other Race", Order = 84)]
        public int? P0080030 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Asian", ShortName = "White; American Indian and Alaska Native; Asian", Order = 85)]
        public int? P0080031 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 86)]
        public int? P0080032 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Some Other Race", ShortName = "White; American Indian and Alaska Native; Some Other Race", Order = 87)]
        public int? P0080033 { get; set; }

        [Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander", Order = 88)]
        public int? P0080034 { get; set; }

        [Display(Name = "White; Asian; Some Other Race", ShortName = "White; Asian; Some Other Race", Order = 89)]
        public int? P0080035 { get; set; }

        [Display(Name = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 90)]
        public int? P0080036 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian", ShortName = "Black or African American; American Indian and Alaska Native; Asian", Order = 91)]
        public int? P0080037 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 92)]
        public int? P0080038 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Some Other Race", Order = 93)]
        public int? P0080039 { get; set; }

        [Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 94)]
        public int? P0080040 { get; set; }

        [Display(Name = "Black or African American; Asian; Some Other Race", ShortName = "Black or African American; Asian; Some Other Race", Order = 95)]
        public int? P0080041 { get; set; }

        [Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 96)]
        public int? P0080042 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 97)]
        public int? P0080043 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Asian; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Some Other Race", Order = 98)]
        public int? P0080044 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 99)]
        public int? P0080045 { get; set; }

        [Display(Name = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 100)]
        public int? P0080046 { get; set; }

        [Display(Name = "Population of four races:", ShortName = "Population of four races:", Order = 101)]
        public int? P0080047 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian", Order = 102)]
        public int? P0080048 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 103)]
        public int? P0080049 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Some Other Race", Order = 104)]
        public int? P0080050 { get; set; }

        [Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 105)]
        public int? P0080051 { get; set; }

        [Display(Name = "White; Black or African American; Asian; Some Other Race", ShortName = "White; Black or African American; Asian; Some Other Race", Order = 106)]
        public int? P0080052 { get; set; }

        [Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 107)]
        public int? P0080053 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 108)]
        public int? P0080054 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Some Other Race", Order = 109)]
        public int? P0080055 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 110)]
        public int? P0080056 { get; set; }

        [Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 111)]
        public int? P0080057 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 112)]
        public int? P0080058 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 113)]
        public int? P0080059 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 114)]
        public int? P0080060 { get; set; }

        [Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 115)]
        public int? P0080061 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 116)]
        public int? P0080062 { get; set; }

        [Display(Name = "Population of five races:", ShortName = "Population of five races:", Order = 117)]
        public int? P0080063 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 118)]
        public int? P0080064 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 119)]
        public int? P0080065 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 120)]
        public int? P0080066 { get; set; }

        [Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 121)]
        public int? P0080067 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 122)]
        public int? P0080068 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 123)]
        public int? P0080069 { get; set; }

        [Display(Name = "Population of six races:", ShortName = "Population of six races:", Order = 124)]
        public int? P0080070 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 125)]
        public int? P0080071 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 126)]
        public int? P0090001 { get; set; }

        [Display(Name = "Hispanic or Latino", ShortName = "Hispanic or Latino", Order = 127)]
        public int? P0090002 { get; set; }

        [Display(Name = "Not Hispanic or Latino:", ShortName = "Not Hispanic or Latino:", Order = 128)]
        public int? P0090003 { get; set; }

        [Display(Name = "Population of one race:", ShortName = "Population of one race:", Order = 129)]
        public int? P0090004 { get; set; }

        [Display(Name = "White alone", ShortName = "White alone", Order = 130)]
        public int? P0090005 { get; set; }

        [Display(Name = "Black or African American alone", ShortName = "Black or African American alone", Order = 131)]
        public int? P0090006 { get; set; }

        [Display(Name = "American Indian and Alaska Native alone", ShortName = "American Indian and Alaska Native alone", Order = 132)]
        public int? P0090007 { get; set; }

        [Display(Name = "Asian alone", ShortName = "Asian alone", Order = 133)]
        public int? P0090008 { get; set; }

        [Display(Name = "Native Hawaiian and Other Pacific Islander alone", ShortName = "Native Hawaiian and Other Pacific Islander alone", Order = 134)]
        public int? P0090009 { get; set; }

        [Display(Name = "Some Other Race alone", ShortName = "Some Other Race alone", Order = 135)]
        public int? P0090010 { get; set; }

        [Display(Name = "Two or More Races:", ShortName = "Two or More Races:", Order = 136)]
        public int? P0090011 { get; set; }

        [Display(Name = "Population of two races:", ShortName = "Population of two races:", Order = 137)]
        public int? P0090012 { get; set; }

        [Display(Name = "White; Black or African American", ShortName = "White; Black or African American", Order = 138)]
        public int? P0090013 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native", ShortName = "White; American Indian and Alaska Native", Order = 139)]
        public int? P0090014 { get; set; }

        [Display(Name = "White; Asian", ShortName = "White; Asian", Order = 140)]
        public int? P0090015 { get; set; }

        [Display(Name = "White; Native Hawaiian and Other Pacific Islander", ShortName = "White; Native Hawaiian and Other Pacific Islander", Order = 141)]
        public int? P0090016 { get; set; }

        [Display(Name = "White; Some Other Race", ShortName = "White; Some Other Race", Order = 142)]
        public int? P0090017 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native", ShortName = "Black or African American; American Indian and Alaska Native", Order = 143)]
        public int? P0090018 { get; set; }

        [Display(Name = "Black or African American; Asian", ShortName = "Black or African American; Asian", Order = 144)]
        public int? P0090019 { get; set; }

        [Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander", Order = 145)]
        public int? P0090020 { get; set; }

        [Display(Name = "Black or African American; Some Other Race", ShortName = "Black or African American; Some Other Race", Order = 146)]
        public int? P0090021 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Asian", ShortName = "American Indian and Alaska Native; Asian", Order = 147)]
        public int? P0090022 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 148)]
        public int? P0090023 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Some Other Race", ShortName = "American Indian and Alaska Native; Some Other Race", Order = 149)]
        public int? P0090024 { get; set; }

        [Display(Name = "Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Asian; Native Hawaiian and Other Pacific Islander", Order = 150)]
        public int? P0090025 { get; set; }

        [Display(Name = "Asian; Some Other Race", ShortName = "Asian; Some Other Race", Order = 151)]
        public int? P0090026 { get; set; }

        [Display(Name = "Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 152)]
        public int? P0090027 { get; set; }

        [Display(Name = "Population of three races:", ShortName = "Population of three races:", Order = 153)]
        public int? P0090028 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native", ShortName = "White; Black or African American; American Indian and Alaska Native", Order = 154)]
        public int? P0090029 { get; set; }

        [Display(Name = "White; Black or African American; Asian", ShortName = "White; Black or African American; Asian", Order = 155)]
        public int? P0090030 { get; set; }

        [Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander", Order = 156)]
        public int? P0090031 { get; set; }

        [Display(Name = "White; Black or African American; Some Other Race", ShortName = "White; Black or African American; Some Other Race", Order = 157)]
        public int? P0090032 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Asian", ShortName = "White; American Indian and Alaska Native; Asian", Order = 158)]
        public int? P0090033 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 159)]
        public int? P0090034 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Some Other Race", ShortName = "White; American Indian and Alaska Native; Some Other Race", Order = 160)]
        public int? P0090035 { get; set; }

        [Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander", Order = 161)]
        public int? P0090036 { get; set; }

        [Display(Name = "White; Asian; Some Other Race", ShortName = "White; Asian; Some Other Race", Order = 162)]
        public int? P0090037 { get; set; }

        [Display(Name = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 163)]
        public int? P0090038 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian", ShortName = "Black or African American; American Indian and Alaska Native; Asian", Order = 164)]
        public int? P0090039 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 165)]
        public int? P0090040 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Some Other Race", Order = 166)]
        public int? P0090041 { get; set; }

        [Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 167)]
        public int? P0090042 { get; set; }

        [Display(Name = "Black or African American; Asian; Some Other Race", ShortName = "Black or African American; Asian; Some Other Race", Order = 168)]
        public int? P0090043 { get; set; }

        [Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 169)]
        public int? P0090044 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 170)]
        public int? P0090045 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Asian; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Some Other Race", Order = 171)]
        public int? P0090046 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 172)]
        public int? P0090047 { get; set; }

        [Display(Name = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 173)]
        public int? P0090048 { get; set; }

        [Display(Name = "Population of four races:", ShortName = "Population of four races:", Order = 174)]
        public int? P0090049 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian", Order = 175)]
        public int? P0090050 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 176)]
        public int? P0090051 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Some Other Race", Order = 177)]
        public int? P0090052 { get; set; }

        [Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 178)]
        public int? P0090053 { get; set; }

        [Display(Name = "White; Black or African American; Asian; Some Other Race", ShortName = "White; Black or African American; Asian; Some Other Race", Order = 179)]
        public int? P0090054 { get; set; }

        [Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 180)]
        public int? P0090055 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 181)]
        public int? P0090056 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Some Other Race", Order = 182)]
        public int? P0090057 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 183)]
        public int? P0090058 { get; set; }

        [Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 184)]
        public int? P0090059 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 185)]
        public int? P0090060 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 186)]
        public int? P0090061 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 187)]
        public int? P0090062 { get; set; }

        [Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 188)]
        public int? P0090063 { get; set; }

        [Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 189)]
        public int? P0090064 { get; set; }

        [Display(Name = "Population of five races:", ShortName = "Population of five races:", Order = 190)]
        public int? P0090065 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 191)]
        public int? P0090066 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 192)]
        public int? P0090067 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 193)]
        public int? P0090068 { get; set; }

        [Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 194)]
        public int? P0090069 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 195)]
        public int? P0090070 { get; set; }

        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 196)]
        public int? P0090071 { get; set; }

        [Display(Name = "Population of six races:", ShortName = "Population of six races:", Order = 197)]
        public int? P0090072 { get; set; }

        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 198)]
        public int? P0090073 { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}
