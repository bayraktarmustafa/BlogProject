using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
	public class CommentManager:ICommentService
	{
		 ICommentDal _commentDal;

		 public CommentManager(ICommentDal commentDal)
		 {
			 _commentDal = commentDal;
		 }

		 public void CommentAdd(Comment comment)
		{
			throw new NotImplementedException();
		}

		public List<Comment> GetList(int id)
		{
			return _commentDal.GetAll(c => c.BlogID == id);
		}
	}
}
