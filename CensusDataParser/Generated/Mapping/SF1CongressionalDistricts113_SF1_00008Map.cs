namespace CensusDataParser.Generated.Mapping
{
	#region Using Directives
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.ModelConfiguration;
	using Binding;
	#endregion Using Directives

	public class SF1CongressionalDistricts113_SF1_00008Map : EntityTypeConfiguration<SF1CongressionalDistricts113_SF1_00008>
	{
		public SF1CongressionalDistricts113_SF1_00008Map()
		{
			ToTable("SF1_00008", "SF1CongressionalDistricts113");

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

			Property(p => p.P012F001)
				.HasColumnName("P012F001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F001")
				.IsOptional();

			Property(p => p.P012F002)
				.HasColumnName("P012F002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F002")
				.IsOptional();

			Property(p => p.P012F003)
				.HasColumnName("P012F003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F003")
				.IsOptional();

			Property(p => p.P012F004)
				.HasColumnName("P012F004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F004")
				.IsOptional();

			Property(p => p.P012F005)
				.HasColumnName("P012F005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F005")
				.IsOptional();

			Property(p => p.P012F006)
				.HasColumnName("P012F006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F006")
				.IsOptional();

			Property(p => p.P012F007)
				.HasColumnName("P012F007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F007")
				.IsOptional();

			Property(p => p.P012F008)
				.HasColumnName("P012F008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F008")
				.IsOptional();

			Property(p => p.P012F009)
				.HasColumnName("P012F009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F009")
				.IsOptional();

			Property(p => p.P012F010)
				.HasColumnName("P012F010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F010")
				.IsOptional();

			Property(p => p.P012F011)
				.HasColumnName("P012F011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F011")
				.IsOptional();

			Property(p => p.P012F012)
				.HasColumnName("P012F012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F012")
				.IsOptional();

			Property(p => p.P012F013)
				.HasColumnName("P012F013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F013")
				.IsOptional();

			Property(p => p.P012F014)
				.HasColumnName("P012F014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F014")
				.IsOptional();

			Property(p => p.P012F015)
				.HasColumnName("P012F015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F015")
				.IsOptional();

			Property(p => p.P012F016)
				.HasColumnName("P012F016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F016")
				.IsOptional();

			Property(p => p.P012F017)
				.HasColumnName("P012F017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F017")
				.IsOptional();

			Property(p => p.P012F018)
				.HasColumnName("P012F018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F018")
				.IsOptional();

			Property(p => p.P012F019)
				.HasColumnName("P012F019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F019")
				.IsOptional();

			Property(p => p.P012F020)
				.HasColumnName("P012F020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F020")
				.IsOptional();

			Property(p => p.P012F021)
				.HasColumnName("P012F021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F021")
				.IsOptional();

			Property(p => p.P012F022)
				.HasColumnName("P012F022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F022")
				.IsOptional();

			Property(p => p.P012F023)
				.HasColumnName("P012F023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F023")
				.IsOptional();

			Property(p => p.P012F024)
				.HasColumnName("P012F024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F024")
				.IsOptional();

			Property(p => p.P012F025)
				.HasColumnName("P012F025")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F025")
				.IsOptional();

			Property(p => p.P012F026)
				.HasColumnName("P012F026")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F026")
				.IsOptional();

			Property(p => p.P012F027)
				.HasColumnName("P012F027")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F027")
				.IsOptional();

			Property(p => p.P012F028)
				.HasColumnName("P012F028")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F028")
				.IsOptional();

			Property(p => p.P012F029)
				.HasColumnName("P012F029")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F029")
				.IsOptional();

			Property(p => p.P012F030)
				.HasColumnName("P012F030")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F030")
				.IsOptional();

			Property(p => p.P012F031)
				.HasColumnName("P012F031")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F031")
				.IsOptional();

			Property(p => p.P012F032)
				.HasColumnName("P012F032")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F032")
				.IsOptional();

			Property(p => p.P012F033)
				.HasColumnName("P012F033")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F033")
				.IsOptional();

			Property(p => p.P012F034)
				.HasColumnName("P012F034")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F034")
				.IsOptional();

			Property(p => p.P012F035)
				.HasColumnName("P012F035")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F035")
				.IsOptional();

			Property(p => p.P012F036)
				.HasColumnName("P012F036")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F036")
				.IsOptional();

			Property(p => p.P012F037)
				.HasColumnName("P012F037")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F037")
				.IsOptional();

			Property(p => p.P012F038)
				.HasColumnName("P012F038")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F038")
				.IsOptional();

			Property(p => p.P012F039)
				.HasColumnName("P012F039")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F039")
				.IsOptional();

			Property(p => p.P012F040)
				.HasColumnName("P012F040")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F040")
				.IsOptional();

			Property(p => p.P012F041)
				.HasColumnName("P012F041")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F041")
				.IsOptional();

			Property(p => p.P012F042)
				.HasColumnName("P012F042")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F042")
				.IsOptional();

			Property(p => p.P012F043)
				.HasColumnName("P012F043")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F043")
				.IsOptional();

			Property(p => p.P012F044)
				.HasColumnName("P012F044")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F044")
				.IsOptional();

			Property(p => p.P012F045)
				.HasColumnName("P012F045")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F045")
				.IsOptional();

			Property(p => p.P012F046)
				.HasColumnName("P012F046")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F046")
				.IsOptional();

			Property(p => p.P012F047)
				.HasColumnName("P012F047")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F047")
				.IsOptional();

			Property(p => p.P012F048)
				.HasColumnName("P012F048")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F048")
				.IsOptional();

			Property(p => p.P012F049)
				.HasColumnName("P012F049")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012F049")
				.IsOptional();

			Property(p => p.P012G001)
				.HasColumnName("P012G001")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G001")
				.IsOptional();

			Property(p => p.P012G002)
				.HasColumnName("P012G002")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G002")
				.IsOptional();

			Property(p => p.P012G003)
				.HasColumnName("P012G003")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G003")
				.IsOptional();

			Property(p => p.P012G004)
				.HasColumnName("P012G004")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G004")
				.IsOptional();

			Property(p => p.P012G005)
				.HasColumnName("P012G005")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G005")
				.IsOptional();

			Property(p => p.P012G006)
				.HasColumnName("P012G006")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G006")
				.IsOptional();

			Property(p => p.P012G007)
				.HasColumnName("P012G007")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G007")
				.IsOptional();

			Property(p => p.P012G008)
				.HasColumnName("P012G008")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G008")
				.IsOptional();

			Property(p => p.P012G009)
				.HasColumnName("P012G009")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G009")
				.IsOptional();

			Property(p => p.P012G010)
				.HasColumnName("P012G010")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G010")
				.IsOptional();

			Property(p => p.P012G011)
				.HasColumnName("P012G011")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G011")
				.IsOptional();

			Property(p => p.P012G012)
				.HasColumnName("P012G012")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G012")
				.IsOptional();

			Property(p => p.P012G013)
				.HasColumnName("P012G013")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G013")
				.IsOptional();

			Property(p => p.P012G014)
				.HasColumnName("P012G014")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G014")
				.IsOptional();

			Property(p => p.P012G015)
				.HasColumnName("P012G015")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G015")
				.IsOptional();

			Property(p => p.P012G016)
				.HasColumnName("P012G016")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G016")
				.IsOptional();

			Property(p => p.P012G017)
				.HasColumnName("P012G017")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G017")
				.IsOptional();

			Property(p => p.P012G018)
				.HasColumnName("P012G018")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G018")
				.IsOptional();

			Property(p => p.P012G019)
				.HasColumnName("P012G019")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G019")
				.IsOptional();

			Property(p => p.P012G020)
				.HasColumnName("P012G020")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G020")
				.IsOptional();

			Property(p => p.P012G021)
				.HasColumnName("P012G021")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G021")
				.IsOptional();

			Property(p => p.P012G022)
				.HasColumnName("P012G022")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G022")
				.IsOptional();

			Property(p => p.P012G023)
				.HasColumnName("P012G023")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G023")
				.IsOptional();

			Property(p => p.P012G024)
				.HasColumnName("P012G024")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G024")
				.IsOptional();

			Property(p => p.P012G025)
				.HasColumnName("P012G025")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G025")
				.IsOptional();

			Property(p => p.P012G026)
				.HasColumnName("P012G026")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G026")
				.IsOptional();

			Property(p => p.P012G027)
				.HasColumnName("P012G027")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G027")
				.IsOptional();

			Property(p => p.P012G028)
				.HasColumnName("P012G028")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G028")
				.IsOptional();

			Property(p => p.P012G029)
				.HasColumnName("P012G029")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G029")
				.IsOptional();

			Property(p => p.P012G030)
				.HasColumnName("P012G030")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G030")
				.IsOptional();

			Property(p => p.P012G031)
				.HasColumnName("P012G031")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G031")
				.IsOptional();

			Property(p => p.P012G032)
				.HasColumnName("P012G032")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G032")
				.IsOptional();

			Property(p => p.P012G033)
				.HasColumnName("P012G033")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G033")
				.IsOptional();

			Property(p => p.P012G034)
				.HasColumnName("P012G034")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G034")
				.IsOptional();

			Property(p => p.P012G035)
				.HasColumnName("P012G035")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G035")
				.IsOptional();

			Property(p => p.P012G036)
				.HasColumnName("P012G036")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G036")
				.IsOptional();

			Property(p => p.P012G037)
				.HasColumnName("P012G037")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G037")
				.IsOptional();

			Property(p => p.P012G038)
				.HasColumnName("P012G038")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G038")
				.IsOptional();

			Property(p => p.P012G039)
				.HasColumnName("P012G039")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G039")
				.IsOptional();

			Property(p => p.P012G040)
				.HasColumnName("P012G040")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G040")
				.IsOptional();

			Property(p => p.P012G041)
				.HasColumnName("P012G041")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G041")
				.IsOptional();

			Property(p => p.P012G042)
				.HasColumnName("P012G042")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G042")
				.IsOptional();

			Property(p => p.P012G043)
				.HasColumnName("P012G043")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G043")
				.IsOptional();

			Property(p => p.P012G044)
				.HasColumnName("P012G044")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G044")
				.IsOptional();

			Property(p => p.P012G045)
				.HasColumnName("P012G045")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G045")
				.IsOptional();

			Property(p => p.P012G046)
				.HasColumnName("P012G046")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G046")
				.IsOptional();

			Property(p => p.P012G047)
				.HasColumnName("P012G047")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G047")
				.IsOptional();

			Property(p => p.P012G048)
				.HasColumnName("P012G048")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G048")
				.IsOptional();

			Property(p => p.P012G049)
				.HasColumnName("P012G049")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012G049")
				.IsOptional();

			Property(p => p.P012H001)
				.HasColumnName("P012H001")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H001")
				.IsOptional();

			Property(p => p.P012H002)
				.HasColumnName("P012H002")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H002")
				.IsOptional();

			Property(p => p.P012H003)
				.HasColumnName("P012H003")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H003")
				.IsOptional();

			Property(p => p.P012H004)
				.HasColumnName("P012H004")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H004")
				.IsOptional();

			Property(p => p.P012H005)
				.HasColumnName("P012H005")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H005")
				.IsOptional();

			Property(p => p.P012H006)
				.HasColumnName("P012H006")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H006")
				.IsOptional();

			Property(p => p.P012H007)
				.HasColumnName("P012H007")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H007")
				.IsOptional();

			Property(p => p.P012H008)
				.HasColumnName("P012H008")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H008")
				.IsOptional();

			Property(p => p.P012H009)
				.HasColumnName("P012H009")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H009")
				.IsOptional();

			Property(p => p.P012H010)
				.HasColumnName("P012H010")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H010")
				.IsOptional();

			Property(p => p.P012H011)
				.HasColumnName("P012H011")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H011")
				.IsOptional();

			Property(p => p.P012H012)
				.HasColumnName("P012H012")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H012")
				.IsOptional();

			Property(p => p.P012H013)
				.HasColumnName("P012H013")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H013")
				.IsOptional();

			Property(p => p.P012H014)
				.HasColumnName("P012H014")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H014")
				.IsOptional();

			Property(p => p.P012H015)
				.HasColumnName("P012H015")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H015")
				.IsOptional();

			Property(p => p.P012H016)
				.HasColumnName("P012H016")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H016")
				.IsOptional();

			Property(p => p.P012H017)
				.HasColumnName("P012H017")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H017")
				.IsOptional();

			Property(p => p.P012H018)
				.HasColumnName("P012H018")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H018")
				.IsOptional();

			Property(p => p.P012H019)
				.HasColumnName("P012H019")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H019")
				.IsOptional();

			Property(p => p.P012H020)
				.HasColumnName("P012H020")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H020")
				.IsOptional();

			Property(p => p.P012H021)
				.HasColumnName("P012H021")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H021")
				.IsOptional();

			Property(p => p.P012H022)
				.HasColumnName("P012H022")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H022")
				.IsOptional();

			Property(p => p.P012H023)
				.HasColumnName("P012H023")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H023")
				.IsOptional();

			Property(p => p.P012H024)
				.HasColumnName("P012H024")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H024")
				.IsOptional();

			Property(p => p.P012H025)
				.HasColumnName("P012H025")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H025")
				.IsOptional();

			Property(p => p.P012H026)
				.HasColumnName("P012H026")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H026")
				.IsOptional();

			Property(p => p.P012H027)
				.HasColumnName("P012H027")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H027")
				.IsOptional();

			Property(p => p.P012H028)
				.HasColumnName("P012H028")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H028")
				.IsOptional();

			Property(p => p.P012H029)
				.HasColumnName("P012H029")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H029")
				.IsOptional();

			Property(p => p.P012H030)
				.HasColumnName("P012H030")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H030")
				.IsOptional();

			Property(p => p.P012H031)
				.HasColumnName("P012H031")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H031")
				.IsOptional();

			Property(p => p.P012H032)
				.HasColumnName("P012H032")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H032")
				.IsOptional();

			Property(p => p.P012H033)
				.HasColumnName("P012H033")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H033")
				.IsOptional();

			Property(p => p.P012H034)
				.HasColumnName("P012H034")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H034")
				.IsOptional();

			Property(p => p.P012H035)
				.HasColumnName("P012H035")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H035")
				.IsOptional();

			Property(p => p.P012H036)
				.HasColumnName("P012H036")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H036")
				.IsOptional();

			Property(p => p.P012H037)
				.HasColumnName("P012H037")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H037")
				.IsOptional();

			Property(p => p.P012H038)
				.HasColumnName("P012H038")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H038")
				.IsOptional();

			Property(p => p.P012H039)
				.HasColumnName("P012H039")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H039")
				.IsOptional();

			Property(p => p.P012H040)
				.HasColumnName("P012H040")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H040")
				.IsOptional();

			Property(p => p.P012H041)
				.HasColumnName("P012H041")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H041")
				.IsOptional();

			Property(p => p.P012H042)
				.HasColumnName("P012H042")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H042")
				.IsOptional();

			Property(p => p.P012H043)
				.HasColumnName("P012H043")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H043")
				.IsOptional();

			Property(p => p.P012H044)
				.HasColumnName("P012H044")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H044")
				.IsOptional();

			Property(p => p.P012H045)
				.HasColumnName("P012H045")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H045")
				.IsOptional();

			Property(p => p.P012H046)
				.HasColumnName("P012H046")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H046")
				.IsOptional();

			Property(p => p.P012H047)
				.HasColumnName("P012H047")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H047")
				.IsOptional();

			Property(p => p.P012H048)
				.HasColumnName("P012H048")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H048")
				.IsOptional();

			Property(p => p.P012H049)
				.HasColumnName("P012H049")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012H049")
				.IsOptional();

			Property(p => p.P012I001)
				.HasColumnName("P012I001")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I001")
				.IsOptional();

			Property(p => p.P012I002)
				.HasColumnName("P012I002")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I002")
				.IsOptional();

			Property(p => p.P012I003)
				.HasColumnName("P012I003")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I003")
				.IsOptional();

			Property(p => p.P012I004)
				.HasColumnName("P012I004")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I004")
				.IsOptional();

			Property(p => p.P012I005)
				.HasColumnName("P012I005")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I005")
				.IsOptional();

			Property(p => p.P012I006)
				.HasColumnName("P012I006")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I006")
				.IsOptional();

			Property(p => p.P012I007)
				.HasColumnName("P012I007")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I007")
				.IsOptional();

			Property(p => p.P012I008)
				.HasColumnName("P012I008")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I008")
				.IsOptional();

			Property(p => p.P012I009)
				.HasColumnName("P012I009")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I009")
				.IsOptional();

			Property(p => p.P012I010)
				.HasColumnName("P012I010")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I010")
				.IsOptional();

			Property(p => p.P012I011)
				.HasColumnName("P012I011")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I011")
				.IsOptional();

			Property(p => p.P012I012)
				.HasColumnName("P012I012")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I012")
				.IsOptional();

			Property(p => p.P012I013)
				.HasColumnName("P012I013")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I013")
				.IsOptional();

			Property(p => p.P012I014)
				.HasColumnName("P012I014")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I014")
				.IsOptional();

			Property(p => p.P012I015)
				.HasColumnName("P012I015")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I015")
				.IsOptional();

			Property(p => p.P012I016)
				.HasColumnName("P012I016")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I016")
				.IsOptional();

			Property(p => p.P012I017)
				.HasColumnName("P012I017")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I017")
				.IsOptional();

			Property(p => p.P012I018)
				.HasColumnName("P012I018")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I018")
				.IsOptional();

			Property(p => p.P012I019)
				.HasColumnName("P012I019")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I019")
				.IsOptional();

			Property(p => p.P012I020)
				.HasColumnName("P012I020")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I020")
				.IsOptional();

			Property(p => p.P012I021)
				.HasColumnName("P012I021")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I021")
				.IsOptional();

			Property(p => p.P012I022)
				.HasColumnName("P012I022")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I022")
				.IsOptional();

			Property(p => p.P012I023)
				.HasColumnName("P012I023")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I023")
				.IsOptional();

			Property(p => p.P012I024)
				.HasColumnName("P012I024")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I024")
				.IsOptional();

			Property(p => p.P012I025)
				.HasColumnName("P012I025")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I025")
				.IsOptional();

			Property(p => p.P012I026)
				.HasColumnName("P012I026")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I026")
				.IsOptional();

			Property(p => p.P012I027)
				.HasColumnName("P012I027")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I027")
				.IsOptional();

			Property(p => p.P012I028)
				.HasColumnName("P012I028")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I028")
				.IsOptional();

			Property(p => p.P012I029)
				.HasColumnName("P012I029")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I029")
				.IsOptional();

			Property(p => p.P012I030)
				.HasColumnName("P012I030")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I030")
				.IsOptional();

			Property(p => p.P012I031)
				.HasColumnName("P012I031")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I031")
				.IsOptional();

			Property(p => p.P012I032)
				.HasColumnName("P012I032")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I032")
				.IsOptional();

			Property(p => p.P012I033)
				.HasColumnName("P012I033")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I033")
				.IsOptional();

			Property(p => p.P012I034)
				.HasColumnName("P012I034")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I034")
				.IsOptional();

			Property(p => p.P012I035)
				.HasColumnName("P012I035")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I035")
				.IsOptional();

			Property(p => p.P012I036)
				.HasColumnName("P012I036")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I036")
				.IsOptional();

			Property(p => p.P012I037)
				.HasColumnName("P012I037")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I037")
				.IsOptional();

			Property(p => p.P012I038)
				.HasColumnName("P012I038")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I038")
				.IsOptional();

			Property(p => p.P012I039)
				.HasColumnName("P012I039")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I039")
				.IsOptional();

			Property(p => p.P012I040)
				.HasColumnName("P012I040")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I040")
				.IsOptional();

			Property(p => p.P012I041)
				.HasColumnName("P012I041")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I041")
				.IsOptional();

			Property(p => p.P012I042)
				.HasColumnName("P012I042")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I042")
				.IsOptional();

			Property(p => p.P012I043)
				.HasColumnName("P012I043")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I043")
				.IsOptional();

			Property(p => p.P012I044)
				.HasColumnName("P012I044")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I044")
				.IsOptional();

			Property(p => p.P012I045)
				.HasColumnName("P012I045")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I045")
				.IsOptional();

			Property(p => p.P012I046)
				.HasColumnName("P012I046")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I046")
				.IsOptional();

			Property(p => p.P012I047)
				.HasColumnName("P012I047")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I047")
				.IsOptional();

			Property(p => p.P012I048)
				.HasColumnName("P012I048")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I048")
				.IsOptional();

			Property(p => p.P012I049)
				.HasColumnName("P012I049")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P012I049")
				.IsOptional();

			Property(p => p.P013A001)
				.HasColumnName("P013A001")
				.HasColumnOrder(201)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013A001")
				.IsOptional();

			Property(p => p.P013A002)
				.HasColumnName("P013A002")
				.HasColumnOrder(202)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013A002")
				.IsOptional();

			Property(p => p.P013A003)
				.HasColumnName("P013A003")
				.HasColumnOrder(203)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013A003")
				.IsOptional();

			Property(p => p.P013B001)
				.HasColumnName("P013B001")
				.HasColumnOrder(204)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013B001")
				.IsOptional();

			Property(p => p.P013B002)
				.HasColumnName("P013B002")
				.HasColumnOrder(205)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013B002")
				.IsOptional();

			Property(p => p.P013B003)
				.HasColumnName("P013B003")
				.HasColumnOrder(206)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013B003")
				.IsOptional();

			Property(p => p.P013C001)
				.HasColumnName("P013C001")
				.HasColumnOrder(207)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013C001")
				.IsOptional();

			Property(p => p.P013C002)
				.HasColumnName("P013C002")
				.HasColumnOrder(208)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013C002")
				.IsOptional();

			Property(p => p.P013C003)
				.HasColumnName("P013C003")
				.HasColumnOrder(209)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013C003")
				.IsOptional();

			Property(p => p.P013D001)
				.HasColumnName("P013D001")
				.HasColumnOrder(210)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013D001")
				.IsOptional();

			Property(p => p.P013D002)
				.HasColumnName("P013D002")
				.HasColumnOrder(211)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013D002")
				.IsOptional();

			Property(p => p.P013D003)
				.HasColumnName("P013D003")
				.HasColumnOrder(212)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013D003")
				.IsOptional();

			Property(p => p.P013E001)
				.HasColumnName("P013E001")
				.HasColumnOrder(213)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013E001")
				.IsOptional();

			Property(p => p.P013E002)
				.HasColumnName("P013E002")
				.HasColumnOrder(214)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013E002")
				.IsOptional();

			Property(p => p.P013E003)
				.HasColumnName("P013E003")
				.HasColumnOrder(215)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013E003")
				.IsOptional();

			Property(p => p.P013F001)
				.HasColumnName("P013F001")
				.HasColumnOrder(216)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013F001")
				.IsOptional();

			Property(p => p.P013F002)
				.HasColumnName("P013F002")
				.HasColumnOrder(217)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013F002")
				.IsOptional();

			Property(p => p.P013F003)
				.HasColumnName("P013F003")
				.HasColumnOrder(218)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013F003")
				.IsOptional();

			Property(p => p.P013G001)
				.HasColumnName("P013G001")
				.HasColumnOrder(219)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013G001")
				.IsOptional();

			Property(p => p.P013G002)
				.HasColumnName("P013G002")
				.HasColumnOrder(220)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013G002")
				.IsOptional();

			Property(p => p.P013G003)
				.HasColumnName("P013G003")
				.HasColumnOrder(221)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013G003")
				.IsOptional();

			Property(p => p.P013H001)
				.HasColumnName("P013H001")
				.HasColumnOrder(222)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013H001")
				.IsOptional();

			Property(p => p.P013H002)
				.HasColumnName("P013H002")
				.HasColumnOrder(223)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013H002")
				.IsOptional();

			Property(p => p.P013H003)
				.HasColumnName("P013H003")
				.HasColumnOrder(224)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013H003")
				.IsOptional();

			Property(p => p.P013I001)
				.HasColumnName("P013I001")
				.HasColumnOrder(225)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013I001")
				.IsOptional();

			Property(p => p.P013I002)
				.HasColumnName("P013I002")
				.HasColumnOrder(226)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013I002")
				.IsOptional();

			Property(p => p.P013I003)
				.HasColumnName("P013I003")
				.HasColumnOrder(227)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P013I003")
				.IsOptional();

			Property(p => p.P016A001)
				.HasColumnName("P016A001")
				.HasColumnOrder(228)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016A001")
				.IsOptional();

			Property(p => p.P016A002)
				.HasColumnName("P016A002")
				.HasColumnOrder(229)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016A002")
				.IsOptional();

			Property(p => p.P016A003)
				.HasColumnName("P016A003")
				.HasColumnOrder(230)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016A003")
				.IsOptional();

			Property(p => p.P016B001)
				.HasColumnName("P016B001")
				.HasColumnOrder(231)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016B001")
				.IsOptional();

			Property(p => p.P016B002)
				.HasColumnName("P016B002")
				.HasColumnOrder(232)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016B002")
				.IsOptional();

			Property(p => p.P016B003)
				.HasColumnName("P016B003")
				.HasColumnOrder(233)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016B003")
				.IsOptional();

			Property(p => p.P016C001)
				.HasColumnName("P016C001")
				.HasColumnOrder(234)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016C001")
				.IsOptional();

			Property(p => p.P016C002)
				.HasColumnName("P016C002")
				.HasColumnOrder(235)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016C002")
				.IsOptional();

			Property(p => p.P016C003)
				.HasColumnName("P016C003")
				.HasColumnOrder(236)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016C003")
				.IsOptional();

			Property(p => p.P016D001)
				.HasColumnName("P016D001")
				.HasColumnOrder(237)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016D001")
				.IsOptional();

			Property(p => p.P016D002)
				.HasColumnName("P016D002")
				.HasColumnOrder(238)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016D002")
				.IsOptional();

			Property(p => p.P016D003)
				.HasColumnName("P016D003")
				.HasColumnOrder(239)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016D003")
				.IsOptional();

			Property(p => p.P016E001)
				.HasColumnName("P016E001")
				.HasColumnOrder(240)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016E001")
				.IsOptional();

			Property(p => p.P016E002)
				.HasColumnName("P016E002")
				.HasColumnOrder(241)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016E002")
				.IsOptional();

			Property(p => p.P016E003)
				.HasColumnName("P016E003")
				.HasColumnOrder(242)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016E003")
				.IsOptional();

			Property(p => p.P016F001)
				.HasColumnName("P016F001")
				.HasColumnOrder(243)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016F001")
				.IsOptional();

			Property(p => p.P016F002)
				.HasColumnName("P016F002")
				.HasColumnOrder(244)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016F002")
				.IsOptional();

			Property(p => p.P016F003)
				.HasColumnName("P016F003")
				.HasColumnOrder(245)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016F003")
				.IsOptional();

			Property(p => p.P016G001)
				.HasColumnName("P016G001")
				.HasColumnOrder(246)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016G001")
				.IsOptional();

			Property(p => p.P016G002)
				.HasColumnName("P016G002")
				.HasColumnOrder(247)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016G002")
				.IsOptional();

			Property(p => p.P016G003)
				.HasColumnName("P016G003")
				.HasColumnOrder(248)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016G003")
				.IsOptional();

			Property(p => p.P016H001)
				.HasColumnName("P016H001")
				.HasColumnOrder(249)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016H001")
				.IsOptional();

			Property(p => p.P016H002)
				.HasColumnName("P016H002")
				.HasColumnOrder(250)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016H002")
				.IsOptional();

			Property(p => p.P016H003)
				.HasColumnName("P016H003")
				.HasColumnOrder(251)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016H003")
				.IsOptional();

			Property(p => p.P016I001)
				.HasColumnName("P016I001")
				.HasColumnOrder(252)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016I001")
				.IsOptional();

			Property(p => p.P016I002)
				.HasColumnName("P016I002")
				.HasColumnOrder(253)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016I002")
				.IsOptional();

			Property(p => p.P016I003)
				.HasColumnName("P016I003")
				.HasColumnOrder(254)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P016I003")
				.IsOptional();

			Property(p => p.P017A001)
				.HasColumnName("P017A001")
				.HasColumnOrder(255)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017A001")
				.IsOptional();

			Property(p => p.P017A002)
				.HasColumnName("P017A002")
				.HasColumnOrder(256)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017A002")
				.IsOptional();

			Property(p => p.P017A003)
				.HasColumnName("P017A003")
				.HasColumnOrder(257)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("P017A003")
				.IsOptional();
		}
	}
}
