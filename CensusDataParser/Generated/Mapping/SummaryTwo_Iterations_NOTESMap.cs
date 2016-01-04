namespace CensusDataParser.Generated.Mapping
{
	#region Using Directives
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.ModelConfiguration;
	using Binding;
	#endregion Using Directives

	public class SummaryTwo_Iterations_NOTESMap : EntityTypeConfiguration<SummaryTwo_Iterations_NOTES>
	{
		public SummaryTwo_Iterations_NOTESMap()
		{
			ToTable("Iterations_NOTES", "SummaryTwo");

			HasKey(k => new
			            {
				            k.SORT_ID
			            });

			Property(p => p.SORT_ID)
				.HasColumnName("SORT_ID")
				.HasColumnOrder(0)
				.HasColumnType("INT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("SORT_ID")
				.IsRequired();

			Property(p => p.NOTE)
				.HasColumnName("NOTE")
				.HasColumnOrder(1)
				.HasColumnType("BIGINT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("NOTE")
				.IsOptional();
		}
	}
}
