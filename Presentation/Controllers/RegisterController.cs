using Buesiness.Concrete;
using DataAccess.Repositories;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    public class RegisterController : Controller
    {

        WriterManager writerManager = new WriterManager(new EfWriterRepository());

        //The method names that gefined get and post atributes for register operations, have to be same
        
        //Run when page loaded
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //Run after click the button
        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            writer.WriterStatus = true;
            writer.WriterAbout = "Deneme";
            writerManager.Add(writer);
            return RedirectToAction("Index", "Blog");
        }
    }
}
