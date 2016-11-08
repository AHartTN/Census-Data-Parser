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

	public class SummaryTwo_GeoHeader_Specifications : BaseModel
	{
		#region Properties
		[Display(Name = "ID", ShortName = "ID", Order = 0)]
		public int ID { get; set; }

		[Display(Name = "FIELD", ShortName = "FIELD", Order = 1)]
		public string FIELD { get; set; }

		[Display(Name = "DATA DICTIONARY REFERENCE", ShortName = "DATA DICTIONARY REFERENCE", Order = 2)]
		public string DATA_DICTIONARY_REFERENCE { get; set; }

		[Display(Name = "STARTING POSITION", ShortName = "STARTING POSITION", Order = 3)]
		public string STARTING_POSITION { get; set; }

		[Display(Name = "FIELD SIZE", ShortName = "FIELD SIZE", Order = 4)]
		public string FIELD_SIZE { get; set; }

		[Display(Name = "DATA TYPE", ShortName = "DATA TYPE", Order = 5)]
		public string DATA_TYPE { get; set; }
		#endregion Properties

		#region Constructors
		public SummaryTwo_GeoHeader_Specifications() { }

		public SummaryTwo_GeoHeader_Specifications(string csvLine) : base(csvLine) { }

		public SummaryTwo_GeoHeader_Specifications(string[] values) : base(values) { }

		public SummaryTwo_GeoHeader_Specifications(OleDbDataReader reader)
		{
			if(reader[0] != DBNull.Value)
			{
				ID = (int)reader[0];
			}
			if(reader[1] != DBNull.Value)
			{
				FIELD = (string)reader[1];
			}
			if(reader[2] != DBNull.Value)
			{
				DATA_DICTIONARY_REFERENCE = (string)reader[2];
			}
			if(reader[3] != DBNull.Value)
			{
				STARTING_POSITION = (string)reader[3];
			}
			if(reader[4] != DBNull.Value)
			{
				FIELD_SIZE = (string)reader[4];
			}
			if(reader[5] != DBNull.Value)
			{
				DATA_TYPE = (string)reader[5];
			}
		}
		#endregion Constructors
	}
}
