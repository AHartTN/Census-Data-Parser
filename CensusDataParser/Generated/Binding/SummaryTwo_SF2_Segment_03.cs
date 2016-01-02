﻿#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2016 11:53 AM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryTwo_SF2_Segment_03.cs
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

    public class SummaryTwo_SF2_Segment_03 : BaseModel
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

        [ReadOnly(false)]
        [Column("CHARITER", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
        public int? CHARITER { get; set; }

        [ReadOnly(false)]
        [Column("CIFSN", Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
        public int? CIFSN { get; set; }

        [ReadOnly(false)]
        [Column("LOGRECNO", Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
        public int? LOGRECNO { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total tribes tallied (300, A01-Z99) & (100-299) or (300, A01-Z99)  or (400-999):", ShortName = "Total tribes tallied (300, A01-Z99) & (100-299) or (300, A01-Z99)  or (400-999):", Order = 5)]
        public int? PCT0030001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian tribes, specified (A01-M38, T01-Z99) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "American Indian tribes, specified (A01-M38, T01-Z99) & (100-299) or (300, A01-Z99) or (400-999):", Order = 6)]
        public int? PCT0030002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Apache (A09-A23) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Apache (A09-A23) & (100-299) or (300, A01-Z99) or (400-999)", Order = 7)]
        public int? PCT0030003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Arapaho (A24-A33) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Arapaho (A24-A33) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 8)]
        public int? PCT0030004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Blackfeet (A45-A50) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Blackfeet (A45-A50) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 9)]
        public int? PCT0030005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Canadian and French American Indian (T01-V23) &  (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Canadian and French American Indian (T01-V23) &  (100-299) or (300, A01-Z99) or (400-999)", Order = 10)]
        public int? PCT0030006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Central American Indian (V24-V83) & (100-299) or  (300, A01-Z99) or (400-999)", ShortName = "Central American Indian (V24-V83) & (100-299) or  (300, A01-Z99) or (400-999)", Order = 11)]
        public int? PCT0030007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Cherokee (B21-B39) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Cherokee (B21-B39) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 12)]
        public int? PCT0030008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Cheyenne (B40-B45) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Cheyenne (B40-B45) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 13)]
        public int? PCT0030009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Chickasaw (B53-B56) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Chickasaw (B53-B56) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 14)]
        public int? PCT0030010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Chippewa (B67-B99) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Chippewa (B67-B99) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 15)]
        public int? PCT0030011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Choctaw (C08-C16) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Choctaw (C08-C16) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 16)]
        public int? PCT0030012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Colville (C35-C38) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Colville (C35-C38) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 17)]
        public int? PCT0030013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Comanche (C39-C43) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Comanche (C39-C43) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 18)]
        public int? PCT0030014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Cree (C59-C63) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Cree (C59-C63) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 19)]
        public int? PCT0030015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Creek (C64-C80) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Creek (C64-C80) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 20)]
        public int? PCT0030016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030017", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Crow (C83-C86) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Crow (C83-C86) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 21)]
        public int? PCT0030017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030018", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Delaware (C93-D04) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Delaware (C93-D04) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 22)]
        public int? PCT0030018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030019", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hopi (D74-D75) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Hopi (D74-D75) & (100-299) or (300, A01-Z99) or (400-999)", Order = 23)]
        public int? PCT0030019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030020", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Houma (D78-D86) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Houma (D78-D86) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 24)]
        public int? PCT0030020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030021", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Iroquois (D93-E09) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Iroquois (D93-E09) & (100-299) or (300, A01-Z99) or (400-999)", Order = 25)]
        public int? PCT0030021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030022", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Kiowa (E30-E36) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Kiowa (E30-E36) & (100-299) or (300, A01-Z99) or (400-999)", Order = 26)]
        public int? PCT0030022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030023", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Lumbee (E78-E83) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Lumbee (E78-E83) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 27)]
        public int? PCT0030023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030024", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Menominee (F11-F14) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Menominee (F11-F14) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 28)]
        public int? PCT0030024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030025", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Mexican American Indian (V84-W66) & (100-299) or  (300, A01-Z99) or (400-999)", ShortName = "Mexican American Indian (V84-W66) & (100-299) or  (300, A01-Z99) or (400-999)", Order = 29)]
        public int? PCT0030025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030026", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Navajo  (F62-F70) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Navajo  (F62-F70) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 30)]
        public int? PCT0030026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030027", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Osage (G04-G09) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Osage (G04-G09) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 31)]
        public int? PCT0030027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030028", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Ottawa (G14-G22) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Ottawa (G14-G22) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 32)]
        public int? PCT0030028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030029", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Paiute (G23-G49) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Paiute (G23-G49) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 33)]
        public int? PCT0030029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030030", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Pima (G84-G91) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Pima (G84-G91) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 34)]
        public int? PCT0030030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030031", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Potawatomi (H21-H33) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Potawatomi (H21-H33) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 35)]
        public int? PCT0030031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030032", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Pueblo (H38-H65) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Pueblo (H38-H65) & (100-299) or (300, A01-Z99) or (400-999)", Order = 36)]
        public int? PCT0030032 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030033", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Puget Sound Salish (H70-H92) & (100-299) or  (300, A01-Z99) or (400-999)", ShortName = "Puget Sound Salish (H70-H92) & (100-299) or  (300, A01-Z99) or (400-999)", Order = 37)]
        public int? PCT0030033 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030034", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Seminole (J47-J57) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Seminole (J47-J57) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 38)]
        public int? PCT0030034 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030035", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Shoshone (J81-J92) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Shoshone (J81-J92) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 39)]
        public int? PCT0030035 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030036", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Sioux (K16-K53) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Sioux (K16-K53) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 40)]
        public int? PCT0030036 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030037", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "South American Indian (W67-X24) & (100-299) or (300, A01-Z99)  or (400-999)", ShortName = "South American Indian (W67-X24) & (100-299) or (300, A01-Z99)  or (400-999)", Order = 41)]
        public int? PCT0030037 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030038", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spanish American Indian (X25-Z99) & (100-299) or  (300, A01-Z99) or (400-999)", ShortName = "Spanish American Indian (X25-Z99) & (100-299) or  (300, A01-Z99) or (400-999)", Order = 42)]
        public int? PCT0030038 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030039", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Tohono O’Odham (K78-K86) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Tohono O’Odham (K78-K86) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 43)]
        public int? PCT0030039 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030040", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Ute (L06-L14) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Ute (L06-L14) & (100-299) or (300, A01-Z99) or (400-999)", Order = 44)]
        public int? PCT0030040 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030041", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Yakama (L79-L84) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Yakama (L79-L84) & (100-299) or (300, A01-Z99) or (400-999)", Order = 45)]
        public int? PCT0030041 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030042", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Yaqui (L91-L99) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Yaqui (L91-L99) & (100-299) or (300, A01-Z99) or (400-999)", Order = 46)]
        public int? PCT0030042 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030043", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Yuman (M22-M33) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Yuman (M22-M33) & (100-299) or (300, A01-Z99) or (400-999)", Order = 47)]
        public int? PCT0030043 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030044", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "All other American Indian tribes (please see technical documentation for codes at http://www.census.gov/prod/cen2010/doc/sf1.pdf, Appendix F)", ShortName = "All other American Indian tribes (please see technical documentation for codes at http://www.census.gov/prod/cen2010/doc/sf1.pdf, Appendix F)", Order = 48)]
        public int? PCT0030044 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030045", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian tribes, not specified (M40-M43) & (100-299)  or (300, A01-Z99) or (400-999)", ShortName = "American Indian tribes, not specified (M40-M43) & (100-299)  or (300, A01-Z99) or (400-999)", Order = 49)]
        public int? PCT0030045 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030046", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Alaska Native tribes, specified (M52-R98, S01-S99) & (100-299)  or (300, A01-Z99) or (400-999):", ShortName = "Alaska Native tribes, specified (M52-R98, S01-S99) & (100-299)  or (300, A01-Z99) or (400-999):", Order = 50)]
        public int? PCT0030046 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030047", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Alaskan Athabascan (M52-N27) & (100-299) or (300, A01-Z99)  or (400-999)", ShortName = "Alaskan Athabascan (M52-N27) & (100-299) or (300, A01-Z99)  or (400-999)", Order = 51)]
        public int? PCT0030047 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030048", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Aleut (R11-R98, S01-S99) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Aleut (R11-R98, S01-S99) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 52)]
        public int? PCT0030048 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030049", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Inupiat (N67-P29, P33-P37) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Inupiat (N67-P29, P33-P37) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 53)]
        public int? PCT0030049 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030050", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Tlingit-Haida (N28-N55, N59-N66) & (100-299) or  (300, A01-Z99) or (400-999)", ShortName = "Tlingit-Haida (N28-N55, N59-N66) & (100-299) or  (300, A01-Z99) or (400-999)", Order = 54)]
        public int? PCT0030050 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030051", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Tsimshian (N56-N58) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Tsimshian (N56-N58) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 55)]
        public int? PCT0030051 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030052", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Yup'ik (P30-P32, P38-R10) & (100-299) or (300, A01-Z99)  or (400-999)", ShortName = "Yup'ik (P30-P32, P38-R10) & (100-299) or (300, A01-Z99)  or (400-999)", Order = 56)]
        public int? PCT0030052 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030053", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Alaska Native tribes, not specified (M44-M51, R99) & (100-299) or  (300, A01-Z99) or (400-999)", ShortName = "Alaska Native tribes, not specified (M44-M51, R99) & (100-299) or  (300, A01-Z99) or (400-999)", Order = 57)]
        public int? PCT0030053 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030054", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian or Alaska Native tribes, not specified (M39),  (300) & (100-299) or (400-999)", ShortName = "American Indian or Alaska Native tribes, not specified (M39),  (300) & (100-299) or (400-999)", Order = 58)]
        public int? PCT0030054 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030055", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "52 years", ShortName = "52 years", Order = 59)]
        public int? PCT0030055 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030056", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "53 years", ShortName = "53 years", Order = 60)]
        public int? PCT0030056 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030057", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "54 years", ShortName = "54 years", Order = 61)]
        public int? PCT0030057 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030058", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 years", ShortName = "55 years", Order = 62)]
        public int? PCT0030058 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030059", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "56 years", ShortName = "56 years", Order = 63)]
        public int? PCT0030059 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030060", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "57 years", ShortName = "57 years", Order = 64)]
        public int? PCT0030060 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030061", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "58 years", ShortName = "58 years", Order = 65)]
        public int? PCT0030061 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030062", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "59 years", ShortName = "59 years", Order = 66)]
        public int? PCT0030062 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030063", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 years", ShortName = "60 years", Order = 67)]
        public int? PCT0030063 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030064", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "61 years", ShortName = "61 years", Order = 68)]
        public int? PCT0030064 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030065", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 years", ShortName = "62 years", Order = 69)]
        public int? PCT0030065 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030066", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "63 years", ShortName = "63 years", Order = 70)]
        public int? PCT0030066 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030067", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "64 years", ShortName = "64 years", Order = 71)]
        public int? PCT0030067 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030068", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 years", ShortName = "65 years", Order = 72)]
        public int? PCT0030068 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030069", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "66 years", ShortName = "66 years", Order = 73)]
        public int? PCT0030069 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030070", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 years", ShortName = "67 years", Order = 74)]
        public int? PCT0030070 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030071", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "68 years", ShortName = "68 years", Order = 75)]
        public int? PCT0030071 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030072", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "69 years", ShortName = "69 years", Order = 76)]
        public int? PCT0030072 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030073", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 years", ShortName = "70 years", Order = 77)]
        public int? PCT0030073 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030074", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "71 years", ShortName = "71 years", Order = 78)]
        public int? PCT0030074 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030075", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "72 years", ShortName = "72 years", Order = 79)]
        public int? PCT0030075 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030076", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "73 years", ShortName = "73 years", Order = 80)]
        public int? PCT0030076 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030077", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "74 years", ShortName = "74 years", Order = 81)]
        public int? PCT0030077 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030078", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 years", ShortName = "75 years", Order = 82)]
        public int? PCT0030078 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030079", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "76 years", ShortName = "76 years", Order = 83)]
        public int? PCT0030079 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030080", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "77 years", ShortName = "77 years", Order = 84)]
        public int? PCT0030080 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030081", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "78 years", ShortName = "78 years", Order = 85)]
        public int? PCT0030081 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030082", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "79 years", ShortName = "79 years", Order = 86)]
        public int? PCT0030082 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030083", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 years", ShortName = "80 years", Order = 87)]
        public int? PCT0030083 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030084", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "81 years", ShortName = "81 years", Order = 88)]
        public int? PCT0030084 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030085", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "82 years", ShortName = "82 years", Order = 89)]
        public int? PCT0030085 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030086", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "83 years", ShortName = "83 years", Order = 90)]
        public int? PCT0030086 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030087", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "84 years", ShortName = "84 years", Order = 91)]
        public int? PCT0030087 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030088", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years", ShortName = "85 years", Order = 92)]
        public int? PCT0030088 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030089", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "86 years", ShortName = "86 years", Order = 93)]
        public int? PCT0030089 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030090", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "87 years", ShortName = "87 years", Order = 94)]
        public int? PCT0030090 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030091", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "88 years", ShortName = "88 years", Order = 95)]
        public int? PCT0030091 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030092", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "89 years", ShortName = "89 years", Order = 96)]
        public int? PCT0030092 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030093", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "90 years", ShortName = "90 years", Order = 97)]
        public int? PCT0030093 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030094", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "91 years", ShortName = "91 years", Order = 98)]
        public int? PCT0030094 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030095", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "92 years", ShortName = "92 years", Order = 99)]
        public int? PCT0030095 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030096", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "93 years", ShortName = "93 years", Order = 100)]
        public int? PCT0030096 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030097", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "94 years", ShortName = "94 years", Order = 101)]
        public int? PCT0030097 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030098", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "95 years", ShortName = "95 years", Order = 102)]
        public int? PCT0030098 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030099", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "96 years", ShortName = "96 years", Order = 103)]
        public int? PCT0030099 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030100", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "97 years", ShortName = "97 years", Order = 104)]
        public int? PCT0030100 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030101", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "98 years", ShortName = "98 years", Order = 105)]
        public int? PCT0030101 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030102", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "99 years", ShortName = "99 years", Order = 106)]
        public int? PCT0030102 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030103", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "100 to 104 years", ShortName = "100 to 104 years", Order = 107)]
        public int? PCT0030103 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030104", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "105 to 109 years", ShortName = "105 to 109 years", Order = 108)]
        public int? PCT0030104 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030105", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "110 years and over", ShortName = "110 years and over", Order = 109)]
        public int? PCT0030105 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030106", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 110)]
        public int? PCT0030106 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030107", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 1 year", ShortName = "Under 1 year", Order = 111)]
        public int? PCT0030107 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030108", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1 year", ShortName = "1 year", Order = 112)]
        public int? PCT0030108 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030109", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2 years", ShortName = "2 years", Order = 113)]
        public int? PCT0030109 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030110", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 years", ShortName = "3 years", Order = 114)]
        public int? PCT0030110 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030111", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4 years", ShortName = "4 years", Order = 115)]
        public int? PCT0030111 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030112", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 116)]
        public int? PCT0030112 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030113", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 years", ShortName = "6 years", Order = 117)]
        public int? PCT0030113 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030114", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7 years", ShortName = "7 years", Order = 118)]
        public int? PCT0030114 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030115", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "8 years", ShortName = "8 years", Order = 119)]
        public int? PCT0030115 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030116", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "9 years", ShortName = "9 years", Order = 120)]
        public int? PCT0030116 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030117", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 years", ShortName = "10 years", Order = 121)]
        public int? PCT0030117 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030118", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "11 years", ShortName = "11 years", Order = 122)]
        public int? PCT0030118 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030119", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 years", ShortName = "12 years", Order = 123)]
        public int? PCT0030119 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030120", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "13 years", ShortName = "13 years", Order = 124)]
        public int? PCT0030120 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030121", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "14 years", ShortName = "14 years", Order = 125)]
        public int? PCT0030121 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030122", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 years", ShortName = "15 years", Order = 126)]
        public int? PCT0030122 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030123", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "16 years", ShortName = "16 years", Order = 127)]
        public int? PCT0030123 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030124", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "17 years", ShortName = "17 years", Order = 128)]
        public int? PCT0030124 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030125", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years", ShortName = "18 years", Order = 129)]
        public int? PCT0030125 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030126", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "19 years", ShortName = "19 years", Order = 130)]
        public int? PCT0030126 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030127", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 131)]
        public int? PCT0030127 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030128", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 132)]
        public int? PCT0030128 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030129", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 years", ShortName = "22 years", Order = 133)]
        public int? PCT0030129 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030130", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "23 years", ShortName = "23 years", Order = 134)]
        public int? PCT0030130 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030131", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "24 years", ShortName = "24 years", Order = 135)]
        public int? PCT0030131 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030132", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 years", ShortName = "25 years", Order = 136)]
        public int? PCT0030132 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030133", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "26 years", ShortName = "26 years", Order = 137)]
        public int? PCT0030133 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030134", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "27 years", ShortName = "27 years", Order = 138)]
        public int? PCT0030134 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030135", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "28 years", ShortName = "28 years", Order = 139)]
        public int? PCT0030135 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030136", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "29 years", ShortName = "29 years", Order = 140)]
        public int? PCT0030136 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030137", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 years", ShortName = "30 years", Order = 141)]
        public int? PCT0030137 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030138", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "31 years", ShortName = "31 years", Order = 142)]
        public int? PCT0030138 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030139", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "32 years", ShortName = "32 years", Order = 143)]
        public int? PCT0030139 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030140", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "33 years", ShortName = "33 years", Order = 144)]
        public int? PCT0030140 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030141", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "34 years", ShortName = "34 years", Order = 145)]
        public int? PCT0030141 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030142", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 years", ShortName = "35 years", Order = 146)]
        public int? PCT0030142 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030143", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "36 years", ShortName = "36 years", Order = 147)]
        public int? PCT0030143 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030144", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "37 years", ShortName = "37 years", Order = 148)]
        public int? PCT0030144 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030145", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "38 years", ShortName = "38 years", Order = 149)]
        public int? PCT0030145 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030146", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "39 years", ShortName = "39 years", Order = 150)]
        public int? PCT0030146 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030147", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 years", ShortName = "40 years", Order = 151)]
        public int? PCT0030147 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030148", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "41 years", ShortName = "41 years", Order = 152)]
        public int? PCT0030148 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030149", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "42 years", ShortName = "42 years", Order = 153)]
        public int? PCT0030149 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030150", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "43 years", ShortName = "43 years", Order = 154)]
        public int? PCT0030150 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030151", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "44 years", ShortName = "44 years", Order = 155)]
        public int? PCT0030151 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030152", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 years", ShortName = "45 years", Order = 156)]
        public int? PCT0030152 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030153", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "46 years", ShortName = "46 years", Order = 157)]
        public int? PCT0030153 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030154", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "47 years", ShortName = "47 years", Order = 158)]
        public int? PCT0030154 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030155", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "48 years", ShortName = "48 years", Order = 159)]
        public int? PCT0030155 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030156", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "49 years", ShortName = "49 years", Order = 160)]
        public int? PCT0030156 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030157", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 years", ShortName = "50 years", Order = 161)]
        public int? PCT0030157 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030158", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "51 years", ShortName = "51 years", Order = 162)]
        public int? PCT0030158 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030159", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "52 years", ShortName = "52 years", Order = 163)]
        public int? PCT0030159 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030160", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "53 years", ShortName = "53 years", Order = 164)]
        public int? PCT0030160 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030161", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "54 years", ShortName = "54 years", Order = 165)]
        public int? PCT0030161 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030162", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 years", ShortName = "55 years", Order = 166)]
        public int? PCT0030162 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030163", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "56 years", ShortName = "56 years", Order = 167)]
        public int? PCT0030163 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030164", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "57 years", ShortName = "57 years", Order = 168)]
        public int? PCT0030164 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030165", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "58 years", ShortName = "58 years", Order = 169)]
        public int? PCT0030165 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030166", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "59 years", ShortName = "59 years", Order = 170)]
        public int? PCT0030166 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030167", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 years", ShortName = "60 years", Order = 171)]
        public int? PCT0030167 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030168", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "61 years", ShortName = "61 years", Order = 172)]
        public int? PCT0030168 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030169", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 years", ShortName = "62 years", Order = 173)]
        public int? PCT0030169 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030170", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "63 years", ShortName = "63 years", Order = 174)]
        public int? PCT0030170 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030171", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "64 years", ShortName = "64 years", Order = 175)]
        public int? PCT0030171 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030172", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 years", ShortName = "65 years", Order = 176)]
        public int? PCT0030172 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030173", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "66 years", ShortName = "66 years", Order = 177)]
        public int? PCT0030173 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030174", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 years", ShortName = "67 years", Order = 178)]
        public int? PCT0030174 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030175", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "68 years", ShortName = "68 years", Order = 179)]
        public int? PCT0030175 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030176", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "69 years", ShortName = "69 years", Order = 180)]
        public int? PCT0030176 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030177", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 years", ShortName = "70 years", Order = 181)]
        public int? PCT0030177 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030178", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "71 years", ShortName = "71 years", Order = 182)]
        public int? PCT0030178 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030179", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "72 years", ShortName = "72 years", Order = 183)]
        public int? PCT0030179 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030180", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "73 years", ShortName = "73 years", Order = 184)]
        public int? PCT0030180 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030181", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "74 years", ShortName = "74 years", Order = 185)]
        public int? PCT0030181 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030182", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 years", ShortName = "75 years", Order = 186)]
        public int? PCT0030182 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030183", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "76 years", ShortName = "76 years", Order = 187)]
        public int? PCT0030183 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030184", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "77 years", ShortName = "77 years", Order = 188)]
        public int? PCT0030184 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030185", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "78 years", ShortName = "78 years", Order = 189)]
        public int? PCT0030185 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030186", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "79 years", ShortName = "79 years", Order = 190)]
        public int? PCT0030186 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030187", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 years", ShortName = "80 years", Order = 191)]
        public int? PCT0030187 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030188", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "81 years", ShortName = "81 years", Order = 192)]
        public int? PCT0030188 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030189", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "82 years", ShortName = "82 years", Order = 193)]
        public int? PCT0030189 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030190", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "83 years", ShortName = "83 years", Order = 194)]
        public int? PCT0030190 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030191", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "84 years", ShortName = "84 years", Order = 195)]
        public int? PCT0030191 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030192", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years", ShortName = "85 years", Order = 196)]
        public int? PCT0030192 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030193", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "86 years", ShortName = "86 years", Order = 197)]
        public int? PCT0030193 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030194", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "87 years", ShortName = "87 years", Order = 198)]
        public int? PCT0030194 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030195", Order = 199)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "88 years", ShortName = "88 years", Order = 199)]
        public int? PCT0030195 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030196", Order = 200)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "89 years", ShortName = "89 years", Order = 200)]
        public int? PCT0030196 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030197", Order = 201)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "90 years", ShortName = "90 years", Order = 201)]
        public int? PCT0030197 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030198", Order = 202)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "91 years", ShortName = "91 years", Order = 202)]
        public int? PCT0030198 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030199", Order = 203)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "92 years", ShortName = "92 years", Order = 203)]
        public int? PCT0030199 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030200", Order = 204)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "93 years", ShortName = "93 years", Order = 204)]
        public int? PCT0030200 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030201", Order = 205)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "94 years", ShortName = "94 years", Order = 205)]
        public int? PCT0030201 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030202", Order = 206)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "95 years", ShortName = "95 years", Order = 206)]
        public int? PCT0030202 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030203", Order = 207)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "96 years", ShortName = "96 years", Order = 207)]
        public int? PCT0030203 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030204", Order = 208)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "97 years", ShortName = "97 years", Order = 208)]
        public int? PCT0030204 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030205", Order = 209)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "98 years", ShortName = "98 years", Order = 209)]
        public int? PCT0030205 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030206", Order = 210)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "99 years", ShortName = "99 years", Order = 210)]
        public int? PCT0030206 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030207", Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "100 to 104 years", ShortName = "100 to 104 years", Order = 211)]
        public int? PCT0030207 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030208", Order = 212)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "105 to 109 years", ShortName = "105 to 109 years", Order = 212)]
        public int? PCT0030208 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0030209", Order = 213)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "110 years and over", ShortName = "110 years and over", Order = 213)]
        public int? PCT0030209 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0040001", Order = 214)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 214)]
        public double? PCT0040001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0040002", Order = 215)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian alone (People who reported a specific American Indian tribe only) (A01-M38, T01-Z99)", ShortName = "American Indian alone (People who reported a specific American Indian tribe only) (A01-M38, T01-Z99)", Order = 215)]
        public double? PCT0040002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0040003", Order = 216)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Alaska Native alone (People who reported a specific Alaska Native tribe only) (M52-R98)", ShortName = "Alaska Native alone (People who reported a specific Alaska Native tribe only) (M52-R98)", Order = 216)]
        public double? PCT0040003 { get; set; }
        #endregion Properties

        #region Constructors
        public SummaryTwo_SF2_Segment_03(string csvLine) : base(csvLine) { }

        public SummaryTwo_SF2_Segment_03(string[] values) : base(values) { }

        public SummaryTwo_SF2_Segment_03(OleDbDataReader reader, CensusFileType fileType)
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
                CHARITER = (int?)reader[2];
            }
            if (reader[3] != DBNull.Value)
            {
                CIFSN = (int?)reader[3];
            }
            if (reader[4] != DBNull.Value)
            {
                LOGRECNO = (int?)reader[4];
            }
            if (reader[5] != DBNull.Value)
            {
                PCT0030001 = (int?)reader[5];
            }
            if (reader[6] != DBNull.Value)
            {
                PCT0030002 = (int?)reader[6];
            }
            if (reader[7] != DBNull.Value)
            {
                PCT0030003 = (int?)reader[7];
            }
            if (reader[8] != DBNull.Value)
            {
                PCT0030004 = (int?)reader[8];
            }
            if (reader[9] != DBNull.Value)
            {
                PCT0030005 = (int?)reader[9];
            }
            if (reader[10] != DBNull.Value)
            {
                PCT0030006 = (int?)reader[10];
            }
            if (reader[11] != DBNull.Value)
            {
                PCT0030007 = (int?)reader[11];
            }
            if (reader[12] != DBNull.Value)
            {
                PCT0030008 = (int?)reader[12];
            }
            if (reader[13] != DBNull.Value)
            {
                PCT0030009 = (int?)reader[13];
            }
            if (reader[14] != DBNull.Value)
            {
                PCT0030010 = (int?)reader[14];
            }
            if (reader[15] != DBNull.Value)
            {
                PCT0030011 = (int?)reader[15];
            }
            if (reader[16] != DBNull.Value)
            {
                PCT0030012 = (int?)reader[16];
            }
            if (reader[17] != DBNull.Value)
            {
                PCT0030013 = (int?)reader[17];
            }
            if (reader[18] != DBNull.Value)
            {
                PCT0030014 = (int?)reader[18];
            }
            if (reader[19] != DBNull.Value)
            {
                PCT0030015 = (int?)reader[19];
            }
            if (reader[20] != DBNull.Value)
            {
                PCT0030016 = (int?)reader[20];
            }
            if (reader[21] != DBNull.Value)
            {
                PCT0030017 = (int?)reader[21];
            }
            if (reader[22] != DBNull.Value)
            {
                PCT0030018 = (int?)reader[22];
            }
            if (reader[23] != DBNull.Value)
            {
                PCT0030019 = (int?)reader[23];
            }
            if (reader[24] != DBNull.Value)
            {
                PCT0030020 = (int?)reader[24];
            }
            if (reader[25] != DBNull.Value)
            {
                PCT0030021 = (int?)reader[25];
            }
            if (reader[26] != DBNull.Value)
            {
                PCT0030022 = (int?)reader[26];
            }
            if (reader[27] != DBNull.Value)
            {
                PCT0030023 = (int?)reader[27];
            }
            if (reader[28] != DBNull.Value)
            {
                PCT0030024 = (int?)reader[28];
            }
            if (reader[29] != DBNull.Value)
            {
                PCT0030025 = (int?)reader[29];
            }
            if (reader[30] != DBNull.Value)
            {
                PCT0030026 = (int?)reader[30];
            }
            if (reader[31] != DBNull.Value)
            {
                PCT0030027 = (int?)reader[31];
            }
            if (reader[32] != DBNull.Value)
            {
                PCT0030028 = (int?)reader[32];
            }
            if (reader[33] != DBNull.Value)
            {
                PCT0030029 = (int?)reader[33];
            }
            if (reader[34] != DBNull.Value)
            {
                PCT0030030 = (int?)reader[34];
            }
            if (reader[35] != DBNull.Value)
            {
                PCT0030031 = (int?)reader[35];
            }
            if (reader[36] != DBNull.Value)
            {
                PCT0030032 = (int?)reader[36];
            }
            if (reader[37] != DBNull.Value)
            {
                PCT0030033 = (int?)reader[37];
            }
            if (reader[38] != DBNull.Value)
            {
                PCT0030034 = (int?)reader[38];
            }
            if (reader[39] != DBNull.Value)
            {
                PCT0030035 = (int?)reader[39];
            }
            if (reader[40] != DBNull.Value)
            {
                PCT0030036 = (int?)reader[40];
            }
            if (reader[41] != DBNull.Value)
            {
                PCT0030037 = (int?)reader[41];
            }
            if (reader[42] != DBNull.Value)
            {
                PCT0030038 = (int?)reader[42];
            }
            if (reader[43] != DBNull.Value)
            {
                PCT0030039 = (int?)reader[43];
            }
            if (reader[44] != DBNull.Value)
            {
                PCT0030040 = (int?)reader[44];
            }
            if (reader[45] != DBNull.Value)
            {
                PCT0030041 = (int?)reader[45];
            }
            if (reader[46] != DBNull.Value)
            {
                PCT0030042 = (int?)reader[46];
            }
            if (reader[47] != DBNull.Value)
            {
                PCT0030043 = (int?)reader[47];
            }
            if (reader[48] != DBNull.Value)
            {
                PCT0030044 = (int?)reader[48];
            }
            if (reader[49] != DBNull.Value)
            {
                PCT0030045 = (int?)reader[49];
            }
            if (reader[50] != DBNull.Value)
            {
                PCT0030046 = (int?)reader[50];
            }
            if (reader[51] != DBNull.Value)
            {
                PCT0030047 = (int?)reader[51];
            }
            if (reader[52] != DBNull.Value)
            {
                PCT0030048 = (int?)reader[52];
            }
            if (reader[53] != DBNull.Value)
            {
                PCT0030049 = (int?)reader[53];
            }
            if (reader[54] != DBNull.Value)
            {
                PCT0030050 = (int?)reader[54];
            }
            if (reader[55] != DBNull.Value)
            {
                PCT0030051 = (int?)reader[55];
            }
            if (reader[56] != DBNull.Value)
            {
                PCT0030052 = (int?)reader[56];
            }
            if (reader[57] != DBNull.Value)
            {
                PCT0030053 = (int?)reader[57];
            }
            if (reader[58] != DBNull.Value)
            {
                PCT0030054 = (int?)reader[58];
            }
            if (reader[59] != DBNull.Value)
            {
                PCT0030055 = (int?)reader[59];
            }
            if (reader[60] != DBNull.Value)
            {
                PCT0030056 = (int?)reader[60];
            }
            if (reader[61] != DBNull.Value)
            {
                PCT0030057 = (int?)reader[61];
            }
            if (reader[62] != DBNull.Value)
            {
                PCT0030058 = (int?)reader[62];
            }
            if (reader[63] != DBNull.Value)
            {
                PCT0030059 = (int?)reader[63];
            }
            if (reader[64] != DBNull.Value)
            {
                PCT0030060 = (int?)reader[64];
            }
            if (reader[65] != DBNull.Value)
            {
                PCT0030061 = (int?)reader[65];
            }
            if (reader[66] != DBNull.Value)
            {
                PCT0030062 = (int?)reader[66];
            }
            if (reader[67] != DBNull.Value)
            {
                PCT0030063 = (int?)reader[67];
            }
            if (reader[68] != DBNull.Value)
            {
                PCT0030064 = (int?)reader[68];
            }
            if (reader[69] != DBNull.Value)
            {
                PCT0030065 = (int?)reader[69];
            }
            if (reader[70] != DBNull.Value)
            {
                PCT0030066 = (int?)reader[70];
            }
            if (reader[71] != DBNull.Value)
            {
                PCT0030067 = (int?)reader[71];
            }
            if (reader[72] != DBNull.Value)
            {
                PCT0030068 = (int?)reader[72];
            }
            if (reader[73] != DBNull.Value)
            {
                PCT0030069 = (int?)reader[73];
            }
            if (reader[74] != DBNull.Value)
            {
                PCT0030070 = (int?)reader[74];
            }
            if (reader[75] != DBNull.Value)
            {
                PCT0030071 = (int?)reader[75];
            }
            if (reader[76] != DBNull.Value)
            {
                PCT0030072 = (int?)reader[76];
            }
            if (reader[77] != DBNull.Value)
            {
                PCT0030073 = (int?)reader[77];
            }
            if (reader[78] != DBNull.Value)
            {
                PCT0030074 = (int?)reader[78];
            }
            if (reader[79] != DBNull.Value)
            {
                PCT0030075 = (int?)reader[79];
            }
            if (reader[80] != DBNull.Value)
            {
                PCT0030076 = (int?)reader[80];
            }
            if (reader[81] != DBNull.Value)
            {
                PCT0030077 = (int?)reader[81];
            }
            if (reader[82] != DBNull.Value)
            {
                PCT0030078 = (int?)reader[82];
            }
            if (reader[83] != DBNull.Value)
            {
                PCT0030079 = (int?)reader[83];
            }
            if (reader[84] != DBNull.Value)
            {
                PCT0030080 = (int?)reader[84];
            }
            if (reader[85] != DBNull.Value)
            {
                PCT0030081 = (int?)reader[85];
            }
            if (reader[86] != DBNull.Value)
            {
                PCT0030082 = (int?)reader[86];
            }
            if (reader[87] != DBNull.Value)
            {
                PCT0030083 = (int?)reader[87];
            }
            if (reader[88] != DBNull.Value)
            {
                PCT0030084 = (int?)reader[88];
            }
            if (reader[89] != DBNull.Value)
            {
                PCT0030085 = (int?)reader[89];
            }
            if (reader[90] != DBNull.Value)
            {
                PCT0030086 = (int?)reader[90];
            }
            if (reader[91] != DBNull.Value)
            {
                PCT0030087 = (int?)reader[91];
            }
            if (reader[92] != DBNull.Value)
            {
                PCT0030088 = (int?)reader[92];
            }
            if (reader[93] != DBNull.Value)
            {
                PCT0030089 = (int?)reader[93];
            }
            if (reader[94] != DBNull.Value)
            {
                PCT0030090 = (int?)reader[94];
            }
            if (reader[95] != DBNull.Value)
            {
                PCT0030091 = (int?)reader[95];
            }
            if (reader[96] != DBNull.Value)
            {
                PCT0030092 = (int?)reader[96];
            }
            if (reader[97] != DBNull.Value)
            {
                PCT0030093 = (int?)reader[97];
            }
            if (reader[98] != DBNull.Value)
            {
                PCT0030094 = (int?)reader[98];
            }
            if (reader[99] != DBNull.Value)
            {
                PCT0030095 = (int?)reader[99];
            }
            if (reader[100] != DBNull.Value)
            {
                PCT0030096 = (int?)reader[100];
            }
            if (reader[101] != DBNull.Value)
            {
                PCT0030097 = (int?)reader[101];
            }
            if (reader[102] != DBNull.Value)
            {
                PCT0030098 = (int?)reader[102];
            }
            if (reader[103] != DBNull.Value)
            {
                PCT0030099 = (int?)reader[103];
            }
            if (reader[104] != DBNull.Value)
            {
                PCT0030100 = (int?)reader[104];
            }
            if (reader[105] != DBNull.Value)
            {
                PCT0030101 = (int?)reader[105];
            }
            if (reader[106] != DBNull.Value)
            {
                PCT0030102 = (int?)reader[106];
            }
            if (reader[107] != DBNull.Value)
            {
                PCT0030103 = (int?)reader[107];
            }
            if (reader[108] != DBNull.Value)
            {
                PCT0030104 = (int?)reader[108];
            }
            if (reader[109] != DBNull.Value)
            {
                PCT0030105 = (int?)reader[109];
            }
            if (reader[110] != DBNull.Value)
            {
                PCT0030106 = (int?)reader[110];
            }
            if (reader[111] != DBNull.Value)
            {
                PCT0030107 = (int?)reader[111];
            }
            if (reader[112] != DBNull.Value)
            {
                PCT0030108 = (int?)reader[112];
            }
            if (reader[113] != DBNull.Value)
            {
                PCT0030109 = (int?)reader[113];
            }
            if (reader[114] != DBNull.Value)
            {
                PCT0030110 = (int?)reader[114];
            }
            if (reader[115] != DBNull.Value)
            {
                PCT0030111 = (int?)reader[115];
            }
            if (reader[116] != DBNull.Value)
            {
                PCT0030112 = (int?)reader[116];
            }
            if (reader[117] != DBNull.Value)
            {
                PCT0030113 = (int?)reader[117];
            }
            if (reader[118] != DBNull.Value)
            {
                PCT0030114 = (int?)reader[118];
            }
            if (reader[119] != DBNull.Value)
            {
                PCT0030115 = (int?)reader[119];
            }
            if (reader[120] != DBNull.Value)
            {
                PCT0030116 = (int?)reader[120];
            }
            if (reader[121] != DBNull.Value)
            {
                PCT0030117 = (int?)reader[121];
            }
            if (reader[122] != DBNull.Value)
            {
                PCT0030118 = (int?)reader[122];
            }
            if (reader[123] != DBNull.Value)
            {
                PCT0030119 = (int?)reader[123];
            }
            if (reader[124] != DBNull.Value)
            {
                PCT0030120 = (int?)reader[124];
            }
            if (reader[125] != DBNull.Value)
            {
                PCT0030121 = (int?)reader[125];
            }
            if (reader[126] != DBNull.Value)
            {
                PCT0030122 = (int?)reader[126];
            }
            if (reader[127] != DBNull.Value)
            {
                PCT0030123 = (int?)reader[127];
            }
            if (reader[128] != DBNull.Value)
            {
                PCT0030124 = (int?)reader[128];
            }
            if (reader[129] != DBNull.Value)
            {
                PCT0030125 = (int?)reader[129];
            }
            if (reader[130] != DBNull.Value)
            {
                PCT0030126 = (int?)reader[130];
            }
            if (reader[131] != DBNull.Value)
            {
                PCT0030127 = (int?)reader[131];
            }
            if (reader[132] != DBNull.Value)
            {
                PCT0030128 = (int?)reader[132];
            }
            if (reader[133] != DBNull.Value)
            {
                PCT0030129 = (int?)reader[133];
            }
            if (reader[134] != DBNull.Value)
            {
                PCT0030130 = (int?)reader[134];
            }
            if (reader[135] != DBNull.Value)
            {
                PCT0030131 = (int?)reader[135];
            }
            if (reader[136] != DBNull.Value)
            {
                PCT0030132 = (int?)reader[136];
            }
            if (reader[137] != DBNull.Value)
            {
                PCT0030133 = (int?)reader[137];
            }
            if (reader[138] != DBNull.Value)
            {
                PCT0030134 = (int?)reader[138];
            }
            if (reader[139] != DBNull.Value)
            {
                PCT0030135 = (int?)reader[139];
            }
            if (reader[140] != DBNull.Value)
            {
                PCT0030136 = (int?)reader[140];
            }
            if (reader[141] != DBNull.Value)
            {
                PCT0030137 = (int?)reader[141];
            }
            if (reader[142] != DBNull.Value)
            {
                PCT0030138 = (int?)reader[142];
            }
            if (reader[143] != DBNull.Value)
            {
                PCT0030139 = (int?)reader[143];
            }
            if (reader[144] != DBNull.Value)
            {
                PCT0030140 = (int?)reader[144];
            }
            if (reader[145] != DBNull.Value)
            {
                PCT0030141 = (int?)reader[145];
            }
            if (reader[146] != DBNull.Value)
            {
                PCT0030142 = (int?)reader[146];
            }
            if (reader[147] != DBNull.Value)
            {
                PCT0030143 = (int?)reader[147];
            }
            if (reader[148] != DBNull.Value)
            {
                PCT0030144 = (int?)reader[148];
            }
            if (reader[149] != DBNull.Value)
            {
                PCT0030145 = (int?)reader[149];
            }
            if (reader[150] != DBNull.Value)
            {
                PCT0030146 = (int?)reader[150];
            }
            if (reader[151] != DBNull.Value)
            {
                PCT0030147 = (int?)reader[151];
            }
            if (reader[152] != DBNull.Value)
            {
                PCT0030148 = (int?)reader[152];
            }
            if (reader[153] != DBNull.Value)
            {
                PCT0030149 = (int?)reader[153];
            }
            if (reader[154] != DBNull.Value)
            {
                PCT0030150 = (int?)reader[154];
            }
            if (reader[155] != DBNull.Value)
            {
                PCT0030151 = (int?)reader[155];
            }
            if (reader[156] != DBNull.Value)
            {
                PCT0030152 = (int?)reader[156];
            }
            if (reader[157] != DBNull.Value)
            {
                PCT0030153 = (int?)reader[157];
            }
            if (reader[158] != DBNull.Value)
            {
                PCT0030154 = (int?)reader[158];
            }
            if (reader[159] != DBNull.Value)
            {
                PCT0030155 = (int?)reader[159];
            }
            if (reader[160] != DBNull.Value)
            {
                PCT0030156 = (int?)reader[160];
            }
            if (reader[161] != DBNull.Value)
            {
                PCT0030157 = (int?)reader[161];
            }
            if (reader[162] != DBNull.Value)
            {
                PCT0030158 = (int?)reader[162];
            }
            if (reader[163] != DBNull.Value)
            {
                PCT0030159 = (int?)reader[163];
            }
            if (reader[164] != DBNull.Value)
            {
                PCT0030160 = (int?)reader[164];
            }
            if (reader[165] != DBNull.Value)
            {
                PCT0030161 = (int?)reader[165];
            }
            if (reader[166] != DBNull.Value)
            {
                PCT0030162 = (int?)reader[166];
            }
            if (reader[167] != DBNull.Value)
            {
                PCT0030163 = (int?)reader[167];
            }
            if (reader[168] != DBNull.Value)
            {
                PCT0030164 = (int?)reader[168];
            }
            if (reader[169] != DBNull.Value)
            {
                PCT0030165 = (int?)reader[169];
            }
            if (reader[170] != DBNull.Value)
            {
                PCT0030166 = (int?)reader[170];
            }
            if (reader[171] != DBNull.Value)
            {
                PCT0030167 = (int?)reader[171];
            }
            if (reader[172] != DBNull.Value)
            {
                PCT0030168 = (int?)reader[172];
            }
            if (reader[173] != DBNull.Value)
            {
                PCT0030169 = (int?)reader[173];
            }
            if (reader[174] != DBNull.Value)
            {
                PCT0030170 = (int?)reader[174];
            }
            if (reader[175] != DBNull.Value)
            {
                PCT0030171 = (int?)reader[175];
            }
            if (reader[176] != DBNull.Value)
            {
                PCT0030172 = (int?)reader[176];
            }
            if (reader[177] != DBNull.Value)
            {
                PCT0030173 = (int?)reader[177];
            }
            if (reader[178] != DBNull.Value)
            {
                PCT0030174 = (int?)reader[178];
            }
            if (reader[179] != DBNull.Value)
            {
                PCT0030175 = (int?)reader[179];
            }
            if (reader[180] != DBNull.Value)
            {
                PCT0030176 = (int?)reader[180];
            }
            if (reader[181] != DBNull.Value)
            {
                PCT0030177 = (int?)reader[181];
            }
            if (reader[182] != DBNull.Value)
            {
                PCT0030178 = (int?)reader[182];
            }
            if (reader[183] != DBNull.Value)
            {
                PCT0030179 = (int?)reader[183];
            }
            if (reader[184] != DBNull.Value)
            {
                PCT0030180 = (int?)reader[184];
            }
            if (reader[185] != DBNull.Value)
            {
                PCT0030181 = (int?)reader[185];
            }
            if (reader[186] != DBNull.Value)
            {
                PCT0030182 = (int?)reader[186];
            }
            if (reader[187] != DBNull.Value)
            {
                PCT0030183 = (int?)reader[187];
            }
            if (reader[188] != DBNull.Value)
            {
                PCT0030184 = (int?)reader[188];
            }
            if (reader[189] != DBNull.Value)
            {
                PCT0030185 = (int?)reader[189];
            }
            if (reader[190] != DBNull.Value)
            {
                PCT0030186 = (int?)reader[190];
            }
            if (reader[191] != DBNull.Value)
            {
                PCT0030187 = (int?)reader[191];
            }
            if (reader[192] != DBNull.Value)
            {
                PCT0030188 = (int?)reader[192];
            }
            if (reader[193] != DBNull.Value)
            {
                PCT0030189 = (int?)reader[193];
            }
            if (reader[194] != DBNull.Value)
            {
                PCT0030190 = (int?)reader[194];
            }
            if (reader[195] != DBNull.Value)
            {
                PCT0030191 = (int?)reader[195];
            }
            if (reader[196] != DBNull.Value)
            {
                PCT0030192 = (int?)reader[196];
            }
            if (reader[197] != DBNull.Value)
            {
                PCT0030193 = (int?)reader[197];
            }
            if (reader[198] != DBNull.Value)
            {
                PCT0030194 = (int?)reader[198];
            }
            if (reader[199] != DBNull.Value)
            {
                PCT0030195 = (int?)reader[199];
            }
            if (reader[200] != DBNull.Value)
            {
                PCT0030196 = (int?)reader[200];
            }
            if (reader[201] != DBNull.Value)
            {
                PCT0030197 = (int?)reader[201];
            }
            if (reader[202] != DBNull.Value)
            {
                PCT0030198 = (int?)reader[202];
            }
            if (reader[203] != DBNull.Value)
            {
                PCT0030199 = (int?)reader[203];
            }
            if (reader[204] != DBNull.Value)
            {
                PCT0030200 = (int?)reader[204];
            }
            if (reader[205] != DBNull.Value)
            {
                PCT0030201 = (int?)reader[205];
            }
            if (reader[206] != DBNull.Value)
            {
                PCT0030202 = (int?)reader[206];
            }
            if (reader[207] != DBNull.Value)
            {
                PCT0030203 = (int?)reader[207];
            }
            if (reader[208] != DBNull.Value)
            {
                PCT0030204 = (int?)reader[208];
            }
            if (reader[209] != DBNull.Value)
            {
                PCT0030205 = (int?)reader[209];
            }
            if (reader[210] != DBNull.Value)
            {
                PCT0030206 = (int?)reader[210];
            }
            if (reader[211] != DBNull.Value)
            {
                PCT0030207 = (int?)reader[211];
            }
            if (reader[212] != DBNull.Value)
            {
                PCT0030208 = (int?)reader[212];
            }
            if (reader[213] != DBNull.Value)
            {
                PCT0030209 = (int?)reader[213];
            }
            if (reader[214] != DBNull.Value)
            {
                PCT0040001 = (double?)reader[214];
            }
            if (reader[215] != DBNull.Value)
            {
                PCT0040002 = (double?)reader[215];
            }
            if (reader[216] != DBNull.Value)
            {
                PCT0040003 = (double?)reader[216];
            }
        }
        #endregion Constructors
    }
}
