#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 4:10 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1_00011.cs
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

    public class SF1_00011
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
        public int? P031A001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 6)]
        public int? P031A002 { get; set; }

        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 7)]
        public int? P031A003 { get; set; }

        [Display(Name = "Related child:", ShortName = "Related child:", Order = 8)]
        public int? P031A004 { get; set; }

        [Display(Name = "Own child:", ShortName = "Own child:", Order = 9)]
        public int? P031A005 { get; set; }

        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 10)]
        public int? P031A006 { get; set; }

        [Display(Name = "In other family:", ShortName = "In other family:", Order = 11)]
        public int? P031A007 { get; set; }

        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 12)]
        public int? P031A008 { get; set; }

        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 13)]
        public int? P031A009 { get; set; }

        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 14)]
        public int? P031A010 { get; set; }

        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 15)]
        public int? P031A011 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 16)]
        public int? P031A012 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 17)]
        public int? P031A013 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 18)]
        public int? P031A014 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 19)]
        public int? P031A015 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 20)]
        public int? P031A016 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 21)]
        public int? P031B001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 22)]
        public int? P031B002 { get; set; }

        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 23)]
        public int? P031B003 { get; set; }

        [Display(Name = "Related child:", ShortName = "Related child:", Order = 24)]
        public int? P031B004 { get; set; }

        [Display(Name = "Own child:", ShortName = "Own child:", Order = 25)]
        public int? P031B005 { get; set; }

        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 26)]
        public int? P031B006 { get; set; }

        [Display(Name = "In other family:", ShortName = "In other family:", Order = 27)]
        public int? P031B007 { get; set; }

        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 28)]
        public int? P031B008 { get; set; }

        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 29)]
        public int? P031B009 { get; set; }

        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 30)]
        public int? P031B010 { get; set; }

        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 31)]
        public int? P031B011 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 32)]
        public int? P031B012 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 33)]
        public int? P031B013 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 34)]
        public int? P031B014 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 35)]
        public int? P031B015 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 36)]
        public int? P031B016 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 37)]
        public int? P031C001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 38)]
        public int? P031C002 { get; set; }

        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 39)]
        public int? P031C003 { get; set; }

        [Display(Name = "Related child:", ShortName = "Related child:", Order = 40)]
        public int? P031C004 { get; set; }

        [Display(Name = "Own child:", ShortName = "Own child:", Order = 41)]
        public int? P031C005 { get; set; }

        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 42)]
        public int? P031C006 { get; set; }

        [Display(Name = "In other family:", ShortName = "In other family:", Order = 43)]
        public int? P031C007 { get; set; }

        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 44)]
        public int? P031C008 { get; set; }

        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 45)]
        public int? P031C009 { get; set; }

        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 46)]
        public int? P031C010 { get; set; }

        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 47)]
        public int? P031C011 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 48)]
        public int? P031C012 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 49)]
        public int? P031C013 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 50)]
        public int? P031C014 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 51)]
        public int? P031C015 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 52)]
        public int? P031C016 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 53)]
        public int? P031D001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 54)]
        public int? P031D002 { get; set; }

        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 55)]
        public int? P031D003 { get; set; }

        [Display(Name = "Related child:", ShortName = "Related child:", Order = 56)]
        public int? P031D004 { get; set; }

        [Display(Name = "Own child:", ShortName = "Own child:", Order = 57)]
        public int? P031D005 { get; set; }

        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 58)]
        public int? P031D006 { get; set; }

        [Display(Name = "In other family:", ShortName = "In other family:", Order = 59)]
        public int? P031D007 { get; set; }

        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 60)]
        public int? P031D008 { get; set; }

        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 61)]
        public int? P031D009 { get; set; }

        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 62)]
        public int? P031D010 { get; set; }

        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 63)]
        public int? P031D011 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 64)]
        public int? P031D012 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 65)]
        public int? P031D013 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 66)]
        public int? P031D014 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 67)]
        public int? P031D015 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 68)]
        public int? P031D016 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 69)]
        public int? P031E001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 70)]
        public int? P031E002 { get; set; }

        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 71)]
        public int? P031E003 { get; set; }

        [Display(Name = "Related child:", ShortName = "Related child:", Order = 72)]
        public int? P031E004 { get; set; }

        [Display(Name = "Own child:", ShortName = "Own child:", Order = 73)]
        public int? P031E005 { get; set; }

        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 74)]
        public int? P031E006 { get; set; }

        [Display(Name = "In other family:", ShortName = "In other family:", Order = 75)]
        public int? P031E007 { get; set; }

        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 76)]
        public int? P031E008 { get; set; }

        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 77)]
        public int? P031E009 { get; set; }

        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 78)]
        public int? P031E010 { get; set; }

        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 79)]
        public int? P031E011 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 80)]
        public int? P031E012 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 81)]
        public int? P031E013 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 82)]
        public int? P031E014 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 83)]
        public int? P031E015 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 84)]
        public int? P031E016 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 85)]
        public int? P031F001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 86)]
        public int? P031F002 { get; set; }

        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 87)]
        public int? P031F003 { get; set; }

        [Display(Name = "Related child:", ShortName = "Related child:", Order = 88)]
        public int? P031F004 { get; set; }

        [Display(Name = "Own child:", ShortName = "Own child:", Order = 89)]
        public int? P031F005 { get; set; }

        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 90)]
        public int? P031F006 { get; set; }

        [Display(Name = "In other family:", ShortName = "In other family:", Order = 91)]
        public int? P031F007 { get; set; }

        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 92)]
        public int? P031F008 { get; set; }

        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 93)]
        public int? P031F009 { get; set; }

        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 94)]
        public int? P031F010 { get; set; }

        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 95)]
        public int? P031F011 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 96)]
        public int? P031F012 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 97)]
        public int? P031F013 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 98)]
        public int? P031F014 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 99)]
        public int? P031F015 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 100)]
        public int? P031F016 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 101)]
        public int? P031G001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 102)]
        public int? P031G002 { get; set; }

        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 103)]
        public int? P031G003 { get; set; }

        [Display(Name = "Related child:", ShortName = "Related child:", Order = 104)]
        public int? P031G004 { get; set; }

        [Display(Name = "Own child:", ShortName = "Own child:", Order = 105)]
        public int? P031G005 { get; set; }

        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 106)]
        public int? P031G006 { get; set; }

        [Display(Name = "In other family:", ShortName = "In other family:", Order = 107)]
        public int? P031G007 { get; set; }

        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 108)]
        public int? P031G008 { get; set; }

        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 109)]
        public int? P031G009 { get; set; }

        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 110)]
        public int? P031G010 { get; set; }

        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 111)]
        public int? P031G011 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 112)]
        public int? P031G012 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 113)]
        public int? P031G013 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 114)]
        public int? P031G014 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 115)]
        public int? P031G015 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 116)]
        public int? P031G016 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 117)]
        public int? P031H001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 118)]
        public int? P031H002 { get; set; }

        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 119)]
        public int? P031H003 { get; set; }

        [Display(Name = "Related child:", ShortName = "Related child:", Order = 120)]
        public int? P031H004 { get; set; }

        [Display(Name = "Own child:", ShortName = "Own child:", Order = 121)]
        public int? P031H005 { get; set; }

        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 122)]
        public int? P031H006 { get; set; }

        [Display(Name = "In other family:", ShortName = "In other family:", Order = 123)]
        public int? P031H007 { get; set; }

        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 124)]
        public int? P031H008 { get; set; }

        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 125)]
        public int? P031H009 { get; set; }

        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 126)]
        public int? P031H010 { get; set; }

        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 127)]
        public int? P031H011 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 128)]
        public int? P031H012 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 129)]
        public int? P031H013 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 130)]
        public int? P031H014 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 131)]
        public int? P031H015 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 132)]
        public int? P031H016 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 133)]
        public int? P031I001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 134)]
        public int? P031I002 { get; set; }

        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 135)]
        public int? P031I003 { get; set; }

        [Display(Name = "Related child:", ShortName = "Related child:", Order = 136)]
        public int? P031I004 { get; set; }

        [Display(Name = "Own child:", ShortName = "Own child:", Order = 137)]
        public int? P031I005 { get; set; }

        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 138)]
        public int? P031I006 { get; set; }

        [Display(Name = "In other family:", ShortName = "In other family:", Order = 139)]
        public int? P031I007 { get; set; }

        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 140)]
        public int? P031I008 { get; set; }

        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 141)]
        public int? P031I009 { get; set; }

        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 142)]
        public int? P031I010 { get; set; }

        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 143)]
        public int? P031I011 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 144)]
        public int? P031I012 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 145)]
        public int? P031I013 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 146)]
        public int? P031I014 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 147)]
        public int? P031I015 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 148)]
        public int? P031I016 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 149)]
        public int? P034A001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 150)]
        public int? P034A002 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 151)]
        public int? P034A003 { get; set; }

        [Display(Name = "Householder:", ShortName = "Householder:", Order = 152)]
        public int? P034A004 { get; set; }

        [Display(Name = "Male", ShortName = "Male", Order = 153)]
        public int? P034A005 { get; set; }

        [Display(Name = "Female", ShortName = "Female", Order = 154)]
        public int? P034A006 { get; set; }

        [Display(Name = "Spouse", ShortName = "Spouse", Order = 155)]
        public int? P034A007 { get; set; }

        [Display(Name = "Parent", ShortName = "Parent", Order = 156)]
        public int? P034A008 { get; set; }

        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 157)]
        public int? P034A009 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 158)]
        public int? P034A010 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 159)]
        public int? P034A011 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 160)]
        public int? P034A012 { get; set; }

        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 161)]
        public int? P034A013 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 162)]
        public int? P034A014 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 163)]
        public int? P034A015 { get; set; }

        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 164)]
        public int? P034A016 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 165)]
        public int? P034A017 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 166)]
        public int? P034A018 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 167)]
        public int? P034A019 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 168)]
        public int? P034A020 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 169)]
        public int? P034A021 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 170)]
        public int? P034A022 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 171)]
        public int? P034B001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 172)]
        public int? P034B002 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 173)]
        public int? P034B003 { get; set; }

        [Display(Name = "Householder:", ShortName = "Householder:", Order = 174)]
        public int? P034B004 { get; set; }

        [Display(Name = "Male", ShortName = "Male", Order = 175)]
        public int? P034B005 { get; set; }

        [Display(Name = "Female", ShortName = "Female", Order = 176)]
        public int? P034B006 { get; set; }

        [Display(Name = "Spouse", ShortName = "Spouse", Order = 177)]
        public int? P034B007 { get; set; }

        [Display(Name = "Parent", ShortName = "Parent", Order = 178)]
        public int? P034B008 { get; set; }

        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 179)]
        public int? P034B009 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 180)]
        public int? P034B010 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 181)]
        public int? P034B011 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 182)]
        public int? P034B012 { get; set; }

        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 183)]
        public int? P034B013 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 184)]
        public int? P034B014 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 185)]
        public int? P034B015 { get; set; }

        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 186)]
        public int? P034B016 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 187)]
        public int? P034B017 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 188)]
        public int? P034B018 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 189)]
        public int? P034B019 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 190)]
        public int? P034B020 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 191)]
        public int? P034B021 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 192)]
        public int? P034B022 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 193)]
        public int? P034C001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 194)]
        public int? P034C002 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 195)]
        public int? P034C003 { get; set; }

        [Display(Name = "Householder:", ShortName = "Householder:", Order = 196)]
        public int? P034C004 { get; set; }

        [Display(Name = "Male", ShortName = "Male", Order = 197)]
        public int? P034C005 { get; set; }

        [Display(Name = "Female", ShortName = "Female", Order = 198)]
        public int? P034C006 { get; set; }

        [Display(Name = "Spouse", ShortName = "Spouse", Order = 199)]
        public int? P034C007 { get; set; }

        [Display(Name = "Parent", ShortName = "Parent", Order = 200)]
        public int? P034C008 { get; set; }

        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 201)]
        public int? P034C009 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 202)]
        public int? P034C010 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 203)]
        public int? P034C011 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 204)]
        public int? P034C012 { get; set; }

        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 205)]
        public int? P034C013 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 206)]
        public int? P034C014 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 207)]
        public int? P034C015 { get; set; }

        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 208)]
        public int? P034C016 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 209)]
        public int? P034C017 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 210)]
        public int? P034C018 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 211)]
        public int? P034C019 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 212)]
        public int? P034C020 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 213)]
        public int? P034C021 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 214)]
        public int? P034C022 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 215)]
        public int? P034D001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 216)]
        public int? P034D002 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 217)]
        public int? P034D003 { get; set; }

        [Display(Name = "Householder:", ShortName = "Householder:", Order = 218)]
        public int? P034D004 { get; set; }

        [Display(Name = "Male", ShortName = "Male", Order = 219)]
        public int? P034D005 { get; set; }

        [Display(Name = "Female", ShortName = "Female", Order = 220)]
        public int? P034D006 { get; set; }

        [Display(Name = "Spouse", ShortName = "Spouse", Order = 221)]
        public int? P034D007 { get; set; }

        [Display(Name = "Parent", ShortName = "Parent", Order = 222)]
        public int? P034D008 { get; set; }

        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 223)]
        public int? P034D009 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 224)]
        public int? P034D010 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 225)]
        public int? P034D011 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 226)]
        public int? P034D012 { get; set; }

        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 227)]
        public int? P034D013 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 228)]
        public int? P034D014 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 229)]
        public int? P034D015 { get; set; }

        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 230)]
        public int? P034D016 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 231)]
        public int? P034D017 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 232)]
        public int? P034D018 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 233)]
        public int? P034D019 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 234)]
        public int? P034D020 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 235)]
        public int? P034D021 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 236)]
        public int? P034D022 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 237)]
        public int? P034E001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 238)]
        public int? P034E002 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 239)]
        public int? P034E003 { get; set; }

        [Display(Name = "Householder:", ShortName = "Householder:", Order = 240)]
        public int? P034E004 { get; set; }

        [Display(Name = "Male", ShortName = "Male", Order = 241)]
        public int? P034E005 { get; set; }

        [Display(Name = "Female", ShortName = "Female", Order = 242)]
        public int? P034E006 { get; set; }

        [Display(Name = "Spouse", ShortName = "Spouse", Order = 243)]
        public int? P034E007 { get; set; }

        [Display(Name = "Parent", ShortName = "Parent", Order = 244)]
        public int? P034E008 { get; set; }

        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 245)]
        public int? P034E009 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 246)]
        public int? P034E010 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 247)]
        public int? P034E011 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 248)]
        public int? P034E012 { get; set; }

        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 249)]
        public int? P034E013 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 250)]
        public int? P034E014 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 251)]
        public int? P034E015 { get; set; }

        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 252)]
        public int? P034E016 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 253)]
        public int? P034E017 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 254)]
        public int? P034E018 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 255)]
        public int? P034E019 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 256)]
        public int? P034E020 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 257)]
        public int? P034E021 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 258)]
        public int? P034E022 { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}
