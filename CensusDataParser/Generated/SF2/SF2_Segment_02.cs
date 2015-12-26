namespace CensusDataParser.Generated.SF2
{
    using System.ComponentModel.DataAnnotations;

    public class SF2_Segment_02
    {
        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
        public int? CHARITER { get; set; }

        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
        public int? CIFSN { get; set; }

        [Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
        public string FILEID { get; set; }

        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
        public int? LOGRECNO { get; set; }

        [Display(Name = "Total tribes tallied (300, A01-Z99) & (300, A01-Z99):", ShortName = "Total tribes tallied (300, A01-Z99) & (300, A01-Z99):", Order = 5)]
        public int? PCT0020001 { get; set; }

        [Display(Name = "American Indian tribes, specified (A01-M38, T01-Z99) & (300, A01-Z99):", ShortName = "American Indian tribes, specified (A01-M38, T01-Z99) & (300, A01-Z99):", Order = 6)]
        public int? PCT0020002 { get; set; }

        [Display(Name = "Apache (A09-A23) & (300, A01-Z99)", ShortName = "Apache (A09-A23) & (300, A01-Z99)", Order = 7)]
        public int? PCT0020003 { get; set; }

        [Display(Name = "Arapaho (A24-A33) & (300, A01-Z99)", ShortName = "Arapaho (A24-A33) & (300, A01-Z99)", Order = 8)]
        public int? PCT0020004 { get; set; }

        [Display(Name = "Blackfeet (A45-A50) & (300, A01-Z99)", ShortName = "Blackfeet (A45-A50) & (300, A01-Z99)", Order = 9)]
        public int? PCT0020005 { get; set; }

        [Display(Name = "Canadian and French American Indian (T01-V23) & (300, A01-Z99)", ShortName = "Canadian and French American Indian (T01-V23) & (300, A01-Z99)", Order = 10)]
        public int? PCT0020006 { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}