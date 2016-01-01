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

    [Table("SF1_00033")]
    public partial class SF1_00033 : BaseModel
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
        [Column("PCT012N001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public System.Nullable<System.Int32> PCT012N001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 6)]
        public System.Nullable<System.Int32> PCT012N002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 1 year", ShortName = "Under 1 year", Order = 7)]
        public System.Nullable<System.Int32> PCT012N003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1 year", ShortName = "1 year", Order = 8)]
        public System.Nullable<System.Int32> PCT012N004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2 years", ShortName = "2 years", Order = 9)]
        public System.Nullable<System.Int32> PCT012N005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 years", ShortName = "3 years", Order = 10)]
        public System.Nullable<System.Int32> PCT012N006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4 years", ShortName = "4 years", Order = 11)]
        public System.Nullable<System.Int32> PCT012N007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 12)]
        public System.Nullable<System.Int32> PCT012N008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 years", ShortName = "6 years", Order = 13)]
        public System.Nullable<System.Int32> PCT012N009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7 years", ShortName = "7 years", Order = 14)]
        public System.Nullable<System.Int32> PCT012N010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "8 years", ShortName = "8 years", Order = 15)]
        public System.Nullable<System.Int32> PCT012N011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "9 years", ShortName = "9 years", Order = 16)]
        public System.Nullable<System.Int32> PCT012N012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 years", ShortName = "10 years", Order = 17)]
        public System.Nullable<System.Int32> PCT012N013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "11 years", ShortName = "11 years", Order = 18)]
        public System.Nullable<System.Int32> PCT012N014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 years", ShortName = "12 years", Order = 19)]
        public System.Nullable<System.Int32> PCT012N015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "13 years", ShortName = "13 years", Order = 20)]
        public System.Nullable<System.Int32> PCT012N016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N017", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "14 years", ShortName = "14 years", Order = 21)]
        public System.Nullable<System.Int32> PCT012N017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N018", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 years", ShortName = "15 years", Order = 22)]
        public System.Nullable<System.Int32> PCT012N018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N019", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "16 years", ShortName = "16 years", Order = 23)]
        public System.Nullable<System.Int32> PCT012N019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N020", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "17 years", ShortName = "17 years", Order = 24)]
        public System.Nullable<System.Int32> PCT012N020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N021", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years", ShortName = "18 years", Order = 25)]
        public System.Nullable<System.Int32> PCT012N021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N022", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "19 years", ShortName = "19 years", Order = 26)]
        public System.Nullable<System.Int32> PCT012N022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N023", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 27)]
        public System.Nullable<System.Int32> PCT012N023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N024", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 28)]
        public System.Nullable<System.Int32> PCT012N024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N025", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 years", ShortName = "22 years", Order = 29)]
        public System.Nullable<System.Int32> PCT012N025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N026", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "23 years", ShortName = "23 years", Order = 30)]
        public System.Nullable<System.Int32> PCT012N026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N027", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "24 years", ShortName = "24 years", Order = 31)]
        public System.Nullable<System.Int32> PCT012N027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N028", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 years", ShortName = "25 years", Order = 32)]
        public System.Nullable<System.Int32> PCT012N028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N029", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "26 years", ShortName = "26 years", Order = 33)]
        public System.Nullable<System.Int32> PCT012N029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N030", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "27 years", ShortName = "27 years", Order = 34)]
        public System.Nullable<System.Int32> PCT012N030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N031", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "28 years", ShortName = "28 years", Order = 35)]
        public System.Nullable<System.Int32> PCT012N031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N032", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "29 years", ShortName = "29 years", Order = 36)]
        public System.Nullable<System.Int32> PCT012N032 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N033", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 years", ShortName = "30 years", Order = 37)]
        public System.Nullable<System.Int32> PCT012N033 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N034", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "31 years", ShortName = "31 years", Order = 38)]
        public System.Nullable<System.Int32> PCT012N034 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N035", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "32 years", ShortName = "32 years", Order = 39)]
        public System.Nullable<System.Int32> PCT012N035 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N036", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "33 years", ShortName = "33 years", Order = 40)]
        public System.Nullable<System.Int32> PCT012N036 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N037", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "34 years", ShortName = "34 years", Order = 41)]
        public System.Nullable<System.Int32> PCT012N037 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N038", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 years", ShortName = "35 years", Order = 42)]
        public System.Nullable<System.Int32> PCT012N038 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N039", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "36 years", ShortName = "36 years", Order = 43)]
        public System.Nullable<System.Int32> PCT012N039 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N040", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "37 years", ShortName = "37 years", Order = 44)]
        public System.Nullable<System.Int32> PCT012N040 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N041", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "38 years", ShortName = "38 years", Order = 45)]
        public System.Nullable<System.Int32> PCT012N041 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N042", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "39 years", ShortName = "39 years", Order = 46)]
        public System.Nullable<System.Int32> PCT012N042 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N043", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 years", ShortName = "40 years", Order = 47)]
        public System.Nullable<System.Int32> PCT012N043 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N044", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "41 years", ShortName = "41 years", Order = 48)]
        public System.Nullable<System.Int32> PCT012N044 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N045", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "42 years", ShortName = "42 years", Order = 49)]
        public System.Nullable<System.Int32> PCT012N045 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N046", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "43 years", ShortName = "43 years", Order = 50)]
        public System.Nullable<System.Int32> PCT012N046 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N047", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "44 years", ShortName = "44 years", Order = 51)]
        public System.Nullable<System.Int32> PCT012N047 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N048", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 years", ShortName = "45 years", Order = 52)]
        public System.Nullable<System.Int32> PCT012N048 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N049", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "46 years", ShortName = "46 years", Order = 53)]
        public System.Nullable<System.Int32> PCT012N049 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N050", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "47 years", ShortName = "47 years", Order = 54)]
        public System.Nullable<System.Int32> PCT012N050 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N051", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "48 years", ShortName = "48 years", Order = 55)]
        public System.Nullable<System.Int32> PCT012N051 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N052", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "49 years", ShortName = "49 years", Order = 56)]
        public System.Nullable<System.Int32> PCT012N052 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N053", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 years", ShortName = "50 years", Order = 57)]
        public System.Nullable<System.Int32> PCT012N053 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N054", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "51 years", ShortName = "51 years", Order = 58)]
        public System.Nullable<System.Int32> PCT012N054 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N055", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "52 years", ShortName = "52 years", Order = 59)]
        public System.Nullable<System.Int32> PCT012N055 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N056", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "53 years", ShortName = "53 years", Order = 60)]
        public System.Nullable<System.Int32> PCT012N056 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N057", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "54 years", ShortName = "54 years", Order = 61)]
        public System.Nullable<System.Int32> PCT012N057 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N058", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 years", ShortName = "55 years", Order = 62)]
        public System.Nullable<System.Int32> PCT012N058 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N059", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "56 years", ShortName = "56 years", Order = 63)]
        public System.Nullable<System.Int32> PCT012N059 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N060", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "57 years", ShortName = "57 years", Order = 64)]
        public System.Nullable<System.Int32> PCT012N060 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N061", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "58 years", ShortName = "58 years", Order = 65)]
        public System.Nullable<System.Int32> PCT012N061 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N062", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "59 years", ShortName = "59 years", Order = 66)]
        public System.Nullable<System.Int32> PCT012N062 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N063", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 years", ShortName = "60 years", Order = 67)]
        public System.Nullable<System.Int32> PCT012N063 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N064", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "61 years", ShortName = "61 years", Order = 68)]
        public System.Nullable<System.Int32> PCT012N064 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N065", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 years", ShortName = "62 years", Order = 69)]
        public System.Nullable<System.Int32> PCT012N065 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N066", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "63 years", ShortName = "63 years", Order = 70)]
        public System.Nullable<System.Int32> PCT012N066 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N067", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "64 years", ShortName = "64 years", Order = 71)]
        public System.Nullable<System.Int32> PCT012N067 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N068", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 years", ShortName = "65 years", Order = 72)]
        public System.Nullable<System.Int32> PCT012N068 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N069", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "66 years", ShortName = "66 years", Order = 73)]
        public System.Nullable<System.Int32> PCT012N069 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N070", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 years", ShortName = "67 years", Order = 74)]
        public System.Nullable<System.Int32> PCT012N070 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N071", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "68 years", ShortName = "68 years", Order = 75)]
        public System.Nullable<System.Int32> PCT012N071 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N072", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "69 years", ShortName = "69 years", Order = 76)]
        public System.Nullable<System.Int32> PCT012N072 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N073", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 years", ShortName = "70 years", Order = 77)]
        public System.Nullable<System.Int32> PCT012N073 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N074", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "71 years", ShortName = "71 years", Order = 78)]
        public System.Nullable<System.Int32> PCT012N074 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N075", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "72 years", ShortName = "72 years", Order = 79)]
        public System.Nullable<System.Int32> PCT012N075 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N076", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "73 years", ShortName = "73 years", Order = 80)]
        public System.Nullable<System.Int32> PCT012N076 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N077", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "74 years", ShortName = "74 years", Order = 81)]
        public System.Nullable<System.Int32> PCT012N077 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N078", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 years", ShortName = "75 years", Order = 82)]
        public System.Nullable<System.Int32> PCT012N078 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N079", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "76 years", ShortName = "76 years", Order = 83)]
        public System.Nullable<System.Int32> PCT012N079 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N080", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "77 years", ShortName = "77 years", Order = 84)]
        public System.Nullable<System.Int32> PCT012N080 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N081", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "78 years", ShortName = "78 years", Order = 85)]
        public System.Nullable<System.Int32> PCT012N081 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N082", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "79 years", ShortName = "79 years", Order = 86)]
        public System.Nullable<System.Int32> PCT012N082 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N083", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 years", ShortName = "80 years", Order = 87)]
        public System.Nullable<System.Int32> PCT012N083 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N084", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "81 years", ShortName = "81 years", Order = 88)]
        public System.Nullable<System.Int32> PCT012N084 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N085", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "82 years", ShortName = "82 years", Order = 89)]
        public System.Nullable<System.Int32> PCT012N085 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N086", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "83 years", ShortName = "83 years", Order = 90)]
        public System.Nullable<System.Int32> PCT012N086 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N087", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "84 years", ShortName = "84 years", Order = 91)]
        public System.Nullable<System.Int32> PCT012N087 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N088", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years", ShortName = "85 years", Order = 92)]
        public System.Nullable<System.Int32> PCT012N088 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N089", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "86 years", ShortName = "86 years", Order = 93)]
        public System.Nullable<System.Int32> PCT012N089 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N090", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "87 years", ShortName = "87 years", Order = 94)]
        public System.Nullable<System.Int32> PCT012N090 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N091", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "88 years", ShortName = "88 years", Order = 95)]
        public System.Nullable<System.Int32> PCT012N091 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N092", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "89 years", ShortName = "89 years", Order = 96)]
        public System.Nullable<System.Int32> PCT012N092 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N093", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "90 years", ShortName = "90 years", Order = 97)]
        public System.Nullable<System.Int32> PCT012N093 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N094", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "91 years", ShortName = "91 years", Order = 98)]
        public System.Nullable<System.Int32> PCT012N094 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N095", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "92 years", ShortName = "92 years", Order = 99)]
        public System.Nullable<System.Int32> PCT012N095 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N096", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "93 years", ShortName = "93 years", Order = 100)]
        public System.Nullable<System.Int32> PCT012N096 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N097", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "94 years", ShortName = "94 years", Order = 101)]
        public System.Nullable<System.Int32> PCT012N097 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N098", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "95 years", ShortName = "95 years", Order = 102)]
        public System.Nullable<System.Int32> PCT012N098 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N099", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "96 years", ShortName = "96 years", Order = 103)]
        public System.Nullable<System.Int32> PCT012N099 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N100", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "97 years", ShortName = "97 years", Order = 104)]
        public System.Nullable<System.Int32> PCT012N100 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N101", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "98 years", ShortName = "98 years", Order = 105)]
        public System.Nullable<System.Int32> PCT012N101 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N102", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "99 years", ShortName = "99 years", Order = 106)]
        public System.Nullable<System.Int32> PCT012N102 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N103", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "100 to 104 years", ShortName = "100 to 104 years", Order = 107)]
        public System.Nullable<System.Int32> PCT012N103 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N104", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "105 to 109 years", ShortName = "105 to 109 years", Order = 108)]
        public System.Nullable<System.Int32> PCT012N104 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N105", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "110 years and over", ShortName = "110 years and over", Order = 109)]
        public System.Nullable<System.Int32> PCT012N105 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N106", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 110)]
        public System.Nullable<System.Int32> PCT012N106 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N107", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 1 year", ShortName = "Under 1 year", Order = 111)]
        public System.Nullable<System.Int32> PCT012N107 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N108", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1 year", ShortName = "1 year", Order = 112)]
        public System.Nullable<System.Int32> PCT012N108 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N109", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2 years", ShortName = "2 years", Order = 113)]
        public System.Nullable<System.Int32> PCT012N109 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N110", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 years", ShortName = "3 years", Order = 114)]
        public System.Nullable<System.Int32> PCT012N110 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N111", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4 years", ShortName = "4 years", Order = 115)]
        public System.Nullable<System.Int32> PCT012N111 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N112", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 116)]
        public System.Nullable<System.Int32> PCT012N112 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N113", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 years", ShortName = "6 years", Order = 117)]
        public System.Nullable<System.Int32> PCT012N113 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N114", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7 years", ShortName = "7 years", Order = 118)]
        public System.Nullable<System.Int32> PCT012N114 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N115", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "8 years", ShortName = "8 years", Order = 119)]
        public System.Nullable<System.Int32> PCT012N115 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N116", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "9 years", ShortName = "9 years", Order = 120)]
        public System.Nullable<System.Int32> PCT012N116 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N117", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 years", ShortName = "10 years", Order = 121)]
        public System.Nullable<System.Int32> PCT012N117 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N118", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "11 years", ShortName = "11 years", Order = 122)]
        public System.Nullable<System.Int32> PCT012N118 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N119", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 years", ShortName = "12 years", Order = 123)]
        public System.Nullable<System.Int32> PCT012N119 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N120", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "13 years", ShortName = "13 years", Order = 124)]
        public System.Nullable<System.Int32> PCT012N120 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N121", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "14 years", ShortName = "14 years", Order = 125)]
        public System.Nullable<System.Int32> PCT012N121 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N122", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 years", ShortName = "15 years", Order = 126)]
        public System.Nullable<System.Int32> PCT012N122 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N123", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "16 years", ShortName = "16 years", Order = 127)]
        public System.Nullable<System.Int32> PCT012N123 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N124", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "17 years", ShortName = "17 years", Order = 128)]
        public System.Nullable<System.Int32> PCT012N124 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N125", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years", ShortName = "18 years", Order = 129)]
        public System.Nullable<System.Int32> PCT012N125 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N126", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "19 years", ShortName = "19 years", Order = 130)]
        public System.Nullable<System.Int32> PCT012N126 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N127", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 131)]
        public System.Nullable<System.Int32> PCT012N127 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N128", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 132)]
        public System.Nullable<System.Int32> PCT012N128 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N129", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 years", ShortName = "22 years", Order = 133)]
        public System.Nullable<System.Int32> PCT012N129 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N130", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "23 years", ShortName = "23 years", Order = 134)]
        public System.Nullable<System.Int32> PCT012N130 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N131", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "24 years", ShortName = "24 years", Order = 135)]
        public System.Nullable<System.Int32> PCT012N131 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N132", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 years", ShortName = "25 years", Order = 136)]
        public System.Nullable<System.Int32> PCT012N132 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N133", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "26 years", ShortName = "26 years", Order = 137)]
        public System.Nullable<System.Int32> PCT012N133 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N134", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "27 years", ShortName = "27 years", Order = 138)]
        public System.Nullable<System.Int32> PCT012N134 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N135", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "28 years", ShortName = "28 years", Order = 139)]
        public System.Nullable<System.Int32> PCT012N135 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N136", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "29 years", ShortName = "29 years", Order = 140)]
        public System.Nullable<System.Int32> PCT012N136 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N137", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 years", ShortName = "30 years", Order = 141)]
        public System.Nullable<System.Int32> PCT012N137 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N138", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "31 years", ShortName = "31 years", Order = 142)]
        public System.Nullable<System.Int32> PCT012N138 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N139", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "32 years", ShortName = "32 years", Order = 143)]
        public System.Nullable<System.Int32> PCT012N139 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N140", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "33 years", ShortName = "33 years", Order = 144)]
        public System.Nullable<System.Int32> PCT012N140 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N141", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "34 years", ShortName = "34 years", Order = 145)]
        public System.Nullable<System.Int32> PCT012N141 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N142", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 years", ShortName = "35 years", Order = 146)]
        public System.Nullable<System.Int32> PCT012N142 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N143", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "36 years", ShortName = "36 years", Order = 147)]
        public System.Nullable<System.Int32> PCT012N143 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N144", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "37 years", ShortName = "37 years", Order = 148)]
        public System.Nullable<System.Int32> PCT012N144 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N145", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "38 years", ShortName = "38 years", Order = 149)]
        public System.Nullable<System.Int32> PCT012N145 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N146", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "39 years", ShortName = "39 years", Order = 150)]
        public System.Nullable<System.Int32> PCT012N146 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N147", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 years", ShortName = "40 years", Order = 151)]
        public System.Nullable<System.Int32> PCT012N147 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N148", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "41 years", ShortName = "41 years", Order = 152)]
        public System.Nullable<System.Int32> PCT012N148 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N149", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "42 years", ShortName = "42 years", Order = 153)]
        public System.Nullable<System.Int32> PCT012N149 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N150", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "43 years", ShortName = "43 years", Order = 154)]
        public System.Nullable<System.Int32> PCT012N150 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N151", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "44 years", ShortName = "44 years", Order = 155)]
        public System.Nullable<System.Int32> PCT012N151 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N152", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 years", ShortName = "45 years", Order = 156)]
        public System.Nullable<System.Int32> PCT012N152 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N153", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "46 years", ShortName = "46 years", Order = 157)]
        public System.Nullable<System.Int32> PCT012N153 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N154", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "47 years", ShortName = "47 years", Order = 158)]
        public System.Nullable<System.Int32> PCT012N154 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N155", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "48 years", ShortName = "48 years", Order = 159)]
        public System.Nullable<System.Int32> PCT012N155 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N156", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "49 years", ShortName = "49 years", Order = 160)]
        public System.Nullable<System.Int32> PCT012N156 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N157", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 years", ShortName = "50 years", Order = 161)]
        public System.Nullable<System.Int32> PCT012N157 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N158", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "51 years", ShortName = "51 years", Order = 162)]
        public System.Nullable<System.Int32> PCT012N158 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N159", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "52 years", ShortName = "52 years", Order = 163)]
        public System.Nullable<System.Int32> PCT012N159 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N160", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "53 years", ShortName = "53 years", Order = 164)]
        public System.Nullable<System.Int32> PCT012N160 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N161", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "54 years", ShortName = "54 years", Order = 165)]
        public System.Nullable<System.Int32> PCT012N161 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N162", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 years", ShortName = "55 years", Order = 166)]
        public System.Nullable<System.Int32> PCT012N162 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N163", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "56 years", ShortName = "56 years", Order = 167)]
        public System.Nullable<System.Int32> PCT012N163 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N164", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "57 years", ShortName = "57 years", Order = 168)]
        public System.Nullable<System.Int32> PCT012N164 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N165", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "58 years", ShortName = "58 years", Order = 169)]
        public System.Nullable<System.Int32> PCT012N165 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N166", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "59 years", ShortName = "59 years", Order = 170)]
        public System.Nullable<System.Int32> PCT012N166 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N167", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 years", ShortName = "60 years", Order = 171)]
        public System.Nullable<System.Int32> PCT012N167 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N168", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "61 years", ShortName = "61 years", Order = 172)]
        public System.Nullable<System.Int32> PCT012N168 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N169", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 years", ShortName = "62 years", Order = 173)]
        public System.Nullable<System.Int32> PCT012N169 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N170", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "63 years", ShortName = "63 years", Order = 174)]
        public System.Nullable<System.Int32> PCT012N170 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N171", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "64 years", ShortName = "64 years", Order = 175)]
        public System.Nullable<System.Int32> PCT012N171 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N172", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 years", ShortName = "65 years", Order = 176)]
        public System.Nullable<System.Int32> PCT012N172 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N173", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "66 years", ShortName = "66 years", Order = 177)]
        public System.Nullable<System.Int32> PCT012N173 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N174", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 years", ShortName = "67 years", Order = 178)]
        public System.Nullable<System.Int32> PCT012N174 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N175", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "68 years", ShortName = "68 years", Order = 179)]
        public System.Nullable<System.Int32> PCT012N175 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N176", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "69 years", ShortName = "69 years", Order = 180)]
        public System.Nullable<System.Int32> PCT012N176 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N177", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 years", ShortName = "70 years", Order = 181)]
        public System.Nullable<System.Int32> PCT012N177 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N178", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "71 years", ShortName = "71 years", Order = 182)]
        public System.Nullable<System.Int32> PCT012N178 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N179", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "72 years", ShortName = "72 years", Order = 183)]
        public System.Nullable<System.Int32> PCT012N179 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N180", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "73 years", ShortName = "73 years", Order = 184)]
        public System.Nullable<System.Int32> PCT012N180 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N181", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "74 years", ShortName = "74 years", Order = 185)]
        public System.Nullable<System.Int32> PCT012N181 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N182", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 years", ShortName = "75 years", Order = 186)]
        public System.Nullable<System.Int32> PCT012N182 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N183", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "76 years", ShortName = "76 years", Order = 187)]
        public System.Nullable<System.Int32> PCT012N183 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N184", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "77 years", ShortName = "77 years", Order = 188)]
        public System.Nullable<System.Int32> PCT012N184 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N185", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "78 years", ShortName = "78 years", Order = 189)]
        public System.Nullable<System.Int32> PCT012N185 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N186", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "79 years", ShortName = "79 years", Order = 190)]
        public System.Nullable<System.Int32> PCT012N186 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N187", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 years", ShortName = "80 years", Order = 191)]
        public System.Nullable<System.Int32> PCT012N187 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N188", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "81 years", ShortName = "81 years", Order = 192)]
        public System.Nullable<System.Int32> PCT012N188 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N189", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "82 years", ShortName = "82 years", Order = 193)]
        public System.Nullable<System.Int32> PCT012N189 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N190", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "83 years", ShortName = "83 years", Order = 194)]
        public System.Nullable<System.Int32> PCT012N190 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N191", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "84 years", ShortName = "84 years", Order = 195)]
        public System.Nullable<System.Int32> PCT012N191 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N192", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years", ShortName = "85 years", Order = 196)]
        public System.Nullable<System.Int32> PCT012N192 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N193", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "86 years", ShortName = "86 years", Order = 197)]
        public System.Nullable<System.Int32> PCT012N193 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N194", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "87 years", ShortName = "87 years", Order = 198)]
        public System.Nullable<System.Int32> PCT012N194 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N195", Order = 199)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "88 years", ShortName = "88 years", Order = 199)]
        public System.Nullable<System.Int32> PCT012N195 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N196", Order = 200)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "89 years", ShortName = "89 years", Order = 200)]
        public System.Nullable<System.Int32> PCT012N196 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N197", Order = 201)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "90 years", ShortName = "90 years", Order = 201)]
        public System.Nullable<System.Int32> PCT012N197 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N198", Order = 202)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "91 years", ShortName = "91 years", Order = 202)]
        public System.Nullable<System.Int32> PCT012N198 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N199", Order = 203)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "92 years", ShortName = "92 years", Order = 203)]
        public System.Nullable<System.Int32> PCT012N199 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N200", Order = 204)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "93 years", ShortName = "93 years", Order = 204)]
        public System.Nullable<System.Int32> PCT012N200 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N201", Order = 205)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "94 years", ShortName = "94 years", Order = 205)]
        public System.Nullable<System.Int32> PCT012N201 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N202", Order = 206)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "95 years", ShortName = "95 years", Order = 206)]
        public System.Nullable<System.Int32> PCT012N202 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N203", Order = 207)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "96 years", ShortName = "96 years", Order = 207)]
        public System.Nullable<System.Int32> PCT012N203 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N204", Order = 208)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "97 years", ShortName = "97 years", Order = 208)]
        public System.Nullable<System.Int32> PCT012N204 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N205", Order = 209)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "98 years", ShortName = "98 years", Order = 209)]
        public System.Nullable<System.Int32> PCT012N205 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N206", Order = 210)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "99 years", ShortName = "99 years", Order = 210)]
        public System.Nullable<System.Int32> PCT012N206 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N207", Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "100 to 104 years", ShortName = "100 to 104 years", Order = 211)]
        public System.Nullable<System.Int32> PCT012N207 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N208", Order = 212)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "105 to 109 years", ShortName = "105 to 109 years", Order = 212)]
        public System.Nullable<System.Int32> PCT012N208 { get; set; }

        [ReadOnly(false)]
        [Column("PCT012N209", Order = 213)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "110 years and over", ShortName = "110 years and over", Order = 213)]
        public System.Nullable<System.Int32> PCT012N209 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1_00033(string csvLine) : base(csvLine) {}

        public SF1_00033(string[] values) : base(values) {}

        public SF1_00033(OleDbDataReader reader, CensusFileType fileType)
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
                PCT012N001 = (System.Nullable<System.Int32>)reader[5];
            }
            if(reader[6] != DBNull.Value)
            {
                PCT012N002 = (System.Nullable<System.Int32>)reader[6];
            }
            if(reader[7] != DBNull.Value)
            {
                PCT012N003 = (System.Nullable<System.Int32>)reader[7];
            }
            if(reader[8] != DBNull.Value)
            {
                PCT012N004 = (System.Nullable<System.Int32>)reader[8];
            }
            if(reader[9] != DBNull.Value)
            {
                PCT012N005 = (System.Nullable<System.Int32>)reader[9];
            }
            if(reader[10] != DBNull.Value)
            {
                PCT012N006 = (System.Nullable<System.Int32>)reader[10];
            }
            if(reader[11] != DBNull.Value)
            {
                PCT012N007 = (System.Nullable<System.Int32>)reader[11];
            }
            if(reader[12] != DBNull.Value)
            {
                PCT012N008 = (System.Nullable<System.Int32>)reader[12];
            }
            if(reader[13] != DBNull.Value)
            {
                PCT012N009 = (System.Nullable<System.Int32>)reader[13];
            }
            if(reader[14] != DBNull.Value)
            {
                PCT012N010 = (System.Nullable<System.Int32>)reader[14];
            }
            if(reader[15] != DBNull.Value)
            {
                PCT012N011 = (System.Nullable<System.Int32>)reader[15];
            }
            if(reader[16] != DBNull.Value)
            {
                PCT012N012 = (System.Nullable<System.Int32>)reader[16];
            }
            if(reader[17] != DBNull.Value)
            {
                PCT012N013 = (System.Nullable<System.Int32>)reader[17];
            }
            if(reader[18] != DBNull.Value)
            {
                PCT012N014 = (System.Nullable<System.Int32>)reader[18];
            }
            if(reader[19] != DBNull.Value)
            {
                PCT012N015 = (System.Nullable<System.Int32>)reader[19];
            }
            if(reader[20] != DBNull.Value)
            {
                PCT012N016 = (System.Nullable<System.Int32>)reader[20];
            }
            if(reader[21] != DBNull.Value)
            {
                PCT012N017 = (System.Nullable<System.Int32>)reader[21];
            }
            if(reader[22] != DBNull.Value)
            {
                PCT012N018 = (System.Nullable<System.Int32>)reader[22];
            }
            if(reader[23] != DBNull.Value)
            {
                PCT012N019 = (System.Nullable<System.Int32>)reader[23];
            }
            if(reader[24] != DBNull.Value)
            {
                PCT012N020 = (System.Nullable<System.Int32>)reader[24];
            }
            if(reader[25] != DBNull.Value)
            {
                PCT012N021 = (System.Nullable<System.Int32>)reader[25];
            }
            if(reader[26] != DBNull.Value)
            {
                PCT012N022 = (System.Nullable<System.Int32>)reader[26];
            }
            if(reader[27] != DBNull.Value)
            {
                PCT012N023 = (System.Nullable<System.Int32>)reader[27];
            }
            if(reader[28] != DBNull.Value)
            {
                PCT012N024 = (System.Nullable<System.Int32>)reader[28];
            }
            if(reader[29] != DBNull.Value)
            {
                PCT012N025 = (System.Nullable<System.Int32>)reader[29];
            }
            if(reader[30] != DBNull.Value)
            {
                PCT012N026 = (System.Nullable<System.Int32>)reader[30];
            }
            if(reader[31] != DBNull.Value)
            {
                PCT012N027 = (System.Nullable<System.Int32>)reader[31];
            }
            if(reader[32] != DBNull.Value)
            {
                PCT012N028 = (System.Nullable<System.Int32>)reader[32];
            }
            if(reader[33] != DBNull.Value)
            {
                PCT012N029 = (System.Nullable<System.Int32>)reader[33];
            }
            if(reader[34] != DBNull.Value)
            {
                PCT012N030 = (System.Nullable<System.Int32>)reader[34];
            }
            if(reader[35] != DBNull.Value)
            {
                PCT012N031 = (System.Nullable<System.Int32>)reader[35];
            }
            if(reader[36] != DBNull.Value)
            {
                PCT012N032 = (System.Nullable<System.Int32>)reader[36];
            }
            if(reader[37] != DBNull.Value)
            {
                PCT012N033 = (System.Nullable<System.Int32>)reader[37];
            }
            if(reader[38] != DBNull.Value)
            {
                PCT012N034 = (System.Nullable<System.Int32>)reader[38];
            }
            if(reader[39] != DBNull.Value)
            {
                PCT012N035 = (System.Nullable<System.Int32>)reader[39];
            }
            if(reader[40] != DBNull.Value)
            {
                PCT012N036 = (System.Nullable<System.Int32>)reader[40];
            }
            if(reader[41] != DBNull.Value)
            {
                PCT012N037 = (System.Nullable<System.Int32>)reader[41];
            }
            if(reader[42] != DBNull.Value)
            {
                PCT012N038 = (System.Nullable<System.Int32>)reader[42];
            }
            if(reader[43] != DBNull.Value)
            {
                PCT012N039 = (System.Nullable<System.Int32>)reader[43];
            }
            if(reader[44] != DBNull.Value)
            {
                PCT012N040 = (System.Nullable<System.Int32>)reader[44];
            }
            if(reader[45] != DBNull.Value)
            {
                PCT012N041 = (System.Nullable<System.Int32>)reader[45];
            }
            if(reader[46] != DBNull.Value)
            {
                PCT012N042 = (System.Nullable<System.Int32>)reader[46];
            }
            if(reader[47] != DBNull.Value)
            {
                PCT012N043 = (System.Nullable<System.Int32>)reader[47];
            }
            if(reader[48] != DBNull.Value)
            {
                PCT012N044 = (System.Nullable<System.Int32>)reader[48];
            }
            if(reader[49] != DBNull.Value)
            {
                PCT012N045 = (System.Nullable<System.Int32>)reader[49];
            }
            if(reader[50] != DBNull.Value)
            {
                PCT012N046 = (System.Nullable<System.Int32>)reader[50];
            }
            if(reader[51] != DBNull.Value)
            {
                PCT012N047 = (System.Nullable<System.Int32>)reader[51];
            }
            if(reader[52] != DBNull.Value)
            {
                PCT012N048 = (System.Nullable<System.Int32>)reader[52];
            }
            if(reader[53] != DBNull.Value)
            {
                PCT012N049 = (System.Nullable<System.Int32>)reader[53];
            }
            if(reader[54] != DBNull.Value)
            {
                PCT012N050 = (System.Nullable<System.Int32>)reader[54];
            }
            if(reader[55] != DBNull.Value)
            {
                PCT012N051 = (System.Nullable<System.Int32>)reader[55];
            }
            if(reader[56] != DBNull.Value)
            {
                PCT012N052 = (System.Nullable<System.Int32>)reader[56];
            }
            if(reader[57] != DBNull.Value)
            {
                PCT012N053 = (System.Nullable<System.Int32>)reader[57];
            }
            if(reader[58] != DBNull.Value)
            {
                PCT012N054 = (System.Nullable<System.Int32>)reader[58];
            }
            if(reader[59] != DBNull.Value)
            {
                PCT012N055 = (System.Nullable<System.Int32>)reader[59];
            }
            if(reader[60] != DBNull.Value)
            {
                PCT012N056 = (System.Nullable<System.Int32>)reader[60];
            }
            if(reader[61] != DBNull.Value)
            {
                PCT012N057 = (System.Nullable<System.Int32>)reader[61];
            }
            if(reader[62] != DBNull.Value)
            {
                PCT012N058 = (System.Nullable<System.Int32>)reader[62];
            }
            if(reader[63] != DBNull.Value)
            {
                PCT012N059 = (System.Nullable<System.Int32>)reader[63];
            }
            if(reader[64] != DBNull.Value)
            {
                PCT012N060 = (System.Nullable<System.Int32>)reader[64];
            }
            if(reader[65] != DBNull.Value)
            {
                PCT012N061 = (System.Nullable<System.Int32>)reader[65];
            }
            if(reader[66] != DBNull.Value)
            {
                PCT012N062 = (System.Nullable<System.Int32>)reader[66];
            }
            if(reader[67] != DBNull.Value)
            {
                PCT012N063 = (System.Nullable<System.Int32>)reader[67];
            }
            if(reader[68] != DBNull.Value)
            {
                PCT012N064 = (System.Nullable<System.Int32>)reader[68];
            }
            if(reader[69] != DBNull.Value)
            {
                PCT012N065 = (System.Nullable<System.Int32>)reader[69];
            }
            if(reader[70] != DBNull.Value)
            {
                PCT012N066 = (System.Nullable<System.Int32>)reader[70];
            }
            if(reader[71] != DBNull.Value)
            {
                PCT012N067 = (System.Nullable<System.Int32>)reader[71];
            }
            if(reader[72] != DBNull.Value)
            {
                PCT012N068 = (System.Nullable<System.Int32>)reader[72];
            }
            if(reader[73] != DBNull.Value)
            {
                PCT012N069 = (System.Nullable<System.Int32>)reader[73];
            }
            if(reader[74] != DBNull.Value)
            {
                PCT012N070 = (System.Nullable<System.Int32>)reader[74];
            }
            if(reader[75] != DBNull.Value)
            {
                PCT012N071 = (System.Nullable<System.Int32>)reader[75];
            }
            if(reader[76] != DBNull.Value)
            {
                PCT012N072 = (System.Nullable<System.Int32>)reader[76];
            }
            if(reader[77] != DBNull.Value)
            {
                PCT012N073 = (System.Nullable<System.Int32>)reader[77];
            }
            if(reader[78] != DBNull.Value)
            {
                PCT012N074 = (System.Nullable<System.Int32>)reader[78];
            }
            if(reader[79] != DBNull.Value)
            {
                PCT012N075 = (System.Nullable<System.Int32>)reader[79];
            }
            if(reader[80] != DBNull.Value)
            {
                PCT012N076 = (System.Nullable<System.Int32>)reader[80];
            }
            if(reader[81] != DBNull.Value)
            {
                PCT012N077 = (System.Nullable<System.Int32>)reader[81];
            }
            if(reader[82] != DBNull.Value)
            {
                PCT012N078 = (System.Nullable<System.Int32>)reader[82];
            }
            if(reader[83] != DBNull.Value)
            {
                PCT012N079 = (System.Nullable<System.Int32>)reader[83];
            }
            if(reader[84] != DBNull.Value)
            {
                PCT012N080 = (System.Nullable<System.Int32>)reader[84];
            }
            if(reader[85] != DBNull.Value)
            {
                PCT012N081 = (System.Nullable<System.Int32>)reader[85];
            }
            if(reader[86] != DBNull.Value)
            {
                PCT012N082 = (System.Nullable<System.Int32>)reader[86];
            }
            if(reader[87] != DBNull.Value)
            {
                PCT012N083 = (System.Nullable<System.Int32>)reader[87];
            }
            if(reader[88] != DBNull.Value)
            {
                PCT012N084 = (System.Nullable<System.Int32>)reader[88];
            }
            if(reader[89] != DBNull.Value)
            {
                PCT012N085 = (System.Nullable<System.Int32>)reader[89];
            }
            if(reader[90] != DBNull.Value)
            {
                PCT012N086 = (System.Nullable<System.Int32>)reader[90];
            }
            if(reader[91] != DBNull.Value)
            {
                PCT012N087 = (System.Nullable<System.Int32>)reader[91];
            }
            if(reader[92] != DBNull.Value)
            {
                PCT012N088 = (System.Nullable<System.Int32>)reader[92];
            }
            if(reader[93] != DBNull.Value)
            {
                PCT012N089 = (System.Nullable<System.Int32>)reader[93];
            }
            if(reader[94] != DBNull.Value)
            {
                PCT012N090 = (System.Nullable<System.Int32>)reader[94];
            }
            if(reader[95] != DBNull.Value)
            {
                PCT012N091 = (System.Nullable<System.Int32>)reader[95];
            }
            if(reader[96] != DBNull.Value)
            {
                PCT012N092 = (System.Nullable<System.Int32>)reader[96];
            }
            if(reader[97] != DBNull.Value)
            {
                PCT012N093 = (System.Nullable<System.Int32>)reader[97];
            }
            if(reader[98] != DBNull.Value)
            {
                PCT012N094 = (System.Nullable<System.Int32>)reader[98];
            }
            if(reader[99] != DBNull.Value)
            {
                PCT012N095 = (System.Nullable<System.Int32>)reader[99];
            }
            if(reader[100] != DBNull.Value)
            {
                PCT012N096 = (System.Nullable<System.Int32>)reader[100];
            }
            if(reader[101] != DBNull.Value)
            {
                PCT012N097 = (System.Nullable<System.Int32>)reader[101];
            }
            if(reader[102] != DBNull.Value)
            {
                PCT012N098 = (System.Nullable<System.Int32>)reader[102];
            }
            if(reader[103] != DBNull.Value)
            {
                PCT012N099 = (System.Nullable<System.Int32>)reader[103];
            }
            if(reader[104] != DBNull.Value)
            {
                PCT012N100 = (System.Nullable<System.Int32>)reader[104];
            }
            if(reader[105] != DBNull.Value)
            {
                PCT012N101 = (System.Nullable<System.Int32>)reader[105];
            }
            if(reader[106] != DBNull.Value)
            {
                PCT012N102 = (System.Nullable<System.Int32>)reader[106];
            }
            if(reader[107] != DBNull.Value)
            {
                PCT012N103 = (System.Nullable<System.Int32>)reader[107];
            }
            if(reader[108] != DBNull.Value)
            {
                PCT012N104 = (System.Nullable<System.Int32>)reader[108];
            }
            if(reader[109] != DBNull.Value)
            {
                PCT012N105 = (System.Nullable<System.Int32>)reader[109];
            }
            if(reader[110] != DBNull.Value)
            {
                PCT012N106 = (System.Nullable<System.Int32>)reader[110];
            }
            if(reader[111] != DBNull.Value)
            {
                PCT012N107 = (System.Nullable<System.Int32>)reader[111];
            }
            if(reader[112] != DBNull.Value)
            {
                PCT012N108 = (System.Nullable<System.Int32>)reader[112];
            }
            if(reader[113] != DBNull.Value)
            {
                PCT012N109 = (System.Nullable<System.Int32>)reader[113];
            }
            if(reader[114] != DBNull.Value)
            {
                PCT012N110 = (System.Nullable<System.Int32>)reader[114];
            }
            if(reader[115] != DBNull.Value)
            {
                PCT012N111 = (System.Nullable<System.Int32>)reader[115];
            }
            if(reader[116] != DBNull.Value)
            {
                PCT012N112 = (System.Nullable<System.Int32>)reader[116];
            }
            if(reader[117] != DBNull.Value)
            {
                PCT012N113 = (System.Nullable<System.Int32>)reader[117];
            }
            if(reader[118] != DBNull.Value)
            {
                PCT012N114 = (System.Nullable<System.Int32>)reader[118];
            }
            if(reader[119] != DBNull.Value)
            {
                PCT012N115 = (System.Nullable<System.Int32>)reader[119];
            }
            if(reader[120] != DBNull.Value)
            {
                PCT012N116 = (System.Nullable<System.Int32>)reader[120];
            }
            if(reader[121] != DBNull.Value)
            {
                PCT012N117 = (System.Nullable<System.Int32>)reader[121];
            }
            if(reader[122] != DBNull.Value)
            {
                PCT012N118 = (System.Nullable<System.Int32>)reader[122];
            }
            if(reader[123] != DBNull.Value)
            {
                PCT012N119 = (System.Nullable<System.Int32>)reader[123];
            }
            if(reader[124] != DBNull.Value)
            {
                PCT012N120 = (System.Nullable<System.Int32>)reader[124];
            }
            if(reader[125] != DBNull.Value)
            {
                PCT012N121 = (System.Nullable<System.Int32>)reader[125];
            }
            if(reader[126] != DBNull.Value)
            {
                PCT012N122 = (System.Nullable<System.Int32>)reader[126];
            }
            if(reader[127] != DBNull.Value)
            {
                PCT012N123 = (System.Nullable<System.Int32>)reader[127];
            }
            if(reader[128] != DBNull.Value)
            {
                PCT012N124 = (System.Nullable<System.Int32>)reader[128];
            }
            if(reader[129] != DBNull.Value)
            {
                PCT012N125 = (System.Nullable<System.Int32>)reader[129];
            }
            if(reader[130] != DBNull.Value)
            {
                PCT012N126 = (System.Nullable<System.Int32>)reader[130];
            }
            if(reader[131] != DBNull.Value)
            {
                PCT012N127 = (System.Nullable<System.Int32>)reader[131];
            }
            if(reader[132] != DBNull.Value)
            {
                PCT012N128 = (System.Nullable<System.Int32>)reader[132];
            }
            if(reader[133] != DBNull.Value)
            {
                PCT012N129 = (System.Nullable<System.Int32>)reader[133];
            }
            if(reader[134] != DBNull.Value)
            {
                PCT012N130 = (System.Nullable<System.Int32>)reader[134];
            }
            if(reader[135] != DBNull.Value)
            {
                PCT012N131 = (System.Nullable<System.Int32>)reader[135];
            }
            if(reader[136] != DBNull.Value)
            {
                PCT012N132 = (System.Nullable<System.Int32>)reader[136];
            }
            if(reader[137] != DBNull.Value)
            {
                PCT012N133 = (System.Nullable<System.Int32>)reader[137];
            }
            if(reader[138] != DBNull.Value)
            {
                PCT012N134 = (System.Nullable<System.Int32>)reader[138];
            }
            if(reader[139] != DBNull.Value)
            {
                PCT012N135 = (System.Nullable<System.Int32>)reader[139];
            }
            if(reader[140] != DBNull.Value)
            {
                PCT012N136 = (System.Nullable<System.Int32>)reader[140];
            }
            if(reader[141] != DBNull.Value)
            {
                PCT012N137 = (System.Nullable<System.Int32>)reader[141];
            }
            if(reader[142] != DBNull.Value)
            {
                PCT012N138 = (System.Nullable<System.Int32>)reader[142];
            }
            if(reader[143] != DBNull.Value)
            {
                PCT012N139 = (System.Nullable<System.Int32>)reader[143];
            }
            if(reader[144] != DBNull.Value)
            {
                PCT012N140 = (System.Nullable<System.Int32>)reader[144];
            }
            if(reader[145] != DBNull.Value)
            {
                PCT012N141 = (System.Nullable<System.Int32>)reader[145];
            }
            if(reader[146] != DBNull.Value)
            {
                PCT012N142 = (System.Nullable<System.Int32>)reader[146];
            }
            if(reader[147] != DBNull.Value)
            {
                PCT012N143 = (System.Nullable<System.Int32>)reader[147];
            }
            if(reader[148] != DBNull.Value)
            {
                PCT012N144 = (System.Nullable<System.Int32>)reader[148];
            }
            if(reader[149] != DBNull.Value)
            {
                PCT012N145 = (System.Nullable<System.Int32>)reader[149];
            }
            if(reader[150] != DBNull.Value)
            {
                PCT012N146 = (System.Nullable<System.Int32>)reader[150];
            }
            if(reader[151] != DBNull.Value)
            {
                PCT012N147 = (System.Nullable<System.Int32>)reader[151];
            }
            if(reader[152] != DBNull.Value)
            {
                PCT012N148 = (System.Nullable<System.Int32>)reader[152];
            }
            if(reader[153] != DBNull.Value)
            {
                PCT012N149 = (System.Nullable<System.Int32>)reader[153];
            }
            if(reader[154] != DBNull.Value)
            {
                PCT012N150 = (System.Nullable<System.Int32>)reader[154];
            }
            if(reader[155] != DBNull.Value)
            {
                PCT012N151 = (System.Nullable<System.Int32>)reader[155];
            }
            if(reader[156] != DBNull.Value)
            {
                PCT012N152 = (System.Nullable<System.Int32>)reader[156];
            }
            if(reader[157] != DBNull.Value)
            {
                PCT012N153 = (System.Nullable<System.Int32>)reader[157];
            }
            if(reader[158] != DBNull.Value)
            {
                PCT012N154 = (System.Nullable<System.Int32>)reader[158];
            }
            if(reader[159] != DBNull.Value)
            {
                PCT012N155 = (System.Nullable<System.Int32>)reader[159];
            }
            if(reader[160] != DBNull.Value)
            {
                PCT012N156 = (System.Nullable<System.Int32>)reader[160];
            }
            if(reader[161] != DBNull.Value)
            {
                PCT012N157 = (System.Nullable<System.Int32>)reader[161];
            }
            if(reader[162] != DBNull.Value)
            {
                PCT012N158 = (System.Nullable<System.Int32>)reader[162];
            }
            if(reader[163] != DBNull.Value)
            {
                PCT012N159 = (System.Nullable<System.Int32>)reader[163];
            }
            if(reader[164] != DBNull.Value)
            {
                PCT012N160 = (System.Nullable<System.Int32>)reader[164];
            }
            if(reader[165] != DBNull.Value)
            {
                PCT012N161 = (System.Nullable<System.Int32>)reader[165];
            }
            if(reader[166] != DBNull.Value)
            {
                PCT012N162 = (System.Nullable<System.Int32>)reader[166];
            }
            if(reader[167] != DBNull.Value)
            {
                PCT012N163 = (System.Nullable<System.Int32>)reader[167];
            }
            if(reader[168] != DBNull.Value)
            {
                PCT012N164 = (System.Nullable<System.Int32>)reader[168];
            }
            if(reader[169] != DBNull.Value)
            {
                PCT012N165 = (System.Nullable<System.Int32>)reader[169];
            }
            if(reader[170] != DBNull.Value)
            {
                PCT012N166 = (System.Nullable<System.Int32>)reader[170];
            }
            if(reader[171] != DBNull.Value)
            {
                PCT012N167 = (System.Nullable<System.Int32>)reader[171];
            }
            if(reader[172] != DBNull.Value)
            {
                PCT012N168 = (System.Nullable<System.Int32>)reader[172];
            }
            if(reader[173] != DBNull.Value)
            {
                PCT012N169 = (System.Nullable<System.Int32>)reader[173];
            }
            if(reader[174] != DBNull.Value)
            {
                PCT012N170 = (System.Nullable<System.Int32>)reader[174];
            }
            if(reader[175] != DBNull.Value)
            {
                PCT012N171 = (System.Nullable<System.Int32>)reader[175];
            }
            if(reader[176] != DBNull.Value)
            {
                PCT012N172 = (System.Nullable<System.Int32>)reader[176];
            }
            if(reader[177] != DBNull.Value)
            {
                PCT012N173 = (System.Nullable<System.Int32>)reader[177];
            }
            if(reader[178] != DBNull.Value)
            {
                PCT012N174 = (System.Nullable<System.Int32>)reader[178];
            }
            if(reader[179] != DBNull.Value)
            {
                PCT012N175 = (System.Nullable<System.Int32>)reader[179];
            }
            if(reader[180] != DBNull.Value)
            {
                PCT012N176 = (System.Nullable<System.Int32>)reader[180];
            }
            if(reader[181] != DBNull.Value)
            {
                PCT012N177 = (System.Nullable<System.Int32>)reader[181];
            }
            if(reader[182] != DBNull.Value)
            {
                PCT012N178 = (System.Nullable<System.Int32>)reader[182];
            }
            if(reader[183] != DBNull.Value)
            {
                PCT012N179 = (System.Nullable<System.Int32>)reader[183];
            }
            if(reader[184] != DBNull.Value)
            {
                PCT012N180 = (System.Nullable<System.Int32>)reader[184];
            }
            if(reader[185] != DBNull.Value)
            {
                PCT012N181 = (System.Nullable<System.Int32>)reader[185];
            }
            if(reader[186] != DBNull.Value)
            {
                PCT012N182 = (System.Nullable<System.Int32>)reader[186];
            }
            if(reader[187] != DBNull.Value)
            {
                PCT012N183 = (System.Nullable<System.Int32>)reader[187];
            }
            if(reader[188] != DBNull.Value)
            {
                PCT012N184 = (System.Nullable<System.Int32>)reader[188];
            }
            if(reader[189] != DBNull.Value)
            {
                PCT012N185 = (System.Nullable<System.Int32>)reader[189];
            }
            if(reader[190] != DBNull.Value)
            {
                PCT012N186 = (System.Nullable<System.Int32>)reader[190];
            }
            if(reader[191] != DBNull.Value)
            {
                PCT012N187 = (System.Nullable<System.Int32>)reader[191];
            }
            if(reader[192] != DBNull.Value)
            {
                PCT012N188 = (System.Nullable<System.Int32>)reader[192];
            }
            if(reader[193] != DBNull.Value)
            {
                PCT012N189 = (System.Nullable<System.Int32>)reader[193];
            }
            if(reader[194] != DBNull.Value)
            {
                PCT012N190 = (System.Nullable<System.Int32>)reader[194];
            }
            if(reader[195] != DBNull.Value)
            {
                PCT012N191 = (System.Nullable<System.Int32>)reader[195];
            }
            if(reader[196] != DBNull.Value)
            {
                PCT012N192 = (System.Nullable<System.Int32>)reader[196];
            }
            if(reader[197] != DBNull.Value)
            {
                PCT012N193 = (System.Nullable<System.Int32>)reader[197];
            }
            if(reader[198] != DBNull.Value)
            {
                PCT012N194 = (System.Nullable<System.Int32>)reader[198];
            }
            if(reader[199] != DBNull.Value)
            {
                PCT012N195 = (System.Nullable<System.Int32>)reader[199];
            }
            if(reader[200] != DBNull.Value)
            {
                PCT012N196 = (System.Nullable<System.Int32>)reader[200];
            }
            if(reader[201] != DBNull.Value)
            {
                PCT012N197 = (System.Nullable<System.Int32>)reader[201];
            }
            if(reader[202] != DBNull.Value)
            {
                PCT012N198 = (System.Nullable<System.Int32>)reader[202];
            }
            if(reader[203] != DBNull.Value)
            {
                PCT012N199 = (System.Nullable<System.Int32>)reader[203];
            }
            if(reader[204] != DBNull.Value)
            {
                PCT012N200 = (System.Nullable<System.Int32>)reader[204];
            }
            if(reader[205] != DBNull.Value)
            {
                PCT012N201 = (System.Nullable<System.Int32>)reader[205];
            }
            if(reader[206] != DBNull.Value)
            {
                PCT012N202 = (System.Nullable<System.Int32>)reader[206];
            }
            if(reader[207] != DBNull.Value)
            {
                PCT012N203 = (System.Nullable<System.Int32>)reader[207];
            }
            if(reader[208] != DBNull.Value)
            {
                PCT012N204 = (System.Nullable<System.Int32>)reader[208];
            }
            if(reader[209] != DBNull.Value)
            {
                PCT012N205 = (System.Nullable<System.Int32>)reader[209];
            }
            if(reader[210] != DBNull.Value)
            {
                PCT012N206 = (System.Nullable<System.Int32>)reader[210];
            }
            if(reader[211] != DBNull.Value)
            {
                PCT012N207 = (System.Nullable<System.Int32>)reader[211];
            }
            if(reader[212] != DBNull.Value)
            {
                PCT012N208 = (System.Nullable<System.Int32>)reader[212];
            }
            if(reader[213] != DBNull.Value)
            {
                PCT012N209 = (System.Nullable<System.Int32>)reader[213];
            }
        }
        #endregion Constructors
    }
}