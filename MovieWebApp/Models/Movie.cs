using System.ComponentModel.DataAnnotations;

namespace MovieWebApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 5)]
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        [Range(0,100)]
        public decimal Price { get; set; }
    }
}
