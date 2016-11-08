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

	public class SummaryOne_SF1_00024Map : EntityTypeConfiguration<SummaryOne_SF1_00024>
	{
		public SummaryOne_SF1_00024Map()
		{
			ToTable("SF1_00024", "SummaryOne");

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

			Property(p => p.PCT012E001)
				.HasColumnName("PCT012E001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E001")
				.IsOptional();

			Property(p => p.PCT012E002)
				.HasColumnName("PCT012E002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E002")
				.IsOptional();

			Property(p => p.PCT012E003)
				.HasColumnName("PCT012E003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E003")
				.IsOptional();

			Property(p => p.PCT012E004)
				.HasColumnName("PCT012E004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E004")
				.IsOptional();

			Property(p => p.PCT012E005)
				.HasColumnName("PCT012E005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E005")
				.IsOptional();

			Property(p => p.PCT012E006)
				.HasColumnName("PCT012E006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E006")
				.IsOptional();

			Property(p => p.PCT012E007)
				.HasColumnName("PCT012E007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E007")
				.IsOptional();

			Property(p => p.PCT012E008)
				.HasColumnName("PCT012E008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E008")
				.IsOptional();

			Property(p => p.PCT012E009)
				.HasColumnName("PCT012E009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E009")
				.IsOptional();

			Property(p => p.PCT012E010)
				.HasColumnName("PCT012E010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E010")
				.IsOptional();

			Property(p => p.PCT012E011)
				.HasColumnName("PCT012E011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E011")
				.IsOptional();

			Property(p => p.PCT012E012)
				.HasColumnName("PCT012E012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E012")
				.IsOptional();

			Property(p => p.PCT012E013)
				.HasColumnName("PCT012E013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E013")
				.IsOptional();

			Property(p => p.PCT012E014)
				.HasColumnName("PCT012E014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E014")
				.IsOptional();

			Property(p => p.PCT012E015)
				.HasColumnName("PCT012E015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E015")
				.IsOptional();

			Property(p => p.PCT012E016)
				.HasColumnName("PCT012E016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E016")
				.IsOptional();

			Property(p => p.PCT012E017)
				.HasColumnName("PCT012E017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E017")
				.IsOptional();

			Property(p => p.PCT012E018)
				.HasColumnName("PCT012E018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E018")
				.IsOptional();

			Property(p => p.PCT012E019)
				.HasColumnName("PCT012E019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E019")
				.IsOptional();

			Property(p => p.PCT012E020)
				.HasColumnName("PCT012E020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E020")
				.IsOptional();

			Property(p => p.PCT012E021)
				.HasColumnName("PCT012E021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E021")
				.IsOptional();

			Property(p => p.PCT012E022)
				.HasColumnName("PCT012E022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E022")
				.IsOptional();

			Property(p => p.PCT012E023)
				.HasColumnName("PCT012E023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E023")
				.IsOptional();

			Property(p => p.PCT012E024)
				.HasColumnName("PCT012E024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E024")
				.IsOptional();

			Property(p => p.PCT012E025)
				.HasColumnName("PCT012E025")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E025")
				.IsOptional();

			Property(p => p.PCT012E026)
				.HasColumnName("PCT012E026")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E026")
				.IsOptional();

			Property(p => p.PCT012E027)
				.HasColumnName("PCT012E027")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E027")
				.IsOptional();

			Property(p => p.PCT012E028)
				.HasColumnName("PCT012E028")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E028")
				.IsOptional();

			Property(p => p.PCT012E029)
				.HasColumnName("PCT012E029")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E029")
				.IsOptional();

			Property(p => p.PCT012E030)
				.HasColumnName("PCT012E030")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E030")
				.IsOptional();

			Property(p => p.PCT012E031)
				.HasColumnName("PCT012E031")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E031")
				.IsOptional();

			Property(p => p.PCT012E032)
				.HasColumnName("PCT012E032")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E032")
				.IsOptional();

			Property(p => p.PCT012E033)
				.HasColumnName("PCT012E033")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E033")
				.IsOptional();

			Property(p => p.PCT012E034)
				.HasColumnName("PCT012E034")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E034")
				.IsOptional();

			Property(p => p.PCT012E035)
				.HasColumnName("PCT012E035")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E035")
				.IsOptional();

			Property(p => p.PCT012E036)
				.HasColumnName("PCT012E036")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E036")
				.IsOptional();

			Property(p => p.PCT012E037)
				.HasColumnName("PCT012E037")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E037")
				.IsOptional();

			Property(p => p.PCT012E038)
				.HasColumnName("PCT012E038")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E038")
				.IsOptional();

			Property(p => p.PCT012E039)
				.HasColumnName("PCT012E039")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E039")
				.IsOptional();

			Property(p => p.PCT012E040)
				.HasColumnName("PCT012E040")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E040")
				.IsOptional();

			Property(p => p.PCT012E041)
				.HasColumnName("PCT012E041")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E041")
				.IsOptional();

			Property(p => p.PCT012E042)
				.HasColumnName("PCT012E042")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E042")
				.IsOptional();

			Property(p => p.PCT012E043)
				.HasColumnName("PCT012E043")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E043")
				.IsOptional();

			Property(p => p.PCT012E044)
				.HasColumnName("PCT012E044")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E044")
				.IsOptional();

			Property(p => p.PCT012E045)
				.HasColumnName("PCT012E045")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E045")
				.IsOptional();

			Property(p => p.PCT012E046)
				.HasColumnName("PCT012E046")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E046")
				.IsOptional();

			Property(p => p.PCT012E047)
				.HasColumnName("PCT012E047")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E047")
				.IsOptional();

			Property(p => p.PCT012E048)
				.HasColumnName("PCT012E048")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E048")
				.IsOptional();

			Property(p => p.PCT012E049)
				.HasColumnName("PCT012E049")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E049")
				.IsOptional();

			Property(p => p.PCT012E050)
				.HasColumnName("PCT012E050")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E050")
				.IsOptional();

			Property(p => p.PCT012E051)
				.HasColumnName("PCT012E051")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E051")
				.IsOptional();

			Property(p => p.PCT012E052)
				.HasColumnName("PCT012E052")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E052")
				.IsOptional();

			Property(p => p.PCT012E053)
				.HasColumnName("PCT012E053")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E053")
				.IsOptional();

			Property(p => p.PCT012E054)
				.HasColumnName("PCT012E054")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E054")
				.IsOptional();

			Property(p => p.PCT012E055)
				.HasColumnName("PCT012E055")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E055")
				.IsOptional();

			Property(p => p.PCT012E056)
				.HasColumnName("PCT012E056")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E056")
				.IsOptional();

			Property(p => p.PCT012E057)
				.HasColumnName("PCT012E057")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E057")
				.IsOptional();

			Property(p => p.PCT012E058)
				.HasColumnName("PCT012E058")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E058")
				.IsOptional();

			Property(p => p.PCT012E059)
				.HasColumnName("PCT012E059")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E059")
				.IsOptional();

			Property(p => p.PCT012E060)
				.HasColumnName("PCT012E060")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E060")
				.IsOptional();

			Property(p => p.PCT012E061)
				.HasColumnName("PCT012E061")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E061")
				.IsOptional();

			Property(p => p.PCT012E062)
				.HasColumnName("PCT012E062")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E062")
				.IsOptional();

			Property(p => p.PCT012E063)
				.HasColumnName("PCT012E063")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E063")
				.IsOptional();

			Property(p => p.PCT012E064)
				.HasColumnName("PCT012E064")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E064")
				.IsOptional();

			Property(p => p.PCT012E065)
				.HasColumnName("PCT012E065")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E065")
				.IsOptional();

			Property(p => p.PCT012E066)
				.HasColumnName("PCT012E066")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E066")
				.IsOptional();

			Property(p => p.PCT012E067)
				.HasColumnName("PCT012E067")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E067")
				.IsOptional();

			Property(p => p.PCT012E068)
				.HasColumnName("PCT012E068")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E068")
				.IsOptional();

			Property(p => p.PCT012E069)
				.HasColumnName("PCT012E069")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E069")
				.IsOptional();

			Property(p => p.PCT012E070)
				.HasColumnName("PCT012E070")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E070")
				.IsOptional();

			Property(p => p.PCT012E071)
				.HasColumnName("PCT012E071")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E071")
				.IsOptional();

			Property(p => p.PCT012E072)
				.HasColumnName("PCT012E072")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E072")
				.IsOptional();

			Property(p => p.PCT012E073)
				.HasColumnName("PCT012E073")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E073")
				.IsOptional();

			Property(p => p.PCT012E074)
				.HasColumnName("PCT012E074")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E074")
				.IsOptional();

			Property(p => p.PCT012E075)
				.HasColumnName("PCT012E075")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E075")
				.IsOptional();

			Property(p => p.PCT012E076)
				.HasColumnName("PCT012E076")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E076")
				.IsOptional();

			Property(p => p.PCT012E077)
				.HasColumnName("PCT012E077")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E077")
				.IsOptional();

			Property(p => p.PCT012E078)
				.HasColumnName("PCT012E078")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E078")
				.IsOptional();

			Property(p => p.PCT012E079)
				.HasColumnName("PCT012E079")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E079")
				.IsOptional();

			Property(p => p.PCT012E080)
				.HasColumnName("PCT012E080")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E080")
				.IsOptional();

			Property(p => p.PCT012E081)
				.HasColumnName("PCT012E081")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E081")
				.IsOptional();

			Property(p => p.PCT012E082)
				.HasColumnName("PCT012E082")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E082")
				.IsOptional();

			Property(p => p.PCT012E083)
				.HasColumnName("PCT012E083")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E083")
				.IsOptional();

			Property(p => p.PCT012E084)
				.HasColumnName("PCT012E084")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E084")
				.IsOptional();

			Property(p => p.PCT012E085)
				.HasColumnName("PCT012E085")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E085")
				.IsOptional();

			Property(p => p.PCT012E086)
				.HasColumnName("PCT012E086")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E086")
				.IsOptional();

			Property(p => p.PCT012E087)
				.HasColumnName("PCT012E087")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E087")
				.IsOptional();

			Property(p => p.PCT012E088)
				.HasColumnName("PCT012E088")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E088")
				.IsOptional();

			Property(p => p.PCT012E089)
				.HasColumnName("PCT012E089")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E089")
				.IsOptional();

			Property(p => p.PCT012E090)
				.HasColumnName("PCT012E090")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E090")
				.IsOptional();

			Property(p => p.PCT012E091)
				.HasColumnName("PCT012E091")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E091")
				.IsOptional();

			Property(p => p.PCT012E092)
				.HasColumnName("PCT012E092")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E092")
				.IsOptional();

			Property(p => p.PCT012E093)
				.HasColumnName("PCT012E093")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E093")
				.IsOptional();

			Property(p => p.PCT012E094)
				.HasColumnName("PCT012E094")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E094")
				.IsOptional();

			Property(p => p.PCT012E095)
				.HasColumnName("PCT012E095")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E095")
				.IsOptional();

			Property(p => p.PCT012E096)
				.HasColumnName("PCT012E096")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E096")
				.IsOptional();

			Property(p => p.PCT012E097)
				.HasColumnName("PCT012E097")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E097")
				.IsOptional();

			Property(p => p.PCT012E098)
				.HasColumnName("PCT012E098")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E098")
				.IsOptional();

			Property(p => p.PCT012E099)
				.HasColumnName("PCT012E099")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E099")
				.IsOptional();

			Property(p => p.PCT012E100)
				.HasColumnName("PCT012E100")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E100")
				.IsOptional();

			Property(p => p.PCT012E101)
				.HasColumnName("PCT012E101")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E101")
				.IsOptional();

			Property(p => p.PCT012E102)
				.HasColumnName("PCT012E102")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E102")
				.IsOptional();

			Property(p => p.PCT012E103)
				.HasColumnName("PCT012E103")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E103")
				.IsOptional();

			Property(p => p.PCT012E104)
				.HasColumnName("PCT012E104")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E104")
				.IsOptional();

			Property(p => p.PCT012E105)
				.HasColumnName("PCT012E105")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E105")
				.IsOptional();

			Property(p => p.PCT012E106)
				.HasColumnName("PCT012E106")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E106")
				.IsOptional();

			Property(p => p.PCT012E107)
				.HasColumnName("PCT012E107")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E107")
				.IsOptional();

			Property(p => p.PCT012E108)
				.HasColumnName("PCT012E108")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E108")
				.IsOptional();

			Property(p => p.PCT012E109)
				.HasColumnName("PCT012E109")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E109")
				.IsOptional();

			Property(p => p.PCT012E110)
				.HasColumnName("PCT012E110")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E110")
				.IsOptional();

			Property(p => p.PCT012E111)
				.HasColumnName("PCT012E111")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E111")
				.IsOptional();

			Property(p => p.PCT012E112)
				.HasColumnName("PCT012E112")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E112")
				.IsOptional();

			Property(p => p.PCT012E113)
				.HasColumnName("PCT012E113")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E113")
				.IsOptional();

			Property(p => p.PCT012E114)
				.HasColumnName("PCT012E114")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E114")
				.IsOptional();

			Property(p => p.PCT012E115)
				.HasColumnName("PCT012E115")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E115")
				.IsOptional();

			Property(p => p.PCT012E116)
				.HasColumnName("PCT012E116")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E116")
				.IsOptional();

			Property(p => p.PCT012E117)
				.HasColumnName("PCT012E117")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E117")
				.IsOptional();

			Property(p => p.PCT012E118)
				.HasColumnName("PCT012E118")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E118")
				.IsOptional();

			Property(p => p.PCT012E119)
				.HasColumnName("PCT012E119")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E119")
				.IsOptional();

			Property(p => p.PCT012E120)
				.HasColumnName("PCT012E120")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E120")
				.IsOptional();

			Property(p => p.PCT012E121)
				.HasColumnName("PCT012E121")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E121")
				.IsOptional();

			Property(p => p.PCT012E122)
				.HasColumnName("PCT012E122")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E122")
				.IsOptional();

			Property(p => p.PCT012E123)
				.HasColumnName("PCT012E123")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E123")
				.IsOptional();

			Property(p => p.PCT012E124)
				.HasColumnName("PCT012E124")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E124")
				.IsOptional();

			Property(p => p.PCT012E125)
				.HasColumnName("PCT012E125")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E125")
				.IsOptional();

			Property(p => p.PCT012E126)
				.HasColumnName("PCT012E126")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E126")
				.IsOptional();

			Property(p => p.PCT012E127)
				.HasColumnName("PCT012E127")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E127")
				.IsOptional();

			Property(p => p.PCT012E128)
				.HasColumnName("PCT012E128")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E128")
				.IsOptional();

			Property(p => p.PCT012E129)
				.HasColumnName("PCT012E129")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E129")
				.IsOptional();

			Property(p => p.PCT012E130)
				.HasColumnName("PCT012E130")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E130")
				.IsOptional();

			Property(p => p.PCT012E131)
				.HasColumnName("PCT012E131")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E131")
				.IsOptional();

			Property(p => p.PCT012E132)
				.HasColumnName("PCT012E132")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E132")
				.IsOptional();

			Property(p => p.PCT012E133)
				.HasColumnName("PCT012E133")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E133")
				.IsOptional();

			Property(p => p.PCT012E134)
				.HasColumnName("PCT012E134")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E134")
				.IsOptional();

			Property(p => p.PCT012E135)
				.HasColumnName("PCT012E135")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E135")
				.IsOptional();

			Property(p => p.PCT012E136)
				.HasColumnName("PCT012E136")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E136")
				.IsOptional();

			Property(p => p.PCT012E137)
				.HasColumnName("PCT012E137")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E137")
				.IsOptional();

			Property(p => p.PCT012E138)
				.HasColumnName("PCT012E138")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E138")
				.IsOptional();

			Property(p => p.PCT012E139)
				.HasColumnName("PCT012E139")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E139")
				.IsOptional();

			Property(p => p.PCT012E140)
				.HasColumnName("PCT012E140")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E140")
				.IsOptional();

			Property(p => p.PCT012E141)
				.HasColumnName("PCT012E141")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E141")
				.IsOptional();

			Property(p => p.PCT012E142)
				.HasColumnName("PCT012E142")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E142")
				.IsOptional();

			Property(p => p.PCT012E143)
				.HasColumnName("PCT012E143")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E143")
				.IsOptional();

			Property(p => p.PCT012E144)
				.HasColumnName("PCT012E144")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E144")
				.IsOptional();

			Property(p => p.PCT012E145)
				.HasColumnName("PCT012E145")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E145")
				.IsOptional();

			Property(p => p.PCT012E146)
				.HasColumnName("PCT012E146")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E146")
				.IsOptional();

			Property(p => p.PCT012E147)
				.HasColumnName("PCT012E147")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E147")
				.IsOptional();

			Property(p => p.PCT012E148)
				.HasColumnName("PCT012E148")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E148")
				.IsOptional();

			Property(p => p.PCT012E149)
				.HasColumnName("PCT012E149")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E149")
				.IsOptional();

			Property(p => p.PCT012E150)
				.HasColumnName("PCT012E150")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E150")
				.IsOptional();

			Property(p => p.PCT012E151)
				.HasColumnName("PCT012E151")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E151")
				.IsOptional();

			Property(p => p.PCT012E152)
				.HasColumnName("PCT012E152")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E152")
				.IsOptional();

			Property(p => p.PCT012E153)
				.HasColumnName("PCT012E153")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E153")
				.IsOptional();

			Property(p => p.PCT012E154)
				.HasColumnName("PCT012E154")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E154")
				.IsOptional();

			Property(p => p.PCT012E155)
				.HasColumnName("PCT012E155")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E155")
				.IsOptional();

			Property(p => p.PCT012E156)
				.HasColumnName("PCT012E156")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E156")
				.IsOptional();

			Property(p => p.PCT012E157)
				.HasColumnName("PCT012E157")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E157")
				.IsOptional();

			Property(p => p.PCT012E158)
				.HasColumnName("PCT012E158")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E158")
				.IsOptional();

			Property(p => p.PCT012E159)
				.HasColumnName("PCT012E159")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E159")
				.IsOptional();

			Property(p => p.PCT012E160)
				.HasColumnName("PCT012E160")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E160")
				.IsOptional();

			Property(p => p.PCT012E161)
				.HasColumnName("PCT012E161")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E161")
				.IsOptional();

			Property(p => p.PCT012E162)
				.HasColumnName("PCT012E162")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E162")
				.IsOptional();

			Property(p => p.PCT012E163)
				.HasColumnName("PCT012E163")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E163")
				.IsOptional();

			Property(p => p.PCT012E164)
				.HasColumnName("PCT012E164")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E164")
				.IsOptional();

			Property(p => p.PCT012E165)
				.HasColumnName("PCT012E165")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E165")
				.IsOptional();

			Property(p => p.PCT012E166)
				.HasColumnName("PCT012E166")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E166")
				.IsOptional();

			Property(p => p.PCT012E167)
				.HasColumnName("PCT012E167")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E167")
				.IsOptional();

			Property(p => p.PCT012E168)
				.HasColumnName("PCT012E168")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E168")
				.IsOptional();

			Property(p => p.PCT012E169)
				.HasColumnName("PCT012E169")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E169")
				.IsOptional();

			Property(p => p.PCT012E170)
				.HasColumnName("PCT012E170")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E170")
				.IsOptional();

			Property(p => p.PCT012E171)
				.HasColumnName("PCT012E171")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E171")
				.IsOptional();

			Property(p => p.PCT012E172)
				.HasColumnName("PCT012E172")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E172")
				.IsOptional();

			Property(p => p.PCT012E173)
				.HasColumnName("PCT012E173")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E173")
				.IsOptional();

			Property(p => p.PCT012E174)
				.HasColumnName("PCT012E174")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E174")
				.IsOptional();

			Property(p => p.PCT012E175)
				.HasColumnName("PCT012E175")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E175")
				.IsOptional();

			Property(p => p.PCT012E176)
				.HasColumnName("PCT012E176")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E176")
				.IsOptional();

			Property(p => p.PCT012E177)
				.HasColumnName("PCT012E177")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E177")
				.IsOptional();

			Property(p => p.PCT012E178)
				.HasColumnName("PCT012E178")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E178")
				.IsOptional();

			Property(p => p.PCT012E179)
				.HasColumnName("PCT012E179")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E179")
				.IsOptional();

			Property(p => p.PCT012E180)
				.HasColumnName("PCT012E180")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E180")
				.IsOptional();

			Property(p => p.PCT012E181)
				.HasColumnName("PCT012E181")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E181")
				.IsOptional();

			Property(p => p.PCT012E182)
				.HasColumnName("PCT012E182")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E182")
				.IsOptional();

			Property(p => p.PCT012E183)
				.HasColumnName("PCT012E183")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E183")
				.IsOptional();

			Property(p => p.PCT012E184)
				.HasColumnName("PCT012E184")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E184")
				.IsOptional();

			Property(p => p.PCT012E185)
				.HasColumnName("PCT012E185")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E185")
				.IsOptional();

			Property(p => p.PCT012E186)
				.HasColumnName("PCT012E186")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E186")
				.IsOptional();

			Property(p => p.PCT012E187)
				.HasColumnName("PCT012E187")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E187")
				.IsOptional();

			Property(p => p.PCT012E188)
				.HasColumnName("PCT012E188")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E188")
				.IsOptional();

			Property(p => p.PCT012E189)
				.HasColumnName("PCT012E189")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E189")
				.IsOptional();

			Property(p => p.PCT012E190)
				.HasColumnName("PCT012E190")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E190")
				.IsOptional();

			Property(p => p.PCT012E191)
				.HasColumnName("PCT012E191")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E191")
				.IsOptional();

			Property(p => p.PCT012E192)
				.HasColumnName("PCT012E192")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E192")
				.IsOptional();

			Property(p => p.PCT012E193)
				.HasColumnName("PCT012E193")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E193")
				.IsOptional();

			Property(p => p.PCT012E194)
				.HasColumnName("PCT012E194")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E194")
				.IsOptional();

			Property(p => p.PCT012E195)
				.HasColumnName("PCT012E195")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E195")
				.IsOptional();

			Property(p => p.PCT012E196)
				.HasColumnName("PCT012E196")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E196")
				.IsOptional();

			Property(p => p.PCT012E197)
				.HasColumnName("PCT012E197")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E197")
				.IsOptional();

			Property(p => p.PCT012E198)
				.HasColumnName("PCT012E198")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E198")
				.IsOptional();

			Property(p => p.PCT012E199)
				.HasColumnName("PCT012E199")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E199")
				.IsOptional();

			Property(p => p.PCT012E200)
				.HasColumnName("PCT012E200")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E200")
				.IsOptional();

			Property(p => p.PCT012E201)
				.HasColumnName("PCT012E201")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E201")
				.IsOptional();

			Property(p => p.PCT012E202)
				.HasColumnName("PCT012E202")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E202")
				.IsOptional();

			Property(p => p.PCT012E203)
				.HasColumnName("PCT012E203")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E203")
				.IsOptional();

			Property(p => p.PCT012E204)
				.HasColumnName("PCT012E204")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E204")
				.IsOptional();

			Property(p => p.PCT012E205)
				.HasColumnName("PCT012E205")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E205")
				.IsOptional();

			Property(p => p.PCT012E206)
				.HasColumnName("PCT012E206")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E206")
				.IsOptional();

			Property(p => p.PCT012E207)
				.HasColumnName("PCT012E207")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E207")
				.IsOptional();

			Property(p => p.PCT012E208)
				.HasColumnName("PCT012E208")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E208")
				.IsOptional();

			Property(p => p.PCT012E209)
				.HasColumnName("PCT012E209")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012E209")
				.IsOptional();
		}
	}
}
