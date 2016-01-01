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

    [Table("SF1_00009")]
    public partial class SF1_00009 : BaseModel
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
        [Column("P017B001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public System.Nullable<System.Double> P017B001 { get; set; }

        [ReadOnly(false)]
        [Column("P017B002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 6)]
        public System.Nullable<System.Double> P017B002 { get; set; }

        [ReadOnly(false)]
        [Column("P017B003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 7)]
        public System.Nullable<System.Double> P017B003 { get; set; }

        [ReadOnly(false)]
        [Column("P017C001", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 8)]
        public System.Nullable<System.Double> P017C001 { get; set; }

        [ReadOnly(false)]
        [Column("P017C002", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 9)]
        public System.Nullable<System.Double> P017C002 { get; set; }

        [ReadOnly(false)]
        [Column("P017C003", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 10)]
        public System.Nullable<System.Double> P017C003 { get; set; }

        [ReadOnly(false)]
        [Column("P017D001", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 11)]
        public System.Nullable<System.Double> P017D001 { get; set; }

        [ReadOnly(false)]
        [Column("P017D002", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 12)]
        public System.Nullable<System.Double> P017D002 { get; set; }

        [ReadOnly(false)]
        [Column("P017D003", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 13)]
        public System.Nullable<System.Double> P017D003 { get; set; }

        [ReadOnly(false)]
        [Column("P017E001", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 14)]
        public System.Nullable<System.Double> P017E001 { get; set; }

        [ReadOnly(false)]
        [Column("P017E002", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 15)]
        public System.Nullable<System.Double> P017E002 { get; set; }

        [ReadOnly(false)]
        [Column("P017E003", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 16)]
        public System.Nullable<System.Double> P017E003 { get; set; }

        [ReadOnly(false)]
        [Column("P017F001", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 17)]
        public System.Nullable<System.Double> P017F001 { get; set; }

        [ReadOnly(false)]
        [Column("P017F002", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 18)]
        public System.Nullable<System.Double> P017F002 { get; set; }

        [ReadOnly(false)]
        [Column("P017F003", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 19)]
        public System.Nullable<System.Double> P017F003 { get; set; }

        [ReadOnly(false)]
        [Column("P017G001", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 20)]
        public System.Nullable<System.Double> P017G001 { get; set; }

        [ReadOnly(false)]
        [Column("P017G002", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 21)]
        public System.Nullable<System.Double> P017G002 { get; set; }

        [ReadOnly(false)]
        [Column("P017G003", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 22)]
        public System.Nullable<System.Double> P017G003 { get; set; }

        [ReadOnly(false)]
        [Column("P017H001", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 23)]
        public System.Nullable<System.Double> P017H001 { get; set; }

        [ReadOnly(false)]
        [Column("P017H002", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 24)]
        public System.Nullable<System.Double> P017H002 { get; set; }

        [ReadOnly(false)]
        [Column("P017H003", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 25)]
        public System.Nullable<System.Double> P017H003 { get; set; }

        [ReadOnly(false)]
        [Column("P017I001", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 26)]
        public System.Nullable<System.Double> P017I001 { get; set; }

        [ReadOnly(false)]
        [Column("P017I002", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 27)]
        public System.Nullable<System.Double> P017I002 { get; set; }

        [ReadOnly(false)]
        [Column("P017I003", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 28)]
        public System.Nullable<System.Double> P017I003 { get; set; }

        [ReadOnly(false)]
        [Column("P018A001", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 29)]
        public System.Nullable<System.Int32> P018A001 { get; set; }

        [ReadOnly(false)]
        [Column("P018A002", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 30)]
        public System.Nullable<System.Int32> P018A002 { get; set; }

        [ReadOnly(false)]
        [Column("P018A003", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 31)]
        public System.Nullable<System.Int32> P018A003 { get; set; }

        [ReadOnly(false)]
        [Column("P018A004", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 32)]
        public System.Nullable<System.Int32> P018A004 { get; set; }

        [ReadOnly(false)]
        [Column("P018A005", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 33)]
        public System.Nullable<System.Int32> P018A005 { get; set; }

        [ReadOnly(false)]
        [Column("P018A006", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 34)]
        public System.Nullable<System.Int32> P018A006 { get; set; }

        [ReadOnly(false)]
        [Column("P018A007", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 35)]
        public System.Nullable<System.Int32> P018A007 { get; set; }

        [ReadOnly(false)]
        [Column("P018A008", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 36)]
        public System.Nullable<System.Int32> P018A008 { get; set; }

        [ReadOnly(false)]
        [Column("P018A009", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 37)]
        public System.Nullable<System.Int32> P018A009 { get; set; }

        [ReadOnly(false)]
        [Column("P018B001", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 38)]
        public System.Nullable<System.Int32> P018B001 { get; set; }

        [ReadOnly(false)]
        [Column("P018B002", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 39)]
        public System.Nullable<System.Int32> P018B002 { get; set; }

        [ReadOnly(false)]
        [Column("P018B003", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 40)]
        public System.Nullable<System.Int32> P018B003 { get; set; }

        [ReadOnly(false)]
        [Column("P018B004", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 41)]
        public System.Nullable<System.Int32> P018B004 { get; set; }

        [ReadOnly(false)]
        [Column("P018B005", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 42)]
        public System.Nullable<System.Int32> P018B005 { get; set; }

        [ReadOnly(false)]
        [Column("P018B006", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 43)]
        public System.Nullable<System.Int32> P018B006 { get; set; }

        [ReadOnly(false)]
        [Column("P018B007", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 44)]
        public System.Nullable<System.Int32> P018B007 { get; set; }

        [ReadOnly(false)]
        [Column("P018B008", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 45)]
        public System.Nullable<System.Int32> P018B008 { get; set; }

        [ReadOnly(false)]
        [Column("P018B009", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 46)]
        public System.Nullable<System.Int32> P018B009 { get; set; }

        [ReadOnly(false)]
        [Column("P018C001", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 47)]
        public System.Nullable<System.Int32> P018C001 { get; set; }

        [ReadOnly(false)]
        [Column("P018C002", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 48)]
        public System.Nullable<System.Int32> P018C002 { get; set; }

        [ReadOnly(false)]
        [Column("P018C003", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 49)]
        public System.Nullable<System.Int32> P018C003 { get; set; }

        [ReadOnly(false)]
        [Column("P018C004", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 50)]
        public System.Nullable<System.Int32> P018C004 { get; set; }

        [ReadOnly(false)]
        [Column("P018C005", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 51)]
        public System.Nullable<System.Int32> P018C005 { get; set; }

        [ReadOnly(false)]
        [Column("P018C006", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 52)]
        public System.Nullable<System.Int32> P018C006 { get; set; }

        [ReadOnly(false)]
        [Column("P018C007", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 53)]
        public System.Nullable<System.Int32> P018C007 { get; set; }

        [ReadOnly(false)]
        [Column("P018C008", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 54)]
        public System.Nullable<System.Int32> P018C008 { get; set; }

        [ReadOnly(false)]
        [Column("P018C009", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 55)]
        public System.Nullable<System.Int32> P018C009 { get; set; }

        [ReadOnly(false)]
        [Column("P018D001", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 56)]
        public System.Nullable<System.Int32> P018D001 { get; set; }

        [ReadOnly(false)]
        [Column("P018D002", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 57)]
        public System.Nullable<System.Int32> P018D002 { get; set; }

        [ReadOnly(false)]
        [Column("P018D003", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 58)]
        public System.Nullable<System.Int32> P018D003 { get; set; }

        [ReadOnly(false)]
        [Column("P018D004", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 59)]
        public System.Nullable<System.Int32> P018D004 { get; set; }

        [ReadOnly(false)]
        [Column("P018D005", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 60)]
        public System.Nullable<System.Int32> P018D005 { get; set; }

        [ReadOnly(false)]
        [Column("P018D006", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 61)]
        public System.Nullable<System.Int32> P018D006 { get; set; }

        [ReadOnly(false)]
        [Column("P018D007", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 62)]
        public System.Nullable<System.Int32> P018D007 { get; set; }

        [ReadOnly(false)]
        [Column("P018D008", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 63)]
        public System.Nullable<System.Int32> P018D008 { get; set; }

        [ReadOnly(false)]
        [Column("P018D009", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 64)]
        public System.Nullable<System.Int32> P018D009 { get; set; }

        [ReadOnly(false)]
        [Column("P018E001", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 65)]
        public System.Nullable<System.Int32> P018E001 { get; set; }

        [ReadOnly(false)]
        [Column("P018E002", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 66)]
        public System.Nullable<System.Int32> P018E002 { get; set; }

        [ReadOnly(false)]
        [Column("P018E003", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 67)]
        public System.Nullable<System.Int32> P018E003 { get; set; }

        [ReadOnly(false)]
        [Column("P018E004", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 68)]
        public System.Nullable<System.Int32> P018E004 { get; set; }

        [ReadOnly(false)]
        [Column("P018E005", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 69)]
        public System.Nullable<System.Int32> P018E005 { get; set; }

        [ReadOnly(false)]
        [Column("P018E006", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 70)]
        public System.Nullable<System.Int32> P018E006 { get; set; }

        [ReadOnly(false)]
        [Column("P018E007", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 71)]
        public System.Nullable<System.Int32> P018E007 { get; set; }

        [ReadOnly(false)]
        [Column("P018E008", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 72)]
        public System.Nullable<System.Int32> P018E008 { get; set; }

        [ReadOnly(false)]
        [Column("P018E009", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 73)]
        public System.Nullable<System.Int32> P018E009 { get; set; }

        [ReadOnly(false)]
        [Column("P018F001", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 74)]
        public System.Nullable<System.Int32> P018F001 { get; set; }

        [ReadOnly(false)]
        [Column("P018F002", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 75)]
        public System.Nullable<System.Int32> P018F002 { get; set; }

        [ReadOnly(false)]
        [Column("P018F003", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 76)]
        public System.Nullable<System.Int32> P018F003 { get; set; }

        [ReadOnly(false)]
        [Column("P018F004", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 77)]
        public System.Nullable<System.Int32> P018F004 { get; set; }

        [ReadOnly(false)]
        [Column("P018F005", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 78)]
        public System.Nullable<System.Int32> P018F005 { get; set; }

        [ReadOnly(false)]
        [Column("P018F006", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 79)]
        public System.Nullable<System.Int32> P018F006 { get; set; }

        [ReadOnly(false)]
        [Column("P018F007", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 80)]
        public System.Nullable<System.Int32> P018F007 { get; set; }

        [ReadOnly(false)]
        [Column("P018F008", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 81)]
        public System.Nullable<System.Int32> P018F008 { get; set; }

        [ReadOnly(false)]
        [Column("P018F009", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 82)]
        public System.Nullable<System.Int32> P018F009 { get; set; }

        [ReadOnly(false)]
        [Column("P018G001", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 83)]
        public System.Nullable<System.Int32> P018G001 { get; set; }

        [ReadOnly(false)]
        [Column("P018G002", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 84)]
        public System.Nullable<System.Int32> P018G002 { get; set; }

        [ReadOnly(false)]
        [Column("P018G003", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 85)]
        public System.Nullable<System.Int32> P018G003 { get; set; }

        [ReadOnly(false)]
        [Column("P018G004", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 86)]
        public System.Nullable<System.Int32> P018G004 { get; set; }

        [ReadOnly(false)]
        [Column("P018G005", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 87)]
        public System.Nullable<System.Int32> P018G005 { get; set; }

        [ReadOnly(false)]
        [Column("P018G006", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 88)]
        public System.Nullable<System.Int32> P018G006 { get; set; }

        [ReadOnly(false)]
        [Column("P018G007", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 89)]
        public System.Nullable<System.Int32> P018G007 { get; set; }

        [ReadOnly(false)]
        [Column("P018G008", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 90)]
        public System.Nullable<System.Int32> P018G008 { get; set; }

        [ReadOnly(false)]
        [Column("P018G009", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 91)]
        public System.Nullable<System.Int32> P018G009 { get; set; }

        [ReadOnly(false)]
        [Column("P018H001", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 92)]
        public System.Nullable<System.Int32> P018H001 { get; set; }

        [ReadOnly(false)]
        [Column("P018H002", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 93)]
        public System.Nullable<System.Int32> P018H002 { get; set; }

        [ReadOnly(false)]
        [Column("P018H003", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 94)]
        public System.Nullable<System.Int32> P018H003 { get; set; }

        [ReadOnly(false)]
        [Column("P018H004", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 95)]
        public System.Nullable<System.Int32> P018H004 { get; set; }

        [ReadOnly(false)]
        [Column("P018H005", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 96)]
        public System.Nullable<System.Int32> P018H005 { get; set; }

        [ReadOnly(false)]
        [Column("P018H006", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 97)]
        public System.Nullable<System.Int32> P018H006 { get; set; }

        [ReadOnly(false)]
        [Column("P018H007", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 98)]
        public System.Nullable<System.Int32> P018H007 { get; set; }

        [ReadOnly(false)]
        [Column("P018H008", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 99)]
        public System.Nullable<System.Int32> P018H008 { get; set; }

        [ReadOnly(false)]
        [Column("P018H009", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 100)]
        public System.Nullable<System.Int32> P018H009 { get; set; }

        [ReadOnly(false)]
        [Column("P018I001", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 101)]
        public System.Nullable<System.Int32> P018I001 { get; set; }

        [ReadOnly(false)]
        [Column("P018I002", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 102)]
        public System.Nullable<System.Int32> P018I002 { get; set; }

        [ReadOnly(false)]
        [Column("P018I003", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 103)]
        public System.Nullable<System.Int32> P018I003 { get; set; }

        [ReadOnly(false)]
        [Column("P018I004", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 104)]
        public System.Nullable<System.Int32> P018I004 { get; set; }

        [ReadOnly(false)]
        [Column("P018I005", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 105)]
        public System.Nullable<System.Int32> P018I005 { get; set; }

        [ReadOnly(false)]
        [Column("P018I006", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 106)]
        public System.Nullable<System.Int32> P018I006 { get; set; }

        [ReadOnly(false)]
        [Column("P018I007", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 107)]
        public System.Nullable<System.Int32> P018I007 { get; set; }

        [ReadOnly(false)]
        [Column("P018I008", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder living alone", ShortName = "Householder living alone", Order = 108)]
        public System.Nullable<System.Int32> P018I008 { get; set; }

        [ReadOnly(false)]
        [Column("P018I009", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder not living alone", ShortName = "Householder not living alone", Order = 109)]
        public System.Nullable<System.Int32> P018I009 { get; set; }

        [ReadOnly(false)]
        [Column("P028A001", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 110)]
        public System.Nullable<System.Int32> P028A001 { get; set; }

        [ReadOnly(false)]
        [Column("P028A002", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 111)]
        public System.Nullable<System.Int32> P028A002 { get; set; }

        [ReadOnly(false)]
        [Column("P028A003", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 112)]
        public System.Nullable<System.Int32> P028A003 { get; set; }

        [ReadOnly(false)]
        [Column("P028A004", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 113)]
        public System.Nullable<System.Int32> P028A004 { get; set; }

        [ReadOnly(false)]
        [Column("P028A005", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 114)]
        public System.Nullable<System.Int32> P028A005 { get; set; }

        [ReadOnly(false)]
        [Column("P028A006", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 115)]
        public System.Nullable<System.Int32> P028A006 { get; set; }

        [ReadOnly(false)]
        [Column("P028A007", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 116)]
        public System.Nullable<System.Int32> P028A007 { get; set; }

        [ReadOnly(false)]
        [Column("P028A008", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 117)]
        public System.Nullable<System.Int32> P028A008 { get; set; }

        [ReadOnly(false)]
        [Column("P028A009", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 118)]
        public System.Nullable<System.Int32> P028A009 { get; set; }

        [ReadOnly(false)]
        [Column("P028A010", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 119)]
        public System.Nullable<System.Int32> P028A010 { get; set; }

        [ReadOnly(false)]
        [Column("P028A011", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 120)]
        public System.Nullable<System.Int32> P028A011 { get; set; }

        [ReadOnly(false)]
        [Column("P028A012", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 121)]
        public System.Nullable<System.Int32> P028A012 { get; set; }

        [ReadOnly(false)]
        [Column("P028A013", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 122)]
        public System.Nullable<System.Int32> P028A013 { get; set; }

        [ReadOnly(false)]
        [Column("P028A014", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 123)]
        public System.Nullable<System.Int32> P028A014 { get; set; }

        [ReadOnly(false)]
        [Column("P028A015", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 124)]
        public System.Nullable<System.Int32> P028A015 { get; set; }

        [ReadOnly(false)]
        [Column("P028A016", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 125)]
        public System.Nullable<System.Int32> P028A016 { get; set; }

        [ReadOnly(false)]
        [Column("P028B001", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 126)]
        public System.Nullable<System.Int32> P028B001 { get; set; }

        [ReadOnly(false)]
        [Column("P028B002", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 127)]
        public System.Nullable<System.Int32> P028B002 { get; set; }

        [ReadOnly(false)]
        [Column("P028B003", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 128)]
        public System.Nullable<System.Int32> P028B003 { get; set; }

        [ReadOnly(false)]
        [Column("P028B004", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 129)]
        public System.Nullable<System.Int32> P028B004 { get; set; }

        [ReadOnly(false)]
        [Column("P028B005", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 130)]
        public System.Nullable<System.Int32> P028B005 { get; set; }

        [ReadOnly(false)]
        [Column("P028B006", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 131)]
        public System.Nullable<System.Int32> P028B006 { get; set; }

        [ReadOnly(false)]
        [Column("P028B007", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 132)]
        public System.Nullable<System.Int32> P028B007 { get; set; }

        [ReadOnly(false)]
        [Column("P028B008", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 133)]
        public System.Nullable<System.Int32> P028B008 { get; set; }

        [ReadOnly(false)]
        [Column("P028B009", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 134)]
        public System.Nullable<System.Int32> P028B009 { get; set; }

        [ReadOnly(false)]
        [Column("P028B010", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 135)]
        public System.Nullable<System.Int32> P028B010 { get; set; }

        [ReadOnly(false)]
        [Column("P028B011", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 136)]
        public System.Nullable<System.Int32> P028B011 { get; set; }

        [ReadOnly(false)]
        [Column("P028B012", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 137)]
        public System.Nullable<System.Int32> P028B012 { get; set; }

        [ReadOnly(false)]
        [Column("P028B013", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 138)]
        public System.Nullable<System.Int32> P028B013 { get; set; }

        [ReadOnly(false)]
        [Column("P028B014", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 139)]
        public System.Nullable<System.Int32> P028B014 { get; set; }

        [ReadOnly(false)]
        [Column("P028B015", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 140)]
        public System.Nullable<System.Int32> P028B015 { get; set; }

        [ReadOnly(false)]
        [Column("P028B016", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 141)]
        public System.Nullable<System.Int32> P028B016 { get; set; }

        [ReadOnly(false)]
        [Column("P028C001", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 142)]
        public System.Nullable<System.Int32> P028C001 { get; set; }

        [ReadOnly(false)]
        [Column("P028C002", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 143)]
        public System.Nullable<System.Int32> P028C002 { get; set; }

        [ReadOnly(false)]
        [Column("P028C003", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 144)]
        public System.Nullable<System.Int32> P028C003 { get; set; }

        [ReadOnly(false)]
        [Column("P028C004", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 145)]
        public System.Nullable<System.Int32> P028C004 { get; set; }

        [ReadOnly(false)]
        [Column("P028C005", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 146)]
        public System.Nullable<System.Int32> P028C005 { get; set; }

        [ReadOnly(false)]
        [Column("P028C006", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 147)]
        public System.Nullable<System.Int32> P028C006 { get; set; }

        [ReadOnly(false)]
        [Column("P028C007", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 148)]
        public System.Nullable<System.Int32> P028C007 { get; set; }

        [ReadOnly(false)]
        [Column("P028C008", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 149)]
        public System.Nullable<System.Int32> P028C008 { get; set; }

        [ReadOnly(false)]
        [Column("P028C009", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 150)]
        public System.Nullable<System.Int32> P028C009 { get; set; }

        [ReadOnly(false)]
        [Column("P028C010", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 151)]
        public System.Nullable<System.Int32> P028C010 { get; set; }

        [ReadOnly(false)]
        [Column("P028C011", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 152)]
        public System.Nullable<System.Int32> P028C011 { get; set; }

        [ReadOnly(false)]
        [Column("P028C012", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 153)]
        public System.Nullable<System.Int32> P028C012 { get; set; }

        [ReadOnly(false)]
        [Column("P028C013", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 154)]
        public System.Nullable<System.Int32> P028C013 { get; set; }

        [ReadOnly(false)]
        [Column("P028C014", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 155)]
        public System.Nullable<System.Int32> P028C014 { get; set; }

        [ReadOnly(false)]
        [Column("P028C015", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 156)]
        public System.Nullable<System.Int32> P028C015 { get; set; }

        [ReadOnly(false)]
        [Column("P028C016", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 157)]
        public System.Nullable<System.Int32> P028C016 { get; set; }

        [ReadOnly(false)]
        [Column("P028D001", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 158)]
        public System.Nullable<System.Int32> P028D001 { get; set; }

        [ReadOnly(false)]
        [Column("P028D002", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 159)]
        public System.Nullable<System.Int32> P028D002 { get; set; }

        [ReadOnly(false)]
        [Column("P028D003", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 160)]
        public System.Nullable<System.Int32> P028D003 { get; set; }

        [ReadOnly(false)]
        [Column("P028D004", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 161)]
        public System.Nullable<System.Int32> P028D004 { get; set; }

        [ReadOnly(false)]
        [Column("P028D005", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 162)]
        public System.Nullable<System.Int32> P028D005 { get; set; }

        [ReadOnly(false)]
        [Column("P028D006", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 163)]
        public System.Nullable<System.Int32> P028D006 { get; set; }

        [ReadOnly(false)]
        [Column("P028D007", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 164)]
        public System.Nullable<System.Int32> P028D007 { get; set; }

        [ReadOnly(false)]
        [Column("P028D008", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 165)]
        public System.Nullable<System.Int32> P028D008 { get; set; }

        [ReadOnly(false)]
        [Column("P028D009", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 166)]
        public System.Nullable<System.Int32> P028D009 { get; set; }

        [ReadOnly(false)]
        [Column("P028D010", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 167)]
        public System.Nullable<System.Int32> P028D010 { get; set; }

        [ReadOnly(false)]
        [Column("P028D011", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 168)]
        public System.Nullable<System.Int32> P028D011 { get; set; }

        [ReadOnly(false)]
        [Column("P028D012", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 169)]
        public System.Nullable<System.Int32> P028D012 { get; set; }

        [ReadOnly(false)]
        [Column("P028D013", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 170)]
        public System.Nullable<System.Int32> P028D013 { get; set; }

        [ReadOnly(false)]
        [Column("P028D014", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 171)]
        public System.Nullable<System.Int32> P028D014 { get; set; }

        [ReadOnly(false)]
        [Column("P028D015", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 172)]
        public System.Nullable<System.Int32> P028D015 { get; set; }

        [ReadOnly(false)]
        [Column("P028D016", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 173)]
        public System.Nullable<System.Int32> P028D016 { get; set; }

        [ReadOnly(false)]
        [Column("P028E001", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 174)]
        public System.Nullable<System.Int32> P028E001 { get; set; }

        [ReadOnly(false)]
        [Column("P028E002", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 175)]
        public System.Nullable<System.Int32> P028E002 { get; set; }

        [ReadOnly(false)]
        [Column("P028E003", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 176)]
        public System.Nullable<System.Int32> P028E003 { get; set; }

        [ReadOnly(false)]
        [Column("P028E004", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 177)]
        public System.Nullable<System.Int32> P028E004 { get; set; }

        [ReadOnly(false)]
        [Column("P028E005", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 178)]
        public System.Nullable<System.Int32> P028E005 { get; set; }

        [ReadOnly(false)]
        [Column("P028E006", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 179)]
        public System.Nullable<System.Int32> P028E006 { get; set; }

        [ReadOnly(false)]
        [Column("P028E007", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 180)]
        public System.Nullable<System.Int32> P028E007 { get; set; }

        [ReadOnly(false)]
        [Column("P028E008", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 181)]
        public System.Nullable<System.Int32> P028E008 { get; set; }

        [ReadOnly(false)]
        [Column("P028E009", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 182)]
        public System.Nullable<System.Int32> P028E009 { get; set; }

        [ReadOnly(false)]
        [Column("P028E010", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 183)]
        public System.Nullable<System.Int32> P028E010 { get; set; }

        [ReadOnly(false)]
        [Column("P028E011", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 184)]
        public System.Nullable<System.Int32> P028E011 { get; set; }

        [ReadOnly(false)]
        [Column("P028E012", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 185)]
        public System.Nullable<System.Int32> P028E012 { get; set; }

        [ReadOnly(false)]
        [Column("P028E013", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 186)]
        public System.Nullable<System.Int32> P028E013 { get; set; }

        [ReadOnly(false)]
        [Column("P028E014", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 187)]
        public System.Nullable<System.Int32> P028E014 { get; set; }

        [ReadOnly(false)]
        [Column("P028E015", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 188)]
        public System.Nullable<System.Int32> P028E015 { get; set; }

        [ReadOnly(false)]
        [Column("P028E016", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 189)]
        public System.Nullable<System.Int32> P028E016 { get; set; }

        [ReadOnly(false)]
        [Column("P028F001", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 190)]
        public System.Nullable<System.Int32> P028F001 { get; set; }

        [ReadOnly(false)]
        [Column("P028F002", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 191)]
        public System.Nullable<System.Int32> P028F002 { get; set; }

        [ReadOnly(false)]
        [Column("P028F003", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 192)]
        public System.Nullable<System.Int32> P028F003 { get; set; }

        [ReadOnly(false)]
        [Column("P028F004", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 193)]
        public System.Nullable<System.Int32> P028F004 { get; set; }

        [ReadOnly(false)]
        [Column("P028F005", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 194)]
        public System.Nullable<System.Int32> P028F005 { get; set; }

        [ReadOnly(false)]
        [Column("P028F006", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 195)]
        public System.Nullable<System.Int32> P028F006 { get; set; }

        [ReadOnly(false)]
        [Column("P028F007", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 196)]
        public System.Nullable<System.Int32> P028F007 { get; set; }

        [ReadOnly(false)]
        [Column("P028F008", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 197)]
        public System.Nullable<System.Int32> P028F008 { get; set; }

        [ReadOnly(false)]
        [Column("P028F009", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 198)]
        public System.Nullable<System.Int32> P028F009 { get; set; }

        [ReadOnly(false)]
        [Column("P028F010", Order = 199)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 199)]
        public System.Nullable<System.Int32> P028F010 { get; set; }

        [ReadOnly(false)]
        [Column("P028F011", Order = 200)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 200)]
        public System.Nullable<System.Int32> P028F011 { get; set; }

        [ReadOnly(false)]
        [Column("P028F012", Order = 201)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 201)]
        public System.Nullable<System.Int32> P028F012 { get; set; }

        [ReadOnly(false)]
        [Column("P028F013", Order = 202)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 202)]
        public System.Nullable<System.Int32> P028F013 { get; set; }

        [ReadOnly(false)]
        [Column("P028F014", Order = 203)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 203)]
        public System.Nullable<System.Int32> P028F014 { get; set; }

        [ReadOnly(false)]
        [Column("P028F015", Order = 204)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 204)]
        public System.Nullable<System.Int32> P028F015 { get; set; }

        [ReadOnly(false)]
        [Column("P028F016", Order = 205)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 205)]
        public System.Nullable<System.Int32> P028F016 { get; set; }

        [ReadOnly(false)]
        [Column("P028G001", Order = 206)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 206)]
        public System.Nullable<System.Int32> P028G001 { get; set; }

        [ReadOnly(false)]
        [Column("P028G002", Order = 207)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 207)]
        public System.Nullable<System.Int32> P028G002 { get; set; }

        [ReadOnly(false)]
        [Column("P028G003", Order = 208)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 208)]
        public System.Nullable<System.Int32> P028G003 { get; set; }

        [ReadOnly(false)]
        [Column("P028G004", Order = 209)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 209)]
        public System.Nullable<System.Int32> P028G004 { get; set; }

        [ReadOnly(false)]
        [Column("P028G005", Order = 210)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 210)]
        public System.Nullable<System.Int32> P028G005 { get; set; }

        [ReadOnly(false)]
        [Column("P028G006", Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 211)]
        public System.Nullable<System.Int32> P028G006 { get; set; }

        [ReadOnly(false)]
        [Column("P028G007", Order = 212)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 212)]
        public System.Nullable<System.Int32> P028G007 { get; set; }

        [ReadOnly(false)]
        [Column("P028G008", Order = 213)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 213)]
        public System.Nullable<System.Int32> P028G008 { get; set; }

        [ReadOnly(false)]
        [Column("P028G009", Order = 214)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 214)]
        public System.Nullable<System.Int32> P028G009 { get; set; }

        [ReadOnly(false)]
        [Column("P028G010", Order = 215)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 215)]
        public System.Nullable<System.Int32> P028G010 { get; set; }

        [ReadOnly(false)]
        [Column("P028G011", Order = 216)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 216)]
        public System.Nullable<System.Int32> P028G011 { get; set; }

        [ReadOnly(false)]
        [Column("P028G012", Order = 217)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 217)]
        public System.Nullable<System.Int32> P028G012 { get; set; }

        [ReadOnly(false)]
        [Column("P028G013", Order = 218)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 218)]
        public System.Nullable<System.Int32> P028G013 { get; set; }

        [ReadOnly(false)]
        [Column("P028G014", Order = 219)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 219)]
        public System.Nullable<System.Int32> P028G014 { get; set; }

        [ReadOnly(false)]
        [Column("P028G015", Order = 220)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 220)]
        public System.Nullable<System.Int32> P028G015 { get; set; }

        [ReadOnly(false)]
        [Column("P028G016", Order = 221)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 221)]
        public System.Nullable<System.Int32> P028G016 { get; set; }

        [ReadOnly(false)]
        [Column("P028H001", Order = 222)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 222)]
        public System.Nullable<System.Int32> P028H001 { get; set; }

        [ReadOnly(false)]
        [Column("P028H002", Order = 223)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 223)]
        public System.Nullable<System.Int32> P028H002 { get; set; }

        [ReadOnly(false)]
        [Column("P028H003", Order = 224)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 224)]
        public System.Nullable<System.Int32> P028H003 { get; set; }

        [ReadOnly(false)]
        [Column("P028H004", Order = 225)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 225)]
        public System.Nullable<System.Int32> P028H004 { get; set; }

        [ReadOnly(false)]
        [Column("P028H005", Order = 226)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 226)]
        public System.Nullable<System.Int32> P028H005 { get; set; }

        [ReadOnly(false)]
        [Column("P028H006", Order = 227)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 227)]
        public System.Nullable<System.Int32> P028H006 { get; set; }

        [ReadOnly(false)]
        [Column("P028H007", Order = 228)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 228)]
        public System.Nullable<System.Int32> P028H007 { get; set; }

        [ReadOnly(false)]
        [Column("P028H008", Order = 229)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 229)]
        public System.Nullable<System.Int32> P028H008 { get; set; }

        [ReadOnly(false)]
        [Column("P028H009", Order = 230)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 230)]
        public System.Nullable<System.Int32> P028H009 { get; set; }

        [ReadOnly(false)]
        [Column("P028H010", Order = 231)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 231)]
        public System.Nullable<System.Int32> P028H010 { get; set; }

        [ReadOnly(false)]
        [Column("P028H011", Order = 232)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 232)]
        public System.Nullable<System.Int32> P028H011 { get; set; }

        [ReadOnly(false)]
        [Column("P028H012", Order = 233)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 233)]
        public System.Nullable<System.Int32> P028H012 { get; set; }

        [ReadOnly(false)]
        [Column("P028H013", Order = 234)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 234)]
        public System.Nullable<System.Int32> P028H013 { get; set; }

        [ReadOnly(false)]
        [Column("P028H014", Order = 235)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 235)]
        public System.Nullable<System.Int32> P028H014 { get; set; }

        [ReadOnly(false)]
        [Column("P028H015", Order = 236)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 236)]
        public System.Nullable<System.Int32> P028H015 { get; set; }

        [ReadOnly(false)]
        [Column("P028H016", Order = 237)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 237)]
        public System.Nullable<System.Int32> P028H016 { get; set; }

        [ReadOnly(false)]
        [Column("P028I001", Order = 238)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 238)]
        public System.Nullable<System.Int32> P028I001 { get; set; }

        [ReadOnly(false)]
        [Column("P028I002", Order = 239)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 239)]
        public System.Nullable<System.Int32> P028I002 { get; set; }

        [ReadOnly(false)]
        [Column("P028I003", Order = 240)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 240)]
        public System.Nullable<System.Int32> P028I003 { get; set; }

        [ReadOnly(false)]
        [Column("P028I004", Order = 241)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 241)]
        public System.Nullable<System.Int32> P028I004 { get; set; }

        [ReadOnly(false)]
        [Column("P028I005", Order = 242)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 242)]
        public System.Nullable<System.Int32> P028I005 { get; set; }

        [ReadOnly(false)]
        [Column("P028I006", Order = 243)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 243)]
        public System.Nullable<System.Int32> P028I006 { get; set; }

        [ReadOnly(false)]
        [Column("P028I007", Order = 244)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 244)]
        public System.Nullable<System.Int32> P028I007 { get; set; }

        [ReadOnly(false)]
        [Column("P028I008", Order = 245)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 245)]
        public System.Nullable<System.Int32> P028I008 { get; set; }

        [ReadOnly(false)]
        [Column("P028I009", Order = 246)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 246)]
        public System.Nullable<System.Int32> P028I009 { get; set; }

        [ReadOnly(false)]
        [Column("P028I010", Order = 247)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 247)]
        public System.Nullable<System.Int32> P028I010 { get; set; }

        [ReadOnly(false)]
        [Column("P028I011", Order = 248)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-person household", ShortName = "2-person household", Order = 248)]
        public System.Nullable<System.Int32> P028I011 { get; set; }

        [ReadOnly(false)]
        [Column("P028I012", Order = 249)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3-person household", ShortName = "3-person household", Order = 249)]
        public System.Nullable<System.Int32> P028I012 { get; set; }

        [ReadOnly(false)]
        [Column("P028I013", Order = 250)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4-person household", ShortName = "4-person household", Order = 250)]
        public System.Nullable<System.Int32> P028I013 { get; set; }

        [ReadOnly(false)]
        [Column("P028I014", Order = 251)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5-person household", ShortName = "5-person household", Order = 251)]
        public System.Nullable<System.Int32> P028I014 { get; set; }

        [ReadOnly(false)]
        [Column("P028I015", Order = 252)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6-person household", ShortName = "6-person household", Order = 252)]
        public System.Nullable<System.Int32> P028I015 { get; set; }

        [ReadOnly(false)]
        [Column("P028I016", Order = 253)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7-or-more-person household", ShortName = "7-or-more-person household", Order = 253)]
        public System.Nullable<System.Int32> P028I016 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1_00009(string csvLine) : base(csvLine) {}

        public SF1_00009(string[] values) : base(values) {}

        public SF1_00009(OleDbDataReader reader, CensusFileType fileType)
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
                P017B001 = (System.Nullable<System.Double>)reader[5];
            }
            if(reader[6] != DBNull.Value)
            {
                P017B002 = (System.Nullable<System.Double>)reader[6];
            }
            if(reader[7] != DBNull.Value)
            {
                P017B003 = (System.Nullable<System.Double>)reader[7];
            }
            if(reader[8] != DBNull.Value)
            {
                P017C001 = (System.Nullable<System.Double>)reader[8];
            }
            if(reader[9] != DBNull.Value)
            {
                P017C002 = (System.Nullable<System.Double>)reader[9];
            }
            if(reader[10] != DBNull.Value)
            {
                P017C003 = (System.Nullable<System.Double>)reader[10];
            }
            if(reader[11] != DBNull.Value)
            {
                P017D001 = (System.Nullable<System.Double>)reader[11];
            }
            if(reader[12] != DBNull.Value)
            {
                P017D002 = (System.Nullable<System.Double>)reader[12];
            }
            if(reader[13] != DBNull.Value)
            {
                P017D003 = (System.Nullable<System.Double>)reader[13];
            }
            if(reader[14] != DBNull.Value)
            {
                P017E001 = (System.Nullable<System.Double>)reader[14];
            }
            if(reader[15] != DBNull.Value)
            {
                P017E002 = (System.Nullable<System.Double>)reader[15];
            }
            if(reader[16] != DBNull.Value)
            {
                P017E003 = (System.Nullable<System.Double>)reader[16];
            }
            if(reader[17] != DBNull.Value)
            {
                P017F001 = (System.Nullable<System.Double>)reader[17];
            }
            if(reader[18] != DBNull.Value)
            {
                P017F002 = (System.Nullable<System.Double>)reader[18];
            }
            if(reader[19] != DBNull.Value)
            {
                P017F003 = (System.Nullable<System.Double>)reader[19];
            }
            if(reader[20] != DBNull.Value)
            {
                P017G001 = (System.Nullable<System.Double>)reader[20];
            }
            if(reader[21] != DBNull.Value)
            {
                P017G002 = (System.Nullable<System.Double>)reader[21];
            }
            if(reader[22] != DBNull.Value)
            {
                P017G003 = (System.Nullable<System.Double>)reader[22];
            }
            if(reader[23] != DBNull.Value)
            {
                P017H001 = (System.Nullable<System.Double>)reader[23];
            }
            if(reader[24] != DBNull.Value)
            {
                P017H002 = (System.Nullable<System.Double>)reader[24];
            }
            if(reader[25] != DBNull.Value)
            {
                P017H003 = (System.Nullable<System.Double>)reader[25];
            }
            if(reader[26] != DBNull.Value)
            {
                P017I001 = (System.Nullable<System.Double>)reader[26];
            }
            if(reader[27] != DBNull.Value)
            {
                P017I002 = (System.Nullable<System.Double>)reader[27];
            }
            if(reader[28] != DBNull.Value)
            {
                P017I003 = (System.Nullable<System.Double>)reader[28];
            }
            if(reader[29] != DBNull.Value)
            {
                P018A001 = (System.Nullable<System.Int32>)reader[29];
            }
            if(reader[30] != DBNull.Value)
            {
                P018A002 = (System.Nullable<System.Int32>)reader[30];
            }
            if(reader[31] != DBNull.Value)
            {
                P018A003 = (System.Nullable<System.Int32>)reader[31];
            }
            if(reader[32] != DBNull.Value)
            {
                P018A004 = (System.Nullable<System.Int32>)reader[32];
            }
            if(reader[33] != DBNull.Value)
            {
                P018A005 = (System.Nullable<System.Int32>)reader[33];
            }
            if(reader[34] != DBNull.Value)
            {
                P018A006 = (System.Nullable<System.Int32>)reader[34];
            }
            if(reader[35] != DBNull.Value)
            {
                P018A007 = (System.Nullable<System.Int32>)reader[35];
            }
            if(reader[36] != DBNull.Value)
            {
                P018A008 = (System.Nullable<System.Int32>)reader[36];
            }
            if(reader[37] != DBNull.Value)
            {
                P018A009 = (System.Nullable<System.Int32>)reader[37];
            }
            if(reader[38] != DBNull.Value)
            {
                P018B001 = (System.Nullable<System.Int32>)reader[38];
            }
            if(reader[39] != DBNull.Value)
            {
                P018B002 = (System.Nullable<System.Int32>)reader[39];
            }
            if(reader[40] != DBNull.Value)
            {
                P018B003 = (System.Nullable<System.Int32>)reader[40];
            }
            if(reader[41] != DBNull.Value)
            {
                P018B004 = (System.Nullable<System.Int32>)reader[41];
            }
            if(reader[42] != DBNull.Value)
            {
                P018B005 = (System.Nullable<System.Int32>)reader[42];
            }
            if(reader[43] != DBNull.Value)
            {
                P018B006 = (System.Nullable<System.Int32>)reader[43];
            }
            if(reader[44] != DBNull.Value)
            {
                P018B007 = (System.Nullable<System.Int32>)reader[44];
            }
            if(reader[45] != DBNull.Value)
            {
                P018B008 = (System.Nullable<System.Int32>)reader[45];
            }
            if(reader[46] != DBNull.Value)
            {
                P018B009 = (System.Nullable<System.Int32>)reader[46];
            }
            if(reader[47] != DBNull.Value)
            {
                P018C001 = (System.Nullable<System.Int32>)reader[47];
            }
            if(reader[48] != DBNull.Value)
            {
                P018C002 = (System.Nullable<System.Int32>)reader[48];
            }
            if(reader[49] != DBNull.Value)
            {
                P018C003 = (System.Nullable<System.Int32>)reader[49];
            }
            if(reader[50] != DBNull.Value)
            {
                P018C004 = (System.Nullable<System.Int32>)reader[50];
            }
            if(reader[51] != DBNull.Value)
            {
                P018C005 = (System.Nullable<System.Int32>)reader[51];
            }
            if(reader[52] != DBNull.Value)
            {
                P018C006 = (System.Nullable<System.Int32>)reader[52];
            }
            if(reader[53] != DBNull.Value)
            {
                P018C007 = (System.Nullable<System.Int32>)reader[53];
            }
            if(reader[54] != DBNull.Value)
            {
                P018C008 = (System.Nullable<System.Int32>)reader[54];
            }
            if(reader[55] != DBNull.Value)
            {
                P018C009 = (System.Nullable<System.Int32>)reader[55];
            }
            if(reader[56] != DBNull.Value)
            {
                P018D001 = (System.Nullable<System.Int32>)reader[56];
            }
            if(reader[57] != DBNull.Value)
            {
                P018D002 = (System.Nullable<System.Int32>)reader[57];
            }
            if(reader[58] != DBNull.Value)
            {
                P018D003 = (System.Nullable<System.Int32>)reader[58];
            }
            if(reader[59] != DBNull.Value)
            {
                P018D004 = (System.Nullable<System.Int32>)reader[59];
            }
            if(reader[60] != DBNull.Value)
            {
                P018D005 = (System.Nullable<System.Int32>)reader[60];
            }
            if(reader[61] != DBNull.Value)
            {
                P018D006 = (System.Nullable<System.Int32>)reader[61];
            }
            if(reader[62] != DBNull.Value)
            {
                P018D007 = (System.Nullable<System.Int32>)reader[62];
            }
            if(reader[63] != DBNull.Value)
            {
                P018D008 = (System.Nullable<System.Int32>)reader[63];
            }
            if(reader[64] != DBNull.Value)
            {
                P018D009 = (System.Nullable<System.Int32>)reader[64];
            }
            if(reader[65] != DBNull.Value)
            {
                P018E001 = (System.Nullable<System.Int32>)reader[65];
            }
            if(reader[66] != DBNull.Value)
            {
                P018E002 = (System.Nullable<System.Int32>)reader[66];
            }
            if(reader[67] != DBNull.Value)
            {
                P018E003 = (System.Nullable<System.Int32>)reader[67];
            }
            if(reader[68] != DBNull.Value)
            {
                P018E004 = (System.Nullable<System.Int32>)reader[68];
            }
            if(reader[69] != DBNull.Value)
            {
                P018E005 = (System.Nullable<System.Int32>)reader[69];
            }
            if(reader[70] != DBNull.Value)
            {
                P018E006 = (System.Nullable<System.Int32>)reader[70];
            }
            if(reader[71] != DBNull.Value)
            {
                P018E007 = (System.Nullable<System.Int32>)reader[71];
            }
            if(reader[72] != DBNull.Value)
            {
                P018E008 = (System.Nullable<System.Int32>)reader[72];
            }
            if(reader[73] != DBNull.Value)
            {
                P018E009 = (System.Nullable<System.Int32>)reader[73];
            }
            if(reader[74] != DBNull.Value)
            {
                P018F001 = (System.Nullable<System.Int32>)reader[74];
            }
            if(reader[75] != DBNull.Value)
            {
                P018F002 = (System.Nullable<System.Int32>)reader[75];
            }
            if(reader[76] != DBNull.Value)
            {
                P018F003 = (System.Nullable<System.Int32>)reader[76];
            }
            if(reader[77] != DBNull.Value)
            {
                P018F004 = (System.Nullable<System.Int32>)reader[77];
            }
            if(reader[78] != DBNull.Value)
            {
                P018F005 = (System.Nullable<System.Int32>)reader[78];
            }
            if(reader[79] != DBNull.Value)
            {
                P018F006 = (System.Nullable<System.Int32>)reader[79];
            }
            if(reader[80] != DBNull.Value)
            {
                P018F007 = (System.Nullable<System.Int32>)reader[80];
            }
            if(reader[81] != DBNull.Value)
            {
                P018F008 = (System.Nullable<System.Int32>)reader[81];
            }
            if(reader[82] != DBNull.Value)
            {
                P018F009 = (System.Nullable<System.Int32>)reader[82];
            }
            if(reader[83] != DBNull.Value)
            {
                P018G001 = (System.Nullable<System.Int32>)reader[83];
            }
            if(reader[84] != DBNull.Value)
            {
                P018G002 = (System.Nullable<System.Int32>)reader[84];
            }
            if(reader[85] != DBNull.Value)
            {
                P018G003 = (System.Nullable<System.Int32>)reader[85];
            }
            if(reader[86] != DBNull.Value)
            {
                P018G004 = (System.Nullable<System.Int32>)reader[86];
            }
            if(reader[87] != DBNull.Value)
            {
                P018G005 = (System.Nullable<System.Int32>)reader[87];
            }
            if(reader[88] != DBNull.Value)
            {
                P018G006 = (System.Nullable<System.Int32>)reader[88];
            }
            if(reader[89] != DBNull.Value)
            {
                P018G007 = (System.Nullable<System.Int32>)reader[89];
            }
            if(reader[90] != DBNull.Value)
            {
                P018G008 = (System.Nullable<System.Int32>)reader[90];
            }
            if(reader[91] != DBNull.Value)
            {
                P018G009 = (System.Nullable<System.Int32>)reader[91];
            }
            if(reader[92] != DBNull.Value)
            {
                P018H001 = (System.Nullable<System.Int32>)reader[92];
            }
            if(reader[93] != DBNull.Value)
            {
                P018H002 = (System.Nullable<System.Int32>)reader[93];
            }
            if(reader[94] != DBNull.Value)
            {
                P018H003 = (System.Nullable<System.Int32>)reader[94];
            }
            if(reader[95] != DBNull.Value)
            {
                P018H004 = (System.Nullable<System.Int32>)reader[95];
            }
            if(reader[96] != DBNull.Value)
            {
                P018H005 = (System.Nullable<System.Int32>)reader[96];
            }
            if(reader[97] != DBNull.Value)
            {
                P018H006 = (System.Nullable<System.Int32>)reader[97];
            }
            if(reader[98] != DBNull.Value)
            {
                P018H007 = (System.Nullable<System.Int32>)reader[98];
            }
            if(reader[99] != DBNull.Value)
            {
                P018H008 = (System.Nullable<System.Int32>)reader[99];
            }
            if(reader[100] != DBNull.Value)
            {
                P018H009 = (System.Nullable<System.Int32>)reader[100];
            }
            if(reader[101] != DBNull.Value)
            {
                P018I001 = (System.Nullable<System.Int32>)reader[101];
            }
            if(reader[102] != DBNull.Value)
            {
                P018I002 = (System.Nullable<System.Int32>)reader[102];
            }
            if(reader[103] != DBNull.Value)
            {
                P018I003 = (System.Nullable<System.Int32>)reader[103];
            }
            if(reader[104] != DBNull.Value)
            {
                P018I004 = (System.Nullable<System.Int32>)reader[104];
            }
            if(reader[105] != DBNull.Value)
            {
                P018I005 = (System.Nullable<System.Int32>)reader[105];
            }
            if(reader[106] != DBNull.Value)
            {
                P018I006 = (System.Nullable<System.Int32>)reader[106];
            }
            if(reader[107] != DBNull.Value)
            {
                P018I007 = (System.Nullable<System.Int32>)reader[107];
            }
            if(reader[108] != DBNull.Value)
            {
                P018I008 = (System.Nullable<System.Int32>)reader[108];
            }
            if(reader[109] != DBNull.Value)
            {
                P018I009 = (System.Nullable<System.Int32>)reader[109];
            }
            if(reader[110] != DBNull.Value)
            {
                P028A001 = (System.Nullable<System.Int32>)reader[110];
            }
            if(reader[111] != DBNull.Value)
            {
                P028A002 = (System.Nullable<System.Int32>)reader[111];
            }
            if(reader[112] != DBNull.Value)
            {
                P028A003 = (System.Nullable<System.Int32>)reader[112];
            }
            if(reader[113] != DBNull.Value)
            {
                P028A004 = (System.Nullable<System.Int32>)reader[113];
            }
            if(reader[114] != DBNull.Value)
            {
                P028A005 = (System.Nullable<System.Int32>)reader[114];
            }
            if(reader[115] != DBNull.Value)
            {
                P028A006 = (System.Nullable<System.Int32>)reader[115];
            }
            if(reader[116] != DBNull.Value)
            {
                P028A007 = (System.Nullable<System.Int32>)reader[116];
            }
            if(reader[117] != DBNull.Value)
            {
                P028A008 = (System.Nullable<System.Int32>)reader[117];
            }
            if(reader[118] != DBNull.Value)
            {
                P028A009 = (System.Nullable<System.Int32>)reader[118];
            }
            if(reader[119] != DBNull.Value)
            {
                P028A010 = (System.Nullable<System.Int32>)reader[119];
            }
            if(reader[120] != DBNull.Value)
            {
                P028A011 = (System.Nullable<System.Int32>)reader[120];
            }
            if(reader[121] != DBNull.Value)
            {
                P028A012 = (System.Nullable<System.Int32>)reader[121];
            }
            if(reader[122] != DBNull.Value)
            {
                P028A013 = (System.Nullable<System.Int32>)reader[122];
            }
            if(reader[123] != DBNull.Value)
            {
                P028A014 = (System.Nullable<System.Int32>)reader[123];
            }
            if(reader[124] != DBNull.Value)
            {
                P028A015 = (System.Nullable<System.Int32>)reader[124];
            }
            if(reader[125] != DBNull.Value)
            {
                P028A016 = (System.Nullable<System.Int32>)reader[125];
            }
            if(reader[126] != DBNull.Value)
            {
                P028B001 = (System.Nullable<System.Int32>)reader[126];
            }
            if(reader[127] != DBNull.Value)
            {
                P028B002 = (System.Nullable<System.Int32>)reader[127];
            }
            if(reader[128] != DBNull.Value)
            {
                P028B003 = (System.Nullable<System.Int32>)reader[128];
            }
            if(reader[129] != DBNull.Value)
            {
                P028B004 = (System.Nullable<System.Int32>)reader[129];
            }
            if(reader[130] != DBNull.Value)
            {
                P028B005 = (System.Nullable<System.Int32>)reader[130];
            }
            if(reader[131] != DBNull.Value)
            {
                P028B006 = (System.Nullable<System.Int32>)reader[131];
            }
            if(reader[132] != DBNull.Value)
            {
                P028B007 = (System.Nullable<System.Int32>)reader[132];
            }
            if(reader[133] != DBNull.Value)
            {
                P028B008 = (System.Nullable<System.Int32>)reader[133];
            }
            if(reader[134] != DBNull.Value)
            {
                P028B009 = (System.Nullable<System.Int32>)reader[134];
            }
            if(reader[135] != DBNull.Value)
            {
                P028B010 = (System.Nullable<System.Int32>)reader[135];
            }
            if(reader[136] != DBNull.Value)
            {
                P028B011 = (System.Nullable<System.Int32>)reader[136];
            }
            if(reader[137] != DBNull.Value)
            {
                P028B012 = (System.Nullable<System.Int32>)reader[137];
            }
            if(reader[138] != DBNull.Value)
            {
                P028B013 = (System.Nullable<System.Int32>)reader[138];
            }
            if(reader[139] != DBNull.Value)
            {
                P028B014 = (System.Nullable<System.Int32>)reader[139];
            }
            if(reader[140] != DBNull.Value)
            {
                P028B015 = (System.Nullable<System.Int32>)reader[140];
            }
            if(reader[141] != DBNull.Value)
            {
                P028B016 = (System.Nullable<System.Int32>)reader[141];
            }
            if(reader[142] != DBNull.Value)
            {
                P028C001 = (System.Nullable<System.Int32>)reader[142];
            }
            if(reader[143] != DBNull.Value)
            {
                P028C002 = (System.Nullable<System.Int32>)reader[143];
            }
            if(reader[144] != DBNull.Value)
            {
                P028C003 = (System.Nullable<System.Int32>)reader[144];
            }
            if(reader[145] != DBNull.Value)
            {
                P028C004 = (System.Nullable<System.Int32>)reader[145];
            }
            if(reader[146] != DBNull.Value)
            {
                P028C005 = (System.Nullable<System.Int32>)reader[146];
            }
            if(reader[147] != DBNull.Value)
            {
                P028C006 = (System.Nullable<System.Int32>)reader[147];
            }
            if(reader[148] != DBNull.Value)
            {
                P028C007 = (System.Nullable<System.Int32>)reader[148];
            }
            if(reader[149] != DBNull.Value)
            {
                P028C008 = (System.Nullable<System.Int32>)reader[149];
            }
            if(reader[150] != DBNull.Value)
            {
                P028C009 = (System.Nullable<System.Int32>)reader[150];
            }
            if(reader[151] != DBNull.Value)
            {
                P028C010 = (System.Nullable<System.Int32>)reader[151];
            }
            if(reader[152] != DBNull.Value)
            {
                P028C011 = (System.Nullable<System.Int32>)reader[152];
            }
            if(reader[153] != DBNull.Value)
            {
                P028C012 = (System.Nullable<System.Int32>)reader[153];
            }
            if(reader[154] != DBNull.Value)
            {
                P028C013 = (System.Nullable<System.Int32>)reader[154];
            }
            if(reader[155] != DBNull.Value)
            {
                P028C014 = (System.Nullable<System.Int32>)reader[155];
            }
            if(reader[156] != DBNull.Value)
            {
                P028C015 = (System.Nullable<System.Int32>)reader[156];
            }
            if(reader[157] != DBNull.Value)
            {
                P028C016 = (System.Nullable<System.Int32>)reader[157];
            }
            if(reader[158] != DBNull.Value)
            {
                P028D001 = (System.Nullable<System.Int32>)reader[158];
            }
            if(reader[159] != DBNull.Value)
            {
                P028D002 = (System.Nullable<System.Int32>)reader[159];
            }
            if(reader[160] != DBNull.Value)
            {
                P028D003 = (System.Nullable<System.Int32>)reader[160];
            }
            if(reader[161] != DBNull.Value)
            {
                P028D004 = (System.Nullable<System.Int32>)reader[161];
            }
            if(reader[162] != DBNull.Value)
            {
                P028D005 = (System.Nullable<System.Int32>)reader[162];
            }
            if(reader[163] != DBNull.Value)
            {
                P028D006 = (System.Nullable<System.Int32>)reader[163];
            }
            if(reader[164] != DBNull.Value)
            {
                P028D007 = (System.Nullable<System.Int32>)reader[164];
            }
            if(reader[165] != DBNull.Value)
            {
                P028D008 = (System.Nullable<System.Int32>)reader[165];
            }
            if(reader[166] != DBNull.Value)
            {
                P028D009 = (System.Nullable<System.Int32>)reader[166];
            }
            if(reader[167] != DBNull.Value)
            {
                P028D010 = (System.Nullable<System.Int32>)reader[167];
            }
            if(reader[168] != DBNull.Value)
            {
                P028D011 = (System.Nullable<System.Int32>)reader[168];
            }
            if(reader[169] != DBNull.Value)
            {
                P028D012 = (System.Nullable<System.Int32>)reader[169];
            }
            if(reader[170] != DBNull.Value)
            {
                P028D013 = (System.Nullable<System.Int32>)reader[170];
            }
            if(reader[171] != DBNull.Value)
            {
                P028D014 = (System.Nullable<System.Int32>)reader[171];
            }
            if(reader[172] != DBNull.Value)
            {
                P028D015 = (System.Nullable<System.Int32>)reader[172];
            }
            if(reader[173] != DBNull.Value)
            {
                P028D016 = (System.Nullable<System.Int32>)reader[173];
            }
            if(reader[174] != DBNull.Value)
            {
                P028E001 = (System.Nullable<System.Int32>)reader[174];
            }
            if(reader[175] != DBNull.Value)
            {
                P028E002 = (System.Nullable<System.Int32>)reader[175];
            }
            if(reader[176] != DBNull.Value)
            {
                P028E003 = (System.Nullable<System.Int32>)reader[176];
            }
            if(reader[177] != DBNull.Value)
            {
                P028E004 = (System.Nullable<System.Int32>)reader[177];
            }
            if(reader[178] != DBNull.Value)
            {
                P028E005 = (System.Nullable<System.Int32>)reader[178];
            }
            if(reader[179] != DBNull.Value)
            {
                P028E006 = (System.Nullable<System.Int32>)reader[179];
            }
            if(reader[180] != DBNull.Value)
            {
                P028E007 = (System.Nullable<System.Int32>)reader[180];
            }
            if(reader[181] != DBNull.Value)
            {
                P028E008 = (System.Nullable<System.Int32>)reader[181];
            }
            if(reader[182] != DBNull.Value)
            {
                P028E009 = (System.Nullable<System.Int32>)reader[182];
            }
            if(reader[183] != DBNull.Value)
            {
                P028E010 = (System.Nullable<System.Int32>)reader[183];
            }
            if(reader[184] != DBNull.Value)
            {
                P028E011 = (System.Nullable<System.Int32>)reader[184];
            }
            if(reader[185] != DBNull.Value)
            {
                P028E012 = (System.Nullable<System.Int32>)reader[185];
            }
            if(reader[186] != DBNull.Value)
            {
                P028E013 = (System.Nullable<System.Int32>)reader[186];
            }
            if(reader[187] != DBNull.Value)
            {
                P028E014 = (System.Nullable<System.Int32>)reader[187];
            }
            if(reader[188] != DBNull.Value)
            {
                P028E015 = (System.Nullable<System.Int32>)reader[188];
            }
            if(reader[189] != DBNull.Value)
            {
                P028E016 = (System.Nullable<System.Int32>)reader[189];
            }
            if(reader[190] != DBNull.Value)
            {
                P028F001 = (System.Nullable<System.Int32>)reader[190];
            }
            if(reader[191] != DBNull.Value)
            {
                P028F002 = (System.Nullable<System.Int32>)reader[191];
            }
            if(reader[192] != DBNull.Value)
            {
                P028F003 = (System.Nullable<System.Int32>)reader[192];
            }
            if(reader[193] != DBNull.Value)
            {
                P028F004 = (System.Nullable<System.Int32>)reader[193];
            }
            if(reader[194] != DBNull.Value)
            {
                P028F005 = (System.Nullable<System.Int32>)reader[194];
            }
            if(reader[195] != DBNull.Value)
            {
                P028F006 = (System.Nullable<System.Int32>)reader[195];
            }
            if(reader[196] != DBNull.Value)
            {
                P028F007 = (System.Nullable<System.Int32>)reader[196];
            }
            if(reader[197] != DBNull.Value)
            {
                P028F008 = (System.Nullable<System.Int32>)reader[197];
            }
            if(reader[198] != DBNull.Value)
            {
                P028F009 = (System.Nullable<System.Int32>)reader[198];
            }
            if(reader[199] != DBNull.Value)
            {
                P028F010 = (System.Nullable<System.Int32>)reader[199];
            }
            if(reader[200] != DBNull.Value)
            {
                P028F011 = (System.Nullable<System.Int32>)reader[200];
            }
            if(reader[201] != DBNull.Value)
            {
                P028F012 = (System.Nullable<System.Int32>)reader[201];
            }
            if(reader[202] != DBNull.Value)
            {
                P028F013 = (System.Nullable<System.Int32>)reader[202];
            }
            if(reader[203] != DBNull.Value)
            {
                P028F014 = (System.Nullable<System.Int32>)reader[203];
            }
            if(reader[204] != DBNull.Value)
            {
                P028F015 = (System.Nullable<System.Int32>)reader[204];
            }
            if(reader[205] != DBNull.Value)
            {
                P028F016 = (System.Nullable<System.Int32>)reader[205];
            }
            if(reader[206] != DBNull.Value)
            {
                P028G001 = (System.Nullable<System.Int32>)reader[206];
            }
            if(reader[207] != DBNull.Value)
            {
                P028G002 = (System.Nullable<System.Int32>)reader[207];
            }
            if(reader[208] != DBNull.Value)
            {
                P028G003 = (System.Nullable<System.Int32>)reader[208];
            }
            if(reader[209] != DBNull.Value)
            {
                P028G004 = (System.Nullable<System.Int32>)reader[209];
            }
            if(reader[210] != DBNull.Value)
            {
                P028G005 = (System.Nullable<System.Int32>)reader[210];
            }
            if(reader[211] != DBNull.Value)
            {
                P028G006 = (System.Nullable<System.Int32>)reader[211];
            }
            if(reader[212] != DBNull.Value)
            {
                P028G007 = (System.Nullable<System.Int32>)reader[212];
            }
            if(reader[213] != DBNull.Value)
            {
                P028G008 = (System.Nullable<System.Int32>)reader[213];
            }
            if(reader[214] != DBNull.Value)
            {
                P028G009 = (System.Nullable<System.Int32>)reader[214];
            }
            if(reader[215] != DBNull.Value)
            {
                P028G010 = (System.Nullable<System.Int32>)reader[215];
            }
            if(reader[216] != DBNull.Value)
            {
                P028G011 = (System.Nullable<System.Int32>)reader[216];
            }
            if(reader[217] != DBNull.Value)
            {
                P028G012 = (System.Nullable<System.Int32>)reader[217];
            }
            if(reader[218] != DBNull.Value)
            {
                P028G013 = (System.Nullable<System.Int32>)reader[218];
            }
            if(reader[219] != DBNull.Value)
            {
                P028G014 = (System.Nullable<System.Int32>)reader[219];
            }
            if(reader[220] != DBNull.Value)
            {
                P028G015 = (System.Nullable<System.Int32>)reader[220];
            }
            if(reader[221] != DBNull.Value)
            {
                P028G016 = (System.Nullable<System.Int32>)reader[221];
            }
            if(reader[222] != DBNull.Value)
            {
                P028H001 = (System.Nullable<System.Int32>)reader[222];
            }
            if(reader[223] != DBNull.Value)
            {
                P028H002 = (System.Nullable<System.Int32>)reader[223];
            }
            if(reader[224] != DBNull.Value)
            {
                P028H003 = (System.Nullable<System.Int32>)reader[224];
            }
            if(reader[225] != DBNull.Value)
            {
                P028H004 = (System.Nullable<System.Int32>)reader[225];
            }
            if(reader[226] != DBNull.Value)
            {
                P028H005 = (System.Nullable<System.Int32>)reader[226];
            }
            if(reader[227] != DBNull.Value)
            {
                P028H006 = (System.Nullable<System.Int32>)reader[227];
            }
            if(reader[228] != DBNull.Value)
            {
                P028H007 = (System.Nullable<System.Int32>)reader[228];
            }
            if(reader[229] != DBNull.Value)
            {
                P028H008 = (System.Nullable<System.Int32>)reader[229];
            }
            if(reader[230] != DBNull.Value)
            {
                P028H009 = (System.Nullable<System.Int32>)reader[230];
            }
            if(reader[231] != DBNull.Value)
            {
                P028H010 = (System.Nullable<System.Int32>)reader[231];
            }
            if(reader[232] != DBNull.Value)
            {
                P028H011 = (System.Nullable<System.Int32>)reader[232];
            }
            if(reader[233] != DBNull.Value)
            {
                P028H012 = (System.Nullable<System.Int32>)reader[233];
            }
            if(reader[234] != DBNull.Value)
            {
                P028H013 = (System.Nullable<System.Int32>)reader[234];
            }
            if(reader[235] != DBNull.Value)
            {
                P028H014 = (System.Nullable<System.Int32>)reader[235];
            }
            if(reader[236] != DBNull.Value)
            {
                P028H015 = (System.Nullable<System.Int32>)reader[236];
            }
            if(reader[237] != DBNull.Value)
            {
                P028H016 = (System.Nullable<System.Int32>)reader[237];
            }
            if(reader[238] != DBNull.Value)
            {
                P028I001 = (System.Nullable<System.Int32>)reader[238];
            }
            if(reader[239] != DBNull.Value)
            {
                P028I002 = (System.Nullable<System.Int32>)reader[239];
            }
            if(reader[240] != DBNull.Value)
            {
                P028I003 = (System.Nullable<System.Int32>)reader[240];
            }
            if(reader[241] != DBNull.Value)
            {
                P028I004 = (System.Nullable<System.Int32>)reader[241];
            }
            if(reader[242] != DBNull.Value)
            {
                P028I005 = (System.Nullable<System.Int32>)reader[242];
            }
            if(reader[243] != DBNull.Value)
            {
                P028I006 = (System.Nullable<System.Int32>)reader[243];
            }
            if(reader[244] != DBNull.Value)
            {
                P028I007 = (System.Nullable<System.Int32>)reader[244];
            }
            if(reader[245] != DBNull.Value)
            {
                P028I008 = (System.Nullable<System.Int32>)reader[245];
            }
            if(reader[246] != DBNull.Value)
            {
                P028I009 = (System.Nullable<System.Int32>)reader[246];
            }
            if(reader[247] != DBNull.Value)
            {
                P028I010 = (System.Nullable<System.Int32>)reader[247];
            }
            if(reader[248] != DBNull.Value)
            {
                P028I011 = (System.Nullable<System.Int32>)reader[248];
            }
            if(reader[249] != DBNull.Value)
            {
                P028I012 = (System.Nullable<System.Int32>)reader[249];
            }
            if(reader[250] != DBNull.Value)
            {
                P028I013 = (System.Nullable<System.Int32>)reader[250];
            }
            if(reader[251] != DBNull.Value)
            {
                P028I014 = (System.Nullable<System.Int32>)reader[251];
            }
            if(reader[252] != DBNull.Value)
            {
                P028I015 = (System.Nullable<System.Int32>)reader[252];
            }
            if(reader[253] != DBNull.Value)
            {
                P028I016 = (System.Nullable<System.Int32>)reader[253];
            }
        }
        #endregion Constructors
    }
}