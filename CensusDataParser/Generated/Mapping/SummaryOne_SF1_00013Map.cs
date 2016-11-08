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

	public class SummaryOne_SF1_00013Map : EntityTypeConfiguration<SummaryOne_SF1_00013>
	{
		public SummaryOne_SF1_00013Map()
		{
			ToTable("SF1_00013", "SummaryOne");

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

			Property(p => p.P038F001)
				.HasColumnName("P038F001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038F001")
				.IsOptional();

			Property(p => p.P038F002)
				.HasColumnName("P038F002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038F002")
				.IsOptional();

			Property(p => p.P038F003)
				.HasColumnName("P038F003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038F003")
				.IsOptional();

			Property(p => p.P038F004)
				.HasColumnName("P038F004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038F004")
				.IsOptional();

			Property(p => p.P038F005)
				.HasColumnName("P038F005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038F005")
				.IsOptional();

			Property(p => p.P038F006)
				.HasColumnName("P038F006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038F006")
				.IsOptional();

			Property(p => p.P038F007)
				.HasColumnName("P038F007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038F007")
				.IsOptional();

			Property(p => p.P038F008)
				.HasColumnName("P038F008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038F008")
				.IsOptional();

			Property(p => p.P038F009)
				.HasColumnName("P038F009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038F009")
				.IsOptional();

			Property(p => p.P038F010)
				.HasColumnName("P038F010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038F010")
				.IsOptional();

			Property(p => p.P038F011)
				.HasColumnName("P038F011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038F011")
				.IsOptional();

			Property(p => p.P038F012)
				.HasColumnName("P038F012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038F012")
				.IsOptional();

			Property(p => p.P038F013)
				.HasColumnName("P038F013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038F013")
				.IsOptional();

			Property(p => p.P038F014)
				.HasColumnName("P038F014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038F014")
				.IsOptional();

			Property(p => p.P038F015)
				.HasColumnName("P038F015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038F015")
				.IsOptional();

			Property(p => p.P038F016)
				.HasColumnName("P038F016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038F016")
				.IsOptional();

			Property(p => p.P038F017)
				.HasColumnName("P038F017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038F017")
				.IsOptional();

			Property(p => p.P038F018)
				.HasColumnName("P038F018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038F018")
				.IsOptional();

			Property(p => p.P038F019)
				.HasColumnName("P038F019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038F019")
				.IsOptional();

			Property(p => p.P038F020)
				.HasColumnName("P038F020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038F020")
				.IsOptional();

			Property(p => p.P038G001)
				.HasColumnName("P038G001")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038G001")
				.IsOptional();

			Property(p => p.P038G002)
				.HasColumnName("P038G002")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038G002")
				.IsOptional();

			Property(p => p.P038G003)
				.HasColumnName("P038G003")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038G003")
				.IsOptional();

			Property(p => p.P038G004)
				.HasColumnName("P038G004")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038G004")
				.IsOptional();

			Property(p => p.P038G005)
				.HasColumnName("P038G005")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038G005")
				.IsOptional();

			Property(p => p.P038G006)
				.HasColumnName("P038G006")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038G006")
				.IsOptional();

			Property(p => p.P038G007)
				.HasColumnName("P038G007")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038G007")
				.IsOptional();

			Property(p => p.P038G008)
				.HasColumnName("P038G008")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038G008")
				.IsOptional();

			Property(p => p.P038G009)
				.HasColumnName("P038G009")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038G009")
				.IsOptional();

			Property(p => p.P038G010)
				.HasColumnName("P038G010")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038G010")
				.IsOptional();

			Property(p => p.P038G011)
				.HasColumnName("P038G011")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038G011")
				.IsOptional();

			Property(p => p.P038G012)
				.HasColumnName("P038G012")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038G012")
				.IsOptional();

			Property(p => p.P038G013)
				.HasColumnName("P038G013")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038G013")
				.IsOptional();

			Property(p => p.P038G014)
				.HasColumnName("P038G014")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038G014")
				.IsOptional();

			Property(p => p.P038G015)
				.HasColumnName("P038G015")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038G015")
				.IsOptional();

			Property(p => p.P038G016)
				.HasColumnName("P038G016")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038G016")
				.IsOptional();

			Property(p => p.P038G017)
				.HasColumnName("P038G017")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038G017")
				.IsOptional();

			Property(p => p.P038G018)
				.HasColumnName("P038G018")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038G018")
				.IsOptional();

			Property(p => p.P038G019)
				.HasColumnName("P038G019")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038G019")
				.IsOptional();

			Property(p => p.P038G020)
				.HasColumnName("P038G020")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038G020")
				.IsOptional();

			Property(p => p.P038H001)
				.HasColumnName("P038H001")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038H001")
				.IsOptional();

			Property(p => p.P038H002)
				.HasColumnName("P038H002")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038H002")
				.IsOptional();

			Property(p => p.P038H003)
				.HasColumnName("P038H003")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038H003")
				.IsOptional();

			Property(p => p.P038H004)
				.HasColumnName("P038H004")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038H004")
				.IsOptional();

			Property(p => p.P038H005)
				.HasColumnName("P038H005")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038H005")
				.IsOptional();

			Property(p => p.P038H006)
				.HasColumnName("P038H006")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038H006")
				.IsOptional();

			Property(p => p.P038H007)
				.HasColumnName("P038H007")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038H007")
				.IsOptional();

			Property(p => p.P038H008)
				.HasColumnName("P038H008")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038H008")
				.IsOptional();

			Property(p => p.P038H009)
				.HasColumnName("P038H009")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038H009")
				.IsOptional();

			Property(p => p.P038H010)
				.HasColumnName("P038H010")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038H010")
				.IsOptional();

			Property(p => p.P038H011)
				.HasColumnName("P038H011")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038H011")
				.IsOptional();

			Property(p => p.P038H012)
				.HasColumnName("P038H012")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038H012")
				.IsOptional();

			Property(p => p.P038H013)
				.HasColumnName("P038H013")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038H013")
				.IsOptional();

			Property(p => p.P038H014)
				.HasColumnName("P038H014")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038H014")
				.IsOptional();

			Property(p => p.P038H015)
				.HasColumnName("P038H015")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038H015")
				.IsOptional();

			Property(p => p.P038H016)
				.HasColumnName("P038H016")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038H016")
				.IsOptional();

			Property(p => p.P038H017)
				.HasColumnName("P038H017")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038H017")
				.IsOptional();

			Property(p => p.P038H018)
				.HasColumnName("P038H018")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038H018")
				.IsOptional();

			Property(p => p.P038H019)
				.HasColumnName("P038H019")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038H019")
				.IsOptional();

			Property(p => p.P038H020)
				.HasColumnName("P038H020")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038H020")
				.IsOptional();

			Property(p => p.P038I001)
				.HasColumnName("P038I001")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038I001")
				.IsOptional();

			Property(p => p.P038I002)
				.HasColumnName("P038I002")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038I002")
				.IsOptional();

			Property(p => p.P038I003)
				.HasColumnName("P038I003")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038I003")
				.IsOptional();

			Property(p => p.P038I004)
				.HasColumnName("P038I004")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038I004")
				.IsOptional();

			Property(p => p.P038I005)
				.HasColumnName("P038I005")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038I005")
				.IsOptional();

			Property(p => p.P038I006)
				.HasColumnName("P038I006")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038I006")
				.IsOptional();

			Property(p => p.P038I007)
				.HasColumnName("P038I007")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038I007")
				.IsOptional();

			Property(p => p.P038I008)
				.HasColumnName("P038I008")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038I008")
				.IsOptional();

			Property(p => p.P038I009)
				.HasColumnName("P038I009")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038I009")
				.IsOptional();

			Property(p => p.P038I010)
				.HasColumnName("P038I010")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038I010")
				.IsOptional();

			Property(p => p.P038I011)
				.HasColumnName("P038I011")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038I011")
				.IsOptional();

			Property(p => p.P038I012)
				.HasColumnName("P038I012")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038I012")
				.IsOptional();

			Property(p => p.P038I013)
				.HasColumnName("P038I013")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038I013")
				.IsOptional();

			Property(p => p.P038I014)
				.HasColumnName("P038I014")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038I014")
				.IsOptional();

			Property(p => p.P038I015)
				.HasColumnName("P038I015")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038I015")
				.IsOptional();

			Property(p => p.P038I016)
				.HasColumnName("P038I016")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038I016")
				.IsOptional();

			Property(p => p.P038I017)
				.HasColumnName("P038I017")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038I017")
				.IsOptional();

			Property(p => p.P038I018)
				.HasColumnName("P038I018")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038I018")
				.IsOptional();

			Property(p => p.P038I019)
				.HasColumnName("P038I019")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038I019")
				.IsOptional();

			Property(p => p.P038I020)
				.HasColumnName("P038I020")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038I020")
				.IsOptional();

			Property(p => p.P039A001)
				.HasColumnName("P039A001")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039A001")
				.IsOptional();

			Property(p => p.P039A002)
				.HasColumnName("P039A002")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039A002")
				.IsOptional();

			Property(p => p.P039A003)
				.HasColumnName("P039A003")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039A003")
				.IsOptional();

			Property(p => p.P039A004)
				.HasColumnName("P039A004")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039A004")
				.IsOptional();

			Property(p => p.P039A005)
				.HasColumnName("P039A005")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039A005")
				.IsOptional();

			Property(p => p.P039A006)
				.HasColumnName("P039A006")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039A006")
				.IsOptional();

			Property(p => p.P039A007)
				.HasColumnName("P039A007")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039A007")
				.IsOptional();

			Property(p => p.P039A008)
				.HasColumnName("P039A008")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039A008")
				.IsOptional();

			Property(p => p.P039A009)
				.HasColumnName("P039A009")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039A009")
				.IsOptional();

			Property(p => p.P039A010)
				.HasColumnName("P039A010")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039A010")
				.IsOptional();

			Property(p => p.P039A011)
				.HasColumnName("P039A011")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039A011")
				.IsOptional();

			Property(p => p.P039A012)
				.HasColumnName("P039A012")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039A012")
				.IsOptional();

			Property(p => p.P039A013)
				.HasColumnName("P039A013")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039A013")
				.IsOptional();

			Property(p => p.P039A014)
				.HasColumnName("P039A014")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039A014")
				.IsOptional();

			Property(p => p.P039A015)
				.HasColumnName("P039A015")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039A015")
				.IsOptional();

			Property(p => p.P039A016)
				.HasColumnName("P039A016")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039A016")
				.IsOptional();

			Property(p => p.P039A017)
				.HasColumnName("P039A017")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039A017")
				.IsOptional();

			Property(p => p.P039A018)
				.HasColumnName("P039A018")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039A018")
				.IsOptional();

			Property(p => p.P039A019)
				.HasColumnName("P039A019")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039A019")
				.IsOptional();

			Property(p => p.P039A020)
				.HasColumnName("P039A020")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039A020")
				.IsOptional();

			Property(p => p.P039B001)
				.HasColumnName("P039B001")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039B001")
				.IsOptional();

			Property(p => p.P039B002)
				.HasColumnName("P039B002")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039B002")
				.IsOptional();

			Property(p => p.P039B003)
				.HasColumnName("P039B003")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039B003")
				.IsOptional();

			Property(p => p.P039B004)
				.HasColumnName("P039B004")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039B004")
				.IsOptional();

			Property(p => p.P039B005)
				.HasColumnName("P039B005")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039B005")
				.IsOptional();

			Property(p => p.P039B006)
				.HasColumnName("P039B006")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039B006")
				.IsOptional();

			Property(p => p.P039B007)
				.HasColumnName("P039B007")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039B007")
				.IsOptional();

			Property(p => p.P039B008)
				.HasColumnName("P039B008")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039B008")
				.IsOptional();

			Property(p => p.P039B009)
				.HasColumnName("P039B009")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039B009")
				.IsOptional();

			Property(p => p.P039B010)
				.HasColumnName("P039B010")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039B010")
				.IsOptional();

			Property(p => p.P039B011)
				.HasColumnName("P039B011")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039B011")
				.IsOptional();

			Property(p => p.P039B012)
				.HasColumnName("P039B012")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039B012")
				.IsOptional();

			Property(p => p.P039B013)
				.HasColumnName("P039B013")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039B013")
				.IsOptional();

			Property(p => p.P039B014)
				.HasColumnName("P039B014")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039B014")
				.IsOptional();

			Property(p => p.P039B015)
				.HasColumnName("P039B015")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039B015")
				.IsOptional();

			Property(p => p.P039B016)
				.HasColumnName("P039B016")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039B016")
				.IsOptional();

			Property(p => p.P039B017)
				.HasColumnName("P039B017")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039B017")
				.IsOptional();

			Property(p => p.P039B018)
				.HasColumnName("P039B018")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039B018")
				.IsOptional();

			Property(p => p.P039B019)
				.HasColumnName("P039B019")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039B019")
				.IsOptional();

			Property(p => p.P039B020)
				.HasColumnName("P039B020")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039B020")
				.IsOptional();

			Property(p => p.P039C001)
				.HasColumnName("P039C001")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039C001")
				.IsOptional();

			Property(p => p.P039C002)
				.HasColumnName("P039C002")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039C002")
				.IsOptional();

			Property(p => p.P039C003)
				.HasColumnName("P039C003")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039C003")
				.IsOptional();

			Property(p => p.P039C004)
				.HasColumnName("P039C004")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039C004")
				.IsOptional();

			Property(p => p.P039C005)
				.HasColumnName("P039C005")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039C005")
				.IsOptional();

			Property(p => p.P039C006)
				.HasColumnName("P039C006")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039C006")
				.IsOptional();

			Property(p => p.P039C007)
				.HasColumnName("P039C007")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039C007")
				.IsOptional();

			Property(p => p.P039C008)
				.HasColumnName("P039C008")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039C008")
				.IsOptional();

			Property(p => p.P039C009)
				.HasColumnName("P039C009")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039C009")
				.IsOptional();

			Property(p => p.P039C010)
				.HasColumnName("P039C010")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039C010")
				.IsOptional();

			Property(p => p.P039C011)
				.HasColumnName("P039C011")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039C011")
				.IsOptional();

			Property(p => p.P039C012)
				.HasColumnName("P039C012")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039C012")
				.IsOptional();

			Property(p => p.P039C013)
				.HasColumnName("P039C013")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039C013")
				.IsOptional();

			Property(p => p.P039C014)
				.HasColumnName("P039C014")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039C014")
				.IsOptional();

			Property(p => p.P039C015)
				.HasColumnName("P039C015")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039C015")
				.IsOptional();

			Property(p => p.P039C016)
				.HasColumnName("P039C016")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039C016")
				.IsOptional();

			Property(p => p.P039C017)
				.HasColumnName("P039C017")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039C017")
				.IsOptional();

			Property(p => p.P039C018)
				.HasColumnName("P039C018")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039C018")
				.IsOptional();

			Property(p => p.P039C019)
				.HasColumnName("P039C019")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039C019")
				.IsOptional();

			Property(p => p.P039C020)
				.HasColumnName("P039C020")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039C020")
				.IsOptional();

			Property(p => p.P039D001)
				.HasColumnName("P039D001")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039D001")
				.IsOptional();

			Property(p => p.P039D002)
				.HasColumnName("P039D002")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039D002")
				.IsOptional();

			Property(p => p.P039D003)
				.HasColumnName("P039D003")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039D003")
				.IsOptional();

			Property(p => p.P039D004)
				.HasColumnName("P039D004")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039D004")
				.IsOptional();

			Property(p => p.P039D005)
				.HasColumnName("P039D005")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039D005")
				.IsOptional();

			Property(p => p.P039D006)
				.HasColumnName("P039D006")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039D006")
				.IsOptional();

			Property(p => p.P039D007)
				.HasColumnName("P039D007")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039D007")
				.IsOptional();

			Property(p => p.P039D008)
				.HasColumnName("P039D008")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039D008")
				.IsOptional();

			Property(p => p.P039D009)
				.HasColumnName("P039D009")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039D009")
				.IsOptional();

			Property(p => p.P039D010)
				.HasColumnName("P039D010")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039D010")
				.IsOptional();

			Property(p => p.P039D011)
				.HasColumnName("P039D011")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039D011")
				.IsOptional();

			Property(p => p.P039D012)
				.HasColumnName("P039D012")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039D012")
				.IsOptional();

			Property(p => p.P039D013)
				.HasColumnName("P039D013")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039D013")
				.IsOptional();

			Property(p => p.P039D014)
				.HasColumnName("P039D014")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039D014")
				.IsOptional();

			Property(p => p.P039D015)
				.HasColumnName("P039D015")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039D015")
				.IsOptional();

			Property(p => p.P039D016)
				.HasColumnName("P039D016")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039D016")
				.IsOptional();

			Property(p => p.P039D017)
				.HasColumnName("P039D017")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039D017")
				.IsOptional();

			Property(p => p.P039D018)
				.HasColumnName("P039D018")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039D018")
				.IsOptional();

			Property(p => p.P039D019)
				.HasColumnName("P039D019")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039D019")
				.IsOptional();

			Property(p => p.P039D020)
				.HasColumnName("P039D020")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039D020")
				.IsOptional();

			Property(p => p.P039E001)
				.HasColumnName("P039E001")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039E001")
				.IsOptional();

			Property(p => p.P039E002)
				.HasColumnName("P039E002")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039E002")
				.IsOptional();

			Property(p => p.P039E003)
				.HasColumnName("P039E003")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039E003")
				.IsOptional();

			Property(p => p.P039E004)
				.HasColumnName("P039E004")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039E004")
				.IsOptional();

			Property(p => p.P039E005)
				.HasColumnName("P039E005")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039E005")
				.IsOptional();

			Property(p => p.P039E006)
				.HasColumnName("P039E006")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039E006")
				.IsOptional();

			Property(p => p.P039E007)
				.HasColumnName("P039E007")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039E007")
				.IsOptional();

			Property(p => p.P039E008)
				.HasColumnName("P039E008")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039E008")
				.IsOptional();

			Property(p => p.P039E009)
				.HasColumnName("P039E009")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039E009")
				.IsOptional();

			Property(p => p.P039E010)
				.HasColumnName("P039E010")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039E010")
				.IsOptional();

			Property(p => p.P039E011)
				.HasColumnName("P039E011")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039E011")
				.IsOptional();

			Property(p => p.P039E012)
				.HasColumnName("P039E012")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039E012")
				.IsOptional();

			Property(p => p.P039E013)
				.HasColumnName("P039E013")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039E013")
				.IsOptional();

			Property(p => p.P039E014)
				.HasColumnName("P039E014")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039E014")
				.IsOptional();

			Property(p => p.P039E015)
				.HasColumnName("P039E015")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039E015")
				.IsOptional();

			Property(p => p.P039E016)
				.HasColumnName("P039E016")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039E016")
				.IsOptional();

			Property(p => p.P039E017)
				.HasColumnName("P039E017")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039E017")
				.IsOptional();

			Property(p => p.P039E018)
				.HasColumnName("P039E018")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039E018")
				.IsOptional();

			Property(p => p.P039E019)
				.HasColumnName("P039E019")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039E019")
				.IsOptional();

			Property(p => p.P039E020)
				.HasColumnName("P039E020")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039E020")
				.IsOptional();

			Property(p => p.P039F001)
				.HasColumnName("P039F001")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039F001")
				.IsOptional();

			Property(p => p.P039F002)
				.HasColumnName("P039F002")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039F002")
				.IsOptional();

			Property(p => p.P039F003)
				.HasColumnName("P039F003")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039F003")
				.IsOptional();

			Property(p => p.P039F004)
				.HasColumnName("P039F004")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039F004")
				.IsOptional();

			Property(p => p.P039F005)
				.HasColumnName("P039F005")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039F005")
				.IsOptional();

			Property(p => p.P039F006)
				.HasColumnName("P039F006")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039F006")
				.IsOptional();

			Property(p => p.P039F007)
				.HasColumnName("P039F007")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039F007")
				.IsOptional();

			Property(p => p.P039F008)
				.HasColumnName("P039F008")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039F008")
				.IsOptional();

			Property(p => p.P039F009)
				.HasColumnName("P039F009")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039F009")
				.IsOptional();

			Property(p => p.P039F010)
				.HasColumnName("P039F010")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039F010")
				.IsOptional();

			Property(p => p.P039F011)
				.HasColumnName("P039F011")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039F011")
				.IsOptional();

			Property(p => p.P039F012)
				.HasColumnName("P039F012")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039F012")
				.IsOptional();

			Property(p => p.P039F013)
				.HasColumnName("P039F013")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039F013")
				.IsOptional();

			Property(p => p.P039F014)
				.HasColumnName("P039F014")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039F014")
				.IsOptional();

			Property(p => p.P039F015)
				.HasColumnName("P039F015")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039F015")
				.IsOptional();

			Property(p => p.P039F016)
				.HasColumnName("P039F016")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039F016")
				.IsOptional();

			Property(p => p.P039F017)
				.HasColumnName("P039F017")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039F017")
				.IsOptional();

			Property(p => p.P039F018)
				.HasColumnName("P039F018")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039F018")
				.IsOptional();

			Property(p => p.P039F019)
				.HasColumnName("P039F019")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039F019")
				.IsOptional();

			Property(p => p.P039F020)
				.HasColumnName("P039F020")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039F020")
				.IsOptional();

			Property(p => p.P039G001)
				.HasColumnName("P039G001")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039G001")
				.IsOptional();

			Property(p => p.P039G002)
				.HasColumnName("P039G002")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039G002")
				.IsOptional();

			Property(p => p.P039G003)
				.HasColumnName("P039G003")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039G003")
				.IsOptional();

			Property(p => p.P039G004)
				.HasColumnName("P039G004")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039G004")
				.IsOptional();

			Property(p => p.P039G005)
				.HasColumnName("P039G005")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039G005")
				.IsOptional();

			Property(p => p.P039G006)
				.HasColumnName("P039G006")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039G006")
				.IsOptional();

			Property(p => p.P039G007)
				.HasColumnName("P039G007")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039G007")
				.IsOptional();

			Property(p => p.P039G008)
				.HasColumnName("P039G008")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039G008")
				.IsOptional();

			Property(p => p.P039G009)
				.HasColumnName("P039G009")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039G009")
				.IsOptional();

			Property(p => p.P039G010)
				.HasColumnName("P039G010")
				.HasColumnOrder(214)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039G010")
				.IsOptional();

			Property(p => p.P039G011)
				.HasColumnName("P039G011")
				.HasColumnOrder(215)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039G011")
				.IsOptional();

			Property(p => p.P039G012)
				.HasColumnName("P039G012")
				.HasColumnOrder(216)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039G012")
				.IsOptional();

			Property(p => p.P039G013)
				.HasColumnName("P039G013")
				.HasColumnOrder(217)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039G013")
				.IsOptional();

			Property(p => p.P039G014)
				.HasColumnName("P039G014")
				.HasColumnOrder(218)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039G014")
				.IsOptional();

			Property(p => p.P039G015)
				.HasColumnName("P039G015")
				.HasColumnOrder(219)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039G015")
				.IsOptional();

			Property(p => p.P039G016)
				.HasColumnName("P039G016")
				.HasColumnOrder(220)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039G016")
				.IsOptional();

			Property(p => p.P039G017)
				.HasColumnName("P039G017")
				.HasColumnOrder(221)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039G017")
				.IsOptional();

			Property(p => p.P039G018)
				.HasColumnName("P039G018")
				.HasColumnOrder(222)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039G018")
				.IsOptional();

			Property(p => p.P039G019)
				.HasColumnName("P039G019")
				.HasColumnOrder(223)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039G019")
				.IsOptional();

			Property(p => p.P039G020)
				.HasColumnName("P039G020")
				.HasColumnOrder(224)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039G020")
				.IsOptional();

			Property(p => p.P039H001)
				.HasColumnName("P039H001")
				.HasColumnOrder(225)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039H001")
				.IsOptional();

			Property(p => p.P039H002)
				.HasColumnName("P039H002")
				.HasColumnOrder(226)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039H002")
				.IsOptional();

			Property(p => p.P039H003)
				.HasColumnName("P039H003")
				.HasColumnOrder(227)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039H003")
				.IsOptional();

			Property(p => p.P039H004)
				.HasColumnName("P039H004")
				.HasColumnOrder(228)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039H004")
				.IsOptional();

			Property(p => p.P039H005)
				.HasColumnName("P039H005")
				.HasColumnOrder(229)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039H005")
				.IsOptional();

			Property(p => p.P039H006)
				.HasColumnName("P039H006")
				.HasColumnOrder(230)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039H006")
				.IsOptional();

			Property(p => p.P039H007)
				.HasColumnName("P039H007")
				.HasColumnOrder(231)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039H007")
				.IsOptional();

			Property(p => p.P039H008)
				.HasColumnName("P039H008")
				.HasColumnOrder(232)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039H008")
				.IsOptional();

			Property(p => p.P039H009)
				.HasColumnName("P039H009")
				.HasColumnOrder(233)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039H009")
				.IsOptional();

			Property(p => p.P039H010)
				.HasColumnName("P039H010")
				.HasColumnOrder(234)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039H010")
				.IsOptional();

			Property(p => p.P039H011)
				.HasColumnName("P039H011")
				.HasColumnOrder(235)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039H011")
				.IsOptional();

			Property(p => p.P039H012)
				.HasColumnName("P039H012")
				.HasColumnOrder(236)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039H012")
				.IsOptional();

			Property(p => p.P039H013)
				.HasColumnName("P039H013")
				.HasColumnOrder(237)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039H013")
				.IsOptional();

			Property(p => p.P039H014)
				.HasColumnName("P039H014")
				.HasColumnOrder(238)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039H014")
				.IsOptional();

			Property(p => p.P039H015)
				.HasColumnName("P039H015")
				.HasColumnOrder(239)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039H015")
				.IsOptional();

			Property(p => p.P039H016)
				.HasColumnName("P039H016")
				.HasColumnOrder(240)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039H016")
				.IsOptional();

			Property(p => p.P039H017)
				.HasColumnName("P039H017")
				.HasColumnOrder(241)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039H017")
				.IsOptional();

			Property(p => p.P039H018)
				.HasColumnName("P039H018")
				.HasColumnOrder(242)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039H018")
				.IsOptional();

			Property(p => p.P039H019)
				.HasColumnName("P039H019")
				.HasColumnOrder(243)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039H019")
				.IsOptional();

			Property(p => p.P039H020)
				.HasColumnName("P039H020")
				.HasColumnOrder(244)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P039H020")
				.IsOptional();
		}
	}
}
