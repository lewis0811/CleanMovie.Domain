using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CleanMovie.Domain
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Title")]
        public string? Name { get; set; }

        [Required]
        [DisplayName("Rental Cost")]
        public decimal RentalCost { get; set; }

        [Required]
        public Category? Category { get; set; }
    }
}