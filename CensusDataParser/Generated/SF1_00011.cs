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

    [Table("SF1_00011")]
    public partial class SF1_00011 : BaseModel
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
        [Column("P031A001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public System.Nullable<System.Int32> P031A001 { get; set; }

        [ReadOnly(false)]
        [Column("P031A002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 6)]
        public System.Nullable<System.Int32> P031A002 { get; set; }

        [ReadOnly(false)]
        [Column("P031A003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 7)]
        public System.Nullable<System.Int32> P031A003 { get; set; }

        [ReadOnly(false)]
        [Column("P031A004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Related child:", ShortName = "Related child:", Order = 8)]
        public System.Nullable<System.Int32> P031A004 { get; set; }

        [ReadOnly(false)]
        [Column("P031A005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Own child:", ShortName = "Own child:", Order = 9)]
        public System.Nullable<System.Int32> P031A005 { get; set; }

        [ReadOnly(false)]
        [Column("P031A006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 10)]
        public System.Nullable<System.Int32> P031A006 { get; set; }

        [ReadOnly(false)]
        [Column("P031A007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In other family:", ShortName = "In other family:", Order = 11)]
        public System.Nullable<System.Int32> P031A007 { get; set; }

        [ReadOnly(false)]
        [Column("P031A008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 12)]
        public System.Nullable<System.Int32> P031A008 { get; set; }

        [ReadOnly(false)]
        [Column("P031A009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 13)]
        public System.Nullable<System.Int32> P031A009 { get; set; }

        [ReadOnly(false)]
        [Column("P031A010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 14)]
        public System.Nullable<System.Int32> P031A010 { get; set; }

        [ReadOnly(false)]
        [Column("P031A011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 15)]
        public System.Nullable<System.Int32> P031A011 { get; set; }

        [ReadOnly(false)]
        [Column("P031A012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 16)]
        public System.Nullable<System.Int32> P031A012 { get; set; }

        [ReadOnly(false)]
        [Column("P031A013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 17)]
        public System.Nullable<System.Int32> P031A013 { get; set; }

        [ReadOnly(false)]
        [Column("P031A014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 18)]
        public System.Nullable<System.Int32> P031A014 { get; set; }

        [ReadOnly(false)]
        [Column("P031A015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 19)]
        public System.Nullable<System.Int32> P031A015 { get; set; }

        [ReadOnly(false)]
        [Column("P031A016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 20)]
        public System.Nullable<System.Int32> P031A016 { get; set; }

        [ReadOnly(false)]
        [Column("P031B001", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 21)]
        public System.Nullable<System.Int32> P031B001 { get; set; }

        [ReadOnly(false)]
        [Column("P031B002", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 22)]
        public System.Nullable<System.Int32> P031B002 { get; set; }

        [ReadOnly(false)]
        [Column("P031B003", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 23)]
        public System.Nullable<System.Int32> P031B003 { get; set; }

        [ReadOnly(false)]
        [Column("P031B004", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Related child:", ShortName = "Related child:", Order = 24)]
        public System.Nullable<System.Int32> P031B004 { get; set; }

        [ReadOnly(false)]
        [Column("P031B005", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Own child:", ShortName = "Own child:", Order = 25)]
        public System.Nullable<System.Int32> P031B005 { get; set; }

        [ReadOnly(false)]
        [Column("P031B006", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 26)]
        public System.Nullable<System.Int32> P031B006 { get; set; }

        [ReadOnly(false)]
        [Column("P031B007", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In other family:", ShortName = "In other family:", Order = 27)]
        public System.Nullable<System.Int32> P031B007 { get; set; }

        [ReadOnly(false)]
        [Column("P031B008", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 28)]
        public System.Nullable<System.Int32> P031B008 { get; set; }

        [ReadOnly(false)]
        [Column("P031B009", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 29)]
        public System.Nullable<System.Int32> P031B009 { get; set; }

        [ReadOnly(false)]
        [Column("P031B010", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 30)]
        public System.Nullable<System.Int32> P031B010 { get; set; }

        [ReadOnly(false)]
        [Column("P031B011", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 31)]
        public System.Nullable<System.Int32> P031B011 { get; set; }

        [ReadOnly(false)]
        [Column("P031B012", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 32)]
        public System.Nullable<System.Int32> P031B012 { get; set; }

        [ReadOnly(false)]
        [Column("P031B013", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 33)]
        public System.Nullable<System.Int32> P031B013 { get; set; }

        [ReadOnly(false)]
        [Column("P031B014", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 34)]
        public System.Nullable<System.Int32> P031B014 { get; set; }

        [ReadOnly(false)]
        [Column("P031B015", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 35)]
        public System.Nullable<System.Int32> P031B015 { get; set; }

        [ReadOnly(false)]
        [Column("P031B016", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 36)]
        public System.Nullable<System.Int32> P031B016 { get; set; }

        [ReadOnly(false)]
        [Column("P031C001", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 37)]
        public System.Nullable<System.Int32> P031C001 { get; set; }

        [ReadOnly(false)]
        [Column("P031C002", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 38)]
        public System.Nullable<System.Int32> P031C002 { get; set; }

        [ReadOnly(false)]
        [Column("P031C003", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 39)]
        public System.Nullable<System.Int32> P031C003 { get; set; }

        [ReadOnly(false)]
        [Column("P031C004", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Related child:", ShortName = "Related child:", Order = 40)]
        public System.Nullable<System.Int32> P031C004 { get; set; }

        [ReadOnly(false)]
        [Column("P031C005", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Own child:", ShortName = "Own child:", Order = 41)]
        public System.Nullable<System.Int32> P031C005 { get; set; }

        [ReadOnly(false)]
        [Column("P031C006", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 42)]
        public System.Nullable<System.Int32> P031C006 { get; set; }

        [ReadOnly(false)]
        [Column("P031C007", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In other family:", ShortName = "In other family:", Order = 43)]
        public System.Nullable<System.Int32> P031C007 { get; set; }

        [ReadOnly(false)]
        [Column("P031C008", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 44)]
        public System.Nullable<System.Int32> P031C008 { get; set; }

        [ReadOnly(false)]
        [Column("P031C009", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 45)]
        public System.Nullable<System.Int32> P031C009 { get; set; }

        [ReadOnly(false)]
        [Column("P031C010", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 46)]
        public System.Nullable<System.Int32> P031C010 { get; set; }

        [ReadOnly(false)]
        [Column("P031C011", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 47)]
        public System.Nullable<System.Int32> P031C011 { get; set; }

        [ReadOnly(false)]
        [Column("P031C012", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 48)]
        public System.Nullable<System.Int32> P031C012 { get; set; }

        [ReadOnly(false)]
        [Column("P031C013", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 49)]
        public System.Nullable<System.Int32> P031C013 { get; set; }

        [ReadOnly(false)]
        [Column("P031C014", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 50)]
        public System.Nullable<System.Int32> P031C014 { get; set; }

        [ReadOnly(false)]
        [Column("P031C015", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 51)]
        public System.Nullable<System.Int32> P031C015 { get; set; }

        [ReadOnly(false)]
        [Column("P031C016", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 52)]
        public System.Nullable<System.Int32> P031C016 { get; set; }

        [ReadOnly(false)]
        [Column("P031D001", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 53)]
        public System.Nullable<System.Int32> P031D001 { get; set; }

        [ReadOnly(false)]
        [Column("P031D002", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 54)]
        public System.Nullable<System.Int32> P031D002 { get; set; }

        [ReadOnly(false)]
        [Column("P031D003", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 55)]
        public System.Nullable<System.Int32> P031D003 { get; set; }

        [ReadOnly(false)]
        [Column("P031D004", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Related child:", ShortName = "Related child:", Order = 56)]
        public System.Nullable<System.Int32> P031D004 { get; set; }

        [ReadOnly(false)]
        [Column("P031D005", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Own child:", ShortName = "Own child:", Order = 57)]
        public System.Nullable<System.Int32> P031D005 { get; set; }

        [ReadOnly(false)]
        [Column("P031D006", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 58)]
        public System.Nullable<System.Int32> P031D006 { get; set; }

        [ReadOnly(false)]
        [Column("P031D007", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In other family:", ShortName = "In other family:", Order = 59)]
        public System.Nullable<System.Int32> P031D007 { get; set; }

        [ReadOnly(false)]
        [Column("P031D008", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 60)]
        public System.Nullable<System.Int32> P031D008 { get; set; }

        [ReadOnly(false)]
        [Column("P031D009", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 61)]
        public System.Nullable<System.Int32> P031D009 { get; set; }

        [ReadOnly(false)]
        [Column("P031D010", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 62)]
        public System.Nullable<System.Int32> P031D010 { get; set; }

        [ReadOnly(false)]
        [Column("P031D011", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 63)]
        public System.Nullable<System.Int32> P031D011 { get; set; }

        [ReadOnly(false)]
        [Column("P031D012", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 64)]
        public System.Nullable<System.Int32> P031D012 { get; set; }

        [ReadOnly(false)]
        [Column("P031D013", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 65)]
        public System.Nullable<System.Int32> P031D013 { get; set; }

        [ReadOnly(false)]
        [Column("P031D014", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 66)]
        public System.Nullable<System.Int32> P031D014 { get; set; }

        [ReadOnly(false)]
        [Column("P031D015", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 67)]
        public System.Nullable<System.Int32> P031D015 { get; set; }

        [ReadOnly(false)]
        [Column("P031D016", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 68)]
        public System.Nullable<System.Int32> P031D016 { get; set; }

        [ReadOnly(false)]
        [Column("P031E001", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 69)]
        public System.Nullable<System.Int32> P031E001 { get; set; }

        [ReadOnly(false)]
        [Column("P031E002", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 70)]
        public System.Nullable<System.Int32> P031E002 { get; set; }

        [ReadOnly(false)]
        [Column("P031E003", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 71)]
        public System.Nullable<System.Int32> P031E003 { get; set; }

        [ReadOnly(false)]
        [Column("P031E004", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Related child:", ShortName = "Related child:", Order = 72)]
        public System.Nullable<System.Int32> P031E004 { get; set; }

        [ReadOnly(false)]
        [Column("P031E005", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Own child:", ShortName = "Own child:", Order = 73)]
        public System.Nullable<System.Int32> P031E005 { get; set; }

        [ReadOnly(false)]
        [Column("P031E006", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 74)]
        public System.Nullable<System.Int32> P031E006 { get; set; }

        [ReadOnly(false)]
        [Column("P031E007", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In other family:", ShortName = "In other family:", Order = 75)]
        public System.Nullable<System.Int32> P031E007 { get; set; }

        [ReadOnly(false)]
        [Column("P031E008", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 76)]
        public System.Nullable<System.Int32> P031E008 { get; set; }

        [ReadOnly(false)]
        [Column("P031E009", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 77)]
        public System.Nullable<System.Int32> P031E009 { get; set; }

        [ReadOnly(false)]
        [Column("P031E010", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 78)]
        public System.Nullable<System.Int32> P031E010 { get; set; }

        [ReadOnly(false)]
        [Column("P031E011", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 79)]
        public System.Nullable<System.Int32> P031E011 { get; set; }

        [ReadOnly(false)]
        [Column("P031E012", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 80)]
        public System.Nullable<System.Int32> P031E012 { get; set; }

        [ReadOnly(false)]
        [Column("P031E013", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 81)]
        public System.Nullable<System.Int32> P031E013 { get; set; }

        [ReadOnly(false)]
        [Column("P031E014", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 82)]
        public System.Nullable<System.Int32> P031E014 { get; set; }

        [ReadOnly(false)]
        [Column("P031E015", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 83)]
        public System.Nullable<System.Int32> P031E015 { get; set; }

        [ReadOnly(false)]
        [Column("P031E016", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 84)]
        public System.Nullable<System.Int32> P031E016 { get; set; }

        [ReadOnly(false)]
        [Column("P031F001", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 85)]
        public System.Nullable<System.Int32> P031F001 { get; set; }

        [ReadOnly(false)]
        [Column("P031F002", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 86)]
        public System.Nullable<System.Int32> P031F002 { get; set; }

        [ReadOnly(false)]
        [Column("P031F003", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 87)]
        public System.Nullable<System.Int32> P031F003 { get; set; }

        [ReadOnly(false)]
        [Column("P031F004", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Related child:", ShortName = "Related child:", Order = 88)]
        public System.Nullable<System.Int32> P031F004 { get; set; }

        [ReadOnly(false)]
        [Column("P031F005", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Own child:", ShortName = "Own child:", Order = 89)]
        public System.Nullable<System.Int32> P031F005 { get; set; }

        [ReadOnly(false)]
        [Column("P031F006", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 90)]
        public System.Nullable<System.Int32> P031F006 { get; set; }

        [ReadOnly(false)]
        [Column("P031F007", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In other family:", ShortName = "In other family:", Order = 91)]
        public System.Nullable<System.Int32> P031F007 { get; set; }

        [ReadOnly(false)]
        [Column("P031F008", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 92)]
        public System.Nullable<System.Int32> P031F008 { get; set; }

        [ReadOnly(false)]
        [Column("P031F009", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 93)]
        public System.Nullable<System.Int32> P031F009 { get; set; }

        [ReadOnly(false)]
        [Column("P031F010", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 94)]
        public System.Nullable<System.Int32> P031F010 { get; set; }

        [ReadOnly(false)]
        [Column("P031F011", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 95)]
        public System.Nullable<System.Int32> P031F011 { get; set; }

        [ReadOnly(false)]
        [Column("P031F012", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 96)]
        public System.Nullable<System.Int32> P031F012 { get; set; }

        [ReadOnly(false)]
        [Column("P031F013", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 97)]
        public System.Nullable<System.Int32> P031F013 { get; set; }

        [ReadOnly(false)]
        [Column("P031F014", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 98)]
        public System.Nullable<System.Int32> P031F014 { get; set; }

        [ReadOnly(false)]
        [Column("P031F015", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 99)]
        public System.Nullable<System.Int32> P031F015 { get; set; }

        [ReadOnly(false)]
        [Column("P031F016", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 100)]
        public System.Nullable<System.Int32> P031F016 { get; set; }

        [ReadOnly(false)]
        [Column("P031G001", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 101)]
        public System.Nullable<System.Int32> P031G001 { get; set; }

        [ReadOnly(false)]
        [Column("P031G002", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 102)]
        public System.Nullable<System.Int32> P031G002 { get; set; }

        [ReadOnly(false)]
        [Column("P031G003", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 103)]
        public System.Nullable<System.Int32> P031G003 { get; set; }

        [ReadOnly(false)]
        [Column("P031G004", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Related child:", ShortName = "Related child:", Order = 104)]
        public System.Nullable<System.Int32> P031G004 { get; set; }

        [ReadOnly(false)]
        [Column("P031G005", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Own child:", ShortName = "Own child:", Order = 105)]
        public System.Nullable<System.Int32> P031G005 { get; set; }

        [ReadOnly(false)]
        [Column("P031G006", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 106)]
        public System.Nullable<System.Int32> P031G006 { get; set; }

        [ReadOnly(false)]
        [Column("P031G007", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In other family:", ShortName = "In other family:", Order = 107)]
        public System.Nullable<System.Int32> P031G007 { get; set; }

        [ReadOnly(false)]
        [Column("P031G008", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 108)]
        public System.Nullable<System.Int32> P031G008 { get; set; }

        [ReadOnly(false)]
        [Column("P031G009", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 109)]
        public System.Nullable<System.Int32> P031G009 { get; set; }

        [ReadOnly(false)]
        [Column("P031G010", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 110)]
        public System.Nullable<System.Int32> P031G010 { get; set; }

        [ReadOnly(false)]
        [Column("P031G011", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 111)]
        public System.Nullable<System.Int32> P031G011 { get; set; }

        [ReadOnly(false)]
        [Column("P031G012", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 112)]
        public System.Nullable<System.Int32> P031G012 { get; set; }

        [ReadOnly(false)]
        [Column("P031G013", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 113)]
        public System.Nullable<System.Int32> P031G013 { get; set; }

        [ReadOnly(false)]
        [Column("P031G014", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 114)]
        public System.Nullable<System.Int32> P031G014 { get; set; }

        [ReadOnly(false)]
        [Column("P031G015", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 115)]
        public System.Nullable<System.Int32> P031G015 { get; set; }

        [ReadOnly(false)]
        [Column("P031G016", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 116)]
        public System.Nullable<System.Int32> P031G016 { get; set; }

        [ReadOnly(false)]
        [Column("P031H001", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 117)]
        public System.Nullable<System.Int32> P031H001 { get; set; }

        [ReadOnly(false)]
        [Column("P031H002", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 118)]
        public System.Nullable<System.Int32> P031H002 { get; set; }

        [ReadOnly(false)]
        [Column("P031H003", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 119)]
        public System.Nullable<System.Int32> P031H003 { get; set; }

        [ReadOnly(false)]
        [Column("P031H004", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Related child:", ShortName = "Related child:", Order = 120)]
        public System.Nullable<System.Int32> P031H004 { get; set; }

        [ReadOnly(false)]
        [Column("P031H005", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Own child:", ShortName = "Own child:", Order = 121)]
        public System.Nullable<System.Int32> P031H005 { get; set; }

        [ReadOnly(false)]
        [Column("P031H006", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 122)]
        public System.Nullable<System.Int32> P031H006 { get; set; }

        [ReadOnly(false)]
        [Column("P031H007", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In other family:", ShortName = "In other family:", Order = 123)]
        public System.Nullable<System.Int32> P031H007 { get; set; }

        [ReadOnly(false)]
        [Column("P031H008", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 124)]
        public System.Nullable<System.Int32> P031H008 { get; set; }

        [ReadOnly(false)]
        [Column("P031H009", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 125)]
        public System.Nullable<System.Int32> P031H009 { get; set; }

        [ReadOnly(false)]
        [Column("P031H010", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 126)]
        public System.Nullable<System.Int32> P031H010 { get; set; }

        [ReadOnly(false)]
        [Column("P031H011", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 127)]
        public System.Nullable<System.Int32> P031H011 { get; set; }

        [ReadOnly(false)]
        [Column("P031H012", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 128)]
        public System.Nullable<System.Int32> P031H012 { get; set; }

        [ReadOnly(false)]
        [Column("P031H013", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 129)]
        public System.Nullable<System.Int32> P031H013 { get; set; }

        [ReadOnly(false)]
        [Column("P031H014", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 130)]
        public System.Nullable<System.Int32> P031H014 { get; set; }

        [ReadOnly(false)]
        [Column("P031H015", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 131)]
        public System.Nullable<System.Int32> P031H015 { get; set; }

        [ReadOnly(false)]
        [Column("P031H016", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 132)]
        public System.Nullable<System.Int32> P031H016 { get; set; }

        [ReadOnly(false)]
        [Column("P031I001", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 133)]
        public System.Nullable<System.Int32> P031I001 { get; set; }

        [ReadOnly(false)]
        [Column("P031I002", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 134)]
        public System.Nullable<System.Int32> P031I002 { get; set; }

        [ReadOnly(false)]
        [Column("P031I003", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 135)]
        public System.Nullable<System.Int32> P031I003 { get; set; }

        [ReadOnly(false)]
        [Column("P031I004", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Related child:", ShortName = "Related child:", Order = 136)]
        public System.Nullable<System.Int32> P031I004 { get; set; }

        [ReadOnly(false)]
        [Column("P031I005", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Own child:", ShortName = "Own child:", Order = 137)]
        public System.Nullable<System.Int32> P031I005 { get; set; }

        [ReadOnly(false)]
        [Column("P031I006", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 138)]
        public System.Nullable<System.Int32> P031I006 { get; set; }

        [ReadOnly(false)]
        [Column("P031I007", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In other family:", ShortName = "In other family:", Order = 139)]
        public System.Nullable<System.Int32> P031I007 { get; set; }

        [ReadOnly(false)]
        [Column("P031I008", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 140)]
        public System.Nullable<System.Int32> P031I008 { get; set; }

        [ReadOnly(false)]
        [Column("P031I009", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 141)]
        public System.Nullable<System.Int32> P031I009 { get; set; }

        [ReadOnly(false)]
        [Column("P031I010", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 142)]
        public System.Nullable<System.Int32> P031I010 { get; set; }

        [ReadOnly(false)]
        [Column("P031I011", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 143)]
        public System.Nullable<System.Int32> P031I011 { get; set; }

        [ReadOnly(false)]
        [Column("P031I012", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 144)]
        public System.Nullable<System.Int32> P031I012 { get; set; }

        [ReadOnly(false)]
        [Column("P031I013", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 145)]
        public System.Nullable<System.Int32> P031I013 { get; set; }

        [ReadOnly(false)]
        [Column("P031I014", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 146)]
        public System.Nullable<System.Int32> P031I014 { get; set; }

        [ReadOnly(false)]
        [Column("P031I015", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 147)]
        public System.Nullable<System.Int32> P031I015 { get; set; }

        [ReadOnly(false)]
        [Column("P031I016", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 148)]
        public System.Nullable<System.Int32> P031I016 { get; set; }

        [ReadOnly(false)]
        [Column("P034A001", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 149)]
        public System.Nullable<System.Int32> P034A001 { get; set; }

        [ReadOnly(false)]
        [Column("P034A002", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 150)]
        public System.Nullable<System.Int32> P034A002 { get; set; }

        [ReadOnly(false)]
        [Column("P034A003", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 151)]
        public System.Nullable<System.Int32> P034A003 { get; set; }

        [ReadOnly(false)]
        [Column("P034A004", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder:", ShortName = "Householder:", Order = 152)]
        public System.Nullable<System.Int32> P034A004 { get; set; }

        [ReadOnly(false)]
        [Column("P034A005", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 153)]
        public System.Nullable<System.Int32> P034A005 { get; set; }

        [ReadOnly(false)]
        [Column("P034A006", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 154)]
        public System.Nullable<System.Int32> P034A006 { get; set; }

        [ReadOnly(false)]
        [Column("P034A007", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spouse", ShortName = "Spouse", Order = 155)]
        public System.Nullable<System.Int32> P034A007 { get; set; }

        [ReadOnly(false)]
        [Column("P034A008", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent", ShortName = "Parent", Order = 156)]
        public System.Nullable<System.Int32> P034A008 { get; set; }

        [ReadOnly(false)]
        [Column("P034A009", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 157)]
        public System.Nullable<System.Int32> P034A009 { get; set; }

        [ReadOnly(false)]
        [Column("P034A010", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 158)]
        public System.Nullable<System.Int32> P034A010 { get; set; }

        [ReadOnly(false)]
        [Column("P034A011", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 159)]
        public System.Nullable<System.Int32> P034A011 { get; set; }

        [ReadOnly(false)]
        [Column("P034A012", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 160)]
        public System.Nullable<System.Int32> P034A012 { get; set; }

        [ReadOnly(false)]
        [Column("P034A013", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 161)]
        public System.Nullable<System.Int32> P034A013 { get; set; }

        [ReadOnly(false)]
        [Column("P034A014", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 162)]
        public System.Nullable<System.Int32> P034A014 { get; set; }

        [ReadOnly(false)]
        [Column("P034A015", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 163)]
        public System.Nullable<System.Int32> P034A015 { get; set; }

        [ReadOnly(false)]
        [Column("P034A016", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 164)]
        public System.Nullable<System.Int32> P034A016 { get; set; }

        [ReadOnly(false)]
        [Column("P034A017", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 165)]
        public System.Nullable<System.Int32> P034A017 { get; set; }

        [ReadOnly(false)]
        [Column("P034A018", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 166)]
        public System.Nullable<System.Int32> P034A018 { get; set; }

        [ReadOnly(false)]
        [Column("P034A019", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 167)]
        public System.Nullable<System.Int32> P034A019 { get; set; }

        [ReadOnly(false)]
        [Column("P034A020", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 168)]
        public System.Nullable<System.Int32> P034A020 { get; set; }

        [ReadOnly(false)]
        [Column("P034A021", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 169)]
        public System.Nullable<System.Int32> P034A021 { get; set; }

        [ReadOnly(false)]
        [Column("P034A022", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 170)]
        public System.Nullable<System.Int32> P034A022 { get; set; }

        [ReadOnly(false)]
        [Column("P034B001", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 171)]
        public System.Nullable<System.Int32> P034B001 { get; set; }

        [ReadOnly(false)]
        [Column("P034B002", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 172)]
        public System.Nullable<System.Int32> P034B002 { get; set; }

        [ReadOnly(false)]
        [Column("P034B003", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 173)]
        public System.Nullable<System.Int32> P034B003 { get; set; }

        [ReadOnly(false)]
        [Column("P034B004", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder:", ShortName = "Householder:", Order = 174)]
        public System.Nullable<System.Int32> P034B004 { get; set; }

        [ReadOnly(false)]
        [Column("P034B005", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 175)]
        public System.Nullable<System.Int32> P034B005 { get; set; }

        [ReadOnly(false)]
        [Column("P034B006", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 176)]
        public System.Nullable<System.Int32> P034B006 { get; set; }

        [ReadOnly(false)]
        [Column("P034B007", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spouse", ShortName = "Spouse", Order = 177)]
        public System.Nullable<System.Int32> P034B007 { get; set; }

        [ReadOnly(false)]
        [Column("P034B008", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent", ShortName = "Parent", Order = 178)]
        public System.Nullable<System.Int32> P034B008 { get; set; }

        [ReadOnly(false)]
        [Column("P034B009", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 179)]
        public System.Nullable<System.Int32> P034B009 { get; set; }

        [ReadOnly(false)]
        [Column("P034B010", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 180)]
        public System.Nullable<System.Int32> P034B010 { get; set; }

        [ReadOnly(false)]
        [Column("P034B011", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 181)]
        public System.Nullable<System.Int32> P034B011 { get; set; }

        [ReadOnly(false)]
        [Column("P034B012", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 182)]
        public System.Nullable<System.Int32> P034B012 { get; set; }

        [ReadOnly(false)]
        [Column("P034B013", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 183)]
        public System.Nullable<System.Int32> P034B013 { get; set; }

        [ReadOnly(false)]
        [Column("P034B014", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 184)]
        public System.Nullable<System.Int32> P034B014 { get; set; }

        [ReadOnly(false)]
        [Column("P034B015", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 185)]
        public System.Nullable<System.Int32> P034B015 { get; set; }

        [ReadOnly(false)]
        [Column("P034B016", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 186)]
        public System.Nullable<System.Int32> P034B016 { get; set; }

        [ReadOnly(false)]
        [Column("P034B017", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 187)]
        public System.Nullable<System.Int32> P034B017 { get; set; }

        [ReadOnly(false)]
        [Column("P034B018", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 188)]
        public System.Nullable<System.Int32> P034B018 { get; set; }

        [ReadOnly(false)]
        [Column("P034B019", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 189)]
        public System.Nullable<System.Int32> P034B019 { get; set; }

        [ReadOnly(false)]
        [Column("P034B020", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 190)]
        public System.Nullable<System.Int32> P034B020 { get; set; }

        [ReadOnly(false)]
        [Column("P034B021", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 191)]
        public System.Nullable<System.Int32> P034B021 { get; set; }

        [ReadOnly(false)]
        [Column("P034B022", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 192)]
        public System.Nullable<System.Int32> P034B022 { get; set; }

        [ReadOnly(false)]
        [Column("P034C001", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 193)]
        public System.Nullable<System.Int32> P034C001 { get; set; }

        [ReadOnly(false)]
        [Column("P034C002", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 194)]
        public System.Nullable<System.Int32> P034C002 { get; set; }

        [ReadOnly(false)]
        [Column("P034C003", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 195)]
        public System.Nullable<System.Int32> P034C003 { get; set; }

        [ReadOnly(false)]
        [Column("P034C004", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder:", ShortName = "Householder:", Order = 196)]
        public System.Nullable<System.Int32> P034C004 { get; set; }

        [ReadOnly(false)]
        [Column("P034C005", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 197)]
        public System.Nullable<System.Int32> P034C005 { get; set; }

        [ReadOnly(false)]
        [Column("P034C006", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 198)]
        public System.Nullable<System.Int32> P034C006 { get; set; }

        [ReadOnly(false)]
        [Column("P034C007", Order = 199)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spouse", ShortName = "Spouse", Order = 199)]
        public System.Nullable<System.Int32> P034C007 { get; set; }

        [ReadOnly(false)]
        [Column("P034C008", Order = 200)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent", ShortName = "Parent", Order = 200)]
        public System.Nullable<System.Int32> P034C008 { get; set; }

        [ReadOnly(false)]
        [Column("P034C009", Order = 201)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 201)]
        public System.Nullable<System.Int32> P034C009 { get; set; }

        [ReadOnly(false)]
        [Column("P034C010", Order = 202)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 202)]
        public System.Nullable<System.Int32> P034C010 { get; set; }

        [ReadOnly(false)]
        [Column("P034C011", Order = 203)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 203)]
        public System.Nullable<System.Int32> P034C011 { get; set; }

        [ReadOnly(false)]
        [Column("P034C012", Order = 204)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 204)]
        public System.Nullable<System.Int32> P034C012 { get; set; }

        [ReadOnly(false)]
        [Column("P034C013", Order = 205)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 205)]
        public System.Nullable<System.Int32> P034C013 { get; set; }

        [ReadOnly(false)]
        [Column("P034C014", Order = 206)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 206)]
        public System.Nullable<System.Int32> P034C014 { get; set; }

        [ReadOnly(false)]
        [Column("P034C015", Order = 207)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 207)]
        public System.Nullable<System.Int32> P034C015 { get; set; }

        [ReadOnly(false)]
        [Column("P034C016", Order = 208)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 208)]
        public System.Nullable<System.Int32> P034C016 { get; set; }

        [ReadOnly(false)]
        [Column("P034C017", Order = 209)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 209)]
        public System.Nullable<System.Int32> P034C017 { get; set; }

        [ReadOnly(false)]
        [Column("P034C018", Order = 210)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 210)]
        public System.Nullable<System.Int32> P034C018 { get; set; }

        [ReadOnly(false)]
        [Column("P034C019", Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 211)]
        public System.Nullable<System.Int32> P034C019 { get; set; }

        [ReadOnly(false)]
        [Column("P034C020", Order = 212)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 212)]
        public System.Nullable<System.Int32> P034C020 { get; set; }

        [ReadOnly(false)]
        [Column("P034C021", Order = 213)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 213)]
        public System.Nullable<System.Int32> P034C021 { get; set; }

        [ReadOnly(false)]
        [Column("P034C022", Order = 214)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 214)]
        public System.Nullable<System.Int32> P034C022 { get; set; }

        [ReadOnly(false)]
        [Column("P034D001", Order = 215)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 215)]
        public System.Nullable<System.Int32> P034D001 { get; set; }

        [ReadOnly(false)]
        [Column("P034D002", Order = 216)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 216)]
        public System.Nullable<System.Int32> P034D002 { get; set; }

        [ReadOnly(false)]
        [Column("P034D003", Order = 217)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 217)]
        public System.Nullable<System.Int32> P034D003 { get; set; }

        [ReadOnly(false)]
        [Column("P034D004", Order = 218)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder:", ShortName = "Householder:", Order = 218)]
        public System.Nullable<System.Int32> P034D004 { get; set; }

        [ReadOnly(false)]
        [Column("P034D005", Order = 219)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 219)]
        public System.Nullable<System.Int32> P034D005 { get; set; }

        [ReadOnly(false)]
        [Column("P034D006", Order = 220)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 220)]
        public System.Nullable<System.Int32> P034D006 { get; set; }

        [ReadOnly(false)]
        [Column("P034D007", Order = 221)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spouse", ShortName = "Spouse", Order = 221)]
        public System.Nullable<System.Int32> P034D007 { get; set; }

        [ReadOnly(false)]
        [Column("P034D008", Order = 222)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent", ShortName = "Parent", Order = 222)]
        public System.Nullable<System.Int32> P034D008 { get; set; }

        [ReadOnly(false)]
        [Column("P034D009", Order = 223)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 223)]
        public System.Nullable<System.Int32> P034D009 { get; set; }

        [ReadOnly(false)]
        [Column("P034D010", Order = 224)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 224)]
        public System.Nullable<System.Int32> P034D010 { get; set; }

        [ReadOnly(false)]
        [Column("P034D011", Order = 225)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 225)]
        public System.Nullable<System.Int32> P034D011 { get; set; }

        [ReadOnly(false)]
        [Column("P034D012", Order = 226)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 226)]
        public System.Nullable<System.Int32> P034D012 { get; set; }

        [ReadOnly(false)]
        [Column("P034D013", Order = 227)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 227)]
        public System.Nullable<System.Int32> P034D013 { get; set; }

        [ReadOnly(false)]
        [Column("P034D014", Order = 228)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 228)]
        public System.Nullable<System.Int32> P034D014 { get; set; }

        [ReadOnly(false)]
        [Column("P034D015", Order = 229)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 229)]
        public System.Nullable<System.Int32> P034D015 { get; set; }

        [ReadOnly(false)]
        [Column("P034D016", Order = 230)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 230)]
        public System.Nullable<System.Int32> P034D016 { get; set; }

        [ReadOnly(false)]
        [Column("P034D017", Order = 231)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 231)]
        public System.Nullable<System.Int32> P034D017 { get; set; }

        [ReadOnly(false)]
        [Column("P034D018", Order = 232)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 232)]
        public System.Nullable<System.Int32> P034D018 { get; set; }

        [ReadOnly(false)]
        [Column("P034D019", Order = 233)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 233)]
        public System.Nullable<System.Int32> P034D019 { get; set; }

        [ReadOnly(false)]
        [Column("P034D020", Order = 234)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 234)]
        public System.Nullable<System.Int32> P034D020 { get; set; }

        [ReadOnly(false)]
        [Column("P034D021", Order = 235)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 235)]
        public System.Nullable<System.Int32> P034D021 { get; set; }

        [ReadOnly(false)]
        [Column("P034D022", Order = 236)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 236)]
        public System.Nullable<System.Int32> P034D022 { get; set; }

        [ReadOnly(false)]
        [Column("P034E001", Order = 237)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 237)]
        public System.Nullable<System.Int32> P034E001 { get; set; }

        [ReadOnly(false)]
        [Column("P034E002", Order = 238)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 238)]
        public System.Nullable<System.Int32> P034E002 { get; set; }

        [ReadOnly(false)]
        [Column("P034E003", Order = 239)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 239)]
        public System.Nullable<System.Int32> P034E003 { get; set; }

        [ReadOnly(false)]
        [Column("P034E004", Order = 240)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder:", ShortName = "Householder:", Order = 240)]
        public System.Nullable<System.Int32> P034E004 { get; set; }

        [ReadOnly(false)]
        [Column("P034E005", Order = 241)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 241)]
        public System.Nullable<System.Int32> P034E005 { get; set; }

        [ReadOnly(false)]
        [Column("P034E006", Order = 242)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 242)]
        public System.Nullable<System.Int32> P034E006 { get; set; }

        [ReadOnly(false)]
        [Column("P034E007", Order = 243)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spouse", ShortName = "Spouse", Order = 243)]
        public System.Nullable<System.Int32> P034E007 { get; set; }

        [ReadOnly(false)]
        [Column("P034E008", Order = 244)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent", ShortName = "Parent", Order = 244)]
        public System.Nullable<System.Int32> P034E008 { get; set; }

        [ReadOnly(false)]
        [Column("P034E009", Order = 245)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 245)]
        public System.Nullable<System.Int32> P034E009 { get; set; }

        [ReadOnly(false)]
        [Column("P034E010", Order = 246)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 246)]
        public System.Nullable<System.Int32> P034E010 { get; set; }

        [ReadOnly(false)]
        [Column("P034E011", Order = 247)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 247)]
        public System.Nullable<System.Int32> P034E011 { get; set; }

        [ReadOnly(false)]
        [Column("P034E012", Order = 248)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 248)]
        public System.Nullable<System.Int32> P034E012 { get; set; }

        [ReadOnly(false)]
        [Column("P034E013", Order = 249)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 249)]
        public System.Nullable<System.Int32> P034E013 { get; set; }

        [ReadOnly(false)]
        [Column("P034E014", Order = 250)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 250)]
        public System.Nullable<System.Int32> P034E014 { get; set; }

        [ReadOnly(false)]
        [Column("P034E015", Order = 251)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 251)]
        public System.Nullable<System.Int32> P034E015 { get; set; }

        [ReadOnly(false)]
        [Column("P034E016", Order = 252)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 252)]
        public System.Nullable<System.Int32> P034E016 { get; set; }

        [ReadOnly(false)]
        [Column("P034E017", Order = 253)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 253)]
        public System.Nullable<System.Int32> P034E017 { get; set; }

        [ReadOnly(false)]
        [Column("P034E018", Order = 254)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 254)]
        public System.Nullable<System.Int32> P034E018 { get; set; }

        [ReadOnly(false)]
        [Column("P034E019", Order = 255)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 255)]
        public System.Nullable<System.Int32> P034E019 { get; set; }

        [ReadOnly(false)]
        [Column("P034E020", Order = 256)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 256)]
        public System.Nullable<System.Int32> P034E020 { get; set; }

        [ReadOnly(false)]
        [Column("P034E021", Order = 257)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 257)]
        public System.Nullable<System.Int32> P034E021 { get; set; }

        [ReadOnly(false)]
        [Column("P034E022", Order = 258)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 258)]
        public System.Nullable<System.Int32> P034E022 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1_00011(string csvLine) : base(csvLine) {}

        public SF1_00011(string[] values) : base(values) {}

        public SF1_00011(OleDbDataReader reader, CensusFileType fileType)
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
                P031A001 = (System.Nullable<System.Int32>)reader[5];
            }
            if(reader[6] != DBNull.Value)
            {
                P031A002 = (System.Nullable<System.Int32>)reader[6];
            }
            if(reader[7] != DBNull.Value)
            {
                P031A003 = (System.Nullable<System.Int32>)reader[7];
            }
            if(reader[8] != DBNull.Value)
            {
                P031A004 = (System.Nullable<System.Int32>)reader[8];
            }
            if(reader[9] != DBNull.Value)
            {
                P031A005 = (System.Nullable<System.Int32>)reader[9];
            }
            if(reader[10] != DBNull.Value)
            {
                P031A006 = (System.Nullable<System.Int32>)reader[10];
            }
            if(reader[11] != DBNull.Value)
            {
                P031A007 = (System.Nullable<System.Int32>)reader[11];
            }
            if(reader[12] != DBNull.Value)
            {
                P031A008 = (System.Nullable<System.Int32>)reader[12];
            }
            if(reader[13] != DBNull.Value)
            {
                P031A009 = (System.Nullable<System.Int32>)reader[13];
            }
            if(reader[14] != DBNull.Value)
            {
                P031A010 = (System.Nullable<System.Int32>)reader[14];
            }
            if(reader[15] != DBNull.Value)
            {
                P031A011 = (System.Nullable<System.Int32>)reader[15];
            }
            if(reader[16] != DBNull.Value)
            {
                P031A012 = (System.Nullable<System.Int32>)reader[16];
            }
            if(reader[17] != DBNull.Value)
            {
                P031A013 = (System.Nullable<System.Int32>)reader[17];
            }
            if(reader[18] != DBNull.Value)
            {
                P031A014 = (System.Nullable<System.Int32>)reader[18];
            }
            if(reader[19] != DBNull.Value)
            {
                P031A015 = (System.Nullable<System.Int32>)reader[19];
            }
            if(reader[20] != DBNull.Value)
            {
                P031A016 = (System.Nullable<System.Int32>)reader[20];
            }
            if(reader[21] != DBNull.Value)
            {
                P031B001 = (System.Nullable<System.Int32>)reader[21];
            }
            if(reader[22] != DBNull.Value)
            {
                P031B002 = (System.Nullable<System.Int32>)reader[22];
            }
            if(reader[23] != DBNull.Value)
            {
                P031B003 = (System.Nullable<System.Int32>)reader[23];
            }
            if(reader[24] != DBNull.Value)
            {
                P031B004 = (System.Nullable<System.Int32>)reader[24];
            }
            if(reader[25] != DBNull.Value)
            {
                P031B005 = (System.Nullable<System.Int32>)reader[25];
            }
            if(reader[26] != DBNull.Value)
            {
                P031B006 = (System.Nullable<System.Int32>)reader[26];
            }
            if(reader[27] != DBNull.Value)
            {
                P031B007 = (System.Nullable<System.Int32>)reader[27];
            }
            if(reader[28] != DBNull.Value)
            {
                P031B008 = (System.Nullable<System.Int32>)reader[28];
            }
            if(reader[29] != DBNull.Value)
            {
                P031B009 = (System.Nullable<System.Int32>)reader[29];
            }
            if(reader[30] != DBNull.Value)
            {
                P031B010 = (System.Nullable<System.Int32>)reader[30];
            }
            if(reader[31] != DBNull.Value)
            {
                P031B011 = (System.Nullable<System.Int32>)reader[31];
            }
            if(reader[32] != DBNull.Value)
            {
                P031B012 = (System.Nullable<System.Int32>)reader[32];
            }
            if(reader[33] != DBNull.Value)
            {
                P031B013 = (System.Nullable<System.Int32>)reader[33];
            }
            if(reader[34] != DBNull.Value)
            {
                P031B014 = (System.Nullable<System.Int32>)reader[34];
            }
            if(reader[35] != DBNull.Value)
            {
                P031B015 = (System.Nullable<System.Int32>)reader[35];
            }
            if(reader[36] != DBNull.Value)
            {
                P031B016 = (System.Nullable<System.Int32>)reader[36];
            }
            if(reader[37] != DBNull.Value)
            {
                P031C001 = (System.Nullable<System.Int32>)reader[37];
            }
            if(reader[38] != DBNull.Value)
            {
                P031C002 = (System.Nullable<System.Int32>)reader[38];
            }
            if(reader[39] != DBNull.Value)
            {
                P031C003 = (System.Nullable<System.Int32>)reader[39];
            }
            if(reader[40] != DBNull.Value)
            {
                P031C004 = (System.Nullable<System.Int32>)reader[40];
            }
            if(reader[41] != DBNull.Value)
            {
                P031C005 = (System.Nullable<System.Int32>)reader[41];
            }
            if(reader[42] != DBNull.Value)
            {
                P031C006 = (System.Nullable<System.Int32>)reader[42];
            }
            if(reader[43] != DBNull.Value)
            {
                P031C007 = (System.Nullable<System.Int32>)reader[43];
            }
            if(reader[44] != DBNull.Value)
            {
                P031C008 = (System.Nullable<System.Int32>)reader[44];
            }
            if(reader[45] != DBNull.Value)
            {
                P031C009 = (System.Nullable<System.Int32>)reader[45];
            }
            if(reader[46] != DBNull.Value)
            {
                P031C010 = (System.Nullable<System.Int32>)reader[46];
            }
            if(reader[47] != DBNull.Value)
            {
                P031C011 = (System.Nullable<System.Int32>)reader[47];
            }
            if(reader[48] != DBNull.Value)
            {
                P031C012 = (System.Nullable<System.Int32>)reader[48];
            }
            if(reader[49] != DBNull.Value)
            {
                P031C013 = (System.Nullable<System.Int32>)reader[49];
            }
            if(reader[50] != DBNull.Value)
            {
                P031C014 = (System.Nullable<System.Int32>)reader[50];
            }
            if(reader[51] != DBNull.Value)
            {
                P031C015 = (System.Nullable<System.Int32>)reader[51];
            }
            if(reader[52] != DBNull.Value)
            {
                P031C016 = (System.Nullable<System.Int32>)reader[52];
            }
            if(reader[53] != DBNull.Value)
            {
                P031D001 = (System.Nullable<System.Int32>)reader[53];
            }
            if(reader[54] != DBNull.Value)
            {
                P031D002 = (System.Nullable<System.Int32>)reader[54];
            }
            if(reader[55] != DBNull.Value)
            {
                P031D003 = (System.Nullable<System.Int32>)reader[55];
            }
            if(reader[56] != DBNull.Value)
            {
                P031D004 = (System.Nullable<System.Int32>)reader[56];
            }
            if(reader[57] != DBNull.Value)
            {
                P031D005 = (System.Nullable<System.Int32>)reader[57];
            }
            if(reader[58] != DBNull.Value)
            {
                P031D006 = (System.Nullable<System.Int32>)reader[58];
            }
            if(reader[59] != DBNull.Value)
            {
                P031D007 = (System.Nullable<System.Int32>)reader[59];
            }
            if(reader[60] != DBNull.Value)
            {
                P031D008 = (System.Nullable<System.Int32>)reader[60];
            }
            if(reader[61] != DBNull.Value)
            {
                P031D009 = (System.Nullable<System.Int32>)reader[61];
            }
            if(reader[62] != DBNull.Value)
            {
                P031D010 = (System.Nullable<System.Int32>)reader[62];
            }
            if(reader[63] != DBNull.Value)
            {
                P031D011 = (System.Nullable<System.Int32>)reader[63];
            }
            if(reader[64] != DBNull.Value)
            {
                P031D012 = (System.Nullable<System.Int32>)reader[64];
            }
            if(reader[65] != DBNull.Value)
            {
                P031D013 = (System.Nullable<System.Int32>)reader[65];
            }
            if(reader[66] != DBNull.Value)
            {
                P031D014 = (System.Nullable<System.Int32>)reader[66];
            }
            if(reader[67] != DBNull.Value)
            {
                P031D015 = (System.Nullable<System.Int32>)reader[67];
            }
            if(reader[68] != DBNull.Value)
            {
                P031D016 = (System.Nullable<System.Int32>)reader[68];
            }
            if(reader[69] != DBNull.Value)
            {
                P031E001 = (System.Nullable<System.Int32>)reader[69];
            }
            if(reader[70] != DBNull.Value)
            {
                P031E002 = (System.Nullable<System.Int32>)reader[70];
            }
            if(reader[71] != DBNull.Value)
            {
                P031E003 = (System.Nullable<System.Int32>)reader[71];
            }
            if(reader[72] != DBNull.Value)
            {
                P031E004 = (System.Nullable<System.Int32>)reader[72];
            }
            if(reader[73] != DBNull.Value)
            {
                P031E005 = (System.Nullable<System.Int32>)reader[73];
            }
            if(reader[74] != DBNull.Value)
            {
                P031E006 = (System.Nullable<System.Int32>)reader[74];
            }
            if(reader[75] != DBNull.Value)
            {
                P031E007 = (System.Nullable<System.Int32>)reader[75];
            }
            if(reader[76] != DBNull.Value)
            {
                P031E008 = (System.Nullable<System.Int32>)reader[76];
            }
            if(reader[77] != DBNull.Value)
            {
                P031E009 = (System.Nullable<System.Int32>)reader[77];
            }
            if(reader[78] != DBNull.Value)
            {
                P031E010 = (System.Nullable<System.Int32>)reader[78];
            }
            if(reader[79] != DBNull.Value)
            {
                P031E011 = (System.Nullable<System.Int32>)reader[79];
            }
            if(reader[80] != DBNull.Value)
            {
                P031E012 = (System.Nullable<System.Int32>)reader[80];
            }
            if(reader[81] != DBNull.Value)
            {
                P031E013 = (System.Nullable<System.Int32>)reader[81];
            }
            if(reader[82] != DBNull.Value)
            {
                P031E014 = (System.Nullable<System.Int32>)reader[82];
            }
            if(reader[83] != DBNull.Value)
            {
                P031E015 = (System.Nullable<System.Int32>)reader[83];
            }
            if(reader[84] != DBNull.Value)
            {
                P031E016 = (System.Nullable<System.Int32>)reader[84];
            }
            if(reader[85] != DBNull.Value)
            {
                P031F001 = (System.Nullable<System.Int32>)reader[85];
            }
            if(reader[86] != DBNull.Value)
            {
                P031F002 = (System.Nullable<System.Int32>)reader[86];
            }
            if(reader[87] != DBNull.Value)
            {
                P031F003 = (System.Nullable<System.Int32>)reader[87];
            }
            if(reader[88] != DBNull.Value)
            {
                P031F004 = (System.Nullable<System.Int32>)reader[88];
            }
            if(reader[89] != DBNull.Value)
            {
                P031F005 = (System.Nullable<System.Int32>)reader[89];
            }
            if(reader[90] != DBNull.Value)
            {
                P031F006 = (System.Nullable<System.Int32>)reader[90];
            }
            if(reader[91] != DBNull.Value)
            {
                P031F007 = (System.Nullable<System.Int32>)reader[91];
            }
            if(reader[92] != DBNull.Value)
            {
                P031F008 = (System.Nullable<System.Int32>)reader[92];
            }
            if(reader[93] != DBNull.Value)
            {
                P031F009 = (System.Nullable<System.Int32>)reader[93];
            }
            if(reader[94] != DBNull.Value)
            {
                P031F010 = (System.Nullable<System.Int32>)reader[94];
            }
            if(reader[95] != DBNull.Value)
            {
                P031F011 = (System.Nullable<System.Int32>)reader[95];
            }
            if(reader[96] != DBNull.Value)
            {
                P031F012 = (System.Nullable<System.Int32>)reader[96];
            }
            if(reader[97] != DBNull.Value)
            {
                P031F013 = (System.Nullable<System.Int32>)reader[97];
            }
            if(reader[98] != DBNull.Value)
            {
                P031F014 = (System.Nullable<System.Int32>)reader[98];
            }
            if(reader[99] != DBNull.Value)
            {
                P031F015 = (System.Nullable<System.Int32>)reader[99];
            }
            if(reader[100] != DBNull.Value)
            {
                P031F016 = (System.Nullable<System.Int32>)reader[100];
            }
            if(reader[101] != DBNull.Value)
            {
                P031G001 = (System.Nullable<System.Int32>)reader[101];
            }
            if(reader[102] != DBNull.Value)
            {
                P031G002 = (System.Nullable<System.Int32>)reader[102];
            }
            if(reader[103] != DBNull.Value)
            {
                P031G003 = (System.Nullable<System.Int32>)reader[103];
            }
            if(reader[104] != DBNull.Value)
            {
                P031G004 = (System.Nullable<System.Int32>)reader[104];
            }
            if(reader[105] != DBNull.Value)
            {
                P031G005 = (System.Nullable<System.Int32>)reader[105];
            }
            if(reader[106] != DBNull.Value)
            {
                P031G006 = (System.Nullable<System.Int32>)reader[106];
            }
            if(reader[107] != DBNull.Value)
            {
                P031G007 = (System.Nullable<System.Int32>)reader[107];
            }
            if(reader[108] != DBNull.Value)
            {
                P031G008 = (System.Nullable<System.Int32>)reader[108];
            }
            if(reader[109] != DBNull.Value)
            {
                P031G009 = (System.Nullable<System.Int32>)reader[109];
            }
            if(reader[110] != DBNull.Value)
            {
                P031G010 = (System.Nullable<System.Int32>)reader[110];
            }
            if(reader[111] != DBNull.Value)
            {
                P031G011 = (System.Nullable<System.Int32>)reader[111];
            }
            if(reader[112] != DBNull.Value)
            {
                P031G012 = (System.Nullable<System.Int32>)reader[112];
            }
            if(reader[113] != DBNull.Value)
            {
                P031G013 = (System.Nullable<System.Int32>)reader[113];
            }
            if(reader[114] != DBNull.Value)
            {
                P031G014 = (System.Nullable<System.Int32>)reader[114];
            }
            if(reader[115] != DBNull.Value)
            {
                P031G015 = (System.Nullable<System.Int32>)reader[115];
            }
            if(reader[116] != DBNull.Value)
            {
                P031G016 = (System.Nullable<System.Int32>)reader[116];
            }
            if(reader[117] != DBNull.Value)
            {
                P031H001 = (System.Nullable<System.Int32>)reader[117];
            }
            if(reader[118] != DBNull.Value)
            {
                P031H002 = (System.Nullable<System.Int32>)reader[118];
            }
            if(reader[119] != DBNull.Value)
            {
                P031H003 = (System.Nullable<System.Int32>)reader[119];
            }
            if(reader[120] != DBNull.Value)
            {
                P031H004 = (System.Nullable<System.Int32>)reader[120];
            }
            if(reader[121] != DBNull.Value)
            {
                P031H005 = (System.Nullable<System.Int32>)reader[121];
            }
            if(reader[122] != DBNull.Value)
            {
                P031H006 = (System.Nullable<System.Int32>)reader[122];
            }
            if(reader[123] != DBNull.Value)
            {
                P031H007 = (System.Nullable<System.Int32>)reader[123];
            }
            if(reader[124] != DBNull.Value)
            {
                P031H008 = (System.Nullable<System.Int32>)reader[124];
            }
            if(reader[125] != DBNull.Value)
            {
                P031H009 = (System.Nullable<System.Int32>)reader[125];
            }
            if(reader[126] != DBNull.Value)
            {
                P031H010 = (System.Nullable<System.Int32>)reader[126];
            }
            if(reader[127] != DBNull.Value)
            {
                P031H011 = (System.Nullable<System.Int32>)reader[127];
            }
            if(reader[128] != DBNull.Value)
            {
                P031H012 = (System.Nullable<System.Int32>)reader[128];
            }
            if(reader[129] != DBNull.Value)
            {
                P031H013 = (System.Nullable<System.Int32>)reader[129];
            }
            if(reader[130] != DBNull.Value)
            {
                P031H014 = (System.Nullable<System.Int32>)reader[130];
            }
            if(reader[131] != DBNull.Value)
            {
                P031H015 = (System.Nullable<System.Int32>)reader[131];
            }
            if(reader[132] != DBNull.Value)
            {
                P031H016 = (System.Nullable<System.Int32>)reader[132];
            }
            if(reader[133] != DBNull.Value)
            {
                P031I001 = (System.Nullable<System.Int32>)reader[133];
            }
            if(reader[134] != DBNull.Value)
            {
                P031I002 = (System.Nullable<System.Int32>)reader[134];
            }
            if(reader[135] != DBNull.Value)
            {
                P031I003 = (System.Nullable<System.Int32>)reader[135];
            }
            if(reader[136] != DBNull.Value)
            {
                P031I004 = (System.Nullable<System.Int32>)reader[136];
            }
            if(reader[137] != DBNull.Value)
            {
                P031I005 = (System.Nullable<System.Int32>)reader[137];
            }
            if(reader[138] != DBNull.Value)
            {
                P031I006 = (System.Nullable<System.Int32>)reader[138];
            }
            if(reader[139] != DBNull.Value)
            {
                P031I007 = (System.Nullable<System.Int32>)reader[139];
            }
            if(reader[140] != DBNull.Value)
            {
                P031I008 = (System.Nullable<System.Int32>)reader[140];
            }
            if(reader[141] != DBNull.Value)
            {
                P031I009 = (System.Nullable<System.Int32>)reader[141];
            }
            if(reader[142] != DBNull.Value)
            {
                P031I010 = (System.Nullable<System.Int32>)reader[142];
            }
            if(reader[143] != DBNull.Value)
            {
                P031I011 = (System.Nullable<System.Int32>)reader[143];
            }
            if(reader[144] != DBNull.Value)
            {
                P031I012 = (System.Nullable<System.Int32>)reader[144];
            }
            if(reader[145] != DBNull.Value)
            {
                P031I013 = (System.Nullable<System.Int32>)reader[145];
            }
            if(reader[146] != DBNull.Value)
            {
                P031I014 = (System.Nullable<System.Int32>)reader[146];
            }
            if(reader[147] != DBNull.Value)
            {
                P031I015 = (System.Nullable<System.Int32>)reader[147];
            }
            if(reader[148] != DBNull.Value)
            {
                P031I016 = (System.Nullable<System.Int32>)reader[148];
            }
            if(reader[149] != DBNull.Value)
            {
                P034A001 = (System.Nullable<System.Int32>)reader[149];
            }
            if(reader[150] != DBNull.Value)
            {
                P034A002 = (System.Nullable<System.Int32>)reader[150];
            }
            if(reader[151] != DBNull.Value)
            {
                P034A003 = (System.Nullable<System.Int32>)reader[151];
            }
            if(reader[152] != DBNull.Value)
            {
                P034A004 = (System.Nullable<System.Int32>)reader[152];
            }
            if(reader[153] != DBNull.Value)
            {
                P034A005 = (System.Nullable<System.Int32>)reader[153];
            }
            if(reader[154] != DBNull.Value)
            {
                P034A006 = (System.Nullable<System.Int32>)reader[154];
            }
            if(reader[155] != DBNull.Value)
            {
                P034A007 = (System.Nullable<System.Int32>)reader[155];
            }
            if(reader[156] != DBNull.Value)
            {
                P034A008 = (System.Nullable<System.Int32>)reader[156];
            }
            if(reader[157] != DBNull.Value)
            {
                P034A009 = (System.Nullable<System.Int32>)reader[157];
            }
            if(reader[158] != DBNull.Value)
            {
                P034A010 = (System.Nullable<System.Int32>)reader[158];
            }
            if(reader[159] != DBNull.Value)
            {
                P034A011 = (System.Nullable<System.Int32>)reader[159];
            }
            if(reader[160] != DBNull.Value)
            {
                P034A012 = (System.Nullable<System.Int32>)reader[160];
            }
            if(reader[161] != DBNull.Value)
            {
                P034A013 = (System.Nullable<System.Int32>)reader[161];
            }
            if(reader[162] != DBNull.Value)
            {
                P034A014 = (System.Nullable<System.Int32>)reader[162];
            }
            if(reader[163] != DBNull.Value)
            {
                P034A015 = (System.Nullable<System.Int32>)reader[163];
            }
            if(reader[164] != DBNull.Value)
            {
                P034A016 = (System.Nullable<System.Int32>)reader[164];
            }
            if(reader[165] != DBNull.Value)
            {
                P034A017 = (System.Nullable<System.Int32>)reader[165];
            }
            if(reader[166] != DBNull.Value)
            {
                P034A018 = (System.Nullable<System.Int32>)reader[166];
            }
            if(reader[167] != DBNull.Value)
            {
                P034A019 = (System.Nullable<System.Int32>)reader[167];
            }
            if(reader[168] != DBNull.Value)
            {
                P034A020 = (System.Nullable<System.Int32>)reader[168];
            }
            if(reader[169] != DBNull.Value)
            {
                P034A021 = (System.Nullable<System.Int32>)reader[169];
            }
            if(reader[170] != DBNull.Value)
            {
                P034A022 = (System.Nullable<System.Int32>)reader[170];
            }
            if(reader[171] != DBNull.Value)
            {
                P034B001 = (System.Nullable<System.Int32>)reader[171];
            }
            if(reader[172] != DBNull.Value)
            {
                P034B002 = (System.Nullable<System.Int32>)reader[172];
            }
            if(reader[173] != DBNull.Value)
            {
                P034B003 = (System.Nullable<System.Int32>)reader[173];
            }
            if(reader[174] != DBNull.Value)
            {
                P034B004 = (System.Nullable<System.Int32>)reader[174];
            }
            if(reader[175] != DBNull.Value)
            {
                P034B005 = (System.Nullable<System.Int32>)reader[175];
            }
            if(reader[176] != DBNull.Value)
            {
                P034B006 = (System.Nullable<System.Int32>)reader[176];
            }
            if(reader[177] != DBNull.Value)
            {
                P034B007 = (System.Nullable<System.Int32>)reader[177];
            }
            if(reader[178] != DBNull.Value)
            {
                P034B008 = (System.Nullable<System.Int32>)reader[178];
            }
            if(reader[179] != DBNull.Value)
            {
                P034B009 = (System.Nullable<System.Int32>)reader[179];
            }
            if(reader[180] != DBNull.Value)
            {
                P034B010 = (System.Nullable<System.Int32>)reader[180];
            }
            if(reader[181] != DBNull.Value)
            {
                P034B011 = (System.Nullable<System.Int32>)reader[181];
            }
            if(reader[182] != DBNull.Value)
            {
                P034B012 = (System.Nullable<System.Int32>)reader[182];
            }
            if(reader[183] != DBNull.Value)
            {
                P034B013 = (System.Nullable<System.Int32>)reader[183];
            }
            if(reader[184] != DBNull.Value)
            {
                P034B014 = (System.Nullable<System.Int32>)reader[184];
            }
            if(reader[185] != DBNull.Value)
            {
                P034B015 = (System.Nullable<System.Int32>)reader[185];
            }
            if(reader[186] != DBNull.Value)
            {
                P034B016 = (System.Nullable<System.Int32>)reader[186];
            }
            if(reader[187] != DBNull.Value)
            {
                P034B017 = (System.Nullable<System.Int32>)reader[187];
            }
            if(reader[188] != DBNull.Value)
            {
                P034B018 = (System.Nullable<System.Int32>)reader[188];
            }
            if(reader[189] != DBNull.Value)
            {
                P034B019 = (System.Nullable<System.Int32>)reader[189];
            }
            if(reader[190] != DBNull.Value)
            {
                P034B020 = (System.Nullable<System.Int32>)reader[190];
            }
            if(reader[191] != DBNull.Value)
            {
                P034B021 = (System.Nullable<System.Int32>)reader[191];
            }
            if(reader[192] != DBNull.Value)
            {
                P034B022 = (System.Nullable<System.Int32>)reader[192];
            }
            if(reader[193] != DBNull.Value)
            {
                P034C001 = (System.Nullable<System.Int32>)reader[193];
            }
            if(reader[194] != DBNull.Value)
            {
                P034C002 = (System.Nullable<System.Int32>)reader[194];
            }
            if(reader[195] != DBNull.Value)
            {
                P034C003 = (System.Nullable<System.Int32>)reader[195];
            }
            if(reader[196] != DBNull.Value)
            {
                P034C004 = (System.Nullable<System.Int32>)reader[196];
            }
            if(reader[197] != DBNull.Value)
            {
                P034C005 = (System.Nullable<System.Int32>)reader[197];
            }
            if(reader[198] != DBNull.Value)
            {
                P034C006 = (System.Nullable<System.Int32>)reader[198];
            }
            if(reader[199] != DBNull.Value)
            {
                P034C007 = (System.Nullable<System.Int32>)reader[199];
            }
            if(reader[200] != DBNull.Value)
            {
                P034C008 = (System.Nullable<System.Int32>)reader[200];
            }
            if(reader[201] != DBNull.Value)
            {
                P034C009 = (System.Nullable<System.Int32>)reader[201];
            }
            if(reader[202] != DBNull.Value)
            {
                P034C010 = (System.Nullable<System.Int32>)reader[202];
            }
            if(reader[203] != DBNull.Value)
            {
                P034C011 = (System.Nullable<System.Int32>)reader[203];
            }
            if(reader[204] != DBNull.Value)
            {
                P034C012 = (System.Nullable<System.Int32>)reader[204];
            }
            if(reader[205] != DBNull.Value)
            {
                P034C013 = (System.Nullable<System.Int32>)reader[205];
            }
            if(reader[206] != DBNull.Value)
            {
                P034C014 = (System.Nullable<System.Int32>)reader[206];
            }
            if(reader[207] != DBNull.Value)
            {
                P034C015 = (System.Nullable<System.Int32>)reader[207];
            }
            if(reader[208] != DBNull.Value)
            {
                P034C016 = (System.Nullable<System.Int32>)reader[208];
            }
            if(reader[209] != DBNull.Value)
            {
                P034C017 = (System.Nullable<System.Int32>)reader[209];
            }
            if(reader[210] != DBNull.Value)
            {
                P034C018 = (System.Nullable<System.Int32>)reader[210];
            }
            if(reader[211] != DBNull.Value)
            {
                P034C019 = (System.Nullable<System.Int32>)reader[211];
            }
            if(reader[212] != DBNull.Value)
            {
                P034C020 = (System.Nullable<System.Int32>)reader[212];
            }
            if(reader[213] != DBNull.Value)
            {
                P034C021 = (System.Nullable<System.Int32>)reader[213];
            }
            if(reader[214] != DBNull.Value)
            {
                P034C022 = (System.Nullable<System.Int32>)reader[214];
            }
            if(reader[215] != DBNull.Value)
            {
                P034D001 = (System.Nullable<System.Int32>)reader[215];
            }
            if(reader[216] != DBNull.Value)
            {
                P034D002 = (System.Nullable<System.Int32>)reader[216];
            }
            if(reader[217] != DBNull.Value)
            {
                P034D003 = (System.Nullable<System.Int32>)reader[217];
            }
            if(reader[218] != DBNull.Value)
            {
                P034D004 = (System.Nullable<System.Int32>)reader[218];
            }
            if(reader[219] != DBNull.Value)
            {
                P034D005 = (System.Nullable<System.Int32>)reader[219];
            }
            if(reader[220] != DBNull.Value)
            {
                P034D006 = (System.Nullable<System.Int32>)reader[220];
            }
            if(reader[221] != DBNull.Value)
            {
                P034D007 = (System.Nullable<System.Int32>)reader[221];
            }
            if(reader[222] != DBNull.Value)
            {
                P034D008 = (System.Nullable<System.Int32>)reader[222];
            }
            if(reader[223] != DBNull.Value)
            {
                P034D009 = (System.Nullable<System.Int32>)reader[223];
            }
            if(reader[224] != DBNull.Value)
            {
                P034D010 = (System.Nullable<System.Int32>)reader[224];
            }
            if(reader[225] != DBNull.Value)
            {
                P034D011 = (System.Nullable<System.Int32>)reader[225];
            }
            if(reader[226] != DBNull.Value)
            {
                P034D012 = (System.Nullable<System.Int32>)reader[226];
            }
            if(reader[227] != DBNull.Value)
            {
                P034D013 = (System.Nullable<System.Int32>)reader[227];
            }
            if(reader[228] != DBNull.Value)
            {
                P034D014 = (System.Nullable<System.Int32>)reader[228];
            }
            if(reader[229] != DBNull.Value)
            {
                P034D015 = (System.Nullable<System.Int32>)reader[229];
            }
            if(reader[230] != DBNull.Value)
            {
                P034D016 = (System.Nullable<System.Int32>)reader[230];
            }
            if(reader[231] != DBNull.Value)
            {
                P034D017 = (System.Nullable<System.Int32>)reader[231];
            }
            if(reader[232] != DBNull.Value)
            {
                P034D018 = (System.Nullable<System.Int32>)reader[232];
            }
            if(reader[233] != DBNull.Value)
            {
                P034D019 = (System.Nullable<System.Int32>)reader[233];
            }
            if(reader[234] != DBNull.Value)
            {
                P034D020 = (System.Nullable<System.Int32>)reader[234];
            }
            if(reader[235] != DBNull.Value)
            {
                P034D021 = (System.Nullable<System.Int32>)reader[235];
            }
            if(reader[236] != DBNull.Value)
            {
                P034D022 = (System.Nullable<System.Int32>)reader[236];
            }
            if(reader[237] != DBNull.Value)
            {
                P034E001 = (System.Nullable<System.Int32>)reader[237];
            }
            if(reader[238] != DBNull.Value)
            {
                P034E002 = (System.Nullable<System.Int32>)reader[238];
            }
            if(reader[239] != DBNull.Value)
            {
                P034E003 = (System.Nullable<System.Int32>)reader[239];
            }
            if(reader[240] != DBNull.Value)
            {
                P034E004 = (System.Nullable<System.Int32>)reader[240];
            }
            if(reader[241] != DBNull.Value)
            {
                P034E005 = (System.Nullable<System.Int32>)reader[241];
            }
            if(reader[242] != DBNull.Value)
            {
                P034E006 = (System.Nullable<System.Int32>)reader[242];
            }
            if(reader[243] != DBNull.Value)
            {
                P034E007 = (System.Nullable<System.Int32>)reader[243];
            }
            if(reader[244] != DBNull.Value)
            {
                P034E008 = (System.Nullable<System.Int32>)reader[244];
            }
            if(reader[245] != DBNull.Value)
            {
                P034E009 = (System.Nullable<System.Int32>)reader[245];
            }
            if(reader[246] != DBNull.Value)
            {
                P034E010 = (System.Nullable<System.Int32>)reader[246];
            }
            if(reader[247] != DBNull.Value)
            {
                P034E011 = (System.Nullable<System.Int32>)reader[247];
            }
            if(reader[248] != DBNull.Value)
            {
                P034E012 = (System.Nullable<System.Int32>)reader[248];
            }
            if(reader[249] != DBNull.Value)
            {
                P034E013 = (System.Nullable<System.Int32>)reader[249];
            }
            if(reader[250] != DBNull.Value)
            {
                P034E014 = (System.Nullable<System.Int32>)reader[250];
            }
            if(reader[251] != DBNull.Value)
            {
                P034E015 = (System.Nullable<System.Int32>)reader[251];
            }
            if(reader[252] != DBNull.Value)
            {
                P034E016 = (System.Nullable<System.Int32>)reader[252];
            }
            if(reader[253] != DBNull.Value)
            {
                P034E017 = (System.Nullable<System.Int32>)reader[253];
            }
            if(reader[254] != DBNull.Value)
            {
                P034E018 = (System.Nullable<System.Int32>)reader[254];
            }
            if(reader[255] != DBNull.Value)
            {
                P034E019 = (System.Nullable<System.Int32>)reader[255];
            }
            if(reader[256] != DBNull.Value)
            {
                P034E020 = (System.Nullable<System.Int32>)reader[256];
            }
            if(reader[257] != DBNull.Value)
            {
                P034E021 = (System.Nullable<System.Int32>)reader[257];
            }
            if(reader[258] != DBNull.Value)
            {
                P034E022 = (System.Nullable<System.Int32>)reader[258];
            }
        }
        #endregion Constructors
    }
}