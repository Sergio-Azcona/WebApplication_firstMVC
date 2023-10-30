using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication_firstMVC.Data;
using System;
using System.Linq;
using WebApplication_firstMVC.Models;
using Microsoft.Extensions.DependencyModel;

//resource: https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/working-with-sql?view=aspnetcore-7.0&tabs=visual-studio
public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new WebApplication_firstMVCContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<WebApplication_firstMVCContext>>()))
        {
            if (context.Movie.Any()) // If there are any movies in the database, the seed initializer returns and no movies are added.
            {
                return;   // return without execting the remaining code
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
