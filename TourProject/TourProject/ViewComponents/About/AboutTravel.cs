using BusinessLayer.Concrete;
using DataAccessLayer.Concrate.EFCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourProject.ViewComponents.About
{
    public class AboutTravel :ViewComponent
    {
        AboutManager abm = new AboutManager(new EfCoreAboutRepository());
        public IViewComponentResult Invoke()
        {
            var value = abm.GetList().FirstOrDefault();
            return View(value);
        }
    }
}
