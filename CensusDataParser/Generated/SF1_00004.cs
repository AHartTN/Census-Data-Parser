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

    [Table("SF1_00004")]
    public partial class SF1_00004 : BaseModel
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
        [Column("P0100001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public System.Nullable<System.Int32> P0100001 { get; set; }

        [ReadOnly(false)]
        [Column("P0100002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of one race:", ShortName = "Population of one race:", Order = 6)]
        public System.Nullable<System.Int32> P0100002 { get; set; }

        [ReadOnly(false)]
        [Column("P0100003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White alone", ShortName = "White alone", Order = 7)]
        public System.Nullable<System.Int32> P0100003 { get; set; }

        [ReadOnly(false)]
        [Column("P0100004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American alone", ShortName = "Black or African American alone", Order = 8)]
        public System.Nullable<System.Int32> P0100004 { get; set; }

        [ReadOnly(false)]
        [Column("P0100005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native alone", ShortName = "American Indian and Alaska Native alone", Order = 9)]
        public System.Nullable<System.Int32> P0100005 { get; set; }

        [ReadOnly(false)]
        [Column("P0100006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian alone", ShortName = "Asian alone", Order = 10)]
        public System.Nullable<System.Int32> P0100006 { get; set; }

        [ReadOnly(false)]
        [Column("P0100007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander alone", ShortName = "Native Hawaiian and Other Pacific Islander alone", Order = 11)]
        public System.Nullable<System.Int32> P0100007 { get; set; }

        [ReadOnly(false)]
        [Column("P0100008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Some Other Race alone", ShortName = "Some Other Race alone", Order = 12)]
        public System.Nullable<System.Int32> P0100008 { get; set; }

        [ReadOnly(false)]
        [Column("P0100009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Two or More Races:", ShortName = "Two or More Races:", Order = 13)]
        public System.Nullable<System.Int32> P0100009 { get; set; }

        [ReadOnly(false)]
        [Column("P0100010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of two races:", ShortName = "Population of two races:", Order = 14)]
        public System.Nullable<System.Int32> P0100010 { get; set; }

        [ReadOnly(false)]
        [Column("P0100011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American", ShortName = "White; Black or African American", Order = 15)]
        public System.Nullable<System.Int32> P0100011 { get; set; }

        [ReadOnly(false)]
        [Column("P0100012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native", ShortName = "White; American Indian and Alaska Native", Order = 16)]
        public System.Nullable<System.Int32> P0100012 { get; set; }

        [ReadOnly(false)]
        [Column("P0100013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian", ShortName = "White; Asian", Order = 17)]
        public System.Nullable<System.Int32> P0100013 { get; set; }

        [ReadOnly(false)]
        [Column("P0100014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Native Hawaiian and Other Pacific Islander", ShortName = "White; Native Hawaiian and Other Pacific Islander", Order = 18)]
        public System.Nullable<System.Int32> P0100014 { get; set; }

        [ReadOnly(false)]
        [Column("P0100015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Some Other Race", ShortName = "White; Some Other Race", Order = 19)]
        public System.Nullable<System.Int32> P0100015 { get; set; }

        [ReadOnly(false)]
        [Column("P0100016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native", ShortName = "Black or African American; American Indian and Alaska Native", Order = 20)]
        public System.Nullable<System.Int32> P0100016 { get; set; }

        [ReadOnly(false)]
        [Column("P0100017", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian", ShortName = "Black or African American; Asian", Order = 21)]
        public System.Nullable<System.Int32> P0100017 { get; set; }

        [ReadOnly(false)]
        [Column("P0100018", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander", Order = 22)]
        public System.Nullable<System.Int32> P0100018 { get; set; }

        [ReadOnly(false)]
        [Column("P0100019", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Some Other Race", ShortName = "Black or African American; Some Other Race", Order = 23)]
        public System.Nullable<System.Int32> P0100019 { get; set; }

        [ReadOnly(false)]
        [Column("P0100020", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian", ShortName = "American Indian and Alaska Native; Asian", Order = 24)]
        public System.Nullable<System.Int32> P0100020 { get; set; }

        [ReadOnly(false)]
        [Column("P0100021", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 25)]
        public System.Nullable<System.Int32> P0100021 { get; set; }

        [ReadOnly(false)]
        [Column("P0100022", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Some Other Race", ShortName = "American Indian and Alaska Native; Some Other Race", Order = 26)]
        public System.Nullable<System.Int32> P0100022 { get; set; }

        [ReadOnly(false)]
        [Column("P0100023", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Asian; Native Hawaiian and Other Pacific Islander", Order = 27)]
        public System.Nullable<System.Int32> P0100023 { get; set; }

        [ReadOnly(false)]
        [Column("P0100024", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian; Some Other Race", ShortName = "Asian; Some Other Race", Order = 28)]
        public System.Nullable<System.Int32> P0100024 { get; set; }

        [ReadOnly(false)]
        [Column("P0100025", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 29)]
        public System.Nullable<System.Int32> P0100025 { get; set; }

        [ReadOnly(false)]
        [Column("P0100026", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of three races:", ShortName = "Population of three races:", Order = 30)]
        public System.Nullable<System.Int32> P0100026 { get; set; }

        [ReadOnly(false)]
        [Column("P0100027", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native", ShortName = "White; Black or African American; American Indian and Alaska Native", Order = 31)]
        public System.Nullable<System.Int32> P0100027 { get; set; }

        [ReadOnly(false)]
        [Column("P0100028", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian", ShortName = "White; Black or African American; Asian", Order = 32)]
        public System.Nullable<System.Int32> P0100028 { get; set; }

        [ReadOnly(false)]
        [Column("P0100029", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander", Order = 33)]
        public System.Nullable<System.Int32> P0100029 { get; set; }

        [ReadOnly(false)]
        [Column("P0100030", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Some Other Race", ShortName = "White; Black or African American; Some Other Race", Order = 34)]
        public System.Nullable<System.Int32> P0100030 { get; set; }

        [ReadOnly(false)]
        [Column("P0100031", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian", ShortName = "White; American Indian and Alaska Native; Asian", Order = 35)]
        public System.Nullable<System.Int32> P0100031 { get; set; }

        [ReadOnly(false)]
        [Column("P0100032", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 36)]
        public System.Nullable<System.Int32> P0100032 { get; set; }

        [ReadOnly(false)]
        [Column("P0100033", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Some Other Race", ShortName = "White; American Indian and Alaska Native; Some Other Race", Order = 37)]
        public System.Nullable<System.Int32> P0100033 { get; set; }

        [ReadOnly(false)]
        [Column("P0100034", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander", Order = 38)]
        public System.Nullable<System.Int32> P0100034 { get; set; }

        [ReadOnly(false)]
        [Column("P0100035", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian; Some Other Race", ShortName = "White; Asian; Some Other Race", Order = 39)]
        public System.Nullable<System.Int32> P0100035 { get; set; }

        [ReadOnly(false)]
        [Column("P0100036", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 40)]
        public System.Nullable<System.Int32> P0100036 { get; set; }

        [ReadOnly(false)]
        [Column("P0100037", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian", ShortName = "Black or African American; American Indian and Alaska Native; Asian", Order = 41)]
        public System.Nullable<System.Int32> P0100037 { get; set; }

        [ReadOnly(false)]
        [Column("P0100038", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 42)]
        public System.Nullable<System.Int32> P0100038 { get; set; }

        [ReadOnly(false)]
        [Column("P0100039", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Some Other Race", Order = 43)]
        public System.Nullable<System.Int32> P0100039 { get; set; }

        [ReadOnly(false)]
        [Column("P0100040", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 44)]
        public System.Nullable<System.Int32> P0100040 { get; set; }

        [ReadOnly(false)]
        [Column("P0100041", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian; Some Other Race", ShortName = "Black or African American; Asian; Some Other Race", Order = 45)]
        public System.Nullable<System.Int32> P0100041 { get; set; }

        [ReadOnly(false)]
        [Column("P0100042", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 46)]
        public System.Nullable<System.Int32> P0100042 { get; set; }

        [ReadOnly(false)]
        [Column("P0100043", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 47)]
        public System.Nullable<System.Int32> P0100043 { get; set; }

        [ReadOnly(false)]
        [Column("P0100044", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Some Other Race", Order = 48)]
        public System.Nullable<System.Int32> P0100044 { get; set; }

        [ReadOnly(false)]
        [Column("P0100045", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 49)]
        public System.Nullable<System.Int32> P0100045 { get; set; }

        [ReadOnly(false)]
        [Column("P0100046", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 50)]
        public System.Nullable<System.Int32> P0100046 { get; set; }

        [ReadOnly(false)]
        [Column("P0100047", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of four races:", ShortName = "Population of four races:", Order = 51)]
        public System.Nullable<System.Int32> P0100047 { get; set; }

        [ReadOnly(false)]
        [Column("P0100048", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian", Order = 52)]
        public System.Nullable<System.Int32> P0100048 { get; set; }

        [ReadOnly(false)]
        [Column("P0100049", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 53)]
        public System.Nullable<System.Int32> P0100049 { get; set; }

        [ReadOnly(false)]
        [Column("P0100050", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Some Other Race", Order = 54)]
        public System.Nullable<System.Int32> P0100050 { get; set; }

        [ReadOnly(false)]
        [Column("P0100051", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 55)]
        public System.Nullable<System.Int32> P0100051 { get; set; }

        [ReadOnly(false)]
        [Column("P0100052", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian; Some Other Race", ShortName = "White; Black or African American; Asian; Some Other Race", Order = 56)]
        public System.Nullable<System.Int32> P0100052 { get; set; }

        [ReadOnly(false)]
        [Column("P0100053", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 57)]
        public System.Nullable<System.Int32> P0100053 { get; set; }

        [ReadOnly(false)]
        [Column("P0100054", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 58)]
        public System.Nullable<System.Int32> P0100054 { get; set; }

        [ReadOnly(false)]
        [Column("P0100055", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Some Other Race", Order = 59)]
        public System.Nullable<System.Int32> P0100055 { get; set; }

        [ReadOnly(false)]
        [Column("P0100056", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 60)]
        public System.Nullable<System.Int32> P0100056 { get; set; }

        [ReadOnly(false)]
        [Column("P0100057", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 61)]
        public System.Nullable<System.Int32> P0100057 { get; set; }

        [ReadOnly(false)]
        [Column("P0100058", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 62)]
        public System.Nullable<System.Int32> P0100058 { get; set; }

        [ReadOnly(false)]
        [Column("P0100059", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 63)]
        public System.Nullable<System.Int32> P0100059 { get; set; }

        [ReadOnly(false)]
        [Column("P0100060", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 64)]
        public System.Nullable<System.Int32> P0100060 { get; set; }

        [ReadOnly(false)]
        [Column("P0100061", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 65)]
        public System.Nullable<System.Int32> P0100061 { get; set; }

        [ReadOnly(false)]
        [Column("P0100062", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 66)]
        public System.Nullable<System.Int32> P0100062 { get; set; }

        [ReadOnly(false)]
        [Column("P0100063", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of five races:", ShortName = "Population of five races:", Order = 67)]
        public System.Nullable<System.Int32> P0100063 { get; set; }

        [ReadOnly(false)]
        [Column("P0100064", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 68)]
        public System.Nullable<System.Int32> P0100064 { get; set; }

        [ReadOnly(false)]
        [Column("P0100065", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 69)]
        public System.Nullable<System.Int32> P0100065 { get; set; }

        [ReadOnly(false)]
        [Column("P0100066", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 70)]
        public System.Nullable<System.Int32> P0100066 { get; set; }

        [ReadOnly(false)]
        [Column("P0100067", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 71)]
        public System.Nullable<System.Int32> P0100067 { get; set; }

        [ReadOnly(false)]
        [Column("P0100068", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 72)]
        public System.Nullable<System.Int32> P0100068 { get; set; }

        [ReadOnly(false)]
        [Column("P0100069", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 73)]
        public System.Nullable<System.Int32> P0100069 { get; set; }

        [ReadOnly(false)]
        [Column("P0100070", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of six races:", ShortName = "Population of six races:", Order = 74)]
        public System.Nullable<System.Int32> P0100070 { get; set; }

        [ReadOnly(false)]
        [Column("P0100071", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 75)]
        public System.Nullable<System.Int32> P0100071 { get; set; }

        [ReadOnly(false)]
        [Column("P0110001", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 76)]
        public System.Nullable<System.Int32> P0110001 { get; set; }

        [ReadOnly(false)]
        [Column("P0110002", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hispanic or Latino", ShortName = "Hispanic or Latino", Order = 77)]
        public System.Nullable<System.Int32> P0110002 { get; set; }

        [ReadOnly(false)]
        [Column("P0110003", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not Hispanic or Latino:", ShortName = "Not Hispanic or Latino:", Order = 78)]
        public System.Nullable<System.Int32> P0110003 { get; set; }

        [ReadOnly(false)]
        [Column("P0110004", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of one race:", ShortName = "Population of one race:", Order = 79)]
        public System.Nullable<System.Int32> P0110004 { get; set; }

        [ReadOnly(false)]
        [Column("P0110005", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White alone", ShortName = "White alone", Order = 80)]
        public System.Nullable<System.Int32> P0110005 { get; set; }

        [ReadOnly(false)]
        [Column("P0110006", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American alone", ShortName = "Black or African American alone", Order = 81)]
        public System.Nullable<System.Int32> P0110006 { get; set; }

        [ReadOnly(false)]
        [Column("P0110007", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native alone", ShortName = "American Indian and Alaska Native alone", Order = 82)]
        public System.Nullable<System.Int32> P0110007 { get; set; }

        [ReadOnly(false)]
        [Column("P0110008", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian alone", ShortName = "Asian alone", Order = 83)]
        public System.Nullable<System.Int32> P0110008 { get; set; }

        [ReadOnly(false)]
        [Column("P0110009", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander alone", ShortName = "Native Hawaiian and Other Pacific Islander alone", Order = 84)]
        public System.Nullable<System.Int32> P0110009 { get; set; }

        [ReadOnly(false)]
        [Column("P0110010", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Some Other Race alone", ShortName = "Some Other Race alone", Order = 85)]
        public System.Nullable<System.Int32> P0110010 { get; set; }

        [ReadOnly(false)]
        [Column("P0110011", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Two or More Races:", ShortName = "Two or More Races:", Order = 86)]
        public System.Nullable<System.Int32> P0110011 { get; set; }

        [ReadOnly(false)]
        [Column("P0110012", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of two races:", ShortName = "Population of two races:", Order = 87)]
        public System.Nullable<System.Int32> P0110012 { get; set; }

        [ReadOnly(false)]
        [Column("P0110013", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American", ShortName = "White; Black or African American", Order = 88)]
        public System.Nullable<System.Int32> P0110013 { get; set; }

        [ReadOnly(false)]
        [Column("P0110014", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native", ShortName = "White; American Indian and Alaska Native", Order = 89)]
        public System.Nullable<System.Int32> P0110014 { get; set; }

        [ReadOnly(false)]
        [Column("P0110015", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian", ShortName = "White; Asian", Order = 90)]
        public System.Nullable<System.Int32> P0110015 { get; set; }

        [ReadOnly(false)]
        [Column("P0110016", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Native Hawaiian and Other Pacific Islander", ShortName = "White; Native Hawaiian and Other Pacific Islander", Order = 91)]
        public System.Nullable<System.Int32> P0110016 { get; set; }

        [ReadOnly(false)]
        [Column("P0110017", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Some Other Race", ShortName = "White; Some Other Race", Order = 92)]
        public System.Nullable<System.Int32> P0110017 { get; set; }

        [ReadOnly(false)]
        [Column("P0110018", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native", ShortName = "Black or African American; American Indian and Alaska Native", Order = 93)]
        public System.Nullable<System.Int32> P0110018 { get; set; }

        [ReadOnly(false)]
        [Column("P0110019", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian", ShortName = "Black or African American; Asian", Order = 94)]
        public System.Nullable<System.Int32> P0110019 { get; set; }

        [ReadOnly(false)]
        [Column("P0110020", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander", Order = 95)]
        public System.Nullable<System.Int32> P0110020 { get; set; }

        [ReadOnly(false)]
        [Column("P0110021", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Some Other Race", ShortName = "Black or African American; Some Other Race", Order = 96)]
        public System.Nullable<System.Int32> P0110021 { get; set; }

        [ReadOnly(false)]
        [Column("P0110022", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian", ShortName = "American Indian and Alaska Native; Asian", Order = 97)]
        public System.Nullable<System.Int32> P0110022 { get; set; }

        [ReadOnly(false)]
        [Column("P0110023", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 98)]
        public System.Nullable<System.Int32> P0110023 { get; set; }

        [ReadOnly(false)]
        [Column("P0110024", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Some Other Race", ShortName = "American Indian and Alaska Native; Some Other Race", Order = 99)]
        public System.Nullable<System.Int32> P0110024 { get; set; }

        [ReadOnly(false)]
        [Column("P0110025", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Asian; Native Hawaiian and Other Pacific Islander", Order = 100)]
        public System.Nullable<System.Int32> P0110025 { get; set; }

        [ReadOnly(false)]
        [Column("P0110026", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian; Some Other Race", ShortName = "Asian; Some Other Race", Order = 101)]
        public System.Nullable<System.Int32> P0110026 { get; set; }

        [ReadOnly(false)]
        [Column("P0110027", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 102)]
        public System.Nullable<System.Int32> P0110027 { get; set; }

        [ReadOnly(false)]
        [Column("P0110028", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of three races:", ShortName = "Population of three races:", Order = 103)]
        public System.Nullable<System.Int32> P0110028 { get; set; }

        [ReadOnly(false)]
        [Column("P0110029", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native", ShortName = "White; Black or African American; American Indian and Alaska Native", Order = 104)]
        public System.Nullable<System.Int32> P0110029 { get; set; }

        [ReadOnly(false)]
        [Column("P0110030", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian", ShortName = "White; Black or African American; Asian", Order = 105)]
        public System.Nullable<System.Int32> P0110030 { get; set; }

        [ReadOnly(false)]
        [Column("P0110031", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander", Order = 106)]
        public System.Nullable<System.Int32> P0110031 { get; set; }

        [ReadOnly(false)]
        [Column("P0110032", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Some Other Race", ShortName = "White; Black or African American; Some Other Race", Order = 107)]
        public System.Nullable<System.Int32> P0110032 { get; set; }

        [ReadOnly(false)]
        [Column("P0110033", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian", ShortName = "White; American Indian and Alaska Native; Asian", Order = 108)]
        public System.Nullable<System.Int32> P0110033 { get; set; }

        [ReadOnly(false)]
        [Column("P0110034", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 109)]
        public System.Nullable<System.Int32> P0110034 { get; set; }

        [ReadOnly(false)]
        [Column("P0110035", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Some Other Race", ShortName = "White; American Indian and Alaska Native; Some Other Race", Order = 110)]
        public System.Nullable<System.Int32> P0110035 { get; set; }

        [ReadOnly(false)]
        [Column("P0110036", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander", Order = 111)]
        public System.Nullable<System.Int32> P0110036 { get; set; }

        [ReadOnly(false)]
        [Column("P0110037", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian; Some Other Race", ShortName = "White; Asian; Some Other Race", Order = 112)]
        public System.Nullable<System.Int32> P0110037 { get; set; }

        [ReadOnly(false)]
        [Column("P0110038", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 113)]
        public System.Nullable<System.Int32> P0110038 { get; set; }

        [ReadOnly(false)]
        [Column("P0110039", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian", ShortName = "Black or African American; American Indian and Alaska Native; Asian", Order = 114)]
        public System.Nullable<System.Int32> P0110039 { get; set; }

        [ReadOnly(false)]
        [Column("P0110040", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 115)]
        public System.Nullable<System.Int32> P0110040 { get; set; }

        [ReadOnly(false)]
        [Column("P0110041", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Some Other Race", Order = 116)]
        public System.Nullable<System.Int32> P0110041 { get; set; }

        [ReadOnly(false)]
        [Column("P0110042", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 117)]
        public System.Nullable<System.Int32> P0110042 { get; set; }

        [ReadOnly(false)]
        [Column("P0110043", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian; Some Other Race", ShortName = "Black or African American; Asian; Some Other Race", Order = 118)]
        public System.Nullable<System.Int32> P0110043 { get; set; }

        [ReadOnly(false)]
        [Column("P0110044", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 119)]
        public System.Nullable<System.Int32> P0110044 { get; set; }

        [ReadOnly(false)]
        [Column("P0110045", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 120)]
        public System.Nullable<System.Int32> P0110045 { get; set; }

        [ReadOnly(false)]
        [Column("P0110046", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Some Other Race", Order = 121)]
        public System.Nullable<System.Int32> P0110046 { get; set; }

        [ReadOnly(false)]
        [Column("P0110047", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 122)]
        public System.Nullable<System.Int32> P0110047 { get; set; }

        [ReadOnly(false)]
        [Column("P0110048", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 123)]
        public System.Nullable<System.Int32> P0110048 { get; set; }

        [ReadOnly(false)]
        [Column("P0110049", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of four races:", ShortName = "Population of four races:", Order = 124)]
        public System.Nullable<System.Int32> P0110049 { get; set; }

        [ReadOnly(false)]
        [Column("P0110050", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian", Order = 125)]
        public System.Nullable<System.Int32> P0110050 { get; set; }

        [ReadOnly(false)]
        [Column("P0110051", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander", Order = 126)]
        public System.Nullable<System.Int32> P0110051 { get; set; }

        [ReadOnly(false)]
        [Column("P0110052", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Some Other Race", Order = 127)]
        public System.Nullable<System.Int32> P0110052 { get; set; }

        [ReadOnly(false)]
        [Column("P0110053", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander", Order = 128)]
        public System.Nullable<System.Int32> P0110053 { get; set; }

        [ReadOnly(false)]
        [Column("P0110054", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian; Some Other Race", ShortName = "White; Black or African American; Asian; Some Other Race", Order = 129)]
        public System.Nullable<System.Int32> P0110054 { get; set; }

        [ReadOnly(false)]
        [Column("P0110055", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 130)]
        public System.Nullable<System.Int32> P0110055 { get; set; }

        [ReadOnly(false)]
        [Column("P0110056", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 131)]
        public System.Nullable<System.Int32> P0110056 { get; set; }

        [ReadOnly(false)]
        [Column("P0110057", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Some Other Race", Order = 132)]
        public System.Nullable<System.Int32> P0110057 { get; set; }

        [ReadOnly(false)]
        [Column("P0110058", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 133)]
        public System.Nullable<System.Int32> P0110058 { get; set; }

        [ReadOnly(false)]
        [Column("P0110059", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 134)]
        public System.Nullable<System.Int32> P0110059 { get; set; }

        [ReadOnly(false)]
        [Column("P0110060", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 135)]
        public System.Nullable<System.Int32> P0110060 { get; set; }

        [ReadOnly(false)]
        [Column("P0110061", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 136)]
        public System.Nullable<System.Int32> P0110061 { get; set; }

        [ReadOnly(false)]
        [Column("P0110062", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 137)]
        public System.Nullable<System.Int32> P0110062 { get; set; }

        [ReadOnly(false)]
        [Column("P0110063", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 138)]
        public System.Nullable<System.Int32> P0110063 { get; set; }

        [ReadOnly(false)]
        [Column("P0110064", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 139)]
        public System.Nullable<System.Int32> P0110064 { get; set; }

        [ReadOnly(false)]
        [Column("P0110065", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of five races:", ShortName = "Population of five races:", Order = 140)]
        public System.Nullable<System.Int32> P0110065 { get; set; }

        [ReadOnly(false)]
        [Column("P0110066", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander", Order = 141)]
        public System.Nullable<System.Int32> P0110066 { get; set; }

        [ReadOnly(false)]
        [Column("P0110067", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Some Other Race", Order = 142)]
        public System.Nullable<System.Int32> P0110067 { get; set; }

        [ReadOnly(false)]
        [Column("P0110068", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 143)]
        public System.Nullable<System.Int32> P0110068 { get; set; }

        [ReadOnly(false)]
        [Column("P0110069", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 144)]
        public System.Nullable<System.Int32> P0110069 { get; set; }

        [ReadOnly(false)]
        [Column("P0110070", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 145)]
        public System.Nullable<System.Int32> P0110070 { get; set; }

        [ReadOnly(false)]
        [Column("P0110071", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 146)]
        public System.Nullable<System.Int32> P0110071 { get; set; }

        [ReadOnly(false)]
        [Column("P0110072", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Population of six races:", ShortName = "Population of six races:", Order = 147)]
        public System.Nullable<System.Int32> P0110072 { get; set; }

        [ReadOnly(false)]
        [Column("P0110073", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", ShortName = "White; Black or African American; American Indian and Alaska Native; Asian; Native Hawaiian and Other Pacific Islander; Some Other Race", Order = 148)]
        public System.Nullable<System.Int32> P0110073 { get; set; }

        [ReadOnly(false)]
        [Column("P0120001", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 149)]
        public System.Nullable<System.Int32> P0120001 { get; set; }

        [ReadOnly(false)]
        [Column("P0120002", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 150)]
        public System.Nullable<System.Int32> P0120002 { get; set; }

        [ReadOnly(false)]
        [Column("P0120003", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 151)]
        public System.Nullable<System.Int32> P0120003 { get; set; }

        [ReadOnly(false)]
        [Column("P0120004", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 152)]
        public System.Nullable<System.Int32> P0120004 { get; set; }

        [ReadOnly(false)]
        [Column("P0120005", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 153)]
        public System.Nullable<System.Int32> P0120005 { get; set; }

        [ReadOnly(false)]
        [Column("P0120006", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 154)]
        public System.Nullable<System.Int32> P0120006 { get; set; }

        [ReadOnly(false)]
        [Column("P0120007", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 155)]
        public System.Nullable<System.Int32> P0120007 { get; set; }

        [ReadOnly(false)]
        [Column("P0120008", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 156)]
        public System.Nullable<System.Int32> P0120008 { get; set; }

        [ReadOnly(false)]
        [Column("P0120009", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 157)]
        public System.Nullable<System.Int32> P0120009 { get; set; }

        [ReadOnly(false)]
        [Column("P0120010", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 158)]
        public System.Nullable<System.Int32> P0120010 { get; set; }

        [ReadOnly(false)]
        [Column("P0120011", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 159)]
        public System.Nullable<System.Int32> P0120011 { get; set; }

        [ReadOnly(false)]
        [Column("P0120012", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 160)]
        public System.Nullable<System.Int32> P0120012 { get; set; }

        [ReadOnly(false)]
        [Column("P0120013", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 161)]
        public System.Nullable<System.Int32> P0120013 { get; set; }

        [ReadOnly(false)]
        [Column("P0120014", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 162)]
        public System.Nullable<System.Int32> P0120014 { get; set; }

        [ReadOnly(false)]
        [Column("P0120015", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 163)]
        public System.Nullable<System.Int32> P0120015 { get; set; }

        [ReadOnly(false)]
        [Column("P0120016", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 164)]
        public System.Nullable<System.Int32> P0120016 { get; set; }

        [ReadOnly(false)]
        [Column("P0120017", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 165)]
        public System.Nullable<System.Int32> P0120017 { get; set; }

        [ReadOnly(false)]
        [Column("P0120018", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 166)]
        public System.Nullable<System.Int32> P0120018 { get; set; }

        [ReadOnly(false)]
        [Column("P0120019", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 167)]
        public System.Nullable<System.Int32> P0120019 { get; set; }

        [ReadOnly(false)]
        [Column("P0120020", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 168)]
        public System.Nullable<System.Int32> P0120020 { get; set; }

        [ReadOnly(false)]
        [Column("P0120021", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 169)]
        public System.Nullable<System.Int32> P0120021 { get; set; }

        [ReadOnly(false)]
        [Column("P0120022", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 170)]
        public System.Nullable<System.Int32> P0120022 { get; set; }

        [ReadOnly(false)]
        [Column("P0120023", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 171)]
        public System.Nullable<System.Int32> P0120023 { get; set; }

        [ReadOnly(false)]
        [Column("P0120024", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 172)]
        public System.Nullable<System.Int32> P0120024 { get; set; }

        [ReadOnly(false)]
        [Column("P0120025", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 173)]
        public System.Nullable<System.Int32> P0120025 { get; set; }

        [ReadOnly(false)]
        [Column("P0120026", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 174)]
        public System.Nullable<System.Int32> P0120026 { get; set; }

        [ReadOnly(false)]
        [Column("P0120027", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 175)]
        public System.Nullable<System.Int32> P0120027 { get; set; }

        [ReadOnly(false)]
        [Column("P0120028", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 176)]
        public System.Nullable<System.Int32> P0120028 { get; set; }

        [ReadOnly(false)]
        [Column("P0120029", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 177)]
        public System.Nullable<System.Int32> P0120029 { get; set; }

        [ReadOnly(false)]
        [Column("P0120030", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 178)]
        public System.Nullable<System.Int32> P0120030 { get; set; }

        [ReadOnly(false)]
        [Column("P0120031", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 179)]
        public System.Nullable<System.Int32> P0120031 { get; set; }

        [ReadOnly(false)]
        [Column("P0120032", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 180)]
        public System.Nullable<System.Int32> P0120032 { get; set; }

        [ReadOnly(false)]
        [Column("P0120033", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 181)]
        public System.Nullable<System.Int32> P0120033 { get; set; }

        [ReadOnly(false)]
        [Column("P0120034", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 182)]
        public System.Nullable<System.Int32> P0120034 { get; set; }

        [ReadOnly(false)]
        [Column("P0120035", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 183)]
        public System.Nullable<System.Int32> P0120035 { get; set; }

        [ReadOnly(false)]
        [Column("P0120036", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 184)]
        public System.Nullable<System.Int32> P0120036 { get; set; }

        [ReadOnly(false)]
        [Column("P0120037", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 185)]
        public System.Nullable<System.Int32> P0120037 { get; set; }

        [ReadOnly(false)]
        [Column("P0120038", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 186)]
        public System.Nullable<System.Int32> P0120038 { get; set; }

        [ReadOnly(false)]
        [Column("P0120039", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 187)]
        public System.Nullable<System.Int32> P0120039 { get; set; }

        [ReadOnly(false)]
        [Column("P0120040", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 188)]
        public System.Nullable<System.Int32> P0120040 { get; set; }

        [ReadOnly(false)]
        [Column("P0120041", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 189)]
        public System.Nullable<System.Int32> P0120041 { get; set; }

        [ReadOnly(false)]
        [Column("P0120042", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 190)]
        public System.Nullable<System.Int32> P0120042 { get; set; }

        [ReadOnly(false)]
        [Column("P0120043", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 191)]
        public System.Nullable<System.Int32> P0120043 { get; set; }

        [ReadOnly(false)]
        [Column("P0120044", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 192)]
        public System.Nullable<System.Int32> P0120044 { get; set; }

        [ReadOnly(false)]
        [Column("P0120045", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 193)]
        public System.Nullable<System.Int32> P0120045 { get; set; }

        [ReadOnly(false)]
        [Column("P0120046", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 194)]
        public System.Nullable<System.Int32> P0120046 { get; set; }

        [ReadOnly(false)]
        [Column("P0120047", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 195)]
        public System.Nullable<System.Int32> P0120047 { get; set; }

        [ReadOnly(false)]
        [Column("P0120048", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 196)]
        public System.Nullable<System.Int32> P0120048 { get; set; }

        [ReadOnly(false)]
        [Column("P0120049", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 197)]
        public System.Nullable<System.Int32> P0120049 { get; set; }

        [ReadOnly(false)]
        [Column("P0130001", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Both sexes", ShortName = "Both sexes", Order = 198)]
        public System.Nullable<System.Double> P0130001 { get; set; }

        [ReadOnly(false)]
        [Column("P0130002", Order = 199)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 199)]
        public System.Nullable<System.Double> P0130002 { get; set; }

        [ReadOnly(false)]
        [Column("P0130003", Order = 200)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 200)]
        public System.Nullable<System.Double> P0130003 { get; set; }

        [ReadOnly(false)]
        [Column("P0140001", Order = 201)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 201)]
        public System.Nullable<System.Int32> P0140001 { get; set; }

        [ReadOnly(false)]
        [Column("P0140002", Order = 202)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 202)]
        public System.Nullable<System.Int32> P0140002 { get; set; }

        [ReadOnly(false)]
        [Column("P0140003", Order = 203)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 1 year", ShortName = "Under 1 year", Order = 203)]
        public System.Nullable<System.Int32> P0140003 { get; set; }

        [ReadOnly(false)]
        [Column("P0140004", Order = 204)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1 year", ShortName = "1 year", Order = 204)]
        public System.Nullable<System.Int32> P0140004 { get; set; }

        [ReadOnly(false)]
        [Column("P0140005", Order = 205)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2 years", ShortName = "2 years", Order = 205)]
        public System.Nullable<System.Int32> P0140005 { get; set; }

        [ReadOnly(false)]
        [Column("P0140006", Order = 206)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 years", ShortName = "3 years", Order = 206)]
        public System.Nullable<System.Int32> P0140006 { get; set; }

        [ReadOnly(false)]
        [Column("P0140007", Order = 207)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4 years", ShortName = "4 years", Order = 207)]
        public System.Nullable<System.Int32> P0140007 { get; set; }

        [ReadOnly(false)]
        [Column("P0140008", Order = 208)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 208)]
        public System.Nullable<System.Int32> P0140008 { get; set; }

        [ReadOnly(false)]
        [Column("P0140009", Order = 209)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 years", ShortName = "6 years", Order = 209)]
        public System.Nullable<System.Int32> P0140009 { get; set; }

        [ReadOnly(false)]
        [Column("P0140010", Order = 210)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7 years", ShortName = "7 years", Order = 210)]
        public System.Nullable<System.Int32> P0140010 { get; set; }

        [ReadOnly(false)]
        [Column("P0140011", Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "8 years", ShortName = "8 years", Order = 211)]
        public System.Nullable<System.Int32> P0140011 { get; set; }

        [ReadOnly(false)]
        [Column("P0140012", Order = 212)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "9 years", ShortName = "9 years", Order = 212)]
        public System.Nullable<System.Int32> P0140012 { get; set; }

        [ReadOnly(false)]
        [Column("P0140013", Order = 213)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 years", ShortName = "10 years", Order = 213)]
        public System.Nullable<System.Int32> P0140013 { get; set; }

        [ReadOnly(false)]
        [Column("P0140014", Order = 214)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "11 years", ShortName = "11 years", Order = 214)]
        public System.Nullable<System.Int32> P0140014 { get; set; }

        [ReadOnly(false)]
        [Column("P0140015", Order = 215)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 years", ShortName = "12 years", Order = 215)]
        public System.Nullable<System.Int32> P0140015 { get; set; }

        [ReadOnly(false)]
        [Column("P0140016", Order = 216)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "13 years", ShortName = "13 years", Order = 216)]
        public System.Nullable<System.Int32> P0140016 { get; set; }

        [ReadOnly(false)]
        [Column("P0140017", Order = 217)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "14 years", ShortName = "14 years", Order = 217)]
        public System.Nullable<System.Int32> P0140017 { get; set; }

        [ReadOnly(false)]
        [Column("P0140018", Order = 218)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 years", ShortName = "15 years", Order = 218)]
        public System.Nullable<System.Int32> P0140018 { get; set; }

        [ReadOnly(false)]
        [Column("P0140019", Order = 219)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "16 years", ShortName = "16 years", Order = 219)]
        public System.Nullable<System.Int32> P0140019 { get; set; }

        [ReadOnly(false)]
        [Column("P0140020", Order = 220)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "17 years", ShortName = "17 years", Order = 220)]
        public System.Nullable<System.Int32> P0140020 { get; set; }

        [ReadOnly(false)]
        [Column("P0140021", Order = 221)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years", ShortName = "18 years", Order = 221)]
        public System.Nullable<System.Int32> P0140021 { get; set; }

        [ReadOnly(false)]
        [Column("P0140022", Order = 222)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "19 years", ShortName = "19 years", Order = 222)]
        public System.Nullable<System.Int32> P0140022 { get; set; }

        [ReadOnly(false)]
        [Column("P0140023", Order = 223)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 223)]
        public System.Nullable<System.Int32> P0140023 { get; set; }

        [ReadOnly(false)]
        [Column("P0140024", Order = 224)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 1 year", ShortName = "Under 1 year", Order = 224)]
        public System.Nullable<System.Int32> P0140024 { get; set; }

        [ReadOnly(false)]
        [Column("P0140025", Order = 225)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1 year", ShortName = "1 year", Order = 225)]
        public System.Nullable<System.Int32> P0140025 { get; set; }

        [ReadOnly(false)]
        [Column("P0140026", Order = 226)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2 years", ShortName = "2 years", Order = 226)]
        public System.Nullable<System.Int32> P0140026 { get; set; }

        [ReadOnly(false)]
        [Column("P0140027", Order = 227)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 years", ShortName = "3 years", Order = 227)]
        public System.Nullable<System.Int32> P0140027 { get; set; }

        [ReadOnly(false)]
        [Column("P0140028", Order = 228)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4 years", ShortName = "4 years", Order = 228)]
        public System.Nullable<System.Int32> P0140028 { get; set; }

        [ReadOnly(false)]
        [Column("P0140029", Order = 229)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 229)]
        public System.Nullable<System.Int32> P0140029 { get; set; }

        [ReadOnly(false)]
        [Column("P0140030", Order = 230)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 years", ShortName = "6 years", Order = 230)]
        public System.Nullable<System.Int32> P0140030 { get; set; }

        [ReadOnly(false)]
        [Column("P0140031", Order = 231)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7 years", ShortName = "7 years", Order = 231)]
        public System.Nullable<System.Int32> P0140031 { get; set; }

        [ReadOnly(false)]
        [Column("P0140032", Order = 232)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "8 years", ShortName = "8 years", Order = 232)]
        public System.Nullable<System.Int32> P0140032 { get; set; }

        [ReadOnly(false)]
        [Column("P0140033", Order = 233)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "9 years", ShortName = "9 years", Order = 233)]
        public System.Nullable<System.Int32> P0140033 { get; set; }

        [ReadOnly(false)]
        [Column("P0140034", Order = 234)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 years", ShortName = "10 years", Order = 234)]
        public System.Nullable<System.Int32> P0140034 { get; set; }

        [ReadOnly(false)]
        [Column("P0140035", Order = 235)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "11 years", ShortName = "11 years", Order = 235)]
        public System.Nullable<System.Int32> P0140035 { get; set; }

        [ReadOnly(false)]
        [Column("P0140036", Order = 236)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 years", ShortName = "12 years", Order = 236)]
        public System.Nullable<System.Int32> P0140036 { get; set; }

        [ReadOnly(false)]
        [Column("P0140037", Order = 237)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "13 years", ShortName = "13 years", Order = 237)]
        public System.Nullable<System.Int32> P0140037 { get; set; }

        [ReadOnly(false)]
        [Column("P0140038", Order = 238)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "14 years", ShortName = "14 years", Order = 238)]
        public System.Nullable<System.Int32> P0140038 { get; set; }

        [ReadOnly(false)]
        [Column("P0140039", Order = 239)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 years", ShortName = "15 years", Order = 239)]
        public System.Nullable<System.Int32> P0140039 { get; set; }

        [ReadOnly(false)]
        [Column("P0140040", Order = 240)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "16 years", ShortName = "16 years", Order = 240)]
        public System.Nullable<System.Int32> P0140040 { get; set; }

        [ReadOnly(false)]
        [Column("P0140041", Order = 241)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "17 years", ShortName = "17 years", Order = 241)]
        public System.Nullable<System.Int32> P0140041 { get; set; }

        [ReadOnly(false)]
        [Column("P0140042", Order = 242)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years", ShortName = "18 years", Order = 242)]
        public System.Nullable<System.Int32> P0140042 { get; set; }

        [ReadOnly(false)]
        [Column("P0140043", Order = 243)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "19 years", ShortName = "19 years", Order = 243)]
        public System.Nullable<System.Int32> P0140043 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1_00004(string csvLine) : base(csvLine) {}

        public SF1_00004(string[] values) : base(values) {}

        public SF1_00004(OleDbDataReader reader, CensusFileType fileType)
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
                P0100001 = (System.Nullable<System.Int32>)reader[5];
            }
            if(reader[6] != DBNull.Value)
            {
                P0100002 = (System.Nullable<System.Int32>)reader[6];
            }
            if(reader[7] != DBNull.Value)
            {
                P0100003 = (System.Nullable<System.Int32>)reader[7];
            }
            if(reader[8] != DBNull.Value)
            {
                P0100004 = (System.Nullable<System.Int32>)reader[8];
            }
            if(reader[9] != DBNull.Value)
            {
                P0100005 = (System.Nullable<System.Int32>)reader[9];
            }
            if(reader[10] != DBNull.Value)
            {
                P0100006 = (System.Nullable<System.Int32>)reader[10];
            }
            if(reader[11] != DBNull.Value)
            {
                P0100007 = (System.Nullable<System.Int32>)reader[11];
            }
            if(reader[12] != DBNull.Value)
            {
                P0100008 = (System.Nullable<System.Int32>)reader[12];
            }
            if(reader[13] != DBNull.Value)
            {
                P0100009 = (System.Nullable<System.Int32>)reader[13];
            }
            if(reader[14] != DBNull.Value)
            {
                P0100010 = (System.Nullable<System.Int32>)reader[14];
            }
            if(reader[15] != DBNull.Value)
            {
                P0100011 = (System.Nullable<System.Int32>)reader[15];
            }
            if(reader[16] != DBNull.Value)
            {
                P0100012 = (System.Nullable<System.Int32>)reader[16];
            }
            if(reader[17] != DBNull.Value)
            {
                P0100013 = (System.Nullable<System.Int32>)reader[17];
            }
            if(reader[18] != DBNull.Value)
            {
                P0100014 = (System.Nullable<System.Int32>)reader[18];
            }
            if(reader[19] != DBNull.Value)
            {
                P0100015 = (System.Nullable<System.Int32>)reader[19];
            }
            if(reader[20] != DBNull.Value)
            {
                P0100016 = (System.Nullable<System.Int32>)reader[20];
            }
            if(reader[21] != DBNull.Value)
            {
                P0100017 = (System.Nullable<System.Int32>)reader[21];
            }
            if(reader[22] != DBNull.Value)
            {
                P0100018 = (System.Nullable<System.Int32>)reader[22];
            }
            if(reader[23] != DBNull.Value)
            {
                P0100019 = (System.Nullable<System.Int32>)reader[23];
            }
            if(reader[24] != DBNull.Value)
            {
                P0100020 = (System.Nullable<System.Int32>)reader[24];
            }
            if(reader[25] != DBNull.Value)
            {
                P0100021 = (System.Nullable<System.Int32>)reader[25];
            }
            if(reader[26] != DBNull.Value)
            {
                P0100022 = (System.Nullable<System.Int32>)reader[26];
            }
            if(reader[27] != DBNull.Value)
            {
                P0100023 = (System.Nullable<System.Int32>)reader[27];
            }
            if(reader[28] != DBNull.Value)
            {
                P0100024 = (System.Nullable<System.Int32>)reader[28];
            }
            if(reader[29] != DBNull.Value)
            {
                P0100025 = (System.Nullable<System.Int32>)reader[29];
            }
            if(reader[30] != DBNull.Value)
            {
                P0100026 = (System.Nullable<System.Int32>)reader[30];
            }
            if(reader[31] != DBNull.Value)
            {
                P0100027 = (System.Nullable<System.Int32>)reader[31];
            }
            if(reader[32] != DBNull.Value)
            {
                P0100028 = (System.Nullable<System.Int32>)reader[32];
            }
            if(reader[33] != DBNull.Value)
            {
                P0100029 = (System.Nullable<System.Int32>)reader[33];
            }
            if(reader[34] != DBNull.Value)
            {
                P0100030 = (System.Nullable<System.Int32>)reader[34];
            }
            if(reader[35] != DBNull.Value)
            {
                P0100031 = (System.Nullable<System.Int32>)reader[35];
            }
            if(reader[36] != DBNull.Value)
            {
                P0100032 = (System.Nullable<System.Int32>)reader[36];
            }
            if(reader[37] != DBNull.Value)
            {
                P0100033 = (System.Nullable<System.Int32>)reader[37];
            }
            if(reader[38] != DBNull.Value)
            {
                P0100034 = (System.Nullable<System.Int32>)reader[38];
            }
            if(reader[39] != DBNull.Value)
            {
                P0100035 = (System.Nullable<System.Int32>)reader[39];
            }
            if(reader[40] != DBNull.Value)
            {
                P0100036 = (System.Nullable<System.Int32>)reader[40];
            }
            if(reader[41] != DBNull.Value)
            {
                P0100037 = (System.Nullable<System.Int32>)reader[41];
            }
            if(reader[42] != DBNull.Value)
            {
                P0100038 = (System.Nullable<System.Int32>)reader[42];
            }
            if(reader[43] != DBNull.Value)
            {
                P0100039 = (System.Nullable<System.Int32>)reader[43];
            }
            if(reader[44] != DBNull.Value)
            {
                P0100040 = (System.Nullable<System.Int32>)reader[44];
            }
            if(reader[45] != DBNull.Value)
            {
                P0100041 = (System.Nullable<System.Int32>)reader[45];
            }
            if(reader[46] != DBNull.Value)
            {
                P0100042 = (System.Nullable<System.Int32>)reader[46];
            }
            if(reader[47] != DBNull.Value)
            {
                P0100043 = (System.Nullable<System.Int32>)reader[47];
            }
            if(reader[48] != DBNull.Value)
            {
                P0100044 = (System.Nullable<System.Int32>)reader[48];
            }
            if(reader[49] != DBNull.Value)
            {
                P0100045 = (System.Nullable<System.Int32>)reader[49];
            }
            if(reader[50] != DBNull.Value)
            {
                P0100046 = (System.Nullable<System.Int32>)reader[50];
            }
            if(reader[51] != DBNull.Value)
            {
                P0100047 = (System.Nullable<System.Int32>)reader[51];
            }
            if(reader[52] != DBNull.Value)
            {
                P0100048 = (System.Nullable<System.Int32>)reader[52];
            }
            if(reader[53] != DBNull.Value)
            {
                P0100049 = (System.Nullable<System.Int32>)reader[53];
            }
            if(reader[54] != DBNull.Value)
            {
                P0100050 = (System.Nullable<System.Int32>)reader[54];
            }
            if(reader[55] != DBNull.Value)
            {
                P0100051 = (System.Nullable<System.Int32>)reader[55];
            }
            if(reader[56] != DBNull.Value)
            {
                P0100052 = (System.Nullable<System.Int32>)reader[56];
            }
            if(reader[57] != DBNull.Value)
            {
                P0100053 = (System.Nullable<System.Int32>)reader[57];
            }
            if(reader[58] != DBNull.Value)
            {
                P0100054 = (System.Nullable<System.Int32>)reader[58];
            }
            if(reader[59] != DBNull.Value)
            {
                P0100055 = (System.Nullable<System.Int32>)reader[59];
            }
            if(reader[60] != DBNull.Value)
            {
                P0100056 = (System.Nullable<System.Int32>)reader[60];
            }
            if(reader[61] != DBNull.Value)
            {
                P0100057 = (System.Nullable<System.Int32>)reader[61];
            }
            if(reader[62] != DBNull.Value)
            {
                P0100058 = (System.Nullable<System.Int32>)reader[62];
            }
            if(reader[63] != DBNull.Value)
            {
                P0100059 = (System.Nullable<System.Int32>)reader[63];
            }
            if(reader[64] != DBNull.Value)
            {
                P0100060 = (System.Nullable<System.Int32>)reader[64];
            }
            if(reader[65] != DBNull.Value)
            {
                P0100061 = (System.Nullable<System.Int32>)reader[65];
            }
            if(reader[66] != DBNull.Value)
            {
                P0100062 = (System.Nullable<System.Int32>)reader[66];
            }
            if(reader[67] != DBNull.Value)
            {
                P0100063 = (System.Nullable<System.Int32>)reader[67];
            }
            if(reader[68] != DBNull.Value)
            {
                P0100064 = (System.Nullable<System.Int32>)reader[68];
            }
            if(reader[69] != DBNull.Value)
            {
                P0100065 = (System.Nullable<System.Int32>)reader[69];
            }
            if(reader[70] != DBNull.Value)
            {
                P0100066 = (System.Nullable<System.Int32>)reader[70];
            }
            if(reader[71] != DBNull.Value)
            {
                P0100067 = (System.Nullable<System.Int32>)reader[71];
            }
            if(reader[72] != DBNull.Value)
            {
                P0100068 = (System.Nullable<System.Int32>)reader[72];
            }
            if(reader[73] != DBNull.Value)
            {
                P0100069 = (System.Nullable<System.Int32>)reader[73];
            }
            if(reader[74] != DBNull.Value)
            {
                P0100070 = (System.Nullable<System.Int32>)reader[74];
            }
            if(reader[75] != DBNull.Value)
            {
                P0100071 = (System.Nullable<System.Int32>)reader[75];
            }
            if(reader[76] != DBNull.Value)
            {
                P0110001 = (System.Nullable<System.Int32>)reader[76];
            }
            if(reader[77] != DBNull.Value)
            {
                P0110002 = (System.Nullable<System.Int32>)reader[77];
            }
            if(reader[78] != DBNull.Value)
            {
                P0110003 = (System.Nullable<System.Int32>)reader[78];
            }
            if(reader[79] != DBNull.Value)
            {
                P0110004 = (System.Nullable<System.Int32>)reader[79];
            }
            if(reader[80] != DBNull.Value)
            {
                P0110005 = (System.Nullable<System.Int32>)reader[80];
            }
            if(reader[81] != DBNull.Value)
            {
                P0110006 = (System.Nullable<System.Int32>)reader[81];
            }
            if(reader[82] != DBNull.Value)
            {
                P0110007 = (System.Nullable<System.Int32>)reader[82];
            }
            if(reader[83] != DBNull.Value)
            {
                P0110008 = (System.Nullable<System.Int32>)reader[83];
            }
            if(reader[84] != DBNull.Value)
            {
                P0110009 = (System.Nullable<System.Int32>)reader[84];
            }
            if(reader[85] != DBNull.Value)
            {
                P0110010 = (System.Nullable<System.Int32>)reader[85];
            }
            if(reader[86] != DBNull.Value)
            {
                P0110011 = (System.Nullable<System.Int32>)reader[86];
            }
            if(reader[87] != DBNull.Value)
            {
                P0110012 = (System.Nullable<System.Int32>)reader[87];
            }
            if(reader[88] != DBNull.Value)
            {
                P0110013 = (System.Nullable<System.Int32>)reader[88];
            }
            if(reader[89] != DBNull.Value)
            {
                P0110014 = (System.Nullable<System.Int32>)reader[89];
            }
            if(reader[90] != DBNull.Value)
            {
                P0110015 = (System.Nullable<System.Int32>)reader[90];
            }
            if(reader[91] != DBNull.Value)
            {
                P0110016 = (System.Nullable<System.Int32>)reader[91];
            }
            if(reader[92] != DBNull.Value)
            {
                P0110017 = (System.Nullable<System.Int32>)reader[92];
            }
            if(reader[93] != DBNull.Value)
            {
                P0110018 = (System.Nullable<System.Int32>)reader[93];
            }
            if(reader[94] != DBNull.Value)
            {
                P0110019 = (System.Nullable<System.Int32>)reader[94];
            }
            if(reader[95] != DBNull.Value)
            {
                P0110020 = (System.Nullable<System.Int32>)reader[95];
            }
            if(reader[96] != DBNull.Value)
            {
                P0110021 = (System.Nullable<System.Int32>)reader[96];
            }
            if(reader[97] != DBNull.Value)
            {
                P0110022 = (System.Nullable<System.Int32>)reader[97];
            }
            if(reader[98] != DBNull.Value)
            {
                P0110023 = (System.Nullable<System.Int32>)reader[98];
            }
            if(reader[99] != DBNull.Value)
            {
                P0110024 = (System.Nullable<System.Int32>)reader[99];
            }
            if(reader[100] != DBNull.Value)
            {
                P0110025 = (System.Nullable<System.Int32>)reader[100];
            }
            if(reader[101] != DBNull.Value)
            {
                P0110026 = (System.Nullable<System.Int32>)reader[101];
            }
            if(reader[102] != DBNull.Value)
            {
                P0110027 = (System.Nullable<System.Int32>)reader[102];
            }
            if(reader[103] != DBNull.Value)
            {
                P0110028 = (System.Nullable<System.Int32>)reader[103];
            }
            if(reader[104] != DBNull.Value)
            {
                P0110029 = (System.Nullable<System.Int32>)reader[104];
            }
            if(reader[105] != DBNull.Value)
            {
                P0110030 = (System.Nullable<System.Int32>)reader[105];
            }
            if(reader[106] != DBNull.Value)
            {
                P0110031 = (System.Nullable<System.Int32>)reader[106];
            }
            if(reader[107] != DBNull.Value)
            {
                P0110032 = (System.Nullable<System.Int32>)reader[107];
            }
            if(reader[108] != DBNull.Value)
            {
                P0110033 = (System.Nullable<System.Int32>)reader[108];
            }
            if(reader[109] != DBNull.Value)
            {
                P0110034 = (System.Nullable<System.Int32>)reader[109];
            }
            if(reader[110] != DBNull.Value)
            {
                P0110035 = (System.Nullable<System.Int32>)reader[110];
            }
            if(reader[111] != DBNull.Value)
            {
                P0110036 = (System.Nullable<System.Int32>)reader[111];
            }
            if(reader[112] != DBNull.Value)
            {
                P0110037 = (System.Nullable<System.Int32>)reader[112];
            }
            if(reader[113] != DBNull.Value)
            {
                P0110038 = (System.Nullable<System.Int32>)reader[113];
            }
            if(reader[114] != DBNull.Value)
            {
                P0110039 = (System.Nullable<System.Int32>)reader[114];
            }
            if(reader[115] != DBNull.Value)
            {
                P0110040 = (System.Nullable<System.Int32>)reader[115];
            }
            if(reader[116] != DBNull.Value)
            {
                P0110041 = (System.Nullable<System.Int32>)reader[116];
            }
            if(reader[117] != DBNull.Value)
            {
                P0110042 = (System.Nullable<System.Int32>)reader[117];
            }
            if(reader[118] != DBNull.Value)
            {
                P0110043 = (System.Nullable<System.Int32>)reader[118];
            }
            if(reader[119] != DBNull.Value)
            {
                P0110044 = (System.Nullable<System.Int32>)reader[119];
            }
            if(reader[120] != DBNull.Value)
            {
                P0110045 = (System.Nullable<System.Int32>)reader[120];
            }
            if(reader[121] != DBNull.Value)
            {
                P0110046 = (System.Nullable<System.Int32>)reader[121];
            }
            if(reader[122] != DBNull.Value)
            {
                P0110047 = (System.Nullable<System.Int32>)reader[122];
            }
            if(reader[123] != DBNull.Value)
            {
                P0110048 = (System.Nullable<System.Int32>)reader[123];
            }
            if(reader[124] != DBNull.Value)
            {
                P0110049 = (System.Nullable<System.Int32>)reader[124];
            }
            if(reader[125] != DBNull.Value)
            {
                P0110050 = (System.Nullable<System.Int32>)reader[125];
            }
            if(reader[126] != DBNull.Value)
            {
                P0110051 = (System.Nullable<System.Int32>)reader[126];
            }
            if(reader[127] != DBNull.Value)
            {
                P0110052 = (System.Nullable<System.Int32>)reader[127];
            }
            if(reader[128] != DBNull.Value)
            {
                P0110053 = (System.Nullable<System.Int32>)reader[128];
            }
            if(reader[129] != DBNull.Value)
            {
                P0110054 = (System.Nullable<System.Int32>)reader[129];
            }
            if(reader[130] != DBNull.Value)
            {
                P0110055 = (System.Nullable<System.Int32>)reader[130];
            }
            if(reader[131] != DBNull.Value)
            {
                P0110056 = (System.Nullable<System.Int32>)reader[131];
            }
            if(reader[132] != DBNull.Value)
            {
                P0110057 = (System.Nullable<System.Int32>)reader[132];
            }
            if(reader[133] != DBNull.Value)
            {
                P0110058 = (System.Nullable<System.Int32>)reader[133];
            }
            if(reader[134] != DBNull.Value)
            {
                P0110059 = (System.Nullable<System.Int32>)reader[134];
            }
            if(reader[135] != DBNull.Value)
            {
                P0110060 = (System.Nullable<System.Int32>)reader[135];
            }
            if(reader[136] != DBNull.Value)
            {
                P0110061 = (System.Nullable<System.Int32>)reader[136];
            }
            if(reader[137] != DBNull.Value)
            {
                P0110062 = (System.Nullable<System.Int32>)reader[137];
            }
            if(reader[138] != DBNull.Value)
            {
                P0110063 = (System.Nullable<System.Int32>)reader[138];
            }
            if(reader[139] != DBNull.Value)
            {
                P0110064 = (System.Nullable<System.Int32>)reader[139];
            }
            if(reader[140] != DBNull.Value)
            {
                P0110065 = (System.Nullable<System.Int32>)reader[140];
            }
            if(reader[141] != DBNull.Value)
            {
                P0110066 = (System.Nullable<System.Int32>)reader[141];
            }
            if(reader[142] != DBNull.Value)
            {
                P0110067 = (System.Nullable<System.Int32>)reader[142];
            }
            if(reader[143] != DBNull.Value)
            {
                P0110068 = (System.Nullable<System.Int32>)reader[143];
            }
            if(reader[144] != DBNull.Value)
            {
                P0110069 = (System.Nullable<System.Int32>)reader[144];
            }
            if(reader[145] != DBNull.Value)
            {
                P0110070 = (System.Nullable<System.Int32>)reader[145];
            }
            if(reader[146] != DBNull.Value)
            {
                P0110071 = (System.Nullable<System.Int32>)reader[146];
            }
            if(reader[147] != DBNull.Value)
            {
                P0110072 = (System.Nullable<System.Int32>)reader[147];
            }
            if(reader[148] != DBNull.Value)
            {
                P0110073 = (System.Nullable<System.Int32>)reader[148];
            }
            if(reader[149] != DBNull.Value)
            {
                P0120001 = (System.Nullable<System.Int32>)reader[149];
            }
            if(reader[150] != DBNull.Value)
            {
                P0120002 = (System.Nullable<System.Int32>)reader[150];
            }
            if(reader[151] != DBNull.Value)
            {
                P0120003 = (System.Nullable<System.Int32>)reader[151];
            }
            if(reader[152] != DBNull.Value)
            {
                P0120004 = (System.Nullable<System.Int32>)reader[152];
            }
            if(reader[153] != DBNull.Value)
            {
                P0120005 = (System.Nullable<System.Int32>)reader[153];
            }
            if(reader[154] != DBNull.Value)
            {
                P0120006 = (System.Nullable<System.Int32>)reader[154];
            }
            if(reader[155] != DBNull.Value)
            {
                P0120007 = (System.Nullable<System.Int32>)reader[155];
            }
            if(reader[156] != DBNull.Value)
            {
                P0120008 = (System.Nullable<System.Int32>)reader[156];
            }
            if(reader[157] != DBNull.Value)
            {
                P0120009 = (System.Nullable<System.Int32>)reader[157];
            }
            if(reader[158] != DBNull.Value)
            {
                P0120010 = (System.Nullable<System.Int32>)reader[158];
            }
            if(reader[159] != DBNull.Value)
            {
                P0120011 = (System.Nullable<System.Int32>)reader[159];
            }
            if(reader[160] != DBNull.Value)
            {
                P0120012 = (System.Nullable<System.Int32>)reader[160];
            }
            if(reader[161] != DBNull.Value)
            {
                P0120013 = (System.Nullable<System.Int32>)reader[161];
            }
            if(reader[162] != DBNull.Value)
            {
                P0120014 = (System.Nullable<System.Int32>)reader[162];
            }
            if(reader[163] != DBNull.Value)
            {
                P0120015 = (System.Nullable<System.Int32>)reader[163];
            }
            if(reader[164] != DBNull.Value)
            {
                P0120016 = (System.Nullable<System.Int32>)reader[164];
            }
            if(reader[165] != DBNull.Value)
            {
                P0120017 = (System.Nullable<System.Int32>)reader[165];
            }
            if(reader[166] != DBNull.Value)
            {
                P0120018 = (System.Nullable<System.Int32>)reader[166];
            }
            if(reader[167] != DBNull.Value)
            {
                P0120019 = (System.Nullable<System.Int32>)reader[167];
            }
            if(reader[168] != DBNull.Value)
            {
                P0120020 = (System.Nullable<System.Int32>)reader[168];
            }
            if(reader[169] != DBNull.Value)
            {
                P0120021 = (System.Nullable<System.Int32>)reader[169];
            }
            if(reader[170] != DBNull.Value)
            {
                P0120022 = (System.Nullable<System.Int32>)reader[170];
            }
            if(reader[171] != DBNull.Value)
            {
                P0120023 = (System.Nullable<System.Int32>)reader[171];
            }
            if(reader[172] != DBNull.Value)
            {
                P0120024 = (System.Nullable<System.Int32>)reader[172];
            }
            if(reader[173] != DBNull.Value)
            {
                P0120025 = (System.Nullable<System.Int32>)reader[173];
            }
            if(reader[174] != DBNull.Value)
            {
                P0120026 = (System.Nullable<System.Int32>)reader[174];
            }
            if(reader[175] != DBNull.Value)
            {
                P0120027 = (System.Nullable<System.Int32>)reader[175];
            }
            if(reader[176] != DBNull.Value)
            {
                P0120028 = (System.Nullable<System.Int32>)reader[176];
            }
            if(reader[177] != DBNull.Value)
            {
                P0120029 = (System.Nullable<System.Int32>)reader[177];
            }
            if(reader[178] != DBNull.Value)
            {
                P0120030 = (System.Nullable<System.Int32>)reader[178];
            }
            if(reader[179] != DBNull.Value)
            {
                P0120031 = (System.Nullable<System.Int32>)reader[179];
            }
            if(reader[180] != DBNull.Value)
            {
                P0120032 = (System.Nullable<System.Int32>)reader[180];
            }
            if(reader[181] != DBNull.Value)
            {
                P0120033 = (System.Nullable<System.Int32>)reader[181];
            }
            if(reader[182] != DBNull.Value)
            {
                P0120034 = (System.Nullable<System.Int32>)reader[182];
            }
            if(reader[183] != DBNull.Value)
            {
                P0120035 = (System.Nullable<System.Int32>)reader[183];
            }
            if(reader[184] != DBNull.Value)
            {
                P0120036 = (System.Nullable<System.Int32>)reader[184];
            }
            if(reader[185] != DBNull.Value)
            {
                P0120037 = (System.Nullable<System.Int32>)reader[185];
            }
            if(reader[186] != DBNull.Value)
            {
                P0120038 = (System.Nullable<System.Int32>)reader[186];
            }
            if(reader[187] != DBNull.Value)
            {
                P0120039 = (System.Nullable<System.Int32>)reader[187];
            }
            if(reader[188] != DBNull.Value)
            {
                P0120040 = (System.Nullable<System.Int32>)reader[188];
            }
            if(reader[189] != DBNull.Value)
            {
                P0120041 = (System.Nullable<System.Int32>)reader[189];
            }
            if(reader[190] != DBNull.Value)
            {
                P0120042 = (System.Nullable<System.Int32>)reader[190];
            }
            if(reader[191] != DBNull.Value)
            {
                P0120043 = (System.Nullable<System.Int32>)reader[191];
            }
            if(reader[192] != DBNull.Value)
            {
                P0120044 = (System.Nullable<System.Int32>)reader[192];
            }
            if(reader[193] != DBNull.Value)
            {
                P0120045 = (System.Nullable<System.Int32>)reader[193];
            }
            if(reader[194] != DBNull.Value)
            {
                P0120046 = (System.Nullable<System.Int32>)reader[194];
            }
            if(reader[195] != DBNull.Value)
            {
                P0120047 = (System.Nullable<System.Int32>)reader[195];
            }
            if(reader[196] != DBNull.Value)
            {
                P0120048 = (System.Nullable<System.Int32>)reader[196];
            }
            if(reader[197] != DBNull.Value)
            {
                P0120049 = (System.Nullable<System.Int32>)reader[197];
            }
            if(reader[198] != DBNull.Value)
            {
                P0130001 = (System.Nullable<System.Double>)reader[198];
            }
            if(reader[199] != DBNull.Value)
            {
                P0130002 = (System.Nullable<System.Double>)reader[199];
            }
            if(reader[200] != DBNull.Value)
            {
                P0130003 = (System.Nullable<System.Double>)reader[200];
            }
            if(reader[201] != DBNull.Value)
            {
                P0140001 = (System.Nullable<System.Int32>)reader[201];
            }
            if(reader[202] != DBNull.Value)
            {
                P0140002 = (System.Nullable<System.Int32>)reader[202];
            }
            if(reader[203] != DBNull.Value)
            {
                P0140003 = (System.Nullable<System.Int32>)reader[203];
            }
            if(reader[204] != DBNull.Value)
            {
                P0140004 = (System.Nullable<System.Int32>)reader[204];
            }
            if(reader[205] != DBNull.Value)
            {
                P0140005 = (System.Nullable<System.Int32>)reader[205];
            }
            if(reader[206] != DBNull.Value)
            {
                P0140006 = (System.Nullable<System.Int32>)reader[206];
            }
            if(reader[207] != DBNull.Value)
            {
                P0140007 = (System.Nullable<System.Int32>)reader[207];
            }
            if(reader[208] != DBNull.Value)
            {
                P0140008 = (System.Nullable<System.Int32>)reader[208];
            }
            if(reader[209] != DBNull.Value)
            {
                P0140009 = (System.Nullable<System.Int32>)reader[209];
            }
            if(reader[210] != DBNull.Value)
            {
                P0140010 = (System.Nullable<System.Int32>)reader[210];
            }
            if(reader[211] != DBNull.Value)
            {
                P0140011 = (System.Nullable<System.Int32>)reader[211];
            }
            if(reader[212] != DBNull.Value)
            {
                P0140012 = (System.Nullable<System.Int32>)reader[212];
            }
            if(reader[213] != DBNull.Value)
            {
                P0140013 = (System.Nullable<System.Int32>)reader[213];
            }
            if(reader[214] != DBNull.Value)
            {
                P0140014 = (System.Nullable<System.Int32>)reader[214];
            }
            if(reader[215] != DBNull.Value)
            {
                P0140015 = (System.Nullable<System.Int32>)reader[215];
            }
            if(reader[216] != DBNull.Value)
            {
                P0140016 = (System.Nullable<System.Int32>)reader[216];
            }
            if(reader[217] != DBNull.Value)
            {
                P0140017 = (System.Nullable<System.Int32>)reader[217];
            }
            if(reader[218] != DBNull.Value)
            {
                P0140018 = (System.Nullable<System.Int32>)reader[218];
            }
            if(reader[219] != DBNull.Value)
            {
                P0140019 = (System.Nullable<System.Int32>)reader[219];
            }
            if(reader[220] != DBNull.Value)
            {
                P0140020 = (System.Nullable<System.Int32>)reader[220];
            }
            if(reader[221] != DBNull.Value)
            {
                P0140021 = (System.Nullable<System.Int32>)reader[221];
            }
            if(reader[222] != DBNull.Value)
            {
                P0140022 = (System.Nullable<System.Int32>)reader[222];
            }
            if(reader[223] != DBNull.Value)
            {
                P0140023 = (System.Nullable<System.Int32>)reader[223];
            }
            if(reader[224] != DBNull.Value)
            {
                P0140024 = (System.Nullable<System.Int32>)reader[224];
            }
            if(reader[225] != DBNull.Value)
            {
                P0140025 = (System.Nullable<System.Int32>)reader[225];
            }
            if(reader[226] != DBNull.Value)
            {
                P0140026 = (System.Nullable<System.Int32>)reader[226];
            }
            if(reader[227] != DBNull.Value)
            {
                P0140027 = (System.Nullable<System.Int32>)reader[227];
            }
            if(reader[228] != DBNull.Value)
            {
                P0140028 = (System.Nullable<System.Int32>)reader[228];
            }
            if(reader[229] != DBNull.Value)
            {
                P0140029 = (System.Nullable<System.Int32>)reader[229];
            }
            if(reader[230] != DBNull.Value)
            {
                P0140030 = (System.Nullable<System.Int32>)reader[230];
            }
            if(reader[231] != DBNull.Value)
            {
                P0140031 = (System.Nullable<System.Int32>)reader[231];
            }
            if(reader[232] != DBNull.Value)
            {
                P0140032 = (System.Nullable<System.Int32>)reader[232];
            }
            if(reader[233] != DBNull.Value)
            {
                P0140033 = (System.Nullable<System.Int32>)reader[233];
            }
            if(reader[234] != DBNull.Value)
            {
                P0140034 = (System.Nullable<System.Int32>)reader[234];
            }
            if(reader[235] != DBNull.Value)
            {
                P0140035 = (System.Nullable<System.Int32>)reader[235];
            }
            if(reader[236] != DBNull.Value)
            {
                P0140036 = (System.Nullable<System.Int32>)reader[236];
            }
            if(reader[237] != DBNull.Value)
            {
                P0140037 = (System.Nullable<System.Int32>)reader[237];
            }
            if(reader[238] != DBNull.Value)
            {
                P0140038 = (System.Nullable<System.Int32>)reader[238];
            }
            if(reader[239] != DBNull.Value)
            {
                P0140039 = (System.Nullable<System.Int32>)reader[239];
            }
            if(reader[240] != DBNull.Value)
            {
                P0140040 = (System.Nullable<System.Int32>)reader[240];
            }
            if(reader[241] != DBNull.Value)
            {
                P0140041 = (System.Nullable<System.Int32>)reader[241];
            }
            if(reader[242] != DBNull.Value)
            {
                P0140042 = (System.Nullable<System.Int32>)reader[242];
            }
            if(reader[243] != DBNull.Value)
            {
                P0140043 = (System.Nullable<System.Int32>)reader[243];
            }
        }
        #endregion Constructors
    }
}