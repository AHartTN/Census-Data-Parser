#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 12/26/2015 5:32 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF2_Segment_05.cs
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

    public class SF2_Segment_05
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
        public int? PCT0190001 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 6)]
        public int? PCT0190002 { get; set; }

        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 7)]
        public int? PCT0190003 { get; set; }

        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 8)]
        public int? PCT0190004 { get; set; }

        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 9)]
        public int? PCT0190005 { get; set; }

        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 10)]
        public int? PCT0190006 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 11)]
        public int? PCT0190007 { get; set; }

        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 12)]
        public int? PCT0190008 { get; set; }

        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 13)]
        public int? PCT0190009 { get; set; }

        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 14)]
        public int? PCT0190010 { get; set; }

        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 15)]
        public int? PCT0190011 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 16)]
        public int? PCT0190012 { get; set; }

        [Display(Name = "Unmarried-partner households:", ShortName = "Unmarried-partner households:", Order = 17)]
        public int? PCT0190013 { get; set; }

        [Display(Name = "Male householder and male partner:", ShortName = "Male householder and male partner:", Order = 18)]
        public int? PCT0190014 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 19)]
        public int? PCT0190015 { get; set; }

        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 20)]
        public int? PCT0190016 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 21)]
        public int? PCT0190017 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 22)]
        public int? PCT0190018 { get; set; }

        [Display(Name = "Male householder and female partner:", ShortName = "Male householder and female partner:", Order = 23)]
        public int? PCT0190019 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 24)]
        public int? PCT0190020 { get; set; }

        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 25)]
        public int? PCT0190021 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 26)]
        public int? PCT0190022 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 27)]
        public int? PCT0190023 { get; set; }

        [Display(Name = "Female householder and female partner:", ShortName = "Female householder and female partner:", Order = 28)]
        public int? PCT0190024 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 29)]
        public int? PCT0190025 { get; set; }

        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 30)]
        public int? PCT0190026 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 31)]
        public int? PCT0190027 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 32)]
        public int? PCT0190028 { get; set; }

        [Display(Name = "Female householder and male partner:", ShortName = "Female householder and male partner:", Order = 33)]
        public int? PCT0190029 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 34)]
        public int? PCT0190030 { get; set; }

        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 35)]
        public int? PCT0190031 { get; set; }

        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 36)]
        public int? PCT0190032 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 37)]
        public int? PCT0190033 { get; set; }

        [Display(Name = "All other households", ShortName = "All other households", Order = 38)]
        public int? PCT0190034 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 39)]
        public int? PCT0200001 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 40)]
        public int? PCT0200002 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 41)]
        public int? PCT0200003 { get; set; }

        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 42)]
        public int? PCT0200004 { get; set; }

        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 43)]
        public int? PCT0200005 { get; set; }

        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 44)]
        public int? PCT0200006 { get; set; }

        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 45)]
        public int? PCT0200007 { get; set; }

        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 46)]
        public int? PCT0200008 { get; set; }

        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 47)]
        public int? PCT0200009 { get; set; }

        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 48)]
        public int? PCT0200010 { get; set; }

        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 49)]
        public int? PCT0200011 { get; set; }

        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 50)]
        public int? PCT0200012 { get; set; }

        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 51)]
        public int? PCT0200013 { get; set; }

        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 52)]
        public int? PCT0200014 { get; set; }

        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 53)]
        public int? PCT0200015 { get; set; }

        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 54)]
        public int? PCT0200016 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 55)]
        public int? PCT0210001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 56)]
        public int? PCT0210002 { get; set; }

        [Display(Name = "Under 18 years:", ShortName = "Under 18 years:", Order = 57)]
        public int? PCT0210003 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301,  401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301,  401-405):", Order = 58)]
        public int? PCT0210004 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 59)]
        public int? PCT0210005 { get; set; }

        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 60)]
        public int? PCT0210006 { get; set; }

        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 61)]
        public int? PCT0210007 { get; set; }

        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 62)]
        public int? PCT0210008 { get; set; }

        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 63)]
        public int? PCT0210009 { get; set; }

        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 64)]
        public int? PCT0210010 { get; set; }

        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 65)]
        public int? PCT0210011 { get; set; }

        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 66)]
        public int? PCT0210012 { get; set; }

        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 67)]
        public int? PCT0210013 { get; set; }

        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 68)]
        public int? PCT0210014 { get; set; }

        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 69)]
        public int? PCT0210015 { get; set; }

        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 70)]
        public int? PCT0210016 { get; set; }

        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 71)]
        public int? PCT0210017 { get; set; }

        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 72)]
        public int? PCT0210018 { get; set; }

        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 73)]
        public int? PCT0210019 { get; set; }

        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 74)]
        public int? PCT0210020 { get; set; }

        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 75)]
        public int? PCT0210021 { get; set; }

        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 76)]
        public int? PCT0210022 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 77)]
        public int? PCT0210023 { get; set; }

        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 78)]
        public int? PCT0210024 { get; set; }

        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 79)]
        public int? PCT0210025 { get; set; }

        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 80)]
        public int? PCT0210026 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 81)]
        public int? PCT0220001 { get; set; }

        [Display(Name = "Male:", ShortName = "Male:", Order = 82)]
        public int? PCT0220002 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 83)]
        public int? PCT0220003 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 84)]
        public int? PCT0220004 { get; set; }

        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 85)]
        public int? PCT0220005 { get; set; }

        [Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 86)]
        public int? PCT0220006 { get; set; }

        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 87)]
        public int? PCT0220007 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 88)]
        public int? PCT0220008 { get; set; }

        [Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 89)]
        public int? PCT0220009 { get; set; }

        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 90)]
        public int? PCT0220010 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 91)]
        public int? PCT0220011 { get; set; }

        [Display(Name = "Female:", ShortName = "Female:", Order = 92)]
        public int? PCT0220012 { get; set; }

        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 93)]
        public int? PCT0220013 { get; set; }

        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 94)]
        public int? PCT0220014 { get; set; }

        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 95)]
        public int? PCT0220015 { get; set; }

        [Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 96)]
        public int? PCT0220016 { get; set; }

        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 97)]
        public int? PCT0220017 { get; set; }

        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 98)]
        public int? PCT0220018 { get; set; }

        [Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 99)]
        public int? PCT0220019 { get; set; }

        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 100)]
        public int? PCT0220020 { get; set; }

        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 101)]
        public int? PCT0220021 { get; set; }

        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 102)]
        public int? PCT0220022 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 103)]
        public int? PCT0220023 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 104)]
        public int? PCT0220024 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 105)]
        public int? PCT0220025 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 106)]
        public int? PCT0220026 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 107)]
        public int? PCT0220027 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 108)]
        public int? PCT0220028 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 109)]
        public int? PCT0230001 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 110)]
        public int? PCT0230002 { get; set; }

        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 111)]
        public int? PCT0230003 { get; set; }

        [Display(Name = "In other family:", ShortName = "In other family:", Order = 112)]
        public int? PCT0230004 { get; set; }

        [Display(Name = "In male householder, no wife present family", ShortName = "In male householder, no wife present family", Order = 113)]
        public int? PCT0230005 { get; set; }

        [Display(Name = "In female householder, no husband present family", ShortName = "In female householder, no husband present family", Order = 114)]
        public int? PCT0230006 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 115)]
        public int? PCT0230007 { get; set; }

        [Display(Name = "In households with a male householder:", ShortName = "In households with a male householder:", Order = 116)]
        public int? PCT0230008 { get; set; }

        [Display(Name = "In 1-person household", ShortName = "In 1-person household", Order = 117)]
        public int? PCT0230009 { get; set; }

        [Display(Name = "In 2-or-more-person household", ShortName = "In 2-or-more-person household", Order = 118)]
        public int? PCT0230010 { get; set; }

        [Display(Name = "In households with a female householder:", ShortName = "In households with a female householder:", Order = 119)]
        public int? PCT0230011 { get; set; }

        [Display(Name = "In 1-person household", ShortName = "In 1-person household", Order = 120)]
        public int? PCT0230012 { get; set; }

        [Display(Name = "In 2-or-more-person household", ShortName = "In 2-or-more-person household", Order = 121)]
        public int? PCT0230013 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 122)]
        public int? PCT0240001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 123)]
        public int? PCT0240002 { get; set; }

        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 124)]
        public int? PCT0240003 { get; set; }

        [Display(Name = "Related child:", ShortName = "Related child:", Order = 125)]
        public int? PCT0240004 { get; set; }

        [Display(Name = "Own child:", ShortName = "Own child:", Order = 126)]
        public int? PCT0240005 { get; set; }

        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 127)]
        public int? PCT0240006 { get; set; }

        [Display(Name = "In other family:", ShortName = "In other family:", Order = 128)]
        public int? PCT0240007 { get; set; }

        [Display(Name = "In male householder, no wife present family", ShortName = "In male householder, no wife present family", Order = 129)]
        public int? PCT0240008 { get; set; }

        [Display(Name = "In female householder, no husband present family", ShortName = "In female householder, no husband present family", Order = 130)]
        public int? PCT0240009 { get; set; }

        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 131)]
        public int? PCT0240010 { get; set; }

        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 132)]
        public int? PCT0240011 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 133)]
        public int? PCT0240012 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 134)]
        public int? PCT0240013 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 135)]
        public int? PCT0240014 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 136)]
        public int? PCT0240015 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 137)]
        public int? PCT0240016 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 138)]
        public int? PCT0250001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 139)]
        public int? PCT0250002 { get; set; }

        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 140)]
        public int? PCT0250003 { get; set; }

        [Display(Name = "Related child:", ShortName = "Related child:", Order = 141)]
        public int? PCT0250004 { get; set; }

        [Display(Name = "Own child:", ShortName = "Own child:", Order = 142)]
        public int? PCT0250005 { get; set; }

        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 143)]
        public int? PCT0250006 { get; set; }

        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 144)]
        public int? PCT0250007 { get; set; }

        [Display(Name = "5 years", ShortName = "5 years", Order = 145)]
        public int? PCT0250008 { get; set; }

        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 146)]
        public int? PCT0250009 { get; set; }

        [Display(Name = "12 and 13 years", ShortName = "12 and 13 years", Order = 147)]
        public int? PCT0250010 { get; set; }

        [Display(Name = "14 years", ShortName = "14 years", Order = 148)]
        public int? PCT0250011 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 149)]
        public int? PCT0250012 { get; set; }

        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 150)]
        public int? PCT0250013 { get; set; }

        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 151)]
        public int? PCT0250014 { get; set; }

        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 152)]
        public int? PCT0250015 { get; set; }

        [Display(Name = "5 years", ShortName = "5 years", Order = 153)]
        public int? PCT0250016 { get; set; }

        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 154)]
        public int? PCT0250017 { get; set; }

        [Display(Name = "12 and 13 years", ShortName = "12 and 13 years", Order = 155)]
        public int? PCT0250018 { get; set; }

        [Display(Name = "14 years", ShortName = "14 years", Order = 156)]
        public int? PCT0250019 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 157)]
        public int? PCT0250020 { get; set; }

        [Display(Name = "Nonrelatives:", ShortName = "Nonrelatives:", Order = 158)]
        public int? PCT0250021 { get; set; }

        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 159)]
        public int? PCT0250022 { get; set; }

        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 160)]
        public int? PCT0250023 { get; set; }

        [Display(Name = "5 years", ShortName = "5 years", Order = 161)]
        public int? PCT0250024 { get; set; }

        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 162)]
        public int? PCT0250025 { get; set; }

        [Display(Name = "12 and 13 years", ShortName = "12 and 13 years", Order = 163)]
        public int? PCT0250026 { get; set; }

        [Display(Name = "14 years", ShortName = "14 years", Order = 164)]
        public int? PCT0250027 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 165)]
        public int? PCT0250028 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 166)]
        public int? PCT0250029 { get; set; }

        [Display(Name = "Institutionalized population:", ShortName = "Institutionalized population:", Order = 167)]
        public int? PCT0250030 { get; set; }

        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 168)]
        public int? PCT0250031 { get; set; }

        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 169)]
        public int? PCT0250032 { get; set; }

        [Display(Name = "5 years", ShortName = "5 years", Order = 170)]
        public int? PCT0250033 { get; set; }

        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 171)]
        public int? PCT0250034 { get; set; }

        [Display(Name = "12 and 13 years", ShortName = "12 and 13 years", Order = 172)]
        public int? PCT0250035 { get; set; }

        [Display(Name = "14 years", ShortName = "14 years", Order = 173)]
        public int? PCT0250036 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 174)]
        public int? PCT0250037 { get; set; }

        [Display(Name = "Noninstitutionalized population:", ShortName = "Noninstitutionalized population:", Order = 175)]
        public int? PCT0250038 { get; set; }

        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 176)]
        public int? PCT0250039 { get; set; }

        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 177)]
        public int? PCT0250040 { get; set; }

        [Display(Name = "5 years", ShortName = "5 years", Order = 178)]
        public int? PCT0250041 { get; set; }

        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 179)]
        public int? PCT0250042 { get; set; }

        [Display(Name = "12 and 13 years", ShortName = "12 and 13 years", Order = 180)]
        public int? PCT0250043 { get; set; }

        [Display(Name = "14 years", ShortName = "14 years", Order = 181)]
        public int? PCT0250044 { get; set; }

        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 182)]
        public int? PCT0250045 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 183)]
        public int? PCT0260001 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 184)]
        public int? PCT0260002 { get; set; }

        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 185)]
        public int? PCT0260003 { get; set; }

        [Display(Name = "In other family:", ShortName = "In other family:", Order = 186)]
        public int? PCT0260004 { get; set; }

        [Display(Name = "In male householder, no wife present family", ShortName = "In male householder, no wife present family", Order = 187)]
        public int? PCT0260005 { get; set; }

        [Display(Name = "In female householder, no husband present family", ShortName = "In female householder, no husband present family", Order = 188)]
        public int? PCT0260006 { get; set; }

        [Display(Name = "In nonfamily households", ShortName = "In nonfamily households", Order = 189)]
        public int? PCT0260007 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 190)]
        public int? PCT0270001 { get; set; }

        [Display(Name = "Unmarried partner of householder present:", ShortName = "Unmarried partner of householder present:", Order = 191)]
        public int? PCT0270002 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 192)]
        public int? PCT0270003 { get; set; }

        [Display(Name = "In male householder and male partner households", ShortName = "In male householder and male partner households", Order = 193)]
        public int? PCT0270004 { get; set; }

        [Display(Name = "In male householder and female partner households", ShortName = "In male householder and female partner households", Order = 194)]
        public int? PCT0270005 { get; set; }

        [Display(Name = "In female householder and female partner households", ShortName = "In female householder and female partner households", Order = 195)]
        public int? PCT0270006 { get; set; }

        [Display(Name = "In female householder and male partner households", ShortName = "In female householder and male partner households", Order = 196)]
        public int? PCT0270007 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 197)]
        public int? PCT0270008 { get; set; }

        [Display(Name = "In male householder and male partner households", ShortName = "In male householder and male partner households", Order = 198)]
        public int? PCT0270009 { get; set; }

        [Display(Name = "In male householder and female partner households", ShortName = "In male householder and female partner households", Order = 199)]
        public int? PCT0270010 { get; set; }

        [Display(Name = "In female householder and female partner households", ShortName = "In female householder and female partner households", Order = 200)]
        public int? PCT0270011 { get; set; }

        [Display(Name = "In female householder and male partner households", ShortName = "In female householder and male partner households", Order = 201)]
        public int? PCT0270012 { get; set; }

        [Display(Name = "No unmarried partner of householder present:", ShortName = "No unmarried partner of householder present:", Order = 202)]
        public int? PCT0270013 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 203)]
        public int? PCT0270014 { get; set; }

        [Display(Name = "In husband-wife family households", ShortName = "In husband-wife family households", Order = 204)]
        public int? PCT0270015 { get; set; }

        [Display(Name = "In male householder, no wife present, family households", ShortName = "In male householder, no wife present, family households", Order = 205)]
        public int? PCT0270016 { get; set; }

        [Display(Name = "In female householder, no husband present, family households", ShortName = "In female householder, no husband present, family households", Order = 206)]
        public int? PCT0270017 { get; set; }

        [Display(Name = "In nonfamily households", ShortName = "In nonfamily households", Order = 207)]
        public int? PCT0270018 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 208)]
        public int? PCT0280001 { get; set; }

        [Display(Name = "In households:", ShortName = "In households:", Order = 209)]
        public int? PCT0280002 { get; set; }

        [Display(Name = "In family households:", ShortName = "In family households:", Order = 210)]
        public int? PCT0280003 { get; set; }

        [Display(Name = "Householder:", ShortName = "Householder:", Order = 211)]
        public int? PCT0280004 { get; set; }

        [Display(Name = "Male", ShortName = "Male", Order = 212)]
        public int? PCT0280005 { get; set; }

        [Display(Name = "Female", ShortName = "Female", Order = 213)]
        public int? PCT0280006 { get; set; }

        [Display(Name = "Spouse", ShortName = "Spouse", Order = 214)]
        public int? PCT0280007 { get; set; }

        [Display(Name = "Child", ShortName = "Child", Order = 215)]
        public int? PCT0280008 { get; set; }

        [Display(Name = "Parent", ShortName = "Parent", Order = 216)]
        public int? PCT0280009 { get; set; }

        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 217)]
        public int? PCT0280010 { get; set; }

        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 218)]
        public int? PCT0280011 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 219)]
        public int? PCT0280012 { get; set; }

        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 220)]
        public int? PCT0280013 { get; set; }

        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 221)]
        public int? PCT0280014 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 222)]
        public int? PCT0280015 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 223)]
        public int? PCT0280016 { get; set; }

        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 224)]
        public int? PCT0280017 { get; set; }

        [Display(Name = "Living alone", ShortName = "Living alone", Order = 225)]
        public int? PCT0280018 { get; set; }

        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 226)]
        public int? PCT0280019 { get; set; }

        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 227)]
        public int? PCT0280020 { get; set; }

        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 228)]
        public int? PCT0280021 { get; set; }

        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 229)]
        public int? PCT0280022 { get; set; }

        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 230)]
        public int? PCT0280023 { get; set; }

        [Display(Name = "Total", ShortName = "Total", Order = 231)]
        public int? PCT0290001 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 232)]
        public int? PCT0300001 { get; set; }

        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 233)]
        public int? PCT0300002 { get; set; }

        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 234)]
        public int? PCT0300003 { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 235)]
        public double? PCT0310001 { get; set; }

        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 236)]
        public double? PCT0310002 { get; set; }

        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 237)]
        public double? PCT0310003 { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}
