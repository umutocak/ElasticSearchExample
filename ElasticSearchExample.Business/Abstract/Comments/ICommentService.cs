using ElasticSearchExample.Entities.Concrete.Comments;

namespace ElasticSearchExample.Business.Abstract.Comments
{
    public interface ICommentService
    {
        List<Comment> GetAllList();
        Comment GetByItem(object item);
        Comment Insert(Comment entity);
        Comment Update(Comment entity);
        void Remove(Comment entity);
        List<Comment> GetCommentsByPostId(int postId);
        List<Comment> GetCommentsByPostId(int postId, int lastAmount);
    }
}
