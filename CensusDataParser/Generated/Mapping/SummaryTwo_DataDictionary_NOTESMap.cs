namespace CensusDataParser.Generated.Mapping
{
	#region Using Directives
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.ModelConfiguration;
	using Binding;
	#endregion Using Directives

	public class SummaryTwo_DataDictionary_NOTESMap : EntityTypeConfiguration<SummaryTwo_DataDictionary_NOTES>
	{
		public SummaryTwo_DataDictionary_NOTESMap()
		{
			ToTable("DataDictionary_NOTES", "SummaryTwo");

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

			Property(p => p.Table)
				.HasColumnName("Table")
				.HasColumnOrder(1)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(255)
				.HasParameterName("Table")
				.IsOptional();

			Property(p => p.Field_Name)
				.HasColumnName("Field_Name")
				.HasColumnOrder(2)
				.HasColumnType("BIGINT")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasParameterName("Field_Name")
				.IsOptional();
		}
	}
}
