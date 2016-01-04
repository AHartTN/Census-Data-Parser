namespace CensusDataParser.Generated.Binding
{
	#region Using Directives
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.Data.OleDb;
	#endregion Using Directives

	public class SF1CongressionalDistricts113_SF1_00009 : BaseModel
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
		public decimal? P017B001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 6)]
		public decimal? P017B002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 7)]
		public decimal? P017B003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 8)]
		public decimal? P017C001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 9)]
		public decimal? P017C002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 10)]
		public decimal? P017C003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 11)]
		public decimal? P017D001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 12)]
		public decimal? P017D002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 13)]
		public decimal? P017D003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 14)]
		public decimal? P017E001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 15)]
		public decimal? P017E002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 16)]
		public decimal? P017E003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 17)]
		public decimal? P017F001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 18)]
		public decimal? P017F002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 19)]
		public decimal? P017F003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 20)]
		public decimal? P017G001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 21)]
		public decimal? P017G002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 22)]
		public decimal? P017G003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 23)]
		public decimal? P017H001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 24)]
		public decimal? P017H002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 25)]
		public decimal? P017H003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 26)]
		public decimal? P017I001 { get; set; }

		[Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 27)]
		public decimal? P017I002 { get; set; }

		[Display(Name = "18 years and over", ShortName = "18 years and over", Order = 28)]
		public decimal? P017I003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 29)]
		public int? P018A001 { get; set; }

		[Display(Name = "Family households:", ShortName = "Family households:", Order = 30)]
		public int? P018A002 { get; set; }

		[Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 31)]
		public int? P018A003 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 32)]
		public int? P018A004 { get; set; }

		[Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 33)]
		public int? P018A005 { get; set; }

		[Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 34)]
		public int? P018A006 { get; set; }

		[Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 35)]
		public int? P018A007 { get; set; }

		[Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 36)]
		public int? P018A008 { get; set; }

		[Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 37)]
		public int? P018A009 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 38)]
		public int? P018B001 { get; set; }

		[Display(Name = "Family households:", ShortName = "Family households:", Order = 39)]
		public int? P018B002 { get; set; }

		[Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 40)]
		public int? P018B003 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 41)]
		public int? P018B004 { get; set; }

		[Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 42)]
		public int? P018B005 { get; set; }

		[Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 43)]
		public int? P018B006 { get; set; }

		[Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 44)]
		public int? P018B007 { get; set; }

		[Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 45)]
		public int? P018B008 { get; set; }

		[Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 46)]
		public int? P018B009 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 47)]
		public int? P018C001 { get; set; }

		[Display(Name = "Family households:", ShortName = "Family households:", Order = 48)]
		public int? P018C002 { get; set; }

		[Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 49)]
		public int? P018C003 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 50)]
		public int? P018C004 { get; set; }

		[Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 51)]
		public int? P018C005 { get; set; }

		[Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 52)]
		public int? P018C006 { get; set; }

		[Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 53)]
		public int? P018C007 { get; set; }

		[Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 54)]
		public int? P018C008 { get; set; }

		[Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 55)]
		public int? P018C009 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 56)]
		public int? P018D001 { get; set; }

		[Display(Name = "Family households:", ShortName = "Family households:", Order = 57)]
		public int? P018D002 { get; set; }

		[Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 58)]
		public int? P018D003 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 59)]
		public int? P018D004 { get; set; }

		[Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 60)]
		public int? P018D005 { get; set; }

		[Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 61)]
		public int? P018D006 { get; set; }

		[Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 62)]
		public int? P018D007 { get; set; }

		[Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 63)]
		public int? P018D008 { get; set; }

		[Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 64)]
		public int? P018D009 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 65)]
		public int? P018E001 { get; set; }

		[Display(Name = "Family households:", ShortName = "Family households:", Order = 66)]
		public int? P018E002 { get; set; }

		[Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 67)]
		public int? P018E003 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 68)]
		public int? P018E004 { get; set; }

		[Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 69)]
		public int? P018E005 { get; set; }

		[Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 70)]
		public int? P018E006 { get; set; }

		[Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 71)]
		public int? P018E007 { get; set; }

		[Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 72)]
		public int? P018E008 { get; set; }

		[Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 73)]
		public int? P018E009 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 74)]
		public int? P018F001 { get; set; }

		[Display(Name = "Family households:", ShortName = "Family households:", Order = 75)]
		public int? P018F002 { get; set; }

		[Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 76)]
		public int? P018F003 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 77)]
		public int? P018F004 { get; set; }

		[Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 78)]
		public int? P018F005 { get; set; }

		[Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 79)]
		public int? P018F006 { get; set; }

		[Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 80)]
		public int? P018F007 { get; set; }

		[Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 81)]
		public int? P018F008 { get; set; }

		[Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 82)]
		public int? P018F009 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 83)]
		public int? P018G001 { get; set; }

		[Display(Name = "Family households:", ShortName = "Family households:", Order = 84)]
		public int? P018G002 { get; set; }

		[Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 85)]
		public int? P018G003 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 86)]
		public int? P018G004 { get; set; }

		[Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 87)]
		public int? P018G005 { get; set; }

		[Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 88)]
		public int? P018G006 { get; set; }

		[Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 89)]
		public int? P018G007 { get; set; }

		[Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 90)]
		public int? P018G008 { get; set; }

		[Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 91)]
		public int? P018G009 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 92)]
		public int? P018H001 { get; set; }

		[Display(Name = "Family households:", ShortName = "Family households:", Order = 93)]
		public int? P018H002 { get; set; }

		[Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 94)]
		public int? P018H003 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 95)]
		public int? P018H004 { get; set; }

		[Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 96)]
		public int? P018H005 { get; set; }

		[Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 97)]
		public int? P018H006 { get; set; }

		[Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 98)]
		public int? P018H007 { get; set; }

		[Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 99)]
		public int? P018H008 { get; set; }

		[Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 100)]
		public int? P018H009 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 101)]
		public int? P018I001 { get; set; }

		[Display(Name = "Family households:", ShortName = "Family households:", Order = 102)]
		public int? P018I002 { get; set; }

		[Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 103)]
		public int? P018I003 { get; set; }

		[Display(Name = "Other family:", ShortName = "Other family:", Order = 104)]
		public int? P018I004 { get; set; }

		[Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 105)]
		public int? P018I005 { get; set; }

		[Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 106)]
		public int? P018I006 { get; set; }

		[Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 107)]
		public int? P018I007 { get; set; }

		[Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 108)]
		public int? P018I008 { get; set; }

		[Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 109)]
		public int? P018I009 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 110)]
		public int? P028A001 { get; set; }

		[Display(Name = "Family households:", ShortName = "Family households:", Order = 111)]
		public int? P028A002 { get; set; }

		[Display(Name = "2-person household", ShortName = "2-person household", Order = 112)]
		public int? P028A003 { get; set; }

		[Display(Name = "3-person household", ShortName = "3-person household", Order = 113)]
		public int? P028A004 { get; set; }

		[Display(Name = "4-person household", ShortName = "4-person household", Order = 114)]
		public int? P028A005 { get; set; }

		[Display(Name = "5-person household", ShortName = "5-person household", Order = 115)]
		public int? P028A006 { get; set; }

		[Display(Name = "6-person household", ShortName = "6-person household", Order = 116)]
		public int? P028A007 { get; set; }

		[Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 117)]
		public int? P028A008 { get; set; }

		[Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 118)]
		public int? P028A009 { get; set; }

		[Display(Name = "1-person household", ShortName = "1-person household", Order = 119)]
		public int? P028A010 { get; set; }

		[Display(Name = "2-person household", ShortName = "2-person household", Order = 120)]
		public int? P028A011 { get; set; }

		[Display(Name = "3-person household", ShortName = "3-person household", Order = 121)]
		public int? P028A012 { get; set; }

		[Display(Name = "4-person household", ShortName = "4-person household", Order = 122)]
		public int? P028A013 { get; set; }

		[Display(Name = "5-person household", ShortName = "5-person household", Order = 123)]
		public int? P028A014 { get; set; }

		[Display(Name = "6-person household", ShortName = "6-person household", Order = 124)]
		public int? P028A015 { get; set; }

		[Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 125)]
		public int? P028A016 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 126)]
		public int? P028B001 { get; set; }

		[Display(Name = "Family households:", ShortName = "Family households:", Order = 127)]
		public int? P028B002 { get; set; }

		[Display(Name = "2-person household", ShortName = "2-person household", Order = 128)]
		public int? P028B003 { get; set; }

		[Display(Name = "3-person household", ShortName = "3-person household", Order = 129)]
		public int? P028B004 { get; set; }

		[Display(Name = "4-person household", ShortName = "4-person household", Order = 130)]
		public int? P028B005 { get; set; }

		[Display(Name = "5-person household", ShortName = "5-person household", Order = 131)]
		public int? P028B006 { get; set; }

		[Display(Name = "6-person household", ShortName = "6-person household", Order = 132)]
		public int? P028B007 { get; set; }

		[Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 133)]
		public int? P028B008 { get; set; }

		[Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 134)]
		public int? P028B009 { get; set; }

		[Display(Name = "1-person household", ShortName = "1-person household", Order = 135)]
		public int? P028B010 { get; set; }

		[Display(Name = "2-person household", ShortName = "2-person household", Order = 136)]
		public int? P028B011 { get; set; }

		[Display(Name = "3-person household", ShortName = "3-person household", Order = 137)]
		public int? P028B012 { get; set; }

		[Display(Name = "4-person household", ShortName = "4-person household", Order = 138)]
		public int? P028B013 { get; set; }

		[Display(Name = "5-person household", ShortName = "5-person household", Order = 139)]
		public int? P028B014 { get; set; }

		[Display(Name = "6-person household", ShortName = "6-person household", Order = 140)]
		public int? P028B015 { get; set; }

		[Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 141)]
		public int? P028B016 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 142)]
		public int? P028C001 { get; set; }

		[Display(Name = "Family households:", ShortName = "Family households:", Order = 143)]
		public int? P028C002 { get; set; }

		[Display(Name = "2-person household", ShortName = "2-person household", Order = 144)]
		public int? P028C003 { get; set; }

		[Display(Name = "3-person household", ShortName = "3-person household", Order = 145)]
		public int? P028C004 { get; set; }

		[Display(Name = "4-person household", ShortName = "4-person household", Order = 146)]
		public int? P028C005 { get; set; }

		[Display(Name = "5-person household", ShortName = "5-person household", Order = 147)]
		public int? P028C006 { get; set; }

		[Display(Name = "6-person household", ShortName = "6-person household", Order = 148)]
		public int? P028C007 { get; set; }

		[Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 149)]
		public int? P028C008 { get; set; }

		[Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 150)]
		public int? P028C009 { get; set; }

		[Display(Name = "1-person household", ShortName = "1-person household", Order = 151)]
		public int? P028C010 { get; set; }

		[Display(Name = "2-person household", ShortName = "2-person household", Order = 152)]
		public int? P028C011 { get; set; }

		[Display(Name = "3-person household", ShortName = "3-person household", Order = 153)]
		public int? P028C012 { get; set; }

		[Display(Name = "4-person household", ShortName = "4-person household", Order = 154)]
		public int? P028C013 { get; set; }

		[Display(Name = "5-person household", ShortName = "5-person household", Order = 155)]
		public int? P028C014 { get; set; }

		[Display(Name = "6-person household", ShortName = "6-person household", Order = 156)]
		public int? P028C015 { get; set; }

		[Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 157)]
		public int? P028C016 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 158)]
		public int? P028D001 { get; set; }

		[Display(Name = "Family households:", ShortName = "Family households:", Order = 159)]
		public int? P028D002 { get; set; }

		[Display(Name = "2-person household", ShortName = "2-person household", Order = 160)]
		public int? P028D003 { get; set; }

		[Display(Name = "3-person household", ShortName = "3-person household", Order = 161)]
		public int? P028D004 { get; set; }

		[Display(Name = "4-person household", ShortName = "4-person household", Order = 162)]
		public int? P028D005 { get; set; }

		[Display(Name = "5-person household", ShortName = "5-person household", Order = 163)]
		public int? P028D006 { get; set; }

		[Display(Name = "6-person household", ShortName = "6-person household", Order = 164)]
		public int? P028D007 { get; set; }

		[Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 165)]
		public int? P028D008 { get; set; }

		[Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 166)]
		public int? P028D009 { get; set; }

		[Display(Name = "1-person household", ShortName = "1-person household", Order = 167)]
		public int? P028D010 { get; set; }

		[Display(Name = "2-person household", ShortName = "2-person household", Order = 168)]
		public int? P028D011 { get; set; }

		[Display(Name = "3-person household", ShortName = "3-person household", Order = 169)]
		public int? P028D012 { get; set; }

		[Display(Name = "4-person household", ShortName = "4-person household", Order = 170)]
		public int? P028D013 { get; set; }

		[Display(Name = "5-person household", ShortName = "5-person household", Order = 171)]
		public int? P028D014 { get; set; }

		[Display(Name = "6-person household", ShortName = "6-person household", Order = 172)]
		public int? P028D015 { get; set; }

		[Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 173)]
		public int? P028D016 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 174)]
		public int? P028E001 { get; set; }

		[Display(Name = "Family households:", ShortName = "Family households:", Order = 175)]
		public int? P028E002 { get; set; }

		[Display(Name = "2-person household", ShortName = "2-person household", Order = 176)]
		public int? P028E003 { get; set; }

		[Display(Name = "3-person household", ShortName = "3-person household", Order = 177)]
		public int? P028E004 { get; set; }

		[Display(Name = "4-person household", ShortName = "4-person household", Order = 178)]
		public int? P028E005 { get; set; }

		[Display(Name = "5-person household", ShortName = "5-person household", Order = 179)]
		public int? P028E006 { get; set; }

		[Display(Name = "6-person household", ShortName = "6-person household", Order = 180)]
		public int? P028E007 { get; set; }

		[Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 181)]
		public int? P028E008 { get; set; }

		[Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 182)]
		public int? P028E009 { get; set; }

		[Display(Name = "1-person household", ShortName = "1-person household", Order = 183)]
		public int? P028E010 { get; set; }

		[Display(Name = "2-person household", ShortName = "2-person household", Order = 184)]
		public int? P028E011 { get; set; }

		[Display(Name = "3-person household", ShortName = "3-person household", Order = 185)]
		public int? P028E012 { get; set; }

		[Display(Name = "4-person household", ShortName = "4-person household", Order = 186)]
		public int? P028E013 { get; set; }

		[Display(Name = "5-person household", ShortName = "5-person household", Order = 187)]
		public int? P028E014 { get; set; }

		[Display(Name = "6-person household", ShortName = "6-person household", Order = 188)]
		public int? P028E015 { get; set; }

		[Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 189)]
		public int? P028E016 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 190)]
		public int? P028F001 { get; set; }

		[Display(Name = "Family households:", ShortName = "Family households:", Order = 191)]
		public int? P028F002 { get; set; }

		[Display(Name = "2-person household", ShortName = "2-person household", Order = 192)]
		public int? P028F003 { get; set; }

		[Display(Name = "3-person household", ShortName = "3-person household", Order = 193)]
		public int? P028F004 { get; set; }

		[Display(Name = "4-person household", ShortName = "4-person household", Order = 194)]
		public int? P028F005 { get; set; }

		[Display(Name = "5-person household", ShortName = "5-person household", Order = 195)]
		public int? P028F006 { get; set; }

		[Display(Name = "6-person household", ShortName = "6-person household", Order = 196)]
		public int? P028F007 { get; set; }

		[Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 197)]
		public int? P028F008 { get; set; }

		[Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 198)]
		public int? P028F009 { get; set; }

		[Display(Name = "1-person household", ShortName = "1-person household", Order = 199)]
		public int? P028F010 { get; set; }

		[Display(Name = "2-person household", ShortName = "2-person household", Order = 200)]
		public int? P028F011 { get; set; }

		[Display(Name = "3-person household", ShortName = "3-person household", Order = 201)]
		public int? P028F012 { get; set; }

		[Display(Name = "4-person household", ShortName = "4-person household", Order = 202)]
		public int? P028F013 { get; set; }

		[Display(Name = "5-person household", ShortName = "5-person household", Order = 203)]
		public int? P028F014 { get; set; }

		[Display(Name = "6-person household", ShortName = "6-person household", Order = 204)]
		public int? P028F015 { get; set; }

		[Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 205)]
		public int? P028F016 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 206)]
		public int? P028G001 { get; set; }

		[Display(Name = "Family households:", ShortName = "Family households:", Order = 207)]
		public int? P028G002 { get; set; }

		[Display(Name = "2-person household", ShortName = "2-person household", Order = 208)]
		public int? P028G003 { get; set; }

		[Display(Name = "3-person household", ShortName = "3-person household", Order = 209)]
		public int? P028G004 { get; set; }

		[Display(Name = "4-person household", ShortName = "4-person household", Order = 210)]
		public int? P028G005 { get; set; }

		[Display(Name = "5-person household", ShortName = "5-person household", Order = 211)]
		public int? P028G006 { get; set; }

		[Display(Name = "6-person household", ShortName = "6-person household", Order = 212)]
		public int? P028G007 { get; set; }

		[Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 213)]
		public int? P028G008 { get; set; }

		[Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 214)]
		public int? P028G009 { get; set; }

		[Display(Name = "1-person household", ShortName = "1-person household", Order = 215)]
		public int? P028G010 { get; set; }

		[Display(Name = "2-person household", ShortName = "2-person household", Order = 216)]
		public int? P028G011 { get; set; }

		[Display(Name = "3-person household", ShortName = "3-person household", Order = 217)]
		public int? P028G012 { get; set; }

		[Display(Name = "4-person household", ShortName = "4-person household", Order = 218)]
		public int? P028G013 { get; set; }

		[Display(Name = "5-person household", ShortName = "5-person household", Order = 219)]
		public int? P028G014 { get; set; }

		[Display(Name = "6-person household", ShortName = "6-person household", Order = 220)]
		public int? P028G015 { get; set; }

		[Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 221)]
		public int? P028G016 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 222)]
		public int? P028H001 { get; set; }

		[Display(Name = "Family households:", ShortName = "Family households:", Order = 223)]
		public int? P028H002 { get; set; }

		[Display(Name = "2-person household", ShortName = "2-person household", Order = 224)]
		public int? P028H003 { get; set; }

		[Display(Name = "3-person household", ShortName = "3-person household", Order = 225)]
		public int? P028H004 { get; set; }

		[Display(Name = "4-person household", ShortName = "4-person household", Order = 226)]
		public int? P028H005 { get; set; }

		[Display(Name = "5-person household", ShortName = "5-person household", Order = 227)]
		public int? P028H006 { get; set; }

		[Display(Name = "6-person household", ShortName = "6-person household", Order = 228)]
		public int? P028H007 { get; set; }

		[Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 229)]
		public int? P028H008 { get; set; }

		[Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 230)]
		public int? P028H009 { get; set; }

		[Display(Name = "1-person household", ShortName = "1-person household", Order = 231)]
		public int? P028H010 { get; set; }

		[Display(Name = "2-person household", ShortName = "2-person household", Order = 232)]
		public int? P028H011 { get; set; }

		[Display(Name = "3-person household", ShortName = "3-person household", Order = 233)]
		public int? P028H012 { get; set; }

		[Display(Name = "4-person household", ShortName = "4-person household", Order = 234)]
		public int? P028H013 { get; set; }

		[Display(Name = "5-person household", ShortName = "5-person household", Order = 235)]
		public int? P028H014 { get; set; }

		[Display(Name = "6-person household", ShortName = "6-person household", Order = 236)]
		public int? P028H015 { get; set; }

		[Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 237)]
		public int? P028H016 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 238)]
		public int? P028I001 { get; set; }

		[Display(Name = "Family households:", ShortName = "Family households:", Order = 239)]
		public int? P028I002 { get; set; }

		[Display(Name = "2-person household", ShortName = "2-person household", Order = 240)]
		public int? P028I003 { get; set; }

		[Display(Name = "3-person household", ShortName = "3-person household", Order = 241)]
		public int? P028I004 { get; set; }

		[Display(Name = "4-person household", ShortName = "4-person household", Order = 242)]
		public int? P028I005 { get; set; }

		[Display(Name = "5-person household", ShortName = "5-person household", Order = 243)]
		public int? P028I006 { get; set; }

		[Display(Name = "6-person household", ShortName = "6-person household", Order = 244)]
		public int? P028I007 { get; set; }

		[Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 245)]
		public int? P028I008 { get; set; }

		[Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 246)]
		public int? P028I009 { get; set; }

		[Display(Name = "1-person household", ShortName = "1-person household", Order = 247)]
		public int? P028I010 { get; set; }

		[Display(Name = "2-person household", ShortName = "2-person household", Order = 248)]
		public int? P028I011 { get; set; }

		[Display(Name = "3-person household", ShortName = "3-person household", Order = 249)]
		public int? P028I012 { get; set; }

		[Display(Name = "4-person household", ShortName = "4-person household", Order = 250)]
		public int? P028I013 { get; set; }

		[Display(Name = "5-person household", ShortName = "5-person household", Order = 251)]
		public int? P028I014 { get; set; }

		[Display(Name = "6-person household", ShortName = "6-person household", Order = 252)]
		public int? P028I015 { get; set; }

		[Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 253)]
		public int? P028I016 { get; set; }
		#endregion Properties

		#region Constructors
		public SF1CongressionalDistricts113_SF1_00009(string csvLine) : base(csvLine) { }

		public SF1CongressionalDistricts113_SF1_00009(string[] values) : base(values) { }

		public SF1CongressionalDistricts113_SF1_00009(OleDbDataReader reader)
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
				P017B001 = (decimal?)reader[5];
			}
			if (reader[6] != DBNull.Value)
			{
				P017B002 = (decimal?)reader[6];
			}
			if (reader[7] != DBNull.Value)
			{
				P017B003 = (decimal?)reader[7];
			}
			if (reader[8] != DBNull.Value)
			{
				P017C001 = (decimal?)reader[8];
			}
			if (reader[9] != DBNull.Value)
			{
				P017C002 = (decimal?)reader[9];
			}
			if (reader[10] != DBNull.Value)
			{
				P017C003 = (decimal?)reader[10];
			}
			if (reader[11] != DBNull.Value)
			{
				P017D001 = (decimal?)reader[11];
			}
			if (reader[12] != DBNull.Value)
			{
				P017D002 = (decimal?)reader[12];
			}
			if (reader[13] != DBNull.Value)
			{
				P017D003 = (decimal?)reader[13];
			}
			if (reader[14] != DBNull.Value)
			{
				P017E001 = (decimal?)reader[14];
			}
			if (reader[15] != DBNull.Value)
			{
				P017E002 = (decimal?)reader[15];
			}
			if (reader[16] != DBNull.Value)
			{
				P017E003 = (decimal?)reader[16];
			}
			if (reader[17] != DBNull.Value)
			{
				P017F001 = (decimal?)reader[17];
			}
			if (reader[18] != DBNull.Value)
			{
				P017F002 = (decimal?)reader[18];
			}
			if (reader[19] != DBNull.Value)
			{
				P017F003 = (decimal?)reader[19];
			}
			if (reader[20] != DBNull.Value)
			{
				P017G001 = (decimal?)reader[20];
			}
			if (reader[21] != DBNull.Value)
			{
				P017G002 = (decimal?)reader[21];
			}
			if (reader[22] != DBNull.Value)
			{
				P017G003 = (decimal?)reader[22];
			}
			if (reader[23] != DBNull.Value)
			{
				P017H001 = (decimal?)reader[23];
			}
			if (reader[24] != DBNull.Value)
			{
				P017H002 = (decimal?)reader[24];
			}
			if (reader[25] != DBNull.Value)
			{
				P017H003 = (decimal?)reader[25];
			}
			if (reader[26] != DBNull.Value)
			{
				P017I001 = (decimal?)reader[26];
			}
			if (reader[27] != DBNull.Value)
			{
				P017I002 = (decimal?)reader[27];
			}
			if (reader[28] != DBNull.Value)
			{
				P017I003 = (decimal?)reader[28];
			}
			if (reader[29] != DBNull.Value)
			{
				P018A001 = (int?)reader[29];
			}
			if (reader[30] != DBNull.Value)
			{
				P018A002 = (int?)reader[30];
			}
			if (reader[31] != DBNull.Value)
			{
				P018A003 = (int?)reader[31];
			}
			if (reader[32] != DBNull.Value)
			{
				P018A004 = (int?)reader[32];
			}
			if (reader[33] != DBNull.Value)
			{
				P018A005 = (int?)reader[33];
			}
			if (reader[34] != DBNull.Value)
			{
				P018A006 = (int?)reader[34];
			}
			if (reader[35] != DBNull.Value)
			{
				P018A007 = (int?)reader[35];
			}
			if (reader[36] != DBNull.Value)
			{
				P018A008 = (int?)reader[36];
			}
			if (reader[37] != DBNull.Value)
			{
				P018A009 = (int?)reader[37];
			}
			if (reader[38] != DBNull.Value)
			{
				P018B001 = (int?)reader[38];
			}
			if (reader[39] != DBNull.Value)
			{
				P018B002 = (int?)reader[39];
			}
			if (reader[40] != DBNull.Value)
			{
				P018B003 = (int?)reader[40];
			}
			if (reader[41] != DBNull.Value)
			{
				P018B004 = (int?)reader[41];
			}
			if (reader[42] != DBNull.Value)
			{
				P018B005 = (int?)reader[42];
			}
			if (reader[43] != DBNull.Value)
			{
				P018B006 = (int?)reader[43];
			}
			if (reader[44] != DBNull.Value)
			{
				P018B007 = (int?)reader[44];
			}
			if (reader[45] != DBNull.Value)
			{
				P018B008 = (int?)reader[45];
			}
			if (reader[46] != DBNull.Value)
			{
				P018B009 = (int?)reader[46];
			}
			if (reader[47] != DBNull.Value)
			{
				P018C001 = (int?)reader[47];
			}
			if (reader[48] != DBNull.Value)
			{
				P018C002 = (int?)reader[48];
			}
			if (reader[49] != DBNull.Value)
			{
				P018C003 = (int?)reader[49];
			}
			if (reader[50] != DBNull.Value)
			{
				P018C004 = (int?)reader[50];
			}
			if (reader[51] != DBNull.Value)
			{
				P018C005 = (int?)reader[51];
			}
			if (reader[52] != DBNull.Value)
			{
				P018C006 = (int?)reader[52];
			}
			if (reader[53] != DBNull.Value)
			{
				P018C007 = (int?)reader[53];
			}
			if (reader[54] != DBNull.Value)
			{
				P018C008 = (int?)reader[54];
			}
			if (reader[55] != DBNull.Value)
			{
				P018C009 = (int?)reader[55];
			}
			if (reader[56] != DBNull.Value)
			{
				P018D001 = (int?)reader[56];
			}
			if (reader[57] != DBNull.Value)
			{
				P018D002 = (int?)reader[57];
			}
			if (reader[58] != DBNull.Value)
			{
				P018D003 = (int?)reader[58];
			}
			if (reader[59] != DBNull.Value)
			{
				P018D004 = (int?)reader[59];
			}
			if (reader[60] != DBNull.Value)
			{
				P018D005 = (int?)reader[60];
			}
			if (reader[61] != DBNull.Value)
			{
				P018D006 = (int?)reader[61];
			}
			if (reader[62] != DBNull.Value)
			{
				P018D007 = (int?)reader[62];
			}
			if (reader[63] != DBNull.Value)
			{
				P018D008 = (int?)reader[63];
			}
			if (reader[64] != DBNull.Value)
			{
				P018D009 = (int?)reader[64];
			}
			if (reader[65] != DBNull.Value)
			{
				P018E001 = (int?)reader[65];
			}
			if (reader[66] != DBNull.Value)
			{
				P018E002 = (int?)reader[66];
			}
			if (reader[67] != DBNull.Value)
			{
				P018E003 = (int?)reader[67];
			}
			if (reader[68] != DBNull.Value)
			{
				P018E004 = (int?)reader[68];
			}
			if (reader[69] != DBNull.Value)
			{
				P018E005 = (int?)reader[69];
			}
			if (reader[70] != DBNull.Value)
			{
				P018E006 = (int?)reader[70];
			}
			if (reader[71] != DBNull.Value)
			{
				P018E007 = (int?)reader[71];
			}
			if (reader[72] != DBNull.Value)
			{
				P018E008 = (int?)reader[72];
			}
			if (reader[73] != DBNull.Value)
			{
				P018E009 = (int?)reader[73];
			}
			if (reader[74] != DBNull.Value)
			{
				P018F001 = (int?)reader[74];
			}
			if (reader[75] != DBNull.Value)
			{
				P018F002 = (int?)reader[75];
			}
			if (reader[76] != DBNull.Value)
			{
				P018F003 = (int?)reader[76];
			}
			if (reader[77] != DBNull.Value)
			{
				P018F004 = (int?)reader[77];
			}
			if (reader[78] != DBNull.Value)
			{
				P018F005 = (int?)reader[78];
			}
			if (reader[79] != DBNull.Value)
			{
				P018F006 = (int?)reader[79];
			}
			if (reader[80] != DBNull.Value)
			{
				P018F007 = (int?)reader[80];
			}
			if (reader[81] != DBNull.Value)
			{
				P018F008 = (int?)reader[81];
			}
			if (reader[82] != DBNull.Value)
			{
				P018F009 = (int?)reader[82];
			}
			if (reader[83] != DBNull.Value)
			{
				P018G001 = (int?)reader[83];
			}
			if (reader[84] != DBNull.Value)
			{
				P018G002 = (int?)reader[84];
			}
			if (reader[85] != DBNull.Value)
			{
				P018G003 = (int?)reader[85];
			}
			if (reader[86] != DBNull.Value)
			{
				P018G004 = (int?)reader[86];
			}
			if (reader[87] != DBNull.Value)
			{
				P018G005 = (int?)reader[87];
			}
			if (reader[88] != DBNull.Value)
			{
				P018G006 = (int?)reader[88];
			}
			if (reader[89] != DBNull.Value)
			{
				P018G007 = (int?)reader[89];
			}
			if (reader[90] != DBNull.Value)
			{
				P018G008 = (int?)reader[90];
			}
			if (reader[91] != DBNull.Value)
			{
				P018G009 = (int?)reader[91];
			}
			if (reader[92] != DBNull.Value)
			{
				P018H001 = (int?)reader[92];
			}
			if (reader[93] != DBNull.Value)
			{
				P018H002 = (int?)reader[93];
			}
			if (reader[94] != DBNull.Value)
			{
				P018H003 = (int?)reader[94];
			}
			if (reader[95] != DBNull.Value)
			{
				P018H004 = (int?)reader[95];
			}
			if (reader[96] != DBNull.Value)
			{
				P018H005 = (int?)reader[96];
			}
			if (reader[97] != DBNull.Value)
			{
				P018H006 = (int?)reader[97];
			}
			if (reader[98] != DBNull.Value)
			{
				P018H007 = (int?)reader[98];
			}
			if (reader[99] != DBNull.Value)
			{
				P018H008 = (int?)reader[99];
			}
			if (reader[100] != DBNull.Value)
			{
				P018H009 = (int?)reader[100];
			}
			if (reader[101] != DBNull.Value)
			{
				P018I001 = (int?)reader[101];
			}
			if (reader[102] != DBNull.Value)
			{
				P018I002 = (int?)reader[102];
			}
			if (reader[103] != DBNull.Value)
			{
				P018I003 = (int?)reader[103];
			}
			if (reader[104] != DBNull.Value)
			{
				P018I004 = (int?)reader[104];
			}
			if (reader[105] != DBNull.Value)
			{
				P018I005 = (int?)reader[105];
			}
			if (reader[106] != DBNull.Value)
			{
				P018I006 = (int?)reader[106];
			}
			if (reader[107] != DBNull.Value)
			{
				P018I007 = (int?)reader[107];
			}
			if (reader[108] != DBNull.Value)
			{
				P018I008 = (int?)reader[108];
			}
			if (reader[109] != DBNull.Value)
			{
				P018I009 = (int?)reader[109];
			}
			if (reader[110] != DBNull.Value)
			{
				P028A001 = (int?)reader[110];
			}
			if (reader[111] != DBNull.Value)
			{
				P028A002 = (int?)reader[111];
			}
			if (reader[112] != DBNull.Value)
			{
				P028A003 = (int?)reader[112];
			}
			if (reader[113] != DBNull.Value)
			{
				P028A004 = (int?)reader[113];
			}
			if (reader[114] != DBNull.Value)
			{
				P028A005 = (int?)reader[114];
			}
			if (reader[115] != DBNull.Value)
			{
				P028A006 = (int?)reader[115];
			}
			if (reader[116] != DBNull.Value)
			{
				P028A007 = (int?)reader[116];
			}
			if (reader[117] != DBNull.Value)
			{
				P028A008 = (int?)reader[117];
			}
			if (reader[118] != DBNull.Value)
			{
				P028A009 = (int?)reader[118];
			}
			if (reader[119] != DBNull.Value)
			{
				P028A010 = (int?)reader[119];
			}
			if (reader[120] != DBNull.Value)
			{
				P028A011 = (int?)reader[120];
			}
			if (reader[121] != DBNull.Value)
			{
				P028A012 = (int?)reader[121];
			}
			if (reader[122] != DBNull.Value)
			{
				P028A013 = (int?)reader[122];
			}
			if (reader[123] != DBNull.Value)
			{
				P028A014 = (int?)reader[123];
			}
			if (reader[124] != DBNull.Value)
			{
				P028A015 = (int?)reader[124];
			}
			if (reader[125] != DBNull.Value)
			{
				P028A016 = (int?)reader[125];
			}
			if (reader[126] != DBNull.Value)
			{
				P028B001 = (int?)reader[126];
			}
			if (reader[127] != DBNull.Value)
			{
				P028B002 = (int?)reader[127];
			}
			if (reader[128] != DBNull.Value)
			{
				P028B003 = (int?)reader[128];
			}
			if (reader[129] != DBNull.Value)
			{
				P028B004 = (int?)reader[129];
			}
			if (reader[130] != DBNull.Value)
			{
				P028B005 = (int?)reader[130];
			}
			if (reader[131] != DBNull.Value)
			{
				P028B006 = (int?)reader[131];
			}
			if (reader[132] != DBNull.Value)
			{
				P028B007 = (int?)reader[132];
			}
			if (reader[133] != DBNull.Value)
			{
				P028B008 = (int?)reader[133];
			}
			if (reader[134] != DBNull.Value)
			{
				P028B009 = (int?)reader[134];
			}
			if (reader[135] != DBNull.Value)
			{
				P028B010 = (int?)reader[135];
			}
			if (reader[136] != DBNull.Value)
			{
				P028B011 = (int?)reader[136];
			}
			if (reader[137] != DBNull.Value)
			{
				P028B012 = (int?)reader[137];
			}
			if (reader[138] != DBNull.Value)
			{
				P028B013 = (int?)reader[138];
			}
			if (reader[139] != DBNull.Value)
			{
				P028B014 = (int?)reader[139];
			}
			if (reader[140] != DBNull.Value)
			{
				P028B015 = (int?)reader[140];
			}
			if (reader[141] != DBNull.Value)
			{
				P028B016 = (int?)reader[141];
			}
			if (reader[142] != DBNull.Value)
			{
				P028C001 = (int?)reader[142];
			}
			if (reader[143] != DBNull.Value)
			{
				P028C002 = (int?)reader[143];
			}
			if (reader[144] != DBNull.Value)
			{
				P028C003 = (int?)reader[144];
			}
			if (reader[145] != DBNull.Value)
			{
				P028C004 = (int?)reader[145];
			}
			if (reader[146] != DBNull.Value)
			{
				P028C005 = (int?)reader[146];
			}
			if (reader[147] != DBNull.Value)
			{
				P028C006 = (int?)reader[147];
			}
			if (reader[148] != DBNull.Value)
			{
				P028C007 = (int?)reader[148];
			}
			if (reader[149] != DBNull.Value)
			{
				P028C008 = (int?)reader[149];
			}
			if (reader[150] != DBNull.Value)
			{
				P028C009 = (int?)reader[150];
			}
			if (reader[151] != DBNull.Value)
			{
				P028C010 = (int?)reader[151];
			}
			if (reader[152] != DBNull.Value)
			{
				P028C011 = (int?)reader[152];
			}
			if (reader[153] != DBNull.Value)
			{
				P028C012 = (int?)reader[153];
			}
			if (reader[154] != DBNull.Value)
			{
				P028C013 = (int?)reader[154];
			}
			if (reader[155] != DBNull.Value)
			{
				P028C014 = (int?)reader[155];
			}
			if (reader[156] != DBNull.Value)
			{
				P028C015 = (int?)reader[156];
			}
			if (reader[157] != DBNull.Value)
			{
				P028C016 = (int?)reader[157];
			}
			if (reader[158] != DBNull.Value)
			{
				P028D001 = (int?)reader[158];
			}
			if (reader[159] != DBNull.Value)
			{
				P028D002 = (int?)reader[159];
			}
			if (reader[160] != DBNull.Value)
			{
				P028D003 = (int?)reader[160];
			}
			if (reader[161] != DBNull.Value)
			{
				P028D004 = (int?)reader[161];
			}
			if (reader[162] != DBNull.Value)
			{
				P028D005 = (int?)reader[162];
			}
			if (reader[163] != DBNull.Value)
			{
				P028D006 = (int?)reader[163];
			}
			if (reader[164] != DBNull.Value)
			{
				P028D007 = (int?)reader[164];
			}
			if (reader[165] != DBNull.Value)
			{
				P028D008 = (int?)reader[165];
			}
			if (reader[166] != DBNull.Value)
			{
				P028D009 = (int?)reader[166];
			}
			if (reader[167] != DBNull.Value)
			{
				P028D010 = (int?)reader[167];
			}
			if (reader[168] != DBNull.Value)
			{
				P028D011 = (int?)reader[168];
			}
			if (reader[169] != DBNull.Value)
			{
				P028D012 = (int?)reader[169];
			}
			if (reader[170] != DBNull.Value)
			{
				P028D013 = (int?)reader[170];
			}
			if (reader[171] != DBNull.Value)
			{
				P028D014 = (int?)reader[171];
			}
			if (reader[172] != DBNull.Value)
			{
				P028D015 = (int?)reader[172];
			}
			if (reader[173] != DBNull.Value)
			{
				P028D016 = (int?)reader[173];
			}
			if (reader[174] != DBNull.Value)
			{
				P028E001 = (int?)reader[174];
			}
			if (reader[175] != DBNull.Value)
			{
				P028E002 = (int?)reader[175];
			}
			if (reader[176] != DBNull.Value)
			{
				P028E003 = (int?)reader[176];
			}
			if (reader[177] != DBNull.Value)
			{
				P028E004 = (int?)reader[177];
			}
			if (reader[178] != DBNull.Value)
			{
				P028E005 = (int?)reader[178];
			}
			if (reader[179] != DBNull.Value)
			{
				P028E006 = (int?)reader[179];
			}
			if (reader[180] != DBNull.Value)
			{
				P028E007 = (int?)reader[180];
			}
			if (reader[181] != DBNull.Value)
			{
				P028E008 = (int?)reader[181];
			}
			if (reader[182] != DBNull.Value)
			{
				P028E009 = (int?)reader[182];
			}
			if (reader[183] != DBNull.Value)
			{
				P028E010 = (int?)reader[183];
			}
			if (reader[184] != DBNull.Value)
			{
				P028E011 = (int?)reader[184];
			}
			if (reader[185] != DBNull.Value)
			{
				P028E012 = (int?)reader[185];
			}
			if (reader[186] != DBNull.Value)
			{
				P028E013 = (int?)reader[186];
			}
			if (reader[187] != DBNull.Value)
			{
				P028E014 = (int?)reader[187];
			}
			if (reader[188] != DBNull.Value)
			{
				P028E015 = (int?)reader[188];
			}
			if (reader[189] != DBNull.Value)
			{
				P028E016 = (int?)reader[189];
			}
			if (reader[190] != DBNull.Value)
			{
				P028F001 = (int?)reader[190];
			}
			if (reader[191] != DBNull.Value)
			{
				P028F002 = (int?)reader[191];
			}
			if (reader[192] != DBNull.Value)
			{
				P028F003 = (int?)reader[192];
			}
			if (reader[193] != DBNull.Value)
			{
				P028F004 = (int?)reader[193];
			}
			if (reader[194] != DBNull.Value)
			{
				P028F005 = (int?)reader[194];
			}
			if (reader[195] != DBNull.Value)
			{
				P028F006 = (int?)reader[195];
			}
			if (reader[196] != DBNull.Value)
			{
				P028F007 = (int?)reader[196];
			}
			if (reader[197] != DBNull.Value)
			{
				P028F008 = (int?)reader[197];
			}
			if (reader[198] != DBNull.Value)
			{
				P028F009 = (int?)reader[198];
			}
			if (reader[199] != DBNull.Value)
			{
				P028F010 = (int?)reader[199];
			}
			if (reader[200] != DBNull.Value)
			{
				P028F011 = (int?)reader[200];
			}
			if (reader[201] != DBNull.Value)
			{
				P028F012 = (int?)reader[201];
			}
			if (reader[202] != DBNull.Value)
			{
				P028F013 = (int?)reader[202];
			}
			if (reader[203] != DBNull.Value)
			{
				P028F014 = (int?)reader[203];
			}
			if (reader[204] != DBNull.Value)
			{
				P028F015 = (int?)reader[204];
			}
			if (reader[205] != DBNull.Value)
			{
				P028F016 = (int?)reader[205];
			}
			if (reader[206] != DBNull.Value)
			{
				P028G001 = (int?)reader[206];
			}
			if (reader[207] != DBNull.Value)
			{
				P028G002 = (int?)reader[207];
			}
			if (reader[208] != DBNull.Value)
			{
				P028G003 = (int?)reader[208];
			}
			if (reader[209] != DBNull.Value)
			{
				P028G004 = (int?)reader[209];
			}
			if (reader[210] != DBNull.Value)
			{
				P028G005 = (int?)reader[210];
			}
			if (reader[211] != DBNull.Value)
			{
				P028G006 = (int?)reader[211];
			}
			if (reader[212] != DBNull.Value)
			{
				P028G007 = (int?)reader[212];
			}
			if (reader[213] != DBNull.Value)
			{
				P028G008 = (int?)reader[213];
			}
			if (reader[214] != DBNull.Value)
			{
				P028G009 = (int?)reader[214];
			}
			if (reader[215] != DBNull.Value)
			{
				P028G010 = (int?)reader[215];
			}
			if (reader[216] != DBNull.Value)
			{
				P028G011 = (int?)reader[216];
			}
			if (reader[217] != DBNull.Value)
			{
				P028G012 = (int?)reader[217];
			}
			if (reader[218] != DBNull.Value)
			{
				P028G013 = (int?)reader[218];
			}
			if (reader[219] != DBNull.Value)
			{
				P028G014 = (int?)reader[219];
			}
			if (reader[220] != DBNull.Value)
			{
				P028G015 = (int?)reader[220];
			}
			if (reader[221] != DBNull.Value)
			{
				P028G016 = (int?)reader[221];
			}
			if (reader[222] != DBNull.Value)
			{
				P028H001 = (int?)reader[222];
			}
			if (reader[223] != DBNull.Value)
			{
				P028H002 = (int?)reader[223];
			}
			if (reader[224] != DBNull.Value)
			{
				P028H003 = (int?)reader[224];
			}
			if (reader[225] != DBNull.Value)
			{
				P028H004 = (int?)reader[225];
			}
			if (reader[226] != DBNull.Value)
			{
				P028H005 = (int?)reader[226];
			}
			if (reader[227] != DBNull.Value)
			{
				P028H006 = (int?)reader[227];
			}
			if (reader[228] != DBNull.Value)
			{
				P028H007 = (int?)reader[228];
			}
			if (reader[229] != DBNull.Value)
			{
				P028H008 = (int?)reader[229];
			}
			if (reader[230] != DBNull.Value)
			{
				P028H009 = (int?)reader[230];
			}
			if (reader[231] != DBNull.Value)
			{
				P028H010 = (int?)reader[231];
			}
			if (reader[232] != DBNull.Value)
			{
				P028H011 = (int?)reader[232];
			}
			if (reader[233] != DBNull.Value)
			{
				P028H012 = (int?)reader[233];
			}
			if (reader[234] != DBNull.Value)
			{
				P028H013 = (int?)reader[234];
			}
			if (reader[235] != DBNull.Value)
			{
				P028H014 = (int?)reader[235];
			}
			if (reader[236] != DBNull.Value)
			{
				P028H015 = (int?)reader[236];
			}
			if (reader[237] != DBNull.Value)
			{
				P028H016 = (int?)reader[237];
			}
			if (reader[238] != DBNull.Value)
			{
				P028I001 = (int?)reader[238];
			}
			if (reader[239] != DBNull.Value)
			{
				P028I002 = (int?)reader[239];
			}
			if (reader[240] != DBNull.Value)
			{
				P028I003 = (int?)reader[240];
			}
			if (reader[241] != DBNull.Value)
			{
				P028I004 = (int?)reader[241];
			}
			if (reader[242] != DBNull.Value)
			{
				P028I005 = (int?)reader[242];
			}
			if (reader[243] != DBNull.Value)
			{
				P028I006 = (int?)reader[243];
			}
			if (reader[244] != DBNull.Value)
			{
				P028I007 = (int?)reader[244];
			}
			if (reader[245] != DBNull.Value)
			{
				P028I008 = (int?)reader[245];
			}
			if (reader[246] != DBNull.Value)
			{
				P028I009 = (int?)reader[246];
			}
			if (reader[247] != DBNull.Value)
			{
				P028I010 = (int?)reader[247];
			}
			if (reader[248] != DBNull.Value)
			{
				P028I011 = (int?)reader[248];
			}
			if (reader[249] != DBNull.Value)
			{
				P028I012 = (int?)reader[249];
			}
			if (reader[250] != DBNull.Value)
			{
				P028I013 = (int?)reader[250];
			}
			if (reader[251] != DBNull.Value)
			{
				P028I014 = (int?)reader[251];
			}
			if (reader[252] != DBNull.Value)
			{
				P028I015 = (int?)reader[252];
			}
			if (reader[253] != DBNull.Value)
			{
				P028I016 = (int?)reader[253];
			}
		}
		#endregion Constructors
	}
}
