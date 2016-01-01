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

    [Table("DataDictionary_NOTES")]
    public partial class DataDictionary_NOTES : BaseModel
    {
        #region Properties
        [ReadOnly(false)]
        [Column("SORT_ID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "SORT ID", ShortName = "SORT ID", Order = 0)]
        public System.Nullable<System.Int32> SORT_ID { get; set; }

        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("Table", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Table", ShortName = "Table", Order = 1)]
        public System.String Table { get; set; }

        [ReadOnly(false)]
        [Column("Field_Name", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Field Name", ShortName = "Field Name", Order = 2)]
        public System.Nullable<System.Int64> Field_Name { get; set; }
        #endregion Properties

        #region Constructors
        public DataDictionary_NOTES(string csvLine) : base(csvLine) {}

        public DataDictionary_NOTES(string[] values) : base(values) {}

        public DataDictionary_NOTES(OleDbDataReader reader, CensusFileType fileType)
        {
            if(reader[0] != DBNull.Value)
            {
                SORT_ID = (System.Nullable<System.Int32>)reader[0];
            }
            if(reader[1] != DBNull.Value)
            {
                Table = (System.String)reader[1];
            }
            if(reader[2] != DBNull.Value)
            {
                Field_Name = (System.Nullable<System.Int64>)reader[2];
            }
        }
        #endregion Constructors
    }
}