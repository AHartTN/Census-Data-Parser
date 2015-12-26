namespace CensusDataParser.Generated.SF1
{
    using System.ComponentModel.DataAnnotations;

    public class SF1_00043
    {
        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
        public string CHARITER { get; set; }

        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
        public string CIFSN { get; set; }

        [Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
        public string FILEID { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public int? H0020001 { get; set; }

        [Display(Name = "Urban:", ShortName = "Urban:", Order = 6)]
        public int? H0020002 { get; set; }

        [Display(Name = "Inside urbanized areas", ShortName = "Inside urbanized areas", Order = 7)]
        public int? H0020003 { get; set; }

        [Display(Name = "Inside urban clusters", ShortName = "Inside urban clusters", Order = 8)]
        public int? H0020004 { get; set; }

        [Display(Name = "Rural", ShortName = "Rural", Order = 9)]
        public int? H0020005 { get; set; }

        [Display(Name = "Not defined for this file", ShortName = "Not defined for this file", Order = 10)]
        public int? H0020006 { get; set; }

        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
        public int? LOGRECNO { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}