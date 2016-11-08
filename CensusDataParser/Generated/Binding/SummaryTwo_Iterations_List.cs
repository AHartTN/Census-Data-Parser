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
	using Models;
	#endregion Using Directives

	public class SummaryTwo_Iterations_List : BaseModel
	{
		#region Properties
		[Display(Name = "SORT ID", ShortName = "SORT ID", Order = 0)]
		public int SORT_ID { get; set; }

		[Display(Name = "Iteration Code", ShortName = "Iteration Code", Order = 1)]
		public string Iteration_Code { get; set; }

		[Display(Name = "Iterations", ShortName = "Iterations", Order = 2)]
		public string Iterations { get; set; }
		#endregion Properties

		#region Constructors
		public SummaryTwo_Iterations_List() { }

		public SummaryTwo_Iterations_List(string csvLine) : base(csvLine) { }

		public SummaryTwo_Iterations_List(string[] values) : base(values) { }

		public SummaryTwo_Iterations_List(OleDbDataReader reader)
		{
			if(reader[0] != DBNull.Value)
			{
				SORT_ID = (int)reader[0];
			}
			if(reader[1] != DBNull.Value)
			{
				Iteration_Code = (string)reader[1];
			}
			if(reader[2] != DBNull.Value)
			{
				Iterations = (string)reader[2];
			}
		}
		#endregion Constructors
	}
}
