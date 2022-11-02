using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppIntPrueba.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Song> Songs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().HasKey(m => m.ArtistId);

            modelBuilder.Entity<Comment>().HasKey(m => m.CommentId);

            modelBuilder.Entity<Song>().HasKey(m => m.SongId);

            modelBuilder.Entity<Song>()
          .HasOne(p => p.Artist)
          .WithMany(b => b.Songs)
          .HasForeignKey(t => t.ArtistId);

            modelBuilder.Entity<Comment>()
          .HasOne(p => p.Song)
          .WithMany(b => b.Comments)
          .HasForeignKey(t => t.SongId);

            modelBuilder.Entity<Artist>()
            .HasData(
            new Artist
            {
                ArtistId = 1,
                ArtistName = "Metallica"
            }
            );

            modelBuilder.Entity<Artist>()
            .HasData(
            new Artist
            {
                ArtistId = 2,
                ArtistName = "Foo Fighters"
            }
            );

            modelBuilder.Entity<Song>()
           .HasData(
           new Song
           {
               SongId = 1,
               SongRegistryDate = new DateTime(),
               SongName = "Nothing Else Matters",
               SongLikes = 1,
               SongDislikes = 0,
               SongImageRoute = "../../assets/nothing else matters.JPG",
               SongYoutubeRoute = "tAGnKpE4NCI",
               ArtistId = 1
           }
           );
           modelBuilder.Entity<Song>()
          .HasData(
           new Song
            {
                SongId = 2,
                SongRegistryDate = new DateTime(),
                SongName = "Master of Pupets",
                SongLikes = 1,
                SongDislikes = 0,
                SongImageRoute = "../../assets/master of puppets.JPG",
               SongYoutubeRoute = "6xjJ2XIbGRk",
               ArtistId = 1
            }
           );
           modelBuilder.Entity<Song>()
          .HasData(
           new Song
            {
                SongId = 3,
                SongRegistryDate = new DateTime(),
                SongName = "The Unforgiven",
                SongLikes = 1,
                SongDislikes = 0,
                SongImageRoute = "../../assets/the unforgiven.JPG",
               SongYoutubeRoute = "DDGhKS6bSAE",
               ArtistId = 1
            }
           );
           modelBuilder.Entity<Song>()
          .HasData(
           new Song
            {
                SongId = 4,
                SongRegistryDate = new DateTime(),
                SongName = "One",
                SongLikes = 1,
                SongDislikes = 0,
                SongImageRoute = "../../assets/one.JPG",
               SongYoutubeRoute = "WM8bTdBs-cw",
               ArtistId = 1
            }
           );
           modelBuilder.Entity<Song>()
          .HasData(
           new Song
            {
                SongId = 5,
                SongRegistryDate = new DateTime(),
                SongName = "For Whom the Bell Tolls",
                SongLikes = 1,
                SongDislikes = 0,
                SongImageRoute = "../../assets/for whom the bells tolls.JPG",
               SongYoutubeRoute = "B_HSa1dEL9s",
               ArtistId = 1
            }
           );
           modelBuilder.Entity<Song>()
          .HasData(
           new Song
            {
                SongId = 6,
                SongRegistryDate = new DateTime(),
                SongName = "Whiskey in the Jar",
                SongLikes = 1,
                SongDislikes = 0,
                SongImageRoute = "../../assets/whiskey in the jar.JPG",
               SongYoutubeRoute = "boanuwUMNNQ",
               ArtistId = 1
            }
           );
           modelBuilder.Entity<Song>()
          .HasData(
           new Song
            {
                SongId = 7,
                SongRegistryDate = new DateTime(),
                SongName = "Sad but True",
                SongLikes = 1,
                SongDislikes = 0,
                SongImageRoute = "../../assets/sadButTrue.JPG",
               SongYoutubeRoute = "A8MO7fkZc5o",
               ArtistId = 1
            }
           );
           modelBuilder.Entity<Song>()
          .HasData(
           new Song
            {
                SongId = 8,
                SongRegistryDate = new DateTime(),
                SongName = "Everlong",
                SongLikes = 1,
                SongDislikes = 0,
                SongImageRoute = "../../assets/Everlong",
               SongYoutubeRoute = "eBG7P-K-r1Y",
               ArtistId = 1
            }
           );
           modelBuilder.Entity<Song>()
          .HasData(
           new Song
            {
                SongId = 9,
                SongRegistryDate = new DateTime(),
                SongName = "The Pretender",
                SongLikes = 1,
                SongDislikes = 0,
                SongImageRoute = "../../assets/the pretender.JPG",
               SongYoutubeRoute = "SBjQ9tuuTJQ",
               ArtistId = 2
            }
           );
            modelBuilder.Entity<Song>()
         .HasData(
          new Song
          {
              SongId = 10,
              SongRegistryDate = new DateTime(),
              SongName = "Best of You",
              SongLikes = 1,
              SongDislikes = 0,
              SongImageRoute = "../../assets/bestOfYou.JPG",
              SongYoutubeRoute = "h_L4Rixya64",
              ArtistId = 2
          }
          );
            modelBuilder.Entity<Song>()
         .HasData(
          new Song
          {
              SongId = 11,
              SongRegistryDate = new DateTime(),
              SongName = "My Hero",
              SongLikes = 1,
              SongDislikes = 0,
              SongImageRoute = "../../assets/my hero.PNG",
              SongYoutubeRoute = "EqWRaAF6_WY",
              ArtistId = 2
          }
          );

            base.OnModelCreating(modelBuilder);
            
        }
    }


    
}
