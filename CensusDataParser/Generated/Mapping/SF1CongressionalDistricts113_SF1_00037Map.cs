namespace CensusDataParser.Generated.Mapping
{
	#region Using Directives
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.ModelConfiguration;
	using Binding;
	#endregion Using Directives

	public class SF1CongressionalDistricts113_SF1_00037Map : EntityTypeConfiguration<SF1CongressionalDistricts113_SF1_00037>
	{
		public SF1CongressionalDistricts113_SF1_00037Map()
		{
			ToTable("SF1_00037", "SF1CongressionalDistricts113");

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

			Property(p => p.PCT019C001)
				.HasColumnName("PCT019C001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019C001")
				.IsOptional();

			Property(p => p.PCT019C002)
				.HasColumnName("PCT019C002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019C002")
				.IsOptional();

			Property(p => p.PCT019C003)
				.HasColumnName("PCT019C003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019C003")
				.IsOptional();

			Property(p => p.PCT019C004)
				.HasColumnName("PCT019C004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019C004")
				.IsOptional();

			Property(p => p.PCT019C005)
				.HasColumnName("PCT019C005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019C005")
				.IsOptional();

			Property(p => p.PCT019C006)
				.HasColumnName("PCT019C006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019C006")
				.IsOptional();

			Property(p => p.PCT019C007)
				.HasColumnName("PCT019C007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019C007")
				.IsOptional();

			Property(p => p.PCT019C008)
				.HasColumnName("PCT019C008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019C008")
				.IsOptional();

			Property(p => p.PCT019C009)
				.HasColumnName("PCT019C009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019C009")
				.IsOptional();

			Property(p => p.PCT019C010)
				.HasColumnName("PCT019C010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019C010")
				.IsOptional();

			Property(p => p.PCT019C011)
				.HasColumnName("PCT019C011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019C011")
				.IsOptional();

			Property(p => p.PCT019D001)
				.HasColumnName("PCT019D001")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019D001")
				.IsOptional();

			Property(p => p.PCT019D002)
				.HasColumnName("PCT019D002")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019D002")
				.IsOptional();

			Property(p => p.PCT019D003)
				.HasColumnName("PCT019D003")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019D003")
				.IsOptional();

			Property(p => p.PCT019D004)
				.HasColumnName("PCT019D004")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019D004")
				.IsOptional();

			Property(p => p.PCT019D005)
				.HasColumnName("PCT019D005")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019D005")
				.IsOptional();

			Property(p => p.PCT019D006)
				.HasColumnName("PCT019D006")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019D006")
				.IsOptional();

			Property(p => p.PCT019D007)
				.HasColumnName("PCT019D007")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019D007")
				.IsOptional();

			Property(p => p.PCT019D008)
				.HasColumnName("PCT019D008")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019D008")
				.IsOptional();

			Property(p => p.PCT019D009)
				.HasColumnName("PCT019D009")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019D009")
				.IsOptional();

			Property(p => p.PCT019D010)
				.HasColumnName("PCT019D010")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019D010")
				.IsOptional();

			Property(p => p.PCT019D011)
				.HasColumnName("PCT019D011")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019D011")
				.IsOptional();

			Property(p => p.PCT019E001)
				.HasColumnName("PCT019E001")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019E001")
				.IsOptional();

			Property(p => p.PCT019E002)
				.HasColumnName("PCT019E002")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019E002")
				.IsOptional();

			Property(p => p.PCT019E003)
				.HasColumnName("PCT019E003")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019E003")
				.IsOptional();

			Property(p => p.PCT019E004)
				.HasColumnName("PCT019E004")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019E004")
				.IsOptional();

			Property(p => p.PCT019E005)
				.HasColumnName("PCT019E005")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019E005")
				.IsOptional();

			Property(p => p.PCT019E006)
				.HasColumnName("PCT019E006")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019E006")
				.IsOptional();

			Property(p => p.PCT019E007)
				.HasColumnName("PCT019E007")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019E007")
				.IsOptional();

			Property(p => p.PCT019E008)
				.HasColumnName("PCT019E008")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019E008")
				.IsOptional();

			Property(p => p.PCT019E009)
				.HasColumnName("PCT019E009")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019E009")
				.IsOptional();

			Property(p => p.PCT019E010)
				.HasColumnName("PCT019E010")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019E010")
				.IsOptional();

			Property(p => p.PCT019E011)
				.HasColumnName("PCT019E011")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019E011")
				.IsOptional();

			Property(p => p.PCT019F001)
				.HasColumnName("PCT019F001")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019F001")
				.IsOptional();

			Property(p => p.PCT019F002)
				.HasColumnName("PCT019F002")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019F002")
				.IsOptional();

			Property(p => p.PCT019F003)
				.HasColumnName("PCT019F003")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019F003")
				.IsOptional();

			Property(p => p.PCT019F004)
				.HasColumnName("PCT019F004")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019F004")
				.IsOptional();

			Property(p => p.PCT019F005)
				.HasColumnName("PCT019F005")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019F005")
				.IsOptional();

			Property(p => p.PCT019F006)
				.HasColumnName("PCT019F006")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019F006")
				.IsOptional();

			Property(p => p.PCT019F007)
				.HasColumnName("PCT019F007")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019F007")
				.IsOptional();

			Property(p => p.PCT019F008)
				.HasColumnName("PCT019F008")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019F008")
				.IsOptional();

			Property(p => p.PCT019F009)
				.HasColumnName("PCT019F009")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019F009")
				.IsOptional();

			Property(p => p.PCT019F010)
				.HasColumnName("PCT019F010")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019F010")
				.IsOptional();

			Property(p => p.PCT019F011)
				.HasColumnName("PCT019F011")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019F011")
				.IsOptional();

			Property(p => p.PCT019G001)
				.HasColumnName("PCT019G001")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019G001")
				.IsOptional();

			Property(p => p.PCT019G002)
				.HasColumnName("PCT019G002")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019G002")
				.IsOptional();

			Property(p => p.PCT019G003)
				.HasColumnName("PCT019G003")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019G003")
				.IsOptional();

			Property(p => p.PCT019G004)
				.HasColumnName("PCT019G004")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019G004")
				.IsOptional();

			Property(p => p.PCT019G005)
				.HasColumnName("PCT019G005")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019G005")
				.IsOptional();

			Property(p => p.PCT019G006)
				.HasColumnName("PCT019G006")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019G006")
				.IsOptional();

			Property(p => p.PCT019G007)
				.HasColumnName("PCT019G007")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019G007")
				.IsOptional();

			Property(p => p.PCT019G008)
				.HasColumnName("PCT019G008")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019G008")
				.IsOptional();

			Property(p => p.PCT019G009)
				.HasColumnName("PCT019G009")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019G009")
				.IsOptional();

			Property(p => p.PCT019G010)
				.HasColumnName("PCT019G010")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019G010")
				.IsOptional();

			Property(p => p.PCT019G011)
				.HasColumnName("PCT019G011")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019G011")
				.IsOptional();

			Property(p => p.PCT019H001)
				.HasColumnName("PCT019H001")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019H001")
				.IsOptional();

			Property(p => p.PCT019H002)
				.HasColumnName("PCT019H002")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019H002")
				.IsOptional();

			Property(p => p.PCT019H003)
				.HasColumnName("PCT019H003")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019H003")
				.IsOptional();

			Property(p => p.PCT019H004)
				.HasColumnName("PCT019H004")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019H004")
				.IsOptional();

			Property(p => p.PCT019H005)
				.HasColumnName("PCT019H005")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019H005")
				.IsOptional();

			Property(p => p.PCT019H006)
				.HasColumnName("PCT019H006")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019H006")
				.IsOptional();

			Property(p => p.PCT019H007)
				.HasColumnName("PCT019H007")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019H007")
				.IsOptional();

			Property(p => p.PCT019H008)
				.HasColumnName("PCT019H008")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019H008")
				.IsOptional();

			Property(p => p.PCT019H009)
				.HasColumnName("PCT019H009")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019H009")
				.IsOptional();

			Property(p => p.PCT019H010)
				.HasColumnName("PCT019H010")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019H010")
				.IsOptional();

			Property(p => p.PCT019H011)
				.HasColumnName("PCT019H011")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019H011")
				.IsOptional();

			Property(p => p.PCT019I001)
				.HasColumnName("PCT019I001")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019I001")
				.IsOptional();

			Property(p => p.PCT019I002)
				.HasColumnName("PCT019I002")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019I002")
				.IsOptional();

			Property(p => p.PCT019I003)
				.HasColumnName("PCT019I003")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019I003")
				.IsOptional();

			Property(p => p.PCT019I004)
				.HasColumnName("PCT019I004")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019I004")
				.IsOptional();

			Property(p => p.PCT019I005)
				.HasColumnName("PCT019I005")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019I005")
				.IsOptional();

			Property(p => p.PCT019I006)
				.HasColumnName("PCT019I006")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019I006")
				.IsOptional();

			Property(p => p.PCT019I007)
				.HasColumnName("PCT019I007")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019I007")
				.IsOptional();

			Property(p => p.PCT019I008)
				.HasColumnName("PCT019I008")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019I008")
				.IsOptional();

			Property(p => p.PCT019I009)
				.HasColumnName("PCT019I009")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019I009")
				.IsOptional();

			Property(p => p.PCT019I010)
				.HasColumnName("PCT019I010")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019I010")
				.IsOptional();

			Property(p => p.PCT019I011)
				.HasColumnName("PCT019I011")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT019I011")
				.IsOptional();

			Property(p => p.PCT020A001)
				.HasColumnName("PCT020A001")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A001")
				.IsOptional();

			Property(p => p.PCT020A002)
				.HasColumnName("PCT020A002")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A002")
				.IsOptional();

			Property(p => p.PCT020A003)
				.HasColumnName("PCT020A003")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A003")
				.IsOptional();

			Property(p => p.PCT020A004)
				.HasColumnName("PCT020A004")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A004")
				.IsOptional();

			Property(p => p.PCT020A005)
				.HasColumnName("PCT020A005")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A005")
				.IsOptional();

			Property(p => p.PCT020A006)
				.HasColumnName("PCT020A006")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A006")
				.IsOptional();

			Property(p => p.PCT020A007)
				.HasColumnName("PCT020A007")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A007")
				.IsOptional();

			Property(p => p.PCT020A008)
				.HasColumnName("PCT020A008")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A008")
				.IsOptional();

			Property(p => p.PCT020A009)
				.HasColumnName("PCT020A009")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A009")
				.IsOptional();

			Property(p => p.PCT020A010)
				.HasColumnName("PCT020A010")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A010")
				.IsOptional();

			Property(p => p.PCT020A011)
				.HasColumnName("PCT020A011")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A011")
				.IsOptional();

			Property(p => p.PCT020A012)
				.HasColumnName("PCT020A012")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A012")
				.IsOptional();

			Property(p => p.PCT020A013)
				.HasColumnName("PCT020A013")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A013")
				.IsOptional();

			Property(p => p.PCT020A014)
				.HasColumnName("PCT020A014")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A014")
				.IsOptional();

			Property(p => p.PCT020A015)
				.HasColumnName("PCT020A015")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A015")
				.IsOptional();

			Property(p => p.PCT020A016)
				.HasColumnName("PCT020A016")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A016")
				.IsOptional();

			Property(p => p.PCT020A017)
				.HasColumnName("PCT020A017")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A017")
				.IsOptional();

			Property(p => p.PCT020A018)
				.HasColumnName("PCT020A018")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A018")
				.IsOptional();

			Property(p => p.PCT020A019)
				.HasColumnName("PCT020A019")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A019")
				.IsOptional();

			Property(p => p.PCT020A020)
				.HasColumnName("PCT020A020")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A020")
				.IsOptional();

			Property(p => p.PCT020A021)
				.HasColumnName("PCT020A021")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A021")
				.IsOptional();

			Property(p => p.PCT020A022)
				.HasColumnName("PCT020A022")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A022")
				.IsOptional();

			Property(p => p.PCT020A023)
				.HasColumnName("PCT020A023")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A023")
				.IsOptional();

			Property(p => p.PCT020A024)
				.HasColumnName("PCT020A024")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A024")
				.IsOptional();

			Property(p => p.PCT020A025)
				.HasColumnName("PCT020A025")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A025")
				.IsOptional();

			Property(p => p.PCT020A026)
				.HasColumnName("PCT020A026")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A026")
				.IsOptional();

			Property(p => p.PCT020A027)
				.HasColumnName("PCT020A027")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A027")
				.IsOptional();

			Property(p => p.PCT020A028)
				.HasColumnName("PCT020A028")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A028")
				.IsOptional();

			Property(p => p.PCT020A029)
				.HasColumnName("PCT020A029")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A029")
				.IsOptional();

			Property(p => p.PCT020A030)
				.HasColumnName("PCT020A030")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A030")
				.IsOptional();

			Property(p => p.PCT020A031)
				.HasColumnName("PCT020A031")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A031")
				.IsOptional();

			Property(p => p.PCT020A032)
				.HasColumnName("PCT020A032")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020A032")
				.IsOptional();

			Property(p => p.PCT020B001)
				.HasColumnName("PCT020B001")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B001")
				.IsOptional();

			Property(p => p.PCT020B002)
				.HasColumnName("PCT020B002")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B002")
				.IsOptional();

			Property(p => p.PCT020B003)
				.HasColumnName("PCT020B003")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B003")
				.IsOptional();

			Property(p => p.PCT020B004)
				.HasColumnName("PCT020B004")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B004")
				.IsOptional();

			Property(p => p.PCT020B005)
				.HasColumnName("PCT020B005")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B005")
				.IsOptional();

			Property(p => p.PCT020B006)
				.HasColumnName("PCT020B006")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B006")
				.IsOptional();

			Property(p => p.PCT020B007)
				.HasColumnName("PCT020B007")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B007")
				.IsOptional();

			Property(p => p.PCT020B008)
				.HasColumnName("PCT020B008")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B008")
				.IsOptional();

			Property(p => p.PCT020B009)
				.HasColumnName("PCT020B009")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B009")
				.IsOptional();

			Property(p => p.PCT020B010)
				.HasColumnName("PCT020B010")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B010")
				.IsOptional();

			Property(p => p.PCT020B011)
				.HasColumnName("PCT020B011")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B011")
				.IsOptional();

			Property(p => p.PCT020B012)
				.HasColumnName("PCT020B012")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B012")
				.IsOptional();

			Property(p => p.PCT020B013)
				.HasColumnName("PCT020B013")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B013")
				.IsOptional();

			Property(p => p.PCT020B014)
				.HasColumnName("PCT020B014")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B014")
				.IsOptional();

			Property(p => p.PCT020B015)
				.HasColumnName("PCT020B015")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B015")
				.IsOptional();

			Property(p => p.PCT020B016)
				.HasColumnName("PCT020B016")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B016")
				.IsOptional();

			Property(p => p.PCT020B017)
				.HasColumnName("PCT020B017")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B017")
				.IsOptional();

			Property(p => p.PCT020B018)
				.HasColumnName("PCT020B018")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B018")
				.IsOptional();

			Property(p => p.PCT020B019)
				.HasColumnName("PCT020B019")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B019")
				.IsOptional();

			Property(p => p.PCT020B020)
				.HasColumnName("PCT020B020")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B020")
				.IsOptional();

			Property(p => p.PCT020B021)
				.HasColumnName("PCT020B021")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B021")
				.IsOptional();

			Property(p => p.PCT020B022)
				.HasColumnName("PCT020B022")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B022")
				.IsOptional();

			Property(p => p.PCT020B023)
				.HasColumnName("PCT020B023")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B023")
				.IsOptional();

			Property(p => p.PCT020B024)
				.HasColumnName("PCT020B024")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B024")
				.IsOptional();

			Property(p => p.PCT020B025)
				.HasColumnName("PCT020B025")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B025")
				.IsOptional();

			Property(p => p.PCT020B026)
				.HasColumnName("PCT020B026")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B026")
				.IsOptional();

			Property(p => p.PCT020B027)
				.HasColumnName("PCT020B027")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B027")
				.IsOptional();

			Property(p => p.PCT020B028)
				.HasColumnName("PCT020B028")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B028")
				.IsOptional();

			Property(p => p.PCT020B029)
				.HasColumnName("PCT020B029")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B029")
				.IsOptional();

			Property(p => p.PCT020B030)
				.HasColumnName("PCT020B030")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B030")
				.IsOptional();

			Property(p => p.PCT020B031)
				.HasColumnName("PCT020B031")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B031")
				.IsOptional();

			Property(p => p.PCT020B032)
				.HasColumnName("PCT020B032")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020B032")
				.IsOptional();

			Property(p => p.PCT020C001)
				.HasColumnName("PCT020C001")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C001")
				.IsOptional();

			Property(p => p.PCT020C002)
				.HasColumnName("PCT020C002")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C002")
				.IsOptional();

			Property(p => p.PCT020C003)
				.HasColumnName("PCT020C003")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C003")
				.IsOptional();

			Property(p => p.PCT020C004)
				.HasColumnName("PCT020C004")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C004")
				.IsOptional();

			Property(p => p.PCT020C005)
				.HasColumnName("PCT020C005")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C005")
				.IsOptional();

			Property(p => p.PCT020C006)
				.HasColumnName("PCT020C006")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C006")
				.IsOptional();

			Property(p => p.PCT020C007)
				.HasColumnName("PCT020C007")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C007")
				.IsOptional();

			Property(p => p.PCT020C008)
				.HasColumnName("PCT020C008")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C008")
				.IsOptional();

			Property(p => p.PCT020C009)
				.HasColumnName("PCT020C009")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C009")
				.IsOptional();

			Property(p => p.PCT020C010)
				.HasColumnName("PCT020C010")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C010")
				.IsOptional();

			Property(p => p.PCT020C011)
				.HasColumnName("PCT020C011")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C011")
				.IsOptional();

			Property(p => p.PCT020C012)
				.HasColumnName("PCT020C012")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C012")
				.IsOptional();

			Property(p => p.PCT020C013)
				.HasColumnName("PCT020C013")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C013")
				.IsOptional();

			Property(p => p.PCT020C014)
				.HasColumnName("PCT020C014")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C014")
				.IsOptional();

			Property(p => p.PCT020C015)
				.HasColumnName("PCT020C015")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C015")
				.IsOptional();

			Property(p => p.PCT020C016)
				.HasColumnName("PCT020C016")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C016")
				.IsOptional();

			Property(p => p.PCT020C017)
				.HasColumnName("PCT020C017")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C017")
				.IsOptional();

			Property(p => p.PCT020C018)
				.HasColumnName("PCT020C018")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C018")
				.IsOptional();

			Property(p => p.PCT020C019)
				.HasColumnName("PCT020C019")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C019")
				.IsOptional();

			Property(p => p.PCT020C020)
				.HasColumnName("PCT020C020")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C020")
				.IsOptional();

			Property(p => p.PCT020C021)
				.HasColumnName("PCT020C021")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C021")
				.IsOptional();

			Property(p => p.PCT020C022)
				.HasColumnName("PCT020C022")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C022")
				.IsOptional();

			Property(p => p.PCT020C023)
				.HasColumnName("PCT020C023")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C023")
				.IsOptional();

			Property(p => p.PCT020C024)
				.HasColumnName("PCT020C024")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C024")
				.IsOptional();

			Property(p => p.PCT020C025)
				.HasColumnName("PCT020C025")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C025")
				.IsOptional();

			Property(p => p.PCT020C026)
				.HasColumnName("PCT020C026")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C026")
				.IsOptional();

			Property(p => p.PCT020C027)
				.HasColumnName("PCT020C027")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C027")
				.IsOptional();

			Property(p => p.PCT020C028)
				.HasColumnName("PCT020C028")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C028")
				.IsOptional();

			Property(p => p.PCT020C029)
				.HasColumnName("PCT020C029")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C029")
				.IsOptional();

			Property(p => p.PCT020C030)
				.HasColumnName("PCT020C030")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C030")
				.IsOptional();

			Property(p => p.PCT020C031)
				.HasColumnName("PCT020C031")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C031")
				.IsOptional();

			Property(p => p.PCT020C032)
				.HasColumnName("PCT020C032")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020C032")
				.IsOptional();

			Property(p => p.PCT020D001)
				.HasColumnName("PCT020D001")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D001")
				.IsOptional();

			Property(p => p.PCT020D002)
				.HasColumnName("PCT020D002")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D002")
				.IsOptional();

			Property(p => p.PCT020D003)
				.HasColumnName("PCT020D003")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D003")
				.IsOptional();

			Property(p => p.PCT020D004)
				.HasColumnName("PCT020D004")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D004")
				.IsOptional();

			Property(p => p.PCT020D005)
				.HasColumnName("PCT020D005")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D005")
				.IsOptional();

			Property(p => p.PCT020D006)
				.HasColumnName("PCT020D006")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D006")
				.IsOptional();

			Property(p => p.PCT020D007)
				.HasColumnName("PCT020D007")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D007")
				.IsOptional();

			Property(p => p.PCT020D008)
				.HasColumnName("PCT020D008")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D008")
				.IsOptional();

			Property(p => p.PCT020D009)
				.HasColumnName("PCT020D009")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D009")
				.IsOptional();

			Property(p => p.PCT020D010)
				.HasColumnName("PCT020D010")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D010")
				.IsOptional();

			Property(p => p.PCT020D011)
				.HasColumnName("PCT020D011")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D011")
				.IsOptional();

			Property(p => p.PCT020D012)
				.HasColumnName("PCT020D012")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D012")
				.IsOptional();

			Property(p => p.PCT020D013)
				.HasColumnName("PCT020D013")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D013")
				.IsOptional();

			Property(p => p.PCT020D014)
				.HasColumnName("PCT020D014")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D014")
				.IsOptional();

			Property(p => p.PCT020D015)
				.HasColumnName("PCT020D015")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D015")
				.IsOptional();

			Property(p => p.PCT020D016)
				.HasColumnName("PCT020D016")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D016")
				.IsOptional();

			Property(p => p.PCT020D017)
				.HasColumnName("PCT020D017")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D017")
				.IsOptional();

			Property(p => p.PCT020D018)
				.HasColumnName("PCT020D018")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D018")
				.IsOptional();

			Property(p => p.PCT020D019)
				.HasColumnName("PCT020D019")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D019")
				.IsOptional();

			Property(p => p.PCT020D020)
				.HasColumnName("PCT020D020")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D020")
				.IsOptional();

			Property(p => p.PCT020D021)
				.HasColumnName("PCT020D021")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D021")
				.IsOptional();

			Property(p => p.PCT020D022)
				.HasColumnName("PCT020D022")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D022")
				.IsOptional();

			Property(p => p.PCT020D023)
				.HasColumnName("PCT020D023")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D023")
				.IsOptional();

			Property(p => p.PCT020D024)
				.HasColumnName("PCT020D024")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D024")
				.IsOptional();

			Property(p => p.PCT020D025)
				.HasColumnName("PCT020D025")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D025")
				.IsOptional();

			Property(p => p.PCT020D026)
				.HasColumnName("PCT020D026")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D026")
				.IsOptional();

			Property(p => p.PCT020D027)
				.HasColumnName("PCT020D027")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D027")
				.IsOptional();

			Property(p => p.PCT020D028)
				.HasColumnName("PCT020D028")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D028")
				.IsOptional();

			Property(p => p.PCT020D029)
				.HasColumnName("PCT020D029")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D029")
				.IsOptional();

			Property(p => p.PCT020D030)
				.HasColumnName("PCT020D030")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D030")
				.IsOptional();

			Property(p => p.PCT020D031)
				.HasColumnName("PCT020D031")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D031")
				.IsOptional();

			Property(p => p.PCT020D032)
				.HasColumnName("PCT020D032")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020D032")
				.IsOptional();

			Property(p => p.PCT020E001)
				.HasColumnName("PCT020E001")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E001")
				.IsOptional();

			Property(p => p.PCT020E002)
				.HasColumnName("PCT020E002")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E002")
				.IsOptional();

			Property(p => p.PCT020E003)
				.HasColumnName("PCT020E003")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E003")
				.IsOptional();

			Property(p => p.PCT020E004)
				.HasColumnName("PCT020E004")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E004")
				.IsOptional();

			Property(p => p.PCT020E005)
				.HasColumnName("PCT020E005")
				.HasColumnOrder(214)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E005")
				.IsOptional();

			Property(p => p.PCT020E006)
				.HasColumnName("PCT020E006")
				.HasColumnOrder(215)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E006")
				.IsOptional();

			Property(p => p.PCT020E007)
				.HasColumnName("PCT020E007")
				.HasColumnOrder(216)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E007")
				.IsOptional();

			Property(p => p.PCT020E008)
				.HasColumnName("PCT020E008")
				.HasColumnOrder(217)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E008")
				.IsOptional();

			Property(p => p.PCT020E009)
				.HasColumnName("PCT020E009")
				.HasColumnOrder(218)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E009")
				.IsOptional();

			Property(p => p.PCT020E010)
				.HasColumnName("PCT020E010")
				.HasColumnOrder(219)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E010")
				.IsOptional();

			Property(p => p.PCT020E011)
				.HasColumnName("PCT020E011")
				.HasColumnOrder(220)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E011")
				.IsOptional();

			Property(p => p.PCT020E012)
				.HasColumnName("PCT020E012")
				.HasColumnOrder(221)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E012")
				.IsOptional();

			Property(p => p.PCT020E013)
				.HasColumnName("PCT020E013")
				.HasColumnOrder(222)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E013")
				.IsOptional();

			Property(p => p.PCT020E014)
				.HasColumnName("PCT020E014")
				.HasColumnOrder(223)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E014")
				.IsOptional();

			Property(p => p.PCT020E015)
				.HasColumnName("PCT020E015")
				.HasColumnOrder(224)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E015")
				.IsOptional();

			Property(p => p.PCT020E016)
				.HasColumnName("PCT020E016")
				.HasColumnOrder(225)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E016")
				.IsOptional();

			Property(p => p.PCT020E017)
				.HasColumnName("PCT020E017")
				.HasColumnOrder(226)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E017")
				.IsOptional();

			Property(p => p.PCT020E018)
				.HasColumnName("PCT020E018")
				.HasColumnOrder(227)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E018")
				.IsOptional();

			Property(p => p.PCT020E019)
				.HasColumnName("PCT020E019")
				.HasColumnOrder(228)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E019")
				.IsOptional();

			Property(p => p.PCT020E020)
				.HasColumnName("PCT020E020")
				.HasColumnOrder(229)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E020")
				.IsOptional();

			Property(p => p.PCT020E021)
				.HasColumnName("PCT020E021")
				.HasColumnOrder(230)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E021")
				.IsOptional();

			Property(p => p.PCT020E022)
				.HasColumnName("PCT020E022")
				.HasColumnOrder(231)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E022")
				.IsOptional();

			Property(p => p.PCT020E023)
				.HasColumnName("PCT020E023")
				.HasColumnOrder(232)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E023")
				.IsOptional();

			Property(p => p.PCT020E024)
				.HasColumnName("PCT020E024")
				.HasColumnOrder(233)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E024")
				.IsOptional();

			Property(p => p.PCT020E025)
				.HasColumnName("PCT020E025")
				.HasColumnOrder(234)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E025")
				.IsOptional();

			Property(p => p.PCT020E026)
				.HasColumnName("PCT020E026")
				.HasColumnOrder(235)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E026")
				.IsOptional();

			Property(p => p.PCT020E027)
				.HasColumnName("PCT020E027")
				.HasColumnOrder(236)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E027")
				.IsOptional();

			Property(p => p.PCT020E028)
				.HasColumnName("PCT020E028")
				.HasColumnOrder(237)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E028")
				.IsOptional();

			Property(p => p.PCT020E029)
				.HasColumnName("PCT020E029")
				.HasColumnOrder(238)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E029")
				.IsOptional();

			Property(p => p.PCT020E030)
				.HasColumnName("PCT020E030")
				.HasColumnOrder(239)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E030")
				.IsOptional();

			Property(p => p.PCT020E031)
				.HasColumnName("PCT020E031")
				.HasColumnOrder(240)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E031")
				.IsOptional();

			Property(p => p.PCT020E032)
				.HasColumnName("PCT020E032")
				.HasColumnOrder(241)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT020E032")
				.IsOptional();
		}
	}
}
