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

    [Table("SF2_Segment_05")]
    public partial class SF2_Segment_05 : BaseModel
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
        [Column("PCT0190001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public System.Nullable<System.Int32> PCT0190001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 6)]
        public System.Nullable<System.Int32> PCT0190002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 7)]
        public System.Nullable<System.Int32> PCT0190003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 8)]
        public System.Nullable<System.Int32> PCT0190004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 9)]
        public System.Nullable<System.Int32> PCT0190005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 10)]
        public System.Nullable<System.Int32> PCT0190006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 11)]
        public System.Nullable<System.Int32> PCT0190007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Roomer or boarder", ShortName = "Roomer or boarder", Order = 12)]
        public System.Nullable<System.Int32> PCT0190008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Housemate or roommate", ShortName = "Housemate or roommate", Order = 13)]
        public System.Nullable<System.Int32> PCT0190009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried partner", ShortName = "Unmarried partner", Order = 14)]
        public System.Nullable<System.Int32> PCT0190010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other nonrelatives", ShortName = "Other nonrelatives", Order = 15)]
        public System.Nullable<System.Int32> PCT0190011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 16)]
        public System.Nullable<System.Int32> PCT0190012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried-partner households:", ShortName = "Unmarried-partner households:", Order = 17)]
        public System.Nullable<System.Int32> PCT0190013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder and male partner:", ShortName = "Male householder and male partner:", Order = 18)]
        public System.Nullable<System.Int32> PCT0190014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 19)]
        public System.Nullable<System.Int32> PCT0190015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 20)]
        public System.Nullable<System.Int32> PCT0190016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190017", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 21)]
        public System.Nullable<System.Int32> PCT0190017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190018", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 22)]
        public System.Nullable<System.Int32> PCT0190018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190019", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder and female partner:", ShortName = "Male householder and female partner:", Order = 23)]
        public System.Nullable<System.Int32> PCT0190019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190020", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 24)]
        public System.Nullable<System.Int32> PCT0190020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190021", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 25)]
        public System.Nullable<System.Int32> PCT0190021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190022", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 26)]
        public System.Nullable<System.Int32> PCT0190022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190023", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 27)]
        public System.Nullable<System.Int32> PCT0190023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190024", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder and female partner:", ShortName = "Female householder and female partner:", Order = 28)]
        public System.Nullable<System.Int32> PCT0190024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190025", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 29)]
        public System.Nullable<System.Int32> PCT0190025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190026", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 30)]
        public System.Nullable<System.Int32> PCT0190026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190027", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 31)]
        public System.Nullable<System.Int32> PCT0190027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190028", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 32)]
        public System.Nullable<System.Int32> PCT0190028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190029", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder and male partner:", ShortName = "Female householder and male partner:", Order = 33)]
        public System.Nullable<System.Int32> PCT0190029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190030", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 34)]
        public System.Nullable<System.Int32> PCT0190030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190031", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "With own children under 18 years", ShortName = "With own children under 18 years", Order = 35)]
        public System.Nullable<System.Int32> PCT0190031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190032", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No own children under 18 years", ShortName = "No own children under 18 years", Order = 36)]
        public System.Nullable<System.Int32> PCT0190032 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190033", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 37)]
        public System.Nullable<System.Int32> PCT0190033 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0190034", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "All other households", ShortName = "All other households", Order = 38)]
        public System.Nullable<System.Int32> PCT0190034 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200001", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 39)]
        public System.Nullable<System.Int32> PCT0200001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200002", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 40)]
        public System.Nullable<System.Int32> PCT0200002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200003", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 41)]
        public System.Nullable<System.Int32> PCT0200003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200004", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 42)]
        public System.Nullable<System.Int32> PCT0200004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200005", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 43)]
        public System.Nullable<System.Int32> PCT0200005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200006", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 44)]
        public System.Nullable<System.Int32> PCT0200006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200007", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 45)]
        public System.Nullable<System.Int32> PCT0200007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200008", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 46)]
        public System.Nullable<System.Int32> PCT0200008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200009", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 47)]
        public System.Nullable<System.Int32> PCT0200009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200010", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 48)]
        public System.Nullable<System.Int32> PCT0200010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200011", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 49)]
        public System.Nullable<System.Int32> PCT0200011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200012", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 50)]
        public System.Nullable<System.Int32> PCT0200012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200013", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 51)]
        public System.Nullable<System.Int32> PCT0200013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200014", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 52)]
        public System.Nullable<System.Int32> PCT0200014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200015", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 53)]
        public System.Nullable<System.Int32> PCT0200015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0200016", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 54)]
        public System.Nullable<System.Int32> PCT0200016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210001", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 55)]
        public System.Nullable<System.Int32> PCT0210001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210002", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 56)]
        public System.Nullable<System.Int32> PCT0210002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210003", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years:", ShortName = "Under 18 years:", Order = 57)]
        public System.Nullable<System.Int32> PCT0210003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210004", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population (101-106, 201-203, 301,  401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301,  401-405):", Order = 58)]
        public System.Nullable<System.Int32> PCT0210004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210005", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 59)]
        public System.Nullable<System.Int32> PCT0210005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210006", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 60)]
        public System.Nullable<System.Int32> PCT0210006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210007", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 61)]
        public System.Nullable<System.Int32> PCT0210007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210008", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 62)]
        public System.Nullable<System.Int32> PCT0210008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210009", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 63)]
        public System.Nullable<System.Int32> PCT0210009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210010", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 64)]
        public System.Nullable<System.Int32> PCT0210010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210011", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 65)]
        public System.Nullable<System.Int32> PCT0210011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210012", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 66)]
        public System.Nullable<System.Int32> PCT0210012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210013", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 67)]
        public System.Nullable<System.Int32> PCT0210013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210014", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 68)]
        public System.Nullable<System.Int32> PCT0210014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210015", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 69)]
        public System.Nullable<System.Int32> PCT0210015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210016", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 70)]
        public System.Nullable<System.Int32> PCT0210016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210017", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 71)]
        public System.Nullable<System.Int32> PCT0210017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210018", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 72)]
        public System.Nullable<System.Int32> PCT0210018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210019", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 73)]
        public System.Nullable<System.Int32> PCT0210019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210020", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 74)]
        public System.Nullable<System.Int32> PCT0210020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210021", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 75)]
        public System.Nullable<System.Int32> PCT0210021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210022", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 76)]
        public System.Nullable<System.Int32> PCT0210022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210023", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 77)]
        public System.Nullable<System.Int32> PCT0210023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210024", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 78)]
        public System.Nullable<System.Int32> PCT0210024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210025", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 79)]
        public System.Nullable<System.Int32> PCT0210025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0210026", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 80)]
        public System.Nullable<System.Int32> PCT0210026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220001", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 81)]
        public System.Nullable<System.Int32> PCT0220001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220002", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 82)]
        public System.Nullable<System.Int32> PCT0220002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220003", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 83)]
        public System.Nullable<System.Int32> PCT0220003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220004", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 84)]
        public System.Nullable<System.Int32> PCT0220004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220005", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 85)]
        public System.Nullable<System.Int32> PCT0220005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220006", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 86)]
        public System.Nullable<System.Int32> PCT0220006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220007", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 87)]
        public System.Nullable<System.Int32> PCT0220007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220008", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 88)]
        public System.Nullable<System.Int32> PCT0220008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220009", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 89)]
        public System.Nullable<System.Int32> PCT0220009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220010", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 90)]
        public System.Nullable<System.Int32> PCT0220010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220011", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 91)]
        public System.Nullable<System.Int32> PCT0220011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220012", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 92)]
        public System.Nullable<System.Int32> PCT0220012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220013", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 93)]
        public System.Nullable<System.Int32> PCT0220013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220014", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities for adults (101-106)", ShortName = "Correctional facilities for adults (101-106)", Order = 94)]
        public System.Nullable<System.Int32> PCT0220014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220015", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Juvenile facilities (201-203)", ShortName = "Juvenile facilities (201-203)", Order = 95)]
        public System.Nullable<System.Int32> PCT0220015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220016", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nursing facilities/skilled-nursing facilities (301)", ShortName = "Nursing facilities/skilled-nursing facilities (301)", Order = 96)]
        public System.Nullable<System.Int32> PCT0220016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220017", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other institutional facilities (401-405)", ShortName = "Other institutional facilities (401-405)", Order = 97)]
        public System.Nullable<System.Int32> PCT0220017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220018", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 98)]
        public System.Nullable<System.Int32> PCT0220018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220019", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "College/university student housing (501)", ShortName = "College/university student housing (501)", Order = 99)]
        public System.Nullable<System.Int32> PCT0220019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220020", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military quarters (601-602)", ShortName = "Military quarters (601-602)", Order = 100)]
        public System.Nullable<System.Int32> PCT0220020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220021", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904)", Order = 101)]
        public System.Nullable<System.Int32> PCT0220021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220022", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 102)]
        public System.Nullable<System.Int32> PCT0220022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220023", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 103)]
        public System.Nullable<System.Int32> PCT0220023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220024", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 104)]
        public System.Nullable<System.Int32> PCT0220024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220025", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 105)]
        public System.Nullable<System.Int32> PCT0220025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220026", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 106)]
        public System.Nullable<System.Int32> PCT0220026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220027", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 107)]
        public System.Nullable<System.Int32> PCT0220027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0220028", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 108)]
        public System.Nullable<System.Int32> PCT0220028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0230001", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 109)]
        public System.Nullable<System.Int32> PCT0230001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0230002", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 110)]
        public System.Nullable<System.Int32> PCT0230002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0230003", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 111)]
        public System.Nullable<System.Int32> PCT0230003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0230004", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In other family:", ShortName = "In other family:", Order = 112)]
        public System.Nullable<System.Int32> PCT0230004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0230005", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In male householder, no wife present family", ShortName = "In male householder, no wife present family", Order = 113)]
        public System.Nullable<System.Int32> PCT0230005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0230006", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In female householder, no husband present family", ShortName = "In female householder, no husband present family", Order = 114)]
        public System.Nullable<System.Int32> PCT0230006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0230007", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 115)]
        public System.Nullable<System.Int32> PCT0230007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0230008", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households with a male householder:", ShortName = "In households with a male householder:", Order = 116)]
        public System.Nullable<System.Int32> PCT0230008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0230009", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In 1-person household", ShortName = "In 1-person household", Order = 117)]
        public System.Nullable<System.Int32> PCT0230009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0230010", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In 2-or-more-person household", ShortName = "In 2-or-more-person household", Order = 118)]
        public System.Nullable<System.Int32> PCT0230010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0230011", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households with a female householder:", ShortName = "In households with a female householder:", Order = 119)]
        public System.Nullable<System.Int32> PCT0230011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0230012", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In 1-person household", ShortName = "In 1-person household", Order = 120)]
        public System.Nullable<System.Int32> PCT0230012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0230013", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In 2-or-more-person household", ShortName = "In 2-or-more-person household", Order = 121)]
        public System.Nullable<System.Int32> PCT0230013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0240001", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 122)]
        public System.Nullable<System.Int32> PCT0240001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0240002", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 123)]
        public System.Nullable<System.Int32> PCT0240002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0240003", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 124)]
        public System.Nullable<System.Int32> PCT0240003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0240004", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Related child:", ShortName = "Related child:", Order = 125)]
        public System.Nullable<System.Int32> PCT0240004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0240005", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Own child:", ShortName = "Own child:", Order = 126)]
        public System.Nullable<System.Int32> PCT0240005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0240006", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 127)]
        public System.Nullable<System.Int32> PCT0240006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0240007", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In other family:", ShortName = "In other family:", Order = 128)]
        public System.Nullable<System.Int32> PCT0240007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0240008", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In male householder, no wife present family", ShortName = "In male householder, no wife present family", Order = 129)]
        public System.Nullable<System.Int32> PCT0240008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0240009", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In female householder, no husband present family", ShortName = "In female householder, no husband present family", Order = 130)]
        public System.Nullable<System.Int32> PCT0240009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0240010", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 131)]
        public System.Nullable<System.Int32> PCT0240010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0240011", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Grandchild", ShortName = "Grandchild", Order = 132)]
        public System.Nullable<System.Int32> PCT0240011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0240012", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 133)]
        public System.Nullable<System.Int32> PCT0240012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0240013", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 134)]
        public System.Nullable<System.Int32> PCT0240013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0240014", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 135)]
        public System.Nullable<System.Int32> PCT0240014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0240015", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 136)]
        public System.Nullable<System.Int32> PCT0240015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0240016", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 137)]
        public System.Nullable<System.Int32> PCT0240016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250001", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 138)]
        public System.Nullable<System.Int32> PCT0250001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250002", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 139)]
        public System.Nullable<System.Int32> PCT0250002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250003", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder or spouse", ShortName = "Householder or spouse", Order = 140)]
        public System.Nullable<System.Int32> PCT0250003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250004", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Related child:", ShortName = "Related child:", Order = 141)]
        public System.Nullable<System.Int32> PCT0250004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250005", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Own child:", ShortName = "Own child:", Order = 142)]
        public System.Nullable<System.Int32> PCT0250005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250006", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 143)]
        public System.Nullable<System.Int32> PCT0250006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250007", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 144)]
        public System.Nullable<System.Int32> PCT0250007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250008", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 145)]
        public System.Nullable<System.Int32> PCT0250008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250009", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 146)]
        public System.Nullable<System.Int32> PCT0250009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250010", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 and 13 years", ShortName = "12 and 13 years", Order = 147)]
        public System.Nullable<System.Int32> PCT0250010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250011", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "14 years", ShortName = "14 years", Order = 148)]
        public System.Nullable<System.Int32> PCT0250011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250012", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 149)]
        public System.Nullable<System.Int32> PCT0250012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250013", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives:", ShortName = "Other relatives:", Order = 150)]
        public System.Nullable<System.Int32> PCT0250013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250014", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 151)]
        public System.Nullable<System.Int32> PCT0250014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250015", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 152)]
        public System.Nullable<System.Int32> PCT0250015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250016", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 153)]
        public System.Nullable<System.Int32> PCT0250016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250017", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 154)]
        public System.Nullable<System.Int32> PCT0250017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250018", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 and 13 years", ShortName = "12 and 13 years", Order = 155)]
        public System.Nullable<System.Int32> PCT0250018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250019", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "14 years", ShortName = "14 years", Order = 156)]
        public System.Nullable<System.Int32> PCT0250019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250020", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 157)]
        public System.Nullable<System.Int32> PCT0250020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250021", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives:", ShortName = "Nonrelatives:", Order = 158)]
        public System.Nullable<System.Int32> PCT0250021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250022", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 159)]
        public System.Nullable<System.Int32> PCT0250022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250023", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 160)]
        public System.Nullable<System.Int32> PCT0250023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250024", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 161)]
        public System.Nullable<System.Int32> PCT0250024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250025", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 162)]
        public System.Nullable<System.Int32> PCT0250025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250026", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 and 13 years", ShortName = "12 and 13 years", Order = 163)]
        public System.Nullable<System.Int32> PCT0250026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250027", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "14 years", ShortName = "14 years", Order = 164)]
        public System.Nullable<System.Int32> PCT0250027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250028", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 165)]
        public System.Nullable<System.Int32> PCT0250028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250029", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 166)]
        public System.Nullable<System.Int32> PCT0250029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250030", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population:", ShortName = "Institutionalized population:", Order = 167)]
        public System.Nullable<System.Int32> PCT0250030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250031", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 168)]
        public System.Nullable<System.Int32> PCT0250031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250032", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 169)]
        public System.Nullable<System.Int32> PCT0250032 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250033", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 170)]
        public System.Nullable<System.Int32> PCT0250033 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250034", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 171)]
        public System.Nullable<System.Int32> PCT0250034 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250035", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 and 13 years", ShortName = "12 and 13 years", Order = 172)]
        public System.Nullable<System.Int32> PCT0250035 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250036", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "14 years", ShortName = "14 years", Order = 173)]
        public System.Nullable<System.Int32> PCT0250036 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250037", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 174)]
        public System.Nullable<System.Int32> PCT0250037 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250038", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population:", ShortName = "Noninstitutionalized population:", Order = 175)]
        public System.Nullable<System.Int32> PCT0250038 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250039", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 3 years", ShortName = "Under 3 years", Order = 176)]
        public System.Nullable<System.Int32> PCT0250039 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250040", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "3 and 4 years", ShortName = "3 and 4 years", Order = 177)]
        public System.Nullable<System.Int32> PCT0250040 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250041", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "5 years", ShortName = "5 years", Order = 178)]
        public System.Nullable<System.Int32> PCT0250041 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250042", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "6 to 11 years", ShortName = "6 to 11 years", Order = 179)]
        public System.Nullable<System.Int32> PCT0250042 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250043", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "12 and 13 years", ShortName = "12 and 13 years", Order = 180)]
        public System.Nullable<System.Int32> PCT0250043 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250044", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "14 years", ShortName = "14 years", Order = 181)]
        public System.Nullable<System.Int32> PCT0250044 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0250045", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "15 to 17 years", ShortName = "15 to 17 years", Order = 182)]
        public System.Nullable<System.Int32> PCT0250045 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0260001", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 183)]
        public System.Nullable<System.Int32> PCT0260001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0260002", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 184)]
        public System.Nullable<System.Int32> PCT0260002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0260003", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In husband-wife family", ShortName = "In husband-wife family", Order = 185)]
        public System.Nullable<System.Int32> PCT0260003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0260004", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In other family:", ShortName = "In other family:", Order = 186)]
        public System.Nullable<System.Int32> PCT0260004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0260005", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In male householder, no wife present family", ShortName = "In male householder, no wife present family", Order = 187)]
        public System.Nullable<System.Int32> PCT0260005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0260006", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In female householder, no husband present family", ShortName = "In female householder, no husband present family", Order = 188)]
        public System.Nullable<System.Int32> PCT0260006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0260007", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households", ShortName = "In nonfamily households", Order = 189)]
        public System.Nullable<System.Int32> PCT0260007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0270001", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 190)]
        public System.Nullable<System.Int32> PCT0270001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0270002", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Unmarried partner of householder present:", ShortName = "Unmarried partner of householder present:", Order = 191)]
        public System.Nullable<System.Int32> PCT0270002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0270003", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 192)]
        public System.Nullable<System.Int32> PCT0270003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0270004", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In male householder and male partner households", ShortName = "In male householder and male partner households", Order = 193)]
        public System.Nullable<System.Int32> PCT0270004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0270005", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In male householder and female partner households", ShortName = "In male householder and female partner households", Order = 194)]
        public System.Nullable<System.Int32> PCT0270005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0270006", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In female householder and female partner households", ShortName = "In female householder and female partner households", Order = 195)]
        public System.Nullable<System.Int32> PCT0270006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0270007", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In female householder and male partner households", ShortName = "In female householder and male partner households", Order = 196)]
        public System.Nullable<System.Int32> PCT0270007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0270008", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 197)]
        public System.Nullable<System.Int32> PCT0270008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0270009", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In male householder and male partner households", ShortName = "In male householder and male partner households", Order = 198)]
        public System.Nullable<System.Int32> PCT0270009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0270010", Order = 199)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In male householder and female partner households", ShortName = "In male householder and female partner households", Order = 199)]
        public System.Nullable<System.Int32> PCT0270010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0270011", Order = 200)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In female householder and female partner households", ShortName = "In female householder and female partner households", Order = 200)]
        public System.Nullable<System.Int32> PCT0270011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0270012", Order = 201)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In female householder and male partner households", ShortName = "In female householder and male partner households", Order = 201)]
        public System.Nullable<System.Int32> PCT0270012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0270013", Order = 202)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No unmarried partner of householder present:", ShortName = "No unmarried partner of householder present:", Order = 202)]
        public System.Nullable<System.Int32> PCT0270013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0270014", Order = 203)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 203)]
        public System.Nullable<System.Int32> PCT0270014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0270015", Order = 204)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In husband-wife family households", ShortName = "In husband-wife family households", Order = 204)]
        public System.Nullable<System.Int32> PCT0270015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0270016", Order = 205)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In male householder, no wife present, family households", ShortName = "In male householder, no wife present, family households", Order = 205)]
        public System.Nullable<System.Int32> PCT0270016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0270017", Order = 206)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In female householder, no husband present, family households", ShortName = "In female householder, no husband present, family households", Order = 206)]
        public System.Nullable<System.Int32> PCT0270017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0270018", Order = 207)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households", ShortName = "In nonfamily households", Order = 207)]
        public System.Nullable<System.Int32> PCT0270018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0280001", Order = 208)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 208)]
        public System.Nullable<System.Int32> PCT0280001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0280002", Order = 209)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In households:", ShortName = "In households:", Order = 209)]
        public System.Nullable<System.Int32> PCT0280002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0280003", Order = 210)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In family households:", ShortName = "In family households:", Order = 210)]
        public System.Nullable<System.Int32> PCT0280003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0280004", Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Householder:", ShortName = "Householder:", Order = 211)]
        public System.Nullable<System.Int32> PCT0280004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0280005", Order = 212)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male", ShortName = "Male", Order = 212)]
        public System.Nullable<System.Int32> PCT0280005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0280006", Order = 213)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female", ShortName = "Female", Order = 213)]
        public System.Nullable<System.Int32> PCT0280006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0280007", Order = 214)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Spouse", ShortName = "Spouse", Order = 214)]
        public System.Nullable<System.Int32> PCT0280007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0280008", Order = 215)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Child", ShortName = "Child", Order = 215)]
        public System.Nullable<System.Int32> PCT0280008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0280009", Order = 216)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent", ShortName = "Parent", Order = 216)]
        public System.Nullable<System.Int32> PCT0280009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0280010", Order = 217)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Parent-in-law", ShortName = "Parent-in-law", Order = 217)]
        public System.Nullable<System.Int32> PCT0280010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0280011", Order = 218)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other relatives", ShortName = "Other relatives", Order = 218)]
        public System.Nullable<System.Int32> PCT0280011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0280012", Order = 219)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 219)]
        public System.Nullable<System.Int32> PCT0280012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0280013", Order = 220)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In nonfamily households:", ShortName = "In nonfamily households:", Order = 220)]
        public System.Nullable<System.Int32> PCT0280013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0280014", Order = 221)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male householder:", ShortName = "Male householder:", Order = 221)]
        public System.Nullable<System.Int32> PCT0280014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0280015", Order = 222)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 222)]
        public System.Nullable<System.Int32> PCT0280015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0280016", Order = 223)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 223)]
        public System.Nullable<System.Int32> PCT0280016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0280017", Order = 224)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female householder:", ShortName = "Female householder:", Order = 224)]
        public System.Nullable<System.Int32> PCT0280017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0280018", Order = 225)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Living alone", ShortName = "Living alone", Order = 225)]
        public System.Nullable<System.Int32> PCT0280018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0280019", Order = 226)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not living alone", ShortName = "Not living alone", Order = 226)]
        public System.Nullable<System.Int32> PCT0280019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0280020", Order = 227)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nonrelatives", ShortName = "Nonrelatives", Order = 227)]
        public System.Nullable<System.Int32> PCT0280020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0280021", Order = 228)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In group quarters:", ShortName = "In group quarters:", Order = 228)]
        public System.Nullable<System.Int32> PCT0280021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0280022", Order = 229)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population", ShortName = "Institutionalized population", Order = 229)]
        public System.Nullable<System.Int32> PCT0280022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0280023", Order = 230)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population", ShortName = "Noninstitutionalized population", Order = 230)]
        public System.Nullable<System.Int32> PCT0280023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0290001", Order = 231)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total", ShortName = "Total", Order = 231)]
        public System.Nullable<System.Int32> PCT0290001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0300001", Order = 232)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 232)]
        public System.Nullable<System.Int32> PCT0300001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0300002", Order = 233)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 233)]
        public System.Nullable<System.Int32> PCT0300002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0300003", Order = 234)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 234)]
        public System.Nullable<System.Int32> PCT0300003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0310001", Order = 235)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 235)]
        public System.Nullable<System.Double> PCT0310001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0310002", Order = 236)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years", ShortName = "Under 18 years", Order = 236)]
        public System.Nullable<System.Double> PCT0310002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0310003", Order = 237)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 years and over", ShortName = "18 years and over", Order = 237)]
        public System.Nullable<System.Double> PCT0310003 { get; set; }
        #endregion Properties

        #region Constructors
        public SF2_Segment_05(string csvLine) : base(csvLine) {}

        public SF2_Segment_05(string[] values) : base(values) {}

        public SF2_Segment_05(OleDbDataReader reader, CensusFileType fileType)
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
                PCT0190001 = (System.Nullable<System.Int32>)reader[5];
            }
            if(reader[6] != DBNull.Value)
            {
                PCT0190002 = (System.Nullable<System.Int32>)reader[6];
            }
            if(reader[7] != DBNull.Value)
            {
                PCT0190003 = (System.Nullable<System.Int32>)reader[7];
            }
            if(reader[8] != DBNull.Value)
            {
                PCT0190004 = (System.Nullable<System.Int32>)reader[8];
            }
            if(reader[9] != DBNull.Value)
            {
                PCT0190005 = (System.Nullable<System.Int32>)reader[9];
            }
            if(reader[10] != DBNull.Value)
            {
                PCT0190006 = (System.Nullable<System.Int32>)reader[10];
            }
            if(reader[11] != DBNull.Value)
            {
                PCT0190007 = (System.Nullable<System.Int32>)reader[11];
            }
            if(reader[12] != DBNull.Value)
            {
                PCT0190008 = (System.Nullable<System.Int32>)reader[12];
            }
            if(reader[13] != DBNull.Value)
            {
                PCT0190009 = (System.Nullable<System.Int32>)reader[13];
            }
            if(reader[14] != DBNull.Value)
            {
                PCT0190010 = (System.Nullable<System.Int32>)reader[14];
            }
            if(reader[15] != DBNull.Value)
            {
                PCT0190011 = (System.Nullable<System.Int32>)reader[15];
            }
            if(reader[16] != DBNull.Value)
            {
                PCT0190012 = (System.Nullable<System.Int32>)reader[16];
            }
            if(reader[17] != DBNull.Value)
            {
                PCT0190013 = (System.Nullable<System.Int32>)reader[17];
            }
            if(reader[18] != DBNull.Value)
            {
                PCT0190014 = (System.Nullable<System.Int32>)reader[18];
            }
            if(reader[19] != DBNull.Value)
            {
                PCT0190015 = (System.Nullable<System.Int32>)reader[19];
            }
            if(reader[20] != DBNull.Value)
            {
                PCT0190016 = (System.Nullable<System.Int32>)reader[20];
            }
            if(reader[21] != DBNull.Value)
            {
                PCT0190017 = (System.Nullable<System.Int32>)reader[21];
            }
            if(reader[22] != DBNull.Value)
            {
                PCT0190018 = (System.Nullable<System.Int32>)reader[22];
            }
            if(reader[23] != DBNull.Value)
            {
                PCT0190019 = (System.Nullable<System.Int32>)reader[23];
            }
            if(reader[24] != DBNull.Value)
            {
                PCT0190020 = (System.Nullable<System.Int32>)reader[24];
            }
            if(reader[25] != DBNull.Value)
            {
                PCT0190021 = (System.Nullable<System.Int32>)reader[25];
            }
            if(reader[26] != DBNull.Value)
            {
                PCT0190022 = (System.Nullable<System.Int32>)reader[26];
            }
            if(reader[27] != DBNull.Value)
            {
                PCT0190023 = (System.Nullable<System.Int32>)reader[27];
            }
            if(reader[28] != DBNull.Value)
            {
                PCT0190024 = (System.Nullable<System.Int32>)reader[28];
            }
            if(reader[29] != DBNull.Value)
            {
                PCT0190025 = (System.Nullable<System.Int32>)reader[29];
            }
            if(reader[30] != DBNull.Value)
            {
                PCT0190026 = (System.Nullable<System.Int32>)reader[30];
            }
            if(reader[31] != DBNull.Value)
            {
                PCT0190027 = (System.Nullable<System.Int32>)reader[31];
            }
            if(reader[32] != DBNull.Value)
            {
                PCT0190028 = (System.Nullable<System.Int32>)reader[32];
            }
            if(reader[33] != DBNull.Value)
            {
                PCT0190029 = (System.Nullable<System.Int32>)reader[33];
            }
            if(reader[34] != DBNull.Value)
            {
                PCT0190030 = (System.Nullable<System.Int32>)reader[34];
            }
            if(reader[35] != DBNull.Value)
            {
                PCT0190031 = (System.Nullable<System.Int32>)reader[35];
            }
            if(reader[36] != DBNull.Value)
            {
                PCT0190032 = (System.Nullable<System.Int32>)reader[36];
            }
            if(reader[37] != DBNull.Value)
            {
                PCT0190033 = (System.Nullable<System.Int32>)reader[37];
            }
            if(reader[38] != DBNull.Value)
            {
                PCT0190034 = (System.Nullable<System.Int32>)reader[38];
            }
            if(reader[39] != DBNull.Value)
            {
                PCT0200001 = (System.Nullable<System.Int32>)reader[39];
            }
            if(reader[40] != DBNull.Value)
            {
                PCT0200002 = (System.Nullable<System.Int32>)reader[40];
            }
            if(reader[41] != DBNull.Value)
            {
                PCT0200003 = (System.Nullable<System.Int32>)reader[41];
            }
            if(reader[42] != DBNull.Value)
            {
                PCT0200004 = (System.Nullable<System.Int32>)reader[42];
            }
            if(reader[43] != DBNull.Value)
            {
                PCT0200005 = (System.Nullable<System.Int32>)reader[43];
            }
            if(reader[44] != DBNull.Value)
            {
                PCT0200006 = (System.Nullable<System.Int32>)reader[44];
            }
            if(reader[45] != DBNull.Value)
            {
                PCT0200007 = (System.Nullable<System.Int32>)reader[45];
            }
            if(reader[46] != DBNull.Value)
            {
                PCT0200008 = (System.Nullable<System.Int32>)reader[46];
            }
            if(reader[47] != DBNull.Value)
            {
                PCT0200009 = (System.Nullable<System.Int32>)reader[47];
            }
            if(reader[48] != DBNull.Value)
            {
                PCT0200010 = (System.Nullable<System.Int32>)reader[48];
            }
            if(reader[49] != DBNull.Value)
            {
                PCT0200011 = (System.Nullable<System.Int32>)reader[49];
            }
            if(reader[50] != DBNull.Value)
            {
                PCT0200012 = (System.Nullable<System.Int32>)reader[50];
            }
            if(reader[51] != DBNull.Value)
            {
                PCT0200013 = (System.Nullable<System.Int32>)reader[51];
            }
            if(reader[52] != DBNull.Value)
            {
                PCT0200014 = (System.Nullable<System.Int32>)reader[52];
            }
            if(reader[53] != DBNull.Value)
            {
                PCT0200015 = (System.Nullable<System.Int32>)reader[53];
            }
            if(reader[54] != DBNull.Value)
            {
                PCT0200016 = (System.Nullable<System.Int32>)reader[54];
            }
            if(reader[55] != DBNull.Value)
            {
                PCT0210001 = (System.Nullable<System.Int32>)reader[55];
            }
            if(reader[56] != DBNull.Value)
            {
                PCT0210002 = (System.Nullable<System.Int32>)reader[56];
            }
            if(reader[57] != DBNull.Value)
            {
                PCT0210003 = (System.Nullable<System.Int32>)reader[57];
            }
            if(reader[58] != DBNull.Value)
            {
                PCT0210004 = (System.Nullable<System.Int32>)reader[58];
            }
            if(reader[59] != DBNull.Value)
            {
                PCT0210005 = (System.Nullable<System.Int32>)reader[59];
            }
            if(reader[60] != DBNull.Value)
            {
                PCT0210006 = (System.Nullable<System.Int32>)reader[60];
            }
            if(reader[61] != DBNull.Value)
            {
                PCT0210007 = (System.Nullable<System.Int32>)reader[61];
            }
            if(reader[62] != DBNull.Value)
            {
                PCT0210008 = (System.Nullable<System.Int32>)reader[62];
            }
            if(reader[63] != DBNull.Value)
            {
                PCT0210009 = (System.Nullable<System.Int32>)reader[63];
            }
            if(reader[64] != DBNull.Value)
            {
                PCT0210010 = (System.Nullable<System.Int32>)reader[64];
            }
            if(reader[65] != DBNull.Value)
            {
                PCT0210011 = (System.Nullable<System.Int32>)reader[65];
            }
            if(reader[66] != DBNull.Value)
            {
                PCT0210012 = (System.Nullable<System.Int32>)reader[66];
            }
            if(reader[67] != DBNull.Value)
            {
                PCT0210013 = (System.Nullable<System.Int32>)reader[67];
            }
            if(reader[68] != DBNull.Value)
            {
                PCT0210014 = (System.Nullable<System.Int32>)reader[68];
            }
            if(reader[69] != DBNull.Value)
            {
                PCT0210015 = (System.Nullable<System.Int32>)reader[69];
            }
            if(reader[70] != DBNull.Value)
            {
                PCT0210016 = (System.Nullable<System.Int32>)reader[70];
            }
            if(reader[71] != DBNull.Value)
            {
                PCT0210017 = (System.Nullable<System.Int32>)reader[71];
            }
            if(reader[72] != DBNull.Value)
            {
                PCT0210018 = (System.Nullable<System.Int32>)reader[72];
            }
            if(reader[73] != DBNull.Value)
            {
                PCT0210019 = (System.Nullable<System.Int32>)reader[73];
            }
            if(reader[74] != DBNull.Value)
            {
                PCT0210020 = (System.Nullable<System.Int32>)reader[74];
            }
            if(reader[75] != DBNull.Value)
            {
                PCT0210021 = (System.Nullable<System.Int32>)reader[75];
            }
            if(reader[76] != DBNull.Value)
            {
                PCT0210022 = (System.Nullable<System.Int32>)reader[76];
            }
            if(reader[77] != DBNull.Value)
            {
                PCT0210023 = (System.Nullable<System.Int32>)reader[77];
            }
            if(reader[78] != DBNull.Value)
            {
                PCT0210024 = (System.Nullable<System.Int32>)reader[78];
            }
            if(reader[79] != DBNull.Value)
            {
                PCT0210025 = (System.Nullable<System.Int32>)reader[79];
            }
            if(reader[80] != DBNull.Value)
            {
                PCT0210026 = (System.Nullable<System.Int32>)reader[80];
            }
            if(reader[81] != DBNull.Value)
            {
                PCT0220001 = (System.Nullable<System.Int32>)reader[81];
            }
            if(reader[82] != DBNull.Value)
            {
                PCT0220002 = (System.Nullable<System.Int32>)reader[82];
            }
            if(reader[83] != DBNull.Value)
            {
                PCT0220003 = (System.Nullable<System.Int32>)reader[83];
            }
            if(reader[84] != DBNull.Value)
            {
                PCT0220004 = (System.Nullable<System.Int32>)reader[84];
            }
            if(reader[85] != DBNull.Value)
            {
                PCT0220005 = (System.Nullable<System.Int32>)reader[85];
            }
            if(reader[86] != DBNull.Value)
            {
                PCT0220006 = (System.Nullable<System.Int32>)reader[86];
            }
            if(reader[87] != DBNull.Value)
            {
                PCT0220007 = (System.Nullable<System.Int32>)reader[87];
            }
            if(reader[88] != DBNull.Value)
            {
                PCT0220008 = (System.Nullable<System.Int32>)reader[88];
            }
            if(reader[89] != DBNull.Value)
            {
                PCT0220009 = (System.Nullable<System.Int32>)reader[89];
            }
            if(reader[90] != DBNull.Value)
            {
                PCT0220010 = (System.Nullable<System.Int32>)reader[90];
            }
            if(reader[91] != DBNull.Value)
            {
                PCT0220011 = (System.Nullable<System.Int32>)reader[91];
            }
            if(reader[92] != DBNull.Value)
            {
                PCT0220012 = (System.Nullable<System.Int32>)reader[92];
            }
            if(reader[93] != DBNull.Value)
            {
                PCT0220013 = (System.Nullable<System.Int32>)reader[93];
            }
            if(reader[94] != DBNull.Value)
            {
                PCT0220014 = (System.Nullable<System.Int32>)reader[94];
            }
            if(reader[95] != DBNull.Value)
            {
                PCT0220015 = (System.Nullable<System.Int32>)reader[95];
            }
            if(reader[96] != DBNull.Value)
            {
                PCT0220016 = (System.Nullable<System.Int32>)reader[96];
            }
            if(reader[97] != DBNull.Value)
            {
                PCT0220017 = (System.Nullable<System.Int32>)reader[97];
            }
            if(reader[98] != DBNull.Value)
            {
                PCT0220018 = (System.Nullable<System.Int32>)reader[98];
            }
            if(reader[99] != DBNull.Value)
            {
                PCT0220019 = (System.Nullable<System.Int32>)reader[99];
            }
            if(reader[100] != DBNull.Value)
            {
                PCT0220020 = (System.Nullable<System.Int32>)reader[100];
            }
            if(reader[101] != DBNull.Value)
            {
                PCT0220021 = (System.Nullable<System.Int32>)reader[101];
            }
            if(reader[102] != DBNull.Value)
            {
                PCT0220022 = (System.Nullable<System.Int32>)reader[102];
            }
            if(reader[103] != DBNull.Value)
            {
                PCT0220023 = (System.Nullable<System.Int32>)reader[103];
            }
            if(reader[104] != DBNull.Value)
            {
                PCT0220024 = (System.Nullable<System.Int32>)reader[104];
            }
            if(reader[105] != DBNull.Value)
            {
                PCT0220025 = (System.Nullable<System.Int32>)reader[105];
            }
            if(reader[106] != DBNull.Value)
            {
                PCT0220026 = (System.Nullable<System.Int32>)reader[106];
            }
            if(reader[107] != DBNull.Value)
            {
                PCT0220027 = (System.Nullable<System.Int32>)reader[107];
            }
            if(reader[108] != DBNull.Value)
            {
                PCT0220028 = (System.Nullable<System.Int32>)reader[108];
            }
            if(reader[109] != DBNull.Value)
            {
                PCT0230001 = (System.Nullable<System.Int32>)reader[109];
            }
            if(reader[110] != DBNull.Value)
            {
                PCT0230002 = (System.Nullable<System.Int32>)reader[110];
            }
            if(reader[111] != DBNull.Value)
            {
                PCT0230003 = (System.Nullable<System.Int32>)reader[111];
            }
            if(reader[112] != DBNull.Value)
            {
                PCT0230004 = (System.Nullable<System.Int32>)reader[112];
            }
            if(reader[113] != DBNull.Value)
            {
                PCT0230005 = (System.Nullable<System.Int32>)reader[113];
            }
            if(reader[114] != DBNull.Value)
            {
                PCT0230006 = (System.Nullable<System.Int32>)reader[114];
            }
            if(reader[115] != DBNull.Value)
            {
                PCT0230007 = (System.Nullable<System.Int32>)reader[115];
            }
            if(reader[116] != DBNull.Value)
            {
                PCT0230008 = (System.Nullable<System.Int32>)reader[116];
            }
            if(reader[117] != DBNull.Value)
            {
                PCT0230009 = (System.Nullable<System.Int32>)reader[117];
            }
            if(reader[118] != DBNull.Value)
            {
                PCT0230010 = (System.Nullable<System.Int32>)reader[118];
            }
            if(reader[119] != DBNull.Value)
            {
                PCT0230011 = (System.Nullable<System.Int32>)reader[119];
            }
            if(reader[120] != DBNull.Value)
            {
                PCT0230012 = (System.Nullable<System.Int32>)reader[120];
            }
            if(reader[121] != DBNull.Value)
            {
                PCT0230013 = (System.Nullable<System.Int32>)reader[121];
            }
            if(reader[122] != DBNull.Value)
            {
                PCT0240001 = (System.Nullable<System.Int32>)reader[122];
            }
            if(reader[123] != DBNull.Value)
            {
                PCT0240002 = (System.Nullable<System.Int32>)reader[123];
            }
            if(reader[124] != DBNull.Value)
            {
                PCT0240003 = (System.Nullable<System.Int32>)reader[124];
            }
            if(reader[125] != DBNull.Value)
            {
                PCT0240004 = (System.Nullable<System.Int32>)reader[125];
            }
            if(reader[126] != DBNull.Value)
            {
                PCT0240005 = (System.Nullable<System.Int32>)reader[126];
            }
            if(reader[127] != DBNull.Value)
            {
                PCT0240006 = (System.Nullable<System.Int32>)reader[127];
            }
            if(reader[128] != DBNull.Value)
            {
                PCT0240007 = (System.Nullable<System.Int32>)reader[128];
            }
            if(reader[129] != DBNull.Value)
            {
                PCT0240008 = (System.Nullable<System.Int32>)reader[129];
            }
            if(reader[130] != DBNull.Value)
            {
                PCT0240009 = (System.Nullable<System.Int32>)reader[130];
            }
            if(reader[131] != DBNull.Value)
            {
                PCT0240010 = (System.Nullable<System.Int32>)reader[131];
            }
            if(reader[132] != DBNull.Value)
            {
                PCT0240011 = (System.Nullable<System.Int32>)reader[132];
            }
            if(reader[133] != DBNull.Value)
            {
                PCT0240012 = (System.Nullable<System.Int32>)reader[133];
            }
            if(reader[134] != DBNull.Value)
            {
                PCT0240013 = (System.Nullable<System.Int32>)reader[134];
            }
            if(reader[135] != DBNull.Value)
            {
                PCT0240014 = (System.Nullable<System.Int32>)reader[135];
            }
            if(reader[136] != DBNull.Value)
            {
                PCT0240015 = (System.Nullable<System.Int32>)reader[136];
            }
            if(reader[137] != DBNull.Value)
            {
                PCT0240016 = (System.Nullable<System.Int32>)reader[137];
            }
            if(reader[138] != DBNull.Value)
            {
                PCT0250001 = (System.Nullable<System.Int32>)reader[138];
            }
            if(reader[139] != DBNull.Value)
            {
                PCT0250002 = (System.Nullable<System.Int32>)reader[139];
            }
            if(reader[140] != DBNull.Value)
            {
                PCT0250003 = (System.Nullable<System.Int32>)reader[140];
            }
            if(reader[141] != DBNull.Value)
            {
                PCT0250004 = (System.Nullable<System.Int32>)reader[141];
            }
            if(reader[142] != DBNull.Value)
            {
                PCT0250005 = (System.Nullable<System.Int32>)reader[142];
            }
            if(reader[143] != DBNull.Value)
            {
                PCT0250006 = (System.Nullable<System.Int32>)reader[143];
            }
            if(reader[144] != DBNull.Value)
            {
                PCT0250007 = (System.Nullable<System.Int32>)reader[144];
            }
            if(reader[145] != DBNull.Value)
            {
                PCT0250008 = (System.Nullable<System.Int32>)reader[145];
            }
            if(reader[146] != DBNull.Value)
            {
                PCT0250009 = (System.Nullable<System.Int32>)reader[146];
            }
            if(reader[147] != DBNull.Value)
            {
                PCT0250010 = (System.Nullable<System.Int32>)reader[147];
            }
            if(reader[148] != DBNull.Value)
            {
                PCT0250011 = (System.Nullable<System.Int32>)reader[148];
            }
            if(reader[149] != DBNull.Value)
            {
                PCT0250012 = (System.Nullable<System.Int32>)reader[149];
            }
            if(reader[150] != DBNull.Value)
            {
                PCT0250013 = (System.Nullable<System.Int32>)reader[150];
            }
            if(reader[151] != DBNull.Value)
            {
                PCT0250014 = (System.Nullable<System.Int32>)reader[151];
            }
            if(reader[152] != DBNull.Value)
            {
                PCT0250015 = (System.Nullable<System.Int32>)reader[152];
            }
            if(reader[153] != DBNull.Value)
            {
                PCT0250016 = (System.Nullable<System.Int32>)reader[153];
            }
            if(reader[154] != DBNull.Value)
            {
                PCT0250017 = (System.Nullable<System.Int32>)reader[154];
            }
            if(reader[155] != DBNull.Value)
            {
                PCT0250018 = (System.Nullable<System.Int32>)reader[155];
            }
            if(reader[156] != DBNull.Value)
            {
                PCT0250019 = (System.Nullable<System.Int32>)reader[156];
            }
            if(reader[157] != DBNull.Value)
            {
                PCT0250020 = (System.Nullable<System.Int32>)reader[157];
            }
            if(reader[158] != DBNull.Value)
            {
                PCT0250021 = (System.Nullable<System.Int32>)reader[158];
            }
            if(reader[159] != DBNull.Value)
            {
                PCT0250022 = (System.Nullable<System.Int32>)reader[159];
            }
            if(reader[160] != DBNull.Value)
            {
                PCT0250023 = (System.Nullable<System.Int32>)reader[160];
            }
            if(reader[161] != DBNull.Value)
            {
                PCT0250024 = (System.Nullable<System.Int32>)reader[161];
            }
            if(reader[162] != DBNull.Value)
            {
                PCT0250025 = (System.Nullable<System.Int32>)reader[162];
            }
            if(reader[163] != DBNull.Value)
            {
                PCT0250026 = (System.Nullable<System.Int32>)reader[163];
            }
            if(reader[164] != DBNull.Value)
            {
                PCT0250027 = (System.Nullable<System.Int32>)reader[164];
            }
            if(reader[165] != DBNull.Value)
            {
                PCT0250028 = (System.Nullable<System.Int32>)reader[165];
            }
            if(reader[166] != DBNull.Value)
            {
                PCT0250029 = (System.Nullable<System.Int32>)reader[166];
            }
            if(reader[167] != DBNull.Value)
            {
                PCT0250030 = (System.Nullable<System.Int32>)reader[167];
            }
            if(reader[168] != DBNull.Value)
            {
                PCT0250031 = (System.Nullable<System.Int32>)reader[168];
            }
            if(reader[169] != DBNull.Value)
            {
                PCT0250032 = (System.Nullable<System.Int32>)reader[169];
            }
            if(reader[170] != DBNull.Value)
            {
                PCT0250033 = (System.Nullable<System.Int32>)reader[170];
            }
            if(reader[171] != DBNull.Value)
            {
                PCT0250034 = (System.Nullable<System.Int32>)reader[171];
            }
            if(reader[172] != DBNull.Value)
            {
                PCT0250035 = (System.Nullable<System.Int32>)reader[172];
            }
            if(reader[173] != DBNull.Value)
            {
                PCT0250036 = (System.Nullable<System.Int32>)reader[173];
            }
            if(reader[174] != DBNull.Value)
            {
                PCT0250037 = (System.Nullable<System.Int32>)reader[174];
            }
            if(reader[175] != DBNull.Value)
            {
                PCT0250038 = (System.Nullable<System.Int32>)reader[175];
            }
            if(reader[176] != DBNull.Value)
            {
                PCT0250039 = (System.Nullable<System.Int32>)reader[176];
            }
            if(reader[177] != DBNull.Value)
            {
                PCT0250040 = (System.Nullable<System.Int32>)reader[177];
            }
            if(reader[178] != DBNull.Value)
            {
                PCT0250041 = (System.Nullable<System.Int32>)reader[178];
            }
            if(reader[179] != DBNull.Value)
            {
                PCT0250042 = (System.Nullable<System.Int32>)reader[179];
            }
            if(reader[180] != DBNull.Value)
            {
                PCT0250043 = (System.Nullable<System.Int32>)reader[180];
            }
            if(reader[181] != DBNull.Value)
            {
                PCT0250044 = (System.Nullable<System.Int32>)reader[181];
            }
            if(reader[182] != DBNull.Value)
            {
                PCT0250045 = (System.Nullable<System.Int32>)reader[182];
            }
            if(reader[183] != DBNull.Value)
            {
                PCT0260001 = (System.Nullable<System.Int32>)reader[183];
            }
            if(reader[184] != DBNull.Value)
            {
                PCT0260002 = (System.Nullable<System.Int32>)reader[184];
            }
            if(reader[185] != DBNull.Value)
            {
                PCT0260003 = (System.Nullable<System.Int32>)reader[185];
            }
            if(reader[186] != DBNull.Value)
            {
                PCT0260004 = (System.Nullable<System.Int32>)reader[186];
            }
            if(reader[187] != DBNull.Value)
            {
                PCT0260005 = (System.Nullable<System.Int32>)reader[187];
            }
            if(reader[188] != DBNull.Value)
            {
                PCT0260006 = (System.Nullable<System.Int32>)reader[188];
            }
            if(reader[189] != DBNull.Value)
            {
                PCT0260007 = (System.Nullable<System.Int32>)reader[189];
            }
            if(reader[190] != DBNull.Value)
            {
                PCT0270001 = (System.Nullable<System.Int32>)reader[190];
            }
            if(reader[191] != DBNull.Value)
            {
                PCT0270002 = (System.Nullable<System.Int32>)reader[191];
            }
            if(reader[192] != DBNull.Value)
            {
                PCT0270003 = (System.Nullable<System.Int32>)reader[192];
            }
            if(reader[193] != DBNull.Value)
            {
                PCT0270004 = (System.Nullable<System.Int32>)reader[193];
            }
            if(reader[194] != DBNull.Value)
            {
                PCT0270005 = (System.Nullable<System.Int32>)reader[194];
            }
            if(reader[195] != DBNull.Value)
            {
                PCT0270006 = (System.Nullable<System.Int32>)reader[195];
            }
            if(reader[196] != DBNull.Value)
            {
                PCT0270007 = (System.Nullable<System.Int32>)reader[196];
            }
            if(reader[197] != DBNull.Value)
            {
                PCT0270008 = (System.Nullable<System.Int32>)reader[197];
            }
            if(reader[198] != DBNull.Value)
            {
                PCT0270009 = (System.Nullable<System.Int32>)reader[198];
            }
            if(reader[199] != DBNull.Value)
            {
                PCT0270010 = (System.Nullable<System.Int32>)reader[199];
            }
            if(reader[200] != DBNull.Value)
            {
                PCT0270011 = (System.Nullable<System.Int32>)reader[200];
            }
            if(reader[201] != DBNull.Value)
            {
                PCT0270012 = (System.Nullable<System.Int32>)reader[201];
            }
            if(reader[202] != DBNull.Value)
            {
                PCT0270013 = (System.Nullable<System.Int32>)reader[202];
            }
            if(reader[203] != DBNull.Value)
            {
                PCT0270014 = (System.Nullable<System.Int32>)reader[203];
            }
            if(reader[204] != DBNull.Value)
            {
                PCT0270015 = (System.Nullable<System.Int32>)reader[204];
            }
            if(reader[205] != DBNull.Value)
            {
                PCT0270016 = (System.Nullable<System.Int32>)reader[205];
            }
            if(reader[206] != DBNull.Value)
            {
                PCT0270017 = (System.Nullable<System.Int32>)reader[206];
            }
            if(reader[207] != DBNull.Value)
            {
                PCT0270018 = (System.Nullable<System.Int32>)reader[207];
            }
            if(reader[208] != DBNull.Value)
            {
                PCT0280001 = (System.Nullable<System.Int32>)reader[208];
            }
            if(reader[209] != DBNull.Value)
            {
                PCT0280002 = (System.Nullable<System.Int32>)reader[209];
            }
            if(reader[210] != DBNull.Value)
            {
                PCT0280003 = (System.Nullable<System.Int32>)reader[210];
            }
            if(reader[211] != DBNull.Value)
            {
                PCT0280004 = (System.Nullable<System.Int32>)reader[211];
            }
            if(reader[212] != DBNull.Value)
            {
                PCT0280005 = (System.Nullable<System.Int32>)reader[212];
            }
            if(reader[213] != DBNull.Value)
            {
                PCT0280006 = (System.Nullable<System.Int32>)reader[213];
            }
            if(reader[214] != DBNull.Value)
            {
                PCT0280007 = (System.Nullable<System.Int32>)reader[214];
            }
            if(reader[215] != DBNull.Value)
            {
                PCT0280008 = (System.Nullable<System.Int32>)reader[215];
            }
            if(reader[216] != DBNull.Value)
            {
                PCT0280009 = (System.Nullable<System.Int32>)reader[216];
            }
            if(reader[217] != DBNull.Value)
            {
                PCT0280010 = (System.Nullable<System.Int32>)reader[217];
            }
            if(reader[218] != DBNull.Value)
            {
                PCT0280011 = (System.Nullable<System.Int32>)reader[218];
            }
            if(reader[219] != DBNull.Value)
            {
                PCT0280012 = (System.Nullable<System.Int32>)reader[219];
            }
            if(reader[220] != DBNull.Value)
            {
                PCT0280013 = (System.Nullable<System.Int32>)reader[220];
            }
            if(reader[221] != DBNull.Value)
            {
                PCT0280014 = (System.Nullable<System.Int32>)reader[221];
            }
            if(reader[222] != DBNull.Value)
            {
                PCT0280015 = (System.Nullable<System.Int32>)reader[222];
            }
            if(reader[223] != DBNull.Value)
            {
                PCT0280016 = (System.Nullable<System.Int32>)reader[223];
            }
            if(reader[224] != DBNull.Value)
            {
                PCT0280017 = (System.Nullable<System.Int32>)reader[224];
            }
            if(reader[225] != DBNull.Value)
            {
                PCT0280018 = (System.Nullable<System.Int32>)reader[225];
            }
            if(reader[226] != DBNull.Value)
            {
                PCT0280019 = (System.Nullable<System.Int32>)reader[226];
            }
            if(reader[227] != DBNull.Value)
            {
                PCT0280020 = (System.Nullable<System.Int32>)reader[227];
            }
            if(reader[228] != DBNull.Value)
            {
                PCT0280021 = (System.Nullable<System.Int32>)reader[228];
            }
            if(reader[229] != DBNull.Value)
            {
                PCT0280022 = (System.Nullable<System.Int32>)reader[229];
            }
            if(reader[230] != DBNull.Value)
            {
                PCT0280023 = (System.Nullable<System.Int32>)reader[230];
            }
            if(reader[231] != DBNull.Value)
            {
                PCT0290001 = (System.Nullable<System.Int32>)reader[231];
            }
            if(reader[232] != DBNull.Value)
            {
                PCT0300001 = (System.Nullable<System.Int32>)reader[232];
            }
            if(reader[233] != DBNull.Value)
            {
                PCT0300002 = (System.Nullable<System.Int32>)reader[233];
            }
            if(reader[234] != DBNull.Value)
            {
                PCT0300003 = (System.Nullable<System.Int32>)reader[234];
            }
            if(reader[235] != DBNull.Value)
            {
                PCT0310001 = (System.Nullable<System.Double>)reader[235];
            }
            if(reader[236] != DBNull.Value)
            {
                PCT0310002 = (System.Nullable<System.Double>)reader[236];
            }
            if(reader[237] != DBNull.Value)
            {
                PCT0310003 = (System.Nullable<System.Double>)reader[237];
            }
        }
        #endregion Constructors
    }
}