using Microsoft.AspNetCore.Mvc;
using MyActiveLife.Apis.Weather;

namespace MyActiveLife.Web.Controllers
{
    public class WeatherController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var weatherClient = new WeatherClient();
            var metar = await weatherClient.GetMetarAsync("KDCA", null, null, null, new DateTime(2022, 6, 8, 0, 0, 0), new DateTime(2022, 6, 9, 0, 0, 0));

            return View(metar);
        }
    }
}
