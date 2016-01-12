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

	public class SummaryOne_SF1_00040Map : EntityTypeConfiguration<SummaryOne_SF1_00040>
	{
		public SummaryOne_SF1_00040Map()
		{
			ToTable("SF1_00040", "SummaryOne");

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

			Property(p => p.PCO0010001)
				.HasColumnName("PCO0010001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010001")
				.IsOptional();

			Property(p => p.PCO0010002)
				.HasColumnName("PCO0010002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010002")
				.IsOptional();

			Property(p => p.PCO0010003)
				.HasColumnName("PCO0010003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010003")
				.IsOptional();

			Property(p => p.PCO0010004)
				.HasColumnName("PCO0010004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010004")
				.IsOptional();

			Property(p => p.PCO0010005)
				.HasColumnName("PCO0010005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010005")
				.IsOptional();

			Property(p => p.PCO0010006)
				.HasColumnName("PCO0010006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010006")
				.IsOptional();

			Property(p => p.PCO0010007)
				.HasColumnName("PCO0010007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010007")
				.IsOptional();

			Property(p => p.PCO0010008)
				.HasColumnName("PCO0010008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010008")
				.IsOptional();

			Property(p => p.PCO0010009)
				.HasColumnName("PCO0010009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010009")
				.IsOptional();

			Property(p => p.PCO0010010)
				.HasColumnName("PCO0010010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010010")
				.IsOptional();

			Property(p => p.PCO0010011)
				.HasColumnName("PCO0010011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010011")
				.IsOptional();

			Property(p => p.PCO0010012)
				.HasColumnName("PCO0010012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010012")
				.IsOptional();

			Property(p => p.PCO0010013)
				.HasColumnName("PCO0010013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010013")
				.IsOptional();

			Property(p => p.PCO0010014)
				.HasColumnName("PCO0010014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010014")
				.IsOptional();

			Property(p => p.PCO0010015)
				.HasColumnName("PCO0010015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010015")
				.IsOptional();

			Property(p => p.PCO0010016)
				.HasColumnName("PCO0010016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010016")
				.IsOptional();

			Property(p => p.PCO0010017)
				.HasColumnName("PCO0010017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010017")
				.IsOptional();

			Property(p => p.PCO0010018)
				.HasColumnName("PCO0010018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010018")
				.IsOptional();

			Property(p => p.PCO0010019)
				.HasColumnName("PCO0010019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010019")
				.IsOptional();

			Property(p => p.PCO0010020)
				.HasColumnName("PCO0010020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010020")
				.IsOptional();

			Property(p => p.PCO0010021)
				.HasColumnName("PCO0010021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010021")
				.IsOptional();

			Property(p => p.PCO0010022)
				.HasColumnName("PCO0010022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010022")
				.IsOptional();

			Property(p => p.PCO0010023)
				.HasColumnName("PCO0010023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010023")
				.IsOptional();

			Property(p => p.PCO0010024)
				.HasColumnName("PCO0010024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010024")
				.IsOptional();

			Property(p => p.PCO0010025)
				.HasColumnName("PCO0010025")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010025")
				.IsOptional();

			Property(p => p.PCO0010026)
				.HasColumnName("PCO0010026")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010026")
				.IsOptional();

			Property(p => p.PCO0010027)
				.HasColumnName("PCO0010027")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010027")
				.IsOptional();

			Property(p => p.PCO0010028)
				.HasColumnName("PCO0010028")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010028")
				.IsOptional();

			Property(p => p.PCO0010029)
				.HasColumnName("PCO0010029")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010029")
				.IsOptional();

			Property(p => p.PCO0010030)
				.HasColumnName("PCO0010030")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010030")
				.IsOptional();

			Property(p => p.PCO0010031)
				.HasColumnName("PCO0010031")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010031")
				.IsOptional();

			Property(p => p.PCO0010032)
				.HasColumnName("PCO0010032")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010032")
				.IsOptional();

			Property(p => p.PCO0010033)
				.HasColumnName("PCO0010033")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010033")
				.IsOptional();

			Property(p => p.PCO0010034)
				.HasColumnName("PCO0010034")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010034")
				.IsOptional();

			Property(p => p.PCO0010035)
				.HasColumnName("PCO0010035")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010035")
				.IsOptional();

			Property(p => p.PCO0010036)
				.HasColumnName("PCO0010036")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010036")
				.IsOptional();

			Property(p => p.PCO0010037)
				.HasColumnName("PCO0010037")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010037")
				.IsOptional();

			Property(p => p.PCO0010038)
				.HasColumnName("PCO0010038")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010038")
				.IsOptional();

			Property(p => p.PCO0010039)
				.HasColumnName("PCO0010039")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0010039")
				.IsOptional();

			Property(p => p.PCO0020001)
				.HasColumnName("PCO0020001")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020001")
				.IsOptional();

			Property(p => p.PCO0020002)
				.HasColumnName("PCO0020002")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020002")
				.IsOptional();

			Property(p => p.PCO0020003)
				.HasColumnName("PCO0020003")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020003")
				.IsOptional();

			Property(p => p.PCO0020004)
				.HasColumnName("PCO0020004")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020004")
				.IsOptional();

			Property(p => p.PCO0020005)
				.HasColumnName("PCO0020005")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020005")
				.IsOptional();

			Property(p => p.PCO0020006)
				.HasColumnName("PCO0020006")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020006")
				.IsOptional();

			Property(p => p.PCO0020007)
				.HasColumnName("PCO0020007")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020007")
				.IsOptional();

			Property(p => p.PCO0020008)
				.HasColumnName("PCO0020008")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020008")
				.IsOptional();

			Property(p => p.PCO0020009)
				.HasColumnName("PCO0020009")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020009")
				.IsOptional();

			Property(p => p.PCO0020010)
				.HasColumnName("PCO0020010")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020010")
				.IsOptional();

			Property(p => p.PCO0020011)
				.HasColumnName("PCO0020011")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020011")
				.IsOptional();

			Property(p => p.PCO0020012)
				.HasColumnName("PCO0020012")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020012")
				.IsOptional();

			Property(p => p.PCO0020013)
				.HasColumnName("PCO0020013")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020013")
				.IsOptional();

			Property(p => p.PCO0020014)
				.HasColumnName("PCO0020014")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020014")
				.IsOptional();

			Property(p => p.PCO0020015)
				.HasColumnName("PCO0020015")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020015")
				.IsOptional();

			Property(p => p.PCO0020016)
				.HasColumnName("PCO0020016")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020016")
				.IsOptional();

			Property(p => p.PCO0020017)
				.HasColumnName("PCO0020017")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020017")
				.IsOptional();

			Property(p => p.PCO0020018)
				.HasColumnName("PCO0020018")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020018")
				.IsOptional();

			Property(p => p.PCO0020019)
				.HasColumnName("PCO0020019")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020019")
				.IsOptional();

			Property(p => p.PCO0020020)
				.HasColumnName("PCO0020020")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020020")
				.IsOptional();

			Property(p => p.PCO0020021)
				.HasColumnName("PCO0020021")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020021")
				.IsOptional();

			Property(p => p.PCO0020022)
				.HasColumnName("PCO0020022")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020022")
				.IsOptional();

			Property(p => p.PCO0020023)
				.HasColumnName("PCO0020023")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020023")
				.IsOptional();

			Property(p => p.PCO0020024)
				.HasColumnName("PCO0020024")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020024")
				.IsOptional();

			Property(p => p.PCO0020025)
				.HasColumnName("PCO0020025")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020025")
				.IsOptional();

			Property(p => p.PCO0020026)
				.HasColumnName("PCO0020026")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020026")
				.IsOptional();

			Property(p => p.PCO0020027)
				.HasColumnName("PCO0020027")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020027")
				.IsOptional();

			Property(p => p.PCO0020028)
				.HasColumnName("PCO0020028")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020028")
				.IsOptional();

			Property(p => p.PCO0020029)
				.HasColumnName("PCO0020029")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020029")
				.IsOptional();

			Property(p => p.PCO0020030)
				.HasColumnName("PCO0020030")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020030")
				.IsOptional();

			Property(p => p.PCO0020031)
				.HasColumnName("PCO0020031")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020031")
				.IsOptional();

			Property(p => p.PCO0020032)
				.HasColumnName("PCO0020032")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020032")
				.IsOptional();

			Property(p => p.PCO0020033)
				.HasColumnName("PCO0020033")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020033")
				.IsOptional();

			Property(p => p.PCO0020034)
				.HasColumnName("PCO0020034")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020034")
				.IsOptional();

			Property(p => p.PCO0020035)
				.HasColumnName("PCO0020035")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020035")
				.IsOptional();

			Property(p => p.PCO0020036)
				.HasColumnName("PCO0020036")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020036")
				.IsOptional();

			Property(p => p.PCO0020037)
				.HasColumnName("PCO0020037")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020037")
				.IsOptional();

			Property(p => p.PCO0020038)
				.HasColumnName("PCO0020038")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020038")
				.IsOptional();

			Property(p => p.PCO0020039)
				.HasColumnName("PCO0020039")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0020039")
				.IsOptional();

			Property(p => p.PCO0030001)
				.HasColumnName("PCO0030001")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030001")
				.IsOptional();

			Property(p => p.PCO0030002)
				.HasColumnName("PCO0030002")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030002")
				.IsOptional();

			Property(p => p.PCO0030003)
				.HasColumnName("PCO0030003")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030003")
				.IsOptional();

			Property(p => p.PCO0030004)
				.HasColumnName("PCO0030004")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030004")
				.IsOptional();

			Property(p => p.PCO0030005)
				.HasColumnName("PCO0030005")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030005")
				.IsOptional();

			Property(p => p.PCO0030006)
				.HasColumnName("PCO0030006")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030006")
				.IsOptional();

			Property(p => p.PCO0030007)
				.HasColumnName("PCO0030007")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030007")
				.IsOptional();

			Property(p => p.PCO0030008)
				.HasColumnName("PCO0030008")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030008")
				.IsOptional();

			Property(p => p.PCO0030009)
				.HasColumnName("PCO0030009")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030009")
				.IsOptional();

			Property(p => p.PCO0030010)
				.HasColumnName("PCO0030010")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030010")
				.IsOptional();

			Property(p => p.PCO0030011)
				.HasColumnName("PCO0030011")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030011")
				.IsOptional();

			Property(p => p.PCO0030012)
				.HasColumnName("PCO0030012")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030012")
				.IsOptional();

			Property(p => p.PCO0030013)
				.HasColumnName("PCO0030013")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030013")
				.IsOptional();

			Property(p => p.PCO0030014)
				.HasColumnName("PCO0030014")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030014")
				.IsOptional();

			Property(p => p.PCO0030015)
				.HasColumnName("PCO0030015")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030015")
				.IsOptional();

			Property(p => p.PCO0030016)
				.HasColumnName("PCO0030016")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030016")
				.IsOptional();

			Property(p => p.PCO0030017)
				.HasColumnName("PCO0030017")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030017")
				.IsOptional();

			Property(p => p.PCO0030018)
				.HasColumnName("PCO0030018")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030018")
				.IsOptional();

			Property(p => p.PCO0030019)
				.HasColumnName("PCO0030019")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030019")
				.IsOptional();

			Property(p => p.PCO0030020)
				.HasColumnName("PCO0030020")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030020")
				.IsOptional();

			Property(p => p.PCO0030021)
				.HasColumnName("PCO0030021")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030021")
				.IsOptional();

			Property(p => p.PCO0030022)
				.HasColumnName("PCO0030022")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030022")
				.IsOptional();

			Property(p => p.PCO0030023)
				.HasColumnName("PCO0030023")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030023")
				.IsOptional();

			Property(p => p.PCO0030024)
				.HasColumnName("PCO0030024")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030024")
				.IsOptional();

			Property(p => p.PCO0030025)
				.HasColumnName("PCO0030025")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030025")
				.IsOptional();

			Property(p => p.PCO0030026)
				.HasColumnName("PCO0030026")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030026")
				.IsOptional();

			Property(p => p.PCO0030027)
				.HasColumnName("PCO0030027")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030027")
				.IsOptional();

			Property(p => p.PCO0030028)
				.HasColumnName("PCO0030028")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030028")
				.IsOptional();

			Property(p => p.PCO0030029)
				.HasColumnName("PCO0030029")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030029")
				.IsOptional();

			Property(p => p.PCO0030030)
				.HasColumnName("PCO0030030")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030030")
				.IsOptional();

			Property(p => p.PCO0030031)
				.HasColumnName("PCO0030031")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030031")
				.IsOptional();

			Property(p => p.PCO0030032)
				.HasColumnName("PCO0030032")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030032")
				.IsOptional();

			Property(p => p.PCO0030033)
				.HasColumnName("PCO0030033")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030033")
				.IsOptional();

			Property(p => p.PCO0030034)
				.HasColumnName("PCO0030034")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030034")
				.IsOptional();

			Property(p => p.PCO0030035)
				.HasColumnName("PCO0030035")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030035")
				.IsOptional();

			Property(p => p.PCO0030036)
				.HasColumnName("PCO0030036")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030036")
				.IsOptional();

			Property(p => p.PCO0030037)
				.HasColumnName("PCO0030037")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030037")
				.IsOptional();

			Property(p => p.PCO0030038)
				.HasColumnName("PCO0030038")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030038")
				.IsOptional();

			Property(p => p.PCO0030039)
				.HasColumnName("PCO0030039")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0030039")
				.IsOptional();

			Property(p => p.PCO0040001)
				.HasColumnName("PCO0040001")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040001")
				.IsOptional();

			Property(p => p.PCO0040002)
				.HasColumnName("PCO0040002")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040002")
				.IsOptional();

			Property(p => p.PCO0040003)
				.HasColumnName("PCO0040003")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040003")
				.IsOptional();

			Property(p => p.PCO0040004)
				.HasColumnName("PCO0040004")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040004")
				.IsOptional();

			Property(p => p.PCO0040005)
				.HasColumnName("PCO0040005")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040005")
				.IsOptional();

			Property(p => p.PCO0040006)
				.HasColumnName("PCO0040006")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040006")
				.IsOptional();

			Property(p => p.PCO0040007)
				.HasColumnName("PCO0040007")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040007")
				.IsOptional();

			Property(p => p.PCO0040008)
				.HasColumnName("PCO0040008")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040008")
				.IsOptional();

			Property(p => p.PCO0040009)
				.HasColumnName("PCO0040009")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040009")
				.IsOptional();

			Property(p => p.PCO0040010)
				.HasColumnName("PCO0040010")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040010")
				.IsOptional();

			Property(p => p.PCO0040011)
				.HasColumnName("PCO0040011")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040011")
				.IsOptional();

			Property(p => p.PCO0040012)
				.HasColumnName("PCO0040012")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040012")
				.IsOptional();

			Property(p => p.PCO0040013)
				.HasColumnName("PCO0040013")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040013")
				.IsOptional();

			Property(p => p.PCO0040014)
				.HasColumnName("PCO0040014")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040014")
				.IsOptional();

			Property(p => p.PCO0040015)
				.HasColumnName("PCO0040015")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040015")
				.IsOptional();

			Property(p => p.PCO0040016)
				.HasColumnName("PCO0040016")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040016")
				.IsOptional();

			Property(p => p.PCO0040017)
				.HasColumnName("PCO0040017")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040017")
				.IsOptional();

			Property(p => p.PCO0040018)
				.HasColumnName("PCO0040018")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040018")
				.IsOptional();

			Property(p => p.PCO0040019)
				.HasColumnName("PCO0040019")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040019")
				.IsOptional();

			Property(p => p.PCO0040020)
				.HasColumnName("PCO0040020")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040020")
				.IsOptional();

			Property(p => p.PCO0040021)
				.HasColumnName("PCO0040021")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040021")
				.IsOptional();

			Property(p => p.PCO0040022)
				.HasColumnName("PCO0040022")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040022")
				.IsOptional();

			Property(p => p.PCO0040023)
				.HasColumnName("PCO0040023")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040023")
				.IsOptional();

			Property(p => p.PCO0040024)
				.HasColumnName("PCO0040024")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040024")
				.IsOptional();

			Property(p => p.PCO0040025)
				.HasColumnName("PCO0040025")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040025")
				.IsOptional();

			Property(p => p.PCO0040026)
				.HasColumnName("PCO0040026")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040026")
				.IsOptional();

			Property(p => p.PCO0040027)
				.HasColumnName("PCO0040027")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040027")
				.IsOptional();

			Property(p => p.PCO0040028)
				.HasColumnName("PCO0040028")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040028")
				.IsOptional();

			Property(p => p.PCO0040029)
				.HasColumnName("PCO0040029")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040029")
				.IsOptional();

			Property(p => p.PCO0040030)
				.HasColumnName("PCO0040030")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040030")
				.IsOptional();

			Property(p => p.PCO0040031)
				.HasColumnName("PCO0040031")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040031")
				.IsOptional();

			Property(p => p.PCO0040032)
				.HasColumnName("PCO0040032")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040032")
				.IsOptional();

			Property(p => p.PCO0040033)
				.HasColumnName("PCO0040033")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040033")
				.IsOptional();

			Property(p => p.PCO0040034)
				.HasColumnName("PCO0040034")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040034")
				.IsOptional();

			Property(p => p.PCO0040035)
				.HasColumnName("PCO0040035")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040035")
				.IsOptional();

			Property(p => p.PCO0040036)
				.HasColumnName("PCO0040036")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040036")
				.IsOptional();

			Property(p => p.PCO0040037)
				.HasColumnName("PCO0040037")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040037")
				.IsOptional();

			Property(p => p.PCO0040038)
				.HasColumnName("PCO0040038")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040038")
				.IsOptional();

			Property(p => p.PCO0040039)
				.HasColumnName("PCO0040039")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0040039")
				.IsOptional();

			Property(p => p.PCO0050001)
				.HasColumnName("PCO0050001")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050001")
				.IsOptional();

			Property(p => p.PCO0050002)
				.HasColumnName("PCO0050002")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050002")
				.IsOptional();

			Property(p => p.PCO0050003)
				.HasColumnName("PCO0050003")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050003")
				.IsOptional();

			Property(p => p.PCO0050004)
				.HasColumnName("PCO0050004")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050004")
				.IsOptional();

			Property(p => p.PCO0050005)
				.HasColumnName("PCO0050005")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050005")
				.IsOptional();

			Property(p => p.PCO0050006)
				.HasColumnName("PCO0050006")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050006")
				.IsOptional();

			Property(p => p.PCO0050007)
				.HasColumnName("PCO0050007")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050007")
				.IsOptional();

			Property(p => p.PCO0050008)
				.HasColumnName("PCO0050008")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050008")
				.IsOptional();

			Property(p => p.PCO0050009)
				.HasColumnName("PCO0050009")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050009")
				.IsOptional();

			Property(p => p.PCO0050010)
				.HasColumnName("PCO0050010")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050010")
				.IsOptional();

			Property(p => p.PCO0050011)
				.HasColumnName("PCO0050011")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050011")
				.IsOptional();

			Property(p => p.PCO0050012)
				.HasColumnName("PCO0050012")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050012")
				.IsOptional();

			Property(p => p.PCO0050013)
				.HasColumnName("PCO0050013")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050013")
				.IsOptional();

			Property(p => p.PCO0050014)
				.HasColumnName("PCO0050014")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050014")
				.IsOptional();

			Property(p => p.PCO0050015)
				.HasColumnName("PCO0050015")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050015")
				.IsOptional();

			Property(p => p.PCO0050016)
				.HasColumnName("PCO0050016")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050016")
				.IsOptional();

			Property(p => p.PCO0050017)
				.HasColumnName("PCO0050017")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050017")
				.IsOptional();

			Property(p => p.PCO0050018)
				.HasColumnName("PCO0050018")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050018")
				.IsOptional();

			Property(p => p.PCO0050019)
				.HasColumnName("PCO0050019")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050019")
				.IsOptional();

			Property(p => p.PCO0050020)
				.HasColumnName("PCO0050020")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050020")
				.IsOptional();

			Property(p => p.PCO0050021)
				.HasColumnName("PCO0050021")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050021")
				.IsOptional();

			Property(p => p.PCO0050022)
				.HasColumnName("PCO0050022")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050022")
				.IsOptional();

			Property(p => p.PCO0050023)
				.HasColumnName("PCO0050023")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050023")
				.IsOptional();

			Property(p => p.PCO0050024)
				.HasColumnName("PCO0050024")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050024")
				.IsOptional();

			Property(p => p.PCO0050025)
				.HasColumnName("PCO0050025")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050025")
				.IsOptional();

			Property(p => p.PCO0050026)
				.HasColumnName("PCO0050026")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050026")
				.IsOptional();

			Property(p => p.PCO0050027)
				.HasColumnName("PCO0050027")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050027")
				.IsOptional();

			Property(p => p.PCO0050028)
				.HasColumnName("PCO0050028")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050028")
				.IsOptional();

			Property(p => p.PCO0050029)
				.HasColumnName("PCO0050029")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050029")
				.IsOptional();

			Property(p => p.PCO0050030)
				.HasColumnName("PCO0050030")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050030")
				.IsOptional();

			Property(p => p.PCO0050031)
				.HasColumnName("PCO0050031")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050031")
				.IsOptional();

			Property(p => p.PCO0050032)
				.HasColumnName("PCO0050032")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050032")
				.IsOptional();

			Property(p => p.PCO0050033)
				.HasColumnName("PCO0050033")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050033")
				.IsOptional();

			Property(p => p.PCO0050034)
				.HasColumnName("PCO0050034")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050034")
				.IsOptional();

			Property(p => p.PCO0050035)
				.HasColumnName("PCO0050035")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050035")
				.IsOptional();

			Property(p => p.PCO0050036)
				.HasColumnName("PCO0050036")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050036")
				.IsOptional();

			Property(p => p.PCO0050037)
				.HasColumnName("PCO0050037")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050037")
				.IsOptional();

			Property(p => p.PCO0050038)
				.HasColumnName("PCO0050038")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050038")
				.IsOptional();

			Property(p => p.PCO0050039)
				.HasColumnName("PCO0050039")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0050039")
				.IsOptional();

			Property(p => p.PCO0060001)
				.HasColumnName("PCO0060001")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060001")
				.IsOptional();

			Property(p => p.PCO0060002)
				.HasColumnName("PCO0060002")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060002")
				.IsOptional();

			Property(p => p.PCO0060003)
				.HasColumnName("PCO0060003")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060003")
				.IsOptional();

			Property(p => p.PCO0060004)
				.HasColumnName("PCO0060004")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060004")
				.IsOptional();

			Property(p => p.PCO0060005)
				.HasColumnName("PCO0060005")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060005")
				.IsOptional();

			Property(p => p.PCO0060006)
				.HasColumnName("PCO0060006")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060006")
				.IsOptional();

			Property(p => p.PCO0060007)
				.HasColumnName("PCO0060007")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060007")
				.IsOptional();

			Property(p => p.PCO0060008)
				.HasColumnName("PCO0060008")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060008")
				.IsOptional();

			Property(p => p.PCO0060009)
				.HasColumnName("PCO0060009")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060009")
				.IsOptional();

			Property(p => p.PCO0060010)
				.HasColumnName("PCO0060010")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060010")
				.IsOptional();

			Property(p => p.PCO0060011)
				.HasColumnName("PCO0060011")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060011")
				.IsOptional();

			Property(p => p.PCO0060012)
				.HasColumnName("PCO0060012")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060012")
				.IsOptional();

			Property(p => p.PCO0060013)
				.HasColumnName("PCO0060013")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060013")
				.IsOptional();

			Property(p => p.PCO0060014)
				.HasColumnName("PCO0060014")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060014")
				.IsOptional();

			Property(p => p.PCO0060015)
				.HasColumnName("PCO0060015")
				.HasColumnOrder(214)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060015")
				.IsOptional();

			Property(p => p.PCO0060016)
				.HasColumnName("PCO0060016")
				.HasColumnOrder(215)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060016")
				.IsOptional();

			Property(p => p.PCO0060017)
				.HasColumnName("PCO0060017")
				.HasColumnOrder(216)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060017")
				.IsOptional();

			Property(p => p.PCO0060018)
				.HasColumnName("PCO0060018")
				.HasColumnOrder(217)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060018")
				.IsOptional();

			Property(p => p.PCO0060019)
				.HasColumnName("PCO0060019")
				.HasColumnOrder(218)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060019")
				.IsOptional();

			Property(p => p.PCO0060020)
				.HasColumnName("PCO0060020")
				.HasColumnOrder(219)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060020")
				.IsOptional();

			Property(p => p.PCO0060021)
				.HasColumnName("PCO0060021")
				.HasColumnOrder(220)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060021")
				.IsOptional();

			Property(p => p.PCO0060022)
				.HasColumnName("PCO0060022")
				.HasColumnOrder(221)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060022")
				.IsOptional();

			Property(p => p.PCO0060023)
				.HasColumnName("PCO0060023")
				.HasColumnOrder(222)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060023")
				.IsOptional();

			Property(p => p.PCO0060024)
				.HasColumnName("PCO0060024")
				.HasColumnOrder(223)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060024")
				.IsOptional();

			Property(p => p.PCO0060025)
				.HasColumnName("PCO0060025")
				.HasColumnOrder(224)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060025")
				.IsOptional();

			Property(p => p.PCO0060026)
				.HasColumnName("PCO0060026")
				.HasColumnOrder(225)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060026")
				.IsOptional();

			Property(p => p.PCO0060027)
				.HasColumnName("PCO0060027")
				.HasColumnOrder(226)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060027")
				.IsOptional();

			Property(p => p.PCO0060028)
				.HasColumnName("PCO0060028")
				.HasColumnOrder(227)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060028")
				.IsOptional();

			Property(p => p.PCO0060029)
				.HasColumnName("PCO0060029")
				.HasColumnOrder(228)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060029")
				.IsOptional();

			Property(p => p.PCO0060030)
				.HasColumnName("PCO0060030")
				.HasColumnOrder(229)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060030")
				.IsOptional();

			Property(p => p.PCO0060031)
				.HasColumnName("PCO0060031")
				.HasColumnOrder(230)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060031")
				.IsOptional();

			Property(p => p.PCO0060032)
				.HasColumnName("PCO0060032")
				.HasColumnOrder(231)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060032")
				.IsOptional();

			Property(p => p.PCO0060033)
				.HasColumnName("PCO0060033")
				.HasColumnOrder(232)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060033")
				.IsOptional();

			Property(p => p.PCO0060034)
				.HasColumnName("PCO0060034")
				.HasColumnOrder(233)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060034")
				.IsOptional();

			Property(p => p.PCO0060035)
				.HasColumnName("PCO0060035")
				.HasColumnOrder(234)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060035")
				.IsOptional();

			Property(p => p.PCO0060036)
				.HasColumnName("PCO0060036")
				.HasColumnOrder(235)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060036")
				.IsOptional();

			Property(p => p.PCO0060037)
				.HasColumnName("PCO0060037")
				.HasColumnOrder(236)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060037")
				.IsOptional();

			Property(p => p.PCO0060038)
				.HasColumnName("PCO0060038")
				.HasColumnOrder(237)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060038")
				.IsOptional();

			Property(p => p.PCO0060039)
				.HasColumnName("PCO0060039")
				.HasColumnOrder(238)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0060039")
				.IsOptional();
		}
	}
}
