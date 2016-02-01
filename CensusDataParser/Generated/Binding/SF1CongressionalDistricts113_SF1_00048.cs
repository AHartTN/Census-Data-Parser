#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1CongressionalDistricts113_SF1_00048.cs
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

    public class SF1CongressionalDistricts113_SF1_00048 : BaseModel
    {
        #region Properties
        [Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
        public string FILEID { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }

        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
        public string CHARITER { get; set; }

        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
        public string CIFSN { get; set; }

        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
        public int LOGRECNO { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public int? PCT0230001 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 6)]
        public int? PCT0230002 { get; set; }

        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 7)]
        public int? PCT0230003 { get; set; }

        [Display(Name = "In other family:", ShortName = "In other family:", Order = 8)]
        public int? PCT0230004 { get; set; }

        [Display(Name = "In male householder, no wife present family", ShortName = "In male householder, no wife present family", Order = 9)]
        public int? PCT0230005 { get; set; }

        [Display(Name = "In female householder, no husband present family", ShortName = "In female householder, no husband present family", Order = 10)]
        public int? PCT0230006 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 11)]
        public int? PCT0230007 { get; set; }

        [Display(Name = "In households with a male householder:", ShortName = "In households with a male householder:", Order = 12)]
        public int? PCT0230008 { get; set; }

        [Display(Name = "In 1-person household", ShortName = "In 1-person household", Order = 13)]
        public int? PCT0230009 { get; set; }

        [Display(Name = "In 2-or-more-person household", ShortName = "In 2-or-more-person household", Order = 14)]
        public int? PCT0230010 { get; set; }

        [Display(Name = "In households with a female householder:", ShortName = "In households with a female householder:", Order = 15)]
        public int? PCT0230011 { get; set; }

        [Display(Name = "In 1-person household", ShortName = "In 1-person household", Order = 16)]
        public int? PCT0230012 { get; set; }

        [Display(Name = "In 2-or-more-person household", ShortName = "In 2-or-more-person household", Order = 17)]
        public int? PCT0230013 { get; set; }

        [Display(Name = "Native Hawaiian and Other Pacific Islander:", ShortName = "Native Hawaiian and Other Pacific Islander:", Order = 18)]
        public int? PCT0230014 { get; set; }

        [Display(Name = "Native Hawaiian", ShortName = "Native Hawaiian", Order = 19)]
        public int? PCT0230015 { get; set; }

        [Display(Name = "Guamanian or Chamorro", ShortName = "Guamanian or Chamorro", Order = 20)]
        public int? PCT0230016 { get; set; }

        [Display(Name = "Samoan", ShortName = "Samoan", Order = 21)]
        public int? PCT0230017 { get; set; }

        [Display(Name = "Other Pacific Islander", ShortName = "Other Pacific Islander", Order = 22)]
        public int? PCT0230018 { get; set; }

        [Display(Name = "Some Other Race", ShortName = "Some Other Race", Order = 23)]
        public int? PCT0230019 { get; set; }

        [Display(Name = "Population of Two or More Races", ShortName = "Population of Two or More Races", Order = 24)]
        public int? PCT0230020 { get; set; }

        [Display(Name = "White; American Indian and Alaska Native", ShortName = "White; American Indian and Alaska Native", Order = 25)]
        public int? PCT0230021 { get; set; }

        [Display(Name = "White; Asian", ShortName = "White; Asian", Order = 26)]
        public int? PCT0230022 { get; set; }

        [Display(Name = "White; Black or African American", ShortName = "White; Black or African American", Order = 27)]
        public int? PCT0230023 { get; set; }

        [Display(Name = "White; Some Other Race", ShortName = "White; Some Other Race", Order = 28)]
        public int? PCT0230024 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 29)]
        public int? PCT0240001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 30)]
        public int? PCT0240002 { get; set; }

        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 31)]
        public int? PCT0240003 { get; set; }

        [Display(Name = "Related child:", ShortName = "Related child:", Order = 32)]
        public int? PCT0240004 { get; set; }

        [Display(Name = "Own child:", ShortName = "Own child:", Order = 33)]
        public int? PCT0240005 { get; set; }

        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 34)]
        public int? PCT0240006 { get; set; }

        [Display(Name = "In other family:", ShortName = "In other family:", Order = 35)]
        public int? PCT0240007 { get; set; }

        [Display(Name = "In male householder, no wife present family", ShortName = "In male householder, no wife present family", Order = 36)]
        public int? PCT0240008 { get; set; }

        [Display(Name = "In female householder, no husband present family", ShortName = "In female householder, no husband present family", Order = 37)]
        public int? PCT0240009 { get; set; }

        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 38)]
        public int? PCT0240010 { get; set; }

        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 39)]
        public int? PCT0240011 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 40)]
        public int? PCT0240012 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 41)]
        public int? PCT0240013 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 42)]
        public int? PCT0240014 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 43)]
        public int? PCT0240015 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 44)]
        public int? PCT0240016 { get; set; }

        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 45)]
        public int? PCT0240017 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 46)]
        public int? PCT0240018 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 47)]
        public int? PCT0240019 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 48)]
        public int? PCT0240020 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 49)]
        public int? PCT0240021 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 50)]
        public int? PCT0240022 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 51)]
        public int? PCT0240023 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1CongressionalDistricts113_SF1_00048() { }

        public SF1CongressionalDistricts113_SF1_00048(string csvLine) : base(csvLine) { }

        public SF1CongressionalDistricts113_SF1_00048(string[] values) : base(values) { }

        public SF1CongressionalDistricts113_SF1_00048(OleDbDataReader reader)
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
                LOGRECNO = (int)reader[4];
            }
            if (reader[5] != DBNull.Value)
            {
                PCT0230001 = (int?)reader[5];
            }
            if (reader[6] != DBNull.Value)
            {
                PCT0230002 = (int?)reader[6];
            }
            if (reader[7] != DBNull.Value)
            {
                PCT0230003 = (int?)reader[7];
            }
            if (reader[8] != DBNull.Value)
            {
                PCT0230004 = (int?)reader[8];
            }
            if (reader[9] != DBNull.Value)
            {
                PCT0230005 = (int?)reader[9];
            }
            if (reader[10] != DBNull.Value)
            {
                PCT0230006 = (int?)reader[10];
            }
            if (reader[11] != DBNull.Value)
            {
                PCT0230007 = (int?)reader[11];
            }
            if (reader[12] != DBNull.Value)
            {
                PCT0230008 = (int?)reader[12];
            }
            if (reader[13] != DBNull.Value)
            {
                PCT0230009 = (int?)reader[13];
            }
            if (reader[14] != DBNull.Value)
            {
                PCT0230010 = (int?)reader[14];
            }
            if (reader[15] != DBNull.Value)
            {
                PCT0230011 = (int?)reader[15];
            }
            if (reader[16] != DBNull.Value)
            {
                PCT0230012 = (int?)reader[16];
            }
            if (reader[17] != DBNull.Value)
            {
                PCT0230013 = (int?)reader[17];
            }
            if (reader[18] != DBNull.Value)
            {
                PCT0230014 = (int?)reader[18];
            }
            if (reader[19] != DBNull.Value)
            {
                PCT0230015 = (int?)reader[19];
            }
            if (reader[20] != DBNull.Value)
            {
                PCT0230016 = (int?)reader[20];
            }
            if (reader[21] != DBNull.Value)
            {
                PCT0230017 = (int?)reader[21];
            }
            if (reader[22] != DBNull.Value)
            {
                PCT0230018 = (int?)reader[22];
            }
            if (reader[23] != DBNull.Value)
            {
                PCT0230019 = (int?)reader[23];
            }
            if (reader[24] != DBNull.Value)
            {
                PCT0230020 = (int?)reader[24];
            }
            if (reader[25] != DBNull.Value)
            {
                PCT0230021 = (int?)reader[25];
            }
            if (reader[26] != DBNull.Value)
            {
                PCT0230022 = (int?)reader[26];
            }
            if (reader[27] != DBNull.Value)
            {
                PCT0230023 = (int?)reader[27];
            }
            if (reader[28] != DBNull.Value)
            {
                PCT0230024 = (int?)reader[28];
            }
            if (reader[29] != DBNull.Value)
            {
                PCT0240001 = (int?)reader[29];
            }
            if (reader[30] != DBNull.Value)
            {
                PCT0240002 = (int?)reader[30];
            }
            if (reader[31] != DBNull.Value)
            {
                PCT0240003 = (int?)reader[31];
            }
            if (reader[32] != DBNull.Value)
            {
                PCT0240004 = (int?)reader[32];
            }
            if (reader[33] != DBNull.Value)
            {
                PCT0240005 = (int?)reader[33];
            }
            if (reader[34] != DBNull.Value)
            {
                PCT0240006 = (int?)reader[34];
            }
            if (reader[35] != DBNull.Value)
            {
                PCT0240007 = (int?)reader[35];
            }
            if (reader[36] != DBNull.Value)
            {
                PCT0240008 = (int?)reader[36];
            }
            if (reader[37] != DBNull.Value)
            {
                PCT0240009 = (int?)reader[37];
            }
            if (reader[38] != DBNull.Value)
            {
                PCT0240010 = (int?)reader[38];
            }
            if (reader[39] != DBNull.Value)
            {
                PCT0240011 = (int?)reader[39];
            }
            if (reader[40] != DBNull.Value)
            {
                PCT0240012 = (int?)reader[40];
            }
            if (reader[41] != DBNull.Value)
            {
                PCT0240013 = (int?)reader[41];
            }
            if (reader[42] != DBNull.Value)
            {
                PCT0240014 = (int?)reader[42];
            }
            if (reader[43] != DBNull.Value)
            {
                PCT0240015 = (int?)reader[43];
            }
            if (reader[44] != DBNull.Value)
            {
                PCT0240016 = (int?)reader[44];
            }
            if (reader[45] != DBNull.Value)
            {
                PCT0240017 = (int?)reader[45];
            }
            if (reader[46] != DBNull.Value)
            {
                PCT0240018 = (int?)reader[46];
            }
            if (reader[47] != DBNull.Value)
            {
                PCT0240019 = (int?)reader[47];
            }
            if (reader[48] != DBNull.Value)
            {
                PCT0240020 = (int?)reader[48];
            }
            if (reader[49] != DBNull.Value)
            {
                PCT0240021 = (int?)reader[49];
            }
            if (reader[50] != DBNull.Value)
            {
                PCT0240022 = (int?)reader[50];
            }
            if (reader[51] != DBNull.Value)
            {
                PCT0240023 = (int?)reader[51];
            }
        }
        #endregion Constructors
    }
}
