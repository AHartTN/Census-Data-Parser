namespace CensusDataParser.Generated.Mapping
{
	#region Using Directives
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.ModelConfiguration;
	using Binding;
	#endregion Using Directives

	public class DemographicProfile_HeaderMap : EntityTypeConfiguration<DemographicProfile_Header>
	{
		public DemographicProfile_HeaderMap()
		{
			ToTable("Header", "DemographicProfile");

			HasKey(k => new
			            {
				            k.DESC
			            });

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
