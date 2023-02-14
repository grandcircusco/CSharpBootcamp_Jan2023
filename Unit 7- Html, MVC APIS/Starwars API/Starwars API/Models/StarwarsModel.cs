﻿namespace Starwars_API.Models
{
    public partial class StarwarsModel
    {
        public long Count { get; set; }
        public object Next { get; set; }
        public object Previous { get; set; }
        public List<Result> Results { get; set; }
    }

    public partial class Result
    {
        public string Name { get; set; }
        public long Height { get; set; }
        public long Mass { get; set; }
        public string HairColor { get; set; }
        public string SkinColor { get; set; }
        public string EyeColor { get; set; }
        public string Birth_Year { get; set; }
        public string Gender { get; set; }
        public Uri Homeworld { get; set; }
        public List<Uri> Films { get; set; }
        public List<Uri> Species { get; set; }
        public List<object> Vehicles { get; set; }
        public List<object> Starships { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Edited { get; set; }
        public Uri Url { get; set; }
    }
}
