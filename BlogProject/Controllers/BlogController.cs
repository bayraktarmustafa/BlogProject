using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    public class BlogController : Controller
    {
         BlogManager blogManager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = blogManager.GetBlogListWithCategory();

            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
	        var values = blogManager.GetBlogById(id);
            return View();
        }
    }
}
