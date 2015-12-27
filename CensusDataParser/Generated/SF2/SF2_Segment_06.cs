#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 5:32 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF2_Segment_06.cs
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

    public class SF2_Segment_06
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
        public int? PCT0320001 { get; set; }

        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 6)]
        public int? PCT0320002 { get; set; }

        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 7)]
        public int? PCT0320003 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 8)]
        public int? PCT0320004 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 9)]
        public int? PCT0320005 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 10)]
        public int? PCT0320006 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 11)]
        public int? PCT0320007 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 12)]
        public int? PCT0320008 { get; set; }

        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 13)]
        public int? PCT0320009 { get; set; }

        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 14)]
        public int? PCT0320010 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 15)]
        public int? PCT0320011 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 16)]
        public int? PCT0320012 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 17)]
        public int? PCT0320013 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 18)]
        public int? PCT0320014 { get; set; }

        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 19)]
        public int? PCT0320015 { get; set; }

        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 20)]
        public int? PCT0320016 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 21)]
        public int? PCT0320017 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 22)]
        public int? PCT0320018 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 23)]
        public int? PCT0320019 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 24)]
        public int? PCT0320020 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 25)]
        public int? PCT0330001 { get; set; }

        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 26)]
        public int? PCT0330002 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 27)]
        public int? PCT0330003 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 28)]
        public int? PCT0330004 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 29)]
        public int? PCT0330005 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 30)]
        public int? PCT0330006 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 31)]
        public int? PCT0330007 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 32)]
        public int? PCT0330008 { get; set; }

        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 33)]
        public int? PCT0330009 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 34)]
        public int? PCT0330010 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 35)]
        public int? PCT0330011 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 36)]
        public int? PCT0330012 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 37)]
        public int? PCT0330013 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 38)]
        public int? PCT0330014 { get; set; }

        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 39)]
        public int? PCT0330015 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 40)]
        public int? PCT0330016 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 41)]
        public int? PCT0330017 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 42)]
        public int? PCT0330018 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 43)]
        public int? PCT0330019 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 44)]
        public int? PCT0330020 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 45)]
        public int? PCT0340001 { get; set; }

        [Display(Name = "In husband-wife families:", ShortName = "In husband-wife families:", Order = 46)]
        public int? PCT0340002 { get; set; }

        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 47)]
        public int? PCT0340003 { get; set; }

        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 48)]
        public int? PCT0340004 { get; set; }

        [Display(Name = "5 years", ShortName = "5 years", Order = 49)]
        public int? PCT0340005 { get; set; }

        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 50)]
        public int? PCT0340006 { get; set; }

        [Display(Name = "12 to 17 years", ShortName = "12 to 17 years", Order = 51)]
        public int? PCT0340007 { get; set; }

        [Display(Name = "In other families:", ShortName = "In other families:", Order = 52)]
        public int? PCT0340008 { get; set; }

        [Display(Name = "In male householder, no wife present family:", ShortName = "In male householder, no wife present family:", Order = 53)]
        public int? PCT0340009 { get; set; }

        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 54)]
        public int? PCT0340010 { get; set; }

        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 55)]
        public int? PCT0340011 { get; set; }

        [Display(Name = "5 years", ShortName = "5 years", Order = 56)]
        public int? PCT0340012 { get; set; }

        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 57)]
        public int? PCT0340013 { get; set; }

        [Display(Name = "12 to 17 years", ShortName = "12 to 17 years", Order = 58)]
        public int? PCT0340014 { get; set; }

        [Display(Name = "In female householder, no husband present family:", ShortName = "In female householder, no husband present family:", Order = 59)]
        public int? PCT0340015 { get; set; }

        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 60)]
        public int? PCT0340016 { get; set; }

        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 61)]
        public int? PCT0340017 { get; set; }

        [Display(Name = "5 years", ShortName = "5 years", Order = 62)]
        public int? PCT0340018 { get; set; }

        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 63)]
        public int? PCT0340019 { get; set; }

        [Display(Name = "12 to 17 years", ShortName = "12 to 17 years", Order = 64)]
        public int? PCT0340020 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 65)]
        public int? PCT0350001 { get; set; }

        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 66)]
        public int? PCT0350002 { get; set; }

        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 67)]
        public int? PCT0350003 { get; set; }

        [Display(Name = "5 years", ShortName = "5 years", Order = 68)]
        public int? PCT0350004 { get; set; }

        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 69)]
        public int? PCT0350005 { get; set; }

        [Display(Name = "12 to 17 years", ShortName = "12 to 17 years", Order = 70)]
        public int? PCT0350006 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 71)]
        public int? PCT0360001 { get; set; }

        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 72)]
        public int? PCT0360002 { get; set; }

        [Display(Name = "Living alone:", ShortName = "Living alone:", Order = 73)]
        public int? PCT0360003 { get; set; }

        [Display(Name = "Householder 15 to 64 years", ShortName = "Householder 15 to 64 years", Order = 74)]
        public int? PCT0360004 { get; set; }

        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 75)]
        public int? PCT0360005 { get; set; }

        [Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 76)]
        public int? PCT0360006 { get; set; }

        [Display(Name = "Householder 15 to 64 years", ShortName = "Householder 15 to 64 years", Order = 77)]
        public int? PCT0360007 { get; set; }

        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 78)]
        public int? PCT0360008 { get; set; }

        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 79)]
        public int? PCT0360009 { get; set; }

        [Display(Name = "Living alone:", ShortName = "Living alone:", Order = 80)]
        public int? PCT0360010 { get; set; }

        [Display(Name = "Householder 15 to 64 years", ShortName = "Householder 15 to 64 years", Order = 81)]
        public int? PCT0360011 { get; set; }

        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 82)]
        public int? PCT0360012 { get; set; }

        [Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 83)]
        public int? PCT0360013 { get; set; }

        [Display(Name = "Householder 15 to 64 years", ShortName = "Householder 15 to 64 years", Order = 84)]
        public int? PCT0360014 { get; set; }

        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 85)]
        public int? PCT0360015 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 86)]
        public int? PCT0370001 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 87)]
        public int? PCT0370002 { get; set; }

        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 88)]
        public int? PCT0370003 { get; set; }

        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 89)]
        public int? PCT0370004 { get; set; }

        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 90)]
        public int? PCT0370005 { get; set; }

        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 91)]
        public int? PCT0370006 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 92)]
        public int? PCT0370007 { get; set; }

        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 93)]
        public int? PCT0370008 { get; set; }

        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 94)]
        public int? PCT0370009 { get; set; }

        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 95)]
        public int? PCT0370010 { get; set; }

        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 96)]
        public int? PCT0370011 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 97)]
        public int? PCT038_0001 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 98)]
        public int? PCT038_0002 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 99)]
        public int? PCT038_0003 { get; set; }

        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 100)]
        public int? PCT038_0004 { get; set; }

        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 101)]
        public int? PCT038_0005 { get; set; }

        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 102)]
        public int? PCT038_0006 { get; set; }

        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 103)]
        public int? PCT038_0007 { get; set; }

        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 104)]
        public int? PCT038_0008 { get; set; }

        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 105)]
        public int? PCT038_0009 { get; set; }

        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 106)]
        public int? PCT038_0010 { get; set; }

        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 107)]
        public int? PCT038_0011 { get; set; }

        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 108)]
        public int? PCT038_0012 { get; set; }

        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 109)]
        public int? PCT038_0013 { get; set; }

        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 110)]
        public int? PCT038_0014 { get; set; }

        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 111)]
        public int? PCT038_0015 { get; set; }

        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 112)]
        public int? PCT038_0016 { get; set; }

        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 113)]
        public int? PCT038_0017 { get; set; }

        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 114)]
        public int? PCT038_0018 { get; set; }

        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 115)]
        public int? PCT038_0019 { get; set; }

        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 116)]
        public int? PCT038_0020 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 117)]
        public int? PCT038_0021 { get; set; }

        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 118)]
        public int? PCT038_0022 { get; set; }

        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 119)]
        public int? PCT038_0023 { get; set; }

        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 120)]
        public int? PCT038_0024 { get; set; }

        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 121)]
        public int? PCT038_0025 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 122)]
        public int? PCT038_0026 { get; set; }

        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 123)]
        public int? PCT038_0027 { get; set; }

        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 124)]
        public int? PCT038_0028 { get; set; }

        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 125)]
        public int? PCT038_0029 { get; set; }

        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 126)]
        public int? PCT038_0030 { get; set; }

        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 127)]
        public int? PCT038_0031 { get; set; }

        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 128)]
        public int? PCT038_0032 { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}
