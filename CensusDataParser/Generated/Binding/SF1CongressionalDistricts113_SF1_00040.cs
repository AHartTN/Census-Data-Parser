#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2016 11:15 AM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1CongressionalDistricts113_SF1_00040.cs
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

    public class SF1CongressionalDistricts113_SF1_00040 : BaseModel
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
        [Column("PCO0010001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public int? PCO0010001 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 6)]
        public int? PCO0010002 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 7)]
        public int? PCO0010003 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 8)]
        public int? PCO0010004 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 9)]
        public int? PCO0010005 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 10)]
        public int? PCO0010006 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 11)]
        public int? PCO0010007 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 12)]
        public int? PCO0010008 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 13)]
        public int? PCO0010009 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 14)]
        public int? PCO0010010 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 15)]
        public int? PCO0010011 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 16)]
        public int? PCO0010012 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 17)]
        public int? PCO0010013 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 18)]
        public int? PCO0010014 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 19)]
        public int? PCO0010015 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 20)]
        public int? PCO0010016 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010017", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 21)]
        public int? PCO0010017 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010018", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 22)]
        public int? PCO0010018 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010019", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 23)]
        public int? PCO0010019 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010020", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 24)]
        public int? PCO0010020 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010021", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 25)]
        public int? PCO0010021 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010022", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 26)]
        public int? PCO0010022 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010023", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 27)]
        public int? PCO0010023 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010024", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 28)]
        public int? PCO0010024 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010025", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 29)]
        public int? PCO0010025 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010026", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 30)]
        public int? PCO0010026 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010027", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 31)]
        public int? PCO0010027 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010028", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 32)]
        public int? PCO0010028 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010029", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 33)]
        public int? PCO0010029 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010030", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 34)]
        public int? PCO0010030 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010031", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 35)]
        public int? PCO0010031 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010032", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 36)]
        public int? PCO0010032 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010033", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 37)]
        public int? PCO0010033 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010034", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 38)]
        public int? PCO0010034 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010035", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 39)]
        public int? PCO0010035 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010036", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 40)]
        public int? PCO0010036 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010037", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 41)]
        public int? PCO0010037 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010038", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 42)]
        public int? PCO0010038 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010039", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 43)]
        public int? PCO0010039 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020001", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total (101-106, 201-203, 301, 401-405):", ShortName = "Total (101-106, 201-203, 301, 401-405):", Order = 44)]
        public int? PCO0020001 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020002", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 45)]
        public int? PCO0020002 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020003", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 46)]
        public int? PCO0020003 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020004", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 47)]
        public int? PCO0020004 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020005", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 48)]
        public int? PCO0020005 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020006", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 49)]
        public int? PCO0020006 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020007", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 50)]
        public int? PCO0020007 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020008", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 51)]
        public int? PCO0020008 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020009", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 52)]
        public int? PCO0020009 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020010", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 53)]
        public int? PCO0020010 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020011", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 54)]
        public int? PCO0020011 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020012", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 55)]
        public int? PCO0020012 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020013", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 56)]
        public int? PCO0020013 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020014", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 57)]
        public int? PCO0020014 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020015", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 58)]
        public int? PCO0020015 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020016", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 59)]
        public int? PCO0020016 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020017", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 60)]
        public int? PCO0020017 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020018", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 61)]
        public int? PCO0020018 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020019", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 62)]
        public int? PCO0020019 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020020", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 63)]
        public int? PCO0020020 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020021", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 64)]
        public int? PCO0020021 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020022", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 65)]
        public int? PCO0020022 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020023", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 66)]
        public int? PCO0020023 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020024", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 67)]
        public int? PCO0020024 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020025", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 68)]
        public int? PCO0020025 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020026", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 69)]
        public int? PCO0020026 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020027", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 70)]
        public int? PCO0020027 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020028", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 71)]
        public int? PCO0020028 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020029", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 72)]
        public int? PCO0020029 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020030", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 73)]
        public int? PCO0020030 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020031", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 74)]
        public int? PCO0020031 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020032", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 75)]
        public int? PCO0020032 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020033", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 76)]
        public int? PCO0020033 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020034", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 77)]
        public int? PCO0020034 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020035", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 78)]
        public int? PCO0020035 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020036", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 79)]
        public int? PCO0020036 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020037", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 80)]
        public int? PCO0020037 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020038", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 81)]
        public int? PCO0020038 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020039", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 82)]
        public int? PCO0020039 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030001", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total (101-106):", ShortName = "Total (101-106):", Order = 83)]
        public int? PCO0030001 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030002", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 84)]
        public int? PCO0030002 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030003", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 85)]
        public int? PCO0030003 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030004", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 86)]
        public int? PCO0030004 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030005", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 87)]
        public int? PCO0030005 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030006", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 88)]
        public int? PCO0030006 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030007", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 89)]
        public int? PCO0030007 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030008", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 90)]
        public int? PCO0030008 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030009", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 91)]
        public int? PCO0030009 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030010", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 92)]
        public int? PCO0030010 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030011", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 93)]
        public int? PCO0030011 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030012", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 94)]
        public int? PCO0030012 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030013", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 95)]
        public int? PCO0030013 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030014", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 96)]
        public int? PCO0030014 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030015", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 97)]
        public int? PCO0030015 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030016", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 98)]
        public int? PCO0030016 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030017", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 99)]
        public int? PCO0030017 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030018", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 100)]
        public int? PCO0030018 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030019", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 101)]
        public int? PCO0030019 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030020", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 102)]
        public int? PCO0030020 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030021", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 103)]
        public int? PCO0030021 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030022", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 104)]
        public int? PCO0030022 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030023", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 105)]
        public int? PCO0030023 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030024", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 106)]
        public int? PCO0030024 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030025", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 107)]
        public int? PCO0030025 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030026", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 108)]
        public int? PCO0030026 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030027", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 109)]
        public int? PCO0030027 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030028", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 110)]
        public int? PCO0030028 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030029", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 111)]
        public int? PCO0030029 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030030", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 112)]
        public int? PCO0030030 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030031", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 113)]
        public int? PCO0030031 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030032", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 114)]
        public int? PCO0030032 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030033", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 115)]
        public int? PCO0030033 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030034", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 116)]
        public int? PCO0030034 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030035", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 117)]
        public int? PCO0030035 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030036", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 118)]
        public int? PCO0030036 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030037", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 119)]
        public int? PCO0030037 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030038", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 120)]
        public int? PCO0030038 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030039", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 121)]
        public int? PCO0030039 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040001", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total (201-203):", ShortName = "Total (201-203):", Order = 122)]
        public int? PCO0040001 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040002", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 123)]
        public int? PCO0040002 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040003", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 124)]
        public int? PCO0040003 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040004", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 125)]
        public int? PCO0040004 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040005", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 126)]
        public int? PCO0040005 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040006", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 127)]
        public int? PCO0040006 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040007", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 128)]
        public int? PCO0040007 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040008", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 129)]
        public int? PCO0040008 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040009", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 130)]
        public int? PCO0040009 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040010", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 131)]
        public int? PCO0040010 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040011", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 132)]
        public int? PCO0040011 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040012", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 133)]
        public int? PCO0040012 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040013", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 134)]
        public int? PCO0040013 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040014", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 135)]
        public int? PCO0040014 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040015", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 136)]
        public int? PCO0040015 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040016", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 137)]
        public int? PCO0040016 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040017", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 138)]
        public int? PCO0040017 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040018", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 139)]
        public int? PCO0040018 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040019", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 140)]
        public int? PCO0040019 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040020", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 141)]
        public int? PCO0040020 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040021", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 142)]
        public int? PCO0040021 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040022", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 143)]
        public int? PCO0040022 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040023", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 144)]
        public int? PCO0040023 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040024", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 145)]
        public int? PCO0040024 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040025", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 146)]
        public int? PCO0040025 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040026", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 147)]
        public int? PCO0040026 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040027", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 148)]
        public int? PCO0040027 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040028", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 149)]
        public int? PCO0040028 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040029", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 150)]
        public int? PCO0040029 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040030", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 151)]
        public int? PCO0040030 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040031", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 152)]
        public int? PCO0040031 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040032", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 153)]
        public int? PCO0040032 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040033", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 154)]
        public int? PCO0040033 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040034", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 155)]
        public int? PCO0040034 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040035", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 156)]
        public int? PCO0040035 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040036", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 157)]
        public int? PCO0040036 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040037", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 158)]
        public int? PCO0040037 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040038", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 159)]
        public int? PCO0040038 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040039", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 160)]
        public int? PCO0040039 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050001", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total (301):", ShortName = "Total (301):", Order = 161)]
        public int? PCO0050001 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050002", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 162)]
        public int? PCO0050002 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050003", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 163)]
        public int? PCO0050003 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050004", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 164)]
        public int? PCO0050004 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050005", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 165)]
        public int? PCO0050005 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050006", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 166)]
        public int? PCO0050006 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050007", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 167)]
        public int? PCO0050007 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050008", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 168)]
        public int? PCO0050008 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050009", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 169)]
        public int? PCO0050009 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050010", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 170)]
        public int? PCO0050010 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050011", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 171)]
        public int? PCO0050011 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050012", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 172)]
        public int? PCO0050012 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050013", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 173)]
        public int? PCO0050013 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050014", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 174)]
        public int? PCO0050014 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050015", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 175)]
        public int? PCO0050015 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050016", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 176)]
        public int? PCO0050016 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050017", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 177)]
        public int? PCO0050017 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050018", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 178)]
        public int? PCO0050018 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050019", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 179)]
        public int? PCO0050019 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050020", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 180)]
        public int? PCO0050020 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050021", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 181)]
        public int? PCO0050021 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050022", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 182)]
        public int? PCO0050022 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050023", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 183)]
        public int? PCO0050023 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050024", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 184)]
        public int? PCO0050024 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050025", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 185)]
        public int? PCO0050025 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050026", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 186)]
        public int? PCO0050026 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050027", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 187)]
        public int? PCO0050027 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050028", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 188)]
        public int? PCO0050028 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050029", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 189)]
        public int? PCO0050029 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050030", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 190)]
        public int? PCO0050030 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050031", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 191)]
        public int? PCO0050031 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050032", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 192)]
        public int? PCO0050032 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050033", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 193)]
        public int? PCO0050033 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050034", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 194)]
        public int? PCO0050034 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050035", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 195)]
        public int? PCO0050035 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050036", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 196)]
        public int? PCO0050036 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050037", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 197)]
        public int? PCO0050037 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050038", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 198)]
        public int? PCO0050038 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050039", Order = 199)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 199)]
        public int? PCO0050039 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060001", Order = 200)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total (401-405):", ShortName = "Total (401-405):", Order = 200)]
        public int? PCO0060001 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060002", Order = 201)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 201)]
        public int? PCO0060002 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060003", Order = 202)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 202)]
        public int? PCO0060003 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060004", Order = 203)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 203)]
        public int? PCO0060004 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060005", Order = 204)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 204)]
        public int? PCO0060005 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060006", Order = 205)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 205)]
        public int? PCO0060006 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060007", Order = 206)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 206)]
        public int? PCO0060007 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060008", Order = 207)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 207)]
        public int? PCO0060008 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060009", Order = 208)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 208)]
        public int? PCO0060009 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060010", Order = 209)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 209)]
        public int? PCO0060010 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060011", Order = 210)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 210)]
        public int? PCO0060011 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060012", Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 211)]
        public int? PCO0060012 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060013", Order = 212)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 212)]
        public int? PCO0060013 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060014", Order = 213)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 213)]
        public int? PCO0060014 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060015", Order = 214)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 214)]
        public int? PCO0060015 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060016", Order = 215)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 215)]
        public int? PCO0060016 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060017", Order = 216)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 216)]
        public int? PCO0060017 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060018", Order = 217)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 217)]
        public int? PCO0060018 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060019", Order = 218)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 218)]
        public int? PCO0060019 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060020", Order = 219)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 219)]
        public int? PCO0060020 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060021", Order = 220)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 220)]
        public int? PCO0060021 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060022", Order = 221)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 221)]
        public int? PCO0060022 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060023", Order = 222)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 222)]
        public int? PCO0060023 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060024", Order = 223)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 223)]
        public int? PCO0060024 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060025", Order = 224)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 224)]
        public int? PCO0060025 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060026", Order = 225)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 225)]
        public int? PCO0060026 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060027", Order = 226)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 226)]
        public int? PCO0060027 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060028", Order = 227)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 227)]
        public int? PCO0060028 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060029", Order = 228)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 228)]
        public int? PCO0060029 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060030", Order = 229)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 229)]
        public int? PCO0060030 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060031", Order = 230)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 230)]
        public int? PCO0060031 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060032", Order = 231)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 231)]
        public int? PCO0060032 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060033", Order = 232)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 232)]
        public int? PCO0060033 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060034", Order = 233)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 233)]
        public int? PCO0060034 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060035", Order = 234)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 234)]
        public int? PCO0060035 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060036", Order = 235)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 235)]
        public int? PCO0060036 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060037", Order = 236)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 236)]
        public int? PCO0060037 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060038", Order = 237)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 237)]
        public int? PCO0060038 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060039", Order = 238)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 238)]
        public int? PCO0060039 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1CongressionalDistricts113_SF1_00040(string csvLine) : base(csvLine) { }

        public SF1CongressionalDistricts113_SF1_00040(string[] values) : base(values) { }

        public SF1CongressionalDistricts113_SF1_00040(OleDbDataReader reader, CensusFileType fileType)
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
                PCO0010001 = (int?)reader[5];
            }
            if (reader[6] != DBNull.Value)
            {
                PCO0010002 = (int?)reader[6];
            }
            if (reader[7] != DBNull.Value)
            {
                PCO0010003 = (int?)reader[7];
            }
            if (reader[8] != DBNull.Value)
            {
                PCO0010004 = (int?)reader[8];
            }
            if (reader[9] != DBNull.Value)
            {
                PCO0010005 = (int?)reader[9];
            }
            if (reader[10] != DBNull.Value)
            {
                PCO0010006 = (int?)reader[10];
            }
            if (reader[11] != DBNull.Value)
            {
                PCO0010007 = (int?)reader[11];
            }
            if (reader[12] != DBNull.Value)
            {
                PCO0010008 = (int?)reader[12];
            }
            if (reader[13] != DBNull.Value)
            {
                PCO0010009 = (int?)reader[13];
            }
            if (reader[14] != DBNull.Value)
            {
                PCO0010010 = (int?)reader[14];
            }
            if (reader[15] != DBNull.Value)
            {
                PCO0010011 = (int?)reader[15];
            }
            if (reader[16] != DBNull.Value)
            {
                PCO0010012 = (int?)reader[16];
            }
            if (reader[17] != DBNull.Value)
            {
                PCO0010013 = (int?)reader[17];
            }
            if (reader[18] != DBNull.Value)
            {
                PCO0010014 = (int?)reader[18];
            }
            if (reader[19] != DBNull.Value)
            {
                PCO0010015 = (int?)reader[19];
            }
            if (reader[20] != DBNull.Value)
            {
                PCO0010016 = (int?)reader[20];
            }
            if (reader[21] != DBNull.Value)
            {
                PCO0010017 = (int?)reader[21];
            }
            if (reader[22] != DBNull.Value)
            {
                PCO0010018 = (int?)reader[22];
            }
            if (reader[23] != DBNull.Value)
            {
                PCO0010019 = (int?)reader[23];
            }
            if (reader[24] != DBNull.Value)
            {
                PCO0010020 = (int?)reader[24];
            }
            if (reader[25] != DBNull.Value)
            {
                PCO0010021 = (int?)reader[25];
            }
            if (reader[26] != DBNull.Value)
            {
                PCO0010022 = (int?)reader[26];
            }
            if (reader[27] != DBNull.Value)
            {
                PCO0010023 = (int?)reader[27];
            }
            if (reader[28] != DBNull.Value)
            {
                PCO0010024 = (int?)reader[28];
            }
            if (reader[29] != DBNull.Value)
            {
                PCO0010025 = (int?)reader[29];
            }
            if (reader[30] != DBNull.Value)
            {
                PCO0010026 = (int?)reader[30];
            }
            if (reader[31] != DBNull.Value)
            {
                PCO0010027 = (int?)reader[31];
            }
            if (reader[32] != DBNull.Value)
            {
                PCO0010028 = (int?)reader[32];
            }
            if (reader[33] != DBNull.Value)
            {
                PCO0010029 = (int?)reader[33];
            }
            if (reader[34] != DBNull.Value)
            {
                PCO0010030 = (int?)reader[34];
            }
            if (reader[35] != DBNull.Value)
            {
                PCO0010031 = (int?)reader[35];
            }
            if (reader[36] != DBNull.Value)
            {
                PCO0010032 = (int?)reader[36];
            }
            if (reader[37] != DBNull.Value)
            {
                PCO0010033 = (int?)reader[37];
            }
            if (reader[38] != DBNull.Value)
            {
                PCO0010034 = (int?)reader[38];
            }
            if (reader[39] != DBNull.Value)
            {
                PCO0010035 = (int?)reader[39];
            }
            if (reader[40] != DBNull.Value)
            {
                PCO0010036 = (int?)reader[40];
            }
            if (reader[41] != DBNull.Value)
            {
                PCO0010037 = (int?)reader[41];
            }
            if (reader[42] != DBNull.Value)
            {
                PCO0010038 = (int?)reader[42];
            }
            if (reader[43] != DBNull.Value)
            {
                PCO0010039 = (int?)reader[43];
            }
            if (reader[44] != DBNull.Value)
            {
                PCO0020001 = (int?)reader[44];
            }
            if (reader[45] != DBNull.Value)
            {
                PCO0020002 = (int?)reader[45];
            }
            if (reader[46] != DBNull.Value)
            {
                PCO0020003 = (int?)reader[46];
            }
            if (reader[47] != DBNull.Value)
            {
                PCO0020004 = (int?)reader[47];
            }
            if (reader[48] != DBNull.Value)
            {
                PCO0020005 = (int?)reader[48];
            }
            if (reader[49] != DBNull.Value)
            {
                PCO0020006 = (int?)reader[49];
            }
            if (reader[50] != DBNull.Value)
            {
                PCO0020007 = (int?)reader[50];
            }
            if (reader[51] != DBNull.Value)
            {
                PCO0020008 = (int?)reader[51];
            }
            if (reader[52] != DBNull.Value)
            {
                PCO0020009 = (int?)reader[52];
            }
            if (reader[53] != DBNull.Value)
            {
                PCO0020010 = (int?)reader[53];
            }
            if (reader[54] != DBNull.Value)
            {
                PCO0020011 = (int?)reader[54];
            }
            if (reader[55] != DBNull.Value)
            {
                PCO0020012 = (int?)reader[55];
            }
            if (reader[56] != DBNull.Value)
            {
                PCO0020013 = (int?)reader[56];
            }
            if (reader[57] != DBNull.Value)
            {
                PCO0020014 = (int?)reader[57];
            }
            if (reader[58] != DBNull.Value)
            {
                PCO0020015 = (int?)reader[58];
            }
            if (reader[59] != DBNull.Value)
            {
                PCO0020016 = (int?)reader[59];
            }
            if (reader[60] != DBNull.Value)
            {
                PCO0020017 = (int?)reader[60];
            }
            if (reader[61] != DBNull.Value)
            {
                PCO0020018 = (int?)reader[61];
            }
            if (reader[62] != DBNull.Value)
            {
                PCO0020019 = (int?)reader[62];
            }
            if (reader[63] != DBNull.Value)
            {
                PCO0020020 = (int?)reader[63];
            }
            if (reader[64] != DBNull.Value)
            {
                PCO0020021 = (int?)reader[64];
            }
            if (reader[65] != DBNull.Value)
            {
                PCO0020022 = (int?)reader[65];
            }
            if (reader[66] != DBNull.Value)
            {
                PCO0020023 = (int?)reader[66];
            }
            if (reader[67] != DBNull.Value)
            {
                PCO0020024 = (int?)reader[67];
            }
            if (reader[68] != DBNull.Value)
            {
                PCO0020025 = (int?)reader[68];
            }
            if (reader[69] != DBNull.Value)
            {
                PCO0020026 = (int?)reader[69];
            }
            if (reader[70] != DBNull.Value)
            {
                PCO0020027 = (int?)reader[70];
            }
            if (reader[71] != DBNull.Value)
            {
                PCO0020028 = (int?)reader[71];
            }
            if (reader[72] != DBNull.Value)
            {
                PCO0020029 = (int?)reader[72];
            }
            if (reader[73] != DBNull.Value)
            {
                PCO0020030 = (int?)reader[73];
            }
            if (reader[74] != DBNull.Value)
            {
                PCO0020031 = (int?)reader[74];
            }
            if (reader[75] != DBNull.Value)
            {
                PCO0020032 = (int?)reader[75];
            }
            if (reader[76] != DBNull.Value)
            {
                PCO0020033 = (int?)reader[76];
            }
            if (reader[77] != DBNull.Value)
            {
                PCO0020034 = (int?)reader[77];
            }
            if (reader[78] != DBNull.Value)
            {
                PCO0020035 = (int?)reader[78];
            }
            if (reader[79] != DBNull.Value)
            {
                PCO0020036 = (int?)reader[79];
            }
            if (reader[80] != DBNull.Value)
            {
                PCO0020037 = (int?)reader[80];
            }
            if (reader[81] != DBNull.Value)
            {
                PCO0020038 = (int?)reader[81];
            }
            if (reader[82] != DBNull.Value)
            {
                PCO0020039 = (int?)reader[82];
            }
            if (reader[83] != DBNull.Value)
            {
                PCO0030001 = (int?)reader[83];
            }
            if (reader[84] != DBNull.Value)
            {
                PCO0030002 = (int?)reader[84];
            }
            if (reader[85] != DBNull.Value)
            {
                PCO0030003 = (int?)reader[85];
            }
            if (reader[86] != DBNull.Value)
            {
                PCO0030004 = (int?)reader[86];
            }
            if (reader[87] != DBNull.Value)
            {
                PCO0030005 = (int?)reader[87];
            }
            if (reader[88] != DBNull.Value)
            {
                PCO0030006 = (int?)reader[88];
            }
            if (reader[89] != DBNull.Value)
            {
                PCO0030007 = (int?)reader[89];
            }
            if (reader[90] != DBNull.Value)
            {
                PCO0030008 = (int?)reader[90];
            }
            if (reader[91] != DBNull.Value)
            {
                PCO0030009 = (int?)reader[91];
            }
            if (reader[92] != DBNull.Value)
            {
                PCO0030010 = (int?)reader[92];
            }
            if (reader[93] != DBNull.Value)
            {
                PCO0030011 = (int?)reader[93];
            }
            if (reader[94] != DBNull.Value)
            {
                PCO0030012 = (int?)reader[94];
            }
            if (reader[95] != DBNull.Value)
            {
                PCO0030013 = (int?)reader[95];
            }
            if (reader[96] != DBNull.Value)
            {
                PCO0030014 = (int?)reader[96];
            }
            if (reader[97] != DBNull.Value)
            {
                PCO0030015 = (int?)reader[97];
            }
            if (reader[98] != DBNull.Value)
            {
                PCO0030016 = (int?)reader[98];
            }
            if (reader[99] != DBNull.Value)
            {
                PCO0030017 = (int?)reader[99];
            }
            if (reader[100] != DBNull.Value)
            {
                PCO0030018 = (int?)reader[100];
            }
            if (reader[101] != DBNull.Value)
            {
                PCO0030019 = (int?)reader[101];
            }
            if (reader[102] != DBNull.Value)
            {
                PCO0030020 = (int?)reader[102];
            }
            if (reader[103] != DBNull.Value)
            {
                PCO0030021 = (int?)reader[103];
            }
            if (reader[104] != DBNull.Value)
            {
                PCO0030022 = (int?)reader[104];
            }
            if (reader[105] != DBNull.Value)
            {
                PCO0030023 = (int?)reader[105];
            }
            if (reader[106] != DBNull.Value)
            {
                PCO0030024 = (int?)reader[106];
            }
            if (reader[107] != DBNull.Value)
            {
                PCO0030025 = (int?)reader[107];
            }
            if (reader[108] != DBNull.Value)
            {
                PCO0030026 = (int?)reader[108];
            }
            if (reader[109] != DBNull.Value)
            {
                PCO0030027 = (int?)reader[109];
            }
            if (reader[110] != DBNull.Value)
            {
                PCO0030028 = (int?)reader[110];
            }
            if (reader[111] != DBNull.Value)
            {
                PCO0030029 = (int?)reader[111];
            }
            if (reader[112] != DBNull.Value)
            {
                PCO0030030 = (int?)reader[112];
            }
            if (reader[113] != DBNull.Value)
            {
                PCO0030031 = (int?)reader[113];
            }
            if (reader[114] != DBNull.Value)
            {
                PCO0030032 = (int?)reader[114];
            }
            if (reader[115] != DBNull.Value)
            {
                PCO0030033 = (int?)reader[115];
            }
            if (reader[116] != DBNull.Value)
            {
                PCO0030034 = (int?)reader[116];
            }
            if (reader[117] != DBNull.Value)
            {
                PCO0030035 = (int?)reader[117];
            }
            if (reader[118] != DBNull.Value)
            {
                PCO0030036 = (int?)reader[118];
            }
            if (reader[119] != DBNull.Value)
            {
                PCO0030037 = (int?)reader[119];
            }
            if (reader[120] != DBNull.Value)
            {
                PCO0030038 = (int?)reader[120];
            }
            if (reader[121] != DBNull.Value)
            {
                PCO0030039 = (int?)reader[121];
            }
            if (reader[122] != DBNull.Value)
            {
                PCO0040001 = (int?)reader[122];
            }
            if (reader[123] != DBNull.Value)
            {
                PCO0040002 = (int?)reader[123];
            }
            if (reader[124] != DBNull.Value)
            {
                PCO0040003 = (int?)reader[124];
            }
            if (reader[125] != DBNull.Value)
            {
                PCO0040004 = (int?)reader[125];
            }
            if (reader[126] != DBNull.Value)
            {
                PCO0040005 = (int?)reader[126];
            }
            if (reader[127] != DBNull.Value)
            {
                PCO0040006 = (int?)reader[127];
            }
            if (reader[128] != DBNull.Value)
            {
                PCO0040007 = (int?)reader[128];
            }
            if (reader[129] != DBNull.Value)
            {
                PCO0040008 = (int?)reader[129];
            }
            if (reader[130] != DBNull.Value)
            {
                PCO0040009 = (int?)reader[130];
            }
            if (reader[131] != DBNull.Value)
            {
                PCO0040010 = (int?)reader[131];
            }
            if (reader[132] != DBNull.Value)
            {
                PCO0040011 = (int?)reader[132];
            }
            if (reader[133] != DBNull.Value)
            {
                PCO0040012 = (int?)reader[133];
            }
            if (reader[134] != DBNull.Value)
            {
                PCO0040013 = (int?)reader[134];
            }
            if (reader[135] != DBNull.Value)
            {
                PCO0040014 = (int?)reader[135];
            }
            if (reader[136] != DBNull.Value)
            {
                PCO0040015 = (int?)reader[136];
            }
            if (reader[137] != DBNull.Value)
            {
                PCO0040016 = (int?)reader[137];
            }
            if (reader[138] != DBNull.Value)
            {
                PCO0040017 = (int?)reader[138];
            }
            if (reader[139] != DBNull.Value)
            {
                PCO0040018 = (int?)reader[139];
            }
            if (reader[140] != DBNull.Value)
            {
                PCO0040019 = (int?)reader[140];
            }
            if (reader[141] != DBNull.Value)
            {
                PCO0040020 = (int?)reader[141];
            }
            if (reader[142] != DBNull.Value)
            {
                PCO0040021 = (int?)reader[142];
            }
            if (reader[143] != DBNull.Value)
            {
                PCO0040022 = (int?)reader[143];
            }
            if (reader[144] != DBNull.Value)
            {
                PCO0040023 = (int?)reader[144];
            }
            if (reader[145] != DBNull.Value)
            {
                PCO0040024 = (int?)reader[145];
            }
            if (reader[146] != DBNull.Value)
            {
                PCO0040025 = (int?)reader[146];
            }
            if (reader[147] != DBNull.Value)
            {
                PCO0040026 = (int?)reader[147];
            }
            if (reader[148] != DBNull.Value)
            {
                PCO0040027 = (int?)reader[148];
            }
            if (reader[149] != DBNull.Value)
            {
                PCO0040028 = (int?)reader[149];
            }
            if (reader[150] != DBNull.Value)
            {
                PCO0040029 = (int?)reader[150];
            }
            if (reader[151] != DBNull.Value)
            {
                PCO0040030 = (int?)reader[151];
            }
            if (reader[152] != DBNull.Value)
            {
                PCO0040031 = (int?)reader[152];
            }
            if (reader[153] != DBNull.Value)
            {
                PCO0040032 = (int?)reader[153];
            }
            if (reader[154] != DBNull.Value)
            {
                PCO0040033 = (int?)reader[154];
            }
            if (reader[155] != DBNull.Value)
            {
                PCO0040034 = (int?)reader[155];
            }
            if (reader[156] != DBNull.Value)
            {
                PCO0040035 = (int?)reader[156];
            }
            if (reader[157] != DBNull.Value)
            {
                PCO0040036 = (int?)reader[157];
            }
            if (reader[158] != DBNull.Value)
            {
                PCO0040037 = (int?)reader[158];
            }
            if (reader[159] != DBNull.Value)
            {
                PCO0040038 = (int?)reader[159];
            }
            if (reader[160] != DBNull.Value)
            {
                PCO0040039 = (int?)reader[160];
            }
            if (reader[161] != DBNull.Value)
            {
                PCO0050001 = (int?)reader[161];
            }
            if (reader[162] != DBNull.Value)
            {
                PCO0050002 = (int?)reader[162];
            }
            if (reader[163] != DBNull.Value)
            {
                PCO0050003 = (int?)reader[163];
            }
            if (reader[164] != DBNull.Value)
            {
                PCO0050004 = (int?)reader[164];
            }
            if (reader[165] != DBNull.Value)
            {
                PCO0050005 = (int?)reader[165];
            }
            if (reader[166] != DBNull.Value)
            {
                PCO0050006 = (int?)reader[166];
            }
            if (reader[167] != DBNull.Value)
            {
                PCO0050007 = (int?)reader[167];
            }
            if (reader[168] != DBNull.Value)
            {
                PCO0050008 = (int?)reader[168];
            }
            if (reader[169] != DBNull.Value)
            {
                PCO0050009 = (int?)reader[169];
            }
            if (reader[170] != DBNull.Value)
            {
                PCO0050010 = (int?)reader[170];
            }
            if (reader[171] != DBNull.Value)
            {
                PCO0050011 = (int?)reader[171];
            }
            if (reader[172] != DBNull.Value)
            {
                PCO0050012 = (int?)reader[172];
            }
            if (reader[173] != DBNull.Value)
            {
                PCO0050013 = (int?)reader[173];
            }
            if (reader[174] != DBNull.Value)
            {
                PCO0050014 = (int?)reader[174];
            }
            if (reader[175] != DBNull.Value)
            {
                PCO0050015 = (int?)reader[175];
            }
            if (reader[176] != DBNull.Value)
            {
                PCO0050016 = (int?)reader[176];
            }
            if (reader[177] != DBNull.Value)
            {
                PCO0050017 = (int?)reader[177];
            }
            if (reader[178] != DBNull.Value)
            {
                PCO0050018 = (int?)reader[178];
            }
            if (reader[179] != DBNull.Value)
            {
                PCO0050019 = (int?)reader[179];
            }
            if (reader[180] != DBNull.Value)
            {
                PCO0050020 = (int?)reader[180];
            }
            if (reader[181] != DBNull.Value)
            {
                PCO0050021 = (int?)reader[181];
            }
            if (reader[182] != DBNull.Value)
            {
                PCO0050022 = (int?)reader[182];
            }
            if (reader[183] != DBNull.Value)
            {
                PCO0050023 = (int?)reader[183];
            }
            if (reader[184] != DBNull.Value)
            {
                PCO0050024 = (int?)reader[184];
            }
            if (reader[185] != DBNull.Value)
            {
                PCO0050025 = (int?)reader[185];
            }
            if (reader[186] != DBNull.Value)
            {
                PCO0050026 = (int?)reader[186];
            }
            if (reader[187] != DBNull.Value)
            {
                PCO0050027 = (int?)reader[187];
            }
            if (reader[188] != DBNull.Value)
            {
                PCO0050028 = (int?)reader[188];
            }
            if (reader[189] != DBNull.Value)
            {
                PCO0050029 = (int?)reader[189];
            }
            if (reader[190] != DBNull.Value)
            {
                PCO0050030 = (int?)reader[190];
            }
            if (reader[191] != DBNull.Value)
            {
                PCO0050031 = (int?)reader[191];
            }
            if (reader[192] != DBNull.Value)
            {
                PCO0050032 = (int?)reader[192];
            }
            if (reader[193] != DBNull.Value)
            {
                PCO0050033 = (int?)reader[193];
            }
            if (reader[194] != DBNull.Value)
            {
                PCO0050034 = (int?)reader[194];
            }
            if (reader[195] != DBNull.Value)
            {
                PCO0050035 = (int?)reader[195];
            }
            if (reader[196] != DBNull.Value)
            {
                PCO0050036 = (int?)reader[196];
            }
            if (reader[197] != DBNull.Value)
            {
                PCO0050037 = (int?)reader[197];
            }
            if (reader[198] != DBNull.Value)
            {
                PCO0050038 = (int?)reader[198];
            }
            if (reader[199] != DBNull.Value)
            {
                PCO0050039 = (int?)reader[199];
            }
            if (reader[200] != DBNull.Value)
            {
                PCO0060001 = (int?)reader[200];
            }
            if (reader[201] != DBNull.Value)
            {
                PCO0060002 = (int?)reader[201];
            }
            if (reader[202] != DBNull.Value)
            {
                PCO0060003 = (int?)reader[202];
            }
            if (reader[203] != DBNull.Value)
            {
                PCO0060004 = (int?)reader[203];
            }
            if (reader[204] != DBNull.Value)
            {
                PCO0060005 = (int?)reader[204];
            }
            if (reader[205] != DBNull.Value)
            {
                PCO0060006 = (int?)reader[205];
            }
            if (reader[206] != DBNull.Value)
            {
                PCO0060007 = (int?)reader[206];
            }
            if (reader[207] != DBNull.Value)
            {
                PCO0060008 = (int?)reader[207];
            }
            if (reader[208] != DBNull.Value)
            {
                PCO0060009 = (int?)reader[208];
            }
            if (reader[209] != DBNull.Value)
            {
                PCO0060010 = (int?)reader[209];
            }
            if (reader[210] != DBNull.Value)
            {
                PCO0060011 = (int?)reader[210];
            }
            if (reader[211] != DBNull.Value)
            {
                PCO0060012 = (int?)reader[211];
            }
            if (reader[212] != DBNull.Value)
            {
                PCO0060013 = (int?)reader[212];
            }
            if (reader[213] != DBNull.Value)
            {
                PCO0060014 = (int?)reader[213];
            }
            if (reader[214] != DBNull.Value)
            {
                PCO0060015 = (int?)reader[214];
            }
            if (reader[215] != DBNull.Value)
            {
                PCO0060016 = (int?)reader[215];
            }
            if (reader[216] != DBNull.Value)
            {
                PCO0060017 = (int?)reader[216];
            }
            if (reader[217] != DBNull.Value)
            {
                PCO0060018 = (int?)reader[217];
            }
            if (reader[218] != DBNull.Value)
            {
                PCO0060019 = (int?)reader[218];
            }
            if (reader[219] != DBNull.Value)
            {
                PCO0060020 = (int?)reader[219];
            }
            if (reader[220] != DBNull.Value)
            {
                PCO0060021 = (int?)reader[220];
            }
            if (reader[221] != DBNull.Value)
            {
                PCO0060022 = (int?)reader[221];
            }
            if (reader[222] != DBNull.Value)
            {
                PCO0060023 = (int?)reader[222];
            }
            if (reader[223] != DBNull.Value)
            {
                PCO0060024 = (int?)reader[223];
            }
            if (reader[224] != DBNull.Value)
            {
                PCO0060025 = (int?)reader[224];
            }
            if (reader[225] != DBNull.Value)
            {
                PCO0060026 = (int?)reader[225];
            }
            if (reader[226] != DBNull.Value)
            {
                PCO0060027 = (int?)reader[226];
            }
            if (reader[227] != DBNull.Value)
            {
                PCO0060028 = (int?)reader[227];
            }
            if (reader[228] != DBNull.Value)
            {
                PCO0060029 = (int?)reader[228];
            }
            if (reader[229] != DBNull.Value)
            {
                PCO0060030 = (int?)reader[229];
            }
            if (reader[230] != DBNull.Value)
            {
                PCO0060031 = (int?)reader[230];
            }
            if (reader[231] != DBNull.Value)
            {
                PCO0060032 = (int?)reader[231];
            }
            if (reader[232] != DBNull.Value)
            {
                PCO0060033 = (int?)reader[232];
            }
            if (reader[233] != DBNull.Value)
            {
                PCO0060034 = (int?)reader[233];
            }
            if (reader[234] != DBNull.Value)
            {
                PCO0060035 = (int?)reader[234];
            }
            if (reader[235] != DBNull.Value)
            {
                PCO0060036 = (int?)reader[235];
            }
            if (reader[236] != DBNull.Value)
            {
                PCO0060037 = (int?)reader[236];
            }
            if (reader[237] != DBNull.Value)
            {
                PCO0060038 = (int?)reader[237];
            }
            if (reader[238] != DBNull.Value)
            {
                PCO0060039 = (int?)reader[238];
            }
        }
        #endregion Constructors
    }
}
