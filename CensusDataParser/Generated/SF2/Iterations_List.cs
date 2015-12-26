namespace CensusDataParser.Generated.SF2
{
    using System.ComponentModel.DataAnnotations;

    public class Iterations_List
    {
        [Display(Name = "Iteration Code", ShortName = "Iteration Code", Order = 1)]
        public string Iteration_Code { get; set; }

        [Display(Name = "Iterations", ShortName = "Iterations", Order = 2)]
        public string Iterations { get; set; }

        [Display(Name = "SORT ID", ShortName = "SORT ID", Order = 0)]
        public int? SORT_ID { get; set; }
    }
}