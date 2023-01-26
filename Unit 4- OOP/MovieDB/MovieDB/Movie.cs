using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB
{
    public class Movie
    {
        //properties
        public string Title { get; set; }
        public string Category { get; set; }
        public int Year { get; set; }
        public int RunTime { get; set; }
        //constructor
        public Movie(string _title, string _category)
        {
            Title = _title;
            Category = _category;
            Year = 0;
            RunTime = 0;
        }
        //76 movies. Created secondary constructor so I don't have to change all movies
        public Movie(string _title, string _category, int _year, int _runTime)
        {
            Title = _title;
            Category = _category;
            Year = _year;
            RunTime = _runTime;
        }
    }
}
