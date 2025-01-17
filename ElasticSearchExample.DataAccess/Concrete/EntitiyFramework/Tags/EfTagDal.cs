using ElasticSearchExample.Core.DataAccess.EntityFramework;
using ElasticSearchExample.DataAccess.Abstract;
using ElasticSearchExample.Entities.Concrete.Tags;
using ElasticSearchExample.Entities.DTOs.Posts;

namespace ElasticSearchExample.DataAccess.Concrete.EntitiyFramework.Tags
{
    public class EfTagDal : EfEntityRepositoryBase<Tag, BlogElasticContext>, ITagDal
    {
        public List<PostTagsInfo> GetPostTags(int postId)
        {
            using (BlogElasticContext context = new BlogElasticContext())
            {
                var tagNameList = from pt in context.PostTags join p in context.Posts on pt.PostId equals p.PostId join t in context.Tags on pt.TagId equals t.TagId 
                                  where p.PostId == postId
                                  select new PostTagsInfo { TagValueName = t.TagName, TagValueId = t.TagId };
                return tagNameList.ToList();
            }
        }
    }
}
