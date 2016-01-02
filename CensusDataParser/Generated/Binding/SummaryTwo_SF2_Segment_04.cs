#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2016 11:54 AM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryTwo_SF2_Segment_04.cs
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

    public class SummaryTwo_SF2_Segment_04 : BaseModel
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
        [Column("PCT0050001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total (400-479, 481-499):", ShortName = "Total (400-479, 481-499):", Order = 5)]
        public int? PCT0050001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian Indian (400-401)", ShortName = "Asian Indian (400-401)", Order = 6)]
        public int? PCT0050002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Bangladeshi (402)", ShortName = "Bangladeshi (402)", Order = 7)]
        public int? PCT0050003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Bhutanese (403)", ShortName = "Bhutanese (403)", Order = 8)]
        public int? PCT0050004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Burmese (404)", ShortName = "Burmese (404)", Order = 9)]
        public int? PCT0050005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Cambodian (405-409)", ShortName = "Cambodian (405-409)", Order = 10)]
        public int? PCT0050006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Chinese (except Taiwanese) (410-411)", ShortName = "Chinese (except Taiwanese) (410-411)", Order = 11)]
        public int? PCT0050007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Filipino (420-421)", ShortName = "Filipino (420-421)", Order = 12)]
        public int? PCT0050008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hmong (422)", ShortName = "Hmong (422)", Order = 13)]
        public int? PCT0050009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Indonesian (423-429)", ShortName = "Indonesian (423-429)", Order = 14)]
        public int? PCT0050010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Japanese (430-439)", ShortName = "Japanese (430-439)", Order = 15)]
        public int? PCT0050011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Korean (440-441)", ShortName = "Korean (440-441)", Order = 16)]
        public int? PCT0050012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Laotian (442)", ShortName = "Laotian (442)", Order = 17)]
        public int? PCT0050013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Malaysian (443)", ShortName = "Malaysian (443)", Order = 18)]
        public int? PCT0050014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nepalese (472)", ShortName = "Nepalese (472)", Order = 19)]
        public int? PCT0050015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Pakistani (445)", ShortName = "Pakistani (445)", Order = 20)]
        public int? PCT0050016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050017", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Sri Lankan (446)", ShortName = "Sri Lankan (446)", Order = 21)]
        public int? PCT0050017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050018", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Taiwanese (412-419)", ShortName = "Taiwanese (412-419)", Order = 22)]
        public int? PCT0050018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050019", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Thai (447-449)", ShortName = "Thai (447-449)", Order = 23)]
        public int? PCT0050019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050020", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Vietnamese (450-459)", ShortName = "Vietnamese (450-459)", Order = 24)]
        public int? PCT0050020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050021", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Asian, specified (444, 465, 470-471, 473-479)", ShortName = "Other Asian, specified (444, 465, 470-471, 473-479)", Order = 25)]
        public int? PCT0050021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050022", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Asian, not specified (460-464, 466-469, 481-499)", ShortName = "Other Asian, not specified (460-464, 466-469, 481-499)", Order = 26)]
        public int? PCT0050022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050023", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 27)]
        public int? PCT0050023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050024", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 28)]
        public int? PCT0050024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050025", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 29)]
        public int? PCT0050025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050026", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 30)]
        public int? PCT0050026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050027", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 31)]
        public int? PCT0050027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050028", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 32)]
        public int? PCT0050028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050029", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 33)]
        public int? PCT0050029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050030", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 34)]
        public int? PCT0050030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050031", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 35)]
        public int? PCT0050031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050032", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 36)]
        public int? PCT0050032 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050033", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 37)]
        public int? PCT0050033 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050034", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 38)]
        public int? PCT0050034 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050035", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 39)]
        public int? PCT0050035 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050036", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 40)]
        public int? PCT0050036 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050037", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 41)]
        public int? PCT0050037 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050038", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 42)]
        public int? PCT0050038 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050039", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 43)]
        public int? PCT0050039 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050040", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 44)]
        public int? PCT0050040 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050041", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 45)]
        public int? PCT0050041 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050042", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 46)]
        public int? PCT0050042 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050043", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 47)]
        public int? PCT0050043 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050044", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 48)]
        public int? PCT0050044 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050045", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 49)]
        public int? PCT0050045 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050046", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 50)]
        public int? PCT0050046 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050047", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 51)]
        public int? PCT0050047 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050048", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 52)]
        public int? PCT0050048 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050049", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 53)]
        public int? PCT0050049 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060001", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total Asian categories tallied (400-499) & (400-499):", ShortName = "Total Asian categories tallied (400-499) & (400-499):", Order = 54)]
        public int? PCT0060001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060002", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian Indian (400-401) & (400-499)", ShortName = "Asian Indian (400-401) & (400-499)", Order = 55)]
        public int? PCT0060002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060003", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Bangladeshi (402) & (400-499)", ShortName = "Bangladeshi (402) & (400-499)", Order = 56)]
        public int? PCT0060003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070001", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total Asian categories tallied (400-499) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Total Asian categories tallied (400-499) & (100-299) or (300, A01-Z99) or (400-999):", Order = 57)]
        public double? PCT0070001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070002", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian Indian (400-401) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Asian Indian (400-401) & (100-299) or (300, A01-Z99) or (400-999)", Order = 58)]
        public double? PCT0070002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070003", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Bangladeshi (402) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Bangladeshi (402) & (100-299) or (300, A01-Z99) or (400-999)", Order = 59)]
        public double? PCT0070003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080001", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total (500-549, 551-599):", ShortName = "Total (500-549, 551-599):", Order = 60)]
        public int? PCT0080001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080002", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Polynesian (500-519):", ShortName = "Polynesian (500-519):", Order = 61)]
        public int? PCT0080002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080003", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian (500-503)", ShortName = "Native Hawaiian (500-503)", Order = 62)]
        public int? PCT0080003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080004", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Samoan (510-511)", ShortName = "Samoan (510-511)", Order = 63)]
        public int? PCT0080004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080005", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Tongan (513)", ShortName = "Tongan (513)", Order = 64)]
        public int? PCT0080005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080006", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Polynesian (504-509, 512, 514-519)", ShortName = "Other Polynesian (504-509, 512, 514-519)", Order = 65)]
        public int? PCT0080006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080007", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Micronesian (520-529, 531-541):", ShortName = "Micronesian (520-529, 531-541):", Order = 66)]
        public int? PCT0080007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080008", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Guamanian or Chamorro (520-522)", ShortName = "Guamanian or Chamorro (520-522)", Order = 67)]
        public int? PCT0080008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080009", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Marshallese (532)", ShortName = "Marshallese (532)", Order = 68)]
        public int? PCT0080009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090001", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total Native Hawaiian and Other Pacific Islander categories tallied (500-599) & (500-599):", ShortName = "Total Native Hawaiian and Other Pacific Islander categories tallied (500-599) & (500-599):", Order = 69)]
        public int? PCT0090001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090002", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Polynesian (500-519) & (500-599):", ShortName = "Polynesian (500-519) & (500-599):", Order = 70)]
        public int? PCT0090002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090003", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian (500-503) & (500-599)", ShortName = "Native Hawaiian (500-503) & (500-599)", Order = 71)]
        public int? PCT0090003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090004", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Samoan (510-511) & (500-599)", ShortName = "Samoan (510-511) & (500-599)", Order = 72)]
        public int? PCT0090004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090005", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Tongan (513) & (500-599)", ShortName = "Tongan (513) & (500-599)", Order = 73)]
        public int? PCT0090005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090006", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Polynesian (504-509, 512, 514-519) & (500-599)", ShortName = "Other Polynesian (504-509, 512, 514-519) & (500-599)", Order = 74)]
        public int? PCT0090006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090007", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Micronesian (520-529, 531-541) & (500-599):", ShortName = "Micronesian (520-529, 531-541) & (500-599):", Order = 75)]
        public int? PCT0090007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090008", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Guamanian or Chamorro (520-522) & (500-599)", ShortName = "Guamanian or Chamorro (520-522) & (500-599)", Order = 76)]
        public int? PCT0090008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090009", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Marshallese (532) & (500-599)", ShortName = "Marshallese (532) & (500-599)", Order = 77)]
        public int? PCT0090009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090010", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Micronesian (523-529, 531, 533-541) & (500-599)", ShortName = "Other Micronesian (523-529, 531, 533-541) & (500-599)", Order = 78)]
        public int? PCT0090010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090011", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Melanesian (542-546) & (500-599):", ShortName = "Melanesian (542-546) & (500-599):", Order = 79)]
        public int? PCT0090011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090012", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Fijian (542) & (500-599)", ShortName = "Fijian (542) & (500-599)", Order = 80)]
        public int? PCT0090012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090013", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Melanesian (543-546) & (500-599)", ShortName = "Other Melanesian (543-546) & (500-599)", Order = 81)]
        public int? PCT0090013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090014", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Pacific Islander, not specified (530, 547-599) & (500-599)", ShortName = "Other Pacific Islander, not specified (530, 547-599) & (500-599)", Order = 82)]
        public int? PCT0090014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090015", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 83)]
        public int? PCT0090015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090016", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 84)]
        public int? PCT0090016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090017", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 85)]
        public int? PCT0090017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090018", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder", ShortName = "Male householder", Order = 86)]
        public int? PCT0090018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090019", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder", ShortName = "Female householder", Order = 87)]
        public int? PCT0090019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100001", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total Native Hawaiian and Other Pacific Islander categories tallied (500-599) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Total Native Hawaiian and Other Pacific Islander categories tallied (500-599) & (100-299) or (300, A01-Z99) or (400-999):", Order = 88)]
        public int? PCT0100001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100002", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Polynesian (500-519) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Polynesian (500-519) & (100-299) or (300, A01-Z99) or (400-999):", Order = 89)]
        public int? PCT0100002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100003", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian (500-503) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Native Hawaiian (500-503) & (100-299) or (300, A01-Z99) or (400-999)", Order = 90)]
        public int? PCT0100003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100004", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Samoan (510-511) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Samoan (510-511) & (100-299) or (300, A01-Z99) or (400-999)", Order = 91)]
        public int? PCT0100004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100005", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Tongan (513) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Tongan (513) & (100-299) or (300, A01-Z99) or (400-999)", Order = 92)]
        public int? PCT0100005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100006", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Polynesian (504-509, 512, 514-519) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Other Polynesian (504-509, 512, 514-519) & (100-299) or (300, A01-Z99) or (400-999)", Order = 93)]
        public int? PCT0100006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100007", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Micronesian (520-529, 531-541) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Micronesian (520-529, 531-541) & (100-299) or (300, A01-Z99) or (400-999):", Order = 94)]
        public int? PCT0100007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100008", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Guamanian or Chamorro (520-522) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Guamanian or Chamorro (520-522) & (100-299) or (300, A01-Z99) or (400-999)", Order = 95)]
        public int? PCT0100008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100009", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Marshallese (532) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Marshallese (532) & (100-299) or (300, A01-Z99) or (400-999)", Order = 96)]
        public int? PCT0100009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100010", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Micronesian (523-529, 531, 533-541)  & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Other Micronesian (523-529, 531, 533-541)  & (100-299) or (300, A01-Z99) or (400-999)", Order = 97)]
        public int? PCT0100010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100011", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Melanesian (542-546) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Melanesian (542-546) & (100-299) or (300, A01-Z99) or (400-999):", Order = 98)]
        public int? PCT0100011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100012", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Fijian (542) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Fijian (542) & (100-299) or (300, A01-Z99) or (400-999)", Order = 99)]
        public int? PCT0100012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100013", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Melanesian (543-546) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Other Melanesian (543-546) & (100-299) or (300, A01-Z99) or (400-999)", Order = 100)]
        public int? PCT0100013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100014", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Pacific Islander, not specified (530, 547-599) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Other Pacific Islander, not specified (530, 547-599) & (100-299) or (300, A01-Z99) or (400-999)", Order = 101)]
        public int? PCT0100014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100015", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 102)]
        public int? PCT0100015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100016", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 103)]
        public int? PCT0100016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100017", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 104)]
        public int? PCT0100017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100018", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 105)]
        public int? PCT0100018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100019", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 106)]
        public int? PCT0100019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100020", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 107)]
        public int? PCT0100020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100021", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 108)]
        public int? PCT0100021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100022", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 109)]
        public int? PCT0100022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100023", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 110)]
        public int? PCT0100023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100024", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 111)]
        public int? PCT0100024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100025", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 112)]
        public int? PCT0100025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100026", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Households with no people under 18 years:", ShortName = "Households with no people under 18 years:", Order = 113)]
        public int? PCT0100026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100027", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 114)]
        public int? PCT0100027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100028", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 115)]
        public int? PCT0100028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100029", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 116)]
        public int? PCT0100029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100030", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 117)]
        public int? PCT0100030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100031", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 118)]
        public int? PCT0100031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100032", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 119)]
        public int? PCT0100032 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100033", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder", ShortName = "Male householder", Order = 120)]
        public int? PCT0100033 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100034", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder", ShortName = "Female householder", Order = 121)]
        public int? PCT0100034 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110001", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 122)]
        public int? PCT0110001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110002", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not Hispanic or Latino (001-199, 300-999)", ShortName = "Not Hispanic or Latino (001-199, 300-999)", Order = 123)]
        public int? PCT0110002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110003", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hispanic or Latino (200-299):", ShortName = "Hispanic or Latino (200-299):", Order = 124)]
        public int? PCT0110003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110004", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Mexican (210-220)", ShortName = "Mexican (210-220)", Order = 125)]
        public int? PCT0110004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110005", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Puerto Rican (260-269)", ShortName = "Puerto Rican (260-269)", Order = 126)]
        public int? PCT0110005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110006", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Cuban (270-274)", ShortName = "Cuban (270-274)", Order = 127)]
        public int? PCT0110006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110007", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Dominican (275-279)", ShortName = "Dominican (275-279)", Order = 128)]
        public int? PCT0110007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110008", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Central American (excluding Mexican) (221-230):", ShortName = "Central American (excluding Mexican) (221-230):", Order = 129)]
        public int? PCT0110008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110009", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Costa Rican (221)", ShortName = "Costa Rican (221)", Order = 130)]
        public int? PCT0110009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110010", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Guatemalan (222)", ShortName = "Guatemalan (222)", Order = 131)]
        public int? PCT0110010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110011", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Honduran (223)", ShortName = "Honduran (223)", Order = 132)]
        public int? PCT0110011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110012", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nicaraguan (224)", ShortName = "Nicaraguan (224)", Order = 133)]
        public int? PCT0110012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110013", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Panamanian (225)", ShortName = "Panamanian (225)", Order = 134)]
        public int? PCT0110013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110014", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Salvadoran (226)", ShortName = "Salvadoran (226)", Order = 135)]
        public int? PCT0110014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110015", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Central American (227-230)", ShortName = "Other Central American (227-230)", Order = 136)]
        public int? PCT0110015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110016", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "South American (231-249):", ShortName = "South American (231-249):", Order = 137)]
        public int? PCT0110016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110017", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Argentinean (231)", ShortName = "Argentinean (231)", Order = 138)]
        public int? PCT0110017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110018", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Bolivian (232)", ShortName = "Bolivian (232)", Order = 139)]
        public int? PCT0110018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110019", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Chilean (233)", ShortName = "Chilean (233)", Order = 140)]
        public int? PCT0110019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110020", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Colombian (234)", ShortName = "Colombian (234)", Order = 141)]
        public int? PCT0110020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110021", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Ecuadorian (235)", ShortName = "Ecuadorian (235)", Order = 142)]
        public int? PCT0110021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110022", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Paraguayan (236)", ShortName = "Paraguayan (236)", Order = 143)]
        public int? PCT0110022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110023", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Peruvian (237)", ShortName = "Peruvian (237)", Order = 144)]
        public int? PCT0110023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110024", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Uruguayan (238)", ShortName = "Uruguayan (238)", Order = 145)]
        public int? PCT0110024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110025", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Venezuelan (239)", ShortName = "Venezuelan (239)", Order = 146)]
        public int? PCT0110025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110026", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other South American (240-249)", ShortName = "Other South American (240-249)", Order = 147)]
        public int? PCT0110026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110027", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Hispanic or Latino (200-209, 250-259, 280-299):", ShortName = "Other Hispanic or Latino (200-209, 250-259, 280-299):", Order = 148)]
        public int? PCT0110027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110028", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spaniard (200-209)", ShortName = "Spaniard (200-209)", Order = 149)]
        public int? PCT0110028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110029", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spanish (282)", ShortName = "Spanish (282)", Order = 150)]
        public int? PCT0110029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110030", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spanish American (286)", ShortName = "Spanish American (286)", Order = 151)]
        public int? PCT0110030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110031", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "All other Hispanic or Latino (250-259, 280-281, 283-285, 287-299)", ShortName = "All other Hispanic or Latino (250-259, 280-281, 283-285, 287-299)", Order = 152)]
        public int? PCT0110031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120001", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 153)]
        public int? PCT0120001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120002", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 154)]
        public int? PCT0120002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120003", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 1 year", ShortName = "Under 1 year", Order = 155)]
        public int? PCT0120003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120004", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1 year", ShortName = "1 year", Order = 156)]
        public int? PCT0120004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120005", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2 years", ShortName = "2 years", Order = 157)]
        public int? PCT0120005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120006", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 years", ShortName = "3 years", Order = 158)]
        public int? PCT0120006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120007", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4 years", ShortName = "4 years", Order = 159)]
        public int? PCT0120007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120008", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 160)]
        public int? PCT0120008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120009", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 years", ShortName = "6 years", Order = 161)]
        public int? PCT0120009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120010", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7 years", ShortName = "7 years", Order = 162)]
        public int? PCT0120010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120011", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "8 years", ShortName = "8 years", Order = 163)]
        public int? PCT0120011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120012", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "9 years", ShortName = "9 years", Order = 164)]
        public int? PCT0120012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120013", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 years", ShortName = "10 years", Order = 165)]
        public int? PCT0120013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120014", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "11 years", ShortName = "11 years", Order = 166)]
        public int? PCT0120014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120015", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 years", ShortName = "12 years", Order = 167)]
        public int? PCT0120015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120016", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "13 years", ShortName = "13 years", Order = 168)]
        public int? PCT0120016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120017", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "14 years", ShortName = "14 years", Order = 169)]
        public int? PCT0120017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120018", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 years", ShortName = "15 years", Order = 170)]
        public int? PCT0120018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120019", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "16 years", ShortName = "16 years", Order = 171)]
        public int? PCT0120019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120020", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "17 years", ShortName = "17 years", Order = 172)]
        public int? PCT0120020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120021", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years", ShortName = "18 years", Order = 173)]
        public int? PCT0120021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130001", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 174)]
        public int? PCT0130001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130002", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 175)]
        public int? PCT0130002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130003", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 176)]
        public int? PCT0130003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130004", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 177)]
        public int? PCT0130004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130005", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 178)]
        public int? PCT0130005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130006", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 179)]
        public int? PCT0130006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130007", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 180)]
        public int? PCT0130007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130008", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 181)]
        public int? PCT0130008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130009", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 182)]
        public int? PCT0130009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130010", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 183)]
        public int? PCT0130010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130011", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 184)]
        public int? PCT0130011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130012", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 185)]
        public int? PCT0130012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130013", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 186)]
        public int? PCT0130013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130014", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 187)]
        public int? PCT0130014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130015", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 188)]
        public int? PCT0130015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140001", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 189)]
        public int? PCT0140001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140002", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Household has three or more generations", ShortName = "Household has three or more generations", Order = 190)]
        public int? PCT0140002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140003", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Household does not have three or more generations", ShortName = "Household does not have three or more generations", Order = 191)]
        public int? PCT0140003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140004", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-or-more-person household:", ShortName = "2-or-more-person household:", Order = 192)]
        public int? PCT0140004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140005", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households", ShortName = "Family households", Order = 193)]
        public int? PCT0140005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140006", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households", ShortName = "Nonfamily households", Order = 194)]
        public int? PCT0140006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140007", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Households with no people 60 years and over:", ShortName = "Households with no people 60 years and over:", Order = 195)]
        public int? PCT0140007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140008", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 196)]
        public int? PCT0140008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140009", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-or-more-person household:", ShortName = "2-or-more-person household:", Order = 197)]
        public int? PCT0140009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140010", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households", ShortName = "Family households", Order = 198)]
        public int? PCT0140010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140011", Order = 199)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households", ShortName = "Nonfamily households", Order = 199)]
        public int? PCT0140011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150001", Order = 200)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 200)]
        public int? PCT0150001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150002", Order = 201)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife households:", ShortName = "Husband-wife households:", Order = 201)]
        public int? PCT0150002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150003", Order = 202)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 202)]
        public int? PCT0150003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150004", Order = 203)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 203)]
        public int? PCT0150004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150005", Order = 204)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 204)]
        public int? PCT0150005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150006", Order = 205)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 205)]
        public int? PCT0150006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150007", Order = 206)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 206)]
        public int? PCT0150007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150008", Order = 207)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 207)]
        public int? PCT0150008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150009", Order = 208)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 208)]
        public int? PCT0150009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150010", Order = 209)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 209)]
        public int? PCT0150010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150011", Order = 210)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 210)]
        public int? PCT0150011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160001", Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 211)]
        public int? PCT0160001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160002", Order = 212)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 212)]
        public int? PCT0160002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160003", Order = 213)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 213)]
        public int? PCT0160003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160004", Order = 214)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With no children under 18 years", ShortName = "With no children under 18 years", Order = 214)]
        public int? PCT0160004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160005", Order = 215)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With one child under 18 years", ShortName = "With one child under 18 years", Order = 215)]
        public int? PCT0160005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160006", Order = 216)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With two children under 18 years", ShortName = "With two children under 18 years", Order = 216)]
        public int? PCT0160006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160007", Order = 217)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With three children under 18 years", ShortName = "With three children under 18 years", Order = 217)]
        public int? PCT0160007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160008", Order = 218)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With four or more children under 18 years", ShortName = "With four or more children under 18 years", Order = 218)]
        public int? PCT0160008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160009", Order = 219)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 219)]
        public int? PCT0160009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160010", Order = 220)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With no children under 18 years", ShortName = "With no children under 18 years", Order = 220)]
        public int? PCT0160010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160011", Order = 221)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With one child under 18 years", ShortName = "With one child under 18 years", Order = 221)]
        public int? PCT0160011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0170001", Order = 222)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 222)]
        public int? PCT0170001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0170002", Order = 223)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried partner of householder present:", ShortName = "Unmarried partner of householder present:", Order = 223)]
        public int? PCT0170002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0170003", Order = 224)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 224)]
        public int? PCT0170003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0180001", Order = 225)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 225)]
        public int? PCT0180001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0180002", Order = 226)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 226)]
        public int? PCT0180002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0180003", Order = 227)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone:", ShortName = "Living alone:", Order = 227)]
        public int? PCT0180003 { get; set; }
        #endregion Properties

        #region Constructors
        public SummaryTwo_SF2_Segment_04(string csvLine) : base(csvLine) { }

        public SummaryTwo_SF2_Segment_04(string[] values) : base(values) { }

        public SummaryTwo_SF2_Segment_04(OleDbDataReader reader, CensusFileType fileType)
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
                PCT0050001 = (int?)reader[5];
            }
            if (reader[6] != DBNull.Value)
            {
                PCT0050002 = (int?)reader[6];
            }
            if (reader[7] != DBNull.Value)
            {
                PCT0050003 = (int?)reader[7];
            }
            if (reader[8] != DBNull.Value)
            {
                PCT0050004 = (int?)reader[8];
            }
            if (reader[9] != DBNull.Value)
            {
                PCT0050005 = (int?)reader[9];
            }
            if (reader[10] != DBNull.Value)
            {
                PCT0050006 = (int?)reader[10];
            }
            if (reader[11] != DBNull.Value)
            {
                PCT0050007 = (int?)reader[11];
            }
            if (reader[12] != DBNull.Value)
            {
                PCT0050008 = (int?)reader[12];
            }
            if (reader[13] != DBNull.Value)
            {
                PCT0050009 = (int?)reader[13];
            }
            if (reader[14] != DBNull.Value)
            {
                PCT0050010 = (int?)reader[14];
            }
            if (reader[15] != DBNull.Value)
            {
                PCT0050011 = (int?)reader[15];
            }
            if (reader[16] != DBNull.Value)
            {
                PCT0050012 = (int?)reader[16];
            }
            if (reader[17] != DBNull.Value)
            {
                PCT0050013 = (int?)reader[17];
            }
            if (reader[18] != DBNull.Value)
            {
                PCT0050014 = (int?)reader[18];
            }
            if (reader[19] != DBNull.Value)
            {
                PCT0050015 = (int?)reader[19];
            }
            if (reader[20] != DBNull.Value)
            {
                PCT0050016 = (int?)reader[20];
            }
            if (reader[21] != DBNull.Value)
            {
                PCT0050017 = (int?)reader[21];
            }
            if (reader[22] != DBNull.Value)
            {
                PCT0050018 = (int?)reader[22];
            }
            if (reader[23] != DBNull.Value)
            {
                PCT0050019 = (int?)reader[23];
            }
            if (reader[24] != DBNull.Value)
            {
                PCT0050020 = (int?)reader[24];
            }
            if (reader[25] != DBNull.Value)
            {
                PCT0050021 = (int?)reader[25];
            }
            if (reader[26] != DBNull.Value)
            {
                PCT0050022 = (int?)reader[26];
            }
            if (reader[27] != DBNull.Value)
            {
                PCT0050023 = (int?)reader[27];
            }
            if (reader[28] != DBNull.Value)
            {
                PCT0050024 = (int?)reader[28];
            }
            if (reader[29] != DBNull.Value)
            {
                PCT0050025 = (int?)reader[29];
            }
            if (reader[30] != DBNull.Value)
            {
                PCT0050026 = (int?)reader[30];
            }
            if (reader[31] != DBNull.Value)
            {
                PCT0050027 = (int?)reader[31];
            }
            if (reader[32] != DBNull.Value)
            {
                PCT0050028 = (int?)reader[32];
            }
            if (reader[33] != DBNull.Value)
            {
                PCT0050029 = (int?)reader[33];
            }
            if (reader[34] != DBNull.Value)
            {
                PCT0050030 = (int?)reader[34];
            }
            if (reader[35] != DBNull.Value)
            {
                PCT0050031 = (int?)reader[35];
            }
            if (reader[36] != DBNull.Value)
            {
                PCT0050032 = (int?)reader[36];
            }
            if (reader[37] != DBNull.Value)
            {
                PCT0050033 = (int?)reader[37];
            }
            if (reader[38] != DBNull.Value)
            {
                PCT0050034 = (int?)reader[38];
            }
            if (reader[39] != DBNull.Value)
            {
                PCT0050035 = (int?)reader[39];
            }
            if (reader[40] != DBNull.Value)
            {
                PCT0050036 = (int?)reader[40];
            }
            if (reader[41] != DBNull.Value)
            {
                PCT0050037 = (int?)reader[41];
            }
            if (reader[42] != DBNull.Value)
            {
                PCT0050038 = (int?)reader[42];
            }
            if (reader[43] != DBNull.Value)
            {
                PCT0050039 = (int?)reader[43];
            }
            if (reader[44] != DBNull.Value)
            {
                PCT0050040 = (int?)reader[44];
            }
            if (reader[45] != DBNull.Value)
            {
                PCT0050041 = (int?)reader[45];
            }
            if (reader[46] != DBNull.Value)
            {
                PCT0050042 = (int?)reader[46];
            }
            if (reader[47] != DBNull.Value)
            {
                PCT0050043 = (int?)reader[47];
            }
            if (reader[48] != DBNull.Value)
            {
                PCT0050044 = (int?)reader[48];
            }
            if (reader[49] != DBNull.Value)
            {
                PCT0050045 = (int?)reader[49];
            }
            if (reader[50] != DBNull.Value)
            {
                PCT0050046 = (int?)reader[50];
            }
            if (reader[51] != DBNull.Value)
            {
                PCT0050047 = (int?)reader[51];
            }
            if (reader[52] != DBNull.Value)
            {
                PCT0050048 = (int?)reader[52];
            }
            if (reader[53] != DBNull.Value)
            {
                PCT0050049 = (int?)reader[53];
            }
            if (reader[54] != DBNull.Value)
            {
                PCT0060001 = (int?)reader[54];
            }
            if (reader[55] != DBNull.Value)
            {
                PCT0060002 = (int?)reader[55];
            }
            if (reader[56] != DBNull.Value)
            {
                PCT0060003 = (int?)reader[56];
            }
            if (reader[57] != DBNull.Value)
            {
                PCT0070001 = (double?)reader[57];
            }
            if (reader[58] != DBNull.Value)
            {
                PCT0070002 = (double?)reader[58];
            }
            if (reader[59] != DBNull.Value)
            {
                PCT0070003 = (double?)reader[59];
            }
            if (reader[60] != DBNull.Value)
            {
                PCT0080001 = (int?)reader[60];
            }
            if (reader[61] != DBNull.Value)
            {
                PCT0080002 = (int?)reader[61];
            }
            if (reader[62] != DBNull.Value)
            {
                PCT0080003 = (int?)reader[62];
            }
            if (reader[63] != DBNull.Value)
            {
                PCT0080004 = (int?)reader[63];
            }
            if (reader[64] != DBNull.Value)
            {
                PCT0080005 = (int?)reader[64];
            }
            if (reader[65] != DBNull.Value)
            {
                PCT0080006 = (int?)reader[65];
            }
            if (reader[66] != DBNull.Value)
            {
                PCT0080007 = (int?)reader[66];
            }
            if (reader[67] != DBNull.Value)
            {
                PCT0080008 = (int?)reader[67];
            }
            if (reader[68] != DBNull.Value)
            {
                PCT0080009 = (int?)reader[68];
            }
            if (reader[69] != DBNull.Value)
            {
                PCT0090001 = (int?)reader[69];
            }
            if (reader[70] != DBNull.Value)
            {
                PCT0090002 = (int?)reader[70];
            }
            if (reader[71] != DBNull.Value)
            {
                PCT0090003 = (int?)reader[71];
            }
            if (reader[72] != DBNull.Value)
            {
                PCT0090004 = (int?)reader[72];
            }
            if (reader[73] != DBNull.Value)
            {
                PCT0090005 = (int?)reader[73];
            }
            if (reader[74] != DBNull.Value)
            {
                PCT0090006 = (int?)reader[74];
            }
            if (reader[75] != DBNull.Value)
            {
                PCT0090007 = (int?)reader[75];
            }
            if (reader[76] != DBNull.Value)
            {
                PCT0090008 = (int?)reader[76];
            }
            if (reader[77] != DBNull.Value)
            {
                PCT0090009 = (int?)reader[77];
            }
            if (reader[78] != DBNull.Value)
            {
                PCT0090010 = (int?)reader[78];
            }
            if (reader[79] != DBNull.Value)
            {
                PCT0090011 = (int?)reader[79];
            }
            if (reader[80] != DBNull.Value)
            {
                PCT0090012 = (int?)reader[80];
            }
            if (reader[81] != DBNull.Value)
            {
                PCT0090013 = (int?)reader[81];
            }
            if (reader[82] != DBNull.Value)
            {
                PCT0090014 = (int?)reader[82];
            }
            if (reader[83] != DBNull.Value)
            {
                PCT0090015 = (int?)reader[83];
            }
            if (reader[84] != DBNull.Value)
            {
                PCT0090016 = (int?)reader[84];
            }
            if (reader[85] != DBNull.Value)
            {
                PCT0090017 = (int?)reader[85];
            }
            if (reader[86] != DBNull.Value)
            {
                PCT0090018 = (int?)reader[86];
            }
            if (reader[87] != DBNull.Value)
            {
                PCT0090019 = (int?)reader[87];
            }
            if (reader[88] != DBNull.Value)
            {
                PCT0100001 = (int?)reader[88];
            }
            if (reader[89] != DBNull.Value)
            {
                PCT0100002 = (int?)reader[89];
            }
            if (reader[90] != DBNull.Value)
            {
                PCT0100003 = (int?)reader[90];
            }
            if (reader[91] != DBNull.Value)
            {
                PCT0100004 = (int?)reader[91];
            }
            if (reader[92] != DBNull.Value)
            {
                PCT0100005 = (int?)reader[92];
            }
            if (reader[93] != DBNull.Value)
            {
                PCT0100006 = (int?)reader[93];
            }
            if (reader[94] != DBNull.Value)
            {
                PCT0100007 = (int?)reader[94];
            }
            if (reader[95] != DBNull.Value)
            {
                PCT0100008 = (int?)reader[95];
            }
            if (reader[96] != DBNull.Value)
            {
                PCT0100009 = (int?)reader[96];
            }
            if (reader[97] != DBNull.Value)
            {
                PCT0100010 = (int?)reader[97];
            }
            if (reader[98] != DBNull.Value)
            {
                PCT0100011 = (int?)reader[98];
            }
            if (reader[99] != DBNull.Value)
            {
                PCT0100012 = (int?)reader[99];
            }
            if (reader[100] != DBNull.Value)
            {
                PCT0100013 = (int?)reader[100];
            }
            if (reader[101] != DBNull.Value)
            {
                PCT0100014 = (int?)reader[101];
            }
            if (reader[102] != DBNull.Value)
            {
                PCT0100015 = (int?)reader[102];
            }
            if (reader[103] != DBNull.Value)
            {
                PCT0100016 = (int?)reader[103];
            }
            if (reader[104] != DBNull.Value)
            {
                PCT0100017 = (int?)reader[104];
            }
            if (reader[105] != DBNull.Value)
            {
                PCT0100018 = (int?)reader[105];
            }
            if (reader[106] != DBNull.Value)
            {
                PCT0100019 = (int?)reader[106];
            }
            if (reader[107] != DBNull.Value)
            {
                PCT0100020 = (int?)reader[107];
            }
            if (reader[108] != DBNull.Value)
            {
                PCT0100021 = (int?)reader[108];
            }
            if (reader[109] != DBNull.Value)
            {
                PCT0100022 = (int?)reader[109];
            }
            if (reader[110] != DBNull.Value)
            {
                PCT0100023 = (int?)reader[110];
            }
            if (reader[111] != DBNull.Value)
            {
                PCT0100024 = (int?)reader[111];
            }
            if (reader[112] != DBNull.Value)
            {
                PCT0100025 = (int?)reader[112];
            }
            if (reader[113] != DBNull.Value)
            {
                PCT0100026 = (int?)reader[113];
            }
            if (reader[114] != DBNull.Value)
            {
                PCT0100027 = (int?)reader[114];
            }
            if (reader[115] != DBNull.Value)
            {
                PCT0100028 = (int?)reader[115];
            }
            if (reader[116] != DBNull.Value)
            {
                PCT0100029 = (int?)reader[116];
            }
            if (reader[117] != DBNull.Value)
            {
                PCT0100030 = (int?)reader[117];
            }
            if (reader[118] != DBNull.Value)
            {
                PCT0100031 = (int?)reader[118];
            }
            if (reader[119] != DBNull.Value)
            {
                PCT0100032 = (int?)reader[119];
            }
            if (reader[120] != DBNull.Value)
            {
                PCT0100033 = (int?)reader[120];
            }
            if (reader[121] != DBNull.Value)
            {
                PCT0100034 = (int?)reader[121];
            }
            if (reader[122] != DBNull.Value)
            {
                PCT0110001 = (int?)reader[122];
            }
            if (reader[123] != DBNull.Value)
            {
                PCT0110002 = (int?)reader[123];
            }
            if (reader[124] != DBNull.Value)
            {
                PCT0110003 = (int?)reader[124];
            }
            if (reader[125] != DBNull.Value)
            {
                PCT0110004 = (int?)reader[125];
            }
            if (reader[126] != DBNull.Value)
            {
                PCT0110005 = (int?)reader[126];
            }
            if (reader[127] != DBNull.Value)
            {
                PCT0110006 = (int?)reader[127];
            }
            if (reader[128] != DBNull.Value)
            {
                PCT0110007 = (int?)reader[128];
            }
            if (reader[129] != DBNull.Value)
            {
                PCT0110008 = (int?)reader[129];
            }
            if (reader[130] != DBNull.Value)
            {
                PCT0110009 = (int?)reader[130];
            }
            if (reader[131] != DBNull.Value)
            {
                PCT0110010 = (int?)reader[131];
            }
            if (reader[132] != DBNull.Value)
            {
                PCT0110011 = (int?)reader[132];
            }
            if (reader[133] != DBNull.Value)
            {
                PCT0110012 = (int?)reader[133];
            }
            if (reader[134] != DBNull.Value)
            {
                PCT0110013 = (int?)reader[134];
            }
            if (reader[135] != DBNull.Value)
            {
                PCT0110014 = (int?)reader[135];
            }
            if (reader[136] != DBNull.Value)
            {
                PCT0110015 = (int?)reader[136];
            }
            if (reader[137] != DBNull.Value)
            {
                PCT0110016 = (int?)reader[137];
            }
            if (reader[138] != DBNull.Value)
            {
                PCT0110017 = (int?)reader[138];
            }
            if (reader[139] != DBNull.Value)
            {
                PCT0110018 = (int?)reader[139];
            }
            if (reader[140] != DBNull.Value)
            {
                PCT0110019 = (int?)reader[140];
            }
            if (reader[141] != DBNull.Value)
            {
                PCT0110020 = (int?)reader[141];
            }
            if (reader[142] != DBNull.Value)
            {
                PCT0110021 = (int?)reader[142];
            }
            if (reader[143] != DBNull.Value)
            {
                PCT0110022 = (int?)reader[143];
            }
            if (reader[144] != DBNull.Value)
            {
                PCT0110023 = (int?)reader[144];
            }
            if (reader[145] != DBNull.Value)
            {
                PCT0110024 = (int?)reader[145];
            }
            if (reader[146] != DBNull.Value)
            {
                PCT0110025 = (int?)reader[146];
            }
            if (reader[147] != DBNull.Value)
            {
                PCT0110026 = (int?)reader[147];
            }
            if (reader[148] != DBNull.Value)
            {
                PCT0110027 = (int?)reader[148];
            }
            if (reader[149] != DBNull.Value)
            {
                PCT0110028 = (int?)reader[149];
            }
            if (reader[150] != DBNull.Value)
            {
                PCT0110029 = (int?)reader[150];
            }
            if (reader[151] != DBNull.Value)
            {
                PCT0110030 = (int?)reader[151];
            }
            if (reader[152] != DBNull.Value)
            {
                PCT0110031 = (int?)reader[152];
            }
            if (reader[153] != DBNull.Value)
            {
                PCT0120001 = (int?)reader[153];
            }
            if (reader[154] != DBNull.Value)
            {
                PCT0120002 = (int?)reader[154];
            }
            if (reader[155] != DBNull.Value)
            {
                PCT0120003 = (int?)reader[155];
            }
            if (reader[156] != DBNull.Value)
            {
                PCT0120004 = (int?)reader[156];
            }
            if (reader[157] != DBNull.Value)
            {
                PCT0120005 = (int?)reader[157];
            }
            if (reader[158] != DBNull.Value)
            {
                PCT0120006 = (int?)reader[158];
            }
            if (reader[159] != DBNull.Value)
            {
                PCT0120007 = (int?)reader[159];
            }
            if (reader[160] != DBNull.Value)
            {
                PCT0120008 = (int?)reader[160];
            }
            if (reader[161] != DBNull.Value)
            {
                PCT0120009 = (int?)reader[161];
            }
            if (reader[162] != DBNull.Value)
            {
                PCT0120010 = (int?)reader[162];
            }
            if (reader[163] != DBNull.Value)
            {
                PCT0120011 = (int?)reader[163];
            }
            if (reader[164] != DBNull.Value)
            {
                PCT0120012 = (int?)reader[164];
            }
            if (reader[165] != DBNull.Value)
            {
                PCT0120013 = (int?)reader[165];
            }
            if (reader[166] != DBNull.Value)
            {
                PCT0120014 = (int?)reader[166];
            }
            if (reader[167] != DBNull.Value)
            {
                PCT0120015 = (int?)reader[167];
            }
            if (reader[168] != DBNull.Value)
            {
                PCT0120016 = (int?)reader[168];
            }
            if (reader[169] != DBNull.Value)
            {
                PCT0120017 = (int?)reader[169];
            }
            if (reader[170] != DBNull.Value)
            {
                PCT0120018 = (int?)reader[170];
            }
            if (reader[171] != DBNull.Value)
            {
                PCT0120019 = (int?)reader[171];
            }
            if (reader[172] != DBNull.Value)
            {
                PCT0120020 = (int?)reader[172];
            }
            if (reader[173] != DBNull.Value)
            {
                PCT0120021 = (int?)reader[173];
            }
            if (reader[174] != DBNull.Value)
            {
                PCT0130001 = (int?)reader[174];
            }
            if (reader[175] != DBNull.Value)
            {
                PCT0130002 = (int?)reader[175];
            }
            if (reader[176] != DBNull.Value)
            {
                PCT0130003 = (int?)reader[176];
            }
            if (reader[177] != DBNull.Value)
            {
                PCT0130004 = (int?)reader[177];
            }
            if (reader[178] != DBNull.Value)
            {
                PCT0130005 = (int?)reader[178];
            }
            if (reader[179] != DBNull.Value)
            {
                PCT0130006 = (int?)reader[179];
            }
            if (reader[180] != DBNull.Value)
            {
                PCT0130007 = (int?)reader[180];
            }
            if (reader[181] != DBNull.Value)
            {
                PCT0130008 = (int?)reader[181];
            }
            if (reader[182] != DBNull.Value)
            {
                PCT0130009 = (int?)reader[182];
            }
            if (reader[183] != DBNull.Value)
            {
                PCT0130010 = (int?)reader[183];
            }
            if (reader[184] != DBNull.Value)
            {
                PCT0130011 = (int?)reader[184];
            }
            if (reader[185] != DBNull.Value)
            {
                PCT0130012 = (int?)reader[185];
            }
            if (reader[186] != DBNull.Value)
            {
                PCT0130013 = (int?)reader[186];
            }
            if (reader[187] != DBNull.Value)
            {
                PCT0130014 = (int?)reader[187];
            }
            if (reader[188] != DBNull.Value)
            {
                PCT0130015 = (int?)reader[188];
            }
            if (reader[189] != DBNull.Value)
            {
                PCT0140001 = (int?)reader[189];
            }
            if (reader[190] != DBNull.Value)
            {
                PCT0140002 = (int?)reader[190];
            }
            if (reader[191] != DBNull.Value)
            {
                PCT0140003 = (int?)reader[191];
            }
            if (reader[192] != DBNull.Value)
            {
                PCT0140004 = (int?)reader[192];
            }
            if (reader[193] != DBNull.Value)
            {
                PCT0140005 = (int?)reader[193];
            }
            if (reader[194] != DBNull.Value)
            {
                PCT0140006 = (int?)reader[194];
            }
            if (reader[195] != DBNull.Value)
            {
                PCT0140007 = (int?)reader[195];
            }
            if (reader[196] != DBNull.Value)
            {
                PCT0140008 = (int?)reader[196];
            }
            if (reader[197] != DBNull.Value)
            {
                PCT0140009 = (int?)reader[197];
            }
            if (reader[198] != DBNull.Value)
            {
                PCT0140010 = (int?)reader[198];
            }
            if (reader[199] != DBNull.Value)
            {
                PCT0140011 = (int?)reader[199];
            }
            if (reader[200] != DBNull.Value)
            {
                PCT0150001 = (int?)reader[200];
            }
            if (reader[201] != DBNull.Value)
            {
                PCT0150002 = (int?)reader[201];
            }
            if (reader[202] != DBNull.Value)
            {
                PCT0150003 = (int?)reader[202];
            }
            if (reader[203] != DBNull.Value)
            {
                PCT0150004 = (int?)reader[203];
            }
            if (reader[204] != DBNull.Value)
            {
                PCT0150005 = (int?)reader[204];
            }
            if (reader[205] != DBNull.Value)
            {
                PCT0150006 = (int?)reader[205];
            }
            if (reader[206] != DBNull.Value)
            {
                PCT0150007 = (int?)reader[206];
            }
            if (reader[207] != DBNull.Value)
            {
                PCT0150008 = (int?)reader[207];
            }
            if (reader[208] != DBNull.Value)
            {
                PCT0150009 = (int?)reader[208];
            }
            if (reader[209] != DBNull.Value)
            {
                PCT0150010 = (int?)reader[209];
            }
            if (reader[210] != DBNull.Value)
            {
                PCT0150011 = (int?)reader[210];
            }
            if (reader[211] != DBNull.Value)
            {
                PCT0160001 = (int?)reader[211];
            }
            if (reader[212] != DBNull.Value)
            {
                PCT0160002 = (int?)reader[212];
            }
            if (reader[213] != DBNull.Value)
            {
                PCT0160003 = (int?)reader[213];
            }
            if (reader[214] != DBNull.Value)
            {
                PCT0160004 = (int?)reader[214];
            }
            if (reader[215] != DBNull.Value)
            {
                PCT0160005 = (int?)reader[215];
            }
            if (reader[216] != DBNull.Value)
            {
                PCT0160006 = (int?)reader[216];
            }
            if (reader[217] != DBNull.Value)
            {
                PCT0160007 = (int?)reader[217];
            }
            if (reader[218] != DBNull.Value)
            {
                PCT0160008 = (int?)reader[218];
            }
            if (reader[219] != DBNull.Value)
            {
                PCT0160009 = (int?)reader[219];
            }
            if (reader[220] != DBNull.Value)
            {
                PCT0160010 = (int?)reader[220];
            }
            if (reader[221] != DBNull.Value)
            {
                PCT0160011 = (int?)reader[221];
            }
            if (reader[222] != DBNull.Value)
            {
                PCT0170001 = (int?)reader[222];
            }
            if (reader[223] != DBNull.Value)
            {
                PCT0170002 = (int?)reader[223];
            }
            if (reader[224] != DBNull.Value)
            {
                PCT0170003 = (int?)reader[224];
            }
            if (reader[225] != DBNull.Value)
            {
                PCT0180001 = (int?)reader[225];
            }
            if (reader[226] != DBNull.Value)
            {
                PCT0180002 = (int?)reader[226];
            }
            if (reader[227] != DBNull.Value)
            {
                PCT0180003 = (int?)reader[227];
            }
        }
        #endregion Constructors
    }
}
