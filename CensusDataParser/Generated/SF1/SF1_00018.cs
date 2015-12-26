#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 4:10 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1_00018.cs
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

    public class SF1_00018
    {
        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
        public string CHARITER { get; set; }

        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
        public string CIFSN { get; set; }

        [Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
        public string FILEID { get; set; }

        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
        public int? LOGRECNO { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public int? PCT0130001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 6)]
        public int? PCT0130002 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 7)]
        public int? PCT0130003 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 8)]
        public int? PCT0130004 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 9)]
        public int? PCT0130005 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 10)]
        public int? PCT0130006 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 11)]
        public int? PCT0130007 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 12)]
        public int? PCT0130008 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 13)]
        public int? PCT0130009 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 14)]
        public int? PCT0130010 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 15)]
        public int? PCT0130011 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 16)]
        public int? PCT0130012 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 17)]
        public int? PCT0130013 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 18)]
        public int? PCT0130014 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 19)]
        public int? PCT0130015 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 20)]
        public int? PCT0130016 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 21)]
        public int? PCT0130017 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 22)]
        public int? PCT0130018 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 23)]
        public int? PCT0130019 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 24)]
        public int? PCT0130020 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 25)]
        public int? PCT0130021 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 26)]
        public int? PCT0130022 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 27)]
        public int? PCT0130023 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 28)]
        public int? PCT0130024 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 29)]
        public int? PCT0130025 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 30)]
        public int? PCT0130026 { get; set; }

        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 31)]
        public int? PCT0130027 { get; set; }

        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 32)]
        public int? PCT0130028 { get; set; }

        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 33)]
        public int? PCT0130029 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 34)]
        public int? PCT0130030 { get; set; }

        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 35)]
        public int? PCT0130031 { get; set; }

        [Display(Name = "20 years", ShortName = "20 years", Order = 36)]
        public int? PCT0130032 { get; set; }

        [Display(Name = "21 years", ShortName = "21 years", Order = 37)]
        public int? PCT0130033 { get; set; }

        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 38)]
        public int? PCT0130034 { get; set; }

        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 39)]
        public int? PCT0130035 { get; set; }

        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 40)]
        public int? PCT0130036 { get; set; }

        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 41)]
        public int? PCT0130037 { get; set; }

        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 42)]
        public int? PCT0130038 { get; set; }

        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 43)]
        public int? PCT0130039 { get; set; }

        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 44)]
        public int? PCT0130040 { get; set; }

        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 45)]
        public int? PCT0130041 { get; set; }

        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 46)]
        public int? PCT0130042 { get; set; }

        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 47)]
        public int? PCT0130043 { get; set; }

        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 48)]
        public int? PCT0130044 { get; set; }

        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 49)]
        public int? PCT0130045 { get; set; }

        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 50)]
        public int? PCT0130046 { get; set; }

        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 51)]
        public int? PCT0130047 { get; set; }

        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 52)]
        public int? PCT0130048 { get; set; }

        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 53)]
        public int? PCT0130049 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 54)]
        public int? PCT0140001 { get; set; }

        [Display(Name = "Household has three or more generations", ShortName = "Household has three or more generations", Order = 55)]
        public int? PCT0140002 { get; set; }

        [Display(Name = "Household does not have three or more generations", ShortName = "Household does not have three or more generations", Order = 56)]
        public int? PCT0140003 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 57)]
        public int? PCT0150001 { get; set; }

        [Display(Name = "Husband-wife households:", ShortName = "Husband-wife households:", Order = 58)]
        public int? PCT0150002 { get; set; }

        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 59)]
        public int? PCT0150003 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 60)]
        public int? PCT0150004 { get; set; }

        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 61)]
        public int? PCT0150005 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 62)]
        public int? PCT0150006 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 63)]
        public int? PCT0150007 { get; set; }

        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 64)]
        public int? PCT0150008 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 65)]
        public int? PCT0150009 { get; set; }

        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 66)]
        public int? PCT0150010 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 67)]
        public int? PCT0150011 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 68)]
        public int? PCT0150012 { get; set; }

        [Display(Name = "Unmarried-partner households:", ShortName = "Unmarried-partner households:", Order = 69)]
        public int? PCT0150013 { get; set; }

        [Display(Name = "Male householder and male partner:", ShortName = "Male householder and male partner:", Order = 70)]
        public int? PCT0150014 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 71)]
        public int? PCT0150015 { get; set; }

        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 72)]
        public int? PCT0150016 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 73)]
        public int? PCT0150017 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 74)]
        public int? PCT0150018 { get; set; }

        [Display(Name = "Male householder and female partner:", ShortName = "Male householder and female partner:", Order = 75)]
        public int? PCT0150019 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 76)]
        public int? PCT0150020 { get; set; }

        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 77)]
        public int? PCT0150021 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 78)]
        public int? PCT0150022 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 79)]
        public int? PCT0150023 { get; set; }

        [Display(Name = "Female householder and female partner:", ShortName = "Female householder and female partner:", Order = 80)]
        public int? PCT0150024 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 81)]
        public int? PCT0150025 { get; set; }

        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 82)]
        public int? PCT0150026 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 83)]
        public int? PCT0150027 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 84)]
        public int? PCT0150028 { get; set; }

        [Display(Name = "Female householder and male partner:", ShortName = "Female householder and male partner:", Order = 85)]
        public int? PCT0150029 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 86)]
        public int? PCT0150030 { get; set; }

        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 87)]
        public int? PCT0150031 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 88)]
        public int? PCT0150032 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 89)]
        public int? PCT0150033 { get; set; }

        [Display(Name = "All other households", ShortName = "All other households", Order = 90)]
        public int? PCT0150034 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 91)]
        public int? PCT0160001 { get; set; }

        [Display(Name = "Family households:", ShortName = "Family households:", Order = 92)]
        public int? PCT0160002 { get; set; }

        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 93)]
        public int? PCT0160003 { get; set; }

        [Display(Name = "With no children under 18 years", ShortName = "With no children under 18 years", Order = 94)]
        public int? PCT0160004 { get; set; }

        [Display(Name = "With one child under 18 years", ShortName = "With one child under 18 years", Order = 95)]
        public int? PCT0160005 { get; set; }

        [Display(Name = "With two children under 18 years", ShortName = "With two children under 18 years", Order = 96)]
        public int? PCT0160006 { get; set; }

        [Display(Name = "With three children under 18 years", ShortName = "With three children under 18 years", Order = 97)]
        public int? PCT0160007 { get; set; }

        [Display(Name = "With four or more children under 18 years", ShortName = "With four or more children under 18 years", Order = 98)]
        public int? PCT0160008 { get; set; }

        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 99)]
        public int? PCT0160009 { get; set; }

        [Display(Name = "With no children under 18 years", ShortName = "With no children under 18 years", Order = 100)]
        public int? PCT0160010 { get; set; }

        [Display(Name = "With one child under 18 years", ShortName = "With one child under 18 years", Order = 101)]
        public int? PCT0160011 { get; set; }

        [Display(Name = "With two children under 18 years", ShortName = "With two children under 18 years", Order = 102)]
        public int? PCT0160012 { get; set; }

        [Display(Name = "With three children under 18 years", ShortName = "With three children under 18 years", Order = 103)]
        public int? PCT0160013 { get; set; }

        [Display(Name = "With four or more children under 18 years", ShortName = "With four or more children under 18 years", Order = 104)]
        public int? PCT0160014 { get; set; }

        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 105)]
        public int? PCT0160015 { get; set; }

        [Display(Name = "With no children under 18 years", ShortName = "With no children under 18 years", Order = 106)]
        public int? PCT0160016 { get; set; }

        [Display(Name = "With one child under 18 years", ShortName = "With one child under 18 years", Order = 107)]
        public int? PCT0160017 { get; set; }

        [Display(Name = "With two children under 18 years", ShortName = "With two children under 18 years", Order = 108)]
        public int? PCT0160018 { get; set; }

        [Display(Name = "With three children under 18 years", ShortName = "With three children under 18 years", Order = 109)]
        public int? PCT0160019 { get; set; }

        [Display(Name = "With four or more children under 18 years", ShortName = "With four or more children under 18 years", Order = 110)]
        public int? PCT0160020 { get; set; }

        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 111)]
        public int? PCT0160021 { get; set; }

        [Display(Name = "With no children under 18 years", ShortName = "With no children under 18 years", Order = 112)]
        public int? PCT0160022 { get; set; }

        [Display(Name = "With one child under 18 years", ShortName = "With one child under 18 years", Order = 113)]
        public int? PCT0160023 { get; set; }

        [Display(Name = "With two children under 18 years", ShortName = "With two children under 18 years", Order = 114)]
        public int? PCT0160024 { get; set; }

        [Display(Name = "With three children under 18 years", ShortName = "With three children under 18 years", Order = 115)]
        public int? PCT0160025 { get; set; }

        [Display(Name = "With four or more children under 18 years", ShortName = "With four or more children under 18 years", Order = 116)]
        public int? PCT0160026 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 117)]
        public int? PCT0170001 { get; set; }

        [Display(Name = "Unmarried partner of householder present:", ShortName = "Unmarried partner of householder present:", Order = 118)]
        public int? PCT0170002 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 119)]
        public int? PCT0170003 { get; set; }

        [Display(Name = "In male householder and male partner households", ShortName = "In male householder and male partner households", Order = 120)]
        public int? PCT0170004 { get; set; }

        [Display(Name = "In male householder and female partner households", ShortName = "In male householder and female partner households", Order = 121)]
        public int? PCT0170005 { get; set; }

        [Display(Name = "In female householder and female partner households", ShortName = "In female householder and female partner households", Order = 122)]
        public int? PCT0170006 { get; set; }

        [Display(Name = "In female householder and male partner households", ShortName = "In female householder and male partner households", Order = 123)]
        public int? PCT0170007 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 124)]
        public int? PCT0170008 { get; set; }

        [Display(Name = "In male householder and male partner households", ShortName = "In male householder and male partner households", Order = 125)]
        public int? PCT0170009 { get; set; }

        [Display(Name = "In male householder and female partner households", ShortName = "In male householder and female partner households", Order = 126)]
        public int? PCT0170010 { get; set; }

        [Display(Name = "In female householder and female partner households", ShortName = "In female householder and female partner households", Order = 127)]
        public int? PCT0170011 { get; set; }

        [Display(Name = "In female householder and male partner households", ShortName = "In female householder and male partner households", Order = 128)]
        public int? PCT0170012 { get; set; }

        [Display(Name = "No unmarried partner of householder present:", ShortName = "No unmarried partner of householder present:", Order = 129)]
        public int? PCT0170013 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 130)]
        public int? PCT0170014 { get; set; }

        [Display(Name = "In husband-wife family households", ShortName = "In husband-wife family households", Order = 131)]
        public int? PCT0170015 { get; set; }

        [Display(Name = "In male householder, no wife present, family households", ShortName = "In male householder, no wife present, family households", Order = 132)]
        public int? PCT0170016 { get; set; }

        [Display(Name = "In female householder, no husband present, family households", ShortName = "In female householder, no husband present, family households", Order = 133)]
        public int? PCT0170017 { get; set; }

        [Display(Name = "In nonfamily households", ShortName = "In nonfamily households", Order = 134)]
        public int? PCT0170018 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 135)]
        public int? PCT0180001 { get; set; }

        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 136)]
        public int? PCT0180002 { get; set; }

        [Display(Name = "Living alone:", ShortName = "Living alone:", Order = 137)]
        public int? PCT0180003 { get; set; }

        [Display(Name = "Householder 15 to 64 years", ShortName = "Householder 15 to 64 years", Order = 138)]
        public int? PCT0180004 { get; set; }

        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 139)]
        public int? PCT0180005 { get; set; }

        [Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 140)]
        public int? PCT0180006 { get; set; }

        [Display(Name = "Householder 15 to 64 years", ShortName = "Householder 15 to 64 years", Order = 141)]
        public int? PCT0180007 { get; set; }

        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 142)]
        public int? PCT0180008 { get; set; }

        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 143)]
        public int? PCT0180009 { get; set; }

        [Display(Name = "Living alone:", ShortName = "Living alone:", Order = 144)]
        public int? PCT0180010 { get; set; }

        [Display(Name = "Householder 15 to 64 years", ShortName = "Householder 15 to 64 years", Order = 145)]
        public int? PCT0180011 { get; set; }

        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 146)]
        public int? PCT0180012 { get; set; }

        [Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 147)]
        public int? PCT0180013 { get; set; }

        [Display(Name = "Householder 15 to 64 years", ShortName = "Householder 15 to 64 years", Order = 148)]
        public int? PCT0180014 { get; set; }

        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 149)]
        public int? PCT0180015 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 150)]
        public int? PCT0190001 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 151)]
        public int? PCT0190002 { get; set; }

        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 152)]
        public int? PCT0190003 { get; set; }

        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 153)]
        public int? PCT0190004 { get; set; }

        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 154)]
        public int? PCT0190005 { get; set; }

        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 155)]
        public int? PCT0190006 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 156)]
        public int? PCT0190007 { get; set; }

        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 157)]
        public int? PCT0190008 { get; set; }

        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 158)]
        public int? PCT0190009 { get; set; }

        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 159)]
        public int? PCT0190010 { get; set; }

        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 160)]
        public int? PCT0190011 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 161)]
        public int? PCT0200001 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 162)]
        public int? PCT0200002 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 163)]
        public int? PCT0200003 { get; set; }

        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 164)]
        public int? PCT0200004 { get; set; }

        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 165)]
        public int? PCT0200005 { get; set; }

        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 166)]
        public int? PCT0200006 { get; set; }

        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 167)]
        public int? PCT0200007 { get; set; }

        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 168)]
        public int? PCT0200008 { get; set; }

        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 169)]
        public int? PCT0200009 { get; set; }

        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 170)]
        public int? PCT0200010 { get; set; }

        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 171)]
        public int? PCT0200011 { get; set; }

        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 172)]
        public int? PCT0200012 { get; set; }

        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 173)]
        public int? PCT0200013 { get; set; }

        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 174)]
        public int? PCT0200014 { get; set; }

        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 175)]
        public int? PCT0200015 { get; set; }

        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 176)]
        public int? PCT0200016 { get; set; }

        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 177)]
        public int? PCT0200017 { get; set; }

        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 178)]
        public int? PCT0200018 { get; set; }

        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 179)]
        public int? PCT0200019 { get; set; }

        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 180)]
        public int? PCT0200020 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 181)]
        public int? PCT0200021 { get; set; }

        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 182)]
        public int? PCT0200022 { get; set; }

        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 183)]
        public int? PCT0200023 { get; set; }

        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 184)]
        public int? PCT0200024 { get; set; }

        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 185)]
        public int? PCT0200025 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 186)]
        public int? PCT0200026 { get; set; }

        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 187)]
        public int? PCT0200027 { get; set; }

        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 188)]
        public int? PCT0200028 { get; set; }

        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 189)]
        public int? PCT0200029 { get; set; }

        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 190)]
        public int? PCT0200030 { get; set; }

        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 191)]
        public int? PCT0200031 { get; set; }

        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 192)]
        public int? PCT0200032 { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}
