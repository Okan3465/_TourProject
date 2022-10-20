using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate.EFCore;
using EntityLayer;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourProject.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfCoreContactRepository());



        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact p)
        {

            ContactValidator cv = new ContactValidator();
            ValidationResult result = cv.Validate(p);

            if (result.IsValid)
            {
                p.ContactDate = DateTime.Now;
                p.ContactImage = "görsel";
                p.ContactPassword = "şifre";
                p.ContactStatus = true;
                p.ContactUserName = "kullaniciAdi";

                cm.TAdd(p);

                return RedirectToAction("Index", "Home");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }

    }
}
