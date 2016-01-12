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

	public class SummaryOne_SF1_00047Map : EntityTypeConfiguration<SummaryOne_SF1_00047>
	{
		public SummaryOne_SF1_00047Map()
		{
			ToTable("SF1_00047", "SummaryOne");

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

			Property(p => p.HCT0010001)
				.HasColumnName("HCT0010001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010001")
				.IsOptional();

			Property(p => p.HCT0010002)
				.HasColumnName("HCT0010002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010002")
				.IsOptional();

			Property(p => p.HCT0010003)
				.HasColumnName("HCT0010003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010003")
				.IsOptional();

			Property(p => p.HCT0010004)
				.HasColumnName("HCT0010004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010004")
				.IsOptional();

			Property(p => p.HCT0010005)
				.HasColumnName("HCT0010005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010005")
				.IsOptional();

			Property(p => p.HCT0010006)
				.HasColumnName("HCT0010006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010006")
				.IsOptional();

			Property(p => p.HCT0010007)
				.HasColumnName("HCT0010007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010007")
				.IsOptional();

			Property(p => p.HCT0010008)
				.HasColumnName("HCT0010008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010008")
				.IsOptional();

			Property(p => p.HCT0010009)
				.HasColumnName("HCT0010009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010009")
				.IsOptional();

			Property(p => p.HCT0010010)
				.HasColumnName("HCT0010010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010010")
				.IsOptional();

			Property(p => p.HCT0010011)
				.HasColumnName("HCT0010011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010011")
				.IsOptional();

			Property(p => p.HCT0010012)
				.HasColumnName("HCT0010012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010012")
				.IsOptional();

			Property(p => p.HCT0010013)
				.HasColumnName("HCT0010013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010013")
				.IsOptional();

			Property(p => p.HCT0010014)
				.HasColumnName("HCT0010014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010014")
				.IsOptional();

			Property(p => p.HCT0010015)
				.HasColumnName("HCT0010015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010015")
				.IsOptional();

			Property(p => p.HCT0010016)
				.HasColumnName("HCT0010016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010016")
				.IsOptional();

			Property(p => p.HCT0010017)
				.HasColumnName("HCT0010017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010017")
				.IsOptional();

			Property(p => p.HCT0010018)
				.HasColumnName("HCT0010018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010018")
				.IsOptional();

			Property(p => p.HCT0010019)
				.HasColumnName("HCT0010019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010019")
				.IsOptional();

			Property(p => p.HCT0010020)
				.HasColumnName("HCT0010020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010020")
				.IsOptional();

			Property(p => p.HCT0010021)
				.HasColumnName("HCT0010021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010021")
				.IsOptional();

			Property(p => p.HCT0010022)
				.HasColumnName("HCT0010022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010022")
				.IsOptional();

			Property(p => p.HCT0010023)
				.HasColumnName("HCT0010023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010023")
				.IsOptional();

			Property(p => p.HCT0010024)
				.HasColumnName("HCT0010024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010024")
				.IsOptional();

			Property(p => p.HCT0010025)
				.HasColumnName("HCT0010025")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010025")
				.IsOptional();

			Property(p => p.HCT0010026)
				.HasColumnName("HCT0010026")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010026")
				.IsOptional();

			Property(p => p.HCT0010027)
				.HasColumnName("HCT0010027")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010027")
				.IsOptional();

			Property(p => p.HCT0010028)
				.HasColumnName("HCT0010028")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010028")
				.IsOptional();

			Property(p => p.HCT0010029)
				.HasColumnName("HCT0010029")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010029")
				.IsOptional();

			Property(p => p.HCT0010030)
				.HasColumnName("HCT0010030")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010030")
				.IsOptional();

			Property(p => p.HCT0010031)
				.HasColumnName("HCT0010031")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010031")
				.IsOptional();

			Property(p => p.HCT0010032)
				.HasColumnName("HCT0010032")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010032")
				.IsOptional();

			Property(p => p.HCT0010033)
				.HasColumnName("HCT0010033")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010033")
				.IsOptional();

			Property(p => p.HCT0010034)
				.HasColumnName("HCT0010034")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010034")
				.IsOptional();

			Property(p => p.HCT0010035)
				.HasColumnName("HCT0010035")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0010035")
				.IsOptional();

			Property(p => p.HCT0020001)
				.HasColumnName("HCT0020001")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0020001")
				.IsOptional();

			Property(p => p.HCT0020002)
				.HasColumnName("HCT0020002")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0020002")
				.IsOptional();

			Property(p => p.HCT0020003)
				.HasColumnName("HCT0020003")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0020003")
				.IsOptional();

			Property(p => p.HCT0020004)
				.HasColumnName("HCT0020004")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0020004")
				.IsOptional();

			Property(p => p.HCT0020005)
				.HasColumnName("HCT0020005")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0020005")
				.IsOptional();

			Property(p => p.HCT0020006)
				.HasColumnName("HCT0020006")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0020006")
				.IsOptional();

			Property(p => p.HCT0020007)
				.HasColumnName("HCT0020007")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0020007")
				.IsOptional();

			Property(p => p.HCT0020008)
				.HasColumnName("HCT0020008")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0020008")
				.IsOptional();

			Property(p => p.HCT0020009)
				.HasColumnName("HCT0020009")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0020009")
				.IsOptional();

			Property(p => p.HCT0020010)
				.HasColumnName("HCT0020010")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0020010")
				.IsOptional();

			Property(p => p.HCT0020011)
				.HasColumnName("HCT0020011")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0020011")
				.IsOptional();

			Property(p => p.HCT0020012)
				.HasColumnName("HCT0020012")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0020012")
				.IsOptional();

			Property(p => p.HCT0020013)
				.HasColumnName("HCT0020013")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0020013")
				.IsOptional();

			Property(p => p.HCT0030001)
				.HasColumnName("HCT0030001")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0030001")
				.IsOptional();

			Property(p => p.HCT0030002)
				.HasColumnName("HCT0030002")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0030002")
				.IsOptional();

			Property(p => p.HCT0030003)
				.HasColumnName("HCT0030003")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0030003")
				.IsOptional();

			Property(p => p.HCT0030004)
				.HasColumnName("HCT0030004")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0030004")
				.IsOptional();

			Property(p => p.HCT0030005)
				.HasColumnName("HCT0030005")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0030005")
				.IsOptional();

			Property(p => p.HCT0030006)
				.HasColumnName("HCT0030006")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0030006")
				.IsOptional();

			Property(p => p.HCT0030007)
				.HasColumnName("HCT0030007")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0030007")
				.IsOptional();

			Property(p => p.HCT0030008)
				.HasColumnName("HCT0030008")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0030008")
				.IsOptional();

			Property(p => p.HCT0030009)
				.HasColumnName("HCT0030009")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0030009")
				.IsOptional();

			Property(p => p.HCT0030010)
				.HasColumnName("HCT0030010")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0030010")
				.IsOptional();

			Property(p => p.HCT0030011)
				.HasColumnName("HCT0030011")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0030011")
				.IsOptional();

			Property(p => p.HCT0030012)
				.HasColumnName("HCT0030012")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0030012")
				.IsOptional();

			Property(p => p.HCT0030013)
				.HasColumnName("HCT0030013")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0030013")
				.IsOptional();

			Property(p => p.HCT0040001)
				.HasColumnName("HCT0040001")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0040001")
				.IsOptional();

			Property(p => p.HCT0040002)
				.HasColumnName("HCT0040002")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0040002")
				.IsOptional();

			Property(p => p.HCT0040003)
				.HasColumnName("HCT0040003")
				.HasColumnOrder(68)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0040003")
				.IsOptional();

			Property(p => p.HCT0040004)
				.HasColumnName("HCT0040004")
				.HasColumnOrder(69)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0040004")
				.IsOptional();

			Property(p => p.HCT0040005)
				.HasColumnName("HCT0040005")
				.HasColumnOrder(70)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0040005")
				.IsOptional();

			Property(p => p.HCT0040006)
				.HasColumnName("HCT0040006")
				.HasColumnOrder(71)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0040006")
				.IsOptional();

			Property(p => p.HCT0040007)
				.HasColumnName("HCT0040007")
				.HasColumnOrder(72)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0040007")
				.IsOptional();

			Property(p => p.HCT0040008)
				.HasColumnName("HCT0040008")
				.HasColumnOrder(73)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0040008")
				.IsOptional();

			Property(p => p.HCT0040009)
				.HasColumnName("HCT0040009")
				.HasColumnOrder(74)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0040009")
				.IsOptional();

			Property(p => p.HCT0040010)
				.HasColumnName("HCT0040010")
				.HasColumnOrder(75)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0040010")
				.IsOptional();

			Property(p => p.HCT0040011)
				.HasColumnName("HCT0040011")
				.HasColumnOrder(76)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0040011")
				.IsOptional();

			Property(p => p.HCT0040012)
				.HasColumnName("HCT0040012")
				.HasColumnOrder(77)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0040012")
				.IsOptional();

			Property(p => p.HCT0040013)
				.HasColumnName("HCT0040013")
				.HasColumnOrder(78)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("HCT0040013")
				.IsOptional();
		}
	}
}
