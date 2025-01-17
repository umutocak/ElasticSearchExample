using ElasticSearchExample.Core.DataAccess.EntityFramework;
using ElasticSearchExample.DataAccess.Abstract;
using ElasticSearchExample.Entities.Concrete.PostTags;

namespace ElasticSearchExample.DataAccess.Concrete.EntitiyFramework.PostTags
{
    public class EfPostTagDal : EfEntityRepositoryBase<PostTag, BlogElasticContext>, IPostTagDal
    {

    }
}
