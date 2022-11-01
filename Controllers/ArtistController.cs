using AppIntPrueba.Models;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
using System.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppIntPrueba.Utilities;

namespace AppIntPrueba.Controllers
{
    [Route("api/artist")]
    //[ApiController]
    public class ArtistController: Controller
    {
        private DataContext dataContext;        

        public ArtistController(DataContext _dataContext)
        {
            dataContext = _dataContext;            
            
        }

        // GET: api/GetArtist/5
        [HttpGet("GetArtist/{artistName}")]
        public async Task<IActionResult> GetArtist(string artistName)
        {          
            var result = dataContext.Artists.Include(b => b.Songs).Where(i => i.ArtistName == artistName);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
                
        [HttpGet("GetSongsForAnArtist/{artistName}")]
        public IActionResult GetSongsForAnArtist(string artistName)
        {
            var result = dataContext.Artists.Include(b => b.Songs).Where(i => i.ArtistName == artistName);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // GET: api/Get6Ids
        [HttpGet("Get6RandomSongs")]
        public IActionResult Get6RandomSongs()
        {
            var theRandom = new TheRandom(dataContext);
            var result = theRandom.SixUniqueSongs();            

            //No hay songs
            if (result.Count() < 5)
            {
                return NotFound();
            }

            return Ok(result);
        }

    }
}
