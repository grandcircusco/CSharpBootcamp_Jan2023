namespace Deck_of_Cards.Models
{
    public partial class DeckModel
    {
        public bool Success { get; set; }
        public string Deck_Id { get; set; }
        public List<Card> Cards { get; set; }
        public long Remaining { get; set; }
    }

    public partial class Card
    {
        public string Code { get; set; }
        public Uri Image { get; set; }
        public Images Images { get; set; }
        public string Value { get; set; }
        public string Suit { get; set; }
    }

    public partial class Images
    {
        public Uri Svg { get; set; }
        public Uri Png { get; set; }
    }
}
