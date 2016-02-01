#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1CongressionalDistricts113_SF1_00003.cs
// 
// Anthony Hart ("ANTHONY") CONFIDENTIAL
// 
// Unpublished Copyright (c) 1985-2016 Anthony Hart, All Rights Reserved.
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

namespace CensusDataParser.Generated.Binding
{
    #region Using Directives
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.OleDb;
    using Models;
    #endregion

    public class SF1CongressionalDistricts113_SF1_00003 : BaseModel
    {
        #region Properties
        [Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
        public string FILEID { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }

        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
        public string CHARITER { get; set; }

        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
        public string CIFSN { get; set; }

        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
        public int LOGRECNO { get; set; }

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
        #endregion Properties

        #region Constructors
        public SF1CongressionalDistricts113_SF1_00003() { }

        public SF1CongressionalDistricts113_SF1_00003(string csvLine) : base(csvLine) { }

        public SF1CongressionalDistricts113_SF1_00003(string[] values) : base(values) { }

        public SF1CongressionalDistricts113_SF1_00003(OleDbDataReader reader)
        {
            if (reader[0] != DBNull.Value)
            {
                FILEID = (string)reader[0];
            }
            if (reader[1] != DBNull.Value)
            {
                STUSAB = (string)reader[1];
            }
            if (reader[2] != DBNull.Value)
            {
                CHARITER = (string)reader[2];
            }
            if (reader[3] != DBNull.Value)
            {
                CIFSN = (string)reader[3];
            }
            if (reader[4] != DBNull.Value)
            {
                LOGRECNO = (int)reader[4];
            }
            if (reader[5] != DBNull.Value)
            {
                P0030001 = (int?)reader[5];
            }
            if (reader[6] != DBNull.Value)
            {
                P0030002 = (int?)reader[6];
            }
            if (reader[7] != DBNull.Value)
            {
                P0030003 = (int?)reader[7];
            }
            if (reader[8] != DBNull.Value)
            {
                P0030004 = (int?)reader[8];
            }
            if (reader[9] != DBNull.Value)
            {
                P0030005 = (int?)reader[9];
            }
            if (reader[10] != DBNull.Value)
            {
                P0030006 = (int?)reader[10];
            }
            if (reader[11] != DBNull.Value)
            {
                P0030007 = (int?)reader[11];
            }
            if (reader[12] != DBNull.Value)
            {
                P0030008 = (int?)reader[12];
            }
            if (reader[13] != DBNull.Value)
            {
                P0040001 = (int?)reader[13];
            }
            if (reader[14] != DBNull.Value)
            {
                P0040002 = (int?)reader[14];
            }
            if (reader[15] != DBNull.Value)
            {
                P0040003 = (int?)reader[15];
            }
            if (reader[16] != DBNull.Value)
            {
                P0050001 = (int?)reader[16];
            }
            if (reader[17] != DBNull.Value)
            {
                P0050002 = (int?)reader[17];
            }
            if (reader[18] != DBNull.Value)
            {
                P0050003 = (int?)reader[18];
            }
            if (reader[19] != DBNull.Value)
            {
                P0050004 = (int?)reader[19];
            }
            if (reader[20] != DBNull.Value)
            {
                P0050005 = (int?)reader[20];
            }
            if (reader[21] != DBNull.Value)
            {
                P0050006 = (int?)reader[21];
            }
            if (reader[22] != DBNull.Value)
            {
                P0050007 = (int?)reader[22];
            }
            if (reader[23] != DBNull.Value)
            {
                P0050008 = (int?)reader[23];
            }
            if (reader[24] != DBNull.Value)
            {
                P0050009 = (int?)reader[24];
            }
            if (reader[25] != DBNull.Value)
            {
                P0050010 = (int?)reader[25];
            }
            if (reader[26] != DBNull.Value)
            {
                P0050011 = (int?)reader[26];
            }
            if (reader[27] != DBNull.Value)
            {
                P0050012 = (int?)reader[27];
            }
            if (reader[28] != DBNull.Value)
            {
                P0050013 = (int?)reader[28];
            }
            if (reader[29] != DBNull.Value)
            {
                P0050014 = (int?)reader[29];
            }
            if (reader[30] != DBNull.Value)
            {
                P0050015 = (int?)reader[30];
            }
            if (reader[31] != DBNull.Value)
            {
                P0050016 = (int?)reader[31];
            }
            if (reader[32] != DBNull.Value)
            {
                P0050017 = (int?)reader[32];
            }
            if (reader[33] != DBNull.Value)
            {
                P0060001 = (int?)reader[33];
            }
            if (reader[34] != DBNull.Value)
            {
                P0060002 = (int?)reader[34];
            }
            if (reader[35] != DBNull.Value)
            {
                P0060003 = (int?)reader[35];
            }
            if (reader[36] != DBNull.Value)
            {
                P0060004 = (int?)reader[36];
            }
            if (reader[37] != DBNull.Value)
            {
                P0060005 = (int?)reader[37];
            }
            if (reader[38] != DBNull.Value)
            {
                P0060006 = (int?)reader[38];
            }
            if (reader[39] != DBNull.Value)
            {
                P0060007 = (int?)reader[39];
            }
            if (reader[40] != DBNull.Value)
            {
                P0070001 = (int?)reader[40];
            }
            if (reader[41] != DBNull.Value)
            {
                P0070002 = (int?)reader[41];
            }
            if (reader[42] != DBNull.Value)
            {
                P0070003 = (int?)reader[42];
            }
            if (reader[43] != DBNull.Value)
            {
                P0070004 = (int?)reader[43];
            }
            if (reader[44] != DBNull.Value)
            {
                P0070005 = (int?)reader[44];
            }
            if (reader[45] != DBNull.Value)
            {
                P0070006 = (int?)reader[45];
            }
            if (reader[46] != DBNull.Value)
            {
                P0070007 = (int?)reader[46];
            }
            if (reader[47] != DBNull.Value)
            {
                P0070008 = (int?)reader[47];
            }
            if (reader[48] != DBNull.Value)
            {
                P0070009 = (int?)reader[48];
            }
            if (reader[49] != DBNull.Value)
            {
                P0070010 = (int?)reader[49];
            }
            if (reader[50] != DBNull.Value)
            {
                P0070011 = (int?)reader[50];
            }
            if (reader[51] != DBNull.Value)
            {
                P0070012 = (int?)reader[51];
            }
            if (reader[52] != DBNull.Value)
            {
                P0070013 = (int?)reader[52];
            }
            if (reader[53] != DBNull.Value)
            {
                P0070014 = (int?)reader[53];
            }
            if (reader[54] != DBNull.Value)
            {
                P0070015 = (int?)reader[54];
            }
            if (reader[55] != DBNull.Value)
            {
                P0080001 = (int?)reader[55];
            }
            if (reader[56] != DBNull.Value)
            {
                P0080002 = (int?)reader[56];
            }
            if (reader[57] != DBNull.Value)
            {
                P0080003 = (int?)reader[57];
            }
            if (reader[58] != DBNull.Value)
            {
                P0080004 = (int?)reader[58];
            }
            if (reader[59] != DBNull.Value)
            {
                P0080005 = (int?)reader[59];
            }
            if (reader[60] != DBNull.Value)
            {
                P0080006 = (int?)reader[60];
            }
            if (reader[61] != DBNull.Value)
            {
                P0080007 = (int?)reader[61];
            }
            if (reader[62] != DBNull.Value)
            {
                P0080008 = (int?)reader[62];
            }
            if (reader[63] != DBNull.Value)
            {
                P0080009 = (int?)reader[63];
            }
            if (reader[64] != DBNull.Value)
            {
                P0080010 = (int?)reader[64];
            }
            if (reader[65] != DBNull.Value)
            {
                P0080011 = (int?)reader[65];
            }
            if (reader[66] != DBNull.Value)
            {
                P0080012 = (int?)reader[66];
            }
            if (reader[67] != DBNull.Value)
            {
                P0080013 = (int?)reader[67];
            }
            if (reader[68] != DBNull.Value)
            {
                P0080014 = (int?)reader[68];
            }
            if (reader[69] != DBNull.Value)
            {
                P0080015 = (int?)reader[69];
            }
            if (reader[70] != DBNull.Value)
            {
                P0080016 = (int?)reader[70];
            }
            if (reader[71] != DBNull.Value)
            {
                P0080017 = (int?)reader[71];
            }
            if (reader[72] != DBNull.Value)
            {
                P0080018 = (int?)reader[72];
            }
            if (reader[73] != DBNull.Value)
            {
                P0080019 = (int?)reader[73];
            }
            if (reader[74] != DBNull.Value)
            {
                P0080020 = (int?)reader[74];
            }
            if (reader[75] != DBNull.Value)
            {
                P0080021 = (int?)reader[75];
            }
            if (reader[76] != DBNull.Value)
            {
                P0080022 = (int?)reader[76];
            }
            if (reader[77] != DBNull.Value)
            {
                P0080023 = (int?)reader[77];
            }
            if (reader[78] != DBNull.Value)
            {
                P0080024 = (int?)reader[78];
            }
            if (reader[79] != DBNull.Value)
            {
                P0080025 = (int?)reader[79];
            }
            if (reader[80] != DBNull.Value)
            {
                P0080026 = (int?)reader[80];
            }
            if (reader[81] != DBNull.Value)
            {
                P0080027 = (int?)reader[81];
            }
            if (reader[82] != DBNull.Value)
            {
                P0080028 = (int?)reader[82];
            }
            if (reader[83] != DBNull.Value)
            {
                P0080029 = (int?)reader[83];
            }
            if (reader[84] != DBNull.Value)
            {
                P0080030 = (int?)reader[84];
            }
            if (reader[85] != DBNull.Value)
            {
                P0080031 = (int?)reader[85];
            }
            if (reader[86] != DBNull.Value)
            {
                P0080032 = (int?)reader[86];
            }
            if (reader[87] != DBNull.Value)
            {
                P0080033 = (int?)reader[87];
            }
            if (reader[88] != DBNull.Value)
            {
                P0080034 = (int?)reader[88];
            }
            if (reader[89] != DBNull.Value)
            {
                P0080035 = (int?)reader[89];
            }
            if (reader[90] != DBNull.Value)
            {
                P0080036 = (int?)reader[90];
            }
            if (reader[91] != DBNull.Value)
            {
                P0080037 = (int?)reader[91];
            }
            if (reader[92] != DBNull.Value)
            {
                P0080038 = (int?)reader[92];
            }
            if (reader[93] != DBNull.Value)
            {
                P0080039 = (int?)reader[93];
            }
            if (reader[94] != DBNull.Value)
            {
                P0080040 = (int?)reader[94];
            }
            if (reader[95] != DBNull.Value)
            {
                P0080041 = (int?)reader[95];
            }
            if (reader[96] != DBNull.Value)
            {
                P0080042 = (int?)reader[96];
            }
            if (reader[97] != DBNull.Value)
            {
                P0080043 = (int?)reader[97];
            }
            if (reader[98] != DBNull.Value)
            {
                P0080044 = (int?)reader[98];
            }
            if (reader[99] != DBNull.Value)
            {
                P0080045 = (int?)reader[99];
            }
            if (reader[100] != DBNull.Value)
            {
                P0080046 = (int?)reader[100];
            }
            if (reader[101] != DBNull.Value)
            {
                P0080047 = (int?)reader[101];
            }
            if (reader[102] != DBNull.Value)
            {
                P0080048 = (int?)reader[102];
            }
            if (reader[103] != DBNull.Value)
            {
                P0080049 = (int?)reader[103];
            }
            if (reader[104] != DBNull.Value)
            {
                P0080050 = (int?)reader[104];
            }
            if (reader[105] != DBNull.Value)
            {
                P0080051 = (int?)reader[105];
            }
            if (reader[106] != DBNull.Value)
            {
                P0080052 = (int?)reader[106];
            }
            if (reader[107] != DBNull.Value)
            {
                P0080053 = (int?)reader[107];
            }
            if (reader[108] != DBNull.Value)
            {
                P0080054 = (int?)reader[108];
            }
            if (reader[109] != DBNull.Value)
            {
                P0080055 = (int?)reader[109];
            }
            if (reader[110] != DBNull.Value)
            {
                P0080056 = (int?)reader[110];
            }
            if (reader[111] != DBNull.Value)
            {
                P0080057 = (int?)reader[111];
            }
            if (reader[112] != DBNull.Value)
            {
                P0080058 = (int?)reader[112];
            }
            if (reader[113] != DBNull.Value)
            {
                P0080059 = (int?)reader[113];
            }
            if (reader[114] != DBNull.Value)
            {
                P0080060 = (int?)reader[114];
            }
            if (reader[115] != DBNull.Value)
            {
                P0080061 = (int?)reader[115];
            }
            if (reader[116] != DBNull.Value)
            {
                P0080062 = (int?)reader[116];
            }
            if (reader[117] != DBNull.Value)
            {
                P0080063 = (int?)reader[117];
            }
            if (reader[118] != DBNull.Value)
            {
                P0080064 = (int?)reader[118];
            }
            if (reader[119] != DBNull.Value)
            {
                P0080065 = (int?)reader[119];
            }
            if (reader[120] != DBNull.Value)
            {
                P0080066 = (int?)reader[120];
            }
            if (reader[121] != DBNull.Value)
            {
                P0080067 = (int?)reader[121];
            }
            if (reader[122] != DBNull.Value)
            {
                P0080068 = (int?)reader[122];
            }
            if (reader[123] != DBNull.Value)
            {
                P0080069 = (int?)reader[123];
            }
            if (reader[124] != DBNull.Value)
            {
                P0080070 = (int?)reader[124];
            }
            if (reader[125] != DBNull.Value)
            {
                P0080071 = (int?)reader[125];
            }
            if (reader[126] != DBNull.Value)
            {
                P0090001 = (int?)reader[126];
            }
            if (reader[127] != DBNull.Value)
            {
                P0090002 = (int?)reader[127];
            }
            if (reader[128] != DBNull.Value)
            {
                P0090003 = (int?)reader[128];
            }
            if (reader[129] != DBNull.Value)
            {
                P0090004 = (int?)reader[129];
            }
            if (reader[130] != DBNull.Value)
            {
                P0090005 = (int?)reader[130];
            }
            if (reader[131] != DBNull.Value)
            {
                P0090006 = (int?)reader[131];
            }
            if (reader[132] != DBNull.Value)
            {
                P0090007 = (int?)reader[132];
            }
            if (reader[133] != DBNull.Value)
            {
                P0090008 = (int?)reader[133];
            }
            if (reader[134] != DBNull.Value)
            {
                P0090009 = (int?)reader[134];
            }
            if (reader[135] != DBNull.Value)
            {
                P0090010 = (int?)reader[135];
            }
            if (reader[136] != DBNull.Value)
            {
                P0090011 = (int?)reader[136];
            }
            if (reader[137] != DBNull.Value)
            {
                P0090012 = (int?)reader[137];
            }
            if (reader[138] != DBNull.Value)
            {
                P0090013 = (int?)reader[138];
            }
            if (reader[139] != DBNull.Value)
            {
                P0090014 = (int?)reader[139];
            }
            if (reader[140] != DBNull.Value)
            {
                P0090015 = (int?)reader[140];
            }
            if (reader[141] != DBNull.Value)
            {
                P0090016 = (int?)reader[141];
            }
            if (reader[142] != DBNull.Value)
            {
                P0090017 = (int?)reader[142];
            }
            if (reader[143] != DBNull.Value)
            {
                P0090018 = (int?)reader[143];
            }
            if (reader[144] != DBNull.Value)
            {
                P0090019 = (int?)reader[144];
            }
            if (reader[145] != DBNull.Value)
            {
                P0090020 = (int?)reader[145];
            }
            if (reader[146] != DBNull.Value)
            {
                P0090021 = (int?)reader[146];
            }
            if (reader[147] != DBNull.Value)
            {
                P0090022 = (int?)reader[147];
            }
            if (reader[148] != DBNull.Value)
            {
                P0090023 = (int?)reader[148];
            }
            if (reader[149] != DBNull.Value)
            {
                P0090024 = (int?)reader[149];
            }
            if (reader[150] != DBNull.Value)
            {
                P0090025 = (int?)reader[150];
            }
            if (reader[151] != DBNull.Value)
            {
                P0090026 = (int?)reader[151];
            }
            if (reader[152] != DBNull.Value)
            {
                P0090027 = (int?)reader[152];
            }
            if (reader[153] != DBNull.Value)
            {
                P0090028 = (int?)reader[153];
            }
            if (reader[154] != DBNull.Value)
            {
                P0090029 = (int?)reader[154];
            }
            if (reader[155] != DBNull.Value)
            {
                P0090030 = (int?)reader[155];
            }
            if (reader[156] != DBNull.Value)
            {
                P0090031 = (int?)reader[156];
            }
            if (reader[157] != DBNull.Value)
            {
                P0090032 = (int?)reader[157];
            }
            if (reader[158] != DBNull.Value)
            {
                P0090033 = (int?)reader[158];
            }
            if (reader[159] != DBNull.Value)
            {
                P0090034 = (int?)reader[159];
            }
            if (reader[160] != DBNull.Value)
            {
                P0090035 = (int?)reader[160];
            }
            if (reader[161] != DBNull.Value)
            {
                P0090036 = (int?)reader[161];
            }
            if (reader[162] != DBNull.Value)
            {
                P0090037 = (int?)reader[162];
            }
            if (reader[163] != DBNull.Value)
            {
                P0090038 = (int?)reader[163];
            }
            if (reader[164] != DBNull.Value)
            {
                P0090039 = (int?)reader[164];
            }
            if (reader[165] != DBNull.Value)
            {
                P0090040 = (int?)reader[165];
            }
            if (reader[166] != DBNull.Value)
            {
                P0090041 = (int?)reader[166];
            }
            if (reader[167] != DBNull.Value)
            {
                P0090042 = (int?)reader[167];
            }
            if (reader[168] != DBNull.Value)
            {
                P0090043 = (int?)reader[168];
            }
            if (reader[169] != DBNull.Value)
            {
                P0090044 = (int?)reader[169];
            }
            if (reader[170] != DBNull.Value)
            {
                P0090045 = (int?)reader[170];
            }
            if (reader[171] != DBNull.Value)
            {
                P0090046 = (int?)reader[171];
            }
            if (reader[172] != DBNull.Value)
            {
                P0090047 = (int?)reader[172];
            }
            if (reader[173] != DBNull.Value)
            {
                P0090048 = (int?)reader[173];
            }
            if (reader[174] != DBNull.Value)
            {
                P0090049 = (int?)reader[174];
            }
            if (reader[175] != DBNull.Value)
            {
                P0090050 = (int?)reader[175];
            }
            if (reader[176] != DBNull.Value)
            {
                P0090051 = (int?)reader[176];
            }
            if (reader[177] != DBNull.Value)
            {
                P0090052 = (int?)reader[177];
            }
            if (reader[178] != DBNull.Value)
            {
                P0090053 = (int?)reader[178];
            }
            if (reader[179] != DBNull.Value)
            {
                P0090054 = (int?)reader[179];
            }
            if (reader[180] != DBNull.Value)
            {
                P0090055 = (int?)reader[180];
            }
            if (reader[181] != DBNull.Value)
            {
                P0090056 = (int?)reader[181];
            }
            if (reader[182] != DBNull.Value)
            {
                P0090057 = (int?)reader[182];
            }
            if (reader[183] != DBNull.Value)
            {
                P0090058 = (int?)reader[183];
            }
            if (reader[184] != DBNull.Value)
            {
                P0090059 = (int?)reader[184];
            }
            if (reader[185] != DBNull.Value)
            {
                P0090060 = (int?)reader[185];
            }
            if (reader[186] != DBNull.Value)
            {
                P0090061 = (int?)reader[186];
            }
            if (reader[187] != DBNull.Value)
            {
                P0090062 = (int?)reader[187];
            }
            if (reader[188] != DBNull.Value)
            {
                P0090063 = (int?)reader[188];
            }
            if (reader[189] != DBNull.Value)
            {
                P0090064 = (int?)reader[189];
            }
            if (reader[190] != DBNull.Value)
            {
                P0090065 = (int?)reader[190];
            }
            if (reader[191] != DBNull.Value)
            {
                P0090066 = (int?)reader[191];
            }
            if (reader[192] != DBNull.Value)
            {
                P0090067 = (int?)reader[192];
            }
            if (reader[193] != DBNull.Value)
            {
                P0090068 = (int?)reader[193];
            }
            if (reader[194] != DBNull.Value)
            {
                P0090069 = (int?)reader[194];
            }
            if (reader[195] != DBNull.Value)
            {
                P0090070 = (int?)reader[195];
            }
            if (reader[196] != DBNull.Value)
            {
                P0090071 = (int?)reader[196];
            }
            if (reader[197] != DBNull.Value)
            {
                P0090072 = (int?)reader[197];
            }
            if (reader[198] != DBNull.Value)
            {
                P0090073 = (int?)reader[198];
            }
        }
        #endregion Constructors
    }
}
