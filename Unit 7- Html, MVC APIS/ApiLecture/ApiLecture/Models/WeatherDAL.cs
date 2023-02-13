using Newtonsoft.Json;
using System.Net;

namespace ApiLecture.Models
{
    public class WeatherDAL
    {
        public static WeatherModel GetWeather(string city)//adjust here
        {
            //Adjust here
            //Setup
            string key = "f13d9a4c716f47f7fa06bc732c55e049"; //Assume this is hidden
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={key}&units=imperial";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Convert it to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //Adjust here
            //Convert to C#
            WeatherModel result = JsonConvert.DeserializeObject<WeatherModel>(JSON);
            return result;
        }
    }
}
