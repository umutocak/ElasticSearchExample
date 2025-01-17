using ElasticSearchExample.Entities.Concrete.Auth;

namespace ElasticSearchExample.Business.Abstract.Auth
{
    public interface IUserService
    {
        List<User> GetAllList();
        User GetByItem(object item);
        User Insert(User entity);
        User Update(User entity);
        void Remove(User entity);
    }
}
