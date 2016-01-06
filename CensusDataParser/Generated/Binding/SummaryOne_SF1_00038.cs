#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/06/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryOne_SF1_00038.cs
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

	public class SummaryOne_SF1_00038 : BaseModel
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
		#endregion Properties

		#region Constructors
		public SummaryOne_SF1_00038(string csvLine) : base(csvLine) { }

		public SummaryOne_SF1_00038(string[] values) : base(values) { }

		public SummaryOne_SF1_00038(OleDbDataReader reader)
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
				PCT020F001 = (int?)reader[5];
			}
			if (reader[6] != DBNull.Value)
			{
				PCT020F002 = (int?)reader[6];
			}
			if (reader[7] != DBNull.Value)
			{
				PCT020F003 = (int?)reader[7];
			}
			if (reader[8] != DBNull.Value)
			{
				PCT020F004 = (int?)reader[8];
			}
			if (reader[9] != DBNull.Value)
			{
				PCT020F005 = (int?)reader[9];
			}
			if (reader[10] != DBNull.Value)
			{
				PCT020F006 = (int?)reader[10];
			}
			if (reader[11] != DBNull.Value)
			{
				PCT020F007 = (int?)reader[11];
			}
			if (reader[12] != DBNull.Value)
			{
				PCT020F008 = (int?)reader[12];
			}
			if (reader[13] != DBNull.Value)
			{
				PCT020F009 = (int?)reader[13];
			}
			if (reader[14] != DBNull.Value)
			{
				PCT020F010 = (int?)reader[14];
			}
			if (reader[15] != DBNull.Value)
			{
				PCT020F011 = (int?)reader[15];
			}
			if (reader[16] != DBNull.Value)
			{
				PCT020F012 = (int?)reader[16];
			}
			if (reader[17] != DBNull.Value)
			{
				PCT020F013 = (int?)reader[17];
			}
			if (reader[18] != DBNull.Value)
			{
				PCT020F014 = (int?)reader[18];
			}
			if (reader[19] != DBNull.Value)
			{
				PCT020F015 = (int?)reader[19];
			}
			if (reader[20] != DBNull.Value)
			{
				PCT020F016 = (int?)reader[20];
			}
			if (reader[21] != DBNull.Value)
			{
				PCT020F017 = (int?)reader[21];
			}
			if (reader[22] != DBNull.Value)
			{
				PCT020F018 = (int?)reader[22];
			}
			if (reader[23] != DBNull.Value)
			{
				PCT020F019 = (int?)reader[23];
			}
			if (reader[24] != DBNull.Value)
			{
				PCT020F020 = (int?)reader[24];
			}
			if (reader[25] != DBNull.Value)
			{
				PCT020F021 = (int?)reader[25];
			}
			if (reader[26] != DBNull.Value)
			{
				PCT020F022 = (int?)reader[26];
			}
			if (reader[27] != DBNull.Value)
			{
				PCT020F023 = (int?)reader[27];
			}
			if (reader[28] != DBNull.Value)
			{
				PCT020F024 = (int?)reader[28];
			}
			if (reader[29] != DBNull.Value)
			{
				PCT020F025 = (int?)reader[29];
			}
			if (reader[30] != DBNull.Value)
			{
				PCT020F026 = (int?)reader[30];
			}
			if (reader[31] != DBNull.Value)
			{
				PCT020F027 = (int?)reader[31];
			}
			if (reader[32] != DBNull.Value)
			{
				PCT020F028 = (int?)reader[32];
			}
			if (reader[33] != DBNull.Value)
			{
				PCT020F029 = (int?)reader[33];
			}
			if (reader[34] != DBNull.Value)
			{
				PCT020F030 = (int?)reader[34];
			}
			if (reader[35] != DBNull.Value)
			{
				PCT020F031 = (int?)reader[35];
			}
			if (reader[36] != DBNull.Value)
			{
				PCT020F032 = (int?)reader[36];
			}
			if (reader[37] != DBNull.Value)
			{
				PCT020G001 = (int?)reader[37];
			}
			if (reader[38] != DBNull.Value)
			{
				PCT020G002 = (int?)reader[38];
			}
			if (reader[39] != DBNull.Value)
			{
				PCT020G003 = (int?)reader[39];
			}
			if (reader[40] != DBNull.Value)
			{
				PCT020G004 = (int?)reader[40];
			}
			if (reader[41] != DBNull.Value)
			{
				PCT020G005 = (int?)reader[41];
			}
			if (reader[42] != DBNull.Value)
			{
				PCT020G006 = (int?)reader[42];
			}
			if (reader[43] != DBNull.Value)
			{
				PCT020G007 = (int?)reader[43];
			}
			if (reader[44] != DBNull.Value)
			{
				PCT020G008 = (int?)reader[44];
			}
			if (reader[45] != DBNull.Value)
			{
				PCT020G009 = (int?)reader[45];
			}
			if (reader[46] != DBNull.Value)
			{
				PCT020G010 = (int?)reader[46];
			}
			if (reader[47] != DBNull.Value)
			{
				PCT020G011 = (int?)reader[47];
			}
			if (reader[48] != DBNull.Value)
			{
				PCT020G012 = (int?)reader[48];
			}
			if (reader[49] != DBNull.Value)
			{
				PCT020G013 = (int?)reader[49];
			}
			if (reader[50] != DBNull.Value)
			{
				PCT020G014 = (int?)reader[50];
			}
			if (reader[51] != DBNull.Value)
			{
				PCT020G015 = (int?)reader[51];
			}
			if (reader[52] != DBNull.Value)
			{
				PCT020G016 = (int?)reader[52];
			}
			if (reader[53] != DBNull.Value)
			{
				PCT020G017 = (int?)reader[53];
			}
			if (reader[54] != DBNull.Value)
			{
				PCT020G018 = (int?)reader[54];
			}
			if (reader[55] != DBNull.Value)
			{
				PCT020G019 = (int?)reader[55];
			}
			if (reader[56] != DBNull.Value)
			{
				PCT020G020 = (int?)reader[56];
			}
			if (reader[57] != DBNull.Value)
			{
				PCT020G021 = (int?)reader[57];
			}
			if (reader[58] != DBNull.Value)
			{
				PCT020G022 = (int?)reader[58];
			}
			if (reader[59] != DBNull.Value)
			{
				PCT020G023 = (int?)reader[59];
			}
			if (reader[60] != DBNull.Value)
			{
				PCT020G024 = (int?)reader[60];
			}
			if (reader[61] != DBNull.Value)
			{
				PCT020G025 = (int?)reader[61];
			}
			if (reader[62] != DBNull.Value)
			{
				PCT020G026 = (int?)reader[62];
			}
			if (reader[63] != DBNull.Value)
			{
				PCT020G027 = (int?)reader[63];
			}
			if (reader[64] != DBNull.Value)
			{
				PCT020G028 = (int?)reader[64];
			}
			if (reader[65] != DBNull.Value)
			{
				PCT020G029 = (int?)reader[65];
			}
			if (reader[66] != DBNull.Value)
			{
				PCT020G030 = (int?)reader[66];
			}
			if (reader[67] != DBNull.Value)
			{
				PCT020G031 = (int?)reader[67];
			}
			if (reader[68] != DBNull.Value)
			{
				PCT020G032 = (int?)reader[68];
			}
			if (reader[69] != DBNull.Value)
			{
				PCT020H001 = (int?)reader[69];
			}
			if (reader[70] != DBNull.Value)
			{
				PCT020H002 = (int?)reader[70];
			}
			if (reader[71] != DBNull.Value)
			{
				PCT020H003 = (int?)reader[71];
			}
			if (reader[72] != DBNull.Value)
			{
				PCT020H004 = (int?)reader[72];
			}
			if (reader[73] != DBNull.Value)
			{
				PCT020H005 = (int?)reader[73];
			}
			if (reader[74] != DBNull.Value)
			{
				PCT020H006 = (int?)reader[74];
			}
			if (reader[75] != DBNull.Value)
			{
				PCT020H007 = (int?)reader[75];
			}
			if (reader[76] != DBNull.Value)
			{
				PCT020H008 = (int?)reader[76];
			}
			if (reader[77] != DBNull.Value)
			{
				PCT020H009 = (int?)reader[77];
			}
			if (reader[78] != DBNull.Value)
			{
				PCT020H010 = (int?)reader[78];
			}
			if (reader[79] != DBNull.Value)
			{
				PCT020H011 = (int?)reader[79];
			}
			if (reader[80] != DBNull.Value)
			{
				PCT020H012 = (int?)reader[80];
			}
			if (reader[81] != DBNull.Value)
			{
				PCT020H013 = (int?)reader[81];
			}
			if (reader[82] != DBNull.Value)
			{
				PCT020H014 = (int?)reader[82];
			}
			if (reader[83] != DBNull.Value)
			{
				PCT020H015 = (int?)reader[83];
			}
			if (reader[84] != DBNull.Value)
			{
				PCT020H016 = (int?)reader[84];
			}
			if (reader[85] != DBNull.Value)
			{
				PCT020H017 = (int?)reader[85];
			}
			if (reader[86] != DBNull.Value)
			{
				PCT020H018 = (int?)reader[86];
			}
			if (reader[87] != DBNull.Value)
			{
				PCT020H019 = (int?)reader[87];
			}
			if (reader[88] != DBNull.Value)
			{
				PCT020H020 = (int?)reader[88];
			}
			if (reader[89] != DBNull.Value)
			{
				PCT020H021 = (int?)reader[89];
			}
			if (reader[90] != DBNull.Value)
			{
				PCT020H022 = (int?)reader[90];
			}
			if (reader[91] != DBNull.Value)
			{
				PCT020H023 = (int?)reader[91];
			}
			if (reader[92] != DBNull.Value)
			{
				PCT020H024 = (int?)reader[92];
			}
			if (reader[93] != DBNull.Value)
			{
				PCT020H025 = (int?)reader[93];
			}
			if (reader[94] != DBNull.Value)
			{
				PCT020H026 = (int?)reader[94];
			}
			if (reader[95] != DBNull.Value)
			{
				PCT020H027 = (int?)reader[95];
			}
			if (reader[96] != DBNull.Value)
			{
				PCT020H028 = (int?)reader[96];
			}
			if (reader[97] != DBNull.Value)
			{
				PCT020H029 = (int?)reader[97];
			}
			if (reader[98] != DBNull.Value)
			{
				PCT020H030 = (int?)reader[98];
			}
			if (reader[99] != DBNull.Value)
			{
				PCT020H031 = (int?)reader[99];
			}
			if (reader[100] != DBNull.Value)
			{
				PCT020H032 = (int?)reader[100];
			}
			if (reader[101] != DBNull.Value)
			{
				PCT020I001 = (int?)reader[101];
			}
			if (reader[102] != DBNull.Value)
			{
				PCT020I002 = (int?)reader[102];
			}
			if (reader[103] != DBNull.Value)
			{
				PCT020I003 = (int?)reader[103];
			}
			if (reader[104] != DBNull.Value)
			{
				PCT020I004 = (int?)reader[104];
			}
			if (reader[105] != DBNull.Value)
			{
				PCT020I005 = (int?)reader[105];
			}
			if (reader[106] != DBNull.Value)
			{
				PCT020I006 = (int?)reader[106];
			}
			if (reader[107] != DBNull.Value)
			{
				PCT020I007 = (int?)reader[107];
			}
			if (reader[108] != DBNull.Value)
			{
				PCT020I008 = (int?)reader[108];
			}
			if (reader[109] != DBNull.Value)
			{
				PCT020I009 = (int?)reader[109];
			}
			if (reader[110] != DBNull.Value)
			{
				PCT020I010 = (int?)reader[110];
			}
			if (reader[111] != DBNull.Value)
			{
				PCT020I011 = (int?)reader[111];
			}
			if (reader[112] != DBNull.Value)
			{
				PCT020I012 = (int?)reader[112];
			}
			if (reader[113] != DBNull.Value)
			{
				PCT020I013 = (int?)reader[113];
			}
			if (reader[114] != DBNull.Value)
			{
				PCT020I014 = (int?)reader[114];
			}
			if (reader[115] != DBNull.Value)
			{
				PCT020I015 = (int?)reader[115];
			}
			if (reader[116] != DBNull.Value)
			{
				PCT020I016 = (int?)reader[116];
			}
			if (reader[117] != DBNull.Value)
			{
				PCT020I017 = (int?)reader[117];
			}
			if (reader[118] != DBNull.Value)
			{
				PCT020I018 = (int?)reader[118];
			}
			if (reader[119] != DBNull.Value)
			{
				PCT020I019 = (int?)reader[119];
			}
			if (reader[120] != DBNull.Value)
			{
				PCT020I020 = (int?)reader[120];
			}
			if (reader[121] != DBNull.Value)
			{
				PCT020I021 = (int?)reader[121];
			}
			if (reader[122] != DBNull.Value)
			{
				PCT020I022 = (int?)reader[122];
			}
			if (reader[123] != DBNull.Value)
			{
				PCT020I023 = (int?)reader[123];
			}
			if (reader[124] != DBNull.Value)
			{
				PCT020I024 = (int?)reader[124];
			}
			if (reader[125] != DBNull.Value)
			{
				PCT020I025 = (int?)reader[125];
			}
			if (reader[126] != DBNull.Value)
			{
				PCT020I026 = (int?)reader[126];
			}
			if (reader[127] != DBNull.Value)
			{
				PCT020I027 = (int?)reader[127];
			}
			if (reader[128] != DBNull.Value)
			{
				PCT020I028 = (int?)reader[128];
			}
			if (reader[129] != DBNull.Value)
			{
				PCT020I029 = (int?)reader[129];
			}
			if (reader[130] != DBNull.Value)
			{
				PCT020I030 = (int?)reader[130];
			}
			if (reader[131] != DBNull.Value)
			{
				PCT020I031 = (int?)reader[131];
			}
			if (reader[132] != DBNull.Value)
			{
				PCT020I032 = (int?)reader[132];
			}
			if (reader[133] != DBNull.Value)
			{
				PCT022A001 = (int?)reader[133];
			}
			if (reader[134] != DBNull.Value)
			{
				PCT022A002 = (int?)reader[134];
			}
			if (reader[135] != DBNull.Value)
			{
				PCT022A003 = (int?)reader[135];
			}
			if (reader[136] != DBNull.Value)
			{
				PCT022A004 = (int?)reader[136];
			}
			if (reader[137] != DBNull.Value)
			{
				PCT022A005 = (int?)reader[137];
			}
			if (reader[138] != DBNull.Value)
			{
				PCT022A006 = (int?)reader[138];
			}
			if (reader[139] != DBNull.Value)
			{
				PCT022A007 = (int?)reader[139];
			}
			if (reader[140] != DBNull.Value)
			{
				PCT022A008 = (int?)reader[140];
			}
			if (reader[141] != DBNull.Value)
			{
				PCT022A009 = (int?)reader[141];
			}
			if (reader[142] != DBNull.Value)
			{
				PCT022A010 = (int?)reader[142];
			}
			if (reader[143] != DBNull.Value)
			{
				PCT022A011 = (int?)reader[143];
			}
			if (reader[144] != DBNull.Value)
			{
				PCT022A012 = (int?)reader[144];
			}
			if (reader[145] != DBNull.Value)
			{
				PCT022A013 = (int?)reader[145];
			}
			if (reader[146] != DBNull.Value)
			{
				PCT022A014 = (int?)reader[146];
			}
			if (reader[147] != DBNull.Value)
			{
				PCT022A015 = (int?)reader[147];
			}
			if (reader[148] != DBNull.Value)
			{
				PCT022A016 = (int?)reader[148];
			}
			if (reader[149] != DBNull.Value)
			{
				PCT022A017 = (int?)reader[149];
			}
			if (reader[150] != DBNull.Value)
			{
				PCT022A018 = (int?)reader[150];
			}
			if (reader[151] != DBNull.Value)
			{
				PCT022A019 = (int?)reader[151];
			}
			if (reader[152] != DBNull.Value)
			{
				PCT022A020 = (int?)reader[152];
			}
			if (reader[153] != DBNull.Value)
			{
				PCT022A021 = (int?)reader[153];
			}
			if (reader[154] != DBNull.Value)
			{
				PCT022B001 = (int?)reader[154];
			}
			if (reader[155] != DBNull.Value)
			{
				PCT022B002 = (int?)reader[155];
			}
			if (reader[156] != DBNull.Value)
			{
				PCT022B003 = (int?)reader[156];
			}
			if (reader[157] != DBNull.Value)
			{
				PCT022B004 = (int?)reader[157];
			}
			if (reader[158] != DBNull.Value)
			{
				PCT022B005 = (int?)reader[158];
			}
			if (reader[159] != DBNull.Value)
			{
				PCT022B006 = (int?)reader[159];
			}
			if (reader[160] != DBNull.Value)
			{
				PCT022B007 = (int?)reader[160];
			}
			if (reader[161] != DBNull.Value)
			{
				PCT022B008 = (int?)reader[161];
			}
			if (reader[162] != DBNull.Value)
			{
				PCT022B009 = (int?)reader[162];
			}
			if (reader[163] != DBNull.Value)
			{
				PCT022B010 = (int?)reader[163];
			}
			if (reader[164] != DBNull.Value)
			{
				PCT022B011 = (int?)reader[164];
			}
			if (reader[165] != DBNull.Value)
			{
				PCT022B012 = (int?)reader[165];
			}
			if (reader[166] != DBNull.Value)
			{
				PCT022B013 = (int?)reader[166];
			}
			if (reader[167] != DBNull.Value)
			{
				PCT022B014 = (int?)reader[167];
			}
			if (reader[168] != DBNull.Value)
			{
				PCT022B015 = (int?)reader[168];
			}
			if (reader[169] != DBNull.Value)
			{
				PCT022B016 = (int?)reader[169];
			}
			if (reader[170] != DBNull.Value)
			{
				PCT022B017 = (int?)reader[170];
			}
			if (reader[171] != DBNull.Value)
			{
				PCT022B018 = (int?)reader[171];
			}
			if (reader[172] != DBNull.Value)
			{
				PCT022B019 = (int?)reader[172];
			}
			if (reader[173] != DBNull.Value)
			{
				PCT022B020 = (int?)reader[173];
			}
			if (reader[174] != DBNull.Value)
			{
				PCT022B021 = (int?)reader[174];
			}
			if (reader[175] != DBNull.Value)
			{
				PCT022C001 = (int?)reader[175];
			}
			if (reader[176] != DBNull.Value)
			{
				PCT022C002 = (int?)reader[176];
			}
			if (reader[177] != DBNull.Value)
			{
				PCT022C003 = (int?)reader[177];
			}
			if (reader[178] != DBNull.Value)
			{
				PCT022C004 = (int?)reader[178];
			}
			if (reader[179] != DBNull.Value)
			{
				PCT022C005 = (int?)reader[179];
			}
			if (reader[180] != DBNull.Value)
			{
				PCT022C006 = (int?)reader[180];
			}
			if (reader[181] != DBNull.Value)
			{
				PCT022C007 = (int?)reader[181];
			}
			if (reader[182] != DBNull.Value)
			{
				PCT022C008 = (int?)reader[182];
			}
			if (reader[183] != DBNull.Value)
			{
				PCT022C009 = (int?)reader[183];
			}
			if (reader[184] != DBNull.Value)
			{
				PCT022C010 = (int?)reader[184];
			}
			if (reader[185] != DBNull.Value)
			{
				PCT022C011 = (int?)reader[185];
			}
			if (reader[186] != DBNull.Value)
			{
				PCT022C012 = (int?)reader[186];
			}
			if (reader[187] != DBNull.Value)
			{
				PCT022C013 = (int?)reader[187];
			}
			if (reader[188] != DBNull.Value)
			{
				PCT022C014 = (int?)reader[188];
			}
			if (reader[189] != DBNull.Value)
			{
				PCT022C015 = (int?)reader[189];
			}
			if (reader[190] != DBNull.Value)
			{
				PCT022C016 = (int?)reader[190];
			}
			if (reader[191] != DBNull.Value)
			{
				PCT022C017 = (int?)reader[191];
			}
			if (reader[192] != DBNull.Value)
			{
				PCT022C018 = (int?)reader[192];
			}
			if (reader[193] != DBNull.Value)
			{
				PCT022C019 = (int?)reader[193];
			}
			if (reader[194] != DBNull.Value)
			{
				PCT022C020 = (int?)reader[194];
			}
			if (reader[195] != DBNull.Value)
			{
				PCT022C021 = (int?)reader[195];
			}
			if (reader[196] != DBNull.Value)
			{
				PCT022D001 = (int?)reader[196];
			}
			if (reader[197] != DBNull.Value)
			{
				PCT022D002 = (int?)reader[197];
			}
			if (reader[198] != DBNull.Value)
			{
				PCT022D003 = (int?)reader[198];
			}
			if (reader[199] != DBNull.Value)
			{
				PCT022D004 = (int?)reader[199];
			}
			if (reader[200] != DBNull.Value)
			{
				PCT022D005 = (int?)reader[200];
			}
			if (reader[201] != DBNull.Value)
			{
				PCT022D006 = (int?)reader[201];
			}
			if (reader[202] != DBNull.Value)
			{
				PCT022D007 = (int?)reader[202];
			}
			if (reader[203] != DBNull.Value)
			{
				PCT022D008 = (int?)reader[203];
			}
			if (reader[204] != DBNull.Value)
			{
				PCT022D009 = (int?)reader[204];
			}
			if (reader[205] != DBNull.Value)
			{
				PCT022D010 = (int?)reader[205];
			}
			if (reader[206] != DBNull.Value)
			{
				PCT022D011 = (int?)reader[206];
			}
			if (reader[207] != DBNull.Value)
			{
				PCT022D012 = (int?)reader[207];
			}
			if (reader[208] != DBNull.Value)
			{
				PCT022D013 = (int?)reader[208];
			}
			if (reader[209] != DBNull.Value)
			{
				PCT022D014 = (int?)reader[209];
			}
			if (reader[210] != DBNull.Value)
			{
				PCT022D015 = (int?)reader[210];
			}
			if (reader[211] != DBNull.Value)
			{
				PCT022D016 = (int?)reader[211];
			}
			if (reader[212] != DBNull.Value)
			{
				PCT022D017 = (int?)reader[212];
			}
			if (reader[213] != DBNull.Value)
			{
				PCT022D018 = (int?)reader[213];
			}
			if (reader[214] != DBNull.Value)
			{
				PCT022D019 = (int?)reader[214];
			}
			if (reader[215] != DBNull.Value)
			{
				PCT022D020 = (int?)reader[215];
			}
			if (reader[216] != DBNull.Value)
			{
				PCT022D021 = (int?)reader[216];
			}
			if (reader[217] != DBNull.Value)
			{
				PCT022E001 = (int?)reader[217];
			}
			if (reader[218] != DBNull.Value)
			{
				PCT022E002 = (int?)reader[218];
			}
			if (reader[219] != DBNull.Value)
			{
				PCT022E003 = (int?)reader[219];
			}
			if (reader[220] != DBNull.Value)
			{
				PCT022E004 = (int?)reader[220];
			}
			if (reader[221] != DBNull.Value)
			{
				PCT022E005 = (int?)reader[221];
			}
			if (reader[222] != DBNull.Value)
			{
				PCT022E006 = (int?)reader[222];
			}
			if (reader[223] != DBNull.Value)
			{
				PCT022E007 = (int?)reader[223];
			}
			if (reader[224] != DBNull.Value)
			{
				PCT022E008 = (int?)reader[224];
			}
			if (reader[225] != DBNull.Value)
			{
				PCT022E009 = (int?)reader[225];
			}
			if (reader[226] != DBNull.Value)
			{
				PCT022E010 = (int?)reader[226];
			}
			if (reader[227] != DBNull.Value)
			{
				PCT022E011 = (int?)reader[227];
			}
			if (reader[228] != DBNull.Value)
			{
				PCT022E012 = (int?)reader[228];
			}
			if (reader[229] != DBNull.Value)
			{
				PCT022E013 = (int?)reader[229];
			}
			if (reader[230] != DBNull.Value)
			{
				PCT022E014 = (int?)reader[230];
			}
			if (reader[231] != DBNull.Value)
			{
				PCT022E015 = (int?)reader[231];
			}
			if (reader[232] != DBNull.Value)
			{
				PCT022E016 = (int?)reader[232];
			}
			if (reader[233] != DBNull.Value)
			{
				PCT022E017 = (int?)reader[233];
			}
			if (reader[234] != DBNull.Value)
			{
				PCT022E018 = (int?)reader[234];
			}
			if (reader[235] != DBNull.Value)
			{
				PCT022E019 = (int?)reader[235];
			}
			if (reader[236] != DBNull.Value)
			{
				PCT022E020 = (int?)reader[236];
			}
			if (reader[237] != DBNull.Value)
			{
				PCT022E021 = (int?)reader[237];
			}
			if (reader[238] != DBNull.Value)
			{
				PCT022F001 = (int?)reader[238];
			}
			if (reader[239] != DBNull.Value)
			{
				PCT022F002 = (int?)reader[239];
			}
			if (reader[240] != DBNull.Value)
			{
				PCT022F003 = (int?)reader[240];
			}
			if (reader[241] != DBNull.Value)
			{
				PCT022F004 = (int?)reader[241];
			}
			if (reader[242] != DBNull.Value)
			{
				PCT022F005 = (int?)reader[242];
			}
			if (reader[243] != DBNull.Value)
			{
				PCT022F006 = (int?)reader[243];
			}
			if (reader[244] != DBNull.Value)
			{
				PCT022F007 = (int?)reader[244];
			}
			if (reader[245] != DBNull.Value)
			{
				PCT022F008 = (int?)reader[245];
			}
			if (reader[246] != DBNull.Value)
			{
				PCT022F009 = (int?)reader[246];
			}
			if (reader[247] != DBNull.Value)
			{
				PCT022F010 = (int?)reader[247];
			}
			if (reader[248] != DBNull.Value)
			{
				PCT022F011 = (int?)reader[248];
			}
			if (reader[249] != DBNull.Value)
			{
				PCT022F012 = (int?)reader[249];
			}
			if (reader[250] != DBNull.Value)
			{
				PCT022F013 = (int?)reader[250];
			}
			if (reader[251] != DBNull.Value)
			{
				PCT022F014 = (int?)reader[251];
			}
			if (reader[252] != DBNull.Value)
			{
				PCT022F015 = (int?)reader[252];
			}
			if (reader[253] != DBNull.Value)
			{
				PCT022F016 = (int?)reader[253];
			}
			if (reader[254] != DBNull.Value)
			{
				PCT022F017 = (int?)reader[254];
			}
			if (reader[255] != DBNull.Value)
			{
				PCT022F018 = (int?)reader[255];
			}
			if (reader[256] != DBNull.Value)
			{
				PCT022F019 = (int?)reader[256];
			}
			if (reader[257] != DBNull.Value)
			{
				PCT022F020 = (int?)reader[257];
			}
			if (reader[258] != DBNull.Value)
			{
				PCT022F021 = (int?)reader[258];
			}
		}
		#endregion Constructors
	}
}
