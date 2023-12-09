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
               TrailerLink = "9UfIRXjoO3I?si=-ESo5GlhVtCie2qt"
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
                  TrailerLink = "g4Hbz2jLxvQ?si=svS6wG8qKGc-6_Xg"
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
              TrailerLink = "qGqiHJTsRkQ?si=lzgBSLf83TZELPE7"
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
               TrailerLink = "d96cjJhvlMA?si=QQCyB3VqDSed3nhu"
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
               TrailerLink = "-f5PwE_Q8Fs?si=JJ1NkKNgq5xuYTN2"
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

            modelBuilder.Entity<Comment>()
          .HasData(
           new Comment
           {
               CommentId = 4,
               CommentDate = new DateTime(2013, 7, 1),
               MovieId = 5,
               Content = "Cool seeing them all together again, even if I didn't massively enjoy it. It's good, nothing more or less in my opinion"
           }
           );

            modelBuilder.Entity<Comment>()
        .HasData(
         new Comment
         {
             CommentId = 5,
             CommentDate = new DateTime(2014, 7, 1),
             MovieId = 5,
             Content = "Robert Downey Jr. felt a little flat to me as Iron Man - he still has a decent amount of moments, just not as many as you get in his individual films"
         }
         );

        modelBuilder.Entity<Comment>()
        .HasData(
        new Comment
    {
        CommentId = 6,
        CommentDate = new DateTime(2015, 7, 1),
        MovieId = 4,
        Content = "A cheerful blockbuster in which Star Wars meets Ziggy Stardust"
    }
    );
            modelBuilder.Entity<Comment>()
   .HasData(
    new Comment
    {
        CommentId = 7,
        CommentDate = new DateTime(2015, 7, 1),
        MovieId = 4,
        Content = "Guardians bounces with the energy of pure invention."
    }
    );

            base.OnModelCreating(modelBuilder);
            
        }
    }


    
}
