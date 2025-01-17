using ElasticSearchExample.Business.Abstract.Auth;
using ElasticSearchExample.Business.Abstract.Posts;
using ElasticSearchExample.Business.Abstract.Tags;
using ElasticSearchExample.Business.ElasticSearchOptions.Abstract;
using ElasticSearchExample.Business.ElasticSearchOptions.Concrete;
using ElasticSearchExample.DataAccess.Abstract;
using ElasticSearchExample.Entities.Concrete.Posts;
using ElasticSearchExample.Entities.DTOs.Posts;
using Nest;

namespace ElasticSearchExample.Business.Concrete.Posts
{
    public class PostManager : IPostService
    {
        public IElasticClient _elasticClient { get; set; }
        private readonly IPostDal _postDal;
        private readonly IElasticSearchService _elasticSearchService;
        private readonly ITagService _tagService;
        private readonly IUserService _userService;

        public PostManager(IUserService userService, ITagService tagService, IElasticSearchService elasticSearchService, IPostDal postDal)
        {
            _userService = userService;
            _tagService = tagService;
            _elasticSearchService = elasticSearchService;
            _postDal = postDal;
        }

        public List<Post> GetAllList()
        {
            return _postDal.GetList();
        }

        public Post GetByItem(object item)
        {
            return _postDal.Get(c => c.PostId == (int)item);
        }

        public PostDetailInfo GetPostDetail(int postId)
        {
            PostDetailInfo detailInfo = _postDal.GetPostDetail(postId);
            detailInfo.TagIds = _tagService.PostTagListForPost(postId).Select(x => x.TagValueId).ToList();
            return detailInfo;
        }

        public List<Post> GetPostsByCategoryId(int categoryId)
        {
            return _postDal.GetList(c => c.CategoryId == categoryId);
        }

        public List<Post> GetPostsByCategoryId(int categoryId, int lastAmount)
        {
            return _postDal.GetList(c => c.CategoryId == categoryId).Take(lastAmount).ToList();
        }

        public List<Post> GetPostsByUserId(int userId)
        {
            return _postDal.GetList(c => c.UserId == userId);
        }

        public Task<List<PostElasticIndexDto>> GetSearchAsync(string searchText, int skipItemCount = 0, int maxItemCount = 100)
        {
            throw new NotImplementedException();
        }

        public Post Insert(Post entity)
        {
            _postDal.Insert(entity);
            return entity;
        }

        public Task<bool> PostAddOrUpdateElasticIndex(PostElasticIndexDto postElasticIndexDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PostDeleteDocumentElasticIndex(PostElasticIndexDto postElasticIndexDto)
        {
            throw new NotImplementedException();
        }

        public void Remove(Post entity)
        {
            _postDal.Delete(entity);
        }

        public Task<List<PostElasticIndexDto>> SuggestSearchAsync(string suggestText, int skipItemCount = 0, int maxItemCount = 100)
        {
            throw new NotImplementedException();
        }

        public Post Update(Post entity)
        {
            _postDal.Update(entity);
            return GetByItem(entity.PostId);
        }
    }
}
