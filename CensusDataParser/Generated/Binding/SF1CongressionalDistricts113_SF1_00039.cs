#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/06/2016 2:17 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SF1CongressionalDistricts113_SF1_00039.cs
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

	public class SF1CongressionalDistricts113_SF1_00039 : BaseModel
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
		public int? PCT022G001 { get; set; }

		[Display(Name = "Male:", ShortName = "Male:", Order = 6)]
		public int? PCT022G002 { get; set; }

		[Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 7)]
		public int? PCT022G003 { get; set; }

		[Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 8)]
		public int? PCT022G004 { get; set; }

		[Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 9)]
		public int? PCT022G005 { get; set; }

		[Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 10)]
		public int? PCT022G006 { get; set; }

		[Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 11)]
		public int? PCT022G007 { get; set; }

		[Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 12)]
		public int? PCT022G008 { get; set; }

		[Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 13)]
		public int? PCT022G009 { get; set; }

		[Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 14)]
		public int? PCT022G010 { get; set; }

		[Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 15)]
		public int? PCT022G011 { get; set; }

		[Display(Name = "Female:", ShortName = "Female:", Order = 16)]
		public int? PCT022G012 { get; set; }

		[Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 17)]
		public int? PCT022G013 { get; set; }

		[Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 18)]
		public int? PCT022G014 { get; set; }

		[Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 19)]
		public int? PCT022G015 { get; set; }

		[Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 20)]
		public int? PCT022G016 { get; set; }

		[Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 21)]
		public int? PCT022G017 { get; set; }

		[Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 22)]
		public int? PCT022G018 { get; set; }

		[Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 23)]
		public int? PCT022G019 { get; set; }

		[Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 24)]
		public int? PCT022G020 { get; set; }

		[Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 25)]
		public int? PCT022G021 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 26)]
		public int? PCT022H001 { get; set; }

		[Display(Name = "Male:", ShortName = "Male:", Order = 27)]
		public int? PCT022H002 { get; set; }

		[Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 28)]
		public int? PCT022H003 { get; set; }

		[Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 29)]
		public int? PCT022H004 { get; set; }

		[Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 30)]
		public int? PCT022H005 { get; set; }

		[Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 31)]
		public int? PCT022H006 { get; set; }

		[Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 32)]
		public int? PCT022H007 { get; set; }

		[Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 33)]
		public int? PCT022H008 { get; set; }

		[Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 34)]
		public int? PCT022H009 { get; set; }

		[Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 35)]
		public int? PCT022H010 { get; set; }

		[Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 36)]
		public int? PCT022H011 { get; set; }

		[Display(Name = "Female:", ShortName = "Female:", Order = 37)]
		public int? PCT022H012 { get; set; }

		[Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 38)]
		public int? PCT022H013 { get; set; }

		[Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 39)]
		public int? PCT022H014 { get; set; }

		[Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 40)]
		public int? PCT022H015 { get; set; }

		[Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 41)]
		public int? PCT022H016 { get; set; }

		[Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 42)]
		public int? PCT022H017 { get; set; }

		[Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 43)]
		public int? PCT022H018 { get; set; }

		[Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 44)]
		public int? PCT022H019 { get; set; }

		[Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 45)]
		public int? PCT022H020 { get; set; }

		[Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 46)]
		public int? PCT022H021 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 47)]
		public int? PCT022I001 { get; set; }

		[Display(Name = "Male:", ShortName = "Male:", Order = 48)]
		public int? PCT022I002 { get; set; }

		[Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 49)]
		public int? PCT022I003 { get; set; }

		[Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 50)]
		public int? PCT022I004 { get; set; }

		[Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 51)]
		public int? PCT022I005 { get; set; }

		[Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 52)]
		public int? PCT022I006 { get; set; }

		[Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 53)]
		public int? PCT022I007 { get; set; }

		[Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 54)]
		public int? PCT022I008 { get; set; }

		[Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 55)]
		public int? PCT022I009 { get; set; }

		[Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 56)]
		public int? PCT022I010 { get; set; }

		[Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 57)]
		public int? PCT022I011 { get; set; }

		[Display(Name = "Female:", ShortName = "Female:", Order = 58)]
		public int? PCT022I012 { get; set; }

		[Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 59)]
		public int? PCT022I013 { get; set; }

		[Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 60)]
		public int? PCT022I014 { get; set; }

		[Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 61)]
		public int? PCT022I015 { get; set; }

		[Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 62)]
		public int? PCT022I016 { get; set; }

		[Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 63)]
		public int? PCT022I017 { get; set; }

		[Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 64)]
		public int? PCT022I018 { get; set; }

		[Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 65)]
		public int? PCT022I019 { get; set; }

		[Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 66)]
		public int? PCT022I020 { get; set; }

		[Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 67)]
		public int? PCT022I021 { get; set; }
		#endregion Properties

		#region Constructors
		public SF1CongressionalDistricts113_SF1_00039(string csvLine) : base(csvLine) { }

		public SF1CongressionalDistricts113_SF1_00039(string[] values) : base(values) { }

		public SF1CongressionalDistricts113_SF1_00039(OleDbDataReader reader)
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
				PCT022G001 = (int?)reader[5];
			}
			if (reader[6] != DBNull.Value)
			{
				PCT022G002 = (int?)reader[6];
			}
			if (reader[7] != DBNull.Value)
			{
				PCT022G003 = (int?)reader[7];
			}
			if (reader[8] != DBNull.Value)
			{
				PCT022G004 = (int?)reader[8];
			}
			if (reader[9] != DBNull.Value)
			{
				PCT022G005 = (int?)reader[9];
			}
			if (reader[10] != DBNull.Value)
			{
				PCT022G006 = (int?)reader[10];
			}
			if (reader[11] != DBNull.Value)
			{
				PCT022G007 = (int?)reader[11];
			}
			if (reader[12] != DBNull.Value)
			{
				PCT022G008 = (int?)reader[12];
			}
			if (reader[13] != DBNull.Value)
			{
				PCT022G009 = (int?)reader[13];
			}
			if (reader[14] != DBNull.Value)
			{
				PCT022G010 = (int?)reader[14];
			}
			if (reader[15] != DBNull.Value)
			{
				PCT022G011 = (int?)reader[15];
			}
			if (reader[16] != DBNull.Value)
			{
				PCT022G012 = (int?)reader[16];
			}
			if (reader[17] != DBNull.Value)
			{
				PCT022G013 = (int?)reader[17];
			}
			if (reader[18] != DBNull.Value)
			{
				PCT022G014 = (int?)reader[18];
			}
			if (reader[19] != DBNull.Value)
			{
				PCT022G015 = (int?)reader[19];
			}
			if (reader[20] != DBNull.Value)
			{
				PCT022G016 = (int?)reader[20];
			}
			if (reader[21] != DBNull.Value)
			{
				PCT022G017 = (int?)reader[21];
			}
			if (reader[22] != DBNull.Value)
			{
				PCT022G018 = (int?)reader[22];
			}
			if (reader[23] != DBNull.Value)
			{
				PCT022G019 = (int?)reader[23];
			}
			if (reader[24] != DBNull.Value)
			{
				PCT022G020 = (int?)reader[24];
			}
			if (reader[25] != DBNull.Value)
			{
				PCT022G021 = (int?)reader[25];
			}
			if (reader[26] != DBNull.Value)
			{
				PCT022H001 = (int?)reader[26];
			}
			if (reader[27] != DBNull.Value)
			{
				PCT022H002 = (int?)reader[27];
			}
			if (reader[28] != DBNull.Value)
			{
				PCT022H003 = (int?)reader[28];
			}
			if (reader[29] != DBNull.Value)
			{
				PCT022H004 = (int?)reader[29];
			}
			if (reader[30] != DBNull.Value)
			{
				PCT022H005 = (int?)reader[30];
			}
			if (reader[31] != DBNull.Value)
			{
				PCT022H006 = (int?)reader[31];
			}
			if (reader[32] != DBNull.Value)
			{
				PCT022H007 = (int?)reader[32];
			}
			if (reader[33] != DBNull.Value)
			{
				PCT022H008 = (int?)reader[33];
			}
			if (reader[34] != DBNull.Value)
			{
				PCT022H009 = (int?)reader[34];
			}
			if (reader[35] != DBNull.Value)
			{
				PCT022H010 = (int?)reader[35];
			}
			if (reader[36] != DBNull.Value)
			{
				PCT022H011 = (int?)reader[36];
			}
			if (reader[37] != DBNull.Value)
			{
				PCT022H012 = (int?)reader[37];
			}
			if (reader[38] != DBNull.Value)
			{
				PCT022H013 = (int?)reader[38];
			}
			if (reader[39] != DBNull.Value)
			{
				PCT022H014 = (int?)reader[39];
			}
			if (reader[40] != DBNull.Value)
			{
				PCT022H015 = (int?)reader[40];
			}
			if (reader[41] != DBNull.Value)
			{
				PCT022H016 = (int?)reader[41];
			}
			if (reader[42] != DBNull.Value)
			{
				PCT022H017 = (int?)reader[42];
			}
			if (reader[43] != DBNull.Value)
			{
				PCT022H018 = (int?)reader[43];
			}
			if (reader[44] != DBNull.Value)
			{
				PCT022H019 = (int?)reader[44];
			}
			if (reader[45] != DBNull.Value)
			{
				PCT022H020 = (int?)reader[45];
			}
			if (reader[46] != DBNull.Value)
			{
				PCT022H021 = (int?)reader[46];
			}
			if (reader[47] != DBNull.Value)
			{
				PCT022I001 = (int?)reader[47];
			}
			if (reader[48] != DBNull.Value)
			{
				PCT022I002 = (int?)reader[48];
			}
			if (reader[49] != DBNull.Value)
			{
				PCT022I003 = (int?)reader[49];
			}
			if (reader[50] != DBNull.Value)
			{
				PCT022I004 = (int?)reader[50];
			}
			if (reader[51] != DBNull.Value)
			{
				PCT022I005 = (int?)reader[51];
			}
			if (reader[52] != DBNull.Value)
			{
				PCT022I006 = (int?)reader[52];
			}
			if (reader[53] != DBNull.Value)
			{
				PCT022I007 = (int?)reader[53];
			}
			if (reader[54] != DBNull.Value)
			{
				PCT022I008 = (int?)reader[54];
			}
			if (reader[55] != DBNull.Value)
			{
				PCT022I009 = (int?)reader[55];
			}
			if (reader[56] != DBNull.Value)
			{
				PCT022I010 = (int?)reader[56];
			}
			if (reader[57] != DBNull.Value)
			{
				PCT022I011 = (int?)reader[57];
			}
			if (reader[58] != DBNull.Value)
			{
				PCT022I012 = (int?)reader[58];
			}
			if (reader[59] != DBNull.Value)
			{
				PCT022I013 = (int?)reader[59];
			}
			if (reader[60] != DBNull.Value)
			{
				PCT022I014 = (int?)reader[60];
			}
			if (reader[61] != DBNull.Value)
			{
				PCT022I015 = (int?)reader[61];
			}
			if (reader[62] != DBNull.Value)
			{
				PCT022I016 = (int?)reader[62];
			}
			if (reader[63] != DBNull.Value)
			{
				PCT022I017 = (int?)reader[63];
			}
			if (reader[64] != DBNull.Value)
			{
				PCT022I018 = (int?)reader[64];
			}
			if (reader[65] != DBNull.Value)
			{
				PCT022I019 = (int?)reader[65];
			}
			if (reader[66] != DBNull.Value)
			{
				PCT022I020 = (int?)reader[66];
			}
			if (reader[67] != DBNull.Value)
			{
				PCT022I021 = (int?)reader[67];
			}
		}
		#endregion Constructors
	}
}
