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

	public class SummaryOne_SF1_00045Map : EntityTypeConfiguration<SummaryOne_SF1_00045>
	{
		public SummaryOne_SF1_00045Map()
		{
			ToTable("SF1_00045", "SummaryOne");

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

			Property(p => p.H011G0001)
				.HasColumnName("H011G0001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H011G0001")
				.IsOptional();

			Property(p => p.H011G0002)
				.HasColumnName("H011G0002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H011G0002")
				.IsOptional();

			Property(p => p.H011G0003)
				.HasColumnName("H011G0003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H011G0003")
				.IsOptional();

			Property(p => p.H011G0004)
				.HasColumnName("H011G0004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H011G0004")
				.IsOptional();

			Property(p => p.H011H0001)
				.HasColumnName("H011H0001")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H011H0001")
				.IsOptional();

			Property(p => p.H011H0002)
				.HasColumnName("H011H0002")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H011H0002")
				.IsOptional();

			Property(p => p.H011H0003)
				.HasColumnName("H011H0003")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H011H0003")
				.IsOptional();

			Property(p => p.H011H0004)
				.HasColumnName("H011H0004")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H011H0004")
				.IsOptional();

			Property(p => p.H011I0001)
				.HasColumnName("H011I0001")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H011I0001")
				.IsOptional();

			Property(p => p.H011I0002)
				.HasColumnName("H011I0002")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H011I0002")
				.IsOptional();

			Property(p => p.H011I0003)
				.HasColumnName("H011I0003")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H011I0003")
				.IsOptional();

			Property(p => p.H011I0004)
				.HasColumnName("H011I0004")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H011I0004")
				.IsOptional();

			Property(p => p.H012A0001)
				.HasColumnName("H012A0001")
				.HasColumnOrder(17)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012A0001")
				.IsOptional();

			Property(p => p.H012A0002)
				.HasColumnName("H012A0002")
				.HasColumnOrder(18)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012A0002")
				.IsOptional();

			Property(p => p.H012A0003)
				.HasColumnName("H012A0003")
				.HasColumnOrder(19)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012A0003")
				.IsOptional();

			Property(p => p.H012B0001)
				.HasColumnName("H012B0001")
				.HasColumnOrder(20)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012B0001")
				.IsOptional();

			Property(p => p.H012B0002)
				.HasColumnName("H012B0002")
				.HasColumnOrder(21)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012B0002")
				.IsOptional();

			Property(p => p.H012B0003)
				.HasColumnName("H012B0003")
				.HasColumnOrder(22)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012B0003")
				.IsOptional();

			Property(p => p.H012C0001)
				.HasColumnName("H012C0001")
				.HasColumnOrder(23)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012C0001")
				.IsOptional();

			Property(p => p.H012C0002)
				.HasColumnName("H012C0002")
				.HasColumnOrder(24)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012C0002")
				.IsOptional();

			Property(p => p.H012C0003)
				.HasColumnName("H012C0003")
				.HasColumnOrder(25)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012C0003")
				.IsOptional();

			Property(p => p.H012D0001)
				.HasColumnName("H012D0001")
				.HasColumnOrder(26)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012D0001")
				.IsOptional();

			Property(p => p.H012D0002)
				.HasColumnName("H012D0002")
				.HasColumnOrder(27)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012D0002")
				.IsOptional();

			Property(p => p.H012D0003)
				.HasColumnName("H012D0003")
				.HasColumnOrder(28)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012D0003")
				.IsOptional();

			Property(p => p.H012E0001)
				.HasColumnName("H012E0001")
				.HasColumnOrder(29)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012E0001")
				.IsOptional();

			Property(p => p.H012E0002)
				.HasColumnName("H012E0002")
				.HasColumnOrder(30)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012E0002")
				.IsOptional();

			Property(p => p.H012E0003)
				.HasColumnName("H012E0003")
				.HasColumnOrder(31)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012E0003")
				.IsOptional();

			Property(p => p.H012F0001)
				.HasColumnName("H012F0001")
				.HasColumnOrder(32)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012F0001")
				.IsOptional();

			Property(p => p.H012F0002)
				.HasColumnName("H012F0002")
				.HasColumnOrder(33)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012F0002")
				.IsOptional();

			Property(p => p.H012F0003)
				.HasColumnName("H012F0003")
				.HasColumnOrder(34)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012F0003")
				.IsOptional();

			Property(p => p.H012G0001)
				.HasColumnName("H012G0001")
				.HasColumnOrder(35)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012G0001")
				.IsOptional();

			Property(p => p.H012G0002)
				.HasColumnName("H012G0002")
				.HasColumnOrder(36)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012G0002")
				.IsOptional();

			Property(p => p.H012G0003)
				.HasColumnName("H012G0003")
				.HasColumnOrder(37)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012G0003")
				.IsOptional();

			Property(p => p.H012H0001)
				.HasColumnName("H012H0001")
				.HasColumnOrder(38)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012H0001")
				.IsOptional();

			Property(p => p.H012H0002)
				.HasColumnName("H012H0002")
				.HasColumnOrder(39)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012H0002")
				.IsOptional();

			Property(p => p.H012H0003)
				.HasColumnName("H012H0003")
				.HasColumnOrder(40)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012H0003")
				.IsOptional();

			Property(p => p.H012I0001)
				.HasColumnName("H012I0001")
				.HasColumnOrder(41)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012I0001")
				.IsOptional();

			Property(p => p.H012I0002)
				.HasColumnName("H012I0002")
				.HasColumnOrder(42)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012I0002")
				.IsOptional();

			Property(p => p.H012I0003)
				.HasColumnName("H012I0003")
				.HasColumnOrder(43)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H012I0003")
				.IsOptional();

			Property(p => p.H016A0001)
				.HasColumnName("H016A0001")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016A0001")
				.IsOptional();

			Property(p => p.H016A0002)
				.HasColumnName("H016A0002")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016A0002")
				.IsOptional();

			Property(p => p.H016A0003)
				.HasColumnName("H016A0003")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016A0003")
				.IsOptional();

			Property(p => p.H016A0004)
				.HasColumnName("H016A0004")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016A0004")
				.IsOptional();

			Property(p => p.H016A0005)
				.HasColumnName("H016A0005")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016A0005")
				.IsOptional();

			Property(p => p.H016A0006)
				.HasColumnName("H016A0006")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016A0006")
				.IsOptional();

			Property(p => p.H016A0007)
				.HasColumnName("H016A0007")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016A0007")
				.IsOptional();

			Property(p => p.H016A0008)
				.HasColumnName("H016A0008")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016A0008")
				.IsOptional();

			Property(p => p.H016A0009)
				.HasColumnName("H016A0009")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016A0009")
				.IsOptional();

			Property(p => p.H016A0010)
				.HasColumnName("H016A0010")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016A0010")
				.IsOptional();

			Property(p => p.H016A0011)
				.HasColumnName("H016A0011")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016A0011")
				.IsOptional();

			Property(p => p.H016A0012)
				.HasColumnName("H016A0012")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016A0012")
				.IsOptional();

			Property(p => p.H016A0013)
				.HasColumnName("H016A0013")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016A0013")
				.IsOptional();

			Property(p => p.H016A0014)
				.HasColumnName("H016A0014")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016A0014")
				.IsOptional();

			Property(p => p.H016A0015)
				.HasColumnName("H016A0015")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016A0015")
				.IsOptional();

			Property(p => p.H016A0016)
				.HasColumnName("H016A0016")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016A0016")
				.IsOptional();

			Property(p => p.H016A0017)
				.HasColumnName("H016A0017")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016A0017")
				.IsOptional();

			Property(p => p.H016B0001)
				.HasColumnName("H016B0001")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016B0001")
				.IsOptional();

			Property(p => p.H016B0002)
				.HasColumnName("H016B0002")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016B0002")
				.IsOptional();

			Property(p => p.H016B0003)
				.HasColumnName("H016B0003")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016B0003")
				.IsOptional();

			Property(p => p.H016B0004)
				.HasColumnName("H016B0004")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016B0004")
				.IsOptional();

			Property(p => p.H016B0005)
				.HasColumnName("H016B0005")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016B0005")
				.IsOptional();

			Property(p => p.H016B0006)
				.HasColumnName("H016B0006")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016B0006")
				.IsOptional();

			Property(p => p.H016B0007)
				.HasColumnName("H016B0007")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016B0007")
				.IsOptional();

			Property(p => p.H016B0008)
				.HasColumnName("H016B0008")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016B0008")
				.IsOptional();

			Property(p => p.H016B0009)
				.HasColumnName("H016B0009")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016B0009")
				.IsOptional();

			Property(p => p.H016B0010)
				.HasColumnName("H016B0010")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016B0010")
				.IsOptional();

			Property(p => p.H016B0011)
				.HasColumnName("H016B0011")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016B0011")
				.IsOptional();

			Property(p => p.H016B0012)
				.HasColumnName("H016B0012")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016B0012")
				.IsOptional();

			Property(p => p.H016B0013)
				.HasColumnName("H016B0013")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016B0013")
				.IsOptional();

			Property(p => p.H016B0014)
				.HasColumnName("H016B0014")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016B0014")
				.IsOptional();

			Property(p => p.H016B0015)
				.HasColumnName("H016B0015")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016B0015")
				.IsOptional();

			Property(p => p.H016B0016)
				.HasColumnName("H016B0016")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016B0016")
				.IsOptional();

			Property(p => p.H016B0017)
				.HasColumnName("H016B0017")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016B0017")
				.IsOptional();

			Property(p => p.H016C0001)
				.HasColumnName("H016C0001")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016C0001")
				.IsOptional();

			Property(p => p.H016C0002)
				.HasColumnName("H016C0002")
				.HasColumnOrder(79)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016C0002")
				.IsOptional();

			Property(p => p.H016C0003)
				.HasColumnName("H016C0003")
				.HasColumnOrder(80)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016C0003")
				.IsOptional();

			Property(p => p.H016C0004)
				.HasColumnName("H016C0004")
				.HasColumnOrder(81)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016C0004")
				.IsOptional();

			Property(p => p.H016C0005)
				.HasColumnName("H016C0005")
				.HasColumnOrder(82)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016C0005")
				.IsOptional();

			Property(p => p.H016C0006)
				.HasColumnName("H016C0006")
				.HasColumnOrder(83)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016C0006")
				.IsOptional();

			Property(p => p.H016C0007)
				.HasColumnName("H016C0007")
				.HasColumnOrder(84)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016C0007")
				.IsOptional();

			Property(p => p.H016C0008)
				.HasColumnName("H016C0008")
				.HasColumnOrder(85)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016C0008")
				.IsOptional();

			Property(p => p.H016C0009)
				.HasColumnName("H016C0009")
				.HasColumnOrder(86)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016C0009")
				.IsOptional();

			Property(p => p.H016C0010)
				.HasColumnName("H016C0010")
				.HasColumnOrder(87)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016C0010")
				.IsOptional();

			Property(p => p.H016C0011)
				.HasColumnName("H016C0011")
				.HasColumnOrder(88)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016C0011")
				.IsOptional();

			Property(p => p.H016C0012)
				.HasColumnName("H016C0012")
				.HasColumnOrder(89)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016C0012")
				.IsOptional();

			Property(p => p.H016C0013)
				.HasColumnName("H016C0013")
				.HasColumnOrder(90)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016C0013")
				.IsOptional();

			Property(p => p.H016C0014)
				.HasColumnName("H016C0014")
				.HasColumnOrder(91)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016C0014")
				.IsOptional();

			Property(p => p.H016C0015)
				.HasColumnName("H016C0015")
				.HasColumnOrder(92)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016C0015")
				.IsOptional();

			Property(p => p.H016C0016)
				.HasColumnName("H016C0016")
				.HasColumnOrder(93)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016C0016")
				.IsOptional();

			Property(p => p.H016C0017)
				.HasColumnName("H016C0017")
				.HasColumnOrder(94)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016C0017")
				.IsOptional();

			Property(p => p.H016D0001)
				.HasColumnName("H016D0001")
				.HasColumnOrder(95)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016D0001")
				.IsOptional();

			Property(p => p.H016D0002)
				.HasColumnName("H016D0002")
				.HasColumnOrder(96)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016D0002")
				.IsOptional();

			Property(p => p.H016D0003)
				.HasColumnName("H016D0003")
				.HasColumnOrder(97)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016D0003")
				.IsOptional();

			Property(p => p.H016D0004)
				.HasColumnName("H016D0004")
				.HasColumnOrder(98)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016D0004")
				.IsOptional();

			Property(p => p.H016D0005)
				.HasColumnName("H016D0005")
				.HasColumnOrder(99)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016D0005")
				.IsOptional();

			Property(p => p.H016D0006)
				.HasColumnName("H016D0006")
				.HasColumnOrder(100)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016D0006")
				.IsOptional();

			Property(p => p.H016D0007)
				.HasColumnName("H016D0007")
				.HasColumnOrder(101)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016D0007")
				.IsOptional();

			Property(p => p.H016D0008)
				.HasColumnName("H016D0008")
				.HasColumnOrder(102)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016D0008")
				.IsOptional();

			Property(p => p.H016D0009)
				.HasColumnName("H016D0009")
				.HasColumnOrder(103)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016D0009")
				.IsOptional();

			Property(p => p.H016D0010)
				.HasColumnName("H016D0010")
				.HasColumnOrder(104)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016D0010")
				.IsOptional();

			Property(p => p.H016D0011)
				.HasColumnName("H016D0011")
				.HasColumnOrder(105)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016D0011")
				.IsOptional();

			Property(p => p.H016D0012)
				.HasColumnName("H016D0012")
				.HasColumnOrder(106)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016D0012")
				.IsOptional();

			Property(p => p.H016D0013)
				.HasColumnName("H016D0013")
				.HasColumnOrder(107)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016D0013")
				.IsOptional();

			Property(p => p.H016D0014)
				.HasColumnName("H016D0014")
				.HasColumnOrder(108)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016D0014")
				.IsOptional();

			Property(p => p.H016D0015)
				.HasColumnName("H016D0015")
				.HasColumnOrder(109)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016D0015")
				.IsOptional();

			Property(p => p.H016D0016)
				.HasColumnName("H016D0016")
				.HasColumnOrder(110)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016D0016")
				.IsOptional();

			Property(p => p.H016D0017)
				.HasColumnName("H016D0017")
				.HasColumnOrder(111)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016D0017")
				.IsOptional();

			Property(p => p.H016E0001)
				.HasColumnName("H016E0001")
				.HasColumnOrder(112)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016E0001")
				.IsOptional();

			Property(p => p.H016E0002)
				.HasColumnName("H016E0002")
				.HasColumnOrder(113)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016E0002")
				.IsOptional();

			Property(p => p.H016E0003)
				.HasColumnName("H016E0003")
				.HasColumnOrder(114)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016E0003")
				.IsOptional();

			Property(p => p.H016E0004)
				.HasColumnName("H016E0004")
				.HasColumnOrder(115)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016E0004")
				.IsOptional();

			Property(p => p.H016E0005)
				.HasColumnName("H016E0005")
				.HasColumnOrder(116)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016E0005")
				.IsOptional();

			Property(p => p.H016E0006)
				.HasColumnName("H016E0006")
				.HasColumnOrder(117)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016E0006")
				.IsOptional();

			Property(p => p.H016E0007)
				.HasColumnName("H016E0007")
				.HasColumnOrder(118)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016E0007")
				.IsOptional();

			Property(p => p.H016E0008)
				.HasColumnName("H016E0008")
				.HasColumnOrder(119)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016E0008")
				.IsOptional();

			Property(p => p.H016E0009)
				.HasColumnName("H016E0009")
				.HasColumnOrder(120)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016E0009")
				.IsOptional();

			Property(p => p.H016E0010)
				.HasColumnName("H016E0010")
				.HasColumnOrder(121)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016E0010")
				.IsOptional();

			Property(p => p.H016E0011)
				.HasColumnName("H016E0011")
				.HasColumnOrder(122)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016E0011")
				.IsOptional();

			Property(p => p.H016E0012)
				.HasColumnName("H016E0012")
				.HasColumnOrder(123)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016E0012")
				.IsOptional();

			Property(p => p.H016E0013)
				.HasColumnName("H016E0013")
				.HasColumnOrder(124)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016E0013")
				.IsOptional();

			Property(p => p.H016E0014)
				.HasColumnName("H016E0014")
				.HasColumnOrder(125)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016E0014")
				.IsOptional();

			Property(p => p.H016E0015)
				.HasColumnName("H016E0015")
				.HasColumnOrder(126)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016E0015")
				.IsOptional();

			Property(p => p.H016E0016)
				.HasColumnName("H016E0016")
				.HasColumnOrder(127)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016E0016")
				.IsOptional();

			Property(p => p.H016E0017)
				.HasColumnName("H016E0017")
				.HasColumnOrder(128)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016E0017")
				.IsOptional();

			Property(p => p.H016F0001)
				.HasColumnName("H016F0001")
				.HasColumnOrder(129)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016F0001")
				.IsOptional();

			Property(p => p.H016F0002)
				.HasColumnName("H016F0002")
				.HasColumnOrder(130)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016F0002")
				.IsOptional();

			Property(p => p.H016F0003)
				.HasColumnName("H016F0003")
				.HasColumnOrder(131)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016F0003")
				.IsOptional();

			Property(p => p.H016F0004)
				.HasColumnName("H016F0004")
				.HasColumnOrder(132)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016F0004")
				.IsOptional();

			Property(p => p.H016F0005)
				.HasColumnName("H016F0005")
				.HasColumnOrder(133)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016F0005")
				.IsOptional();

			Property(p => p.H016F0006)
				.HasColumnName("H016F0006")
				.HasColumnOrder(134)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016F0006")
				.IsOptional();

			Property(p => p.H016F0007)
				.HasColumnName("H016F0007")
				.HasColumnOrder(135)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016F0007")
				.IsOptional();

			Property(p => p.H016F0008)
				.HasColumnName("H016F0008")
				.HasColumnOrder(136)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016F0008")
				.IsOptional();

			Property(p => p.H016F0009)
				.HasColumnName("H016F0009")
				.HasColumnOrder(137)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016F0009")
				.IsOptional();

			Property(p => p.H016F0010)
				.HasColumnName("H016F0010")
				.HasColumnOrder(138)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016F0010")
				.IsOptional();

			Property(p => p.H016F0011)
				.HasColumnName("H016F0011")
				.HasColumnOrder(139)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016F0011")
				.IsOptional();

			Property(p => p.H016F0012)
				.HasColumnName("H016F0012")
				.HasColumnOrder(140)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016F0012")
				.IsOptional();

			Property(p => p.H016F0013)
				.HasColumnName("H016F0013")
				.HasColumnOrder(141)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016F0013")
				.IsOptional();

			Property(p => p.H016F0014)
				.HasColumnName("H016F0014")
				.HasColumnOrder(142)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016F0014")
				.IsOptional();

			Property(p => p.H016F0015)
				.HasColumnName("H016F0015")
				.HasColumnOrder(143)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016F0015")
				.IsOptional();

			Property(p => p.H016F0016)
				.HasColumnName("H016F0016")
				.HasColumnOrder(144)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016F0016")
				.IsOptional();

			Property(p => p.H016F0017)
				.HasColumnName("H016F0017")
				.HasColumnOrder(145)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016F0017")
				.IsOptional();

			Property(p => p.H016G0001)
				.HasColumnName("H016G0001")
				.HasColumnOrder(146)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016G0001")
				.IsOptional();

			Property(p => p.H016G0002)
				.HasColumnName("H016G0002")
				.HasColumnOrder(147)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016G0002")
				.IsOptional();

			Property(p => p.H016G0003)
				.HasColumnName("H016G0003")
				.HasColumnOrder(148)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016G0003")
				.IsOptional();

			Property(p => p.H016G0004)
				.HasColumnName("H016G0004")
				.HasColumnOrder(149)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016G0004")
				.IsOptional();

			Property(p => p.H016G0005)
				.HasColumnName("H016G0005")
				.HasColumnOrder(150)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016G0005")
				.IsOptional();

			Property(p => p.H016G0006)
				.HasColumnName("H016G0006")
				.HasColumnOrder(151)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016G0006")
				.IsOptional();

			Property(p => p.H016G0007)
				.HasColumnName("H016G0007")
				.HasColumnOrder(152)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016G0007")
				.IsOptional();

			Property(p => p.H016G0008)
				.HasColumnName("H016G0008")
				.HasColumnOrder(153)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016G0008")
				.IsOptional();

			Property(p => p.H016G0009)
				.HasColumnName("H016G0009")
				.HasColumnOrder(154)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016G0009")
				.IsOptional();

			Property(p => p.H016G0010)
				.HasColumnName("H016G0010")
				.HasColumnOrder(155)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016G0010")
				.IsOptional();

			Property(p => p.H016G0011)
				.HasColumnName("H016G0011")
				.HasColumnOrder(156)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016G0011")
				.IsOptional();

			Property(p => p.H016G0012)
				.HasColumnName("H016G0012")
				.HasColumnOrder(157)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016G0012")
				.IsOptional();

			Property(p => p.H016G0013)
				.HasColumnName("H016G0013")
				.HasColumnOrder(158)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016G0013")
				.IsOptional();

			Property(p => p.H016G0014)
				.HasColumnName("H016G0014")
				.HasColumnOrder(159)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016G0014")
				.IsOptional();

			Property(p => p.H016G0015)
				.HasColumnName("H016G0015")
				.HasColumnOrder(160)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016G0015")
				.IsOptional();

			Property(p => p.H016G0016)
				.HasColumnName("H016G0016")
				.HasColumnOrder(161)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016G0016")
				.IsOptional();

			Property(p => p.H016G0017)
				.HasColumnName("H016G0017")
				.HasColumnOrder(162)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016G0017")
				.IsOptional();

			Property(p => p.H016H0001)
				.HasColumnName("H016H0001")
				.HasColumnOrder(163)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016H0001")
				.IsOptional();

			Property(p => p.H016H0002)
				.HasColumnName("H016H0002")
				.HasColumnOrder(164)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016H0002")
				.IsOptional();

			Property(p => p.H016H0003)
				.HasColumnName("H016H0003")
				.HasColumnOrder(165)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016H0003")
				.IsOptional();

			Property(p => p.H016H0004)
				.HasColumnName("H016H0004")
				.HasColumnOrder(166)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016H0004")
				.IsOptional();

			Property(p => p.H016H0005)
				.HasColumnName("H016H0005")
				.HasColumnOrder(167)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016H0005")
				.IsOptional();

			Property(p => p.H016H0006)
				.HasColumnName("H016H0006")
				.HasColumnOrder(168)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016H0006")
				.IsOptional();

			Property(p => p.H016H0007)
				.HasColumnName("H016H0007")
				.HasColumnOrder(169)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016H0007")
				.IsOptional();

			Property(p => p.H016H0008)
				.HasColumnName("H016H0008")
				.HasColumnOrder(170)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016H0008")
				.IsOptional();

			Property(p => p.H016H0009)
				.HasColumnName("H016H0009")
				.HasColumnOrder(171)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016H0009")
				.IsOptional();

			Property(p => p.H016H0010)
				.HasColumnName("H016H0010")
				.HasColumnOrder(172)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016H0010")
				.IsOptional();

			Property(p => p.H016H0011)
				.HasColumnName("H016H0011")
				.HasColumnOrder(173)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016H0011")
				.IsOptional();

			Property(p => p.H016H0012)
				.HasColumnName("H016H0012")
				.HasColumnOrder(174)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016H0012")
				.IsOptional();

			Property(p => p.H016H0013)
				.HasColumnName("H016H0013")
				.HasColumnOrder(175)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016H0013")
				.IsOptional();

			Property(p => p.H016H0014)
				.HasColumnName("H016H0014")
				.HasColumnOrder(176)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016H0014")
				.IsOptional();

			Property(p => p.H016H0015)
				.HasColumnName("H016H0015")
				.HasColumnOrder(177)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016H0015")
				.IsOptional();

			Property(p => p.H016H0016)
				.HasColumnName("H016H0016")
				.HasColumnOrder(178)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016H0016")
				.IsOptional();

			Property(p => p.H016H0017)
				.HasColumnName("H016H0017")
				.HasColumnOrder(179)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016H0017")
				.IsOptional();

			Property(p => p.H016I0001)
				.HasColumnName("H016I0001")
				.HasColumnOrder(180)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016I0001")
				.IsOptional();

			Property(p => p.H016I0002)
				.HasColumnName("H016I0002")
				.HasColumnOrder(181)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016I0002")
				.IsOptional();

			Property(p => p.H016I0003)
				.HasColumnName("H016I0003")
				.HasColumnOrder(182)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016I0003")
				.IsOptional();

			Property(p => p.H016I0004)
				.HasColumnName("H016I0004")
				.HasColumnOrder(183)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016I0004")
				.IsOptional();

			Property(p => p.H016I0005)
				.HasColumnName("H016I0005")
				.HasColumnOrder(184)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016I0005")
				.IsOptional();

			Property(p => p.H016I0006)
				.HasColumnName("H016I0006")
				.HasColumnOrder(185)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016I0006")
				.IsOptional();

			Property(p => p.H016I0007)
				.HasColumnName("H016I0007")
				.HasColumnOrder(186)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016I0007")
				.IsOptional();

			Property(p => p.H016I0008)
				.HasColumnName("H016I0008")
				.HasColumnOrder(187)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016I0008")
				.IsOptional();

			Property(p => p.H016I0009)
				.HasColumnName("H016I0009")
				.HasColumnOrder(188)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016I0009")
				.IsOptional();

			Property(p => p.H016I0010)
				.HasColumnName("H016I0010")
				.HasColumnOrder(189)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016I0010")
				.IsOptional();

			Property(p => p.H016I0011)
				.HasColumnName("H016I0011")
				.HasColumnOrder(190)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016I0011")
				.IsOptional();

			Property(p => p.H016I0012)
				.HasColumnName("H016I0012")
				.HasColumnOrder(191)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016I0012")
				.IsOptional();

			Property(p => p.H016I0013)
				.HasColumnName("H016I0013")
				.HasColumnOrder(192)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016I0013")
				.IsOptional();

			Property(p => p.H016I0014)
				.HasColumnName("H016I0014")
				.HasColumnOrder(193)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016I0014")
				.IsOptional();

			Property(p => p.H016I0015)
				.HasColumnName("H016I0015")
				.HasColumnOrder(194)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016I0015")
				.IsOptional();

			Property(p => p.H016I0016)
				.HasColumnName("H016I0016")
				.HasColumnOrder(195)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016I0016")
				.IsOptional();

			Property(p => p.H016I0017)
				.HasColumnName("H016I0017")
				.HasColumnOrder(196)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H016I0017")
				.IsOptional();

			Property(p => p.H017A0001)
				.HasColumnName("H017A0001")
				.HasColumnOrder(197)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017A0001")
				.IsOptional();

			Property(p => p.H017A0002)
				.HasColumnName("H017A0002")
				.HasColumnOrder(198)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017A0002")
				.IsOptional();

			Property(p => p.H017A0003)
				.HasColumnName("H017A0003")
				.HasColumnOrder(199)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017A0003")
				.IsOptional();

			Property(p => p.H017A0004)
				.HasColumnName("H017A0004")
				.HasColumnOrder(200)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017A0004")
				.IsOptional();

			Property(p => p.H017A0005)
				.HasColumnName("H017A0005")
				.HasColumnOrder(201)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017A0005")
				.IsOptional();

			Property(p => p.H017A0006)
				.HasColumnName("H017A0006")
				.HasColumnOrder(202)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017A0006")
				.IsOptional();

			Property(p => p.H017A0007)
				.HasColumnName("H017A0007")
				.HasColumnOrder(203)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017A0007")
				.IsOptional();

			Property(p => p.H017A0008)
				.HasColumnName("H017A0008")
				.HasColumnOrder(204)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017A0008")
				.IsOptional();

			Property(p => p.H017A0009)
				.HasColumnName("H017A0009")
				.HasColumnOrder(205)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017A0009")
				.IsOptional();

			Property(p => p.H017A0010)
				.HasColumnName("H017A0010")
				.HasColumnOrder(206)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017A0010")
				.IsOptional();

			Property(p => p.H017A0011)
				.HasColumnName("H017A0011")
				.HasColumnOrder(207)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017A0011")
				.IsOptional();

			Property(p => p.H017A0012)
				.HasColumnName("H017A0012")
				.HasColumnOrder(208)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017A0012")
				.IsOptional();

			Property(p => p.H017A0013)
				.HasColumnName("H017A0013")
				.HasColumnOrder(209)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017A0013")
				.IsOptional();

			Property(p => p.H017A0014)
				.HasColumnName("H017A0014")
				.HasColumnOrder(210)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017A0014")
				.IsOptional();

			Property(p => p.H017A0015)
				.HasColumnName("H017A0015")
				.HasColumnOrder(211)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017A0015")
				.IsOptional();

			Property(p => p.H017A0016)
				.HasColumnName("H017A0016")
				.HasColumnOrder(212)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017A0016")
				.IsOptional();

			Property(p => p.H017A0017)
				.HasColumnName("H017A0017")
				.HasColumnOrder(213)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017A0017")
				.IsOptional();

			Property(p => p.H017A0018)
				.HasColumnName("H017A0018")
				.HasColumnOrder(214)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017A0018")
				.IsOptional();

			Property(p => p.H017A0019)
				.HasColumnName("H017A0019")
				.HasColumnOrder(215)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017A0019")
				.IsOptional();

			Property(p => p.H017A0020)
				.HasColumnName("H017A0020")
				.HasColumnOrder(216)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017A0020")
				.IsOptional();

			Property(p => p.H017A0021)
				.HasColumnName("H017A0021")
				.HasColumnOrder(217)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017A0021")
				.IsOptional();

			Property(p => p.H017B0001)
				.HasColumnName("H017B0001")
				.HasColumnOrder(218)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017B0001")
				.IsOptional();

			Property(p => p.H017B0002)
				.HasColumnName("H017B0002")
				.HasColumnOrder(219)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017B0002")
				.IsOptional();

			Property(p => p.H017B0003)
				.HasColumnName("H017B0003")
				.HasColumnOrder(220)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017B0003")
				.IsOptional();

			Property(p => p.H017B0004)
				.HasColumnName("H017B0004")
				.HasColumnOrder(221)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017B0004")
				.IsOptional();

			Property(p => p.H017B0005)
				.HasColumnName("H017B0005")
				.HasColumnOrder(222)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017B0005")
				.IsOptional();

			Property(p => p.H017B0006)
				.HasColumnName("H017B0006")
				.HasColumnOrder(223)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017B0006")
				.IsOptional();

			Property(p => p.H017B0007)
				.HasColumnName("H017B0007")
				.HasColumnOrder(224)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017B0007")
				.IsOptional();

			Property(p => p.H017B0008)
				.HasColumnName("H017B0008")
				.HasColumnOrder(225)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017B0008")
				.IsOptional();

			Property(p => p.H017B0009)
				.HasColumnName("H017B0009")
				.HasColumnOrder(226)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017B0009")
				.IsOptional();

			Property(p => p.H017B0010)
				.HasColumnName("H017B0010")
				.HasColumnOrder(227)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017B0010")
				.IsOptional();

			Property(p => p.H017B0011)
				.HasColumnName("H017B0011")
				.HasColumnOrder(228)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017B0011")
				.IsOptional();

			Property(p => p.H017B0012)
				.HasColumnName("H017B0012")
				.HasColumnOrder(229)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017B0012")
				.IsOptional();

			Property(p => p.H017B0013)
				.HasColumnName("H017B0013")
				.HasColumnOrder(230)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017B0013")
				.IsOptional();

			Property(p => p.H017B0014)
				.HasColumnName("H017B0014")
				.HasColumnOrder(231)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017B0014")
				.IsOptional();

			Property(p => p.H017B0015)
				.HasColumnName("H017B0015")
				.HasColumnOrder(232)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017B0015")
				.IsOptional();

			Property(p => p.H017B0016)
				.HasColumnName("H017B0016")
				.HasColumnOrder(233)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017B0016")
				.IsOptional();

			Property(p => p.H017B0017)
				.HasColumnName("H017B0017")
				.HasColumnOrder(234)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017B0017")
				.IsOptional();

			Property(p => p.H017B0018)
				.HasColumnName("H017B0018")
				.HasColumnOrder(235)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017B0018")
				.IsOptional();

			Property(p => p.H017B0019)
				.HasColumnName("H017B0019")
				.HasColumnOrder(236)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017B0019")
				.IsOptional();

			Property(p => p.H017B0020)
				.HasColumnName("H017B0020")
				.HasColumnOrder(237)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017B0020")
				.IsOptional();

			Property(p => p.H017B0021)
				.HasColumnName("H017B0021")
				.HasColumnOrder(238)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017B0021")
				.IsOptional();

			Property(p => p.H017C0001)
				.HasColumnName("H017C0001")
				.HasColumnOrder(239)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017C0001")
				.IsOptional();

			Property(p => p.H017C0002)
				.HasColumnName("H017C0002")
				.HasColumnOrder(240)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017C0002")
				.IsOptional();

			Property(p => p.H017C0003)
				.HasColumnName("H017C0003")
				.HasColumnOrder(241)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017C0003")
				.IsOptional();

			Property(p => p.H017C0004)
				.HasColumnName("H017C0004")
				.HasColumnOrder(242)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017C0004")
				.IsOptional();

			Property(p => p.H017C0005)
				.HasColumnName("H017C0005")
				.HasColumnOrder(243)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017C0005")
				.IsOptional();

			Property(p => p.H017C0006)
				.HasColumnName("H017C0006")
				.HasColumnOrder(244)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017C0006")
				.IsOptional();

			Property(p => p.H017C0007)
				.HasColumnName("H017C0007")
				.HasColumnOrder(245)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017C0007")
				.IsOptional();

			Property(p => p.H017C0008)
				.HasColumnName("H017C0008")
				.HasColumnOrder(246)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017C0008")
				.IsOptional();

			Property(p => p.H017C0009)
				.HasColumnName("H017C0009")
				.HasColumnOrder(247)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017C0009")
				.IsOptional();

			Property(p => p.H017C0010)
				.HasColumnName("H017C0010")
				.HasColumnOrder(248)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017C0010")
				.IsOptional();

			Property(p => p.H017C0011)
				.HasColumnName("H017C0011")
				.HasColumnOrder(249)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017C0011")
				.IsOptional();

			Property(p => p.H017C0012)
				.HasColumnName("H017C0012")
				.HasColumnOrder(250)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017C0012")
				.IsOptional();

			Property(p => p.H017C0013)
				.HasColumnName("H017C0013")
				.HasColumnOrder(251)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017C0013")
				.IsOptional();

			Property(p => p.H017C0014)
				.HasColumnName("H017C0014")
				.HasColumnOrder(252)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017C0014")
				.IsOptional();

			Property(p => p.H017C0015)
				.HasColumnName("H017C0015")
				.HasColumnOrder(253)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017C0015")
				.IsOptional();

			Property(p => p.H017C0016)
				.HasColumnName("H017C0016")
				.HasColumnOrder(254)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017C0016")
				.IsOptional();

			Property(p => p.H017C0017)
				.HasColumnName("H017C0017")
				.HasColumnOrder(255)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017C0017")
				.IsOptional();

			Property(p => p.H017C0018)
				.HasColumnName("H017C0018")
				.HasColumnOrder(256)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017C0018")
				.IsOptional();

			Property(p => p.H017C0019)
				.HasColumnName("H017C0019")
				.HasColumnOrder(257)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017C0019")
				.IsOptional();

			Property(p => p.H017C0020)
				.HasColumnName("H017C0020")
				.HasColumnOrder(258)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017C0020")
				.IsOptional();

			Property(p => p.H017C0021)
				.HasColumnName("H017C0021")
				.HasColumnOrder(259)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("H017C0021")
				.IsOptional();
		}
	}
}
