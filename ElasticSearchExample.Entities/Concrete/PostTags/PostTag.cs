using ElasticSearchExample.Core.Entities;

namespace ElasticSearchExample.Entities.Concrete.PostTags
{
    public class PostTag : IEntity
    {
        public int PostTagId { get; set; }
        public int PostId { get; set; }
        public int TagId { get; set; }
    }
}
