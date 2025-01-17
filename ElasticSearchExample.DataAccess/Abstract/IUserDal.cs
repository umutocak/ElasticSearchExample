using ElasticSearchExample.Core.DataAccess;
using ElasticSearchExample.Entities.Concrete.Auth;

namespace ElasticSearchExample.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {

    }
}
