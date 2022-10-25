using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Travel.ViewModels
{
    public class TravelDatePickerVM
    {
        public string? Departure { get; set; }
        public string? Arrival { get; set; }
        public List<SelectListItem>? CountryList { get; set; }

        [Display(Name = "Vertrekdatum *")]
        [Required(ErrorMessage = "Gelieve een datum in te geven.")]
        public string? Startdatum { get; set; }
        [Required(ErrorMessage = "Gelieve een datum in te geven.")]
        public string? Einddatum { get; set; }
    }
}
