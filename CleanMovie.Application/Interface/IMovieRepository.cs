using CleanMovie.Domain;

namespace CleanMovie.Application.Interface
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetAllMovies();

        IEnumerable<Category> GetAllCategories();

        Movie CreateMovie(Movie movie);

        Category CreateCategory(Category category);
    }
}