using ElasticSearchExample.Core.DataAccess;
using ElasticSearchExample.Entities.Concrete.Tags;
using ElasticSearchExample.Entities.DTOs.Posts;

namespace ElasticSearchExample.DataAccess.Abstract
{
    public interface ITagDal : IEntityRepository<Tag>
    {
        List<PostTagsInfo> GetPostTags(int postId);
    }
}
