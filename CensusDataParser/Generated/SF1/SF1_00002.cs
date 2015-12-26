namespace CensusDataParser.Generated.SF1
{
    using System.ComponentModel.DataAnnotations;

    public class SF1_00002
    {
        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
        public string CHARITER { get; set; }

        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
        public string CIFSN { get; set; }

        [Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
        public string FILEID { get; set; }

        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
        public int? LOGRECNO { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public int? P0020001 { get; set; }

        [Display(Name = "Hispanic or Latino", ShortName = "Hispanic or Latino", Order = 6)]
        public int? P0020002 { get; set; }

        [Display(Name = "Not Hispanic or Latino:", ShortName = "Not Hispanic or Latino:", Order = 7)]
        public int? P0020003 { get; set; }

        [Display(Name = "Population of one race:", ShortName = "Population of one race:", Order = 8)]
        public int? P0020004 { get; set; }

        [Display(Name = "White alone", ShortName = "White alone", Order = 9)]
        public int? P0020005 { get; set; }

        [Display(Name = "Black or African American alone", ShortName = "Black or African American alone", Order = 10)]
        public int? P0020006 { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}