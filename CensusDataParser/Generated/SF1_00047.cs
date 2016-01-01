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

    [Table("SF1_00047")]
    public partial class SF1_00047 : BaseModel
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
        [Column("HCT0010001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public System.Nullable<System.Int32> HCT0010001 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 6)]
        public System.Nullable<System.Int32> HCT0010002 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not Hispanic or Latino householder:", ShortName = "Not Hispanic or Latino householder:", Order = 7)]
        public System.Nullable<System.Int32> HCT0010003 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 8)]
        public System.Nullable<System.Int32> HCT0010004 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 9)]
        public System.Nullable<System.Int32> HCT0010005 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 10)]
        public System.Nullable<System.Int32> HCT0010006 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 11)]
        public System.Nullable<System.Int32> HCT0010007 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 12)]
        public System.Nullable<System.Int32> HCT0010008 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 13)]
        public System.Nullable<System.Int32> HCT0010009 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 14)]
        public System.Nullable<System.Int32> HCT0010010 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hispanic or Latino householder:", ShortName = "Hispanic or Latino householder:", Order = 15)]
        public System.Nullable<System.Int32> HCT0010011 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 16)]
        public System.Nullable<System.Int32> HCT0010012 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 17)]
        public System.Nullable<System.Int32> HCT0010013 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 18)]
        public System.Nullable<System.Int32> HCT0010014 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 19)]
        public System.Nullable<System.Int32> HCT0010015 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 20)]
        public System.Nullable<System.Int32> HCT0010016 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010017", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 21)]
        public System.Nullable<System.Int32> HCT0010017 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010018", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 22)]
        public System.Nullable<System.Int32> HCT0010018 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010019", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter occupied:", ShortName = "Renter occupied:", Order = 23)]
        public System.Nullable<System.Int32> HCT0010019 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010020", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not Hispanic or Latino householder:", ShortName = "Not Hispanic or Latino householder:", Order = 24)]
        public System.Nullable<System.Int32> HCT0010020 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010021", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 25)]
        public System.Nullable<System.Int32> HCT0010021 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010022", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 26)]
        public System.Nullable<System.Int32> HCT0010022 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010023", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 27)]
        public System.Nullable<System.Int32> HCT0010023 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010024", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 28)]
        public System.Nullable<System.Int32> HCT0010024 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010025", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 29)]
        public System.Nullable<System.Int32> HCT0010025 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010026", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 30)]
        public System.Nullable<System.Int32> HCT0010026 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010027", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 31)]
        public System.Nullable<System.Int32> HCT0010027 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010028", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hispanic or Latino householder:", ShortName = "Hispanic or Latino householder:", Order = 32)]
        public System.Nullable<System.Int32> HCT0010028 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010029", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 33)]
        public System.Nullable<System.Int32> HCT0010029 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010030", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 34)]
        public System.Nullable<System.Int32> HCT0010030 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010031", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 35)]
        public System.Nullable<System.Int32> HCT0010031 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010032", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Asian alone", ShortName = "Householder who is Asian alone", Order = 36)]
        public System.Nullable<System.Int32> HCT0010032 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010033", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Native Hawaiian and Other Pacific Islander alone", ShortName = "Householder who is Native Hawaiian and Other Pacific Islander alone", Order = 37)]
        public System.Nullable<System.Int32> HCT0010033 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010034", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Some Other Race alone", ShortName = "Householder who is Some Other Race alone", Order = 38)]
        public System.Nullable<System.Int32> HCT0010034 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0010035", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder who is Two or More Races", ShortName = "Householder who is Two or More Races", Order = 39)]
        public System.Nullable<System.Int32> HCT0010035 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020001", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 40)]
        public System.Nullable<System.Int32> HCT0020001 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020002", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 41)]
        public System.Nullable<System.Int32> HCT0020002 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020003", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 42)]
        public System.Nullable<System.Int32> HCT0020003 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020004", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 43)]
        public System.Nullable<System.Int32> HCT0020004 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020005", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 44)]
        public System.Nullable<System.Int32> HCT0020005 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020006", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 45)]
        public System.Nullable<System.Int32> HCT0020006 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020007", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 46)]
        public System.Nullable<System.Int32> HCT0020007 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020008", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter-occupied:", ShortName = "Renter-occupied:", Order = 47)]
        public System.Nullable<System.Int32> HCT0020008 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020009", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years:", ShortName = "With own children under 18 years:", Order = 48)]
        public System.Nullable<System.Int32> HCT0020009 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020010", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 49)]
        public System.Nullable<System.Int32> HCT0020010 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020011", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 50)]
        public System.Nullable<System.Int32> HCT0020011 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020012", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 51)]
        public System.Nullable<System.Int32> HCT0020012 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0020013", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 52)]
        public System.Nullable<System.Int32> HCT0020013 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030001", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 53)]
        public System.Nullable<System.Int32> HCT0030001 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030002", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 54)]
        public System.Nullable<System.Int32> HCT0030002 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030003", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 55)]
        public System.Nullable<System.Int32> HCT0030003 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030004", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 56)]
        public System.Nullable<System.Int32> HCT0030004 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030005", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 57)]
        public System.Nullable<System.Int32> HCT0030005 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030006", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 58)]
        public System.Nullable<System.Int32> HCT0030006 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030007", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 59)]
        public System.Nullable<System.Int32> HCT0030007 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030008", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter-occupied:", ShortName = "Renter-occupied:", Order = 60)]
        public System.Nullable<System.Int32> HCT0030008 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030009", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 61)]
        public System.Nullable<System.Int32> HCT0030009 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030010", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 62)]
        public System.Nullable<System.Int32> HCT0030010 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030011", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 63)]
        public System.Nullable<System.Int32> HCT0030011 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030012", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 64)]
        public System.Nullable<System.Int32> HCT0030012 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0030013", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 65)]
        public System.Nullable<System.Int32> HCT0030013 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040001", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 66)]
        public System.Nullable<System.Int32> HCT0040001 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040002", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Owner-occupied:", ShortName = "Owner-occupied:", Order = 67)]
        public System.Nullable<System.Int32> HCT0040002 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040003", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With children under 18 years:", ShortName = "With children under 18 years:", Order = 68)]
        public System.Nullable<System.Int32> HCT0040003 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040004", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 69)]
        public System.Nullable<System.Int32> HCT0040004 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040005", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 70)]
        public System.Nullable<System.Int32> HCT0040005 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040006", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 71)]
        public System.Nullable<System.Int32> HCT0040006 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040007", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No children under 18 years", ShortName = "No children under 18 years", Order = 72)]
        public System.Nullable<System.Int32> HCT0040007 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040008", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Renter-occupied:", ShortName = "Renter-occupied:", Order = 73)]
        public System.Nullable<System.Int32> HCT0040008 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040009", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With children under 18 years:", ShortName = "With children under 18 years:", Order = 74)]
        public System.Nullable<System.Int32> HCT0040009 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040010", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 75)]
        public System.Nullable<System.Int32> HCT0040010 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040011", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 76)]
        public System.Nullable<System.Int32> HCT0040011 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040012", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 77)]
        public System.Nullable<System.Int32> HCT0040012 { get; set; }

        [ReadOnly(false)]
        [Column("HCT0040013", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No children under 18 years", ShortName = "No children under 18 years", Order = 78)]
        public System.Nullable<System.Int32> HCT0040013 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1_00047(string csvLine) : base(csvLine) {}

        public SF1_00047(string[] values) : base(values) {}

        public SF1_00047(OleDbDataReader reader, CensusFileType fileType)
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
                HCT0010001 = (System.Nullable<System.Int32>)reader[5];
            }
            if(reader[6] != DBNull.Value)
            {
                HCT0010002 = (System.Nullable<System.Int32>)reader[6];
            }
            if(reader[7] != DBNull.Value)
            {
                HCT0010003 = (System.Nullable<System.Int32>)reader[7];
            }
            if(reader[8] != DBNull.Value)
            {
                HCT0010004 = (System.Nullable<System.Int32>)reader[8];
            }
            if(reader[9] != DBNull.Value)
            {
                HCT0010005 = (System.Nullable<System.Int32>)reader[9];
            }
            if(reader[10] != DBNull.Value)
            {
                HCT0010006 = (System.Nullable<System.Int32>)reader[10];
            }
            if(reader[11] != DBNull.Value)
            {
                HCT0010007 = (System.Nullable<System.Int32>)reader[11];
            }
            if(reader[12] != DBNull.Value)
            {
                HCT0010008 = (System.Nullable<System.Int32>)reader[12];
            }
            if(reader[13] != DBNull.Value)
            {
                HCT0010009 = (System.Nullable<System.Int32>)reader[13];
            }
            if(reader[14] != DBNull.Value)
            {
                HCT0010010 = (System.Nullable<System.Int32>)reader[14];
            }
            if(reader[15] != DBNull.Value)
            {
                HCT0010011 = (System.Nullable<System.Int32>)reader[15];
            }
            if(reader[16] != DBNull.Value)
            {
                HCT0010012 = (System.Nullable<System.Int32>)reader[16];
            }
            if(reader[17] != DBNull.Value)
            {
                HCT0010013 = (System.Nullable<System.Int32>)reader[17];
            }
            if(reader[18] != DBNull.Value)
            {
                HCT0010014 = (System.Nullable<System.Int32>)reader[18];
            }
            if(reader[19] != DBNull.Value)
            {
                HCT0010015 = (System.Nullable<System.Int32>)reader[19];
            }
            if(reader[20] != DBNull.Value)
            {
                HCT0010016 = (System.Nullable<System.Int32>)reader[20];
            }
            if(reader[21] != DBNull.Value)
            {
                HCT0010017 = (System.Nullable<System.Int32>)reader[21];
            }
            if(reader[22] != DBNull.Value)
            {
                HCT0010018 = (System.Nullable<System.Int32>)reader[22];
            }
            if(reader[23] != DBNull.Value)
            {
                HCT0010019 = (System.Nullable<System.Int32>)reader[23];
            }
            if(reader[24] != DBNull.Value)
            {
                HCT0010020 = (System.Nullable<System.Int32>)reader[24];
            }
            if(reader[25] != DBNull.Value)
            {
                HCT0010021 = (System.Nullable<System.Int32>)reader[25];
            }
            if(reader[26] != DBNull.Value)
            {
                HCT0010022 = (System.Nullable<System.Int32>)reader[26];
            }
            if(reader[27] != DBNull.Value)
            {
                HCT0010023 = (System.Nullable<System.Int32>)reader[27];
            }
            if(reader[28] != DBNull.Value)
            {
                HCT0010024 = (System.Nullable<System.Int32>)reader[28];
            }
            if(reader[29] != DBNull.Value)
            {
                HCT0010025 = (System.Nullable<System.Int32>)reader[29];
            }
            if(reader[30] != DBNull.Value)
            {
                HCT0010026 = (System.Nullable<System.Int32>)reader[30];
            }
            if(reader[31] != DBNull.Value)
            {
                HCT0010027 = (System.Nullable<System.Int32>)reader[31];
            }
            if(reader[32] != DBNull.Value)
            {
                HCT0010028 = (System.Nullable<System.Int32>)reader[32];
            }
            if(reader[33] != DBNull.Value)
            {
                HCT0010029 = (System.Nullable<System.Int32>)reader[33];
            }
            if(reader[34] != DBNull.Value)
            {
                HCT0010030 = (System.Nullable<System.Int32>)reader[34];
            }
            if(reader[35] != DBNull.Value)
            {
                HCT0010031 = (System.Nullable<System.Int32>)reader[35];
            }
            if(reader[36] != DBNull.Value)
            {
                HCT0010032 = (System.Nullable<System.Int32>)reader[36];
            }
            if(reader[37] != DBNull.Value)
            {
                HCT0010033 = (System.Nullable<System.Int32>)reader[37];
            }
            if(reader[38] != DBNull.Value)
            {
                HCT0010034 = (System.Nullable<System.Int32>)reader[38];
            }
            if(reader[39] != DBNull.Value)
            {
                HCT0010035 = (System.Nullable<System.Int32>)reader[39];
            }
            if(reader[40] != DBNull.Value)
            {
                HCT0020001 = (System.Nullable<System.Int32>)reader[40];
            }
            if(reader[41] != DBNull.Value)
            {
                HCT0020002 = (System.Nullable<System.Int32>)reader[41];
            }
            if(reader[42] != DBNull.Value)
            {
                HCT0020003 = (System.Nullable<System.Int32>)reader[42];
            }
            if(reader[43] != DBNull.Value)
            {
                HCT0020004 = (System.Nullable<System.Int32>)reader[43];
            }
            if(reader[44] != DBNull.Value)
            {
                HCT0020005 = (System.Nullable<System.Int32>)reader[44];
            }
            if(reader[45] != DBNull.Value)
            {
                HCT0020006 = (System.Nullable<System.Int32>)reader[45];
            }
            if(reader[46] != DBNull.Value)
            {
                HCT0020007 = (System.Nullable<System.Int32>)reader[46];
            }
            if(reader[47] != DBNull.Value)
            {
                HCT0020008 = (System.Nullable<System.Int32>)reader[47];
            }
            if(reader[48] != DBNull.Value)
            {
                HCT0020009 = (System.Nullable<System.Int32>)reader[48];
            }
            if(reader[49] != DBNull.Value)
            {
                HCT0020010 = (System.Nullable<System.Int32>)reader[49];
            }
            if(reader[50] != DBNull.Value)
            {
                HCT0020011 = (System.Nullable<System.Int32>)reader[50];
            }
            if(reader[51] != DBNull.Value)
            {
                HCT0020012 = (System.Nullable<System.Int32>)reader[51];
            }
            if(reader[52] != DBNull.Value)
            {
                HCT0020013 = (System.Nullable<System.Int32>)reader[52];
            }
            if(reader[53] != DBNull.Value)
            {
                HCT0030001 = (System.Nullable<System.Int32>)reader[53];
            }
            if(reader[54] != DBNull.Value)
            {
                HCT0030002 = (System.Nullable<System.Int32>)reader[54];
            }
            if(reader[55] != DBNull.Value)
            {
                HCT0030003 = (System.Nullable<System.Int32>)reader[55];
            }
            if(reader[56] != DBNull.Value)
            {
                HCT0030004 = (System.Nullable<System.Int32>)reader[56];
            }
            if(reader[57] != DBNull.Value)
            {
                HCT0030005 = (System.Nullable<System.Int32>)reader[57];
            }
            if(reader[58] != DBNull.Value)
            {
                HCT0030006 = (System.Nullable<System.Int32>)reader[58];
            }
            if(reader[59] != DBNull.Value)
            {
                HCT0030007 = (System.Nullable<System.Int32>)reader[59];
            }
            if(reader[60] != DBNull.Value)
            {
                HCT0030008 = (System.Nullable<System.Int32>)reader[60];
            }
            if(reader[61] != DBNull.Value)
            {
                HCT0030009 = (System.Nullable<System.Int32>)reader[61];
            }
            if(reader[62] != DBNull.Value)
            {
                HCT0030010 = (System.Nullable<System.Int32>)reader[62];
            }
            if(reader[63] != DBNull.Value)
            {
                HCT0030011 = (System.Nullable<System.Int32>)reader[63];
            }
            if(reader[64] != DBNull.Value)
            {
                HCT0030012 = (System.Nullable<System.Int32>)reader[64];
            }
            if(reader[65] != DBNull.Value)
            {
                HCT0030013 = (System.Nullable<System.Int32>)reader[65];
            }
            if(reader[66] != DBNull.Value)
            {
                HCT0040001 = (System.Nullable<System.Int32>)reader[66];
            }
            if(reader[67] != DBNull.Value)
            {
                HCT0040002 = (System.Nullable<System.Int32>)reader[67];
            }
            if(reader[68] != DBNull.Value)
            {
                HCT0040003 = (System.Nullable<System.Int32>)reader[68];
            }
            if(reader[69] != DBNull.Value)
            {
                HCT0040004 = (System.Nullable<System.Int32>)reader[69];
            }
            if(reader[70] != DBNull.Value)
            {
                HCT0040005 = (System.Nullable<System.Int32>)reader[70];
            }
            if(reader[71] != DBNull.Value)
            {
                HCT0040006 = (System.Nullable<System.Int32>)reader[71];
            }
            if(reader[72] != DBNull.Value)
            {
                HCT0040007 = (System.Nullable<System.Int32>)reader[72];
            }
            if(reader[73] != DBNull.Value)
            {
                HCT0040008 = (System.Nullable<System.Int32>)reader[73];
            }
            if(reader[74] != DBNull.Value)
            {
                HCT0040009 = (System.Nullable<System.Int32>)reader[74];
            }
            if(reader[75] != DBNull.Value)
            {
                HCT0040010 = (System.Nullable<System.Int32>)reader[75];
            }
            if(reader[76] != DBNull.Value)
            {
                HCT0040011 = (System.Nullable<System.Int32>)reader[76];
            }
            if(reader[77] != DBNull.Value)
            {
                HCT0040012 = (System.Nullable<System.Int32>)reader[77];
            }
            if(reader[78] != DBNull.Value)
            {
                HCT0040013 = (System.Nullable<System.Int32>)reader[78];
            }
        }
        #endregion Constructors
    }
}