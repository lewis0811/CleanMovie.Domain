using CleanMovie.Domain;

namespace CleanMovie.Application.Interface
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();

        Category AddCategory(Category category);
    }
}