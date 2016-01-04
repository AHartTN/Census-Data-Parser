namespace CensusDataParser.Generated.Binding
{
	#region Using Directives
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.Data.OleDb;
	#endregion Using Directives

	public class SF1CongressionalDistricts113_SF1_00018 : BaseModel
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
		public int? PCT0130001 { get; set; }

		[Display(Name = "Male:", ShortName = "Male:", Order = 6)]
		public int? PCT0130002 { get; set; }

		[Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 7)]
		public int? PCT0130003 { get; set; }

		[Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 8)]
		public int? PCT0130004 { get; set; }

		[Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 9)]
		public int? PCT0130005 { get; set; }

		[Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 10)]
		public int? PCT0130006 { get; set; }

		[Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 11)]
		public int? PCT0130007 { get; set; }

		[Display(Name = "20 years", ShortName = "20 years", Order = 12)]
		public int? PCT0130008 { get; set; }

		[Display(Name = "21 years", ShortName = "21 years", Order = 13)]
		public int? PCT0130009 { get; set; }

		[Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 14)]
		public int? PCT0130010 { get; set; }

		[Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 15)]
		public int? PCT0130011 { get; set; }

		[Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 16)]
		public int? PCT0130012 { get; set; }

		[Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 17)]
		public int? PCT0130013 { get; set; }

		[Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 18)]
		public int? PCT0130014 { get; set; }

		[Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 19)]
		public int? PCT0130015 { get; set; }

		[Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 20)]
		public int? PCT0130016 { get; set; }

		[Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 21)]
		public int? PCT0130017 { get; set; }

		[Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 22)]
		public int? PCT0130018 { get; set; }

		[Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 23)]
		public int? PCT0130019 { get; set; }

		[Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 24)]
		public int? PCT0130020 { get; set; }

		[Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 25)]
		public int? PCT0130021 { get; set; }

		[Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 26)]
		public int? PCT0130022 { get; set; }

		[Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 27)]
		public int? PCT0130023 { get; set; }

		[Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 28)]
		public int? PCT0130024 { get; set; }

		[Display(Name = "85 years and over", ShortName = "85 years and over", Order = 29)]
		public int? PCT0130025 { get; set; }

		[Display(Name = "Female:", ShortName = "Female:", Order = 30)]
		public int? PCT0130026 { get; set; }

		[Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 31)]
		public int? PCT0130027 { get; set; }

		[Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 32)]
		public int? PCT0130028 { get; set; }

		[Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 33)]
		public int? PCT0130029 { get; set; }

		[Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 34)]
		public int? PCT0130030 { get; set; }

		[Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 35)]
		public int? PCT0130031 { get; set; }

		[Display(Name = "20 years", ShortName = "20 years", Order = 36)]
		public int? PCT0130032 { get; set; }

		[Display(Name = "21 years", ShortName = "21 years", Order = 37)]
		public int? PCT0130033 { get; set; }

		[Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 38)]
		public int? PCT0130034 { get; set; }

		[Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 39)]
		public int? PCT0130035 { get; set; }

		[Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 40)]
		public int? PCT0130036 { get; set; }

		[Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 41)]
		public int? PCT0130037 { get; set; }

		[Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 42)]
		public int? PCT0130038 { get; set; }

		[Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 43)]
		public int? PCT0130039 { get; set; }

		[Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 44)]
		public int? PCT0130040 { get; set; }

		[Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 45)]
		public int? PCT0130041 { get; set; }

		[Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 46)]
		public int? PCT0130042 { get; set; }

		[Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 47)]
		public int? PCT0130043 { get; set; }

		[Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 48)]
		public int? PCT0130044 { get; set; }

		[Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 49)]
		public int? PCT0130045 { get; set; }

		[Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 50)]
		public int? PCT0130046 { get; set; }

		[Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 51)]
		public int? PCT0130047 { get; set; }

		[Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 52)]
		public int? PCT0130048 { get; set; }

		[Display(Name = "85 years and over", ShortName = "85 years and over", Order = 53)]
		public int? PCT0130049 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 54)]
		public int? PCT0140001 { get; set; }

		[Display(Name = "Household has three or more generations", ShortName = "Household has three or more generations", Order = 55)]
		public int? PCT0140002 { get; set; }

		[Display(Name = "Household does not have three or more generations", ShortName = "Household does not have three or more generations", Order = 56)]
		public int? PCT0140003 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 57)]
		public int? PCT0150001 { get; set; }

		[Display(Name = "Husband-wife households:", ShortName = "Husband-wife households:", Order = 58)]
		public int? PCT0150002 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 59)]
		public int? PCT0150003 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 60)]
		public int? PCT0150004 { get; set; }

		[Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 61)]
		public int? PCT0150005 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 62)]
		public int? PCT0150006 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 63)]
		public int? PCT0150007 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 64)]
		public int? PCT0150008 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 65)]
		public int? PCT0150009 { get; set; }

		[Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 66)]
		public int? PCT0150010 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 67)]
		public int? PCT0150011 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 68)]
		public int? PCT0150012 { get; set; }

		[Display(Name = "Unmarried-partner households:", ShortName = "Unmarried-partner households:", Order = 69)]
		public int? PCT0150013 { get; set; }

		[Display(Name = "Male householder and male partner:", ShortName = "Male householder and male partner:", Order = 70)]
		public int? PCT0150014 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 71)]
		public int? PCT0150015 { get; set; }

		[Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 72)]
		public int? PCT0150016 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 73)]
		public int? PCT0150017 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 74)]
		public int? PCT0150018 { get; set; }

		[Display(Name = "Male householder and female partner:", ShortName = "Male householder and female partner:", Order = 75)]
		public int? PCT0150019 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 76)]
		public int? PCT0150020 { get; set; }

		[Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 77)]
		public int? PCT0150021 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 78)]
		public int? PCT0150022 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 79)]
		public int? PCT0150023 { get; set; }

		[Display(Name = "Female householder and female partner:", ShortName = "Female householder and female partner:", Order = 80)]
		public int? PCT0150024 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 81)]
		public int? PCT0150025 { get; set; }

		[Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 82)]
		public int? PCT0150026 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 83)]
		public int? PCT0150027 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 84)]
		public int? PCT0150028 { get; set; }

		[Display(Name = "Female householder and male partner:", ShortName = "Female householder and male partner:", Order = 85)]
		public int? PCT0150029 { get; set; }

		[Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 86)]
		public int? PCT0150030 { get; set; }

		[Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 87)]
		public int? PCT0150031 { get; set; }

		[Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 88)]
		public int? PCT0150032 { get; set; }

		[Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 89)]
		public int? PCT0150033 { get; set; }

		[Display(Name = "All other households", ShortName = "All other households", Order = 90)]
		public int? PCT0150034 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 91)]
		public int? PCT0160001 { get; set; }

		[Display(Name = "Family households:", ShortName = "Family households:", Order = 92)]
		public int? PCT0160002 { get; set; }

		[Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 93)]
		public int? PCT0160003 { get; set; }

		[Display(Name = "With no children under 18 years", ShortName = "With no children under 18 years", Order = 94)]
		public int? PCT0160004 { get; set; }

		[Display(Name = "With one child under 18 years", ShortName = "With one child under 18 years", Order = 95)]
		public int? PCT0160005 { get; set; }

		[Display(Name = "With two children under 18 years", ShortName = "With two children under 18 years", Order = 96)]
		public int? PCT0160006 { get; set; }

		[Display(Name = "With three children under 18 years", ShortName = "With three children under 18 years", Order = 97)]
		public int? PCT0160007 { get; set; }

		[Display(Name = "With four or more children under 18 years", ShortName = "With four or more children under 18 years", Order = 98)]
		public int? PCT0160008 { get; set; }

		[Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 99)]
		public int? PCT0160009 { get; set; }

		[Display(Name = "With no children under 18 years", ShortName = "With no children under 18 years", Order = 100)]
		public int? PCT0160010 { get; set; }

		[Display(Name = "With one child under 18 years", ShortName = "With one child under 18 years", Order = 101)]
		public int? PCT0160011 { get; set; }

		[Display(Name = "With two children under 18 years", ShortName = "With two children under 18 years", Order = 102)]
		public int? PCT0160012 { get; set; }

		[Display(Name = "With three children under 18 years", ShortName = "With three children under 18 years", Order = 103)]
		public int? PCT0160013 { get; set; }

		[Display(Name = "With four or more children under 18 years", ShortName = "With four or more children under 18 years", Order = 104)]
		public int? PCT0160014 { get; set; }

		[Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 105)]
		public int? PCT0160015 { get; set; }

		[Display(Name = "With no children under 18 years", ShortName = "With no children under 18 years", Order = 106)]
		public int? PCT0160016 { get; set; }

		[Display(Name = "With one child under 18 years", ShortName = "With one child under 18 years", Order = 107)]
		public int? PCT0160017 { get; set; }

		[Display(Name = "With two children under 18 years", ShortName = "With two children under 18 years", Order = 108)]
		public int? PCT0160018 { get; set; }

		[Display(Name = "With three children under 18 years", ShortName = "With three children under 18 years", Order = 109)]
		public int? PCT0160019 { get; set; }

		[Display(Name = "With four or more children under 18 years", ShortName = "With four or more children under 18 years", Order = 110)]
		public int? PCT0160020 { get; set; }

		[Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 111)]
		public int? PCT0160021 { get; set; }

		[Display(Name = "With no children under 18 years", ShortName = "With no children under 18 years", Order = 112)]
		public int? PCT0160022 { get; set; }

		[Display(Name = "With one child under 18 years", ShortName = "With one child under 18 years", Order = 113)]
		public int? PCT0160023 { get; set; }

		[Display(Name = "With two children under 18 years", ShortName = "With two children under 18 years", Order = 114)]
		public int? PCT0160024 { get; set; }

		[Display(Name = "With three children under 18 years", ShortName = "With three children under 18 years", Order = 115)]
		public int? PCT0160025 { get; set; }

		[Display(Name = "With four or more children under 18 years", ShortName = "With four or more children under 18 years", Order = 116)]
		public int? PCT0160026 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 117)]
		public int? PCT0170001 { get; set; }

		[Display(Name = "Unmarried partner of householder present:", ShortName = "Unmarried partner of householder present:", Order = 118)]
		public int? PCT0170002 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 119)]
		public int? PCT0170003 { get; set; }

		[Display(Name = "In male householder and male partner households", ShortName = "In male householder and male partner households", Order = 120)]
		public int? PCT0170004 { get; set; }

		[Display(Name = "In male householder and female partner households", ShortName = "In male householder and female partner households", Order = 121)]
		public int? PCT0170005 { get; set; }

		[Display(Name = "In female householder and female partner households", ShortName = "In female householder and female partner households", Order = 122)]
		public int? PCT0170006 { get; set; }

		[Display(Name = "In female householder and male partner households", ShortName = "In female householder and male partner households", Order = 123)]
		public int? PCT0170007 { get; set; }

		[Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 124)]
		public int? PCT0170008 { get; set; }

		[Display(Name = "In male householder and male partner households", ShortName = "In male householder and male partner households", Order = 125)]
		public int? PCT0170009 { get; set; }

		[Display(Name = "In male householder and female partner households", ShortName = "In male householder and female partner households", Order = 126)]
		public int? PCT0170010 { get; set; }

		[Display(Name = "In female householder and female partner households", ShortName = "In female householder and female partner households", Order = 127)]
		public int? PCT0170011 { get; set; }

		[Display(Name = "In female householder and male partner households", ShortName = "In female householder and male partner households", Order = 128)]
		public int? PCT0170012 { get; set; }

		[Display(Name = "No unmarried partner of householder present:", ShortName = "No unmarried partner of householder present:", Order = 129)]
		public int? PCT0170013 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 130)]
		public int? PCT0170014 { get; set; }

		[Display(Name = "In husband-wife family households", ShortName = "In husband-wife family households", Order = 131)]
		public int? PCT0170015 { get; set; }

		[Display(Name = "In male householder, no wife present, family households", ShortName = "In male householder, no wife present, family households", Order = 132)]
		public int? PCT0170016 { get; set; }

		[Display(Name = "In female householder, no husband present, family households", ShortName = "In female householder, no husband present, family households", Order = 133)]
		public int? PCT0170017 { get; set; }

		[Display(Name = "In nonfamily households", ShortName = "In nonfamily households", Order = 134)]
		public int? PCT0170018 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 135)]
		public int? PCT0180001 { get; set; }

		[Display(Name = "Male householder:", ShortName = "Male householder:", Order = 136)]
		public int? PCT0180002 { get; set; }

		[Display(Name = "Living alone:", ShortName = "Living alone:", Order = 137)]
		public int? PCT0180003 { get; set; }

		[Display(Name = "Householder 15 to 64 years", ShortName = "Householder 15 to 64 years", Order = 138)]
		public int? PCT0180004 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 139)]
		public int? PCT0180005 { get; set; }

		[Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 140)]
		public int? PCT0180006 { get; set; }

		[Display(Name = "Householder 15 to 64 years", ShortName = "Householder 15 to 64 years", Order = 141)]
		public int? PCT0180007 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 142)]
		public int? PCT0180008 { get; set; }

		[Display(Name = "Female householder:", ShortName = "Female householder:", Order = 143)]
		public int? PCT0180009 { get; set; }

		[Display(Name = "Living alone:", ShortName = "Living alone:", Order = 144)]
		public int? PCT0180010 { get; set; }

		[Display(Name = "Householder 15 to 64 years", ShortName = "Householder 15 to 64 years", Order = 145)]
		public int? PCT0180011 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 146)]
		public int? PCT0180012 { get; set; }

		[Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 147)]
		public int? PCT0180013 { get; set; }

		[Display(Name = "Householder 15 to 64 years", ShortName = "Householder 15 to 64 years", Order = 148)]
		public int? PCT0180014 { get; set; }

		[Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 149)]
		public int? PCT0180015 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 150)]
		public int? PCT0190001 { get; set; }

		[Display(Name = "In family households:", ShortName = "In family households:", Order = 151)]
		public int? PCT0190002 { get; set; }

		[Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 152)]
		public int? PCT0190003 { get; set; }

		[Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 153)]
		public int? PCT0190004 { get; set; }

		[Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 154)]
		public int? PCT0190005 { get; set; }

		[Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 155)]
		public int? PCT0190006 { get; set; }

		[Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 156)]
		public int? PCT0190007 { get; set; }

		[Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 157)]
		public int? PCT0190008 { get; set; }

		[Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 158)]
		public int? PCT0190009 { get; set; }

		[Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 159)]
		public int? PCT0190010 { get; set; }

		[Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 160)]
		public int? PCT0190011 { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 161)]
		public int? PCT0200001 { get; set; }

		[Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 162)]
		public int? PCT0200002 { get; set; }

		[Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 163)]
		public int? PCT0200003 { get; set; }

		[Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 164)]
		public int? PCT0200004 { get; set; }

		[Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 165)]
		public int? PCT0200005 { get; set; }

		[Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 166)]
		public int? PCT0200006 { get; set; }

		[Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 167)]
		public int? PCT0200007 { get; set; }

		[Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 168)]
		public int? PCT0200008 { get; set; }

		[Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 169)]
		public int? PCT0200009 { get; set; }

		[Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 170)]
		public int? PCT0200010 { get; set; }

		[Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 171)]
		public int? PCT0200011 { get; set; }

		[Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 172)]
		public int? PCT0200012 { get; set; }

		[Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 173)]
		public int? PCT0200013 { get; set; }

		[Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 174)]
		public int? PCT0200014 { get; set; }

		[Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 175)]
		public int? PCT0200015 { get; set; }

		[Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 176)]
		public int? PCT0200016 { get; set; }

		[Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 177)]
		public int? PCT0200017 { get; set; }

		[Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 178)]
		public int? PCT0200018 { get; set; }

		[Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 179)]
		public int? PCT0200019 { get; set; }

		[Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 180)]
		public int? PCT0200020 { get; set; }

		[Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 181)]
		public int? PCT0200021 { get; set; }

		[Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 182)]
		public int? PCT0200022 { get; set; }

		[Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 183)]
		public int? PCT0200023 { get; set; }

		[Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 184)]
		public int? PCT0200024 { get; set; }

		[Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 185)]
		public int? PCT0200025 { get; set; }

		[Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 186)]
		public int? PCT0200026 { get; set; }

		[Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 187)]
		public int? PCT0200027 { get; set; }

		[Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 188)]
		public int? PCT0200028 { get; set; }

		[Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 189)]
		public int? PCT0200029 { get; set; }

		[Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 190)]
		public int? PCT0200030 { get; set; }

		[Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 191)]
		public int? PCT0200031 { get; set; }

		[Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 192)]
		public int? PCT0200032 { get; set; }
		#endregion Properties

		#region Constructors
		public SF1CongressionalDistricts113_SF1_00018(string csvLine) : base(csvLine) { }

		public SF1CongressionalDistricts113_SF1_00018(string[] values) : base(values) { }

		public SF1CongressionalDistricts113_SF1_00018(OleDbDataReader reader)
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
				PCT0130001 = (int?)reader[5];
			}
			if (reader[6] != DBNull.Value)
			{
				PCT0130002 = (int?)reader[6];
			}
			if (reader[7] != DBNull.Value)
			{
				PCT0130003 = (int?)reader[7];
			}
			if (reader[8] != DBNull.Value)
			{
				PCT0130004 = (int?)reader[8];
			}
			if (reader[9] != DBNull.Value)
			{
				PCT0130005 = (int?)reader[9];
			}
			if (reader[10] != DBNull.Value)
			{
				PCT0130006 = (int?)reader[10];
			}
			if (reader[11] != DBNull.Value)
			{
				PCT0130007 = (int?)reader[11];
			}
			if (reader[12] != DBNull.Value)
			{
				PCT0130008 = (int?)reader[12];
			}
			if (reader[13] != DBNull.Value)
			{
				PCT0130009 = (int?)reader[13];
			}
			if (reader[14] != DBNull.Value)
			{
				PCT0130010 = (int?)reader[14];
			}
			if (reader[15] != DBNull.Value)
			{
				PCT0130011 = (int?)reader[15];
			}
			if (reader[16] != DBNull.Value)
			{
				PCT0130012 = (int?)reader[16];
			}
			if (reader[17] != DBNull.Value)
			{
				PCT0130013 = (int?)reader[17];
			}
			if (reader[18] != DBNull.Value)
			{
				PCT0130014 = (int?)reader[18];
			}
			if (reader[19] != DBNull.Value)
			{
				PCT0130015 = (int?)reader[19];
			}
			if (reader[20] != DBNull.Value)
			{
				PCT0130016 = (int?)reader[20];
			}
			if (reader[21] != DBNull.Value)
			{
				PCT0130017 = (int?)reader[21];
			}
			if (reader[22] != DBNull.Value)
			{
				PCT0130018 = (int?)reader[22];
			}
			if (reader[23] != DBNull.Value)
			{
				PCT0130019 = (int?)reader[23];
			}
			if (reader[24] != DBNull.Value)
			{
				PCT0130020 = (int?)reader[24];
			}
			if (reader[25] != DBNull.Value)
			{
				PCT0130021 = (int?)reader[25];
			}
			if (reader[26] != DBNull.Value)
			{
				PCT0130022 = (int?)reader[26];
			}
			if (reader[27] != DBNull.Value)
			{
				PCT0130023 = (int?)reader[27];
			}
			if (reader[28] != DBNull.Value)
			{
				PCT0130024 = (int?)reader[28];
			}
			if (reader[29] != DBNull.Value)
			{
				PCT0130025 = (int?)reader[29];
			}
			if (reader[30] != DBNull.Value)
			{
				PCT0130026 = (int?)reader[30];
			}
			if (reader[31] != DBNull.Value)
			{
				PCT0130027 = (int?)reader[31];
			}
			if (reader[32] != DBNull.Value)
			{
				PCT0130028 = (int?)reader[32];
			}
			if (reader[33] != DBNull.Value)
			{
				PCT0130029 = (int?)reader[33];
			}
			if (reader[34] != DBNull.Value)
			{
				PCT0130030 = (int?)reader[34];
			}
			if (reader[35] != DBNull.Value)
			{
				PCT0130031 = (int?)reader[35];
			}
			if (reader[36] != DBNull.Value)
			{
				PCT0130032 = (int?)reader[36];
			}
			if (reader[37] != DBNull.Value)
			{
				PCT0130033 = (int?)reader[37];
			}
			if (reader[38] != DBNull.Value)
			{
				PCT0130034 = (int?)reader[38];
			}
			if (reader[39] != DBNull.Value)
			{
				PCT0130035 = (int?)reader[39];
			}
			if (reader[40] != DBNull.Value)
			{
				PCT0130036 = (int?)reader[40];
			}
			if (reader[41] != DBNull.Value)
			{
				PCT0130037 = (int?)reader[41];
			}
			if (reader[42] != DBNull.Value)
			{
				PCT0130038 = (int?)reader[42];
			}
			if (reader[43] != DBNull.Value)
			{
				PCT0130039 = (int?)reader[43];
			}
			if (reader[44] != DBNull.Value)
			{
				PCT0130040 = (int?)reader[44];
			}
			if (reader[45] != DBNull.Value)
			{
				PCT0130041 = (int?)reader[45];
			}
			if (reader[46] != DBNull.Value)
			{
				PCT0130042 = (int?)reader[46];
			}
			if (reader[47] != DBNull.Value)
			{
				PCT0130043 = (int?)reader[47];
			}
			if (reader[48] != DBNull.Value)
			{
				PCT0130044 = (int?)reader[48];
			}
			if (reader[49] != DBNull.Value)
			{
				PCT0130045 = (int?)reader[49];
			}
			if (reader[50] != DBNull.Value)
			{
				PCT0130046 = (int?)reader[50];
			}
			if (reader[51] != DBNull.Value)
			{
				PCT0130047 = (int?)reader[51];
			}
			if (reader[52] != DBNull.Value)
			{
				PCT0130048 = (int?)reader[52];
			}
			if (reader[53] != DBNull.Value)
			{
				PCT0130049 = (int?)reader[53];
			}
			if (reader[54] != DBNull.Value)
			{
				PCT0140001 = (int?)reader[54];
			}
			if (reader[55] != DBNull.Value)
			{
				PCT0140002 = (int?)reader[55];
			}
			if (reader[56] != DBNull.Value)
			{
				PCT0140003 = (int?)reader[56];
			}
			if (reader[57] != DBNull.Value)
			{
				PCT0150001 = (int?)reader[57];
			}
			if (reader[58] != DBNull.Value)
			{
				PCT0150002 = (int?)reader[58];
			}
			if (reader[59] != DBNull.Value)
			{
				PCT0150003 = (int?)reader[59];
			}
			if (reader[60] != DBNull.Value)
			{
				PCT0150004 = (int?)reader[60];
			}
			if (reader[61] != DBNull.Value)
			{
				PCT0150005 = (int?)reader[61];
			}
			if (reader[62] != DBNull.Value)
			{
				PCT0150006 = (int?)reader[62];
			}
			if (reader[63] != DBNull.Value)
			{
				PCT0150007 = (int?)reader[63];
			}
			if (reader[64] != DBNull.Value)
			{
				PCT0150008 = (int?)reader[64];
			}
			if (reader[65] != DBNull.Value)
			{
				PCT0150009 = (int?)reader[65];
			}
			if (reader[66] != DBNull.Value)
			{
				PCT0150010 = (int?)reader[66];
			}
			if (reader[67] != DBNull.Value)
			{
				PCT0150011 = (int?)reader[67];
			}
			if (reader[68] != DBNull.Value)
			{
				PCT0150012 = (int?)reader[68];
			}
			if (reader[69] != DBNull.Value)
			{
				PCT0150013 = (int?)reader[69];
			}
			if (reader[70] != DBNull.Value)
			{
				PCT0150014 = (int?)reader[70];
			}
			if (reader[71] != DBNull.Value)
			{
				PCT0150015 = (int?)reader[71];
			}
			if (reader[72] != DBNull.Value)
			{
				PCT0150016 = (int?)reader[72];
			}
			if (reader[73] != DBNull.Value)
			{
				PCT0150017 = (int?)reader[73];
			}
			if (reader[74] != DBNull.Value)
			{
				PCT0150018 = (int?)reader[74];
			}
			if (reader[75] != DBNull.Value)
			{
				PCT0150019 = (int?)reader[75];
			}
			if (reader[76] != DBNull.Value)
			{
				PCT0150020 = (int?)reader[76];
			}
			if (reader[77] != DBNull.Value)
			{
				PCT0150021 = (int?)reader[77];
			}
			if (reader[78] != DBNull.Value)
			{
				PCT0150022 = (int?)reader[78];
			}
			if (reader[79] != DBNull.Value)
			{
				PCT0150023 = (int?)reader[79];
			}
			if (reader[80] != DBNull.Value)
			{
				PCT0150024 = (int?)reader[80];
			}
			if (reader[81] != DBNull.Value)
			{
				PCT0150025 = (int?)reader[81];
			}
			if (reader[82] != DBNull.Value)
			{
				PCT0150026 = (int?)reader[82];
			}
			if (reader[83] != DBNull.Value)
			{
				PCT0150027 = (int?)reader[83];
			}
			if (reader[84] != DBNull.Value)
			{
				PCT0150028 = (int?)reader[84];
			}
			if (reader[85] != DBNull.Value)
			{
				PCT0150029 = (int?)reader[85];
			}
			if (reader[86] != DBNull.Value)
			{
				PCT0150030 = (int?)reader[86];
			}
			if (reader[87] != DBNull.Value)
			{
				PCT0150031 = (int?)reader[87];
			}
			if (reader[88] != DBNull.Value)
			{
				PCT0150032 = (int?)reader[88];
			}
			if (reader[89] != DBNull.Value)
			{
				PCT0150033 = (int?)reader[89];
			}
			if (reader[90] != DBNull.Value)
			{
				PCT0150034 = (int?)reader[90];
			}
			if (reader[91] != DBNull.Value)
			{
				PCT0160001 = (int?)reader[91];
			}
			if (reader[92] != DBNull.Value)
			{
				PCT0160002 = (int?)reader[92];
			}
			if (reader[93] != DBNull.Value)
			{
				PCT0160003 = (int?)reader[93];
			}
			if (reader[94] != DBNull.Value)
			{
				PCT0160004 = (int?)reader[94];
			}
			if (reader[95] != DBNull.Value)
			{
				PCT0160005 = (int?)reader[95];
			}
			if (reader[96] != DBNull.Value)
			{
				PCT0160006 = (int?)reader[96];
			}
			if (reader[97] != DBNull.Value)
			{
				PCT0160007 = (int?)reader[97];
			}
			if (reader[98] != DBNull.Value)
			{
				PCT0160008 = (int?)reader[98];
			}
			if (reader[99] != DBNull.Value)
			{
				PCT0160009 = (int?)reader[99];
			}
			if (reader[100] != DBNull.Value)
			{
				PCT0160010 = (int?)reader[100];
			}
			if (reader[101] != DBNull.Value)
			{
				PCT0160011 = (int?)reader[101];
			}
			if (reader[102] != DBNull.Value)
			{
				PCT0160012 = (int?)reader[102];
			}
			if (reader[103] != DBNull.Value)
			{
				PCT0160013 = (int?)reader[103];
			}
			if (reader[104] != DBNull.Value)
			{
				PCT0160014 = (int?)reader[104];
			}
			if (reader[105] != DBNull.Value)
			{
				PCT0160015 = (int?)reader[105];
			}
			if (reader[106] != DBNull.Value)
			{
				PCT0160016 = (int?)reader[106];
			}
			if (reader[107] != DBNull.Value)
			{
				PCT0160017 = (int?)reader[107];
			}
			if (reader[108] != DBNull.Value)
			{
				PCT0160018 = (int?)reader[108];
			}
			if (reader[109] != DBNull.Value)
			{
				PCT0160019 = (int?)reader[109];
			}
			if (reader[110] != DBNull.Value)
			{
				PCT0160020 = (int?)reader[110];
			}
			if (reader[111] != DBNull.Value)
			{
				PCT0160021 = (int?)reader[111];
			}
			if (reader[112] != DBNull.Value)
			{
				PCT0160022 = (int?)reader[112];
			}
			if (reader[113] != DBNull.Value)
			{
				PCT0160023 = (int?)reader[113];
			}
			if (reader[114] != DBNull.Value)
			{
				PCT0160024 = (int?)reader[114];
			}
			if (reader[115] != DBNull.Value)
			{
				PCT0160025 = (int?)reader[115];
			}
			if (reader[116] != DBNull.Value)
			{
				PCT0160026 = (int?)reader[116];
			}
			if (reader[117] != DBNull.Value)
			{
				PCT0170001 = (int?)reader[117];
			}
			if (reader[118] != DBNull.Value)
			{
				PCT0170002 = (int?)reader[118];
			}
			if (reader[119] != DBNull.Value)
			{
				PCT0170003 = (int?)reader[119];
			}
			if (reader[120] != DBNull.Value)
			{
				PCT0170004 = (int?)reader[120];
			}
			if (reader[121] != DBNull.Value)
			{
				PCT0170005 = (int?)reader[121];
			}
			if (reader[122] != DBNull.Value)
			{
				PCT0170006 = (int?)reader[122];
			}
			if (reader[123] != DBNull.Value)
			{
				PCT0170007 = (int?)reader[123];
			}
			if (reader[124] != DBNull.Value)
			{
				PCT0170008 = (int?)reader[124];
			}
			if (reader[125] != DBNull.Value)
			{
				PCT0170009 = (int?)reader[125];
			}
			if (reader[126] != DBNull.Value)
			{
				PCT0170010 = (int?)reader[126];
			}
			if (reader[127] != DBNull.Value)
			{
				PCT0170011 = (int?)reader[127];
			}
			if (reader[128] != DBNull.Value)
			{
				PCT0170012 = (int?)reader[128];
			}
			if (reader[129] != DBNull.Value)
			{
				PCT0170013 = (int?)reader[129];
			}
			if (reader[130] != DBNull.Value)
			{
				PCT0170014 = (int?)reader[130];
			}
			if (reader[131] != DBNull.Value)
			{
				PCT0170015 = (int?)reader[131];
			}
			if (reader[132] != DBNull.Value)
			{
				PCT0170016 = (int?)reader[132];
			}
			if (reader[133] != DBNull.Value)
			{
				PCT0170017 = (int?)reader[133];
			}
			if (reader[134] != DBNull.Value)
			{
				PCT0170018 = (int?)reader[134];
			}
			if (reader[135] != DBNull.Value)
			{
				PCT0180001 = (int?)reader[135];
			}
			if (reader[136] != DBNull.Value)
			{
				PCT0180002 = (int?)reader[136];
			}
			if (reader[137] != DBNull.Value)
			{
				PCT0180003 = (int?)reader[137];
			}
			if (reader[138] != DBNull.Value)
			{
				PCT0180004 = (int?)reader[138];
			}
			if (reader[139] != DBNull.Value)
			{
				PCT0180005 = (int?)reader[139];
			}
			if (reader[140] != DBNull.Value)
			{
				PCT0180006 = (int?)reader[140];
			}
			if (reader[141] != DBNull.Value)
			{
				PCT0180007 = (int?)reader[141];
			}
			if (reader[142] != DBNull.Value)
			{
				PCT0180008 = (int?)reader[142];
			}
			if (reader[143] != DBNull.Value)
			{
				PCT0180009 = (int?)reader[143];
			}
			if (reader[144] != DBNull.Value)
			{
				PCT0180010 = (int?)reader[144];
			}
			if (reader[145] != DBNull.Value)
			{
				PCT0180011 = (int?)reader[145];
			}
			if (reader[146] != DBNull.Value)
			{
				PCT0180012 = (int?)reader[146];
			}
			if (reader[147] != DBNull.Value)
			{
				PCT0180013 = (int?)reader[147];
			}
			if (reader[148] != DBNull.Value)
			{
				PCT0180014 = (int?)reader[148];
			}
			if (reader[149] != DBNull.Value)
			{
				PCT0180015 = (int?)reader[149];
			}
			if (reader[150] != DBNull.Value)
			{
				PCT0190001 = (int?)reader[150];
			}
			if (reader[151] != DBNull.Value)
			{
				PCT0190002 = (int?)reader[151];
			}
			if (reader[152] != DBNull.Value)
			{
				PCT0190003 = (int?)reader[152];
			}
			if (reader[153] != DBNull.Value)
			{
				PCT0190004 = (int?)reader[153];
			}
			if (reader[154] != DBNull.Value)
			{
				PCT0190005 = (int?)reader[154];
			}
			if (reader[155] != DBNull.Value)
			{
				PCT0190006 = (int?)reader[155];
			}
			if (reader[156] != DBNull.Value)
			{
				PCT0190007 = (int?)reader[156];
			}
			if (reader[157] != DBNull.Value)
			{
				PCT0190008 = (int?)reader[157];
			}
			if (reader[158] != DBNull.Value)
			{
				PCT0190009 = (int?)reader[158];
			}
			if (reader[159] != DBNull.Value)
			{
				PCT0190010 = (int?)reader[159];
			}
			if (reader[160] != DBNull.Value)
			{
				PCT0190011 = (int?)reader[160];
			}
			if (reader[161] != DBNull.Value)
			{
				PCT0200001 = (int?)reader[161];
			}
			if (reader[162] != DBNull.Value)
			{
				PCT0200002 = (int?)reader[162];
			}
			if (reader[163] != DBNull.Value)
			{
				PCT0200003 = (int?)reader[163];
			}
			if (reader[164] != DBNull.Value)
			{
				PCT0200004 = (int?)reader[164];
			}
			if (reader[165] != DBNull.Value)
			{
				PCT0200005 = (int?)reader[165];
			}
			if (reader[166] != DBNull.Value)
			{
				PCT0200006 = (int?)reader[166];
			}
			if (reader[167] != DBNull.Value)
			{
				PCT0200007 = (int?)reader[167];
			}
			if (reader[168] != DBNull.Value)
			{
				PCT0200008 = (int?)reader[168];
			}
			if (reader[169] != DBNull.Value)
			{
				PCT0200009 = (int?)reader[169];
			}
			if (reader[170] != DBNull.Value)
			{
				PCT0200010 = (int?)reader[170];
			}
			if (reader[171] != DBNull.Value)
			{
				PCT0200011 = (int?)reader[171];
			}
			if (reader[172] != DBNull.Value)
			{
				PCT0200012 = (int?)reader[172];
			}
			if (reader[173] != DBNull.Value)
			{
				PCT0200013 = (int?)reader[173];
			}
			if (reader[174] != DBNull.Value)
			{
				PCT0200014 = (int?)reader[174];
			}
			if (reader[175] != DBNull.Value)
			{
				PCT0200015 = (int?)reader[175];
			}
			if (reader[176] != DBNull.Value)
			{
				PCT0200016 = (int?)reader[176];
			}
			if (reader[177] != DBNull.Value)
			{
				PCT0200017 = (int?)reader[177];
			}
			if (reader[178] != DBNull.Value)
			{
				PCT0200018 = (int?)reader[178];
			}
			if (reader[179] != DBNull.Value)
			{
				PCT0200019 = (int?)reader[179];
			}
			if (reader[180] != DBNull.Value)
			{
				PCT0200020 = (int?)reader[180];
			}
			if (reader[181] != DBNull.Value)
			{
				PCT0200021 = (int?)reader[181];
			}
			if (reader[182] != DBNull.Value)
			{
				PCT0200022 = (int?)reader[182];
			}
			if (reader[183] != DBNull.Value)
			{
				PCT0200023 = (int?)reader[183];
			}
			if (reader[184] != DBNull.Value)
			{
				PCT0200024 = (int?)reader[184];
			}
			if (reader[185] != DBNull.Value)
			{
				PCT0200025 = (int?)reader[185];
			}
			if (reader[186] != DBNull.Value)
			{
				PCT0200026 = (int?)reader[186];
			}
			if (reader[187] != DBNull.Value)
			{
				PCT0200027 = (int?)reader[187];
			}
			if (reader[188] != DBNull.Value)
			{
				PCT0200028 = (int?)reader[188];
			}
			if (reader[189] != DBNull.Value)
			{
				PCT0200029 = (int?)reader[189];
			}
			if (reader[190] != DBNull.Value)
			{
				PCT0200030 = (int?)reader[190];
			}
			if (reader[191] != DBNull.Value)
			{
				PCT0200031 = (int?)reader[191];
			}
			if (reader[192] != DBNull.Value)
			{
				PCT0200032 = (int?)reader[192];
			}
		}
		#endregion Constructors
	}
}
