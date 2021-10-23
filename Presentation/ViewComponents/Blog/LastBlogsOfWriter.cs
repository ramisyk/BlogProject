using Buesiness.Concrete;
using DataAccess.EntityFtramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.ViewComponents.Blog
{
    public class LastBlogsOfWriter : ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var results = blogManager.GetByWriter(1);
            return View(results);
        }
    }
}
