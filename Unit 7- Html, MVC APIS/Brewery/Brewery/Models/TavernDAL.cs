using Newtonsoft.Json;
using System.Net;

namespace Brewery.Models
{
    public class TavernDAL
    {
        public static List<TavernModel> GetTaverns(string input, string cityState)//adjust here
        {
            //Adjust here
            //Setup
            string url = $"https://api.openbrewerydb.org/breweries?by_{cityState}={input}";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Convert it to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //Adjust here
            //Convert to C#
            List<TavernModel> result = JsonConvert.DeserializeObject<List<TavernModel>>(JSON);
            return result;
        }
    }
}
