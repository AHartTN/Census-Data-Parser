#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2016 11:36 AM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryOne_SF1_00027.cs
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

    public class SummaryOne_SF1_00027 : BaseModel
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
        [Column("PCT012H001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public int? PCT012H001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 6)]
        public int? PCT012H002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 1 year", ShortName = "Under 1 year", Order = 7)]
        public int? PCT012H003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1 year", ShortName = "1 year", Order = 8)]
        public int? PCT012H004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2 years", ShortName = "2 years", Order = 9)]
        public int? PCT012H005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 years", ShortName = "3 years", Order = 10)]
        public int? PCT012H006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4 years", ShortName = "4 years", Order = 11)]
        public int? PCT012H007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 12)]
        public int? PCT012H008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 years", ShortName = "6 years", Order = 13)]
        public int? PCT012H009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7 years", ShortName = "7 years", Order = 14)]
        public int? PCT012H010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "8 years", ShortName = "8 years", Order = 15)]
        public int? PCT012H011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "9 years", ShortName = "9 years", Order = 16)]
        public int? PCT012H012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 years", ShortName = "10 years", Order = 17)]
        public int? PCT012H013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "11 years", ShortName = "11 years", Order = 18)]
        public int? PCT012H014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 years", ShortName = "12 years", Order = 19)]
        public int? PCT012H015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "13 years", ShortName = "13 years", Order = 20)]
        public int? PCT012H016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H017", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "14 years", ShortName = "14 years", Order = 21)]
        public int? PCT012H017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H018", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 years", ShortName = "15 years", Order = 22)]
        public int? PCT012H018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H019", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "16 years", ShortName = "16 years", Order = 23)]
        public int? PCT012H019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H020", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "17 years", ShortName = "17 years", Order = 24)]
        public int? PCT012H020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H021", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years", ShortName = "18 years", Order = 25)]
        public int? PCT012H021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H022", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "19 years", ShortName = "19 years", Order = 26)]
        public int? PCT012H022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H023", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 27)]
        public int? PCT012H023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H024", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 28)]
        public int? PCT012H024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H025", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 years", ShortName = "22 years", Order = 29)]
        public int? PCT012H025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H026", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "23 years", ShortName = "23 years", Order = 30)]
        public int? PCT012H026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H027", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "24 years", ShortName = "24 years", Order = 31)]
        public int? PCT012H027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H028", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 years", ShortName = "25 years", Order = 32)]
        public int? PCT012H028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H029", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "26 years", ShortName = "26 years", Order = 33)]
        public int? PCT012H029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H030", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "27 years", ShortName = "27 years", Order = 34)]
        public int? PCT012H030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H031", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "28 years", ShortName = "28 years", Order = 35)]
        public int? PCT012H031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H032", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "29 years", ShortName = "29 years", Order = 36)]
        public int? PCT012H032 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H033", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 years", ShortName = "30 years", Order = 37)]
        public int? PCT012H033 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H034", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "31 years", ShortName = "31 years", Order = 38)]
        public int? PCT012H034 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H035", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "32 years", ShortName = "32 years", Order = 39)]
        public int? PCT012H035 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H036", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "33 years", ShortName = "33 years", Order = 40)]
        public int? PCT012H036 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H037", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "34 years", ShortName = "34 years", Order = 41)]
        public int? PCT012H037 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H038", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 years", ShortName = "35 years", Order = 42)]
        public int? PCT012H038 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H039", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "36 years", ShortName = "36 years", Order = 43)]
        public int? PCT012H039 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H040", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "37 years", ShortName = "37 years", Order = 44)]
        public int? PCT012H040 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H041", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "38 years", ShortName = "38 years", Order = 45)]
        public int? PCT012H041 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H042", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "39 years", ShortName = "39 years", Order = 46)]
        public int? PCT012H042 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H043", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 years", ShortName = "40 years", Order = 47)]
        public int? PCT012H043 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H044", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "41 years", ShortName = "41 years", Order = 48)]
        public int? PCT012H044 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H045", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "42 years", ShortName = "42 years", Order = 49)]
        public int? PCT012H045 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H046", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "43 years", ShortName = "43 years", Order = 50)]
        public int? PCT012H046 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H047", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "44 years", ShortName = "44 years", Order = 51)]
        public int? PCT012H047 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H048", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 years", ShortName = "45 years", Order = 52)]
        public int? PCT012H048 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H049", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "46 years", ShortName = "46 years", Order = 53)]
        public int? PCT012H049 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H050", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "47 years", ShortName = "47 years", Order = 54)]
        public int? PCT012H050 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H051", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "48 years", ShortName = "48 years", Order = 55)]
        public int? PCT012H051 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H052", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "49 years", ShortName = "49 years", Order = 56)]
        public int? PCT012H052 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H053", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 years", ShortName = "50 years", Order = 57)]
        public int? PCT012H053 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H054", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "51 years", ShortName = "51 years", Order = 58)]
        public int? PCT012H054 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H055", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "52 years", ShortName = "52 years", Order = 59)]
        public int? PCT012H055 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H056", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "53 years", ShortName = "53 years", Order = 60)]
        public int? PCT012H056 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H057", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "54 years", ShortName = "54 years", Order = 61)]
        public int? PCT012H057 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H058", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 years", ShortName = "55 years", Order = 62)]
        public int? PCT012H058 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H059", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "56 years", ShortName = "56 years", Order = 63)]
        public int? PCT012H059 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H060", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "57 years", ShortName = "57 years", Order = 64)]
        public int? PCT012H060 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H061", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "58 years", ShortName = "58 years", Order = 65)]
        public int? PCT012H061 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H062", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "59 years", ShortName = "59 years", Order = 66)]
        public int? PCT012H062 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H063", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 years", ShortName = "60 years", Order = 67)]
        public int? PCT012H063 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H064", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "61 years", ShortName = "61 years", Order = 68)]
        public int? PCT012H064 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H065", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 years", ShortName = "62 years", Order = 69)]
        public int? PCT012H065 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H066", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "63 years", ShortName = "63 years", Order = 70)]
        public int? PCT012H066 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H067", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "64 years", ShortName = "64 years", Order = 71)]
        public int? PCT012H067 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H068", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 years", ShortName = "65 years", Order = 72)]
        public int? PCT012H068 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H069", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "66 years", ShortName = "66 years", Order = 73)]
        public int? PCT012H069 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H070", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 years", ShortName = "67 years", Order = 74)]
        public int? PCT012H070 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H071", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "68 years", ShortName = "68 years", Order = 75)]
        public int? PCT012H071 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H072", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "69 years", ShortName = "69 years", Order = 76)]
        public int? PCT012H072 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H073", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 years", ShortName = "70 years", Order = 77)]
        public int? PCT012H073 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H074", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "71 years", ShortName = "71 years", Order = 78)]
        public int? PCT012H074 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H075", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "72 years", ShortName = "72 years", Order = 79)]
        public int? PCT012H075 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H076", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "73 years", ShortName = "73 years", Order = 80)]
        public int? PCT012H076 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H077", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "74 years", ShortName = "74 years", Order = 81)]
        public int? PCT012H077 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H078", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 years", ShortName = "75 years", Order = 82)]
        public int? PCT012H078 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H079", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "76 years", ShortName = "76 years", Order = 83)]
        public int? PCT012H079 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H080", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "77 years", ShortName = "77 years", Order = 84)]
        public int? PCT012H080 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H081", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "78 years", ShortName = "78 years", Order = 85)]
        public int? PCT012H081 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H082", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "79 years", ShortName = "79 years", Order = 86)]
        public int? PCT012H082 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H083", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 years", ShortName = "80 years", Order = 87)]
        public int? PCT012H083 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H084", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "81 years", ShortName = "81 years", Order = 88)]
        public int? PCT012H084 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H085", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "82 years", ShortName = "82 years", Order = 89)]
        public int? PCT012H085 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H086", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "83 years", ShortName = "83 years", Order = 90)]
        public int? PCT012H086 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H087", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "84 years", ShortName = "84 years", Order = 91)]
        public int? PCT012H087 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H088", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years", ShortName = "85 years", Order = 92)]
        public int? PCT012H088 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H089", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "86 years", ShortName = "86 years", Order = 93)]
        public int? PCT012H089 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H090", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "87 years", ShortName = "87 years", Order = 94)]
        public int? PCT012H090 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H091", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "88 years", ShortName = "88 years", Order = 95)]
        public int? PCT012H091 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H092", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "89 years", ShortName = "89 years", Order = 96)]
        public int? PCT012H092 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H093", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "90 years", ShortName = "90 years", Order = 97)]
        public int? PCT012H093 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H094", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "91 years", ShortName = "91 years", Order = 98)]
        public int? PCT012H094 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H095", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "92 years", ShortName = "92 years", Order = 99)]
        public int? PCT012H095 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H096", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "93 years", ShortName = "93 years", Order = 100)]
        public int? PCT012H096 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H097", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "94 years", ShortName = "94 years", Order = 101)]
        public int? PCT012H097 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H098", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "95 years", ShortName = "95 years", Order = 102)]
        public int? PCT012H098 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H099", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "96 years", ShortName = "96 years", Order = 103)]
        public int? PCT012H099 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H100", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "97 years", ShortName = "97 years", Order = 104)]
        public int? PCT012H100 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H101", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "98 years", ShortName = "98 years", Order = 105)]
        public int? PCT012H101 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H102", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "99 years", ShortName = "99 years", Order = 106)]
        public int? PCT012H102 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H103", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "100 to 104 years", ShortName = "100 to 104 years", Order = 107)]
        public int? PCT012H103 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H104", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "105 to 109 years", ShortName = "105 to 109 years", Order = 108)]
        public int? PCT012H104 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H105", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "110 years and over", ShortName = "110 years and over", Order = 109)]
        public int? PCT012H105 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H106", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 110)]
        public int? PCT012H106 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H107", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 1 year", ShortName = "Under 1 year", Order = 111)]
        public int? PCT012H107 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H108", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1 year", ShortName = "1 year", Order = 112)]
        public int? PCT012H108 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H109", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2 years", ShortName = "2 years", Order = 113)]
        public int? PCT012H109 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H110", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 years", ShortName = "3 years", Order = 114)]
        public int? PCT012H110 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H111", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4 years", ShortName = "4 years", Order = 115)]
        public int? PCT012H111 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H112", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 116)]
        public int? PCT012H112 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H113", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 years", ShortName = "6 years", Order = 117)]
        public int? PCT012H113 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H114", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7 years", ShortName = "7 years", Order = 118)]
        public int? PCT012H114 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H115", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "8 years", ShortName = "8 years", Order = 119)]
        public int? PCT012H115 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H116", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "9 years", ShortName = "9 years", Order = 120)]
        public int? PCT012H116 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H117", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 years", ShortName = "10 years", Order = 121)]
        public int? PCT012H117 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H118", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "11 years", ShortName = "11 years", Order = 122)]
        public int? PCT012H118 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H119", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 years", ShortName = "12 years", Order = 123)]
        public int? PCT012H119 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H120", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "13 years", ShortName = "13 years", Order = 124)]
        public int? PCT012H120 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H121", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "14 years", ShortName = "14 years", Order = 125)]
        public int? PCT012H121 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H122", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 years", ShortName = "15 years", Order = 126)]
        public int? PCT012H122 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H123", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "16 years", ShortName = "16 years", Order = 127)]
        public int? PCT012H123 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H124", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "17 years", ShortName = "17 years", Order = 128)]
        public int? PCT012H124 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H125", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years", ShortName = "18 years", Order = 129)]
        public int? PCT012H125 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H126", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "19 years", ShortName = "19 years", Order = 130)]
        public int? PCT012H126 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H127", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 131)]
        public int? PCT012H127 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H128", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 132)]
        public int? PCT012H128 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H129", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 years", ShortName = "22 years", Order = 133)]
        public int? PCT012H129 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H130", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "23 years", ShortName = "23 years", Order = 134)]
        public int? PCT012H130 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H131", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "24 years", ShortName = "24 years", Order = 135)]
        public int? PCT012H131 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H132", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 years", ShortName = "25 years", Order = 136)]
        public int? PCT012H132 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H133", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "26 years", ShortName = "26 years", Order = 137)]
        public int? PCT012H133 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H134", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "27 years", ShortName = "27 years", Order = 138)]
        public int? PCT012H134 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H135", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "28 years", ShortName = "28 years", Order = 139)]
        public int? PCT012H135 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H136", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "29 years", ShortName = "29 years", Order = 140)]
        public int? PCT012H136 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H137", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 years", ShortName = "30 years", Order = 141)]
        public int? PCT012H137 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H138", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "31 years", ShortName = "31 years", Order = 142)]
        public int? PCT012H138 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H139", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "32 years", ShortName = "32 years", Order = 143)]
        public int? PCT012H139 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H140", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "33 years", ShortName = "33 years", Order = 144)]
        public int? PCT012H140 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H141", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "34 years", ShortName = "34 years", Order = 145)]
        public int? PCT012H141 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H142", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 years", ShortName = "35 years", Order = 146)]
        public int? PCT012H142 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H143", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "36 years", ShortName = "36 years", Order = 147)]
        public int? PCT012H143 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H144", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "37 years", ShortName = "37 years", Order = 148)]
        public int? PCT012H144 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H145", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "38 years", ShortName = "38 years", Order = 149)]
        public int? PCT012H145 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H146", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "39 years", ShortName = "39 years", Order = 150)]
        public int? PCT012H146 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H147", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 years", ShortName = "40 years", Order = 151)]
        public int? PCT012H147 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H148", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "41 years", ShortName = "41 years", Order = 152)]
        public int? PCT012H148 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H149", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "42 years", ShortName = "42 years", Order = 153)]
        public int? PCT012H149 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H150", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "43 years", ShortName = "43 years", Order = 154)]
        public int? PCT012H150 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H151", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "44 years", ShortName = "44 years", Order = 155)]
        public int? PCT012H151 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H152", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 years", ShortName = "45 years", Order = 156)]
        public int? PCT012H152 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H153", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "46 years", ShortName = "46 years", Order = 157)]
        public int? PCT012H153 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H154", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "47 years", ShortName = "47 years", Order = 158)]
        public int? PCT012H154 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H155", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "48 years", ShortName = "48 years", Order = 159)]
        public int? PCT012H155 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H156", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "49 years", ShortName = "49 years", Order = 160)]
        public int? PCT012H156 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H157", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 years", ShortName = "50 years", Order = 161)]
        public int? PCT012H157 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H158", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "51 years", ShortName = "51 years", Order = 162)]
        public int? PCT012H158 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H159", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "52 years", ShortName = "52 years", Order = 163)]
        public int? PCT012H159 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H160", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "53 years", ShortName = "53 years", Order = 164)]
        public int? PCT012H160 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H161", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "54 years", ShortName = "54 years", Order = 165)]
        public int? PCT012H161 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H162", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 years", ShortName = "55 years", Order = 166)]
        public int? PCT012H162 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H163", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "56 years", ShortName = "56 years", Order = 167)]
        public int? PCT012H163 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H164", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "57 years", ShortName = "57 years", Order = 168)]
        public int? PCT012H164 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H165", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "58 years", ShortName = "58 years", Order = 169)]
        public int? PCT012H165 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H166", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "59 years", ShortName = "59 years", Order = 170)]
        public int? PCT012H166 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H167", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 years", ShortName = "60 years", Order = 171)]
        public int? PCT012H167 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H168", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "61 years", ShortName = "61 years", Order = 172)]
        public int? PCT012H168 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H169", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 years", ShortName = "62 years", Order = 173)]
        public int? PCT012H169 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H170", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "63 years", ShortName = "63 years", Order = 174)]
        public int? PCT012H170 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H171", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "64 years", ShortName = "64 years", Order = 175)]
        public int? PCT012H171 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H172", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 years", ShortName = "65 years", Order = 176)]
        public int? PCT012H172 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H173", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "66 years", ShortName = "66 years", Order = 177)]
        public int? PCT012H173 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H174", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 years", ShortName = "67 years", Order = 178)]
        public int? PCT012H174 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H175", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "68 years", ShortName = "68 years", Order = 179)]
        public int? PCT012H175 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H176", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "69 years", ShortName = "69 years", Order = 180)]
        public int? PCT012H176 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H177", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 years", ShortName = "70 years", Order = 181)]
        public int? PCT012H177 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H178", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "71 years", ShortName = "71 years", Order = 182)]
        public int? PCT012H178 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H179", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "72 years", ShortName = "72 years", Order = 183)]
        public int? PCT012H179 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H180", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "73 years", ShortName = "73 years", Order = 184)]
        public int? PCT012H180 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H181", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "74 years", ShortName = "74 years", Order = 185)]
        public int? PCT012H181 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H182", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 years", ShortName = "75 years", Order = 186)]
        public int? PCT012H182 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H183", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "76 years", ShortName = "76 years", Order = 187)]
        public int? PCT012H183 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H184", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "77 years", ShortName = "77 years", Order = 188)]
        public int? PCT012H184 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H185", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "78 years", ShortName = "78 years", Order = 189)]
        public int? PCT012H185 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H186", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "79 years", ShortName = "79 years", Order = 190)]
        public int? PCT012H186 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H187", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 years", ShortName = "80 years", Order = 191)]
        public int? PCT012H187 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H188", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "81 years", ShortName = "81 years", Order = 192)]
        public int? PCT012H188 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H189", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "82 years", ShortName = "82 years", Order = 193)]
        public int? PCT012H189 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H190", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "83 years", ShortName = "83 years", Order = 194)]
        public int? PCT012H190 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H191", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "84 years", ShortName = "84 years", Order = 195)]
        public int? PCT012H191 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H192", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years", ShortName = "85 years", Order = 196)]
        public int? PCT012H192 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H193", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "86 years", ShortName = "86 years", Order = 197)]
        public int? PCT012H193 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H194", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "87 years", ShortName = "87 years", Order = 198)]
        public int? PCT012H194 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H195", Order = 199)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "88 years", ShortName = "88 years", Order = 199)]
        public int? PCT012H195 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H196", Order = 200)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "89 years", ShortName = "89 years", Order = 200)]
        public int? PCT012H196 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H197", Order = 201)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "90 years", ShortName = "90 years", Order = 201)]
        public int? PCT012H197 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H198", Order = 202)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "91 years", ShortName = "91 years", Order = 202)]
        public int? PCT012H198 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H199", Order = 203)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "92 years", ShortName = "92 years", Order = 203)]
        public int? PCT012H199 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H200", Order = 204)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "93 years", ShortName = "93 years", Order = 204)]
        public int? PCT012H200 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H201", Order = 205)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "94 years", ShortName = "94 years", Order = 205)]
        public int? PCT012H201 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H202", Order = 206)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "95 years", ShortName = "95 years", Order = 206)]
        public int? PCT012H202 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H203", Order = 207)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "96 years", ShortName = "96 years", Order = 207)]
        public int? PCT012H203 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H204", Order = 208)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "97 years", ShortName = "97 years", Order = 208)]
        public int? PCT012H204 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H205", Order = 209)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "98 years", ShortName = "98 years", Order = 209)]
        public int? PCT012H205 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H206", Order = 210)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "99 years", ShortName = "99 years", Order = 210)]
        public int? PCT012H206 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H207", Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "100 to 104 years", ShortName = "100 to 104 years", Order = 211)]
        public int? PCT012H207 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H208", Order = 212)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "105 to 109 years", ShortName = "105 to 109 years", Order = 212)]
        public int? PCT012H208 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012H209", Order = 213)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "110 years and over", ShortName = "110 years and over", Order = 213)]
        public int? PCT012H209 { get; set; }
        #endregion Properties

        #region Constructors
        public SummaryOne_SF1_00027(string csvLine) : base(csvLine) { }

        public SummaryOne_SF1_00027(string[] values) : base(values) { }

        public SummaryOne_SF1_00027(OleDbDataReader reader, CensusFileType fileType)
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
                PCT012H001 = (int?)reader[5];
            }
            if (reader[6] != DBNull.Value)
            {
                PCT012H002 = (int?)reader[6];
            }
            if (reader[7] != DBNull.Value)
            {
                PCT012H003 = (int?)reader[7];
            }
            if (reader[8] != DBNull.Value)
            {
                PCT012H004 = (int?)reader[8];
            }
            if (reader[9] != DBNull.Value)
            {
                PCT012H005 = (int?)reader[9];
            }
            if (reader[10] != DBNull.Value)
            {
                PCT012H006 = (int?)reader[10];
            }
            if (reader[11] != DBNull.Value)
            {
                PCT012H007 = (int?)reader[11];
            }
            if (reader[12] != DBNull.Value)
            {
                PCT012H008 = (int?)reader[12];
            }
            if (reader[13] != DBNull.Value)
            {
                PCT012H009 = (int?)reader[13];
            }
            if (reader[14] != DBNull.Value)
            {
                PCT012H010 = (int?)reader[14];
            }
            if (reader[15] != DBNull.Value)
            {
                PCT012H011 = (int?)reader[15];
            }
            if (reader[16] != DBNull.Value)
            {
                PCT012H012 = (int?)reader[16];
            }
            if (reader[17] != DBNull.Value)
            {
                PCT012H013 = (int?)reader[17];
            }
            if (reader[18] != DBNull.Value)
            {
                PCT012H014 = (int?)reader[18];
            }
            if (reader[19] != DBNull.Value)
            {
                PCT012H015 = (int?)reader[19];
            }
            if (reader[20] != DBNull.Value)
            {
                PCT012H016 = (int?)reader[20];
            }
            if (reader[21] != DBNull.Value)
            {
                PCT012H017 = (int?)reader[21];
            }
            if (reader[22] != DBNull.Value)
            {
                PCT012H018 = (int?)reader[22];
            }
            if (reader[23] != DBNull.Value)
            {
                PCT012H019 = (int?)reader[23];
            }
            if (reader[24] != DBNull.Value)
            {
                PCT012H020 = (int?)reader[24];
            }
            if (reader[25] != DBNull.Value)
            {
                PCT012H021 = (int?)reader[25];
            }
            if (reader[26] != DBNull.Value)
            {
                PCT012H022 = (int?)reader[26];
            }
            if (reader[27] != DBNull.Value)
            {
                PCT012H023 = (int?)reader[27];
            }
            if (reader[28] != DBNull.Value)
            {
                PCT012H024 = (int?)reader[28];
            }
            if (reader[29] != DBNull.Value)
            {
                PCT012H025 = (int?)reader[29];
            }
            if (reader[30] != DBNull.Value)
            {
                PCT012H026 = (int?)reader[30];
            }
            if (reader[31] != DBNull.Value)
            {
                PCT012H027 = (int?)reader[31];
            }
            if (reader[32] != DBNull.Value)
            {
                PCT012H028 = (int?)reader[32];
            }
            if (reader[33] != DBNull.Value)
            {
                PCT012H029 = (int?)reader[33];
            }
            if (reader[34] != DBNull.Value)
            {
                PCT012H030 = (int?)reader[34];
            }
            if (reader[35] != DBNull.Value)
            {
                PCT012H031 = (int?)reader[35];
            }
            if (reader[36] != DBNull.Value)
            {
                PCT012H032 = (int?)reader[36];
            }
            if (reader[37] != DBNull.Value)
            {
                PCT012H033 = (int?)reader[37];
            }
            if (reader[38] != DBNull.Value)
            {
                PCT012H034 = (int?)reader[38];
            }
            if (reader[39] != DBNull.Value)
            {
                PCT012H035 = (int?)reader[39];
            }
            if (reader[40] != DBNull.Value)
            {
                PCT012H036 = (int?)reader[40];
            }
            if (reader[41] != DBNull.Value)
            {
                PCT012H037 = (int?)reader[41];
            }
            if (reader[42] != DBNull.Value)
            {
                PCT012H038 = (int?)reader[42];
            }
            if (reader[43] != DBNull.Value)
            {
                PCT012H039 = (int?)reader[43];
            }
            if (reader[44] != DBNull.Value)
            {
                PCT012H040 = (int?)reader[44];
            }
            if (reader[45] != DBNull.Value)
            {
                PCT012H041 = (int?)reader[45];
            }
            if (reader[46] != DBNull.Value)
            {
                PCT012H042 = (int?)reader[46];
            }
            if (reader[47] != DBNull.Value)
            {
                PCT012H043 = (int?)reader[47];
            }
            if (reader[48] != DBNull.Value)
            {
                PCT012H044 = (int?)reader[48];
            }
            if (reader[49] != DBNull.Value)
            {
                PCT012H045 = (int?)reader[49];
            }
            if (reader[50] != DBNull.Value)
            {
                PCT012H046 = (int?)reader[50];
            }
            if (reader[51] != DBNull.Value)
            {
                PCT012H047 = (int?)reader[51];
            }
            if (reader[52] != DBNull.Value)
            {
                PCT012H048 = (int?)reader[52];
            }
            if (reader[53] != DBNull.Value)
            {
                PCT012H049 = (int?)reader[53];
            }
            if (reader[54] != DBNull.Value)
            {
                PCT012H050 = (int?)reader[54];
            }
            if (reader[55] != DBNull.Value)
            {
                PCT012H051 = (int?)reader[55];
            }
            if (reader[56] != DBNull.Value)
            {
                PCT012H052 = (int?)reader[56];
            }
            if (reader[57] != DBNull.Value)
            {
                PCT012H053 = (int?)reader[57];
            }
            if (reader[58] != DBNull.Value)
            {
                PCT012H054 = (int?)reader[58];
            }
            if (reader[59] != DBNull.Value)
            {
                PCT012H055 = (int?)reader[59];
            }
            if (reader[60] != DBNull.Value)
            {
                PCT012H056 = (int?)reader[60];
            }
            if (reader[61] != DBNull.Value)
            {
                PCT012H057 = (int?)reader[61];
            }
            if (reader[62] != DBNull.Value)
            {
                PCT012H058 = (int?)reader[62];
            }
            if (reader[63] != DBNull.Value)
            {
                PCT012H059 = (int?)reader[63];
            }
            if (reader[64] != DBNull.Value)
            {
                PCT012H060 = (int?)reader[64];
            }
            if (reader[65] != DBNull.Value)
            {
                PCT012H061 = (int?)reader[65];
            }
            if (reader[66] != DBNull.Value)
            {
                PCT012H062 = (int?)reader[66];
            }
            if (reader[67] != DBNull.Value)
            {
                PCT012H063 = (int?)reader[67];
            }
            if (reader[68] != DBNull.Value)
            {
                PCT012H064 = (int?)reader[68];
            }
            if (reader[69] != DBNull.Value)
            {
                PCT012H065 = (int?)reader[69];
            }
            if (reader[70] != DBNull.Value)
            {
                PCT012H066 = (int?)reader[70];
            }
            if (reader[71] != DBNull.Value)
            {
                PCT012H067 = (int?)reader[71];
            }
            if (reader[72] != DBNull.Value)
            {
                PCT012H068 = (int?)reader[72];
            }
            if (reader[73] != DBNull.Value)
            {
                PCT012H069 = (int?)reader[73];
            }
            if (reader[74] != DBNull.Value)
            {
                PCT012H070 = (int?)reader[74];
            }
            if (reader[75] != DBNull.Value)
            {
                PCT012H071 = (int?)reader[75];
            }
            if (reader[76] != DBNull.Value)
            {
                PCT012H072 = (int?)reader[76];
            }
            if (reader[77] != DBNull.Value)
            {
                PCT012H073 = (int?)reader[77];
            }
            if (reader[78] != DBNull.Value)
            {
                PCT012H074 = (int?)reader[78];
            }
            if (reader[79] != DBNull.Value)
            {
                PCT012H075 = (int?)reader[79];
            }
            if (reader[80] != DBNull.Value)
            {
                PCT012H076 = (int?)reader[80];
            }
            if (reader[81] != DBNull.Value)
            {
                PCT012H077 = (int?)reader[81];
            }
            if (reader[82] != DBNull.Value)
            {
                PCT012H078 = (int?)reader[82];
            }
            if (reader[83] != DBNull.Value)
            {
                PCT012H079 = (int?)reader[83];
            }
            if (reader[84] != DBNull.Value)
            {
                PCT012H080 = (int?)reader[84];
            }
            if (reader[85] != DBNull.Value)
            {
                PCT012H081 = (int?)reader[85];
            }
            if (reader[86] != DBNull.Value)
            {
                PCT012H082 = (int?)reader[86];
            }
            if (reader[87] != DBNull.Value)
            {
                PCT012H083 = (int?)reader[87];
            }
            if (reader[88] != DBNull.Value)
            {
                PCT012H084 = (int?)reader[88];
            }
            if (reader[89] != DBNull.Value)
            {
                PCT012H085 = (int?)reader[89];
            }
            if (reader[90] != DBNull.Value)
            {
                PCT012H086 = (int?)reader[90];
            }
            if (reader[91] != DBNull.Value)
            {
                PCT012H087 = (int?)reader[91];
            }
            if (reader[92] != DBNull.Value)
            {
                PCT012H088 = (int?)reader[92];
            }
            if (reader[93] != DBNull.Value)
            {
                PCT012H089 = (int?)reader[93];
            }
            if (reader[94] != DBNull.Value)
            {
                PCT012H090 = (int?)reader[94];
            }
            if (reader[95] != DBNull.Value)
            {
                PCT012H091 = (int?)reader[95];
            }
            if (reader[96] != DBNull.Value)
            {
                PCT012H092 = (int?)reader[96];
            }
            if (reader[97] != DBNull.Value)
            {
                PCT012H093 = (int?)reader[97];
            }
            if (reader[98] != DBNull.Value)
            {
                PCT012H094 = (int?)reader[98];
            }
            if (reader[99] != DBNull.Value)
            {
                PCT012H095 = (int?)reader[99];
            }
            if (reader[100] != DBNull.Value)
            {
                PCT012H096 = (int?)reader[100];
            }
            if (reader[101] != DBNull.Value)
            {
                PCT012H097 = (int?)reader[101];
            }
            if (reader[102] != DBNull.Value)
            {
                PCT012H098 = (int?)reader[102];
            }
            if (reader[103] != DBNull.Value)
            {
                PCT012H099 = (int?)reader[103];
            }
            if (reader[104] != DBNull.Value)
            {
                PCT012H100 = (int?)reader[104];
            }
            if (reader[105] != DBNull.Value)
            {
                PCT012H101 = (int?)reader[105];
            }
            if (reader[106] != DBNull.Value)
            {
                PCT012H102 = (int?)reader[106];
            }
            if (reader[107] != DBNull.Value)
            {
                PCT012H103 = (int?)reader[107];
            }
            if (reader[108] != DBNull.Value)
            {
                PCT012H104 = (int?)reader[108];
            }
            if (reader[109] != DBNull.Value)
            {
                PCT012H105 = (int?)reader[109];
            }
            if (reader[110] != DBNull.Value)
            {
                PCT012H106 = (int?)reader[110];
            }
            if (reader[111] != DBNull.Value)
            {
                PCT012H107 = (int?)reader[111];
            }
            if (reader[112] != DBNull.Value)
            {
                PCT012H108 = (int?)reader[112];
            }
            if (reader[113] != DBNull.Value)
            {
                PCT012H109 = (int?)reader[113];
            }
            if (reader[114] != DBNull.Value)
            {
                PCT012H110 = (int?)reader[114];
            }
            if (reader[115] != DBNull.Value)
            {
                PCT012H111 = (int?)reader[115];
            }
            if (reader[116] != DBNull.Value)
            {
                PCT012H112 = (int?)reader[116];
            }
            if (reader[117] != DBNull.Value)
            {
                PCT012H113 = (int?)reader[117];
            }
            if (reader[118] != DBNull.Value)
            {
                PCT012H114 = (int?)reader[118];
            }
            if (reader[119] != DBNull.Value)
            {
                PCT012H115 = (int?)reader[119];
            }
            if (reader[120] != DBNull.Value)
            {
                PCT012H116 = (int?)reader[120];
            }
            if (reader[121] != DBNull.Value)
            {
                PCT012H117 = (int?)reader[121];
            }
            if (reader[122] != DBNull.Value)
            {
                PCT012H118 = (int?)reader[122];
            }
            if (reader[123] != DBNull.Value)
            {
                PCT012H119 = (int?)reader[123];
            }
            if (reader[124] != DBNull.Value)
            {
                PCT012H120 = (int?)reader[124];
            }
            if (reader[125] != DBNull.Value)
            {
                PCT012H121 = (int?)reader[125];
            }
            if (reader[126] != DBNull.Value)
            {
                PCT012H122 = (int?)reader[126];
            }
            if (reader[127] != DBNull.Value)
            {
                PCT012H123 = (int?)reader[127];
            }
            if (reader[128] != DBNull.Value)
            {
                PCT012H124 = (int?)reader[128];
            }
            if (reader[129] != DBNull.Value)
            {
                PCT012H125 = (int?)reader[129];
            }
            if (reader[130] != DBNull.Value)
            {
                PCT012H126 = (int?)reader[130];
            }
            if (reader[131] != DBNull.Value)
            {
                PCT012H127 = (int?)reader[131];
            }
            if (reader[132] != DBNull.Value)
            {
                PCT012H128 = (int?)reader[132];
            }
            if (reader[133] != DBNull.Value)
            {
                PCT012H129 = (int?)reader[133];
            }
            if (reader[134] != DBNull.Value)
            {
                PCT012H130 = (int?)reader[134];
            }
            if (reader[135] != DBNull.Value)
            {
                PCT012H131 = (int?)reader[135];
            }
            if (reader[136] != DBNull.Value)
            {
                PCT012H132 = (int?)reader[136];
            }
            if (reader[137] != DBNull.Value)
            {
                PCT012H133 = (int?)reader[137];
            }
            if (reader[138] != DBNull.Value)
            {
                PCT012H134 = (int?)reader[138];
            }
            if (reader[139] != DBNull.Value)
            {
                PCT012H135 = (int?)reader[139];
            }
            if (reader[140] != DBNull.Value)
            {
                PCT012H136 = (int?)reader[140];
            }
            if (reader[141] != DBNull.Value)
            {
                PCT012H137 = (int?)reader[141];
            }
            if (reader[142] != DBNull.Value)
            {
                PCT012H138 = (int?)reader[142];
            }
            if (reader[143] != DBNull.Value)
            {
                PCT012H139 = (int?)reader[143];
            }
            if (reader[144] != DBNull.Value)
            {
                PCT012H140 = (int?)reader[144];
            }
            if (reader[145] != DBNull.Value)
            {
                PCT012H141 = (int?)reader[145];
            }
            if (reader[146] != DBNull.Value)
            {
                PCT012H142 = (int?)reader[146];
            }
            if (reader[147] != DBNull.Value)
            {
                PCT012H143 = (int?)reader[147];
            }
            if (reader[148] != DBNull.Value)
            {
                PCT012H144 = (int?)reader[148];
            }
            if (reader[149] != DBNull.Value)
            {
                PCT012H145 = (int?)reader[149];
            }
            if (reader[150] != DBNull.Value)
            {
                PCT012H146 = (int?)reader[150];
            }
            if (reader[151] != DBNull.Value)
            {
                PCT012H147 = (int?)reader[151];
            }
            if (reader[152] != DBNull.Value)
            {
                PCT012H148 = (int?)reader[152];
            }
            if (reader[153] != DBNull.Value)
            {
                PCT012H149 = (int?)reader[153];
            }
            if (reader[154] != DBNull.Value)
            {
                PCT012H150 = (int?)reader[154];
            }
            if (reader[155] != DBNull.Value)
            {
                PCT012H151 = (int?)reader[155];
            }
            if (reader[156] != DBNull.Value)
            {
                PCT012H152 = (int?)reader[156];
            }
            if (reader[157] != DBNull.Value)
            {
                PCT012H153 = (int?)reader[157];
            }
            if (reader[158] != DBNull.Value)
            {
                PCT012H154 = (int?)reader[158];
            }
            if (reader[159] != DBNull.Value)
            {
                PCT012H155 = (int?)reader[159];
            }
            if (reader[160] != DBNull.Value)
            {
                PCT012H156 = (int?)reader[160];
            }
            if (reader[161] != DBNull.Value)
            {
                PCT012H157 = (int?)reader[161];
            }
            if (reader[162] != DBNull.Value)
            {
                PCT012H158 = (int?)reader[162];
            }
            if (reader[163] != DBNull.Value)
            {
                PCT012H159 = (int?)reader[163];
            }
            if (reader[164] != DBNull.Value)
            {
                PCT012H160 = (int?)reader[164];
            }
            if (reader[165] != DBNull.Value)
            {
                PCT012H161 = (int?)reader[165];
            }
            if (reader[166] != DBNull.Value)
            {
                PCT012H162 = (int?)reader[166];
            }
            if (reader[167] != DBNull.Value)
            {
                PCT012H163 = (int?)reader[167];
            }
            if (reader[168] != DBNull.Value)
            {
                PCT012H164 = (int?)reader[168];
            }
            if (reader[169] != DBNull.Value)
            {
                PCT012H165 = (int?)reader[169];
            }
            if (reader[170] != DBNull.Value)
            {
                PCT012H166 = (int?)reader[170];
            }
            if (reader[171] != DBNull.Value)
            {
                PCT012H167 = (int?)reader[171];
            }
            if (reader[172] != DBNull.Value)
            {
                PCT012H168 = (int?)reader[172];
            }
            if (reader[173] != DBNull.Value)
            {
                PCT012H169 = (int?)reader[173];
            }
            if (reader[174] != DBNull.Value)
            {
                PCT012H170 = (int?)reader[174];
            }
            if (reader[175] != DBNull.Value)
            {
                PCT012H171 = (int?)reader[175];
            }
            if (reader[176] != DBNull.Value)
            {
                PCT012H172 = (int?)reader[176];
            }
            if (reader[177] != DBNull.Value)
            {
                PCT012H173 = (int?)reader[177];
            }
            if (reader[178] != DBNull.Value)
            {
                PCT012H174 = (int?)reader[178];
            }
            if (reader[179] != DBNull.Value)
            {
                PCT012H175 = (int?)reader[179];
            }
            if (reader[180] != DBNull.Value)
            {
                PCT012H176 = (int?)reader[180];
            }
            if (reader[181] != DBNull.Value)
            {
                PCT012H177 = (int?)reader[181];
            }
            if (reader[182] != DBNull.Value)
            {
                PCT012H178 = (int?)reader[182];
            }
            if (reader[183] != DBNull.Value)
            {
                PCT012H179 = (int?)reader[183];
            }
            if (reader[184] != DBNull.Value)
            {
                PCT012H180 = (int?)reader[184];
            }
            if (reader[185] != DBNull.Value)
            {
                PCT012H181 = (int?)reader[185];
            }
            if (reader[186] != DBNull.Value)
            {
                PCT012H182 = (int?)reader[186];
            }
            if (reader[187] != DBNull.Value)
            {
                PCT012H183 = (int?)reader[187];
            }
            if (reader[188] != DBNull.Value)
            {
                PCT012H184 = (int?)reader[188];
            }
            if (reader[189] != DBNull.Value)
            {
                PCT012H185 = (int?)reader[189];
            }
            if (reader[190] != DBNull.Value)
            {
                PCT012H186 = (int?)reader[190];
            }
            if (reader[191] != DBNull.Value)
            {
                PCT012H187 = (int?)reader[191];
            }
            if (reader[192] != DBNull.Value)
            {
                PCT012H188 = (int?)reader[192];
            }
            if (reader[193] != DBNull.Value)
            {
                PCT012H189 = (int?)reader[193];
            }
            if (reader[194] != DBNull.Value)
            {
                PCT012H190 = (int?)reader[194];
            }
            if (reader[195] != DBNull.Value)
            {
                PCT012H191 = (int?)reader[195];
            }
            if (reader[196] != DBNull.Value)
            {
                PCT012H192 = (int?)reader[196];
            }
            if (reader[197] != DBNull.Value)
            {
                PCT012H193 = (int?)reader[197];
            }
            if (reader[198] != DBNull.Value)
            {
                PCT012H194 = (int?)reader[198];
            }
            if (reader[199] != DBNull.Value)
            {
                PCT012H195 = (int?)reader[199];
            }
            if (reader[200] != DBNull.Value)
            {
                PCT012H196 = (int?)reader[200];
            }
            if (reader[201] != DBNull.Value)
            {
                PCT012H197 = (int?)reader[201];
            }
            if (reader[202] != DBNull.Value)
            {
                PCT012H198 = (int?)reader[202];
            }
            if (reader[203] != DBNull.Value)
            {
                PCT012H199 = (int?)reader[203];
            }
            if (reader[204] != DBNull.Value)
            {
                PCT012H200 = (int?)reader[204];
            }
            if (reader[205] != DBNull.Value)
            {
                PCT012H201 = (int?)reader[205];
            }
            if (reader[206] != DBNull.Value)
            {
                PCT012H202 = (int?)reader[206];
            }
            if (reader[207] != DBNull.Value)
            {
                PCT012H203 = (int?)reader[207];
            }
            if (reader[208] != DBNull.Value)
            {
                PCT012H204 = (int?)reader[208];
            }
            if (reader[209] != DBNull.Value)
            {
                PCT012H205 = (int?)reader[209];
            }
            if (reader[210] != DBNull.Value)
            {
                PCT012H206 = (int?)reader[210];
            }
            if (reader[211] != DBNull.Value)
            {
                PCT012H207 = (int?)reader[211];
            }
            if (reader[212] != DBNull.Value)
            {
                PCT012H208 = (int?)reader[212];
            }
            if (reader[213] != DBNull.Value)
            {
                PCT012H209 = (int?)reader[213];
            }
        }
        #endregion Constructors
    }
}
