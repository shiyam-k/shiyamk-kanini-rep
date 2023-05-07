using API_OnetoManyMovies.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_OnetoManyMovies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        private readonly MovieDBContext movieContext;
        public DirectorController(MovieDBContext movieContext)
        {
            this.movieContext = movieContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movies>>> GetMovies()
        {
            var dir = await movieContext.Director.Include(x => x.Movies).ToListAsync();
            return Ok(dir);
        }
        [HttpPost]
        public async Task<ActionResult<string>> PostDirector(DirectorDummy director)
        {
            if (director == null)
            {
                return BadRequest();
            }
            Director dir = new Director()
            {
                DName = director.directorName
            };
            await movieContext.Director.AddAsync(dir);
            await movieContext.SaveChangesAsync();
            return Ok("Added");
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<string>> DeleteDirector(int id)
        {
            if(movieContext == null)
            {
                return NotFound();
            }
            Director dir = await movieContext.Director.FindAsync(id);
            if(dir == null)
            {
                return BadRequest();
            }
            movieContext.Director.Remove(dir);
            await movieContext.SaveChangesAsync();
            return Ok("Deleted");
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<string>> PutDirector(int id, DirectorDummy directorUpdate)
        {
            Director director = await movieContext.Director.FindAsync(id);
            if(director == null)
            {
                return NotFound();
            }
            director.DName = directorUpdate.directorName;
            movieContext.Director.Update(director);
            await movieContext.SaveChangesAsync();
            return Ok("Updated");
        }
    }
}
