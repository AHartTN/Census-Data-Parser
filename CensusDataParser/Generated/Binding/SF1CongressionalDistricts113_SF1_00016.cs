#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1CongressionalDistricts113_SF1_00016.cs
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

    public class SF1CongressionalDistricts113_SF1_00016 : BaseModel
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

        [Display(Name = "Total Native Hawaiian and Other Pacific Islander categories tallied (500-599) & (500-599):", ShortName = "Total Native Hawaiian and Other Pacific Islander categories tallied (500-599) & (500-599):", Order = 5)]
        public int? PCT0090001 { get; set; }

        [Display(Name = "Polynesian (500-519) & (500-599):", ShortName = "Polynesian (500-519) & (500-599):", Order = 6)]
        public int? PCT0090002 { get; set; }

        [Display(Name = "Native Hawaiian (500-503) & (500-599)", ShortName = "Native Hawaiian (500-503) & (500-599)", Order = 7)]
        public int? PCT0090003 { get; set; }

        [Display(Name = "Samoan (510-511) & (500-599)", ShortName = "Samoan (510-511) & (500-599)", Order = 8)]
        public int? PCT0090004 { get; set; }

        [Display(Name = "Tongan (513) & (500-599)", ShortName = "Tongan (513) & (500-599)", Order = 9)]
        public int? PCT0090005 { get; set; }

        [Display(Name = "Other Polynesian (504-509, 512, 514-519) & (500-599)", ShortName = "Other Polynesian (504-509, 512, 514-519) & (500-599)", Order = 10)]
        public int? PCT0090006 { get; set; }

        [Display(Name = "Micronesian (520-529, 531-541) & (500-599):", ShortName = "Micronesian (520-529, 531-541) & (500-599):", Order = 11)]
        public int? PCT0090007 { get; set; }

        [Display(Name = "Guamanian or Chamorro (520-522) & (500-599)", ShortName = "Guamanian or Chamorro (520-522) & (500-599)", Order = 12)]
        public int? PCT0090008 { get; set; }

        [Display(Name = "Marshallese (532) & (500-599)", ShortName = "Marshallese (532) & (500-599)", Order = 13)]
        public int? PCT0090009 { get; set; }

        [Display(Name = "Other Micronesian (523-529, 531, 533-541) & (500-599)", ShortName = "Other Micronesian (523-529, 531, 533-541) & (500-599)", Order = 14)]
        public int? PCT0090010 { get; set; }

        [Display(Name = "Melanesian (542-546) & (500-599):", ShortName = "Melanesian (542-546) & (500-599):", Order = 15)]
        public int? PCT0090011 { get; set; }

        [Display(Name = "Fijian (542) & (500-599)", ShortName = "Fijian (542) & (500-599)", Order = 16)]
        public int? PCT0090012 { get; set; }

        [Display(Name = "Other Melanesian (543-546) & (500-599)", ShortName = "Other Melanesian (543-546) & (500-599)", Order = 17)]
        public int? PCT0090013 { get; set; }

        [Display(Name = "Other Pacific Islander, not specified (530, 547-599) & (500-599)", ShortName = "Other Pacific Islander, not specified (530, 547-599) & (500-599)", Order = 18)]
        public int? PCT0090014 { get; set; }

        [Display(Name = "Total Native Hawaiian and Other Pacific Islander categories tallied (500-599) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Total Native Hawaiian and Other Pacific Islander categories tallied (500-599) & (100-299) or (300, A01-Z99) or (400-999):", Order = 19)]
        public int? PCT0100001 { get; set; }

        [Display(Name = "Polynesian (500-519) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Polynesian (500-519) & (100-299) or (300, A01-Z99) or (400-999):", Order = 20)]
        public int? PCT0100002 { get; set; }

        [Display(Name = "Native Hawaiian (500-503) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Native Hawaiian (500-503) & (100-299) or (300, A01-Z99) or (400-999)", Order = 21)]
        public int? PCT0100003 { get; set; }

        [Display(Name = "Samoan (510-511) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Samoan (510-511) & (100-299) or (300, A01-Z99) or (400-999)", Order = 22)]
        public int? PCT0100004 { get; set; }

        [Display(Name = "Tongan (513) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Tongan (513) & (100-299) or (300, A01-Z99) or (400-999)", Order = 23)]
        public int? PCT0100005 { get; set; }

        [Display(Name = "Other Polynesian (504-509, 512, 514-519) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Other Polynesian (504-509, 512, 514-519) & (100-299) or (300, A01-Z99) or (400-999)", Order = 24)]
        public int? PCT0100006 { get; set; }

        [Display(Name = "Micronesian (520-529, 531-541) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Micronesian (520-529, 531-541) & (100-299) or (300, A01-Z99) or (400-999):", Order = 25)]
        public int? PCT0100007 { get; set; }

        [Display(Name = "Guamanian or Chamorro (520-522) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Guamanian or Chamorro (520-522) & (100-299) or (300, A01-Z99) or (400-999)", Order = 26)]
        public int? PCT0100008 { get; set; }

        [Display(Name = "Marshallese (532) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Marshallese (532) & (100-299) or (300, A01-Z99) or (400-999)", Order = 27)]
        public int? PCT0100009 { get; set; }

        [Display(Name = "Other Micronesian (523-529, 531, 533-541)  & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Other Micronesian (523-529, 531, 533-541)  & (100-299) or (300, A01-Z99) or (400-999)", Order = 28)]
        public int? PCT0100010 { get; set; }

        [Display(Name = "Melanesian (542-546) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Melanesian (542-546) & (100-299) or (300, A01-Z99) or (400-999):", Order = 29)]
        public int? PCT0100011 { get; set; }

        [Display(Name = "Fijian (542) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Fijian (542) & (100-299) or (300, A01-Z99) or (400-999)", Order = 30)]
        public int? PCT0100012 { get; set; }

        [Display(Name = "Other Melanesian (543-546) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Other Melanesian (543-546) & (100-299) or (300, A01-Z99) or (400-999)", Order = 31)]
        public int? PCT0100013 { get; set; }

        [Display(Name = "Other Pacific Islander, not specified (530, 547-599) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Other Pacific Islander, not specified (530, 547-599) & (100-299) or (300, A01-Z99) or (400-999)", Order = 32)]
        public int? PCT0100014 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 33)]
        public int? PCT0110001 { get; set; }

        [Display(Name = "Not Hispanic or Latino (001-199, 300-999)", ShortName = "Not Hispanic or Latino (001-199, 300-999)", Order = 34)]
        public int? PCT0110002 { get; set; }

        [Display(Name = "Hispanic or Latino (200-299):", ShortName = "Hispanic or Latino (200-299):", Order = 35)]
        public int? PCT0110003 { get; set; }

        [Display(Name = "Mexican (210-220)", ShortName = "Mexican (210-220)", Order = 36)]
        public int? PCT0110004 { get; set; }

        [Display(Name = "Puerto Rican (260-269)", ShortName = "Puerto Rican (260-269)", Order = 37)]
        public int? PCT0110005 { get; set; }

        [Display(Name = "Cuban (270-274)", ShortName = "Cuban (270-274)", Order = 38)]
        public int? PCT0110006 { get; set; }

        [Display(Name = "Dominican (275-279)", ShortName = "Dominican (275-279)", Order = 39)]
        public int? PCT0110007 { get; set; }

        [Display(Name = "Central American (excluding Mexican) (221-230):", ShortName = "Central American (excluding Mexican) (221-230):", Order = 40)]
        public int? PCT0110008 { get; set; }

        [Display(Name = "Costa Rican (221)", ShortName = "Costa Rican (221)", Order = 41)]
        public int? PCT0110009 { get; set; }

        [Display(Name = "Guatemalan (222)", ShortName = "Guatemalan (222)", Order = 42)]
        public int? PCT0110010 { get; set; }

        [Display(Name = "Honduran (223)", ShortName = "Honduran (223)", Order = 43)]
        public int? PCT0110011 { get; set; }

        [Display(Name = "Nicaraguan (224)", ShortName = "Nicaraguan (224)", Order = 44)]
        public int? PCT0110012 { get; set; }

        [Display(Name = "Panamanian (225)", ShortName = "Panamanian (225)", Order = 45)]
        public int? PCT0110013 { get; set; }

        [Display(Name = "Salvadoran (226)", ShortName = "Salvadoran (226)", Order = 46)]
        public int? PCT0110014 { get; set; }

        [Display(Name = "Other Central American (227-230)", ShortName = "Other Central American (227-230)", Order = 47)]
        public int? PCT0110015 { get; set; }

        [Display(Name = "South American (231-249):", ShortName = "South American (231-249):", Order = 48)]
        public int? PCT0110016 { get; set; }

        [Display(Name = "Argentinean (231)", ShortName = "Argentinean (231)", Order = 49)]
        public int? PCT0110017 { get; set; }

        [Display(Name = "Bolivian (232)", ShortName = "Bolivian (232)", Order = 50)]
        public int? PCT0110018 { get; set; }

        [Display(Name = "Chilean (233)", ShortName = "Chilean (233)", Order = 51)]
        public int? PCT0110019 { get; set; }

        [Display(Name = "Colombian (234)", ShortName = "Colombian (234)", Order = 52)]
        public int? PCT0110020 { get; set; }

        [Display(Name = "Ecuadorian (235)", ShortName = "Ecuadorian (235)", Order = 53)]
        public int? PCT0110021 { get; set; }

        [Display(Name = "Paraguayan (236)", ShortName = "Paraguayan (236)", Order = 54)]
        public int? PCT0110022 { get; set; }

        [Display(Name = "Peruvian (237)", ShortName = "Peruvian (237)", Order = 55)]
        public int? PCT0110023 { get; set; }

        [Display(Name = "Uruguayan (238)", ShortName = "Uruguayan (238)", Order = 56)]
        public int? PCT0110024 { get; set; }

        [Display(Name = "Venezuelan (239)", ShortName = "Venezuelan (239)", Order = 57)]
        public int? PCT0110025 { get; set; }

        [Display(Name = "Other South American (240-249)", ShortName = "Other South American (240-249)", Order = 58)]
        public int? PCT0110026 { get; set; }

        [Display(Name = "Other Hispanic or Latino (200-209, 250-259, 280-299):", ShortName = "Other Hispanic or Latino (200-209, 250-259, 280-299):", Order = 59)]
        public int? PCT0110027 { get; set; }

        [Display(Name = "Spaniard (200-209)", ShortName = "Spaniard (200-209)", Order = 60)]
        public int? PCT0110028 { get; set; }

        [Display(Name = "Spanish (282)", ShortName = "Spanish (282)", Order = 61)]
        public int? PCT0110029 { get; set; }

        [Display(Name = "Spanish American (286)", ShortName = "Spanish American (286)", Order = 62)]
        public int? PCT0110030 { get; set; }

        [Display(Name = "All other Hispanic or Latino (250-259, 280-281, 283-285, 287-299)", ShortName = "All other Hispanic or Latino (250-259, 280-281, 283-285, 287-299)", Order = 63)]
        public int? PCT0110031 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1CongressionalDistricts113_SF1_00016() { }

        public SF1CongressionalDistricts113_SF1_00016(string csvLine) : base(csvLine) { }

        public SF1CongressionalDistricts113_SF1_00016(string[] values) : base(values) { }

        public SF1CongressionalDistricts113_SF1_00016(OleDbDataReader reader)
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
                PCT0090001 = (int?)reader[5];
            }
            if (reader[6] != DBNull.Value)
            {
                PCT0090002 = (int?)reader[6];
            }
            if (reader[7] != DBNull.Value)
            {
                PCT0090003 = (int?)reader[7];
            }
            if (reader[8] != DBNull.Value)
            {
                PCT0090004 = (int?)reader[8];
            }
            if (reader[9] != DBNull.Value)
            {
                PCT0090005 = (int?)reader[9];
            }
            if (reader[10] != DBNull.Value)
            {
                PCT0090006 = (int?)reader[10];
            }
            if (reader[11] != DBNull.Value)
            {
                PCT0090007 = (int?)reader[11];
            }
            if (reader[12] != DBNull.Value)
            {
                PCT0090008 = (int?)reader[12];
            }
            if (reader[13] != DBNull.Value)
            {
                PCT0090009 = (int?)reader[13];
            }
            if (reader[14] != DBNull.Value)
            {
                PCT0090010 = (int?)reader[14];
            }
            if (reader[15] != DBNull.Value)
            {
                PCT0090011 = (int?)reader[15];
            }
            if (reader[16] != DBNull.Value)
            {
                PCT0090012 = (int?)reader[16];
            }
            if (reader[17] != DBNull.Value)
            {
                PCT0090013 = (int?)reader[17];
            }
            if (reader[18] != DBNull.Value)
            {
                PCT0090014 = (int?)reader[18];
            }
            if (reader[19] != DBNull.Value)
            {
                PCT0100001 = (int?)reader[19];
            }
            if (reader[20] != DBNull.Value)
            {
                PCT0100002 = (int?)reader[20];
            }
            if (reader[21] != DBNull.Value)
            {
                PCT0100003 = (int?)reader[21];
            }
            if (reader[22] != DBNull.Value)
            {
                PCT0100004 = (int?)reader[22];
            }
            if (reader[23] != DBNull.Value)
            {
                PCT0100005 = (int?)reader[23];
            }
            if (reader[24] != DBNull.Value)
            {
                PCT0100006 = (int?)reader[24];
            }
            if (reader[25] != DBNull.Value)
            {
                PCT0100007 = (int?)reader[25];
            }
            if (reader[26] != DBNull.Value)
            {
                PCT0100008 = (int?)reader[26];
            }
            if (reader[27] != DBNull.Value)
            {
                PCT0100009 = (int?)reader[27];
            }
            if (reader[28] != DBNull.Value)
            {
                PCT0100010 = (int?)reader[28];
            }
            if (reader[29] != DBNull.Value)
            {
                PCT0100011 = (int?)reader[29];
            }
            if (reader[30] != DBNull.Value)
            {
                PCT0100012 = (int?)reader[30];
            }
            if (reader[31] != DBNull.Value)
            {
                PCT0100013 = (int?)reader[31];
            }
            if (reader[32] != DBNull.Value)
            {
                PCT0100014 = (int?)reader[32];
            }
            if (reader[33] != DBNull.Value)
            {
                PCT0110001 = (int?)reader[33];
            }
            if (reader[34] != DBNull.Value)
            {
                PCT0110002 = (int?)reader[34];
            }
            if (reader[35] != DBNull.Value)
            {
                PCT0110003 = (int?)reader[35];
            }
            if (reader[36] != DBNull.Value)
            {
                PCT0110004 = (int?)reader[36];
            }
            if (reader[37] != DBNull.Value)
            {
                PCT0110005 = (int?)reader[37];
            }
            if (reader[38] != DBNull.Value)
            {
                PCT0110006 = (int?)reader[38];
            }
            if (reader[39] != DBNull.Value)
            {
                PCT0110007 = (int?)reader[39];
            }
            if (reader[40] != DBNull.Value)
            {
                PCT0110008 = (int?)reader[40];
            }
            if (reader[41] != DBNull.Value)
            {
                PCT0110009 = (int?)reader[41];
            }
            if (reader[42] != DBNull.Value)
            {
                PCT0110010 = (int?)reader[42];
            }
            if (reader[43] != DBNull.Value)
            {
                PCT0110011 = (int?)reader[43];
            }
            if (reader[44] != DBNull.Value)
            {
                PCT0110012 = (int?)reader[44];
            }
            if (reader[45] != DBNull.Value)
            {
                PCT0110013 = (int?)reader[45];
            }
            if (reader[46] != DBNull.Value)
            {
                PCT0110014 = (int?)reader[46];
            }
            if (reader[47] != DBNull.Value)
            {
                PCT0110015 = (int?)reader[47];
            }
            if (reader[48] != DBNull.Value)
            {
                PCT0110016 = (int?)reader[48];
            }
            if (reader[49] != DBNull.Value)
            {
                PCT0110017 = (int?)reader[49];
            }
            if (reader[50] != DBNull.Value)
            {
                PCT0110018 = (int?)reader[50];
            }
            if (reader[51] != DBNull.Value)
            {
                PCT0110019 = (int?)reader[51];
            }
            if (reader[52] != DBNull.Value)
            {
                PCT0110020 = (int?)reader[52];
            }
            if (reader[53] != DBNull.Value)
            {
                PCT0110021 = (int?)reader[53];
            }
            if (reader[54] != DBNull.Value)
            {
                PCT0110022 = (int?)reader[54];
            }
            if (reader[55] != DBNull.Value)
            {
                PCT0110023 = (int?)reader[55];
            }
            if (reader[56] != DBNull.Value)
            {
                PCT0110024 = (int?)reader[56];
            }
            if (reader[57] != DBNull.Value)
            {
                PCT0110025 = (int?)reader[57];
            }
            if (reader[58] != DBNull.Value)
            {
                PCT0110026 = (int?)reader[58];
            }
            if (reader[59] != DBNull.Value)
            {
                PCT0110027 = (int?)reader[59];
            }
            if (reader[60] != DBNull.Value)
            {
                PCT0110028 = (int?)reader[60];
            }
            if (reader[61] != DBNull.Value)
            {
                PCT0110029 = (int?)reader[61];
            }
            if (reader[62] != DBNull.Value)
            {
                PCT0110030 = (int?)reader[62];
            }
            if (reader[63] != DBNull.Value)
            {
                PCT0110031 = (int?)reader[63];
            }
        }
        #endregion Constructors
    }
}
