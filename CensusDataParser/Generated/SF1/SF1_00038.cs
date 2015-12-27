#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 5:31 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1_00038.cs
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

    public class SF1_00038
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
        public int? PCT020F001 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 6)]
        public int? PCT020F002 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 7)]
        public int? PCT020F003 { get; set; }

        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 8)]
        public int? PCT020F004 { get; set; }

        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 9)]
        public int? PCT020F005 { get; set; }

        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 10)]
        public int? PCT020F006 { get; set; }

        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 11)]
        public int? PCT020F007 { get; set; }

        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 12)]
        public int? PCT020F008 { get; set; }

        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 13)]
        public int? PCT020F009 { get; set; }

        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 14)]
        public int? PCT020F010 { get; set; }

        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 15)]
        public int? PCT020F011 { get; set; }

        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 16)]
        public int? PCT020F012 { get; set; }

        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 17)]
        public int? PCT020F013 { get; set; }

        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 18)]
        public int? PCT020F014 { get; set; }

        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 19)]
        public int? PCT020F015 { get; set; }

        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 20)]
        public int? PCT020F016 { get; set; }

        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 21)]
        public int? PCT020F017 { get; set; }

        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 22)]
        public int? PCT020F018 { get; set; }

        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 23)]
        public int? PCT020F019 { get; set; }

        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 24)]
        public int? PCT020F020 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 25)]
        public int? PCT020F021 { get; set; }

        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 26)]
        public int? PCT020F022 { get; set; }

        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 27)]
        public int? PCT020F023 { get; set; }

        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 28)]
        public int? PCT020F024 { get; set; }

        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 29)]
        public int? PCT020F025 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 30)]
        public int? PCT020F026 { get; set; }

        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 31)]
        public int? PCT020F027 { get; set; }

        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 32)]
        public int? PCT020F028 { get; set; }

        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 33)]
        public int? PCT020F029 { get; set; }

        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 34)]
        public int? PCT020F030 { get; set; }

        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 35)]
        public int? PCT020F031 { get; set; }

        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 36)]
        public int? PCT020F032 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 37)]
        public int? PCT020G001 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 38)]
        public int? PCT020G002 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 39)]
        public int? PCT020G003 { get; set; }

        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 40)]
        public int? PCT020G004 { get; set; }

        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 41)]
        public int? PCT020G005 { get; set; }

        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 42)]
        public int? PCT020G006 { get; set; }

        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 43)]
        public int? PCT020G007 { get; set; }

        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 44)]
        public int? PCT020G008 { get; set; }

        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 45)]
        public int? PCT020G009 { get; set; }

        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 46)]
        public int? PCT020G010 { get; set; }

        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 47)]
        public int? PCT020G011 { get; set; }

        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 48)]
        public int? PCT020G012 { get; set; }

        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 49)]
        public int? PCT020G013 { get; set; }

        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 50)]
        public int? PCT020G014 { get; set; }

        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 51)]
        public int? PCT020G015 { get; set; }

        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 52)]
        public int? PCT020G016 { get; set; }

        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 53)]
        public int? PCT020G017 { get; set; }

        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 54)]
        public int? PCT020G018 { get; set; }

        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 55)]
        public int? PCT020G019 { get; set; }

        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 56)]
        public int? PCT020G020 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 57)]
        public int? PCT020G021 { get; set; }

        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 58)]
        public int? PCT020G022 { get; set; }

        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 59)]
        public int? PCT020G023 { get; set; }

        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 60)]
        public int? PCT020G024 { get; set; }

        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 61)]
        public int? PCT020G025 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 62)]
        public int? PCT020G026 { get; set; }

        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 63)]
        public int? PCT020G027 { get; set; }

        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 64)]
        public int? PCT020G028 { get; set; }

        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 65)]
        public int? PCT020G029 { get; set; }

        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 66)]
        public int? PCT020G030 { get; set; }

        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 67)]
        public int? PCT020G031 { get; set; }

        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 68)]
        public int? PCT020G032 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 69)]
        public int? PCT020H001 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 70)]
        public int? PCT020H002 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 71)]
        public int? PCT020H003 { get; set; }

        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 72)]
        public int? PCT020H004 { get; set; }

        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 73)]
        public int? PCT020H005 { get; set; }

        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 74)]
        public int? PCT020H006 { get; set; }

        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 75)]
        public int? PCT020H007 { get; set; }

        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 76)]
        public int? PCT020H008 { get; set; }

        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 77)]
        public int? PCT020H009 { get; set; }

        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 78)]
        public int? PCT020H010 { get; set; }

        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 79)]
        public int? PCT020H011 { get; set; }

        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 80)]
        public int? PCT020H012 { get; set; }

        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 81)]
        public int? PCT020H013 { get; set; }

        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 82)]
        public int? PCT020H014 { get; set; }

        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 83)]
        public int? PCT020H015 { get; set; }

        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 84)]
        public int? PCT020H016 { get; set; }

        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 85)]
        public int? PCT020H017 { get; set; }

        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 86)]
        public int? PCT020H018 { get; set; }

        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 87)]
        public int? PCT020H019 { get; set; }

        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 88)]
        public int? PCT020H020 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 89)]
        public int? PCT020H021 { get; set; }

        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 90)]
        public int? PCT020H022 { get; set; }

        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 91)]
        public int? PCT020H023 { get; set; }

        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 92)]
        public int? PCT020H024 { get; set; }

        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 93)]
        public int? PCT020H025 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 94)]
        public int? PCT020H026 { get; set; }

        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 95)]
        public int? PCT020H027 { get; set; }

        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 96)]
        public int? PCT020H028 { get; set; }

        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 97)]
        public int? PCT020H029 { get; set; }

        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 98)]
        public int? PCT020H030 { get; set; }

        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 99)]
        public int? PCT020H031 { get; set; }

        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 100)]
        public int? PCT020H032 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 101)]
        public int? PCT020I001 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 102)]
        public int? PCT020I002 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 103)]
        public int? PCT020I003 { get; set; }

        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 104)]
        public int? PCT020I004 { get; set; }

        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 105)]
        public int? PCT020I005 { get; set; }

        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 106)]
        public int? PCT020I006 { get; set; }

        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 107)]
        public int? PCT020I007 { get; set; }

        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 108)]
        public int? PCT020I008 { get; set; }

        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 109)]
        public int? PCT020I009 { get; set; }

        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 110)]
        public int? PCT020I010 { get; set; }

        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 111)]
        public int? PCT020I011 { get; set; }

        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 112)]
        public int? PCT020I012 { get; set; }

        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 113)]
        public int? PCT020I013 { get; set; }

        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 114)]
        public int? PCT020I014 { get; set; }

        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 115)]
        public int? PCT020I015 { get; set; }

        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 116)]
        public int? PCT020I016 { get; set; }

        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 117)]
        public int? PCT020I017 { get; set; }

        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 118)]
        public int? PCT020I018 { get; set; }

        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 119)]
        public int? PCT020I019 { get; set; }

        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 120)]
        public int? PCT020I020 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 121)]
        public int? PCT020I021 { get; set; }

        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 122)]
        public int? PCT020I022 { get; set; }

        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 123)]
        public int? PCT020I023 { get; set; }

        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 124)]
        public int? PCT020I024 { get; set; }

        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 125)]
        public int? PCT020I025 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 126)]
        public int? PCT020I026 { get; set; }

        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 127)]
        public int? PCT020I027 { get; set; }

        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 128)]
        public int? PCT020I028 { get; set; }

        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 129)]
        public int? PCT020I029 { get; set; }

        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 130)]
        public int? PCT020I030 { get; set; }

        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 131)]
        public int? PCT020I031 { get; set; }

        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 132)]
        public int? PCT020I032 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 133)]
        public int? PCT022A001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 134)]
        public int? PCT022A002 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 135)]
        public int? PCT022A003 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 136)]
        public int? PCT022A004 { get; set; }

        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 137)]
        public int? PCT022A005 { get; set; }

        [Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 138)]
        public int? PCT022A006 { get; set; }

        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 139)]
        public int? PCT022A007 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 140)]
        public int? PCT022A008 { get; set; }

        [Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 141)]
        public int? PCT022A009 { get; set; }

        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 142)]
        public int? PCT022A010 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 143)]
        public int? PCT022A011 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 144)]
        public int? PCT022A012 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 145)]
        public int? PCT022A013 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 146)]
        public int? PCT022A014 { get; set; }

        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 147)]
        public int? PCT022A015 { get; set; }

        [Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 148)]
        public int? PCT022A016 { get; set; }

        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 149)]
        public int? PCT022A017 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 150)]
        public int? PCT022A018 { get; set; }

        [Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 151)]
        public int? PCT022A019 { get; set; }

        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 152)]
        public int? PCT022A020 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 153)]
        public int? PCT022A021 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 154)]
        public int? PCT022B001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 155)]
        public int? PCT022B002 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 156)]
        public int? PCT022B003 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 157)]
        public int? PCT022B004 { get; set; }

        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 158)]
        public int? PCT022B005 { get; set; }

        [Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 159)]
        public int? PCT022B006 { get; set; }

        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 160)]
        public int? PCT022B007 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 161)]
        public int? PCT022B008 { get; set; }

        [Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 162)]
        public int? PCT022B009 { get; set; }

        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 163)]
        public int? PCT022B010 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 164)]
        public int? PCT022B011 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 165)]
        public int? PCT022B012 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 166)]
        public int? PCT022B013 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 167)]
        public int? PCT022B014 { get; set; }

        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 168)]
        public int? PCT022B015 { get; set; }

        [Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 169)]
        public int? PCT022B016 { get; set; }

        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 170)]
        public int? PCT022B017 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 171)]
        public int? PCT022B018 { get; set; }

        [Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 172)]
        public int? PCT022B019 { get; set; }

        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 173)]
        public int? PCT022B020 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 174)]
        public int? PCT022B021 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 175)]
        public int? PCT022C001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 176)]
        public int? PCT022C002 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 177)]
        public int? PCT022C003 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 178)]
        public int? PCT022C004 { get; set; }

        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 179)]
        public int? PCT022C005 { get; set; }

        [Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 180)]
        public int? PCT022C006 { get; set; }

        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 181)]
        public int? PCT022C007 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 182)]
        public int? PCT022C008 { get; set; }

        [Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 183)]
        public int? PCT022C009 { get; set; }

        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 184)]
        public int? PCT022C010 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 185)]
        public int? PCT022C011 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 186)]
        public int? PCT022C012 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 187)]
        public int? PCT022C013 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 188)]
        public int? PCT022C014 { get; set; }

        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 189)]
        public int? PCT022C015 { get; set; }

        [Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 190)]
        public int? PCT022C016 { get; set; }

        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 191)]
        public int? PCT022C017 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 192)]
        public int? PCT022C018 { get; set; }

        [Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 193)]
        public int? PCT022C019 { get; set; }

        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 194)]
        public int? PCT022C020 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 195)]
        public int? PCT022C021 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 196)]
        public int? PCT022D001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 197)]
        public int? PCT022D002 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 198)]
        public int? PCT022D003 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 199)]
        public int? PCT022D004 { get; set; }

        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 200)]
        public int? PCT022D005 { get; set; }

        [Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 201)]
        public int? PCT022D006 { get; set; }

        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 202)]
        public int? PCT022D007 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 203)]
        public int? PCT022D008 { get; set; }

        [Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 204)]
        public int? PCT022D009 { get; set; }

        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 205)]
        public int? PCT022D010 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 206)]
        public int? PCT022D011 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 207)]
        public int? PCT022D012 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 208)]
        public int? PCT022D013 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 209)]
        public int? PCT022D014 { get; set; }

        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 210)]
        public int? PCT022D015 { get; set; }

        [Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 211)]
        public int? PCT022D016 { get; set; }

        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 212)]
        public int? PCT022D017 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 213)]
        public int? PCT022D018 { get; set; }

        [Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 214)]
        public int? PCT022D019 { get; set; }

        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 215)]
        public int? PCT022D020 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 216)]
        public int? PCT022D021 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 217)]
        public int? PCT022E001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 218)]
        public int? PCT022E002 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 219)]
        public int? PCT022E003 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 220)]
        public int? PCT022E004 { get; set; }

        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 221)]
        public int? PCT022E005 { get; set; }

        [Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 222)]
        public int? PCT022E006 { get; set; }

        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 223)]
        public int? PCT022E007 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 224)]
        public int? PCT022E008 { get; set; }

        [Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 225)]
        public int? PCT022E009 { get; set; }

        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 226)]
        public int? PCT022E010 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 227)]
        public int? PCT022E011 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 228)]
        public int? PCT022E012 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 229)]
        public int? PCT022E013 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 230)]
        public int? PCT022E014 { get; set; }

        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 231)]
        public int? PCT022E015 { get; set; }

        [Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 232)]
        public int? PCT022E016 { get; set; }

        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 233)]
        public int? PCT022E017 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 234)]
        public int? PCT022E018 { get; set; }

        [Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 235)]
        public int? PCT022E019 { get; set; }

        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 236)]
        public int? PCT022E020 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 237)]
        public int? PCT022E021 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 238)]
        public int? PCT022F001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 239)]
        public int? PCT022F002 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 240)]
        public int? PCT022F003 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 241)]
        public int? PCT022F004 { get; set; }

        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 242)]
        public int? PCT022F005 { get; set; }

        [Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 243)]
        public int? PCT022F006 { get; set; }

        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 244)]
        public int? PCT022F007 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 245)]
        public int? PCT022F008 { get; set; }

        [Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 246)]
        public int? PCT022F009 { get; set; }

        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 247)]
        public int? PCT022F010 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 248)]
        public int? PCT022F011 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 249)]
        public int? PCT022F012 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 250)]
        public int? PCT022F013 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 251)]
        public int? PCT022F014 { get; set; }

        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 252)]
        public int? PCT022F015 { get; set; }

        [Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 253)]
        public int? PCT022F016 { get; set; }

        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 254)]
        public int? PCT022F017 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 255)]
        public int? PCT022F018 { get; set; }

        [Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 256)]
        public int? PCT022F019 { get; set; }

        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 257)]
        public int? PCT022F020 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 258)]
        public int? PCT022F021 { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}
