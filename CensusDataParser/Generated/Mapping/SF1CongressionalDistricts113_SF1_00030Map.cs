namespace CensusDataParser.Generated.Mapping
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

	public class SF1CongressionalDistricts113_SF1_00030Map : EntityTypeConfiguration<SF1CongressionalDistricts113_SF1_00030>
	{
		public SF1CongressionalDistricts113_SF1_00030Map()
		{
			ToTable("SF1_00030", "SF1CongressionalDistricts113");

			HasKey(k => new {k.FILEID, k.STUSAB, k.CHARITER, k.CIFSN, k.LOGRECNO});

			Property(p => p.FILEID)
				.HasColumnName("FILEID")
				.HasColumnOrder(0)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(255)
				.HasParameterName("FILEID")
				.IsRequired();

			Property(p => p.STUSAB)
				.HasColumnName("STUSAB")
				.HasColumnOrder(1)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(255)
				.HasParameterName("STUSAB")
				.IsRequired();

			Property(p => p.CHARITER)
				.HasColumnName("CHARITER")
				.HasColumnOrder(2)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(255)
				.HasParameterName("CHARITER")
				.IsRequired();

			Property(p => p.CIFSN)
				.HasColumnName("CIFSN")
				.HasColumnOrder(3)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(255)
				.HasParameterName("CIFSN")
				.IsRequired();

			Property(p => p.LOGRECNO)
				.HasColumnName("LOGRECNO")
				.HasColumnOrder(4)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("LOGRECNO")
				.IsRequired();

			Property(p => p.PCT012K001)
				.HasColumnName("PCT012K001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K001")
				.IsOptional();

			Property(p => p.PCT012K002)
				.HasColumnName("PCT012K002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K002")
				.IsOptional();

			Property(p => p.PCT012K003)
				.HasColumnName("PCT012K003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K003")
				.IsOptional();

			Property(p => p.PCT012K004)
				.HasColumnName("PCT012K004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K004")
				.IsOptional();

			Property(p => p.PCT012K005)
				.HasColumnName("PCT012K005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K005")
				.IsOptional();

			Property(p => p.PCT012K006)
				.HasColumnName("PCT012K006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K006")
				.IsOptional();

			Property(p => p.PCT012K007)
				.HasColumnName("PCT012K007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K007")
				.IsOptional();

			Property(p => p.PCT012K008)
				.HasColumnName("PCT012K008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K008")
				.IsOptional();

			Property(p => p.PCT012K009)
				.HasColumnName("PCT012K009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K009")
				.IsOptional();

			Property(p => p.PCT012K010)
				.HasColumnName("PCT012K010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K010")
				.IsOptional();

			Property(p => p.PCT012K011)
				.HasColumnName("PCT012K011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K011")
				.IsOptional();

			Property(p => p.PCT012K012)
				.HasColumnName("PCT012K012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K012")
				.IsOptional();

			Property(p => p.PCT012K013)
				.HasColumnName("PCT012K013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K013")
				.IsOptional();

			Property(p => p.PCT012K014)
				.HasColumnName("PCT012K014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K014")
				.IsOptional();

			Property(p => p.PCT012K015)
				.HasColumnName("PCT012K015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K015")
				.IsOptional();

			Property(p => p.PCT012K016)
				.HasColumnName("PCT012K016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K016")
				.IsOptional();

			Property(p => p.PCT012K017)
				.HasColumnName("PCT012K017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K017")
				.IsOptional();

			Property(p => p.PCT012K018)
				.HasColumnName("PCT012K018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K018")
				.IsOptional();

			Property(p => p.PCT012K019)
				.HasColumnName("PCT012K019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K019")
				.IsOptional();

			Property(p => p.PCT012K020)
				.HasColumnName("PCT012K020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K020")
				.IsOptional();

			Property(p => p.PCT012K021)
				.HasColumnName("PCT012K021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K021")
				.IsOptional();

			Property(p => p.PCT012K022)
				.HasColumnName("PCT012K022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K022")
				.IsOptional();

			Property(p => p.PCT012K023)
				.HasColumnName("PCT012K023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K023")
				.IsOptional();

			Property(p => p.PCT012K024)
				.HasColumnName("PCT012K024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K024")
				.IsOptional();

			Property(p => p.PCT012K025)
				.HasColumnName("PCT012K025")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K025")
				.IsOptional();

			Property(p => p.PCT012K026)
				.HasColumnName("PCT012K026")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K026")
				.IsOptional();

			Property(p => p.PCT012K027)
				.HasColumnName("PCT012K027")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K027")
				.IsOptional();

			Property(p => p.PCT012K028)
				.HasColumnName("PCT012K028")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K028")
				.IsOptional();

			Property(p => p.PCT012K029)
				.HasColumnName("PCT012K029")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K029")
				.IsOptional();

			Property(p => p.PCT012K030)
				.HasColumnName("PCT012K030")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K030")
				.IsOptional();

			Property(p => p.PCT012K031)
				.HasColumnName("PCT012K031")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K031")
				.IsOptional();

			Property(p => p.PCT012K032)
				.HasColumnName("PCT012K032")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K032")
				.IsOptional();

			Property(p => p.PCT012K033)
				.HasColumnName("PCT012K033")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K033")
				.IsOptional();

			Property(p => p.PCT012K034)
				.HasColumnName("PCT012K034")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K034")
				.IsOptional();

			Property(p => p.PCT012K035)
				.HasColumnName("PCT012K035")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K035")
				.IsOptional();

			Property(p => p.PCT012K036)
				.HasColumnName("PCT012K036")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K036")
				.IsOptional();

			Property(p => p.PCT012K037)
				.HasColumnName("PCT012K037")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K037")
				.IsOptional();

			Property(p => p.PCT012K038)
				.HasColumnName("PCT012K038")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K038")
				.IsOptional();

			Property(p => p.PCT012K039)
				.HasColumnName("PCT012K039")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K039")
				.IsOptional();

			Property(p => p.PCT012K040)
				.HasColumnName("PCT012K040")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K040")
				.IsOptional();

			Property(p => p.PCT012K041)
				.HasColumnName("PCT012K041")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K041")
				.IsOptional();

			Property(p => p.PCT012K042)
				.HasColumnName("PCT012K042")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K042")
				.IsOptional();

			Property(p => p.PCT012K043)
				.HasColumnName("PCT012K043")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K043")
				.IsOptional();

			Property(p => p.PCT012K044)
				.HasColumnName("PCT012K044")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K044")
				.IsOptional();

			Property(p => p.PCT012K045)
				.HasColumnName("PCT012K045")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K045")
				.IsOptional();

			Property(p => p.PCT012K046)
				.HasColumnName("PCT012K046")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K046")
				.IsOptional();

			Property(p => p.PCT012K047)
				.HasColumnName("PCT012K047")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K047")
				.IsOptional();

			Property(p => p.PCT012K048)
				.HasColumnName("PCT012K048")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K048")
				.IsOptional();

			Property(p => p.PCT012K049)
				.HasColumnName("PCT012K049")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K049")
				.IsOptional();

			Property(p => p.PCT012K050)
				.HasColumnName("PCT012K050")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K050")
				.IsOptional();

			Property(p => p.PCT012K051)
				.HasColumnName("PCT012K051")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K051")
				.IsOptional();

			Property(p => p.PCT012K052)
				.HasColumnName("PCT012K052")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K052")
				.IsOptional();

			Property(p => p.PCT012K053)
				.HasColumnName("PCT012K053")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K053")
				.IsOptional();

			Property(p => p.PCT012K054)
				.HasColumnName("PCT012K054")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K054")
				.IsOptional();

			Property(p => p.PCT012K055)
				.HasColumnName("PCT012K055")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K055")
				.IsOptional();

			Property(p => p.PCT012K056)
				.HasColumnName("PCT012K056")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K056")
				.IsOptional();

			Property(p => p.PCT012K057)
				.HasColumnName("PCT012K057")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K057")
				.IsOptional();

			Property(p => p.PCT012K058)
				.HasColumnName("PCT012K058")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K058")
				.IsOptional();

			Property(p => p.PCT012K059)
				.HasColumnName("PCT012K059")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K059")
				.IsOptional();

			Property(p => p.PCT012K060)
				.HasColumnName("PCT012K060")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K060")
				.IsOptional();

			Property(p => p.PCT012K061)
				.HasColumnName("PCT012K061")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K061")
				.IsOptional();

			Property(p => p.PCT012K062)
				.HasColumnName("PCT012K062")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K062")
				.IsOptional();

			Property(p => p.PCT012K063)
				.HasColumnName("PCT012K063")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K063")
				.IsOptional();

			Property(p => p.PCT012K064)
				.HasColumnName("PCT012K064")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K064")
				.IsOptional();

			Property(p => p.PCT012K065)
				.HasColumnName("PCT012K065")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K065")
				.IsOptional();

			Property(p => p.PCT012K066)
				.HasColumnName("PCT012K066")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K066")
				.IsOptional();

			Property(p => p.PCT012K067)
				.HasColumnName("PCT012K067")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K067")
				.IsOptional();

			Property(p => p.PCT012K068)
				.HasColumnName("PCT012K068")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K068")
				.IsOptional();

			Property(p => p.PCT012K069)
				.HasColumnName("PCT012K069")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K069")
				.IsOptional();

			Property(p => p.PCT012K070)
				.HasColumnName("PCT012K070")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K070")
				.IsOptional();

			Property(p => p.PCT012K071)
				.HasColumnName("PCT012K071")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K071")
				.IsOptional();

			Property(p => p.PCT012K072)
				.HasColumnName("PCT012K072")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K072")
				.IsOptional();

			Property(p => p.PCT012K073)
				.HasColumnName("PCT012K073")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K073")
				.IsOptional();

			Property(p => p.PCT012K074)
				.HasColumnName("PCT012K074")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K074")
				.IsOptional();

			Property(p => p.PCT012K075)
				.HasColumnName("PCT012K075")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K075")
				.IsOptional();

			Property(p => p.PCT012K076)
				.HasColumnName("PCT012K076")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K076")
				.IsOptional();

			Property(p => p.PCT012K077)
				.HasColumnName("PCT012K077")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K077")
				.IsOptional();

			Property(p => p.PCT012K078)
				.HasColumnName("PCT012K078")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K078")
				.IsOptional();

			Property(p => p.PCT012K079)
				.HasColumnName("PCT012K079")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K079")
				.IsOptional();

			Property(p => p.PCT012K080)
				.HasColumnName("PCT012K080")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K080")
				.IsOptional();

			Property(p => p.PCT012K081)
				.HasColumnName("PCT012K081")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K081")
				.IsOptional();

			Property(p => p.PCT012K082)
				.HasColumnName("PCT012K082")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K082")
				.IsOptional();

			Property(p => p.PCT012K083)
				.HasColumnName("PCT012K083")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K083")
				.IsOptional();

			Property(p => p.PCT012K084)
				.HasColumnName("PCT012K084")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K084")
				.IsOptional();

			Property(p => p.PCT012K085)
				.HasColumnName("PCT012K085")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K085")
				.IsOptional();

			Property(p => p.PCT012K086)
				.HasColumnName("PCT012K086")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K086")
				.IsOptional();

			Property(p => p.PCT012K087)
				.HasColumnName("PCT012K087")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K087")
				.IsOptional();

			Property(p => p.PCT012K088)
				.HasColumnName("PCT012K088")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K088")
				.IsOptional();

			Property(p => p.PCT012K089)
				.HasColumnName("PCT012K089")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K089")
				.IsOptional();

			Property(p => p.PCT012K090)
				.HasColumnName("PCT012K090")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K090")
				.IsOptional();

			Property(p => p.PCT012K091)
				.HasColumnName("PCT012K091")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K091")
				.IsOptional();

			Property(p => p.PCT012K092)
				.HasColumnName("PCT012K092")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K092")
				.IsOptional();

			Property(p => p.PCT012K093)
				.HasColumnName("PCT012K093")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K093")
				.IsOptional();

			Property(p => p.PCT012K094)
				.HasColumnName("PCT012K094")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K094")
				.IsOptional();

			Property(p => p.PCT012K095)
				.HasColumnName("PCT012K095")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K095")
				.IsOptional();

			Property(p => p.PCT012K096)
				.HasColumnName("PCT012K096")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K096")
				.IsOptional();

			Property(p => p.PCT012K097)
				.HasColumnName("PCT012K097")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K097")
				.IsOptional();

			Property(p => p.PCT012K098)
				.HasColumnName("PCT012K098")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K098")
				.IsOptional();

			Property(p => p.PCT012K099)
				.HasColumnName("PCT012K099")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K099")
				.IsOptional();

			Property(p => p.PCT012K100)
				.HasColumnName("PCT012K100")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K100")
				.IsOptional();

			Property(p => p.PCT012K101)
				.HasColumnName("PCT012K101")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K101")
				.IsOptional();

			Property(p => p.PCT012K102)
				.HasColumnName("PCT012K102")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K102")
				.IsOptional();

			Property(p => p.PCT012K103)
				.HasColumnName("PCT012K103")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K103")
				.IsOptional();

			Property(p => p.PCT012K104)
				.HasColumnName("PCT012K104")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K104")
				.IsOptional();

			Property(p => p.PCT012K105)
				.HasColumnName("PCT012K105")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K105")
				.IsOptional();

			Property(p => p.PCT012K106)
				.HasColumnName("PCT012K106")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K106")
				.IsOptional();

			Property(p => p.PCT012K107)
				.HasColumnName("PCT012K107")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K107")
				.IsOptional();

			Property(p => p.PCT012K108)
				.HasColumnName("PCT012K108")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K108")
				.IsOptional();

			Property(p => p.PCT012K109)
				.HasColumnName("PCT012K109")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K109")
				.IsOptional();

			Property(p => p.PCT012K110)
				.HasColumnName("PCT012K110")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K110")
				.IsOptional();

			Property(p => p.PCT012K111)
				.HasColumnName("PCT012K111")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K111")
				.IsOptional();

			Property(p => p.PCT012K112)
				.HasColumnName("PCT012K112")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K112")
				.IsOptional();

			Property(p => p.PCT012K113)
				.HasColumnName("PCT012K113")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K113")
				.IsOptional();

			Property(p => p.PCT012K114)
				.HasColumnName("PCT012K114")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K114")
				.IsOptional();

			Property(p => p.PCT012K115)
				.HasColumnName("PCT012K115")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K115")
				.IsOptional();

			Property(p => p.PCT012K116)
				.HasColumnName("PCT012K116")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K116")
				.IsOptional();

			Property(p => p.PCT012K117)
				.HasColumnName("PCT012K117")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K117")
				.IsOptional();

			Property(p => p.PCT012K118)
				.HasColumnName("PCT012K118")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K118")
				.IsOptional();

			Property(p => p.PCT012K119)
				.HasColumnName("PCT012K119")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K119")
				.IsOptional();

			Property(p => p.PCT012K120)
				.HasColumnName("PCT012K120")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K120")
				.IsOptional();

			Property(p => p.PCT012K121)
				.HasColumnName("PCT012K121")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K121")
				.IsOptional();

			Property(p => p.PCT012K122)
				.HasColumnName("PCT012K122")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K122")
				.IsOptional();

			Property(p => p.PCT012K123)
				.HasColumnName("PCT012K123")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K123")
				.IsOptional();

			Property(p => p.PCT012K124)
				.HasColumnName("PCT012K124")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K124")
				.IsOptional();

			Property(p => p.PCT012K125)
				.HasColumnName("PCT012K125")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K125")
				.IsOptional();

			Property(p => p.PCT012K126)
				.HasColumnName("PCT012K126")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K126")
				.IsOptional();

			Property(p => p.PCT012K127)
				.HasColumnName("PCT012K127")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K127")
				.IsOptional();

			Property(p => p.PCT012K128)
				.HasColumnName("PCT012K128")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K128")
				.IsOptional();

			Property(p => p.PCT012K129)
				.HasColumnName("PCT012K129")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K129")
				.IsOptional();

			Property(p => p.PCT012K130)
				.HasColumnName("PCT012K130")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K130")
				.IsOptional();

			Property(p => p.PCT012K131)
				.HasColumnName("PCT012K131")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K131")
				.IsOptional();

			Property(p => p.PCT012K132)
				.HasColumnName("PCT012K132")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K132")
				.IsOptional();

			Property(p => p.PCT012K133)
				.HasColumnName("PCT012K133")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K133")
				.IsOptional();

			Property(p => p.PCT012K134)
				.HasColumnName("PCT012K134")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K134")
				.IsOptional();

			Property(p => p.PCT012K135)
				.HasColumnName("PCT012K135")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K135")
				.IsOptional();

			Property(p => p.PCT012K136)
				.HasColumnName("PCT012K136")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K136")
				.IsOptional();

			Property(p => p.PCT012K137)
				.HasColumnName("PCT012K137")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K137")
				.IsOptional();

			Property(p => p.PCT012K138)
				.HasColumnName("PCT012K138")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K138")
				.IsOptional();

			Property(p => p.PCT012K139)
				.HasColumnName("PCT012K139")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K139")
				.IsOptional();

			Property(p => p.PCT012K140)
				.HasColumnName("PCT012K140")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K140")
				.IsOptional();

			Property(p => p.PCT012K141)
				.HasColumnName("PCT012K141")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K141")
				.IsOptional();

			Property(p => p.PCT012K142)
				.HasColumnName("PCT012K142")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K142")
				.IsOptional();

			Property(p => p.PCT012K143)
				.HasColumnName("PCT012K143")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K143")
				.IsOptional();

			Property(p => p.PCT012K144)
				.HasColumnName("PCT012K144")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K144")
				.IsOptional();

			Property(p => p.PCT012K145)
				.HasColumnName("PCT012K145")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K145")
				.IsOptional();

			Property(p => p.PCT012K146)
				.HasColumnName("PCT012K146")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K146")
				.IsOptional();

			Property(p => p.PCT012K147)
				.HasColumnName("PCT012K147")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K147")
				.IsOptional();

			Property(p => p.PCT012K148)
				.HasColumnName("PCT012K148")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K148")
				.IsOptional();

			Property(p => p.PCT012K149)
				.HasColumnName("PCT012K149")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K149")
				.IsOptional();

			Property(p => p.PCT012K150)
				.HasColumnName("PCT012K150")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K150")
				.IsOptional();

			Property(p => p.PCT012K151)
				.HasColumnName("PCT012K151")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K151")
				.IsOptional();

			Property(p => p.PCT012K152)
				.HasColumnName("PCT012K152")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K152")
				.IsOptional();

			Property(p => p.PCT012K153)
				.HasColumnName("PCT012K153")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K153")
				.IsOptional();

			Property(p => p.PCT012K154)
				.HasColumnName("PCT012K154")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K154")
				.IsOptional();

			Property(p => p.PCT012K155)
				.HasColumnName("PCT012K155")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K155")
				.IsOptional();

			Property(p => p.PCT012K156)
				.HasColumnName("PCT012K156")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K156")
				.IsOptional();

			Property(p => p.PCT012K157)
				.HasColumnName("PCT012K157")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K157")
				.IsOptional();

			Property(p => p.PCT012K158)
				.HasColumnName("PCT012K158")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K158")
				.IsOptional();

			Property(p => p.PCT012K159)
				.HasColumnName("PCT012K159")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K159")
				.IsOptional();

			Property(p => p.PCT012K160)
				.HasColumnName("PCT012K160")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K160")
				.IsOptional();

			Property(p => p.PCT012K161)
				.HasColumnName("PCT012K161")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K161")
				.IsOptional();

			Property(p => p.PCT012K162)
				.HasColumnName("PCT012K162")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K162")
				.IsOptional();

			Property(p => p.PCT012K163)
				.HasColumnName("PCT012K163")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K163")
				.IsOptional();

			Property(p => p.PCT012K164)
				.HasColumnName("PCT012K164")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K164")
				.IsOptional();

			Property(p => p.PCT012K165)
				.HasColumnName("PCT012K165")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K165")
				.IsOptional();

			Property(p => p.PCT012K166)
				.HasColumnName("PCT012K166")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K166")
				.IsOptional();

			Property(p => p.PCT012K167)
				.HasColumnName("PCT012K167")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K167")
				.IsOptional();

			Property(p => p.PCT012K168)
				.HasColumnName("PCT012K168")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K168")
				.IsOptional();

			Property(p => p.PCT012K169)
				.HasColumnName("PCT012K169")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K169")
				.IsOptional();

			Property(p => p.PCT012K170)
				.HasColumnName("PCT012K170")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K170")
				.IsOptional();

			Property(p => p.PCT012K171)
				.HasColumnName("PCT012K171")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K171")
				.IsOptional();

			Property(p => p.PCT012K172)
				.HasColumnName("PCT012K172")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K172")
				.IsOptional();

			Property(p => p.PCT012K173)
				.HasColumnName("PCT012K173")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K173")
				.IsOptional();

			Property(p => p.PCT012K174)
				.HasColumnName("PCT012K174")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K174")
				.IsOptional();

			Property(p => p.PCT012K175)
				.HasColumnName("PCT012K175")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K175")
				.IsOptional();

			Property(p => p.PCT012K176)
				.HasColumnName("PCT012K176")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K176")
				.IsOptional();

			Property(p => p.PCT012K177)
				.HasColumnName("PCT012K177")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K177")
				.IsOptional();

			Property(p => p.PCT012K178)
				.HasColumnName("PCT012K178")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K178")
				.IsOptional();

			Property(p => p.PCT012K179)
				.HasColumnName("PCT012K179")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K179")
				.IsOptional();

			Property(p => p.PCT012K180)
				.HasColumnName("PCT012K180")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K180")
				.IsOptional();

			Property(p => p.PCT012K181)
				.HasColumnName("PCT012K181")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K181")
				.IsOptional();

			Property(p => p.PCT012K182)
				.HasColumnName("PCT012K182")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K182")
				.IsOptional();

			Property(p => p.PCT012K183)
				.HasColumnName("PCT012K183")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K183")
				.IsOptional();

			Property(p => p.PCT012K184)
				.HasColumnName("PCT012K184")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K184")
				.IsOptional();

			Property(p => p.PCT012K185)
				.HasColumnName("PCT012K185")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K185")
				.IsOptional();

			Property(p => p.PCT012K186)
				.HasColumnName("PCT012K186")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K186")
				.IsOptional();

			Property(p => p.PCT012K187)
				.HasColumnName("PCT012K187")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K187")
				.IsOptional();

			Property(p => p.PCT012K188)
				.HasColumnName("PCT012K188")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K188")
				.IsOptional();

			Property(p => p.PCT012K189)
				.HasColumnName("PCT012K189")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K189")
				.IsOptional();

			Property(p => p.PCT012K190)
				.HasColumnName("PCT012K190")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K190")
				.IsOptional();

			Property(p => p.PCT012K191)
				.HasColumnName("PCT012K191")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K191")
				.IsOptional();

			Property(p => p.PCT012K192)
				.HasColumnName("PCT012K192")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K192")
				.IsOptional();

			Property(p => p.PCT012K193)
				.HasColumnName("PCT012K193")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K193")
				.IsOptional();

			Property(p => p.PCT012K194)
				.HasColumnName("PCT012K194")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K194")
				.IsOptional();

			Property(p => p.PCT012K195)
				.HasColumnName("PCT012K195")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K195")
				.IsOptional();

			Property(p => p.PCT012K196)
				.HasColumnName("PCT012K196")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K196")
				.IsOptional();

			Property(p => p.PCT012K197)
				.HasColumnName("PCT012K197")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K197")
				.IsOptional();

			Property(p => p.PCT012K198)
				.HasColumnName("PCT012K198")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K198")
				.IsOptional();

			Property(p => p.PCT012K199)
				.HasColumnName("PCT012K199")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K199")
				.IsOptional();

			Property(p => p.PCT012K200)
				.HasColumnName("PCT012K200")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K200")
				.IsOptional();

			Property(p => p.PCT012K201)
				.HasColumnName("PCT012K201")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K201")
				.IsOptional();

			Property(p => p.PCT012K202)
				.HasColumnName("PCT012K202")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K202")
				.IsOptional();

			Property(p => p.PCT012K203)
				.HasColumnName("PCT012K203")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K203")
				.IsOptional();

			Property(p => p.PCT012K204)
				.HasColumnName("PCT012K204")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K204")
				.IsOptional();

			Property(p => p.PCT012K205)
				.HasColumnName("PCT012K205")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K205")
				.IsOptional();

			Property(p => p.PCT012K206)
				.HasColumnName("PCT012K206")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K206")
				.IsOptional();

			Property(p => p.PCT012K207)
				.HasColumnName("PCT012K207")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K207")
				.IsOptional();

			Property(p => p.PCT012K208)
				.HasColumnName("PCT012K208")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K208")
				.IsOptional();

			Property(p => p.PCT012K209)
				.HasColumnName("PCT012K209")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012K209")
				.IsOptional();
		}
	}
}
