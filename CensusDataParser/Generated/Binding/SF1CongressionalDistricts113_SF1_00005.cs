#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2016 11:01 AM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1CongressionalDistricts113_SF1_00005.cs
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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.OleDb;
    using Enumerators;
    #endregion

    public class SF1CongressionalDistricts113_SF1_00005 : BaseModel
    {
        #region Properties
        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("FILEID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
        public string FILEID { get; set; }

        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("STUSAB", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }

        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("CHARITER", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
        public string CHARITER { get; set; }

        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("CIFSN", Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
        public string CIFSN { get; set; }

        [ReadOnly(false)]
        [Column("LOGRECNO", Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
        public int? LOGRECNO { get; set; }

        [ReadOnly(false)]
        [Column("P0150001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public int? P0150001 { get; set; }

        [ReadOnly(false)]
        [Column("P0150002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not Hispanic or Latino householder:", ShortName = "Not Hispanic or Latino householder:", Order = 6)]
        public int? P0150002 { get; set; }

        [ReadOnly(false)]
        [Column("P0150003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 7)]
        public int? P0150003 { get; set; }

        [ReadOnly(false)]
        [Column("P0150004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 8)]
        public int? P0150004 { get; set; }

        [ReadOnly(false)]
        [Column("P0150005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 9)]
        public int? P0150005 { get; set; }

        [ReadOnly(false)]
        [Column("P0150006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 10)]
        public int? P0150006 { get; set; }

        [ReadOnly(false)]
        [Column("P0150007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 11)]
        public int? P0150007 { get; set; }

        [ReadOnly(false)]
        [Column("P0150008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 12)]
        public int? P0150008 { get; set; }

        [ReadOnly(false)]
        [Column("P0150009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 13)]
        public int? P0150009 { get; set; }

        [ReadOnly(false)]
        [Column("P0150010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hispanic or Latino householder:", ShortName = "Hispanic or Latino householder:", Order = 14)]
        public int? P0150010 { get; set; }

        [ReadOnly(false)]
        [Column("P0150011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 15)]
        public int? P0150011 { get; set; }

        [ReadOnly(false)]
        [Column("P0150012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 16)]
        public int? P0150012 { get; set; }

        [ReadOnly(false)]
        [Column("P0150013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 17)]
        public int? P0150013 { get; set; }

        [ReadOnly(false)]
        [Column("P0150014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 18)]
        public int? P0150014 { get; set; }

        [ReadOnly(false)]
        [Column("P0150015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 19)]
        public int? P0150015 { get; set; }

        [ReadOnly(false)]
        [Column("P0150016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 20)]
        public int? P0150016 { get; set; }

        [ReadOnly(false)]
        [Column("P0150017", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 21)]
        public int? P0150017 { get; set; }

        [ReadOnly(false)]
        [Column("P0160001", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 22)]
        public int? P0160001 { get; set; }

        [ReadOnly(false)]
        [Column("P0160002", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 23)]
        public int? P0160002 { get; set; }

        [ReadOnly(false)]
        [Column("P0160003", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 24)]
        public int? P0160003 { get; set; }

        [ReadOnly(false)]
        [Column("P0170001", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 25)]
        public double? P0170001 { get; set; }

        [ReadOnly(false)]
        [Column("P0170002", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 26)]
        public double? P0170002 { get; set; }

        [ReadOnly(false)]
        [Column("P0170003", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 27)]
        public double? P0170003 { get; set; }

        [ReadOnly(false)]
        [Column("P0180001", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 28)]
        public int? P0180001 { get; set; }

        [ReadOnly(false)]
        [Column("P0180002", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 29)]
        public int? P0180002 { get; set; }

        [ReadOnly(false)]
        [Column("P0180003", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 30)]
        public int? P0180003 { get; set; }

        [ReadOnly(false)]
        [Column("P0180004", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 31)]
        public int? P0180004 { get; set; }

        [ReadOnly(false)]
        [Column("P0180005", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 32)]
        public int? P0180005 { get; set; }

        [ReadOnly(false)]
        [Column("P0180006", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 33)]
        public int? P0180006 { get; set; }

        [ReadOnly(false)]
        [Column("P0180007", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 34)]
        public int? P0180007 { get; set; }

        [ReadOnly(false)]
        [Column("P0180008", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 35)]
        public int? P0180008 { get; set; }

        [ReadOnly(false)]
        [Column("P0180009", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 36)]
        public int? P0180009 { get; set; }

        [ReadOnly(false)]
        [Column("P0190001", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 37)]
        public int? P0190001 { get; set; }

        [ReadOnly(false)]
        [Column("P0190002", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household:", ShortName = "1-person household:", Order = 38)]
        public int? P0190002 { get; set; }

        [ReadOnly(false)]
        [Column("P0190003", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder", ShortName = "Male householder", Order = 39)]
        public int? P0190003 { get; set; }

        [ReadOnly(false)]
        [Column("P0190004", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder", ShortName = "Female householder", Order = 40)]
        public int? P0190004 { get; set; }

        [ReadOnly(false)]
        [Column("P0190005", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-or-more-person household:", ShortName = "2-or-more-person household:", Order = 41)]
        public int? P0190005 { get; set; }

        [ReadOnly(false)]
        [Column("P0190006", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 42)]
        public int? P0190006 { get; set; }

        [ReadOnly(false)]
        [Column("P0190007", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 43)]
        public int? P0190007 { get; set; }

        [ReadOnly(false)]
        [Column("P0190008", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 44)]
        public int? P0190008 { get; set; }

        [ReadOnly(false)]
        [Column("P0190009", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 45)]
        public int? P0190009 { get; set; }

        [ReadOnly(false)]
        [Column("P0190010", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 46)]
        public int? P0190010 { get; set; }

        [ReadOnly(false)]
        [Column("P0190011", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 47)]
        public int? P0190011 { get; set; }

        [ReadOnly(false)]
        [Column("P0190012", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 48)]
        public int? P0190012 { get; set; }

        [ReadOnly(false)]
        [Column("P0190013", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 49)]
        public int? P0190013 { get; set; }

        [ReadOnly(false)]
        [Column("P0190014", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 50)]
        public int? P0190014 { get; set; }

        [ReadOnly(false)]
        [Column("P0190015", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 51)]
        public int? P0190015 { get; set; }

        [ReadOnly(false)]
        [Column("P0190016", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 52)]
        public int? P0190016 { get; set; }

        [ReadOnly(false)]
        [Column("P0190017", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 53)]
        public int? P0190017 { get; set; }

        [ReadOnly(false)]
        [Column("P0190018", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder", ShortName = "Male householder", Order = 54)]
        public int? P0190018 { get; set; }

        [ReadOnly(false)]
        [Column("P0190019", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder", ShortName = "Female householder", Order = 55)]
        public int? P0190019 { get; set; }

        [ReadOnly(false)]
        [Column("P0200001", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 56)]
        public int? P0200001 { get; set; }

        [ReadOnly(false)]
        [Column("P0200002", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Households with one or more people under 18 years:", ShortName = "Households with one or more people under 18 years:", Order = 57)]
        public int? P0200002 { get; set; }

        [ReadOnly(false)]
        [Column("P0200003", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 58)]
        public int? P0200003 { get; set; }

        [ReadOnly(false)]
        [Column("P0200004", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 59)]
        public int? P0200004 { get; set; }

        [ReadOnly(false)]
        [Column("P0200005", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 60)]
        public int? P0200005 { get; set; }

        [ReadOnly(false)]
        [Column("P0200006", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 61)]
        public int? P0200006 { get; set; }

        [ReadOnly(false)]
        [Column("P0200007", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 62)]
        public int? P0200007 { get; set; }

        [ReadOnly(false)]
        [Column("P0200008", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 63)]
        public int? P0200008 { get; set; }

        [ReadOnly(false)]
        [Column("P0200009", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 64)]
        public int? P0200009 { get; set; }

        [ReadOnly(false)]
        [Column("P0200010", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 65)]
        public int? P0200010 { get; set; }

        [ReadOnly(false)]
        [Column("P0200011", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 66)]
        public int? P0200011 { get; set; }

        [ReadOnly(false)]
        [Column("P0200012", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 67)]
        public int? P0200012 { get; set; }

        [ReadOnly(false)]
        [Column("P0200013", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 68)]
        public int? P0200013 { get; set; }

        [ReadOnly(false)]
        [Column("P0200014", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 69)]
        public int? P0200014 { get; set; }

        [ReadOnly(false)]
        [Column("P0200015", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 70)]
        public int? P0200015 { get; set; }

        [ReadOnly(false)]
        [Column("P0200016", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 71)]
        public int? P0200016 { get; set; }

        [ReadOnly(false)]
        [Column("P0200017", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 72)]
        public int? P0200017 { get; set; }

        [ReadOnly(false)]
        [Column("P0200018", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 73)]
        public int? P0200018 { get; set; }

        [ReadOnly(false)]
        [Column("P0200019", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 74)]
        public int? P0200019 { get; set; }

        [ReadOnly(false)]
        [Column("P0200020", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 75)]
        public int? P0200020 { get; set; }

        [ReadOnly(false)]
        [Column("P0200021", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 76)]
        public int? P0200021 { get; set; }

        [ReadOnly(false)]
        [Column("P0200022", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 77)]
        public int? P0200022 { get; set; }

        [ReadOnly(false)]
        [Column("P0200023", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 78)]
        public int? P0200023 { get; set; }

        [ReadOnly(false)]
        [Column("P0200024", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 79)]
        public int? P0200024 { get; set; }

        [ReadOnly(false)]
        [Column("P0200025", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 80)]
        public int? P0200025 { get; set; }

        [ReadOnly(false)]
        [Column("P0200026", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Households with no people under 18 years:", ShortName = "Households with no people under 18 years:", Order = 81)]
        public int? P0200026 { get; set; }

        [ReadOnly(false)]
        [Column("P0200027", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 82)]
        public int? P0200027 { get; set; }

        [ReadOnly(false)]
        [Column("P0200028", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 83)]
        public int? P0200028 { get; set; }

        [ReadOnly(false)]
        [Column("P0200029", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 84)]
        public int? P0200029 { get; set; }

        [ReadOnly(false)]
        [Column("P0200030", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 85)]
        public int? P0200030 { get; set; }

        [ReadOnly(false)]
        [Column("P0200031", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 86)]
        public int? P0200031 { get; set; }

        [ReadOnly(false)]
        [Column("P0200032", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 87)]
        public int? P0200032 { get; set; }

        [ReadOnly(false)]
        [Column("P0200033", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder", ShortName = "Male householder", Order = 88)]
        public int? P0200033 { get; set; }

        [ReadOnly(false)]
        [Column("P0200034", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder", ShortName = "Female householder", Order = 89)]
        public int? P0200034 { get; set; }

        [ReadOnly(false)]
        [Column("P0210001", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 90)]
        public int? P0210001 { get; set; }

        [ReadOnly(false)]
        [Column("P0210002", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 64 years:", ShortName = "Householder 15 to 64 years:", Order = 91)]
        public int? P0210002 { get; set; }

        [ReadOnly(false)]
        [Column("P0210003", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 92)]
        public int? P0210003 { get; set; }

        [ReadOnly(false)]
        [Column("P0210004", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 93)]
        public int? P0210004 { get; set; }

        [ReadOnly(false)]
        [Column("P0210005", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years", ShortName = "With related children under 18 years", Order = 94)]
        public int? P0210005 { get; set; }

        [ReadOnly(false)]
        [Column("P0210006", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 95)]
        public int? P0210006 { get; set; }

        [ReadOnly(false)]
        [Column("P0210007", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 96)]
        public int? P0210007 { get; set; }

        [ReadOnly(false)]
        [Column("P0210008", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 97)]
        public int? P0210008 { get; set; }

        [ReadOnly(false)]
        [Column("P0210009", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years", ShortName = "With related children under 18 years", Order = 98)]
        public int? P0210009 { get; set; }

        [ReadOnly(false)]
        [Column("P0210010", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 99)]
        public int? P0210010 { get; set; }

        [ReadOnly(false)]
        [Column("P0210011", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 100)]
        public int? P0210011 { get; set; }

        [ReadOnly(false)]
        [Column("P0210012", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years", ShortName = "With related children under 18 years", Order = 101)]
        public int? P0210012 { get; set; }

        [ReadOnly(false)]
        [Column("P0210013", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 102)]
        public int? P0210013 { get; set; }

        [ReadOnly(false)]
        [Column("P0210014", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 103)]
        public int? P0210014 { get; set; }

        [ReadOnly(false)]
        [Column("P0210015", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 104)]
        public int? P0210015 { get; set; }

        [ReadOnly(false)]
        [Column("P0210016", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 105)]
        public int? P0210016 { get; set; }

        [ReadOnly(false)]
        [Column("P0210017", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over:", ShortName = "Householder 65 years and over:", Order = 106)]
        public int? P0210017 { get; set; }

        [ReadOnly(false)]
        [Column("P0210018", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 107)]
        public int? P0210018 { get; set; }

        [ReadOnly(false)]
        [Column("P0210019", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 108)]
        public int? P0210019 { get; set; }

        [ReadOnly(false)]
        [Column("P0210020", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years", ShortName = "With related children under 18 years", Order = 109)]
        public int? P0210020 { get; set; }

        [ReadOnly(false)]
        [Column("P0210021", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 110)]
        public int? P0210021 { get; set; }

        [ReadOnly(false)]
        [Column("P0210022", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 111)]
        public int? P0210022 { get; set; }

        [ReadOnly(false)]
        [Column("P0210023", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 112)]
        public int? P0210023 { get; set; }

        [ReadOnly(false)]
        [Column("P0210024", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years", ShortName = "With related children under 18 years", Order = 113)]
        public int? P0210024 { get; set; }

        [ReadOnly(false)]
        [Column("P0210025", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 114)]
        public int? P0210025 { get; set; }

        [ReadOnly(false)]
        [Column("P0210026", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 115)]
        public int? P0210026 { get; set; }

        [ReadOnly(false)]
        [Column("P0210027", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years", ShortName = "With related children under 18 years", Order = 116)]
        public int? P0210027 { get; set; }

        [ReadOnly(false)]
        [Column("P0210028", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 117)]
        public int? P0210028 { get; set; }

        [ReadOnly(false)]
        [Column("P0210029", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 118)]
        public int? P0210029 { get; set; }

        [ReadOnly(false)]
        [Column("P0210030", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 119)]
        public int? P0210030 { get; set; }

        [ReadOnly(false)]
        [Column("P0210031", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 120)]
        public int? P0210031 { get; set; }

        [ReadOnly(false)]
        [Column("P0220001", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 121)]
        public int? P0220001 { get; set; }

        [ReadOnly(false)]
        [Column("P0220002", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 122)]
        public int? P0220002 { get; set; }

        [ReadOnly(false)]
        [Column("P0220003", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 123)]
        public int? P0220003 { get; set; }

        [ReadOnly(false)]
        [Column("P0220004", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 124)]
        public int? P0220004 { get; set; }

        [ReadOnly(false)]
        [Column("P0220005", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 125)]
        public int? P0220005 { get; set; }

        [ReadOnly(false)]
        [Column("P0220006", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 126)]
        public int? P0220006 { get; set; }

        [ReadOnly(false)]
        [Column("P0220007", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 127)]
        public int? P0220007 { get; set; }

        [ReadOnly(false)]
        [Column("P0220008", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 128)]
        public int? P0220008 { get; set; }

        [ReadOnly(false)]
        [Column("P0220009", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 129)]
        public int? P0220009 { get; set; }

        [ReadOnly(false)]
        [Column("P0220010", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 130)]
        public int? P0220010 { get; set; }

        [ReadOnly(false)]
        [Column("P0220011", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 131)]
        public int? P0220011 { get; set; }

        [ReadOnly(false)]
        [Column("P0220012", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 132)]
        public int? P0220012 { get; set; }

        [ReadOnly(false)]
        [Column("P0220013", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 133)]
        public int? P0220013 { get; set; }

        [ReadOnly(false)]
        [Column("P0220014", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 134)]
        public int? P0220014 { get; set; }

        [ReadOnly(false)]
        [Column("P0220015", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 135)]
        public int? P0220015 { get; set; }

        [ReadOnly(false)]
        [Column("P0220016", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 136)]
        public int? P0220016 { get; set; }

        [ReadOnly(false)]
        [Column("P0220017", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 137)]
        public int? P0220017 { get; set; }

        [ReadOnly(false)]
        [Column("P0220018", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 138)]
        public int? P0220018 { get; set; }

        [ReadOnly(false)]
        [Column("P0220019", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 139)]
        public int? P0220019 { get; set; }

        [ReadOnly(false)]
        [Column("P0220020", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 140)]
        public int? P0220020 { get; set; }

        [ReadOnly(false)]
        [Column("P0220021", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 141)]
        public int? P0220021 { get; set; }

        [ReadOnly(false)]
        [Column("P0230001", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 142)]
        public int? P0230001 { get; set; }

        [ReadOnly(false)]
        [Column("P0230002", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Households with one or more people 60 years and over:", ShortName = "Households with one or more people 60 years and over:", Order = 143)]
        public int? P0230002 { get; set; }

        [ReadOnly(false)]
        [Column("P0230003", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 144)]
        public int? P0230003 { get; set; }

        [ReadOnly(false)]
        [Column("P0230004", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 145)]
        public int? P0230004 { get; set; }

        [ReadOnly(false)]
        [Column("P0230005", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 146)]
        public int? P0230005 { get; set; }

        [ReadOnly(false)]
        [Column("P0230006", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 147)]
        public int? P0230006 { get; set; }

        [ReadOnly(false)]
        [Column("P0230007", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 148)]
        public int? P0230007 { get; set; }

        [ReadOnly(false)]
        [Column("P0230008", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households", ShortName = "Nonfamily households", Order = 149)]
        public int? P0230008 { get; set; }

        [ReadOnly(false)]
        [Column("P0230009", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Households with no people 60 years and over:", ShortName = "Households with no people 60 years and over:", Order = 150)]
        public int? P0230009 { get; set; }

        [ReadOnly(false)]
        [Column("P0230010", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 151)]
        public int? P0230010 { get; set; }

        [ReadOnly(false)]
        [Column("P0230011", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 152)]
        public int? P0230011 { get; set; }

        [ReadOnly(false)]
        [Column("P0230012", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 153)]
        public int? P0230012 { get; set; }

        [ReadOnly(false)]
        [Column("P0230013", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 154)]
        public int? P0230013 { get; set; }

        [ReadOnly(false)]
        [Column("P0230014", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 155)]
        public int? P0230014 { get; set; }

        [ReadOnly(false)]
        [Column("P0230015", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households", ShortName = "Nonfamily households", Order = 156)]
        public int? P0230015 { get; set; }

        [ReadOnly(false)]
        [Column("P0240001", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 157)]
        public int? P0240001 { get; set; }

        [ReadOnly(false)]
        [Column("P0240002", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Households with one or more people 60 years and over:", ShortName = "Households with one or more people 60 years and over:", Order = 158)]
        public int? P0240002 { get; set; }

        [ReadOnly(false)]
        [Column("P0240003", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 159)]
        public int? P0240003 { get; set; }

        [ReadOnly(false)]
        [Column("P0240004", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-or-more-person household:", ShortName = "2-or-more-person household:", Order = 160)]
        public int? P0240004 { get; set; }

        [ReadOnly(false)]
        [Column("P0240005", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households", ShortName = "Family households", Order = 161)]
        public int? P0240005 { get; set; }

        [ReadOnly(false)]
        [Column("P0240006", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households", ShortName = "Nonfamily households", Order = 162)]
        public int? P0240006 { get; set; }

        [ReadOnly(false)]
        [Column("P0240007", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Households with no people 60 years and over:", ShortName = "Households with no people 60 years and over:", Order = 163)]
        public int? P0240007 { get; set; }

        [ReadOnly(false)]
        [Column("P0240008", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 164)]
        public int? P0240008 { get; set; }

        [ReadOnly(false)]
        [Column("P0240009", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-or-more-person household:", ShortName = "2-or-more-person household:", Order = 165)]
        public int? P0240009 { get; set; }

        [ReadOnly(false)]
        [Column("P0240010", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households", ShortName = "Family households", Order = 166)]
        public int? P0240010 { get; set; }

        [ReadOnly(false)]
        [Column("P0240011", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households", ShortName = "Nonfamily households", Order = 167)]
        public int? P0240011 { get; set; }

        [ReadOnly(false)]
        [Column("P0250001", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 168)]
        public int? P0250001 { get; set; }

        [ReadOnly(false)]
        [Column("P0250002", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Households with one or more people 65 years and over:", ShortName = "Households with one or more people 65 years and over:", Order = 169)]
        public int? P0250002 { get; set; }

        [ReadOnly(false)]
        [Column("P0250003", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 170)]
        public int? P0250003 { get; set; }

        [ReadOnly(false)]
        [Column("P0250004", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-or-more-person household:", ShortName = "2-or-more-person household:", Order = 171)]
        public int? P0250004 { get; set; }

        [ReadOnly(false)]
        [Column("P0250005", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households", ShortName = "Family households", Order = 172)]
        public int? P0250005 { get; set; }

        [ReadOnly(false)]
        [Column("P0250006", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households", ShortName = "Nonfamily households", Order = 173)]
        public int? P0250006 { get; set; }

        [ReadOnly(false)]
        [Column("P0250007", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Households with no people 65 years and over:", ShortName = "Households with no people 65 years and over:", Order = 174)]
        public int? P0250007 { get; set; }

        [ReadOnly(false)]
        [Column("P0250008", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 175)]
        public int? P0250008 { get; set; }

        [ReadOnly(false)]
        [Column("P0250009", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-or-more-person household:", ShortName = "2-or-more-person household:", Order = 176)]
        public int? P0250009 { get; set; }

        [ReadOnly(false)]
        [Column("P0250010", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households", ShortName = "Family households", Order = 177)]
        public int? P0250010 { get; set; }

        [ReadOnly(false)]
        [Column("P0250011", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households", ShortName = "Nonfamily households", Order = 178)]
        public int? P0250011 { get; set; }

        [ReadOnly(false)]
        [Column("P0260001", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 179)]
        public int? P0260001 { get; set; }

        [ReadOnly(false)]
        [Column("P0260002", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Households with one or more people 75 years and over:", ShortName = "Households with one or more people 75 years and over:", Order = 180)]
        public int? P0260002 { get; set; }

        [ReadOnly(false)]
        [Column("P0260003", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 181)]
        public int? P0260003 { get; set; }

        [ReadOnly(false)]
        [Column("P0260004", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-or-more-person household:", ShortName = "2-or-more-person household:", Order = 182)]
        public int? P0260004 { get; set; }

        [ReadOnly(false)]
        [Column("P0260005", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households", ShortName = "Family households", Order = 183)]
        public int? P0260005 { get; set; }

        [ReadOnly(false)]
        [Column("P0260006", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households", ShortName = "Nonfamily households", Order = 184)]
        public int? P0260006 { get; set; }

        [ReadOnly(false)]
        [Column("P0260007", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Households with no people 75 years and over:", ShortName = "Households with no people 75 years and over:", Order = 185)]
        public int? P0260007 { get; set; }

        [ReadOnly(false)]
        [Column("P0260008", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 186)]
        public int? P0260008 { get; set; }

        [ReadOnly(false)]
        [Column("P0260009", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-or-more-person household:", ShortName = "2-or-more-person household:", Order = 187)]
        public int? P0260009 { get; set; }

        [ReadOnly(false)]
        [Column("P0260010", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households", ShortName = "Family households", Order = 188)]
        public int? P0260010 { get; set; }

        [ReadOnly(false)]
        [Column("P0260011", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households", ShortName = "Nonfamily households", Order = 189)]
        public int? P0260011 { get; set; }

        [ReadOnly(false)]
        [Column("P0270001", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 190)]
        public int? P0270001 { get; set; }

        [ReadOnly(false)]
        [Column("P0270002", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Households with one or more nonrelatives", ShortName = "Households with one or more nonrelatives", Order = 191)]
        public int? P0270002 { get; set; }

        [ReadOnly(false)]
        [Column("P0270003", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Households with no nonrelatives", ShortName = "Households with no nonrelatives", Order = 192)]
        public int? P0270003 { get; set; }

        [ReadOnly(false)]
        [Column("P0280001", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 193)]
        public int? P0280001 { get; set; }

        [ReadOnly(false)]
        [Column("P0280002", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 194)]
        public int? P0280002 { get; set; }

        [ReadOnly(false)]
        [Column("P0280003", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 195)]
        public int? P0280003 { get; set; }

        [ReadOnly(false)]
        [Column("P0280004", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 196)]
        public int? P0280004 { get; set; }

        [ReadOnly(false)]
        [Column("P0280005", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 197)]
        public int? P0280005 { get; set; }

        [ReadOnly(false)]
        [Column("P0280006", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 198)]
        public int? P0280006 { get; set; }

        [ReadOnly(false)]
        [Column("P0280007", Order = 199)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 199)]
        public int? P0280007 { get; set; }

        [ReadOnly(false)]
        [Column("P0280008", Order = 200)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 200)]
        public int? P0280008 { get; set; }

        [ReadOnly(false)]
        [Column("P0280009", Order = 201)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 201)]
        public int? P0280009 { get; set; }

        [ReadOnly(false)]
        [Column("P0280010", Order = 202)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 202)]
        public int? P0280010 { get; set; }

        [ReadOnly(false)]
        [Column("P0280011", Order = 203)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 203)]
        public int? P0280011 { get; set; }

        [ReadOnly(false)]
        [Column("P0280012", Order = 204)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 204)]
        public int? P0280012 { get; set; }

        [ReadOnly(false)]
        [Column("P0280013", Order = 205)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 205)]
        public int? P0280013 { get; set; }

        [ReadOnly(false)]
        [Column("P0280014", Order = 206)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 206)]
        public int? P0280014 { get; set; }

        [ReadOnly(false)]
        [Column("P0280015", Order = 207)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 207)]
        public int? P0280015 { get; set; }

        [ReadOnly(false)]
        [Column("P0280016", Order = 208)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 208)]
        public int? P0280016 { get; set; }

        [ReadOnly(false)]
        [Column("P0290001", Order = 209)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 209)]
        public int? P0290001 { get; set; }

        [ReadOnly(false)]
        [Column("P0290002", Order = 210)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 210)]
        public int? P0290002 { get; set; }

        [ReadOnly(false)]
        [Column("P0290003", Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 211)]
        public int? P0290003 { get; set; }

        [ReadOnly(false)]
        [Column("P0290004", Order = 212)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder:", ShortName = "Householder:", Order = 212)]
        public int? P0290004 { get; set; }

        [ReadOnly(false)]
        [Column("P0290005", Order = 213)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 213)]
        public int? P0290005 { get; set; }

        [ReadOnly(false)]
        [Column("P0290006", Order = 214)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 214)]
        public int? P0290006 { get; set; }

        [ReadOnly(false)]
        [Column("P0290007", Order = 215)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spouse", ShortName = "Spouse", Order = 215)]
        public int? P0290007 { get; set; }

        [ReadOnly(false)]
        [Column("P0290008", Order = 216)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Biological child", ShortName = "Biological child", Order = 216)]
        public int? P0290008 { get; set; }

        [ReadOnly(false)]
        [Column("P0290009", Order = 217)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Adopted child", ShortName = "Adopted child", Order = 217)]
        public int? P0290009 { get; set; }

        [ReadOnly(false)]
        [Column("P0290010", Order = 218)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Stepchild", ShortName = "Stepchild", Order = 218)]
        public int? P0290010 { get; set; }

        [ReadOnly(false)]
        [Column("P0290011", Order = 219)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 219)]
        public int? P0290011 { get; set; }

        [ReadOnly(false)]
        [Column("P0290012", Order = 220)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 220)]
        public int? P0290012 { get; set; }

        [ReadOnly(false)]
        [Column("P0290013", Order = 221)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent", ShortName = "Parent", Order = 221)]
        public int? P0290013 { get; set; }

        [ReadOnly(false)]
        [Column("P0290014", Order = 222)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 222)]
        public int? P0290014 { get; set; }

        [ReadOnly(false)]
        [Column("P0290015", Order = 223)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 223)]
        public int? P0290015 { get; set; }

        [ReadOnly(false)]
        [Column("P0290016", Order = 224)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 224)]
        public int? P0290016 { get; set; }

        [ReadOnly(false)]
        [Column("P0290017", Order = 225)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 225)]
        public int? P0290017 { get; set; }

        [ReadOnly(false)]
        [Column("P0290018", Order = 226)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 226)]
        public int? P0290018 { get; set; }

        [ReadOnly(false)]
        [Column("P0290019", Order = 227)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 227)]
        public int? P0290019 { get; set; }

        [ReadOnly(false)]
        [Column("P0290020", Order = 228)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 228)]
        public int? P0290020 { get; set; }

        [ReadOnly(false)]
        [Column("P0290021", Order = 229)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 229)]
        public int? P0290021 { get; set; }

        [ReadOnly(false)]
        [Column("P0290022", Order = 230)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 230)]
        public int? P0290022 { get; set; }

        [ReadOnly(false)]
        [Column("P0290023", Order = 231)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 231)]
        public int? P0290023 { get; set; }

        [ReadOnly(false)]
        [Column("P0290024", Order = 232)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 232)]
        public int? P0290024 { get; set; }

        [ReadOnly(false)]
        [Column("P0290025", Order = 233)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 233)]
        public int? P0290025 { get; set; }

        [ReadOnly(false)]
        [Column("P0290026", Order = 234)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 234)]
        public int? P0290026 { get; set; }

        [ReadOnly(false)]
        [Column("P0290027", Order = 235)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 235)]
        public int? P0290027 { get; set; }

        [ReadOnly(false)]
        [Column("P0290028", Order = 236)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 236)]
        public int? P0290028 { get; set; }

        [ReadOnly(false)]
        [Column("P0300001", Order = 237)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 237)]
        public int? P0300001 { get; set; }

        [ReadOnly(false)]
        [Column("P0300002", Order = 238)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 238)]
        public int? P0300002 { get; set; }

        [ReadOnly(false)]
        [Column("P0300003", Order = 239)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 239)]
        public int? P0300003 { get; set; }

        [ReadOnly(false)]
        [Column("P0300004", Order = 240)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In other family:", ShortName = "In other family:", Order = 240)]
        public int? P0300004 { get; set; }

        [ReadOnly(false)]
        [Column("P0300005", Order = 241)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In male householder, no wife present family", ShortName = "In male householder, no wife present family", Order = 241)]
        public int? P0300005 { get; set; }

        [ReadOnly(false)]
        [Column("P0300006", Order = 242)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In female householder, no husband present family", ShortName = "In female householder, no husband present family", Order = 242)]
        public int? P0300006 { get; set; }

        [ReadOnly(false)]
        [Column("P0300007", Order = 243)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 243)]
        public int? P0300007 { get; set; }

        [ReadOnly(false)]
        [Column("P0300008", Order = 244)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households with a male householder:", ShortName = "In households with a male householder:", Order = 244)]
        public int? P0300008 { get; set; }

        [ReadOnly(false)]
        [Column("P0300009", Order = 245)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In 1-person household", ShortName = "In 1-person household", Order = 245)]
        public int? P0300009 { get; set; }

        [ReadOnly(false)]
        [Column("P0300010", Order = 246)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In 2-or-more-person household", ShortName = "In 2-or-more-person household", Order = 246)]
        public int? P0300010 { get; set; }

        [ReadOnly(false)]
        [Column("P0300011", Order = 247)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households with a female householder:", ShortName = "In households with a female householder:", Order = 247)]
        public int? P0300011 { get; set; }

        [ReadOnly(false)]
        [Column("P0300012", Order = 248)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In 1-person household", ShortName = "In 1-person household", Order = 248)]
        public int? P0300012 { get; set; }

        [ReadOnly(false)]
        [Column("P0300013", Order = 249)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In 2-or-more-person household", ShortName = "In 2-or-more-person household", Order = 249)]
        public int? P0300013 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1CongressionalDistricts113_SF1_00005(string csvLine) : base(csvLine) { }

        public SF1CongressionalDistricts113_SF1_00005(string[] values) : base(values) { }

        public SF1CongressionalDistricts113_SF1_00005(OleDbDataReader reader, CensusFileType fileType)
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
                LOGRECNO = (int?)reader[4];
            }
            if (reader[5] != DBNull.Value)
            {
                P0150001 = (int?)reader[5];
            }
            if (reader[6] != DBNull.Value)
            {
                P0150002 = (int?)reader[6];
            }
            if (reader[7] != DBNull.Value)
            {
                P0150003 = (int?)reader[7];
            }
            if (reader[8] != DBNull.Value)
            {
                P0150004 = (int?)reader[8];
            }
            if (reader[9] != DBNull.Value)
            {
                P0150005 = (int?)reader[9];
            }
            if (reader[10] != DBNull.Value)
            {
                P0150006 = (int?)reader[10];
            }
            if (reader[11] != DBNull.Value)
            {
                P0150007 = (int?)reader[11];
            }
            if (reader[12] != DBNull.Value)
            {
                P0150008 = (int?)reader[12];
            }
            if (reader[13] != DBNull.Value)
            {
                P0150009 = (int?)reader[13];
            }
            if (reader[14] != DBNull.Value)
            {
                P0150010 = (int?)reader[14];
            }
            if (reader[15] != DBNull.Value)
            {
                P0150011 = (int?)reader[15];
            }
            if (reader[16] != DBNull.Value)
            {
                P0150012 = (int?)reader[16];
            }
            if (reader[17] != DBNull.Value)
            {
                P0150013 = (int?)reader[17];
            }
            if (reader[18] != DBNull.Value)
            {
                P0150014 = (int?)reader[18];
            }
            if (reader[19] != DBNull.Value)
            {
                P0150015 = (int?)reader[19];
            }
            if (reader[20] != DBNull.Value)
            {
                P0150016 = (int?)reader[20];
            }
            if (reader[21] != DBNull.Value)
            {
                P0150017 = (int?)reader[21];
            }
            if (reader[22] != DBNull.Value)
            {
                P0160001 = (int?)reader[22];
            }
            if (reader[23] != DBNull.Value)
            {
                P0160002 = (int?)reader[23];
            }
            if (reader[24] != DBNull.Value)
            {
                P0160003 = (int?)reader[24];
            }
            if (reader[25] != DBNull.Value)
            {
                P0170001 = (double?)reader[25];
            }
            if (reader[26] != DBNull.Value)
            {
                P0170002 = (double?)reader[26];
            }
            if (reader[27] != DBNull.Value)
            {
                P0170003 = (double?)reader[27];
            }
            if (reader[28] != DBNull.Value)
            {
                P0180001 = (int?)reader[28];
            }
            if (reader[29] != DBNull.Value)
            {
                P0180002 = (int?)reader[29];
            }
            if (reader[30] != DBNull.Value)
            {
                P0180003 = (int?)reader[30];
            }
            if (reader[31] != DBNull.Value)
            {
                P0180004 = (int?)reader[31];
            }
            if (reader[32] != DBNull.Value)
            {
                P0180005 = (int?)reader[32];
            }
            if (reader[33] != DBNull.Value)
            {
                P0180006 = (int?)reader[33];
            }
            if (reader[34] != DBNull.Value)
            {
                P0180007 = (int?)reader[34];
            }
            if (reader[35] != DBNull.Value)
            {
                P0180008 = (int?)reader[35];
            }
            if (reader[36] != DBNull.Value)
            {
                P0180009 = (int?)reader[36];
            }
            if (reader[37] != DBNull.Value)
            {
                P0190001 = (int?)reader[37];
            }
            if (reader[38] != DBNull.Value)
            {
                P0190002 = (int?)reader[38];
            }
            if (reader[39] != DBNull.Value)
            {
                P0190003 = (int?)reader[39];
            }
            if (reader[40] != DBNull.Value)
            {
                P0190004 = (int?)reader[40];
            }
            if (reader[41] != DBNull.Value)
            {
                P0190005 = (int?)reader[41];
            }
            if (reader[42] != DBNull.Value)
            {
                P0190006 = (int?)reader[42];
            }
            if (reader[43] != DBNull.Value)
            {
                P0190007 = (int?)reader[43];
            }
            if (reader[44] != DBNull.Value)
            {
                P0190008 = (int?)reader[44];
            }
            if (reader[45] != DBNull.Value)
            {
                P0190009 = (int?)reader[45];
            }
            if (reader[46] != DBNull.Value)
            {
                P0190010 = (int?)reader[46];
            }
            if (reader[47] != DBNull.Value)
            {
                P0190011 = (int?)reader[47];
            }
            if (reader[48] != DBNull.Value)
            {
                P0190012 = (int?)reader[48];
            }
            if (reader[49] != DBNull.Value)
            {
                P0190013 = (int?)reader[49];
            }
            if (reader[50] != DBNull.Value)
            {
                P0190014 = (int?)reader[50];
            }
            if (reader[51] != DBNull.Value)
            {
                P0190015 = (int?)reader[51];
            }
            if (reader[52] != DBNull.Value)
            {
                P0190016 = (int?)reader[52];
            }
            if (reader[53] != DBNull.Value)
            {
                P0190017 = (int?)reader[53];
            }
            if (reader[54] != DBNull.Value)
            {
                P0190018 = (int?)reader[54];
            }
            if (reader[55] != DBNull.Value)
            {
                P0190019 = (int?)reader[55];
            }
            if (reader[56] != DBNull.Value)
            {
                P0200001 = (int?)reader[56];
            }
            if (reader[57] != DBNull.Value)
            {
                P0200002 = (int?)reader[57];
            }
            if (reader[58] != DBNull.Value)
            {
                P0200003 = (int?)reader[58];
            }
            if (reader[59] != DBNull.Value)
            {
                P0200004 = (int?)reader[59];
            }
            if (reader[60] != DBNull.Value)
            {
                P0200005 = (int?)reader[60];
            }
            if (reader[61] != DBNull.Value)
            {
                P0200006 = (int?)reader[61];
            }
            if (reader[62] != DBNull.Value)
            {
                P0200007 = (int?)reader[62];
            }
            if (reader[63] != DBNull.Value)
            {
                P0200008 = (int?)reader[63];
            }
            if (reader[64] != DBNull.Value)
            {
                P0200009 = (int?)reader[64];
            }
            if (reader[65] != DBNull.Value)
            {
                P0200010 = (int?)reader[65];
            }
            if (reader[66] != DBNull.Value)
            {
                P0200011 = (int?)reader[66];
            }
            if (reader[67] != DBNull.Value)
            {
                P0200012 = (int?)reader[67];
            }
            if (reader[68] != DBNull.Value)
            {
                P0200013 = (int?)reader[68];
            }
            if (reader[69] != DBNull.Value)
            {
                P0200014 = (int?)reader[69];
            }
            if (reader[70] != DBNull.Value)
            {
                P0200015 = (int?)reader[70];
            }
            if (reader[71] != DBNull.Value)
            {
                P0200016 = (int?)reader[71];
            }
            if (reader[72] != DBNull.Value)
            {
                P0200017 = (int?)reader[72];
            }
            if (reader[73] != DBNull.Value)
            {
                P0200018 = (int?)reader[73];
            }
            if (reader[74] != DBNull.Value)
            {
                P0200019 = (int?)reader[74];
            }
            if (reader[75] != DBNull.Value)
            {
                P0200020 = (int?)reader[75];
            }
            if (reader[76] != DBNull.Value)
            {
                P0200021 = (int?)reader[76];
            }
            if (reader[77] != DBNull.Value)
            {
                P0200022 = (int?)reader[77];
            }
            if (reader[78] != DBNull.Value)
            {
                P0200023 = (int?)reader[78];
            }
            if (reader[79] != DBNull.Value)
            {
                P0200024 = (int?)reader[79];
            }
            if (reader[80] != DBNull.Value)
            {
                P0200025 = (int?)reader[80];
            }
            if (reader[81] != DBNull.Value)
            {
                P0200026 = (int?)reader[81];
            }
            if (reader[82] != DBNull.Value)
            {
                P0200027 = (int?)reader[82];
            }
            if (reader[83] != DBNull.Value)
            {
                P0200028 = (int?)reader[83];
            }
            if (reader[84] != DBNull.Value)
            {
                P0200029 = (int?)reader[84];
            }
            if (reader[85] != DBNull.Value)
            {
                P0200030 = (int?)reader[85];
            }
            if (reader[86] != DBNull.Value)
            {
                P0200031 = (int?)reader[86];
            }
            if (reader[87] != DBNull.Value)
            {
                P0200032 = (int?)reader[87];
            }
            if (reader[88] != DBNull.Value)
            {
                P0200033 = (int?)reader[88];
            }
            if (reader[89] != DBNull.Value)
            {
                P0200034 = (int?)reader[89];
            }
            if (reader[90] != DBNull.Value)
            {
                P0210001 = (int?)reader[90];
            }
            if (reader[91] != DBNull.Value)
            {
                P0210002 = (int?)reader[91];
            }
            if (reader[92] != DBNull.Value)
            {
                P0210003 = (int?)reader[92];
            }
            if (reader[93] != DBNull.Value)
            {
                P0210004 = (int?)reader[93];
            }
            if (reader[94] != DBNull.Value)
            {
                P0210005 = (int?)reader[94];
            }
            if (reader[95] != DBNull.Value)
            {
                P0210006 = (int?)reader[95];
            }
            if (reader[96] != DBNull.Value)
            {
                P0210007 = (int?)reader[96];
            }
            if (reader[97] != DBNull.Value)
            {
                P0210008 = (int?)reader[97];
            }
            if (reader[98] != DBNull.Value)
            {
                P0210009 = (int?)reader[98];
            }
            if (reader[99] != DBNull.Value)
            {
                P0210010 = (int?)reader[99];
            }
            if (reader[100] != DBNull.Value)
            {
                P0210011 = (int?)reader[100];
            }
            if (reader[101] != DBNull.Value)
            {
                P0210012 = (int?)reader[101];
            }
            if (reader[102] != DBNull.Value)
            {
                P0210013 = (int?)reader[102];
            }
            if (reader[103] != DBNull.Value)
            {
                P0210014 = (int?)reader[103];
            }
            if (reader[104] != DBNull.Value)
            {
                P0210015 = (int?)reader[104];
            }
            if (reader[105] != DBNull.Value)
            {
                P0210016 = (int?)reader[105];
            }
            if (reader[106] != DBNull.Value)
            {
                P0210017 = (int?)reader[106];
            }
            if (reader[107] != DBNull.Value)
            {
                P0210018 = (int?)reader[107];
            }
            if (reader[108] != DBNull.Value)
            {
                P0210019 = (int?)reader[108];
            }
            if (reader[109] != DBNull.Value)
            {
                P0210020 = (int?)reader[109];
            }
            if (reader[110] != DBNull.Value)
            {
                P0210021 = (int?)reader[110];
            }
            if (reader[111] != DBNull.Value)
            {
                P0210022 = (int?)reader[111];
            }
            if (reader[112] != DBNull.Value)
            {
                P0210023 = (int?)reader[112];
            }
            if (reader[113] != DBNull.Value)
            {
                P0210024 = (int?)reader[113];
            }
            if (reader[114] != DBNull.Value)
            {
                P0210025 = (int?)reader[114];
            }
            if (reader[115] != DBNull.Value)
            {
                P0210026 = (int?)reader[115];
            }
            if (reader[116] != DBNull.Value)
            {
                P0210027 = (int?)reader[116];
            }
            if (reader[117] != DBNull.Value)
            {
                P0210028 = (int?)reader[117];
            }
            if (reader[118] != DBNull.Value)
            {
                P0210029 = (int?)reader[118];
            }
            if (reader[119] != DBNull.Value)
            {
                P0210030 = (int?)reader[119];
            }
            if (reader[120] != DBNull.Value)
            {
                P0210031 = (int?)reader[120];
            }
            if (reader[121] != DBNull.Value)
            {
                P0220001 = (int?)reader[121];
            }
            if (reader[122] != DBNull.Value)
            {
                P0220002 = (int?)reader[122];
            }
            if (reader[123] != DBNull.Value)
            {
                P0220003 = (int?)reader[123];
            }
            if (reader[124] != DBNull.Value)
            {
                P0220004 = (int?)reader[124];
            }
            if (reader[125] != DBNull.Value)
            {
                P0220005 = (int?)reader[125];
            }
            if (reader[126] != DBNull.Value)
            {
                P0220006 = (int?)reader[126];
            }
            if (reader[127] != DBNull.Value)
            {
                P0220007 = (int?)reader[127];
            }
            if (reader[128] != DBNull.Value)
            {
                P0220008 = (int?)reader[128];
            }
            if (reader[129] != DBNull.Value)
            {
                P0220009 = (int?)reader[129];
            }
            if (reader[130] != DBNull.Value)
            {
                P0220010 = (int?)reader[130];
            }
            if (reader[131] != DBNull.Value)
            {
                P0220011 = (int?)reader[131];
            }
            if (reader[132] != DBNull.Value)
            {
                P0220012 = (int?)reader[132];
            }
            if (reader[133] != DBNull.Value)
            {
                P0220013 = (int?)reader[133];
            }
            if (reader[134] != DBNull.Value)
            {
                P0220014 = (int?)reader[134];
            }
            if (reader[135] != DBNull.Value)
            {
                P0220015 = (int?)reader[135];
            }
            if (reader[136] != DBNull.Value)
            {
                P0220016 = (int?)reader[136];
            }
            if (reader[137] != DBNull.Value)
            {
                P0220017 = (int?)reader[137];
            }
            if (reader[138] != DBNull.Value)
            {
                P0220018 = (int?)reader[138];
            }
            if (reader[139] != DBNull.Value)
            {
                P0220019 = (int?)reader[139];
            }
            if (reader[140] != DBNull.Value)
            {
                P0220020 = (int?)reader[140];
            }
            if (reader[141] != DBNull.Value)
            {
                P0220021 = (int?)reader[141];
            }
            if (reader[142] != DBNull.Value)
            {
                P0230001 = (int?)reader[142];
            }
            if (reader[143] != DBNull.Value)
            {
                P0230002 = (int?)reader[143];
            }
            if (reader[144] != DBNull.Value)
            {
                P0230003 = (int?)reader[144];
            }
            if (reader[145] != DBNull.Value)
            {
                P0230004 = (int?)reader[145];
            }
            if (reader[146] != DBNull.Value)
            {
                P0230005 = (int?)reader[146];
            }
            if (reader[147] != DBNull.Value)
            {
                P0230006 = (int?)reader[147];
            }
            if (reader[148] != DBNull.Value)
            {
                P0230007 = (int?)reader[148];
            }
            if (reader[149] != DBNull.Value)
            {
                P0230008 = (int?)reader[149];
            }
            if (reader[150] != DBNull.Value)
            {
                P0230009 = (int?)reader[150];
            }
            if (reader[151] != DBNull.Value)
            {
                P0230010 = (int?)reader[151];
            }
            if (reader[152] != DBNull.Value)
            {
                P0230011 = (int?)reader[152];
            }
            if (reader[153] != DBNull.Value)
            {
                P0230012 = (int?)reader[153];
            }
            if (reader[154] != DBNull.Value)
            {
                P0230013 = (int?)reader[154];
            }
            if (reader[155] != DBNull.Value)
            {
                P0230014 = (int?)reader[155];
            }
            if (reader[156] != DBNull.Value)
            {
                P0230015 = (int?)reader[156];
            }
            if (reader[157] != DBNull.Value)
            {
                P0240001 = (int?)reader[157];
            }
            if (reader[158] != DBNull.Value)
            {
                P0240002 = (int?)reader[158];
            }
            if (reader[159] != DBNull.Value)
            {
                P0240003 = (int?)reader[159];
            }
            if (reader[160] != DBNull.Value)
            {
                P0240004 = (int?)reader[160];
            }
            if (reader[161] != DBNull.Value)
            {
                P0240005 = (int?)reader[161];
            }
            if (reader[162] != DBNull.Value)
            {
                P0240006 = (int?)reader[162];
            }
            if (reader[163] != DBNull.Value)
            {
                P0240007 = (int?)reader[163];
            }
            if (reader[164] != DBNull.Value)
            {
                P0240008 = (int?)reader[164];
            }
            if (reader[165] != DBNull.Value)
            {
                P0240009 = (int?)reader[165];
            }
            if (reader[166] != DBNull.Value)
            {
                P0240010 = (int?)reader[166];
            }
            if (reader[167] != DBNull.Value)
            {
                P0240011 = (int?)reader[167];
            }
            if (reader[168] != DBNull.Value)
            {
                P0250001 = (int?)reader[168];
            }
            if (reader[169] != DBNull.Value)
            {
                P0250002 = (int?)reader[169];
            }
            if (reader[170] != DBNull.Value)
            {
                P0250003 = (int?)reader[170];
            }
            if (reader[171] != DBNull.Value)
            {
                P0250004 = (int?)reader[171];
            }
            if (reader[172] != DBNull.Value)
            {
                P0250005 = (int?)reader[172];
            }
            if (reader[173] != DBNull.Value)
            {
                P0250006 = (int?)reader[173];
            }
            if (reader[174] != DBNull.Value)
            {
                P0250007 = (int?)reader[174];
            }
            if (reader[175] != DBNull.Value)
            {
                P0250008 = (int?)reader[175];
            }
            if (reader[176] != DBNull.Value)
            {
                P0250009 = (int?)reader[176];
            }
            if (reader[177] != DBNull.Value)
            {
                P0250010 = (int?)reader[177];
            }
            if (reader[178] != DBNull.Value)
            {
                P0250011 = (int?)reader[178];
            }
            if (reader[179] != DBNull.Value)
            {
                P0260001 = (int?)reader[179];
            }
            if (reader[180] != DBNull.Value)
            {
                P0260002 = (int?)reader[180];
            }
            if (reader[181] != DBNull.Value)
            {
                P0260003 = (int?)reader[181];
            }
            if (reader[182] != DBNull.Value)
            {
                P0260004 = (int?)reader[182];
            }
            if (reader[183] != DBNull.Value)
            {
                P0260005 = (int?)reader[183];
            }
            if (reader[184] != DBNull.Value)
            {
                P0260006 = (int?)reader[184];
            }
            if (reader[185] != DBNull.Value)
            {
                P0260007 = (int?)reader[185];
            }
            if (reader[186] != DBNull.Value)
            {
                P0260008 = (int?)reader[186];
            }
            if (reader[187] != DBNull.Value)
            {
                P0260009 = (int?)reader[187];
            }
            if (reader[188] != DBNull.Value)
            {
                P0260010 = (int?)reader[188];
            }
            if (reader[189] != DBNull.Value)
            {
                P0260011 = (int?)reader[189];
            }
            if (reader[190] != DBNull.Value)
            {
                P0270001 = (int?)reader[190];
            }
            if (reader[191] != DBNull.Value)
            {
                P0270002 = (int?)reader[191];
            }
            if (reader[192] != DBNull.Value)
            {
                P0270003 = (int?)reader[192];
            }
            if (reader[193] != DBNull.Value)
            {
                P0280001 = (int?)reader[193];
            }
            if (reader[194] != DBNull.Value)
            {
                P0280002 = (int?)reader[194];
            }
            if (reader[195] != DBNull.Value)
            {
                P0280003 = (int?)reader[195];
            }
            if (reader[196] != DBNull.Value)
            {
                P0280004 = (int?)reader[196];
            }
            if (reader[197] != DBNull.Value)
            {
                P0280005 = (int?)reader[197];
            }
            if (reader[198] != DBNull.Value)
            {
                P0280006 = (int?)reader[198];
            }
            if (reader[199] != DBNull.Value)
            {
                P0280007 = (int?)reader[199];
            }
            if (reader[200] != DBNull.Value)
            {
                P0280008 = (int?)reader[200];
            }
            if (reader[201] != DBNull.Value)
            {
                P0280009 = (int?)reader[201];
            }
            if (reader[202] != DBNull.Value)
            {
                P0280010 = (int?)reader[202];
            }
            if (reader[203] != DBNull.Value)
            {
                P0280011 = (int?)reader[203];
            }
            if (reader[204] != DBNull.Value)
            {
                P0280012 = (int?)reader[204];
            }
            if (reader[205] != DBNull.Value)
            {
                P0280013 = (int?)reader[205];
            }
            if (reader[206] != DBNull.Value)
            {
                P0280014 = (int?)reader[206];
            }
            if (reader[207] != DBNull.Value)
            {
                P0280015 = (int?)reader[207];
            }
            if (reader[208] != DBNull.Value)
            {
                P0280016 = (int?)reader[208];
            }
            if (reader[209] != DBNull.Value)
            {
                P0290001 = (int?)reader[209];
            }
            if (reader[210] != DBNull.Value)
            {
                P0290002 = (int?)reader[210];
            }
            if (reader[211] != DBNull.Value)
            {
                P0290003 = (int?)reader[211];
            }
            if (reader[212] != DBNull.Value)
            {
                P0290004 = (int?)reader[212];
            }
            if (reader[213] != DBNull.Value)
            {
                P0290005 = (int?)reader[213];
            }
            if (reader[214] != DBNull.Value)
            {
                P0290006 = (int?)reader[214];
            }
            if (reader[215] != DBNull.Value)
            {
                P0290007 = (int?)reader[215];
            }
            if (reader[216] != DBNull.Value)
            {
                P0290008 = (int?)reader[216];
            }
            if (reader[217] != DBNull.Value)
            {
                P0290009 = (int?)reader[217];
            }
            if (reader[218] != DBNull.Value)
            {
                P0290010 = (int?)reader[218];
            }
            if (reader[219] != DBNull.Value)
            {
                P0290011 = (int?)reader[219];
            }
            if (reader[220] != DBNull.Value)
            {
                P0290012 = (int?)reader[220];
            }
            if (reader[221] != DBNull.Value)
            {
                P0290013 = (int?)reader[221];
            }
            if (reader[222] != DBNull.Value)
            {
                P0290014 = (int?)reader[222];
            }
            if (reader[223] != DBNull.Value)
            {
                P0290015 = (int?)reader[223];
            }
            if (reader[224] != DBNull.Value)
            {
                P0290016 = (int?)reader[224];
            }
            if (reader[225] != DBNull.Value)
            {
                P0290017 = (int?)reader[225];
            }
            if (reader[226] != DBNull.Value)
            {
                P0290018 = (int?)reader[226];
            }
            if (reader[227] != DBNull.Value)
            {
                P0290019 = (int?)reader[227];
            }
            if (reader[228] != DBNull.Value)
            {
                P0290020 = (int?)reader[228];
            }
            if (reader[229] != DBNull.Value)
            {
                P0290021 = (int?)reader[229];
            }
            if (reader[230] != DBNull.Value)
            {
                P0290022 = (int?)reader[230];
            }
            if (reader[231] != DBNull.Value)
            {
                P0290023 = (int?)reader[231];
            }
            if (reader[232] != DBNull.Value)
            {
                P0290024 = (int?)reader[232];
            }
            if (reader[233] != DBNull.Value)
            {
                P0290025 = (int?)reader[233];
            }
            if (reader[234] != DBNull.Value)
            {
                P0290026 = (int?)reader[234];
            }
            if (reader[235] != DBNull.Value)
            {
                P0290027 = (int?)reader[235];
            }
            if (reader[236] != DBNull.Value)
            {
                P0290028 = (int?)reader[236];
            }
            if (reader[237] != DBNull.Value)
            {
                P0300001 = (int?)reader[237];
            }
            if (reader[238] != DBNull.Value)
            {
                P0300002 = (int?)reader[238];
            }
            if (reader[239] != DBNull.Value)
            {
                P0300003 = (int?)reader[239];
            }
            if (reader[240] != DBNull.Value)
            {
                P0300004 = (int?)reader[240];
            }
            if (reader[241] != DBNull.Value)
            {
                P0300005 = (int?)reader[241];
            }
            if (reader[242] != DBNull.Value)
            {
                P0300006 = (int?)reader[242];
            }
            if (reader[243] != DBNull.Value)
            {
                P0300007 = (int?)reader[243];
            }
            if (reader[244] != DBNull.Value)
            {
                P0300008 = (int?)reader[244];
            }
            if (reader[245] != DBNull.Value)
            {
                P0300009 = (int?)reader[245];
            }
            if (reader[246] != DBNull.Value)
            {
                P0300010 = (int?)reader[246];
            }
            if (reader[247] != DBNull.Value)
            {
                P0300011 = (int?)reader[247];
            }
            if (reader[248] != DBNull.Value)
            {
                P0300012 = (int?)reader[248];
            }
            if (reader[249] != DBNull.Value)
            {
                P0300013 = (int?)reader[249];
            }
        }
        #endregion Constructors
    }
}
