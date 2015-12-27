#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 5:32 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1_00009.cs
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

    public class SF1_00009
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
        public double? P017B001 { get; set; }

        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 6)]
        public double? P017B002 { get; set; }

        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 7)]
        public double? P017B003 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 8)]
        public double? P017C001 { get; set; }

        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 9)]
        public double? P017C002 { get; set; }

        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 10)]
        public double? P017C003 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 11)]
        public double? P017D001 { get; set; }

        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 12)]
        public double? P017D002 { get; set; }

        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 13)]
        public double? P017D003 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 14)]
        public double? P017E001 { get; set; }

        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 15)]
        public double? P017E002 { get; set; }

        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 16)]
        public double? P017E003 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 17)]
        public double? P017F001 { get; set; }

        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 18)]
        public double? P017F002 { get; set; }

        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 19)]
        public double? P017F003 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 20)]
        public double? P017G001 { get; set; }

        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 21)]
        public double? P017G002 { get; set; }

        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 22)]
        public double? P017G003 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 23)]
        public double? P017H001 { get; set; }

        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 24)]
        public double? P017H002 { get; set; }

        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 25)]
        public double? P017H003 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 26)]
        public double? P017I001 { get; set; }

        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 27)]
        public double? P017I002 { get; set; }

        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 28)]
        public double? P017I003 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 29)]
        public int? P018A001 { get; set; }

        [Display(Name = "Family households:", ShortName = "Family households:", Order = 30)]
        public int? P018A002 { get; set; }

        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 31)]
        public int? P018A003 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 32)]
        public int? P018A004 { get; set; }

        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 33)]
        public int? P018A005 { get; set; }

        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 34)]
        public int? P018A006 { get; set; }

        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 35)]
        public int? P018A007 { get; set; }

        [Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 36)]
        public int? P018A008 { get; set; }

        [Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 37)]
        public int? P018A009 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 38)]
        public int? P018B001 { get; set; }

        [Display(Name = "Family households:", ShortName = "Family households:", Order = 39)]
        public int? P018B002 { get; set; }

        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 40)]
        public int? P018B003 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 41)]
        public int? P018B004 { get; set; }

        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 42)]
        public int? P018B005 { get; set; }

        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 43)]
        public int? P018B006 { get; set; }

        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 44)]
        public int? P018B007 { get; set; }

        [Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 45)]
        public int? P018B008 { get; set; }

        [Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 46)]
        public int? P018B009 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 47)]
        public int? P018C001 { get; set; }

        [Display(Name = "Family households:", ShortName = "Family households:", Order = 48)]
        public int? P018C002 { get; set; }

        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 49)]
        public int? P018C003 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 50)]
        public int? P018C004 { get; set; }

        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 51)]
        public int? P018C005 { get; set; }

        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 52)]
        public int? P018C006 { get; set; }

        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 53)]
        public int? P018C007 { get; set; }

        [Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 54)]
        public int? P018C008 { get; set; }

        [Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 55)]
        public int? P018C009 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 56)]
        public int? P018D001 { get; set; }

        [Display(Name = "Family households:", ShortName = "Family households:", Order = 57)]
        public int? P018D002 { get; set; }

        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 58)]
        public int? P018D003 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 59)]
        public int? P018D004 { get; set; }

        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 60)]
        public int? P018D005 { get; set; }

        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 61)]
        public int? P018D006 { get; set; }

        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 62)]
        public int? P018D007 { get; set; }

        [Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 63)]
        public int? P018D008 { get; set; }

        [Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 64)]
        public int? P018D009 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 65)]
        public int? P018E001 { get; set; }

        [Display(Name = "Family households:", ShortName = "Family households:", Order = 66)]
        public int? P018E002 { get; set; }

        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 67)]
        public int? P018E003 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 68)]
        public int? P018E004 { get; set; }

        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 69)]
        public int? P018E005 { get; set; }

        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 70)]
        public int? P018E006 { get; set; }

        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 71)]
        public int? P018E007 { get; set; }

        [Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 72)]
        public int? P018E008 { get; set; }

        [Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 73)]
        public int? P018E009 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 74)]
        public int? P018F001 { get; set; }

        [Display(Name = "Family households:", ShortName = "Family households:", Order = 75)]
        public int? P018F002 { get; set; }

        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 76)]
        public int? P018F003 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 77)]
        public int? P018F004 { get; set; }

        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 78)]
        public int? P018F005 { get; set; }

        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 79)]
        public int? P018F006 { get; set; }

        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 80)]
        public int? P018F007 { get; set; }

        [Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 81)]
        public int? P018F008 { get; set; }

        [Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 82)]
        public int? P018F009 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 83)]
        public int? P018G001 { get; set; }

        [Display(Name = "Family households:", ShortName = "Family households:", Order = 84)]
        public int? P018G002 { get; set; }

        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 85)]
        public int? P018G003 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 86)]
        public int? P018G004 { get; set; }

        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 87)]
        public int? P018G005 { get; set; }

        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 88)]
        public int? P018G006 { get; set; }

        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 89)]
        public int? P018G007 { get; set; }

        [Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 90)]
        public int? P018G008 { get; set; }

        [Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 91)]
        public int? P018G009 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 92)]
        public int? P018H001 { get; set; }

        [Display(Name = "Family households:", ShortName = "Family households:", Order = 93)]
        public int? P018H002 { get; set; }

        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 94)]
        public int? P018H003 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 95)]
        public int? P018H004 { get; set; }

        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 96)]
        public int? P018H005 { get; set; }

        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 97)]
        public int? P018H006 { get; set; }

        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 98)]
        public int? P018H007 { get; set; }

        [Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 99)]
        public int? P018H008 { get; set; }

        [Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 100)]
        public int? P018H009 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 101)]
        public int? P018I001 { get; set; }

        [Display(Name = "Family households:", ShortName = "Family households:", Order = 102)]
        public int? P018I002 { get; set; }

        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 103)]
        public int? P018I003 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 104)]
        public int? P018I004 { get; set; }

        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 105)]
        public int? P018I005 { get; set; }

        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 106)]
        public int? P018I006 { get; set; }

        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 107)]
        public int? P018I007 { get; set; }

        [Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 108)]
        public int? P018I008 { get; set; }

        [Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 109)]
        public int? P018I009 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 110)]
        public int? P028A001 { get; set; }

        [Display(Name = "Family households:", ShortName = "Family households:", Order = 111)]
        public int? P028A002 { get; set; }

        [Display(Name = "2-person household", ShortName = "2-person household", Order = 112)]
        public int? P028A003 { get; set; }

        [Display(Name = "3-person household", ShortName = "3-person household", Order = 113)]
        public int? P028A004 { get; set; }

        [Display(Name = "4-person household", ShortName = "4-person household", Order = 114)]
        public int? P028A005 { get; set; }

        [Display(Name = "5-person household", ShortName = "5-person household", Order = 115)]
        public int? P028A006 { get; set; }

        [Display(Name = "6-person household", ShortName = "6-person household", Order = 116)]
        public int? P028A007 { get; set; }

        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 117)]
        public int? P028A008 { get; set; }

        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 118)]
        public int? P028A009 { get; set; }

        [Display(Name = "1-person household", ShortName = "1-person household", Order = 119)]
        public int? P028A010 { get; set; }

        [Display(Name = "2-person household", ShortName = "2-person household", Order = 120)]
        public int? P028A011 { get; set; }

        [Display(Name = "3-person household", ShortName = "3-person household", Order = 121)]
        public int? P028A012 { get; set; }

        [Display(Name = "4-person household", ShortName = "4-person household", Order = 122)]
        public int? P028A013 { get; set; }

        [Display(Name = "5-person household", ShortName = "5-person household", Order = 123)]
        public int? P028A014 { get; set; }

        [Display(Name = "6-person household", ShortName = "6-person household", Order = 124)]
        public int? P028A015 { get; set; }

        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 125)]
        public int? P028A016 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 126)]
        public int? P028B001 { get; set; }

        [Display(Name = "Family households:", ShortName = "Family households:", Order = 127)]
        public int? P028B002 { get; set; }

        [Display(Name = "2-person household", ShortName = "2-person household", Order = 128)]
        public int? P028B003 { get; set; }

        [Display(Name = "3-person household", ShortName = "3-person household", Order = 129)]
        public int? P028B004 { get; set; }

        [Display(Name = "4-person household", ShortName = "4-person household", Order = 130)]
        public int? P028B005 { get; set; }

        [Display(Name = "5-person household", ShortName = "5-person household", Order = 131)]
        public int? P028B006 { get; set; }

        [Display(Name = "6-person household", ShortName = "6-person household", Order = 132)]
        public int? P028B007 { get; set; }

        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 133)]
        public int? P028B008 { get; set; }

        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 134)]
        public int? P028B009 { get; set; }

        [Display(Name = "1-person household", ShortName = "1-person household", Order = 135)]
        public int? P028B010 { get; set; }

        [Display(Name = "2-person household", ShortName = "2-person household", Order = 136)]
        public int? P028B011 { get; set; }

        [Display(Name = "3-person household", ShortName = "3-person household", Order = 137)]
        public int? P028B012 { get; set; }

        [Display(Name = "4-person household", ShortName = "4-person household", Order = 138)]
        public int? P028B013 { get; set; }

        [Display(Name = "5-person household", ShortName = "5-person household", Order = 139)]
        public int? P028B014 { get; set; }

        [Display(Name = "6-person household", ShortName = "6-person household", Order = 140)]
        public int? P028B015 { get; set; }

        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 141)]
        public int? P028B016 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 142)]
        public int? P028C001 { get; set; }

        [Display(Name = "Family households:", ShortName = "Family households:", Order = 143)]
        public int? P028C002 { get; set; }

        [Display(Name = "2-person household", ShortName = "2-person household", Order = 144)]
        public int? P028C003 { get; set; }

        [Display(Name = "3-person household", ShortName = "3-person household", Order = 145)]
        public int? P028C004 { get; set; }

        [Display(Name = "4-person household", ShortName = "4-person household", Order = 146)]
        public int? P028C005 { get; set; }

        [Display(Name = "5-person household", ShortName = "5-person household", Order = 147)]
        public int? P028C006 { get; set; }

        [Display(Name = "6-person household", ShortName = "6-person household", Order = 148)]
        public int? P028C007 { get; set; }

        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 149)]
        public int? P028C008 { get; set; }

        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 150)]
        public int? P028C009 { get; set; }

        [Display(Name = "1-person household", ShortName = "1-person household", Order = 151)]
        public int? P028C010 { get; set; }

        [Display(Name = "2-person household", ShortName = "2-person household", Order = 152)]
        public int? P028C011 { get; set; }

        [Display(Name = "3-person household", ShortName = "3-person household", Order = 153)]
        public int? P028C012 { get; set; }

        [Display(Name = "4-person household", ShortName = "4-person household", Order = 154)]
        public int? P028C013 { get; set; }

        [Display(Name = "5-person household", ShortName = "5-person household", Order = 155)]
        public int? P028C014 { get; set; }

        [Display(Name = "6-person household", ShortName = "6-person household", Order = 156)]
        public int? P028C015 { get; set; }

        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 157)]
        public int? P028C016 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 158)]
        public int? P028D001 { get; set; }

        [Display(Name = "Family households:", ShortName = "Family households:", Order = 159)]
        public int? P028D002 { get; set; }

        [Display(Name = "2-person household", ShortName = "2-person household", Order = 160)]
        public int? P028D003 { get; set; }

        [Display(Name = "3-person household", ShortName = "3-person household", Order = 161)]
        public int? P028D004 { get; set; }

        [Display(Name = "4-person household", ShortName = "4-person household", Order = 162)]
        public int? P028D005 { get; set; }

        [Display(Name = "5-person household", ShortName = "5-person household", Order = 163)]
        public int? P028D006 { get; set; }

        [Display(Name = "6-person household", ShortName = "6-person household", Order = 164)]
        public int? P028D007 { get; set; }

        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 165)]
        public int? P028D008 { get; set; }

        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 166)]
        public int? P028D009 { get; set; }

        [Display(Name = "1-person household", ShortName = "1-person household", Order = 167)]
        public int? P028D010 { get; set; }

        [Display(Name = "2-person household", ShortName = "2-person household", Order = 168)]
        public int? P028D011 { get; set; }

        [Display(Name = "3-person household", ShortName = "3-person household", Order = 169)]
        public int? P028D012 { get; set; }

        [Display(Name = "4-person household", ShortName = "4-person household", Order = 170)]
        public int? P028D013 { get; set; }

        [Display(Name = "5-person household", ShortName = "5-person household", Order = 171)]
        public int? P028D014 { get; set; }

        [Display(Name = "6-person household", ShortName = "6-person household", Order = 172)]
        public int? P028D015 { get; set; }

        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 173)]
        public int? P028D016 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 174)]
        public int? P028E001 { get; set; }

        [Display(Name = "Family households:", ShortName = "Family households:", Order = 175)]
        public int? P028E002 { get; set; }

        [Display(Name = "2-person household", ShortName = "2-person household", Order = 176)]
        public int? P028E003 { get; set; }

        [Display(Name = "3-person household", ShortName = "3-person household", Order = 177)]
        public int? P028E004 { get; set; }

        [Display(Name = "4-person household", ShortName = "4-person household", Order = 178)]
        public int? P028E005 { get; set; }

        [Display(Name = "5-person household", ShortName = "5-person household", Order = 179)]
        public int? P028E006 { get; set; }

        [Display(Name = "6-person household", ShortName = "6-person household", Order = 180)]
        public int? P028E007 { get; set; }

        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 181)]
        public int? P028E008 { get; set; }

        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 182)]
        public int? P028E009 { get; set; }

        [Display(Name = "1-person household", ShortName = "1-person household", Order = 183)]
        public int? P028E010 { get; set; }

        [Display(Name = "2-person household", ShortName = "2-person household", Order = 184)]
        public int? P028E011 { get; set; }

        [Display(Name = "3-person household", ShortName = "3-person household", Order = 185)]
        public int? P028E012 { get; set; }

        [Display(Name = "4-person household", ShortName = "4-person household", Order = 186)]
        public int? P028E013 { get; set; }

        [Display(Name = "5-person household", ShortName = "5-person household", Order = 187)]
        public int? P028E014 { get; set; }

        [Display(Name = "6-person household", ShortName = "6-person household", Order = 188)]
        public int? P028E015 { get; set; }

        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 189)]
        public int? P028E016 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 190)]
        public int? P028F001 { get; set; }

        [Display(Name = "Family households:", ShortName = "Family households:", Order = 191)]
        public int? P028F002 { get; set; }

        [Display(Name = "2-person household", ShortName = "2-person household", Order = 192)]
        public int? P028F003 { get; set; }

        [Display(Name = "3-person household", ShortName = "3-person household", Order = 193)]
        public int? P028F004 { get; set; }

        [Display(Name = "4-person household", ShortName = "4-person household", Order = 194)]
        public int? P028F005 { get; set; }

        [Display(Name = "5-person household", ShortName = "5-person household", Order = 195)]
        public int? P028F006 { get; set; }

        [Display(Name = "6-person household", ShortName = "6-person household", Order = 196)]
        public int? P028F007 { get; set; }

        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 197)]
        public int? P028F008 { get; set; }

        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 198)]
        public int? P028F009 { get; set; }

        [Display(Name = "1-person household", ShortName = "1-person household", Order = 199)]
        public int? P028F010 { get; set; }

        [Display(Name = "2-person household", ShortName = "2-person household", Order = 200)]
        public int? P028F011 { get; set; }

        [Display(Name = "3-person household", ShortName = "3-person household", Order = 201)]
        public int? P028F012 { get; set; }

        [Display(Name = "4-person household", ShortName = "4-person household", Order = 202)]
        public int? P028F013 { get; set; }

        [Display(Name = "5-person household", ShortName = "5-person household", Order = 203)]
        public int? P028F014 { get; set; }

        [Display(Name = "6-person household", ShortName = "6-person household", Order = 204)]
        public int? P028F015 { get; set; }

        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 205)]
        public int? P028F016 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 206)]
        public int? P028G001 { get; set; }

        [Display(Name = "Family households:", ShortName = "Family households:", Order = 207)]
        public int? P028G002 { get; set; }

        [Display(Name = "2-person household", ShortName = "2-person household", Order = 208)]
        public int? P028G003 { get; set; }

        [Display(Name = "3-person household", ShortName = "3-person household", Order = 209)]
        public int? P028G004 { get; set; }

        [Display(Name = "4-person household", ShortName = "4-person household", Order = 210)]
        public int? P028G005 { get; set; }

        [Display(Name = "5-person household", ShortName = "5-person household", Order = 211)]
        public int? P028G006 { get; set; }

        [Display(Name = "6-person household", ShortName = "6-person household", Order = 212)]
        public int? P028G007 { get; set; }

        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 213)]
        public int? P028G008 { get; set; }

        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 214)]
        public int? P028G009 { get; set; }

        [Display(Name = "1-person household", ShortName = "1-person household", Order = 215)]
        public int? P028G010 { get; set; }

        [Display(Name = "2-person household", ShortName = "2-person household", Order = 216)]
        public int? P028G011 { get; set; }

        [Display(Name = "3-person household", ShortName = "3-person household", Order = 217)]
        public int? P028G012 { get; set; }

        [Display(Name = "4-person household", ShortName = "4-person household", Order = 218)]
        public int? P028G013 { get; set; }

        [Display(Name = "5-person household", ShortName = "5-person household", Order = 219)]
        public int? P028G014 { get; set; }

        [Display(Name = "6-person household", ShortName = "6-person household", Order = 220)]
        public int? P028G015 { get; set; }

        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 221)]
        public int? P028G016 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 222)]
        public int? P028H001 { get; set; }

        [Display(Name = "Family households:", ShortName = "Family households:", Order = 223)]
        public int? P028H002 { get; set; }

        [Display(Name = "2-person household", ShortName = "2-person household", Order = 224)]
        public int? P028H003 { get; set; }

        [Display(Name = "3-person household", ShortName = "3-person household", Order = 225)]
        public int? P028H004 { get; set; }

        [Display(Name = "4-person household", ShortName = "4-person household", Order = 226)]
        public int? P028H005 { get; set; }

        [Display(Name = "5-person household", ShortName = "5-person household", Order = 227)]
        public int? P028H006 { get; set; }

        [Display(Name = "6-person household", ShortName = "6-person household", Order = 228)]
        public int? P028H007 { get; set; }

        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 229)]
        public int? P028H008 { get; set; }

        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 230)]
        public int? P028H009 { get; set; }

        [Display(Name = "1-person household", ShortName = "1-person household", Order = 231)]
        public int? P028H010 { get; set; }

        [Display(Name = "2-person household", ShortName = "2-person household", Order = 232)]
        public int? P028H011 { get; set; }

        [Display(Name = "3-person household", ShortName = "3-person household", Order = 233)]
        public int? P028H012 { get; set; }

        [Display(Name = "4-person household", ShortName = "4-person household", Order = 234)]
        public int? P028H013 { get; set; }

        [Display(Name = "5-person household", ShortName = "5-person household", Order = 235)]
        public int? P028H014 { get; set; }

        [Display(Name = "6-person household", ShortName = "6-person household", Order = 236)]
        public int? P028H015 { get; set; }

        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 237)]
        public int? P028H016 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 238)]
        public int? P028I001 { get; set; }

        [Display(Name = "Family households:", ShortName = "Family households:", Order = 239)]
        public int? P028I002 { get; set; }

        [Display(Name = "2-person household", ShortName = "2-person household", Order = 240)]
        public int? P028I003 { get; set; }

        [Display(Name = "3-person household", ShortName = "3-person household", Order = 241)]
        public int? P028I004 { get; set; }

        [Display(Name = "4-person household", ShortName = "4-person household", Order = 242)]
        public int? P028I005 { get; set; }

        [Display(Name = "5-person household", ShortName = "5-person household", Order = 243)]
        public int? P028I006 { get; set; }

        [Display(Name = "6-person household", ShortName = "6-person household", Order = 244)]
        public int? P028I007 { get; set; }

        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 245)]
        public int? P028I008 { get; set; }

        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 246)]
        public int? P028I009 { get; set; }

        [Display(Name = "1-person household", ShortName = "1-person household", Order = 247)]
        public int? P028I010 { get; set; }

        [Display(Name = "2-person household", ShortName = "2-person household", Order = 248)]
        public int? P028I011 { get; set; }

        [Display(Name = "3-person household", ShortName = "3-person household", Order = 249)]
        public int? P028I012 { get; set; }

        [Display(Name = "4-person household", ShortName = "4-person household", Order = 250)]
        public int? P028I013 { get; set; }

        [Display(Name = "5-person household", ShortName = "5-person household", Order = 251)]
        public int? P028I014 { get; set; }

        [Display(Name = "6-person household", ShortName = "6-person household", Order = 252)]
        public int? P028I015 { get; set; }

        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 253)]
        public int? P028I016 { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}
