using BusinessLayer.Concrete;
using DataAccessLayer.Concrate.EFCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourProject.Controllers
{
    public class AboutController : Controller
    {
        AboutManager abm = new AboutManager(new EfCoreAboutRepository());
        public IActionResult Index()
        {
            var values = abm.GetList().FirstOrDefault();

            return View(values);
        }

    }
}
