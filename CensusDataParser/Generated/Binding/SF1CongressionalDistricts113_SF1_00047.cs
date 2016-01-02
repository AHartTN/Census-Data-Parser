#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2016 11:18 AM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1CongressionalDistricts113_SF1_00047.cs
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

    public class SF1CongressionalDistricts113_SF1_00047 : BaseModel
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
        [Column("HCT0010001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public int? HCT0010001 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 6)]
        public int? HCT0010002 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not Hispanic or Latino householder:", ShortName = "Not Hispanic or Latino householder:", Order = 7)]
        public int? HCT0010003 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 8)]
        public int? HCT0010004 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 9)]
        public int? HCT0010005 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 10)]
        public int? HCT0010006 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 11)]
        public int? HCT0010007 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 12)]
        public int? HCT0010008 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 13)]
        public int? HCT0010009 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 14)]
        public int? HCT0010010 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hispanic or Latino householder:", ShortName = "Hispanic or Latino householder:", Order = 15)]
        public int? HCT0010011 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 16)]
        public int? HCT0010012 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 17)]
        public int? HCT0010013 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 18)]
        public int? HCT0010014 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 19)]
        public int? HCT0010015 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 20)]
        public int? HCT0010016 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010017", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 21)]
        public int? HCT0010017 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010018", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 22)]
        public int? HCT0010018 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010019", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 23)]
        public int? HCT0010019 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010020", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not Hispanic or Latino householder:", ShortName = "Not Hispanic or Latino householder:", Order = 24)]
        public int? HCT0010020 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010021", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 25)]
        public int? HCT0010021 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010022", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 26)]
        public int? HCT0010022 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010023", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 27)]
        public int? HCT0010023 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010024", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 28)]
        public int? HCT0010024 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010025", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 29)]
        public int? HCT0010025 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010026", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 30)]
        public int? HCT0010026 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010027", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 31)]
        public int? HCT0010027 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010028", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hispanic or Latino householder:", ShortName = "Hispanic or Latino householder:", Order = 32)]
        public int? HCT0010028 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010029", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 33)]
        public int? HCT0010029 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010030", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 34)]
        public int? HCT0010030 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010031", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 35)]
        public int? HCT0010031 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010032", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 36)]
        public int? HCT0010032 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010033", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 37)]
        public int? HCT0010033 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010034", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 38)]
        public int? HCT0010034 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010035", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 39)]
        public int? HCT0010035 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020001", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 40)]
        public int? HCT0020001 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020002", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 41)]
        public int? HCT0020002 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020003", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 42)]
        public int? HCT0020003 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020004", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 43)]
        public int? HCT0020004 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020005", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 44)]
        public int? HCT0020005 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020006", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 45)]
        public int? HCT0020006 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020007", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 46)]
        public int? HCT0020007 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020008", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter-occupied:", ShortName = "Renter-occupied:", Order = 47)]
        public int? HCT0020008 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020009", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 48)]
        public int? HCT0020009 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020010", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 49)]
        public int? HCT0020010 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020011", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 50)]
        public int? HCT0020011 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020012", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 51)]
        public int? HCT0020012 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020013", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 52)]
        public int? HCT0020013 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030001", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 53)]
        public int? HCT0030001 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030002", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 54)]
        public int? HCT0030002 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030003", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 55)]
        public int? HCT0030003 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030004", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 56)]
        public int? HCT0030004 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030005", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 57)]
        public int? HCT0030005 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030006", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 58)]
        public int? HCT0030006 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030007", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 59)]
        public int? HCT0030007 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030008", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter-occupied:", ShortName = "Renter-occupied:", Order = 60)]
        public int? HCT0030008 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030009", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 61)]
        public int? HCT0030009 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030010", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 62)]
        public int? HCT0030010 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030011", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 63)]
        public int? HCT0030011 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030012", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 64)]
        public int? HCT0030012 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030013", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 65)]
        public int? HCT0030013 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040001", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 66)]
        public int? HCT0040001 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040002", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 67)]
        public int? HCT0040002 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040003", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With children under 18 years:", ShortName = "With children under 18 years:", Order = 68)]
        public int? HCT0040003 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040004", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 69)]
        public int? HCT0040004 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040005", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 70)]
        public int? HCT0040005 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040006", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 71)]
        public int? HCT0040006 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040007", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No children under 18 years", ShortName = "No children under 18 years", Order = 72)]
        public int? HCT0040007 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040008", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter-occupied:", ShortName = "Renter-occupied:", Order = 73)]
        public int? HCT0040008 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040009", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With children under 18 years:", ShortName = "With children under 18 years:", Order = 74)]
        public int? HCT0040009 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040010", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 75)]
        public int? HCT0040010 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040011", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 76)]
        public int? HCT0040011 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040012", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 77)]
        public int? HCT0040012 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040013", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No children under 18 years", ShortName = "No children under 18 years", Order = 78)]
        public int? HCT0040013 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1CongressionalDistricts113_SF1_00047(string csvLine) : base(csvLine) { }

        public SF1CongressionalDistricts113_SF1_00047(string[] values) : base(values) { }

        public SF1CongressionalDistricts113_SF1_00047(OleDbDataReader reader, CensusFileType fileType)
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
                HCT0010001 = (int?)reader[5];
            }
            if (reader[6] != DBNull.Value)
            {
                HCT0010002 = (int?)reader[6];
            }
            if (reader[7] != DBNull.Value)
            {
                HCT0010003 = (int?)reader[7];
            }
            if (reader[8] != DBNull.Value)
            {
                HCT0010004 = (int?)reader[8];
            }
            if (reader[9] != DBNull.Value)
            {
                HCT0010005 = (int?)reader[9];
            }
            if (reader[10] != DBNull.Value)
            {
                HCT0010006 = (int?)reader[10];
            }
            if (reader[11] != DBNull.Value)
            {
                HCT0010007 = (int?)reader[11];
            }
            if (reader[12] != DBNull.Value)
            {
                HCT0010008 = (int?)reader[12];
            }
            if (reader[13] != DBNull.Value)
            {
                HCT0010009 = (int?)reader[13];
            }
            if (reader[14] != DBNull.Value)
            {
                HCT0010010 = (int?)reader[14];
            }
            if (reader[15] != DBNull.Value)
            {
                HCT0010011 = (int?)reader[15];
            }
            if (reader[16] != DBNull.Value)
            {
                HCT0010012 = (int?)reader[16];
            }
            if (reader[17] != DBNull.Value)
            {
                HCT0010013 = (int?)reader[17];
            }
            if (reader[18] != DBNull.Value)
            {
                HCT0010014 = (int?)reader[18];
            }
            if (reader[19] != DBNull.Value)
            {
                HCT0010015 = (int?)reader[19];
            }
            if (reader[20] != DBNull.Value)
            {
                HCT0010016 = (int?)reader[20];
            }
            if (reader[21] != DBNull.Value)
            {
                HCT0010017 = (int?)reader[21];
            }
            if (reader[22] != DBNull.Value)
            {
                HCT0010018 = (int?)reader[22];
            }
            if (reader[23] != DBNull.Value)
            {
                HCT0010019 = (int?)reader[23];
            }
            if (reader[24] != DBNull.Value)
            {
                HCT0010020 = (int?)reader[24];
            }
            if (reader[25] != DBNull.Value)
            {
                HCT0010021 = (int?)reader[25];
            }
            if (reader[26] != DBNull.Value)
            {
                HCT0010022 = (int?)reader[26];
            }
            if (reader[27] != DBNull.Value)
            {
                HCT0010023 = (int?)reader[27];
            }
            if (reader[28] != DBNull.Value)
            {
                HCT0010024 = (int?)reader[28];
            }
            if (reader[29] != DBNull.Value)
            {
                HCT0010025 = (int?)reader[29];
            }
            if (reader[30] != DBNull.Value)
            {
                HCT0010026 = (int?)reader[30];
            }
            if (reader[31] != DBNull.Value)
            {
                HCT0010027 = (int?)reader[31];
            }
            if (reader[32] != DBNull.Value)
            {
                HCT0010028 = (int?)reader[32];
            }
            if (reader[33] != DBNull.Value)
            {
                HCT0010029 = (int?)reader[33];
            }
            if (reader[34] != DBNull.Value)
            {
                HCT0010030 = (int?)reader[34];
            }
            if (reader[35] != DBNull.Value)
            {
                HCT0010031 = (int?)reader[35];
            }
            if (reader[36] != DBNull.Value)
            {
                HCT0010032 = (int?)reader[36];
            }
            if (reader[37] != DBNull.Value)
            {
                HCT0010033 = (int?)reader[37];
            }
            if (reader[38] != DBNull.Value)
            {
                HCT0010034 = (int?)reader[38];
            }
            if (reader[39] != DBNull.Value)
            {
                HCT0010035 = (int?)reader[39];
            }
            if (reader[40] != DBNull.Value)
            {
                HCT0020001 = (int?)reader[40];
            }
            if (reader[41] != DBNull.Value)
            {
                HCT0020002 = (int?)reader[41];
            }
            if (reader[42] != DBNull.Value)
            {
                HCT0020003 = (int?)reader[42];
            }
            if (reader[43] != DBNull.Value)
            {
                HCT0020004 = (int?)reader[43];
            }
            if (reader[44] != DBNull.Value)
            {
                HCT0020005 = (int?)reader[44];
            }
            if (reader[45] != DBNull.Value)
            {
                HCT0020006 = (int?)reader[45];
            }
            if (reader[46] != DBNull.Value)
            {
                HCT0020007 = (int?)reader[46];
            }
            if (reader[47] != DBNull.Value)
            {
                HCT0020008 = (int?)reader[47];
            }
            if (reader[48] != DBNull.Value)
            {
                HCT0020009 = (int?)reader[48];
            }
            if (reader[49] != DBNull.Value)
            {
                HCT0020010 = (int?)reader[49];
            }
            if (reader[50] != DBNull.Value)
            {
                HCT0020011 = (int?)reader[50];
            }
            if (reader[51] != DBNull.Value)
            {
                HCT0020012 = (int?)reader[51];
            }
            if (reader[52] != DBNull.Value)
            {
                HCT0020013 = (int?)reader[52];
            }
            if (reader[53] != DBNull.Value)
            {
                HCT0030001 = (int?)reader[53];
            }
            if (reader[54] != DBNull.Value)
            {
                HCT0030002 = (int?)reader[54];
            }
            if (reader[55] != DBNull.Value)
            {
                HCT0030003 = (int?)reader[55];
            }
            if (reader[56] != DBNull.Value)
            {
                HCT0030004 = (int?)reader[56];
            }
            if (reader[57] != DBNull.Value)
            {
                HCT0030005 = (int?)reader[57];
            }
            if (reader[58] != DBNull.Value)
            {
                HCT0030006 = (int?)reader[58];
            }
            if (reader[59] != DBNull.Value)
            {
                HCT0030007 = (int?)reader[59];
            }
            if (reader[60] != DBNull.Value)
            {
                HCT0030008 = (int?)reader[60];
            }
            if (reader[61] != DBNull.Value)
            {
                HCT0030009 = (int?)reader[61];
            }
            if (reader[62] != DBNull.Value)
            {
                HCT0030010 = (int?)reader[62];
            }
            if (reader[63] != DBNull.Value)
            {
                HCT0030011 = (int?)reader[63];
            }
            if (reader[64] != DBNull.Value)
            {
                HCT0030012 = (int?)reader[64];
            }
            if (reader[65] != DBNull.Value)
            {
                HCT0030013 = (int?)reader[65];
            }
            if (reader[66] != DBNull.Value)
            {
                HCT0040001 = (int?)reader[66];
            }
            if (reader[67] != DBNull.Value)
            {
                HCT0040002 = (int?)reader[67];
            }
            if (reader[68] != DBNull.Value)
            {
                HCT0040003 = (int?)reader[68];
            }
            if (reader[69] != DBNull.Value)
            {
                HCT0040004 = (int?)reader[69];
            }
            if (reader[70] != DBNull.Value)
            {
                HCT0040005 = (int?)reader[70];
            }
            if (reader[71] != DBNull.Value)
            {
                HCT0040006 = (int?)reader[71];
            }
            if (reader[72] != DBNull.Value)
            {
                HCT0040007 = (int?)reader[72];
            }
            if (reader[73] != DBNull.Value)
            {
                HCT0040008 = (int?)reader[73];
            }
            if (reader[74] != DBNull.Value)
            {
                HCT0040009 = (int?)reader[74];
            }
            if (reader[75] != DBNull.Value)
            {
                HCT0040010 = (int?)reader[75];
            }
            if (reader[76] != DBNull.Value)
            {
                HCT0040011 = (int?)reader[76];
            }
            if (reader[77] != DBNull.Value)
            {
                HCT0040012 = (int?)reader[77];
            }
            if (reader[78] != DBNull.Value)
            {
                HCT0040013 = (int?)reader[78];
            }
        }
        #endregion Constructors
    }
}
