#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2016 11:17 AM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1CongressionalDistricts113_SF1_00045.cs
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

    public class SF1CongressionalDistricts113_SF1_00045 : BaseModel
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
        [Column("H011G0001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population in occupied housing units:", ShortName = "Population in occupied housing units:", Order = 5)]
        public int? H011G0001 { get; set; }

        [ReadOnly(false)]
        [Column("H011G0002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owned with a mortgage or a loan", ShortName = "Owned with a mortgage or a loan", Order = 6)]
        public int? H011G0002 { get; set; }

        [ReadOnly(false)]
        [Column("H011G0003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owned free and clear", ShortName = "Owned free and clear", Order = 7)]
        public int? H011G0003 { get; set; }

        [ReadOnly(false)]
        [Column("H011G0004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 8)]
        public int? H011G0004 { get; set; }

        [ReadOnly(false)]
        [Column("H011H0001", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population in occupied housing units:", ShortName = "Population in occupied housing units:", Order = 9)]
        public int? H011H0001 { get; set; }

        [ReadOnly(false)]
        [Column("H011H0002", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owned with a mortgage or a loan", ShortName = "Owned with a mortgage or a loan", Order = 10)]
        public int? H011H0002 { get; set; }

        [ReadOnly(false)]
        [Column("H011H0003", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owned free and clear", ShortName = "Owned free and clear", Order = 11)]
        public int? H011H0003 { get; set; }

        [ReadOnly(false)]
        [Column("H011H0004", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 12)]
        public int? H011H0004 { get; set; }

        [ReadOnly(false)]
        [Column("H011I0001", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population in occupied housing units:", ShortName = "Population in occupied housing units:", Order = 13)]
        public int? H011I0001 { get; set; }

        [ReadOnly(false)]
        [Column("H011I0002", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owned with a mortgage or a loan", ShortName = "Owned with a mortgage or a loan", Order = 14)]
        public int? H011I0002 { get; set; }

        [ReadOnly(false)]
        [Column("H011I0003", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owned free and clear", ShortName = "Owned free and clear", Order = 15)]
        public int? H011I0003 { get; set; }

        [ReadOnly(false)]
        [Column("H011I0004", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 16)]
        public int? H011I0004 { get; set; }

        [ReadOnly(false)]
        [Column("H012A0001", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total", ShortName = "Total", Order = 17)]
        public double? H012A0001 { get; set; }

        [ReadOnly(false)]
        [Column("H012A0002", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied", ShortName = "Owner occupied", Order = 18)]
        public double? H012A0002 { get; set; }

        [ReadOnly(false)]
        [Column("H012A0003", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 19)]
        public double? H012A0003 { get; set; }

        [ReadOnly(false)]
        [Column("H012B0001", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total", ShortName = "Total", Order = 20)]
        public double? H012B0001 { get; set; }

        [ReadOnly(false)]
        [Column("H012B0002", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied", ShortName = "Owner occupied", Order = 21)]
        public double? H012B0002 { get; set; }

        [ReadOnly(false)]
        [Column("H012B0003", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 22)]
        public double? H012B0003 { get; set; }

        [ReadOnly(false)]
        [Column("H012C0001", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total", ShortName = "Total", Order = 23)]
        public double? H012C0001 { get; set; }

        [ReadOnly(false)]
        [Column("H012C0002", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied", ShortName = "Owner occupied", Order = 24)]
        public double? H012C0002 { get; set; }

        [ReadOnly(false)]
        [Column("H012C0003", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 25)]
        public double? H012C0003 { get; set; }

        [ReadOnly(false)]
        [Column("H012D0001", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total", ShortName = "Total", Order = 26)]
        public double? H012D0001 { get; set; }

        [ReadOnly(false)]
        [Column("H012D0002", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied", ShortName = "Owner occupied", Order = 27)]
        public double? H012D0002 { get; set; }

        [ReadOnly(false)]
        [Column("H012D0003", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 28)]
        public double? H012D0003 { get; set; }

        [ReadOnly(false)]
        [Column("H012E0001", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total", ShortName = "Total", Order = 29)]
        public double? H012E0001 { get; set; }

        [ReadOnly(false)]
        [Column("H012E0002", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied", ShortName = "Owner occupied", Order = 30)]
        public double? H012E0002 { get; set; }

        [ReadOnly(false)]
        [Column("H012E0003", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 31)]
        public double? H012E0003 { get; set; }

        [ReadOnly(false)]
        [Column("H012F0001", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total", ShortName = "Total", Order = 32)]
        public double? H012F0001 { get; set; }

        [ReadOnly(false)]
        [Column("H012F0002", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied", ShortName = "Owner occupied", Order = 33)]
        public double? H012F0002 { get; set; }

        [ReadOnly(false)]
        [Column("H012F0003", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 34)]
        public double? H012F0003 { get; set; }

        [ReadOnly(false)]
        [Column("H012G0001", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total", ShortName = "Total", Order = 35)]
        public double? H012G0001 { get; set; }

        [ReadOnly(false)]
        [Column("H012G0002", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied", ShortName = "Owner occupied", Order = 36)]
        public double? H012G0002 { get; set; }

        [ReadOnly(false)]
        [Column("H012G0003", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 37)]
        public double? H012G0003 { get; set; }

        [ReadOnly(false)]
        [Column("H012H0001", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total", ShortName = "Total", Order = 38)]
        public double? H012H0001 { get; set; }

        [ReadOnly(false)]
        [Column("H012H0002", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied", ShortName = "Owner occupied", Order = 39)]
        public double? H012H0002 { get; set; }

        [ReadOnly(false)]
        [Column("H012H0003", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 40)]
        public double? H012H0003 { get; set; }

        [ReadOnly(false)]
        [Column("H012I0001", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total", ShortName = "Total", Order = 41)]
        public double? H012I0001 { get; set; }

        [ReadOnly(false)]
        [Column("H012I0002", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied", ShortName = "Owner occupied", Order = 42)]
        public double? H012I0002 { get; set; }

        [ReadOnly(false)]
        [Column("H012I0003", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 43)]
        public double? H012I0003 { get; set; }

        [ReadOnly(false)]
        [Column("H016A0001", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 44)]
        public int? H016A0001 { get; set; }

        [ReadOnly(false)]
        [Column("H016A0002", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 45)]
        public int? H016A0002 { get; set; }

        [ReadOnly(false)]
        [Column("H016A0003", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 46)]
        public int? H016A0003 { get; set; }

        [ReadOnly(false)]
        [Column("H016A0004", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 47)]
        public int? H016A0004 { get; set; }

        [ReadOnly(false)]
        [Column("H016A0005", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 48)]
        public int? H016A0005 { get; set; }

        [ReadOnly(false)]
        [Column("H016A0006", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 49)]
        public int? H016A0006 { get; set; }

        [ReadOnly(false)]
        [Column("H016A0007", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 50)]
        public int? H016A0007 { get; set; }

        [ReadOnly(false)]
        [Column("H016A0008", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 51)]
        public int? H016A0008 { get; set; }

        [ReadOnly(false)]
        [Column("H016A0009", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 52)]
        public int? H016A0009 { get; set; }

        [ReadOnly(false)]
        [Column("H016A0010", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 53)]
        public int? H016A0010 { get; set; }

        [ReadOnly(false)]
        [Column("H016A0011", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 54)]
        public int? H016A0011 { get; set; }

        [ReadOnly(false)]
        [Column("H016A0012", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 55)]
        public int? H016A0012 { get; set; }

        [ReadOnly(false)]
        [Column("H016A0013", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 56)]
        public int? H016A0013 { get; set; }

        [ReadOnly(false)]
        [Column("H016A0014", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 57)]
        public int? H016A0014 { get; set; }

        [ReadOnly(false)]
        [Column("H016A0015", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 58)]
        public int? H016A0015 { get; set; }

        [ReadOnly(false)]
        [Column("H016A0016", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 59)]
        public int? H016A0016 { get; set; }

        [ReadOnly(false)]
        [Column("H016A0017", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 60)]
        public int? H016A0017 { get; set; }

        [ReadOnly(false)]
        [Column("H016B0001", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 61)]
        public int? H016B0001 { get; set; }

        [ReadOnly(false)]
        [Column("H016B0002", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 62)]
        public int? H016B0002 { get; set; }

        [ReadOnly(false)]
        [Column("H016B0003", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 63)]
        public int? H016B0003 { get; set; }

        [ReadOnly(false)]
        [Column("H016B0004", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 64)]
        public int? H016B0004 { get; set; }

        [ReadOnly(false)]
        [Column("H016B0005", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 65)]
        public int? H016B0005 { get; set; }

        [ReadOnly(false)]
        [Column("H016B0006", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 66)]
        public int? H016B0006 { get; set; }

        [ReadOnly(false)]
        [Column("H016B0007", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 67)]
        public int? H016B0007 { get; set; }

        [ReadOnly(false)]
        [Column("H016B0008", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 68)]
        public int? H016B0008 { get; set; }

        [ReadOnly(false)]
        [Column("H016B0009", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 69)]
        public int? H016B0009 { get; set; }

        [ReadOnly(false)]
        [Column("H016B0010", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 70)]
        public int? H016B0010 { get; set; }

        [ReadOnly(false)]
        [Column("H016B0011", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 71)]
        public int? H016B0011 { get; set; }

        [ReadOnly(false)]
        [Column("H016B0012", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 72)]
        public int? H016B0012 { get; set; }

        [ReadOnly(false)]
        [Column("H016B0013", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 73)]
        public int? H016B0013 { get; set; }

        [ReadOnly(false)]
        [Column("H016B0014", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 74)]
        public int? H016B0014 { get; set; }

        [ReadOnly(false)]
        [Column("H016B0015", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 75)]
        public int? H016B0015 { get; set; }

        [ReadOnly(false)]
        [Column("H016B0016", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 76)]
        public int? H016B0016 { get; set; }

        [ReadOnly(false)]
        [Column("H016B0017", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 77)]
        public int? H016B0017 { get; set; }

        [ReadOnly(false)]
        [Column("H016C0001", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 78)]
        public int? H016C0001 { get; set; }

        [ReadOnly(false)]
        [Column("H016C0002", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 79)]
        public int? H016C0002 { get; set; }

        [ReadOnly(false)]
        [Column("H016C0003", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 80)]
        public int? H016C0003 { get; set; }

        [ReadOnly(false)]
        [Column("H016C0004", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 81)]
        public int? H016C0004 { get; set; }

        [ReadOnly(false)]
        [Column("H016C0005", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 82)]
        public int? H016C0005 { get; set; }

        [ReadOnly(false)]
        [Column("H016C0006", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 83)]
        public int? H016C0006 { get; set; }

        [ReadOnly(false)]
        [Column("H016C0007", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 84)]
        public int? H016C0007 { get; set; }

        [ReadOnly(false)]
        [Column("H016C0008", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 85)]
        public int? H016C0008 { get; set; }

        [ReadOnly(false)]
        [Column("H016C0009", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 86)]
        public int? H016C0009 { get; set; }

        [ReadOnly(false)]
        [Column("H016C0010", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 87)]
        public int? H016C0010 { get; set; }

        [ReadOnly(false)]
        [Column("H016C0011", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 88)]
        public int? H016C0011 { get; set; }

        [ReadOnly(false)]
        [Column("H016C0012", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 89)]
        public int? H016C0012 { get; set; }

        [ReadOnly(false)]
        [Column("H016C0013", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 90)]
        public int? H016C0013 { get; set; }

        [ReadOnly(false)]
        [Column("H016C0014", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 91)]
        public int? H016C0014 { get; set; }

        [ReadOnly(false)]
        [Column("H016C0015", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 92)]
        public int? H016C0015 { get; set; }

        [ReadOnly(false)]
        [Column("H016C0016", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 93)]
        public int? H016C0016 { get; set; }

        [ReadOnly(false)]
        [Column("H016C0017", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 94)]
        public int? H016C0017 { get; set; }

        [ReadOnly(false)]
        [Column("H016D0001", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 95)]
        public int? H016D0001 { get; set; }

        [ReadOnly(false)]
        [Column("H016D0002", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 96)]
        public int? H016D0002 { get; set; }

        [ReadOnly(false)]
        [Column("H016D0003", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 97)]
        public int? H016D0003 { get; set; }

        [ReadOnly(false)]
        [Column("H016D0004", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 98)]
        public int? H016D0004 { get; set; }

        [ReadOnly(false)]
        [Column("H016D0005", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 99)]
        public int? H016D0005 { get; set; }

        [ReadOnly(false)]
        [Column("H016D0006", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 100)]
        public int? H016D0006 { get; set; }

        [ReadOnly(false)]
        [Column("H016D0007", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 101)]
        public int? H016D0007 { get; set; }

        [ReadOnly(false)]
        [Column("H016D0008", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 102)]
        public int? H016D0008 { get; set; }

        [ReadOnly(false)]
        [Column("H016D0009", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 103)]
        public int? H016D0009 { get; set; }

        [ReadOnly(false)]
        [Column("H016D0010", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 104)]
        public int? H016D0010 { get; set; }

        [ReadOnly(false)]
        [Column("H016D0011", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 105)]
        public int? H016D0011 { get; set; }

        [ReadOnly(false)]
        [Column("H016D0012", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 106)]
        public int? H016D0012 { get; set; }

        [ReadOnly(false)]
        [Column("H016D0013", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 107)]
        public int? H016D0013 { get; set; }

        [ReadOnly(false)]
        [Column("H016D0014", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 108)]
        public int? H016D0014 { get; set; }

        [ReadOnly(false)]
        [Column("H016D0015", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 109)]
        public int? H016D0015 { get; set; }

        [ReadOnly(false)]
        [Column("H016D0016", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 110)]
        public int? H016D0016 { get; set; }

        [ReadOnly(false)]
        [Column("H016D0017", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 111)]
        public int? H016D0017 { get; set; }

        [ReadOnly(false)]
        [Column("H016E0001", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 112)]
        public int? H016E0001 { get; set; }

        [ReadOnly(false)]
        [Column("H016E0002", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 113)]
        public int? H016E0002 { get; set; }

        [ReadOnly(false)]
        [Column("H016E0003", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 114)]
        public int? H016E0003 { get; set; }

        [ReadOnly(false)]
        [Column("H016E0004", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 115)]
        public int? H016E0004 { get; set; }

        [ReadOnly(false)]
        [Column("H016E0005", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 116)]
        public int? H016E0005 { get; set; }

        [ReadOnly(false)]
        [Column("H016E0006", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 117)]
        public int? H016E0006 { get; set; }

        [ReadOnly(false)]
        [Column("H016E0007", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 118)]
        public int? H016E0007 { get; set; }

        [ReadOnly(false)]
        [Column("H016E0008", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 119)]
        public int? H016E0008 { get; set; }

        [ReadOnly(false)]
        [Column("H016E0009", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 120)]
        public int? H016E0009 { get; set; }

        [ReadOnly(false)]
        [Column("H016E0010", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 121)]
        public int? H016E0010 { get; set; }

        [ReadOnly(false)]
        [Column("H016E0011", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 122)]
        public int? H016E0011 { get; set; }

        [ReadOnly(false)]
        [Column("H016E0012", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 123)]
        public int? H016E0012 { get; set; }

        [ReadOnly(false)]
        [Column("H016E0013", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 124)]
        public int? H016E0013 { get; set; }

        [ReadOnly(false)]
        [Column("H016E0014", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 125)]
        public int? H016E0014 { get; set; }

        [ReadOnly(false)]
        [Column("H016E0015", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 126)]
        public int? H016E0015 { get; set; }

        [ReadOnly(false)]
        [Column("H016E0016", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 127)]
        public int? H016E0016 { get; set; }

        [ReadOnly(false)]
        [Column("H016E0017", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 128)]
        public int? H016E0017 { get; set; }

        [ReadOnly(false)]
        [Column("H016F0001", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 129)]
        public int? H016F0001 { get; set; }

        [ReadOnly(false)]
        [Column("H016F0002", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 130)]
        public int? H016F0002 { get; set; }

        [ReadOnly(false)]
        [Column("H016F0003", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 131)]
        public int? H016F0003 { get; set; }

        [ReadOnly(false)]
        [Column("H016F0004", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 132)]
        public int? H016F0004 { get; set; }

        [ReadOnly(false)]
        [Column("H016F0005", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 133)]
        public int? H016F0005 { get; set; }

        [ReadOnly(false)]
        [Column("H016F0006", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 134)]
        public int? H016F0006 { get; set; }

        [ReadOnly(false)]
        [Column("H016F0007", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 135)]
        public int? H016F0007 { get; set; }

        [ReadOnly(false)]
        [Column("H016F0008", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 136)]
        public int? H016F0008 { get; set; }

        [ReadOnly(false)]
        [Column("H016F0009", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 137)]
        public int? H016F0009 { get; set; }

        [ReadOnly(false)]
        [Column("H016F0010", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 138)]
        public int? H016F0010 { get; set; }

        [ReadOnly(false)]
        [Column("H016F0011", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 139)]
        public int? H016F0011 { get; set; }

        [ReadOnly(false)]
        [Column("H016F0012", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 140)]
        public int? H016F0012 { get; set; }

        [ReadOnly(false)]
        [Column("H016F0013", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 141)]
        public int? H016F0013 { get; set; }

        [ReadOnly(false)]
        [Column("H016F0014", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 142)]
        public int? H016F0014 { get; set; }

        [ReadOnly(false)]
        [Column("H016F0015", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 143)]
        public int? H016F0015 { get; set; }

        [ReadOnly(false)]
        [Column("H016F0016", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 144)]
        public int? H016F0016 { get; set; }

        [ReadOnly(false)]
        [Column("H016F0017", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 145)]
        public int? H016F0017 { get; set; }

        [ReadOnly(false)]
        [Column("H016G0001", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 146)]
        public int? H016G0001 { get; set; }

        [ReadOnly(false)]
        [Column("H016G0002", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 147)]
        public int? H016G0002 { get; set; }

        [ReadOnly(false)]
        [Column("H016G0003", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 148)]
        public int? H016G0003 { get; set; }

        [ReadOnly(false)]
        [Column("H016G0004", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 149)]
        public int? H016G0004 { get; set; }

        [ReadOnly(false)]
        [Column("H016G0005", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 150)]
        public int? H016G0005 { get; set; }

        [ReadOnly(false)]
        [Column("H016G0006", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 151)]
        public int? H016G0006 { get; set; }

        [ReadOnly(false)]
        [Column("H016G0007", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 152)]
        public int? H016G0007 { get; set; }

        [ReadOnly(false)]
        [Column("H016G0008", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 153)]
        public int? H016G0008 { get; set; }

        [ReadOnly(false)]
        [Column("H016G0009", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 154)]
        public int? H016G0009 { get; set; }

        [ReadOnly(false)]
        [Column("H016G0010", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 155)]
        public int? H016G0010 { get; set; }

        [ReadOnly(false)]
        [Column("H016G0011", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 156)]
        public int? H016G0011 { get; set; }

        [ReadOnly(false)]
        [Column("H016G0012", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 157)]
        public int? H016G0012 { get; set; }

        [ReadOnly(false)]
        [Column("H016G0013", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 158)]
        public int? H016G0013 { get; set; }

        [ReadOnly(false)]
        [Column("H016G0014", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 159)]
        public int? H016G0014 { get; set; }

        [ReadOnly(false)]
        [Column("H016G0015", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 160)]
        public int? H016G0015 { get; set; }

        [ReadOnly(false)]
        [Column("H016G0016", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 161)]
        public int? H016G0016 { get; set; }

        [ReadOnly(false)]
        [Column("H016G0017", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 162)]
        public int? H016G0017 { get; set; }

        [ReadOnly(false)]
        [Column("H016H0001", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 163)]
        public int? H016H0001 { get; set; }

        [ReadOnly(false)]
        [Column("H016H0002", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 164)]
        public int? H016H0002 { get; set; }

        [ReadOnly(false)]
        [Column("H016H0003", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 165)]
        public int? H016H0003 { get; set; }

        [ReadOnly(false)]
        [Column("H016H0004", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 166)]
        public int? H016H0004 { get; set; }

        [ReadOnly(false)]
        [Column("H016H0005", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 167)]
        public int? H016H0005 { get; set; }

        [ReadOnly(false)]
        [Column("H016H0006", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 168)]
        public int? H016H0006 { get; set; }

        [ReadOnly(false)]
        [Column("H016H0007", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 169)]
        public int? H016H0007 { get; set; }

        [ReadOnly(false)]
        [Column("H016H0008", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 170)]
        public int? H016H0008 { get; set; }

        [ReadOnly(false)]
        [Column("H016H0009", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 171)]
        public int? H016H0009 { get; set; }

        [ReadOnly(false)]
        [Column("H016H0010", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 172)]
        public int? H016H0010 { get; set; }

        [ReadOnly(false)]
        [Column("H016H0011", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 173)]
        public int? H016H0011 { get; set; }

        [ReadOnly(false)]
        [Column("H016H0012", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 174)]
        public int? H016H0012 { get; set; }

        [ReadOnly(false)]
        [Column("H016H0013", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 175)]
        public int? H016H0013 { get; set; }

        [ReadOnly(false)]
        [Column("H016H0014", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 176)]
        public int? H016H0014 { get; set; }

        [ReadOnly(false)]
        [Column("H016H0015", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 177)]
        public int? H016H0015 { get; set; }

        [ReadOnly(false)]
        [Column("H016H0016", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 178)]
        public int? H016H0016 { get; set; }

        [ReadOnly(false)]
        [Column("H016H0017", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 179)]
        public int? H016H0017 { get; set; }

        [ReadOnly(false)]
        [Column("H016I0001", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 180)]
        public int? H016I0001 { get; set; }

        [ReadOnly(false)]
        [Column("H016I0002", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 181)]
        public int? H016I0002 { get; set; }

        [ReadOnly(false)]
        [Column("H016I0003", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 182)]
        public int? H016I0003 { get; set; }

        [ReadOnly(false)]
        [Column("H016I0004", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 183)]
        public int? H016I0004 { get; set; }

        [ReadOnly(false)]
        [Column("H016I0005", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 184)]
        public int? H016I0005 { get; set; }

        [ReadOnly(false)]
        [Column("H016I0006", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 185)]
        public int? H016I0006 { get; set; }

        [ReadOnly(false)]
        [Column("H016I0007", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 186)]
        public int? H016I0007 { get; set; }

        [ReadOnly(false)]
        [Column("H016I0008", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 187)]
        public int? H016I0008 { get; set; }

        [ReadOnly(false)]
        [Column("H016I0009", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 188)]
        public int? H016I0009 { get; set; }

        [ReadOnly(false)]
        [Column("H016I0010", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 189)]
        public int? H016I0010 { get; set; }

        [ReadOnly(false)]
        [Column("H016I0011", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 190)]
        public int? H016I0011 { get; set; }

        [ReadOnly(false)]
        [Column("H016I0012", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 191)]
        public int? H016I0012 { get; set; }

        [ReadOnly(false)]
        [Column("H016I0013", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 192)]
        public int? H016I0013 { get; set; }

        [ReadOnly(false)]
        [Column("H016I0014", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 193)]
        public int? H016I0014 { get; set; }

        [ReadOnly(false)]
        [Column("H016I0015", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 194)]
        public int? H016I0015 { get; set; }

        [ReadOnly(false)]
        [Column("H016I0016", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 195)]
        public int? H016I0016 { get; set; }

        [ReadOnly(false)]
        [Column("H016I0017", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 196)]
        public int? H016I0017 { get; set; }

        [ReadOnly(false)]
        [Column("H017A0001", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 197)]
        public int? H017A0001 { get; set; }

        [ReadOnly(false)]
        [Column("H017A0002", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 198)]
        public int? H017A0002 { get; set; }

        [ReadOnly(false)]
        [Column("H017A0003", Order = 199)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 199)]
        public int? H017A0003 { get; set; }

        [ReadOnly(false)]
        [Column("H017A0004", Order = 200)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 200)]
        public int? H017A0004 { get; set; }

        [ReadOnly(false)]
        [Column("H017A0005", Order = 201)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 201)]
        public int? H017A0005 { get; set; }

        [ReadOnly(false)]
        [Column("H017A0006", Order = 202)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 202)]
        public int? H017A0006 { get; set; }

        [ReadOnly(false)]
        [Column("H017A0007", Order = 203)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 203)]
        public int? H017A0007 { get; set; }

        [ReadOnly(false)]
        [Column("H017A0008", Order = 204)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 204)]
        public int? H017A0008 { get; set; }

        [ReadOnly(false)]
        [Column("H017A0009", Order = 205)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 205)]
        public int? H017A0009 { get; set; }

        [ReadOnly(false)]
        [Column("H017A0010", Order = 206)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 206)]
        public int? H017A0010 { get; set; }

        [ReadOnly(false)]
        [Column("H017A0011", Order = 207)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 207)]
        public int? H017A0011 { get; set; }

        [ReadOnly(false)]
        [Column("H017A0012", Order = 208)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 208)]
        public int? H017A0012 { get; set; }

        [ReadOnly(false)]
        [Column("H017A0013", Order = 209)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 209)]
        public int? H017A0013 { get; set; }

        [ReadOnly(false)]
        [Column("H017A0014", Order = 210)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 210)]
        public int? H017A0014 { get; set; }

        [ReadOnly(false)]
        [Column("H017A0015", Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 211)]
        public int? H017A0015 { get; set; }

        [ReadOnly(false)]
        [Column("H017A0016", Order = 212)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 212)]
        public int? H017A0016 { get; set; }

        [ReadOnly(false)]
        [Column("H017A0017", Order = 213)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 213)]
        public int? H017A0017 { get; set; }

        [ReadOnly(false)]
        [Column("H017A0018", Order = 214)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 214)]
        public int? H017A0018 { get; set; }

        [ReadOnly(false)]
        [Column("H017A0019", Order = 215)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 215)]
        public int? H017A0019 { get; set; }

        [ReadOnly(false)]
        [Column("H017A0020", Order = 216)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 216)]
        public int? H017A0020 { get; set; }

        [ReadOnly(false)]
        [Column("H017A0021", Order = 217)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 217)]
        public int? H017A0021 { get; set; }

        [ReadOnly(false)]
        [Column("H017B0001", Order = 218)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 218)]
        public int? H017B0001 { get; set; }

        [ReadOnly(false)]
        [Column("H017B0002", Order = 219)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 219)]
        public int? H017B0002 { get; set; }

        [ReadOnly(false)]
        [Column("H017B0003", Order = 220)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 220)]
        public int? H017B0003 { get; set; }

        [ReadOnly(false)]
        [Column("H017B0004", Order = 221)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 221)]
        public int? H017B0004 { get; set; }

        [ReadOnly(false)]
        [Column("H017B0005", Order = 222)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 222)]
        public int? H017B0005 { get; set; }

        [ReadOnly(false)]
        [Column("H017B0006", Order = 223)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 223)]
        public int? H017B0006 { get; set; }

        [ReadOnly(false)]
        [Column("H017B0007", Order = 224)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 224)]
        public int? H017B0007 { get; set; }

        [ReadOnly(false)]
        [Column("H017B0008", Order = 225)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 225)]
        public int? H017B0008 { get; set; }

        [ReadOnly(false)]
        [Column("H017B0009", Order = 226)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 226)]
        public int? H017B0009 { get; set; }

        [ReadOnly(false)]
        [Column("H017B0010", Order = 227)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 227)]
        public int? H017B0010 { get; set; }

        [ReadOnly(false)]
        [Column("H017B0011", Order = 228)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 228)]
        public int? H017B0011 { get; set; }

        [ReadOnly(false)]
        [Column("H017B0012", Order = 229)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 229)]
        public int? H017B0012 { get; set; }

        [ReadOnly(false)]
        [Column("H017B0013", Order = 230)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 230)]
        public int? H017B0013 { get; set; }

        [ReadOnly(false)]
        [Column("H017B0014", Order = 231)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 231)]
        public int? H017B0014 { get; set; }

        [ReadOnly(false)]
        [Column("H017B0015", Order = 232)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 232)]
        public int? H017B0015 { get; set; }

        [ReadOnly(false)]
        [Column("H017B0016", Order = 233)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 233)]
        public int? H017B0016 { get; set; }

        [ReadOnly(false)]
        [Column("H017B0017", Order = 234)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 234)]
        public int? H017B0017 { get; set; }

        [ReadOnly(false)]
        [Column("H017B0018", Order = 235)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 235)]
        public int? H017B0018 { get; set; }

        [ReadOnly(false)]
        [Column("H017B0019", Order = 236)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 236)]
        public int? H017B0019 { get; set; }

        [ReadOnly(false)]
        [Column("H017B0020", Order = 237)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 237)]
        public int? H017B0020 { get; set; }

        [ReadOnly(false)]
        [Column("H017B0021", Order = 238)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 238)]
        public int? H017B0021 { get; set; }

        [ReadOnly(false)]
        [Column("H017C0001", Order = 239)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 239)]
        public int? H017C0001 { get; set; }

        [ReadOnly(false)]
        [Column("H017C0002", Order = 240)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 240)]
        public int? H017C0002 { get; set; }

        [ReadOnly(false)]
        [Column("H017C0003", Order = 241)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 241)]
        public int? H017C0003 { get; set; }

        [ReadOnly(false)]
        [Column("H017C0004", Order = 242)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 242)]
        public int? H017C0004 { get; set; }

        [ReadOnly(false)]
        [Column("H017C0005", Order = 243)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 243)]
        public int? H017C0005 { get; set; }

        [ReadOnly(false)]
        [Column("H017C0006", Order = 244)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 244)]
        public int? H017C0006 { get; set; }

        [ReadOnly(false)]
        [Column("H017C0007", Order = 245)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 245)]
        public int? H017C0007 { get; set; }

        [ReadOnly(false)]
        [Column("H017C0008", Order = 246)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 246)]
        public int? H017C0008 { get; set; }

        [ReadOnly(false)]
        [Column("H017C0009", Order = 247)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 247)]
        public int? H017C0009 { get; set; }

        [ReadOnly(false)]
        [Column("H017C0010", Order = 248)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 248)]
        public int? H017C0010 { get; set; }

        [ReadOnly(false)]
        [Column("H017C0011", Order = 249)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 249)]
        public int? H017C0011 { get; set; }

        [ReadOnly(false)]
        [Column("H017C0012", Order = 250)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 250)]
        public int? H017C0012 { get; set; }

        [ReadOnly(false)]
        [Column("H017C0013", Order = 251)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 251)]
        public int? H017C0013 { get; set; }

        [ReadOnly(false)]
        [Column("H017C0014", Order = 252)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 252)]
        public int? H017C0014 { get; set; }

        [ReadOnly(false)]
        [Column("H017C0015", Order = 253)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 253)]
        public int? H017C0015 { get; set; }

        [ReadOnly(false)]
        [Column("H017C0016", Order = 254)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 254)]
        public int? H017C0016 { get; set; }

        [ReadOnly(false)]
        [Column("H017C0017", Order = 255)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 255)]
        public int? H017C0017 { get; set; }

        [ReadOnly(false)]
        [Column("H017C0018", Order = 256)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 256)]
        public int? H017C0018 { get; set; }

        [ReadOnly(false)]
        [Column("H017C0019", Order = 257)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 257)]
        public int? H017C0019 { get; set; }

        [ReadOnly(false)]
        [Column("H017C0020", Order = 258)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 258)]
        public int? H017C0020 { get; set; }

        [ReadOnly(false)]
        [Column("H017C0021", Order = 259)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 259)]
        public int? H017C0021 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1CongressionalDistricts113_SF1_00045(string csvLine) : base(csvLine) { }

        public SF1CongressionalDistricts113_SF1_00045(string[] values) : base(values) { }

        public SF1CongressionalDistricts113_SF1_00045(OleDbDataReader reader, CensusFileType fileType)
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
                H011G0001 = (int?)reader[5];
            }
            if (reader[6] != DBNull.Value)
            {
                H011G0002 = (int?)reader[6];
            }
            if (reader[7] != DBNull.Value)
            {
                H011G0003 = (int?)reader[7];
            }
            if (reader[8] != DBNull.Value)
            {
                H011G0004 = (int?)reader[8];
            }
            if (reader[9] != DBNull.Value)
            {
                H011H0001 = (int?)reader[9];
            }
            if (reader[10] != DBNull.Value)
            {
                H011H0002 = (int?)reader[10];
            }
            if (reader[11] != DBNull.Value)
            {
                H011H0003 = (int?)reader[11];
            }
            if (reader[12] != DBNull.Value)
            {
                H011H0004 = (int?)reader[12];
            }
            if (reader[13] != DBNull.Value)
            {
                H011I0001 = (int?)reader[13];
            }
            if (reader[14] != DBNull.Value)
            {
                H011I0002 = (int?)reader[14];
            }
            if (reader[15] != DBNull.Value)
            {
                H011I0003 = (int?)reader[15];
            }
            if (reader[16] != DBNull.Value)
            {
                H011I0004 = (int?)reader[16];
            }
            if (reader[17] != DBNull.Value)
            {
                H012A0001 = (double?)reader[17];
            }
            if (reader[18] != DBNull.Value)
            {
                H012A0002 = (double?)reader[18];
            }
            if (reader[19] != DBNull.Value)
            {
                H012A0003 = (double?)reader[19];
            }
            if (reader[20] != DBNull.Value)
            {
                H012B0001 = (double?)reader[20];
            }
            if (reader[21] != DBNull.Value)
            {
                H012B0002 = (double?)reader[21];
            }
            if (reader[22] != DBNull.Value)
            {
                H012B0003 = (double?)reader[22];
            }
            if (reader[23] != DBNull.Value)
            {
                H012C0001 = (double?)reader[23];
            }
            if (reader[24] != DBNull.Value)
            {
                H012C0002 = (double?)reader[24];
            }
            if (reader[25] != DBNull.Value)
            {
                H012C0003 = (double?)reader[25];
            }
            if (reader[26] != DBNull.Value)
            {
                H012D0001 = (double?)reader[26];
            }
            if (reader[27] != DBNull.Value)
            {
                H012D0002 = (double?)reader[27];
            }
            if (reader[28] != DBNull.Value)
            {
                H012D0003 = (double?)reader[28];
            }
            if (reader[29] != DBNull.Value)
            {
                H012E0001 = (double?)reader[29];
            }
            if (reader[30] != DBNull.Value)
            {
                H012E0002 = (double?)reader[30];
            }
            if (reader[31] != DBNull.Value)
            {
                H012E0003 = (double?)reader[31];
            }
            if (reader[32] != DBNull.Value)
            {
                H012F0001 = (double?)reader[32];
            }
            if (reader[33] != DBNull.Value)
            {
                H012F0002 = (double?)reader[33];
            }
            if (reader[34] != DBNull.Value)
            {
                H012F0003 = (double?)reader[34];
            }
            if (reader[35] != DBNull.Value)
            {
                H012G0001 = (double?)reader[35];
            }
            if (reader[36] != DBNull.Value)
            {
                H012G0002 = (double?)reader[36];
            }
            if (reader[37] != DBNull.Value)
            {
                H012G0003 = (double?)reader[37];
            }
            if (reader[38] != DBNull.Value)
            {
                H012H0001 = (double?)reader[38];
            }
            if (reader[39] != DBNull.Value)
            {
                H012H0002 = (double?)reader[39];
            }
            if (reader[40] != DBNull.Value)
            {
                H012H0003 = (double?)reader[40];
            }
            if (reader[41] != DBNull.Value)
            {
                H012I0001 = (double?)reader[41];
            }
            if (reader[42] != DBNull.Value)
            {
                H012I0002 = (double?)reader[42];
            }
            if (reader[43] != DBNull.Value)
            {
                H012I0003 = (double?)reader[43];
            }
            if (reader[44] != DBNull.Value)
            {
                H016A0001 = (int?)reader[44];
            }
            if (reader[45] != DBNull.Value)
            {
                H016A0002 = (int?)reader[45];
            }
            if (reader[46] != DBNull.Value)
            {
                H016A0003 = (int?)reader[46];
            }
            if (reader[47] != DBNull.Value)
            {
                H016A0004 = (int?)reader[47];
            }
            if (reader[48] != DBNull.Value)
            {
                H016A0005 = (int?)reader[48];
            }
            if (reader[49] != DBNull.Value)
            {
                H016A0006 = (int?)reader[49];
            }
            if (reader[50] != DBNull.Value)
            {
                H016A0007 = (int?)reader[50];
            }
            if (reader[51] != DBNull.Value)
            {
                H016A0008 = (int?)reader[51];
            }
            if (reader[52] != DBNull.Value)
            {
                H016A0009 = (int?)reader[52];
            }
            if (reader[53] != DBNull.Value)
            {
                H016A0010 = (int?)reader[53];
            }
            if (reader[54] != DBNull.Value)
            {
                H016A0011 = (int?)reader[54];
            }
            if (reader[55] != DBNull.Value)
            {
                H016A0012 = (int?)reader[55];
            }
            if (reader[56] != DBNull.Value)
            {
                H016A0013 = (int?)reader[56];
            }
            if (reader[57] != DBNull.Value)
            {
                H016A0014 = (int?)reader[57];
            }
            if (reader[58] != DBNull.Value)
            {
                H016A0015 = (int?)reader[58];
            }
            if (reader[59] != DBNull.Value)
            {
                H016A0016 = (int?)reader[59];
            }
            if (reader[60] != DBNull.Value)
            {
                H016A0017 = (int?)reader[60];
            }
            if (reader[61] != DBNull.Value)
            {
                H016B0001 = (int?)reader[61];
            }
            if (reader[62] != DBNull.Value)
            {
                H016B0002 = (int?)reader[62];
            }
            if (reader[63] != DBNull.Value)
            {
                H016B0003 = (int?)reader[63];
            }
            if (reader[64] != DBNull.Value)
            {
                H016B0004 = (int?)reader[64];
            }
            if (reader[65] != DBNull.Value)
            {
                H016B0005 = (int?)reader[65];
            }
            if (reader[66] != DBNull.Value)
            {
                H016B0006 = (int?)reader[66];
            }
            if (reader[67] != DBNull.Value)
            {
                H016B0007 = (int?)reader[67];
            }
            if (reader[68] != DBNull.Value)
            {
                H016B0008 = (int?)reader[68];
            }
            if (reader[69] != DBNull.Value)
            {
                H016B0009 = (int?)reader[69];
            }
            if (reader[70] != DBNull.Value)
            {
                H016B0010 = (int?)reader[70];
            }
            if (reader[71] != DBNull.Value)
            {
                H016B0011 = (int?)reader[71];
            }
            if (reader[72] != DBNull.Value)
            {
                H016B0012 = (int?)reader[72];
            }
            if (reader[73] != DBNull.Value)
            {
                H016B0013 = (int?)reader[73];
            }
            if (reader[74] != DBNull.Value)
            {
                H016B0014 = (int?)reader[74];
            }
            if (reader[75] != DBNull.Value)
            {
                H016B0015 = (int?)reader[75];
            }
            if (reader[76] != DBNull.Value)
            {
                H016B0016 = (int?)reader[76];
            }
            if (reader[77] != DBNull.Value)
            {
                H016B0017 = (int?)reader[77];
            }
            if (reader[78] != DBNull.Value)
            {
                H016C0001 = (int?)reader[78];
            }
            if (reader[79] != DBNull.Value)
            {
                H016C0002 = (int?)reader[79];
            }
            if (reader[80] != DBNull.Value)
            {
                H016C0003 = (int?)reader[80];
            }
            if (reader[81] != DBNull.Value)
            {
                H016C0004 = (int?)reader[81];
            }
            if (reader[82] != DBNull.Value)
            {
                H016C0005 = (int?)reader[82];
            }
            if (reader[83] != DBNull.Value)
            {
                H016C0006 = (int?)reader[83];
            }
            if (reader[84] != DBNull.Value)
            {
                H016C0007 = (int?)reader[84];
            }
            if (reader[85] != DBNull.Value)
            {
                H016C0008 = (int?)reader[85];
            }
            if (reader[86] != DBNull.Value)
            {
                H016C0009 = (int?)reader[86];
            }
            if (reader[87] != DBNull.Value)
            {
                H016C0010 = (int?)reader[87];
            }
            if (reader[88] != DBNull.Value)
            {
                H016C0011 = (int?)reader[88];
            }
            if (reader[89] != DBNull.Value)
            {
                H016C0012 = (int?)reader[89];
            }
            if (reader[90] != DBNull.Value)
            {
                H016C0013 = (int?)reader[90];
            }
            if (reader[91] != DBNull.Value)
            {
                H016C0014 = (int?)reader[91];
            }
            if (reader[92] != DBNull.Value)
            {
                H016C0015 = (int?)reader[92];
            }
            if (reader[93] != DBNull.Value)
            {
                H016C0016 = (int?)reader[93];
            }
            if (reader[94] != DBNull.Value)
            {
                H016C0017 = (int?)reader[94];
            }
            if (reader[95] != DBNull.Value)
            {
                H016D0001 = (int?)reader[95];
            }
            if (reader[96] != DBNull.Value)
            {
                H016D0002 = (int?)reader[96];
            }
            if (reader[97] != DBNull.Value)
            {
                H016D0003 = (int?)reader[97];
            }
            if (reader[98] != DBNull.Value)
            {
                H016D0004 = (int?)reader[98];
            }
            if (reader[99] != DBNull.Value)
            {
                H016D0005 = (int?)reader[99];
            }
            if (reader[100] != DBNull.Value)
            {
                H016D0006 = (int?)reader[100];
            }
            if (reader[101] != DBNull.Value)
            {
                H016D0007 = (int?)reader[101];
            }
            if (reader[102] != DBNull.Value)
            {
                H016D0008 = (int?)reader[102];
            }
            if (reader[103] != DBNull.Value)
            {
                H016D0009 = (int?)reader[103];
            }
            if (reader[104] != DBNull.Value)
            {
                H016D0010 = (int?)reader[104];
            }
            if (reader[105] != DBNull.Value)
            {
                H016D0011 = (int?)reader[105];
            }
            if (reader[106] != DBNull.Value)
            {
                H016D0012 = (int?)reader[106];
            }
            if (reader[107] != DBNull.Value)
            {
                H016D0013 = (int?)reader[107];
            }
            if (reader[108] != DBNull.Value)
            {
                H016D0014 = (int?)reader[108];
            }
            if (reader[109] != DBNull.Value)
            {
                H016D0015 = (int?)reader[109];
            }
            if (reader[110] != DBNull.Value)
            {
                H016D0016 = (int?)reader[110];
            }
            if (reader[111] != DBNull.Value)
            {
                H016D0017 = (int?)reader[111];
            }
            if (reader[112] != DBNull.Value)
            {
                H016E0001 = (int?)reader[112];
            }
            if (reader[113] != DBNull.Value)
            {
                H016E0002 = (int?)reader[113];
            }
            if (reader[114] != DBNull.Value)
            {
                H016E0003 = (int?)reader[114];
            }
            if (reader[115] != DBNull.Value)
            {
                H016E0004 = (int?)reader[115];
            }
            if (reader[116] != DBNull.Value)
            {
                H016E0005 = (int?)reader[116];
            }
            if (reader[117] != DBNull.Value)
            {
                H016E0006 = (int?)reader[117];
            }
            if (reader[118] != DBNull.Value)
            {
                H016E0007 = (int?)reader[118];
            }
            if (reader[119] != DBNull.Value)
            {
                H016E0008 = (int?)reader[119];
            }
            if (reader[120] != DBNull.Value)
            {
                H016E0009 = (int?)reader[120];
            }
            if (reader[121] != DBNull.Value)
            {
                H016E0010 = (int?)reader[121];
            }
            if (reader[122] != DBNull.Value)
            {
                H016E0011 = (int?)reader[122];
            }
            if (reader[123] != DBNull.Value)
            {
                H016E0012 = (int?)reader[123];
            }
            if (reader[124] != DBNull.Value)
            {
                H016E0013 = (int?)reader[124];
            }
            if (reader[125] != DBNull.Value)
            {
                H016E0014 = (int?)reader[125];
            }
            if (reader[126] != DBNull.Value)
            {
                H016E0015 = (int?)reader[126];
            }
            if (reader[127] != DBNull.Value)
            {
                H016E0016 = (int?)reader[127];
            }
            if (reader[128] != DBNull.Value)
            {
                H016E0017 = (int?)reader[128];
            }
            if (reader[129] != DBNull.Value)
            {
                H016F0001 = (int?)reader[129];
            }
            if (reader[130] != DBNull.Value)
            {
                H016F0002 = (int?)reader[130];
            }
            if (reader[131] != DBNull.Value)
            {
                H016F0003 = (int?)reader[131];
            }
            if (reader[132] != DBNull.Value)
            {
                H016F0004 = (int?)reader[132];
            }
            if (reader[133] != DBNull.Value)
            {
                H016F0005 = (int?)reader[133];
            }
            if (reader[134] != DBNull.Value)
            {
                H016F0006 = (int?)reader[134];
            }
            if (reader[135] != DBNull.Value)
            {
                H016F0007 = (int?)reader[135];
            }
            if (reader[136] != DBNull.Value)
            {
                H016F0008 = (int?)reader[136];
            }
            if (reader[137] != DBNull.Value)
            {
                H016F0009 = (int?)reader[137];
            }
            if (reader[138] != DBNull.Value)
            {
                H016F0010 = (int?)reader[138];
            }
            if (reader[139] != DBNull.Value)
            {
                H016F0011 = (int?)reader[139];
            }
            if (reader[140] != DBNull.Value)
            {
                H016F0012 = (int?)reader[140];
            }
            if (reader[141] != DBNull.Value)
            {
                H016F0013 = (int?)reader[141];
            }
            if (reader[142] != DBNull.Value)
            {
                H016F0014 = (int?)reader[142];
            }
            if (reader[143] != DBNull.Value)
            {
                H016F0015 = (int?)reader[143];
            }
            if (reader[144] != DBNull.Value)
            {
                H016F0016 = (int?)reader[144];
            }
            if (reader[145] != DBNull.Value)
            {
                H016F0017 = (int?)reader[145];
            }
            if (reader[146] != DBNull.Value)
            {
                H016G0001 = (int?)reader[146];
            }
            if (reader[147] != DBNull.Value)
            {
                H016G0002 = (int?)reader[147];
            }
            if (reader[148] != DBNull.Value)
            {
                H016G0003 = (int?)reader[148];
            }
            if (reader[149] != DBNull.Value)
            {
                H016G0004 = (int?)reader[149];
            }
            if (reader[150] != DBNull.Value)
            {
                H016G0005 = (int?)reader[150];
            }
            if (reader[151] != DBNull.Value)
            {
                H016G0006 = (int?)reader[151];
            }
            if (reader[152] != DBNull.Value)
            {
                H016G0007 = (int?)reader[152];
            }
            if (reader[153] != DBNull.Value)
            {
                H016G0008 = (int?)reader[153];
            }
            if (reader[154] != DBNull.Value)
            {
                H016G0009 = (int?)reader[154];
            }
            if (reader[155] != DBNull.Value)
            {
                H016G0010 = (int?)reader[155];
            }
            if (reader[156] != DBNull.Value)
            {
                H016G0011 = (int?)reader[156];
            }
            if (reader[157] != DBNull.Value)
            {
                H016G0012 = (int?)reader[157];
            }
            if (reader[158] != DBNull.Value)
            {
                H016G0013 = (int?)reader[158];
            }
            if (reader[159] != DBNull.Value)
            {
                H016G0014 = (int?)reader[159];
            }
            if (reader[160] != DBNull.Value)
            {
                H016G0015 = (int?)reader[160];
            }
            if (reader[161] != DBNull.Value)
            {
                H016G0016 = (int?)reader[161];
            }
            if (reader[162] != DBNull.Value)
            {
                H016G0017 = (int?)reader[162];
            }
            if (reader[163] != DBNull.Value)
            {
                H016H0001 = (int?)reader[163];
            }
            if (reader[164] != DBNull.Value)
            {
                H016H0002 = (int?)reader[164];
            }
            if (reader[165] != DBNull.Value)
            {
                H016H0003 = (int?)reader[165];
            }
            if (reader[166] != DBNull.Value)
            {
                H016H0004 = (int?)reader[166];
            }
            if (reader[167] != DBNull.Value)
            {
                H016H0005 = (int?)reader[167];
            }
            if (reader[168] != DBNull.Value)
            {
                H016H0006 = (int?)reader[168];
            }
            if (reader[169] != DBNull.Value)
            {
                H016H0007 = (int?)reader[169];
            }
            if (reader[170] != DBNull.Value)
            {
                H016H0008 = (int?)reader[170];
            }
            if (reader[171] != DBNull.Value)
            {
                H016H0009 = (int?)reader[171];
            }
            if (reader[172] != DBNull.Value)
            {
                H016H0010 = (int?)reader[172];
            }
            if (reader[173] != DBNull.Value)
            {
                H016H0011 = (int?)reader[173];
            }
            if (reader[174] != DBNull.Value)
            {
                H016H0012 = (int?)reader[174];
            }
            if (reader[175] != DBNull.Value)
            {
                H016H0013 = (int?)reader[175];
            }
            if (reader[176] != DBNull.Value)
            {
                H016H0014 = (int?)reader[176];
            }
            if (reader[177] != DBNull.Value)
            {
                H016H0015 = (int?)reader[177];
            }
            if (reader[178] != DBNull.Value)
            {
                H016H0016 = (int?)reader[178];
            }
            if (reader[179] != DBNull.Value)
            {
                H016H0017 = (int?)reader[179];
            }
            if (reader[180] != DBNull.Value)
            {
                H016I0001 = (int?)reader[180];
            }
            if (reader[181] != DBNull.Value)
            {
                H016I0002 = (int?)reader[181];
            }
            if (reader[182] != DBNull.Value)
            {
                H016I0003 = (int?)reader[182];
            }
            if (reader[183] != DBNull.Value)
            {
                H016I0004 = (int?)reader[183];
            }
            if (reader[184] != DBNull.Value)
            {
                H016I0005 = (int?)reader[184];
            }
            if (reader[185] != DBNull.Value)
            {
                H016I0006 = (int?)reader[185];
            }
            if (reader[186] != DBNull.Value)
            {
                H016I0007 = (int?)reader[186];
            }
            if (reader[187] != DBNull.Value)
            {
                H016I0008 = (int?)reader[187];
            }
            if (reader[188] != DBNull.Value)
            {
                H016I0009 = (int?)reader[188];
            }
            if (reader[189] != DBNull.Value)
            {
                H016I0010 = (int?)reader[189];
            }
            if (reader[190] != DBNull.Value)
            {
                H016I0011 = (int?)reader[190];
            }
            if (reader[191] != DBNull.Value)
            {
                H016I0012 = (int?)reader[191];
            }
            if (reader[192] != DBNull.Value)
            {
                H016I0013 = (int?)reader[192];
            }
            if (reader[193] != DBNull.Value)
            {
                H016I0014 = (int?)reader[193];
            }
            if (reader[194] != DBNull.Value)
            {
                H016I0015 = (int?)reader[194];
            }
            if (reader[195] != DBNull.Value)
            {
                H016I0016 = (int?)reader[195];
            }
            if (reader[196] != DBNull.Value)
            {
                H016I0017 = (int?)reader[196];
            }
            if (reader[197] != DBNull.Value)
            {
                H017A0001 = (int?)reader[197];
            }
            if (reader[198] != DBNull.Value)
            {
                H017A0002 = (int?)reader[198];
            }
            if (reader[199] != DBNull.Value)
            {
                H017A0003 = (int?)reader[199];
            }
            if (reader[200] != DBNull.Value)
            {
                H017A0004 = (int?)reader[200];
            }
            if (reader[201] != DBNull.Value)
            {
                H017A0005 = (int?)reader[201];
            }
            if (reader[202] != DBNull.Value)
            {
                H017A0006 = (int?)reader[202];
            }
            if (reader[203] != DBNull.Value)
            {
                H017A0007 = (int?)reader[203];
            }
            if (reader[204] != DBNull.Value)
            {
                H017A0008 = (int?)reader[204];
            }
            if (reader[205] != DBNull.Value)
            {
                H017A0009 = (int?)reader[205];
            }
            if (reader[206] != DBNull.Value)
            {
                H017A0010 = (int?)reader[206];
            }
            if (reader[207] != DBNull.Value)
            {
                H017A0011 = (int?)reader[207];
            }
            if (reader[208] != DBNull.Value)
            {
                H017A0012 = (int?)reader[208];
            }
            if (reader[209] != DBNull.Value)
            {
                H017A0013 = (int?)reader[209];
            }
            if (reader[210] != DBNull.Value)
            {
                H017A0014 = (int?)reader[210];
            }
            if (reader[211] != DBNull.Value)
            {
                H017A0015 = (int?)reader[211];
            }
            if (reader[212] != DBNull.Value)
            {
                H017A0016 = (int?)reader[212];
            }
            if (reader[213] != DBNull.Value)
            {
                H017A0017 = (int?)reader[213];
            }
            if (reader[214] != DBNull.Value)
            {
                H017A0018 = (int?)reader[214];
            }
            if (reader[215] != DBNull.Value)
            {
                H017A0019 = (int?)reader[215];
            }
            if (reader[216] != DBNull.Value)
            {
                H017A0020 = (int?)reader[216];
            }
            if (reader[217] != DBNull.Value)
            {
                H017A0021 = (int?)reader[217];
            }
            if (reader[218] != DBNull.Value)
            {
                H017B0001 = (int?)reader[218];
            }
            if (reader[219] != DBNull.Value)
            {
                H017B0002 = (int?)reader[219];
            }
            if (reader[220] != DBNull.Value)
            {
                H017B0003 = (int?)reader[220];
            }
            if (reader[221] != DBNull.Value)
            {
                H017B0004 = (int?)reader[221];
            }
            if (reader[222] != DBNull.Value)
            {
                H017B0005 = (int?)reader[222];
            }
            if (reader[223] != DBNull.Value)
            {
                H017B0006 = (int?)reader[223];
            }
            if (reader[224] != DBNull.Value)
            {
                H017B0007 = (int?)reader[224];
            }
            if (reader[225] != DBNull.Value)
            {
                H017B0008 = (int?)reader[225];
            }
            if (reader[226] != DBNull.Value)
            {
                H017B0009 = (int?)reader[226];
            }
            if (reader[227] != DBNull.Value)
            {
                H017B0010 = (int?)reader[227];
            }
            if (reader[228] != DBNull.Value)
            {
                H017B0011 = (int?)reader[228];
            }
            if (reader[229] != DBNull.Value)
            {
                H017B0012 = (int?)reader[229];
            }
            if (reader[230] != DBNull.Value)
            {
                H017B0013 = (int?)reader[230];
            }
            if (reader[231] != DBNull.Value)
            {
                H017B0014 = (int?)reader[231];
            }
            if (reader[232] != DBNull.Value)
            {
                H017B0015 = (int?)reader[232];
            }
            if (reader[233] != DBNull.Value)
            {
                H017B0016 = (int?)reader[233];
            }
            if (reader[234] != DBNull.Value)
            {
                H017B0017 = (int?)reader[234];
            }
            if (reader[235] != DBNull.Value)
            {
                H017B0018 = (int?)reader[235];
            }
            if (reader[236] != DBNull.Value)
            {
                H017B0019 = (int?)reader[236];
            }
            if (reader[237] != DBNull.Value)
            {
                H017B0020 = (int?)reader[237];
            }
            if (reader[238] != DBNull.Value)
            {
                H017B0021 = (int?)reader[238];
            }
            if (reader[239] != DBNull.Value)
            {
                H017C0001 = (int?)reader[239];
            }
            if (reader[240] != DBNull.Value)
            {
                H017C0002 = (int?)reader[240];
            }
            if (reader[241] != DBNull.Value)
            {
                H017C0003 = (int?)reader[241];
            }
            if (reader[242] != DBNull.Value)
            {
                H017C0004 = (int?)reader[242];
            }
            if (reader[243] != DBNull.Value)
            {
                H017C0005 = (int?)reader[243];
            }
            if (reader[244] != DBNull.Value)
            {
                H017C0006 = (int?)reader[244];
            }
            if (reader[245] != DBNull.Value)
            {
                H017C0007 = (int?)reader[245];
            }
            if (reader[246] != DBNull.Value)
            {
                H017C0008 = (int?)reader[246];
            }
            if (reader[247] != DBNull.Value)
            {
                H017C0009 = (int?)reader[247];
            }
            if (reader[248] != DBNull.Value)
            {
                H017C0010 = (int?)reader[248];
            }
            if (reader[249] != DBNull.Value)
            {
                H017C0011 = (int?)reader[249];
            }
            if (reader[250] != DBNull.Value)
            {
                H017C0012 = (int?)reader[250];
            }
            if (reader[251] != DBNull.Value)
            {
                H017C0013 = (int?)reader[251];
            }
            if (reader[252] != DBNull.Value)
            {
                H017C0014 = (int?)reader[252];
            }
            if (reader[253] != DBNull.Value)
            {
                H017C0015 = (int?)reader[253];
            }
            if (reader[254] != DBNull.Value)
            {
                H017C0016 = (int?)reader[254];
            }
            if (reader[255] != DBNull.Value)
            {
                H017C0017 = (int?)reader[255];
            }
            if (reader[256] != DBNull.Value)
            {
                H017C0018 = (int?)reader[256];
            }
            if (reader[257] != DBNull.Value)
            {
                H017C0019 = (int?)reader[257];
            }
            if (reader[258] != DBNull.Value)
            {
                H017C0020 = (int?)reader[258];
            }
            if (reader[259] != DBNull.Value)
            {
                H017C0021 = (int?)reader[259];
            }
        }
        #endregion Constructors
    }
}
