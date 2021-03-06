using Buesiness.Concrete;
using DataAccess.EntityFtramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var results = blogManager.GetWithCategory();
            return View(results);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var results = blogManager.GetById(id);
            return View(results);
        }
    }
}
