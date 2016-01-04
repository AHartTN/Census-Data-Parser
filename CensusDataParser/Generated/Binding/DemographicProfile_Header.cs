namespace CensusDataParser.Generated.Binding
{
	#region Using Directives
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.Data.OleDb;
	#endregion Using Directives

	public class DemographicProfile_Header : BaseModel
	{
		#region Properties
		[Display(Name = "DESC", ShortName = "DESC", Order = 0)]
		public string DESC { get; set; }

		[Display(Name = "Area Name-Legal/Statistical Area Description (LSAD) Term-Part Indicator", ShortName = "Area Name-Legal/Statistical Area Description (LSAD) Term-Part Indicator", Order = 1)]
		public string NAME { get; set; }

		[Display(Name = "LEN", ShortName = "LEN", Order = 2)]
		public decimal? LEN { get; set; }
		#endregion Properties

		#region Constructors
		public DemographicProfile_Header(string csvLine) : base(csvLine) { }

		public DemographicProfile_Header(string[] values) : base(values) { }

		public DemographicProfile_Header(OleDbDataReader reader)
		{
			if (reader[0] != DBNull.Value)
			{
				DESC = (string)reader[0];
			}
			if (reader[1] != DBNull.Value)
			{
				NAME = (string)reader[1];
			}
			if (reader[2] != DBNull.Value)
			{
				LEN = (decimal?)reader[2];
			}
		}
		#endregion Constructors
	}
}
