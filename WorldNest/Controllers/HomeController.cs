using Microsoft.AspNetCore.Mvc;
using WorldNest.Services.Countries;
using WorldNest.Services.Oceans;

namespace WorldNest.Controllers
{
    public class HomeController : Controller
    {
        private readonly CountryService countryService;
        private readonly OceanService oceanService;

        public HomeController(
            CountryService countryService,
            OceanService oceanService)
        {
            this.countryService = countryService;
            this.oceanService = oceanService;
        }

        public async ValueTask<IActionResult> Index()
        {
            return View();
        }

        public async ValueTask<IActionResult> Country()
        {
            var countries = await countryService.GetCountries();
            return View(countries);
        }

        public async ValueTask<IActionResult> DetailsCountry(int id)
        {
            var country = await countryService.GetCountryById(id); 
            if (country == null)
            {
                return NotFound();
            }
            return View(country);
        }

        public async ValueTask<IActionResult> Ocean()
        {
            var oceans = await this.oceanService.GetOceans();
            return View(oceans);
        }

        public async ValueTask<IActionResult> DetailsOcean(int id)
        {
            var ocean = await oceanService.GetOceanById(id);
            if (ocean == null)
            {
                return NotFound();
            }
            return View(ocean);
        }
    }
}
