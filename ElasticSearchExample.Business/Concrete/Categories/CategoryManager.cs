using ElasticSearchExample.Business.Abstract.Categories;
using ElasticSearchExample.DataAccess.Abstract;
using ElasticSearchExample.Entities.Concrete.Categories;

namespace ElasticSearchExample.Business.Concrete.Categories
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAllList()
        {
            var result = _categoryDal.GetList();
            return result;
        }
        public Category GetByItem(object item)
        {
            var result = _categoryDal.Get(c => c.CategoryId == (int)item);
            return result;
        }

        public Category Insert(Category entity)
        {
            var result = _categoryDal.Insert(entity);
            return result;
        }
        public void Remove(Category entity)
        {
            _categoryDal.Delete(entity);
        }
        public Category Update(Category entity)
        {
            var result = _categoryDal.Update(entity);
            return GetByItem(entity.CategoryId);
        }
    }
}
