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

	public class SummaryTwo_Table_Names : BaseModel
	{
		#region Properties
		[Display(Name = "SORT ID", ShortName = "SORT ID", Order = 0)]
		public int SORT_ID { get; set; }

		[Display(Name = "TABLE CODE", ShortName = "TABLE CODE", Order = 1)]
		public string TABLE_CODE { get; set; }

		[Display(Name = "TABLE NAME", ShortName = "TABLE NAME", Order = 2)]
		public string TABLE_NAME { get; set; }

		[Display(Name = "CELL COUNT", ShortName = "CELL COUNT", Order = 3)]
		public string CELL_COUNT { get; set; }
		#endregion Properties

		#region Constructors
		public SummaryTwo_Table_Names() { }

		public SummaryTwo_Table_Names(string csvLine) : base(csvLine) { }

		public SummaryTwo_Table_Names(string[] values) : base(values) { }

		public SummaryTwo_Table_Names(OleDbDataReader reader)
		{
			if(reader[0] != DBNull.Value)
			{
				SORT_ID = (int)reader[0];
			}
			if(reader[1] != DBNull.Value)
			{
				TABLE_CODE = (string)reader[1];
			}
			if(reader[2] != DBNull.Value)
			{
				TABLE_NAME = (string)reader[2];
			}
			if(reader[3] != DBNull.Value)
			{
				CELL_COUNT = (string)reader[3];
			}
		}
		#endregion Constructors
	}
}
