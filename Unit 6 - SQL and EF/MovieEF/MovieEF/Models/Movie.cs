using System;
using System.Collections.Generic;

namespace MovieEF.Models;

public partial class Movie
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Genre { get; set; }

    public double? Runtime { get; set; }

    //methods
    //these will get ignored by ef
    public static List<Movie> GetByGenre(string genre)
    {
        MovieDbContext dbContext = new MovieDbContext();
        return dbContext.Movies.Where(m => m.Genre.ToLower().Trim() == genre.Trim().ToLower()).ToList();
    }

    public static List<Movie> GetByTitle(string title)
    {
        MovieDbContext dbContext = new MovieDbContext();
        return dbContext.Movies.Where(m => m.Title.ToLower().Trim().Contains(title.ToLower().Trim())).ToList();
    }
}
