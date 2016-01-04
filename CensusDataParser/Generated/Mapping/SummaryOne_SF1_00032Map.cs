namespace CensusDataParser.Generated.Mapping
{
	#region Using Directives
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.ModelConfiguration;
	using Binding;
	#endregion Using Directives

	public class SummaryOne_SF1_00032Map : EntityTypeConfiguration<SummaryOne_SF1_00032>
	{
		public SummaryOne_SF1_00032Map()
		{
			ToTable("SF1_00032", "SummaryOne");

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

			Property(p => p.PCT012M001)
				.HasColumnName("PCT012M001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M001")
				.IsOptional();

			Property(p => p.PCT012M002)
				.HasColumnName("PCT012M002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M002")
				.IsOptional();

			Property(p => p.PCT012M003)
				.HasColumnName("PCT012M003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M003")
				.IsOptional();

			Property(p => p.PCT012M004)
				.HasColumnName("PCT012M004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M004")
				.IsOptional();

			Property(p => p.PCT012M005)
				.HasColumnName("PCT012M005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M005")
				.IsOptional();

			Property(p => p.PCT012M006)
				.HasColumnName("PCT012M006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M006")
				.IsOptional();

			Property(p => p.PCT012M007)
				.HasColumnName("PCT012M007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M007")
				.IsOptional();

			Property(p => p.PCT012M008)
				.HasColumnName("PCT012M008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M008")
				.IsOptional();

			Property(p => p.PCT012M009)
				.HasColumnName("PCT012M009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M009")
				.IsOptional();

			Property(p => p.PCT012M010)
				.HasColumnName("PCT012M010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M010")
				.IsOptional();

			Property(p => p.PCT012M011)
				.HasColumnName("PCT012M011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M011")
				.IsOptional();

			Property(p => p.PCT012M012)
				.HasColumnName("PCT012M012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M012")
				.IsOptional();

			Property(p => p.PCT012M013)
				.HasColumnName("PCT012M013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M013")
				.IsOptional();

			Property(p => p.PCT012M014)
				.HasColumnName("PCT012M014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M014")
				.IsOptional();

			Property(p => p.PCT012M015)
				.HasColumnName("PCT012M015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M015")
				.IsOptional();

			Property(p => p.PCT012M016)
				.HasColumnName("PCT012M016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M016")
				.IsOptional();

			Property(p => p.PCT012M017)
				.HasColumnName("PCT012M017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M017")
				.IsOptional();

			Property(p => p.PCT012M018)
				.HasColumnName("PCT012M018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M018")
				.IsOptional();

			Property(p => p.PCT012M019)
				.HasColumnName("PCT012M019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M019")
				.IsOptional();

			Property(p => p.PCT012M020)
				.HasColumnName("PCT012M020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M020")
				.IsOptional();

			Property(p => p.PCT012M021)
				.HasColumnName("PCT012M021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M021")
				.IsOptional();

			Property(p => p.PCT012M022)
				.HasColumnName("PCT012M022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M022")
				.IsOptional();

			Property(p => p.PCT012M023)
				.HasColumnName("PCT012M023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M023")
				.IsOptional();

			Property(p => p.PCT012M024)
				.HasColumnName("PCT012M024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M024")
				.IsOptional();

			Property(p => p.PCT012M025)
				.HasColumnName("PCT012M025")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M025")
				.IsOptional();

			Property(p => p.PCT012M026)
				.HasColumnName("PCT012M026")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M026")
				.IsOptional();

			Property(p => p.PCT012M027)
				.HasColumnName("PCT012M027")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M027")
				.IsOptional();

			Property(p => p.PCT012M028)
				.HasColumnName("PCT012M028")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M028")
				.IsOptional();

			Property(p => p.PCT012M029)
				.HasColumnName("PCT012M029")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M029")
				.IsOptional();

			Property(p => p.PCT012M030)
				.HasColumnName("PCT012M030")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M030")
				.IsOptional();

			Property(p => p.PCT012M031)
				.HasColumnName("PCT012M031")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M031")
				.IsOptional();

			Property(p => p.PCT012M032)
				.HasColumnName("PCT012M032")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M032")
				.IsOptional();

			Property(p => p.PCT012M033)
				.HasColumnName("PCT012M033")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M033")
				.IsOptional();

			Property(p => p.PCT012M034)
				.HasColumnName("PCT012M034")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M034")
				.IsOptional();

			Property(p => p.PCT012M035)
				.HasColumnName("PCT012M035")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M035")
				.IsOptional();

			Property(p => p.PCT012M036)
				.HasColumnName("PCT012M036")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M036")
				.IsOptional();

			Property(p => p.PCT012M037)
				.HasColumnName("PCT012M037")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M037")
				.IsOptional();

			Property(p => p.PCT012M038)
				.HasColumnName("PCT012M038")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M038")
				.IsOptional();

			Property(p => p.PCT012M039)
				.HasColumnName("PCT012M039")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M039")
				.IsOptional();

			Property(p => p.PCT012M040)
				.HasColumnName("PCT012M040")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M040")
				.IsOptional();

			Property(p => p.PCT012M041)
				.HasColumnName("PCT012M041")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M041")
				.IsOptional();

			Property(p => p.PCT012M042)
				.HasColumnName("PCT012M042")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M042")
				.IsOptional();

			Property(p => p.PCT012M043)
				.HasColumnName("PCT012M043")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M043")
				.IsOptional();

			Property(p => p.PCT012M044)
				.HasColumnName("PCT012M044")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M044")
				.IsOptional();

			Property(p => p.PCT012M045)
				.HasColumnName("PCT012M045")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M045")
				.IsOptional();

			Property(p => p.PCT012M046)
				.HasColumnName("PCT012M046")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M046")
				.IsOptional();

			Property(p => p.PCT012M047)
				.HasColumnName("PCT012M047")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M047")
				.IsOptional();

			Property(p => p.PCT012M048)
				.HasColumnName("PCT012M048")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M048")
				.IsOptional();

			Property(p => p.PCT012M049)
				.HasColumnName("PCT012M049")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M049")
				.IsOptional();

			Property(p => p.PCT012M050)
				.HasColumnName("PCT012M050")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M050")
				.IsOptional();

			Property(p => p.PCT012M051)
				.HasColumnName("PCT012M051")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M051")
				.IsOptional();

			Property(p => p.PCT012M052)
				.HasColumnName("PCT012M052")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M052")
				.IsOptional();

			Property(p => p.PCT012M053)
				.HasColumnName("PCT012M053")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M053")
				.IsOptional();

			Property(p => p.PCT012M054)
				.HasColumnName("PCT012M054")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M054")
				.IsOptional();

			Property(p => p.PCT012M055)
				.HasColumnName("PCT012M055")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M055")
				.IsOptional();

			Property(p => p.PCT012M056)
				.HasColumnName("PCT012M056")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M056")
				.IsOptional();

			Property(p => p.PCT012M057)
				.HasColumnName("PCT012M057")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M057")
				.IsOptional();

			Property(p => p.PCT012M058)
				.HasColumnName("PCT012M058")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M058")
				.IsOptional();

			Property(p => p.PCT012M059)
				.HasColumnName("PCT012M059")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M059")
				.IsOptional();

			Property(p => p.PCT012M060)
				.HasColumnName("PCT012M060")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M060")
				.IsOptional();

			Property(p => p.PCT012M061)
				.HasColumnName("PCT012M061")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M061")
				.IsOptional();

			Property(p => p.PCT012M062)
				.HasColumnName("PCT012M062")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M062")
				.IsOptional();

			Property(p => p.PCT012M063)
				.HasColumnName("PCT012M063")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M063")
				.IsOptional();

			Property(p => p.PCT012M064)
				.HasColumnName("PCT012M064")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M064")
				.IsOptional();

			Property(p => p.PCT012M065)
				.HasColumnName("PCT012M065")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M065")
				.IsOptional();

			Property(p => p.PCT012M066)
				.HasColumnName("PCT012M066")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M066")
				.IsOptional();

			Property(p => p.PCT012M067)
				.HasColumnName("PCT012M067")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M067")
				.IsOptional();

			Property(p => p.PCT012M068)
				.HasColumnName("PCT012M068")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M068")
				.IsOptional();

			Property(p => p.PCT012M069)
				.HasColumnName("PCT012M069")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M069")
				.IsOptional();

			Property(p => p.PCT012M070)
				.HasColumnName("PCT012M070")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M070")
				.IsOptional();

			Property(p => p.PCT012M071)
				.HasColumnName("PCT012M071")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M071")
				.IsOptional();

			Property(p => p.PCT012M072)
				.HasColumnName("PCT012M072")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M072")
				.IsOptional();

			Property(p => p.PCT012M073)
				.HasColumnName("PCT012M073")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M073")
				.IsOptional();

			Property(p => p.PCT012M074)
				.HasColumnName("PCT012M074")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M074")
				.IsOptional();

			Property(p => p.PCT012M075)
				.HasColumnName("PCT012M075")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M075")
				.IsOptional();

			Property(p => p.PCT012M076)
				.HasColumnName("PCT012M076")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M076")
				.IsOptional();

			Property(p => p.PCT012M077)
				.HasColumnName("PCT012M077")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M077")
				.IsOptional();

			Property(p => p.PCT012M078)
				.HasColumnName("PCT012M078")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M078")
				.IsOptional();

			Property(p => p.PCT012M079)
				.HasColumnName("PCT012M079")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M079")
				.IsOptional();

			Property(p => p.PCT012M080)
				.HasColumnName("PCT012M080")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M080")
				.IsOptional();

			Property(p => p.PCT012M081)
				.HasColumnName("PCT012M081")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M081")
				.IsOptional();

			Property(p => p.PCT012M082)
				.HasColumnName("PCT012M082")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M082")
				.IsOptional();

			Property(p => p.PCT012M083)
				.HasColumnName("PCT012M083")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M083")
				.IsOptional();

			Property(p => p.PCT012M084)
				.HasColumnName("PCT012M084")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M084")
				.IsOptional();

			Property(p => p.PCT012M085)
				.HasColumnName("PCT012M085")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M085")
				.IsOptional();

			Property(p => p.PCT012M086)
				.HasColumnName("PCT012M086")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M086")
				.IsOptional();

			Property(p => p.PCT012M087)
				.HasColumnName("PCT012M087")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M087")
				.IsOptional();

			Property(p => p.PCT012M088)
				.HasColumnName("PCT012M088")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M088")
				.IsOptional();

			Property(p => p.PCT012M089)
				.HasColumnName("PCT012M089")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M089")
				.IsOptional();

			Property(p => p.PCT012M090)
				.HasColumnName("PCT012M090")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M090")
				.IsOptional();

			Property(p => p.PCT012M091)
				.HasColumnName("PCT012M091")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M091")
				.IsOptional();

			Property(p => p.PCT012M092)
				.HasColumnName("PCT012M092")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M092")
				.IsOptional();

			Property(p => p.PCT012M093)
				.HasColumnName("PCT012M093")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M093")
				.IsOptional();

			Property(p => p.PCT012M094)
				.HasColumnName("PCT012M094")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M094")
				.IsOptional();

			Property(p => p.PCT012M095)
				.HasColumnName("PCT012M095")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M095")
				.IsOptional();

			Property(p => p.PCT012M096)
				.HasColumnName("PCT012M096")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M096")
				.IsOptional();

			Property(p => p.PCT012M097)
				.HasColumnName("PCT012M097")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M097")
				.IsOptional();

			Property(p => p.PCT012M098)
				.HasColumnName("PCT012M098")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M098")
				.IsOptional();

			Property(p => p.PCT012M099)
				.HasColumnName("PCT012M099")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M099")
				.IsOptional();

			Property(p => p.PCT012M100)
				.HasColumnName("PCT012M100")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M100")
				.IsOptional();

			Property(p => p.PCT012M101)
				.HasColumnName("PCT012M101")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M101")
				.IsOptional();

			Property(p => p.PCT012M102)
				.HasColumnName("PCT012M102")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M102")
				.IsOptional();

			Property(p => p.PCT012M103)
				.HasColumnName("PCT012M103")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M103")
				.IsOptional();

			Property(p => p.PCT012M104)
				.HasColumnName("PCT012M104")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M104")
				.IsOptional();

			Property(p => p.PCT012M105)
				.HasColumnName("PCT012M105")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M105")
				.IsOptional();

			Property(p => p.PCT012M106)
				.HasColumnName("PCT012M106")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M106")
				.IsOptional();

			Property(p => p.PCT012M107)
				.HasColumnName("PCT012M107")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M107")
				.IsOptional();

			Property(p => p.PCT012M108)
				.HasColumnName("PCT012M108")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M108")
				.IsOptional();

			Property(p => p.PCT012M109)
				.HasColumnName("PCT012M109")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M109")
				.IsOptional();

			Property(p => p.PCT012M110)
				.HasColumnName("PCT012M110")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M110")
				.IsOptional();

			Property(p => p.PCT012M111)
				.HasColumnName("PCT012M111")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M111")
				.IsOptional();

			Property(p => p.PCT012M112)
				.HasColumnName("PCT012M112")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M112")
				.IsOptional();

			Property(p => p.PCT012M113)
				.HasColumnName("PCT012M113")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M113")
				.IsOptional();

			Property(p => p.PCT012M114)
				.HasColumnName("PCT012M114")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M114")
				.IsOptional();

			Property(p => p.PCT012M115)
				.HasColumnName("PCT012M115")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M115")
				.IsOptional();

			Property(p => p.PCT012M116)
				.HasColumnName("PCT012M116")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M116")
				.IsOptional();

			Property(p => p.PCT012M117)
				.HasColumnName("PCT012M117")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M117")
				.IsOptional();

			Property(p => p.PCT012M118)
				.HasColumnName("PCT012M118")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M118")
				.IsOptional();

			Property(p => p.PCT012M119)
				.HasColumnName("PCT012M119")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M119")
				.IsOptional();

			Property(p => p.PCT012M120)
				.HasColumnName("PCT012M120")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M120")
				.IsOptional();

			Property(p => p.PCT012M121)
				.HasColumnName("PCT012M121")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M121")
				.IsOptional();

			Property(p => p.PCT012M122)
				.HasColumnName("PCT012M122")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M122")
				.IsOptional();

			Property(p => p.PCT012M123)
				.HasColumnName("PCT012M123")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M123")
				.IsOptional();

			Property(p => p.PCT012M124)
				.HasColumnName("PCT012M124")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M124")
				.IsOptional();

			Property(p => p.PCT012M125)
				.HasColumnName("PCT012M125")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M125")
				.IsOptional();

			Property(p => p.PCT012M126)
				.HasColumnName("PCT012M126")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M126")
				.IsOptional();

			Property(p => p.PCT012M127)
				.HasColumnName("PCT012M127")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M127")
				.IsOptional();

			Property(p => p.PCT012M128)
				.HasColumnName("PCT012M128")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M128")
				.IsOptional();

			Property(p => p.PCT012M129)
				.HasColumnName("PCT012M129")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M129")
				.IsOptional();

			Property(p => p.PCT012M130)
				.HasColumnName("PCT012M130")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M130")
				.IsOptional();

			Property(p => p.PCT012M131)
				.HasColumnName("PCT012M131")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M131")
				.IsOptional();

			Property(p => p.PCT012M132)
				.HasColumnName("PCT012M132")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M132")
				.IsOptional();

			Property(p => p.PCT012M133)
				.HasColumnName("PCT012M133")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M133")
				.IsOptional();

			Property(p => p.PCT012M134)
				.HasColumnName("PCT012M134")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M134")
				.IsOptional();

			Property(p => p.PCT012M135)
				.HasColumnName("PCT012M135")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M135")
				.IsOptional();

			Property(p => p.PCT012M136)
				.HasColumnName("PCT012M136")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M136")
				.IsOptional();

			Property(p => p.PCT012M137)
				.HasColumnName("PCT012M137")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M137")
				.IsOptional();

			Property(p => p.PCT012M138)
				.HasColumnName("PCT012M138")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M138")
				.IsOptional();

			Property(p => p.PCT012M139)
				.HasColumnName("PCT012M139")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M139")
				.IsOptional();

			Property(p => p.PCT012M140)
				.HasColumnName("PCT012M140")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M140")
				.IsOptional();

			Property(p => p.PCT012M141)
				.HasColumnName("PCT012M141")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M141")
				.IsOptional();

			Property(p => p.PCT012M142)
				.HasColumnName("PCT012M142")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M142")
				.IsOptional();

			Property(p => p.PCT012M143)
				.HasColumnName("PCT012M143")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M143")
				.IsOptional();

			Property(p => p.PCT012M144)
				.HasColumnName("PCT012M144")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M144")
				.IsOptional();

			Property(p => p.PCT012M145)
				.HasColumnName("PCT012M145")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M145")
				.IsOptional();

			Property(p => p.PCT012M146)
				.HasColumnName("PCT012M146")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M146")
				.IsOptional();

			Property(p => p.PCT012M147)
				.HasColumnName("PCT012M147")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M147")
				.IsOptional();

			Property(p => p.PCT012M148)
				.HasColumnName("PCT012M148")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M148")
				.IsOptional();

			Property(p => p.PCT012M149)
				.HasColumnName("PCT012M149")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M149")
				.IsOptional();

			Property(p => p.PCT012M150)
				.HasColumnName("PCT012M150")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M150")
				.IsOptional();

			Property(p => p.PCT012M151)
				.HasColumnName("PCT012M151")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M151")
				.IsOptional();

			Property(p => p.PCT012M152)
				.HasColumnName("PCT012M152")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M152")
				.IsOptional();

			Property(p => p.PCT012M153)
				.HasColumnName("PCT012M153")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M153")
				.IsOptional();

			Property(p => p.PCT012M154)
				.HasColumnName("PCT012M154")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M154")
				.IsOptional();

			Property(p => p.PCT012M155)
				.HasColumnName("PCT012M155")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M155")
				.IsOptional();

			Property(p => p.PCT012M156)
				.HasColumnName("PCT012M156")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M156")
				.IsOptional();

			Property(p => p.PCT012M157)
				.HasColumnName("PCT012M157")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M157")
				.IsOptional();

			Property(p => p.PCT012M158)
				.HasColumnName("PCT012M158")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M158")
				.IsOptional();

			Property(p => p.PCT012M159)
				.HasColumnName("PCT012M159")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M159")
				.IsOptional();

			Property(p => p.PCT012M160)
				.HasColumnName("PCT012M160")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M160")
				.IsOptional();

			Property(p => p.PCT012M161)
				.HasColumnName("PCT012M161")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M161")
				.IsOptional();

			Property(p => p.PCT012M162)
				.HasColumnName("PCT012M162")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M162")
				.IsOptional();

			Property(p => p.PCT012M163)
				.HasColumnName("PCT012M163")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M163")
				.IsOptional();

			Property(p => p.PCT012M164)
				.HasColumnName("PCT012M164")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M164")
				.IsOptional();

			Property(p => p.PCT012M165)
				.HasColumnName("PCT012M165")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M165")
				.IsOptional();

			Property(p => p.PCT012M166)
				.HasColumnName("PCT012M166")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M166")
				.IsOptional();

			Property(p => p.PCT012M167)
				.HasColumnName("PCT012M167")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M167")
				.IsOptional();

			Property(p => p.PCT012M168)
				.HasColumnName("PCT012M168")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M168")
				.IsOptional();

			Property(p => p.PCT012M169)
				.HasColumnName("PCT012M169")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M169")
				.IsOptional();

			Property(p => p.PCT012M170)
				.HasColumnName("PCT012M170")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M170")
				.IsOptional();

			Property(p => p.PCT012M171)
				.HasColumnName("PCT012M171")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M171")
				.IsOptional();

			Property(p => p.PCT012M172)
				.HasColumnName("PCT012M172")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M172")
				.IsOptional();

			Property(p => p.PCT012M173)
				.HasColumnName("PCT012M173")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M173")
				.IsOptional();

			Property(p => p.PCT012M174)
				.HasColumnName("PCT012M174")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M174")
				.IsOptional();

			Property(p => p.PCT012M175)
				.HasColumnName("PCT012M175")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M175")
				.IsOptional();

			Property(p => p.PCT012M176)
				.HasColumnName("PCT012M176")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M176")
				.IsOptional();

			Property(p => p.PCT012M177)
				.HasColumnName("PCT012M177")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M177")
				.IsOptional();

			Property(p => p.PCT012M178)
				.HasColumnName("PCT012M178")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M178")
				.IsOptional();

			Property(p => p.PCT012M179)
				.HasColumnName("PCT012M179")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M179")
				.IsOptional();

			Property(p => p.PCT012M180)
				.HasColumnName("PCT012M180")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M180")
				.IsOptional();

			Property(p => p.PCT012M181)
				.HasColumnName("PCT012M181")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M181")
				.IsOptional();

			Property(p => p.PCT012M182)
				.HasColumnName("PCT012M182")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M182")
				.IsOptional();

			Property(p => p.PCT012M183)
				.HasColumnName("PCT012M183")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M183")
				.IsOptional();

			Property(p => p.PCT012M184)
				.HasColumnName("PCT012M184")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M184")
				.IsOptional();

			Property(p => p.PCT012M185)
				.HasColumnName("PCT012M185")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M185")
				.IsOptional();

			Property(p => p.PCT012M186)
				.HasColumnName("PCT012M186")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M186")
				.IsOptional();

			Property(p => p.PCT012M187)
				.HasColumnName("PCT012M187")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M187")
				.IsOptional();

			Property(p => p.PCT012M188)
				.HasColumnName("PCT012M188")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M188")
				.IsOptional();

			Property(p => p.PCT012M189)
				.HasColumnName("PCT012M189")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M189")
				.IsOptional();

			Property(p => p.PCT012M190)
				.HasColumnName("PCT012M190")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M190")
				.IsOptional();

			Property(p => p.PCT012M191)
				.HasColumnName("PCT012M191")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M191")
				.IsOptional();

			Property(p => p.PCT012M192)
				.HasColumnName("PCT012M192")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M192")
				.IsOptional();

			Property(p => p.PCT012M193)
				.HasColumnName("PCT012M193")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M193")
				.IsOptional();

			Property(p => p.PCT012M194)
				.HasColumnName("PCT012M194")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M194")
				.IsOptional();

			Property(p => p.PCT012M195)
				.HasColumnName("PCT012M195")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M195")
				.IsOptional();

			Property(p => p.PCT012M196)
				.HasColumnName("PCT012M196")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M196")
				.IsOptional();

			Property(p => p.PCT012M197)
				.HasColumnName("PCT012M197")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M197")
				.IsOptional();

			Property(p => p.PCT012M198)
				.HasColumnName("PCT012M198")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M198")
				.IsOptional();

			Property(p => p.PCT012M199)
				.HasColumnName("PCT012M199")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M199")
				.IsOptional();

			Property(p => p.PCT012M200)
				.HasColumnName("PCT012M200")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M200")
				.IsOptional();

			Property(p => p.PCT012M201)
				.HasColumnName("PCT012M201")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M201")
				.IsOptional();

			Property(p => p.PCT012M202)
				.HasColumnName("PCT012M202")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M202")
				.IsOptional();

			Property(p => p.PCT012M203)
				.HasColumnName("PCT012M203")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M203")
				.IsOptional();

			Property(p => p.PCT012M204)
				.HasColumnName("PCT012M204")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M204")
				.IsOptional();

			Property(p => p.PCT012M205)
				.HasColumnName("PCT012M205")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M205")
				.IsOptional();

			Property(p => p.PCT012M206)
				.HasColumnName("PCT012M206")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M206")
				.IsOptional();

			Property(p => p.PCT012M207)
				.HasColumnName("PCT012M207")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M207")
				.IsOptional();

			Property(p => p.PCT012M208)
				.HasColumnName("PCT012M208")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M208")
				.IsOptional();

			Property(p => p.PCT012M209)
				.HasColumnName("PCT012M209")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012M209")
				.IsOptional();
		}
	}
}
