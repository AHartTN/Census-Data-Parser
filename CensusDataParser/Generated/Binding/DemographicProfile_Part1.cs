namespace CensusDataParser.Generated.Binding
{
	#region Using Directives
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.Data.OleDb;
	#endregion Using Directives

	public class DemographicProfile_Part1 : BaseModel
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
		public string LOGRECNO { get; set; }

		[Display(Name = "DPSF0010001", ShortName = "DPSF0010001", Order = 5)]
		public int? DPSF0010001 { get; set; }

		[Display(Name = "DPSF0010002", ShortName = "DPSF0010002", Order = 6)]
		public int? DPSF0010002 { get; set; }

		[Display(Name = "DPSF0010003", ShortName = "DPSF0010003", Order = 7)]
		public int? DPSF0010003 { get; set; }

		[Display(Name = "DPSF0010004", ShortName = "DPSF0010004", Order = 8)]
		public int? DPSF0010004 { get; set; }

		[Display(Name = "DPSF0010005", ShortName = "DPSF0010005", Order = 9)]
		public int? DPSF0010005 { get; set; }

		[Display(Name = "DPSF0010006", ShortName = "DPSF0010006", Order = 10)]
		public int? DPSF0010006 { get; set; }

		[Display(Name = "DPSF0010007", ShortName = "DPSF0010007", Order = 11)]
		public int? DPSF0010007 { get; set; }

		[Display(Name = "DPSF0010008", ShortName = "DPSF0010008", Order = 12)]
		public int? DPSF0010008 { get; set; }

		[Display(Name = "DPSF0010009", ShortName = "DPSF0010009", Order = 13)]
		public int? DPSF0010009 { get; set; }

		[Display(Name = "DPSF0010010", ShortName = "DPSF0010010", Order = 14)]
		public int? DPSF0010010 { get; set; }

		[Display(Name = "DPSF0010011", ShortName = "DPSF0010011", Order = 15)]
		public int? DPSF0010011 { get; set; }

		[Display(Name = "DPSF0010012", ShortName = "DPSF0010012", Order = 16)]
		public int? DPSF0010012 { get; set; }

		[Display(Name = "DPSF0010013", ShortName = "DPSF0010013", Order = 17)]
		public int? DPSF0010013 { get; set; }

		[Display(Name = "DPSF0010014", ShortName = "DPSF0010014", Order = 18)]
		public int? DPSF0010014 { get; set; }

		[Display(Name = "DPSF0010015", ShortName = "DPSF0010015", Order = 19)]
		public int? DPSF0010015 { get; set; }

		[Display(Name = "DPSF0010016", ShortName = "DPSF0010016", Order = 20)]
		public int? DPSF0010016 { get; set; }

		[Display(Name = "DPSF0010017", ShortName = "DPSF0010017", Order = 21)]
		public int? DPSF0010017 { get; set; }

		[Display(Name = "DPSF0010018", ShortName = "DPSF0010018", Order = 22)]
		public int? DPSF0010018 { get; set; }

		[Display(Name = "DPSF0010019", ShortName = "DPSF0010019", Order = 23)]
		public int? DPSF0010019 { get; set; }

		[Display(Name = "DPSF0010020", ShortName = "DPSF0010020", Order = 24)]
		public int? DPSF0010020 { get; set; }

		[Display(Name = "DPSF0010021", ShortName = "DPSF0010021", Order = 25)]
		public int? DPSF0010021 { get; set; }

		[Display(Name = "DPSF0010022", ShortName = "DPSF0010022", Order = 26)]
		public int? DPSF0010022 { get; set; }

		[Display(Name = "DPSF0010023", ShortName = "DPSF0010023", Order = 27)]
		public int? DPSF0010023 { get; set; }

		[Display(Name = "DPSF0010024", ShortName = "DPSF0010024", Order = 28)]
		public int? DPSF0010024 { get; set; }

		[Display(Name = "DPSF0010025", ShortName = "DPSF0010025", Order = 29)]
		public int? DPSF0010025 { get; set; }

		[Display(Name = "DPSF0010026", ShortName = "DPSF0010026", Order = 30)]
		public int? DPSF0010026 { get; set; }

		[Display(Name = "DPSF0010027", ShortName = "DPSF0010027", Order = 31)]
		public int? DPSF0010027 { get; set; }

		[Display(Name = "DPSF0010028", ShortName = "DPSF0010028", Order = 32)]
		public int? DPSF0010028 { get; set; }

		[Display(Name = "DPSF0010029", ShortName = "DPSF0010029", Order = 33)]
		public int? DPSF0010029 { get; set; }

		[Display(Name = "DPSF0010030", ShortName = "DPSF0010030", Order = 34)]
		public int? DPSF0010030 { get; set; }

		[Display(Name = "DPSF0010031", ShortName = "DPSF0010031", Order = 35)]
		public int? DPSF0010031 { get; set; }

		[Display(Name = "DPSF0010032", ShortName = "DPSF0010032", Order = 36)]
		public int? DPSF0010032 { get; set; }

		[Display(Name = "DPSF0010033", ShortName = "DPSF0010033", Order = 37)]
		public int? DPSF0010033 { get; set; }

		[Display(Name = "DPSF0010034", ShortName = "DPSF0010034", Order = 38)]
		public int? DPSF0010034 { get; set; }

		[Display(Name = "DPSF0010035", ShortName = "DPSF0010035", Order = 39)]
		public int? DPSF0010035 { get; set; }

		[Display(Name = "DPSF0010036", ShortName = "DPSF0010036", Order = 40)]
		public int? DPSF0010036 { get; set; }

		[Display(Name = "DPSF0010037", ShortName = "DPSF0010037", Order = 41)]
		public int? DPSF0010037 { get; set; }

		[Display(Name = "DPSF0010038", ShortName = "DPSF0010038", Order = 42)]
		public int? DPSF0010038 { get; set; }

		[Display(Name = "DPSF0010039", ShortName = "DPSF0010039", Order = 43)]
		public int? DPSF0010039 { get; set; }

		[Display(Name = "DPSF0010040", ShortName = "DPSF0010040", Order = 44)]
		public int? DPSF0010040 { get; set; }

		[Display(Name = "DPSF0010041", ShortName = "DPSF0010041", Order = 45)]
		public int? DPSF0010041 { get; set; }

		[Display(Name = "DPSF0010042", ShortName = "DPSF0010042", Order = 46)]
		public int? DPSF0010042 { get; set; }

		[Display(Name = "DPSF0010043", ShortName = "DPSF0010043", Order = 47)]
		public int? DPSF0010043 { get; set; }

		[Display(Name = "DPSF0010044", ShortName = "DPSF0010044", Order = 48)]
		public int? DPSF0010044 { get; set; }

		[Display(Name = "DPSF0010045", ShortName = "DPSF0010045", Order = 49)]
		public int? DPSF0010045 { get; set; }

		[Display(Name = "DPSF0010046", ShortName = "DPSF0010046", Order = 50)]
		public int? DPSF0010046 { get; set; }

		[Display(Name = "DPSF0010047", ShortName = "DPSF0010047", Order = 51)]
		public int? DPSF0010047 { get; set; }

		[Display(Name = "DPSF0010048", ShortName = "DPSF0010048", Order = 52)]
		public int? DPSF0010048 { get; set; }

		[Display(Name = "DPSF0010049", ShortName = "DPSF0010049", Order = 53)]
		public int? DPSF0010049 { get; set; }

		[Display(Name = "DPSF0010050", ShortName = "DPSF0010050", Order = 54)]
		public int? DPSF0010050 { get; set; }

		[Display(Name = "DPSF0010051", ShortName = "DPSF0010051", Order = 55)]
		public int? DPSF0010051 { get; set; }

		[Display(Name = "DPSF0010052", ShortName = "DPSF0010052", Order = 56)]
		public int? DPSF0010052 { get; set; }

		[Display(Name = "DPSF0010053", ShortName = "DPSF0010053", Order = 57)]
		public int? DPSF0010053 { get; set; }

		[Display(Name = "DPSF0010054", ShortName = "DPSF0010054", Order = 58)]
		public int? DPSF0010054 { get; set; }

		[Display(Name = "DPSF0010055", ShortName = "DPSF0010055", Order = 59)]
		public int? DPSF0010055 { get; set; }

		[Display(Name = "DPSF0010056", ShortName = "DPSF0010056", Order = 60)]
		public int? DPSF0010056 { get; set; }

		[Display(Name = "DPSF0010057", ShortName = "DPSF0010057", Order = 61)]
		public int? DPSF0010057 { get; set; }

		[Display(Name = "DPSF0020001", ShortName = "DPSF0020001", Order = 62)]
		public decimal? DPSF0020001 { get; set; }

		[Display(Name = "DPSF0020002", ShortName = "DPSF0020002", Order = 63)]
		public decimal? DPSF0020002 { get; set; }

		[Display(Name = "DPSF0020003", ShortName = "DPSF0020003", Order = 64)]
		public decimal? DPSF0020003 { get; set; }

		[Display(Name = "DPSF0030001", ShortName = "DPSF0030001", Order = 65)]
		public int? DPSF0030001 { get; set; }

		[Display(Name = "DPSF0030002", ShortName = "DPSF0030002", Order = 66)]
		public int? DPSF0030002 { get; set; }

		[Display(Name = "DPSF0030003", ShortName = "DPSF0030003", Order = 67)]
		public int? DPSF0030003 { get; set; }

		[Display(Name = "DPSF0040001", ShortName = "DPSF0040001", Order = 68)]
		public int? DPSF0040001 { get; set; }

		[Display(Name = "DPSF0040002", ShortName = "DPSF0040002", Order = 69)]
		public int? DPSF0040002 { get; set; }

		[Display(Name = "DPSF0040003", ShortName = "DPSF0040003", Order = 70)]
		public int? DPSF0040003 { get; set; }

		[Display(Name = "DPSF0050001", ShortName = "DPSF0050001", Order = 71)]
		public int? DPSF0050001 { get; set; }

		[Display(Name = "DPSF0050002", ShortName = "DPSF0050002", Order = 72)]
		public int? DPSF0050002 { get; set; }

		[Display(Name = "DPSF0050003", ShortName = "DPSF0050003", Order = 73)]
		public int? DPSF0050003 { get; set; }

		[Display(Name = "DPSF0060001", ShortName = "DPSF0060001", Order = 74)]
		public int? DPSF0060001 { get; set; }

		[Display(Name = "DPSF0060002", ShortName = "DPSF0060002", Order = 75)]
		public int? DPSF0060002 { get; set; }

		[Display(Name = "DPSF0060003", ShortName = "DPSF0060003", Order = 76)]
		public int? DPSF0060003 { get; set; }

		[Display(Name = "DPSF0070001", ShortName = "DPSF0070001", Order = 77)]
		public int? DPSF0070001 { get; set; }

		[Display(Name = "DPSF0070002", ShortName = "DPSF0070002", Order = 78)]
		public int? DPSF0070002 { get; set; }

		[Display(Name = "DPSF0070003", ShortName = "DPSF0070003", Order = 79)]
		public int? DPSF0070003 { get; set; }

		[Display(Name = "DPSF0080001", ShortName = "DPSF0080001", Order = 80)]
		public int? DPSF0080001 { get; set; }

		[Display(Name = "DPSF0080002", ShortName = "DPSF0080002", Order = 81)]
		public int? DPSF0080002 { get; set; }

		[Display(Name = "DPSF0080003", ShortName = "DPSF0080003", Order = 82)]
		public int? DPSF0080003 { get; set; }

		[Display(Name = "DPSF0080004", ShortName = "DPSF0080004", Order = 83)]
		public int? DPSF0080004 { get; set; }

		[Display(Name = "DPSF0080005", ShortName = "DPSF0080005", Order = 84)]
		public int? DPSF0080005 { get; set; }

		[Display(Name = "DPSF0080006", ShortName = "DPSF0080006", Order = 85)]
		public int? DPSF0080006 { get; set; }

		[Display(Name = "DPSF0080007", ShortName = "DPSF0080007", Order = 86)]
		public int? DPSF0080007 { get; set; }

		[Display(Name = "DPSF0080008", ShortName = "DPSF0080008", Order = 87)]
		public int? DPSF0080008 { get; set; }

		[Display(Name = "DPSF0080009", ShortName = "DPSF0080009", Order = 88)]
		public int? DPSF0080009 { get; set; }

		[Display(Name = "DPSF0080010", ShortName = "DPSF0080010", Order = 89)]
		public int? DPSF0080010 { get; set; }

		[Display(Name = "DPSF0080011", ShortName = "DPSF0080011", Order = 90)]
		public int? DPSF0080011 { get; set; }

		[Display(Name = "DPSF0080012", ShortName = "DPSF0080012", Order = 91)]
		public int? DPSF0080012 { get; set; }

		[Display(Name = "DPSF0080013", ShortName = "DPSF0080013", Order = 92)]
		public int? DPSF0080013 { get; set; }

		[Display(Name = "DPSF0080014", ShortName = "DPSF0080014", Order = 93)]
		public int? DPSF0080014 { get; set; }

		[Display(Name = "DPSF0080015", ShortName = "DPSF0080015", Order = 94)]
		public int? DPSF0080015 { get; set; }

		[Display(Name = "DPSF0080016", ShortName = "DPSF0080016", Order = 95)]
		public int? DPSF0080016 { get; set; }

		[Display(Name = "DPSF0080017", ShortName = "DPSF0080017", Order = 96)]
		public int? DPSF0080017 { get; set; }

		[Display(Name = "DPSF0080018", ShortName = "DPSF0080018", Order = 97)]
		public int? DPSF0080018 { get; set; }

		[Display(Name = "DPSF0080019", ShortName = "DPSF0080019", Order = 98)]
		public int? DPSF0080019 { get; set; }

		[Display(Name = "DPSF0080020", ShortName = "DPSF0080020", Order = 99)]
		public int? DPSF0080020 { get; set; }

		[Display(Name = "DPSF0080021", ShortName = "DPSF0080021", Order = 100)]
		public int? DPSF0080021 { get; set; }

		[Display(Name = "DPSF0080022", ShortName = "DPSF0080022", Order = 101)]
		public int? DPSF0080022 { get; set; }

		[Display(Name = "DPSF0080023", ShortName = "DPSF0080023", Order = 102)]
		public int? DPSF0080023 { get; set; }

		[Display(Name = "DPSF0080024", ShortName = "DPSF0080024", Order = 103)]
		public int? DPSF0080024 { get; set; }

		[Display(Name = "DPSF0090001", ShortName = "DPSF0090001", Order = 104)]
		public int? DPSF0090001 { get; set; }

		[Display(Name = "DPSF0090002", ShortName = "DPSF0090002", Order = 105)]
		public int? DPSF0090002 { get; set; }

		[Display(Name = "DPSF0090003", ShortName = "DPSF0090003", Order = 106)]
		public int? DPSF0090003 { get; set; }

		[Display(Name = "DPSF0090004", ShortName = "DPSF0090004", Order = 107)]
		public int? DPSF0090004 { get; set; }

		[Display(Name = "DPSF0090005", ShortName = "DPSF0090005", Order = 108)]
		public int? DPSF0090005 { get; set; }

		[Display(Name = "DPSF0090006", ShortName = "DPSF0090006", Order = 109)]
		public int? DPSF0090006 { get; set; }

		[Display(Name = "DPSF0100001", ShortName = "DPSF0100001", Order = 110)]
		public int? DPSF0100001 { get; set; }

		[Display(Name = "DPSF0100002", ShortName = "DPSF0100002", Order = 111)]
		public int? DPSF0100002 { get; set; }

		[Display(Name = "DPSF0100003", ShortName = "DPSF0100003", Order = 112)]
		public int? DPSF0100003 { get; set; }

		[Display(Name = "DPSF0100004", ShortName = "DPSF0100004", Order = 113)]
		public int? DPSF0100004 { get; set; }

		[Display(Name = "DPSF0100005", ShortName = "DPSF0100005", Order = 114)]
		public int? DPSF0100005 { get; set; }

		[Display(Name = "DPSF0100006", ShortName = "DPSF0100006", Order = 115)]
		public int? DPSF0100006 { get; set; }

		[Display(Name = "DPSF0100007", ShortName = "DPSF0100007", Order = 116)]
		public int? DPSF0100007 { get; set; }

		[Display(Name = "DPSF0110001", ShortName = "DPSF0110001", Order = 117)]
		public int? DPSF0110001 { get; set; }

		[Display(Name = "DPSF0110002", ShortName = "DPSF0110002", Order = 118)]
		public int? DPSF0110002 { get; set; }

		[Display(Name = "DPSF0110003", ShortName = "DPSF0110003", Order = 119)]
		public int? DPSF0110003 { get; set; }

		[Display(Name = "DPSF0110004", ShortName = "DPSF0110004", Order = 120)]
		public int? DPSF0110004 { get; set; }

		[Display(Name = "DPSF0110005", ShortName = "DPSF0110005", Order = 121)]
		public int? DPSF0110005 { get; set; }

		[Display(Name = "DPSF0110006", ShortName = "DPSF0110006", Order = 122)]
		public int? DPSF0110006 { get; set; }

		[Display(Name = "DPSF0110007", ShortName = "DPSF0110007", Order = 123)]
		public int? DPSF0110007 { get; set; }

		[Display(Name = "DPSF0110008", ShortName = "DPSF0110008", Order = 124)]
		public int? DPSF0110008 { get; set; }

		[Display(Name = "DPSF0110009", ShortName = "DPSF0110009", Order = 125)]
		public int? DPSF0110009 { get; set; }

		[Display(Name = "DPSF0110010", ShortName = "DPSF0110010", Order = 126)]
		public int? DPSF0110010 { get; set; }

		[Display(Name = "DPSF0110011", ShortName = "DPSF0110011", Order = 127)]
		public int? DPSF0110011 { get; set; }

		[Display(Name = "DPSF0110012", ShortName = "DPSF0110012", Order = 128)]
		public int? DPSF0110012 { get; set; }

		[Display(Name = "DPSF0110013", ShortName = "DPSF0110013", Order = 129)]
		public int? DPSF0110013 { get; set; }

		[Display(Name = "DPSF0110014", ShortName = "DPSF0110014", Order = 130)]
		public int? DPSF0110014 { get; set; }

		[Display(Name = "DPSF0110015", ShortName = "DPSF0110015", Order = 131)]
		public int? DPSF0110015 { get; set; }

		[Display(Name = "DPSF0110016", ShortName = "DPSF0110016", Order = 132)]
		public int? DPSF0110016 { get; set; }

		[Display(Name = "DPSF0110017", ShortName = "DPSF0110017", Order = 133)]
		public int? DPSF0110017 { get; set; }

		[Display(Name = "DPSF0120001", ShortName = "DPSF0120001", Order = 134)]
		public int? DPSF0120001 { get; set; }

		[Display(Name = "DPSF0120002", ShortName = "DPSF0120002", Order = 135)]
		public int? DPSF0120002 { get; set; }

		[Display(Name = "DPSF0120003", ShortName = "DPSF0120003", Order = 136)]
		public int? DPSF0120003 { get; set; }

		[Display(Name = "DPSF0120004", ShortName = "DPSF0120004", Order = 137)]
		public int? DPSF0120004 { get; set; }

		[Display(Name = "DPSF0120005", ShortName = "DPSF0120005", Order = 138)]
		public int? DPSF0120005 { get; set; }

		[Display(Name = "DPSF0120006", ShortName = "DPSF0120006", Order = 139)]
		public int? DPSF0120006 { get; set; }

		[Display(Name = "DPSF0120007", ShortName = "DPSF0120007", Order = 140)]
		public int? DPSF0120007 { get; set; }

		[Display(Name = "DPSF0120008", ShortName = "DPSF0120008", Order = 141)]
		public int? DPSF0120008 { get; set; }

		[Display(Name = "DPSF0120009", ShortName = "DPSF0120009", Order = 142)]
		public int? DPSF0120009 { get; set; }

		[Display(Name = "DPSF0120010", ShortName = "DPSF0120010", Order = 143)]
		public int? DPSF0120010 { get; set; }

		[Display(Name = "DPSF0120011", ShortName = "DPSF0120011", Order = 144)]
		public int? DPSF0120011 { get; set; }

		[Display(Name = "DPSF0120012", ShortName = "DPSF0120012", Order = 145)]
		public int? DPSF0120012 { get; set; }

		[Display(Name = "DPSF0120013", ShortName = "DPSF0120013", Order = 146)]
		public int? DPSF0120013 { get; set; }

		[Display(Name = "DPSF0120014", ShortName = "DPSF0120014", Order = 147)]
		public int? DPSF0120014 { get; set; }

		[Display(Name = "DPSF0120015", ShortName = "DPSF0120015", Order = 148)]
		public int? DPSF0120015 { get; set; }

		[Display(Name = "DPSF0120016", ShortName = "DPSF0120016", Order = 149)]
		public int? DPSF0120016 { get; set; }

		[Display(Name = "DPSF0120017", ShortName = "DPSF0120017", Order = 150)]
		public int? DPSF0120017 { get; set; }

		[Display(Name = "DPSF0120018", ShortName = "DPSF0120018", Order = 151)]
		public int? DPSF0120018 { get; set; }

		[Display(Name = "DPSF0120019", ShortName = "DPSF0120019", Order = 152)]
		public int? DPSF0120019 { get; set; }

		[Display(Name = "DPSF0120020", ShortName = "DPSF0120020", Order = 153)]
		public int? DPSF0120020 { get; set; }

		[Display(Name = "DPSF0130001", ShortName = "DPSF0130001", Order = 154)]
		public int? DPSF0130001 { get; set; }

		[Display(Name = "DPSF0130002", ShortName = "DPSF0130002", Order = 155)]
		public int? DPSF0130002 { get; set; }

		[Display(Name = "DPSF0130003", ShortName = "DPSF0130003", Order = 156)]
		public int? DPSF0130003 { get; set; }

		[Display(Name = "DPSF0130004", ShortName = "DPSF0130004", Order = 157)]
		public int? DPSF0130004 { get; set; }

		[Display(Name = "DPSF0130005", ShortName = "DPSF0130005", Order = 158)]
		public int? DPSF0130005 { get; set; }

		[Display(Name = "DPSF0130006", ShortName = "DPSF0130006", Order = 159)]
		public int? DPSF0130006 { get; set; }

		[Display(Name = "DPSF0130007", ShortName = "DPSF0130007", Order = 160)]
		public int? DPSF0130007 { get; set; }

		[Display(Name = "DPSF0130008", ShortName = "DPSF0130008", Order = 161)]
		public int? DPSF0130008 { get; set; }

		[Display(Name = "DPSF0130009", ShortName = "DPSF0130009", Order = 162)]
		public int? DPSF0130009 { get; set; }

		[Display(Name = "DPSF0130010", ShortName = "DPSF0130010", Order = 163)]
		public int? DPSF0130010 { get; set; }

		[Display(Name = "DPSF0130011", ShortName = "DPSF0130011", Order = 164)]
		public int? DPSF0130011 { get; set; }

		[Display(Name = "DPSF0130012", ShortName = "DPSF0130012", Order = 165)]
		public int? DPSF0130012 { get; set; }

		[Display(Name = "DPSF0130013", ShortName = "DPSF0130013", Order = 166)]
		public int? DPSF0130013 { get; set; }

		[Display(Name = "DPSF0130014", ShortName = "DPSF0130014", Order = 167)]
		public int? DPSF0130014 { get; set; }

		[Display(Name = "DPSF0130015", ShortName = "DPSF0130015", Order = 168)]
		public int? DPSF0130015 { get; set; }

		[Display(Name = "DPSF0140001", ShortName = "DPSF0140001", Order = 169)]
		public int? DPSF0140001 { get; set; }

		[Display(Name = "DPSF0150001", ShortName = "DPSF0150001", Order = 170)]
		public int? DPSF0150001 { get; set; }

		[Display(Name = "DPSF0160001", ShortName = "DPSF0160001", Order = 171)]
		public decimal? DPSF0160001 { get; set; }

		[Display(Name = "DPSF0170001", ShortName = "DPSF0170001", Order = 172)]
		public decimal? DPSF0170001 { get; set; }

		[Display(Name = "DPSF0180001", ShortName = "DPSF0180001", Order = 173)]
		public int? DPSF0180001 { get; set; }

		[Display(Name = "DPSF0180002", ShortName = "DPSF0180002", Order = 174)]
		public int? DPSF0180002 { get; set; }

		[Display(Name = "DPSF0180003", ShortName = "DPSF0180003", Order = 175)]
		public int? DPSF0180003 { get; set; }

		[Display(Name = "DPSF0180004", ShortName = "DPSF0180004", Order = 176)]
		public int? DPSF0180004 { get; set; }

		[Display(Name = "DPSF0180005", ShortName = "DPSF0180005", Order = 177)]
		public int? DPSF0180005 { get; set; }

		[Display(Name = "DPSF0180006", ShortName = "DPSF0180006", Order = 178)]
		public int? DPSF0180006 { get; set; }

		[Display(Name = "DPSF0180007", ShortName = "DPSF0180007", Order = 179)]
		public int? DPSF0180007 { get; set; }

		[Display(Name = "DPSF0180008", ShortName = "DPSF0180008", Order = 180)]
		public int? DPSF0180008 { get; set; }

		[Display(Name = "DPSF0180009", ShortName = "DPSF0180009", Order = 181)]
		public int? DPSF0180009 { get; set; }

		[Display(Name = "DPSF0190001", ShortName = "DPSF0190001", Order = 182)]
		public decimal? DPSF0190001 { get; set; }

		[Display(Name = "DPSF0200001", ShortName = "DPSF0200001", Order = 183)]
		public decimal? DPSF0200001 { get; set; }

		[Display(Name = "DPSF0210001", ShortName = "DPSF0210001", Order = 184)]
		public int? DPSF0210001 { get; set; }

		[Display(Name = "DPSF0210002", ShortName = "DPSF0210002", Order = 185)]
		public int? DPSF0210002 { get; set; }

		[Display(Name = "DPSF0210003", ShortName = "DPSF0210003", Order = 186)]
		public int? DPSF0210003 { get; set; }

		[Display(Name = "DPSF0220001", ShortName = "DPSF0220001", Order = 187)]
		public int? DPSF0220001 { get; set; }

		[Display(Name = "DPSF0220002", ShortName = "DPSF0220002", Order = 188)]
		public int? DPSF0220002 { get; set; }

		[Display(Name = "DPSF0230001", ShortName = "DPSF0230001", Order = 189)]
		public decimal? DPSF0230001 { get; set; }

		[Display(Name = "DPSF0230002", ShortName = "DPSF0230002", Order = 190)]
		public decimal? DPSF0230002 { get; set; }
		#endregion Properties

		#region Constructors
		public DemographicProfile_Part1(string csvLine) : base(csvLine) { }

		public DemographicProfile_Part1(string[] values) : base(values) { }

		public DemographicProfile_Part1(OleDbDataReader reader)
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
				LOGRECNO = (string)reader[4];
			}
			if (reader[5] != DBNull.Value)
			{
				DPSF0010001 = (int?)reader[5];
			}
			if (reader[6] != DBNull.Value)
			{
				DPSF0010002 = (int?)reader[6];
			}
			if (reader[7] != DBNull.Value)
			{
				DPSF0010003 = (int?)reader[7];
			}
			if (reader[8] != DBNull.Value)
			{
				DPSF0010004 = (int?)reader[8];
			}
			if (reader[9] != DBNull.Value)
			{
				DPSF0010005 = (int?)reader[9];
			}
			if (reader[10] != DBNull.Value)
			{
				DPSF0010006 = (int?)reader[10];
			}
			if (reader[11] != DBNull.Value)
			{
				DPSF0010007 = (int?)reader[11];
			}
			if (reader[12] != DBNull.Value)
			{
				DPSF0010008 = (int?)reader[12];
			}
			if (reader[13] != DBNull.Value)
			{
				DPSF0010009 = (int?)reader[13];
			}
			if (reader[14] != DBNull.Value)
			{
				DPSF0010010 = (int?)reader[14];
			}
			if (reader[15] != DBNull.Value)
			{
				DPSF0010011 = (int?)reader[15];
			}
			if (reader[16] != DBNull.Value)
			{
				DPSF0010012 = (int?)reader[16];
			}
			if (reader[17] != DBNull.Value)
			{
				DPSF0010013 = (int?)reader[17];
			}
			if (reader[18] != DBNull.Value)
			{
				DPSF0010014 = (int?)reader[18];
			}
			if (reader[19] != DBNull.Value)
			{
				DPSF0010015 = (int?)reader[19];
			}
			if (reader[20] != DBNull.Value)
			{
				DPSF0010016 = (int?)reader[20];
			}
			if (reader[21] != DBNull.Value)
			{
				DPSF0010017 = (int?)reader[21];
			}
			if (reader[22] != DBNull.Value)
			{
				DPSF0010018 = (int?)reader[22];
			}
			if (reader[23] != DBNull.Value)
			{
				DPSF0010019 = (int?)reader[23];
			}
			if (reader[24] != DBNull.Value)
			{
				DPSF0010020 = (int?)reader[24];
			}
			if (reader[25] != DBNull.Value)
			{
				DPSF0010021 = (int?)reader[25];
			}
			if (reader[26] != DBNull.Value)
			{
				DPSF0010022 = (int?)reader[26];
			}
			if (reader[27] != DBNull.Value)
			{
				DPSF0010023 = (int?)reader[27];
			}
			if (reader[28] != DBNull.Value)
			{
				DPSF0010024 = (int?)reader[28];
			}
			if (reader[29] != DBNull.Value)
			{
				DPSF0010025 = (int?)reader[29];
			}
			if (reader[30] != DBNull.Value)
			{
				DPSF0010026 = (int?)reader[30];
			}
			if (reader[31] != DBNull.Value)
			{
				DPSF0010027 = (int?)reader[31];
			}
			if (reader[32] != DBNull.Value)
			{
				DPSF0010028 = (int?)reader[32];
			}
			if (reader[33] != DBNull.Value)
			{
				DPSF0010029 = (int?)reader[33];
			}
			if (reader[34] != DBNull.Value)
			{
				DPSF0010030 = (int?)reader[34];
			}
			if (reader[35] != DBNull.Value)
			{
				DPSF0010031 = (int?)reader[35];
			}
			if (reader[36] != DBNull.Value)
			{
				DPSF0010032 = (int?)reader[36];
			}
			if (reader[37] != DBNull.Value)
			{
				DPSF0010033 = (int?)reader[37];
			}
			if (reader[38] != DBNull.Value)
			{
				DPSF0010034 = (int?)reader[38];
			}
			if (reader[39] != DBNull.Value)
			{
				DPSF0010035 = (int?)reader[39];
			}
			if (reader[40] != DBNull.Value)
			{
				DPSF0010036 = (int?)reader[40];
			}
			if (reader[41] != DBNull.Value)
			{
				DPSF0010037 = (int?)reader[41];
			}
			if (reader[42] != DBNull.Value)
			{
				DPSF0010038 = (int?)reader[42];
			}
			if (reader[43] != DBNull.Value)
			{
				DPSF0010039 = (int?)reader[43];
			}
			if (reader[44] != DBNull.Value)
			{
				DPSF0010040 = (int?)reader[44];
			}
			if (reader[45] != DBNull.Value)
			{
				DPSF0010041 = (int?)reader[45];
			}
			if (reader[46] != DBNull.Value)
			{
				DPSF0010042 = (int?)reader[46];
			}
			if (reader[47] != DBNull.Value)
			{
				DPSF0010043 = (int?)reader[47];
			}
			if (reader[48] != DBNull.Value)
			{
				DPSF0010044 = (int?)reader[48];
			}
			if (reader[49] != DBNull.Value)
			{
				DPSF0010045 = (int?)reader[49];
			}
			if (reader[50] != DBNull.Value)
			{
				DPSF0010046 = (int?)reader[50];
			}
			if (reader[51] != DBNull.Value)
			{
				DPSF0010047 = (int?)reader[51];
			}
			if (reader[52] != DBNull.Value)
			{
				DPSF0010048 = (int?)reader[52];
			}
			if (reader[53] != DBNull.Value)
			{
				DPSF0010049 = (int?)reader[53];
			}
			if (reader[54] != DBNull.Value)
			{
				DPSF0010050 = (int?)reader[54];
			}
			if (reader[55] != DBNull.Value)
			{
				DPSF0010051 = (int?)reader[55];
			}
			if (reader[56] != DBNull.Value)
			{
				DPSF0010052 = (int?)reader[56];
			}
			if (reader[57] != DBNull.Value)
			{
				DPSF0010053 = (int?)reader[57];
			}
			if (reader[58] != DBNull.Value)
			{
				DPSF0010054 = (int?)reader[58];
			}
			if (reader[59] != DBNull.Value)
			{
				DPSF0010055 = (int?)reader[59];
			}
			if (reader[60] != DBNull.Value)
			{
				DPSF0010056 = (int?)reader[60];
			}
			if (reader[61] != DBNull.Value)
			{
				DPSF0010057 = (int?)reader[61];
			}
			if (reader[62] != DBNull.Value)
			{
				DPSF0020001 = (decimal?)reader[62];
			}
			if (reader[63] != DBNull.Value)
			{
				DPSF0020002 = (decimal?)reader[63];
			}
			if (reader[64] != DBNull.Value)
			{
				DPSF0020003 = (decimal?)reader[64];
			}
			if (reader[65] != DBNull.Value)
			{
				DPSF0030001 = (int?)reader[65];
			}
			if (reader[66] != DBNull.Value)
			{
				DPSF0030002 = (int?)reader[66];
			}
			if (reader[67] != DBNull.Value)
			{
				DPSF0030003 = (int?)reader[67];
			}
			if (reader[68] != DBNull.Value)
			{
				DPSF0040001 = (int?)reader[68];
			}
			if (reader[69] != DBNull.Value)
			{
				DPSF0040002 = (int?)reader[69];
			}
			if (reader[70] != DBNull.Value)
			{
				DPSF0040003 = (int?)reader[70];
			}
			if (reader[71] != DBNull.Value)
			{
				DPSF0050001 = (int?)reader[71];
			}
			if (reader[72] != DBNull.Value)
			{
				DPSF0050002 = (int?)reader[72];
			}
			if (reader[73] != DBNull.Value)
			{
				DPSF0050003 = (int?)reader[73];
			}
			if (reader[74] != DBNull.Value)
			{
				DPSF0060001 = (int?)reader[74];
			}
			if (reader[75] != DBNull.Value)
			{
				DPSF0060002 = (int?)reader[75];
			}
			if (reader[76] != DBNull.Value)
			{
				DPSF0060003 = (int?)reader[76];
			}
			if (reader[77] != DBNull.Value)
			{
				DPSF0070001 = (int?)reader[77];
			}
			if (reader[78] != DBNull.Value)
			{
				DPSF0070002 = (int?)reader[78];
			}
			if (reader[79] != DBNull.Value)
			{
				DPSF0070003 = (int?)reader[79];
			}
			if (reader[80] != DBNull.Value)
			{
				DPSF0080001 = (int?)reader[80];
			}
			if (reader[81] != DBNull.Value)
			{
				DPSF0080002 = (int?)reader[81];
			}
			if (reader[82] != DBNull.Value)
			{
				DPSF0080003 = (int?)reader[82];
			}
			if (reader[83] != DBNull.Value)
			{
				DPSF0080004 = (int?)reader[83];
			}
			if (reader[84] != DBNull.Value)
			{
				DPSF0080005 = (int?)reader[84];
			}
			if (reader[85] != DBNull.Value)
			{
				DPSF0080006 = (int?)reader[85];
			}
			if (reader[86] != DBNull.Value)
			{
				DPSF0080007 = (int?)reader[86];
			}
			if (reader[87] != DBNull.Value)
			{
				DPSF0080008 = (int?)reader[87];
			}
			if (reader[88] != DBNull.Value)
			{
				DPSF0080009 = (int?)reader[88];
			}
			if (reader[89] != DBNull.Value)
			{
				DPSF0080010 = (int?)reader[89];
			}
			if (reader[90] != DBNull.Value)
			{
				DPSF0080011 = (int?)reader[90];
			}
			if (reader[91] != DBNull.Value)
			{
				DPSF0080012 = (int?)reader[91];
			}
			if (reader[92] != DBNull.Value)
			{
				DPSF0080013 = (int?)reader[92];
			}
			if (reader[93] != DBNull.Value)
			{
				DPSF0080014 = (int?)reader[93];
			}
			if (reader[94] != DBNull.Value)
			{
				DPSF0080015 = (int?)reader[94];
			}
			if (reader[95] != DBNull.Value)
			{
				DPSF0080016 = (int?)reader[95];
			}
			if (reader[96] != DBNull.Value)
			{
				DPSF0080017 = (int?)reader[96];
			}
			if (reader[97] != DBNull.Value)
			{
				DPSF0080018 = (int?)reader[97];
			}
			if (reader[98] != DBNull.Value)
			{
				DPSF0080019 = (int?)reader[98];
			}
			if (reader[99] != DBNull.Value)
			{
				DPSF0080020 = (int?)reader[99];
			}
			if (reader[100] != DBNull.Value)
			{
				DPSF0080021 = (int?)reader[100];
			}
			if (reader[101] != DBNull.Value)
			{
				DPSF0080022 = (int?)reader[101];
			}
			if (reader[102] != DBNull.Value)
			{
				DPSF0080023 = (int?)reader[102];
			}
			if (reader[103] != DBNull.Value)
			{
				DPSF0080024 = (int?)reader[103];
			}
			if (reader[104] != DBNull.Value)
			{
				DPSF0090001 = (int?)reader[104];
			}
			if (reader[105] != DBNull.Value)
			{
				DPSF0090002 = (int?)reader[105];
			}
			if (reader[106] != DBNull.Value)
			{
				DPSF0090003 = (int?)reader[106];
			}
			if (reader[107] != DBNull.Value)
			{
				DPSF0090004 = (int?)reader[107];
			}
			if (reader[108] != DBNull.Value)
			{
				DPSF0090005 = (int?)reader[108];
			}
			if (reader[109] != DBNull.Value)
			{
				DPSF0090006 = (int?)reader[109];
			}
			if (reader[110] != DBNull.Value)
			{
				DPSF0100001 = (int?)reader[110];
			}
			if (reader[111] != DBNull.Value)
			{
				DPSF0100002 = (int?)reader[111];
			}
			if (reader[112] != DBNull.Value)
			{
				DPSF0100003 = (int?)reader[112];
			}
			if (reader[113] != DBNull.Value)
			{
				DPSF0100004 = (int?)reader[113];
			}
			if (reader[114] != DBNull.Value)
			{
				DPSF0100005 = (int?)reader[114];
			}
			if (reader[115] != DBNull.Value)
			{
				DPSF0100006 = (int?)reader[115];
			}
			if (reader[116] != DBNull.Value)
			{
				DPSF0100007 = (int?)reader[116];
			}
			if (reader[117] != DBNull.Value)
			{
				DPSF0110001 = (int?)reader[117];
			}
			if (reader[118] != DBNull.Value)
			{
				DPSF0110002 = (int?)reader[118];
			}
			if (reader[119] != DBNull.Value)
			{
				DPSF0110003 = (int?)reader[119];
			}
			if (reader[120] != DBNull.Value)
			{
				DPSF0110004 = (int?)reader[120];
			}
			if (reader[121] != DBNull.Value)
			{
				DPSF0110005 = (int?)reader[121];
			}
			if (reader[122] != DBNull.Value)
			{
				DPSF0110006 = (int?)reader[122];
			}
			if (reader[123] != DBNull.Value)
			{
				DPSF0110007 = (int?)reader[123];
			}
			if (reader[124] != DBNull.Value)
			{
				DPSF0110008 = (int?)reader[124];
			}
			if (reader[125] != DBNull.Value)
			{
				DPSF0110009 = (int?)reader[125];
			}
			if (reader[126] != DBNull.Value)
			{
				DPSF0110010 = (int?)reader[126];
			}
			if (reader[127] != DBNull.Value)
			{
				DPSF0110011 = (int?)reader[127];
			}
			if (reader[128] != DBNull.Value)
			{
				DPSF0110012 = (int?)reader[128];
			}
			if (reader[129] != DBNull.Value)
			{
				DPSF0110013 = (int?)reader[129];
			}
			if (reader[130] != DBNull.Value)
			{
				DPSF0110014 = (int?)reader[130];
			}
			if (reader[131] != DBNull.Value)
			{
				DPSF0110015 = (int?)reader[131];
			}
			if (reader[132] != DBNull.Value)
			{
				DPSF0110016 = (int?)reader[132];
			}
			if (reader[133] != DBNull.Value)
			{
				DPSF0110017 = (int?)reader[133];
			}
			if (reader[134] != DBNull.Value)
			{
				DPSF0120001 = (int?)reader[134];
			}
			if (reader[135] != DBNull.Value)
			{
				DPSF0120002 = (int?)reader[135];
			}
			if (reader[136] != DBNull.Value)
			{
				DPSF0120003 = (int?)reader[136];
			}
			if (reader[137] != DBNull.Value)
			{
				DPSF0120004 = (int?)reader[137];
			}
			if (reader[138] != DBNull.Value)
			{
				DPSF0120005 = (int?)reader[138];
			}
			if (reader[139] != DBNull.Value)
			{
				DPSF0120006 = (int?)reader[139];
			}
			if (reader[140] != DBNull.Value)
			{
				DPSF0120007 = (int?)reader[140];
			}
			if (reader[141] != DBNull.Value)
			{
				DPSF0120008 = (int?)reader[141];
			}
			if (reader[142] != DBNull.Value)
			{
				DPSF0120009 = (int?)reader[142];
			}
			if (reader[143] != DBNull.Value)
			{
				DPSF0120010 = (int?)reader[143];
			}
			if (reader[144] != DBNull.Value)
			{
				DPSF0120011 = (int?)reader[144];
			}
			if (reader[145] != DBNull.Value)
			{
				DPSF0120012 = (int?)reader[145];
			}
			if (reader[146] != DBNull.Value)
			{
				DPSF0120013 = (int?)reader[146];
			}
			if (reader[147] != DBNull.Value)
			{
				DPSF0120014 = (int?)reader[147];
			}
			if (reader[148] != DBNull.Value)
			{
				DPSF0120015 = (int?)reader[148];
			}
			if (reader[149] != DBNull.Value)
			{
				DPSF0120016 = (int?)reader[149];
			}
			if (reader[150] != DBNull.Value)
			{
				DPSF0120017 = (int?)reader[150];
			}
			if (reader[151] != DBNull.Value)
			{
				DPSF0120018 = (int?)reader[151];
			}
			if (reader[152] != DBNull.Value)
			{
				DPSF0120019 = (int?)reader[152];
			}
			if (reader[153] != DBNull.Value)
			{
				DPSF0120020 = (int?)reader[153];
			}
			if (reader[154] != DBNull.Value)
			{
				DPSF0130001 = (int?)reader[154];
			}
			if (reader[155] != DBNull.Value)
			{
				DPSF0130002 = (int?)reader[155];
			}
			if (reader[156] != DBNull.Value)
			{
				DPSF0130003 = (int?)reader[156];
			}
			if (reader[157] != DBNull.Value)
			{
				DPSF0130004 = (int?)reader[157];
			}
			if (reader[158] != DBNull.Value)
			{
				DPSF0130005 = (int?)reader[158];
			}
			if (reader[159] != DBNull.Value)
			{
				DPSF0130006 = (int?)reader[159];
			}
			if (reader[160] != DBNull.Value)
			{
				DPSF0130007 = (int?)reader[160];
			}
			if (reader[161] != DBNull.Value)
			{
				DPSF0130008 = (int?)reader[161];
			}
			if (reader[162] != DBNull.Value)
			{
				DPSF0130009 = (int?)reader[162];
			}
			if (reader[163] != DBNull.Value)
			{
				DPSF0130010 = (int?)reader[163];
			}
			if (reader[164] != DBNull.Value)
			{
				DPSF0130011 = (int?)reader[164];
			}
			if (reader[165] != DBNull.Value)
			{
				DPSF0130012 = (int?)reader[165];
			}
			if (reader[166] != DBNull.Value)
			{
				DPSF0130013 = (int?)reader[166];
			}
			if (reader[167] != DBNull.Value)
			{
				DPSF0130014 = (int?)reader[167];
			}
			if (reader[168] != DBNull.Value)
			{
				DPSF0130015 = (int?)reader[168];
			}
			if (reader[169] != DBNull.Value)
			{
				DPSF0140001 = (int?)reader[169];
			}
			if (reader[170] != DBNull.Value)
			{
				DPSF0150001 = (int?)reader[170];
			}
			if (reader[171] != DBNull.Value)
			{
				DPSF0160001 = (decimal?)reader[171];
			}
			if (reader[172] != DBNull.Value)
			{
				DPSF0170001 = (decimal?)reader[172];
			}
			if (reader[173] != DBNull.Value)
			{
				DPSF0180001 = (int?)reader[173];
			}
			if (reader[174] != DBNull.Value)
			{
				DPSF0180002 = (int?)reader[174];
			}
			if (reader[175] != DBNull.Value)
			{
				DPSF0180003 = (int?)reader[175];
			}
			if (reader[176] != DBNull.Value)
			{
				DPSF0180004 = (int?)reader[176];
			}
			if (reader[177] != DBNull.Value)
			{
				DPSF0180005 = (int?)reader[177];
			}
			if (reader[178] != DBNull.Value)
			{
				DPSF0180006 = (int?)reader[178];
			}
			if (reader[179] != DBNull.Value)
			{
				DPSF0180007 = (int?)reader[179];
			}
			if (reader[180] != DBNull.Value)
			{
				DPSF0180008 = (int?)reader[180];
			}
			if (reader[181] != DBNull.Value)
			{
				DPSF0180009 = (int?)reader[181];
			}
			if (reader[182] != DBNull.Value)
			{
				DPSF0190001 = (decimal?)reader[182];
			}
			if (reader[183] != DBNull.Value)
			{
				DPSF0200001 = (decimal?)reader[183];
			}
			if (reader[184] != DBNull.Value)
			{
				DPSF0210001 = (int?)reader[184];
			}
			if (reader[185] != DBNull.Value)
			{
				DPSF0210002 = (int?)reader[185];
			}
			if (reader[186] != DBNull.Value)
			{
				DPSF0210003 = (int?)reader[186];
			}
			if (reader[187] != DBNull.Value)
			{
				DPSF0220001 = (int?)reader[187];
			}
			if (reader[188] != DBNull.Value)
			{
				DPSF0220002 = (int?)reader[188];
			}
			if (reader[189] != DBNull.Value)
			{
				DPSF0230001 = (decimal?)reader[189];
			}
			if (reader[190] != DBNull.Value)
			{
				DPSF0230002 = (decimal?)reader[190];
			}
		}
		#endregion Constructors
	}
}
