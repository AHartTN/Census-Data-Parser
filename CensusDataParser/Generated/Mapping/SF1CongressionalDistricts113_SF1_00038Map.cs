namespace CensusDataParser.Generated.Mapping
{
	#region Using Directives
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.ModelConfiguration;
	using Binding;
	#endregion Using Directives

	public class SF1CongressionalDistricts113_SF1_00038Map : EntityTypeConfiguration<SF1CongressionalDistricts113_SF1_00038>
	{
		public SF1CongressionalDistricts113_SF1_00038Map()
		{
			ToTable("SF1_00038", "SF1CongressionalDistricts113");

			HasKey(k => new
			            {
				            k.FILEID,
				            k.STUSAB,
				            k.CHARITER,
				            k.CIFSN,
				            k.LOGRECNO
			            });

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

			Property(p => p.PCT020F001)
				.HasColumnName("PCT020F001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F001")
				.IsOptional();

			Property(p => p.PCT020F002)
				.HasColumnName("PCT020F002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F002")
				.IsOptional();

			Property(p => p.PCT020F003)
				.HasColumnName("PCT020F003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F003")
				.IsOptional();

			Property(p => p.PCT020F004)
				.HasColumnName("PCT020F004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F004")
				.IsOptional();

			Property(p => p.PCT020F005)
				.HasColumnName("PCT020F005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F005")
				.IsOptional();

			Property(p => p.PCT020F006)
				.HasColumnName("PCT020F006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F006")
				.IsOptional();

			Property(p => p.PCT020F007)
				.HasColumnName("PCT020F007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F007")
				.IsOptional();

			Property(p => p.PCT020F008)
				.HasColumnName("PCT020F008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F008")
				.IsOptional();

			Property(p => p.PCT020F009)
				.HasColumnName("PCT020F009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F009")
				.IsOptional();

			Property(p => p.PCT020F010)
				.HasColumnName("PCT020F010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F010")
				.IsOptional();

			Property(p => p.PCT020F011)
				.HasColumnName("PCT020F011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F011")
				.IsOptional();

			Property(p => p.PCT020F012)
				.HasColumnName("PCT020F012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F012")
				.IsOptional();

			Property(p => p.PCT020F013)
				.HasColumnName("PCT020F013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F013")
				.IsOptional();

			Property(p => p.PCT020F014)
				.HasColumnName("PCT020F014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F014")
				.IsOptional();

			Property(p => p.PCT020F015)
				.HasColumnName("PCT020F015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F015")
				.IsOptional();

			Property(p => p.PCT020F016)
				.HasColumnName("PCT020F016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F016")
				.IsOptional();

			Property(p => p.PCT020F017)
				.HasColumnName("PCT020F017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F017")
				.IsOptional();

			Property(p => p.PCT020F018)
				.HasColumnName("PCT020F018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F018")
				.IsOptional();

			Property(p => p.PCT020F019)
				.HasColumnName("PCT020F019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F019")
				.IsOptional();

			Property(p => p.PCT020F020)
				.HasColumnName("PCT020F020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F020")
				.IsOptional();

			Property(p => p.PCT020F021)
				.HasColumnName("PCT020F021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F021")
				.IsOptional();

			Property(p => p.PCT020F022)
				.HasColumnName("PCT020F022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F022")
				.IsOptional();

			Property(p => p.PCT020F023)
				.HasColumnName("PCT020F023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F023")
				.IsOptional();

			Property(p => p.PCT020F024)
				.HasColumnName("PCT020F024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F024")
				.IsOptional();

			Property(p => p.PCT020F025)
				.HasColumnName("PCT020F025")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F025")
				.IsOptional();

			Property(p => p.PCT020F026)
				.HasColumnName("PCT020F026")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F026")
				.IsOptional();

			Property(p => p.PCT020F027)
				.HasColumnName("PCT020F027")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F027")
				.IsOptional();

			Property(p => p.PCT020F028)
				.HasColumnName("PCT020F028")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F028")
				.IsOptional();

			Property(p => p.PCT020F029)
				.HasColumnName("PCT020F029")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F029")
				.IsOptional();

			Property(p => p.PCT020F030)
				.HasColumnName("PCT020F030")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F030")
				.IsOptional();

			Property(p => p.PCT020F031)
				.HasColumnName("PCT020F031")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F031")
				.IsOptional();

			Property(p => p.PCT020F032)
				.HasColumnName("PCT020F032")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020F032")
				.IsOptional();

			Property(p => p.PCT020G001)
				.HasColumnName("PCT020G001")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G001")
				.IsOptional();

			Property(p => p.PCT020G002)
				.HasColumnName("PCT020G002")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G002")
				.IsOptional();

			Property(p => p.PCT020G003)
				.HasColumnName("PCT020G003")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G003")
				.IsOptional();

			Property(p => p.PCT020G004)
				.HasColumnName("PCT020G004")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G004")
				.IsOptional();

			Property(p => p.PCT020G005)
				.HasColumnName("PCT020G005")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G005")
				.IsOptional();

			Property(p => p.PCT020G006)
				.HasColumnName("PCT020G006")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G006")
				.IsOptional();

			Property(p => p.PCT020G007)
				.HasColumnName("PCT020G007")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G007")
				.IsOptional();

			Property(p => p.PCT020G008)
				.HasColumnName("PCT020G008")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G008")
				.IsOptional();

			Property(p => p.PCT020G009)
				.HasColumnName("PCT020G009")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G009")
				.IsOptional();

			Property(p => p.PCT020G010)
				.HasColumnName("PCT020G010")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G010")
				.IsOptional();

			Property(p => p.PCT020G011)
				.HasColumnName("PCT020G011")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G011")
				.IsOptional();

			Property(p => p.PCT020G012)
				.HasColumnName("PCT020G012")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G012")
				.IsOptional();

			Property(p => p.PCT020G013)
				.HasColumnName("PCT020G013")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G013")
				.IsOptional();

			Property(p => p.PCT020G014)
				.HasColumnName("PCT020G014")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G014")
				.IsOptional();

			Property(p => p.PCT020G015)
				.HasColumnName("PCT020G015")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G015")
				.IsOptional();

			Property(p => p.PCT020G016)
				.HasColumnName("PCT020G016")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G016")
				.IsOptional();

			Property(p => p.PCT020G017)
				.HasColumnName("PCT020G017")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G017")
				.IsOptional();

			Property(p => p.PCT020G018)
				.HasColumnName("PCT020G018")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G018")
				.IsOptional();

			Property(p => p.PCT020G019)
				.HasColumnName("PCT020G019")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G019")
				.IsOptional();

			Property(p => p.PCT020G020)
				.HasColumnName("PCT020G020")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G020")
				.IsOptional();

			Property(p => p.PCT020G021)
				.HasColumnName("PCT020G021")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G021")
				.IsOptional();

			Property(p => p.PCT020G022)
				.HasColumnName("PCT020G022")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G022")
				.IsOptional();

			Property(p => p.PCT020G023)
				.HasColumnName("PCT020G023")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G023")
				.IsOptional();

			Property(p => p.PCT020G024)
				.HasColumnName("PCT020G024")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G024")
				.IsOptional();

			Property(p => p.PCT020G025)
				.HasColumnName("PCT020G025")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G025")
				.IsOptional();

			Property(p => p.PCT020G026)
				.HasColumnName("PCT020G026")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G026")
				.IsOptional();

			Property(p => p.PCT020G027)
				.HasColumnName("PCT020G027")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G027")
				.IsOptional();

			Property(p => p.PCT020G028)
				.HasColumnName("PCT020G028")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G028")
				.IsOptional();

			Property(p => p.PCT020G029)
				.HasColumnName("PCT020G029")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G029")
				.IsOptional();

			Property(p => p.PCT020G030)
				.HasColumnName("PCT020G030")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G030")
				.IsOptional();

			Property(p => p.PCT020G031)
				.HasColumnName("PCT020G031")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G031")
				.IsOptional();

			Property(p => p.PCT020G032)
				.HasColumnName("PCT020G032")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020G032")
				.IsOptional();

			Property(p => p.PCT020H001)
				.HasColumnName("PCT020H001")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H001")
				.IsOptional();

			Property(p => p.PCT020H002)
				.HasColumnName("PCT020H002")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H002")
				.IsOptional();

			Property(p => p.PCT020H003)
				.HasColumnName("PCT020H003")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H003")
				.IsOptional();

			Property(p => p.PCT020H004)
				.HasColumnName("PCT020H004")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H004")
				.IsOptional();

			Property(p => p.PCT020H005)
				.HasColumnName("PCT020H005")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H005")
				.IsOptional();

			Property(p => p.PCT020H006)
				.HasColumnName("PCT020H006")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H006")
				.IsOptional();

			Property(p => p.PCT020H007)
				.HasColumnName("PCT020H007")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H007")
				.IsOptional();

			Property(p => p.PCT020H008)
				.HasColumnName("PCT020H008")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H008")
				.IsOptional();

			Property(p => p.PCT020H009)
				.HasColumnName("PCT020H009")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H009")
				.IsOptional();

			Property(p => p.PCT020H010)
				.HasColumnName("PCT020H010")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H010")
				.IsOptional();

			Property(p => p.PCT020H011)
				.HasColumnName("PCT020H011")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H011")
				.IsOptional();

			Property(p => p.PCT020H012)
				.HasColumnName("PCT020H012")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H012")
				.IsOptional();

			Property(p => p.PCT020H013)
				.HasColumnName("PCT020H013")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H013")
				.IsOptional();

			Property(p => p.PCT020H014)
				.HasColumnName("PCT020H014")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H014")
				.IsOptional();

			Property(p => p.PCT020H015)
				.HasColumnName("PCT020H015")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H015")
				.IsOptional();

			Property(p => p.PCT020H016)
				.HasColumnName("PCT020H016")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H016")
				.IsOptional();

			Property(p => p.PCT020H017)
				.HasColumnName("PCT020H017")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H017")
				.IsOptional();

			Property(p => p.PCT020H018)
				.HasColumnName("PCT020H018")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H018")
				.IsOptional();

			Property(p => p.PCT020H019)
				.HasColumnName("PCT020H019")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H019")
				.IsOptional();

			Property(p => p.PCT020H020)
				.HasColumnName("PCT020H020")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H020")
				.IsOptional();

			Property(p => p.PCT020H021)
				.HasColumnName("PCT020H021")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H021")
				.IsOptional();

			Property(p => p.PCT020H022)
				.HasColumnName("PCT020H022")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H022")
				.IsOptional();

			Property(p => p.PCT020H023)
				.HasColumnName("PCT020H023")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H023")
				.IsOptional();

			Property(p => p.PCT020H024)
				.HasColumnName("PCT020H024")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H024")
				.IsOptional();

			Property(p => p.PCT020H025)
				.HasColumnName("PCT020H025")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H025")
				.IsOptional();

			Property(p => p.PCT020H026)
				.HasColumnName("PCT020H026")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H026")
				.IsOptional();

			Property(p => p.PCT020H027)
				.HasColumnName("PCT020H027")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H027")
				.IsOptional();

			Property(p => p.PCT020H028)
				.HasColumnName("PCT020H028")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H028")
				.IsOptional();

			Property(p => p.PCT020H029)
				.HasColumnName("PCT020H029")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H029")
				.IsOptional();

			Property(p => p.PCT020H030)
				.HasColumnName("PCT020H030")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H030")
				.IsOptional();

			Property(p => p.PCT020H031)
				.HasColumnName("PCT020H031")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H031")
				.IsOptional();

			Property(p => p.PCT020H032)
				.HasColumnName("PCT020H032")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020H032")
				.IsOptional();

			Property(p => p.PCT020I001)
				.HasColumnName("PCT020I001")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I001")
				.IsOptional();

			Property(p => p.PCT020I002)
				.HasColumnName("PCT020I002")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I002")
				.IsOptional();

			Property(p => p.PCT020I003)
				.HasColumnName("PCT020I003")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I003")
				.IsOptional();

			Property(p => p.PCT020I004)
				.HasColumnName("PCT020I004")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I004")
				.IsOptional();

			Property(p => p.PCT020I005)
				.HasColumnName("PCT020I005")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I005")
				.IsOptional();

			Property(p => p.PCT020I006)
				.HasColumnName("PCT020I006")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I006")
				.IsOptional();

			Property(p => p.PCT020I007)
				.HasColumnName("PCT020I007")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I007")
				.IsOptional();

			Property(p => p.PCT020I008)
				.HasColumnName("PCT020I008")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I008")
				.IsOptional();

			Property(p => p.PCT020I009)
				.HasColumnName("PCT020I009")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I009")
				.IsOptional();

			Property(p => p.PCT020I010)
				.HasColumnName("PCT020I010")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I010")
				.IsOptional();

			Property(p => p.PCT020I011)
				.HasColumnName("PCT020I011")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I011")
				.IsOptional();

			Property(p => p.PCT020I012)
				.HasColumnName("PCT020I012")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I012")
				.IsOptional();

			Property(p => p.PCT020I013)
				.HasColumnName("PCT020I013")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I013")
				.IsOptional();

			Property(p => p.PCT020I014)
				.HasColumnName("PCT020I014")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I014")
				.IsOptional();

			Property(p => p.PCT020I015)
				.HasColumnName("PCT020I015")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I015")
				.IsOptional();

			Property(p => p.PCT020I016)
				.HasColumnName("PCT020I016")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I016")
				.IsOptional();

			Property(p => p.PCT020I017)
				.HasColumnName("PCT020I017")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I017")
				.IsOptional();

			Property(p => p.PCT020I018)
				.HasColumnName("PCT020I018")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I018")
				.IsOptional();

			Property(p => p.PCT020I019)
				.HasColumnName("PCT020I019")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I019")
				.IsOptional();

			Property(p => p.PCT020I020)
				.HasColumnName("PCT020I020")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I020")
				.IsOptional();

			Property(p => p.PCT020I021)
				.HasColumnName("PCT020I021")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I021")
				.IsOptional();

			Property(p => p.PCT020I022)
				.HasColumnName("PCT020I022")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I022")
				.IsOptional();

			Property(p => p.PCT020I023)
				.HasColumnName("PCT020I023")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I023")
				.IsOptional();

			Property(p => p.PCT020I024)
				.HasColumnName("PCT020I024")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I024")
				.IsOptional();

			Property(p => p.PCT020I025)
				.HasColumnName("PCT020I025")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I025")
				.IsOptional();

			Property(p => p.PCT020I026)
				.HasColumnName("PCT020I026")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I026")
				.IsOptional();

			Property(p => p.PCT020I027)
				.HasColumnName("PCT020I027")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I027")
				.IsOptional();

			Property(p => p.PCT020I028)
				.HasColumnName("PCT020I028")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I028")
				.IsOptional();

			Property(p => p.PCT020I029)
				.HasColumnName("PCT020I029")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I029")
				.IsOptional();

			Property(p => p.PCT020I030)
				.HasColumnName("PCT020I030")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I030")
				.IsOptional();

			Property(p => p.PCT020I031)
				.HasColumnName("PCT020I031")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I031")
				.IsOptional();

			Property(p => p.PCT020I032)
				.HasColumnName("PCT020I032")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020I032")
				.IsOptional();

			Property(p => p.PCT022A001)
				.HasColumnName("PCT022A001")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022A001")
				.IsOptional();

			Property(p => p.PCT022A002)
				.HasColumnName("PCT022A002")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022A002")
				.IsOptional();

			Property(p => p.PCT022A003)
				.HasColumnName("PCT022A003")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022A003")
				.IsOptional();

			Property(p => p.PCT022A004)
				.HasColumnName("PCT022A004")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022A004")
				.IsOptional();

			Property(p => p.PCT022A005)
				.HasColumnName("PCT022A005")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022A005")
				.IsOptional();

			Property(p => p.PCT022A006)
				.HasColumnName("PCT022A006")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022A006")
				.IsOptional();

			Property(p => p.PCT022A007)
				.HasColumnName("PCT022A007")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022A007")
				.IsOptional();

			Property(p => p.PCT022A008)
				.HasColumnName("PCT022A008")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022A008")
				.IsOptional();

			Property(p => p.PCT022A009)
				.HasColumnName("PCT022A009")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022A009")
				.IsOptional();

			Property(p => p.PCT022A010)
				.HasColumnName("PCT022A010")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022A010")
				.IsOptional();

			Property(p => p.PCT022A011)
				.HasColumnName("PCT022A011")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022A011")
				.IsOptional();

			Property(p => p.PCT022A012)
				.HasColumnName("PCT022A012")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022A012")
				.IsOptional();

			Property(p => p.PCT022A013)
				.HasColumnName("PCT022A013")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022A013")
				.IsOptional();

			Property(p => p.PCT022A014)
				.HasColumnName("PCT022A014")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022A014")
				.IsOptional();

			Property(p => p.PCT022A015)
				.HasColumnName("PCT022A015")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022A015")
				.IsOptional();

			Property(p => p.PCT022A016)
				.HasColumnName("PCT022A016")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022A016")
				.IsOptional();

			Property(p => p.PCT022A017)
				.HasColumnName("PCT022A017")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022A017")
				.IsOptional();

			Property(p => p.PCT022A018)
				.HasColumnName("PCT022A018")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022A018")
				.IsOptional();

			Property(p => p.PCT022A019)
				.HasColumnName("PCT022A019")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022A019")
				.IsOptional();

			Property(p => p.PCT022A020)
				.HasColumnName("PCT022A020")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022A020")
				.IsOptional();

			Property(p => p.PCT022A021)
				.HasColumnName("PCT022A021")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022A021")
				.IsOptional();

			Property(p => p.PCT022B001)
				.HasColumnName("PCT022B001")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022B001")
				.IsOptional();

			Property(p => p.PCT022B002)
				.HasColumnName("PCT022B002")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022B002")
				.IsOptional();

			Property(p => p.PCT022B003)
				.HasColumnName("PCT022B003")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022B003")
				.IsOptional();

			Property(p => p.PCT022B004)
				.HasColumnName("PCT022B004")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022B004")
				.IsOptional();

			Property(p => p.PCT022B005)
				.HasColumnName("PCT022B005")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022B005")
				.IsOptional();

			Property(p => p.PCT022B006)
				.HasColumnName("PCT022B006")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022B006")
				.IsOptional();

			Property(p => p.PCT022B007)
				.HasColumnName("PCT022B007")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022B007")
				.IsOptional();

			Property(p => p.PCT022B008)
				.HasColumnName("PCT022B008")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022B008")
				.IsOptional();

			Property(p => p.PCT022B009)
				.HasColumnName("PCT022B009")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022B009")
				.IsOptional();

			Property(p => p.PCT022B010)
				.HasColumnName("PCT022B010")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022B010")
				.IsOptional();

			Property(p => p.PCT022B011)
				.HasColumnName("PCT022B011")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022B011")
				.IsOptional();

			Property(p => p.PCT022B012)
				.HasColumnName("PCT022B012")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022B012")
				.IsOptional();

			Property(p => p.PCT022B013)
				.HasColumnName("PCT022B013")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022B013")
				.IsOptional();

			Property(p => p.PCT022B014)
				.HasColumnName("PCT022B014")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022B014")
				.IsOptional();

			Property(p => p.PCT022B015)
				.HasColumnName("PCT022B015")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022B015")
				.IsOptional();

			Property(p => p.PCT022B016)
				.HasColumnName("PCT022B016")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022B016")
				.IsOptional();

			Property(p => p.PCT022B017)
				.HasColumnName("PCT022B017")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022B017")
				.IsOptional();

			Property(p => p.PCT022B018)
				.HasColumnName("PCT022B018")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022B018")
				.IsOptional();

			Property(p => p.PCT022B019)
				.HasColumnName("PCT022B019")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022B019")
				.IsOptional();

			Property(p => p.PCT022B020)
				.HasColumnName("PCT022B020")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022B020")
				.IsOptional();

			Property(p => p.PCT022B021)
				.HasColumnName("PCT022B021")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022B021")
				.IsOptional();

			Property(p => p.PCT022C001)
				.HasColumnName("PCT022C001")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022C001")
				.IsOptional();

			Property(p => p.PCT022C002)
				.HasColumnName("PCT022C002")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022C002")
				.IsOptional();

			Property(p => p.PCT022C003)
				.HasColumnName("PCT022C003")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022C003")
				.IsOptional();

			Property(p => p.PCT022C004)
				.HasColumnName("PCT022C004")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022C004")
				.IsOptional();

			Property(p => p.PCT022C005)
				.HasColumnName("PCT022C005")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022C005")
				.IsOptional();

			Property(p => p.PCT022C006)
				.HasColumnName("PCT022C006")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022C006")
				.IsOptional();

			Property(p => p.PCT022C007)
				.HasColumnName("PCT022C007")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022C007")
				.IsOptional();

			Property(p => p.PCT022C008)
				.HasColumnName("PCT022C008")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022C008")
				.IsOptional();

			Property(p => p.PCT022C009)
				.HasColumnName("PCT022C009")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022C009")
				.IsOptional();

			Property(p => p.PCT022C010)
				.HasColumnName("PCT022C010")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022C010")
				.IsOptional();

			Property(p => p.PCT022C011)
				.HasColumnName("PCT022C011")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022C011")
				.IsOptional();

			Property(p => p.PCT022C012)
				.HasColumnName("PCT022C012")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022C012")
				.IsOptional();

			Property(p => p.PCT022C013)
				.HasColumnName("PCT022C013")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022C013")
				.IsOptional();

			Property(p => p.PCT022C014)
				.HasColumnName("PCT022C014")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022C014")
				.IsOptional();

			Property(p => p.PCT022C015)
				.HasColumnName("PCT022C015")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022C015")
				.IsOptional();

			Property(p => p.PCT022C016)
				.HasColumnName("PCT022C016")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022C016")
				.IsOptional();

			Property(p => p.PCT022C017)
				.HasColumnName("PCT022C017")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022C017")
				.IsOptional();

			Property(p => p.PCT022C018)
				.HasColumnName("PCT022C018")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022C018")
				.IsOptional();

			Property(p => p.PCT022C019)
				.HasColumnName("PCT022C019")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022C019")
				.IsOptional();

			Property(p => p.PCT022C020)
				.HasColumnName("PCT022C020")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022C020")
				.IsOptional();

			Property(p => p.PCT022C021)
				.HasColumnName("PCT022C021")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022C021")
				.IsOptional();

			Property(p => p.PCT022D001)
				.HasColumnName("PCT022D001")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022D001")
				.IsOptional();

			Property(p => p.PCT022D002)
				.HasColumnName("PCT022D002")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022D002")
				.IsOptional();

			Property(p => p.PCT022D003)
				.HasColumnName("PCT022D003")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022D003")
				.IsOptional();

			Property(p => p.PCT022D004)
				.HasColumnName("PCT022D004")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022D004")
				.IsOptional();

			Property(p => p.PCT022D005)
				.HasColumnName("PCT022D005")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022D005")
				.IsOptional();

			Property(p => p.PCT022D006)
				.HasColumnName("PCT022D006")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022D006")
				.IsOptional();

			Property(p => p.PCT022D007)
				.HasColumnName("PCT022D007")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022D007")
				.IsOptional();

			Property(p => p.PCT022D008)
				.HasColumnName("PCT022D008")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022D008")
				.IsOptional();

			Property(p => p.PCT022D009)
				.HasColumnName("PCT022D009")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022D009")
				.IsOptional();

			Property(p => p.PCT022D010)
				.HasColumnName("PCT022D010")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022D010")
				.IsOptional();

			Property(p => p.PCT022D011)
				.HasColumnName("PCT022D011")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022D011")
				.IsOptional();

			Property(p => p.PCT022D012)
				.HasColumnName("PCT022D012")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022D012")
				.IsOptional();

			Property(p => p.PCT022D013)
				.HasColumnName("PCT022D013")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022D013")
				.IsOptional();

			Property(p => p.PCT022D014)
				.HasColumnName("PCT022D014")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022D014")
				.IsOptional();

			Property(p => p.PCT022D015)
				.HasColumnName("PCT022D015")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022D015")
				.IsOptional();

			Property(p => p.PCT022D016)
				.HasColumnName("PCT022D016")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022D016")
				.IsOptional();

			Property(p => p.PCT022D017)
				.HasColumnName("PCT022D017")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022D017")
				.IsOptional();

			Property(p => p.PCT022D018)
				.HasColumnName("PCT022D018")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022D018")
				.IsOptional();

			Property(p => p.PCT022D019)
				.HasColumnName("PCT022D019")
				.HasColumnOrder(214)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022D019")
				.IsOptional();

			Property(p => p.PCT022D020)
				.HasColumnName("PCT022D020")
				.HasColumnOrder(215)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022D020")
				.IsOptional();

			Property(p => p.PCT022D021)
				.HasColumnName("PCT022D021")
				.HasColumnOrder(216)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022D021")
				.IsOptional();

			Property(p => p.PCT022E001)
				.HasColumnName("PCT022E001")
				.HasColumnOrder(217)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022E001")
				.IsOptional();

			Property(p => p.PCT022E002)
				.HasColumnName("PCT022E002")
				.HasColumnOrder(218)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022E002")
				.IsOptional();

			Property(p => p.PCT022E003)
				.HasColumnName("PCT022E003")
				.HasColumnOrder(219)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022E003")
				.IsOptional();

			Property(p => p.PCT022E004)
				.HasColumnName("PCT022E004")
				.HasColumnOrder(220)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022E004")
				.IsOptional();

			Property(p => p.PCT022E005)
				.HasColumnName("PCT022E005")
				.HasColumnOrder(221)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022E005")
				.IsOptional();

			Property(p => p.PCT022E006)
				.HasColumnName("PCT022E006")
				.HasColumnOrder(222)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022E006")
				.IsOptional();

			Property(p => p.PCT022E007)
				.HasColumnName("PCT022E007")
				.HasColumnOrder(223)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022E007")
				.IsOptional();

			Property(p => p.PCT022E008)
				.HasColumnName("PCT022E008")
				.HasColumnOrder(224)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022E008")
				.IsOptional();

			Property(p => p.PCT022E009)
				.HasColumnName("PCT022E009")
				.HasColumnOrder(225)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022E009")
				.IsOptional();

			Property(p => p.PCT022E010)
				.HasColumnName("PCT022E010")
				.HasColumnOrder(226)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022E010")
				.IsOptional();

			Property(p => p.PCT022E011)
				.HasColumnName("PCT022E011")
				.HasColumnOrder(227)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022E011")
				.IsOptional();

			Property(p => p.PCT022E012)
				.HasColumnName("PCT022E012")
				.HasColumnOrder(228)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022E012")
				.IsOptional();

			Property(p => p.PCT022E013)
				.HasColumnName("PCT022E013")
				.HasColumnOrder(229)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022E013")
				.IsOptional();

			Property(p => p.PCT022E014)
				.HasColumnName("PCT022E014")
				.HasColumnOrder(230)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022E014")
				.IsOptional();

			Property(p => p.PCT022E015)
				.HasColumnName("PCT022E015")
				.HasColumnOrder(231)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022E015")
				.IsOptional();

			Property(p => p.PCT022E016)
				.HasColumnName("PCT022E016")
				.HasColumnOrder(232)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022E016")
				.IsOptional();

			Property(p => p.PCT022E017)
				.HasColumnName("PCT022E017")
				.HasColumnOrder(233)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022E017")
				.IsOptional();

			Property(p => p.PCT022E018)
				.HasColumnName("PCT022E018")
				.HasColumnOrder(234)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022E018")
				.IsOptional();

			Property(p => p.PCT022E019)
				.HasColumnName("PCT022E019")
				.HasColumnOrder(235)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022E019")
				.IsOptional();

			Property(p => p.PCT022E020)
				.HasColumnName("PCT022E020")
				.HasColumnOrder(236)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022E020")
				.IsOptional();

			Property(p => p.PCT022E021)
				.HasColumnName("PCT022E021")
				.HasColumnOrder(237)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022E021")
				.IsOptional();

			Property(p => p.PCT022F001)
				.HasColumnName("PCT022F001")
				.HasColumnOrder(238)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022F001")
				.IsOptional();

			Property(p => p.PCT022F002)
				.HasColumnName("PCT022F002")
				.HasColumnOrder(239)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022F002")
				.IsOptional();

			Property(p => p.PCT022F003)
				.HasColumnName("PCT022F003")
				.HasColumnOrder(240)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022F003")
				.IsOptional();

			Property(p => p.PCT022F004)
				.HasColumnName("PCT022F004")
				.HasColumnOrder(241)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022F004")
				.IsOptional();

			Property(p => p.PCT022F005)
				.HasColumnName("PCT022F005")
				.HasColumnOrder(242)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022F005")
				.IsOptional();

			Property(p => p.PCT022F006)
				.HasColumnName("PCT022F006")
				.HasColumnOrder(243)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022F006")
				.IsOptional();

			Property(p => p.PCT022F007)
				.HasColumnName("PCT022F007")
				.HasColumnOrder(244)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022F007")
				.IsOptional();

			Property(p => p.PCT022F008)
				.HasColumnName("PCT022F008")
				.HasColumnOrder(245)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022F008")
				.IsOptional();

			Property(p => p.PCT022F009)
				.HasColumnName("PCT022F009")
				.HasColumnOrder(246)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022F009")
				.IsOptional();

			Property(p => p.PCT022F010)
				.HasColumnName("PCT022F010")
				.HasColumnOrder(247)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022F010")
				.IsOptional();

			Property(p => p.PCT022F011)
				.HasColumnName("PCT022F011")
				.HasColumnOrder(248)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022F011")
				.IsOptional();

			Property(p => p.PCT022F012)
				.HasColumnName("PCT022F012")
				.HasColumnOrder(249)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022F012")
				.IsOptional();

			Property(p => p.PCT022F013)
				.HasColumnName("PCT022F013")
				.HasColumnOrder(250)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022F013")
				.IsOptional();

			Property(p => p.PCT022F014)
				.HasColumnName("PCT022F014")
				.HasColumnOrder(251)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022F014")
				.IsOptional();

			Property(p => p.PCT022F015)
				.HasColumnName("PCT022F015")
				.HasColumnOrder(252)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022F015")
				.IsOptional();

			Property(p => p.PCT022F016)
				.HasColumnName("PCT022F016")
				.HasColumnOrder(253)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022F016")
				.IsOptional();

			Property(p => p.PCT022F017)
				.HasColumnName("PCT022F017")
				.HasColumnOrder(254)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022F017")
				.IsOptional();

			Property(p => p.PCT022F018)
				.HasColumnName("PCT022F018")
				.HasColumnOrder(255)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022F018")
				.IsOptional();

			Property(p => p.PCT022F019)
				.HasColumnName("PCT022F019")
				.HasColumnOrder(256)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022F019")
				.IsOptional();

			Property(p => p.PCT022F020)
				.HasColumnName("PCT022F020")
				.HasColumnOrder(257)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022F020")
				.IsOptional();

			Property(p => p.PCT022F021)
				.HasColumnName("PCT022F021")
				.HasColumnOrder(258)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022F021")
				.IsOptional();
		}
	}
}
