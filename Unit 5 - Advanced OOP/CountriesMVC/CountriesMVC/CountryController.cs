namespace CountriesMVC
{
    public class CountryController
    {
        public List<Country> CountryDb = new List<Country>()
        {
            new Country("Germany", "Europe",new List<string> {"Black","Red","Yellow"} ),
            new Country("Russia", "Europe and Asia",new List<string> {"White","Blue","Red"} ),
             new Country("Canada", "North America",new List<string> {"Red","White"} ),
              new Country("China", "Asia",new List<string> {"Red","Yellow"} ),
               new Country("Brazil", "South America",new List<string> {"Green","Yellow","Blue"} ),
                new Country("Australia", "Oceania",new List<string> {"Red","White","Blue"} ),
                 new Country("India", "Asia",new List<string> {"DarkYellow","White","DarkGreen"} ),
                 new Country("Argentina", "South America",new List<string> {"Blue","White"} ),
                 new Country("Kazakhstan", "Asia",new List<string> {"Blue","Yellow"} ),
                 new Country("Algeria", "Africa",new List<string> {"Green","White","Red"} ),
                 //North America
      new Country("United States", "North America", new List<string>() { "red", "white", "blue" }),
      new Country("Belize", "North America", new List<string>() { "red", "white", "blue" }),
      new Country("Costa Rica", "North America", new List<string>() { "blue", "white", "red" }),

      //South America
      new Country("Paraguay", "South America", new List<string>() { "red", "white", "blue" }),

      //Europe 
      new Country("Iceland", "Europe", new List<string>() { "blue", "white", "red" }),
      new Country("Croatia", "Europe", new List<string>() { "red", "white", "blue" }),
      new Country("Czech Republic", "Europe", new List<string>() { "blue", "white", "red" }),

      //Asia
      new Country("Laos", "Asia", new List<string>() { "red", "blue", "white" }),
      new Country("Nepal", "Asia", new List<string>() { "white", "blue", "red" }),
      
      //Australia
      new Country("New Zealand", "Australia", new List<string>() { "blue", "white", "red" }),

      //Antartica
      new Country("Antartica", "Antartica", new List<string>() { "blue", "white" })
        };

        //methods
        public void CountryAction(Country c)
        {
            CountryView view = new CountryView(c);
            view.Display();
        }

        public void WelcomeAction()
        {
            bool run = true;
            while (run)
            {
                CountryListView view = new CountryListView(CountryDb);
                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
                view.Display();

                //pretend its validated
                int choice = int.Parse(Console.ReadLine());
                Country result = CountryDb[choice];

                CountryAction(result);
                //ask to continue
                while (true)
                {
                    Console.WriteLine("Do you want to see another? y/n");
                    string continueCheck = Console.ReadLine();
                    if(continueCheck == "y")
                    {
                        run = true;
                        break;
                    }
                    else if(continueCheck == "n")
                    {
                        run = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                }
            }
            

        }
    }
}
