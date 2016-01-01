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

    [Table("Iterations_List")]
    public partial class Iterations_List : BaseModel
    {
        #region Properties
        [ReadOnly(false)]
        [Column("SORT_ID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "SORT ID", ShortName = "SORT ID", Order = 0)]
        public System.Nullable<System.Int32> SORT_ID { get; set; }

        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("Iteration_Code", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Iteration Code", ShortName = "Iteration Code", Order = 1)]
        public System.String Iteration_Code { get; set; }

        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("Iterations", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Iterations", ShortName = "Iterations", Order = 2)]
        public System.String Iterations { get; set; }
        #endregion Properties

        #region Constructors
        public Iterations_List(string csvLine) : base(csvLine) {}

        public Iterations_List(string[] values) : base(values) {}

        public Iterations_List(OleDbDataReader reader, CensusFileType fileType)
        {
            if(reader[0] != DBNull.Value)
            {
                SORT_ID = (System.Nullable<System.Int32>)reader[0];
            }
            if(reader[1] != DBNull.Value)
            {
                Iteration_Code = (System.String)reader[1];
            }
            if(reader[2] != DBNull.Value)
            {
                Iterations = (System.String)reader[2];
            }
        }
        #endregion Constructors
    }
}