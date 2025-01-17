using ElasticSearchExample.Core.DataAccess.EntityFramework;
using ElasticSearchExample.DataAccess.Abstract;
using ElasticSearchExample.Entities.Concrete.Auth;

namespace ElasticSearchExample.DataAccess.Concrete.EntitiyFramework.Auth
{
    public class EfUserDal : EfEntityRepositoryBase<User, BlogElasticContext>, IUserDal
    {

    }
}
