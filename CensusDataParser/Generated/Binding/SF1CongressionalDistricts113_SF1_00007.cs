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

	public class SF1CongressionalDistricts113_SF1_00007 : BaseModel
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
		public int? P0500001 { get; set; }

		[Display(Name = "Allocated", ShortName = "Allocated", Order = 6)]
		public int? P0500002 { get; set; }

		[Display(Name = "Not allocated", ShortName = "Not allocated", Order = 7)]
		public int? P0500003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 8)]
		public int? P0510001 { get; set; }

		[Display(Name = "No items allocated", ShortName = "No items allocated", Order = 9)]
		public int? P0510002 { get; set; }

		[Display(Name = "One or more items allocated", ShortName = "One or more items allocated", Order = 10)]
		public int? P0510003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 11)]
		public int? P012A001 { get; set; }

		[Display(Name = "Male:", ShortName = "Male:", Order = 12)]
		public int? P012A002 { get; set; }

		[Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 13)]
		public int? P012A003 { get; set; }

		[Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 14)]
		public int? P012A004 { get; set; }

		[Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 15)]
		public int? P012A005 { get; set; }

		[Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 16)]
		public int? P012A006 { get; set; }

		[Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 17)]
		public int? P012A007 { get; set; }

		[Display(Name = "20 years", ShortName = "20 years", Order = 18)]
		public int? P012A008 { get; set; }

		[Display(Name = "21 years", ShortName = "21 years", Order = 19)]
		public int? P012A009 { get; set; }

		[Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 20)]
		public int? P012A010 { get; set; }

		[Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 21)]
		public int? P012A011 { get; set; }

		[Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 22)]
		public int? P012A012 { get; set; }

		[Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 23)]
		public int? P012A013 { get; set; }

		[Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 24)]
		public int? P012A014 { get; set; }

		[Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 25)]
		public int? P012A015 { get; set; }

		[Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 26)]
		public int? P012A016 { get; set; }

		[Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 27)]
		public int? P012A017 { get; set; }

		[Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 28)]
		public int? P012A018 { get; set; }

		[Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 29)]
		public int? P012A019 { get; set; }

		[Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 30)]
		public int? P012A020 { get; set; }

		[Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 31)]
		public int? P012A021 { get; set; }

		[Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 32)]
		public int? P012A022 { get; set; }

		[Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 33)]
		public int? P012A023 { get; set; }

		[Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 34)]
		public int? P012A024 { get; set; }

		[Display(Name = "85 years and over", ShortName = "85 years and over", Order = 35)]
		public int? P012A025 { get; set; }

		[Display(Name = "Female:", ShortName = "Female:", Order = 36)]
		public int? P012A026 { get; set; }

		[Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 37)]
		public int? P012A027 { get; set; }

		[Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 38)]
		public int? P012A028 { get; set; }

		[Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 39)]
		public int? P012A029 { get; set; }

		[Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 40)]
		public int? P012A030 { get; set; }

		[Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 41)]
		public int? P012A031 { get; set; }

		[Display(Name = "20 years", ShortName = "20 years", Order = 42)]
		public int? P012A032 { get; set; }

		[Display(Name = "21 years", ShortName = "21 years", Order = 43)]
		public int? P012A033 { get; set; }

		[Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 44)]
		public int? P012A034 { get; set; }

		[Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 45)]
		public int? P012A035 { get; set; }

		[Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 46)]
		public int? P012A036 { get; set; }

		[Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 47)]
		public int? P012A037 { get; set; }

		[Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 48)]
		public int? P012A038 { get; set; }

		[Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 49)]
		public int? P012A039 { get; set; }

		[Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 50)]
		public int? P012A040 { get; set; }

		[Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 51)]
		public int? P012A041 { get; set; }

		[Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 52)]
		public int? P012A042 { get; set; }

		[Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 53)]
		public int? P012A043 { get; set; }

		[Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 54)]
		public int? P012A044 { get; set; }

		[Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 55)]
		public int? P012A045 { get; set; }

		[Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 56)]
		public int? P012A046 { get; set; }

		[Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 57)]
		public int? P012A047 { get; set; }

		[Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 58)]
		public int? P012A048 { get; set; }

		[Display(Name = "85 years and over", ShortName = "85 years and over", Order = 59)]
		public int? P012A049 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 60)]
		public int? P012B001 { get; set; }

		[Display(Name = "Male:", ShortName = "Male:", Order = 61)]
		public int? P012B002 { get; set; }

		[Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 62)]
		public int? P012B003 { get; set; }

		[Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 63)]
		public int? P012B004 { get; set; }

		[Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 64)]
		public int? P012B005 { get; set; }

		[Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 65)]
		public int? P012B006 { get; set; }

		[Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 66)]
		public int? P012B007 { get; set; }

		[Display(Name = "20 years", ShortName = "20 years", Order = 67)]
		public int? P012B008 { get; set; }

		[Display(Name = "21 years", ShortName = "21 years", Order = 68)]
		public int? P012B009 { get; set; }

		[Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 69)]
		public int? P012B010 { get; set; }

		[Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 70)]
		public int? P012B011 { get; set; }

		[Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 71)]
		public int? P012B012 { get; set; }

		[Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 72)]
		public int? P012B013 { get; set; }

		[Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 73)]
		public int? P012B014 { get; set; }

		[Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 74)]
		public int? P012B015 { get; set; }

		[Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 75)]
		public int? P012B016 { get; set; }

		[Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 76)]
		public int? P012B017 { get; set; }

		[Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 77)]
		public int? P012B018 { get; set; }

		[Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 78)]
		public int? P012B019 { get; set; }

		[Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 79)]
		public int? P012B020 { get; set; }

		[Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 80)]
		public int? P012B021 { get; set; }

		[Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 81)]
		public int? P012B022 { get; set; }

		[Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 82)]
		public int? P012B023 { get; set; }

		[Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 83)]
		public int? P012B024 { get; set; }

		[Display(Name = "85 years and over", ShortName = "85 years and over", Order = 84)]
		public int? P012B025 { get; set; }

		[Display(Name = "Female:", ShortName = "Female:", Order = 85)]
		public int? P012B026 { get; set; }

		[Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 86)]
		public int? P012B027 { get; set; }

		[Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 87)]
		public int? P012B028 { get; set; }

		[Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 88)]
		public int? P012B029 { get; set; }

		[Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 89)]
		public int? P012B030 { get; set; }

		[Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 90)]
		public int? P012B031 { get; set; }

		[Display(Name = "20 years", ShortName = "20 years", Order = 91)]
		public int? P012B032 { get; set; }

		[Display(Name = "21 years", ShortName = "21 years", Order = 92)]
		public int? P012B033 { get; set; }

		[Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 93)]
		public int? P012B034 { get; set; }

		[Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 94)]
		public int? P012B035 { get; set; }

		[Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 95)]
		public int? P012B036 { get; set; }

		[Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 96)]
		public int? P012B037 { get; set; }

		[Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 97)]
		public int? P012B038 { get; set; }

		[Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 98)]
		public int? P012B039 { get; set; }

		[Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 99)]
		public int? P012B040 { get; set; }

		[Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 100)]
		public int? P012B041 { get; set; }

		[Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 101)]
		public int? P012B042 { get; set; }

		[Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 102)]
		public int? P012B043 { get; set; }

		[Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 103)]
		public int? P012B044 { get; set; }

		[Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 104)]
		public int? P012B045 { get; set; }

		[Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 105)]
		public int? P012B046 { get; set; }

		[Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 106)]
		public int? P012B047 { get; set; }

		[Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 107)]
		public int? P012B048 { get; set; }

		[Display(Name = "85 years and over", ShortName = "85 years and over", Order = 108)]
		public int? P012B049 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 109)]
		public int? P012C001 { get; set; }

		[Display(Name = "Male:", ShortName = "Male:", Order = 110)]
		public int? P012C002 { get; set; }

		[Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 111)]
		public int? P012C003 { get; set; }

		[Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 112)]
		public int? P012C004 { get; set; }

		[Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 113)]
		public int? P012C005 { get; set; }

		[Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 114)]
		public int? P012C006 { get; set; }

		[Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 115)]
		public int? P012C007 { get; set; }

		[Display(Name = "20 years", ShortName = "20 years", Order = 116)]
		public int? P012C008 { get; set; }

		[Display(Name = "21 years", ShortName = "21 years", Order = 117)]
		public int? P012C009 { get; set; }

		[Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 118)]
		public int? P012C010 { get; set; }

		[Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 119)]
		public int? P012C011 { get; set; }

		[Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 120)]
		public int? P012C012 { get; set; }

		[Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 121)]
		public int? P012C013 { get; set; }

		[Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 122)]
		public int? P012C014 { get; set; }

		[Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 123)]
		public int? P012C015 { get; set; }

		[Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 124)]
		public int? P012C016 { get; set; }

		[Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 125)]
		public int? P012C017 { get; set; }

		[Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 126)]
		public int? P012C018 { get; set; }

		[Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 127)]
		public int? P012C019 { get; set; }

		[Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 128)]
		public int? P012C020 { get; set; }

		[Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 129)]
		public int? P012C021 { get; set; }

		[Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 130)]
		public int? P012C022 { get; set; }

		[Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 131)]
		public int? P012C023 { get; set; }

		[Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 132)]
		public int? P012C024 { get; set; }

		[Display(Name = "85 years and over", ShortName = "85 years and over", Order = 133)]
		public int? P012C025 { get; set; }

		[Display(Name = "Female:", ShortName = "Female:", Order = 134)]
		public int? P012C026 { get; set; }

		[Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 135)]
		public int? P012C027 { get; set; }

		[Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 136)]
		public int? P012C028 { get; set; }

		[Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 137)]
		public int? P012C029 { get; set; }

		[Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 138)]
		public int? P012C030 { get; set; }

		[Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 139)]
		public int? P012C031 { get; set; }

		[Display(Name = "20 years", ShortName = "20 years", Order = 140)]
		public int? P012C032 { get; set; }

		[Display(Name = "21 years", ShortName = "21 years", Order = 141)]
		public int? P012C033 { get; set; }

		[Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 142)]
		public int? P012C034 { get; set; }

		[Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 143)]
		public int? P012C035 { get; set; }

		[Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 144)]
		public int? P012C036 { get; set; }

		[Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 145)]
		public int? P012C037 { get; set; }

		[Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 146)]
		public int? P012C038 { get; set; }

		[Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 147)]
		public int? P012C039 { get; set; }

		[Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 148)]
		public int? P012C040 { get; set; }

		[Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 149)]
		public int? P012C041 { get; set; }

		[Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 150)]
		public int? P012C042 { get; set; }

		[Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 151)]
		public int? P012C043 { get; set; }

		[Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 152)]
		public int? P012C044 { get; set; }

		[Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 153)]
		public int? P012C045 { get; set; }

		[Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 154)]
		public int? P012C046 { get; set; }

		[Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 155)]
		public int? P012C047 { get; set; }

		[Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 156)]
		public int? P012C048 { get; set; }

		[Display(Name = "85 years and over", ShortName = "85 years and over", Order = 157)]
		public int? P012C049 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 158)]
		public int? P012D001 { get; set; }

		[Display(Name = "Male:", ShortName = "Male:", Order = 159)]
		public int? P012D002 { get; set; }

		[Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 160)]
		public int? P012D003 { get; set; }

		[Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 161)]
		public int? P012D004 { get; set; }

		[Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 162)]
		public int? P012D005 { get; set; }

		[Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 163)]
		public int? P012D006 { get; set; }

		[Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 164)]
		public int? P012D007 { get; set; }

		[Display(Name = "20 years", ShortName = "20 years", Order = 165)]
		public int? P012D008 { get; set; }

		[Display(Name = "21 years", ShortName = "21 years", Order = 166)]
		public int? P012D009 { get; set; }

		[Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 167)]
		public int? P012D010 { get; set; }

		[Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 168)]
		public int? P012D011 { get; set; }

		[Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 169)]
		public int? P012D012 { get; set; }

		[Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 170)]
		public int? P012D013 { get; set; }

		[Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 171)]
		public int? P012D014 { get; set; }

		[Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 172)]
		public int? P012D015 { get; set; }

		[Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 173)]
		public int? P012D016 { get; set; }

		[Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 174)]
		public int? P012D017 { get; set; }

		[Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 175)]
		public int? P012D018 { get; set; }

		[Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 176)]
		public int? P012D019 { get; set; }

		[Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 177)]
		public int? P012D020 { get; set; }

		[Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 178)]
		public int? P012D021 { get; set; }

		[Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 179)]
		public int? P012D022 { get; set; }

		[Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 180)]
		public int? P012D023 { get; set; }

		[Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 181)]
		public int? P012D024 { get; set; }

		[Display(Name = "85 years and over", ShortName = "85 years and over", Order = 182)]
		public int? P012D025 { get; set; }

		[Display(Name = "Female:", ShortName = "Female:", Order = 183)]
		public int? P012D026 { get; set; }

		[Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 184)]
		public int? P012D027 { get; set; }

		[Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 185)]
		public int? P012D028 { get; set; }

		[Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 186)]
		public int? P012D029 { get; set; }

		[Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 187)]
		public int? P012D030 { get; set; }

		[Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 188)]
		public int? P012D031 { get; set; }

		[Display(Name = "20 years", ShortName = "20 years", Order = 189)]
		public int? P012D032 { get; set; }

		[Display(Name = "21 years", ShortName = "21 years", Order = 190)]
		public int? P012D033 { get; set; }

		[Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 191)]
		public int? P012D034 { get; set; }

		[Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 192)]
		public int? P012D035 { get; set; }

		[Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 193)]
		public int? P012D036 { get; set; }

		[Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 194)]
		public int? P012D037 { get; set; }

		[Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 195)]
		public int? P012D038 { get; set; }

		[Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 196)]
		public int? P012D039 { get; set; }

		[Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 197)]
		public int? P012D040 { get; set; }

		[Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 198)]
		public int? P012D041 { get; set; }

		[Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 199)]
		public int? P012D042 { get; set; }

		[Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 200)]
		public int? P012D043 { get; set; }

		[Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 201)]
		public int? P012D044 { get; set; }

		[Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 202)]
		public int? P012D045 { get; set; }

		[Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 203)]
		public int? P012D046 { get; set; }

		[Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 204)]
		public int? P012D047 { get; set; }

		[Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 205)]
		public int? P012D048 { get; set; }

		[Display(Name = "85 years and over", ShortName = "85 years and over", Order = 206)]
		public int? P012D049 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 207)]
		public int? P012E001 { get; set; }

		[Display(Name = "Male:", ShortName = "Male:", Order = 208)]
		public int? P012E002 { get; set; }

		[Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 209)]
		public int? P012E003 { get; set; }

		[Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 210)]
		public int? P012E004 { get; set; }

		[Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 211)]
		public int? P012E005 { get; set; }

		[Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 212)]
		public int? P012E006 { get; set; }

		[Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 213)]
		public int? P012E007 { get; set; }

		[Display(Name = "20 years", ShortName = "20 years", Order = 214)]
		public int? P012E008 { get; set; }

		[Display(Name = "21 years", ShortName = "21 years", Order = 215)]
		public int? P012E009 { get; set; }

		[Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 216)]
		public int? P012E010 { get; set; }

		[Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 217)]
		public int? P012E011 { get; set; }

		[Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 218)]
		public int? P012E012 { get; set; }

		[Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 219)]
		public int? P012E013 { get; set; }

		[Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 220)]
		public int? P012E014 { get; set; }

		[Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 221)]
		public int? P012E015 { get; set; }

		[Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 222)]
		public int? P012E016 { get; set; }

		[Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 223)]
		public int? P012E017 { get; set; }

		[Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 224)]
		public int? P012E018 { get; set; }

		[Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 225)]
		public int? P012E019 { get; set; }

		[Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 226)]
		public int? P012E020 { get; set; }

		[Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 227)]
		public int? P012E021 { get; set; }

		[Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 228)]
		public int? P012E022 { get; set; }

		[Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 229)]
		public int? P012E023 { get; set; }

		[Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 230)]
		public int? P012E024 { get; set; }

		[Display(Name = "85 years and over", ShortName = "85 years and over", Order = 231)]
		public int? P012E025 { get; set; }

		[Display(Name = "Female:", ShortName = "Female:", Order = 232)]
		public int? P012E026 { get; set; }

		[Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 233)]
		public int? P012E027 { get; set; }

		[Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 234)]
		public int? P012E028 { get; set; }

		[Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 235)]
		public int? P012E029 { get; set; }

		[Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 236)]
		public int? P012E030 { get; set; }

		[Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 237)]
		public int? P012E031 { get; set; }

		[Display(Name = "20 years", ShortName = "20 years", Order = 238)]
		public int? P012E032 { get; set; }

		[Display(Name = "21 years", ShortName = "21 years", Order = 239)]
		public int? P012E033 { get; set; }

		[Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 240)]
		public int? P012E034 { get; set; }

		[Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 241)]
		public int? P012E035 { get; set; }

		[Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 242)]
		public int? P012E036 { get; set; }

		[Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 243)]
		public int? P012E037 { get; set; }

		[Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 244)]
		public int? P012E038 { get; set; }

		[Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 245)]
		public int? P012E039 { get; set; }

		[Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 246)]
		public int? P012E040 { get; set; }

		[Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 247)]
		public int? P012E041 { get; set; }

		[Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 248)]
		public int? P012E042 { get; set; }

		[Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 249)]
		public int? P012E043 { get; set; }

		[Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 250)]
		public int? P012E044 { get; set; }

		[Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 251)]
		public int? P012E045 { get; set; }

		[Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 252)]
		public int? P012E046 { get; set; }

		[Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 253)]
		public int? P012E047 { get; set; }

		[Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 254)]
		public int? P012E048 { get; set; }

		[Display(Name = "85 years and over", ShortName = "85 years and over", Order = 255)]
		public int? P012E049 { get; set; }
		#endregion Properties

		#region Constructors
		public SF1CongressionalDistricts113_SF1_00007() { }

		public SF1CongressionalDistricts113_SF1_00007(string csvLine) : base(csvLine) { }

		public SF1CongressionalDistricts113_SF1_00007(string[] values) : base(values) { }

		public SF1CongressionalDistricts113_SF1_00007(OleDbDataReader reader)
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
				P0500001 = (int?)reader[5];
			}
			if(reader[6] != DBNull.Value)
			{
				P0500002 = (int?)reader[6];
			}
			if(reader[7] != DBNull.Value)
			{
				P0500003 = (int?)reader[7];
			}
			if(reader[8] != DBNull.Value)
			{
				P0510001 = (int?)reader[8];
			}
			if(reader[9] != DBNull.Value)
			{
				P0510002 = (int?)reader[9];
			}
			if(reader[10] != DBNull.Value)
			{
				P0510003 = (int?)reader[10];
			}
			if(reader[11] != DBNull.Value)
			{
				P012A001 = (int?)reader[11];
			}
			if(reader[12] != DBNull.Value)
			{
				P012A002 = (int?)reader[12];
			}
			if(reader[13] != DBNull.Value)
			{
				P012A003 = (int?)reader[13];
			}
			if(reader[14] != DBNull.Value)
			{
				P012A004 = (int?)reader[14];
			}
			if(reader[15] != DBNull.Value)
			{
				P012A005 = (int?)reader[15];
			}
			if(reader[16] != DBNull.Value)
			{
				P012A006 = (int?)reader[16];
			}
			if(reader[17] != DBNull.Value)
			{
				P012A007 = (int?)reader[17];
			}
			if(reader[18] != DBNull.Value)
			{
				P012A008 = (int?)reader[18];
			}
			if(reader[19] != DBNull.Value)
			{
				P012A009 = (int?)reader[19];
			}
			if(reader[20] != DBNull.Value)
			{
				P012A010 = (int?)reader[20];
			}
			if(reader[21] != DBNull.Value)
			{
				P012A011 = (int?)reader[21];
			}
			if(reader[22] != DBNull.Value)
			{
				P012A012 = (int?)reader[22];
			}
			if(reader[23] != DBNull.Value)
			{
				P012A013 = (int?)reader[23];
			}
			if(reader[24] != DBNull.Value)
			{
				P012A014 = (int?)reader[24];
			}
			if(reader[25] != DBNull.Value)
			{
				P012A015 = (int?)reader[25];
			}
			if(reader[26] != DBNull.Value)
			{
				P012A016 = (int?)reader[26];
			}
			if(reader[27] != DBNull.Value)
			{
				P012A017 = (int?)reader[27];
			}
			if(reader[28] != DBNull.Value)
			{
				P012A018 = (int?)reader[28];
			}
			if(reader[29] != DBNull.Value)
			{
				P012A019 = (int?)reader[29];
			}
			if(reader[30] != DBNull.Value)
			{
				P012A020 = (int?)reader[30];
			}
			if(reader[31] != DBNull.Value)
			{
				P012A021 = (int?)reader[31];
			}
			if(reader[32] != DBNull.Value)
			{
				P012A022 = (int?)reader[32];
			}
			if(reader[33] != DBNull.Value)
			{
				P012A023 = (int?)reader[33];
			}
			if(reader[34] != DBNull.Value)
			{
				P012A024 = (int?)reader[34];
			}
			if(reader[35] != DBNull.Value)
			{
				P012A025 = (int?)reader[35];
			}
			if(reader[36] != DBNull.Value)
			{
				P012A026 = (int?)reader[36];
			}
			if(reader[37] != DBNull.Value)
			{
				P012A027 = (int?)reader[37];
			}
			if(reader[38] != DBNull.Value)
			{
				P012A028 = (int?)reader[38];
			}
			if(reader[39] != DBNull.Value)
			{
				P012A029 = (int?)reader[39];
			}
			if(reader[40] != DBNull.Value)
			{
				P012A030 = (int?)reader[40];
			}
			if(reader[41] != DBNull.Value)
			{
				P012A031 = (int?)reader[41];
			}
			if(reader[42] != DBNull.Value)
			{
				P012A032 = (int?)reader[42];
			}
			if(reader[43] != DBNull.Value)
			{
				P012A033 = (int?)reader[43];
			}
			if(reader[44] != DBNull.Value)
			{
				P012A034 = (int?)reader[44];
			}
			if(reader[45] != DBNull.Value)
			{
				P012A035 = (int?)reader[45];
			}
			if(reader[46] != DBNull.Value)
			{
				P012A036 = (int?)reader[46];
			}
			if(reader[47] != DBNull.Value)
			{
				P012A037 = (int?)reader[47];
			}
			if(reader[48] != DBNull.Value)
			{
				P012A038 = (int?)reader[48];
			}
			if(reader[49] != DBNull.Value)
			{
				P012A039 = (int?)reader[49];
			}
			if(reader[50] != DBNull.Value)
			{
				P012A040 = (int?)reader[50];
			}
			if(reader[51] != DBNull.Value)
			{
				P012A041 = (int?)reader[51];
			}
			if(reader[52] != DBNull.Value)
			{
				P012A042 = (int?)reader[52];
			}
			if(reader[53] != DBNull.Value)
			{
				P012A043 = (int?)reader[53];
			}
			if(reader[54] != DBNull.Value)
			{
				P012A044 = (int?)reader[54];
			}
			if(reader[55] != DBNull.Value)
			{
				P012A045 = (int?)reader[55];
			}
			if(reader[56] != DBNull.Value)
			{
				P012A046 = (int?)reader[56];
			}
			if(reader[57] != DBNull.Value)
			{
				P012A047 = (int?)reader[57];
			}
			if(reader[58] != DBNull.Value)
			{
				P012A048 = (int?)reader[58];
			}
			if(reader[59] != DBNull.Value)
			{
				P012A049 = (int?)reader[59];
			}
			if(reader[60] != DBNull.Value)
			{
				P012B001 = (int?)reader[60];
			}
			if(reader[61] != DBNull.Value)
			{
				P012B002 = (int?)reader[61];
			}
			if(reader[62] != DBNull.Value)
			{
				P012B003 = (int?)reader[62];
			}
			if(reader[63] != DBNull.Value)
			{
				P012B004 = (int?)reader[63];
			}
			if(reader[64] != DBNull.Value)
			{
				P012B005 = (int?)reader[64];
			}
			if(reader[65] != DBNull.Value)
			{
				P012B006 = (int?)reader[65];
			}
			if(reader[66] != DBNull.Value)
			{
				P012B007 = (int?)reader[66];
			}
			if(reader[67] != DBNull.Value)
			{
				P012B008 = (int?)reader[67];
			}
			if(reader[68] != DBNull.Value)
			{
				P012B009 = (int?)reader[68];
			}
			if(reader[69] != DBNull.Value)
			{
				P012B010 = (int?)reader[69];
			}
			if(reader[70] != DBNull.Value)
			{
				P012B011 = (int?)reader[70];
			}
			if(reader[71] != DBNull.Value)
			{
				P012B012 = (int?)reader[71];
			}
			if(reader[72] != DBNull.Value)
			{
				P012B013 = (int?)reader[72];
			}
			if(reader[73] != DBNull.Value)
			{
				P012B014 = (int?)reader[73];
			}
			if(reader[74] != DBNull.Value)
			{
				P012B015 = (int?)reader[74];
			}
			if(reader[75] != DBNull.Value)
			{
				P012B016 = (int?)reader[75];
			}
			if(reader[76] != DBNull.Value)
			{
				P012B017 = (int?)reader[76];
			}
			if(reader[77] != DBNull.Value)
			{
				P012B018 = (int?)reader[77];
			}
			if(reader[78] != DBNull.Value)
			{
				P012B019 = (int?)reader[78];
			}
			if(reader[79] != DBNull.Value)
			{
				P012B020 = (int?)reader[79];
			}
			if(reader[80] != DBNull.Value)
			{
				P012B021 = (int?)reader[80];
			}
			if(reader[81] != DBNull.Value)
			{
				P012B022 = (int?)reader[81];
			}
			if(reader[82] != DBNull.Value)
			{
				P012B023 = (int?)reader[82];
			}
			if(reader[83] != DBNull.Value)
			{
				P012B024 = (int?)reader[83];
			}
			if(reader[84] != DBNull.Value)
			{
				P012B025 = (int?)reader[84];
			}
			if(reader[85] != DBNull.Value)
			{
				P012B026 = (int?)reader[85];
			}
			if(reader[86] != DBNull.Value)
			{
				P012B027 = (int?)reader[86];
			}
			if(reader[87] != DBNull.Value)
			{
				P012B028 = (int?)reader[87];
			}
			if(reader[88] != DBNull.Value)
			{
				P012B029 = (int?)reader[88];
			}
			if(reader[89] != DBNull.Value)
			{
				P012B030 = (int?)reader[89];
			}
			if(reader[90] != DBNull.Value)
			{
				P012B031 = (int?)reader[90];
			}
			if(reader[91] != DBNull.Value)
			{
				P012B032 = (int?)reader[91];
			}
			if(reader[92] != DBNull.Value)
			{
				P012B033 = (int?)reader[92];
			}
			if(reader[93] != DBNull.Value)
			{
				P012B034 = (int?)reader[93];
			}
			if(reader[94] != DBNull.Value)
			{
				P012B035 = (int?)reader[94];
			}
			if(reader[95] != DBNull.Value)
			{
				P012B036 = (int?)reader[95];
			}
			if(reader[96] != DBNull.Value)
			{
				P012B037 = (int?)reader[96];
			}
			if(reader[97] != DBNull.Value)
			{
				P012B038 = (int?)reader[97];
			}
			if(reader[98] != DBNull.Value)
			{
				P012B039 = (int?)reader[98];
			}
			if(reader[99] != DBNull.Value)
			{
				P012B040 = (int?)reader[99];
			}
			if(reader[100] != DBNull.Value)
			{
				P012B041 = (int?)reader[100];
			}
			if(reader[101] != DBNull.Value)
			{
				P012B042 = (int?)reader[101];
			}
			if(reader[102] != DBNull.Value)
			{
				P012B043 = (int?)reader[102];
			}
			if(reader[103] != DBNull.Value)
			{
				P012B044 = (int?)reader[103];
			}
			if(reader[104] != DBNull.Value)
			{
				P012B045 = (int?)reader[104];
			}
			if(reader[105] != DBNull.Value)
			{
				P012B046 = (int?)reader[105];
			}
			if(reader[106] != DBNull.Value)
			{
				P012B047 = (int?)reader[106];
			}
			if(reader[107] != DBNull.Value)
			{
				P012B048 = (int?)reader[107];
			}
			if(reader[108] != DBNull.Value)
			{
				P012B049 = (int?)reader[108];
			}
			if(reader[109] != DBNull.Value)
			{
				P012C001 = (int?)reader[109];
			}
			if(reader[110] != DBNull.Value)
			{
				P012C002 = (int?)reader[110];
			}
			if(reader[111] != DBNull.Value)
			{
				P012C003 = (int?)reader[111];
			}
			if(reader[112] != DBNull.Value)
			{
				P012C004 = (int?)reader[112];
			}
			if(reader[113] != DBNull.Value)
			{
				P012C005 = (int?)reader[113];
			}
			if(reader[114] != DBNull.Value)
			{
				P012C006 = (int?)reader[114];
			}
			if(reader[115] != DBNull.Value)
			{
				P012C007 = (int?)reader[115];
			}
			if(reader[116] != DBNull.Value)
			{
				P012C008 = (int?)reader[116];
			}
			if(reader[117] != DBNull.Value)
			{
				P012C009 = (int?)reader[117];
			}
			if(reader[118] != DBNull.Value)
			{
				P012C010 = (int?)reader[118];
			}
			if(reader[119] != DBNull.Value)
			{
				P012C011 = (int?)reader[119];
			}
			if(reader[120] != DBNull.Value)
			{
				P012C012 = (int?)reader[120];
			}
			if(reader[121] != DBNull.Value)
			{
				P012C013 = (int?)reader[121];
			}
			if(reader[122] != DBNull.Value)
			{
				P012C014 = (int?)reader[122];
			}
			if(reader[123] != DBNull.Value)
			{
				P012C015 = (int?)reader[123];
			}
			if(reader[124] != DBNull.Value)
			{
				P012C016 = (int?)reader[124];
			}
			if(reader[125] != DBNull.Value)
			{
				P012C017 = (int?)reader[125];
			}
			if(reader[126] != DBNull.Value)
			{
				P012C018 = (int?)reader[126];
			}
			if(reader[127] != DBNull.Value)
			{
				P012C019 = (int?)reader[127];
			}
			if(reader[128] != DBNull.Value)
			{
				P012C020 = (int?)reader[128];
			}
			if(reader[129] != DBNull.Value)
			{
				P012C021 = (int?)reader[129];
			}
			if(reader[130] != DBNull.Value)
			{
				P012C022 = (int?)reader[130];
			}
			if(reader[131] != DBNull.Value)
			{
				P012C023 = (int?)reader[131];
			}
			if(reader[132] != DBNull.Value)
			{
				P012C024 = (int?)reader[132];
			}
			if(reader[133] != DBNull.Value)
			{
				P012C025 = (int?)reader[133];
			}
			if(reader[134] != DBNull.Value)
			{
				P012C026 = (int?)reader[134];
			}
			if(reader[135] != DBNull.Value)
			{
				P012C027 = (int?)reader[135];
			}
			if(reader[136] != DBNull.Value)
			{
				P012C028 = (int?)reader[136];
			}
			if(reader[137] != DBNull.Value)
			{
				P012C029 = (int?)reader[137];
			}
			if(reader[138] != DBNull.Value)
			{
				P012C030 = (int?)reader[138];
			}
			if(reader[139] != DBNull.Value)
			{
				P012C031 = (int?)reader[139];
			}
			if(reader[140] != DBNull.Value)
			{
				P012C032 = (int?)reader[140];
			}
			if(reader[141] != DBNull.Value)
			{
				P012C033 = (int?)reader[141];
			}
			if(reader[142] != DBNull.Value)
			{
				P012C034 = (int?)reader[142];
			}
			if(reader[143] != DBNull.Value)
			{
				P012C035 = (int?)reader[143];
			}
			if(reader[144] != DBNull.Value)
			{
				P012C036 = (int?)reader[144];
			}
			if(reader[145] != DBNull.Value)
			{
				P012C037 = (int?)reader[145];
			}
			if(reader[146] != DBNull.Value)
			{
				P012C038 = (int?)reader[146];
			}
			if(reader[147] != DBNull.Value)
			{
				P012C039 = (int?)reader[147];
			}
			if(reader[148] != DBNull.Value)
			{
				P012C040 = (int?)reader[148];
			}
			if(reader[149] != DBNull.Value)
			{
				P012C041 = (int?)reader[149];
			}
			if(reader[150] != DBNull.Value)
			{
				P012C042 = (int?)reader[150];
			}
			if(reader[151] != DBNull.Value)
			{
				P012C043 = (int?)reader[151];
			}
			if(reader[152] != DBNull.Value)
			{
				P012C044 = (int?)reader[152];
			}
			if(reader[153] != DBNull.Value)
			{
				P012C045 = (int?)reader[153];
			}
			if(reader[154] != DBNull.Value)
			{
				P012C046 = (int?)reader[154];
			}
			if(reader[155] != DBNull.Value)
			{
				P012C047 = (int?)reader[155];
			}
			if(reader[156] != DBNull.Value)
			{
				P012C048 = (int?)reader[156];
			}
			if(reader[157] != DBNull.Value)
			{
				P012C049 = (int?)reader[157];
			}
			if(reader[158] != DBNull.Value)
			{
				P012D001 = (int?)reader[158];
			}
			if(reader[159] != DBNull.Value)
			{
				P012D002 = (int?)reader[159];
			}
			if(reader[160] != DBNull.Value)
			{
				P012D003 = (int?)reader[160];
			}
			if(reader[161] != DBNull.Value)
			{
				P012D004 = (int?)reader[161];
			}
			if(reader[162] != DBNull.Value)
			{
				P012D005 = (int?)reader[162];
			}
			if(reader[163] != DBNull.Value)
			{
				P012D006 = (int?)reader[163];
			}
			if(reader[164] != DBNull.Value)
			{
				P012D007 = (int?)reader[164];
			}
			if(reader[165] != DBNull.Value)
			{
				P012D008 = (int?)reader[165];
			}
			if(reader[166] != DBNull.Value)
			{
				P012D009 = (int?)reader[166];
			}
			if(reader[167] != DBNull.Value)
			{
				P012D010 = (int?)reader[167];
			}
			if(reader[168] != DBNull.Value)
			{
				P012D011 = (int?)reader[168];
			}
			if(reader[169] != DBNull.Value)
			{
				P012D012 = (int?)reader[169];
			}
			if(reader[170] != DBNull.Value)
			{
				P012D013 = (int?)reader[170];
			}
			if(reader[171] != DBNull.Value)
			{
				P012D014 = (int?)reader[171];
			}
			if(reader[172] != DBNull.Value)
			{
				P012D015 = (int?)reader[172];
			}
			if(reader[173] != DBNull.Value)
			{
				P012D016 = (int?)reader[173];
			}
			if(reader[174] != DBNull.Value)
			{
				P012D017 = (int?)reader[174];
			}
			if(reader[175] != DBNull.Value)
			{
				P012D018 = (int?)reader[175];
			}
			if(reader[176] != DBNull.Value)
			{
				P012D019 = (int?)reader[176];
			}
			if(reader[177] != DBNull.Value)
			{
				P012D020 = (int?)reader[177];
			}
			if(reader[178] != DBNull.Value)
			{
				P012D021 = (int?)reader[178];
			}
			if(reader[179] != DBNull.Value)
			{
				P012D022 = (int?)reader[179];
			}
			if(reader[180] != DBNull.Value)
			{
				P012D023 = (int?)reader[180];
			}
			if(reader[181] != DBNull.Value)
			{
				P012D024 = (int?)reader[181];
			}
			if(reader[182] != DBNull.Value)
			{
				P012D025 = (int?)reader[182];
			}
			if(reader[183] != DBNull.Value)
			{
				P012D026 = (int?)reader[183];
			}
			if(reader[184] != DBNull.Value)
			{
				P012D027 = (int?)reader[184];
			}
			if(reader[185] != DBNull.Value)
			{
				P012D028 = (int?)reader[185];
			}
			if(reader[186] != DBNull.Value)
			{
				P012D029 = (int?)reader[186];
			}
			if(reader[187] != DBNull.Value)
			{
				P012D030 = (int?)reader[187];
			}
			if(reader[188] != DBNull.Value)
			{
				P012D031 = (int?)reader[188];
			}
			if(reader[189] != DBNull.Value)
			{
				P012D032 = (int?)reader[189];
			}
			if(reader[190] != DBNull.Value)
			{
				P012D033 = (int?)reader[190];
			}
			if(reader[191] != DBNull.Value)
			{
				P012D034 = (int?)reader[191];
			}
			if(reader[192] != DBNull.Value)
			{
				P012D035 = (int?)reader[192];
			}
			if(reader[193] != DBNull.Value)
			{
				P012D036 = (int?)reader[193];
			}
			if(reader[194] != DBNull.Value)
			{
				P012D037 = (int?)reader[194];
			}
			if(reader[195] != DBNull.Value)
			{
				P012D038 = (int?)reader[195];
			}
			if(reader[196] != DBNull.Value)
			{
				P012D039 = (int?)reader[196];
			}
			if(reader[197] != DBNull.Value)
			{
				P012D040 = (int?)reader[197];
			}
			if(reader[198] != DBNull.Value)
			{
				P012D041 = (int?)reader[198];
			}
			if(reader[199] != DBNull.Value)
			{
				P012D042 = (int?)reader[199];
			}
			if(reader[200] != DBNull.Value)
			{
				P012D043 = (int?)reader[200];
			}
			if(reader[201] != DBNull.Value)
			{
				P012D044 = (int?)reader[201];
			}
			if(reader[202] != DBNull.Value)
			{
				P012D045 = (int?)reader[202];
			}
			if(reader[203] != DBNull.Value)
			{
				P012D046 = (int?)reader[203];
			}
			if(reader[204] != DBNull.Value)
			{
				P012D047 = (int?)reader[204];
			}
			if(reader[205] != DBNull.Value)
			{
				P012D048 = (int?)reader[205];
			}
			if(reader[206] != DBNull.Value)
			{
				P012D049 = (int?)reader[206];
			}
			if(reader[207] != DBNull.Value)
			{
				P012E001 = (int?)reader[207];
			}
			if(reader[208] != DBNull.Value)
			{
				P012E002 = (int?)reader[208];
			}
			if(reader[209] != DBNull.Value)
			{
				P012E003 = (int?)reader[209];
			}
			if(reader[210] != DBNull.Value)
			{
				P012E004 = (int?)reader[210];
			}
			if(reader[211] != DBNull.Value)
			{
				P012E005 = (int?)reader[211];
			}
			if(reader[212] != DBNull.Value)
			{
				P012E006 = (int?)reader[212];
			}
			if(reader[213] != DBNull.Value)
			{
				P012E007 = (int?)reader[213];
			}
			if(reader[214] != DBNull.Value)
			{
				P012E008 = (int?)reader[214];
			}
			if(reader[215] != DBNull.Value)
			{
				P012E009 = (int?)reader[215];
			}
			if(reader[216] != DBNull.Value)
			{
				P012E010 = (int?)reader[216];
			}
			if(reader[217] != DBNull.Value)
			{
				P012E011 = (int?)reader[217];
			}
			if(reader[218] != DBNull.Value)
			{
				P012E012 = (int?)reader[218];
			}
			if(reader[219] != DBNull.Value)
			{
				P012E013 = (int?)reader[219];
			}
			if(reader[220] != DBNull.Value)
			{
				P012E014 = (int?)reader[220];
			}
			if(reader[221] != DBNull.Value)
			{
				P012E015 = (int?)reader[221];
			}
			if(reader[222] != DBNull.Value)
			{
				P012E016 = (int?)reader[222];
			}
			if(reader[223] != DBNull.Value)
			{
				P012E017 = (int?)reader[223];
			}
			if(reader[224] != DBNull.Value)
			{
				P012E018 = (int?)reader[224];
			}
			if(reader[225] != DBNull.Value)
			{
				P012E019 = (int?)reader[225];
			}
			if(reader[226] != DBNull.Value)
			{
				P012E020 = (int?)reader[226];
			}
			if(reader[227] != DBNull.Value)
			{
				P012E021 = (int?)reader[227];
			}
			if(reader[228] != DBNull.Value)
			{
				P012E022 = (int?)reader[228];
			}
			if(reader[229] != DBNull.Value)
			{
				P012E023 = (int?)reader[229];
			}
			if(reader[230] != DBNull.Value)
			{
				P012E024 = (int?)reader[230];
			}
			if(reader[231] != DBNull.Value)
			{
				P012E025 = (int?)reader[231];
			}
			if(reader[232] != DBNull.Value)
			{
				P012E026 = (int?)reader[232];
			}
			if(reader[233] != DBNull.Value)
			{
				P012E027 = (int?)reader[233];
			}
			if(reader[234] != DBNull.Value)
			{
				P012E028 = (int?)reader[234];
			}
			if(reader[235] != DBNull.Value)
			{
				P012E029 = (int?)reader[235];
			}
			if(reader[236] != DBNull.Value)
			{
				P012E030 = (int?)reader[236];
			}
			if(reader[237] != DBNull.Value)
			{
				P012E031 = (int?)reader[237];
			}
			if(reader[238] != DBNull.Value)
			{
				P012E032 = (int?)reader[238];
			}
			if(reader[239] != DBNull.Value)
			{
				P012E033 = (int?)reader[239];
			}
			if(reader[240] != DBNull.Value)
			{
				P012E034 = (int?)reader[240];
			}
			if(reader[241] != DBNull.Value)
			{
				P012E035 = (int?)reader[241];
			}
			if(reader[242] != DBNull.Value)
			{
				P012E036 = (int?)reader[242];
			}
			if(reader[243] != DBNull.Value)
			{
				P012E037 = (int?)reader[243];
			}
			if(reader[244] != DBNull.Value)
			{
				P012E038 = (int?)reader[244];
			}
			if(reader[245] != DBNull.Value)
			{
				P012E039 = (int?)reader[245];
			}
			if(reader[246] != DBNull.Value)
			{
				P012E040 = (int?)reader[246];
			}
			if(reader[247] != DBNull.Value)
			{
				P012E041 = (int?)reader[247];
			}
			if(reader[248] != DBNull.Value)
			{
				P012E042 = (int?)reader[248];
			}
			if(reader[249] != DBNull.Value)
			{
				P012E043 = (int?)reader[249];
			}
			if(reader[250] != DBNull.Value)
			{
				P012E044 = (int?)reader[250];
			}
			if(reader[251] != DBNull.Value)
			{
				P012E045 = (int?)reader[251];
			}
			if(reader[252] != DBNull.Value)
			{
				P012E046 = (int?)reader[252];
			}
			if(reader[253] != DBNull.Value)
			{
				P012E047 = (int?)reader[253];
			}
			if(reader[254] != DBNull.Value)
			{
				P012E048 = (int?)reader[254];
			}
			if(reader[255] != DBNull.Value)
			{
				P012E049 = (int?)reader[255];
			}
		}
		#endregion Constructors
	}
}
