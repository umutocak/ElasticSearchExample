using ElasticSearchExample.Core.Entities;
using System.Linq.Expressions;

namespace ElasticSearchExample.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        T Insert(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
