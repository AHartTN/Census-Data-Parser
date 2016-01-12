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

	public class SummaryTwo_GeoHeader_SpecificationsMap : EntityTypeConfiguration<SummaryTwo_GeoHeader_Specifications>
	{
		public SummaryTwo_GeoHeader_SpecificationsMap()
		{
			ToTable("GeoHeader_Specifications", "SummaryTwo");

			HasKey(k => new {k.ID});

			Property(p => p.ID)
				.HasColumnName("ID")
				.HasColumnOrder(0)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("ID")
				.IsRequired();

			Property(p => p.FIELD)
				.HasColumnName("FIELD")
				.HasColumnOrder(1)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(255)
				.HasParameterName("FIELD")
				.IsOptional();

			Property(p => p.DATA_DICTIONARY_REFERENCE)
				.HasColumnName("DATA_DICTIONARY_REFERENCE")
				.HasColumnOrder(2)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(255)
				.HasParameterName("DATA_DICTIONARY_REFERENCE")
				.IsOptional();

			Property(p => p.STARTING_POSITION)
				.HasColumnName("STARTING_POSITION")
				.HasColumnOrder(3)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(255)
				.HasParameterName("STARTING_POSITION")
				.IsOptional();

			Property(p => p.FIELD_SIZE)
				.HasColumnName("FIELD_SIZE")
				.HasColumnOrder(4)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(255)
				.HasParameterName("FIELD_SIZE")
				.IsOptional();

			Property(p => p.DATA_TYPE)
				.HasColumnName("DATA_TYPE")
				.HasColumnOrder(5)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(255)
				.HasParameterName("DATA_TYPE")
				.IsOptional();
		}
	}
}
