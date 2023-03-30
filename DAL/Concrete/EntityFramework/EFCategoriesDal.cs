using Core.DataAccess.EntityFramework;
using DAL.Abstract;
using DAL.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DAL.Concrete.EntityFramework
{
    public class EFCategoriesDal : EfEntityRepositoryBase<Categories, WinFormDBContext>, ICategoriesDal
    {
    }
}
