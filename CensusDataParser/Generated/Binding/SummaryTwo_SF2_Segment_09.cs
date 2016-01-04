namespace CensusDataParser.Generated.Binding
{
	#region Using Directives
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.Data.OleDb;
	#endregion Using Directives

	public class SummaryTwo_SF2_Segment_09 : BaseModel
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

		[Display(Name = "Total (501):", ShortName = "Total (501):", Order = 5)]
		public int? PCO0080001 { get; set; }

		[Display(Name = "Male:", ShortName = "Male:", Order = 6)]
		public int? PCO0080002 { get; set; }

		[Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 7)]
		public int? PCO0080003 { get; set; }

		[Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 8)]
		public int? PCO0080004 { get; set; }

		[Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 9)]
		public int? PCO0080005 { get; set; }

		[Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 10)]
		public int? PCO0080006 { get; set; }

		[Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 11)]
		public int? PCO0080007 { get; set; }

		[Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 12)]
		public int? PCO0080008 { get; set; }

		[Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 13)]
		public int? PCO0080009 { get; set; }

		[Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 14)]
		public int? PCO0080010 { get; set; }

		[Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 15)]
		public int? PCO0080011 { get; set; }

		[Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 16)]
		public int? PCO0080012 { get; set; }

		[Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 17)]
		public int? PCO0080013 { get; set; }

		[Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 18)]
		public int? PCO0080014 { get; set; }

		[Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 19)]
		public int? PCO0080015 { get; set; }

		[Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 20)]
		public int? PCO0080016 { get; set; }

		[Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 21)]
		public int? PCO0080017 { get; set; }

		[Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 22)]
		public int? PCO0080018 { get; set; }

		[Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 23)]
		public int? PCO0080019 { get; set; }

		[Display(Name = "85 years and over", ShortName = "85 years and over", Order = 24)]
		public int? PCO0080020 { get; set; }

		[Display(Name = "Female:", ShortName = "Female:", Order = 25)]
		public int? PCO0080021 { get; set; }

		[Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 26)]
		public int? PCO0080022 { get; set; }

		[Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 27)]
		public int? PCO0080023 { get; set; }

		[Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 28)]
		public int? PCO0080024 { get; set; }

		[Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 29)]
		public int? PCO0080025 { get; set; }

		[Display(Name = "Total (601-602):", ShortName = "Total (601-602):", Order = 30)]
		public int? PCO0090001 { get; set; }

		[Display(Name = "Male:", ShortName = "Male:", Order = 31)]
		public int? PCO0090002 { get; set; }

		[Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 32)]
		public int? PCO0090003 { get; set; }

		[Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 33)]
		public int? PCO0090004 { get; set; }

		[Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 34)]
		public int? PCO0090005 { get; set; }

		[Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 35)]
		public int? PCO0090006 { get; set; }

		[Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 36)]
		public int? PCO0090007 { get; set; }

		[Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 37)]
		public int? PCO0090008 { get; set; }

		[Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 38)]
		public int? PCO0090009 { get; set; }

		[Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 39)]
		public int? PCO0090010 { get; set; }

		[Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 40)]
		public int? PCO0090011 { get; set; }

		[Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 41)]
		public int? PCO0090012 { get; set; }

		[Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 42)]
		public int? PCO0090013 { get; set; }

		[Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 43)]
		public int? PCO0090014 { get; set; }

		[Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 44)]
		public int? PCO0090015 { get; set; }

		[Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 45)]
		public int? PCO0090016 { get; set; }

		[Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 46)]
		public int? PCO0090017 { get; set; }

		[Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 47)]
		public int? PCO0090018 { get; set; }

		[Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 48)]
		public int? PCO0090019 { get; set; }

		[Display(Name = "85 years and over", ShortName = "85 years and over", Order = 49)]
		public int? PCO0090020 { get; set; }

		[Display(Name = "Female:", ShortName = "Female:", Order = 50)]
		public int? PCO0090021 { get; set; }

		[Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 51)]
		public int? PCO0090022 { get; set; }

		[Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 52)]
		public int? PCO0090023 { get; set; }

		[Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 53)]
		public int? PCO0090024 { get; set; }

		[Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 54)]
		public int? PCO0090025 { get; set; }

		[Display(Name = "Total (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Total (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 55)]
		public int? PCO0100001 { get; set; }

		[Display(Name = "Male:", ShortName = "Male:", Order = 56)]
		public int? PCO0100002 { get; set; }

		[Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 57)]
		public int? PCO0100003 { get; set; }

		[Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 58)]
		public int? PCO0100004 { get; set; }

		[Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 59)]
		public int? PCO0100005 { get; set; }

		[Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 60)]
		public int? PCO0100006 { get; set; }

		[Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 61)]
		public int? PCO0100007 { get; set; }

		[Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 62)]
		public int? PCO0100008 { get; set; }

		[Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 63)]
		public int? PCO0100009 { get; set; }

		[Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 64)]
		public int? PCO0100010 { get; set; }

		[Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 65)]
		public int? PCO0100011 { get; set; }

		[Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 66)]
		public int? PCO0100012 { get; set; }

		[Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 67)]
		public int? PCO0100013 { get; set; }

		[Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 68)]
		public int? PCO0100014 { get; set; }

		[Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 69)]
		public int? PCO0100015 { get; set; }

		[Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 70)]
		public int? PCO0100016 { get; set; }

		[Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 71)]
		public int? PCO0100017 { get; set; }

		[Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 72)]
		public int? PCO0100018 { get; set; }

		[Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 73)]
		public int? PCO0100019 { get; set; }

		[Display(Name = "85 years and over", ShortName = "85 years and over", Order = 74)]
		public int? PCO0100020 { get; set; }

		[Display(Name = "Female:", ShortName = "Female:", Order = 75)]
		public int? PCO0100021 { get; set; }

		[Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 76)]
		public int? PCO0100022 { get; set; }

		[Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 77)]
		public int? PCO0100023 { get; set; }

		[Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 78)]
		public int? PCO0100024 { get; set; }

		[Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 79)]
		public int? PCO0100025 { get; set; }

		[Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 80)]
		public int? PCO0100026 { get; set; }

		[Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 81)]
		public int? PCO0100027 { get; set; }

		[Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 82)]
		public int? PCO0100028 { get; set; }

		[Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 83)]
		public int? PCO0100029 { get; set; }

		[Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 84)]
		public int? PCO0100030 { get; set; }

		[Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 85)]
		public int? PCO0100031 { get; set; }

		[Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 86)]
		public int? PCO0100032 { get; set; }

		[Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 87)]
		public int? PCO0100033 { get; set; }

		[Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 88)]
		public int? PCO0100034 { get; set; }

		[Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 89)]
		public int? PCO0100035 { get; set; }

		[Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 90)]
		public int? PCO0100036 { get; set; }

		[Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 91)]
		public int? PCO0100037 { get; set; }

		[Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 92)]
		public int? PCO0100038 { get; set; }

		[Display(Name = "85 years and over", ShortName = "85 years and over", Order = 93)]
		public int? PCO0100039 { get; set; }
		#endregion Properties

		#region Constructors
		public SummaryTwo_SF2_Segment_09(string csvLine) : base(csvLine) { }

		public SummaryTwo_SF2_Segment_09(string[] values) : base(values) { }

		public SummaryTwo_SF2_Segment_09(OleDbDataReader reader)
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
				PCO0080001 = (int?)reader[5];
			}
			if (reader[6] != DBNull.Value)
			{
				PCO0080002 = (int?)reader[6];
			}
			if (reader[7] != DBNull.Value)
			{
				PCO0080003 = (int?)reader[7];
			}
			if (reader[8] != DBNull.Value)
			{
				PCO0080004 = (int?)reader[8];
			}
			if (reader[9] != DBNull.Value)
			{
				PCO0080005 = (int?)reader[9];
			}
			if (reader[10] != DBNull.Value)
			{
				PCO0080006 = (int?)reader[10];
			}
			if (reader[11] != DBNull.Value)
			{
				PCO0080007 = (int?)reader[11];
			}
			if (reader[12] != DBNull.Value)
			{
				PCO0080008 = (int?)reader[12];
			}
			if (reader[13] != DBNull.Value)
			{
				PCO0080009 = (int?)reader[13];
			}
			if (reader[14] != DBNull.Value)
			{
				PCO0080010 = (int?)reader[14];
			}
			if (reader[15] != DBNull.Value)
			{
				PCO0080011 = (int?)reader[15];
			}
			if (reader[16] != DBNull.Value)
			{
				PCO0080012 = (int?)reader[16];
			}
			if (reader[17] != DBNull.Value)
			{
				PCO0080013 = (int?)reader[17];
			}
			if (reader[18] != DBNull.Value)
			{
				PCO0080014 = (int?)reader[18];
			}
			if (reader[19] != DBNull.Value)
			{
				PCO0080015 = (int?)reader[19];
			}
			if (reader[20] != DBNull.Value)
			{
				PCO0080016 = (int?)reader[20];
			}
			if (reader[21] != DBNull.Value)
			{
				PCO0080017 = (int?)reader[21];
			}
			if (reader[22] != DBNull.Value)
			{
				PCO0080018 = (int?)reader[22];
			}
			if (reader[23] != DBNull.Value)
			{
				PCO0080019 = (int?)reader[23];
			}
			if (reader[24] != DBNull.Value)
			{
				PCO0080020 = (int?)reader[24];
			}
			if (reader[25] != DBNull.Value)
			{
				PCO0080021 = (int?)reader[25];
			}
			if (reader[26] != DBNull.Value)
			{
				PCO0080022 = (int?)reader[26];
			}
			if (reader[27] != DBNull.Value)
			{
				PCO0080023 = (int?)reader[27];
			}
			if (reader[28] != DBNull.Value)
			{
				PCO0080024 = (int?)reader[28];
			}
			if (reader[29] != DBNull.Value)
			{
				PCO0080025 = (int?)reader[29];
			}
			if (reader[30] != DBNull.Value)
			{
				PCO0090001 = (int?)reader[30];
			}
			if (reader[31] != DBNull.Value)
			{
				PCO0090002 = (int?)reader[31];
			}
			if (reader[32] != DBNull.Value)
			{
				PCO0090003 = (int?)reader[32];
			}
			if (reader[33] != DBNull.Value)
			{
				PCO0090004 = (int?)reader[33];
			}
			if (reader[34] != DBNull.Value)
			{
				PCO0090005 = (int?)reader[34];
			}
			if (reader[35] != DBNull.Value)
			{
				PCO0090006 = (int?)reader[35];
			}
			if (reader[36] != DBNull.Value)
			{
				PCO0090007 = (int?)reader[36];
			}
			if (reader[37] != DBNull.Value)
			{
				PCO0090008 = (int?)reader[37];
			}
			if (reader[38] != DBNull.Value)
			{
				PCO0090009 = (int?)reader[38];
			}
			if (reader[39] != DBNull.Value)
			{
				PCO0090010 = (int?)reader[39];
			}
			if (reader[40] != DBNull.Value)
			{
				PCO0090011 = (int?)reader[40];
			}
			if (reader[41] != DBNull.Value)
			{
				PCO0090012 = (int?)reader[41];
			}
			if (reader[42] != DBNull.Value)
			{
				PCO0090013 = (int?)reader[42];
			}
			if (reader[43] != DBNull.Value)
			{
				PCO0090014 = (int?)reader[43];
			}
			if (reader[44] != DBNull.Value)
			{
				PCO0090015 = (int?)reader[44];
			}
			if (reader[45] != DBNull.Value)
			{
				PCO0090016 = (int?)reader[45];
			}
			if (reader[46] != DBNull.Value)
			{
				PCO0090017 = (int?)reader[46];
			}
			if (reader[47] != DBNull.Value)
			{
				PCO0090018 = (int?)reader[47];
			}
			if (reader[48] != DBNull.Value)
			{
				PCO0090019 = (int?)reader[48];
			}
			if (reader[49] != DBNull.Value)
			{
				PCO0090020 = (int?)reader[49];
			}
			if (reader[50] != DBNull.Value)
			{
				PCO0090021 = (int?)reader[50];
			}
			if (reader[51] != DBNull.Value)
			{
				PCO0090022 = (int?)reader[51];
			}
			if (reader[52] != DBNull.Value)
			{
				PCO0090023 = (int?)reader[52];
			}
			if (reader[53] != DBNull.Value)
			{
				PCO0090024 = (int?)reader[53];
			}
			if (reader[54] != DBNull.Value)
			{
				PCO0090025 = (int?)reader[54];
			}
			if (reader[55] != DBNull.Value)
			{
				PCO0100001 = (int?)reader[55];
			}
			if (reader[56] != DBNull.Value)
			{
				PCO0100002 = (int?)reader[56];
			}
			if (reader[57] != DBNull.Value)
			{
				PCO0100003 = (int?)reader[57];
			}
			if (reader[58] != DBNull.Value)
			{
				PCO0100004 = (int?)reader[58];
			}
			if (reader[59] != DBNull.Value)
			{
				PCO0100005 = (int?)reader[59];
			}
			if (reader[60] != DBNull.Value)
			{
				PCO0100006 = (int?)reader[60];
			}
			if (reader[61] != DBNull.Value)
			{
				PCO0100007 = (int?)reader[61];
			}
			if (reader[62] != DBNull.Value)
			{
				PCO0100008 = (int?)reader[62];
			}
			if (reader[63] != DBNull.Value)
			{
				PCO0100009 = (int?)reader[63];
			}
			if (reader[64] != DBNull.Value)
			{
				PCO0100010 = (int?)reader[64];
			}
			if (reader[65] != DBNull.Value)
			{
				PCO0100011 = (int?)reader[65];
			}
			if (reader[66] != DBNull.Value)
			{
				PCO0100012 = (int?)reader[66];
			}
			if (reader[67] != DBNull.Value)
			{
				PCO0100013 = (int?)reader[67];
			}
			if (reader[68] != DBNull.Value)
			{
				PCO0100014 = (int?)reader[68];
			}
			if (reader[69] != DBNull.Value)
			{
				PCO0100015 = (int?)reader[69];
			}
			if (reader[70] != DBNull.Value)
			{
				PCO0100016 = (int?)reader[70];
			}
			if (reader[71] != DBNull.Value)
			{
				PCO0100017 = (int?)reader[71];
			}
			if (reader[72] != DBNull.Value)
			{
				PCO0100018 = (int?)reader[72];
			}
			if (reader[73] != DBNull.Value)
			{
				PCO0100019 = (int?)reader[73];
			}
			if (reader[74] != DBNull.Value)
			{
				PCO0100020 = (int?)reader[74];
			}
			if (reader[75] != DBNull.Value)
			{
				PCO0100021 = (int?)reader[75];
			}
			if (reader[76] != DBNull.Value)
			{
				PCO0100022 = (int?)reader[76];
			}
			if (reader[77] != DBNull.Value)
			{
				PCO0100023 = (int?)reader[77];
			}
			if (reader[78] != DBNull.Value)
			{
				PCO0100024 = (int?)reader[78];
			}
			if (reader[79] != DBNull.Value)
			{
				PCO0100025 = (int?)reader[79];
			}
			if (reader[80] != DBNull.Value)
			{
				PCO0100026 = (int?)reader[80];
			}
			if (reader[81] != DBNull.Value)
			{
				PCO0100027 = (int?)reader[81];
			}
			if (reader[82] != DBNull.Value)
			{
				PCO0100028 = (int?)reader[82];
			}
			if (reader[83] != DBNull.Value)
			{
				PCO0100029 = (int?)reader[83];
			}
			if (reader[84] != DBNull.Value)
			{
				PCO0100030 = (int?)reader[84];
			}
			if (reader[85] != DBNull.Value)
			{
				PCO0100031 = (int?)reader[85];
			}
			if (reader[86] != DBNull.Value)
			{
				PCO0100032 = (int?)reader[86];
			}
			if (reader[87] != DBNull.Value)
			{
				PCO0100033 = (int?)reader[87];
			}
			if (reader[88] != DBNull.Value)
			{
				PCO0100034 = (int?)reader[88];
			}
			if (reader[89] != DBNull.Value)
			{
				PCO0100035 = (int?)reader[89];
			}
			if (reader[90] != DBNull.Value)
			{
				PCO0100036 = (int?)reader[90];
			}
			if (reader[91] != DBNull.Value)
			{
				PCO0100037 = (int?)reader[91];
			}
			if (reader[92] != DBNull.Value)
			{
				PCO0100038 = (int?)reader[92];
			}
			if (reader[93] != DBNull.Value)
			{
				PCO0100039 = (int?)reader[93];
			}
		}
		#endregion Constructors
	}
}
