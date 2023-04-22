using CleanMovie.Application.Interface;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult GetAllCategory()
        {
            var list = _categoryService.GetAllCategories();
            return Ok(list);
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            var newCategory = _categoryService.AddCategory(category);
            return Ok(newCategory);
        }
    }
}
