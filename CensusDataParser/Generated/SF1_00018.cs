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

    [Table("SF1_00018")]
    public partial class SF1_00018 : BaseModel
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
        [Column("PCT0130001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public System.Nullable<System.Int32> PCT0130001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 6)]
        public System.Nullable<System.Int32> PCT0130002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 7)]
        public System.Nullable<System.Int32> PCT0130003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 8)]
        public System.Nullable<System.Int32> PCT0130004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 9)]
        public System.Nullable<System.Int32> PCT0130005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 10)]
        public System.Nullable<System.Int32> PCT0130006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 11)]
        public System.Nullable<System.Int32> PCT0130007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 12)]
        public System.Nullable<System.Int32> PCT0130008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 13)]
        public System.Nullable<System.Int32> PCT0130009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 14)]
        public System.Nullable<System.Int32> PCT0130010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 15)]
        public System.Nullable<System.Int32> PCT0130011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 16)]
        public System.Nullable<System.Int32> PCT0130012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 17)]
        public System.Nullable<System.Int32> PCT0130013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 18)]
        public System.Nullable<System.Int32> PCT0130014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 19)]
        public System.Nullable<System.Int32> PCT0130015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 20)]
        public System.Nullable<System.Int32> PCT0130016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130017", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 21)]
        public System.Nullable<System.Int32> PCT0130017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130018", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 22)]
        public System.Nullable<System.Int32> PCT0130018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130019", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 23)]
        public System.Nullable<System.Int32> PCT0130019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130020", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 24)]
        public System.Nullable<System.Int32> PCT0130020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130021", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 25)]
        public System.Nullable<System.Int32> PCT0130021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130022", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 26)]
        public System.Nullable<System.Int32> PCT0130022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130023", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 27)]
        public System.Nullable<System.Int32> PCT0130023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130024", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 28)]
        public System.Nullable<System.Int32> PCT0130024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130025", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 29)]
        public System.Nullable<System.Int32> PCT0130025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130026", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 30)]
        public System.Nullable<System.Int32> PCT0130026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130027", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 31)]
        public System.Nullable<System.Int32> PCT0130027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130028", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 32)]
        public System.Nullable<System.Int32> PCT0130028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130029", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 33)]
        public System.Nullable<System.Int32> PCT0130029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130030", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 34)]
        public System.Nullable<System.Int32> PCT0130030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130031", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 35)]
        public System.Nullable<System.Int32> PCT0130031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130032", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 36)]
        public System.Nullable<System.Int32> PCT0130032 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130033", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 37)]
        public System.Nullable<System.Int32> PCT0130033 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130034", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 38)]
        public System.Nullable<System.Int32> PCT0130034 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130035", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 39)]
        public System.Nullable<System.Int32> PCT0130035 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130036", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 40)]
        public System.Nullable<System.Int32> PCT0130036 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130037", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 41)]
        public System.Nullable<System.Int32> PCT0130037 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130038", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 42)]
        public System.Nullable<System.Int32> PCT0130038 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130039", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 43)]
        public System.Nullable<System.Int32> PCT0130039 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130040", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 44)]
        public System.Nullable<System.Int32> PCT0130040 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130041", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 45)]
        public System.Nullable<System.Int32> PCT0130041 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130042", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 46)]
        public System.Nullable<System.Int32> PCT0130042 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130043", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 47)]
        public System.Nullable<System.Int32> PCT0130043 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130044", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 48)]
        public System.Nullable<System.Int32> PCT0130044 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130045", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 49)]
        public System.Nullable<System.Int32> PCT0130045 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130046", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 50)]
        public System.Nullable<System.Int32> PCT0130046 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130047", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 51)]
        public System.Nullable<System.Int32> PCT0130047 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130048", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 52)]
        public System.Nullable<System.Int32> PCT0130048 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130049", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 53)]
        public System.Nullable<System.Int32> PCT0130049 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140001", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 54)]
        public System.Nullable<System.Int32> PCT0140001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140002", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Household has three or more generations", ShortName = "Household has three or more generations", Order = 55)]
        public System.Nullable<System.Int32> PCT0140002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140003", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Household does not have three or more generations", ShortName = "Household does not have three or more generations", Order = 56)]
        public System.Nullable<System.Int32> PCT0140003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150001", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 57)]
        public System.Nullable<System.Int32> PCT0150001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150002", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife households:", ShortName = "Husband-wife households:", Order = 58)]
        public System.Nullable<System.Int32> PCT0150002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150003", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 59)]
        public System.Nullable<System.Int32> PCT0150003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150004", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 60)]
        public System.Nullable<System.Int32> PCT0150004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150005", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 61)]
        public System.Nullable<System.Int32> PCT0150005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150006", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 62)]
        public System.Nullable<System.Int32> PCT0150006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150007", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 63)]
        public System.Nullable<System.Int32> PCT0150007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150008", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 64)]
        public System.Nullable<System.Int32> PCT0150008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150009", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 65)]
        public System.Nullable<System.Int32> PCT0150009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150010", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 66)]
        public System.Nullable<System.Int32> PCT0150010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150011", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 67)]
        public System.Nullable<System.Int32> PCT0150011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150012", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 68)]
        public System.Nullable<System.Int32> PCT0150012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150013", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried-partner households:", ShortName = "Unmarried-partner households:", Order = 69)]
        public System.Nullable<System.Int32> PCT0150013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150014", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder and male partner:", ShortName = "Male householder and male partner:", Order = 70)]
        public System.Nullable<System.Int32> PCT0150014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150015", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 71)]
        public System.Nullable<System.Int32> PCT0150015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150016", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 72)]
        public System.Nullable<System.Int32> PCT0150016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150017", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 73)]
        public System.Nullable<System.Int32> PCT0150017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150018", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 74)]
        public System.Nullable<System.Int32> PCT0150018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150019", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder and female partner:", ShortName = "Male householder and female partner:", Order = 75)]
        public System.Nullable<System.Int32> PCT0150019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150020", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 76)]
        public System.Nullable<System.Int32> PCT0150020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150021", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 77)]
        public System.Nullable<System.Int32> PCT0150021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150022", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 78)]
        public System.Nullable<System.Int32> PCT0150022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150023", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 79)]
        public System.Nullable<System.Int32> PCT0150023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150024", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder and female partner:", ShortName = "Female householder and female partner:", Order = 80)]
        public System.Nullable<System.Int32> PCT0150024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150025", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 81)]
        public System.Nullable<System.Int32> PCT0150025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150026", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 82)]
        public System.Nullable<System.Int32> PCT0150026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150027", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 83)]
        public System.Nullable<System.Int32> PCT0150027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150028", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 84)]
        public System.Nullable<System.Int32> PCT0150028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150029", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder and male partner:", ShortName = "Female householder and male partner:", Order = 85)]
        public System.Nullable<System.Int32> PCT0150029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150030", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 86)]
        public System.Nullable<System.Int32> PCT0150030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150031", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 87)]
        public System.Nullable<System.Int32> PCT0150031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150032", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 88)]
        public System.Nullable<System.Int32> PCT0150032 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150033", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 89)]
        public System.Nullable<System.Int32> PCT0150033 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150034", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "All other households", ShortName = "All other households", Order = 90)]
        public System.Nullable<System.Int32> PCT0150034 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160001", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 91)]
        public System.Nullable<System.Int32> PCT0160001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160002", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 92)]
        public System.Nullable<System.Int32> PCT0160002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160003", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 93)]
        public System.Nullable<System.Int32> PCT0160003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160004", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With no children under 18 years", ShortName = "With no children under 18 years", Order = 94)]
        public System.Nullable<System.Int32> PCT0160004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160005", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With one child under 18 years", ShortName = "With one child under 18 years", Order = 95)]
        public System.Nullable<System.Int32> PCT0160005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160006", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With two children under 18 years", ShortName = "With two children under 18 years", Order = 96)]
        public System.Nullable<System.Int32> PCT0160006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160007", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With three children under 18 years", ShortName = "With three children under 18 years", Order = 97)]
        public System.Nullable<System.Int32> PCT0160007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160008", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With four or more children under 18 years", ShortName = "With four or more children under 18 years", Order = 98)]
        public System.Nullable<System.Int32> PCT0160008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160009", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 99)]
        public System.Nullable<System.Int32> PCT0160009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160010", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With no children under 18 years", ShortName = "With no children under 18 years", Order = 100)]
        public System.Nullable<System.Int32> PCT0160010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160011", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With one child under 18 years", ShortName = "With one child under 18 years", Order = 101)]
        public System.Nullable<System.Int32> PCT0160011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160012", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With two children under 18 years", ShortName = "With two children under 18 years", Order = 102)]
        public System.Nullable<System.Int32> PCT0160012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160013", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With three children under 18 years", ShortName = "With three children under 18 years", Order = 103)]
        public System.Nullable<System.Int32> PCT0160013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160014", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With four or more children under 18 years", ShortName = "With four or more children under 18 years", Order = 104)]
        public System.Nullable<System.Int32> PCT0160014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160015", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 105)]
        public System.Nullable<System.Int32> PCT0160015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160016", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With no children under 18 years", ShortName = "With no children under 18 years", Order = 106)]
        public System.Nullable<System.Int32> PCT0160016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160017", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With one child under 18 years", ShortName = "With one child under 18 years", Order = 107)]
        public System.Nullable<System.Int32> PCT0160017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160018", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With two children under 18 years", ShortName = "With two children under 18 years", Order = 108)]
        public System.Nullable<System.Int32> PCT0160018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160019", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With three children under 18 years", ShortName = "With three children under 18 years", Order = 109)]
        public System.Nullable<System.Int32> PCT0160019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160020", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With four or more children under 18 years", ShortName = "With four or more children under 18 years", Order = 110)]
        public System.Nullable<System.Int32> PCT0160020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160021", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 111)]
        public System.Nullable<System.Int32> PCT0160021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160022", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With no children under 18 years", ShortName = "With no children under 18 years", Order = 112)]
        public System.Nullable<System.Int32> PCT0160022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160023", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With one child under 18 years", ShortName = "With one child under 18 years", Order = 113)]
        public System.Nullable<System.Int32> PCT0160023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160024", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With two children under 18 years", ShortName = "With two children under 18 years", Order = 114)]
        public System.Nullable<System.Int32> PCT0160024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160025", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With three children under 18 years", ShortName = "With three children under 18 years", Order = 115)]
        public System.Nullable<System.Int32> PCT0160025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160026", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With four or more children under 18 years", ShortName = "With four or more children under 18 years", Order = 116)]
        public System.Nullable<System.Int32> PCT0160026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0170001", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 117)]
        public System.Nullable<System.Int32> PCT0170001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0170002", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried partner of householder present:", ShortName = "Unmarried partner of householder present:", Order = 118)]
        public System.Nullable<System.Int32> PCT0170002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0170003", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 119)]
        public System.Nullable<System.Int32> PCT0170003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0170004", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In male householder and male partner households", ShortName = "In male householder and male partner households", Order = 120)]
        public System.Nullable<System.Int32> PCT0170004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0170005", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In male householder and female partner households", ShortName = "In male householder and female partner households", Order = 121)]
        public System.Nullable<System.Int32> PCT0170005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0170006", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In female householder and female partner households", ShortName = "In female householder and female partner households", Order = 122)]
        public System.Nullable<System.Int32> PCT0170006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0170007", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In female householder and male partner households", ShortName = "In female householder and male partner households", Order = 123)]
        public System.Nullable<System.Int32> PCT0170007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0170008", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 124)]
        public System.Nullable<System.Int32> PCT0170008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0170009", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In male householder and male partner households", ShortName = "In male householder and male partner households", Order = 125)]
        public System.Nullable<System.Int32> PCT0170009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0170010", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In male householder and female partner households", ShortName = "In male householder and female partner households", Order = 126)]
        public System.Nullable<System.Int32> PCT0170010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0170011", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In female householder and female partner households", ShortName = "In female householder and female partner households", Order = 127)]
        public System.Nullable<System.Int32> PCT0170011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0170012", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In female householder and male partner households", ShortName = "In female householder and male partner households", Order = 128)]
        public System.Nullable<System.Int32> PCT0170012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0170013", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No unmarried partner of householder present:", ShortName = "No unmarried partner of householder present:", Order = 129)]
        public System.Nullable<System.Int32> PCT0170013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0170014", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 130)]
        public System.Nullable<System.Int32> PCT0170014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0170015", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In husband-wife family households", ShortName = "In husband-wife family households", Order = 131)]
        public System.Nullable<System.Int32> PCT0170015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0170016", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In male householder, no wife present, family households", ShortName = "In male householder, no wife present, family households", Order = 132)]
        public System.Nullable<System.Int32> PCT0170016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0170017", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In female householder, no husband present, family households", ShortName = "In female householder, no husband present, family households", Order = 133)]
        public System.Nullable<System.Int32> PCT0170017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0170018", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households", ShortName = "In nonfamily households", Order = 134)]
        public System.Nullable<System.Int32> PCT0170018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0180001", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 135)]
        public System.Nullable<System.Int32> PCT0180001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0180002", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 136)]
        public System.Nullable<System.Int32> PCT0180002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0180003", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone:", ShortName = "Living alone:", Order = 137)]
        public System.Nullable<System.Int32> PCT0180003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0180004", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 64 years", ShortName = "Householder 15 to 64 years", Order = 138)]
        public System.Nullable<System.Int32> PCT0180004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0180005", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 139)]
        public System.Nullable<System.Int32> PCT0180005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0180006", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 140)]
        public System.Nullable<System.Int32> PCT0180006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0180007", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 64 years", ShortName = "Householder 15 to 64 years", Order = 141)]
        public System.Nullable<System.Int32> PCT0180007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0180008", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 142)]
        public System.Nullable<System.Int32> PCT0180008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0180009", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 143)]
        public System.Nullable<System.Int32> PCT0180009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0180010", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone:", ShortName = "Living alone:", Order = 144)]
        public System.Nullable<System.Int32> PCT0180010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0180011", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 64 years", ShortName = "Householder 15 to 64 years", Order = 145)]
        public System.Nullable<System.Int32> PCT0180011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0180012", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 146)]
        public System.Nullable<System.Int32> PCT0180012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0180013", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone:", ShortName = "Not living alone:", Order = 147)]
        public System.Nullable<System.Int32> PCT0180013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0180014", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 15 to 64 years", ShortName = "Householder 15 to 64 years", Order = 148)]
        public System.Nullable<System.Int32> PCT0180014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0180015", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder 65 years and over", ShortName = "Householder 65 years and over", Order = 149)]
        public System.Nullable<System.Int32> PCT0180015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190001", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 150)]
        public System.Nullable<System.Int32> PCT0190001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190002", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 151)]
        public System.Nullable<System.Int32> PCT0190002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190003", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 152)]
        public System.Nullable<System.Int32> PCT0190003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190004", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 153)]
        public System.Nullable<System.Int32> PCT0190004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190005", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 154)]
        public System.Nullable<System.Int32> PCT0190005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190006", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 155)]
        public System.Nullable<System.Int32> PCT0190006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190007", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 156)]
        public System.Nullable<System.Int32> PCT0190007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190008", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 157)]
        public System.Nullable<System.Int32> PCT0190008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190009", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 158)]
        public System.Nullable<System.Int32> PCT0190009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190010", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 159)]
        public System.Nullable<System.Int32> PCT0190010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190011", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 160)]
        public System.Nullable<System.Int32> PCT0190011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200001", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 161)]
        public System.Nullable<System.Int32> PCT0200001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200002", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 162)]
        public System.Nullable<System.Int32> PCT0200002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200003", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 163)]
        public System.Nullable<System.Int32> PCT0200003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200004", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 164)]
        public System.Nullable<System.Int32> PCT0200004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200005", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 165)]
        public System.Nullable<System.Int32> PCT0200005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200006", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 166)]
        public System.Nullable<System.Int32> PCT0200006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200007", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 167)]
        public System.Nullable<System.Int32> PCT0200007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200008", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 168)]
        public System.Nullable<System.Int32> PCT0200008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200009", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 169)]
        public System.Nullable<System.Int32> PCT0200009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200010", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 170)]
        public System.Nullable<System.Int32> PCT0200010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200011", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 171)]
        public System.Nullable<System.Int32> PCT0200011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200012", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 172)]
        public System.Nullable<System.Int32> PCT0200012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200013", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 173)]
        public System.Nullable<System.Int32> PCT0200013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200014", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 174)]
        public System.Nullable<System.Int32> PCT0200014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200015", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 175)]
        public System.Nullable<System.Int32> PCT0200015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200016", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 176)]
        public System.Nullable<System.Int32> PCT0200016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200017", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 177)]
        public System.Nullable<System.Int32> PCT0200017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200018", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 178)]
        public System.Nullable<System.Int32> PCT0200018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200019", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 179)]
        public System.Nullable<System.Int32> PCT0200019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200020", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 180)]
        public System.Nullable<System.Int32> PCT0200020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200021", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 181)]
        public System.Nullable<System.Int32> PCT0200021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200022", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 182)]
        public System.Nullable<System.Int32> PCT0200022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200023", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 183)]
        public System.Nullable<System.Int32> PCT0200023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200024", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 184)]
        public System.Nullable<System.Int32> PCT0200024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200025", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 185)]
        public System.Nullable<System.Int32> PCT0200025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200026", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 186)]
        public System.Nullable<System.Int32> PCT0200026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200027", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 187)]
        public System.Nullable<System.Int32> PCT0200027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200028", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 188)]
        public System.Nullable<System.Int32> PCT0200028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200029", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 189)]
        public System.Nullable<System.Int32> PCT0200029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200030", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 190)]
        public System.Nullable<System.Int32> PCT0200030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200031", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 191)]
        public System.Nullable<System.Int32> PCT0200031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200032", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 192)]
        public System.Nullable<System.Int32> PCT0200032 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1_00018(string csvLine) : base(csvLine) {}

        public SF1_00018(string[] values) : base(values) {}

        public SF1_00018(OleDbDataReader reader, CensusFileType fileType)
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
                PCT0130001 = (System.Nullable<System.Int32>)reader[5];
            }
            if(reader[6] != DBNull.Value)
            {
                PCT0130002 = (System.Nullable<System.Int32>)reader[6];
            }
            if(reader[7] != DBNull.Value)
            {
                PCT0130003 = (System.Nullable<System.Int32>)reader[7];
            }
            if(reader[8] != DBNull.Value)
            {
                PCT0130004 = (System.Nullable<System.Int32>)reader[8];
            }
            if(reader[9] != DBNull.Value)
            {
                PCT0130005 = (System.Nullable<System.Int32>)reader[9];
            }
            if(reader[10] != DBNull.Value)
            {
                PCT0130006 = (System.Nullable<System.Int32>)reader[10];
            }
            if(reader[11] != DBNull.Value)
            {
                PCT0130007 = (System.Nullable<System.Int32>)reader[11];
            }
            if(reader[12] != DBNull.Value)
            {
                PCT0130008 = (System.Nullable<System.Int32>)reader[12];
            }
            if(reader[13] != DBNull.Value)
            {
                PCT0130009 = (System.Nullable<System.Int32>)reader[13];
            }
            if(reader[14] != DBNull.Value)
            {
                PCT0130010 = (System.Nullable<System.Int32>)reader[14];
            }
            if(reader[15] != DBNull.Value)
            {
                PCT0130011 = (System.Nullable<System.Int32>)reader[15];
            }
            if(reader[16] != DBNull.Value)
            {
                PCT0130012 = (System.Nullable<System.Int32>)reader[16];
            }
            if(reader[17] != DBNull.Value)
            {
                PCT0130013 = (System.Nullable<System.Int32>)reader[17];
            }
            if(reader[18] != DBNull.Value)
            {
                PCT0130014 = (System.Nullable<System.Int32>)reader[18];
            }
            if(reader[19] != DBNull.Value)
            {
                PCT0130015 = (System.Nullable<System.Int32>)reader[19];
            }
            if(reader[20] != DBNull.Value)
            {
                PCT0130016 = (System.Nullable<System.Int32>)reader[20];
            }
            if(reader[21] != DBNull.Value)
            {
                PCT0130017 = (System.Nullable<System.Int32>)reader[21];
            }
            if(reader[22] != DBNull.Value)
            {
                PCT0130018 = (System.Nullable<System.Int32>)reader[22];
            }
            if(reader[23] != DBNull.Value)
            {
                PCT0130019 = (System.Nullable<System.Int32>)reader[23];
            }
            if(reader[24] != DBNull.Value)
            {
                PCT0130020 = (System.Nullable<System.Int32>)reader[24];
            }
            if(reader[25] != DBNull.Value)
            {
                PCT0130021 = (System.Nullable<System.Int32>)reader[25];
            }
            if(reader[26] != DBNull.Value)
            {
                PCT0130022 = (System.Nullable<System.Int32>)reader[26];
            }
            if(reader[27] != DBNull.Value)
            {
                PCT0130023 = (System.Nullable<System.Int32>)reader[27];
            }
            if(reader[28] != DBNull.Value)
            {
                PCT0130024 = (System.Nullable<System.Int32>)reader[28];
            }
            if(reader[29] != DBNull.Value)
            {
                PCT0130025 = (System.Nullable<System.Int32>)reader[29];
            }
            if(reader[30] != DBNull.Value)
            {
                PCT0130026 = (System.Nullable<System.Int32>)reader[30];
            }
            if(reader[31] != DBNull.Value)
            {
                PCT0130027 = (System.Nullable<System.Int32>)reader[31];
            }
            if(reader[32] != DBNull.Value)
            {
                PCT0130028 = (System.Nullable<System.Int32>)reader[32];
            }
            if(reader[33] != DBNull.Value)
            {
                PCT0130029 = (System.Nullable<System.Int32>)reader[33];
            }
            if(reader[34] != DBNull.Value)
            {
                PCT0130030 = (System.Nullable<System.Int32>)reader[34];
            }
            if(reader[35] != DBNull.Value)
            {
                PCT0130031 = (System.Nullable<System.Int32>)reader[35];
            }
            if(reader[36] != DBNull.Value)
            {
                PCT0130032 = (System.Nullable<System.Int32>)reader[36];
            }
            if(reader[37] != DBNull.Value)
            {
                PCT0130033 = (System.Nullable<System.Int32>)reader[37];
            }
            if(reader[38] != DBNull.Value)
            {
                PCT0130034 = (System.Nullable<System.Int32>)reader[38];
            }
            if(reader[39] != DBNull.Value)
            {
                PCT0130035 = (System.Nullable<System.Int32>)reader[39];
            }
            if(reader[40] != DBNull.Value)
            {
                PCT0130036 = (System.Nullable<System.Int32>)reader[40];
            }
            if(reader[41] != DBNull.Value)
            {
                PCT0130037 = (System.Nullable<System.Int32>)reader[41];
            }
            if(reader[42] != DBNull.Value)
            {
                PCT0130038 = (System.Nullable<System.Int32>)reader[42];
            }
            if(reader[43] != DBNull.Value)
            {
                PCT0130039 = (System.Nullable<System.Int32>)reader[43];
            }
            if(reader[44] != DBNull.Value)
            {
                PCT0130040 = (System.Nullable<System.Int32>)reader[44];
            }
            if(reader[45] != DBNull.Value)
            {
                PCT0130041 = (System.Nullable<System.Int32>)reader[45];
            }
            if(reader[46] != DBNull.Value)
            {
                PCT0130042 = (System.Nullable<System.Int32>)reader[46];
            }
            if(reader[47] != DBNull.Value)
            {
                PCT0130043 = (System.Nullable<System.Int32>)reader[47];
            }
            if(reader[48] != DBNull.Value)
            {
                PCT0130044 = (System.Nullable<System.Int32>)reader[48];
            }
            if(reader[49] != DBNull.Value)
            {
                PCT0130045 = (System.Nullable<System.Int32>)reader[49];
            }
            if(reader[50] != DBNull.Value)
            {
                PCT0130046 = (System.Nullable<System.Int32>)reader[50];
            }
            if(reader[51] != DBNull.Value)
            {
                PCT0130047 = (System.Nullable<System.Int32>)reader[51];
            }
            if(reader[52] != DBNull.Value)
            {
                PCT0130048 = (System.Nullable<System.Int32>)reader[52];
            }
            if(reader[53] != DBNull.Value)
            {
                PCT0130049 = (System.Nullable<System.Int32>)reader[53];
            }
            if(reader[54] != DBNull.Value)
            {
                PCT0140001 = (System.Nullable<System.Int32>)reader[54];
            }
            if(reader[55] != DBNull.Value)
            {
                PCT0140002 = (System.Nullable<System.Int32>)reader[55];
            }
            if(reader[56] != DBNull.Value)
            {
                PCT0140003 = (System.Nullable<System.Int32>)reader[56];
            }
            if(reader[57] != DBNull.Value)
            {
                PCT0150001 = (System.Nullable<System.Int32>)reader[57];
            }
            if(reader[58] != DBNull.Value)
            {
                PCT0150002 = (System.Nullable<System.Int32>)reader[58];
            }
            if(reader[59] != DBNull.Value)
            {
                PCT0150003 = (System.Nullable<System.Int32>)reader[59];
            }
            if(reader[60] != DBNull.Value)
            {
                PCT0150004 = (System.Nullable<System.Int32>)reader[60];
            }
            if(reader[61] != DBNull.Value)
            {
                PCT0150005 = (System.Nullable<System.Int32>)reader[61];
            }
            if(reader[62] != DBNull.Value)
            {
                PCT0150006 = (System.Nullable<System.Int32>)reader[62];
            }
            if(reader[63] != DBNull.Value)
            {
                PCT0150007 = (System.Nullable<System.Int32>)reader[63];
            }
            if(reader[64] != DBNull.Value)
            {
                PCT0150008 = (System.Nullable<System.Int32>)reader[64];
            }
            if(reader[65] != DBNull.Value)
            {
                PCT0150009 = (System.Nullable<System.Int32>)reader[65];
            }
            if(reader[66] != DBNull.Value)
            {
                PCT0150010 = (System.Nullable<System.Int32>)reader[66];
            }
            if(reader[67] != DBNull.Value)
            {
                PCT0150011 = (System.Nullable<System.Int32>)reader[67];
            }
            if(reader[68] != DBNull.Value)
            {
                PCT0150012 = (System.Nullable<System.Int32>)reader[68];
            }
            if(reader[69] != DBNull.Value)
            {
                PCT0150013 = (System.Nullable<System.Int32>)reader[69];
            }
            if(reader[70] != DBNull.Value)
            {
                PCT0150014 = (System.Nullable<System.Int32>)reader[70];
            }
            if(reader[71] != DBNull.Value)
            {
                PCT0150015 = (System.Nullable<System.Int32>)reader[71];
            }
            if(reader[72] != DBNull.Value)
            {
                PCT0150016 = (System.Nullable<System.Int32>)reader[72];
            }
            if(reader[73] != DBNull.Value)
            {
                PCT0150017 = (System.Nullable<System.Int32>)reader[73];
            }
            if(reader[74] != DBNull.Value)
            {
                PCT0150018 = (System.Nullable<System.Int32>)reader[74];
            }
            if(reader[75] != DBNull.Value)
            {
                PCT0150019 = (System.Nullable<System.Int32>)reader[75];
            }
            if(reader[76] != DBNull.Value)
            {
                PCT0150020 = (System.Nullable<System.Int32>)reader[76];
            }
            if(reader[77] != DBNull.Value)
            {
                PCT0150021 = (System.Nullable<System.Int32>)reader[77];
            }
            if(reader[78] != DBNull.Value)
            {
                PCT0150022 = (System.Nullable<System.Int32>)reader[78];
            }
            if(reader[79] != DBNull.Value)
            {
                PCT0150023 = (System.Nullable<System.Int32>)reader[79];
            }
            if(reader[80] != DBNull.Value)
            {
                PCT0150024 = (System.Nullable<System.Int32>)reader[80];
            }
            if(reader[81] != DBNull.Value)
            {
                PCT0150025 = (System.Nullable<System.Int32>)reader[81];
            }
            if(reader[82] != DBNull.Value)
            {
                PCT0150026 = (System.Nullable<System.Int32>)reader[82];
            }
            if(reader[83] != DBNull.Value)
            {
                PCT0150027 = (System.Nullable<System.Int32>)reader[83];
            }
            if(reader[84] != DBNull.Value)
            {
                PCT0150028 = (System.Nullable<System.Int32>)reader[84];
            }
            if(reader[85] != DBNull.Value)
            {
                PCT0150029 = (System.Nullable<System.Int32>)reader[85];
            }
            if(reader[86] != DBNull.Value)
            {
                PCT0150030 = (System.Nullable<System.Int32>)reader[86];
            }
            if(reader[87] != DBNull.Value)
            {
                PCT0150031 = (System.Nullable<System.Int32>)reader[87];
            }
            if(reader[88] != DBNull.Value)
            {
                PCT0150032 = (System.Nullable<System.Int32>)reader[88];
            }
            if(reader[89] != DBNull.Value)
            {
                PCT0150033 = (System.Nullable<System.Int32>)reader[89];
            }
            if(reader[90] != DBNull.Value)
            {
                PCT0150034 = (System.Nullable<System.Int32>)reader[90];
            }
            if(reader[91] != DBNull.Value)
            {
                PCT0160001 = (System.Nullable<System.Int32>)reader[91];
            }
            if(reader[92] != DBNull.Value)
            {
                PCT0160002 = (System.Nullable<System.Int32>)reader[92];
            }
            if(reader[93] != DBNull.Value)
            {
                PCT0160003 = (System.Nullable<System.Int32>)reader[93];
            }
            if(reader[94] != DBNull.Value)
            {
                PCT0160004 = (System.Nullable<System.Int32>)reader[94];
            }
            if(reader[95] != DBNull.Value)
            {
                PCT0160005 = (System.Nullable<System.Int32>)reader[95];
            }
            if(reader[96] != DBNull.Value)
            {
                PCT0160006 = (System.Nullable<System.Int32>)reader[96];
            }
            if(reader[97] != DBNull.Value)
            {
                PCT0160007 = (System.Nullable<System.Int32>)reader[97];
            }
            if(reader[98] != DBNull.Value)
            {
                PCT0160008 = (System.Nullable<System.Int32>)reader[98];
            }
            if(reader[99] != DBNull.Value)
            {
                PCT0160009 = (System.Nullable<System.Int32>)reader[99];
            }
            if(reader[100] != DBNull.Value)
            {
                PCT0160010 = (System.Nullable<System.Int32>)reader[100];
            }
            if(reader[101] != DBNull.Value)
            {
                PCT0160011 = (System.Nullable<System.Int32>)reader[101];
            }
            if(reader[102] != DBNull.Value)
            {
                PCT0160012 = (System.Nullable<System.Int32>)reader[102];
            }
            if(reader[103] != DBNull.Value)
            {
                PCT0160013 = (System.Nullable<System.Int32>)reader[103];
            }
            if(reader[104] != DBNull.Value)
            {
                PCT0160014 = (System.Nullable<System.Int32>)reader[104];
            }
            if(reader[105] != DBNull.Value)
            {
                PCT0160015 = (System.Nullable<System.Int32>)reader[105];
            }
            if(reader[106] != DBNull.Value)
            {
                PCT0160016 = (System.Nullable<System.Int32>)reader[106];
            }
            if(reader[107] != DBNull.Value)
            {
                PCT0160017 = (System.Nullable<System.Int32>)reader[107];
            }
            if(reader[108] != DBNull.Value)
            {
                PCT0160018 = (System.Nullable<System.Int32>)reader[108];
            }
            if(reader[109] != DBNull.Value)
            {
                PCT0160019 = (System.Nullable<System.Int32>)reader[109];
            }
            if(reader[110] != DBNull.Value)
            {
                PCT0160020 = (System.Nullable<System.Int32>)reader[110];
            }
            if(reader[111] != DBNull.Value)
            {
                PCT0160021 = (System.Nullable<System.Int32>)reader[111];
            }
            if(reader[112] != DBNull.Value)
            {
                PCT0160022 = (System.Nullable<System.Int32>)reader[112];
            }
            if(reader[113] != DBNull.Value)
            {
                PCT0160023 = (System.Nullable<System.Int32>)reader[113];
            }
            if(reader[114] != DBNull.Value)
            {
                PCT0160024 = (System.Nullable<System.Int32>)reader[114];
            }
            if(reader[115] != DBNull.Value)
            {
                PCT0160025 = (System.Nullable<System.Int32>)reader[115];
            }
            if(reader[116] != DBNull.Value)
            {
                PCT0160026 = (System.Nullable<System.Int32>)reader[116];
            }
            if(reader[117] != DBNull.Value)
            {
                PCT0170001 = (System.Nullable<System.Int32>)reader[117];
            }
            if(reader[118] != DBNull.Value)
            {
                PCT0170002 = (System.Nullable<System.Int32>)reader[118];
            }
            if(reader[119] != DBNull.Value)
            {
                PCT0170003 = (System.Nullable<System.Int32>)reader[119];
            }
            if(reader[120] != DBNull.Value)
            {
                PCT0170004 = (System.Nullable<System.Int32>)reader[120];
            }
            if(reader[121] != DBNull.Value)
            {
                PCT0170005 = (System.Nullable<System.Int32>)reader[121];
            }
            if(reader[122] != DBNull.Value)
            {
                PCT0170006 = (System.Nullable<System.Int32>)reader[122];
            }
            if(reader[123] != DBNull.Value)
            {
                PCT0170007 = (System.Nullable<System.Int32>)reader[123];
            }
            if(reader[124] != DBNull.Value)
            {
                PCT0170008 = (System.Nullable<System.Int32>)reader[124];
            }
            if(reader[125] != DBNull.Value)
            {
                PCT0170009 = (System.Nullable<System.Int32>)reader[125];
            }
            if(reader[126] != DBNull.Value)
            {
                PCT0170010 = (System.Nullable<System.Int32>)reader[126];
            }
            if(reader[127] != DBNull.Value)
            {
                PCT0170011 = (System.Nullable<System.Int32>)reader[127];
            }
            if(reader[128] != DBNull.Value)
            {
                PCT0170012 = (System.Nullable<System.Int32>)reader[128];
            }
            if(reader[129] != DBNull.Value)
            {
                PCT0170013 = (System.Nullable<System.Int32>)reader[129];
            }
            if(reader[130] != DBNull.Value)
            {
                PCT0170014 = (System.Nullable<System.Int32>)reader[130];
            }
            if(reader[131] != DBNull.Value)
            {
                PCT0170015 = (System.Nullable<System.Int32>)reader[131];
            }
            if(reader[132] != DBNull.Value)
            {
                PCT0170016 = (System.Nullable<System.Int32>)reader[132];
            }
            if(reader[133] != DBNull.Value)
            {
                PCT0170017 = (System.Nullable<System.Int32>)reader[133];
            }
            if(reader[134] != DBNull.Value)
            {
                PCT0170018 = (System.Nullable<System.Int32>)reader[134];
            }
            if(reader[135] != DBNull.Value)
            {
                PCT0180001 = (System.Nullable<System.Int32>)reader[135];
            }
            if(reader[136] != DBNull.Value)
            {
                PCT0180002 = (System.Nullable<System.Int32>)reader[136];
            }
            if(reader[137] != DBNull.Value)
            {
                PCT0180003 = (System.Nullable<System.Int32>)reader[137];
            }
            if(reader[138] != DBNull.Value)
            {
                PCT0180004 = (System.Nullable<System.Int32>)reader[138];
            }
            if(reader[139] != DBNull.Value)
            {
                PCT0180005 = (System.Nullable<System.Int32>)reader[139];
            }
            if(reader[140] != DBNull.Value)
            {
                PCT0180006 = (System.Nullable<System.Int32>)reader[140];
            }
            if(reader[141] != DBNull.Value)
            {
                PCT0180007 = (System.Nullable<System.Int32>)reader[141];
            }
            if(reader[142] != DBNull.Value)
            {
                PCT0180008 = (System.Nullable<System.Int32>)reader[142];
            }
            if(reader[143] != DBNull.Value)
            {
                PCT0180009 = (System.Nullable<System.Int32>)reader[143];
            }
            if(reader[144] != DBNull.Value)
            {
                PCT0180010 = (System.Nullable<System.Int32>)reader[144];
            }
            if(reader[145] != DBNull.Value)
            {
                PCT0180011 = (System.Nullable<System.Int32>)reader[145];
            }
            if(reader[146] != DBNull.Value)
            {
                PCT0180012 = (System.Nullable<System.Int32>)reader[146];
            }
            if(reader[147] != DBNull.Value)
            {
                PCT0180013 = (System.Nullable<System.Int32>)reader[147];
            }
            if(reader[148] != DBNull.Value)
            {
                PCT0180014 = (System.Nullable<System.Int32>)reader[148];
            }
            if(reader[149] != DBNull.Value)
            {
                PCT0180015 = (System.Nullable<System.Int32>)reader[149];
            }
            if(reader[150] != DBNull.Value)
            {
                PCT0190001 = (System.Nullable<System.Int32>)reader[150];
            }
            if(reader[151] != DBNull.Value)
            {
                PCT0190002 = (System.Nullable<System.Int32>)reader[151];
            }
            if(reader[152] != DBNull.Value)
            {
                PCT0190003 = (System.Nullable<System.Int32>)reader[152];
            }
            if(reader[153] != DBNull.Value)
            {
                PCT0190004 = (System.Nullable<System.Int32>)reader[153];
            }
            if(reader[154] != DBNull.Value)
            {
                PCT0190005 = (System.Nullable<System.Int32>)reader[154];
            }
            if(reader[155] != DBNull.Value)
            {
                PCT0190006 = (System.Nullable<System.Int32>)reader[155];
            }
            if(reader[156] != DBNull.Value)
            {
                PCT0190007 = (System.Nullable<System.Int32>)reader[156];
            }
            if(reader[157] != DBNull.Value)
            {
                PCT0190008 = (System.Nullable<System.Int32>)reader[157];
            }
            if(reader[158] != DBNull.Value)
            {
                PCT0190009 = (System.Nullable<System.Int32>)reader[158];
            }
            if(reader[159] != DBNull.Value)
            {
                PCT0190010 = (System.Nullable<System.Int32>)reader[159];
            }
            if(reader[160] != DBNull.Value)
            {
                PCT0190011 = (System.Nullable<System.Int32>)reader[160];
            }
            if(reader[161] != DBNull.Value)
            {
                PCT0200001 = (System.Nullable<System.Int32>)reader[161];
            }
            if(reader[162] != DBNull.Value)
            {
                PCT0200002 = (System.Nullable<System.Int32>)reader[162];
            }
            if(reader[163] != DBNull.Value)
            {
                PCT0200003 = (System.Nullable<System.Int32>)reader[163];
            }
            if(reader[164] != DBNull.Value)
            {
                PCT0200004 = (System.Nullable<System.Int32>)reader[164];
            }
            if(reader[165] != DBNull.Value)
            {
                PCT0200005 = (System.Nullable<System.Int32>)reader[165];
            }
            if(reader[166] != DBNull.Value)
            {
                PCT0200006 = (System.Nullable<System.Int32>)reader[166];
            }
            if(reader[167] != DBNull.Value)
            {
                PCT0200007 = (System.Nullable<System.Int32>)reader[167];
            }
            if(reader[168] != DBNull.Value)
            {
                PCT0200008 = (System.Nullable<System.Int32>)reader[168];
            }
            if(reader[169] != DBNull.Value)
            {
                PCT0200009 = (System.Nullable<System.Int32>)reader[169];
            }
            if(reader[170] != DBNull.Value)
            {
                PCT0200010 = (System.Nullable<System.Int32>)reader[170];
            }
            if(reader[171] != DBNull.Value)
            {
                PCT0200011 = (System.Nullable<System.Int32>)reader[171];
            }
            if(reader[172] != DBNull.Value)
            {
                PCT0200012 = (System.Nullable<System.Int32>)reader[172];
            }
            if(reader[173] != DBNull.Value)
            {
                PCT0200013 = (System.Nullable<System.Int32>)reader[173];
            }
            if(reader[174] != DBNull.Value)
            {
                PCT0200014 = (System.Nullable<System.Int32>)reader[174];
            }
            if(reader[175] != DBNull.Value)
            {
                PCT0200015 = (System.Nullable<System.Int32>)reader[175];
            }
            if(reader[176] != DBNull.Value)
            {
                PCT0200016 = (System.Nullable<System.Int32>)reader[176];
            }
            if(reader[177] != DBNull.Value)
            {
                PCT0200017 = (System.Nullable<System.Int32>)reader[177];
            }
            if(reader[178] != DBNull.Value)
            {
                PCT0200018 = (System.Nullable<System.Int32>)reader[178];
            }
            if(reader[179] != DBNull.Value)
            {
                PCT0200019 = (System.Nullable<System.Int32>)reader[179];
            }
            if(reader[180] != DBNull.Value)
            {
                PCT0200020 = (System.Nullable<System.Int32>)reader[180];
            }
            if(reader[181] != DBNull.Value)
            {
                PCT0200021 = (System.Nullable<System.Int32>)reader[181];
            }
            if(reader[182] != DBNull.Value)
            {
                PCT0200022 = (System.Nullable<System.Int32>)reader[182];
            }
            if(reader[183] != DBNull.Value)
            {
                PCT0200023 = (System.Nullable<System.Int32>)reader[183];
            }
            if(reader[184] != DBNull.Value)
            {
                PCT0200024 = (System.Nullable<System.Int32>)reader[184];
            }
            if(reader[185] != DBNull.Value)
            {
                PCT0200025 = (System.Nullable<System.Int32>)reader[185];
            }
            if(reader[186] != DBNull.Value)
            {
                PCT0200026 = (System.Nullable<System.Int32>)reader[186];
            }
            if(reader[187] != DBNull.Value)
            {
                PCT0200027 = (System.Nullable<System.Int32>)reader[187];
            }
            if(reader[188] != DBNull.Value)
            {
                PCT0200028 = (System.Nullable<System.Int32>)reader[188];
            }
            if(reader[189] != DBNull.Value)
            {
                PCT0200029 = (System.Nullable<System.Int32>)reader[189];
            }
            if(reader[190] != DBNull.Value)
            {
                PCT0200030 = (System.Nullable<System.Int32>)reader[190];
            }
            if(reader[191] != DBNull.Value)
            {
                PCT0200031 = (System.Nullable<System.Int32>)reader[191];
            }
            if(reader[192] != DBNull.Value)
            {
                PCT0200032 = (System.Nullable<System.Int32>)reader[192];
            }
        }
        #endregion Constructors
    }
}