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

    [Table("SF1_00046")]
    public partial class SF1_00046 : BaseModel
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
        [Column("H017D0001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public System.Nullable<System.Int32> H017D0001 { get; set; }

        [ReadOnly(false)]
        [Column("H017D0002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 6)]
        public System.Nullable<System.Int32> H017D0002 { get; set; }

        [ReadOnly(false)]
        [Column("H017D0003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 7)]
        public System.Nullable<System.Int32> H017D0003 { get; set; }

        [ReadOnly(false)]
        [Column("H017D0004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 8)]
        public System.Nullable<System.Int32> H017D0004 { get; set; }

        [ReadOnly(false)]
        [Column("H017D0005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 9)]
        public System.Nullable<System.Int32> H017D0005 { get; set; }

        [ReadOnly(false)]
        [Column("H017D0006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 10)]
        public System.Nullable<System.Int32> H017D0006 { get; set; }

        [ReadOnly(false)]
        [Column("H017D0007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 11)]
        public System.Nullable<System.Int32> H017D0007 { get; set; }

        [ReadOnly(false)]
        [Column("H017D0008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 12)]
        public System.Nullable<System.Int32> H017D0008 { get; set; }

        [ReadOnly(false)]
        [Column("H017D0009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 13)]
        public System.Nullable<System.Int32> H017D0009 { get; set; }

        [ReadOnly(false)]
        [Column("H017D0010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 14)]
        public System.Nullable<System.Int32> H017D0010 { get; set; }

        [ReadOnly(false)]
        [Column("H017D0011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 15)]
        public System.Nullable<System.Int32> H017D0011 { get; set; }

        [ReadOnly(false)]
        [Column("H017D0012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 16)]
        public System.Nullable<System.Int32> H017D0012 { get; set; }

        [ReadOnly(false)]
        [Column("H017D0013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 17)]
        public System.Nullable<System.Int32> H017D0013 { get; set; }

        [ReadOnly(false)]
        [Column("H017D0014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 18)]
        public System.Nullable<System.Int32> H017D0014 { get; set; }

        [ReadOnly(false)]
        [Column("H017D0015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 19)]
        public System.Nullable<System.Int32> H017D0015 { get; set; }

        [ReadOnly(false)]
        [Column("H017D0016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 20)]
        public System.Nullable<System.Int32> H017D0016 { get; set; }

        [ReadOnly(false)]
        [Column("H017D0017", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 21)]
        public System.Nullable<System.Int32> H017D0017 { get; set; }

        [ReadOnly(false)]
        [Column("H017D0018", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 22)]
        public System.Nullable<System.Int32> H017D0018 { get; set; }

        [ReadOnly(false)]
        [Column("H017D0019", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 23)]
        public System.Nullable<System.Int32> H017D0019 { get; set; }

        [ReadOnly(false)]
        [Column("H017D0020", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 24)]
        public System.Nullable<System.Int32> H017D0020 { get; set; }

        [ReadOnly(false)]
        [Column("H017D0021", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 25)]
        public System.Nullable<System.Int32> H017D0021 { get; set; }

        [ReadOnly(false)]
        [Column("H017E0001", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 26)]
        public System.Nullable<System.Int32> H017E0001 { get; set; }

        [ReadOnly(false)]
        [Column("H017E0002", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 27)]
        public System.Nullable<System.Int32> H017E0002 { get; set; }

        [ReadOnly(false)]
        [Column("H017E0003", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 28)]
        public System.Nullable<System.Int32> H017E0003 { get; set; }

        [ReadOnly(false)]
        [Column("H017E0004", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 29)]
        public System.Nullable<System.Int32> H017E0004 { get; set; }

        [ReadOnly(false)]
        [Column("H017E0005", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 30)]
        public System.Nullable<System.Int32> H017E0005 { get; set; }

        [ReadOnly(false)]
        [Column("H017E0006", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 31)]
        public System.Nullable<System.Int32> H017E0006 { get; set; }

        [ReadOnly(false)]
        [Column("H017E0007", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 32)]
        public System.Nullable<System.Int32> H017E0007 { get; set; }

        [ReadOnly(false)]
        [Column("H017E0008", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 33)]
        public System.Nullable<System.Int32> H017E0008 { get; set; }

        [ReadOnly(false)]
        [Column("H017E0009", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 34)]
        public System.Nullable<System.Int32> H017E0009 { get; set; }

        [ReadOnly(false)]
        [Column("H017E0010", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 35)]
        public System.Nullable<System.Int32> H017E0010 { get; set; }

        [ReadOnly(false)]
        [Column("H017E0011", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 36)]
        public System.Nullable<System.Int32> H017E0011 { get; set; }

        [ReadOnly(false)]
        [Column("H017E0012", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 37)]
        public System.Nullable<System.Int32> H017E0012 { get; set; }

        [ReadOnly(false)]
        [Column("H017E0013", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 38)]
        public System.Nullable<System.Int32> H017E0013 { get; set; }

        [ReadOnly(false)]
        [Column("H017E0014", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 39)]
        public System.Nullable<System.Int32> H017E0014 { get; set; }

        [ReadOnly(false)]
        [Column("H017E0015", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 40)]
        public System.Nullable<System.Int32> H017E0015 { get; set; }

        [ReadOnly(false)]
        [Column("H017E0016", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 41)]
        public System.Nullable<System.Int32> H017E0016 { get; set; }

        [ReadOnly(false)]
        [Column("H017E0017", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 42)]
        public System.Nullable<System.Int32> H017E0017 { get; set; }

        [ReadOnly(false)]
        [Column("H017E0018", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 43)]
        public System.Nullable<System.Int32> H017E0018 { get; set; }

        [ReadOnly(false)]
        [Column("H017E0019", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 44)]
        public System.Nullable<System.Int32> H017E0019 { get; set; }

        [ReadOnly(false)]
        [Column("H017E0020", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 45)]
        public System.Nullable<System.Int32> H017E0020 { get; set; }

        [ReadOnly(false)]
        [Column("H017E0021", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 46)]
        public System.Nullable<System.Int32> H017E0021 { get; set; }

        [ReadOnly(false)]
        [Column("H017F0001", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 47)]
        public System.Nullable<System.Int32> H017F0001 { get; set; }

        [ReadOnly(false)]
        [Column("H017F0002", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 48)]
        public System.Nullable<System.Int32> H017F0002 { get; set; }

        [ReadOnly(false)]
        [Column("H017F0003", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 49)]
        public System.Nullable<System.Int32> H017F0003 { get; set; }

        [ReadOnly(false)]
        [Column("H017F0004", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 50)]
        public System.Nullable<System.Int32> H017F0004 { get; set; }

        [ReadOnly(false)]
        [Column("H017F0005", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 51)]
        public System.Nullable<System.Int32> H017F0005 { get; set; }

        [ReadOnly(false)]
        [Column("H017F0006", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 52)]
        public System.Nullable<System.Int32> H017F0006 { get; set; }

        [ReadOnly(false)]
        [Column("H017F0007", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 53)]
        public System.Nullable<System.Int32> H017F0007 { get; set; }

        [ReadOnly(false)]
        [Column("H017F0008", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 54)]
        public System.Nullable<System.Int32> H017F0008 { get; set; }

        [ReadOnly(false)]
        [Column("H017F0009", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 55)]
        public System.Nullable<System.Int32> H017F0009 { get; set; }

        [ReadOnly(false)]
        [Column("H017F0010", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 56)]
        public System.Nullable<System.Int32> H017F0010 { get; set; }

        [ReadOnly(false)]
        [Column("H017F0011", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 57)]
        public System.Nullable<System.Int32> H017F0011 { get; set; }

        [ReadOnly(false)]
        [Column("H017F0012", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 58)]
        public System.Nullable<System.Int32> H017F0012 { get; set; }

        [ReadOnly(false)]
        [Column("H017F0013", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 59)]
        public System.Nullable<System.Int32> H017F0013 { get; set; }

        [ReadOnly(false)]
        [Column("H017F0014", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 60)]
        public System.Nullable<System.Int32> H017F0014 { get; set; }

        [ReadOnly(false)]
        [Column("H017F0015", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 61)]
        public System.Nullable<System.Int32> H017F0015 { get; set; }

        [ReadOnly(false)]
        [Column("H017F0016", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 62)]
        public System.Nullable<System.Int32> H017F0016 { get; set; }

        [ReadOnly(false)]
        [Column("H017F0017", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 63)]
        public System.Nullable<System.Int32> H017F0017 { get; set; }

        [ReadOnly(false)]
        [Column("H017F0018", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 64)]
        public System.Nullable<System.Int32> H017F0018 { get; set; }

        [ReadOnly(false)]
        [Column("H017F0019", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 65)]
        public System.Nullable<System.Int32> H017F0019 { get; set; }

        [ReadOnly(false)]
        [Column("H017F0020", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 66)]
        public System.Nullable<System.Int32> H017F0020 { get; set; }

        [ReadOnly(false)]
        [Column("H017F0021", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 67)]
        public System.Nullable<System.Int32> H017F0021 { get; set; }

        [ReadOnly(false)]
        [Column("H017G0001", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 68)]
        public System.Nullable<System.Int32> H017G0001 { get; set; }

        [ReadOnly(false)]
        [Column("H017G0002", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 69)]
        public System.Nullable<System.Int32> H017G0002 { get; set; }

        [ReadOnly(false)]
        [Column("H017G0003", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 70)]
        public System.Nullable<System.Int32> H017G0003 { get; set; }

        [ReadOnly(false)]
        [Column("H017G0004", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 71)]
        public System.Nullable<System.Int32> H017G0004 { get; set; }

        [ReadOnly(false)]
        [Column("H017G0005", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 72)]
        public System.Nullable<System.Int32> H017G0005 { get; set; }

        [ReadOnly(false)]
        [Column("H017G0006", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 73)]
        public System.Nullable<System.Int32> H017G0006 { get; set; }

        [ReadOnly(false)]
        [Column("H017G0007", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 74)]
        public System.Nullable<System.Int32> H017G0007 { get; set; }

        [ReadOnly(false)]
        [Column("H017G0008", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 75)]
        public System.Nullable<System.Int32> H017G0008 { get; set; }

        [ReadOnly(false)]
        [Column("H017G0009", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 76)]
        public System.Nullable<System.Int32> H017G0009 { get; set; }

        [ReadOnly(false)]
        [Column("H017G0010", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 77)]
        public System.Nullable<System.Int32> H017G0010 { get; set; }

        [ReadOnly(false)]
        [Column("H017G0011", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 78)]
        public System.Nullable<System.Int32> H017G0011 { get; set; }

        [ReadOnly(false)]
        [Column("H017G0012", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 79)]
        public System.Nullable<System.Int32> H017G0012 { get; set; }

        [ReadOnly(false)]
        [Column("H017G0013", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 80)]
        public System.Nullable<System.Int32> H017G0013 { get; set; }

        [ReadOnly(false)]
        [Column("H017G0014", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 81)]
        public System.Nullable<System.Int32> H017G0014 { get; set; }

        [ReadOnly(false)]
        [Column("H017G0015", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 82)]
        public System.Nullable<System.Int32> H017G0015 { get; set; }

        [ReadOnly(false)]
        [Column("H017G0016", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 83)]
        public System.Nullable<System.Int32> H017G0016 { get; set; }

        [ReadOnly(false)]
        [Column("H017G0017", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 84)]
        public System.Nullable<System.Int32> H017G0017 { get; set; }

        [ReadOnly(false)]
        [Column("H017G0018", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 85)]
        public System.Nullable<System.Int32> H017G0018 { get; set; }

        [ReadOnly(false)]
        [Column("H017G0019", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 86)]
        public System.Nullable<System.Int32> H017G0019 { get; set; }

        [ReadOnly(false)]
        [Column("H017G0020", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 87)]
        public System.Nullable<System.Int32> H017G0020 { get; set; }

        [ReadOnly(false)]
        [Column("H017G0021", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 88)]
        public System.Nullable<System.Int32> H017G0021 { get; set; }

        [ReadOnly(false)]
        [Column("H017H0001", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 89)]
        public System.Nullable<System.Int32> H017H0001 { get; set; }

        [ReadOnly(false)]
        [Column("H017H0002", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 90)]
        public System.Nullable<System.Int32> H017H0002 { get; set; }

        [ReadOnly(false)]
        [Column("H017H0003", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 91)]
        public System.Nullable<System.Int32> H017H0003 { get; set; }

        [ReadOnly(false)]
        [Column("H017H0004", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 92)]
        public System.Nullable<System.Int32> H017H0004 { get; set; }

        [ReadOnly(false)]
        [Column("H017H0005", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 93)]
        public System.Nullable<System.Int32> H017H0005 { get; set; }

        [ReadOnly(false)]
        [Column("H017H0006", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 94)]
        public System.Nullable<System.Int32> H017H0006 { get; set; }

        [ReadOnly(false)]
        [Column("H017H0007", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 95)]
        public System.Nullable<System.Int32> H017H0007 { get; set; }

        [ReadOnly(false)]
        [Column("H017H0008", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 96)]
        public System.Nullable<System.Int32> H017H0008 { get; set; }

        [ReadOnly(false)]
        [Column("H017H0009", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 97)]
        public System.Nullable<System.Int32> H017H0009 { get; set; }

        [ReadOnly(false)]
        [Column("H017H0010", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 98)]
        public System.Nullable<System.Int32> H017H0010 { get; set; }

        [ReadOnly(false)]
        [Column("H017H0011", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 99)]
        public System.Nullable<System.Int32> H017H0011 { get; set; }

        [ReadOnly(false)]
        [Column("H017H0012", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 100)]
        public System.Nullable<System.Int32> H017H0012 { get; set; }

        [ReadOnly(false)]
        [Column("H017H0013", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 101)]
        public System.Nullable<System.Int32> H017H0013 { get; set; }

        [ReadOnly(false)]
        [Column("H017H0014", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 102)]
        public System.Nullable<System.Int32> H017H0014 { get; set; }

        [ReadOnly(false)]
        [Column("H017H0015", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 103)]
        public System.Nullable<System.Int32> H017H0015 { get; set; }

        [ReadOnly(false)]
        [Column("H017H0016", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 104)]
        public System.Nullable<System.Int32> H017H0016 { get; set; }

        [ReadOnly(false)]
        [Column("H017H0017", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 105)]
        public System.Nullable<System.Int32> H017H0017 { get; set; }

        [ReadOnly(false)]
        [Column("H017H0018", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 106)]
        public System.Nullable<System.Int32> H017H0018 { get; set; }

        [ReadOnly(false)]
        [Column("H017H0019", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 107)]
        public System.Nullable<System.Int32> H017H0019 { get; set; }

        [ReadOnly(false)]
        [Column("H017H0020", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 108)]
        public System.Nullable<System.Int32> H017H0020 { get; set; }

        [ReadOnly(false)]
        [Column("H017H0021", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 109)]
        public System.Nullable<System.Int32> H017H0021 { get; set; }

        [ReadOnly(false)]
        [Column("H017I0001", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 110)]
        public System.Nullable<System.Int32> H017I0001 { get; set; }

        [ReadOnly(false)]
        [Column("H017I0002", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 111)]
        public System.Nullable<System.Int32> H017I0002 { get; set; }

        [ReadOnly(false)]
        [Column("H017I0003", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 112)]
        public System.Nullable<System.Int32> H017I0003 { get; set; }

        [ReadOnly(false)]
        [Column("H017I0004", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 113)]
        public System.Nullable<System.Int32> H017I0004 { get; set; }

        [ReadOnly(false)]
        [Column("H017I0005", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 114)]
        public System.Nullable<System.Int32> H017I0005 { get; set; }

        [ReadOnly(false)]
        [Column("H017I0006", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 115)]
        public System.Nullable<System.Int32> H017I0006 { get; set; }

        [ReadOnly(false)]
        [Column("H017I0007", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 116)]
        public System.Nullable<System.Int32> H017I0007 { get; set; }

        [ReadOnly(false)]
        [Column("H017I0008", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 117)]
        public System.Nullable<System.Int32> H017I0008 { get; set; }

        [ReadOnly(false)]
        [Column("H017I0009", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 118)]
        public System.Nullable<System.Int32> H017I0009 { get; set; }

        [ReadOnly(false)]
        [Column("H017I0010", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 119)]
        public System.Nullable<System.Int32> H017I0010 { get; set; }

        [ReadOnly(false)]
        [Column("H017I0011", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 120)]
        public System.Nullable<System.Int32> H017I0011 { get; set; }

        [ReadOnly(false)]
        [Column("H017I0012", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 121)]
        public System.Nullable<System.Int32> H017I0012 { get; set; }

        [ReadOnly(false)]
        [Column("H017I0013", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 122)]
        public System.Nullable<System.Int32> H017I0013 { get; set; }

        [ReadOnly(false)]
        [Column("H017I0014", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 123)]
        public System.Nullable<System.Int32> H017I0014 { get; set; }

        [ReadOnly(false)]
        [Column("H017I0015", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 124)]
        public System.Nullable<System.Int32> H017I0015 { get; set; }

        [ReadOnly(false)]
        [Column("H017I0016", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 125)]
        public System.Nullable<System.Int32> H017I0016 { get; set; }

        [ReadOnly(false)]
        [Column("H017I0017", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 126)]
        public System.Nullable<System.Int32> H017I0017 { get; set; }

        [ReadOnly(false)]
        [Column("H017I0018", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 127)]
        public System.Nullable<System.Int32> H017I0018 { get; set; }

        [ReadOnly(false)]
        [Column("H017I0019", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 128)]
        public System.Nullable<System.Int32> H017I0019 { get; set; }

        [ReadOnly(false)]
        [Column("H017I0020", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 129)]
        public System.Nullable<System.Int32> H017I0020 { get; set; }

        [ReadOnly(false)]
        [Column("H017I0021", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 130)]
        public System.Nullable<System.Int32> H017I0021 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1_00046(string csvLine) : base(csvLine) {}

        public SF1_00046(string[] values) : base(values) {}

        public SF1_00046(OleDbDataReader reader, CensusFileType fileType)
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
                H017D0001 = (System.Nullable<System.Int32>)reader[5];
            }
            if(reader[6] != DBNull.Value)
            {
                H017D0002 = (System.Nullable<System.Int32>)reader[6];
            }
            if(reader[7] != DBNull.Value)
            {
                H017D0003 = (System.Nullable<System.Int32>)reader[7];
            }
            if(reader[8] != DBNull.Value)
            {
                H017D0004 = (System.Nullable<System.Int32>)reader[8];
            }
            if(reader[9] != DBNull.Value)
            {
                H017D0005 = (System.Nullable<System.Int32>)reader[9];
            }
            if(reader[10] != DBNull.Value)
            {
                H017D0006 = (System.Nullable<System.Int32>)reader[10];
            }
            if(reader[11] != DBNull.Value)
            {
                H017D0007 = (System.Nullable<System.Int32>)reader[11];
            }
            if(reader[12] != DBNull.Value)
            {
                H017D0008 = (System.Nullable<System.Int32>)reader[12];
            }
            if(reader[13] != DBNull.Value)
            {
                H017D0009 = (System.Nullable<System.Int32>)reader[13];
            }
            if(reader[14] != DBNull.Value)
            {
                H017D0010 = (System.Nullable<System.Int32>)reader[14];
            }
            if(reader[15] != DBNull.Value)
            {
                H017D0011 = (System.Nullable<System.Int32>)reader[15];
            }
            if(reader[16] != DBNull.Value)
            {
                H017D0012 = (System.Nullable<System.Int32>)reader[16];
            }
            if(reader[17] != DBNull.Value)
            {
                H017D0013 = (System.Nullable<System.Int32>)reader[17];
            }
            if(reader[18] != DBNull.Value)
            {
                H017D0014 = (System.Nullable<System.Int32>)reader[18];
            }
            if(reader[19] != DBNull.Value)
            {
                H017D0015 = (System.Nullable<System.Int32>)reader[19];
            }
            if(reader[20] != DBNull.Value)
            {
                H017D0016 = (System.Nullable<System.Int32>)reader[20];
            }
            if(reader[21] != DBNull.Value)
            {
                H017D0017 = (System.Nullable<System.Int32>)reader[21];
            }
            if(reader[22] != DBNull.Value)
            {
                H017D0018 = (System.Nullable<System.Int32>)reader[22];
            }
            if(reader[23] != DBNull.Value)
            {
                H017D0019 = (System.Nullable<System.Int32>)reader[23];
            }
            if(reader[24] != DBNull.Value)
            {
                H017D0020 = (System.Nullable<System.Int32>)reader[24];
            }
            if(reader[25] != DBNull.Value)
            {
                H017D0021 = (System.Nullable<System.Int32>)reader[25];
            }
            if(reader[26] != DBNull.Value)
            {
                H017E0001 = (System.Nullable<System.Int32>)reader[26];
            }
            if(reader[27] != DBNull.Value)
            {
                H017E0002 = (System.Nullable<System.Int32>)reader[27];
            }
            if(reader[28] != DBNull.Value)
            {
                H017E0003 = (System.Nullable<System.Int32>)reader[28];
            }
            if(reader[29] != DBNull.Value)
            {
                H017E0004 = (System.Nullable<System.Int32>)reader[29];
            }
            if(reader[30] != DBNull.Value)
            {
                H017E0005 = (System.Nullable<System.Int32>)reader[30];
            }
            if(reader[31] != DBNull.Value)
            {
                H017E0006 = (System.Nullable<System.Int32>)reader[31];
            }
            if(reader[32] != DBNull.Value)
            {
                H017E0007 = (System.Nullable<System.Int32>)reader[32];
            }
            if(reader[33] != DBNull.Value)
            {
                H017E0008 = (System.Nullable<System.Int32>)reader[33];
            }
            if(reader[34] != DBNull.Value)
            {
                H017E0009 = (System.Nullable<System.Int32>)reader[34];
            }
            if(reader[35] != DBNull.Value)
            {
                H017E0010 = (System.Nullable<System.Int32>)reader[35];
            }
            if(reader[36] != DBNull.Value)
            {
                H017E0011 = (System.Nullable<System.Int32>)reader[36];
            }
            if(reader[37] != DBNull.Value)
            {
                H017E0012 = (System.Nullable<System.Int32>)reader[37];
            }
            if(reader[38] != DBNull.Value)
            {
                H017E0013 = (System.Nullable<System.Int32>)reader[38];
            }
            if(reader[39] != DBNull.Value)
            {
                H017E0014 = (System.Nullable<System.Int32>)reader[39];
            }
            if(reader[40] != DBNull.Value)
            {
                H017E0015 = (System.Nullable<System.Int32>)reader[40];
            }
            if(reader[41] != DBNull.Value)
            {
                H017E0016 = (System.Nullable<System.Int32>)reader[41];
            }
            if(reader[42] != DBNull.Value)
            {
                H017E0017 = (System.Nullable<System.Int32>)reader[42];
            }
            if(reader[43] != DBNull.Value)
            {
                H017E0018 = (System.Nullable<System.Int32>)reader[43];
            }
            if(reader[44] != DBNull.Value)
            {
                H017E0019 = (System.Nullable<System.Int32>)reader[44];
            }
            if(reader[45] != DBNull.Value)
            {
                H017E0020 = (System.Nullable<System.Int32>)reader[45];
            }
            if(reader[46] != DBNull.Value)
            {
                H017E0021 = (System.Nullable<System.Int32>)reader[46];
            }
            if(reader[47] != DBNull.Value)
            {
                H017F0001 = (System.Nullable<System.Int32>)reader[47];
            }
            if(reader[48] != DBNull.Value)
            {
                H017F0002 = (System.Nullable<System.Int32>)reader[48];
            }
            if(reader[49] != DBNull.Value)
            {
                H017F0003 = (System.Nullable<System.Int32>)reader[49];
            }
            if(reader[50] != DBNull.Value)
            {
                H017F0004 = (System.Nullable<System.Int32>)reader[50];
            }
            if(reader[51] != DBNull.Value)
            {
                H017F0005 = (System.Nullable<System.Int32>)reader[51];
            }
            if(reader[52] != DBNull.Value)
            {
                H017F0006 = (System.Nullable<System.Int32>)reader[52];
            }
            if(reader[53] != DBNull.Value)
            {
                H017F0007 = (System.Nullable<System.Int32>)reader[53];
            }
            if(reader[54] != DBNull.Value)
            {
                H017F0008 = (System.Nullable<System.Int32>)reader[54];
            }
            if(reader[55] != DBNull.Value)
            {
                H017F0009 = (System.Nullable<System.Int32>)reader[55];
            }
            if(reader[56] != DBNull.Value)
            {
                H017F0010 = (System.Nullable<System.Int32>)reader[56];
            }
            if(reader[57] != DBNull.Value)
            {
                H017F0011 = (System.Nullable<System.Int32>)reader[57];
            }
            if(reader[58] != DBNull.Value)
            {
                H017F0012 = (System.Nullable<System.Int32>)reader[58];
            }
            if(reader[59] != DBNull.Value)
            {
                H017F0013 = (System.Nullable<System.Int32>)reader[59];
            }
            if(reader[60] != DBNull.Value)
            {
                H017F0014 = (System.Nullable<System.Int32>)reader[60];
            }
            if(reader[61] != DBNull.Value)
            {
                H017F0015 = (System.Nullable<System.Int32>)reader[61];
            }
            if(reader[62] != DBNull.Value)
            {
                H017F0016 = (System.Nullable<System.Int32>)reader[62];
            }
            if(reader[63] != DBNull.Value)
            {
                H017F0017 = (System.Nullable<System.Int32>)reader[63];
            }
            if(reader[64] != DBNull.Value)
            {
                H017F0018 = (System.Nullable<System.Int32>)reader[64];
            }
            if(reader[65] != DBNull.Value)
            {
                H017F0019 = (System.Nullable<System.Int32>)reader[65];
            }
            if(reader[66] != DBNull.Value)
            {
                H017F0020 = (System.Nullable<System.Int32>)reader[66];
            }
            if(reader[67] != DBNull.Value)
            {
                H017F0021 = (System.Nullable<System.Int32>)reader[67];
            }
            if(reader[68] != DBNull.Value)
            {
                H017G0001 = (System.Nullable<System.Int32>)reader[68];
            }
            if(reader[69] != DBNull.Value)
            {
                H017G0002 = (System.Nullable<System.Int32>)reader[69];
            }
            if(reader[70] != DBNull.Value)
            {
                H017G0003 = (System.Nullable<System.Int32>)reader[70];
            }
            if(reader[71] != DBNull.Value)
            {
                H017G0004 = (System.Nullable<System.Int32>)reader[71];
            }
            if(reader[72] != DBNull.Value)
            {
                H017G0005 = (System.Nullable<System.Int32>)reader[72];
            }
            if(reader[73] != DBNull.Value)
            {
                H017G0006 = (System.Nullable<System.Int32>)reader[73];
            }
            if(reader[74] != DBNull.Value)
            {
                H017G0007 = (System.Nullable<System.Int32>)reader[74];
            }
            if(reader[75] != DBNull.Value)
            {
                H017G0008 = (System.Nullable<System.Int32>)reader[75];
            }
            if(reader[76] != DBNull.Value)
            {
                H017G0009 = (System.Nullable<System.Int32>)reader[76];
            }
            if(reader[77] != DBNull.Value)
            {
                H017G0010 = (System.Nullable<System.Int32>)reader[77];
            }
            if(reader[78] != DBNull.Value)
            {
                H017G0011 = (System.Nullable<System.Int32>)reader[78];
            }
            if(reader[79] != DBNull.Value)
            {
                H017G0012 = (System.Nullable<System.Int32>)reader[79];
            }
            if(reader[80] != DBNull.Value)
            {
                H017G0013 = (System.Nullable<System.Int32>)reader[80];
            }
            if(reader[81] != DBNull.Value)
            {
                H017G0014 = (System.Nullable<System.Int32>)reader[81];
            }
            if(reader[82] != DBNull.Value)
            {
                H017G0015 = (System.Nullable<System.Int32>)reader[82];
            }
            if(reader[83] != DBNull.Value)
            {
                H017G0016 = (System.Nullable<System.Int32>)reader[83];
            }
            if(reader[84] != DBNull.Value)
            {
                H017G0017 = (System.Nullable<System.Int32>)reader[84];
            }
            if(reader[85] != DBNull.Value)
            {
                H017G0018 = (System.Nullable<System.Int32>)reader[85];
            }
            if(reader[86] != DBNull.Value)
            {
                H017G0019 = (System.Nullable<System.Int32>)reader[86];
            }
            if(reader[87] != DBNull.Value)
            {
                H017G0020 = (System.Nullable<System.Int32>)reader[87];
            }
            if(reader[88] != DBNull.Value)
            {
                H017G0021 = (System.Nullable<System.Int32>)reader[88];
            }
            if(reader[89] != DBNull.Value)
            {
                H017H0001 = (System.Nullable<System.Int32>)reader[89];
            }
            if(reader[90] != DBNull.Value)
            {
                H017H0002 = (System.Nullable<System.Int32>)reader[90];
            }
            if(reader[91] != DBNull.Value)
            {
                H017H0003 = (System.Nullable<System.Int32>)reader[91];
            }
            if(reader[92] != DBNull.Value)
            {
                H017H0004 = (System.Nullable<System.Int32>)reader[92];
            }
            if(reader[93] != DBNull.Value)
            {
                H017H0005 = (System.Nullable<System.Int32>)reader[93];
            }
            if(reader[94] != DBNull.Value)
            {
                H017H0006 = (System.Nullable<System.Int32>)reader[94];
            }
            if(reader[95] != DBNull.Value)
            {
                H017H0007 = (System.Nullable<System.Int32>)reader[95];
            }
            if(reader[96] != DBNull.Value)
            {
                H017H0008 = (System.Nullable<System.Int32>)reader[96];
            }
            if(reader[97] != DBNull.Value)
            {
                H017H0009 = (System.Nullable<System.Int32>)reader[97];
            }
            if(reader[98] != DBNull.Value)
            {
                H017H0010 = (System.Nullable<System.Int32>)reader[98];
            }
            if(reader[99] != DBNull.Value)
            {
                H017H0011 = (System.Nullable<System.Int32>)reader[99];
            }
            if(reader[100] != DBNull.Value)
            {
                H017H0012 = (System.Nullable<System.Int32>)reader[100];
            }
            if(reader[101] != DBNull.Value)
            {
                H017H0013 = (System.Nullable<System.Int32>)reader[101];
            }
            if(reader[102] != DBNull.Value)
            {
                H017H0014 = (System.Nullable<System.Int32>)reader[102];
            }
            if(reader[103] != DBNull.Value)
            {
                H017H0015 = (System.Nullable<System.Int32>)reader[103];
            }
            if(reader[104] != DBNull.Value)
            {
                H017H0016 = (System.Nullable<System.Int32>)reader[104];
            }
            if(reader[105] != DBNull.Value)
            {
                H017H0017 = (System.Nullable<System.Int32>)reader[105];
            }
            if(reader[106] != DBNull.Value)
            {
                H017H0018 = (System.Nullable<System.Int32>)reader[106];
            }
            if(reader[107] != DBNull.Value)
            {
                H017H0019 = (System.Nullable<System.Int32>)reader[107];
            }
            if(reader[108] != DBNull.Value)
            {
                H017H0020 = (System.Nullable<System.Int32>)reader[108];
            }
            if(reader[109] != DBNull.Value)
            {
                H017H0021 = (System.Nullable<System.Int32>)reader[109];
            }
            if(reader[110] != DBNull.Value)
            {
                H017I0001 = (System.Nullable<System.Int32>)reader[110];
            }
            if(reader[111] != DBNull.Value)
            {
                H017I0002 = (System.Nullable<System.Int32>)reader[111];
            }
            if(reader[112] != DBNull.Value)
            {
                H017I0003 = (System.Nullable<System.Int32>)reader[112];
            }
            if(reader[113] != DBNull.Value)
            {
                H017I0004 = (System.Nullable<System.Int32>)reader[113];
            }
            if(reader[114] != DBNull.Value)
            {
                H017I0005 = (System.Nullable<System.Int32>)reader[114];
            }
            if(reader[115] != DBNull.Value)
            {
                H017I0006 = (System.Nullable<System.Int32>)reader[115];
            }
            if(reader[116] != DBNull.Value)
            {
                H017I0007 = (System.Nullable<System.Int32>)reader[116];
            }
            if(reader[117] != DBNull.Value)
            {
                H017I0008 = (System.Nullable<System.Int32>)reader[117];
            }
            if(reader[118] != DBNull.Value)
            {
                H017I0009 = (System.Nullable<System.Int32>)reader[118];
            }
            if(reader[119] != DBNull.Value)
            {
                H017I0010 = (System.Nullable<System.Int32>)reader[119];
            }
            if(reader[120] != DBNull.Value)
            {
                H017I0011 = (System.Nullable<System.Int32>)reader[120];
            }
            if(reader[121] != DBNull.Value)
            {
                H017I0012 = (System.Nullable<System.Int32>)reader[121];
            }
            if(reader[122] != DBNull.Value)
            {
                H017I0013 = (System.Nullable<System.Int32>)reader[122];
            }
            if(reader[123] != DBNull.Value)
            {
                H017I0014 = (System.Nullable<System.Int32>)reader[123];
            }
            if(reader[124] != DBNull.Value)
            {
                H017I0015 = (System.Nullable<System.Int32>)reader[124];
            }
            if(reader[125] != DBNull.Value)
            {
                H017I0016 = (System.Nullable<System.Int32>)reader[125];
            }
            if(reader[126] != DBNull.Value)
            {
                H017I0017 = (System.Nullable<System.Int32>)reader[126];
            }
            if(reader[127] != DBNull.Value)
            {
                H017I0018 = (System.Nullable<System.Int32>)reader[127];
            }
            if(reader[128] != DBNull.Value)
            {
                H017I0019 = (System.Nullable<System.Int32>)reader[128];
            }
            if(reader[129] != DBNull.Value)
            {
                H017I0020 = (System.Nullable<System.Int32>)reader[129];
            }
            if(reader[130] != DBNull.Value)
            {
                H017I0021 = (System.Nullable<System.Int32>)reader[130];
            }
        }
        #endregion Constructors
    }
}