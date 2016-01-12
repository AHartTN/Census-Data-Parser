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

	public class SummaryOne_DATA_FIELD_DESCRIPTORSMap : EntityTypeConfiguration<SummaryOne_DATA_FIELD_DESCRIPTORS>
	{
		public SummaryOne_DATA_FIELD_DESCRIPTORSMap()
		{
			ToTable("DATA_FIELD_DESCRIPTORS", "SummaryOne");

			HasKey(k => new {k.SORT_ID, k.SEGMENT, k.TABLE_NUMBER, k.FIELD_CODE});

			Property(p => p.SORT_ID)
				.HasColumnName("SORT_ID")
				.HasColumnOrder(0)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("SORT_ID")
				.IsRequired();

			Property(p => p.SEGMENT)
				.HasColumnName("SEGMENT")
				.HasColumnOrder(1)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(2)
				.HasParameterName("SEGMENT")
				.IsRequired();

			Property(p => p.TABLE_NUMBER)
				.HasColumnName("TABLE_NUMBER")
				.HasColumnOrder(2)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(6)
				.HasParameterName("TABLE_NUMBER")
				.IsRequired();

			Property(p => p.FIELD_NAME)
				.HasColumnName("FIELD_NAME")
				.HasColumnOrder(3)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(255)
				.HasParameterName("FIELD_NAME")
				.IsOptional();

			Property(p => p.FIELD_CODE)
				.HasColumnName("FIELD_CODE")
				.HasColumnOrder(4)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(10)
				.HasParameterName("FIELD_CODE")
				.IsRequired();

			Property(p => p.DECIMAL)
				.HasColumnName("DECIMAL")
				.HasColumnOrder(5)
				.HasColumnType("SMALLINT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("DECIMAL")
				.IsOptional();
		}
	}
}
