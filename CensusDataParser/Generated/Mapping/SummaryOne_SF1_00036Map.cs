namespace CensusDataParser.Generated.Mapping
{
	#region Using Directives
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.ModelConfiguration;
	using Binding;
	#endregion Using Directives

	public class SummaryOne_SF1_00036Map : EntityTypeConfiguration<SummaryOne_SF1_00036>
	{
		public SummaryOne_SF1_00036Map()
		{
			ToTable("SF1_00036", "SummaryOne");

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

			Property(p => p.PCT013F001)
				.HasColumnName("PCT013F001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F001")
				.IsOptional();

			Property(p => p.PCT013F002)
				.HasColumnName("PCT013F002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F002")
				.IsOptional();

			Property(p => p.PCT013F003)
				.HasColumnName("PCT013F003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F003")
				.IsOptional();

			Property(p => p.PCT013F004)
				.HasColumnName("PCT013F004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F004")
				.IsOptional();

			Property(p => p.PCT013F005)
				.HasColumnName("PCT013F005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F005")
				.IsOptional();

			Property(p => p.PCT013F006)
				.HasColumnName("PCT013F006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F006")
				.IsOptional();

			Property(p => p.PCT013F007)
				.HasColumnName("PCT013F007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F007")
				.IsOptional();

			Property(p => p.PCT013F008)
				.HasColumnName("PCT013F008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F008")
				.IsOptional();

			Property(p => p.PCT013F009)
				.HasColumnName("PCT013F009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F009")
				.IsOptional();

			Property(p => p.PCT013F010)
				.HasColumnName("PCT013F010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F010")
				.IsOptional();

			Property(p => p.PCT013F011)
				.HasColumnName("PCT013F011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F011")
				.IsOptional();

			Property(p => p.PCT013F012)
				.HasColumnName("PCT013F012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F012")
				.IsOptional();

			Property(p => p.PCT013F013)
				.HasColumnName("PCT013F013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F013")
				.IsOptional();

			Property(p => p.PCT013F014)
				.HasColumnName("PCT013F014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F014")
				.IsOptional();

			Property(p => p.PCT013F015)
				.HasColumnName("PCT013F015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F015")
				.IsOptional();

			Property(p => p.PCT013F016)
				.HasColumnName("PCT013F016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F016")
				.IsOptional();

			Property(p => p.PCT013F017)
				.HasColumnName("PCT013F017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F017")
				.IsOptional();

			Property(p => p.PCT013F018)
				.HasColumnName("PCT013F018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F018")
				.IsOptional();

			Property(p => p.PCT013F019)
				.HasColumnName("PCT013F019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F019")
				.IsOptional();

			Property(p => p.PCT013F020)
				.HasColumnName("PCT013F020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F020")
				.IsOptional();

			Property(p => p.PCT013F021)
				.HasColumnName("PCT013F021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F021")
				.IsOptional();

			Property(p => p.PCT013F022)
				.HasColumnName("PCT013F022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F022")
				.IsOptional();

			Property(p => p.PCT013F023)
				.HasColumnName("PCT013F023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F023")
				.IsOptional();

			Property(p => p.PCT013F024)
				.HasColumnName("PCT013F024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F024")
				.IsOptional();

			Property(p => p.PCT013F025)
				.HasColumnName("PCT013F025")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F025")
				.IsOptional();

			Property(p => p.PCT013F026)
				.HasColumnName("PCT013F026")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F026")
				.IsOptional();

			Property(p => p.PCT013F027)
				.HasColumnName("PCT013F027")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F027")
				.IsOptional();

			Property(p => p.PCT013F028)
				.HasColumnName("PCT013F028")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F028")
				.IsOptional();

			Property(p => p.PCT013F029)
				.HasColumnName("PCT013F029")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F029")
				.IsOptional();

			Property(p => p.PCT013F030)
				.HasColumnName("PCT013F030")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F030")
				.IsOptional();

			Property(p => p.PCT013F031)
				.HasColumnName("PCT013F031")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F031")
				.IsOptional();

			Property(p => p.PCT013F032)
				.HasColumnName("PCT013F032")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F032")
				.IsOptional();

			Property(p => p.PCT013F033)
				.HasColumnName("PCT013F033")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F033")
				.IsOptional();

			Property(p => p.PCT013F034)
				.HasColumnName("PCT013F034")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F034")
				.IsOptional();

			Property(p => p.PCT013F035)
				.HasColumnName("PCT013F035")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F035")
				.IsOptional();

			Property(p => p.PCT013F036)
				.HasColumnName("PCT013F036")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F036")
				.IsOptional();

			Property(p => p.PCT013F037)
				.HasColumnName("PCT013F037")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F037")
				.IsOptional();

			Property(p => p.PCT013F038)
				.HasColumnName("PCT013F038")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F038")
				.IsOptional();

			Property(p => p.PCT013F039)
				.HasColumnName("PCT013F039")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F039")
				.IsOptional();

			Property(p => p.PCT013F040)
				.HasColumnName("PCT013F040")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F040")
				.IsOptional();

			Property(p => p.PCT013F041)
				.HasColumnName("PCT013F041")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F041")
				.IsOptional();

			Property(p => p.PCT013F042)
				.HasColumnName("PCT013F042")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F042")
				.IsOptional();

			Property(p => p.PCT013F043)
				.HasColumnName("PCT013F043")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F043")
				.IsOptional();

			Property(p => p.PCT013F044)
				.HasColumnName("PCT013F044")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F044")
				.IsOptional();

			Property(p => p.PCT013F045)
				.HasColumnName("PCT013F045")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F045")
				.IsOptional();

			Property(p => p.PCT013F046)
				.HasColumnName("PCT013F046")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F046")
				.IsOptional();

			Property(p => p.PCT013F047)
				.HasColumnName("PCT013F047")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F047")
				.IsOptional();

			Property(p => p.PCT013F048)
				.HasColumnName("PCT013F048")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F048")
				.IsOptional();

			Property(p => p.PCT013F049)
				.HasColumnName("PCT013F049")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013F049")
				.IsOptional();

			Property(p => p.PCT013G001)
				.HasColumnName("PCT013G001")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G001")
				.IsOptional();

			Property(p => p.PCT013G002)
				.HasColumnName("PCT013G002")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G002")
				.IsOptional();

			Property(p => p.PCT013G003)
				.HasColumnName("PCT013G003")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G003")
				.IsOptional();

			Property(p => p.PCT013G004)
				.HasColumnName("PCT013G004")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G004")
				.IsOptional();

			Property(p => p.PCT013G005)
				.HasColumnName("PCT013G005")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G005")
				.IsOptional();

			Property(p => p.PCT013G006)
				.HasColumnName("PCT013G006")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G006")
				.IsOptional();

			Property(p => p.PCT013G007)
				.HasColumnName("PCT013G007")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G007")
				.IsOptional();

			Property(p => p.PCT013G008)
				.HasColumnName("PCT013G008")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G008")
				.IsOptional();

			Property(p => p.PCT013G009)
				.HasColumnName("PCT013G009")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G009")
				.IsOptional();

			Property(p => p.PCT013G010)
				.HasColumnName("PCT013G010")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G010")
				.IsOptional();

			Property(p => p.PCT013G011)
				.HasColumnName("PCT013G011")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G011")
				.IsOptional();

			Property(p => p.PCT013G012)
				.HasColumnName("PCT013G012")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G012")
				.IsOptional();

			Property(p => p.PCT013G013)
				.HasColumnName("PCT013G013")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G013")
				.IsOptional();

			Property(p => p.PCT013G014)
				.HasColumnName("PCT013G014")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G014")
				.IsOptional();

			Property(p => p.PCT013G015)
				.HasColumnName("PCT013G015")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G015")
				.IsOptional();

			Property(p => p.PCT013G016)
				.HasColumnName("PCT013G016")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G016")
				.IsOptional();

			Property(p => p.PCT013G017)
				.HasColumnName("PCT013G017")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G017")
				.IsOptional();

			Property(p => p.PCT013G018)
				.HasColumnName("PCT013G018")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G018")
				.IsOptional();

			Property(p => p.PCT013G019)
				.HasColumnName("PCT013G019")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G019")
				.IsOptional();

			Property(p => p.PCT013G020)
				.HasColumnName("PCT013G020")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G020")
				.IsOptional();

			Property(p => p.PCT013G021)
				.HasColumnName("PCT013G021")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G021")
				.IsOptional();

			Property(p => p.PCT013G022)
				.HasColumnName("PCT013G022")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G022")
				.IsOptional();

			Property(p => p.PCT013G023)
				.HasColumnName("PCT013G023")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G023")
				.IsOptional();

			Property(p => p.PCT013G024)
				.HasColumnName("PCT013G024")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G024")
				.IsOptional();

			Property(p => p.PCT013G025)
				.HasColumnName("PCT013G025")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G025")
				.IsOptional();

			Property(p => p.PCT013G026)
				.HasColumnName("PCT013G026")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G026")
				.IsOptional();

			Property(p => p.PCT013G027)
				.HasColumnName("PCT013G027")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G027")
				.IsOptional();

			Property(p => p.PCT013G028)
				.HasColumnName("PCT013G028")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G028")
				.IsOptional();

			Property(p => p.PCT013G029)
				.HasColumnName("PCT013G029")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G029")
				.IsOptional();

			Property(p => p.PCT013G030)
				.HasColumnName("PCT013G030")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G030")
				.IsOptional();

			Property(p => p.PCT013G031)
				.HasColumnName("PCT013G031")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G031")
				.IsOptional();

			Property(p => p.PCT013G032)
				.HasColumnName("PCT013G032")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G032")
				.IsOptional();

			Property(p => p.PCT013G033)
				.HasColumnName("PCT013G033")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G033")
				.IsOptional();

			Property(p => p.PCT013G034)
				.HasColumnName("PCT013G034")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G034")
				.IsOptional();

			Property(p => p.PCT013G035)
				.HasColumnName("PCT013G035")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G035")
				.IsOptional();

			Property(p => p.PCT013G036)
				.HasColumnName("PCT013G036")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G036")
				.IsOptional();

			Property(p => p.PCT013G037)
				.HasColumnName("PCT013G037")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G037")
				.IsOptional();

			Property(p => p.PCT013G038)
				.HasColumnName("PCT013G038")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G038")
				.IsOptional();

			Property(p => p.PCT013G039)
				.HasColumnName("PCT013G039")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G039")
				.IsOptional();

			Property(p => p.PCT013G040)
				.HasColumnName("PCT013G040")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G040")
				.IsOptional();

			Property(p => p.PCT013G041)
				.HasColumnName("PCT013G041")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G041")
				.IsOptional();

			Property(p => p.PCT013G042)
				.HasColumnName("PCT013G042")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G042")
				.IsOptional();

			Property(p => p.PCT013G043)
				.HasColumnName("PCT013G043")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G043")
				.IsOptional();

			Property(p => p.PCT013G044)
				.HasColumnName("PCT013G044")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G044")
				.IsOptional();

			Property(p => p.PCT013G045)
				.HasColumnName("PCT013G045")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G045")
				.IsOptional();

			Property(p => p.PCT013G046)
				.HasColumnName("PCT013G046")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G046")
				.IsOptional();

			Property(p => p.PCT013G047)
				.HasColumnName("PCT013G047")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G047")
				.IsOptional();

			Property(p => p.PCT013G048)
				.HasColumnName("PCT013G048")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G048")
				.IsOptional();

			Property(p => p.PCT013G049)
				.HasColumnName("PCT013G049")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013G049")
				.IsOptional();

			Property(p => p.PCT013H001)
				.HasColumnName("PCT013H001")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H001")
				.IsOptional();

			Property(p => p.PCT013H002)
				.HasColumnName("PCT013H002")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H002")
				.IsOptional();

			Property(p => p.PCT013H003)
				.HasColumnName("PCT013H003")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H003")
				.IsOptional();

			Property(p => p.PCT013H004)
				.HasColumnName("PCT013H004")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H004")
				.IsOptional();

			Property(p => p.PCT013H005)
				.HasColumnName("PCT013H005")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H005")
				.IsOptional();

			Property(p => p.PCT013H006)
				.HasColumnName("PCT013H006")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H006")
				.IsOptional();

			Property(p => p.PCT013H007)
				.HasColumnName("PCT013H007")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H007")
				.IsOptional();

			Property(p => p.PCT013H008)
				.HasColumnName("PCT013H008")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H008")
				.IsOptional();

			Property(p => p.PCT013H009)
				.HasColumnName("PCT013H009")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H009")
				.IsOptional();

			Property(p => p.PCT013H010)
				.HasColumnName("PCT013H010")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H010")
				.IsOptional();

			Property(p => p.PCT013H011)
				.HasColumnName("PCT013H011")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H011")
				.IsOptional();

			Property(p => p.PCT013H012)
				.HasColumnName("PCT013H012")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H012")
				.IsOptional();

			Property(p => p.PCT013H013)
				.HasColumnName("PCT013H013")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H013")
				.IsOptional();

			Property(p => p.PCT013H014)
				.HasColumnName("PCT013H014")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H014")
				.IsOptional();

			Property(p => p.PCT013H015)
				.HasColumnName("PCT013H015")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H015")
				.IsOptional();

			Property(p => p.PCT013H016)
				.HasColumnName("PCT013H016")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H016")
				.IsOptional();

			Property(p => p.PCT013H017)
				.HasColumnName("PCT013H017")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H017")
				.IsOptional();

			Property(p => p.PCT013H018)
				.HasColumnName("PCT013H018")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H018")
				.IsOptional();

			Property(p => p.PCT013H019)
				.HasColumnName("PCT013H019")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H019")
				.IsOptional();

			Property(p => p.PCT013H020)
				.HasColumnName("PCT013H020")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H020")
				.IsOptional();

			Property(p => p.PCT013H021)
				.HasColumnName("PCT013H021")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H021")
				.IsOptional();

			Property(p => p.PCT013H022)
				.HasColumnName("PCT013H022")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H022")
				.IsOptional();

			Property(p => p.PCT013H023)
				.HasColumnName("PCT013H023")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H023")
				.IsOptional();

			Property(p => p.PCT013H024)
				.HasColumnName("PCT013H024")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H024")
				.IsOptional();

			Property(p => p.PCT013H025)
				.HasColumnName("PCT013H025")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H025")
				.IsOptional();

			Property(p => p.PCT013H026)
				.HasColumnName("PCT013H026")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H026")
				.IsOptional();

			Property(p => p.PCT013H027)
				.HasColumnName("PCT013H027")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H027")
				.IsOptional();

			Property(p => p.PCT013H028)
				.HasColumnName("PCT013H028")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H028")
				.IsOptional();

			Property(p => p.PCT013H029)
				.HasColumnName("PCT013H029")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H029")
				.IsOptional();

			Property(p => p.PCT013H030)
				.HasColumnName("PCT013H030")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H030")
				.IsOptional();

			Property(p => p.PCT013H031)
				.HasColumnName("PCT013H031")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H031")
				.IsOptional();

			Property(p => p.PCT013H032)
				.HasColumnName("PCT013H032")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H032")
				.IsOptional();

			Property(p => p.PCT013H033)
				.HasColumnName("PCT013H033")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H033")
				.IsOptional();

			Property(p => p.PCT013H034)
				.HasColumnName("PCT013H034")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H034")
				.IsOptional();

			Property(p => p.PCT013H035)
				.HasColumnName("PCT013H035")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H035")
				.IsOptional();

			Property(p => p.PCT013H036)
				.HasColumnName("PCT013H036")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H036")
				.IsOptional();

			Property(p => p.PCT013H037)
				.HasColumnName("PCT013H037")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H037")
				.IsOptional();

			Property(p => p.PCT013H038)
				.HasColumnName("PCT013H038")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H038")
				.IsOptional();

			Property(p => p.PCT013H039)
				.HasColumnName("PCT013H039")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H039")
				.IsOptional();

			Property(p => p.PCT013H040)
				.HasColumnName("PCT013H040")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H040")
				.IsOptional();

			Property(p => p.PCT013H041)
				.HasColumnName("PCT013H041")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H041")
				.IsOptional();

			Property(p => p.PCT013H042)
				.HasColumnName("PCT013H042")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H042")
				.IsOptional();

			Property(p => p.PCT013H043)
				.HasColumnName("PCT013H043")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H043")
				.IsOptional();

			Property(p => p.PCT013H044)
				.HasColumnName("PCT013H044")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H044")
				.IsOptional();

			Property(p => p.PCT013H045)
				.HasColumnName("PCT013H045")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H045")
				.IsOptional();

			Property(p => p.PCT013H046)
				.HasColumnName("PCT013H046")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H046")
				.IsOptional();

			Property(p => p.PCT013H047)
				.HasColumnName("PCT013H047")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H047")
				.IsOptional();

			Property(p => p.PCT013H048)
				.HasColumnName("PCT013H048")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H048")
				.IsOptional();

			Property(p => p.PCT013H049)
				.HasColumnName("PCT013H049")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013H049")
				.IsOptional();

			Property(p => p.PCT013I001)
				.HasColumnName("PCT013I001")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I001")
				.IsOptional();

			Property(p => p.PCT013I002)
				.HasColumnName("PCT013I002")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I002")
				.IsOptional();

			Property(p => p.PCT013I003)
				.HasColumnName("PCT013I003")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I003")
				.IsOptional();

			Property(p => p.PCT013I004)
				.HasColumnName("PCT013I004")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I004")
				.IsOptional();

			Property(p => p.PCT013I005)
				.HasColumnName("PCT013I005")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I005")
				.IsOptional();

			Property(p => p.PCT013I006)
				.HasColumnName("PCT013I006")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I006")
				.IsOptional();

			Property(p => p.PCT013I007)
				.HasColumnName("PCT013I007")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I007")
				.IsOptional();

			Property(p => p.PCT013I008)
				.HasColumnName("PCT013I008")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I008")
				.IsOptional();

			Property(p => p.PCT013I009)
				.HasColumnName("PCT013I009")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I009")
				.IsOptional();

			Property(p => p.PCT013I010)
				.HasColumnName("PCT013I010")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I010")
				.IsOptional();

			Property(p => p.PCT013I011)
				.HasColumnName("PCT013I011")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I011")
				.IsOptional();

			Property(p => p.PCT013I012)
				.HasColumnName("PCT013I012")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I012")
				.IsOptional();

			Property(p => p.PCT013I013)
				.HasColumnName("PCT013I013")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I013")
				.IsOptional();

			Property(p => p.PCT013I014)
				.HasColumnName("PCT013I014")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I014")
				.IsOptional();

			Property(p => p.PCT013I015)
				.HasColumnName("PCT013I015")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I015")
				.IsOptional();

			Property(p => p.PCT013I016)
				.HasColumnName("PCT013I016")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I016")
				.IsOptional();

			Property(p => p.PCT013I017)
				.HasColumnName("PCT013I017")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I017")
				.IsOptional();

			Property(p => p.PCT013I018)
				.HasColumnName("PCT013I018")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I018")
				.IsOptional();

			Property(p => p.PCT013I019)
				.HasColumnName("PCT013I019")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I019")
				.IsOptional();

			Property(p => p.PCT013I020)
				.HasColumnName("PCT013I020")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I020")
				.IsOptional();

			Property(p => p.PCT013I021)
				.HasColumnName("PCT013I021")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I021")
				.IsOptional();

			Property(p => p.PCT013I022)
				.HasColumnName("PCT013I022")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I022")
				.IsOptional();

			Property(p => p.PCT013I023)
				.HasColumnName("PCT013I023")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I023")
				.IsOptional();

			Property(p => p.PCT013I024)
				.HasColumnName("PCT013I024")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I024")
				.IsOptional();

			Property(p => p.PCT013I025)
				.HasColumnName("PCT013I025")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I025")
				.IsOptional();

			Property(p => p.PCT013I026)
				.HasColumnName("PCT013I026")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I026")
				.IsOptional();

			Property(p => p.PCT013I027)
				.HasColumnName("PCT013I027")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I027")
				.IsOptional();

			Property(p => p.PCT013I028)
				.HasColumnName("PCT013I028")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I028")
				.IsOptional();

			Property(p => p.PCT013I029)
				.HasColumnName("PCT013I029")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I029")
				.IsOptional();

			Property(p => p.PCT013I030)
				.HasColumnName("PCT013I030")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I030")
				.IsOptional();

			Property(p => p.PCT013I031)
				.HasColumnName("PCT013I031")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I031")
				.IsOptional();

			Property(p => p.PCT013I032)
				.HasColumnName("PCT013I032")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I032")
				.IsOptional();

			Property(p => p.PCT013I033)
				.HasColumnName("PCT013I033")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I033")
				.IsOptional();

			Property(p => p.PCT013I034)
				.HasColumnName("PCT013I034")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I034")
				.IsOptional();

			Property(p => p.PCT013I035)
				.HasColumnName("PCT013I035")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I035")
				.IsOptional();

			Property(p => p.PCT013I036)
				.HasColumnName("PCT013I036")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I036")
				.IsOptional();

			Property(p => p.PCT013I037)
				.HasColumnName("PCT013I037")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I037")
				.IsOptional();

			Property(p => p.PCT013I038)
				.HasColumnName("PCT013I038")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I038")
				.IsOptional();

			Property(p => p.PCT013I039)
				.HasColumnName("PCT013I039")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I039")
				.IsOptional();

			Property(p => p.PCT013I040)
				.HasColumnName("PCT013I040")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I040")
				.IsOptional();

			Property(p => p.PCT013I041)
				.HasColumnName("PCT013I041")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I041")
				.IsOptional();

			Property(p => p.PCT013I042)
				.HasColumnName("PCT013I042")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I042")
				.IsOptional();

			Property(p => p.PCT013I043)
				.HasColumnName("PCT013I043")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I043")
				.IsOptional();

			Property(p => p.PCT013I044)
				.HasColumnName("PCT013I044")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I044")
				.IsOptional();

			Property(p => p.PCT013I045)
				.HasColumnName("PCT013I045")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I045")
				.IsOptional();

			Property(p => p.PCT013I046)
				.HasColumnName("PCT013I046")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I046")
				.IsOptional();

			Property(p => p.PCT013I047)
				.HasColumnName("PCT013I047")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I047")
				.IsOptional();

			Property(p => p.PCT013I048)
				.HasColumnName("PCT013I048")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I048")
				.IsOptional();

			Property(p => p.PCT013I049)
				.HasColumnName("PCT013I049")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT013I049")
				.IsOptional();

			Property(p => p.PCT014A001)
				.HasColumnName("PCT014A001")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014A001")
				.IsOptional();

			Property(p => p.PCT014A002)
				.HasColumnName("PCT014A002")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014A002")
				.IsOptional();

			Property(p => p.PCT014A003)
				.HasColumnName("PCT014A003")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014A003")
				.IsOptional();

			Property(p => p.PCT014B001)
				.HasColumnName("PCT014B001")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014B001")
				.IsOptional();

			Property(p => p.PCT014B002)
				.HasColumnName("PCT014B002")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014B002")
				.IsOptional();

			Property(p => p.PCT014B003)
				.HasColumnName("PCT014B003")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014B003")
				.IsOptional();

			Property(p => p.PCT014C001)
				.HasColumnName("PCT014C001")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014C001")
				.IsOptional();

			Property(p => p.PCT014C002)
				.HasColumnName("PCT014C002")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014C002")
				.IsOptional();

			Property(p => p.PCT014C003)
				.HasColumnName("PCT014C003")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014C003")
				.IsOptional();

			Property(p => p.PCT014D001)
				.HasColumnName("PCT014D001")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014D001")
				.IsOptional();

			Property(p => p.PCT014D002)
				.HasColumnName("PCT014D002")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014D002")
				.IsOptional();

			Property(p => p.PCT014D003)
				.HasColumnName("PCT014D003")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014D003")
				.IsOptional();

			Property(p => p.PCT014E001)
				.HasColumnName("PCT014E001")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014E001")
				.IsOptional();

			Property(p => p.PCT014E002)
				.HasColumnName("PCT014E002")
				.HasColumnOrder(214)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014E002")
				.IsOptional();

			Property(p => p.PCT014E003)
				.HasColumnName("PCT014E003")
				.HasColumnOrder(215)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014E003")
				.IsOptional();

			Property(p => p.PCT014F001)
				.HasColumnName("PCT014F001")
				.HasColumnOrder(216)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014F001")
				.IsOptional();

			Property(p => p.PCT014F002)
				.HasColumnName("PCT014F002")
				.HasColumnOrder(217)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014F002")
				.IsOptional();

			Property(p => p.PCT014F003)
				.HasColumnName("PCT014F003")
				.HasColumnOrder(218)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014F003")
				.IsOptional();

			Property(p => p.PCT014G001)
				.HasColumnName("PCT014G001")
				.HasColumnOrder(219)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014G001")
				.IsOptional();

			Property(p => p.PCT014G002)
				.HasColumnName("PCT014G002")
				.HasColumnOrder(220)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014G002")
				.IsOptional();

			Property(p => p.PCT014G003)
				.HasColumnName("PCT014G003")
				.HasColumnOrder(221)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014G003")
				.IsOptional();

			Property(p => p.PCT014H001)
				.HasColumnName("PCT014H001")
				.HasColumnOrder(222)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014H001")
				.IsOptional();

			Property(p => p.PCT014H002)
				.HasColumnName("PCT014H002")
				.HasColumnOrder(223)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014H002")
				.IsOptional();

			Property(p => p.PCT014H003)
				.HasColumnName("PCT014H003")
				.HasColumnOrder(224)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014H003")
				.IsOptional();

			Property(p => p.PCT014I001)
				.HasColumnName("PCT014I001")
				.HasColumnOrder(225)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014I001")
				.IsOptional();

			Property(p => p.PCT014I002)
				.HasColumnName("PCT014I002")
				.HasColumnOrder(226)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014I002")
				.IsOptional();

			Property(p => p.PCT014I003)
				.HasColumnName("PCT014I003")
				.HasColumnOrder(227)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT014I003")
				.IsOptional();

			Property(p => p.PCT019A001)
				.HasColumnName("PCT019A001")
				.HasColumnOrder(228)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019A001")
				.IsOptional();

			Property(p => p.PCT019A002)
				.HasColumnName("PCT019A002")
				.HasColumnOrder(229)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019A002")
				.IsOptional();

			Property(p => p.PCT019A003)
				.HasColumnName("PCT019A003")
				.HasColumnOrder(230)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019A003")
				.IsOptional();

			Property(p => p.PCT019A004)
				.HasColumnName("PCT019A004")
				.HasColumnOrder(231)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019A004")
				.IsOptional();

			Property(p => p.PCT019A005)
				.HasColumnName("PCT019A005")
				.HasColumnOrder(232)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019A005")
				.IsOptional();

			Property(p => p.PCT019A006)
				.HasColumnName("PCT019A006")
				.HasColumnOrder(233)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019A006")
				.IsOptional();

			Property(p => p.PCT019A007)
				.HasColumnName("PCT019A007")
				.HasColumnOrder(234)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019A007")
				.IsOptional();

			Property(p => p.PCT019A008)
				.HasColumnName("PCT019A008")
				.HasColumnOrder(235)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019A008")
				.IsOptional();

			Property(p => p.PCT019A009)
				.HasColumnName("PCT019A009")
				.HasColumnOrder(236)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019A009")
				.IsOptional();

			Property(p => p.PCT019A010)
				.HasColumnName("PCT019A010")
				.HasColumnOrder(237)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019A010")
				.IsOptional();

			Property(p => p.PCT019A011)
				.HasColumnName("PCT019A011")
				.HasColumnOrder(238)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019A011")
				.IsOptional();

			Property(p => p.PCT019B001)
				.HasColumnName("PCT019B001")
				.HasColumnOrder(239)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019B001")
				.IsOptional();

			Property(p => p.PCT019B002)
				.HasColumnName("PCT019B002")
				.HasColumnOrder(240)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019B002")
				.IsOptional();

			Property(p => p.PCT019B003)
				.HasColumnName("PCT019B003")
				.HasColumnOrder(241)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019B003")
				.IsOptional();

			Property(p => p.PCT019B004)
				.HasColumnName("PCT019B004")
				.HasColumnOrder(242)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019B004")
				.IsOptional();

			Property(p => p.PCT019B005)
				.HasColumnName("PCT019B005")
				.HasColumnOrder(243)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019B005")
				.IsOptional();

			Property(p => p.PCT019B006)
				.HasColumnName("PCT019B006")
				.HasColumnOrder(244)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019B006")
				.IsOptional();

			Property(p => p.PCT019B007)
				.HasColumnName("PCT019B007")
				.HasColumnOrder(245)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019B007")
				.IsOptional();

			Property(p => p.PCT019B008)
				.HasColumnName("PCT019B008")
				.HasColumnOrder(246)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019B008")
				.IsOptional();

			Property(p => p.PCT019B009)
				.HasColumnName("PCT019B009")
				.HasColumnOrder(247)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019B009")
				.IsOptional();

			Property(p => p.PCT019B010)
				.HasColumnName("PCT019B010")
				.HasColumnOrder(248)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019B010")
				.IsOptional();

			Property(p => p.PCT019B011)
				.HasColumnName("PCT019B011")
				.HasColumnOrder(249)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019B011")
				.IsOptional();
		}
	}
}
