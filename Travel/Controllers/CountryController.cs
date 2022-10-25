using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Travel.ViewModels;
using Travel.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace Travel.Controllers
{
    public class CountryController : Controller
    {
        private IConfiguration _Configure;
        private string apiBaseUrl;

        public CountryController(IConfiguration configuration) //DI
        {
            _Configure = configuration;
            apiBaseUrl = _Configure.GetValue<string>("WebAPIBaseUrl");
        }

        public async Task<IActionResult> Index()
        {
            List<Country>? countries = new List<Country>();
            var countryVM = new CountryVM();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(apiBaseUrl))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                    countries = JsonConvert.DeserializeObject<List<Country>>(apiResponse);
                    //   ViewBag.CountryLst = countries != null ? countries.Select(x => new SelectListItem { Text = x.LocalizedName, Value = x.ID }).ToList() : null;

                    countryVM.CountryList = countries != null ? countries.Select(x => new SelectListItem { Text = x.LocalizedName, Value = x.ID }).ToList() : null;

                }
            }

            return View(countryVM);
        }
        [HttpPost]
        public IActionResult Index(CountryVM countryVM)
        {
            return View();
        }
    }
}
