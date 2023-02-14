namespace Brewery.Models
{
    public partial class TavernModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string BreweryType { get; set; }
        public string Street { get; set; }
        public object Address2 { get; set; }
        public object Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public object CountyProvince { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string Phone { get; set; }
        public Uri WebsiteUrl { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
