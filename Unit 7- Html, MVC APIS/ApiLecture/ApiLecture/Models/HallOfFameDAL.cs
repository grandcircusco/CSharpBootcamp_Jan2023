using Newtonsoft.Json;
using System.Net;
using System.Text.Json.Serialization;

namespace ApiLecture.Models
{
    public class HallOfFameDAL
    {
        public static HallOfFameResponse GetHallOfFame()//adjust here
        {
            //Adjust here
            //Setup
            string url = "https://grandcircusco.github.io/demo-apis/computer-science-hall-of-fame.json";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Convert it to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //Adjust here
            //Convert to C#
            HallOfFameResponse result = JsonConvert.DeserializeObject<HallOfFameResponse>(JSON);
            return result;
        }
    }
}
