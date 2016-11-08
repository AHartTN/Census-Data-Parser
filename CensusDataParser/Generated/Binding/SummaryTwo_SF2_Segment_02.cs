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

	public class SummaryTwo_SF2_Segment_02 : BaseModel
	{
		#region Properties
		[Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
		public string FILEID { get; set; }

		[Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
		public string STUSAB { get; set; }

		[Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
		public int CHARITER { get; set; }

		[Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
		public int CIFSN { get; set; }

		[Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
		public int LOGRECNO { get; set; }

		[Display(Name = "Total tribes tallied (300, A01-Z99) & (300, A01-Z99):", ShortName = "Total tribes tallied (300, A01-Z99) & (300, A01-Z99):", Order = 5)]
		public int? PCT0020001 { get; set; }

		[Display(Name = "American Indian tribes, specified (A01-M38, T01-Z99) & (300, A01-Z99):", ShortName = "American Indian tribes, specified (A01-M38, T01-Z99) & (300, A01-Z99):", Order = 6)]
		public int? PCT0020002 { get; set; }

		[Display(Name = "Apache (A09-A23) & (300, A01-Z99)", ShortName = "Apache (A09-A23) & (300, A01-Z99)", Order = 7)]
		public int? PCT0020003 { get; set; }

		[Display(Name = "Arapaho (A24-A33) & (300, A01-Z99)", ShortName = "Arapaho (A24-A33) & (300, A01-Z99)", Order = 8)]
		public int? PCT0020004 { get; set; }

		[Display(Name = "Blackfeet (A45-A50) & (300, A01-Z99)", ShortName = "Blackfeet (A45-A50) & (300, A01-Z99)", Order = 9)]
		public int? PCT0020005 { get; set; }

		[Display(Name = "Canadian and French American Indian (T01-V23) & (300, A01-Z99)", ShortName = "Canadian and French American Indian (T01-V23) & (300, A01-Z99)", Order = 10)]
		public int? PCT0020006 { get; set; }
		#endregion Properties

		#region Constructors
		public SummaryTwo_SF2_Segment_02() { }

		public SummaryTwo_SF2_Segment_02(string csvLine) : base(csvLine) { }

		public SummaryTwo_SF2_Segment_02(string[] values) : base(values) { }

		public SummaryTwo_SF2_Segment_02(OleDbDataReader reader)
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
				CHARITER = (int)reader[2];
			}
			if(reader[3] != DBNull.Value)
			{
				CIFSN = (int)reader[3];
			}
			if(reader[4] != DBNull.Value)
			{
				LOGRECNO = (int)reader[4];
			}
			if(reader[5] != DBNull.Value)
			{
				PCT0020001 = (int?)reader[5];
			}
			if(reader[6] != DBNull.Value)
			{
				PCT0020002 = (int?)reader[6];
			}
			if(reader[7] != DBNull.Value)
			{
				PCT0020003 = (int?)reader[7];
			}
			if(reader[8] != DBNull.Value)
			{
				PCT0020004 = (int?)reader[8];
			}
			if(reader[9] != DBNull.Value)
			{
				PCT0020005 = (int?)reader[9];
			}
			if(reader[10] != DBNull.Value)
			{
				PCT0020006 = (int?)reader[10];
			}
		}
		#endregion Constructors
	}
}
