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

    [Table("SF1_00044")]
    public partial class SF1_00044 : BaseModel
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
        [Column("H0030001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public System.Nullable<System.Int32> H0030001 { get; set; }

        [ReadOnly(false)]
        [Column("H0030002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Occupied", ShortName = "Occupied", Order = 6)]
        public System.Nullable<System.Int32> H0030002 { get; set; }

        [ReadOnly(false)]
        [Column("H0030003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Vacant", ShortName = "Vacant", Order = 7)]
        public System.Nullable<System.Int32> H0030003 { get; set; }

        [ReadOnly(false)]
        [Column("H0040001", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 8)]
        public System.Nullable<System.Int32> H0040001 { get; set; }

        [ReadOnly(false)]
        [Column("H0040002", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owned with a mortgage or a loan", ShortName = "Owned with a mortgage or a loan", Order = 9)]
        public System.Nullable<System.Int32> H0040002 { get; set; }

        [ReadOnly(false)]
        [Column("H0040003", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owned free and clear", ShortName = "Owned free and clear", Order = 10)]
        public System.Nullable<System.Int32> H0040003 { get; set; }

        [ReadOnly(false)]
        [Column("H0040004", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 11)]
        public System.Nullable<System.Int32> H0040004 { get; set; }

        [ReadOnly(false)]
        [Column("H0050001", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 12)]
        public System.Nullable<System.Int32> H0050001 { get; set; }

        [ReadOnly(false)]
        [Column("H0050002", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "For rent", ShortName = "For rent", Order = 13)]
        public System.Nullable<System.Int32> H0050002 { get; set; }

        [ReadOnly(false)]
        [Column("H0050003", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Rented, not occupied", ShortName = "Rented, not occupied", Order = 14)]
        public System.Nullable<System.Int32> H0050003 { get; set; }

        [ReadOnly(false)]
        [Column("H0050004", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "For sale only", ShortName = "For sale only", Order = 15)]
        public System.Nullable<System.Int32> H0050004 { get; set; }

        [ReadOnly(false)]
        [Column("H0050005", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Sold, not occupied", ShortName = "Sold, not occupied", Order = 16)]
        public System.Nullable<System.Int32> H0050005 { get; set; }

        [ReadOnly(false)]
        [Column("H0050006", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "For seasonal, recreational, or occasional use", ShortName = "For seasonal, recreational, or occasional use", Order = 17)]
        public System.Nullable<System.Int32> H0050006 { get; set; }

        [ReadOnly(false)]
        [Column("H0050007", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "For migrant workers", ShortName = "For migrant workers", Order = 18)]
        public System.Nullable<System.Int32> H0050007 { get; set; }

        [ReadOnly(false)]
        [Column("H0050008", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other vacant", ShortName = "Other vacant", Order = 19)]
        public System.Nullable<System.Int32> H0050008 { get; set; }

        [ReadOnly(false)]
        [Column("H0060001", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 20)]
        public System.Nullable<System.Int32> H0060001 { get; set; }

        [ReadOnly(false)]
        [Column("H0060002", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 21)]
        public System.Nullable<System.Int32> H0060002 { get; set; }

        [ReadOnly(false)]
        [Column("H0060003", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 22)]
        public System.Nullable<System.Int32> H0060003 { get; set; }

        [ReadOnly(false)]
        [Column("H0060004", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 23)]
        public System.Nullable<System.Int32> H0060004 { get; set; }

        [ReadOnly(false)]
        [Column("H0060005", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 24)]
        public System.Nullable<System.Int32> H0060005 { get; set; }

        [ReadOnly(false)]
        [Column("H0060006", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 25)]
        public System.Nullable<System.Int32> H0060006 { get; set; }

        [ReadOnly(false)]
        [Column("H0060007", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 26)]
        public System.Nullable<System.Int32> H0060007 { get; set; }

        [ReadOnly(false)]
        [Column("H0060008", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 27)]
        public System.Nullable<System.Int32> H0060008 { get; set; }

        [ReadOnly(false)]
        [Column("H0070001", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 28)]
        public System.Nullable<System.Int32> H0070001 { get; set; }

        [ReadOnly(false)]
        [Column("H0070002", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not Hispanic or Latino householder:", ShortName = "Not Hispanic or Latino householder:", Order = 29)]
        public System.Nullable<System.Int32> H0070002 { get; set; }

        [ReadOnly(false)]
        [Column("H0070003", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 30)]
        public System.Nullable<System.Int32> H0070003 { get; set; }

        [ReadOnly(false)]
        [Column("H0070004", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 31)]
        public System.Nullable<System.Int32> H0070004 { get; set; }

        [ReadOnly(false)]
        [Column("H0070005", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 32)]
        public System.Nullable<System.Int32> H0070005 { get; set; }

        [ReadOnly(false)]
        [Column("H0070006", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 33)]
        public System.Nullable<System.Int32> H0070006 { get; set; }

        [ReadOnly(false)]
        [Column("H0070007", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 34)]
        public System.Nullable<System.Int32> H0070007 { get; set; }

        [ReadOnly(false)]
        [Column("H0070008", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 35)]
        public System.Nullable<System.Int32> H0070008 { get; set; }

        [ReadOnly(false)]
        [Column("H0070009", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 36)]
        public System.Nullable<System.Int32> H0070009 { get; set; }

        [ReadOnly(false)]
        [Column("H0070010", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hispanic or Latino householder:", ShortName = "Hispanic or Latino householder:", Order = 37)]
        public System.Nullable<System.Int32> H0070010 { get; set; }

        [ReadOnly(false)]
        [Column("H0070011", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 38)]
        public System.Nullable<System.Int32> H0070011 { get; set; }

        [ReadOnly(false)]
        [Column("H0070012", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 39)]
        public System.Nullable<System.Int32> H0070012 { get; set; }

        [ReadOnly(false)]
        [Column("H0070013", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 40)]
        public System.Nullable<System.Int32> H0070013 { get; set; }

        [ReadOnly(false)]
        [Column("H0070014", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 41)]
        public System.Nullable<System.Int32> H0070014 { get; set; }

        [ReadOnly(false)]
        [Column("H0070015", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 42)]
        public System.Nullable<System.Int32> H0070015 { get; set; }

        [ReadOnly(false)]
        [Column("H0070016", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 43)]
        public System.Nullable<System.Int32> H0070016 { get; set; }

        [ReadOnly(false)]
        [Column("H0070017", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 44)]
        public System.Nullable<System.Int32> H0070017 { get; set; }

        [ReadOnly(false)]
        [Column("H0080001", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total races tallied for householders:", ShortName = "Total races tallied for householders:", Order = 45)]
        public System.Nullable<System.Int32> H0080001 { get; set; }

        [ReadOnly(false)]
        [Column("H0080002", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White alone or in combination with one or more other races", ShortName = "White alone or in combination with one or more other races", Order = 46)]
        public System.Nullable<System.Int32> H0080002 { get; set; }

        [ReadOnly(false)]
        [Column("H0080003", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American alone or in combination with one or more other races", ShortName = "Black or African American alone or in combination with one or more other races", Order = 47)]
        public System.Nullable<System.Int32> H0080003 { get; set; }

        [ReadOnly(false)]
        [Column("H0080004", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native alone or in combination with one or more other races", ShortName = "American Indian and Alaska Native alone or in combination with one or more other races", Order = 48)]
        public System.Nullable<System.Int32> H0080004 { get; set; }

        [ReadOnly(false)]
        [Column("H0080005", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian alone or in combination with one or more other races", ShortName = "Asian alone or in combination with one or more other races", Order = 49)]
        public System.Nullable<System.Int32> H0080005 { get; set; }

        [ReadOnly(false)]
        [Column("H0080006", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander alone or in combination with one or more other races", ShortName = "Native Hawaiian and Other Pacific Islander alone or in combination with one or more other races", Order = 50)]
        public System.Nullable<System.Int32> H0080006 { get; set; }

        [ReadOnly(false)]
        [Column("H0080007", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Some Other Race alone or in combination with one or more other races", ShortName = "Some Other Race alone or in combination with one or more other races", Order = 51)]
        public System.Nullable<System.Int32> H0080007 { get; set; }

        [ReadOnly(false)]
        [Column("H0090001", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total races tallied for householders:", ShortName = "Total races tallied for householders:", Order = 52)]
        public System.Nullable<System.Int32> H0090001 { get; set; }

        [ReadOnly(false)]
        [Column("H0090002", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total races tallied for Not Hispanic or Latino householders:", ShortName = "Total races tallied for Not Hispanic or Latino householders:", Order = 53)]
        public System.Nullable<System.Int32> H0090002 { get; set; }

        [ReadOnly(false)]
        [Column("H0090003", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White alone or in combination with one or more other races", ShortName = "White alone or in combination with one or more other races", Order = 54)]
        public System.Nullable<System.Int32> H0090003 { get; set; }

        [ReadOnly(false)]
        [Column("H0090004", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American alone or in combination with one or more other races", ShortName = "Black or African American alone or in combination with one or more other races", Order = 55)]
        public System.Nullable<System.Int32> H0090004 { get; set; }

        [ReadOnly(false)]
        [Column("H0090005", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native alone or in combination with one or more other races", ShortName = "American Indian and Alaska Native alone or in combination with one or more other races", Order = 56)]
        public System.Nullable<System.Int32> H0090005 { get; set; }

        [ReadOnly(false)]
        [Column("H0090006", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian alone or in combination with one or more other races", ShortName = "Asian alone or in combination with one or more other races", Order = 57)]
        public System.Nullable<System.Int32> H0090006 { get; set; }

        [ReadOnly(false)]
        [Column("H0090007", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander alone or in combination with one or more other races", ShortName = "Native Hawaiian and Other Pacific Islander alone or in combination with one or more other races", Order = 58)]
        public System.Nullable<System.Int32> H0090007 { get; set; }

        [ReadOnly(false)]
        [Column("H0090008", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Some Other Race alone or in combination with one or more other races", ShortName = "Some Other Race alone or in combination with one or more other races", Order = 59)]
        public System.Nullable<System.Int32> H0090008 { get; set; }

        [ReadOnly(false)]
        [Column("H0090009", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total races tallied for Hispanic or Latino householders:", ShortName = "Total races tallied for Hispanic or Latino householders:", Order = 60)]
        public System.Nullable<System.Int32> H0090009 { get; set; }

        [ReadOnly(false)]
        [Column("H0090010", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White alone or in combination with one or more other races", ShortName = "White alone or in combination with one or more other races", Order = 61)]
        public System.Nullable<System.Int32> H0090010 { get; set; }

        [ReadOnly(false)]
        [Column("H0090011", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American alone or in combination with one or more other races", ShortName = "Black or African American alone or in combination with one or more other races", Order = 62)]
        public System.Nullable<System.Int32> H0090011 { get; set; }

        [ReadOnly(false)]
        [Column("H0090012", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native alone or in combination with one or more other races", ShortName = "American Indian and Alaska Native alone or in combination with one or more other races", Order = 63)]
        public System.Nullable<System.Int32> H0090012 { get; set; }

        [ReadOnly(false)]
        [Column("H0090013", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian alone or in combination with one or more other races", ShortName = "Asian alone or in combination with one or more other races", Order = 64)]
        public System.Nullable<System.Int32> H0090013 { get; set; }

        [ReadOnly(false)]
        [Column("H0090014", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander alone or in combination with one or more other races", ShortName = "Native Hawaiian and Other Pacific Islander alone or in combination with one or more other races", Order = 65)]
        public System.Nullable<System.Int32> H0090014 { get; set; }

        [ReadOnly(false)]
        [Column("H0090015", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Some Other Race alone or in combination with one or more other races", ShortName = "Some Other Race alone or in combination with one or more other races", Order = 66)]
        public System.Nullable<System.Int32> H0090015 { get; set; }

        [ReadOnly(false)]
        [Column("H0100001", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total", ShortName = "Total", Order = 67)]
        public System.Nullable<System.Int32> H0100001 { get; set; }

        [ReadOnly(false)]
        [Column("H0110001", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total population in occupied housing units:", ShortName = "Total population in occupied housing units:", Order = 68)]
        public System.Nullable<System.Int32> H0110001 { get; set; }

        [ReadOnly(false)]
        [Column("H0110002", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owned with a mortgage or a loan", ShortName = "Owned with a mortgage or a loan", Order = 69)]
        public System.Nullable<System.Int32> H0110002 { get; set; }

        [ReadOnly(false)]
        [Column("H0110003", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owned free and clear", ShortName = "Owned free and clear", Order = 70)]
        public System.Nullable<System.Int32> H0110003 { get; set; }

        [ReadOnly(false)]
        [Column("H0110004", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 71)]
        public System.Nullable<System.Int32> H0110004 { get; set; }

        [ReadOnly(false)]
        [Column("H0120001", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total", ShortName = "Total", Order = 72)]
        public System.Nullable<System.Double> H0120001 { get; set; }

        [ReadOnly(false)]
        [Column("H0120002", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied", ShortName = "Owner occupied", Order = 73)]
        public System.Nullable<System.Double> H0120002 { get; set; }

        [ReadOnly(false)]
        [Column("H0120003", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 74)]
        public System.Nullable<System.Double> H0120003 { get; set; }

        [ReadOnly(false)]
        [Column("H0130001", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 75)]
        public System.Nullable<System.Int32> H0130001 { get; set; }

        [ReadOnly(false)]
        [Column("H0130002", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 76)]
        public System.Nullable<System.Int32> H0130002 { get; set; }

        [ReadOnly(false)]
        [Column("H0130003", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 77)]
        public System.Nullable<System.Int32> H0130003 { get; set; }

        [ReadOnly(false)]
        [Column("H0130004", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 78)]
        public System.Nullable<System.Int32> H0130004 { get; set; }

        [ReadOnly(false)]
        [Column("H0130005", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 79)]
        public System.Nullable<System.Int32> H0130005 { get; set; }

        [ReadOnly(false)]
        [Column("H0130006", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 80)]
        public System.Nullable<System.Int32> H0130006 { get; set; }

        [ReadOnly(false)]
        [Column("H0130007", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 81)]
        public System.Nullable<System.Int32> H0130007 { get; set; }

        [ReadOnly(false)]
        [Column("H0130008", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 82)]
        public System.Nullable<System.Int32> H0130008 { get; set; }

        [ReadOnly(false)]
        [Column("H0140001", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 83)]
        public System.Nullable<System.Int32> H0140001 { get; set; }

        [ReadOnly(false)]
        [Column("H0140002", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 84)]
        public System.Nullable<System.Int32> H0140002 { get; set; }

        [ReadOnly(false)]
        [Column("H0140003", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 85)]
        public System.Nullable<System.Int32> H0140003 { get; set; }

        [ReadOnly(false)]
        [Column("H0140004", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 86)]
        public System.Nullable<System.Int32> H0140004 { get; set; }

        [ReadOnly(false)]
        [Column("H0140005", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 87)]
        public System.Nullable<System.Int32> H0140005 { get; set; }

        [ReadOnly(false)]
        [Column("H0140006", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 88)]
        public System.Nullable<System.Int32> H0140006 { get; set; }

        [ReadOnly(false)]
        [Column("H0140007", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 89)]
        public System.Nullable<System.Int32> H0140007 { get; set; }

        [ReadOnly(false)]
        [Column("H0140008", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 90)]
        public System.Nullable<System.Int32> H0140008 { get; set; }

        [ReadOnly(false)]
        [Column("H0140009", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 91)]
        public System.Nullable<System.Int32> H0140009 { get; set; }

        [ReadOnly(false)]
        [Column("H0140010", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 92)]
        public System.Nullable<System.Int32> H0140010 { get; set; }

        [ReadOnly(false)]
        [Column("H0140011", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 93)]
        public System.Nullable<System.Int32> H0140011 { get; set; }

        [ReadOnly(false)]
        [Column("H0140012", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 94)]
        public System.Nullable<System.Int32> H0140012 { get; set; }

        [ReadOnly(false)]
        [Column("H0140013", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 95)]
        public System.Nullable<System.Int32> H0140013 { get; set; }

        [ReadOnly(false)]
        [Column("H0140014", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 96)]
        public System.Nullable<System.Int32> H0140014 { get; set; }

        [ReadOnly(false)]
        [Column("H0140015", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 97)]
        public System.Nullable<System.Int32> H0140015 { get; set; }

        [ReadOnly(false)]
        [Column("H0140016", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 98)]
        public System.Nullable<System.Int32> H0140016 { get; set; }

        [ReadOnly(false)]
        [Column("H0140017", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 99)]
        public System.Nullable<System.Int32> H0140017 { get; set; }

        [ReadOnly(false)]
        [Column("H0150001", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 100)]
        public System.Nullable<System.Int32> H0150001 { get; set; }

        [ReadOnly(false)]
        [Column("H0150002", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 101)]
        public System.Nullable<System.Int32> H0150002 { get; set; }

        [ReadOnly(false)]
        [Column("H0150003", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not Hispanic or Latino householder", ShortName = "Not Hispanic or Latino householder", Order = 102)]
        public System.Nullable<System.Int32> H0150003 { get; set; }

        [ReadOnly(false)]
        [Column("H0150004", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hispanic or Latino householder", ShortName = "Hispanic or Latino householder", Order = 103)]
        public System.Nullable<System.Int32> H0150004 { get; set; }

        [ReadOnly(false)]
        [Column("H0150005", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 104)]
        public System.Nullable<System.Int32> H0150005 { get; set; }

        [ReadOnly(false)]
        [Column("H0150006", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not Hispanic or Latino householder", ShortName = "Not Hispanic or Latino householder", Order = 105)]
        public System.Nullable<System.Int32> H0150006 { get; set; }

        [ReadOnly(false)]
        [Column("H0150007", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hispanic or Latino householder", ShortName = "Hispanic or Latino householder", Order = 106)]
        public System.Nullable<System.Int32> H0150007 { get; set; }

        [ReadOnly(false)]
        [Column("H0160001", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 107)]
        public System.Nullable<System.Int32> H0160001 { get; set; }

        [ReadOnly(false)]
        [Column("H0160002", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 108)]
        public System.Nullable<System.Int32> H0160002 { get; set; }

        [ReadOnly(false)]
        [Column("H0160003", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 109)]
        public System.Nullable<System.Int32> H0160003 { get; set; }

        [ReadOnly(false)]
        [Column("H0160004", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 110)]
        public System.Nullable<System.Int32> H0160004 { get; set; }

        [ReadOnly(false)]
        [Column("H0160005", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 111)]
        public System.Nullable<System.Int32> H0160005 { get; set; }

        [ReadOnly(false)]
        [Column("H0160006", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 112)]
        public System.Nullable<System.Int32> H0160006 { get; set; }

        [ReadOnly(false)]
        [Column("H0160007", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 113)]
        public System.Nullable<System.Int32> H0160007 { get; set; }

        [ReadOnly(false)]
        [Column("H0160008", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 114)]
        public System.Nullable<System.Int32> H0160008 { get; set; }

        [ReadOnly(false)]
        [Column("H0160009", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 115)]
        public System.Nullable<System.Int32> H0160009 { get; set; }

        [ReadOnly(false)]
        [Column("H0160010", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 116)]
        public System.Nullable<System.Int32> H0160010 { get; set; }

        [ReadOnly(false)]
        [Column("H0160011", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 117)]
        public System.Nullable<System.Int32> H0160011 { get; set; }

        [ReadOnly(false)]
        [Column("H0160012", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 118)]
        public System.Nullable<System.Int32> H0160012 { get; set; }

        [ReadOnly(false)]
        [Column("H0160013", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 119)]
        public System.Nullable<System.Int32> H0160013 { get; set; }

        [ReadOnly(false)]
        [Column("H0160014", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 120)]
        public System.Nullable<System.Int32> H0160014 { get; set; }

        [ReadOnly(false)]
        [Column("H0160015", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 121)]
        public System.Nullable<System.Int32> H0160015 { get; set; }

        [ReadOnly(false)]
        [Column("H0160016", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 122)]
        public System.Nullable<System.Int32> H0160016 { get; set; }

        [ReadOnly(false)]
        [Column("H0160017", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 123)]
        public System.Nullable<System.Int32> H0160017 { get; set; }

        [ReadOnly(false)]
        [Column("H0170001", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 124)]
        public System.Nullable<System.Int32> H0170001 { get; set; }

        [ReadOnly(false)]
        [Column("H0170002", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 125)]
        public System.Nullable<System.Int32> H0170002 { get; set; }

        [ReadOnly(false)]
        [Column("H0170003", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 126)]
        public System.Nullable<System.Int32> H0170003 { get; set; }

        [ReadOnly(false)]
        [Column("H0170004", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 127)]
        public System.Nullable<System.Int32> H0170004 { get; set; }

        [ReadOnly(false)]
        [Column("H0170005", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 128)]
        public System.Nullable<System.Int32> H0170005 { get; set; }

        [ReadOnly(false)]
        [Column("H0170006", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 129)]
        public System.Nullable<System.Int32> H0170006 { get; set; }

        [ReadOnly(false)]
        [Column("H0170007", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 130)]
        public System.Nullable<System.Int32> H0170007 { get; set; }

        [ReadOnly(false)]
        [Column("H0170008", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 131)]
        public System.Nullable<System.Int32> H0170008 { get; set; }

        [ReadOnly(false)]
        [Column("H0170009", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 132)]
        public System.Nullable<System.Int32> H0170009 { get; set; }

        [ReadOnly(false)]
        [Column("H0170010", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 133)]
        public System.Nullable<System.Int32> H0170010 { get; set; }

        [ReadOnly(false)]
        [Column("H0170011", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 134)]
        public System.Nullable<System.Int32> H0170011 { get; set; }

        [ReadOnly(false)]
        [Column("H0170012", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 135)]
        public System.Nullable<System.Int32> H0170012 { get; set; }

        [ReadOnly(false)]
        [Column("H0170013", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 24 years", ShortName = "Householder 15 to 24 years", Order = 136)]
        public System.Nullable<System.Int32> H0170013 { get; set; }

        [ReadOnly(false)]
        [Column("H0170014", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 25 to 34 years", ShortName = "Householder 25 to 34 years", Order = 137)]
        public System.Nullable<System.Int32> H0170014 { get; set; }

        [ReadOnly(false)]
        [Column("H0170015", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 44 years", ShortName = "Householder 35 to 44 years", Order = 138)]
        public System.Nullable<System.Int32> H0170015 { get; set; }

        [ReadOnly(false)]
        [Column("H0170016", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 45 to 54 years", ShortName = "Householder 45 to 54 years", Order = 139)]
        public System.Nullable<System.Int32> H0170016 { get; set; }

        [ReadOnly(false)]
        [Column("H0170017", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 55 to 59 years", ShortName = "Householder 55 to 59 years", Order = 140)]
        public System.Nullable<System.Int32> H0170017 { get; set; }

        [ReadOnly(false)]
        [Column("H0170018", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 60 to 64 years", ShortName = "Householder 60 to 64 years", Order = 141)]
        public System.Nullable<System.Int32> H0170018 { get; set; }

        [ReadOnly(false)]
        [Column("H0170019", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 to 74 years", ShortName = "Householder 65 to 74 years", Order = 142)]
        public System.Nullable<System.Int32> H0170019 { get; set; }

        [ReadOnly(false)]
        [Column("H0170020", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 75 to 84 years", ShortName = "Householder 75 to 84 years", Order = 143)]
        public System.Nullable<System.Int32> H0170020 { get; set; }

        [ReadOnly(false)]
        [Column("H0170021", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 85 years and over", ShortName = "Householder 85 years and over", Order = 144)]
        public System.Nullable<System.Int32> H0170021 { get; set; }

        [ReadOnly(false)]
        [Column("H0180001", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 145)]
        public System.Nullable<System.Int32> H0180001 { get; set; }

        [ReadOnly(false)]
        [Column("H0180002", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 146)]
        public System.Nullable<System.Int32> H0180002 { get; set; }

        [ReadOnly(false)]
        [Column("H0180003", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 147)]
        public System.Nullable<System.Int32> H0180003 { get; set; }

        [ReadOnly(false)]
        [Column("H0180004", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 148)]
        public System.Nullable<System.Int32> H0180004 { get; set; }

        [ReadOnly(false)]
        [Column("H0180005", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 149)]
        public System.Nullable<System.Int32> H0180005 { get; set; }

        [ReadOnly(false)]
        [Column("H0180006", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 150)]
        public System.Nullable<System.Int32> H0180006 { get; set; }

        [ReadOnly(false)]
        [Column("H0180007", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 151)]
        public System.Nullable<System.Int32> H0180007 { get; set; }

        [ReadOnly(false)]
        [Column("H0180008", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 152)]
        public System.Nullable<System.Int32> H0180008 { get; set; }

        [ReadOnly(false)]
        [Column("H0180009", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 153)]
        public System.Nullable<System.Int32> H0180009 { get; set; }

        [ReadOnly(false)]
        [Column("H0180010", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 154)]
        public System.Nullable<System.Int32> H0180010 { get; set; }

        [ReadOnly(false)]
        [Column("H0180011", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 155)]
        public System.Nullable<System.Int32> H0180011 { get; set; }

        [ReadOnly(false)]
        [Column("H0180012", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 156)]
        public System.Nullable<System.Int32> H0180012 { get; set; }

        [ReadOnly(false)]
        [Column("H0180013", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 157)]
        public System.Nullable<System.Int32> H0180013 { get; set; }

        [ReadOnly(false)]
        [Column("H0180014", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 158)]
        public System.Nullable<System.Int32> H0180014 { get; set; }

        [ReadOnly(false)]
        [Column("H0180015", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 159)]
        public System.Nullable<System.Int32> H0180015 { get; set; }

        [ReadOnly(false)]
        [Column("H0180016", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 160)]
        public System.Nullable<System.Int32> H0180016 { get; set; }

        [ReadOnly(false)]
        [Column("H0180017", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 161)]
        public System.Nullable<System.Int32> H0180017 { get; set; }

        [ReadOnly(false)]
        [Column("H0180018", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 162)]
        public System.Nullable<System.Int32> H0180018 { get; set; }

        [ReadOnly(false)]
        [Column("H0180019", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone:", ShortName = "Living alone:", Order = 163)]
        public System.Nullable<System.Int32> H0180019 { get; set; }

        [ReadOnly(false)]
        [Column("H0180020", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 164)]
        public System.Nullable<System.Int32> H0180020 { get; set; }

        [ReadOnly(false)]
        [Column("H0180021", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 165)]
        public System.Nullable<System.Int32> H0180021 { get; set; }

        [ReadOnly(false)]
        [Column("H0180022", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 166)]
        public System.Nullable<System.Int32> H0180022 { get; set; }

        [ReadOnly(false)]
        [Column("H0180023", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 167)]
        public System.Nullable<System.Int32> H0180023 { get; set; }

        [ReadOnly(false)]
        [Column("H0180024", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 168)]
        public System.Nullable<System.Int32> H0180024 { get; set; }

        [ReadOnly(false)]
        [Column("H0180025", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 169)]
        public System.Nullable<System.Int32> H0180025 { get; set; }

        [ReadOnly(false)]
        [Column("H0180026", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 170)]
        public System.Nullable<System.Int32> H0180026 { get; set; }

        [ReadOnly(false)]
        [Column("H0180027", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 171)]
        public System.Nullable<System.Int32> H0180027 { get; set; }

        [ReadOnly(false)]
        [Column("H0180028", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone:", ShortName = "Living alone:", Order = 172)]
        public System.Nullable<System.Int32> H0180028 { get; set; }

        [ReadOnly(false)]
        [Column("H0180029", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 173)]
        public System.Nullable<System.Int32> H0180029 { get; set; }

        [ReadOnly(false)]
        [Column("H0180030", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 174)]
        public System.Nullable<System.Int32> H0180030 { get; set; }

        [ReadOnly(false)]
        [Column("H0180031", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 175)]
        public System.Nullable<System.Int32> H0180031 { get; set; }

        [ReadOnly(false)]
        [Column("H0180032", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 176)]
        public System.Nullable<System.Int32> H0180032 { get; set; }

        [ReadOnly(false)]
        [Column("H0180033", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 177)]
        public System.Nullable<System.Int32> H0180033 { get; set; }

        [ReadOnly(false)]
        [Column("H0180034", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 178)]
        public System.Nullable<System.Int32> H0180034 { get; set; }

        [ReadOnly(false)]
        [Column("H0180035", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 179)]
        public System.Nullable<System.Int32> H0180035 { get; set; }

        [ReadOnly(false)]
        [Column("H0180036", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 180)]
        public System.Nullable<System.Int32> H0180036 { get; set; }

        [ReadOnly(false)]
        [Column("H0180037", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 181)]
        public System.Nullable<System.Int32> H0180037 { get; set; }

        [ReadOnly(false)]
        [Column("H0180038", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 182)]
        public System.Nullable<System.Int32> H0180038 { get; set; }

        [ReadOnly(false)]
        [Column("H0180039", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 183)]
        public System.Nullable<System.Int32> H0180039 { get; set; }

        [ReadOnly(false)]
        [Column("H0180040", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 184)]
        public System.Nullable<System.Int32> H0180040 { get; set; }

        [ReadOnly(false)]
        [Column("H0180041", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 185)]
        public System.Nullable<System.Int32> H0180041 { get; set; }

        [ReadOnly(false)]
        [Column("H0180042", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 186)]
        public System.Nullable<System.Int32> H0180042 { get; set; }

        [ReadOnly(false)]
        [Column("H0180043", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 187)]
        public System.Nullable<System.Int32> H0180043 { get; set; }

        [ReadOnly(false)]
        [Column("H0180044", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 188)]
        public System.Nullable<System.Int32> H0180044 { get; set; }

        [ReadOnly(false)]
        [Column("H0180045", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 189)]
        public System.Nullable<System.Int32> H0180045 { get; set; }

        [ReadOnly(false)]
        [Column("H0180046", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 190)]
        public System.Nullable<System.Int32> H0180046 { get; set; }

        [ReadOnly(false)]
        [Column("H0180047", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 191)]
        public System.Nullable<System.Int32> H0180047 { get; set; }

        [ReadOnly(false)]
        [Column("H0180048", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 192)]
        public System.Nullable<System.Int32> H0180048 { get; set; }

        [ReadOnly(false)]
        [Column("H0180049", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 193)]
        public System.Nullable<System.Int32> H0180049 { get; set; }

        [ReadOnly(false)]
        [Column("H0180050", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 194)]
        public System.Nullable<System.Int32> H0180050 { get; set; }

        [ReadOnly(false)]
        [Column("H0180051", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 195)]
        public System.Nullable<System.Int32> H0180051 { get; set; }

        [ReadOnly(false)]
        [Column("H0180052", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 196)]
        public System.Nullable<System.Int32> H0180052 { get; set; }

        [ReadOnly(false)]
        [Column("H0180053", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone:", ShortName = "Living alone:", Order = 197)]
        public System.Nullable<System.Int32> H0180053 { get; set; }

        [ReadOnly(false)]
        [Column("H0180054", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 198)]
        public System.Nullable<System.Int32> H0180054 { get; set; }

        [ReadOnly(false)]
        [Column("H0180055", Order = 199)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 199)]
        public System.Nullable<System.Int32> H0180055 { get; set; }

        [ReadOnly(false)]
        [Column("H0180056", Order = 200)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 200)]
        public System.Nullable<System.Int32> H0180056 { get; set; }

        [ReadOnly(false)]
        [Column("H0180057", Order = 201)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 201)]
        public System.Nullable<System.Int32> H0180057 { get; set; }

        [ReadOnly(false)]
        [Column("H0180058", Order = 202)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 202)]
        public System.Nullable<System.Int32> H0180058 { get; set; }

        [ReadOnly(false)]
        [Column("H0180059", Order = 203)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 203)]
        public System.Nullable<System.Int32> H0180059 { get; set; }

        [ReadOnly(false)]
        [Column("H0180060", Order = 204)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 204)]
        public System.Nullable<System.Int32> H0180060 { get; set; }

        [ReadOnly(false)]
        [Column("H0180061", Order = 205)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 205)]
        public System.Nullable<System.Int32> H0180061 { get; set; }

        [ReadOnly(false)]
        [Column("H0180062", Order = 206)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone:", ShortName = "Living alone:", Order = 206)]
        public System.Nullable<System.Int32> H0180062 { get; set; }

        [ReadOnly(false)]
        [Column("H0180063", Order = 207)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 207)]
        public System.Nullable<System.Int32> H0180063 { get; set; }

        [ReadOnly(false)]
        [Column("H0180064", Order = 208)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 208)]
        public System.Nullable<System.Int32> H0180064 { get; set; }

        [ReadOnly(false)]
        [Column("H0180065", Order = 209)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 209)]
        public System.Nullable<System.Int32> H0180065 { get; set; }

        [ReadOnly(false)]
        [Column("H0180066", Order = 210)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 210)]
        public System.Nullable<System.Int32> H0180066 { get; set; }

        [ReadOnly(false)]
        [Column("H0180067", Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 34 years", ShortName = "Householder 15 to 34 years", Order = 211)]
        public System.Nullable<System.Int32> H0180067 { get; set; }

        [ReadOnly(false)]
        [Column("H0180068", Order = 212)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 35 to 64 years", ShortName = "Householder 35 to 64 years", Order = 212)]
        public System.Nullable<System.Int32> H0180068 { get; set; }

        [ReadOnly(false)]
        [Column("H0180069", Order = 213)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 213)]
        public System.Nullable<System.Int32> H0180069 { get; set; }

        [ReadOnly(false)]
        [Column("H0190001", Order = 214)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 214)]
        public System.Nullable<System.Int32> H0190001 { get; set; }

        [ReadOnly(false)]
        [Column("H0190002", Order = 215)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 215)]
        public System.Nullable<System.Int32> H0190002 { get; set; }

        [ReadOnly(false)]
        [Column("H0190003", Order = 216)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With children under 18 years", ShortName = "With children under 18 years", Order = 216)]
        public System.Nullable<System.Int32> H0190003 { get; set; }

        [ReadOnly(false)]
        [Column("H0190004", Order = 217)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No children under 18 years", ShortName = "No children under 18 years", Order = 217)]
        public System.Nullable<System.Int32> H0190004 { get; set; }

        [ReadOnly(false)]
        [Column("H0190005", Order = 218)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter-occupied:", ShortName = "Renter-occupied:", Order = 218)]
        public System.Nullable<System.Int32> H0190005 { get; set; }

        [ReadOnly(false)]
        [Column("H0190006", Order = 219)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With children under 18 years", ShortName = "With children under 18 years", Order = 219)]
        public System.Nullable<System.Int32> H0190006 { get; set; }

        [ReadOnly(false)]
        [Column("H0190007", Order = 220)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No children under 18 years", ShortName = "No children under 18 years", Order = 220)]
        public System.Nullable<System.Int32> H0190007 { get; set; }

        [ReadOnly(false)]
        [Column("H0200001", Order = 221)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 221)]
        public System.Nullable<System.Int32> H0200001 { get; set; }

        [ReadOnly(false)]
        [Column("H0200002", Order = 222)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Substituted", ShortName = "Substituted", Order = 222)]
        public System.Nullable<System.Int32> H0200002 { get; set; }

        [ReadOnly(false)]
        [Column("H0200003", Order = 223)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not substituted", ShortName = "Not substituted", Order = 223)]
        public System.Nullable<System.Int32> H0200003 { get; set; }

        [ReadOnly(false)]
        [Column("H0210001", Order = 224)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 224)]
        public System.Nullable<System.Int32> H0210001 { get; set; }

        [ReadOnly(false)]
        [Column("H0210002", Order = 225)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Allocated", ShortName = "Allocated", Order = 225)]
        public System.Nullable<System.Int32> H0210002 { get; set; }

        [ReadOnly(false)]
        [Column("H0210003", Order = 226)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not allocated", ShortName = "Not allocated", Order = 226)]
        public System.Nullable<System.Int32> H0210003 { get; set; }

        [ReadOnly(false)]
        [Column("H0220001", Order = 227)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 227)]
        public System.Nullable<System.Int32> H0220001 { get; set; }

        [ReadOnly(false)]
        [Column("H0220002", Order = 228)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Allocated", ShortName = "Allocated", Order = 228)]
        public System.Nullable<System.Int32> H0220002 { get; set; }

        [ReadOnly(false)]
        [Column("H0220003", Order = 229)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not allocated", ShortName = "Not allocated", Order = 229)]
        public System.Nullable<System.Int32> H0220003 { get; set; }

        [ReadOnly(false)]
        [Column("H011A0001", Order = 230)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population in occupied housing units:", ShortName = "Population in occupied housing units:", Order = 230)]
        public System.Nullable<System.Int32> H011A0001 { get; set; }

        [ReadOnly(false)]
        [Column("H011A0002", Order = 231)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owned with a mortgage or a loan", ShortName = "Owned with a mortgage or a loan", Order = 231)]
        public System.Nullable<System.Int32> H011A0002 { get; set; }

        [ReadOnly(false)]
        [Column("H011A0003", Order = 232)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owned free and clear", ShortName = "Owned free and clear", Order = 232)]
        public System.Nullable<System.Int32> H011A0003 { get; set; }

        [ReadOnly(false)]
        [Column("H011A0004", Order = 233)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 233)]
        public System.Nullable<System.Int32> H011A0004 { get; set; }

        [ReadOnly(false)]
        [Column("H011B0001", Order = 234)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population in occupied housing units:", ShortName = "Population in occupied housing units:", Order = 234)]
        public System.Nullable<System.Int32> H011B0001 { get; set; }

        [ReadOnly(false)]
        [Column("H011B0002", Order = 235)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owned with a mortgage or a loan", ShortName = "Owned with a mortgage or a loan", Order = 235)]
        public System.Nullable<System.Int32> H011B0002 { get; set; }

        [ReadOnly(false)]
        [Column("H011B0003", Order = 236)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owned free and clear", ShortName = "Owned free and clear", Order = 236)]
        public System.Nullable<System.Int32> H011B0003 { get; set; }

        [ReadOnly(false)]
        [Column("H011B0004", Order = 237)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 237)]
        public System.Nullable<System.Int32> H011B0004 { get; set; }

        [ReadOnly(false)]
        [Column("H011C0001", Order = 238)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population in occupied housing units:", ShortName = "Population in occupied housing units:", Order = 238)]
        public System.Nullable<System.Int32> H011C0001 { get; set; }

        [ReadOnly(false)]
        [Column("H011C0002", Order = 239)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owned with a mortgage or a loan", ShortName = "Owned with a mortgage or a loan", Order = 239)]
        public System.Nullable<System.Int32> H011C0002 { get; set; }

        [ReadOnly(false)]
        [Column("H011C0003", Order = 240)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owned free and clear", ShortName = "Owned free and clear", Order = 240)]
        public System.Nullable<System.Int32> H011C0003 { get; set; }

        [ReadOnly(false)]
        [Column("H011C0004", Order = 241)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 241)]
        public System.Nullable<System.Int32> H011C0004 { get; set; }

        [ReadOnly(false)]
        [Column("H011D0001", Order = 242)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population in occupied housing units:", ShortName = "Population in occupied housing units:", Order = 242)]
        public System.Nullable<System.Int32> H011D0001 { get; set; }

        [ReadOnly(false)]
        [Column("H011D0002", Order = 243)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owned with a mortgage or a loan", ShortName = "Owned with a mortgage or a loan", Order = 243)]
        public System.Nullable<System.Int32> H011D0002 { get; set; }

        [ReadOnly(false)]
        [Column("H011D0003", Order = 244)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owned free and clear", ShortName = "Owned free and clear", Order = 244)]
        public System.Nullable<System.Int32> H011D0003 { get; set; }

        [ReadOnly(false)]
        [Column("H011D0004", Order = 245)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 245)]
        public System.Nullable<System.Int32> H011D0004 { get; set; }

        [ReadOnly(false)]
        [Column("H011E0001", Order = 246)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population in occupied housing units:", ShortName = "Population in occupied housing units:", Order = 246)]
        public System.Nullable<System.Int32> H011E0001 { get; set; }

        [ReadOnly(false)]
        [Column("H011E0002", Order = 247)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owned with a mortgage or a loan", ShortName = "Owned with a mortgage or a loan", Order = 247)]
        public System.Nullable<System.Int32> H011E0002 { get; set; }

        [ReadOnly(false)]
        [Column("H011E0003", Order = 248)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owned free and clear", ShortName = "Owned free and clear", Order = 248)]
        public System.Nullable<System.Int32> H011E0003 { get; set; }

        [ReadOnly(false)]
        [Column("H011E0004", Order = 249)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 249)]
        public System.Nullable<System.Int32> H011E0004 { get; set; }

        [ReadOnly(false)]
        [Column("H011F0001", Order = 250)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population in occupied housing units:", ShortName = "Population in occupied housing units:", Order = 250)]
        public System.Nullable<System.Int32> H011F0001 { get; set; }

        [ReadOnly(false)]
        [Column("H011F0002", Order = 251)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owned with a mortgage or a loan", ShortName = "Owned with a mortgage or a loan", Order = 251)]
        public System.Nullable<System.Int32> H011F0002 { get; set; }

        [ReadOnly(false)]
        [Column("H011F0003", Order = 252)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owned free and clear", ShortName = "Owned free and clear", Order = 252)]
        public System.Nullable<System.Int32> H011F0003 { get; set; }

        [ReadOnly(false)]
        [Column("H011F0004", Order = 253)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied", ShortName = "Renter occupied", Order = 253)]
        public System.Nullable<System.Int32> H011F0004 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1_00044(string csvLine) : base(csvLine) {}

        public SF1_00044(string[] values) : base(values) {}

        public SF1_00044(OleDbDataReader reader, CensusFileType fileType)
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
                H0030001 = (System.Nullable<System.Int32>)reader[5];
            }
            if(reader[6] != DBNull.Value)
            {
                H0030002 = (System.Nullable<System.Int32>)reader[6];
            }
            if(reader[7] != DBNull.Value)
            {
                H0030003 = (System.Nullable<System.Int32>)reader[7];
            }
            if(reader[8] != DBNull.Value)
            {
                H0040001 = (System.Nullable<System.Int32>)reader[8];
            }
            if(reader[9] != DBNull.Value)
            {
                H0040002 = (System.Nullable<System.Int32>)reader[9];
            }
            if(reader[10] != DBNull.Value)
            {
                H0040003 = (System.Nullable<System.Int32>)reader[10];
            }
            if(reader[11] != DBNull.Value)
            {
                H0040004 = (System.Nullable<System.Int32>)reader[11];
            }
            if(reader[12] != DBNull.Value)
            {
                H0050001 = (System.Nullable<System.Int32>)reader[12];
            }
            if(reader[13] != DBNull.Value)
            {
                H0050002 = (System.Nullable<System.Int32>)reader[13];
            }
            if(reader[14] != DBNull.Value)
            {
                H0050003 = (System.Nullable<System.Int32>)reader[14];
            }
            if(reader[15] != DBNull.Value)
            {
                H0050004 = (System.Nullable<System.Int32>)reader[15];
            }
            if(reader[16] != DBNull.Value)
            {
                H0050005 = (System.Nullable<System.Int32>)reader[16];
            }
            if(reader[17] != DBNull.Value)
            {
                H0050006 = (System.Nullable<System.Int32>)reader[17];
            }
            if(reader[18] != DBNull.Value)
            {
                H0050007 = (System.Nullable<System.Int32>)reader[18];
            }
            if(reader[19] != DBNull.Value)
            {
                H0050008 = (System.Nullable<System.Int32>)reader[19];
            }
            if(reader[20] != DBNull.Value)
            {
                H0060001 = (System.Nullable<System.Int32>)reader[20];
            }
            if(reader[21] != DBNull.Value)
            {
                H0060002 = (System.Nullable<System.Int32>)reader[21];
            }
            if(reader[22] != DBNull.Value)
            {
                H0060003 = (System.Nullable<System.Int32>)reader[22];
            }
            if(reader[23] != DBNull.Value)
            {
                H0060004 = (System.Nullable<System.Int32>)reader[23];
            }
            if(reader[24] != DBNull.Value)
            {
                H0060005 = (System.Nullable<System.Int32>)reader[24];
            }
            if(reader[25] != DBNull.Value)
            {
                H0060006 = (System.Nullable<System.Int32>)reader[25];
            }
            if(reader[26] != DBNull.Value)
            {
                H0060007 = (System.Nullable<System.Int32>)reader[26];
            }
            if(reader[27] != DBNull.Value)
            {
                H0060008 = (System.Nullable<System.Int32>)reader[27];
            }
            if(reader[28] != DBNull.Value)
            {
                H0070001 = (System.Nullable<System.Int32>)reader[28];
            }
            if(reader[29] != DBNull.Value)
            {
                H0070002 = (System.Nullable<System.Int32>)reader[29];
            }
            if(reader[30] != DBNull.Value)
            {
                H0070003 = (System.Nullable<System.Int32>)reader[30];
            }
            if(reader[31] != DBNull.Value)
            {
                H0070004 = (System.Nullable<System.Int32>)reader[31];
            }
            if(reader[32] != DBNull.Value)
            {
                H0070005 = (System.Nullable<System.Int32>)reader[32];
            }
            if(reader[33] != DBNull.Value)
            {
                H0070006 = (System.Nullable<System.Int32>)reader[33];
            }
            if(reader[34] != DBNull.Value)
            {
                H0070007 = (System.Nullable<System.Int32>)reader[34];
            }
            if(reader[35] != DBNull.Value)
            {
                H0070008 = (System.Nullable<System.Int32>)reader[35];
            }
            if(reader[36] != DBNull.Value)
            {
                H0070009 = (System.Nullable<System.Int32>)reader[36];
            }
            if(reader[37] != DBNull.Value)
            {
                H0070010 = (System.Nullable<System.Int32>)reader[37];
            }
            if(reader[38] != DBNull.Value)
            {
                H0070011 = (System.Nullable<System.Int32>)reader[38];
            }
            if(reader[39] != DBNull.Value)
            {
                H0070012 = (System.Nullable<System.Int32>)reader[39];
            }
            if(reader[40] != DBNull.Value)
            {
                H0070013 = (System.Nullable<System.Int32>)reader[40];
            }
            if(reader[41] != DBNull.Value)
            {
                H0070014 = (System.Nullable<System.Int32>)reader[41];
            }
            if(reader[42] != DBNull.Value)
            {
                H0070015 = (System.Nullable<System.Int32>)reader[42];
            }
            if(reader[43] != DBNull.Value)
            {
                H0070016 = (System.Nullable<System.Int32>)reader[43];
            }
            if(reader[44] != DBNull.Value)
            {
                H0070017 = (System.Nullable<System.Int32>)reader[44];
            }
            if(reader[45] != DBNull.Value)
            {
                H0080001 = (System.Nullable<System.Int32>)reader[45];
            }
            if(reader[46] != DBNull.Value)
            {
                H0080002 = (System.Nullable<System.Int32>)reader[46];
            }
            if(reader[47] != DBNull.Value)
            {
                H0080003 = (System.Nullable<System.Int32>)reader[47];
            }
            if(reader[48] != DBNull.Value)
            {
                H0080004 = (System.Nullable<System.Int32>)reader[48];
            }
            if(reader[49] != DBNull.Value)
            {
                H0080005 = (System.Nullable<System.Int32>)reader[49];
            }
            if(reader[50] != DBNull.Value)
            {
                H0080006 = (System.Nullable<System.Int32>)reader[50];
            }
            if(reader[51] != DBNull.Value)
            {
                H0080007 = (System.Nullable<System.Int32>)reader[51];
            }
            if(reader[52] != DBNull.Value)
            {
                H0090001 = (System.Nullable<System.Int32>)reader[52];
            }
            if(reader[53] != DBNull.Value)
            {
                H0090002 = (System.Nullable<System.Int32>)reader[53];
            }
            if(reader[54] != DBNull.Value)
            {
                H0090003 = (System.Nullable<System.Int32>)reader[54];
            }
            if(reader[55] != DBNull.Value)
            {
                H0090004 = (System.Nullable<System.Int32>)reader[55];
            }
            if(reader[56] != DBNull.Value)
            {
                H0090005 = (System.Nullable<System.Int32>)reader[56];
            }
            if(reader[57] != DBNull.Value)
            {
                H0090006 = (System.Nullable<System.Int32>)reader[57];
            }
            if(reader[58] != DBNull.Value)
            {
                H0090007 = (System.Nullable<System.Int32>)reader[58];
            }
            if(reader[59] != DBNull.Value)
            {
                H0090008 = (System.Nullable<System.Int32>)reader[59];
            }
            if(reader[60] != DBNull.Value)
            {
                H0090009 = (System.Nullable<System.Int32>)reader[60];
            }
            if(reader[61] != DBNull.Value)
            {
                H0090010 = (System.Nullable<System.Int32>)reader[61];
            }
            if(reader[62] != DBNull.Value)
            {
                H0090011 = (System.Nullable<System.Int32>)reader[62];
            }
            if(reader[63] != DBNull.Value)
            {
                H0090012 = (System.Nullable<System.Int32>)reader[63];
            }
            if(reader[64] != DBNull.Value)
            {
                H0090013 = (System.Nullable<System.Int32>)reader[64];
            }
            if(reader[65] != DBNull.Value)
            {
                H0090014 = (System.Nullable<System.Int32>)reader[65];
            }
            if(reader[66] != DBNull.Value)
            {
                H0090015 = (System.Nullable<System.Int32>)reader[66];
            }
            if(reader[67] != DBNull.Value)
            {
                H0100001 = (System.Nullable<System.Int32>)reader[67];
            }
            if(reader[68] != DBNull.Value)
            {
                H0110001 = (System.Nullable<System.Int32>)reader[68];
            }
            if(reader[69] != DBNull.Value)
            {
                H0110002 = (System.Nullable<System.Int32>)reader[69];
            }
            if(reader[70] != DBNull.Value)
            {
                H0110003 = (System.Nullable<System.Int32>)reader[70];
            }
            if(reader[71] != DBNull.Value)
            {
                H0110004 = (System.Nullable<System.Int32>)reader[71];
            }
            if(reader[72] != DBNull.Value)
            {
                H0120001 = (System.Nullable<System.Double>)reader[72];
            }
            if(reader[73] != DBNull.Value)
            {
                H0120002 = (System.Nullable<System.Double>)reader[73];
            }
            if(reader[74] != DBNull.Value)
            {
                H0120003 = (System.Nullable<System.Double>)reader[74];
            }
            if(reader[75] != DBNull.Value)
            {
                H0130001 = (System.Nullable<System.Int32>)reader[75];
            }
            if(reader[76] != DBNull.Value)
            {
                H0130002 = (System.Nullable<System.Int32>)reader[76];
            }
            if(reader[77] != DBNull.Value)
            {
                H0130003 = (System.Nullable<System.Int32>)reader[77];
            }
            if(reader[78] != DBNull.Value)
            {
                H0130004 = (System.Nullable<System.Int32>)reader[78];
            }
            if(reader[79] != DBNull.Value)
            {
                H0130005 = (System.Nullable<System.Int32>)reader[79];
            }
            if(reader[80] != DBNull.Value)
            {
                H0130006 = (System.Nullable<System.Int32>)reader[80];
            }
            if(reader[81] != DBNull.Value)
            {
                H0130007 = (System.Nullable<System.Int32>)reader[81];
            }
            if(reader[82] != DBNull.Value)
            {
                H0130008 = (System.Nullable<System.Int32>)reader[82];
            }
            if(reader[83] != DBNull.Value)
            {
                H0140001 = (System.Nullable<System.Int32>)reader[83];
            }
            if(reader[84] != DBNull.Value)
            {
                H0140002 = (System.Nullable<System.Int32>)reader[84];
            }
            if(reader[85] != DBNull.Value)
            {
                H0140003 = (System.Nullable<System.Int32>)reader[85];
            }
            if(reader[86] != DBNull.Value)
            {
                H0140004 = (System.Nullable<System.Int32>)reader[86];
            }
            if(reader[87] != DBNull.Value)
            {
                H0140005 = (System.Nullable<System.Int32>)reader[87];
            }
            if(reader[88] != DBNull.Value)
            {
                H0140006 = (System.Nullable<System.Int32>)reader[88];
            }
            if(reader[89] != DBNull.Value)
            {
                H0140007 = (System.Nullable<System.Int32>)reader[89];
            }
            if(reader[90] != DBNull.Value)
            {
                H0140008 = (System.Nullable<System.Int32>)reader[90];
            }
            if(reader[91] != DBNull.Value)
            {
                H0140009 = (System.Nullable<System.Int32>)reader[91];
            }
            if(reader[92] != DBNull.Value)
            {
                H0140010 = (System.Nullable<System.Int32>)reader[92];
            }
            if(reader[93] != DBNull.Value)
            {
                H0140011 = (System.Nullable<System.Int32>)reader[93];
            }
            if(reader[94] != DBNull.Value)
            {
                H0140012 = (System.Nullable<System.Int32>)reader[94];
            }
            if(reader[95] != DBNull.Value)
            {
                H0140013 = (System.Nullable<System.Int32>)reader[95];
            }
            if(reader[96] != DBNull.Value)
            {
                H0140014 = (System.Nullable<System.Int32>)reader[96];
            }
            if(reader[97] != DBNull.Value)
            {
                H0140015 = (System.Nullable<System.Int32>)reader[97];
            }
            if(reader[98] != DBNull.Value)
            {
                H0140016 = (System.Nullable<System.Int32>)reader[98];
            }
            if(reader[99] != DBNull.Value)
            {
                H0140017 = (System.Nullable<System.Int32>)reader[99];
            }
            if(reader[100] != DBNull.Value)
            {
                H0150001 = (System.Nullable<System.Int32>)reader[100];
            }
            if(reader[101] != DBNull.Value)
            {
                H0150002 = (System.Nullable<System.Int32>)reader[101];
            }
            if(reader[102] != DBNull.Value)
            {
                H0150003 = (System.Nullable<System.Int32>)reader[102];
            }
            if(reader[103] != DBNull.Value)
            {
                H0150004 = (System.Nullable<System.Int32>)reader[103];
            }
            if(reader[104] != DBNull.Value)
            {
                H0150005 = (System.Nullable<System.Int32>)reader[104];
            }
            if(reader[105] != DBNull.Value)
            {
                H0150006 = (System.Nullable<System.Int32>)reader[105];
            }
            if(reader[106] != DBNull.Value)
            {
                H0150007 = (System.Nullable<System.Int32>)reader[106];
            }
            if(reader[107] != DBNull.Value)
            {
                H0160001 = (System.Nullable<System.Int32>)reader[107];
            }
            if(reader[108] != DBNull.Value)
            {
                H0160002 = (System.Nullable<System.Int32>)reader[108];
            }
            if(reader[109] != DBNull.Value)
            {
                H0160003 = (System.Nullable<System.Int32>)reader[109];
            }
            if(reader[110] != DBNull.Value)
            {
                H0160004 = (System.Nullable<System.Int32>)reader[110];
            }
            if(reader[111] != DBNull.Value)
            {
                H0160005 = (System.Nullable<System.Int32>)reader[111];
            }
            if(reader[112] != DBNull.Value)
            {
                H0160006 = (System.Nullable<System.Int32>)reader[112];
            }
            if(reader[113] != DBNull.Value)
            {
                H0160007 = (System.Nullable<System.Int32>)reader[113];
            }
            if(reader[114] != DBNull.Value)
            {
                H0160008 = (System.Nullable<System.Int32>)reader[114];
            }
            if(reader[115] != DBNull.Value)
            {
                H0160009 = (System.Nullable<System.Int32>)reader[115];
            }
            if(reader[116] != DBNull.Value)
            {
                H0160010 = (System.Nullable<System.Int32>)reader[116];
            }
            if(reader[117] != DBNull.Value)
            {
                H0160011 = (System.Nullable<System.Int32>)reader[117];
            }
            if(reader[118] != DBNull.Value)
            {
                H0160012 = (System.Nullable<System.Int32>)reader[118];
            }
            if(reader[119] != DBNull.Value)
            {
                H0160013 = (System.Nullable<System.Int32>)reader[119];
            }
            if(reader[120] != DBNull.Value)
            {
                H0160014 = (System.Nullable<System.Int32>)reader[120];
            }
            if(reader[121] != DBNull.Value)
            {
                H0160015 = (System.Nullable<System.Int32>)reader[121];
            }
            if(reader[122] != DBNull.Value)
            {
                H0160016 = (System.Nullable<System.Int32>)reader[122];
            }
            if(reader[123] != DBNull.Value)
            {
                H0160017 = (System.Nullable<System.Int32>)reader[123];
            }
            if(reader[124] != DBNull.Value)
            {
                H0170001 = (System.Nullable<System.Int32>)reader[124];
            }
            if(reader[125] != DBNull.Value)
            {
                H0170002 = (System.Nullable<System.Int32>)reader[125];
            }
            if(reader[126] != DBNull.Value)
            {
                H0170003 = (System.Nullable<System.Int32>)reader[126];
            }
            if(reader[127] != DBNull.Value)
            {
                H0170004 = (System.Nullable<System.Int32>)reader[127];
            }
            if(reader[128] != DBNull.Value)
            {
                H0170005 = (System.Nullable<System.Int32>)reader[128];
            }
            if(reader[129] != DBNull.Value)
            {
                H0170006 = (System.Nullable<System.Int32>)reader[129];
            }
            if(reader[130] != DBNull.Value)
            {
                H0170007 = (System.Nullable<System.Int32>)reader[130];
            }
            if(reader[131] != DBNull.Value)
            {
                H0170008 = (System.Nullable<System.Int32>)reader[131];
            }
            if(reader[132] != DBNull.Value)
            {
                H0170009 = (System.Nullable<System.Int32>)reader[132];
            }
            if(reader[133] != DBNull.Value)
            {
                H0170010 = (System.Nullable<System.Int32>)reader[133];
            }
            if(reader[134] != DBNull.Value)
            {
                H0170011 = (System.Nullable<System.Int32>)reader[134];
            }
            if(reader[135] != DBNull.Value)
            {
                H0170012 = (System.Nullable<System.Int32>)reader[135];
            }
            if(reader[136] != DBNull.Value)
            {
                H0170013 = (System.Nullable<System.Int32>)reader[136];
            }
            if(reader[137] != DBNull.Value)
            {
                H0170014 = (System.Nullable<System.Int32>)reader[137];
            }
            if(reader[138] != DBNull.Value)
            {
                H0170015 = (System.Nullable<System.Int32>)reader[138];
            }
            if(reader[139] != DBNull.Value)
            {
                H0170016 = (System.Nullable<System.Int32>)reader[139];
            }
            if(reader[140] != DBNull.Value)
            {
                H0170017 = (System.Nullable<System.Int32>)reader[140];
            }
            if(reader[141] != DBNull.Value)
            {
                H0170018 = (System.Nullable<System.Int32>)reader[141];
            }
            if(reader[142] != DBNull.Value)
            {
                H0170019 = (System.Nullable<System.Int32>)reader[142];
            }
            if(reader[143] != DBNull.Value)
            {
                H0170020 = (System.Nullable<System.Int32>)reader[143];
            }
            if(reader[144] != DBNull.Value)
            {
                H0170021 = (System.Nullable<System.Int32>)reader[144];
            }
            if(reader[145] != DBNull.Value)
            {
                H0180001 = (System.Nullable<System.Int32>)reader[145];
            }
            if(reader[146] != DBNull.Value)
            {
                H0180002 = (System.Nullable<System.Int32>)reader[146];
            }
            if(reader[147] != DBNull.Value)
            {
                H0180003 = (System.Nullable<System.Int32>)reader[147];
            }
            if(reader[148] != DBNull.Value)
            {
                H0180004 = (System.Nullable<System.Int32>)reader[148];
            }
            if(reader[149] != DBNull.Value)
            {
                H0180005 = (System.Nullable<System.Int32>)reader[149];
            }
            if(reader[150] != DBNull.Value)
            {
                H0180006 = (System.Nullable<System.Int32>)reader[150];
            }
            if(reader[151] != DBNull.Value)
            {
                H0180007 = (System.Nullable<System.Int32>)reader[151];
            }
            if(reader[152] != DBNull.Value)
            {
                H0180008 = (System.Nullable<System.Int32>)reader[152];
            }
            if(reader[153] != DBNull.Value)
            {
                H0180009 = (System.Nullable<System.Int32>)reader[153];
            }
            if(reader[154] != DBNull.Value)
            {
                H0180010 = (System.Nullable<System.Int32>)reader[154];
            }
            if(reader[155] != DBNull.Value)
            {
                H0180011 = (System.Nullable<System.Int32>)reader[155];
            }
            if(reader[156] != DBNull.Value)
            {
                H0180012 = (System.Nullable<System.Int32>)reader[156];
            }
            if(reader[157] != DBNull.Value)
            {
                H0180013 = (System.Nullable<System.Int32>)reader[157];
            }
            if(reader[158] != DBNull.Value)
            {
                H0180014 = (System.Nullable<System.Int32>)reader[158];
            }
            if(reader[159] != DBNull.Value)
            {
                H0180015 = (System.Nullable<System.Int32>)reader[159];
            }
            if(reader[160] != DBNull.Value)
            {
                H0180016 = (System.Nullable<System.Int32>)reader[160];
            }
            if(reader[161] != DBNull.Value)
            {
                H0180017 = (System.Nullable<System.Int32>)reader[161];
            }
            if(reader[162] != DBNull.Value)
            {
                H0180018 = (System.Nullable<System.Int32>)reader[162];
            }
            if(reader[163] != DBNull.Value)
            {
                H0180019 = (System.Nullable<System.Int32>)reader[163];
            }
            if(reader[164] != DBNull.Value)
            {
                H0180020 = (System.Nullable<System.Int32>)reader[164];
            }
            if(reader[165] != DBNull.Value)
            {
                H0180021 = (System.Nullable<System.Int32>)reader[165];
            }
            if(reader[166] != DBNull.Value)
            {
                H0180022 = (System.Nullable<System.Int32>)reader[166];
            }
            if(reader[167] != DBNull.Value)
            {
                H0180023 = (System.Nullable<System.Int32>)reader[167];
            }
            if(reader[168] != DBNull.Value)
            {
                H0180024 = (System.Nullable<System.Int32>)reader[168];
            }
            if(reader[169] != DBNull.Value)
            {
                H0180025 = (System.Nullable<System.Int32>)reader[169];
            }
            if(reader[170] != DBNull.Value)
            {
                H0180026 = (System.Nullable<System.Int32>)reader[170];
            }
            if(reader[171] != DBNull.Value)
            {
                H0180027 = (System.Nullable<System.Int32>)reader[171];
            }
            if(reader[172] != DBNull.Value)
            {
                H0180028 = (System.Nullable<System.Int32>)reader[172];
            }
            if(reader[173] != DBNull.Value)
            {
                H0180029 = (System.Nullable<System.Int32>)reader[173];
            }
            if(reader[174] != DBNull.Value)
            {
                H0180030 = (System.Nullable<System.Int32>)reader[174];
            }
            if(reader[175] != DBNull.Value)
            {
                H0180031 = (System.Nullable<System.Int32>)reader[175];
            }
            if(reader[176] != DBNull.Value)
            {
                H0180032 = (System.Nullable<System.Int32>)reader[176];
            }
            if(reader[177] != DBNull.Value)
            {
                H0180033 = (System.Nullable<System.Int32>)reader[177];
            }
            if(reader[178] != DBNull.Value)
            {
                H0180034 = (System.Nullable<System.Int32>)reader[178];
            }
            if(reader[179] != DBNull.Value)
            {
                H0180035 = (System.Nullable<System.Int32>)reader[179];
            }
            if(reader[180] != DBNull.Value)
            {
                H0180036 = (System.Nullable<System.Int32>)reader[180];
            }
            if(reader[181] != DBNull.Value)
            {
                H0180037 = (System.Nullable<System.Int32>)reader[181];
            }
            if(reader[182] != DBNull.Value)
            {
                H0180038 = (System.Nullable<System.Int32>)reader[182];
            }
            if(reader[183] != DBNull.Value)
            {
                H0180039 = (System.Nullable<System.Int32>)reader[183];
            }
            if(reader[184] != DBNull.Value)
            {
                H0180040 = (System.Nullable<System.Int32>)reader[184];
            }
            if(reader[185] != DBNull.Value)
            {
                H0180041 = (System.Nullable<System.Int32>)reader[185];
            }
            if(reader[186] != DBNull.Value)
            {
                H0180042 = (System.Nullable<System.Int32>)reader[186];
            }
            if(reader[187] != DBNull.Value)
            {
                H0180043 = (System.Nullable<System.Int32>)reader[187];
            }
            if(reader[188] != DBNull.Value)
            {
                H0180044 = (System.Nullable<System.Int32>)reader[188];
            }
            if(reader[189] != DBNull.Value)
            {
                H0180045 = (System.Nullable<System.Int32>)reader[189];
            }
            if(reader[190] != DBNull.Value)
            {
                H0180046 = (System.Nullable<System.Int32>)reader[190];
            }
            if(reader[191] != DBNull.Value)
            {
                H0180047 = (System.Nullable<System.Int32>)reader[191];
            }
            if(reader[192] != DBNull.Value)
            {
                H0180048 = (System.Nullable<System.Int32>)reader[192];
            }
            if(reader[193] != DBNull.Value)
            {
                H0180049 = (System.Nullable<System.Int32>)reader[193];
            }
            if(reader[194] != DBNull.Value)
            {
                H0180050 = (System.Nullable<System.Int32>)reader[194];
            }
            if(reader[195] != DBNull.Value)
            {
                H0180051 = (System.Nullable<System.Int32>)reader[195];
            }
            if(reader[196] != DBNull.Value)
            {
                H0180052 = (System.Nullable<System.Int32>)reader[196];
            }
            if(reader[197] != DBNull.Value)
            {
                H0180053 = (System.Nullable<System.Int32>)reader[197];
            }
            if(reader[198] != DBNull.Value)
            {
                H0180054 = (System.Nullable<System.Int32>)reader[198];
            }
            if(reader[199] != DBNull.Value)
            {
                H0180055 = (System.Nullable<System.Int32>)reader[199];
            }
            if(reader[200] != DBNull.Value)
            {
                H0180056 = (System.Nullable<System.Int32>)reader[200];
            }
            if(reader[201] != DBNull.Value)
            {
                H0180057 = (System.Nullable<System.Int32>)reader[201];
            }
            if(reader[202] != DBNull.Value)
            {
                H0180058 = (System.Nullable<System.Int32>)reader[202];
            }
            if(reader[203] != DBNull.Value)
            {
                H0180059 = (System.Nullable<System.Int32>)reader[203];
            }
            if(reader[204] != DBNull.Value)
            {
                H0180060 = (System.Nullable<System.Int32>)reader[204];
            }
            if(reader[205] != DBNull.Value)
            {
                H0180061 = (System.Nullable<System.Int32>)reader[205];
            }
            if(reader[206] != DBNull.Value)
            {
                H0180062 = (System.Nullable<System.Int32>)reader[206];
            }
            if(reader[207] != DBNull.Value)
            {
                H0180063 = (System.Nullable<System.Int32>)reader[207];
            }
            if(reader[208] != DBNull.Value)
            {
                H0180064 = (System.Nullable<System.Int32>)reader[208];
            }
            if(reader[209] != DBNull.Value)
            {
                H0180065 = (System.Nullable<System.Int32>)reader[209];
            }
            if(reader[210] != DBNull.Value)
            {
                H0180066 = (System.Nullable<System.Int32>)reader[210];
            }
            if(reader[211] != DBNull.Value)
            {
                H0180067 = (System.Nullable<System.Int32>)reader[211];
            }
            if(reader[212] != DBNull.Value)
            {
                H0180068 = (System.Nullable<System.Int32>)reader[212];
            }
            if(reader[213] != DBNull.Value)
            {
                H0180069 = (System.Nullable<System.Int32>)reader[213];
            }
            if(reader[214] != DBNull.Value)
            {
                H0190001 = (System.Nullable<System.Int32>)reader[214];
            }
            if(reader[215] != DBNull.Value)
            {
                H0190002 = (System.Nullable<System.Int32>)reader[215];
            }
            if(reader[216] != DBNull.Value)
            {
                H0190003 = (System.Nullable<System.Int32>)reader[216];
            }
            if(reader[217] != DBNull.Value)
            {
                H0190004 = (System.Nullable<System.Int32>)reader[217];
            }
            if(reader[218] != DBNull.Value)
            {
                H0190005 = (System.Nullable<System.Int32>)reader[218];
            }
            if(reader[219] != DBNull.Value)
            {
                H0190006 = (System.Nullable<System.Int32>)reader[219];
            }
            if(reader[220] != DBNull.Value)
            {
                H0190007 = (System.Nullable<System.Int32>)reader[220];
            }
            if(reader[221] != DBNull.Value)
            {
                H0200001 = (System.Nullable<System.Int32>)reader[221];
            }
            if(reader[222] != DBNull.Value)
            {
                H0200002 = (System.Nullable<System.Int32>)reader[222];
            }
            if(reader[223] != DBNull.Value)
            {
                H0200003 = (System.Nullable<System.Int32>)reader[223];
            }
            if(reader[224] != DBNull.Value)
            {
                H0210001 = (System.Nullable<System.Int32>)reader[224];
            }
            if(reader[225] != DBNull.Value)
            {
                H0210002 = (System.Nullable<System.Int32>)reader[225];
            }
            if(reader[226] != DBNull.Value)
            {
                H0210003 = (System.Nullable<System.Int32>)reader[226];
            }
            if(reader[227] != DBNull.Value)
            {
                H0220001 = (System.Nullable<System.Int32>)reader[227];
            }
            if(reader[228] != DBNull.Value)
            {
                H0220002 = (System.Nullable<System.Int32>)reader[228];
            }
            if(reader[229] != DBNull.Value)
            {
                H0220003 = (System.Nullable<System.Int32>)reader[229];
            }
            if(reader[230] != DBNull.Value)
            {
                H011A0001 = (System.Nullable<System.Int32>)reader[230];
            }
            if(reader[231] != DBNull.Value)
            {
                H011A0002 = (System.Nullable<System.Int32>)reader[231];
            }
            if(reader[232] != DBNull.Value)
            {
                H011A0003 = (System.Nullable<System.Int32>)reader[232];
            }
            if(reader[233] != DBNull.Value)
            {
                H011A0004 = (System.Nullable<System.Int32>)reader[233];
            }
            if(reader[234] != DBNull.Value)
            {
                H011B0001 = (System.Nullable<System.Int32>)reader[234];
            }
            if(reader[235] != DBNull.Value)
            {
                H011B0002 = (System.Nullable<System.Int32>)reader[235];
            }
            if(reader[236] != DBNull.Value)
            {
                H011B0003 = (System.Nullable<System.Int32>)reader[236];
            }
            if(reader[237] != DBNull.Value)
            {
                H011B0004 = (System.Nullable<System.Int32>)reader[237];
            }
            if(reader[238] != DBNull.Value)
            {
                H011C0001 = (System.Nullable<System.Int32>)reader[238];
            }
            if(reader[239] != DBNull.Value)
            {
                H011C0002 = (System.Nullable<System.Int32>)reader[239];
            }
            if(reader[240] != DBNull.Value)
            {
                H011C0003 = (System.Nullable<System.Int32>)reader[240];
            }
            if(reader[241] != DBNull.Value)
            {
                H011C0004 = (System.Nullable<System.Int32>)reader[241];
            }
            if(reader[242] != DBNull.Value)
            {
                H011D0001 = (System.Nullable<System.Int32>)reader[242];
            }
            if(reader[243] != DBNull.Value)
            {
                H011D0002 = (System.Nullable<System.Int32>)reader[243];
            }
            if(reader[244] != DBNull.Value)
            {
                H011D0003 = (System.Nullable<System.Int32>)reader[244];
            }
            if(reader[245] != DBNull.Value)
            {
                H011D0004 = (System.Nullable<System.Int32>)reader[245];
            }
            if(reader[246] != DBNull.Value)
            {
                H011E0001 = (System.Nullable<System.Int32>)reader[246];
            }
            if(reader[247] != DBNull.Value)
            {
                H011E0002 = (System.Nullable<System.Int32>)reader[247];
            }
            if(reader[248] != DBNull.Value)
            {
                H011E0003 = (System.Nullable<System.Int32>)reader[248];
            }
            if(reader[249] != DBNull.Value)
            {
                H011E0004 = (System.Nullable<System.Int32>)reader[249];
            }
            if(reader[250] != DBNull.Value)
            {
                H011F0001 = (System.Nullable<System.Int32>)reader[250];
            }
            if(reader[251] != DBNull.Value)
            {
                H011F0002 = (System.Nullable<System.Int32>)reader[251];
            }
            if(reader[252] != DBNull.Value)
            {
                H011F0003 = (System.Nullable<System.Int32>)reader[252];
            }
            if(reader[253] != DBNull.Value)
            {
                H011F0004 = (System.Nullable<System.Int32>)reader[253];
            }
        }
        #endregion Constructors
    }
}