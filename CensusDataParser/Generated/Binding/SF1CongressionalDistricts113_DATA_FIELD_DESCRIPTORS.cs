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

	public class SF1CongressionalDistricts113_DATA_FIELD_DESCRIPTORS : BaseModel
	{
		#region Properties
		[Display(Name = "SORT ID", ShortName = "SORT ID", Order = 0)]
		public int SORT_ID { get; set; }

		[Display(Name = "SEGMENT", ShortName = "SEGMENT", Order = 1)]
		public string SEGMENT { get; set; }

		[Display(Name = "TABLE NUMBER", ShortName = "TABLE NUMBER", Order = 2)]
		public string TABLE_NUMBER { get; set; }

		[Display(Name = "FIELD NAME", ShortName = "FIELD NAME", Order = 3)]
		public string FIELD_NAME { get; set; }

		[Display(Name = "FIELD CODE", ShortName = "FIELD CODE", Order = 4)]
		public string FIELD_CODE { get; set; }

		[Display(Name = "DECIMAL", ShortName = "DECIMAL", Order = 5)]
		public short? DECIMAL { get; set; }
		#endregion Properties

		#region Constructors
		public SF1CongressionalDistricts113_DATA_FIELD_DESCRIPTORS() { }

		public SF1CongressionalDistricts113_DATA_FIELD_DESCRIPTORS(string csvLine) : base(csvLine) { }

		public SF1CongressionalDistricts113_DATA_FIELD_DESCRIPTORS(string[] values) : base(values) { }

		public SF1CongressionalDistricts113_DATA_FIELD_DESCRIPTORS(OleDbDataReader reader)
		{
			if(reader[0] != DBNull.Value)
			{
				SORT_ID = (int)reader[0];
			}
			if(reader[1] != DBNull.Value)
			{
				SEGMENT = (string)reader[1];
			}
			if(reader[2] != DBNull.Value)
			{
				TABLE_NUMBER = (string)reader[2];
			}
			if(reader[3] != DBNull.Value)
			{
				FIELD_NAME = (string)reader[3];
			}
			if(reader[4] != DBNull.Value)
			{
				FIELD_CODE = (string)reader[4];
			}
			if(reader[5] != DBNull.Value)
			{
				DECIMAL = (short?)reader[5];
			}
		}
		#endregion Constructors
	}
}
