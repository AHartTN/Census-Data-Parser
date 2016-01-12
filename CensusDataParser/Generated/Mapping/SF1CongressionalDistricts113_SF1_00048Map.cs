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

	public class SF1CongressionalDistricts113_SF1_00048Map : EntityTypeConfiguration<SF1CongressionalDistricts113_SF1_00048>
	{
		public SF1CongressionalDistricts113_SF1_00048Map()
		{
			ToTable("SF1_00048", "SF1CongressionalDistricts113");

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

			Property(p => p.PCT0230001)
				.HasColumnName("PCT0230001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0230001")
				.IsOptional();

			Property(p => p.PCT0230002)
				.HasColumnName("PCT0230002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0230002")
				.IsOptional();

			Property(p => p.PCT0230003)
				.HasColumnName("PCT0230003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0230003")
				.IsOptional();

			Property(p => p.PCT0230004)
				.HasColumnName("PCT0230004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0230004")
				.IsOptional();

			Property(p => p.PCT0230005)
				.HasColumnName("PCT0230005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0230005")
				.IsOptional();

			Property(p => p.PCT0230006)
				.HasColumnName("PCT0230006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0230006")
				.IsOptional();

			Property(p => p.PCT0230007)
				.HasColumnName("PCT0230007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0230007")
				.IsOptional();

			Property(p => p.PCT0230008)
				.HasColumnName("PCT0230008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0230008")
				.IsOptional();

			Property(p => p.PCT0230009)
				.HasColumnName("PCT0230009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0230009")
				.IsOptional();

			Property(p => p.PCT0230010)
				.HasColumnName("PCT0230010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0230010")
				.IsOptional();

			Property(p => p.PCT0230011)
				.HasColumnName("PCT0230011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0230011")
				.IsOptional();

			Property(p => p.PCT0230012)
				.HasColumnName("PCT0230012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0230012")
				.IsOptional();

			Property(p => p.PCT0230013)
				.HasColumnName("PCT0230013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0230013")
				.IsOptional();

			Property(p => p.PCT0230014)
				.HasColumnName("PCT0230014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0230014")
				.IsOptional();

			Property(p => p.PCT0230015)
				.HasColumnName("PCT0230015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0230015")
				.IsOptional();

			Property(p => p.PCT0230016)
				.HasColumnName("PCT0230016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0230016")
				.IsOptional();

			Property(p => p.PCT0230017)
				.HasColumnName("PCT0230017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0230017")
				.IsOptional();

			Property(p => p.PCT0230018)
				.HasColumnName("PCT0230018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0230018")
				.IsOptional();

			Property(p => p.PCT0230019)
				.HasColumnName("PCT0230019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0230019")
				.IsOptional();

			Property(p => p.PCT0230020)
				.HasColumnName("PCT0230020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0230020")
				.IsOptional();

			Property(p => p.PCT0230021)
				.HasColumnName("PCT0230021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0230021")
				.IsOptional();

			Property(p => p.PCT0230022)
				.HasColumnName("PCT0230022")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0230022")
				.IsOptional();

			Property(p => p.PCT0230023)
				.HasColumnName("PCT0230023")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0230023")
				.IsOptional();

			Property(p => p.PCT0230024)
				.HasColumnName("PCT0230024")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0230024")
				.IsOptional();

			Property(p => p.PCT0240001)
				.HasColumnName("PCT0240001")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0240001")
				.IsOptional();

			Property(p => p.PCT0240002)
				.HasColumnName("PCT0240002")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0240002")
				.IsOptional();

			Property(p => p.PCT0240003)
				.HasColumnName("PCT0240003")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0240003")
				.IsOptional();

			Property(p => p.PCT0240004)
				.HasColumnName("PCT0240004")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0240004")
				.IsOptional();

			Property(p => p.PCT0240005)
				.HasColumnName("PCT0240005")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0240005")
				.IsOptional();

			Property(p => p.PCT0240006)
				.HasColumnName("PCT0240006")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0240006")
				.IsOptional();

			Property(p => p.PCT0240007)
				.HasColumnName("PCT0240007")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0240007")
				.IsOptional();

			Property(p => p.PCT0240008)
				.HasColumnName("PCT0240008")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0240008")
				.IsOptional();

			Property(p => p.PCT0240009)
				.HasColumnName("PCT0240009")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0240009")
				.IsOptional();

			Property(p => p.PCT0240010)
				.HasColumnName("PCT0240010")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0240010")
				.IsOptional();

			Property(p => p.PCT0240011)
				.HasColumnName("PCT0240011")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0240011")
				.IsOptional();

			Property(p => p.PCT0240012)
				.HasColumnName("PCT0240012")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0240012")
				.IsOptional();

			Property(p => p.PCT0240013)
				.HasColumnName("PCT0240013")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0240013")
				.IsOptional();

			Property(p => p.PCT0240014)
				.HasColumnName("PCT0240014")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0240014")
				.IsOptional();

			Property(p => p.PCT0240015)
				.HasColumnName("PCT0240015")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0240015")
				.IsOptional();

			Property(p => p.PCT0240016)
				.HasColumnName("PCT0240016")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0240016")
				.IsOptional();

			Property(p => p.PCT0240017)
				.HasColumnName("PCT0240017")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0240017")
				.IsOptional();

			Property(p => p.PCT0240018)
				.HasColumnName("PCT0240018")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0240018")
				.IsOptional();

			Property(p => p.PCT0240019)
				.HasColumnName("PCT0240019")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0240019")
				.IsOptional();

			Property(p => p.PCT0240020)
				.HasColumnName("PCT0240020")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0240020")
				.IsOptional();

			Property(p => p.PCT0240021)
				.HasColumnName("PCT0240021")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0240021")
				.IsOptional();

			Property(p => p.PCT0240022)
				.HasColumnName("PCT0240022")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0240022")
				.IsOptional();

			Property(p => p.PCT0240023)
				.HasColumnName("PCT0240023")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT0240023")
				.IsOptional();
		}
	}
}
