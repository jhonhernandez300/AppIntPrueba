using AppIntPrueba.Models;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
using System.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppIntPrueba.Utilities;
using System.Net;
using Newtonsoft.Json;

namespace AppIntPrueba.Controllers
{
    [Route("api/song")]
    public class SongController : Controller
    {
        private DataContext dataContext;

        public SongController(DataContext _dataContext)
        {
            dataContext = _dataContext;
        }
                
        [HttpGet("GetSong/{songName}")]
        public async Task<IActionResult> GetSong(string songName)
        {
            var result = dataContext.Songs.Include(b => b.Comments).Where(i => i.SongName == songName);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost("UpdateLikes")]
        public ActionResult<Song> UpdateLikes( Song song)
        //public async Task<ActionResult<Song>> UpdateLikes([FromBody] Song song)
        {
            //var result = await dataContext.Songs.AsNoTracking().Where(i => i.SongId == song.SongId).ToListAsync();
            //var result = dataContext.Songs.FirstOrDefault(x => x.SongId == song.SongId);
            /*System.InvalidOperationException: 'An exception was thrown while attempting to evaluate a LINQ query parameter expression. See the inner exception for more information. To show additional information call 'DbContextOptionsBuilder.EnableSensitiveDataLogging'.'
             */
            //int id = Convert.ToInt32(songId);
            song.SongLikes += 1;
            Console.WriteLine(song.SongLikes);
             var result = dataContext.Songs.Where(x => x.SongId == song.SongId).ToList();
            /*System.InvalidOperationException: 'An exception was thrown while attempting to evaluate a LINQ query parameter expression. See the inner exception for more information. To show additional information call 'DbContextOptionsBuilder.EnableSensitiveDataLogging'.'
             */

            if (result == null)
            {
                return NotFound();
            }

            try
            {
                var updateResult = dataContext.Songs.Update(song);
                dataContext.SaveChangesAsync();
                return Ok(updateResult);
                //return StatusCode((int)HttpStatusCode.Created);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return StatusCode(500, "Like no guardado");                
                //return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

    }
}
