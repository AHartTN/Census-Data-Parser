namespace CensusDataParser.Generated.SF2
{
    using System.ComponentModel.DataAnnotations;

    public class Iterations_NOTES
    {
        [Display(Name = "NOTE", ShortName = "NOTE", Order = 1)]
        public string NOTE { get; set; }

        [Display(Name = "SORT ID", ShortName = "SORT ID", Order = 0)]
        public int? SORT_ID { get; set; }
    }
}