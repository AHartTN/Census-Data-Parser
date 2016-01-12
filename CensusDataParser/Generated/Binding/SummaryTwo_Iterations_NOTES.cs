namespace CensusDataParser.Generated.Binding
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

	public class SummaryTwo_Iterations_NOTES : BaseModel
	{
		#region Properties
		[Display(Name = "SORT ID", ShortName = "SORT ID", Order = 0)]
		public int SORT_ID { get; set; }

		[Display(Name = "NOTE", ShortName = "NOTE", Order = 1)]
		public long? NOTE { get; set; }
		#endregion Properties

		#region Constructors
		public SummaryTwo_Iterations_NOTES() { }

		public SummaryTwo_Iterations_NOTES(string csvLine) : base(csvLine) { }

		public SummaryTwo_Iterations_NOTES(string[] values) : base(values) { }

		public SummaryTwo_Iterations_NOTES(OleDbDataReader reader)
		{
			if(reader[0] != DBNull.Value)
			{
				SORT_ID = (int)reader[0];
			}
			if(reader[1] != DBNull.Value)
			{
				NOTE = (long?)reader[1];
			}
		}
		#endregion Constructors
	}
}
