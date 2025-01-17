using ElasticSearchExample.Core.Entities;
using ElasticSearchExample.Entities.Concrete.Posts;

namespace ElasticSearchExample.Entities.DTOs.Posts
{
    public class PostDetailInfo : IEntity
    {
        public Post PostInfo { get; set; }
        public string UserName { get; set; }
        public string CategoryName { get; set; }
        public List<int> TagIds { get; set; }

    }
}
