namespace CensusDataParser.Generated.SF2
{
    using System.ComponentModel.DataAnnotations;

    public class DataDictionary
    {
        [Display(Name = "FIELD CODE", ShortName = "FIELD CODE", Order = 4)]
        public string FIELD_CODE { get; set; }

        [Display(Name = "FIELD NAME", ShortName = "FIELD NAME", Order = 3)]
        public string FIELD_NAME { get; set; }

        [Display(Name = "SEGMENT", ShortName = "SEGMENT", Order = 2)]
        public string SEGMENT { get; set; }

        [Display(Name = "SORT_ID", ShortName = "SORT_ID", Order = 0)]
        public int? SORT_ID { get; set; }

        [Display(Name = "TABLE", ShortName = "TABLE", Order = 1)]
        public string TABLE { get; set; }
    }
}