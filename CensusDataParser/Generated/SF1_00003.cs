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

    [Table("SF1_00003")]
    public partial class SF1_00003 : BaseModel
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
        [Column("P0030001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public System.Nullable<System.Int32> P0030001 { get; set; }

        [ReadOnly(false)]
        [Column("P0030002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of one race:", ShortName = "Population of one race:", Order = 6)]
        public System.Nullable<System.Int32> P0030002 { get; set; }

        [ReadOnly(false)]
        [Column("P0030003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White alone", ShortName = "White alone", Order = 7)]
        public System.Nullable<System.Int32> P0030003 { get; set; }

        [ReadOnly(false)]
        [Column("P0030004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American alone", ShortName = "Black or African American alone", Order = 8)]
        public System.Nullable<System.Int32> P0030004 { get; set; }

        [ReadOnly(false)]
        [Column("P0030005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native alone", ShortName = "American Indian and Alaska Native alone", Order = 9)]
        public System.Nullable<System.Int32> P0030005 { get; set; }

        [ReadOnly(false)]
        [Column("P0030006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian alone", ShortName = "Asian alone", Order = 10)]
        public System.Nullable<System.Int32> P0030006 { get; set; }

        [ReadOnly(false)]
        [Column("P0030007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander alone", ShortName = "Native Hawaiian and Other Pacific Islander alone", Order = 11)]
        public System.Nullable<System.Int32> P0030007 { get; set; }

        [ReadOnly(false)]
        [Column("P0030008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Some Other Race alone", ShortName = "Some Other Race alone", Order = 12)]
        public System.Nullable<System.Int32> P0030008 { get; set; }

        [ReadOnly(false)]
        [Column("P0040001", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 13)]
        public System.Nullable<System.Int32> P0040001 { get; set; }

        [ReadOnly(false)]
        [Column("P0040002", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hispanic or Latino", ShortName = "Hispanic or Latino", Order = 14)]
        public System.Nullable<System.Int32> P0040002 { get; set; }

        [ReadOnly(false)]
        [Column("P0040003", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not Hispanic or Latino:", ShortName = "Not Hispanic or Latino:", Order = 15)]
        public System.Nullable<System.Int32> P0040003 { get; set; }

        [ReadOnly(false)]
        [Column("P0050001", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 16)]
        public System.Nullable<System.Int32> P0050001 { get; set; }

        [ReadOnly(false)]
        [Column("P0050002", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not Hispanic or Latino:", ShortName = "Not Hispanic or Latino:", Order = 17)]
        public System.Nullable<System.Int32> P0050002 { get; set; }

        [ReadOnly(false)]
        [Column("P0050003", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White alone", ShortName = "White alone", Order = 18)]
        public System.Nullable<System.Int32> P0050003 { get; set; }

        [ReadOnly(false)]
        [Column("P0050004", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American alone", ShortName = "Black or African American alone", Order = 19)]
        public System.Nullable<System.Int32> P0050004 { get; set; }

        [ReadOnly(false)]
        [Column("P0050005", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native alone", ShortName = "American Indian and Alaska Native alone", Order = 20)]
        public System.Nullable<System.Int32> P0050005 { get; set; }

        [ReadOnly(false)]
        [Column("P0050006", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian alone", ShortName = "Asian alone", Order = 21)]
        public System.Nullable<System.Int32> P0050006 { get; set; }

        [ReadOnly(false)]
        [Column("P0050007", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander alone", ShortName = "Native Hawaiian and Other Pacific Islander alone", Order = 22)]
        public System.Nullable<System.Int32> P0050007 { get; set; }

        [ReadOnly(false)]
        [Column("P0050008", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Some Other Race alone", ShortName = "Some Other Race alone", Order = 23)]
        public System.Nullable<System.Int32> P0050008 { get; set; }

        [ReadOnly(false)]
        [Column("P0050009", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Two or More Races", ShortName = "Two or More Races", Order = 24)]
        public System.Nullable<System.Int32> P0050009 { get; set; }

        [ReadOnly(false)]
        [Column("P0050010", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hispanic or Latino:", ShortName = "Hispanic or Latino:", Order = 25)]
        public System.Nullable<System.Int32> P0050010 { get; set; }

        [ReadOnly(false)]
        [Column("P0050011", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White alone", ShortName = "White alone", Order = 26)]
        public System.Nullable<System.Int32> P0050011 { get; set; }

        [ReadOnly(false)]
        [Column("P0050012", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American alone", ShortName = "Black or African American alone", Order = 27)]
        public System.Nullable<System.Int32> P0050012 { get; set; }

        [ReadOnly(false)]
        [Column("P0050013", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native alone", ShortName = "American Indian and Alaska Native alone", Order = 28)]
        public System.Nullable<System.Int32> P0050013 { get; set; }

        [ReadOnly(false)]
        [Column("P0050014", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian alone", ShortName = "Asian alone", Order = 29)]
        public System.Nullable<System.Int32> P0050014 { get; set; }

        [ReadOnly(false)]
        [Column("P0050015", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander alone", ShortName = "Native Hawaiian and Other Pacific Islander alone", Order = 30)]
        public System.Nullable<System.Int32> P0050015 { get; set; }

        [ReadOnly(false)]
        [Column("P0050016", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Some Other Race alone", ShortName = "Some Other Race alone", Order = 31)]
        public System.Nullable<System.Int32> P0050016 { get; set; }

        [ReadOnly(false)]
        [Column("P0050017", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Two or More Races", ShortName = "Two or More Races", Order = 32)]
        public System.Nullable<System.Int32> P0050017 { get; set; }

        [ReadOnly(false)]
        [Column("P0060001", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total races tallied:", ShortName = "Total races tallied:", Order = 33)]
        public System.Nullable<System.Int32> P0060001 { get; set; }

        [ReadOnly(false)]
        [Column("P0060002", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White alone or in combination with one or more other races", ShortName = "White alone or in combination with one or more other races", Order = 34)]
        public System.Nullable<System.Int32> P0060002 { get; set; }

        [ReadOnly(false)]
        [Column("P0060003", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American alone or in combination with one or more other races", ShortName = "Black or African American alone or in combination with one or more other races", Order = 35)]
        public System.Nullable<System.Int32> P0060003 { get; set; }

        [ReadOnly(false)]
        [Column("P0060004", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native alone or in combination with one or more other races", ShortName = "American Indian and Alaska Native alone or in combination with one or more other races", Order = 36)]
        public System.Nullable<System.Int32> P0060004 { get; set; }

        [ReadOnly(false)]
        [Column("P0060005", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian alone or in combination with one or more other races", ShortName = "Asian alone or in combination with one or more other races", Order = 37)]
        public System.Nullable<System.Int32> P0060005 { get; set; }

        [ReadOnly(false)]
        [Column("P0060006", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander alone or in combination with one or more other races", ShortName = "Native Hawaiian and Other Pacific Islander alone or in combination with one or more other races", Order = 38)]
        public System.Nullable<System.Int32> P0060006 { get; set; }

        [ReadOnly(false)]
        [Column("P0060007", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Some Other Race alone or in combination with one or more other races", ShortName = "Some Other Race alone or in combination with one or more other races", Order = 39)]
        public System.Nullable<System.Int32> P0060007 { get; set; }

        [ReadOnly(false)]
        [Column("P0070001", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total races tallied:", ShortName = "Total races tallied:", Order = 40)]
        public System.Nullable<System.Int32> P0070001 { get; set; }

        [ReadOnly(false)]
        [Column("P0070002", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not Hispanic or Latino:", ShortName = "Not Hispanic or Latino:", Order = 41)]
        public System.Nullable<System.Int32> P0070002 { get; set; }

        [ReadOnly(false)]
        [Column("P0070003", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White alone or in combination with one or more other races", ShortName = "White alone or in combination with one or more other races", Order = 42)]
        public System.Nullable<System.Int32> P0070003 { get; set; }

        [ReadOnly(false)]
        [Column("P0070004", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American alone or in combination with one or more other races", ShortName = "Black or African American alone or in combination with one or more other races", Order = 43)]
        public System.Nullable<System.Int32> P0070004 { get; set; }

        [ReadOnly(false)]
        [Column("P0070005", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native alone or in combination with one or more other races", ShortName = "American Indian and Alaska Native alone or in combination with one or more other races", Order = 44)]
        public System.Nullable<System.Int32> P0070005 { get; set; }

        [ReadOnly(false)]
        [Column("P0070006", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian alone or in combination with one or more other races", ShortName = "Asian alone or in combination with one or more other races", Order = 45)]
        public System.Nullable<System.Int32> P0070006 { get; set; }

        [ReadOnly(false)]
        [Column("P0070007", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander alone or in combination with one or more other races", ShortName = "Native Hawaiian and Other Pacific Islander alone or in combination with one or more other races", Order = 46)]
        public System.Nullable<System.Int32> P0070007 { get; set; }

        [ReadOnly(false)]
        [Column("P0070008", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Some Other Race alone or in combination with one or more other races", ShortName = "Some Other Race alone or in combination with one or more other races", Order = 47)]
        public System.Nullable<System.Int32> P0070008 { get; set; }

        [ReadOnly(false)]
        [Column("P0070009", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hispanic or Latino:", ShortName = "Hispanic or Latino:", Order = 48)]
        public System.Nullable<System.Int32> P0070009 { get; set; }

        [ReadOnly(false)]
        [Column("P0070010", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White alone or in combination with one or more other races", ShortName = "White alone or in combination with one or more other races", Order = 49)]
        public System.Nullable<System.Int32> P0070010 { get; set; }

        [ReadOnly(false)]
        [Column("P0070011", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American alone or in combination with one or more other races", ShortName = "Black or African American alone or in combination with one or more other races", Order = 50)]
        public System.Nullable<System.Int32> P0070011 { get; set; }

        [ReadOnly(false)]
        [Column("P0070012", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native alone or in combination with one or more other races", ShortName = "American Indian and Alaska Native alone or in combination with one or more other races", Order = 51)]
        public System.Nullable<System.Int32> P0070012 { get; set; }

        [ReadOnly(false)]
        [Column("P0070013", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian alone or in combination with one or more other races", ShortName = "Asian alone or in combination with one or more other races", Order = 52)]
        public System.Nullable<System.Int32> P0070013 { get; set; }

        [ReadOnly(false)]
        [Column("P0070014", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander alone or in combination with one or more other races", ShortName = "Native Hawaiian and Other Pacific Islander alone or in combination with one or more other races", Order = 53)]
        public System.Nullable<System.Int32> P0070014 { get; set; }

        [ReadOnly(false)]
        [Column("P0070015", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Some Other Race alone or in combination with one or more other races", ShortName = "Some Other Race alone or in combination with one or more other races", Order = 54)]
        public System.Nullable<System.Int32> P0070015 { get; set; }

        [ReadOnly(false)]
        [Column("P0080001", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 55)]
        public System.Nullable<System.Int32> P0080001 { get; set; }

        [ReadOnly(false)]
        [Column("P0080002", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of one race:", ShortName = "Population of one race:", Order = 56)]
        public System.Nullable<System.Int32> P0080002 { get; set; }

        [ReadOnly(false)]
        [Column("P0080003", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White alone", ShortName = "White alone", Order = 57)]
        public System.Nullable<System.Int32> P0080003 { get; set; }

        [ReadOnly(false)]
        [Column("P0080004", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American alone", ShortName = "Black or African American alone", Order = 58)]
        public System.Nullable<System.Int32> P0080004 { get; set; }

        [ReadOnly(false)]
        [Column("P0080005", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native alone", ShortName = "American Indian and Alaska Native alone", Order = 59)]
        public System.Nullable<System.Int32> P0080005 { get; set; }

        [ReadOnly(false)]
        [Column("P0080006", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian alone", ShortName = "Asian alone", Order = 60)]
        public System.Nullable<System.Int32> P0080006 { get; set; }

        [ReadOnly(false)]
        [Column("P0080007", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander alone", ShortName = "Native Hawaiian and Other Pacific Islander alone", Order = 61)]
        public System.Nullable<System.Int32> P0080007 { get; set; }

        [ReadOnly(false)]
        [Column("P0080008", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Some Other Race alone", ShortName = "Some Other Race alone", Order = 62)]
        public System.Nullable<System.Int32> P0080008 { get; set; }

        [ReadOnly(false)]
        [Column("P0080009", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Two or More Races:", ShortName = "Two or More Races:", Order = 63)]
        public System.Nullable<System.Int32> P0080009 { get; set; }

        [ReadOnly(false)]
        [Column("P0080010", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of two races:", ShortName = "Population of two races:", Order = 64)]
        public System.Nullable<System.Int32> P0080010 { get; set; }

        [ReadOnly(false)]
        [Column("P0080011", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American", ShortName = "White; Black or African American", Order = 65)]
        public System.Nullable<System.Int32> P0080011 { get; set; }

        [ReadOnly(false)]
        [Column("P0080012", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native", ShortName = "White; American Indian and Alaska Native", Order = 66)]
        public System.Nullable<System.Int32> P0080012 { get; set; }

        [ReadOnly(false)]
        [Column("P0080013", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian", ShortName = "White; Asian", Order = 67)]
        public System.Nullable<System.Int32> P0080013 { get; set; }

        [ReadOnly(false)]
        [Column("P0080014", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Native Hawaiian and Other Pacific Islander", ShortName = "White; Native Hawaiian and Other Pacific Islander", Order = 68)]
        public System.Nullable<System.Int32> P0080014 { get; set; }

        [ReadOnly(false)]
        [Column("P0080015", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Some Other Race", ShortName = "White; Some Other Race", Order = 69)]
        public System.Nullable<System.Int32> P0080015 { get; set; }

        [ReadOnly(false)]
        [Column("P0080016", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native", ShortName = "Black or African American; American Indian and Alaska Native", Order = 70)]
        public System.Nullable<System.Int32> P0080016 { get; set; }

        [ReadOnly(false)]
        [Column("P0080017", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian", ShortName = "Black or African American; Asian", Order = 71)]
        public System.Nullable<System.Int32> P0080017 { get; set; }

        [ReadOnly(false)]
        [Column("P0080018", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander", Order = 72)]
        public System.Nullable<System.Int32> P0080018 { get; set; }

        [ReadOnly(false)]
        [Column("P0080019", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Some Other Race", ShortName = "Black or African American; Some Other Race", Order = 73)]
        public System.Nullable<System.Int32> P0080019 { get; set; }

        [ReadOnly(false)]
        [Column("P0080020", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian", ShortName = "American Indian and Alaska Native; Asian", Order = 74)]
        public System.Nullable<System.Int32> P0080020 { get; set; }

        [ReadOnly(false)]
        [Column("P0080021", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 75)]
        public System.Nullable<System.Int32> P0080021 { get; set; }

        [ReadOnly(false)]
        [Column("P0080022", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Some Other Race", ShortName = "American Indian and Alaska Native; Some Other Race", Order = 76)]
        public System.Nullable<System.Int32> P0080022 { get; set; }

        [ReadOnly(false)]
        [Column("P0080023", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Asian; Native Hawaiian and Other Pacific Islander", Order = 77)]
        public System.Nullable<System.Int32> P0080023 { get; set; }

        [ReadOnly(false)]
        [Column("P0080024", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian; Some Other Race", ShortName = "Asian; Some Other Race", Order = 78)]
        public System.Nullable<System.Int32> P0080024 { get; set; }

        [ReadOnly(false)]
        [Column("P0080025", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 79)]
        public System.Nullable<System.Int32> P0080025 { get; set; }

        [ReadOnly(false)]
        [Column("P0080026", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of three races:", ShortName = "Population of three races:", Order = 80)]
        public System.Nullable<System.Int32> P0080026 { get; set; }

        [ReadOnly(false)]
        [Column("P0080027", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native", ShortName = "White; Black or African American; American Indian and Alaska Native", Order = 81)]
        public System.Nullable<System.Int32> P0080027 { get; set; }

        [ReadOnly(false)]
        [Column("P0080028", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian", ShortName = "White; Black or African American; Asian", Order = 82)]
        public System.Nullable<System.Int32> P0080028 { get; set; }

        [ReadOnly(false)]
        [Column("P0080029", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander", Order = 83)]
        public System.Nullable<System.Int32> P0080029 { get; set; }

        [ReadOnly(false)]
        [Column("P0080030", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Some Other Race", ShortName = "White; Black or African American; Some Other Race", Order = 84)]
        public System.Nullable<System.Int32> P0080030 { get; set; }

        [ReadOnly(false)]
        [Column("P0080031", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian", ShortName = "White; American Indian and Alaska Native; Asian", Order = 85)]
        public System.Nullable<System.Int32> P0080031 { get; set; }

        [ReadOnly(false)]
        [Column("P0080032", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 86)]
        public System.Nullable<System.Int32> P0080032 { get; set; }

        [ReadOnly(false)]
        [Column("P0080033", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Some Other Race", ShortName = "White; American Indian and Alaska Native; Some Other Race", Order = 87)]
        public System.Nullable<System.Int32> P0080033 { get; set; }

        [ReadOnly(false)]
        [Column("P0080034", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander", Order = 88)]
        public System.Nullable<System.Int32> P0080034 { get; set; }

        [ReadOnly(false)]
        [Column("P0080035", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian; Some Other Race", ShortName = "White; Asian; Some Other Race", Order = 89)]
        public System.Nullable<System.Int32> P0080035 { get; set; }

        [ReadOnly(false)]
        [Column("P0080036", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 90)]
        public System.Nullable<System.Int32> P0080036 { get; set; }

        [ReadOnly(false)]
        [Column("P0080037", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian", ShortName = "Black or African American; American Indian and Alaska Native; Asian", Order = 91)]
        public System.Nullable<System.Int32> P0080037 { get; set; }

        [ReadOnly(false)]
        [Column("P0080038", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 92)]
        public System.Nullable<System.Int32> P0080038 { get; set; }

        [ReadOnly(false)]
        [Column("P0080039", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Some Other Race", Order = 93)]
        public System.Nullable<System.Int32> P0080039 { get; set; }

        [ReadOnly(false)]
        [Column("P0080040", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 94)]
        public System.Nullable<System.Int32> P0080040 { get; set; }

        [ReadOnly(false)]
        [Column("P0080041", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian; Some Other Race", ShortName = "Black or African American; Asian; Some Other Race", Order = 95)]
        public System.Nullable<System.Int32> P0080041 { get; set; }

        [ReadOnly(false)]
        [Column("P0080042", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 96)]
        public System.Nullable<System.Int32> P0080042 { get; set; }

        [ReadOnly(false)]
        [Column("P0080043", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 97)]
        public System.Nullable<System.Int32> P0080043 { get; set; }

        [ReadOnly(false)]
        [Column("P0080044", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Some Other Race", Order = 98)]
        public System.Nullable<System.Int32> P0080044 { get; set; }

        [ReadOnly(false)]
        [Column("P0080045", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 99)]
        public System.Nullable<System.Int32> P0080045 { get; set; }

        [ReadOnly(false)]
        [Column("P0080046", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 100)]
        public System.Nullable<System.Int32> P0080046 { get; set; }

        [ReadOnly(false)]
        [Column("P0080047", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of four races:", ShortName = "Population of four races:", Order = 101)]
        public System.Nullable<System.Int32> P0080047 { get; set; }

        [ReadOnly(false)]
        [Column("P0080048", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian", Order = 102)]
        public System.Nullable<System.Int32> P0080048 { get; set; }

        [ReadOnly(false)]
        [Column("P0080049", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 103)]
        public System.Nullable<System.Int32> P0080049 { get; set; }

        [ReadOnly(false)]
        [Column("P0080050", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Some Other Race", Order = 104)]
        public System.Nullable<System.Int32> P0080050 { get; set; }

        [ReadOnly(false)]
        [Column("P0080051", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 105)]
        public System.Nullable<System.Int32> P0080051 { get; set; }

        [ReadOnly(false)]
        [Column("P0080052", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian; Some Other Race", ShortName = "White; Black or African American; Asian; Some Other Race", Order = 106)]
        public System.Nullable<System.Int32> P0080052 { get; set; }

        [ReadOnly(false)]
        [Column("P0080053", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 107)]
        public System.Nullable<System.Int32> P0080053 { get; set; }

        [ReadOnly(false)]
        [Column("P0080054", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 108)]
        public System.Nullable<System.Int32> P0080054 { get; set; }

        [ReadOnly(false)]
        [Column("P0080055", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Some Other Race", Order = 109)]
        public System.Nullable<System.Int32> P0080055 { get; set; }

        [ReadOnly(false)]
        [Column("P0080056", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 110)]
        public System.Nullable<System.Int32> P0080056 { get; set; }

        [ReadOnly(false)]
        [Column("P0080057", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 111)]
        public System.Nullable<System.Int32> P0080057 { get; set; }

        [ReadOnly(false)]
        [Column("P0080058", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 112)]
        public System.Nullable<System.Int32> P0080058 { get; set; }

        [ReadOnly(false)]
        [Column("P0080059", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 113)]
        public System.Nullable<System.Int32> P0080059 { get; set; }

        [ReadOnly(false)]
        [Column("P0080060", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 114)]
        public System.Nullable<System.Int32> P0080060 { get; set; }

        [ReadOnly(false)]
        [Column("P0080061", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 115)]
        public System.Nullable<System.Int32> P0080061 { get; set; }

        [ReadOnly(false)]
        [Column("P0080062", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 116)]
        public System.Nullable<System.Int32> P0080062 { get; set; }

        [ReadOnly(false)]
        [Column("P0080063", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of five races:", ShortName = "Population of five races:", Order = 117)]
        public System.Nullable<System.Int32> P0080063 { get; set; }

        [ReadOnly(false)]
        [Column("P0080064", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 118)]
        public System.Nullable<System.Int32> P0080064 { get; set; }

        [ReadOnly(false)]
        [Column("P0080065", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 119)]
        public System.Nullable<System.Int32> P0080065 { get; set; }

        [ReadOnly(false)]
        [Column("P0080066", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 120)]
        public System.Nullable<System.Int32> P0080066 { get; set; }

        [ReadOnly(false)]
        [Column("P0080067", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 121)]
        public System.Nullable<System.Int32> P0080067 { get; set; }

        [ReadOnly(false)]
        [Column("P0080068", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 122)]
        public System.Nullable<System.Int32> P0080068 { get; set; }

        [ReadOnly(false)]
        [Column("P0080069", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 123)]
        public System.Nullable<System.Int32> P0080069 { get; set; }

        [ReadOnly(false)]
        [Column("P0080070", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of six races:", ShortName = "Population of six races:", Order = 124)]
        public System.Nullable<System.Int32> P0080070 { get; set; }

        [ReadOnly(false)]
        [Column("P0080071", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 125)]
        public System.Nullable<System.Int32> P0080071 { get; set; }

        [ReadOnly(false)]
        [Column("P0090001", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 126)]
        public System.Nullable<System.Int32> P0090001 { get; set; }

        [ReadOnly(false)]
        [Column("P0090002", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hispanic or Latino", ShortName = "Hispanic or Latino", Order = 127)]
        public System.Nullable<System.Int32> P0090002 { get; set; }

        [ReadOnly(false)]
        [Column("P0090003", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not Hispanic or Latino:", ShortName = "Not Hispanic or Latino:", Order = 128)]
        public System.Nullable<System.Int32> P0090003 { get; set; }

        [ReadOnly(false)]
        [Column("P0090004", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of one race:", ShortName = "Population of one race:", Order = 129)]
        public System.Nullable<System.Int32> P0090004 { get; set; }

        [ReadOnly(false)]
        [Column("P0090005", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White alone", ShortName = "White alone", Order = 130)]
        public System.Nullable<System.Int32> P0090005 { get; set; }

        [ReadOnly(false)]
        [Column("P0090006", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American alone", ShortName = "Black or African American alone", Order = 131)]
        public System.Nullable<System.Int32> P0090006 { get; set; }

        [ReadOnly(false)]
        [Column("P0090007", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native alone", ShortName = "American Indian and Alaska Native alone", Order = 132)]
        public System.Nullable<System.Int32> P0090007 { get; set; }

        [ReadOnly(false)]
        [Column("P0090008", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian alone", ShortName = "Asian alone", Order = 133)]
        public System.Nullable<System.Int32> P0090008 { get; set; }

        [ReadOnly(false)]
        [Column("P0090009", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander alone", ShortName = "Native Hawaiian and Other Pacific Islander alone", Order = 134)]
        public System.Nullable<System.Int32> P0090009 { get; set; }

        [ReadOnly(false)]
        [Column("P0090010", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Some Other Race alone", ShortName = "Some Other Race alone", Order = 135)]
        public System.Nullable<System.Int32> P0090010 { get; set; }

        [ReadOnly(false)]
        [Column("P0090011", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Two or More Races:", ShortName = "Two or More Races:", Order = 136)]
        public System.Nullable<System.Int32> P0090011 { get; set; }

        [ReadOnly(false)]
        [Column("P0090012", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of two races:", ShortName = "Population of two races:", Order = 137)]
        public System.Nullable<System.Int32> P0090012 { get; set; }

        [ReadOnly(false)]
        [Column("P0090013", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American", ShortName = "White; Black or African American", Order = 138)]
        public System.Nullable<System.Int32> P0090013 { get; set; }

        [ReadOnly(false)]
        [Column("P0090014", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native", ShortName = "White; American Indian and Alaska Native", Order = 139)]
        public System.Nullable<System.Int32> P0090014 { get; set; }

        [ReadOnly(false)]
        [Column("P0090015", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian", ShortName = "White; Asian", Order = 140)]
        public System.Nullable<System.Int32> P0090015 { get; set; }

        [ReadOnly(false)]
        [Column("P0090016", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Native Hawaiian and Other Pacific Islander", ShortName = "White; Native Hawaiian and Other Pacific Islander", Order = 141)]
        public System.Nullable<System.Int32> P0090016 { get; set; }

        [ReadOnly(false)]
        [Column("P0090017", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Some Other Race", ShortName = "White; Some Other Race", Order = 142)]
        public System.Nullable<System.Int32> P0090017 { get; set; }

        [ReadOnly(false)]
        [Column("P0090018", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native", ShortName = "Black or African American; American Indian and Alaska Native", Order = 143)]
        public System.Nullable<System.Int32> P0090018 { get; set; }

        [ReadOnly(false)]
        [Column("P0090019", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian", ShortName = "Black or African American; Asian", Order = 144)]
        public System.Nullable<System.Int32> P0090019 { get; set; }

        [ReadOnly(false)]
        [Column("P0090020", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander", Order = 145)]
        public System.Nullable<System.Int32> P0090020 { get; set; }

        [ReadOnly(false)]
        [Column("P0090021", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Some Other Race", ShortName = "Black or African American; Some Other Race", Order = 146)]
        public System.Nullable<System.Int32> P0090021 { get; set; }

        [ReadOnly(false)]
        [Column("P0090022", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian", ShortName = "American Indian and Alaska Native; Asian", Order = 147)]
        public System.Nullable<System.Int32> P0090022 { get; set; }

        [ReadOnly(false)]
        [Column("P0090023", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 148)]
        public System.Nullable<System.Int32> P0090023 { get; set; }

        [ReadOnly(false)]
        [Column("P0090024", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Some Other Race", ShortName = "American Indian and Alaska Native; Some Other Race", Order = 149)]
        public System.Nullable<System.Int32> P0090024 { get; set; }

        [ReadOnly(false)]
        [Column("P0090025", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Asian; Native Hawaiian and Other Pacific Islander", Order = 150)]
        public System.Nullable<System.Int32> P0090025 { get; set; }

        [ReadOnly(false)]
        [Column("P0090026", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian; Some Other Race", ShortName = "Asian; Some Other Race", Order = 151)]
        public System.Nullable<System.Int32> P0090026 { get; set; }

        [ReadOnly(false)]
        [Column("P0090027", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 152)]
        public System.Nullable<System.Int32> P0090027 { get; set; }

        [ReadOnly(false)]
        [Column("P0090028", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of three races:", ShortName = "Population of three races:", Order = 153)]
        public System.Nullable<System.Int32> P0090028 { get; set; }

        [ReadOnly(false)]
        [Column("P0090029", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native", ShortName = "White; Black or African American; American Indian and Alaska Native", Order = 154)]
        public System.Nullable<System.Int32> P0090029 { get; set; }

        [ReadOnly(false)]
        [Column("P0090030", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian", ShortName = "White; Black or African American; Asian", Order = 155)]
        public System.Nullable<System.Int32> P0090030 { get; set; }

        [ReadOnly(false)]
        [Column("P0090031", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander", Order = 156)]
        public System.Nullable<System.Int32> P0090031 { get; set; }

        [ReadOnly(false)]
        [Column("P0090032", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Some Other Race", ShortName = "White; Black or African American; Some Other Race", Order = 157)]
        public System.Nullable<System.Int32> P0090032 { get; set; }

        [ReadOnly(false)]
        [Column("P0090033", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian", ShortName = "White; American Indian and Alaska Native; Asian", Order = 158)]
        public System.Nullable<System.Int32> P0090033 { get; set; }

        [ReadOnly(false)]
        [Column("P0090034", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 159)]
        public System.Nullable<System.Int32> P0090034 { get; set; }

        [ReadOnly(false)]
        [Column("P0090035", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Some Other Race", ShortName = "White; American Indian and Alaska Native; Some Other Race", Order = 160)]
        public System.Nullable<System.Int32> P0090035 { get; set; }

        [ReadOnly(false)]
        [Column("P0090036", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander", Order = 161)]
        public System.Nullable<System.Int32> P0090036 { get; set; }

        [ReadOnly(false)]
        [Column("P0090037", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian; Some Other Race", ShortName = "White; Asian; Some Other Race", Order = 162)]
        public System.Nullable<System.Int32> P0090037 { get; set; }

        [ReadOnly(false)]
        [Column("P0090038", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 163)]
        public System.Nullable<System.Int32> P0090038 { get; set; }

        [ReadOnly(false)]
        [Column("P0090039", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian", ShortName = "Black or African American; American Indian and Alaska Native; Asian", Order = 164)]
        public System.Nullable<System.Int32> P0090039 { get; set; }

        [ReadOnly(false)]
        [Column("P0090040", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 165)]
        public System.Nullable<System.Int32> P0090040 { get; set; }

        [ReadOnly(false)]
        [Column("P0090041", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Some Other Race", Order = 166)]
        public System.Nullable<System.Int32> P0090041 { get; set; }

        [ReadOnly(false)]
        [Column("P0090042", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 167)]
        public System.Nullable<System.Int32> P0090042 { get; set; }

        [ReadOnly(false)]
        [Column("P0090043", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian; Some Other Race", ShortName = "Black or African American; Asian; Some Other Race", Order = 168)]
        public System.Nullable<System.Int32> P0090043 { get; set; }

        [ReadOnly(false)]
        [Column("P0090044", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 169)]
        public System.Nullable<System.Int32> P0090044 { get; set; }

        [ReadOnly(false)]
        [Column("P0090045", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 170)]
        public System.Nullable<System.Int32> P0090045 { get; set; }

        [ReadOnly(false)]
        [Column("P0090046", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Some Other Race", Order = 171)]
        public System.Nullable<System.Int32> P0090046 { get; set; }

        [ReadOnly(false)]
        [Column("P0090047", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 172)]
        public System.Nullable<System.Int32> P0090047 { get; set; }

        [ReadOnly(false)]
        [Column("P0090048", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 173)]
        public System.Nullable<System.Int32> P0090048 { get; set; }

        [ReadOnly(false)]
        [Column("P0090049", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of four races:", ShortName = "Population of four races:", Order = 174)]
        public System.Nullable<System.Int32> P0090049 { get; set; }

        [ReadOnly(false)]
        [Column("P0090050", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian", Order = 175)]
        public System.Nullable<System.Int32> P0090050 { get; set; }

        [ReadOnly(false)]
        [Column("P0090051", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 176)]
        public System.Nullable<System.Int32> P0090051 { get; set; }

        [ReadOnly(false)]
        [Column("P0090052", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Some Other Race", Order = 177)]
        public System.Nullable<System.Int32> P0090052 { get; set; }

        [ReadOnly(false)]
        [Column("P0090053", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 178)]
        public System.Nullable<System.Int32> P0090053 { get; set; }

        [ReadOnly(false)]
        [Column("P0090054", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian; Some Other Race", ShortName = "White; Black or African American; Asian; Some Other Race", Order = 179)]
        public System.Nullable<System.Int32> P0090054 { get; set; }

        [ReadOnly(false)]
        [Column("P0090055", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 180)]
        public System.Nullable<System.Int32> P0090055 { get; set; }

        [ReadOnly(false)]
        [Column("P0090056", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 181)]
        public System.Nullable<System.Int32> P0090056 { get; set; }

        [ReadOnly(false)]
        [Column("P0090057", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Some Other Race", Order = 182)]
        public System.Nullable<System.Int32> P0090057 { get; set; }

        [ReadOnly(false)]
        [Column("P0090058", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 183)]
        public System.Nullable<System.Int32> P0090058 { get; set; }

        [ReadOnly(false)]
        [Column("P0090059", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 184)]
        public System.Nullable<System.Int32> P0090059 { get; set; }

        [ReadOnly(false)]
        [Column("P0090060", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 185)]
        public System.Nullable<System.Int32> P0090060 { get; set; }

        [ReadOnly(false)]
        [Column("P0090061", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 186)]
        public System.Nullable<System.Int32> P0090061 { get; set; }

        [ReadOnly(false)]
        [Column("P0090062", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 187)]
        public System.Nullable<System.Int32> P0090062 { get; set; }

        [ReadOnly(false)]
        [Column("P0090063", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 188)]
        public System.Nullable<System.Int32> P0090063 { get; set; }

        [ReadOnly(false)]
        [Column("P0090064", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 189)]
        public System.Nullable<System.Int32> P0090064 { get; set; }

        [ReadOnly(false)]
        [Column("P0090065", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of five races:", ShortName = "Population of five races:", Order = 190)]
        public System.Nullable<System.Int32> P0090065 { get; set; }

        [ReadOnly(false)]
        [Column("P0090066", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 191)]
        public System.Nullable<System.Int32> P0090066 { get; set; }

        [ReadOnly(false)]
        [Column("P0090067", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 192)]
        public System.Nullable<System.Int32> P0090067 { get; set; }

        [ReadOnly(false)]
        [Column("P0090068", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 193)]
        public System.Nullable<System.Int32> P0090068 { get; set; }

        [ReadOnly(false)]
        [Column("P0090069", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 194)]
        public System.Nullable<System.Int32> P0090069 { get; set; }

        [ReadOnly(false)]
        [Column("P0090070", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 195)]
        public System.Nullable<System.Int32> P0090070 { get; set; }

        [ReadOnly(false)]
        [Column("P0090071", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 196)]
        public System.Nullable<System.Int32> P0090071 { get; set; }

        [ReadOnly(false)]
        [Column("P0090072", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of six races:", ShortName = "Population of six races:", Order = 197)]
        public System.Nullable<System.Int32> P0090072 { get; set; }

        [ReadOnly(false)]
        [Column("P0090073", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 198)]
        public System.Nullable<System.Int32> P0090073 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1_00003(string csvLine) : base(csvLine) {}

        public SF1_00003(string[] values) : base(values) {}

        public SF1_00003(OleDbDataReader reader, CensusFileType fileType)
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
                P0030001 = (System.Nullable<System.Int32>)reader[5];
            }
            if(reader[6] != DBNull.Value)
            {
                P0030002 = (System.Nullable<System.Int32>)reader[6];
            }
            if(reader[7] != DBNull.Value)
            {
                P0030003 = (System.Nullable<System.Int32>)reader[7];
            }
            if(reader[8] != DBNull.Value)
            {
                P0030004 = (System.Nullable<System.Int32>)reader[8];
            }
            if(reader[9] != DBNull.Value)
            {
                P0030005 = (System.Nullable<System.Int32>)reader[9];
            }
            if(reader[10] != DBNull.Value)
            {
                P0030006 = (System.Nullable<System.Int32>)reader[10];
            }
            if(reader[11] != DBNull.Value)
            {
                P0030007 = (System.Nullable<System.Int32>)reader[11];
            }
            if(reader[12] != DBNull.Value)
            {
                P0030008 = (System.Nullable<System.Int32>)reader[12];
            }
            if(reader[13] != DBNull.Value)
            {
                P0040001 = (System.Nullable<System.Int32>)reader[13];
            }
            if(reader[14] != DBNull.Value)
            {
                P0040002 = (System.Nullable<System.Int32>)reader[14];
            }
            if(reader[15] != DBNull.Value)
            {
                P0040003 = (System.Nullable<System.Int32>)reader[15];
            }
            if(reader[16] != DBNull.Value)
            {
                P0050001 = (System.Nullable<System.Int32>)reader[16];
            }
            if(reader[17] != DBNull.Value)
            {
                P0050002 = (System.Nullable<System.Int32>)reader[17];
            }
            if(reader[18] != DBNull.Value)
            {
                P0050003 = (System.Nullable<System.Int32>)reader[18];
            }
            if(reader[19] != DBNull.Value)
            {
                P0050004 = (System.Nullable<System.Int32>)reader[19];
            }
            if(reader[20] != DBNull.Value)
            {
                P0050005 = (System.Nullable<System.Int32>)reader[20];
            }
            if(reader[21] != DBNull.Value)
            {
                P0050006 = (System.Nullable<System.Int32>)reader[21];
            }
            if(reader[22] != DBNull.Value)
            {
                P0050007 = (System.Nullable<System.Int32>)reader[22];
            }
            if(reader[23] != DBNull.Value)
            {
                P0050008 = (System.Nullable<System.Int32>)reader[23];
            }
            if(reader[24] != DBNull.Value)
            {
                P0050009 = (System.Nullable<System.Int32>)reader[24];
            }
            if(reader[25] != DBNull.Value)
            {
                P0050010 = (System.Nullable<System.Int32>)reader[25];
            }
            if(reader[26] != DBNull.Value)
            {
                P0050011 = (System.Nullable<System.Int32>)reader[26];
            }
            if(reader[27] != DBNull.Value)
            {
                P0050012 = (System.Nullable<System.Int32>)reader[27];
            }
            if(reader[28] != DBNull.Value)
            {
                P0050013 = (System.Nullable<System.Int32>)reader[28];
            }
            if(reader[29] != DBNull.Value)
            {
                P0050014 = (System.Nullable<System.Int32>)reader[29];
            }
            if(reader[30] != DBNull.Value)
            {
                P0050015 = (System.Nullable<System.Int32>)reader[30];
            }
            if(reader[31] != DBNull.Value)
            {
                P0050016 = (System.Nullable<System.Int32>)reader[31];
            }
            if(reader[32] != DBNull.Value)
            {
                P0050017 = (System.Nullable<System.Int32>)reader[32];
            }
            if(reader[33] != DBNull.Value)
            {
                P0060001 = (System.Nullable<System.Int32>)reader[33];
            }
            if(reader[34] != DBNull.Value)
            {
                P0060002 = (System.Nullable<System.Int32>)reader[34];
            }
            if(reader[35] != DBNull.Value)
            {
                P0060003 = (System.Nullable<System.Int32>)reader[35];
            }
            if(reader[36] != DBNull.Value)
            {
                P0060004 = (System.Nullable<System.Int32>)reader[36];
            }
            if(reader[37] != DBNull.Value)
            {
                P0060005 = (System.Nullable<System.Int32>)reader[37];
            }
            if(reader[38] != DBNull.Value)
            {
                P0060006 = (System.Nullable<System.Int32>)reader[38];
            }
            if(reader[39] != DBNull.Value)
            {
                P0060007 = (System.Nullable<System.Int32>)reader[39];
            }
            if(reader[40] != DBNull.Value)
            {
                P0070001 = (System.Nullable<System.Int32>)reader[40];
            }
            if(reader[41] != DBNull.Value)
            {
                P0070002 = (System.Nullable<System.Int32>)reader[41];
            }
            if(reader[42] != DBNull.Value)
            {
                P0070003 = (System.Nullable<System.Int32>)reader[42];
            }
            if(reader[43] != DBNull.Value)
            {
                P0070004 = (System.Nullable<System.Int32>)reader[43];
            }
            if(reader[44] != DBNull.Value)
            {
                P0070005 = (System.Nullable<System.Int32>)reader[44];
            }
            if(reader[45] != DBNull.Value)
            {
                P0070006 = (System.Nullable<System.Int32>)reader[45];
            }
            if(reader[46] != DBNull.Value)
            {
                P0070007 = (System.Nullable<System.Int32>)reader[46];
            }
            if(reader[47] != DBNull.Value)
            {
                P0070008 = (System.Nullable<System.Int32>)reader[47];
            }
            if(reader[48] != DBNull.Value)
            {
                P0070009 = (System.Nullable<System.Int32>)reader[48];
            }
            if(reader[49] != DBNull.Value)
            {
                P0070010 = (System.Nullable<System.Int32>)reader[49];
            }
            if(reader[50] != DBNull.Value)
            {
                P0070011 = (System.Nullable<System.Int32>)reader[50];
            }
            if(reader[51] != DBNull.Value)
            {
                P0070012 = (System.Nullable<System.Int32>)reader[51];
            }
            if(reader[52] != DBNull.Value)
            {
                P0070013 = (System.Nullable<System.Int32>)reader[52];
            }
            if(reader[53] != DBNull.Value)
            {
                P0070014 = (System.Nullable<System.Int32>)reader[53];
            }
            if(reader[54] != DBNull.Value)
            {
                P0070015 = (System.Nullable<System.Int32>)reader[54];
            }
            if(reader[55] != DBNull.Value)
            {
                P0080001 = (System.Nullable<System.Int32>)reader[55];
            }
            if(reader[56] != DBNull.Value)
            {
                P0080002 = (System.Nullable<System.Int32>)reader[56];
            }
            if(reader[57] != DBNull.Value)
            {
                P0080003 = (System.Nullable<System.Int32>)reader[57];
            }
            if(reader[58] != DBNull.Value)
            {
                P0080004 = (System.Nullable<System.Int32>)reader[58];
            }
            if(reader[59] != DBNull.Value)
            {
                P0080005 = (System.Nullable<System.Int32>)reader[59];
            }
            if(reader[60] != DBNull.Value)
            {
                P0080006 = (System.Nullable<System.Int32>)reader[60];
            }
            if(reader[61] != DBNull.Value)
            {
                P0080007 = (System.Nullable<System.Int32>)reader[61];
            }
            if(reader[62] != DBNull.Value)
            {
                P0080008 = (System.Nullable<System.Int32>)reader[62];
            }
            if(reader[63] != DBNull.Value)
            {
                P0080009 = (System.Nullable<System.Int32>)reader[63];
            }
            if(reader[64] != DBNull.Value)
            {
                P0080010 = (System.Nullable<System.Int32>)reader[64];
            }
            if(reader[65] != DBNull.Value)
            {
                P0080011 = (System.Nullable<System.Int32>)reader[65];
            }
            if(reader[66] != DBNull.Value)
            {
                P0080012 = (System.Nullable<System.Int32>)reader[66];
            }
            if(reader[67] != DBNull.Value)
            {
                P0080013 = (System.Nullable<System.Int32>)reader[67];
            }
            if(reader[68] != DBNull.Value)
            {
                P0080014 = (System.Nullable<System.Int32>)reader[68];
            }
            if(reader[69] != DBNull.Value)
            {
                P0080015 = (System.Nullable<System.Int32>)reader[69];
            }
            if(reader[70] != DBNull.Value)
            {
                P0080016 = (System.Nullable<System.Int32>)reader[70];
            }
            if(reader[71] != DBNull.Value)
            {
                P0080017 = (System.Nullable<System.Int32>)reader[71];
            }
            if(reader[72] != DBNull.Value)
            {
                P0080018 = (System.Nullable<System.Int32>)reader[72];
            }
            if(reader[73] != DBNull.Value)
            {
                P0080019 = (System.Nullable<System.Int32>)reader[73];
            }
            if(reader[74] != DBNull.Value)
            {
                P0080020 = (System.Nullable<System.Int32>)reader[74];
            }
            if(reader[75] != DBNull.Value)
            {
                P0080021 = (System.Nullable<System.Int32>)reader[75];
            }
            if(reader[76] != DBNull.Value)
            {
                P0080022 = (System.Nullable<System.Int32>)reader[76];
            }
            if(reader[77] != DBNull.Value)
            {
                P0080023 = (System.Nullable<System.Int32>)reader[77];
            }
            if(reader[78] != DBNull.Value)
            {
                P0080024 = (System.Nullable<System.Int32>)reader[78];
            }
            if(reader[79] != DBNull.Value)
            {
                P0080025 = (System.Nullable<System.Int32>)reader[79];
            }
            if(reader[80] != DBNull.Value)
            {
                P0080026 = (System.Nullable<System.Int32>)reader[80];
            }
            if(reader[81] != DBNull.Value)
            {
                P0080027 = (System.Nullable<System.Int32>)reader[81];
            }
            if(reader[82] != DBNull.Value)
            {
                P0080028 = (System.Nullable<System.Int32>)reader[82];
            }
            if(reader[83] != DBNull.Value)
            {
                P0080029 = (System.Nullable<System.Int32>)reader[83];
            }
            if(reader[84] != DBNull.Value)
            {
                P0080030 = (System.Nullable<System.Int32>)reader[84];
            }
            if(reader[85] != DBNull.Value)
            {
                P0080031 = (System.Nullable<System.Int32>)reader[85];
            }
            if(reader[86] != DBNull.Value)
            {
                P0080032 = (System.Nullable<System.Int32>)reader[86];
            }
            if(reader[87] != DBNull.Value)
            {
                P0080033 = (System.Nullable<System.Int32>)reader[87];
            }
            if(reader[88] != DBNull.Value)
            {
                P0080034 = (System.Nullable<System.Int32>)reader[88];
            }
            if(reader[89] != DBNull.Value)
            {
                P0080035 = (System.Nullable<System.Int32>)reader[89];
            }
            if(reader[90] != DBNull.Value)
            {
                P0080036 = (System.Nullable<System.Int32>)reader[90];
            }
            if(reader[91] != DBNull.Value)
            {
                P0080037 = (System.Nullable<System.Int32>)reader[91];
            }
            if(reader[92] != DBNull.Value)
            {
                P0080038 = (System.Nullable<System.Int32>)reader[92];
            }
            if(reader[93] != DBNull.Value)
            {
                P0080039 = (System.Nullable<System.Int32>)reader[93];
            }
            if(reader[94] != DBNull.Value)
            {
                P0080040 = (System.Nullable<System.Int32>)reader[94];
            }
            if(reader[95] != DBNull.Value)
            {
                P0080041 = (System.Nullable<System.Int32>)reader[95];
            }
            if(reader[96] != DBNull.Value)
            {
                P0080042 = (System.Nullable<System.Int32>)reader[96];
            }
            if(reader[97] != DBNull.Value)
            {
                P0080043 = (System.Nullable<System.Int32>)reader[97];
            }
            if(reader[98] != DBNull.Value)
            {
                P0080044 = (System.Nullable<System.Int32>)reader[98];
            }
            if(reader[99] != DBNull.Value)
            {
                P0080045 = (System.Nullable<System.Int32>)reader[99];
            }
            if(reader[100] != DBNull.Value)
            {
                P0080046 = (System.Nullable<System.Int32>)reader[100];
            }
            if(reader[101] != DBNull.Value)
            {
                P0080047 = (System.Nullable<System.Int32>)reader[101];
            }
            if(reader[102] != DBNull.Value)
            {
                P0080048 = (System.Nullable<System.Int32>)reader[102];
            }
            if(reader[103] != DBNull.Value)
            {
                P0080049 = (System.Nullable<System.Int32>)reader[103];
            }
            if(reader[104] != DBNull.Value)
            {
                P0080050 = (System.Nullable<System.Int32>)reader[104];
            }
            if(reader[105] != DBNull.Value)
            {
                P0080051 = (System.Nullable<System.Int32>)reader[105];
            }
            if(reader[106] != DBNull.Value)
            {
                P0080052 = (System.Nullable<System.Int32>)reader[106];
            }
            if(reader[107] != DBNull.Value)
            {
                P0080053 = (System.Nullable<System.Int32>)reader[107];
            }
            if(reader[108] != DBNull.Value)
            {
                P0080054 = (System.Nullable<System.Int32>)reader[108];
            }
            if(reader[109] != DBNull.Value)
            {
                P0080055 = (System.Nullable<System.Int32>)reader[109];
            }
            if(reader[110] != DBNull.Value)
            {
                P0080056 = (System.Nullable<System.Int32>)reader[110];
            }
            if(reader[111] != DBNull.Value)
            {
                P0080057 = (System.Nullable<System.Int32>)reader[111];
            }
            if(reader[112] != DBNull.Value)
            {
                P0080058 = (System.Nullable<System.Int32>)reader[112];
            }
            if(reader[113] != DBNull.Value)
            {
                P0080059 = (System.Nullable<System.Int32>)reader[113];
            }
            if(reader[114] != DBNull.Value)
            {
                P0080060 = (System.Nullable<System.Int32>)reader[114];
            }
            if(reader[115] != DBNull.Value)
            {
                P0080061 = (System.Nullable<System.Int32>)reader[115];
            }
            if(reader[116] != DBNull.Value)
            {
                P0080062 = (System.Nullable<System.Int32>)reader[116];
            }
            if(reader[117] != DBNull.Value)
            {
                P0080063 = (System.Nullable<System.Int32>)reader[117];
            }
            if(reader[118] != DBNull.Value)
            {
                P0080064 = (System.Nullable<System.Int32>)reader[118];
            }
            if(reader[119] != DBNull.Value)
            {
                P0080065 = (System.Nullable<System.Int32>)reader[119];
            }
            if(reader[120] != DBNull.Value)
            {
                P0080066 = (System.Nullable<System.Int32>)reader[120];
            }
            if(reader[121] != DBNull.Value)
            {
                P0080067 = (System.Nullable<System.Int32>)reader[121];
            }
            if(reader[122] != DBNull.Value)
            {
                P0080068 = (System.Nullable<System.Int32>)reader[122];
            }
            if(reader[123] != DBNull.Value)
            {
                P0080069 = (System.Nullable<System.Int32>)reader[123];
            }
            if(reader[124] != DBNull.Value)
            {
                P0080070 = (System.Nullable<System.Int32>)reader[124];
            }
            if(reader[125] != DBNull.Value)
            {
                P0080071 = (System.Nullable<System.Int32>)reader[125];
            }
            if(reader[126] != DBNull.Value)
            {
                P0090001 = (System.Nullable<System.Int32>)reader[126];
            }
            if(reader[127] != DBNull.Value)
            {
                P0090002 = (System.Nullable<System.Int32>)reader[127];
            }
            if(reader[128] != DBNull.Value)
            {
                P0090003 = (System.Nullable<System.Int32>)reader[128];
            }
            if(reader[129] != DBNull.Value)
            {
                P0090004 = (System.Nullable<System.Int32>)reader[129];
            }
            if(reader[130] != DBNull.Value)
            {
                P0090005 = (System.Nullable<System.Int32>)reader[130];
            }
            if(reader[131] != DBNull.Value)
            {
                P0090006 = (System.Nullable<System.Int32>)reader[131];
            }
            if(reader[132] != DBNull.Value)
            {
                P0090007 = (System.Nullable<System.Int32>)reader[132];
            }
            if(reader[133] != DBNull.Value)
            {
                P0090008 = (System.Nullable<System.Int32>)reader[133];
            }
            if(reader[134] != DBNull.Value)
            {
                P0090009 = (System.Nullable<System.Int32>)reader[134];
            }
            if(reader[135] != DBNull.Value)
            {
                P0090010 = (System.Nullable<System.Int32>)reader[135];
            }
            if(reader[136] != DBNull.Value)
            {
                P0090011 = (System.Nullable<System.Int32>)reader[136];
            }
            if(reader[137] != DBNull.Value)
            {
                P0090012 = (System.Nullable<System.Int32>)reader[137];
            }
            if(reader[138] != DBNull.Value)
            {
                P0090013 = (System.Nullable<System.Int32>)reader[138];
            }
            if(reader[139] != DBNull.Value)
            {
                P0090014 = (System.Nullable<System.Int32>)reader[139];
            }
            if(reader[140] != DBNull.Value)
            {
                P0090015 = (System.Nullable<System.Int32>)reader[140];
            }
            if(reader[141] != DBNull.Value)
            {
                P0090016 = (System.Nullable<System.Int32>)reader[141];
            }
            if(reader[142] != DBNull.Value)
            {
                P0090017 = (System.Nullable<System.Int32>)reader[142];
            }
            if(reader[143] != DBNull.Value)
            {
                P0090018 = (System.Nullable<System.Int32>)reader[143];
            }
            if(reader[144] != DBNull.Value)
            {
                P0090019 = (System.Nullable<System.Int32>)reader[144];
            }
            if(reader[145] != DBNull.Value)
            {
                P0090020 = (System.Nullable<System.Int32>)reader[145];
            }
            if(reader[146] != DBNull.Value)
            {
                P0090021 = (System.Nullable<System.Int32>)reader[146];
            }
            if(reader[147] != DBNull.Value)
            {
                P0090022 = (System.Nullable<System.Int32>)reader[147];
            }
            if(reader[148] != DBNull.Value)
            {
                P0090023 = (System.Nullable<System.Int32>)reader[148];
            }
            if(reader[149] != DBNull.Value)
            {
                P0090024 = (System.Nullable<System.Int32>)reader[149];
            }
            if(reader[150] != DBNull.Value)
            {
                P0090025 = (System.Nullable<System.Int32>)reader[150];
            }
            if(reader[151] != DBNull.Value)
            {
                P0090026 = (System.Nullable<System.Int32>)reader[151];
            }
            if(reader[152] != DBNull.Value)
            {
                P0090027 = (System.Nullable<System.Int32>)reader[152];
            }
            if(reader[153] != DBNull.Value)
            {
                P0090028 = (System.Nullable<System.Int32>)reader[153];
            }
            if(reader[154] != DBNull.Value)
            {
                P0090029 = (System.Nullable<System.Int32>)reader[154];
            }
            if(reader[155] != DBNull.Value)
            {
                P0090030 = (System.Nullable<System.Int32>)reader[155];
            }
            if(reader[156] != DBNull.Value)
            {
                P0090031 = (System.Nullable<System.Int32>)reader[156];
            }
            if(reader[157] != DBNull.Value)
            {
                P0090032 = (System.Nullable<System.Int32>)reader[157];
            }
            if(reader[158] != DBNull.Value)
            {
                P0090033 = (System.Nullable<System.Int32>)reader[158];
            }
            if(reader[159] != DBNull.Value)
            {
                P0090034 = (System.Nullable<System.Int32>)reader[159];
            }
            if(reader[160] != DBNull.Value)
            {
                P0090035 = (System.Nullable<System.Int32>)reader[160];
            }
            if(reader[161] != DBNull.Value)
            {
                P0090036 = (System.Nullable<System.Int32>)reader[161];
            }
            if(reader[162] != DBNull.Value)
            {
                P0090037 = (System.Nullable<System.Int32>)reader[162];
            }
            if(reader[163] != DBNull.Value)
            {
                P0090038 = (System.Nullable<System.Int32>)reader[163];
            }
            if(reader[164] != DBNull.Value)
            {
                P0090039 = (System.Nullable<System.Int32>)reader[164];
            }
            if(reader[165] != DBNull.Value)
            {
                P0090040 = (System.Nullable<System.Int32>)reader[165];
            }
            if(reader[166] != DBNull.Value)
            {
                P0090041 = (System.Nullable<System.Int32>)reader[166];
            }
            if(reader[167] != DBNull.Value)
            {
                P0090042 = (System.Nullable<System.Int32>)reader[167];
            }
            if(reader[168] != DBNull.Value)
            {
                P0090043 = (System.Nullable<System.Int32>)reader[168];
            }
            if(reader[169] != DBNull.Value)
            {
                P0090044 = (System.Nullable<System.Int32>)reader[169];
            }
            if(reader[170] != DBNull.Value)
            {
                P0090045 = (System.Nullable<System.Int32>)reader[170];
            }
            if(reader[171] != DBNull.Value)
            {
                P0090046 = (System.Nullable<System.Int32>)reader[171];
            }
            if(reader[172] != DBNull.Value)
            {
                P0090047 = (System.Nullable<System.Int32>)reader[172];
            }
            if(reader[173] != DBNull.Value)
            {
                P0090048 = (System.Nullable<System.Int32>)reader[173];
            }
            if(reader[174] != DBNull.Value)
            {
                P0090049 = (System.Nullable<System.Int32>)reader[174];
            }
            if(reader[175] != DBNull.Value)
            {
                P0090050 = (System.Nullable<System.Int32>)reader[175];
            }
            if(reader[176] != DBNull.Value)
            {
                P0090051 = (System.Nullable<System.Int32>)reader[176];
            }
            if(reader[177] != DBNull.Value)
            {
                P0090052 = (System.Nullable<System.Int32>)reader[177];
            }
            if(reader[178] != DBNull.Value)
            {
                P0090053 = (System.Nullable<System.Int32>)reader[178];
            }
            if(reader[179] != DBNull.Value)
            {
                P0090054 = (System.Nullable<System.Int32>)reader[179];
            }
            if(reader[180] != DBNull.Value)
            {
                P0090055 = (System.Nullable<System.Int32>)reader[180];
            }
            if(reader[181] != DBNull.Value)
            {
                P0090056 = (System.Nullable<System.Int32>)reader[181];
            }
            if(reader[182] != DBNull.Value)
            {
                P0090057 = (System.Nullable<System.Int32>)reader[182];
            }
            if(reader[183] != DBNull.Value)
            {
                P0090058 = (System.Nullable<System.Int32>)reader[183];
            }
            if(reader[184] != DBNull.Value)
            {
                P0090059 = (System.Nullable<System.Int32>)reader[184];
            }
            if(reader[185] != DBNull.Value)
            {
                P0090060 = (System.Nullable<System.Int32>)reader[185];
            }
            if(reader[186] != DBNull.Value)
            {
                P0090061 = (System.Nullable<System.Int32>)reader[186];
            }
            if(reader[187] != DBNull.Value)
            {
                P0090062 = (System.Nullable<System.Int32>)reader[187];
            }
            if(reader[188] != DBNull.Value)
            {
                P0090063 = (System.Nullable<System.Int32>)reader[188];
            }
            if(reader[189] != DBNull.Value)
            {
                P0090064 = (System.Nullable<System.Int32>)reader[189];
            }
            if(reader[190] != DBNull.Value)
            {
                P0090065 = (System.Nullable<System.Int32>)reader[190];
            }
            if(reader[191] != DBNull.Value)
            {
                P0090066 = (System.Nullable<System.Int32>)reader[191];
            }
            if(reader[192] != DBNull.Value)
            {
                P0090067 = (System.Nullable<System.Int32>)reader[192];
            }
            if(reader[193] != DBNull.Value)
            {
                P0090068 = (System.Nullable<System.Int32>)reader[193];
            }
            if(reader[194] != DBNull.Value)
            {
                P0090069 = (System.Nullable<System.Int32>)reader[194];
            }
            if(reader[195] != DBNull.Value)
            {
                P0090070 = (System.Nullable<System.Int32>)reader[195];
            }
            if(reader[196] != DBNull.Value)
            {
                P0090071 = (System.Nullable<System.Int32>)reader[196];
            }
            if(reader[197] != DBNull.Value)
            {
                P0090072 = (System.Nullable<System.Int32>)reader[197];
            }
            if(reader[198] != DBNull.Value)
            {
                P0090073 = (System.Nullable<System.Int32>)reader[198];
            }
        }
        #endregion Constructors
    }
}