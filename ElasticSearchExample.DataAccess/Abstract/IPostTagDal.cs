using ElasticSearchExample.Core.DataAccess;
using ElasticSearchExample.Entities.Concrete.PostTags;

namespace ElasticSearchExample.DataAccess.Abstract
{
    public interface IPostTagDal : IEntityRepository<PostTag>
    {

    }
}
