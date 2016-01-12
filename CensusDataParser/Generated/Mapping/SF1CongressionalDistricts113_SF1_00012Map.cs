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

	public class SF1CongressionalDistricts113_SF1_00012Map : EntityTypeConfiguration<SF1CongressionalDistricts113_SF1_00012>
	{
		public SF1CongressionalDistricts113_SF1_00012Map()
		{
			ToTable("SF1_00012", "SF1CongressionalDistricts113");

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

			Property(p => p.P034F001)
				.HasColumnName("P034F001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034F001")
				.IsOptional();

			Property(p => p.P034F002)
				.HasColumnName("P034F002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034F002")
				.IsOptional();

			Property(p => p.P034F003)
				.HasColumnName("P034F003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034F003")
				.IsOptional();

			Property(p => p.P034F004)
				.HasColumnName("P034F004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034F004")
				.IsOptional();

			Property(p => p.P034F005)
				.HasColumnName("P034F005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034F005")
				.IsOptional();

			Property(p => p.P034F006)
				.HasColumnName("P034F006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034F006")
				.IsOptional();

			Property(p => p.P034F007)
				.HasColumnName("P034F007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034F007")
				.IsOptional();

			Property(p => p.P034F008)
				.HasColumnName("P034F008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034F008")
				.IsOptional();

			Property(p => p.P034F009)
				.HasColumnName("P034F009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034F009")
				.IsOptional();

			Property(p => p.P034F010)
				.HasColumnName("P034F010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034F010")
				.IsOptional();

			Property(p => p.P034F011)
				.HasColumnName("P034F011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034F011")
				.IsOptional();

			Property(p => p.P034F012)
				.HasColumnName("P034F012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034F012")
				.IsOptional();

			Property(p => p.P034F013)
				.HasColumnName("P034F013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034F013")
				.IsOptional();

			Property(p => p.P034F014)
				.HasColumnName("P034F014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034F014")
				.IsOptional();

			Property(p => p.P034F015)
				.HasColumnName("P034F015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034F015")
				.IsOptional();

			Property(p => p.P034F016)
				.HasColumnName("P034F016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034F016")
				.IsOptional();

			Property(p => p.P034F017)
				.HasColumnName("P034F017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034F017")
				.IsOptional();

			Property(p => p.P034F018)
				.HasColumnName("P034F018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034F018")
				.IsOptional();

			Property(p => p.P034F019)
				.HasColumnName("P034F019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034F019")
				.IsOptional();

			Property(p => p.P034F020)
				.HasColumnName("P034F020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034F020")
				.IsOptional();

			Property(p => p.P034F021)
				.HasColumnName("P034F021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034F021")
				.IsOptional();

			Property(p => p.P034F022)
				.HasColumnName("P034F022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034F022")
				.IsOptional();

			Property(p => p.P034G001)
				.HasColumnName("P034G001")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034G001")
				.IsOptional();

			Property(p => p.P034G002)
				.HasColumnName("P034G002")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034G002")
				.IsOptional();

			Property(p => p.P034G003)
				.HasColumnName("P034G003")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034G003")
				.IsOptional();

			Property(p => p.P034G004)
				.HasColumnName("P034G004")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034G004")
				.IsOptional();

			Property(p => p.P034G005)
				.HasColumnName("P034G005")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034G005")
				.IsOptional();

			Property(p => p.P034G006)
				.HasColumnName("P034G006")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034G006")
				.IsOptional();

			Property(p => p.P034G007)
				.HasColumnName("P034G007")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034G007")
				.IsOptional();

			Property(p => p.P034G008)
				.HasColumnName("P034G008")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034G008")
				.IsOptional();

			Property(p => p.P034G009)
				.HasColumnName("P034G009")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034G009")
				.IsOptional();

			Property(p => p.P034G010)
				.HasColumnName("P034G010")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034G010")
				.IsOptional();

			Property(p => p.P034G011)
				.HasColumnName("P034G011")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034G011")
				.IsOptional();

			Property(p => p.P034G012)
				.HasColumnName("P034G012")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034G012")
				.IsOptional();

			Property(p => p.P034G013)
				.HasColumnName("P034G013")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034G013")
				.IsOptional();

			Property(p => p.P034G014)
				.HasColumnName("P034G014")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034G014")
				.IsOptional();

			Property(p => p.P034G015)
				.HasColumnName("P034G015")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034G015")
				.IsOptional();

			Property(p => p.P034G016)
				.HasColumnName("P034G016")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034G016")
				.IsOptional();

			Property(p => p.P034G017)
				.HasColumnName("P034G017")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034G017")
				.IsOptional();

			Property(p => p.P034G018)
				.HasColumnName("P034G018")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034G018")
				.IsOptional();

			Property(p => p.P034G019)
				.HasColumnName("P034G019")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034G019")
				.IsOptional();

			Property(p => p.P034G020)
				.HasColumnName("P034G020")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034G020")
				.IsOptional();

			Property(p => p.P034G021)
				.HasColumnName("P034G021")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034G021")
				.IsOptional();

			Property(p => p.P034G022)
				.HasColumnName("P034G022")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034G022")
				.IsOptional();

			Property(p => p.P034H001)
				.HasColumnName("P034H001")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034H001")
				.IsOptional();

			Property(p => p.P034H002)
				.HasColumnName("P034H002")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034H002")
				.IsOptional();

			Property(p => p.P034H003)
				.HasColumnName("P034H003")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034H003")
				.IsOptional();

			Property(p => p.P034H004)
				.HasColumnName("P034H004")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034H004")
				.IsOptional();

			Property(p => p.P034H005)
				.HasColumnName("P034H005")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034H005")
				.IsOptional();

			Property(p => p.P034H006)
				.HasColumnName("P034H006")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034H006")
				.IsOptional();

			Property(p => p.P034H007)
				.HasColumnName("P034H007")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034H007")
				.IsOptional();

			Property(p => p.P034H008)
				.HasColumnName("P034H008")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034H008")
				.IsOptional();

			Property(p => p.P034H009)
				.HasColumnName("P034H009")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034H009")
				.IsOptional();

			Property(p => p.P034H010)
				.HasColumnName("P034H010")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034H010")
				.IsOptional();

			Property(p => p.P034H011)
				.HasColumnName("P034H011")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034H011")
				.IsOptional();

			Property(p => p.P034H012)
				.HasColumnName("P034H012")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034H012")
				.IsOptional();

			Property(p => p.P034H013)
				.HasColumnName("P034H013")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034H013")
				.IsOptional();

			Property(p => p.P034H014)
				.HasColumnName("P034H014")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034H014")
				.IsOptional();

			Property(p => p.P034H015)
				.HasColumnName("P034H015")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034H015")
				.IsOptional();

			Property(p => p.P034H016)
				.HasColumnName("P034H016")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034H016")
				.IsOptional();

			Property(p => p.P034H017)
				.HasColumnName("P034H017")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034H017")
				.IsOptional();

			Property(p => p.P034H018)
				.HasColumnName("P034H018")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034H018")
				.IsOptional();

			Property(p => p.P034H019)
				.HasColumnName("P034H019")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034H019")
				.IsOptional();

			Property(p => p.P034H020)
				.HasColumnName("P034H020")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034H020")
				.IsOptional();

			Property(p => p.P034H021)
				.HasColumnName("P034H021")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034H021")
				.IsOptional();

			Property(p => p.P034H022)
				.HasColumnName("P034H022")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034H022")
				.IsOptional();

			Property(p => p.P034I001)
				.HasColumnName("P034I001")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034I001")
				.IsOptional();

			Property(p => p.P034I002)
				.HasColumnName("P034I002")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034I002")
				.IsOptional();

			Property(p => p.P034I003)
				.HasColumnName("P034I003")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034I003")
				.IsOptional();

			Property(p => p.P034I004)
				.HasColumnName("P034I004")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034I004")
				.IsOptional();

			Property(p => p.P034I005)
				.HasColumnName("P034I005")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034I005")
				.IsOptional();

			Property(p => p.P034I006)
				.HasColumnName("P034I006")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034I006")
				.IsOptional();

			Property(p => p.P034I007)
				.HasColumnName("P034I007")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034I007")
				.IsOptional();

			Property(p => p.P034I008)
				.HasColumnName("P034I008")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034I008")
				.IsOptional();

			Property(p => p.P034I009)
				.HasColumnName("P034I009")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034I009")
				.IsOptional();

			Property(p => p.P034I010)
				.HasColumnName("P034I010")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034I010")
				.IsOptional();

			Property(p => p.P034I011)
				.HasColumnName("P034I011")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034I011")
				.IsOptional();

			Property(p => p.P034I012)
				.HasColumnName("P034I012")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034I012")
				.IsOptional();

			Property(p => p.P034I013)
				.HasColumnName("P034I013")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034I013")
				.IsOptional();

			Property(p => p.P034I014)
				.HasColumnName("P034I014")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034I014")
				.IsOptional();

			Property(p => p.P034I015)
				.HasColumnName("P034I015")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034I015")
				.IsOptional();

			Property(p => p.P034I016)
				.HasColumnName("P034I016")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034I016")
				.IsOptional();

			Property(p => p.P034I017)
				.HasColumnName("P034I017")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034I017")
				.IsOptional();

			Property(p => p.P034I018)
				.HasColumnName("P034I018")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034I018")
				.IsOptional();

			Property(p => p.P034I019)
				.HasColumnName("P034I019")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034I019")
				.IsOptional();

			Property(p => p.P034I020)
				.HasColumnName("P034I020")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034I020")
				.IsOptional();

			Property(p => p.P034I021)
				.HasColumnName("P034I021")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034I021")
				.IsOptional();

			Property(p => p.P034I022)
				.HasColumnName("P034I022")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P034I022")
				.IsOptional();

			Property(p => p.P035A001)
				.HasColumnName("P035A001")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P035A001")
				.IsOptional();

			Property(p => p.P035B001)
				.HasColumnName("P035B001")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P035B001")
				.IsOptional();

			Property(p => p.P035C001)
				.HasColumnName("P035C001")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P035C001")
				.IsOptional();

			Property(p => p.P035D001)
				.HasColumnName("P035D001")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P035D001")
				.IsOptional();

			Property(p => p.P035E001)
				.HasColumnName("P035E001")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P035E001")
				.IsOptional();

			Property(p => p.P035F001)
				.HasColumnName("P035F001")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P035F001")
				.IsOptional();

			Property(p => p.P035G001)
				.HasColumnName("P035G001")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P035G001")
				.IsOptional();

			Property(p => p.P035H001)
				.HasColumnName("P035H001")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P035H001")
				.IsOptional();

			Property(p => p.P035I001)
				.HasColumnName("P035I001")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P035I001")
				.IsOptional();

			Property(p => p.P036A001)
				.HasColumnName("P036A001")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036A001")
				.IsOptional();

			Property(p => p.P036A002)
				.HasColumnName("P036A002")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036A002")
				.IsOptional();

			Property(p => p.P036A003)
				.HasColumnName("P036A003")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036A003")
				.IsOptional();

			Property(p => p.P036B001)
				.HasColumnName("P036B001")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036B001")
				.IsOptional();

			Property(p => p.P036B002)
				.HasColumnName("P036B002")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036B002")
				.IsOptional();

			Property(p => p.P036B003)
				.HasColumnName("P036B003")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036B003")
				.IsOptional();

			Property(p => p.P036C001)
				.HasColumnName("P036C001")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036C001")
				.IsOptional();

			Property(p => p.P036C002)
				.HasColumnName("P036C002")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036C002")
				.IsOptional();

			Property(p => p.P036C003)
				.HasColumnName("P036C003")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036C003")
				.IsOptional();

			Property(p => p.P036D001)
				.HasColumnName("P036D001")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036D001")
				.IsOptional();

			Property(p => p.P036D002)
				.HasColumnName("P036D002")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036D002")
				.IsOptional();

			Property(p => p.P036D003)
				.HasColumnName("P036D003")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036D003")
				.IsOptional();

			Property(p => p.P036E001)
				.HasColumnName("P036E001")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036E001")
				.IsOptional();

			Property(p => p.P036E002)
				.HasColumnName("P036E002")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036E002")
				.IsOptional();

			Property(p => p.P036E003)
				.HasColumnName("P036E003")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036E003")
				.IsOptional();

			Property(p => p.P036F001)
				.HasColumnName("P036F001")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036F001")
				.IsOptional();

			Property(p => p.P036F002)
				.HasColumnName("P036F002")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036F002")
				.IsOptional();

			Property(p => p.P036F003)
				.HasColumnName("P036F003")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036F003")
				.IsOptional();

			Property(p => p.P036G001)
				.HasColumnName("P036G001")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036G001")
				.IsOptional();

			Property(p => p.P036G002)
				.HasColumnName("P036G002")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036G002")
				.IsOptional();

			Property(p => p.P036G003)
				.HasColumnName("P036G003")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036G003")
				.IsOptional();

			Property(p => p.P036H001)
				.HasColumnName("P036H001")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036H001")
				.IsOptional();

			Property(p => p.P036H002)
				.HasColumnName("P036H002")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036H002")
				.IsOptional();

			Property(p => p.P036H003)
				.HasColumnName("P036H003")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036H003")
				.IsOptional();

			Property(p => p.P036I001)
				.HasColumnName("P036I001")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036I001")
				.IsOptional();

			Property(p => p.P036I002)
				.HasColumnName("P036I002")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036I002")
				.IsOptional();

			Property(p => p.P036I003)
				.HasColumnName("P036I003")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P036I003")
				.IsOptional();

			Property(p => p.P037A001)
				.HasColumnName("P037A001")
				.HasColumnOrder(129)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037A001")
				.IsOptional();

			Property(p => p.P037A002)
				.HasColumnName("P037A002")
				.HasColumnOrder(130)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037A002")
				.IsOptional();

			Property(p => p.P037A003)
				.HasColumnName("P037A003")
				.HasColumnOrder(131)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037A003")
				.IsOptional();

			Property(p => p.P037B001)
				.HasColumnName("P037B001")
				.HasColumnOrder(132)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037B001")
				.IsOptional();

			Property(p => p.P037B002)
				.HasColumnName("P037B002")
				.HasColumnOrder(133)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037B002")
				.IsOptional();

			Property(p => p.P037B003)
				.HasColumnName("P037B003")
				.HasColumnOrder(134)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037B003")
				.IsOptional();

			Property(p => p.P037C001)
				.HasColumnName("P037C001")
				.HasColumnOrder(135)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037C001")
				.IsOptional();

			Property(p => p.P037C002)
				.HasColumnName("P037C002")
				.HasColumnOrder(136)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037C002")
				.IsOptional();

			Property(p => p.P037C003)
				.HasColumnName("P037C003")
				.HasColumnOrder(137)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037C003")
				.IsOptional();

			Property(p => p.P037D001)
				.HasColumnName("P037D001")
				.HasColumnOrder(138)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037D001")
				.IsOptional();

			Property(p => p.P037D002)
				.HasColumnName("P037D002")
				.HasColumnOrder(139)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037D002")
				.IsOptional();

			Property(p => p.P037D003)
				.HasColumnName("P037D003")
				.HasColumnOrder(140)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037D003")
				.IsOptional();

			Property(p => p.P037E001)
				.HasColumnName("P037E001")
				.HasColumnOrder(141)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037E001")
				.IsOptional();

			Property(p => p.P037E002)
				.HasColumnName("P037E002")
				.HasColumnOrder(142)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037E002")
				.IsOptional();

			Property(p => p.P037E003)
				.HasColumnName("P037E003")
				.HasColumnOrder(143)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037E003")
				.IsOptional();

			Property(p => p.P037F001)
				.HasColumnName("P037F001")
				.HasColumnOrder(144)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037F001")
				.IsOptional();

			Property(p => p.P037F002)
				.HasColumnName("P037F002")
				.HasColumnOrder(145)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037F002")
				.IsOptional();

			Property(p => p.P037F003)
				.HasColumnName("P037F003")
				.HasColumnOrder(146)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037F003")
				.IsOptional();

			Property(p => p.P037G001)
				.HasColumnName("P037G001")
				.HasColumnOrder(147)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037G001")
				.IsOptional();

			Property(p => p.P037G002)
				.HasColumnName("P037G002")
				.HasColumnOrder(148)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037G002")
				.IsOptional();

			Property(p => p.P037G003)
				.HasColumnName("P037G003")
				.HasColumnOrder(149)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037G003")
				.IsOptional();

			Property(p => p.P037H001)
				.HasColumnName("P037H001")
				.HasColumnOrder(150)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037H001")
				.IsOptional();

			Property(p => p.P037H002)
				.HasColumnName("P037H002")
				.HasColumnOrder(151)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037H002")
				.IsOptional();

			Property(p => p.P037H003)
				.HasColumnName("P037H003")
				.HasColumnOrder(152)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037H003")
				.IsOptional();

			Property(p => p.P037I001)
				.HasColumnName("P037I001")
				.HasColumnOrder(153)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037I001")
				.IsOptional();

			Property(p => p.P037I002)
				.HasColumnName("P037I002")
				.HasColumnOrder(154)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037I002")
				.IsOptional();

			Property(p => p.P037I003)
				.HasColumnName("P037I003")
				.HasColumnOrder(155)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P037I003")
				.IsOptional();

			Property(p => p.P038A001)
				.HasColumnName("P038A001")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038A001")
				.IsOptional();

			Property(p => p.P038A002)
				.HasColumnName("P038A002")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038A002")
				.IsOptional();

			Property(p => p.P038A003)
				.HasColumnName("P038A003")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038A003")
				.IsOptional();

			Property(p => p.P038A004)
				.HasColumnName("P038A004")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038A004")
				.IsOptional();

			Property(p => p.P038A005)
				.HasColumnName("P038A005")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038A005")
				.IsOptional();

			Property(p => p.P038A006)
				.HasColumnName("P038A006")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038A006")
				.IsOptional();

			Property(p => p.P038A007)
				.HasColumnName("P038A007")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038A007")
				.IsOptional();

			Property(p => p.P038A008)
				.HasColumnName("P038A008")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038A008")
				.IsOptional();

			Property(p => p.P038A009)
				.HasColumnName("P038A009")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038A009")
				.IsOptional();

			Property(p => p.P038A010)
				.HasColumnName("P038A010")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038A010")
				.IsOptional();

			Property(p => p.P038A011)
				.HasColumnName("P038A011")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038A011")
				.IsOptional();

			Property(p => p.P038A012)
				.HasColumnName("P038A012")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038A012")
				.IsOptional();

			Property(p => p.P038A013)
				.HasColumnName("P038A013")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038A013")
				.IsOptional();

			Property(p => p.P038A014)
				.HasColumnName("P038A014")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038A014")
				.IsOptional();

			Property(p => p.P038A015)
				.HasColumnName("P038A015")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038A015")
				.IsOptional();

			Property(p => p.P038A016)
				.HasColumnName("P038A016")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038A016")
				.IsOptional();

			Property(p => p.P038A017)
				.HasColumnName("P038A017")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038A017")
				.IsOptional();

			Property(p => p.P038A018)
				.HasColumnName("P038A018")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038A018")
				.IsOptional();

			Property(p => p.P038A019)
				.HasColumnName("P038A019")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038A019")
				.IsOptional();

			Property(p => p.P038A020)
				.HasColumnName("P038A020")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038A020")
				.IsOptional();

			Property(p => p.P038B001)
				.HasColumnName("P038B001")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038B001")
				.IsOptional();

			Property(p => p.P038B002)
				.HasColumnName("P038B002")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038B002")
				.IsOptional();

			Property(p => p.P038B003)
				.HasColumnName("P038B003")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038B003")
				.IsOptional();

			Property(p => p.P038B004)
				.HasColumnName("P038B004")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038B004")
				.IsOptional();

			Property(p => p.P038B005)
				.HasColumnName("P038B005")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038B005")
				.IsOptional();

			Property(p => p.P038B006)
				.HasColumnName("P038B006")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038B006")
				.IsOptional();

			Property(p => p.P038B007)
				.HasColumnName("P038B007")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038B007")
				.IsOptional();

			Property(p => p.P038B008)
				.HasColumnName("P038B008")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038B008")
				.IsOptional();

			Property(p => p.P038B009)
				.HasColumnName("P038B009")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038B009")
				.IsOptional();

			Property(p => p.P038B010)
				.HasColumnName("P038B010")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038B010")
				.IsOptional();

			Property(p => p.P038B011)
				.HasColumnName("P038B011")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038B011")
				.IsOptional();

			Property(p => p.P038B012)
				.HasColumnName("P038B012")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038B012")
				.IsOptional();

			Property(p => p.P038B013)
				.HasColumnName("P038B013")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038B013")
				.IsOptional();

			Property(p => p.P038B014)
				.HasColumnName("P038B014")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038B014")
				.IsOptional();

			Property(p => p.P038B015)
				.HasColumnName("P038B015")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038B015")
				.IsOptional();

			Property(p => p.P038B016)
				.HasColumnName("P038B016")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038B016")
				.IsOptional();

			Property(p => p.P038B017)
				.HasColumnName("P038B017")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038B017")
				.IsOptional();

			Property(p => p.P038B018)
				.HasColumnName("P038B018")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038B018")
				.IsOptional();

			Property(p => p.P038B019)
				.HasColumnName("P038B019")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038B019")
				.IsOptional();

			Property(p => p.P038B020)
				.HasColumnName("P038B020")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038B020")
				.IsOptional();

			Property(p => p.P038C001)
				.HasColumnName("P038C001")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038C001")
				.IsOptional();

			Property(p => p.P038C002)
				.HasColumnName("P038C002")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038C002")
				.IsOptional();

			Property(p => p.P038C003)
				.HasColumnName("P038C003")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038C003")
				.IsOptional();

			Property(p => p.P038C004)
				.HasColumnName("P038C004")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038C004")
				.IsOptional();

			Property(p => p.P038C005)
				.HasColumnName("P038C005")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038C005")
				.IsOptional();

			Property(p => p.P038C006)
				.HasColumnName("P038C006")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038C006")
				.IsOptional();

			Property(p => p.P038C007)
				.HasColumnName("P038C007")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038C007")
				.IsOptional();

			Property(p => p.P038C008)
				.HasColumnName("P038C008")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038C008")
				.IsOptional();

			Property(p => p.P038C009)
				.HasColumnName("P038C009")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038C009")
				.IsOptional();

			Property(p => p.P038C010)
				.HasColumnName("P038C010")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038C010")
				.IsOptional();

			Property(p => p.P038C011)
				.HasColumnName("P038C011")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038C011")
				.IsOptional();

			Property(p => p.P038C012)
				.HasColumnName("P038C012")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038C012")
				.IsOptional();

			Property(p => p.P038C013)
				.HasColumnName("P038C013")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038C013")
				.IsOptional();

			Property(p => p.P038C014)
				.HasColumnName("P038C014")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038C014")
				.IsOptional();

			Property(p => p.P038C015)
				.HasColumnName("P038C015")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038C015")
				.IsOptional();

			Property(p => p.P038C016)
				.HasColumnName("P038C016")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038C016")
				.IsOptional();

			Property(p => p.P038C017)
				.HasColumnName("P038C017")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038C017")
				.IsOptional();

			Property(p => p.P038C018)
				.HasColumnName("P038C018")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038C018")
				.IsOptional();

			Property(p => p.P038C019)
				.HasColumnName("P038C019")
				.HasColumnOrder(214)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038C019")
				.IsOptional();

			Property(p => p.P038C020)
				.HasColumnName("P038C020")
				.HasColumnOrder(215)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038C020")
				.IsOptional();

			Property(p => p.P038D001)
				.HasColumnName("P038D001")
				.HasColumnOrder(216)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038D001")
				.IsOptional();

			Property(p => p.P038D002)
				.HasColumnName("P038D002")
				.HasColumnOrder(217)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038D002")
				.IsOptional();

			Property(p => p.P038D003)
				.HasColumnName("P038D003")
				.HasColumnOrder(218)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038D003")
				.IsOptional();

			Property(p => p.P038D004)
				.HasColumnName("P038D004")
				.HasColumnOrder(219)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038D004")
				.IsOptional();

			Property(p => p.P038D005)
				.HasColumnName("P038D005")
				.HasColumnOrder(220)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038D005")
				.IsOptional();

			Property(p => p.P038D006)
				.HasColumnName("P038D006")
				.HasColumnOrder(221)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038D006")
				.IsOptional();

			Property(p => p.P038D007)
				.HasColumnName("P038D007")
				.HasColumnOrder(222)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038D007")
				.IsOptional();

			Property(p => p.P038D008)
				.HasColumnName("P038D008")
				.HasColumnOrder(223)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038D008")
				.IsOptional();

			Property(p => p.P038D009)
				.HasColumnName("P038D009")
				.HasColumnOrder(224)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038D009")
				.IsOptional();

			Property(p => p.P038D010)
				.HasColumnName("P038D010")
				.HasColumnOrder(225)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038D010")
				.IsOptional();

			Property(p => p.P038D011)
				.HasColumnName("P038D011")
				.HasColumnOrder(226)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038D011")
				.IsOptional();

			Property(p => p.P038D012)
				.HasColumnName("P038D012")
				.HasColumnOrder(227)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038D012")
				.IsOptional();

			Property(p => p.P038D013)
				.HasColumnName("P038D013")
				.HasColumnOrder(228)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038D013")
				.IsOptional();

			Property(p => p.P038D014)
				.HasColumnName("P038D014")
				.HasColumnOrder(229)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038D014")
				.IsOptional();

			Property(p => p.P038D015)
				.HasColumnName("P038D015")
				.HasColumnOrder(230)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038D015")
				.IsOptional();

			Property(p => p.P038D016)
				.HasColumnName("P038D016")
				.HasColumnOrder(231)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038D016")
				.IsOptional();

			Property(p => p.P038D017)
				.HasColumnName("P038D017")
				.HasColumnOrder(232)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038D017")
				.IsOptional();

			Property(p => p.P038D018)
				.HasColumnName("P038D018")
				.HasColumnOrder(233)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038D018")
				.IsOptional();

			Property(p => p.P038D019)
				.HasColumnName("P038D019")
				.HasColumnOrder(234)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038D019")
				.IsOptional();

			Property(p => p.P038D020)
				.HasColumnName("P038D020")
				.HasColumnOrder(235)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038D020")
				.IsOptional();

			Property(p => p.P038E001)
				.HasColumnName("P038E001")
				.HasColumnOrder(236)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038E001")
				.IsOptional();

			Property(p => p.P038E002)
				.HasColumnName("P038E002")
				.HasColumnOrder(237)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038E002")
				.IsOptional();

			Property(p => p.P038E003)
				.HasColumnName("P038E003")
				.HasColumnOrder(238)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038E003")
				.IsOptional();

			Property(p => p.P038E004)
				.HasColumnName("P038E004")
				.HasColumnOrder(239)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038E004")
				.IsOptional();

			Property(p => p.P038E005)
				.HasColumnName("P038E005")
				.HasColumnOrder(240)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038E005")
				.IsOptional();

			Property(p => p.P038E006)
				.HasColumnName("P038E006")
				.HasColumnOrder(241)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038E006")
				.IsOptional();

			Property(p => p.P038E007)
				.HasColumnName("P038E007")
				.HasColumnOrder(242)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038E007")
				.IsOptional();

			Property(p => p.P038E008)
				.HasColumnName("P038E008")
				.HasColumnOrder(243)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038E008")
				.IsOptional();

			Property(p => p.P038E009)
				.HasColumnName("P038E009")
				.HasColumnOrder(244)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038E009")
				.IsOptional();

			Property(p => p.P038E010)
				.HasColumnName("P038E010")
				.HasColumnOrder(245)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038E010")
				.IsOptional();

			Property(p => p.P038E011)
				.HasColumnName("P038E011")
				.HasColumnOrder(246)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038E011")
				.IsOptional();

			Property(p => p.P038E012)
				.HasColumnName("P038E012")
				.HasColumnOrder(247)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038E012")
				.IsOptional();

			Property(p => p.P038E013)
				.HasColumnName("P038E013")
				.HasColumnOrder(248)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038E013")
				.IsOptional();

			Property(p => p.P038E014)
				.HasColumnName("P038E014")
				.HasColumnOrder(249)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038E014")
				.IsOptional();

			Property(p => p.P038E015)
				.HasColumnName("P038E015")
				.HasColumnOrder(250)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038E015")
				.IsOptional();

			Property(p => p.P038E016)
				.HasColumnName("P038E016")
				.HasColumnOrder(251)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038E016")
				.IsOptional();

			Property(p => p.P038E017)
				.HasColumnName("P038E017")
				.HasColumnOrder(252)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038E017")
				.IsOptional();

			Property(p => p.P038E018)
				.HasColumnName("P038E018")
				.HasColumnOrder(253)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038E018")
				.IsOptional();

			Property(p => p.P038E019)
				.HasColumnName("P038E019")
				.HasColumnOrder(254)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038E019")
				.IsOptional();

			Property(p => p.P038E020)
				.HasColumnName("P038E020")
				.HasColumnOrder(255)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P038E020")
				.IsOptional();
		}
	}
}
