using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppIntPrueba.Models
{
    public class Comment
    {
        public Comment()
        {
            // Initialize non-nullable properties in the constructor
            Content = string.Empty; // or any default non-null value
            CommentDate = DateTime.Today;
            //Movie = new Movie();
        }

        public int CommentId { get; set; }
        
        [Required]
        public DateTime CommentDate { get; set; }

        [Required]
        [StringLength(300, MinimumLength = 2)]
        public string Content { get; set; }

        public int? MovieId { get; set; }
        public Movie? Movie { get; set; }
    }
}
