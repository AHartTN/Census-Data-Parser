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

    [Table("Table_Names")]
    public partial class Table_Names : BaseModel
    {
        #region Properties
        [ReadOnly(false)]
        [Column("SORT_ID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "SORT ID", ShortName = "SORT ID", Order = 0)]
        public System.Nullable<System.Int32> SORT_ID { get; set; }

        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("TABLE_CODE", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "TABLE CODE", ShortName = "TABLE CODE", Order = 1)]
        public System.String TABLE_CODE { get; set; }

        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("TABLE_NAME", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "TABLE NAME", ShortName = "TABLE NAME", Order = 2)]
        public System.String TABLE_NAME { get; set; }

        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("CELL_COUNT", Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "CELL COUNT", ShortName = "CELL COUNT", Order = 3)]
        public System.String CELL_COUNT { get; set; }
        #endregion Properties

        #region Constructors
        public Table_Names(string csvLine) : base(csvLine) {}

        public Table_Names(string[] values) : base(values) {}

        public Table_Names(OleDbDataReader reader, CensusFileType fileType)
        {
            if(reader[0] != DBNull.Value)
            {
                SORT_ID = (System.Nullable<System.Int32>)reader[0];
            }
            if(reader[1] != DBNull.Value)
            {
                TABLE_CODE = (System.String)reader[1];
            }
            if(reader[2] != DBNull.Value)
            {
                TABLE_NAME = (System.String)reader[2];
            }
            if(reader[3] != DBNull.Value)
            {
                CELL_COUNT = (System.String)reader[3];
            }
        }
        #endregion Constructors
    }
}