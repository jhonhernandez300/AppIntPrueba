using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace AppIntPrueba.Models
{
    public class Movie
    {
        public Movie()
        {
            // Initialize non-nullable properties in the constructor
            Title = string.Empty; // or any default non-null value
            Rating = 0;
            Genre = string.Empty;
            Duration = "1h";
            Description = string.Empty;
        }

        public int MovieId { get; set; }
        
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 2)]
        public string Title { get; set; }

        [Required]        
        [MinLength(6)]
        public string Description { get; set; }

        [Required]
        [Range(0.0, 10.0)]
        public double Rating { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 2)]
        public string Duration { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 4)]
        public string Genre { get; set; }

        public string? TrailerLink { get; set; }

        public string? ImageRoute { get; set; }

        public virtual ICollection<Comment>? Comments { get; set; }
    }
}
