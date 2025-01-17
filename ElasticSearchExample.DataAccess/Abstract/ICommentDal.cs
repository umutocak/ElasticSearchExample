using ElasticSearchExample.Core.DataAccess;
using ElasticSearchExample.Entities.Concrete.Comments;

namespace ElasticSearchExample.DataAccess.Abstract
{
    public interface ICommentDal : IEntityRepository<Comment>
    {

    }
}
