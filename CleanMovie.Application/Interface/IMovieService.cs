using CleanMovie.Domain;

namespace CleanMovie.Application.Interface
{
    // This is a use case
    public interface IMovieService
    {
        IEnumerable<Movie> GetAllMovies();

        Movie CreateMovie(Movie movie);
    }
}