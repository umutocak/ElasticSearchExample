using ElasticSearchExample.Core.Entities;

namespace ElasticSearchExample.Entities.Concrete.Auth
{
    public class User : IEntity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
    }
}
