using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;

namespace DataAccess.Repository
{
    public class GenericRepository<T>:IGenericDal<T> where T: class
    {
        public void Add(T entity)
        {
            using (var context = new Context())
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var context = new Context())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (var context = new Context())
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            using (var context = new Context())
            {
                return context.Set<T>().ToList();
            }
        }

        public T GetById(int id)
        {
	        using (var context = new Context())
	        {
		        return context.Set<T>().Find(id);
	        }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
	        using (var context = new Context())
	        {
		        return context.Set<T>().Where(filter).ToList();
	        }
        }
    }
}
