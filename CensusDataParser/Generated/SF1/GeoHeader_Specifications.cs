namespace CensusDataParser.Generated.SF1
{
    using System.ComponentModel.DataAnnotations;

    public class GeoHeader_Specifications
    {
        [Display(Name = "DATA DICTIONARY REFERENCE", ShortName = "DATA DICTIONARY REFERENCE", Order = 2)]
        public string DATA_DICTIONARY_REFERENCE { get; set; }

        [Display(Name = "DATA TYPE", ShortName = "DATA TYPE", Order = 5)]
        public string DATA_TYPE { get; set; }

        [Display(Name = "FIELD", ShortName = "FIELD", Order = 1)]
        public string FIELD { get; set; }

        [Display(Name = "FIELD SIZE", ShortName = "FIELD SIZE", Order = 4)]
        public string FIELD_SIZE { get; set; }

        [Display(Name = "ID", ShortName = "ID", Order = 0)]
        public int? ID { get; set; }

        [Display(Name = "STARTING POSITION", ShortName = "STARTING POSITION", Order = 3)]
        public string STARTING_POSITION { get; set; }
    }
}