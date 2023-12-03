using AppIntPrueba.Models;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
using System.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppIntPrueba.Utilities;
using Newtonsoft.Json;
using System.Net;

namespace AppIntPrueba.Controllers
{
    [Route("api/comment")]
    public class CommentController : Controller
    {
        private DataContext dataContext;

        public CommentController(DataContext _dataContext)
        {
            dataContext = _dataContext;
        }

        [HttpGet("GetComments/{movieId}")]
        public async Task<IActionResult> GetComments(int movieId)
        {                       
            var result =  await dataContext.Comments.Where(i => i.MovieId == movieId).ToListAsync();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }


        [HttpPost("SaveComment")]
        public async Task<IActionResult> SaveComment([FromBody] Comment comment)
        //public async Task<IActionResult> SaveComment(Comment comment, int movieId)
        {
            if (comment == null) { 
                return BadRequest();
            }

            var movie = await dataContext.Movies.Where(i => i.MovieId == comment.MovieId).ToListAsync();

            if (movie == null)
            {
                return BadRequest();
            }
            else
            {
                try
                {                    
                    var result = dataContext.Comments.Add(comment);
                    await dataContext.SaveChangesAsync();
                    return StatusCode((int)HttpStatusCode.Created);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
                }
            }

                       
        }
    }
}
