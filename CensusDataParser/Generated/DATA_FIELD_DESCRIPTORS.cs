namespace CensusDataParser.Generated
{
	#region Using Directives
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.OleDb;
	using Enumerators;
	#endregion

	namespace CensusDataParser.Generated.SummaryOne
	{
		#region Using Directives
		using System;
		using System.Collections.Generic;
		using System.ComponentModel;
		using System.ComponentModel.DataAnnotations;
		using System.ComponentModel.DataAnnotations.Schema;
		using System.Data.OleDb;
		using Enumerators;
		#endregion Using Directives

		[Table("DATA_FIELD_DESCRIPTORS")]
		public partial class DATA_FIELD_DESCRIPTORS : BaseModel
		{
			#region Properties
			[ReadOnly(false)]
			[Column("SORT_ID", Order = 0)]
			[DatabaseGenerated(DatabaseGeneratedOption.None)]
			[Display(Name = "SORT ID", ShortName = "SORT ID", Order = 0)]
			public System.Nullable<System.Int32> SORT_ID { get; set; }

			[MaxLength(2)]
			[ReadOnly(false)]
			[Column("SEGMENT", Order = 1)]
			[DatabaseGenerated(DatabaseGeneratedOption.None)]
			[Display(Name = "SEGMENT", ShortName = "SEGMENT", Order = 1)]
			public System.String SEGMENT { get; set; }

			[MaxLength(6)]
			[ReadOnly(false)]
			[Column("TABLE_NUMBER", Order = 2)]
			[DatabaseGenerated(DatabaseGeneratedOption.None)]
			[Display(Name = "TABLE NUMBER", ShortName = "TABLE NUMBER", Order = 2)]
			public System.String TABLE_NUMBER { get; set; }

			[MaxLength(255)]
			[ReadOnly(false)]
			[Column("FIELD_NAME", Order = 3)]
			[DatabaseGenerated(DatabaseGeneratedOption.None)]
			[Display(Name = "FIELD NAME", ShortName = "FIELD NAME", Order = 3)]
			public System.String FIELD_NAME { get; set; }

			[MaxLength(10)]
			[ReadOnly(false)]
			[Column("FIELD_CODE", Order = 4)]
			[DatabaseGenerated(DatabaseGeneratedOption.None)]
			[Display(Name = "FIELD CODE", ShortName = "FIELD CODE", Order = 4)]
			public System.String FIELD_CODE { get; set; }

			[ReadOnly(false)]
			[Column("DECIMAL", Order = 5)]
			[DatabaseGenerated(DatabaseGeneratedOption.None)]
			[Display(Name = "DECIMAL", ShortName = "DECIMAL", Order = 5)]
			public System.Nullable<System.Int16> DECIMAL { get; set; }
			#endregion Properties

			#region Constructors
			public DATA_FIELD_DESCRIPTORS(string csvLine) : base(csvLine) {}

			public DATA_FIELD_DESCRIPTORS(string[] values) : base(values) {}

			public DATA_FIELD_DESCRIPTORS(OleDbDataReader reader, CensusFileType fileType)
			{
				if(reader[0] != DBNull.Value)
				{
					SORT_ID = (System.Nullable<System.Int32>)reader[0];
				}
				if(reader[1] != DBNull.Value)
				{
					SEGMENT = (System.String)reader[1];
				}
				if(reader[2] != DBNull.Value)
				{
					TABLE_NUMBER = (System.String)reader[2];
				}
				if(reader[3] != DBNull.Value)
				{
					FIELD_NAME = (System.String)reader[3];
				}
				if(reader[4] != DBNull.Value)
				{
					FIELD_CODE = (System.String)reader[4];
				}
				if(reader[5] != DBNull.Value)
				{
					DECIMAL = (System.Nullable<System.Int16>)reader[5];
				}
			}
			#endregion Constructors
		}
	}
}
