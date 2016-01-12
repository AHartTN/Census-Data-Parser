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

	public class SummaryOne_SF1_00031Map : EntityTypeConfiguration<SummaryOne_SF1_00031>
	{
		public SummaryOne_SF1_00031Map()
		{
			ToTable("SF1_00031", "SummaryOne");

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

			Property(p => p.PCT012L001)
				.HasColumnName("PCT012L001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L001")
				.IsOptional();

			Property(p => p.PCT012L002)
				.HasColumnName("PCT012L002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L002")
				.IsOptional();

			Property(p => p.PCT012L003)
				.HasColumnName("PCT012L003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L003")
				.IsOptional();

			Property(p => p.PCT012L004)
				.HasColumnName("PCT012L004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L004")
				.IsOptional();

			Property(p => p.PCT012L005)
				.HasColumnName("PCT012L005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L005")
				.IsOptional();

			Property(p => p.PCT012L006)
				.HasColumnName("PCT012L006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L006")
				.IsOptional();

			Property(p => p.PCT012L007)
				.HasColumnName("PCT012L007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L007")
				.IsOptional();

			Property(p => p.PCT012L008)
				.HasColumnName("PCT012L008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L008")
				.IsOptional();

			Property(p => p.PCT012L009)
				.HasColumnName("PCT012L009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L009")
				.IsOptional();

			Property(p => p.PCT012L010)
				.HasColumnName("PCT012L010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L010")
				.IsOptional();

			Property(p => p.PCT012L011)
				.HasColumnName("PCT012L011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L011")
				.IsOptional();

			Property(p => p.PCT012L012)
				.HasColumnName("PCT012L012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L012")
				.IsOptional();

			Property(p => p.PCT012L013)
				.HasColumnName("PCT012L013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L013")
				.IsOptional();

			Property(p => p.PCT012L014)
				.HasColumnName("PCT012L014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L014")
				.IsOptional();

			Property(p => p.PCT012L015)
				.HasColumnName("PCT012L015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L015")
				.IsOptional();

			Property(p => p.PCT012L016)
				.HasColumnName("PCT012L016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L016")
				.IsOptional();

			Property(p => p.PCT012L017)
				.HasColumnName("PCT012L017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L017")
				.IsOptional();

			Property(p => p.PCT012L018)
				.HasColumnName("PCT012L018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L018")
				.IsOptional();

			Property(p => p.PCT012L019)
				.HasColumnName("PCT012L019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L019")
				.IsOptional();

			Property(p => p.PCT012L020)
				.HasColumnName("PCT012L020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L020")
				.IsOptional();

			Property(p => p.PCT012L021)
				.HasColumnName("PCT012L021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L021")
				.IsOptional();

			Property(p => p.PCT012L022)
				.HasColumnName("PCT012L022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L022")
				.IsOptional();

			Property(p => p.PCT012L023)
				.HasColumnName("PCT012L023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L023")
				.IsOptional();

			Property(p => p.PCT012L024)
				.HasColumnName("PCT012L024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L024")
				.IsOptional();

			Property(p => p.PCT012L025)
				.HasColumnName("PCT012L025")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L025")
				.IsOptional();

			Property(p => p.PCT012L026)
				.HasColumnName("PCT012L026")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L026")
				.IsOptional();

			Property(p => p.PCT012L027)
				.HasColumnName("PCT012L027")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L027")
				.IsOptional();

			Property(p => p.PCT012L028)
				.HasColumnName("PCT012L028")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L028")
				.IsOptional();

			Property(p => p.PCT012L029)
				.HasColumnName("PCT012L029")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L029")
				.IsOptional();

			Property(p => p.PCT012L030)
				.HasColumnName("PCT012L030")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L030")
				.IsOptional();

			Property(p => p.PCT012L031)
				.HasColumnName("PCT012L031")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L031")
				.IsOptional();

			Property(p => p.PCT012L032)
				.HasColumnName("PCT012L032")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L032")
				.IsOptional();

			Property(p => p.PCT012L033)
				.HasColumnName("PCT012L033")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L033")
				.IsOptional();

			Property(p => p.PCT012L034)
				.HasColumnName("PCT012L034")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L034")
				.IsOptional();

			Property(p => p.PCT012L035)
				.HasColumnName("PCT012L035")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L035")
				.IsOptional();

			Property(p => p.PCT012L036)
				.HasColumnName("PCT012L036")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L036")
				.IsOptional();

			Property(p => p.PCT012L037)
				.HasColumnName("PCT012L037")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L037")
				.IsOptional();

			Property(p => p.PCT012L038)
				.HasColumnName("PCT012L038")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L038")
				.IsOptional();

			Property(p => p.PCT012L039)
				.HasColumnName("PCT012L039")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L039")
				.IsOptional();

			Property(p => p.PCT012L040)
				.HasColumnName("PCT012L040")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L040")
				.IsOptional();

			Property(p => p.PCT012L041)
				.HasColumnName("PCT012L041")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L041")
				.IsOptional();

			Property(p => p.PCT012L042)
				.HasColumnName("PCT012L042")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L042")
				.IsOptional();

			Property(p => p.PCT012L043)
				.HasColumnName("PCT012L043")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L043")
				.IsOptional();

			Property(p => p.PCT012L044)
				.HasColumnName("PCT012L044")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L044")
				.IsOptional();

			Property(p => p.PCT012L045)
				.HasColumnName("PCT012L045")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L045")
				.IsOptional();

			Property(p => p.PCT012L046)
				.HasColumnName("PCT012L046")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L046")
				.IsOptional();

			Property(p => p.PCT012L047)
				.HasColumnName("PCT012L047")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L047")
				.IsOptional();

			Property(p => p.PCT012L048)
				.HasColumnName("PCT012L048")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L048")
				.IsOptional();

			Property(p => p.PCT012L049)
				.HasColumnName("PCT012L049")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L049")
				.IsOptional();

			Property(p => p.PCT012L050)
				.HasColumnName("PCT012L050")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L050")
				.IsOptional();

			Property(p => p.PCT012L051)
				.HasColumnName("PCT012L051")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L051")
				.IsOptional();

			Property(p => p.PCT012L052)
				.HasColumnName("PCT012L052")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L052")
				.IsOptional();

			Property(p => p.PCT012L053)
				.HasColumnName("PCT012L053")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L053")
				.IsOptional();

			Property(p => p.PCT012L054)
				.HasColumnName("PCT012L054")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L054")
				.IsOptional();

			Property(p => p.PCT012L055)
				.HasColumnName("PCT012L055")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L055")
				.IsOptional();

			Property(p => p.PCT012L056)
				.HasColumnName("PCT012L056")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L056")
				.IsOptional();

			Property(p => p.PCT012L057)
				.HasColumnName("PCT012L057")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L057")
				.IsOptional();

			Property(p => p.PCT012L058)
				.HasColumnName("PCT012L058")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L058")
				.IsOptional();

			Property(p => p.PCT012L059)
				.HasColumnName("PCT012L059")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L059")
				.IsOptional();

			Property(p => p.PCT012L060)
				.HasColumnName("PCT012L060")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L060")
				.IsOptional();

			Property(p => p.PCT012L061)
				.HasColumnName("PCT012L061")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L061")
				.IsOptional();

			Property(p => p.PCT012L062)
				.HasColumnName("PCT012L062")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L062")
				.IsOptional();

			Property(p => p.PCT012L063)
				.HasColumnName("PCT012L063")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L063")
				.IsOptional();

			Property(p => p.PCT012L064)
				.HasColumnName("PCT012L064")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L064")
				.IsOptional();

			Property(p => p.PCT012L065)
				.HasColumnName("PCT012L065")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L065")
				.IsOptional();

			Property(p => p.PCT012L066)
				.HasColumnName("PCT012L066")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L066")
				.IsOptional();

			Property(p => p.PCT012L067)
				.HasColumnName("PCT012L067")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L067")
				.IsOptional();

			Property(p => p.PCT012L068)
				.HasColumnName("PCT012L068")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L068")
				.IsOptional();

			Property(p => p.PCT012L069)
				.HasColumnName("PCT012L069")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L069")
				.IsOptional();

			Property(p => p.PCT012L070)
				.HasColumnName("PCT012L070")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L070")
				.IsOptional();

			Property(p => p.PCT012L071)
				.HasColumnName("PCT012L071")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L071")
				.IsOptional();

			Property(p => p.PCT012L072)
				.HasColumnName("PCT012L072")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L072")
				.IsOptional();

			Property(p => p.PCT012L073)
				.HasColumnName("PCT012L073")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L073")
				.IsOptional();

			Property(p => p.PCT012L074)
				.HasColumnName("PCT012L074")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L074")
				.IsOptional();

			Property(p => p.PCT012L075)
				.HasColumnName("PCT012L075")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L075")
				.IsOptional();

			Property(p => p.PCT012L076)
				.HasColumnName("PCT012L076")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L076")
				.IsOptional();

			Property(p => p.PCT012L077)
				.HasColumnName("PCT012L077")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L077")
				.IsOptional();

			Property(p => p.PCT012L078)
				.HasColumnName("PCT012L078")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L078")
				.IsOptional();

			Property(p => p.PCT012L079)
				.HasColumnName("PCT012L079")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L079")
				.IsOptional();

			Property(p => p.PCT012L080)
				.HasColumnName("PCT012L080")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L080")
				.IsOptional();

			Property(p => p.PCT012L081)
				.HasColumnName("PCT012L081")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L081")
				.IsOptional();

			Property(p => p.PCT012L082)
				.HasColumnName("PCT012L082")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L082")
				.IsOptional();

			Property(p => p.PCT012L083)
				.HasColumnName("PCT012L083")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L083")
				.IsOptional();

			Property(p => p.PCT012L084)
				.HasColumnName("PCT012L084")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L084")
				.IsOptional();

			Property(p => p.PCT012L085)
				.HasColumnName("PCT012L085")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L085")
				.IsOptional();

			Property(p => p.PCT012L086)
				.HasColumnName("PCT012L086")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L086")
				.IsOptional();

			Property(p => p.PCT012L087)
				.HasColumnName("PCT012L087")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L087")
				.IsOptional();

			Property(p => p.PCT012L088)
				.HasColumnName("PCT012L088")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L088")
				.IsOptional();

			Property(p => p.PCT012L089)
				.HasColumnName("PCT012L089")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L089")
				.IsOptional();

			Property(p => p.PCT012L090)
				.HasColumnName("PCT012L090")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L090")
				.IsOptional();

			Property(p => p.PCT012L091)
				.HasColumnName("PCT012L091")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L091")
				.IsOptional();

			Property(p => p.PCT012L092)
				.HasColumnName("PCT012L092")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L092")
				.IsOptional();

			Property(p => p.PCT012L093)
				.HasColumnName("PCT012L093")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L093")
				.IsOptional();

			Property(p => p.PCT012L094)
				.HasColumnName("PCT012L094")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L094")
				.IsOptional();

			Property(p => p.PCT012L095)
				.HasColumnName("PCT012L095")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L095")
				.IsOptional();

			Property(p => p.PCT012L096)
				.HasColumnName("PCT012L096")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L096")
				.IsOptional();

			Property(p => p.PCT012L097)
				.HasColumnName("PCT012L097")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L097")
				.IsOptional();

			Property(p => p.PCT012L098)
				.HasColumnName("PCT012L098")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L098")
				.IsOptional();

			Property(p => p.PCT012L099)
				.HasColumnName("PCT012L099")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L099")
				.IsOptional();

			Property(p => p.PCT012L100)
				.HasColumnName("PCT012L100")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L100")
				.IsOptional();

			Property(p => p.PCT012L101)
				.HasColumnName("PCT012L101")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L101")
				.IsOptional();

			Property(p => p.PCT012L102)
				.HasColumnName("PCT012L102")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L102")
				.IsOptional();

			Property(p => p.PCT012L103)
				.HasColumnName("PCT012L103")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L103")
				.IsOptional();

			Property(p => p.PCT012L104)
				.HasColumnName("PCT012L104")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L104")
				.IsOptional();

			Property(p => p.PCT012L105)
				.HasColumnName("PCT012L105")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L105")
				.IsOptional();

			Property(p => p.PCT012L106)
				.HasColumnName("PCT012L106")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L106")
				.IsOptional();

			Property(p => p.PCT012L107)
				.HasColumnName("PCT012L107")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L107")
				.IsOptional();

			Property(p => p.PCT012L108)
				.HasColumnName("PCT012L108")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L108")
				.IsOptional();

			Property(p => p.PCT012L109)
				.HasColumnName("PCT012L109")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L109")
				.IsOptional();

			Property(p => p.PCT012L110)
				.HasColumnName("PCT012L110")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L110")
				.IsOptional();

			Property(p => p.PCT012L111)
				.HasColumnName("PCT012L111")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L111")
				.IsOptional();

			Property(p => p.PCT012L112)
				.HasColumnName("PCT012L112")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L112")
				.IsOptional();

			Property(p => p.PCT012L113)
				.HasColumnName("PCT012L113")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L113")
				.IsOptional();

			Property(p => p.PCT012L114)
				.HasColumnName("PCT012L114")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L114")
				.IsOptional();

			Property(p => p.PCT012L115)
				.HasColumnName("PCT012L115")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L115")
				.IsOptional();

			Property(p => p.PCT012L116)
				.HasColumnName("PCT012L116")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L116")
				.IsOptional();

			Property(p => p.PCT012L117)
				.HasColumnName("PCT012L117")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L117")
				.IsOptional();

			Property(p => p.PCT012L118)
				.HasColumnName("PCT012L118")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L118")
				.IsOptional();

			Property(p => p.PCT012L119)
				.HasColumnName("PCT012L119")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L119")
				.IsOptional();

			Property(p => p.PCT012L120)
				.HasColumnName("PCT012L120")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L120")
				.IsOptional();

			Property(p => p.PCT012L121)
				.HasColumnName("PCT012L121")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L121")
				.IsOptional();

			Property(p => p.PCT012L122)
				.HasColumnName("PCT012L122")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L122")
				.IsOptional();

			Property(p => p.PCT012L123)
				.HasColumnName("PCT012L123")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L123")
				.IsOptional();

			Property(p => p.PCT012L124)
				.HasColumnName("PCT012L124")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L124")
				.IsOptional();

			Property(p => p.PCT012L125)
				.HasColumnName("PCT012L125")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L125")
				.IsOptional();

			Property(p => p.PCT012L126)
				.HasColumnName("PCT012L126")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L126")
				.IsOptional();

			Property(p => p.PCT012L127)
				.HasColumnName("PCT012L127")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L127")
				.IsOptional();

			Property(p => p.PCT012L128)
				.HasColumnName("PCT012L128")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L128")
				.IsOptional();

			Property(p => p.PCT012L129)
				.HasColumnName("PCT012L129")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L129")
				.IsOptional();

			Property(p => p.PCT012L130)
				.HasColumnName("PCT012L130")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L130")
				.IsOptional();

			Property(p => p.PCT012L131)
				.HasColumnName("PCT012L131")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L131")
				.IsOptional();

			Property(p => p.PCT012L132)
				.HasColumnName("PCT012L132")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L132")
				.IsOptional();

			Property(p => p.PCT012L133)
				.HasColumnName("PCT012L133")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L133")
				.IsOptional();

			Property(p => p.PCT012L134)
				.HasColumnName("PCT012L134")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L134")
				.IsOptional();

			Property(p => p.PCT012L135)
				.HasColumnName("PCT012L135")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L135")
				.IsOptional();

			Property(p => p.PCT012L136)
				.HasColumnName("PCT012L136")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L136")
				.IsOptional();

			Property(p => p.PCT012L137)
				.HasColumnName("PCT012L137")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L137")
				.IsOptional();

			Property(p => p.PCT012L138)
				.HasColumnName("PCT012L138")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L138")
				.IsOptional();

			Property(p => p.PCT012L139)
				.HasColumnName("PCT012L139")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L139")
				.IsOptional();

			Property(p => p.PCT012L140)
				.HasColumnName("PCT012L140")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L140")
				.IsOptional();

			Property(p => p.PCT012L141)
				.HasColumnName("PCT012L141")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L141")
				.IsOptional();

			Property(p => p.PCT012L142)
				.HasColumnName("PCT012L142")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L142")
				.IsOptional();

			Property(p => p.PCT012L143)
				.HasColumnName("PCT012L143")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L143")
				.IsOptional();

			Property(p => p.PCT012L144)
				.HasColumnName("PCT012L144")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L144")
				.IsOptional();

			Property(p => p.PCT012L145)
				.HasColumnName("PCT012L145")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L145")
				.IsOptional();

			Property(p => p.PCT012L146)
				.HasColumnName("PCT012L146")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L146")
				.IsOptional();

			Property(p => p.PCT012L147)
				.HasColumnName("PCT012L147")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L147")
				.IsOptional();

			Property(p => p.PCT012L148)
				.HasColumnName("PCT012L148")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L148")
				.IsOptional();

			Property(p => p.PCT012L149)
				.HasColumnName("PCT012L149")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L149")
				.IsOptional();

			Property(p => p.PCT012L150)
				.HasColumnName("PCT012L150")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L150")
				.IsOptional();

			Property(p => p.PCT012L151)
				.HasColumnName("PCT012L151")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L151")
				.IsOptional();

			Property(p => p.PCT012L152)
				.HasColumnName("PCT012L152")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L152")
				.IsOptional();

			Property(p => p.PCT012L153)
				.HasColumnName("PCT012L153")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L153")
				.IsOptional();

			Property(p => p.PCT012L154)
				.HasColumnName("PCT012L154")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L154")
				.IsOptional();

			Property(p => p.PCT012L155)
				.HasColumnName("PCT012L155")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L155")
				.IsOptional();

			Property(p => p.PCT012L156)
				.HasColumnName("PCT012L156")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L156")
				.IsOptional();

			Property(p => p.PCT012L157)
				.HasColumnName("PCT012L157")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L157")
				.IsOptional();

			Property(p => p.PCT012L158)
				.HasColumnName("PCT012L158")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L158")
				.IsOptional();

			Property(p => p.PCT012L159)
				.HasColumnName("PCT012L159")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L159")
				.IsOptional();

			Property(p => p.PCT012L160)
				.HasColumnName("PCT012L160")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L160")
				.IsOptional();

			Property(p => p.PCT012L161)
				.HasColumnName("PCT012L161")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L161")
				.IsOptional();

			Property(p => p.PCT012L162)
				.HasColumnName("PCT012L162")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L162")
				.IsOptional();

			Property(p => p.PCT012L163)
				.HasColumnName("PCT012L163")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L163")
				.IsOptional();

			Property(p => p.PCT012L164)
				.HasColumnName("PCT012L164")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L164")
				.IsOptional();

			Property(p => p.PCT012L165)
				.HasColumnName("PCT012L165")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L165")
				.IsOptional();

			Property(p => p.PCT012L166)
				.HasColumnName("PCT012L166")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L166")
				.IsOptional();

			Property(p => p.PCT012L167)
				.HasColumnName("PCT012L167")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L167")
				.IsOptional();

			Property(p => p.PCT012L168)
				.HasColumnName("PCT012L168")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L168")
				.IsOptional();

			Property(p => p.PCT012L169)
				.HasColumnName("PCT012L169")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L169")
				.IsOptional();

			Property(p => p.PCT012L170)
				.HasColumnName("PCT012L170")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L170")
				.IsOptional();

			Property(p => p.PCT012L171)
				.HasColumnName("PCT012L171")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L171")
				.IsOptional();

			Property(p => p.PCT012L172)
				.HasColumnName("PCT012L172")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L172")
				.IsOptional();

			Property(p => p.PCT012L173)
				.HasColumnName("PCT012L173")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L173")
				.IsOptional();

			Property(p => p.PCT012L174)
				.HasColumnName("PCT012L174")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L174")
				.IsOptional();

			Property(p => p.PCT012L175)
				.HasColumnName("PCT012L175")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L175")
				.IsOptional();

			Property(p => p.PCT012L176)
				.HasColumnName("PCT012L176")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L176")
				.IsOptional();

			Property(p => p.PCT012L177)
				.HasColumnName("PCT012L177")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L177")
				.IsOptional();

			Property(p => p.PCT012L178)
				.HasColumnName("PCT012L178")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L178")
				.IsOptional();

			Property(p => p.PCT012L179)
				.HasColumnName("PCT012L179")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L179")
				.IsOptional();

			Property(p => p.PCT012L180)
				.HasColumnName("PCT012L180")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L180")
				.IsOptional();

			Property(p => p.PCT012L181)
				.HasColumnName("PCT012L181")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L181")
				.IsOptional();

			Property(p => p.PCT012L182)
				.HasColumnName("PCT012L182")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L182")
				.IsOptional();

			Property(p => p.PCT012L183)
				.HasColumnName("PCT012L183")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L183")
				.IsOptional();

			Property(p => p.PCT012L184)
				.HasColumnName("PCT012L184")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L184")
				.IsOptional();

			Property(p => p.PCT012L185)
				.HasColumnName("PCT012L185")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L185")
				.IsOptional();

			Property(p => p.PCT012L186)
				.HasColumnName("PCT012L186")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L186")
				.IsOptional();

			Property(p => p.PCT012L187)
				.HasColumnName("PCT012L187")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L187")
				.IsOptional();

			Property(p => p.PCT012L188)
				.HasColumnName("PCT012L188")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L188")
				.IsOptional();

			Property(p => p.PCT012L189)
				.HasColumnName("PCT012L189")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L189")
				.IsOptional();

			Property(p => p.PCT012L190)
				.HasColumnName("PCT012L190")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L190")
				.IsOptional();

			Property(p => p.PCT012L191)
				.HasColumnName("PCT012L191")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L191")
				.IsOptional();

			Property(p => p.PCT012L192)
				.HasColumnName("PCT012L192")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L192")
				.IsOptional();

			Property(p => p.PCT012L193)
				.HasColumnName("PCT012L193")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L193")
				.IsOptional();

			Property(p => p.PCT012L194)
				.HasColumnName("PCT012L194")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L194")
				.IsOptional();

			Property(p => p.PCT012L195)
				.HasColumnName("PCT012L195")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L195")
				.IsOptional();

			Property(p => p.PCT012L196)
				.HasColumnName("PCT012L196")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L196")
				.IsOptional();

			Property(p => p.PCT012L197)
				.HasColumnName("PCT012L197")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L197")
				.IsOptional();

			Property(p => p.PCT012L198)
				.HasColumnName("PCT012L198")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L198")
				.IsOptional();

			Property(p => p.PCT012L199)
				.HasColumnName("PCT012L199")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L199")
				.IsOptional();

			Property(p => p.PCT012L200)
				.HasColumnName("PCT012L200")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L200")
				.IsOptional();

			Property(p => p.PCT012L201)
				.HasColumnName("PCT012L201")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L201")
				.IsOptional();

			Property(p => p.PCT012L202)
				.HasColumnName("PCT012L202")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L202")
				.IsOptional();

			Property(p => p.PCT012L203)
				.HasColumnName("PCT012L203")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L203")
				.IsOptional();

			Property(p => p.PCT012L204)
				.HasColumnName("PCT012L204")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L204")
				.IsOptional();

			Property(p => p.PCT012L205)
				.HasColumnName("PCT012L205")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L205")
				.IsOptional();

			Property(p => p.PCT012L206)
				.HasColumnName("PCT012L206")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L206")
				.IsOptional();

			Property(p => p.PCT012L207)
				.HasColumnName("PCT012L207")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L207")
				.IsOptional();

			Property(p => p.PCT012L208)
				.HasColumnName("PCT012L208")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L208")
				.IsOptional();

			Property(p => p.PCT012L209)
				.HasColumnName("PCT012L209")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012L209")
				.IsOptional();
		}
	}
}
