using ElasticSearchExample.Core.DataAccess.EntityFramework;
using ElasticSearchExample.DataAccess.Abstract;
using ElasticSearchExample.Entities.Concrete.Categories;

namespace ElasticSearchExample.DataAccess.Concrete.EntitiyFramework.Categories
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, BlogElasticContext>, ICategoryDal
    {

    }
}
