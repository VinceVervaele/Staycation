using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Travel.ViewModels
{
    public class TravelVM
    {

        public string? Departure { get; set; }
        public string? Arrival { get; set; }
        public List<SelectListItem>? CountryList  { get; set; }

        [Display(Name = "Vertrekdatum *")]
        [Required(ErrorMessage = "Gelieve een datum in te geven.")]
        [DataType(DataType.Date)]
        public string? Startdatum { get; set; }
        [Required(ErrorMessage = "Gelieve een datum in te geven.")]
        [DataType(DataType.Date)]
        public string? Einddatum { get; set; }
    }
}
