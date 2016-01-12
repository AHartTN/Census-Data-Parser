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

	public class SummaryOne_SF1_00022Map : EntityTypeConfiguration<SummaryOne_SF1_00022>
	{
		public SummaryOne_SF1_00022Map()
		{
			ToTable("SF1_00022", "SummaryOne");

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

			Property(p => p.PCT012C001)
				.HasColumnName("PCT012C001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C001")
				.IsOptional();

			Property(p => p.PCT012C002)
				.HasColumnName("PCT012C002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C002")
				.IsOptional();

			Property(p => p.PCT012C003)
				.HasColumnName("PCT012C003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C003")
				.IsOptional();

			Property(p => p.PCT012C004)
				.HasColumnName("PCT012C004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C004")
				.IsOptional();

			Property(p => p.PCT012C005)
				.HasColumnName("PCT012C005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C005")
				.IsOptional();

			Property(p => p.PCT012C006)
				.HasColumnName("PCT012C006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C006")
				.IsOptional();

			Property(p => p.PCT012C007)
				.HasColumnName("PCT012C007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C007")
				.IsOptional();

			Property(p => p.PCT012C008)
				.HasColumnName("PCT012C008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C008")
				.IsOptional();

			Property(p => p.PCT012C009)
				.HasColumnName("PCT012C009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C009")
				.IsOptional();

			Property(p => p.PCT012C010)
				.HasColumnName("PCT012C010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C010")
				.IsOptional();

			Property(p => p.PCT012C011)
				.HasColumnName("PCT012C011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C011")
				.IsOptional();

			Property(p => p.PCT012C012)
				.HasColumnName("PCT012C012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C012")
				.IsOptional();

			Property(p => p.PCT012C013)
				.HasColumnName("PCT012C013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C013")
				.IsOptional();

			Property(p => p.PCT012C014)
				.HasColumnName("PCT012C014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C014")
				.IsOptional();

			Property(p => p.PCT012C015)
				.HasColumnName("PCT012C015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C015")
				.IsOptional();

			Property(p => p.PCT012C016)
				.HasColumnName("PCT012C016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C016")
				.IsOptional();

			Property(p => p.PCT012C017)
				.HasColumnName("PCT012C017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C017")
				.IsOptional();

			Property(p => p.PCT012C018)
				.HasColumnName("PCT012C018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C018")
				.IsOptional();

			Property(p => p.PCT012C019)
				.HasColumnName("PCT012C019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C019")
				.IsOptional();

			Property(p => p.PCT012C020)
				.HasColumnName("PCT012C020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C020")
				.IsOptional();

			Property(p => p.PCT012C021)
				.HasColumnName("PCT012C021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C021")
				.IsOptional();

			Property(p => p.PCT012C022)
				.HasColumnName("PCT012C022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C022")
				.IsOptional();

			Property(p => p.PCT012C023)
				.HasColumnName("PCT012C023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C023")
				.IsOptional();

			Property(p => p.PCT012C024)
				.HasColumnName("PCT012C024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C024")
				.IsOptional();

			Property(p => p.PCT012C025)
				.HasColumnName("PCT012C025")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C025")
				.IsOptional();

			Property(p => p.PCT012C026)
				.HasColumnName("PCT012C026")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C026")
				.IsOptional();

			Property(p => p.PCT012C027)
				.HasColumnName("PCT012C027")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C027")
				.IsOptional();

			Property(p => p.PCT012C028)
				.HasColumnName("PCT012C028")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C028")
				.IsOptional();

			Property(p => p.PCT012C029)
				.HasColumnName("PCT012C029")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C029")
				.IsOptional();

			Property(p => p.PCT012C030)
				.HasColumnName("PCT012C030")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C030")
				.IsOptional();

			Property(p => p.PCT012C031)
				.HasColumnName("PCT012C031")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C031")
				.IsOptional();

			Property(p => p.PCT012C032)
				.HasColumnName("PCT012C032")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C032")
				.IsOptional();

			Property(p => p.PCT012C033)
				.HasColumnName("PCT012C033")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C033")
				.IsOptional();

			Property(p => p.PCT012C034)
				.HasColumnName("PCT012C034")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C034")
				.IsOptional();

			Property(p => p.PCT012C035)
				.HasColumnName("PCT012C035")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C035")
				.IsOptional();

			Property(p => p.PCT012C036)
				.HasColumnName("PCT012C036")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C036")
				.IsOptional();

			Property(p => p.PCT012C037)
				.HasColumnName("PCT012C037")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C037")
				.IsOptional();

			Property(p => p.PCT012C038)
				.HasColumnName("PCT012C038")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C038")
				.IsOptional();

			Property(p => p.PCT012C039)
				.HasColumnName("PCT012C039")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C039")
				.IsOptional();

			Property(p => p.PCT012C040)
				.HasColumnName("PCT012C040")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C040")
				.IsOptional();

			Property(p => p.PCT012C041)
				.HasColumnName("PCT012C041")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C041")
				.IsOptional();

			Property(p => p.PCT012C042)
				.HasColumnName("PCT012C042")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C042")
				.IsOptional();

			Property(p => p.PCT012C043)
				.HasColumnName("PCT012C043")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C043")
				.IsOptional();

			Property(p => p.PCT012C044)
				.HasColumnName("PCT012C044")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C044")
				.IsOptional();

			Property(p => p.PCT012C045)
				.HasColumnName("PCT012C045")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C045")
				.IsOptional();

			Property(p => p.PCT012C046)
				.HasColumnName("PCT012C046")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C046")
				.IsOptional();

			Property(p => p.PCT012C047)
				.HasColumnName("PCT012C047")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C047")
				.IsOptional();

			Property(p => p.PCT012C048)
				.HasColumnName("PCT012C048")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C048")
				.IsOptional();

			Property(p => p.PCT012C049)
				.HasColumnName("PCT012C049")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C049")
				.IsOptional();

			Property(p => p.PCT012C050)
				.HasColumnName("PCT012C050")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C050")
				.IsOptional();

			Property(p => p.PCT012C051)
				.HasColumnName("PCT012C051")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C051")
				.IsOptional();

			Property(p => p.PCT012C052)
				.HasColumnName("PCT012C052")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C052")
				.IsOptional();

			Property(p => p.PCT012C053)
				.HasColumnName("PCT012C053")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C053")
				.IsOptional();

			Property(p => p.PCT012C054)
				.HasColumnName("PCT012C054")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C054")
				.IsOptional();

			Property(p => p.PCT012C055)
				.HasColumnName("PCT012C055")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C055")
				.IsOptional();

			Property(p => p.PCT012C056)
				.HasColumnName("PCT012C056")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C056")
				.IsOptional();

			Property(p => p.PCT012C057)
				.HasColumnName("PCT012C057")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C057")
				.IsOptional();

			Property(p => p.PCT012C058)
				.HasColumnName("PCT012C058")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C058")
				.IsOptional();

			Property(p => p.PCT012C059)
				.HasColumnName("PCT012C059")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C059")
				.IsOptional();

			Property(p => p.PCT012C060)
				.HasColumnName("PCT012C060")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C060")
				.IsOptional();

			Property(p => p.PCT012C061)
				.HasColumnName("PCT012C061")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C061")
				.IsOptional();

			Property(p => p.PCT012C062)
				.HasColumnName("PCT012C062")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C062")
				.IsOptional();

			Property(p => p.PCT012C063)
				.HasColumnName("PCT012C063")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C063")
				.IsOptional();

			Property(p => p.PCT012C064)
				.HasColumnName("PCT012C064")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C064")
				.IsOptional();

			Property(p => p.PCT012C065)
				.HasColumnName("PCT012C065")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C065")
				.IsOptional();

			Property(p => p.PCT012C066)
				.HasColumnName("PCT012C066")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C066")
				.IsOptional();

			Property(p => p.PCT012C067)
				.HasColumnName("PCT012C067")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C067")
				.IsOptional();

			Property(p => p.PCT012C068)
				.HasColumnName("PCT012C068")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C068")
				.IsOptional();

			Property(p => p.PCT012C069)
				.HasColumnName("PCT012C069")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C069")
				.IsOptional();

			Property(p => p.PCT012C070)
				.HasColumnName("PCT012C070")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C070")
				.IsOptional();

			Property(p => p.PCT012C071)
				.HasColumnName("PCT012C071")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C071")
				.IsOptional();

			Property(p => p.PCT012C072)
				.HasColumnName("PCT012C072")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C072")
				.IsOptional();

			Property(p => p.PCT012C073)
				.HasColumnName("PCT012C073")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C073")
				.IsOptional();

			Property(p => p.PCT012C074)
				.HasColumnName("PCT012C074")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C074")
				.IsOptional();

			Property(p => p.PCT012C075)
				.HasColumnName("PCT012C075")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C075")
				.IsOptional();

			Property(p => p.PCT012C076)
				.HasColumnName("PCT012C076")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C076")
				.IsOptional();

			Property(p => p.PCT012C077)
				.HasColumnName("PCT012C077")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C077")
				.IsOptional();

			Property(p => p.PCT012C078)
				.HasColumnName("PCT012C078")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C078")
				.IsOptional();

			Property(p => p.PCT012C079)
				.HasColumnName("PCT012C079")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C079")
				.IsOptional();

			Property(p => p.PCT012C080)
				.HasColumnName("PCT012C080")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C080")
				.IsOptional();

			Property(p => p.PCT012C081)
				.HasColumnName("PCT012C081")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C081")
				.IsOptional();

			Property(p => p.PCT012C082)
				.HasColumnName("PCT012C082")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C082")
				.IsOptional();

			Property(p => p.PCT012C083)
				.HasColumnName("PCT012C083")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C083")
				.IsOptional();

			Property(p => p.PCT012C084)
				.HasColumnName("PCT012C084")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C084")
				.IsOptional();

			Property(p => p.PCT012C085)
				.HasColumnName("PCT012C085")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C085")
				.IsOptional();

			Property(p => p.PCT012C086)
				.HasColumnName("PCT012C086")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C086")
				.IsOptional();

			Property(p => p.PCT012C087)
				.HasColumnName("PCT012C087")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C087")
				.IsOptional();

			Property(p => p.PCT012C088)
				.HasColumnName("PCT012C088")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C088")
				.IsOptional();

			Property(p => p.PCT012C089)
				.HasColumnName("PCT012C089")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C089")
				.IsOptional();

			Property(p => p.PCT012C090)
				.HasColumnName("PCT012C090")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C090")
				.IsOptional();

			Property(p => p.PCT012C091)
				.HasColumnName("PCT012C091")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C091")
				.IsOptional();

			Property(p => p.PCT012C092)
				.HasColumnName("PCT012C092")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C092")
				.IsOptional();

			Property(p => p.PCT012C093)
				.HasColumnName("PCT012C093")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C093")
				.IsOptional();

			Property(p => p.PCT012C094)
				.HasColumnName("PCT012C094")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C094")
				.IsOptional();

			Property(p => p.PCT012C095)
				.HasColumnName("PCT012C095")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C095")
				.IsOptional();

			Property(p => p.PCT012C096)
				.HasColumnName("PCT012C096")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C096")
				.IsOptional();

			Property(p => p.PCT012C097)
				.HasColumnName("PCT012C097")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C097")
				.IsOptional();

			Property(p => p.PCT012C098)
				.HasColumnName("PCT012C098")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C098")
				.IsOptional();

			Property(p => p.PCT012C099)
				.HasColumnName("PCT012C099")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C099")
				.IsOptional();

			Property(p => p.PCT012C100)
				.HasColumnName("PCT012C100")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C100")
				.IsOptional();

			Property(p => p.PCT012C101)
				.HasColumnName("PCT012C101")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C101")
				.IsOptional();

			Property(p => p.PCT012C102)
				.HasColumnName("PCT012C102")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C102")
				.IsOptional();

			Property(p => p.PCT012C103)
				.HasColumnName("PCT012C103")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C103")
				.IsOptional();

			Property(p => p.PCT012C104)
				.HasColumnName("PCT012C104")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C104")
				.IsOptional();

			Property(p => p.PCT012C105)
				.HasColumnName("PCT012C105")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C105")
				.IsOptional();

			Property(p => p.PCT012C106)
				.HasColumnName("PCT012C106")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C106")
				.IsOptional();

			Property(p => p.PCT012C107)
				.HasColumnName("PCT012C107")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C107")
				.IsOptional();

			Property(p => p.PCT012C108)
				.HasColumnName("PCT012C108")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C108")
				.IsOptional();

			Property(p => p.PCT012C109)
				.HasColumnName("PCT012C109")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C109")
				.IsOptional();

			Property(p => p.PCT012C110)
				.HasColumnName("PCT012C110")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C110")
				.IsOptional();

			Property(p => p.PCT012C111)
				.HasColumnName("PCT012C111")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C111")
				.IsOptional();

			Property(p => p.PCT012C112)
				.HasColumnName("PCT012C112")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C112")
				.IsOptional();

			Property(p => p.PCT012C113)
				.HasColumnName("PCT012C113")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C113")
				.IsOptional();

			Property(p => p.PCT012C114)
				.HasColumnName("PCT012C114")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C114")
				.IsOptional();

			Property(p => p.PCT012C115)
				.HasColumnName("PCT012C115")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C115")
				.IsOptional();

			Property(p => p.PCT012C116)
				.HasColumnName("PCT012C116")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C116")
				.IsOptional();

			Property(p => p.PCT012C117)
				.HasColumnName("PCT012C117")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C117")
				.IsOptional();

			Property(p => p.PCT012C118)
				.HasColumnName("PCT012C118")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C118")
				.IsOptional();

			Property(p => p.PCT012C119)
				.HasColumnName("PCT012C119")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C119")
				.IsOptional();

			Property(p => p.PCT012C120)
				.HasColumnName("PCT012C120")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C120")
				.IsOptional();

			Property(p => p.PCT012C121)
				.HasColumnName("PCT012C121")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C121")
				.IsOptional();

			Property(p => p.PCT012C122)
				.HasColumnName("PCT012C122")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C122")
				.IsOptional();

			Property(p => p.PCT012C123)
				.HasColumnName("PCT012C123")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C123")
				.IsOptional();

			Property(p => p.PCT012C124)
				.HasColumnName("PCT012C124")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C124")
				.IsOptional();

			Property(p => p.PCT012C125)
				.HasColumnName("PCT012C125")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C125")
				.IsOptional();

			Property(p => p.PCT012C126)
				.HasColumnName("PCT012C126")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C126")
				.IsOptional();

			Property(p => p.PCT012C127)
				.HasColumnName("PCT012C127")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C127")
				.IsOptional();

			Property(p => p.PCT012C128)
				.HasColumnName("PCT012C128")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C128")
				.IsOptional();

			Property(p => p.PCT012C129)
				.HasColumnName("PCT012C129")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C129")
				.IsOptional();

			Property(p => p.PCT012C130)
				.HasColumnName("PCT012C130")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C130")
				.IsOptional();

			Property(p => p.PCT012C131)
				.HasColumnName("PCT012C131")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C131")
				.IsOptional();

			Property(p => p.PCT012C132)
				.HasColumnName("PCT012C132")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C132")
				.IsOptional();

			Property(p => p.PCT012C133)
				.HasColumnName("PCT012C133")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C133")
				.IsOptional();

			Property(p => p.PCT012C134)
				.HasColumnName("PCT012C134")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C134")
				.IsOptional();

			Property(p => p.PCT012C135)
				.HasColumnName("PCT012C135")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C135")
				.IsOptional();

			Property(p => p.PCT012C136)
				.HasColumnName("PCT012C136")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C136")
				.IsOptional();

			Property(p => p.PCT012C137)
				.HasColumnName("PCT012C137")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C137")
				.IsOptional();

			Property(p => p.PCT012C138)
				.HasColumnName("PCT012C138")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C138")
				.IsOptional();

			Property(p => p.PCT012C139)
				.HasColumnName("PCT012C139")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C139")
				.IsOptional();

			Property(p => p.PCT012C140)
				.HasColumnName("PCT012C140")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C140")
				.IsOptional();

			Property(p => p.PCT012C141)
				.HasColumnName("PCT012C141")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C141")
				.IsOptional();

			Property(p => p.PCT012C142)
				.HasColumnName("PCT012C142")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C142")
				.IsOptional();

			Property(p => p.PCT012C143)
				.HasColumnName("PCT012C143")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C143")
				.IsOptional();

			Property(p => p.PCT012C144)
				.HasColumnName("PCT012C144")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C144")
				.IsOptional();

			Property(p => p.PCT012C145)
				.HasColumnName("PCT012C145")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C145")
				.IsOptional();

			Property(p => p.PCT012C146)
				.HasColumnName("PCT012C146")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C146")
				.IsOptional();

			Property(p => p.PCT012C147)
				.HasColumnName("PCT012C147")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C147")
				.IsOptional();

			Property(p => p.PCT012C148)
				.HasColumnName("PCT012C148")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C148")
				.IsOptional();

			Property(p => p.PCT012C149)
				.HasColumnName("PCT012C149")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C149")
				.IsOptional();

			Property(p => p.PCT012C150)
				.HasColumnName("PCT012C150")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C150")
				.IsOptional();

			Property(p => p.PCT012C151)
				.HasColumnName("PCT012C151")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C151")
				.IsOptional();

			Property(p => p.PCT012C152)
				.HasColumnName("PCT012C152")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C152")
				.IsOptional();

			Property(p => p.PCT012C153)
				.HasColumnName("PCT012C153")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C153")
				.IsOptional();

			Property(p => p.PCT012C154)
				.HasColumnName("PCT012C154")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C154")
				.IsOptional();

			Property(p => p.PCT012C155)
				.HasColumnName("PCT012C155")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C155")
				.IsOptional();

			Property(p => p.PCT012C156)
				.HasColumnName("PCT012C156")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C156")
				.IsOptional();

			Property(p => p.PCT012C157)
				.HasColumnName("PCT012C157")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C157")
				.IsOptional();

			Property(p => p.PCT012C158)
				.HasColumnName("PCT012C158")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C158")
				.IsOptional();

			Property(p => p.PCT012C159)
				.HasColumnName("PCT012C159")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C159")
				.IsOptional();

			Property(p => p.PCT012C160)
				.HasColumnName("PCT012C160")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C160")
				.IsOptional();

			Property(p => p.PCT012C161)
				.HasColumnName("PCT012C161")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C161")
				.IsOptional();

			Property(p => p.PCT012C162)
				.HasColumnName("PCT012C162")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C162")
				.IsOptional();

			Property(p => p.PCT012C163)
				.HasColumnName("PCT012C163")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C163")
				.IsOptional();

			Property(p => p.PCT012C164)
				.HasColumnName("PCT012C164")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C164")
				.IsOptional();

			Property(p => p.PCT012C165)
				.HasColumnName("PCT012C165")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C165")
				.IsOptional();

			Property(p => p.PCT012C166)
				.HasColumnName("PCT012C166")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C166")
				.IsOptional();

			Property(p => p.PCT012C167)
				.HasColumnName("PCT012C167")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C167")
				.IsOptional();

			Property(p => p.PCT012C168)
				.HasColumnName("PCT012C168")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C168")
				.IsOptional();

			Property(p => p.PCT012C169)
				.HasColumnName("PCT012C169")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C169")
				.IsOptional();

			Property(p => p.PCT012C170)
				.HasColumnName("PCT012C170")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C170")
				.IsOptional();

			Property(p => p.PCT012C171)
				.HasColumnName("PCT012C171")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C171")
				.IsOptional();

			Property(p => p.PCT012C172)
				.HasColumnName("PCT012C172")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C172")
				.IsOptional();

			Property(p => p.PCT012C173)
				.HasColumnName("PCT012C173")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C173")
				.IsOptional();

			Property(p => p.PCT012C174)
				.HasColumnName("PCT012C174")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C174")
				.IsOptional();

			Property(p => p.PCT012C175)
				.HasColumnName("PCT012C175")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C175")
				.IsOptional();

			Property(p => p.PCT012C176)
				.HasColumnName("PCT012C176")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C176")
				.IsOptional();

			Property(p => p.PCT012C177)
				.HasColumnName("PCT012C177")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C177")
				.IsOptional();

			Property(p => p.PCT012C178)
				.HasColumnName("PCT012C178")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C178")
				.IsOptional();

			Property(p => p.PCT012C179)
				.HasColumnName("PCT012C179")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C179")
				.IsOptional();

			Property(p => p.PCT012C180)
				.HasColumnName("PCT012C180")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C180")
				.IsOptional();

			Property(p => p.PCT012C181)
				.HasColumnName("PCT012C181")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C181")
				.IsOptional();

			Property(p => p.PCT012C182)
				.HasColumnName("PCT012C182")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C182")
				.IsOptional();

			Property(p => p.PCT012C183)
				.HasColumnName("PCT012C183")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C183")
				.IsOptional();

			Property(p => p.PCT012C184)
				.HasColumnName("PCT012C184")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C184")
				.IsOptional();

			Property(p => p.PCT012C185)
				.HasColumnName("PCT012C185")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C185")
				.IsOptional();

			Property(p => p.PCT012C186)
				.HasColumnName("PCT012C186")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C186")
				.IsOptional();

			Property(p => p.PCT012C187)
				.HasColumnName("PCT012C187")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C187")
				.IsOptional();

			Property(p => p.PCT012C188)
				.HasColumnName("PCT012C188")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C188")
				.IsOptional();

			Property(p => p.PCT012C189)
				.HasColumnName("PCT012C189")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C189")
				.IsOptional();

			Property(p => p.PCT012C190)
				.HasColumnName("PCT012C190")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C190")
				.IsOptional();

			Property(p => p.PCT012C191)
				.HasColumnName("PCT012C191")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C191")
				.IsOptional();

			Property(p => p.PCT012C192)
				.HasColumnName("PCT012C192")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C192")
				.IsOptional();

			Property(p => p.PCT012C193)
				.HasColumnName("PCT012C193")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C193")
				.IsOptional();

			Property(p => p.PCT012C194)
				.HasColumnName("PCT012C194")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C194")
				.IsOptional();

			Property(p => p.PCT012C195)
				.HasColumnName("PCT012C195")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C195")
				.IsOptional();

			Property(p => p.PCT012C196)
				.HasColumnName("PCT012C196")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C196")
				.IsOptional();

			Property(p => p.PCT012C197)
				.HasColumnName("PCT012C197")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C197")
				.IsOptional();

			Property(p => p.PCT012C198)
				.HasColumnName("PCT012C198")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C198")
				.IsOptional();

			Property(p => p.PCT012C199)
				.HasColumnName("PCT012C199")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C199")
				.IsOptional();

			Property(p => p.PCT012C200)
				.HasColumnName("PCT012C200")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C200")
				.IsOptional();

			Property(p => p.PCT012C201)
				.HasColumnName("PCT012C201")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C201")
				.IsOptional();

			Property(p => p.PCT012C202)
				.HasColumnName("PCT012C202")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C202")
				.IsOptional();

			Property(p => p.PCT012C203)
				.HasColumnName("PCT012C203")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C203")
				.IsOptional();

			Property(p => p.PCT012C204)
				.HasColumnName("PCT012C204")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C204")
				.IsOptional();

			Property(p => p.PCT012C205)
				.HasColumnName("PCT012C205")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C205")
				.IsOptional();

			Property(p => p.PCT012C206)
				.HasColumnName("PCT012C206")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C206")
				.IsOptional();

			Property(p => p.PCT012C207)
				.HasColumnName("PCT012C207")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C207")
				.IsOptional();

			Property(p => p.PCT012C208)
				.HasColumnName("PCT012C208")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C208")
				.IsOptional();

			Property(p => p.PCT012C209)
				.HasColumnName("PCT012C209")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012C209")
				.IsOptional();
		}
	}
}
