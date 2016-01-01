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

    [Table("SF1_00035")]
    public partial class SF1_00035 : BaseModel
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
        [Column("PCT013A001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public System.Nullable<System.Int32> PCT013A001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 6)]
        public System.Nullable<System.Int32> PCT013A002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 7)]
        public System.Nullable<System.Int32> PCT013A003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 8)]
        public System.Nullable<System.Int32> PCT013A004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 9)]
        public System.Nullable<System.Int32> PCT013A005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 10)]
        public System.Nullable<System.Int32> PCT013A006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 11)]
        public System.Nullable<System.Int32> PCT013A007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 12)]
        public System.Nullable<System.Int32> PCT013A008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 13)]
        public System.Nullable<System.Int32> PCT013A009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 14)]
        public System.Nullable<System.Int32> PCT013A010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 15)]
        public System.Nullable<System.Int32> PCT013A011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 16)]
        public System.Nullable<System.Int32> PCT013A012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 17)]
        public System.Nullable<System.Int32> PCT013A013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 18)]
        public System.Nullable<System.Int32> PCT013A014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 19)]
        public System.Nullable<System.Int32> PCT013A015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 20)]
        public System.Nullable<System.Int32> PCT013A016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A017", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 21)]
        public System.Nullable<System.Int32> PCT013A017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A018", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 22)]
        public System.Nullable<System.Int32> PCT013A018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A019", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 23)]
        public System.Nullable<System.Int32> PCT013A019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A020", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 24)]
        public System.Nullable<System.Int32> PCT013A020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A021", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 25)]
        public System.Nullable<System.Int32> PCT013A021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A022", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 26)]
        public System.Nullable<System.Int32> PCT013A022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A023", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 27)]
        public System.Nullable<System.Int32> PCT013A023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A024", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 28)]
        public System.Nullable<System.Int32> PCT013A024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A025", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 29)]
        public System.Nullable<System.Int32> PCT013A025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A026", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 30)]
        public System.Nullable<System.Int32> PCT013A026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A027", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 31)]
        public System.Nullable<System.Int32> PCT013A027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A028", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 32)]
        public System.Nullable<System.Int32> PCT013A028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A029", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 33)]
        public System.Nullable<System.Int32> PCT013A029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A030", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 34)]
        public System.Nullable<System.Int32> PCT013A030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A031", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 35)]
        public System.Nullable<System.Int32> PCT013A031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A032", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 36)]
        public System.Nullable<System.Int32> PCT013A032 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A033", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 37)]
        public System.Nullable<System.Int32> PCT013A033 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A034", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 38)]
        public System.Nullable<System.Int32> PCT013A034 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A035", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 39)]
        public System.Nullable<System.Int32> PCT013A035 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A036", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 40)]
        public System.Nullable<System.Int32> PCT013A036 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A037", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 41)]
        public System.Nullable<System.Int32> PCT013A037 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A038", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 42)]
        public System.Nullable<System.Int32> PCT013A038 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A039", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 43)]
        public System.Nullable<System.Int32> PCT013A039 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A040", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 44)]
        public System.Nullable<System.Int32> PCT013A040 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A041", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 45)]
        public System.Nullable<System.Int32> PCT013A041 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A042", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 46)]
        public System.Nullable<System.Int32> PCT013A042 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A043", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 47)]
        public System.Nullable<System.Int32> PCT013A043 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A044", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 48)]
        public System.Nullable<System.Int32> PCT013A044 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A045", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 49)]
        public System.Nullable<System.Int32> PCT013A045 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A046", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 50)]
        public System.Nullable<System.Int32> PCT013A046 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A047", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 51)]
        public System.Nullable<System.Int32> PCT013A047 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A048", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 52)]
        public System.Nullable<System.Int32> PCT013A048 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013A049", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 53)]
        public System.Nullable<System.Int32> PCT013A049 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B001", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 54)]
        public System.Nullable<System.Int32> PCT013B001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B002", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 55)]
        public System.Nullable<System.Int32> PCT013B002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B003", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 56)]
        public System.Nullable<System.Int32> PCT013B003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B004", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 57)]
        public System.Nullable<System.Int32> PCT013B004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B005", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 58)]
        public System.Nullable<System.Int32> PCT013B005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B006", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 59)]
        public System.Nullable<System.Int32> PCT013B006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B007", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 60)]
        public System.Nullable<System.Int32> PCT013B007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B008", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 61)]
        public System.Nullable<System.Int32> PCT013B008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B009", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 62)]
        public System.Nullable<System.Int32> PCT013B009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B010", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 63)]
        public System.Nullable<System.Int32> PCT013B010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B011", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 64)]
        public System.Nullable<System.Int32> PCT013B011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B012", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 65)]
        public System.Nullable<System.Int32> PCT013B012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B013", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 66)]
        public System.Nullable<System.Int32> PCT013B013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B014", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 67)]
        public System.Nullable<System.Int32> PCT013B014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B015", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 68)]
        public System.Nullable<System.Int32> PCT013B015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B016", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 69)]
        public System.Nullable<System.Int32> PCT013B016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B017", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 70)]
        public System.Nullable<System.Int32> PCT013B017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B018", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 71)]
        public System.Nullable<System.Int32> PCT013B018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B019", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 72)]
        public System.Nullable<System.Int32> PCT013B019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B020", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 73)]
        public System.Nullable<System.Int32> PCT013B020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B021", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 74)]
        public System.Nullable<System.Int32> PCT013B021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B022", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 75)]
        public System.Nullable<System.Int32> PCT013B022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B023", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 76)]
        public System.Nullable<System.Int32> PCT013B023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B024", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 77)]
        public System.Nullable<System.Int32> PCT013B024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B025", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 78)]
        public System.Nullable<System.Int32> PCT013B025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B026", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 79)]
        public System.Nullable<System.Int32> PCT013B026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B027", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 80)]
        public System.Nullable<System.Int32> PCT013B027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B028", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 81)]
        public System.Nullable<System.Int32> PCT013B028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B029", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 82)]
        public System.Nullable<System.Int32> PCT013B029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B030", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 83)]
        public System.Nullable<System.Int32> PCT013B030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B031", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 84)]
        public System.Nullable<System.Int32> PCT013B031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B032", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 85)]
        public System.Nullable<System.Int32> PCT013B032 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B033", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 86)]
        public System.Nullable<System.Int32> PCT013B033 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B034", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 87)]
        public System.Nullable<System.Int32> PCT013B034 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B035", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 88)]
        public System.Nullable<System.Int32> PCT013B035 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B036", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 89)]
        public System.Nullable<System.Int32> PCT013B036 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B037", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 90)]
        public System.Nullable<System.Int32> PCT013B037 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B038", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 91)]
        public System.Nullable<System.Int32> PCT013B038 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B039", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 92)]
        public System.Nullable<System.Int32> PCT013B039 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B040", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 93)]
        public System.Nullable<System.Int32> PCT013B040 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B041", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 94)]
        public System.Nullable<System.Int32> PCT013B041 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B042", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 95)]
        public System.Nullable<System.Int32> PCT013B042 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B043", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 96)]
        public System.Nullable<System.Int32> PCT013B043 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B044", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 97)]
        public System.Nullable<System.Int32> PCT013B044 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B045", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 98)]
        public System.Nullable<System.Int32> PCT013B045 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B046", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 99)]
        public System.Nullable<System.Int32> PCT013B046 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B047", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 100)]
        public System.Nullable<System.Int32> PCT013B047 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B048", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 101)]
        public System.Nullable<System.Int32> PCT013B048 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013B049", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 102)]
        public System.Nullable<System.Int32> PCT013B049 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C001", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 103)]
        public System.Nullable<System.Int32> PCT013C001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C002", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 104)]
        public System.Nullable<System.Int32> PCT013C002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C003", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 105)]
        public System.Nullable<System.Int32> PCT013C003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C004", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 106)]
        public System.Nullable<System.Int32> PCT013C004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C005", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 107)]
        public System.Nullable<System.Int32> PCT013C005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C006", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 108)]
        public System.Nullable<System.Int32> PCT013C006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C007", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 109)]
        public System.Nullable<System.Int32> PCT013C007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C008", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 110)]
        public System.Nullable<System.Int32> PCT013C008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C009", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 111)]
        public System.Nullable<System.Int32> PCT013C009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C010", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 112)]
        public System.Nullable<System.Int32> PCT013C010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C011", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 113)]
        public System.Nullable<System.Int32> PCT013C011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C012", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 114)]
        public System.Nullable<System.Int32> PCT013C012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C013", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 115)]
        public System.Nullable<System.Int32> PCT013C013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C014", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 116)]
        public System.Nullable<System.Int32> PCT013C014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C015", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 117)]
        public System.Nullable<System.Int32> PCT013C015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C016", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 118)]
        public System.Nullable<System.Int32> PCT013C016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C017", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 119)]
        public System.Nullable<System.Int32> PCT013C017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C018", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 120)]
        public System.Nullable<System.Int32> PCT013C018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C019", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 121)]
        public System.Nullable<System.Int32> PCT013C019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C020", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 122)]
        public System.Nullable<System.Int32> PCT013C020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C021", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 123)]
        public System.Nullable<System.Int32> PCT013C021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C022", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 124)]
        public System.Nullable<System.Int32> PCT013C022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C023", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 125)]
        public System.Nullable<System.Int32> PCT013C023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C024", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 126)]
        public System.Nullable<System.Int32> PCT013C024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C025", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 127)]
        public System.Nullable<System.Int32> PCT013C025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C026", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 128)]
        public System.Nullable<System.Int32> PCT013C026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C027", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 129)]
        public System.Nullable<System.Int32> PCT013C027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C028", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 130)]
        public System.Nullable<System.Int32> PCT013C028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C029", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 131)]
        public System.Nullable<System.Int32> PCT013C029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C030", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 132)]
        public System.Nullable<System.Int32> PCT013C030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C031", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 133)]
        public System.Nullable<System.Int32> PCT013C031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C032", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 134)]
        public System.Nullable<System.Int32> PCT013C032 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C033", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 135)]
        public System.Nullable<System.Int32> PCT013C033 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C034", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 136)]
        public System.Nullable<System.Int32> PCT013C034 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C035", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 137)]
        public System.Nullable<System.Int32> PCT013C035 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C036", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 138)]
        public System.Nullable<System.Int32> PCT013C036 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C037", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 139)]
        public System.Nullable<System.Int32> PCT013C037 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C038", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 140)]
        public System.Nullable<System.Int32> PCT013C038 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C039", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 141)]
        public System.Nullable<System.Int32> PCT013C039 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C040", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 142)]
        public System.Nullable<System.Int32> PCT013C040 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C041", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 143)]
        public System.Nullable<System.Int32> PCT013C041 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C042", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 144)]
        public System.Nullable<System.Int32> PCT013C042 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C043", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 145)]
        public System.Nullable<System.Int32> PCT013C043 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C044", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 146)]
        public System.Nullable<System.Int32> PCT013C044 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C045", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 147)]
        public System.Nullable<System.Int32> PCT013C045 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C046", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 148)]
        public System.Nullable<System.Int32> PCT013C046 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C047", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 149)]
        public System.Nullable<System.Int32> PCT013C047 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C048", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 150)]
        public System.Nullable<System.Int32> PCT013C048 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013C049", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 151)]
        public System.Nullable<System.Int32> PCT013C049 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D001", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 152)]
        public System.Nullable<System.Int32> PCT013D001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D002", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 153)]
        public System.Nullable<System.Int32> PCT013D002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D003", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 154)]
        public System.Nullable<System.Int32> PCT013D003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D004", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 155)]
        public System.Nullable<System.Int32> PCT013D004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D005", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 156)]
        public System.Nullable<System.Int32> PCT013D005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D006", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 157)]
        public System.Nullable<System.Int32> PCT013D006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D007", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 158)]
        public System.Nullable<System.Int32> PCT013D007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D008", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 159)]
        public System.Nullable<System.Int32> PCT013D008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D009", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 160)]
        public System.Nullable<System.Int32> PCT013D009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D010", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 161)]
        public System.Nullable<System.Int32> PCT013D010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D011", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 162)]
        public System.Nullable<System.Int32> PCT013D011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D012", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 163)]
        public System.Nullable<System.Int32> PCT013D012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D013", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 164)]
        public System.Nullable<System.Int32> PCT013D013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D014", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 165)]
        public System.Nullable<System.Int32> PCT013D014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D015", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 166)]
        public System.Nullable<System.Int32> PCT013D015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D016", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 167)]
        public System.Nullable<System.Int32> PCT013D016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D017", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 168)]
        public System.Nullable<System.Int32> PCT013D017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D018", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 169)]
        public System.Nullable<System.Int32> PCT013D018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D019", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 170)]
        public System.Nullable<System.Int32> PCT013D019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D020", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 171)]
        public System.Nullable<System.Int32> PCT013D020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D021", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 172)]
        public System.Nullable<System.Int32> PCT013D021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D022", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 173)]
        public System.Nullable<System.Int32> PCT013D022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D023", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 174)]
        public System.Nullable<System.Int32> PCT013D023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D024", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 175)]
        public System.Nullable<System.Int32> PCT013D024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D025", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 176)]
        public System.Nullable<System.Int32> PCT013D025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D026", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 177)]
        public System.Nullable<System.Int32> PCT013D026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D027", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 178)]
        public System.Nullable<System.Int32> PCT013D027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D028", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 179)]
        public System.Nullable<System.Int32> PCT013D028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D029", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 180)]
        public System.Nullable<System.Int32> PCT013D029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D030", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 181)]
        public System.Nullable<System.Int32> PCT013D030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D031", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 182)]
        public System.Nullable<System.Int32> PCT013D031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D032", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 183)]
        public System.Nullable<System.Int32> PCT013D032 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D033", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 184)]
        public System.Nullable<System.Int32> PCT013D033 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D034", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 185)]
        public System.Nullable<System.Int32> PCT013D034 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D035", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 186)]
        public System.Nullable<System.Int32> PCT013D035 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D036", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 187)]
        public System.Nullable<System.Int32> PCT013D036 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D037", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 188)]
        public System.Nullable<System.Int32> PCT013D037 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D038", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 189)]
        public System.Nullable<System.Int32> PCT013D038 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D039", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 190)]
        public System.Nullable<System.Int32> PCT013D039 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D040", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 191)]
        public System.Nullable<System.Int32> PCT013D040 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D041", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 192)]
        public System.Nullable<System.Int32> PCT013D041 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D042", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 193)]
        public System.Nullable<System.Int32> PCT013D042 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D043", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 194)]
        public System.Nullable<System.Int32> PCT013D043 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D044", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 195)]
        public System.Nullable<System.Int32> PCT013D044 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D045", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 196)]
        public System.Nullable<System.Int32> PCT013D045 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D046", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 197)]
        public System.Nullable<System.Int32> PCT013D046 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D047", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 198)]
        public System.Nullable<System.Int32> PCT013D047 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D048", Order = 199)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 199)]
        public System.Nullable<System.Int32> PCT013D048 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013D049", Order = 200)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 200)]
        public System.Nullable<System.Int32> PCT013D049 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E001", Order = 201)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 201)]
        public System.Nullable<System.Int32> PCT013E001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E002", Order = 202)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 202)]
        public System.Nullable<System.Int32> PCT013E002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E003", Order = 203)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 203)]
        public System.Nullable<System.Int32> PCT013E003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E004", Order = 204)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 204)]
        public System.Nullable<System.Int32> PCT013E004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E005", Order = 205)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 205)]
        public System.Nullable<System.Int32> PCT013E005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E006", Order = 206)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 206)]
        public System.Nullable<System.Int32> PCT013E006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E007", Order = 207)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 207)]
        public System.Nullable<System.Int32> PCT013E007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E008", Order = 208)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 208)]
        public System.Nullable<System.Int32> PCT013E008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E009", Order = 209)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 209)]
        public System.Nullable<System.Int32> PCT013E009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E010", Order = 210)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 210)]
        public System.Nullable<System.Int32> PCT013E010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E011", Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 211)]
        public System.Nullable<System.Int32> PCT013E011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E012", Order = 212)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 212)]
        public System.Nullable<System.Int32> PCT013E012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E013", Order = 213)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 213)]
        public System.Nullable<System.Int32> PCT013E013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E014", Order = 214)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 214)]
        public System.Nullable<System.Int32> PCT013E014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E015", Order = 215)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 215)]
        public System.Nullable<System.Int32> PCT013E015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E016", Order = 216)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 216)]
        public System.Nullable<System.Int32> PCT013E016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E017", Order = 217)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 217)]
        public System.Nullable<System.Int32> PCT013E017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E018", Order = 218)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 218)]
        public System.Nullable<System.Int32> PCT013E018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E019", Order = 219)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 219)]
        public System.Nullable<System.Int32> PCT013E019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E020", Order = 220)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 220)]
        public System.Nullable<System.Int32> PCT013E020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E021", Order = 221)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 221)]
        public System.Nullable<System.Int32> PCT013E021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E022", Order = 222)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 222)]
        public System.Nullable<System.Int32> PCT013E022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E023", Order = 223)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 223)]
        public System.Nullable<System.Int32> PCT013E023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E024", Order = 224)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 224)]
        public System.Nullable<System.Int32> PCT013E024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E025", Order = 225)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 225)]
        public System.Nullable<System.Int32> PCT013E025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E026", Order = 226)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 226)]
        public System.Nullable<System.Int32> PCT013E026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E027", Order = 227)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 227)]
        public System.Nullable<System.Int32> PCT013E027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E028", Order = 228)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 228)]
        public System.Nullable<System.Int32> PCT013E028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E029", Order = 229)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 229)]
        public System.Nullable<System.Int32> PCT013E029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E030", Order = 230)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 230)]
        public System.Nullable<System.Int32> PCT013E030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E031", Order = 231)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 231)]
        public System.Nullable<System.Int32> PCT013E031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E032", Order = 232)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 232)]
        public System.Nullable<System.Int32> PCT013E032 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E033", Order = 233)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 233)]
        public System.Nullable<System.Int32> PCT013E033 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E034", Order = 234)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 234)]
        public System.Nullable<System.Int32> PCT013E034 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E035", Order = 235)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 235)]
        public System.Nullable<System.Int32> PCT013E035 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E036", Order = 236)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 236)]
        public System.Nullable<System.Int32> PCT013E036 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E037", Order = 237)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 237)]
        public System.Nullable<System.Int32> PCT013E037 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E038", Order = 238)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 238)]
        public System.Nullable<System.Int32> PCT013E038 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E039", Order = 239)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 239)]
        public System.Nullable<System.Int32> PCT013E039 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E040", Order = 240)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 240)]
        public System.Nullable<System.Int32> PCT013E040 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E041", Order = 241)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 241)]
        public System.Nullable<System.Int32> PCT013E041 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E042", Order = 242)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 242)]
        public System.Nullable<System.Int32> PCT013E042 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E043", Order = 243)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 243)]
        public System.Nullable<System.Int32> PCT013E043 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E044", Order = 244)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 244)]
        public System.Nullable<System.Int32> PCT013E044 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E045", Order = 245)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 245)]
        public System.Nullable<System.Int32> PCT013E045 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E046", Order = 246)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 246)]
        public System.Nullable<System.Int32> PCT013E046 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E047", Order = 247)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 247)]
        public System.Nullable<System.Int32> PCT013E047 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E048", Order = 248)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 248)]
        public System.Nullable<System.Int32> PCT013E048 { get; set; }

        [ReadOnly(false)]
        [Column("PCT013E049", Order = 249)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 249)]
        public System.Nullable<System.Int32> PCT013E049 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1_00035(string csvLine) : base(csvLine) {}

        public SF1_00035(string[] values) : base(values) {}

        public SF1_00035(OleDbDataReader reader, CensusFileType fileType)
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
                PCT013A001 = (System.Nullable<System.Int32>)reader[5];
            }
            if(reader[6] != DBNull.Value)
            {
                PCT013A002 = (System.Nullable<System.Int32>)reader[6];
            }
            if(reader[7] != DBNull.Value)
            {
                PCT013A003 = (System.Nullable<System.Int32>)reader[7];
            }
            if(reader[8] != DBNull.Value)
            {
                PCT013A004 = (System.Nullable<System.Int32>)reader[8];
            }
            if(reader[9] != DBNull.Value)
            {
                PCT013A005 = (System.Nullable<System.Int32>)reader[9];
            }
            if(reader[10] != DBNull.Value)
            {
                PCT013A006 = (System.Nullable<System.Int32>)reader[10];
            }
            if(reader[11] != DBNull.Value)
            {
                PCT013A007 = (System.Nullable<System.Int32>)reader[11];
            }
            if(reader[12] != DBNull.Value)
            {
                PCT013A008 = (System.Nullable<System.Int32>)reader[12];
            }
            if(reader[13] != DBNull.Value)
            {
                PCT013A009 = (System.Nullable<System.Int32>)reader[13];
            }
            if(reader[14] != DBNull.Value)
            {
                PCT013A010 = (System.Nullable<System.Int32>)reader[14];
            }
            if(reader[15] != DBNull.Value)
            {
                PCT013A011 = (System.Nullable<System.Int32>)reader[15];
            }
            if(reader[16] != DBNull.Value)
            {
                PCT013A012 = (System.Nullable<System.Int32>)reader[16];
            }
            if(reader[17] != DBNull.Value)
            {
                PCT013A013 = (System.Nullable<System.Int32>)reader[17];
            }
            if(reader[18] != DBNull.Value)
            {
                PCT013A014 = (System.Nullable<System.Int32>)reader[18];
            }
            if(reader[19] != DBNull.Value)
            {
                PCT013A015 = (System.Nullable<System.Int32>)reader[19];
            }
            if(reader[20] != DBNull.Value)
            {
                PCT013A016 = (System.Nullable<System.Int32>)reader[20];
            }
            if(reader[21] != DBNull.Value)
            {
                PCT013A017 = (System.Nullable<System.Int32>)reader[21];
            }
            if(reader[22] != DBNull.Value)
            {
                PCT013A018 = (System.Nullable<System.Int32>)reader[22];
            }
            if(reader[23] != DBNull.Value)
            {
                PCT013A019 = (System.Nullable<System.Int32>)reader[23];
            }
            if(reader[24] != DBNull.Value)
            {
                PCT013A020 = (System.Nullable<System.Int32>)reader[24];
            }
            if(reader[25] != DBNull.Value)
            {
                PCT013A021 = (System.Nullable<System.Int32>)reader[25];
            }
            if(reader[26] != DBNull.Value)
            {
                PCT013A022 = (System.Nullable<System.Int32>)reader[26];
            }
            if(reader[27] != DBNull.Value)
            {
                PCT013A023 = (System.Nullable<System.Int32>)reader[27];
            }
            if(reader[28] != DBNull.Value)
            {
                PCT013A024 = (System.Nullable<System.Int32>)reader[28];
            }
            if(reader[29] != DBNull.Value)
            {
                PCT013A025 = (System.Nullable<System.Int32>)reader[29];
            }
            if(reader[30] != DBNull.Value)
            {
                PCT013A026 = (System.Nullable<System.Int32>)reader[30];
            }
            if(reader[31] != DBNull.Value)
            {
                PCT013A027 = (System.Nullable<System.Int32>)reader[31];
            }
            if(reader[32] != DBNull.Value)
            {
                PCT013A028 = (System.Nullable<System.Int32>)reader[32];
            }
            if(reader[33] != DBNull.Value)
            {
                PCT013A029 = (System.Nullable<System.Int32>)reader[33];
            }
            if(reader[34] != DBNull.Value)
            {
                PCT013A030 = (System.Nullable<System.Int32>)reader[34];
            }
            if(reader[35] != DBNull.Value)
            {
                PCT013A031 = (System.Nullable<System.Int32>)reader[35];
            }
            if(reader[36] != DBNull.Value)
            {
                PCT013A032 = (System.Nullable<System.Int32>)reader[36];
            }
            if(reader[37] != DBNull.Value)
            {
                PCT013A033 = (System.Nullable<System.Int32>)reader[37];
            }
            if(reader[38] != DBNull.Value)
            {
                PCT013A034 = (System.Nullable<System.Int32>)reader[38];
            }
            if(reader[39] != DBNull.Value)
            {
                PCT013A035 = (System.Nullable<System.Int32>)reader[39];
            }
            if(reader[40] != DBNull.Value)
            {
                PCT013A036 = (System.Nullable<System.Int32>)reader[40];
            }
            if(reader[41] != DBNull.Value)
            {
                PCT013A037 = (System.Nullable<System.Int32>)reader[41];
            }
            if(reader[42] != DBNull.Value)
            {
                PCT013A038 = (System.Nullable<System.Int32>)reader[42];
            }
            if(reader[43] != DBNull.Value)
            {
                PCT013A039 = (System.Nullable<System.Int32>)reader[43];
            }
            if(reader[44] != DBNull.Value)
            {
                PCT013A040 = (System.Nullable<System.Int32>)reader[44];
            }
            if(reader[45] != DBNull.Value)
            {
                PCT013A041 = (System.Nullable<System.Int32>)reader[45];
            }
            if(reader[46] != DBNull.Value)
            {
                PCT013A042 = (System.Nullable<System.Int32>)reader[46];
            }
            if(reader[47] != DBNull.Value)
            {
                PCT013A043 = (System.Nullable<System.Int32>)reader[47];
            }
            if(reader[48] != DBNull.Value)
            {
                PCT013A044 = (System.Nullable<System.Int32>)reader[48];
            }
            if(reader[49] != DBNull.Value)
            {
                PCT013A045 = (System.Nullable<System.Int32>)reader[49];
            }
            if(reader[50] != DBNull.Value)
            {
                PCT013A046 = (System.Nullable<System.Int32>)reader[50];
            }
            if(reader[51] != DBNull.Value)
            {
                PCT013A047 = (System.Nullable<System.Int32>)reader[51];
            }
            if(reader[52] != DBNull.Value)
            {
                PCT013A048 = (System.Nullable<System.Int32>)reader[52];
            }
            if(reader[53] != DBNull.Value)
            {
                PCT013A049 = (System.Nullable<System.Int32>)reader[53];
            }
            if(reader[54] != DBNull.Value)
            {
                PCT013B001 = (System.Nullable<System.Int32>)reader[54];
            }
            if(reader[55] != DBNull.Value)
            {
                PCT013B002 = (System.Nullable<System.Int32>)reader[55];
            }
            if(reader[56] != DBNull.Value)
            {
                PCT013B003 = (System.Nullable<System.Int32>)reader[56];
            }
            if(reader[57] != DBNull.Value)
            {
                PCT013B004 = (System.Nullable<System.Int32>)reader[57];
            }
            if(reader[58] != DBNull.Value)
            {
                PCT013B005 = (System.Nullable<System.Int32>)reader[58];
            }
            if(reader[59] != DBNull.Value)
            {
                PCT013B006 = (System.Nullable<System.Int32>)reader[59];
            }
            if(reader[60] != DBNull.Value)
            {
                PCT013B007 = (System.Nullable<System.Int32>)reader[60];
            }
            if(reader[61] != DBNull.Value)
            {
                PCT013B008 = (System.Nullable<System.Int32>)reader[61];
            }
            if(reader[62] != DBNull.Value)
            {
                PCT013B009 = (System.Nullable<System.Int32>)reader[62];
            }
            if(reader[63] != DBNull.Value)
            {
                PCT013B010 = (System.Nullable<System.Int32>)reader[63];
            }
            if(reader[64] != DBNull.Value)
            {
                PCT013B011 = (System.Nullable<System.Int32>)reader[64];
            }
            if(reader[65] != DBNull.Value)
            {
                PCT013B012 = (System.Nullable<System.Int32>)reader[65];
            }
            if(reader[66] != DBNull.Value)
            {
                PCT013B013 = (System.Nullable<System.Int32>)reader[66];
            }
            if(reader[67] != DBNull.Value)
            {
                PCT013B014 = (System.Nullable<System.Int32>)reader[67];
            }
            if(reader[68] != DBNull.Value)
            {
                PCT013B015 = (System.Nullable<System.Int32>)reader[68];
            }
            if(reader[69] != DBNull.Value)
            {
                PCT013B016 = (System.Nullable<System.Int32>)reader[69];
            }
            if(reader[70] != DBNull.Value)
            {
                PCT013B017 = (System.Nullable<System.Int32>)reader[70];
            }
            if(reader[71] != DBNull.Value)
            {
                PCT013B018 = (System.Nullable<System.Int32>)reader[71];
            }
            if(reader[72] != DBNull.Value)
            {
                PCT013B019 = (System.Nullable<System.Int32>)reader[72];
            }
            if(reader[73] != DBNull.Value)
            {
                PCT013B020 = (System.Nullable<System.Int32>)reader[73];
            }
            if(reader[74] != DBNull.Value)
            {
                PCT013B021 = (System.Nullable<System.Int32>)reader[74];
            }
            if(reader[75] != DBNull.Value)
            {
                PCT013B022 = (System.Nullable<System.Int32>)reader[75];
            }
            if(reader[76] != DBNull.Value)
            {
                PCT013B023 = (System.Nullable<System.Int32>)reader[76];
            }
            if(reader[77] != DBNull.Value)
            {
                PCT013B024 = (System.Nullable<System.Int32>)reader[77];
            }
            if(reader[78] != DBNull.Value)
            {
                PCT013B025 = (System.Nullable<System.Int32>)reader[78];
            }
            if(reader[79] != DBNull.Value)
            {
                PCT013B026 = (System.Nullable<System.Int32>)reader[79];
            }
            if(reader[80] != DBNull.Value)
            {
                PCT013B027 = (System.Nullable<System.Int32>)reader[80];
            }
            if(reader[81] != DBNull.Value)
            {
                PCT013B028 = (System.Nullable<System.Int32>)reader[81];
            }
            if(reader[82] != DBNull.Value)
            {
                PCT013B029 = (System.Nullable<System.Int32>)reader[82];
            }
            if(reader[83] != DBNull.Value)
            {
                PCT013B030 = (System.Nullable<System.Int32>)reader[83];
            }
            if(reader[84] != DBNull.Value)
            {
                PCT013B031 = (System.Nullable<System.Int32>)reader[84];
            }
            if(reader[85] != DBNull.Value)
            {
                PCT013B032 = (System.Nullable<System.Int32>)reader[85];
            }
            if(reader[86] != DBNull.Value)
            {
                PCT013B033 = (System.Nullable<System.Int32>)reader[86];
            }
            if(reader[87] != DBNull.Value)
            {
                PCT013B034 = (System.Nullable<System.Int32>)reader[87];
            }
            if(reader[88] != DBNull.Value)
            {
                PCT013B035 = (System.Nullable<System.Int32>)reader[88];
            }
            if(reader[89] != DBNull.Value)
            {
                PCT013B036 = (System.Nullable<System.Int32>)reader[89];
            }
            if(reader[90] != DBNull.Value)
            {
                PCT013B037 = (System.Nullable<System.Int32>)reader[90];
            }
            if(reader[91] != DBNull.Value)
            {
                PCT013B038 = (System.Nullable<System.Int32>)reader[91];
            }
            if(reader[92] != DBNull.Value)
            {
                PCT013B039 = (System.Nullable<System.Int32>)reader[92];
            }
            if(reader[93] != DBNull.Value)
            {
                PCT013B040 = (System.Nullable<System.Int32>)reader[93];
            }
            if(reader[94] != DBNull.Value)
            {
                PCT013B041 = (System.Nullable<System.Int32>)reader[94];
            }
            if(reader[95] != DBNull.Value)
            {
                PCT013B042 = (System.Nullable<System.Int32>)reader[95];
            }
            if(reader[96] != DBNull.Value)
            {
                PCT013B043 = (System.Nullable<System.Int32>)reader[96];
            }
            if(reader[97] != DBNull.Value)
            {
                PCT013B044 = (System.Nullable<System.Int32>)reader[97];
            }
            if(reader[98] != DBNull.Value)
            {
                PCT013B045 = (System.Nullable<System.Int32>)reader[98];
            }
            if(reader[99] != DBNull.Value)
            {
                PCT013B046 = (System.Nullable<System.Int32>)reader[99];
            }
            if(reader[100] != DBNull.Value)
            {
                PCT013B047 = (System.Nullable<System.Int32>)reader[100];
            }
            if(reader[101] != DBNull.Value)
            {
                PCT013B048 = (System.Nullable<System.Int32>)reader[101];
            }
            if(reader[102] != DBNull.Value)
            {
                PCT013B049 = (System.Nullable<System.Int32>)reader[102];
            }
            if(reader[103] != DBNull.Value)
            {
                PCT013C001 = (System.Nullable<System.Int32>)reader[103];
            }
            if(reader[104] != DBNull.Value)
            {
                PCT013C002 = (System.Nullable<System.Int32>)reader[104];
            }
            if(reader[105] != DBNull.Value)
            {
                PCT013C003 = (System.Nullable<System.Int32>)reader[105];
            }
            if(reader[106] != DBNull.Value)
            {
                PCT013C004 = (System.Nullable<System.Int32>)reader[106];
            }
            if(reader[107] != DBNull.Value)
            {
                PCT013C005 = (System.Nullable<System.Int32>)reader[107];
            }
            if(reader[108] != DBNull.Value)
            {
                PCT013C006 = (System.Nullable<System.Int32>)reader[108];
            }
            if(reader[109] != DBNull.Value)
            {
                PCT013C007 = (System.Nullable<System.Int32>)reader[109];
            }
            if(reader[110] != DBNull.Value)
            {
                PCT013C008 = (System.Nullable<System.Int32>)reader[110];
            }
            if(reader[111] != DBNull.Value)
            {
                PCT013C009 = (System.Nullable<System.Int32>)reader[111];
            }
            if(reader[112] != DBNull.Value)
            {
                PCT013C010 = (System.Nullable<System.Int32>)reader[112];
            }
            if(reader[113] != DBNull.Value)
            {
                PCT013C011 = (System.Nullable<System.Int32>)reader[113];
            }
            if(reader[114] != DBNull.Value)
            {
                PCT013C012 = (System.Nullable<System.Int32>)reader[114];
            }
            if(reader[115] != DBNull.Value)
            {
                PCT013C013 = (System.Nullable<System.Int32>)reader[115];
            }
            if(reader[116] != DBNull.Value)
            {
                PCT013C014 = (System.Nullable<System.Int32>)reader[116];
            }
            if(reader[117] != DBNull.Value)
            {
                PCT013C015 = (System.Nullable<System.Int32>)reader[117];
            }
            if(reader[118] != DBNull.Value)
            {
                PCT013C016 = (System.Nullable<System.Int32>)reader[118];
            }
            if(reader[119] != DBNull.Value)
            {
                PCT013C017 = (System.Nullable<System.Int32>)reader[119];
            }
            if(reader[120] != DBNull.Value)
            {
                PCT013C018 = (System.Nullable<System.Int32>)reader[120];
            }
            if(reader[121] != DBNull.Value)
            {
                PCT013C019 = (System.Nullable<System.Int32>)reader[121];
            }
            if(reader[122] != DBNull.Value)
            {
                PCT013C020 = (System.Nullable<System.Int32>)reader[122];
            }
            if(reader[123] != DBNull.Value)
            {
                PCT013C021 = (System.Nullable<System.Int32>)reader[123];
            }
            if(reader[124] != DBNull.Value)
            {
                PCT013C022 = (System.Nullable<System.Int32>)reader[124];
            }
            if(reader[125] != DBNull.Value)
            {
                PCT013C023 = (System.Nullable<System.Int32>)reader[125];
            }
            if(reader[126] != DBNull.Value)
            {
                PCT013C024 = (System.Nullable<System.Int32>)reader[126];
            }
            if(reader[127] != DBNull.Value)
            {
                PCT013C025 = (System.Nullable<System.Int32>)reader[127];
            }
            if(reader[128] != DBNull.Value)
            {
                PCT013C026 = (System.Nullable<System.Int32>)reader[128];
            }
            if(reader[129] != DBNull.Value)
            {
                PCT013C027 = (System.Nullable<System.Int32>)reader[129];
            }
            if(reader[130] != DBNull.Value)
            {
                PCT013C028 = (System.Nullable<System.Int32>)reader[130];
            }
            if(reader[131] != DBNull.Value)
            {
                PCT013C029 = (System.Nullable<System.Int32>)reader[131];
            }
            if(reader[132] != DBNull.Value)
            {
                PCT013C030 = (System.Nullable<System.Int32>)reader[132];
            }
            if(reader[133] != DBNull.Value)
            {
                PCT013C031 = (System.Nullable<System.Int32>)reader[133];
            }
            if(reader[134] != DBNull.Value)
            {
                PCT013C032 = (System.Nullable<System.Int32>)reader[134];
            }
            if(reader[135] != DBNull.Value)
            {
                PCT013C033 = (System.Nullable<System.Int32>)reader[135];
            }
            if(reader[136] != DBNull.Value)
            {
                PCT013C034 = (System.Nullable<System.Int32>)reader[136];
            }
            if(reader[137] != DBNull.Value)
            {
                PCT013C035 = (System.Nullable<System.Int32>)reader[137];
            }
            if(reader[138] != DBNull.Value)
            {
                PCT013C036 = (System.Nullable<System.Int32>)reader[138];
            }
            if(reader[139] != DBNull.Value)
            {
                PCT013C037 = (System.Nullable<System.Int32>)reader[139];
            }
            if(reader[140] != DBNull.Value)
            {
                PCT013C038 = (System.Nullable<System.Int32>)reader[140];
            }
            if(reader[141] != DBNull.Value)
            {
                PCT013C039 = (System.Nullable<System.Int32>)reader[141];
            }
            if(reader[142] != DBNull.Value)
            {
                PCT013C040 = (System.Nullable<System.Int32>)reader[142];
            }
            if(reader[143] != DBNull.Value)
            {
                PCT013C041 = (System.Nullable<System.Int32>)reader[143];
            }
            if(reader[144] != DBNull.Value)
            {
                PCT013C042 = (System.Nullable<System.Int32>)reader[144];
            }
            if(reader[145] != DBNull.Value)
            {
                PCT013C043 = (System.Nullable<System.Int32>)reader[145];
            }
            if(reader[146] != DBNull.Value)
            {
                PCT013C044 = (System.Nullable<System.Int32>)reader[146];
            }
            if(reader[147] != DBNull.Value)
            {
                PCT013C045 = (System.Nullable<System.Int32>)reader[147];
            }
            if(reader[148] != DBNull.Value)
            {
                PCT013C046 = (System.Nullable<System.Int32>)reader[148];
            }
            if(reader[149] != DBNull.Value)
            {
                PCT013C047 = (System.Nullable<System.Int32>)reader[149];
            }
            if(reader[150] != DBNull.Value)
            {
                PCT013C048 = (System.Nullable<System.Int32>)reader[150];
            }
            if(reader[151] != DBNull.Value)
            {
                PCT013C049 = (System.Nullable<System.Int32>)reader[151];
            }
            if(reader[152] != DBNull.Value)
            {
                PCT013D001 = (System.Nullable<System.Int32>)reader[152];
            }
            if(reader[153] != DBNull.Value)
            {
                PCT013D002 = (System.Nullable<System.Int32>)reader[153];
            }
            if(reader[154] != DBNull.Value)
            {
                PCT013D003 = (System.Nullable<System.Int32>)reader[154];
            }
            if(reader[155] != DBNull.Value)
            {
                PCT013D004 = (System.Nullable<System.Int32>)reader[155];
            }
            if(reader[156] != DBNull.Value)
            {
                PCT013D005 = (System.Nullable<System.Int32>)reader[156];
            }
            if(reader[157] != DBNull.Value)
            {
                PCT013D006 = (System.Nullable<System.Int32>)reader[157];
            }
            if(reader[158] != DBNull.Value)
            {
                PCT013D007 = (System.Nullable<System.Int32>)reader[158];
            }
            if(reader[159] != DBNull.Value)
            {
                PCT013D008 = (System.Nullable<System.Int32>)reader[159];
            }
            if(reader[160] != DBNull.Value)
            {
                PCT013D009 = (System.Nullable<System.Int32>)reader[160];
            }
            if(reader[161] != DBNull.Value)
            {
                PCT013D010 = (System.Nullable<System.Int32>)reader[161];
            }
            if(reader[162] != DBNull.Value)
            {
                PCT013D011 = (System.Nullable<System.Int32>)reader[162];
            }
            if(reader[163] != DBNull.Value)
            {
                PCT013D012 = (System.Nullable<System.Int32>)reader[163];
            }
            if(reader[164] != DBNull.Value)
            {
                PCT013D013 = (System.Nullable<System.Int32>)reader[164];
            }
            if(reader[165] != DBNull.Value)
            {
                PCT013D014 = (System.Nullable<System.Int32>)reader[165];
            }
            if(reader[166] != DBNull.Value)
            {
                PCT013D015 = (System.Nullable<System.Int32>)reader[166];
            }
            if(reader[167] != DBNull.Value)
            {
                PCT013D016 = (System.Nullable<System.Int32>)reader[167];
            }
            if(reader[168] != DBNull.Value)
            {
                PCT013D017 = (System.Nullable<System.Int32>)reader[168];
            }
            if(reader[169] != DBNull.Value)
            {
                PCT013D018 = (System.Nullable<System.Int32>)reader[169];
            }
            if(reader[170] != DBNull.Value)
            {
                PCT013D019 = (System.Nullable<System.Int32>)reader[170];
            }
            if(reader[171] != DBNull.Value)
            {
                PCT013D020 = (System.Nullable<System.Int32>)reader[171];
            }
            if(reader[172] != DBNull.Value)
            {
                PCT013D021 = (System.Nullable<System.Int32>)reader[172];
            }
            if(reader[173] != DBNull.Value)
            {
                PCT013D022 = (System.Nullable<System.Int32>)reader[173];
            }
            if(reader[174] != DBNull.Value)
            {
                PCT013D023 = (System.Nullable<System.Int32>)reader[174];
            }
            if(reader[175] != DBNull.Value)
            {
                PCT013D024 = (System.Nullable<System.Int32>)reader[175];
            }
            if(reader[176] != DBNull.Value)
            {
                PCT013D025 = (System.Nullable<System.Int32>)reader[176];
            }
            if(reader[177] != DBNull.Value)
            {
                PCT013D026 = (System.Nullable<System.Int32>)reader[177];
            }
            if(reader[178] != DBNull.Value)
            {
                PCT013D027 = (System.Nullable<System.Int32>)reader[178];
            }
            if(reader[179] != DBNull.Value)
            {
                PCT013D028 = (System.Nullable<System.Int32>)reader[179];
            }
            if(reader[180] != DBNull.Value)
            {
                PCT013D029 = (System.Nullable<System.Int32>)reader[180];
            }
            if(reader[181] != DBNull.Value)
            {
                PCT013D030 = (System.Nullable<System.Int32>)reader[181];
            }
            if(reader[182] != DBNull.Value)
            {
                PCT013D031 = (System.Nullable<System.Int32>)reader[182];
            }
            if(reader[183] != DBNull.Value)
            {
                PCT013D032 = (System.Nullable<System.Int32>)reader[183];
            }
            if(reader[184] != DBNull.Value)
            {
                PCT013D033 = (System.Nullable<System.Int32>)reader[184];
            }
            if(reader[185] != DBNull.Value)
            {
                PCT013D034 = (System.Nullable<System.Int32>)reader[185];
            }
            if(reader[186] != DBNull.Value)
            {
                PCT013D035 = (System.Nullable<System.Int32>)reader[186];
            }
            if(reader[187] != DBNull.Value)
            {
                PCT013D036 = (System.Nullable<System.Int32>)reader[187];
            }
            if(reader[188] != DBNull.Value)
            {
                PCT013D037 = (System.Nullable<System.Int32>)reader[188];
            }
            if(reader[189] != DBNull.Value)
            {
                PCT013D038 = (System.Nullable<System.Int32>)reader[189];
            }
            if(reader[190] != DBNull.Value)
            {
                PCT013D039 = (System.Nullable<System.Int32>)reader[190];
            }
            if(reader[191] != DBNull.Value)
            {
                PCT013D040 = (System.Nullable<System.Int32>)reader[191];
            }
            if(reader[192] != DBNull.Value)
            {
                PCT013D041 = (System.Nullable<System.Int32>)reader[192];
            }
            if(reader[193] != DBNull.Value)
            {
                PCT013D042 = (System.Nullable<System.Int32>)reader[193];
            }
            if(reader[194] != DBNull.Value)
            {
                PCT013D043 = (System.Nullable<System.Int32>)reader[194];
            }
            if(reader[195] != DBNull.Value)
            {
                PCT013D044 = (System.Nullable<System.Int32>)reader[195];
            }
            if(reader[196] != DBNull.Value)
            {
                PCT013D045 = (System.Nullable<System.Int32>)reader[196];
            }
            if(reader[197] != DBNull.Value)
            {
                PCT013D046 = (System.Nullable<System.Int32>)reader[197];
            }
            if(reader[198] != DBNull.Value)
            {
                PCT013D047 = (System.Nullable<System.Int32>)reader[198];
            }
            if(reader[199] != DBNull.Value)
            {
                PCT013D048 = (System.Nullable<System.Int32>)reader[199];
            }
            if(reader[200] != DBNull.Value)
            {
                PCT013D049 = (System.Nullable<System.Int32>)reader[200];
            }
            if(reader[201] != DBNull.Value)
            {
                PCT013E001 = (System.Nullable<System.Int32>)reader[201];
            }
            if(reader[202] != DBNull.Value)
            {
                PCT013E002 = (System.Nullable<System.Int32>)reader[202];
            }
            if(reader[203] != DBNull.Value)
            {
                PCT013E003 = (System.Nullable<System.Int32>)reader[203];
            }
            if(reader[204] != DBNull.Value)
            {
                PCT013E004 = (System.Nullable<System.Int32>)reader[204];
            }
            if(reader[205] != DBNull.Value)
            {
                PCT013E005 = (System.Nullable<System.Int32>)reader[205];
            }
            if(reader[206] != DBNull.Value)
            {
                PCT013E006 = (System.Nullable<System.Int32>)reader[206];
            }
            if(reader[207] != DBNull.Value)
            {
                PCT013E007 = (System.Nullable<System.Int32>)reader[207];
            }
            if(reader[208] != DBNull.Value)
            {
                PCT013E008 = (System.Nullable<System.Int32>)reader[208];
            }
            if(reader[209] != DBNull.Value)
            {
                PCT013E009 = (System.Nullable<System.Int32>)reader[209];
            }
            if(reader[210] != DBNull.Value)
            {
                PCT013E010 = (System.Nullable<System.Int32>)reader[210];
            }
            if(reader[211] != DBNull.Value)
            {
                PCT013E011 = (System.Nullable<System.Int32>)reader[211];
            }
            if(reader[212] != DBNull.Value)
            {
                PCT013E012 = (System.Nullable<System.Int32>)reader[212];
            }
            if(reader[213] != DBNull.Value)
            {
                PCT013E013 = (System.Nullable<System.Int32>)reader[213];
            }
            if(reader[214] != DBNull.Value)
            {
                PCT013E014 = (System.Nullable<System.Int32>)reader[214];
            }
            if(reader[215] != DBNull.Value)
            {
                PCT013E015 = (System.Nullable<System.Int32>)reader[215];
            }
            if(reader[216] != DBNull.Value)
            {
                PCT013E016 = (System.Nullable<System.Int32>)reader[216];
            }
            if(reader[217] != DBNull.Value)
            {
                PCT013E017 = (System.Nullable<System.Int32>)reader[217];
            }
            if(reader[218] != DBNull.Value)
            {
                PCT013E018 = (System.Nullable<System.Int32>)reader[218];
            }
            if(reader[219] != DBNull.Value)
            {
                PCT013E019 = (System.Nullable<System.Int32>)reader[219];
            }
            if(reader[220] != DBNull.Value)
            {
                PCT013E020 = (System.Nullable<System.Int32>)reader[220];
            }
            if(reader[221] != DBNull.Value)
            {
                PCT013E021 = (System.Nullable<System.Int32>)reader[221];
            }
            if(reader[222] != DBNull.Value)
            {
                PCT013E022 = (System.Nullable<System.Int32>)reader[222];
            }
            if(reader[223] != DBNull.Value)
            {
                PCT013E023 = (System.Nullable<System.Int32>)reader[223];
            }
            if(reader[224] != DBNull.Value)
            {
                PCT013E024 = (System.Nullable<System.Int32>)reader[224];
            }
            if(reader[225] != DBNull.Value)
            {
                PCT013E025 = (System.Nullable<System.Int32>)reader[225];
            }
            if(reader[226] != DBNull.Value)
            {
                PCT013E026 = (System.Nullable<System.Int32>)reader[226];
            }
            if(reader[227] != DBNull.Value)
            {
                PCT013E027 = (System.Nullable<System.Int32>)reader[227];
            }
            if(reader[228] != DBNull.Value)
            {
                PCT013E028 = (System.Nullable<System.Int32>)reader[228];
            }
            if(reader[229] != DBNull.Value)
            {
                PCT013E029 = (System.Nullable<System.Int32>)reader[229];
            }
            if(reader[230] != DBNull.Value)
            {
                PCT013E030 = (System.Nullable<System.Int32>)reader[230];
            }
            if(reader[231] != DBNull.Value)
            {
                PCT013E031 = (System.Nullable<System.Int32>)reader[231];
            }
            if(reader[232] != DBNull.Value)
            {
                PCT013E032 = (System.Nullable<System.Int32>)reader[232];
            }
            if(reader[233] != DBNull.Value)
            {
                PCT013E033 = (System.Nullable<System.Int32>)reader[233];
            }
            if(reader[234] != DBNull.Value)
            {
                PCT013E034 = (System.Nullable<System.Int32>)reader[234];
            }
            if(reader[235] != DBNull.Value)
            {
                PCT013E035 = (System.Nullable<System.Int32>)reader[235];
            }
            if(reader[236] != DBNull.Value)
            {
                PCT013E036 = (System.Nullable<System.Int32>)reader[236];
            }
            if(reader[237] != DBNull.Value)
            {
                PCT013E037 = (System.Nullable<System.Int32>)reader[237];
            }
            if(reader[238] != DBNull.Value)
            {
                PCT013E038 = (System.Nullable<System.Int32>)reader[238];
            }
            if(reader[239] != DBNull.Value)
            {
                PCT013E039 = (System.Nullable<System.Int32>)reader[239];
            }
            if(reader[240] != DBNull.Value)
            {
                PCT013E040 = (System.Nullable<System.Int32>)reader[240];
            }
            if(reader[241] != DBNull.Value)
            {
                PCT013E041 = (System.Nullable<System.Int32>)reader[241];
            }
            if(reader[242] != DBNull.Value)
            {
                PCT013E042 = (System.Nullable<System.Int32>)reader[242];
            }
            if(reader[243] != DBNull.Value)
            {
                PCT013E043 = (System.Nullable<System.Int32>)reader[243];
            }
            if(reader[244] != DBNull.Value)
            {
                PCT013E044 = (System.Nullable<System.Int32>)reader[244];
            }
            if(reader[245] != DBNull.Value)
            {
                PCT013E045 = (System.Nullable<System.Int32>)reader[245];
            }
            if(reader[246] != DBNull.Value)
            {
                PCT013E046 = (System.Nullable<System.Int32>)reader[246];
            }
            if(reader[247] != DBNull.Value)
            {
                PCT013E047 = (System.Nullable<System.Int32>)reader[247];
            }
            if(reader[248] != DBNull.Value)
            {
                PCT013E048 = (System.Nullable<System.Int32>)reader[248];
            }
            if(reader[249] != DBNull.Value)
            {
                PCT013E049 = (System.Nullable<System.Int32>)reader[249];
            }
        }
        #endregion Constructors
    }
}