namespace CensusDataParser.Generated.Binding
{
	#region Using Directives
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.Data.OleDb;
	#endregion Using Directives

	public class SummaryOne_SF1_00004 : BaseModel
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
		public int? P0100001 { get; set; }

		[Display(Name = "Population of one race:", ShortName = "Population of one race:", Order = 6)]
		public int? P0100002 { get; set; }

		[Display(Name = "White alone", ShortName = "White alone", Order = 7)]
		public int? P0100003 { get; set; }

		[Display(Name = "Black or African American alone", ShortName = "Black or African American alone", Order = 8)]
		public int? P0100004 { get; set; }

		[Display(Name = "American Indian and Alaska Native alone", ShortName = "American Indian and Alaska Native alone", Order = 9)]
		public int? P0100005 { get; set; }

		[Display(Name = "Asian alone", ShortName = "Asian alone", Order = 10)]
		public int? P0100006 { get; set; }

		[Display(Name = "Native Hawaiian and Other Pacific Islander alone", ShortName = "Native Hawaiian and Other Pacific Islander alone", Order = 11)]
		public int? P0100007 { get; set; }

		[Display(Name = "Some Other Race alone", ShortName = "Some Other Race alone", Order = 12)]
		public int? P0100008 { get; set; }

		[Display(Name = "Two or More Races:", ShortName = "Two or More Races:", Order = 13)]
		public int? P0100009 { get; set; }

		[Display(Name = "Population of two races:", ShortName = "Population of two races:", Order = 14)]
		public int? P0100010 { get; set; }

		[Display(Name = "White; Black or African American", ShortName = "White; Black or African American", Order = 15)]
		public int? P0100011 { get; set; }

		[Display(Name = "White; American Indian and Alaska Native", ShortName = "White; American Indian and Alaska Native", Order = 16)]
		public int? P0100012 { get; set; }

		[Display(Name = "White; Asian", ShortName = "White; Asian", Order = 17)]
		public int? P0100013 { get; set; }

		[Display(Name = "White; Native Hawaiian and Other Pacific Islander", ShortName = "White; Native Hawaiian and Other Pacific Islander", Order = 18)]
		public int? P0100014 { get; set; }

		[Display(Name = "White; Some Other Race", ShortName = "White; Some Other Race", Order = 19)]
		public int? P0100015 { get; set; }

		[Display(Name = "Black or African American; American Indian and Alaska Native", ShortName = "Black or African American; American Indian and Alaska Native", Order = 20)]
		public int? P0100016 { get; set; }

		[Display(Name = "Black or African American; Asian", ShortName = "Black or African American; Asian", Order = 21)]
		public int? P0100017 { get; set; }

		[Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander", Order = 22)]
		public int? P0100018 { get; set; }

		[Display(Name = "Black or African American; Some Other Race", ShortName = "Black or African American; Some Other Race", Order = 23)]
		public int? P0100019 { get; set; }

		[Display(Name = "American Indian and Alaska Native; Asian", ShortName = "American Indian and Alaska Native; Asian", Order = 24)]
		public int? P0100020 { get; set; }

		[Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 25)]
		public int? P0100021 { get; set; }

		[Display(Name = "American Indian and Alaska Native; Some Other Race", ShortName = "American Indian and Alaska Native; Some Other Race", Order = 26)]
		public int? P0100022 { get; set; }

		[Display(Name = "Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Asian; Native Hawaiian and Other Pacific Islander", Order = 27)]
		public int? P0100023 { get; set; }

		[Display(Name = "Asian; Some Other Race", ShortName = "Asian; Some Other Race", Order = 28)]
		public int? P0100024 { get; set; }

		[Display(Name = "Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 29)]
		public int? P0100025 { get; set; }

		[Display(Name = "Population of three races:", ShortName = "Population of three races:", Order = 30)]
		public int? P0100026 { get; set; }

		[Display(Name = "White; Black or African American; American Indian and Alaska Native", ShortName = "White; Black or African American; American Indian and Alaska Native", Order = 31)]
		public int? P0100027 { get; set; }

		[Display(Name = "White; Black or African American; Asian", ShortName = "White; Black or African American; Asian", Order = 32)]
		public int? P0100028 { get; set; }

		[Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander", Order = 33)]
		public int? P0100029 { get; set; }

		[Display(Name = "White; Black or African American; Some Other Race", ShortName = "White; Black or African American; Some Other Race", Order = 34)]
		public int? P0100030 { get; set; }

		[Display(Name = "White; American Indian and Alaska Native; Asian", ShortName = "White; American Indian and Alaska Native; Asian", Order = 35)]
		public int? P0100031 { get; set; }

		[Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 36)]
		public int? P0100032 { get; set; }

		[Display(Name = "White; American Indian and Alaska Native; Some Other Race", ShortName = "White; American Indian and Alaska Native; Some Other Race", Order = 37)]
		public int? P0100033 { get; set; }

		[Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander", Order = 38)]
		public int? P0100034 { get; set; }

		[Display(Name = "White; Asian; Some Other Race", ShortName = "White; Asian; Some Other Race", Order = 39)]
		public int? P0100035 { get; set; }

		[Display(Name = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 40)]
		public int? P0100036 { get; set; }

		[Display(Name = "Black or African American; American Indian and Alaska Native; Asian", ShortName = "Black or African American; American Indian and Alaska Native; Asian", Order = 41)]
		public int? P0100037 { get; set; }

		[Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 42)]
		public int? P0100038 { get; set; }

		[Display(Name = "Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Some Other Race", Order = 43)]
		public int? P0100039 { get; set; }

		[Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 44)]
		public int? P0100040 { get; set; }

		[Display(Name = "Black or African American; Asian; Some Other Race", ShortName = "Black or African American; Asian; Some Other Race", Order = 45)]
		public int? P0100041 { get; set; }

		[Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 46)]
		public int? P0100042 { get; set; }

