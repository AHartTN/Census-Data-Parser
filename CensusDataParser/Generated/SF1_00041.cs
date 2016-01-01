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

    [Table("SF1_00041")]
    public partial class SF1_00041 : BaseModel
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
        [Column("PCO0070001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Total (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 5)]
        public System.Nullable<System.Int32> PCO0070001 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 6)]
        public System.Nullable<System.Int32> PCO0070002 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 7)]
        public System.Nullable<System.Int32> PCO0070003 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 8)]
        public System.Nullable<System.Int32> PCO0070004 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 9)]
        public System.Nullable<System.Int32> PCO0070005 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 10)]
        public System.Nullable<System.Int32> PCO0070006 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 11)]
        public System.Nullable<System.Int32> PCO0070007 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 12)]
        public System.Nullable<System.Int32> PCO0070008 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 13)]
        public System.Nullable<System.Int32> PCO0070009 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 14)]
        public System.Nullable<System.Int32> PCO0070010 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 15)]
        public System.Nullable<System.Int32> PCO0070011 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 16)]
        public System.Nullable<System.Int32> PCO0070012 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 17)]
        public System.Nullable<System.Int32> PCO0070013 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 18)]
        public System.Nullable<System.Int32> PCO0070014 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 19)]
        public System.Nullable<System.Int32> PCO0070015 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 20)]
        public System.Nullable<System.Int32> PCO0070016 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070017", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 21)]
        public System.Nullable<System.Int32> PCO0070017 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070018", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 22)]
        public System.Nullable<System.Int32> PCO0070018 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070019", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 23)]
        public System.Nullable<System.Int32> PCO0070019 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070020", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 24)]
        public System.Nullable<System.Int32> PCO0070020 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070021", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 25)]
        public System.Nullable<System.Int32> PCO0070021 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070022", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 26)]
        public System.Nullable<System.Int32> PCO0070022 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070023", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 27)]
        public System.Nullable<System.Int32> PCO0070023 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070024", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 28)]
        public System.Nullable<System.Int32> PCO0070024 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070025", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 29)]
        public System.Nullable<System.Int32> PCO0070025 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070026", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 30)]
        public System.Nullable<System.Int32> PCO0070026 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070027", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 31)]
        public System.Nullable<System.Int32> PCO0070027 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070028", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 32)]
        public System.Nullable<System.Int32> PCO0070028 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070029", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 33)]
        public System.Nullable<System.Int32> PCO0070029 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070030", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 34)]
        public System.Nullable<System.Int32> PCO0070030 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070031", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 35)]
        public System.Nullable<System.Int32> PCO0070031 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070032", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 36)]
        public System.Nullable<System.Int32> PCO0070032 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070033", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 37)]
        public System.Nullable<System.Int32> PCO0070033 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070034", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 38)]
        public System.Nullable<System.Int32> PCO0070034 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070035", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 39)]
        public System.Nullable<System.Int32> PCO0070035 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070036", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 40)]
        public System.Nullable<System.Int32> PCO0070036 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070037", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 41)]
        public System.Nullable<System.Int32> PCO0070037 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070038", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 42)]
        public System.Nullable<System.Int32> PCO0070038 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070039", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 43)]
        public System.Nullable<System.Int32> PCO0070039 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080001", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total (501):", ShortName = "Total (501):", Order = 44)]
        public System.Nullable<System.Int32> PCO0080001 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080002", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 45)]
        public System.Nullable<System.Int32> PCO0080002 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080003", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 46)]
        public System.Nullable<System.Int32> PCO0080003 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080004", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 47)]
        public System.Nullable<System.Int32> PCO0080004 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080005", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 48)]
        public System.Nullable<System.Int32> PCO0080005 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080006", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 49)]
        public System.Nullable<System.Int32> PCO0080006 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080007", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 50)]
        public System.Nullable<System.Int32> PCO0080007 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080008", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 51)]
        public System.Nullable<System.Int32> PCO0080008 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080009", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 52)]
        public System.Nullable<System.Int32> PCO0080009 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080010", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 53)]
        public System.Nullable<System.Int32> PCO0080010 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080011", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 54)]
        public System.Nullable<System.Int32> PCO0080011 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080012", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 55)]
        public System.Nullable<System.Int32> PCO0080012 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080013", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 56)]
        public System.Nullable<System.Int32> PCO0080013 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080014", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 57)]
        public System.Nullable<System.Int32> PCO0080014 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080015", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 58)]
        public System.Nullable<System.Int32> PCO0080015 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080016", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 59)]
        public System.Nullable<System.Int32> PCO0080016 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080017", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 60)]
        public System.Nullable<System.Int32> PCO0080017 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080018", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 61)]
        public System.Nullable<System.Int32> PCO0080018 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080019", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 62)]
        public System.Nullable<System.Int32> PCO0080019 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080020", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 63)]
        public System.Nullable<System.Int32> PCO0080020 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080021", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 64)]
        public System.Nullable<System.Int32> PCO0080021 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080022", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 65)]
        public System.Nullable<System.Int32> PCO0080022 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080023", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 66)]
        public System.Nullable<System.Int32> PCO0080023 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080024", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 67)]
        public System.Nullable<System.Int32> PCO0080024 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080025", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 68)]
        public System.Nullable<System.Int32> PCO0080025 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080026", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 69)]
        public System.Nullable<System.Int32> PCO0080026 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080027", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 70)]
        public System.Nullable<System.Int32> PCO0080027 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080028", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 71)]
        public System.Nullable<System.Int32> PCO0080028 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080029", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 72)]
        public System.Nullable<System.Int32> PCO0080029 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080030", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 73)]
        public System.Nullable<System.Int32> PCO0080030 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080031", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 74)]
        public System.Nullable<System.Int32> PCO0080031 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080032", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 75)]
        public System.Nullable<System.Int32> PCO0080032 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080033", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 76)]
        public System.Nullable<System.Int32> PCO0080033 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080034", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 77)]
        public System.Nullable<System.Int32> PCO0080034 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080035", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 78)]
        public System.Nullable<System.Int32> PCO0080035 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080036", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 79)]
        public System.Nullable<System.Int32> PCO0080036 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080037", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 80)]
        public System.Nullable<System.Int32> PCO0080037 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080038", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 81)]
        public System.Nullable<System.Int32> PCO0080038 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0080039", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 82)]
        public System.Nullable<System.Int32> PCO0080039 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090001", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total (601-602):", ShortName = "Total (601-602):", Order = 83)]
        public System.Nullable<System.Int32> PCO0090001 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090002", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 84)]
        public System.Nullable<System.Int32> PCO0090002 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090003", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 85)]
        public System.Nullable<System.Int32> PCO0090003 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090004", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 86)]
        public System.Nullable<System.Int32> PCO0090004 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090005", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 87)]
        public System.Nullable<System.Int32> PCO0090005 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090006", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 88)]
        public System.Nullable<System.Int32> PCO0090006 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090007", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 89)]
        public System.Nullable<System.Int32> PCO0090007 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090008", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 90)]
        public System.Nullable<System.Int32> PCO0090008 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090009", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 91)]
        public System.Nullable<System.Int32> PCO0090009 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090010", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 92)]
        public System.Nullable<System.Int32> PCO0090010 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090011", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 93)]
        public System.Nullable<System.Int32> PCO0090011 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090012", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 94)]
        public System.Nullable<System.Int32> PCO0090012 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090013", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 95)]
        public System.Nullable<System.Int32> PCO0090013 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090014", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 96)]
        public System.Nullable<System.Int32> PCO0090014 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090015", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 97)]
        public System.Nullable<System.Int32> PCO0090015 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090016", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 98)]
        public System.Nullable<System.Int32> PCO0090016 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090017", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 99)]
        public System.Nullable<System.Int32> PCO0090017 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090018", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 100)]
        public System.Nullable<System.Int32> PCO0090018 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090019", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 101)]
        public System.Nullable<System.Int32> PCO0090019 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090020", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 102)]
        public System.Nullable<System.Int32> PCO0090020 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090021", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 103)]
        public System.Nullable<System.Int32> PCO0090021 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090022", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 104)]
        public System.Nullable<System.Int32> PCO0090022 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090023", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 105)]
        public System.Nullable<System.Int32> PCO0090023 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090024", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 106)]
        public System.Nullable<System.Int32> PCO0090024 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090025", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 107)]
        public System.Nullable<System.Int32> PCO0090025 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090026", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 108)]
        public System.Nullable<System.Int32> PCO0090026 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090027", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 109)]
        public System.Nullable<System.Int32> PCO0090027 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090028", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 110)]
        public System.Nullable<System.Int32> PCO0090028 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090029", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 111)]
        public System.Nullable<System.Int32> PCO0090029 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090030", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 112)]
        public System.Nullable<System.Int32> PCO0090030 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090031", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 113)]
        public System.Nullable<System.Int32> PCO0090031 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090032", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 114)]
        public System.Nullable<System.Int32> PCO0090032 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090033", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 115)]
        public System.Nullable<System.Int32> PCO0090033 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090034", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 116)]
        public System.Nullable<System.Int32> PCO0090034 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090035", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 117)]
        public System.Nullable<System.Int32> PCO0090035 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090036", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 118)]
        public System.Nullable<System.Int32> PCO0090036 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090037", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 119)]
        public System.Nullable<System.Int32> PCO0090037 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090038", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 120)]
        public System.Nullable<System.Int32> PCO0090038 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0090039", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 121)]
        public System.Nullable<System.Int32> PCO0090039 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100001", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Total (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 122)]
        public System.Nullable<System.Int32> PCO0100001 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100002", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 123)]
        public System.Nullable<System.Int32> PCO0100002 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100003", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 124)]
        public System.Nullable<System.Int32> PCO0100003 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100004", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 125)]
        public System.Nullable<System.Int32> PCO0100004 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100005", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 126)]
        public System.Nullable<System.Int32> PCO0100005 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100006", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 127)]
        public System.Nullable<System.Int32> PCO0100006 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100007", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 128)]
        public System.Nullable<System.Int32> PCO0100007 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100008", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 129)]
        public System.Nullable<System.Int32> PCO0100008 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100009", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 130)]
        public System.Nullable<System.Int32> PCO0100009 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100010", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 131)]
        public System.Nullable<System.Int32> PCO0100010 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100011", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 132)]
        public System.Nullable<System.Int32> PCO0100011 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100012", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 133)]
        public System.Nullable<System.Int32> PCO0100012 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100013", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 134)]
        public System.Nullable<System.Int32> PCO0100013 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100014", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 135)]
        public System.Nullable<System.Int32> PCO0100014 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100015", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 136)]
        public System.Nullable<System.Int32> PCO0100015 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100016", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 137)]
        public System.Nullable<System.Int32> PCO0100016 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100017", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 138)]
        public System.Nullable<System.Int32> PCO0100017 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100018", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 139)]
        public System.Nullable<System.Int32> PCO0100018 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100019", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 140)]
        public System.Nullable<System.Int32> PCO0100019 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100020", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 141)]
        public System.Nullable<System.Int32> PCO0100020 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100021", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 142)]
        public System.Nullable<System.Int32> PCO0100021 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100022", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 143)]
        public System.Nullable<System.Int32> PCO0100022 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100023", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 144)]
        public System.Nullable<System.Int32> PCO0100023 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100024", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 145)]
        public System.Nullable<System.Int32> PCO0100024 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100025", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 146)]
        public System.Nullable<System.Int32> PCO0100025 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100026", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 147)]
        public System.Nullable<System.Int32> PCO0100026 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100027", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 148)]
        public System.Nullable<System.Int32> PCO0100027 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100028", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 149)]
        public System.Nullable<System.Int32> PCO0100028 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100029", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 150)]
        public System.Nullable<System.Int32> PCO0100029 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100030", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 151)]
        public System.Nullable<System.Int32> PCO0100030 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100031", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 152)]
        public System.Nullable<System.Int32> PCO0100031 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100032", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 153)]
        public System.Nullable<System.Int32> PCO0100032 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100033", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 154)]
        public System.Nullable<System.Int32> PCO0100033 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100034", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 155)]
        public System.Nullable<System.Int32> PCO0100034 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100035", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 156)]
        public System.Nullable<System.Int32> PCO0100035 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100036", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 157)]
        public System.Nullable<System.Int32> PCO0100036 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100037", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 158)]
        public System.Nullable<System.Int32> PCO0100037 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100038", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 159)]
        public System.Nullable<System.Int32> PCO0100038 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0100039", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 160)]
        public System.Nullable<System.Int32> PCO0100039 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1_00041(string csvLine) : base(csvLine) {}

        public SF1_00041(string[] values) : base(values) {}

        public SF1_00041(OleDbDataReader reader, CensusFileType fileType)
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
                PCO0070001 = (System.Nullable<System.Int32>)reader[5];
            }
            if(reader[6] != DBNull.Value)
            {
                PCO0070002 = (System.Nullable<System.Int32>)reader[6];
            }
            if(reader[7] != DBNull.Value)
            {
                PCO0070003 = (System.Nullable<System.Int32>)reader[7];
            }
            if(reader[8] != DBNull.Value)
            {
                PCO0070004 = (System.Nullable<System.Int32>)reader[8];
            }
            if(reader[9] != DBNull.Value)
            {
                PCO0070005 = (System.Nullable<System.Int32>)reader[9];
            }
            if(reader[10] != DBNull.Value)
            {
                PCO0070006 = (System.Nullable<System.Int32>)reader[10];
            }
            if(reader[11] != DBNull.Value)
            {
                PCO0070007 = (System.Nullable<System.Int32>)reader[11];
            }
            if(reader[12] != DBNull.Value)
            {
                PCO0070008 = (System.Nullable<System.Int32>)reader[12];
            }
            if(reader[13] != DBNull.Value)
            {
                PCO0070009 = (System.Nullable<System.Int32>)reader[13];
            }
            if(reader[14] != DBNull.Value)
            {
                PCO0070010 = (System.Nullable<System.Int32>)reader[14];
            }
            if(reader[15] != DBNull.Value)
            {
                PCO0070011 = (System.Nullable<System.Int32>)reader[15];
            }
            if(reader[16] != DBNull.Value)
            {
                PCO0070012 = (System.Nullable<System.Int32>)reader[16];
            }
            if(reader[17] != DBNull.Value)
            {
                PCO0070013 = (System.Nullable<System.Int32>)reader[17];
            }
            if(reader[18] != DBNull.Value)
            {
                PCO0070014 = (System.Nullable<System.Int32>)reader[18];
            }
            if(reader[19] != DBNull.Value)
            {
                PCO0070015 = (System.Nullable<System.Int32>)reader[19];
            }
            if(reader[20] != DBNull.Value)
            {
                PCO0070016 = (System.Nullable<System.Int32>)reader[20];
            }
            if(reader[21] != DBNull.Value)
            {
                PCO0070017 = (System.Nullable<System.Int32>)reader[21];
            }
            if(reader[22] != DBNull.Value)
            {
                PCO0070018 = (System.Nullable<System.Int32>)reader[22];
            }
            if(reader[23] != DBNull.Value)
            {
                PCO0070019 = (System.Nullable<System.Int32>)reader[23];
            }
            if(reader[24] != DBNull.Value)
            {
                PCO0070020 = (System.Nullable<System.Int32>)reader[24];
            }
            if(reader[25] != DBNull.Value)
            {
                PCO0070021 = (System.Nullable<System.Int32>)reader[25];
            }
            if(reader[26] != DBNull.Value)
            {
                PCO0070022 = (System.Nullable<System.Int32>)reader[26];
            }
            if(reader[27] != DBNull.Value)
            {
                PCO0070023 = (System.Nullable<System.Int32>)reader[27];
            }
            if(reader[28] != DBNull.Value)
            {
                PCO0070024 = (System.Nullable<System.Int32>)reader[28];
            }
            if(reader[29] != DBNull.Value)
            {
                PCO0070025 = (System.Nullable<System.Int32>)reader[29];
            }
            if(reader[30] != DBNull.Value)
            {
                PCO0070026 = (System.Nullable<System.Int32>)reader[30];
            }
            if(reader[31] != DBNull.Value)
            {
                PCO0070027 = (System.Nullable<System.Int32>)reader[31];
            }
            if(reader[32] != DBNull.Value)
            {
                PCO0070028 = (System.Nullable<System.Int32>)reader[32];
            }
            if(reader[33] != DBNull.Value)
            {
                PCO0070029 = (System.Nullable<System.Int32>)reader[33];
            }
            if(reader[34] != DBNull.Value)
            {
                PCO0070030 = (System.Nullable<System.Int32>)reader[34];
            }
            if(reader[35] != DBNull.Value)
            {
                PCO0070031 = (System.Nullable<System.Int32>)reader[35];
            }
            if(reader[36] != DBNull.Value)
            {
                PCO0070032 = (System.Nullable<System.Int32>)reader[36];
            }
            if(reader[37] != DBNull.Value)
            {
                PCO0070033 = (System.Nullable<System.Int32>)reader[37];
            }
            if(reader[38] != DBNull.Value)
            {
                PCO0070034 = (System.Nullable<System.Int32>)reader[38];
            }
            if(reader[39] != DBNull.Value)
            {
                PCO0070035 = (System.Nullable<System.Int32>)reader[39];
            }
            if(reader[40] != DBNull.Value)
            {
                PCO0070036 = (System.Nullable<System.Int32>)reader[40];
            }
            if(reader[41] != DBNull.Value)
            {
                PCO0070037 = (System.Nullable<System.Int32>)reader[41];
            }
            if(reader[42] != DBNull.Value)
            {
                PCO0070038 = (System.Nullable<System.Int32>)reader[42];
            }
            if(reader[43] != DBNull.Value)
            {
                PCO0070039 = (System.Nullable<System.Int32>)reader[43];
            }
            if(reader[44] != DBNull.Value)
            {
                PCO0080001 = (System.Nullable<System.Int32>)reader[44];
            }
            if(reader[45] != DBNull.Value)
            {
                PCO0080002 = (System.Nullable<System.Int32>)reader[45];
            }
            if(reader[46] != DBNull.Value)
            {
                PCO0080003 = (System.Nullable<System.Int32>)reader[46];
            }
            if(reader[47] != DBNull.Value)
            {
                PCO0080004 = (System.Nullable<System.Int32>)reader[47];
            }
            if(reader[48] != DBNull.Value)
            {
                PCO0080005 = (System.Nullable<System.Int32>)reader[48];
            }
            if(reader[49] != DBNull.Value)
            {
                PCO0080006 = (System.Nullable<System.Int32>)reader[49];
            }
            if(reader[50] != DBNull.Value)
            {
                PCO0080007 = (System.Nullable<System.Int32>)reader[50];
            }
            if(reader[51] != DBNull.Value)
            {
                PCO0080008 = (System.Nullable<System.Int32>)reader[51];
            }
            if(reader[52] != DBNull.Value)
            {
                PCO0080009 = (System.Nullable<System.Int32>)reader[52];
            }
            if(reader[53] != DBNull.Value)
            {
                PCO0080010 = (System.Nullable<System.Int32>)reader[53];
            }
            if(reader[54] != DBNull.Value)
            {
                PCO0080011 = (System.Nullable<System.Int32>)reader[54];
            }
            if(reader[55] != DBNull.Value)
            {
                PCO0080012 = (System.Nullable<System.Int32>)reader[55];
            }
            if(reader[56] != DBNull.Value)
            {
                PCO0080013 = (System.Nullable<System.Int32>)reader[56];
            }
            if(reader[57] != DBNull.Value)
            {
                PCO0080014 = (System.Nullable<System.Int32>)reader[57];
            }
            if(reader[58] != DBNull.Value)
            {
                PCO0080015 = (System.Nullable<System.Int32>)reader[58];
            }
            if(reader[59] != DBNull.Value)
            {
                PCO0080016 = (System.Nullable<System.Int32>)reader[59];
            }
            if(reader[60] != DBNull.Value)
            {
                PCO0080017 = (System.Nullable<System.Int32>)reader[60];
            }
            if(reader[61] != DBNull.Value)
            {
                PCO0080018 = (System.Nullable<System.Int32>)reader[61];
            }
            if(reader[62] != DBNull.Value)
            {
                PCO0080019 = (System.Nullable<System.Int32>)reader[62];
            }
            if(reader[63] != DBNull.Value)
            {
                PCO0080020 = (System.Nullable<System.Int32>)reader[63];
            }
            if(reader[64] != DBNull.Value)
            {
                PCO0080021 = (System.Nullable<System.Int32>)reader[64];
            }
            if(reader[65] != DBNull.Value)
            {
                PCO0080022 = (System.Nullable<System.Int32>)reader[65];
            }
            if(reader[66] != DBNull.Value)
            {
                PCO0080023 = (System.Nullable<System.Int32>)reader[66];
            }
            if(reader[67] != DBNull.Value)
            {
                PCO0080024 = (System.Nullable<System.Int32>)reader[67];
            }
            if(reader[68] != DBNull.Value)
            {
                PCO0080025 = (System.Nullable<System.Int32>)reader[68];
            }
            if(reader[69] != DBNull.Value)
            {
                PCO0080026 = (System.Nullable<System.Int32>)reader[69];
            }
            if(reader[70] != DBNull.Value)
            {
                PCO0080027 = (System.Nullable<System.Int32>)reader[70];
            }
            if(reader[71] != DBNull.Value)
            {
                PCO0080028 = (System.Nullable<System.Int32>)reader[71];
            }
            if(reader[72] != DBNull.Value)
            {
                PCO0080029 = (System.Nullable<System.Int32>)reader[72];
            }
            if(reader[73] != DBNull.Value)
            {
                PCO0080030 = (System.Nullable<System.Int32>)reader[73];
            }
            if(reader[74] != DBNull.Value)
            {
                PCO0080031 = (System.Nullable<System.Int32>)reader[74];
            }
            if(reader[75] != DBNull.Value)
            {
                PCO0080032 = (System.Nullable<System.Int32>)reader[75];
            }
            if(reader[76] != DBNull.Value)
            {
                PCO0080033 = (System.Nullable<System.Int32>)reader[76];
            }
            if(reader[77] != DBNull.Value)
            {
                PCO0080034 = (System.Nullable<System.Int32>)reader[77];
            }
            if(reader[78] != DBNull.Value)
            {
                PCO0080035 = (System.Nullable<System.Int32>)reader[78];
            }
            if(reader[79] != DBNull.Value)
            {
                PCO0080036 = (System.Nullable<System.Int32>)reader[79];
            }
            if(reader[80] != DBNull.Value)
            {
                PCO0080037 = (System.Nullable<System.Int32>)reader[80];
            }
            if(reader[81] != DBNull.Value)
            {
                PCO0080038 = (System.Nullable<System.Int32>)reader[81];
            }
            if(reader[82] != DBNull.Value)
            {
                PCO0080039 = (System.Nullable<System.Int32>)reader[82];
            }
            if(reader[83] != DBNull.Value)
            {
                PCO0090001 = (System.Nullable<System.Int32>)reader[83];
            }
            if(reader[84] != DBNull.Value)
            {
                PCO0090002 = (System.Nullable<System.Int32>)reader[84];
            }
            if(reader[85] != DBNull.Value)
            {
                PCO0090003 = (System.Nullable<System.Int32>)reader[85];
            }
            if(reader[86] != DBNull.Value)
            {
                PCO0090004 = (System.Nullable<System.Int32>)reader[86];
            }
            if(reader[87] != DBNull.Value)
            {
                PCO0090005 = (System.Nullable<System.Int32>)reader[87];
            }
            if(reader[88] != DBNull.Value)
            {
                PCO0090006 = (System.Nullable<System.Int32>)reader[88];
            }
            if(reader[89] != DBNull.Value)
            {
                PCO0090007 = (System.Nullable<System.Int32>)reader[89];
            }
            if(reader[90] != DBNull.Value)
            {
                PCO0090008 = (System.Nullable<System.Int32>)reader[90];
            }
            if(reader[91] != DBNull.Value)
            {
                PCO0090009 = (System.Nullable<System.Int32>)reader[91];
            }
            if(reader[92] != DBNull.Value)
            {
                PCO0090010 = (System.Nullable<System.Int32>)reader[92];
            }
            if(reader[93] != DBNull.Value)
            {
                PCO0090011 = (System.Nullable<System.Int32>)reader[93];
            }
            if(reader[94] != DBNull.Value)
            {
                PCO0090012 = (System.Nullable<System.Int32>)reader[94];
            }
            if(reader[95] != DBNull.Value)
            {
                PCO0090013 = (System.Nullable<System.Int32>)reader[95];
            }
            if(reader[96] != DBNull.Value)
            {
                PCO0090014 = (System.Nullable<System.Int32>)reader[96];
            }
            if(reader[97] != DBNull.Value)
            {
                PCO0090015 = (System.Nullable<System.Int32>)reader[97];
            }
            if(reader[98] != DBNull.Value)
            {
                PCO0090016 = (System.Nullable<System.Int32>)reader[98];
            }
            if(reader[99] != DBNull.Value)
            {
                PCO0090017 = (System.Nullable<System.Int32>)reader[99];
            }
            if(reader[100] != DBNull.Value)
            {
                PCO0090018 = (System.Nullable<System.Int32>)reader[100];
            }
            if(reader[101] != DBNull.Value)
            {
                PCO0090019 = (System.Nullable<System.Int32>)reader[101];
            }
            if(reader[102] != DBNull.Value)
            {
                PCO0090020 = (System.Nullable<System.Int32>)reader[102];
            }
            if(reader[103] != DBNull.Value)
            {
                PCO0090021 = (System.Nullable<System.Int32>)reader[103];
            }
            if(reader[104] != DBNull.Value)
            {
                PCO0090022 = (System.Nullable<System.Int32>)reader[104];
            }
            if(reader[105] != DBNull.Value)
            {
                PCO0090023 = (System.Nullable<System.Int32>)reader[105];
            }
            if(reader[106] != DBNull.Value)
            {
                PCO0090024 = (System.Nullable<System.Int32>)reader[106];
            }
            if(reader[107] != DBNull.Value)
            {
                PCO0090025 = (System.Nullable<System.Int32>)reader[107];
            }
            if(reader[108] != DBNull.Value)
            {
                PCO0090026 = (System.Nullable<System.Int32>)reader[108];
            }
            if(reader[109] != DBNull.Value)
            {
                PCO0090027 = (System.Nullable<System.Int32>)reader[109];
            }
            if(reader[110] != DBNull.Value)
            {
                PCO0090028 = (System.Nullable<System.Int32>)reader[110];
            }
            if(reader[111] != DBNull.Value)
            {
                PCO0090029 = (System.Nullable<System.Int32>)reader[111];
            }
            if(reader[112] != DBNull.Value)
            {
                PCO0090030 = (System.Nullable<System.Int32>)reader[112];
            }
            if(reader[113] != DBNull.Value)
            {
                PCO0090031 = (System.Nullable<System.Int32>)reader[113];
            }
            if(reader[114] != DBNull.Value)
            {
                PCO0090032 = (System.Nullable<System.Int32>)reader[114];
            }
            if(reader[115] != DBNull.Value)
            {
                PCO0090033 = (System.Nullable<System.Int32>)reader[115];
            }
            if(reader[116] != DBNull.Value)
            {
                PCO0090034 = (System.Nullable<System.Int32>)reader[116];
            }
            if(reader[117] != DBNull.Value)
            {
                PCO0090035 = (System.Nullable<System.Int32>)reader[117];
            }
            if(reader[118] != DBNull.Value)
            {
                PCO0090036 = (System.Nullable<System.Int32>)reader[118];
            }
            if(reader[119] != DBNull.Value)
            {
                PCO0090037 = (System.Nullable<System.Int32>)reader[119];
            }
            if(reader[120] != DBNull.Value)
            {
                PCO0090038 = (System.Nullable<System.Int32>)reader[120];
            }
            if(reader[121] != DBNull.Value)
            {
                PCO0090039 = (System.Nullable<System.Int32>)reader[121];
            }
            if(reader[122] != DBNull.Value)
            {
                PCO0100001 = (System.Nullable<System.Int32>)reader[122];
            }
            if(reader[123] != DBNull.Value)
            {
                PCO0100002 = (System.Nullable<System.Int32>)reader[123];
            }
            if(reader[124] != DBNull.Value)
            {
                PCO0100003 = (System.Nullable<System.Int32>)reader[124];
            }
            if(reader[125] != DBNull.Value)
            {
                PCO0100004 = (System.Nullable<System.Int32>)reader[125];
            }
            if(reader[126] != DBNull.Value)
            {
                PCO0100005 = (System.Nullable<System.Int32>)reader[126];
            }
            if(reader[127] != DBNull.Value)
            {
                PCO0100006 = (System.Nullable<System.Int32>)reader[127];
            }
            if(reader[128] != DBNull.Value)
            {
                PCO0100007 = (System.Nullable<System.Int32>)reader[128];
            }
            if(reader[129] != DBNull.Value)
            {
                PCO0100008 = (System.Nullable<System.Int32>)reader[129];
            }
            if(reader[130] != DBNull.Value)
            {
                PCO0100009 = (System.Nullable<System.Int32>)reader[130];
            }
            if(reader[131] != DBNull.Value)
            {
                PCO0100010 = (System.Nullable<System.Int32>)reader[131];
            }
            if(reader[132] != DBNull.Value)
            {
                PCO0100011 = (System.Nullable<System.Int32>)reader[132];
            }
            if(reader[133] != DBNull.Value)
            {
                PCO0100012 = (System.Nullable<System.Int32>)reader[133];
            }
            if(reader[134] != DBNull.Value)
            {
                PCO0100013 = (System.Nullable<System.Int32>)reader[134];
            }
            if(reader[135] != DBNull.Value)
            {
                PCO0100014 = (System.Nullable<System.Int32>)reader[135];
            }
            if(reader[136] != DBNull.Value)
            {
                PCO0100015 = (System.Nullable<System.Int32>)reader[136];
            }
            if(reader[137] != DBNull.Value)
            {
                PCO0100016 = (System.Nullable<System.Int32>)reader[137];
            }
            if(reader[138] != DBNull.Value)
            {
                PCO0100017 = (System.Nullable<System.Int32>)reader[138];
            }
            if(reader[139] != DBNull.Value)
            {
                PCO0100018 = (System.Nullable<System.Int32>)reader[139];
            }
            if(reader[140] != DBNull.Value)
            {
                PCO0100019 = (System.Nullable<System.Int32>)reader[140];
            }
            if(reader[141] != DBNull.Value)
            {
                PCO0100020 = (System.Nullable<System.Int32>)reader[141];
            }
            if(reader[142] != DBNull.Value)
            {
                PCO0100021 = (System.Nullable<System.Int32>)reader[142];
            }
            if(reader[143] != DBNull.Value)
            {
                PCO0100022 = (System.Nullable<System.Int32>)reader[143];
            }
            if(reader[144] != DBNull.Value)
            {
                PCO0100023 = (System.Nullable<System.Int32>)reader[144];
            }
            if(reader[145] != DBNull.Value)
            {
                PCO0100024 = (System.Nullable<System.Int32>)reader[145];
            }
            if(reader[146] != DBNull.Value)
            {
                PCO0100025 = (System.Nullable<System.Int32>)reader[146];
            }
            if(reader[147] != DBNull.Value)
            {
                PCO0100026 = (System.Nullable<System.Int32>)reader[147];
            }
            if(reader[148] != DBNull.Value)
            {
                PCO0100027 = (System.Nullable<System.Int32>)reader[148];
            }
            if(reader[149] != DBNull.Value)
            {
                PCO0100028 = (System.Nullable<System.Int32>)reader[149];
            }
            if(reader[150] != DBNull.Value)
            {
                PCO0100029 = (System.Nullable<System.Int32>)reader[150];
            }
            if(reader[151] != DBNull.Value)
            {
                PCO0100030 = (System.Nullable<System.Int32>)reader[151];
            }
            if(reader[152] != DBNull.Value)
            {
                PCO0100031 = (System.Nullable<System.Int32>)reader[152];
            }
            if(reader[153] != DBNull.Value)
            {
                PCO0100032 = (System.Nullable<System.Int32>)reader[153];
            }
            if(reader[154] != DBNull.Value)
            {
                PCO0100033 = (System.Nullable<System.Int32>)reader[154];
            }
            if(reader[155] != DBNull.Value)
            {
                PCO0100034 = (System.Nullable<System.Int32>)reader[155];
            }
            if(reader[156] != DBNull.Value)
            {
                PCO0100035 = (System.Nullable<System.Int32>)reader[156];
            }
            if(reader[157] != DBNull.Value)
            {
                PCO0100036 = (System.Nullable<System.Int32>)reader[157];
            }
            if(reader[158] != DBNull.Value)
            {
                PCO0100037 = (System.Nullable<System.Int32>)reader[158];
            }
            if(reader[159] != DBNull.Value)
            {
                PCO0100038 = (System.Nullable<System.Int32>)reader[159];
            }
            if(reader[160] != DBNull.Value)
            {
                PCO0100039 = (System.Nullable<System.Int32>)reader[160];
            }
        }
        #endregion Constructors
    }
}