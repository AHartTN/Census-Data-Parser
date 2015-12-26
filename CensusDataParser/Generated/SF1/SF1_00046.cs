#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 4:09 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1_00046.cs
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

    public class SF1_00046
    {
        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
        public string CHARITER { get; set; }

        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
        public string CIFSN { get; set; }

        [Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
        public string FILEID { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public int? H017D0001 { get; set; }

        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 6)]
        public int? H017D0002 { get; set; }

        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 7)]
        public int? H017D0003 { get; set; }

        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 8)]
        public int? H017D0004 { get; set; }

        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 9)]
        public int? H017D0005 { get; set; }

        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 10)]
        public int? H017D0006 { get; set; }

        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 11)]
        public int? H017D0007 { get; set; }

        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 12)]
        public int? H017D0008 { get; set; }

        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 13)]
        public int? H017D0009 { get; set; }

        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 14)]
        public int? H017D0010 { get; set; }

        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 15)]
        public int? H017D0011 { get; set; }

        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 16)]
        public int? H017D0012 { get; set; }

        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 17)]
        public int? H017D0013 { get; set; }

        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 18)]
        public int? H017D0014 { get; set; }

        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 19)]
        public int? H017D0015 { get; set; }

        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 20)]
        public int? H017D0016 { get; set; }

        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 21)]
        public int? H017D0017 { get; set; }

        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 22)]
        public int? H017D0018 { get; set; }

        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 23)]
        public int? H017D0019 { get; set; }

        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 24)]
        public int? H017D0020 { get; set; }

        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 25)]
        public int? H017D0021 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 26)]
        public int? H017E0001 { get; set; }

        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 27)]
        public int? H017E0002 { get; set; }

        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 28)]
        public int? H017E0003 { get; set; }

        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 29)]
        public int? H017E0004 { get; set; }

        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 30)]
        public int? H017E0005 { get; set; }

        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 31)]
        public int? H017E0006 { get; set; }

        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 32)]
        public int? H017E0007 { get; set; }

        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 33)]
        public int? H017E0008 { get; set; }

        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 34)]
        public int? H017E0009 { get; set; }

        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 35)]
        public int? H017E0010 { get; set; }

        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 36)]
        public int? H017E0011 { get; set; }

        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 37)]
        public int? H017E0012 { get; set; }

        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 38)]
        public int? H017E0013 { get; set; }

        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 39)]
        public int? H017E0014 { get; set; }

        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 40)]
        public int? H017E0015 { get; set; }

        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 41)]
        public int? H017E0016 { get; set; }

        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 42)]
        public int? H017E0017 { get; set; }

        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 43)]
        public int? H017E0018 { get; set; }

        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 44)]
        public int? H017E0019 { get; set; }

        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 45)]
        public int? H017E0020 { get; set; }

        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 46)]
        public int? H017E0021 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 47)]
        public int? H017F0001 { get; set; }

        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 48)]
        public int? H017F0002 { get; set; }

        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 49)]
        public int? H017F0003 { get; set; }

        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 50)]
        public int? H017F0004 { get; set; }

        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 51)]
        public int? H017F0005 { get; set; }

        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 52)]
        public int? H017F0006 { get; set; }

        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 53)]
        public int? H017F0007 { get; set; }

        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 54)]
        public int? H017F0008 { get; set; }

        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 55)]
        public int? H017F0009 { get; set; }

        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 56)]
        public int? H017F0010 { get; set; }

        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 57)]
        public int? H017F0011 { get; set; }

        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 58)]
        public int? H017F0012 { get; set; }

        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 59)]
        public int? H017F0013 { get; set; }

        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 60)]
        public int? H017F0014 { get; set; }

        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 61)]
        public int? H017F0015 { get; set; }

        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 62)]
        public int? H017F0016 { get; set; }

        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 63)]
        public int? H017F0017 { get; set; }

        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 64)]
        public int? H017F0018 { get; set; }

        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 65)]
        public int? H017F0019 { get; set; }

        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 66)]
        public int? H017F0020 { get; set; }

        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 67)]
        public int? H017F0021 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 68)]
        public int? H017G0001 { get; set; }

        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 69)]
        public int? H017G0002 { get; set; }

        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 70)]
        public int? H017G0003 { get; set; }

        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 71)]
        public int? H017G0004 { get; set; }

        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 72)]
        public int? H017G0005 { get; set; }

        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 73)]
        public int? H017G0006 { get; set; }

        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 74)]
        public int? H017G0007 { get; set; }

        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 75)]
        public int? H017G0008 { get; set; }

        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 76)]
        public int? H017G0009 { get; set; }

        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 77)]
        public int? H017G0010 { get; set; }

        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 78)]
        public int? H017G0011 { get; set; }

        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 79)]
        public int? H017G0012 { get; set; }

        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 80)]
        public int? H017G0013 { get; set; }

        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 81)]
        public int? H017G0014 { get; set; }

        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 82)]
        public int? H017G0015 { get; set; }

        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 83)]
        public int? H017G0016 { get; set; }

        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 84)]
        public int? H017G0017 { get; set; }

        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 85)]
        public int? H017G0018 { get; set; }

        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 86)]
        public int? H017G0019 { get; set; }

        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 87)]
        public int? H017G0020 { get; set; }

        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 88)]
        public int? H017G0021 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 89)]
        public int? H017H0001 { get; set; }

        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 90)]
        public int? H017H0002 { get; set; }

        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 91)]
        public int? H017H0003 { get; set; }

        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 92)]
        public int? H017H0004 { get; set; }

        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 93)]
        public int? H017H0005 { get; set; }

        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 94)]
        public int? H017H0006 { get; set; }

        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 95)]
        public int? H017H0007 { get; set; }

        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 96)]
        public int? H017H0008 { get; set; }

        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 97)]
        public int? H017H0009 { get; set; }

        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 98)]
        public int? H017H0010 { get; set; }

        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 99)]
        public int? H017H0011 { get; set; }

        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 100)]
        public int? H017H0012 { get; set; }

        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 101)]
        public int? H017H0013 { get; set; }

        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 102)]
        public int? H017H0014 { get; set; }

        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 103)]
        public int? H017H0015 { get; set; }

        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 104)]
        public int? H017H0016 { get; set; }

        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 105)]
        public int? H017H0017 { get; set; }

        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 106)]
        public int? H017H0018 { get; set; }

        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 107)]
        public int? H017H0019 { get; set; }

        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 108)]
        public int? H017H0020 { get; set; }

        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 109)]
        public int? H017H0021 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 110)]
        public int? H017I0001 { get; set; }

        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 111)]
        public int? H017I0002 { get; set; }

        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 112)]
        public int? H017I0003 { get; set; }

        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 113)]
        public int? H017I0004 { get; set; }

        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 114)]
        public int? H017I0005 { get; set; }

        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 115)]
        public int? H017I0006 { get; set; }

        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 116)]
        public int? H017I0007 { get; set; }

        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 117)]
        public int? H017I0008 { get; set; }

        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 118)]
        public int? H017I0009 { get; set; }

        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 119)]
        public int? H017I0010 { get; set; }

        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 120)]
        public int? H017I0011 { get; set; }

        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 121)]
        public int? H017I0012 { get; set; }

        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 122)]
        public int? H017I0013 { get; set; }

        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 123)]
        public int? H017I0014 { get; set; }

        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 124)]
        public int? H017I0015 { get; set; }

        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 125)]
        public int? H017I0016 { get; set; }

        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 126)]
        public int? H017I0017 { get; set; }

        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 127)]
        public int? H017I0018 { get; set; }

        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 128)]
        public int? H017I0019 { get; set; }

        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 129)]
        public int? H017I0020 { get; set; }

        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 130)]
        public int? H017I0021 { get; set; }

        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
        public int? LOGRECNO { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}
