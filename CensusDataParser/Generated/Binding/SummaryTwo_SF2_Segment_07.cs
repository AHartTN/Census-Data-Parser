#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/06/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryTwo_SF2_Segment_07.cs
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

	public class SummaryTwo_SF2_Segment_07 : BaseModel
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
		public int? PCT0390001 { get; set; }

		[Display(Name = "Male:", ShortName = "Male:", Order = 6)]
		public int? PCT0390002 { get; set; }

		[Display(Name = "Under 18 years:", ShortName = "Under 18 years:", Order = 7)]
		public int? PCT0390003 { get; set; }

		[Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 8)]
		public int? PCT0390004 { get; set; }

		[Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 9)]
		public int? PCT0390005 { get; set; }

		[Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 10)]
		public int? PCT0390006 { get; set; }

		[Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 11)]
		public int? PCT0390007 { get; set; }

		[Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 12)]
		public int? PCT0390008 { get; set; }

		[Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 13)]
		public int? PCT0390009 { get; set; }

		[Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 14)]
		public int? PCT0390010 { get; set; }

		[Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 15)]
		public int? PCT0390011 { get; set; }

		[Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 16)]
		public int? PCT0390012 { get; set; }

		[Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 17)]
		public int? PCT0390013 { get; set; }

		[Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 18)]
		public int? PCT0390014 { get; set; }

		[Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 19)]
		public int? PCT0390015 { get; set; }

		[Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 20)]
		public int? PCT0390016 { get; set; }

		[Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 21)]
		public int? PCT0390017 { get; set; }

		[Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 22)]
		public int? PCT0390018 { get; set; }

		[Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 23)]
		public int? PCT0390019 { get; set; }

		[Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 24)]
		public int? PCT0390020 { get; set; }

		[Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 25)]
		public int? PCT0390021 { get; set; }

		[Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 26)]
		public int? PCT0390022 { get; set; }

		[Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 27)]
		public int? PCT0390023 { get; set; }

		[Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 28)]
		public int? PCT0390024 { get; set; }

		[Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 29)]
		public int? PCT0390025 { get; set; }

		[Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 30)]
		public int? PCT0390026 { get; set; }

		[Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 31)]
		public int? PCT0390027 { get; set; }

		[Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 32)]
		public int? PCT0390028 { get; set; }

		[Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 33)]
		public int? PCT0390029 { get; set; }

		[Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 34)]
		public int? PCT0390030 { get; set; }

		[Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 35)]
		public int? PCT0390031 { get; set; }

		[Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 36)]
		public int? PCT0390032 { get; set; }

		[Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 37)]
		public int? PCT0390033 { get; set; }

		[Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 38)]
		public int? PCT0390034 { get; set; }

		[Display(Name = "18 to 64 years:", ShortName = "18 to 64 years:", Order = 39)]
		public int? PCT0390035 { get; set; }

		[Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 40)]
		public int? PCT0390036 { get; set; }

		[Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 41)]
		public int? PCT0390037 { get; set; }

		[Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 42)]
		public int? PCT0390038 { get; set; }

		[Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 43)]
		public int? PCT0390039 { get; set; }

		[Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 44)]
		public int? PCT0390040 { get; set; }

		[Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 45)]
		public int? PCT0390041 { get; set; }

		[Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 46)]
		public int? PCT0390042 { get; set; }

		[Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 47)]
		public int? PCT0390043 { get; set; }

		[Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 48)]
		public int? PCT0390044 { get; set; }

		[Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 49)]
		public int? PCT0390045 { get; set; }

		[Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 50)]
		public int? PCT0390046 { get; set; }

		[Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 51)]
		public int? PCT0390047 { get; set; }

		[Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 52)]
		public int? PCT0390048 { get; set; }

		[Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 53)]
		public int? PCT0390049 { get; set; }

		[Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 54)]
		public int? PCT0390050 { get; set; }

		[Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 55)]
		public int? PCT0390051 { get; set; }

		[Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 56)]
		public int? PCT0390052 { get; set; }

		[Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 57)]
		public int? PCT0390053 { get; set; }

		[Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 58)]
		public int? PCT0390054 { get; set; }

		[Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 59)]
		public int? PCT0390055 { get; set; }

		[Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 60)]
		public int? PCT0390056 { get; set; }

		[Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 61)]
		public int? PCT0390057 { get; set; }

		[Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 62)]
		public int? PCT0390058 { get; set; }

		[Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 63)]
		public int? PCT0390059 { get; set; }

		[Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 64)]
		public int? PCT0390060 { get; set; }

		[Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 65)]
		public int? PCT0390061 { get; set; }

		[Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 66)]
		public int? PCT0390062 { get; set; }

		[Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 67)]
		public int? PCT0390063 { get; set; }

		[Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 68)]
		public int? PCT0390064 { get; set; }

		[Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 69)]
		public int? PCT0390065 { get; set; }

		[Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 70)]
		public int? PCT0390066 { get; set; }

		[Display(Name = "65 years and over:", ShortName = "65 years and over:", Order = 71)]
		public int? PCT0390067 { get; set; }

		[Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 72)]
		public int? PCT0390068 { get; set; }

		[Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 73)]
		public int? PCT0390069 { get; set; }

		[Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 74)]
		public int? PCT0390070 { get; set; }

		[Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 75)]
		public int? PCT0390071 { get; set; }

		[Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 76)]
		public int? PCT0390072 { get; set; }

		[Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 77)]
		public int? PCT0390073 { get; set; }

		[Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 78)]
		public int? PCT0390074 { get; set; }

		[Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 79)]
		public int? PCT0390075 { get; set; }

		[Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 80)]
		public int? PCT0390076 { get; set; }

		[Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 81)]
		public int? PCT0390077 { get; set; }

		[Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 82)]
		public int? PCT0390078 { get; set; }

		[Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 83)]
		public int? PCT0390079 { get; set; }

		[Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 84)]
		public int? PCT0390080 { get; set; }

		[Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 85)]
		public int? PCT0390081 { get; set; }

		[Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 86)]
		public int? PCT0390082 { get; set; }

		[Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 87)]
		public int? PCT0390083 { get; set; }

		[Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 88)]
		public int? PCT0390084 { get; set; }

		[Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 89)]
		public int? PCT0390085 { get; set; }

		[Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 90)]
		public int? PCT0390086 { get; set; }

		[Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 91)]
		public int? PCT0390087 { get; set; }

		[Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 92)]
		public int? PCT0390088 { get; set; }

		[Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 93)]
		public int? PCT0390089 { get; set; }

		[Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 94)]
		public int? PCT0390090 { get; set; }

		[Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 95)]
		public int? PCT0390091 { get; set; }

		[Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 96)]
		public int? PCT0390092 { get; set; }

		[Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 97)]
		public int? PCT0390093 { get; set; }

		[Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 98)]
		public int? PCT0390094 { get; set; }

		[Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 99)]
		public int? PCT0390095 { get; set; }

		[Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 100)]
		public int? PCT0390096 { get; set; }

		[Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 101)]
		public int? PCT0390097 { get; set; }

		[Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 102)]
		public int? PCT0390098 { get; set; }

		[Display(Name = "Female:", ShortName = "Female:", Order = 103)]
		public int? PCT0390099 { get; set; }

		[Display(Name = "Under 18 years:", ShortName = "Under 18 years:", Order = 104)]
		public int? PCT0390100 { get; set; }

		[Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 105)]
		public int? PCT0390101 { get; set; }

		[Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 106)]
		public int? PCT0390102 { get; set; }

		[Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 107)]
		public int? PCT0390103 { get; set; }

		[Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 108)]
		public int? PCT0390104 { get; set; }

		[Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 109)]
		public int? PCT0390105 { get; set; }

		[Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 110)]
		public int? PCT0390106 { get; set; }

		[Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 111)]
		public int? PCT0390107 { get; set; }

		[Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 112)]
		public int? PCT0390108 { get; set; }

		[Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 113)]
		public int? PCT0390109 { get; set; }

		[Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 114)]
		public int? PCT0390110 { get; set; }

		[Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 115)]
		public int? PCT0390111 { get; set; }

		[Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 116)]
		public int? PCT0390112 { get; set; }

		[Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 117)]
		public int? PCT0390113 { get; set; }

		[Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 118)]
		public int? PCT0390114 { get; set; }

		[Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 119)]
		public int? PCT0390115 { get; set; }

		[Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 120)]
		public int? PCT0390116 { get; set; }

		[Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 121)]
		public int? PCT0390117 { get; set; }

		[Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 122)]
		public int? PCT0390118 { get; set; }

		[Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 123)]
		public int? PCT0390119 { get; set; }

		[Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 124)]
		public int? PCT0390120 { get; set; }

		[Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 125)]
		public int? PCT0390121 { get; set; }

		[Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 126)]
		public int? PCT0390122 { get; set; }

		[Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 127)]
		public int? PCT0390123 { get; set; }

		[Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 128)]
		public int? PCT0390124 { get; set; }

		[Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 129)]
		public int? PCT0390125 { get; set; }

		[Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 130)]
		public int? PCT0390126 { get; set; }

		[Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 131)]
		public int? PCT0390127 { get; set; }

		[Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 132)]
		public int? PCT0390128 { get; set; }

		[Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 133)]
		public int? PCT0390129 { get; set; }

		[Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 134)]
		public int? PCT0390130 { get; set; }

		[Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 135)]
		public int? PCT0390131 { get; set; }

		[Display(Name = "18 to 64 years:", ShortName = "18 to 64 years:", Order = 136)]
		public int? PCT0390132 { get; set; }

		[Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 137)]
		public int? PCT0390133 { get; set; }

		[Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 138)]
		public int? PCT0390134 { get; set; }

		[Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 139)]
		public int? PCT0390135 { get; set; }

		[Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 140)]
		public int? PCT0390136 { get; set; }

		[Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 141)]
		public int? PCT0390137 { get; set; }

		[Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 142)]
		public int? PCT0390138 { get; set; }

		[Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 143)]
		public int? PCT0390139 { get; set; }

		[Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 144)]
		public int? PCT0390140 { get; set; }

		[Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 145)]
		public int? PCT0390141 { get; set; }

		[Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 146)]
		public int? PCT0390142 { get; set; }

		[Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 147)]
		public int? PCT0390143 { get; set; }

		[Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 148)]
		public int? PCT0390144 { get; set; }

		[Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 149)]
		public int? PCT0390145 { get; set; }

		[Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 150)]
		public int? PCT0390146 { get; set; }

		[Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 151)]
		public int? PCT0390147 { get; set; }

		[Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 152)]
		public int? PCT0390148 { get; set; }

		[Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 153)]
		public int? PCT0390149 { get; set; }

		[Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 154)]
		public int? PCT0390150 { get; set; }

		[Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 155)]
		public int? PCT0390151 { get; set; }

		[Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 156)]
		public int? PCT0390152 { get; set; }

		[Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 157)]
		public int? PCT0390153 { get; set; }

		[Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 158)]
		public int? PCT0390154 { get; set; }

		[Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 159)]
		public int? PCT0390155 { get; set; }

		[Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 160)]
		public int? PCT0390156 { get; set; }

		[Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 161)]
		public int? PCT0390157 { get; set; }

		[Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 162)]
		public int? PCT0390158 { get; set; }

		[Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 163)]
		public int? PCT0390159 { get; set; }

		[Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 164)]
		public int? PCT0390160 { get; set; }

		[Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 165)]
		public int? PCT0390161 { get; set; }

		[Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 166)]
		public int? PCT0390162 { get; set; }

		[Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 167)]
		public int? PCT0390163 { get; set; }

		[Display(Name = "65 years and over:", ShortName = "65 years and over:", Order = 168)]
		public int? PCT0390164 { get; set; }

		[Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 169)]
		public int? PCT0390165 { get; set; }

		[Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 170)]
		public int? PCT0390166 { get; set; }

		[Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 171)]
		public int? PCT0390167 { get; set; }

		[Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 172)]
		public int? PCT0390168 { get; set; }

		[Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 173)]
		public int? PCT0390169 { get; set; }

		[Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 174)]
		public int? PCT0390170 { get; set; }

		[Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 175)]
		public int? PCT0390171 { get; set; }

		[Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 176)]
		public int? PCT0390172 { get; set; }

		[Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 177)]
		public int? PCT0390173 { get; set; }

		[Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 178)]
		public int? PCT0390174 { get; set; }

		[Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 179)]
		public int? PCT0390175 { get; set; }

		[Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 180)]
		public int? PCT0390176 { get; set; }

		[Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 181)]
		public int? PCT0390177 { get; set; }

		[Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 182)]
		public int? PCT0390178 { get; set; }

		[Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 183)]
		public int? PCT0390179 { get; set; }

		[Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 184)]
		public int? PCT0390180 { get; set; }

		[Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 185)]
		public int? PCT0390181 { get; set; }

		[Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 186)]
		public int? PCT0390182 { get; set; }

		[Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 187)]
		public int? PCT0390183 { get; set; }

		[Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 188)]
		public int? PCT0390184 { get; set; }

		[Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 189)]
		public int? PCT0390185 { get; set; }

		[Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 190)]
		public int? PCT0390186 { get; set; }

		[Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 191)]
		public int? PCT0390187 { get; set; }

		[Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 192)]
		public int? PCT0390188 { get; set; }

		[Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 193)]
		public int? PCT0390189 { get; set; }

		[Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 194)]
		public int? PCT0390190 { get; set; }

		[Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 195)]
		public int? PCT0390191 { get; set; }

		[Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 196)]
		public int? PCT0390192 { get; set; }

		[Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 197)]
		public int? PCT0390193 { get; set; }

		[Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 198)]
		public int? PCT0390194 { get; set; }

		[Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 199)]
		public int? PCT0390195 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 200)]
		public int? PCT0400001 { get; set; }

		[Display(Name = "Not substituted", ShortName = "Not substituted", Order = 201)]
		public int? PCT0400002 { get; set; }

		[Display(Name = "Substituted", ShortName = "Substituted", Order = 202)]
		public int? PCT0400003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 203)]
		public int? PCT0410001 { get; set; }

		[Display(Name = "No items allocated", ShortName = "No items allocated", Order = 204)]
		public int? PCT0410002 { get; set; }

		[Display(Name = "One or more items allocated", ShortName = "One or more items allocated", Order = 205)]
		public int? PCT0410003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 206)]
		public int? PCT0420001 { get; set; }

		[Display(Name = "Allocated", ShortName = "Allocated", Order = 207)]
		public int? PCT0420002 { get; set; }

		[Display(Name = "Not allocated", ShortName = "Not allocated", Order = 208)]
		public int? PCT0420003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 209)]
		public int? PCT0430001 { get; set; }

		[Display(Name = "Allocated", ShortName = "Allocated", Order = 210)]
		public int? PCT0430002 { get; set; }

		[Display(Name = "Not allocated", ShortName = "Not allocated", Order = 211)]
		public int? PCT0430003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 212)]
		public int? PCT0440001 { get; set; }

		[Display(Name = "Allocated", ShortName = "Allocated", Order = 213)]
		public int? PCT0440002 { get; set; }

		[Display(Name = "Not allocated", ShortName = "Not allocated", Order = 214)]
		public int? PCT0440003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 215)]
		public int? PCT0450001 { get; set; }

		[Display(Name = "Allocated", ShortName = "Allocated", Order = 216)]
		public int? PCT0450002 { get; set; }

		[Display(Name = "Not allocated", ShortName = "Not allocated", Order = 217)]
		public int? PCT0450003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 218)]
		public int? PCT0460001 { get; set; }

		[Display(Name = "Allocated", ShortName = "Allocated", Order = 219)]
		public int? PCT0460002 { get; set; }

		[Display(Name = "Not allocated", ShortName = "Not allocated", Order = 220)]
		public int? PCT0460003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 221)]
		public int? PCT0470001 { get; set; }

		[Display(Name = "No items allocated", ShortName = "No items allocated", Order = 222)]
		public int? PCT0470002 { get; set; }

		[Display(Name = "One or more items allocated", ShortName = "One or more items allocated", Order = 223)]
		public int? PCT0470003 { get; set; }
		#endregion Properties

		#region Constructors
		public SummaryTwo_SF2_Segment_07(string csvLine) : base(csvLine) { }

		public SummaryTwo_SF2_Segment_07(string[] values) : base(values) { }

		public SummaryTwo_SF2_Segment_07(OleDbDataReader reader)
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
				PCT0390001 = (int?)reader[5];
			}
			if (reader[6] != DBNull.Value)
			{
				PCT0390002 = (int?)reader[6];
			}
			if (reader[7] != DBNull.Value)
			{
				PCT0390003 = (int?)reader[7];
			}
			if (reader[8] != DBNull.Value)
			{
				PCT0390004 = (int?)reader[8];
			}
			if (reader[9] != DBNull.Value)
			{
				PCT0390005 = (int?)reader[9];
			}
			if (reader[10] != DBNull.Value)
			{
				PCT0390006 = (int?)reader[10];
			}
			if (reader[11] != DBNull.Value)
			{
				PCT0390007 = (int?)reader[11];
			}
			if (reader[12] != DBNull.Value)
			{
				PCT0390008 = (int?)reader[12];
			}
			if (reader[13] != DBNull.Value)
			{
				PCT0390009 = (int?)reader[13];
			}
			if (reader[14] != DBNull.Value)
			{
				PCT0390010 = (int?)reader[14];
			}
			if (reader[15] != DBNull.Value)
			{
				PCT0390011 = (int?)reader[15];
			}
			if (reader[16] != DBNull.Value)
			{
				PCT0390012 = (int?)reader[16];
			}
			if (reader[17] != DBNull.Value)
			{
				PCT0390013 = (int?)reader[17];
			}
			if (reader[18] != DBNull.Value)
			{
				PCT0390014 = (int?)reader[18];
			}
			if (reader[19] != DBNull.Value)
			{
				PCT0390015 = (int?)reader[19];
			}
			if (reader[20] != DBNull.Value)
			{
				PCT0390016 = (int?)reader[20];
			}
			if (reader[21] != DBNull.Value)
			{
				PCT0390017 = (int?)reader[21];
			}
			if (reader[22] != DBNull.Value)
			{
				PCT0390018 = (int?)reader[22];
			}
			if (reader[23] != DBNull.Value)
			{
				PCT0390019 = (int?)reader[23];
			}
			if (reader[24] != DBNull.Value)
			{
				PCT0390020 = (int?)reader[24];
			}
			if (reader[25] != DBNull.Value)
			{
				PCT0390021 = (int?)reader[25];
			}
			if (reader[26] != DBNull.Value)
			{
				PCT0390022 = (int?)reader[26];
			}
			if (reader[27] != DBNull.Value)
			{
				PCT0390023 = (int?)reader[27];
			}
			if (reader[28] != DBNull.Value)
			{
				PCT0390024 = (int?)reader[28];
			}
			if (reader[29] != DBNull.Value)
			{
				PCT0390025 = (int?)reader[29];
			}
			if (reader[30] != DBNull.Value)
			{
				PCT0390026 = (int?)reader[30];
			}
			if (reader[31] != DBNull.Value)
			{
				PCT0390027 = (int?)reader[31];
			}
			if (reader[32] != DBNull.Value)
			{
				PCT0390028 = (int?)reader[32];
			}
			if (reader[33] != DBNull.Value)
			{
				PCT0390029 = (int?)reader[33];
			}
			if (reader[34] != DBNull.Value)
			{
				PCT0390030 = (int?)reader[34];
			}
			if (reader[35] != DBNull.Value)
			{
				PCT0390031 = (int?)reader[35];
			}
			if (reader[36] != DBNull.Value)
			{
				PCT0390032 = (int?)reader[36];
			}
			if (reader[37] != DBNull.Value)
			{
				PCT0390033 = (int?)reader[37];
			}
			if (reader[38] != DBNull.Value)
			{
				PCT0390034 = (int?)reader[38];
			}
			if (reader[39] != DBNull.Value)
			{
				PCT0390035 = (int?)reader[39];
			}
			if (reader[40] != DBNull.Value)
			{
				PCT0390036 = (int?)reader[40];
			}
			if (reader[41] != DBNull.Value)
			{
				PCT0390037 = (int?)reader[41];
			}
			if (reader[42] != DBNull.Value)
			{
				PCT0390038 = (int?)reader[42];
			}
			if (reader[43] != DBNull.Value)
			{
				PCT0390039 = (int?)reader[43];
			}
			if (reader[44] != DBNull.Value)
			{
				PCT0390040 = (int?)reader[44];
			}
			if (reader[45] != DBNull.Value)
			{
				PCT0390041 = (int?)reader[45];
			}
			if (reader[46] != DBNull.Value)
			{
				PCT0390042 = (int?)reader[46];
			}
			if (reader[47] != DBNull.Value)
			{
				PCT0390043 = (int?)reader[47];
			}
			if (reader[48] != DBNull.Value)
			{
				PCT0390044 = (int?)reader[48];
			}
			if (reader[49] != DBNull.Value)
			{
				PCT0390045 = (int?)reader[49];
			}
			if (reader[50] != DBNull.Value)
			{
				PCT0390046 = (int?)reader[50];
			}
			if (reader[51] != DBNull.Value)
			{
				PCT0390047 = (int?)reader[51];
			}
			if (reader[52] != DBNull.Value)
			{
				PCT0390048 = (int?)reader[52];
			}
			if (reader[53] != DBNull.Value)
			{
				PCT0390049 = (int?)reader[53];
			}
			if (reader[54] != DBNull.Value)
			{
				PCT0390050 = (int?)reader[54];
			}
			if (reader[55] != DBNull.Value)
			{
				PCT0390051 = (int?)reader[55];
			}
			if (reader[56] != DBNull.Value)
			{
				PCT0390052 = (int?)reader[56];
			}
			if (reader[57] != DBNull.Value)
			{
				PCT0390053 = (int?)reader[57];
			}
			if (reader[58] != DBNull.Value)
			{
				PCT0390054 = (int?)reader[58];
			}
			if (reader[59] != DBNull.Value)
			{
				PCT0390055 = (int?)reader[59];
			}
			if (reader[60] != DBNull.Value)
			{
				PCT0390056 = (int?)reader[60];
			}
			if (reader[61] != DBNull.Value)
			{
				PCT0390057 = (int?)reader[61];
			}
			if (reader[62] != DBNull.Value)
			{
				PCT0390058 = (int?)reader[62];
			}
			if (reader[63] != DBNull.Value)
			{
				PCT0390059 = (int?)reader[63];
			}
			if (reader[64] != DBNull.Value)
			{
				PCT0390060 = (int?)reader[64];
			}
			if (reader[65] != DBNull.Value)
			{
				PCT0390061 = (int?)reader[65];
			}
			if (reader[66] != DBNull.Value)
			{
				PCT0390062 = (int?)reader[66];
			}
			if (reader[67] != DBNull.Value)
			{
				PCT0390063 = (int?)reader[67];
			}
			if (reader[68] != DBNull.Value)
			{
				PCT0390064 = (int?)reader[68];
			}
			if (reader[69] != DBNull.Value)
			{
				PCT0390065 = (int?)reader[69];
			}
			if (reader[70] != DBNull.Value)
			{
				PCT0390066 = (int?)reader[70];
			}
			if (reader[71] != DBNull.Value)
			{
				PCT0390067 = (int?)reader[71];
			}
			if (reader[72] != DBNull.Value)
			{
				PCT0390068 = (int?)reader[72];
			}
			if (reader[73] != DBNull.Value)
			{
				PCT0390069 = (int?)reader[73];
			}
			if (reader[74] != DBNull.Value)
			{
				PCT0390070 = (int?)reader[74];
			}
			if (reader[75] != DBNull.Value)
			{
				PCT0390071 = (int?)reader[75];
			}
			if (reader[76] != DBNull.Value)
			{
				PCT0390072 = (int?)reader[76];
			}
			if (reader[77] != DBNull.Value)
			{
				PCT0390073 = (int?)reader[77];
			}
			if (reader[78] != DBNull.Value)
			{
				PCT0390074 = (int?)reader[78];
			}
			if (reader[79] != DBNull.Value)
			{
				PCT0390075 = (int?)reader[79];
			}
			if (reader[80] != DBNull.Value)
			{
				PCT0390076 = (int?)reader[80];
			}
			if (reader[81] != DBNull.Value)
			{
				PCT0390077 = (int?)reader[81];
			}
			if (reader[82] != DBNull.Value)
			{
				PCT0390078 = (int?)reader[82];
			}
			if (reader[83] != DBNull.Value)
			{
				PCT0390079 = (int?)reader[83];
			}
			if (reader[84] != DBNull.Value)
			{
				PCT0390080 = (int?)reader[84];
			}
			if (reader[85] != DBNull.Value)
			{
				PCT0390081 = (int?)reader[85];
			}
			if (reader[86] != DBNull.Value)
			{
				PCT0390082 = (int?)reader[86];
			}
			if (reader[87] != DBNull.Value)
			{
				PCT0390083 = (int?)reader[87];
			}
			if (reader[88] != DBNull.Value)
			{
				PCT0390084 = (int?)reader[88];
			}
			if (reader[89] != DBNull.Value)
			{
				PCT0390085 = (int?)reader[89];
			}
			if (reader[90] != DBNull.Value)
			{
				PCT0390086 = (int?)reader[90];
			}
			if (reader[91] != DBNull.Value)
			{
				PCT0390087 = (int?)reader[91];
			}
			if (reader[92] != DBNull.Value)
			{
				PCT0390088 = (int?)reader[92];
			}
			if (reader[93] != DBNull.Value)
			{
				PCT0390089 = (int?)reader[93];
			}
			if (reader[94] != DBNull.Value)
			{
				PCT0390090 = (int?)reader[94];
			}
			if (reader[95] != DBNull.Value)
			{
				PCT0390091 = (int?)reader[95];
			}
			if (reader[96] != DBNull.Value)
			{
				PCT0390092 = (int?)reader[96];
			}
			if (reader[97] != DBNull.Value)
			{
				PCT0390093 = (int?)reader[97];
			}
			if (reader[98] != DBNull.Value)
			{
				PCT0390094 = (int?)reader[98];
			}
			if (reader[99] != DBNull.Value)
			{
				PCT0390095 = (int?)reader[99];
			}
			if (reader[100] != DBNull.Value)
			{
				PCT0390096 = (int?)reader[100];
			}
			if (reader[101] != DBNull.Value)
			{
				PCT0390097 = (int?)reader[101];
			}
			if (reader[102] != DBNull.Value)
			{
				PCT0390098 = (int?)reader[102];
			}
			if (reader[103] != DBNull.Value)
			{
				PCT0390099 = (int?)reader[103];
			}
			if (reader[104] != DBNull.Value)
			{
				PCT0390100 = (int?)reader[104];
			}
			if (reader[105] != DBNull.Value)
			{
				PCT0390101 = (int?)reader[105];
			}
			if (reader[106] != DBNull.Value)
			{
				PCT0390102 = (int?)reader[106];
			}
			if (reader[107] != DBNull.Value)
			{
				PCT0390103 = (int?)reader[107];
			}
			if (reader[108] != DBNull.Value)
			{
				PCT0390104 = (int?)reader[108];
			}
			if (reader[109] != DBNull.Value)
			{
				PCT0390105 = (int?)reader[109];
			}
			if (reader[110] != DBNull.Value)
			{
				PCT0390106 = (int?)reader[110];
			}
			if (reader[111] != DBNull.Value)
			{
				PCT0390107 = (int?)reader[111];
			}
			if (reader[112] != DBNull.Value)
			{
				PCT0390108 = (int?)reader[112];
			}
			if (reader[113] != DBNull.Value)
			{
				PCT0390109 = (int?)reader[113];
			}
			if (reader[114] != DBNull.Value)
			{
				PCT0390110 = (int?)reader[114];
			}
			if (reader[115] != DBNull.Value)
			{
				PCT0390111 = (int?)reader[115];
			}
			if (reader[116] != DBNull.Value)
			{
				PCT0390112 = (int?)reader[116];
			}
			if (reader[117] != DBNull.Value)
			{
				PCT0390113 = (int?)reader[117];
			}
			if (reader[118] != DBNull.Value)
			{
				PCT0390114 = (int?)reader[118];
			}
			if (reader[119] != DBNull.Value)
			{
				PCT0390115 = (int?)reader[119];
			}
			if (reader[120] != DBNull.Value)
			{
				PCT0390116 = (int?)reader[120];
			}
			if (reader[121] != DBNull.Value)
			{
				PCT0390117 = (int?)reader[121];
			}
			if (reader[122] != DBNull.Value)
			{
				PCT0390118 = (int?)reader[122];
			}
			if (reader[123] != DBNull.Value)
			{
				PCT0390119 = (int?)reader[123];
			}
			if (reader[124] != DBNull.Value)
			{
				PCT0390120 = (int?)reader[124];
			}
			if (reader[125] != DBNull.Value)
			{
				PCT0390121 = (int?)reader[125];
			}
			if (reader[126] != DBNull.Value)
			{
				PCT0390122 = (int?)reader[126];
			}
			if (reader[127] != DBNull.Value)
			{
				PCT0390123 = (int?)reader[127];
			}
			if (reader[128] != DBNull.Value)
			{
				PCT0390124 = (int?)reader[128];
			}
			if (reader[129] != DBNull.Value)
			{
				PCT0390125 = (int?)reader[129];
			}
			if (reader[130] != DBNull.Value)
			{
				PCT0390126 = (int?)reader[130];
			}
			if (reader[131] != DBNull.Value)
			{
				PCT0390127 = (int?)reader[131];
			}
			if (reader[132] != DBNull.Value)
			{
				PCT0390128 = (int?)reader[132];
			}
			if (reader[133] != DBNull.Value)
			{
				PCT0390129 = (int?)reader[133];
			}
			if (reader[134] != DBNull.Value)
			{
				PCT0390130 = (int?)reader[134];
			}
			if (reader[135] != DBNull.Value)
			{
				PCT0390131 = (int?)reader[135];
			}
			if (reader[136] != DBNull.Value)
			{
				PCT0390132 = (int?)reader[136];
			}
			if (reader[137] != DBNull.Value)
			{
				PCT0390133 = (int?)reader[137];
			}
			if (reader[138] != DBNull.Value)
			{
				PCT0390134 = (int?)reader[138];
			}
			if (reader[139] != DBNull.Value)
			{
				PCT0390135 = (int?)reader[139];
			}
			if (reader[140] != DBNull.Value)
			{
				PCT0390136 = (int?)reader[140];
			}
			if (reader[141] != DBNull.Value)
			{
				PCT0390137 = (int?)reader[141];
			}
			if (reader[142] != DBNull.Value)
			{
				PCT0390138 = (int?)reader[142];
			}
			if (reader[143] != DBNull.Value)
			{
				PCT0390139 = (int?)reader[143];
			}
			if (reader[144] != DBNull.Value)
			{
				PCT0390140 = (int?)reader[144];
			}
			if (reader[145] != DBNull.Value)
			{
				PCT0390141 = (int?)reader[145];
			}
			if (reader[146] != DBNull.Value)
			{
				PCT0390142 = (int?)reader[146];
			}
			if (reader[147] != DBNull.Value)
			{
				PCT0390143 = (int?)reader[147];
			}
			if (reader[148] != DBNull.Value)
			{
				PCT0390144 = (int?)reader[148];
			}
			if (reader[149] != DBNull.Value)
			{
				PCT0390145 = (int?)reader[149];
			}
			if (reader[150] != DBNull.Value)
			{
				PCT0390146 = (int?)reader[150];
			}
			if (reader[151] != DBNull.Value)
			{
				PCT0390147 = (int?)reader[151];
			}
			if (reader[152] != DBNull.Value)
			{
				PCT0390148 = (int?)reader[152];
			}
			if (reader[153] != DBNull.Value)
			{
				PCT0390149 = (int?)reader[153];
			}
			if (reader[154] != DBNull.Value)
			{
				PCT0390150 = (int?)reader[154];
			}
			if (reader[155] != DBNull.Value)
			{
				PCT0390151 = (int?)reader[155];
			}
			if (reader[156] != DBNull.Value)
			{
				PCT0390152 = (int?)reader[156];
			}
			if (reader[157] != DBNull.Value)
			{
				PCT0390153 = (int?)reader[157];
			}
			if (reader[158] != DBNull.Value)
			{
				PCT0390154 = (int?)reader[158];
			}
			if (reader[159] != DBNull.Value)
			{
				PCT0390155 = (int?)reader[159];
			}
			if (reader[160] != DBNull.Value)
			{
				PCT0390156 = (int?)reader[160];
			}
			if (reader[161] != DBNull.Value)
			{
				PCT0390157 = (int?)reader[161];
			}
			if (reader[162] != DBNull.Value)
			{
				PCT0390158 = (int?)reader[162];
			}
			if (reader[163] != DBNull.Value)
			{
				PCT0390159 = (int?)reader[163];
			}
			if (reader[164] != DBNull.Value)
			{
				PCT0390160 = (int?)reader[164];
			}
			if (reader[165] != DBNull.Value)
			{
				PCT0390161 = (int?)reader[165];
			}
			if (reader[166] != DBNull.Value)
			{
				PCT0390162 = (int?)reader[166];
			}
			if (reader[167] != DBNull.Value)
			{
				PCT0390163 = (int?)reader[167];
			}
			if (reader[168] != DBNull.Value)
			{
				PCT0390164 = (int?)reader[168];
			}
			if (reader[169] != DBNull.Value)
			{
				PCT0390165 = (int?)reader[169];
			}
			if (reader[170] != DBNull.Value)
			{
				PCT0390166 = (int?)reader[170];
			}
			if (reader[171] != DBNull.Value)
			{
				PCT0390167 = (int?)reader[171];
			}
			if (reader[172] != DBNull.Value)
			{
				PCT0390168 = (int?)reader[172];
			}
			if (reader[173] != DBNull.Value)
			{
				PCT0390169 = (int?)reader[173];
			}
			if (reader[174] != DBNull.Value)
			{
				PCT0390170 = (int?)reader[174];
			}
			if (reader[175] != DBNull.Value)
			{
				PCT0390171 = (int?)reader[175];
			}
			if (reader[176] != DBNull.Value)
			{
				PCT0390172 = (int?)reader[176];
			}
			if (reader[177] != DBNull.Value)
			{
				PCT0390173 = (int?)reader[177];
			}
			if (reader[178] != DBNull.Value)
			{
				PCT0390174 = (int?)reader[178];
			}
			if (reader[179] != DBNull.Value)
			{
				PCT0390175 = (int?)reader[179];
			}
			if (reader[180] != DBNull.Value)
			{
				PCT0390176 = (int?)reader[180];
			}
			if (reader[181] != DBNull.Value)
			{
				PCT0390177 = (int?)reader[181];
			}
			if (reader[182] != DBNull.Value)
			{
				PCT0390178 = (int?)reader[182];
			}
			if (reader[183] != DBNull.Value)
			{
				PCT0390179 = (int?)reader[183];
			}
			if (reader[184] != DBNull.Value)
			{
				PCT0390180 = (int?)reader[184];
			}
			if (reader[185] != DBNull.Value)
			{
				PCT0390181 = (int?)reader[185];
			}
			if (reader[186] != DBNull.Value)
			{
				PCT0390182 = (int?)reader[186];
			}
			if (reader[187] != DBNull.Value)
			{
				PCT0390183 = (int?)reader[187];
			}
			if (reader[188] != DBNull.Value)
			{
				PCT0390184 = (int?)reader[188];
			}
			if (reader[189] != DBNull.Value)
			{
				PCT0390185 = (int?)reader[189];
			}
			if (reader[190] != DBNull.Value)
			{
				PCT0390186 = (int?)reader[190];
			}
			if (reader[191] != DBNull.Value)
			{
				PCT0390187 = (int?)reader[191];
			}
			if (reader[192] != DBNull.Value)
			{
				PCT0390188 = (int?)reader[192];
			}
			if (reader[193] != DBNull.Value)
			{
				PCT0390189 = (int?)reader[193];
			}
			if (reader[194] != DBNull.Value)
			{
				PCT0390190 = (int?)reader[194];
			}
			if (reader[195] != DBNull.Value)
			{
				PCT0390191 = (int?)reader[195];
			}
			if (reader[196] != DBNull.Value)
			{
				PCT0390192 = (int?)reader[196];
			}
			if (reader[197] != DBNull.Value)
			{
				PCT0390193 = (int?)reader[197];
			}
			if (reader[198] != DBNull.Value)
			{
				PCT0390194 = (int?)reader[198];
			}
			if (reader[199] != DBNull.Value)
			{
				PCT0390195 = (int?)reader[199];
			}
			if (reader[200] != DBNull.Value)
			{
				PCT0400001 = (int?)reader[200];
			}
			if (reader[201] != DBNull.Value)
			{
				PCT0400002 = (int?)reader[201];
			}
			if (reader[202] != DBNull.Value)
			{
				PCT0400003 = (int?)reader[202];
			}
			if (reader[203] != DBNull.Value)
			{
				PCT0410001 = (int?)reader[203];
			}
			if (reader[204] != DBNull.Value)
			{
				PCT0410002 = (int?)reader[204];
			}
			if (reader[205] != DBNull.Value)
			{
				PCT0410003 = (int?)reader[205];
			}
			if (reader[206] != DBNull.Value)
			{
				PCT0420001 = (int?)reader[206];
			}
			if (reader[207] != DBNull.Value)
			{
				PCT0420002 = (int?)reader[207];
			}
			if (reader[208] != DBNull.Value)
			{
				PCT0420003 = (int?)reader[208];
			}
			if (reader[209] != DBNull.Value)
			{
				PCT0430001 = (int?)reader[209];
			}
			if (reader[210] != DBNull.Value)
			{
				PCT0430002 = (int?)reader[210];
			}
			if (reader[211] != DBNull.Value)
			{
				PCT0430003 = (int?)reader[211];
			}
			if (reader[212] != DBNull.Value)
			{
				PCT0440001 = (int?)reader[212];
			}
			if (reader[213] != DBNull.Value)
			{
				PCT0440002 = (int?)reader[213];
			}
			if (reader[214] != DBNull.Value)
			{
				PCT0440003 = (int?)reader[214];
			}
			if (reader[215] != DBNull.Value)
			{
				PCT0450001 = (int?)reader[215];
			}
			if (reader[216] != DBNull.Value)
			{
				PCT0450002 = (int?)reader[216];
			}
			if (reader[217] != DBNull.Value)
			{
				PCT0450003 = (int?)reader[217];
			}
			if (reader[218] != DBNull.Value)
			{
				PCT0460001 = (int?)reader[218];
			}
			if (reader[219] != DBNull.Value)
			{
				PCT0460002 = (int?)reader[219];
			}
			if (reader[220] != DBNull.Value)
			{
				PCT0460003 = (int?)reader[220];
			}
			if (reader[221] != DBNull.Value)
			{
				PCT0470001 = (int?)reader[221];
			}
			if (reader[222] != DBNull.Value)
			{
				PCT0470002 = (int?)reader[222];
			}
			if (reader[223] != DBNull.Value)
			{
				PCT0470003 = (int?)reader[223];
			}
		}
		#endregion Constructors
	}
}
