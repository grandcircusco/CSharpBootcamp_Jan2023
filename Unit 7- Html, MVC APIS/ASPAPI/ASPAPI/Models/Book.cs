namespace ASPAPI.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int Year { get; set; }

        public Book(string _title, string _category, int _year)
        {
            Title = _title;
            Category = _category;
            Year = _year;
        }
    }
}
