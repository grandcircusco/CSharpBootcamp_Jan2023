using Newtonsoft.Json;
using System.Net;

namespace Starwars_API.Models
{
    public class StarwarsDAL
    {
        public static StarwarsModel GetCharacter(string input)//adjust here
        {
            //Adjust here
            //Setup
            string url = $"https://swapi.dev/api/people/?search={input}";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Convert it to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //Adjust here
            //Convert to C#
            StarwarsModel result = JsonConvert.DeserializeObject<StarwarsModel>(JSON);
            return result;
        }
    }
}
