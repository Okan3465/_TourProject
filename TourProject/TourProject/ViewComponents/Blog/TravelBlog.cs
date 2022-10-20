using BusinessLayer.Concrete;
using DataAccessLayer.Concrate.EFCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourProject.ViewComponents.Blog
{
    public class TravelBlog :ViewComponent
    {
        BlogManager bm = new BlogManager(new EfCoreBlogRepository());
        public IViewComponentResult Invoke()
        {
            var value = bm.GetList();
            return View(value);
        }
    }
}
