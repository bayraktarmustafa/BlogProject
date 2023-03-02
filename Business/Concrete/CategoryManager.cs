using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entity.Concrete;

namespace Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
         ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
           
        }
        public void CategoryAdd(Category category)
        {
            _categoryDal.Add(category);
        }

        public void CategoryRemove(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int id)
        {
            return  _categoryDal.GetById(id);
        }
    }
}
