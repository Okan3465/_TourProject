using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BusinessLayer.Abstract.IGenericService;

namespace BusinessLayer.Abstract
{
    public interface ICommentService:IGenericService<Comment>
    {
        void AddComment(Comment comment);

        List<Comment> ReadAllComments();

      
        List<Comment> GetCommentListWithCustomer(int id);
    }
}
