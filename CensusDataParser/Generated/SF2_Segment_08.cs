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

    [Table("SF2_Segment_08")]
    public partial class SF2_Segment_08 : BaseModel
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
        [Column("PCO0010001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public System.Nullable<System.Int32> PCO0010001 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 6)]
        public System.Nullable<System.Int32> PCO0010002 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 7)]
        public System.Nullable<System.Int32> PCO0010003 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 8)]
        public System.Nullable<System.Int32> PCO0010004 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 9)]
        public System.Nullable<System.Int32> PCO0010005 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 10)]
        public System.Nullable<System.Int32> PCO0010006 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 11)]
        public System.Nullable<System.Int32> PCO0010007 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 12)]
        public System.Nullable<System.Int32> PCO0010008 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 13)]
        public System.Nullable<System.Int32> PCO0010009 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 14)]
        public System.Nullable<System.Int32> PCO0010010 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 15)]
        public System.Nullable<System.Int32> PCO0010011 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 16)]
        public System.Nullable<System.Int32> PCO0010012 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 17)]
        public System.Nullable<System.Int32> PCO0010013 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 18)]
        public System.Nullable<System.Int32> PCO0010014 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 19)]
        public System.Nullable<System.Int32> PCO0010015 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 20)]
        public System.Nullable<System.Int32> PCO0010016 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010017", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 21)]
        public System.Nullable<System.Int32> PCO0010017 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010018", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 22)]
        public System.Nullable<System.Int32> PCO0010018 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010019", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 23)]
        public System.Nullable<System.Int32> PCO0010019 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010020", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 24)]
        public System.Nullable<System.Int32> PCO0010020 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010021", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 25)]
        public System.Nullable<System.Int32> PCO0010021 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010022", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 26)]
        public System.Nullable<System.Int32> PCO0010022 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010023", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 27)]
        public System.Nullable<System.Int32> PCO0010023 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010024", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 28)]
        public System.Nullable<System.Int32> PCO0010024 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010025", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 29)]
        public System.Nullable<System.Int32> PCO0010025 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010026", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 30)]
        public System.Nullable<System.Int32> PCO0010026 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010027", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 31)]
        public System.Nullable<System.Int32> PCO0010027 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010028", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 32)]
        public System.Nullable<System.Int32> PCO0010028 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010029", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 33)]
        public System.Nullable<System.Int32> PCO0010029 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010030", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 34)]
        public System.Nullable<System.Int32> PCO0010030 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010031", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 35)]
        public System.Nullable<System.Int32> PCO0010031 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010032", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 36)]
        public System.Nullable<System.Int32> PCO0010032 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010033", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 37)]
        public System.Nullable<System.Int32> PCO0010033 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010034", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 38)]
        public System.Nullable<System.Int32> PCO0010034 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010035", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 39)]
        public System.Nullable<System.Int32> PCO0010035 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010036", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 40)]
        public System.Nullable<System.Int32> PCO0010036 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010037", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 41)]
        public System.Nullable<System.Int32> PCO0010037 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010038", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 42)]
        public System.Nullable<System.Int32> PCO0010038 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0010039", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 43)]
        public System.Nullable<System.Int32> PCO0010039 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020001", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total (101-106, 201-203, 301, 401-405):", ShortName = "Total (101-106, 201-203, 301, 401-405):", Order = 44)]
        public System.Nullable<System.Int32> PCO0020001 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020002", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 45)]
        public System.Nullable<System.Int32> PCO0020002 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020003", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 46)]
        public System.Nullable<System.Int32> PCO0020003 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020004", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 47)]
        public System.Nullable<System.Int32> PCO0020004 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020005", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 48)]
        public System.Nullable<System.Int32> PCO0020005 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020006", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 49)]
        public System.Nullable<System.Int32> PCO0020006 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020007", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 50)]
        public System.Nullable<System.Int32> PCO0020007 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020008", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 51)]
        public System.Nullable<System.Int32> PCO0020008 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020009", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 52)]
        public System.Nullable<System.Int32> PCO0020009 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020010", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 53)]
        public System.Nullable<System.Int32> PCO0020010 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020011", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 54)]
        public System.Nullable<System.Int32> PCO0020011 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020012", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 55)]
        public System.Nullable<System.Int32> PCO0020012 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020013", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 56)]
        public System.Nullable<System.Int32> PCO0020013 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020014", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 57)]
        public System.Nullable<System.Int32> PCO0020014 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020015", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 58)]
        public System.Nullable<System.Int32> PCO0020015 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020016", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 59)]
        public System.Nullable<System.Int32> PCO0020016 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020017", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 60)]
        public System.Nullable<System.Int32> PCO0020017 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020018", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 61)]
        public System.Nullable<System.Int32> PCO0020018 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020019", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 62)]
        public System.Nullable<System.Int32> PCO0020019 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020020", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 63)]
        public System.Nullable<System.Int32> PCO0020020 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020021", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 64)]
        public System.Nullable<System.Int32> PCO0020021 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020022", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 65)]
        public System.Nullable<System.Int32> PCO0020022 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020023", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 66)]
        public System.Nullable<System.Int32> PCO0020023 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020024", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 67)]
        public System.Nullable<System.Int32> PCO0020024 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020025", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 68)]
        public System.Nullable<System.Int32> PCO0020025 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020026", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 69)]
        public System.Nullable<System.Int32> PCO0020026 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020027", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 70)]
        public System.Nullable<System.Int32> PCO0020027 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020028", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 71)]
        public System.Nullable<System.Int32> PCO0020028 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020029", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 72)]
        public System.Nullable<System.Int32> PCO0020029 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020030", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 73)]
        public System.Nullable<System.Int32> PCO0020030 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020031", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 74)]
        public System.Nullable<System.Int32> PCO0020031 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020032", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 75)]
        public System.Nullable<System.Int32> PCO0020032 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020033", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 76)]
        public System.Nullable<System.Int32> PCO0020033 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020034", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 77)]
        public System.Nullable<System.Int32> PCO0020034 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020035", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 78)]
        public System.Nullable<System.Int32> PCO0020035 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020036", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 79)]
        public System.Nullable<System.Int32> PCO0020036 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020037", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 80)]
        public System.Nullable<System.Int32> PCO0020037 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020038", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 81)]
        public System.Nullable<System.Int32> PCO0020038 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0020039", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 82)]
        public System.Nullable<System.Int32> PCO0020039 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030001", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total (101-106):", ShortName = "Total (101-106):", Order = 83)]
        public System.Nullable<System.Int32> PCO0030001 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030002", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 84)]
        public System.Nullable<System.Int32> PCO0030002 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030003", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 85)]
        public System.Nullable<System.Int32> PCO0030003 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030004", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 86)]
        public System.Nullable<System.Int32> PCO0030004 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030005", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 87)]
        public System.Nullable<System.Int32> PCO0030005 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030006", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 88)]
        public System.Nullable<System.Int32> PCO0030006 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030007", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 89)]
        public System.Nullable<System.Int32> PCO0030007 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030008", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 90)]
        public System.Nullable<System.Int32> PCO0030008 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030009", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 91)]
        public System.Nullable<System.Int32> PCO0030009 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030010", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 92)]
        public System.Nullable<System.Int32> PCO0030010 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030011", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 93)]
        public System.Nullable<System.Int32> PCO0030011 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030012", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 94)]
        public System.Nullable<System.Int32> PCO0030012 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030013", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 95)]
        public System.Nullable<System.Int32> PCO0030013 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030014", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 96)]
        public System.Nullable<System.Int32> PCO0030014 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030015", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 97)]
        public System.Nullable<System.Int32> PCO0030015 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030016", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 98)]
        public System.Nullable<System.Int32> PCO0030016 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030017", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 99)]
        public System.Nullable<System.Int32> PCO0030017 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030018", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 100)]
        public System.Nullable<System.Int32> PCO0030018 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030019", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 101)]
        public System.Nullable<System.Int32> PCO0030019 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030020", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 102)]
        public System.Nullable<System.Int32> PCO0030020 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030021", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 103)]
        public System.Nullable<System.Int32> PCO0030021 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030022", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 104)]
        public System.Nullable<System.Int32> PCO0030022 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030023", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 105)]
        public System.Nullable<System.Int32> PCO0030023 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030024", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 106)]
        public System.Nullable<System.Int32> PCO0030024 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030025", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 107)]
        public System.Nullable<System.Int32> PCO0030025 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030026", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 108)]
        public System.Nullable<System.Int32> PCO0030026 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030027", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 109)]
        public System.Nullable<System.Int32> PCO0030027 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030028", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 110)]
        public System.Nullable<System.Int32> PCO0030028 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030029", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 111)]
        public System.Nullable<System.Int32> PCO0030029 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030030", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 112)]
        public System.Nullable<System.Int32> PCO0030030 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030031", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 113)]
        public System.Nullable<System.Int32> PCO0030031 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030032", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 114)]
        public System.Nullable<System.Int32> PCO0030032 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0030033", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 115)]
        public System.Nullable<System.Int32> PCO0030033 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040001", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total (201-203):", ShortName = "Total (201-203):", Order = 116)]
        public System.Nullable<System.Int32> PCO0040001 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040002", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 117)]
        public System.Nullable<System.Int32> PCO0040002 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040003", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 118)]
        public System.Nullable<System.Int32> PCO0040003 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040004", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 119)]
        public System.Nullable<System.Int32> PCO0040004 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040005", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 120)]
        public System.Nullable<System.Int32> PCO0040005 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040006", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 121)]
        public System.Nullable<System.Int32> PCO0040006 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040007", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 122)]
        public System.Nullable<System.Int32> PCO0040007 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040008", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 123)]
        public System.Nullable<System.Int32> PCO0040008 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040009", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 124)]
        public System.Nullable<System.Int32> PCO0040009 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040010", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 125)]
        public System.Nullable<System.Int32> PCO0040010 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040011", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 126)]
        public System.Nullable<System.Int32> PCO0040011 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040012", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 127)]
        public System.Nullable<System.Int32> PCO0040012 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040013", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 128)]
        public System.Nullable<System.Int32> PCO0040013 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040014", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 129)]
        public System.Nullable<System.Int32> PCO0040014 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0040015", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 130)]
        public System.Nullable<System.Int32> PCO0040015 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050001", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total (301):", ShortName = "Total (301):", Order = 131)]
        public System.Nullable<System.Int32> PCO0050001 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050002", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 132)]
        public System.Nullable<System.Int32> PCO0050002 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050003", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 133)]
        public System.Nullable<System.Int32> PCO0050003 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050004", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 134)]
        public System.Nullable<System.Int32> PCO0050004 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050005", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 135)]
        public System.Nullable<System.Int32> PCO0050005 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050006", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 136)]
        public System.Nullable<System.Int32> PCO0050006 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050007", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 137)]
        public System.Nullable<System.Int32> PCO0050007 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050008", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 138)]
        public System.Nullable<System.Int32> PCO0050008 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050009", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 139)]
        public System.Nullable<System.Int32> PCO0050009 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050010", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 140)]
        public System.Nullable<System.Int32> PCO0050010 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050011", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 141)]
        public System.Nullable<System.Int32> PCO0050011 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050012", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 142)]
        public System.Nullable<System.Int32> PCO0050012 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050013", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 143)]
        public System.Nullable<System.Int32> PCO0050013 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050014", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 144)]
        public System.Nullable<System.Int32> PCO0050014 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050015", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 145)]
        public System.Nullable<System.Int32> PCO0050015 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050016", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 146)]
        public System.Nullable<System.Int32> PCO0050016 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050017", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 147)]
        public System.Nullable<System.Int32> PCO0050017 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050018", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 148)]
        public System.Nullable<System.Int32> PCO0050018 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050019", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 149)]
        public System.Nullable<System.Int32> PCO0050019 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050020", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 150)]
        public System.Nullable<System.Int32> PCO0050020 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050021", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 151)]
        public System.Nullable<System.Int32> PCO0050021 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050022", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 152)]
        public System.Nullable<System.Int32> PCO0050022 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050023", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 153)]
        public System.Nullable<System.Int32> PCO0050023 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050024", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 154)]
        public System.Nullable<System.Int32> PCO0050024 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050025", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 155)]
        public System.Nullable<System.Int32> PCO0050025 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050026", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 156)]
        public System.Nullable<System.Int32> PCO0050026 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050027", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 157)]
        public System.Nullable<System.Int32> PCO0050027 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050028", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 158)]
        public System.Nullable<System.Int32> PCO0050028 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050029", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 159)]
        public System.Nullable<System.Int32> PCO0050029 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050030", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 160)]
        public System.Nullable<System.Int32> PCO0050030 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0050031", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 161)]
        public System.Nullable<System.Int32> PCO0050031 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060001", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total (401-405):", ShortName = "Total (401-405):", Order = 162)]
        public System.Nullable<System.Int32> PCO0060001 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060002", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 163)]
        public System.Nullable<System.Int32> PCO0060002 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060003", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 164)]
        public System.Nullable<System.Int32> PCO0060003 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060004", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 165)]
        public System.Nullable<System.Int32> PCO0060004 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060005", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 166)]
        public System.Nullable<System.Int32> PCO0060005 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060006", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 167)]
        public System.Nullable<System.Int32> PCO0060006 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060007", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 168)]
        public System.Nullable<System.Int32> PCO0060007 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060008", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 169)]
        public System.Nullable<System.Int32> PCO0060008 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060009", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 170)]
        public System.Nullable<System.Int32> PCO0060009 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060010", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 171)]
        public System.Nullable<System.Int32> PCO0060010 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060011", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 172)]
        public System.Nullable<System.Int32> PCO0060011 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060012", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 173)]
        public System.Nullable<System.Int32> PCO0060012 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060013", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 174)]
        public System.Nullable<System.Int32> PCO0060013 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060014", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 175)]
        public System.Nullable<System.Int32> PCO0060014 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060015", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 176)]
        public System.Nullable<System.Int32> PCO0060015 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060016", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 177)]
        public System.Nullable<System.Int32> PCO0060016 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060017", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 178)]
        public System.Nullable<System.Int32> PCO0060017 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060018", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 179)]
        public System.Nullable<System.Int32> PCO0060018 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060019", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 180)]
        public System.Nullable<System.Int32> PCO0060019 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060020", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 181)]
        public System.Nullable<System.Int32> PCO0060020 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060021", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 182)]
        public System.Nullable<System.Int32> PCO0060021 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060022", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 183)]
        public System.Nullable<System.Int32> PCO0060022 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060023", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 184)]
        public System.Nullable<System.Int32> PCO0060023 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060024", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 185)]
        public System.Nullable<System.Int32> PCO0060024 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060025", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 186)]
        public System.Nullable<System.Int32> PCO0060025 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060026", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 187)]
        public System.Nullable<System.Int32> PCO0060026 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060027", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 188)]
        public System.Nullable<System.Int32> PCO0060027 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060028", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 189)]
        public System.Nullable<System.Int32> PCO0060028 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060029", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 190)]
        public System.Nullable<System.Int32> PCO0060029 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060030", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 191)]
        public System.Nullable<System.Int32> PCO0060030 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060031", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 192)]
        public System.Nullable<System.Int32> PCO0060031 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060032", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 193)]
        public System.Nullable<System.Int32> PCO0060032 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060033", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 194)]
        public System.Nullable<System.Int32> PCO0060033 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060034", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 195)]
        public System.Nullable<System.Int32> PCO0060034 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060035", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 196)]
        public System.Nullable<System.Int32> PCO0060035 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060036", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 197)]
        public System.Nullable<System.Int32> PCO0060036 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060037", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 198)]
        public System.Nullable<System.Int32> PCO0060037 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060038", Order = 199)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 199)]
        public System.Nullable<System.Int32> PCO0060038 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0060039", Order = 200)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 200)]
        public System.Nullable<System.Int32> PCO0060039 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070001", Order = 201)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Total (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 201)]
        public System.Nullable<System.Int32> PCO0070001 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070002", Order = 202)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 202)]
        public System.Nullable<System.Int32> PCO0070002 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070003", Order = 203)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 203)]
        public System.Nullable<System.Int32> PCO0070003 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070004", Order = 204)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 204)]
        public System.Nullable<System.Int32> PCO0070004 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070005", Order = 205)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 205)]
        public System.Nullable<System.Int32> PCO0070005 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070006", Order = 206)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 206)]
        public System.Nullable<System.Int32> PCO0070006 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070007", Order = 207)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 207)]
        public System.Nullable<System.Int32> PCO0070007 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070008", Order = 208)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 208)]
        public System.Nullable<System.Int32> PCO0070008 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070009", Order = 209)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 209)]
        public System.Nullable<System.Int32> PCO0070009 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070010", Order = 210)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 210)]
        public System.Nullable<System.Int32> PCO0070010 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070011", Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 211)]
        public System.Nullable<System.Int32> PCO0070011 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070012", Order = 212)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 212)]
        public System.Nullable<System.Int32> PCO0070012 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070013", Order = 213)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 213)]
        public System.Nullable<System.Int32> PCO0070013 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070014", Order = 214)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 214)]
        public System.Nullable<System.Int32> PCO0070014 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070015", Order = 215)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 215)]
        public System.Nullable<System.Int32> PCO0070015 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070016", Order = 216)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 216)]
        public System.Nullable<System.Int32> PCO0070016 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070017", Order = 217)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 217)]
        public System.Nullable<System.Int32> PCO0070017 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070018", Order = 218)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 218)]
        public System.Nullable<System.Int32> PCO0070018 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070019", Order = 219)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 219)]
        public System.Nullable<System.Int32> PCO0070019 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070020", Order = 220)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 220)]
        public System.Nullable<System.Int32> PCO0070020 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070021", Order = 221)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 221)]
        public System.Nullable<System.Int32> PCO0070021 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070022", Order = 222)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 222)]
        public System.Nullable<System.Int32> PCO0070022 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070023", Order = 223)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 223)]
        public System.Nullable<System.Int32> PCO0070023 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070024", Order = 224)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 224)]
        public System.Nullable<System.Int32> PCO0070024 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070025", Order = 225)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 19 years", ShortName = "15 to 19 years", Order = 225)]
        public System.Nullable<System.Int32> PCO0070025 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070026", Order = 226)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 to 24 years", ShortName = "20 to 24 years", Order = 226)]
        public System.Nullable<System.Int32> PCO0070026 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070027", Order = 227)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 227)]
        public System.Nullable<System.Int32> PCO0070027 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070028", Order = 228)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 228)]
        public System.Nullable<System.Int32> PCO0070028 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070029", Order = 229)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 229)]
        public System.Nullable<System.Int32> PCO0070029 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070030", Order = 230)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 230)]
        public System.Nullable<System.Int32> PCO0070030 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070031", Order = 231)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 231)]
        public System.Nullable<System.Int32> PCO0070031 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070032", Order = 232)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 232)]
        public System.Nullable<System.Int32> PCO0070032 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070033", Order = 233)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 233)]
        public System.Nullable<System.Int32> PCO0070033 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070034", Order = 234)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 to 64 years", ShortName = "60 to 64 years", Order = 234)]
        public System.Nullable<System.Int32> PCO0070034 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070035", Order = 235)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 to 69 years", ShortName = "65 to 69 years", Order = 235)]
        public System.Nullable<System.Int32> PCO0070035 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070036", Order = 236)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 236)]
        public System.Nullable<System.Int32> PCO0070036 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070037", Order = 237)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 237)]
        public System.Nullable<System.Int32> PCO0070037 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070038", Order = 238)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 238)]
        public System.Nullable<System.Int32> PCO0070038 { get; set; }

        [ReadOnly(false)]
        [Column("PCO0070039", Order = 239)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 239)]
        public System.Nullable<System.Int32> PCO0070039 { get; set; }
        #endregion Properties

        #region Constructors
        public SF2_Segment_08(string csvLine) : base(csvLine) {}

        public SF2_Segment_08(string[] values) : base(values) {}

        public SF2_Segment_08(OleDbDataReader reader, CensusFileType fileType)
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
                PCO0010001 = (System.Nullable<System.Int32>)reader[5];
            }
            if(reader[6] != DBNull.Value)
            {
                PCO0010002 = (System.Nullable<System.Int32>)reader[6];
            }
            if(reader[7] != DBNull.Value)
            {
                PCO0010003 = (System.Nullable<System.Int32>)reader[7];
            }
            if(reader[8] != DBNull.Value)
            {
                PCO0010004 = (System.Nullable<System.Int32>)reader[8];
            }
            if(reader[9] != DBNull.Value)
            {
                PCO0010005 = (System.Nullable<System.Int32>)reader[9];
            }
            if(reader[10] != DBNull.Value)
            {
                PCO0010006 = (System.Nullable<System.Int32>)reader[10];
            }
            if(reader[11] != DBNull.Value)
            {
                PCO0010007 = (System.Nullable<System.Int32>)reader[11];
            }
            if(reader[12] != DBNull.Value)
            {
                PCO0010008 = (System.Nullable<System.Int32>)reader[12];
            }
            if(reader[13] != DBNull.Value)
            {
                PCO0010009 = (System.Nullable<System.Int32>)reader[13];
            }
            if(reader[14] != DBNull.Value)
            {
                PCO0010010 = (System.Nullable<System.Int32>)reader[14];
            }
            if(reader[15] != DBNull.Value)
            {
                PCO0010011 = (System.Nullable<System.Int32>)reader[15];
            }
            if(reader[16] != DBNull.Value)
            {
                PCO0010012 = (System.Nullable<System.Int32>)reader[16];
            }
            if(reader[17] != DBNull.Value)
            {
                PCO0010013 = (System.Nullable<System.Int32>)reader[17];
            }
            if(reader[18] != DBNull.Value)
            {
                PCO0010014 = (System.Nullable<System.Int32>)reader[18];
            }
            if(reader[19] != DBNull.Value)
            {
                PCO0010015 = (System.Nullable<System.Int32>)reader[19];
            }
            if(reader[20] != DBNull.Value)
            {
                PCO0010016 = (System.Nullable<System.Int32>)reader[20];
            }
            if(reader[21] != DBNull.Value)
            {
                PCO0010017 = (System.Nullable<System.Int32>)reader[21];
            }
            if(reader[22] != DBNull.Value)
            {
                PCO0010018 = (System.Nullable<System.Int32>)reader[22];
            }
            if(reader[23] != DBNull.Value)
            {
                PCO0010019 = (System.Nullable<System.Int32>)reader[23];
            }
            if(reader[24] != DBNull.Value)
            {
                PCO0010020 = (System.Nullable<System.Int32>)reader[24];
            }
            if(reader[25] != DBNull.Value)
            {
                PCO0010021 = (System.Nullable<System.Int32>)reader[25];
            }
            if(reader[26] != DBNull.Value)
            {
                PCO0010022 = (System.Nullable<System.Int32>)reader[26];
            }
            if(reader[27] != DBNull.Value)
            {
                PCO0010023 = (System.Nullable<System.Int32>)reader[27];
            }
            if(reader[28] != DBNull.Value)
            {
                PCO0010024 = (System.Nullable<System.Int32>)reader[28];
            }
            if(reader[29] != DBNull.Value)
            {
                PCO0010025 = (System.Nullable<System.Int32>)reader[29];
            }
            if(reader[30] != DBNull.Value)
            {
                PCO0010026 = (System.Nullable<System.Int32>)reader[30];
            }
            if(reader[31] != DBNull.Value)
            {
                PCO0010027 = (System.Nullable<System.Int32>)reader[31];
            }
            if(reader[32] != DBNull.Value)
            {
                PCO0010028 = (System.Nullable<System.Int32>)reader[32];
            }
            if(reader[33] != DBNull.Value)
            {
                PCO0010029 = (System.Nullable<System.Int32>)reader[33];
            }
            if(reader[34] != DBNull.Value)
            {
                PCO0010030 = (System.Nullable<System.Int32>)reader[34];
            }
            if(reader[35] != DBNull.Value)
            {
                PCO0010031 = (System.Nullable<System.Int32>)reader[35];
            }
            if(reader[36] != DBNull.Value)
            {
                PCO0010032 = (System.Nullable<System.Int32>)reader[36];
            }
            if(reader[37] != DBNull.Value)
            {
                PCO0010033 = (System.Nullable<System.Int32>)reader[37];
            }
            if(reader[38] != DBNull.Value)
            {
                PCO0010034 = (System.Nullable<System.Int32>)reader[38];
            }
            if(reader[39] != DBNull.Value)
            {
                PCO0010035 = (System.Nullable<System.Int32>)reader[39];
            }
            if(reader[40] != DBNull.Value)
            {
                PCO0010036 = (System.Nullable<System.Int32>)reader[40];
            }
            if(reader[41] != DBNull.Value)
            {
                PCO0010037 = (System.Nullable<System.Int32>)reader[41];
            }
            if(reader[42] != DBNull.Value)
            {
                PCO0010038 = (System.Nullable<System.Int32>)reader[42];
            }
            if(reader[43] != DBNull.Value)
            {
                PCO0010039 = (System.Nullable<System.Int32>)reader[43];
            }
            if(reader[44] != DBNull.Value)
            {
                PCO0020001 = (System.Nullable<System.Int32>)reader[44];
            }
            if(reader[45] != DBNull.Value)
            {
                PCO0020002 = (System.Nullable<System.Int32>)reader[45];
            }
            if(reader[46] != DBNull.Value)
            {
                PCO0020003 = (System.Nullable<System.Int32>)reader[46];
            }
            if(reader[47] != DBNull.Value)
            {
                PCO0020004 = (System.Nullable<System.Int32>)reader[47];
            }
            if(reader[48] != DBNull.Value)
            {
                PCO0020005 = (System.Nullable<System.Int32>)reader[48];
            }
            if(reader[49] != DBNull.Value)
            {
                PCO0020006 = (System.Nullable<System.Int32>)reader[49];
            }
            if(reader[50] != DBNull.Value)
            {
                PCO0020007 = (System.Nullable<System.Int32>)reader[50];
            }
            if(reader[51] != DBNull.Value)
            {
                PCO0020008 = (System.Nullable<System.Int32>)reader[51];
            }
            if(reader[52] != DBNull.Value)
            {
                PCO0020009 = (System.Nullable<System.Int32>)reader[52];
            }
            if(reader[53] != DBNull.Value)
            {
                PCO0020010 = (System.Nullable<System.Int32>)reader[53];
            }
            if(reader[54] != DBNull.Value)
            {
                PCO0020011 = (System.Nullable<System.Int32>)reader[54];
            }
            if(reader[55] != DBNull.Value)
            {
                PCO0020012 = (System.Nullable<System.Int32>)reader[55];
            }
            if(reader[56] != DBNull.Value)
            {
                PCO0020013 = (System.Nullable<System.Int32>)reader[56];
            }
            if(reader[57] != DBNull.Value)
            {
                PCO0020014 = (System.Nullable<System.Int32>)reader[57];
            }
            if(reader[58] != DBNull.Value)
            {
                PCO0020015 = (System.Nullable<System.Int32>)reader[58];
            }
            if(reader[59] != DBNull.Value)
            {
                PCO0020016 = (System.Nullable<System.Int32>)reader[59];
            }
            if(reader[60] != DBNull.Value)
            {
                PCO0020017 = (System.Nullable<System.Int32>)reader[60];
            }
            if(reader[61] != DBNull.Value)
            {
                PCO0020018 = (System.Nullable<System.Int32>)reader[61];
            }
            if(reader[62] != DBNull.Value)
            {
                PCO0020019 = (System.Nullable<System.Int32>)reader[62];
            }
            if(reader[63] != DBNull.Value)
            {
                PCO0020020 = (System.Nullable<System.Int32>)reader[63];
            }
            if(reader[64] != DBNull.Value)
            {
                PCO0020021 = (System.Nullable<System.Int32>)reader[64];
            }
            if(reader[65] != DBNull.Value)
            {
                PCO0020022 = (System.Nullable<System.Int32>)reader[65];
            }
            if(reader[66] != DBNull.Value)
            {
                PCO0020023 = (System.Nullable<System.Int32>)reader[66];
            }
            if(reader[67] != DBNull.Value)
            {
                PCO0020024 = (System.Nullable<System.Int32>)reader[67];
            }
            if(reader[68] != DBNull.Value)
            {
                PCO0020025 = (System.Nullable<System.Int32>)reader[68];
            }
            if(reader[69] != DBNull.Value)
            {
                PCO0020026 = (System.Nullable<System.Int32>)reader[69];
            }
            if(reader[70] != DBNull.Value)
            {
                PCO0020027 = (System.Nullable<System.Int32>)reader[70];
            }
            if(reader[71] != DBNull.Value)
            {
                PCO0020028 = (System.Nullable<System.Int32>)reader[71];
            }
            if(reader[72] != DBNull.Value)
            {
                PCO0020029 = (System.Nullable<System.Int32>)reader[72];
            }
            if(reader[73] != DBNull.Value)
            {
                PCO0020030 = (System.Nullable<System.Int32>)reader[73];
            }
            if(reader[74] != DBNull.Value)
            {
                PCO0020031 = (System.Nullable<System.Int32>)reader[74];
            }
            if(reader[75] != DBNull.Value)
            {
                PCO0020032 = (System.Nullable<System.Int32>)reader[75];
            }
            if(reader[76] != DBNull.Value)
            {
                PCO0020033 = (System.Nullable<System.Int32>)reader[76];
            }
            if(reader[77] != DBNull.Value)
            {
                PCO0020034 = (System.Nullable<System.Int32>)reader[77];
            }
            if(reader[78] != DBNull.Value)
            {
                PCO0020035 = (System.Nullable<System.Int32>)reader[78];
            }
            if(reader[79] != DBNull.Value)
            {
                PCO0020036 = (System.Nullable<System.Int32>)reader[79];
            }
            if(reader[80] != DBNull.Value)
            {
                PCO0020037 = (System.Nullable<System.Int32>)reader[80];
            }
            if(reader[81] != DBNull.Value)
            {
                PCO0020038 = (System.Nullable<System.Int32>)reader[81];
            }
            if(reader[82] != DBNull.Value)
            {
                PCO0020039 = (System.Nullable<System.Int32>)reader[82];
            }
            if(reader[83] != DBNull.Value)
            {
                PCO0030001 = (System.Nullable<System.Int32>)reader[83];
            }
            if(reader[84] != DBNull.Value)
            {
                PCO0030002 = (System.Nullable<System.Int32>)reader[84];
            }
            if(reader[85] != DBNull.Value)
            {
                PCO0030003 = (System.Nullable<System.Int32>)reader[85];
            }
            if(reader[86] != DBNull.Value)
            {
                PCO0030004 = (System.Nullable<System.Int32>)reader[86];
            }
            if(reader[87] != DBNull.Value)
            {
                PCO0030005 = (System.Nullable<System.Int32>)reader[87];
            }
            if(reader[88] != DBNull.Value)
            {
                PCO0030006 = (System.Nullable<System.Int32>)reader[88];
            }
            if(reader[89] != DBNull.Value)
            {
                PCO0030007 = (System.Nullable<System.Int32>)reader[89];
            }
            if(reader[90] != DBNull.Value)
            {
                PCO0030008 = (System.Nullable<System.Int32>)reader[90];
            }
            if(reader[91] != DBNull.Value)
            {
                PCO0030009 = (System.Nullable<System.Int32>)reader[91];
            }
            if(reader[92] != DBNull.Value)
            {
                PCO0030010 = (System.Nullable<System.Int32>)reader[92];
            }
            if(reader[93] != DBNull.Value)
            {
                PCO0030011 = (System.Nullable<System.Int32>)reader[93];
            }
            if(reader[94] != DBNull.Value)
            {
                PCO0030012 = (System.Nullable<System.Int32>)reader[94];
            }
            if(reader[95] != DBNull.Value)
            {
                PCO0030013 = (System.Nullable<System.Int32>)reader[95];
            }
            if(reader[96] != DBNull.Value)
            {
                PCO0030014 = (System.Nullable<System.Int32>)reader[96];
            }
            if(reader[97] != DBNull.Value)
            {
                PCO0030015 = (System.Nullable<System.Int32>)reader[97];
            }
            if(reader[98] != DBNull.Value)
            {
                PCO0030016 = (System.Nullable<System.Int32>)reader[98];
            }
            if(reader[99] != DBNull.Value)
            {
                PCO0030017 = (System.Nullable<System.Int32>)reader[99];
            }
            if(reader[100] != DBNull.Value)
            {
                PCO0030018 = (System.Nullable<System.Int32>)reader[100];
            }
            if(reader[101] != DBNull.Value)
            {
                PCO0030019 = (System.Nullable<System.Int32>)reader[101];
            }
            if(reader[102] != DBNull.Value)
            {
                PCO0030020 = (System.Nullable<System.Int32>)reader[102];
            }
            if(reader[103] != DBNull.Value)
            {
                PCO0030021 = (System.Nullable<System.Int32>)reader[103];
            }
            if(reader[104] != DBNull.Value)
            {
                PCO0030022 = (System.Nullable<System.Int32>)reader[104];
            }
            if(reader[105] != DBNull.Value)
            {
                PCO0030023 = (System.Nullable<System.Int32>)reader[105];
            }
            if(reader[106] != DBNull.Value)
            {
                PCO0030024 = (System.Nullable<System.Int32>)reader[106];
            }
            if(reader[107] != DBNull.Value)
            {
                PCO0030025 = (System.Nullable<System.Int32>)reader[107];
            }
            if(reader[108] != DBNull.Value)
            {
                PCO0030026 = (System.Nullable<System.Int32>)reader[108];
            }
            if(reader[109] != DBNull.Value)
            {
                PCO0030027 = (System.Nullable<System.Int32>)reader[109];
            }
            if(reader[110] != DBNull.Value)
            {
                PCO0030028 = (System.Nullable<System.Int32>)reader[110];
            }
            if(reader[111] != DBNull.Value)
            {
                PCO0030029 = (System.Nullable<System.Int32>)reader[111];
            }
            if(reader[112] != DBNull.Value)
            {
                PCO0030030 = (System.Nullable<System.Int32>)reader[112];
            }
            if(reader[113] != DBNull.Value)
            {
                PCO0030031 = (System.Nullable<System.Int32>)reader[113];
            }
            if(reader[114] != DBNull.Value)
            {
                PCO0030032 = (System.Nullable<System.Int32>)reader[114];
            }
            if(reader[115] != DBNull.Value)
            {
                PCO0030033 = (System.Nullable<System.Int32>)reader[115];
            }
            if(reader[116] != DBNull.Value)
            {
                PCO0040001 = (System.Nullable<System.Int32>)reader[116];
            }
            if(reader[117] != DBNull.Value)
            {
                PCO0040002 = (System.Nullable<System.Int32>)reader[117];
            }
            if(reader[118] != DBNull.Value)
            {
                PCO0040003 = (System.Nullable<System.Int32>)reader[118];
            }
            if(reader[119] != DBNull.Value)
            {
                PCO0040004 = (System.Nullable<System.Int32>)reader[119];
            }
            if(reader[120] != DBNull.Value)
            {
                PCO0040005 = (System.Nullable<System.Int32>)reader[120];
            }
            if(reader[121] != DBNull.Value)
            {
                PCO0040006 = (System.Nullable<System.Int32>)reader[121];
            }
            if(reader[122] != DBNull.Value)
            {
                PCO0040007 = (System.Nullable<System.Int32>)reader[122];
            }
            if(reader[123] != DBNull.Value)
            {
                PCO0040008 = (System.Nullable<System.Int32>)reader[123];
            }
            if(reader[124] != DBNull.Value)
            {
                PCO0040009 = (System.Nullable<System.Int32>)reader[124];
            }
            if(reader[125] != DBNull.Value)
            {
                PCO0040010 = (System.Nullable<System.Int32>)reader[125];
            }
            if(reader[126] != DBNull.Value)
            {
                PCO0040011 = (System.Nullable<System.Int32>)reader[126];
            }
            if(reader[127] != DBNull.Value)
            {
                PCO0040012 = (System.Nullable<System.Int32>)reader[127];
            }
            if(reader[128] != DBNull.Value)
            {
                PCO0040013 = (System.Nullable<System.Int32>)reader[128];
            }
            if(reader[129] != DBNull.Value)
            {
                PCO0040014 = (System.Nullable<System.Int32>)reader[129];
            }
            if(reader[130] != DBNull.Value)
            {
                PCO0040015 = (System.Nullable<System.Int32>)reader[130];
            }
            if(reader[131] != DBNull.Value)
            {
                PCO0050001 = (System.Nullable<System.Int32>)reader[131];
            }
            if(reader[132] != DBNull.Value)
            {
                PCO0050002 = (System.Nullable<System.Int32>)reader[132];
            }
            if(reader[133] != DBNull.Value)
            {
                PCO0050003 = (System.Nullable<System.Int32>)reader[133];
            }
            if(reader[134] != DBNull.Value)
            {
                PCO0050004 = (System.Nullable<System.Int32>)reader[134];
            }
            if(reader[135] != DBNull.Value)
            {
                PCO0050005 = (System.Nullable<System.Int32>)reader[135];
            }
            if(reader[136] != DBNull.Value)
            {
                PCO0050006 = (System.Nullable<System.Int32>)reader[136];
            }
            if(reader[137] != DBNull.Value)
            {
                PCO0050007 = (System.Nullable<System.Int32>)reader[137];
            }
            if(reader[138] != DBNull.Value)
            {
                PCO0050008 = (System.Nullable<System.Int32>)reader[138];
            }
            if(reader[139] != DBNull.Value)
            {
                PCO0050009 = (System.Nullable<System.Int32>)reader[139];
            }
            if(reader[140] != DBNull.Value)
            {
                PCO0050010 = (System.Nullable<System.Int32>)reader[140];
            }
            if(reader[141] != DBNull.Value)
            {
                PCO0050011 = (System.Nullable<System.Int32>)reader[141];
            }
            if(reader[142] != DBNull.Value)
            {
                PCO0050012 = (System.Nullable<System.Int32>)reader[142];
            }
            if(reader[143] != DBNull.Value)
            {
                PCO0050013 = (System.Nullable<System.Int32>)reader[143];
            }
            if(reader[144] != DBNull.Value)
            {
                PCO0050014 = (System.Nullable<System.Int32>)reader[144];
            }
            if(reader[145] != DBNull.Value)
            {
                PCO0050015 = (System.Nullable<System.Int32>)reader[145];
            }
            if(reader[146] != DBNull.Value)
            {
                PCO0050016 = (System.Nullable<System.Int32>)reader[146];
            }
            if(reader[147] != DBNull.Value)
            {
                PCO0050017 = (System.Nullable<System.Int32>)reader[147];
            }
            if(reader[148] != DBNull.Value)
            {
                PCO0050018 = (System.Nullable<System.Int32>)reader[148];
            }
            if(reader[149] != DBNull.Value)
            {
                PCO0050019 = (System.Nullable<System.Int32>)reader[149];
            }
            if(reader[150] != DBNull.Value)
            {
                PCO0050020 = (System.Nullable<System.Int32>)reader[150];
            }
            if(reader[151] != DBNull.Value)
            {
                PCO0050021 = (System.Nullable<System.Int32>)reader[151];
            }
            if(reader[152] != DBNull.Value)
            {
                PCO0050022 = (System.Nullable<System.Int32>)reader[152];
            }
            if(reader[153] != DBNull.Value)
            {
                PCO0050023 = (System.Nullable<System.Int32>)reader[153];
            }
            if(reader[154] != DBNull.Value)
            {
                PCO0050024 = (System.Nullable<System.Int32>)reader[154];
            }
            if(reader[155] != DBNull.Value)
            {
                PCO0050025 = (System.Nullable<System.Int32>)reader[155];
            }
            if(reader[156] != DBNull.Value)
            {
                PCO0050026 = (System.Nullable<System.Int32>)reader[156];
            }
            if(reader[157] != DBNull.Value)
            {
                PCO0050027 = (System.Nullable<System.Int32>)reader[157];
            }
            if(reader[158] != DBNull.Value)
            {
                PCO0050028 = (System.Nullable<System.Int32>)reader[158];
            }
            if(reader[159] != DBNull.Value)
            {
                PCO0050029 = (System.Nullable<System.Int32>)reader[159];
            }
            if(reader[160] != DBNull.Value)
            {
                PCO0050030 = (System.Nullable<System.Int32>)reader[160];
            }
            if(reader[161] != DBNull.Value)
            {
                PCO0050031 = (System.Nullable<System.Int32>)reader[161];
            }
            if(reader[162] != DBNull.Value)
            {
                PCO0060001 = (System.Nullable<System.Int32>)reader[162];
            }
            if(reader[163] != DBNull.Value)
            {
                PCO0060002 = (System.Nullable<System.Int32>)reader[163];
            }
            if(reader[164] != DBNull.Value)
            {
                PCO0060003 = (System.Nullable<System.Int32>)reader[164];
            }
            if(reader[165] != DBNull.Value)
            {
                PCO0060004 = (System.Nullable<System.Int32>)reader[165];
            }
            if(reader[166] != DBNull.Value)
            {
                PCO0060005 = (System.Nullable<System.Int32>)reader[166];
            }
            if(reader[167] != DBNull.Value)
            {
                PCO0060006 = (System.Nullable<System.Int32>)reader[167];
            }
            if(reader[168] != DBNull.Value)
            {
                PCO0060007 = (System.Nullable<System.Int32>)reader[168];
            }
            if(reader[169] != DBNull.Value)
            {
                PCO0060008 = (System.Nullable<System.Int32>)reader[169];
            }
            if(reader[170] != DBNull.Value)
            {
                PCO0060009 = (System.Nullable<System.Int32>)reader[170];
            }
            if(reader[171] != DBNull.Value)
            {
                PCO0060010 = (System.Nullable<System.Int32>)reader[171];
            }
            if(reader[172] != DBNull.Value)
            {
                PCO0060011 = (System.Nullable<System.Int32>)reader[172];
            }
            if(reader[173] != DBNull.Value)
            {
                PCO0060012 = (System.Nullable<System.Int32>)reader[173];
            }
            if(reader[174] != DBNull.Value)
            {
                PCO0060013 = (System.Nullable<System.Int32>)reader[174];
            }
            if(reader[175] != DBNull.Value)
            {
                PCO0060014 = (System.Nullable<System.Int32>)reader[175];
            }
            if(reader[176] != DBNull.Value)
            {
                PCO0060015 = (System.Nullable<System.Int32>)reader[176];
            }
            if(reader[177] != DBNull.Value)
            {
                PCO0060016 = (System.Nullable<System.Int32>)reader[177];
            }
            if(reader[178] != DBNull.Value)
            {
                PCO0060017 = (System.Nullable<System.Int32>)reader[178];
            }
            if(reader[179] != DBNull.Value)
            {
                PCO0060018 = (System.Nullable<System.Int32>)reader[179];
            }
            if(reader[180] != DBNull.Value)
            {
                PCO0060019 = (System.Nullable<System.Int32>)reader[180];
            }
            if(reader[181] != DBNull.Value)
            {
                PCO0060020 = (System.Nullable<System.Int32>)reader[181];
            }
            if(reader[182] != DBNull.Value)
            {
                PCO0060021 = (System.Nullable<System.Int32>)reader[182];
            }
            if(reader[183] != DBNull.Value)
            {
                PCO0060022 = (System.Nullable<System.Int32>)reader[183];
            }
            if(reader[184] != DBNull.Value)
            {
                PCO0060023 = (System.Nullable<System.Int32>)reader[184];
            }
            if(reader[185] != DBNull.Value)
            {
                PCO0060024 = (System.Nullable<System.Int32>)reader[185];
            }
            if(reader[186] != DBNull.Value)
            {
                PCO0060025 = (System.Nullable<System.Int32>)reader[186];
            }
            if(reader[187] != DBNull.Value)
            {
                PCO0060026 = (System.Nullable<System.Int32>)reader[187];
            }
            if(reader[188] != DBNull.Value)
            {
                PCO0060027 = (System.Nullable<System.Int32>)reader[188];
            }
            if(reader[189] != DBNull.Value)
            {
                PCO0060028 = (System.Nullable<System.Int32>)reader[189];
            }
            if(reader[190] != DBNull.Value)
            {
                PCO0060029 = (System.Nullable<System.Int32>)reader[190];
            }
            if(reader[191] != DBNull.Value)
            {
                PCO0060030 = (System.Nullable<System.Int32>)reader[191];
            }
            if(reader[192] != DBNull.Value)
            {
                PCO0060031 = (System.Nullable<System.Int32>)reader[192];
            }
            if(reader[193] != DBNull.Value)
            {
                PCO0060032 = (System.Nullable<System.Int32>)reader[193];
            }
            if(reader[194] != DBNull.Value)
            {
                PCO0060033 = (System.Nullable<System.Int32>)reader[194];
            }
            if(reader[195] != DBNull.Value)
            {
                PCO0060034 = (System.Nullable<System.Int32>)reader[195];
            }
            if(reader[196] != DBNull.Value)
            {
                PCO0060035 = (System.Nullable<System.Int32>)reader[196];
            }
            if(reader[197] != DBNull.Value)
            {
                PCO0060036 = (System.Nullable<System.Int32>)reader[197];
            }
            if(reader[198] != DBNull.Value)
            {
                PCO0060037 = (System.Nullable<System.Int32>)reader[198];
            }
            if(reader[199] != DBNull.Value)
            {
                PCO0060038 = (System.Nullable<System.Int32>)reader[199];
            }
            if(reader[200] != DBNull.Value)
            {
                PCO0060039 = (System.Nullable<System.Int32>)reader[200];
            }
            if(reader[201] != DBNull.Value)
            {
                PCO0070001 = (System.Nullable<System.Int32>)reader[201];
            }
            if(reader[202] != DBNull.Value)
            {
                PCO0070002 = (System.Nullable<System.Int32>)reader[202];
            }
            if(reader[203] != DBNull.Value)
            {
                PCO0070003 = (System.Nullable<System.Int32>)reader[203];
            }
            if(reader[204] != DBNull.Value)
            {
                PCO0070004 = (System.Nullable<System.Int32>)reader[204];
            }
            if(reader[205] != DBNull.Value)
            {
                PCO0070005 = (System.Nullable<System.Int32>)reader[205];
            }
            if(reader[206] != DBNull.Value)
            {
                PCO0070006 = (System.Nullable<System.Int32>)reader[206];
            }
            if(reader[207] != DBNull.Value)
            {
                PCO0070007 = (System.Nullable<System.Int32>)reader[207];
            }
            if(reader[208] != DBNull.Value)
            {
                PCO0070008 = (System.Nullable<System.Int32>)reader[208];
            }
            if(reader[209] != DBNull.Value)
            {
                PCO0070009 = (System.Nullable<System.Int32>)reader[209];
            }
            if(reader[210] != DBNull.Value)
            {
                PCO0070010 = (System.Nullable<System.Int32>)reader[210];
            }
            if(reader[211] != DBNull.Value)
            {
                PCO0070011 = (System.Nullable<System.Int32>)reader[211];
            }
            if(reader[212] != DBNull.Value)
            {
                PCO0070012 = (System.Nullable<System.Int32>)reader[212];
            }
            if(reader[213] != DBNull.Value)
            {
                PCO0070013 = (System.Nullable<System.Int32>)reader[213];
            }
            if(reader[214] != DBNull.Value)
            {
                PCO0070014 = (System.Nullable<System.Int32>)reader[214];
            }
            if(reader[215] != DBNull.Value)
            {
                PCO0070015 = (System.Nullable<System.Int32>)reader[215];
            }
            if(reader[216] != DBNull.Value)
            {
                PCO0070016 = (System.Nullable<System.Int32>)reader[216];
            }
            if(reader[217] != DBNull.Value)
            {
                PCO0070017 = (System.Nullable<System.Int32>)reader[217];
            }
            if(reader[218] != DBNull.Value)
            {
                PCO0070018 = (System.Nullable<System.Int32>)reader[218];
            }
            if(reader[219] != DBNull.Value)
            {
                PCO0070019 = (System.Nullable<System.Int32>)reader[219];
            }
            if(reader[220] != DBNull.Value)
            {
                PCO0070020 = (System.Nullable<System.Int32>)reader[220];
            }
            if(reader[221] != DBNull.Value)
            {
                PCO0070021 = (System.Nullable<System.Int32>)reader[221];
            }
            if(reader[222] != DBNull.Value)
            {
                PCO0070022 = (System.Nullable<System.Int32>)reader[222];
            }
            if(reader[223] != DBNull.Value)
            {
                PCO0070023 = (System.Nullable<System.Int32>)reader[223];
            }
            if(reader[224] != DBNull.Value)
            {
                PCO0070024 = (System.Nullable<System.Int32>)reader[224];
            }
            if(reader[225] != DBNull.Value)
            {
                PCO0070025 = (System.Nullable<System.Int32>)reader[225];
            }
            if(reader[226] != DBNull.Value)
            {
                PCO0070026 = (System.Nullable<System.Int32>)reader[226];
            }
            if(reader[227] != DBNull.Value)
            {
                PCO0070027 = (System.Nullable<System.Int32>)reader[227];
            }
            if(reader[228] != DBNull.Value)
            {
                PCO0070028 = (System.Nullable<System.Int32>)reader[228];
            }
            if(reader[229] != DBNull.Value)
            {
                PCO0070029 = (System.Nullable<System.Int32>)reader[229];
            }
            if(reader[230] != DBNull.Value)
            {
                PCO0070030 = (System.Nullable<System.Int32>)reader[230];
            }
            if(reader[231] != DBNull.Value)
            {
                PCO0070031 = (System.Nullable<System.Int32>)reader[231];
            }
            if(reader[232] != DBNull.Value)
            {
                PCO0070032 = (System.Nullable<System.Int32>)reader[232];
            }
            if(reader[233] != DBNull.Value)
            {
                PCO0070033 = (System.Nullable<System.Int32>)reader[233];
            }
            if(reader[234] != DBNull.Value)
            {
                PCO0070034 = (System.Nullable<System.Int32>)reader[234];
            }
            if(reader[235] != DBNull.Value)
            {
                PCO0070035 = (System.Nullable<System.Int32>)reader[235];
            }
            if(reader[236] != DBNull.Value)
            {
                PCO0070036 = (System.Nullable<System.Int32>)reader[236];
            }
            if(reader[237] != DBNull.Value)
            {
                PCO0070037 = (System.Nullable<System.Int32>)reader[237];
            }
            if(reader[238] != DBNull.Value)
            {
                PCO0070038 = (System.Nullable<System.Int32>)reader[238];
            }
            if(reader[239] != DBNull.Value)
            {
                PCO0070039 = (System.Nullable<System.Int32>)reader[239];
            }
        }
        #endregion Constructors
    }
}