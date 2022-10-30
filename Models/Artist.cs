using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppIntPrueba.Models
{
    public class Artist
    {   
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
