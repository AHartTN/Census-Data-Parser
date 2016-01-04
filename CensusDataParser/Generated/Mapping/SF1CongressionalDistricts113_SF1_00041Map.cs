namespace CensusDataParser.Generated.Mapping
{
	#region Using Directives
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.ModelConfiguration;
	using Binding;
	#endregion Using Directives

	public class SF1CongressionalDistricts113_SF1_00041Map : EntityTypeConfiguration<SF1CongressionalDistricts113_SF1_00041>
	{
		public SF1CongressionalDistricts113_SF1_00041Map()
		{
			ToTable("SF1_00041", "SF1CongressionalDistricts113");

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

			Property(p => p.PCO0070001)
				.HasColumnName("PCO0070001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070001")
				.IsOptional();

			Property(p => p.PCO0070002)
				.HasColumnName("PCO0070002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070002")
				.IsOptional();

			Property(p => p.PCO0070003)
				.HasColumnName("PCO0070003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070003")
				.IsOptional();

			Property(p => p.PCO0070004)
				.HasColumnName("PCO0070004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070004")
				.IsOptional();

			Property(p => p.PCO0070005)
				.HasColumnName("PCO0070005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070005")
				.IsOptional();

			Property(p => p.PCO0070006)
				.HasColumnName("PCO0070006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070006")
				.IsOptional();

			Property(p => p.PCO0070007)
				.HasColumnName("PCO0070007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070007")
				.IsOptional();

			Property(p => p.PCO0070008)
				.HasColumnName("PCO0070008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070008")
				.IsOptional();

			Property(p => p.PCO0070009)
				.HasColumnName("PCO0070009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070009")
				.IsOptional();

			Property(p => p.PCO0070010)
				.HasColumnName("PCO0070010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070010")
				.IsOptional();

			Property(p => p.PCO0070011)
				.HasColumnName("PCO0070011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070011")
				.IsOptional();

			Property(p => p.PCO0070012)
				.HasColumnName("PCO0070012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070012")
				.IsOptional();

			Property(p => p.PCO0070013)
				.HasColumnName("PCO0070013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070013")
				.IsOptional();

			Property(p => p.PCO0070014)
				.HasColumnName("PCO0070014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070014")
				.IsOptional();

			Property(p => p.PCO0070015)
				.HasColumnName("PCO0070015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070015")
				.IsOptional();

			Property(p => p.PCO0070016)
				.HasColumnName("PCO0070016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070016")
				.IsOptional();

			Property(p => p.PCO0070017)
				.HasColumnName("PCO0070017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070017")
				.IsOptional();

			Property(p => p.PCO0070018)
				.HasColumnName("PCO0070018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070018")
				.IsOptional();

			Property(p => p.PCO0070019)
				.HasColumnName("PCO0070019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070019")
				.IsOptional();

			Property(p => p.PCO0070020)
				.HasColumnName("PCO0070020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070020")
				.IsOptional();

			Property(p => p.PCO0070021)
				.HasColumnName("PCO0070021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070021")
				.IsOptional();

			Property(p => p.PCO0070022)
				.HasColumnName("PCO0070022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070022")
				.IsOptional();

			Property(p => p.PCO0070023)
				.HasColumnName("PCO0070023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070023")
				.IsOptional();

			Property(p => p.PCO0070024)
				.HasColumnName("PCO0070024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070024")
				.IsOptional();

			Property(p => p.PCO0070025)
				.HasColumnName("PCO0070025")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070025")
				.IsOptional();

			Property(p => p.PCO0070026)
				.HasColumnName("PCO0070026")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070026")
				.IsOptional();

			Property(p => p.PCO0070027)
				.HasColumnName("PCO0070027")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070027")
				.IsOptional();

			Property(p => p.PCO0070028)
				.HasColumnName("PCO0070028")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070028")
				.IsOptional();

			Property(p => p.PCO0070029)
				.HasColumnName("PCO0070029")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070029")
				.IsOptional();

			Property(p => p.PCO0070030)
				.HasColumnName("PCO0070030")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070030")
				.IsOptional();

			Property(p => p.PCO0070031)
				.HasColumnName("PCO0070031")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070031")
				.IsOptional();

			Property(p => p.PCO0070032)
				.HasColumnName("PCO0070032")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070032")
				.IsOptional();

			Property(p => p.PCO0070033)
				.HasColumnName("PCO0070033")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070033")
				.IsOptional();

			Property(p => p.PCO0070034)
				.HasColumnName("PCO0070034")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070034")
				.IsOptional();

			Property(p => p.PCO0070035)
				.HasColumnName("PCO0070035")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070035")
				.IsOptional();

			Property(p => p.PCO0070036)
				.HasColumnName("PCO0070036")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070036")
				.IsOptional();

			Property(p => p.PCO0070037)
				.HasColumnName("PCO0070037")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070037")
				.IsOptional();

			Property(p => p.PCO0070038)
				.HasColumnName("PCO0070038")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070038")
				.IsOptional();

			Property(p => p.PCO0070039)
				.HasColumnName("PCO0070039")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0070039")
				.IsOptional();

			Property(p => p.PCO0080001)
				.HasColumnName("PCO0080001")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080001")
				.IsOptional();

			Property(p => p.PCO0080002)
				.HasColumnName("PCO0080002")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080002")
				.IsOptional();

			Property(p => p.PCO0080003)
				.HasColumnName("PCO0080003")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080003")
				.IsOptional();

			Property(p => p.PCO0080004)
				.HasColumnName("PCO0080004")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080004")
				.IsOptional();

			Property(p => p.PCO0080005)
				.HasColumnName("PCO0080005")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080005")
				.IsOptional();

			Property(p => p.PCO0080006)
				.HasColumnName("PCO0080006")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080006")
				.IsOptional();

			Property(p => p.PCO0080007)
				.HasColumnName("PCO0080007")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080007")
				.IsOptional();

			Property(p => p.PCO0080008)
				.HasColumnName("PCO0080008")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080008")
				.IsOptional();

			Property(p => p.PCO0080009)
				.HasColumnName("PCO0080009")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080009")
				.IsOptional();

			Property(p => p.PCO0080010)
				.HasColumnName("PCO0080010")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080010")
				.IsOptional();

			Property(p => p.PCO0080011)
				.HasColumnName("PCO0080011")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080011")
				.IsOptional();

			Property(p => p.PCO0080012)
				.HasColumnName("PCO0080012")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080012")
				.IsOptional();

			Property(p => p.PCO0080013)
				.HasColumnName("PCO0080013")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080013")
				.IsOptional();

			Property(p => p.PCO0080014)
				.HasColumnName("PCO0080014")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080014")
				.IsOptional();

			Property(p => p.PCO0080015)
				.HasColumnName("PCO0080015")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080015")
				.IsOptional();

			Property(p => p.PCO0080016)
				.HasColumnName("PCO0080016")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080016")
				.IsOptional();

			Property(p => p.PCO0080017)
				.HasColumnName("PCO0080017")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080017")
				.IsOptional();

			Property(p => p.PCO0080018)
				.HasColumnName("PCO0080018")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080018")
				.IsOptional();

			Property(p => p.PCO0080019)
				.HasColumnName("PCO0080019")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080019")
				.IsOptional();

			Property(p => p.PCO0080020)
				.HasColumnName("PCO0080020")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080020")
				.IsOptional();

			Property(p => p.PCO0080021)
				.HasColumnName("PCO0080021")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080021")
				.IsOptional();

			Property(p => p.PCO0080022)
				.HasColumnName("PCO0080022")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080022")
				.IsOptional();

			Property(p => p.PCO0080023)
				.HasColumnName("PCO0080023")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080023")
				.IsOptional();

			Property(p => p.PCO0080024)
				.HasColumnName("PCO0080024")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080024")
				.IsOptional();

			Property(p => p.PCO0080025)
				.HasColumnName("PCO0080025")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080025")
				.IsOptional();

			Property(p => p.PCO0080026)
				.HasColumnName("PCO0080026")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080026")
				.IsOptional();

			Property(p => p.PCO0080027)
				.HasColumnName("PCO0080027")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080027")
				.IsOptional();

			Property(p => p.PCO0080028)
				.HasColumnName("PCO0080028")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080028")
				.IsOptional();

			Property(p => p.PCO0080029)
				.HasColumnName("PCO0080029")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080029")
				.IsOptional();

			Property(p => p.PCO0080030)
				.HasColumnName("PCO0080030")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080030")
				.IsOptional();

			Property(p => p.PCO0080031)
				.HasColumnName("PCO0080031")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080031")
				.IsOptional();

			Property(p => p.PCO0080032)
				.HasColumnName("PCO0080032")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080032")
				.IsOptional();

			Property(p => p.PCO0080033)
				.HasColumnName("PCO0080033")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080033")
				.IsOptional();

			Property(p => p.PCO0080034)
				.HasColumnName("PCO0080034")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080034")
				.IsOptional();

			Property(p => p.PCO0080035)
				.HasColumnName("PCO0080035")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080035")
				.IsOptional();

			Property(p => p.PCO0080036)
				.HasColumnName("PCO0080036")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080036")
				.IsOptional();

			Property(p => p.PCO0080037)
				.HasColumnName("PCO0080037")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080037")
				.IsOptional();

			Property(p => p.PCO0080038)
				.HasColumnName("PCO0080038")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080038")
				.IsOptional();

			Property(p => p.PCO0080039)
				.HasColumnName("PCO0080039")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0080039")
				.IsOptional();

			Property(p => p.PCO0090001)
				.HasColumnName("PCO0090001")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090001")
				.IsOptional();

			Property(p => p.PCO0090002)
				.HasColumnName("PCO0090002")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090002")
				.IsOptional();

			Property(p => p.PCO0090003)
				.HasColumnName("PCO0090003")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090003")
				.IsOptional();

			Property(p => p.PCO0090004)
				.HasColumnName("PCO0090004")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090004")
				.IsOptional();

			Property(p => p.PCO0090005)
				.HasColumnName("PCO0090005")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090005")
				.IsOptional();

			Property(p => p.PCO0090006)
				.HasColumnName("PCO0090006")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090006")
				.IsOptional();

			Property(p => p.PCO0090007)
				.HasColumnName("PCO0090007")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090007")
				.IsOptional();

			Property(p => p.PCO0090008)
				.HasColumnName("PCO0090008")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090008")
				.IsOptional();

			Property(p => p.PCO0090009)
				.HasColumnName("PCO0090009")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090009")
				.IsOptional();

			Property(p => p.PCO0090010)
				.HasColumnName("PCO0090010")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090010")
				.IsOptional();

			Property(p => p.PCO0090011)
				.HasColumnName("PCO0090011")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090011")
				.IsOptional();

			Property(p => p.PCO0090012)
				.HasColumnName("PCO0090012")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090012")
				.IsOptional();

			Property(p => p.PCO0090013)
				.HasColumnName("PCO0090013")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090013")
				.IsOptional();

			Property(p => p.PCO0090014)
				.HasColumnName("PCO0090014")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090014")
				.IsOptional();

			Property(p => p.PCO0090015)
				.HasColumnName("PCO0090015")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090015")
				.IsOptional();

			Property(p => p.PCO0090016)
				.HasColumnName("PCO0090016")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090016")
				.IsOptional();

			Property(p => p.PCO0090017)
				.HasColumnName("PCO0090017")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090017")
				.IsOptional();

			Property(p => p.PCO0090018)
				.HasColumnName("PCO0090018")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090018")
				.IsOptional();

			Property(p => p.PCO0090019)
				.HasColumnName("PCO0090019")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090019")
				.IsOptional();

			Property(p => p.PCO0090020)
				.HasColumnName("PCO0090020")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090020")
				.IsOptional();

			Property(p => p.PCO0090021)
				.HasColumnName("PCO0090021")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090021")
				.IsOptional();

			Property(p => p.PCO0090022)
				.HasColumnName("PCO0090022")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090022")
				.IsOptional();

			Property(p => p.PCO0090023)
				.HasColumnName("PCO0090023")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090023")
				.IsOptional();

			Property(p => p.PCO0090024)
				.HasColumnName("PCO0090024")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090024")
				.IsOptional();

			Property(p => p.PCO0090025)
				.HasColumnName("PCO0090025")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090025")
				.IsOptional();

			Property(p => p.PCO0090026)
				.HasColumnName("PCO0090026")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090026")
				.IsOptional();

			Property(p => p.PCO0090027)
				.HasColumnName("PCO0090027")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090027")
				.IsOptional();

			Property(p => p.PCO0090028)
				.HasColumnName("PCO0090028")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090028")
				.IsOptional();

			Property(p => p.PCO0090029)
				.HasColumnName("PCO0090029")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090029")
				.IsOptional();

			Property(p => p.PCO0090030)
				.HasColumnName("PCO0090030")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090030")
				.IsOptional();

			Property(p => p.PCO0090031)
				.HasColumnName("PCO0090031")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090031")
				.IsOptional();

			Property(p => p.PCO0090032)
				.HasColumnName("PCO0090032")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090032")
				.IsOptional();

			Property(p => p.PCO0090033)
				.HasColumnName("PCO0090033")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090033")
				.IsOptional();

			Property(p => p.PCO0090034)
				.HasColumnName("PCO0090034")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090034")
				.IsOptional();

			Property(p => p.PCO0090035)
				.HasColumnName("PCO0090035")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090035")
				.IsOptional();

			Property(p => p.PCO0090036)
				.HasColumnName("PCO0090036")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090036")
				.IsOptional();

			Property(p => p.PCO0090037)
				.HasColumnName("PCO0090037")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090037")
				.IsOptional();

			Property(p => p.PCO0090038)
				.HasColumnName("PCO0090038")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090038")
				.IsOptional();

			Property(p => p.PCO0090039)
				.HasColumnName("PCO0090039")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0090039")
				.IsOptional();

			Property(p => p.PCO0100001)
				.HasColumnName("PCO0100001")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100001")
				.IsOptional();

			Property(p => p.PCO0100002)
				.HasColumnName("PCO0100002")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100002")
				.IsOptional();

			Property(p => p.PCO0100003)
				.HasColumnName("PCO0100003")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100003")
				.IsOptional();

			Property(p => p.PCO0100004)
				.HasColumnName("PCO0100004")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100004")
				.IsOptional();

			Property(p => p.PCO0100005)
				.HasColumnName("PCO0100005")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100005")
				.IsOptional();

			Property(p => p.PCO0100006)
				.HasColumnName("PCO0100006")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100006")
				.IsOptional();

			Property(p => p.PCO0100007)
				.HasColumnName("PCO0100007")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100007")
				.IsOptional();

			Property(p => p.PCO0100008)
				.HasColumnName("PCO0100008")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100008")
				.IsOptional();

			Property(p => p.PCO0100009)
				.HasColumnName("PCO0100009")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100009")
				.IsOptional();

			Property(p => p.PCO0100010)
				.HasColumnName("PCO0100010")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100010")
				.IsOptional();

			Property(p => p.PCO0100011)
				.HasColumnName("PCO0100011")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100011")
				.IsOptional();

			Property(p => p.PCO0100012)
				.HasColumnName("PCO0100012")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100012")
				.IsOptional();

			Property(p => p.PCO0100013)
				.HasColumnName("PCO0100013")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100013")
				.IsOptional();

			Property(p => p.PCO0100014)
				.HasColumnName("PCO0100014")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100014")
				.IsOptional();

			Property(p => p.PCO0100015)
				.HasColumnName("PCO0100015")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100015")
				.IsOptional();

			Property(p => p.PCO0100016)
				.HasColumnName("PCO0100016")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100016")
				.IsOptional();

			Property(p => p.PCO0100017)
				.HasColumnName("PCO0100017")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100017")
				.IsOptional();

			Property(p => p.PCO0100018)
				.HasColumnName("PCO0100018")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100018")
				.IsOptional();

			Property(p => p.PCO0100019)
				.HasColumnName("PCO0100019")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100019")
				.IsOptional();

			Property(p => p.PCO0100020)
				.HasColumnName("PCO0100020")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100020")
				.IsOptional();

			Property(p => p.PCO0100021)
				.HasColumnName("PCO0100021")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100021")
				.IsOptional();

			Property(p => p.PCO0100022)
				.HasColumnName("PCO0100022")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100022")
				.IsOptional();

			Property(p => p.PCO0100023)
				.HasColumnName("PCO0100023")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100023")
				.IsOptional();

			Property(p => p.PCO0100024)
				.HasColumnName("PCO0100024")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100024")
				.IsOptional();

			Property(p => p.PCO0100025)
				.HasColumnName("PCO0100025")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100025")
				.IsOptional();

			Property(p => p.PCO0100026)
				.HasColumnName("PCO0100026")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100026")
				.IsOptional();

			Property(p => p.PCO0100027)
				.HasColumnName("PCO0100027")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100027")
				.IsOptional();

			Property(p => p.PCO0100028)
				.HasColumnName("PCO0100028")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100028")
				.IsOptional();

			Property(p => p.PCO0100029)
				.HasColumnName("PCO0100029")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100029")
				.IsOptional();

			Property(p => p.PCO0100030)
				.HasColumnName("PCO0100030")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100030")
				.IsOptional();

			Property(p => p.PCO0100031)
				.HasColumnName("PCO0100031")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100031")
				.IsOptional();

			Property(p => p.PCO0100032)
				.HasColumnName("PCO0100032")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100032")
				.IsOptional();

			Property(p => p.PCO0100033)
				.HasColumnName("PCO0100033")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100033")
				.IsOptional();

			Property(p => p.PCO0100034)
				.HasColumnName("PCO0100034")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100034")
				.IsOptional();

			Property(p => p.PCO0100035)
				.HasColumnName("PCO0100035")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100035")
				.IsOptional();

			Property(p => p.PCO0100036)
				.HasColumnName("PCO0100036")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100036")
				.IsOptional();

			Property(p => p.PCO0100037)
				.HasColumnName("PCO0100037")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100037")
				.IsOptional();

			Property(p => p.PCO0100038)
				.HasColumnName("PCO0100038")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100038")
				.IsOptional();

			Property(p => p.PCO0100039)
				.HasColumnName("PCO0100039")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCO0100039")
				.IsOptional();
		}
	}
}
