using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using DataAccess.Repository;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using (var context = new Context())
            {
                return context.Blogs.Include(c=>c.Category).ToList();
            }
        }
    }
}
