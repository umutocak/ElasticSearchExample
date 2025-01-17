using ElasticSearchExample.Entities.Concrete.PostTags;

namespace ElasticSearchExample.Business.Abstract.PostTags
{
    public interface IPostTagService
    {
        List<PostTag> GetAllList();
        PostTag GetByItem(object item);
        PostTag Insert(PostTag entity);
        PostTag Update(PostTag entity);
        void Remove(PostTag entity);
        List<PostTag> GetListByPostId(int postId);
        void RemoveAllPostTagsByPostId(int postId);
        List<PostTag> GetListByTagId(int tagId);
    }
}
