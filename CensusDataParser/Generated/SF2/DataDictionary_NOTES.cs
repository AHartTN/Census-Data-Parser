namespace CensusDataParser.Generated.SF2
{
    using System.ComponentModel.DataAnnotations;

    public class DataDictionary_NOTES
    {
        [Display(Name = "Field Name", ShortName = "Field Name", Order = 2)]
        public string Field_Name { get; set; }

        [Display(Name = "SORT_ID", ShortName = "SORT_ID", Order = 0)]
        public int? SORT_ID { get; set; }

        [Display(Name = "Table", ShortName = "Table", Order = 1)]
        public string Table { get; set; }
    }
}