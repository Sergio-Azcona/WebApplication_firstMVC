using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplication_firstMVC.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [DisplayName("Movie Title")]// amend column header display name
        public string? Title { get; set; }

        [DisplayName("Release Date")] // amend column header display name
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        //[Column(Type = Decimal)]
        public decimal? Price { get; set; }
        public string? Rating { get; set; }
        public string? Language { get; set; }
    }
}