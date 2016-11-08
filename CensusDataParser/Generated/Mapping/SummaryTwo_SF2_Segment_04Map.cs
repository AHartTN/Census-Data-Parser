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
	using Models;
	#endregion Using Directives

	public class SummaryTwo_SF2_Segment_04Map : EntityTypeConfiguration<SummaryTwo_SF2_Segment_04>
	{
		public SummaryTwo_SF2_Segment_04Map()
		{
			ToTable("SF2_Segment_04", "SummaryTwo");

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

			Property(p => p.PCT0050001)
				.HasColumnName("PCT0050001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050001")
				.IsOptional();

			Property(p => p.PCT0050002)
				.HasColumnName("PCT0050002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050002")
				.IsOptional();

			Property(p => p.PCT0050003)
				.HasColumnName("PCT0050003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050003")
				.IsOptional();

			Property(p => p.PCT0050004)
				.HasColumnName("PCT0050004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050004")
				.IsOptional();

			Property(p => p.PCT0050005)
				.HasColumnName("PCT0050005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050005")
				.IsOptional();

			Property(p => p.PCT0050006)
				.HasColumnName("PCT0050006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050006")
				.IsOptional();

			Property(p => p.PCT0050007)
				.HasColumnName("PCT0050007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050007")
				.IsOptional();

			Property(p => p.PCT0050008)
				.HasColumnName("PCT0050008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050008")
				.IsOptional();

			Property(p => p.PCT0050009)
				.HasColumnName("PCT0050009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050009")
				.IsOptional();

			Property(p => p.PCT0050010)
				.HasColumnName("PCT0050010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050010")
				.IsOptional();

			Property(p => p.PCT0050011)
				.HasColumnName("PCT0050011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050011")
				.IsOptional();

			Property(p => p.PCT0050012)
				.HasColumnName("PCT0050012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050012")
				.IsOptional();

			Property(p => p.PCT0050013)
				.HasColumnName("PCT0050013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050013")
				.IsOptional();

			Property(p => p.PCT0050014)
				.HasColumnName("PCT0050014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050014")
				.IsOptional();

			Property(p => p.PCT0050015)
				.HasColumnName("PCT0050015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050015")
				.IsOptional();

			Property(p => p.PCT0050016)
				.HasColumnName("PCT0050016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050016")
				.IsOptional();

			Property(p => p.PCT0050017)
				.HasColumnName("PCT0050017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050017")
				.IsOptional();

			Property(p => p.PCT0050018)
				.HasColumnName("PCT0050018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050018")
				.IsOptional();

			Property(p => p.PCT0050019)
				.HasColumnName("PCT0050019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050019")
				.IsOptional();

			Property(p => p.PCT0050020)
				.HasColumnName("PCT0050020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050020")
				.IsOptional();

			Property(p => p.PCT0050021)
				.HasColumnName("PCT0050021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050021")
				.IsOptional();

			Property(p => p.PCT0050022)
				.HasColumnName("PCT0050022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050022")
				.IsOptional();

			Property(p => p.PCT0050023)
				.HasColumnName("PCT0050023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050023")
				.IsOptional();

			Property(p => p.PCT0050024)
				.HasColumnName("PCT0050024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050024")
				.IsOptional();

			Property(p => p.PCT0050025)
				.HasColumnName("PCT0050025")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050025")
				.IsOptional();

			Property(p => p.PCT0050026)
				.HasColumnName("PCT0050026")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050026")
				.IsOptional();

			Property(p => p.PCT0050027)
				.HasColumnName("PCT0050027")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050027")
				.IsOptional();

			Property(p => p.PCT0050028)
				.HasColumnName("PCT0050028")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050028")
				.IsOptional();

			Property(p => p.PCT0050029)
				.HasColumnName("PCT0050029")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050029")
				.IsOptional();

			Property(p => p.PCT0050030)
				.HasColumnName("PCT0050030")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050030")
				.IsOptional();

			Property(p => p.PCT0050031)
				.HasColumnName("PCT0050031")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050031")
				.IsOptional();

			Property(p => p.PCT0050032)
				.HasColumnName("PCT0050032")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050032")
				.IsOptional();

			Property(p => p.PCT0050033)
				.HasColumnName("PCT0050033")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050033")
				.IsOptional();

			Property(p => p.PCT0050034)
				.HasColumnName("PCT0050034")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050034")
				.IsOptional();

			Property(p => p.PCT0050035)
				.HasColumnName("PCT0050035")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050035")
				.IsOptional();

			Property(p => p.PCT0050036)
				.HasColumnName("PCT0050036")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050036")
				.IsOptional();

			Property(p => p.PCT0050037)
				.HasColumnName("PCT0050037")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050037")
				.IsOptional();

			Property(p => p.PCT0050038)
				.HasColumnName("PCT0050038")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050038")
				.IsOptional();

			Property(p => p.PCT0050039)
				.HasColumnName("PCT0050039")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050039")
				.IsOptional();

			Property(p => p.PCT0050040)
				.HasColumnName("PCT0050040")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050040")
				.IsOptional();

			Property(p => p.PCT0050041)
				.HasColumnName("PCT0050041")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050041")
				.IsOptional();

			Property(p => p.PCT0050042)
				.HasColumnName("PCT0050042")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050042")
				.IsOptional();

			Property(p => p.PCT0050043)
				.HasColumnName("PCT0050043")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050043")
				.IsOptional();

			Property(p => p.PCT0050044)
				.HasColumnName("PCT0050044")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050044")
				.IsOptional();

			Property(p => p.PCT0050045)
				.HasColumnName("PCT0050045")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050045")
				.IsOptional();

			Property(p => p.PCT0050046)
				.HasColumnName("PCT0050046")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050046")
				.IsOptional();

			Property(p => p.PCT0050047)
				.HasColumnName("PCT0050047")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050047")
				.IsOptional();

			Property(p => p.PCT0050048)
				.HasColumnName("PCT0050048")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050048")
				.IsOptional();

			Property(p => p.PCT0050049)
				.HasColumnName("PCT0050049")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0050049")
				.IsOptional();

			Property(p => p.PCT0060001)
				.HasColumnName("PCT0060001")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060001")
				.IsOptional();

			Property(p => p.PCT0060002)
				.HasColumnName("PCT0060002")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060002")
				.IsOptional();

			Property(p => p.PCT0060003)
				.HasColumnName("PCT0060003")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0060003")
				.IsOptional();

			Property(p => p.PCT0070001)
				.HasColumnName("PCT0070001")
				.HasColumnOrder(57)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070001")
				.IsOptional();

			Property(p => p.PCT0070002)
				.HasColumnName("PCT0070002")
				.HasColumnOrder(58)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070002")
				.IsOptional();

			Property(p => p.PCT0070003)
				.HasColumnName("PCT0070003")
				.HasColumnOrder(59)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0070003")
				.IsOptional();

			Property(p => p.PCT0080001)
				.HasColumnName("PCT0080001")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0080001")
				.IsOptional();

			Property(p => p.PCT0080002)
				.HasColumnName("PCT0080002")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0080002")
				.IsOptional();

			Property(p => p.PCT0080003)
				.HasColumnName("PCT0080003")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0080003")
				.IsOptional();

			Property(p => p.PCT0080004)
				.HasColumnName("PCT0080004")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0080004")
				.IsOptional();

			Property(p => p.PCT0080005)
				.HasColumnName("PCT0080005")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0080005")
				.IsOptional();

			Property(p => p.PCT0080006)
				.HasColumnName("PCT0080006")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0080006")
				.IsOptional();

			Property(p => p.PCT0080007)
				.HasColumnName("PCT0080007")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0080007")
				.IsOptional();

			Property(p => p.PCT0080008)
				.HasColumnName("PCT0080008")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0080008")
				.IsOptional();

			Property(p => p.PCT0080009)
				.HasColumnName("PCT0080009")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0080009")
				.IsOptional();

			Property(p => p.PCT0090001)
				.HasColumnName("PCT0090001")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0090001")
				.IsOptional();

			Property(p => p.PCT0090002)
				.HasColumnName("PCT0090002")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0090002")
				.IsOptional();

			Property(p => p.PCT0090003)
				.HasColumnName("PCT0090003")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0090003")
				.IsOptional();

			Property(p => p.PCT0090004)
				.HasColumnName("PCT0090004")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0090004")
				.IsOptional();

			Property(p => p.PCT0090005)
				.HasColumnName("PCT0090005")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0090005")
				.IsOptional();

			Property(p => p.PCT0090006)
				.HasColumnName("PCT0090006")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0090006")
				.IsOptional();

			Property(p => p.PCT0090007)
				.HasColumnName("PCT0090007")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0090007")
				.IsOptional();

			Property(p => p.PCT0090008)
				.HasColumnName("PCT0090008")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0090008")
				.IsOptional();

			Property(p => p.PCT0090009)
				.HasColumnName("PCT0090009")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0090009")
				.IsOptional();

			Property(p => p.PCT0090010)
				.HasColumnName("PCT0090010")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0090010")
				.IsOptional();

			Property(p => p.PCT0090011)
				.HasColumnName("PCT0090011")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0090011")
				.IsOptional();

			Property(p => p.PCT0090012)
				.HasColumnName("PCT0090012")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0090012")
				.IsOptional();

			Property(p => p.PCT0090013)
				.HasColumnName("PCT0090013")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0090013")
				.IsOptional();

			Property(p => p.PCT0090014)
				.HasColumnName("PCT0090014")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0090014")
				.IsOptional();

			Property(p => p.PCT0090015)
				.HasColumnName("PCT0090015")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0090015")
				.IsOptional();

			Property(p => p.PCT0090016)
				.HasColumnName("PCT0090016")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0090016")
				.IsOptional();

			Property(p => p.PCT0090017)
				.HasColumnName("PCT0090017")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0090017")
				.IsOptional();

			Property(p => p.PCT0090018)
				.HasColumnName("PCT0090018")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0090018")
				.IsOptional();

			Property(p => p.PCT0090019)
				.HasColumnName("PCT0090019")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0090019")
				.IsOptional();

			Property(p => p.PCT0100001)
				.HasColumnName("PCT0100001")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100001")
				.IsOptional();

			Property(p => p.PCT0100002)
				.HasColumnName("PCT0100002")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100002")
				.IsOptional();

			Property(p => p.PCT0100003)
				.HasColumnName("PCT0100003")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100003")
				.IsOptional();

			Property(p => p.PCT0100004)
				.HasColumnName("PCT0100004")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100004")
				.IsOptional();

			Property(p => p.PCT0100005)
				.HasColumnName("PCT0100005")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100005")
				.IsOptional();

			Property(p => p.PCT0100006)
				.HasColumnName("PCT0100006")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100006")
				.IsOptional();

			Property(p => p.PCT0100007)
				.HasColumnName("PCT0100007")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100007")
				.IsOptional();

			Property(p => p.PCT0100008)
				.HasColumnName("PCT0100008")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100008")
				.IsOptional();

			Property(p => p.PCT0100009)
				.HasColumnName("PCT0100009")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100009")
				.IsOptional();

			Property(p => p.PCT0100010)
				.HasColumnName("PCT0100010")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100010")
				.IsOptional();

			Property(p => p.PCT0100011)
				.HasColumnName("PCT0100011")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100011")
				.IsOptional();

			Property(p => p.PCT0100012)
				.HasColumnName("PCT0100012")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100012")
				.IsOptional();

			Property(p => p.PCT0100013)
				.HasColumnName("PCT0100013")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100013")
				.IsOptional();

			Property(p => p.PCT0100014)
				.HasColumnName("PCT0100014")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100014")
				.IsOptional();

			Property(p => p.PCT0100015)
				.HasColumnName("PCT0100015")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100015")
				.IsOptional();

			Property(p => p.PCT0100016)
				.HasColumnName("PCT0100016")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100016")
				.IsOptional();

			Property(p => p.PCT0100017)
				.HasColumnName("PCT0100017")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100017")
				.IsOptional();

			Property(p => p.PCT0100018)
				.HasColumnName("PCT0100018")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100018")
				.IsOptional();

			Property(p => p.PCT0100019)
				.HasColumnName("PCT0100019")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100019")
				.IsOptional();

			Property(p => p.PCT0100020)
				.HasColumnName("PCT0100020")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100020")
				.IsOptional();

			Property(p => p.PCT0100021)
				.HasColumnName("PCT0100021")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100021")
				.IsOptional();

			Property(p => p.PCT0100022)
				.HasColumnName("PCT0100022")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100022")
				.IsOptional();

			Property(p => p.PCT0100023)
				.HasColumnName("PCT0100023")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100023")
				.IsOptional();

			Property(p => p.PCT0100024)
				.HasColumnName("PCT0100024")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100024")
				.IsOptional();

			Property(p => p.PCT0100025)
				.HasColumnName("PCT0100025")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100025")
				.IsOptional();

			Property(p => p.PCT0100026)
				.HasColumnName("PCT0100026")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100026")
				.IsOptional();

			Property(p => p.PCT0100027)
				.HasColumnName("PCT0100027")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100027")
				.IsOptional();

			Property(p => p.PCT0100028)
				.HasColumnName("PCT0100028")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100028")
				.IsOptional();

			Property(p => p.PCT0100029)
				.HasColumnName("PCT0100029")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100029")
				.IsOptional();

			Property(p => p.PCT0100030)
				.HasColumnName("PCT0100030")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100030")
				.IsOptional();

			Property(p => p.PCT0100031)
				.HasColumnName("PCT0100031")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100031")
				.IsOptional();

			Property(p => p.PCT0100032)
				.HasColumnName("PCT0100032")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100032")
				.IsOptional();

			Property(p => p.PCT0100033)
				.HasColumnName("PCT0100033")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100033")
				.IsOptional();

			Property(p => p.PCT0100034)
				.HasColumnName("PCT0100034")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0100034")
				.IsOptional();

			Property(p => p.PCT0110001)
				.HasColumnName("PCT0110001")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110001")
				.IsOptional();

			Property(p => p.PCT0110002)
				.HasColumnName("PCT0110002")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110002")
				.IsOptional();

			Property(p => p.PCT0110003)
				.HasColumnName("PCT0110003")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110003")
				.IsOptional();

			Property(p => p.PCT0110004)
				.HasColumnName("PCT0110004")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110004")
				.IsOptional();

			Property(p => p.PCT0110005)
				.HasColumnName("PCT0110005")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110005")
				.IsOptional();

			Property(p => p.PCT0110006)
				.HasColumnName("PCT0110006")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110006")
				.IsOptional();

			Property(p => p.PCT0110007)
				.HasColumnName("PCT0110007")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110007")
				.IsOptional();

			Property(p => p.PCT0110008)
				.HasColumnName("PCT0110008")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110008")
				.IsOptional();

			Property(p => p.PCT0110009)
				.HasColumnName("PCT0110009")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110009")
				.IsOptional();

			Property(p => p.PCT0110010)
				.HasColumnName("PCT0110010")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110010")
				.IsOptional();

			Property(p => p.PCT0110011)
				.HasColumnName("PCT0110011")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110011")
				.IsOptional();

			Property(p => p.PCT0110012)
				.HasColumnName("PCT0110012")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110012")
				.IsOptional();

			Property(p => p.PCT0110013)
				.HasColumnName("PCT0110013")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110013")
				.IsOptional();

			Property(p => p.PCT0110014)
				.HasColumnName("PCT0110014")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110014")
				.IsOptional();

			Property(p => p.PCT0110015)
				.HasColumnName("PCT0110015")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110015")
				.IsOptional();

			Property(p => p.PCT0110016)
				.HasColumnName("PCT0110016")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110016")
				.IsOptional();

			Property(p => p.PCT0110017)
				.HasColumnName("PCT0110017")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110017")
				.IsOptional();

			Property(p => p.PCT0110018)
				.HasColumnName("PCT0110018")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110018")
				.IsOptional();

			Property(p => p.PCT0110019)
				.HasColumnName("PCT0110019")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110019")
				.IsOptional();

			Property(p => p.PCT0110020)
				.HasColumnName("PCT0110020")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110020")
				.IsOptional();

			Property(p => p.PCT0110021)
				.HasColumnName("PCT0110021")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110021")
				.IsOptional();

			Property(p => p.PCT0110022)
				.HasColumnName("PCT0110022")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110022")
				.IsOptional();

			Property(p => p.PCT0110023)
				.HasColumnName("PCT0110023")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110023")
				.IsOptional();

			Property(p => p.PCT0110024)
				.HasColumnName("PCT0110024")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110024")
				.IsOptional();

			Property(p => p.PCT0110025)
				.HasColumnName("PCT0110025")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110025")
				.IsOptional();

			Property(p => p.PCT0110026)
				.HasColumnName("PCT0110026")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110026")
				.IsOptional();

			Property(p => p.PCT0110027)
				.HasColumnName("PCT0110027")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110027")
				.IsOptional();

			Property(p => p.PCT0110028)
				.HasColumnName("PCT0110028")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110028")
				.IsOptional();

			Property(p => p.PCT0110029)
				.HasColumnName("PCT0110029")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110029")
				.IsOptional();

			Property(p => p.PCT0110030)
				.HasColumnName("PCT0110030")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110030")
				.IsOptional();

			Property(p => p.PCT0110031)
				.HasColumnName("PCT0110031")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0110031")
				.IsOptional();

			Property(p => p.PCT0120001)
				.HasColumnName("PCT0120001")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0120001")
				.IsOptional();

			Property(p => p.PCT0120002)
				.HasColumnName("PCT0120002")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0120002")
				.IsOptional();

			Property(p => p.PCT0120003)
				.HasColumnName("PCT0120003")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0120003")
				.IsOptional();

			Property(p => p.PCT0120004)
				.HasColumnName("PCT0120004")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0120004")
				.IsOptional();

			Property(p => p.PCT0120005)
				.HasColumnName("PCT0120005")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0120005")
				.IsOptional();

			Property(p => p.PCT0120006)
				.HasColumnName("PCT0120006")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0120006")
				.IsOptional();

			Property(p => p.PCT0120007)
				.HasColumnName("PCT0120007")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0120007")
				.IsOptional();

			Property(p => p.PCT0120008)
				.HasColumnName("PCT0120008")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0120008")
				.IsOptional();

			Property(p => p.PCT0120009)
				.HasColumnName("PCT0120009")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0120009")
				.IsOptional();

			Property(p => p.PCT0120010)
				.HasColumnName("PCT0120010")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0120010")
				.IsOptional();

			Property(p => p.PCT0120011)
				.HasColumnName("PCT0120011")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0120011")
				.IsOptional();

			Property(p => p.PCT0120012)
				.HasColumnName("PCT0120012")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0120012")
				.IsOptional();

			Property(p => p.PCT0120013)
				.HasColumnName("PCT0120013")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0120013")
				.IsOptional();

			Property(p => p.PCT0120014)
				.HasColumnName("PCT0120014")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0120014")
				.IsOptional();

			Property(p => p.PCT0120015)
				.HasColumnName("PCT0120015")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0120015")
				.IsOptional();

			Property(p => p.PCT0120016)
				.HasColumnName("PCT0120016")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0120016")
				.IsOptional();

			Property(p => p.PCT0120017)
				.HasColumnName("PCT0120017")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0120017")
				.IsOptional();

			Property(p => p.PCT0120018)
				.HasColumnName("PCT0120018")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0120018")
				.IsOptional();

			Property(p => p.PCT0120019)
				.HasColumnName("PCT0120019")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0120019")
				.IsOptional();

			Property(p => p.PCT0120020)
				.HasColumnName("PCT0120020")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0120020")
				.IsOptional();

			Property(p => p.PCT0120021)
				.HasColumnName("PCT0120021")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0120021")
				.IsOptional();

			Property(p => p.PCT0130001)
				.HasColumnName("PCT0130001")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130001")
				.IsOptional();

			Property(p => p.PCT0130002)
				.HasColumnName("PCT0130002")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130002")
				.IsOptional();

			Property(p => p.PCT0130003)
				.HasColumnName("PCT0130003")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130003")
				.IsOptional();

			Property(p => p.PCT0130004)
				.HasColumnName("PCT0130004")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130004")
				.IsOptional();

			Property(p => p.PCT0130005)
				.HasColumnName("PCT0130005")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130005")
				.IsOptional();

			Property(p => p.PCT0130006)
				.HasColumnName("PCT0130006")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130006")
				.IsOptional();

			Property(p => p.PCT0130007)
				.HasColumnName("PCT0130007")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130007")
				.IsOptional();

			Property(p => p.PCT0130008)
				.HasColumnName("PCT0130008")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130008")
				.IsOptional();

			Property(p => p.PCT0130009)
				.HasColumnName("PCT0130009")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130009")
				.IsOptional();

			Property(p => p.PCT0130010)
				.HasColumnName("PCT0130010")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130010")
				.IsOptional();

			Property(p => p.PCT0130011)
				.HasColumnName("PCT0130011")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130011")
				.IsOptional();

			Property(p => p.PCT0130012)
				.HasColumnName("PCT0130012")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130012")
				.IsOptional();

			Property(p => p.PCT0130013)
				.HasColumnName("PCT0130013")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130013")
				.IsOptional();

			Property(p => p.PCT0130014)
				.HasColumnName("PCT0130014")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130014")
				.IsOptional();

			Property(p => p.PCT0130015)
				.HasColumnName("PCT0130015")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0130015")
				.IsOptional();

			Property(p => p.PCT0140001)
				.HasColumnName("PCT0140001")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0140001")
				.IsOptional();

			Property(p => p.PCT0140002)
				.HasColumnName("PCT0140002")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0140002")
				.IsOptional();

			Property(p => p.PCT0140003)
				.HasColumnName("PCT0140003")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0140003")
				.IsOptional();

			Property(p => p.PCT0140004)
				.HasColumnName("PCT0140004")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0140004")
				.IsOptional();

			Property(p => p.PCT0140005)
				.HasColumnName("PCT0140005")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0140005")
				.IsOptional();

			Property(p => p.PCT0140006)
				.HasColumnName("PCT0140006")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0140006")
				.IsOptional();

			Property(p => p.PCT0140007)
				.HasColumnName("PCT0140007")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0140007")
				.IsOptional();

			Property(p => p.PCT0140008)
				.HasColumnName("PCT0140008")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0140008")
				.IsOptional();

			Property(p => p.PCT0140009)
				.HasColumnName("PCT0140009")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0140009")
				.IsOptional();

			Property(p => p.PCT0140010)
				.HasColumnName("PCT0140010")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0140010")
				.IsOptional();

			Property(p => p.PCT0140011)
				.HasColumnName("PCT0140011")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0140011")
				.IsOptional();

			Property(p => p.PCT0150001)
				.HasColumnName("PCT0150001")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150001")
				.IsOptional();

			Property(p => p.PCT0150002)
				.HasColumnName("PCT0150002")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150002")
				.IsOptional();

			Property(p => p.PCT0150003)
				.HasColumnName("PCT0150003")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150003")
				.IsOptional();

			Property(p => p.PCT0150004)
				.HasColumnName("PCT0150004")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150004")
				.IsOptional();

			Property(p => p.PCT0150005)
				.HasColumnName("PCT0150005")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150005")
				.IsOptional();

			Property(p => p.PCT0150006)
				.HasColumnName("PCT0150006")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150006")
				.IsOptional();

			Property(p => p.PCT0150007)
				.HasColumnName("PCT0150007")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150007")
				.IsOptional();

			Property(p => p.PCT0150008)
				.HasColumnName("PCT0150008")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150008")
				.IsOptional();

			Property(p => p.PCT0150009)
				.HasColumnName("PCT0150009")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150009")
				.IsOptional();

			Property(p => p.PCT0150010)
				.HasColumnName("PCT0150010")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150010")
				.IsOptional();

			Property(p => p.PCT0150011)
				.HasColumnName("PCT0150011")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0150011")
				.IsOptional();

			Property(p => p.PCT0160001)
				.HasColumnName("PCT0160001")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160001")
				.IsOptional();

			Property(p => p.PCT0160002)
				.HasColumnName("PCT0160002")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160002")
				.IsOptional();

			Property(p => p.PCT0160003)
				.HasColumnName("PCT0160003")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160003")
				.IsOptional();

			Property(p => p.PCT0160004)
				.HasColumnName("PCT0160004")
				.HasColumnOrder(214)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160004")
				.IsOptional();

			Property(p => p.PCT0160005)
				.HasColumnName("PCT0160005")
				.HasColumnOrder(215)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160005")
				.IsOptional();

			Property(p => p.PCT0160006)
				.HasColumnName("PCT0160006")
				.HasColumnOrder(216)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160006")
				.IsOptional();

			Property(p => p.PCT0160007)
				.HasColumnName("PCT0160007")
				.HasColumnOrder(217)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160007")
				.IsOptional();

			Property(p => p.PCT0160008)
				.HasColumnName("PCT0160008")
				.HasColumnOrder(218)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160008")
				.IsOptional();

			Property(p => p.PCT0160009)
				.HasColumnName("PCT0160009")
				.HasColumnOrder(219)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160009")
				.IsOptional();

			Property(p => p.PCT0160010)
				.HasColumnName("PCT0160010")
				.HasColumnOrder(220)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160010")
				.IsOptional();

			Property(p => p.PCT0160011)
				.HasColumnName("PCT0160011")
				.HasColumnOrder(221)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0160011")
				.IsOptional();

			Property(p => p.PCT0170001)
				.HasColumnName("PCT0170001")
				.HasColumnOrder(222)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0170001")
				.IsOptional();

			Property(p => p.PCT0170002)
				.HasColumnName("PCT0170002")
				.HasColumnOrder(223)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0170002")
				.IsOptional();

			Property(p => p.PCT0170003)
				.HasColumnName("PCT0170003")
				.HasColumnOrder(224)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0170003")
				.IsOptional();

			Property(p => p.PCT0180001)
				.HasColumnName("PCT0180001")
				.HasColumnOrder(225)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0180001")
				.IsOptional();

			Property(p => p.PCT0180002)
				.HasColumnName("PCT0180002")
				.HasColumnOrder(226)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0180002")
				.IsOptional();

			Property(p => p.PCT0180003)
				.HasColumnName("PCT0180003")
				.HasColumnOrder(227)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0180003")
				.IsOptional();
		}
	}
}
