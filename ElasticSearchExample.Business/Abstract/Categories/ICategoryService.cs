using ElasticSearchExample.Entities.Concrete.Categories;

namespace ElasticSearchExample.Business.Abstract.Categories
{
    public interface ICategoryService
    {
        List<Category> GetAllList();

        Category GetByItem(object item);

        Category Insert(Category entity);

        Category Update(Category entity);

        void Remove(Category entity);
    }
}
