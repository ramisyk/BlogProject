using Microsoft.AspNetCore.Mvc;
using Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    Id=1,
                    Username="Ramis"
                },
                new UserComment
                {
                    Id=2,
                    Username="Ahmet"
                },
                new UserComment
                {
                    Id=3,
                    Username="Merve"
                }
            };
            return View(commentValues);
        }
    }
}
