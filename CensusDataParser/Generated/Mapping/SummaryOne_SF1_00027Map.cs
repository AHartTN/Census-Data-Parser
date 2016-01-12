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

	public class SummaryOne_SF1_00027Map : EntityTypeConfiguration<SummaryOne_SF1_00027>
	{
		public SummaryOne_SF1_00027Map()
		{
			ToTable("SF1_00027", "SummaryOne");

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

			Property(p => p.PCT012H001)
				.HasColumnName("PCT012H001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H001")
				.IsOptional();

			Property(p => p.PCT012H002)
				.HasColumnName("PCT012H002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H002")
				.IsOptional();

			Property(p => p.PCT012H003)
				.HasColumnName("PCT012H003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H003")
				.IsOptional();

			Property(p => p.PCT012H004)
				.HasColumnName("PCT012H004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H004")
				.IsOptional();

			Property(p => p.PCT012H005)
				.HasColumnName("PCT012H005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H005")
				.IsOptional();

			Property(p => p.PCT012H006)
				.HasColumnName("PCT012H006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H006")
				.IsOptional();

			Property(p => p.PCT012H007)
				.HasColumnName("PCT012H007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H007")
				.IsOptional();

			Property(p => p.PCT012H008)
				.HasColumnName("PCT012H008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H008")
				.IsOptional();

			Property(p => p.PCT012H009)
				.HasColumnName("PCT012H009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H009")
				.IsOptional();

			Property(p => p.PCT012H010)
				.HasColumnName("PCT012H010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H010")
				.IsOptional();

			Property(p => p.PCT012H011)
				.HasColumnName("PCT012H011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H011")
				.IsOptional();

			Property(p => p.PCT012H012)
				.HasColumnName("PCT012H012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H012")
				.IsOptional();

			Property(p => p.PCT012H013)
				.HasColumnName("PCT012H013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H013")
				.IsOptional();

			Property(p => p.PCT012H014)
				.HasColumnName("PCT012H014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H014")
				.IsOptional();

			Property(p => p.PCT012H015)
				.HasColumnName("PCT012H015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H015")
				.IsOptional();

			Property(p => p.PCT012H016)
				.HasColumnName("PCT012H016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H016")
				.IsOptional();

			Property(p => p.PCT012H017)
				.HasColumnName("PCT012H017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H017")
				.IsOptional();

			Property(p => p.PCT012H018)
				.HasColumnName("PCT012H018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H018")
				.IsOptional();

			Property(p => p.PCT012H019)
				.HasColumnName("PCT012H019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H019")
				.IsOptional();

			Property(p => p.PCT012H020)
				.HasColumnName("PCT012H020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H020")
				.IsOptional();

			Property(p => p.PCT012H021)
				.HasColumnName("PCT012H021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H021")
				.IsOptional();

			Property(p => p.PCT012H022)
				.HasColumnName("PCT012H022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H022")
				.IsOptional();

			Property(p => p.PCT012H023)
				.HasColumnName("PCT012H023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H023")
				.IsOptional();

			Property(p => p.PCT012H024)
				.HasColumnName("PCT012H024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H024")
				.IsOptional();

			Property(p => p.PCT012H025)
				.HasColumnName("PCT012H025")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H025")
				.IsOptional();

			Property(p => p.PCT012H026)
				.HasColumnName("PCT012H026")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H026")
				.IsOptional();

			Property(p => p.PCT012H027)
				.HasColumnName("PCT012H027")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H027")
				.IsOptional();

			Property(p => p.PCT012H028)
				.HasColumnName("PCT012H028")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H028")
				.IsOptional();

			Property(p => p.PCT012H029)
				.HasColumnName("PCT012H029")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H029")
				.IsOptional();

			Property(p => p.PCT012H030)
				.HasColumnName("PCT012H030")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H030")
				.IsOptional();

			Property(p => p.PCT012H031)
				.HasColumnName("PCT012H031")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H031")
				.IsOptional();

			Property(p => p.PCT012H032)
				.HasColumnName("PCT012H032")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H032")
				.IsOptional();

			Property(p => p.PCT012H033)
				.HasColumnName("PCT012H033")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H033")
				.IsOptional();

			Property(p => p.PCT012H034)
				.HasColumnName("PCT012H034")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H034")
				.IsOptional();

			Property(p => p.PCT012H035)
				.HasColumnName("PCT012H035")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H035")
				.IsOptional();

			Property(p => p.PCT012H036)
				.HasColumnName("PCT012H036")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H036")
				.IsOptional();

			Property(p => p.PCT012H037)
				.HasColumnName("PCT012H037")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H037")
				.IsOptional();

			Property(p => p.PCT012H038)
				.HasColumnName("PCT012H038")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H038")
				.IsOptional();

			Property(p => p.PCT012H039)
				.HasColumnName("PCT012H039")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H039")
				.IsOptional();

			Property(p => p.PCT012H040)
				.HasColumnName("PCT012H040")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H040")
				.IsOptional();

			Property(p => p.PCT012H041)
				.HasColumnName("PCT012H041")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H041")
				.IsOptional();

			Property(p => p.PCT012H042)
				.HasColumnName("PCT012H042")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H042")
				.IsOptional();

			Property(p => p.PCT012H043)
				.HasColumnName("PCT012H043")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H043")
				.IsOptional();

			Property(p => p.PCT012H044)
				.HasColumnName("PCT012H044")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H044")
				.IsOptional();

			Property(p => p.PCT012H045)
				.HasColumnName("PCT012H045")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H045")
				.IsOptional();

			Property(p => p.PCT012H046)
				.HasColumnName("PCT012H046")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H046")
				.IsOptional();

			Property(p => p.PCT012H047)
				.HasColumnName("PCT012H047")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H047")
				.IsOptional();

			Property(p => p.PCT012H048)
				.HasColumnName("PCT012H048")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H048")
				.IsOptional();

			Property(p => p.PCT012H049)
				.HasColumnName("PCT012H049")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H049")
				.IsOptional();

			Property(p => p.PCT012H050)
				.HasColumnName("PCT012H050")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H050")
				.IsOptional();

			Property(p => p.PCT012H051)
				.HasColumnName("PCT012H051")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H051")
				.IsOptional();

			Property(p => p.PCT012H052)
				.HasColumnName("PCT012H052")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H052")
				.IsOptional();

			Property(p => p.PCT012H053)
				.HasColumnName("PCT012H053")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H053")
				.IsOptional();

			Property(p => p.PCT012H054)
				.HasColumnName("PCT012H054")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H054")
				.IsOptional();

			Property(p => p.PCT012H055)
				.HasColumnName("PCT012H055")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H055")
				.IsOptional();

			Property(p => p.PCT012H056)
				.HasColumnName("PCT012H056")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H056")
				.IsOptional();

			Property(p => p.PCT012H057)
				.HasColumnName("PCT012H057")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H057")
				.IsOptional();

			Property(p => p.PCT012H058)
				.HasColumnName("PCT012H058")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H058")
				.IsOptional();

			Property(p => p.PCT012H059)
				.HasColumnName("PCT012H059")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H059")
				.IsOptional();

			Property(p => p.PCT012H060)
				.HasColumnName("PCT012H060")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H060")
				.IsOptional();

			Property(p => p.PCT012H061)
				.HasColumnName("PCT012H061")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H061")
				.IsOptional();

			Property(p => p.PCT012H062)
				.HasColumnName("PCT012H062")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H062")
				.IsOptional();

			Property(p => p.PCT012H063)
				.HasColumnName("PCT012H063")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H063")
				.IsOptional();

			Property(p => p.PCT012H064)
				.HasColumnName("PCT012H064")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H064")
				.IsOptional();

			Property(p => p.PCT012H065)
				.HasColumnName("PCT012H065")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H065")
				.IsOptional();

			Property(p => p.PCT012H066)
				.HasColumnName("PCT012H066")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H066")
				.IsOptional();

			Property(p => p.PCT012H067)
				.HasColumnName("PCT012H067")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H067")
				.IsOptional();

			Property(p => p.PCT012H068)
				.HasColumnName("PCT012H068")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H068")
				.IsOptional();

			Property(p => p.PCT012H069)
				.HasColumnName("PCT012H069")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H069")
				.IsOptional();

			Property(p => p.PCT012H070)
				.HasColumnName("PCT012H070")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H070")
				.IsOptional();

			Property(p => p.PCT012H071)
				.HasColumnName("PCT012H071")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H071")
				.IsOptional();

			Property(p => p.PCT012H072)
				.HasColumnName("PCT012H072")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H072")
				.IsOptional();

			Property(p => p.PCT012H073)
				.HasColumnName("PCT012H073")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H073")
				.IsOptional();

			Property(p => p.PCT012H074)
				.HasColumnName("PCT012H074")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H074")
				.IsOptional();

			Property(p => p.PCT012H075)
				.HasColumnName("PCT012H075")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H075")
				.IsOptional();

			Property(p => p.PCT012H076)
				.HasColumnName("PCT012H076")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H076")
				.IsOptional();

			Property(p => p.PCT012H077)
				.HasColumnName("PCT012H077")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H077")
				.IsOptional();

			Property(p => p.PCT012H078)
				.HasColumnName("PCT012H078")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H078")
				.IsOptional();

			Property(p => p.PCT012H079)
				.HasColumnName("PCT012H079")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H079")
				.IsOptional();

			Property(p => p.PCT012H080)
				.HasColumnName("PCT012H080")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H080")
				.IsOptional();

			Property(p => p.PCT012H081)
				.HasColumnName("PCT012H081")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H081")
				.IsOptional();

			Property(p => p.PCT012H082)
				.HasColumnName("PCT012H082")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H082")
				.IsOptional();

			Property(p => p.PCT012H083)
				.HasColumnName("PCT012H083")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H083")
				.IsOptional();

			Property(p => p.PCT012H084)
				.HasColumnName("PCT012H084")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H084")
				.IsOptional();

			Property(p => p.PCT012H085)
				.HasColumnName("PCT012H085")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H085")
				.IsOptional();

			Property(p => p.PCT012H086)
				.HasColumnName("PCT012H086")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H086")
				.IsOptional();

			Property(p => p.PCT012H087)
				.HasColumnName("PCT012H087")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H087")
				.IsOptional();

			Property(p => p.PCT012H088)
				.HasColumnName("PCT012H088")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H088")
				.IsOptional();

			Property(p => p.PCT012H089)
				.HasColumnName("PCT012H089")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H089")
				.IsOptional();

			Property(p => p.PCT012H090)
				.HasColumnName("PCT012H090")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H090")
				.IsOptional();

			Property(p => p.PCT012H091)
				.HasColumnName("PCT012H091")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H091")
				.IsOptional();

			Property(p => p.PCT012H092)
				.HasColumnName("PCT012H092")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H092")
				.IsOptional();

			Property(p => p.PCT012H093)
				.HasColumnName("PCT012H093")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H093")
				.IsOptional();

			Property(p => p.PCT012H094)
				.HasColumnName("PCT012H094")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H094")
				.IsOptional();

			Property(p => p.PCT012H095)
				.HasColumnName("PCT012H095")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H095")
				.IsOptional();

			Property(p => p.PCT012H096)
				.HasColumnName("PCT012H096")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H096")
				.IsOptional();

			Property(p => p.PCT012H097)
				.HasColumnName("PCT012H097")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H097")
				.IsOptional();

			Property(p => p.PCT012H098)
				.HasColumnName("PCT012H098")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H098")
				.IsOptional();

			Property(p => p.PCT012H099)
				.HasColumnName("PCT012H099")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H099")
				.IsOptional();

			Property(p => p.PCT012H100)
				.HasColumnName("PCT012H100")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H100")
				.IsOptional();

			Property(p => p.PCT012H101)
				.HasColumnName("PCT012H101")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H101")
				.IsOptional();

			Property(p => p.PCT012H102)
				.HasColumnName("PCT012H102")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H102")
				.IsOptional();

			Property(p => p.PCT012H103)
				.HasColumnName("PCT012H103")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H103")
				.IsOptional();

			Property(p => p.PCT012H104)
				.HasColumnName("PCT012H104")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H104")
				.IsOptional();

			Property(p => p.PCT012H105)
				.HasColumnName("PCT012H105")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H105")
				.IsOptional();

			Property(p => p.PCT012H106)
				.HasColumnName("PCT012H106")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H106")
				.IsOptional();

			Property(p => p.PCT012H107)
				.HasColumnName("PCT012H107")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H107")
				.IsOptional();

			Property(p => p.PCT012H108)
				.HasColumnName("PCT012H108")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H108")
				.IsOptional();

			Property(p => p.PCT012H109)
				.HasColumnName("PCT012H109")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H109")
				.IsOptional();

			Property(p => p.PCT012H110)
				.HasColumnName("PCT012H110")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H110")
				.IsOptional();

			Property(p => p.PCT012H111)
				.HasColumnName("PCT012H111")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H111")
				.IsOptional();

			Property(p => p.PCT012H112)
				.HasColumnName("PCT012H112")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H112")
				.IsOptional();

			Property(p => p.PCT012H113)
				.HasColumnName("PCT012H113")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H113")
				.IsOptional();

			Property(p => p.PCT012H114)
				.HasColumnName("PCT012H114")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H114")
				.IsOptional();

			Property(p => p.PCT012H115)
				.HasColumnName("PCT012H115")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H115")
				.IsOptional();

			Property(p => p.PCT012H116)
				.HasColumnName("PCT012H116")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H116")
				.IsOptional();

			Property(p => p.PCT012H117)
				.HasColumnName("PCT012H117")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H117")
				.IsOptional();

			Property(p => p.PCT012H118)
				.HasColumnName("PCT012H118")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H118")
				.IsOptional();

			Property(p => p.PCT012H119)
				.HasColumnName("PCT012H119")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H119")
				.IsOptional();

			Property(p => p.PCT012H120)
				.HasColumnName("PCT012H120")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H120")
				.IsOptional();

			Property(p => p.PCT012H121)
				.HasColumnName("PCT012H121")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H121")
				.IsOptional();

			Property(p => p.PCT012H122)
				.HasColumnName("PCT012H122")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H122")
				.IsOptional();

			Property(p => p.PCT012H123)
				.HasColumnName("PCT012H123")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H123")
				.IsOptional();

			Property(p => p.PCT012H124)
				.HasColumnName("PCT012H124")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H124")
				.IsOptional();

			Property(p => p.PCT012H125)
				.HasColumnName("PCT012H125")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H125")
				.IsOptional();

			Property(p => p.PCT012H126)
				.HasColumnName("PCT012H126")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H126")
				.IsOptional();

			Property(p => p.PCT012H127)
				.HasColumnName("PCT012H127")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H127")
				.IsOptional();

			Property(p => p.PCT012H128)
				.HasColumnName("PCT012H128")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H128")
				.IsOptional();

			Property(p => p.PCT012H129)
				.HasColumnName("PCT012H129")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H129")
				.IsOptional();

			Property(p => p.PCT012H130)
				.HasColumnName("PCT012H130")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H130")
				.IsOptional();

			Property(p => p.PCT012H131)
				.HasColumnName("PCT012H131")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H131")
				.IsOptional();

			Property(p => p.PCT012H132)
				.HasColumnName("PCT012H132")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H132")
				.IsOptional();

			Property(p => p.PCT012H133)
				.HasColumnName("PCT012H133")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H133")
				.IsOptional();

			Property(p => p.PCT012H134)
				.HasColumnName("PCT012H134")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H134")
				.IsOptional();

			Property(p => p.PCT012H135)
				.HasColumnName("PCT012H135")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H135")
				.IsOptional();

			Property(p => p.PCT012H136)
				.HasColumnName("PCT012H136")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H136")
				.IsOptional();

			Property(p => p.PCT012H137)
				.HasColumnName("PCT012H137")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H137")
				.IsOptional();

			Property(p => p.PCT012H138)
				.HasColumnName("PCT012H138")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H138")
				.IsOptional();

			Property(p => p.PCT012H139)
				.HasColumnName("PCT012H139")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H139")
				.IsOptional();

			Property(p => p.PCT012H140)
				.HasColumnName("PCT012H140")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H140")
				.IsOptional();

			Property(p => p.PCT012H141)
				.HasColumnName("PCT012H141")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H141")
				.IsOptional();

			Property(p => p.PCT012H142)
				.HasColumnName("PCT012H142")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H142")
				.IsOptional();

			Property(p => p.PCT012H143)
				.HasColumnName("PCT012H143")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H143")
				.IsOptional();

			Property(p => p.PCT012H144)
				.HasColumnName("PCT012H144")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H144")
				.IsOptional();

			Property(p => p.PCT012H145)
				.HasColumnName("PCT012H145")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H145")
				.IsOptional();

			Property(p => p.PCT012H146)
				.HasColumnName("PCT012H146")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H146")
				.IsOptional();

			Property(p => p.PCT012H147)
				.HasColumnName("PCT012H147")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H147")
				.IsOptional();

			Property(p => p.PCT012H148)
				.HasColumnName("PCT012H148")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H148")
				.IsOptional();

			Property(p => p.PCT012H149)
				.HasColumnName("PCT012H149")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H149")
				.IsOptional();

			Property(p => p.PCT012H150)
				.HasColumnName("PCT012H150")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H150")
				.IsOptional();

			Property(p => p.PCT012H151)
				.HasColumnName("PCT012H151")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H151")
				.IsOptional();

			Property(p => p.PCT012H152)
				.HasColumnName("PCT012H152")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H152")
				.IsOptional();

			Property(p => p.PCT012H153)
				.HasColumnName("PCT012H153")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H153")
				.IsOptional();

			Property(p => p.PCT012H154)
				.HasColumnName("PCT012H154")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H154")
				.IsOptional();

			Property(p => p.PCT012H155)
				.HasColumnName("PCT012H155")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H155")
				.IsOptional();

			Property(p => p.PCT012H156)
				.HasColumnName("PCT012H156")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H156")
				.IsOptional();

			Property(p => p.PCT012H157)
				.HasColumnName("PCT012H157")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H157")
				.IsOptional();

			Property(p => p.PCT012H158)
				.HasColumnName("PCT012H158")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H158")
				.IsOptional();

			Property(p => p.PCT012H159)
				.HasColumnName("PCT012H159")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H159")
				.IsOptional();

			Property(p => p.PCT012H160)
				.HasColumnName("PCT012H160")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H160")
				.IsOptional();

			Property(p => p.PCT012H161)
				.HasColumnName("PCT012H161")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H161")
				.IsOptional();

			Property(p => p.PCT012H162)
				.HasColumnName("PCT012H162")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H162")
				.IsOptional();

			Property(p => p.PCT012H163)
				.HasColumnName("PCT012H163")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H163")
				.IsOptional();

			Property(p => p.PCT012H164)
				.HasColumnName("PCT012H164")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H164")
				.IsOptional();

			Property(p => p.PCT012H165)
				.HasColumnName("PCT012H165")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H165")
				.IsOptional();

			Property(p => p.PCT012H166)
				.HasColumnName("PCT012H166")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H166")
				.IsOptional();

			Property(p => p.PCT012H167)
				.HasColumnName("PCT012H167")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H167")
				.IsOptional();

			Property(p => p.PCT012H168)
				.HasColumnName("PCT012H168")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H168")
				.IsOptional();

			Property(p => p.PCT012H169)
				.HasColumnName("PCT012H169")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H169")
				.IsOptional();

			Property(p => p.PCT012H170)
				.HasColumnName("PCT012H170")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H170")
				.IsOptional();

			Property(p => p.PCT012H171)
				.HasColumnName("PCT012H171")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H171")
				.IsOptional();

			Property(p => p.PCT012H172)
				.HasColumnName("PCT012H172")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H172")
				.IsOptional();

			Property(p => p.PCT012H173)
				.HasColumnName("PCT012H173")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H173")
				.IsOptional();

			Property(p => p.PCT012H174)
				.HasColumnName("PCT012H174")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H174")
				.IsOptional();

			Property(p => p.PCT012H175)
				.HasColumnName("PCT012H175")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H175")
				.IsOptional();

			Property(p => p.PCT012H176)
				.HasColumnName("PCT012H176")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H176")
				.IsOptional();

			Property(p => p.PCT012H177)
				.HasColumnName("PCT012H177")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H177")
				.IsOptional();

			Property(p => p.PCT012H178)
				.HasColumnName("PCT012H178")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H178")
				.IsOptional();

			Property(p => p.PCT012H179)
				.HasColumnName("PCT012H179")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H179")
				.IsOptional();

			Property(p => p.PCT012H180)
				.HasColumnName("PCT012H180")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H180")
				.IsOptional();

			Property(p => p.PCT012H181)
				.HasColumnName("PCT012H181")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H181")
				.IsOptional();

			Property(p => p.PCT012H182)
				.HasColumnName("PCT012H182")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H182")
				.IsOptional();

			Property(p => p.PCT012H183)
				.HasColumnName("PCT012H183")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H183")
				.IsOptional();

			Property(p => p.PCT012H184)
				.HasColumnName("PCT012H184")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H184")
				.IsOptional();

			Property(p => p.PCT012H185)
				.HasColumnName("PCT012H185")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H185")
				.IsOptional();

			Property(p => p.PCT012H186)
				.HasColumnName("PCT012H186")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H186")
				.IsOptional();

			Property(p => p.PCT012H187)
				.HasColumnName("PCT012H187")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H187")
				.IsOptional();

			Property(p => p.PCT012H188)
				.HasColumnName("PCT012H188")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H188")
				.IsOptional();

			Property(p => p.PCT012H189)
				.HasColumnName("PCT012H189")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H189")
				.IsOptional();

			Property(p => p.PCT012H190)
				.HasColumnName("PCT012H190")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H190")
				.IsOptional();

			Property(p => p.PCT012H191)
				.HasColumnName("PCT012H191")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H191")
				.IsOptional();

			Property(p => p.PCT012H192)
				.HasColumnName("PCT012H192")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H192")
				.IsOptional();

			Property(p => p.PCT012H193)
				.HasColumnName("PCT012H193")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H193")
				.IsOptional();

			Property(p => p.PCT012H194)
				.HasColumnName("PCT012H194")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H194")
				.IsOptional();

			Property(p => p.PCT012H195)
				.HasColumnName("PCT012H195")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H195")
				.IsOptional();

			Property(p => p.PCT012H196)
				.HasColumnName("PCT012H196")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H196")
				.IsOptional();

			Property(p => p.PCT012H197)
				.HasColumnName("PCT012H197")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H197")
				.IsOptional();

			Property(p => p.PCT012H198)
				.HasColumnName("PCT012H198")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H198")
				.IsOptional();

			Property(p => p.PCT012H199)
				.HasColumnName("PCT012H199")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H199")
				.IsOptional();

			Property(p => p.PCT012H200)
				.HasColumnName("PCT012H200")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H200")
				.IsOptional();

			Property(p => p.PCT012H201)
				.HasColumnName("PCT012H201")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H201")
				.IsOptional();

			Property(p => p.PCT012H202)
				.HasColumnName("PCT012H202")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H202")
				.IsOptional();

			Property(p => p.PCT012H203)
				.HasColumnName("PCT012H203")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H203")
				.IsOptional();

			Property(p => p.PCT012H204)
				.HasColumnName("PCT012H204")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H204")
				.IsOptional();

			Property(p => p.PCT012H205)
				.HasColumnName("PCT012H205")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H205")
				.IsOptional();

			Property(p => p.PCT012H206)
				.HasColumnName("PCT012H206")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H206")
				.IsOptional();

			Property(p => p.PCT012H207)
				.HasColumnName("PCT012H207")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H207")
				.IsOptional();

			Property(p => p.PCT012H208)
				.HasColumnName("PCT012H208")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H208")
				.IsOptional();

			Property(p => p.PCT012H209)
				.HasColumnName("PCT012H209")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012H209")
				.IsOptional();
		}
	}
}
