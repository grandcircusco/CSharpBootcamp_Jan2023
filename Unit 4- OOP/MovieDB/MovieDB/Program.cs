using MovieDB;
using Validation;
using System.IO;

List<Movie> movies = new List<Movie>()
{
    new Movie("Midsommar", "horror",2019, 171),
    new Movie("Jujutsu Kaisen 0", "Animated", 2022, 105),
    new Movie("Requiem for a dream", "Drama", 2000, 102),
    new Movie("The Office, The Movie", "drama"),
    new Movie ("Everything Everywhere All at Once","drama",2022, 149),
    new Movie ("The Big Lebowski","comedy", 1998, 117),
    new Movie ("A Monster Calls","drama", 2016, 108),
    new Movie ("The Shape of Water","romance"),
    new Movie ("Pacific Rim","sci-fi"),
    new Movie ("Soul","drama"),
    new Movie ("Requiem for a Dream","animated"),
    new Movie ("Coco","animated"),
    new Movie ("MidSommar","horror"),
    new Movie("Shawshank Redemption", "drama"),
    new Movie("The Dark Knight", "action"),
    new Movie("Run Hide Fight", "action"),
    new Movie("Zootopia", "animated"),
    new Movie("How to Train Your Dragon", "animated"),
    new Movie("Terminal List", "action"),
    new Movie("Instant Family", "drama"),
    new Movie("La Misma Luna", "drama"),
    new Movie("Pilgrim's Progress", "animated"),
    new Movie("Insanity of God", "historical"),
    new Movie("Swiss Family Robinson", "adventure"),
    new Movie("Harriet", "historical"),
    new Movie("The Green Book", "historical"),
    new Movie("News of the World", "drama"),
    new Movie("Lord of the Rings", "adventure"),
    new Movie("The Princess Bride", "adventure"),
    new Movie("Big Hero 6", "animated"),
    new Movie("Little Women", "historical"),
    new Movie("Avengers: Endgame", "adventure"),
    new Movie("Wednesday", "action"),
    new Movie("Grease", "romance"),
    new Movie("Carter", "action"),
    new Movie("White Noise", "drama"),
    new Movie("Spider Head", "sci-fi"),
    new Movie("stargate", "scifi"),
    new Movie("Run Hide Fight", "action"),
    new Movie("Zootopia", "animated"),
    new Movie("How to Train Your Dragon", "animated"),
    new Movie("The Terminal List", "action"),
    new Movie("Instant Family", "drama"),
    new Movie("La Misma Luna", "drama"),
    new Movie("Hot Rod", "Comedy"),
    new Movie("Star Wars", "Scifi"),
  new Movie("2001: A Space Odyssey", "Scifi"),
  new Movie("A Clockwork Orange", "Scifi"),
  new Movie("Close Encounters of the Third Kind", "Scifi"),

  new Movie("WALL·E", "Animated"),
  new Movie("Inside Out", "Animated"),
  new Movie("Zootopia", "Animated"),
  new Movie("Soul", "Animated"),
  new Movie("Spirited Away", "Animated"),
  new Movie("Turning Red", "Animated"),
  new Movie("Coco", "Animated"),
  new Movie("Toy Story 4", "Animated"),
  new Movie("Up", "Animated"),
  new Movie("Toy Story 3", "Animated"),
  new Movie("Toy Story 2", "Animated"),
  new Movie("Toy Story 1", "Animated"),

  new Movie("Boyhood", "Drama"),
  new Movie("The Last of the Mohicans", "Drama"),
  new Movie("Dances with Wolves", "Drama"),
  new Movie("Into the Wild", "Drama"),
  new Movie("Dead Poets Society", "Drama"),
  new Movie("Casablanca", "Drama"),
  new Movie("Citizen Kane", "Drama"),
  new Movie("Schindler's List", "Drama"),
  new Movie("On the Waterfront", "Drama"),
  new Movie("Paris, Texas", "Drama"),

  new Movie("Train to Busan", "Horror"),
  new Movie("Let the Right One In", "Horror"),
  new Movie("28 Days Later", "Horror"),
  new Movie("The Wailing", "Horror"),
  new Movie("The Conjuring", "Horror")
};

//Distinct Categories
List<Movie> DistinctCategories = movies.GroupBy(m => m.Category.ToLower().Trim()).Select(m => m.First()).ToList();



//start
Console.WriteLine("Welcome to 2023 Blockbuster. Theres only 1 left.");

bool runProgram = true;

while (runProgram)
{
    //Category display
    Console.WriteLine("Which category of movie do you want to see?");
    for (int i = 0; i< DistinctCategories.Count; i++)
    {
        Console.WriteLine($"{i}. {DistinctCategories[i].Category}");
    }
    //string category = Console.ReadLine().ToLower().Trim();
    int choice = Validator.GetNumberInRangeInt(0, DistinctCategories.Count -1);
    string category = DistinctCategories[choice].Category;

    List<Movie> result = movies.Where(m => m.Category.ToLower().Trim() == category).ToList();

    Console.WriteLine();
    Console.WriteLine("Here are the matching movies");

    foreach (Movie m in result.OrderBy(m => m.Title))
    {
        if(m.Year == 0)
        {
            Console.WriteLine($"{m.Title} No info on Year or Runtime");
        }
        else
        {
            Console.WriteLine($"{m.Title} Year: {m.Year} Runtime: {m.RunTime}");
        }
    }

    //If continue
    runProgram = Validator.GetContinue("Would you like to search for more movies?");
}

