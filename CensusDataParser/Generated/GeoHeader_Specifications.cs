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

    [Table("GeoHeader_Specifications")]
    public partial class GeoHeader_Specifications : BaseModel
    {
        #region Properties
        [ReadOnly(false)]
        [Column("ID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "ID", ShortName = "ID", Order = 0)]
        public System.Nullable<System.Int32> ID { get; set; }

        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("FIELD", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "FIELD", ShortName = "FIELD", Order = 1)]
        public System.String FIELD { get; set; }

        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("DATA_DICTIONARY_REFERENCE", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "DATA DICTIONARY REFERENCE", ShortName = "DATA DICTIONARY REFERENCE", Order = 2)]
        public System.String DATA_DICTIONARY_REFERENCE { get; set; }

        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("STARTING_POSITION", Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "STARTING POSITION", ShortName = "STARTING POSITION", Order = 3)]
        public System.String STARTING_POSITION { get; set; }

        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("FIELD_SIZE", Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "FIELD SIZE", ShortName = "FIELD SIZE", Order = 4)]
        public System.String FIELD_SIZE { get; set; }

        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("DATA_TYPE", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "DATA TYPE", ShortName = "DATA TYPE", Order = 5)]
        public System.String DATA_TYPE { get; set; }
        #endregion Properties

        #region Constructors
        public GeoHeader_Specifications(string csvLine) : base(csvLine) {}

        public GeoHeader_Specifications(string[] values) : base(values) {}

        public GeoHeader_Specifications(OleDbDataReader reader, CensusFileType fileType)
        {
            if(reader[0] != DBNull.Value)
            {
                ID = (System.Nullable<System.Int32>)reader[0];
            }
            if(reader[1] != DBNull.Value)
            {
                FIELD = (System.String)reader[1];
            }
            if(reader[2] != DBNull.Value)
            {
                DATA_DICTIONARY_REFERENCE = (System.String)reader[2];
            }
            if(reader[3] != DBNull.Value)
            {
                STARTING_POSITION = (System.String)reader[3];
            }
            if(reader[4] != DBNull.Value)
            {
                FIELD_SIZE = (System.String)reader[4];
            }
            if(reader[5] != DBNull.Value)
            {
                DATA_TYPE = (System.String)reader[5];
            }
        }
        #endregion Constructors
    }
}