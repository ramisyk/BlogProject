using Buesiness.Concrete;
using DataAccess.EntityFtramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment comment)
        {
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.CommentStatus = true;
            comment.BlogId = 8;
            commentManager.Add(comment);
            return PartialView();
        }
        public PartialViewResult PartialListCommentByBlog(int blogId)
        {
            var results= commentManager.GetAll(blogId);
            return PartialView(results);
        }
    }
}
