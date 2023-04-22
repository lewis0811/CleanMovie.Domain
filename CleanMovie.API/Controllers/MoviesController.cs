using CleanMovie.Application.Interface;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public IActionResult GetMovies()
        {
            var movieFromService = _movieService.GetAllMovies();
            return Ok(movieFromService);
        }

        [HttpPost]
        public IActionResult AddMovies(Movie movie)
        {
            var newMovie = _movieService.CreateMovie(movie);
            return Ok(newMovie);
        }
    }
}
