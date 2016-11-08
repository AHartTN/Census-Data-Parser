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

	public class SummaryOne_SF1_00011 : BaseModel
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
		public int? P031A001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 6)]
		public int? P031A002 { get; set; }

		[Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 7)]
		public int? P031A003 { get; set; }

		[Display(Name = "Related child:", ShortName = "Related child:", Order = 8)]
		public int? P031A004 { get; set; }

		[Display(Name = "Own child:", ShortName = "Own child:", Order = 9)]
		public int? P031A005 { get; set; }

		[Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 10)]
		public int? P031A006 { get; set; }

		[Display(Name = "In other family:", ShortName = "In other family:", Order = 11)]
		public int? P031A007 { get; set; }

		[Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 12)]
		public int? P031A008 { get; set; }

		[Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 13)]
		public int? P031A009 { get; set; }

		[Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 14)]
		public int? P031A010 { get; set; }

		[Display(Name = "Grandchild", ShortName = "Grandchild", Order = 15)]
		public int? P031A011 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 16)]
		public int? P031A012 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 17)]
		public int? P031A013 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 18)]
		public int? P031A014 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 19)]
		public int? P031A015 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 20)]
		public int? P031A016 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 21)]
		public int? P031B001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 22)]
		public int? P031B002 { get; set; }

		[Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 23)]
		public int? P031B003 { get; set; }

		[Display(Name = "Related child:", ShortName = "Related child:", Order = 24)]
		public int? P031B004 { get; set; }

		[Display(Name = "Own child:", ShortName = "Own child:", Order = 25)]
		public int? P031B005 { get; set; }

		[Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 26)]
		public int? P031B006 { get; set; }

		[Display(Name = "In other family:", ShortName = "In other family:", Order = 27)]
		public int? P031B007 { get; set; }

		[Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 28)]
		public int? P031B008 { get; set; }

		[Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 29)]
		public int? P031B009 { get; set; }

		[Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 30)]
		public int? P031B010 { get; set; }

		[Display(Name = "Grandchild", ShortName = "Grandchild", Order = 31)]
		public int? P031B011 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 32)]
		public int? P031B012 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 33)]
		public int? P031B013 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 34)]
		public int? P031B014 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 35)]
		public int? P031B015 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 36)]
		public int? P031B016 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 37)]
		public int? P031C001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 38)]
		public int? P031C002 { get; set; }

		[Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 39)]
		public int? P031C003 { get; set; }

		[Display(Name = "Related child:", ShortName = "Related child:", Order = 40)]
		public int? P031C004 { get; set; }

		[Display(Name = "Own child:", ShortName = "Own child:", Order = 41)]
		public int? P031C005 { get; set; }

		[Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 42)]
		public int? P031C006 { get; set; }

		[Display(Name = "In other family:", ShortName = "In other family:", Order = 43)]
		public int? P031C007 { get; set; }

		[Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 44)]
		public int? P031C008 { get; set; }

		[Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 45)]
		public int? P031C009 { get; set; }

		[Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 46)]
		public int? P031C010 { get; set; }

		[Display(Name = "Grandchild", ShortName = "Grandchild", Order = 47)]
		public int? P031C011 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 48)]
		public int? P031C012 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 49)]
		public int? P031C013 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 50)]
		public int? P031C014 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 51)]
		public int? P031C015 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 52)]
		public int? P031C016 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 53)]
		public int? P031D001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 54)]
		public int? P031D002 { get; set; }

		[Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 55)]
		public int? P031D003 { get; set; }

		[Display(Name = "Related child:", ShortName = "Related child:", Order = 56)]
		public int? P031D004 { get; set; }

		[Display(Name = "Own child:", ShortName = "Own child:", Order = 57)]
		public int? P031D005 { get; set; }

		[Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 58)]
		public int? P031D006 { get; set; }

		[Display(Name = "In other family:", ShortName = "In other family:", Order = 59)]
		public int? P031D007 { get; set; }

		[Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 60)]
		public int? P031D008 { get; set; }

		[Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 61)]
		public int? P031D009 { get; set; }

		[Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 62)]
		public int? P031D010 { get; set; }

		[Display(Name = "Grandchild", ShortName = "Grandchild", Order = 63)]
		public int? P031D011 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 64)]
		public int? P031D012 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 65)]
		public int? P031D013 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 66)]
		public int? P031D014 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 67)]
		public int? P031D015 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 68)]
		public int? P031D016 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 69)]
		public int? P031E001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 70)]
		public int? P031E002 { get; set; }

		[Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 71)]
		public int? P031E003 { get; set; }

		[Display(Name = "Related child:", ShortName = "Related child:", Order = 72)]
		public int? P031E004 { get; set; }

		[Display(Name = "Own child:", ShortName = "Own child:", Order = 73)]
		public int? P031E005 { get; set; }

		[Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 74)]
		public int? P031E006 { get; set; }

		[Display(Name = "In other family:", ShortName = "In other family:", Order = 75)]
		public int? P031E007 { get; set; }

		[Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 76)]
		public int? P031E008 { get; set; }

		[Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 77)]
		public int? P031E009 { get; set; }

		[Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 78)]
		public int? P031E010 { get; set; }

		[Display(Name = "Grandchild", ShortName = "Grandchild", Order = 79)]
		public int? P031E011 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 80)]
		public int? P031E012 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 81)]
		public int? P031E013 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 82)]
		public int? P031E014 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 83)]
		public int? P031E015 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 84)]
		public int? P031E016 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 85)]
		public int? P031F001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 86)]
		public int? P031F002 { get; set; }

		[Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 87)]
		public int? P031F003 { get; set; }

		[Display(Name = "Related child:", ShortName = "Related child:", Order = 88)]
		public int? P031F004 { get; set; }

		[Display(Name = "Own child:", ShortName = "Own child:", Order = 89)]
		public int? P031F005 { get; set; }

		[Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 90)]
		public int? P031F006 { get; set; }

		[Display(Name = "In other family:", ShortName = "In other family:", Order = 91)]
		public int? P031F007 { get; set; }

		[Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 92)]
		public int? P031F008 { get; set; }

		[Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 93)]
		public int? P031F009 { get; set; }

		[Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 94)]
		public int? P031F010 { get; set; }

		[Display(Name = "Grandchild", ShortName = "Grandchild", Order = 95)]
		public int? P031F011 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 96)]
		public int? P031F012 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 97)]
		public int? P031F013 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 98)]
		public int? P031F014 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 99)]
		public int? P031F015 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 100)]
		public int? P031F016 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 101)]
		public int? P031G001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 102)]
		public int? P031G002 { get; set; }

		[Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 103)]
		public int? P031G003 { get; set; }

		[Display(Name = "Related child:", ShortName = "Related child:", Order = 104)]
		public int? P031G004 { get; set; }

		[Display(Name = "Own child:", ShortName = "Own child:", Order = 105)]
		public int? P031G005 { get; set; }

		[Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 106)]
		public int? P031G006 { get; set; }

		[Display(Name = "In other family:", ShortName = "In other family:", Order = 107)]
		public int? P031G007 { get; set; }

		[Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 108)]
		public int? P031G008 { get; set; }

		[Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 109)]
		public int? P031G009 { get; set; }

		[Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 110)]
		public int? P031G010 { get; set; }

		[Display(Name = "Grandchild", ShortName = "Grandchild", Order = 111)]
		public int? P031G011 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 112)]
		public int? P031G012 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 113)]
		public int? P031G013 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 114)]
		public int? P031G014 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 115)]
		public int? P031G015 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 116)]
		public int? P031G016 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 117)]
		public int? P031H001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 118)]
		public int? P031H002 { get; set; }

		[Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 119)]
		public int? P031H003 { get; set; }

		[Display(Name = "Related child:", ShortName = "Related child:", Order = 120)]
		public int? P031H004 { get; set; }

		[Display(Name = "Own child:", ShortName = "Own child:", Order = 121)]
		public int? P031H005 { get; set; }

		[Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 122)]
		public int? P031H006 { get; set; }

		[Display(Name = "In other family:", ShortName = "In other family:", Order = 123)]
		public int? P031H007 { get; set; }

		[Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 124)]
		public int? P031H008 { get; set; }

		[Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 125)]
		public int? P031H009 { get; set; }

		[Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 126)]
		public int? P031H010 { get; set; }

		[Display(Name = "Grandchild", ShortName = "Grandchild", Order = 127)]
		public int? P031H011 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 128)]
		public int? P031H012 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 129)]
		public int? P031H013 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 130)]
		public int? P031H014 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 131)]
		public int? P031H015 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 132)]
		public int? P031H016 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 133)]
		public int? P031I001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 134)]
		public int? P031I002 { get; set; }

		[Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 135)]
		public int? P031I003 { get; set; }

		[Display(Name = "Related child:", ShortName = "Related child:", Order = 136)]
		public int? P031I004 { get; set; }

		[Display(Name = "Own child:", ShortName = "Own child:", Order = 137)]
		public int? P031I005 { get; set; }

		[Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 138)]
		public int? P031I006 { get; set; }

		[Display(Name = "In other family:", ShortName = "In other family:", Order = 139)]
		public int? P031I007 { get; set; }

		[Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 140)]
		public int? P031I008 { get; set; }

		[Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 141)]
		public int? P031I009 { get; set; }

		[Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 142)]
		public int? P031I010 { get; set; }

		[Display(Name = "Grandchild", ShortName = "Grandchild", Order = 143)]
		public int? P031I011 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 144)]
		public int? P031I012 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 145)]
		public int? P031I013 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 146)]
		public int? P031I014 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 147)]
		public int? P031I015 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 148)]
		public int? P031I016 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 149)]
		public int? P034A001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 150)]
		public int? P034A002 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 151)]
		public int? P034A003 { get; set; }

		[Display(Name = "Householder:", ShortName = "Householder:", Order = 152)]
		public int? P034A004 { get; set; }

		[Display(Name = "Male", ShortName = "Male", Order = 153)]
		public int? P034A005 { get; set; }

		[Display(Name = "Female", ShortName = "Female", Order = 154)]
		public int? P034A006 { get; set; }

		[Display(Name = "Spouse", ShortName = "Spouse", Order = 155)]
		public int? P034A007 { get; set; }

		[Display(Name = "Parent", ShortName = "Parent", Order = 156)]
		public int? P034A008 { get; set; }

		[Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 157)]
		public int? P034A009 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 158)]
		public int? P034A010 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 159)]
		public int? P034A011 { get; set; }

		[Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 160)]
		public int? P034A012 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 161)]
		public int? P034A013 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 162)]
		public int? P034A014 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 163)]
		public int? P034A015 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 164)]
		public int? P034A016 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 165)]
		public int? P034A017 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 166)]
		public int? P034A018 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 167)]
		public int? P034A019 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 168)]
		public int? P034A020 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 169)]
		public int? P034A021 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 170)]
		public int? P034A022 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 171)]
		public int? P034B001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 172)]
		public int? P034B002 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 173)]
		public int? P034B003 { get; set; }

		[Display(Name = "Householder:", ShortName = "Householder:", Order = 174)]
		public int? P034B004 { get; set; }

		[Display(Name = "Male", ShortName = "Male", Order = 175)]
		public int? P034B005 { get; set; }

		[Display(Name = "Female", ShortName = "Female", Order = 176)]
		public int? P034B006 { get; set; }

		[Display(Name = "Spouse", ShortName = "Spouse", Order = 177)]
		public int? P034B007 { get; set; }

		[Display(Name = "Parent", ShortName = "Parent", Order = 178)]
		public int? P034B008 { get; set; }

		[Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 179)]
		public int? P034B009 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 180)]
		public int? P034B010 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 181)]
		public int? P034B011 { get; set; }

		[Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 182)]
		public int? P034B012 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 183)]
		public int? P034B013 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 184)]
		public int? P034B014 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 185)]
		public int? P034B015 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 186)]
		public int? P034B016 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 187)]
		public int? P034B017 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 188)]
		public int? P034B018 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 189)]
		public int? P034B019 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 190)]
		public int? P034B020 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 191)]
		public int? P034B021 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 192)]
		public int? P034B022 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 193)]
		public int? P034C001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 194)]
		public int? P034C002 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 195)]
		public int? P034C003 { get; set; }

		[Display(Name = "Householder:", ShortName = "Householder:", Order = 196)]
		public int? P034C004 { get; set; }

		[Display(Name = "Male", ShortName = "Male", Order = 197)]
		public int? P034C005 { get; set; }

		[Display(Name = "Female", ShortName = "Female", Order = 198)]
		public int? P034C006 { get; set; }

		[Display(Name = "Spouse", ShortName = "Spouse", Order = 199)]
		public int? P034C007 { get; set; }

		[Display(Name = "Parent", ShortName = "Parent", Order = 200)]
		public int? P034C008 { get; set; }

		[Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 201)]
		public int? P034C009 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 202)]
		public int? P034C010 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 203)]
		public int? P034C011 { get; set; }

		[Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 204)]
		public int? P034C012 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 205)]
		public int? P034C013 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 206)]
		public int? P034C014 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 207)]
		public int? P034C015 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 208)]
		public int? P034C016 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 209)]
		public int? P034C017 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 210)]
		public int? P034C018 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 211)]
		public int? P034C019 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 212)]
		public int? P034C020 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 213)]
		public int? P034C021 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 214)]
		public int? P034C022 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 215)]
		public int? P034D001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 216)]
		public int? P034D002 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 217)]
		public int? P034D003 { get; set; }

		[Display(Name = "Householder:", ShortName = "Householder:", Order = 218)]
		public int? P034D004 { get; set; }

		[Display(Name = "Male", ShortName = "Male", Order = 219)]
		public int? P034D005 { get; set; }

		[Display(Name = "Female", ShortName = "Female", Order = 220)]
		public int? P034D006 { get; set; }

		[Display(Name = "Spouse", ShortName = "Spouse", Order = 221)]
		public int? P034D007 { get; set; }

		[Display(Name = "Parent", ShortName = "Parent", Order = 222)]
		public int? P034D008 { get; set; }

		[Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 223)]
		public int? P034D009 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 224)]
		public int? P034D010 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 225)]
		public int? P034D011 { get; set; }

		[Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 226)]
		public int? P034D012 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 227)]
		public int? P034D013 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 228)]
		public int? P034D014 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 229)]
		public int? P034D015 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 230)]
		public int? P034D016 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 231)]
		public int? P034D017 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 232)]
		public int? P034D018 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 233)]
		public int? P034D019 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 234)]
		public int? P034D020 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 235)]
		public int? P034D021 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 236)]
		public int? P034D022 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 237)]
		public int? P034E001 { get; set; }

		[Display(Name = "In households:", ShortName = "In households:", Order = 238)]
		public int? P034E002 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 239)]
		public int? P034E003 { get; set; }

		[Display(Name = "Householder:", ShortName = "Householder:", Order = 240)]
		public int? P034E004 { get; set; }

		[Display(Name = "Male", ShortName = "Male", Order = 241)]
		public int? P034E005 { get; set; }

		[Display(Name = "Female", ShortName = "Female", Order = 242)]
		public int? P034E006 { get; set; }

		[Display(Name = "Spouse", ShortName = "Spouse", Order = 243)]
		public int? P034E007 { get; set; }

		[Display(Name = "Parent", ShortName = "Parent", Order = 244)]
		public int? P034E008 { get; set; }

		[Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 245)]
		public int? P034E009 { get; set; }

		[Display(Name = "Other relatives", ShortName = "Other relatives", Order = 246)]
		public int? P034E010 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 247)]
		public int? P034E011 { get; set; }

		[Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 248)]
		public int? P034E012 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 249)]
		public int? P034E013 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 250)]
		public int? P034E014 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 251)]
		public int? P034E015 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 252)]
		public int? P034E016 { get; set; }

		[Display(Name = "Living alone", ShortName = "Living alone", Order = 253)]
		public int? P034E017 { get; set; }

		[Display(Name = "Not living alone", ShortName = "Not living alone", Order = 254)]
		public int? P034E018 { get; set; }

		[Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 255)]
		public int? P034E019 { get; set; }

		[Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 256)]
		public int? P034E020 { get; set; }

		[Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 257)]
		public int? P034E021 { get; set; }

		[Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 258)]
		public int? P034E022 { get; set; }
		#endregion Properties

		#region Constructors
		public SummaryOne_SF1_00011() { }

		public SummaryOne_SF1_00011(string csvLine) : base(csvLine) { }

		public SummaryOne_SF1_00011(string[] values) : base(values) { }

		public SummaryOne_SF1_00011(OleDbDataReader reader)
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
				P031A001 = (int?)reader[5];
			}
			if(reader[6] != DBNull.Value)
			{
				P031A002 = (int?)reader[6];
			}
			if(reader[7] != DBNull.Value)
			{
				P031A003 = (int?)reader[7];
			}
			if(reader[8] != DBNull.Value)
			{
				P031A004 = (int?)reader[8];
			}
			if(reader[9] != DBNull.Value)
			{
				P031A005 = (int?)reader[9];
			}
			if(reader[10] != DBNull.Value)
			{
				P031A006 = (int?)reader[10];
			}
			if(reader[11] != DBNull.Value)
			{
				P031A007 = (int?)reader[11];
			}
			if(reader[12] != DBNull.Value)
			{
				P031A008 = (int?)reader[12];
			}
			if(reader[13] != DBNull.Value)
			{
				P031A009 = (int?)reader[13];
			}
			if(reader[14] != DBNull.Value)
			{
				P031A010 = (int?)reader[14];
			}
			if(reader[15] != DBNull.Value)
			{
				P031A011 = (int?)reader[15];
			}
			if(reader[16] != DBNull.Value)
			{
				P031A012 = (int?)reader[16];
			}
			if(reader[17] != DBNull.Value)
			{
				P031A013 = (int?)reader[17];
			}
			if(reader[18] != DBNull.Value)
			{
				P031A014 = (int?)reader[18];
			}
			if(reader[19] != DBNull.Value)
			{
				P031A015 = (int?)reader[19];
			}
			if(reader[20] != DBNull.Value)
			{
				P031A016 = (int?)reader[20];
			}
			if(reader[21] != DBNull.Value)
			{
				P031B001 = (int?)reader[21];
			}
			if(reader[22] != DBNull.Value)
			{
				P031B002 = (int?)reader[22];
			}
			if(reader[23] != DBNull.Value)
			{
				P031B003 = (int?)reader[23];
			}
			if(reader[24] != DBNull.Value)
			{
				P031B004 = (int?)reader[24];
			}
			if(reader[25] != DBNull.Value)
			{
				P031B005 = (int?)reader[25];
			}
			if(reader[26] != DBNull.Value)
			{
				P031B006 = (int?)reader[26];
			}
			if(reader[27] != DBNull.Value)
			{
				P031B007 = (int?)reader[27];
			}
			if(reader[28] != DBNull.Value)
			{
				P031B008 = (int?)reader[28];
			}
			if(reader[29] != DBNull.Value)
			{
				P031B009 = (int?)reader[29];
			}
			if(reader[30] != DBNull.Value)
			{
				P031B010 = (int?)reader[30];
			}
			if(reader[31] != DBNull.Value)
			{
				P031B011 = (int?)reader[31];
			}
			if(reader[32] != DBNull.Value)
			{
				P031B012 = (int?)reader[32];
			}
			if(reader[33] != DBNull.Value)
			{
				P031B013 = (int?)reader[33];
			}
			if(reader[34] != DBNull.Value)
			{
				P031B014 = (int?)reader[34];
			}
			if(reader[35] != DBNull.Value)
			{
				P031B015 = (int?)reader[35];
			}
			if(reader[36] != DBNull.Value)
			{
				P031B016 = (int?)reader[36];
			}
			if(reader[37] != DBNull.Value)
			{
				P031C001 = (int?)reader[37];
			}
			if(reader[38] != DBNull.Value)
			{
				P031C002 = (int?)reader[38];
			}
			if(reader[39] != DBNull.Value)
			{
				P031C003 = (int?)reader[39];
			}
			if(reader[40] != DBNull.Value)
			{
				P031C004 = (int?)reader[40];
			}
			if(reader[41] != DBNull.Value)
			{
				P031C005 = (int?)reader[41];
			}
			if(reader[42] != DBNull.Value)
			{
				P031C006 = (int?)reader[42];
			}
			if(reader[43] != DBNull.Value)
			{
				P031C007 = (int?)reader[43];
			}
			if(reader[44] != DBNull.Value)
			{
				P031C008 = (int?)reader[44];
			}
			if(reader[45] != DBNull.Value)
			{
				P031C009 = (int?)reader[45];
			}
			if(reader[46] != DBNull.Value)
			{
				P031C010 = (int?)reader[46];
			}
			if(reader[47] != DBNull.Value)
			{
				P031C011 = (int?)reader[47];
			}
			if(reader[48] != DBNull.Value)
			{
				P031C012 = (int?)reader[48];
			}
			if(reader[49] != DBNull.Value)
			{
				P031C013 = (int?)reader[49];
			}
			if(reader[50] != DBNull.Value)
			{
				P031C014 = (int?)reader[50];
			}
			if(reader[51] != DBNull.Value)
			{
				P031C015 = (int?)reader[51];
			}
			if(reader[52] != DBNull.Value)
			{
				P031C016 = (int?)reader[52];
			}
			if(reader[53] != DBNull.Value)
			{
				P031D001 = (int?)reader[53];
			}
			if(reader[54] != DBNull.Value)
			{
				P031D002 = (int?)reader[54];
			}
			if(reader[55] != DBNull.Value)
			{
				P031D003 = (int?)reader[55];
			}
			if(reader[56] != DBNull.Value)
			{
				P031D004 = (int?)reader[56];
			}
			if(reader[57] != DBNull.Value)
			{
				P031D005 = (int?)reader[57];
			}
			if(reader[58] != DBNull.Value)
			{
				P031D006 = (int?)reader[58];
			}
			if(reader[59] != DBNull.Value)
			{
				P031D007 = (int?)reader[59];
			}
			if(reader[60] != DBNull.Value)
			{
				P031D008 = (int?)reader[60];
			}
			if(reader[61] != DBNull.Value)
			{
				P031D009 = (int?)reader[61];
			}
			if(reader[62] != DBNull.Value)
			{
				P031D010 = (int?)reader[62];
			}
			if(reader[63] != DBNull.Value)
			{
				P031D011 = (int?)reader[63];
			}
			if(reader[64] != DBNull.Value)
			{
				P031D012 = (int?)reader[64];
			}
			if(reader[65] != DBNull.Value)
			{
				P031D013 = (int?)reader[65];
			}
			if(reader[66] != DBNull.Value)
			{
				P031D014 = (int?)reader[66];
			}
			if(reader[67] != DBNull.Value)
			{
				P031D015 = (int?)reader[67];
			}
			if(reader[68] != DBNull.Value)
			{
				P031D016 = (int?)reader[68];
			}
			if(reader[69] != DBNull.Value)
			{
				P031E001 = (int?)reader[69];
			}
			if(reader[70] != DBNull.Value)
			{
				P031E002 = (int?)reader[70];
			}
			if(reader[71] != DBNull.Value)
			{
				P031E003 = (int?)reader[71];
			}
			if(reader[72] != DBNull.Value)
			{
				P031E004 = (int?)reader[72];
			}
			if(reader[73] != DBNull.Value)
			{
				P031E005 = (int?)reader[73];
			}
			if(reader[74] != DBNull.Value)
			{
				P031E006 = (int?)reader[74];
			}
			if(reader[75] != DBNull.Value)
			{
				P031E007 = (int?)reader[75];
			}
			if(reader[76] != DBNull.Value)
			{
				P031E008 = (int?)reader[76];
			}
			if(reader[77] != DBNull.Value)
			{
				P031E009 = (int?)reader[77];
			}
			if(reader[78] != DBNull.Value)
			{
				P031E010 = (int?)reader[78];
			}
			if(reader[79] != DBNull.Value)
			{
				P031E011 = (int?)reader[79];
			}
			if(reader[80] != DBNull.Value)
			{
				P031E012 = (int?)reader[80];
			}
			if(reader[81] != DBNull.Value)
			{
				P031E013 = (int?)reader[81];
			}
			if(reader[82] != DBNull.Value)
			{
				P031E014 = (int?)reader[82];
			}
			if(reader[83] != DBNull.Value)
			{
				P031E015 = (int?)reader[83];
			}
			if(reader[84] != DBNull.Value)
			{
				P031E016 = (int?)reader[84];
			}
			if(reader[85] != DBNull.Value)
			{
				P031F001 = (int?)reader[85];
			}
			if(reader[86] != DBNull.Value)
			{
				P031F002 = (int?)reader[86];
			}
			if(reader[87] != DBNull.Value)
			{
				P031F003 = (int?)reader[87];
			}
			if(reader[88] != DBNull.Value)
			{
				P031F004 = (int?)reader[88];
			}
			if(reader[89] != DBNull.Value)
			{
				P031F005 = (int?)reader[89];
			}
			if(reader[90] != DBNull.Value)
			{
				P031F006 = (int?)reader[90];
			}
			if(reader[91] != DBNull.Value)
			{
				P031F007 = (int?)reader[91];
			}
			if(reader[92] != DBNull.Value)
			{
				P031F008 = (int?)reader[92];
			}
			if(reader[93] != DBNull.Value)
			{
				P031F009 = (int?)reader[93];
			}
			if(reader[94] != DBNull.Value)
			{
				P031F010 = (int?)reader[94];
			}
			if(reader[95] != DBNull.Value)
			{
				P031F011 = (int?)reader[95];
			}
			if(reader[96] != DBNull.Value)
			{
				P031F012 = (int?)reader[96];
			}
			if(reader[97] != DBNull.Value)
			{
				P031F013 = (int?)reader[97];
			}
			if(reader[98] != DBNull.Value)
			{
				P031F014 = (int?)reader[98];
			}
			if(reader[99] != DBNull.Value)
			{
				P031F015 = (int?)reader[99];
			}
			if(reader[100] != DBNull.Value)
			{
				P031F016 = (int?)reader[100];
			}
			if(reader[101] != DBNull.Value)
			{
				P031G001 = (int?)reader[101];
			}
			if(reader[102] != DBNull.Value)
			{
				P031G002 = (int?)reader[102];
			}
			if(reader[103] != DBNull.Value)
			{
				P031G003 = (int?)reader[103];
			}
			if(reader[104] != DBNull.Value)
			{
				P031G004 = (int?)reader[104];
			}
			if(reader[105] != DBNull.Value)
			{
				P031G005 = (int?)reader[105];
			}
			if(reader[106] != DBNull.Value)
			{
				P031G006 = (int?)reader[106];
			}
			if(reader[107] != DBNull.Value)
			{
				P031G007 = (int?)reader[107];
			}
			if(reader[108] != DBNull.Value)
			{
				P031G008 = (int?)reader[108];
			}
			if(reader[109] != DBNull.Value)
			{
				P031G009 = (int?)reader[109];
			}
			if(reader[110] != DBNull.Value)
			{
				P031G010 = (int?)reader[110];
			}
			if(reader[111] != DBNull.Value)
			{
				P031G011 = (int?)reader[111];
			}
			if(reader[112] != DBNull.Value)
			{
				P031G012 = (int?)reader[112];
			}
			if(reader[113] != DBNull.Value)
			{
				P031G013 = (int?)reader[113];
			}
			if(reader[114] != DBNull.Value)
			{
				P031G014 = (int?)reader[114];
			}
			if(reader[115] != DBNull.Value)
			{
				P031G015 = (int?)reader[115];
			}
			if(reader[116] != DBNull.Value)
			{
				P031G016 = (int?)reader[116];
			}
			if(reader[117] != DBNull.Value)
			{
				P031H001 = (int?)reader[117];
			}
			if(reader[118] != DBNull.Value)
			{
				P031H002 = (int?)reader[118];
			}
			if(reader[119] != DBNull.Value)
			{
				P031H003 = (int?)reader[119];
			}
			if(reader[120] != DBNull.Value)
			{
				P031H004 = (int?)reader[120];
			}
			if(reader[121] != DBNull.Value)
			{
				P031H005 = (int?)reader[121];
			}
			if(reader[122] != DBNull.Value)
			{
				P031H006 = (int?)reader[122];
			}
			if(reader[123] != DBNull.Value)
			{
				P031H007 = (int?)reader[123];
			}
			if(reader[124] != DBNull.Value)
			{
				P031H008 = (int?)reader[124];
			}
			if(reader[125] != DBNull.Value)
			{
				P031H009 = (int?)reader[125];
			}
			if(reader[126] != DBNull.Value)
			{
				P031H010 = (int?)reader[126];
			}
			if(reader[127] != DBNull.Value)
			{
				P031H011 = (int?)reader[127];
			}
			if(reader[128] != DBNull.Value)
			{
				P031H012 = (int?)reader[128];
			}
			if(reader[129] != DBNull.Value)
			{
				P031H013 = (int?)reader[129];
			}
			if(reader[130] != DBNull.Value)
			{
				P031H014 = (int?)reader[130];
			}
			if(reader[131] != DBNull.Value)
			{
				P031H015 = (int?)reader[131];
			}
			if(reader[132] != DBNull.Value)
			{
				P031H016 = (int?)reader[132];
			}
			if(reader[133] != DBNull.Value)
			{
				P031I001 = (int?)reader[133];
			}
			if(reader[134] != DBNull.Value)
			{
				P031I002 = (int?)reader[134];
			}
			if(reader[135] != DBNull.Value)
			{
				P031I003 = (int?)reader[135];
			}
			if(reader[136] != DBNull.Value)
			{
				P031I004 = (int?)reader[136];
			}
			if(reader[137] != DBNull.Value)
			{
				P031I005 = (int?)reader[137];
			}
			if(reader[138] != DBNull.Value)
			{
				P031I006 = (int?)reader[138];
			}
			if(reader[139] != DBNull.Value)
			{
				P031I007 = (int?)reader[139];
			}
			if(reader[140] != DBNull.Value)
			{
				P031I008 = (int?)reader[140];
			}
			if(reader[141] != DBNull.Value)
			{
				P031I009 = (int?)reader[141];
			}
			if(reader[142] != DBNull.Value)
			{
				P031I010 = (int?)reader[142];
			}
			if(reader[143] != DBNull.Value)
			{
				P031I011 = (int?)reader[143];
			}
			if(reader[144] != DBNull.Value)
			{
				P031I012 = (int?)reader[144];
			}
			if(reader[145] != DBNull.Value)
			{
				P031I013 = (int?)reader[145];
			}
			if(reader[146] != DBNull.Value)
			{
				P031I014 = (int?)reader[146];
			}
			if(reader[147] != DBNull.Value)
			{
				P031I015 = (int?)reader[147];
			}
			if(reader[148] != DBNull.Value)
			{
				P031I016 = (int?)reader[148];
			}
			if(reader[149] != DBNull.Value)
			{
				P034A001 = (int?)reader[149];
			}
			if(reader[150] != DBNull.Value)
			{
				P034A002 = (int?)reader[150];
			}
			if(reader[151] != DBNull.Value)
			{
				P034A003 = (int?)reader[151];
			}
			if(reader[152] != DBNull.Value)
			{
				P034A004 = (int?)reader[152];
			}
			if(reader[153] != DBNull.Value)
			{
				P034A005 = (int?)reader[153];
			}
			if(reader[154] != DBNull.Value)
			{
				P034A006 = (int?)reader[154];
			}
			if(reader[155] != DBNull.Value)
			{
				P034A007 = (int?)reader[155];
			}
			if(reader[156] != DBNull.Value)
			{
				P034A008 = (int?)reader[156];
			}
			if(reader[157] != DBNull.Value)
			{
				P034A009 = (int?)reader[157];
			}
			if(reader[158] != DBNull.Value)
			{
				P034A010 = (int?)reader[158];
			}
			if(reader[159] != DBNull.Value)
			{
				P034A011 = (int?)reader[159];
			}
			if(reader[160] != DBNull.Value)
			{
				P034A012 = (int?)reader[160];
			}
			if(reader[161] != DBNull.Value)
			{
				P034A013 = (int?)reader[161];
			}
			if(reader[162] != DBNull.Value)
			{
				P034A014 = (int?)reader[162];
			}
			if(reader[163] != DBNull.Value)
			{
				P034A015 = (int?)reader[163];
			}
			if(reader[164] != DBNull.Value)
			{
				P034A016 = (int?)reader[164];
			}
			if(reader[165] != DBNull.Value)
			{
				P034A017 = (int?)reader[165];
			}
			if(reader[166] != DBNull.Value)
			{
				P034A018 = (int?)reader[166];
			}
			if(reader[167] != DBNull.Value)
			{
				P034A019 = (int?)reader[167];
			}
			if(reader[168] != DBNull.Value)
			{
				P034A020 = (int?)reader[168];
			}
			if(reader[169] != DBNull.Value)
			{
				P034A021 = (int?)reader[169];
			}
			if(reader[170] != DBNull.Value)
			{
				P034A022 = (int?)reader[170];
			}
			if(reader[171] != DBNull.Value)
			{
				P034B001 = (int?)reader[171];
			}
			if(reader[172] != DBNull.Value)
			{
				P034B002 = (int?)reader[172];
			}
			if(reader[173] != DBNull.Value)
			{
				P034B003 = (int?)reader[173];
			}
			if(reader[174] != DBNull.Value)
			{
				P034B004 = (int?)reader[174];
			}
			if(reader[175] != DBNull.Value)
			{
				P034B005 = (int?)reader[175];
			}
			if(reader[176] != DBNull.Value)
			{
				P034B006 = (int?)reader[176];
			}
			if(reader[177] != DBNull.Value)
			{
				P034B007 = (int?)reader[177];
			}
			if(reader[178] != DBNull.Value)
			{
				P034B008 = (int?)reader[178];
			}
			if(reader[179] != DBNull.Value)
			{
				P034B009 = (int?)reader[179];
			}
			if(reader[180] != DBNull.Value)
			{
				P034B010 = (int?)reader[180];
			}
			if(reader[181] != DBNull.Value)
			{
				P034B011 = (int?)reader[181];
			}
			if(reader[182] != DBNull.Value)
			{
				P034B012 = (int?)reader[182];
			}
			if(reader[183] != DBNull.Value)
			{
				P034B013 = (int?)reader[183];
			}
			if(reader[184] != DBNull.Value)
			{
				P034B014 = (int?)reader[184];
			}
			if(reader[185] != DBNull.Value)
			{
				P034B015 = (int?)reader[185];
			}
			if(reader[186] != DBNull.Value)
			{
				P034B016 = (int?)reader[186];
			}
			if(reader[187] != DBNull.Value)
			{
				P034B017 = (int?)reader[187];
			}
			if(reader[188] != DBNull.Value)
			{
				P034B018 = (int?)reader[188];
			}
			if(reader[189] != DBNull.Value)
			{
				P034B019 = (int?)reader[189];
			}
			if(reader[190] != DBNull.Value)
			{
				P034B020 = (int?)reader[190];
			}
			if(reader[191] != DBNull.Value)
			{
				P034B021 = (int?)reader[191];
			}
			if(reader[192] != DBNull.Value)
			{
				P034B022 = (int?)reader[192];
			}
			if(reader[193] != DBNull.Value)
			{
				P034C001 = (int?)reader[193];
			}
			if(reader[194] != DBNull.Value)
			{
				P034C002 = (int?)reader[194];
			}
			if(reader[195] != DBNull.Value)
			{
				P034C003 = (int?)reader[195];
			}
			if(reader[196] != DBNull.Value)
			{
				P034C004 = (int?)reader[196];
			}
			if(reader[197] != DBNull.Value)
			{
				P034C005 = (int?)reader[197];
			}
			if(reader[198] != DBNull.Value)
			{
				P034C006 = (int?)reader[198];
			}
			if(reader[199] != DBNull.Value)
			{
				P034C007 = (int?)reader[199];
			}
			if(reader[200] != DBNull.Value)
			{
				P034C008 = (int?)reader[200];
			}
			if(reader[201] != DBNull.Value)
			{
				P034C009 = (int?)reader[201];
			}
			if(reader[202] != DBNull.Value)
			{
				P034C010 = (int?)reader[202];
			}
			if(reader[203] != DBNull.Value)
			{
				P034C011 = (int?)reader[203];
			}
			if(reader[204] != DBNull.Value)
			{
				P034C012 = (int?)reader[204];
			}
			if(reader[205] != DBNull.Value)
			{
				P034C013 = (int?)reader[205];
			}
			if(reader[206] != DBNull.Value)
			{
				P034C014 = (int?)reader[206];
			}
			if(reader[207] != DBNull.Value)
			{
				P034C015 = (int?)reader[207];
			}
			if(reader[208] != DBNull.Value)
			{
				P034C016 = (int?)reader[208];
			}
			if(reader[209] != DBNull.Value)
			{
				P034C017 = (int?)reader[209];
			}
			if(reader[210] != DBNull.Value)
			{
				P034C018 = (int?)reader[210];
			}
			if(reader[211] != DBNull.Value)
			{
				P034C019 = (int?)reader[211];
			}
			if(reader[212] != DBNull.Value)
			{
				P034C020 = (int?)reader[212];
			}
			if(reader[213] != DBNull.Value)
			{
				P034C021 = (int?)reader[213];
			}
			if(reader[214] != DBNull.Value)
			{
				P034C022 = (int?)reader[214];
			}
			if(reader[215] != DBNull.Value)
			{
				P034D001 = (int?)reader[215];
			}
			if(reader[216] != DBNull.Value)
			{
				P034D002 = (int?)reader[216];
			}
			if(reader[217] != DBNull.Value)
			{
				P034D003 = (int?)reader[217];
			}
			if(reader[218] != DBNull.Value)
			{
				P034D004 = (int?)reader[218];
			}
			if(reader[219] != DBNull.Value)
			{
				P034D005 = (int?)reader[219];
			}
			if(reader[220] != DBNull.Value)
			{
				P034D006 = (int?)reader[220];
			}
			if(reader[221] != DBNull.Value)
			{
				P034D007 = (int?)reader[221];
			}
			if(reader[222] != DBNull.Value)
			{
				P034D008 = (int?)reader[222];
			}
			if(reader[223] != DBNull.Value)
			{
				P034D009 = (int?)reader[223];
			}
			if(reader[224] != DBNull.Value)
			{
				P034D010 = (int?)reader[224];
			}
			if(reader[225] != DBNull.Value)
			{
				P034D011 = (int?)reader[225];
			}
			if(reader[226] != DBNull.Value)
			{
				P034D012 = (int?)reader[226];
			}
			if(reader[227] != DBNull.Value)
			{
				P034D013 = (int?)reader[227];
			}
			if(reader[228] != DBNull.Value)
			{
				P034D014 = (int?)reader[228];
			}
			if(reader[229] != DBNull.Value)
			{
				P034D015 = (int?)reader[229];
			}
			if(reader[230] != DBNull.Value)
			{
				P034D016 = (int?)reader[230];
			}
			if(reader[231] != DBNull.Value)
			{
				P034D017 = (int?)reader[231];
			}
			if(reader[232] != DBNull.Value)
			{
				P034D018 = (int?)reader[232];
			}
			if(reader[233] != DBNull.Value)
			{
				P034D019 = (int?)reader[233];
			}
			if(reader[234] != DBNull.Value)
			{
				P034D020 = (int?)reader[234];
			}
			if(reader[235] != DBNull.Value)
			{
				P034D021 = (int?)reader[235];
			}
			if(reader[236] != DBNull.Value)
			{
				P034D022 = (int?)reader[236];
			}
			if(reader[237] != DBNull.Value)
			{
				P034E001 = (int?)reader[237];
			}
			if(reader[238] != DBNull.Value)
			{
				P034E002 = (int?)reader[238];
			}
			if(reader[239] != DBNull.Value)
			{
				P034E003 = (int?)reader[239];
			}
			if(reader[240] != DBNull.Value)
			{
				P034E004 = (int?)reader[240];
			}
			if(reader[241] != DBNull.Value)
			{
				P034E005 = (int?)reader[241];
			}
			if(reader[242] != DBNull.Value)
			{
				P034E006 = (int?)reader[242];
			}
			if(reader[243] != DBNull.Value)
			{
				P034E007 = (int?)reader[243];
			}
			if(reader[244] != DBNull.Value)
			{
				P034E008 = (int?)reader[244];
			}
			if(reader[245] != DBNull.Value)
			{
				P034E009 = (int?)reader[245];
			}
			if(reader[246] != DBNull.Value)
			{
				P034E010 = (int?)reader[246];
			}
			if(reader[247] != DBNull.Value)
			{
				P034E011 = (int?)reader[247];
			}
			if(reader[248] != DBNull.Value)
			{
				P034E012 = (int?)reader[248];
			}
			if(reader[249] != DBNull.Value)
			{
				P034E013 = (int?)reader[249];
			}
			if(reader[250] != DBNull.Value)
			{
				P034E014 = (int?)reader[250];
			}
			if(reader[251] != DBNull.Value)
			{
				P034E015 = (int?)reader[251];
			}
			if(reader[252] != DBNull.Value)
			{
				P034E016 = (int?)reader[252];
			}
			if(reader[253] != DBNull.Value)
			{
				P034E017 = (int?)reader[253];
			}
			if(reader[254] != DBNull.Value)
			{
				P034E018 = (int?)reader[254];
			}
			if(reader[255] != DBNull.Value)
			{
				P034E019 = (int?)reader[255];
			}
			if(reader[256] != DBNull.Value)
			{
				P034E020 = (int?)reader[256];
			}
			if(reader[257] != DBNull.Value)
			{
				P034E021 = (int?)reader[257];
			}
			if(reader[258] != DBNull.Value)
			{
				P034E022 = (int?)reader[258];
			}
		}
		#endregion Constructors
	}
}
