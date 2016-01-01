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

    [Table("SF2_Segment_07")]
    public partial class SF2_Segment_07 : BaseModel
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
        [Column("PCT0390001", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public System.Nullable<System.Int32> PCT0390001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390002", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Male:", ShortName = "Male:", Order = 6)]
        public System.Nullable<System.Int32> PCT0390002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390003", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years:", ShortName = "Under 18 years:", Order = 7)]
        public System.Nullable<System.Int32> PCT0390003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390004", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 8)]
        public System.Nullable<System.Int32> PCT0390004 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390005", Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 9)]
        public System.Nullable<System.Int32> PCT0390005 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390006", Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 10)]
        public System.Nullable<System.Int32> PCT0390006 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390007", Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 11)]
        public System.Nullable<System.Int32> PCT0390007 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390008", Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 12)]
        public System.Nullable<System.Int32> PCT0390008 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390009", Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 13)]
        public System.Nullable<System.Int32> PCT0390009 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390010", Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 14)]
        public System.Nullable<System.Int32> PCT0390010 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390011", Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 15)]
        public System.Nullable<System.Int32> PCT0390011 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390012", Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 16)]
        public System.Nullable<System.Int32> PCT0390012 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390013", Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 17)]
        public System.Nullable<System.Int32> PCT0390013 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390014", Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 18)]
        public System.Nullable<System.Int32> PCT0390014 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390015", Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 19)]
        public System.Nullable<System.Int32> PCT0390015 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390016", Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 20)]
        public System.Nullable<System.Int32> PCT0390016 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390017", Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 21)]
        public System.Nullable<System.Int32> PCT0390017 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390018", Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 22)]
        public System.Nullable<System.Int32> PCT0390018 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390019", Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 23)]
        public System.Nullable<System.Int32> PCT0390019 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390020", Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 24)]
        public System.Nullable<System.Int32> PCT0390020 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390021", Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 25)]
        public System.Nullable<System.Int32> PCT0390021 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390022", Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 26)]
        public System.Nullable<System.Int32> PCT0390022 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390023", Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 27)]
        public System.Nullable<System.Int32> PCT0390023 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390024", Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 28)]
        public System.Nullable<System.Int32> PCT0390024 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390025", Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 29)]
        public System.Nullable<System.Int32> PCT0390025 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390026", Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 30)]
        public System.Nullable<System.Int32> PCT0390026 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390027", Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 31)]
        public System.Nullable<System.Int32> PCT0390027 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390028", Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 32)]
        public System.Nullable<System.Int32> PCT0390028 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390029", Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 33)]
        public System.Nullable<System.Int32> PCT0390029 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390030", Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 34)]
        public System.Nullable<System.Int32> PCT0390030 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390031", Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 35)]
        public System.Nullable<System.Int32> PCT0390031 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390032", Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 36)]
        public System.Nullable<System.Int32> PCT0390032 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390033", Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 37)]
        public System.Nullable<System.Int32> PCT0390033 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390034", Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 38)]
        public System.Nullable<System.Int32> PCT0390034 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390035", Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 to 64 years:", ShortName = "18 to 64 years:", Order = 39)]
        public System.Nullable<System.Int32> PCT0390035 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390036", Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 40)]
        public System.Nullable<System.Int32> PCT0390036 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390037", Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 41)]
        public System.Nullable<System.Int32> PCT0390037 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390038", Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 42)]
        public System.Nullable<System.Int32> PCT0390038 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390039", Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 43)]
        public System.Nullable<System.Int32> PCT0390039 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390040", Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 44)]
        public System.Nullable<System.Int32> PCT0390040 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390041", Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 45)]
        public System.Nullable<System.Int32> PCT0390041 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390042", Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 46)]
        public System.Nullable<System.Int32> PCT0390042 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390043", Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 47)]
        public System.Nullable<System.Int32> PCT0390043 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390044", Order = 48)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 48)]
        public System.Nullable<System.Int32> PCT0390044 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390045", Order = 49)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 49)]
        public System.Nullable<System.Int32> PCT0390045 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390046", Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 50)]
        public System.Nullable<System.Int32> PCT0390046 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390047", Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 51)]
        public System.Nullable<System.Int32> PCT0390047 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390048", Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 52)]
        public System.Nullable<System.Int32> PCT0390048 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390049", Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 53)]
        public System.Nullable<System.Int32> PCT0390049 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390050", Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 54)]
        public System.Nullable<System.Int32> PCT0390050 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390051", Order = 55)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 55)]
        public System.Nullable<System.Int32> PCT0390051 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390052", Order = 56)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 56)]
        public System.Nullable<System.Int32> PCT0390052 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390053", Order = 57)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 57)]
        public System.Nullable<System.Int32> PCT0390053 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390054", Order = 58)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 58)]
        public System.Nullable<System.Int32> PCT0390054 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390055", Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 59)]
        public System.Nullable<System.Int32> PCT0390055 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390056", Order = 60)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 60)]
        public System.Nullable<System.Int32> PCT0390056 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390057", Order = 61)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 61)]
        public System.Nullable<System.Int32> PCT0390057 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390058", Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 62)]
        public System.Nullable<System.Int32> PCT0390058 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390059", Order = 63)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 63)]
        public System.Nullable<System.Int32> PCT0390059 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390060", Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 64)]
        public System.Nullable<System.Int32> PCT0390060 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390061", Order = 65)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 65)]
        public System.Nullable<System.Int32> PCT0390061 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390062", Order = 66)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 66)]
        public System.Nullable<System.Int32> PCT0390062 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390063", Order = 67)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 67)]
        public System.Nullable<System.Int32> PCT0390063 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390064", Order = 68)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 68)]
        public System.Nullable<System.Int32> PCT0390064 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390065", Order = 69)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 69)]
        public System.Nullable<System.Int32> PCT0390065 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390066", Order = 70)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 70)]
        public System.Nullable<System.Int32> PCT0390066 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390067", Order = 71)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 years and over:", ShortName = "65 years and over:", Order = 71)]
        public System.Nullable<System.Int32> PCT0390067 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390068", Order = 72)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 72)]
        public System.Nullable<System.Int32> PCT0390068 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390069", Order = 73)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 73)]
        public System.Nullable<System.Int32> PCT0390069 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390070", Order = 74)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 74)]
        public System.Nullable<System.Int32> PCT0390070 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390071", Order = 75)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 75)]
        public System.Nullable<System.Int32> PCT0390071 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390072", Order = 76)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 76)]
        public System.Nullable<System.Int32> PCT0390072 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390073", Order = 77)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 77)]
        public System.Nullable<System.Int32> PCT0390073 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390074", Order = 78)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 78)]
        public System.Nullable<System.Int32> PCT0390074 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390075", Order = 79)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 79)]
        public System.Nullable<System.Int32> PCT0390075 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390076", Order = 80)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 80)]
        public System.Nullable<System.Int32> PCT0390076 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390077", Order = 81)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 81)]
        public System.Nullable<System.Int32> PCT0390077 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390078", Order = 82)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 82)]
        public System.Nullable<System.Int32> PCT0390078 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390079", Order = 83)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 83)]
        public System.Nullable<System.Int32> PCT0390079 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390080", Order = 84)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 84)]
        public System.Nullable<System.Int32> PCT0390080 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390081", Order = 85)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 85)]
        public System.Nullable<System.Int32> PCT0390081 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390082", Order = 86)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 86)]
        public System.Nullable<System.Int32> PCT0390082 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390083", Order = 87)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 87)]
        public System.Nullable<System.Int32> PCT0390083 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390084", Order = 88)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 88)]
        public System.Nullable<System.Int32> PCT0390084 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390085", Order = 89)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 89)]
        public System.Nullable<System.Int32> PCT0390085 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390086", Order = 90)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 90)]
        public System.Nullable<System.Int32> PCT0390086 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390087", Order = 91)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 91)]
        public System.Nullable<System.Int32> PCT0390087 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390088", Order = 92)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 92)]
        public System.Nullable<System.Int32> PCT0390088 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390089", Order = 93)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 93)]
        public System.Nullable<System.Int32> PCT0390089 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390090", Order = 94)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 94)]
        public System.Nullable<System.Int32> PCT0390090 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390091", Order = 95)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 95)]
        public System.Nullable<System.Int32> PCT0390091 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390092", Order = 96)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 96)]
        public System.Nullable<System.Int32> PCT0390092 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390093", Order = 97)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 97)]
        public System.Nullable<System.Int32> PCT0390093 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390094", Order = 98)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 98)]
        public System.Nullable<System.Int32> PCT0390094 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390095", Order = 99)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 99)]
        public System.Nullable<System.Int32> PCT0390095 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390096", Order = 100)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 100)]
        public System.Nullable<System.Int32> PCT0390096 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390097", Order = 101)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 101)]
        public System.Nullable<System.Int32> PCT0390097 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390098", Order = 102)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 102)]
        public System.Nullable<System.Int32> PCT0390098 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390099", Order = 103)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Female:", ShortName = "Female:", Order = 103)]
        public System.Nullable<System.Int32> PCT0390099 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390100", Order = 104)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Under 18 years:", ShortName = "Under 18 years:", Order = 104)]
        public System.Nullable<System.Int32> PCT0390100 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390101", Order = 105)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 105)]
        public System.Nullable<System.Int32> PCT0390101 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390102", Order = 106)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 106)]
        public System.Nullable<System.Int32> PCT0390102 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390103", Order = 107)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 107)]
        public System.Nullable<System.Int32> PCT0390103 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390104", Order = 108)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 108)]
        public System.Nullable<System.Int32> PCT0390104 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390105", Order = 109)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 109)]
        public System.Nullable<System.Int32> PCT0390105 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390106", Order = 110)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 110)]
        public System.Nullable<System.Int32> PCT0390106 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390107", Order = 111)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 111)]
        public System.Nullable<System.Int32> PCT0390107 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390108", Order = 112)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 112)]
        public System.Nullable<System.Int32> PCT0390108 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390109", Order = 113)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 113)]
        public System.Nullable<System.Int32> PCT0390109 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390110", Order = 114)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 114)]
        public System.Nullable<System.Int32> PCT0390110 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390111", Order = 115)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 115)]
        public System.Nullable<System.Int32> PCT0390111 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390112", Order = 116)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 116)]
        public System.Nullable<System.Int32> PCT0390112 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390113", Order = 117)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 117)]
        public System.Nullable<System.Int32> PCT0390113 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390114", Order = 118)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 118)]
        public System.Nullable<System.Int32> PCT0390114 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390115", Order = 119)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 119)]
        public System.Nullable<System.Int32> PCT0390115 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390116", Order = 120)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 120)]
        public System.Nullable<System.Int32> PCT0390116 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390117", Order = 121)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 121)]
        public System.Nullable<System.Int32> PCT0390117 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390118", Order = 122)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 122)]
        public System.Nullable<System.Int32> PCT0390118 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390119", Order = 123)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 123)]
        public System.Nullable<System.Int32> PCT0390119 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390120", Order = 124)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 124)]
        public System.Nullable<System.Int32> PCT0390120 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390121", Order = 125)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 125)]
        public System.Nullable<System.Int32> PCT0390121 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390122", Order = 126)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 126)]
        public System.Nullable<System.Int32> PCT0390122 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390123", Order = 127)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 127)]
        public System.Nullable<System.Int32> PCT0390123 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390124", Order = 128)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 128)]
        public System.Nullable<System.Int32> PCT0390124 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390125", Order = 129)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 129)]
        public System.Nullable<System.Int32> PCT0390125 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390126", Order = 130)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 130)]
        public System.Nullable<System.Int32> PCT0390126 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390127", Order = 131)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 131)]
        public System.Nullable<System.Int32> PCT0390127 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390128", Order = 132)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 132)]
        public System.Nullable<System.Int32> PCT0390128 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390129", Order = 133)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 133)]
        public System.Nullable<System.Int32> PCT0390129 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390130", Order = 134)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 134)]
        public System.Nullable<System.Int32> PCT0390130 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390131", Order = 135)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 135)]
        public System.Nullable<System.Int32> PCT0390131 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390132", Order = 136)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "18 to 64 years:", ShortName = "18 to 64 years:", Order = 136)]
        public System.Nullable<System.Int32> PCT0390132 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390133", Order = 137)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 137)]
        public System.Nullable<System.Int32> PCT0390133 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390134", Order = 138)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 138)]
        public System.Nullable<System.Int32> PCT0390134 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390135", Order = 139)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 139)]
        public System.Nullable<System.Int32> PCT0390135 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390136", Order = 140)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 140)]
        public System.Nullable<System.Int32> PCT0390136 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390137", Order = 141)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 141)]
        public System.Nullable<System.Int32> PCT0390137 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390138", Order = 142)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 142)]
        public System.Nullable<System.Int32> PCT0390138 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390139", Order = 143)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 143)]
        public System.Nullable<System.Int32> PCT0390139 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390140", Order = 144)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 144)]
        public System.Nullable<System.Int32> PCT0390140 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390141", Order = 145)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 145)]
        public System.Nullable<System.Int32> PCT0390141 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390142", Order = 146)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 146)]
        public System.Nullable<System.Int32> PCT0390142 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390143", Order = 147)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 147)]
        public System.Nullable<System.Int32> PCT0390143 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390144", Order = 148)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 148)]
        public System.Nullable<System.Int32> PCT0390144 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390145", Order = 149)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 149)]
        public System.Nullable<System.Int32> PCT0390145 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390146", Order = 150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 150)]
        public System.Nullable<System.Int32> PCT0390146 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390147", Order = 151)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 151)]
        public System.Nullable<System.Int32> PCT0390147 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390148", Order = 152)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 152)]
        public System.Nullable<System.Int32> PCT0390148 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390149", Order = 153)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 153)]
        public System.Nullable<System.Int32> PCT0390149 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390150", Order = 154)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 154)]
        public System.Nullable<System.Int32> PCT0390150 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390151", Order = 155)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 155)]
        public System.Nullable<System.Int32> PCT0390151 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390152", Order = 156)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 156)]
        public System.Nullable<System.Int32> PCT0390152 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390153", Order = 157)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 157)]
        public System.Nullable<System.Int32> PCT0390153 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390154", Order = 158)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 158)]
        public System.Nullable<System.Int32> PCT0390154 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390155", Order = 159)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 159)]
        public System.Nullable<System.Int32> PCT0390155 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390156", Order = 160)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 160)]
        public System.Nullable<System.Int32> PCT0390156 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390157", Order = 161)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 161)]
        public System.Nullable<System.Int32> PCT0390157 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390158", Order = 162)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 162)]
        public System.Nullable<System.Int32> PCT0390158 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390159", Order = 163)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 163)]
        public System.Nullable<System.Int32> PCT0390159 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390160", Order = 164)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 164)]
        public System.Nullable<System.Int32> PCT0390160 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390161", Order = 165)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 165)]
        public System.Nullable<System.Int32> PCT0390161 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390162", Order = 166)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 166)]
        public System.Nullable<System.Int32> PCT0390162 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390163", Order = 167)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 167)]
        public System.Nullable<System.Int32> PCT0390163 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390164", Order = 168)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "65 years and over:", ShortName = "65 years and over:", Order = 168)]
        public System.Nullable<System.Int32> PCT0390164 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390165", Order = 169)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Institutionalized population (101-106, 201-203, 301, 401-405):", ShortName = "Institutionalized population (101-106, 201-203, 301, 401-405):", Order = 169)]
        public System.Nullable<System.Int32> PCT0390165 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390166", Order = 170)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities for adults (101-106):", ShortName = "Correctional facilities for adults (101-106):", Order = 170)]
        public System.Nullable<System.Int32> PCT0390166 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390167", Order = 171)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal detention centers (101)", ShortName = "Federal detention centers (101)", Order = 171)]
        public System.Nullable<System.Int32> PCT0390167 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390168", Order = 172)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Federal prisons (102)", ShortName = "Federal prisons (102)", Order = 172)]
        public System.Nullable<System.Int32> PCT0390168 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390169", Order = 173)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "State prisons (103)", ShortName = "State prisons (103)", Order = 173)]
        public System.Nullable<System.Int32> PCT0390169 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390170", Order = 174)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Local jails and other municipal confinement facilities (104)", ShortName = "Local jails and other municipal confinement facilities (104)", Order = 174)]
        public System.Nullable<System.Int32> PCT0390170 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390171", Order = 175)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional residential facilities (105)", ShortName = "Correctional residential facilities (105)", Order = 175)]
        public System.Nullable<System.Int32> PCT0390171 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390172", Order = 176)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military disciplinary barracks and jails (106)", ShortName = "Military disciplinary barracks and jails (106)", Order = 176)]
        public System.Nullable<System.Int32> PCT0390172 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390173", Order = 177)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Juvenile facilities (201-203):", ShortName = "Juvenile facilities (201-203):", Order = 177)]
        public System.Nullable<System.Int32> PCT0390173 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390174", Order = 178)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes for juveniles (non-correctional) (201)", ShortName = "Group homes for juveniles (non-correctional) (201)", Order = 178)]
        public System.Nullable<System.Int32> PCT0390174 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390175", Order = 179)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for juveniles (non-correctional) (202)", ShortName = "Residential treatment centers for juveniles (non-correctional) (202)", Order = 179)]
        public System.Nullable<System.Int32> PCT0390175 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390176", Order = 180)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Correctional facilities intended for juveniles (203)", ShortName = "Correctional facilities intended for juveniles (203)", Order = 180)]
        public System.Nullable<System.Int32> PCT0390176 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390177", Order = 181)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Nursing facilities/Skilled-nursing facilities (301)", ShortName = "Nursing facilities/Skilled-nursing facilities (301)", Order = 181)]
        public System.Nullable<System.Int32> PCT0390177 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390178", Order = 182)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other institutional facilities (401-405):", ShortName = "Other institutional facilities (401-405):", Order = 182)]
        public System.Nullable<System.Int32> PCT0390178 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390179", Order = 183)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", ShortName = "Mental (Psychiatric) hospitals and psychiatric units in other hospitals (401)", Order = 183)]
        public System.Nullable<System.Int32> PCT0390179 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390180", Order = 184)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Hospitals with patients who have no usual home elsewhere (402)", ShortName = "Hospitals with patients who have no usual home elsewhere (402)", Order = 184)]
        public System.Nullable<System.Int32> PCT0390180 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390181", Order = 185)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "In-patient hospice facilities (403)", ShortName = "In-patient hospice facilities (403)", Order = 185)]
        public System.Nullable<System.Int32> PCT0390181 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390182", Order = 186)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military treatment facilities with assigned patients (404)", ShortName = "Military treatment facilities with assigned patients (404)", Order = 186)]
        public System.Nullable<System.Int32> PCT0390182 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390183", Order = 187)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential schools for people with disabilities (405)", ShortName = "Residential schools for people with disabilities (405)", Order = 187)]
        public System.Nullable<System.Int32> PCT0390183 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390184", Order = 188)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Noninstitutionalized population (501, 601-602, 701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 188)]
        public System.Nullable<System.Int32> PCT0390184 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390185", Order = 189)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "College/University student housing (501)", ShortName = "College/University student housing (501)", Order = 189)]
        public System.Nullable<System.Int32> PCT0390185 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390186", Order = 190)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military quarters (601-602):", ShortName = "Military quarters (601-602):", Order = 190)]
        public System.Nullable<System.Int32> PCT0390186 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390187", Order = 191)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military barracks and dormitories (non-disciplinary) (601)", ShortName = "Military barracks and dormitories (non-disciplinary) (601)", Order = 191)]
        public System.Nullable<System.Int32> PCT0390187 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390188", Order = 192)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Military ships (602)", ShortName = "Military ships (602)", Order = 192)]
        public System.Nullable<System.Int32> PCT0390188 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390189", Order = 193)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", ShortName = "Other noninstitutional facilities (701-702, 704, 706, 801-802, 900-901, 903-904):", Order = 193)]
        public System.Nullable<System.Int32> PCT0390189 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390190", Order = 194)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", ShortName = "Emergency and transitional shelters (with sleeping facilities) for people experiencing homelessness (701)", Order = 194)]
        public System.Nullable<System.Int32> PCT0390190 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390191", Order = 195)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Group homes intended for adults (801)", ShortName = "Group homes intended for adults (801)", Order = 195)]
        public System.Nullable<System.Int32> PCT0390191 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390192", Order = 196)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Residential treatment centers for adults (802)", ShortName = "Residential treatment centers for adults (802)", Order = 196)]
        public System.Nullable<System.Int32> PCT0390192 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390193", Order = 197)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Maritime/merchant vessels (900)", ShortName = "Maritime/merchant vessels (900)", Order = 197)]
        public System.Nullable<System.Int32> PCT0390193 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390194", Order = 198)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Workers' group living quarters and Job Corps centers (901)", ShortName = "Workers' group living quarters and Job Corps centers (901)", Order = 198)]
        public System.Nullable<System.Int32> PCT0390194 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0390195", Order = 199)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Other noninstitutional facilities (702, 704, 706, 903-904)", ShortName = "Other noninstitutional facilities (702, 704, 706, 903-904)", Order = 199)]
        public System.Nullable<System.Int32> PCT0390195 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0400001", Order = 200)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 200)]
        public System.Nullable<System.Int32> PCT0400001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0400002", Order = 201)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not substituted", ShortName = "Not substituted", Order = 201)]
        public System.Nullable<System.Int32> PCT0400002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0400003", Order = 202)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Substituted", ShortName = "Substituted", Order = 202)]
        public System.Nullable<System.Int32> PCT0400003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0410001", Order = 203)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 203)]
        public System.Nullable<System.Int32> PCT0410001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0410002", Order = 204)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No items allocated", ShortName = "No items allocated", Order = 204)]
        public System.Nullable<System.Int32> PCT0410002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0410003", Order = 205)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "One or more items allocated", ShortName = "One or more items allocated", Order = 205)]
        public System.Nullable<System.Int32> PCT0410003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0420001", Order = 206)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 206)]
        public System.Nullable<System.Int32> PCT0420001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0420002", Order = 207)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Allocated", ShortName = "Allocated", Order = 207)]
        public System.Nullable<System.Int32> PCT0420002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0420003", Order = 208)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not allocated", ShortName = "Not allocated", Order = 208)]
        public System.Nullable<System.Int32> PCT0420003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0430001", Order = 209)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 209)]
        public System.Nullable<System.Int32> PCT0430001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0430002", Order = 210)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Allocated", ShortName = "Allocated", Order = 210)]
        public System.Nullable<System.Int32> PCT0430002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0430003", Order = 211)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not allocated", ShortName = "Not allocated", Order = 211)]
        public System.Nullable<System.Int32> PCT0430003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0440001", Order = 212)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 212)]
        public System.Nullable<System.Int32> PCT0440001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0440002", Order = 213)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Allocated", ShortName = "Allocated", Order = 213)]
        public System.Nullable<System.Int32> PCT0440002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0440003", Order = 214)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not allocated", ShortName = "Not allocated", Order = 214)]
        public System.Nullable<System.Int32> PCT0440003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0450001", Order = 215)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 215)]
        public System.Nullable<System.Int32> PCT0450001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0450002", Order = 216)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Allocated", ShortName = "Allocated", Order = 216)]
        public System.Nullable<System.Int32> PCT0450002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0450003", Order = 217)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not allocated", ShortName = "Not allocated", Order = 217)]
        public System.Nullable<System.Int32> PCT0450003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0460001", Order = 218)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 218)]
        public System.Nullable<System.Int32> PCT0460001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0460002", Order = 219)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Allocated", ShortName = "Allocated", Order = 219)]
        public System.Nullable<System.Int32> PCT0460002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0460003", Order = 220)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Not allocated", ShortName = "Not allocated", Order = 220)]
        public System.Nullable<System.Int32> PCT0460003 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0470001", Order = 221)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Total:", ShortName = "Total:", Order = 221)]
        public System.Nullable<System.Int32> PCT0470001 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0470002", Order = 222)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "No items allocated", ShortName = "No items allocated", Order = 222)]
        public System.Nullable<System.Int32> PCT0470002 { get; set; }

        [ReadOnly(false)]
        [Column("PCT0470003", Order = 223)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "One or more items allocated", ShortName = "One or more items allocated", Order = 223)]
        public System.Nullable<System.Int32> PCT0470003 { get; set; }
        #endregion Properties

        #region Constructors
        public SF2_Segment_07(string csvLine) : base(csvLine) {}

        public SF2_Segment_07(string[] values) : base(values) {}

        public SF2_Segment_07(OleDbDataReader reader, CensusFileType fileType)
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
                PCT0390001 = (System.Nullable<System.Int32>)reader[5];
            }
            if(reader[6] != DBNull.Value)
            {
                PCT0390002 = (System.Nullable<System.Int32>)reader[6];
            }
            if(reader[7] != DBNull.Value)
            {
                PCT0390003 = (System.Nullable<System.Int32>)reader[7];
            }
            if(reader[8] != DBNull.Value)
            {
                PCT0390004 = (System.Nullable<System.Int32>)reader[8];
            }
            if(reader[9] != DBNull.Value)
            {
                PCT0390005 = (System.Nullable<System.Int32>)reader[9];
            }
            if(reader[10] != DBNull.Value)
            {
                PCT0390006 = (System.Nullable<System.Int32>)reader[10];
            }
            if(reader[11] != DBNull.Value)
            {
                PCT0390007 = (System.Nullable<System.Int32>)reader[11];
            }
            if(reader[12] != DBNull.Value)
            {
                PCT0390008 = (System.Nullable<System.Int32>)reader[12];
            }
            if(reader[13] != DBNull.Value)
            {
                PCT0390009 = (System.Nullable<System.Int32>)reader[13];
            }
            if(reader[14] != DBNull.Value)
            {
                PCT0390010 = (System.Nullable<System.Int32>)reader[14];
            }
            if(reader[15] != DBNull.Value)
            {
                PCT0390011 = (System.Nullable<System.Int32>)reader[15];
            }
            if(reader[16] != DBNull.Value)
            {
                PCT0390012 = (System.Nullable<System.Int32>)reader[16];
            }
            if(reader[17] != DBNull.Value)
            {
                PCT0390013 = (System.Nullable<System.Int32>)reader[17];
            }
            if(reader[18] != DBNull.Value)
            {
                PCT0390014 = (System.Nullable<System.Int32>)reader[18];
            }
            if(reader[19] != DBNull.Value)
            {
                PCT0390015 = (System.Nullable<System.Int32>)reader[19];
            }
            if(reader[20] != DBNull.Value)
            {
                PCT0390016 = (System.Nullable<System.Int32>)reader[20];
            }
            if(reader[21] != DBNull.Value)
            {
                PCT0390017 = (System.Nullable<System.Int32>)reader[21];
            }
            if(reader[22] != DBNull.Value)
            {
                PCT0390018 = (System.Nullable<System.Int32>)reader[22];
            }
            if(reader[23] != DBNull.Value)
            {
                PCT0390019 = (System.Nullable<System.Int32>)reader[23];
            }
            if(reader[24] != DBNull.Value)
            {
                PCT0390020 = (System.Nullable<System.Int32>)reader[24];
            }
            if(reader[25] != DBNull.Value)
            {
                PCT0390021 = (System.Nullable<System.Int32>)reader[25];
            }
            if(reader[26] != DBNull.Value)
            {
                PCT0390022 = (System.Nullable<System.Int32>)reader[26];
            }
            if(reader[27] != DBNull.Value)
            {
                PCT0390023 = (System.Nullable<System.Int32>)reader[27];
            }
            if(reader[28] != DBNull.Value)
            {
                PCT0390024 = (System.Nullable<System.Int32>)reader[28];
            }
            if(reader[29] != DBNull.Value)
            {
                PCT0390025 = (System.Nullable<System.Int32>)reader[29];
            }
            if(reader[30] != DBNull.Value)
            {
                PCT0390026 = (System.Nullable<System.Int32>)reader[30];
            }
            if(reader[31] != DBNull.Value)
            {
                PCT0390027 = (System.Nullable<System.Int32>)reader[31];
            }
            if(reader[32] != DBNull.Value)
            {
                PCT0390028 = (System.Nullable<System.Int32>)reader[32];
            }
            if(reader[33] != DBNull.Value)
            {
                PCT0390029 = (System.Nullable<System.Int32>)reader[33];
            }
            if(reader[34] != DBNull.Value)
            {
                PCT0390030 = (System.Nullable<System.Int32>)reader[34];
            }
            if(reader[35] != DBNull.Value)
            {
                PCT0390031 = (System.Nullable<System.Int32>)reader[35];
            }
            if(reader[36] != DBNull.Value)
            {
                PCT0390032 = (System.Nullable<System.Int32>)reader[36];
            }
            if(reader[37] != DBNull.Value)
            {
                PCT0390033 = (System.Nullable<System.Int32>)reader[37];
            }
            if(reader[38] != DBNull.Value)
            {
                PCT0390034 = (System.Nullable<System.Int32>)reader[38];
            }
            if(reader[39] != DBNull.Value)
            {
                PCT0390035 = (System.Nullable<System.Int32>)reader[39];
            }
            if(reader[40] != DBNull.Value)
            {
                PCT0390036 = (System.Nullable<System.Int32>)reader[40];
            }
            if(reader[41] != DBNull.Value)
            {
                PCT0390037 = (System.Nullable<System.Int32>)reader[41];
            }
            if(reader[42] != DBNull.Value)
            {
                PCT0390038 = (System.Nullable<System.Int32>)reader[42];
            }
            if(reader[43] != DBNull.Value)
            {
                PCT0390039 = (System.Nullable<System.Int32>)reader[43];
            }
            if(reader[44] != DBNull.Value)
            {
                PCT0390040 = (System.Nullable<System.Int32>)reader[44];
            }
            if(reader[45] != DBNull.Value)
            {
                PCT0390041 = (System.Nullable<System.Int32>)reader[45];
            }
            if(reader[46] != DBNull.Value)
            {
                PCT0390042 = (System.Nullable<System.Int32>)reader[46];
            }
            if(reader[47] != DBNull.Value)
            {
                PCT0390043 = (System.Nullable<System.Int32>)reader[47];
            }
            if(reader[48] != DBNull.Value)
            {
                PCT0390044 = (System.Nullable<System.Int32>)reader[48];
            }
            if(reader[49] != DBNull.Value)
            {
                PCT0390045 = (System.Nullable<System.Int32>)reader[49];
            }
            if(reader[50] != DBNull.Value)
            {
                PCT0390046 = (System.Nullable<System.Int32>)reader[50];
            }
            if(reader[51] != DBNull.Value)
            {
                PCT0390047 = (System.Nullable<System.Int32>)reader[51];
            }
            if(reader[52] != DBNull.Value)
            {
                PCT0390048 = (System.Nullable<System.Int32>)reader[52];
            }
            if(reader[53] != DBNull.Value)
            {
                PCT0390049 = (System.Nullable<System.Int32>)reader[53];
            }
            if(reader[54] != DBNull.Value)
            {
                PCT0390050 = (System.Nullable<System.Int32>)reader[54];
            }
            if(reader[55] != DBNull.Value)
            {
                PCT0390051 = (System.Nullable<System.Int32>)reader[55];
            }
            if(reader[56] != DBNull.Value)
            {
                PCT0390052 = (System.Nullable<System.Int32>)reader[56];
            }
            if(reader[57] != DBNull.Value)
            {
                PCT0390053 = (System.Nullable<System.Int32>)reader[57];
            }
            if(reader[58] != DBNull.Value)
            {
                PCT0390054 = (System.Nullable<System.Int32>)reader[58];
            }
            if(reader[59] != DBNull.Value)
            {
                PCT0390055 = (System.Nullable<System.Int32>)reader[59];
            }
            if(reader[60] != DBNull.Value)
            {
                PCT0390056 = (System.Nullable<System.Int32>)reader[60];
            }
            if(reader[61] != DBNull.Value)
            {
                PCT0390057 = (System.Nullable<System.Int32>)reader[61];
            }
            if(reader[62] != DBNull.Value)
            {
                PCT0390058 = (System.Nullable<System.Int32>)reader[62];
            }
            if(reader[63] != DBNull.Value)
            {
                PCT0390059 = (System.Nullable<System.Int32>)reader[63];
            }
            if(reader[64] != DBNull.Value)
            {
                PCT0390060 = (System.Nullable<System.Int32>)reader[64];
            }
            if(reader[65] != DBNull.Value)
            {
                PCT0390061 = (System.Nullable<System.Int32>)reader[65];
            }
            if(reader[66] != DBNull.Value)
            {
                PCT0390062 = (System.Nullable<System.Int32>)reader[66];
            }
            if(reader[67] != DBNull.Value)
            {
                PCT0390063 = (System.Nullable<System.Int32>)reader[67];
            }
            if(reader[68] != DBNull.Value)
            {
                PCT0390064 = (System.Nullable<System.Int32>)reader[68];
            }
            if(reader[69] != DBNull.Value)
            {
                PCT0390065 = (System.Nullable<System.Int32>)reader[69];
            }
            if(reader[70] != DBNull.Value)
            {
                PCT0390066 = (System.Nullable<System.Int32>)reader[70];
            }
            if(reader[71] != DBNull.Value)
            {
                PCT0390067 = (System.Nullable<System.Int32>)reader[71];
            }
            if(reader[72] != DBNull.Value)
            {
                PCT0390068 = (System.Nullable<System.Int32>)reader[72];
            }
            if(reader[73] != DBNull.Value)
            {
                PCT0390069 = (System.Nullable<System.Int32>)reader[73];
            }
            if(reader[74] != DBNull.Value)
            {
                PCT0390070 = (System.Nullable<System.Int32>)reader[74];
            }
            if(reader[75] != DBNull.Value)
            {
                PCT0390071 = (System.Nullable<System.Int32>)reader[75];
            }
            if(reader[76] != DBNull.Value)
            {
                PCT0390072 = (System.Nullable<System.Int32>)reader[76];
            }
            if(reader[77] != DBNull.Value)
            {
                PCT0390073 = (System.Nullable<System.Int32>)reader[77];
            }
            if(reader[78] != DBNull.Value)
            {
                PCT0390074 = (System.Nullable<System.Int32>)reader[78];
            }
            if(reader[79] != DBNull.Value)
            {
                PCT0390075 = (System.Nullable<System.Int32>)reader[79];
            }
            if(reader[80] != DBNull.Value)
            {
                PCT0390076 = (System.Nullable<System.Int32>)reader[80];
            }
            if(reader[81] != DBNull.Value)
            {
                PCT0390077 = (System.Nullable<System.Int32>)reader[81];
            }
            if(reader[82] != DBNull.Value)
            {
                PCT0390078 = (System.Nullable<System.Int32>)reader[82];
            }
            if(reader[83] != DBNull.Value)
            {
                PCT0390079 = (System.Nullable<System.Int32>)reader[83];
            }
            if(reader[84] != DBNull.Value)
            {
                PCT0390080 = (System.Nullable<System.Int32>)reader[84];
            }
            if(reader[85] != DBNull.Value)
            {
                PCT0390081 = (System.Nullable<System.Int32>)reader[85];
            }
            if(reader[86] != DBNull.Value)
            {
                PCT0390082 = (System.Nullable<System.Int32>)reader[86];
            }
            if(reader[87] != DBNull.Value)
            {
                PCT0390083 = (System.Nullable<System.Int32>)reader[87];
            }
            if(reader[88] != DBNull.Value)
            {
                PCT0390084 = (System.Nullable<System.Int32>)reader[88];
            }
            if(reader[89] != DBNull.Value)
            {
                PCT0390085 = (System.Nullable<System.Int32>)reader[89];
            }
            if(reader[90] != DBNull.Value)
            {
                PCT0390086 = (System.Nullable<System.Int32>)reader[90];
            }
            if(reader[91] != DBNull.Value)
            {
                PCT0390087 = (System.Nullable<System.Int32>)reader[91];
            }
            if(reader[92] != DBNull.Value)
            {
                PCT0390088 = (System.Nullable<System.Int32>)reader[92];
            }
            if(reader[93] != DBNull.Value)
            {
                PCT0390089 = (System.Nullable<System.Int32>)reader[93];
            }
            if(reader[94] != DBNull.Value)
            {
                PCT0390090 = (System.Nullable<System.Int32>)reader[94];
            }
            if(reader[95] != DBNull.Value)
            {
                PCT0390091 = (System.Nullable<System.Int32>)reader[95];
            }
            if(reader[96] != DBNull.Value)
            {
                PCT0390092 = (System.Nullable<System.Int32>)reader[96];
            }
            if(reader[97] != DBNull.Value)
            {
                PCT0390093 = (System.Nullable<System.Int32>)reader[97];
            }
            if(reader[98] != DBNull.Value)
            {
                PCT0390094 = (System.Nullable<System.Int32>)reader[98];
            }
            if(reader[99] != DBNull.Value)
            {
                PCT0390095 = (System.Nullable<System.Int32>)reader[99];
            }
            if(reader[100] != DBNull.Value)
            {
                PCT0390096 = (System.Nullable<System.Int32>)reader[100];
            }
            if(reader[101] != DBNull.Value)
            {
                PCT0390097 = (System.Nullable<System.Int32>)reader[101];
            }
            if(reader[102] != DBNull.Value)
            {
                PCT0390098 = (System.Nullable<System.Int32>)reader[102];
            }
            if(reader[103] != DBNull.Value)
            {
                PCT0390099 = (System.Nullable<System.Int32>)reader[103];
            }
            if(reader[104] != DBNull.Value)
            {
                PCT0390100 = (System.Nullable<System.Int32>)reader[104];
            }
            if(reader[105] != DBNull.Value)
            {
                PCT0390101 = (System.Nullable<System.Int32>)reader[105];
            }
            if(reader[106] != DBNull.Value)
            {
                PCT0390102 = (System.Nullable<System.Int32>)reader[106];
            }
            if(reader[107] != DBNull.Value)
            {
                PCT0390103 = (System.Nullable<System.Int32>)reader[107];
            }
            if(reader[108] != DBNull.Value)
            {
                PCT0390104 = (System.Nullable<System.Int32>)reader[108];
            }
            if(reader[109] != DBNull.Value)
            {
                PCT0390105 = (System.Nullable<System.Int32>)reader[109];
            }
            if(reader[110] != DBNull.Value)
            {
                PCT0390106 = (System.Nullable<System.Int32>)reader[110];
            }
            if(reader[111] != DBNull.Value)
            {
                PCT0390107 = (System.Nullable<System.Int32>)reader[111];
            }
            if(reader[112] != DBNull.Value)
            {
                PCT0390108 = (System.Nullable<System.Int32>)reader[112];
            }
            if(reader[113] != DBNull.Value)
            {
                PCT0390109 = (System.Nullable<System.Int32>)reader[113];
            }
            if(reader[114] != DBNull.Value)
            {
                PCT0390110 = (System.Nullable<System.Int32>)reader[114];
            }
            if(reader[115] != DBNull.Value)
            {
                PCT0390111 = (System.Nullable<System.Int32>)reader[115];
            }
            if(reader[116] != DBNull.Value)
            {
                PCT0390112 = (System.Nullable<System.Int32>)reader[116];
            }
            if(reader[117] != DBNull.Value)
            {
                PCT0390113 = (System.Nullable<System.Int32>)reader[117];
            }
            if(reader[118] != DBNull.Value)
            {
                PCT0390114 = (System.Nullable<System.Int32>)reader[118];
            }
            if(reader[119] != DBNull.Value)
            {
                PCT0390115 = (System.Nullable<System.Int32>)reader[119];
            }
            if(reader[120] != DBNull.Value)
            {
                PCT0390116 = (System.Nullable<System.Int32>)reader[120];
            }
            if(reader[121] != DBNull.Value)
            {
                PCT0390117 = (System.Nullable<System.Int32>)reader[121];
            }
            if(reader[122] != DBNull.Value)
            {
                PCT0390118 = (System.Nullable<System.Int32>)reader[122];
            }
            if(reader[123] != DBNull.Value)
            {
                PCT0390119 = (System.Nullable<System.Int32>)reader[123];
            }
            if(reader[124] != DBNull.Value)
            {
                PCT0390120 = (System.Nullable<System.Int32>)reader[124];
            }
            if(reader[125] != DBNull.Value)
            {
                PCT0390121 = (System.Nullable<System.Int32>)reader[125];
            }
            if(reader[126] != DBNull.Value)
            {
                PCT0390122 = (System.Nullable<System.Int32>)reader[126];
            }
            if(reader[127] != DBNull.Value)
            {
                PCT0390123 = (System.Nullable<System.Int32>)reader[127];
            }
            if(reader[128] != DBNull.Value)
            {
                PCT0390124 = (System.Nullable<System.Int32>)reader[128];
            }
            if(reader[129] != DBNull.Value)
            {
                PCT0390125 = (System.Nullable<System.Int32>)reader[129];
            }
            if(reader[130] != DBNull.Value)
            {
                PCT0390126 = (System.Nullable<System.Int32>)reader[130];
            }
            if(reader[131] != DBNull.Value)
            {
                PCT0390127 = (System.Nullable<System.Int32>)reader[131];
            }
            if(reader[132] != DBNull.Value)
            {
                PCT0390128 = (System.Nullable<System.Int32>)reader[132];
            }
            if(reader[133] != DBNull.Value)
            {
                PCT0390129 = (System.Nullable<System.Int32>)reader[133];
            }
            if(reader[134] != DBNull.Value)
            {
                PCT0390130 = (System.Nullable<System.Int32>)reader[134];
            }
            if(reader[135] != DBNull.Value)
            {
                PCT0390131 = (System.Nullable<System.Int32>)reader[135];
            }
            if(reader[136] != DBNull.Value)
            {
                PCT0390132 = (System.Nullable<System.Int32>)reader[136];
            }
            if(reader[137] != DBNull.Value)
            {
                PCT0390133 = (System.Nullable<System.Int32>)reader[137];
            }
            if(reader[138] != DBNull.Value)
            {
                PCT0390134 = (System.Nullable<System.Int32>)reader[138];
            }
            if(reader[139] != DBNull.Value)
            {
                PCT0390135 = (System.Nullable<System.Int32>)reader[139];
            }
            if(reader[140] != DBNull.Value)
            {
                PCT0390136 = (System.Nullable<System.Int32>)reader[140];
            }
            if(reader[141] != DBNull.Value)
            {
                PCT0390137 = (System.Nullable<System.Int32>)reader[141];
            }
            if(reader[142] != DBNull.Value)
            {
                PCT0390138 = (System.Nullable<System.Int32>)reader[142];
            }
            if(reader[143] != DBNull.Value)
            {
                PCT0390139 = (System.Nullable<System.Int32>)reader[143];
            }
            if(reader[144] != DBNull.Value)
            {
                PCT0390140 = (System.Nullable<System.Int32>)reader[144];
            }
            if(reader[145] != DBNull.Value)
            {
                PCT0390141 = (System.Nullable<System.Int32>)reader[145];
            }
            if(reader[146] != DBNull.Value)
            {
                PCT0390142 = (System.Nullable<System.Int32>)reader[146];
            }
            if(reader[147] != DBNull.Value)
            {
                PCT0390143 = (System.Nullable<System.Int32>)reader[147];
            }
            if(reader[148] != DBNull.Value)
            {
                PCT0390144 = (System.Nullable<System.Int32>)reader[148];
            }
            if(reader[149] != DBNull.Value)
            {
                PCT0390145 = (System.Nullable<System.Int32>)reader[149];
            }
            if(reader[150] != DBNull.Value)
            {
                PCT0390146 = (System.Nullable<System.Int32>)reader[150];
            }
            if(reader[151] != DBNull.Value)
            {
                PCT0390147 = (System.Nullable<System.Int32>)reader[151];
            }
            if(reader[152] != DBNull.Value)
            {
                PCT0390148 = (System.Nullable<System.Int32>)reader[152];
            }
            if(reader[153] != DBNull.Value)
            {
                PCT0390149 = (System.Nullable<System.Int32>)reader[153];
            }
            if(reader[154] != DBNull.Value)
            {
                PCT0390150 = (System.Nullable<System.Int32>)reader[154];
            }
            if(reader[155] != DBNull.Value)
            {
                PCT0390151 = (System.Nullable<System.Int32>)reader[155];
            }
            if(reader[156] != DBNull.Value)
            {
                PCT0390152 = (System.Nullable<System.Int32>)reader[156];
            }
            if(reader[157] != DBNull.Value)
            {
                PCT0390153 = (System.Nullable<System.Int32>)reader[157];
            }
            if(reader[158] != DBNull.Value)
            {
                PCT0390154 = (System.Nullable<System.Int32>)reader[158];
            }
            if(reader[159] != DBNull.Value)
            {
                PCT0390155 = (System.Nullable<System.Int32>)reader[159];
            }
            if(reader[160] != DBNull.Value)
            {
                PCT0390156 = (System.Nullable<System.Int32>)reader[160];
            }
            if(reader[161] != DBNull.Value)
            {
                PCT0390157 = (System.Nullable<System.Int32>)reader[161];
            }
            if(reader[162] != DBNull.Value)
            {
                PCT0390158 = (System.Nullable<System.Int32>)reader[162];
            }
            if(reader[163] != DBNull.Value)
            {
                PCT0390159 = (System.Nullable<System.Int32>)reader[163];
            }
            if(reader[164] != DBNull.Value)
            {
                PCT0390160 = (System.Nullable<System.Int32>)reader[164];
            }
            if(reader[165] != DBNull.Value)
            {
                PCT0390161 = (System.Nullable<System.Int32>)reader[165];
            }
            if(reader[166] != DBNull.Value)
            {
                PCT0390162 = (System.Nullable<System.Int32>)reader[166];
            }
            if(reader[167] != DBNull.Value)
            {
                PCT0390163 = (System.Nullable<System.Int32>)reader[167];
            }
            if(reader[168] != DBNull.Value)
            {
                PCT0390164 = (System.Nullable<System.Int32>)reader[168];
            }
            if(reader[169] != DBNull.Value)
            {
                PCT0390165 = (System.Nullable<System.Int32>)reader[169];
            }
            if(reader[170] != DBNull.Value)
            {
                PCT0390166 = (System.Nullable<System.Int32>)reader[170];
            }
            if(reader[171] != DBNull.Value)
            {
                PCT0390167 = (System.Nullable<System.Int32>)reader[171];
            }
            if(reader[172] != DBNull.Value)
            {
                PCT0390168 = (System.Nullable<System.Int32>)reader[172];
            }
            if(reader[173] != DBNull.Value)
            {
                PCT0390169 = (System.Nullable<System.Int32>)reader[173];
            }
            if(reader[174] != DBNull.Value)
            {
                PCT0390170 = (System.Nullable<System.Int32>)reader[174];
            }
            if(reader[175] != DBNull.Value)
            {
                PCT0390171 = (System.Nullable<System.Int32>)reader[175];
            }
            if(reader[176] != DBNull.Value)
            {
                PCT0390172 = (System.Nullable<System.Int32>)reader[176];
            }
            if(reader[177] != DBNull.Value)
            {
                PCT0390173 = (System.Nullable<System.Int32>)reader[177];
            }
            if(reader[178] != DBNull.Value)
            {
                PCT0390174 = (System.Nullable<System.Int32>)reader[178];
            }
            if(reader[179] != DBNull.Value)
            {
                PCT0390175 = (System.Nullable<System.Int32>)reader[179];
            }
            if(reader[180] != DBNull.Value)
            {
                PCT0390176 = (System.Nullable<System.Int32>)reader[180];
            }
            if(reader[181] != DBNull.Value)
            {
                PCT0390177 = (System.Nullable<System.Int32>)reader[181];
            }
            if(reader[182] != DBNull.Value)
            {
                PCT0390178 = (System.Nullable<System.Int32>)reader[182];
            }
            if(reader[183] != DBNull.Value)
            {
                PCT0390179 = (System.Nullable<System.Int32>)reader[183];
            }
            if(reader[184] != DBNull.Value)
            {
                PCT0390180 = (System.Nullable<System.Int32>)reader[184];
            }
            if(reader[185] != DBNull.Value)
            {
                PCT0390181 = (System.Nullable<System.Int32>)reader[185];
            }
            if(reader[186] != DBNull.Value)
            {
                PCT0390182 = (System.Nullable<System.Int32>)reader[186];
            }
            if(reader[187] != DBNull.Value)
            {
                PCT0390183 = (System.Nullable<System.Int32>)reader[187];
            }
            if(reader[188] != DBNull.Value)
            {
                PCT0390184 = (System.Nullable<System.Int32>)reader[188];
            }
            if(reader[189] != DBNull.Value)
            {
                PCT0390185 = (System.Nullable<System.Int32>)reader[189];
            }
            if(reader[190] != DBNull.Value)
            {
                PCT0390186 = (System.Nullable<System.Int32>)reader[190];
            }
            if(reader[191] != DBNull.Value)
            {
                PCT0390187 = (System.Nullable<System.Int32>)reader[191];
            }
            if(reader[192] != DBNull.Value)
            {
                PCT0390188 = (System.Nullable<System.Int32>)reader[192];
            }
            if(reader[193] != DBNull.Value)
            {
                PCT0390189 = (System.Nullable<System.Int32>)reader[193];
            }
            if(reader[194] != DBNull.Value)
            {
                PCT0390190 = (System.Nullable<System.Int32>)reader[194];
            }
            if(reader[195] != DBNull.Value)
            {
                PCT0390191 = (System.Nullable<System.Int32>)reader[195];
            }
            if(reader[196] != DBNull.Value)
            {
                PCT0390192 = (System.Nullable<System.Int32>)reader[196];
            }
            if(reader[197] != DBNull.Value)
            {
                PCT0390193 = (System.Nullable<System.Int32>)reader[197];
            }
            if(reader[198] != DBNull.Value)
            {
                PCT0390194 = (System.Nullable<System.Int32>)reader[198];
            }
            if(reader[199] != DBNull.Value)
            {
                PCT0390195 = (System.Nullable<System.Int32>)reader[199];
            }
            if(reader[200] != DBNull.Value)
            {
                PCT0400001 = (System.Nullable<System.Int32>)reader[200];
            }
            if(reader[201] != DBNull.Value)
            {
                PCT0400002 = (System.Nullable<System.Int32>)reader[201];
            }
            if(reader[202] != DBNull.Value)
            {
                PCT0400003 = (System.Nullable<System.Int32>)reader[202];
            }
            if(reader[203] != DBNull.Value)
            {
                PCT0410001 = (System.Nullable<System.Int32>)reader[203];
            }
            if(reader[204] != DBNull.Value)
            {
                PCT0410002 = (System.Nullable<System.Int32>)reader[204];
            }
            if(reader[205] != DBNull.Value)
            {
                PCT0410003 = (System.Nullable<System.Int32>)reader[205];
            }
            if(reader[206] != DBNull.Value)
            {
                PCT0420001 = (System.Nullable<System.Int32>)reader[206];
            }
            if(reader[207] != DBNull.Value)
            {
                PCT0420002 = (System.Nullable<System.Int32>)reader[207];
            }
            if(reader[208] != DBNull.Value)
            {
                PCT0420003 = (System.Nullable<System.Int32>)reader[208];
            }
            if(reader[209] != DBNull.Value)
            {
                PCT0430001 = (System.Nullable<System.Int32>)reader[209];
            }
            if(reader[210] != DBNull.Value)
            {
                PCT0430002 = (System.Nullable<System.Int32>)reader[210];
            }
            if(reader[211] != DBNull.Value)
            {
                PCT0430003 = (System.Nullable<System.Int32>)reader[211];
            }
            if(reader[212] != DBNull.Value)
            {
                PCT0440001 = (System.Nullable<System.Int32>)reader[212];
            }
            if(reader[213] != DBNull.Value)
            {
                PCT0440002 = (System.Nullable<System.Int32>)reader[213];
            }
            if(reader[214] != DBNull.Value)
            {
                PCT0440003 = (System.Nullable<System.Int32>)reader[214];
            }
            if(reader[215] != DBNull.Value)
            {
                PCT0450001 = (System.Nullable<System.Int32>)reader[215];
            }
            if(reader[216] != DBNull.Value)
            {
                PCT0450002 = (System.Nullable<System.Int32>)reader[216];
            }
            if(reader[217] != DBNull.Value)
            {
                PCT0450003 = (System.Nullable<System.Int32>)reader[217];
            }
            if(reader[218] != DBNull.Value)
            {
                PCT0460001 = (System.Nullable<System.Int32>)reader[218];
            }
            if(reader[219] != DBNull.Value)
            {
                PCT0460002 = (System.Nullable<System.Int32>)reader[219];
            }
            if(reader[220] != DBNull.Value)
            {
                PCT0460003 = (System.Nullable<System.Int32>)reader[220];
            }
            if(reader[221] != DBNull.Value)
            {
                PCT0470001 = (System.Nullable<System.Int32>)reader[221];
            }
            if(reader[222] != DBNull.Value)
            {
                PCT0470002 = (System.Nullable<System.Int32>)reader[222];
            }
            if(reader[223] != DBNull.Value)
            {
                PCT0470003 = (System.Nullable<System.Int32>)reader[223];
            }
        }
        #endregion Constructors
    }
}