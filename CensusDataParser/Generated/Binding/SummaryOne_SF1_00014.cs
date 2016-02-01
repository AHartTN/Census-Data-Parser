#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryOne_SF1_00014.cs
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
    using System.ComponentModel.DataAnnotations;
    using System.Data.OleDb;
    using Models;
    #endregion

    public class SummaryOne_SF1_00014 : BaseModel
    {
        #region Properties
        [Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
        public string FILEID { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }

        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
        public int CHARITER { get; set; }

        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
        public int CIFSN { get; set; }

        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
        public int LOGRECNO { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public int? P039I001 { get; set; }

        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 6)]
        public int? P039I002 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 7)]
        public int? P039I003 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 8)]
        public int? P039I004 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 9)]
        public int? P039I005 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 10)]
        public int? P039I006 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 11)]
        public int? P039I007 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 12)]
        public int? P039I008 { get; set; }

        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 13)]
        public int? P039I009 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 14)]
        public int? P039I010 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 15)]
        public int? P039I011 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 16)]
        public int? P039I012 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 17)]
        public int? P039I013 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 18)]
        public int? P039I014 { get; set; }

        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 19)]
        public int? P039I015 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 20)]
        public int? P039I016 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 21)]
        public int? P039I017 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 22)]
        public int? P039I018 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 23)]
        public int? P039I019 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 24)]
        public int? P039I020 { get; set; }
        #endregion Properties

        #region Constructors
        public SummaryOne_SF1_00014() { }

        public SummaryOne_SF1_00014(string csvLine) : base(csvLine) { }

        public SummaryOne_SF1_00014(string[] values) : base(values) { }

        public SummaryOne_SF1_00014(OleDbDataReader reader)
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
                CHARITER = (int)reader[2];
            }
            if (reader[3] != DBNull.Value)
            {
                CIFSN = (int)reader[3];
            }
            if (reader[4] != DBNull.Value)
            {
                LOGRECNO = (int)reader[4];
            }
            if (reader[5] != DBNull.Value)
            {
                P039I001 = (int?)reader[5];
            }
            if (reader[6] != DBNull.Value)
            {
                P039I002 = (int?)reader[6];
            }
            if (reader[7] != DBNull.Value)
            {
                P039I003 = (int?)reader[7];
            }
            if (reader[8] != DBNull.Value)
            {
                P039I004 = (int?)reader[8];
            }
            if (reader[9] != DBNull.Value)
            {
                P039I005 = (int?)reader[9];
            }
            if (reader[10] != DBNull.Value)
            {
                P039I006 = (int?)reader[10];
            }
            if (reader[11] != DBNull.Value)
            {
                P039I007 = (int?)reader[11];
            }
            if (reader[12] != DBNull.Value)
            {
                P039I008 = (int?)reader[12];
            }
            if (reader[13] != DBNull.Value)
            {
                P039I009 = (int?)reader[13];
            }
            if (reader[14] != DBNull.Value)
            {
                P039I010 = (int?)reader[14];
            }
            if (reader[15] != DBNull.Value)
            {
                P039I011 = (int?)reader[15];
            }
            if (reader[16] != DBNull.Value)
            {
                P039I012 = (int?)reader[16];
            }
            if (reader[17] != DBNull.Value)
            {
                P039I013 = (int?)reader[17];
            }
            if (reader[18] != DBNull.Value)
            {
                P039I014 = (int?)reader[18];
            }
            if (reader[19] != DBNull.Value)
            {
                P039I015 = (int?)reader[19];
            }
            if (reader[20] != DBNull.Value)
            {
                P039I016 = (int?)reader[20];
            }
            if (reader[21] != DBNull.Value)
            {
                P039I017 = (int?)reader[21];
            }
            if (reader[22] != DBNull.Value)
            {
                P039I018 = (int?)reader[22];
            }
            if (reader[23] != DBNull.Value)
            {
                P039I019 = (int?)reader[23];
            }
            if (reader[24] != DBNull.Value)
            {
                P039I020 = (int?)reader[24];
            }
        }
        #endregion Constructors
    }
}
