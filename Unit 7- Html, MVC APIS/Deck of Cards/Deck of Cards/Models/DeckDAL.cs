using Newtonsoft.Json;
using System.Net;
using System.Text.Json.Serialization;

namespace Deck_of_Cards.Models
{
    public class DeckDAL
    {
        public static string deckid = "p7g29qdp0n4p";
        public static DeckModel GetDeckModel(int amount)
        {
            //Setup
            string url = $"https://deckofcardsapi.com/api/deck/{deckid}/draw/?count={amount}";


            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Convert it to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //Convert to c#
            DeckModel result = JsonConvert.DeserializeObject<DeckModel>(JSON);
            return result;
        }

        public static void ShuffleDeck()
        {
            //Setup
            string url = $"https://deckofcardsapi.com/api/deck/{deckid}/shuffle/";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Not doing anything since I will not return values
        }
    }
}
