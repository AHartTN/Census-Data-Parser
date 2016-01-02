#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2016 11:00 AM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: Redistricting_PL.cs
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

    public class Redistricting_PL : BaseModel
    {
        #region Properties
        [MaxLength(6)]
        [ReadOnly(false)]
        [Column("FILEID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
        public string FILEID { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("STUSAB", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }

        [MaxLength(3)]
        [ReadOnly(false)]
        [Column("CHARITER", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
        public string CHARITER { get; set; }

        [MaxLength(2)]
        [ReadOnly(false)]
        [Column("CIFSN", Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
        public string CIFSN { get; set; }

        [MaxLength(7)]
        [ReadOnly(false)]
        [Column("LOGRECNO", Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
        public string LOGRECNO { get; set; }

        [ReadOnly(false)]
        [Column("P0010001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public int? P0010001 { get; set; }

        [ReadOnly(false)]
        [Column("P0010002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of one race:", ShortName = "Population of one race:", Order = 6)]
        public int? P0010002 { get; set; }

        [ReadOnly(false)]
        [Column("P0010003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White alone", ShortName = "White alone", Order = 7)]
        public int? P0010003 { get; set; }

        [ReadOnly(false)]
        [Column("P0010004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American alone", ShortName = "Black or African American alone", Order = 8)]
        public int? P0010004 { get; set; }

        [ReadOnly(false)]
        [Column("P0010005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native alone", ShortName = "American Indian and Alaska Native alone", Order = 9)]
        public int? P0010005 { get; set; }

        [ReadOnly(false)]
        [Column("P0010006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian alone", ShortName = "Asian alone", Order = 10)]
        public int? P0010006 { get; set; }

        [ReadOnly(false)]
        [Column("P0010007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander alone", ShortName = "Native Hawaiian and Other Pacific Islander alone", Order = 11)]
        public int? P0010007 { get; set; }

        [ReadOnly(false)]
        [Column("P0010008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Some Other Race alone", ShortName = "Some Other Race alone", Order = 12)]
        public int? P0010008 { get; set; }

        [ReadOnly(false)]
        [Column("P0010009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Two or More Races:", ShortName = "Two or More Races:", Order = 13)]
        public int? P0010009 { get; set; }

        [ReadOnly(false)]
        [Column("P0010010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of two races:", ShortName = "Population of two races:", Order = 14)]
        public int? P0010010 { get; set; }

        [ReadOnly(false)]
        [Column("P0010011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American", ShortName = "White; Black or African American", Order = 15)]
        public int? P0010011 { get; set; }

        [ReadOnly(false)]
        [Column("P0010012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native", ShortName = "White; American Indian and Alaska Native", Order = 16)]
        public int? P0010012 { get; set; }

        [ReadOnly(false)]
        [Column("P0010013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian", ShortName = "White; Asian", Order = 17)]
        public int? P0010013 { get; set; }

        [ReadOnly(false)]
        [Column("P0010014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Native Hawaiian and Other Pacific Islander", ShortName = "White; Native Hawaiian and Other Pacific Islander", Order = 18)]
        public int? P0010014 { get; set; }

        [ReadOnly(false)]
        [Column("P0010015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Some Other Race", ShortName = "White; Some Other Race", Order = 19)]
        public int? P0010015 { get; set; }

        [ReadOnly(false)]
        [Column("P0010016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native", ShortName = "Black or African American; American Indian and Alaska Native", Order = 20)]
        public int? P0010016 { get; set; }

        [ReadOnly(false)]
        [Column("P0010017", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian", ShortName = "Black or African American; Asian", Order = 21)]
        public int? P0010017 { get; set; }

        [ReadOnly(false)]
        [Column("P0010018", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander", Order = 22)]
        public int? P0010018 { get; set; }

        [ReadOnly(false)]
        [Column("P0010019", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Some Other Race", ShortName = "Black or African American; Some Other Race", Order = 23)]
        public int? P0010019 { get; set; }

        [ReadOnly(false)]
        [Column("P0010020", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian", ShortName = "American Indian and Alaska Native; Asian", Order = 24)]
        public int? P0010020 { get; set; }

        [ReadOnly(false)]
        [Column("P0010021", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 25)]
        public int? P0010021 { get; set; }

        [ReadOnly(false)]
        [Column("P0010022", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Some Other Race", ShortName = "American Indian and Alaska Native; Some Other Race", Order = 26)]
        public int? P0010022 { get; set; }

        [ReadOnly(false)]
        [Column("P0010023", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Asian; Native Hawaiian and Other Pacific Islander", Order = 27)]
        public int? P0010023 { get; set; }

        [ReadOnly(false)]
        [Column("P0010024", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian; Some Other Race", ShortName = "Asian; Some Other Race", Order = 28)]
        public int? P0010024 { get; set; }

        [ReadOnly(false)]
        [Column("P0010025", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 29)]
        public int? P0010025 { get; set; }

        [ReadOnly(false)]
        [Column("P0010026", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of three races:", ShortName = "Population of three races:", Order = 30)]
        public int? P0010026 { get; set; }

        [ReadOnly(false)]
        [Column("P0010027", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native", ShortName = "White; Black or African American; American Indian and Alaska Native", Order = 31)]
        public int? P0010027 { get; set; }

        [ReadOnly(false)]
        [Column("P0010028", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian", ShortName = "White; Black or African American; Asian", Order = 32)]
        public int? P0010028 { get; set; }

        [ReadOnly(false)]
        [Column("P0010029", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander", Order = 33)]
        public int? P0010029 { get; set; }

        [ReadOnly(false)]
        [Column("P0010030", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Some Other Race", ShortName = "White; Black or African American; Some Other Race", Order = 34)]
        public int? P0010030 { get; set; }

        [ReadOnly(false)]
        [Column("P0010031", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian", ShortName = "White; American Indian and Alaska Native; Asian", Order = 35)]
        public int? P0010031 { get; set; }

        [ReadOnly(false)]
        [Column("P0010032", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 36)]
        public int? P0010032 { get; set; }

        [ReadOnly(false)]
        [Column("P0010033", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Some Other Race", ShortName = "White; American Indian and Alaska Native; Some Other Race", Order = 37)]
        public int? P0010033 { get; set; }

        [ReadOnly(false)]
        [Column("P0010034", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander", Order = 38)]
        public int? P0010034 { get; set; }

        [ReadOnly(false)]
        [Column("P0010035", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian; Some Other Race", ShortName = "White; Asian; Some Other Race", Order = 39)]
        public int? P0010035 { get; set; }

        [ReadOnly(false)]
        [Column("P0010036", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 40)]
        public int? P0010036 { get; set; }

        [ReadOnly(false)]
        [Column("P0010037", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian", ShortName = "Black or African American; American Indian and Alaska Native; Asian", Order = 41)]
        public int? P0010037 { get; set; }

        [ReadOnly(false)]
        [Column("P0010038", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 42)]
        public int? P0010038 { get; set; }

        [ReadOnly(false)]
        [Column("P0010039", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Some Other Race", Order = 43)]
        public int? P0010039 { get; set; }

        [ReadOnly(false)]
        [Column("P0010040", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 44)]
        public int? P0010040 { get; set; }

        [ReadOnly(false)]
        [Column("P0010041", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian; Some Other Race", ShortName = "Black or African American; Asian; Some Other Race", Order = 45)]
        public int? P0010041 { get; set; }

        [ReadOnly(false)]
        [Column("P0010042", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 46)]
        public int? P0010042 { get; set; }

        [ReadOnly(false)]
        [Column("P0010043", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 47)]
        public int? P0010043 { get; set; }

        [ReadOnly(false)]
        [Column("P0010044", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Some Other Race", Order = 48)]
        public int? P0010044 { get; set; }

        [ReadOnly(false)]
        [Column("P0010045", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 49)]
        public int? P0010045 { get; set; }

        [ReadOnly(false)]
        [Column("P0010046", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 50)]
        public int? P0010046 { get; set; }

        [ReadOnly(false)]
        [Column("P0010047", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of four races:", ShortName = "Population of four races:", Order = 51)]
        public int? P0010047 { get; set; }

        [ReadOnly(false)]
        [Column("P0010048", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian", Order = 52)]
        public int? P0010048 { get; set; }

        [ReadOnly(false)]
        [Column("P0010049", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 53)]
        public int? P0010049 { get; set; }

        [ReadOnly(false)]
        [Column("P0010050", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Some Other Race", Order = 54)]
        public int? P0010050 { get; set; }

        [ReadOnly(false)]
        [Column("P0010051", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 55)]
        public int? P0010051 { get; set; }

        [ReadOnly(false)]
        [Column("P0010052", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian; Some Other Race", ShortName = "White; Black or African American; Asian; Some Other Race", Order = 56)]
        public int? P0010052 { get; set; }

        [ReadOnly(false)]
        [Column("P0010053", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 57)]
        public int? P0010053 { get; set; }

        [ReadOnly(false)]
        [Column("P0010054", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 58)]
        public int? P0010054 { get; set; }

        [ReadOnly(false)]
        [Column("P0010055", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Some Other Race", Order = 59)]
        public int? P0010055 { get; set; }

        [ReadOnly(false)]
        [Column("P0010056", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 60)]
        public int? P0010056 { get; set; }

        [ReadOnly(false)]
        [Column("P0010057", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 61)]
        public int? P0010057 { get; set; }

        [ReadOnly(false)]
        [Column("P0010058", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 62)]
        public int? P0010058 { get; set; }

        [ReadOnly(false)]
        [Column("P0010059", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 63)]
        public int? P0010059 { get; set; }

        [ReadOnly(false)]
        [Column("P0010060", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 64)]
        public int? P0010060 { get; set; }

        [ReadOnly(false)]
        [Column("P0010061", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 65)]
        public int? P0010061 { get; set; }

        [ReadOnly(false)]
        [Column("P0010062", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 66)]
        public int? P0010062 { get; set; }

        [ReadOnly(false)]
        [Column("P0010063", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of five races:", ShortName = "Population of five races:", Order = 67)]
        public int? P0010063 { get; set; }

        [ReadOnly(false)]
        [Column("P0010064", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 68)]
        public int? P0010064 { get; set; }

        [ReadOnly(false)]
        [Column("P0010065", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 69)]
        public int? P0010065 { get; set; }

        [ReadOnly(false)]
        [Column("P0010066", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 70)]
        public int? P0010066 { get; set; }

        [ReadOnly(false)]
        [Column("P0010067", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 71)]
        public int? P0010067 { get; set; }

        [ReadOnly(false)]
        [Column("P0010068", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 72)]
        public int? P0010068 { get; set; }

        [ReadOnly(false)]
        [Column("P0010069", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 73)]
        public int? P0010069 { get; set; }

        [ReadOnly(false)]
        [Column("P0010070", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of six races:", ShortName = "Population of six races:", Order = 74)]
        public int? P0010070 { get; set; }

        [ReadOnly(false)]
        [Column("P0010071", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 75)]
        public int? P0010071 { get; set; }

        [ReadOnly(false)]
        [Column("P0020001", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 76)]
        public int? P0020001 { get; set; }

        [ReadOnly(false)]
        [Column("P0020002", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hispanic or Latino", ShortName = "Hispanic or Latino", Order = 77)]
        public int? P0020002 { get; set; }

        [ReadOnly(false)]
        [Column("P0020003", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not Hispanic or Latino:", ShortName = "Not Hispanic or Latino:", Order = 78)]
        public int? P0020003 { get; set; }

        [ReadOnly(false)]
        [Column("P0020004", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of one race:", ShortName = "Population of one race:", Order = 79)]
        public int? P0020004 { get; set; }

        [ReadOnly(false)]
        [Column("P0020005", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White alone", ShortName = "White alone", Order = 80)]
        public int? P0020005 { get; set; }

        [ReadOnly(false)]
        [Column("P0020006", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American alone", ShortName = "Black or African American alone", Order = 81)]
        public int? P0020006 { get; set; }

        [ReadOnly(false)]
        [Column("P0020007", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native alone", ShortName = "American Indian and Alaska Native alone", Order = 82)]
        public int? P0020007 { get; set; }

        [ReadOnly(false)]
        [Column("P0020008", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian alone", ShortName = "Asian alone", Order = 83)]
        public int? P0020008 { get; set; }

        [ReadOnly(false)]
        [Column("P0020009", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander alone", ShortName = "Native Hawaiian and Other Pacific Islander alone", Order = 84)]
        public int? P0020009 { get; set; }

        [ReadOnly(false)]
        [Column("P0020010", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Some Other Race alone", ShortName = "Some Other Race alone", Order = 85)]
        public int? P0020010 { get; set; }

        [ReadOnly(false)]
        [Column("P0020011", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Two or More Races:", ShortName = "Two or More Races:", Order = 86)]
        public int? P0020011 { get; set; }

        [ReadOnly(false)]
        [Column("P0020012", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of two races:", ShortName = "Population of two races:", Order = 87)]
        public int? P0020012 { get; set; }

        [ReadOnly(false)]
        [Column("P0020013", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American", ShortName = "White; Black or African American", Order = 88)]
        public int? P0020013 { get; set; }

        [ReadOnly(false)]
        [Column("P0020014", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native", ShortName = "White; American Indian and Alaska Native", Order = 89)]
        public int? P0020014 { get; set; }

        [ReadOnly(false)]
        [Column("P0020015", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian", ShortName = "White; Asian", Order = 90)]
        public int? P0020015 { get; set; }

        [ReadOnly(false)]
        [Column("P0020016", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Native Hawaiian and Other Pacific Islander", ShortName = "White; Native Hawaiian and Other Pacific Islander", Order = 91)]
        public int? P0020016 { get; set; }

        [ReadOnly(false)]
        [Column("P0020017", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Some Other Race", ShortName = "White; Some Other Race", Order = 92)]
        public int? P0020017 { get; set; }

        [ReadOnly(false)]
        [Column("P0020018", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native", ShortName = "Black or African American; American Indian and Alaska Native", Order = 93)]
        public int? P0020018 { get; set; }

        [ReadOnly(false)]
        [Column("P0020019", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian", ShortName = "Black or African American; Asian", Order = 94)]
        public int? P0020019 { get; set; }

        [ReadOnly(false)]
        [Column("P0020020", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander", Order = 95)]
        public int? P0020020 { get; set; }

        [ReadOnly(false)]
        [Column("P0020021", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Some Other Race", ShortName = "Black or African American; Some Other Race", Order = 96)]
        public int? P0020021 { get; set; }

        [ReadOnly(false)]
        [Column("P0020022", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian", ShortName = "American Indian and Alaska Native; Asian", Order = 97)]
        public int? P0020022 { get; set; }

        [ReadOnly(false)]
        [Column("P0020023", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 98)]
        public int? P0020023 { get; set; }

        [ReadOnly(false)]
        [Column("P0020024", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Some Other Race", ShortName = "American Indian and Alaska Native; Some Other Race", Order = 99)]
        public int? P0020024 { get; set; }

        [ReadOnly(false)]
        [Column("P0020025", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Asian; Native Hawaiian and Other Pacific Islander", Order = 100)]
        public int? P0020025 { get; set; }

        [ReadOnly(false)]
        [Column("P0020026", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian; Some Other Race", ShortName = "Asian; Some Other Race", Order = 101)]
        public int? P0020026 { get; set; }

        [ReadOnly(false)]
        [Column("P0020027", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 102)]
        public int? P0020027 { get; set; }

        [ReadOnly(false)]
        [Column("P0020028", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of three races:", ShortName = "Population of three races:", Order = 103)]
        public int? P0020028 { get; set; }

        [ReadOnly(false)]
        [Column("P0020029", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native", ShortName = "White; Black or African American; American Indian and Alaska Native", Order = 104)]
        public int? P0020029 { get; set; }

        [ReadOnly(false)]
        [Column("P0020030", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian", ShortName = "White; Black or African American; Asian", Order = 105)]
        public int? P0020030 { get; set; }

        [ReadOnly(false)]
        [Column("P0020031", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander", Order = 106)]
        public int? P0020031 { get; set; }

        [ReadOnly(false)]
        [Column("P0020032", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Some Other Race", ShortName = "White; Black or African American; Some Other Race", Order = 107)]
        public int? P0020032 { get; set; }

        [ReadOnly(false)]
        [Column("P0020033", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian", ShortName = "White; American Indian and Alaska Native; Asian", Order = 108)]
        public int? P0020033 { get; set; }

        [ReadOnly(false)]
        [Column("P0020034", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 109)]
        public int? P0020034 { get; set; }

        [ReadOnly(false)]
        [Column("P0020035", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Some Other Race", ShortName = "White; American Indian and Alaska Native; Some Other Race", Order = 110)]
        public int? P0020035 { get; set; }

        [ReadOnly(false)]
        [Column("P0020036", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander", Order = 111)]
        public int? P0020036 { get; set; }

        [ReadOnly(false)]
        [Column("P0020037", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian; Some Other Race", ShortName = "White; Asian; Some Other Race", Order = 112)]
        public int? P0020037 { get; set; }

        [ReadOnly(false)]
        [Column("P0020038", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 113)]
        public int? P0020038 { get; set; }

        [ReadOnly(false)]
        [Column("P0020039", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian", ShortName = "Black or African American; American Indian and Alaska Native; Asian", Order = 114)]
        public int? P0020039 { get; set; }

        [ReadOnly(false)]
        [Column("P0020040", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 115)]
        public int? P0020040 { get; set; }

        [ReadOnly(false)]
        [Column("P0020041", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Some Other Race", Order = 116)]
        public int? P0020041 { get; set; }

        [ReadOnly(false)]
        [Column("P0020042", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 117)]
        public int? P0020042 { get; set; }

        [ReadOnly(false)]
        [Column("P0020043", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian; Some Other Race", ShortName = "Black or African American; Asian; Some Other Race", Order = 118)]
        public int? P0020043 { get; set; }

        [ReadOnly(false)]
        [Column("P0020044", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 119)]
        public int? P0020044 { get; set; }

        [ReadOnly(false)]
        [Column("P0020045", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 120)]
        public int? P0020045 { get; set; }

        [ReadOnly(false)]
        [Column("P0020046", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Some Other Race", Order = 121)]
        public int? P0020046 { get; set; }

        [ReadOnly(false)]
        [Column("P0020047", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 122)]
        public int? P0020047 { get; set; }

        [ReadOnly(false)]
        [Column("P0020048", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 123)]
        public int? P0020048 { get; set; }

        [ReadOnly(false)]
        [Column("P0020049", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of four races:", ShortName = "Population of four races:", Order = 124)]
        public int? P0020049 { get; set; }

        [ReadOnly(false)]
        [Column("P0020050", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian", Order = 125)]
        public int? P0020050 { get; set; }

        [ReadOnly(false)]
        [Column("P0020051", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 126)]
        public int? P0020051 { get; set; }

        [ReadOnly(false)]
        [Column("P0020052", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Some Other Race", Order = 127)]
        public int? P0020052 { get; set; }

        [ReadOnly(false)]
        [Column("P0020053", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 128)]
        public int? P0020053 { get; set; }

        [ReadOnly(false)]
        [Column("P0020054", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian; Some Other Race", ShortName = "White; Black or African American; Asian; Some Other Race", Order = 129)]
        public int? P0020054 { get; set; }

        [ReadOnly(false)]
        [Column("P0020055", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 130)]
        public int? P0020055 { get; set; }

        [ReadOnly(false)]
        [Column("P0020056", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 131)]
        public int? P0020056 { get; set; }

        [ReadOnly(false)]
        [Column("P0020057", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Some Other Race", Order = 132)]
        public int? P0020057 { get; set; }

        [ReadOnly(false)]
        [Column("P0020058", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 133)]
        public int? P0020058 { get; set; }

        [ReadOnly(false)]
        [Column("P0020059", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander, Some Other Race", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander, Some Other Race", Order = 134)]
        public int? P0020059 { get; set; }

        [ReadOnly(false)]
        [Column("P0020060", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 135)]
        public int? P0020060 { get; set; }

        [ReadOnly(false)]
        [Column("P0020061", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 136)]
        public int? P0020061 { get; set; }

        [ReadOnly(false)]
        [Column("P0020062", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 137)]
        public int? P0020062 { get; set; }

        [ReadOnly(false)]
        [Column("P0020063", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 138)]
        public int? P0020063 { get; set; }

        [ReadOnly(false)]
        [Column("P0020064", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 139)]
        public int? P0020064 { get; set; }

        [ReadOnly(false)]
        [Column("P0020065", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of five races:", ShortName = "Population of five races:", Order = 140)]
        public int? P0020065 { get; set; }

        [ReadOnly(false)]
        [Column("P0020066", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 141)]
        public int? P0020066 { get; set; }

        [ReadOnly(false)]
        [Column("P0020067", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 142)]
        public int? P0020067 { get; set; }

        [ReadOnly(false)]
        [Column("P0020068", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 143)]
        public int? P0020068 { get; set; }

        [ReadOnly(false)]
        [Column("P0020069", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 144)]
        public int? P0020069 { get; set; }

        [ReadOnly(false)]
        [Column("P0020070", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 145)]
        public int? P0020070 { get; set; }

        [ReadOnly(false)]
        [Column("P0020071", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 146)]
        public int? P0020071 { get; set; }

        [ReadOnly(false)]
        [Column("P0020072", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of six races:", ShortName = "Population of six races:", Order = 147)]
        public int? P0020072 { get; set; }

        [ReadOnly(false)]
        [Column("P0020073", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 148)]
        public int? P0020073 { get; set; }

        [ReadOnly(false)]
        [Column("P0030001", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 149)]
        public int? P0030001 { get; set; }

        [ReadOnly(false)]
        [Column("P0030002", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of one race:", ShortName = "Population of one race:", Order = 150)]
        public int? P0030002 { get; set; }

        [ReadOnly(false)]
        [Column("P0030003", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White alone", ShortName = "White alone", Order = 151)]
        public int? P0030003 { get; set; }

        [ReadOnly(false)]
        [Column("P0030004", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American alone", ShortName = "Black or African American alone", Order = 152)]
        public int? P0030004 { get; set; }

        [ReadOnly(false)]
        [Column("P0030005", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native alone", ShortName = "American Indian and Alaska Native alone", Order = 153)]
        public int? P0030005 { get; set; }

        [ReadOnly(false)]
        [Column("P0030006", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian alone", ShortName = "Asian alone", Order = 154)]
        public int? P0030006 { get; set; }

        [ReadOnly(false)]
        [Column("P0030007", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander alone", ShortName = "Native Hawaiian and Other Pacific Islander alone", Order = 155)]
        public int? P0030007 { get; set; }

        [ReadOnly(false)]
        [Column("P0030008", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Some Other Race alone", ShortName = "Some Other Race alone", Order = 156)]
        public int? P0030008 { get; set; }

        [ReadOnly(false)]
        [Column("P0030009", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Two or More Races:", ShortName = "Two or More Races:", Order = 157)]
        public int? P0030009 { get; set; }

        [ReadOnly(false)]
        [Column("P0030010", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of two races:", ShortName = "Population of two races:", Order = 158)]
        public int? P0030010 { get; set; }

        [ReadOnly(false)]
        [Column("P0030011", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American", ShortName = "White; Black or African American", Order = 159)]
        public int? P0030011 { get; set; }

        [ReadOnly(false)]
        [Column("P0030012", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native", ShortName = "White; American Indian and Alaska Native", Order = 160)]
        public int? P0030012 { get; set; }

        [ReadOnly(false)]
        [Column("P0030013", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian", ShortName = "White; Asian", Order = 161)]
        public int? P0030013 { get; set; }

        [ReadOnly(false)]
        [Column("P0030014", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Native Hawaiian and Other Pacific Islander", ShortName = "White; Native Hawaiian and Other Pacific Islander", Order = 162)]
        public int? P0030014 { get; set; }

        [ReadOnly(false)]
        [Column("P0030015", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Some Other Race", ShortName = "White; Some Other Race", Order = 163)]
        public int? P0030015 { get; set; }

        [ReadOnly(false)]
        [Column("P0030016", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native", ShortName = "Black or African American; American Indian and Alaska Native", Order = 164)]
        public int? P0030016 { get; set; }

        [ReadOnly(false)]
        [Column("P0030017", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian", ShortName = "Black or African American; Asian", Order = 165)]
        public int? P0030017 { get; set; }

        [ReadOnly(false)]
        [Column("P0030018", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander", Order = 166)]
        public int? P0030018 { get; set; }

        [ReadOnly(false)]
        [Column("P0030019", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Some Other Race", ShortName = "Black or African American; Some Other Race", Order = 167)]
        public int? P0030019 { get; set; }

        [ReadOnly(false)]
        [Column("P0030020", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian", ShortName = "American Indian and Alaska Native; Asian", Order = 168)]
        public int? P0030020 { get; set; }

        [ReadOnly(false)]
        [Column("P0030021", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 169)]
        public int? P0030021 { get; set; }

        [ReadOnly(false)]
        [Column("P0030022", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Some Other Race", ShortName = "American Indian and Alaska Native; Some Other Race", Order = 170)]
        public int? P0030022 { get; set; }

        [ReadOnly(false)]
        [Column("P0030023", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Asian; Native Hawaiian and Other Pacific Islander", Order = 171)]
        public int? P0030023 { get; set; }

        [ReadOnly(false)]
        [Column("P0030024", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian; Some Other Race", ShortName = "Asian; Some Other Race", Order = 172)]
        public int? P0030024 { get; set; }

        [ReadOnly(false)]
        [Column("P0030025", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 173)]
        public int? P0030025 { get; set; }

        [ReadOnly(false)]
        [Column("P0030026", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of three races:", ShortName = "Population of three races:", Order = 174)]
        public int? P0030026 { get; set; }

        [ReadOnly(false)]
        [Column("P0030027", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native", ShortName = "White; Black or African American; American Indian and Alaska Native", Order = 175)]
        public int? P0030027 { get; set; }

        [ReadOnly(false)]
        [Column("P0030028", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian", ShortName = "White; Black or African American; Asian", Order = 176)]
        public int? P0030028 { get; set; }

        [ReadOnly(false)]
        [Column("P0030029", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander", Order = 177)]
        public int? P0030029 { get; set; }

        [ReadOnly(false)]
        [Column("P0030030", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Some Other Race", ShortName = "White; Black or African American; Some Other Race", Order = 178)]
        public int? P0030030 { get; set; }

        [ReadOnly(false)]
        [Column("P0030031", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian", ShortName = "White; American Indian and Alaska Native; Asian", Order = 179)]
        public int? P0030031 { get; set; }

        [ReadOnly(false)]
        [Column("P0030032", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 180)]
        public int? P0030032 { get; set; }

        [ReadOnly(false)]
        [Column("P0030033", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Some Other Race", ShortName = "White; American Indian and Alaska Native; Some Other Race", Order = 181)]
        public int? P0030033 { get; set; }

        [ReadOnly(false)]
        [Column("P0030034", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander", Order = 182)]
        public int? P0030034 { get; set; }

        [ReadOnly(false)]
        [Column("P0030035", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian; Some Other Race", ShortName = "White; Asian; Some Other Race", Order = 183)]
        public int? P0030035 { get; set; }

        [ReadOnly(false)]
        [Column("P0030036", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 184)]
        public int? P0030036 { get; set; }

        [ReadOnly(false)]
        [Column("P0030037", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian", ShortName = "Black or African American; American Indian and Alaska Native; Asian", Order = 185)]
        public int? P0030037 { get; set; }

        [ReadOnly(false)]
        [Column("P0030038", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 186)]
        public int? P0030038 { get; set; }

        [ReadOnly(false)]
        [Column("P0030039", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Some Other Race", Order = 187)]
        public int? P0030039 { get; set; }

        [ReadOnly(false)]
        [Column("P0030040", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 188)]
        public int? P0030040 { get; set; }

        [ReadOnly(false)]
        [Column("P0030041", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian; Some Other Race", ShortName = "Black or African American; Asian; Some Other Race", Order = 189)]
        public int? P0030041 { get; set; }

        [ReadOnly(false)]
        [Column("P0030042", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 190)]
        public int? P0030042 { get; set; }

        [ReadOnly(false)]
        [Column("P0030043", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 191)]
        public int? P0030043 { get; set; }

        [ReadOnly(false)]
        [Column("P0030044", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Some Other Race", Order = 192)]
        public int? P0030044 { get; set; }

        [ReadOnly(false)]
        [Column("P0030045", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 193)]
        public int? P0030045 { get; set; }

        [ReadOnly(false)]
        [Column("P0030046", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 194)]
        public int? P0030046 { get; set; }

        [ReadOnly(false)]
        [Column("P0030047", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of four races:", ShortName = "Population of four races:", Order = 195)]
        public int? P0030047 { get; set; }

        [ReadOnly(false)]
        [Column("P0030048", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian", Order = 196)]
        public int? P0030048 { get; set; }

        [ReadOnly(false)]
        [Column("P0030049", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 197)]
        public int? P0030049 { get; set; }

        [ReadOnly(false)]
        [Column("P0030050", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Some Other Race", Order = 198)]
        public int? P0030050 { get; set; }

        [ReadOnly(false)]
        [Column("P0030051", Order = 199)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 199)]
        public int? P0030051 { get; set; }

        [ReadOnly(false)]
        [Column("P0030052", Order = 200)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian; Some Other Race", ShortName = "White; Black or African American; Asian; Some Other Race", Order = 200)]
        public int? P0030052 { get; set; }

        [ReadOnly(false)]
        [Column("P0030053", Order = 201)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 201)]
        public int? P0030053 { get; set; }

        [ReadOnly(false)]
        [Column("P0030054", Order = 202)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 202)]
        public int? P0030054 { get; set; }

        [ReadOnly(false)]
        [Column("P0030055", Order = 203)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Some Other Race", Order = 203)]
        public int? P0030055 { get; set; }

        [ReadOnly(false)]
        [Column("P0030056", Order = 204)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 204)]
        public int? P0030056 { get; set; }

        [ReadOnly(false)]
        [Column("P0030057", Order = 205)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 205)]
        public int? P0030057 { get; set; }

        [ReadOnly(false)]
        [Column("P0030058", Order = 206)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 206)]
        public int? P0030058 { get; set; }

        [ReadOnly(false)]
        [Column("P0030059", Order = 207)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 207)]
        public int? P0030059 { get; set; }

        [ReadOnly(false)]
        [Column("P0030060", Order = 208)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 208)]
        public int? P0030060 { get; set; }

        [ReadOnly(false)]
        [Column("P0030061", Order = 209)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 209)]
        public int? P0030061 { get; set; }

        [ReadOnly(false)]
        [Column("P0030062", Order = 210)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 210)]
        public int? P0030062 { get; set; }

        [ReadOnly(false)]
        [Column("P0030063", Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of five races:", ShortName = "Population of five races:", Order = 211)]
        public int? P0030063 { get; set; }

        [ReadOnly(false)]
        [Column("P0030064", Order = 212)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 212)]
        public int? P0030064 { get; set; }

        [ReadOnly(false)]
        [Column("P0030065", Order = 213)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 213)]
        public int? P0030065 { get; set; }

        [ReadOnly(false)]
        [Column("P0030066", Order = 214)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 214)]
        public int? P0030066 { get; set; }

        [ReadOnly(false)]
        [Column("P0030067", Order = 215)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 215)]
        public int? P0030067 { get; set; }

        [ReadOnly(false)]
        [Column("P0030068", Order = 216)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander;  Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander;  Some Other Race", Order = 216)]
        public int? P0030068 { get; set; }

        [ReadOnly(false)]
        [Column("P0030069", Order = 217)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 217)]
        public int? P0030069 { get; set; }

        [ReadOnly(false)]
        [Column("P0030070", Order = 218)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of six races:", ShortName = "Population of six races:", Order = 218)]
        public int? P0030070 { get; set; }

        [ReadOnly(false)]
        [Column("P0030071", Order = 219)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 219)]
        public int? P0030071 { get; set; }

        [ReadOnly(false)]
        [Column("P0040001", Order = 220)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 220)]
        public int? P0040001 { get; set; }

        [ReadOnly(false)]
        [Column("P0040002", Order = 221)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hispanic or Latino", ShortName = "Hispanic or Latino", Order = 221)]
        public int? P0040002 { get; set; }

        [ReadOnly(false)]
        [Column("P0040003", Order = 222)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not Hispanic or Latino:", ShortName = "Not Hispanic or Latino:", Order = 222)]
        public int? P0040003 { get; set; }

        [ReadOnly(false)]
        [Column("P0040004", Order = 223)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of one race:", ShortName = "Population of one race:", Order = 223)]
        public int? P0040004 { get; set; }

        [ReadOnly(false)]
        [Column("P0040005", Order = 224)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White alone", ShortName = "White alone", Order = 224)]
        public int? P0040005 { get; set; }

        [ReadOnly(false)]
        [Column("P0040006", Order = 225)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American alone", ShortName = "Black or African American alone", Order = 225)]
        public int? P0040006 { get; set; }

        [ReadOnly(false)]
        [Column("P0040007", Order = 226)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native alone", ShortName = "American Indian and Alaska Native alone", Order = 226)]
        public int? P0040007 { get; set; }

        [ReadOnly(false)]
        [Column("P0040008", Order = 227)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian alone", ShortName = "Asian alone", Order = 227)]
        public int? P0040008 { get; set; }

        [ReadOnly(false)]
        [Column("P0040009", Order = 228)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander alone", ShortName = "Native Hawaiian and Other Pacific Islander alone", Order = 228)]
        public int? P0040009 { get; set; }

        [ReadOnly(false)]
        [Column("P0040010", Order = 229)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Some Other Race alone", ShortName = "Some Other Race alone", Order = 229)]
        public int? P0040010 { get; set; }

        [ReadOnly(false)]
        [Column("P0040011", Order = 230)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Two or More Races:", ShortName = "Two or More Races:", Order = 230)]
        public int? P0040011 { get; set; }

        [ReadOnly(false)]
        [Column("P0040012", Order = 231)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of two races:", ShortName = "Population of two races:", Order = 231)]
        public int? P0040012 { get; set; }

        [ReadOnly(false)]
        [Column("P0040013", Order = 232)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American", ShortName = "White; Black or African American", Order = 232)]
        public int? P0040013 { get; set; }

        [ReadOnly(false)]
        [Column("P0040014", Order = 233)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native", ShortName = "White; American Indian and Alaska Native", Order = 233)]
        public int? P0040014 { get; set; }

        [ReadOnly(false)]
        [Column("P0040015", Order = 234)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian", ShortName = "White; Asian", Order = 234)]
        public int? P0040015 { get; set; }

        [ReadOnly(false)]
        [Column("P0040016", Order = 235)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Native Hawaiian and Other Pacific Islander", ShortName = "White; Native Hawaiian and Other Pacific Islander", Order = 235)]
        public int? P0040016 { get; set; }

        [ReadOnly(false)]
        [Column("P0040017", Order = 236)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Some Other Race", ShortName = "White; Some Other Race", Order = 236)]
        public int? P0040017 { get; set; }

        [ReadOnly(false)]
        [Column("P0040018", Order = 237)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native", ShortName = "Black or African American; American Indian and Alaska Native", Order = 237)]
        public int? P0040018 { get; set; }

        [ReadOnly(false)]
        [Column("P0040019", Order = 238)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian", ShortName = "Black or African American; Asian", Order = 238)]
        public int? P0040019 { get; set; }

        [ReadOnly(false)]
        [Column("P0040020", Order = 239)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander", Order = 239)]
        public int? P0040020 { get; set; }

        [ReadOnly(false)]
        [Column("P0040021", Order = 240)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Some Other Race", ShortName = "Black or African American; Some Other Race", Order = 240)]
        public int? P0040021 { get; set; }

        [ReadOnly(false)]
        [Column("P0040022", Order = 241)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian", ShortName = "American Indian and Alaska Native; Asian", Order = 241)]
        public int? P0040022 { get; set; }

        [ReadOnly(false)]
        [Column("P0040023", Order = 242)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 242)]
        public int? P0040023 { get; set; }

        [ReadOnly(false)]
        [Column("P0040024", Order = 243)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Some Other Race", ShortName = "American Indian and Alaska Native; Some Other Race", Order = 243)]
        public int? P0040024 { get; set; }

        [ReadOnly(false)]
        [Column("P0040025", Order = 244)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Asian; Native Hawaiian and Other Pacific Islander", Order = 244)]
        public int? P0040025 { get; set; }

        [ReadOnly(false)]
        [Column("P0040026", Order = 245)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian; Some Other Race", ShortName = "Asian; Some Other Race", Order = 245)]
        public int? P0040026 { get; set; }

        [ReadOnly(false)]
        [Column("P0040027", Order = 246)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 246)]
        public int? P0040027 { get; set; }

        [ReadOnly(false)]
        [Column("P0040028", Order = 247)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of three races:", ShortName = "Population of three races:", Order = 247)]
        public int? P0040028 { get; set; }

        [ReadOnly(false)]
        [Column("P0040029", Order = 248)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native", ShortName = "White; Black or African American; American Indian and Alaska Native", Order = 248)]
        public int? P0040029 { get; set; }

        [ReadOnly(false)]
        [Column("P0040030", Order = 249)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian", ShortName = "White; Black or African American; Asian", Order = 249)]
        public int? P0040030 { get; set; }

        [ReadOnly(false)]
        [Column("P0040031", Order = 250)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander", Order = 250)]
        public int? P0040031 { get; set; }

        [ReadOnly(false)]
        [Column("P0040032", Order = 251)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Some Other Race", ShortName = "White; Black or African American; Some Other Race", Order = 251)]
        public int? P0040032 { get; set; }

        [ReadOnly(false)]
        [Column("P0040033", Order = 252)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian", ShortName = "White; American Indian and Alaska Native; Asian", Order = 252)]
        public int? P0040033 { get; set; }

        [ReadOnly(false)]
        [Column("P0040034", Order = 253)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 253)]
        public int? P0040034 { get; set; }

        [ReadOnly(false)]
        [Column("P0040035", Order = 254)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Some Other Race", ShortName = "White; American Indian and Alaska Native; Some Other Race", Order = 254)]
        public int? P0040035 { get; set; }

        [ReadOnly(false)]
        [Column("P0040036", Order = 255)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander", Order = 255)]
        public int? P0040036 { get; set; }

        [ReadOnly(false)]
        [Column("P0040037", Order = 256)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian; Some Other Race", ShortName = "White; Asian; Some Other Race", Order = 256)]
        public int? P0040037 { get; set; }

        [ReadOnly(false)]
        [Column("P0040038", Order = 257)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 257)]
        public int? P0040038 { get; set; }

        [ReadOnly(false)]
        [Column("P0040039", Order = 258)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian", ShortName = "Black or African American; American Indian and Alaska Native; Asian", Order = 258)]
        public int? P0040039 { get; set; }

        [ReadOnly(false)]
        [Column("P0040040", Order = 259)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 259)]
        public int? P0040040 { get; set; }

        [ReadOnly(false)]
        [Column("P0040041", Order = 260)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Some Other Race", Order = 260)]
        public int? P0040041 { get; set; }

        [ReadOnly(false)]
        [Column("P0040042", Order = 261)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 261)]
        public int? P0040042 { get; set; }

        [ReadOnly(false)]
        [Column("P0040043", Order = 262)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian; Some Other Race", ShortName = "Black or African American; Asian; Some Other Race", Order = 262)]
        public int? P0040043 { get; set; }

        [ReadOnly(false)]
        [Column("P0040044", Order = 263)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 263)]
        public int? P0040044 { get; set; }

        [ReadOnly(false)]
        [Column("P0040045", Order = 264)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 264)]
        public int? P0040045 { get; set; }

        [ReadOnly(false)]
        [Column("P0040046", Order = 265)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Some Other Race", Order = 265)]
        public int? P0040046 { get; set; }

        [ReadOnly(false)]
        [Column("P0040047", Order = 266)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 266)]
        public int? P0040047 { get; set; }

        [ReadOnly(false)]
        [Column("P0040048", Order = 267)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 267)]
        public int? P0040048 { get; set; }

        [ReadOnly(false)]
        [Column("P0040049", Order = 268)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of four races:", ShortName = "Population of four races:", Order = 268)]
        public int? P0040049 { get; set; }

        [ReadOnly(false)]
        [Column("P0040050", Order = 269)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian", Order = 269)]
        public int? P0040050 { get; set; }

        [ReadOnly(false)]
        [Column("P0040051", Order = 270)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 270)]
        public int? P0040051 { get; set; }

        [ReadOnly(false)]
        [Column("P0040052", Order = 271)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Some Other Race", Order = 271)]
        public int? P0040052 { get; set; }

        [ReadOnly(false)]
        [Column("P0040053", Order = 272)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 272)]
        public int? P0040053 { get; set; }

        [ReadOnly(false)]
        [Column("P0040054", Order = 273)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian; Some Other Race", ShortName = "White; Black or African American; Asian; Some Other Race", Order = 273)]
        public int? P0040054 { get; set; }

        [ReadOnly(false)]
        [Column("P0040055", Order = 274)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 274)]
        public int? P0040055 { get; set; }

        [ReadOnly(false)]
        [Column("P0040056", Order = 275)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 275)]
        public int? P0040056 { get; set; }

        [ReadOnly(false)]
        [Column("P0040057", Order = 276)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Some Other Race", Order = 276)]
        public int? P0040057 { get; set; }

        [ReadOnly(false)]
        [Column("P0040058", Order = 277)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 277)]
        public int? P0040058 { get; set; }

        [ReadOnly(false)]
        [Column("P0040059", Order = 278)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander, Some Other Race", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander, Some Other Race", Order = 278)]
        public int? P0040059 { get; set; }

        [ReadOnly(false)]
        [Column("P0040060", Order = 279)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 279)]
        public int? P0040060 { get; set; }

        [ReadOnly(false)]
        [Column("P0040061", Order = 280)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 280)]
        public int? P0040061 { get; set; }

        [ReadOnly(false)]
        [Column("P0040062", Order = 281)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 281)]
        public int? P0040062 { get; set; }

        [ReadOnly(false)]
        [Column("P0040063", Order = 282)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 282)]
        public int? P0040063 { get; set; }

        [ReadOnly(false)]
        [Column("P0040064", Order = 283)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 283)]
        public int? P0040064 { get; set; }

        [ReadOnly(false)]
        [Column("P0040065", Order = 284)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of five races:", ShortName = "Population of five races:", Order = 284)]
        public int? P0040065 { get; set; }

        [ReadOnly(false)]
        [Column("P0040066", Order = 285)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 285)]
        public int? P0040066 { get; set; }

        [ReadOnly(false)]
        [Column("P0040067", Order = 286)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 286)]
        public int? P0040067 { get; set; }

        [ReadOnly(false)]
        [Column("P0040068", Order = 287)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 287)]
        public int? P0040068 { get; set; }

        [ReadOnly(false)]
        [Column("P0040069", Order = 288)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 288)]
        public int? P0040069 { get; set; }

        [ReadOnly(false)]
        [Column("P0040070", Order = 289)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 289)]
        public int? P0040070 { get; set; }

        [ReadOnly(false)]
        [Column("P0040071", Order = 290)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 290)]
        public int? P0040071 { get; set; }

        [ReadOnly(false)]
        [Column("P0040072", Order = 291)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of six races:", ShortName = "Population of six races:", Order = 291)]
        public int? P0040072 { get; set; }

        [ReadOnly(false)]
        [Column("P0040073", Order = 292)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 292)]
        public int? P0040073 { get; set; }

        [ReadOnly(false)]
        [Column("H0010001", Order = 293)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 293)]
        public int? H0010001 { get; set; }

        [ReadOnly(false)]
        [Column("H0010002", Order = 294)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Occupied", ShortName = "Occupied", Order = 294)]
        public int? H0010002 { get; set; }

        [ReadOnly(false)]
        [Column("H0010003", Order = 295)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Vacant", ShortName = "Vacant", Order = 295)]
        public int? H0010003 { get; set; }
        #endregion Properties

        #region Constructors
        public Redistricting_PL(string csvLine) : base(csvLine) { }

        public Redistricting_PL(string[] values) : base(values) { }

        public Redistricting_PL(OleDbDataReader reader, CensusFileType fileType)
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
                LOGRECNO = (string)reader[4];
            }
            if (reader[5] != DBNull.Value)
            {
                P0010001 = (int?)reader[5];
            }
            if (reader[6] != DBNull.Value)
            {
                P0010002 = (int?)reader[6];
            }
            if (reader[7] != DBNull.Value)
            {
                P0010003 = (int?)reader[7];
            }
            if (reader[8] != DBNull.Value)
            {
                P0010004 = (int?)reader[8];
            }
            if (reader[9] != DBNull.Value)
            {
                P0010005 = (int?)reader[9];
            }
            if (reader[10] != DBNull.Value)
            {
                P0010006 = (int?)reader[10];
            }
            if (reader[11] != DBNull.Value)
            {
                P0010007 = (int?)reader[11];
            }
            if (reader[12] != DBNull.Value)
            {
                P0010008 = (int?)reader[12];
            }
            if (reader[13] != DBNull.Value)
            {
                P0010009 = (int?)reader[13];
            }
            if (reader[14] != DBNull.Value)
            {
                P0010010 = (int?)reader[14];
            }
            if (reader[15] != DBNull.Value)
            {
                P0010011 = (int?)reader[15];
            }
            if (reader[16] != DBNull.Value)
            {
                P0010012 = (int?)reader[16];
            }
            if (reader[17] != DBNull.Value)
            {
                P0010013 = (int?)reader[17];
            }
            if (reader[18] != DBNull.Value)
            {
                P0010014 = (int?)reader[18];
            }
            if (reader[19] != DBNull.Value)
            {
                P0010015 = (int?)reader[19];
            }
            if (reader[20] != DBNull.Value)
            {
                P0010016 = (int?)reader[20];
            }
            if (reader[21] != DBNull.Value)
            {
                P0010017 = (int?)reader[21];
            }
            if (reader[22] != DBNull.Value)
            {
                P0010018 = (int?)reader[22];
            }
            if (reader[23] != DBNull.Value)
            {
                P0010019 = (int?)reader[23];
            }
            if (reader[24] != DBNull.Value)
            {
                P0010020 = (int?)reader[24];
            }
            if (reader[25] != DBNull.Value)
            {
                P0010021 = (int?)reader[25];
            }
            if (reader[26] != DBNull.Value)
            {
                P0010022 = (int?)reader[26];
            }
            if (reader[27] != DBNull.Value)
            {
                P0010023 = (int?)reader[27];
            }
            if (reader[28] != DBNull.Value)
            {
                P0010024 = (int?)reader[28];
            }
            if (reader[29] != DBNull.Value)
            {
                P0010025 = (int?)reader[29];
            }
            if (reader[30] != DBNull.Value)
            {
                P0010026 = (int?)reader[30];
            }
            if (reader[31] != DBNull.Value)
            {
                P0010027 = (int?)reader[31];
            }
            if (reader[32] != DBNull.Value)
            {
                P0010028 = (int?)reader[32];
            }
            if (reader[33] != DBNull.Value)
            {
                P0010029 = (int?)reader[33];
            }
            if (reader[34] != DBNull.Value)
            {
                P0010030 = (int?)reader[34];
            }
            if (reader[35] != DBNull.Value)
            {
                P0010031 = (int?)reader[35];
            }
            if (reader[36] != DBNull.Value)
            {
                P0010032 = (int?)reader[36];
            }
            if (reader[37] != DBNull.Value)
            {
                P0010033 = (int?)reader[37];
            }
            if (reader[38] != DBNull.Value)
            {
                P0010034 = (int?)reader[38];
            }
            if (reader[39] != DBNull.Value)
            {
                P0010035 = (int?)reader[39];
            }
            if (reader[40] != DBNull.Value)
            {
                P0010036 = (int?)reader[40];
            }
            if (reader[41] != DBNull.Value)
            {
                P0010037 = (int?)reader[41];
            }
            if (reader[42] != DBNull.Value)
            {
                P0010038 = (int?)reader[42];
            }
            if (reader[43] != DBNull.Value)
            {
                P0010039 = (int?)reader[43];
            }
            if (reader[44] != DBNull.Value)
            {
                P0010040 = (int?)reader[44];
            }
            if (reader[45] != DBNull.Value)
            {
                P0010041 = (int?)reader[45];
            }
            if (reader[46] != DBNull.Value)
            {
                P0010042 = (int?)reader[46];
            }
            if (reader[47] != DBNull.Value)
            {
                P0010043 = (int?)reader[47];
            }
            if (reader[48] != DBNull.Value)
            {
                P0010044 = (int?)reader[48];
            }
            if (reader[49] != DBNull.Value)
            {
                P0010045 = (int?)reader[49];
            }
            if (reader[50] != DBNull.Value)
            {
                P0010046 = (int?)reader[50];
            }
            if (reader[51] != DBNull.Value)
            {
                P0010047 = (int?)reader[51];
            }
            if (reader[52] != DBNull.Value)
            {
                P0010048 = (int?)reader[52];
            }
            if (reader[53] != DBNull.Value)
            {
                P0010049 = (int?)reader[53];
            }
            if (reader[54] != DBNull.Value)
            {
                P0010050 = (int?)reader[54];
            }
            if (reader[55] != DBNull.Value)
            {
                P0010051 = (int?)reader[55];
            }
            if (reader[56] != DBNull.Value)
            {
                P0010052 = (int?)reader[56];
            }
            if (reader[57] != DBNull.Value)
            {
                P0010053 = (int?)reader[57];
            }
            if (reader[58] != DBNull.Value)
            {
                P0010054 = (int?)reader[58];
            }
            if (reader[59] != DBNull.Value)
            {
                P0010055 = (int?)reader[59];
            }
            if (reader[60] != DBNull.Value)
            {
                P0010056 = (int?)reader[60];
            }
            if (reader[61] != DBNull.Value)
            {
                P0010057 = (int?)reader[61];
            }
            if (reader[62] != DBNull.Value)
            {
                P0010058 = (int?)reader[62];
            }
            if (reader[63] != DBNull.Value)
            {
                P0010059 = (int?)reader[63];
            }
            if (reader[64] != DBNull.Value)
            {
                P0010060 = (int?)reader[64];
            }
            if (reader[65] != DBNull.Value)
            {
                P0010061 = (int?)reader[65];
            }
            if (reader[66] != DBNull.Value)
            {
                P0010062 = (int?)reader[66];
            }
            if (reader[67] != DBNull.Value)
            {
                P0010063 = (int?)reader[67];
            }
            if (reader[68] != DBNull.Value)
            {
                P0010064 = (int?)reader[68];
            }
            if (reader[69] != DBNull.Value)
            {
                P0010065 = (int?)reader[69];
            }
            if (reader[70] != DBNull.Value)
            {
                P0010066 = (int?)reader[70];
            }
            if (reader[71] != DBNull.Value)
            {
                P0010067 = (int?)reader[71];
            }
            if (reader[72] != DBNull.Value)
            {
                P0010068 = (int?)reader[72];
            }
            if (reader[73] != DBNull.Value)
            {
                P0010069 = (int?)reader[73];
            }
            if (reader[74] != DBNull.Value)
            {
                P0010070 = (int?)reader[74];
            }
            if (reader[75] != DBNull.Value)
            {
                P0010071 = (int?)reader[75];
            }
            if (reader[76] != DBNull.Value)
            {
                P0020001 = (int?)reader[76];
            }
            if (reader[77] != DBNull.Value)
            {
                P0020002 = (int?)reader[77];
            }
            if (reader[78] != DBNull.Value)
            {
                P0020003 = (int?)reader[78];
            }
            if (reader[79] != DBNull.Value)
            {
                P0020004 = (int?)reader[79];
            }
            if (reader[80] != DBNull.Value)
            {
                P0020005 = (int?)reader[80];
            }
            if (reader[81] != DBNull.Value)
            {
                P0020006 = (int?)reader[81];
            }
            if (reader[82] != DBNull.Value)
            {
                P0020007 = (int?)reader[82];
            }
            if (reader[83] != DBNull.Value)
            {
                P0020008 = (int?)reader[83];
            }
            if (reader[84] != DBNull.Value)
            {
                P0020009 = (int?)reader[84];
            }
            if (reader[85] != DBNull.Value)
            {
                P0020010 = (int?)reader[85];
            }
            if (reader[86] != DBNull.Value)
            {
                P0020011 = (int?)reader[86];
            }
            if (reader[87] != DBNull.Value)
            {
                P0020012 = (int?)reader[87];
            }
            if (reader[88] != DBNull.Value)
            {
                P0020013 = (int?)reader[88];
            }
            if (reader[89] != DBNull.Value)
            {
                P0020014 = (int?)reader[89];
            }
            if (reader[90] != DBNull.Value)
            {
                P0020015 = (int?)reader[90];
            }
            if (reader[91] != DBNull.Value)
            {
                P0020016 = (int?)reader[91];
            }
            if (reader[92] != DBNull.Value)
            {
                P0020017 = (int?)reader[92];
            }
            if (reader[93] != DBNull.Value)
            {
                P0020018 = (int?)reader[93];
            }
            if (reader[94] != DBNull.Value)
            {
                P0020019 = (int?)reader[94];
            }
            if (reader[95] != DBNull.Value)
            {
                P0020020 = (int?)reader[95];
            }
            if (reader[96] != DBNull.Value)
            {
                P0020021 = (int?)reader[96];
            }
            if (reader[97] != DBNull.Value)
            {
                P0020022 = (int?)reader[97];
            }
            if (reader[98] != DBNull.Value)
            {
                P0020023 = (int?)reader[98];
            }
            if (reader[99] != DBNull.Value)
            {
                P0020024 = (int?)reader[99];
            }
            if (reader[100] != DBNull.Value)
            {
                P0020025 = (int?)reader[100];
            }
            if (reader[101] != DBNull.Value)
            {
                P0020026 = (int?)reader[101];
            }
            if (reader[102] != DBNull.Value)
            {
                P0020027 = (int?)reader[102];
            }
            if (reader[103] != DBNull.Value)
            {
                P0020028 = (int?)reader[103];
            }
            if (reader[104] != DBNull.Value)
            {
                P0020029 = (int?)reader[104];
            }
            if (reader[105] != DBNull.Value)
            {
                P0020030 = (int?)reader[105];
            }
            if (reader[106] != DBNull.Value)
            {
                P0020031 = (int?)reader[106];
            }
            if (reader[107] != DBNull.Value)
            {
                P0020032 = (int?)reader[107];
            }
            if (reader[108] != DBNull.Value)
            {
                P0020033 = (int?)reader[108];
            }
            if (reader[109] != DBNull.Value)
            {
                P0020034 = (int?)reader[109];
            }
            if (reader[110] != DBNull.Value)
            {
                P0020035 = (int?)reader[110];
            }
            if (reader[111] != DBNull.Value)
            {
                P0020036 = (int?)reader[111];
            }
            if (reader[112] != DBNull.Value)
            {
                P0020037 = (int?)reader[112];
            }
            if (reader[113] != DBNull.Value)
            {
                P0020038 = (int?)reader[113];
            }
            if (reader[114] != DBNull.Value)
            {
                P0020039 = (int?)reader[114];
            }
            if (reader[115] != DBNull.Value)
            {
                P0020040 = (int?)reader[115];
            }
            if (reader[116] != DBNull.Value)
            {
                P0020041 = (int?)reader[116];
            }
            if (reader[117] != DBNull.Value)
            {
                P0020042 = (int?)reader[117];
            }
            if (reader[118] != DBNull.Value)
            {
                P0020043 = (int?)reader[118];
            }
            if (reader[119] != DBNull.Value)
            {
                P0020044 = (int?)reader[119];
            }
            if (reader[120] != DBNull.Value)
            {
                P0020045 = (int?)reader[120];
            }
            if (reader[121] != DBNull.Value)
            {
                P0020046 = (int?)reader[121];
            }
            if (reader[122] != DBNull.Value)
            {
                P0020047 = (int?)reader[122];
            }
            if (reader[123] != DBNull.Value)
            {
                P0020048 = (int?)reader[123];
            }
            if (reader[124] != DBNull.Value)
            {
                P0020049 = (int?)reader[124];
            }
            if (reader[125] != DBNull.Value)
            {
                P0020050 = (int?)reader[125];
            }
            if (reader[126] != DBNull.Value)
            {
                P0020051 = (int?)reader[126];
            }
            if (reader[127] != DBNull.Value)
            {
                P0020052 = (int?)reader[127];
            }
            if (reader[128] != DBNull.Value)
            {
                P0020053 = (int?)reader[128];
            }
            if (reader[129] != DBNull.Value)
            {
                P0020054 = (int?)reader[129];
            }
            if (reader[130] != DBNull.Value)
            {
                P0020055 = (int?)reader[130];
            }
            if (reader[131] != DBNull.Value)
            {
                P0020056 = (int?)reader[131];
            }
            if (reader[132] != DBNull.Value)
            {
                P0020057 = (int?)reader[132];
            }
            if (reader[133] != DBNull.Value)
            {
                P0020058 = (int?)reader[133];
            }
            if (reader[134] != DBNull.Value)
            {
                P0020059 = (int?)reader[134];
            }
            if (reader[135] != DBNull.Value)
            {
                P0020060 = (int?)reader[135];
            }
            if (reader[136] != DBNull.Value)
            {
                P0020061 = (int?)reader[136];
            }
            if (reader[137] != DBNull.Value)
            {
                P0020062 = (int?)reader[137];
            }
            if (reader[138] != DBNull.Value)
            {
                P0020063 = (int?)reader[138];
            }
            if (reader[139] != DBNull.Value)
            {
                P0020064 = (int?)reader[139];
            }
            if (reader[140] != DBNull.Value)
            {
                P0020065 = (int?)reader[140];
            }
            if (reader[141] != DBNull.Value)
            {
                P0020066 = (int?)reader[141];
            }
            if (reader[142] != DBNull.Value)
            {
                P0020067 = (int?)reader[142];
            }
            if (reader[143] != DBNull.Value)
            {
                P0020068 = (int?)reader[143];
            }
            if (reader[144] != DBNull.Value)
            {
                P0020069 = (int?)reader[144];
            }
            if (reader[145] != DBNull.Value)
            {
                P0020070 = (int?)reader[145];
            }
            if (reader[146] != DBNull.Value)
            {
                P0020071 = (int?)reader[146];
            }
            if (reader[147] != DBNull.Value)
            {
                P0020072 = (int?)reader[147];
            }
            if (reader[148] != DBNull.Value)
            {
                P0020073 = (int?)reader[148];
            }
            if (reader[149] != DBNull.Value)
            {
                P0030001 = (int?)reader[149];
            }
            if (reader[150] != DBNull.Value)
            {
                P0030002 = (int?)reader[150];
            }
            if (reader[151] != DBNull.Value)
            {
                P0030003 = (int?)reader[151];
            }
            if (reader[152] != DBNull.Value)
            {
                P0030004 = (int?)reader[152];
            }
            if (reader[153] != DBNull.Value)
            {
                P0030005 = (int?)reader[153];
            }
            if (reader[154] != DBNull.Value)
            {
                P0030006 = (int?)reader[154];
            }
            if (reader[155] != DBNull.Value)
            {
                P0030007 = (int?)reader[155];
            }
            if (reader[156] != DBNull.Value)
            {
                P0030008 = (int?)reader[156];
            }
            if (reader[157] != DBNull.Value)
            {
                P0030009 = (int?)reader[157];
            }
            if (reader[158] != DBNull.Value)
            {
                P0030010 = (int?)reader[158];
            }
            if (reader[159] != DBNull.Value)
            {
                P0030011 = (int?)reader[159];
            }
            if (reader[160] != DBNull.Value)
            {
                P0030012 = (int?)reader[160];
            }
            if (reader[161] != DBNull.Value)
            {
                P0030013 = (int?)reader[161];
            }
            if (reader[162] != DBNull.Value)
            {
                P0030014 = (int?)reader[162];
            }
            if (reader[163] != DBNull.Value)
            {
                P0030015 = (int?)reader[163];
            }
            if (reader[164] != DBNull.Value)
            {
                P0030016 = (int?)reader[164];
            }
            if (reader[165] != DBNull.Value)
            {
                P0030017 = (int?)reader[165];
            }
            if (reader[166] != DBNull.Value)
            {
                P0030018 = (int?)reader[166];
            }
            if (reader[167] != DBNull.Value)
            {
                P0030019 = (int?)reader[167];
            }
            if (reader[168] != DBNull.Value)
            {
                P0030020 = (int?)reader[168];
            }
            if (reader[169] != DBNull.Value)
            {
                P0030021 = (int?)reader[169];
            }
            if (reader[170] != DBNull.Value)
            {
                P0030022 = (int?)reader[170];
            }
            if (reader[171] != DBNull.Value)
            {
                P0030023 = (int?)reader[171];
            }
            if (reader[172] != DBNull.Value)
            {
                P0030024 = (int?)reader[172];
            }
            if (reader[173] != DBNull.Value)
            {
                P0030025 = (int?)reader[173];
            }
            if (reader[174] != DBNull.Value)
            {
                P0030026 = (int?)reader[174];
            }
            if (reader[175] != DBNull.Value)
            {
                P0030027 = (int?)reader[175];
            }
            if (reader[176] != DBNull.Value)
            {
                P0030028 = (int?)reader[176];
            }
            if (reader[177] != DBNull.Value)
            {
                P0030029 = (int?)reader[177];
            }
            if (reader[178] != DBNull.Value)
            {
                P0030030 = (int?)reader[178];
            }
            if (reader[179] != DBNull.Value)
            {
                P0030031 = (int?)reader[179];
            }
            if (reader[180] != DBNull.Value)
            {
                P0030032 = (int?)reader[180];
            }
            if (reader[181] != DBNull.Value)
            {
                P0030033 = (int?)reader[181];
            }
            if (reader[182] != DBNull.Value)
            {
                P0030034 = (int?)reader[182];
            }
            if (reader[183] != DBNull.Value)
            {
                P0030035 = (int?)reader[183];
            }
            if (reader[184] != DBNull.Value)
            {
                P0030036 = (int?)reader[184];
            }
            if (reader[185] != DBNull.Value)
            {
                P0030037 = (int?)reader[185];
            }
            if (reader[186] != DBNull.Value)
            {
                P0030038 = (int?)reader[186];
            }
            if (reader[187] != DBNull.Value)
            {
                P0030039 = (int?)reader[187];
            }
            if (reader[188] != DBNull.Value)
            {
                P0030040 = (int?)reader[188];
            }
            if (reader[189] != DBNull.Value)
            {
                P0030041 = (int?)reader[189];
            }
            if (reader[190] != DBNull.Value)
            {
                P0030042 = (int?)reader[190];
            }
            if (reader[191] != DBNull.Value)
            {
                P0030043 = (int?)reader[191];
            }
            if (reader[192] != DBNull.Value)
            {
                P0030044 = (int?)reader[192];
            }
            if (reader[193] != DBNull.Value)
            {
                P0030045 = (int?)reader[193];
            }
            if (reader[194] != DBNull.Value)
            {
                P0030046 = (int?)reader[194];
            }
            if (reader[195] != DBNull.Value)
            {
                P0030047 = (int?)reader[195];
            }
            if (reader[196] != DBNull.Value)
            {
                P0030048 = (int?)reader[196];
            }
            if (reader[197] != DBNull.Value)
            {
                P0030049 = (int?)reader[197];
            }
            if (reader[198] != DBNull.Value)
            {
                P0030050 = (int?)reader[198];
            }
            if (reader[199] != DBNull.Value)
            {
                P0030051 = (int?)reader[199];
            }
            if (reader[200] != DBNull.Value)
            {
                P0030052 = (int?)reader[200];
            }
            if (reader[201] != DBNull.Value)
            {
                P0030053 = (int?)reader[201];
            }
            if (reader[202] != DBNull.Value)
            {
                P0030054 = (int?)reader[202];
            }
            if (reader[203] != DBNull.Value)
            {
                P0030055 = (int?)reader[203];
            }
            if (reader[204] != DBNull.Value)
            {
                P0030056 = (int?)reader[204];
            }
            if (reader[205] != DBNull.Value)
            {
                P0030057 = (int?)reader[205];
            }
            if (reader[206] != DBNull.Value)
            {
                P0030058 = (int?)reader[206];
            }
            if (reader[207] != DBNull.Value)
            {
                P0030059 = (int?)reader[207];
            }
            if (reader[208] != DBNull.Value)
            {
                P0030060 = (int?)reader[208];
            }
            if (reader[209] != DBNull.Value)
            {
                P0030061 = (int?)reader[209];
            }
            if (reader[210] != DBNull.Value)
            {
                P0030062 = (int?)reader[210];
            }
            if (reader[211] != DBNull.Value)
            {
                P0030063 = (int?)reader[211];
            }
            if (reader[212] != DBNull.Value)
            {
                P0030064 = (int?)reader[212];
            }
            if (reader[213] != DBNull.Value)
            {
                P0030065 = (int?)reader[213];
            }
            if (reader[214] != DBNull.Value)
            {
                P0030066 = (int?)reader[214];
            }
            if (reader[215] != DBNull.Value)
            {
                P0030067 = (int?)reader[215];
            }
            if (reader[216] != DBNull.Value)
            {
                P0030068 = (int?)reader[216];
            }
            if (reader[217] != DBNull.Value)
            {
                P0030069 = (int?)reader[217];
            }
            if (reader[218] != DBNull.Value)
            {
                P0030070 = (int?)reader[218];
            }
            if (reader[219] != DBNull.Value)
            {
                P0030071 = (int?)reader[219];
            }
            if (reader[220] != DBNull.Value)
            {
                P0040001 = (int?)reader[220];
            }
            if (reader[221] != DBNull.Value)
            {
                P0040002 = (int?)reader[221];
            }
            if (reader[222] != DBNull.Value)
            {
                P0040003 = (int?)reader[222];
            }
            if (reader[223] != DBNull.Value)
            {
                P0040004 = (int?)reader[223];
            }
            if (reader[224] != DBNull.Value)
            {
                P0040005 = (int?)reader[224];
            }
            if (reader[225] != DBNull.Value)
            {
                P0040006 = (int?)reader[225];
            }
            if (reader[226] != DBNull.Value)
            {
                P0040007 = (int?)reader[226];
            }
            if (reader[227] != DBNull.Value)
            {
                P0040008 = (int?)reader[227];
            }
            if (reader[228] != DBNull.Value)
            {
                P0040009 = (int?)reader[228];
            }
            if (reader[229] != DBNull.Value)
            {
                P0040010 = (int?)reader[229];
            }
            if (reader[230] != DBNull.Value)
            {
                P0040011 = (int?)reader[230];
            }
            if (reader[231] != DBNull.Value)
            {
                P0040012 = (int?)reader[231];
            }
            if (reader[232] != DBNull.Value)
            {
                P0040013 = (int?)reader[232];
            }
            if (reader[233] != DBNull.Value)
            {
                P0040014 = (int?)reader[233];
            }
            if (reader[234] != DBNull.Value)
            {
                P0040015 = (int?)reader[234];
            }
            if (reader[235] != DBNull.Value)
            {
                P0040016 = (int?)reader[235];
            }
            if (reader[236] != DBNull.Value)
            {
                P0040017 = (int?)reader[236];
            }
            if (reader[237] != DBNull.Value)
            {
                P0040018 = (int?)reader[237];
            }
            if (reader[238] != DBNull.Value)
            {
                P0040019 = (int?)reader[238];
            }
            if (reader[239] != DBNull.Value)
            {
                P0040020 = (int?)reader[239];
            }
            if (reader[240] != DBNull.Value)
            {
                P0040021 = (int?)reader[240];
            }
            if (reader[241] != DBNull.Value)
            {
                P0040022 = (int?)reader[241];
            }
            if (reader[242] != DBNull.Value)
            {
                P0040023 = (int?)reader[242];
            }
            if (reader[243] != DBNull.Value)
            {
                P0040024 = (int?)reader[243];
            }
            if (reader[244] != DBNull.Value)
            {
                P0040025 = (int?)reader[244];
            }
            if (reader[245] != DBNull.Value)
            {
                P0040026 = (int?)reader[245];
            }
            if (reader[246] != DBNull.Value)
            {
                P0040027 = (int?)reader[246];
            }
            if (reader[247] != DBNull.Value)
            {
                P0040028 = (int?)reader[247];
            }
            if (reader[248] != DBNull.Value)
            {
                P0040029 = (int?)reader[248];
            }
            if (reader[249] != DBNull.Value)
            {
                P0040030 = (int?)reader[249];
            }
            if (reader[250] != DBNull.Value)
            {
                P0040031 = (int?)reader[250];
            }
            if (reader[251] != DBNull.Value)
            {
                P0040032 = (int?)reader[251];
            }
            if (reader[252] != DBNull.Value)
            {
                P0040033 = (int?)reader[252];
            }
            if (reader[253] != DBNull.Value)
            {
                P0040034 = (int?)reader[253];
            }
            if (reader[254] != DBNull.Value)
            {
                P0040035 = (int?)reader[254];
            }
            if (reader[255] != DBNull.Value)
            {
                P0040036 = (int?)reader[255];
            }
            if (reader[256] != DBNull.Value)
            {
                P0040037 = (int?)reader[256];
            }
            if (reader[257] != DBNull.Value)
            {
                P0040038 = (int?)reader[257];
            }
            if (reader[258] != DBNull.Value)
            {
                P0040039 = (int?)reader[258];
            }
            if (reader[259] != DBNull.Value)
            {
                P0040040 = (int?)reader[259];
            }
            if (reader[260] != DBNull.Value)
            {
                P0040041 = (int?)reader[260];
            }
            if (reader[261] != DBNull.Value)
            {
                P0040042 = (int?)reader[261];
            }
            if (reader[262] != DBNull.Value)
            {
                P0040043 = (int?)reader[262];
            }
            if (reader[263] != DBNull.Value)
            {
                P0040044 = (int?)reader[263];
            }
            if (reader[264] != DBNull.Value)
            {
                P0040045 = (int?)reader[264];
            }
            if (reader[265] != DBNull.Value)
            {
                P0040046 = (int?)reader[265];
            }
            if (reader[266] != DBNull.Value)
            {
                P0040047 = (int?)reader[266];
            }
            if (reader[267] != DBNull.Value)
            {
                P0040048 = (int?)reader[267];
            }
            if (reader[268] != DBNull.Value)
            {
                P0040049 = (int?)reader[268];
            }
            if (reader[269] != DBNull.Value)
            {
                P0040050 = (int?)reader[269];
            }
            if (reader[270] != DBNull.Value)
            {
                P0040051 = (int?)reader[270];
            }
            if (reader[271] != DBNull.Value)
            {
                P0040052 = (int?)reader[271];
            }
            if (reader[272] != DBNull.Value)
            {
                P0040053 = (int?)reader[272];
            }
            if (reader[273] != DBNull.Value)
            {
                P0040054 = (int?)reader[273];
            }
            if (reader[274] != DBNull.Value)
            {
                P0040055 = (int?)reader[274];
            }
            if (reader[275] != DBNull.Value)
            {
                P0040056 = (int?)reader[275];
            }
            if (reader[276] != DBNull.Value)
            {
                P0040057 = (int?)reader[276];
            }
            if (reader[277] != DBNull.Value)
            {
                P0040058 = (int?)reader[277];
            }
            if (reader[278] != DBNull.Value)
            {
                P0040059 = (int?)reader[278];
            }
            if (reader[279] != DBNull.Value)
            {
                P0040060 = (int?)reader[279];
            }
            if (reader[280] != DBNull.Value)
            {
                P0040061 = (int?)reader[280];
            }
            if (reader[281] != DBNull.Value)
            {
                P0040062 = (int?)reader[281];
            }
            if (reader[282] != DBNull.Value)
            {
                P0040063 = (int?)reader[282];
            }
            if (reader[283] != DBNull.Value)
            {
                P0040064 = (int?)reader[283];
            }
            if (reader[284] != DBNull.Value)
            {
                P0040065 = (int?)reader[284];
            }
            if (reader[285] != DBNull.Value)
            {
                P0040066 = (int?)reader[285];
            }
            if (reader[286] != DBNull.Value)
            {
                P0040067 = (int?)reader[286];
            }
            if (reader[287] != DBNull.Value)
            {
                P0040068 = (int?)reader[287];
            }
            if (reader[288] != DBNull.Value)
            {
                P0040069 = (int?)reader[288];
            }
            if (reader[289] != DBNull.Value)
            {
                P0040070 = (int?)reader[289];
            }
            if (reader[290] != DBNull.Value)
            {
                P0040071 = (int?)reader[290];
            }
            if (reader[291] != DBNull.Value)
            {
                P0040072 = (int?)reader[291];
            }
            if (reader[292] != DBNull.Value)
            {
                P0040073 = (int?)reader[292];
            }
            if (reader[293] != DBNull.Value)
            {
                H0010001 = (int?)reader[293];
            }
            if (reader[294] != DBNull.Value)
            {
                H0010002 = (int?)reader[294];
            }
            if (reader[295] != DBNull.Value)
            {
                H0010003 = (int?)reader[295];
            }
        }
        #endregion Constructors
    }
}
