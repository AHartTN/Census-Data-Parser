#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2016 11:02 AM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1CongressionalDistricts113_SF1_00006.cs
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

    public class SF1CongressionalDistricts113_SF1_00006 : BaseModel
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
        [Column("P0310001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public int? P0310001 { get; set; }

        [ReadOnly(false)]
        [Column("P0310002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 6)]
        public int? P0310002 { get; set; }

        [ReadOnly(false)]
        [Column("P0310003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 7)]
        public int? P0310003 { get; set; }

        [ReadOnly(false)]
        [Column("P0310004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Related child:", ShortName = "Related child:", Order = 8)]
        public int? P0310004 { get; set; }

        [ReadOnly(false)]
        [Column("P0310005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Own child:", ShortName = "Own child:", Order = 9)]
        public int? P0310005 { get; set; }

        [ReadOnly(false)]
        [Column("P0310006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 10)]
        public int? P0310006 { get; set; }

        [ReadOnly(false)]
        [Column("P0310007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In other family:", ShortName = "In other family:", Order = 11)]
        public int? P0310007 { get; set; }

        [ReadOnly(false)]
        [Column("P0310008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In male householder, no wife present family", ShortName = "In male householder, no wife present family", Order = 12)]
        public int? P0310008 { get; set; }

        [ReadOnly(false)]
        [Column("P0310009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In female householder, no husband present family", ShortName = "In female householder, no husband present family", Order = 13)]
        public int? P0310009 { get; set; }

        [ReadOnly(false)]
        [Column("P0310010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 14)]
        public int? P0310010 { get; set; }

        [ReadOnly(false)]
        [Column("P0310011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 15)]
        public int? P0310011 { get; set; }

        [ReadOnly(false)]
        [Column("P0310012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 16)]
        public int? P0310012 { get; set; }

        [ReadOnly(false)]
        [Column("P0310013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 17)]
        public int? P0310013 { get; set; }

        [ReadOnly(false)]
        [Column("P0310014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 18)]
        public int? P0310014 { get; set; }

        [ReadOnly(false)]
        [Column("P0310015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 19)]
        public int? P0310015 { get; set; }

        [ReadOnly(false)]
        [Column("P0310016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 20)]
        public int? P0310016 { get; set; }

        [ReadOnly(false)]
        [Column("P0320001", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 21)]
        public int? P0320001 { get; set; }

        [ReadOnly(false)]
        [Column("P0320002", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 22)]
        public int? P0320002 { get; set; }

        [ReadOnly(false)]
        [Column("P0320003", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 23)]
        public int? P0320003 { get; set; }

        [ReadOnly(false)]
        [Column("P0320004", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Related child:", ShortName = "Related child:", Order = 24)]
        public int? P0320004 { get; set; }

        [ReadOnly(false)]
        [Column("P0320005", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Own child:", ShortName = "Own child:", Order = 25)]
        public int? P0320005 { get; set; }

        [ReadOnly(false)]
        [Column("P0320006", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 26)]
        public int? P0320006 { get; set; }

        [ReadOnly(false)]
        [Column("P0320007", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 27)]
        public int? P0320007 { get; set; }

        [ReadOnly(false)]
        [Column("P0320008", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 28)]
        public int? P0320008 { get; set; }

        [ReadOnly(false)]
        [Column("P0320009", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 29)]
        public int? P0320009 { get; set; }

        [ReadOnly(false)]
        [Column("P0320010", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 and 13 years", ShortName = "12 and 13 years", Order = 30)]
        public int? P0320010 { get; set; }

        [ReadOnly(false)]
        [Column("P0320011", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "14 years", ShortName = "14 years", Order = 31)]
        public int? P0320011 { get; set; }

        [ReadOnly(false)]
        [Column("P0320012", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 32)]
        public int? P0320012 { get; set; }

        [ReadOnly(false)]
        [Column("P0320013", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 33)]
        public int? P0320013 { get; set; }

        [ReadOnly(false)]
        [Column("P0320014", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 34)]
        public int? P0320014 { get; set; }

        [ReadOnly(false)]
        [Column("P0320015", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 35)]
        public int? P0320015 { get; set; }

        [ReadOnly(false)]
        [Column("P0320016", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 36)]
        public int? P0320016 { get; set; }

        [ReadOnly(false)]
        [Column("P0320017", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 37)]
        public int? P0320017 { get; set; }

        [ReadOnly(false)]
        [Column("P0320018", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 and 13 years", ShortName = "12 and 13 years", Order = 38)]
        public int? P0320018 { get; set; }

        [ReadOnly(false)]
        [Column("P0320019", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "14 years", ShortName = "14 years", Order = 39)]
        public int? P0320019 { get; set; }

        [ReadOnly(false)]
        [Column("P0320020", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 40)]
        public int? P0320020 { get; set; }

        [ReadOnly(false)]
        [Column("P0320021", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives:", ShortName = "Nonrelatives:", Order = 41)]
        public int? P0320021 { get; set; }

        [ReadOnly(false)]
        [Column("P0320022", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 42)]
        public int? P0320022 { get; set; }

        [ReadOnly(false)]
        [Column("P0320023", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 43)]
        public int? P0320023 { get; set; }

        [ReadOnly(false)]
        [Column("P0320024", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 44)]
        public int? P0320024 { get; set; }

        [ReadOnly(false)]
        [Column("P0320025", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 45)]
        public int? P0320025 { get; set; }

        [ReadOnly(false)]
        [Column("P0320026", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 and 13 years", ShortName = "12 and 13 years", Order = 46)]
        public int? P0320026 { get; set; }

        [ReadOnly(false)]
        [Column("P0320027", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "14 years", ShortName = "14 years", Order = 47)]
        public int? P0320027 { get; set; }

        [ReadOnly(false)]
        [Column("P0320028", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 48)]
        public int? P0320028 { get; set; }

        [ReadOnly(false)]
        [Column("P0320029", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 49)]
        public int? P0320029 { get; set; }

        [ReadOnly(false)]
        [Column("P0320030", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population:", ShortName = "Institutionalized population:", Order = 50)]
        public int? P0320030 { get; set; }

        [ReadOnly(false)]
        [Column("P0320031", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 51)]
        public int? P0320031 { get; set; }

        [ReadOnly(false)]
        [Column("P0320032", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 52)]
        public int? P0320032 { get; set; }

        [ReadOnly(false)]
        [Column("P0320033", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 53)]
        public int? P0320033 { get; set; }

        [ReadOnly(false)]
        [Column("P0320034", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 54)]
        public int? P0320034 { get; set; }

        [ReadOnly(false)]
        [Column("P0320035", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 and 13 years", ShortName = "12 and 13 years", Order = 55)]
        public int? P0320035 { get; set; }

        [ReadOnly(false)]
        [Column("P0320036", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "14 years", ShortName = "14 years", Order = 56)]
        public int? P0320036 { get; set; }

        [ReadOnly(false)]
        [Column("P0320037", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 57)]
        public int? P0320037 { get; set; }

        [ReadOnly(false)]
        [Column("P0320038", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population:", ShortName = "Noninstitutionalized population:", Order = 58)]
        public int? P0320038 { get; set; }

        [ReadOnly(false)]
        [Column("P0320039", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 59)]
        public int? P0320039 { get; set; }

        [ReadOnly(false)]
        [Column("P0320040", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 60)]
        public int? P0320040 { get; set; }

        [ReadOnly(false)]
        [Column("P0320041", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 61)]
        public int? P0320041 { get; set; }

        [ReadOnly(false)]
        [Column("P0320042", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 62)]
        public int? P0320042 { get; set; }

        [ReadOnly(false)]
        [Column("P0320043", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 and 13 years", ShortName = "12 and 13 years", Order = 63)]
        public int? P0320043 { get; set; }

        [ReadOnly(false)]
        [Column("P0320044", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "14 years", ShortName = "14 years", Order = 64)]
        public int? P0320044 { get; set; }

        [ReadOnly(false)]
        [Column("P0320045", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 65)]
        public int? P0320045 { get; set; }

        [ReadOnly(false)]
        [Column("P0330001", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 66)]
        public int? P0330001 { get; set; }

        [ReadOnly(false)]
        [Column("P0330002", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 67)]
        public int? P0330002 { get; set; }

        [ReadOnly(false)]
        [Column("P0330003", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 68)]
        public int? P0330003 { get; set; }

        [ReadOnly(false)]
        [Column("P0330004", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In other family:", ShortName = "In other family:", Order = 69)]
        public int? P0330004 { get; set; }

        [ReadOnly(false)]
        [Column("P0330005", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In male householder, no wife present family", ShortName = "In male householder, no wife present family", Order = 70)]
        public int? P0330005 { get; set; }

        [ReadOnly(false)]
        [Column("P0330006", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In female householder, no husband present family", ShortName = "In female householder, no husband present family", Order = 71)]
        public int? P0330006 { get; set; }

        [ReadOnly(false)]
        [Column("P0330007", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households", ShortName = "In nonfamily households", Order = 72)]
        public int? P0330007 { get; set; }

        [ReadOnly(false)]
        [Column("P0340001", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 73)]
        public int? P0340001 { get; set; }

        [ReadOnly(false)]
        [Column("P0340002", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 74)]
        public int? P0340002 { get; set; }

        [ReadOnly(false)]
        [Column("P0340003", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 75)]
        public int? P0340003 { get; set; }

        [ReadOnly(false)]
        [Column("P0340004", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder:", ShortName = "Householder:", Order = 76)]
        public int? P0340004 { get; set; }

        [ReadOnly(false)]
        [Column("P0340005", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 77)]
        public int? P0340005 { get; set; }

        [ReadOnly(false)]
        [Column("P0340006", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 78)]
        public int? P0340006 { get; set; }

        [ReadOnly(false)]
        [Column("P0340007", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spouse", ShortName = "Spouse", Order = 79)]
        public int? P0340007 { get; set; }

        [ReadOnly(false)]
        [Column("P0340008", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent", ShortName = "Parent", Order = 80)]
        public int? P0340008 { get; set; }

        [ReadOnly(false)]
        [Column("P0340009", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 81)]
        public int? P0340009 { get; set; }

        [ReadOnly(false)]
        [Column("P0340010", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 82)]
        public int? P0340010 { get; set; }

        [ReadOnly(false)]
        [Column("P0340011", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 83)]
        public int? P0340011 { get; set; }

        [ReadOnly(false)]
        [Column("P0340012", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 84)]
        public int? P0340012 { get; set; }

        [ReadOnly(false)]
        [Column("P0340013", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 85)]
        public int? P0340013 { get; set; }

        [ReadOnly(false)]
        [Column("P0340014", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 86)]
        public int? P0340014 { get; set; }

        [ReadOnly(false)]
        [Column("P0340015", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 87)]
        public int? P0340015 { get; set; }

        [ReadOnly(false)]
        [Column("P0340016", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 88)]
        public int? P0340016 { get; set; }

        [ReadOnly(false)]
        [Column("P0340017", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 89)]
        public int? P0340017 { get; set; }

        [ReadOnly(false)]
        [Column("P0340018", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 90)]
        public int? P0340018 { get; set; }

        [ReadOnly(false)]
        [Column("P0340019", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 91)]
        public int? P0340019 { get; set; }

        [ReadOnly(false)]
        [Column("P0340020", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 92)]
        public int? P0340020 { get; set; }

        [ReadOnly(false)]
        [Column("P0340021", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 93)]
        public int? P0340021 { get; set; }

        [ReadOnly(false)]
        [Column("P0340022", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 94)]
        public int? P0340022 { get; set; }

        [ReadOnly(false)]
        [Column("P0350001", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total", ShortName = "Total", Order = 95)]
        public int? P0350001 { get; set; }

        [ReadOnly(false)]
        [Column("P0360001", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 96)]
        public int? P0360001 { get; set; }

        [ReadOnly(false)]
        [Column("P0360002", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 97)]
        public int? P0360002 { get; set; }

        [ReadOnly(false)]
        [Column("P0360003", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 98)]
        public int? P0360003 { get; set; }

        [ReadOnly(false)]
        [Column("P0370001", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 99)]
        public double? P0370001 { get; set; }

        [ReadOnly(false)]
        [Column("P0370002", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 100)]
        public double? P0370002 { get; set; }

        [ReadOnly(false)]
        [Column("P0370003", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 101)]
        public double? P0370003 { get; set; }

        [ReadOnly(false)]
        [Column("P0380001", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 102)]
        public int? P0380001 { get; set; }

        [ReadOnly(false)]
        [Column("P0380002", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 103)]
        public int? P0380002 { get; set; }

        [ReadOnly(false)]
        [Column("P0380003", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 104)]
        public int? P0380003 { get; set; }

        [ReadOnly(false)]
        [Column("P0380004", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 105)]
        public int? P0380004 { get; set; }

        [ReadOnly(false)]
        [Column("P0380005", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 106)]
        public int? P0380005 { get; set; }

        [ReadOnly(false)]
        [Column("P0380006", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 107)]
        public int? P0380006 { get; set; }

        [ReadOnly(false)]
        [Column("P0380007", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 108)]
        public int? P0380007 { get; set; }

        [ReadOnly(false)]
        [Column("P0380008", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 109)]
        public int? P0380008 { get; set; }

        [ReadOnly(false)]
        [Column("P0380009", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 110)]
        public int? P0380009 { get; set; }

        [ReadOnly(false)]
        [Column("P0380010", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 111)]
        public int? P0380010 { get; set; }

        [ReadOnly(false)]
        [Column("P0380011", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 112)]
        public int? P0380011 { get; set; }

        [ReadOnly(false)]
        [Column("P0380012", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 113)]
        public int? P0380012 { get; set; }

        [ReadOnly(false)]
        [Column("P0380013", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 114)]
        public int? P0380013 { get; set; }

        [ReadOnly(false)]
        [Column("P0380014", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 115)]
        public int? P0380014 { get; set; }

        [ReadOnly(false)]
        [Column("P0380015", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 116)]
        public int? P0380015 { get; set; }

        [ReadOnly(false)]
        [Column("P0380016", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 117)]
        public int? P0380016 { get; set; }

        [ReadOnly(false)]
        [Column("P0380017", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 118)]
        public int? P0380017 { get; set; }

        [ReadOnly(false)]
        [Column("P0380018", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 119)]
        public int? P0380018 { get; set; }

        [ReadOnly(false)]
        [Column("P0380019", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 120)]
        public int? P0380019 { get; set; }

        [ReadOnly(false)]
        [Column("P0380020", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 121)]
        public int? P0380020 { get; set; }

        [ReadOnly(false)]
        [Column("P0390001", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 122)]
        public int? P0390001 { get; set; }

        [ReadOnly(false)]
        [Column("P0390002", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 123)]
        public int? P0390002 { get; set; }

        [ReadOnly(false)]
        [Column("P0390003", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 124)]
        public int? P0390003 { get; set; }

        [ReadOnly(false)]
        [Column("P0390004", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 125)]
        public int? P0390004 { get; set; }

        [ReadOnly(false)]
        [Column("P0390005", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 126)]
        public int? P0390005 { get; set; }

        [ReadOnly(false)]
        [Column("P0390006", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 127)]
        public int? P0390006 { get; set; }

        [ReadOnly(false)]
        [Column("P0390007", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 128)]
        public int? P0390007 { get; set; }

        [ReadOnly(false)]
        [Column("P0390008", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 129)]
        public int? P0390008 { get; set; }

        [ReadOnly(false)]
        [Column("P0390009", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 130)]
        public int? P0390009 { get; set; }

        [ReadOnly(false)]
        [Column("P0390010", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 131)]
        public int? P0390010 { get; set; }

        [ReadOnly(false)]
        [Column("P0390011", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 132)]
        public int? P0390011 { get; set; }

        [ReadOnly(false)]
        [Column("P0390012", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 133)]
        public int? P0390012 { get; set; }

        [ReadOnly(false)]
        [Column("P0390013", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 134)]
        public int? P0390013 { get; set; }

        [ReadOnly(false)]
        [Column("P0390014", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 135)]
        public int? P0390014 { get; set; }

        [ReadOnly(false)]
        [Column("P0390015", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 136)]
        public int? P0390015 { get; set; }

        [ReadOnly(false)]
        [Column("P0390016", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 137)]
        public int? P0390016 { get; set; }

        [ReadOnly(false)]
        [Column("P0390017", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 138)]
        public int? P0390017 { get; set; }

        [ReadOnly(false)]
        [Column("P0390018", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 139)]
        public int? P0390018 { get; set; }

        [ReadOnly(false)]
        [Column("P0390019", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 140)]
        public int? P0390019 { get; set; }

        [ReadOnly(false)]
        [Column("P0390020", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 141)]
        public int? P0390020 { get; set; }

        [ReadOnly(false)]
        [Column("P0400001", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 142)]
        public int? P0400001 { get; set; }

        [ReadOnly(false)]
        [Column("P0400002", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In husband-wife families:", ShortName = "In husband-wife families:", Order = 143)]
        public int? P0400002 { get; set; }

        [ReadOnly(false)]
        [Column("P0400003", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 144)]
        public int? P0400003 { get; set; }

        [ReadOnly(false)]
        [Column("P0400004", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 145)]
        public int? P0400004 { get; set; }

        [ReadOnly(false)]
        [Column("P0400005", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 146)]
        public int? P0400005 { get; set; }

        [ReadOnly(false)]
        [Column("P0400006", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 147)]
        public int? P0400006 { get; set; }

        [ReadOnly(false)]
        [Column("P0400007", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 to 17 years", ShortName = "12 to 17 years", Order = 148)]
        public int? P0400007 { get; set; }

        [ReadOnly(false)]
        [Column("P0400008", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In other families:", ShortName = "In other families:", Order = 149)]
        public int? P0400008 { get; set; }

        [ReadOnly(false)]
        [Column("P0400009", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In male householder, no wife present family", ShortName = "In male householder, no wife present family", Order = 150)]
        public int? P0400009 { get; set; }

        [ReadOnly(false)]
        [Column("P0400010", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 151)]
        public int? P0400010 { get; set; }

        [ReadOnly(false)]
        [Column("P0400011", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 152)]
        public int? P0400011 { get; set; }

        [ReadOnly(false)]
        [Column("P0400012", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 153)]
        public int? P0400012 { get; set; }

        [ReadOnly(false)]
        [Column("P0400013", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 154)]
        public int? P0400013 { get; set; }

        [ReadOnly(false)]
        [Column("P0400014", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 to 17 years", ShortName = "12 to 17 years", Order = 155)]
        public int? P0400014 { get; set; }

        [ReadOnly(false)]
        [Column("P0400015", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In female householder, no husband present family", ShortName = "In female householder, no husband present family", Order = 156)]
        public int? P0400015 { get; set; }

        [ReadOnly(false)]
        [Column("P0400016", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 157)]
        public int? P0400016 { get; set; }

        [ReadOnly(false)]
        [Column("P0400017", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 158)]
        public int? P0400017 { get; set; }

        [ReadOnly(false)]
        [Column("P0400018", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 159)]
        public int? P0400018 { get; set; }

        [ReadOnly(false)]
        [Column("P0400019", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 160)]
        public int? P0400019 { get; set; }

        [ReadOnly(false)]
        [Column("P0400020", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 to 17 years", ShortName = "12 to 17 years", Order = 161)]
        public int? P0400020 { get; set; }

        [ReadOnly(false)]
        [Column("P0410001", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 162)]
        public int? P0410001 { get; set; }

        [ReadOnly(false)]
        [Column("P0410002", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 163)]
        public int? P0410002 { get; set; }

        [ReadOnly(false)]
        [Column("P0410003", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 164)]
        public int? P0410003 { get; set; }

        [ReadOnly(false)]
        [Column("P0410004", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 165)]
        public int? P0410004 { get; set; }

        [ReadOnly(false)]
        [Column("P0410005", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 166)]
        public int? P0410005 { get; set; }

        [ReadOnly(false)]
        [Column("P0410006", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 to 17 years", ShortName = "12 to 17 years", Order = 167)]
        public int? P0410006 { get; set; }

        [ReadOnly(false)]
        [Column("P0420001", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 168)]
        public int? P0420001 { get; set; }

        [ReadOnly(false)]
        [Column("P0420002", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 169)]
        public int? P0420002 { get; set; }

        [ReadOnly(false)]
        [Column("P0420003", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 170)]
        public int? P0420003 { get; set; }

        [ReadOnly(false)]
        [Column("P0420004", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 171)]
        public int? P0420004 { get; set; }

        [ReadOnly(false)]
        [Column("P0420005", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 172)]
        public int? P0420005 { get; set; }

        [ReadOnly(false)]
        [Column("P0420006", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 173)]
        public int? P0420006 { get; set; }

        [ReadOnly(false)]
        [Column("P0420007", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 174)]
        public int? P0420007 { get; set; }

        [ReadOnly(false)]
        [Column("P0420008", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 175)]
        public int? P0420008 { get; set; }

        [ReadOnly(false)]
        [Column("P0420009", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 176)]
        public int? P0420009 { get; set; }

        [ReadOnly(false)]
        [Column("P0420010", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706,   801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706,   801-802, 900-901, 903-904)", Order = 177)]
        public int? P0420010 { get; set; }

        [ReadOnly(false)]
        [Column("P0430001", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 178)]
        public int? P0430001 { get; set; }

        [ReadOnly(false)]
        [Column("P0430002", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 179)]
        public int? P0430002 { get; set; }

        [ReadOnly(false)]
        [Column("P0430003", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years:", ShortName = "Under 18 years:", Order = 180)]
        public int? P0430003 { get; set; }

        [ReadOnly(false)]
        [Column("P0430004", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 181)]
        public int? P0430004 { get; set; }

        [ReadOnly(false)]
        [Column("P0430005", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 182)]
        public int? P0430005 { get; set; }

        [ReadOnly(false)]
        [Column("P0430006", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 183)]
        public int? P0430006 { get; set; }

        [ReadOnly(false)]
        [Column("P0430007", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 184)]
        public int? P0430007 { get; set; }

        [ReadOnly(false)]
        [Column("P0430008", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 185)]
        public int? P0430008 { get; set; }

        [ReadOnly(false)]
        [Column("P0430009", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 186)]
        public int? P0430009 { get; set; }

        [ReadOnly(false)]
        [Column("P0430010", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 187)]
        public int? P0430010 { get; set; }

        [ReadOnly(false)]
        [Column("P0430011", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 188)]
        public int? P0430011 { get; set; }

        [ReadOnly(false)]
        [Column("P0430012", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706,   801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706,   801-802, 900-901, 903-904)", Order = 189)]
        public int? P0430012 { get; set; }

        [ReadOnly(false)]
        [Column("P0430013", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 to 64 years:", ShortName = "18 to 64 years:", Order = 190)]
        public int? P0430013 { get; set; }

        [ReadOnly(false)]
        [Column("P0430014", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 191)]
        public int? P0430014 { get; set; }

        [ReadOnly(false)]
        [Column("P0430015", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 192)]
        public int? P0430015 { get; set; }

        [ReadOnly(false)]
        [Column("P0430016", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 193)]
        public int? P0430016 { get; set; }

        [ReadOnly(false)]
        [Column("P0430017", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 194)]
        public int? P0430017 { get; set; }

        [ReadOnly(false)]
        [Column("P0430018", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 195)]
        public int? P0430018 { get; set; }

        [ReadOnly(false)]
        [Column("P0430019", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 196)]
        public int? P0430019 { get; set; }

        [ReadOnly(false)]
        [Column("P0430020", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 197)]
        public int? P0430020 { get; set; }

        [ReadOnly(false)]
        [Column("P0430021", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 198)]
        public int? P0430021 { get; set; }

        [ReadOnly(false)]
        [Column("P0430022", Order = 199)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706,   801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706,   801-802, 900-901, 903-904)", Order = 199)]
        public int? P0430022 { get; set; }

        [ReadOnly(false)]
        [Column("P0430023", Order = 200)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 years and over:", ShortName = "65 years and over:", Order = 200)]
        public int? P0430023 { get; set; }

        [ReadOnly(false)]
        [Column("P0430024", Order = 201)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 201)]
        public int? P0430024 { get; set; }

        [ReadOnly(false)]
        [Column("P0430025", Order = 202)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 202)]
        public int? P0430025 { get; set; }

        [ReadOnly(false)]
        [Column("P0430026", Order = 203)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 203)]
        public int? P0430026 { get; set; }

        [ReadOnly(false)]
        [Column("P0430027", Order = 204)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 204)]
        public int? P0430027 { get; set; }

        [ReadOnly(false)]
        [Column("P0430028", Order = 205)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 205)]
        public int? P0430028 { get; set; }

        [ReadOnly(false)]
        [Column("P0430029", Order = 206)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 206)]
        public int? P0430029 { get; set; }

        [ReadOnly(false)]
        [Column("P0430030", Order = 207)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 207)]
        public int? P0430030 { get; set; }

        [ReadOnly(false)]
        [Column("P0430031", Order = 208)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 208)]
        public int? P0430031 { get; set; }

        [ReadOnly(false)]
        [Column("P0430032", Order = 209)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706,   801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706,   801-802, 900-901, 903-904)", Order = 209)]
        public int? P0430032 { get; set; }

        [ReadOnly(false)]
        [Column("P0430033", Order = 210)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 210)]
        public int? P0430033 { get; set; }

        [ReadOnly(false)]
        [Column("P0430034", Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years:", ShortName = "Under 18 years:", Order = 211)]
        public int? P0430034 { get; set; }

        [ReadOnly(false)]
        [Column("P0430035", Order = 212)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 212)]
        public int? P0430035 { get; set; }

        [ReadOnly(false)]
        [Column("P0430036", Order = 213)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 213)]
        public int? P0430036 { get; set; }

        [ReadOnly(false)]
        [Column("P0430037", Order = 214)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 214)]
        public int? P0430037 { get; set; }

        [ReadOnly(false)]
        [Column("P0430038", Order = 215)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 215)]
        public int? P0430038 { get; set; }

        [ReadOnly(false)]
        [Column("P0430039", Order = 216)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 216)]
        public int? P0430039 { get; set; }

        [ReadOnly(false)]
        [Column("P0430040", Order = 217)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 217)]
        public int? P0430040 { get; set; }

        [ReadOnly(false)]
        [Column("P0430041", Order = 218)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 218)]
        public int? P0430041 { get; set; }

        [ReadOnly(false)]
        [Column("P0430042", Order = 219)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 219)]
        public int? P0430042 { get; set; }

        [ReadOnly(false)]
        [Column("P0430043", Order = 220)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706,   801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706,   801-802, 900-901, 903-904)", Order = 220)]
        public int? P0430043 { get; set; }

        [ReadOnly(false)]
        [Column("P0430044", Order = 221)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 to 64 years:", ShortName = "18 to 64 years:", Order = 221)]
        public int? P0430044 { get; set; }

        [ReadOnly(false)]
        [Column("P0430045", Order = 222)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 222)]
        public int? P0430045 { get; set; }

        [ReadOnly(false)]
        [Column("P0430046", Order = 223)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 223)]
        public int? P0430046 { get; set; }

        [ReadOnly(false)]
        [Column("P0430047", Order = 224)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 224)]
        public int? P0430047 { get; set; }

        [ReadOnly(false)]
        [Column("P0430048", Order = 225)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 225)]
        public int? P0430048 { get; set; }

        [ReadOnly(false)]
        [Column("P0430049", Order = 226)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 226)]
        public int? P0430049 { get; set; }

        [ReadOnly(false)]
        [Column("P0430050", Order = 227)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 227)]
        public int? P0430050 { get; set; }

        [ReadOnly(false)]
        [Column("P0430051", Order = 228)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 228)]
        public int? P0430051 { get; set; }

        [ReadOnly(false)]
        [Column("P0430052", Order = 229)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 229)]
        public int? P0430052 { get; set; }

        [ReadOnly(false)]
        [Column("P0430053", Order = 230)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706,   801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706,   801-802, 900-901, 903-904)", Order = 230)]
        public int? P0430053 { get; set; }

        [ReadOnly(false)]
        [Column("P0430054", Order = 231)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 years and over:", ShortName = "65 years and over:", Order = 231)]
        public int? P0430054 { get; set; }

        [ReadOnly(false)]
        [Column("P0430055", Order = 232)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 232)]
        public int? P0430055 { get; set; }

        [ReadOnly(false)]
        [Column("P0430056", Order = 233)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 233)]
        public int? P0430056 { get; set; }

        [ReadOnly(false)]
        [Column("P0430057", Order = 234)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 234)]
        public int? P0430057 { get; set; }

        [ReadOnly(false)]
        [Column("P0430058", Order = 235)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 235)]
        public int? P0430058 { get; set; }

        [ReadOnly(false)]
        [Column("P0430059", Order = 236)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 236)]
        public int? P0430059 { get; set; }

        [ReadOnly(false)]
        [Column("P0430060", Order = 237)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 237)]
        public int? P0430060 { get; set; }

        [ReadOnly(false)]
        [Column("P0430061", Order = 238)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 238)]
        public int? P0430061 { get; set; }

        [ReadOnly(false)]
        [Column("P0430062", Order = 239)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 239)]
        public int? P0430062 { get; set; }

        [ReadOnly(false)]
        [Column("P0430063", Order = 240)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706,   801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706,   801-802, 900-901, 903-904)", Order = 240)]
        public int? P0430063 { get; set; }

        [ReadOnly(false)]
        [Column("P0440001", Order = 241)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 241)]
        public int? P0440001 { get; set; }

        [ReadOnly(false)]
        [Column("P0440002", Order = 242)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not substituted", ShortName = "Not substituted", Order = 242)]
        public int? P0440002 { get; set; }

        [ReadOnly(false)]
        [Column("P0440003", Order = 243)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Substituted", ShortName = "Substituted", Order = 243)]
        public int? P0440003 { get; set; }

        [ReadOnly(false)]
        [Column("P0450001", Order = 244)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 244)]
        public int? P0450001 { get; set; }

        [ReadOnly(false)]
        [Column("P0450002", Order = 245)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No items allocated", ShortName = "No items allocated", Order = 245)]
        public int? P0450002 { get; set; }

        [ReadOnly(false)]
        [Column("P0450003", Order = 246)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "One or more items allocated", ShortName = "One or more items allocated", Order = 246)]
        public int? P0450003 { get; set; }

        [ReadOnly(false)]
        [Column("P0460001", Order = 247)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 247)]
        public int? P0460001 { get; set; }

        [ReadOnly(false)]
        [Column("P0460002", Order = 248)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Allocated", ShortName = "Allocated", Order = 248)]
        public int? P0460002 { get; set; }

        [ReadOnly(false)]
        [Column("P0460003", Order = 249)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not allocated", ShortName = "Not allocated", Order = 249)]
        public int? P0460003 { get; set; }

        [ReadOnly(false)]
        [Column("P0470001", Order = 250)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 250)]
        public int? P0470001 { get; set; }

        [ReadOnly(false)]
        [Column("P0470002", Order = 251)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Allocated", ShortName = "Allocated", Order = 251)]
        public int? P0470002 { get; set; }

        [ReadOnly(false)]
        [Column("P0470003", Order = 252)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not allocated", ShortName = "Not allocated", Order = 252)]
        public int? P0470003 { get; set; }

        [ReadOnly(false)]
        [Column("P0480001", Order = 253)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 253)]
        public int? P0480001 { get; set; }

        [ReadOnly(false)]
        [Column("P0480002", Order = 254)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Allocated", ShortName = "Allocated", Order = 254)]
        public int? P0480002 { get; set; }

        [ReadOnly(false)]
        [Column("P0480003", Order = 255)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not allocated", ShortName = "Not allocated", Order = 255)]
        public int? P0480003 { get; set; }

        [ReadOnly(false)]
        [Column("P0490001", Order = 256)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 256)]
        public int? P0490001 { get; set; }

        [ReadOnly(false)]
        [Column("P0490002", Order = 257)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Allocated", ShortName = "Allocated", Order = 257)]
        public int? P0490002 { get; set; }

        [ReadOnly(false)]
        [Column("P0490003", Order = 258)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not allocated", ShortName = "Not allocated", Order = 258)]
        public int? P0490003 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1CongressionalDistricts113_SF1_00006(string csvLine) : base(csvLine) { }

        public SF1CongressionalDistricts113_SF1_00006(string[] values) : base(values) { }

        public SF1CongressionalDistricts113_SF1_00006(OleDbDataReader reader, CensusFileType fileType)
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
                P0310001 = (int?)reader[5];
            }
            if (reader[6] != DBNull.Value)
            {
                P0310002 = (int?)reader[6];
            }
            if (reader[7] != DBNull.Value)
            {
                P0310003 = (int?)reader[7];
            }
            if (reader[8] != DBNull.Value)
            {
                P0310004 = (int?)reader[8];
            }
            if (reader[9] != DBNull.Value)
            {
                P0310005 = (int?)reader[9];
            }
            if (reader[10] != DBNull.Value)
            {
                P0310006 = (int?)reader[10];
            }
            if (reader[11] != DBNull.Value)
            {
                P0310007 = (int?)reader[11];
            }
            if (reader[12] != DBNull.Value)
            {
                P0310008 = (int?)reader[12];
            }
            if (reader[13] != DBNull.Value)
            {
                P0310009 = (int?)reader[13];
            }
            if (reader[14] != DBNull.Value)
            {
                P0310010 = (int?)reader[14];
            }
            if (reader[15] != DBNull.Value)
            {
                P0310011 = (int?)reader[15];
            }
            if (reader[16] != DBNull.Value)
            {
                P0310012 = (int?)reader[16];
            }
            if (reader[17] != DBNull.Value)
            {
                P0310013 = (int?)reader[17];
            }
            if (reader[18] != DBNull.Value)
            {
                P0310014 = (int?)reader[18];
            }
            if (reader[19] != DBNull.Value)
            {
                P0310015 = (int?)reader[19];
            }
            if (reader[20] != DBNull.Value)
            {
                P0310016 = (int?)reader[20];
            }
            if (reader[21] != DBNull.Value)
            {
                P0320001 = (int?)reader[21];
            }
            if (reader[22] != DBNull.Value)
            {
                P0320002 = (int?)reader[22];
            }
            if (reader[23] != DBNull.Value)
            {
                P0320003 = (int?)reader[23];
            }
            if (reader[24] != DBNull.Value)
            {
                P0320004 = (int?)reader[24];
            }
            if (reader[25] != DBNull.Value)
            {
                P0320005 = (int?)reader[25];
            }
            if (reader[26] != DBNull.Value)
            {
                P0320006 = (int?)reader[26];
            }
            if (reader[27] != DBNull.Value)
            {
                P0320007 = (int?)reader[27];
            }
            if (reader[28] != DBNull.Value)
            {
                P0320008 = (int?)reader[28];
            }
            if (reader[29] != DBNull.Value)
            {
                P0320009 = (int?)reader[29];
            }
            if (reader[30] != DBNull.Value)
            {
                P0320010 = (int?)reader[30];
            }
            if (reader[31] != DBNull.Value)
            {
                P0320011 = (int?)reader[31];
            }
            if (reader[32] != DBNull.Value)
            {
                P0320012 = (int?)reader[32];
            }
            if (reader[33] != DBNull.Value)
            {
                P0320013 = (int?)reader[33];
            }
            if (reader[34] != DBNull.Value)
            {
                P0320014 = (int?)reader[34];
            }
            if (reader[35] != DBNull.Value)
            {
                P0320015 = (int?)reader[35];
            }
            if (reader[36] != DBNull.Value)
            {
                P0320016 = (int?)reader[36];
            }
            if (reader[37] != DBNull.Value)
            {
                P0320017 = (int?)reader[37];
            }
            if (reader[38] != DBNull.Value)
            {
                P0320018 = (int?)reader[38];
            }
            if (reader[39] != DBNull.Value)
            {
                P0320019 = (int?)reader[39];
            }
            if (reader[40] != DBNull.Value)
            {
                P0320020 = (int?)reader[40];
            }
            if (reader[41] != DBNull.Value)
            {
                P0320021 = (int?)reader[41];
            }
            if (reader[42] != DBNull.Value)
            {
                P0320022 = (int?)reader[42];
            }
            if (reader[43] != DBNull.Value)
            {
                P0320023 = (int?)reader[43];
            }
            if (reader[44] != DBNull.Value)
            {
                P0320024 = (int?)reader[44];
            }
            if (reader[45] != DBNull.Value)
            {
                P0320025 = (int?)reader[45];
            }
            if (reader[46] != DBNull.Value)
            {
                P0320026 = (int?)reader[46];
            }
            if (reader[47] != DBNull.Value)
            {
                P0320027 = (int?)reader[47];
            }
            if (reader[48] != DBNull.Value)
            {
                P0320028 = (int?)reader[48];
            }
            if (reader[49] != DBNull.Value)
            {
                P0320029 = (int?)reader[49];
            }
            if (reader[50] != DBNull.Value)
            {
                P0320030 = (int?)reader[50];
            }
            if (reader[51] != DBNull.Value)
            {
                P0320031 = (int?)reader[51];
            }
            if (reader[52] != DBNull.Value)
            {
                P0320032 = (int?)reader[52];
            }
            if (reader[53] != DBNull.Value)
            {
                P0320033 = (int?)reader[53];
            }
            if (reader[54] != DBNull.Value)
            {
                P0320034 = (int?)reader[54];
            }
            if (reader[55] != DBNull.Value)
            {
                P0320035 = (int?)reader[55];
            }
            if (reader[56] != DBNull.Value)
            {
                P0320036 = (int?)reader[56];
            }
            if (reader[57] != DBNull.Value)
            {
                P0320037 = (int?)reader[57];
            }
            if (reader[58] != DBNull.Value)
            {
                P0320038 = (int?)reader[58];
            }
            if (reader[59] != DBNull.Value)
            {
                P0320039 = (int?)reader[59];
            }
            if (reader[60] != DBNull.Value)
            {
                P0320040 = (int?)reader[60];
            }
            if (reader[61] != DBNull.Value)
            {
                P0320041 = (int?)reader[61];
            }
            if (reader[62] != DBNull.Value)
            {
                P0320042 = (int?)reader[62];
            }
            if (reader[63] != DBNull.Value)
            {
                P0320043 = (int?)reader[63];
            }
            if (reader[64] != DBNull.Value)
            {
                P0320044 = (int?)reader[64];
            }
            if (reader[65] != DBNull.Value)
            {
                P0320045 = (int?)reader[65];
            }
            if (reader[66] != DBNull.Value)
            {
                P0330001 = (int?)reader[66];
            }
            if (reader[67] != DBNull.Value)
            {
                P0330002 = (int?)reader[67];
            }
            if (reader[68] != DBNull.Value)
            {
                P0330003 = (int?)reader[68];
            }
            if (reader[69] != DBNull.Value)
            {
                P0330004 = (int?)reader[69];
            }
            if (reader[70] != DBNull.Value)
            {
                P0330005 = (int?)reader[70];
            }
            if (reader[71] != DBNull.Value)
            {
                P0330006 = (int?)reader[71];
            }
            if (reader[72] != DBNull.Value)
            {
                P0330007 = (int?)reader[72];
            }
            if (reader[73] != DBNull.Value)
            {
                P0340001 = (int?)reader[73];
            }
            if (reader[74] != DBNull.Value)
            {
                P0340002 = (int?)reader[74];
            }
            if (reader[75] != DBNull.Value)
            {
                P0340003 = (int?)reader[75];
            }
            if (reader[76] != DBNull.Value)
            {
                P0340004 = (int?)reader[76];
            }
            if (reader[77] != DBNull.Value)
            {
                P0340005 = (int?)reader[77];
            }
            if (reader[78] != DBNull.Value)
            {
                P0340006 = (int?)reader[78];
            }
            if (reader[79] != DBNull.Value)
            {
                P0340007 = (int?)reader[79];
            }
            if (reader[80] != DBNull.Value)
            {
                P0340008 = (int?)reader[80];
            }
            if (reader[81] != DBNull.Value)
            {
                P0340009 = (int?)reader[81];
            }
            if (reader[82] != DBNull.Value)
            {
                P0340010 = (int?)reader[82];
            }
            if (reader[83] != DBNull.Value)
            {
                P0340011 = (int?)reader[83];
            }
            if (reader[84] != DBNull.Value)
            {
                P0340012 = (int?)reader[84];
            }
            if (reader[85] != DBNull.Value)
            {
                P0340013 = (int?)reader[85];
            }
            if (reader[86] != DBNull.Value)
            {
                P0340014 = (int?)reader[86];
            }
            if (reader[87] != DBNull.Value)
            {
                P0340015 = (int?)reader[87];
            }
            if (reader[88] != DBNull.Value)
            {
                P0340016 = (int?)reader[88];
            }
            if (reader[89] != DBNull.Value)
            {
                P0340017 = (int?)reader[89];
            }
            if (reader[90] != DBNull.Value)
            {
                P0340018 = (int?)reader[90];
            }
            if (reader[91] != DBNull.Value)
            {
                P0340019 = (int?)reader[91];
            }
            if (reader[92] != DBNull.Value)
            {
                P0340020 = (int?)reader[92];
            }
            if (reader[93] != DBNull.Value)
            {
                P0340021 = (int?)reader[93];
            }
            if (reader[94] != DBNull.Value)
            {
                P0340022 = (int?)reader[94];
            }
            if (reader[95] != DBNull.Value)
            {
                P0350001 = (int?)reader[95];
            }
            if (reader[96] != DBNull.Value)
            {
                P0360001 = (int?)reader[96];
            }
            if (reader[97] != DBNull.Value)
            {
                P0360002 = (int?)reader[97];
            }
            if (reader[98] != DBNull.Value)
            {
                P0360003 = (int?)reader[98];
            }
            if (reader[99] != DBNull.Value)
            {
                P0370001 = (double?)reader[99];
            }
            if (reader[100] != DBNull.Value)
            {
                P0370002 = (double?)reader[100];
            }
            if (reader[101] != DBNull.Value)
            {
                P0370003 = (double?)reader[101];
            }
            if (reader[102] != DBNull.Value)
            {
                P0380001 = (int?)reader[102];
            }
            if (reader[103] != DBNull.Value)
            {
                P0380002 = (int?)reader[103];
            }
            if (reader[104] != DBNull.Value)
            {
                P0380003 = (int?)reader[104];
            }
            if (reader[105] != DBNull.Value)
            {
                P0380004 = (int?)reader[105];
            }
            if (reader[106] != DBNull.Value)
            {
                P0380005 = (int?)reader[106];
            }
            if (reader[107] != DBNull.Value)
            {
                P0380006 = (int?)reader[107];
            }
            if (reader[108] != DBNull.Value)
            {
                P0380007 = (int?)reader[108];
            }
            if (reader[109] != DBNull.Value)
            {
                P0380008 = (int?)reader[109];
            }
            if (reader[110] != DBNull.Value)
            {
                P0380009 = (int?)reader[110];
            }
            if (reader[111] != DBNull.Value)
            {
                P0380010 = (int?)reader[111];
            }
            if (reader[112] != DBNull.Value)
            {
                P0380011 = (int?)reader[112];
            }
            if (reader[113] != DBNull.Value)
            {
                P0380012 = (int?)reader[113];
            }
            if (reader[114] != DBNull.Value)
            {
                P0380013 = (int?)reader[114];
            }
            if (reader[115] != DBNull.Value)
            {
                P0380014 = (int?)reader[115];
            }
            if (reader[116] != DBNull.Value)
            {
                P0380015 = (int?)reader[116];
            }
            if (reader[117] != DBNull.Value)
            {
                P0380016 = (int?)reader[117];
            }
            if (reader[118] != DBNull.Value)
            {
                P0380017 = (int?)reader[118];
            }
            if (reader[119] != DBNull.Value)
            {
                P0380018 = (int?)reader[119];
            }
            if (reader[120] != DBNull.Value)
            {
                P0380019 = (int?)reader[120];
            }
            if (reader[121] != DBNull.Value)
            {
                P0380020 = (int?)reader[121];
            }
            if (reader[122] != DBNull.Value)
            {
                P0390001 = (int?)reader[122];
            }
            if (reader[123] != DBNull.Value)
            {
                P0390002 = (int?)reader[123];
            }
            if (reader[124] != DBNull.Value)
            {
                P0390003 = (int?)reader[124];
            }
            if (reader[125] != DBNull.Value)
            {
                P0390004 = (int?)reader[125];
            }
            if (reader[126] != DBNull.Value)
            {
                P0390005 = (int?)reader[126];
            }
            if (reader[127] != DBNull.Value)
            {
                P0390006 = (int?)reader[127];
            }
            if (reader[128] != DBNull.Value)
            {
                P0390007 = (int?)reader[128];
            }
            if (reader[129] != DBNull.Value)
            {
                P0390008 = (int?)reader[129];
            }
            if (reader[130] != DBNull.Value)
            {
                P0390009 = (int?)reader[130];
            }
            if (reader[131] != DBNull.Value)
            {
                P0390010 = (int?)reader[131];
            }
            if (reader[132] != DBNull.Value)
            {
                P0390011 = (int?)reader[132];
            }
            if (reader[133] != DBNull.Value)
            {
                P0390012 = (int?)reader[133];
            }
            if (reader[134] != DBNull.Value)
            {
                P0390013 = (int?)reader[134];
            }
            if (reader[135] != DBNull.Value)
            {
                P0390014 = (int?)reader[135];
            }
            if (reader[136] != DBNull.Value)
            {
                P0390015 = (int?)reader[136];
            }
            if (reader[137] != DBNull.Value)
            {
                P0390016 = (int?)reader[137];
            }
            if (reader[138] != DBNull.Value)
            {
                P0390017 = (int?)reader[138];
            }
            if (reader[139] != DBNull.Value)
            {
                P0390018 = (int?)reader[139];
            }
            if (reader[140] != DBNull.Value)
            {
                P0390019 = (int?)reader[140];
            }
            if (reader[141] != DBNull.Value)
            {
                P0390020 = (int?)reader[141];
            }
            if (reader[142] != DBNull.Value)
            {
                P0400001 = (int?)reader[142];
            }
            if (reader[143] != DBNull.Value)
            {
                P0400002 = (int?)reader[143];
            }
            if (reader[144] != DBNull.Value)
            {
                P0400003 = (int?)reader[144];
            }
            if (reader[145] != DBNull.Value)
            {
                P0400004 = (int?)reader[145];
            }
            if (reader[146] != DBNull.Value)
            {
                P0400005 = (int?)reader[146];
            }
            if (reader[147] != DBNull.Value)
            {
                P0400006 = (int?)reader[147];
            }
            if (reader[148] != DBNull.Value)
            {
                P0400007 = (int?)reader[148];
            }
            if (reader[149] != DBNull.Value)
            {
                P0400008 = (int?)reader[149];
            }
            if (reader[150] != DBNull.Value)
            {
                P0400009 = (int?)reader[150];
            }
            if (reader[151] != DBNull.Value)
            {
                P0400010 = (int?)reader[151];
            }
            if (reader[152] != DBNull.Value)
            {
                P0400011 = (int?)reader[152];
            }
            if (reader[153] != DBNull.Value)
            {
                P0400012 = (int?)reader[153];
            }
            if (reader[154] != DBNull.Value)
            {
                P0400013 = (int?)reader[154];
            }
            if (reader[155] != DBNull.Value)
            {
                P0400014 = (int?)reader[155];
            }
            if (reader[156] != DBNull.Value)
            {
                P0400015 = (int?)reader[156];
            }
            if (reader[157] != DBNull.Value)
            {
                P0400016 = (int?)reader[157];
            }
            if (reader[158] != DBNull.Value)
            {
                P0400017 = (int?)reader[158];
            }
            if (reader[159] != DBNull.Value)
            {
                P0400018 = (int?)reader[159];
            }
            if (reader[160] != DBNull.Value)
            {
                P0400019 = (int?)reader[160];
            }
            if (reader[161] != DBNull.Value)
            {
                P0400020 = (int?)reader[161];
            }
            if (reader[162] != DBNull.Value)
            {
                P0410001 = (int?)reader[162];
            }
            if (reader[163] != DBNull.Value)
            {
                P0410002 = (int?)reader[163];
            }
            if (reader[164] != DBNull.Value)
            {
                P0410003 = (int?)reader[164];
            }
            if (reader[165] != DBNull.Value)
            {
                P0410004 = (int?)reader[165];
            }
            if (reader[166] != DBNull.Value)
            {
                P0410005 = (int?)reader[166];
            }
            if (reader[167] != DBNull.Value)
            {
                P0410006 = (int?)reader[167];
            }
            if (reader[168] != DBNull.Value)
            {
                P0420001 = (int?)reader[168];
            }
            if (reader[169] != DBNull.Value)
            {
                P0420002 = (int?)reader[169];
            }
            if (reader[170] != DBNull.Value)
            {
                P0420003 = (int?)reader[170];
            }
            if (reader[171] != DBNull.Value)
            {
                P0420004 = (int?)reader[171];
            }
            if (reader[172] != DBNull.Value)
            {
                P0420005 = (int?)reader[172];
            }
            if (reader[173] != DBNull.Value)
            {
                P0420006 = (int?)reader[173];
            }
            if (reader[174] != DBNull.Value)
            {
                P0420007 = (int?)reader[174];
            }
            if (reader[175] != DBNull.Value)
            {
                P0420008 = (int?)reader[175];
            }
            if (reader[176] != DBNull.Value)
            {
                P0420009 = (int?)reader[176];
            }
            if (reader[177] != DBNull.Value)
            {
                P0420010 = (int?)reader[177];
            }
            if (reader[178] != DBNull.Value)
            {
                P0430001 = (int?)reader[178];
            }
            if (reader[179] != DBNull.Value)
            {
                P0430002 = (int?)reader[179];
            }
            if (reader[180] != DBNull.Value)
            {
                P0430003 = (int?)reader[180];
            }
            if (reader[181] != DBNull.Value)
            {
                P0430004 = (int?)reader[181];
            }
            if (reader[182] != DBNull.Value)
            {
                P0430005 = (int?)reader[182];
            }
            if (reader[183] != DBNull.Value)
            {
                P0430006 = (int?)reader[183];
            }
            if (reader[184] != DBNull.Value)
            {
                P0430007 = (int?)reader[184];
            }
            if (reader[185] != DBNull.Value)
            {
                P0430008 = (int?)reader[185];
            }
            if (reader[186] != DBNull.Value)
            {
                P0430009 = (int?)reader[186];
            }
            if (reader[187] != DBNull.Value)
            {
                P0430010 = (int?)reader[187];
            }
            if (reader[188] != DBNull.Value)
            {
                P0430011 = (int?)reader[188];
            }
            if (reader[189] != DBNull.Value)
            {
                P0430012 = (int?)reader[189];
            }
            if (reader[190] != DBNull.Value)
            {
                P0430013 = (int?)reader[190];
            }
            if (reader[191] != DBNull.Value)
            {
                P0430014 = (int?)reader[191];
            }
            if (reader[192] != DBNull.Value)
            {
                P0430015 = (int?)reader[192];
            }
            if (reader[193] != DBNull.Value)
            {
                P0430016 = (int?)reader[193];
            }
            if (reader[194] != DBNull.Value)
            {
                P0430017 = (int?)reader[194];
            }
            if (reader[195] != DBNull.Value)
            {
                P0430018 = (int?)reader[195];
            }
            if (reader[196] != DBNull.Value)
            {
                P0430019 = (int?)reader[196];
            }
            if (reader[197] != DBNull.Value)
            {
                P0430020 = (int?)reader[197];
            }
            if (reader[198] != DBNull.Value)
            {
                P0430021 = (int?)reader[198];
            }
            if (reader[199] != DBNull.Value)
            {
                P0430022 = (int?)reader[199];
            }
            if (reader[200] != DBNull.Value)
            {
                P0430023 = (int?)reader[200];
            }
            if (reader[201] != DBNull.Value)
            {
                P0430024 = (int?)reader[201];
            }
            if (reader[202] != DBNull.Value)
            {
                P0430025 = (int?)reader[202];
            }
            if (reader[203] != DBNull.Value)
            {
                P0430026 = (int?)reader[203];
            }
            if (reader[204] != DBNull.Value)
            {
                P0430027 = (int?)reader[204];
            }
            if (reader[205] != DBNull.Value)
            {
                P0430028 = (int?)reader[205];
            }
            if (reader[206] != DBNull.Value)
            {
                P0430029 = (int?)reader[206];
            }
            if (reader[207] != DBNull.Value)
            {
                P0430030 = (int?)reader[207];
            }
            if (reader[208] != DBNull.Value)
            {
                P0430031 = (int?)reader[208];
            }
            if (reader[209] != DBNull.Value)
            {
                P0430032 = (int?)reader[209];
            }
            if (reader[210] != DBNull.Value)
            {
                P0430033 = (int?)reader[210];
            }
            if (reader[211] != DBNull.Value)
            {
                P0430034 = (int?)reader[211];
            }
            if (reader[212] != DBNull.Value)
            {
                P0430035 = (int?)reader[212];
            }
            if (reader[213] != DBNull.Value)
            {
                P0430036 = (int?)reader[213];
            }
            if (reader[214] != DBNull.Value)
            {
                P0430037 = (int?)reader[214];
            }
            if (reader[215] != DBNull.Value)
            {
                P0430038 = (int?)reader[215];
            }
            if (reader[216] != DBNull.Value)
            {
                P0430039 = (int?)reader[216];
            }
            if (reader[217] != DBNull.Value)
            {
                P0430040 = (int?)reader[217];
            }
            if (reader[218] != DBNull.Value)
            {
                P0430041 = (int?)reader[218];
            }
            if (reader[219] != DBNull.Value)
            {
                P0430042 = (int?)reader[219];
            }
            if (reader[220] != DBNull.Value)
            {
                P0430043 = (int?)reader[220];
            }
            if (reader[221] != DBNull.Value)
            {
                P0430044 = (int?)reader[221];
            }
            if (reader[222] != DBNull.Value)
            {
                P0430045 = (int?)reader[222];
            }
            if (reader[223] != DBNull.Value)
            {
                P0430046 = (int?)reader[223];
            }
            if (reader[224] != DBNull.Value)
            {
                P0430047 = (int?)reader[224];
            }
            if (reader[225] != DBNull.Value)
            {
                P0430048 = (int?)reader[225];
            }
            if (reader[226] != DBNull.Value)
            {
                P0430049 = (int?)reader[226];
            }
            if (reader[227] != DBNull.Value)
            {
                P0430050 = (int?)reader[227];
            }
            if (reader[228] != DBNull.Value)
            {
                P0430051 = (int?)reader[228];
            }
            if (reader[229] != DBNull.Value)
            {
                P0430052 = (int?)reader[229];
            }
            if (reader[230] != DBNull.Value)
            {
                P0430053 = (int?)reader[230];
            }
            if (reader[231] != DBNull.Value)
            {
                P0430054 = (int?)reader[231];
            }
            if (reader[232] != DBNull.Value)
            {
                P0430055 = (int?)reader[232];
            }
            if (reader[233] != DBNull.Value)
            {
                P0430056 = (int?)reader[233];
            }
            if (reader[234] != DBNull.Value)
            {
                P0430057 = (int?)reader[234];
            }
            if (reader[235] != DBNull.Value)
            {
                P0430058 = (int?)reader[235];
            }
            if (reader[236] != DBNull.Value)
            {
                P0430059 = (int?)reader[236];
            }
            if (reader[237] != DBNull.Value)
            {
                P0430060 = (int?)reader[237];
            }
            if (reader[238] != DBNull.Value)
            {
                P0430061 = (int?)reader[238];
            }
            if (reader[239] != DBNull.Value)
            {
                P0430062 = (int?)reader[239];
            }
            if (reader[240] != DBNull.Value)
            {
                P0430063 = (int?)reader[240];
            }
            if (reader[241] != DBNull.Value)
            {
                P0440001 = (int?)reader[241];
            }
            if (reader[242] != DBNull.Value)
            {
                P0440002 = (int?)reader[242];
            }
            if (reader[243] != DBNull.Value)
            {
                P0440003 = (int?)reader[243];
            }
            if (reader[244] != DBNull.Value)
            {
                P0450001 = (int?)reader[244];
            }
            if (reader[245] != DBNull.Value)
            {
                P0450002 = (int?)reader[245];
            }
            if (reader[246] != DBNull.Value)
            {
                P0450003 = (int?)reader[246];
            }
            if (reader[247] != DBNull.Value)
            {
                P0460001 = (int?)reader[247];
            }
            if (reader[248] != DBNull.Value)
            {
                P0460002 = (int?)reader[248];
            }
            if (reader[249] != DBNull.Value)
            {
                P0460003 = (int?)reader[249];
            }
            if (reader[250] != DBNull.Value)
            {
                P0470001 = (int?)reader[250];
            }
            if (reader[251] != DBNull.Value)
            {
                P0470002 = (int?)reader[251];
            }
            if (reader[252] != DBNull.Value)
            {
                P0470003 = (int?)reader[252];
            }
            if (reader[253] != DBNull.Value)
            {
                P0480001 = (int?)reader[253];
            }
            if (reader[254] != DBNull.Value)
            {
                P0480002 = (int?)reader[254];
            }
            if (reader[255] != DBNull.Value)
            {
                P0480003 = (int?)reader[255];
            }
            if (reader[256] != DBNull.Value)
            {
                P0490001 = (int?)reader[256];
            }
            if (reader[257] != DBNull.Value)
            {
                P0490002 = (int?)reader[257];
            }
            if (reader[258] != DBNull.Value)
            {
                P0490003 = (int?)reader[258];
            }
        }
        #endregion Constructors
    }
}
