using AppIntPrueba.Models;
using System;
using System.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AppIntPrueba.Utilities
{
    public class TheRandom
    {
        private DataContext dataContext;

        public TheRandom(DataContext _dataContext)
        {
            dataContext = _dataContext;

        }

        public List<Movie> TwoUniqueMovies() {            
            var result = dataContext.Movies.Where(x => x.MovieId == dataContext.Movies.Max(y => y.MovieId)).First();

            //List of numerical IDs to ensure that no duplicate numbers are sent
            List<int> randomList = new List<int>();
            List<Movie> moviesList = new List<Movie>();
            
            //In case there are not movies
            if (result != null && result.MovieId >= 2)
            {
                int max = result.MovieId;
                var rand = new Random();                
                int myNumber = 0;

                do
                {
                    myNumber = rand.Next(1, max);

                    if (!randomList.Contains(myNumber))
                    {
                        var movie = dataContext.Movies.Include(b => b.Comments).Where(i => i.MovieId == myNumber);                        

                        if (movie != null)
                        {
                            moviesList.AddRange(movie.ToList<Movie>());                                                        
                            randomList.Add(myNumber);
                        }
                    }
                } while (randomList.Count < 2);
            }
            return moviesList;
        }
    }
}
