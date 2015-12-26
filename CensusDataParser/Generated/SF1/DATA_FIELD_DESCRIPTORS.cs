namespace CensusDataParser.Generated.SF1
{
    using System.ComponentModel.DataAnnotations;

    public class DATA_FIELD_DESCRIPTORS
    {
        [Display(Name = "DECIMAL", ShortName = "DECIMAL", Order = 5)]
        public short? DECIMAL { get; set; }

        [Display(Name = "FIELD CODE", ShortName = "FIELD CODE", Order = 4)]
        public string FIELD_CODE { get; set; }

        [Display(Name = "FIELD NAME", ShortName = "FIELD NAME", Order = 3)]
        public string FIELD_NAME { get; set; }

        [Display(Name = "SEGMENT", ShortName = "SEGMENT", Order = 1)]
        public string SEGMENT { get; set; }

        [Display(Name = "SORT ID", ShortName = "SORT ID", Order = 0)]
        public int? SORT_ID { get; set; }

        [Display(Name = "TABLE NUMBER", ShortName = "TABLE NUMBER", Order = 2)]
        public string TABLE_NUMBER { get; set; }
    }
}