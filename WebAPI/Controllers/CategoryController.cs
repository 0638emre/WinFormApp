using BL.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoriesService _categoriesService;

        public CategoryController(ICategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }

        /// <summary>
        /// T�m kategorileri d�ner.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllCategory")]
        public IActionResult GetAllCategory()
        {
            var data = _categoriesService.GetCategories();
            return Ok(data);
        }

        /// <summary>
        /// Id ye g�re tekil kategori d�ner.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("GetCategoryById")]
        public IActionResult GetCategoryById([FromQuery] Guid Id)
        {
            var data = _categoriesService.GetCategoryById(Id);
            return Ok(data);
        }

        /// <summary>
        /// Kategori ekler.
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        [HttpPost("AddCategory")]
        public IActionResult AddCategory([FromQuery] string categoryName)
        {
            string result;
            var data = _categoriesService.AddCategory(categoryName);
            if (data)
            {
                result = "Ba�ar�l�";
            }
            else
            {
                result = "Ba�ar�s�z.";
            }
            return Ok(result);
        }

        /// <summary>
        /// Kategori siler.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpDelete("DeleteCategory")]
        public IActionResult DeleteCategory([FromQuery] Guid Id)
        {
            string result;
            var data = _categoriesService.RemoveCategory(Id);
            if (data)
            {
                result = "Ba�ar�l�";
            }
            else
            {
                result = "Ba�ar�s�z.";
            }
            return Ok(result);
        }
    }
}