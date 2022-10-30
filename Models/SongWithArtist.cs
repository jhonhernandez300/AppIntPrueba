namespace AppIntPrueba.Models
{
    public class SongWithArtist
    {
        public int SongWithArtistId { get; set; }
        public int SongId { get; set; }
        public DateTime SongRegistryDate { get; set; }
        public string SongName { get; set; }
        public string SongLikes { get; set; }
        public string SongDislikes { get; set; }
        public string SongImageRoute { get; set; }
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
    }
}
