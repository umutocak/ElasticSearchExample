using ElasticSearchExample.Business.ElasticSearchOptions.Concrete;
using ElasticSearchExample.Entities.Concrete.Posts;
using ElasticSearchExample.Entities.DTOs.Posts;

namespace ElasticSearchExample.Business.Abstract.Posts
{
    public interface IPostService
    {
        List<Post> GetAllList();
        Post GetByItem(object item);
        Post Insert(Post entity);
        Post Update(Post entity);
        void Remove(Post entity);
        List<Post> GetPostsByCategoryId(int categoryId);
        List<Post> GetPostsByUserId(int userId);
        List<Post> GetPostsByCategoryId(int categoryId, int lastAmount);
        PostDetailInfo GetPostDetail(int postId);
        Task<bool> PostAddOrUpdateElasticIndex(PostElasticIndexDto postElasticIndexDto);
        Task<bool> PostDeleteDocumentElasticIndex(PostElasticIndexDto postElasticIndexDto);
        Task<List<PostElasticIndexDto>> SuggestSearchAsync(string suggestText, int skipItemCount = 0, int maxItemCount = 100);
        Task<List<PostElasticIndexDto>> GetSearchAsync(string searchText, int skipItemCount = 0, int maxItemCount = 100);
    }
}
