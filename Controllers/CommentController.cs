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
                
        [HttpPost("SaveComment")]
        public async Task<ActionResult<Comment>> SaveComment([FromBody] Comment comment)
        //public async Task<ActionResult<Comment>> SaveComment(Comment comment)
        {
            if (comment == null) { 
                return BadRequest();
            }

            try
            {
                var result = dataContext.Comments.Add(comment);
                await dataContext.SaveChangesAsync();
                //return Ok(result);
                return StatusCode((int)HttpStatusCode.Created);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //return StatusCode(500, "Comentario no guardado");
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }            
        }
    }
}
