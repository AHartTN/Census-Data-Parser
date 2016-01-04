namespace CensusDataParser.Generated.Binding
{
	#region Using Directives
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.Data.OleDb;
	#endregion Using Directives

	public class SummaryTwo_DataDictionary_NOTES : BaseModel
	{
		#region Properties
		[Display(Name = "SORT ID", ShortName = "SORT ID", Order = 0)]
		public int SORT_ID { get; set; }

		[Display(Name = "Table", ShortName = "Table", Order = 1)]
		public string Table { get; set; }

		[Display(Name = "Field Name", ShortName = "Field Name", Order = 2)]
		public long? Field_Name { get; set; }
		#endregion Properties

		#region Constructors
		public SummaryTwo_DataDictionary_NOTES(string csvLine) : base(csvLine) { }

		public SummaryTwo_DataDictionary_NOTES(string[] values) : base(values) { }

		public SummaryTwo_DataDictionary_NOTES(OleDbDataReader reader)
		{
			if (reader[0] != DBNull.Value)
			{
				SORT_ID = (int)reader[0];
			}
			if (reader[1] != DBNull.Value)
			{
				Table = (string)reader[1];
			}
			if (reader[2] != DBNull.Value)
			{
				Field_Name = (long?)reader[2];
			}
		}
		#endregion Constructors
	}
}
