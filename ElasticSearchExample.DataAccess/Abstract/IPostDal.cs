using ElasticSearchExample.Core.DataAccess;
using ElasticSearchExample.Entities.Concrete.Posts;
using ElasticSearchExample.Entities.DTOs.Posts;

namespace ElasticSearchExample.DataAccess.Abstract
{
    public interface IPostDal : IEntityRepository<Post>
    {
        PostDetailInfo GetPostDetail(int postId);
    }
}
