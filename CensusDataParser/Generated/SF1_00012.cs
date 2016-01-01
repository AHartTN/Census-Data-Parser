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

    [Table("SF1_00012")]
    public partial class SF1_00012 : BaseModel
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
        [Column("P034F001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public System.Nullable<System.Int32> P034F001 { get; set; }

        [ReadOnly(false)]
        [Column("P034F002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 6)]
        public System.Nullable<System.Int32> P034F002 { get; set; }

        [ReadOnly(false)]
        [Column("P034F003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 7)]
        public System.Nullable<System.Int32> P034F003 { get; set; }

        [ReadOnly(false)]
        [Column("P034F004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder:", ShortName = "Householder:", Order = 8)]
        public System.Nullable<System.Int32> P034F004 { get; set; }

        [ReadOnly(false)]
        [Column("P034F005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 9)]
        public System.Nullable<System.Int32> P034F005 { get; set; }

        [ReadOnly(false)]
        [Column("P034F006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 10)]
        public System.Nullable<System.Int32> P034F006 { get; set; }

        [ReadOnly(false)]
        [Column("P034F007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spouse", ShortName = "Spouse", Order = 11)]
        public System.Nullable<System.Int32> P034F007 { get; set; }

        [ReadOnly(false)]
        [Column("P034F008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent", ShortName = "Parent", Order = 12)]
        public System.Nullable<System.Int32> P034F008 { get; set; }

        [ReadOnly(false)]
        [Column("P034F009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 13)]
        public System.Nullable<System.Int32> P034F009 { get; set; }

        [ReadOnly(false)]
        [Column("P034F010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 14)]
        public System.Nullable<System.Int32> P034F010 { get; set; }

        [ReadOnly(false)]
        [Column("P034F011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 15)]
        public System.Nullable<System.Int32> P034F011 { get; set; }

        [ReadOnly(false)]
        [Column("P034F012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 16)]
        public System.Nullable<System.Int32> P034F012 { get; set; }

        [ReadOnly(false)]
        [Column("P034F013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 17)]
        public System.Nullable<System.Int32> P034F013 { get; set; }

        [ReadOnly(false)]
        [Column("P034F014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 18)]
        public System.Nullable<System.Int32> P034F014 { get; set; }

        [ReadOnly(false)]
        [Column("P034F015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 19)]
        public System.Nullable<System.Int32> P034F015 { get; set; }

        [ReadOnly(false)]
        [Column("P034F016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 20)]
        public System.Nullable<System.Int32> P034F016 { get; set; }

        [ReadOnly(false)]
        [Column("P034F017", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 21)]
        public System.Nullable<System.Int32> P034F017 { get; set; }

        [ReadOnly(false)]
        [Column("P034F018", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 22)]
        public System.Nullable<System.Int32> P034F018 { get; set; }

        [ReadOnly(false)]
        [Column("P034F019", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 23)]
        public System.Nullable<System.Int32> P034F019 { get; set; }

        [ReadOnly(false)]
        [Column("P034F020", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 24)]
        public System.Nullable<System.Int32> P034F020 { get; set; }

        [ReadOnly(false)]
        [Column("P034F021", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 25)]
        public System.Nullable<System.Int32> P034F021 { get; set; }

        [ReadOnly(false)]
        [Column("P034F022", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 26)]
        public System.Nullable<System.Int32> P034F022 { get; set; }

        [ReadOnly(false)]
        [Column("P034G001", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 27)]
        public System.Nullable<System.Int32> P034G001 { get; set; }

        [ReadOnly(false)]
        [Column("P034G002", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 28)]
        public System.Nullable<System.Int32> P034G002 { get; set; }

        [ReadOnly(false)]
        [Column("P034G003", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 29)]
        public System.Nullable<System.Int32> P034G003 { get; set; }

        [ReadOnly(false)]
        [Column("P034G004", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder:", ShortName = "Householder:", Order = 30)]
        public System.Nullable<System.Int32> P034G004 { get; set; }

        [ReadOnly(false)]
        [Column("P034G005", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 31)]
        public System.Nullable<System.Int32> P034G005 { get; set; }

        [ReadOnly(false)]
        [Column("P034G006", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 32)]
        public System.Nullable<System.Int32> P034G006 { get; set; }

        [ReadOnly(false)]
        [Column("P034G007", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spouse", ShortName = "Spouse", Order = 33)]
        public System.Nullable<System.Int32> P034G007 { get; set; }

        [ReadOnly(false)]
        [Column("P034G008", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent", ShortName = "Parent", Order = 34)]
        public System.Nullable<System.Int32> P034G008 { get; set; }

        [ReadOnly(false)]
        [Column("P034G009", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 35)]
        public System.Nullable<System.Int32> P034G009 { get; set; }

        [ReadOnly(false)]
        [Column("P034G010", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 36)]
        public System.Nullable<System.Int32> P034G010 { get; set; }

        [ReadOnly(false)]
        [Column("P034G011", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 37)]
        public System.Nullable<System.Int32> P034G011 { get; set; }

        [ReadOnly(false)]
        [Column("P034G012", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 38)]
        public System.Nullable<System.Int32> P034G012 { get; set; }

        [ReadOnly(false)]
        [Column("P034G013", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 39)]
        public System.Nullable<System.Int32> P034G013 { get; set; }

        [ReadOnly(false)]
        [Column("P034G014", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 40)]
        public System.Nullable<System.Int32> P034G014 { get; set; }

        [ReadOnly(false)]
        [Column("P034G015", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 41)]
        public System.Nullable<System.Int32> P034G015 { get; set; }

        [ReadOnly(false)]
        [Column("P034G016", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 42)]
        public System.Nullable<System.Int32> P034G016 { get; set; }

        [ReadOnly(false)]
        [Column("P034G017", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 43)]
        public System.Nullable<System.Int32> P034G017 { get; set; }

        [ReadOnly(false)]
        [Column("P034G018", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 44)]
        public System.Nullable<System.Int32> P034G018 { get; set; }

        [ReadOnly(false)]
        [Column("P034G019", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 45)]
        public System.Nullable<System.Int32> P034G019 { get; set; }

        [ReadOnly(false)]
        [Column("P034G020", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 46)]
        public System.Nullable<System.Int32> P034G020 { get; set; }

        [ReadOnly(false)]
        [Column("P034G021", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 47)]
        public System.Nullable<System.Int32> P034G021 { get; set; }

        [ReadOnly(false)]
        [Column("P034G022", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 48)]
        public System.Nullable<System.Int32> P034G022 { get; set; }

        [ReadOnly(false)]
        [Column("P034H001", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 49)]
        public System.Nullable<System.Int32> P034H001 { get; set; }

        [ReadOnly(false)]
        [Column("P034H002", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 50)]
        public System.Nullable<System.Int32> P034H002 { get; set; }

        [ReadOnly(false)]
        [Column("P034H003", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 51)]
        public System.Nullable<System.Int32> P034H003 { get; set; }

        [ReadOnly(false)]
        [Column("P034H004", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder:", ShortName = "Householder:", Order = 52)]
        public System.Nullable<System.Int32> P034H004 { get; set; }

        [ReadOnly(false)]
        [Column("P034H005", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 53)]
        public System.Nullable<System.Int32> P034H005 { get; set; }

        [ReadOnly(false)]
        [Column("P034H006", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 54)]
        public System.Nullable<System.Int32> P034H006 { get; set; }

        [ReadOnly(false)]
        [Column("P034H007", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spouse", ShortName = "Spouse", Order = 55)]
        public System.Nullable<System.Int32> P034H007 { get; set; }

        [ReadOnly(false)]
        [Column("P034H008", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent", ShortName = "Parent", Order = 56)]
        public System.Nullable<System.Int32> P034H008 { get; set; }

        [ReadOnly(false)]
        [Column("P034H009", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 57)]
        public System.Nullable<System.Int32> P034H009 { get; set; }

        [ReadOnly(false)]
        [Column("P034H010", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 58)]
        public System.Nullable<System.Int32> P034H010 { get; set; }

        [ReadOnly(false)]
        [Column("P034H011", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 59)]
        public System.Nullable<System.Int32> P034H011 { get; set; }

        [ReadOnly(false)]
        [Column("P034H012", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 60)]
        public System.Nullable<System.Int32> P034H012 { get; set; }

        [ReadOnly(false)]
        [Column("P034H013", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 61)]
        public System.Nullable<System.Int32> P034H013 { get; set; }

        [ReadOnly(false)]
        [Column("P034H014", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 62)]
        public System.Nullable<System.Int32> P034H014 { get; set; }

        [ReadOnly(false)]
        [Column("P034H015", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 63)]
        public System.Nullable<System.Int32> P034H015 { get; set; }

        [ReadOnly(false)]
        [Column("P034H016", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 64)]
        public System.Nullable<System.Int32> P034H016 { get; set; }

        [ReadOnly(false)]
        [Column("P034H017", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 65)]
        public System.Nullable<System.Int32> P034H017 { get; set; }

        [ReadOnly(false)]
        [Column("P034H018", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 66)]
        public System.Nullable<System.Int32> P034H018 { get; set; }

        [ReadOnly(false)]
        [Column("P034H019", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 67)]
        public System.Nullable<System.Int32> P034H019 { get; set; }

        [ReadOnly(false)]
        [Column("P034H020", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 68)]
        public System.Nullable<System.Int32> P034H020 { get; set; }

        [ReadOnly(false)]
        [Column("P034H021", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 69)]
        public System.Nullable<System.Int32> P034H021 { get; set; }

        [ReadOnly(false)]
        [Column("P034H022", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 70)]
        public System.Nullable<System.Int32> P034H022 { get; set; }

        [ReadOnly(false)]
        [Column("P034I001", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 71)]
        public System.Nullable<System.Int32> P034I001 { get; set; }

        [ReadOnly(false)]
        [Column("P034I002", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 72)]
        public System.Nullable<System.Int32> P034I002 { get; set; }

        [ReadOnly(false)]
        [Column("P034I003", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 73)]
        public System.Nullable<System.Int32> P034I003 { get; set; }

        [ReadOnly(false)]
        [Column("P034I004", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder:", ShortName = "Householder:", Order = 74)]
        public System.Nullable<System.Int32> P034I004 { get; set; }

        [ReadOnly(false)]
        [Column("P034I005", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 75)]
        public System.Nullable<System.Int32> P034I005 { get; set; }

        [ReadOnly(false)]
        [Column("P034I006", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 76)]
        public System.Nullable<System.Int32> P034I006 { get; set; }

        [ReadOnly(false)]
        [Column("P034I007", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spouse", ShortName = "Spouse", Order = 77)]
        public System.Nullable<System.Int32> P034I007 { get; set; }

        [ReadOnly(false)]
        [Column("P034I008", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent", ShortName = "Parent", Order = 78)]
        public System.Nullable<System.Int32> P034I008 { get; set; }

        [ReadOnly(false)]
        [Column("P034I009", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 79)]
        public System.Nullable<System.Int32> P034I009 { get; set; }

        [ReadOnly(false)]
        [Column("P034I010", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 80)]
        public System.Nullable<System.Int32> P034I010 { get; set; }

        [ReadOnly(false)]
        [Column("P034I011", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 81)]
        public System.Nullable<System.Int32> P034I011 { get; set; }

        [ReadOnly(false)]
        [Column("P034I012", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 82)]
        public System.Nullable<System.Int32> P034I012 { get; set; }

        [ReadOnly(false)]
        [Column("P034I013", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 83)]
        public System.Nullable<System.Int32> P034I013 { get; set; }

        [ReadOnly(false)]
        [Column("P034I014", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 84)]
        public System.Nullable<System.Int32> P034I014 { get; set; }

        [ReadOnly(false)]
        [Column("P034I015", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 85)]
        public System.Nullable<System.Int32> P034I015 { get; set; }

        [ReadOnly(false)]
        [Column("P034I016", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 86)]
        public System.Nullable<System.Int32> P034I016 { get; set; }

        [ReadOnly(false)]
        [Column("P034I017", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 87)]
        public System.Nullable<System.Int32> P034I017 { get; set; }

        [ReadOnly(false)]
        [Column("P034I018", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 88)]
        public System.Nullable<System.Int32> P034I018 { get; set; }

        [ReadOnly(false)]
        [Column("P034I019", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 89)]
        public System.Nullable<System.Int32> P034I019 { get; set; }

        [ReadOnly(false)]
        [Column("P034I020", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 90)]
        public System.Nullable<System.Int32> P034I020 { get; set; }

        [ReadOnly(false)]
        [Column("P034I021", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 91)]
        public System.Nullable<System.Int32> P034I021 { get; set; }

        [ReadOnly(false)]
        [Column("P034I022", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 92)]
        public System.Nullable<System.Int32> P034I022 { get; set; }

        [ReadOnly(false)]
        [Column("P035A001", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total", ShortName = "Total", Order = 93)]
        public System.Nullable<System.Int32> P035A001 { get; set; }

        [ReadOnly(false)]
        [Column("P035B001", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total", ShortName = "Total", Order = 94)]
        public System.Nullable<System.Int32> P035B001 { get; set; }

        [ReadOnly(false)]
        [Column("P035C001", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total", ShortName = "Total", Order = 95)]
        public System.Nullable<System.Int32> P035C001 { get; set; }

        [ReadOnly(false)]
        [Column("P035D001", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total", ShortName = "Total", Order = 96)]
        public System.Nullable<System.Int32> P035D001 { get; set; }

        [ReadOnly(false)]
        [Column("P035E001", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total", ShortName = "Total", Order = 97)]
        public System.Nullable<System.Int32> P035E001 { get; set; }

        [ReadOnly(false)]
        [Column("P035F001", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total", ShortName = "Total", Order = 98)]
        public System.Nullable<System.Int32> P035F001 { get; set; }

        [ReadOnly(false)]
        [Column("P035G001", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total", ShortName = "Total", Order = 99)]
        public System.Nullable<System.Int32> P035G001 { get; set; }

        [ReadOnly(false)]
        [Column("P035H001", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total", ShortName = "Total", Order = 100)]
        public System.Nullable<System.Int32> P035H001 { get; set; }

        [ReadOnly(false)]
        [Column("P035I001", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total", ShortName = "Total", Order = 101)]
        public System.Nullable<System.Int32> P035I001 { get; set; }

        [ReadOnly(false)]
        [Column("P036A001", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 102)]
        public System.Nullable<System.Int32> P036A001 { get; set; }

        [ReadOnly(false)]
        [Column("P036A002", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 103)]
        public System.Nullable<System.Int32> P036A002 { get; set; }

        [ReadOnly(false)]
        [Column("P036A003", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 104)]
        public System.Nullable<System.Int32> P036A003 { get; set; }

        [ReadOnly(false)]
        [Column("P036B001", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 105)]
        public System.Nullable<System.Int32> P036B001 { get; set; }

        [ReadOnly(false)]
        [Column("P036B002", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 106)]
        public System.Nullable<System.Int32> P036B002 { get; set; }

        [ReadOnly(false)]
        [Column("P036B003", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 107)]
        public System.Nullable<System.Int32> P036B003 { get; set; }

        [ReadOnly(false)]
        [Column("P036C001", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 108)]
        public System.Nullable<System.Int32> P036C001 { get; set; }

        [ReadOnly(false)]
        [Column("P036C002", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 109)]
        public System.Nullable<System.Int32> P036C002 { get; set; }

        [ReadOnly(false)]
        [Column("P036C003", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 110)]
        public System.Nullable<System.Int32> P036C003 { get; set; }

        [ReadOnly(false)]
        [Column("P036D001", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 111)]
        public System.Nullable<System.Int32> P036D001 { get; set; }

        [ReadOnly(false)]
        [Column("P036D002", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 112)]
        public System.Nullable<System.Int32> P036D002 { get; set; }

        [ReadOnly(false)]
        [Column("P036D003", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 113)]
        public System.Nullable<System.Int32> P036D003 { get; set; }

        [ReadOnly(false)]
        [Column("P036E001", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 114)]
        public System.Nullable<System.Int32> P036E001 { get; set; }

        [ReadOnly(false)]
        [Column("P036E002", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 115)]
        public System.Nullable<System.Int32> P036E002 { get; set; }

        [ReadOnly(false)]
        [Column("P036E003", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 116)]
        public System.Nullable<System.Int32> P036E003 { get; set; }

        [ReadOnly(false)]
        [Column("P036F001", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 117)]
        public System.Nullable<System.Int32> P036F001 { get; set; }

        [ReadOnly(false)]
        [Column("P036F002", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 118)]
        public System.Nullable<System.Int32> P036F002 { get; set; }

        [ReadOnly(false)]
        [Column("P036F003", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 119)]
        public System.Nullable<System.Int32> P036F003 { get; set; }

        [ReadOnly(false)]
        [Column("P036G001", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 120)]
        public System.Nullable<System.Int32> P036G001 { get; set; }

        [ReadOnly(false)]
        [Column("P036G002", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 121)]
        public System.Nullable<System.Int32> P036G002 { get; set; }

        [ReadOnly(false)]
        [Column("P036G003", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 122)]
        public System.Nullable<System.Int32> P036G003 { get; set; }

        [ReadOnly(false)]
        [Column("P036H001", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 123)]
        public System.Nullable<System.Int32> P036H001 { get; set; }

        [ReadOnly(false)]
        [Column("P036H002", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 124)]
        public System.Nullable<System.Int32> P036H002 { get; set; }

        [ReadOnly(false)]
        [Column("P036H003", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 125)]
        public System.Nullable<System.Int32> P036H003 { get; set; }

        [ReadOnly(false)]
        [Column("P036I001", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 126)]
        public System.Nullable<System.Int32> P036I001 { get; set; }

        [ReadOnly(false)]
        [Column("P036I002", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 127)]
        public System.Nullable<System.Int32> P036I002 { get; set; }

        [ReadOnly(false)]
        [Column("P036I003", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 128)]
        public System.Nullable<System.Int32> P036I003 { get; set; }

        [ReadOnly(false)]
        [Column("P037A001", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 129)]
        public System.Nullable<System.Double> P037A001 { get; set; }

        [ReadOnly(false)]
        [Column("P037A002", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 130)]
        public System.Nullable<System.Double> P037A002 { get; set; }

        [ReadOnly(false)]
        [Column("P037A003", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 131)]
        public System.Nullable<System.Double> P037A003 { get; set; }

        [ReadOnly(false)]
        [Column("P037B001", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 132)]
        public System.Nullable<System.Double> P037B001 { get; set; }

        [ReadOnly(false)]
        [Column("P037B002", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 133)]
        public System.Nullable<System.Double> P037B002 { get; set; }

        [ReadOnly(false)]
        [Column("P037B003", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 134)]
        public System.Nullable<System.Double> P037B003 { get; set; }

        [ReadOnly(false)]
        [Column("P037C001", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 135)]
        public System.Nullable<System.Double> P037C001 { get; set; }

        [ReadOnly(false)]
        [Column("P037C002", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 136)]
        public System.Nullable<System.Double> P037C002 { get; set; }

        [ReadOnly(false)]
        [Column("P037C003", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 137)]
        public System.Nullable<System.Double> P037C003 { get; set; }

        [ReadOnly(false)]
        [Column("P037D001", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 138)]
        public System.Nullable<System.Double> P037D001 { get; set; }

        [ReadOnly(false)]
        [Column("P037D002", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 139)]
        public System.Nullable<System.Double> P037D002 { get; set; }

        [ReadOnly(false)]
        [Column("P037D003", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 140)]
        public System.Nullable<System.Double> P037D003 { get; set; }

        [ReadOnly(false)]
        [Column("P037E001", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 141)]
        public System.Nullable<System.Double> P037E001 { get; set; }

        [ReadOnly(false)]
        [Column("P037E002", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 142)]
        public System.Nullable<System.Double> P037E002 { get; set; }

        [ReadOnly(false)]
        [Column("P037E003", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 143)]
        public System.Nullable<System.Double> P037E003 { get; set; }

        [ReadOnly(false)]
        [Column("P037F001", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 144)]
        public System.Nullable<System.Double> P037F001 { get; set; }

        [ReadOnly(false)]
        [Column("P037F002", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 145)]
        public System.Nullable<System.Double> P037F002 { get; set; }

        [ReadOnly(false)]
        [Column("P037F003", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 146)]
        public System.Nullable<System.Double> P037F003 { get; set; }

        [ReadOnly(false)]
        [Column("P037G001", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 147)]
        public System.Nullable<System.Double> P037G001 { get; set; }

        [ReadOnly(false)]
        [Column("P037G002", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 148)]
        public System.Nullable<System.Double> P037G002 { get; set; }

        [ReadOnly(false)]
        [Column("P037G003", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 149)]
        public System.Nullable<System.Double> P037G003 { get; set; }

        [ReadOnly(false)]
        [Column("P037H001", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 150)]
        public System.Nullable<System.Double> P037H001 { get; set; }

        [ReadOnly(false)]
        [Column("P037H002", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 151)]
        public System.Nullable<System.Double> P037H002 { get; set; }

        [ReadOnly(false)]
        [Column("P037H003", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 152)]
        public System.Nullable<System.Double> P037H003 { get; set; }

        [ReadOnly(false)]
        [Column("P037I001", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 153)]
        public System.Nullable<System.Double> P037I001 { get; set; }

        [ReadOnly(false)]
        [Column("P037I002", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 154)]
        public System.Nullable<System.Double> P037I002 { get; set; }

        [ReadOnly(false)]
        [Column("P037I003", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 155)]
        public System.Nullable<System.Double> P037I003 { get; set; }

        [ReadOnly(false)]
        [Column("P038A001", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 156)]
        public System.Nullable<System.Int32> P038A001 { get; set; }

        [ReadOnly(false)]
        [Column("P038A002", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 157)]
        public System.Nullable<System.Int32> P038A002 { get; set; }

        [ReadOnly(false)]
        [Column("P038A003", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 158)]
        public System.Nullable<System.Int32> P038A003 { get; set; }

        [ReadOnly(false)]
        [Column("P038A004", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 159)]
        public System.Nullable<System.Int32> P038A004 { get; set; }

        [ReadOnly(false)]
        [Column("P038A005", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 160)]
        public System.Nullable<System.Int32> P038A005 { get; set; }

        [ReadOnly(false)]
        [Column("P038A006", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 161)]
        public System.Nullable<System.Int32> P038A006 { get; set; }

        [ReadOnly(false)]
        [Column("P038A007", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 162)]
        public System.Nullable<System.Int32> P038A007 { get; set; }

        [ReadOnly(false)]
        [Column("P038A008", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 163)]
        public System.Nullable<System.Int32> P038A008 { get; set; }

        [ReadOnly(false)]
        [Column("P038A009", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 164)]
        public System.Nullable<System.Int32> P038A009 { get; set; }

        [ReadOnly(false)]
        [Column("P038A010", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 165)]
        public System.Nullable<System.Int32> P038A010 { get; set; }

        [ReadOnly(false)]
        [Column("P038A011", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 166)]
        public System.Nullable<System.Int32> P038A011 { get; set; }

        [ReadOnly(false)]
        [Column("P038A012", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 167)]
        public System.Nullable<System.Int32> P038A012 { get; set; }

        [ReadOnly(false)]
        [Column("P038A013", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 168)]
        public System.Nullable<System.Int32> P038A013 { get; set; }

        [ReadOnly(false)]
        [Column("P038A014", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 169)]
        public System.Nullable<System.Int32> P038A014 { get; set; }

        [ReadOnly(false)]
        [Column("P038A015", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 170)]
        public System.Nullable<System.Int32> P038A015 { get; set; }

        [ReadOnly(false)]
        [Column("P038A016", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 171)]
        public System.Nullable<System.Int32> P038A016 { get; set; }

        [ReadOnly(false)]
        [Column("P038A017", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 172)]
        public System.Nullable<System.Int32> P038A017 { get; set; }

        [ReadOnly(false)]
        [Column("P038A018", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 173)]
        public System.Nullable<System.Int32> P038A018 { get; set; }

        [ReadOnly(false)]
        [Column("P038A019", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 174)]
        public System.Nullable<System.Int32> P038A019 { get; set; }

        [ReadOnly(false)]
        [Column("P038A020", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 175)]
        public System.Nullable<System.Int32> P038A020 { get; set; }

        [ReadOnly(false)]
        [Column("P038B001", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 176)]
        public System.Nullable<System.Int32> P038B001 { get; set; }

        [ReadOnly(false)]
        [Column("P038B002", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 177)]
        public System.Nullable<System.Int32> P038B002 { get; set; }

        [ReadOnly(false)]
        [Column("P038B003", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 178)]
        public System.Nullable<System.Int32> P038B003 { get; set; }

        [ReadOnly(false)]
        [Column("P038B004", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 179)]
        public System.Nullable<System.Int32> P038B004 { get; set; }

        [ReadOnly(false)]
        [Column("P038B005", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 180)]
        public System.Nullable<System.Int32> P038B005 { get; set; }

        [ReadOnly(false)]
        [Column("P038B006", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 181)]
        public System.Nullable<System.Int32> P038B006 { get; set; }

        [ReadOnly(false)]
        [Column("P038B007", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 182)]
        public System.Nullable<System.Int32> P038B007 { get; set; }

        [ReadOnly(false)]
        [Column("P038B008", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 183)]
        public System.Nullable<System.Int32> P038B008 { get; set; }

        [ReadOnly(false)]
        [Column("P038B009", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 184)]
        public System.Nullable<System.Int32> P038B009 { get; set; }

        [ReadOnly(false)]
        [Column("P038B010", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 185)]
        public System.Nullable<System.Int32> P038B010 { get; set; }

        [ReadOnly(false)]
        [Column("P038B011", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 186)]
        public System.Nullable<System.Int32> P038B011 { get; set; }

        [ReadOnly(false)]
        [Column("P038B012", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 187)]
        public System.Nullable<System.Int32> P038B012 { get; set; }

        [ReadOnly(false)]
        [Column("P038B013", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 188)]
        public System.Nullable<System.Int32> P038B013 { get; set; }

        [ReadOnly(false)]
        [Column("P038B014", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 189)]
        public System.Nullable<System.Int32> P038B014 { get; set; }

        [ReadOnly(false)]
        [Column("P038B015", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 190)]
        public System.Nullable<System.Int32> P038B015 { get; set; }

        [ReadOnly(false)]
        [Column("P038B016", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 191)]
        public System.Nullable<System.Int32> P038B016 { get; set; }

        [ReadOnly(false)]
        [Column("P038B017", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 192)]
        public System.Nullable<System.Int32> P038B017 { get; set; }

        [ReadOnly(false)]
        [Column("P038B018", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 193)]
        public System.Nullable<System.Int32> P038B018 { get; set; }

        [ReadOnly(false)]
        [Column("P038B019", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 194)]
        public System.Nullable<System.Int32> P038B019 { get; set; }

        [ReadOnly(false)]
        [Column("P038B020", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 195)]
        public System.Nullable<System.Int32> P038B020 { get; set; }

        [ReadOnly(false)]
        [Column("P038C001", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 196)]
        public System.Nullable<System.Int32> P038C001 { get; set; }

        [ReadOnly(false)]
        [Column("P038C002", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 197)]
        public System.Nullable<System.Int32> P038C002 { get; set; }

        [ReadOnly(false)]
        [Column("P038C003", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 198)]
        public System.Nullable<System.Int32> P038C003 { get; set; }

        [ReadOnly(false)]
        [Column("P038C004", Order = 199)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 199)]
        public System.Nullable<System.Int32> P038C004 { get; set; }

        [ReadOnly(false)]
        [Column("P038C005", Order = 200)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 200)]
        public System.Nullable<System.Int32> P038C005 { get; set; }

        [ReadOnly(false)]
        [Column("P038C006", Order = 201)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 201)]
        public System.Nullable<System.Int32> P038C006 { get; set; }

        [ReadOnly(false)]
        [Column("P038C007", Order = 202)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 202)]
        public System.Nullable<System.Int32> P038C007 { get; set; }

        [ReadOnly(false)]
        [Column("P038C008", Order = 203)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 203)]
        public System.Nullable<System.Int32> P038C008 { get; set; }

        [ReadOnly(false)]
        [Column("P038C009", Order = 204)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 204)]
        public System.Nullable<System.Int32> P038C009 { get; set; }

        [ReadOnly(false)]
        [Column("P038C010", Order = 205)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 205)]
        public System.Nullable<System.Int32> P038C010 { get; set; }

        [ReadOnly(false)]
        [Column("P038C011", Order = 206)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 206)]
        public System.Nullable<System.Int32> P038C011 { get; set; }

        [ReadOnly(false)]
        [Column("P038C012", Order = 207)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 207)]
        public System.Nullable<System.Int32> P038C012 { get; set; }

        [ReadOnly(false)]
        [Column("P038C013", Order = 208)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 208)]
        public System.Nullable<System.Int32> P038C013 { get; set; }

        [ReadOnly(false)]
        [Column("P038C014", Order = 209)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 209)]
        public System.Nullable<System.Int32> P038C014 { get; set; }

        [ReadOnly(false)]
        [Column("P038C015", Order = 210)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 210)]
        public System.Nullable<System.Int32> P038C015 { get; set; }

        [ReadOnly(false)]
        [Column("P038C016", Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 211)]
        public System.Nullable<System.Int32> P038C016 { get; set; }

        [ReadOnly(false)]
        [Column("P038C017", Order = 212)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 212)]
        public System.Nullable<System.Int32> P038C017 { get; set; }

        [ReadOnly(false)]
        [Column("P038C018", Order = 213)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 213)]
        public System.Nullable<System.Int32> P038C018 { get; set; }

        [ReadOnly(false)]
        [Column("P038C019", Order = 214)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 214)]
        public System.Nullable<System.Int32> P038C019 { get; set; }

        [ReadOnly(false)]
        [Column("P038C020", Order = 215)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 215)]
        public System.Nullable<System.Int32> P038C020 { get; set; }

        [ReadOnly(false)]
        [Column("P038D001", Order = 216)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 216)]
        public System.Nullable<System.Int32> P038D001 { get; set; }

        [ReadOnly(false)]
        [Column("P038D002", Order = 217)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 217)]
        public System.Nullable<System.Int32> P038D002 { get; set; }

        [ReadOnly(false)]
        [Column("P038D003", Order = 218)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 218)]
        public System.Nullable<System.Int32> P038D003 { get; set; }

        [ReadOnly(false)]
        [Column("P038D004", Order = 219)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 219)]
        public System.Nullable<System.Int32> P038D004 { get; set; }

        [ReadOnly(false)]
        [Column("P038D005", Order = 220)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 220)]
        public System.Nullable<System.Int32> P038D005 { get; set; }

        [ReadOnly(false)]
        [Column("P038D006", Order = 221)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 221)]
        public System.Nullable<System.Int32> P038D006 { get; set; }

        [ReadOnly(false)]
        [Column("P038D007", Order = 222)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 222)]
        public System.Nullable<System.Int32> P038D007 { get; set; }

        [ReadOnly(false)]
        [Column("P038D008", Order = 223)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 223)]
        public System.Nullable<System.Int32> P038D008 { get; set; }

        [ReadOnly(false)]
        [Column("P038D009", Order = 224)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 224)]
        public System.Nullable<System.Int32> P038D009 { get; set; }

        [ReadOnly(false)]
        [Column("P038D010", Order = 225)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 225)]
        public System.Nullable<System.Int32> P038D010 { get; set; }

        [ReadOnly(false)]
        [Column("P038D011", Order = 226)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 226)]
        public System.Nullable<System.Int32> P038D011 { get; set; }

        [ReadOnly(false)]
        [Column("P038D012", Order = 227)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 227)]
        public System.Nullable<System.Int32> P038D012 { get; set; }

        [ReadOnly(false)]
        [Column("P038D013", Order = 228)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 228)]
        public System.Nullable<System.Int32> P038D013 { get; set; }

        [ReadOnly(false)]
        [Column("P038D014", Order = 229)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 229)]
        public System.Nullable<System.Int32> P038D014 { get; set; }

        [ReadOnly(false)]
        [Column("P038D015", Order = 230)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 230)]
        public System.Nullable<System.Int32> P038D015 { get; set; }

        [ReadOnly(false)]
        [Column("P038D016", Order = 231)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 231)]
        public System.Nullable<System.Int32> P038D016 { get; set; }

        [ReadOnly(false)]
        [Column("P038D017", Order = 232)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 232)]
        public System.Nullable<System.Int32> P038D017 { get; set; }

        [ReadOnly(false)]
        [Column("P038D018", Order = 233)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 233)]
        public System.Nullable<System.Int32> P038D018 { get; set; }

        [ReadOnly(false)]
        [Column("P038D019", Order = 234)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 234)]
        public System.Nullable<System.Int32> P038D019 { get; set; }

        [ReadOnly(false)]
        [Column("P038D020", Order = 235)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 235)]
        public System.Nullable<System.Int32> P038D020 { get; set; }

        [ReadOnly(false)]
        [Column("P038E001", Order = 236)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 236)]
        public System.Nullable<System.Int32> P038E001 { get; set; }

        [ReadOnly(false)]
        [Column("P038E002", Order = 237)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 237)]
        public System.Nullable<System.Int32> P038E002 { get; set; }

        [ReadOnly(false)]
        [Column("P038E003", Order = 238)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 238)]
        public System.Nullable<System.Int32> P038E003 { get; set; }

        [ReadOnly(false)]
        [Column("P038E004", Order = 239)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 239)]
        public System.Nullable<System.Int32> P038E004 { get; set; }

        [ReadOnly(false)]
        [Column("P038E005", Order = 240)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 240)]
        public System.Nullable<System.Int32> P038E005 { get; set; }

        [ReadOnly(false)]
        [Column("P038E006", Order = 241)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 241)]
        public System.Nullable<System.Int32> P038E006 { get; set; }

        [ReadOnly(false)]
        [Column("P038E007", Order = 242)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 242)]
        public System.Nullable<System.Int32> P038E007 { get; set; }

        [ReadOnly(false)]
        [Column("P038E008", Order = 243)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 243)]
        public System.Nullable<System.Int32> P038E008 { get; set; }

        [ReadOnly(false)]
        [Column("P038E009", Order = 244)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 244)]
        public System.Nullable<System.Int32> P038E009 { get; set; }

        [ReadOnly(false)]
        [Column("P038E010", Order = 245)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 245)]
        public System.Nullable<System.Int32> P038E010 { get; set; }

        [ReadOnly(false)]
        [Column("P038E011", Order = 246)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 246)]
        public System.Nullable<System.Int32> P038E011 { get; set; }

        [ReadOnly(false)]
        [Column("P038E012", Order = 247)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 247)]
        public System.Nullable<System.Int32> P038E012 { get; set; }

        [ReadOnly(false)]
        [Column("P038E013", Order = 248)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 248)]
        public System.Nullable<System.Int32> P038E013 { get; set; }

        [ReadOnly(false)]
        [Column("P038E014", Order = 249)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 249)]
        public System.Nullable<System.Int32> P038E014 { get; set; }

        [ReadOnly(false)]
        [Column("P038E015", Order = 250)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 250)]
        public System.Nullable<System.Int32> P038E015 { get; set; }

        [ReadOnly(false)]
        [Column("P038E016", Order = 251)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 251)]
        public System.Nullable<System.Int32> P038E016 { get; set; }

        [ReadOnly(false)]
        [Column("P038E017", Order = 252)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 252)]
        public System.Nullable<System.Int32> P038E017 { get; set; }

        [ReadOnly(false)]
        [Column("P038E018", Order = 253)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 253)]
        public System.Nullable<System.Int32> P038E018 { get; set; }

        [ReadOnly(false)]
        [Column("P038E019", Order = 254)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 254)]
        public System.Nullable<System.Int32> P038E019 { get; set; }

        [ReadOnly(false)]
        [Column("P038E020", Order = 255)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 255)]
        public System.Nullable<System.Int32> P038E020 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1_00012(string csvLine) : base(csvLine) {}

        public SF1_00012(string[] values) : base(values) {}

        public SF1_00012(OleDbDataReader reader, CensusFileType fileType)
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
                P034F001 = (System.Nullable<System.Int32>)reader[5];
            }
            if(reader[6] != DBNull.Value)
            {
                P034F002 = (System.Nullable<System.Int32>)reader[6];
            }
            if(reader[7] != DBNull.Value)
            {
                P034F003 = (System.Nullable<System.Int32>)reader[7];
            }
            if(reader[8] != DBNull.Value)
            {
                P034F004 = (System.Nullable<System.Int32>)reader[8];
            }
            if(reader[9] != DBNull.Value)
            {
                P034F005 = (System.Nullable<System.Int32>)reader[9];
            }
            if(reader[10] != DBNull.Value)
            {
                P034F006 = (System.Nullable<System.Int32>)reader[10];
            }
            if(reader[11] != DBNull.Value)
            {
                P034F007 = (System.Nullable<System.Int32>)reader[11];
            }
            if(reader[12] != DBNull.Value)
            {
                P034F008 = (System.Nullable<System.Int32>)reader[12];
            }
            if(reader[13] != DBNull.Value)
            {
                P034F009 = (System.Nullable<System.Int32>)reader[13];
            }
            if(reader[14] != DBNull.Value)
            {
                P034F010 = (System.Nullable<System.Int32>)reader[14];
            }
            if(reader[15] != DBNull.Value)
            {
                P034F011 = (System.Nullable<System.Int32>)reader[15];
            }
            if(reader[16] != DBNull.Value)
            {
                P034F012 = (System.Nullable<System.Int32>)reader[16];
            }
            if(reader[17] != DBNull.Value)
            {
                P034F013 = (System.Nullable<System.Int32>)reader[17];
            }
            if(reader[18] != DBNull.Value)
            {
                P034F014 = (System.Nullable<System.Int32>)reader[18];
            }
            if(reader[19] != DBNull.Value)
            {
                P034F015 = (System.Nullable<System.Int32>)reader[19];
            }
            if(reader[20] != DBNull.Value)
            {
                P034F016 = (System.Nullable<System.Int32>)reader[20];
            }
            if(reader[21] != DBNull.Value)
            {
                P034F017 = (System.Nullable<System.Int32>)reader[21];
            }
            if(reader[22] != DBNull.Value)
            {
                P034F018 = (System.Nullable<System.Int32>)reader[22];
            }
            if(reader[23] != DBNull.Value)
            {
                P034F019 = (System.Nullable<System.Int32>)reader[23];
            }
            if(reader[24] != DBNull.Value)
            {
                P034F020 = (System.Nullable<System.Int32>)reader[24];
            }
            if(reader[25] != DBNull.Value)
            {
                P034F021 = (System.Nullable<System.Int32>)reader[25];
            }
            if(reader[26] != DBNull.Value)
            {
                P034F022 = (System.Nullable<System.Int32>)reader[26];
            }
            if(reader[27] != DBNull.Value)
            {
                P034G001 = (System.Nullable<System.Int32>)reader[27];
            }
            if(reader[28] != DBNull.Value)
            {
                P034G002 = (System.Nullable<System.Int32>)reader[28];
            }
            if(reader[29] != DBNull.Value)
            {
                P034G003 = (System.Nullable<System.Int32>)reader[29];
            }
            if(reader[30] != DBNull.Value)
            {
                P034G004 = (System.Nullable<System.Int32>)reader[30];
            }
            if(reader[31] != DBNull.Value)
            {
                P034G005 = (System.Nullable<System.Int32>)reader[31];
            }
            if(reader[32] != DBNull.Value)
            {
                P034G006 = (System.Nullable<System.Int32>)reader[32];
            }
            if(reader[33] != DBNull.Value)
            {
                P034G007 = (System.Nullable<System.Int32>)reader[33];
            }
            if(reader[34] != DBNull.Value)
            {
                P034G008 = (System.Nullable<System.Int32>)reader[34];
            }
            if(reader[35] != DBNull.Value)
            {
                P034G009 = (System.Nullable<System.Int32>)reader[35];
            }
            if(reader[36] != DBNull.Value)
            {
                P034G010 = (System.Nullable<System.Int32>)reader[36];
            }
            if(reader[37] != DBNull.Value)
            {
                P034G011 = (System.Nullable<System.Int32>)reader[37];
            }
            if(reader[38] != DBNull.Value)
            {
                P034G012 = (System.Nullable<System.Int32>)reader[38];
            }
            if(reader[39] != DBNull.Value)
            {
                P034G013 = (System.Nullable<System.Int32>)reader[39];
            }
            if(reader[40] != DBNull.Value)
            {
                P034G014 = (System.Nullable<System.Int32>)reader[40];
            }
            if(reader[41] != DBNull.Value)
            {
                P034G015 = (System.Nullable<System.Int32>)reader[41];
            }
            if(reader[42] != DBNull.Value)
            {
                P034G016 = (System.Nullable<System.Int32>)reader[42];
            }
            if(reader[43] != DBNull.Value)
            {
                P034G017 = (System.Nullable<System.Int32>)reader[43];
            }
            if(reader[44] != DBNull.Value)
            {
                P034G018 = (System.Nullable<System.Int32>)reader[44];
            }
            if(reader[45] != DBNull.Value)
            {
                P034G019 = (System.Nullable<System.Int32>)reader[45];
            }
            if(reader[46] != DBNull.Value)
            {
                P034G020 = (System.Nullable<System.Int32>)reader[46];
            }
            if(reader[47] != DBNull.Value)
            {
                P034G021 = (System.Nullable<System.Int32>)reader[47];
            }
            if(reader[48] != DBNull.Value)
            {
                P034G022 = (System.Nullable<System.Int32>)reader[48];
            }
            if(reader[49] != DBNull.Value)
            {
                P034H001 = (System.Nullable<System.Int32>)reader[49];
            }
            if(reader[50] != DBNull.Value)
            {
                P034H002 = (System.Nullable<System.Int32>)reader[50];
            }
            if(reader[51] != DBNull.Value)
            {
                P034H003 = (System.Nullable<System.Int32>)reader[51];
            }
            if(reader[52] != DBNull.Value)
            {
                P034H004 = (System.Nullable<System.Int32>)reader[52];
            }
            if(reader[53] != DBNull.Value)
            {
                P034H005 = (System.Nullable<System.Int32>)reader[53];
            }
            if(reader[54] != DBNull.Value)
            {
                P034H006 = (System.Nullable<System.Int32>)reader[54];
            }
            if(reader[55] != DBNull.Value)
            {
                P034H007 = (System.Nullable<System.Int32>)reader[55];
            }
            if(reader[56] != DBNull.Value)
            {
                P034H008 = (System.Nullable<System.Int32>)reader[56];
            }
            if(reader[57] != DBNull.Value)
            {
                P034H009 = (System.Nullable<System.Int32>)reader[57];
            }
            if(reader[58] != DBNull.Value)
            {
                P034H010 = (System.Nullable<System.Int32>)reader[58];
            }
            if(reader[59] != DBNull.Value)
            {
                P034H011 = (System.Nullable<System.Int32>)reader[59];
            }
            if(reader[60] != DBNull.Value)
            {
                P034H012 = (System.Nullable<System.Int32>)reader[60];
            }
            if(reader[61] != DBNull.Value)
            {
                P034H013 = (System.Nullable<System.Int32>)reader[61];
            }
            if(reader[62] != DBNull.Value)
            {
                P034H014 = (System.Nullable<System.Int32>)reader[62];
            }
            if(reader[63] != DBNull.Value)
            {
                P034H015 = (System.Nullable<System.Int32>)reader[63];
            }
            if(reader[64] != DBNull.Value)
            {
                P034H016 = (System.Nullable<System.Int32>)reader[64];
            }
            if(reader[65] != DBNull.Value)
            {
                P034H017 = (System.Nullable<System.Int32>)reader[65];
            }
            if(reader[66] != DBNull.Value)
            {
                P034H018 = (System.Nullable<System.Int32>)reader[66];
            }
            if(reader[67] != DBNull.Value)
            {
                P034H019 = (System.Nullable<System.Int32>)reader[67];
            }
            if(reader[68] != DBNull.Value)
            {
                P034H020 = (System.Nullable<System.Int32>)reader[68];
            }
            if(reader[69] != DBNull.Value)
            {
                P034H021 = (System.Nullable<System.Int32>)reader[69];
            }
            if(reader[70] != DBNull.Value)
            {
                P034H022 = (System.Nullable<System.Int32>)reader[70];
            }
            if(reader[71] != DBNull.Value)
            {
                P034I001 = (System.Nullable<System.Int32>)reader[71];
            }
            if(reader[72] != DBNull.Value)
            {
                P034I002 = (System.Nullable<System.Int32>)reader[72];
            }
            if(reader[73] != DBNull.Value)
            {
                P034I003 = (System.Nullable<System.Int32>)reader[73];
            }
            if(reader[74] != DBNull.Value)
            {
                P034I004 = (System.Nullable<System.Int32>)reader[74];
            }
            if(reader[75] != DBNull.Value)
            {
                P034I005 = (System.Nullable<System.Int32>)reader[75];
            }
            if(reader[76] != DBNull.Value)
            {
                P034I006 = (System.Nullable<System.Int32>)reader[76];
            }
            if(reader[77] != DBNull.Value)
            {
                P034I007 = (System.Nullable<System.Int32>)reader[77];
            }
            if(reader[78] != DBNull.Value)
            {
                P034I008 = (System.Nullable<System.Int32>)reader[78];
            }
            if(reader[79] != DBNull.Value)
            {
                P034I009 = (System.Nullable<System.Int32>)reader[79];
            }
            if(reader[80] != DBNull.Value)
            {
                P034I010 = (System.Nullable<System.Int32>)reader[80];
            }
            if(reader[81] != DBNull.Value)
            {
                P034I011 = (System.Nullable<System.Int32>)reader[81];
            }
            if(reader[82] != DBNull.Value)
            {
                P034I012 = (System.Nullable<System.Int32>)reader[82];
            }
            if(reader[83] != DBNull.Value)
            {
                P034I013 = (System.Nullable<System.Int32>)reader[83];
            }
            if(reader[84] != DBNull.Value)
            {
                P034I014 = (System.Nullable<System.Int32>)reader[84];
            }
            if(reader[85] != DBNull.Value)
            {
                P034I015 = (System.Nullable<System.Int32>)reader[85];
            }
            if(reader[86] != DBNull.Value)
            {
                P034I016 = (System.Nullable<System.Int32>)reader[86];
            }
            if(reader[87] != DBNull.Value)
            {
                P034I017 = (System.Nullable<System.Int32>)reader[87];
            }
            if(reader[88] != DBNull.Value)
            {
                P034I018 = (System.Nullable<System.Int32>)reader[88];
            }
            if(reader[89] != DBNull.Value)
            {
                P034I019 = (System.Nullable<System.Int32>)reader[89];
            }
            if(reader[90] != DBNull.Value)
            {
                P034I020 = (System.Nullable<System.Int32>)reader[90];
            }
            if(reader[91] != DBNull.Value)
            {
                P034I021 = (System.Nullable<System.Int32>)reader[91];
            }
            if(reader[92] != DBNull.Value)
            {
                P034I022 = (System.Nullable<System.Int32>)reader[92];
            }
            if(reader[93] != DBNull.Value)
            {
                P035A001 = (System.Nullable<System.Int32>)reader[93];
            }
            if(reader[94] != DBNull.Value)
            {
                P035B001 = (System.Nullable<System.Int32>)reader[94];
            }
            if(reader[95] != DBNull.Value)
            {
                P035C001 = (System.Nullable<System.Int32>)reader[95];
            }
            if(reader[96] != DBNull.Value)
            {
                P035D001 = (System.Nullable<System.Int32>)reader[96];
            }
            if(reader[97] != DBNull.Value)
            {
                P035E001 = (System.Nullable<System.Int32>)reader[97];
            }
            if(reader[98] != DBNull.Value)
            {
                P035F001 = (System.Nullable<System.Int32>)reader[98];
            }
            if(reader[99] != DBNull.Value)
            {
                P035G001 = (System.Nullable<System.Int32>)reader[99];
            }
            if(reader[100] != DBNull.Value)
            {
                P035H001 = (System.Nullable<System.Int32>)reader[100];
            }
            if(reader[101] != DBNull.Value)
            {
                P035I001 = (System.Nullable<System.Int32>)reader[101];
            }
            if(reader[102] != DBNull.Value)
            {
                P036A001 = (System.Nullable<System.Int32>)reader[102];
            }
            if(reader[103] != DBNull.Value)
            {
                P036A002 = (System.Nullable<System.Int32>)reader[103];
            }
            if(reader[104] != DBNull.Value)
            {
                P036A003 = (System.Nullable<System.Int32>)reader[104];
            }
            if(reader[105] != DBNull.Value)
            {
                P036B001 = (System.Nullable<System.Int32>)reader[105];
            }
            if(reader[106] != DBNull.Value)
            {
                P036B002 = (System.Nullable<System.Int32>)reader[106];
            }
            if(reader[107] != DBNull.Value)
            {
                P036B003 = (System.Nullable<System.Int32>)reader[107];
            }
            if(reader[108] != DBNull.Value)
            {
                P036C001 = (System.Nullable<System.Int32>)reader[108];
            }
            if(reader[109] != DBNull.Value)
            {
                P036C002 = (System.Nullable<System.Int32>)reader[109];
            }
            if(reader[110] != DBNull.Value)
            {
                P036C003 = (System.Nullable<System.Int32>)reader[110];
            }
            if(reader[111] != DBNull.Value)
            {
                P036D001 = (System.Nullable<System.Int32>)reader[111];
            }
            if(reader[112] != DBNull.Value)
            {
                P036D002 = (System.Nullable<System.Int32>)reader[112];
            }
            if(reader[113] != DBNull.Value)
            {
                P036D003 = (System.Nullable<System.Int32>)reader[113];
            }
            if(reader[114] != DBNull.Value)
            {
                P036E001 = (System.Nullable<System.Int32>)reader[114];
            }
            if(reader[115] != DBNull.Value)
            {
                P036E002 = (System.Nullable<System.Int32>)reader[115];
            }
            if(reader[116] != DBNull.Value)
            {
                P036E003 = (System.Nullable<System.Int32>)reader[116];
            }
            if(reader[117] != DBNull.Value)
            {
                P036F001 = (System.Nullable<System.Int32>)reader[117];
            }
            if(reader[118] != DBNull.Value)
            {
                P036F002 = (System.Nullable<System.Int32>)reader[118];
            }
            if(reader[119] != DBNull.Value)
            {
                P036F003 = (System.Nullable<System.Int32>)reader[119];
            }
            if(reader[120] != DBNull.Value)
            {
                P036G001 = (System.Nullable<System.Int32>)reader[120];
            }
            if(reader[121] != DBNull.Value)
            {
                P036G002 = (System.Nullable<System.Int32>)reader[121];
            }
            if(reader[122] != DBNull.Value)
            {
                P036G003 = (System.Nullable<System.Int32>)reader[122];
            }
            if(reader[123] != DBNull.Value)
            {
                P036H001 = (System.Nullable<System.Int32>)reader[123];
            }
            if(reader[124] != DBNull.Value)
            {
                P036H002 = (System.Nullable<System.Int32>)reader[124];
            }
            if(reader[125] != DBNull.Value)
            {
                P036H003 = (System.Nullable<System.Int32>)reader[125];
            }
            if(reader[126] != DBNull.Value)
            {
                P036I001 = (System.Nullable<System.Int32>)reader[126];
            }
            if(reader[127] != DBNull.Value)
            {
                P036I002 = (System.Nullable<System.Int32>)reader[127];
            }
            if(reader[128] != DBNull.Value)
            {
                P036I003 = (System.Nullable<System.Int32>)reader[128];
            }
            if(reader[129] != DBNull.Value)
            {
                P037A001 = (System.Nullable<System.Double>)reader[129];
            }
            if(reader[130] != DBNull.Value)
            {
                P037A002 = (System.Nullable<System.Double>)reader[130];
            }
            if(reader[131] != DBNull.Value)
            {
                P037A003 = (System.Nullable<System.Double>)reader[131];
            }
            if(reader[132] != DBNull.Value)
            {
                P037B001 = (System.Nullable<System.Double>)reader[132];
            }
            if(reader[133] != DBNull.Value)
            {
                P037B002 = (System.Nullable<System.Double>)reader[133];
            }
            if(reader[134] != DBNull.Value)
            {
                P037B003 = (System.Nullable<System.Double>)reader[134];
            }
            if(reader[135] != DBNull.Value)
            {
                P037C001 = (System.Nullable<System.Double>)reader[135];
            }
            if(reader[136] != DBNull.Value)
            {
                P037C002 = (System.Nullable<System.Double>)reader[136];
            }
            if(reader[137] != DBNull.Value)
            {
                P037C003 = (System.Nullable<System.Double>)reader[137];
            }
            if(reader[138] != DBNull.Value)
            {
                P037D001 = (System.Nullable<System.Double>)reader[138];
            }
            if(reader[139] != DBNull.Value)
            {
                P037D002 = (System.Nullable<System.Double>)reader[139];
            }
            if(reader[140] != DBNull.Value)
            {
                P037D003 = (System.Nullable<System.Double>)reader[140];
            }
            if(reader[141] != DBNull.Value)
            {
                P037E001 = (System.Nullable<System.Double>)reader[141];
            }
            if(reader[142] != DBNull.Value)
            {
                P037E002 = (System.Nullable<System.Double>)reader[142];
            }
            if(reader[143] != DBNull.Value)
            {
                P037E003 = (System.Nullable<System.Double>)reader[143];
            }
            if(reader[144] != DBNull.Value)
            {
                P037F001 = (System.Nullable<System.Double>)reader[144];
            }
            if(reader[145] != DBNull.Value)
            {
                P037F002 = (System.Nullable<System.Double>)reader[145];
            }
            if(reader[146] != DBNull.Value)
            {
                P037F003 = (System.Nullable<System.Double>)reader[146];
            }
            if(reader[147] != DBNull.Value)
            {
                P037G001 = (System.Nullable<System.Double>)reader[147];
            }
            if(reader[148] != DBNull.Value)
            {
                P037G002 = (System.Nullable<System.Double>)reader[148];
            }
            if(reader[149] != DBNull.Value)
            {
                P037G003 = (System.Nullable<System.Double>)reader[149];
            }
            if(reader[150] != DBNull.Value)
            {
                P037H001 = (System.Nullable<System.Double>)reader[150];
            }
            if(reader[151] != DBNull.Value)
            {
                P037H002 = (System.Nullable<System.Double>)reader[151];
            }
            if(reader[152] != DBNull.Value)
            {
                P037H003 = (System.Nullable<System.Double>)reader[152];
            }
            if(reader[153] != DBNull.Value)
            {
                P037I001 = (System.Nullable<System.Double>)reader[153];
            }
            if(reader[154] != DBNull.Value)
            {
                P037I002 = (System.Nullable<System.Double>)reader[154];
            }
            if(reader[155] != DBNull.Value)
            {
                P037I003 = (System.Nullable<System.Double>)reader[155];
            }
            if(reader[156] != DBNull.Value)
            {
                P038A001 = (System.Nullable<System.Int32>)reader[156];
            }
            if(reader[157] != DBNull.Value)
            {
                P038A002 = (System.Nullable<System.Int32>)reader[157];
            }
            if(reader[158] != DBNull.Value)
            {
                P038A003 = (System.Nullable<System.Int32>)reader[158];
            }
            if(reader[159] != DBNull.Value)
            {
                P038A004 = (System.Nullable<System.Int32>)reader[159];
            }
            if(reader[160] != DBNull.Value)
            {
                P038A005 = (System.Nullable<System.Int32>)reader[160];
            }
            if(reader[161] != DBNull.Value)
            {
                P038A006 = (System.Nullable<System.Int32>)reader[161];
            }
            if(reader[162] != DBNull.Value)
            {
                P038A007 = (System.Nullable<System.Int32>)reader[162];
            }
            if(reader[163] != DBNull.Value)
            {
                P038A008 = (System.Nullable<System.Int32>)reader[163];
            }
            if(reader[164] != DBNull.Value)
            {
                P038A009 = (System.Nullable<System.Int32>)reader[164];
            }
            if(reader[165] != DBNull.Value)
            {
                P038A010 = (System.Nullable<System.Int32>)reader[165];
            }
            if(reader[166] != DBNull.Value)
            {
                P038A011 = (System.Nullable<System.Int32>)reader[166];
            }
            if(reader[167] != DBNull.Value)
            {
                P038A012 = (System.Nullable<System.Int32>)reader[167];
            }
            if(reader[168] != DBNull.Value)
            {
                P038A013 = (System.Nullable<System.Int32>)reader[168];
            }
            if(reader[169] != DBNull.Value)
            {
                P038A014 = (System.Nullable<System.Int32>)reader[169];
            }
            if(reader[170] != DBNull.Value)
            {
                P038A015 = (System.Nullable<System.Int32>)reader[170];
            }
            if(reader[171] != DBNull.Value)
            {
                P038A016 = (System.Nullable<System.Int32>)reader[171];
            }
            if(reader[172] != DBNull.Value)
            {
                P038A017 = (System.Nullable<System.Int32>)reader[172];
            }
            if(reader[173] != DBNull.Value)
            {
                P038A018 = (System.Nullable<System.Int32>)reader[173];
            }
            if(reader[174] != DBNull.Value)
            {
                P038A019 = (System.Nullable<System.Int32>)reader[174];
            }
            if(reader[175] != DBNull.Value)
            {
                P038A020 = (System.Nullable<System.Int32>)reader[175];
            }
            if(reader[176] != DBNull.Value)
            {
                P038B001 = (System.Nullable<System.Int32>)reader[176];
            }
            if(reader[177] != DBNull.Value)
            {
                P038B002 = (System.Nullable<System.Int32>)reader[177];
            }
            if(reader[178] != DBNull.Value)
            {
                P038B003 = (System.Nullable<System.Int32>)reader[178];
            }
            if(reader[179] != DBNull.Value)
            {
                P038B004 = (System.Nullable<System.Int32>)reader[179];
            }
            if(reader[180] != DBNull.Value)
            {
                P038B005 = (System.Nullable<System.Int32>)reader[180];
            }
            if(reader[181] != DBNull.Value)
            {
                P038B006 = (System.Nullable<System.Int32>)reader[181];
            }
            if(reader[182] != DBNull.Value)
            {
                P038B007 = (System.Nullable<System.Int32>)reader[182];
            }
            if(reader[183] != DBNull.Value)
            {
                P038B008 = (System.Nullable<System.Int32>)reader[183];
            }
            if(reader[184] != DBNull.Value)
            {
                P038B009 = (System.Nullable<System.Int32>)reader[184];
            }
            if(reader[185] != DBNull.Value)
            {
                P038B010 = (System.Nullable<System.Int32>)reader[185];
            }
            if(reader[186] != DBNull.Value)
            {
                P038B011 = (System.Nullable<System.Int32>)reader[186];
            }
            if(reader[187] != DBNull.Value)
            {
                P038B012 = (System.Nullable<System.Int32>)reader[187];
            }
            if(reader[188] != DBNull.Value)
            {
                P038B013 = (System.Nullable<System.Int32>)reader[188];
            }
            if(reader[189] != DBNull.Value)
            {
                P038B014 = (System.Nullable<System.Int32>)reader[189];
            }
            if(reader[190] != DBNull.Value)
            {
                P038B015 = (System.Nullable<System.Int32>)reader[190];
            }
            if(reader[191] != DBNull.Value)
            {
                P038B016 = (System.Nullable<System.Int32>)reader[191];
            }
            if(reader[192] != DBNull.Value)
            {
                P038B017 = (System.Nullable<System.Int32>)reader[192];
            }
            if(reader[193] != DBNull.Value)
            {
                P038B018 = (System.Nullable<System.Int32>)reader[193];
            }
            if(reader[194] != DBNull.Value)
            {
                P038B019 = (System.Nullable<System.Int32>)reader[194];
            }
            if(reader[195] != DBNull.Value)
            {
                P038B020 = (System.Nullable<System.Int32>)reader[195];
            }
            if(reader[196] != DBNull.Value)
            {
                P038C001 = (System.Nullable<System.Int32>)reader[196];
            }
            if(reader[197] != DBNull.Value)
            {
                P038C002 = (System.Nullable<System.Int32>)reader[197];
            }
            if(reader[198] != DBNull.Value)
            {
                P038C003 = (System.Nullable<System.Int32>)reader[198];
            }
            if(reader[199] != DBNull.Value)
            {
                P038C004 = (System.Nullable<System.Int32>)reader[199];
            }
            if(reader[200] != DBNull.Value)
            {
                P038C005 = (System.Nullable<System.Int32>)reader[200];
            }
            if(reader[201] != DBNull.Value)
            {
                P038C006 = (System.Nullable<System.Int32>)reader[201];
            }
            if(reader[202] != DBNull.Value)
            {
                P038C007 = (System.Nullable<System.Int32>)reader[202];
            }
            if(reader[203] != DBNull.Value)
            {
                P038C008 = (System.Nullable<System.Int32>)reader[203];
            }
            if(reader[204] != DBNull.Value)
            {
                P038C009 = (System.Nullable<System.Int32>)reader[204];
            }
            if(reader[205] != DBNull.Value)
            {
                P038C010 = (System.Nullable<System.Int32>)reader[205];
            }
            if(reader[206] != DBNull.Value)
            {
                P038C011 = (System.Nullable<System.Int32>)reader[206];
            }
            if(reader[207] != DBNull.Value)
            {
                P038C012 = (System.Nullable<System.Int32>)reader[207];
            }
            if(reader[208] != DBNull.Value)
            {
                P038C013 = (System.Nullable<System.Int32>)reader[208];
            }
            if(reader[209] != DBNull.Value)
            {
                P038C014 = (System.Nullable<System.Int32>)reader[209];
            }
            if(reader[210] != DBNull.Value)
            {
                P038C015 = (System.Nullable<System.Int32>)reader[210];
            }
            if(reader[211] != DBNull.Value)
            {
                P038C016 = (System.Nullable<System.Int32>)reader[211];
            }
            if(reader[212] != DBNull.Value)
            {
                P038C017 = (System.Nullable<System.Int32>)reader[212];
            }
            if(reader[213] != DBNull.Value)
            {
                P038C018 = (System.Nullable<System.Int32>)reader[213];
            }
            if(reader[214] != DBNull.Value)
            {
                P038C019 = (System.Nullable<System.Int32>)reader[214];
            }
            if(reader[215] != DBNull.Value)
            {
                P038C020 = (System.Nullable<System.Int32>)reader[215];
            }
            if(reader[216] != DBNull.Value)
            {
                P038D001 = (System.Nullable<System.Int32>)reader[216];
            }
            if(reader[217] != DBNull.Value)
            {
                P038D002 = (System.Nullable<System.Int32>)reader[217];
            }
            if(reader[218] != DBNull.Value)
            {
                P038D003 = (System.Nullable<System.Int32>)reader[218];
            }
            if(reader[219] != DBNull.Value)
            {
                P038D004 = (System.Nullable<System.Int32>)reader[219];
            }
            if(reader[220] != DBNull.Value)
            {
                P038D005 = (System.Nullable<System.Int32>)reader[220];
            }
            if(reader[221] != DBNull.Value)
            {
                P038D006 = (System.Nullable<System.Int32>)reader[221];
            }
            if(reader[222] != DBNull.Value)
            {
                P038D007 = (System.Nullable<System.Int32>)reader[222];
            }
            if(reader[223] != DBNull.Value)
            {
                P038D008 = (System.Nullable<System.Int32>)reader[223];
            }
            if(reader[224] != DBNull.Value)
            {
                P038D009 = (System.Nullable<System.Int32>)reader[224];
            }
            if(reader[225] != DBNull.Value)
            {
                P038D010 = (System.Nullable<System.Int32>)reader[225];
            }
            if(reader[226] != DBNull.Value)
            {
                P038D011 = (System.Nullable<System.Int32>)reader[226];
            }
            if(reader[227] != DBNull.Value)
            {
                P038D012 = (System.Nullable<System.Int32>)reader[227];
            }
            if(reader[228] != DBNull.Value)
            {
                P038D013 = (System.Nullable<System.Int32>)reader[228];
            }
            if(reader[229] != DBNull.Value)
            {
                P038D014 = (System.Nullable<System.Int32>)reader[229];
            }
            if(reader[230] != DBNull.Value)
            {
                P038D015 = (System.Nullable<System.Int32>)reader[230];
            }
            if(reader[231] != DBNull.Value)
            {
                P038D016 = (System.Nullable<System.Int32>)reader[231];
            }
            if(reader[232] != DBNull.Value)
            {
                P038D017 = (System.Nullable<System.Int32>)reader[232];
            }
            if(reader[233] != DBNull.Value)
            {
                P038D018 = (System.Nullable<System.Int32>)reader[233];
            }
            if(reader[234] != DBNull.Value)
            {
                P038D019 = (System.Nullable<System.Int32>)reader[234];
            }
            if(reader[235] != DBNull.Value)
            {
                P038D020 = (System.Nullable<System.Int32>)reader[235];
            }
            if(reader[236] != DBNull.Value)
            {
                P038E001 = (System.Nullable<System.Int32>)reader[236];
            }
            if(reader[237] != DBNull.Value)
            {
                P038E002 = (System.Nullable<System.Int32>)reader[237];
            }
            if(reader[238] != DBNull.Value)
            {
                P038E003 = (System.Nullable<System.Int32>)reader[238];
            }
            if(reader[239] != DBNull.Value)
            {
                P038E004 = (System.Nullable<System.Int32>)reader[239];
            }
            if(reader[240] != DBNull.Value)
            {
                P038E005 = (System.Nullable<System.Int32>)reader[240];
            }
            if(reader[241] != DBNull.Value)
            {
                P038E006 = (System.Nullable<System.Int32>)reader[241];
            }
            if(reader[242] != DBNull.Value)
            {
                P038E007 = (System.Nullable<System.Int32>)reader[242];
            }
            if(reader[243] != DBNull.Value)
            {
                P038E008 = (System.Nullable<System.Int32>)reader[243];
            }
            if(reader[244] != DBNull.Value)
            {
                P038E009 = (System.Nullable<System.Int32>)reader[244];
            }
            if(reader[245] != DBNull.Value)
            {
                P038E010 = (System.Nullable<System.Int32>)reader[245];
            }
            if(reader[246] != DBNull.Value)
            {
                P038E011 = (System.Nullable<System.Int32>)reader[246];
            }
            if(reader[247] != DBNull.Value)
            {
                P038E012 = (System.Nullable<System.Int32>)reader[247];
            }
            if(reader[248] != DBNull.Value)
            {
                P038E013 = (System.Nullable<System.Int32>)reader[248];
            }
            if(reader[249] != DBNull.Value)
            {
                P038E014 = (System.Nullable<System.Int32>)reader[249];
            }
            if(reader[250] != DBNull.Value)
            {
                P038E015 = (System.Nullable<System.Int32>)reader[250];
            }
            if(reader[251] != DBNull.Value)
            {
                P038E016 = (System.Nullable<System.Int32>)reader[251];
            }
            if(reader[252] != DBNull.Value)
            {
                P038E017 = (System.Nullable<System.Int32>)reader[252];
            }
            if(reader[253] != DBNull.Value)
            {
                P038E018 = (System.Nullable<System.Int32>)reader[253];
            }
            if(reader[254] != DBNull.Value)
            {
                P038E019 = (System.Nullable<System.Int32>)reader[254];
            }
            if(reader[255] != DBNull.Value)
            {
                P038E020 = (System.Nullable<System.Int32>)reader[255];
            }
        }
        #endregion Constructors
    }
}