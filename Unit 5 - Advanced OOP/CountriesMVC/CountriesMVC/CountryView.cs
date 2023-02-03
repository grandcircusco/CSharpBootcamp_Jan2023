using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CountriesMVC
{
    public class CountryView
    {
        //properties
        public Country DisplayCountry { get; set; }
        //Constructor
        public CountryView(Country _country)
        {
            DisplayCountry = _country;
        }
        //methods
        public void Display()
        {
            Console.WriteLine($"{DisplayCountry.Name} {DisplayCountry.Continent}");
            Console.WriteLine("Colors:");
            foreach(string color in DisplayCountry.Colors)
            {
                Console.ForegroundColor = Enum.Parse<ConsoleColor>(color,true); //true means ignore casing
                //Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color, true);
                //Console.ForegroundColor = ConsoleColor.Red;
                //Console.ForegroundColor = (ConsoleColor)1;
                if (color.ToLower().Trim() == "black")
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
                Console.WriteLine(color);
                Console.ResetColor();
            }

            
        }
    }
}
