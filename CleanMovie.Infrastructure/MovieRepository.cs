using CleanMovie.Application.Interface;
using CleanMovie.Domain;
using Microsoft.EntityFrameworkCore;

namespace CleanMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDbContext _db;

        public MovieRepository(MovieDbContext db)
        {
            _db = db;
        }

        public Category CreateCategory(Category category)
        {
            _db.Categories.Add(category);
            _db.SaveChanges();
            return category;
        }

        //Create
        public Movie CreateMovie(Movie movie)
        {
            _db.Movies.Add(movie);
            _db.SaveChanges();
            return movie;
        }

        // GET list
        public IEnumerable<Movie> GetAllMovies()
        {
            IQueryable<Movie> query = _db.Set<Movie>();
            query = query.Include(m => m.Category);
            return query.ToList();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _db.Categories.ToList();
        }
    }
}