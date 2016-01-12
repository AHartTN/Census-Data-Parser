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

	public class SF1CongressionalDistricts113_SF1_00039Map : EntityTypeConfiguration<SF1CongressionalDistricts113_SF1_00039>
	{
		public SF1CongressionalDistricts113_SF1_00039Map()
		{
			ToTable("SF1_00039", "SF1CongressionalDistricts113");

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

			Property(p => p.PCT022G001)
				.HasColumnName("PCT022G001")
				.HasColumnOrder(5)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022G001")
				.IsOptional();

			Property(p => p.PCT022G002)
				.HasColumnName("PCT022G002")
				.HasColumnOrder(6)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022G002")
				.IsOptional();

			Property(p => p.PCT022G003)
				.HasColumnName("PCT022G003")
				.HasColumnOrder(7)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022G003")
				.IsOptional();

			Property(p => p.PCT022G004)
				.HasColumnName("PCT022G004")
				.HasColumnOrder(8)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022G004")
				.IsOptional();

			Property(p => p.PCT022G005)
				.HasColumnName("PCT022G005")
				.HasColumnOrder(9)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022G005")
				.IsOptional();

			Property(p => p.PCT022G006)
				.HasColumnName("PCT022G006")
				.HasColumnOrder(10)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022G006")
				.IsOptional();

			Property(p => p.PCT022G007)
				.HasColumnName("PCT022G007")
				.HasColumnOrder(11)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022G007")
				.IsOptional();

			Property(p => p.PCT022G008)
				.HasColumnName("PCT022G008")
				.HasColumnOrder(12)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022G008")
				.IsOptional();

			Property(p => p.PCT022G009)
				.HasColumnName("PCT022G009")
				.HasColumnOrder(13)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022G009")
				.IsOptional();

			Property(p => p.PCT022G010)
				.HasColumnName("PCT022G010")
				.HasColumnOrder(14)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022G010")
				.IsOptional();

			Property(p => p.PCT022G011)
				.HasColumnName("PCT022G011")
				.HasColumnOrder(15)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022G011")
				.IsOptional();

			Property(p => p.PCT022G012)
				.HasColumnName("PCT022G012")
				.HasColumnOrder(16)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022G012")
				.IsOptional();

			Property(p => p.PCT022G013)
				.HasColumnName("PCT022G013")
				.HasColumnOrder(17)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022G013")
				.IsOptional();

			Property(p => p.PCT022G014)
				.HasColumnName("PCT022G014")
				.HasColumnOrder(18)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022G014")
				.IsOptional();

			Property(p => p.PCT022G015)
				.HasColumnName("PCT022G015")
				.HasColumnOrder(19)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022G015")
				.IsOptional();

			Property(p => p.PCT022G016)
				.HasColumnName("PCT022G016")
				.HasColumnOrder(20)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022G016")
				.IsOptional();

			Property(p => p.PCT022G017)
				.HasColumnName("PCT022G017")
				.HasColumnOrder(21)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022G017")
				.IsOptional();

			Property(p => p.PCT022G018)
				.HasColumnName("PCT022G018")
				.HasColumnOrder(22)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022G018")
				.IsOptional();

			Property(p => p.PCT022G019)
				.HasColumnName("PCT022G019")
				.HasColumnOrder(23)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022G019")
				.IsOptional();

			Property(p => p.PCT022G020)
				.HasColumnName("PCT022G020")
				.HasColumnOrder(24)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022G020")
				.IsOptional();

			Property(p => p.PCT022G021)
				.HasColumnName("PCT022G021")
				.HasColumnOrder(25)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022G021")
				.IsOptional();

			Property(p => p.PCT022H001)
				.HasColumnName("PCT022H001")
				.HasColumnOrder(26)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022H001")
				.IsOptional();

			Property(p => p.PCT022H002)
				.HasColumnName("PCT022H002")
				.HasColumnOrder(27)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022H002")
				.IsOptional();

			Property(p => p.PCT022H003)
				.HasColumnName("PCT022H003")
				.HasColumnOrder(28)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022H003")
				.IsOptional();

			Property(p => p.PCT022H004)
				.HasColumnName("PCT022H004")
				.HasColumnOrder(29)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022H004")
				.IsOptional();

			Property(p => p.PCT022H005)
				.HasColumnName("PCT022H005")
				.HasColumnOrder(30)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022H005")
				.IsOptional();

			Property(p => p.PCT022H006)
				.HasColumnName("PCT022H006")
				.HasColumnOrder(31)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022H006")
				.IsOptional();

			Property(p => p.PCT022H007)
				.HasColumnName("PCT022H007")
				.HasColumnOrder(32)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022H007")
				.IsOptional();

			Property(p => p.PCT022H008)
				.HasColumnName("PCT022H008")
				.HasColumnOrder(33)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022H008")
				.IsOptional();

			Property(p => p.PCT022H009)
				.HasColumnName("PCT022H009")
				.HasColumnOrder(34)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022H009")
				.IsOptional();

			Property(p => p.PCT022H010)
				.HasColumnName("PCT022H010")
				.HasColumnOrder(35)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022H010")
				.IsOptional();

			Property(p => p.PCT022H011)
				.HasColumnName("PCT022H011")
				.HasColumnOrder(36)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022H011")
				.IsOptional();

			Property(p => p.PCT022H012)
				.HasColumnName("PCT022H012")
				.HasColumnOrder(37)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022H012")
				.IsOptional();

			Property(p => p.PCT022H013)
				.HasColumnName("PCT022H013")
				.HasColumnOrder(38)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022H013")
				.IsOptional();

			Property(p => p.PCT022H014)
				.HasColumnName("PCT022H014")
				.HasColumnOrder(39)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022H014")
				.IsOptional();

			Property(p => p.PCT022H015)
				.HasColumnName("PCT022H015")
				.HasColumnOrder(40)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022H015")
				.IsOptional();

			Property(p => p.PCT022H016)
				.HasColumnName("PCT022H016")
				.HasColumnOrder(41)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022H016")
				.IsOptional();

			Property(p => p.PCT022H017)
				.HasColumnName("PCT022H017")
				.HasColumnOrder(42)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022H017")
				.IsOptional();

			Property(p => p.PCT022H018)
				.HasColumnName("PCT022H018")
				.HasColumnOrder(43)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022H018")
				.IsOptional();

			Property(p => p.PCT022H019)
				.HasColumnName("PCT022H019")
				.HasColumnOrder(44)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022H019")
				.IsOptional();

			Property(p => p.PCT022H020)
				.HasColumnName("PCT022H020")
				.HasColumnOrder(45)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022H020")
				.IsOptional();

			Property(p => p.PCT022H021)
				.HasColumnName("PCT022H021")
				.HasColumnOrder(46)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022H021")
				.IsOptional();

			Property(p => p.PCT022I001)
				.HasColumnName("PCT022I001")
				.HasColumnOrder(47)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022I001")
				.IsOptional();

			Property(p => p.PCT022I002)
				.HasColumnName("PCT022I002")
				.HasColumnOrder(48)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022I002")
				.IsOptional();

			Property(p => p.PCT022I003)
				.HasColumnName("PCT022I003")
				.HasColumnOrder(49)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022I003")
				.IsOptional();

			Property(p => p.PCT022I004)
				.HasColumnName("PCT022I004")
				.HasColumnOrder(50)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022I004")
				.IsOptional();

			Property(p => p.PCT022I005)
				.HasColumnName("PCT022I005")
				.HasColumnOrder(51)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022I005")
				.IsOptional();

			Property(p => p.PCT022I006)
				.HasColumnName("PCT022I006")
				.HasColumnOrder(52)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022I006")
				.IsOptional();

			Property(p => p.PCT022I007)
				.HasColumnName("PCT022I007")
				.HasColumnOrder(53)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022I007")
				.IsOptional();

			Property(p => p.PCT022I008)
				.HasColumnName("PCT022I008")
				.HasColumnOrder(54)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022I008")
				.IsOptional();

			Property(p => p.PCT022I009)
				.HasColumnName("PCT022I009")
				.HasColumnOrder(55)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022I009")
				.IsOptional();

			Property(p => p.PCT022I010)
				.HasColumnName("PCT022I010")
				.HasColumnOrder(56)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022I010")
				.IsOptional();

			Property(p => p.PCT022I011)
				.HasColumnName("PCT022I011")
				.HasColumnOrder(57)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022I011")
				.IsOptional();

			Property(p => p.PCT022I012)
				.HasColumnName("PCT022I012")
				.HasColumnOrder(58)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022I012")
				.IsOptional();

			Property(p => p.PCT022I013)
				.HasColumnName("PCT022I013")
				.HasColumnOrder(59)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022I013")
				.IsOptional();

			Property(p => p.PCT022I014)
				.HasColumnName("PCT022I014")
				.HasColumnOrder(60)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022I014")
				.IsOptional();

			Property(p => p.PCT022I015)
				.HasColumnName("PCT022I015")
				.HasColumnOrder(61)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022I015")
				.IsOptional();

			Property(p => p.PCT022I016)
				.HasColumnName("PCT022I016")
				.HasColumnOrder(62)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022I016")
				.IsOptional();

			Property(p => p.PCT022I017)
				.HasColumnName("PCT022I017")
				.HasColumnOrder(63)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022I017")
				.IsOptional();

			Property(p => p.PCT022I018)
				.HasColumnName("PCT022I018")
				.HasColumnOrder(64)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022I018")
				.IsOptional();

			Property(p => p.PCT022I019)
				.HasColumnName("PCT022I019")
				.HasColumnOrder(65)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022I019")
				.IsOptional();

			Property(p => p.PCT022I020)
				.HasColumnName("PCT022I020")
				.HasColumnOrder(66)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022I020")
				.IsOptional();

			Property(p => p.PCT022I021)
				.HasColumnName("PCT022I021")
				.HasColumnOrder(67)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("PCT022I021")
				.IsOptional();
		}
	}
}
