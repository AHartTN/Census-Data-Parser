#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 4:11 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF2_Segment_04.cs
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

namespace CensusDataParser.Generated.SF2
{
    #region Using Directives
    using System.ComponentModel.DataAnnotations;
    #endregion

    public class SF2_Segment_04
    {
        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
        public string CHARITER { get; set; }

        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
        public string CIFSN { get; set; }

        [Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
        public string FILEID { get; set; }

        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
        public int? LOGRECNO { get; set; }

        [Display(Name = "Total (400-479, 481-499):", ShortName = "Total (400-479, 481-499):", Order = 5)]
        public int? PCT0050001 { get; set; }

        [Display(Name = "Asian Indian (400-401)", ShortName = "Asian Indian (400-401)", Order = 6)]
        public int? PCT0050002 { get; set; }

        [Display(Name = "Bangladeshi (402)", ShortName = "Bangladeshi (402)", Order = 7)]
        public int? PCT0050003 { get; set; }

        [Display(Name = "Bhutanese (403)", ShortName = "Bhutanese (403)", Order = 8)]
        public int? PCT0050004 { get; set; }

        [Display(Name = "Burmese (404)", ShortName = "Burmese (404)", Order = 9)]
        public int? PCT0050005 { get; set; }

        [Display(Name = "Cambodian (405-409)", ShortName = "Cambodian (405-409)", Order = 10)]
        public int? PCT0050006 { get; set; }

        [Display(Name = "Chinese (except Taiwanese) (410-411)", ShortName = "Chinese (except Taiwanese) (410-411)", Order = 11)]
        public int? PCT0050007 { get; set; }

        [Display(Name = "Filipino (420-421)", ShortName = "Filipino (420-421)", Order = 12)]
        public int? PCT0050008 { get; set; }

        [Display(Name = "Hmong (422)", ShortName = "Hmong (422)", Order = 13)]
        public int? PCT0050009 { get; set; }

        [Display(Name = "Indonesian (423-429)", ShortName = "Indonesian (423-429)", Order = 14)]
        public int? PCT0050010 { get; set; }

        [Display(Name = "Japanese (430-439)", ShortName = "Japanese (430-439)", Order = 15)]
        public int? PCT0050011 { get; set; }

        [Display(Name = "Korean (440-441)", ShortName = "Korean (440-441)", Order = 16)]
        public int? PCT0050012 { get; set; }

        [Display(Name = "Laotian (442)", ShortName = "Laotian (442)", Order = 17)]
        public int? PCT0050013 { get; set; }

        [Display(Name = "Malaysian (443)", ShortName = "Malaysian (443)", Order = 18)]
        public int? PCT0050014 { get; set; }

        [Display(Name = "Nepalese (472)", ShortName = "Nepalese (472)", Order = 19)]
        public int? PCT0050015 { get; set; }

        [Display(Name = "Pakistani (445)", ShortName = "Pakistani (445)", Order = 20)]
        public int? PCT0050016 { get; set; }

        [Display(Name = "Sri Lankan (446)", ShortName = "Sri Lankan (446)", Order = 21)]
        public int? PCT0050017 { get; set; }

        [Display(Name = "Taiwanese (412-419)", ShortName = "Taiwanese (412-419)", Order = 22)]
        public int? PCT0050018 { get; set; }

        [Display(Name = "Thai (447-449)", ShortName = "Thai (447-449)", Order = 23)]
        public int? PCT0050019 { get; set; }

        [Display(Name = "Vietnamese (450-459)", ShortName = "Vietnamese (450-459)", Order = 24)]
        public int? PCT0050020 { get; set; }

        [Display(Name = "Other Asian, specified (444, 465, 470-471, 473-479)", ShortName = "Other Asian, specified (444, 465, 470-471, 473-479)", Order = 25)]
        public int? PCT0050021 { get; set; }

        [Display(Name = "Other Asian, not specified (460-464, 466-469, 481-499)", ShortName = "Other Asian, not specified (460-464, 466-469, 481-499)", Order = 26)]
        public int? PCT0050022 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 27)]
        public int? PCT0050023 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 28)]
        public int? PCT0050024 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 29)]
        public int? PCT0050025 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 30)]
        public int? PCT0050026 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 31)]
        public int? PCT0050027 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 32)]
        public int? PCT0050028 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 33)]
        public int? PCT0050029 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 34)]
        public int? PCT0050030 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 35)]
        public int? PCT0050031 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 36)]
        public int? PCT0050032 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 37)]
        public int? PCT0050033 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 38)]
        public int? PCT0050034 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 39)]
        public int? PCT0050035 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 40)]
        public int? PCT0050036 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 41)]
        public int? PCT0050037 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 42)]
        public int? PCT0050038 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 43)]
        public int? PCT0050039 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 44)]
        public int? PCT0050040 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 45)]
        public int? PCT0050041 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 46)]
        public int? PCT0050042 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 47)]
        public int? PCT0050043 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 48)]
        public int? PCT0050044 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 49)]
        public int? PCT0050045 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 50)]
        public int? PCT0050046 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 51)]
        public int? PCT0050047 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 52)]
        public int? PCT0050048 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 53)]
        public int? PCT0050049 { get; set; }

        [Display(Name = "Total Asian categories tallied (400-499) & (400-499):", ShortName = "Total Asian categories tallied (400-499) & (400-499):", Order = 54)]
        public int? PCT0060001 { get; set; }

        [Display(Name = "Asian Indian (400-401) & (400-499)", ShortName = "Asian Indian (400-401) & (400-499)", Order = 55)]
        public int? PCT0060002 { get; set; }

        [Display(Name = "Bangladeshi (402) & (400-499)", ShortName = "Bangladeshi (402) & (400-499)", Order = 56)]
        public int? PCT0060003 { get; set; }

        [Display(Name = "Total Asian categories tallied (400-499) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Total Asian categories tallied (400-499) & (100-299) or (300, A01-Z99) or (400-999):", Order = 57)]
        public double? PCT0070001 { get; set; }

        [Display(Name = "Asian Indian (400-401) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Asian Indian (400-401) & (100-299) or (300, A01-Z99) or (400-999)", Order = 58)]
        public double? PCT0070002 { get; set; }

        [Display(Name = "Bangladeshi (402) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Bangladeshi (402) & (100-299) or (300, A01-Z99) or (400-999)", Order = 59)]
        public double? PCT0070003 { get; set; }

        [Display(Name = "Total (500-549, 551-599):", ShortName = "Total (500-549, 551-599):", Order = 60)]
        public int? PCT0080001 { get; set; }

        [Display(Name = "Polynesian (500-519):", ShortName = "Polynesian (500-519):", Order = 61)]
        public int? PCT0080002 { get; set; }

        [Display(Name = "Native Hawaiian (500-503)", ShortName = "Native Hawaiian (500-503)", Order = 62)]
        public int? PCT0080003 { get; set; }

        [Display(Name = "Samoan (510-511)", ShortName = "Samoan (510-511)", Order = 63)]
        public int? PCT0080004 { get; set; }

        [Display(Name = "Tongan (513)", ShortName = "Tongan (513)", Order = 64)]
        public int? PCT0080005 { get; set; }

        [Display(Name = "Other Polynesian (504-509, 512, 514-519)", ShortName = "Other Polynesian (504-509, 512, 514-519)", Order = 65)]
        public int? PCT0080006 { get; set; }

        [Display(Name = "Micronesian (520-529, 531-541):", ShortName = "Micronesian (520-529, 531-541):", Order = 66)]
        public int? PCT0080007 { get; set; }

        [Display(Name = "Guamanian or Chamorro (520-522)", ShortName = "Guamanian or Chamorro (520-522)", Order = 67)]
        public int? PCT0080008 { get; set; }

        [Display(Name = "Marshallese (532)", ShortName = "Marshallese (532)", Order = 68)]
        public int? PCT0080009 { get; set; }

        [Display(Name = "Total Native Hawaiian and Other Pacific Islander categories tallied (500-599) & (500-599):", ShortName = "Total Native Hawaiian and Other Pacific Islander categories tallied (500-599) & (500-599):", Order = 69)]
        public int? PCT0090001 { get; set; }

        [Display(Name = "Polynesian (500-519) & (500-599):", ShortName = "Polynesian (500-519) & (500-599):", Order = 70)]
        public int? PCT0090002 { get; set; }

        [Display(Name = "Native Hawaiian (500-503) & (500-599)", ShortName = "Native Hawaiian (500-503) & (500-599)", Order = 71)]
        public int? PCT0090003 { get; set; }

        [Display(Name = "Samoan (510-511) & (500-599)", ShortName = "Samoan (510-511) & (500-599)", Order = 72)]
        public int? PCT0090004 { get; set; }

        [Display(Name = "Tongan (513) & (500-599)", ShortName = "Tongan (513) & (500-599)", Order = 73)]
        public int? PCT0090005 { get; set; }

        [Display(Name = "Other Polynesian (504-509, 512, 514-519) & (500-599)", ShortName = "Other Polynesian (504-509, 512, 514-519) & (500-599)", Order = 74)]
        public int? PCT0090006 { get; set; }

        [Display(Name = "Micronesian (520-529, 531-541) & (500-599):", ShortName = "Micronesian (520-529, 531-541) & (500-599):", Order = 75)]
        public int? PCT0090007 { get; set; }

        [Display(Name = "Guamanian or Chamorro (520-522) & (500-599)", ShortName = "Guamanian or Chamorro (520-522) & (500-599)", Order = 76)]
        public int? PCT0090008 { get; set; }

        [Display(Name = "Marshallese (532) & (500-599)", ShortName = "Marshallese (532) & (500-599)", Order = 77)]
        public int? PCT0090009 { get; set; }

        [Display(Name = "Other Micronesian (523-529, 531, 533-541) & (500-599)", ShortName = "Other Micronesian (523-529, 531, 533-541) & (500-599)", Order = 78)]
        public int? PCT0090010 { get; set; }

        [Display(Name = "Melanesian (542-546) & (500-599):", ShortName = "Melanesian (542-546) & (500-599):", Order = 79)]
        public int? PCT0090011 { get; set; }

        [Display(Name = "Fijian (542) & (500-599)", ShortName = "Fijian (542) & (500-599)", Order = 80)]
        public int? PCT0090012 { get; set; }

        [Display(Name = "Other Melanesian (543-546) & (500-599)", ShortName = "Other Melanesian (543-546) & (500-599)", Order = 81)]
        public int? PCT0090013 { get; set; }

        [Display(Name = "Other Pacific Islander, not specified (530, 547-599) & (500-599)", ShortName = "Other Pacific Islander, not specified (530, 547-599) & (500-599)", Order = 82)]
        public int? PCT0090014 { get; set; }

        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 83)]
        public int? PCT0090015 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 84)]
        public int? PCT0090016 { get; set; }

        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 85)]
        public int? PCT0090017 { get; set; }

        [Display(Name = "Male householder", ShortName = "Male householder", Order = 86)]
        public int? PCT0090018 { get; set; }

        [Display(Name = "Female householder", ShortName = "Female householder", Order = 87)]
        public int? PCT0090019 { get; set; }

        [Display(Name = "Total Native Hawaiian and Other Pacific Islander categories tallied (500-599) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Total Native Hawaiian and Other Pacific Islander categories tallied (500-599) & (100-299) or (300, A01-Z99) or (400-999):", Order = 88)]
        public int? PCT0100001 { get; set; }

        [Display(Name = "Polynesian (500-519) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Polynesian (500-519) & (100-299) or (300, A01-Z99) or (400-999):", Order = 89)]
        public int? PCT0100002 { get; set; }

        [Display(Name = "Native Hawaiian (500-503) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Native Hawaiian (500-503) & (100-299) or (300, A01-Z99) or (400-999)", Order = 90)]
        public int? PCT0100003 { get; set; }

        [Display(Name = "Samoan (510-511) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Samoan (510-511) & (100-299) or (300, A01-Z99) or (400-999)", Order = 91)]
        public int? PCT0100004 { get; set; }

        [Display(Name = "Tongan (513) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Tongan (513) & (100-299) or (300, A01-Z99) or (400-999)", Order = 92)]
        public int? PCT0100005 { get; set; }

        [Display(Name = "Other Polynesian (504-509, 512, 514-519) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Other Polynesian (504-509, 512, 514-519) & (100-299) or (300, A01-Z99) or (400-999)", Order = 93)]
        public int? PCT0100006 { get; set; }

        [Display(Name = "Micronesian (520-529, 531-541) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Micronesian (520-529, 531-541) & (100-299) or (300, A01-Z99) or (400-999):", Order = 94)]
        public int? PCT0100007 { get; set; }

        [Display(Name = "Guamanian or Chamorro (520-522) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Guamanian or Chamorro (520-522) & (100-299) or (300, A01-Z99) or (400-999)", Order = 95)]
        public int? PCT0100008 { get; set; }

        [Display(Name = "Marshallese (532) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Marshallese (532) & (100-299) or (300, A01-Z99) or (400-999)", Order = 96)]
        public int? PCT0100009 { get; set; }

        [Display(Name = "Other Micronesian (523-529, 531, 533-541)  & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Other Micronesian (523-529, 531, 533-541)  & (100-299) or (300, A01-Z99) or (400-999)", Order = 97)]
        public int? PCT0100010 { get; set; }

        [Display(Name = "Melanesian (542-546) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Melanesian (542-546) & (100-299) or (300, A01-Z99) or (400-999):", Order = 98)]
        public int? PCT0100011 { get; set; }

        [Display(Name = "Fijian (542) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Fijian (542) & (100-299) or (300, A01-Z99) or (400-999)", Order = 99)]
        public int? PCT0100012 { get; set; }

        [Display(Name = "Other Melanesian (543-546) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Other Melanesian (543-546) & (100-299) or (300, A01-Z99) or (400-999)", Order = 100)]
        public int? PCT0100013 { get; set; }

        [Display(Name = "Other Pacific Islander, not specified (530, 547-599) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Other Pacific Islander, not specified (530, 547-599) & (100-299) or (300, A01-Z99) or (400-999)", Order = 101)]
        public int? PCT0100014 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 102)]
        public int? PCT0100015 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 103)]
        public int? PCT0100016 { get; set; }

        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 104)]
        public int? PCT0100017 { get; set; }

        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 105)]
        public int? PCT0100018 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 106)]
        public int? PCT0100019 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 107)]
        public int? PCT0100020 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 108)]
        public int? PCT0100021 { get; set; }

        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 109)]
        public int? PCT0100022 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 110)]
        public int? PCT0100023 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 111)]
        public int? PCT0100024 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 112)]
        public int? PCT0100025 { get; set; }

        [Display(Name = "Households with no people under 18 years:", ShortName = "Households with no people under 18 years:", Order = 113)]
        public int? PCT0100026 { get; set; }

        [Display(Name = "Family households:", ShortName = "Family households:", Order = 114)]
        public int? PCT0100027 { get; set; }

        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 115)]
        public int? PCT0100028 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 116)]
        public int? PCT0100029 { get; set; }

        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 117)]
        public int? PCT0100030 { get; set; }

        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 118)]
        public int? PCT0100031 { get; set; }

        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 119)]
        public int? PCT0100032 { get; set; }

        [Display(Name = "Male householder", ShortName = "Male householder", Order = 120)]
        public int? PCT0100033 { get; set; }

        [Display(Name = "Female householder", ShortName = "Female householder", Order = 121)]
        public int? PCT0100034 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 122)]
        public int? PCT0110001 { get; set; }

        [Display(Name = "Not Hispanic or Latino (001-199, 300-999)", ShortName = "Not Hispanic or Latino (001-199, 300-999)", Order = 123)]
        public int? PCT0110002 { get; set; }

        [Display(Name = "Hispanic or Latino (200-299):", ShortName = "Hispanic or Latino (200-299):", Order = 124)]
        public int? PCT0110003 { get; set; }

        [Display(Name = "Mexican (210-220)", ShortName = "Mexican (210-220)", Order = 125)]
        public int? PCT0110004 { get; set; }

        [Display(Name = "Puerto Rican (260-269)", ShortName = "Puerto Rican (260-269)", Order = 126)]
        public int? PCT0110005 { get; set; }

        [Display(Name = "Cuban (270-274)", ShortName = "Cuban (270-274)", Order = 127)]
        public int? PCT0110006 { get; set; }

        [Display(Name = "Dominican (275-279)", ShortName = "Dominican (275-279)", Order = 128)]
        public int? PCT0110007 { get; set; }

        [Display(Name = "Central American (excluding Mexican) (221-230):", ShortName = "Central American (excluding Mexican) (221-230):", Order = 129)]
        public int? PCT0110008 { get; set; }

        [Display(Name = "Costa Rican (221)", ShortName = "Costa Rican (221)", Order = 130)]
        public int? PCT0110009 { get; set; }

        [Display(Name = "Guatemalan (222)", ShortName = "Guatemalan (222)", Order = 131)]
        public int? PCT0110010 { get; set; }

        [Display(Name = "Honduran (223)", ShortName = "Honduran (223)", Order = 132)]
        public int? PCT0110011 { get; set; }

        [Display(Name = "Nicaraguan (224)", ShortName = "Nicaraguan (224)", Order = 133)]
        public int? PCT0110012 { get; set; }

        [Display(Name = "Panamanian (225)", ShortName = "Panamanian (225)", Order = 134)]
        public int? PCT0110013 { get; set; }

        [Display(Name = "Salvadoran (226)", ShortName = "Salvadoran (226)", Order = 135)]
        public int? PCT0110014 { get; set; }

        [Display(Name = "Other Central American (227-230)", ShortName = "Other Central American (227-230)", Order = 136)]
        public int? PCT0110015 { get; set; }

        [Display(Name = "South American (231-249):", ShortName = "South American (231-249):", Order = 137)]
        public int? PCT0110016 { get; set; }

        [Display(Name = "Argentinean (231)", ShortName = "Argentinean (231)", Order = 138)]
        public int? PCT0110017 { get; set; }

        [Display(Name = "Bolivian (232)", ShortName = "Bolivian (232)", Order = 139)]
        public int? PCT0110018 { get; set; }

        [Display(Name = "Chilean (233)", ShortName = "Chilean (233)", Order = 140)]
        public int? PCT0110019 { get; set; }

        [Display(Name = "Colombian (234)", ShortName = "Colombian (234)", Order = 141)]
        public int? PCT0110020 { get; set; }

        [Display(Name = "Ecuadorian (235)", ShortName = "Ecuadorian (235)", Order = 142)]
        public int? PCT0110021 { get; set; }

        [Display(Name = "Paraguayan (236)", ShortName = "Paraguayan (236)", Order = 143)]
        public int? PCT0110022 { get; set; }

        [Display(Name = "Peruvian (237)", ShortName = "Peruvian (237)", Order = 144)]
        public int? PCT0110023 { get; set; }

        [Display(Name = "Uruguayan (238)", ShortName = "Uruguayan (238)", Order = 145)]
        public int? PCT0110024 { get; set; }

        [Display(Name = "Venezuelan (239)", ShortName = "Venezuelan (239)", Order = 146)]
        public int? PCT0110025 { get; set; }

        [Display(Name = "Other South American (240-249)", ShortName = "Other South American (240-249)", Order = 147)]
        public int? PCT0110026 { get; set; }

        [Display(Name = "Other Hispanic or Latino (200-209, 250-259, 280-299):", ShortName = "Other Hispanic or Latino (200-209, 250-259, 280-299):", Order = 148)]
        public int? PCT0110027 { get; set; }

        [Display(Name = "Spaniard (200-209)", ShortName = "Spaniard (200-209)", Order = 149)]
        public int? PCT0110028 { get; set; }

        [Display(Name = "Spanish (282)", ShortName = "Spanish (282)", Order = 150)]
        public int? PCT0110029 { get; set; }

        [Display(Name = "Spanish American (286)", ShortName = "Spanish American (286)", Order = 151)]
        public int? PCT0110030 { get; set; }

        [Display(Name = "All other Hispanic or Latino (250-259, 280-281, 283-285, 287-299)", ShortName = "All other Hispanic or Latino (250-259, 280-281, 283-285, 287-299)", Order = 152)]
        public int? PCT0110031 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 153)]
        public int? PCT0120001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 154)]
        public int? PCT0120002 { get; set; }

        [Display(Name = "Under 1 year", ShortName = "Under 1 year", Order = 155)]
        public int? PCT0120003 { get; set; }

        [Display(Name = "1 year", ShortName = "1 year", Order = 156)]
        public int? PCT0120004 { get; set; }

        [Display(Name = "2 years", ShortName = "2 years", Order = 157)]
        public int? PCT0120005 { get; set; }

        [Display(Name = "3 years", ShortName = "3 years", Order = 158)]
        public int? PCT0120006 { get; set; }

        [Display(Name = "4 years", ShortName = "4 years", Order = 159)]
        public int? PCT0120007 { get; set; }

        [Display(Name = "5 years", ShortName = "5 years", Order = 160)]
        public int? PCT0120008 { get; set; }

        [Display(Name = "6 years", ShortName = "6 years", Order = 161)]
        public int? PCT0120009 { get; set; }

        [Display(Name = "7 years", ShortName = "7 years", Order = 162)]
        public int? PCT0120010 { get; set; }

        [Display(Name = "8 years", ShortName = "8 years", Order = 163)]
        public int? PCT0120011 { get; set; }

        [Display(Name = "9 years", ShortName = "9 years", Order = 164)]
        public int? PCT0120012 { get; set; }

        [Display(Name = "10 years", ShortName = "10 years", Order = 165)]
        public int? PCT0120013 { get; set; }

        [Display(Name = "11 years", ShortName = "11 years", Order = 166)]
        public int? PCT0120014 { get; set; }

        [Display(Name = "12 years", ShortName = "12 years", Order = 167)]
        public int? PCT0120015 { get; set; }

        [Display(Name = "13 years", ShortName = "13 years", Order = 168)]
        public int? PCT0120016 { get; set; }

        [Display(Name = "14 years", ShortName = "14 years", Order = 169)]
        public int? PCT0120017 { get; set; }

        [Display(Name = "15 years", ShortName = "15 years", Order = 170)]
        public int? PCT0120018 { get; set; }

        [Display(Name = "16 years", ShortName = "16 years", Order = 171)]
        public int? PCT0120019 { get; set; }

        [Display(Name = "17 years", ShortName = "17 years", Order = 172)]
        public int? PCT0120020 { get; set; }

        [Display(Name = "18 years", ShortName = "18 years", Order = 173)]
        public int? PCT0120021 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 174)]
        public int? PCT0130001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 175)]
        public int? PCT0130002 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 176)]
        public int? PCT0130003 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 177)]
        public int? PCT0130004 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 178)]
        public int? PCT0130005 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 179)]
        public int? PCT0130006 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 180)]
        public int? PCT0130007 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 181)]
        public int? PCT0130008 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 182)]
        public int? PCT0130009 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 183)]
        public int? PCT0130010 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 184)]
        public int? PCT0130011 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 185)]
        public int? PCT0130012 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 186)]
        public int? PCT0130013 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 187)]
        public int? PCT0130014 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 188)]
        public int? PCT0130015 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 189)]
        public int? PCT0140001 { get; set; }

        [Display(Name = "Household has three or more generations", ShortName = "Household has three or more generations", Order = 190)]
        public int? PCT0140002 { get; set; }

        [Display(Name = "Household does not have three or more generations", ShortName = "Household does not have three or more generations", Order = 191)]
        public int? PCT0140003 { get; set; }

        [Display(Name = "2-or-more-person household:", ShortName = "2-or-more-person household:", Order = 192)]
        public int? PCT0140004 { get; set; }

        [Display(Name = "Family households", ShortName = "Family households", Order = 193)]
        public int? PCT0140005 { get; set; }

        [Display(Name = "Nonfamily households", ShortName = "Nonfamily households", Order = 194)]
        public int? PCT0140006 { get; set; }

        [Display(Name = "Households with no people 60 years and over:", ShortName = "Households with no people 60 years and over:", Order = 195)]
        public int? PCT0140007 { get; set; }

        [Display(Name = "1-person household", ShortName = "1-person household", Order = 196)]
        public int? PCT0140008 { get; set; }

        [Display(Name = "2-or-more-person household:", ShortName = "2-or-more-person household:", Order = 197)]
        public int? PCT0140009 { get; set; }

        [Display(Name = "Family households", ShortName = "Family households", Order = 198)]
        public int? PCT0140010 { get; set; }

        [Display(Name = "Nonfamily households", ShortName = "Nonfamily households", Order = 199)]
        public int? PCT0140011 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 200)]
        public int? PCT0150001 { get; set; }

        [Display(Name = "Husband-wife households:", ShortName = "Husband-wife households:", Order = 201)]
        public int? PCT0150002 { get; set; }

        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 202)]
        public int? PCT0150003 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 203)]
        public int? PCT0150004 { get; set; }

        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 204)]
        public int? PCT0150005 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 205)]
        public int? PCT0150006 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 206)]
        public int? PCT0150007 { get; set; }

        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 207)]
        public int? PCT0150008 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 208)]
        public int? PCT0150009 { get; set; }

        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 209)]
        public int? PCT0150010 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 210)]
        public int? PCT0150011 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 211)]
        public int? PCT0160001 { get; set; }

        [Display(Name = "Family households:", ShortName = "Family households:", Order = 212)]
        public int? PCT0160002 { get; set; }

        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 213)]
        public int? PCT0160003 { get; set; }

        [Display(Name = "With no children under 18 years", ShortName = "With no children under 18 years", Order = 214)]
        public int? PCT0160004 { get; set; }

        [Display(Name = "With one child under 18 years", ShortName = "With one child under 18 years", Order = 215)]
        public int? PCT0160005 { get; set; }

        [Display(Name = "With two children under 18 years", ShortName = "With two children under 18 years", Order = 216)]
        public int? PCT0160006 { get; set; }

        [Display(Name = "With three children under 18 years", ShortName = "With three children under 18 years", Order = 217)]
        public int? PCT0160007 { get; set; }

        [Display(Name = "With four or more children under 18 years", ShortName = "With four or more children under 18 years", Order = 218)]
        public int? PCT0160008 { get; set; }

        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 219)]
        public int? PCT0160009 { get; set; }

        [Display(Name = "With no children under 18 years", ShortName = "With no children under 18 years", Order = 220)]
        public int? PCT0160010 { get; set; }

        [Display(Name = "With one child under 18 years", ShortName = "With one child under 18 years", Order = 221)]
        public int? PCT0160011 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 222)]
        public int? PCT0170001 { get; set; }

        [Display(Name = "Unmarried partner of householder present:", ShortName = "Unmarried partner of householder present:", Order = 223)]
        public int? PCT0170002 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 224)]
        public int? PCT0170003 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 225)]
        public int? PCT0180001 { get; set; }

        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 226)]
        public int? PCT0180002 { get; set; }

        [Display(Name = "Living alone:", ShortName = "Living alone:", Order = 227)]
        public int? PCT0180003 { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}
