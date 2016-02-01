#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SummaryOne_SF1_00037.cs
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
    using Models;
    #endregion

    public class SummaryOne_SF1_00037 : BaseModel
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
        public int? PCT019C001 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 6)]
        public int? PCT019C002 { get; set; }

        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 7)]
        public int? PCT019C003 { get; set; }

        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 8)]
        public int? PCT019C004 { get; set; }

        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 9)]
        public int? PCT019C005 { get; set; }

        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 10)]
        public int? PCT019C006 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 11)]
        public int? PCT019C007 { get; set; }

        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 12)]
        public int? PCT019C008 { get; set; }

        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 13)]
        public int? PCT019C009 { get; set; }

        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 14)]
        public int? PCT019C010 { get; set; }

        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 15)]
        public int? PCT019C011 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 16)]
        public int? PCT019D001 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 17)]
        public int? PCT019D002 { get; set; }

        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 18)]
        public int? PCT019D003 { get; set; }

        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 19)]
        public int? PCT019D004 { get; set; }

        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 20)]
        public int? PCT019D005 { get; set; }

        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 21)]
        public int? PCT019D006 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 22)]
        public int? PCT019D007 { get; set; }

        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 23)]
        public int? PCT019D008 { get; set; }

        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 24)]
        public int? PCT019D009 { get; set; }

        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 25)]
        public int? PCT019D010 { get; set; }

        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 26)]
        public int? PCT019D011 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 27)]
        public int? PCT019E001 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 28)]
        public int? PCT019E002 { get; set; }

        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 29)]
        public int? PCT019E003 { get; set; }

        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 30)]
        public int? PCT019E004 { get; set; }

        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 31)]
        public int? PCT019E005 { get; set; }

        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 32)]
        public int? PCT019E006 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 33)]
        public int? PCT019E007 { get; set; }

        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 34)]
        public int? PCT019E008 { get; set; }

        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 35)]
        public int? PCT019E009 { get; set; }

        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 36)]
        public int? PCT019E010 { get; set; }

        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 37)]
        public int? PCT019E011 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 38)]
        public int? PCT019F001 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 39)]
        public int? PCT019F002 { get; set; }

        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 40)]
        public int? PCT019F003 { get; set; }

        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 41)]
        public int? PCT019F004 { get; set; }

        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 42)]
        public int? PCT019F005 { get; set; }

        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 43)]
        public int? PCT019F006 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 44)]
        public int? PCT019F007 { get; set; }

        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 45)]
        public int? PCT019F008 { get; set; }

        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 46)]
        public int? PCT019F009 { get; set; }

        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 47)]
        public int? PCT019F010 { get; set; }

        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 48)]
        public int? PCT019F011 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 49)]
        public int? PCT019G001 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 50)]
        public int? PCT019G002 { get; set; }

        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 51)]
        public int? PCT019G003 { get; set; }

        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 52)]
        public int? PCT019G004 { get; set; }

        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 53)]
        public int? PCT019G005 { get; set; }

        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 54)]
        public int? PCT019G006 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 55)]
        public int? PCT019G007 { get; set; }

        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 56)]
        public int? PCT019G008 { get; set; }

        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 57)]
        public int? PCT019G009 { get; set; }

        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 58)]
        public int? PCT019G010 { get; set; }

        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 59)]
        public int? PCT019G011 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 60)]
        public int? PCT019H001 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 61)]
        public int? PCT019H002 { get; set; }

        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 62)]
        public int? PCT019H003 { get; set; }

        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 63)]
        public int? PCT019H004 { get; set; }

        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 64)]
        public int? PCT019H005 { get; set; }

        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 65)]
        public int? PCT019H006 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 66)]
        public int? PCT019H007 { get; set; }

        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 67)]
        public int? PCT019H008 { get; set; }

        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 68)]
        public int? PCT019H009 { get; set; }

        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 69)]
        public int? PCT019H010 { get; set; }

        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 70)]
        public int? PCT019H011 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 71)]
        public int? PCT019I001 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 72)]
        public int? PCT019I002 { get; set; }

        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 73)]
        public int? PCT019I003 { get; set; }

        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 74)]
        public int? PCT019I004 { get; set; }

        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 75)]
        public int? PCT019I005 { get; set; }

        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 76)]
        public int? PCT019I006 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 77)]
        public int? PCT019I007 { get; set; }

        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 78)]
        public int? PCT019I008 { get; set; }

        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 79)]
        public int? PCT019I009 { get; set; }

        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 80)]
        public int? PCT019I010 { get; set; }

        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 81)]
        public int? PCT019I011 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 82)]
        public int? PCT020A001 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 83)]
        public int? PCT020A002 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 84)]
        public int? PCT020A003 { get; set; }

        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 85)]
        public int? PCT020A004 { get; set; }

        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 86)]
        public int? PCT020A005 { get; set; }

        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 87)]
        public int? PCT020A006 { get; set; }

        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 88)]
        public int? PCT020A007 { get; set; }

        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 89)]
        public int? PCT020A008 { get; set; }

        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 90)]
        public int? PCT020A009 { get; set; }

        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 91)]
        public int? PCT020A010 { get; set; }

        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 92)]
        public int? PCT020A011 { get; set; }

        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 93)]
        public int? PCT020A012 { get; set; }

        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 94)]
        public int? PCT020A013 { get; set; }

        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 95)]
        public int? PCT020A014 { get; set; }

        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 96)]
        public int? PCT020A015 { get; set; }

        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 97)]
        public int? PCT020A016 { get; set; }

        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 98)]
        public int? PCT020A017 { get; set; }

        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 99)]
        public int? PCT020A018 { get; set; }

        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 100)]
        public int? PCT020A019 { get; set; }

        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 101)]
        public int? PCT020A020 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 102)]
        public int? PCT020A021 { get; set; }

        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 103)]
        public int? PCT020A022 { get; set; }

        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 104)]
        public int? PCT020A023 { get; set; }

        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 105)]
        public int? PCT020A024 { get; set; }

        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 106)]
        public int? PCT020A025 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 107)]
        public int? PCT020A026 { get; set; }

        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 108)]
        public int? PCT020A027 { get; set; }

        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 109)]
        public int? PCT020A028 { get; set; }

        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 110)]
        public int? PCT020A029 { get; set; }

        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 111)]
        public int? PCT020A030 { get; set; }

        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 112)]
        public int? PCT020A031 { get; set; }

        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 113)]
        public int? PCT020A032 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 114)]
        public int? PCT020B001 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 115)]
        public int? PCT020B002 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 116)]
        public int? PCT020B003 { get; set; }

        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 117)]
        public int? PCT020B004 { get; set; }

        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 118)]
        public int? PCT020B005 { get; set; }

        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 119)]
        public int? PCT020B006 { get; set; }

        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 120)]
        public int? PCT020B007 { get; set; }

        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 121)]
        public int? PCT020B008 { get; set; }

        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 122)]
        public int? PCT020B009 { get; set; }

        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 123)]
        public int? PCT020B010 { get; set; }

        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 124)]
        public int? PCT020B011 { get; set; }

        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 125)]
        public int? PCT020B012 { get; set; }

        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 126)]
        public int? PCT020B013 { get; set; }

        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 127)]
        public int? PCT020B014 { get; set; }

        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 128)]
        public int? PCT020B015 { get; set; }

        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 129)]
        public int? PCT020B016 { get; set; }

        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 130)]
        public int? PCT020B017 { get; set; }

        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 131)]
        public int? PCT020B018 { get; set; }

        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 132)]
        public int? PCT020B019 { get; set; }

        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 133)]
        public int? PCT020B020 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 134)]
        public int? PCT020B021 { get; set; }

        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 135)]
        public int? PCT020B022 { get; set; }

        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 136)]
        public int? PCT020B023 { get; set; }

        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 137)]
        public int? PCT020B024 { get; set; }

        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 138)]
        public int? PCT020B025 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 139)]
        public int? PCT020B026 { get; set; }

        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 140)]
        public int? PCT020B027 { get; set; }

        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 141)]
        public int? PCT020B028 { get; set; }

        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 142)]
        public int? PCT020B029 { get; set; }

        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 143)]
        public int? PCT020B030 { get; set; }

        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 144)]
        public int? PCT020B031 { get; set; }

        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 145)]
        public int? PCT020B032 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 146)]
        public int? PCT020C001 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 147)]
        public int? PCT020C002 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 148)]
        public int? PCT020C003 { get; set; }

        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 149)]
        public int? PCT020C004 { get; set; }

        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 150)]
        public int? PCT020C005 { get; set; }

        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 151)]
        public int? PCT020C006 { get; set; }

        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 152)]
        public int? PCT020C007 { get; set; }

        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 153)]
        public int? PCT020C008 { get; set; }

        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 154)]
        public int? PCT020C009 { get; set; }

        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 155)]
        public int? PCT020C010 { get; set; }

        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 156)]
        public int? PCT020C011 { get; set; }

        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 157)]
        public int? PCT020C012 { get; set; }

        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 158)]
        public int? PCT020C013 { get; set; }

        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 159)]
        public int? PCT020C014 { get; set; }

        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 160)]
        public int? PCT020C015 { get; set; }

        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 161)]
        public int? PCT020C016 { get; set; }

        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 162)]
        public int? PCT020C017 { get; set; }

        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 163)]
        public int? PCT020C018 { get; set; }

        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 164)]
        public int? PCT020C019 { get; set; }

        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 165)]
        public int? PCT020C020 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 166)]
        public int? PCT020C021 { get; set; }

        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 167)]
        public int? PCT020C022 { get; set; }

        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 168)]
        public int? PCT020C023 { get; set; }

        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 169)]
        public int? PCT020C024 { get; set; }

        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 170)]
        public int? PCT020C025 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 171)]
        public int? PCT020C026 { get; set; }

        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 172)]
        public int? PCT020C027 { get; set; }

        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 173)]
        public int? PCT020C028 { get; set; }

        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 174)]
        public int? PCT020C029 { get; set; }

        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 175)]
        public int? PCT020C030 { get; set; }

        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 176)]
        public int? PCT020C031 { get; set; }

        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 177)]
        public int? PCT020C032 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 178)]
        public int? PCT020D001 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 179)]
        public int? PCT020D002 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 180)]
        public int? PCT020D003 { get; set; }

        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 181)]
        public int? PCT020D004 { get; set; }

        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 182)]
        public int? PCT020D005 { get; set; }

        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 183)]
        public int? PCT020D006 { get; set; }

        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 184)]
        public int? PCT020D007 { get; set; }

        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 185)]
        public int? PCT020D008 { get; set; }

        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 186)]
        public int? PCT020D009 { get; set; }

        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 187)]
        public int? PCT020D010 { get; set; }

        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 188)]
        public int? PCT020D011 { get; set; }

        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 189)]
        public int? PCT020D012 { get; set; }

        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 190)]
        public int? PCT020D013 { get; set; }

        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 191)]
        public int? PCT020D014 { get; set; }

        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 192)]
        public int? PCT020D015 { get; set; }

        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 193)]
        public int? PCT020D016 { get; set; }

        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 194)]
        public int? PCT020D017 { get; set; }

        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 195)]
        public int? PCT020D018 { get; set; }

        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 196)]
        public int? PCT020D019 { get; set; }

        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 197)]
        public int? PCT020D020 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 198)]
        public int? PCT020D021 { get; set; }

        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 199)]
        public int? PCT020D022 { get; set; }

        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 200)]
        public int? PCT020D023 { get; set; }

        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 201)]
        public int? PCT020D024 { get; set; }

        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 202)]
        public int? PCT020D025 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 203)]
        public int? PCT020D026 { get; set; }

        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 204)]
        public int? PCT020D027 { get; set; }

        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 205)]
        public int? PCT020D028 { get; set; }

        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 206)]
        public int? PCT020D029 { get; set; }

        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 207)]
        public int? PCT020D030 { get; set; }

        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 208)]
        public int? PCT020D031 { get; set; }

        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 209)]
        public int? PCT020D032 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 210)]
        public int? PCT020E001 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 211)]
        public int? PCT020E002 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 212)]
        public int? PCT020E003 { get; set; }

        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 213)]
        public int? PCT020E004 { get; set; }

        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 214)]
        public int? PCT020E005 { get; set; }

        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 215)]
        public int? PCT020E006 { get; set; }

        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 216)]
        public int? PCT020E007 { get; set; }

        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 217)]
        public int? PCT020E008 { get; set; }

        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 218)]
        public int? PCT020E009 { get; set; }

        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 219)]
        public int? PCT020E010 { get; set; }

        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 220)]
        public int? PCT020E011 { get; set; }

        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 221)]
        public int? PCT020E012 { get; set; }

        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 222)]
        public int? PCT020E013 { get; set; }

        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 223)]
        public int? PCT020E014 { get; set; }

        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 224)]
        public int? PCT020E015 { get; set; }

        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 225)]
        public int? PCT020E016 { get; set; }

        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 226)]
        public int? PCT020E017 { get; set; }

        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 227)]
        public int? PCT020E018 { get; set; }

        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 228)]
        public int? PCT020E019 { get; set; }

        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 229)]
        public int? PCT020E020 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 230)]
        public int? PCT020E021 { get; set; }

        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 231)]
        public int? PCT020E022 { get; set; }

        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 232)]
        public int? PCT020E023 { get; set; }

        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 233)]
        public int? PCT020E024 { get; set; }

        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 234)]
        public int? PCT020E025 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 235)]
        public int? PCT020E026 { get; set; }

        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 236)]
        public int? PCT020E027 { get; set; }

        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 237)]
        public int? PCT020E028 { get; set; }

        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 238)]
        public int? PCT020E029 { get; set; }

        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 239)]
        public int? PCT020E030 { get; set; }

        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 240)]
        public int? PCT020E031 { get; set; }

        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 241)]
        public int? PCT020E032 { get; set; }
        #endregion Properties

        #region Constructors
        public SummaryOne_SF1_00037() { }

        public SummaryOne_SF1_00037(string csvLine) : base(csvLine) { }

        public SummaryOne_SF1_00037(string[] values) : base(values) { }

        public SummaryOne_SF1_00037(OleDbDataReader reader)
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
                PCT019C001 = (int?)reader[5];
            }
            if (reader[6] != DBNull.Value)
            {
                PCT019C002 = (int?)reader[6];
            }
            if (reader[7] != DBNull.Value)
            {
                PCT019C003 = (int?)reader[7];
            }
            if (reader[8] != DBNull.Value)
            {
                PCT019C004 = (int?)reader[8];
            }
            if (reader[9] != DBNull.Value)
            {
                PCT019C005 = (int?)reader[9];
            }
            if (reader[10] != DBNull.Value)
            {
                PCT019C006 = (int?)reader[10];
            }
            if (reader[11] != DBNull.Value)
            {
                PCT019C007 = (int?)reader[11];
            }
            if (reader[12] != DBNull.Value)
            {
                PCT019C008 = (int?)reader[12];
            }
            if (reader[13] != DBNull.Value)
            {
                PCT019C009 = (int?)reader[13];
            }
            if (reader[14] != DBNull.Value)
            {
                PCT019C010 = (int?)reader[14];
            }
            if (reader[15] != DBNull.Value)
            {
                PCT019C011 = (int?)reader[15];
            }
            if (reader[16] != DBNull.Value)
            {
                PCT019D001 = (int?)reader[16];
            }
            if (reader[17] != DBNull.Value)
            {
                PCT019D002 = (int?)reader[17];
            }
            if (reader[18] != DBNull.Value)
            {
                PCT019D003 = (int?)reader[18];
            }
            if (reader[19] != DBNull.Value)
            {
                PCT019D004 = (int?)reader[19];
            }
            if (reader[20] != DBNull.Value)
            {
                PCT019D005 = (int?)reader[20];
            }
            if (reader[21] != DBNull.Value)
            {
                PCT019D006 = (int?)reader[21];
            }
            if (reader[22] != DBNull.Value)
            {
                PCT019D007 = (int?)reader[22];
            }
            if (reader[23] != DBNull.Value)
            {
                PCT019D008 = (int?)reader[23];
            }
            if (reader[24] != DBNull.Value)
            {
                PCT019D009 = (int?)reader[24];
            }
            if (reader[25] != DBNull.Value)
            {
                PCT019D010 = (int?)reader[25];
            }
            if (reader[26] != DBNull.Value)
            {
                PCT019D011 = (int?)reader[26];
            }
            if (reader[27] != DBNull.Value)
            {
                PCT019E001 = (int?)reader[27];
            }
            if (reader[28] != DBNull.Value)
            {
                PCT019E002 = (int?)reader[28];
            }
            if (reader[29] != DBNull.Value)
            {
                PCT019E003 = (int?)reader[29];
            }
            if (reader[30] != DBNull.Value)
            {
                PCT019E004 = (int?)reader[30];
            }
            if (reader[31] != DBNull.Value)
            {
                PCT019E005 = (int?)reader[31];
            }
            if (reader[32] != DBNull.Value)
            {
                PCT019E006 = (int?)reader[32];
            }
            if (reader[33] != DBNull.Value)
            {
                PCT019E007 = (int?)reader[33];
            }
            if (reader[34] != DBNull.Value)
            {
                PCT019E008 = (int?)reader[34];
            }
            if (reader[35] != DBNull.Value)
            {
                PCT019E009 = (int?)reader[35];
            }
            if (reader[36] != DBNull.Value)
            {
                PCT019E010 = (int?)reader[36];
            }
            if (reader[37] != DBNull.Value)
            {
                PCT019E011 = (int?)reader[37];
            }
            if (reader[38] != DBNull.Value)
            {
                PCT019F001 = (int?)reader[38];
            }
            if (reader[39] != DBNull.Value)
            {
                PCT019F002 = (int?)reader[39];
            }
            if (reader[40] != DBNull.Value)
            {
                PCT019F003 = (int?)reader[40];
            }
            if (reader[41] != DBNull.Value)
            {
                PCT019F004 = (int?)reader[41];
            }
            if (reader[42] != DBNull.Value)
            {
                PCT019F005 = (int?)reader[42];
            }
            if (reader[43] != DBNull.Value)
            {
                PCT019F006 = (int?)reader[43];
            }
            if (reader[44] != DBNull.Value)
            {
                PCT019F007 = (int?)reader[44];
            }
            if (reader[45] != DBNull.Value)
            {
                PCT019F008 = (int?)reader[45];
            }
            if (reader[46] != DBNull.Value)
            {
                PCT019F009 = (int?)reader[46];
            }
            if (reader[47] != DBNull.Value)
            {
                PCT019F010 = (int?)reader[47];
            }
            if (reader[48] != DBNull.Value)
            {
                PCT019F011 = (int?)reader[48];
            }
            if (reader[49] != DBNull.Value)
            {
                PCT019G001 = (int?)reader[49];
            }
            if (reader[50] != DBNull.Value)
            {
                PCT019G002 = (int?)reader[50];
            }
            if (reader[51] != DBNull.Value)
            {
                PCT019G003 = (int?)reader[51];
            }
            if (reader[52] != DBNull.Value)
            {
                PCT019G004 = (int?)reader[52];
            }
            if (reader[53] != DBNull.Value)
            {
                PCT019G005 = (int?)reader[53];
            }
            if (reader[54] != DBNull.Value)
            {
                PCT019G006 = (int?)reader[54];
            }
            if (reader[55] != DBNull.Value)
            {
                PCT019G007 = (int?)reader[55];
            }
            if (reader[56] != DBNull.Value)
            {
                PCT019G008 = (int?)reader[56];
            }
            if (reader[57] != DBNull.Value)
            {
                PCT019G009 = (int?)reader[57];
            }
            if (reader[58] != DBNull.Value)
            {
                PCT019G010 = (int?)reader[58];
            }
            if (reader[59] != DBNull.Value)
            {
                PCT019G011 = (int?)reader[59];
            }
            if (reader[60] != DBNull.Value)
            {
                PCT019H001 = (int?)reader[60];
            }
            if (reader[61] != DBNull.Value)
            {
                PCT019H002 = (int?)reader[61];
            }
            if (reader[62] != DBNull.Value)
            {
                PCT019H003 = (int?)reader[62];
            }
            if (reader[63] != DBNull.Value)
            {
                PCT019H004 = (int?)reader[63];
            }
            if (reader[64] != DBNull.Value)
            {
                PCT019H005 = (int?)reader[64];
            }
            if (reader[65] != DBNull.Value)
            {
                PCT019H006 = (int?)reader[65];
            }
            if (reader[66] != DBNull.Value)
            {
                PCT019H007 = (int?)reader[66];
            }
            if (reader[67] != DBNull.Value)
            {
                PCT019H008 = (int?)reader[67];
            }
            if (reader[68] != DBNull.Value)
            {
                PCT019H009 = (int?)reader[68];
            }
            if (reader[69] != DBNull.Value)
            {
                PCT019H010 = (int?)reader[69];
            }
            if (reader[70] != DBNull.Value)
            {
                PCT019H011 = (int?)reader[70];
            }
            if (reader[71] != DBNull.Value)
            {
                PCT019I001 = (int?)reader[71];
            }
            if (reader[72] != DBNull.Value)
            {
                PCT019I002 = (int?)reader[72];
            }
            if (reader[73] != DBNull.Value)
            {
                PCT019I003 = (int?)reader[73];
            }
            if (reader[74] != DBNull.Value)
            {
                PCT019I004 = (int?)reader[74];
            }
            if (reader[75] != DBNull.Value)
            {
                PCT019I005 = (int?)reader[75];
            }
            if (reader[76] != DBNull.Value)
            {
                PCT019I006 = (int?)reader[76];
            }
            if (reader[77] != DBNull.Value)
            {
                PCT019I007 = (int?)reader[77];
            }
            if (reader[78] != DBNull.Value)
            {
                PCT019I008 = (int?)reader[78];
            }
            if (reader[79] != DBNull.Value)
            {
                PCT019I009 = (int?)reader[79];
            }
            if (reader[80] != DBNull.Value)
            {
                PCT019I010 = (int?)reader[80];
            }
            if (reader[81] != DBNull.Value)
            {
                PCT019I011 = (int?)reader[81];
            }
            if (reader[82] != DBNull.Value)
            {
                PCT020A001 = (int?)reader[82];
            }
            if (reader[83] != DBNull.Value)
            {
                PCT020A002 = (int?)reader[83];
            }
            if (reader[84] != DBNull.Value)
            {
                PCT020A003 = (int?)reader[84];
            }
            if (reader[85] != DBNull.Value)
            {
                PCT020A004 = (int?)reader[85];
            }
            if (reader[86] != DBNull.Value)
            {
                PCT020A005 = (int?)reader[86];
            }
            if (reader[87] != DBNull.Value)
            {
                PCT020A006 = (int?)reader[87];
            }
            if (reader[88] != DBNull.Value)
            {
                PCT020A007 = (int?)reader[88];
            }
            if (reader[89] != DBNull.Value)
            {
                PCT020A008 = (int?)reader[89];
            }
            if (reader[90] != DBNull.Value)
            {
                PCT020A009 = (int?)reader[90];
            }
            if (reader[91] != DBNull.Value)
            {
                PCT020A010 = (int?)reader[91];
            }
            if (reader[92] != DBNull.Value)
            {
                PCT020A011 = (int?)reader[92];
            }
            if (reader[93] != DBNull.Value)
            {
                PCT020A012 = (int?)reader[93];
            }
            if (reader[94] != DBNull.Value)
            {
                PCT020A013 = (int?)reader[94];
            }
            if (reader[95] != DBNull.Value)
            {
                PCT020A014 = (int?)reader[95];
            }
            if (reader[96] != DBNull.Value)
            {
                PCT020A015 = (int?)reader[96];
            }
            if (reader[97] != DBNull.Value)
            {
                PCT020A016 = (int?)reader[97];
            }
            if (reader[98] != DBNull.Value)
            {
                PCT020A017 = (int?)reader[98];
            }
            if (reader[99] != DBNull.Value)
            {
                PCT020A018 = (int?)reader[99];
            }
            if (reader[100] != DBNull.Value)
            {
                PCT020A019 = (int?)reader[100];
            }
            if (reader[101] != DBNull.Value)
            {
                PCT020A020 = (int?)reader[101];
            }
            if (reader[102] != DBNull.Value)
            {
                PCT020A021 = (int?)reader[102];
            }
            if (reader[103] != DBNull.Value)
            {
                PCT020A022 = (int?)reader[103];
            }
            if (reader[104] != DBNull.Value)
            {
                PCT020A023 = (int?)reader[104];
            }
            if (reader[105] != DBNull.Value)
            {
                PCT020A024 = (int?)reader[105];
            }
            if (reader[106] != DBNull.Value)
            {
                PCT020A025 = (int?)reader[106];
            }
            if (reader[107] != DBNull.Value)
            {
                PCT020A026 = (int?)reader[107];
            }
            if (reader[108] != DBNull.Value)
            {
                PCT020A027 = (int?)reader[108];
            }
            if (reader[109] != DBNull.Value)
            {
                PCT020A028 = (int?)reader[109];
            }
            if (reader[110] != DBNull.Value)
            {
                PCT020A029 = (int?)reader[110];
            }
            if (reader[111] != DBNull.Value)
            {
                PCT020A030 = (int?)reader[111];
            }
            if (reader[112] != DBNull.Value)
            {
                PCT020A031 = (int?)reader[112];
            }
            if (reader[113] != DBNull.Value)
            {
                PCT020A032 = (int?)reader[113];
            }
            if (reader[114] != DBNull.Value)
            {
                PCT020B001 = (int?)reader[114];
            }
            if (reader[115] != DBNull.Value)
            {
                PCT020B002 = (int?)reader[115];
            }
            if (reader[116] != DBNull.Value)
            {
                PCT020B003 = (int?)reader[116];
            }
            if (reader[117] != DBNull.Value)
            {
                PCT020B004 = (int?)reader[117];
            }
            if (reader[118] != DBNull.Value)
            {
                PCT020B005 = (int?)reader[118];
            }
            if (reader[119] != DBNull.Value)
            {
                PCT020B006 = (int?)reader[119];
            }
            if (reader[120] != DBNull.Value)
            {
                PCT020B007 = (int?)reader[120];
            }
            if (reader[121] != DBNull.Value)
            {
                PCT020B008 = (int?)reader[121];
            }
            if (reader[122] != DBNull.Value)
            {
                PCT020B009 = (int?)reader[122];
            }
            if (reader[123] != DBNull.Value)
            {
                PCT020B010 = (int?)reader[123];
            }
            if (reader[124] != DBNull.Value)
            {
                PCT020B011 = (int?)reader[124];
            }
            if (reader[125] != DBNull.Value)
            {
                PCT020B012 = (int?)reader[125];
            }
            if (reader[126] != DBNull.Value)
            {
                PCT020B013 = (int?)reader[126];
            }
            if (reader[127] != DBNull.Value)
            {
                PCT020B014 = (int?)reader[127];
            }
            if (reader[128] != DBNull.Value)
            {
                PCT020B015 = (int?)reader[128];
            }
            if (reader[129] != DBNull.Value)
            {
                PCT020B016 = (int?)reader[129];
            }
            if (reader[130] != DBNull.Value)
            {
                PCT020B017 = (int?)reader[130];
            }
            if (reader[131] != DBNull.Value)
            {
                PCT020B018 = (int?)reader[131];
            }
            if (reader[132] != DBNull.Value)
            {
                PCT020B019 = (int?)reader[132];
            }
            if (reader[133] != DBNull.Value)
            {
                PCT020B020 = (int?)reader[133];
            }
            if (reader[134] != DBNull.Value)
            {
                PCT020B021 = (int?)reader[134];
            }
            if (reader[135] != DBNull.Value)
            {
                PCT020B022 = (int?)reader[135];
            }
            if (reader[136] != DBNull.Value)
            {
                PCT020B023 = (int?)reader[136];
            }
            if (reader[137] != DBNull.Value)
            {
                PCT020B024 = (int?)reader[137];
            }
            if (reader[138] != DBNull.Value)
            {
                PCT020B025 = (int?)reader[138];
            }
            if (reader[139] != DBNull.Value)
            {
                PCT020B026 = (int?)reader[139];
            }
            if (reader[140] != DBNull.Value)
            {
                PCT020B027 = (int?)reader[140];
            }
            if (reader[141] != DBNull.Value)
            {
                PCT020B028 = (int?)reader[141];
            }
            if (reader[142] != DBNull.Value)
            {
                PCT020B029 = (int?)reader[142];
            }
            if (reader[143] != DBNull.Value)
            {
                PCT020B030 = (int?)reader[143];
            }
            if (reader[144] != DBNull.Value)
            {
                PCT020B031 = (int?)reader[144];
            }
            if (reader[145] != DBNull.Value)
            {
                PCT020B032 = (int?)reader[145];
            }
            if (reader[146] != DBNull.Value)
            {
                PCT020C001 = (int?)reader[146];
            }
            if (reader[147] != DBNull.Value)
            {
                PCT020C002 = (int?)reader[147];
            }
            if (reader[148] != DBNull.Value)
            {
                PCT020C003 = (int?)reader[148];
            }
            if (reader[149] != DBNull.Value)
            {
                PCT020C004 = (int?)reader[149];
            }
            if (reader[150] != DBNull.Value)
            {
                PCT020C005 = (int?)reader[150];
            }
            if (reader[151] != DBNull.Value)
            {
                PCT020C006 = (int?)reader[151];
            }
            if (reader[152] != DBNull.Value)
            {
                PCT020C007 = (int?)reader[152];
            }
            if (reader[153] != DBNull.Value)
            {
                PCT020C008 = (int?)reader[153];
            }
            if (reader[154] != DBNull.Value)
            {
                PCT020C009 = (int?)reader[154];
            }
            if (reader[155] != DBNull.Value)
            {
                PCT020C010 = (int?)reader[155];
            }
            if (reader[156] != DBNull.Value)
            {
                PCT020C011 = (int?)reader[156];
            }
            if (reader[157] != DBNull.Value)
            {
                PCT020C012 = (int?)reader[157];
            }
            if (reader[158] != DBNull.Value)
            {
                PCT020C013 = (int?)reader[158];
            }
            if (reader[159] != DBNull.Value)
            {
                PCT020C014 = (int?)reader[159];
            }
            if (reader[160] != DBNull.Value)
            {
                PCT020C015 = (int?)reader[160];
            }
            if (reader[161] != DBNull.Value)
            {
                PCT020C016 = (int?)reader[161];
            }
            if (reader[162] != DBNull.Value)
            {
                PCT020C017 = (int?)reader[162];
            }
            if (reader[163] != DBNull.Value)
            {
                PCT020C018 = (int?)reader[163];
            }
            if (reader[164] != DBNull.Value)
            {
                PCT020C019 = (int?)reader[164];
            }
            if (reader[165] != DBNull.Value)
            {
                PCT020C020 = (int?)reader[165];
            }
            if (reader[166] != DBNull.Value)
            {
                PCT020C021 = (int?)reader[166];
            }
            if (reader[167] != DBNull.Value)
            {
                PCT020C022 = (int?)reader[167];
            }
            if (reader[168] != DBNull.Value)
            {
                PCT020C023 = (int?)reader[168];
            }
            if (reader[169] != DBNull.Value)
            {
                PCT020C024 = (int?)reader[169];
            }
            if (reader[170] != DBNull.Value)
            {
                PCT020C025 = (int?)reader[170];
            }
            if (reader[171] != DBNull.Value)
            {
                PCT020C026 = (int?)reader[171];
            }
            if (reader[172] != DBNull.Value)
            {
                PCT020C027 = (int?)reader[172];
            }
            if (reader[173] != DBNull.Value)
            {
                PCT020C028 = (int?)reader[173];
            }
            if (reader[174] != DBNull.Value)
            {
                PCT020C029 = (int?)reader[174];
            }
            if (reader[175] != DBNull.Value)
            {
                PCT020C030 = (int?)reader[175];
            }
            if (reader[176] != DBNull.Value)
            {
                PCT020C031 = (int?)reader[176];
            }
            if (reader[177] != DBNull.Value)
            {
                PCT020C032 = (int?)reader[177];
            }
            if (reader[178] != DBNull.Value)
            {
                PCT020D001 = (int?)reader[178];
            }
            if (reader[179] != DBNull.Value)
            {
                PCT020D002 = (int?)reader[179];
            }
            if (reader[180] != DBNull.Value)
            {
                PCT020D003 = (int?)reader[180];
            }
            if (reader[181] != DBNull.Value)
            {
                PCT020D004 = (int?)reader[181];
            }
            if (reader[182] != DBNull.Value)
            {
                PCT020D005 = (int?)reader[182];
            }
            if (reader[183] != DBNull.Value)
            {
                PCT020D006 = (int?)reader[183];
            }
            if (reader[184] != DBNull.Value)
            {
                PCT020D007 = (int?)reader[184];
            }
            if (reader[185] != DBNull.Value)
            {
                PCT020D008 = (int?)reader[185];
            }
            if (reader[186] != DBNull.Value)
            {
                PCT020D009 = (int?)reader[186];
            }
            if (reader[187] != DBNull.Value)
            {
                PCT020D010 = (int?)reader[187];
            }
            if (reader[188] != DBNull.Value)
            {
                PCT020D011 = (int?)reader[188];
            }
            if (reader[189] != DBNull.Value)
            {
                PCT020D012 = (int?)reader[189];
            }
            if (reader[190] != DBNull.Value)
            {
                PCT020D013 = (int?)reader[190];
            }
            if (reader[191] != DBNull.Value)
            {
                PCT020D014 = (int?)reader[191];
            }
            if (reader[192] != DBNull.Value)
            {
                PCT020D015 = (int?)reader[192];
            }
            if (reader[193] != DBNull.Value)
            {
                PCT020D016 = (int?)reader[193];
            }
            if (reader[194] != DBNull.Value)
            {
                PCT020D017 = (int?)reader[194];
            }
            if (reader[195] != DBNull.Value)
            {
                PCT020D018 = (int?)reader[195];
            }
            if (reader[196] != DBNull.Value)
            {
                PCT020D019 = (int?)reader[196];
            }
            if (reader[197] != DBNull.Value)
            {
                PCT020D020 = (int?)reader[197];
            }
            if (reader[198] != DBNull.Value)
            {
                PCT020D021 = (int?)reader[198];
            }
            if (reader[199] != DBNull.Value)
            {
                PCT020D022 = (int?)reader[199];
            }
            if (reader[200] != DBNull.Value)
            {
                PCT020D023 = (int?)reader[200];
            }
            if (reader[201] != DBNull.Value)
            {
                PCT020D024 = (int?)reader[201];
            }
            if (reader[202] != DBNull.Value)
            {
                PCT020D025 = (int?)reader[202];
            }
            if (reader[203] != DBNull.Value)
            {
                PCT020D026 = (int?)reader[203];
            }
            if (reader[204] != DBNull.Value)
            {
                PCT020D027 = (int?)reader[204];
            }
            if (reader[205] != DBNull.Value)
            {
                PCT020D028 = (int?)reader[205];
            }
            if (reader[206] != DBNull.Value)
            {
                PCT020D029 = (int?)reader[206];
            }
            if (reader[207] != DBNull.Value)
            {
                PCT020D030 = (int?)reader[207];
            }
            if (reader[208] != DBNull.Value)
            {
                PCT020D031 = (int?)reader[208];
            }
            if (reader[209] != DBNull.Value)
            {
                PCT020D032 = (int?)reader[209];
            }
            if (reader[210] != DBNull.Value)
            {
                PCT020E001 = (int?)reader[210];
            }
            if (reader[211] != DBNull.Value)
            {
                PCT020E002 = (int?)reader[211];
            }
            if (reader[212] != DBNull.Value)
            {
                PCT020E003 = (int?)reader[212];
            }
            if (reader[213] != DBNull.Value)
            {
                PCT020E004 = (int?)reader[213];
            }
            if (reader[214] != DBNull.Value)
            {
                PCT020E005 = (int?)reader[214];
            }
            if (reader[215] != DBNull.Value)
            {
                PCT020E006 = (int?)reader[215];
            }
            if (reader[216] != DBNull.Value)
            {
                PCT020E007 = (int?)reader[216];
            }
            if (reader[217] != DBNull.Value)
            {
                PCT020E008 = (int?)reader[217];
            }
            if (reader[218] != DBNull.Value)
            {
                PCT020E009 = (int?)reader[218];
            }
            if (reader[219] != DBNull.Value)
            {
                PCT020E010 = (int?)reader[219];
            }
            if (reader[220] != DBNull.Value)
            {
                PCT020E011 = (int?)reader[220];
            }
            if (reader[221] != DBNull.Value)
            {
                PCT020E012 = (int?)reader[221];
            }
            if (reader[222] != DBNull.Value)
            {
                PCT020E013 = (int?)reader[222];
            }
            if (reader[223] != DBNull.Value)
            {
                PCT020E014 = (int?)reader[223];
            }
            if (reader[224] != DBNull.Value)
            {
                PCT020E015 = (int?)reader[224];
            }
            if (reader[225] != DBNull.Value)
            {
                PCT020E016 = (int?)reader[225];
            }
            if (reader[226] != DBNull.Value)
            {
                PCT020E017 = (int?)reader[226];
            }
            if (reader[227] != DBNull.Value)
            {
                PCT020E018 = (int?)reader[227];
            }
            if (reader[228] != DBNull.Value)
            {
                PCT020E019 = (int?)reader[228];
            }
            if (reader[229] != DBNull.Value)
            {
                PCT020E020 = (int?)reader[229];
            }
            if (reader[230] != DBNull.Value)
            {
                PCT020E021 = (int?)reader[230];
            }
            if (reader[231] != DBNull.Value)
            {
                PCT020E022 = (int?)reader[231];
            }
            if (reader[232] != DBNull.Value)
            {
                PCT020E023 = (int?)reader[232];
            }
            if (reader[233] != DBNull.Value)
            {
                PCT020E024 = (int?)reader[233];
            }
            if (reader[234] != DBNull.Value)
            {
                PCT020E025 = (int?)reader[234];
            }
            if (reader[235] != DBNull.Value)
            {
                PCT020E026 = (int?)reader[235];
            }
            if (reader[236] != DBNull.Value)
            {
                PCT020E027 = (int?)reader[236];
            }
            if (reader[237] != DBNull.Value)
            {
                PCT020E028 = (int?)reader[237];
            }
            if (reader[238] != DBNull.Value)
            {
                PCT020E029 = (int?)reader[238];
            }
            if (reader[239] != DBNull.Value)
            {
                PCT020E030 = (int?)reader[239];
            }
            if (reader[240] != DBNull.Value)
            {
                PCT020E031 = (int?)reader[240];
            }
            if (reader[241] != DBNull.Value)
            {
                PCT020E032 = (int?)reader[241];
            }
        }
        #endregion Constructors
    }
}
