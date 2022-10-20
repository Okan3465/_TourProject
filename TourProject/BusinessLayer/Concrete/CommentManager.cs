using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager :ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void AddComment(Comment comment)
        {
            _commentDal.Create(comment);
        }

        public Comment GetById(int id)
        {
            return _commentDal.GetById(id);
        }
      

        public List<Comment> GetCommentListWithCustomer(int id)
        {
            return _commentDal.GetListByFilter(x => x.CustomerID == id);
        }

        public List<Comment> GetList()
        {
            return _commentDal.GetListAll().Take(1).ToList();
        }

        public List<Comment> ReadAllComments()
        {
            return _commentDal.GetListAll();
        }

        public void TAdd(Comment t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Comment t)
        {
            _commentDal.Delete(t);
        }

        public void TUpdate(Comment t)
        {
            _commentDal.Update(t);
        }
    }
}
