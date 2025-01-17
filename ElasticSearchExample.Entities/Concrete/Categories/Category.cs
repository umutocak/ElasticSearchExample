using ElasticSearchExample.Core.Entities;

namespace ElasticSearchExample.Entities.Concrete.Categories
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
