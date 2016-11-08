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
	using Models;
	#endregion Using Directives

	public class SF1CongressionalDistricts113_SF1_00013 : BaseModel
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
		public int? P038F001 { get; set; }

		[Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 6)]
		public int? P038F002 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 7)]
		public int? P038F003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 8)]
		public int? P038F004 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 9)]
		public int? P038F005 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 10)]
		public int? P038F006 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 11)]
		public int? P038F007 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 12)]
		public int? P038F008 { get; set; }

		[Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 13)]
		public int? P038F009 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 14)]
		public int? P038F010 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 15)]
		public int? P038F011 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 16)]
		public int? P038F012 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 17)]
		public int? P038F013 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 18)]
		public int? P038F014 { get; set; }

		[Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 19)]
		public int? P038F015 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 20)]
		public int? P038F016 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 21)]
		public int? P038F017 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 22)]
		public int? P038F018 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 23)]
		public int? P038F019 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 24)]
		public int? P038F020 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 25)]
		public int? P038G001 { get; set; }

		[Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 26)]
		public int? P038G002 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 27)]
		public int? P038G003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 28)]
		public int? P038G004 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 29)]
		public int? P038G005 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 30)]
		public int? P038G006 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 31)]
		public int? P038G007 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 32)]
		public int? P038G008 { get; set; }

		[Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 33)]
		public int? P038G009 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 34)]
		public int? P038G010 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 35)]
		public int? P038G011 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 36)]
		public int? P038G012 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 37)]
		public int? P038G013 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 38)]
		public int? P038G014 { get; set; }

		[Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 39)]
		public int? P038G015 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 40)]
		public int? P038G016 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 41)]
		public int? P038G017 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 42)]
		public int? P038G018 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 43)]
		public int? P038G019 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 44)]
		public int? P038G020 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 45)]
		public int? P038H001 { get; set; }

		[Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 46)]
		public int? P038H002 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 47)]
		public int? P038H003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 48)]
		public int? P038H004 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 49)]
		public int? P038H005 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 50)]
		public int? P038H006 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 51)]
		public int? P038H007 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 52)]
		public int? P038H008 { get; set; }

		[Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 53)]
		public int? P038H009 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 54)]
		public int? P038H010 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 55)]
		public int? P038H011 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 56)]
		public int? P038H012 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 57)]
		public int? P038H013 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 58)]
		public int? P038H014 { get; set; }

		[Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 59)]
		public int? P038H015 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 60)]
		public int? P038H016 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 61)]
		public int? P038H017 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 62)]
		public int? P038H018 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 63)]
		public int? P038H019 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 64)]
		public int? P038H020 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 65)]
		public int? P038I001 { get; set; }

		[Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 66)]
		public int? P038I002 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 67)]
		public int? P038I003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 68)]
		public int? P038I004 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 69)]
		public int? P038I005 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 70)]
		public int? P038I006 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 71)]
		public int? P038I007 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 72)]
		public int? P038I008 { get; set; }

		[Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 73)]
		public int? P038I009 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 74)]
		public int? P038I010 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 75)]
		public int? P038I011 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 76)]
		public int? P038I012 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 77)]
		public int? P038I013 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 78)]
		public int? P038I014 { get; set; }

		[Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 79)]
		public int? P038I015 { get; set; }

		[Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 80)]
		public int? P038I016 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 81)]
		public int? P038I017 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 82)]
		public int? P038I018 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 83)]
		public int? P038I019 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 84)]
		public int? P038I020 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 85)]
		public int? P039A001 { get; set; }

		[Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 86)]
		public int? P039A002 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 87)]
		public int? P039A003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 88)]
		public int? P039A004 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 89)]
		public int? P039A005 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 90)]
		public int? P039A006 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 91)]
		public int? P039A007 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 92)]
		public int? P039A008 { get; set; }

		[Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 93)]
		public int? P039A009 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 94)]
		public int? P039A010 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 95)]
		public int? P039A011 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 96)]
		public int? P039A012 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 97)]
		public int? P039A013 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 98)]
		public int? P039A014 { get; set; }

		[Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 99)]
		public int? P039A015 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 100)]
		public int? P039A016 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 101)]
		public int? P039A017 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 102)]
		public int? P039A018 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 103)]
		public int? P039A019 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 104)]
		public int? P039A020 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 105)]
		public int? P039B001 { get; set; }

		[Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 106)]
		public int? P039B002 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 107)]
		public int? P039B003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 108)]
		public int? P039B004 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 109)]
		public int? P039B005 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 110)]
		public int? P039B006 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 111)]
		public int? P039B007 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 112)]
		public int? P039B008 { get; set; }

		[Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 113)]
		public int? P039B009 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 114)]
		public int? P039B010 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 115)]
		public int? P039B011 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 116)]
		public int? P039B012 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 117)]
		public int? P039B013 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 118)]
		public int? P039B014 { get; set; }

		[Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 119)]
		public int? P039B015 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 120)]
		public int? P039B016 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 121)]
		public int? P039B017 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 122)]
		public int? P039B018 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 123)]
		public int? P039B019 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 124)]
		public int? P039B020 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 125)]
		public int? P039C001 { get; set; }

		[Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 126)]
		public int? P039C002 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 127)]
		public int? P039C003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 128)]
		public int? P039C004 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 129)]
		public int? P039C005 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 130)]
		public int? P039C006 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 131)]
		public int? P039C007 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 132)]
		public int? P039C008 { get; set; }

		[Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 133)]
		public int? P039C009 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 134)]
		public int? P039C010 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 135)]
		public int? P039C011 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 136)]
		public int? P039C012 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 137)]
		public int? P039C013 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 138)]
		public int? P039C014 { get; set; }

		[Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 139)]
		public int? P039C015 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 140)]
		public int? P039C016 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 141)]
		public int? P039C017 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 142)]
		public int? P039C018 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 143)]
		public int? P039C019 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 144)]
		public int? P039C020 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 145)]
		public int? P039D001 { get; set; }

		[Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 146)]
		public int? P039D002 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 147)]
		public int? P039D003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 148)]
		public int? P039D004 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 149)]
		public int? P039D005 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 150)]
		public int? P039D006 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 151)]
		public int? P039D007 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 152)]
		public int? P039D008 { get; set; }

		[Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 153)]
		public int? P039D009 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 154)]
		public int? P039D010 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 155)]
		public int? P039D011 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 156)]
		public int? P039D012 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 157)]
		public int? P039D013 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 158)]
		public int? P039D014 { get; set; }

		[Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 159)]
		public int? P039D015 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 160)]
		public int? P039D016 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 161)]
		public int? P039D017 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 162)]
		public int? P039D018 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 163)]
		public int? P039D019 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 164)]
		public int? P039D020 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 165)]
		public int? P039E001 { get; set; }

		[Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 166)]
		public int? P039E002 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 167)]
		public int? P039E003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 168)]
		public int? P039E004 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 169)]
		public int? P039E005 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 170)]
		public int? P039E006 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 171)]
		public int? P039E007 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 172)]
		public int? P039E008 { get; set; }

		[Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 173)]
		public int? P039E009 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 174)]
		public int? P039E010 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 175)]
		public int? P039E011 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 176)]
		public int? P039E012 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 177)]
		public int? P039E013 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 178)]
		public int? P039E014 { get; set; }

		[Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 179)]
		public int? P039E015 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 180)]
		public int? P039E016 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 181)]
		public int? P039E017 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 182)]
		public int? P039E018 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 183)]
		public int? P039E019 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 184)]
		public int? P039E020 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 185)]
		public int? P039F001 { get; set; }

		[Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 186)]
		public int? P039F002 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 187)]
		public int? P039F003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 188)]
		public int? P039F004 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 189)]
		public int? P039F005 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 190)]
		public int? P039F006 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 191)]
		public int? P039F007 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 192)]
		public int? P039F008 { get; set; }

		[Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 193)]
		public int? P039F009 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 194)]
		public int? P039F010 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 195)]
		public int? P039F011 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 196)]
		public int? P039F012 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 197)]
		public int? P039F013 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 198)]
		public int? P039F014 { get; set; }

		[Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 199)]
		public int? P039F015 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 200)]
		public int? P039F016 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 201)]
		public int? P039F017 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 202)]
		public int? P039F018 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 203)]
		public int? P039F019 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 204)]
		public int? P039F020 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 205)]
		public int? P039G001 { get; set; }

		[Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 206)]
		public int? P039G002 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 207)]
		public int? P039G003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 208)]
		public int? P039G004 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 209)]
		public int? P039G005 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 210)]
		public int? P039G006 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 211)]
		public int? P039G007 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 212)]
		public int? P039G008 { get; set; }

		[Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 213)]
		public int? P039G009 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 214)]
		public int? P039G010 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 215)]
		public int? P039G011 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 216)]
		public int? P039G012 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 217)]
		public int? P039G013 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 218)]
		public int? P039G014 { get; set; }

		[Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 219)]
		public int? P039G015 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 220)]
		public int? P039G016 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 221)]
		public int? P039G017 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 222)]
		public int? P039G018 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 223)]
		public int? P039G019 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 224)]
		public int? P039G020 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 225)]
		public int? P039H001 { get; set; }

		[Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 226)]
		public int? P039H002 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 227)]
		public int? P039H003 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 228)]
		public int? P039H004 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 229)]
		public int? P039H005 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 230)]
		public int? P039H006 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 231)]
		public int? P039H007 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 232)]
		public int? P039H008 { get; set; }

		[Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 233)]
		public int? P039H009 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 234)]
		public int? P039H010 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 235)]
		public int? P039H011 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 236)]
		public int? P039H012 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 237)]
		public int? P039H013 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 238)]
		public int? P039H014 { get; set; }

		[Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 239)]
		public int? P039H015 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 240)]
		public int? P039H016 { get; set; }

		[Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 241)]
		public int? P039H017 { get; set; }

		[Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 242)]
		public int? P039H018 { get; set; }

		[Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 243)]
		public int? P039H019 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 244)]
		public int? P039H020 { get; set; }
		#endregion Properties

		#region Constructors
		public SF1CongressionalDistricts113_SF1_00013() { }

		public SF1CongressionalDistricts113_SF1_00013(string csvLine) : base(csvLine) { }

		public SF1CongressionalDistricts113_SF1_00013(string[] values) : base(values) { }

		public SF1CongressionalDistricts113_SF1_00013(OleDbDataReader reader)
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
				P038F001 = (int?)reader[5];
			}
			if(reader[6] != DBNull.Value)
			{
				P038F002 = (int?)reader[6];
			}
			if(reader[7] != DBNull.Value)
			{
				P038F003 = (int?)reader[7];
			}
			if(reader[8] != DBNull.Value)
			{
				P038F004 = (int?)reader[8];
			}
			if(reader[9] != DBNull.Value)
			{
				P038F005 = (int?)reader[9];
			}
			if(reader[10] != DBNull.Value)
			{
				P038F006 = (int?)reader[10];
			}
			if(reader[11] != DBNull.Value)
			{
				P038F007 = (int?)reader[11];
			}
			if(reader[12] != DBNull.Value)
			{
				P038F008 = (int?)reader[12];
			}
			if(reader[13] != DBNull.Value)
			{
				P038F009 = (int?)reader[13];
			}
			if(reader[14] != DBNull.Value)
			{
				P038F010 = (int?)reader[14];
			}
			if(reader[15] != DBNull.Value)
			{
				P038F011 = (int?)reader[15];
			}
			if(reader[16] != DBNull.Value)
			{
				P038F012 = (int?)reader[16];
			}
			if(reader[17] != DBNull.Value)
			{
				P038F013 = (int?)reader[17];
			}
			if(reader[18] != DBNull.Value)
			{
				P038F014 = (int?)reader[18];
			}
			if(reader[19] != DBNull.Value)
			{
				P038F015 = (int?)reader[19];
			}
			if(reader[20] != DBNull.Value)
			{
				P038F016 = (int?)reader[20];
			}
			if(reader[21] != DBNull.Value)
			{
				P038F017 = (int?)reader[21];
			}
			if(reader[22] != DBNull.Value)
			{
				P038F018 = (int?)reader[22];
			}
			if(reader[23] != DBNull.Value)
			{
				P038F019 = (int?)reader[23];
			}
			if(reader[24] != DBNull.Value)
			{
				P038F020 = (int?)reader[24];
			}
			if(reader[25] != DBNull.Value)
			{
				P038G001 = (int?)reader[25];
			}
			if(reader[26] != DBNull.Value)
			{
				P038G002 = (int?)reader[26];
			}
			if(reader[27] != DBNull.Value)
			{
				P038G003 = (int?)reader[27];
			}
			if(reader[28] != DBNull.Value)
			{
				P038G004 = (int?)reader[28];
			}
			if(reader[29] != DBNull.Value)
			{
				P038G005 = (int?)reader[29];
			}
			if(reader[30] != DBNull.Value)
			{
				P038G006 = (int?)reader[30];
			}
			if(reader[31] != DBNull.Value)
			{
				P038G007 = (int?)reader[31];
			}
			if(reader[32] != DBNull.Value)
			{
				P038G008 = (int?)reader[32];
			}
			if(reader[33] != DBNull.Value)
			{
				P038G009 = (int?)reader[33];
			}
			if(reader[34] != DBNull.Value)
			{
				P038G010 = (int?)reader[34];
			}
			if(reader[35] != DBNull.Value)
			{
				P038G011 = (int?)reader[35];
			}
			if(reader[36] != DBNull.Value)
			{
				P038G012 = (int?)reader[36];
			}
			if(reader[37] != DBNull.Value)
			{
				P038G013 = (int?)reader[37];
			}
			if(reader[38] != DBNull.Value)
			{
				P038G014 = (int?)reader[38];
			}
			if(reader[39] != DBNull.Value)
			{
				P038G015 = (int?)reader[39];
			}
			if(reader[40] != DBNull.Value)
			{
				P038G016 = (int?)reader[40];
			}
			if(reader[41] != DBNull.Value)
			{
				P038G017 = (int?)reader[41];
			}
			if(reader[42] != DBNull.Value)
			{
				P038G018 = (int?)reader[42];
			}
			if(reader[43] != DBNull.Value)
			{
				P038G019 = (int?)reader[43];
			}
			if(reader[44] != DBNull.Value)
			{
				P038G020 = (int?)reader[44];
			}
			if(reader[45] != DBNull.Value)
			{
				P038H001 = (int?)reader[45];
			}
			if(reader[46] != DBNull.Value)
			{
				P038H002 = (int?)reader[46];
			}
			if(reader[47] != DBNull.Value)
			{
				P038H003 = (int?)reader[47];
			}
			if(reader[48] != DBNull.Value)
			{
				P038H004 = (int?)reader[48];
			}
			if(reader[49] != DBNull.Value)
			{
				P038H005 = (int?)reader[49];
			}
			if(reader[50] != DBNull.Value)
			{
				P038H006 = (int?)reader[50];
			}
			if(reader[51] != DBNull.Value)
			{
				P038H007 = (int?)reader[51];
			}
			if(reader[52] != DBNull.Value)
			{
				P038H008 = (int?)reader[52];
			}
			if(reader[53] != DBNull.Value)
			{
				P038H009 = (int?)reader[53];
			}
			if(reader[54] != DBNull.Value)
			{
				P038H010 = (int?)reader[54];
			}
			if(reader[55] != DBNull.Value)
			{
				P038H011 = (int?)reader[55];
			}
			if(reader[56] != DBNull.Value)
			{
				P038H012 = (int?)reader[56];
			}
			if(reader[57] != DBNull.Value)
			{
				P038H013 = (int?)reader[57];
			}
			if(reader[58] != DBNull.Value)
			{
				P038H014 = (int?)reader[58];
			}
			if(reader[59] != DBNull.Value)
			{
				P038H015 = (int?)reader[59];
			}
			if(reader[60] != DBNull.Value)
			{
				P038H016 = (int?)reader[60];
			}
			if(reader[61] != DBNull.Value)
			{
				P038H017 = (int?)reader[61];
			}
			if(reader[62] != DBNull.Value)
			{
				P038H018 = (int?)reader[62];
			}
			if(reader[63] != DBNull.Value)
			{
				P038H019 = (int?)reader[63];
			}
			if(reader[64] != DBNull.Value)
			{
				P038H020 = (int?)reader[64];
			}
			if(reader[65] != DBNull.Value)
			{
				P038I001 = (int?)reader[65];
			}
			if(reader[66] != DBNull.Value)
			{
				P038I002 = (int?)reader[66];
			}
			if(reader[67] != DBNull.Value)
			{
				P038I003 = (int?)reader[67];
			}
			if(reader[68] != DBNull.Value)
			{
				P038I004 = (int?)reader[68];
			}
			if(reader[69] != DBNull.Value)
			{
				P038I005 = (int?)reader[69];
			}
			if(reader[70] != DBNull.Value)
			{
				P038I006 = (int?)reader[70];
			}
			if(reader[71] != DBNull.Value)
			{
				P038I007 = (int?)reader[71];
			}
			if(reader[72] != DBNull.Value)
			{
				P038I008 = (int?)reader[72];
			}
			if(reader[73] != DBNull.Value)
			{
				P038I009 = (int?)reader[73];
			}
			if(reader[74] != DBNull.Value)
			{
				P038I010 = (int?)reader[74];
			}
			if(reader[75] != DBNull.Value)
			{
				P038I011 = (int?)reader[75];
			}
			if(reader[76] != DBNull.Value)
			{
				P038I012 = (int?)reader[76];
			}
			if(reader[77] != DBNull.Value)
			{
				P038I013 = (int?)reader[77];
			}
			if(reader[78] != DBNull.Value)
			{
				P038I014 = (int?)reader[78];
			}
			if(reader[79] != DBNull.Value)
			{
				P038I015 = (int?)reader[79];
			}
			if(reader[80] != DBNull.Value)
			{
				P038I016 = (int?)reader[80];
			}
			if(reader[81] != DBNull.Value)
			{
				P038I017 = (int?)reader[81];
			}
			if(reader[82] != DBNull.Value)
			{
				P038I018 = (int?)reader[82];
			}
			if(reader[83] != DBNull.Value)
			{
				P038I019 = (int?)reader[83];
			}
			if(reader[84] != DBNull.Value)
			{
				P038I020 = (int?)reader[84];
			}
			if(reader[85] != DBNull.Value)
			{
				P039A001 = (int?)reader[85];
			}
			if(reader[86] != DBNull.Value)
			{
				P039A002 = (int?)reader[86];
			}
			if(reader[87] != DBNull.Value)
			{
				P039A003 = (int?)reader[87];
			}
			if(reader[88] != DBNull.Value)
			{
				P039A004 = (int?)reader[88];
			}
			if(reader[89] != DBNull.Value)
			{
				P039A005 = (int?)reader[89];
			}
			if(reader[90] != DBNull.Value)
			{
				P039A006 = (int?)reader[90];
			}
			if(reader[91] != DBNull.Value)
			{
				P039A007 = (int?)reader[91];
			}
			if(reader[92] != DBNull.Value)
			{
				P039A008 = (int?)reader[92];
			}
			if(reader[93] != DBNull.Value)
			{
				P039A009 = (int?)reader[93];
			}
			if(reader[94] != DBNull.Value)
			{
				P039A010 = (int?)reader[94];
			}
			if(reader[95] != DBNull.Value)
			{
				P039A011 = (int?)reader[95];
			}
			if(reader[96] != DBNull.Value)
			{
				P039A012 = (int?)reader[96];
			}
			if(reader[97] != DBNull.Value)
			{
				P039A013 = (int?)reader[97];
			}
			if(reader[98] != DBNull.Value)
			{
				P039A014 = (int?)reader[98];
			}
			if(reader[99] != DBNull.Value)
			{
				P039A015 = (int?)reader[99];
			}
			if(reader[100] != DBNull.Value)
			{
				P039A016 = (int?)reader[100];
			}
			if(reader[101] != DBNull.Value)
			{
				P039A017 = (int?)reader[101];
			}
			if(reader[102] != DBNull.Value)
			{
				P039A018 = (int?)reader[102];
			}
			if(reader[103] != DBNull.Value)
			{
				P039A019 = (int?)reader[103];
			}
			if(reader[104] != DBNull.Value)
			{
				P039A020 = (int?)reader[104];
			}
			if(reader[105] != DBNull.Value)
			{
				P039B001 = (int?)reader[105];
			}
			if(reader[106] != DBNull.Value)
			{
				P039B002 = (int?)reader[106];
			}
			if(reader[107] != DBNull.Value)
			{
				P039B003 = (int?)reader[107];
			}
			if(reader[108] != DBNull.Value)
			{
				P039B004 = (int?)reader[108];
			}
			if(reader[109] != DBNull.Value)
			{
				P039B005 = (int?)reader[109];
			}
			if(reader[110] != DBNull.Value)
			{
				P039B006 = (int?)reader[110];
			}
			if(reader[111] != DBNull.Value)
			{
				P039B007 = (int?)reader[111];
			}
			if(reader[112] != DBNull.Value)
			{
				P039B008 = (int?)reader[112];
			}
			if(reader[113] != DBNull.Value)
			{
				P039B009 = (int?)reader[113];
			}
			if(reader[114] != DBNull.Value)
			{
				P039B010 = (int?)reader[114];
			}
			if(reader[115] != DBNull.Value)
			{
				P039B011 = (int?)reader[115];
			}
			if(reader[116] != DBNull.Value)
			{
				P039B012 = (int?)reader[116];
			}
			if(reader[117] != DBNull.Value)
			{
				P039B013 = (int?)reader[117];
			}
			if(reader[118] != DBNull.Value)
			{
				P039B014 = (int?)reader[118];
			}
			if(reader[119] != DBNull.Value)
			{
				P039B015 = (int?)reader[119];
			}
			if(reader[120] != DBNull.Value)
			{
				P039B016 = (int?)reader[120];
			}
			if(reader[121] != DBNull.Value)
			{
				P039B017 = (int?)reader[121];
			}
			if(reader[122] != DBNull.Value)
			{
				P039B018 = (int?)reader[122];
			}
			if(reader[123] != DBNull.Value)
			{
				P039B019 = (int?)reader[123];
			}
			if(reader[124] != DBNull.Value)
			{
				P039B020 = (int?)reader[124];
			}
			if(reader[125] != DBNull.Value)
			{
				P039C001 = (int?)reader[125];
			}
			if(reader[126] != DBNull.Value)
			{
				P039C002 = (int?)reader[126];
			}
			if(reader[127] != DBNull.Value)
			{
				P039C003 = (int?)reader[127];
			}
			if(reader[128] != DBNull.Value)
			{
				P039C004 = (int?)reader[128];
			}
			if(reader[129] != DBNull.Value)
			{
				P039C005 = (int?)reader[129];
			}
			if(reader[130] != DBNull.Value)
			{
				P039C006 = (int?)reader[130];
			}
			if(reader[131] != DBNull.Value)
			{
				P039C007 = (int?)reader[131];
			}
			if(reader[132] != DBNull.Value)
			{
				P039C008 = (int?)reader[132];
			}
			if(reader[133] != DBNull.Value)
			{
				P039C009 = (int?)reader[133];
			}
			if(reader[134] != DBNull.Value)
			{
				P039C010 = (int?)reader[134];
			}
			if(reader[135] != DBNull.Value)
			{
				P039C011 = (int?)reader[135];
			}
			if(reader[136] != DBNull.Value)
			{
				P039C012 = (int?)reader[136];
			}
			if(reader[137] != DBNull.Value)
			{
				P039C013 = (int?)reader[137];
			}
			if(reader[138] != DBNull.Value)
			{
				P039C014 = (int?)reader[138];
			}
			if(reader[139] != DBNull.Value)
			{
				P039C015 = (int?)reader[139];
			}
			if(reader[140] != DBNull.Value)
			{
				P039C016 = (int?)reader[140];
			}
			if(reader[141] != DBNull.Value)
			{
				P039C017 = (int?)reader[141];
			}
			if(reader[142] != DBNull.Value)
			{
				P039C018 = (int?)reader[142];
			}
			if(reader[143] != DBNull.Value)
			{
				P039C019 = (int?)reader[143];
			}
			if(reader[144] != DBNull.Value)
			{
				P039C020 = (int?)reader[144];
			}
			if(reader[145] != DBNull.Value)
			{
				P039D001 = (int?)reader[145];
			}
			if(reader[146] != DBNull.Value)
			{
				P039D002 = (int?)reader[146];
			}
			if(reader[147] != DBNull.Value)
			{
				P039D003 = (int?)reader[147];
			}
			if(reader[148] != DBNull.Value)
			{
				P039D004 = (int?)reader[148];
			}
			if(reader[149] != DBNull.Value)
			{
				P039D005 = (int?)reader[149];
			}
			if(reader[150] != DBNull.Value)
			{
				P039D006 = (int?)reader[150];
			}
			if(reader[151] != DBNull.Value)
			{
				P039D007 = (int?)reader[151];
			}
			if(reader[152] != DBNull.Value)
			{
				P039D008 = (int?)reader[152];
			}
			if(reader[153] != DBNull.Value)
			{
				P039D009 = (int?)reader[153];
			}
			if(reader[154] != DBNull.Value)
			{
				P039D010 = (int?)reader[154];
			}
			if(reader[155] != DBNull.Value)
			{
				P039D011 = (int?)reader[155];
			}
			if(reader[156] != DBNull.Value)
			{
				P039D012 = (int?)reader[156];
			}
			if(reader[157] != DBNull.Value)
			{
				P039D013 = (int?)reader[157];
			}
			if(reader[158] != DBNull.Value)
			{
				P039D014 = (int?)reader[158];
			}
			if(reader[159] != DBNull.Value)
			{
				P039D015 = (int?)reader[159];
			}
			if(reader[160] != DBNull.Value)
			{
				P039D016 = (int?)reader[160];
			}
			if(reader[161] != DBNull.Value)
			{
				P039D017 = (int?)reader[161];
			}
			if(reader[162] != DBNull.Value)
			{
				P039D018 = (int?)reader[162];
			}
			if(reader[163] != DBNull.Value)
			{
				P039D019 = (int?)reader[163];
			}
			if(reader[164] != DBNull.Value)
			{
				P039D020 = (int?)reader[164];
			}
			if(reader[165] != DBNull.Value)
			{
				P039E001 = (int?)reader[165];
			}
			if(reader[166] != DBNull.Value)
			{
				P039E002 = (int?)reader[166];
			}
			if(reader[167] != DBNull.Value)
			{
				P039E003 = (int?)reader[167];
			}
			if(reader[168] != DBNull.Value)
			{
				P039E004 = (int?)reader[168];
			}
			if(reader[169] != DBNull.Value)
			{
				P039E005 = (int?)reader[169];
			}
			if(reader[170] != DBNull.Value)
			{
				P039E006 = (int?)reader[170];
			}
			if(reader[171] != DBNull.Value)
			{
				P039E007 = (int?)reader[171];
			}
			if(reader[172] != DBNull.Value)
			{
				P039E008 = (int?)reader[172];
			}
			if(reader[173] != DBNull.Value)
			{
				P039E009 = (int?)reader[173];
			}
			if(reader[174] != DBNull.Value)
			{
				P039E010 = (int?)reader[174];
			}
			if(reader[175] != DBNull.Value)
			{
				P039E011 = (int?)reader[175];
			}
			if(reader[176] != DBNull.Value)
			{
				P039E012 = (int?)reader[176];
			}
			if(reader[177] != DBNull.Value)
			{
				P039E013 = (int?)reader[177];
			}
			if(reader[178] != DBNull.Value)
			{
				P039E014 = (int?)reader[178];
			}
			if(reader[179] != DBNull.Value)
			{
				P039E015 = (int?)reader[179];
			}
			if(reader[180] != DBNull.Value)
			{
				P039E016 = (int?)reader[180];
			}
			if(reader[181] != DBNull.Value)
			{
				P039E017 = (int?)reader[181];
			}
			if(reader[182] != DBNull.Value)
			{
				P039E018 = (int?)reader[182];
			}
			if(reader[183] != DBNull.Value)
			{
				P039E019 = (int?)reader[183];
			}
			if(reader[184] != DBNull.Value)
			{
				P039E020 = (int?)reader[184];
			}
			if(reader[185] != DBNull.Value)
			{
				P039F001 = (int?)reader[185];
			}
			if(reader[186] != DBNull.Value)
			{
				P039F002 = (int?)reader[186];
			}
			if(reader[187] != DBNull.Value)
			{
				P039F003 = (int?)reader[187];
			}
			if(reader[188] != DBNull.Value)
			{
				P039F004 = (int?)reader[188];
			}
			if(reader[189] != DBNull.Value)
			{
				P039F005 = (int?)reader[189];
			}
			if(reader[190] != DBNull.Value)
			{
				P039F006 = (int?)reader[190];
			}
			if(reader[191] != DBNull.Value)
			{
				P039F007 = (int?)reader[191];
			}
			if(reader[192] != DBNull.Value)
			{
				P039F008 = (int?)reader[192];
			}
			if(reader[193] != DBNull.Value)
			{
				P039F009 = (int?)reader[193];
			}
			if(reader[194] != DBNull.Value)
			{
				P039F010 = (int?)reader[194];
			}
			if(reader[195] != DBNull.Value)
			{
				P039F011 = (int?)reader[195];
			}
			if(reader[196] != DBNull.Value)
			{
				P039F012 = (int?)reader[196];
			}
			if(reader[197] != DBNull.Value)
			{
				P039F013 = (int?)reader[197];
			}
			if(reader[198] != DBNull.Value)
			{
				P039F014 = (int?)reader[198];
			}
			if(reader[199] != DBNull.Value)
			{
				P039F015 = (int?)reader[199];
			}
			if(reader[200] != DBNull.Value)
			{
				P039F016 = (int?)reader[200];
			}
			if(reader[201] != DBNull.Value)
			{
				P039F017 = (int?)reader[201];
			}
			if(reader[202] != DBNull.Value)
			{
				P039F018 = (int?)reader[202];
			}
			if(reader[203] != DBNull.Value)
			{
				P039F019 = (int?)reader[203];
			}
			if(reader[204] != DBNull.Value)
			{
				P039F020 = (int?)reader[204];
			}
			if(reader[205] != DBNull.Value)
			{
				P039G001 = (int?)reader[205];
			}
			if(reader[206] != DBNull.Value)
			{
				P039G002 = (int?)reader[206];
			}
			if(reader[207] != DBNull.Value)
			{
				P039G003 = (int?)reader[207];
			}
			if(reader[208] != DBNull.Value)
			{
				P039G004 = (int?)reader[208];
			}
			if(reader[209] != DBNull.Value)
			{
				P039G005 = (int?)reader[209];
			}
			if(reader[210] != DBNull.Value)
			{
				P039G006 = (int?)reader[210];
			}
			if(reader[211] != DBNull.Value)
			{
				P039G007 = (int?)reader[211];
			}
			if(reader[212] != DBNull.Value)
			{
				P039G008 = (int?)reader[212];
			}
			if(reader[213] != DBNull.Value)
			{
				P039G009 = (int?)reader[213];
			}
			if(reader[214] != DBNull.Value)
			{
				P039G010 = (int?)reader[214];
			}
			if(reader[215] != DBNull.Value)
			{
				P039G011 = (int?)reader[215];
			}
			if(reader[216] != DBNull.Value)
			{
				P039G012 = (int?)reader[216];
			}
			if(reader[217] != DBNull.Value)
			{
				P039G013 = (int?)reader[217];
			}
			if(reader[218] != DBNull.Value)
			{
				P039G014 = (int?)reader[218];
			}
			if(reader[219] != DBNull.Value)
			{
				P039G015 = (int?)reader[219];
			}
			if(reader[220] != DBNull.Value)
			{
				P039G016 = (int?)reader[220];
			}
			if(reader[221] != DBNull.Value)
			{
				P039G017 = (int?)reader[221];
			}
			if(reader[222] != DBNull.Value)
			{
				P039G018 = (int?)reader[222];
			}
			if(reader[223] != DBNull.Value)
			{
				P039G019 = (int?)reader[223];
			}
			if(reader[224] != DBNull.Value)
			{
				P039G020 = (int?)reader[224];
			}
			if(reader[225] != DBNull.Value)
			{
				P039H001 = (int?)reader[225];
			}
			if(reader[226] != DBNull.Value)
			{
				P039H002 = (int?)reader[226];
			}
			if(reader[227] != DBNull.Value)
			{
				P039H003 = (int?)reader[227];
			}
			if(reader[228] != DBNull.Value)
			{
				P039H004 = (int?)reader[228];
			}
			if(reader[229] != DBNull.Value)
			{
				P039H005 = (int?)reader[229];
			}
			if(reader[230] != DBNull.Value)
			{
				P039H006 = (int?)reader[230];
			}
			if(reader[231] != DBNull.Value)
			{
				P039H007 = (int?)reader[231];
			}
			if(reader[232] != DBNull.Value)
			{
				P039H008 = (int?)reader[232];
			}
			if(reader[233] != DBNull.Value)
			{
				P039H009 = (int?)reader[233];
			}
			if(reader[234] != DBNull.Value)
			{
				P039H010 = (int?)reader[234];
			}
			if(reader[235] != DBNull.Value)
			{
				P039H011 = (int?)reader[235];
			}
			if(reader[236] != DBNull.Value)
			{
				P039H012 = (int?)reader[236];
			}
			if(reader[237] != DBNull.Value)
			{
				P039H013 = (int?)reader[237];
			}
			if(reader[238] != DBNull.Value)
			{
				P039H014 = (int?)reader[238];
			}
			if(reader[239] != DBNull.Value)
			{
				P039H015 = (int?)reader[239];
			}
			if(reader[240] != DBNull.Value)
			{
				P039H016 = (int?)reader[240];
			}
			if(reader[241] != DBNull.Value)
			{
				P039H017 = (int?)reader[241];
			}
			if(reader[242] != DBNull.Value)
			{
				P039H018 = (int?)reader[242];
			}
			if(reader[243] != DBNull.Value)
			{
				P039H019 = (int?)reader[243];
			}
			if(reader[244] != DBNull.Value)
			{
				P039H020 = (int?)reader[244];
			}
		}
		#endregion Constructors
	}
}
