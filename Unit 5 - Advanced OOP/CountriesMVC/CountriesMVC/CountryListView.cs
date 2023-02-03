using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesMVC
{
    public class CountryListView
    {
        //properties
        public List<Country> Countries { get; set; }
        //Constructor
        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }
        //Methods
        public void Display()
        {
            for(int i = 0; i < Countries.Count; i++)
            {
               
                Console.WriteLine($"{i}. {Countries[i].Name}");
            }
        }
    }
}
