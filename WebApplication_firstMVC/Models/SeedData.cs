using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication_firstMVC.Data;
using System;
using System.Linq;
using WebApplication_firstMVC.Models;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new WebApplication_firstMVCContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<WebApplication_firstMVCContext>>()))
        {
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Parasite",
                    ReleaseDate = DateTime.Parse("2019-10-11"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 27.99M,
                    Language = "Korean"
                },
                new Movie
                {
                    Title = "Roma",
                    ReleaseDate = DateTime.Parse("2018-10-27"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 17.99M,
                    Language = "Spanish"
                },
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-1-11"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 11.99M,
                    Language = "English"
                }
            );

            context.SaveChanges();
        }    
    }
}
