using ElasticSearchExample.Core.DataAccess;
using ElasticSearchExample.Entities.Concrete.Categories;

namespace ElasticSearchExample.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {

    }
}
