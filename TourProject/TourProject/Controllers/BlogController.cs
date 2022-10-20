using BusinessLayer.Concrete;
using DataAccessLayer.Concrate.EFCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourProject.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfCoreBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetList();

            return View(values);
        }

        public IActionResult BlogReadDetails(int id)
        {
           
            var values = bm.GetById(id);
            return View(values);
        }

        public IActionResult SeeAllBlogs()
        {
            var values = bm.SeeAllBlogs();
            return View(values);
        }
    }
}
