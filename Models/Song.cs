using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppIntPrueba.Models
{
    public class Song
    {     
        public int SongId { get; set; }
        public DateTime SongRegistryDate { get; set; }
        public string SongName { get; set; }
        public int SongLikes { get; set; }
        public int SongDislikes { get; set; }
        public string SongImageRoute { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
