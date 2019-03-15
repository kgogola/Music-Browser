using MusicBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicBrowser.Controllers
{
    public class WeatherController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ParisWeather()
        {
            return View();
        }

        public JsonResult GetWeather(string city)
        {
            Weather weath = new Weather(city);

            return Json(weath.getWeatherForecast(), JsonRequestBehavior.AllowGet );  // HTTP GET requests from the client are allowed.

        }

        public ActionResult WeatherSearcher()
        {
            return View();
        }




    }
}