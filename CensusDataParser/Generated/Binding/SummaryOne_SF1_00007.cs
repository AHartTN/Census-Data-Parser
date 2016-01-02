#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2016 11:21 AM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryOne_SF1_00007.cs
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

    public class SummaryOne_SF1_00007 : BaseModel
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
        [Column("P0500001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public int? P0500001 { get; set; }

        [ReadOnly(false)]
        [Column("P0500002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Allocated", ShortName = "Allocated", Order = 6)]
        public int? P0500002 { get; set; }

        [ReadOnly(false)]
        [Column("P0500003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not allocated", ShortName = "Not allocated", Order = 7)]
        public int? P0500003 { get; set; }

        [ReadOnly(false)]
        [Column("P0510001", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 8)]
        public int? P0510001 { get; set; }

        [ReadOnly(false)]
        [Column("P0510002", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No items allocated", ShortName = "No items allocated", Order = 9)]
        public int? P0510002 { get; set; }

        [ReadOnly(false)]
        [Column("P0510003", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "One or more items allocated", ShortName = "One or more items allocated", Order = 10)]
        public int? P0510003 { get; set; }

        [ReadOnly(false)]
        [Column("P012A001", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 11)]
        public int? P012A001 { get; set; }

        [ReadOnly(false)]
        [Column("P012A002", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 12)]
        public int? P012A002 { get; set; }

        [ReadOnly(false)]
        [Column("P012A003", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 13)]
        public int? P012A003 { get; set; }

        [ReadOnly(false)]
        [Column("P012A004", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 14)]
        public int? P012A004 { get; set; }

        [ReadOnly(false)]
        [Column("P012A005", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 15)]
        public int? P012A005 { get; set; }

        [ReadOnly(false)]
        [Column("P012A006", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 16)]
        public int? P012A006 { get; set; }

        [ReadOnly(false)]
        [Column("P012A007", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 17)]
        public int? P012A007 { get; set; }

        [ReadOnly(false)]
        [Column("P012A008", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 18)]
        public int? P012A008 { get; set; }

        [ReadOnly(false)]
        [Column("P012A009", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 19)]
        public int? P012A009 { get; set; }

        [ReadOnly(false)]
        [Column("P012A010", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 20)]
        public int? P012A010 { get; set; }

        [ReadOnly(false)]
        [Column("P012A011", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 21)]
        public int? P012A011 { get; set; }

        [ReadOnly(false)]
        [Column("P012A012", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 22)]
        public int? P012A012 { get; set; }

        [ReadOnly(false)]
        [Column("P012A013", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 23)]
        public int? P012A013 { get; set; }

        [ReadOnly(false)]
        [Column("P012A014", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 24)]
        public int? P012A014 { get; set; }

        [ReadOnly(false)]
        [Column("P012A015", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 25)]
        public int? P012A015 { get; set; }

        [ReadOnly(false)]
        [Column("P012A016", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 26)]
        public int? P012A016 { get; set; }

        [ReadOnly(false)]
        [Column("P012A017", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 27)]
        public int? P012A017 { get; set; }

        [ReadOnly(false)]
        [Column("P012A018", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 28)]
        public int? P012A018 { get; set; }

        [ReadOnly(false)]
        [Column("P012A019", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 29)]
        public int? P012A019 { get; set; }

        [ReadOnly(false)]
        [Column("P012A020", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 30)]
        public int? P012A020 { get; set; }

        [ReadOnly(false)]
        [Column("P012A021", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 31)]
        public int? P012A021 { get; set; }

        [ReadOnly(false)]
        [Column("P012A022", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 32)]
        public int? P012A022 { get; set; }

        [ReadOnly(false)]
        [Column("P012A023", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 33)]
        public int? P012A023 { get; set; }

        [ReadOnly(false)]
        [Column("P012A024", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 34)]
        public int? P012A024 { get; set; }

        [ReadOnly(false)]
        [Column("P012A025", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 35)]
        public int? P012A025 { get; set; }

        [ReadOnly(false)]
        [Column("P012A026", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 36)]
        public int? P012A026 { get; set; }

        [ReadOnly(false)]
        [Column("P012A027", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 37)]
        public int? P012A027 { get; set; }

        [ReadOnly(false)]
        [Column("P012A028", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 38)]
        public int? P012A028 { get; set; }

        [ReadOnly(false)]
        [Column("P012A029", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 39)]
        public int? P012A029 { get; set; }

        [ReadOnly(false)]
        [Column("P012A030", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 40)]
        public int? P012A030 { get; set; }

        [ReadOnly(false)]
        [Column("P012A031", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 41)]
        public int? P012A031 { get; set; }

        [ReadOnly(false)]
        [Column("P012A032", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 42)]
        public int? P012A032 { get; set; }

        [ReadOnly(false)]
        [Column("P012A033", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 43)]
        public int? P012A033 { get; set; }

        [ReadOnly(false)]
        [Column("P012A034", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 44)]
        public int? P012A034 { get; set; }

        [ReadOnly(false)]
        [Column("P012A035", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 45)]
        public int? P012A035 { get; set; }

        [ReadOnly(false)]
        [Column("P012A036", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 46)]
        public int? P012A036 { get; set; }

        [ReadOnly(false)]
        [Column("P012A037", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 47)]
        public int? P012A037 { get; set; }

        [ReadOnly(false)]
        [Column("P012A038", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 48)]
        public int? P012A038 { get; set; }

        [ReadOnly(false)]
        [Column("P012A039", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 49)]
        public int? P012A039 { get; set; }

        [ReadOnly(false)]
        [Column("P012A040", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 50)]
        public int? P012A040 { get; set; }

        [ReadOnly(false)]
        [Column("P012A041", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 51)]
        public int? P012A041 { get; set; }

        [ReadOnly(false)]
        [Column("P012A042", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 52)]
        public int? P012A042 { get; set; }

        [ReadOnly(false)]
        [Column("P012A043", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 53)]
        public int? P012A043 { get; set; }

        [ReadOnly(false)]
        [Column("P012A044", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 54)]
        public int? P012A044 { get; set; }

        [ReadOnly(false)]
        [Column("P012A045", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 55)]
        public int? P012A045 { get; set; }

        [ReadOnly(false)]
        [Column("P012A046", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 56)]
        public int? P012A046 { get; set; }

        [ReadOnly(false)]
        [Column("P012A047", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 57)]
        public int? P012A047 { get; set; }

        [ReadOnly(false)]
        [Column("P012A048", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 58)]
        public int? P012A048 { get; set; }

        [ReadOnly(false)]
        [Column("P012A049", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 59)]
        public int? P012A049 { get; set; }

        [ReadOnly(false)]
        [Column("P012B001", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 60)]
        public int? P012B001 { get; set; }

        [ReadOnly(false)]
        [Column("P012B002", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 61)]
        public int? P012B002 { get; set; }

        [ReadOnly(false)]
        [Column("P012B003", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 62)]
        public int? P012B003 { get; set; }

        [ReadOnly(false)]
        [Column("P012B004", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 63)]
        public int? P012B004 { get; set; }

        [ReadOnly(false)]
        [Column("P012B005", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 64)]
        public int? P012B005 { get; set; }

        [ReadOnly(false)]
        [Column("P012B006", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 65)]
        public int? P012B006 { get; set; }

        [ReadOnly(false)]
        [Column("P012B007", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 66)]
        public int? P012B007 { get; set; }

        [ReadOnly(false)]
        [Column("P012B008", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 67)]
        public int? P012B008 { get; set; }

        [ReadOnly(false)]
        [Column("P012B009", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 68)]
        public int? P012B009 { get; set; }

        [ReadOnly(false)]
        [Column("P012B010", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 69)]
        public int? P012B010 { get; set; }

        [ReadOnly(false)]
        [Column("P012B011", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 70)]
        public int? P012B011 { get; set; }

        [ReadOnly(false)]
        [Column("P012B012", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 71)]
        public int? P012B012 { get; set; }

        [ReadOnly(false)]
        [Column("P012B013", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 72)]
        public int? P012B013 { get; set; }

        [ReadOnly(false)]
        [Column("P012B014", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 73)]
        public int? P012B014 { get; set; }

        [ReadOnly(false)]
        [Column("P012B015", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 74)]
        public int? P012B015 { get; set; }

        [ReadOnly(false)]
        [Column("P012B016", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 75)]
        public int? P012B016 { get; set; }

        [ReadOnly(false)]
        [Column("P012B017", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 76)]
        public int? P012B017 { get; set; }

        [ReadOnly(false)]
        [Column("P012B018", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 77)]
        public int? P012B018 { get; set; }

        [ReadOnly(false)]
        [Column("P012B019", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 78)]
        public int? P012B019 { get; set; }

        [ReadOnly(false)]
        [Column("P012B020", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 79)]
        public int? P012B020 { get; set; }

        [ReadOnly(false)]
        [Column("P012B021", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 80)]
        public int? P012B021 { get; set; }

        [ReadOnly(false)]
        [Column("P012B022", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 81)]
        public int? P012B022 { get; set; }

        [ReadOnly(false)]
        [Column("P012B023", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 82)]
        public int? P012B023 { get; set; }

        [ReadOnly(false)]
        [Column("P012B024", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 83)]
        public int? P012B024 { get; set; }

        [ReadOnly(false)]
        [Column("P012B025", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 84)]
        public int? P012B025 { get; set; }

        [ReadOnly(false)]
        [Column("P012B026", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 85)]
        public int? P012B026 { get; set; }

        [ReadOnly(false)]
        [Column("P012B027", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 86)]
        public int? P012B027 { get; set; }

        [ReadOnly(false)]
        [Column("P012B028", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 87)]
        public int? P012B028 { get; set; }

        [ReadOnly(false)]
        [Column("P012B029", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 88)]
        public int? P012B029 { get; set; }

        [ReadOnly(false)]
        [Column("P012B030", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 89)]
        public int? P012B030 { get; set; }

        [ReadOnly(false)]
        [Column("P012B031", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 90)]
        public int? P012B031 { get; set; }

        [ReadOnly(false)]
        [Column("P012B032", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 91)]
        public int? P012B032 { get; set; }

        [ReadOnly(false)]
        [Column("P012B033", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 92)]
        public int? P012B033 { get; set; }

        [ReadOnly(false)]
        [Column("P012B034", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 93)]
        public int? P012B034 { get; set; }

        [ReadOnly(false)]
        [Column("P012B035", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 94)]
        public int? P012B035 { get; set; }

        [ReadOnly(false)]
        [Column("P012B036", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 95)]
        public int? P012B036 { get; set; }

        [ReadOnly(false)]
        [Column("P012B037", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 96)]
        public int? P012B037 { get; set; }

        [ReadOnly(false)]
        [Column("P012B038", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 97)]
        public int? P012B038 { get; set; }

        [ReadOnly(false)]
        [Column("P012B039", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 98)]
        public int? P012B039 { get; set; }

        [ReadOnly(false)]
        [Column("P012B040", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 99)]
        public int? P012B040 { get; set; }

        [ReadOnly(false)]
        [Column("P012B041", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 100)]
        public int? P012B041 { get; set; }

        [ReadOnly(false)]
        [Column("P012B042", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 101)]
        public int? P012B042 { get; set; }

        [ReadOnly(false)]
        [Column("P012B043", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 102)]
        public int? P012B043 { get; set; }

        [ReadOnly(false)]
        [Column("P012B044", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 103)]
        public int? P012B044 { get; set; }

        [ReadOnly(false)]
        [Column("P012B045", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 104)]
        public int? P012B045 { get; set; }

        [ReadOnly(false)]
        [Column("P012B046", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 105)]
        public int? P012B046 { get; set; }

        [ReadOnly(false)]
        [Column("P012B047", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 106)]
        public int? P012B047 { get; set; }

        [ReadOnly(false)]
        [Column("P012B048", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 107)]
        public int? P012B048 { get; set; }

        [ReadOnly(false)]
        [Column("P012B049", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 108)]
        public int? P012B049 { get; set; }

        [ReadOnly(false)]
        [Column("P012C001", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 109)]
        public int? P012C001 { get; set; }

        [ReadOnly(false)]
        [Column("P012C002", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 110)]
        public int? P012C002 { get; set; }

        [ReadOnly(false)]
        [Column("P012C003", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 111)]
        public int? P012C003 { get; set; }

        [ReadOnly(false)]
        [Column("P012C004", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 112)]
        public int? P012C004 { get; set; }

        [ReadOnly(false)]
        [Column("P012C005", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 113)]
        public int? P012C005 { get; set; }

        [ReadOnly(false)]
        [Column("P012C006", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 114)]
        public int? P012C006 { get; set; }

        [ReadOnly(false)]
        [Column("P012C007", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 115)]
        public int? P012C007 { get; set; }

        [ReadOnly(false)]
        [Column("P012C008", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 116)]
        public int? P012C008 { get; set; }

        [ReadOnly(false)]
        [Column("P012C009", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 117)]
        public int? P012C009 { get; set; }

        [ReadOnly(false)]
        [Column("P012C010", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 118)]
        public int? P012C010 { get; set; }

        [ReadOnly(false)]
        [Column("P012C011", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 119)]
        public int? P012C011 { get; set; }

        [ReadOnly(false)]
        [Column("P012C012", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 120)]
        public int? P012C012 { get; set; }

        [ReadOnly(false)]
        [Column("P012C013", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 121)]
        public int? P012C013 { get; set; }

        [ReadOnly(false)]
        [Column("P012C014", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 122)]
        public int? P012C014 { get; set; }

        [ReadOnly(false)]
        [Column("P012C015", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 123)]
        public int? P012C015 { get; set; }

        [ReadOnly(false)]
        [Column("P012C016", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 124)]
        public int? P012C016 { get; set; }

        [ReadOnly(false)]
        [Column("P012C017", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 125)]
        public int? P012C017 { get; set; }

        [ReadOnly(false)]
        [Column("P012C018", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 126)]
        public int? P012C018 { get; set; }

        [ReadOnly(false)]
        [Column("P012C019", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 127)]
        public int? P012C019 { get; set; }

        [ReadOnly(false)]
        [Column("P012C020", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 128)]
        public int? P012C020 { get; set; }

        [ReadOnly(false)]
        [Column("P012C021", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 129)]
        public int? P012C021 { get; set; }

        [ReadOnly(false)]
        [Column("P012C022", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 130)]
        public int? P012C022 { get; set; }

        [ReadOnly(false)]
        [Column("P012C023", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 131)]
        public int? P012C023 { get; set; }

        [ReadOnly(false)]
        [Column("P012C024", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 132)]
        public int? P012C024 { get; set; }

        [ReadOnly(false)]
        [Column("P012C025", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 133)]
        public int? P012C025 { get; set; }

        [ReadOnly(false)]
        [Column("P012C026", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 134)]
        public int? P012C026 { get; set; }

        [ReadOnly(false)]
        [Column("P012C027", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 135)]
        public int? P012C027 { get; set; }

        [ReadOnly(false)]
        [Column("P012C028", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 136)]
        public int? P012C028 { get; set; }

        [ReadOnly(false)]
        [Column("P012C029", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 137)]
        public int? P012C029 { get; set; }

        [ReadOnly(false)]
        [Column("P012C030", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 138)]
        public int? P012C030 { get; set; }

        [ReadOnly(false)]
        [Column("P012C031", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 139)]
        public int? P012C031 { get; set; }

        [ReadOnly(false)]
        [Column("P012C032", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 140)]
        public int? P012C032 { get; set; }

        [ReadOnly(false)]
        [Column("P012C033", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 141)]
        public int? P012C033 { get; set; }

        [ReadOnly(false)]
        [Column("P012C034", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 142)]
        public int? P012C034 { get; set; }

        [ReadOnly(false)]
        [Column("P012C035", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 143)]
        public int? P012C035 { get; set; }

        [ReadOnly(false)]
        [Column("P012C036", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 144)]
        public int? P012C036 { get; set; }

        [ReadOnly(false)]
        [Column("P012C037", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 145)]
        public int? P012C037 { get; set; }

        [ReadOnly(false)]
        [Column("P012C038", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 146)]
        public int? P012C038 { get; set; }

        [ReadOnly(false)]
        [Column("P012C039", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 147)]
        public int? P012C039 { get; set; }

        [ReadOnly(false)]
        [Column("P012C040", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 148)]
        public int? P012C040 { get; set; }

        [ReadOnly(false)]
        [Column("P012C041", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 149)]
        public int? P012C041 { get; set; }

        [ReadOnly(false)]
        [Column("P012C042", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 150)]
        public int? P012C042 { get; set; }

        [ReadOnly(false)]
        [Column("P012C043", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 151)]
        public int? P012C043 { get; set; }

        [ReadOnly(false)]
        [Column("P012C044", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 152)]
        public int? P012C044 { get; set; }

        [ReadOnly(false)]
        [Column("P012C045", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 153)]
        public int? P012C045 { get; set; }

        [ReadOnly(false)]
        [Column("P012C046", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 154)]
        public int? P012C046 { get; set; }

        [ReadOnly(false)]
        [Column("P012C047", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 155)]
        public int? P012C047 { get; set; }

        [ReadOnly(false)]
        [Column("P012C048", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 156)]
        public int? P012C048 { get; set; }

        [ReadOnly(false)]
        [Column("P012C049", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 157)]
        public int? P012C049 { get; set; }

        [ReadOnly(false)]
        [Column("P012D001", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 158)]
        public int? P012D001 { get; set; }

        [ReadOnly(false)]
        [Column("P012D002", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 159)]
        public int? P012D002 { get; set; }

        [ReadOnly(false)]
        [Column("P012D003", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 160)]
        public int? P012D003 { get; set; }

        [ReadOnly(false)]
        [Column("P012D004", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 161)]
        public int? P012D004 { get; set; }

        [ReadOnly(false)]
        [Column("P012D005", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 162)]
        public int? P012D005 { get; set; }

        [ReadOnly(false)]
        [Column("P012D006", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 163)]
        public int? P012D006 { get; set; }

        [ReadOnly(false)]
        [Column("P012D007", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 164)]
        public int? P012D007 { get; set; }

        [ReadOnly(false)]
        [Column("P012D008", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 165)]
        public int? P012D008 { get; set; }

        [ReadOnly(false)]
        [Column("P012D009", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 166)]
        public int? P012D009 { get; set; }

        [ReadOnly(false)]
        [Column("P012D010", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 167)]
        public int? P012D010 { get; set; }

        [ReadOnly(false)]
        [Column("P012D011", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 168)]
        public int? P012D011 { get; set; }

        [ReadOnly(false)]
        [Column("P012D012", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 169)]
        public int? P012D012 { get; set; }

        [ReadOnly(false)]
        [Column("P012D013", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 170)]
        public int? P012D013 { get; set; }

        [ReadOnly(false)]
        [Column("P012D014", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 171)]
        public int? P012D014 { get; set; }

        [ReadOnly(false)]
        [Column("P012D015", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 172)]
        public int? P012D015 { get; set; }

        [ReadOnly(false)]
        [Column("P012D016", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 173)]
        public int? P012D016 { get; set; }

        [ReadOnly(false)]
        [Column("P012D017", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 174)]
        public int? P012D017 { get; set; }

        [ReadOnly(false)]
        [Column("P012D018", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 175)]
        public int? P012D018 { get; set; }

        [ReadOnly(false)]
        [Column("P012D019", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 176)]
        public int? P012D019 { get; set; }

        [ReadOnly(false)]
        [Column("P012D020", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 177)]
        public int? P012D020 { get; set; }

        [ReadOnly(false)]
        [Column("P012D021", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 178)]
        public int? P012D021 { get; set; }

        [ReadOnly(false)]
        [Column("P012D022", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 179)]
        public int? P012D022 { get; set; }

        [ReadOnly(false)]
        [Column("P012D023", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 180)]
        public int? P012D023 { get; set; }

        [ReadOnly(false)]
        [Column("P012D024", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 181)]
        public int? P012D024 { get; set; }

        [ReadOnly(false)]
        [Column("P012D025", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 182)]
        public int? P012D025 { get; set; }

        [ReadOnly(false)]
        [Column("P012D026", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 183)]
        public int? P012D026 { get; set; }

        [ReadOnly(false)]
        [Column("P012D027", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 184)]
        public int? P012D027 { get; set; }

        [ReadOnly(false)]
        [Column("P012D028", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 185)]
        public int? P012D028 { get; set; }

        [ReadOnly(false)]
        [Column("P012D029", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 186)]
        public int? P012D029 { get; set; }

        [ReadOnly(false)]
        [Column("P012D030", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 187)]
        public int? P012D030 { get; set; }

        [ReadOnly(false)]
        [Column("P012D031", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 188)]
        public int? P012D031 { get; set; }

        [ReadOnly(false)]
        [Column("P012D032", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 189)]
        public int? P012D032 { get; set; }

        [ReadOnly(false)]
        [Column("P012D033", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 190)]
        public int? P012D033 { get; set; }

        [ReadOnly(false)]
        [Column("P012D034", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 191)]
        public int? P012D034 { get; set; }

        [ReadOnly(false)]
        [Column("P012D035", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 192)]
        public int? P012D035 { get; set; }

        [ReadOnly(false)]
        [Column("P012D036", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 193)]
        public int? P012D036 { get; set; }

        [ReadOnly(false)]
        [Column("P012D037", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 194)]
        public int? P012D037 { get; set; }

        [ReadOnly(false)]
        [Column("P012D038", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 195)]
        public int? P012D038 { get; set; }

        [ReadOnly(false)]
        [Column("P012D039", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 196)]
        public int? P012D039 { get; set; }

        [ReadOnly(false)]
        [Column("P012D040", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 197)]
        public int? P012D040 { get; set; }

        [ReadOnly(false)]
        [Column("P012D041", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 198)]
        public int? P012D041 { get; set; }

        [ReadOnly(false)]
        [Column("P012D042", Order = 199)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 199)]
        public int? P012D042 { get; set; }

        [ReadOnly(false)]
        [Column("P012D043", Order = 200)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 200)]
        public int? P012D043 { get; set; }

        [ReadOnly(false)]
        [Column("P012D044", Order = 201)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 201)]
        public int? P012D044 { get; set; }

        [ReadOnly(false)]
        [Column("P012D045", Order = 202)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 202)]
        public int? P012D045 { get; set; }

        [ReadOnly(false)]
        [Column("P012D046", Order = 203)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 203)]
        public int? P012D046 { get; set; }

        [ReadOnly(false)]
        [Column("P012D047", Order = 204)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 204)]
        public int? P012D047 { get; set; }

        [ReadOnly(false)]
        [Column("P012D048", Order = 205)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 205)]
        public int? P012D048 { get; set; }

        [ReadOnly(false)]
        [Column("P012D049", Order = 206)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 206)]
        public int? P012D049 { get; set; }

        [ReadOnly(false)]
        [Column("P012E001", Order = 207)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 207)]
        public int? P012E001 { get; set; }

        [ReadOnly(false)]
        [Column("P012E002", Order = 208)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 208)]
        public int? P012E002 { get; set; }

        [ReadOnly(false)]
        [Column("P012E003", Order = 209)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 209)]
        public int? P012E003 { get; set; }

        [ReadOnly(false)]
        [Column("P012E004", Order = 210)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 210)]
        public int? P012E004 { get; set; }

        [ReadOnly(false)]
        [Column("P012E005", Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 211)]
        public int? P012E005 { get; set; }

        [ReadOnly(false)]
        [Column("P012E006", Order = 212)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 212)]
        public int? P012E006 { get; set; }

        [ReadOnly(false)]
        [Column("P012E007", Order = 213)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 213)]
        public int? P012E007 { get; set; }

        [ReadOnly(false)]
        [Column("P012E008", Order = 214)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 214)]
        public int? P012E008 { get; set; }

        [ReadOnly(false)]
        [Column("P012E009", Order = 215)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 215)]
        public int? P012E009 { get; set; }

        [ReadOnly(false)]
        [Column("P012E010", Order = 216)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 216)]
        public int? P012E010 { get; set; }

        [ReadOnly(false)]
        [Column("P012E011", Order = 217)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 217)]
        public int? P012E011 { get; set; }

        [ReadOnly(false)]
        [Column("P012E012", Order = 218)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 218)]
        public int? P012E012 { get; set; }

        [ReadOnly(false)]
        [Column("P012E013", Order = 219)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 219)]
        public int? P012E013 { get; set; }

        [ReadOnly(false)]
        [Column("P012E014", Order = 220)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 220)]
        public int? P012E014 { get; set; }

        [ReadOnly(false)]
        [Column("P012E015", Order = 221)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 221)]
        public int? P012E015 { get; set; }

        [ReadOnly(false)]
        [Column("P012E016", Order = 222)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 222)]
        public int? P012E016 { get; set; }

        [ReadOnly(false)]
        [Column("P012E017", Order = 223)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 223)]
        public int? P012E017 { get; set; }

        [ReadOnly(false)]
        [Column("P012E018", Order = 224)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 224)]
        public int? P012E018 { get; set; }

        [ReadOnly(false)]
        [Column("P012E019", Order = 225)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 225)]
        public int? P012E019 { get; set; }

        [ReadOnly(false)]
        [Column("P012E020", Order = 226)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 226)]
        public int? P012E020 { get; set; }

        [ReadOnly(false)]
        [Column("P012E021", Order = 227)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 227)]
        public int? P012E021 { get; set; }

        [ReadOnly(false)]
        [Column("P012E022", Order = 228)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 228)]
        public int? P012E022 { get; set; }

        [ReadOnly(false)]
        [Column("P012E023", Order = 229)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 229)]
        public int? P012E023 { get; set; }

        [ReadOnly(false)]
        [Column("P012E024", Order = 230)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 230)]
        public int? P012E024 { get; set; }

        [ReadOnly(false)]
        [Column("P012E025", Order = 231)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 231)]
        public int? P012E025 { get; set; }

        [ReadOnly(false)]
        [Column("P012E026", Order = 232)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 232)]
        public int? P012E026 { get; set; }

        [ReadOnly(false)]
        [Column("P012E027", Order = 233)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 233)]
        public int? P012E027 { get; set; }

        [ReadOnly(false)]
        [Column("P012E028", Order = 234)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 234)]
        public int? P012E028 { get; set; }

        [ReadOnly(false)]
        [Column("P012E029", Order = 235)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 235)]
        public int? P012E029 { get; set; }

        [ReadOnly(false)]
        [Column("P012E030", Order = 236)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 236)]
        public int? P012E030 { get; set; }

        [ReadOnly(false)]
        [Column("P012E031", Order = 237)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 237)]
        public int? P012E031 { get; set; }

        [ReadOnly(false)]
        [Column("P012E032", Order = 238)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 238)]
        public int? P012E032 { get; set; }

        [ReadOnly(false)]
        [Column("P012E033", Order = 239)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 239)]
        public int? P012E033 { get; set; }

        [ReadOnly(false)]
        [Column("P012E034", Order = 240)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 240)]
        public int? P012E034 { get; set; }

        [ReadOnly(false)]
        [Column("P012E035", Order = 241)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 241)]
        public int? P012E035 { get; set; }

        [ReadOnly(false)]
        [Column("P012E036", Order = 242)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 242)]
        public int? P012E036 { get; set; }

        [ReadOnly(false)]
        [Column("P012E037", Order = 243)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 243)]
        public int? P012E037 { get; set; }

        [ReadOnly(false)]
        [Column("P012E038", Order = 244)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 244)]
        public int? P012E038 { get; set; }

        [ReadOnly(false)]
        [Column("P012E039", Order = 245)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 245)]
        public int? P012E039 { get; set; }

        [ReadOnly(false)]
        [Column("P012E040", Order = 246)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 246)]
        public int? P012E040 { get; set; }

        [ReadOnly(false)]
        [Column("P012E041", Order = 247)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 247)]
        public int? P012E041 { get; set; }

        [ReadOnly(false)]
        [Column("P012E042", Order = 248)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 248)]
        public int? P012E042 { get; set; }

        [ReadOnly(false)]
        [Column("P012E043", Order = 249)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 249)]
        public int? P012E043 { get; set; }

        [ReadOnly(false)]
        [Column("P012E044", Order = 250)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 250)]
        public int? P012E044 { get; set; }

        [ReadOnly(false)]
        [Column("P012E045", Order = 251)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 251)]
        public int? P012E045 { get; set; }

        [ReadOnly(false)]
        [Column("P012E046", Order = 252)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 252)]
        public int? P012E046 { get; set; }

        [ReadOnly(false)]
        [Column("P012E047", Order = 253)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 253)]
        public int? P012E047 { get; set; }

        [ReadOnly(false)]
        [Column("P012E048", Order = 254)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 254)]
        public int? P012E048 { get; set; }

        [ReadOnly(false)]
        [Column("P012E049", Order = 255)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 255)]
        public int? P012E049 { get; set; }
        #endregion Properties

        #region Constructors
        public SummaryOne_SF1_00007(string csvLine) : base(csvLine) { }

        public SummaryOne_SF1_00007(string[] values) : base(values) { }

        public SummaryOne_SF1_00007(OleDbDataReader reader, CensusFileType fileType)
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
                P0500001 = (int?)reader[5];
            }
            if (reader[6] != DBNull.Value)
            {
                P0500002 = (int?)reader[6];
            }
            if (reader[7] != DBNull.Value)
            {
                P0500003 = (int?)reader[7];
            }
            if (reader[8] != DBNull.Value)
            {
                P0510001 = (int?)reader[8];
            }
            if (reader[9] != DBNull.Value)
            {
                P0510002 = (int?)reader[9];
            }
            if (reader[10] != DBNull.Value)
            {
                P0510003 = (int?)reader[10];
            }
            if (reader[11] != DBNull.Value)
            {
                P012A001 = (int?)reader[11];
            }
            if (reader[12] != DBNull.Value)
            {
                P012A002 = (int?)reader[12];
            }
            if (reader[13] != DBNull.Value)
            {
                P012A003 = (int?)reader[13];
            }
            if (reader[14] != DBNull.Value)
            {
                P012A004 = (int?)reader[14];
            }
            if (reader[15] != DBNull.Value)
            {
                P012A005 = (int?)reader[15];
            }
            if (reader[16] != DBNull.Value)
            {
                P012A006 = (int?)reader[16];
            }
            if (reader[17] != DBNull.Value)
            {
                P012A007 = (int?)reader[17];
            }
            if (reader[18] != DBNull.Value)
            {
                P012A008 = (int?)reader[18];
            }
            if (reader[19] != DBNull.Value)
            {
                P012A009 = (int?)reader[19];
            }
            if (reader[20] != DBNull.Value)
            {
                P012A010 = (int?)reader[20];
            }
            if (reader[21] != DBNull.Value)
            {
                P012A011 = (int?)reader[21];
            }
            if (reader[22] != DBNull.Value)
            {
                P012A012 = (int?)reader[22];
            }
            if (reader[23] != DBNull.Value)
            {
                P012A013 = (int?)reader[23];
            }
            if (reader[24] != DBNull.Value)
            {
                P012A014 = (int?)reader[24];
            }
            if (reader[25] != DBNull.Value)
            {
                P012A015 = (int?)reader[25];
            }
            if (reader[26] != DBNull.Value)
            {
                P012A016 = (int?)reader[26];
            }
            if (reader[27] != DBNull.Value)
            {
                P012A017 = (int?)reader[27];
            }
            if (reader[28] != DBNull.Value)
            {
                P012A018 = (int?)reader[28];
            }
            if (reader[29] != DBNull.Value)
            {
                P012A019 = (int?)reader[29];
            }
            if (reader[30] != DBNull.Value)
            {
                P012A020 = (int?)reader[30];
            }
            if (reader[31] != DBNull.Value)
            {
                P012A021 = (int?)reader[31];
            }
            if (reader[32] != DBNull.Value)
            {
                P012A022 = (int?)reader[32];
            }
            if (reader[33] != DBNull.Value)
            {
                P012A023 = (int?)reader[33];
            }
            if (reader[34] != DBNull.Value)
            {
                P012A024 = (int?)reader[34];
            }
            if (reader[35] != DBNull.Value)
            {
                P012A025 = (int?)reader[35];
            }
            if (reader[36] != DBNull.Value)
            {
                P012A026 = (int?)reader[36];
            }
            if (reader[37] != DBNull.Value)
            {
                P012A027 = (int?)reader[37];
            }
            if (reader[38] != DBNull.Value)
            {
                P012A028 = (int?)reader[38];
            }
            if (reader[39] != DBNull.Value)
            {
                P012A029 = (int?)reader[39];
            }
            if (reader[40] != DBNull.Value)
            {
                P012A030 = (int?)reader[40];
            }
            if (reader[41] != DBNull.Value)
            {
                P012A031 = (int?)reader[41];
            }
            if (reader[42] != DBNull.Value)
            {
                P012A032 = (int?)reader[42];
            }
            if (reader[43] != DBNull.Value)
            {
                P012A033 = (int?)reader[43];
            }
            if (reader[44] != DBNull.Value)
            {
                P012A034 = (int?)reader[44];
            }
            if (reader[45] != DBNull.Value)
            {
                P012A035 = (int?)reader[45];
            }
            if (reader[46] != DBNull.Value)
            {
                P012A036 = (int?)reader[46];
            }
            if (reader[47] != DBNull.Value)
            {
                P012A037 = (int?)reader[47];
            }
            if (reader[48] != DBNull.Value)
            {
                P012A038 = (int?)reader[48];
            }
            if (reader[49] != DBNull.Value)
            {
                P012A039 = (int?)reader[49];
            }
            if (reader[50] != DBNull.Value)
            {
                P012A040 = (int?)reader[50];
            }
            if (reader[51] != DBNull.Value)
            {
                P012A041 = (int?)reader[51];
            }
            if (reader[52] != DBNull.Value)
            {
                P012A042 = (int?)reader[52];
            }
            if (reader[53] != DBNull.Value)
            {
                P012A043 = (int?)reader[53];
            }
            if (reader[54] != DBNull.Value)
            {
                P012A044 = (int?)reader[54];
            }
            if (reader[55] != DBNull.Value)
            {
                P012A045 = (int?)reader[55];
            }
            if (reader[56] != DBNull.Value)
            {
                P012A046 = (int?)reader[56];
            }
            if (reader[57] != DBNull.Value)
            {
                P012A047 = (int?)reader[57];
            }
            if (reader[58] != DBNull.Value)
            {
                P012A048 = (int?)reader[58];
            }
            if (reader[59] != DBNull.Value)
            {
                P012A049 = (int?)reader[59];
            }
            if (reader[60] != DBNull.Value)
            {
                P012B001 = (int?)reader[60];
            }
            if (reader[61] != DBNull.Value)
            {
                P012B002 = (int?)reader[61];
            }
            if (reader[62] != DBNull.Value)
            {
                P012B003 = (int?)reader[62];
            }
            if (reader[63] != DBNull.Value)
            {
                P012B004 = (int?)reader[63];
            }
            if (reader[64] != DBNull.Value)
            {
                P012B005 = (int?)reader[64];
            }
            if (reader[65] != DBNull.Value)
            {
                P012B006 = (int?)reader[65];
            }
            if (reader[66] != DBNull.Value)
            {
                P012B007 = (int?)reader[66];
            }
            if (reader[67] != DBNull.Value)
            {
                P012B008 = (int?)reader[67];
            }
            if (reader[68] != DBNull.Value)
            {
                P012B009 = (int?)reader[68];
            }
            if (reader[69] != DBNull.Value)
            {
                P012B010 = (int?)reader[69];
            }
            if (reader[70] != DBNull.Value)
            {
                P012B011 = (int?)reader[70];
            }
            if (reader[71] != DBNull.Value)
            {
                P012B012 = (int?)reader[71];
            }
            if (reader[72] != DBNull.Value)
            {
                P012B013 = (int?)reader[72];
            }
            if (reader[73] != DBNull.Value)
            {
                P012B014 = (int?)reader[73];
            }
            if (reader[74] != DBNull.Value)
            {
                P012B015 = (int?)reader[74];
            }
            if (reader[75] != DBNull.Value)
            {
                P012B016 = (int?)reader[75];
            }
            if (reader[76] != DBNull.Value)
            {
                P012B017 = (int?)reader[76];
            }
            if (reader[77] != DBNull.Value)
            {
                P012B018 = (int?)reader[77];
            }
            if (reader[78] != DBNull.Value)
            {
                P012B019 = (int?)reader[78];
            }
            if (reader[79] != DBNull.Value)
            {
                P012B020 = (int?)reader[79];
            }
            if (reader[80] != DBNull.Value)
            {
                P012B021 = (int?)reader[80];
            }
            if (reader[81] != DBNull.Value)
            {
                P012B022 = (int?)reader[81];
            }
            if (reader[82] != DBNull.Value)
            {
                P012B023 = (int?)reader[82];
            }
            if (reader[83] != DBNull.Value)
            {
                P012B024 = (int?)reader[83];
            }
            if (reader[84] != DBNull.Value)
            {
                P012B025 = (int?)reader[84];
            }
            if (reader[85] != DBNull.Value)
            {
                P012B026 = (int?)reader[85];
            }
            if (reader[86] != DBNull.Value)
            {
                P012B027 = (int?)reader[86];
            }
            if (reader[87] != DBNull.Value)
            {
                P012B028 = (int?)reader[87];
            }
            if (reader[88] != DBNull.Value)
            {
                P012B029 = (int?)reader[88];
            }
            if (reader[89] != DBNull.Value)
            {
                P012B030 = (int?)reader[89];
            }
            if (reader[90] != DBNull.Value)
            {
                P012B031 = (int?)reader[90];
            }
            if (reader[91] != DBNull.Value)
            {
                P012B032 = (int?)reader[91];
            }
            if (reader[92] != DBNull.Value)
            {
                P012B033 = (int?)reader[92];
            }
            if (reader[93] != DBNull.Value)
            {
                P012B034 = (int?)reader[93];
            }
            if (reader[94] != DBNull.Value)
            {
                P012B035 = (int?)reader[94];
            }
            if (reader[95] != DBNull.Value)
            {
                P012B036 = (int?)reader[95];
            }
            if (reader[96] != DBNull.Value)
            {
                P012B037 = (int?)reader[96];
            }
            if (reader[97] != DBNull.Value)
            {
                P012B038 = (int?)reader[97];
            }
            if (reader[98] != DBNull.Value)
            {
                P012B039 = (int?)reader[98];
            }
            if (reader[99] != DBNull.Value)
            {
                P012B040 = (int?)reader[99];
            }
            if (reader[100] != DBNull.Value)
            {
                P012B041 = (int?)reader[100];
            }
            if (reader[101] != DBNull.Value)
            {
                P012B042 = (int?)reader[101];
            }
            if (reader[102] != DBNull.Value)
            {
                P012B043 = (int?)reader[102];
            }
            if (reader[103] != DBNull.Value)
            {
                P012B044 = (int?)reader[103];
            }
            if (reader[104] != DBNull.Value)
            {
                P012B045 = (int?)reader[104];
            }
            if (reader[105] != DBNull.Value)
            {
                P012B046 = (int?)reader[105];
            }
            if (reader[106] != DBNull.Value)
            {
                P012B047 = (int?)reader[106];
            }
            if (reader[107] != DBNull.Value)
            {
                P012B048 = (int?)reader[107];
            }
            if (reader[108] != DBNull.Value)
            {
                P012B049 = (int?)reader[108];
            }
            if (reader[109] != DBNull.Value)
            {
                P012C001 = (int?)reader[109];
            }
            if (reader[110] != DBNull.Value)
            {
                P012C002 = (int?)reader[110];
            }
            if (reader[111] != DBNull.Value)
            {
                P012C003 = (int?)reader[111];
            }
            if (reader[112] != DBNull.Value)
            {
                P012C004 = (int?)reader[112];
            }
            if (reader[113] != DBNull.Value)
            {
                P012C005 = (int?)reader[113];
            }
            if (reader[114] != DBNull.Value)
            {
                P012C006 = (int?)reader[114];
            }
            if (reader[115] != DBNull.Value)
            {
                P012C007 = (int?)reader[115];
            }
            if (reader[116] != DBNull.Value)
            {
                P012C008 = (int?)reader[116];
            }
            if (reader[117] != DBNull.Value)
            {
                P012C009 = (int?)reader[117];
            }
            if (reader[118] != DBNull.Value)
            {
                P012C010 = (int?)reader[118];
            }
            if (reader[119] != DBNull.Value)
            {
                P012C011 = (int?)reader[119];
            }
            if (reader[120] != DBNull.Value)
            {
                P012C012 = (int?)reader[120];
            }
            if (reader[121] != DBNull.Value)
            {
                P012C013 = (int?)reader[121];
            }
            if (reader[122] != DBNull.Value)
            {
                P012C014 = (int?)reader[122];
            }
            if (reader[123] != DBNull.Value)
            {
                P012C015 = (int?)reader[123];
            }
            if (reader[124] != DBNull.Value)
            {
                P012C016 = (int?)reader[124];
            }
            if (reader[125] != DBNull.Value)
            {
                P012C017 = (int?)reader[125];
            }
            if (reader[126] != DBNull.Value)
            {
                P012C018 = (int?)reader[126];
            }
            if (reader[127] != DBNull.Value)
            {
                P012C019 = (int?)reader[127];
            }
            if (reader[128] != DBNull.Value)
            {
                P012C020 = (int?)reader[128];
            }
            if (reader[129] != DBNull.Value)
            {
                P012C021 = (int?)reader[129];
            }
            if (reader[130] != DBNull.Value)
            {
                P012C022 = (int?)reader[130];
            }
            if (reader[131] != DBNull.Value)
            {
                P012C023 = (int?)reader[131];
            }
            if (reader[132] != DBNull.Value)
            {
                P012C024 = (int?)reader[132];
            }
            if (reader[133] != DBNull.Value)
            {
                P012C025 = (int?)reader[133];
            }
            if (reader[134] != DBNull.Value)
            {
                P012C026 = (int?)reader[134];
            }
            if (reader[135] != DBNull.Value)
            {
                P012C027 = (int?)reader[135];
            }
            if (reader[136] != DBNull.Value)
            {
                P012C028 = (int?)reader[136];
            }
            if (reader[137] != DBNull.Value)
            {
                P012C029 = (int?)reader[137];
            }
            if (reader[138] != DBNull.Value)
            {
                P012C030 = (int?)reader[138];
            }
            if (reader[139] != DBNull.Value)
            {
                P012C031 = (int?)reader[139];
            }
            if (reader[140] != DBNull.Value)
            {
                P012C032 = (int?)reader[140];
            }
            if (reader[141] != DBNull.Value)
            {
                P012C033 = (int?)reader[141];
            }
            if (reader[142] != DBNull.Value)
            {
                P012C034 = (int?)reader[142];
            }
            if (reader[143] != DBNull.Value)
            {
                P012C035 = (int?)reader[143];
            }
            if (reader[144] != DBNull.Value)
            {
                P012C036 = (int?)reader[144];
            }
            if (reader[145] != DBNull.Value)
            {
                P012C037 = (int?)reader[145];
            }
            if (reader[146] != DBNull.Value)
            {
                P012C038 = (int?)reader[146];
            }
            if (reader[147] != DBNull.Value)
            {
                P012C039 = (int?)reader[147];
            }
            if (reader[148] != DBNull.Value)
            {
                P012C040 = (int?)reader[148];
            }
            if (reader[149] != DBNull.Value)
            {
                P012C041 = (int?)reader[149];
            }
            if (reader[150] != DBNull.Value)
            {
                P012C042 = (int?)reader[150];
            }
            if (reader[151] != DBNull.Value)
            {
                P012C043 = (int?)reader[151];
            }
            if (reader[152] != DBNull.Value)
            {
                P012C044 = (int?)reader[152];
            }
            if (reader[153] != DBNull.Value)
            {
                P012C045 = (int?)reader[153];
            }
            if (reader[154] != DBNull.Value)
            {
                P012C046 = (int?)reader[154];
            }
            if (reader[155] != DBNull.Value)
            {
                P012C047 = (int?)reader[155];
            }
            if (reader[156] != DBNull.Value)
            {
                P012C048 = (int?)reader[156];
            }
            if (reader[157] != DBNull.Value)
            {
                P012C049 = (int?)reader[157];
            }
            if (reader[158] != DBNull.Value)
            {
                P012D001 = (int?)reader[158];
            }
            if (reader[159] != DBNull.Value)
            {
                P012D002 = (int?)reader[159];
            }
            if (reader[160] != DBNull.Value)
            {
                P012D003 = (int?)reader[160];
            }
            if (reader[161] != DBNull.Value)
            {
                P012D004 = (int?)reader[161];
            }
            if (reader[162] != DBNull.Value)
            {
                P012D005 = (int?)reader[162];
            }
            if (reader[163] != DBNull.Value)
            {
                P012D006 = (int?)reader[163];
            }
            if (reader[164] != DBNull.Value)
            {
                P012D007 = (int?)reader[164];
            }
            if (reader[165] != DBNull.Value)
            {
                P012D008 = (int?)reader[165];
            }
            if (reader[166] != DBNull.Value)
            {
                P012D009 = (int?)reader[166];
            }
            if (reader[167] != DBNull.Value)
            {
                P012D010 = (int?)reader[167];
            }
            if (reader[168] != DBNull.Value)
            {
                P012D011 = (int?)reader[168];
            }
            if (reader[169] != DBNull.Value)
            {
                P012D012 = (int?)reader[169];
            }
            if (reader[170] != DBNull.Value)
            {
                P012D013 = (int?)reader[170];
            }
            if (reader[171] != DBNull.Value)
            {
                P012D014 = (int?)reader[171];
            }
            if (reader[172] != DBNull.Value)
            {
                P012D015 = (int?)reader[172];
            }
            if (reader[173] != DBNull.Value)
            {
                P012D016 = (int?)reader[173];
            }
            if (reader[174] != DBNull.Value)
            {
                P012D017 = (int?)reader[174];
            }
            if (reader[175] != DBNull.Value)
            {
                P012D018 = (int?)reader[175];
            }
            if (reader[176] != DBNull.Value)
            {
                P012D019 = (int?)reader[176];
            }
            if (reader[177] != DBNull.Value)
            {
                P012D020 = (int?)reader[177];
            }
            if (reader[178] != DBNull.Value)
            {
                P012D021 = (int?)reader[178];
            }
            if (reader[179] != DBNull.Value)
            {
                P012D022 = (int?)reader[179];
            }
            if (reader[180] != DBNull.Value)
            {
                P012D023 = (int?)reader[180];
            }
            if (reader[181] != DBNull.Value)
            {
                P012D024 = (int?)reader[181];
            }
            if (reader[182] != DBNull.Value)
            {
                P012D025 = (int?)reader[182];
            }
            if (reader[183] != DBNull.Value)
            {
                P012D026 = (int?)reader[183];
            }
            if (reader[184] != DBNull.Value)
            {
                P012D027 = (int?)reader[184];
            }
            if (reader[185] != DBNull.Value)
            {
                P012D028 = (int?)reader[185];
            }
            if (reader[186] != DBNull.Value)
            {
                P012D029 = (int?)reader[186];
            }
            if (reader[187] != DBNull.Value)
            {
                P012D030 = (int?)reader[187];
            }
            if (reader[188] != DBNull.Value)
            {
                P012D031 = (int?)reader[188];
            }
            if (reader[189] != DBNull.Value)
            {
                P012D032 = (int?)reader[189];
            }
            if (reader[190] != DBNull.Value)
            {
                P012D033 = (int?)reader[190];
            }
            if (reader[191] != DBNull.Value)
            {
                P012D034 = (int?)reader[191];
            }
            if (reader[192] != DBNull.Value)
            {
                P012D035 = (int?)reader[192];
            }
            if (reader[193] != DBNull.Value)
            {
                P012D036 = (int?)reader[193];
            }
            if (reader[194] != DBNull.Value)
            {
                P012D037 = (int?)reader[194];
            }
            if (reader[195] != DBNull.Value)
            {
                P012D038 = (int?)reader[195];
            }
            if (reader[196] != DBNull.Value)
            {
                P012D039 = (int?)reader[196];
            }
            if (reader[197] != DBNull.Value)
            {
                P012D040 = (int?)reader[197];
            }
            if (reader[198] != DBNull.Value)
            {
                P012D041 = (int?)reader[198];
            }
            if (reader[199] != DBNull.Value)
            {
                P012D042 = (int?)reader[199];
            }
            if (reader[200] != DBNull.Value)
            {
                P012D043 = (int?)reader[200];
            }
            if (reader[201] != DBNull.Value)
            {
                P012D044 = (int?)reader[201];
            }
            if (reader[202] != DBNull.Value)
            {
                P012D045 = (int?)reader[202];
            }
            if (reader[203] != DBNull.Value)
            {
                P012D046 = (int?)reader[203];
            }
            if (reader[204] != DBNull.Value)
            {
                P012D047 = (int?)reader[204];
            }
            if (reader[205] != DBNull.Value)
            {
                P012D048 = (int?)reader[205];
            }
            if (reader[206] != DBNull.Value)
            {
                P012D049 = (int?)reader[206];
            }
            if (reader[207] != DBNull.Value)
            {
                P012E001 = (int?)reader[207];
            }
            if (reader[208] != DBNull.Value)
            {
                P012E002 = (int?)reader[208];
            }
            if (reader[209] != DBNull.Value)
            {
                P012E003 = (int?)reader[209];
            }
            if (reader[210] != DBNull.Value)
            {
                P012E004 = (int?)reader[210];
            }
            if (reader[211] != DBNull.Value)
            {
                P012E005 = (int?)reader[211];
            }
            if (reader[212] != DBNull.Value)
            {
                P012E006 = (int?)reader[212];
            }
            if (reader[213] != DBNull.Value)
            {
                P012E007 = (int?)reader[213];
            }
            if (reader[214] != DBNull.Value)
            {
                P012E008 = (int?)reader[214];
            }
            if (reader[215] != DBNull.Value)
            {
                P012E009 = (int?)reader[215];
            }
            if (reader[216] != DBNull.Value)
            {
                P012E010 = (int?)reader[216];
            }
            if (reader[217] != DBNull.Value)
            {
                P012E011 = (int?)reader[217];
            }
            if (reader[218] != DBNull.Value)
            {
                P012E012 = (int?)reader[218];
            }
            if (reader[219] != DBNull.Value)
            {
                P012E013 = (int?)reader[219];
            }
            if (reader[220] != DBNull.Value)
            {
                P012E014 = (int?)reader[220];
            }
            if (reader[221] != DBNull.Value)
            {
                P012E015 = (int?)reader[221];
            }
            if (reader[222] != DBNull.Value)
            {
                P012E016 = (int?)reader[222];
            }
            if (reader[223] != DBNull.Value)
            {
                P012E017 = (int?)reader[223];
            }
            if (reader[224] != DBNull.Value)
            {
                P012E018 = (int?)reader[224];
            }
            if (reader[225] != DBNull.Value)
            {
                P012E019 = (int?)reader[225];
            }
            if (reader[226] != DBNull.Value)
            {
                P012E020 = (int?)reader[226];
            }
            if (reader[227] != DBNull.Value)
            {
                P012E021 = (int?)reader[227];
            }
            if (reader[228] != DBNull.Value)
            {
                P012E022 = (int?)reader[228];
            }
            if (reader[229] != DBNull.Value)
            {
                P012E023 = (int?)reader[229];
            }
            if (reader[230] != DBNull.Value)
            {
                P012E024 = (int?)reader[230];
            }
            if (reader[231] != DBNull.Value)
            {
                P012E025 = (int?)reader[231];
            }
            if (reader[232] != DBNull.Value)
            {
                P012E026 = (int?)reader[232];
            }
            if (reader[233] != DBNull.Value)
            {
                P012E027 = (int?)reader[233];
            }
            if (reader[234] != DBNull.Value)
            {
                P012E028 = (int?)reader[234];
            }
            if (reader[235] != DBNull.Value)
            {
                P012E029 = (int?)reader[235];
            }
            if (reader[236] != DBNull.Value)
            {
                P012E030 = (int?)reader[236];
            }
            if (reader[237] != DBNull.Value)
            {
                P012E031 = (int?)reader[237];
            }
            if (reader[238] != DBNull.Value)
            {
                P012E032 = (int?)reader[238];
            }
            if (reader[239] != DBNull.Value)
            {
                P012E033 = (int?)reader[239];
            }
            if (reader[240] != DBNull.Value)
            {
                P012E034 = (int?)reader[240];
            }
            if (reader[241] != DBNull.Value)
            {
                P012E035 = (int?)reader[241];
            }
            if (reader[242] != DBNull.Value)
            {
                P012E036 = (int?)reader[242];
            }
            if (reader[243] != DBNull.Value)
            {
                P012E037 = (int?)reader[243];
            }
            if (reader[244] != DBNull.Value)
            {
                P012E038 = (int?)reader[244];
            }
            if (reader[245] != DBNull.Value)
            {
                P012E039 = (int?)reader[245];
            }
            if (reader[246] != DBNull.Value)
            {
                P012E040 = (int?)reader[246];
            }
            if (reader[247] != DBNull.Value)
            {
                P012E041 = (int?)reader[247];
            }
            if (reader[248] != DBNull.Value)
            {
                P012E042 = (int?)reader[248];
            }
            if (reader[249] != DBNull.Value)
            {
                P012E043 = (int?)reader[249];
            }
            if (reader[250] != DBNull.Value)
            {
                P012E044 = (int?)reader[250];
            }
            if (reader[251] != DBNull.Value)
            {
                P012E045 = (int?)reader[251];
            }
            if (reader[252] != DBNull.Value)
            {
                P012E046 = (int?)reader[252];
            }
            if (reader[253] != DBNull.Value)
            {
                P012E047 = (int?)reader[253];
            }
            if (reader[254] != DBNull.Value)
            {
                P012E048 = (int?)reader[254];
            }
            if (reader[255] != DBNull.Value)
            {
                P012E049 = (int?)reader[255];
            }
        }
        #endregion Constructors
    }
}
