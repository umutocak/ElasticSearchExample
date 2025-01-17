using ElasticSearchExample.Business.Abstract.Comments;
using ElasticSearchExample.DataAccess.Abstract;
using ElasticSearchExample.Entities.Concrete.Comments;

namespace ElasticSearchExample.Business.Concrete.Comments
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public Comment Insert(Comment comment)
        {
            _commentDal.Insert(comment);
            return comment;
        }
        public void Remove(Comment comment)
        {
            _commentDal.Delete(comment);
        }
        public Comment Update(Comment comment)
        {
            _commentDal.Update(comment);
            return GetByItem(comment.CommentId);
        }

        public List<Comment> GetAllList()
        {
            return _commentDal.GetList();
        }
        public Comment GetByItem(object item)
        {
            return _commentDal.Get(c => c.CommentId == (int)item);
        }
        public List<Comment> GetCommentsByPostId(int postId)
        {
            return _commentDal.GetList(c => c.PostId == postId);
        }
        public List<Comment> GetCommentsByPostId(int postId, int lastAmount)
        {
            return _commentDal.GetList(c => c.PostId == postId)
              .OrderByDescending(x => x.CommentDate)
              .Take(lastAmount)
              .ToList();
        }
    }
}
