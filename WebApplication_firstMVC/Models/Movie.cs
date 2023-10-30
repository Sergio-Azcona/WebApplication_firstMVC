using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplication_firstMVC.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [DisplayName("Movie Title")]// amend column header display name
        [StringLength(60, MinimumLength = 1), Required]
        public string? Title { get; set; }

        [DisplayName("Release Date")] // amend column header display name
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required, RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), StringLength(30)] // validations info: https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/validation?view=aspnetcore-7.0
        public string? Genre { get; set; }
        
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal? Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string? Rating { get; set; }
        
        [StringLength(60, MinimumLength = 2)]
        public string? Language { get; set; }
    }
}