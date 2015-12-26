#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 4:10 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1_00010.cs
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

    public class SF1_00010
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
        public int? P029A001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 6)]
        public int? P029A002 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 7)]
        public int? P029A003 { get; set; }

        [Display(Name = "Householder:", ShortName = "Householder:", Order = 8)]
        public int? P029A004 { get; set; }

        [Display(Name = "Male", ShortName = "Male", Order = 9)]
        public int? P029A005 { get; set; }

        [Display(Name = "Female", ShortName = "Female", Order = 10)]
        public int? P029A006 { get; set; }

        [Display(Name = "Spouse", ShortName = "Spouse", Order = 11)]
        public int? P029A007 { get; set; }

        [Display(Name = "Biological child", ShortName = "Biological child", Order = 12)]
        public int? P029A008 { get; set; }

        [Display(Name = "Adopted child", ShortName = "Adopted child", Order = 13)]
        public int? P029A009 { get; set; }

        [Display(Name = "Stepchild", ShortName = "Stepchild", Order = 14)]
        public int? P029A010 { get; set; }

        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 15)]
        public int? P029A011 { get; set; }

        [Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 16)]
        public int? P029A012 { get; set; }

        [Display(Name = "Parent", ShortName = "Parent", Order = 17)]
        public int? P029A013 { get; set; }

        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 18)]
        public int? P029A014 { get; set; }

        [Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 19)]
        public int? P029A015 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 20)]
        public int? P029A016 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 21)]
        public int? P029A017 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 22)]
        public int? P029A018 { get; set; }

        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 23)]
        public int? P029A019 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 24)]
        public int? P029A020 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 25)]
        public int? P029A021 { get; set; }

        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 26)]
        public int? P029A022 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 27)]
        public int? P029A023 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 28)]
        public int? P029A024 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 29)]
        public int? P029A025 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 30)]
        public int? P029A026 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 31)]
        public int? P029A027 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 32)]
        public int? P029A028 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 33)]
        public int? P029B001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 34)]
        public int? P029B002 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 35)]
        public int? P029B003 { get; set; }

        [Display(Name = "Householder:", ShortName = "Householder:", Order = 36)]
        public int? P029B004 { get; set; }

        [Display(Name = "Male", ShortName = "Male", Order = 37)]
        public int? P029B005 { get; set; }

        [Display(Name = "Female", ShortName = "Female", Order = 38)]
        public int? P029B006 { get; set; }

        [Display(Name = "Spouse", ShortName = "Spouse", Order = 39)]
        public int? P029B007 { get; set; }

        [Display(Name = "Biological child", ShortName = "Biological child", Order = 40)]
        public int? P029B008 { get; set; }

        [Display(Name = "Adopted child", ShortName = "Adopted child", Order = 41)]
        public int? P029B009 { get; set; }

        [Display(Name = "Stepchild", ShortName = "Stepchild", Order = 42)]
        public int? P029B010 { get; set; }

        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 43)]
        public int? P029B011 { get; set; }

        [Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 44)]
        public int? P029B012 { get; set; }

        [Display(Name = "Parent", ShortName = "Parent", Order = 45)]
        public int? P029B013 { get; set; }

        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 46)]
        public int? P029B014 { get; set; }

        [Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 47)]
        public int? P029B015 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 48)]
        public int? P029B016 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 49)]
        public int? P029B017 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 50)]
        public int? P029B018 { get; set; }

        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 51)]
        public int? P029B019 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 52)]
        public int? P029B020 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 53)]
        public int? P029B021 { get; set; }

        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 54)]
        public int? P029B022 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 55)]
        public int? P029B023 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 56)]
        public int? P029B024 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 57)]
        public int? P029B025 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 58)]
        public int? P029B026 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 59)]
        public int? P029B027 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 60)]
        public int? P029B028 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 61)]
        public int? P029C001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 62)]
        public int? P029C002 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 63)]
        public int? P029C003 { get; set; }

        [Display(Name = "Householder:", ShortName = "Householder:", Order = 64)]
        public int? P029C004 { get; set; }

        [Display(Name = "Male", ShortName = "Male", Order = 65)]
        public int? P029C005 { get; set; }

        [Display(Name = "Female", ShortName = "Female", Order = 66)]
        public int? P029C006 { get; set; }

        [Display(Name = "Spouse", ShortName = "Spouse", Order = 67)]
        public int? P029C007 { get; set; }

        [Display(Name = "Biological child", ShortName = "Biological child", Order = 68)]
        public int? P029C008 { get; set; }

        [Display(Name = "Adopted child", ShortName = "Adopted child", Order = 69)]
        public int? P029C009 { get; set; }

        [Display(Name = "Stepchild", ShortName = "Stepchild", Order = 70)]
        public int? P029C010 { get; set; }

        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 71)]
        public int? P029C011 { get; set; }

        [Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 72)]
        public int? P029C012 { get; set; }

        [Display(Name = "Parent", ShortName = "Parent", Order = 73)]
        public int? P029C013 { get; set; }

        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 74)]
        public int? P029C014 { get; set; }

        [Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 75)]
        public int? P029C015 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 76)]
        public int? P029C016 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 77)]
        public int? P029C017 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 78)]
        public int? P029C018 { get; set; }

        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 79)]
        public int? P029C019 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 80)]
        public int? P029C020 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 81)]
        public int? P029C021 { get; set; }

        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 82)]
        public int? P029C022 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 83)]
        public int? P029C023 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 84)]
        public int? P029C024 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 85)]
        public int? P029C025 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 86)]
        public int? P029C026 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 87)]
        public int? P029C027 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 88)]
        public int? P029C028 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 89)]
        public int? P029D001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 90)]
        public int? P029D002 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 91)]
        public int? P029D003 { get; set; }

        [Display(Name = "Householder:", ShortName = "Householder:", Order = 92)]
        public int? P029D004 { get; set; }

        [Display(Name = "Male", ShortName = "Male", Order = 93)]
        public int? P029D005 { get; set; }

        [Display(Name = "Female", ShortName = "Female", Order = 94)]
        public int? P029D006 { get; set; }

        [Display(Name = "Spouse", ShortName = "Spouse", Order = 95)]
        public int? P029D007 { get; set; }

        [Display(Name = "Biological child", ShortName = "Biological child", Order = 96)]
        public int? P029D008 { get; set; }

        [Display(Name = "Adopted child", ShortName = "Adopted child", Order = 97)]
        public int? P029D009 { get; set; }

        [Display(Name = "Stepchild", ShortName = "Stepchild", Order = 98)]
        public int? P029D010 { get; set; }

        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 99)]
        public int? P029D011 { get; set; }

        [Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 100)]
        public int? P029D012 { get; set; }

        [Display(Name = "Parent", ShortName = "Parent", Order = 101)]
        public int? P029D013 { get; set; }

        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 102)]
        public int? P029D014 { get; set; }

        [Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 103)]
        public int? P029D015 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 104)]
        public int? P029D016 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 105)]
        public int? P029D017 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 106)]
        public int? P029D018 { get; set; }

        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 107)]
        public int? P029D019 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 108)]
        public int? P029D020 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 109)]
        public int? P029D021 { get; set; }

        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 110)]
        public int? P029D022 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 111)]
        public int? P029D023 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 112)]
        public int? P029D024 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 113)]
        public int? P029D025 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 114)]
        public int? P029D026 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 115)]
        public int? P029D027 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 116)]
        public int? P029D028 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 117)]
        public int? P029E001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 118)]
        public int? P029E002 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 119)]
        public int? P029E003 { get; set; }

        [Display(Name = "Householder:", ShortName = "Householder:", Order = 120)]
        public int? P029E004 { get; set; }

        [Display(Name = "Male", ShortName = "Male", Order = 121)]
        public int? P029E005 { get; set; }

        [Display(Name = "Female", ShortName = "Female", Order = 122)]
        public int? P029E006 { get; set; }

        [Display(Name = "Spouse", ShortName = "Spouse", Order = 123)]
        public int? P029E007 { get; set; }

        [Display(Name = "Biological child", ShortName = "Biological child", Order = 124)]
        public int? P029E008 { get; set; }

        [Display(Name = "Adopted child", ShortName = "Adopted child", Order = 125)]
        public int? P029E009 { get; set; }

        [Display(Name = "Stepchild", ShortName = "Stepchild", Order = 126)]
        public int? P029E010 { get; set; }

        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 127)]
        public int? P029E011 { get; set; }

        [Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 128)]
        public int? P029E012 { get; set; }

        [Display(Name = "Parent", ShortName = "Parent", Order = 129)]
        public int? P029E013 { get; set; }

        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 130)]
        public int? P029E014 { get; set; }

        [Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 131)]
        public int? P029E015 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 132)]
        public int? P029E016 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 133)]
        public int? P029E017 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 134)]
        public int? P029E018 { get; set; }

        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 135)]
        public int? P029E019 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 136)]
        public int? P029E020 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 137)]
        public int? P029E021 { get; set; }

        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 138)]
        public int? P029E022 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 139)]
        public int? P029E023 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 140)]
        public int? P029E024 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 141)]
        public int? P029E025 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 142)]
        public int? P029E026 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 143)]
        public int? P029E027 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 144)]
        public int? P029E028 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 145)]
        public int? P029F001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 146)]
        public int? P029F002 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 147)]
        public int? P029F003 { get; set; }

        [Display(Name = "Householder:", ShortName = "Householder:", Order = 148)]
        public int? P029F004 { get; set; }

        [Display(Name = "Male", ShortName = "Male", Order = 149)]
        public int? P029F005 { get; set; }

        [Display(Name = "Female", ShortName = "Female", Order = 150)]
        public int? P029F006 { get; set; }

        [Display(Name = "Spouse", ShortName = "Spouse", Order = 151)]
        public int? P029F007 { get; set; }

        [Display(Name = "Biological child", ShortName = "Biological child", Order = 152)]
        public int? P029F008 { get; set; }

        [Display(Name = "Adopted child", ShortName = "Adopted child", Order = 153)]
        public int? P029F009 { get; set; }

        [Display(Name = "Stepchild", ShortName = "Stepchild", Order = 154)]
        public int? P029F010 { get; set; }

        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 155)]
        public int? P029F011 { get; set; }

        [Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 156)]
        public int? P029F012 { get; set; }

        [Display(Name = "Parent", ShortName = "Parent", Order = 157)]
        public int? P029F013 { get; set; }

        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 158)]
        public int? P029F014 { get; set; }

        [Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 159)]
        public int? P029F015 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 160)]
        public int? P029F016 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 161)]
        public int? P029F017 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 162)]
        public int? P029F018 { get; set; }

        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 163)]
        public int? P029F019 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 164)]
        public int? P029F020 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 165)]
        public int? P029F021 { get; set; }

        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 166)]
        public int? P029F022 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 167)]
        public int? P029F023 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 168)]
        public int? P029F024 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 169)]
        public int? P029F025 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 170)]
        public int? P029F026 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 171)]
        public int? P029F027 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 172)]
        public int? P029F028 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 173)]
        public int? P029G001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 174)]
        public int? P029G002 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 175)]
        public int? P029G003 { get; set; }

        [Display(Name = "Householder:", ShortName = "Householder:", Order = 176)]
        public int? P029G004 { get; set; }

        [Display(Name = "Male", ShortName = "Male", Order = 177)]
        public int? P029G005 { get; set; }

        [Display(Name = "Female", ShortName = "Female", Order = 178)]
        public int? P029G006 { get; set; }

        [Display(Name = "Spouse", ShortName = "Spouse", Order = 179)]
        public int? P029G007 { get; set; }

        [Display(Name = "Biological child", ShortName = "Biological child", Order = 180)]
        public int? P029G008 { get; set; }

        [Display(Name = "Adopted child", ShortName = "Adopted child", Order = 181)]
        public int? P029G009 { get; set; }

        [Display(Name = "Stepchild", ShortName = "Stepchild", Order = 182)]
        public int? P029G010 { get; set; }

        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 183)]
        public int? P029G011 { get; set; }

        [Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 184)]
        public int? P029G012 { get; set; }

        [Display(Name = "Parent", ShortName = "Parent", Order = 185)]
        public int? P029G013 { get; set; }

        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 186)]
        public int? P029G014 { get; set; }

        [Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 187)]
        public int? P029G015 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 188)]
        public int? P029G016 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 189)]
        public int? P029G017 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 190)]
        public int? P029G018 { get; set; }

        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 191)]
        public int? P029G019 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 192)]
        public int? P029G020 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 193)]
        public int? P029G021 { get; set; }

        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 194)]
        public int? P029G022 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 195)]
        public int? P029G023 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 196)]
        public int? P029G024 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 197)]
        public int? P029G025 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 198)]
        public int? P029G026 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 199)]
        public int? P029G027 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 200)]
        public int? P029G028 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 201)]
        public int? P029H001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 202)]
        public int? P029H002 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 203)]
        public int? P029H003 { get; set; }

        [Display(Name = "Householder:", ShortName = "Householder:", Order = 204)]
        public int? P029H004 { get; set; }

        [Display(Name = "Male", ShortName = "Male", Order = 205)]
        public int? P029H005 { get; set; }

        [Display(Name = "Female", ShortName = "Female", Order = 206)]
        public int? P029H006 { get; set; }

        [Display(Name = "Spouse", ShortName = "Spouse", Order = 207)]
        public int? P029H007 { get; set; }

        [Display(Name = "Biological child", ShortName = "Biological child", Order = 208)]
        public int? P029H008 { get; set; }

        [Display(Name = "Adopted child", ShortName = "Adopted child", Order = 209)]
        public int? P029H009 { get; set; }

        [Display(Name = "Stepchild", ShortName = "Stepchild", Order = 210)]
        public int? P029H010 { get; set; }

        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 211)]
        public int? P029H011 { get; set; }

        [Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 212)]
        public int? P029H012 { get; set; }

        [Display(Name = "Parent", ShortName = "Parent", Order = 213)]
        public int? P029H013 { get; set; }

        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 214)]
        public int? P029H014 { get; set; }

        [Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 215)]
        public int? P029H015 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 216)]
        public int? P029H016 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 217)]
        public int? P029H017 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 218)]
        public int? P029H018 { get; set; }

        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 219)]
        public int? P029H019 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 220)]
        public int? P029H020 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 221)]
        public int? P029H021 { get; set; }

        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 222)]
        public int? P029H022 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 223)]
        public int? P029H023 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 224)]
        public int? P029H024 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 225)]
        public int? P029H025 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 226)]
        public int? P029H026 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 227)]
        public int? P029H027 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 228)]
        public int? P029H028 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 229)]
        public int? P029I001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 230)]
        public int? P029I002 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 231)]
        public int? P029I003 { get; set; }

        [Display(Name = "Householder:", ShortName = "Householder:", Order = 232)]
        public int? P029I004 { get; set; }

        [Display(Name = "Male", ShortName = "Male", Order = 233)]
        public int? P029I005 { get; set; }

        [Display(Name = "Female", ShortName = "Female", Order = 234)]
        public int? P029I006 { get; set; }

        [Display(Name = "Spouse", ShortName = "Spouse", Order = 235)]
        public int? P029I007 { get; set; }

        [Display(Name = "Biological child", ShortName = "Biological child", Order = 236)]
        public int? P029I008 { get; set; }

        [Display(Name = "Adopted child", ShortName = "Adopted child", Order = 237)]
        public int? P029I009 { get; set; }

        [Display(Name = "Stepchild", ShortName = "Stepchild", Order = 238)]
        public int? P029I010 { get; set; }

        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 239)]
        public int? P029I011 { get; set; }

        [Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 240)]
        public int? P029I012 { get; set; }

        [Display(Name = "Parent", ShortName = "Parent", Order = 241)]
        public int? P029I013 { get; set; }

        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 242)]
        public int? P029I014 { get; set; }

        [Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 243)]
        public int? P029I015 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 244)]
        public int? P029I016 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 245)]
        public int? P029I017 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 246)]
        public int? P029I018 { get; set; }

        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 247)]
        public int? P029I019 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 248)]
        public int? P029I020 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 249)]
        public int? P029I021 { get; set; }

        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 250)]
        public int? P029I022 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 251)]
        public int? P029I023 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 252)]
        public int? P029I024 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 253)]
        public int? P029I025 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 254)]
        public int? P029I026 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 255)]
        public int? P029I027 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 256)]
        public int? P029I028 { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}
