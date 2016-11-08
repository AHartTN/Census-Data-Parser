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

	public class SF1CongressionalDistricts113_SF1_00043 : BaseModel
	{
		#region Properties
		[Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
		public string FILEID { get; set; }

		[Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
		public string STUSAB { get; set; }

		[Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
		public string CHARITER { get; set; }

		[Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
		public string CIFSN { get; set; }

		[Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
		public int LOGRECNO { get; set; }

		[Display(Name = "Total:", ShortName = "Total:", Order = 5)]
		public int? H0020001 { get; set; }

		[Display(Name = "Urban:", ShortName = "Urban:", Order = 6)]
		public int? H0020002 { get; set; }

		[Display(Name = "Inside urbanized areas", ShortName = "Inside urbanized areas", Order = 7)]
		public int? H0020003 { get; set; }

		[Display(Name = "Inside urban clusters", ShortName = "Inside urban clusters", Order = 8)]
		public int? H0020004 { get; set; }

		[Display(Name = "Rural", ShortName = "Rural", Order = 9)]
		public int? H0020005 { get; set; }

		[Display(Name = "Not defined for this file", ShortName = "Not defined for this file", Order = 10)]
		public int? H0020006 { get; set; }
		#endregion Properties

		#region Constructors
		public SF1CongressionalDistricts113_SF1_00043() { }

		public SF1CongressionalDistricts113_SF1_00043(string csvLine) : base(csvLine) { }

		public SF1CongressionalDistricts113_SF1_00043(string[] values) : base(values) { }

		public SF1CongressionalDistricts113_SF1_00043(OleDbDataReader reader)
		{
			if(reader[0] != DBNull.Value)
			{
				FILEID = (string)reader[0];
			}
			if(reader[1] != DBNull.Value)
			{
				STUSAB = (string)reader[1];
			}
			if(reader[2] != DBNull.Value)
			{
				CHARITER = (string)reader[2];
			}
			if(reader[3] != DBNull.Value)
			{
				CIFSN = (string)reader[3];
			}
			if(reader[4] != DBNull.Value)
			{
				LOGRECNO = (int)reader[4];
			}
			if(reader[5] != DBNull.Value)
			{
				H0020001 = (int?)reader[5];
			}
			if(reader[6] != DBNull.Value)
			{
				H0020002 = (int?)reader[6];
			}
			if(reader[7] != DBNull.Value)
			{
				H0020003 = (int?)reader[7];
			}
			if(reader[8] != DBNull.Value)
			{
				H0020004 = (int?)reader[8];
			}
			if(reader[9] != DBNull.Value)
			{
				H0020005 = (int?)reader[9];
			}
			if(reader[10] != DBNull.Value)
			{
				H0020006 = (int?)reader[10];
			}
		}
		#endregion Constructors
	}
}
