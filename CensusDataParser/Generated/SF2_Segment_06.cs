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

    [Table("SF2_Segment_06")]
    public partial class SF2_Segment_06 : BaseModel
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
        [Column("PCT0320001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public System.Nullable<System.Int32> PCT0320001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0320002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 6)]
        public System.Nullable<System.Int32> PCT0320002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0320003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 7)]
        public System.Nullable<System.Int32> PCT0320003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0320004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 8)]
        public System.Nullable<System.Int32> PCT0320004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0320005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 9)]
        public System.Nullable<System.Int32> PCT0320005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0320006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 10)]
        public System.Nullable<System.Int32> PCT0320006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0320007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 11)]
        public System.Nullable<System.Int32> PCT0320007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0320008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 12)]
        public System.Nullable<System.Int32> PCT0320008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0320009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 13)]
        public System.Nullable<System.Int32> PCT0320009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0320010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 14)]
        public System.Nullable<System.Int32> PCT0320010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0320011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 15)]
        public System.Nullable<System.Int32> PCT0320011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0320012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 16)]
        public System.Nullable<System.Int32> PCT0320012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0320013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 17)]
        public System.Nullable<System.Int32> PCT0320013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0320014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 18)]
        public System.Nullable<System.Int32> PCT0320014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0320015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 19)]
        public System.Nullable<System.Int32> PCT0320015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0320016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 20)]
        public System.Nullable<System.Int32> PCT0320016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0320017", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 21)]
        public System.Nullable<System.Int32> PCT0320017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0320018", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 22)]
        public System.Nullable<System.Int32> PCT0320018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0320019", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 23)]
        public System.Nullable<System.Int32> PCT0320019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0320020", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 24)]
        public System.Nullable<System.Int32> PCT0320020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0330001", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 25)]
        public System.Nullable<System.Int32> PCT0330001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0330002", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 26)]
        public System.Nullable<System.Int32> PCT0330002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0330003", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 27)]
        public System.Nullable<System.Int32> PCT0330003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0330004", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 28)]
        public System.Nullable<System.Int32> PCT0330004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0330005", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 29)]
        public System.Nullable<System.Int32> PCT0330005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0330006", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 30)]
        public System.Nullable<System.Int32> PCT0330006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0330007", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 31)]
        public System.Nullable<System.Int32> PCT0330007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0330008", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 32)]
        public System.Nullable<System.Int32> PCT0330008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0330009", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 33)]
        public System.Nullable<System.Int32> PCT0330009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0330010", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 34)]
        public System.Nullable<System.Int32> PCT0330010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0330011", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 35)]
        public System.Nullable<System.Int32> PCT0330011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0330012", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 36)]
        public System.Nullable<System.Int32> PCT0330012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0330013", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 37)]
        public System.Nullable<System.Int32> PCT0330013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0330014", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 38)]
        public System.Nullable<System.Int32> PCT0330014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0330015", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 39)]
        public System.Nullable<System.Int32> PCT0330015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0330016", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 40)]
        public System.Nullable<System.Int32> PCT0330016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0330017", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 41)]
        public System.Nullable<System.Int32> PCT0330017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0330018", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 42)]
        public System.Nullable<System.Int32> PCT0330018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0330019", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 43)]
        public System.Nullable<System.Int32> PCT0330019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0330020", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 44)]
        public System.Nullable<System.Int32> PCT0330020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0340001", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 45)]
        public System.Nullable<System.Int32> PCT0340001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0340002", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In husband-wife families:", ShortName = "In husband-wife families:", Order = 46)]
        public System.Nullable<System.Int32> PCT0340002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0340003", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 47)]
        public System.Nullable<System.Int32> PCT0340003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0340004", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 48)]
        public System.Nullable<System.Int32> PCT0340004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0340005", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 49)]
        public System.Nullable<System.Int32> PCT0340005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0340006", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 50)]
        public System.Nullable<System.Int32> PCT0340006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0340007", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 to 17 years", ShortName = "12 to 17 years", Order = 51)]
        public System.Nullable<System.Int32> PCT0340007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0340008", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In other families:", ShortName = "In other families:", Order = 52)]
        public System.Nullable<System.Int32> PCT0340008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0340009", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In male householder, no wife present family:", ShortName = "In male householder, no wife present family:", Order = 53)]
        public System.Nullable<System.Int32> PCT0340009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0340010", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 54)]
        public System.Nullable<System.Int32> PCT0340010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0340011", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 55)]
        public System.Nullable<System.Int32> PCT0340011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0340012", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 56)]
        public System.Nullable<System.Int32> PCT0340012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0340013", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 57)]
        public System.Nullable<System.Int32> PCT0340013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0340014", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 to 17 years", ShortName = "12 to 17 years", Order = 58)]
        public System.Nullable<System.Int32> PCT0340014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0340015", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In female householder, no husband present family:", ShortName = "In female householder, no husband present family:", Order = 59)]
        public System.Nullable<System.Int32> PCT0340015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0340016", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 60)]
        public System.Nullable<System.Int32> PCT0340016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0340017", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 61)]
        public System.Nullable<System.Int32> PCT0340017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0340018", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 62)]
        public System.Nullable<System.Int32> PCT0340018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0340019", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 63)]
        public System.Nullable<System.Int32> PCT0340019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0340020", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 to 17 years", ShortName = "12 to 17 years", Order = 64)]
        public System.Nullable<System.Int32> PCT0340020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0350001", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 65)]
        public System.Nullable<System.Int32> PCT0350001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0350002", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 66)]
        public System.Nullable<System.Int32> PCT0350002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0350003", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 67)]
        public System.Nullable<System.Int32> PCT0350003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0350004", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 68)]
        public System.Nullable<System.Int32> PCT0350004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0350005", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 69)]
        public System.Nullable<System.Int32> PCT0350005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0350006", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 to 17 years", ShortName = "12 to 17 years", Order = 70)]
        public System.Nullable<System.Int32> PCT0350006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0360001", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 71)]
        public System.Nullable<System.Int32> PCT0360001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0360002", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 72)]
        public System.Nullable<System.Int32> PCT0360002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0360003", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone:", ShortName = "Living alone:", Order = 73)]
        public System.Nullable<System.Int32> PCT0360003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0360004", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 64 years", ShortName = "Householder 15 to 64 years", Order = 74)]
        public System.Nullable<System.Int32> PCT0360004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0360005", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 75)]
        public System.Nullable<System.Int32> PCT0360005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0360006", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 76)]
        public System.Nullable<System.Int32> PCT0360006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0360007", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 64 years", ShortName = "Householder 15 to 64 years", Order = 77)]
        public System.Nullable<System.Int32> PCT0360007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0360008", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 78)]
        public System.Nullable<System.Int32> PCT0360008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0360009", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 79)]
        public System.Nullable<System.Int32> PCT0360009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0360010", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone:", ShortName = "Living alone:", Order = 80)]
        public System.Nullable<System.Int32> PCT0360010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0360011", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 64 years", ShortName = "Householder 15 to 64 years", Order = 81)]
        public System.Nullable<System.Int32> PCT0360011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0360012", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 82)]
        public System.Nullable<System.Int32> PCT0360012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0360013", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 83)]
        public System.Nullable<System.Int32> PCT0360013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0360014", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 64 years", ShortName = "Householder 15 to 64 years", Order = 84)]
        public System.Nullable<System.Int32> PCT0360014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0360015", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 85)]
        public System.Nullable<System.Int32> PCT0360015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0370001", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 86)]
        public System.Nullable<System.Int32> PCT0370001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0370002", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 87)]
        public System.Nullable<System.Int32> PCT0370002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0370003", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 88)]
        public System.Nullable<System.Int32> PCT0370003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0370004", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 89)]
        public System.Nullable<System.Int32> PCT0370004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0370005", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 90)]
        public System.Nullable<System.Int32> PCT0370005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0370006", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 91)]
        public System.Nullable<System.Int32> PCT0370006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0370007", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 92)]
        public System.Nullable<System.Int32> PCT0370007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0370008", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 93)]
        public System.Nullable<System.Int32> PCT0370008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0370009", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 94)]
        public System.Nullable<System.Int32> PCT0370009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0370010", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 95)]
        public System.Nullable<System.Int32> PCT0370010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0370011", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 96)]
        public System.Nullable<System.Int32> PCT0370011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0001", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 97)]
        public System.Nullable<System.Int32> PCT038_0001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0002", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 98)]
        public System.Nullable<System.Int32> PCT038_0002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0003", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 99)]
        public System.Nullable<System.Int32> PCT038_0003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0004", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 100)]
        public System.Nullable<System.Int32> PCT038_0004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0005", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 101)]
        public System.Nullable<System.Int32> PCT038_0005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0006", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 102)]
        public System.Nullable<System.Int32> PCT038_0006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0007", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 103)]
        public System.Nullable<System.Int32> PCT038_0007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0008", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 104)]
        public System.Nullable<System.Int32> PCT038_0008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0009", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 105)]
        public System.Nullable<System.Int32> PCT038_0009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0010", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 106)]
        public System.Nullable<System.Int32> PCT038_0010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0011", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 107)]
        public System.Nullable<System.Int32> PCT038_0011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0012", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 108)]
        public System.Nullable<System.Int32> PCT038_0012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0013", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 109)]
        public System.Nullable<System.Int32> PCT038_0013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0014", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 110)]
        public System.Nullable<System.Int32> PCT038_0014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0015", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 111)]
        public System.Nullable<System.Int32> PCT038_0015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0016", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 112)]
        public System.Nullable<System.Int32> PCT038_0016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0017", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 113)]
        public System.Nullable<System.Int32> PCT038_0017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0018", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 114)]
        public System.Nullable<System.Int32> PCT038_0018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0019", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 115)]
        public System.Nullable<System.Int32> PCT038_0019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0020", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 116)]
        public System.Nullable<System.Int32> PCT038_0020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0021", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 117)]
        public System.Nullable<System.Int32> PCT038_0021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0022", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 118)]
        public System.Nullable<System.Int32> PCT038_0022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0023", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 119)]
        public System.Nullable<System.Int32> PCT038_0023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0024", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 120)]
        public System.Nullable<System.Int32> PCT038_0024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0025", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 121)]
        public System.Nullable<System.Int32> PCT038_0025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0026", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 122)]
        public System.Nullable<System.Int32> PCT038_0026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0027", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 123)]
        public System.Nullable<System.Int32> PCT038_0027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0028", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 124)]
        public System.Nullable<System.Int32> PCT038_0028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0029", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 125)]
        public System.Nullable<System.Int32> PCT038_0029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0030", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 126)]
        public System.Nullable<System.Int32> PCT038_0030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0031", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 127)]
        public System.Nullable<System.Int32> PCT038_0031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT038_0032", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 128)]
        public System.Nullable<System.Int32> PCT038_0032 { get; set; }
        #endregion Properties

        #region Constructors
        public SF2_Segment_06(string csvLine) : base(csvLine) {}

        public SF2_Segment_06(string[] values) : base(values) {}

        public SF2_Segment_06(OleDbDataReader reader, CensusFileType fileType)
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
                PCT0320001 = (System.Nullable<System.Int32>)reader[5];
            }
            if(reader[6] != DBNull.Value)
            {
                PCT0320002 = (System.Nullable<System.Int32>)reader[6];
            }
            if(reader[7] != DBNull.Value)
            {
                PCT0320003 = (System.Nullable<System.Int32>)reader[7];
            }
            if(reader[8] != DBNull.Value)
            {
                PCT0320004 = (System.Nullable<System.Int32>)reader[8];
            }
            if(reader[9] != DBNull.Value)
            {
                PCT0320005 = (System.Nullable<System.Int32>)reader[9];
            }
            if(reader[10] != DBNull.Value)
            {
                PCT0320006 = (System.Nullable<System.Int32>)reader[10];
            }
            if(reader[11] != DBNull.Value)
            {
                PCT0320007 = (System.Nullable<System.Int32>)reader[11];
            }
            if(reader[12] != DBNull.Value)
            {
                PCT0320008 = (System.Nullable<System.Int32>)reader[12];
            }
            if(reader[13] != DBNull.Value)
            {
                PCT0320009 = (System.Nullable<System.Int32>)reader[13];
            }
            if(reader[14] != DBNull.Value)
            {
                PCT0320010 = (System.Nullable<System.Int32>)reader[14];
            }
            if(reader[15] != DBNull.Value)
            {
                PCT0320011 = (System.Nullable<System.Int32>)reader[15];
            }
            if(reader[16] != DBNull.Value)
            {
                PCT0320012 = (System.Nullable<System.Int32>)reader[16];
            }
            if(reader[17] != DBNull.Value)
            {
                PCT0320013 = (System.Nullable<System.Int32>)reader[17];
            }
            if(reader[18] != DBNull.Value)
            {
                PCT0320014 = (System.Nullable<System.Int32>)reader[18];
            }
            if(reader[19] != DBNull.Value)
            {
                PCT0320015 = (System.Nullable<System.Int32>)reader[19];
            }
            if(reader[20] != DBNull.Value)
            {
                PCT0320016 = (System.Nullable<System.Int32>)reader[20];
            }
            if(reader[21] != DBNull.Value)
            {
                PCT0320017 = (System.Nullable<System.Int32>)reader[21];
            }
            if(reader[22] != DBNull.Value)
            {
                PCT0320018 = (System.Nullable<System.Int32>)reader[22];
            }
            if(reader[23] != DBNull.Value)
            {
                PCT0320019 = (System.Nullable<System.Int32>)reader[23];
            }
            if(reader[24] != DBNull.Value)
            {
                PCT0320020 = (System.Nullable<System.Int32>)reader[24];
            }
            if(reader[25] != DBNull.Value)
            {
                PCT0330001 = (System.Nullable<System.Int32>)reader[25];
            }
            if(reader[26] != DBNull.Value)
            {
                PCT0330002 = (System.Nullable<System.Int32>)reader[26];
            }
            if(reader[27] != DBNull.Value)
            {
                PCT0330003 = (System.Nullable<System.Int32>)reader[27];
            }
            if(reader[28] != DBNull.Value)
            {
                PCT0330004 = (System.Nullable<System.Int32>)reader[28];
            }
            if(reader[29] != DBNull.Value)
            {
                PCT0330005 = (System.Nullable<System.Int32>)reader[29];
            }
            if(reader[30] != DBNull.Value)
            {
                PCT0330006 = (System.Nullable<System.Int32>)reader[30];
            }
            if(reader[31] != DBNull.Value)
            {
                PCT0330007 = (System.Nullable<System.Int32>)reader[31];
            }
            if(reader[32] != DBNull.Value)
            {
                PCT0330008 = (System.Nullable<System.Int32>)reader[32];
            }
            if(reader[33] != DBNull.Value)
            {
                PCT0330009 = (System.Nullable<System.Int32>)reader[33];
            }
            if(reader[34] != DBNull.Value)
            {
                PCT0330010 = (System.Nullable<System.Int32>)reader[34];
            }
            if(reader[35] != DBNull.Value)
            {
                PCT0330011 = (System.Nullable<System.Int32>)reader[35];
            }
            if(reader[36] != DBNull.Value)
            {
                PCT0330012 = (System.Nullable<System.Int32>)reader[36];
            }
            if(reader[37] != DBNull.Value)
            {
                PCT0330013 = (System.Nullable<System.Int32>)reader[37];
            }
            if(reader[38] != DBNull.Value)
            {
                PCT0330014 = (System.Nullable<System.Int32>)reader[38];
            }
            if(reader[39] != DBNull.Value)
            {
                PCT0330015 = (System.Nullable<System.Int32>)reader[39];
            }
            if(reader[40] != DBNull.Value)
            {
                PCT0330016 = (System.Nullable<System.Int32>)reader[40];
            }
            if(reader[41] != DBNull.Value)
            {
                PCT0330017 = (System.Nullable<System.Int32>)reader[41];
            }
            if(reader[42] != DBNull.Value)
            {
                PCT0330018 = (System.Nullable<System.Int32>)reader[42];
            }
            if(reader[43] != DBNull.Value)
            {
                PCT0330019 = (System.Nullable<System.Int32>)reader[43];
            }
            if(reader[44] != DBNull.Value)
            {
                PCT0330020 = (System.Nullable<System.Int32>)reader[44];
            }
            if(reader[45] != DBNull.Value)
            {
                PCT0340001 = (System.Nullable<System.Int32>)reader[45];
            }
            if(reader[46] != DBNull.Value)
            {
                PCT0340002 = (System.Nullable<System.Int32>)reader[46];
            }
            if(reader[47] != DBNull.Value)
            {
                PCT0340003 = (System.Nullable<System.Int32>)reader[47];
            }
            if(reader[48] != DBNull.Value)
            {
                PCT0340004 = (System.Nullable<System.Int32>)reader[48];
            }
            if(reader[49] != DBNull.Value)
            {
                PCT0340005 = (System.Nullable<System.Int32>)reader[49];
            }
            if(reader[50] != DBNull.Value)
            {
                PCT0340006 = (System.Nullable<System.Int32>)reader[50];
            }
            if(reader[51] != DBNull.Value)
            {
                PCT0340007 = (System.Nullable<System.Int32>)reader[51];
            }
            if(reader[52] != DBNull.Value)
            {
                PCT0340008 = (System.Nullable<System.Int32>)reader[52];
            }
            if(reader[53] != DBNull.Value)
            {
                PCT0340009 = (System.Nullable<System.Int32>)reader[53];
            }
            if(reader[54] != DBNull.Value)
            {
                PCT0340010 = (System.Nullable<System.Int32>)reader[54];
            }
            if(reader[55] != DBNull.Value)
            {
                PCT0340011 = (System.Nullable<System.Int32>)reader[55];
            }
            if(reader[56] != DBNull.Value)
            {
                PCT0340012 = (System.Nullable<System.Int32>)reader[56];
            }
            if(reader[57] != DBNull.Value)
            {
                PCT0340013 = (System.Nullable<System.Int32>)reader[57];
            }
            if(reader[58] != DBNull.Value)
            {
                PCT0340014 = (System.Nullable<System.Int32>)reader[58];
            }
            if(reader[59] != DBNull.Value)
            {
                PCT0340015 = (System.Nullable<System.Int32>)reader[59];
            }
            if(reader[60] != DBNull.Value)
            {
                PCT0340016 = (System.Nullable<System.Int32>)reader[60];
            }
            if(reader[61] != DBNull.Value)
            {
                PCT0340017 = (System.Nullable<System.Int32>)reader[61];
            }
            if(reader[62] != DBNull.Value)
            {
                PCT0340018 = (System.Nullable<System.Int32>)reader[62];
            }
            if(reader[63] != DBNull.Value)
            {
                PCT0340019 = (System.Nullable<System.Int32>)reader[63];
            }
            if(reader[64] != DBNull.Value)
            {
                PCT0340020 = (System.Nullable<System.Int32>)reader[64];
            }
            if(reader[65] != DBNull.Value)
            {
                PCT0350001 = (System.Nullable<System.Int32>)reader[65];
            }
            if(reader[66] != DBNull.Value)
            {
                PCT0350002 = (System.Nullable<System.Int32>)reader[66];
            }
            if(reader[67] != DBNull.Value)
            {
                PCT0350003 = (System.Nullable<System.Int32>)reader[67];
            }
            if(reader[68] != DBNull.Value)
            {
                PCT0350004 = (System.Nullable<System.Int32>)reader[68];
            }
            if(reader[69] != DBNull.Value)
            {
                PCT0350005 = (System.Nullable<System.Int32>)reader[69];
            }
            if(reader[70] != DBNull.Value)
            {
                PCT0350006 = (System.Nullable<System.Int32>)reader[70];
            }
            if(reader[71] != DBNull.Value)
            {
                PCT0360001 = (System.Nullable<System.Int32>)reader[71];
            }
            if(reader[72] != DBNull.Value)
            {
                PCT0360002 = (System.Nullable<System.Int32>)reader[72];
            }
            if(reader[73] != DBNull.Value)
            {
                PCT0360003 = (System.Nullable<System.Int32>)reader[73];
            }
            if(reader[74] != DBNull.Value)
            {
                PCT0360004 = (System.Nullable<System.Int32>)reader[74];
            }
            if(reader[75] != DBNull.Value)
            {
                PCT0360005 = (System.Nullable<System.Int32>)reader[75];
            }
            if(reader[76] != DBNull.Value)
            {
                PCT0360006 = (System.Nullable<System.Int32>)reader[76];
            }
            if(reader[77] != DBNull.Value)
            {
                PCT0360007 = (System.Nullable<System.Int32>)reader[77];
            }
            if(reader[78] != DBNull.Value)
            {
                PCT0360008 = (System.Nullable<System.Int32>)reader[78];
            }
            if(reader[79] != DBNull.Value)
            {
                PCT0360009 = (System.Nullable<System.Int32>)reader[79];
            }
            if(reader[80] != DBNull.Value)
            {
                PCT0360010 = (System.Nullable<System.Int32>)reader[80];
            }
            if(reader[81] != DBNull.Value)
            {
                PCT0360011 = (System.Nullable<System.Int32>)reader[81];
            }
            if(reader[82] != DBNull.Value)
            {
                PCT0360012 = (System.Nullable<System.Int32>)reader[82];
            }
            if(reader[83] != DBNull.Value)
            {
                PCT0360013 = (System.Nullable<System.Int32>)reader[83];
            }
            if(reader[84] != DBNull.Value)
            {
                PCT0360014 = (System.Nullable<System.Int32>)reader[84];
            }
            if(reader[85] != DBNull.Value)
            {
                PCT0360015 = (System.Nullable<System.Int32>)reader[85];
            }
            if(reader[86] != DBNull.Value)
            {
                PCT0370001 = (System.Nullable<System.Int32>)reader[86];
            }
            if(reader[87] != DBNull.Value)
            {
                PCT0370002 = (System.Nullable<System.Int32>)reader[87];
            }
            if(reader[88] != DBNull.Value)
            {
                PCT0370003 = (System.Nullable<System.Int32>)reader[88];
            }
            if(reader[89] != DBNull.Value)
            {
                PCT0370004 = (System.Nullable<System.Int32>)reader[89];
            }
            if(reader[90] != DBNull.Value)
            {
                PCT0370005 = (System.Nullable<System.Int32>)reader[90];
            }
            if(reader[91] != DBNull.Value)
            {
                PCT0370006 = (System.Nullable<System.Int32>)reader[91];
            }
            if(reader[92] != DBNull.Value)
            {
                PCT0370007 = (System.Nullable<System.Int32>)reader[92];
            }
            if(reader[93] != DBNull.Value)
            {
                PCT0370008 = (System.Nullable<System.Int32>)reader[93];
            }
            if(reader[94] != DBNull.Value)
            {
                PCT0370009 = (System.Nullable<System.Int32>)reader[94];
            }
            if(reader[95] != DBNull.Value)
            {
                PCT0370010 = (System.Nullable<System.Int32>)reader[95];
            }
            if(reader[96] != DBNull.Value)
            {
                PCT0370011 = (System.Nullable<System.Int32>)reader[96];
            }
            if(reader[97] != DBNull.Value)
            {
                PCT038_0001 = (System.Nullable<System.Int32>)reader[97];
            }
            if(reader[98] != DBNull.Value)
            {
                PCT038_0002 = (System.Nullable<System.Int32>)reader[98];
            }
            if(reader[99] != DBNull.Value)
            {
                PCT038_0003 = (System.Nullable<System.Int32>)reader[99];
            }
            if(reader[100] != DBNull.Value)
            {
                PCT038_0004 = (System.Nullable<System.Int32>)reader[100];
            }
            if(reader[101] != DBNull.Value)
            {
                PCT038_0005 = (System.Nullable<System.Int32>)reader[101];
            }
            if(reader[102] != DBNull.Value)
            {
                PCT038_0006 = (System.Nullable<System.Int32>)reader[102];
            }
            if(reader[103] != DBNull.Value)
            {
                PCT038_0007 = (System.Nullable<System.Int32>)reader[103];
            }
            if(reader[104] != DBNull.Value)
            {
                PCT038_0008 = (System.Nullable<System.Int32>)reader[104];
            }
            if(reader[105] != DBNull.Value)
            {
                PCT038_0009 = (System.Nullable<System.Int32>)reader[105];
            }
            if(reader[106] != DBNull.Value)
            {
                PCT038_0010 = (System.Nullable<System.Int32>)reader[106];
            }
            if(reader[107] != DBNull.Value)
            {
                PCT038_0011 = (System.Nullable<System.Int32>)reader[107];
            }
            if(reader[108] != DBNull.Value)
            {
                PCT038_0012 = (System.Nullable<System.Int32>)reader[108];
            }
            if(reader[109] != DBNull.Value)
            {
                PCT038_0013 = (System.Nullable<System.Int32>)reader[109];
            }
            if(reader[110] != DBNull.Value)
            {
                PCT038_0014 = (System.Nullable<System.Int32>)reader[110];
            }
            if(reader[111] != DBNull.Value)
            {
                PCT038_0015 = (System.Nullable<System.Int32>)reader[111];
            }
            if(reader[112] != DBNull.Value)
            {
                PCT038_0016 = (System.Nullable<System.Int32>)reader[112];
            }
            if(reader[113] != DBNull.Value)
            {
                PCT038_0017 = (System.Nullable<System.Int32>)reader[113];
            }
            if(reader[114] != DBNull.Value)
            {
                PCT038_0018 = (System.Nullable<System.Int32>)reader[114];
            }
            if(reader[115] != DBNull.Value)
            {
                PCT038_0019 = (System.Nullable<System.Int32>)reader[115];
            }
            if(reader[116] != DBNull.Value)
            {
                PCT038_0020 = (System.Nullable<System.Int32>)reader[116];
            }
            if(reader[117] != DBNull.Value)
            {
                PCT038_0021 = (System.Nullable<System.Int32>)reader[117];
            }
            if(reader[118] != DBNull.Value)
            {
                PCT038_0022 = (System.Nullable<System.Int32>)reader[118];
            }
            if(reader[119] != DBNull.Value)
            {
                PCT038_0023 = (System.Nullable<System.Int32>)reader[119];
            }
            if(reader[120] != DBNull.Value)
            {
                PCT038_0024 = (System.Nullable<System.Int32>)reader[120];
            }
            if(reader[121] != DBNull.Value)
            {
                PCT038_0025 = (System.Nullable<System.Int32>)reader[121];
            }
            if(reader[122] != DBNull.Value)
            {
                PCT038_0026 = (System.Nullable<System.Int32>)reader[122];
            }
            if(reader[123] != DBNull.Value)
            {
                PCT038_0027 = (System.Nullable<System.Int32>)reader[123];
            }
            if(reader[124] != DBNull.Value)
            {
                PCT038_0028 = (System.Nullable<System.Int32>)reader[124];
            }
            if(reader[125] != DBNull.Value)
            {
                PCT038_0029 = (System.Nullable<System.Int32>)reader[125];
            }
            if(reader[126] != DBNull.Value)
            {
                PCT038_0030 = (System.Nullable<System.Int32>)reader[126];
            }
            if(reader[127] != DBNull.Value)
            {
                PCT038_0031 = (System.Nullable<System.Int32>)reader[127];
            }
            if(reader[128] != DBNull.Value)
            {
                PCT038_0032 = (System.Nullable<System.Int32>)reader[128];
            }
        }
        #endregion Constructors
    }
}