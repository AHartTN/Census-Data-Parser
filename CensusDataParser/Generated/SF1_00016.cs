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

    [Table("SF1_00016")]
    public partial class SF1_00016 : BaseModel
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
        [Column("PCT0090001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total Native Hawaiian and Other Pacific Islander categories tallied (500-599) & (500-599):", ShortName = "Total Native Hawaiian and Other Pacific Islander categories tallied (500-599) & (500-599):", Order = 5)]
        public System.Nullable<System.Int32> PCT0090001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Polynesian (500-519) & (500-599):", ShortName = "Polynesian (500-519) & (500-599):", Order = 6)]
        public System.Nullable<System.Int32> PCT0090002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian (500-503) & (500-599)", ShortName = "Native Hawaiian (500-503) & (500-599)", Order = 7)]
        public System.Nullable<System.Int32> PCT0090003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Samoan (510-511) & (500-599)", ShortName = "Samoan (510-511) & (500-599)", Order = 8)]
        public System.Nullable<System.Int32> PCT0090004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Tongan (513) & (500-599)", ShortName = "Tongan (513) & (500-599)", Order = 9)]
        public System.Nullable<System.Int32> PCT0090005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Polynesian (504-509, 512, 514-519) & (500-599)", ShortName = "Other Polynesian (504-509, 512, 514-519) & (500-599)", Order = 10)]
        public System.Nullable<System.Int32> PCT0090006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Micronesian (520-529, 531-541) & (500-599):", ShortName = "Micronesian (520-529, 531-541) & (500-599):", Order = 11)]
        public System.Nullable<System.Int32> PCT0090007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Guamanian or Chamorro (520-522) & (500-599)", ShortName = "Guamanian or Chamorro (520-522) & (500-599)", Order = 12)]
        public System.Nullable<System.Int32> PCT0090008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Marshallese (532) & (500-599)", ShortName = "Marshallese (532) & (500-599)", Order = 13)]
        public System.Nullable<System.Int32> PCT0090009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Micronesian (523-529, 531, 533-541) & (500-599)", ShortName = "Other Micronesian (523-529, 531, 533-541) & (500-599)", Order = 14)]
        public System.Nullable<System.Int32> PCT0090010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Melanesian (542-546) & (500-599):", ShortName = "Melanesian (542-546) & (500-599):", Order = 15)]
        public System.Nullable<System.Int32> PCT0090011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Fijian (542) & (500-599)", ShortName = "Fijian (542) & (500-599)", Order = 16)]
        public System.Nullable<System.Int32> PCT0090012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Melanesian (543-546) & (500-599)", ShortName = "Other Melanesian (543-546) & (500-599)", Order = 17)]
        public System.Nullable<System.Int32> PCT0090013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0090014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Pacific Islander, not specified (530, 547-599) & (500-599)", ShortName = "Other Pacific Islander, not specified (530, 547-599) & (500-599)", Order = 18)]
        public System.Nullable<System.Int32> PCT0090014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100001", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total Native Hawaiian and Other Pacific Islander categories tallied (500-599) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Total Native Hawaiian and Other Pacific Islander categories tallied (500-599) & (100-299) or (300, A01-Z99) or (400-999):", Order = 19)]
        public System.Nullable<System.Int32> PCT0100001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100002", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Polynesian (500-519) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Polynesian (500-519) & (100-299) or (300, A01-Z99) or (400-999):", Order = 20)]
        public System.Nullable<System.Int32> PCT0100002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100003", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Native Hawaiian (500-503) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Native Hawaiian (500-503) & (100-299) or (300, A01-Z99) or (400-999)", Order = 21)]
        public System.Nullable<System.Int32> PCT0100003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100004", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Samoan (510-511) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Samoan (510-511) & (100-299) or (300, A01-Z99) or (400-999)", Order = 22)]
        public System.Nullable<System.Int32> PCT0100004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100005", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Tongan (513) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Tongan (513) & (100-299) or (300, A01-Z99) or (400-999)", Order = 23)]
        public System.Nullable<System.Int32> PCT0100005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100006", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Polynesian (504-509, 512, 514-519) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Other Polynesian (504-509, 512, 514-519) & (100-299) or (300, A01-Z99) or (400-999)", Order = 24)]
        public System.Nullable<System.Int32> PCT0100006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100007", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Micronesian (520-529, 531-541) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Micronesian (520-529, 531-541) & (100-299) or (300, A01-Z99) or (400-999):", Order = 25)]
        public System.Nullable<System.Int32> PCT0100007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100008", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Guamanian or Chamorro (520-522) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Guamanian or Chamorro (520-522) & (100-299) or (300, A01-Z99) or (400-999)", Order = 26)]
        public System.Nullable<System.Int32> PCT0100008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100009", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Marshallese (532) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Marshallese (532) & (100-299) or (300, A01-Z99) or (400-999)", Order = 27)]
        public System.Nullable<System.Int32> PCT0100009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100010", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Micronesian (523-529, 531, 533-541)  & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Other Micronesian (523-529, 531, 533-541)  & (100-299) or (300, A01-Z99) or (400-999)", Order = 28)]
        public System.Nullable<System.Int32> PCT0100010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100011", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Melanesian (542-546) & (100-299) or (300, A01-Z99) or (400-999):", ShortName = "Melanesian (542-546) & (100-299) or (300, A01-Z99) or (400-999):", Order = 29)]
        public System.Nullable<System.Int32> PCT0100011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100012", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Fijian (542) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Fijian (542) & (100-299) or (300, A01-Z99) or (400-999)", Order = 30)]
        public System.Nullable<System.Int32> PCT0100012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100013", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Melanesian (543-546) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Other Melanesian (543-546) & (100-299) or (300, A01-Z99) or (400-999)", Order = 31)]
        public System.Nullable<System.Int32> PCT0100013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0100014", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Pacific Islander, not specified (530, 547-599) & (100-299) or (300, A01-Z99) or (400-999)", ShortName = "Other Pacific Islander, not specified (530, 547-599) & (100-299) or (300, A01-Z99) or (400-999)", Order = 32)]
        public System.Nullable<System.Int32> PCT0100014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110001", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 33)]
        public System.Nullable<System.Int32> PCT0110001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110002", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not Hispanic or Latino (001-199, 300-999)", ShortName = "Not Hispanic or Latino (001-199, 300-999)", Order = 34)]
        public System.Nullable<System.Int32> PCT0110002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110003", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hispanic or Latino (200-299):", ShortName = "Hispanic or Latino (200-299):", Order = 35)]
        public System.Nullable<System.Int32> PCT0110003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110004", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Mexican (210-220)", ShortName = "Mexican (210-220)", Order = 36)]
        public System.Nullable<System.Int32> PCT0110004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110005", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Puerto Rican (260-269)", ShortName = "Puerto Rican (260-269)", Order = 37)]
        public System.Nullable<System.Int32> PCT0110005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110006", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Cuban (270-274)", ShortName = "Cuban (270-274)", Order = 38)]
        public System.Nullable<System.Int32> PCT0110006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110007", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Dominican (275-279)", ShortName = "Dominican (275-279)", Order = 39)]
        public System.Nullable<System.Int32> PCT0110007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110008", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Central American (excluding Mexican) (221-230):", ShortName = "Central American (excluding Mexican) (221-230):", Order = 40)]
        public System.Nullable<System.Int32> PCT0110008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110009", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Costa Rican (221)", ShortName = "Costa Rican (221)", Order = 41)]
        public System.Nullable<System.Int32> PCT0110009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110010", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Guatemalan (222)", ShortName = "Guatemalan (222)", Order = 42)]
        public System.Nullable<System.Int32> PCT0110010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110011", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Honduran (223)", ShortName = "Honduran (223)", Order = 43)]
        public System.Nullable<System.Int32> PCT0110011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110012", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nicaraguan (224)", ShortName = "Nicaraguan (224)", Order = 44)]
        public System.Nullable<System.Int32> PCT0110012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110013", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Panamanian (225)", ShortName = "Panamanian (225)", Order = 45)]
        public System.Nullable<System.Int32> PCT0110013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110014", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Salvadoran (226)", ShortName = "Salvadoran (226)", Order = 46)]
        public System.Nullable<System.Int32> PCT0110014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110015", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Central American (227-230)", ShortName = "Other Central American (227-230)", Order = 47)]
        public System.Nullable<System.Int32> PCT0110015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110016", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "South American (231-249):", ShortName = "South American (231-249):", Order = 48)]
        public System.Nullable<System.Int32> PCT0110016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110017", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Argentinean (231)", ShortName = "Argentinean (231)", Order = 49)]
        public System.Nullable<System.Int32> PCT0110017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110018", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Bolivian (232)", ShortName = "Bolivian (232)", Order = 50)]
        public System.Nullable<System.Int32> PCT0110018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110019", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Chilean (233)", ShortName = "Chilean (233)", Order = 51)]
        public System.Nullable<System.Int32> PCT0110019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110020", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Colombian (234)", ShortName = "Colombian (234)", Order = 52)]
        public System.Nullable<System.Int32> PCT0110020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110021", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Ecuadorian (235)", ShortName = "Ecuadorian (235)", Order = 53)]
        public System.Nullable<System.Int32> PCT0110021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110022", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Paraguayan (236)", ShortName = "Paraguayan (236)", Order = 54)]
        public System.Nullable<System.Int32> PCT0110022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110023", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Peruvian (237)", ShortName = "Peruvian (237)", Order = 55)]
        public System.Nullable<System.Int32> PCT0110023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110024", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Uruguayan (238)", ShortName = "Uruguayan (238)", Order = 56)]
        public System.Nullable<System.Int32> PCT0110024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110025", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Venezuelan (239)", ShortName = "Venezuelan (239)", Order = 57)]
        public System.Nullable<System.Int32> PCT0110025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110026", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other South American (240-249)", ShortName = "Other South American (240-249)", Order = 58)]
        public System.Nullable<System.Int32> PCT0110026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110027", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other Hispanic or Latino (200-209, 250-259, 280-299):", ShortName = "Other Hispanic or Latino (200-209, 250-259, 280-299):", Order = 59)]
        public System.Nullable<System.Int32> PCT0110027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110028", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spaniard (200-209)", ShortName = "Spaniard (200-209)", Order = 60)]
        public System.Nullable<System.Int32> PCT0110028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110029", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spanish (282)", ShortName = "Spanish (282)", Order = 61)]
        public System.Nullable<System.Int32> PCT0110029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110030", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spanish American (286)", ShortName = "Spanish American (286)", Order = 62)]
        public System.Nullable<System.Int32> PCT0110030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0110031", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "All other Hispanic or Latino (250-259, 280-281, 283-285, 287-299)", ShortName = "All other Hispanic or Latino (250-259, 280-281, 283-285, 287-299)", Order = 63)]
        public System.Nullable<System.Int32> PCT0110031 { get; set; }
        #endregion Properties

        #region Constructors
        public SF1_00016(string csvLine) : base(csvLine) {}

        public SF1_00016(string[] values) : base(values) {}

        public SF1_00016(OleDbDataReader reader, CensusFileType fileType)
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
                PCT0090001 = (System.Nullable<System.Int32>)reader[5];
            }
            if(reader[6] != DBNull.Value)
            {
                PCT0090002 = (System.Nullable<System.Int32>)reader[6];
            }
            if(reader[7] != DBNull.Value)
            {
                PCT0090003 = (System.Nullable<System.Int32>)reader[7];
            }
            if(reader[8] != DBNull.Value)
            {
                PCT0090004 = (System.Nullable<System.Int32>)reader[8];
            }
            if(reader[9] != DBNull.Value)
            {
                PCT0090005 = (System.Nullable<System.Int32>)reader[9];
            }
            if(reader[10] != DBNull.Value)
            {
                PCT0090006 = (System.Nullable<System.Int32>)reader[10];
            }
            if(reader[11] != DBNull.Value)
            {
                PCT0090007 = (System.Nullable<System.Int32>)reader[11];
            }
            if(reader[12] != DBNull.Value)
            {
                PCT0090008 = (System.Nullable<System.Int32>)reader[12];
            }
            if(reader[13] != DBNull.Value)
            {
                PCT0090009 = (System.Nullable<System.Int32>)reader[13];
            }
            if(reader[14] != DBNull.Value)
            {
                PCT0090010 = (System.Nullable<System.Int32>)reader[14];
            }
            if(reader[15] != DBNull.Value)
            {
                PCT0090011 = (System.Nullable<System.Int32>)reader[15];
            }
            if(reader[16] != DBNull.Value)
            {
                PCT0090012 = (System.Nullable<System.Int32>)reader[16];
            }
            if(reader[17] != DBNull.Value)
            {
                PCT0090013 = (System.Nullable<System.Int32>)reader[17];
            }
            if(reader[18] != DBNull.Value)
            {
                PCT0090014 = (System.Nullable<System.Int32>)reader[18];
            }
            if(reader[19] != DBNull.Value)
            {
                PCT0100001 = (System.Nullable<System.Int32>)reader[19];
            }
            if(reader[20] != DBNull.Value)
            {
                PCT0100002 = (System.Nullable<System.Int32>)reader[20];
            }
            if(reader[21] != DBNull.Value)
            {
                PCT0100003 = (System.Nullable<System.Int32>)reader[21];
            }
            if(reader[22] != DBNull.Value)
            {
                PCT0100004 = (System.Nullable<System.Int32>)reader[22];
            }
            if(reader[23] != DBNull.Value)
            {
                PCT0100005 = (System.Nullable<System.Int32>)reader[23];
            }
            if(reader[24] != DBNull.Value)
            {
                PCT0100006 = (System.Nullable<System.Int32>)reader[24];
            }
            if(reader[25] != DBNull.Value)
            {
                PCT0100007 = (System.Nullable<System.Int32>)reader[25];
            }
            if(reader[26] != DBNull.Value)
            {
                PCT0100008 = (System.Nullable<System.Int32>)reader[26];
            }
            if(reader[27] != DBNull.Value)
            {
                PCT0100009 = (System.Nullable<System.Int32>)reader[27];
            }
            if(reader[28] != DBNull.Value)
            {
                PCT0100010 = (System.Nullable<System.Int32>)reader[28];
            }
            if(reader[29] != DBNull.Value)
            {
                PCT0100011 = (System.Nullable<System.Int32>)reader[29];
            }
            if(reader[30] != DBNull.Value)
            {
                PCT0100012 = (System.Nullable<System.Int32>)reader[30];
            }
            if(reader[31] != DBNull.Value)
            {
                PCT0100013 = (System.Nullable<System.Int32>)reader[31];
            }
            if(reader[32] != DBNull.Value)
            {
                PCT0100014 = (System.Nullable<System.Int32>)reader[32];
            }
            if(reader[33] != DBNull.Value)
            {
                PCT0110001 = (System.Nullable<System.Int32>)reader[33];
            }
            if(reader[34] != DBNull.Value)
            {
                PCT0110002 = (System.Nullable<System.Int32>)reader[34];
            }
            if(reader[35] != DBNull.Value)
            {
                PCT0110003 = (System.Nullable<System.Int32>)reader[35];
            }
            if(reader[36] != DBNull.Value)
            {
                PCT0110004 = (System.Nullable<System.Int32>)reader[36];
            }
            if(reader[37] != DBNull.Value)
            {
                PCT0110005 = (System.Nullable<System.Int32>)reader[37];
            }
            if(reader[38] != DBNull.Value)
            {
                PCT0110006 = (System.Nullable<System.Int32>)reader[38];
            }
            if(reader[39] != DBNull.Value)
            {
                PCT0110007 = (System.Nullable<System.Int32>)reader[39];
            }
            if(reader[40] != DBNull.Value)
            {
                PCT0110008 = (System.Nullable<System.Int32>)reader[40];
            }
            if(reader[41] != DBNull.Value)
            {
                PCT0110009 = (System.Nullable<System.Int32>)reader[41];
            }
            if(reader[42] != DBNull.Value)
            {
                PCT0110010 = (System.Nullable<System.Int32>)reader[42];
            }
            if(reader[43] != DBNull.Value)
            {
                PCT0110011 = (System.Nullable<System.Int32>)reader[43];
            }
            if(reader[44] != DBNull.Value)
            {
                PCT0110012 = (System.Nullable<System.Int32>)reader[44];
            }
            if(reader[45] != DBNull.Value)
            {
                PCT0110013 = (System.Nullable<System.Int32>)reader[45];
            }
            if(reader[46] != DBNull.Value)
            {
                PCT0110014 = (System.Nullable<System.Int32>)reader[46];
            }
            if(reader[47] != DBNull.Value)
            {
                PCT0110015 = (System.Nullable<System.Int32>)reader[47];
            }
            if(reader[48] != DBNull.Value)
            {
                PCT0110016 = (System.Nullable<System.Int32>)reader[48];
            }
            if(reader[49] != DBNull.Value)
            {
                PCT0110017 = (System.Nullable<System.Int32>)reader[49];
            }
            if(reader[50] != DBNull.Value)
            {
                PCT0110018 = (System.Nullable<System.Int32>)reader[50];
            }
            if(reader[51] != DBNull.Value)
            {
                PCT0110019 = (System.Nullable<System.Int32>)reader[51];
            }
            if(reader[52] != DBNull.Value)
            {
                PCT0110020 = (System.Nullable<System.Int32>)reader[52];
            }
            if(reader[53] != DBNull.Value)
            {
                PCT0110021 = (System.Nullable<System.Int32>)reader[53];
            }
            if(reader[54] != DBNull.Value)
            {
                PCT0110022 = (System.Nullable<System.Int32>)reader[54];
            }
            if(reader[55] != DBNull.Value)
            {
                PCT0110023 = (System.Nullable<System.Int32>)reader[55];
            }
            if(reader[56] != DBNull.Value)
            {
                PCT0110024 = (System.Nullable<System.Int32>)reader[56];
            }
            if(reader[57] != DBNull.Value)
            {
                PCT0110025 = (System.Nullable<System.Int32>)reader[57];
            }
            if(reader[58] != DBNull.Value)
            {
                PCT0110026 = (System.Nullable<System.Int32>)reader[58];
            }
            if(reader[59] != DBNull.Value)
            {
                PCT0110027 = (System.Nullable<System.Int32>)reader[59];
            }
            if(reader[60] != DBNull.Value)
            {
                PCT0110028 = (System.Nullable<System.Int32>)reader[60];
            }
            if(reader[61] != DBNull.Value)
            {
                PCT0110029 = (System.Nullable<System.Int32>)reader[61];
            }
            if(reader[62] != DBNull.Value)
            {
                PCT0110030 = (System.Nullable<System.Int32>)reader[62];
            }
            if(reader[63] != DBNull.Value)
            {
                PCT0110031 = (System.Nullable<System.Int32>)reader[63];
            }
        }
        #endregion Constructors
    }
}