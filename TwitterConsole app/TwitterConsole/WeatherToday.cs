using System.IO;
using System.Net;
using System.Text;

namespace TwitterConsole
{
    class WeatherToday
    {
        string weather = "";
        static GeoPositionCurent adress = new GeoPositionCurent();
        string city = adress.GetLocationByPublicIP("1");
        internal StringBuilder GetCurrentWeatherByLocation()
        {
            #region getting weather by location
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WeatherToday location = new WeatherToday();
            WebRequest request2 = WebRequest.Create($"http://www.timeanddate.com/weather/russia/{city}");

            WebResponse response2 = request2.GetResponse();
            StreamReader stream0 = new StreamReader(response2.GetResponseStream());
            {
                weather = stream0.ReadToEnd();
            }
            StringBuilder weatherBuilded = new StringBuilder("Погода сегодня:\n");

            //int IndCelcius = weather.IndexOf("&nbsp;°C")-2;
            var weatherCelcius = weatherBuilded.Append($"Температура - {weather.Substring(weather.IndexOf("&nbsp;°C") - 2, 2)}°C;\n");

            int FIndClouds = weather.IndexOf("&nbsp;°C</div><p>") + 17;
            int LIndClouds = weather.IndexOf(".</p><br");
            var weatherClouds = weatherBuilded.Append($"Облачность - {weather.Substring(FIndClouds, LIndClouds - FIndClouds)};\n");

            int FIndWind = weather.IndexOf("<br>Wind:") + 9;
            int LIndWind = weather.IndexOf("km/h <span") + 4;
            var weatherWind = weatherBuilded.Append($"Ветер - {weather.Substring(FIndWind, LIndWind - FIndWind)};\n");


            return weatherBuilded;
            #endregion

        }


    }
}
