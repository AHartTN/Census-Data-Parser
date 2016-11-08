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
	using Models;
	#endregion Using Directives

	public class SummaryOne_SF1_00034Map : EntityTypeConfiguration<SummaryOne_SF1_00034>
	{
		public SummaryOne_SF1_00034Map()
		{
			ToTable("SF1_00034", "SummaryOne");

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

			Property(p => p.PCT012O001)
				.HasColumnName("PCT012O001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O001")
				.IsOptional();

			Property(p => p.PCT012O002)
				.HasColumnName("PCT012O002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O002")
				.IsOptional();

			Property(p => p.PCT012O003)
				.HasColumnName("PCT012O003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O003")
				.IsOptional();

			Property(p => p.PCT012O004)
				.HasColumnName("PCT012O004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O004")
				.IsOptional();

			Property(p => p.PCT012O005)
				.HasColumnName("PCT012O005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O005")
				.IsOptional();

			Property(p => p.PCT012O006)
				.HasColumnName("PCT012O006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O006")
				.IsOptional();

			Property(p => p.PCT012O007)
				.HasColumnName("PCT012O007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O007")
				.IsOptional();

			Property(p => p.PCT012O008)
				.HasColumnName("PCT012O008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O008")
				.IsOptional();

			Property(p => p.PCT012O009)
				.HasColumnName("PCT012O009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O009")
				.IsOptional();

			Property(p => p.PCT012O010)
				.HasColumnName("PCT012O010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O010")
				.IsOptional();

			Property(p => p.PCT012O011)
				.HasColumnName("PCT012O011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O011")
				.IsOptional();

			Property(p => p.PCT012O012)
				.HasColumnName("PCT012O012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O012")
				.IsOptional();

			Property(p => p.PCT012O013)
				.HasColumnName("PCT012O013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O013")
				.IsOptional();

			Property(p => p.PCT012O014)
				.HasColumnName("PCT012O014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O014")
				.IsOptional();

			Property(p => p.PCT012O015)
				.HasColumnName("PCT012O015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O015")
				.IsOptional();

			Property(p => p.PCT012O016)
				.HasColumnName("PCT012O016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O016")
				.IsOptional();

			Property(p => p.PCT012O017)
				.HasColumnName("PCT012O017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O017")
				.IsOptional();

			Property(p => p.PCT012O018)
				.HasColumnName("PCT012O018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O018")
				.IsOptional();

			Property(p => p.PCT012O019)
				.HasColumnName("PCT012O019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O019")
				.IsOptional();

			Property(p => p.PCT012O020)
				.HasColumnName("PCT012O020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O020")
				.IsOptional();

			Property(p => p.PCT012O021)
				.HasColumnName("PCT012O021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O021")
				.IsOptional();

			Property(p => p.PCT012O022)
				.HasColumnName("PCT012O022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O022")
				.IsOptional();

			Property(p => p.PCT012O023)
				.HasColumnName("PCT012O023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O023")
				.IsOptional();

			Property(p => p.PCT012O024)
				.HasColumnName("PCT012O024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O024")
				.IsOptional();

			Property(p => p.PCT012O025)
				.HasColumnName("PCT012O025")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O025")
				.IsOptional();

			Property(p => p.PCT012O026)
				.HasColumnName("PCT012O026")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O026")
				.IsOptional();

			Property(p => p.PCT012O027)
				.HasColumnName("PCT012O027")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O027")
				.IsOptional();

			Property(p => p.PCT012O028)
				.HasColumnName("PCT012O028")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O028")
				.IsOptional();

			Property(p => p.PCT012O029)
				.HasColumnName("PCT012O029")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O029")
				.IsOptional();

			Property(p => p.PCT012O030)
				.HasColumnName("PCT012O030")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O030")
				.IsOptional();

			Property(p => p.PCT012O031)
				.HasColumnName("PCT012O031")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O031")
				.IsOptional();

			Property(p => p.PCT012O032)
				.HasColumnName("PCT012O032")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O032")
				.IsOptional();

			Property(p => p.PCT012O033)
				.HasColumnName("PCT012O033")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O033")
				.IsOptional();

			Property(p => p.PCT012O034)
				.HasColumnName("PCT012O034")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O034")
				.IsOptional();

			Property(p => p.PCT012O035)
				.HasColumnName("PCT012O035")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O035")
				.IsOptional();

			Property(p => p.PCT012O036)
				.HasColumnName("PCT012O036")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O036")
				.IsOptional();

			Property(p => p.PCT012O037)
				.HasColumnName("PCT012O037")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O037")
				.IsOptional();

			Property(p => p.PCT012O038)
				.HasColumnName("PCT012O038")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O038")
				.IsOptional();

			Property(p => p.PCT012O039)
				.HasColumnName("PCT012O039")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O039")
				.IsOptional();

			Property(p => p.PCT012O040)
				.HasColumnName("PCT012O040")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O040")
				.IsOptional();

			Property(p => p.PCT012O041)
				.HasColumnName("PCT012O041")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O041")
				.IsOptional();

			Property(p => p.PCT012O042)
				.HasColumnName("PCT012O042")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O042")
				.IsOptional();

			Property(p => p.PCT012O043)
				.HasColumnName("PCT012O043")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O043")
				.IsOptional();

			Property(p => p.PCT012O044)
				.HasColumnName("PCT012O044")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O044")
				.IsOptional();

			Property(p => p.PCT012O045)
				.HasColumnName("PCT012O045")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O045")
				.IsOptional();

			Property(p => p.PCT012O046)
				.HasColumnName("PCT012O046")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O046")
				.IsOptional();

			Property(p => p.PCT012O047)
				.HasColumnName("PCT012O047")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O047")
				.IsOptional();

			Property(p => p.PCT012O048)
				.HasColumnName("PCT012O048")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O048")
				.IsOptional();

			Property(p => p.PCT012O049)
				.HasColumnName("PCT012O049")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O049")
				.IsOptional();

			Property(p => p.PCT012O050)
				.HasColumnName("PCT012O050")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O050")
				.IsOptional();

			Property(p => p.PCT012O051)
				.HasColumnName("PCT012O051")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O051")
				.IsOptional();

			Property(p => p.PCT012O052)
				.HasColumnName("PCT012O052")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O052")
				.IsOptional();

			Property(p => p.PCT012O053)
				.HasColumnName("PCT012O053")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O053")
				.IsOptional();

			Property(p => p.PCT012O054)
				.HasColumnName("PCT012O054")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O054")
				.IsOptional();

			Property(p => p.PCT012O055)
				.HasColumnName("PCT012O055")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O055")
				.IsOptional();

			Property(p => p.PCT012O056)
				.HasColumnName("PCT012O056")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O056")
				.IsOptional();

			Property(p => p.PCT012O057)
				.HasColumnName("PCT012O057")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O057")
				.IsOptional();

			Property(p => p.PCT012O058)
				.HasColumnName("PCT012O058")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O058")
				.IsOptional();

			Property(p => p.PCT012O059)
				.HasColumnName("PCT012O059")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O059")
				.IsOptional();

			Property(p => p.PCT012O060)
				.HasColumnName("PCT012O060")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O060")
				.IsOptional();

			Property(p => p.PCT012O061)
				.HasColumnName("PCT012O061")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O061")
				.IsOptional();

			Property(p => p.PCT012O062)
				.HasColumnName("PCT012O062")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O062")
				.IsOptional();

			Property(p => p.PCT012O063)
				.HasColumnName("PCT012O063")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O063")
				.IsOptional();

			Property(p => p.PCT012O064)
				.HasColumnName("PCT012O064")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O064")
				.IsOptional();

			Property(p => p.PCT012O065)
				.HasColumnName("PCT012O065")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O065")
				.IsOptional();

			Property(p => p.PCT012O066)
				.HasColumnName("PCT012O066")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O066")
				.IsOptional();

			Property(p => p.PCT012O067)
				.HasColumnName("PCT012O067")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O067")
				.IsOptional();

			Property(p => p.PCT012O068)
				.HasColumnName("PCT012O068")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O068")
				.IsOptional();

			Property(p => p.PCT012O069)
				.HasColumnName("PCT012O069")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O069")
				.IsOptional();

			Property(p => p.PCT012O070)
				.HasColumnName("PCT012O070")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O070")
				.IsOptional();

			Property(p => p.PCT012O071)
				.HasColumnName("PCT012O071")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O071")
				.IsOptional();

			Property(p => p.PCT012O072)
				.HasColumnName("PCT012O072")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O072")
				.IsOptional();

			Property(p => p.PCT012O073)
				.HasColumnName("PCT012O073")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O073")
				.IsOptional();

			Property(p => p.PCT012O074)
				.HasColumnName("PCT012O074")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O074")
				.IsOptional();

			Property(p => p.PCT012O075)
				.HasColumnName("PCT012O075")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O075")
				.IsOptional();

			Property(p => p.PCT012O076)
				.HasColumnName("PCT012O076")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O076")
				.IsOptional();

			Property(p => p.PCT012O077)
				.HasColumnName("PCT012O077")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O077")
				.IsOptional();

			Property(p => p.PCT012O078)
				.HasColumnName("PCT012O078")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O078")
				.IsOptional();

			Property(p => p.PCT012O079)
				.HasColumnName("PCT012O079")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O079")
				.IsOptional();

			Property(p => p.PCT012O080)
				.HasColumnName("PCT012O080")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O080")
				.IsOptional();

			Property(p => p.PCT012O081)
				.HasColumnName("PCT012O081")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O081")
				.IsOptional();

			Property(p => p.PCT012O082)
				.HasColumnName("PCT012O082")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O082")
				.IsOptional();

			Property(p => p.PCT012O083)
				.HasColumnName("PCT012O083")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O083")
				.IsOptional();

			Property(p => p.PCT012O084)
				.HasColumnName("PCT012O084")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O084")
				.IsOptional();

			Property(p => p.PCT012O085)
				.HasColumnName("PCT012O085")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O085")
				.IsOptional();

			Property(p => p.PCT012O086)
				.HasColumnName("PCT012O086")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O086")
				.IsOptional();

			Property(p => p.PCT012O087)
				.HasColumnName("PCT012O087")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O087")
				.IsOptional();

			Property(p => p.PCT012O088)
				.HasColumnName("PCT012O088")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O088")
				.IsOptional();

			Property(p => p.PCT012O089)
				.HasColumnName("PCT012O089")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O089")
				.IsOptional();

			Property(p => p.PCT012O090)
				.HasColumnName("PCT012O090")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O090")
				.IsOptional();

			Property(p => p.PCT012O091)
				.HasColumnName("PCT012O091")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O091")
				.IsOptional();

			Property(p => p.PCT012O092)
				.HasColumnName("PCT012O092")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O092")
				.IsOptional();

			Property(p => p.PCT012O093)
				.HasColumnName("PCT012O093")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O093")
				.IsOptional();

			Property(p => p.PCT012O094)
				.HasColumnName("PCT012O094")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O094")
				.IsOptional();

			Property(p => p.PCT012O095)
				.HasColumnName("PCT012O095")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O095")
				.IsOptional();

			Property(p => p.PCT012O096)
				.HasColumnName("PCT012O096")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O096")
				.IsOptional();

			Property(p => p.PCT012O097)
				.HasColumnName("PCT012O097")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O097")
				.IsOptional();

			Property(p => p.PCT012O098)
				.HasColumnName("PCT012O098")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O098")
				.IsOptional();

			Property(p => p.PCT012O099)
				.HasColumnName("PCT012O099")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O099")
				.IsOptional();

			Property(p => p.PCT012O100)
				.HasColumnName("PCT012O100")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O100")
				.IsOptional();

			Property(p => p.PCT012O101)
				.HasColumnName("PCT012O101")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O101")
				.IsOptional();

			Property(p => p.PCT012O102)
				.HasColumnName("PCT012O102")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O102")
				.IsOptional();

			Property(p => p.PCT012O103)
				.HasColumnName("PCT012O103")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O103")
				.IsOptional();

			Property(p => p.PCT012O104)
				.HasColumnName("PCT012O104")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O104")
				.IsOptional();

			Property(p => p.PCT012O105)
				.HasColumnName("PCT012O105")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O105")
				.IsOptional();

			Property(p => p.PCT012O106)
				.HasColumnName("PCT012O106")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O106")
				.IsOptional();

			Property(p => p.PCT012O107)
				.HasColumnName("PCT012O107")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O107")
				.IsOptional();

			Property(p => p.PCT012O108)
				.HasColumnName("PCT012O108")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O108")
				.IsOptional();

			Property(p => p.PCT012O109)
				.HasColumnName("PCT012O109")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O109")
				.IsOptional();

			Property(p => p.PCT012O110)
				.HasColumnName("PCT012O110")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O110")
				.IsOptional();

			Property(p => p.PCT012O111)
				.HasColumnName("PCT012O111")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O111")
				.IsOptional();

			Property(p => p.PCT012O112)
				.HasColumnName("PCT012O112")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O112")
				.IsOptional();

			Property(p => p.PCT012O113)
				.HasColumnName("PCT012O113")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O113")
				.IsOptional();

			Property(p => p.PCT012O114)
				.HasColumnName("PCT012O114")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O114")
				.IsOptional();

			Property(p => p.PCT012O115)
				.HasColumnName("PCT012O115")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O115")
				.IsOptional();

			Property(p => p.PCT012O116)
				.HasColumnName("PCT012O116")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O116")
				.IsOptional();

			Property(p => p.PCT012O117)
				.HasColumnName("PCT012O117")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O117")
				.IsOptional();

			Property(p => p.PCT012O118)
				.HasColumnName("PCT012O118")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O118")
				.IsOptional();

			Property(p => p.PCT012O119)
				.HasColumnName("PCT012O119")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O119")
				.IsOptional();

			Property(p => p.PCT012O120)
				.HasColumnName("PCT012O120")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O120")
				.IsOptional();

			Property(p => p.PCT012O121)
				.HasColumnName("PCT012O121")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O121")
				.IsOptional();

			Property(p => p.PCT012O122)
				.HasColumnName("PCT012O122")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O122")
				.IsOptional();

			Property(p => p.PCT012O123)
				.HasColumnName("PCT012O123")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O123")
				.IsOptional();

			Property(p => p.PCT012O124)
				.HasColumnName("PCT012O124")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O124")
				.IsOptional();

			Property(p => p.PCT012O125)
				.HasColumnName("PCT012O125")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O125")
				.IsOptional();

			Property(p => p.PCT012O126)
				.HasColumnName("PCT012O126")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O126")
				.IsOptional();

			Property(p => p.PCT012O127)
				.HasColumnName("PCT012O127")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O127")
				.IsOptional();

			Property(p => p.PCT012O128)
				.HasColumnName("PCT012O128")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O128")
				.IsOptional();

			Property(p => p.PCT012O129)
				.HasColumnName("PCT012O129")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O129")
				.IsOptional();

			Property(p => p.PCT012O130)
				.HasColumnName("PCT012O130")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O130")
				.IsOptional();

			Property(p => p.PCT012O131)
				.HasColumnName("PCT012O131")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O131")
				.IsOptional();

			Property(p => p.PCT012O132)
				.HasColumnName("PCT012O132")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O132")
				.IsOptional();

			Property(p => p.PCT012O133)
				.HasColumnName("PCT012O133")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O133")
				.IsOptional();

			Property(p => p.PCT012O134)
				.HasColumnName("PCT012O134")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O134")
				.IsOptional();

			Property(p => p.PCT012O135)
				.HasColumnName("PCT012O135")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O135")
				.IsOptional();

			Property(p => p.PCT012O136)
				.HasColumnName("PCT012O136")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O136")
				.IsOptional();

			Property(p => p.PCT012O137)
				.HasColumnName("PCT012O137")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O137")
				.IsOptional();

			Property(p => p.PCT012O138)
				.HasColumnName("PCT012O138")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O138")
				.IsOptional();

			Property(p => p.PCT012O139)
				.HasColumnName("PCT012O139")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O139")
				.IsOptional();

			Property(p => p.PCT012O140)
				.HasColumnName("PCT012O140")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O140")
				.IsOptional();

			Property(p => p.PCT012O141)
				.HasColumnName("PCT012O141")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O141")
				.IsOptional();

			Property(p => p.PCT012O142)
				.HasColumnName("PCT012O142")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O142")
				.IsOptional();

			Property(p => p.PCT012O143)
				.HasColumnName("PCT012O143")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O143")
				.IsOptional();

			Property(p => p.PCT012O144)
				.HasColumnName("PCT012O144")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O144")
				.IsOptional();

			Property(p => p.PCT012O145)
				.HasColumnName("PCT012O145")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O145")
				.IsOptional();

			Property(p => p.PCT012O146)
				.HasColumnName("PCT012O146")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O146")
				.IsOptional();

			Property(p => p.PCT012O147)
				.HasColumnName("PCT012O147")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O147")
				.IsOptional();

			Property(p => p.PCT012O148)
				.HasColumnName("PCT012O148")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O148")
				.IsOptional();

			Property(p => p.PCT012O149)
				.HasColumnName("PCT012O149")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O149")
				.IsOptional();

			Property(p => p.PCT012O150)
				.HasColumnName("PCT012O150")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O150")
				.IsOptional();

			Property(p => p.PCT012O151)
				.HasColumnName("PCT012O151")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O151")
				.IsOptional();

			Property(p => p.PCT012O152)
				.HasColumnName("PCT012O152")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O152")
				.IsOptional();

			Property(p => p.PCT012O153)
				.HasColumnName("PCT012O153")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O153")
				.IsOptional();

			Property(p => p.PCT012O154)
				.HasColumnName("PCT012O154")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O154")
				.IsOptional();

			Property(p => p.PCT012O155)
				.HasColumnName("PCT012O155")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O155")
				.IsOptional();

			Property(p => p.PCT012O156)
				.HasColumnName("PCT012O156")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O156")
				.IsOptional();

			Property(p => p.PCT012O157)
				.HasColumnName("PCT012O157")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O157")
				.IsOptional();

			Property(p => p.PCT012O158)
				.HasColumnName("PCT012O158")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O158")
				.IsOptional();

			Property(p => p.PCT012O159)
				.HasColumnName("PCT012O159")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O159")
				.IsOptional();

			Property(p => p.PCT012O160)
				.HasColumnName("PCT012O160")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O160")
				.IsOptional();

			Property(p => p.PCT012O161)
				.HasColumnName("PCT012O161")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O161")
				.IsOptional();

			Property(p => p.PCT012O162)
				.HasColumnName("PCT012O162")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O162")
				.IsOptional();

			Property(p => p.PCT012O163)
				.HasColumnName("PCT012O163")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O163")
				.IsOptional();

			Property(p => p.PCT012O164)
				.HasColumnName("PCT012O164")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O164")
				.IsOptional();

			Property(p => p.PCT012O165)
				.HasColumnName("PCT012O165")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O165")
				.IsOptional();

			Property(p => p.PCT012O166)
				.HasColumnName("PCT012O166")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O166")
				.IsOptional();

			Property(p => p.PCT012O167)
				.HasColumnName("PCT012O167")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O167")
				.IsOptional();

			Property(p => p.PCT012O168)
				.HasColumnName("PCT012O168")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O168")
				.IsOptional();

			Property(p => p.PCT012O169)
				.HasColumnName("PCT012O169")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O169")
				.IsOptional();

			Property(p => p.PCT012O170)
				.HasColumnName("PCT012O170")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O170")
				.IsOptional();

			Property(p => p.PCT012O171)
				.HasColumnName("PCT012O171")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O171")
				.IsOptional();

			Property(p => p.PCT012O172)
				.HasColumnName("PCT012O172")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O172")
				.IsOptional();

			Property(p => p.PCT012O173)
				.HasColumnName("PCT012O173")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O173")
				.IsOptional();

			Property(p => p.PCT012O174)
				.HasColumnName("PCT012O174")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O174")
				.IsOptional();

			Property(p => p.PCT012O175)
				.HasColumnName("PCT012O175")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O175")
				.IsOptional();

			Property(p => p.PCT012O176)
				.HasColumnName("PCT012O176")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O176")
				.IsOptional();

			Property(p => p.PCT012O177)
				.HasColumnName("PCT012O177")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O177")
				.IsOptional();

			Property(p => p.PCT012O178)
				.HasColumnName("PCT012O178")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O178")
				.IsOptional();

			Property(p => p.PCT012O179)
				.HasColumnName("PCT012O179")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O179")
				.IsOptional();

			Property(p => p.PCT012O180)
				.HasColumnName("PCT012O180")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O180")
				.IsOptional();

			Property(p => p.PCT012O181)
				.HasColumnName("PCT012O181")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O181")
				.IsOptional();

			Property(p => p.PCT012O182)
				.HasColumnName("PCT012O182")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O182")
				.IsOptional();

			Property(p => p.PCT012O183)
				.HasColumnName("PCT012O183")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O183")
				.IsOptional();

			Property(p => p.PCT012O184)
				.HasColumnName("PCT012O184")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O184")
				.IsOptional();

			Property(p => p.PCT012O185)
				.HasColumnName("PCT012O185")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O185")
				.IsOptional();

			Property(p => p.PCT012O186)
				.HasColumnName("PCT012O186")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O186")
				.IsOptional();

			Property(p => p.PCT012O187)
				.HasColumnName("PCT012O187")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O187")
				.IsOptional();

			Property(p => p.PCT012O188)
				.HasColumnName("PCT012O188")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O188")
				.IsOptional();

			Property(p => p.PCT012O189)
				.HasColumnName("PCT012O189")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O189")
				.IsOptional();

			Property(p => p.PCT012O190)
				.HasColumnName("PCT012O190")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O190")
				.IsOptional();

			Property(p => p.PCT012O191)
				.HasColumnName("PCT012O191")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O191")
				.IsOptional();

			Property(p => p.PCT012O192)
				.HasColumnName("PCT012O192")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O192")
				.IsOptional();

			Property(p => p.PCT012O193)
				.HasColumnName("PCT012O193")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O193")
				.IsOptional();

			Property(p => p.PCT012O194)
				.HasColumnName("PCT012O194")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O194")
				.IsOptional();

			Property(p => p.PCT012O195)
				.HasColumnName("PCT012O195")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O195")
				.IsOptional();

			Property(p => p.PCT012O196)
				.HasColumnName("PCT012O196")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O196")
				.IsOptional();

			Property(p => p.PCT012O197)
				.HasColumnName("PCT012O197")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O197")
				.IsOptional();

			Property(p => p.PCT012O198)
				.HasColumnName("PCT012O198")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O198")
				.IsOptional();

			Property(p => p.PCT012O199)
				.HasColumnName("PCT012O199")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O199")
				.IsOptional();

			Property(p => p.PCT012O200)
				.HasColumnName("PCT012O200")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O200")
				.IsOptional();

			Property(p => p.PCT012O201)
				.HasColumnName("PCT012O201")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O201")
				.IsOptional();

			Property(p => p.PCT012O202)
				.HasColumnName("PCT012O202")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O202")
				.IsOptional();

			Property(p => p.PCT012O203)
				.HasColumnName("PCT012O203")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O203")
				.IsOptional();

			Property(p => p.PCT012O204)
				.HasColumnName("PCT012O204")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O204")
				.IsOptional();

			Property(p => p.PCT012O205)
				.HasColumnName("PCT012O205")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O205")
				.IsOptional();

			Property(p => p.PCT012O206)
				.HasColumnName("PCT012O206")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O206")
				.IsOptional();

			Property(p => p.PCT012O207)
				.HasColumnName("PCT012O207")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O207")
				.IsOptional();

			Property(p => p.PCT012O208)
				.HasColumnName("PCT012O208")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O208")
				.IsOptional();

			Property(p => p.PCT012O209)
				.HasColumnName("PCT012O209")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012O209")
				.IsOptional();
		}
	}
}
