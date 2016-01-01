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

    [Table("SF1_00010")]
    public partial class SF1_00010 : BaseModel
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
        [Column("P029A001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public System.Nullable<System.Int32> P029A001 { get; set; }

        [ReadOnly(false)]
        [Column("P029A002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 6)]
        public System.Nullable<System.Int32> P029A002 { get; set; }

        [ReadOnly(false)]
        [Column("P029A003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 7)]
        public System.Nullable<System.Int32> P029A003 { get; set; }

        [ReadOnly(false)]
        [Column("P029A004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder:", ShortName = "Householder:", Order = 8)]
        public System.Nullable<System.Int32> P029A004 { get; set; }

        [ReadOnly(false)]
        [Column("P029A005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 9)]
        public System.Nullable<System.Int32> P029A005 { get; set; }

        [ReadOnly(false)]
        [Column("P029A006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 10)]
        public System.Nullable<System.Int32> P029A006 { get; set; }

        [ReadOnly(false)]
        [Column("P029A007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spouse", ShortName = "Spouse", Order = 11)]
        public System.Nullable<System.Int32> P029A007 { get; set; }

        [ReadOnly(false)]
        [Column("P029A008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Biological child", ShortName = "Biological child", Order = 12)]
        public System.Nullable<System.Int32> P029A008 { get; set; }

        [ReadOnly(false)]
        [Column("P029A009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Adopted child", ShortName = "Adopted child", Order = 13)]
        public System.Nullable<System.Int32> P029A009 { get; set; }

        [ReadOnly(false)]
        [Column("P029A010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Stepchild", ShortName = "Stepchild", Order = 14)]
        public System.Nullable<System.Int32> P029A010 { get; set; }

        [ReadOnly(false)]
        [Column("P029A011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 15)]
        public System.Nullable<System.Int32> P029A011 { get; set; }

        [ReadOnly(false)]
        [Column("P029A012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 16)]
        public System.Nullable<System.Int32> P029A012 { get; set; }

        [ReadOnly(false)]
        [Column("P029A013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent", ShortName = "Parent", Order = 17)]
        public System.Nullable<System.Int32> P029A013 { get; set; }

        [ReadOnly(false)]
        [Column("P029A014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 18)]
        public System.Nullable<System.Int32> P029A014 { get; set; }

        [ReadOnly(false)]
        [Column("P029A015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 19)]
        public System.Nullable<System.Int32> P029A015 { get; set; }

        [ReadOnly(false)]
        [Column("P029A016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 20)]
        public System.Nullable<System.Int32> P029A016 { get; set; }

        [ReadOnly(false)]
        [Column("P029A017", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 21)]
        public System.Nullable<System.Int32> P029A017 { get; set; }

        [ReadOnly(false)]
        [Column("P029A018", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 22)]
        public System.Nullable<System.Int32> P029A018 { get; set; }

        [ReadOnly(false)]
        [Column("P029A019", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 23)]
        public System.Nullable<System.Int32> P029A019 { get; set; }

        [ReadOnly(false)]
        [Column("P029A020", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 24)]
        public System.Nullable<System.Int32> P029A020 { get; set; }

        [ReadOnly(false)]
        [Column("P029A021", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 25)]
        public System.Nullable<System.Int32> P029A021 { get; set; }

        [ReadOnly(false)]
        [Column("P029A022", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 26)]
        public System.Nullable<System.Int32> P029A022 { get; set; }

        [ReadOnly(false)]
        [Column("P029A023", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 27)]
        public System.Nullable<System.Int32> P029A023 { get; set; }

        [ReadOnly(false)]
        [Column("P029A024", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 28)]
        public System.Nullable<System.Int32> P029A024 { get; set; }

        [ReadOnly(false)]
        [Column("P029A025", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 29)]
        public System.Nullable<System.Int32> P029A025 { get; set; }

        [ReadOnly(false)]
        [Column("P029A026", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 30)]
        public System.Nullable<System.Int32> P029A026 { get; set; }

        [ReadOnly(false)]
        [Column("P029A027", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 31)]
        public System.Nullable<System.Int32> P029A027 { get; set; }

        [ReadOnly(false)]
        [Column("P029A028", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 32)]
        public System.Nullable<System.Int32> P029A028 { get; set; }

        [ReadOnly(false)]
        [Column("P029B001", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 33)]
        public System.Nullable<System.Int32> P029B001 { get; set; }

        [ReadOnly(false)]
        [Column("P029B002", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 34)]
        public System.Nullable<System.Int32> P029B002 { get; set; }

        [ReadOnly(false)]
        [Column("P029B003", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 35)]
        public System.Nullable<System.Int32> P029B003 { get; set; }

        [ReadOnly(false)]
        [Column("P029B004", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder:", ShortName = "Householder:", Order = 36)]
        public System.Nullable<System.Int32> P029B004 { get; set; }

        [ReadOnly(false)]
        [Column("P029B005", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 37)]
        public System.Nullable<System.Int32> P029B005 { get; set; }

        [ReadOnly(false)]
        [Column("P029B006", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 38)]
        public System.Nullable<System.Int32> P029B006 { get; set; }

        [ReadOnly(false)]
        [Column("P029B007", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spouse", ShortName = "Spouse", Order = 39)]
        public System.Nullable<System.Int32> P029B007 { get; set; }

        [ReadOnly(false)]
        [Column("P029B008", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Biological child", ShortName = "Biological child", Order = 40)]
        public System.Nullable<System.Int32> P029B008 { get; set; }

        [ReadOnly(false)]
        [Column("P029B009", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Adopted child", ShortName = "Adopted child", Order = 41)]
        public System.Nullable<System.Int32> P029B009 { get; set; }

        [ReadOnly(false)]
        [Column("P029B010", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Stepchild", ShortName = "Stepchild", Order = 42)]
        public System.Nullable<System.Int32> P029B010 { get; set; }

        [ReadOnly(false)]
        [Column("P029B011", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 43)]
        public System.Nullable<System.Int32> P029B011 { get; set; }

        [ReadOnly(false)]
        [Column("P029B012", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 44)]
        public System.Nullable<System.Int32> P029B012 { get; set; }

        [ReadOnly(false)]
        [Column("P029B013", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent", ShortName = "Parent", Order = 45)]
        public System.Nullable<System.Int32> P029B013 { get; set; }

        [ReadOnly(false)]
        [Column("P029B014", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 46)]
        public System.Nullable<System.Int32> P029B014 { get; set; }

        [ReadOnly(false)]
        [Column("P029B015", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 47)]
        public System.Nullable<System.Int32> P029B015 { get; set; }

        [ReadOnly(false)]
        [Column("P029B016", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 48)]
        public System.Nullable<System.Int32> P029B016 { get; set; }

        [ReadOnly(false)]
        [Column("P029B017", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 49)]
        public System.Nullable<System.Int32> P029B017 { get; set; }

        [ReadOnly(false)]
        [Column("P029B018", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 50)]
        public System.Nullable<System.Int32> P029B018 { get; set; }

        [ReadOnly(false)]
        [Column("P029B019", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 51)]
        public System.Nullable<System.Int32> P029B019 { get; set; }

        [ReadOnly(false)]
        [Column("P029B020", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 52)]
        public System.Nullable<System.Int32> P029B020 { get; set; }

        [ReadOnly(false)]
        [Column("P029B021", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 53)]
        public System.Nullable<System.Int32> P029B021 { get; set; }

        [ReadOnly(false)]
        [Column("P029B022", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 54)]
        public System.Nullable<System.Int32> P029B022 { get; set; }

        [ReadOnly(false)]
        [Column("P029B023", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 55)]
        public System.Nullable<System.Int32> P029B023 { get; set; }

        [ReadOnly(false)]
        [Column("P029B024", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 56)]
        public System.Nullable<System.Int32> P029B024 { get; set; }

        [ReadOnly(false)]
        [Column("P029B025", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 57)]
        public System.Nullable<System.Int32> P029B025 { get; set; }

        [ReadOnly(false)]
        [Column("P029B026", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 58)]
        public System.Nullable<System.Int32> P029B026 { get; set; }

        [ReadOnly(false)]
        [Column("P029B027", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 59)]
        public System.Nullable<System.Int32> P029B027 { get; set; }

        [ReadOnly(false)]
        [Column("P029B028", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 60)]
        public System.Nullable<System.Int32> P029B028 { get; set; }

        [ReadOnly(false)]
        [Column("P029C001", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 61)]
        public System.Nullable<System.Int32> P029C001 { get; set; }

        [ReadOnly(false)]
        [Column("P029C002", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 62)]
        public System.Nullable<System.Int32> P029C002 { get; set; }

        [ReadOnly(false)]
        [Column("P029C003", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 63)]
        public System.Nullable<System.Int32> P029C003 { get; set; }

        [ReadOnly(false)]
        [Column("P029C004", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder:", ShortName = "Householder:", Order = 64)]
        public System.Nullable<System.Int32> P029C004 { get; set; }

        [ReadOnly(false)]
        [Column("P029C005", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 65)]
        public System.Nullable<System.Int32> P029C005 { get; set; }

        [ReadOnly(false)]
        [Column("P029C006", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 66)]
        public System.Nullable<System.Int32> P029C006 { get; set; }

        [ReadOnly(false)]
        [Column("P029C007", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spouse", ShortName = "Spouse", Order = 67)]
        public System.Nullable<System.Int32> P029C007 { get; set; }

        [ReadOnly(false)]
        [Column("P029C008", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Biological child", ShortName = "Biological child", Order = 68)]
        public System.Nullable<System.Int32> P029C008 { get; set; }

        [ReadOnly(false)]
        [Column("P029C009", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Adopted child", ShortName = "Adopted child", Order = 69)]
        public System.Nullable<System.Int32> P029C009 { get; set; }

        [ReadOnly(false)]
        [Column("P029C010", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Stepchild", ShortName = "Stepchild", Order = 70)]
        public System.Nullable<System.Int32> P029C010 { get; set; }

        [ReadOnly(false)]
        [Column("P029C011", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 71)]
        public System.Nullable<System.Int32> P029C011 { get; set; }

        [ReadOnly(false)]
        [Column("P029C012", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 72)]
        public System.Nullable<System.Int32> P029C012 { get; set; }

        [ReadOnly(false)]
        [Column("P029C013", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent", ShortName = "Parent", Order = 73)]
        public System.Nullable<System.Int32> P029C013 { get; set; }

        [ReadOnly(false)]
        [Column("P029C014", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 74)]
        public System.Nullable<System.Int32> P029C014 { get; set; }

        [ReadOnly(false)]
        [Column("P029C015", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 75)]
        public System.Nullable<System.Int32> P029C015 { get; set; }

        [ReadOnly(false)]
        [Column("P029C016", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 76)]
        public System.Nullable<System.Int32> P029C016 { get; set; }

        [ReadOnly(false)]
        [Column("P029C017", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 77)]
        public System.Nullable<System.Int32> P029C017 { get; set; }

        [ReadOnly(false)]
        [Column("P029C018", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 78)]
        public System.Nullable<System.Int32> P029C018 { get; set; }

        [ReadOnly(false)]
        [Column("P029C019", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 79)]
        public System.Nullable<System.Int32> P029C019 { get; set; }

        [ReadOnly(false)]
        [Column("P029C020", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 80)]
        public System.Nullable<System.Int32> P029C020 { get; set; }

        [ReadOnly(false)]
        [Column("P029C021", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 81)]
        public System.Nullable<System.Int32> P029C021 { get; set; }

        [ReadOnly(false)]
        [Column("P029C022", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 82)]
        public System.Nullable<System.Int32> P029C022 { get; set; }

        [ReadOnly(false)]
        [Column("P029C023", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 83)]
        public System.Nullable<System.Int32> P029C023 { get; set; }

        [ReadOnly(false)]
        [Column("P029C024", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 84)]
        public System.Nullable<System.Int32> P029C024 { get; set; }

        [ReadOnly(false)]
        [Column("P029C025", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 85)]
        public System.Nullable<System.Int32> P029C025 { get; set; }

        [ReadOnly(false)]
        [Column("P029C026", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 86)]
        public System.Nullable<System.Int32> P029C026 { get; set; }

        [ReadOnly(false)]
        [Column("P029C027", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 87)]
        public System.Nullable<System.Int32> P029C027 { get; set; }

        [ReadOnly(false)]
        [Column("P029C028", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 88)]
        public System.Nullable<System.Int32> P029C028 { get; set; }

        [ReadOnly(false)]
        [Column("P029D001", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 89)]
        public System.Nullable<System.Int32> P029D001 { get; set; }

        [ReadOnly(false)]
        [Column("P029D002", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 90)]
        public System.Nullable<System.Int32> P029D002 { get; set; }

        [ReadOnly(false)]
        [Column("P029D003", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 91)]
        public System.Nullable<System.Int32> P029D003 { get; set; }

        [ReadOnly(false)]
        [Column("P029D004", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder:", ShortName = "Householder:", Order = 92)]
        public System.Nullable<System.Int32> P029D004 { get; set; }

        [ReadOnly(false)]
        [Column("P029D005", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 93)]
        public System.Nullable<System.Int32> P029D005 { get; set; }

        [ReadOnly(false)]
        [Column("P029D006", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 94)]
        public System.Nullable<System.Int32> P029D006 { get; set; }

        [ReadOnly(false)]
        [Column("P029D007", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spouse", ShortName = "Spouse", Order = 95)]
        public System.Nullable<System.Int32> P029D007 { get; set; }

        [ReadOnly(false)]
        [Column("P029D008", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Biological child", ShortName = "Biological child", Order = 96)]
        public System.Nullable<System.Int32> P029D008 { get; set; }

        [ReadOnly(false)]
        [Column("P029D009", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Adopted child", ShortName = "Adopted child", Order = 97)]
        public System.Nullable<System.Int32> P029D009 { get; set; }

        [ReadOnly(false)]
        [Column("P029D010", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Stepchild", ShortName = "Stepchild", Order = 98)]
        public System.Nullable<System.Int32> P029D010 { get; set; }

        [ReadOnly(false)]
        [Column("P029D011", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 99)]
        public System.Nullable<System.Int32> P029D011 { get; set; }

        [ReadOnly(false)]
        [Column("P029D012", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 100)]
        public System.Nullable<System.Int32> P029D012 { get; set; }

        [ReadOnly(false)]
        [Column("P029D013", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent", ShortName = "Parent", Order = 101)]
        public System.Nullable<System.Int32> P029D013 { get; set; }

        [ReadOnly(false)]
        [Column("P029D014", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 102)]
        public System.Nullable<System.Int32> P029D014 { get; set; }

        [ReadOnly(false)]
        [Column("P029D015", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 103)]
        public System.Nullable<System.Int32> P029D015 { get; set; }

        [ReadOnly(false)]
        [Column("P029D016", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 104)]
        public System.Nullable<System.Int32> P029D016 { get; set; }

        [ReadOnly(false)]
        [Column("P029D017", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 105)]
        public System.Nullable<System.Int32> P029D017 { get; set; }

        [ReadOnly(false)]
        [Column("P029D018", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 106)]
        public System.Nullable<System.Int32> P029D018 { get; set; }

        [ReadOnly(false)]
        [Column("P029D019", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 107)]
        public System.Nullable<System.Int32> P029D019 { get; set; }

        [ReadOnly(false)]
        [Column("P029D020", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 108)]
        public System.Nullable<System.Int32> P029D020 { get; set; }

        [ReadOnly(false)]
        [Column("P029D021", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 109)]
        public System.Nullable<System.Int32> P029D021 { get; set; }

        [ReadOnly(false)]
        [Column("P029D022", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 110)]
        public System.Nullable<System.Int32> P029D022 { get; set; }

        [ReadOnly(false)]
        [Column("P029D023", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 111)]
        public System.Nullable<System.Int32> P029D023 { get; set; }

        [ReadOnly(false)]
        [Column("P029D024", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 112)]
        public System.Nullable<System.Int32> P029D024 { get; set; }

        [ReadOnly(false)]
        [Column("P029D025", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 113)]
        public System.Nullable<System.Int32> P029D025 { get; set; }

        [ReadOnly(false)]
        [Column("P029D026", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 114)]
        public System.Nullable<System.Int32> P029D026 { get; set; }

        [ReadOnly(false)]
        [Column("P029D027", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 115)]
        public System.Nullable<System.Int32> P029D027 { get; set; }

        [ReadOnly(false)]
        [Column("P029D028", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 116)]
        public System.Nullable<System.Int32> P029D028 { get; set; }

        [ReadOnly(false)]
        [Column("P029E001", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 117)]
        public System.Nullable<System.Int32> P029E001 { get; set; }

        [ReadOnly(false)]
        [Column("P029E002", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 118)]
        public System.Nullable<System.Int32> P029E002 { get; set; }

        [ReadOnly(false)]
        [Column("P029E003", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 119)]
        public System.Nullable<System.Int32> P029E003 { get; set; }

        [ReadOnly(false)]
        [Column("P029E004", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder:", ShortName = "Householder:", Order = 120)]
        public System.Nullable<System.Int32> P029E004 { get; set; }

        [ReadOnly(false)]
        [Column("P029E005", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 121)]
        public System.Nullable<System.Int32> P029E005 { get; set; }

        [ReadOnly(false)]
        [Column("P029E006", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 122)]
        public System.Nullable<System.Int32> P029E006 { get; set; }

        [ReadOnly(false)]
        [Column("P029E007", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spouse", ShortName = "Spouse", Order = 123)]
        public System.Nullable<System.Int32> P029E007 { get; set; }

        [ReadOnly(false)]
        [Column("P029E008", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Biological child", ShortName = "Biological child", Order = 124)]
        public System.Nullable<System.Int32> P029E008 { get; set; }

        [ReadOnly(false)]
        [Column("P029E009", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Adopted child", ShortName = "Adopted child", Order = 125)]
        public System.Nullable<System.Int32> P029E009 { get; set; }

        [ReadOnly(false)]
        [Column("P029E010", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Stepchild", ShortName = "Stepchild", Order = 126)]
        public System.Nullable<System.Int32> P029E010 { get; set; }

        [ReadOnly(false)]
        [Column("P029E011", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 127)]
        public System.Nullable<System.Int32> P029E011 { get; set; }

        [ReadOnly(false)]
        [Column("P029E012", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 128)]
        public System.Nullable<System.Int32> P029E012 { get; set; }

        [ReadOnly(false)]
        [Column("P029E013", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent", ShortName = "Parent", Order = 129)]
        public System.Nullable<System.Int32> P029E013 { get; set; }

        [ReadOnly(false)]
        [Column("P029E014", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 130)]
        public System.Nullable<System.Int32> P029E014 { get; set; }

        [ReadOnly(false)]
        [Column("P029E015", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 131)]
        public System.Nullable<System.Int32> P029E015 { get; set; }

        [ReadOnly(false)]
        [Column("P029E016", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 132)]
        public System.Nullable<System.Int32> P029E016 { get; set; }

        [ReadOnly(false)]
        [Column("P029E017", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 133)]
        public System.Nullable<System.Int32> P029E017 { get; set; }

        [ReadOnly(false)]
        [Column("P029E018", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 134)]
        public System.Nullable<System.Int32> P029E018 { get; set; }

        [ReadOnly(false)]
        [Column("P029E019", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 135)]
        public System.Nullable<System.Int32> P029E019 { get; set; }

        [ReadOnly(false)]
        [Column("P029E020", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 136)]
        public System.Nullable<System.Int32> P029E020 { get; set; }

        [ReadOnly(false)]
        [Column("P029E021", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 137)]
        public System.Nullable<System.Int32> P029E021 { get; set; }

        [ReadOnly(false)]
        [Column("P029E022", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 138)]
        public System.Nullable<System.Int32> P029E022 { get; set; }

        [ReadOnly(false)]
        [Column("P029E023", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 139)]
        public System.Nullable<System.Int32> P029E023 { get; set; }

        [ReadOnly(false)]
        [Column("P029E024", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 140)]
        public System.Nullable<System.Int32> P029E024 { get; set; }

        [ReadOnly(false)]
        [Column("P029E025", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 141)]
        public System.Nullable<System.Int32> P029E025 { get; set; }

        [ReadOnly(false)]
        [Column("P029E026", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 142)]
        public System.Nullable<System.Int32> P029E026 { get; set; }

        [ReadOnly(false)]
        [Column("P029E027", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 143)]
        public System.Nullable<System.Int32> P029E027 { get; set; }

        [ReadOnly(false)]
        [Column("P029E028", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 144)]
        public System.Nullable<System.Int32> P029E028 { get; set; }

        [ReadOnly(false)]
        [Column("P029F001", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 145)]
        public System.Nullable<System.Int32> P029F001 { get; set; }

        [ReadOnly(false)]
        [Column("P029F002", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 146)]
        public System.Nullable<System.Int32> P029F002 { get; set; }

        [ReadOnly(false)]
        [Column("P029F003", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 147)]
        public System.Nullable<System.Int32> P029F003 { get; set; }

        [ReadOnly(false)]
        [Column("P029F004", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder:", ShortName = "Householder:", Order = 148)]
        public System.Nullable<System.Int32> P029F004 { get; set; }

        [ReadOnly(false)]
        [Column("P029F005", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 149)]
        public System.Nullable<System.Int32> P029F005 { get; set; }

        [ReadOnly(false)]
        [Column("P029F006", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 150)]
        public System.Nullable<System.Int32> P029F006 { get; set; }

        [ReadOnly(false)]
        [Column("P029F007", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spouse", ShortName = "Spouse", Order = 151)]
        public System.Nullable<System.Int32> P029F007 { get; set; }

        [ReadOnly(false)]
        [Column("P029F008", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Biological child", ShortName = "Biological child", Order = 152)]
        public System.Nullable<System.Int32> P029F008 { get; set; }

        [ReadOnly(false)]
        [Column("P029F009", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Adopted child", ShortName = "Adopted child", Order = 153)]
        public System.Nullable<System.Int32> P029F009 { get; set; }

        [ReadOnly(false)]
        [Column("P029F010", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Stepchild", ShortName = "Stepchild", Order = 154)]
        public System.Nullable<System.Int32> P029F010 { get; set; }

        [ReadOnly(false)]
        [Column("P029F011", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 155)]
        public System.Nullable<System.Int32> P029F011 { get; set; }

        [ReadOnly(false)]
        [Column("P029F012", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 156)]
        public System.Nullable<System.Int32> P029F012 { get; set; }

        [ReadOnly(false)]
        [Column("P029F013", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent", ShortName = "Parent", Order = 157)]
        public System.Nullable<System.Int32> P029F013 { get; set; }

        [ReadOnly(false)]
        [Column("P029F014", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 158)]
        public System.Nullable<System.Int32> P029F014 { get; set; }

        [ReadOnly(false)]
        [Column("P029F015", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 159)]
        public System.Nullable<System.Int32> P029F015 { get; set; }

        [ReadOnly(false)]
        [Column("P029F016", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 160)]
        public System.Nullable<System.Int32> P029F016 { get; set; }

        [ReadOnly(false)]
        [Column("P029F017", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 161)]
        public System.Nullable<System.Int32> P029F017 { get; set; }

        [ReadOnly(false)]
        [Column("P029F018", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 162)]
        public System.Nullable<System.Int32> P029F018 { get; set; }

        [ReadOnly(false)]
        [Column("P029F019", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 163)]
        public System.Nullable<System.Int32> P029F019 { get; set; }

        [ReadOnly(false)]
        [Column("P029F020", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 164)]
        public System.Nullable<System.Int32> P029F020 { get; set; }

        [ReadOnly(false)]
        [Column("P029F021", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 165)]
        public System.Nullable<System.Int32> P029F021 { get; set; }

        [ReadOnly(false)]
        [Column("P029F022", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 166)]
        public System.Nullable<System.Int32> P029F022 { get; set; }

        [ReadOnly(false)]
        [Column("P029F023", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 167)]
        public System.Nullable<System.Int32> P029F023 { get; set; }

        [ReadOnly(false)]
        [Column("P029F024", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 168)]
        public System.Nullable<System.Int32> P029F024 { get; set; }

        [ReadOnly(false)]
        [Column("P029F025", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 169)]
        public System.Nullable<System.Int32> P029F025 { get; set; }

        [ReadOnly(false)]
        [Column("P029F026", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 170)]
        public System.Nullable<System.Int32> P029F026 { get; set; }

        [ReadOnly(false)]
        [Column("P029F027", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 171)]
        public System.Nullable<System.Int32> P029F027 { get; set; }

        [ReadOnly(false)]
        [Column("P029F028", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 172)]
        public System.Nullable<System.Int32> P029F028 { get; set; }

        [ReadOnly(false)]
        [Column("P029G001", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 173)]
        public System.Nullable<System.Int32> P029G001 { get; set; }

        [ReadOnly(false)]
        [Column("P029G002", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 174)]
        public System.Nullable<System.Int32> P029G002 { get; set; }

        [ReadOnly(false)]
        [Column("P029G003", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 175)]
        public System.Nullable<System.Int32> P029G003 { get; set; }

        [ReadOnly(false)]
        [Column("P029G004", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder:", ShortName = "Householder:", Order = 176)]
        public System.Nullable<System.Int32> P029G004 { get; set; }

        [ReadOnly(false)]
        [Column("P029G005", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 177)]
        public System.Nullable<System.Int32> P029G005 { get; set; }

        [ReadOnly(false)]
        [Column("P029G006", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 178)]
        public System.Nullable<System.Int32> P029G006 { get; set; }

        [ReadOnly(false)]
        [Column("P029G007", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spouse", ShortName = "Spouse", Order = 179)]
        public System.Nullable<System.Int32> P029G007 { get; set; }

        [ReadOnly(false)]
        [Column("P029G008", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Biological child", ShortName = "Biological child", Order = 180)]
        public System.Nullable<System.Int32> P029G008 { get; set; }

        [ReadOnly(false)]
        [Column("P029G009", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Adopted child", ShortName = "Adopted child", Order = 181)]
        public System.Nullable<System.Int32> P029G009 { get; set; }

        [ReadOnly(false)]
        [Column("P029G010", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Stepchild", ShortName = "Stepchild", Order = 182)]
        public System.Nullable<System.Int32> P029G010 { get; set; }

        [ReadOnly(false)]
        [Column("P029G011", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 183)]
        public System.Nullable<System.Int32> P029G011 { get; set; }

        [ReadOnly(false)]
        [Column("P029G012", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 184)]
        public System.Nullable<System.Int32> P029G012 { get; set; }

        [ReadOnly(false)]
        [Column("P029G013", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent", ShortName = "Parent", Order = 185)]
        public System.Nullable<System.Int32> P029G013 { get; set; }

        [ReadOnly(false)]
        [Column("P029G014", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 186)]
        public System.Nullable<System.Int32> P029G014 { get; set; }

        [ReadOnly(false)]
        [Column("P029G015", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 187)]
        public System.Nullable<System.Int32> P029G015 { get; set; }

        [ReadOnly(false)]
        [Column("P029G016", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 188)]
        public System.Nullable<System.Int32> P029G016 { get; set; }

        [ReadOnly(false)]
        [Column("P029G017", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 189)]
        public System.Nullable<System.Int32> P029G017 { get; set; }

        [ReadOnly(false)]
        [Column("P029G018", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 190)]
        public System.Nullable<System.Int32> P029G018 { get; set; }

        [ReadOnly(false)]
        [Column("P029G019", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 191)]
        public System.Nullable<System.Int32> P029G019 { get; set; }

        [ReadOnly(false)]
        [Column("P029G020", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 192)]
        public System.Nullable<System.Int32> P029G020 { get; set; }

        [ReadOnly(false)]
        [Column("P029G021", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 193)]
        public System.Nullable<System.Int32> P029G021 { get; set; }

        [ReadOnly(false)]
        [Column("P029G022", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 194)]
        public System.Nullable<System.Int32> P029G022 { get; set; }

        [ReadOnly(false)]
        [Column("P029G023", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 195)]
        public System.Nullable<System.Int32> P029G023 { get; set; }

        [ReadOnly(false)]
        [Column("P029G024", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 196)]
        public System.Nullable<System.Int32> P029G024 { get; set; }

        [ReadOnly(false)]
        [Column("P029G025", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 197)]
        public System.Nullable<System.Int32> P029G025 { get; set; }

        [ReadOnly(false)]
        [Column("P029G026", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 198)]
        public System.Nullable<System.Int32> P029G026 { get; set; }

        [ReadOnly(false)]
        [Column("P029G027", Order = 199)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 199)]
        public System.Nullable<System.Int32> P029G027 { get; set; }

        [ReadOnly(false)]
        [Column("P029G028", Order = 200)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 200)]
        public System.Nullable<System.Int32> P029G028 { get; set; }

        [ReadOnly(false)]
        [Column("P029H001", Order = 201)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 201)]
        public System.Nullable<System.Int32> P029H001 { get; set; }

        [ReadOnly(false)]
        [Column("P029H002", Order = 202)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 202)]
        public System.Nullable<System.Int32> P029H002 { get; set; }

        [ReadOnly(false)]
        [Column("P029H003", Order = 203)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 203)]
        public System.Nullable<System.Int32> P029H003 { get; set; }

        [ReadOnly(false)]
        [Column("P029H004", Order = 204)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder:", ShortName = "Householder:", Order = 204)]
        public System.Nullable<System.Int32> P029H004 { get; set; }

        [ReadOnly(false)]
        [Column("P029H005", Order = 205)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 205)]
        public System.Nullable<System.Int32> P029H005 { get; set; }

        [ReadOnly(false)]
        [Column("P029H006", Order = 206)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 206)]
        public System.Nullable<System.Int32> P029H006 { get; set; }

        [ReadOnly(false)]
        [Column("P029H007", Order = 207)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spouse", ShortName = "Spouse", Order = 207)]
        public System.Nullable<System.Int32> P029H007 { get; set; }

        [ReadOnly(false)]
        [Column("P029H008", Order = 208)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Biological child", ShortName = "Biological child", Order = 208)]
        public System.Nullable<System.Int32> P029H008 { get; set; }

        [ReadOnly(false)]
        [Column("P029H009", Order = 209)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Adopted child", ShortName = "Adopted child", Order = 209)]
        public System.Nullable<System.Int32> P029H009 { get; set; }

        [ReadOnly(false)]
        [Column("P029H010", Order = 210)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Stepchild", ShortName = "Stepchild", Order = 210)]
        public System.Nullable<System.Int32> P029H010 { get; set; }

        [ReadOnly(false)]
        [Column("P029H011", Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 211)]
        public System.Nullable<System.Int32> P029H011 { get; set; }

        [ReadOnly(false)]
        [Column("P029H012", Order = 212)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 212)]
        public System.Nullable<System.Int32> P029H012 { get; set; }

        [ReadOnly(false)]
        [Column("P029H013", Order = 213)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent", ShortName = "Parent", Order = 213)]
        public System.Nullable<System.Int32> P029H013 { get; set; }

        [ReadOnly(false)]
        [Column("P029H014", Order = 214)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 214)]
        public System.Nullable<System.Int32> P029H014 { get; set; }

        [ReadOnly(false)]
        [Column("P029H015", Order = 215)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 215)]
        public System.Nullable<System.Int32> P029H015 { get; set; }

        [ReadOnly(false)]
        [Column("P029H016", Order = 216)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 216)]
        public System.Nullable<System.Int32> P029H016 { get; set; }

        [ReadOnly(false)]
        [Column("P029H017", Order = 217)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 217)]
        public System.Nullable<System.Int32> P029H017 { get; set; }

        [ReadOnly(false)]
        [Column("P029H018", Order = 218)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 218)]
        public System.Nullable<System.Int32> P029H018 { get; set; }

        [ReadOnly(false)]
        [Column("P029H019", Order = 219)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 219)]
        public System.Nullable<System.Int32> P029H019 { get; set; }

        [ReadOnly(false)]
        [Column("P029H020", Order = 220)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 220)]
        public System.Nullable<System.Int32> P029H020 { get; set; }

        [ReadOnly(false)]
        [Column("P029H021", Order = 221)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 221)]
        public System.Nullable<System.Int32> P029H021 { get; set; }

        [ReadOnly(false)]
        [Column("P029H022", Order = 222)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 222)]
        public System.Nullable<System.Int32> P029H022 { get; set; }

        [ReadOnly(false)]
        [Column("P029H023", Order = 223)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 223)]
        public System.Nullable<System.Int32> P029H023 { get; set; }

        [ReadOnly(false)]
        [Column("P029H024", Order = 224)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 224)]
        public System.Nullable<System.Int32> P029H024 { get; set; }

        [ReadOnly(false)]
        [Column("P029H025", Order = 225)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 225)]
        public System.Nullable<System.Int32> P029H025 { get; set; }

        [ReadOnly(false)]
        [Column("P029H026", Order = 226)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 226)]
        public System.Nullable<System.Int32> P029H026 { get; set; }

        [ReadOnly(false)]
        [Column("P029H027", Order = 227)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 227)]
        public System.Nullable<System.Int32> P029H027 { get; set; }

        [ReadOnly(false)]
        [Column("P029H028", Order = 228)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 228)]
        public System.Nullable<System.Int32> P029H028 { get; set; }

        [ReadOnly(false)]
        [Column("P029I001", Order = 229)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 229)]
        public System.Nullable<System.Int32> P029I001 { get; set; }

        [ReadOnly(false)]
        [Column("P029I002", Order = 230)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 230)]
        public System.Nullable<System.Int32> P029I002 { get; set; }

        [ReadOnly(false)]
        [Column("P029I003", Order = 231)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 231)]
        public System.Nullable<System.Int32> P029I003 { get; set; }

        [ReadOnly(false)]
        [Column("P029I004", Order = 232)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder:", ShortName = "Householder:", Order = 232)]
        public System.Nullable<System.Int32> P029I004 { get; set; }

        [ReadOnly(false)]
        [Column("P029I005", Order = 233)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 233)]
        public System.Nullable<System.Int32> P029I005 { get; set; }

        [ReadOnly(false)]
        [Column("P029I006", Order = 234)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 234)]
        public System.Nullable<System.Int32> P029I006 { get; set; }

        [ReadOnly(false)]
        [Column("P029I007", Order = 235)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spouse", ShortName = "Spouse", Order = 235)]
        public System.Nullable<System.Int32> P029I007 { get; set; }

        [ReadOnly(false)]
        [Column("P029I008", Order = 236)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Biological child", ShortName = "Biological child", Order = 236)]
        public System.Nullable<System.Int32> P029I008 { get; set; }

        [ReadOnly(false)]
        [Column("P029I009", Order = 237)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Adopted child", ShortName = "Adopted child", Order = 237)]
        public System.Nullable<System.Int32> P029I009 { get; set; }

        [ReadOnly(false)]
        [Column("P029I010", Order = 238)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Stepchild", ShortName = "Stepchild", Order = 238)]
        public System.Nullable<System.Int32> P029I010 { get; set; }

        [ReadOnly(false)]
        [Column("P029I011", Order = 239)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 239)]
        public System.Nullable<System.Int32> P029I011 { get; set; }

        [ReadOnly(false)]
        [Column("P029I012", Order = 240)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Brother or sister", ShortName = "Brother or sister", Order = 240)]
        public System.Nullable<System.Int32> P029I012 { get; set; }

        [ReadOnly(false)]
        [Column("P029I013", Order = 241)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent", ShortName = "Parent", Order = 241)]
        public System.Nullable<System.Int32> P029I013 { get; set; }

        [ReadOnly(false)]
        [Column("P029I014", Order = 242)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 242)]
        public System.Nullable<System.Int32> P029I014 { get; set; }

        [ReadOnly(false)]
        [Column("P029I015", Order = 243)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Son-in-law or daughter-in-law", ShortName = "Son-in-law or daughter-in-law", Order = 243)]
        public System.Nullable<System.Int32> P029I015 { get; set; }

        [ReadOnly(false)]
        [Column("P029I016", Order = 244)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 244)]
        public System.Nullable<System.Int32> P029I016 { get; set; }

        [ReadOnly(false)]
        [Column("P029I017", Order = 245)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 245)]
        public System.Nullable<System.Int32> P029I017 { get; set; }

        [ReadOnly(false)]
        [Column("P029I018", Order = 246)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 246)]
        public System.Nullable<System.Int32> P029I018 { get; set; }

        [ReadOnly(false)]
        [Column("P029I019", Order = 247)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 247)]
        public System.Nullable<System.Int32> P029I019 { get; set; }

        [ReadOnly(false)]
        [Column("P029I020", Order = 248)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 248)]
        public System.Nullable<System.Int32> P029I020 { get; set; }

        [ReadOnly(false)]
        [Column("P029I021", Order = 249)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 249)]
        public System.Nullable<System.Int32> P029I021 { get; set; }

        [ReadOnly(false)]
        [Column("P029I022", Order = 250)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 250)]
        public System.Nullable<System.Int32> P029I022 { get; set; }

        [ReadOnly(false)]
        [Column("P029I023", Order = 251)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 251)]
        public System.Nullable<System.Int32> P029I023 { get; set; }

        [ReadOnly(false)]
        [Column("P029I024", Order = 252)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 252)]
        public System.Nullable<System.Int32> P029I024 { get; set; }

        [ReadOnly(false)]
        [Column("P029I025", Order = 253)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 253)]
        public System.Nullable<System.Int32> P029I025 { get; set; }

        [ReadOnly(false)]
        [Column("P029I026", Order = 254)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 254)]
        public System.Nullable<System.Int32> P029I026 { get; set; }

        [ReadOnly(false)]
        [Column("P029I027", Order = 255)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 255)]
        public System.Nullable<System.Int32> P029I027 { get; set; }

        [ReadOnly(false)]
        [Column("P029I028", Order = 256)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 256)]
        public System.Nullable<System.Int32> P029I028 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1_00010(string csvLine) : base(csvLine) {}

        public SF1_00010(string[] values) : base(values) {}

        public SF1_00010(OleDbDataReader reader, CensusFileType fileType)
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
                P029A001 = (System.Nullable<System.Int32>)reader[5];
            }
            if(reader[6] != DBNull.Value)
            {
                P029A002 = (System.Nullable<System.Int32>)reader[6];
            }
            if(reader[7] != DBNull.Value)
            {
                P029A003 = (System.Nullable<System.Int32>)reader[7];
            }
            if(reader[8] != DBNull.Value)
            {
                P029A004 = (System.Nullable<System.Int32>)reader[8];
            }
            if(reader[9] != DBNull.Value)
            {
                P029A005 = (System.Nullable<System.Int32>)reader[9];
            }
            if(reader[10] != DBNull.Value)
            {
                P029A006 = (System.Nullable<System.Int32>)reader[10];
            }
            if(reader[11] != DBNull.Value)
            {
                P029A007 = (System.Nullable<System.Int32>)reader[11];
            }
            if(reader[12] != DBNull.Value)
            {
                P029A008 = (System.Nullable<System.Int32>)reader[12];
            }
            if(reader[13] != DBNull.Value)
            {
                P029A009 = (System.Nullable<System.Int32>)reader[13];
            }
            if(reader[14] != DBNull.Value)
            {
                P029A010 = (System.Nullable<System.Int32>)reader[14];
            }
            if(reader[15] != DBNull.Value)
            {
                P029A011 = (System.Nullable<System.Int32>)reader[15];
            }
            if(reader[16] != DBNull.Value)
            {
                P029A012 = (System.Nullable<System.Int32>)reader[16];
            }
            if(reader[17] != DBNull.Value)
            {
                P029A013 = (System.Nullable<System.Int32>)reader[17];
            }
            if(reader[18] != DBNull.Value)
            {
                P029A014 = (System.Nullable<System.Int32>)reader[18];
            }
            if(reader[19] != DBNull.Value)
            {
                P029A015 = (System.Nullable<System.Int32>)reader[19];
            }
            if(reader[20] != DBNull.Value)
            {
                P029A016 = (System.Nullable<System.Int32>)reader[20];
            }
            if(reader[21] != DBNull.Value)
            {
                P029A017 = (System.Nullable<System.Int32>)reader[21];
            }
            if(reader[22] != DBNull.Value)
            {
                P029A018 = (System.Nullable<System.Int32>)reader[22];
            }
            if(reader[23] != DBNull.Value)
            {
                P029A019 = (System.Nullable<System.Int32>)reader[23];
            }
            if(reader[24] != DBNull.Value)
            {
                P029A020 = (System.Nullable<System.Int32>)reader[24];
            }
            if(reader[25] != DBNull.Value)
            {
                P029A021 = (System.Nullable<System.Int32>)reader[25];
            }
            if(reader[26] != DBNull.Value)
            {
                P029A022 = (System.Nullable<System.Int32>)reader[26];
            }
            if(reader[27] != DBNull.Value)
            {
                P029A023 = (System.Nullable<System.Int32>)reader[27];
            }
            if(reader[28] != DBNull.Value)
            {
                P029A024 = (System.Nullable<System.Int32>)reader[28];
            }
            if(reader[29] != DBNull.Value)
            {
                P029A025 = (System.Nullable<System.Int32>)reader[29];
            }
            if(reader[30] != DBNull.Value)
            {
                P029A026 = (System.Nullable<System.Int32>)reader[30];
            }
            if(reader[31] != DBNull.Value)
            {
                P029A027 = (System.Nullable<System.Int32>)reader[31];
            }
            if(reader[32] != DBNull.Value)
            {
                P029A028 = (System.Nullable<System.Int32>)reader[32];
            }
            if(reader[33] != DBNull.Value)
            {
                P029B001 = (System.Nullable<System.Int32>)reader[33];
            }
            if(reader[34] != DBNull.Value)
            {
                P029B002 = (System.Nullable<System.Int32>)reader[34];
            }
            if(reader[35] != DBNull.Value)
            {
                P029B003 = (System.Nullable<System.Int32>)reader[35];
            }
            if(reader[36] != DBNull.Value)
            {
                P029B004 = (System.Nullable<System.Int32>)reader[36];
            }
            if(reader[37] != DBNull.Value)
            {
                P029B005 = (System.Nullable<System.Int32>)reader[37];
            }
            if(reader[38] != DBNull.Value)
            {
                P029B006 = (System.Nullable<System.Int32>)reader[38];
            }
            if(reader[39] != DBNull.Value)
            {
                P029B007 = (System.Nullable<System.Int32>)reader[39];
            }
            if(reader[40] != DBNull.Value)
            {
                P029B008 = (System.Nullable<System.Int32>)reader[40];
            }
            if(reader[41] != DBNull.Value)
            {
                P029B009 = (System.Nullable<System.Int32>)reader[41];
            }
            if(reader[42] != DBNull.Value)
            {
                P029B010 = (System.Nullable<System.Int32>)reader[42];
            }
            if(reader[43] != DBNull.Value)
            {
                P029B011 = (System.Nullable<System.Int32>)reader[43];
            }
            if(reader[44] != DBNull.Value)
            {
                P029B012 = (System.Nullable<System.Int32>)reader[44];
            }
            if(reader[45] != DBNull.Value)
            {
                P029B013 = (System.Nullable<System.Int32>)reader[45];
            }
            if(reader[46] != DBNull.Value)
            {
                P029B014 = (System.Nullable<System.Int32>)reader[46];
            }
            if(reader[47] != DBNull.Value)
            {
                P029B015 = (System.Nullable<System.Int32>)reader[47];
            }
            if(reader[48] != DBNull.Value)
            {
                P029B016 = (System.Nullable<System.Int32>)reader[48];
            }
            if(reader[49] != DBNull.Value)
            {
                P029B017 = (System.Nullable<System.Int32>)reader[49];
            }
            if(reader[50] != DBNull.Value)
            {
                P029B018 = (System.Nullable<System.Int32>)reader[50];
            }
            if(reader[51] != DBNull.Value)
            {
                P029B019 = (System.Nullable<System.Int32>)reader[51];
            }
            if(reader[52] != DBNull.Value)
            {
                P029B020 = (System.Nullable<System.Int32>)reader[52];
            }
            if(reader[53] != DBNull.Value)
            {
                P029B021 = (System.Nullable<System.Int32>)reader[53];
            }
            if(reader[54] != DBNull.Value)
            {
                P029B022 = (System.Nullable<System.Int32>)reader[54];
            }
            if(reader[55] != DBNull.Value)
            {
                P029B023 = (System.Nullable<System.Int32>)reader[55];
            }
            if(reader[56] != DBNull.Value)
            {
                P029B024 = (System.Nullable<System.Int32>)reader[56];
            }
            if(reader[57] != DBNull.Value)
            {
                P029B025 = (System.Nullable<System.Int32>)reader[57];
            }
            if(reader[58] != DBNull.Value)
            {
                P029B026 = (System.Nullable<System.Int32>)reader[58];
            }
            if(reader[59] != DBNull.Value)
            {
                P029B027 = (System.Nullable<System.Int32>)reader[59];
            }
            if(reader[60] != DBNull.Value)
            {
                P029B028 = (System.Nullable<System.Int32>)reader[60];
            }
            if(reader[61] != DBNull.Value)
            {
                P029C001 = (System.Nullable<System.Int32>)reader[61];
            }
            if(reader[62] != DBNull.Value)
            {
                P029C002 = (System.Nullable<System.Int32>)reader[62];
            }
            if(reader[63] != DBNull.Value)
            {
                P029C003 = (System.Nullable<System.Int32>)reader[63];
            }
            if(reader[64] != DBNull.Value)
            {
                P029C004 = (System.Nullable<System.Int32>)reader[64];
            }
            if(reader[65] != DBNull.Value)
            {
                P029C005 = (System.Nullable<System.Int32>)reader[65];
            }
            if(reader[66] != DBNull.Value)
            {
                P029C006 = (System.Nullable<System.Int32>)reader[66];
            }
            if(reader[67] != DBNull.Value)
            {
                P029C007 = (System.Nullable<System.Int32>)reader[67];
            }
            if(reader[68] != DBNull.Value)
            {
                P029C008 = (System.Nullable<System.Int32>)reader[68];
            }
            if(reader[69] != DBNull.Value)
            {
                P029C009 = (System.Nullable<System.Int32>)reader[69];
            }
            if(reader[70] != DBNull.Value)
            {
                P029C010 = (System.Nullable<System.Int32>)reader[70];
            }
            if(reader[71] != DBNull.Value)
            {
                P029C011 = (System.Nullable<System.Int32>)reader[71];
            }
            if(reader[72] != DBNull.Value)
            {
                P029C012 = (System.Nullable<System.Int32>)reader[72];
            }
            if(reader[73] != DBNull.Value)
            {
                P029C013 = (System.Nullable<System.Int32>)reader[73];
            }
            if(reader[74] != DBNull.Value)
            {
                P029C014 = (System.Nullable<System.Int32>)reader[74];
            }
            if(reader[75] != DBNull.Value)
            {
                P029C015 = (System.Nullable<System.Int32>)reader[75];
            }
            if(reader[76] != DBNull.Value)
            {
                P029C016 = (System.Nullable<System.Int32>)reader[76];
            }
            if(reader[77] != DBNull.Value)
            {
                P029C017 = (System.Nullable<System.Int32>)reader[77];
            }
            if(reader[78] != DBNull.Value)
            {
                P029C018 = (System.Nullable<System.Int32>)reader[78];
            }
            if(reader[79] != DBNull.Value)
            {
                P029C019 = (System.Nullable<System.Int32>)reader[79];
            }
            if(reader[80] != DBNull.Value)
            {
                P029C020 = (System.Nullable<System.Int32>)reader[80];
            }
            if(reader[81] != DBNull.Value)
            {
                P029C021 = (System.Nullable<System.Int32>)reader[81];
            }
            if(reader[82] != DBNull.Value)
            {
                P029C022 = (System.Nullable<System.Int32>)reader[82];
            }
            if(reader[83] != DBNull.Value)
            {
                P029C023 = (System.Nullable<System.Int32>)reader[83];
            }
            if(reader[84] != DBNull.Value)
            {
                P029C024 = (System.Nullable<System.Int32>)reader[84];
            }
            if(reader[85] != DBNull.Value)
            {
                P029C025 = (System.Nullable<System.Int32>)reader[85];
            }
            if(reader[86] != DBNull.Value)
            {
                P029C026 = (System.Nullable<System.Int32>)reader[86];
            }
            if(reader[87] != DBNull.Value)
            {
                P029C027 = (System.Nullable<System.Int32>)reader[87];
            }
            if(reader[88] != DBNull.Value)
            {
                P029C028 = (System.Nullable<System.Int32>)reader[88];
            }
            if(reader[89] != DBNull.Value)
            {
                P029D001 = (System.Nullable<System.Int32>)reader[89];
            }
            if(reader[90] != DBNull.Value)
            {
                P029D002 = (System.Nullable<System.Int32>)reader[90];
            }
            if(reader[91] != DBNull.Value)
            {
                P029D003 = (System.Nullable<System.Int32>)reader[91];
            }
            if(reader[92] != DBNull.Value)
            {
                P029D004 = (System.Nullable<System.Int32>)reader[92];
            }
            if(reader[93] != DBNull.Value)
            {
                P029D005 = (System.Nullable<System.Int32>)reader[93];
            }
            if(reader[94] != DBNull.Value)
            {
                P029D006 = (System.Nullable<System.Int32>)reader[94];
            }
            if(reader[95] != DBNull.Value)
            {
                P029D007 = (System.Nullable<System.Int32>)reader[95];
            }
            if(reader[96] != DBNull.Value)
            {
                P029D008 = (System.Nullable<System.Int32>)reader[96];
            }
            if(reader[97] != DBNull.Value)
            {
                P029D009 = (System.Nullable<System.Int32>)reader[97];
            }
            if(reader[98] != DBNull.Value)
            {
                P029D010 = (System.Nullable<System.Int32>)reader[98];
            }
            if(reader[99] != DBNull.Value)
            {
                P029D011 = (System.Nullable<System.Int32>)reader[99];
            }
            if(reader[100] != DBNull.Value)
            {
                P029D012 = (System.Nullable<System.Int32>)reader[100];
            }
            if(reader[101] != DBNull.Value)
            {
                P029D013 = (System.Nullable<System.Int32>)reader[101];
            }
            if(reader[102] != DBNull.Value)
            {
                P029D014 = (System.Nullable<System.Int32>)reader[102];
            }
            if(reader[103] != DBNull.Value)
            {
                P029D015 = (System.Nullable<System.Int32>)reader[103];
            }
            if(reader[104] != DBNull.Value)
            {
                P029D016 = (System.Nullable<System.Int32>)reader[104];
            }
            if(reader[105] != DBNull.Value)
            {
                P029D017 = (System.Nullable<System.Int32>)reader[105];
            }
            if(reader[106] != DBNull.Value)
            {
                P029D018 = (System.Nullable<System.Int32>)reader[106];
            }
            if(reader[107] != DBNull.Value)
            {
                P029D019 = (System.Nullable<System.Int32>)reader[107];
            }
            if(reader[108] != DBNull.Value)
            {
                P029D020 = (System.Nullable<System.Int32>)reader[108];
            }
            if(reader[109] != DBNull.Value)
            {
                P029D021 = (System.Nullable<System.Int32>)reader[109];
            }
            if(reader[110] != DBNull.Value)
            {
                P029D022 = (System.Nullable<System.Int32>)reader[110];
            }
            if(reader[111] != DBNull.Value)
            {
                P029D023 = (System.Nullable<System.Int32>)reader[111];
            }
            if(reader[112] != DBNull.Value)
            {
                P029D024 = (System.Nullable<System.Int32>)reader[112];
            }
            if(reader[113] != DBNull.Value)
            {
                P029D025 = (System.Nullable<System.Int32>)reader[113];
            }
            if(reader[114] != DBNull.Value)
            {
                P029D026 = (System.Nullable<System.Int32>)reader[114];
            }
            if(reader[115] != DBNull.Value)
            {
                P029D027 = (System.Nullable<System.Int32>)reader[115];
            }
            if(reader[116] != DBNull.Value)
            {
                P029D028 = (System.Nullable<System.Int32>)reader[116];
            }
            if(reader[117] != DBNull.Value)
            {
                P029E001 = (System.Nullable<System.Int32>)reader[117];
            }
            if(reader[118] != DBNull.Value)
            {
                P029E002 = (System.Nullable<System.Int32>)reader[118];
            }
            if(reader[119] != DBNull.Value)
            {
                P029E003 = (System.Nullable<System.Int32>)reader[119];
            }
            if(reader[120] != DBNull.Value)
            {
                P029E004 = (System.Nullable<System.Int32>)reader[120];
            }
            if(reader[121] != DBNull.Value)
            {
                P029E005 = (System.Nullable<System.Int32>)reader[121];
            }
            if(reader[122] != DBNull.Value)
            {
                P029E006 = (System.Nullable<System.Int32>)reader[122];
            }
            if(reader[123] != DBNull.Value)
            {
                P029E007 = (System.Nullable<System.Int32>)reader[123];
            }
            if(reader[124] != DBNull.Value)
            {
                P029E008 = (System.Nullable<System.Int32>)reader[124];
            }
            if(reader[125] != DBNull.Value)
            {
                P029E009 = (System.Nullable<System.Int32>)reader[125];
            }
            if(reader[126] != DBNull.Value)
            {
                P029E010 = (System.Nullable<System.Int32>)reader[126];
            }
            if(reader[127] != DBNull.Value)
            {
                P029E011 = (System.Nullable<System.Int32>)reader[127];
            }
            if(reader[128] != DBNull.Value)
            {
                P029E012 = (System.Nullable<System.Int32>)reader[128];
            }
            if(reader[129] != DBNull.Value)
            {
                P029E013 = (System.Nullable<System.Int32>)reader[129];
            }
            if(reader[130] != DBNull.Value)
            {
                P029E014 = (System.Nullable<System.Int32>)reader[130];
            }
            if(reader[131] != DBNull.Value)
            {
                P029E015 = (System.Nullable<System.Int32>)reader[131];
            }
            if(reader[132] != DBNull.Value)
            {
                P029E016 = (System.Nullable<System.Int32>)reader[132];
            }
            if(reader[133] != DBNull.Value)
            {
                P029E017 = (System.Nullable<System.Int32>)reader[133];
            }
            if(reader[134] != DBNull.Value)
            {
                P029E018 = (System.Nullable<System.Int32>)reader[134];
            }
            if(reader[135] != DBNull.Value)
            {
                P029E019 = (System.Nullable<System.Int32>)reader[135];
            }
            if(reader[136] != DBNull.Value)
            {
                P029E020 = (System.Nullable<System.Int32>)reader[136];
            }
            if(reader[137] != DBNull.Value)
            {
                P029E021 = (System.Nullable<System.Int32>)reader[137];
            }
            if(reader[138] != DBNull.Value)
            {
                P029E022 = (System.Nullable<System.Int32>)reader[138];
            }
            if(reader[139] != DBNull.Value)
            {
                P029E023 = (System.Nullable<System.Int32>)reader[139];
            }
            if(reader[140] != DBNull.Value)
            {
                P029E024 = (System.Nullable<System.Int32>)reader[140];
            }
            if(reader[141] != DBNull.Value)
            {
                P029E025 = (System.Nullable<System.Int32>)reader[141];
            }
            if(reader[142] != DBNull.Value)
            {
                P029E026 = (System.Nullable<System.Int32>)reader[142];
            }
            if(reader[143] != DBNull.Value)
            {
                P029E027 = (System.Nullable<System.Int32>)reader[143];
            }
            if(reader[144] != DBNull.Value)
            {
                P029E028 = (System.Nullable<System.Int32>)reader[144];
            }
            if(reader[145] != DBNull.Value)
            {
                P029F001 = (System.Nullable<System.Int32>)reader[145];
            }
            if(reader[146] != DBNull.Value)
            {
                P029F002 = (System.Nullable<System.Int32>)reader[146];
            }
            if(reader[147] != DBNull.Value)
            {
                P029F003 = (System.Nullable<System.Int32>)reader[147];
            }
            if(reader[148] != DBNull.Value)
            {
                P029F004 = (System.Nullable<System.Int32>)reader[148];
            }
            if(reader[149] != DBNull.Value)
            {
                P029F005 = (System.Nullable<System.Int32>)reader[149];
            }
            if(reader[150] != DBNull.Value)
            {
                P029F006 = (System.Nullable<System.Int32>)reader[150];
            }
            if(reader[151] != DBNull.Value)
            {
                P029F007 = (System.Nullable<System.Int32>)reader[151];
            }
            if(reader[152] != DBNull.Value)
            {
                P029F008 = (System.Nullable<System.Int32>)reader[152];
            }
            if(reader[153] != DBNull.Value)
            {
                P029F009 = (System.Nullable<System.Int32>)reader[153];
            }
            if(reader[154] != DBNull.Value)
            {
                P029F010 = (System.Nullable<System.Int32>)reader[154];
            }
            if(reader[155] != DBNull.Value)
            {
                P029F011 = (System.Nullable<System.Int32>)reader[155];
            }
            if(reader[156] != DBNull.Value)
            {
                P029F012 = (System.Nullable<System.Int32>)reader[156];
            }
            if(reader[157] != DBNull.Value)
            {
                P029F013 = (System.Nullable<System.Int32>)reader[157];
            }
            if(reader[158] != DBNull.Value)
            {
                P029F014 = (System.Nullable<System.Int32>)reader[158];
            }
            if(reader[159] != DBNull.Value)
            {
                P029F015 = (System.Nullable<System.Int32>)reader[159];
            }
            if(reader[160] != DBNull.Value)
            {
                P029F016 = (System.Nullable<System.Int32>)reader[160];
            }
            if(reader[161] != DBNull.Value)
            {
                P029F017 = (System.Nullable<System.Int32>)reader[161];
            }
            if(reader[162] != DBNull.Value)
            {
                P029F018 = (System.Nullable<System.Int32>)reader[162];
            }
            if(reader[163] != DBNull.Value)
            {
                P029F019 = (System.Nullable<System.Int32>)reader[163];
            }
            if(reader[164] != DBNull.Value)
            {
                P029F020 = (System.Nullable<System.Int32>)reader[164];
            }
            if(reader[165] != DBNull.Value)
            {
                P029F021 = (System.Nullable<System.Int32>)reader[165];
            }
            if(reader[166] != DBNull.Value)
            {
                P029F022 = (System.Nullable<System.Int32>)reader[166];
            }
            if(reader[167] != DBNull.Value)
            {
                P029F023 = (System.Nullable<System.Int32>)reader[167];
            }
            if(reader[168] != DBNull.Value)
            {
                P029F024 = (System.Nullable<System.Int32>)reader[168];
            }
            if(reader[169] != DBNull.Value)
            {
                P029F025 = (System.Nullable<System.Int32>)reader[169];
            }
            if(reader[170] != DBNull.Value)
            {
                P029F026 = (System.Nullable<System.Int32>)reader[170];
            }
            if(reader[171] != DBNull.Value)
            {
                P029F027 = (System.Nullable<System.Int32>)reader[171];
            }
            if(reader[172] != DBNull.Value)
            {
                P029F028 = (System.Nullable<System.Int32>)reader[172];
            }
            if(reader[173] != DBNull.Value)
            {
                P029G001 = (System.Nullable<System.Int32>)reader[173];
            }
            if(reader[174] != DBNull.Value)
            {
                P029G002 = (System.Nullable<System.Int32>)reader[174];
            }
            if(reader[175] != DBNull.Value)
            {
                P029G003 = (System.Nullable<System.Int32>)reader[175];
            }
            if(reader[176] != DBNull.Value)
            {
                P029G004 = (System.Nullable<System.Int32>)reader[176];
            }
            if(reader[177] != DBNull.Value)
            {
                P029G005 = (System.Nullable<System.Int32>)reader[177];
            }
            if(reader[178] != DBNull.Value)
            {
                P029G006 = (System.Nullable<System.Int32>)reader[178];
            }
            if(reader[179] != DBNull.Value)
            {
                P029G007 = (System.Nullable<System.Int32>)reader[179];
            }
            if(reader[180] != DBNull.Value)
            {
                P029G008 = (System.Nullable<System.Int32>)reader[180];
            }
            if(reader[181] != DBNull.Value)
            {
                P029G009 = (System.Nullable<System.Int32>)reader[181];
            }
            if(reader[182] != DBNull.Value)
            {
                P029G010 = (System.Nullable<System.Int32>)reader[182];
            }
            if(reader[183] != DBNull.Value)
            {
                P029G011 = (System.Nullable<System.Int32>)reader[183];
            }
            if(reader[184] != DBNull.Value)
            {
                P029G012 = (System.Nullable<System.Int32>)reader[184];
            }
            if(reader[185] != DBNull.Value)
            {
                P029G013 = (System.Nullable<System.Int32>)reader[185];
            }
            if(reader[186] != DBNull.Value)
            {
                P029G014 = (System.Nullable<System.Int32>)reader[186];
            }
            if(reader[187] != DBNull.Value)
            {
                P029G015 = (System.Nullable<System.Int32>)reader[187];
            }
            if(reader[188] != DBNull.Value)
            {
                P029G016 = (System.Nullable<System.Int32>)reader[188];
            }
            if(reader[189] != DBNull.Value)
            {
                P029G017 = (System.Nullable<System.Int32>)reader[189];
            }
            if(reader[190] != DBNull.Value)
            {
                P029G018 = (System.Nullable<System.Int32>)reader[190];
            }
            if(reader[191] != DBNull.Value)
            {
                P029G019 = (System.Nullable<System.Int32>)reader[191];
            }
            if(reader[192] != DBNull.Value)
            {
                P029G020 = (System.Nullable<System.Int32>)reader[192];
            }
            if(reader[193] != DBNull.Value)
            {
                P029G021 = (System.Nullable<System.Int32>)reader[193];
            }
            if(reader[194] != DBNull.Value)
            {
                P029G022 = (System.Nullable<System.Int32>)reader[194];
            }
            if(reader[195] != DBNull.Value)
            {
                P029G023 = (System.Nullable<System.Int32>)reader[195];
            }
            if(reader[196] != DBNull.Value)
            {
                P029G024 = (System.Nullable<System.Int32>)reader[196];
            }
            if(reader[197] != DBNull.Value)
            {
                P029G025 = (System.Nullable<System.Int32>)reader[197];
            }
            if(reader[198] != DBNull.Value)
            {
                P029G026 = (System.Nullable<System.Int32>)reader[198];
            }
            if(reader[199] != DBNull.Value)
            {
                P029G027 = (System.Nullable<System.Int32>)reader[199];
            }
            if(reader[200] != DBNull.Value)
            {
                P029G028 = (System.Nullable<System.Int32>)reader[200];
            }
            if(reader[201] != DBNull.Value)
            {
                P029H001 = (System.Nullable<System.Int32>)reader[201];
            }
            if(reader[202] != DBNull.Value)
            {
                P029H002 = (System.Nullable<System.Int32>)reader[202];
            }
            if(reader[203] != DBNull.Value)
            {
                P029H003 = (System.Nullable<System.Int32>)reader[203];
            }
            if(reader[204] != DBNull.Value)
            {
                P029H004 = (System.Nullable<System.Int32>)reader[204];
            }
            if(reader[205] != DBNull.Value)
            {
                P029H005 = (System.Nullable<System.Int32>)reader[205];
            }
            if(reader[206] != DBNull.Value)
            {
                P029H006 = (System.Nullable<System.Int32>)reader[206];
            }
            if(reader[207] != DBNull.Value)
            {
                P029H007 = (System.Nullable<System.Int32>)reader[207];
            }
            if(reader[208] != DBNull.Value)
            {
                P029H008 = (System.Nullable<System.Int32>)reader[208];
            }
            if(reader[209] != DBNull.Value)
            {
                P029H009 = (System.Nullable<System.Int32>)reader[209];
            }
            if(reader[210] != DBNull.Value)
            {
                P029H010 = (System.Nullable<System.Int32>)reader[210];
            }
            if(reader[211] != DBNull.Value)
            {
                P029H011 = (System.Nullable<System.Int32>)reader[211];
            }
            if(reader[212] != DBNull.Value)
            {
                P029H012 = (System.Nullable<System.Int32>)reader[212];
            }
            if(reader[213] != DBNull.Value)
            {
                P029H013 = (System.Nullable<System.Int32>)reader[213];
            }
            if(reader[214] != DBNull.Value)
            {
                P029H014 = (System.Nullable<System.Int32>)reader[214];
            }
            if(reader[215] != DBNull.Value)
            {
                P029H015 = (System.Nullable<System.Int32>)reader[215];
            }
            if(reader[216] != DBNull.Value)
            {
                P029H016 = (System.Nullable<System.Int32>)reader[216];
            }
            if(reader[217] != DBNull.Value)
            {
                P029H017 = (System.Nullable<System.Int32>)reader[217];
            }
            if(reader[218] != DBNull.Value)
            {
                P029H018 = (System.Nullable<System.Int32>)reader[218];
            }
            if(reader[219] != DBNull.Value)
            {
                P029H019 = (System.Nullable<System.Int32>)reader[219];
            }
            if(reader[220] != DBNull.Value)
            {
                P029H020 = (System.Nullable<System.Int32>)reader[220];
            }
            if(reader[221] != DBNull.Value)
            {
                P029H021 = (System.Nullable<System.Int32>)reader[221];
            }
            if(reader[222] != DBNull.Value)
            {
                P029H022 = (System.Nullable<System.Int32>)reader[222];
            }
            if(reader[223] != DBNull.Value)
            {
                P029H023 = (System.Nullable<System.Int32>)reader[223];
            }
            if(reader[224] != DBNull.Value)
            {
                P029H024 = (System.Nullable<System.Int32>)reader[224];
            }
            if(reader[225] != DBNull.Value)
            {
                P029H025 = (System.Nullable<System.Int32>)reader[225];
            }
            if(reader[226] != DBNull.Value)
            {
                P029H026 = (System.Nullable<System.Int32>)reader[226];
            }
            if(reader[227] != DBNull.Value)
            {
                P029H027 = (System.Nullable<System.Int32>)reader[227];
            }
            if(reader[228] != DBNull.Value)
            {
                P029H028 = (System.Nullable<System.Int32>)reader[228];
            }
            if(reader[229] != DBNull.Value)
            {
                P029I001 = (System.Nullable<System.Int32>)reader[229];
            }
            if(reader[230] != DBNull.Value)
            {
                P029I002 = (System.Nullable<System.Int32>)reader[230];
            }
            if(reader[231] != DBNull.Value)
            {
                P029I003 = (System.Nullable<System.Int32>)reader[231];
            }
            if(reader[232] != DBNull.Value)
            {
                P029I004 = (System.Nullable<System.Int32>)reader[232];
            }
            if(reader[233] != DBNull.Value)
            {
                P029I005 = (System.Nullable<System.Int32>)reader[233];
            }
            if(reader[234] != DBNull.Value)
            {
                P029I006 = (System.Nullable<System.Int32>)reader[234];
            }
            if(reader[235] != DBNull.Value)
            {
                P029I007 = (System.Nullable<System.Int32>)reader[235];
            }
            if(reader[236] != DBNull.Value)
            {
                P029I008 = (System.Nullable<System.Int32>)reader[236];
            }
            if(reader[237] != DBNull.Value)
            {
                P029I009 = (System.Nullable<System.Int32>)reader[237];
            }
            if(reader[238] != DBNull.Value)
            {
                P029I010 = (System.Nullable<System.Int32>)reader[238];
            }
            if(reader[239] != DBNull.Value)
            {
                P029I011 = (System.Nullable<System.Int32>)reader[239];
            }
            if(reader[240] != DBNull.Value)
            {
                P029I012 = (System.Nullable<System.Int32>)reader[240];
            }
            if(reader[241] != DBNull.Value)
            {
                P029I013 = (System.Nullable<System.Int32>)reader[241];
            }
            if(reader[242] != DBNull.Value)
            {
                P029I014 = (System.Nullable<System.Int32>)reader[242];
            }
            if(reader[243] != DBNull.Value)
            {
                P029I015 = (System.Nullable<System.Int32>)reader[243];
            }
            if(reader[244] != DBNull.Value)
            {
                P029I016 = (System.Nullable<System.Int32>)reader[244];
            }
            if(reader[245] != DBNull.Value)
            {
                P029I017 = (System.Nullable<System.Int32>)reader[245];
            }
            if(reader[246] != DBNull.Value)
            {
                P029I018 = (System.Nullable<System.Int32>)reader[246];
            }
            if(reader[247] != DBNull.Value)
            {
                P029I019 = (System.Nullable<System.Int32>)reader[247];
            }
            if(reader[248] != DBNull.Value)
            {
                P029I020 = (System.Nullable<System.Int32>)reader[248];
            }
            if(reader[249] != DBNull.Value)
            {
                P029I021 = (System.Nullable<System.Int32>)reader[249];
            }
            if(reader[250] != DBNull.Value)
            {
                P029I022 = (System.Nullable<System.Int32>)reader[250];
            }
            if(reader[251] != DBNull.Value)
            {
                P029I023 = (System.Nullable<System.Int32>)reader[251];
            }
            if(reader[252] != DBNull.Value)
            {
                P029I024 = (System.Nullable<System.Int32>)reader[252];
            }
            if(reader[253] != DBNull.Value)
            {
                P029I025 = (System.Nullable<System.Int32>)reader[253];
            }
            if(reader[254] != DBNull.Value)
            {
                P029I026 = (System.Nullable<System.Int32>)reader[254];
            }
            if(reader[255] != DBNull.Value)
            {
                P029I027 = (System.Nullable<System.Int32>)reader[255];
            }
            if(reader[256] != DBNull.Value)
            {
                P029I028 = (System.Nullable<System.Int32>)reader[256];
            }
        }
        #endregion Constructors
    }
}