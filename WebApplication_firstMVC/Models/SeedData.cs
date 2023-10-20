using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication_firstMVC.Data;
using System;
using System.Linq;
namespace WebApplication_firstMVC.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebApplication_firstMVCContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WebApplication_firstMVCContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return; // seed database
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Gone With The Wind",
                        ReleaseDate = DateTime.Parse("01/17/1940"),
                        Genre = "Drama",
                        Price = 8.50M,
                    },
                     new Movie
                     {
                         Title = "Ghostbusters ",
                         ReleaseDate = DateTime.Parse("1984-3-13"),
                         Genre = "Comedy",
                         Price = 8.99M
                     },
                     new Movie
                     {
                         Title = "Margin Call",
                         ReleaseDate = DateTime.Parse("10/21/2021"),
                         Genre = "Drama",
                         Price = 10.50M
                     },
                     new Movie
                     {
                         Title = "Ghostbusters ",
                         ReleaseDate = DateTime.Parse("1984-3-13"),
                         Genre = "Comedy",
                         Price = 8.99M
                     },
                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M
                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
