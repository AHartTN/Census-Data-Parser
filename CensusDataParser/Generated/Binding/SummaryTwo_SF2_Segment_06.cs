namespace CensusDataParser.Generated.Binding
{
	#region Using Directives
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity;
	using System.Data.Entity.ModelConfiguration;
	using System.Data.OleDb;
	using Enumerators;
	using Generated.Binding;
	using Generated.Mapping;
	#endregion Using Directives

	public class SummaryTwo_SF2_Segment_06 : BaseModel
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
		#endregion Properties

		#region Constructors
		public SummaryTwo_SF2_Segment_06() { }

		public SummaryTwo_SF2_Segment_06(string csvLine) : base(csvLine) { }

		public SummaryTwo_SF2_Segment_06(string[] values) : base(values) { }

		public SummaryTwo_SF2_Segment_06(OleDbDataReader reader)
		{
			if(reader[0] != DBNull.Value)
			{
				FILEID = (string)reader[0];
			}
			if(reader[1] != DBNull.Value)
			{
				STUSAB = (string)reader[1];
			}
			if(reader[2] != DBNull.Value)
			{
				CHARITER = (string)reader[2];
			}
			if(reader[3] != DBNull.Value)
			{
				CIFSN = (string)reader[3];
			}
			if(reader[4] != DBNull.Value)
			{
				LOGRECNO = (int)reader[4];
			}
			if(reader[5] != DBNull.Value)
			{
				PCT0320001 = (int?)reader[5];
			}
			if(reader[6] != DBNull.Value)
			{
				PCT0320002 = (int?)reader[6];
			}
			if(reader[7] != DBNull.Value)
			{
				PCT0320003 = (int?)reader[7];
			}
			if(reader[8] != DBNull.Value)
			{
				PCT0320004 = (int?)reader[8];
			}
			if(reader[9] != DBNull.Value)
			{
				PCT0320005 = (int?)reader[9];
			}
			if(reader[10] != DBNull.Value)
			{
				PCT0320006 = (int?)reader[10];
			}
			if(reader[11] != DBNull.Value)
			{
				PCT0320007 = (int?)reader[11];
			}
			if(reader[12] != DBNull.Value)
			{
				PCT0320008 = (int?)reader[12];
			}
			if(reader[13] != DBNull.Value)
			{
				PCT0320009 = (int?)reader[13];
			}
			if(reader[14] != DBNull.Value)
			{
				PCT0320010 = (int?)reader[14];
			}
			if(reader[15] != DBNull.Value)
			{
				PCT0320011 = (int?)reader[15];
			}
			if(reader[16] != DBNull.Value)
			{
				PCT0320012 = (int?)reader[16];
			}
			if(reader[17] != DBNull.Value)
			{
				PCT0320013 = (int?)reader[17];
			}
			if(reader[18] != DBNull.Value)
			{
				PCT0320014 = (int?)reader[18];
			}
			if(reader[19] != DBNull.Value)
			{
				PCT0320015 = (int?)reader[19];
			}
			if(reader[20] != DBNull.Value)
			{
				PCT0320016 = (int?)reader[20];
			}
			if(reader[21] != DBNull.Value)
			{
				PCT0320017 = (int?)reader[21];
			}
			if(reader[22] != DBNull.Value)
			{
				PCT0320018 = (int?)reader[22];
			}
			if(reader[23] != DBNull.Value)
			{
				PCT0320019 = (int?)reader[23];
			}
			if(reader[24] != DBNull.Value)
			{
				PCT0320020 = (int?)reader[24];
			}
			if(reader[25] != DBNull.Value)
			{
				PCT0330001 = (int?)reader[25];
			}
			if(reader[26] != DBNull.Value)
			{
				PCT0330002 = (int?)reader[26];
			}
			if(reader[27] != DBNull.Value)
			{
				PCT0330003 = (int?)reader[27];
			}
			if(reader[28] != DBNull.Value)
			{
				PCT0330004 = (int?)reader[28];
			}
			if(reader[29] != DBNull.Value)
			{
				PCT0330005 = (int?)reader[29];
			}
			if(reader[30] != DBNull.Value)
			{
				PCT0330006 = (int?)reader[30];
			}
			if(reader[31] != DBNull.Value)
			{
				PCT0330007 = (int?)reader[31];
			}
			if(reader[32] != DBNull.Value)
			{
				PCT0330008 = (int?)reader[32];
			}
			if(reader[33] != DBNull.Value)
			{
				PCT0330009 = (int?)reader[33];
			}
			if(reader[34] != DBNull.Value)
			{
				PCT0330010 = (int?)reader[34];
			}
			if(reader[35] != DBNull.Value)
			{
				PCT0330011 = (int?)reader[35];
			}
			if(reader[36] != DBNull.Value)
			{
				PCT0330012 = (int?)reader[36];
			}
			if(reader[37] != DBNull.Value)
			{
				PCT0330013 = (int?)reader[37];
			}
			if(reader[38] != DBNull.Value)
			{
				PCT0330014 = (int?)reader[38];
			}
			if(reader[39] != DBNull.Value)
			{
				PCT0330015 = (int?)reader[39];
			}
			if(reader[40] != DBNull.Value)
			{
				PCT0330016 = (int?)reader[40];
			}
			if(reader[41] != DBNull.Value)
			{
				PCT0330017 = (int?)reader[41];
			}
			if(reader[42] != DBNull.Value)
			{
				PCT0330018 = (int?)reader[42];
			}
			if(reader[43] != DBNull.Value)
			{
				PCT0330019 = (int?)reader[43];
			}
			if(reader[44] != DBNull.Value)
			{
				PCT0330020 = (int?)reader[44];
			}
			if(reader[45] != DBNull.Value)
			{
				PCT0340001 = (int?)reader[45];
			}
			if(reader[46] != DBNull.Value)
			{
				PCT0340002 = (int?)reader[46];
			}
			if(reader[47] != DBNull.Value)
			{
				PCT0340003 = (int?)reader[47];
			}
			if(reader[48] != DBNull.Value)
			{
				PCT0340004 = (int?)reader[48];
			}
			if(reader[49] != DBNull.Value)
			{
				PCT0340005 = (int?)reader[49];
			}
			if(reader[50] != DBNull.Value)
			{
				PCT0340006 = (int?)reader[50];
			}
			if(reader[51] != DBNull.Value)
			{
				PCT0340007 = (int?)reader[51];
			}
			if(reader[52] != DBNull.Value)
			{
				PCT0340008 = (int?)reader[52];
			}
			if(reader[53] != DBNull.Value)
			{
				PCT0340009 = (int?)reader[53];
			}
			if(reader[54] != DBNull.Value)
			{
				PCT0340010 = (int?)reader[54];
			}
			if(reader[55] != DBNull.Value)
			{
				PCT0340011 = (int?)reader[55];
			}
			if(reader[56] != DBNull.Value)
			{
				PCT0340012 = (int?)reader[56];
			}
			if(reader[57] != DBNull.Value)
			{
				PCT0340013 = (int?)reader[57];
			}
			if(reader[58] != DBNull.Value)
			{
				PCT0340014 = (int?)reader[58];
			}
			if(reader[59] != DBNull.Value)
			{
				PCT0340015 = (int?)reader[59];
			}
			if(reader[60] != DBNull.Value)
			{
				PCT0340016 = (int?)reader[60];
			}
			if(reader[61] != DBNull.Value)
			{
				PCT0340017 = (int?)reader[61];
			}
			if(reader[62] != DBNull.Value)
			{
				PCT0340018 = (int?)reader[62];
			}
			if(reader[63] != DBNull.Value)
			{
				PCT0340019 = (int?)reader[63];
			}
			if(reader[64] != DBNull.Value)
			{
				PCT0340020 = (int?)reader[64];
			}
			if(reader[65] != DBNull.Value)
			{
				PCT0350001 = (int?)reader[65];
			}
			if(reader[66] != DBNull.Value)
			{
				PCT0350002 = (int?)reader[66];
			}
			if(reader[67] != DBNull.Value)
			{
				PCT0350003 = (int?)reader[67];
			}
			if(reader[68] != DBNull.Value)
			{
				PCT0350004 = (int?)reader[68];
			}
			if(reader[69] != DBNull.Value)
			{
				PCT0350005 = (int?)reader[69];
			}
			if(reader[70] != DBNull.Value)
			{
				PCT0350006 = (int?)reader[70];
			}
			if(reader[71] != DBNull.Value)
			{
				PCT0360001 = (int?)reader[71];
			}
			if(reader[72] != DBNull.Value)
			{
				PCT0360002 = (int?)reader[72];
			}
			if(reader[73] != DBNull.Value)
			{
				PCT0360003 = (int?)reader[73];
			}
			if(reader[74] != DBNull.Value)
			{
				PCT0360004 = (int?)reader[74];
			}
			if(reader[75] != DBNull.Value)
			{
				PCT0360005 = (int?)reader[75];
			}
			if(reader[76] != DBNull.Value)
			{
				PCT0360006 = (int?)reader[76];
			}
			if(reader[77] != DBNull.Value)
			{
				PCT0360007 = (int?)reader[77];
			}
			if(reader[78] != DBNull.Value)
			{
				PCT0360008 = (int?)reader[78];
			}
			if(reader[79] != DBNull.Value)
			{
				PCT0360009 = (int?)reader[79];
			}
			if(reader[80] != DBNull.Value)
			{
				PCT0360010 = (int?)reader[80];
			}
			if(reader[81] != DBNull.Value)
			{
				PCT0360011 = (int?)reader[81];
			}
			if(reader[82] != DBNull.Value)
			{
				PCT0360012 = (int?)reader[82];
			}
			if(reader[83] != DBNull.Value)
			{
				PCT0360013 = (int?)reader[83];
			}
			if(reader[84] != DBNull.Value)
			{
				PCT0360014 = (int?)reader[84];
			}
			if(reader[85] != DBNull.Value)
			{
				PCT0360015 = (int?)reader[85];
			}
			if(reader[86] != DBNull.Value)
			{
				PCT0370001 = (int?)reader[86];
			}
			if(reader[87] != DBNull.Value)
			{
				PCT0370002 = (int?)reader[87];
			}
			if(reader[88] != DBNull.Value)
			{
				PCT0370003 = (int?)reader[88];
			}
			if(reader[89] != DBNull.Value)
			{
				PCT0370004 = (int?)reader[89];
			}
			if(reader[90] != DBNull.Value)
			{
				PCT0370005 = (int?)reader[90];
			}
			if(reader[91] != DBNull.Value)
			{
				PCT0370006 = (int?)reader[91];
			}
			if(reader[92] != DBNull.Value)
			{
				PCT0370007 = (int?)reader[92];
			}
			if(reader[93] != DBNull.Value)
			{
				PCT0370008 = (int?)reader[93];
			}
			if(reader[94] != DBNull.Value)
			{
				PCT0370009 = (int?)reader[94];
			}
			if(reader[95] != DBNull.Value)
			{
				PCT0370010 = (int?)reader[95];
			}
			if(reader[96] != DBNull.Value)
			{
				PCT0370011 = (int?)reader[96];
			}
			if(reader[97] != DBNull.Value)
			{
				PCT038_0001 = (int?)reader[97];
			}
			if(reader[98] != DBNull.Value)
			{
				PCT038_0002 = (int?)reader[98];
			}
			if(reader[99] != DBNull.Value)
			{
				PCT038_0003 = (int?)reader[99];
			}
			if(reader[100] != DBNull.Value)
			{
				PCT038_0004 = (int?)reader[100];
			}
			if(reader[101] != DBNull.Value)
			{
				PCT038_0005 = (int?)reader[101];
			}
			if(reader[102] != DBNull.Value)
			{
				PCT038_0006 = (int?)reader[102];
			}
			if(reader[103] != DBNull.Value)
			{
				PCT038_0007 = (int?)reader[103];
			}
			if(reader[104] != DBNull.Value)
			{
				PCT038_0008 = (int?)reader[104];
			}
			if(reader[105] != DBNull.Value)
			{
				PCT038_0009 = (int?)reader[105];
			}
			if(reader[106] != DBNull.Value)
			{
				PCT038_0010 = (int?)reader[106];
			}
			if(reader[107] != DBNull.Value)
			{
				PCT038_0011 = (int?)reader[107];
			}
			if(reader[108] != DBNull.Value)
			{
				PCT038_0012 = (int?)reader[108];
			}
			if(reader[109] != DBNull.Value)
			{
				PCT038_0013 = (int?)reader[109];
			}
			if(reader[110] != DBNull.Value)
			{
				PCT038_0014 = (int?)reader[110];
			}
			if(reader[111] != DBNull.Value)
			{
				PCT038_0015 = (int?)reader[111];
			}
			if(reader[112] != DBNull.Value)
			{
				PCT038_0016 = (int?)reader[112];
			}
			if(reader[113] != DBNull.Value)
			{
				PCT038_0017 = (int?)reader[113];
			}
			if(reader[114] != DBNull.Value)
			{
				PCT038_0018 = (int?)reader[114];
			}
			if(reader[115] != DBNull.Value)
			{
				PCT038_0019 = (int?)reader[115];
			}
			if(reader[116] != DBNull.Value)
			{
				PCT038_0020 = (int?)reader[116];
			}
			if(reader[117] != DBNull.Value)
			{
				PCT038_0021 = (int?)reader[117];
			}
			if(reader[118] != DBNull.Value)
			{
				PCT038_0022 = (int?)reader[118];
			}
			if(reader[119] != DBNull.Value)
			{
				PCT038_0023 = (int?)reader[119];
			}
			if(reader[120] != DBNull.Value)
			{
				PCT038_0024 = (int?)reader[120];
			}
			if(reader[121] != DBNull.Value)
			{
				PCT038_0025 = (int?)reader[121];
			}
			if(reader[122] != DBNull.Value)
			{
				PCT038_0026 = (int?)reader[122];
			}
			if(reader[123] != DBNull.Value)
			{
				PCT038_0027 = (int?)reader[123];
			}
			if(reader[124] != DBNull.Value)
			{
				PCT038_0028 = (int?)reader[124];
			}
			if(reader[125] != DBNull.Value)
			{
				PCT038_0029 = (int?)reader[125];
			}
			if(reader[126] != DBNull.Value)
			{
				PCT038_0030 = (int?)reader[126];
			}
			if(reader[127] != DBNull.Value)
			{
				PCT038_0031 = (int?)reader[127];
			}
			if(reader[128] != DBNull.Value)
			{
				PCT038_0032 = (int?)reader[128];
			}
		}
		#endregion Constructors
	}
}
