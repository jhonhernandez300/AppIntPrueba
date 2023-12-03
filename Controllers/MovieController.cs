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
    [Route("api/movie")]
    public class MovieController : Controller
    {
        private DataContext dataContext;

        public MovieController(DataContext _dataContext)
        {
            this.dataContext = _dataContext ?? throw new ArgumentNullException(nameof(_dataContext));
        }
                
        [HttpGet("GetMovieByName/{title}")]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovieByName(string title)
        {
            if (title == null)
            {
                return BadRequest();
            }
            else 
            {
                var result = await dataContext.Movies.Include(b => b.Comments).Where(i => i.Title == title).ToListAsync();

                if (result.Count == 0)
                {
                    return NotFound();
                }

                return Ok(result);
            }            
        }

        [HttpGet("GetAllMovies")]
        public async Task<ActionResult<IEnumerable<Movie>>> GetAllMovies()
        {           
                var result = await dataContext.Movies.ToListAsync();
                return Ok(result);           
        }

        [HttpGet("GetMovieById/{id}")]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovieById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            else
            {
                var result = await dataContext.Movies.Include(b => b.Comments).Where(i => i.MovieId == id).ToListAsync();

                if (result.Count == 0)
                {
                    return NotFound();
                }

                return Ok(result);
            }
        }

    }
}
