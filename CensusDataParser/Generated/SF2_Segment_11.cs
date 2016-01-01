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

    [Table("SF2_Segment_11")]
    public partial class SF2_Segment_11 : BaseModel
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
        [Column("HCT0020001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public System.Nullable<System.Int32> HCT0020001 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 6)]
        public System.Nullable<System.Int32> HCT0020002 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 7)]
        public System.Nullable<System.Int32> HCT0020003 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 8)]
        public System.Nullable<System.Int32> HCT0020004 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030001", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 9)]
        public System.Nullable<System.Int32> HCT0030001 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040001", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 10)]
        public System.Nullable<System.Int32> HCT0040001 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040002", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 11)]
        public System.Nullable<System.Int32> HCT0040002 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040003", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With children under 18 years:", ShortName = "With children under 18 years:", Order = 12)]
        public System.Nullable<System.Int32> HCT0040003 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040004", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 13)]
        public System.Nullable<System.Int32> HCT0040004 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0050001", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total", ShortName = "Total", Order = 14)]
        public System.Nullable<System.Double> HCT0050001 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0050002", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied", ShortName = "Owner occupied", Order = 15)]
        public System.Nullable<System.Double> HCT0050002 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0050003", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 16)]
        public System.Nullable<System.Double> HCT0050003 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0060001", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 17)]
        public System.Nullable<System.Int32> HCT0060001 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0060002", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 18)]
        public System.Nullable<System.Int32> HCT0060002 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0060003", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 19)]
        public System.Nullable<System.Int32> HCT0060003 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0060004", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 20)]
        public System.Nullable<System.Int32> HCT0060004 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0060005", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 21)]
        public System.Nullable<System.Int32> HCT0060005 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0060006", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 22)]
        public System.Nullable<System.Int32> HCT0060006 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0060007", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 23)]
        public System.Nullable<System.Int32> HCT0060007 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0060008", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 24)]
        public System.Nullable<System.Int32> HCT0060008 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0070001", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 25)]
        public System.Nullable<System.Int32> HCT0070001 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0070002", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 26)]
        public System.Nullable<System.Int32> HCT0070002 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0070003", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 27)]
        public System.Nullable<System.Int32> HCT0070003 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0070004", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 28)]
        public System.Nullable<System.Int32> HCT0070004 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0070005", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 29)]
        public System.Nullable<System.Int32> HCT0070005 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0070006", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 30)]
        public System.Nullable<System.Int32> HCT0070006 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0070007", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 31)]
        public System.Nullable<System.Int32> HCT0070007 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0070008", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 32)]
        public System.Nullable<System.Int32> HCT0070008 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0070009", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 33)]
        public System.Nullable<System.Int32> HCT0070009 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0070010", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 34)]
        public System.Nullable<System.Int32> HCT0070010 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0070011", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 35)]
        public System.Nullable<System.Int32> HCT0070011 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0070012", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 36)]
        public System.Nullable<System.Int32> HCT0070012 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0070013", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 37)]
        public System.Nullable<System.Int32> HCT0070013 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0070014", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 38)]
        public System.Nullable<System.Int32> HCT0070014 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0070015", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 39)]
        public System.Nullable<System.Int32> HCT0070015 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0070016", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 40)]
        public System.Nullable<System.Int32> HCT0070016 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0070017", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 41)]
        public System.Nullable<System.Int32> HCT0070017 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0080001", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 42)]
        public System.Nullable<System.Int32> HCT0080001 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0080002", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 43)]
        public System.Nullable<System.Int32> HCT0080002 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0080003", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 44)]
        public System.Nullable<System.Int32> HCT0080003 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0080004", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 45)]
        public System.Nullable<System.Int32> HCT0080004 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0080005", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 46)]
        public System.Nullable<System.Int32> HCT0080005 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0080006", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 47)]
        public System.Nullable<System.Int32> HCT0080006 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0080007", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 48)]
        public System.Nullable<System.Int32> HCT0080007 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0080008", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 49)]
        public System.Nullable<System.Int32> HCT0080008 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0080009", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 50)]
        public System.Nullable<System.Int32> HCT0080009 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0080010", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 51)]
        public System.Nullable<System.Int32> HCT0080010 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0080011", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 52)]
        public System.Nullable<System.Int32> HCT0080011 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0080012", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 53)]
        public System.Nullable<System.Int32> HCT0080012 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0080013", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 54)]
        public System.Nullable<System.Int32> HCT0080013 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0080014", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 55)]
        public System.Nullable<System.Int32> HCT0080014 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0080015", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 56)]
        public System.Nullable<System.Int32> HCT0080015 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0080016", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 57)]
        public System.Nullable<System.Int32> HCT0080016 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0080017", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 58)]
        public System.Nullable<System.Int32> HCT0080017 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0080018", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 59)]
        public System.Nullable<System.Int32> HCT0080018 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0080019", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 60)]
        public System.Nullable<System.Int32> HCT0080019 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0080020", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 61)]
        public System.Nullable<System.Int32> HCT0080020 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0080021", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 62)]
        public System.Nullable<System.Int32> HCT0080021 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090001", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 63)]
        public System.Nullable<System.Int32> HCT0090001 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090002", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 64)]
        public System.Nullable<System.Int32> HCT0090002 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090003", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 65)]
        public System.Nullable<System.Int32> HCT0090003 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090004", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 66)]
        public System.Nullable<System.Int32> HCT0090004 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090005", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 67)]
        public System.Nullable<System.Int32> HCT0090005 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090006", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 68)]
        public System.Nullable<System.Int32> HCT0090006 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090007", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 69)]
        public System.Nullable<System.Int32> HCT0090007 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090008", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 70)]
        public System.Nullable<System.Int32> HCT0090008 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090009", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 71)]
        public System.Nullable<System.Int32> HCT0090009 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090010", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 72)]
        public System.Nullable<System.Int32> HCT0090010 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090011", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 73)]
        public System.Nullable<System.Int32> HCT0090011 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090012", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 74)]
        public System.Nullable<System.Int32> HCT0090012 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090013", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 75)]
        public System.Nullable<System.Int32> HCT0090013 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090014", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 76)]
        public System.Nullable<System.Int32> HCT0090014 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090015", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 77)]
        public System.Nullable<System.Int32> HCT0090015 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090016", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 78)]
        public System.Nullable<System.Int32> HCT0090016 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090017", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 79)]
        public System.Nullable<System.Int32> HCT0090017 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090018", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 80)]
        public System.Nullable<System.Int32> HCT0090018 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090019", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone:", ShortName = "Living alone:", Order = 81)]
        public System.Nullable<System.Int32> HCT0090019 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090020", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 82)]
        public System.Nullable<System.Int32> HCT0090020 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090021", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 83)]
        public System.Nullable<System.Int32> HCT0090021 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090022", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 84)]
        public System.Nullable<System.Int32> HCT0090022 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090023", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 85)]
        public System.Nullable<System.Int32> HCT0090023 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090024", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 86)]
        public System.Nullable<System.Int32> HCT0090024 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090025", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 87)]
        public System.Nullable<System.Int32> HCT0090025 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090026", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 88)]
        public System.Nullable<System.Int32> HCT0090026 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090027", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 89)]
        public System.Nullable<System.Int32> HCT0090027 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090028", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone:", ShortName = "Living alone:", Order = 90)]
        public System.Nullable<System.Int32> HCT0090028 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090029", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 91)]
        public System.Nullable<System.Int32> HCT0090029 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090030", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 92)]
        public System.Nullable<System.Int32> HCT0090030 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090031", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 93)]
        public System.Nullable<System.Int32> HCT0090031 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090032", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 94)]
        public System.Nullable<System.Int32> HCT0090032 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090033", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 95)]
        public System.Nullable<System.Int32> HCT0090033 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090034", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 96)]
        public System.Nullable<System.Int32> HCT0090034 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090035", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 97)]
        public System.Nullable<System.Int32> HCT0090035 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090036", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 98)]
        public System.Nullable<System.Int32> HCT0090036 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090037", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 99)]
        public System.Nullable<System.Int32> HCT0090037 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090038", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 100)]
        public System.Nullable<System.Int32> HCT0090038 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090039", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 101)]
        public System.Nullable<System.Int32> HCT0090039 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090040", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 102)]
        public System.Nullable<System.Int32> HCT0090040 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090041", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 103)]
        public System.Nullable<System.Int32> HCT0090041 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090042", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 104)]
        public System.Nullable<System.Int32> HCT0090042 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090043", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 105)]
        public System.Nullable<System.Int32> HCT0090043 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090044", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 106)]
        public System.Nullable<System.Int32> HCT0090044 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090045", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 107)]
        public System.Nullable<System.Int32> HCT0090045 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090046", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 108)]
        public System.Nullable<System.Int32> HCT0090046 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090047", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 109)]
        public System.Nullable<System.Int32> HCT0090047 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090048", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 110)]
        public System.Nullable<System.Int32> HCT0090048 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090049", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 111)]
        public System.Nullable<System.Int32> HCT0090049 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090050", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 112)]
        public System.Nullable<System.Int32> HCT0090050 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090051", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 113)]
        public System.Nullable<System.Int32> HCT0090051 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090052", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 114)]
        public System.Nullable<System.Int32> HCT0090052 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090053", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone:", ShortName = "Living alone:", Order = 115)]
        public System.Nullable<System.Int32> HCT0090053 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090054", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 116)]
        public System.Nullable<System.Int32> HCT0090054 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090055", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 117)]
        public System.Nullable<System.Int32> HCT0090055 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090056", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 118)]
        public System.Nullable<System.Int32> HCT0090056 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090057", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 119)]
        public System.Nullable<System.Int32> HCT0090057 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090058", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 120)]
        public System.Nullable<System.Int32> HCT0090058 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090059", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 121)]
        public System.Nullable<System.Int32> HCT0090059 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090060", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 122)]
        public System.Nullable<System.Int32> HCT0090060 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090061", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 123)]
        public System.Nullable<System.Int32> HCT0090061 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090062", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone:", ShortName = "Living alone:", Order = 124)]
        public System.Nullable<System.Int32> HCT0090062 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090063", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 125)]
        public System.Nullable<System.Int32> HCT0090063 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090064", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 126)]
        public System.Nullable<System.Int32> HCT0090064 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090065", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 127)]
        public System.Nullable<System.Int32> HCT0090065 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090066", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 128)]
        public System.Nullable<System.Int32> HCT0090066 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090067", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 129)]
        public System.Nullable<System.Int32> HCT0090067 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090068", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 130)]
        public System.Nullable<System.Int32> HCT0090068 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0090069", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 131)]
        public System.Nullable<System.Int32> HCT0090069 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0100001", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 132)]
        public System.Nullable<System.Int32> HCT0100001 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0100002", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 133)]
        public System.Nullable<System.Int32> HCT0100002 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0100003", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 134)]
        public System.Nullable<System.Int32> HCT0100003 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0100004", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 135)]
        public System.Nullable<System.Int32> HCT0100004 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0100005", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 136)]
        public System.Nullable<System.Int32> HCT0100005 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0100006", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 137)]
        public System.Nullable<System.Int32> HCT0100006 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0100007", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 138)]
        public System.Nullable<System.Int32> HCT0100007 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0100008", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter-occupied:", ShortName = "Renter-occupied:", Order = 139)]
        public System.Nullable<System.Int32> HCT0100008 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0100009", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 140)]
        public System.Nullable<System.Int32> HCT0100009 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0100010", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 141)]
        public System.Nullable<System.Int32> HCT0100010 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0100011", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 142)]
        public System.Nullable<System.Int32> HCT0100011 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0100012", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 143)]
        public System.Nullable<System.Int32> HCT0100012 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0100013", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 144)]
        public System.Nullable<System.Int32> HCT0100013 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0110001", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 145)]
        public System.Nullable<System.Int32> HCT0110001 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0110002", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 146)]
        public System.Nullable<System.Int32> HCT0110002 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0110003", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 147)]
        public System.Nullable<System.Int32> HCT0110003 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0110004", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 148)]
        public System.Nullable<System.Int32> HCT0110004 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0110005", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 149)]
        public System.Nullable<System.Int32> HCT0110005 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0110006", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 150)]
        public System.Nullable<System.Int32> HCT0110006 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0110007", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 151)]
        public System.Nullable<System.Int32> HCT0110007 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0110008", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter-occupied:", ShortName = "Renter-occupied:", Order = 152)]
        public System.Nullable<System.Int32> HCT0110008 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0110009", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 153)]
        public System.Nullable<System.Int32> HCT0110009 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0110010", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 154)]
        public System.Nullable<System.Int32> HCT0110010 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0110011", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 155)]
        public System.Nullable<System.Int32> HCT0110011 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0110012", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 156)]
        public System.Nullable<System.Int32> HCT0110012 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0110013", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 157)]
        public System.Nullable<System.Int32> HCT0110013 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0120001", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 158)]
        public System.Nullable<System.Int32> HCT0120001 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0120002", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 159)]
        public System.Nullable<System.Int32> HCT0120002 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0120003", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With children under 18 years:", ShortName = "With children under 18 years:", Order = 160)]
        public System.Nullable<System.Int32> HCT0120003 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0120004", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 161)]
        public System.Nullable<System.Int32> HCT0120004 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0120005", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 162)]
        public System.Nullable<System.Int32> HCT0120005 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0120006", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 163)]
        public System.Nullable<System.Int32> HCT0120006 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0120007", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No children under 18 years", ShortName = "No children under 18 years", Order = 164)]
        public System.Nullable<System.Int32> HCT0120007 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0120008", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter-occupied:", ShortName = "Renter-occupied:", Order = 165)]
        public System.Nullable<System.Int32> HCT0120008 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0120009", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With children under 18 years:", ShortName = "With children under 18 years:", Order = 166)]
        public System.Nullable<System.Int32> HCT0120009 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0120010", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 167)]
        public System.Nullable<System.Int32> HCT0120010 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0120011", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 168)]
        public System.Nullable<System.Int32> HCT0120011 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0120012", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 169)]
        public System.Nullable<System.Int32> HCT0120012 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0120013", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No children under 18 years", ShortName = "No children under 18 years", Order = 170)]
        public System.Nullable<System.Int32> HCT0120013 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0130001", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 171)]
        public System.Nullable<System.Int32> HCT0130001 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0130002", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Substituted", ShortName = "Substituted", Order = 172)]
        public System.Nullable<System.Int32> HCT0130002 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0130003", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not substituted", ShortName = "Not substituted", Order = 173)]
        public System.Nullable<System.Int32> HCT0130003 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0140001", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 174)]
        public System.Nullable<System.Int32> HCT0140001 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0140002", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Allocated", ShortName = "Allocated", Order = 175)]
        public System.Nullable<System.Int32> HCT0140002 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0140003", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not allocated", ShortName = "Not allocated", Order = 176)]
        public System.Nullable<System.Int32> HCT0140003 { get; set; }
        #endregion Properties

        #region Constructors
        public SF2_Segment_11(string csvLine) : base(csvLine) {}

        public SF2_Segment_11(string[] values) : base(values) {}

        public SF2_Segment_11(OleDbDataReader reader, CensusFileType fileType)
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
                HCT0020001 = (System.Nullable<System.Int32>)reader[5];
            }
            if(reader[6] != DBNull.Value)
            {
                HCT0020002 = (System.Nullable<System.Int32>)reader[6];
            }
            if(reader[7] != DBNull.Value)
            {
                HCT0020003 = (System.Nullable<System.Int32>)reader[7];
            }
            if(reader[8] != DBNull.Value)
            {
                HCT0020004 = (System.Nullable<System.Int32>)reader[8];
            }
            if(reader[9] != DBNull.Value)
            {
                HCT0030001 = (System.Nullable<System.Int32>)reader[9];
            }
            if(reader[10] != DBNull.Value)
            {
                HCT0040001 = (System.Nullable<System.Int32>)reader[10];
            }
            if(reader[11] != DBNull.Value)
            {
                HCT0040002 = (System.Nullable<System.Int32>)reader[11];
            }
            if(reader[12] != DBNull.Value)
            {
                HCT0040003 = (System.Nullable<System.Int32>)reader[12];
            }
            if(reader[13] != DBNull.Value)
            {
                HCT0040004 = (System.Nullable<System.Int32>)reader[13];
            }
            if(reader[14] != DBNull.Value)
            {
                HCT0050001 = (System.Nullable<System.Double>)reader[14];
            }
            if(reader[15] != DBNull.Value)
            {
                HCT0050002 = (System.Nullable<System.Double>)reader[15];
            }
            if(reader[16] != DBNull.Value)
            {
                HCT0050003 = (System.Nullable<System.Double>)reader[16];
            }
            if(reader[17] != DBNull.Value)
            {
                HCT0060001 = (System.Nullable<System.Int32>)reader[17];
            }
            if(reader[18] != DBNull.Value)
            {
                HCT0060002 = (System.Nullable<System.Int32>)reader[18];
            }
            if(reader[19] != DBNull.Value)
            {
                HCT0060003 = (System.Nullable<System.Int32>)reader[19];
            }
            if(reader[20] != DBNull.Value)
            {
                HCT0060004 = (System.Nullable<System.Int32>)reader[20];
            }
            if(reader[21] != DBNull.Value)
            {
                HCT0060005 = (System.Nullable<System.Int32>)reader[21];
            }
            if(reader[22] != DBNull.Value)
            {
                HCT0060006 = (System.Nullable<System.Int32>)reader[22];
            }
            if(reader[23] != DBNull.Value)
            {
                HCT0060007 = (System.Nullable<System.Int32>)reader[23];
            }
            if(reader[24] != DBNull.Value)
            {
                HCT0060008 = (System.Nullable<System.Int32>)reader[24];
            }
            if(reader[25] != DBNull.Value)
            {
                HCT0070001 = (System.Nullable<System.Int32>)reader[25];
            }
            if(reader[26] != DBNull.Value)
            {
                HCT0070002 = (System.Nullable<System.Int32>)reader[26];
            }
            if(reader[27] != DBNull.Value)
            {
                HCT0070003 = (System.Nullable<System.Int32>)reader[27];
            }
            if(reader[28] != DBNull.Value)
            {
                HCT0070004 = (System.Nullable<System.Int32>)reader[28];
            }
            if(reader[29] != DBNull.Value)
            {
                HCT0070005 = (System.Nullable<System.Int32>)reader[29];
            }
            if(reader[30] != DBNull.Value)
            {
                HCT0070006 = (System.Nullable<System.Int32>)reader[30];
            }
            if(reader[31] != DBNull.Value)
            {
                HCT0070007 = (System.Nullable<System.Int32>)reader[31];
            }
            if(reader[32] != DBNull.Value)
            {
                HCT0070008 = (System.Nullable<System.Int32>)reader[32];
            }
            if(reader[33] != DBNull.Value)
            {
                HCT0070009 = (System.Nullable<System.Int32>)reader[33];
            }
            if(reader[34] != DBNull.Value)
            {
                HCT0070010 = (System.Nullable<System.Int32>)reader[34];
            }
            if(reader[35] != DBNull.Value)
            {
                HCT0070011 = (System.Nullable<System.Int32>)reader[35];
            }
            if(reader[36] != DBNull.Value)
            {
                HCT0070012 = (System.Nullable<System.Int32>)reader[36];
            }
            if(reader[37] != DBNull.Value)
            {
                HCT0070013 = (System.Nullable<System.Int32>)reader[37];
            }
            if(reader[38] != DBNull.Value)
            {
                HCT0070014 = (System.Nullable<System.Int32>)reader[38];
            }
            if(reader[39] != DBNull.Value)
            {
                HCT0070015 = (System.Nullable<System.Int32>)reader[39];
            }
            if(reader[40] != DBNull.Value)
            {
                HCT0070016 = (System.Nullable<System.Int32>)reader[40];
            }
            if(reader[41] != DBNull.Value)
            {
                HCT0070017 = (System.Nullable<System.Int32>)reader[41];
            }
            if(reader[42] != DBNull.Value)
            {
                HCT0080001 = (System.Nullable<System.Int32>)reader[42];
            }
            if(reader[43] != DBNull.Value)
            {
                HCT0080002 = (System.Nullable<System.Int32>)reader[43];
            }
            if(reader[44] != DBNull.Value)
            {
                HCT0080003 = (System.Nullable<System.Int32>)reader[44];
            }
            if(reader[45] != DBNull.Value)
            {
                HCT0080004 = (System.Nullable<System.Int32>)reader[45];
            }
            if(reader[46] != DBNull.Value)
            {
                HCT0080005 = (System.Nullable<System.Int32>)reader[46];
            }
            if(reader[47] != DBNull.Value)
            {
                HCT0080006 = (System.Nullable<System.Int32>)reader[47];
            }
            if(reader[48] != DBNull.Value)
            {
                HCT0080007 = (System.Nullable<System.Int32>)reader[48];
            }
            if(reader[49] != DBNull.Value)
            {
                HCT0080008 = (System.Nullable<System.Int32>)reader[49];
            }
            if(reader[50] != DBNull.Value)
            {
                HCT0080009 = (System.Nullable<System.Int32>)reader[50];
            }
            if(reader[51] != DBNull.Value)
            {
                HCT0080010 = (System.Nullable<System.Int32>)reader[51];
            }
            if(reader[52] != DBNull.Value)
            {
                HCT0080011 = (System.Nullable<System.Int32>)reader[52];
            }
            if(reader[53] != DBNull.Value)
            {
                HCT0080012 = (System.Nullable<System.Int32>)reader[53];
            }
            if(reader[54] != DBNull.Value)
            {
                HCT0080013 = (System.Nullable<System.Int32>)reader[54];
            }
            if(reader[55] != DBNull.Value)
            {
                HCT0080014 = (System.Nullable<System.Int32>)reader[55];
            }
            if(reader[56] != DBNull.Value)
            {
                HCT0080015 = (System.Nullable<System.Int32>)reader[56];
            }
            if(reader[57] != DBNull.Value)
            {
                HCT0080016 = (System.Nullable<System.Int32>)reader[57];
            }
            if(reader[58] != DBNull.Value)
            {
                HCT0080017 = (System.Nullable<System.Int32>)reader[58];
            }
            if(reader[59] != DBNull.Value)
            {
                HCT0080018 = (System.Nullable<System.Int32>)reader[59];
            }
            if(reader[60] != DBNull.Value)
            {
                HCT0080019 = (System.Nullable<System.Int32>)reader[60];
            }
            if(reader[61] != DBNull.Value)
            {
                HCT0080020 = (System.Nullable<System.Int32>)reader[61];
            }
            if(reader[62] != DBNull.Value)
            {
                HCT0080021 = (System.Nullable<System.Int32>)reader[62];
            }
            if(reader[63] != DBNull.Value)
            {
                HCT0090001 = (System.Nullable<System.Int32>)reader[63];
            }
            if(reader[64] != DBNull.Value)
            {
                HCT0090002 = (System.Nullable<System.Int32>)reader[64];
            }
            if(reader[65] != DBNull.Value)
            {
                HCT0090003 = (System.Nullable<System.Int32>)reader[65];
            }
            if(reader[66] != DBNull.Value)
            {
                HCT0090004 = (System.Nullable<System.Int32>)reader[66];
            }
            if(reader[67] != DBNull.Value)
            {
                HCT0090005 = (System.Nullable<System.Int32>)reader[67];
            }
            if(reader[68] != DBNull.Value)
            {
                HCT0090006 = (System.Nullable<System.Int32>)reader[68];
            }
            if(reader[69] != DBNull.Value)
            {
                HCT0090007 = (System.Nullable<System.Int32>)reader[69];
            }
            if(reader[70] != DBNull.Value)
            {
                HCT0090008 = (System.Nullable<System.Int32>)reader[70];
            }
            if(reader[71] != DBNull.Value)
            {
                HCT0090009 = (System.Nullable<System.Int32>)reader[71];
            }
            if(reader[72] != DBNull.Value)
            {
                HCT0090010 = (System.Nullable<System.Int32>)reader[72];
            }
            if(reader[73] != DBNull.Value)
            {
                HCT0090011 = (System.Nullable<System.Int32>)reader[73];
            }
            if(reader[74] != DBNull.Value)
            {
                HCT0090012 = (System.Nullable<System.Int32>)reader[74];
            }
            if(reader[75] != DBNull.Value)
            {
                HCT0090013 = (System.Nullable<System.Int32>)reader[75];
            }
            if(reader[76] != DBNull.Value)
            {
                HCT0090014 = (System.Nullable<System.Int32>)reader[76];
            }
            if(reader[77] != DBNull.Value)
            {
                HCT0090015 = (System.Nullable<System.Int32>)reader[77];
            }
            if(reader[78] != DBNull.Value)
            {
                HCT0090016 = (System.Nullable<System.Int32>)reader[78];
            }
            if(reader[79] != DBNull.Value)
            {
                HCT0090017 = (System.Nullable<System.Int32>)reader[79];
            }
            if(reader[80] != DBNull.Value)
            {
                HCT0090018 = (System.Nullable<System.Int32>)reader[80];
            }
            if(reader[81] != DBNull.Value)
            {
                HCT0090019 = (System.Nullable<System.Int32>)reader[81];
            }
            if(reader[82] != DBNull.Value)
            {
                HCT0090020 = (System.Nullable<System.Int32>)reader[82];
            }
            if(reader[83] != DBNull.Value)
            {
                HCT0090021 = (System.Nullable<System.Int32>)reader[83];
            }
            if(reader[84] != DBNull.Value)
            {
                HCT0090022 = (System.Nullable<System.Int32>)reader[84];
            }
            if(reader[85] != DBNull.Value)
            {
                HCT0090023 = (System.Nullable<System.Int32>)reader[85];
            }
            if(reader[86] != DBNull.Value)
            {
                HCT0090024 = (System.Nullable<System.Int32>)reader[86];
            }
            if(reader[87] != DBNull.Value)
            {
                HCT0090025 = (System.Nullable<System.Int32>)reader[87];
            }
            if(reader[88] != DBNull.Value)
            {
                HCT0090026 = (System.Nullable<System.Int32>)reader[88];
            }
            if(reader[89] != DBNull.Value)
            {
                HCT0090027 = (System.Nullable<System.Int32>)reader[89];
            }
            if(reader[90] != DBNull.Value)
            {
                HCT0090028 = (System.Nullable<System.Int32>)reader[90];
            }
            if(reader[91] != DBNull.Value)
            {
                HCT0090029 = (System.Nullable<System.Int32>)reader[91];
            }
            if(reader[92] != DBNull.Value)
            {
                HCT0090030 = (System.Nullable<System.Int32>)reader[92];
            }
            if(reader[93] != DBNull.Value)
            {
                HCT0090031 = (System.Nullable<System.Int32>)reader[93];
            }
            if(reader[94] != DBNull.Value)
            {
                HCT0090032 = (System.Nullable<System.Int32>)reader[94];
            }
            if(reader[95] != DBNull.Value)
            {
                HCT0090033 = (System.Nullable<System.Int32>)reader[95];
            }
            if(reader[96] != DBNull.Value)
            {
                HCT0090034 = (System.Nullable<System.Int32>)reader[96];
            }
            if(reader[97] != DBNull.Value)
            {
                HCT0090035 = (System.Nullable<System.Int32>)reader[97];
            }
            if(reader[98] != DBNull.Value)
            {
                HCT0090036 = (System.Nullable<System.Int32>)reader[98];
            }
            if(reader[99] != DBNull.Value)
            {
                HCT0090037 = (System.Nullable<System.Int32>)reader[99];
            }
            if(reader[100] != DBNull.Value)
            {
                HCT0090038 = (System.Nullable<System.Int32>)reader[100];
            }
            if(reader[101] != DBNull.Value)
            {
                HCT0090039 = (System.Nullable<System.Int32>)reader[101];
            }
            if(reader[102] != DBNull.Value)
            {
                HCT0090040 = (System.Nullable<System.Int32>)reader[102];
            }
            if(reader[103] != DBNull.Value)
            {
                HCT0090041 = (System.Nullable<System.Int32>)reader[103];
            }
            if(reader[104] != DBNull.Value)
            {
                HCT0090042 = (System.Nullable<System.Int32>)reader[104];
            }
            if(reader[105] != DBNull.Value)
            {
                HCT0090043 = (System.Nullable<System.Int32>)reader[105];
            }
            if(reader[106] != DBNull.Value)
            {
                HCT0090044 = (System.Nullable<System.Int32>)reader[106];
            }
            if(reader[107] != DBNull.Value)
            {
                HCT0090045 = (System.Nullable<System.Int32>)reader[107];
            }
            if(reader[108] != DBNull.Value)
            {
                HCT0090046 = (System.Nullable<System.Int32>)reader[108];
            }
            if(reader[109] != DBNull.Value)
            {
                HCT0090047 = (System.Nullable<System.Int32>)reader[109];
            }
            if(reader[110] != DBNull.Value)
            {
                HCT0090048 = (System.Nullable<System.Int32>)reader[110];
            }
            if(reader[111] != DBNull.Value)
            {
                HCT0090049 = (System.Nullable<System.Int32>)reader[111];
            }
            if(reader[112] != DBNull.Value)
            {
                HCT0090050 = (System.Nullable<System.Int32>)reader[112];
            }
            if(reader[113] != DBNull.Value)
            {
                HCT0090051 = (System.Nullable<System.Int32>)reader[113];
            }
            if(reader[114] != DBNull.Value)
            {
                HCT0090052 = (System.Nullable<System.Int32>)reader[114];
            }
            if(reader[115] != DBNull.Value)
            {
                HCT0090053 = (System.Nullable<System.Int32>)reader[115];
            }
            if(reader[116] != DBNull.Value)
            {
                HCT0090054 = (System.Nullable<System.Int32>)reader[116];
            }
            if(reader[117] != DBNull.Value)
            {
                HCT0090055 = (System.Nullable<System.Int32>)reader[117];
            }
            if(reader[118] != DBNull.Value)
            {
                HCT0090056 = (System.Nullable<System.Int32>)reader[118];
            }
            if(reader[119] != DBNull.Value)
            {
                HCT0090057 = (System.Nullable<System.Int32>)reader[119];
            }
            if(reader[120] != DBNull.Value)
            {
                HCT0090058 = (System.Nullable<System.Int32>)reader[120];
            }
            if(reader[121] != DBNull.Value)
            {
                HCT0090059 = (System.Nullable<System.Int32>)reader[121];
            }
            if(reader[122] != DBNull.Value)
            {
                HCT0090060 = (System.Nullable<System.Int32>)reader[122];
            }
            if(reader[123] != DBNull.Value)
            {
                HCT0090061 = (System.Nullable<System.Int32>)reader[123];
            }
            if(reader[124] != DBNull.Value)
            {
                HCT0090062 = (System.Nullable<System.Int32>)reader[124];
            }
            if(reader[125] != DBNull.Value)
            {
                HCT0090063 = (System.Nullable<System.Int32>)reader[125];
            }
            if(reader[126] != DBNull.Value)
            {
                HCT0090064 = (System.Nullable<System.Int32>)reader[126];
            }
            if(reader[127] != DBNull.Value)
            {
                HCT0090065 = (System.Nullable<System.Int32>)reader[127];
            }
            if(reader[128] != DBNull.Value)
            {
                HCT0090066 = (System.Nullable<System.Int32>)reader[128];
            }
            if(reader[129] != DBNull.Value)
            {
                HCT0090067 = (System.Nullable<System.Int32>)reader[129];
            }
            if(reader[130] != DBNull.Value)
            {
                HCT0090068 = (System.Nullable<System.Int32>)reader[130];
            }
            if(reader[131] != DBNull.Value)
            {
                HCT0090069 = (System.Nullable<System.Int32>)reader[131];
            }
            if(reader[132] != DBNull.Value)
            {
                HCT0100001 = (System.Nullable<System.Int32>)reader[132];
            }
            if(reader[133] != DBNull.Value)
            {
                HCT0100002 = (System.Nullable<System.Int32>)reader[133];
            }
            if(reader[134] != DBNull.Value)
            {
                HCT0100003 = (System.Nullable<System.Int32>)reader[134];
            }
            if(reader[135] != DBNull.Value)
            {
                HCT0100004 = (System.Nullable<System.Int32>)reader[135];
            }
            if(reader[136] != DBNull.Value)
            {
                HCT0100005 = (System.Nullable<System.Int32>)reader[136];
            }
            if(reader[137] != DBNull.Value)
            {
                HCT0100006 = (System.Nullable<System.Int32>)reader[137];
            }
            if(reader[138] != DBNull.Value)
            {
                HCT0100007 = (System.Nullable<System.Int32>)reader[138];
            }
            if(reader[139] != DBNull.Value)
            {
                HCT0100008 = (System.Nullable<System.Int32>)reader[139];
            }
            if(reader[140] != DBNull.Value)
            {
                HCT0100009 = (System.Nullable<System.Int32>)reader[140];
            }
            if(reader[141] != DBNull.Value)
            {
                HCT0100010 = (System.Nullable<System.Int32>)reader[141];
            }
            if(reader[142] != DBNull.Value)
            {
                HCT0100011 = (System.Nullable<System.Int32>)reader[142];
            }
            if(reader[143] != DBNull.Value)
            {
                HCT0100012 = (System.Nullable<System.Int32>)reader[143];
            }
            if(reader[144] != DBNull.Value)
            {
                HCT0100013 = (System.Nullable<System.Int32>)reader[144];
            }
            if(reader[145] != DBNull.Value)
            {
                HCT0110001 = (System.Nullable<System.Int32>)reader[145];
            }
            if(reader[146] != DBNull.Value)
            {
                HCT0110002 = (System.Nullable<System.Int32>)reader[146];
            }
            if(reader[147] != DBNull.Value)
            {
                HCT0110003 = (System.Nullable<System.Int32>)reader[147];
            }
            if(reader[148] != DBNull.Value)
            {
                HCT0110004 = (System.Nullable<System.Int32>)reader[148];
            }
            if(reader[149] != DBNull.Value)
            {
                HCT0110005 = (System.Nullable<System.Int32>)reader[149];
            }
            if(reader[150] != DBNull.Value)
            {
                HCT0110006 = (System.Nullable<System.Int32>)reader[150];
            }
            if(reader[151] != DBNull.Value)
            {
                HCT0110007 = (System.Nullable<System.Int32>)reader[151];
            }
            if(reader[152] != DBNull.Value)
            {
                HCT0110008 = (System.Nullable<System.Int32>)reader[152];
            }
            if(reader[153] != DBNull.Value)
            {
                HCT0110009 = (System.Nullable<System.Int32>)reader[153];
            }
            if(reader[154] != DBNull.Value)
            {
                HCT0110010 = (System.Nullable<System.Int32>)reader[154];
            }
            if(reader[155] != DBNull.Value)
            {
                HCT0110011 = (System.Nullable<System.Int32>)reader[155];
            }
            if(reader[156] != DBNull.Value)
            {
                HCT0110012 = (System.Nullable<System.Int32>)reader[156];
            }
            if(reader[157] != DBNull.Value)
            {
                HCT0110013 = (System.Nullable<System.Int32>)reader[157];
            }
            if(reader[158] != DBNull.Value)
            {
                HCT0120001 = (System.Nullable<System.Int32>)reader[158];
            }
            if(reader[159] != DBNull.Value)
            {
                HCT0120002 = (System.Nullable<System.Int32>)reader[159];
            }
            if(reader[160] != DBNull.Value)
            {
                HCT0120003 = (System.Nullable<System.Int32>)reader[160];
            }
            if(reader[161] != DBNull.Value)
            {
                HCT0120004 = (System.Nullable<System.Int32>)reader[161];
            }
            if(reader[162] != DBNull.Value)
            {
                HCT0120005 = (System.Nullable<System.Int32>)reader[162];
            }
            if(reader[163] != DBNull.Value)
            {
                HCT0120006 = (System.Nullable<System.Int32>)reader[163];
            }
            if(reader[164] != DBNull.Value)
            {
                HCT0120007 = (System.Nullable<System.Int32>)reader[164];
            }
            if(reader[165] != DBNull.Value)
            {
                HCT0120008 = (System.Nullable<System.Int32>)reader[165];
            }
            if(reader[166] != DBNull.Value)
            {
                HCT0120009 = (System.Nullable<System.Int32>)reader[166];
            }
            if(reader[167] != DBNull.Value)
            {
                HCT0120010 = (System.Nullable<System.Int32>)reader[167];
            }
            if(reader[168] != DBNull.Value)
            {
                HCT0120011 = (System.Nullable<System.Int32>)reader[168];
            }
            if(reader[169] != DBNull.Value)
            {
                HCT0120012 = (System.Nullable<System.Int32>)reader[169];
            }
            if(reader[170] != DBNull.Value)
            {
                HCT0120013 = (System.Nullable<System.Int32>)reader[170];
            }
            if(reader[171] != DBNull.Value)
            {
                HCT0130001 = (System.Nullable<System.Int32>)reader[171];
            }
            if(reader[172] != DBNull.Value)
            {
                HCT0130002 = (System.Nullable<System.Int32>)reader[172];
            }
            if(reader[173] != DBNull.Value)
            {
                HCT0130003 = (System.Nullable<System.Int32>)reader[173];
            }
            if(reader[174] != DBNull.Value)
            {
                HCT0140001 = (System.Nullable<System.Int32>)reader[174];
            }
            if(reader[175] != DBNull.Value)
            {
                HCT0140002 = (System.Nullable<System.Int32>)reader[175];
            }
            if(reader[176] != DBNull.Value)
            {
                HCT0140003 = (System.Nullable<System.Int32>)reader[176];
            }
        }
        #endregion Constructors
    }
}