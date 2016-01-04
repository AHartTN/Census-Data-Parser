namespace CensusDataParser.Generated.Mapping
{
	#region Using Directives
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.ModelConfiguration;
	using Binding;
	#endregion Using Directives

	public class SummaryTwo_Iterations_ListMap : EntityTypeConfiguration<SummaryTwo_Iterations_List>
	{
		public SummaryTwo_Iterations_ListMap()
		{
			ToTable("Iterations_List", "SummaryTwo");

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

			Property(p => p.Iteration_Code)
				.HasColumnName("Iteration_Code")
				.HasColumnOrder(1)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(255)
				.HasParameterName("Iteration_Code")
				.IsOptional();

			Property(p => p.Iterations)
				.HasColumnName("Iterations")
				.HasColumnOrder(2)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(255)
				.HasParameterName("Iterations")
				.IsOptional();
		}
	}
}
