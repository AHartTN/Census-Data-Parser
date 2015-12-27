#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 5:32 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1_00016.cs
// 
// Anthony Hart ("ANTHONY") CONFIDENTIAL
// 
// Unpublished Copyright (c) 1985-2015 Anthony Hart, All Rights Reserved.
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

namespace CensusDataParser.Generated.SF1
{
    #region Using Directives
    using System.ComponentModel.DataAnnotations;
    #endregion

    public class SF1_00016
    {
        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
        public string CHARITER { get; set; }

        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
        public string CIFSN { get; set; }

        [Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
        public string FILEID { get; set; }

        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
        public int? LOGRECNO { get; set; }

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

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}
