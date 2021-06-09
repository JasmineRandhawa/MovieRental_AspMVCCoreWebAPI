using System;
using System.ComponentModel.DataAnnotations;

namespace MovieRental.Dtos
{
    public class MovieDto
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }


        [Required(ErrorMessage = "Genre field is required")]
        public int? GenreId { get; set; }

        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Range(1, 100)]
        public short? NumberOfStock { get; set; }

    }
}