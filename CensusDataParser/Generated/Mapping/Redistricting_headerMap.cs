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

	public class Redistricting_headerMap : EntityTypeConfiguration<Redistricting_header>
	{
		public Redistricting_headerMap()
		{
			ToTable("header", "Redistricting");

			HasKey(k => new {k.DESC});

			Property(p => p.DESC)
				.HasColumnName("DESC")
				.HasColumnOrder(0)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(255)
				.HasParameterName("DESC")
				.IsRequired();

			Property(p => p.NAME)
				.HasColumnName("NAME")
				.HasColumnOrder(1)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(255)
				.HasParameterName("NAME")
				.IsOptional();

			Property(p => p.LEN)
				.HasColumnName("LEN")
				.HasColumnOrder(2)
				.HasColumnType("DECIMAL")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("LEN")
				.IsOptional();
		}
	}
}
