namespace CensusDataParser.Generated.CensusDataParser.Generated.SummaryOne
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

    [Table("SF1_00001")]
    public partial class SF1_00001 : BaseModel
    {
        #region Properties
        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("FILEID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
        public System.String FILEID { get; set; }

        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("STUSAB", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public System.String STUSAB { get; set; }

        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("CHARITER", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
        public System.String CHARITER { get; set; }

        [MaxLength(255)]
        [ReadOnly(false)]
        [Column("CIFSN", Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
        public System.String CIFSN { get; set; }

        [ReadOnly(false)]
        [Column("LOGRECNO", Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
        public System.Nullable<System.Int32> LOGRECNO { get; set; }

        [ReadOnly(false)]
        [Column("P0010001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public System.Nullable<System.Int32> P0010001 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1_00001(string csvLine) : base(csvLine) {}

        public SF1_00001(string[] values) : base(values) {}

        public SF1_00001(OleDbDataReader reader, CensusFileType fileType)
        {
            if(reader[0] != DBNull.Value)
            {
                FILEID = (System.String)reader[0];
            }
            if(reader[1] != DBNull.Value)
            {
                STUSAB = (System.String)reader[1];
            }
            if(reader[2] != DBNull.Value)
            {
                CHARITER = (System.String)reader[2];
            }
            if(reader[3] != DBNull.Value)
            {
                CIFSN = (System.String)reader[3];
            }
            if(reader[4] != DBNull.Value)
            {
                LOGRECNO = (System.Nullable<System.Int32>)reader[4];
            }
            if(reader[5] != DBNull.Value)
            {
                P0010001 = (System.Nullable<System.Int32>)reader[5];
            }
        }
        #endregion Constructors
    }
}