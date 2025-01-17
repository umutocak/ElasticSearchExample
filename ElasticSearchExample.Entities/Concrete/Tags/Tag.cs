using ElasticSearchExample.Core.Entities;

namespace ElasticSearchExample.Entities.Concrete.Tags
{
    public class Tag : IEntity
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
    }
}
