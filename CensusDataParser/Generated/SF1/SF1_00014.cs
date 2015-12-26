namespace CensusDataParser.Generated.SF1
{
    using System.ComponentModel.DataAnnotations;

    public class SF1_00014
    {
        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
        public int? CHARITER { get; set; }

        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
        public int? CIFSN { get; set; }

        [Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
        public string FILEID { get; set; }

        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
        public int? LOGRECNO { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public int? P039I001 { get; set; }

        [Display(Name = "Husband-wife family:", ShortName = "Husband-wife family:", Order = 6)]
        public int? P039I002 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 7)]
        public int? P039I003 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 8)]
        public int? P039I004 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 9)]
        public int? P039I005 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 10)]
        public int? P039I006 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 11)]
        public int? P039I007 { get; set; }

        [Display(Name = "Other family:", ShortName = "Other family:", Order = 12)]
        public int? P039I008 { get; set; }

        [Display(Name = "Male householder, no wife present:", ShortName = "Male householder, no wife present:", Order = 13)]
        public int? P039I009 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 14)]
        public int? P039I010 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 15)]
        public int? P039I011 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 16)]
        public int? P039I012 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 17)]
        public int? P039I013 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 18)]
        public int? P039I014 { get; set; }

        [Display(Name = "Female householder, no husband present:", ShortName = "Female householder, no husband present:", Order = 19)]
        public int? P039I015 { get; set; }

        [Display(Name = "With related children under 18 years:", ShortName = "With related children under 18 years:", Order = 20)]
        public int? P039I016 { get; set; }

        [Display(Name = "Under 6 years only", ShortName = "Under 6 years only", Order = 21)]
        public int? P039I017 { get; set; }

        [Display(Name = "Under 6 years and 6 to 17 years", ShortName = "Under 6 years and 6 to 17 years", Order = 22)]
        public int? P039I018 { get; set; }

        [Display(Name = "6 to 17 years only", ShortName = "6 to 17 years only", Order = 23)]
        public int? P039I019 { get; set; }

        [Display(Name = "No related children under 18 years", ShortName = "No related children under 18 years", Order = 24)]
        public int? P039I020 { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}