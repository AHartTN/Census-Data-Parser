namespace CensusDataParser.Generated.SF2
{
    using System.ComponentModel.DataAnnotations;

    public class SF2_Segment_10
    {
        [Display(Name = "Characteristic Iteration", ShortName = "Characteristic Iteration", Order = 2)]
        public string CHARITER { get; set; }

        [Display(Name = "Characteristic Iteration File Sequence Number", ShortName = "Characteristic Iteration File Sequence Number", Order = 3)]
        public string CIFSN { get; set; }

        [Display(Name = "File Identification", ShortName = "File Identification", Order = 0)]
        public string FILEID { get; set; }

        [Display(Name = "Total:", ShortName = "Total:", Order = 5)]
        public int? HCT0010001 { get; set; }

        [Display(Name = "Owner occupied:", ShortName = "Owner occupied:", Order = 6)]
        public int? HCT0010002 { get; set; }

        [Display(Name = "Not Hispanic or Latino householder:", ShortName = "Not Hispanic or Latino householder:", Order = 7)]
        public int? HCT0010003 { get; set; }

        [Display(Name = "Householder who is White alone", ShortName = "Householder who is White alone", Order = 8)]
        public int? HCT0010004 { get; set; }

        [Display(Name = "Householder who is Black or African American alone", ShortName = "Householder who is Black or African American alone", Order = 9)]
        public int? HCT0010005 { get; set; }

        [Display(Name = "Householder who is American Indian and Alaska Native alone", ShortName = "Householder who is American Indian and Alaska Native alone", Order = 10)]
        public int? HCT0010006 { get; set; }

        [Display(Name = "Logical Record Number", ShortName = "Logical Record Number", Order = 4)]
        public int? LOGRECNO { get; set; }

        [Display(Name = "State/US-Abbreviation (USPS)", ShortName = "State/US-Abbreviation (USPS)", Order = 1)]
        public string STUSAB { get; set; }
    }
}