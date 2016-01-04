namespace CensusDataParser.Generated.Binding
{
	#region Using Directives
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.Data.OleDb;
	#endregion Using Directives

	public class SummaryTwo_SF2_Segment_11 : BaseModel
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
		public int? HCT0020001 { get; set; }

		[Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 6)]
		public int? HCT0020002 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 7)]
		public int? HCT0020003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 8)]
		public int? HCT0020004 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 9)]
		public int? HCT0030001 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 10)]
		public int? HCT0040001 { get; set; }

		[Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 11)]
		public int? HCT0040002 { get; set; }

		[Display(Name = "With children under 18 years:", ShortName = "With children under 18 years:", Order = 12)]
		public int? HCT0040003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 13)]
		public int? HCT0040004 { get; set; }

		[Display(Name = "Total", ShortName = "Total", Order = 14)]
		public decimal? HCT0050001 { get; set; }

		[Display(Name = "Owner occupied", ShortName = "Owner occupied", Order = 15)]
		public decimal? HCT0050002 { get; set; }

		[Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 16)]
		public decimal? HCT0050003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 17)]
		public int? HCT0060001 { get; set; }

		[Display(Name = "1-person household", ShortName = "1-person household", Order = 18)]
		public int? HCT0060002 { get; set; }

		[Display(Name = "2-person household", ShortName = "2-person household", Order = 19)]
		public int? HCT0060003 { get; set; }

		[Display(Name = "3-person household", ShortName = "3-person household", Order = 20)]
		public int? HCT0060004 { get; set; }

		[Display(Name = "4-person household", ShortName = "4-person household", Order = 21)]
		public int? HCT0060005 { get; set; }

		[Display(Name = "5-person household", ShortName = "5-person household", Order = 22)]
		public int? HCT0060006 { get; set; }

		[Display(Name = "6-person household", ShortName = "6-person household", Order = 23)]
		public int? HCT0060007 { get; set; }

		[Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 24)]
		public int? HCT0060008 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 25)]
		public int? HCT0070001 { get; set; }

		[Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 26)]
		public int? HCT0070002 { get; set; }

		[Display(Name = "1-person household", ShortName = "1-person household", Order = 27)]
		public int? HCT0070003 { get; set; }

		[Display(Name = "2-person household", ShortName = "2-person household", Order = 28)]
		public int? HCT0070004 { get; set; }

		[Display(Name = "3-person household", ShortName = "3-person household", Order = 29)]
		public int? HCT0070005 { get; set; }

		[Display(Name = "4-person household", ShortName = "4-person household", Order = 30)]
		public int? HCT0070006 { get; set; }

		[Display(Name = "5-person household", ShortName = "5-person household", Order = 31)]
		public int? HCT0070007 { get; set; }

		[Display(Name = "6-person household", ShortName = "6-person household", Order = 32)]
		public int? HCT0070008 { get; set; }

		[Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 33)]
		public int? HCT0070009 { get; set; }

		[Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 34)]
		public int? HCT0070010 { get; set; }

		[Display(Name = "1-person household", ShortName = "1-person household", Order = 35)]
		public int? HCT0070011 { get; set; }

		[Display(Name = "2-person household", ShortName = "2-person household", Order = 36)]
		public int? HCT0070012 { get; set; }

		[Display(Name = "3-person household", ShortName = "3-person household", Order = 37)]
		public int? HCT0070013 { get; set; }

		[Display(Name = "4-person household", ShortName = "4-person household", Order = 38)]
		public int? HCT0070014 { get; set; }

		[Display(Name = "5-person household", ShortName = "5-person household", Order = 39)]
		public int? HCT0070015 { get; set; }

		[Display(Name = "6-person household", ShortName = "6-person household", Order = 40)]
		public int? HCT0070016 { get; set; }

		[Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 41)]
		public int? HCT0070017 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 42)]
		public int? HCT0080001 { get; set; }

		[Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 43)]
		public int? HCT0080002 { get; set; }

		[Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 44)]
		public int? HCT0080003 { get; set; }

		[Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 45)]
		public int? HCT0080004 { get; set; }

		[Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 46)]
		public int? HCT0080005 { get; set; }

		[Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 47)]
		public int? HCT0080006 { get; set; }

		[Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 48)]
		public int? HCT0080007 { get; set; }

		[Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 49)]
		public int? HCT0080008 { get; set; }

		[Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 50)]
		public int? HCT0080009 { get; set; }

		[Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 51)]
		public int? HCT0080010 { get; set; }

		[Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 52)]
		public int? HCT0080011 { get; set; }

		[Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 53)]
		public int? HCT0080012 { get; set; }

		[Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 54)]
		public int? HCT0080013 { get; set; }

		[Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 55)]
		public int? HCT0080014 { get; set; }

		[Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 56)]
		public int? HCT0080015 { get; set; }

		[Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 57)]
		public int? HCT0080016 { get; set; }

		[Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 58)]
		public int? HCT0080017 { get; set; }

		[Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 59)]
		public int? HCT0080018 { get; set; }

		[Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 60)]
		public int? HCT0080019 { get; set; }

		[Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 61)]
		public int? HCT0080020 { get; set; }

		[Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 62)]
		public int? HCT0080021 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 63)]
		public int? HCT0090001 { get; set; }

		[Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 64)]
		public int? HCT0090002 { get; set; }

		[Display(Name = "Family households:", ShortName = "Family households:", Order = 65)]
		public int? HCT0090003 { get; set; }

		[Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 66)]
		public int? HCT0090004 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 67)]
		public int? HCT0090005 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 68)]
		public int? HCT0090006 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 69)]
		public int? HCT0090007 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 70)]
		public int? HCT0090008 { get; set; }

		[Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 71)]
		public int? HCT0090009 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 72)]
		public int? HCT0090010 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 73)]
		public int? HCT0090011 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 74)]
		public int? HCT0090012 { get; set; }

		[Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 75)]
		public int? HCT0090013 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 76)]
		public int? HCT0090014 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 77)]
		public int? HCT0090015 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 78)]
		public int? HCT0090016 { get; set; }

		[Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 79)]
		public int? HCT0090017 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 80)]
		public int? HCT0090018 { get; set; }

		[Display(Name = "Living alone:", ShortName = "Living alone:", Order = 81)]
		public int? HCT0090019 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 82)]
		public int? HCT0090020 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 83)]
		public int? HCT0090021 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 84)]
		public int? HCT0090022 { get; set; }

		[Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 85)]
		public int? HCT0090023 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 86)]
		public int? HCT0090024 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 87)]
		public int? HCT0090025 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 88)]
		public int? HCT0090026 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 89)]
		public int? HCT0090027 { get; set; }

		[Display(Name = "Living alone:", ShortName = "Living alone:", Order = 90)]
		public int? HCT0090028 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 91)]
		public int? HCT0090029 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 92)]
		public int? HCT0090030 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 93)]
		public int? HCT0090031 { get; set; }

		[Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 94)]
		public int? HCT0090032 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 95)]
		public int? HCT0090033 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 96)]
		public int? HCT0090034 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 97)]
		public int? HCT0090035 { get; set; }

		[Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 98)]
		public int? HCT0090036 { get; set; }

		[Display(Name = "Family households:", ShortName = "Family households:", Order = 99)]
		public int? HCT0090037 { get; set; }

		[Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 100)]
		public int? HCT0090038 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 101)]
		public int? HCT0090039 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 102)]
		public int? HCT0090040 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 103)]
		public int? HCT0090041 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 104)]
		public int? HCT0090042 { get; set; }

		[Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 105)]
		public int? HCT0090043 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 106)]
		public int? HCT0090044 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 107)]
		public int? HCT0090045 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 108)]
		public int? HCT0090046 { get; set; }

		[Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 109)]
		public int? HCT0090047 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 110)]
		public int? HCT0090048 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 111)]
		public int? HCT0090049 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 112)]
		public int? HCT0090050 { get; set; }

		[Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 113)]
		public int? HCT0090051 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 114)]
		public int? HCT0090052 { get; set; }

		[Display(Name = "Living alone:", ShortName = "Living alone:", Order = 115)]
		public int? HCT0090053 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 116)]
		public int? HCT0090054 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 117)]
		public int? HCT0090055 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 118)]
		public int? HCT0090056 { get; set; }

		[Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 119)]
		public int? HCT0090057 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 120)]
		public int? HCT0090058 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 121)]
		public int? HCT0090059 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 122)]
		public int? HCT0090060 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 123)]
		public int? HCT0090061 { get; set; }

		[Display(Name = "Living alone:", ShortName = "Living alone:", Order = 124)]
		public int? HCT0090062 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 125)]
		public int? HCT0090063 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 126)]
		public int? HCT0090064 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 127)]
		public int? HCT0090065 { get; set; }

		[Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 128)]
		public int? HCT0090066 { get; set; }

		[Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 129)]
		public int? HCT0090067 { get; set; }

		[Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 130)]
		public int? HCT0090068 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 131)]
		public int? HCT0090069 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 132)]
		public int? HCT0100001 { get; set; }

		[Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 133)]
		public int? HCT0100002 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 134)]
		public int? HCT0100003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 135)]
		public int? HCT0100004 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 136)]
		public int? HCT0100005 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 137)]
		public int? HCT0100006 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 138)]
		public int? HCT0100007 { get; set; }

		[Display(Name = "Renter-occupied:", ShortName = "Renter-occupied:", Order = 139)]
		public int? HCT0100008 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 140)]
		public int? HCT0100009 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 141)]
		public int? HCT0100010 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 142)]
		public int? HCT0100011 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 143)]
		public int? HCT0100012 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 144)]
		public int? HCT0100013 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 145)]
		public int? HCT0110001 { get; set; }

		[Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 146)]
		public int? HCT0110002 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 147)]
		public int? HCT0110003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 148)]
		public int? HCT0110004 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 149)]
		public int? HCT0110005 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 150)]
		public int? HCT0110006 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 151)]
		public int? HCT0110007 { get; set; }

		[Display(Name = "Renter-occupied:", ShortName = "Renter-occupied:", Order = 152)]
		public int? HCT0110008 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 153)]
		public int? HCT0110009 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 154)]
		public int? HCT0110010 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 155)]
		public int? HCT0110011 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 156)]
		public int? HCT0110012 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 157)]
		public int? HCT0110013 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 158)]
		public int? HCT0120001 { get; set; }

		[Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 159)]
		public int? HCT0120002 { get; set; }

		[Display(Name = "With children under 18 years:", ShortName = "With children under 18 years:", Order = 160)]
		public int? HCT0120003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 161)]
		public int? HCT0120004 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 162)]
		public int? HCT0120005 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 163)]
		public int? HCT0120006 { get; set; }

		[Display(Name = "No children under 18 years", ShortName = "No children under 18 years", Order = 164)]
		public int? HCT0120007 { get; set; }

		[Display(Name = "Renter-occupied:", ShortName = "Renter-occupied:", Order = 165)]
		public int? HCT0120008 { get; set; }

		[Display(Name = "With children under 18 years:", ShortName = "With children under 18 years:", Order = 166)]
		public int? HCT0120009 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 167)]
		public int? HCT0120010 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 168)]
		public int? HCT0120011 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 169)]
		public int? HCT0120012 { get; set; }

		[Display(Name = "No children under 18 years", ShortName = "No children under 18 years", Order = 170)]
		public int? HCT0120013 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 171)]
		public int? HCT0130001 { get; set; }

		[Display(Name = "Substituted", ShortName = "Substituted", Order = 172)]
		public int? HCT0130002 { get; set; }

		[Display(Name = "Not substituted", ShortName = "Not substituted", Order = 173)]
		public int? HCT0130003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 174)]
		public int? HCT0140001 { get; set; }

		[Display(Name = "Allocated", ShortName = "Allocated", Order = 175)]
		public int? HCT0140002 { get; set; }

		[Display(Name = "Not allocated", ShortName = "Not allocated", Order = 176)]
		public int? HCT0140003 { get; set; }
		#endregion Properties

		#region Constructors
		public SummaryTwo_SF2_Segment_11(string csvLine) : base(csvLine) { }

		public SummaryTwo_SF2_Segment_11(string[] values) : base(values) { }

		public SummaryTwo_SF2_Segment_11(OleDbDataReader reader)
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
				HCT0020001 = (int?)reader[5];
			}
			if (reader[6] != DBNull.Value)
			{
				HCT0020002 = (int?)reader[6];
			}
			if (reader[7] != DBNull.Value)
			{
				HCT0020003 = (int?)reader[7];
			}
			if (reader[8] != DBNull.Value)
			{
				HCT0020004 = (int?)reader[8];
			}
			if (reader[9] != DBNull.Value)
			{
				HCT0030001 = (int?)reader[9];
			}
			if (reader[10] != DBNull.Value)
			{
				HCT0040001 = (int?)reader[10];
			}
			if (reader[11] != DBNull.Value)
			{
				HCT0040002 = (int?)reader[11];
			}
			if (reader[12] != DBNull.Value)
			{
				HCT0040003 = (int?)reader[12];
			}
			if (reader[13] != DBNull.Value)
			{
				HCT0040004 = (int?)reader[13];
			}
			if (reader[14] != DBNull.Value)
			{
				HCT0050001 = (decimal?)reader[14];
			}
			if (reader[15] != DBNull.Value)
			{
				HCT0050002 = (decimal?)reader[15];
			}
			if (reader[16] != DBNull.Value)
			{
				HCT0050003 = (decimal?)reader[16];
			}
			if (reader[17] != DBNull.Value)
			{
				HCT0060001 = (int?)reader[17];
			}
			if (reader[18] != DBNull.Value)
			{
				HCT0060002 = (int?)reader[18];
			}
			if (reader[19] != DBNull.Value)
			{
				HCT0060003 = (int?)reader[19];
			}
			if (reader[20] != DBNull.Value)
			{
				HCT0060004 = (int?)reader[20];
			}
			if (reader[21] != DBNull.Value)
			{
				HCT0060005 = (int?)reader[21];
			}
			if (reader[22] != DBNull.Value)
			{
				HCT0060006 = (int?)reader[22];
			}
			if (reader[23] != DBNull.Value)
			{
				HCT0060007 = (int?)reader[23];
			}
			if (reader[24] != DBNull.Value)
			{
				HCT0060008 = (int?)reader[24];
			}
			if (reader[25] != DBNull.Value)
			{
				HCT0070001 = (int?)reader[25];
			}
			if (reader[26] != DBNull.Value)
			{
				HCT0070002 = (int?)reader[26];
			}
			if (reader[27] != DBNull.Value)
			{
				HCT0070003 = (int?)reader[27];
			}
			if (reader[28] != DBNull.Value)
			{
				HCT0070004 = (int?)reader[28];
			}
			if (reader[29] != DBNull.Value)
			{
				HCT0070005 = (int?)reader[29];
			}
			if (reader[30] != DBNull.Value)
			{
				HCT0070006 = (int?)reader[30];
			}
			if (reader[31] != DBNull.Value)
			{
				HCT0070007 = (int?)reader[31];
			}
			if (reader[32] != DBNull.Value)
			{
				HCT0070008 = (int?)reader[32];
			}
			if (reader[33] != DBNull.Value)
			{
				HCT0070009 = (int?)reader[33];
			}
			if (reader[34] != DBNull.Value)
			{
				HCT0070010 = (int?)reader[34];
			}
			if (reader[35] != DBNull.Value)
			{
				HCT0070011 = (int?)reader[35];
			}
			if (reader[36] != DBNull.Value)
			{
				HCT0070012 = (int?)reader[36];
			}
			if (reader[37] != DBNull.Value)
			{
				HCT0070013 = (int?)reader[37];
			}
			if (reader[38] != DBNull.Value)
			{
				HCT0070014 = (int?)reader[38];
			}
			if (reader[39] != DBNull.Value)
			{
				HCT0070015 = (int?)reader[39];
			}
			if (reader[40] != DBNull.Value)
			{
				HCT0070016 = (int?)reader[40];
			}
			if (reader[41] != DBNull.Value)
			{
				HCT0070017 = (int?)reader[41];
			}
			if (reader[42] != DBNull.Value)
			{
				HCT0080001 = (int?)reader[42];
			}
			if (reader[43] != DBNull.Value)
			{
				HCT0080002 = (int?)reader[43];
			}
			if (reader[44] != DBNull.Value)
			{
				HCT0080003 = (int?)reader[44];
			}
			if (reader[45] != DBNull.Value)
			{
				HCT0080004 = (int?)reader[45];
			}
			if (reader[46] != DBNull.Value)
			{
				HCT0080005 = (int?)reader[46];
			}
			if (reader[47] != DBNull.Value)
			{
				HCT0080006 = (int?)reader[47];
			}
			if (reader[48] != DBNull.Value)
			{
				HCT0080007 = (int?)reader[48];
			}
			if (reader[49] != DBNull.Value)
			{
				HCT0080008 = (int?)reader[49];
			}
			if (reader[50] != DBNull.Value)
			{
				HCT0080009 = (int?)reader[50];
			}
			if (reader[51] != DBNull.Value)
			{
				HCT0080010 = (int?)reader[51];
			}
			if (reader[52] != DBNull.Value)
			{
				HCT0080011 = (int?)reader[52];
			}
			if (reader[53] != DBNull.Value)
			{
				HCT0080012 = (int?)reader[53];
			}
			if (reader[54] != DBNull.Value)
			{
				HCT0080013 = (int?)reader[54];
			}
			if (reader[55] != DBNull.Value)
			{
				HCT0080014 = (int?)reader[55];
			}
			if (reader[56] != DBNull.Value)
			{
				HCT0080015 = (int?)reader[56];
			}
			if (reader[57] != DBNull.Value)
			{
				HCT0080016 = (int?)reader[57];
			}
			if (reader[58] != DBNull.Value)
			{
				HCT0080017 = (int?)reader[58];
			}
			if (reader[59] != DBNull.Value)
			{
				HCT0080018 = (int?)reader[59];
			}
			if (reader[60] != DBNull.Value)
			{
				HCT0080019 = (int?)reader[60];
			}
			if (reader[61] != DBNull.Value)
			{
				HCT0080020 = (int?)reader[61];
			}
			if (reader[62] != DBNull.Value)
			{
				HCT0080021 = (int?)reader[62];
			}
			if (reader[63] != DBNull.Value)
			{
				HCT0090001 = (int?)reader[63];
			}
			if (reader[64] != DBNull.Value)
			{
				HCT0090002 = (int?)reader[64];
			}
			if (reader[65] != DBNull.Value)
			{
				HCT0090003 = (int?)reader[65];
			}
			if (reader[66] != DBNull.Value)
			{
				HCT0090004 = (int?)reader[66];
			}
			if (reader[67] != DBNull.Value)
			{
				HCT0090005 = (int?)reader[67];
			}
			if (reader[68] != DBNull.Value)
			{
				HCT0090006 = (int?)reader[68];
			}
			if (reader[69] != DBNull.Value)
			{
				HCT0090007 = (int?)reader[69];
			}
			if (reader[70] != DBNull.Value)
			{
				HCT0090008 = (int?)reader[70];
			}
			if (reader[71] != DBNull.Value)
			{
				HCT0090009 = (int?)reader[71];
			}
			if (reader[72] != DBNull.Value)
			{
				HCT0090010 = (int?)reader[72];
			}
			if (reader[73] != DBNull.Value)
			{
				HCT0090011 = (int?)reader[73];
			}
			if (reader[74] != DBNull.Value)
			{
				HCT0090012 = (int?)reader[74];
			}
			if (reader[75] != DBNull.Value)
			{
				HCT0090013 = (int?)reader[75];
			}
			if (reader[76] != DBNull.Value)
			{
				HCT0090014 = (int?)reader[76];
			}
			if (reader[77] != DBNull.Value)
			{
				HCT0090015 = (int?)reader[77];
			}
			if (reader[78] != DBNull.Value)
			{
				HCT0090016 = (int?)reader[78];
			}
			if (reader[79] != DBNull.Value)
			{
				HCT0090017 = (int?)reader[79];
			}
			if (reader[80] != DBNull.Value)
			{
				HCT0090018 = (int?)reader[80];
			}
			if (reader[81] != DBNull.Value)
			{
				HCT0090019 = (int?)reader[81];
			}
			if (reader[82] != DBNull.Value)
			{
				HCT0090020 = (int?)reader[82];
			}
			if (reader[83] != DBNull.Value)
			{
				HCT0090021 = (int?)reader[83];
			}
			if (reader[84] != DBNull.Value)
			{
				HCT0090022 = (int?)reader[84];
			}
			if (reader[85] != DBNull.Value)
			{
				HCT0090023 = (int?)reader[85];
			}
			if (reader[86] != DBNull.Value)
			{
				HCT0090024 = (int?)reader[86];
			}
			if (reader[87] != DBNull.Value)
			{
				HCT0090025 = (int?)reader[87];
			}
			if (reader[88] != DBNull.Value)
			{
				HCT0090026 = (int?)reader[88];
			}
			if (reader[89] != DBNull.Value)
			{
				HCT0090027 = (int?)reader[89];
			}
			if (reader[90] != DBNull.Value)
			{
				HCT0090028 = (int?)reader[90];
			}
			if (reader[91] != DBNull.Value)
			{
				HCT0090029 = (int?)reader[91];
			}
			if (reader[92] != DBNull.Value)
			{
				HCT0090030 = (int?)reader[92];
			}
			if (reader[93] != DBNull.Value)
			{
				HCT0090031 = (int?)reader[93];
			}
			if (reader[94] != DBNull.Value)
			{
				HCT0090032 = (int?)reader[94];
			}
			if (reader[95] != DBNull.Value)
			{
				HCT0090033 = (int?)reader[95];
			}
			if (reader[96] != DBNull.Value)
			{
				HCT0090034 = (int?)reader[96];
			}
			if (reader[97] != DBNull.Value)
			{
				HCT0090035 = (int?)reader[97];
			}
			if (reader[98] != DBNull.Value)
			{
				HCT0090036 = (int?)reader[98];
			}
			if (reader[99] != DBNull.Value)
			{
				HCT0090037 = (int?)reader[99];
			}
			if (reader[100] != DBNull.Value)
			{
				HCT0090038 = (int?)reader[100];
			}
			if (reader[101] != DBNull.Value)
			{
				HCT0090039 = (int?)reader[101];
			}
			if (reader[102] != DBNull.Value)
			{
				HCT0090040 = (int?)reader[102];
			}
			if (reader[103] != DBNull.Value)
			{
				HCT0090041 = (int?)reader[103];
			}
			if (reader[104] != DBNull.Value)
			{
				HCT0090042 = (int?)reader[104];
			}
			if (reader[105] != DBNull.Value)
			{
				HCT0090043 = (int?)reader[105];
			}
			if (reader[106] != DBNull.Value)
			{
				HCT0090044 = (int?)reader[106];
			}
			if (reader[107] != DBNull.Value)
			{
				HCT0090045 = (int?)reader[107];
			}
			if (reader[108] != DBNull.Value)
			{
				HCT0090046 = (int?)reader[108];
			}
			if (reader[109] != DBNull.Value)
			{
				HCT0090047 = (int?)reader[109];
			}
			if (reader[110] != DBNull.Value)
			{
				HCT0090048 = (int?)reader[110];
			}
			if (reader[111] != DBNull.Value)
			{
				HCT0090049 = (int?)reader[111];
			}
			if (reader[112] != DBNull.Value)
			{
				HCT0090050 = (int?)reader[112];
			}
			if (reader[113] != DBNull.Value)
			{
				HCT0090051 = (int?)reader[113];
			}
			if (reader[114] != DBNull.Value)
			{
				HCT0090052 = (int?)reader[114];
			}
			if (reader[115] != DBNull.Value)
			{
				HCT0090053 = (int?)reader[115];
			}
			if (reader[116] != DBNull.Value)
			{
				HCT0090054 = (int?)reader[116];
			}
			if (reader[117] != DBNull.Value)
			{
				HCT0090055 = (int?)reader[117];
			}
			if (reader[118] != DBNull.Value)
			{
				HCT0090056 = (int?)reader[118];
			}
			if (reader[119] != DBNull.Value)
			{
				HCT0090057 = (int?)reader[119];
			}
			if (reader[120] != DBNull.Value)
			{
				HCT0090058 = (int?)reader[120];
			}
			if (reader[121] != DBNull.Value)
			{
				HCT0090059 = (int?)reader[121];
			}
			if (reader[122] != DBNull.Value)
			{
				HCT0090060 = (int?)reader[122];
			}
			if (reader[123] != DBNull.Value)
			{
				HCT0090061 = (int?)reader[123];
			}
			if (reader[124] != DBNull.Value)
			{
				HCT0090062 = (int?)reader[124];
			}
			if (reader[125] != DBNull.Value)
			{
				HCT0090063 = (int?)reader[125];
			}
			if (reader[126] != DBNull.Value)
			{
				HCT0090064 = (int?)reader[126];
			}
			if (reader[127] != DBNull.Value)
			{
				HCT0090065 = (int?)reader[127];
			}
			if (reader[128] != DBNull.Value)
			{
				HCT0090066 = (int?)reader[128];
			}
			if (reader[129] != DBNull.Value)
			{
				HCT0090067 = (int?)reader[129];
			}
			if (reader[130] != DBNull.Value)
			{
				HCT0090068 = (int?)reader[130];
			}
			if (reader[131] != DBNull.Value)
			{
				HCT0090069 = (int?)reader[131];
			}
			if (reader[132] != DBNull.Value)
			{
				HCT0100001 = (int?)reader[132];
			}
			if (reader[133] != DBNull.Value)
			{
				HCT0100002 = (int?)reader[133];
			}
			if (reader[134] != DBNull.Value)
			{
				HCT0100003 = (int?)reader[134];
			}
			if (reader[135] != DBNull.Value)
			{
				HCT0100004 = (int?)reader[135];
			}
			if (reader[136] != DBNull.Value)
			{
				HCT0100005 = (int?)reader[136];
			}
			if (reader[137] != DBNull.Value)
			{
				HCT0100006 = (int?)reader[137];
			}
			if (reader[138] != DBNull.Value)
			{
				HCT0100007 = (int?)reader[138];
			}
			if (reader[139] != DBNull.Value)
			{
				HCT0100008 = (int?)reader[139];
			}
			if (reader[140] != DBNull.Value)
			{
				HCT0100009 = (int?)reader[140];
			}
			if (reader[141] != DBNull.Value)
			{
				HCT0100010 = (int?)reader[141];
			}
			if (reader[142] != DBNull.Value)
			{
				HCT0100011 = (int?)reader[142];
			}
			if (reader[143] != DBNull.Value)
			{
				HCT0100012 = (int?)reader[143];
			}
			if (reader[144] != DBNull.Value)
			{
				HCT0100013 = (int?)reader[144];
			}
			if (reader[145] != DBNull.Value)
			{
				HCT0110001 = (int?)reader[145];
			}
			if (reader[146] != DBNull.Value)
			{
				HCT0110002 = (int?)reader[146];
			}
			if (reader[147] != DBNull.Value)
			{
				HCT0110003 = (int?)reader[147];
			}
			if (reader[148] != DBNull.Value)
			{
				HCT0110004 = (int?)reader[148];
			}
			if (reader[149] != DBNull.Value)
			{
				HCT0110005 = (int?)reader[149];
			}
			if (reader[150] != DBNull.Value)
			{
				HCT0110006 = (int?)reader[150];
			}
			if (reader[151] != DBNull.Value)
			{
				HCT0110007 = (int?)reader[151];
			}
			if (reader[152] != DBNull.Value)
			{
				HCT0110008 = (int?)reader[152];
			}
			if (reader[153] != DBNull.Value)
			{
				HCT0110009 = (int?)reader[153];
			}
			if (reader[154] != DBNull.Value)
			{
				HCT0110010 = (int?)reader[154];
			}
			if (reader[155] != DBNull.Value)
			{
				HCT0110011 = (int?)reader[155];
			}
			if (reader[156] != DBNull.Value)
			{
				HCT0110012 = (int?)reader[156];
			}
			if (reader[157] != DBNull.Value)
			{
				HCT0110013 = (int?)reader[157];
			}
			if (reader[158] != DBNull.Value)
			{
				HCT0120001 = (int?)reader[158];
			}
			if (reader[159] != DBNull.Value)
			{
				HCT0120002 = (int?)reader[159];
			}
			if (reader[160] != DBNull.Value)
			{
				HCT0120003 = (int?)reader[160];
			}
			if (reader[161] != DBNull.Value)
			{
				HCT0120004 = (int?)reader[161];
			}
			if (reader[162] != DBNull.Value)
			{
				HCT0120005 = (int?)reader[162];
			}
			if (reader[163] != DBNull.Value)
			{
				HCT0120006 = (int?)reader[163];
			}
			if (reader[164] != DBNull.Value)
			{
				HCT0120007 = (int?)reader[164];
			}
			if (reader[165] != DBNull.Value)
			{
				HCT0120008 = (int?)reader[165];
			}
			if (reader[166] != DBNull.Value)
			{
				HCT0120009 = (int?)reader[166];
			}
			if (reader[167] != DBNull.Value)
			{
				HCT0120010 = (int?)reader[167];
			}
			if (reader[168] != DBNull.Value)
			{
				HCT0120011 = (int?)reader[168];
			}
			if (reader[169] != DBNull.Value)
			{
				HCT0120012 = (int?)reader[169];
			}
			if (reader[170] != DBNull.Value)
			{
				HCT0120013 = (int?)reader[170];
			}
			if (reader[171] != DBNull.Value)
			{
				HCT0130001 = (int?)reader[171];
			}
			if (reader[172] != DBNull.Value)
			{
				HCT0130002 = (int?)reader[172];
			}
			if (reader[173] != DBNull.Value)
			{
				HCT0130003 = (int?)reader[173];
			}
			if (reader[174] != DBNull.Value)
			{
				HCT0140001 = (int?)reader[174];
			}
			if (reader[175] != DBNull.Value)
			{
				HCT0140002 = (int?)reader[175];
			}
			if (reader[176] != DBNull.Value)
			{
				HCT0140003 = (int?)reader[176];
			}
		}
		#endregion Constructors
	}
}
