using Entities.DTO;

namespace BL.Abstract
{
    public interface ICategoriesService
    {
        public bool AddCategory(string categoryName);
        public bool RemoveCategory(Guid categoryId);
        public List<GetCategoryDTO> GetCategories();
        public GetCategoryDTO GetCategoryById(Guid categoryId);

    }
}
