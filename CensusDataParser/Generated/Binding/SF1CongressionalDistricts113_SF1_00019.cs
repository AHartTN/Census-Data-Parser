#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/06/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1CongressionalDistricts113_SF1_00019.cs
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
	#endregion

	public class SF1CongressionalDistricts113_SF1_00019 : BaseModel
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
		#endregion Properties

		#region Constructors
		public SF1CongressionalDistricts113_SF1_00019(string csvLine) : base(csvLine) { }

		public SF1CongressionalDistricts113_SF1_00019(string[] values) : base(values) { }

		public SF1CongressionalDistricts113_SF1_00019(OleDbDataReader reader)
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
				PCT0210001 = (int?)reader[5];
			}
			if (reader[6] != DBNull.Value)
			{
				PCT0210002 = (int?)reader[6];
			}
			if (reader[7] != DBNull.Value)
			{
				PCT0210003 = (int?)reader[7];
			}
			if (reader[8] != DBNull.Value)
			{
				PCT0210004 = (int?)reader[8];
			}
			if (reader[9] != DBNull.Value)
			{
				PCT0210005 = (int?)reader[9];
			}
			if (reader[10] != DBNull.Value)
			{
				PCT0210006 = (int?)reader[10];
			}
			if (reader[11] != DBNull.Value)
			{
				PCT0210007 = (int?)reader[11];
			}
			if (reader[12] != DBNull.Value)
			{
				PCT0210008 = (int?)reader[12];
			}
			if (reader[13] != DBNull.Value)
			{
				PCT0210009 = (int?)reader[13];
			}
			if (reader[14] != DBNull.Value)
			{
				PCT0210010 = (int?)reader[14];
			}
			if (reader[15] != DBNull.Value)
			{
				PCT0210011 = (int?)reader[15];
			}
			if (reader[16] != DBNull.Value)
			{
				PCT0210012 = (int?)reader[16];
			}
			if (reader[17] != DBNull.Value)
			{
				PCT0210013 = (int?)reader[17];
			}
			if (reader[18] != DBNull.Value)
			{
				PCT0210014 = (int?)reader[18];
			}
			if (reader[19] != DBNull.Value)
			{
				PCT0210015 = (int?)reader[19];
			}
			if (reader[20] != DBNull.Value)
			{
				PCT0210016 = (int?)reader[20];
			}
			if (reader[21] != DBNull.Value)
			{
				PCT0210017 = (int?)reader[21];
			}
			if (reader[22] != DBNull.Value)
			{
				PCT0210018 = (int?)reader[22];
			}
			if (reader[23] != DBNull.Value)
			{
				PCT0210019 = (int?)reader[23];
			}
			if (reader[24] != DBNull.Value)
			{
				PCT0210020 = (int?)reader[24];
			}
			if (reader[25] != DBNull.Value)
			{
				PCT0210021 = (int?)reader[25];
			}
			if (reader[26] != DBNull.Value)
			{
				PCT0210022 = (int?)reader[26];
			}
			if (reader[27] != DBNull.Value)
			{
				PCT0210023 = (int?)reader[27];
			}
			if (reader[28] != DBNull.Value)
			{
				PCT0210024 = (int?)reader[28];
			}
			if (reader[29] != DBNull.Value)
			{
				PCT0210025 = (int?)reader[29];
			}
			if (reader[30] != DBNull.Value)
			{
				PCT0210026 = (int?)reader[30];
			}
			if (reader[31] != DBNull.Value)
			{
				PCT0210027 = (int?)reader[31];
			}
			if (reader[32] != DBNull.Value)
			{
				PCT0210028 = (int?)reader[32];
			}
			if (reader[33] != DBNull.Value)
			{
				PCT0210029 = (int?)reader[33];
			}
			if (reader[34] != DBNull.Value)
			{
				PCT0210030 = (int?)reader[34];
			}
			if (reader[35] != DBNull.Value)
			{
				PCT0210031 = (int?)reader[35];
			}
			if (reader[36] != DBNull.Value)
			{
				PCT0210032 = (int?)reader[36];
			}
			if (reader[37] != DBNull.Value)
			{
				PCT0210033 = (int?)reader[37];
			}
			if (reader[38] != DBNull.Value)
			{
				PCT0210034 = (int?)reader[38];
			}
			if (reader[39] != DBNull.Value)
			{
				PCT0210035 = (int?)reader[39];
			}
			if (reader[40] != DBNull.Value)
			{
				PCT0210036 = (int?)reader[40];
			}
			if (reader[41] != DBNull.Value)
			{
				PCT0210037 = (int?)reader[41];
			}
			if (reader[42] != DBNull.Value)
			{
				PCT0210038 = (int?)reader[42];
			}
			if (reader[43] != DBNull.Value)
			{
				PCT0210039 = (int?)reader[43];
			}
			if (reader[44] != DBNull.Value)
			{
				PCT0210040 = (int?)reader[44];
			}
			if (reader[45] != DBNull.Value)
			{
				PCT0210041 = (int?)reader[45];
			}
			if (reader[46] != DBNull.Value)
			{
				PCT0210042 = (int?)reader[46];
			}
			if (reader[47] != DBNull.Value)
			{
				PCT0210043 = (int?)reader[47];
			}
			if (reader[48] != DBNull.Value)
			{
				PCT0210044 = (int?)reader[48];
			}
			if (reader[49] != DBNull.Value)
			{
				PCT0210045 = (int?)reader[49];
			}
			if (reader[50] != DBNull.Value)
			{
				PCT0210046 = (int?)reader[50];
			}
			if (reader[51] != DBNull.Value)
			{
				PCT0210047 = (int?)reader[51];
			}
			if (reader[52] != DBNull.Value)
			{
				PCT0210048 = (int?)reader[52];
			}
			if (reader[53] != DBNull.Value)
			{
				PCT0210049 = (int?)reader[53];
			}
			if (reader[54] != DBNull.Value)
			{
				PCT0210050 = (int?)reader[54];
			}
			if (reader[55] != DBNull.Value)
			{
				PCT0210051 = (int?)reader[55];
			}
			if (reader[56] != DBNull.Value)
			{
				PCT0210052 = (int?)reader[56];
			}
			if (reader[57] != DBNull.Value)
			{
				PCT0210053 = (int?)reader[57];
			}
			if (reader[58] != DBNull.Value)
			{
				PCT0210054 = (int?)reader[58];
			}
			if (reader[59] != DBNull.Value)
			{
				PCT0210055 = (int?)reader[59];
			}
			if (reader[60] != DBNull.Value)
			{
				PCT0210056 = (int?)reader[60];
			}
			if (reader[61] != DBNull.Value)
			{
				PCT0210057 = (int?)reader[61];
			}
			if (reader[62] != DBNull.Value)
			{
				PCT0210058 = (int?)reader[62];
			}
			if (reader[63] != DBNull.Value)
			{
				PCT0210059 = (int?)reader[63];
			}
			if (reader[64] != DBNull.Value)
			{
				PCT0210060 = (int?)reader[64];
			}
			if (reader[65] != DBNull.Value)
			{
				PCT0210061 = (int?)reader[65];
			}
			if (reader[66] != DBNull.Value)
			{
				PCT0210062 = (int?)reader[66];
			}
			if (reader[67] != DBNull.Value)
			{
				PCT0210063 = (int?)reader[67];
			}
			if (reader[68] != DBNull.Value)
			{
				PCT0210064 = (int?)reader[68];
			}
			if (reader[69] != DBNull.Value)
			{
				PCT0210065 = (int?)reader[69];
			}
			if (reader[70] != DBNull.Value)
			{
				PCT0210066 = (int?)reader[70];
			}
			if (reader[71] != DBNull.Value)
			{
				PCT0210067 = (int?)reader[71];
			}
			if (reader[72] != DBNull.Value)
			{
				PCT0210068 = (int?)reader[72];
			}
			if (reader[73] != DBNull.Value)
			{
				PCT0210069 = (int?)reader[73];
			}
			if (reader[74] != DBNull.Value)
			{
				PCT0210070 = (int?)reader[74];
			}
			if (reader[75] != DBNull.Value)
			{
				PCT0210071 = (int?)reader[75];
			}
			if (reader[76] != DBNull.Value)
			{
				PCT0210072 = (int?)reader[76];
			}
			if (reader[77] != DBNull.Value)
			{
				PCT0210073 = (int?)reader[77];
			}
			if (reader[78] != DBNull.Value)
			{
				PCT0210074 = (int?)reader[78];
			}
			if (reader[79] != DBNull.Value)
			{
				PCT0210075 = (int?)reader[79];
			}
			if (reader[80] != DBNull.Value)
			{
				PCT0210076 = (int?)reader[80];
			}
			if (reader[81] != DBNull.Value)
			{
				PCT0210077 = (int?)reader[81];
			}
			if (reader[82] != DBNull.Value)
			{
				PCT0210078 = (int?)reader[82];
			}
			if (reader[83] != DBNull.Value)
			{
				PCT0210079 = (int?)reader[83];
			}
			if (reader[84] != DBNull.Value)
			{
				PCT0210080 = (int?)reader[84];
			}
			if (reader[85] != DBNull.Value)
			{
				PCT0210081 = (int?)reader[85];
			}
			if (reader[86] != DBNull.Value)
			{
				PCT0210082 = (int?)reader[86];
			}
			if (reader[87] != DBNull.Value)
			{
				PCT0210083 = (int?)reader[87];
			}
			if (reader[88] != DBNull.Value)
			{
				PCT0210084 = (int?)reader[88];
			}
			if (reader[89] != DBNull.Value)
			{
				PCT0210085 = (int?)reader[89];
			}
			if (reader[90] != DBNull.Value)
			{
				PCT0210086 = (int?)reader[90];
			}
			if (reader[91] != DBNull.Value)
			{
				PCT0210087 = (int?)reader[91];
			}
			if (reader[92] != DBNull.Value)
			{
				PCT0210088 = (int?)reader[92];
			}
			if (reader[93] != DBNull.Value)
			{
				PCT0210089 = (int?)reader[93];
			}
			if (reader[94] != DBNull.Value)
			{
				PCT0210090 = (int?)reader[94];
			}
			if (reader[95] != DBNull.Value)
			{
				PCT0210091 = (int?)reader[95];
			}
			if (reader[96] != DBNull.Value)
			{
				PCT0210092 = (int?)reader[96];
			}
			if (reader[97] != DBNull.Value)
			{
				PCT0210093 = (int?)reader[97];
			}
			if (reader[98] != DBNull.Value)
			{
				PCT0210094 = (int?)reader[98];
			}
			if (reader[99] != DBNull.Value)
			{
				PCT0210095 = (int?)reader[99];
			}
			if (reader[100] != DBNull.Value)
			{
				PCT0210096 = (int?)reader[100];
			}
			if (reader[101] != DBNull.Value)
			{
				PCT0210097 = (int?)reader[101];
			}
			if (reader[102] != DBNull.Value)
			{
				PCT0210098 = (int?)reader[102];
			}
			if (reader[103] != DBNull.Value)
			{
				PCT0210099 = (int?)reader[103];
			}
			if (reader[104] != DBNull.Value)
			{
				PCT0210100 = (int?)reader[104];
			}
			if (reader[105] != DBNull.Value)
			{
				PCT0210101 = (int?)reader[105];
			}
			if (reader[106] != DBNull.Value)
			{
				PCT0210102 = (int?)reader[106];
			}
			if (reader[107] != DBNull.Value)
			{
				PCT0210103 = (int?)reader[107];
			}
			if (reader[108] != DBNull.Value)
			{
				PCT0210104 = (int?)reader[108];
			}
			if (reader[109] != DBNull.Value)
			{
				PCT0210105 = (int?)reader[109];
			}
			if (reader[110] != DBNull.Value)
			{
				PCT0210106 = (int?)reader[110];
			}
			if (reader[111] != DBNull.Value)
			{
				PCT0210107 = (int?)reader[111];
			}
			if (reader[112] != DBNull.Value)
			{
				PCT0210108 = (int?)reader[112];
			}
			if (reader[113] != DBNull.Value)
			{
				PCT0210109 = (int?)reader[113];
			}
			if (reader[114] != DBNull.Value)
			{
				PCT0210110 = (int?)reader[114];
			}
			if (reader[115] != DBNull.Value)
			{
				PCT0210111 = (int?)reader[115];
			}
			if (reader[116] != DBNull.Value)
			{
				PCT0210112 = (int?)reader[116];
			}
			if (reader[117] != DBNull.Value)
			{
				PCT0210113 = (int?)reader[117];
			}
			if (reader[118] != DBNull.Value)
			{
				PCT0210114 = (int?)reader[118];
			}
			if (reader[119] != DBNull.Value)
			{
				PCT0210115 = (int?)reader[119];
			}
			if (reader[120] != DBNull.Value)
			{
				PCT0210116 = (int?)reader[120];
			}
			if (reader[121] != DBNull.Value)
			{
				PCT0210117 = (int?)reader[121];
			}
			if (reader[122] != DBNull.Value)
			{
				PCT0210118 = (int?)reader[122];
			}
			if (reader[123] != DBNull.Value)
			{
				PCT0210119 = (int?)reader[123];
			}
			if (reader[124] != DBNull.Value)
			{
				PCT0210120 = (int?)reader[124];
			}
			if (reader[125] != DBNull.Value)
			{
				PCT0210121 = (int?)reader[125];
			}
			if (reader[126] != DBNull.Value)
			{
				PCT0210122 = (int?)reader[126];
			}
			if (reader[127] != DBNull.Value)
			{
				PCT0210123 = (int?)reader[127];
			}
			if (reader[128] != DBNull.Value)
			{
				PCT0210124 = (int?)reader[128];
			}
			if (reader[129] != DBNull.Value)
			{
				PCT0210125 = (int?)reader[129];
			}
			if (reader[130] != DBNull.Value)
			{
				PCT0210126 = (int?)reader[130];
			}
			if (reader[131] != DBNull.Value)
			{
				PCT0210127 = (int?)reader[131];
			}
			if (reader[132] != DBNull.Value)
			{
				PCT0210128 = (int?)reader[132];
			}
			if (reader[133] != DBNull.Value)
			{
				PCT0210129 = (int?)reader[133];
			}
			if (reader[134] != DBNull.Value)
			{
				PCT0210130 = (int?)reader[134];
			}
			if (reader[135] != DBNull.Value)
			{
				PCT0210131 = (int?)reader[135];
			}
			if (reader[136] != DBNull.Value)
			{
				PCT0210132 = (int?)reader[136];
			}
			if (reader[137] != DBNull.Value)
			{
				PCT0210133 = (int?)reader[137];
			}
			if (reader[138] != DBNull.Value)
			{
				PCT0210134 = (int?)reader[138];
			}
			if (reader[139] != DBNull.Value)
			{
				PCT0210135 = (int?)reader[139];
			}
			if (reader[140] != DBNull.Value)
			{
				PCT0210136 = (int?)reader[140];
			}
			if (reader[141] != DBNull.Value)
			{
				PCT0210137 = (int?)reader[141];
			}
			if (reader[142] != DBNull.Value)
			{
				PCT0210138 = (int?)reader[142];
			}
			if (reader[143] != DBNull.Value)
			{
				PCT0210139 = (int?)reader[143];
			}
			if (reader[144] != DBNull.Value)
			{
				PCT0210140 = (int?)reader[144];
			}
			if (reader[145] != DBNull.Value)
			{
				PCT0210141 = (int?)reader[145];
			}
			if (reader[146] != DBNull.Value)
			{
				PCT0210142 = (int?)reader[146];
			}
			if (reader[147] != DBNull.Value)
			{
				PCT0210143 = (int?)reader[147];
			}
			if (reader[148] != DBNull.Value)
			{
				PCT0210144 = (int?)reader[148];
			}
			if (reader[149] != DBNull.Value)
			{
				PCT0210145 = (int?)reader[149];
			}
			if (reader[150] != DBNull.Value)
			{
				PCT0210146 = (int?)reader[150];
			}
			if (reader[151] != DBNull.Value)
			{
				PCT0210147 = (int?)reader[151];
			}
			if (reader[152] != DBNull.Value)
			{
				PCT0210148 = (int?)reader[152];
			}
			if (reader[153] != DBNull.Value)
			{
				PCT0210149 = (int?)reader[153];
			}
			if (reader[154] != DBNull.Value)
			{
				PCT0210150 = (int?)reader[154];
			}
			if (reader[155] != DBNull.Value)
			{
				PCT0210151 = (int?)reader[155];
			}
			if (reader[156] != DBNull.Value)
			{
				PCT0210152 = (int?)reader[156];
			}
			if (reader[157] != DBNull.Value)
			{
				PCT0210153 = (int?)reader[157];
			}
			if (reader[158] != DBNull.Value)
			{
				PCT0210154 = (int?)reader[158];
			}
			if (reader[159] != DBNull.Value)
			{
				PCT0210155 = (int?)reader[159];
			}
			if (reader[160] != DBNull.Value)
			{
				PCT0210156 = (int?)reader[160];
			}
			if (reader[161] != DBNull.Value)
			{
				PCT0210157 = (int?)reader[161];
			}
			if (reader[162] != DBNull.Value)
			{
				PCT0210158 = (int?)reader[162];
			}
			if (reader[163] != DBNull.Value)
			{
				PCT0210159 = (int?)reader[163];
			}
			if (reader[164] != DBNull.Value)
			{
				PCT0210160 = (int?)reader[164];
			}
			if (reader[165] != DBNull.Value)
			{
				PCT0210161 = (int?)reader[165];
			}
			if (reader[166] != DBNull.Value)
			{
				PCT0210162 = (int?)reader[166];
			}
			if (reader[167] != DBNull.Value)
			{
				PCT0210163 = (int?)reader[167];
			}
			if (reader[168] != DBNull.Value)
			{
				PCT0210164 = (int?)reader[168];
			}
			if (reader[169] != DBNull.Value)
			{
				PCT0210165 = (int?)reader[169];
			}
			if (reader[170] != DBNull.Value)
			{
				PCT0210166 = (int?)reader[170];
			}
			if (reader[171] != DBNull.Value)
			{
				PCT0210167 = (int?)reader[171];
			}
			if (reader[172] != DBNull.Value)
			{
				PCT0210168 = (int?)reader[172];
			}
			if (reader[173] != DBNull.Value)
			{
				PCT0210169 = (int?)reader[173];
			}
			if (reader[174] != DBNull.Value)
			{
				PCT0210170 = (int?)reader[174];
			}
			if (reader[175] != DBNull.Value)
			{
				PCT0210171 = (int?)reader[175];
			}
			if (reader[176] != DBNull.Value)
			{
				PCT0210172 = (int?)reader[176];
			}
			if (reader[177] != DBNull.Value)
			{
				PCT0210173 = (int?)reader[177];
			}
			if (reader[178] != DBNull.Value)
			{
				PCT0210174 = (int?)reader[178];
			}
			if (reader[179] != DBNull.Value)
			{
				PCT0210175 = (int?)reader[179];
			}
			if (reader[180] != DBNull.Value)
			{
				PCT0210176 = (int?)reader[180];
			}
			if (reader[181] != DBNull.Value)
			{
				PCT0210177 = (int?)reader[181];
			}
			if (reader[182] != DBNull.Value)
			{
				PCT0210178 = (int?)reader[182];
			}
			if (reader[183] != DBNull.Value)
			{
				PCT0210179 = (int?)reader[183];
			}
			if (reader[184] != DBNull.Value)
			{
				PCT0210180 = (int?)reader[184];
			}
			if (reader[185] != DBNull.Value)
			{
				PCT0210181 = (int?)reader[185];
			}
			if (reader[186] != DBNull.Value)
			{
				PCT0210182 = (int?)reader[186];
			}
			if (reader[187] != DBNull.Value)
			{
				PCT0210183 = (int?)reader[187];
			}
			if (reader[188] != DBNull.Value)
			{
				PCT0210184 = (int?)reader[188];
			}
			if (reader[189] != DBNull.Value)
			{
				PCT0210185 = (int?)reader[189];
			}
			if (reader[190] != DBNull.Value)
			{
				PCT0210186 = (int?)reader[190];
			}
			if (reader[191] != DBNull.Value)
			{
				PCT0210187 = (int?)reader[191];
			}
			if (reader[192] != DBNull.Value)
			{
				PCT0210188 = (int?)reader[192];
			}
			if (reader[193] != DBNull.Value)
			{
				PCT0210189 = (int?)reader[193];
			}
			if (reader[194] != DBNull.Value)
			{
				PCT0210190 = (int?)reader[194];
			}
			if (reader[195] != DBNull.Value)
			{
				PCT0210191 = (int?)reader[195];
			}
			if (reader[196] != DBNull.Value)
			{
				PCT0210192 = (int?)reader[196];
			}
			if (reader[197] != DBNull.Value)
			{
				PCT0210193 = (int?)reader[197];
			}
			if (reader[198] != DBNull.Value)
			{
				PCT0210194 = (int?)reader[198];
			}
			if (reader[199] != DBNull.Value)
			{
				PCT0210195 = (int?)reader[199];
			}
			if (reader[200] != DBNull.Value)
			{
				PCT0220001 = (int?)reader[200];
			}
			if (reader[201] != DBNull.Value)
			{
				PCT0220002 = (int?)reader[201];
			}
			if (reader[202] != DBNull.Value)
			{
				PCT0220003 = (int?)reader[202];
			}
			if (reader[203] != DBNull.Value)
			{
				PCT0220004 = (int?)reader[203];
			}
			if (reader[204] != DBNull.Value)
			{
				PCT0220005 = (int?)reader[204];
			}
			if (reader[205] != DBNull.Value)
			{
				PCT0220006 = (int?)reader[205];
			}
			if (reader[206] != DBNull.Value)
			{
				PCT0220007 = (int?)reader[206];
			}
			if (reader[207] != DBNull.Value)
			{
				PCT0220008 = (int?)reader[207];
			}
			if (reader[208] != DBNull.Value)
			{
				PCT0220009 = (int?)reader[208];
			}
			if (reader[209] != DBNull.Value)
			{
				PCT0220010 = (int?)reader[209];
			}
			if (reader[210] != DBNull.Value)
			{
				PCT0220011 = (int?)reader[210];
			}
			if (reader[211] != DBNull.Value)
			{
				PCT0220012 = (int?)reader[211];
			}
			if (reader[212] != DBNull.Value)
			{
				PCT0220013 = (int?)reader[212];
			}
			if (reader[213] != DBNull.Value)
			{
				PCT0220014 = (int?)reader[213];
			}
			if (reader[214] != DBNull.Value)
			{
				PCT0220015 = (int?)reader[214];
			}
			if (reader[215] != DBNull.Value)
			{
				PCT0220016 = (int?)reader[215];
			}
			if (reader[216] != DBNull.Value)
			{
				PCT0220017 = (int?)reader[216];
			}
			if (reader[217] != DBNull.Value)
			{
				PCT0220018 = (int?)reader[217];
			}
			if (reader[218] != DBNull.Value)
			{
				PCT0220019 = (int?)reader[218];
			}
			if (reader[219] != DBNull.Value)
			{
				PCT0220020 = (int?)reader[219];
			}
			if (reader[220] != DBNull.Value)
			{
				PCT0220021 = (int?)reader[220];
			}
		}
		#endregion Constructors
	}
}
