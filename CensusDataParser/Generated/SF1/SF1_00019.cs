#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 5:31 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1_00019.cs
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

    public class SF1_00019
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
        public int? PCT0210001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 6)]
        public int? PCT0210002 { get; set; }

        [Display(Name = "Under 18 years:", ShortName = "Under 18 years:", Order = 7)]
        public int? PCT0210003 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301,  401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301,  401-405):", Order = 8)]
        public int? PCT0210004 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 9)]
        public int? PCT0210005 { get; set; }

        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 10)]
        public int? PCT0210006 { get; set; }

        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 11)]
        public int? PCT0210007 { get; set; }

        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 12)]
        public int? PCT0210008 { get; set; }

        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 13)]
        public int? PCT0210009 { get; set; }

        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 14)]
        public int? PCT0210010 { get; set; }

        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 15)]
        public int? PCT0210011 { get; set; }

        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 16)]
        public int? PCT0210012 { get; set; }

        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 17)]
        public int? PCT0210013 { get; set; }

        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 18)]
        public int? PCT0210014 { get; set; }

        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 19)]
        public int? PCT0210015 { get; set; }

        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 20)]
        public int? PCT0210016 { get; set; }

        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 21)]
        public int? PCT0210017 { get; set; }

        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 22)]
        public int? PCT0210018 { get; set; }

        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 23)]
        public int? PCT0210019 { get; set; }

        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 24)]
        public int? PCT0210020 { get; set; }

        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 25)]
        public int? PCT0210021 { get; set; }

        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 26)]
        public int? PCT0210022 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 27)]
        public int? PCT0210023 { get; set; }

        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 28)]
        public int? PCT0210024 { get; set; }

        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 29)]
        public int? PCT0210025 { get; set; }

        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 30)]
        public int? PCT0210026 { get; set; }

        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 31)]
        public int? PCT0210027 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 32)]
        public int? PCT0210028 { get; set; }

        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 33)]
        public int? PCT0210029 { get; set; }

        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 34)]
        public int? PCT0210030 { get; set; }

        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 35)]
        public int? PCT0210031 { get; set; }

        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 36)]
        public int? PCT0210032 { get; set; }

        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 37)]
        public int? PCT0210033 { get; set; }

        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 38)]
        public int? PCT0210034 { get; set; }

        [Display(Name = "18 to 64 years:", ShortName = "18 to 64 years:", Order = 39)]
        public int? PCT0210035 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301,  401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301,  401-405):", Order = 40)]
        public int? PCT0210036 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 41)]
        public int? PCT0210037 { get; set; }

        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 42)]
        public int? PCT0210038 { get; set; }

        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 43)]
        public int? PCT0210039 { get; set; }

        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 44)]
        public int? PCT0210040 { get; set; }

        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 45)]
        public int? PCT0210041 { get; set; }

        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 46)]
        public int? PCT0210042 { get; set; }

        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 47)]
        public int? PCT0210043 { get; set; }

        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 48)]
        public int? PCT0210044 { get; set; }

        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 49)]
        public int? PCT0210045 { get; set; }

        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 50)]
        public int? PCT0210046 { get; set; }

        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 51)]
        public int? PCT0210047 { get; set; }

        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 52)]
        public int? PCT0210048 { get; set; }

        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 53)]
        public int? PCT0210049 { get; set; }

        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 54)]
        public int? PCT0210050 { get; set; }

        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 55)]
        public int? PCT0210051 { get; set; }

        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 56)]
        public int? PCT0210052 { get; set; }

        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 57)]
        public int? PCT0210053 { get; set; }

        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 58)]
        public int? PCT0210054 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 59)]
        public int? PCT0210055 { get; set; }

        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 60)]
        public int? PCT0210056 { get; set; }

        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 61)]
        public int? PCT0210057 { get; set; }

        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 62)]
        public int? PCT0210058 { get; set; }

        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 63)]
        public int? PCT0210059 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 64)]
        public int? PCT0210060 { get; set; }

        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 65)]
        public int? PCT0210061 { get; set; }

        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 66)]
        public int? PCT0210062 { get; set; }

        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 67)]
        public int? PCT0210063 { get; set; }

        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 68)]
        public int? PCT0210064 { get; set; }

        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 69)]
        public int? PCT0210065 { get; set; }

        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 70)]
        public int? PCT0210066 { get; set; }

        [Display(Name = "65 years and over:", ShortName = "65 years and over:", Order = 71)]
        public int? PCT0210067 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301,  401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301,  401-405):", Order = 72)]
        public int? PCT0210068 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 73)]
        public int? PCT0210069 { get; set; }

        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 74)]
        public int? PCT0210070 { get; set; }

        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 75)]
        public int? PCT0210071 { get; set; }

        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 76)]
        public int? PCT0210072 { get; set; }

        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 77)]
        public int? PCT0210073 { get; set; }

        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 78)]
        public int? PCT0210074 { get; set; }

        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 79)]
        public int? PCT0210075 { get; set; }

        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 80)]
        public int? PCT0210076 { get; set; }

        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 81)]
        public int? PCT0210077 { get; set; }

        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 82)]
        public int? PCT0210078 { get; set; }

        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 83)]
        public int? PCT0210079 { get; set; }

        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 84)]
        public int? PCT0210080 { get; set; }

        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 85)]
        public int? PCT0210081 { get; set; }

        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 86)]
        public int? PCT0210082 { get; set; }

        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 87)]
        public int? PCT0210083 { get; set; }

        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 88)]
        public int? PCT0210084 { get; set; }

        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 89)]
        public int? PCT0210085 { get; set; }

        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 90)]
        public int? PCT0210086 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 91)]
        public int? PCT0210087 { get; set; }

        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 92)]
        public int? PCT0210088 { get; set; }

        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 93)]
        public int? PCT0210089 { get; set; }

        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 94)]
        public int? PCT0210090 { get; set; }

        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 95)]
        public int? PCT0210091 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 96)]
        public int? PCT0210092 { get; set; }

        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 97)]
        public int? PCT0210093 { get; set; }

        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 98)]
        public int? PCT0210094 { get; set; }

        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 99)]
        public int? PCT0210095 { get; set; }

        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 100)]
        public int? PCT0210096 { get; set; }

        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 101)]
        public int? PCT0210097 { get; set; }

        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 102)]
        public int? PCT0210098 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 103)]
        public int? PCT0210099 { get; set; }

        [Display(Name = "Under 18 years:", ShortName = "Under 18 years:", Order = 104)]
        public int? PCT0210100 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301,  401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301,  401-405):", Order = 105)]
        public int? PCT0210101 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 106)]
        public int? PCT0210102 { get; set; }

        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 107)]
        public int? PCT0210103 { get; set; }

        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 108)]
        public int? PCT0210104 { get; set; }

        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 109)]
        public int? PCT0210105 { get; set; }

        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 110)]
        public int? PCT0210106 { get; set; }

        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 111)]
        public int? PCT0210107 { get; set; }

        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 112)]
        public int? PCT0210108 { get; set; }

        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 113)]
        public int? PCT0210109 { get; set; }

        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 114)]
        public int? PCT0210110 { get; set; }

        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 115)]
        public int? PCT0210111 { get; set; }

        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 116)]
        public int? PCT0210112 { get; set; }

        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 117)]
        public int? PCT0210113 { get; set; }

        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 118)]
        public int? PCT0210114 { get; set; }

        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 119)]
        public int? PCT0210115 { get; set; }

        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 120)]
        public int? PCT0210116 { get; set; }

        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 121)]
        public int? PCT0210117 { get; set; }

        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 122)]
        public int? PCT0210118 { get; set; }

        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 123)]
        public int? PCT0210119 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 124)]
        public int? PCT0210120 { get; set; }

        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 125)]
        public int? PCT0210121 { get; set; }

        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 126)]
        public int? PCT0210122 { get; set; }

        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 127)]
        public int? PCT0210123 { get; set; }

        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 128)]
        public int? PCT0210124 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 129)]
        public int? PCT0210125 { get; set; }

        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 130)]
        public int? PCT0210126 { get; set; }

        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 131)]
        public int? PCT0210127 { get; set; }

        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 132)]
        public int? PCT0210128 { get; set; }

        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 133)]
        public int? PCT0210129 { get; set; }

        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 134)]
        public int? PCT0210130 { get; set; }

        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 135)]
        public int? PCT0210131 { get; set; }

        [Display(Name = "18 to 64 years:", ShortName = "18 to 64 years:", Order = 136)]
        public int? PCT0210132 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301,  401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301,  401-405):", Order = 137)]
        public int? PCT0210133 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 138)]
        public int? PCT0210134 { get; set; }

        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 139)]
        public int? PCT0210135 { get; set; }

        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 140)]
        public int? PCT0210136 { get; set; }

        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 141)]
        public int? PCT0210137 { get; set; }

        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 142)]
        public int? PCT0210138 { get; set; }

        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 143)]
        public int? PCT0210139 { get; set; }

        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 144)]
        public int? PCT0210140 { get; set; }

        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 145)]
        public int? PCT0210141 { get; set; }

        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 146)]
        public int? PCT0210142 { get; set; }

        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 147)]
        public int? PCT0210143 { get; set; }

        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 148)]
        public int? PCT0210144 { get; set; }

        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 149)]
        public int? PCT0210145 { get; set; }

        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 150)]
        public int? PCT0210146 { get; set; }

        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 151)]
        public int? PCT0210147 { get; set; }

        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 152)]
        public int? PCT0210148 { get; set; }

        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 153)]
        public int? PCT0210149 { get; set; }

        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 154)]
        public int? PCT0210150 { get; set; }

        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 155)]
        public int? PCT0210151 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 156)]
        public int? PCT0210152 { get; set; }

        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 157)]
        public int? PCT0210153 { get; set; }

        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 158)]
        public int? PCT0210154 { get; set; }

        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 159)]
        public int? PCT0210155 { get; set; }

        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 160)]
        public int? PCT0210156 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 161)]
        public int? PCT0210157 { get; set; }

        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 162)]
        public int? PCT0210158 { get; set; }

        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 163)]
        public int? PCT0210159 { get; set; }

        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 164)]
        public int? PCT0210160 { get; set; }

        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 165)]
        public int? PCT0210161 { get; set; }

        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 166)]
        public int? PCT0210162 { get; set; }

        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 167)]
        public int? PCT0210163 { get; set; }

        [Display(Name = "65 years and over:", ShortName = "65 years and over:", Order = 168)]
        public int? PCT0210164 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301,  401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301,  401-405):", Order = 169)]
        public int? PCT0210165 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 170)]
        public int? PCT0210166 { get; set; }

        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 171)]
        public int? PCT0210167 { get; set; }

        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 172)]
        public int? PCT0210168 { get; set; }

        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 173)]
        public int? PCT0210169 { get; set; }

        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 174)]
        public int? PCT0210170 { get; set; }

        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 175)]
        public int? PCT0210171 { get; set; }

        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 176)]
        public int? PCT0210172 { get; set; }

        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 177)]
        public int? PCT0210173 { get; set; }

        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 178)]
        public int? PCT0210174 { get; set; }

        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 179)]
        public int? PCT0210175 { get; set; }

        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 180)]
        public int? PCT0210176 { get; set; }

        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 181)]
        public int? PCT0210177 { get; set; }

        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 182)]
        public int? PCT0210178 { get; set; }

        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 183)]
        public int? PCT0210179 { get; set; }

        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 184)]
        public int? PCT0210180 { get; set; }

        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 185)]
        public int? PCT0210181 { get; set; }

        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 186)]
        public int? PCT0210182 { get; set; }

        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 187)]
        public int? PCT0210183 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 188)]
        public int? PCT0210184 { get; set; }

        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 189)]
        public int? PCT0210185 { get; set; }

        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 190)]
        public int? PCT0210186 { get; set; }

        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 191)]
        public int? PCT0210187 { get; set; }

        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 192)]
        public int? PCT0210188 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 193)]
        public int? PCT0210189 { get; set; }

        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 194)]
        public int? PCT0210190 { get; set; }

        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 195)]
        public int? PCT0210191 { get; set; }

        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 196)]
        public int? PCT0210192 { get; set; }

        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 197)]
        public int? PCT0210193 { get; set; }

        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 198)]
        public int? PCT0210194 { get; set; }

        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 199)]
        public int? PCT0210195 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 200)]
        public int? PCT0220001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 201)]
        public int? PCT0220002 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 202)]
        public int? PCT0220003 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 203)]
        public int? PCT0220004 { get; set; }

        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 204)]
        public int? PCT0220005 { get; set; }

        [Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 205)]
        public int? PCT0220006 { get; set; }

        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 206)]
        public int? PCT0220007 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 207)]
        public int? PCT0220008 { get; set; }

        [Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 208)]
        public int? PCT0220009 { get; set; }

        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 209)]
        public int? PCT0220010 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 210)]
        public int? PCT0220011 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 211)]
        public int? PCT0220012 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 212)]
        public int? PCT0220013 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 213)]
        public int? PCT0220014 { get; set; }

        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 214)]
        public int? PCT0220015 { get; set; }

        [Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 215)]
        public int? PCT0220016 { get; set; }

        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 216)]
        public int? PCT0220017 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 217)]
        public int? PCT0220018 { get; set; }

        [Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 218)]
        public int? PCT0220019 { get; set; }

        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 219)]
        public int? PCT0220020 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 220)]
        public int? PCT0220021 { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}
