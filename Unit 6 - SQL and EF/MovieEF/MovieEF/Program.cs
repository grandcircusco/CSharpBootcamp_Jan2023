// See https://aka.ms/new-console-template for more information
using MovieEF.Models;

//PopulateDB();
//Tester();
Console.WriteLine("Welcome to Movie DB.");
Console.WriteLine("Would you like to search by Genre or Title?");
string menuChoice = Console.ReadLine().Trim().ToLower();
if(menuChoice == "genre")
{
    string input = GetInput("Genre");
    foreach (Movie m in Movie.GetByGenre(input))
    {
        Console.WriteLine(m.Title);
    }
}
else if(menuChoice == "title")
{
    string input = GetInput("Title");
    foreach (Movie m in Movie.GetByTitle(input))
    {
        Console.WriteLine(m.Title);
    }
}
else
{
    Console.WriteLine("Invalid menu choice");
}

static string GetInput(string search)
{
    Console.WriteLine($"What {search} would you like to see?");
    return Console.ReadLine();
}


static void Tester()
{
    foreach (Movie m in Movie.GetByGenre("action"))
    {
        Console.WriteLine(m.Title);
    }
    Console.WriteLine();
    foreach (Movie m in Movie.GetByTitle("Avenger"))
    {
        Console.WriteLine(m.Title);
    }
}
static void PopulateDB()
{
    MovieDbContext dbContext = new MovieDbContext();
    List<Movie> tempMovies = new List<Movie>()
    {
        new Movie(){Title = "Shawshank Redemption", Genre ="drama", Runtime = 202},
        new Movie(){Title = "The Dark Knight", Genre = "action", Runtime = 212 },
    new Movie(){Title = "Run Hide Fight", Genre = "action", Runtime = 169 },
    new Movie(){Title = "Zootopia", Genre = "animated", Runtime = 168 },
    new Movie(){Title = "How to Train Your Dragon", Genre = "animated", Runtime = 158 },
    new Movie(){Title = "The Terminal List", Genre = "action", Runtime = 480 },
    new Movie(){Title = "Instant Family", Genre = "drama", Runtime = 179 },
    new Movie(){Title = "La Misma Luna", Genre = "drama", Runtime = 169 },
    new Movie(){Title = "Pilgrim's Progress", Genre = "animated", Runtime = 113 },
    new Movie(){Title = "Insanity of God", Genre = "historical", Runtime = 90 },
    new Movie(){Title = "Swiss Family Robinson", Genre = "adventure", Runtime = 126 },
    new Movie(){Title = "Harriet", Genre = "historical", Runtime = 125 },
    new Movie(){Title = "The Green Book", Genre = "historical", Runtime = 130 },
    new Movie(){Title = "News of the World", Genre = "drama", Runtime = 119 },
    new Movie(){Title = "Fellowship of the Ring", Genre = "adventure", Runtime = 178 },
    new Movie(){Title = "The Princess Bride", Genre = "adventure", Runtime = 98 },
    new Movie(){Title = "Big Hero 6", Genre = "animated", Runtime = 102 },
    new Movie(){Title = "Little Women", Genre = "historical", Runtime = 135 },
    new Movie(){Title = "Avengers: Infinity War", Genre = "adventure", Runtime = 149 },
    new Movie(){Title = "Avengers: Endgame", Genre = "adventure", Runtime = 182 },
    new Movie(){Title = "Grease", Genre = "historical", Runtime = 110 },
    new Movie(){Title = "Carter", Genre = "action", Runtime = 132 },
    new Movie(){Title = "White Noise", Genre = "drama", Runtime = 136 },
    new Movie(){Title = "Spiderhead", Genre = "sci-fi", Runtime = 107 },
    new Movie(){Title = "Pacific Rim", Genre = "sci-fi", Runtime = 132 },
    new Movie(){Title = "Star Wars", Genre = "sci-fi", Runtime = 121 }
    };

    dbContext.Movies.AddRange(tempMovies);
    dbContext.SaveChanges();
}