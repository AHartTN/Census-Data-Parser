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

	public class SF1CongressionalDistricts113_SF1_00015 : BaseModel
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

		[Display(Name = "Total tribes tallied (300, A01-M38, M41-R98, S01-Z99):", ShortName = "Total tribes tallied (300, A01-M38, M41-R98, S01-Z99):", Order = 5)]
		public int? PCT0010001 { get; set; }

		[Display(Name = "American Indian tribes, specified (A01-M38, T01-Z99):", ShortName = "American Indian tribes, specified (A01-M38, T01-Z99):", Order = 6)]
		public int? PCT0010002 { get; set; }

		[Display(Name = "Apache (A09-A23)", ShortName = "Apache (A09-A23)", Order = 7)]
		public int? PCT0010003 { get; set; }

		[Display(Name = "Arapaho (A24-A33)", ShortName = "Arapaho (A24-A33)", Order = 8)]
		public int? PCT0010004 { get; set; }

		[Display(Name = "Blackfeet (A45-A50)", ShortName = "Blackfeet (A45-A50)", Order = 9)]
		public int? PCT0010005 { get; set; }

		[Display(Name = "Canadian and French American Indian (T01-V23)", ShortName = "Canadian and French American Indian (T01-V23)", Order = 10)]
		public int? PCT0010006 { get; set; }

		[Display(Name = "Central American Indian (V24-V83)", ShortName = "Central American Indian (V24-V83)", Order = 11)]
		public int? PCT0010007 { get; set; }

		[Display(Name = "Cherokee (B21-B39)", ShortName = "Cherokee (B21-B39)", Order = 12)]
		public int? PCT0010008 { get; set; }

		[Display(Name = "Cheyenne (B40-B45)", ShortName = "Cheyenne (B40-B45)", Order = 13)]
		public int? PCT0010009 { get; set; }

		[Display(Name = "Chickasaw (B53-B56)", ShortName = "Chickasaw (B53-B56)", Order = 14)]
		public int? PCT0010010 { get; set; }

		[Display(Name = "Chippewa (B67-B99)", ShortName = "Chippewa (B67-B99)", Order = 15)]
		public int? PCT0010011 { get; set; }

		[Display(Name = "Choctaw (C08-C16)", ShortName = "Choctaw (C08-C16)", Order = 16)]
		public int? PCT0010012 { get; set; }

		[Display(Name = "Colville (C35-C38)", ShortName = "Colville (C35-C38)", Order = 17)]
		public int? PCT0010013 { get; set; }

		[Display(Name = "Comanche (C39-C43)", ShortName = "Comanche (C39-C43)", Order = 18)]
		public int? PCT0010014 { get; set; }

		[Display(Name = "Cree (C59-C63)", ShortName = "Cree (C59-C63)", Order = 19)]
		public int? PCT0010015 { get; set; }

		[Display(Name = "Creek (C64-C80)", ShortName = "Creek (C64-C80)", Order = 20)]
		public int? PCT0010016 { get; set; }

		[Display(Name = "Crow (C83-C86)", ShortName = "Crow (C83-C86)", Order = 21)]
		public int? PCT0010017 { get; set; }

		[Display(Name = "Delaware (C93-D04)", ShortName = "Delaware (C93-D04)", Order = 22)]
		public int? PCT0010018 { get; set; }

		[Display(Name = "Hopi (D74-D75)", ShortName = "Hopi (D74-D75)", Order = 23)]
		public int? PCT0010019 { get; set; }

		[Display(Name = "Houma (D78-D86)", ShortName = "Houma (D78-D86)", Order = 24)]
		public int? PCT0010020 { get; set; }

		[Display(Name = "Iroquois (D93-E09)", ShortName = "Iroquois (D93-E09)", Order = 25)]
		public int? PCT0010021 { get; set; }

		[Display(Name = "Kiowa (E30-E36)", ShortName = "Kiowa (E30-E36)", Order = 26)]
		public int? PCT0010022 { get; set; }

		[Display(Name = "Lumbee (E78-E83)", ShortName = "Lumbee (E78-E83)", Order = 27)]
		public int? PCT0010023 { get; set; }

		[Display(Name = "Menominee (F11-F14)", ShortName = "Menominee (F11-F14)", Order = 28)]
		public int? PCT0010024 { get; set; }

		[Display(Name = "Mexican American Indian (V84-W66)", ShortName = "Mexican American Indian (V84-W66)", Order = 29)]
		public int? PCT0010025 { get; set; }

		[Display(Name = "Navajo  (F62-F70)", ShortName = "Navajo  (F62-F70)", Order = 30)]
		public int? PCT0010026 { get; set; }

		[Display(Name = "Osage (G04-G09)", ShortName = "Osage (G04-G09)", Order = 31)]
		public int? PCT0010027 { get; set; }

		[Display(Name = "Ottawa (G14-G22)", ShortName = "Ottawa (G14-G22)", Order = 32)]
		public int? PCT0010028 { get; set; }

		[Display(Name = "Paiute (G23-G49)", ShortName = "Paiute (G23-G49)", Order = 33)]
		public int? PCT0010029 { get; set; }

		[Display(Name = "Pima (G84-G91)", ShortName = "Pima (G84-G91)", Order = 34)]
		public int? PCT0010030 { get; set; }

		[Display(Name = "Potawatomi (H21-H33)", ShortName = "Potawatomi (H21-H33)", Order = 35)]
		public int? PCT0010031 { get; set; }

		[Display(Name = "Pueblo (H38-H65)", ShortName = "Pueblo (H38-H65)", Order = 36)]
		public int? PCT0010032 { get; set; }

		[Display(Name = "Puget Sound Salish (H70-H92)", ShortName = "Puget Sound Salish (H70-H92)", Order = 37)]
		public int? PCT0010033 { get; set; }

		[Display(Name = "Seminole (J47-J57)", ShortName = "Seminole (J47-J57)", Order = 38)]
		public int? PCT0010034 { get; set; }

		[Display(Name = "Shoshone (J81-J92)", ShortName = "Shoshone (J81-J92)", Order = 39)]
		public int? PCT0010035 { get; set; }

		[Display(Name = "Sioux (K16-K53)", ShortName = "Sioux (K16-K53)", Order = 40)]
		public int? PCT0010036 { get; set; }

		[Display(Name = "South American Indian (W67-X24)", ShortName = "South American Indian (W67-X24)", Order = 41)]
		public int? PCT0010037 { get; set; }

		[Display(Name = "Spanish American Indian (X25-Z99)", ShortName = "Spanish American Indian (X25-Z99)", Order = 42)]
		public int? PCT0010038 { get; set; }

		[Display(Name = "Tohono O’Odham (K78-K86)", ShortName = "Tohono O’Odham (K78-K86)", Order = 43)]
		public int? PCT0010039 { get; set; }

		[Display(Name = "Ute (L06-L14)", ShortName = "Ute (L06-L14)", Order = 44)]
		public int? PCT0010040 { get; set; }

		[Display(Name = "Yakama (L79-L84)", ShortName = "Yakama (L79-L84)", Order = 45)]
		public int? PCT0010041 { get; set; }

		[Display(Name = "Yaqui (L91-L99)", ShortName = "Yaqui (L91-L99)", Order = 46)]
		public int? PCT0010042 { get; set; }

		[Display(Name = "Yuman (M22-M33)", ShortName = "Yuman (M22-M33)", Order = 47)]
		public int? PCT0010043 { get; set; }

		[Display(Name = "All other American Indian tribes (please see technical documentation for codes at http://www.census.gov/prod/cen2010/doc/sf1.pdf, Appendix F)", ShortName = "All other American Indian tribes (please see technical documentation for codes at http://www.census.gov/prod/cen2010/doc/sf1.pdf, Appendix F)", Order = 48)]
		public int? PCT0010044 { get; set; }

		[Display(Name = "American Indian tribes, not specified (M41-M43)", ShortName = "American Indian tribes, not specified (M41-M43)", Order = 49)]
		public int? PCT0010045 { get; set; }

		[Display(Name = "Alaska Native tribes, specified (M52-R98, S01-S99):", ShortName = "Alaska Native tribes, specified (M52-R98, S01-S99):", Order = 50)]
		public int? PCT0010046 { get; set; }

		[Display(Name = "Alaskan Athabascan (M52-N27)", ShortName = "Alaskan Athabascan (M52-N27)", Order = 51)]
		public int? PCT0010047 { get; set; }

		[Display(Name = "Aleut (R11-R98, S01-S99)", ShortName = "Aleut (R11-R98, S01-S99)", Order = 52)]
		public int? PCT0010048 { get; set; }

		[Display(Name = "Inupiat (N67-P29, P33-P37)", ShortName = "Inupiat (N67-P29, P33-P37)", Order = 53)]
		public int? PCT0010049 { get; set; }

		[Display(Name = "Tlingit-Haida (N28-N55, N59-N66)", ShortName = "Tlingit-Haida (N28-N55, N59-N66)", Order = 54)]
		public int? PCT0010050 { get; set; }

		[Display(Name = "Tsimshian (N56-N58)", ShortName = "Tsimshian (N56-N58)", Order = 55)]
		public int? PCT0010051 { get; set; }

		[Display(Name = "Yup'ik (P30-P32, P38-R10)", ShortName = "Yup'ik (P30-P32, P38-R10)", Order = 56)]
		public int? PCT0010052 { get; set; }

		[Display(Name = "Alaska Native tribes, not specified (M44-M51)", ShortName = "Alaska Native tribes, not specified (M44-M51)", Order = 57)]
		public int? PCT0010053 { get; set; }

		[Display(Name = "American Indian or Alaska Native tribes, not specified (300)", ShortName = "American Indian or Alaska Native tribes, not specified (300)", Order = 58)]
		public int? PCT0010054 { get; set; }

		[Display(Name = "Total tribes tallied (300, A01-Z99) & (300, A01-Z99):", ShortName = "Total tribes tallied (300, A01-Z99) & (300, A01-Z99):", Order = 59)]
		public int? PCT0020001 { get; set; }

		[Display(Name = "American Indian tribes, specified (A01-M38, T01-Z99) & (300, A01-Z99):", ShortName = "American Indian tribes, specified (A01-M38, T01-Z99) & (300, A01-Z99):", Order = 60)]
		public int? PCT0020002 { get; set; }

		[Display(Name = "Apache (A09-A23) & (300, A01-Z99)", ShortName = "Apache (A09-A23) & (300, A01-Z99)", Order = 61)]
		public int? PCT0020003 { get; set; }

		[Display(Name = "Arapaho (A24-A33) & (300, A01-Z99)", ShortName = "Arapaho (A24-A33) & (300, A01-Z99)", Order = 62)]
		public int? PCT0020004 { get; set; }

		[Display(Name = "Blackfeet (A45-A50) & (300, A01-Z99)", ShortName = "Blackfeet (A45-A50) & (300, A01-Z99)", Order = 63)]
		public int? PCT0020005 { get; set; }

		[Display(Name = "Canadian and French American Indian (T01-V23) & (300, A01-Z99)", ShortName = "Canadian and French American Indian (T01-V23) & (300, A01-Z99)", Order = 64)]
		public int? PCT0020006 { get; set; }

		[Display(Name = "Central American Indian (V24-V83) & (300, A01-Z99)", ShortName = "Central American Indian (V24-V83) & (300, A01-Z99)", Order = 65)]
		public int? PCT0020007 { get; set; }

		[Display(Name = "Cherokee (B21-B39) & (300, A01-Z99)", ShortName = "Cherokee (B21-B39) & (300, A01-Z99)", Order = 66)]
		public int? PCT0020008 { get; set; }

		[Display(Name = "Cheyenne (B40-B45) & (300, A01-Z99)", ShortName = "Cheyenne (B40-B45) & (300, A01-Z99)", Order = 67)]
		public int? PCT0020009 { get; set; }

		[Display(Name = "Chickasaw (B53-B56) & (300, A01-Z99)", ShortName = "Chickasaw (B53-B56) & (300, A01-Z99)", Order = 68)]
		public int? PCT0020010 { get; set; }

		[Display(Name = "Chippewa (B67-B99) & (300, A01-Z99)", ShortName = "Chippewa (B67-B99) & (300, A01-Z99)", Order = 69)]
		public int? PCT0020011 { get; set; }

		[Display(Name = "Choctaw (C08-C16) & (300, A01-Z99)", ShortName = "Choctaw (C08-C16) & (300, A01-Z99)", Order = 70)]
		public int? PCT0020012 { get; set; }

		[Display(Name = "Colville (C35-C38) & (300, A01-Z99)", ShortName = "Colville (C35-C38) & (300, A01-Z99)", Order = 71)]
		public int? PCT0020013 { get; set; }

		[Display(Name = "Comanche (C39-C43) & (300, A01-Z99)", ShortName = "Comanche (C39-C43) & (300, A01-Z99)", Order = 72)]
		public int? PCT0020014 { get; set; }

		[Display(Name = "Cree (C59-C63) & (300, A01-Z99)", ShortName = "Cree (C59-C63) & (300, A01-Z99)", Order = 73)]
		public int? PCT0020015 { get; set; }

		[Display(Name = "Creek (C64-C80) & (300, A01-Z99)", ShortName = "Creek (C64-C80) & (300, A01-Z99)", Order = 74)]
		public int? PCT0020016 { get; set; }

		[Display(Name = "Crow (C83-C86) & (300, A01-Z99)", ShortName = "Crow (C83-C86) & (300, A01-Z99)", Order = 75)]
		public int? PCT0020017 { get; set; }

		[Display(Name = "Delaware (C93-D04) & (300, A01-Z99)", ShortName = "Delaware (C93-D04) & (300, A01-Z99)", Order = 76)]
		public int? PCT0020018 { get; set; }

		[Display(Name = "Hopi (D74-D75) & (300, A01-Z99)", ShortName = "Hopi (D74-D75) & (300, A01-Z99)", Order = 77)]
		public int? PCT0020019 { get; set; }

		[Display(Name = "Houma (D78-D86) & (300, A01-Z99)", ShortName = "Houma (D78-D86) & (300, A01-Z99)", Order = 78)]
		public int? PCT0020020 { get; set; }

		[Display(Name = "Iroquois (D93-E09) & (300, A01-Z99)", ShortName = "Iroquois (D93-E09) & (300, A01-Z99)", Order = 79)]
		public int? PCT0020021 { get; set; }

		[Display(Name = "Kiowa (E30-E36) & (300, A01-Z99)", ShortName = "Kiowa (E30-E36) & (300, A01-Z99)", Order = 80)]
		public int? PCT0020022 { get; set; }

		[Display(Name = "Lumbee (E78-E83) & (300, A01-Z99)", ShortName = "Lumbee (E78-E83) & (300, A01-Z99)", Order = 81)]
		public int? PCT0020023 { get; set; }

		[Display(Name = "Menominee (F11-F14) & (300, A01-Z99)", ShortName = "Menominee (F11-F14) & (300, A01-Z99)", Order = 82)]
		public int? PCT0020024 { get; set; }

		[Display(Name = "Mexican American Indian (V84-W66) & (300, A01-Z99)", ShortName = "Mexican American Indian (V84-W66) & (300, A01-Z99)", Order = 83)]
		public int? PCT0020025 { get; set; }

		[Display(Name = "Navajo  (F62-F70) & (300, A01-Z99)", ShortName = "Navajo  (F62-F70) & (300, A01-Z99)", Order = 84)]
		public int? PCT0020026 { get; set; }

		[Display(Name = "Osage (G04-G09) & (300, A01-Z99)", ShortName = "Osage (G04-G09) & (300, A01-Z99)", Order = 85)]
		public int? PCT0020027 { get; set; }

		[Display(Name = "Ottawa (G14-G22) & (300, A01-Z99)", ShortName = "Ottawa (G14-G22) & (300, A01-Z99)", Order = 86)]
		public int? PCT0020028 { get; set; }

		[Display(Name = "Paiute (G23-G49) & (300, A01-Z99)", ShortName = "Paiute (G23-G49) & (300, A01-Z99)", Order = 87)]
		public int? PCT0020029 { get; set; }

		[Display(Name = "Pima (G84-G91) & (300, A01-Z99)", ShortName = "Pima (G84-G91) & (300, A01-Z99)", Order = 88)]
		public int? PCT0020030 { get; set; }

		[Display(Name = "Potawatomi (H21-H33) & (300, A01-Z99)", ShortName = "Potawatomi (H21-H33) & (300, A01-Z99)", Order = 89)]
		public int? PCT0020031 { get; set; }

		[Display(Name = "Pueblo (H38-H65) & (300, A01-Z99)", ShortName = "Pueblo (H38-H65) & (300, A01-Z99)", Order = 90)]
		public int? PCT0020032 { get; set; }

		[Display(Name = "Puget Sound Salish (H70-H92) & (300, A01-Z99)", ShortName = "Puget Sound Salish (H70-H92) & (300, A01-Z99)", Order = 91)]
		public int? PCT0020033 { get; set; }

		[Display(Name = "Seminole (J47-J57) & (300, A01-Z99)", ShortName = "Seminole (J47-J57) & (300, A01-Z99)", Order = 92)]
		public int? PCT0020034 { get; set; }

		[Display(Name = "Shoshone  (J81-J92) & (300, A01-Z99)", ShortName = "Shoshone  (J81-J92) & (300, A01-Z99)", Order = 93)]
		public int? PCT0020035 { get; set; }

		[Display(Name = "Sioux (K16-K53) & (300, A01-Z99)", ShortName = "Sioux (K16-K53) & (300, A01-Z99)", Order = 94)]
		public int? PCT0020036 { get; set; }

		[Display(Name = "South American Indian (W67-X24) & (300, A01-Z99)", ShortName = "South American Indian (W67-X24) & (300, A01-Z99)", Order = 95)]
		public int? PCT0020037 { get; set; }

		[Display(Name = "Spanish American Indian (X25-Z99) & (300, A01-Z99)", ShortName = "Spanish American Indian (X25-Z99) & (300, A01-Z99)", Order = 96)]
		public int? PCT0020038 { get; set; }

		[Display(Name = "Tohono O’Odham (K78-K86) & (300, A01-Z99)", ShortName = "Tohono O’Odham (K78-K86) & (300, A01-Z99)", Order = 97)]
		public int? PCT0020039 { get; set; }

		[Display(Name = "Ute (L06-L14) & (300, A01-Z99)", ShortName = "Ute (L06-L14) & (300, A01-Z99)", Order = 98)]
		public int? PCT0020040 { get; set; }

		[Display(Name = "Yakama (L79-L84) & (300, A01-Z99)", ShortName = "Yakama (L79-L84) & (300, A01-Z99)", Order = 99)]
		public int? PCT0020041 { get; set; }

		[Display(Name = "Yaqui (L91-L99) & (300, A01-Z99)", ShortName = "Yaqui (L91-L99) & (300, A01-Z99)", Order = 100)]
		public int? PCT0020042 { get; set; }

		[Display(Name = "Yuman (M22-M33) & (300, A01-Z99)", ShortName = "Yuman (M22-M33) & (300, A01-Z99)", Order = 101)]
		public int? PCT0020043 { get; set; }

		[Display(Name = "All other American Indian tribes  (please see technical documentation for codes at http://www.census.gov/prod/cen2010/doc/sf1.pdf, Appendix F)", ShortName = "All other American Indian tribes  (please see technical documentation for codes at http://www.census.gov/prod/cen2010/doc/sf1.pdf, Appendix F)", Order = 102)]
		public int? PCT0020044 { get; set; }

		[Display(Name = "American Indian tribes, not specified (M41-M43) & (300, A01-Z99)", ShortName = "American Indian tribes, not specified (M41-M43) & (300, A01-Z99)", Order = 103)]
		public int? PCT0020045 { get; set; }

		[Display(Name = "Alaska Native tribes, specified (M52-R98, S01-S99) & (300, A01-Z99):", ShortName = "Alaska Native tribes, specified (M52-R98, S01-S99) & (300, A01-Z99):", Order = 104)]
		public int? PCT0020046 { get; set; }

		[Display(Name = "Alaskan Athabascan (M52-N27) & (300, A01-Z99)", ShortName = "Alaskan Athabascan (M52-N27) & (300, A01-Z99)", Order = 105)]
		public int? PCT0020047 { get; set; }

		[Display(Name = "Aleut (R11-R98, S01-S99) & (300, A01-Z99)", ShortName = "Aleut (R11-R98, S01-S99) & (300, A01-Z99)", Order = 106)]
		public int? PCT0020048 { get; set; }

		[Display(Name = "Inupiat (N67-P29, P33-P37) & (300, A01-Z99)", ShortName = "Inupiat (N67-P29, P33-P37) & (300, A01-Z99)", Order = 107)]
		public int? PCT0020049 { get; set; }

		[Display(Name = "Tlingit-Haida (N28-N55, N59-N66) & (300, A01-Z99)", ShortName = "Tlingit-Haida (N28-N55, N59-N66) & (300, A01-Z99)", Order = 108)]
		public int? PCT0020050 { get; set; }

		[Display(Name = "Tsimshian (N56-N58) & (300, A01-Z99)", ShortName = "Tsimshian (N56-N58) & (300, A01-Z99)", Order = 109)]
		public int? PCT0020051 { get; set; }

		[Display(Name = "Yup'ik (P30-P32, P38-R10) & (300, A01-Z99)", ShortName = "Yup'ik (P30-P32, P38-R10) & (300, A01-Z99)", Order = 110)]
		public int? PCT0020052 { get; set; }

		[Display(Name = "Alaska Native tribes, not specified (M44-M51) & (300, A01-Z99)", ShortName = "Alaska Native tribes, not specified (M44-M51) & (300, A01-Z99)", Order = 111)]
		public int? PCT0020053 { get; set; }

		[Display(Name = "American Indian or Alaska Native tribes, not specified (300)", ShortName = "American Indian or Alaska Native tribes, not specified (300)", Order = 112)]
		public int? PCT0020054 { get; set; }

		[Display(Name = "Total tribes tallied (300, A01-Z99) & (100-299) or (300, A01-Z99)  or (400-999):", ShortName = "Total tribes tallied (300, A01-Z99) & (100-299) or (300, A01-Z99)  or (400-999):", Order = 113)]
		public int? PCT0030001 { get; set; }

		[Display(Name = "American Indian tribes, specified (A01-M38, T01-Z99) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "American Indian tribes, specified (A01-M38, T01-Z99) & (100-299) or (300, A01-Z99) or (400-999):", Order = 114)]
		public int? PCT0030002 { get; set; }

		[Display(Name = "Apache (A09-A23) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Apache (A09-A23) & (100-299) or (300, A01-Z99) or (400-999)", Order = 115)]
		public int? PCT0030003 { get; set; }

		[Display(Name = "Arapaho (A24-A33) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Arapaho (A24-A33) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 116)]
		public int? PCT0030004 { get; set; }

		[Display(Name = "Blackfeet (A45-A50) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Blackfeet (A45-A50) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 117)]
		public int? PCT0030005 { get; set; }

		[Display(Name = "Canadian and French American Indian (T01-V23) &  (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Canadian and French American Indian (T01-V23) &  (100-299) or (300, A01-Z99) or (400-999)", Order = 118)]
		public int? PCT0030006 { get; set; }

		[Display(Name = "Central American Indian (V24-V83) & (100-299) or  (300, A01-Z99) or (400-999)", ShortName = "Central American Indian (V24-V83) & (100-299) or  (300, A01-Z99) or (400-999)", Order = 119)]
		public int? PCT0030007 { get; set; }

		[Display(Name = "Cherokee (B21-B39) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Cherokee (B21-B39) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 120)]
		public int? PCT0030008 { get; set; }

		[Display(Name = "Cheyenne (B40-B45) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Cheyenne (B40-B45) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 121)]
		public int? PCT0030009 { get; set; }

		[Display(Name = "Chickasaw (B53-B56) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Chickasaw (B53-B56) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 122)]
		public int? PCT0030010 { get; set; }

		[Display(Name = "Chippewa (B67-B99) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Chippewa (B67-B99) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 123)]
		public int? PCT0030011 { get; set; }

		[Display(Name = "Choctaw (C08-C16) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Choctaw (C08-C16) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 124)]
		public int? PCT0030012 { get; set; }

		[Display(Name = "Colville (C35-C38) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Colville (C35-C38) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 125)]
		public int? PCT0030013 { get; set; }

		[Display(Name = "Comanche (C39-C43) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Comanche (C39-C43) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 126)]
		public int? PCT0030014 { get; set; }

		[Display(Name = "Cree (C59-C63) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Cree (C59-C63) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 127)]
		public int? PCT0030015 { get; set; }

		[Display(Name = "Creek (C64-C80) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Creek (C64-C80) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 128)]
		public int? PCT0030016 { get; set; }

		[Display(Name = "Crow (C83-C86) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Crow (C83-C86) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 129)]
		public int? PCT0030017 { get; set; }

		[Display(Name = "Delaware (C93-D04) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Delaware (C93-D04) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 130)]
		public int? PCT0030018 { get; set; }

		[Display(Name = "Hopi (D74-D75) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Hopi (D74-D75) & (100-299) or (300, A01-Z99) or (400-999)", Order = 131)]
		public int? PCT0030019 { get; set; }

		[Display(Name = "Houma (D78-D86) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Houma (D78-D86) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 132)]
		public int? PCT0030020 { get; set; }

		[Display(Name = "Iroquois (D93-E09) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Iroquois (D93-E09) & (100-299) or (300, A01-Z99) or (400-999)", Order = 133)]
		public int? PCT0030021 { get; set; }

		[Display(Name = "Kiowa (E30-E36) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Kiowa (E30-E36) & (100-299) or (300, A01-Z99) or (400-999)", Order = 134)]
		public int? PCT0030022 { get; set; }

		[Display(Name = "Lumbee (E78-E83) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Lumbee (E78-E83) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 135)]
		public int? PCT0030023 { get; set; }

		[Display(Name = "Menominee (F11-F14) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Menominee (F11-F14) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 136)]
		public int? PCT0030024 { get; set; }

		[Display(Name = "Mexican American Indian (V84-W66) & (100-299) or  (300, A01-Z99) or (400-999)", ShortName = "Mexican American Indian (V84-W66) & (100-299) or  (300, A01-Z99) or (400-999)", Order = 137)]
		public int? PCT0030025 { get; set; }

		[Display(Name = "Navajo  (F62-F70) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Navajo  (F62-F70) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 138)]
		public int? PCT0030026 { get; set; }

		[Display(Name = "Osage (G04-G09) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Osage (G04-G09) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 139)]
		public int? PCT0030027 { get; set; }

		[Display(Name = "Ottawa (G14-G22) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Ottawa (G14-G22) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 140)]
		public int? PCT0030028 { get; set; }

		[Display(Name = "Paiute (G23-G49) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Paiute (G23-G49) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 141)]
		public int? PCT0030029 { get; set; }

		[Display(Name = "Pima (G84-G91) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Pima (G84-G91) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 142)]
		public int? PCT0030030 { get; set; }

		[Display(Name = "Potawatomi (H21-H33) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Potawatomi (H21-H33) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 143)]
		public int? PCT0030031 { get; set; }

		[Display(Name = "Pueblo (H38-H65) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Pueblo (H38-H65) & (100-299) or (300, A01-Z99) or (400-999)", Order = 144)]
		public int? PCT0030032 { get; set; }

		[Display(Name = "Puget Sound Salish (H70-H92) & (100-299) or  (300, A01-Z99) or (400-999)", ShortName = "Puget Sound Salish (H70-H92) & (100-299) or  (300, A01-Z99) or (400-999)", Order = 145)]
		public int? PCT0030033 { get; set; }

		[Display(Name = "Seminole (J47-J57) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Seminole (J47-J57) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 146)]
		public int? PCT0030034 { get; set; }

		[Display(Name = "Shoshone (J81-J92) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Shoshone (J81-J92) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 147)]
		public int? PCT0030035 { get; set; }

		[Display(Name = "Sioux (K16-K53) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Sioux (K16-K53) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 148)]
		public int? PCT0030036 { get; set; }

		[Display(Name = "South American Indian (W67-X24) & (100-299) or (300, A01-Z99)  or (400-999)", ShortName = "South American Indian (W67-X24) & (100-299) or (300, A01-Z99)  or (400-999)", Order = 149)]
		public int? PCT0030037 { get; set; }

		[Display(Name = "Spanish American Indian (X25-Z99) & (100-299) or  (300, A01-Z99) or (400-999)", ShortName = "Spanish American Indian (X25-Z99) & (100-299) or  (300, A01-Z99) or (400-999)", Order = 150)]
		public int? PCT0030038 { get; set; }

		[Display(Name = "Tohono O’Odham (K78-K86) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Tohono O’Odham (K78-K86) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 151)]
		public int? PCT0030039 { get; set; }

		[Display(Name = "Ute (L06-L14) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Ute (L06-L14) & (100-299) or (300, A01-Z99) or (400-999)", Order = 152)]
		public int? PCT0030040 { get; set; }

		[Display(Name = "Yakama (L79-L84) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Yakama (L79-L84) & (100-299) or (300, A01-Z99) or (400-999)", Order = 153)]
		public int? PCT0030041 { get; set; }

		[Display(Name = "Yaqui (L91-L99) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Yaqui (L91-L99) & (100-299) or (300, A01-Z99) or (400-999)", Order = 154)]
		public int? PCT0030042 { get; set; }

		[Display(Name = "Yuman (M22-M33) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Yuman (M22-M33) & (100-299) or (300, A01-Z99) or (400-999)", Order = 155)]
		public int? PCT0030043 { get; set; }

		[Display(Name = "All other American Indian tribes (please see technical documentation for codes at http://www.census.gov/prod/cen2010/doc/sf1.pdf, Appendix F)", ShortName = "All other American Indian tribes (please see technical documentation for codes at http://www.census.gov/prod/cen2010/doc/sf1.pdf, Appendix F)", Order = 156)]
		public int? PCT0030044 { get; set; }

		[Display(Name = "American Indian tribes, not specified (M40-M43) & (100-299)  or (300, A01-Z99) or (400-999)", ShortName = "American Indian tribes, not specified (M40-M43) & (100-299)  or (300, A01-Z99) or (400-999)", Order = 157)]
		public int? PCT0030045 { get; set; }

		[Display(Name = "Alaska Native tribes, specified (M52-R98, S01-S99) & (100-299)  or (300, A01-Z99) or (400-999):", ShortName = "Alaska Native tribes, specified (M52-R98, S01-S99) & (100-299)  or (300, A01-Z99) or (400-999):", Order = 158)]
		public int? PCT0030046 { get; set; }

		[Display(Name = "Alaskan Athabascan (M52-N27) & (100-299) or (300, A01-Z99)  or (400-999)", ShortName = "Alaskan Athabascan (M52-N27) & (100-299) or (300, A01-Z99)  or (400-999)", Order = 159)]
		public int? PCT0030047 { get; set; }

		[Display(Name = "Aleut (R11-R98, S01-S99) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Aleut (R11-R98, S01-S99) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 160)]
		public int? PCT0030048 { get; set; }

		[Display(Name = "Inupiat (N67-P29, P33-P37) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Inupiat (N67-P29, P33-P37) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 161)]
		public int? PCT0030049 { get; set; }

		[Display(Name = "Tlingit-Haida (N28-N55, N59-N66) & (100-299) or  (300, A01-Z99) or (400-999)", ShortName = "Tlingit-Haida (N28-N55, N59-N66) & (100-299) or  (300, A01-Z99) or (400-999)", Order = 162)]
		public int? PCT0030050 { get; set; }

		[Display(Name = "Tsimshian (N56-N58) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Tsimshian (N56-N58) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 163)]
		public int? PCT0030051 { get; set; }

		[Display(Name = "Yup'ik (P30-P32, P38-R10) & (100-299) or (300, A01-Z99)  or (400-999)", ShortName = "Yup'ik (P30-P32, P38-R10) & (100-299) or (300, A01-Z99)  or (400-999)", Order = 164)]
		public int? PCT0030052 { get; set; }

		[Display(Name = "Alaska Native tribes, not specified (M44-M51, R99) & (100-299) or  (300, A01-Z99) or (400-999)", ShortName = "Alaska Native tribes, not specified (M44-M51, R99) & (100-299) or  (300, A01-Z99) or (400-999)", Order = 165)]
		public int? PCT0030053 { get; set; }

		[Display(Name = "American Indian or Alaska Native tribes, not specified (M39),  (300) & (100-299) or (400-999)", ShortName = "American Indian or Alaska Native tribes, not specified (M39),  (300) & (100-299) or (400-999)", Order = 166)]
		public int? PCT0030054 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 167)]
		public int? PCT0040001 { get; set; }

		[Display(Name = "American Indian alone (People who reported a specific American Indian tribe only) (A01-M38, T01-Z99)", ShortName = "American Indian alone (People who reported a specific American Indian tribe only) (A01-M38, T01-Z99)", Order = 168)]
		public int? PCT0040002 { get; set; }

		[Display(Name = "Alaska Native alone (People who reported a specific Alaska Native tribe only) (M52-R98)", ShortName = "Alaska Native alone (People who reported a specific Alaska Native tribe only) (M52-R98)", Order = 169)]
		public int? PCT0040003 { get; set; }

		[Display(Name = "American Indian and Alaska Native alone (People who reported both a specific American Indian tribe(s) and a specific Alaska Native tribe(s) and no other race) (A01-M38, T01-Z99) &  (M52-R98)", ShortName = "American Indian and Alaska Native alone (People who reported both a specific American Indian tribe(s) and a specific Alaska Native tribe(s) and no other race) (A01-M38, T01-Z99) &  (M52-R98)", Order = 170)]
		public int? PCT0040004 { get; set; }

		[Display(Name = "American Indian in combination with one or more other races  (People who reported a specific American Indian tribe and reported one or more other races) (A01-M38, T01-Z99) & (100-299) or (400-999)", ShortName = "American Indian in combination with one or more other races  (People who reported a specific American Indian tribe and reported one or more other races) (A01-M38, T01-Z99) & (100-299) or (400-999)", Order = 171)]
		public int? PCT0040005 { get; set; }

		[Display(Name = "Alaska Native in combination with one or more other races (People who reported a specific Alaska Native tribe and reported one or more other races) (M52-R98) & (100-299) or (400-999)", ShortName = "Alaska Native in combination with one or more other races (People who reported a specific Alaska Native tribe and reported one or more other races) (M52-R98) & (100-299) or (400-999)", Order = 172)]
		public int? PCT0040006 { get; set; }

		[Display(Name = "American Indian and Alaska Native in combination with one or more other races(People who reported both a specific American Indian tribe and a specific Alaska Native tribe and reported 1 or more other races)(A01-M38,T01-Z99)&(M52-R98)&(100-299)or(400-999)", ShortName = "American Indian and Alaska Native in combination with one or more other races(People who reported both a specific American Indian tribe and a specific Alaska Native tribe and reported 1 or more other races)(A01-M38,T01-Z99)&(M52-R98)&(100-299)or(400-999)", Order = 173)]
		public int? PCT0040007 { get; set; }

		[Display(Name = "American Indian or Alaska Native alone (People who marked the American Indian or Alaska Native checkbox only or did not report a specific tribe) (300-399) or (M39-M51, R99)", ShortName = "American Indian or Alaska Native alone (People who marked the American Indian or Alaska Native checkbox only or did not report a specific tribe) (300-399) or (M39-M51, R99)", Order = 174)]
		public int? PCT0040008 { get; set; }

		[Display(Name = "American Indian and Alaska Native in combination with 1 or more other races(People who marked the American Indian or Alaska Native checkbox or didn’t provide a specific tribe,and reported 1 or more other races)(300-399)or(M39-M51,R99)&(100-299)or(400-999)", ShortName = "American Indian and Alaska Native in combination with 1 or more other races(People who marked the American Indian or Alaska Native checkbox or didn’t provide a specific tribe,and reported 1 or more other races)(300-399)or(M39-M51,R99)&(100-299)or(400-999)", Order = 175)]
		public int? PCT0040009 { get; set; }

		[Display(Name = "Total (400-479, 481-499):", ShortName = "Total (400-479, 481-499):", Order = 176)]
		public int? PCT0050001 { get; set; }

		[Display(Name = "Asian Indian (400-401)", ShortName = "Asian Indian (400-401)", Order = 177)]
		public int? PCT0050002 { get; set; }

		[Display(Name = "Bangladeshi (402)", ShortName = "Bangladeshi (402)", Order = 178)]
		public int? PCT0050003 { get; set; }

		[Display(Name = "Bhutanese (403)", ShortName = "Bhutanese (403)", Order = 179)]
		public int? PCT0050004 { get; set; }

		[Display(Name = "Burmese (404)", ShortName = "Burmese (404)", Order = 180)]
		public int? PCT0050005 { get; set; }

		[Display(Name = "Cambodian (405-409)", ShortName = "Cambodian (405-409)", Order = 181)]
		public int? PCT0050006 { get; set; }

		[Display(Name = "Chinese (except Taiwanese) (410-411)", ShortName = "Chinese (except Taiwanese) (410-411)", Order = 182)]
		public int? PCT0050007 { get; set; }

		[Display(Name = "Filipino (420-421)", ShortName = "Filipino (420-421)", Order = 183)]
		public int? PCT0050008 { get; set; }

		[Display(Name = "Hmong (422)", ShortName = "Hmong (422)", Order = 184)]
		public int? PCT0050009 { get; set; }

		[Display(Name = "Indonesian (423-429)", ShortName = "Indonesian (423-429)", Order = 185)]
		public int? PCT0050010 { get; set; }

		[Display(Name = "Japanese (430-439)", ShortName = "Japanese (430-439)", Order = 186)]
		public int? PCT0050011 { get; set; }

		[Display(Name = "Korean (440-441)", ShortName = "Korean (440-441)", Order = 187)]
		public int? PCT0050012 { get; set; }

		[Display(Name = "Laotian (442)", ShortName = "Laotian (442)", Order = 188)]
		public int? PCT0050013 { get; set; }

		[Display(Name = "Malaysian (443)", ShortName = "Malaysian (443)", Order = 189)]
		public int? PCT0050014 { get; set; }

		[Display(Name = "Nepalese (472)", ShortName = "Nepalese (472)", Order = 190)]
		public int? PCT0050015 { get; set; }

		[Display(Name = "Pakistani (445)", ShortName = "Pakistani (445)", Order = 191)]
		public int? PCT0050016 { get; set; }

		[Display(Name = "Sri Lankan (446)", ShortName = "Sri Lankan (446)", Order = 192)]
		public int? PCT0050017 { get; set; }

		[Display(Name = "Taiwanese (412-419)", ShortName = "Taiwanese (412-419)", Order = 193)]
		public int? PCT0050018 { get; set; }

		[Display(Name = "Thai (447-449)", ShortName = "Thai (447-449)", Order = 194)]
		public int? PCT0050019 { get; set; }

		[Display(Name = "Vietnamese (450-459)", ShortName = "Vietnamese (450-459)", Order = 195)]
		public int? PCT0050020 { get; set; }

		[Display(Name = "Other Asian, specified (444, 465, 470-471, 473-479)", ShortName = "Other Asian, specified (444, 465, 470-471, 473-479)", Order = 196)]
		public int? PCT0050021 { get; set; }

		[Display(Name = "Other Asian, not specified (460-464, 466-469, 481-499)", ShortName = "Other Asian, not specified (460-464, 466-469, 481-499)", Order = 197)]
		public int? PCT0050022 { get; set; }

		[Display(Name = "Total Asian categories tallied (400-499) & (400-499):", ShortName = "Total Asian categories tallied (400-499) & (400-499):", Order = 198)]
		public int? PCT0060001 { get; set; }

		[Display(Name = "Asian Indian (400-401) & (400-499)", ShortName = "Asian Indian (400-401) & (400-499)", Order = 199)]
		public int? PCT0060002 { get; set; }

		[Display(Name = "Bangladeshi (402) & (400-499)", ShortName = "Bangladeshi (402) & (400-499)", Order = 200)]
		public int? PCT0060003 { get; set; }

		[Display(Name = "Bhutanese (403) & (400-499)", ShortName = "Bhutanese (403) & (400-499)", Order = 201)]
		public int? PCT0060004 { get; set; }

		[Display(Name = "Burmese (404) & (400-499)", ShortName = "Burmese (404) & (400-499)", Order = 202)]
		public int? PCT0060005 { get; set; }

		[Display(Name = "Cambodian (405-409) & (400-499)", ShortName = "Cambodian (405-409) & (400-499)", Order = 203)]
		public int? PCT0060006 { get; set; }

		[Display(Name = "Chinese (except Taiwanese) (410-411) & (400-499)", ShortName = "Chinese (except Taiwanese) (410-411) & (400-499)", Order = 204)]
		public int? PCT0060007 { get; set; }

		[Display(Name = "Filipino (420-421) & (400-499)", ShortName = "Filipino (420-421) & (400-499)", Order = 205)]
		public int? PCT0060008 { get; set; }

		[Display(Name = "Hmong (422) & (400-499)", ShortName = "Hmong (422) & (400-499)", Order = 206)]
		public int? PCT0060009 { get; set; }

		[Display(Name = "Indonesian (423-429) & (400-499)", ShortName = "Indonesian (423-429) & (400-499)", Order = 207)]
		public int? PCT0060010 { get; set; }

		[Display(Name = "Japanese (430-439) & (400-499)", ShortName = "Japanese (430-439) & (400-499)", Order = 208)]
		public int? PCT0060011 { get; set; }

		[Display(Name = "Korean (440-441) & (400-499)", ShortName = "Korean (440-441) & (400-499)", Order = 209)]
		public int? PCT0060012 { get; set; }

		[Display(Name = "Laotian (442) & (400-499)", ShortName = "Laotian (442) & (400-499)", Order = 210)]
		public int? PCT0060013 { get; set; }

		[Display(Name = "Malaysian (443) & (400-499)", ShortName = "Malaysian (443) & (400-499)", Order = 211)]
		public int? PCT0060014 { get; set; }

		[Display(Name = "Nepalese (472) & (400-499)", ShortName = "Nepalese (472) & (400-499)", Order = 212)]
		public int? PCT0060015 { get; set; }

		[Display(Name = "Pakistani (445) & (400-499)", ShortName = "Pakistani (445) & (400-499)", Order = 213)]
		public int? PCT0060016 { get; set; }

		[Display(Name = "Sri Lankan (446) & (400-499)", ShortName = "Sri Lankan (446) & (400-499)", Order = 214)]
		public int? PCT0060017 { get; set; }

		[Display(Name = "Taiwanese (412-419) & (400-499)", ShortName = "Taiwanese (412-419) & (400-499)", Order = 215)]
		public int? PCT0060018 { get; set; }

		[Display(Name = "Thai (447-449) & (400-499)", ShortName = "Thai (447-449) & (400-499)", Order = 216)]
		public int? PCT0060019 { get; set; }

		[Display(Name = "Vietnamese (450-459) & (400-499)", ShortName = "Vietnamese (450-459) & (400-499)", Order = 217)]
		public int? PCT0060020 { get; set; }

		[Display(Name = "Other Asian, specified (444, 465, 470-471, 473-479) & (400-499)", ShortName = "Other Asian, specified (444, 465, 470-471, 473-479) & (400-499)", Order = 218)]
		public int? PCT0060021 { get; set; }

		[Display(Name = "Other Asian, not specified (460-464, 466-469, 480-499) & (400-499)", ShortName = "Other Asian, not specified (460-464, 466-469, 480-499) & (400-499)", Order = 219)]
		public int? PCT0060022 { get; set; }

		[Display(Name = "Total Asian categories tallied (400-499) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Total Asian categories tallied (400-499) & (100-299) or (300, A01-Z99) or (400-999):", Order = 220)]
		public int? PCT0070001 { get; set; }

		[Display(Name = "Asian Indian (400-401) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Asian Indian (400-401) & (100-299) or (300, A01-Z99) or (400-999)", Order = 221)]
		public int? PCT0070002 { get; set; }

		[Display(Name = "Bangladeshi (402) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Bangladeshi (402) & (100-299) or (300, A01-Z99) or (400-999)", Order = 222)]
		public int? PCT0070003 { get; set; }

		[Display(Name = "Bhutanese (403) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Bhutanese (403) & (100-299) or (300, A01-Z99) or (400-999)", Order = 223)]
		public int? PCT0070004 { get; set; }

		[Display(Name = "Burmese (404) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Burmese (404) & (100-299) or (300, A01-Z99) or (400-999)", Order = 224)]
		public int? PCT0070005 { get; set; }

		[Display(Name = "Cambodian (405-409) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Cambodian (405-409) & (100-299) or (300, A01-Z99) or (400-999)", Order = 225)]
		public int? PCT0070006 { get; set; }

		[Display(Name = "Chinese (except Taiwanese) (410-411) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Chinese (except Taiwanese) (410-411) & (100-299) or (300, A01-Z99) or (400-999)", Order = 226)]
		public int? PCT0070007 { get; set; }

		[Display(Name = "Filipino (420-421) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Filipino (420-421) & (100-299) or (300, A01-Z99) or (400-999)", Order = 227)]
		public int? PCT0070008 { get; set; }

		[Display(Name = "Hmong (422) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Hmong (422) & (100-299) or (300, A01-Z99) or (400-999)", Order = 228)]
		public int? PCT0070009 { get; set; }

		[Display(Name = "Indonesian (423-429) & (100-299) or (300, A01-Z99) or  (400-999)", ShortName = "Indonesian (423-429) & (100-299) or (300, A01-Z99) or  (400-999)", Order = 229)]
		public int? PCT0070010 { get; set; }

		[Display(Name = "Japanese (430-439) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Japanese (430-439) & (100-299) or (300, A01-Z99) or (400-999)", Order = 230)]
		public int? PCT0070011 { get; set; }

		[Display(Name = "Korean (440-441) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Korean (440-441) & (100-299) or (300, A01-Z99) or (400-999)", Order = 231)]
		public int? PCT0070012 { get; set; }

		[Display(Name = "Laotian (442) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Laotian (442) & (100-299) or (300, A01-Z99) or (400-999)", Order = 232)]
		public int? PCT0070013 { get; set; }

		[Display(Name = "Malaysian (443) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Malaysian (443) & (100-299) or (300, A01-Z99) or (400-999)", Order = 233)]
		public int? PCT0070014 { get; set; }

		[Display(Name = "Nepalese (472) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Nepalese (472) & (100-299) or (300, A01-Z99) or (400-999)", Order = 234)]
		public int? PCT0070015 { get; set; }

		[Display(Name = "Pakistani (445) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Pakistani (445) & (100-299) or (300, A01-Z99) or (400-999)", Order = 235)]
		public int? PCT0070016 { get; set; }

		[Display(Name = "Sri Lankan (446) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Sri Lankan (446) & (100-299) or (300, A01-Z99) or (400-999)", Order = 236)]
		public int? PCT0070017 { get; set; }

		[Display(Name = "Taiwanese (412-419) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Taiwanese (412-419) & (100-299) or (300, A01-Z99) or (400-999)", Order = 237)]
		public int? PCT0070018 { get; set; }

		[Display(Name = "Thai (447-449) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Thai (447-449) & (100-299) or (300, A01-Z99) or (400-999)", Order = 238)]
		public int? PCT0070019 { get; set; }

		[Display(Name = "Vietnamese (450-459) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Vietnamese (450-459) & (100-299) or (300, A01-Z99) or (400-999)", Order = 239)]
		public int? PCT0070020 { get; set; }

		[Display(Name = "Other Asian, specified (444, 465, 470-471, 473-479) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Other Asian, specified (444, 465, 470-471, 473-479) & (100-299) or (300, A01-Z99) or (400-999)", Order = 240)]
		public int? PCT0070021 { get; set; }

		[Display(Name = "Other Asian, not specified (460-464, 466-469, 480-499) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Other Asian, not specified (460-464, 466-469, 480-499) & (100-299) or (300, A01-Z99) or (400-999)", Order = 241)]
		public int? PCT0070022 { get; set; }

		[Display(Name = "Total (500-549, 551-599):", ShortName = "Total (500-549, 551-599):", Order = 242)]
		public int? PCT0080001 { get; set; }

		[Display(Name = "Polynesian (500-519):", ShortName = "Polynesian (500-519):", Order = 243)]
		public int? PCT0080002 { get; set; }

		[Display(Name = "Native Hawaiian (500-503)", ShortName = "Native Hawaiian (500-503)", Order = 244)]
		public int? PCT0080003 { get; set; }

		[Display(Name = "Samoan (510-511)", ShortName = "Samoan (510-511)", Order = 245)]
		public int? PCT0080004 { get; set; }

		[Display(Name = "Tongan (513)", ShortName = "Tongan (513)", Order = 246)]
		public int? PCT0080005 { get; set; }

		[Display(Name = "Other Polynesian (504-509, 512, 514-519)", ShortName = "Other Polynesian (504-509, 512, 514-519)", Order = 247)]
		public int? PCT0080006 { get; set; }

		[Display(Name = "Micronesian (520-529, 531-541):", ShortName = "Micronesian (520-529, 531-541):", Order = 248)]
		public int? PCT0080007 { get; set; }

		[Display(Name = "Guamanian or Chamorro (520-522)", ShortName = "Guamanian or Chamorro (520-522)", Order = 249)]
		public int? PCT0080008 { get; set; }

		[Display(Name = "Marshallese (532)", ShortName = "Marshallese (532)", Order = 250)]
		public int? PCT0080009 { get; set; }

		[Display(Name = "Other Micronesian (523-529, 531, 533-541)", ShortName = "Other Micronesian (523-529, 531, 533-541)", Order = 251)]
		public int? PCT0080010 { get; set; }

		[Display(Name = "Melanesian (542-546):", ShortName = "Melanesian (542-546):", Order = 252)]
		public int? PCT0080011 { get; set; }

		[Display(Name = "Fijian (542)", ShortName = "Fijian (542)", Order = 253)]
		public int? PCT0080012 { get; set; }

		[Display(Name = "Other Melanesian (543-546)", ShortName = "Other Melanesian (543-546)", Order = 254)]
		public int? PCT0080013 { get; set; }

		[Display(Name = "Other Pacific Islander, not specified (530, 547-549, 551-599)", ShortName = "Other Pacific Islander, not specified (530, 547-549, 551-599)", Order = 255)]
		public int? PCT0080014 { get; set; }
		#endregion Properties

		#region Constructors
		public SF1CongressionalDistricts113_SF1_00015() { }

		public SF1CongressionalDistricts113_SF1_00015(string csvLine) : base(csvLine) { }

		public SF1CongressionalDistricts113_SF1_00015(string[] values) : base(values) { }

		public SF1CongressionalDistricts113_SF1_00015(OleDbDataReader reader)
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
				PCT0010001 = (int?)reader[5];
			}
			if(reader[6] != DBNull.Value)
			{
				PCT0010002 = (int?)reader[6];
			}
			if(reader[7] != DBNull.Value)
			{
				PCT0010003 = (int?)reader[7];
			}
			if(reader[8] != DBNull.Value)
			{
				PCT0010004 = (int?)reader[8];
			}
			if(reader[9] != DBNull.Value)
			{
				PCT0010005 = (int?)reader[9];
			}
			if(reader[10] != DBNull.Value)
			{
				PCT0010006 = (int?)reader[10];
			}
			if(reader[11] != DBNull.Value)
			{
				PCT0010007 = (int?)reader[11];
			}
			if(reader[12] != DBNull.Value)
			{
				PCT0010008 = (int?)reader[12];
			}
			if(reader[13] != DBNull.Value)
			{
				PCT0010009 = (int?)reader[13];
			}
			if(reader[14] != DBNull.Value)
			{
				PCT0010010 = (int?)reader[14];
			}
			if(reader[15] != DBNull.Value)
			{
				PCT0010011 = (int?)reader[15];
			}
			if(reader[16] != DBNull.Value)
			{
				PCT0010012 = (int?)reader[16];
			}
			if(reader[17] != DBNull.Value)
			{
				PCT0010013 = (int?)reader[17];
			}
			if(reader[18] != DBNull.Value)
			{
				PCT0010014 = (int?)reader[18];
			}
			if(reader[19] != DBNull.Value)
			{
				PCT0010015 = (int?)reader[19];
			}
			if(reader[20] != DBNull.Value)
			{
				PCT0010016 = (int?)reader[20];
			}
			if(reader[21] != DBNull.Value)
			{
				PCT0010017 = (int?)reader[21];
			}
			if(reader[22] != DBNull.Value)
			{
				PCT0010018 = (int?)reader[22];
			}
			if(reader[23] != DBNull.Value)
			{
				PCT0010019 = (int?)reader[23];
			}
			if(reader[24] != DBNull.Value)
			{
				PCT0010020 = (int?)reader[24];
			}
			if(reader[25] != DBNull.Value)
			{
				PCT0010021 = (int?)reader[25];
			}
			if(reader[26] != DBNull.Value)
			{
				PCT0010022 = (int?)reader[26];
			}
			if(reader[27] != DBNull.Value)
			{
				PCT0010023 = (int?)reader[27];
			}
			if(reader[28] != DBNull.Value)
			{
				PCT0010024 = (int?)reader[28];
			}
			if(reader[29] != DBNull.Value)
			{
				PCT0010025 = (int?)reader[29];
			}
			if(reader[30] != DBNull.Value)
			{
				PCT0010026 = (int?)reader[30];
			}
			if(reader[31] != DBNull.Value)
			{
				PCT0010027 = (int?)reader[31];
			}
			if(reader[32] != DBNull.Value)
			{
				PCT0010028 = (int?)reader[32];
			}
			if(reader[33] != DBNull.Value)
			{
				PCT0010029 = (int?)reader[33];
			}
			if(reader[34] != DBNull.Value)
			{
				PCT0010030 = (int?)reader[34];
			}
			if(reader[35] != DBNull.Value)
			{
				PCT0010031 = (int?)reader[35];
			}
			if(reader[36] != DBNull.Value)
			{
				PCT0010032 = (int?)reader[36];
			}
			if(reader[37] != DBNull.Value)
			{
				PCT0010033 = (int?)reader[37];
			}
			if(reader[38] != DBNull.Value)
			{
				PCT0010034 = (int?)reader[38];
			}
			if(reader[39] != DBNull.Value)
			{
				PCT0010035 = (int?)reader[39];
			}
			if(reader[40] != DBNull.Value)
			{
				PCT0010036 = (int?)reader[40];
			}
			if(reader[41] != DBNull.Value)
			{
				PCT0010037 = (int?)reader[41];
			}
			if(reader[42] != DBNull.Value)
			{
				PCT0010038 = (int?)reader[42];
			}
			if(reader[43] != DBNull.Value)
			{
				PCT0010039 = (int?)reader[43];
			}
			if(reader[44] != DBNull.Value)
			{
				PCT0010040 = (int?)reader[44];
			}
			if(reader[45] != DBNull.Value)
			{
				PCT0010041 = (int?)reader[45];
			}
			if(reader[46] != DBNull.Value)
			{
				PCT0010042 = (int?)reader[46];
			}
			if(reader[47] != DBNull.Value)
			{
				PCT0010043 = (int?)reader[47];
			}
			if(reader[48] != DBNull.Value)
			{
				PCT0010044 = (int?)reader[48];
			}
			if(reader[49] != DBNull.Value)
			{
				PCT0010045 = (int?)reader[49];
			}
			if(reader[50] != DBNull.Value)
			{
				PCT0010046 = (int?)reader[50];
			}
			if(reader[51] != DBNull.Value)
			{
				PCT0010047 = (int?)reader[51];
			}
			if(reader[52] != DBNull.Value)
			{
				PCT0010048 = (int?)reader[52];
			}
			if(reader[53] != DBNull.Value)
			{
				PCT0010049 = (int?)reader[53];
			}
			if(reader[54] != DBNull.Value)
			{
				PCT0010050 = (int?)reader[54];
			}
			if(reader[55] != DBNull.Value)
			{
				PCT0010051 = (int?)reader[55];
			}
			if(reader[56] != DBNull.Value)
			{
				PCT0010052 = (int?)reader[56];
			}
			if(reader[57] != DBNull.Value)
			{
				PCT0010053 = (int?)reader[57];
			}
			if(reader[58] != DBNull.Value)
			{
				PCT0010054 = (int?)reader[58];
			}
			if(reader[59] != DBNull.Value)
			{
				PCT0020001 = (int?)reader[59];
			}
			if(reader[60] != DBNull.Value)
			{
				PCT0020002 = (int?)reader[60];
			}
			if(reader[61] != DBNull.Value)
			{
				PCT0020003 = (int?)reader[61];
			}
			if(reader[62] != DBNull.Value)
			{
				PCT0020004 = (int?)reader[62];
			}
			if(reader[63] != DBNull.Value)
			{
				PCT0020005 = (int?)reader[63];
			}
			if(reader[64] != DBNull.Value)
			{
				PCT0020006 = (int?)reader[64];
			}
			if(reader[65] != DBNull.Value)
			{
				PCT0020007 = (int?)reader[65];
			}
			if(reader[66] != DBNull.Value)
			{
				PCT0020008 = (int?)reader[66];
			}
			if(reader[67] != DBNull.Value)
			{
				PCT0020009 = (int?)reader[67];
			}
			if(reader[68] != DBNull.Value)
			{
				PCT0020010 = (int?)reader[68];
			}
			if(reader[69] != DBNull.Value)
			{
				PCT0020011 = (int?)reader[69];
			}
			if(reader[70] != DBNull.Value)
			{
				PCT0020012 = (int?)reader[70];
			}
			if(reader[71] != DBNull.Value)
			{
				PCT0020013 = (int?)reader[71];
			}
			if(reader[72] != DBNull.Value)
			{
				PCT0020014 = (int?)reader[72];
			}
			if(reader[73] != DBNull.Value)
			{
				PCT0020015 = (int?)reader[73];
			}
			if(reader[74] != DBNull.Value)
			{
				PCT0020016 = (int?)reader[74];
			}
			if(reader[75] != DBNull.Value)
			{
				PCT0020017 = (int?)reader[75];
			}
			if(reader[76] != DBNull.Value)
			{
				PCT0020018 = (int?)reader[76];
			}
			if(reader[77] != DBNull.Value)
			{
				PCT0020019 = (int?)reader[77];
			}
			if(reader[78] != DBNull.Value)
			{
				PCT0020020 = (int?)reader[78];
			}
			if(reader[79] != DBNull.Value)
			{
				PCT0020021 = (int?)reader[79];
			}
			if(reader[80] != DBNull.Value)
			{
				PCT0020022 = (int?)reader[80];
			}
			if(reader[81] != DBNull.Value)
			{
				PCT0020023 = (int?)reader[81];
			}
			if(reader[82] != DBNull.Value)
			{
				PCT0020024 = (int?)reader[82];
			}
			if(reader[83] != DBNull.Value)
			{
				PCT0020025 = (int?)reader[83];
			}
			if(reader[84] != DBNull.Value)
			{
				PCT0020026 = (int?)reader[84];
			}
			if(reader[85] != DBNull.Value)
			{
				PCT0020027 = (int?)reader[85];
			}
			if(reader[86] != DBNull.Value)
			{
				PCT0020028 = (int?)reader[86];
			}
			if(reader[87] != DBNull.Value)
			{
				PCT0020029 = (int?)reader[87];
			}
			if(reader[88] != DBNull.Value)
			{
				PCT0020030 = (int?)reader[88];
			}
			if(reader[89] != DBNull.Value)
			{
				PCT0020031 = (int?)reader[89];
			}
			if(reader[90] != DBNull.Value)
			{
				PCT0020032 = (int?)reader[90];
			}
			if(reader[91] != DBNull.Value)
			{
				PCT0020033 = (int?)reader[91];
			}
			if(reader[92] != DBNull.Value)
			{
				PCT0020034 = (int?)reader[92];
			}
			if(reader[93] != DBNull.Value)
			{
				PCT0020035 = (int?)reader[93];
			}
			if(reader[94] != DBNull.Value)
			{
				PCT0020036 = (int?)reader[94];
			}
			if(reader[95] != DBNull.Value)
			{
				PCT0020037 = (int?)reader[95];
			}
			if(reader[96] != DBNull.Value)
			{
				PCT0020038 = (int?)reader[96];
			}
			if(reader[97] != DBNull.Value)
			{
				PCT0020039 = (int?)reader[97];
			}
			if(reader[98] != DBNull.Value)
			{
				PCT0020040 = (int?)reader[98];
			}
			if(reader[99] != DBNull.Value)
			{
				PCT0020041 = (int?)reader[99];
			}
			if(reader[100] != DBNull.Value)
			{
				PCT0020042 = (int?)reader[100];
			}
			if(reader[101] != DBNull.Value)
			{
				PCT0020043 = (int?)reader[101];
			}
			if(reader[102] != DBNull.Value)
			{
				PCT0020044 = (int?)reader[102];
			}
			if(reader[103] != DBNull.Value)
			{
				PCT0020045 = (int?)reader[103];
			}
			if(reader[104] != DBNull.Value)
			{
				PCT0020046 = (int?)reader[104];
			}
			if(reader[105] != DBNull.Value)
			{
				PCT0020047 = (int?)reader[105];
			}
			if(reader[106] != DBNull.Value)
			{
				PCT0020048 = (int?)reader[106];
			}
			if(reader[107] != DBNull.Value)
			{
				PCT0020049 = (int?)reader[107];
			}
			if(reader[108] != DBNull.Value)
			{
				PCT0020050 = (int?)reader[108];
			}
			if(reader[109] != DBNull.Value)
			{
				PCT0020051 = (int?)reader[109];
			}
			if(reader[110] != DBNull.Value)
			{
				PCT0020052 = (int?)reader[110];
			}
			if(reader[111] != DBNull.Value)
			{
				PCT0020053 = (int?)reader[111];
			}
			if(reader[112] != DBNull.Value)
			{
				PCT0020054 = (int?)reader[112];
			}
			if(reader[113] != DBNull.Value)
			{
				PCT0030001 = (int?)reader[113];
			}
			if(reader[114] != DBNull.Value)
			{
				PCT0030002 = (int?)reader[114];
			}
			if(reader[115] != DBNull.Value)
			{
				PCT0030003 = (int?)reader[115];
			}
			if(reader[116] != DBNull.Value)
			{
				PCT0030004 = (int?)reader[116];
			}
			if(reader[117] != DBNull.Value)
			{
				PCT0030005 = (int?)reader[117];
			}
			if(reader[118] != DBNull.Value)
			{
				PCT0030006 = (int?)reader[118];
			}
			if(reader[119] != DBNull.Value)
			{
				PCT0030007 = (int?)reader[119];
			}
			if(reader[120] != DBNull.Value)
			{
				PCT0030008 = (int?)reader[120];
			}
			if(reader[121] != DBNull.Value)
			{
				PCT0030009 = (int?)reader[121];
			}
			if(reader[122] != DBNull.Value)
			{
				PCT0030010 = (int?)reader[122];
			}
			if(reader[123] != DBNull.Value)
			{
				PCT0030011 = (int?)reader[123];
			}
			if(reader[124] != DBNull.Value)
			{
				PCT0030012 = (int?)reader[124];
			}
			if(reader[125] != DBNull.Value)
			{
				PCT0030013 = (int?)reader[125];
			}
			if(reader[126] != DBNull.Value)
			{
				PCT0030014 = (int?)reader[126];
			}
			if(reader[127] != DBNull.Value)
			{
				PCT0030015 = (int?)reader[127];
			}
			if(reader[128] != DBNull.Value)
			{
				PCT0030016 = (int?)reader[128];
			}
			if(reader[129] != DBNull.Value)
			{
				PCT0030017 = (int?)reader[129];
			}
			if(reader[130] != DBNull.Value)
			{
				PCT0030018 = (int?)reader[130];
			}
			if(reader[131] != DBNull.Value)
			{
				PCT0030019 = (int?)reader[131];
			}
			if(reader[132] != DBNull.Value)
			{
				PCT0030020 = (int?)reader[132];
			}
			if(reader[133] != DBNull.Value)
			{
				PCT0030021 = (int?)reader[133];
			}
			if(reader[134] != DBNull.Value)
			{
				PCT0030022 = (int?)reader[134];
			}
			if(reader[135] != DBNull.Value)
			{
				PCT0030023 = (int?)reader[135];
			}
			if(reader[136] != DBNull.Value)
			{
				PCT0030024 = (int?)reader[136];
			}
			if(reader[137] != DBNull.Value)
			{
				PCT0030025 = (int?)reader[137];
			}
			if(reader[138] != DBNull.Value)
			{
				PCT0030026 = (int?)reader[138];
			}
			if(reader[139] != DBNull.Value)
			{
				PCT0030027 = (int?)reader[139];
			}
			if(reader[140] != DBNull.Value)
			{
				PCT0030028 = (int?)reader[140];
			}
			if(reader[141] != DBNull.Value)
			{
				PCT0030029 = (int?)reader[141];
			}
			if(reader[142] != DBNull.Value)
			{
				PCT0030030 = (int?)reader[142];
			}
			if(reader[143] != DBNull.Value)
			{
				PCT0030031 = (int?)reader[143];
			}
			if(reader[144] != DBNull.Value)
			{
				PCT0030032 = (int?)reader[144];
			}
			if(reader[145] != DBNull.Value)
			{
				PCT0030033 = (int?)reader[145];
			}
			if(reader[146] != DBNull.Value)
			{
				PCT0030034 = (int?)reader[146];
			}
			if(reader[147] != DBNull.Value)
			{
				PCT0030035 = (int?)reader[147];
			}
			if(reader[148] != DBNull.Value)
			{
				PCT0030036 = (int?)reader[148];
			}
			if(reader[149] != DBNull.Value)
			{
				PCT0030037 = (int?)reader[149];
			}
			if(reader[150] != DBNull.Value)
			{
				PCT0030038 = (int?)reader[150];
			}
			if(reader[151] != DBNull.Value)
			{
				PCT0030039 = (int?)reader[151];
			}
			if(reader[152] != DBNull.Value)
			{
				PCT0030040 = (int?)reader[152];
			}
			if(reader[153] != DBNull.Value)
			{
				PCT0030041 = (int?)reader[153];
			}
			if(reader[154] != DBNull.Value)
			{
				PCT0030042 = (int?)reader[154];
			}
			if(reader[155] != DBNull.Value)
			{
				PCT0030043 = (int?)reader[155];
			}
			if(reader[156] != DBNull.Value)
			{
				PCT0030044 = (int?)reader[156];
			}
			if(reader[157] != DBNull.Value)
			{
				PCT0030045 = (int?)reader[157];
			}
			if(reader[158] != DBNull.Value)
			{
				PCT0030046 = (int?)reader[158];
			}
			if(reader[159] != DBNull.Value)
			{
				PCT0030047 = (int?)reader[159];
			}
			if(reader[160] != DBNull.Value)
			{
				PCT0030048 = (int?)reader[160];
			}
			if(reader[161] != DBNull.Value)
			{
				PCT0030049 = (int?)reader[161];
			}
			if(reader[162] != DBNull.Value)
			{
				PCT0030050 = (int?)reader[162];
			}
			if(reader[163] != DBNull.Value)
			{
				PCT0030051 = (int?)reader[163];
			}
			if(reader[164] != DBNull.Value)
			{
				PCT0030052 = (int?)reader[164];
			}
			if(reader[165] != DBNull.Value)
			{
				PCT0030053 = (int?)reader[165];
			}
			if(reader[166] != DBNull.Value)
			{
				PCT0030054 = (int?)reader[166];
			}
			if(reader[167] != DBNull.Value)
			{
				PCT0040001 = (int?)reader[167];
			}
			if(reader[168] != DBNull.Value)
			{
				PCT0040002 = (int?)reader[168];
			}
			if(reader[169] != DBNull.Value)
			{
				PCT0040003 = (int?)reader[169];
			}
			if(reader[170] != DBNull.Value)
			{
				PCT0040004 = (int?)reader[170];
			}
			if(reader[171] != DBNull.Value)
			{
				PCT0040005 = (int?)reader[171];
			}
			if(reader[172] != DBNull.Value)
			{
				PCT0040006 = (int?)reader[172];
			}
			if(reader[173] != DBNull.Value)
			{
				PCT0040007 = (int?)reader[173];
			}
			if(reader[174] != DBNull.Value)
			{
				PCT0040008 = (int?)reader[174];
			}
			if(reader[175] != DBNull.Value)
			{
				PCT0040009 = (int?)reader[175];
			}
			if(reader[176] != DBNull.Value)
			{
				PCT0050001 = (int?)reader[176];
			}
			if(reader[177] != DBNull.Value)
			{
				PCT0050002 = (int?)reader[177];
			}
			if(reader[178] != DBNull.Value)
			{
				PCT0050003 = (int?)reader[178];
			}
			if(reader[179] != DBNull.Value)
			{
				PCT0050004 = (int?)reader[179];
			}
			if(reader[180] != DBNull.Value)
			{
				PCT0050005 = (int?)reader[180];
			}
			if(reader[181] != DBNull.Value)
			{
				PCT0050006 = (int?)reader[181];
			}
			if(reader[182] != DBNull.Value)
			{
				PCT0050007 = (int?)reader[182];
			}
			if(reader[183] != DBNull.Value)
			{
				PCT0050008 = (int?)reader[183];
			}
			if(reader[184] != DBNull.Value)
			{
				PCT0050009 = (int?)reader[184];
			}
			if(reader[185] != DBNull.Value)
			{
				PCT0050010 = (int?)reader[185];
			}
			if(reader[186] != DBNull.Value)
			{
				PCT0050011 = (int?)reader[186];
			}
			if(reader[187] != DBNull.Value)
			{
				PCT0050012 = (int?)reader[187];
			}
			if(reader[188] != DBNull.Value)
			{
				PCT0050013 = (int?)reader[188];
			}
			if(reader[189] != DBNull.Value)
			{
				PCT0050014 = (int?)reader[189];
			}
			if(reader[190] != DBNull.Value)
			{
				PCT0050015 = (int?)reader[190];
			}
			if(reader[191] != DBNull.Value)
			{
				PCT0050016 = (int?)reader[191];
			}
			if(reader[192] != DBNull.Value)
			{
				PCT0050017 = (int?)reader[192];
			}
			if(reader[193] != DBNull.Value)
			{
				PCT0050018 = (int?)reader[193];
			}
			if(reader[194] != DBNull.Value)
			{
				PCT0050019 = (int?)reader[194];
			}
			if(reader[195] != DBNull.Value)
			{
				PCT0050020 = (int?)reader[195];
			}
			if(reader[196] != DBNull.Value)
			{
				PCT0050021 = (int?)reader[196];
			}
			if(reader[197] != DBNull.Value)
			{
				PCT0050022 = (int?)reader[197];
			}
			if(reader[198] != DBNull.Value)
			{
				PCT0060001 = (int?)reader[198];
			}
			if(reader[199] != DBNull.Value)
			{
				PCT0060002 = (int?)reader[199];
			}
			if(reader[200] != DBNull.Value)
			{
				PCT0060003 = (int?)reader[200];
			}
			if(reader[201] != DBNull.Value)
			{
				PCT0060004 = (int?)reader[201];
			}
			if(reader[202] != DBNull.Value)
			{
				PCT0060005 = (int?)reader[202];
			}
			if(reader[203] != DBNull.Value)
			{
				PCT0060006 = (int?)reader[203];
			}
			if(reader[204] != DBNull.Value)
			{
				PCT0060007 = (int?)reader[204];
			}
			if(reader[205] != DBNull.Value)
			{
				PCT0060008 = (int?)reader[205];
			}
			if(reader[206] != DBNull.Value)
			{
				PCT0060009 = (int?)reader[206];
			}
			if(reader[207] != DBNull.Value)
			{
				PCT0060010 = (int?)reader[207];
			}
			if(reader[208] != DBNull.Value)
			{
				PCT0060011 = (int?)reader[208];
			}
			if(reader[209] != DBNull.Value)
			{
				PCT0060012 = (int?)reader[209];
			}
			if(reader[210] != DBNull.Value)
			{
				PCT0060013 = (int?)reader[210];
			}
			if(reader[211] != DBNull.Value)
			{
				PCT0060014 = (int?)reader[211];
			}
			if(reader[212] != DBNull.Value)
			{
				PCT0060015 = (int?)reader[212];
			}
			if(reader[213] != DBNull.Value)
			{
				PCT0060016 = (int?)reader[213];
			}
			if(reader[214] != DBNull.Value)
			{
				PCT0060017 = (int?)reader[214];
			}
			if(reader[215] != DBNull.Value)
			{
				PCT0060018 = (int?)reader[215];
			}
			if(reader[216] != DBNull.Value)
			{
				PCT0060019 = (int?)reader[216];
			}
			if(reader[217] != DBNull.Value)
			{
				PCT0060020 = (int?)reader[217];
			}
			if(reader[218] != DBNull.Value)
			{
				PCT0060021 = (int?)reader[218];
			}
			if(reader[219] != DBNull.Value)
			{
				PCT0060022 = (int?)reader[219];
			}
			if(reader[220] != DBNull.Value)
			{
				PCT0070001 = (int?)reader[220];
			}
			if(reader[221] != DBNull.Value)
			{
				PCT0070002 = (int?)reader[221];
			}
			if(reader[222] != DBNull.Value)
			{
				PCT0070003 = (int?)reader[222];
			}
			if(reader[223] != DBNull.Value)
			{
				PCT0070004 = (int?)reader[223];
			}
			if(reader[224] != DBNull.Value)
			{
				PCT0070005 = (int?)reader[224];
			}
			if(reader[225] != DBNull.Value)
			{
				PCT0070006 = (int?)reader[225];
			}
			if(reader[226] != DBNull.Value)
			{
				PCT0070007 = (int?)reader[226];
			}
			if(reader[227] != DBNull.Value)
			{
				PCT0070008 = (int?)reader[227];
			}
			if(reader[228] != DBNull.Value)
			{
				PCT0070009 = (int?)reader[228];
			}
			if(reader[229] != DBNull.Value)
			{
				PCT0070010 = (int?)reader[229];
			}
			if(reader[230] != DBNull.Value)
			{
				PCT0070011 = (int?)reader[230];
			}
			if(reader[231] != DBNull.Value)
			{
				PCT0070012 = (int?)reader[231];
			}
			if(reader[232] != DBNull.Value)
			{
				PCT0070013 = (int?)reader[232];
			}
			if(reader[233] != DBNull.Value)
			{
				PCT0070014 = (int?)reader[233];
			}
			if(reader[234] != DBNull.Value)
			{
				PCT0070015 = (int?)reader[234];
			}
			if(reader[235] != DBNull.Value)
			{
				PCT0070016 = (int?)reader[235];
			}
			if(reader[236] != DBNull.Value)
			{
				PCT0070017 = (int?)reader[236];
			}
			if(reader[237] != DBNull.Value)
			{
				PCT0070018 = (int?)reader[237];
			}
			if(reader[238] != DBNull.Value)
			{
				PCT0070019 = (int?)reader[238];
			}
			if(reader[239] != DBNull.Value)
			{
				PCT0070020 = (int?)reader[239];
			}
			if(reader[240] != DBNull.Value)
			{
				PCT0070021 = (int?)reader[240];
			}
			if(reader[241] != DBNull.Value)
			{
				PCT0070022 = (int?)reader[241];
			}
			if(reader[242] != DBNull.Value)
			{
				PCT0080001 = (int?)reader[242];
			}
			if(reader[243] != DBNull.Value)
			{
				PCT0080002 = (int?)reader[243];
			}
			if(reader[244] != DBNull.Value)
			{
				PCT0080003 = (int?)reader[244];
			}
			if(reader[245] != DBNull.Value)
			{
				PCT0080004 = (int?)reader[245];
			}
			if(reader[246] != DBNull.Value)
			{
				PCT0080005 = (int?)reader[246];
			}
			if(reader[247] != DBNull.Value)
			{
				PCT0080006 = (int?)reader[247];
			}
			if(reader[248] != DBNull.Value)
			{
				PCT0080007 = (int?)reader[248];
			}
			if(reader[249] != DBNull.Value)
			{
				PCT0080008 = (int?)reader[249];
			}
			if(reader[250] != DBNull.Value)
			{
				PCT0080009 = (int?)reader[250];
			}
			if(reader[251] != DBNull.Value)
			{
				PCT0080010 = (int?)reader[251];
			}
			if(reader[252] != DBNull.Value)
			{
				PCT0080011 = (int?)reader[252];
			}
			if(reader[253] != DBNull.Value)
			{
				PCT0080012 = (int?)reader[253];
			}
			if(reader[254] != DBNull.Value)
			{
				PCT0080013 = (int?)reader[254];
			}
			if(reader[255] != DBNull.Value)
			{
				PCT0080014 = (int?)reader[255];
			}
		}
		#endregion Constructors
	}
}
