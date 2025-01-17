using ElasticSearchExample.Core.DataAccess.EntityFramework;
using ElasticSearchExample.DataAccess.Abstract;
using ElasticSearchExample.Entities.Concrete.Posts;
using ElasticSearchExample.Entities.DTOs.Posts;

namespace ElasticSearchExample.DataAccess.Concrete.EntitiyFramework.Posts
{
    public class EfPostDal : EfEntityRepositoryBase<Post, BlogElasticContext>, IPostDal
    {
        public PostDetailInfo GetPostDetail(int postId)
        {
            using (BlogElasticContext context = new BlogElasticContext())
            {
                var data = from p in context.Posts join c in context.Categories on p.CategoryId equals c.CategoryId join u in context.Users
                           on p.UserId equals u.UserId where p.PostId == postId
                           select new PostDetailInfo
                           {
                               PostInfo = p,
                               CategoryName = c.CategoryName,
                               UserName = u.FullName
                           };
                return data?.FirstOrDefault();
            }
        }
    }
}
