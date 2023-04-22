using CleanMovie.Application.Interface;
using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly IMovieRepository _movieRepository;
        public CategoryService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Category AddCategory(Category category)
        {
            var newCategory = _movieRepository.CreateCategory(category);
            return newCategory;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var categoryList = _movieRepository.GetAllCategories();
            return categoryList;
        }
    }
}
