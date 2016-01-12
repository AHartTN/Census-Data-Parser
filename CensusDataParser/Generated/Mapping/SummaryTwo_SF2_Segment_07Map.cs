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

	public class SummaryTwo_SF2_Segment_07Map : EntityTypeConfiguration<SummaryTwo_SF2_Segment_07>
	{
		public SummaryTwo_SF2_Segment_07Map()
		{
			ToTable("SF2_Segment_07", "SummaryTwo");

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

			Property(p => p.PCT0390001)
				.HasColumnName("PCT0390001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390001")
				.IsOptional();

			Property(p => p.PCT0390002)
				.HasColumnName("PCT0390002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390002")
				.IsOptional();

			Property(p => p.PCT0390003)
				.HasColumnName("PCT0390003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390003")
				.IsOptional();

			Property(p => p.PCT0390004)
				.HasColumnName("PCT0390004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390004")
				.IsOptional();

			Property(p => p.PCT0390005)
				.HasColumnName("PCT0390005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390005")
				.IsOptional();

			Property(p => p.PCT0390006)
				.HasColumnName("PCT0390006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390006")
				.IsOptional();

			Property(p => p.PCT0390007)
				.HasColumnName("PCT0390007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390007")
				.IsOptional();

			Property(p => p.PCT0390008)
				.HasColumnName("PCT0390008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390008")
				.IsOptional();

			Property(p => p.PCT0390009)
				.HasColumnName("PCT0390009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390009")
				.IsOptional();

			Property(p => p.PCT0390010)
				.HasColumnName("PCT0390010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390010")
				.IsOptional();

			Property(p => p.PCT0390011)
				.HasColumnName("PCT0390011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390011")
				.IsOptional();

			Property(p => p.PCT0390012)
				.HasColumnName("PCT0390012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390012")
				.IsOptional();

			Property(p => p.PCT0390013)
				.HasColumnName("PCT0390013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390013")
				.IsOptional();

			Property(p => p.PCT0390014)
				.HasColumnName("PCT0390014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390014")
				.IsOptional();

			Property(p => p.PCT0390015)
				.HasColumnName("PCT0390015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390015")
				.IsOptional();

			Property(p => p.PCT0390016)
				.HasColumnName("PCT0390016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390016")
				.IsOptional();

			Property(p => p.PCT0390017)
				.HasColumnName("PCT0390017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390017")
				.IsOptional();

			Property(p => p.PCT0390018)
				.HasColumnName("PCT0390018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390018")
				.IsOptional();

			Property(p => p.PCT0390019)
				.HasColumnName("PCT0390019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390019")
				.IsOptional();

			Property(p => p.PCT0390020)
				.HasColumnName("PCT0390020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390020")
				.IsOptional();

			Property(p => p.PCT0390021)
				.HasColumnName("PCT0390021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390021")
				.IsOptional();

			Property(p => p.PCT0390022)
				.HasColumnName("PCT0390022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390022")
				.IsOptional();

			Property(p => p.PCT0390023)
				.HasColumnName("PCT0390023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390023")
				.IsOptional();

			Property(p => p.PCT0390024)
				.HasColumnName("PCT0390024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390024")
				.IsOptional();

			Property(p => p.PCT0390025)
				.HasColumnName("PCT0390025")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390025")
				.IsOptional();

			Property(p => p.PCT0390026)
				.HasColumnName("PCT0390026")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390026")
				.IsOptional();

			Property(p => p.PCT0390027)
				.HasColumnName("PCT0390027")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390027")
				.IsOptional();

			Property(p => p.PCT0390028)
				.HasColumnName("PCT0390028")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390028")
				.IsOptional();

			Property(p => p.PCT0390029)
				.HasColumnName("PCT0390029")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390029")
				.IsOptional();

			Property(p => p.PCT0390030)
				.HasColumnName("PCT0390030")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390030")
				.IsOptional();

			Property(p => p.PCT0390031)
				.HasColumnName("PCT0390031")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390031")
				.IsOptional();

			Property(p => p.PCT0390032)
				.HasColumnName("PCT0390032")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390032")
				.IsOptional();

			Property(p => p.PCT0390033)
				.HasColumnName("PCT0390033")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390033")
				.IsOptional();

			Property(p => p.PCT0390034)
				.HasColumnName("PCT0390034")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390034")
				.IsOptional();

			Property(p => p.PCT0390035)
				.HasColumnName("PCT0390035")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390035")
				.IsOptional();

			Property(p => p.PCT0390036)
				.HasColumnName("PCT0390036")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390036")
				.IsOptional();

			Property(p => p.PCT0390037)
				.HasColumnName("PCT0390037")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390037")
				.IsOptional();

			Property(p => p.PCT0390038)
				.HasColumnName("PCT0390038")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390038")
				.IsOptional();

			Property(p => p.PCT0390039)
				.HasColumnName("PCT0390039")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390039")
				.IsOptional();

			Property(p => p.PCT0390040)
				.HasColumnName("PCT0390040")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390040")
				.IsOptional();

			Property(p => p.PCT0390041)
				.HasColumnName("PCT0390041")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390041")
				.IsOptional();

			Property(p => p.PCT0390042)
				.HasColumnName("PCT0390042")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390042")
				.IsOptional();

			Property(p => p.PCT0390043)
				.HasColumnName("PCT0390043")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390043")
				.IsOptional();

			Property(p => p.PCT0390044)
				.HasColumnName("PCT0390044")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390044")
				.IsOptional();

			Property(p => p.PCT0390045)
				.HasColumnName("PCT0390045")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390045")
				.IsOptional();

			Property(p => p.PCT0390046)
				.HasColumnName("PCT0390046")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390046")
				.IsOptional();

			Property(p => p.PCT0390047)
				.HasColumnName("PCT0390047")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390047")
				.IsOptional();

			Property(p => p.PCT0390048)
				.HasColumnName("PCT0390048")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390048")
				.IsOptional();

			Property(p => p.PCT0390049)
				.HasColumnName("PCT0390049")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390049")
				.IsOptional();

			Property(p => p.PCT0390050)
				.HasColumnName("PCT0390050")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390050")
				.IsOptional();

			Property(p => p.PCT0390051)
				.HasColumnName("PCT0390051")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390051")
				.IsOptional();

			Property(p => p.PCT0390052)
				.HasColumnName("PCT0390052")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390052")
				.IsOptional();

			Property(p => p.PCT0390053)
				.HasColumnName("PCT0390053")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390053")
				.IsOptional();

			Property(p => p.PCT0390054)
				.HasColumnName("PCT0390054")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390054")
				.IsOptional();

			Property(p => p.PCT0390055)
				.HasColumnName("PCT0390055")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390055")
				.IsOptional();

			Property(p => p.PCT0390056)
				.HasColumnName("PCT0390056")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390056")
				.IsOptional();

			Property(p => p.PCT0390057)
				.HasColumnName("PCT0390057")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390057")
				.IsOptional();

			Property(p => p.PCT0390058)
				.HasColumnName("PCT0390058")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390058")
				.IsOptional();

			Property(p => p.PCT0390059)
				.HasColumnName("PCT0390059")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390059")
				.IsOptional();

			Property(p => p.PCT0390060)
				.HasColumnName("PCT0390060")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390060")
				.IsOptional();

			Property(p => p.PCT0390061)
				.HasColumnName("PCT0390061")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390061")
				.IsOptional();

			Property(p => p.PCT0390062)
				.HasColumnName("PCT0390062")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390062")
				.IsOptional();

			Property(p => p.PCT0390063)
				.HasColumnName("PCT0390063")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390063")
				.IsOptional();

			Property(p => p.PCT0390064)
				.HasColumnName("PCT0390064")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390064")
				.IsOptional();

			Property(p => p.PCT0390065)
				.HasColumnName("PCT0390065")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390065")
				.IsOptional();

			Property(p => p.PCT0390066)
				.HasColumnName("PCT0390066")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390066")
				.IsOptional();

			Property(p => p.PCT0390067)
				.HasColumnName("PCT0390067")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390067")
				.IsOptional();

			Property(p => p.PCT0390068)
				.HasColumnName("PCT0390068")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390068")
				.IsOptional();

			Property(p => p.PCT0390069)
				.HasColumnName("PCT0390069")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390069")
				.IsOptional();

			Property(p => p.PCT0390070)
				.HasColumnName("PCT0390070")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390070")
				.IsOptional();

			Property(p => p.PCT0390071)
				.HasColumnName("PCT0390071")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390071")
				.IsOptional();

			Property(p => p.PCT0390072)
				.HasColumnName("PCT0390072")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390072")
				.IsOptional();

			Property(p => p.PCT0390073)
				.HasColumnName("PCT0390073")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390073")
				.IsOptional();

			Property(p => p.PCT0390074)
				.HasColumnName("PCT0390074")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390074")
				.IsOptional();

			Property(p => p.PCT0390075)
				.HasColumnName("PCT0390075")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390075")
				.IsOptional();

			Property(p => p.PCT0390076)
				.HasColumnName("PCT0390076")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390076")
				.IsOptional();

			Property(p => p.PCT0390077)
				.HasColumnName("PCT0390077")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390077")
				.IsOptional();

			Property(p => p.PCT0390078)
				.HasColumnName("PCT0390078")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390078")
				.IsOptional();

			Property(p => p.PCT0390079)
				.HasColumnName("PCT0390079")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390079")
				.IsOptional();

			Property(p => p.PCT0390080)
				.HasColumnName("PCT0390080")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390080")
				.IsOptional();

			Property(p => p.PCT0390081)
				.HasColumnName("PCT0390081")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390081")
				.IsOptional();

			Property(p => p.PCT0390082)
				.HasColumnName("PCT0390082")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390082")
				.IsOptional();

			Property(p => p.PCT0390083)
				.HasColumnName("PCT0390083")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390083")
				.IsOptional();

			Property(p => p.PCT0390084)
				.HasColumnName("PCT0390084")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390084")
				.IsOptional();

			Property(p => p.PCT0390085)
				.HasColumnName("PCT0390085")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390085")
				.IsOptional();

			Property(p => p.PCT0390086)
				.HasColumnName("PCT0390086")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390086")
				.IsOptional();

			Property(p => p.PCT0390087)
				.HasColumnName("PCT0390087")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390087")
				.IsOptional();

			Property(p => p.PCT0390088)
				.HasColumnName("PCT0390088")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390088")
				.IsOptional();

			Property(p => p.PCT0390089)
				.HasColumnName("PCT0390089")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390089")
				.IsOptional();

			Property(p => p.PCT0390090)
				.HasColumnName("PCT0390090")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390090")
				.IsOptional();

			Property(p => p.PCT0390091)
				.HasColumnName("PCT0390091")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390091")
				.IsOptional();

			Property(p => p.PCT0390092)
				.HasColumnName("PCT0390092")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390092")
				.IsOptional();

			Property(p => p.PCT0390093)
				.HasColumnName("PCT0390093")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390093")
				.IsOptional();

			Property(p => p.PCT0390094)
				.HasColumnName("PCT0390094")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390094")
				.IsOptional();

			Property(p => p.PCT0390095)
				.HasColumnName("PCT0390095")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390095")
				.IsOptional();

			Property(p => p.PCT0390096)
				.HasColumnName("PCT0390096")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390096")
				.IsOptional();

			Property(p => p.PCT0390097)
				.HasColumnName("PCT0390097")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390097")
				.IsOptional();

			Property(p => p.PCT0390098)
				.HasColumnName("PCT0390098")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390098")
				.IsOptional();

			Property(p => p.PCT0390099)
				.HasColumnName("PCT0390099")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390099")
				.IsOptional();

			Property(p => p.PCT0390100)
				.HasColumnName("PCT0390100")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390100")
				.IsOptional();

			Property(p => p.PCT0390101)
				.HasColumnName("PCT0390101")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390101")
				.IsOptional();

			Property(p => p.PCT0390102)
				.HasColumnName("PCT0390102")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390102")
				.IsOptional();

			Property(p => p.PCT0390103)
				.HasColumnName("PCT0390103")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390103")
				.IsOptional();

			Property(p => p.PCT0390104)
				.HasColumnName("PCT0390104")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390104")
				.IsOptional();

			Property(p => p.PCT0390105)
				.HasColumnName("PCT0390105")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390105")
				.IsOptional();

			Property(p => p.PCT0390106)
				.HasColumnName("PCT0390106")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390106")
				.IsOptional();

			Property(p => p.PCT0390107)
				.HasColumnName("PCT0390107")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390107")
				.IsOptional();

			Property(p => p.PCT0390108)
				.HasColumnName("PCT0390108")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390108")
				.IsOptional();

			Property(p => p.PCT0390109)
				.HasColumnName("PCT0390109")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390109")
				.IsOptional();

			Property(p => p.PCT0390110)
				.HasColumnName("PCT0390110")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390110")
				.IsOptional();

			Property(p => p.PCT0390111)
				.HasColumnName("PCT0390111")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390111")
				.IsOptional();

			Property(p => p.PCT0390112)
				.HasColumnName("PCT0390112")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390112")
				.IsOptional();

			Property(p => p.PCT0390113)
				.HasColumnName("PCT0390113")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390113")
				.IsOptional();

			Property(p => p.PCT0390114)
				.HasColumnName("PCT0390114")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390114")
				.IsOptional();

			Property(p => p.PCT0390115)
				.HasColumnName("PCT0390115")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390115")
				.IsOptional();

			Property(p => p.PCT0390116)
				.HasColumnName("PCT0390116")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390116")
				.IsOptional();

			Property(p => p.PCT0390117)
				.HasColumnName("PCT0390117")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390117")
				.IsOptional();

			Property(p => p.PCT0390118)
				.HasColumnName("PCT0390118")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390118")
				.IsOptional();

			Property(p => p.PCT0390119)
				.HasColumnName("PCT0390119")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390119")
				.IsOptional();

			Property(p => p.PCT0390120)
				.HasColumnName("PCT0390120")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390120")
				.IsOptional();

			Property(p => p.PCT0390121)
				.HasColumnName("PCT0390121")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390121")
				.IsOptional();

			Property(p => p.PCT0390122)
				.HasColumnName("PCT0390122")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390122")
				.IsOptional();

			Property(p => p.PCT0390123)
				.HasColumnName("PCT0390123")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390123")
				.IsOptional();

			Property(p => p.PCT0390124)
				.HasColumnName("PCT0390124")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390124")
				.IsOptional();

			Property(p => p.PCT0390125)
				.HasColumnName("PCT0390125")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390125")
				.IsOptional();

			Property(p => p.PCT0390126)
				.HasColumnName("PCT0390126")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390126")
				.IsOptional();

			Property(p => p.PCT0390127)
				.HasColumnName("PCT0390127")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390127")
				.IsOptional();

			Property(p => p.PCT0390128)
				.HasColumnName("PCT0390128")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390128")
				.IsOptional();

			Property(p => p.PCT0390129)
				.HasColumnName("PCT0390129")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390129")
				.IsOptional();

			Property(p => p.PCT0390130)
				.HasColumnName("PCT0390130")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390130")
				.IsOptional();

			Property(p => p.PCT0390131)
				.HasColumnName("PCT0390131")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390131")
				.IsOptional();

			Property(p => p.PCT0390132)
				.HasColumnName("PCT0390132")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390132")
				.IsOptional();

			Property(p => p.PCT0390133)
				.HasColumnName("PCT0390133")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390133")
				.IsOptional();

			Property(p => p.PCT0390134)
				.HasColumnName("PCT0390134")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390134")
				.IsOptional();

			Property(p => p.PCT0390135)
				.HasColumnName("PCT0390135")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390135")
				.IsOptional();

			Property(p => p.PCT0390136)
				.HasColumnName("PCT0390136")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390136")
				.IsOptional();

			Property(p => p.PCT0390137)
				.HasColumnName("PCT0390137")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390137")
				.IsOptional();

			Property(p => p.PCT0390138)
				.HasColumnName("PCT0390138")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390138")
				.IsOptional();

			Property(p => p.PCT0390139)
				.HasColumnName("PCT0390139")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390139")
				.IsOptional();

			Property(p => p.PCT0390140)
				.HasColumnName("PCT0390140")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390140")
				.IsOptional();

			Property(p => p.PCT0390141)
				.HasColumnName("PCT0390141")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390141")
				.IsOptional();

			Property(p => p.PCT0390142)
				.HasColumnName("PCT0390142")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390142")
				.IsOptional();

			Property(p => p.PCT0390143)
				.HasColumnName("PCT0390143")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390143")
				.IsOptional();

			Property(p => p.PCT0390144)
				.HasColumnName("PCT0390144")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390144")
				.IsOptional();

			Property(p => p.PCT0390145)
				.HasColumnName("PCT0390145")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390145")
				.IsOptional();

			Property(p => p.PCT0390146)
				.HasColumnName("PCT0390146")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390146")
				.IsOptional();

			Property(p => p.PCT0390147)
				.HasColumnName("PCT0390147")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390147")
				.IsOptional();

			Property(p => p.PCT0390148)
				.HasColumnName("PCT0390148")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390148")
				.IsOptional();

			Property(p => p.PCT0390149)
				.HasColumnName("PCT0390149")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390149")
				.IsOptional();

			Property(p => p.PCT0390150)
				.HasColumnName("PCT0390150")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390150")
				.IsOptional();

			Property(p => p.PCT0390151)
				.HasColumnName("PCT0390151")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390151")
				.IsOptional();

			Property(p => p.PCT0390152)
				.HasColumnName("PCT0390152")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390152")
				.IsOptional();

			Property(p => p.PCT0390153)
				.HasColumnName("PCT0390153")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390153")
				.IsOptional();

			Property(p => p.PCT0390154)
				.HasColumnName("PCT0390154")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390154")
				.IsOptional();

			Property(p => p.PCT0390155)
				.HasColumnName("PCT0390155")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390155")
				.IsOptional();

			Property(p => p.PCT0390156)
				.HasColumnName("PCT0390156")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390156")
				.IsOptional();

			Property(p => p.PCT0390157)
				.HasColumnName("PCT0390157")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390157")
				.IsOptional();

			Property(p => p.PCT0390158)
				.HasColumnName("PCT0390158")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390158")
				.IsOptional();

			Property(p => p.PCT0390159)
				.HasColumnName("PCT0390159")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390159")
				.IsOptional();

			Property(p => p.PCT0390160)
				.HasColumnName("PCT0390160")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390160")
				.IsOptional();

			Property(p => p.PCT0390161)
				.HasColumnName("PCT0390161")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390161")
				.IsOptional();

			Property(p => p.PCT0390162)
				.HasColumnName("PCT0390162")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390162")
				.IsOptional();

			Property(p => p.PCT0390163)
				.HasColumnName("PCT0390163")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390163")
				.IsOptional();

			Property(p => p.PCT0390164)
				.HasColumnName("PCT0390164")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390164")
				.IsOptional();

			Property(p => p.PCT0390165)
				.HasColumnName("PCT0390165")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390165")
				.IsOptional();

			Property(p => p.PCT0390166)
				.HasColumnName("PCT0390166")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390166")
				.IsOptional();

			Property(p => p.PCT0390167)
				.HasColumnName("PCT0390167")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390167")
				.IsOptional();

			Property(p => p.PCT0390168)
				.HasColumnName("PCT0390168")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390168")
				.IsOptional();

			Property(p => p.PCT0390169)
				.HasColumnName("PCT0390169")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390169")
				.IsOptional();

			Property(p => p.PCT0390170)
				.HasColumnName("PCT0390170")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390170")
				.IsOptional();

			Property(p => p.PCT0390171)
				.HasColumnName("PCT0390171")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390171")
				.IsOptional();

			Property(p => p.PCT0390172)
				.HasColumnName("PCT0390172")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390172")
				.IsOptional();

			Property(p => p.PCT0390173)
				.HasColumnName("PCT0390173")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390173")
				.IsOptional();

			Property(p => p.PCT0390174)
				.HasColumnName("PCT0390174")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390174")
				.IsOptional();

			Property(p => p.PCT0390175)
				.HasColumnName("PCT0390175")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390175")
				.IsOptional();

			Property(p => p.PCT0390176)
				.HasColumnName("PCT0390176")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390176")
				.IsOptional();

			Property(p => p.PCT0390177)
				.HasColumnName("PCT0390177")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390177")
				.IsOptional();

			Property(p => p.PCT0390178)
				.HasColumnName("PCT0390178")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390178")
				.IsOptional();

			Property(p => p.PCT0390179)
				.HasColumnName("PCT0390179")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390179")
				.IsOptional();

			Property(p => p.PCT0390180)
				.HasColumnName("PCT0390180")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390180")
				.IsOptional();

			Property(p => p.PCT0390181)
				.HasColumnName("PCT0390181")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390181")
				.IsOptional();

			Property(p => p.PCT0390182)
				.HasColumnName("PCT0390182")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390182")
				.IsOptional();

			Property(p => p.PCT0390183)
				.HasColumnName("PCT0390183")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390183")
				.IsOptional();

			Property(p => p.PCT0390184)
				.HasColumnName("PCT0390184")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390184")
				.IsOptional();

			Property(p => p.PCT0390185)
				.HasColumnName("PCT0390185")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390185")
				.IsOptional();

			Property(p => p.PCT0390186)
				.HasColumnName("PCT0390186")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390186")
				.IsOptional();

			Property(p => p.PCT0390187)
				.HasColumnName("PCT0390187")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390187")
				.IsOptional();

			Property(p => p.PCT0390188)
				.HasColumnName("PCT0390188")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390188")
				.IsOptional();

			Property(p => p.PCT0390189)
				.HasColumnName("PCT0390189")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390189")
				.IsOptional();

			Property(p => p.PCT0390190)
				.HasColumnName("PCT0390190")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390190")
				.IsOptional();

			Property(p => p.PCT0390191)
				.HasColumnName("PCT0390191")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390191")
				.IsOptional();

			Property(p => p.PCT0390192)
				.HasColumnName("PCT0390192")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390192")
				.IsOptional();

			Property(p => p.PCT0390193)
				.HasColumnName("PCT0390193")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390193")
				.IsOptional();

			Property(p => p.PCT0390194)
				.HasColumnName("PCT0390194")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390194")
				.IsOptional();

			Property(p => p.PCT0390195)
				.HasColumnName("PCT0390195")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0390195")
				.IsOptional();

			Property(p => p.PCT0400001)
				.HasColumnName("PCT0400001")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0400001")
				.IsOptional();

			Property(p => p.PCT0400002)
				.HasColumnName("PCT0400002")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0400002")
				.IsOptional();

			Property(p => p.PCT0400003)
				.HasColumnName("PCT0400003")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0400003")
				.IsOptional();

			Property(p => p.PCT0410001)
				.HasColumnName("PCT0410001")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0410001")
				.IsOptional();

			Property(p => p.PCT0410002)
				.HasColumnName("PCT0410002")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0410002")
				.IsOptional();

			Property(p => p.PCT0410003)
				.HasColumnName("PCT0410003")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0410003")
				.IsOptional();

			Property(p => p.PCT0420001)
				.HasColumnName("PCT0420001")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0420001")
				.IsOptional();

			Property(p => p.PCT0420002)
				.HasColumnName("PCT0420002")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0420002")
				.IsOptional();

			Property(p => p.PCT0420003)
				.HasColumnName("PCT0420003")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0420003")
				.IsOptional();

			Property(p => p.PCT0430001)
				.HasColumnName("PCT0430001")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0430001")
				.IsOptional();

			Property(p => p.PCT0430002)
				.HasColumnName("PCT0430002")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0430002")
				.IsOptional();

			Property(p => p.PCT0430003)
				.HasColumnName("PCT0430003")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0430003")
				.IsOptional();

			Property(p => p.PCT0440001)
				.HasColumnName("PCT0440001")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0440001")
				.IsOptional();

			Property(p => p.PCT0440002)
				.HasColumnName("PCT0440002")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0440002")
				.IsOptional();

			Property(p => p.PCT0440003)
				.HasColumnName("PCT0440003")
				.HasColumnOrder(214)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0440003")
				.IsOptional();

			Property(p => p.PCT0450001)
				.HasColumnName("PCT0450001")
				.HasColumnOrder(215)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0450001")
				.IsOptional();

			Property(p => p.PCT0450002)
				.HasColumnName("PCT0450002")
				.HasColumnOrder(216)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0450002")
				.IsOptional();

			Property(p => p.PCT0450003)
				.HasColumnName("PCT0450003")
				.HasColumnOrder(217)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0450003")
				.IsOptional();

			Property(p => p.PCT0460001)
				.HasColumnName("PCT0460001")
				.HasColumnOrder(218)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0460001")
				.IsOptional();

			Property(p => p.PCT0460002)
				.HasColumnName("PCT0460002")
				.HasColumnOrder(219)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0460002")
				.IsOptional();

			Property(p => p.PCT0460003)
				.HasColumnName("PCT0460003")
				.HasColumnOrder(220)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0460003")
				.IsOptional();

			Property(p => p.PCT0470001)
				.HasColumnName("PCT0470001")
				.HasColumnOrder(221)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0470001")
				.IsOptional();

			Property(p => p.PCT0470002)
				.HasColumnName("PCT0470002")
				.HasColumnOrder(222)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0470002")
				.IsOptional();

			Property(p => p.PCT0470003)
				.HasColumnName("PCT0470003")
				.HasColumnOrder(223)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0470003")
				.IsOptional();
		}
	}
}
