using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Globalization;
using Travel.Models;
using Travel.ViewModels;

namespace Travel.Controllers
{
    public class CalendarController : Controller
    {
        private IConfiguration _Configure;
        private string apiBaseUrl;

        public CalendarController(IConfiguration configuration) //DI
        {
            _Configure = configuration;
            apiBaseUrl = _Configure.GetValue<string>("WebAPIBaseUrl");
        }

        public async Task<IActionResult> Index()
        {
            List<Country>? countries = new List<Country>();
            var travelVM = new TravelVM();
            travelVM.CountryList = await GetCountriesAsync();
            return View(travelVM);

        }

        [HttpPost]
        public async Task<IActionResult> Index(TravelVM travelVM)
        {
            travelVM.CountryList = await GetCountriesAsync();
            return View(travelVM);
        }
        private async Task<List<SelectListItem>?> GetCountriesAsync()
        {
            List<Country>? countries = new List<Country>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(apiBaseUrl))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                    countries = JsonConvert.DeserializeObject<List<Country>>(apiResponse);
                }
            }
            return countries != null ? countries.Select(x => new SelectListItem { Text = x.LocalizedName, Value = x.ID }).ToList() : null;
        }



    }
}




