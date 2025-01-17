using ElasticSearchExample.Entities.Concrete.Tags;
using ElasticSearchExample.Entities.DTOs.Posts;

namespace ElasticSearchExample.Business.Abstract.Tags
{
    public interface ITagService
    {
        List<Tag> GetAllList();
        Tag GetByItem(object item);
        Tag Insert(Tag entity);
        Tag Update(Tag entity);
        void Remove(Tag entity);
        List<PostTagsInfo> PostTagListForPost(int postID);
        List<Tag> TagListForIds(List<int> tagIds);
    }
}
