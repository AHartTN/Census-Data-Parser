namespace CensusDataParser.Generated.Binding
{
	#region Using Directives
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.Data.OleDb;
	#endregion Using Directives

	public class SF1CongressionalDistricts113_SF1_00047 : BaseModel
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
		public int? HCT0010001 { get; set; }

		[Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 6)]
		public int? HCT0010002 { get; set; }

		[Display(Name = "Not Hispanic or Latino householder:", ShortName = "Not Hispanic or Latino householder:", Order = 7)]
		public int? HCT0010003 { get; set; }

		[Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 8)]
		public int? HCT0010004 { get; set; }

		[Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 9)]
		public int? HCT0010005 { get; set; }

		[Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 10)]
		public int? HCT0010006 { get; set; }

		[Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 11)]
		public int? HCT0010007 { get; set; }

		[Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 12)]
		public int? HCT0010008 { get; set; }

		[Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 13)]
		public int? HCT0010009 { get; set; }

		[Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 14)]
		public int? HCT0010010 { get; set; }

		[Display(Name = "Hispanic or Latino householder:", ShortName = "Hispanic or Latino householder:", Order = 15)]
		public int? HCT0010011 { get; set; }

		[Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 16)]
		public int? HCT0010012 { get; set; }

		[Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 17)]
		public int? HCT0010013 { get; set; }

		[Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 18)]
		public int? HCT0010014 { get; set; }

		[Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 19)]
		public int? HCT0010015 { get; set; }

		[Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 20)]
		public int? HCT0010016 { get; set; }

		[Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 21)]
		public int? HCT0010017 { get; set; }

		[Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 22)]
		public int? HCT0010018 { get; set; }

		[Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 23)]
		public int? HCT0010019 { get; set; }

		[Display(Name = "Not Hispanic or Latino householder:", ShortName = "Not Hispanic or Latino householder:", Order = 24)]
		public int? HCT0010020 { get; set; }

		[Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 25)]
		public int? HCT0010021 { get; set; }

		[Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 26)]
		public int? HCT0010022 { get; set; }

		[Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 27)]
		public int? HCT0010023 { get; set; }

		[Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 28)]
		public int? HCT0010024 { get; set; }

		[Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 29)]
		public int? HCT0010025 { get; set; }

		[Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 30)]
		public int? HCT0010026 { get; set; }

		[Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 31)]
		public int? HCT0010027 { get; set; }

		[Display(Name = "Hispanic or Latino householder:", ShortName = "Hispanic or Latino householder:", Order = 32)]
		public int? HCT0010028 { get; set; }

		[Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 33)]
		public int? HCT0010029 { get; set; }

		[Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 34)]
		public int? HCT0010030 { get; set; }

		[Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 35)]
		public int? HCT0010031 { get; set; }

		[Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 36)]
		public int? HCT0010032 { get; set; }

		[Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 37)]
		public int? HCT0010033 { get; set; }

		[Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 38)]
		public int? HCT0010034 { get; set; }

		[Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 39)]
		public int? HCT0010035 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 40)]
		public int? HCT0020001 { get; set; }

		[Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 41)]
		public int? HCT0020002 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 42)]
		public int? HCT0020003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 43)]
		public int? HCT0020004 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 44)]
		public int? HCT0020005 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 45)]
		public int? HCT0020006 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 46)]
		public int? HCT0020007 { get; set; }

		[Display(Name = "Renter-occupied:", ShortName = "Renter-occupied:", Order = 47)]
		public int? HCT0020008 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 48)]
		public int? HCT0020009 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 49)]
		public int? HCT0020010 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 50)]
		public int? HCT0020011 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 51)]
		public int? HCT0020012 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 52)]
		public int? HCT0020013 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 53)]
		public int? HCT0030001 { get; set; }

		[Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 54)]
		public int? HCT0030002 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 55)]
		public int? HCT0030003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 56)]
		public int? HCT0030004 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 57)]
		public int? HCT0030005 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 58)]
		public int? HCT0030006 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 59)]
		public int? HCT0030007 { get; set; }

		[Display(Name = "Renter-occupied:", ShortName = "Renter-occupied:", Order = 60)]
		public int? HCT0030008 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 61)]
		public int? HCT0030009 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 62)]
		public int? HCT0030010 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 63)]
		public int? HCT0030011 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 64)]
		public int? HCT0030012 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 65)]
		public int? HCT0030013 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 66)]
		public int? HCT0040001 { get; set; }

		[Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 67)]
		public int? HCT0040002 { get; set; }

		[Display(Name = "With children under 18 years:", ShortName = "With children under 18 years:", Order = 68)]
		public int? HCT0040003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 69)]
		public int? HCT0040004 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 70)]
		public int? HCT0040005 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 71)]
		public int? HCT0040006 { get; set; }

		[Display(Name = "No children under 18 years", ShortName = "No children under 18 years", Order = 72)]
		public int? HCT0040007 { get; set; }

		[Display(Name = "Renter-occupied:", ShortName = "Renter-occupied:", Order = 73)]
		public int? HCT0040008 { get; set; }

		[Display(Name = "With children under 18 years:", ShortName = "With children under 18 years:", Order = 74)]
		public int? HCT0040009 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 75)]
		public int? HCT0040010 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 76)]
		public int? HCT0040011 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 77)]
		public int? HCT0040012 { get; set; }

		[Display(Name = "No children under 18 years", ShortName = "No children under 18 years", Order = 78)]
		public int? HCT0040013 { get; set; }
		#endregion Properties

		#region Constructors
		public SF1CongressionalDistricts113_SF1_00047(string csvLine) : base(csvLine) { }

		public SF1CongressionalDistricts113_SF1_00047(string[] values) : base(values) { }

		public SF1CongressionalDistricts113_SF1_00047(OleDbDataReader reader)
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
				HCT0010001 = (int?)reader[5];
			}
			if (reader[6] != DBNull.Value)
			{
				HCT0010002 = (int?)reader[6];
			}
			if (reader[7] != DBNull.Value)
			{
				HCT0010003 = (int?)reader[7];
			}
			if (reader[8] != DBNull.Value)
			{
				HCT0010004 = (int?)reader[8];
			}
			if (reader[9] != DBNull.Value)
			{
				HCT0010005 = (int?)reader[9];
			}
			if (reader[10] != DBNull.Value)
			{
				HCT0010006 = (int?)reader[10];
			}
			if (reader[11] != DBNull.Value)
			{
				HCT0010007 = (int?)reader[11];
			}
			if (reader[12] != DBNull.Value)
			{
				HCT0010008 = (int?)reader[12];
			}
			if (reader[13] != DBNull.Value)
			{
				HCT0010009 = (int?)reader[13];
			}
			if (reader[14] != DBNull.Value)
			{
				HCT0010010 = (int?)reader[14];
			}
			if (reader[15] != DBNull.Value)
			{
				HCT0010011 = (int?)reader[15];
			}
			if (reader[16] != DBNull.Value)
			{
				HCT0010012 = (int?)reader[16];
			}
			if (reader[17] != DBNull.Value)
			{
				HCT0010013 = (int?)reader[17];
			}
			if (reader[18] != DBNull.Value)
			{
				HCT0010014 = (int?)reader[18];
			}
			if (reader[19] != DBNull.Value)
			{
				HCT0010015 = (int?)reader[19];
			}
			if (reader[20] != DBNull.Value)
			{
				HCT0010016 = (int?)reader[20];
			}
			if (reader[21] != DBNull.Value)
			{
				HCT0010017 = (int?)reader[21];
			}
			if (reader[22] != DBNull.Value)
			{
				HCT0010018 = (int?)reader[22];
			}
			if (reader[23] != DBNull.Value)
			{
				HCT0010019 = (int?)reader[23];
			}
			if (reader[24] != DBNull.Value)
			{
				HCT0010020 = (int?)reader[24];
			}
			if (reader[25] != DBNull.Value)
			{
				HCT0010021 = (int?)reader[25];
			}
			if (reader[26] != DBNull.Value)
			{
				HCT0010022 = (int?)reader[26];
			}
			if (reader[27] != DBNull.Value)
			{
				HCT0010023 = (int?)reader[27];
			}
			if (reader[28] != DBNull.Value)
			{
				HCT0010024 = (int?)reader[28];
			}
			if (reader[29] != DBNull.Value)
			{
				HCT0010025 = (int?)reader[29];
			}
			if (reader[30] != DBNull.Value)
			{
				HCT0010026 = (int?)reader[30];
			}
			if (reader[31] != DBNull.Value)
			{
				HCT0010027 = (int?)reader[31];
			}
			if (reader[32] != DBNull.Value)
			{
				HCT0010028 = (int?)reader[32];
			}
			if (reader[33] != DBNull.Value)
			{
				HCT0010029 = (int?)reader[33];
			}
			if (reader[34] != DBNull.Value)
			{
				HCT0010030 = (int?)reader[34];
			}
			if (reader[35] != DBNull.Value)
			{
				HCT0010031 = (int?)reader[35];
			}
			if (reader[36] != DBNull.Value)
			{
				HCT0010032 = (int?)reader[36];
			}
			if (reader[37] != DBNull.Value)
			{
				HCT0010033 = (int?)reader[37];
			}
			if (reader[38] != DBNull.Value)
			{
				HCT0010034 = (int?)reader[38];
			}
			if (reader[39] != DBNull.Value)
			{
				HCT0010035 = (int?)reader[39];
			}
			if (reader[40] != DBNull.Value)
			{
				HCT0020001 = (int?)reader[40];
			}
			if (reader[41] != DBNull.Value)
			{
				HCT0020002 = (int?)reader[41];
			}
			if (reader[42] != DBNull.Value)
			{
				HCT0020003 = (int?)reader[42];
			}
			if (reader[43] != DBNull.Value)
			{
				HCT0020004 = (int?)reader[43];
			}
			if (reader[44] != DBNull.Value)
			{
				HCT0020005 = (int?)reader[44];
			}
			if (reader[45] != DBNull.Value)
			{
				HCT0020006 = (int?)reader[45];
			}
			if (reader[46] != DBNull.Value)
			{
				HCT0020007 = (int?)reader[46];
			}
			if (reader[47] != DBNull.Value)
			{
				HCT0020008 = (int?)reader[47];
			}
			if (reader[48] != DBNull.Value)
			{
				HCT0020009 = (int?)reader[48];
			}
			if (reader[49] != DBNull.Value)
			{
				HCT0020010 = (int?)reader[49];
			}
			if (reader[50] != DBNull.Value)
			{
				HCT0020011 = (int?)reader[50];
			}
			if (reader[51] != DBNull.Value)
			{
				HCT0020012 = (int?)reader[51];
			}
			if (reader[52] != DBNull.Value)
			{
				HCT0020013 = (int?)reader[52];
			}
			if (reader[53] != DBNull.Value)
			{
				HCT0030001 = (int?)reader[53];
			}
			if (reader[54] != DBNull.Value)
			{
				HCT0030002 = (int?)reader[54];
			}
			if (reader[55] != DBNull.Value)
			{
				HCT0030003 = (int?)reader[55];
			}
			if (reader[56] != DBNull.Value)
			{
				HCT0030004 = (int?)reader[56];
			}
			if (reader[57] != DBNull.Value)
			{
				HCT0030005 = (int?)reader[57];
			}
			if (reader[58] != DBNull.Value)
			{
				HCT0030006 = (int?)reader[58];
			}
			if (reader[59] != DBNull.Value)
			{
				HCT0030007 = (int?)reader[59];
			}
			if (reader[60] != DBNull.Value)
			{
				HCT0030008 = (int?)reader[60];
			}
			if (reader[61] != DBNull.Value)
			{
				HCT0030009 = (int?)reader[61];
			}
			if (reader[62] != DBNull.Value)
			{
				HCT0030010 = (int?)reader[62];
			}
			if (reader[63] != DBNull.Value)
			{
				HCT0030011 = (int?)reader[63];
			}
			if (reader[64] != DBNull.Value)
			{
				HCT0030012 = (int?)reader[64];
			}
			if (reader[65] != DBNull.Value)
			{
				HCT0030013 = (int?)reader[65];
			}
			if (reader[66] != DBNull.Value)
			{
				HCT0040001 = (int?)reader[66];
			}
			if (reader[67] != DBNull.Value)
			{
				HCT0040002 = (int?)reader[67];
			}
			if (reader[68] != DBNull.Value)
			{
				HCT0040003 = (int?)reader[68];
			}
			if (reader[69] != DBNull.Value)
			{
				HCT0040004 = (int?)reader[69];
			}
			if (reader[70] != DBNull.Value)
			{
				HCT0040005 = (int?)reader[70];
			}
			if (reader[71] != DBNull.Value)
			{
				HCT0040006 = (int?)reader[71];
			}
			if (reader[72] != DBNull.Value)
			{
				HCT0040007 = (int?)reader[72];
			}
			if (reader[73] != DBNull.Value)
			{
				HCT0040008 = (int?)reader[73];
			}
			if (reader[74] != DBNull.Value)
			{
				HCT0040009 = (int?)reader[74];
			}
			if (reader[75] != DBNull.Value)
			{
				HCT0040010 = (int?)reader[75];
			}
			if (reader[76] != DBNull.Value)
			{
				HCT0040011 = (int?)reader[76];
			}
			if (reader[77] != DBNull.Value)
			{
				HCT0040012 = (int?)reader[77];
			}
			if (reader[78] != DBNull.Value)
			{
				HCT0040013 = (int?)reader[78];
			}
		}
		#endregion Constructors
	}
}
