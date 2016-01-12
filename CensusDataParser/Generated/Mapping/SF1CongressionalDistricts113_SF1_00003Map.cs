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

	public class SF1CongressionalDistricts113_SF1_00003Map : EntityTypeConfiguration<SF1CongressionalDistricts113_SF1_00003>
	{
		public SF1CongressionalDistricts113_SF1_00003Map()
		{
			ToTable("SF1_00003", "SF1CongressionalDistricts113");

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

			Property(p => p.P0030001)
				.HasColumnName("P0030001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030001")
				.IsOptional();

			Property(p => p.P0030002)
				.HasColumnName("P0030002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030002")
				.IsOptional();

			Property(p => p.P0030003)
				.HasColumnName("P0030003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030003")
				.IsOptional();

			Property(p => p.P0030004)
				.HasColumnName("P0030004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030004")
				.IsOptional();

			Property(p => p.P0030005)
				.HasColumnName("P0030005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030005")
				.IsOptional();

			Property(p => p.P0030006)
				.HasColumnName("P0030006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030006")
				.IsOptional();

			Property(p => p.P0030007)
				.HasColumnName("P0030007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030007")
				.IsOptional();

			Property(p => p.P0030008)
				.HasColumnName("P0030008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0030008")
				.IsOptional();

			Property(p => p.P0040001)
				.HasColumnName("P0040001")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040001")
				.IsOptional();

			Property(p => p.P0040002)
				.HasColumnName("P0040002")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040002")
				.IsOptional();

			Property(p => p.P0040003)
				.HasColumnName("P0040003")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0040003")
				.IsOptional();

			Property(p => p.P0050001)
				.HasColumnName("P0050001")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0050001")
				.IsOptional();

			Property(p => p.P0050002)
				.HasColumnName("P0050002")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0050002")
				.IsOptional();

			Property(p => p.P0050003)
				.HasColumnName("P0050003")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0050003")
				.IsOptional();

			Property(p => p.P0050004)
				.HasColumnName("P0050004")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0050004")
				.IsOptional();

			Property(p => p.P0050005)
				.HasColumnName("P0050005")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0050005")
				.IsOptional();

			Property(p => p.P0050006)
				.HasColumnName("P0050006")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0050006")
				.IsOptional();

			Property(p => p.P0050007)
				.HasColumnName("P0050007")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0050007")
				.IsOptional();

			Property(p => p.P0050008)
				.HasColumnName("P0050008")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0050008")
				.IsOptional();

			Property(p => p.P0050009)
				.HasColumnName("P0050009")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0050009")
				.IsOptional();

			Property(p => p.P0050010)
				.HasColumnName("P0050010")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0050010")
				.IsOptional();

			Property(p => p.P0050011)
				.HasColumnName("P0050011")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0050011")
				.IsOptional();

			Property(p => p.P0050012)
				.HasColumnName("P0050012")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0050012")
				.IsOptional();

			Property(p => p.P0050013)
				.HasColumnName("P0050013")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0050013")
				.IsOptional();

			Property(p => p.P0050014)
				.HasColumnName("P0050014")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0050014")
				.IsOptional();

			Property(p => p.P0050015)
				.HasColumnName("P0050015")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0050015")
				.IsOptional();

			Property(p => p.P0050016)
				.HasColumnName("P0050016")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0050016")
				.IsOptional();

			Property(p => p.P0050017)
				.HasColumnName("P0050017")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0050017")
				.IsOptional();

			Property(p => p.P0060001)
				.HasColumnName("P0060001")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0060001")
				.IsOptional();

			Property(p => p.P0060002)
				.HasColumnName("P0060002")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0060002")
				.IsOptional();

			Property(p => p.P0060003)
				.HasColumnName("P0060003")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0060003")
				.IsOptional();

			Property(p => p.P0060004)
				.HasColumnName("P0060004")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0060004")
				.IsOptional();

			Property(p => p.P0060005)
				.HasColumnName("P0060005")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0060005")
				.IsOptional();

			Property(p => p.P0060006)
				.HasColumnName("P0060006")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0060006")
				.IsOptional();

			Property(p => p.P0060007)
				.HasColumnName("P0060007")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0060007")
				.IsOptional();

			Property(p => p.P0070001)
				.HasColumnName("P0070001")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0070001")
				.IsOptional();

			Property(p => p.P0070002)
				.HasColumnName("P0070002")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0070002")
				.IsOptional();

			Property(p => p.P0070003)
				.HasColumnName("P0070003")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0070003")
				.IsOptional();

			Property(p => p.P0070004)
				.HasColumnName("P0070004")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0070004")
				.IsOptional();

			Property(p => p.P0070005)
				.HasColumnName("P0070005")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0070005")
				.IsOptional();

			Property(p => p.P0070006)
				.HasColumnName("P0070006")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0070006")
				.IsOptional();

			Property(p => p.P0070007)
				.HasColumnName("P0070007")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0070007")
				.IsOptional();

			Property(p => p.P0070008)
				.HasColumnName("P0070008")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0070008")
				.IsOptional();

			Property(p => p.P0070009)
				.HasColumnName("P0070009")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0070009")
				.IsOptional();

			Property(p => p.P0070010)
				.HasColumnName("P0070010")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0070010")
				.IsOptional();

			Property(p => p.P0070011)
				.HasColumnName("P0070011")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0070011")
				.IsOptional();

			Property(p => p.P0070012)
				.HasColumnName("P0070012")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0070012")
				.IsOptional();

			Property(p => p.P0070013)
				.HasColumnName("P0070013")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0070013")
				.IsOptional();

			Property(p => p.P0070014)
				.HasColumnName("P0070014")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0070014")
				.IsOptional();

			Property(p => p.P0070015)
				.HasColumnName("P0070015")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0070015")
				.IsOptional();

			Property(p => p.P0080001)
				.HasColumnName("P0080001")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080001")
				.IsOptional();

			Property(p => p.P0080002)
				.HasColumnName("P0080002")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080002")
				.IsOptional();

			Property(p => p.P0080003)
				.HasColumnName("P0080003")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080003")
				.IsOptional();

			Property(p => p.P0080004)
				.HasColumnName("P0080004")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080004")
				.IsOptional();

			Property(p => p.P0080005)
				.HasColumnName("P0080005")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080005")
				.IsOptional();

			Property(p => p.P0080006)
				.HasColumnName("P0080006")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080006")
				.IsOptional();

			Property(p => p.P0080007)
				.HasColumnName("P0080007")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080007")
				.IsOptional();

			Property(p => p.P0080008)
				.HasColumnName("P0080008")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080008")
				.IsOptional();

			Property(p => p.P0080009)
				.HasColumnName("P0080009")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080009")
				.IsOptional();

			Property(p => p.P0080010)
				.HasColumnName("P0080010")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080010")
				.IsOptional();

			Property(p => p.P0080011)
				.HasColumnName("P0080011")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080011")
				.IsOptional();

			Property(p => p.P0080012)
				.HasColumnName("P0080012")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080012")
				.IsOptional();

			Property(p => p.P0080013)
				.HasColumnName("P0080013")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080013")
				.IsOptional();

			Property(p => p.P0080014)
				.HasColumnName("P0080014")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080014")
				.IsOptional();

			Property(p => p.P0080015)
				.HasColumnName("P0080015")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080015")
				.IsOptional();

			Property(p => p.P0080016)
				.HasColumnName("P0080016")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080016")
				.IsOptional();

			Property(p => p.P0080017)
				.HasColumnName("P0080017")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080017")
				.IsOptional();

			Property(p => p.P0080018)
				.HasColumnName("P0080018")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080018")
				.IsOptional();

			Property(p => p.P0080019)
				.HasColumnName("P0080019")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080019")
				.IsOptional();

			Property(p => p.P0080020)
				.HasColumnName("P0080020")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080020")
				.IsOptional();

			Property(p => p.P0080021)
				.HasColumnName("P0080021")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080021")
				.IsOptional();

			Property(p => p.P0080022)
				.HasColumnName("P0080022")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080022")
				.IsOptional();

			Property(p => p.P0080023)
				.HasColumnName("P0080023")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080023")
				.IsOptional();

			Property(p => p.P0080024)
				.HasColumnName("P0080024")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080024")
				.IsOptional();

			Property(p => p.P0080025)
				.HasColumnName("P0080025")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080025")
				.IsOptional();

			Property(p => p.P0080026)
				.HasColumnName("P0080026")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080026")
				.IsOptional();

			Property(p => p.P0080027)
				.HasColumnName("P0080027")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080027")
				.IsOptional();

			Property(p => p.P0080028)
				.HasColumnName("P0080028")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080028")
				.IsOptional();

			Property(p => p.P0080029)
				.HasColumnName("P0080029")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080029")
				.IsOptional();

			Property(p => p.P0080030)
				.HasColumnName("P0080030")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080030")
				.IsOptional();

			Property(p => p.P0080031)
				.HasColumnName("P0080031")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080031")
				.IsOptional();

			Property(p => p.P0080032)
				.HasColumnName("P0080032")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080032")
				.IsOptional();

			Property(p => p.P0080033)
				.HasColumnName("P0080033")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080033")
				.IsOptional();

			Property(p => p.P0080034)
				.HasColumnName("P0080034")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080034")
				.IsOptional();

			Property(p => p.P0080035)
				.HasColumnName("P0080035")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080035")
				.IsOptional();

			Property(p => p.P0080036)
				.HasColumnName("P0080036")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080036")
				.IsOptional();

			Property(p => p.P0080037)
				.HasColumnName("P0080037")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080037")
				.IsOptional();

			Property(p => p.P0080038)
				.HasColumnName("P0080038")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080038")
				.IsOptional();

			Property(p => p.P0080039)
				.HasColumnName("P0080039")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080039")
				.IsOptional();

			Property(p => p.P0080040)
				.HasColumnName("P0080040")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080040")
				.IsOptional();

			Property(p => p.P0080041)
				.HasColumnName("P0080041")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080041")
				.IsOptional();

			Property(p => p.P0080042)
				.HasColumnName("P0080042")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080042")
				.IsOptional();

			Property(p => p.P0080043)
				.HasColumnName("P0080043")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080043")
				.IsOptional();

			Property(p => p.P0080044)
				.HasColumnName("P0080044")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080044")
				.IsOptional();

			Property(p => p.P0080045)
				.HasColumnName("P0080045")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080045")
				.IsOptional();

			Property(p => p.P0080046)
				.HasColumnName("P0080046")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080046")
				.IsOptional();

			Property(p => p.P0080047)
				.HasColumnName("P0080047")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080047")
				.IsOptional();

			Property(p => p.P0080048)
				.HasColumnName("P0080048")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080048")
				.IsOptional();

			Property(p => p.P0080049)
				.HasColumnName("P0080049")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080049")
				.IsOptional();

			Property(p => p.P0080050)
				.HasColumnName("P0080050")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080050")
				.IsOptional();

			Property(p => p.P0080051)
				.HasColumnName("P0080051")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080051")
				.IsOptional();

			Property(p => p.P0080052)
				.HasColumnName("P0080052")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080052")
				.IsOptional();

			Property(p => p.P0080053)
				.HasColumnName("P0080053")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080053")
				.IsOptional();

			Property(p => p.P0080054)
				.HasColumnName("P0080054")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080054")
				.IsOptional();

			Property(p => p.P0080055)
				.HasColumnName("P0080055")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080055")
				.IsOptional();

			Property(p => p.P0080056)
				.HasColumnName("P0080056")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080056")
				.IsOptional();

			Property(p => p.P0080057)
				.HasColumnName("P0080057")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080057")
				.IsOptional();

			Property(p => p.P0080058)
				.HasColumnName("P0080058")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080058")
				.IsOptional();

			Property(p => p.P0080059)
				.HasColumnName("P0080059")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080059")
				.IsOptional();

			Property(p => p.P0080060)
				.HasColumnName("P0080060")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080060")
				.IsOptional();

			Property(p => p.P0080061)
				.HasColumnName("P0080061")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080061")
				.IsOptional();

			Property(p => p.P0080062)
				.HasColumnName("P0080062")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080062")
				.IsOptional();

			Property(p => p.P0080063)
				.HasColumnName("P0080063")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080063")
				.IsOptional();

			Property(p => p.P0080064)
				.HasColumnName("P0080064")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080064")
				.IsOptional();

			Property(p => p.P0080065)
				.HasColumnName("P0080065")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080065")
				.IsOptional();

			Property(p => p.P0080066)
				.HasColumnName("P0080066")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080066")
				.IsOptional();

			Property(p => p.P0080067)
				.HasColumnName("P0080067")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080067")
				.IsOptional();

			Property(p => p.P0080068)
				.HasColumnName("P0080068")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080068")
				.IsOptional();

			Property(p => p.P0080069)
				.HasColumnName("P0080069")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080069")
				.IsOptional();

			Property(p => p.P0080070)
				.HasColumnName("P0080070")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080070")
				.IsOptional();

			Property(p => p.P0080071)
				.HasColumnName("P0080071")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0080071")
				.IsOptional();

			Property(p => p.P0090001)
				.HasColumnName("P0090001")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090001")
				.IsOptional();

			Property(p => p.P0090002)
				.HasColumnName("P0090002")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090002")
				.IsOptional();

			Property(p => p.P0090003)
				.HasColumnName("P0090003")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090003")
				.IsOptional();

			Property(p => p.P0090004)
				.HasColumnName("P0090004")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090004")
				.IsOptional();

			Property(p => p.P0090005)
				.HasColumnName("P0090005")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090005")
				.IsOptional();

			Property(p => p.P0090006)
				.HasColumnName("P0090006")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090006")
				.IsOptional();

			Property(p => p.P0090007)
				.HasColumnName("P0090007")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090007")
				.IsOptional();

			Property(p => p.P0090008)
				.HasColumnName("P0090008")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090008")
				.IsOptional();

			Property(p => p.P0090009)
				.HasColumnName("P0090009")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090009")
				.IsOptional();

			Property(p => p.P0090010)
				.HasColumnName("P0090010")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090010")
				.IsOptional();

			Property(p => p.P0090011)
				.HasColumnName("P0090011")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090011")
				.IsOptional();

			Property(p => p.P0090012)
				.HasColumnName("P0090012")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090012")
				.IsOptional();

			Property(p => p.P0090013)
				.HasColumnName("P0090013")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090013")
				.IsOptional();

			Property(p => p.P0090014)
				.HasColumnName("P0090014")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090014")
				.IsOptional();

			Property(p => p.P0090015)
				.HasColumnName("P0090015")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090015")
				.IsOptional();

			Property(p => p.P0090016)
				.HasColumnName("P0090016")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090016")
				.IsOptional();

			Property(p => p.P0090017)
				.HasColumnName("P0090017")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090017")
				.IsOptional();

			Property(p => p.P0090018)
				.HasColumnName("P0090018")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090018")
				.IsOptional();

			Property(p => p.P0090019)
				.HasColumnName("P0090019")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090019")
				.IsOptional();

			Property(p => p.P0090020)
				.HasColumnName("P0090020")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090020")
				.IsOptional();

			Property(p => p.P0090021)
				.HasColumnName("P0090021")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090021")
				.IsOptional();

			Property(p => p.P0090022)
				.HasColumnName("P0090022")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090022")
				.IsOptional();

			Property(p => p.P0090023)
				.HasColumnName("P0090023")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090023")
				.IsOptional();

			Property(p => p.P0090024)
				.HasColumnName("P0090024")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090024")
				.IsOptional();

			Property(p => p.P0090025)
				.HasColumnName("P0090025")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090025")
				.IsOptional();

			Property(p => p.P0090026)
				.HasColumnName("P0090026")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090026")
				.IsOptional();

			Property(p => p.P0090027)
				.HasColumnName("P0090027")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090027")
				.IsOptional();

			Property(p => p.P0090028)
				.HasColumnName("P0090028")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090028")
				.IsOptional();

			Property(p => p.P0090029)
				.HasColumnName("P0090029")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090029")
				.IsOptional();

			Property(p => p.P0090030)
				.HasColumnName("P0090030")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090030")
				.IsOptional();

			Property(p => p.P0090031)
				.HasColumnName("P0090031")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090031")
				.IsOptional();

			Property(p => p.P0090032)
				.HasColumnName("P0090032")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090032")
				.IsOptional();

			Property(p => p.P0090033)
				.HasColumnName("P0090033")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090033")
				.IsOptional();

			Property(p => p.P0090034)
				.HasColumnName("P0090034")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090034")
				.IsOptional();

			Property(p => p.P0090035)
				.HasColumnName("P0090035")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090035")
				.IsOptional();

			Property(p => p.P0090036)
				.HasColumnName("P0090036")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090036")
				.IsOptional();

			Property(p => p.P0090037)
				.HasColumnName("P0090037")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090037")
				.IsOptional();

			Property(p => p.P0090038)
				.HasColumnName("P0090038")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090038")
				.IsOptional();

			Property(p => p.P0090039)
				.HasColumnName("P0090039")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090039")
				.IsOptional();

			Property(p => p.P0090040)
				.HasColumnName("P0090040")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090040")
				.IsOptional();

			Property(p => p.P0090041)
				.HasColumnName("P0090041")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090041")
				.IsOptional();

			Property(p => p.P0090042)
				.HasColumnName("P0090042")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090042")
				.IsOptional();

			Property(p => p.P0090043)
				.HasColumnName("P0090043")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090043")
				.IsOptional();

			Property(p => p.P0090044)
				.HasColumnName("P0090044")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090044")
				.IsOptional();

			Property(p => p.P0090045)
				.HasColumnName("P0090045")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090045")
				.IsOptional();

			Property(p => p.P0090046)
				.HasColumnName("P0090046")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090046")
				.IsOptional();

			Property(p => p.P0090047)
				.HasColumnName("P0090047")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090047")
				.IsOptional();

			Property(p => p.P0090048)
				.HasColumnName("P0090048")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090048")
				.IsOptional();

			Property(p => p.P0090049)
				.HasColumnName("P0090049")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090049")
				.IsOptional();

			Property(p => p.P0090050)
				.HasColumnName("P0090050")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090050")
				.IsOptional();

			Property(p => p.P0090051)
				.HasColumnName("P0090051")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090051")
				.IsOptional();

			Property(p => p.P0090052)
				.HasColumnName("P0090052")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090052")
				.IsOptional();

			Property(p => p.P0090053)
				.HasColumnName("P0090053")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090053")
				.IsOptional();

			Property(p => p.P0090054)
				.HasColumnName("P0090054")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090054")
				.IsOptional();

			Property(p => p.P0090055)
				.HasColumnName("P0090055")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090055")
				.IsOptional();

			Property(p => p.P0090056)
				.HasColumnName("P0090056")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090056")
				.IsOptional();

			Property(p => p.P0090057)
				.HasColumnName("P0090057")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090057")
				.IsOptional();

			Property(p => p.P0090058)
				.HasColumnName("P0090058")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090058")
				.IsOptional();

			Property(p => p.P0090059)
				.HasColumnName("P0090059")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090059")
				.IsOptional();

			Property(p => p.P0090060)
				.HasColumnName("P0090060")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090060")
				.IsOptional();

			Property(p => p.P0090061)
				.HasColumnName("P0090061")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090061")
				.IsOptional();

			Property(p => p.P0090062)
				.HasColumnName("P0090062")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090062")
				.IsOptional();

			Property(p => p.P0090063)
				.HasColumnName("P0090063")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090063")
				.IsOptional();

			Property(p => p.P0090064)
				.HasColumnName("P0090064")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090064")
				.IsOptional();

			Property(p => p.P0090065)
				.HasColumnName("P0090065")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090065")
				.IsOptional();

			Property(p => p.P0090066)
				.HasColumnName("P0090066")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090066")
				.IsOptional();

			Property(p => p.P0090067)
				.HasColumnName("P0090067")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090067")
				.IsOptional();

			Property(p => p.P0090068)
				.HasColumnName("P0090068")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090068")
				.IsOptional();

			Property(p => p.P0090069)
				.HasColumnName("P0090069")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090069")
				.IsOptional();

			Property(p => p.P0090070)
				.HasColumnName("P0090070")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090070")
				.IsOptional();

			Property(p => p.P0090071)
				.HasColumnName("P0090071")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090071")
				.IsOptional();

			Property(p => p.P0090072)
				.HasColumnName("P0090072")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090072")
				.IsOptional();

			Property(p => p.P0090073)
				.HasColumnName("P0090073")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0090073")
				.IsOptional();
		}
	}
}
