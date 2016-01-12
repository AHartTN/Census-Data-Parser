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

	public class SummaryTwo_SF2_Segment_03Map : EntityTypeConfiguration<SummaryTwo_SF2_Segment_03>
	{
		public SummaryTwo_SF2_Segment_03Map()
		{
			ToTable("SF2_Segment_03", "SummaryTwo");

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
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("CHARITER")
				.IsRequired();

			Property(p => p.CIFSN)
				.HasColumnName("CIFSN")
				.HasColumnOrder(3)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("CIFSN")
				.IsRequired();

			Property(p => p.LOGRECNO)
				.HasColumnName("LOGRECNO")
				.HasColumnOrder(4)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("LOGRECNO")
				.IsRequired();

			Property(p => p.PCT0030001)
				.HasColumnName("PCT0030001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030001")
				.IsOptional();

			Property(p => p.PCT0030002)
				.HasColumnName("PCT0030002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030002")
				.IsOptional();

			Property(p => p.PCT0030003)
				.HasColumnName("PCT0030003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030003")
				.IsOptional();

			Property(p => p.PCT0030004)
				.HasColumnName("PCT0030004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030004")
				.IsOptional();

			Property(p => p.PCT0030005)
				.HasColumnName("PCT0030005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030005")
				.IsOptional();

			Property(p => p.PCT0030006)
				.HasColumnName("PCT0030006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030006")
				.IsOptional();

			Property(p => p.PCT0030007)
				.HasColumnName("PCT0030007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030007")
				.IsOptional();

			Property(p => p.PCT0030008)
				.HasColumnName("PCT0030008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030008")
				.IsOptional();

			Property(p => p.PCT0030009)
				.HasColumnName("PCT0030009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030009")
				.IsOptional();

			Property(p => p.PCT0030010)
				.HasColumnName("PCT0030010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030010")
				.IsOptional();

			Property(p => p.PCT0030011)
				.HasColumnName("PCT0030011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030011")
				.IsOptional();

			Property(p => p.PCT0030012)
				.HasColumnName("PCT0030012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030012")
				.IsOptional();

			Property(p => p.PCT0030013)
				.HasColumnName("PCT0030013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030013")
				.IsOptional();

			Property(p => p.PCT0030014)
				.HasColumnName("PCT0030014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030014")
				.IsOptional();

			Property(p => p.PCT0030015)
				.HasColumnName("PCT0030015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030015")
				.IsOptional();

			Property(p => p.PCT0030016)
				.HasColumnName("PCT0030016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030016")
				.IsOptional();

			Property(p => p.PCT0030017)
				.HasColumnName("PCT0030017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030017")
				.IsOptional();

			Property(p => p.PCT0030018)
				.HasColumnName("PCT0030018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030018")
				.IsOptional();

			Property(p => p.PCT0030019)
				.HasColumnName("PCT0030019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030019")
				.IsOptional();

			Property(p => p.PCT0030020)
				.HasColumnName("PCT0030020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030020")
				.IsOptional();

			Property(p => p.PCT0030021)
				.HasColumnName("PCT0030021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030021")
				.IsOptional();

			Property(p => p.PCT0030022)
				.HasColumnName("PCT0030022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030022")
				.IsOptional();

			Property(p => p.PCT0030023)
				.HasColumnName("PCT0030023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030023")
				.IsOptional();

			Property(p => p.PCT0030024)
				.HasColumnName("PCT0030024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030024")
				.IsOptional();

			Property(p => p.PCT0030025)
				.HasColumnName("PCT0030025")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030025")
				.IsOptional();

			Property(p => p.PCT0030026)
				.HasColumnName("PCT0030026")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030026")
				.IsOptional();

			Property(p => p.PCT0030027)
				.HasColumnName("PCT0030027")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030027")
				.IsOptional();

			Property(p => p.PCT0030028)
				.HasColumnName("PCT0030028")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030028")
				.IsOptional();

			Property(p => p.PCT0030029)
				.HasColumnName("PCT0030029")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030029")
				.IsOptional();

			Property(p => p.PCT0030030)
				.HasColumnName("PCT0030030")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030030")
				.IsOptional();

			Property(p => p.PCT0030031)
				.HasColumnName("PCT0030031")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030031")
				.IsOptional();

			Property(p => p.PCT0030032)
				.HasColumnName("PCT0030032")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030032")
				.IsOptional();

			Property(p => p.PCT0030033)
				.HasColumnName("PCT0030033")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030033")
				.IsOptional();

			Property(p => p.PCT0030034)
				.HasColumnName("PCT0030034")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030034")
				.IsOptional();

			Property(p => p.PCT0030035)
				.HasColumnName("PCT0030035")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030035")
				.IsOptional();

			Property(p => p.PCT0030036)
				.HasColumnName("PCT0030036")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030036")
				.IsOptional();

			Property(p => p.PCT0030037)
				.HasColumnName("PCT0030037")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030037")
				.IsOptional();

			Property(p => p.PCT0030038)
				.HasColumnName("PCT0030038")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030038")
				.IsOptional();

			Property(p => p.PCT0030039)
				.HasColumnName("PCT0030039")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030039")
				.IsOptional();

			Property(p => p.PCT0030040)
				.HasColumnName("PCT0030040")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030040")
				.IsOptional();

			Property(p => p.PCT0030041)
				.HasColumnName("PCT0030041")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030041")
				.IsOptional();

			Property(p => p.PCT0030042)
				.HasColumnName("PCT0030042")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030042")
				.IsOptional();

			Property(p => p.PCT0030043)
				.HasColumnName("PCT0030043")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030043")
				.IsOptional();

			Property(p => p.PCT0030044)
				.HasColumnName("PCT0030044")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030044")
				.IsOptional();

			Property(p => p.PCT0030045)
				.HasColumnName("PCT0030045")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030045")
				.IsOptional();

			Property(p => p.PCT0030046)
				.HasColumnName("PCT0030046")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030046")
				.IsOptional();

			Property(p => p.PCT0030047)
				.HasColumnName("PCT0030047")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030047")
				.IsOptional();

			Property(p => p.PCT0030048)
				.HasColumnName("PCT0030048")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030048")
				.IsOptional();

			Property(p => p.PCT0030049)
				.HasColumnName("PCT0030049")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030049")
				.IsOptional();

			Property(p => p.PCT0030050)
				.HasColumnName("PCT0030050")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030050")
				.IsOptional();

			Property(p => p.PCT0030051)
				.HasColumnName("PCT0030051")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030051")
				.IsOptional();

			Property(p => p.PCT0030052)
				.HasColumnName("PCT0030052")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030052")
				.IsOptional();

			Property(p => p.PCT0030053)
				.HasColumnName("PCT0030053")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030053")
				.IsOptional();

			Property(p => p.PCT0030054)
				.HasColumnName("PCT0030054")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030054")
				.IsOptional();

			Property(p => p.PCT0030055)
				.HasColumnName("PCT0030055")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030055")
				.IsOptional();

			Property(p => p.PCT0030056)
				.HasColumnName("PCT0030056")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030056")
				.IsOptional();

			Property(p => p.PCT0030057)
				.HasColumnName("PCT0030057")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030057")
				.IsOptional();

			Property(p => p.PCT0030058)
				.HasColumnName("PCT0030058")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030058")
				.IsOptional();

			Property(p => p.PCT0030059)
				.HasColumnName("PCT0030059")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030059")
				.IsOptional();

			Property(p => p.PCT0030060)
				.HasColumnName("PCT0030060")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030060")
				.IsOptional();

			Property(p => p.PCT0030061)
				.HasColumnName("PCT0030061")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030061")
				.IsOptional();

			Property(p => p.PCT0030062)
				.HasColumnName("PCT0030062")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030062")
				.IsOptional();

			Property(p => p.PCT0030063)
				.HasColumnName("PCT0030063")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030063")
				.IsOptional();

			Property(p => p.PCT0030064)
				.HasColumnName("PCT0030064")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030064")
				.IsOptional();

			Property(p => p.PCT0030065)
				.HasColumnName("PCT0030065")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030065")
				.IsOptional();

			Property(p => p.PCT0030066)
				.HasColumnName("PCT0030066")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030066")
				.IsOptional();

			Property(p => p.PCT0030067)
				.HasColumnName("PCT0030067")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030067")
				.IsOptional();

			Property(p => p.PCT0030068)
				.HasColumnName("PCT0030068")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030068")
				.IsOptional();

			Property(p => p.PCT0030069)
				.HasColumnName("PCT0030069")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030069")
				.IsOptional();

			Property(p => p.PCT0030070)
				.HasColumnName("PCT0030070")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030070")
				.IsOptional();

			Property(p => p.PCT0030071)
				.HasColumnName("PCT0030071")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030071")
				.IsOptional();

			Property(p => p.PCT0030072)
				.HasColumnName("PCT0030072")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030072")
				.IsOptional();

			Property(p => p.PCT0030073)
				.HasColumnName("PCT0030073")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030073")
				.IsOptional();

			Property(p => p.PCT0030074)
				.HasColumnName("PCT0030074")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030074")
				.IsOptional();

			Property(p => p.PCT0030075)
				.HasColumnName("PCT0030075")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030075")
				.IsOptional();

			Property(p => p.PCT0030076)
				.HasColumnName("PCT0030076")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030076")
				.IsOptional();

			Property(p => p.PCT0030077)
				.HasColumnName("PCT0030077")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030077")
				.IsOptional();

			Property(p => p.PCT0030078)
				.HasColumnName("PCT0030078")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030078")
				.IsOptional();

			Property(p => p.PCT0030079)
				.HasColumnName("PCT0030079")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030079")
				.IsOptional();

			Property(p => p.PCT0030080)
				.HasColumnName("PCT0030080")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030080")
				.IsOptional();

			Property(p => p.PCT0030081)
				.HasColumnName("PCT0030081")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030081")
				.IsOptional();

			Property(p => p.PCT0030082)
				.HasColumnName("PCT0030082")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030082")
				.IsOptional();

			Property(p => p.PCT0030083)
				.HasColumnName("PCT0030083")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030083")
				.IsOptional();

			Property(p => p.PCT0030084)
				.HasColumnName("PCT0030084")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030084")
				.IsOptional();

			Property(p => p.PCT0030085)
				.HasColumnName("PCT0030085")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030085")
				.IsOptional();

			Property(p => p.PCT0030086)
				.HasColumnName("PCT0030086")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030086")
				.IsOptional();

			Property(p => p.PCT0030087)
				.HasColumnName("PCT0030087")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030087")
				.IsOptional();

			Property(p => p.PCT0030088)
				.HasColumnName("PCT0030088")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030088")
				.IsOptional();

			Property(p => p.PCT0030089)
				.HasColumnName("PCT0030089")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030089")
				.IsOptional();

			Property(p => p.PCT0030090)
				.HasColumnName("PCT0030090")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030090")
				.IsOptional();

			Property(p => p.PCT0030091)
				.HasColumnName("PCT0030091")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030091")
				.IsOptional();

			Property(p => p.PCT0030092)
				.HasColumnName("PCT0030092")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030092")
				.IsOptional();

			Property(p => p.PCT0030093)
				.HasColumnName("PCT0030093")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030093")
				.IsOptional();

			Property(p => p.PCT0030094)
				.HasColumnName("PCT0030094")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030094")
				.IsOptional();

			Property(p => p.PCT0030095)
				.HasColumnName("PCT0030095")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030095")
				.IsOptional();

			Property(p => p.PCT0030096)
				.HasColumnName("PCT0030096")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030096")
				.IsOptional();

			Property(p => p.PCT0030097)
				.HasColumnName("PCT0030097")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030097")
				.IsOptional();

			Property(p => p.PCT0030098)
				.HasColumnName("PCT0030098")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030098")
				.IsOptional();

			Property(p => p.PCT0030099)
				.HasColumnName("PCT0030099")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030099")
				.IsOptional();

			Property(p => p.PCT0030100)
				.HasColumnName("PCT0030100")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030100")
				.IsOptional();

			Property(p => p.PCT0030101)
				.HasColumnName("PCT0030101")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030101")
				.IsOptional();

			Property(p => p.PCT0030102)
				.HasColumnName("PCT0030102")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030102")
				.IsOptional();

			Property(p => p.PCT0030103)
				.HasColumnName("PCT0030103")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030103")
				.IsOptional();

			Property(p => p.PCT0030104)
				.HasColumnName("PCT0030104")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030104")
				.IsOptional();

			Property(p => p.PCT0030105)
				.HasColumnName("PCT0030105")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030105")
				.IsOptional();

			Property(p => p.PCT0030106)
				.HasColumnName("PCT0030106")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030106")
				.IsOptional();

			Property(p => p.PCT0030107)
				.HasColumnName("PCT0030107")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030107")
				.IsOptional();

			Property(p => p.PCT0030108)
				.HasColumnName("PCT0030108")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030108")
				.IsOptional();

			Property(p => p.PCT0030109)
				.HasColumnName("PCT0030109")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030109")
				.IsOptional();

			Property(p => p.PCT0030110)
				.HasColumnName("PCT0030110")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030110")
				.IsOptional();

			Property(p => p.PCT0030111)
				.HasColumnName("PCT0030111")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030111")
				.IsOptional();

			Property(p => p.PCT0030112)
				.HasColumnName("PCT0030112")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030112")
				.IsOptional();

			Property(p => p.PCT0030113)
				.HasColumnName("PCT0030113")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030113")
				.IsOptional();

			Property(p => p.PCT0030114)
				.HasColumnName("PCT0030114")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030114")
				.IsOptional();

			Property(p => p.PCT0030115)
				.HasColumnName("PCT0030115")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030115")
				.IsOptional();

			Property(p => p.PCT0030116)
				.HasColumnName("PCT0030116")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030116")
				.IsOptional();

			Property(p => p.PCT0030117)
				.HasColumnName("PCT0030117")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030117")
				.IsOptional();

			Property(p => p.PCT0030118)
				.HasColumnName("PCT0030118")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030118")
				.IsOptional();

			Property(p => p.PCT0030119)
				.HasColumnName("PCT0030119")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030119")
				.IsOptional();

			Property(p => p.PCT0030120)
				.HasColumnName("PCT0030120")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030120")
				.IsOptional();

			Property(p => p.PCT0030121)
				.HasColumnName("PCT0030121")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030121")
				.IsOptional();

			Property(p => p.PCT0030122)
				.HasColumnName("PCT0030122")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030122")
				.IsOptional();

			Property(p => p.PCT0030123)
				.HasColumnName("PCT0030123")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030123")
				.IsOptional();

			Property(p => p.PCT0030124)
				.HasColumnName("PCT0030124")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030124")
				.IsOptional();

			Property(p => p.PCT0030125)
				.HasColumnName("PCT0030125")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030125")
				.IsOptional();

			Property(p => p.PCT0030126)
				.HasColumnName("PCT0030126")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030126")
				.IsOptional();

			Property(p => p.PCT0030127)
				.HasColumnName("PCT0030127")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030127")
				.IsOptional();

			Property(p => p.PCT0030128)
				.HasColumnName("PCT0030128")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030128")
				.IsOptional();

			Property(p => p.PCT0030129)
				.HasColumnName("PCT0030129")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030129")
				.IsOptional();

			Property(p => p.PCT0030130)
				.HasColumnName("PCT0030130")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030130")
				.IsOptional();

			Property(p => p.PCT0030131)
				.HasColumnName("PCT0030131")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030131")
				.IsOptional();

			Property(p => p.PCT0030132)
				.HasColumnName("PCT0030132")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030132")
				.IsOptional();

			Property(p => p.PCT0030133)
				.HasColumnName("PCT0030133")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030133")
				.IsOptional();

			Property(p => p.PCT0030134)
				.HasColumnName("PCT0030134")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030134")
				.IsOptional();

			Property(p => p.PCT0030135)
				.HasColumnName("PCT0030135")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030135")
				.IsOptional();

			Property(p => p.PCT0030136)
				.HasColumnName("PCT0030136")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030136")
				.IsOptional();

			Property(p => p.PCT0030137)
				.HasColumnName("PCT0030137")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030137")
				.IsOptional();

			Property(p => p.PCT0030138)
				.HasColumnName("PCT0030138")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030138")
				.IsOptional();

			Property(p => p.PCT0030139)
				.HasColumnName("PCT0030139")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030139")
				.IsOptional();

			Property(p => p.PCT0030140)
				.HasColumnName("PCT0030140")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030140")
				.IsOptional();

			Property(p => p.PCT0030141)
				.HasColumnName("PCT0030141")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030141")
				.IsOptional();

			Property(p => p.PCT0030142)
				.HasColumnName("PCT0030142")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030142")
				.IsOptional();

			Property(p => p.PCT0030143)
				.HasColumnName("PCT0030143")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030143")
				.IsOptional();

			Property(p => p.PCT0030144)
				.HasColumnName("PCT0030144")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030144")
				.IsOptional();

			Property(p => p.PCT0030145)
				.HasColumnName("PCT0030145")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030145")
				.IsOptional();

			Property(p => p.PCT0030146)
				.HasColumnName("PCT0030146")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030146")
				.IsOptional();

			Property(p => p.PCT0030147)
				.HasColumnName("PCT0030147")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030147")
				.IsOptional();

			Property(p => p.PCT0030148)
				.HasColumnName("PCT0030148")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030148")
				.IsOptional();

			Property(p => p.PCT0030149)
				.HasColumnName("PCT0030149")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030149")
				.IsOptional();

			Property(p => p.PCT0030150)
				.HasColumnName("PCT0030150")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030150")
				.IsOptional();

			Property(p => p.PCT0030151)
				.HasColumnName("PCT0030151")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030151")
				.IsOptional();

			Property(p => p.PCT0030152)
				.HasColumnName("PCT0030152")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030152")
				.IsOptional();

			Property(p => p.PCT0030153)
				.HasColumnName("PCT0030153")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030153")
				.IsOptional();

			Property(p => p.PCT0030154)
				.HasColumnName("PCT0030154")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030154")
				.IsOptional();

			Property(p => p.PCT0030155)
				.HasColumnName("PCT0030155")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030155")
				.IsOptional();

			Property(p => p.PCT0030156)
				.HasColumnName("PCT0030156")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030156")
				.IsOptional();

			Property(p => p.PCT0030157)
				.HasColumnName("PCT0030157")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030157")
				.IsOptional();

			Property(p => p.PCT0030158)
				.HasColumnName("PCT0030158")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030158")
				.IsOptional();

			Property(p => p.PCT0030159)
				.HasColumnName("PCT0030159")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030159")
				.IsOptional();

			Property(p => p.PCT0030160)
				.HasColumnName("PCT0030160")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030160")
				.IsOptional();

			Property(p => p.PCT0030161)
				.HasColumnName("PCT0030161")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030161")
				.IsOptional();

			Property(p => p.PCT0030162)
				.HasColumnName("PCT0030162")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030162")
				.IsOptional();

			Property(p => p.PCT0030163)
				.HasColumnName("PCT0030163")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030163")
				.IsOptional();

			Property(p => p.PCT0030164)
				.HasColumnName("PCT0030164")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030164")
				.IsOptional();

			Property(p => p.PCT0030165)
				.HasColumnName("PCT0030165")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030165")
				.IsOptional();

			Property(p => p.PCT0030166)
				.HasColumnName("PCT0030166")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030166")
				.IsOptional();

			Property(p => p.PCT0030167)
				.HasColumnName("PCT0030167")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030167")
				.IsOptional();

			Property(p => p.PCT0030168)
				.HasColumnName("PCT0030168")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030168")
				.IsOptional();

			Property(p => p.PCT0030169)
				.HasColumnName("PCT0030169")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030169")
				.IsOptional();

			Property(p => p.PCT0030170)
				.HasColumnName("PCT0030170")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030170")
				.IsOptional();

			Property(p => p.PCT0030171)
				.HasColumnName("PCT0030171")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030171")
				.IsOptional();

			Property(p => p.PCT0030172)
				.HasColumnName("PCT0030172")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030172")
				.IsOptional();

			Property(p => p.PCT0030173)
				.HasColumnName("PCT0030173")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030173")
				.IsOptional();

			Property(p => p.PCT0030174)
				.HasColumnName("PCT0030174")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030174")
				.IsOptional();

			Property(p => p.PCT0030175)
				.HasColumnName("PCT0030175")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030175")
				.IsOptional();

			Property(p => p.PCT0030176)
				.HasColumnName("PCT0030176")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030176")
				.IsOptional();

			Property(p => p.PCT0030177)
				.HasColumnName("PCT0030177")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030177")
				.IsOptional();

			Property(p => p.PCT0030178)
				.HasColumnName("PCT0030178")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030178")
				.IsOptional();

			Property(p => p.PCT0030179)
				.HasColumnName("PCT0030179")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030179")
				.IsOptional();

			Property(p => p.PCT0030180)
				.HasColumnName("PCT0030180")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030180")
				.IsOptional();

			Property(p => p.PCT0030181)
				.HasColumnName("PCT0030181")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030181")
				.IsOptional();

			Property(p => p.PCT0030182)
				.HasColumnName("PCT0030182")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030182")
				.IsOptional();

			Property(p => p.PCT0030183)
				.HasColumnName("PCT0030183")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030183")
				.IsOptional();

			Property(p => p.PCT0030184)
				.HasColumnName("PCT0030184")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030184")
				.IsOptional();

			Property(p => p.PCT0030185)
				.HasColumnName("PCT0030185")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030185")
				.IsOptional();

			Property(p => p.PCT0030186)
				.HasColumnName("PCT0030186")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030186")
				.IsOptional();

			Property(p => p.PCT0030187)
				.HasColumnName("PCT0030187")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030187")
				.IsOptional();

			Property(p => p.PCT0030188)
				.HasColumnName("PCT0030188")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030188")
				.IsOptional();

			Property(p => p.PCT0030189)
				.HasColumnName("PCT0030189")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030189")
				.IsOptional();

			Property(p => p.PCT0030190)
				.HasColumnName("PCT0030190")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030190")
				.IsOptional();

			Property(p => p.PCT0030191)
				.HasColumnName("PCT0030191")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030191")
				.IsOptional();

			Property(p => p.PCT0030192)
				.HasColumnName("PCT0030192")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030192")
				.IsOptional();

			Property(p => p.PCT0030193)
				.HasColumnName("PCT0030193")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030193")
				.IsOptional();

			Property(p => p.PCT0030194)
				.HasColumnName("PCT0030194")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030194")
				.IsOptional();

			Property(p => p.PCT0030195)
				.HasColumnName("PCT0030195")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030195")
				.IsOptional();

			Property(p => p.PCT0030196)
				.HasColumnName("PCT0030196")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030196")
				.IsOptional();

			Property(p => p.PCT0030197)
				.HasColumnName("PCT0030197")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030197")
				.IsOptional();

			Property(p => p.PCT0030198)
				.HasColumnName("PCT0030198")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030198")
				.IsOptional();

			Property(p => p.PCT0030199)
				.HasColumnName("PCT0030199")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030199")
				.IsOptional();

			Property(p => p.PCT0030200)
				.HasColumnName("PCT0030200")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030200")
				.IsOptional();

			Property(p => p.PCT0030201)
				.HasColumnName("PCT0030201")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030201")
				.IsOptional();

			Property(p => p.PCT0030202)
				.HasColumnName("PCT0030202")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030202")
				.IsOptional();

			Property(p => p.PCT0030203)
				.HasColumnName("PCT0030203")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030203")
				.IsOptional();

			Property(p => p.PCT0030204)
				.HasColumnName("PCT0030204")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030204")
				.IsOptional();

			Property(p => p.PCT0030205)
				.HasColumnName("PCT0030205")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030205")
				.IsOptional();

			Property(p => p.PCT0030206)
				.HasColumnName("PCT0030206")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030206")
				.IsOptional();

			Property(p => p.PCT0030207)
				.HasColumnName("PCT0030207")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030207")
				.IsOptional();

			Property(p => p.PCT0030208)
				.HasColumnName("PCT0030208")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030208")
				.IsOptional();

			Property(p => p.PCT0030209)
				.HasColumnName("PCT0030209")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0030209")
				.IsOptional();

			Property(p => p.PCT0040001)
				.HasColumnName("PCT0040001")
				.HasColumnOrder(214)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0040001")
				.IsOptional();

			Property(p => p.PCT0040002)
				.HasColumnName("PCT0040002")
				.HasColumnOrder(215)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0040002")
				.IsOptional();

			Property(p => p.PCT0040003)
				.HasColumnName("PCT0040003")
				.HasColumnOrder(216)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0040003")
				.IsOptional();
		}
	}
}
