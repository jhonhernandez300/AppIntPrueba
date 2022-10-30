using AppIntPrueba.Models;
using System;
using AppIntPrueba.Models;
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

        public List<Song> SixUniqueSongs() {            
            var result = dataContext.Songs.Where(x => x.SongId == dataContext.Songs.Max(y => y.SongId)).First();
            
            //Lista de Ids numéricos para asegurar que no se envían números repetidos
            List<int> randomList = new List<int>();
            List<Song> songsList = new List<Song>();
            
            //Por si no hay Songs
            if (result != null && result.SongId >= 6)
            {
                int max = result.SongId;
                var rand = new Random();                
                int myNumber = 0;

                do
                {
                    myNumber = rand.Next(1, max);

                    if (!randomList.Contains(myNumber))
                    {
                        var song = dataContext.Songs.Include(b => b.Artist).Where(i => i.SongId == myNumber);
                        //var song = dataContext.Songs.Where(i => i.SongId == myNumber)
                        //.Include(b => b.Artist.ArtistName);

                        if (song != null)
                        {
                            songsList.AddRange(song.ToList<Song>());                                                        
                            randomList.Add(myNumber);
                        }
                    }
                } while (randomList.Count <= 6);
            }
            return songsList;
        }
    }
}
