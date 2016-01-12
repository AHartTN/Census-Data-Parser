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

	public class SF1CongressionalDistricts113_SF1_00006Map : EntityTypeConfiguration<SF1CongressionalDistricts113_SF1_00006>
	{
		public SF1CongressionalDistricts113_SF1_00006Map()
		{
			ToTable("SF1_00006", "SF1CongressionalDistricts113");

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

			Property(p => p.P0310001)
				.HasColumnName("P0310001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0310001")
				.IsOptional();

			Property(p => p.P0310002)
				.HasColumnName("P0310002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0310002")
				.IsOptional();

			Property(p => p.P0310003)
				.HasColumnName("P0310003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0310003")
				.IsOptional();

			Property(p => p.P0310004)
				.HasColumnName("P0310004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0310004")
				.IsOptional();

			Property(p => p.P0310005)
				.HasColumnName("P0310005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0310005")
				.IsOptional();

			Property(p => p.P0310006)
				.HasColumnName("P0310006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0310006")
				.IsOptional();

			Property(p => p.P0310007)
				.HasColumnName("P0310007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0310007")
				.IsOptional();

			Property(p => p.P0310008)
				.HasColumnName("P0310008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0310008")
				.IsOptional();

			Property(p => p.P0310009)
				.HasColumnName("P0310009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0310009")
				.IsOptional();

			Property(p => p.P0310010)
				.HasColumnName("P0310010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0310010")
				.IsOptional();

			Property(p => p.P0310011)
				.HasColumnName("P0310011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0310011")
				.IsOptional();

			Property(p => p.P0310012)
				.HasColumnName("P0310012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0310012")
				.IsOptional();

			Property(p => p.P0310013)
				.HasColumnName("P0310013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0310013")
				.IsOptional();

			Property(p => p.P0310014)
				.HasColumnName("P0310014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0310014")
				.IsOptional();

			Property(p => p.P0310015)
				.HasColumnName("P0310015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0310015")
				.IsOptional();

			Property(p => p.P0310016)
				.HasColumnName("P0310016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0310016")
				.IsOptional();

			Property(p => p.P0320001)
				.HasColumnName("P0320001")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320001")
				.IsOptional();

			Property(p => p.P0320002)
				.HasColumnName("P0320002")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320002")
				.IsOptional();

			Property(p => p.P0320003)
				.HasColumnName("P0320003")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320003")
				.IsOptional();

			Property(p => p.P0320004)
				.HasColumnName("P0320004")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320004")
				.IsOptional();

			Property(p => p.P0320005)
				.HasColumnName("P0320005")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320005")
				.IsOptional();

			Property(p => p.P0320006)
				.HasColumnName("P0320006")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320006")
				.IsOptional();

			Property(p => p.P0320007)
				.HasColumnName("P0320007")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320007")
				.IsOptional();

			Property(p => p.P0320008)
				.HasColumnName("P0320008")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320008")
				.IsOptional();

			Property(p => p.P0320009)
				.HasColumnName("P0320009")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320009")
				.IsOptional();

			Property(p => p.P0320010)
				.HasColumnName("P0320010")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320010")
				.IsOptional();

			Property(p => p.P0320011)
				.HasColumnName("P0320011")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320011")
				.IsOptional();

			Property(p => p.P0320012)
				.HasColumnName("P0320012")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320012")
				.IsOptional();

			Property(p => p.P0320013)
				.HasColumnName("P0320013")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320013")
				.IsOptional();

			Property(p => p.P0320014)
				.HasColumnName("P0320014")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320014")
				.IsOptional();

			Property(p => p.P0320015)
				.HasColumnName("P0320015")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320015")
				.IsOptional();

			Property(p => p.P0320016)
				.HasColumnName("P0320016")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320016")
				.IsOptional();

			Property(p => p.P0320017)
				.HasColumnName("P0320017")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320017")
				.IsOptional();

			Property(p => p.P0320018)
				.HasColumnName("P0320018")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320018")
				.IsOptional();

			Property(p => p.P0320019)
				.HasColumnName("P0320019")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320019")
				.IsOptional();

			Property(p => p.P0320020)
				.HasColumnName("P0320020")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320020")
				.IsOptional();

			Property(p => p.P0320021)
				.HasColumnName("P0320021")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320021")
				.IsOptional();

			Property(p => p.P0320022)
				.HasColumnName("P0320022")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320022")
				.IsOptional();

			Property(p => p.P0320023)
				.HasColumnName("P0320023")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320023")
				.IsOptional();

			Property(p => p.P0320024)
				.HasColumnName("P0320024")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320024")
				.IsOptional();

			Property(p => p.P0320025)
				.HasColumnName("P0320025")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320025")
				.IsOptional();

			Property(p => p.P0320026)
				.HasColumnName("P0320026")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320026")
				.IsOptional();

			Property(p => p.P0320027)
				.HasColumnName("P0320027")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320027")
				.IsOptional();

			Property(p => p.P0320028)
				.HasColumnName("P0320028")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320028")
				.IsOptional();

			Property(p => p.P0320029)
				.HasColumnName("P0320029")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320029")
				.IsOptional();

			Property(p => p.P0320030)
				.HasColumnName("P0320030")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320030")
				.IsOptional();

			Property(p => p.P0320031)
				.HasColumnName("P0320031")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320031")
				.IsOptional();

			Property(p => p.P0320032)
				.HasColumnName("P0320032")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320032")
				.IsOptional();

			Property(p => p.P0320033)
				.HasColumnName("P0320033")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320033")
				.IsOptional();

			Property(p => p.P0320034)
				.HasColumnName("P0320034")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320034")
				.IsOptional();

			Property(p => p.P0320035)
				.HasColumnName("P0320035")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320035")
				.IsOptional();

			Property(p => p.P0320036)
				.HasColumnName("P0320036")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320036")
				.IsOptional();

			Property(p => p.P0320037)
				.HasColumnName("P0320037")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320037")
				.IsOptional();

			Property(p => p.P0320038)
				.HasColumnName("P0320038")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320038")
				.IsOptional();

			Property(p => p.P0320039)
				.HasColumnName("P0320039")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320039")
				.IsOptional();

			Property(p => p.P0320040)
				.HasColumnName("P0320040")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320040")
				.IsOptional();

			Property(p => p.P0320041)
				.HasColumnName("P0320041")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320041")
				.IsOptional();

			Property(p => p.P0320042)
				.HasColumnName("P0320042")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320042")
				.IsOptional();

			Property(p => p.P0320043)
				.HasColumnName("P0320043")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320043")
				.IsOptional();

			Property(p => p.P0320044)
				.HasColumnName("P0320044")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320044")
				.IsOptional();

			Property(p => p.P0320045)
				.HasColumnName("P0320045")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0320045")
				.IsOptional();

			Property(p => p.P0330001)
				.HasColumnName("P0330001")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0330001")
				.IsOptional();

			Property(p => p.P0330002)
				.HasColumnName("P0330002")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0330002")
				.IsOptional();

			Property(p => p.P0330003)
				.HasColumnName("P0330003")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0330003")
				.IsOptional();

			Property(p => p.P0330004)
				.HasColumnName("P0330004")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0330004")
				.IsOptional();

			Property(p => p.P0330005)
				.HasColumnName("P0330005")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0330005")
				.IsOptional();

			Property(p => p.P0330006)
				.HasColumnName("P0330006")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0330006")
				.IsOptional();

			Property(p => p.P0330007)
				.HasColumnName("P0330007")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0330007")
				.IsOptional();

			Property(p => p.P0340001)
				.HasColumnName("P0340001")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0340001")
				.IsOptional();

			Property(p => p.P0340002)
				.HasColumnName("P0340002")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0340002")
				.IsOptional();

			Property(p => p.P0340003)
				.HasColumnName("P0340003")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0340003")
				.IsOptional();

			Property(p => p.P0340004)
				.HasColumnName("P0340004")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0340004")
				.IsOptional();

			Property(p => p.P0340005)
				.HasColumnName("P0340005")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0340005")
				.IsOptional();

			Property(p => p.P0340006)
				.HasColumnName("P0340006")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0340006")
				.IsOptional();

			Property(p => p.P0340007)
				.HasColumnName("P0340007")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0340007")
				.IsOptional();

			Property(p => p.P0340008)
				.HasColumnName("P0340008")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0340008")
				.IsOptional();

			Property(p => p.P0340009)
				.HasColumnName("P0340009")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0340009")
				.IsOptional();

			Property(p => p.P0340010)
				.HasColumnName("P0340010")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0340010")
				.IsOptional();

			Property(p => p.P0340011)
				.HasColumnName("P0340011")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0340011")
				.IsOptional();

			Property(p => p.P0340012)
				.HasColumnName("P0340012")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0340012")
				.IsOptional();

			Property(p => p.P0340013)
				.HasColumnName("P0340013")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0340013")
				.IsOptional();

			Property(p => p.P0340014)
				.HasColumnName("P0340014")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0340014")
				.IsOptional();

			Property(p => p.P0340015)
				.HasColumnName("P0340015")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0340015")
				.IsOptional();

			Property(p => p.P0340016)
				.HasColumnName("P0340016")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0340016")
				.IsOptional();

			Property(p => p.P0340017)
				.HasColumnName("P0340017")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0340017")
				.IsOptional();

			Property(p => p.P0340018)
				.HasColumnName("P0340018")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0340018")
				.IsOptional();

			Property(p => p.P0340019)
				.HasColumnName("P0340019")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0340019")
				.IsOptional();

			Property(p => p.P0340020)
				.HasColumnName("P0340020")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0340020")
				.IsOptional();

			Property(p => p.P0340021)
				.HasColumnName("P0340021")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0340021")
				.IsOptional();

			Property(p => p.P0340022)
				.HasColumnName("P0340022")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0340022")
				.IsOptional();

			Property(p => p.P0350001)
				.HasColumnName("P0350001")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0350001")
				.IsOptional();

			Property(p => p.P0360001)
				.HasColumnName("P0360001")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0360001")
				.IsOptional();

			Property(p => p.P0360002)
				.HasColumnName("P0360002")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0360002")
				.IsOptional();

			Property(p => p.P0360003)
				.HasColumnName("P0360003")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0360003")
				.IsOptional();

			Property(p => p.P0370001)
				.HasColumnName("P0370001")
				.HasColumnOrder(99)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0370001")
				.IsOptional();

			Property(p => p.P0370002)
				.HasColumnName("P0370002")
				.HasColumnOrder(100)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0370002")
				.IsOptional();

			Property(p => p.P0370003)
				.HasColumnName("P0370003")
				.HasColumnOrder(101)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0370003")
				.IsOptional();

			Property(p => p.P0380001)
				.HasColumnName("P0380001")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0380001")
				.IsOptional();

			Property(p => p.P0380002)
				.HasColumnName("P0380002")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0380002")
				.IsOptional();

			Property(p => p.P0380003)
				.HasColumnName("P0380003")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0380003")
				.IsOptional();

			Property(p => p.P0380004)
				.HasColumnName("P0380004")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0380004")
				.IsOptional();

			Property(p => p.P0380005)
				.HasColumnName("P0380005")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0380005")
				.IsOptional();

			Property(p => p.P0380006)
				.HasColumnName("P0380006")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0380006")
				.IsOptional();

			Property(p => p.P0380007)
				.HasColumnName("P0380007")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0380007")
				.IsOptional();

			Property(p => p.P0380008)
				.HasColumnName("P0380008")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0380008")
				.IsOptional();

			Property(p => p.P0380009)
				.HasColumnName("P0380009")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0380009")
				.IsOptional();

			Property(p => p.P0380010)
				.HasColumnName("P0380010")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0380010")
				.IsOptional();

			Property(p => p.P0380011)
				.HasColumnName("P0380011")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0380011")
				.IsOptional();

			Property(p => p.P0380012)
				.HasColumnName("P0380012")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0380012")
				.IsOptional();

			Property(p => p.P0380013)
				.HasColumnName("P0380013")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0380013")
				.IsOptional();

			Property(p => p.P0380014)
				.HasColumnName("P0380014")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0380014")
				.IsOptional();

			Property(p => p.P0380015)
				.HasColumnName("P0380015")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0380015")
				.IsOptional();

			Property(p => p.P0380016)
				.HasColumnName("P0380016")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0380016")
				.IsOptional();

			Property(p => p.P0380017)
				.HasColumnName("P0380017")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0380017")
				.IsOptional();

			Property(p => p.P0380018)
				.HasColumnName("P0380018")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0380018")
				.IsOptional();

			Property(p => p.P0380019)
				.HasColumnName("P0380019")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0380019")
				.IsOptional();

			Property(p => p.P0380020)
				.HasColumnName("P0380020")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0380020")
				.IsOptional();

			Property(p => p.P0390001)
				.HasColumnName("P0390001")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0390001")
				.IsOptional();

			Property(p => p.P0390002)
				.HasColumnName("P0390002")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0390002")
				.IsOptional();

			Property(p => p.P0390003)
				.HasColumnName("P0390003")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0390003")
				.IsOptional();

			Property(p => p.P0390004)
				.HasColumnName("P0390004")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0390004")
				.IsOptional();

			Property(p => p.P0390005)
				.HasColumnName("P0390005")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0390005")
				.IsOptional();

			Property(p => p.P0390006)
				.HasColumnName("P0390006")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0390006")
				.IsOptional();

			Property(p => p.P0390007)
				.HasColumnName("P0390007")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0390007")
				.IsOptional();

			Property(p => p.P0390008)
				.HasColumnName("P0390008")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0390008")
				.IsOptional();

			Property(p => p.P0390009)
				.HasColumnName("P0390009")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0390009")
				.IsOptional();

			Property(p => p.P0390010)
				.HasColumnName("P0390010")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0390010")
				.IsOptional();

			Property(p => p.P0390011)
				.HasColumnName("P0390011")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0390011")
				.IsOptional();

			Property(p => p.P0390012)
				.HasColumnName("P0390012")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0390012")
				.IsOptional();

			Property(p => p.P0390013)
				.HasColumnName("P0390013")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0390013")
				.IsOptional();

			Property(p => p.P0390014)
				.HasColumnName("P0390014")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0390014")
				.IsOptional();

			Property(p => p.P0390015)
				.HasColumnName("P0390015")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0390015")
				.IsOptional();

			Property(p => p.P0390016)
				.HasColumnName("P0390016")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0390016")
				.IsOptional();

			Property(p => p.P0390017)
				.HasColumnName("P0390017")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0390017")
				.IsOptional();

			Property(p => p.P0390018)
				.HasColumnName("P0390018")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0390018")
				.IsOptional();

			Property(p => p.P0390019)
				.HasColumnName("P0390019")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0390019")
				.IsOptional();

			Property(p => p.P0390020)
				.HasColumnName("P0390020")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0390020")
				.IsOptional();

			Property(p => p.P0400001)
				.HasColumnName("P0400001")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0400001")
				.IsOptional();

			Property(p => p.P0400002)
				.HasColumnName("P0400002")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0400002")
				.IsOptional();

			Property(p => p.P0400003)
				.HasColumnName("P0400003")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0400003")
				.IsOptional();

			Property(p => p.P0400004)
				.HasColumnName("P0400004")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0400004")
				.IsOptional();

			Property(p => p.P0400005)
				.HasColumnName("P0400005")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0400005")
				.IsOptional();

			Property(p => p.P0400006)
				.HasColumnName("P0400006")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0400006")
				.IsOptional();

			Property(p => p.P0400007)
				.HasColumnName("P0400007")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0400007")
				.IsOptional();

			Property(p => p.P0400008)
				.HasColumnName("P0400008")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0400008")
				.IsOptional();

			Property(p => p.P0400009)
				.HasColumnName("P0400009")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0400009")
				.IsOptional();

			Property(p => p.P0400010)
				.HasColumnName("P0400010")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0400010")
				.IsOptional();

			Property(p => p.P0400011)
				.HasColumnName("P0400011")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0400011")
				.IsOptional();

			Property(p => p.P0400012)
				.HasColumnName("P0400012")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0400012")
				.IsOptional();

			Property(p => p.P0400013)
				.HasColumnName("P0400013")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0400013")
				.IsOptional();

			Property(p => p.P0400014)
				.HasColumnName("P0400014")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0400014")
				.IsOptional();

			Property(p => p.P0400015)
				.HasColumnName("P0400015")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0400015")
				.IsOptional();

			Property(p => p.P0400016)
				.HasColumnName("P0400016")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0400016")
				.IsOptional();

			Property(p => p.P0400017)
				.HasColumnName("P0400017")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0400017")
				.IsOptional();

			Property(p => p.P0400018)
				.HasColumnName("P0400018")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0400018")
				.IsOptional();

			Property(p => p.P0400019)
				.HasColumnName("P0400019")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0400019")
				.IsOptional();

			Property(p => p.P0400020)
				.HasColumnName("P0400020")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0400020")
				.IsOptional();

			Property(p => p.P0410001)
				.HasColumnName("P0410001")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0410001")
				.IsOptional();

			Property(p => p.P0410002)
				.HasColumnName("P0410002")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0410002")
				.IsOptional();

			Property(p => p.P0410003)
				.HasColumnName("P0410003")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0410003")
				.IsOptional();

			Property(p => p.P0410004)
				.HasColumnName("P0410004")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0410004")
				.IsOptional();

			Property(p => p.P0410005)
				.HasColumnName("P0410005")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0410005")
				.IsOptional();

			Property(p => p.P0410006)
				.HasColumnName("P0410006")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0410006")
				.IsOptional();

			Property(p => p.P0420001)
				.HasColumnName("P0420001")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0420001")
				.IsOptional();

			Property(p => p.P0420002)
				.HasColumnName("P0420002")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0420002")
				.IsOptional();

			Property(p => p.P0420003)
				.HasColumnName("P0420003")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0420003")
				.IsOptional();

			Property(p => p.P0420004)
				.HasColumnName("P0420004")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0420004")
				.IsOptional();

			Property(p => p.P0420005)
				.HasColumnName("P0420005")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0420005")
				.IsOptional();

			Property(p => p.P0420006)
				.HasColumnName("P0420006")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0420006")
				.IsOptional();

			Property(p => p.P0420007)
				.HasColumnName("P0420007")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0420007")
				.IsOptional();

			Property(p => p.P0420008)
				.HasColumnName("P0420008")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0420008")
				.IsOptional();

			Property(p => p.P0420009)
				.HasColumnName("P0420009")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0420009")
				.IsOptional();

			Property(p => p.P0420010)
				.HasColumnName("P0420010")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0420010")
				.IsOptional();

			Property(p => p.P0430001)
				.HasColumnName("P0430001")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430001")
				.IsOptional();

			Property(p => p.P0430002)
				.HasColumnName("P0430002")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430002")
				.IsOptional();

			Property(p => p.P0430003)
				.HasColumnName("P0430003")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430003")
				.IsOptional();

			Property(p => p.P0430004)
				.HasColumnName("P0430004")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430004")
				.IsOptional();

			Property(p => p.P0430005)
				.HasColumnName("P0430005")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430005")
				.IsOptional();

			Property(p => p.P0430006)
				.HasColumnName("P0430006")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430006")
				.IsOptional();

			Property(p => p.P0430007)
				.HasColumnName("P0430007")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430007")
				.IsOptional();

			Property(p => p.P0430008)
				.HasColumnName("P0430008")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430008")
				.IsOptional();

			Property(p => p.P0430009)
				.HasColumnName("P0430009")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430009")
				.IsOptional();

			Property(p => p.P0430010)
				.HasColumnName("P0430010")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430010")
				.IsOptional();

			Property(p => p.P0430011)
				.HasColumnName("P0430011")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430011")
				.IsOptional();

			Property(p => p.P0430012)
				.HasColumnName("P0430012")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430012")
				.IsOptional();

			Property(p => p.P0430013)
				.HasColumnName("P0430013")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430013")
				.IsOptional();

			Property(p => p.P0430014)
				.HasColumnName("P0430014")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430014")
				.IsOptional();

			Property(p => p.P0430015)
				.HasColumnName("P0430015")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430015")
				.IsOptional();

			Property(p => p.P0430016)
				.HasColumnName("P0430016")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430016")
				.IsOptional();

			Property(p => p.P0430017)
				.HasColumnName("P0430017")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430017")
				.IsOptional();

			Property(p => p.P0430018)
				.HasColumnName("P0430018")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430018")
				.IsOptional();

			Property(p => p.P0430019)
				.HasColumnName("P0430019")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430019")
				.IsOptional();

			Property(p => p.P0430020)
				.HasColumnName("P0430020")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430020")
				.IsOptional();

			Property(p => p.P0430021)
				.HasColumnName("P0430021")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430021")
				.IsOptional();

			Property(p => p.P0430022)
				.HasColumnName("P0430022")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430022")
				.IsOptional();

			Property(p => p.P0430023)
				.HasColumnName("P0430023")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430023")
				.IsOptional();

			Property(p => p.P0430024)
				.HasColumnName("P0430024")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430024")
				.IsOptional();

			Property(p => p.P0430025)
				.HasColumnName("P0430025")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430025")
				.IsOptional();

			Property(p => p.P0430026)
				.HasColumnName("P0430026")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430026")
				.IsOptional();

			Property(p => p.P0430027)
				.HasColumnName("P0430027")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430027")
				.IsOptional();

			Property(p => p.P0430028)
				.HasColumnName("P0430028")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430028")
				.IsOptional();

			Property(p => p.P0430029)
				.HasColumnName("P0430029")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430029")
				.IsOptional();

			Property(p => p.P0430030)
				.HasColumnName("P0430030")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430030")
				.IsOptional();

			Property(p => p.P0430031)
				.HasColumnName("P0430031")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430031")
				.IsOptional();

			Property(p => p.P0430032)
				.HasColumnName("P0430032")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430032")
				.IsOptional();

			Property(p => p.P0430033)
				.HasColumnName("P0430033")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430033")
				.IsOptional();

			Property(p => p.P0430034)
				.HasColumnName("P0430034")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430034")
				.IsOptional();

			Property(p => p.P0430035)
				.HasColumnName("P0430035")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430035")
				.IsOptional();

			Property(p => p.P0430036)
				.HasColumnName("P0430036")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430036")
				.IsOptional();

			Property(p => p.P0430037)
				.HasColumnName("P0430037")
				.HasColumnOrder(214)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430037")
				.IsOptional();

			Property(p => p.P0430038)
				.HasColumnName("P0430038")
				.HasColumnOrder(215)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430038")
				.IsOptional();

			Property(p => p.P0430039)
				.HasColumnName("P0430039")
				.HasColumnOrder(216)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430039")
				.IsOptional();

			Property(p => p.P0430040)
				.HasColumnName("P0430040")
				.HasColumnOrder(217)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430040")
				.IsOptional();

			Property(p => p.P0430041)
				.HasColumnName("P0430041")
				.HasColumnOrder(218)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430041")
				.IsOptional();

			Property(p => p.P0430042)
				.HasColumnName("P0430042")
				.HasColumnOrder(219)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430042")
				.IsOptional();

			Property(p => p.P0430043)
				.HasColumnName("P0430043")
				.HasColumnOrder(220)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430043")
				.IsOptional();

			Property(p => p.P0430044)
				.HasColumnName("P0430044")
				.HasColumnOrder(221)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430044")
				.IsOptional();

			Property(p => p.P0430045)
				.HasColumnName("P0430045")
				.HasColumnOrder(222)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430045")
				.IsOptional();

			Property(p => p.P0430046)
				.HasColumnName("P0430046")
				.HasColumnOrder(223)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430046")
				.IsOptional();

			Property(p => p.P0430047)
				.HasColumnName("P0430047")
				.HasColumnOrder(224)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430047")
				.IsOptional();

			Property(p => p.P0430048)
				.HasColumnName("P0430048")
				.HasColumnOrder(225)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430048")
				.IsOptional();

			Property(p => p.P0430049)
				.HasColumnName("P0430049")
				.HasColumnOrder(226)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430049")
				.IsOptional();

			Property(p => p.P0430050)
				.HasColumnName("P0430050")
				.HasColumnOrder(227)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430050")
				.IsOptional();

			Property(p => p.P0430051)
				.HasColumnName("P0430051")
				.HasColumnOrder(228)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430051")
				.IsOptional();

			Property(p => p.P0430052)
				.HasColumnName("P0430052")
				.HasColumnOrder(229)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430052")
				.IsOptional();

			Property(p => p.P0430053)
				.HasColumnName("P0430053")
				.HasColumnOrder(230)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430053")
				.IsOptional();

			Property(p => p.P0430054)
				.HasColumnName("P0430054")
				.HasColumnOrder(231)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430054")
				.IsOptional();

			Property(p => p.P0430055)
				.HasColumnName("P0430055")
				.HasColumnOrder(232)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430055")
				.IsOptional();

			Property(p => p.P0430056)
				.HasColumnName("P0430056")
				.HasColumnOrder(233)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430056")
				.IsOptional();

			Property(p => p.P0430057)
				.HasColumnName("P0430057")
				.HasColumnOrder(234)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430057")
				.IsOptional();

			Property(p => p.P0430058)
				.HasColumnName("P0430058")
				.HasColumnOrder(235)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430058")
				.IsOptional();

			Property(p => p.P0430059)
				.HasColumnName("P0430059")
				.HasColumnOrder(236)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430059")
				.IsOptional();

			Property(p => p.P0430060)
				.HasColumnName("P0430060")
				.HasColumnOrder(237)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430060")
				.IsOptional();

			Property(p => p.P0430061)
				.HasColumnName("P0430061")
				.HasColumnOrder(238)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430061")
				.IsOptional();

			Property(p => p.P0430062)
				.HasColumnName("P0430062")
				.HasColumnOrder(239)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430062")
				.IsOptional();

			Property(p => p.P0430063)
				.HasColumnName("P0430063")
				.HasColumnOrder(240)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0430063")
				.IsOptional();

			Property(p => p.P0440001)
				.HasColumnName("P0440001")
				.HasColumnOrder(241)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0440001")
				.IsOptional();

			Property(p => p.P0440002)
				.HasColumnName("P0440002")
				.HasColumnOrder(242)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0440002")
				.IsOptional();

			Property(p => p.P0440003)
				.HasColumnName("P0440003")
				.HasColumnOrder(243)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0440003")
				.IsOptional();

			Property(p => p.P0450001)
				.HasColumnName("P0450001")
				.HasColumnOrder(244)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0450001")
				.IsOptional();

			Property(p => p.P0450002)
				.HasColumnName("P0450002")
				.HasColumnOrder(245)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0450002")
				.IsOptional();

			Property(p => p.P0450003)
				.HasColumnName("P0450003")
				.HasColumnOrder(246)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0450003")
				.IsOptional();

			Property(p => p.P0460001)
				.HasColumnName("P0460001")
				.HasColumnOrder(247)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0460001")
				.IsOptional();

			Property(p => p.P0460002)
				.HasColumnName("P0460002")
				.HasColumnOrder(248)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0460002")
				.IsOptional();

			Property(p => p.P0460003)
				.HasColumnName("P0460003")
				.HasColumnOrder(249)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0460003")
				.IsOptional();

			Property(p => p.P0470001)
				.HasColumnName("P0470001")
				.HasColumnOrder(250)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0470001")
				.IsOptional();

			Property(p => p.P0470002)
				.HasColumnName("P0470002")
				.HasColumnOrder(251)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0470002")
				.IsOptional();

			Property(p => p.P0470003)
				.HasColumnName("P0470003")
				.HasColumnOrder(252)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0470003")
				.IsOptional();

			Property(p => p.P0480001)
				.HasColumnName("P0480001")
				.HasColumnOrder(253)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0480001")
				.IsOptional();

			Property(p => p.P0480002)
				.HasColumnName("P0480002")
				.HasColumnOrder(254)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0480002")
				.IsOptional();

			Property(p => p.P0480003)
				.HasColumnName("P0480003")
				.HasColumnOrder(255)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0480003")
				.IsOptional();

			Property(p => p.P0490001)
				.HasColumnName("P0490001")
				.HasColumnOrder(256)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0490001")
				.IsOptional();

			Property(p => p.P0490002)
				.HasColumnName("P0490002")
				.HasColumnOrder(257)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0490002")
				.IsOptional();

			Property(p => p.P0490003)
				.HasColumnName("P0490003")
				.HasColumnOrder(258)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P0490003")
				.IsOptional();
		}
	}
}
