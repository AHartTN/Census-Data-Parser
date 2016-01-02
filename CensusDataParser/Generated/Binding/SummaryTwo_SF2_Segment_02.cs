#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/02/2016 11:53 AM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryTwo_SF2_Segment_02.cs
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

    public class SummaryTwo_SF2_Segment_02 : BaseModel
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
        [Column("PCT0020001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total tribes tallied (300, A01-Z99) & (300, A01-Z99):", ShortName = "Total tribes tallied (300, A01-Z99) & (300, A01-Z99):", Order = 5)]
        public int? PCT0020001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian tribes, specified (A01-M38, T01-Z99) & (300, A01-Z99):", ShortName = "American Indian tribes, specified (A01-M38, T01-Z99) & (300, A01-Z99):", Order = 6)]
        public int? PCT0020002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Apache (A09-A23) & (300, A01-Z99)", ShortName = "Apache (A09-A23) & (300, A01-Z99)", Order = 7)]
        public int? PCT0020003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Arapaho (A24-A33) & (300, A01-Z99)", ShortName = "Arapaho (A24-A33) & (300, A01-Z99)", Order = 8)]
        public int? PCT0020004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Blackfeet (A45-A50) & (300, A01-Z99)", ShortName = "Blackfeet (A45-A50) & (300, A01-Z99)", Order = 9)]
        public int? PCT0020005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Canadian and French American Indian (T01-V23) & (300, A01-Z99)", ShortName = "Canadian and French American Indian (T01-V23) & (300, A01-Z99)", Order = 10)]
        public int? PCT0020006 { get; set; }
        #endregion Properties

        #region Constructors
        public SummaryTwo_SF2_Segment_02(string csvLine) : base(csvLine) { }

        public SummaryTwo_SF2_Segment_02(string[] values) : base(values) { }

        public SummaryTwo_SF2_Segment_02(OleDbDataReader reader, CensusFileType fileType)
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
                PCT0020001 = (int?)reader[5];
            }
            if (reader[6] != DBNull.Value)
            {
                PCT0020002 = (int?)reader[6];
            }
            if (reader[7] != DBNull.Value)
            {
                PCT0020003 = (int?)reader[7];
            }
            if (reader[8] != DBNull.Value)
            {
                PCT0020004 = (int?)reader[8];
            }
            if (reader[9] != DBNull.Value)
            {
                PCT0020005 = (int?)reader[9];
            }
            if (reader[10] != DBNull.Value)
            {
                PCT0020006 = (int?)reader[10];
            }
        }
        #endregion Constructors
    }
}
