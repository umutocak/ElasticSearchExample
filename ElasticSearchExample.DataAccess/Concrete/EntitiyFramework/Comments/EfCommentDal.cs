using ElasticSearchExample.Core.DataAccess.EntityFramework;
using ElasticSearchExample.DataAccess.Abstract;
using ElasticSearchExample.Entities.Concrete.Comments;

namespace ElasticSearchExample.DataAccess.Concrete.EntitiyFramework.Comments
{
    public class EfCommentDal : EfEntityRepositoryBase<Comment, BlogElasticContext>, ICommentDal
    {

    }
}
