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

    [Table("SF2_Segment_04")]
    public partial class SF2_Segment_04 : BaseModel
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
        [Column("PCT0050001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total (400-479, 481-499):", ShortName = "Total (400-479, 481-499):", Order = 5)]
        public System.Nullable<System.Int32> PCT0050001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian Indian (400-401)", ShortName = "Asian Indian (400-401)", Order = 6)]
        public System.Nullable<System.Int32> PCT0050002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Bangladeshi (402)", ShortName = "Bangladeshi (402)", Order = 7)]
        public System.Nullable<System.Int32> PCT0050003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Bhutanese (403)", ShortName = "Bhutanese (403)", Order = 8)]
        public System.Nullable<System.Int32> PCT0050004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Burmese (404)", ShortName = "Burmese (404)", Order = 9)]
        public System.Nullable<System.Int32> PCT0050005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Cambodian (405-409)", ShortName = "Cambodian (405-409)", Order = 10)]
        public System.Nullable<System.Int32> PCT0050006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Chinese (except Taiwanese) (410-411)", ShortName = "Chinese (except Taiwanese) (410-411)", Order = 11)]
        public System.Nullable<System.Int32> PCT0050007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Filipino (420-421)", ShortName = "Filipino (420-421)", Order = 12)]
        public System.Nullable<System.Int32> PCT0050008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hmong (422)", ShortName = "Hmong (422)", Order = 13)]
        public System.Nullable<System.Int32> PCT0050009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Indonesian (423-429)", ShortName = "Indonesian (423-429)", Order = 14)]
        public System.Nullable<System.Int32> PCT0050010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Japanese (430-439)", ShortName = "Japanese (430-439)", Order = 15)]
        public System.Nullable<System.Int32> PCT0050011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Korean (440-441)", ShortName = "Korean (440-441)", Order = 16)]
        public System.Nullable<System.Int32> PCT0050012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Laotian (442)", ShortName = "Laotian (442)", Order = 17)]
        public System.Nullable<System.Int32> PCT0050013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Malaysian (443)", ShortName = "Malaysian (443)", Order = 18)]
        public System.Nullable<System.Int32> PCT0050014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nepalese (472)", ShortName = "Nepalese (472)", Order = 19)]
        public System.Nullable<System.Int32> PCT0050015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Pakistani (445)", ShortName = "Pakistani (445)", Order = 20)]
        public System.Nullable<System.Int32> PCT0050016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050017", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Sri Lankan (446)", ShortName = "Sri Lankan (446)", Order = 21)]
        public System.Nullable<System.Int32> PCT0050017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050018", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Taiwanese (412-419)", ShortName = "Taiwanese (412-419)", Order = 22)]
        public System.Nullable<System.Int32> PCT0050018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050019", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Thai (447-449)", ShortName = "Thai (447-449)", Order = 23)]
        public System.Nullable<System.Int32> PCT0050019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050020", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Vietnamese (450-459)", ShortName = "Vietnamese (450-459)", Order = 24)]
        public System.Nullable<System.Int32> PCT0050020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050021", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Asian, specified (444, 465, 470-471, 473-479)", ShortName = "Other Asian, specified (444, 465, 470-471, 473-479)", Order = 25)]
        public System.Nullable<System.Int32> PCT0050021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050022", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Asian, not specified (460-464, 466-469, 481-499)", ShortName = "Other Asian, not specified (460-464, 466-469, 481-499)", Order = 26)]
        public System.Nullable<System.Int32> PCT0050022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050023", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 27)]
        public System.Nullable<System.Int32> PCT0050023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050024", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 28)]
        public System.Nullable<System.Int32> PCT0050024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050025", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 29)]
        public System.Nullable<System.Int32> PCT0050025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050026", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 30)]
        public System.Nullable<System.Int32> PCT0050026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050027", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 31)]
        public System.Nullable<System.Int32> PCT0050027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050028", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 32)]
        public System.Nullable<System.Int32> PCT0050028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050029", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 33)]
        public System.Nullable<System.Int32> PCT0050029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050030", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 34)]
        public System.Nullable<System.Int32> PCT0050030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050031", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 35)]
        public System.Nullable<System.Int32> PCT0050031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050032", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 36)]
        public System.Nullable<System.Int32> PCT0050032 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050033", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 37)]
        public System.Nullable<System.Int32> PCT0050033 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050034", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 38)]
        public System.Nullable<System.Int32> PCT0050034 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050035", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 39)]
        public System.Nullable<System.Int32> PCT0050035 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050036", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 40)]
        public System.Nullable<System.Int32> PCT0050036 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050037", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 41)]
        public System.Nullable<System.Int32> PCT0050037 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050038", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 42)]
        public System.Nullable<System.Int32> PCT0050038 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050039", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 43)]
        public System.Nullable<System.Int32> PCT0050039 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050040", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "50 to 54 years", ShortName = "50 to 54 years", Order = 44)]
        public System.Nullable<System.Int32> PCT0050040 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050041", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "55 to 59 years", ShortName = "55 to 59 years", Order = 45)]
        public System.Nullable<System.Int32> PCT0050041 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050042", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "60 and 61 years", ShortName = "60 and 61 years", Order = 46)]
        public System.Nullable<System.Int32> PCT0050042 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050043", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "62 to 64 years", ShortName = "62 to 64 years", Order = 47)]
        public System.Nullable<System.Int32> PCT0050043 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050044", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 and 66 years", ShortName = "65 and 66 years", Order = 48)]
        public System.Nullable<System.Int32> PCT0050044 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050045", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "67 to 69 years", ShortName = "67 to 69 years", Order = 49)]
        public System.Nullable<System.Int32> PCT0050045 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050046", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "70 to 74 years", ShortName = "70 to 74 years", Order = 50)]
        public System.Nullable<System.Int32> PCT0050046 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050047", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "75 to 79 years", ShortName = "75 to 79 years", Order = 51)]
        public System.Nullable<System.Int32> PCT0050047 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050048", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "80 to 84 years", ShortName = "80 to 84 years", Order = 52)]
        public System.Nullable<System.Int32> PCT0050048 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0050049", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "85 years and over", ShortName = "85 years and over", Order = 53)]
        public System.Nullable<System.Int32> PCT0050049 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060001", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total Asian categories tallied (400-499) & (400-499):", ShortName = "Total Asian categories tallied (400-499) & (400-499):", Order = 54)]
        public System.Nullable<System.Int32> PCT0060001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060002", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian Indian (400-401) & (400-499)", ShortName = "Asian Indian (400-401) & (400-499)", Order = 55)]
        public System.Nullable<System.Int32> PCT0060002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0060003", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Bangladeshi (402) & (400-499)", ShortName = "Bangladeshi (402) & (400-499)", Order = 56)]
        public System.Nullable<System.Int32> PCT0060003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070001", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total Asian categories tallied (400-499) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Total Asian categories tallied (400-499) & (100-299) or (300, A01-Z99) or (400-999):", Order = 57)]
        public System.Nullable<System.Double> PCT0070001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070002", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Asian Indian (400-401) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Asian Indian (400-401) & (100-299) or (300, A01-Z99) or (400-999)", Order = 58)]
        public System.Nullable<System.Double> PCT0070002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0070003", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Bangladeshi (402) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Bangladeshi (402) & (100-299) or (300, A01-Z99) or (400-999)", Order = 59)]
        public System.Nullable<System.Double> PCT0070003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080001", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total (500-549, 551-599):", ShortName = "Total (500-549, 551-599):", Order = 60)]
        public System.Nullable<System.Int32> PCT0080001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080002", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Polynesian (500-519):", ShortName = "Polynesian (500-519):", Order = 61)]
        public System.Nullable<System.Int32> PCT0080002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080003", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian (500-503)", ShortName = "Native Hawaiian (500-503)", Order = 62)]
        public System.Nullable<System.Int32> PCT0080003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080004", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Samoan (510-511)", ShortName = "Samoan (510-511)", Order = 63)]
        public System.Nullable<System.Int32> PCT0080004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080005", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Tongan (513)", ShortName = "Tongan (513)", Order = 64)]
        public System.Nullable<System.Int32> PCT0080005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080006", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Polynesian (504-509, 512, 514-519)", ShortName = "Other Polynesian (504-509, 512, 514-519)", Order = 65)]
        public System.Nullable<System.Int32> PCT0080006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080007", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Micronesian (520-529, 531-541):", ShortName = "Micronesian (520-529, 531-541):", Order = 66)]
        public System.Nullable<System.Int32> PCT0080007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080008", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Guamanian or Chamorro (520-522)", ShortName = "Guamanian or Chamorro (520-522)", Order = 67)]
        public System.Nullable<System.Int32> PCT0080008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0080009", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Marshallese (532)", ShortName = "Marshallese (532)", Order = 68)]
        public System.Nullable<System.Int32> PCT0080009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090001", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total Native Hawaiian and Other Pacific Islander categories tallied (500-599) & (500-599):", ShortName = "Total Native Hawaiian and Other Pacific Islander categories tallied (500-599) & (500-599):", Order = 69)]
        public System.Nullable<System.Int32> PCT0090001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090002", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Polynesian (500-519) & (500-599):", ShortName = "Polynesian (500-519) & (500-599):", Order = 70)]
        public System.Nullable<System.Int32> PCT0090002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090003", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian (500-503) & (500-599)", ShortName = "Native Hawaiian (500-503) & (500-599)", Order = 71)]
        public System.Nullable<System.Int32> PCT0090003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090004", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Samoan (510-511) & (500-599)", ShortName = "Samoan (510-511) & (500-599)", Order = 72)]
        public System.Nullable<System.Int32> PCT0090004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090005", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Tongan (513) & (500-599)", ShortName = "Tongan (513) & (500-599)", Order = 73)]
        public System.Nullable<System.Int32> PCT0090005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090006", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Polynesian (504-509, 512, 514-519) & (500-599)", ShortName = "Other Polynesian (504-509, 512, 514-519) & (500-599)", Order = 74)]
        public System.Nullable<System.Int32> PCT0090006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090007", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Micronesian (520-529, 531-541) & (500-599):", ShortName = "Micronesian (520-529, 531-541) & (500-599):", Order = 75)]
        public System.Nullable<System.Int32> PCT0090007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090008", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Guamanian or Chamorro (520-522) & (500-599)", ShortName = "Guamanian or Chamorro (520-522) & (500-599)", Order = 76)]
        public System.Nullable<System.Int32> PCT0090008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090009", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Marshallese (532) & (500-599)", ShortName = "Marshallese (532) & (500-599)", Order = 77)]
        public System.Nullable<System.Int32> PCT0090009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090010", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Micronesian (523-529, 531, 533-541) & (500-599)", ShortName = "Other Micronesian (523-529, 531, 533-541) & (500-599)", Order = 78)]
        public System.Nullable<System.Int32> PCT0090010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090011", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Melanesian (542-546) & (500-599):", ShortName = "Melanesian (542-546) & (500-599):", Order = 79)]
        public System.Nullable<System.Int32> PCT0090011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090012", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Fijian (542) & (500-599)", ShortName = "Fijian (542) & (500-599)", Order = 80)]
        public System.Nullable<System.Int32> PCT0090012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090013", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Melanesian (543-546) & (500-599)", ShortName = "Other Melanesian (543-546) & (500-599)", Order = 81)]
        public System.Nullable<System.Int32> PCT0090013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090014", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Pacific Islander, not specified (530, 547-599) & (500-599)", ShortName = "Other Pacific Islander, not specified (530, 547-599) & (500-599)", Order = 82)]
        public System.Nullable<System.Int32> PCT0090014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090015", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 83)]
        public System.Nullable<System.Int32> PCT0090015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090016", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 84)]
        public System.Nullable<System.Int32> PCT0090016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090017", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 85)]
        public System.Nullable<System.Int32> PCT0090017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090018", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder", ShortName = "Male householder", Order = 86)]
        public System.Nullable<System.Int32> PCT0090018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090019", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder", ShortName = "Female householder", Order = 87)]
        public System.Nullable<System.Int32> PCT0090019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100001", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total Native Hawaiian and Other Pacific Islander categories tallied (500-599) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Total Native Hawaiian and Other Pacific Islander categories tallied (500-599) & (100-299) or (300, A01-Z99) or (400-999):", Order = 88)]
        public System.Nullable<System.Int32> PCT0100001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100002", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Polynesian (500-519) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Polynesian (500-519) & (100-299) or (300, A01-Z99) or (400-999):", Order = 89)]
        public System.Nullable<System.Int32> PCT0100002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100003", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian (500-503) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Native Hawaiian (500-503) & (100-299) or (300, A01-Z99) or (400-999)", Order = 90)]
        public System.Nullable<System.Int32> PCT0100003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100004", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Samoan (510-511) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Samoan (510-511) & (100-299) or (300, A01-Z99) or (400-999)", Order = 91)]
        public System.Nullable<System.Int32> PCT0100004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100005", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Tongan (513) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Tongan (513) & (100-299) or (300, A01-Z99) or (400-999)", Order = 92)]
        public System.Nullable<System.Int32> PCT0100005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100006", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Polynesian (504-509, 512, 514-519) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Other Polynesian (504-509, 512, 514-519) & (100-299) or (300, A01-Z99) or (400-999)", Order = 93)]
        public System.Nullable<System.Int32> PCT0100006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100007", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Micronesian (520-529, 531-541) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Micronesian (520-529, 531-541) & (100-299) or (300, A01-Z99) or (400-999):", Order = 94)]
        public System.Nullable<System.Int32> PCT0100007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100008", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Guamanian or Chamorro (520-522) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Guamanian or Chamorro (520-522) & (100-299) or (300, A01-Z99) or (400-999)", Order = 95)]
        public System.Nullable<System.Int32> PCT0100008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100009", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Marshallese (532) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Marshallese (532) & (100-299) or (300, A01-Z99) or (400-999)", Order = 96)]
        public System.Nullable<System.Int32> PCT0100009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100010", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Micronesian (523-529, 531, 533-541)  & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Other Micronesian (523-529, 531, 533-541)  & (100-299) or (300, A01-Z99) or (400-999)", Order = 97)]
        public System.Nullable<System.Int32> PCT0100010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100011", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Melanesian (542-546) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Melanesian (542-546) & (100-299) or (300, A01-Z99) or (400-999):", Order = 98)]
        public System.Nullable<System.Int32> PCT0100011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100012", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Fijian (542) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Fijian (542) & (100-299) or (300, A01-Z99) or (400-999)", Order = 99)]
        public System.Nullable<System.Int32> PCT0100012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100013", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Melanesian (543-546) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Other Melanesian (543-546) & (100-299) or (300, A01-Z99) or (400-999)", Order = 100)]
        public System.Nullable<System.Int32> PCT0100013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100014", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Pacific Islander, not specified (530, 547-599) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Other Pacific Islander, not specified (530, 547-599) & (100-299) or (300, A01-Z99) or (400-999)", Order = 101)]
        public System.Nullable<System.Int32> PCT0100014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100015", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 102)]
        public System.Nullable<System.Int32> PCT0100015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100016", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 103)]
        public System.Nullable<System.Int32> PCT0100016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100017", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 104)]
        public System.Nullable<System.Int32> PCT0100017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100018", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 105)]
        public System.Nullable<System.Int32> PCT0100018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100019", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 106)]
        public System.Nullable<System.Int32> PCT0100019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100020", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 107)]
        public System.Nullable<System.Int32> PCT0100020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100021", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 108)]
        public System.Nullable<System.Int32> PCT0100021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100022", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 109)]
        public System.Nullable<System.Int32> PCT0100022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100023", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 110)]
        public System.Nullable<System.Int32> PCT0100023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100024", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 111)]
        public System.Nullable<System.Int32> PCT0100024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100025", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 112)]
        public System.Nullable<System.Int32> PCT0100025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100026", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Households with no people under 18 years:", ShortName = "Households with no people under 18 years:", Order = 113)]
        public System.Nullable<System.Int32> PCT0100026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100027", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 114)]
        public System.Nullable<System.Int32> PCT0100027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100028", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family", ShortName = "Husband-wife family", Order = 115)]
        public System.Nullable<System.Int32> PCT0100028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100029", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other family:", ShortName = "Other family:", Order = 116)]
        public System.Nullable<System.Int32> PCT0100029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100030", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present", ShortName = "Male householder, no wife present", Order = 117)]
        public System.Nullable<System.Int32> PCT0100030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100031", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder, no husband present", ShortName = "Female householder, no husband present", Order = 118)]
        public System.Nullable<System.Int32> PCT0100031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100032", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households:", ShortName = "Nonfamily households:", Order = 119)]
        public System.Nullable<System.Int32> PCT0100032 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100033", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder", ShortName = "Male householder", Order = 120)]
        public System.Nullable<System.Int32> PCT0100033 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100034", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder", ShortName = "Female householder", Order = 121)]
        public System.Nullable<System.Int32> PCT0100034 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110001", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 122)]
        public System.Nullable<System.Int32> PCT0110001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110002", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not Hispanic or Latino (001-199, 300-999)", ShortName = "Not Hispanic or Latino (001-199, 300-999)", Order = 123)]
        public System.Nullable<System.Int32> PCT0110002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110003", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hispanic or Latino (200-299):", ShortName = "Hispanic or Latino (200-299):", Order = 124)]
        public System.Nullable<System.Int32> PCT0110003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110004", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Mexican (210-220)", ShortName = "Mexican (210-220)", Order = 125)]
        public System.Nullable<System.Int32> PCT0110004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110005", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Puerto Rican (260-269)", ShortName = "Puerto Rican (260-269)", Order = 126)]
        public System.Nullable<System.Int32> PCT0110005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110006", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Cuban (270-274)", ShortName = "Cuban (270-274)", Order = 127)]
        public System.Nullable<System.Int32> PCT0110006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110007", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Dominican (275-279)", ShortName = "Dominican (275-279)", Order = 128)]
        public System.Nullable<System.Int32> PCT0110007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110008", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Central American (excluding Mexican) (221-230):", ShortName = "Central American (excluding Mexican) (221-230):", Order = 129)]
        public System.Nullable<System.Int32> PCT0110008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110009", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Costa Rican (221)", ShortName = "Costa Rican (221)", Order = 130)]
        public System.Nullable<System.Int32> PCT0110009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110010", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Guatemalan (222)", ShortName = "Guatemalan (222)", Order = 131)]
        public System.Nullable<System.Int32> PCT0110010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110011", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Honduran (223)", ShortName = "Honduran (223)", Order = 132)]
        public System.Nullable<System.Int32> PCT0110011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110012", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nicaraguan (224)", ShortName = "Nicaraguan (224)", Order = 133)]
        public System.Nullable<System.Int32> PCT0110012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110013", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Panamanian (225)", ShortName = "Panamanian (225)", Order = 134)]
        public System.Nullable<System.Int32> PCT0110013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110014", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Salvadoran (226)", ShortName = "Salvadoran (226)", Order = 135)]
        public System.Nullable<System.Int32> PCT0110014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110015", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Central American (227-230)", ShortName = "Other Central American (227-230)", Order = 136)]
        public System.Nullable<System.Int32> PCT0110015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110016", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "South American (231-249):", ShortName = "South American (231-249):", Order = 137)]
        public System.Nullable<System.Int32> PCT0110016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110017", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Argentinean (231)", ShortName = "Argentinean (231)", Order = 138)]
        public System.Nullable<System.Int32> PCT0110017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110018", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Bolivian (232)", ShortName = "Bolivian (232)", Order = 139)]
        public System.Nullable<System.Int32> PCT0110018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110019", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Chilean (233)", ShortName = "Chilean (233)", Order = 140)]
        public System.Nullable<System.Int32> PCT0110019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110020", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Colombian (234)", ShortName = "Colombian (234)", Order = 141)]
        public System.Nullable<System.Int32> PCT0110020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110021", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Ecuadorian (235)", ShortName = "Ecuadorian (235)", Order = 142)]
        public System.Nullable<System.Int32> PCT0110021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110022", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Paraguayan (236)", ShortName = "Paraguayan (236)", Order = 143)]
        public System.Nullable<System.Int32> PCT0110022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110023", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Peruvian (237)", ShortName = "Peruvian (237)", Order = 144)]
        public System.Nullable<System.Int32> PCT0110023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110024", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Uruguayan (238)", ShortName = "Uruguayan (238)", Order = 145)]
        public System.Nullable<System.Int32> PCT0110024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110025", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Venezuelan (239)", ShortName = "Venezuelan (239)", Order = 146)]
        public System.Nullable<System.Int32> PCT0110025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110026", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other South American (240-249)", ShortName = "Other South American (240-249)", Order = 147)]
        public System.Nullable<System.Int32> PCT0110026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110027", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Hispanic or Latino (200-209, 250-259, 280-299):", ShortName = "Other Hispanic or Latino (200-209, 250-259, 280-299):", Order = 148)]
        public System.Nullable<System.Int32> PCT0110027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110028", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spaniard (200-209)", ShortName = "Spaniard (200-209)", Order = 149)]
        public System.Nullable<System.Int32> PCT0110028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110029", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spanish (282)", ShortName = "Spanish (282)", Order = 150)]
        public System.Nullable<System.Int32> PCT0110029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110030", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spanish American (286)", ShortName = "Spanish American (286)", Order = 151)]
        public System.Nullable<System.Int32> PCT0110030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110031", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "All other Hispanic or Latino (250-259, 280-281, 283-285, 287-299)", ShortName = "All other Hispanic or Latino (250-259, 280-281, 283-285, 287-299)", Order = 152)]
        public System.Nullable<System.Int32> PCT0110031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120001", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 153)]
        public System.Nullable<System.Int32> PCT0120001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120002", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 154)]
        public System.Nullable<System.Int32> PCT0120002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120003", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 1 year", ShortName = "Under 1 year", Order = 155)]
        public System.Nullable<System.Int32> PCT0120003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120004", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1 year", ShortName = "1 year", Order = 156)]
        public System.Nullable<System.Int32> PCT0120004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120005", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2 years", ShortName = "2 years", Order = 157)]
        public System.Nullable<System.Int32> PCT0120005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120006", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 years", ShortName = "3 years", Order = 158)]
        public System.Nullable<System.Int32> PCT0120006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120007", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "4 years", ShortName = "4 years", Order = 159)]
        public System.Nullable<System.Int32> PCT0120007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120008", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 160)]
        public System.Nullable<System.Int32> PCT0120008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120009", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 years", ShortName = "6 years", Order = 161)]
        public System.Nullable<System.Int32> PCT0120009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120010", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "7 years", ShortName = "7 years", Order = 162)]
        public System.Nullable<System.Int32> PCT0120010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120011", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "8 years", ShortName = "8 years", Order = 163)]
        public System.Nullable<System.Int32> PCT0120011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120012", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "9 years", ShortName = "9 years", Order = 164)]
        public System.Nullable<System.Int32> PCT0120012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120013", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 years", ShortName = "10 years", Order = 165)]
        public System.Nullable<System.Int32> PCT0120013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120014", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "11 years", ShortName = "11 years", Order = 166)]
        public System.Nullable<System.Int32> PCT0120014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120015", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 years", ShortName = "12 years", Order = 167)]
        public System.Nullable<System.Int32> PCT0120015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120016", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "13 years", ShortName = "13 years", Order = 168)]
        public System.Nullable<System.Int32> PCT0120016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120017", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "14 years", ShortName = "14 years", Order = 169)]
        public System.Nullable<System.Int32> PCT0120017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120018", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 years", ShortName = "15 years", Order = 170)]
        public System.Nullable<System.Int32> PCT0120018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120019", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "16 years", ShortName = "16 years", Order = 171)]
        public System.Nullable<System.Int32> PCT0120019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120020", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "17 years", ShortName = "17 years", Order = 172)]
        public System.Nullable<System.Int32> PCT0120020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0120021", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years", ShortName = "18 years", Order = 173)]
        public System.Nullable<System.Int32> PCT0120021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130001", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 174)]
        public System.Nullable<System.Int32> PCT0130001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130002", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 175)]
        public System.Nullable<System.Int32> PCT0130002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130003", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 5 years", ShortName = "Under 5 years", Order = 176)]
        public System.Nullable<System.Int32> PCT0130003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130004", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 to 9 years", ShortName = "5 to 9 years", Order = 177)]
        public System.Nullable<System.Int32> PCT0130004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130005", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "10 to 14 years", ShortName = "10 to 14 years", Order = 178)]
        public System.Nullable<System.Int32> PCT0130005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130006", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 179)]
        public System.Nullable<System.Int32> PCT0130006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130007", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 and 19 years", ShortName = "18 and 19 years", Order = 180)]
        public System.Nullable<System.Int32> PCT0130007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130008", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "20 years", ShortName = "20 years", Order = 181)]
        public System.Nullable<System.Int32> PCT0130008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130009", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "21 years", ShortName = "21 years", Order = 182)]
        public System.Nullable<System.Int32> PCT0130009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130010", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "22 to 24 years", ShortName = "22 to 24 years", Order = 183)]
        public System.Nullable<System.Int32> PCT0130010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130011", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "25 to 29 years", ShortName = "25 to 29 years", Order = 184)]
        public System.Nullable<System.Int32> PCT0130011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130012", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "30 to 34 years", ShortName = "30 to 34 years", Order = 185)]
        public System.Nullable<System.Int32> PCT0130012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130013", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "35 to 39 years", ShortName = "35 to 39 years", Order = 186)]
        public System.Nullable<System.Int32> PCT0130013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130014", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "40 to 44 years", ShortName = "40 to 44 years", Order = 187)]
        public System.Nullable<System.Int32> PCT0130014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0130015", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "45 to 49 years", ShortName = "45 to 49 years", Order = 188)]
        public System.Nullable<System.Int32> PCT0130015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140001", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 189)]
        public System.Nullable<System.Int32> PCT0140001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140002", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Household has three or more generations", ShortName = "Household has three or more generations", Order = 190)]
        public System.Nullable<System.Int32> PCT0140002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140003", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Household does not have three or more generations", ShortName = "Household does not have three or more generations", Order = 191)]
        public System.Nullable<System.Int32> PCT0140003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140004", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-or-more-person household:", ShortName = "2-or-more-person household:", Order = 192)]
        public System.Nullable<System.Int32> PCT0140004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140005", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households", ShortName = "Family households", Order = 193)]
        public System.Nullable<System.Int32> PCT0140005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140006", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households", ShortName = "Nonfamily households", Order = 194)]
        public System.Nullable<System.Int32> PCT0140006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140007", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Households with no people 60 years and over:", ShortName = "Households with no people 60 years and over:", Order = 195)]
        public System.Nullable<System.Int32> PCT0140007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140008", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "1-person household", ShortName = "1-person household", Order = 196)]
        public System.Nullable<System.Int32> PCT0140008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140009", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "2-or-more-person household:", ShortName = "2-or-more-person household:", Order = 197)]
        public System.Nullable<System.Int32> PCT0140009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140010", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households", ShortName = "Family households", Order = 198)]
        public System.Nullable<System.Int32> PCT0140010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0140011", Order = 199)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonfamily households", ShortName = "Nonfamily households", Order = 199)]
        public System.Nullable<System.Int32> PCT0140011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150001", Order = 200)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 200)]
        public System.Nullable<System.Int32> PCT0150001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150002", Order = 201)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife households:", ShortName = "Husband-wife households:", Order = 201)]
        public System.Nullable<System.Int32> PCT0150002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150003", Order = 202)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 202)]
        public System.Nullable<System.Int32> PCT0150003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150004", Order = 203)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 203)]
        public System.Nullable<System.Int32> PCT0150004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150005", Order = 204)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 204)]
        public System.Nullable<System.Int32> PCT0150005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150006", Order = 205)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 205)]
        public System.Nullable<System.Int32> PCT0150006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150007", Order = 206)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 206)]
        public System.Nullable<System.Int32> PCT0150007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150008", Order = 207)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 207)]
        public System.Nullable<System.Int32> PCT0150008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150009", Order = 208)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 208)]
        public System.Nullable<System.Int32> PCT0150009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150010", Order = 209)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 209)]
        public System.Nullable<System.Int32> PCT0150010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0150011", Order = 210)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 210)]
        public System.Nullable<System.Int32> PCT0150011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160001", Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 211)]
        public System.Nullable<System.Int32> PCT0160001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160002", Order = 212)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Family households:", ShortName = "Family households:", Order = 212)]
        public System.Nullable<System.Int32> PCT0160002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160003", Order = 213)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 213)]
        public System.Nullable<System.Int32> PCT0160003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160004", Order = 214)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With no children under 18 years", ShortName = "With no children under 18 years", Order = 214)]
        public System.Nullable<System.Int32> PCT0160004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160005", Order = 215)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With one child under 18 years", ShortName = "With one child under 18 years", Order = 215)]
        public System.Nullable<System.Int32> PCT0160005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160006", Order = 216)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With two children under 18 years", ShortName = "With two children under 18 years", Order = 216)]
        public System.Nullable<System.Int32> PCT0160006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160007", Order = 217)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With three children under 18 years", ShortName = "With three children under 18 years", Order = 217)]
        public System.Nullable<System.Int32> PCT0160007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160008", Order = 218)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With four or more children under 18 years", ShortName = "With four or more children under 18 years", Order = 218)]
        public System.Nullable<System.Int32> PCT0160008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160009", Order = 219)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 219)]
        public System.Nullable<System.Int32> PCT0160009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160010", Order = 220)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With no children under 18 years", ShortName = "With no children under 18 years", Order = 220)]
        public System.Nullable<System.Int32> PCT0160010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0160011", Order = 221)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With one child under 18 years", ShortName = "With one child under 18 years", Order = 221)]
        public System.Nullable<System.Int32> PCT0160011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0170001", Order = 222)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 222)]
        public System.Nullable<System.Int32> PCT0170001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0170002", Order = 223)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried partner of householder present:", ShortName = "Unmarried partner of householder present:", Order = 223)]
        public System.Nullable<System.Int32> PCT0170002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0170003", Order = 224)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 224)]
        public System.Nullable<System.Int32> PCT0170003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0180001", Order = 225)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 225)]
        public System.Nullable<System.Int32> PCT0180001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0180002", Order = 226)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 226)]
        public System.Nullable<System.Int32> PCT0180002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0180003", Order = 227)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone:", ShortName = "Living alone:", Order = 227)]
        public System.Nullable<System.Int32> PCT0180003 { get; set; }
        #endregion Properties

        #region Constructors
        public SF2_Segment_04(string csvLine) : base(csvLine) {}

        public SF2_Segment_04(string[] values) : base(values) {}

        public SF2_Segment_04(OleDbDataReader reader, CensusFileType fileType)
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
                PCT0050001 = (System.Nullable<System.Int32>)reader[5];
            }
            if(reader[6] != DBNull.Value)
            {
                PCT0050002 = (System.Nullable<System.Int32>)reader[6];
            }
            if(reader[7] != DBNull.Value)
            {
                PCT0050003 = (System.Nullable<System.Int32>)reader[7];
            }
            if(reader[8] != DBNull.Value)
            {
                PCT0050004 = (System.Nullable<System.Int32>)reader[8];
            }
            if(reader[9] != DBNull.Value)
            {
                PCT0050005 = (System.Nullable<System.Int32>)reader[9];
            }
            if(reader[10] != DBNull.Value)
            {
                PCT0050006 = (System.Nullable<System.Int32>)reader[10];
            }
            if(reader[11] != DBNull.Value)
            {
                PCT0050007 = (System.Nullable<System.Int32>)reader[11];
            }
            if(reader[12] != DBNull.Value)
            {
                PCT0050008 = (System.Nullable<System.Int32>)reader[12];
            }
            if(reader[13] != DBNull.Value)
            {
                PCT0050009 = (System.Nullable<System.Int32>)reader[13];
            }
            if(reader[14] != DBNull.Value)
            {
                PCT0050010 = (System.Nullable<System.Int32>)reader[14];
            }
            if(reader[15] != DBNull.Value)
            {
                PCT0050011 = (System.Nullable<System.Int32>)reader[15];
            }
            if(reader[16] != DBNull.Value)
            {
                PCT0050012 = (System.Nullable<System.Int32>)reader[16];
            }
            if(reader[17] != DBNull.Value)
            {
                PCT0050013 = (System.Nullable<System.Int32>)reader[17];
            }
            if(reader[18] != DBNull.Value)
            {
                PCT0050014 = (System.Nullable<System.Int32>)reader[18];
            }
            if(reader[19] != DBNull.Value)
            {
                PCT0050015 = (System.Nullable<System.Int32>)reader[19];
            }
            if(reader[20] != DBNull.Value)
            {
                PCT0050016 = (System.Nullable<System.Int32>)reader[20];
            }
            if(reader[21] != DBNull.Value)
            {
                PCT0050017 = (System.Nullable<System.Int32>)reader[21];
            }
            if(reader[22] != DBNull.Value)
            {
                PCT0050018 = (System.Nullable<System.Int32>)reader[22];
            }
            if(reader[23] != DBNull.Value)
            {
                PCT0050019 = (System.Nullable<System.Int32>)reader[23];
            }
            if(reader[24] != DBNull.Value)
            {
                PCT0050020 = (System.Nullable<System.Int32>)reader[24];
            }
            if(reader[25] != DBNull.Value)
            {
                PCT0050021 = (System.Nullable<System.Int32>)reader[25];
            }
            if(reader[26] != DBNull.Value)
            {
                PCT0050022 = (System.Nullable<System.Int32>)reader[26];
            }
            if(reader[27] != DBNull.Value)
            {
                PCT0050023 = (System.Nullable<System.Int32>)reader[27];
            }
            if(reader[28] != DBNull.Value)
            {
                PCT0050024 = (System.Nullable<System.Int32>)reader[28];
            }
            if(reader[29] != DBNull.Value)
            {
                PCT0050025 = (System.Nullable<System.Int32>)reader[29];
            }
            if(reader[30] != DBNull.Value)
            {
                PCT0050026 = (System.Nullable<System.Int32>)reader[30];
            }
            if(reader[31] != DBNull.Value)
            {
                PCT0050027 = (System.Nullable<System.Int32>)reader[31];
            }
            if(reader[32] != DBNull.Value)
            {
                PCT0050028 = (System.Nullable<System.Int32>)reader[32];
            }
            if(reader[33] != DBNull.Value)
            {
                PCT0050029 = (System.Nullable<System.Int32>)reader[33];
            }
            if(reader[34] != DBNull.Value)
            {
                PCT0050030 = (System.Nullable<System.Int32>)reader[34];
            }
            if(reader[35] != DBNull.Value)
            {
                PCT0050031 = (System.Nullable<System.Int32>)reader[35];
            }
            if(reader[36] != DBNull.Value)
            {
                PCT0050032 = (System.Nullable<System.Int32>)reader[36];
            }
            if(reader[37] != DBNull.Value)
            {
                PCT0050033 = (System.Nullable<System.Int32>)reader[37];
            }
            if(reader[38] != DBNull.Value)
            {
                PCT0050034 = (System.Nullable<System.Int32>)reader[38];
            }
            if(reader[39] != DBNull.Value)
            {
                PCT0050035 = (System.Nullable<System.Int32>)reader[39];
            }
            if(reader[40] != DBNull.Value)
            {
                PCT0050036 = (System.Nullable<System.Int32>)reader[40];
            }
            if(reader[41] != DBNull.Value)
            {
                PCT0050037 = (System.Nullable<System.Int32>)reader[41];
            }
            if(reader[42] != DBNull.Value)
            {
                PCT0050038 = (System.Nullable<System.Int32>)reader[42];
            }
            if(reader[43] != DBNull.Value)
            {
                PCT0050039 = (System.Nullable<System.Int32>)reader[43];
            }
            if(reader[44] != DBNull.Value)
            {
                PCT0050040 = (System.Nullable<System.Int32>)reader[44];
            }
            if(reader[45] != DBNull.Value)
            {
                PCT0050041 = (System.Nullable<System.Int32>)reader[45];
            }
            if(reader[46] != DBNull.Value)
            {
                PCT0050042 = (System.Nullable<System.Int32>)reader[46];
            }
            if(reader[47] != DBNull.Value)
            {
                PCT0050043 = (System.Nullable<System.Int32>)reader[47];
            }
            if(reader[48] != DBNull.Value)
            {
                PCT0050044 = (System.Nullable<System.Int32>)reader[48];
            }
            if(reader[49] != DBNull.Value)
            {
                PCT0050045 = (System.Nullable<System.Int32>)reader[49];
            }
            if(reader[50] != DBNull.Value)
            {
                PCT0050046 = (System.Nullable<System.Int32>)reader[50];
            }
            if(reader[51] != DBNull.Value)
            {
                PCT0050047 = (System.Nullable<System.Int32>)reader[51];
            }
            if(reader[52] != DBNull.Value)
            {
                PCT0050048 = (System.Nullable<System.Int32>)reader[52];
            }
            if(reader[53] != DBNull.Value)
            {
                PCT0050049 = (System.Nullable<System.Int32>)reader[53];
            }
            if(reader[54] != DBNull.Value)
            {
                PCT0060001 = (System.Nullable<System.Int32>)reader[54];
            }
            if(reader[55] != DBNull.Value)
            {
                PCT0060002 = (System.Nullable<System.Int32>)reader[55];
            }
            if(reader[56] != DBNull.Value)
            {
                PCT0060003 = (System.Nullable<System.Int32>)reader[56];
            }
            if(reader[57] != DBNull.Value)
            {
                PCT0070001 = (System.Nullable<System.Double>)reader[57];
            }
            if(reader[58] != DBNull.Value)
            {
                PCT0070002 = (System.Nullable<System.Double>)reader[58];
            }
            if(reader[59] != DBNull.Value)
            {
                PCT0070003 = (System.Nullable<System.Double>)reader[59];
            }
            if(reader[60] != DBNull.Value)
            {
                PCT0080001 = (System.Nullable<System.Int32>)reader[60];
            }
            if(reader[61] != DBNull.Value)
            {
                PCT0080002 = (System.Nullable<System.Int32>)reader[61];
            }
            if(reader[62] != DBNull.Value)
            {
                PCT0080003 = (System.Nullable<System.Int32>)reader[62];
            }
            if(reader[63] != DBNull.Value)
            {
                PCT0080004 = (System.Nullable<System.Int32>)reader[63];
            }
            if(reader[64] != DBNull.Value)
            {
                PCT0080005 = (System.Nullable<System.Int32>)reader[64];
            }
            if(reader[65] != DBNull.Value)
            {
                PCT0080006 = (System.Nullable<System.Int32>)reader[65];
            }
            if(reader[66] != DBNull.Value)
            {
                PCT0080007 = (System.Nullable<System.Int32>)reader[66];
            }
            if(reader[67] != DBNull.Value)
            {
                PCT0080008 = (System.Nullable<System.Int32>)reader[67];
            }
            if(reader[68] != DBNull.Value)
            {
                PCT0080009 = (System.Nullable<System.Int32>)reader[68];
            }
            if(reader[69] != DBNull.Value)
            {
                PCT0090001 = (System.Nullable<System.Int32>)reader[69];
            }
            if(reader[70] != DBNull.Value)
            {
                PCT0090002 = (System.Nullable<System.Int32>)reader[70];
            }
            if(reader[71] != DBNull.Value)
            {
                PCT0090003 = (System.Nullable<System.Int32>)reader[71];
            }
            if(reader[72] != DBNull.Value)
            {
                PCT0090004 = (System.Nullable<System.Int32>)reader[72];
            }
            if(reader[73] != DBNull.Value)
            {
                PCT0090005 = (System.Nullable<System.Int32>)reader[73];
            }
            if(reader[74] != DBNull.Value)
            {
                PCT0090006 = (System.Nullable<System.Int32>)reader[74];
            }
            if(reader[75] != DBNull.Value)
            {
                PCT0090007 = (System.Nullable<System.Int32>)reader[75];
            }
            if(reader[76] != DBNull.Value)
            {
                PCT0090008 = (System.Nullable<System.Int32>)reader[76];
            }
            if(reader[77] != DBNull.Value)
            {
                PCT0090009 = (System.Nullable<System.Int32>)reader[77];
            }
            if(reader[78] != DBNull.Value)
            {
                PCT0090010 = (System.Nullable<System.Int32>)reader[78];
            }
            if(reader[79] != DBNull.Value)
            {
                PCT0090011 = (System.Nullable<System.Int32>)reader[79];
            }
            if(reader[80] != DBNull.Value)
            {
                PCT0090012 = (System.Nullable<System.Int32>)reader[80];
            }
            if(reader[81] != DBNull.Value)
            {
                PCT0090013 = (System.Nullable<System.Int32>)reader[81];
            }
            if(reader[82] != DBNull.Value)
            {
                PCT0090014 = (System.Nullable<System.Int32>)reader[82];
            }
            if(reader[83] != DBNull.Value)
            {
                PCT0090015 = (System.Nullable<System.Int32>)reader[83];
            }
            if(reader[84] != DBNull.Value)
            {
                PCT0090016 = (System.Nullable<System.Int32>)reader[84];
            }
            if(reader[85] != DBNull.Value)
            {
                PCT0090017 = (System.Nullable<System.Int32>)reader[85];
            }
            if(reader[86] != DBNull.Value)
            {
                PCT0090018 = (System.Nullable<System.Int32>)reader[86];
            }
            if(reader[87] != DBNull.Value)
            {
                PCT0090019 = (System.Nullable<System.Int32>)reader[87];
            }
            if(reader[88] != DBNull.Value)
            {
                PCT0100001 = (System.Nullable<System.Int32>)reader[88];
            }
            if(reader[89] != DBNull.Value)
            {
                PCT0100002 = (System.Nullable<System.Int32>)reader[89];
            }
            if(reader[90] != DBNull.Value)
            {
                PCT0100003 = (System.Nullable<System.Int32>)reader[90];
            }
            if(reader[91] != DBNull.Value)
            {
                PCT0100004 = (System.Nullable<System.Int32>)reader[91];
            }
            if(reader[92] != DBNull.Value)
            {
                PCT0100005 = (System.Nullable<System.Int32>)reader[92];
            }
            if(reader[93] != DBNull.Value)
            {
                PCT0100006 = (System.Nullable<System.Int32>)reader[93];
            }
            if(reader[94] != DBNull.Value)
            {
                PCT0100007 = (System.Nullable<System.Int32>)reader[94];
            }
            if(reader[95] != DBNull.Value)
            {
                PCT0100008 = (System.Nullable<System.Int32>)reader[95];
            }
            if(reader[96] != DBNull.Value)
            {
                PCT0100009 = (System.Nullable<System.Int32>)reader[96];
            }
            if(reader[97] != DBNull.Value)
            {
                PCT0100010 = (System.Nullable<System.Int32>)reader[97];
            }
            if(reader[98] != DBNull.Value)
            {
                PCT0100011 = (System.Nullable<System.Int32>)reader[98];
            }
            if(reader[99] != DBNull.Value)
            {
                PCT0100012 = (System.Nullable<System.Int32>)reader[99];
            }
            if(reader[100] != DBNull.Value)
            {
                PCT0100013 = (System.Nullable<System.Int32>)reader[100];
            }
            if(reader[101] != DBNull.Value)
            {
                PCT0100014 = (System.Nullable<System.Int32>)reader[101];
            }
            if(reader[102] != DBNull.Value)
            {
                PCT0100015 = (System.Nullable<System.Int32>)reader[102];
            }
            if(reader[103] != DBNull.Value)
            {
                PCT0100016 = (System.Nullable<System.Int32>)reader[103];
            }
            if(reader[104] != DBNull.Value)
            {
                PCT0100017 = (System.Nullable<System.Int32>)reader[104];
            }
            if(reader[105] != DBNull.Value)
            {
                PCT0100018 = (System.Nullable<System.Int32>)reader[105];
            }
            if(reader[106] != DBNull.Value)
            {
                PCT0100019 = (System.Nullable<System.Int32>)reader[106];
            }
            if(reader[107] != DBNull.Value)
            {
                PCT0100020 = (System.Nullable<System.Int32>)reader[107];
            }
            if(reader[108] != DBNull.Value)
            {
                PCT0100021 = (System.Nullable<System.Int32>)reader[108];
            }
            if(reader[109] != DBNull.Value)
            {
                PCT0100022 = (System.Nullable<System.Int32>)reader[109];
            }
            if(reader[110] != DBNull.Value)
            {
                PCT0100023 = (System.Nullable<System.Int32>)reader[110];
            }
            if(reader[111] != DBNull.Value)
            {
                PCT0100024 = (System.Nullable<System.Int32>)reader[111];
            }
            if(reader[112] != DBNull.Value)
            {
                PCT0100025 = (System.Nullable<System.Int32>)reader[112];
            }
            if(reader[113] != DBNull.Value)
            {
                PCT0100026 = (System.Nullable<System.Int32>)reader[113];
            }
            if(reader[114] != DBNull.Value)
            {
                PCT0100027 = (System.Nullable<System.Int32>)reader[114];
            }
            if(reader[115] != DBNull.Value)
            {
                PCT0100028 = (System.Nullable<System.Int32>)reader[115];
            }
            if(reader[116] != DBNull.Value)
            {
                PCT0100029 = (System.Nullable<System.Int32>)reader[116];
            }
            if(reader[117] != DBNull.Value)
            {
                PCT0100030 = (System.Nullable<System.Int32>)reader[117];
            }
            if(reader[118] != DBNull.Value)
            {
                PCT0100031 = (System.Nullable<System.Int32>)reader[118];
            }
            if(reader[119] != DBNull.Value)
            {
                PCT0100032 = (System.Nullable<System.Int32>)reader[119];
            }
            if(reader[120] != DBNull.Value)
            {
                PCT0100033 = (System.Nullable<System.Int32>)reader[120];
            }
            if(reader[121] != DBNull.Value)
            {
                PCT0100034 = (System.Nullable<System.Int32>)reader[121];
            }
            if(reader[122] != DBNull.Value)
            {
                PCT0110001 = (System.Nullable<System.Int32>)reader[122];
            }
            if(reader[123] != DBNull.Value)
            {
                PCT0110002 = (System.Nullable<System.Int32>)reader[123];
            }
            if(reader[124] != DBNull.Value)
            {
                PCT0110003 = (System.Nullable<System.Int32>)reader[124];
            }
            if(reader[125] != DBNull.Value)
            {
                PCT0110004 = (System.Nullable<System.Int32>)reader[125];
            }
            if(reader[126] != DBNull.Value)
            {
                PCT0110005 = (System.Nullable<System.Int32>)reader[126];
            }
            if(reader[127] != DBNull.Value)
            {
                PCT0110006 = (System.Nullable<System.Int32>)reader[127];
            }
            if(reader[128] != DBNull.Value)
            {
                PCT0110007 = (System.Nullable<System.Int32>)reader[128];
            }
            if(reader[129] != DBNull.Value)
            {
                PCT0110008 = (System.Nullable<System.Int32>)reader[129];
            }
            if(reader[130] != DBNull.Value)
            {
                PCT0110009 = (System.Nullable<System.Int32>)reader[130];
            }
            if(reader[131] != DBNull.Value)
            {
                PCT0110010 = (System.Nullable<System.Int32>)reader[131];
            }
            if(reader[132] != DBNull.Value)
            {
                PCT0110011 = (System.Nullable<System.Int32>)reader[132];
            }
            if(reader[133] != DBNull.Value)
            {
                PCT0110012 = (System.Nullable<System.Int32>)reader[133];
            }
            if(reader[134] != DBNull.Value)
            {
                PCT0110013 = (System.Nullable<System.Int32>)reader[134];
            }
            if(reader[135] != DBNull.Value)
            {
                PCT0110014 = (System.Nullable<System.Int32>)reader[135];
            }
            if(reader[136] != DBNull.Value)
            {
                PCT0110015 = (System.Nullable<System.Int32>)reader[136];
            }
            if(reader[137] != DBNull.Value)
            {
                PCT0110016 = (System.Nullable<System.Int32>)reader[137];
            }
            if(reader[138] != DBNull.Value)
            {
                PCT0110017 = (System.Nullable<System.Int32>)reader[138];
            }
            if(reader[139] != DBNull.Value)
            {
                PCT0110018 = (System.Nullable<System.Int32>)reader[139];
            }
            if(reader[140] != DBNull.Value)
            {
                PCT0110019 = (System.Nullable<System.Int32>)reader[140];
            }
            if(reader[141] != DBNull.Value)
            {
                PCT0110020 = (System.Nullable<System.Int32>)reader[141];
            }
            if(reader[142] != DBNull.Value)
            {
                PCT0110021 = (System.Nullable<System.Int32>)reader[142];
            }
            if(reader[143] != DBNull.Value)
            {
                PCT0110022 = (System.Nullable<System.Int32>)reader[143];
            }
            if(reader[144] != DBNull.Value)
            {
                PCT0110023 = (System.Nullable<System.Int32>)reader[144];
            }
            if(reader[145] != DBNull.Value)
            {
                PCT0110024 = (System.Nullable<System.Int32>)reader[145];
            }
            if(reader[146] != DBNull.Value)
            {
                PCT0110025 = (System.Nullable<System.Int32>)reader[146];
            }
            if(reader[147] != DBNull.Value)
            {
                PCT0110026 = (System.Nullable<System.Int32>)reader[147];
            }
            if(reader[148] != DBNull.Value)
            {
                PCT0110027 = (System.Nullable<System.Int32>)reader[148];
            }
            if(reader[149] != DBNull.Value)
            {
                PCT0110028 = (System.Nullable<System.Int32>)reader[149];
            }
            if(reader[150] != DBNull.Value)
            {
                PCT0110029 = (System.Nullable<System.Int32>)reader[150];
            }
            if(reader[151] != DBNull.Value)
            {
                PCT0110030 = (System.Nullable<System.Int32>)reader[151];
            }
            if(reader[152] != DBNull.Value)
            {
                PCT0110031 = (System.Nullable<System.Int32>)reader[152];
            }
            if(reader[153] != DBNull.Value)
            {
                PCT0120001 = (System.Nullable<System.Int32>)reader[153];
            }
            if(reader[154] != DBNull.Value)
            {
                PCT0120002 = (System.Nullable<System.Int32>)reader[154];
            }
            if(reader[155] != DBNull.Value)
            {
                PCT0120003 = (System.Nullable<System.Int32>)reader[155];
            }
            if(reader[156] != DBNull.Value)
            {
                PCT0120004 = (System.Nullable<System.Int32>)reader[156];
            }
            if(reader[157] != DBNull.Value)
            {
                PCT0120005 = (System.Nullable<System.Int32>)reader[157];
            }
            if(reader[158] != DBNull.Value)
            {
                PCT0120006 = (System.Nullable<System.Int32>)reader[158];
            }
            if(reader[159] != DBNull.Value)
            {
                PCT0120007 = (System.Nullable<System.Int32>)reader[159];
            }
            if(reader[160] != DBNull.Value)
            {
                PCT0120008 = (System.Nullable<System.Int32>)reader[160];
            }
            if(reader[161] != DBNull.Value)
            {
                PCT0120009 = (System.Nullable<System.Int32>)reader[161];
            }
            if(reader[162] != DBNull.Value)
            {
                PCT0120010 = (System.Nullable<System.Int32>)reader[162];
            }
            if(reader[163] != DBNull.Value)
            {
                PCT0120011 = (System.Nullable<System.Int32>)reader[163];
            }
            if(reader[164] != DBNull.Value)
            {
                PCT0120012 = (System.Nullable<System.Int32>)reader[164];
            }
            if(reader[165] != DBNull.Value)
            {
                PCT0120013 = (System.Nullable<System.Int32>)reader[165];
            }
            if(reader[166] != DBNull.Value)
            {
                PCT0120014 = (System.Nullable<System.Int32>)reader[166];
            }
            if(reader[167] != DBNull.Value)
            {
                PCT0120015 = (System.Nullable<System.Int32>)reader[167];
            }
            if(reader[168] != DBNull.Value)
            {
                PCT0120016 = (System.Nullable<System.Int32>)reader[168];
            }
            if(reader[169] != DBNull.Value)
            {
                PCT0120017 = (System.Nullable<System.Int32>)reader[169];
            }
            if(reader[170] != DBNull.Value)
            {
                PCT0120018 = (System.Nullable<System.Int32>)reader[170];
            }
            if(reader[171] != DBNull.Value)
            {
                PCT0120019 = (System.Nullable<System.Int32>)reader[171];
            }
            if(reader[172] != DBNull.Value)
            {
                PCT0120020 = (System.Nullable<System.Int32>)reader[172];
            }
            if(reader[173] != DBNull.Value)
            {
                PCT0120021 = (System.Nullable<System.Int32>)reader[173];
            }
            if(reader[174] != DBNull.Value)
            {
                PCT0130001 = (System.Nullable<System.Int32>)reader[174];
            }
            if(reader[175] != DBNull.Value)
            {
                PCT0130002 = (System.Nullable<System.Int32>)reader[175];
            }
            if(reader[176] != DBNull.Value)
            {
                PCT0130003 = (System.Nullable<System.Int32>)reader[176];
            }
            if(reader[177] != DBNull.Value)
            {
                PCT0130004 = (System.Nullable<System.Int32>)reader[177];
            }
            if(reader[178] != DBNull.Value)
            {
                PCT0130005 = (System.Nullable<System.Int32>)reader[178];
            }
            if(reader[179] != DBNull.Value)
            {
                PCT0130006 = (System.Nullable<System.Int32>)reader[179];
            }
            if(reader[180] != DBNull.Value)
            {
                PCT0130007 = (System.Nullable<System.Int32>)reader[180];
            }
            if(reader[181] != DBNull.Value)
            {
                PCT0130008 = (System.Nullable<System.Int32>)reader[181];
            }
            if(reader[182] != DBNull.Value)
            {
                PCT0130009 = (System.Nullable<System.Int32>)reader[182];
            }
            if(reader[183] != DBNull.Value)
            {
                PCT0130010 = (System.Nullable<System.Int32>)reader[183];
            }
            if(reader[184] != DBNull.Value)
            {
                PCT0130011 = (System.Nullable<System.Int32>)reader[184];
            }
            if(reader[185] != DBNull.Value)
            {
                PCT0130012 = (System.Nullable<System.Int32>)reader[185];
            }
            if(reader[186] != DBNull.Value)
            {
                PCT0130013 = (System.Nullable<System.Int32>)reader[186];
            }
            if(reader[187] != DBNull.Value)
            {
                PCT0130014 = (System.Nullable<System.Int32>)reader[187];
            }
            if(reader[188] != DBNull.Value)
            {
                PCT0130015 = (System.Nullable<System.Int32>)reader[188];
            }
            if(reader[189] != DBNull.Value)
            {
                PCT0140001 = (System.Nullable<System.Int32>)reader[189];
            }
            if(reader[190] != DBNull.Value)
            {
                PCT0140002 = (System.Nullable<System.Int32>)reader[190];
            }
            if(reader[191] != DBNull.Value)
            {
                PCT0140003 = (System.Nullable<System.Int32>)reader[191];
            }
            if(reader[192] != DBNull.Value)
            {
                PCT0140004 = (System.Nullable<System.Int32>)reader[192];
            }
            if(reader[193] != DBNull.Value)
            {
                PCT0140005 = (System.Nullable<System.Int32>)reader[193];
            }
            if(reader[194] != DBNull.Value)
            {
                PCT0140006 = (System.Nullable<System.Int32>)reader[194];
            }
            if(reader[195] != DBNull.Value)
            {
                PCT0140007 = (System.Nullable<System.Int32>)reader[195];
            }
            if(reader[196] != DBNull.Value)
            {
                PCT0140008 = (System.Nullable<System.Int32>)reader[196];
            }
            if(reader[197] != DBNull.Value)
            {
                PCT0140009 = (System.Nullable<System.Int32>)reader[197];
            }
            if(reader[198] != DBNull.Value)
            {
                PCT0140010 = (System.Nullable<System.Int32>)reader[198];
            }
            if(reader[199] != DBNull.Value)
            {
                PCT0140011 = (System.Nullable<System.Int32>)reader[199];
            }
            if(reader[200] != DBNull.Value)
            {
                PCT0150001 = (System.Nullable<System.Int32>)reader[200];
            }
            if(reader[201] != DBNull.Value)
            {
                PCT0150002 = (System.Nullable<System.Int32>)reader[201];
            }
            if(reader[202] != DBNull.Value)
            {
                PCT0150003 = (System.Nullable<System.Int32>)reader[202];
            }
            if(reader[203] != DBNull.Value)
            {
                PCT0150004 = (System.Nullable<System.Int32>)reader[203];
            }
            if(reader[204] != DBNull.Value)
            {
                PCT0150005 = (System.Nullable<System.Int32>)reader[204];
            }
            if(reader[205] != DBNull.Value)
            {
                PCT0150006 = (System.Nullable<System.Int32>)reader[205];
            }
            if(reader[206] != DBNull.Value)
            {
                PCT0150007 = (System.Nullable<System.Int32>)reader[206];
            }
            if(reader[207] != DBNull.Value)
            {
                PCT0150008 = (System.Nullable<System.Int32>)reader[207];
            }
            if(reader[208] != DBNull.Value)
            {
                PCT0150009 = (System.Nullable<System.Int32>)reader[208];
            }
            if(reader[209] != DBNull.Value)
            {
                PCT0150010 = (System.Nullable<System.Int32>)reader[209];
            }
            if(reader[210] != DBNull.Value)
            {
                PCT0150011 = (System.Nullable<System.Int32>)reader[210];
            }
            if(reader[211] != DBNull.Value)
            {
                PCT0160001 = (System.Nullable<System.Int32>)reader[211];
            }
            if(reader[212] != DBNull.Value)
            {
                PCT0160002 = (System.Nullable<System.Int32>)reader[212];
            }
            if(reader[213] != DBNull.Value)
            {
                PCT0160003 = (System.Nullable<System.Int32>)reader[213];
            }
            if(reader[214] != DBNull.Value)
            {
                PCT0160004 = (System.Nullable<System.Int32>)reader[214];
            }
            if(reader[215] != DBNull.Value)
            {
                PCT0160005 = (System.Nullable<System.Int32>)reader[215];
            }
            if(reader[216] != DBNull.Value)
            {
                PCT0160006 = (System.Nullable<System.Int32>)reader[216];
            }
            if(reader[217] != DBNull.Value)
            {
                PCT0160007 = (System.Nullable<System.Int32>)reader[217];
            }
            if(reader[218] != DBNull.Value)
            {
                PCT0160008 = (System.Nullable<System.Int32>)reader[218];
            }
            if(reader[219] != DBNull.Value)
            {
                PCT0160009 = (System.Nullable<System.Int32>)reader[219];
            }
            if(reader[220] != DBNull.Value)
            {
                PCT0160010 = (System.Nullable<System.Int32>)reader[220];
            }
            if(reader[221] != DBNull.Value)
            {
                PCT0160011 = (System.Nullable<System.Int32>)reader[221];
            }
            if(reader[222] != DBNull.Value)
            {
                PCT0170001 = (System.Nullable<System.Int32>)reader[222];
            }
            if(reader[223] != DBNull.Value)
            {
                PCT0170002 = (System.Nullable<System.Int32>)reader[223];
            }
            if(reader[224] != DBNull.Value)
            {
                PCT0170003 = (System.Nullable<System.Int32>)reader[224];
            }
            if(reader[225] != DBNull.Value)
            {
                PCT0180001 = (System.Nullable<System.Int32>)reader[225];
            }
            if(reader[226] != DBNull.Value)
            {
                PCT0180002 = (System.Nullable<System.Int32>)reader[226];
            }
            if(reader[227] != DBNull.Value)
            {
                PCT0180003 = (System.Nullable<System.Int32>)reader[227];
            }
        }
        #endregion Constructors
    }
}