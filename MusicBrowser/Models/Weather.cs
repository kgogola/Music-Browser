using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace MusicBrowser.Models
{
    public class Weather
    {
        public string city;
        public Weather(string city)
        {
            this.city = city;
        }
        
        public Object getWeatherForecast()
        {
          
            string appid = "adf871fab3963fca2fa822af432e5c89";
            string url = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&APPID=" + appid + "&units=imperial";
            //synchronous client.
            var client = new WebClient(); //it makes possible to take response as a string
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer(); //it makes possible to change string to json object
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;

        }





    }
}