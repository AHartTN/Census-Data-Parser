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

    [Table("SF2_Segment_02")]
    public partial class SF2_Segment_02 : BaseModel
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

        [ReadOnly(false)]
        [Column("CHARITER", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
        public System.Nullable<System.Int32> CHARITER { get; set; }

        [ReadOnly(false)]
        [Column("CIFSN", Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
        public System.Nullable<System.Int32> CIFSN { get; set; }

        [ReadOnly(false)]
        [Column("LOGRECNO", Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
        public System.Nullable<System.Int32> LOGRECNO { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total tribes tallied (300, A01-Z99) & (300, A01-Z99):", ShortName = "Total tribes tallied (300, A01-Z99) & (300, A01-Z99):", Order = 5)]
        public System.Nullable<System.Int32> PCT0020001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian tribes, specified (A01-M38, T01-Z99) & (300, A01-Z99):", ShortName = "American Indian tribes, specified (A01-M38, T01-Z99) & (300, A01-Z99):", Order = 6)]
        public System.Nullable<System.Int32> PCT0020002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Apache (A09-A23) & (300, A01-Z99)", ShortName = "Apache (A09-A23) & (300, A01-Z99)", Order = 7)]
        public System.Nullable<System.Int32> PCT0020003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Arapaho (A24-A33) & (300, A01-Z99)", ShortName = "Arapaho (A24-A33) & (300, A01-Z99)", Order = 8)]
        public System.Nullable<System.Int32> PCT0020004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Blackfeet (A45-A50) & (300, A01-Z99)", ShortName = "Blackfeet (A45-A50) & (300, A01-Z99)", Order = 9)]
        public System.Nullable<System.Int32> PCT0020005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0020006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Canadian and French American Indian (T01-V23) & (300, A01-Z99)", ShortName = "Canadian and French American Indian (T01-V23) & (300, A01-Z99)", Order = 10)]
        public System.Nullable<System.Int32> PCT0020006 { get; set; }
        #endregion Properties

        #region Constructors
        public SF2_Segment_02(string csvLine) : base(csvLine) {}

        public SF2_Segment_02(string[] values) : base(values) {}

        public SF2_Segment_02(OleDbDataReader reader, CensusFileType fileType)
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
                CHARITER = (System.Nullable<System.Int32>)reader[2];
            }
            if(reader[3] != DBNull.Value)
            {
                CIFSN = (System.Nullable<System.Int32>)reader[3];
            }
            if(reader[4] != DBNull.Value)
            {
                LOGRECNO = (System.Nullable<System.Int32>)reader[4];
            }
            if(reader[5] != DBNull.Value)
            {
                PCT0020001 = (System.Nullable<System.Int32>)reader[5];
            }
            if(reader[6] != DBNull.Value)
            {
                PCT0020002 = (System.Nullable<System.Int32>)reader[6];
            }
            if(reader[7] != DBNull.Value)
            {
                PCT0020003 = (System.Nullable<System.Int32>)reader[7];
            }
            if(reader[8] != DBNull.Value)
            {
                PCT0020004 = (System.Nullable<System.Int32>)reader[8];
            }
            if(reader[9] != DBNull.Value)
            {
                PCT0020005 = (System.Nullable<System.Int32>)reader[9];
            }
            if(reader[10] != DBNull.Value)
            {
                PCT0020006 = (System.Nullable<System.Int32>)reader[10];
            }
        }
        #endregion Constructors
    }
}