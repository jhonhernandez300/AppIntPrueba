using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            // Initialize DbSet properties here
            Comments = Set<Comment>();
            Movies = Set<Movie>();
        }
        
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           
            modelBuilder.Entity<Comment>().HasKey(m => m.CommentId);

            modelBuilder.Entity<Movie>().HasKey(m => m.MovieId);

            modelBuilder.Entity<Comment>()
            .HasOne(p => p.Movie)
            .WithMany(b => b.Comments)
            .HasForeignKey(t => t.MovieId);

            modelBuilder.Entity<Movie>()
           .HasData(
           new Movie
           {
               MovieId = 1,
               ReleaseDate = new DateTime(2020, 9, 3),
               Title = "Tenet",
               Description = "Armed with only one word, Tenet, and fighting for the survival of the entire world, a Protagonist journeys through a twilight world of international espionage on a mission that will unfold in something beyond real time.",
               Rating = 7.8,
               ImageRoute = "../../assets/Tenet.png",
               Duration = "2h 30 min",
               Genre = "Action, Sci-Fi",
               TrailerLink = "https://www.youtube.com/watch?v=LdOM0x0XDMo"
           }             
           );

           modelBuilder.Entity<Movie>()
          .HasData(
              new Movie
              {
                  MovieId = 2,
                  ReleaseDate = new DateTime(2018, 12, 14),
                  Title = "Spider-Man: Into the Spider-Verse",
                  Description = "Teen Miles Morales becomes the Spider-Man of his universe, and must join with five spider-powered individuals from other dimensions to stop a threat for all realities.",
                  Rating = 8.4,
                  ImageRoute = "../../assets/SpiderMan.png",
                  Duration = "1h 57min",
                  Genre = "Action, Animation, Adventure",
                  TrailerLink = "https://www.youtube.com/watch?v=tg52up16eq0"
              }           
           );

           modelBuilder.Entity<Movie>()
          .HasData(
          new Movie
          {
              MovieId = 3,
              ReleaseDate = new DateTime(2019, 9, 27),
              Title = "Knives Out",
              Description = "A detective investigates the death of a patriarch of an eccentric, combative family",
              Rating = 7.9,
              ImageRoute = "../../assets/KnivesOut.png",
              Duration = "2h 10min",
              Genre = "Comedy, Crime, Drama",
              TrailerLink = "https://www.youtube.com/watch?v=qGqiHJTsRkQ"
          }
           );

           modelBuilder.Entity<Movie>()
          .HasData(
           new Movie
           {
               MovieId = 4,
               ReleaseDate = new DateTime(2014, 8, 1),
               Title = "Guardians of the Galaxy",
               Description = "A group of intergalactic criminals must pull together to stop a fanatical warrior with plans to purge the universe.",
               Rating = 8.0,
               ImageRoute = "../../assets/GuardiansOfTheGalaxy.png",
               Duration = "2h 1min",
               Genre = "Action, Adventure, Comedy",
               TrailerLink = "https://www.youtube.com/watch?v=d96cjJhvlMA"
           }
           );

           modelBuilder.Entity<Movie>()
          .HasData(
           new Movie
           {
               MovieId = 5,
               ReleaseDate = new DateTime(2015, 5, 1),
               Title = "Avengers: Age of Ultron",
               Description = "When Tony Stark and Bruce Banner try to jump-start a dormant peacekeeping program called Ultron, things go horribly wrong and it's up to Earth's mightiest heroes to stop the villainous Ultron from enacting his terrible plan.",
               Rating = 7.3,
               ImageRoute = "../../assets/Avengers.png",
               Duration = "2h 21min",
               Genre = "Action, Adventure, Sci-Fi",
               TrailerLink = "https://www.youtube.com/watch?v=tmeOjFno6Do"
           }
           );

            modelBuilder.Entity<Comment>()
          .HasData(
           new Comment
           {
               CommentId = 1,
               CommentDate = new DateTime(2015, 5, 1),
               MovieId = 1,
               Content = "Good movie"               
           }
           );

            modelBuilder.Entity<Comment>()
         .HasData(
          new Comment
          {
              CommentId = 21,
              CommentDate = new DateTime(2023, 5, 1),
              MovieId = 2,
              Content = "Boring movie"
          }
          );

            modelBuilder.Entity<Comment>()
         .HasData(
          new Comment
          {
              CommentId = 3,
              CommentDate = new DateTime(2013, 6, 1),
              MovieId = 3,
              Content = "I like it"
          }
          );

            base.OnModelCreating(modelBuilder);
            
        }
    }


    
}
