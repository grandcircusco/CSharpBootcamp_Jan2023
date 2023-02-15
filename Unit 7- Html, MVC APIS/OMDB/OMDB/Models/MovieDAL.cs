using Newtonsoft.Json;
using System.Net;

namespace OMDB.Models
{
    public class MovieDAL
    {
        public static MovieModel GetMovie(string title)
        {
            //setup
            string key = Secret.apiKey;
            string url = $"http://www.omdbapi.com/?apikey={key}&t={title}";

            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            MovieModel result = JsonConvert.DeserializeObject<MovieModel>(JSON);
            return result;
        }
    }
}
