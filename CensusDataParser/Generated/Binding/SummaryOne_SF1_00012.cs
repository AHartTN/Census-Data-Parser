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

	public class SummaryOne_SF1_00012 : BaseModel
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
		public int? P034F001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 6)]
		public int? P034F002 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 7)]
		public int? P034F003 { get; set; }

		[Display(Name = "Householder:", ShortName = "Householder:", Order = 8)]
		public int? P034F004 { get; set; }

		[Display(Name = "Male", ShortName = "Male", Order = 9)]
		public int? P034F005 { get; set; }

		[Display(Name = "Female", ShortName = "Female", Order = 10)]
		public int? P034F006 { get; set; }

		[Display(Name = "Spouse", ShortName = "Spouse", Order = 11)]
		public int? P034F007 { get; set; }

		[Display(Name = "Parent", ShortName = "Parent", Order = 12)]
		public int? P034F008 { get; set; }

		[Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 13)]
		public int? P034F009 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 14)]
		public int? P034F010 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 15)]
		public int? P034F011 { get; set; }

		[Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 16)]
		public int? P034F012 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 17)]
		public int? P034F013 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 18)]
		public int? P034F014 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 19)]
		public int? P034F015 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 20)]
		public int? P034F016 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 21)]
		public int? P034F017 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 22)]
		public int? P034F018 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 23)]
		public int? P034F019 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 24)]
		public int? P034F020 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 25)]
		public int? P034F021 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 26)]
		public int? P034F022 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 27)]
		public int? P034G001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 28)]
		public int? P034G002 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 29)]
		public int? P034G003 { get; set; }

		[Display(Name = "Householder:", ShortName = "Householder:", Order = 30)]
		public int? P034G004 { get; set; }

		[Display(Name = "Male", ShortName = "Male", Order = 31)]
		public int? P034G005 { get; set; }

		[Display(Name = "Female", ShortName = "Female", Order = 32)]
		public int? P034G006 { get; set; }

		[Display(Name = "Spouse", ShortName = "Spouse", Order = 33)]
		public int? P034G007 { get; set; }

		[Display(Name = "Parent", ShortName = "Parent", Order = 34)]
		public int? P034G008 { get; set; }

		[Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 35)]
		public int? P034G009 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 36)]
		public int? P034G010 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 37)]
		public int? P034G011 { get; set; }

		[Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 38)]
		public int? P034G012 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 39)]
		public int? P034G013 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 40)]
		public int? P034G014 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 41)]
		public int? P034G015 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 42)]
		public int? P034G016 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 43)]
		public int? P034G017 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 44)]
		public int? P034G018 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 45)]
		public int? P034G019 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 46)]
		public int? P034G020 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 47)]
		public int? P034G021 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 48)]
		public int? P034G022 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 49)]
		public int? P034H001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 50)]
		public int? P034H002 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 51)]
		public int? P034H003 { get; set; }

		[Display(Name = "Householder:", ShortName = "Householder:", Order = 52)]
		public int? P034H004 { get; set; }

		[Display(Name = "Male", ShortName = "Male", Order = 53)]
		public int? P034H005 { get; set; }

		[Display(Name = "Female", ShortName = "Female", Order = 54)]
		public int? P034H006 { get; set; }

		[Display(Name = "Spouse", ShortName = "Spouse", Order = 55)]
		public int? P034H007 { get; set; }

		[Display(Name = "Parent", ShortName = "Parent", Order = 56)]
		public int? P034H008 { get; set; }

		[Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 57)]
		public int? P034H009 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 58)]
		public int? P034H010 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 59)]
		public int? P034H011 { get; set; }

		[Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 60)]
		public int? P034H012 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 61)]
		public int? P034H013 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 62)]
		public int? P034H014 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 63)]
		public int? P034H015 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 64)]
		public int? P034H016 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 65)]
		public int? P034H017 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 66)]
		public int? P034H018 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 67)]
		public int? P034H019 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 68)]
		public int? P034H020 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 69)]
		public int? P034H021 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 70)]
		public int? P034H022 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 71)]
		public int? P034I001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 72)]
		public int? P034I002 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 73)]
		public int? P034I003 { get; set; }

		[Display(Name = "Householder:", ShortName = "Householder:", Order = 74)]
		public int? P034I004 { get; set; }

		[Display(Name = "Male", ShortName = "Male", Order = 75)]
		public int? P034I005 { get; set; }

		[Display(Name = "Female", ShortName = "Female", Order = 76)]
		public int? P034I006 { get; set; }

		[Display(Name = "Spouse", ShortName = "Spouse", Order = 77)]
		public int? P034I007 { get; set; }

		[Display(Name = "Parent", ShortName = "Parent", Order = 78)]
		public int? P034I008 { get; set; }

		[Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 79)]
		public int? P034I009 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 80)]
		public int? P034I010 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 81)]
		public int? P034I011 { get; set; }

		[Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 82)]
		public int? P034I012 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 83)]
		public int? P034I013 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 84)]
		public int? P034I014 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 85)]
		public int? P034I015 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 86)]
		public int? P034I016 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 87)]
		public int? P034I017 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 88)]
		public int? P034I018 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 89)]
		public int? P034I019 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 90)]
		public int? P034I020 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 91)]
		public int? P034I021 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 92)]
		public int? P034I022 { get; set; }

		[Display(Name = "Total", ShortName = "Total", Order = 93)]
		public int? P035A001 { get; set; }

		[Display(Name = "Total", ShortName = "Total", Order = 94)]
		public int? P035B001 { get; set; }

		[Display(Name = "Total", ShortName = "Total", Order = 95)]
		public int? P035C001 { get; set; }

		[Display(Name = "Total", ShortName = "Total", Order = 96)]
		public int? P035D001 { get; set; }

		[Display(Name = "Total", ShortName = "Total", Order = 97)]
		public int? P035E001 { get; set; }

		[Display(Name = "Total", ShortName = "Total", Order = 98)]
		public int? P035F001 { get; set; }

		[Display(Name = "Total", ShortName = "Total", Order = 99)]
		public int? P035G001 { get; set; }

		[Display(Name = "Total", ShortName = "Total", Order = 100)]
		public int? P035H001 { get; set; }

		[Display(Name = "Total", ShortName = "Total", Order = 101)]
		public int? P035I001 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 102)]
		public int? P036A001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 103)]
		public int? P036A002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 104)]
		public int? P036A003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 105)]
		public int? P036B001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 106)]
		public int? P036B002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 107)]
		public int? P036B003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 108)]
		public int? P036C001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 109)]
		public int? P036C002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 110)]
		public int? P036C003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 111)]
		public int? P036D001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 112)]
		public int? P036D002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 113)]
		public int? P036D003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 114)]
		public int? P036E001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 115)]
		public int? P036E002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 116)]
		public int? P036E003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 117)]
		public int? P036F001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 118)]
		public int? P036F002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 119)]
		public int? P036F003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 120)]
		public int? P036G001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 121)]
		public int? P036G002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 122)]
		public int? P036G003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 123)]
		public int? P036H001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 124)]
		public int? P036H002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 125)]
		public int? P036H003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 126)]
		public int? P036I001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 127)]
		public int? P036I002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 128)]
		public int? P036I003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 129)]
		public decimal? P037A001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 130)]
		public decimal? P037A002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 131)]
		public decimal? P037A003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 132)]
		public decimal? P037B001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 133)]
		public decimal? P037B002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 134)]
		public decimal? P037B003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 135)]
		public decimal? P037C001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 136)]
		public decimal? P037C002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 137)]
		public decimal? P037C003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 138)]
		public decimal? P037D001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 139)]
		public decimal? P037D002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 140)]
		public decimal? P037D003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 141)]
		public decimal? P037E001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 142)]
		public decimal? P037E002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 143)]
		public decimal? P037E003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 144)]
		public decimal? P037F001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 145)]
		public decimal? P037F002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 146)]
		public decimal? P037F003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 147)]
		public decimal? P037G001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 148)]
		public decimal? P037G002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 149)]
		public decimal? P037G003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 150)]
		public decimal? P037H001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 151)]
		public decimal? P037H002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 152)]
		public decimal? P037H003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 153)]
		public decimal? P037I001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 154)]
		public decimal? P037I002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 155)]
		public decimal? P037I003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 156)]
		public int? P038A001 { get; set; }

		[Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 157)]
		public int? P038A002 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 158)]
		public int? P038A003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 159)]
		public int? P038A004 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 160)]
		public int? P038A005 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 161)]
		public int? P038A006 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 162)]
		public int? P038A007 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 163)]
		public int? P038A008 { get; set; }

		[Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 164)]
		public int? P038A009 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 165)]
		public int? P038A010 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 166)]
		public int? P038A011 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 167)]
		public int? P038A012 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 168)]
		public int? P038A013 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 169)]
		public int? P038A014 { get; set; }

		[Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 170)]
		public int? P038A015 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 171)]
		public int? P038A016 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 172)]
		public int? P038A017 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 173)]
		public int? P038A018 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 174)]
		public int? P038A019 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 175)]
		public int? P038A020 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 176)]
		public int? P038B001 { get; set; }

		[Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 177)]
		public int? P038B002 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 178)]
		public int? P038B003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 179)]
		public int? P038B004 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 180)]
		public int? P038B005 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 181)]
		public int? P038B006 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 182)]
		public int? P038B007 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 183)]
		public int? P038B008 { get; set; }

		[Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 184)]
		public int? P038B009 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 185)]
		public int? P038B010 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 186)]
		public int? P038B011 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 187)]
		public int? P038B012 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 188)]
		public int? P038B013 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 189)]
		public int? P038B014 { get; set; }

		[Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 190)]
		public int? P038B015 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 191)]
		public int? P038B016 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 192)]
		public int? P038B017 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 193)]
		public int? P038B018 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 194)]
		public int? P038B019 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 195)]
		public int? P038B020 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 196)]
		public int? P038C001 { get; set; }

		[Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 197)]
		public int? P038C002 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 198)]
		public int? P038C003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 199)]
		public int? P038C004 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 200)]
		public int? P038C005 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 201)]
		public int? P038C006 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 202)]
		public int? P038C007 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 203)]
		public int? P038C008 { get; set; }

		[Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 204)]
		public int? P038C009 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 205)]
		public int? P038C010 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 206)]
		public int? P038C011 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 207)]
		public int? P038C012 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 208)]
		public int? P038C013 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 209)]
		public int? P038C014 { get; set; }

		[Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 210)]
		public int? P038C015 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 211)]
		public int? P038C016 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 212)]
		public int? P038C017 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 213)]
		public int? P038C018 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 214)]
		public int? P038C019 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 215)]
		public int? P038C020 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 216)]
		public int? P038D001 { get; set; }

		[Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 217)]
		public int? P038D002 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 218)]
		public int? P038D003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 219)]
		public int? P038D004 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 220)]
		public int? P038D005 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 221)]
		public int? P038D006 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 222)]
		public int? P038D007 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 223)]
		public int? P038D008 { get; set; }

		[Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 224)]
		public int? P038D009 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 225)]
		public int? P038D010 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 226)]
		public int? P038D011 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 227)]
		public int? P038D012 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 228)]
		public int? P038D013 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 229)]
		public int? P038D014 { get; set; }

		[Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 230)]
		public int? P038D015 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 231)]
		public int? P038D016 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 232)]
		public int? P038D017 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 233)]
		public int? P038D018 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 234)]
		public int? P038D019 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 235)]
		public int? P038D020 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 236)]
		public int? P038E001 { get; set; }

		[Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 237)]
		public int? P038E002 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 238)]
		public int? P038E003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 239)]
		public int? P038E004 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 240)]
		public int? P038E005 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 241)]
		public int? P038E006 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 242)]
		public int? P038E007 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 243)]
		public int? P038E008 { get; set; }

		[Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 244)]
		public int? P038E009 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 245)]
		public int? P038E010 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 246)]
		public int? P038E011 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 247)]
		public int? P038E012 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 248)]
		public int? P038E013 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 249)]
		public int? P038E014 { get; set; }

		[Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 250)]
		public int? P038E015 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 251)]
		public int? P038E016 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 252)]
		public int? P038E017 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 253)]
		public int? P038E018 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 254)]
		public int? P038E019 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 255)]
		public int? P038E020 { get; set; }
		#endregion Properties

		#region Constructors
		public SummaryOne_SF1_00012() { }

		public SummaryOne_SF1_00012(string csvLine) : base(csvLine) { }

		public SummaryOne_SF1_00012(string[] values) : base(values) { }

		public SummaryOne_SF1_00012(OleDbDataReader reader)
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
				P034F001 = (int?)reader[5];
			}
			if(reader[6] != DBNull.Value)
			{
				P034F002 = (int?)reader[6];
			}
			if(reader[7] != DBNull.Value)
			{
				P034F003 = (int?)reader[7];
			}
			if(reader[8] != DBNull.Value)
			{
				P034F004 = (int?)reader[8];
			}
			if(reader[9] != DBNull.Value)
			{
				P034F005 = (int?)reader[9];
			}
			if(reader[10] != DBNull.Value)
			{
				P034F006 = (int?)reader[10];
			}
			if(reader[11] != DBNull.Value)
			{
				P034F007 = (int?)reader[11];
			}
			if(reader[12] != DBNull.Value)
			{
				P034F008 = (int?)reader[12];
			}
			if(reader[13] != DBNull.Value)
			{
				P034F009 = (int?)reader[13];
			}
			if(reader[14] != DBNull.Value)
			{
				P034F010 = (int?)reader[14];
			}
			if(reader[15] != DBNull.Value)
			{
				P034F011 = (int?)reader[15];
			}
			if(reader[16] != DBNull.Value)
			{
				P034F012 = (int?)reader[16];
			}
			if(reader[17] != DBNull.Value)
			{
				P034F013 = (int?)reader[17];
			}
			if(reader[18] != DBNull.Value)
			{
				P034F014 = (int?)reader[18];
			}
			if(reader[19] != DBNull.Value)
			{
				P034F015 = (int?)reader[19];
			}
			if(reader[20] != DBNull.Value)
			{
				P034F016 = (int?)reader[20];
			}
			if(reader[21] != DBNull.Value)
			{
				P034F017 = (int?)reader[21];
			}
			if(reader[22] != DBNull.Value)
			{
				P034F018 = (int?)reader[22];
			}
			if(reader[23] != DBNull.Value)
			{
				P034F019 = (int?)reader[23];
			}
			if(reader[24] != DBNull.Value)
			{
				P034F020 = (int?)reader[24];
			}
			if(reader[25] != DBNull.Value)
			{
				P034F021 = (int?)reader[25];
			}
			if(reader[26] != DBNull.Value)
			{
				P034F022 = (int?)reader[26];
			}
			if(reader[27] != DBNull.Value)
			{
				P034G001 = (int?)reader[27];
			}
			if(reader[28] != DBNull.Value)
			{
				P034G002 = (int?)reader[28];
			}
			if(reader[29] != DBNull.Value)
			{
				P034G003 = (int?)reader[29];
			}
			if(reader[30] != DBNull.Value)
			{
				P034G004 = (int?)reader[30];
			}
			if(reader[31] != DBNull.Value)
			{
				P034G005 = (int?)reader[31];
			}
			if(reader[32] != DBNull.Value)
			{
				P034G006 = (int?)reader[32];
			}
			if(reader[33] != DBNull.Value)
			{
				P034G007 = (int?)reader[33];
			}
			if(reader[34] != DBNull.Value)
			{
				P034G008 = (int?)reader[34];
			}
			if(reader[35] != DBNull.Value)
			{
				P034G009 = (int?)reader[35];
			}
			if(reader[36] != DBNull.Value)
			{
				P034G010 = (int?)reader[36];
			}
			if(reader[37] != DBNull.Value)
			{
				P034G011 = (int?)reader[37];
			}
			if(reader[38] != DBNull.Value)
			{
				P034G012 = (int?)reader[38];
			}
			if(reader[39] != DBNull.Value)
			{
				P034G013 = (int?)reader[39];
			}
			if(reader[40] != DBNull.Value)
			{
				P034G014 = (int?)reader[40];
			}
			if(reader[41] != DBNull.Value)
			{
				P034G015 = (int?)reader[41];
			}
			if(reader[42] != DBNull.Value)
			{
				P034G016 = (int?)reader[42];
			}
			if(reader[43] != DBNull.Value)
			{
				P034G017 = (int?)reader[43];
			}
			if(reader[44] != DBNull.Value)
			{
				P034G018 = (int?)reader[44];
			}
			if(reader[45] != DBNull.Value)
			{
				P034G019 = (int?)reader[45];
			}
			if(reader[46] != DBNull.Value)
			{
				P034G020 = (int?)reader[46];
			}
			if(reader[47] != DBNull.Value)
			{
				P034G021 = (int?)reader[47];
			}
			if(reader[48] != DBNull.Value)
			{
				P034G022 = (int?)reader[48];
			}
			if(reader[49] != DBNull.Value)
			{
				P034H001 = (int?)reader[49];
			}
			if(reader[50] != DBNull.Value)
			{
				P034H002 = (int?)reader[50];
			}
			if(reader[51] != DBNull.Value)
			{
				P034H003 = (int?)reader[51];
			}
			if(reader[52] != DBNull.Value)
			{
				P034H004 = (int?)reader[52];
			}
			if(reader[53] != DBNull.Value)
			{
				P034H005 = (int?)reader[53];
			}
			if(reader[54] != DBNull.Value)
			{
				P034H006 = (int?)reader[54];
			}
			if(reader[55] != DBNull.Value)
			{
				P034H007 = (int?)reader[55];
			}
			if(reader[56] != DBNull.Value)
			{
				P034H008 = (int?)reader[56];
			}
			if(reader[57] != DBNull.Value)
			{
				P034H009 = (int?)reader[57];
			}
			if(reader[58] != DBNull.Value)
			{
				P034H010 = (int?)reader[58];
			}
			if(reader[59] != DBNull.Value)
			{
				P034H011 = (int?)reader[59];
			}
			if(reader[60] != DBNull.Value)
			{
				P034H012 = (int?)reader[60];
			}
			if(reader[61] != DBNull.Value)
			{
				P034H013 = (int?)reader[61];
			}
			if(reader[62] != DBNull.Value)
			{
				P034H014 = (int?)reader[62];
			}
			if(reader[63] != DBNull.Value)
			{
				P034H015 = (int?)reader[63];
			}
			if(reader[64] != DBNull.Value)
			{
				P034H016 = (int?)reader[64];
			}
			if(reader[65] != DBNull.Value)
			{
				P034H017 = (int?)reader[65];
			}
			if(reader[66] != DBNull.Value)
			{
				P034H018 = (int?)reader[66];
			}
			if(reader[67] != DBNull.Value)
			{
				P034H019 = (int?)reader[67];
			}
			if(reader[68] != DBNull.Value)
			{
				P034H020 = (int?)reader[68];
			}
			if(reader[69] != DBNull.Value)
			{
				P034H021 = (int?)reader[69];
			}
			if(reader[70] != DBNull.Value)
			{
				P034H022 = (int?)reader[70];
			}
			if(reader[71] != DBNull.Value)
			{
				P034I001 = (int?)reader[71];
			}
			if(reader[72] != DBNull.Value)
			{
				P034I002 = (int?)reader[72];
			}
			if(reader[73] != DBNull.Value)
			{
				P034I003 = (int?)reader[73];
			}
			if(reader[74] != DBNull.Value)
			{
				P034I004 = (int?)reader[74];
			}
			if(reader[75] != DBNull.Value)
			{
				P034I005 = (int?)reader[75];
			}
			if(reader[76] != DBNull.Value)
			{
				P034I006 = (int?)reader[76];
			}
			if(reader[77] != DBNull.Value)
			{
				P034I007 = (int?)reader[77];
			}
			if(reader[78] != DBNull.Value)
			{
				P034I008 = (int?)reader[78];
			}
			if(reader[79] != DBNull.Value)
			{
				P034I009 = (int?)reader[79];
			}
			if(reader[80] != DBNull.Value)
			{
				P034I010 = (int?)reader[80];
			}
			if(reader[81] != DBNull.Value)
			{
				P034I011 = (int?)reader[81];
			}
			if(reader[82] != DBNull.Value)
			{
				P034I012 = (int?)reader[82];
			}
			if(reader[83] != DBNull.Value)
			{
				P034I013 = (int?)reader[83];
			}
			if(reader[84] != DBNull.Value)
			{
				P034I014 = (int?)reader[84];
			}
			if(reader[85] != DBNull.Value)
			{
				P034I015 = (int?)reader[85];
			}
			if(reader[86] != DBNull.Value)
			{
				P034I016 = (int?)reader[86];
			}
			if(reader[87] != DBNull.Value)
			{
				P034I017 = (int?)reader[87];
			}
			if(reader[88] != DBNull.Value)
			{
				P034I018 = (int?)reader[88];
			}
			if(reader[89] != DBNull.Value)
			{
				P034I019 = (int?)reader[89];
			}
			if(reader[90] != DBNull.Value)
			{
				P034I020 = (int?)reader[90];
			}
			if(reader[91] != DBNull.Value)
			{
				P034I021 = (int?)reader[91];
			}
			if(reader[92] != DBNull.Value)
			{
				P034I022 = (int?)reader[92];
			}
			if(reader[93] != DBNull.Value)
			{
				P035A001 = (int?)reader[93];
			}
			if(reader[94] != DBNull.Value)
			{
				P035B001 = (int?)reader[94];
			}
			if(reader[95] != DBNull.Value)
			{
				P035C001 = (int?)reader[95];
			}
			if(reader[96] != DBNull.Value)
			{
				P035D001 = (int?)reader[96];
			}
			if(reader[97] != DBNull.Value)
			{
				P035E001 = (int?)reader[97];
			}
			if(reader[98] != DBNull.Value)
			{
				P035F001 = (int?)reader[98];
			}
			if(reader[99] != DBNull.Value)
			{
				P035G001 = (int?)reader[99];
			}
			if(reader[100] != DBNull.Value)
			{
				P035H001 = (int?)reader[100];
			}
			if(reader[101] != DBNull.Value)
			{
				P035I001 = (int?)reader[101];
			}
			if(reader[102] != DBNull.Value)
			{
				P036A001 = (int?)reader[102];
			}
			if(reader[103] != DBNull.Value)
			{
				P036A002 = (int?)reader[103];
			}
			if(reader[104] != DBNull.Value)
			{
				P036A003 = (int?)reader[104];
			}
			if(reader[105] != DBNull.Value)
			{
				P036B001 = (int?)reader[105];
			}
			if(reader[106] != DBNull.Value)
			{
				P036B002 = (int?)reader[106];
			}
			if(reader[107] != DBNull.Value)
			{
				P036B003 = (int?)reader[107];
			}
			if(reader[108] != DBNull.Value)
			{
				P036C001 = (int?)reader[108];
			}
			if(reader[109] != DBNull.Value)
			{
				P036C002 = (int?)reader[109];
			}
			if(reader[110] != DBNull.Value)
			{
				P036C003 = (int?)reader[110];
			}
			if(reader[111] != DBNull.Value)
			{
				P036D001 = (int?)reader[111];
			}
			if(reader[112] != DBNull.Value)
			{
				P036D002 = (int?)reader[112];
			}
			if(reader[113] != DBNull.Value)
			{
				P036D003 = (int?)reader[113];
			}
			if(reader[114] != DBNull.Value)
			{
				P036E001 = (int?)reader[114];
			}
			if(reader[115] != DBNull.Value)
			{
				P036E002 = (int?)reader[115];
			}
			if(reader[116] != DBNull.Value)
			{
				P036E003 = (int?)reader[116];
			}
			if(reader[117] != DBNull.Value)
			{
				P036F001 = (int?)reader[117];
			}
			if(reader[118] != DBNull.Value)
			{
				P036F002 = (int?)reader[118];
			}
			if(reader[119] != DBNull.Value)
			{
				P036F003 = (int?)reader[119];
			}
			if(reader[120] != DBNull.Value)
			{
				P036G001 = (int?)reader[120];
			}
			if(reader[121] != DBNull.Value)
			{
				P036G002 = (int?)reader[121];
			}
			if(reader[122] != DBNull.Value)
			{
				P036G003 = (int?)reader[122];
			}
			if(reader[123] != DBNull.Value)
			{
				P036H001 = (int?)reader[123];
			}
			if(reader[124] != DBNull.Value)
			{
				P036H002 = (int?)reader[124];
			}
			if(reader[125] != DBNull.Value)
			{
				P036H003 = (int?)reader[125];
			}
			if(reader[126] != DBNull.Value)
			{
				P036I001 = (int?)reader[126];
			}
			if(reader[127] != DBNull.Value)
			{
				P036I002 = (int?)reader[127];
			}
			if(reader[128] != DBNull.Value)
			{
				P036I003 = (int?)reader[128];
			}
			if(reader[129] != DBNull.Value)
			{
				P037A001 = (decimal?)reader[129];
			}
			if(reader[130] != DBNull.Value)
			{
				P037A002 = (decimal?)reader[130];
			}
			if(reader[131] != DBNull.Value)
			{
				P037A003 = (decimal?)reader[131];
			}
			if(reader[132] != DBNull.Value)
			{
				P037B001 = (decimal?)reader[132];
			}
			if(reader[133] != DBNull.Value)
			{
				P037B002 = (decimal?)reader[133];
			}
			if(reader[134] != DBNull.Value)
			{
				P037B003 = (decimal?)reader[134];
			}
			if(reader[135] != DBNull.Value)
			{
				P037C001 = (decimal?)reader[135];
			}
			if(reader[136] != DBNull.Value)
			{
				P037C002 = (decimal?)reader[136];
			}
			if(reader[137] != DBNull.Value)
			{
				P037C003 = (decimal?)reader[137];
			}
			if(reader[138] != DBNull.Value)
			{
				P037D001 = (decimal?)reader[138];
			}
			if(reader[139] != DBNull.Value)
			{
				P037D002 = (decimal?)reader[139];
			}
			if(reader[140] != DBNull.Value)
			{
				P037D003 = (decimal?)reader[140];
			}
			if(reader[141] != DBNull.Value)
			{
				P037E001 = (decimal?)reader[141];
			}
			if(reader[142] != DBNull.Value)
			{
				P037E002 = (decimal?)reader[142];
			}
			if(reader[143] != DBNull.Value)
			{
				P037E003 = (decimal?)reader[143];
			}
			if(reader[144] != DBNull.Value)
			{
				P037F001 = (decimal?)reader[144];
			}
			if(reader[145] != DBNull.Value)
			{
				P037F002 = (decimal?)reader[145];
			}
			if(reader[146] != DBNull.Value)
			{
				P037F003 = (decimal?)reader[146];
			}
			if(reader[147] != DBNull.Value)
			{
				P037G001 = (decimal?)reader[147];
			}
			if(reader[148] != DBNull.Value)
			{
				P037G002 = (decimal?)reader[148];
			}
			if(reader[149] != DBNull.Value)
			{
				P037G003 = (decimal?)reader[149];
			}
			if(reader[150] != DBNull.Value)
			{
				P037H001 = (decimal?)reader[150];
			}
			if(reader[151] != DBNull.Value)
			{
				P037H002 = (decimal?)reader[151];
			}
			if(reader[152] != DBNull.Value)
			{
				P037H003 = (decimal?)reader[152];
			}
			if(reader[153] != DBNull.Value)
			{
				P037I001 = (decimal?)reader[153];
			}
			if(reader[154] != DBNull.Value)
			{
				P037I002 = (decimal?)reader[154];
			}
			if(reader[155] != DBNull.Value)
			{
				P037I003 = (decimal?)reader[155];
			}
			if(reader[156] != DBNull.Value)
			{
				P038A001 = (int?)reader[156];
			}
			if(reader[157] != DBNull.Value)
			{
				P038A002 = (int?)reader[157];
			}
			if(reader[158] != DBNull.Value)
			{
				P038A003 = (int?)reader[158];
			}
			if(reader[159] != DBNull.Value)
			{
				P038A004 = (int?)reader[159];
			}
			if(reader[160] != DBNull.Value)
			{
				P038A005 = (int?)reader[160];
			}
			if(reader[161] != DBNull.Value)
			{
				P038A006 = (int?)reader[161];
			}
			if(reader[162] != DBNull.Value)
			{
				P038A007 = (int?)reader[162];
			}
			if(reader[163] != DBNull.Value)
			{
				P038A008 = (int?)reader[163];
			}
			if(reader[164] != DBNull.Value)
			{
				P038A009 = (int?)reader[164];
			}
			if(reader[165] != DBNull.Value)
			{
				P038A010 = (int?)reader[165];
			}
			if(reader[166] != DBNull.Value)
			{
				P038A011 = (int?)reader[166];
			}
			if(reader[167] != DBNull.Value)
			{
				P038A012 = (int?)reader[167];
			}
			if(reader[168] != DBNull.Value)
			{
				P038A013 = (int?)reader[168];
			}
			if(reader[169] != DBNull.Value)
			{
				P038A014 = (int?)reader[169];
			}
			if(reader[170] != DBNull.Value)
			{
				P038A015 = (int?)reader[170];
			}
			if(reader[171] != DBNull.Value)
			{
				P038A016 = (int?)reader[171];
			}
			if(reader[172] != DBNull.Value)
			{
				P038A017 = (int?)reader[172];
			}
			if(reader[173] != DBNull.Value)
			{
				P038A018 = (int?)reader[173];
			}
			if(reader[174] != DBNull.Value)
			{
				P038A019 = (int?)reader[174];
			}
			if(reader[175] != DBNull.Value)
			{
				P038A020 = (int?)reader[175];
			}
			if(reader[176] != DBNull.Value)
			{
				P038B001 = (int?)reader[176];
			}
			if(reader[177] != DBNull.Value)
			{
				P038B002 = (int?)reader[177];
			}
			if(reader[178] != DBNull.Value)
			{
				P038B003 = (int?)reader[178];
			}
			if(reader[179] != DBNull.Value)
			{
				P038B004 = (int?)reader[179];
			}
			if(reader[180] != DBNull.Value)
			{
				P038B005 = (int?)reader[180];
			}
			if(reader[181] != DBNull.Value)
			{
				P038B006 = (int?)reader[181];
			}
			if(reader[182] != DBNull.Value)
			{
				P038B007 = (int?)reader[182];
			}
			if(reader[183] != DBNull.Value)
			{
				P038B008 = (int?)reader[183];
			}
			if(reader[184] != DBNull.Value)
			{
				P038B009 = (int?)reader[184];
			}
			if(reader[185] != DBNull.Value)
			{
				P038B010 = (int?)reader[185];
			}
			if(reader[186] != DBNull.Value)
			{
				P038B011 = (int?)reader[186];
			}
			if(reader[187] != DBNull.Value)
			{
				P038B012 = (int?)reader[187];
			}
			if(reader[188] != DBNull.Value)
			{
				P038B013 = (int?)reader[188];
			}
			if(reader[189] != DBNull.Value)
			{
				P038B014 = (int?)reader[189];
			}
			if(reader[190] != DBNull.Value)
			{
				P038B015 = (int?)reader[190];
			}
			if(reader[191] != DBNull.Value)
			{
				P038B016 = (int?)reader[191];
			}
			if(reader[192] != DBNull.Value)
			{
				P038B017 = (int?)reader[192];
			}
			if(reader[193] != DBNull.Value)
			{
				P038B018 = (int?)reader[193];
			}
			if(reader[194] != DBNull.Value)
			{
				P038B019 = (int?)reader[194];
			}
			if(reader[195] != DBNull.Value)
			{
				P038B020 = (int?)reader[195];
			}
			if(reader[196] != DBNull.Value)
			{
				P038C001 = (int?)reader[196];
			}
			if(reader[197] != DBNull.Value)
			{
				P038C002 = (int?)reader[197];
			}
			if(reader[198] != DBNull.Value)
			{
				P038C003 = (int?)reader[198];
			}
			if(reader[199] != DBNull.Value)
			{
				P038C004 = (int?)reader[199];
			}
			if(reader[200] != DBNull.Value)
			{
				P038C005 = (int?)reader[200];
			}
			if(reader[201] != DBNull.Value)
			{
				P038C006 = (int?)reader[201];
			}
			if(reader[202] != DBNull.Value)
			{
				P038C007 = (int?)reader[202];
			}
			if(reader[203] != DBNull.Value)
			{
				P038C008 = (int?)reader[203];
			}
			if(reader[204] != DBNull.Value)
			{
				P038C009 = (int?)reader[204];
			}
			if(reader[205] != DBNull.Value)
			{
				P038C010 = (int?)reader[205];
			}
			if(reader[206] != DBNull.Value)
			{
				P038C011 = (int?)reader[206];
			}
			if(reader[207] != DBNull.Value)
			{
				P038C012 = (int?)reader[207];
			}
			if(reader[208] != DBNull.Value)
			{
				P038C013 = (int?)reader[208];
			}
			if(reader[209] != DBNull.Value)
			{
				P038C014 = (int?)reader[209];
			}
			if(reader[210] != DBNull.Value)
			{
				P038C015 = (int?)reader[210];
			}
			if(reader[211] != DBNull.Value)
			{
				P038C016 = (int?)reader[211];
			}
			if(reader[212] != DBNull.Value)
			{
				P038C017 = (int?)reader[212];
			}
			if(reader[213] != DBNull.Value)
			{
				P038C018 = (int?)reader[213];
			}
			if(reader[214] != DBNull.Value)
			{
				P038C019 = (int?)reader[214];
			}
			if(reader[215] != DBNull.Value)
			{
				P038C020 = (int?)reader[215];
			}
			if(reader[216] != DBNull.Value)
			{
				P038D001 = (int?)reader[216];
			}
			if(reader[217] != DBNull.Value)
			{
				P038D002 = (int?)reader[217];
			}
			if(reader[218] != DBNull.Value)
			{
				P038D003 = (int?)reader[218];
			}
			if(reader[219] != DBNull.Value)
			{
				P038D004 = (int?)reader[219];
			}
			if(reader[220] != DBNull.Value)
			{
				P038D005 = (int?)reader[220];
			}
			if(reader[221] != DBNull.Value)
			{
				P038D006 = (int?)reader[221];
			}
			if(reader[222] != DBNull.Value)
			{
				P038D007 = (int?)reader[222];
			}
			if(reader[223] != DBNull.Value)
			{
				P038D008 = (int?)reader[223];
			}
			if(reader[224] != DBNull.Value)
			{
				P038D009 = (int?)reader[224];
			}
			if(reader[225] != DBNull.Value)
			{
				P038D010 = (int?)reader[225];
			}
			if(reader[226] != DBNull.Value)
			{
				P038D011 = (int?)reader[226];
			}
			if(reader[227] != DBNull.Value)
			{
				P038D012 = (int?)reader[227];
			}
			if(reader[228] != DBNull.Value)
			{
				P038D013 = (int?)reader[228];
			}
			if(reader[229] != DBNull.Value)
			{
				P038D014 = (int?)reader[229];
			}
			if(reader[230] != DBNull.Value)
			{
				P038D015 = (int?)reader[230];
			}
			if(reader[231] != DBNull.Value)
			{
				P038D016 = (int?)reader[231];
			}
			if(reader[232] != DBNull.Value)
			{
				P038D017 = (int?)reader[232];
			}
			if(reader[233] != DBNull.Value)
			{
				P038D018 = (int?)reader[233];
			}
			if(reader[234] != DBNull.Value)
			{
				P038D019 = (int?)reader[234];
			}
			if(reader[235] != DBNull.Value)
			{
				P038D020 = (int?)reader[235];
			}
			if(reader[236] != DBNull.Value)
			{
				P038E001 = (int?)reader[236];
			}
			if(reader[237] != DBNull.Value)
			{
				P038E002 = (int?)reader[237];
			}
			if(reader[238] != DBNull.Value)
			{
				P038E003 = (int?)reader[238];
			}
			if(reader[239] != DBNull.Value)
			{
				P038E004 = (int?)reader[239];
			}
			if(reader[240] != DBNull.Value)
			{
				P038E005 = (int?)reader[240];
			}
			if(reader[241] != DBNull.Value)
			{
				P038E006 = (int?)reader[241];
			}
			if(reader[242] != DBNull.Value)
			{
				P038E007 = (int?)reader[242];
			}
			if(reader[243] != DBNull.Value)
			{
				P038E008 = (int?)reader[243];
			}
			if(reader[244] != DBNull.Value)
			{
				P038E009 = (int?)reader[244];
			}
			if(reader[245] != DBNull.Value)
			{
				P038E010 = (int?)reader[245];
			}
			if(reader[246] != DBNull.Value)
			{
				P038E011 = (int?)reader[246];
			}
			if(reader[247] != DBNull.Value)
			{
				P038E012 = (int?)reader[247];
			}
			if(reader[248] != DBNull.Value)
			{
				P038E013 = (int?)reader[248];
			}
			if(reader[249] != DBNull.Value)
			{
				P038E014 = (int?)reader[249];
			}
			if(reader[250] != DBNull.Value)
			{
				P038E015 = (int?)reader[250];
			}
			if(reader[251] != DBNull.Value)
			{
				P038E016 = (int?)reader[251];
			}
			if(reader[252] != DBNull.Value)
			{
				P038E017 = (int?)reader[252];
			}
			if(reader[253] != DBNull.Value)
			{
				P038E018 = (int?)reader[253];
			}
			if(reader[254] != DBNull.Value)
			{
				P038E019 = (int?)reader[254];
			}
			if(reader[255] != DBNull.Value)
			{
				P038E020 = (int?)reader[255];
			}
		}
		#endregion Constructors
	}
}