		[Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 47)]
		public int? P0100043 { get; set; }

		[Display(Name = "American Indian and Alaska Native; Asian; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Some Other Race", Order = 48)]
		public int? P0100044 { get; set; }

		[Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 49)]
		public int? P0100045 { get; set; }

		[Display(Name = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 50)]
		public int? P0100046 { get; set; }

		[Display(Name = "Population of four races:", ShortName = "Population of four races:", Order = 51)]
		public int? P0100047 { get; set; }

		[Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian", Order = 52)]
		public int? P0100048 { get; set; }

		[Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 53)]
		public int? P0100049 { get; set; }

		[Display(Name = "White; Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Some Other Race", Order = 54)]
		public int? P0100050 { get; set; }

		[Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 55)]
		public int? P0100051 { get; set; }

		[Display(Name = "White; Black or African American; Asian; Some Other Race", ShortName = "White; Black or African American; Asian; Some Other Race", Order = 56)]
		public int? P0100052 { get; set; }

		[Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 57)]
		public int? P0100053 { get; set; }

		[Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 58)]
		public int? P0100054 { get; set; }

		[Display(Name = "White; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Some Other Race", Order = 59)]
		public int? P0100055 { get; set; }

		[Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 60)]
		public int? P0100056 { get; set; }

		[Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 61)]
		public int? P0100057 { get; set; }

		[Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 62)]
		public int? P0100058 { get; set; }

		[Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 63)]
		public int? P0100059 { get; set; }

		[Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 64)]
		public int? P0100060 { get; set; }

		[Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 65)]
		public int? P0100061 { get; set; }

		[Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 66)]
		public int? P0100062 { get; set; }

		[Display(Name = "Population of five races:", ShortName = "Population of five races:", Order = 67)]
		public int? P0100063 { get; set; }

		[Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 68)]
		public int? P0100064 { get; set; }

		[Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 69)]
		public int? P0100065 { get; set; }

		[Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 70)]
		public int? P0100066 { get; set; }

		[Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 71)]
		public int? P0100067 { get; set; }

		[Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 72)]
		public int? P0100068 { get; set; }

		[Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 73)]
		public int? P0100069 { get; set; }

		[Display(Name = "Population of six races:", ShortName = "Population of six races:", Order = 74)]
		public int? P0100070 { get; set; }

		[Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 75)]
		public int? P0100071 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 76)]
		public int? P0110001 { get; set; }

		[Display(Name = "Hispanic or Latino", ShortName = "Hispanic or Latino", Order = 77)]
		public int? P0110002 { get; set; }

		[Display(Name = "Not Hispanic or Latino:", ShortName = "Not Hispanic or Latino:", Order = 78)]
		public int? P0110003 { get; set; }

		[Display(Name = "Population of one race:", ShortName = "Population of one race:", Order = 79)]
		public int? P0110004 { get; set; }

		[Display(Name = "White alone", ShortName = "White alone", Order = 80)]
		public int? P0110005 { get; set; }

		[Display(Name = "Black or African American alone", ShortName = "Black or African American alone", Order = 81)]
		public int? P0110006 { get; set; }

		[Display(Name = "American Indian and Alaska Native alone", ShortName = "American Indian and Alaska Native alone", Order = 82)]
		public int? P0110007 { get; set; }

		[Display(Name = "Asian alone", ShortName = "Asian alone", Order = 83)]
		public int? P0110008 { get; set; }

		[Display(Name = "Native Hawaiian and Other Pacific Islander alone", ShortName = "Native Hawaiian and Other Pacific Islander alone", Order = 84)]
		public int? P0110009 { get; set; }

		[Display(Name = "Some Other Race alone", ShortName = "Some Other Race alone", Order = 85)]
		public int? P0110010 { get; set; }

		[Display(Name = "Two or More Races:", ShortName = "Two or More Races:", Order = 86)]
		public int? P0110011 { get; set; }

		[Display(Name = "Population of two races:", ShortName = "Population of two races:", Order = 87)]
		public int? P0110012 { get; set; }

		[Display(Name = "White; Black or African American", ShortName = "White; Black or African American", Order = 88)]
		public int? P0110013 { get; set; }

		[Display(Name = "White; American Indian and Alaska Native", ShortName = "White; American Indian and Alaska Native", Order = 89)]
		public int? P0110014 { get; set; }

		[Display(Name = "White; Asian", ShortName = "White; Asian", Order = 90)]
		public int? P0110015 { get; set; }

		[Display(Name = "White; Native Hawaiian and Other Pacific Islander", ShortName = "White; Native Hawaiian and Other Pacific Islander", Order = 91)]
		public int? P0110016 { get; set; }

		[Display(Name = "White; Some Other Race", ShortName = "White; Some Other Race", Order = 92)]
		public int? P0110017 { get; set; }

		[Display(Name = "Black or African American; American Indian and Alaska Native", ShortName = "Black or African American; American Indian and Alaska Native", Order = 93)]
		public int? P0110018 { get; set; }

		[Display(Name = "Black or African American; Asian", ShortName = "Black or African American; Asian", Order = 94)]
		public int? P0110019 { get; set; }

		[Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander", Order = 95)]
		public int? P0110020 { get; set; }

		[Display(Name = "Black or African American; Some Other Race", ShortName = "Black or African American; Some Other Race", Order = 96)]
		public int? P0110021 { get; set; }

		[Display(Name = "American Indian and Alaska Native; Asian", ShortName = "American Indian and Alaska Native; Asian", Order = 97)]
		public int? P0110022 { get; set; }

		[Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 98)]
		public int? P0110023 { get; set; }

		[Display(Name = "American Indian and Alaska Native; Some Other Race", ShortName = "American Indian and Alaska Native; Some Other Race", Order = 99)]
		public int? P0110024 { get; set; }

		[Display(Name = "Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Asian; Native Hawaiian and Other Pacific Islander", Order = 100)]
		public int? P0110025 { get; set; }

		[Display(Name = "Asian; Some Other Race", ShortName = "Asian; Some Other Race", Order = 101)]
		public int? P0110026 { get; set; }

		[Display(Name = "Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 102)]
		public int? P0110027 { get; set; }

		[Display(Name = "Population of three races:", ShortName = "Population of three races:", Order = 103)]
		public int? P0110028 { get; set; }

		[Display(Name = "White; Black or African American; American Indian and Alaska Native", ShortName = "White; Black or African American; American Indian and Alaska Native", Order = 104)]
		public int? P0110029 { get; set; }

		[Display(Name = "White; Black or African American; Asian", ShortName = "White; Black or African American; Asian", Order = 105)]
		public int? P0110030 { get; set; }

		[Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander", Order = 106)]
		public int? P0110031 { get; set; }

		[Display(Name = "White; Black or African American; Some Other Race", ShortName = "White; Black or African American; Some Other Race", Order = 107)]
		public int? P0110032 { get; set; }

		[Display(Name = "White; American Indian and Alaska Native; Asian", ShortName = "White; American Indian and Alaska Native; Asian", Order = 108)]
		public int? P0110033 { get; set; }

		[Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 109)]
		public int? P0110034 { get; set; }

		[Display(Name = "White; American Indian and Alaska Native; Some Other Race", ShortName = "White; American Indian and Alaska Native; Some Other Race", Order = 110)]
		public int? P0110035 { get; set; }

		[Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander", Order = 111)]
		public int? P0110036 { get; set; }

		[Display(Name = "White; Asian; Some Other Race", ShortName = "White; Asian; Some Other Race", Order = 112)]
		public int? P0110037 { get; set; }

		[Display(Name = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 113)]
		public int? P0110038 { get; set; }

		[Display(Name = "Black or African American; American Indian and Alaska Native; Asian", ShortName = "Black or African American; American Indian and Alaska Native; Asian", Order = 114)]
		public int? P0110039 { get; set; }

		[Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 115)]
		public int? P0110040 { get; set; }

		[Display(Name = "Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Some Other Race", Order = 116)]
		public int? P0110041 { get; set; }

		[Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 117)]
		public int? P0110042 { get; set; }

		[Display(Name = "Black or African American; Asian; Some Other Race", ShortName = "Black or African American; Asian; Some Other Race", Order = 118)]
		public int? P0110043 { get; set; }

		[Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 119)]
		public int? P0110044 { get; set; }

		[Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 120)]
		public int? P0110045 { get; set; }

		[Display(Name = "American Indian and Alaska Native; Asian; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Some Other Race", Order = 121)]
		public int? P0110046 { get; set; }

		[Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 122)]
		public int? P0110047 { get; set; }

		[Display(Name = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 123)]
		public int? P0110048 { get; set; }

		[Display(Name = "Population of four races:", ShortName = "Population of four races:", Order = 124)]
		public int? P0110049 { get; set; }

		[Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian", Order = 125)]
		public int? P0110050 { get; set; }

		[Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 126)]
		public int? P0110051 { get; set; }

		[Display(Name = "White; Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Some Other Race", Order = 127)]
		public int? P0110052 { get; set; }

		[Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 128)]
		public int? P0110053 { get; set; }

		[Display(Name = "White; Black or African American; Asian; Some Other Race", ShortName = "White; Black or African American; Asian; Some Other Race", Order = 129)]
		public int? P0110054 { get; set; }

		[Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 130)]
		public int? P0110055 { get; set; }

		[Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 131)]
		public int? P0110056 { get; set; }

		[Display(Name = "White; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Some Other Race", Order = 132)]
		public int? P0110057 { get; set; }

		[Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 133)]
		public int? P0110058 { get; set; }

		[Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 134)]
		public int? P0110059 { get; set; }

		[Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 135)]
		public int? P0110060 { get; set; }

		[Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 136)]
		public int? P0110061 { get; set; }

		[Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 137)]
		public int? P0110062 { get; set; }

		[Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 138)]
		public int? P0110063 { get; set; }

		[Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 139)]
		public int? P0110064 { get; set; }

		[Display(Name = "Population of five races:", ShortName = "Population of five races:", Order = 140)]
		public int? P0110065 { get; set; }

		[Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 141)]
		public int? P0110066 { get; set; }

		[Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 142)]
		public int? P0110067 { get; set; }

		[Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 143)]
		public int? P0110068 { get; set; }

		[Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 144)]
		public int? P0110069 { get; set; }

		[Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 145)]
		public int? P0110070 { get; set; }

		[Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 146)]
		public int? P0110071 { get; set; }

		[Display(Name = "Population of six races:", ShortName = "Population of six races:", Order = 147)]
		public int? P0110072 { get; set; }

		[Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 148)]
		public int? P0110073 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 149)]
		public int? P0120001 { get; set; }

		[Display(Name = "Male:", ShortName = "Male:", Order = 150)]
		public int? P0120002 { get; set; }

		[Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 151)]
		public int? P0120003 { get; set; }

		[Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 152)]
		public int? P0120004 { get; set; }

		[Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 153)]
		public int? P0120005 { get; set; }

		[Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 154)]
		public int? P0120006 { get; set; }

		[Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 155)]
		public int? P0120007 { get; set; }

		[Display(Name = "20 years", ShortName = "20 years", Order = 156)]
		public int? P0120008 { get; set; }

		[Display(Name = "21 years", ShortName = "21 years", Order = 157)]
		public int? P0120009 { get; set; }

		[Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 158)]
		public int? P0120010 { get; set; }

		[Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 159)]
		public int? P0120011 { get; set; }

		[Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 160)]
		public int? P0120012 { get; set; }

		[Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 161)]
		public int? P0120013 { get; set; }

		[Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 162)]
		public int? P0120014 { get; set; }

		[Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 163)]
		public int? P0120015 { get; set; }

		[Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 164)]
		public int? P0120016 { get; set; }

		[Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 165)]
		public int? P0120017 { get; set; }

		[Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 166)]
		public int? P0120018 { get; set; }

		[Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 167)]
		public int? P0120019 { get; set; }

		[Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 168)]
		public int? P0120020 { get; set; }

		[Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 169)]
		public int? P0120021 { get; set; }

		[Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 170)]
		public int? P0120022 { get; set; }

		[Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 171)]
		public int? P0120023 { get; set; }

		[Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 172)]
		public int? P0120024 { get; set; }

		[Display(Name = "85 years and over", ShortName = "85 years and over", Order = 173)]
		public int? P0120025 { get; set; }

		[Display(Name = "Female:", ShortName = "Female:", Order = 174)]
		public int? P0120026 { get; set; }

		[Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 175)]
		public int? P0120027 { get; set; }

		[Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 176)]
		public int? P0120028 { get; set; }

		[Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 177)]
		public int? P0120029 { get; set; }

		[Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 178)]
		public int? P0120030 { get; set; }

		[Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 179)]
		public int? P0120031 { get; set; }

		[Display(Name = "20 years", ShortName = "20 years", Order = 180)]
		public int? P0120032 { get; set; }

		[Display(Name = "21 years", ShortName = "21 years", Order = 181)]
		public int? P0120033 { get; set; }

		[Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 182)]
		public int? P0120034 { get; set; }

		[Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 183)]
		public int? P0120035 { get; set; }

		[Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 184)]
		public int? P0120036 { get; set; }

		[Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 185)]
		public int? P0120037 { get; set; }

		[Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 186)]
		public int? P0120038 { get; set; }

		[Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 187)]
		public int? P0120039 { get; set; }

		[Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 188)]
		public int? P0120040 { get; set; }

		[Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 189)]
		public int? P0120041 { get; set; }

		[Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 190)]
		public int? P0120042 { get; set; }

		[Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 191)]
		public int? P0120043 { get; set; }

		[Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 192)]
		public int? P0120044 { get; set; }

		[Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 193)]
		public int? P0120045 { get; set; }

		[Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 194)]
		public int? P0120046 { get; set; }

		[Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 195)]
		public int? P0120047 { get; set; }

		[Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 196)]
		public int? P0120048 { get; set; }

		[Display(Name = "85 years and over", ShortName = "85 years and over", Order = 197)]
		public int? P0120049 { get; set; }

		[Display(Name = "Both sexes", ShortName = "Both sexes", Order = 198)]
		public decimal? P0130001 { get; set; }

		[Display(Name = "Male", ShortName = "Male", Order = 199)]
		public decimal? P0130002 { get; set; }

		[Display(Name = "Female", ShortName = "Female", Order = 200)]
		public decimal? P0130003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 201)]
		public int? P0140001 { get; set; }

		[Display(Name = "Male:", ShortName = "Male:", Order = 202)]
		public int? P0140002 { get; set; }

		[Display(Name = "Under 1 year", ShortName = "Under 1 year", Order = 203)]
		public int? P0140003 { get; set; }

		[Display(Name = "1 year", ShortName = "1 year", Order = 204)]
		public int? P0140004 { get; set; }

		[Display(Name = "2 years", ShortName = "2 years", Order = 205)]
		public int? P0140005 { get; set; }

		[Display(Name = "3 years", ShortName = "3 years", Order = 206)]
		public int? P0140006 { get; set; }

		[Display(Name = "4 years", ShortName = "4 years", Order = 207)]
		public int? P0140007 { get; set; }

		[Display(Name = "5 years", ShortName = "5 years", Order = 208)]
		public int? P0140008 { get; set; }

		[Display(Name = "6 years", ShortName = "6 years", Order = 209)]
		public int? P0140009 { get; set; }

		[Display(Name = "7 years", ShortName = "7 years", Order = 210)]
		public int? P0140010 { get; set; }

		[Display(Name = "8 years", ShortName = "8 years", Order = 211)]
		public int? P0140011 { get; set; }

		[Display(Name = "9 years", ShortName = "9 years", Order = 212)]
		public int? P0140012 { get; set; }

		[Display(Name = "10 years", ShortName = "10 years", Order = 213)]
		public int? P0140013 { get; set; }

		[Display(Name = "11 years", ShortName = "11 years", Order = 214)]
		public int? P0140014 { get; set; }

		[Display(Name = "12 years", ShortName = "12 years", Order = 215)]
		public int? P0140015 { get; set; }

		[Display(Name = "13 years", ShortName = "13 years", Order = 216)]
		public int? P0140016 { get; set; }

		[Display(Name = "14 years", ShortName = "14 years", Order = 217)]
		public int? P0140017 { get; set; }

		[Display(Name = "15 years", ShortName = "15 years", Order = 218)]
		public int? P0140018 { get; set; }

		[Display(Name = "16 years", ShortName = "16 years", Order = 219)]
		public int? P0140019 { get; set; }

		[Display(Name = "17 years", ShortName = "17 years", Order = 220)]
		public int? P0140020 { get; set; }

		[Display(Name = "18 years", ShortName = "18 years", Order = 221)]
		public int? P0140021 { get; set; }

		[Display(Name = "19 years", ShortName = "19 years", Order = 222)]
		public int? P0140022 { get; set; }

		[Display(Name = "Female:", ShortName = "Female:", Order = 223)]
		public int? P0140023 { get; set; }

		[Display(Name = "Under 1 year", ShortName = "Under 1 year", Order = 224)]
		public int? P0140024 { get; set; }

		[Display(Name = "1 year", ShortName = "1 year", Order = 225)]
		public int? P0140025 { get; set; }

		[Display(Name = "2 years", ShortName = "2 years", Order = 226)]
		public int? P0140026 { get; set; }

		[Display(Name = "3 years", ShortName = "3 years", Order = 227)]
		public int? P0140027 { get; set; }

		[Display(Name = "4 years", ShortName = "4 years", Order = 228)]
		public int? P0140028 { get; set; }

		[Display(Name = "5 years", ShortName = "5 years", Order = 229)]
		public int? P0140029 { get; set; }

		[Display(Name = "6 years", ShortName = "6 years", Order = 230)]
		public int? P0140030 { get; set; }

		[Display(Name = "7 years", ShortName = "7 years", Order = 231)]
		public int? P0140031 { get; set; }

		[Display(Name = "8 years", ShortName = "8 years", Order = 232)]
		public int? P0140032 { get; set; }

		[Display(Name = "9 years", ShortName = "9 years", Order = 233)]
		public int? P0140033 { get; set; }

		[Display(Name = "10 years", ShortName = "10 years", Order = 234)]
		public int? P0140034 { get; set; }

		[Display(Name = "11 years", ShortName = "11 years", Order = 235)]
		public int? P0140035 { get; set; }

		[Display(Name = "12 years", ShortName = "12 years", Order = 236)]
		public int? P0140036 { get; set; }

		[Display(Name = "13 years", ShortName = "13 years", Order = 237)]
		public int? P0140037 { get; set; }

		[Display(Name = "14 years", ShortName = "14 years", Order = 238)]
		public int? P0140038 { get; set; }

		[Display(Name = "15 years", ShortName = "15 years", Order = 239)]
		public int? P0140039 { get; set; }

		[Display(Name = "16 years", ShortName = "16 years", Order = 240)]
		public int? P0140040 { get; set; }

		[Display(Name = "17 years", ShortName = "17 years", Order = 241)]
		public int? P0140041 { get; set; }

		[Display(Name = "18 years", ShortName = "18 years", Order = 242)]
		public int? P0140042 { get; set; }

		[Display(Name = "19 years", ShortName = "19 years", Order = 243)]
		public int? P0140043 { get; set; }
		#endregion Properties

		#region Constructors
		public SummaryOne_SF1_00004(string csvLine) : base(csvLine) { }

		public SummaryOne_SF1_00004(string[] values) : base(values) { }

		public SummaryOne_SF1_00004(OleDbDataReader reader)
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
				P0100001 = (int?)reader[5];
			}
			if (reader[6] != DBNull.Value)
			{
				P0100002 = (int?)reader[6];
			}
			if (reader[7] != DBNull.Value)
			{
				P0100003 = (int?)reader[7];
			}
			if (reader[8] != DBNull.Value)
			{
				P0100004 = (int?)reader[8];
			}
			if (reader[9] != DBNull.Value)
			{
				P0100005 = (int?)reader[9];
			}
			if (reader[10] != DBNull.Value)
			{
				P0100006 = (int?)reader[10];
			}
			if (reader[11] != DBNull.Value)
			{
				P0100007 = (int?)reader[11];
			}
			if (reader[12] != DBNull.Value)
			{
				P0100008 = (int?)reader[12];
			}
			if (reader[13] != DBNull.Value)
			{
				P0100009 = (int?)reader[13];
			}
			if (reader[14] != DBNull.Value)
			{
				P0100010 = (int?)reader[14];
			}
			if (reader[15] != DBNull.Value)
			{
				P0100011 = (int?)reader[15];
			}
			if (reader[16] != DBNull.Value)
			{
				P0100012 = (int?)reader[16];
			}
			if (reader[17] != DBNull.Value)
			{
				P0100013 = (int?)reader[17];
			}
			if (reader[18] != DBNull.Value)
			{
				P0100014 = (int?)reader[18];
			}
			if (reader[19] != DBNull.Value)
			{
				P0100015 = (int?)reader[19];
			}
			if (reader[20] != DBNull.Value)
			{
				P0100016 = (int?)reader[20];
			}
			if (reader[21] != DBNull.Value)
			{
				P0100017 = (int?)reader[21];
			}
			if (reader[22] != DBNull.Value)
			{
				P0100018 = (int?)reader[22];
			}
			if (reader[23] != DBNull.Value)
			{
				P0100019 = (int?)reader[23];
			}
			if (reader[24] != DBNull.Value)
			{
				P0100020 = (int?)reader[24];
			}
			if (reader[25] != DBNull.Value)
			{
				P0100021 = (int?)reader[25];
			}
			if (reader[26] != DBNull.Value)
			{
				P0100022 = (int?)reader[26];
			}
			if (reader[27] != DBNull.Value)
			{
				P0100023 = (int?)reader[27];
			}
			if (reader[28] != DBNull.Value)
			{
				P0100024 = (int?)reader[28];
			}
			if (reader[29] != DBNull.Value)
			{
				P0100025 = (int?)reader[29];
			}
			if (reader[30] != DBNull.Value)
			{
				P0100026 = (int?)reader[30];
			}
			if (reader[31] != DBNull.Value)
			{
				P0100027 = (int?)reader[31];
			}
			if (reader[32] != DBNull.Value)
			{
				P0100028 = (int?)reader[32];
			}
			if (reader[33] != DBNull.Value)
			{
				P0100029 = (int?)reader[33];
			}
			if (reader[34] != DBNull.Value)
			{
				P0100030 = (int?)reader[34];
			}
			if (reader[35] != DBNull.Value)
			{
				P0100031 = (int?)reader[35];
			}
			if (reader[36] != DBNull.Value)
			{
				P0100032 = (int?)reader[36];
			}
			if (reader[37] != DBNull.Value)
			{
				P0100033 = (int?)reader[37];
			}
			if (reader[38] != DBNull.Value)
			{
				P0100034 = (int?)reader[38];
			}
			if (reader[39] != DBNull.Value)
			{
				P0100035 = (int?)reader[39];
			}
			if (reader[40] != DBNull.Value)
			{
				P0100036 = (int?)reader[40];
			}
			if (reader[41] != DBNull.Value)
			{
				P0100037 = (int?)reader[41];
			}
			if (reader[42] != DBNull.Value)
			{
				P0100038 = (int?)reader[42];
			}
			if (reader[43] != DBNull.Value)
			{
				P0100039 = (int?)reader[43];
			}
			if (reader[44] != DBNull.Value)
			{
				P0100040 = (int?)reader[44];
			}
			if (reader[45] != DBNull.Value)
			{
				P0100041 = (int?)reader[45];
			}
			if (reader[46] != DBNull.Value)
			{
				P0100042 = (int?)reader[46];
			}
			if (reader[47] != DBNull.Value)
			{
				P0100043 = (int?)reader[47];
			}
			if (reader[48] != DBNull.Value)
			{
				P0100044 = (int?)reader[48];
			}
			if (reader[49] != DBNull.Value)
			{
				P0100045 = (int?)reader[49];
			}
			if (reader[50] != DBNull.Value)
			{
				P0100046 = (int?)reader[50];
			}
			if (reader[51] != DBNull.Value)
			{
				P0100047 = (int?)reader[51];
			}
			if (reader[52] != DBNull.Value)
			{
				P0100048 = (int?)reader[52];
			}
			if (reader[53] != DBNull.Value)
			{
				P0100049 = (int?)reader[53];
			}
			if (reader[54] != DBNull.Value)
			{
				P0100050 = (int?)reader[54];
			}
			if (reader[55] != DBNull.Value)
			{
				P0100051 = (int?)reader[55];
			}
			if (reader[56] != DBNull.Value)
			{
				P0100052 = (int?)reader[56];
			}
			if (reader[57] != DBNull.Value)
			{
				P0100053 = (int?)reader[57];
			}
			if (reader[58] != DBNull.Value)
			{
				P0100054 = (int?)reader[58];
			}
			if (reader[59] != DBNull.Value)
			{
				P0100055 = (int?)reader[59];
			}
			if (reader[60] != DBNull.Value)
			{
				P0100056 = (int?)reader[60];
			}
			if (reader[61] != DBNull.Value)
			{
				P0100057 = (int?)reader[61];
			}
			if (reader[62] != DBNull.Value)
			{
				P0100058 = (int?)reader[62];
			}
			if (reader[63] != DBNull.Value)
			{
				P0100059 = (int?)reader[63];
			}
			if (reader[64] != DBNull.Value)
			{
				P0100060 = (int?)reader[64];
			}
			if (reader[65] != DBNull.Value)
			{
				P0100061 = (int?)reader[65];
			}
			if (reader[66] != DBNull.Value)
			{
				P0100062 = (int?)reader[66];
			}
			if (reader[67] != DBNull.Value)
			{
				P0100063 = (int?)reader[67];
			}
			if (reader[68] != DBNull.Value)
			{
				P0100064 = (int?)reader[68];
			}
			if (reader[69] != DBNull.Value)
			{
				P0100065 = (int?)reader[69];
			}
			if (reader[70] != DBNull.Value)
			{
				P0100066 = (int?)reader[70];
			}
			if (reader[71] != DBNull.Value)
			{
				P0100067 = (int?)reader[71];
			}
			if (reader[72] != DBNull.Value)
			{
				P0100068 = (int?)reader[72];
			}
			if (reader[73] != DBNull.Value)
			{
				P0100069 = (int?)reader[73];
			}
			if (reader[74] != DBNull.Value)
			{
				P0100070 = (int?)reader[74];
			}
			if (reader[75] != DBNull.Value)
			{
				P0100071 = (int?)reader[75];
			}
			if (reader[76] != DBNull.Value)
			{
				P0110001 = (int?)reader[76];
			}
			if (reader[77] != DBNull.Value)
			{
				P0110002 = (int?)reader[77];
			}
			if (reader[78] != DBNull.Value)
			{
				P0110003 = (int?)reader[78];
			}
			if (reader[79] != DBNull.Value)
			{
				P0110004 = (int?)reader[79];
			}
			if (reader[80] != DBNull.Value)
			{
				P0110005 = (int?)reader[80];
			}
			if (reader[81] != DBNull.Value)
			{
				P0110006 = (int?)reader[81];
			}
			if (reader[82] != DBNull.Value)
			{
				P0110007 = (int?)reader[82];
			}
			if (reader[83] != DBNull.Value)
			{
				P0110008 = (int?)reader[83];
			}
			if (reader[84] != DBNull.Value)
			{
				P0110009 = (int?)reader[84];
			}
			if (reader[85] != DBNull.Value)
			{
				P0110010 = (int?)reader[85];
			}
			if (reader[86] != DBNull.Value)
			{
				P0110011 = (int?)reader[86];
			}
			if (reader[87] != DBNull.Value)
			{
				P0110012 = (int?)reader[87];
			}
			if (reader[88] != DBNull.Value)
			{
				P0110013 = (int?)reader[88];
			}
			if (reader[89] != DBNull.Value)
			{
				P0110014 = (int?)reader[89];
			}
			if (reader[90] != DBNull.Value)
			{
				P0110015 = (int?)reader[90];
			}
			if (reader[91] != DBNull.Value)
			{
				P0110016 = (int?)reader[91];
			}
			if (reader[92] != DBNull.Value)
			{
				P0110017 = (int?)reader[92];
			}
			if (reader[93] != DBNull.Value)
			{
				P0110018 = (int?)reader[93];
			}
			if (reader[94] != DBNull.Value)
			{
				P0110019 = (int?)reader[94];
			}
			if (reader[95] != DBNull.Value)
			{
				P0110020 = (int?)reader[95];
			}
			if (reader[96] != DBNull.Value)
			{
				P0110021 = (int?)reader[96];
			}
			if (reader[97] != DBNull.Value)
			{
				P0110022 = (int?)reader[97];
			}
			if (reader[98] != DBNull.Value)
			{
				P0110023 = (int?)reader[98];
			}
			if (reader[99] != DBNull.Value)
			{
				P0110024 = (int?)reader[99];
			}
			if (reader[100] != DBNull.Value)
			{
				P0110025 = (int?)reader[100];
			}
			if (reader[101] != DBNull.Value)
			{
				P0110026 = (int?)reader[101];
			}
			if (reader[102] != DBNull.Value)
			{
				P0110027 = (int?)reader[102];
			}
			if (reader[103] != DBNull.Value)
			{
				P0110028 = (int?)reader[103];
			}
			if (reader[104] != DBNull.Value)
			{
				P0110029 = (int?)reader[104];
			}
			if (reader[105] != DBNull.Value)
			{
				P0110030 = (int?)reader[105];
			}
			if (reader[106] != DBNull.Value)
			{
				P0110031 = (int?)reader[106];
			}
			if (reader[107] != DBNull.Value)
			{
				P0110032 = (int?)reader[107];
			}
			if (reader[108] != DBNull.Value)
			{
				P0110033 = (int?)reader[108];
			}
			if (reader[109] != DBNull.Value)
			{
				P0110034 = (int?)reader[109];
			}
			if (reader[110] != DBNull.Value)
			{
				P0110035 = (int?)reader[110];
			}
			if (reader[111] != DBNull.Value)
			{
				P0110036 = (int?)reader[111];
			}
			if (reader[112] != DBNull.Value)
			{
				P0110037 = (int?)reader[112];
			}
			if (reader[113] != DBNull.Value)
			{
				P0110038 = (int?)reader[113];
			}
			if (reader[114] != DBNull.Value)
			{
				P0110039 = (int?)reader[114];
			}
			if (reader[115] != DBNull.Value)
			{
				P0110040 = (int?)reader[115];
			}
			if (reader[116] != DBNull.Value)
			{
				P0110041 = (int?)reader[116];
			}
			if (reader[117] != DBNull.Value)
			{
				P0110042 = (int?)reader[117];
			}
			if (reader[118] != DBNull.Value)
			{
				P0110043 = (int?)reader[118];
			}
			if (reader[119] != DBNull.Value)
			{
				P0110044 = (int?)reader[119];
			}
			if (reader[120] != DBNull.Value)
			{
				P0110045 = (int?)reader[120];
			}
			if (reader[121] != DBNull.Value)
			{
				P0110046 = (int?)reader[121];
			}
			if (reader[122] != DBNull.Value)
			{
				P0110047 = (int?)reader[122];
			}
			if (reader[123] != DBNull.Value)
			{
				P0110048 = (int?)reader[123];
			}
			if (reader[124] != DBNull.Value)
			{
				P0110049 = (int?)reader[124];
			}
			if (reader[125] != DBNull.Value)
			{
				P0110050 = (int?)reader[125];
			}
			if (reader[126] != DBNull.Value)
			{
				P0110051 = (int?)reader[126];
			}
			if (reader[127] != DBNull.Value)
			{
				P0110052 = (int?)reader[127];
			}
			if (reader[128] != DBNull.Value)
			{
				P0110053 = (int?)reader[128];
			}
			if (reader[129] != DBNull.Value)
			{
				P0110054 = (int?)reader[129];
			}
			if (reader[130] != DBNull.Value)
			{
				P0110055 = (int?)reader[130];
			}
			if (reader[131] != DBNull.Value)
			{
				P0110056 = (int?)reader[131];
			}
			if (reader[132] != DBNull.Value)
			{
				P0110057 = (int?)reader[132];
			}
			if (reader[133] != DBNull.Value)
			{
				P0110058 = (int?)reader[133];
			}
			if (reader[134] != DBNull.Value)
			{
				P0110059 = (int?)reader[134];
			}
			if (reader[135] != DBNull.Value)
			{
				P0110060 = (int?)reader[135];
			}
			if (reader[136] != DBNull.Value)
			{
				P0110061 = (int?)reader[136];
			}
			if (reader[137] != DBNull.Value)
			{
				P0110062 = (int?)reader[137];
			}
			if (reader[138] != DBNull.Value)
			{
				P0110063 = (int?)reader[138];
			}
			if (reader[139] != DBNull.Value)
			{
				P0110064 = (int?)reader[139];
			}
			if (reader[140] != DBNull.Value)
			{
				P0110065 = (int?)reader[140];
			}
			if (reader[141] != DBNull.Value)
			{
				P0110066 = (int?)reader[141];
			}
			if (reader[142] != DBNull.Value)
			{
				P0110067 = (int?)reader[142];
			}
			if (reader[143] != DBNull.Value)
			{
				P0110068 = (int?)reader[143];
			}
			if (reader[144] != DBNull.Value)
			{
				P0110069 = (int?)reader[144];
			}
			if (reader[145] != DBNull.Value)
			{
				P0110070 = (int?)reader[145];
			}
			if (reader[146] != DBNull.Value)
			{
				P0110071 = (int?)reader[146];
			}
			if (reader[147] != DBNull.Value)
			{
				P0110072 = (int?)reader[147];
			}
			if (reader[148] != DBNull.Value)
			{
				P0110073 = (int?)reader[148];
			}
			if (reader[149] != DBNull.Value)
			{
				P0120001 = (int?)reader[149];
			}
			if (reader[150] != DBNull.Value)
			{
				P0120002 = (int?)reader[150];
			}
			if (reader[151] != DBNull.Value)
			{
				P0120003 = (int?)reader[151];
			}
			if (reader[152] != DBNull.Value)
			{
				P0120004 = (int?)reader[152];
			}
			if (reader[153] != DBNull.Value)
			{
				P0120005 = (int?)reader[153];
			}
			if (reader[154] != DBNull.Value)
			{
				P0120006 = (int?)reader[154];
			}
			if (reader[155] != DBNull.Value)
			{
				P0120007 = (int?)reader[155];
			}
			if (reader[156] != DBNull.Value)
			{
				P0120008 = (int?)reader[156];
			}
			if (reader[157] != DBNull.Value)
			{
				P0120009 = (int?)reader[157];
			}
			if (reader[158] != DBNull.Value)
			{
				P0120010 = (int?)reader[158];
			}
			if (reader[159] != DBNull.Value)
			{
				P0120011 = (int?)reader[159];
			}
			if (reader[160] != DBNull.Value)
			{
				P0120012 = (int?)reader[160];
			}
			if (reader[161] != DBNull.Value)
			{
				P0120013 = (int?)reader[161];
			}
			if (reader[162] != DBNull.Value)
			{
				P0120014 = (int?)reader[162];
			}
			if (reader[163] != DBNull.Value)
			{
				P0120015 = (int?)reader[163];
			}
			if (reader[164] != DBNull.Value)
			{
				P0120016 = (int?)reader[164];
			}
			if (reader[165] != DBNull.Value)
			{
				P0120017 = (int?)reader[165];
			}
			if (reader[166] != DBNull.Value)
			{
				P0120018 = (int?)reader[166];
			}
			if (reader[167] != DBNull.Value)
			{
				P0120019 = (int?)reader[167];
			}
			if (reader[168] != DBNull.Value)
			{
				P0120020 = (int?)reader[168];
			}
			if (reader[169] != DBNull.Value)
			{
				P0120021 = (int?)reader[169];
			}
			if (reader[170] != DBNull.Value)
			{
				P0120022 = (int?)reader[170];
			}
			if (reader[171] != DBNull.Value)
			{
				P0120023 = (int?)reader[171];
			}
			if (reader[172] != DBNull.Value)
			{
				P0120024 = (int?)reader[172];
			}
			if (reader[173] != DBNull.Value)
			{
				P0120025 = (int?)reader[173];
			}
			if (reader[174] != DBNull.Value)
			{
				P0120026 = (int?)reader[174];
			}
			if (reader[175] != DBNull.Value)
			{
				P0120027 = (int?)reader[175];
			}
			if (reader[176] != DBNull.Value)
			{
				P0120028 = (int?)reader[176];
			}
			if (reader[177] != DBNull.Value)
			{
				P0120029 = (int?)reader[177];
			}
			if (reader[178] != DBNull.Value)
			{
				P0120030 = (int?)reader[178];
			}
			if (reader[179] != DBNull.Value)
			{
				P0120031 = (int?)reader[179];
			}
			if (reader[180] != DBNull.Value)
			{
				P0120032 = (int?)reader[180];
			}
			if (reader[181] != DBNull.Value)
			{
				P0120033 = (int?)reader[181];
			}
			if (reader[182] != DBNull.Value)
			{
				P0120034 = (int?)reader[182];
			}
			if (reader[183] != DBNull.Value)
			{
				P0120035 = (int?)reader[183];
			}
			if (reader[184] != DBNull.Value)
			{
				P0120036 = (int?)reader[184];
			}
			if (reader[185] != DBNull.Value)
			{
				P0120037 = (int?)reader[185];
			}
			if (reader[186] != DBNull.Value)
			{
				P0120038 = (int?)reader[186];
			}
			if (reader[187] != DBNull.Value)
			{
				P0120039 = (int?)reader[187];
			}
			if (reader[188] != DBNull.Value)
			{
				P0120040 = (int?)reader[188];
			}
			if (reader[189] != DBNull.Value)
			{
				P0120041 = (int?)reader[189];
			}
			if (reader[190] != DBNull.Value)
			{
				P0120042 = (int?)reader[190];
			}
			if (reader[191] != DBNull.Value)
			{
				P0120043 = (int?)reader[191];
			}
			if (reader[192] != DBNull.Value)
			{
				P0120044 = (int?)reader[192];
			}
			if (reader[193] != DBNull.Value)
			{
				P0120045 = (int?)reader[193];
			}
			if (reader[194] != DBNull.Value)
			{
				P0120046 = (int?)reader[194];
			}
			if (reader[195] != DBNull.Value)
			{
				P0120047 = (int?)reader[195];
			}
			if (reader[196] != DBNull.Value)
			{
				P0120048 = (int?)reader[196];
			}
			if (reader[197] != DBNull.Value)
			{
				P0120049 = (int?)reader[197];
			}
			if (reader[198] != DBNull.Value)
			{
				P0130001 = (decimal?)reader[198];
			}
			if (reader[199] != DBNull.Value)
			{
				P0130002 = (decimal?)reader[199];
			}
			if (reader[200] != DBNull.Value)
			{
				P0130003 = (decimal?)reader[200];
			}
			if (reader[201] != DBNull.Value)
			{
				P0140001 = (int?)reader[201];
			}
			if (reader[202] != DBNull.Value)
			{
				P0140002 = (int?)reader[202];
			}
			if (reader[203] != DBNull.Value)
			{
				P0140003 = (int?)reader[203];
			}
			if (reader[204] != DBNull.Value)
			{
				P0140004 = (int?)reader[204];
			}
			if (reader[205] != DBNull.Value)
			{
				P0140005 = (int?)reader[205];
			}
			if (reader[206] != DBNull.Value)
			{
				P0140006 = (int?)reader[206];
			}
			if (reader[207] != DBNull.Value)
			{
				P0140007 = (int?)reader[207];
			}
			if (reader[208] != DBNull.Value)
			{
				P0140008 = (int?)reader[208];
			}
			if (reader[209] != DBNull.Value)
			{
				P0140009 = (int?)reader[209];
			}
			if (reader[210] != DBNull.Value)
			{
				P0140010 = (int?)reader[210];
			}
			if (reader[211] != DBNull.Value)
			{
				P0140011 = (int?)reader[211];
			}
			if (reader[212] != DBNull.Value)
			{
				P0140012 = (int?)reader[212];
			}
			if (reader[213] != DBNull.Value)
			{
				P0140013 = (int?)reader[213];
			}
			if (reader[214] != DBNull.Value)
			{
				P0140014 = (int?)reader[214];
			}
			if (reader[215] != DBNull.Value)
			{
				P0140015 = (int?)reader[215];
			}
			if (reader[216] != DBNull.Value)
			{
				P0140016 = (int?)reader[216];
			}
			if (reader[217] != DBNull.Value)
			{
				P0140017 = (int?)reader[217];
			}
			if (reader[218] != DBNull.Value)
			{
				P0140018 = (int?)reader[218];
			}
			if (reader[219] != DBNull.Value)
			{
				P0140019 = (int?)reader[219];
			}
			if (reader[220] != DBNull.Value)
			{
				P0140020 = (int?)reader[220];
			}
			if (reader[221] != DBNull.Value)
			{
				P0140021 = (int?)reader[221];
			}
			if (reader[222] != DBNull.Value)
			{
				P0140022 = (int?)reader[222];
			}
			if (reader[223] != DBNull.Value)
			{
				P0140023 = (int?)reader[223];
			}
			if (reader[224] != DBNull.Value)
			{
				P0140024 = (int?)reader[224];
			}
			if (reader[225] != DBNull.Value)
			{
				P0140025 = (int?)reader[225];
			}
			if (reader[226] != DBNull.Value)
			{
				P0140026 = (int?)reader[226];
			}
			if (reader[227] != DBNull.Value)
			{
				P0140027 = (int?)reader[227];
			}
			if (reader[228] != DBNull.Value)
			{
				P0140028 = (int?)reader[228];
			}
			if (reader[229] != DBNull.Value)
			{
				P0140029 = (int?)reader[229];
			}
			if (reader[230] != DBNull.Value)
			{
				P0140030 = (int?)reader[230];
			}
			if (reader[231] != DBNull.Value)
			{
				P0140031 = (int?)reader[231];
			}
			if (reader[232] != DBNull.Value)
			{
				P0140032 = (int?)reader[232];
			}
			if (reader[233] != DBNull.Value)
			{
				P0140033 = (int?)reader[233];
			}
			if (reader[234] != DBNull.Value)
			{
				P0140034 = (int?)reader[234];
			}
			if (reader[235] != DBNull.Value)
			{
				P0140035 = (int?)reader[235];
			}
			if (reader[236] != DBNull.Value)
			{
				P0140036 = (int?)reader[236];
			}
			if (reader[237] != DBNull.Value)
			{
				P0140037 = (int?)reader[237];
			}
			if (reader[238] != DBNull.Value)
			{
				P0140038 = (int?)reader[238];
			}
			if (reader[239] != DBNull.Value)
			{
				P0140039 = (int?)reader[239];
			}
			if (reader[240] != DBNull.Value)
			{
				P0140040 = (int?)reader[240];
			}
			if (reader[241] != DBNull.Value)
			{
				P0140041 = (int?)reader[241];
			}
			if (reader[242] != DBNull.Value)
			{
				P0140042 = (int?)reader[242];
			}
			if (reader[243] != DBNull.Value)
			{
				P0140043 = (int?)reader[243];
			}
		}
		#endregion Constructors
	}
}
