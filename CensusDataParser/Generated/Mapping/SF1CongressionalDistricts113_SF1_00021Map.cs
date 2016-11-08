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

	public class SF1CongressionalDistricts113_SF1_00021Map : EntityTypeConfiguration<SF1CongressionalDistricts113_SF1_00021>
	{
		public SF1CongressionalDistricts113_SF1_00021Map()
		{
			ToTable("SF1_00021", "SF1CongressionalDistricts113");

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

			Property(p => p.PCT012B001)
				.HasColumnName("PCT012B001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B001")
				.IsOptional();

			Property(p => p.PCT012B002)
				.HasColumnName("PCT012B002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B002")
				.IsOptional();

			Property(p => p.PCT012B003)
				.HasColumnName("PCT012B003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B003")
				.IsOptional();

			Property(p => p.PCT012B004)
				.HasColumnName("PCT012B004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B004")
				.IsOptional();

			Property(p => p.PCT012B005)
				.HasColumnName("PCT012B005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B005")
				.IsOptional();

			Property(p => p.PCT012B006)
				.HasColumnName("PCT012B006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B006")
				.IsOptional();

			Property(p => p.PCT012B007)
				.HasColumnName("PCT012B007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B007")
				.IsOptional();

			Property(p => p.PCT012B008)
				.HasColumnName("PCT012B008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B008")
				.IsOptional();

			Property(p => p.PCT012B009)
				.HasColumnName("PCT012B009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B009")
				.IsOptional();

			Property(p => p.PCT012B010)
				.HasColumnName("PCT012B010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B010")
				.IsOptional();

			Property(p => p.PCT012B011)
				.HasColumnName("PCT012B011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B011")
				.IsOptional();

			Property(p => p.PCT012B012)
				.HasColumnName("PCT012B012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B012")
				.IsOptional();

			Property(p => p.PCT012B013)
				.HasColumnName("PCT012B013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B013")
				.IsOptional();

			Property(p => p.PCT012B014)
				.HasColumnName("PCT012B014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B014")
				.IsOptional();

			Property(p => p.PCT012B015)
				.HasColumnName("PCT012B015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B015")
				.IsOptional();

			Property(p => p.PCT012B016)
				.HasColumnName("PCT012B016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B016")
				.IsOptional();

			Property(p => p.PCT012B017)
				.HasColumnName("PCT012B017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B017")
				.IsOptional();

			Property(p => p.PCT012B018)
				.HasColumnName("PCT012B018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B018")
				.IsOptional();

			Property(p => p.PCT012B019)
				.HasColumnName("PCT012B019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B019")
				.IsOptional();

			Property(p => p.PCT012B020)
				.HasColumnName("PCT012B020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B020")
				.IsOptional();

			Property(p => p.PCT012B021)
				.HasColumnName("PCT012B021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B021")
				.IsOptional();

			Property(p => p.PCT012B022)
				.HasColumnName("PCT012B022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B022")
				.IsOptional();

			Property(p => p.PCT012B023)
				.HasColumnName("PCT012B023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B023")
				.IsOptional();

			Property(p => p.PCT012B024)
				.HasColumnName("PCT012B024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B024")
				.IsOptional();

			Property(p => p.PCT012B025)
				.HasColumnName("PCT012B025")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B025")
				.IsOptional();

			Property(p => p.PCT012B026)
				.HasColumnName("PCT012B026")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B026")
				.IsOptional();

			Property(p => p.PCT012B027)
				.HasColumnName("PCT012B027")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B027")
				.IsOptional();

			Property(p => p.PCT012B028)
				.HasColumnName("PCT012B028")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B028")
				.IsOptional();

			Property(p => p.PCT012B029)
				.HasColumnName("PCT012B029")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B029")
				.IsOptional();

			Property(p => p.PCT012B030)
				.HasColumnName("PCT012B030")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B030")
				.IsOptional();

			Property(p => p.PCT012B031)
				.HasColumnName("PCT012B031")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B031")
				.IsOptional();

			Property(p => p.PCT012B032)
				.HasColumnName("PCT012B032")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B032")
				.IsOptional();

			Property(p => p.PCT012B033)
				.HasColumnName("PCT012B033")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B033")
				.IsOptional();

			Property(p => p.PCT012B034)
				.HasColumnName("PCT012B034")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B034")
				.IsOptional();

			Property(p => p.PCT012B035)
				.HasColumnName("PCT012B035")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B035")
				.IsOptional();

			Property(p => p.PCT012B036)
				.HasColumnName("PCT012B036")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B036")
				.IsOptional();

			Property(p => p.PCT012B037)
				.HasColumnName("PCT012B037")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B037")
				.IsOptional();

			Property(p => p.PCT012B038)
				.HasColumnName("PCT012B038")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B038")
				.IsOptional();

			Property(p => p.PCT012B039)
				.HasColumnName("PCT012B039")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B039")
				.IsOptional();

			Property(p => p.PCT012B040)
				.HasColumnName("PCT012B040")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B040")
				.IsOptional();

			Property(p => p.PCT012B041)
				.HasColumnName("PCT012B041")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B041")
				.IsOptional();

			Property(p => p.PCT012B042)
				.HasColumnName("PCT012B042")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B042")
				.IsOptional();

			Property(p => p.PCT012B043)
				.HasColumnName("PCT012B043")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B043")
				.IsOptional();

			Property(p => p.PCT012B044)
				.HasColumnName("PCT012B044")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B044")
				.IsOptional();

			Property(p => p.PCT012B045)
				.HasColumnName("PCT012B045")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B045")
				.IsOptional();

			Property(p => p.PCT012B046)
				.HasColumnName("PCT012B046")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B046")
				.IsOptional();

			Property(p => p.PCT012B047)
				.HasColumnName("PCT012B047")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B047")
				.IsOptional();

			Property(p => p.PCT012B048)
				.HasColumnName("PCT012B048")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B048")
				.IsOptional();

			Property(p => p.PCT012B049)
				.HasColumnName("PCT012B049")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B049")
				.IsOptional();

			Property(p => p.PCT012B050)
				.HasColumnName("PCT012B050")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B050")
				.IsOptional();

			Property(p => p.PCT012B051)
				.HasColumnName("PCT012B051")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B051")
				.IsOptional();

			Property(p => p.PCT012B052)
				.HasColumnName("PCT012B052")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B052")
				.IsOptional();

			Property(p => p.PCT012B053)
				.HasColumnName("PCT012B053")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B053")
				.IsOptional();

			Property(p => p.PCT012B054)
				.HasColumnName("PCT012B054")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B054")
				.IsOptional();

			Property(p => p.PCT012B055)
				.HasColumnName("PCT012B055")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B055")
				.IsOptional();

			Property(p => p.PCT012B056)
				.HasColumnName("PCT012B056")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B056")
				.IsOptional();

			Property(p => p.PCT012B057)
				.HasColumnName("PCT012B057")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B057")
				.IsOptional();

			Property(p => p.PCT012B058)
				.HasColumnName("PCT012B058")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B058")
				.IsOptional();

			Property(p => p.PCT012B059)
				.HasColumnName("PCT012B059")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B059")
				.IsOptional();

			Property(p => p.PCT012B060)
				.HasColumnName("PCT012B060")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B060")
				.IsOptional();

			Property(p => p.PCT012B061)
				.HasColumnName("PCT012B061")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B061")
				.IsOptional();

			Property(p => p.PCT012B062)
				.HasColumnName("PCT012B062")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B062")
				.IsOptional();

			Property(p => p.PCT012B063)
				.HasColumnName("PCT012B063")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B063")
				.IsOptional();

			Property(p => p.PCT012B064)
				.HasColumnName("PCT012B064")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B064")
				.IsOptional();

			Property(p => p.PCT012B065)
				.HasColumnName("PCT012B065")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B065")
				.IsOptional();

			Property(p => p.PCT012B066)
				.HasColumnName("PCT012B066")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B066")
				.IsOptional();

			Property(p => p.PCT012B067)
				.HasColumnName("PCT012B067")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B067")
				.IsOptional();

			Property(p => p.PCT012B068)
				.HasColumnName("PCT012B068")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B068")
				.IsOptional();

			Property(p => p.PCT012B069)
				.HasColumnName("PCT012B069")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B069")
				.IsOptional();

			Property(p => p.PCT012B070)
				.HasColumnName("PCT012B070")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B070")
				.IsOptional();

			Property(p => p.PCT012B071)
				.HasColumnName("PCT012B071")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B071")
				.IsOptional();

			Property(p => p.PCT012B072)
				.HasColumnName("PCT012B072")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B072")
				.IsOptional();

			Property(p => p.PCT012B073)
				.HasColumnName("PCT012B073")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B073")
				.IsOptional();

			Property(p => p.PCT012B074)
				.HasColumnName("PCT012B074")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B074")
				.IsOptional();

			Property(p => p.PCT012B075)
				.HasColumnName("PCT012B075")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B075")
				.IsOptional();

			Property(p => p.PCT012B076)
				.HasColumnName("PCT012B076")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B076")
				.IsOptional();

			Property(p => p.PCT012B077)
				.HasColumnName("PCT012B077")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B077")
				.IsOptional();

			Property(p => p.PCT012B078)
				.HasColumnName("PCT012B078")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B078")
				.IsOptional();

			Property(p => p.PCT012B079)
				.HasColumnName("PCT012B079")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B079")
				.IsOptional();

			Property(p => p.PCT012B080)
				.HasColumnName("PCT012B080")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B080")
				.IsOptional();

			Property(p => p.PCT012B081)
				.HasColumnName("PCT012B081")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B081")
				.IsOptional();

			Property(p => p.PCT012B082)
				.HasColumnName("PCT012B082")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B082")
				.IsOptional();

			Property(p => p.PCT012B083)
				.HasColumnName("PCT012B083")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B083")
				.IsOptional();

			Property(p => p.PCT012B084)
				.HasColumnName("PCT012B084")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B084")
				.IsOptional();

			Property(p => p.PCT012B085)
				.HasColumnName("PCT012B085")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B085")
				.IsOptional();

			Property(p => p.PCT012B086)
				.HasColumnName("PCT012B086")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B086")
				.IsOptional();

			Property(p => p.PCT012B087)
				.HasColumnName("PCT012B087")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B087")
				.IsOptional();

			Property(p => p.PCT012B088)
				.HasColumnName("PCT012B088")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B088")
				.IsOptional();

			Property(p => p.PCT012B089)
				.HasColumnName("PCT012B089")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B089")
				.IsOptional();

			Property(p => p.PCT012B090)
				.HasColumnName("PCT012B090")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B090")
				.IsOptional();

			Property(p => p.PCT012B091)
				.HasColumnName("PCT012B091")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B091")
				.IsOptional();

			Property(p => p.PCT012B092)
				.HasColumnName("PCT012B092")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B092")
				.IsOptional();

			Property(p => p.PCT012B093)
				.HasColumnName("PCT012B093")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B093")
				.IsOptional();

			Property(p => p.PCT012B094)
				.HasColumnName("PCT012B094")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B094")
				.IsOptional();

			Property(p => p.PCT012B095)
				.HasColumnName("PCT012B095")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B095")
				.IsOptional();

			Property(p => p.PCT012B096)
				.HasColumnName("PCT012B096")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B096")
				.IsOptional();

			Property(p => p.PCT012B097)
				.HasColumnName("PCT012B097")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B097")
				.IsOptional();

			Property(p => p.PCT012B098)
				.HasColumnName("PCT012B098")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B098")
				.IsOptional();

			Property(p => p.PCT012B099)
				.HasColumnName("PCT012B099")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B099")
				.IsOptional();

			Property(p => p.PCT012B100)
				.HasColumnName("PCT012B100")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B100")
				.IsOptional();

			Property(p => p.PCT012B101)
				.HasColumnName("PCT012B101")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B101")
				.IsOptional();

			Property(p => p.PCT012B102)
				.HasColumnName("PCT012B102")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B102")
				.IsOptional();

			Property(p => p.PCT012B103)
				.HasColumnName("PCT012B103")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B103")
				.IsOptional();

			Property(p => p.PCT012B104)
				.HasColumnName("PCT012B104")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B104")
				.IsOptional();

			Property(p => p.PCT012B105)
				.HasColumnName("PCT012B105")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B105")
				.IsOptional();

			Property(p => p.PCT012B106)
				.HasColumnName("PCT012B106")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B106")
				.IsOptional();

			Property(p => p.PCT012B107)
				.HasColumnName("PCT012B107")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B107")
				.IsOptional();

			Property(p => p.PCT012B108)
				.HasColumnName("PCT012B108")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B108")
				.IsOptional();

			Property(p => p.PCT012B109)
				.HasColumnName("PCT012B109")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B109")
				.IsOptional();

			Property(p => p.PCT012B110)
				.HasColumnName("PCT012B110")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B110")
				.IsOptional();

			Property(p => p.PCT012B111)
				.HasColumnName("PCT012B111")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B111")
				.IsOptional();

			Property(p => p.PCT012B112)
				.HasColumnName("PCT012B112")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B112")
				.IsOptional();

			Property(p => p.PCT012B113)
				.HasColumnName("PCT012B113")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B113")
				.IsOptional();

			Property(p => p.PCT012B114)
				.HasColumnName("PCT012B114")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B114")
				.IsOptional();

			Property(p => p.PCT012B115)
				.HasColumnName("PCT012B115")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B115")
				.IsOptional();

			Property(p => p.PCT012B116)
				.HasColumnName("PCT012B116")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B116")
				.IsOptional();

			Property(p => p.PCT012B117)
				.HasColumnName("PCT012B117")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B117")
				.IsOptional();

			Property(p => p.PCT012B118)
				.HasColumnName("PCT012B118")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B118")
				.IsOptional();

			Property(p => p.PCT012B119)
				.HasColumnName("PCT012B119")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B119")
				.IsOptional();

			Property(p => p.PCT012B120)
				.HasColumnName("PCT012B120")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B120")
				.IsOptional();

			Property(p => p.PCT012B121)
				.HasColumnName("PCT012B121")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B121")
				.IsOptional();

			Property(p => p.PCT012B122)
				.HasColumnName("PCT012B122")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B122")
				.IsOptional();

			Property(p => p.PCT012B123)
				.HasColumnName("PCT012B123")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B123")
				.IsOptional();

			Property(p => p.PCT012B124)
				.HasColumnName("PCT012B124")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B124")
				.IsOptional();

			Property(p => p.PCT012B125)
				.HasColumnName("PCT012B125")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B125")
				.IsOptional();

			Property(p => p.PCT012B126)
				.HasColumnName("PCT012B126")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B126")
				.IsOptional();

			Property(p => p.PCT012B127)
				.HasColumnName("PCT012B127")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B127")
				.IsOptional();

			Property(p => p.PCT012B128)
				.HasColumnName("PCT012B128")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B128")
				.IsOptional();

			Property(p => p.PCT012B129)
				.HasColumnName("PCT012B129")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B129")
				.IsOptional();

			Property(p => p.PCT012B130)
				.HasColumnName("PCT012B130")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B130")
				.IsOptional();

			Property(p => p.PCT012B131)
				.HasColumnName("PCT012B131")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B131")
				.IsOptional();

			Property(p => p.PCT012B132)
				.HasColumnName("PCT012B132")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B132")
				.IsOptional();

			Property(p => p.PCT012B133)
				.HasColumnName("PCT012B133")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B133")
				.IsOptional();

			Property(p => p.PCT012B134)
				.HasColumnName("PCT012B134")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B134")
				.IsOptional();

			Property(p => p.PCT012B135)
				.HasColumnName("PCT012B135")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B135")
				.IsOptional();

			Property(p => p.PCT012B136)
				.HasColumnName("PCT012B136")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B136")
				.IsOptional();

			Property(p => p.PCT012B137)
				.HasColumnName("PCT012B137")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B137")
				.IsOptional();

			Property(p => p.PCT012B138)
				.HasColumnName("PCT012B138")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B138")
				.IsOptional();

			Property(p => p.PCT012B139)
				.HasColumnName("PCT012B139")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B139")
				.IsOptional();

			Property(p => p.PCT012B140)
				.HasColumnName("PCT012B140")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B140")
				.IsOptional();

			Property(p => p.PCT012B141)
				.HasColumnName("PCT012B141")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B141")
				.IsOptional();

			Property(p => p.PCT012B142)
				.HasColumnName("PCT012B142")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B142")
				.IsOptional();

			Property(p => p.PCT012B143)
				.HasColumnName("PCT012B143")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B143")
				.IsOptional();

			Property(p => p.PCT012B144)
				.HasColumnName("PCT012B144")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B144")
				.IsOptional();

			Property(p => p.PCT012B145)
				.HasColumnName("PCT012B145")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B145")
				.IsOptional();

			Property(p => p.PCT012B146)
				.HasColumnName("PCT012B146")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B146")
				.IsOptional();

			Property(p => p.PCT012B147)
				.HasColumnName("PCT012B147")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B147")
				.IsOptional();

			Property(p => p.PCT012B148)
				.HasColumnName("PCT012B148")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B148")
				.IsOptional();

			Property(p => p.PCT012B149)
				.HasColumnName("PCT012B149")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B149")
				.IsOptional();

			Property(p => p.PCT012B150)
				.HasColumnName("PCT012B150")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B150")
				.IsOptional();

			Property(p => p.PCT012B151)
				.HasColumnName("PCT012B151")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B151")
				.IsOptional();

			Property(p => p.PCT012B152)
				.HasColumnName("PCT012B152")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B152")
				.IsOptional();

			Property(p => p.PCT012B153)
				.HasColumnName("PCT012B153")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B153")
				.IsOptional();

			Property(p => p.PCT012B154)
				.HasColumnName("PCT012B154")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B154")
				.IsOptional();

			Property(p => p.PCT012B155)
				.HasColumnName("PCT012B155")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B155")
				.IsOptional();

			Property(p => p.PCT012B156)
				.HasColumnName("PCT012B156")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B156")
				.IsOptional();

			Property(p => p.PCT012B157)
				.HasColumnName("PCT012B157")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B157")
				.IsOptional();

			Property(p => p.PCT012B158)
				.HasColumnName("PCT012B158")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B158")
				.IsOptional();

			Property(p => p.PCT012B159)
				.HasColumnName("PCT012B159")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B159")
				.IsOptional();

			Property(p => p.PCT012B160)
				.HasColumnName("PCT012B160")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B160")
				.IsOptional();

			Property(p => p.PCT012B161)
				.HasColumnName("PCT012B161")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B161")
				.IsOptional();

			Property(p => p.PCT012B162)
				.HasColumnName("PCT012B162")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B162")
				.IsOptional();

			Property(p => p.PCT012B163)
				.HasColumnName("PCT012B163")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B163")
				.IsOptional();

			Property(p => p.PCT012B164)
				.HasColumnName("PCT012B164")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B164")
				.IsOptional();

			Property(p => p.PCT012B165)
				.HasColumnName("PCT012B165")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B165")
				.IsOptional();

			Property(p => p.PCT012B166)
				.HasColumnName("PCT012B166")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B166")
				.IsOptional();

			Property(p => p.PCT012B167)
				.HasColumnName("PCT012B167")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B167")
				.IsOptional();

			Property(p => p.PCT012B168)
				.HasColumnName("PCT012B168")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B168")
				.IsOptional();

			Property(p => p.PCT012B169)
				.HasColumnName("PCT012B169")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B169")
				.IsOptional();

			Property(p => p.PCT012B170)
				.HasColumnName("PCT012B170")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B170")
				.IsOptional();

			Property(p => p.PCT012B171)
				.HasColumnName("PCT012B171")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B171")
				.IsOptional();

			Property(p => p.PCT012B172)
				.HasColumnName("PCT012B172")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B172")
				.IsOptional();

			Property(p => p.PCT012B173)
				.HasColumnName("PCT012B173")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B173")
				.IsOptional();

			Property(p => p.PCT012B174)
				.HasColumnName("PCT012B174")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B174")
				.IsOptional();

			Property(p => p.PCT012B175)
				.HasColumnName("PCT012B175")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B175")
				.IsOptional();

			Property(p => p.PCT012B176)
				.HasColumnName("PCT012B176")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B176")
				.IsOptional();

			Property(p => p.PCT012B177)
				.HasColumnName("PCT012B177")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B177")
				.IsOptional();

			Property(p => p.PCT012B178)
				.HasColumnName("PCT012B178")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B178")
				.IsOptional();

			Property(p => p.PCT012B179)
				.HasColumnName("PCT012B179")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B179")
				.IsOptional();

			Property(p => p.PCT012B180)
				.HasColumnName("PCT012B180")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B180")
				.IsOptional();

			Property(p => p.PCT012B181)
				.HasColumnName("PCT012B181")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B181")
				.IsOptional();

			Property(p => p.PCT012B182)
				.HasColumnName("PCT012B182")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B182")
				.IsOptional();

			Property(p => p.PCT012B183)
				.HasColumnName("PCT012B183")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B183")
				.IsOptional();

			Property(p => p.PCT012B184)
				.HasColumnName("PCT012B184")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B184")
				.IsOptional();

			Property(p => p.PCT012B185)
				.HasColumnName("PCT012B185")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B185")
				.IsOptional();

			Property(p => p.PCT012B186)
				.HasColumnName("PCT012B186")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B186")
				.IsOptional();

			Property(p => p.PCT012B187)
				.HasColumnName("PCT012B187")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B187")
				.IsOptional();

			Property(p => p.PCT012B188)
				.HasColumnName("PCT012B188")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B188")
				.IsOptional();

			Property(p => p.PCT012B189)
				.HasColumnName("PCT012B189")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B189")
				.IsOptional();

			Property(p => p.PCT012B190)
				.HasColumnName("PCT012B190")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B190")
				.IsOptional();

			Property(p => p.PCT012B191)
				.HasColumnName("PCT012B191")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B191")
				.IsOptional();

			Property(p => p.PCT012B192)
				.HasColumnName("PCT012B192")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B192")
				.IsOptional();

			Property(p => p.PCT012B193)
				.HasColumnName("PCT012B193")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B193")
				.IsOptional();

			Property(p => p.PCT012B194)
				.HasColumnName("PCT012B194")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B194")
				.IsOptional();

			Property(p => p.PCT012B195)
				.HasColumnName("PCT012B195")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B195")
				.IsOptional();

			Property(p => p.PCT012B196)
				.HasColumnName("PCT012B196")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B196")
				.IsOptional();

			Property(p => p.PCT012B197)
				.HasColumnName("PCT012B197")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B197")
				.IsOptional();

			Property(p => p.PCT012B198)
				.HasColumnName("PCT012B198")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B198")
				.IsOptional();

			Property(p => p.PCT012B199)
				.HasColumnName("PCT012B199")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B199")
				.IsOptional();

			Property(p => p.PCT012B200)
				.HasColumnName("PCT012B200")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B200")
				.IsOptional();

			Property(p => p.PCT012B201)
				.HasColumnName("PCT012B201")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B201")
				.IsOptional();

			Property(p => p.PCT012B202)
				.HasColumnName("PCT012B202")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B202")
				.IsOptional();

			Property(p => p.PCT012B203)
				.HasColumnName("PCT012B203")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B203")
				.IsOptional();

			Property(p => p.PCT012B204)
				.HasColumnName("PCT012B204")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B204")
				.IsOptional();

			Property(p => p.PCT012B205)
				.HasColumnName("PCT012B205")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B205")
				.IsOptional();

			Property(p => p.PCT012B206)
				.HasColumnName("PCT012B206")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B206")
				.IsOptional();

			Property(p => p.PCT012B207)
				.HasColumnName("PCT012B207")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B207")
				.IsOptional();

			Property(p => p.PCT012B208)
				.HasColumnName("PCT012B208")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B208")
				.IsOptional();

			Property(p => p.PCT012B209)
				.HasColumnName("PCT012B209")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT012B209")
				.IsOptional();
		}
	}
}
