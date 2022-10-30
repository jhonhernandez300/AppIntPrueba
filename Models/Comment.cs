using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppIntPrueba.Models
{
    public class Comment
    {        
        public int CommentId { get; set; }
        public DateTime CommentDate { get; set; }
        public string? CommentContent { get; set; }
        public int SongId { get; set; }
        public Song Song { get; set; }

    }
}
