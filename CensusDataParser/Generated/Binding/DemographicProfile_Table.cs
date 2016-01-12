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

	public class DemographicProfile_Table : BaseModel
	{
		#region Properties
		[Display(Name = "STUB", ShortName = "STUB", Order = 0)]
		public string STUB { get; set; }

		[Display(Name = "ITEM", ShortName = "ITEM", Order = 1)]
		public string ITEM { get; set; }

		[Display(Name = "SEGMENT", ShortName = "SEGMENT", Order = 2)]
		public decimal SEGMENT { get; set; }
		#endregion Properties

		#region Constructors
		public DemographicProfile_Table() { }

		public DemographicProfile_Table(string csvLine) : base(csvLine) { }

		public DemographicProfile_Table(string[] values) : base(values) { }

		public DemographicProfile_Table(OleDbDataReader reader)
		{
			if(reader[0] != DBNull.Value)
			{
				STUB = (string)reader[0];
			}
			if(reader[1] != DBNull.Value)
			{
				ITEM = (string)reader[1];
			}
			if(reader[2] != DBNull.Value)
			{
				SEGMENT = (decimal)reader[2];
			}
		}
		#endregion Constructors
	}
}
