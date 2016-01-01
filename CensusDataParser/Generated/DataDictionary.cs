namespace CensusDataParser.Generated.CensusDataParser.Generated.SummaryTwo
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

    [Table("DataDictionary")]
    public partial class DataDictionary : BaseModel
    {
        #region Properties
        [ReadOnly(false)]
        [Column("SORT_ID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "SORT ID", ShortName = "SORT ID", Order = 0)]
        public System.Nullable<System.Int32> SORT_ID { get; set; }

        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("TABLE", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "TABLE", ShortName = "TABLE", Order = 1)]
        public System.String TABLE { get; set; }

        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("SEGMENT", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "SEGMENT", ShortName = "SEGMENT", Order = 2)]
        public System.String SEGMENT { get; set; }

        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("FIELD_NAME", Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "FIELD NAME", ShortName = "FIELD NAME", Order = 3)]
        public System.String FIELD_NAME { get; set; }

        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("FIELD_CODE", Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "FIELD CODE", ShortName = "FIELD CODE", Order = 4)]
        public System.String FIELD_CODE { get; set; }
        #endregion Properties

        #region Constructors
        public DataDictionary(string csvLine) : base(csvLine) {}

        public DataDictionary(string[] values) : base(values) {}

        public DataDictionary(OleDbDataReader reader, CensusFileType fileType)
        {
            if(reader[0] != DBNull.Value)
            {
                SORT_ID = (System.Nullable<System.Int32>)reader[0];
            }
            if(reader[1] != DBNull.Value)
            {
                TABLE = (System.String)reader[1];
            }
            if(reader[2] != DBNull.Value)
            {
                SEGMENT = (System.String)reader[2];
            }
            if(reader[3] != DBNull.Value)
            {
                FIELD_NAME = (System.String)reader[3];
            }
            if(reader[4] != DBNull.Value)
            {
                FIELD_CODE = (System.String)reader[4];
            }
        }
        #endregion Constructors
    }
}