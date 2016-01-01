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

    [Table("Iterations_NOTES")]
    public partial class Iterations_NOTES : BaseModel
    {
        #region Properties
        [ReadOnly(false)]
        [Column("SORT_ID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "SORT ID", ShortName = "SORT ID", Order = 0)]
        public System.Nullable<System.Int32> SORT_ID { get; set; }

        [ReadOnly(false)]
        [Column("NOTE", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "NOTE", ShortName = "NOTE", Order = 1)]
        public System.Nullable<System.Int64> NOTE { get; set; }
        #endregion Properties

        #region Constructors
        public Iterations_NOTES(string csvLine) : base(csvLine) {}

        public Iterations_NOTES(string[] values) : base(values) {}

        public Iterations_NOTES(OleDbDataReader reader, CensusFileType fileType)
        {
            if(reader[0] != DBNull.Value)
            {
                SORT_ID = (System.Nullable<System.Int32>)reader[0];
            }
            if(reader[1] != DBNull.Value)
            {
                NOTE = (System.Nullable<System.Int64>)reader[1];
            }
        }
        #endregion Constructors
    }
}