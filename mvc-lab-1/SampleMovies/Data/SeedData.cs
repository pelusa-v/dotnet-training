namespace SampleMovies.Data;


using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SampleMovies.Models;
using System;
using System.Linq;

public static class SeedData
{
    public static void InitializeDb(IServiceProvider serviceProvider)
    {
        using (var context = serviceProvider.GetRequiredService<AppDbContext>())
        {
            if (context.Movies.Any())
            {
                return;
            }

            context.Movies.AddRange(
                new Movie
                {
                    Title = "The Shawshank Redemption",
                    ReleaseDate = DateTime.Parse("1994-09-23"),
                    Genre = "Drama",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "The Godfather",
                    ReleaseDate = DateTime.Parse("1972-03-24"),
                    Genre = "Crime",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "The Dark Knight",
                    ReleaseDate = DateTime.Parse("2008-07-18"),
                    Genre = "Action",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Pulp Fiction",
                    ReleaseDate = DateTime.Parse("1994-10-14"),
                    Genre = "Crime",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "The Lord of the Rings: The Return of the King",
                    ReleaseDate = DateTime.Parse("2003-12-17"),
                    Genre = "Fantasy",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Forrest Gump",
                    ReleaseDate = DateTime.Parse("1994-07-06"),
                    Genre = "Drama",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Inception",
                    ReleaseDate = DateTime.Parse("2010-07-16"),
                    Genre = "Sci-Fi",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Fight Club",
                    ReleaseDate = DateTime.Parse("1999-10-15"),
                    Genre = "Drama",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "The Matrix",
                    ReleaseDate = DateTime.Parse("1999-03-31"),
                    Genre = "Sci-Fi",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Goodfellas",
                    ReleaseDate = DateTime.Parse("1990-09-19"),
                    Genre = "Crime",
                    Price = 9.99M
                }
            );
            context.SaveChanges();
        }
    }
}
