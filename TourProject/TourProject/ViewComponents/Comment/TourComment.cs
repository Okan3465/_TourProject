using BusinessLayer.Concrete;
using DataAccessLayer.Concrate.EFCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourProject.ViewComponents.Comment
{
    public class TourComment:ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCoreCommentRepository());

       
        public IViewComponentResult Invoke()
        {
           
            var values = cm.GetList();
            return View(values);
        }
    }
}
