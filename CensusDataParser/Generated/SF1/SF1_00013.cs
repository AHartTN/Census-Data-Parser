#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 5:32 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1_00013.cs
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

    public class SF1_00013
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
        public int? P038F001 { get; set; }

        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 6)]
        public int? P038F002 { get; set; }

        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 7)]
        public int? P038F003 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 8)]
        public int? P038F004 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 9)]
        public int? P038F005 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 10)]
        public int? P038F006 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 11)]
        public int? P038F007 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 12)]
        public int? P038F008 { get; set; }

        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 13)]
        public int? P038F009 { get; set; }

        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 14)]
        public int? P038F010 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 15)]
        public int? P038F011 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 16)]
        public int? P038F012 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 17)]
        public int? P038F013 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 18)]
        public int? P038F014 { get; set; }

        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 19)]
        public int? P038F015 { get; set; }

        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 20)]
        public int? P038F016 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 21)]
        public int? P038F017 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 22)]
        public int? P038F018 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 23)]
        public int? P038F019 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 24)]
        public int? P038F020 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 25)]
        public int? P038G001 { get; set; }

        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 26)]
        public int? P038G002 { get; set; }

        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 27)]
        public int? P038G003 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 28)]
        public int? P038G004 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 29)]
        public int? P038G005 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 30)]
        public int? P038G006 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 31)]
        public int? P038G007 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 32)]
        public int? P038G008 { get; set; }

        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 33)]
        public int? P038G009 { get; set; }

        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 34)]
        public int? P038G010 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 35)]
        public int? P038G011 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 36)]
        public int? P038G012 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 37)]
        public int? P038G013 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 38)]
        public int? P038G014 { get; set; }

        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 39)]
        public int? P038G015 { get; set; }

        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 40)]
        public int? P038G016 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 41)]
        public int? P038G017 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 42)]
        public int? P038G018 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 43)]
        public int? P038G019 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 44)]
        public int? P038G020 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 45)]
        public int? P038H001 { get; set; }

        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 46)]
        public int? P038H002 { get; set; }

        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 47)]
        public int? P038H003 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 48)]
        public int? P038H004 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 49)]
        public int? P038H005 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 50)]
        public int? P038H006 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 51)]
        public int? P038H007 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 52)]
        public int? P038H008 { get; set; }

        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 53)]
        public int? P038H009 { get; set; }

        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 54)]
        public int? P038H010 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 55)]
        public int? P038H011 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 56)]
        public int? P038H012 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 57)]
        public int? P038H013 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 58)]
        public int? P038H014 { get; set; }

        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 59)]
        public int? P038H015 { get; set; }

        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 60)]
        public int? P038H016 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 61)]
        public int? P038H017 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 62)]
        public int? P038H018 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 63)]
        public int? P038H019 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 64)]
        public int? P038H020 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 65)]
        public int? P038I001 { get; set; }

        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 66)]
        public int? P038I002 { get; set; }

        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 67)]
        public int? P038I003 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 68)]
        public int? P038I004 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 69)]
        public int? P038I005 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 70)]
        public int? P038I006 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 71)]
        public int? P038I007 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 72)]
        public int? P038I008 { get; set; }

        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 73)]
        public int? P038I009 { get; set; }

        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 74)]
        public int? P038I010 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 75)]
        public int? P038I011 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 76)]
        public int? P038I012 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 77)]
        public int? P038I013 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 78)]
        public int? P038I014 { get; set; }

        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 79)]
        public int? P038I015 { get; set; }

        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 80)]
        public int? P038I016 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 81)]
        public int? P038I017 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 82)]
        public int? P038I018 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 83)]
        public int? P038I019 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 84)]
        public int? P038I020 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 85)]
        public int? P039A001 { get; set; }

        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 86)]
        public int? P039A002 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 87)]
        public int? P039A003 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 88)]
        public int? P039A004 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 89)]
        public int? P039A005 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 90)]
        public int? P039A006 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 91)]
        public int? P039A007 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 92)]
        public int? P039A008 { get; set; }

        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 93)]
        public int? P039A009 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 94)]
        public int? P039A010 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 95)]
        public int? P039A011 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 96)]
        public int? P039A012 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 97)]
        public int? P039A013 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 98)]
        public int? P039A014 { get; set; }

        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 99)]
        public int? P039A015 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 100)]
        public int? P039A016 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 101)]
        public int? P039A017 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 102)]
        public int? P039A018 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 103)]
        public int? P039A019 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 104)]
        public int? P039A020 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 105)]
        public int? P039B001 { get; set; }

        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 106)]
        public int? P039B002 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 107)]
        public int? P039B003 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 108)]
        public int? P039B004 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 109)]
        public int? P039B005 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 110)]
        public int? P039B006 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 111)]
        public int? P039B007 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 112)]
        public int? P039B008 { get; set; }

        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 113)]
        public int? P039B009 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 114)]
        public int? P039B010 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 115)]
        public int? P039B011 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 116)]
        public int? P039B012 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 117)]
        public int? P039B013 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 118)]
        public int? P039B014 { get; set; }

        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 119)]
        public int? P039B015 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 120)]
        public int? P039B016 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 121)]
        public int? P039B017 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 122)]
        public int? P039B018 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 123)]
        public int? P039B019 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 124)]
        public int? P039B020 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 125)]
        public int? P039C001 { get; set; }

        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 126)]
        public int? P039C002 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 127)]
        public int? P039C003 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 128)]
        public int? P039C004 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 129)]
        public int? P039C005 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 130)]
        public int? P039C006 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 131)]
        public int? P039C007 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 132)]
        public int? P039C008 { get; set; }

        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 133)]
        public int? P039C009 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 134)]
        public int? P039C010 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 135)]
        public int? P039C011 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 136)]
        public int? P039C012 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 137)]
        public int? P039C013 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 138)]
        public int? P039C014 { get; set; }

        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 139)]
        public int? P039C015 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 140)]
        public int? P039C016 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 141)]
        public int? P039C017 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 142)]
        public int? P039C018 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 143)]
        public int? P039C019 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 144)]
        public int? P039C020 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 145)]
        public int? P039D001 { get; set; }

        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 146)]
        public int? P039D002 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 147)]
        public int? P039D003 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 148)]
        public int? P039D004 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 149)]
        public int? P039D005 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 150)]
        public int? P039D006 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 151)]
        public int? P039D007 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 152)]
        public int? P039D008 { get; set; }

        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 153)]
        public int? P039D009 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 154)]
        public int? P039D010 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 155)]
        public int? P039D011 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 156)]
        public int? P039D012 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 157)]
        public int? P039D013 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 158)]
        public int? P039D014 { get; set; }

        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 159)]
        public int? P039D015 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 160)]
        public int? P039D016 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 161)]
        public int? P039D017 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 162)]
        public int? P039D018 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 163)]
        public int? P039D019 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 164)]
        public int? P039D020 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 165)]
        public int? P039E001 { get; set; }

        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 166)]
        public int? P039E002 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 167)]
        public int? P039E003 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 168)]
        public int? P039E004 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 169)]
        public int? P039E005 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 170)]
        public int? P039E006 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 171)]
        public int? P039E007 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 172)]
        public int? P039E008 { get; set; }

        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 173)]
        public int? P039E009 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 174)]
        public int? P039E010 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 175)]
        public int? P039E011 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 176)]
        public int? P039E012 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 177)]
        public int? P039E013 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 178)]
        public int? P039E014 { get; set; }

        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 179)]
        public int? P039E015 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 180)]
        public int? P039E016 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 181)]
        public int? P039E017 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 182)]
        public int? P039E018 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 183)]
        public int? P039E019 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 184)]
        public int? P039E020 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 185)]
        public int? P039F001 { get; set; }

        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 186)]
        public int? P039F002 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 187)]
        public int? P039F003 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 188)]
        public int? P039F004 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 189)]
        public int? P039F005 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 190)]
        public int? P039F006 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 191)]
        public int? P039F007 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 192)]
        public int? P039F008 { get; set; }

        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 193)]
        public int? P039F009 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 194)]
        public int? P039F010 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 195)]
        public int? P039F011 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 196)]
        public int? P039F012 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 197)]
        public int? P039F013 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 198)]
        public int? P039F014 { get; set; }

        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 199)]
        public int? P039F015 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 200)]
        public int? P039F016 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 201)]
        public int? P039F017 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 202)]
        public int? P039F018 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 203)]
        public int? P039F019 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 204)]
        public int? P039F020 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 205)]
        public int? P039G001 { get; set; }

        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 206)]
        public int? P039G002 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 207)]
        public int? P039G003 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 208)]
        public int? P039G004 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 209)]
        public int? P039G005 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 210)]
        public int? P039G006 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 211)]
        public int? P039G007 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 212)]
        public int? P039G008 { get; set; }

        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 213)]
        public int? P039G009 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 214)]
        public int? P039G010 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 215)]
        public int? P039G011 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 216)]
        public int? P039G012 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 217)]
        public int? P039G013 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 218)]
        public int? P039G014 { get; set; }

        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 219)]
        public int? P039G015 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 220)]
        public int? P039G016 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 221)]
        public int? P039G017 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 222)]
        public int? P039G018 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 223)]
        public int? P039G019 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 224)]
        public int? P039G020 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 225)]
        public int? P039H001 { get; set; }

        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 226)]
        public int? P039H002 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 227)]
        public int? P039H003 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 228)]
        public int? P039H004 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 229)]
        public int? P039H005 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 230)]
        public int? P039H006 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 231)]
        public int? P039H007 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 232)]
        public int? P039H008 { get; set; }

        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 233)]
        public int? P039H009 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 234)]
        public int? P039H010 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 235)]
        public int? P039H011 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 236)]
        public int? P039H012 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 237)]
        public int? P039H013 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 238)]
        public int? P039H014 { get; set; }

        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 239)]
        public int? P039H015 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 240)]
        public int? P039H016 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 241)]
        public int? P039H017 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 242)]
        public int? P039H018 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 243)]
        public int? P039H019 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 244)]
        public int? P039H020 { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}
