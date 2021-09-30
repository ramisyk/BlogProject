using Buesiness.Concrete;
using DataAccess.EntityFtramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());

        public IActionResult Index()
        {
            var result = categoryManager.GetAll();
            return View(result);
        }
    }
}
