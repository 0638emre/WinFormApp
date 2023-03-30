using BL.Abstract;
using DAL.Abstract;
using Entities.Concrete;
using Entities.DTO;

namespace BL.Concrete
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ICategoriesDal _categoryDal;

        public CategoriesService(ICategoriesDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public bool AddCategory(string categoryName)
        { 
            _categoryDal.Add(new()
            {
                Id = Guid.NewGuid(),
                Name = categoryName,
                CreatedDate = DateTime.UtcNow
            });

            return true;
        }

        public bool RemoveCategory(Guid categoryId)
        {
            _categoryDal.Delete(new()
            {
                Id = categoryId,
                DeletedDate = DateTime.UtcNow
            });

            return true;
        }

        public List<GetCategoryDTO> GetCategories()
        {
            List<Categories> categories = _categoryDal.GetList();

            List<GetCategoryDTO> datas = new();

            foreach (var c in categories)
            {
                datas.Add(new()
                {
                    Id = c.Id,
                    Name = c.Name
                });
            }

            return datas;
        }

        public GetCategoryDTO GetCategoryById(Guid categoryId)
        {
            Categories category = _categoryDal.Get(c => c.Id == categoryId);

            GetCategoryDTO data = new()
            {
                Id = category.Id,
                Name = category.Name
            };

            return data;
        }
    }
}
