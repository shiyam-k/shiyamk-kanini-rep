using API_OnetoManyMovies.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_OnetoManyMovies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieDBContext movieContext;
        public MovieController(MovieDBContext db) 
        {
            movieContext = db;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movies>>> GetMovies()
        {
            //var movies = movieContext.Movies.Include(x => x.Director).ToList();
            return movieContext.Movies.ToList();
        }
        [HttpPost]
        public async Task<ActionResult<string>> PostMovies(MovieDummy movie)
        {
            if (movie == null)
            {
                return BadRequest();
            }

            Director dir = movieContext.Director.Find(movie.directorId);
            if (dir == null)
            {
                return BadRequest();
            }
            Movies m = new Movies()
            {
                MName = movie.movieName,
                Director = dir,
                DirectorId = movie.directorId
            };
            await movieContext.Movies.AddAsync(m);
            await movieContext.SaveChangesAsync();
            return Ok("Added");
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<string>> DeleteMovies(int id)
        {
            if(id == null)
            {
                return BadRequest();
            }
            Movies movie = movieContext.Movies.Find(id);
            movieContext.Movies.Remove(movie);
            await movieContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<string>> UpdateMovies(int id, MovieDummy movieUpdate)
        {
            if (id == null)
            {
                return BadRequest();    
            }
            Movies movie = await movieContext.Movies.FindAsync(id);
            if(movie == null)
            {
                return BadRequest();
            }
            movie.MName = movieUpdate.movieName;

            movieContext.Movies.Update(movie);
            await movieContext.SaveChangesAsync();
            return Ok("Updated");
        }


    }
}
