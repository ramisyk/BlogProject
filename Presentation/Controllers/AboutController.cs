using Buesiness.Concrete;
using DataAccess.EntityFtramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutRepository());
        public IActionResult Index()
        {
            var results = aboutManager.GetAll();

            return View(results);
        }
        public PartialViewResult SocialMediaAbout()
        {
            return PartialView();
        }
    }
}
