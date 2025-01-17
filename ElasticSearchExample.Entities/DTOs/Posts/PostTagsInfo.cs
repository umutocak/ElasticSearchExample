using ElasticSearchExample.Core.Entities;

namespace ElasticSearchExample.Entities.DTOs.Posts
{
    public class PostTagsInfo : IEntity
    {
        public string TagValueName { get; set; }
        public int TagValueId { get; set; }
    }
}
