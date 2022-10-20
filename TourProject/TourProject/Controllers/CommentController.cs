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
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCoreCommentRepository());

        public IActionResult Index()
        {
            var values = cm.ReadAllComments();
            return View(values);
        }

       [HttpGet]

       public IActionResult AddComment()
        {
            return View();
        }
        [HttpPost]

        public IActionResult AddComment(Comment p)
        {
            CommentValidator cv = new CommentValidator();
            ValidationResult results = cv.Validate(p);



            if (results.IsValid)
            {
                p.CommentStatus = true;
                p.CustomerID = Convert.ToInt32(User.Claims.FirstOrDefault().Value);
                cm.AddComment(p);
               
                return RedirectToAction("Index", "Comment");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }


            return View();
        }

      public IActionResult GetCommentsByCustomer()
        {
            int CustomerID = Convert.ToInt32(User.Claims.FirstOrDefault().Value);
            var values = cm.GetCommentListWithCustomer(CustomerID);
            return View(values);
        }

        public IActionResult DeleteComment(int id)
        {
            var commentvalue = cm.GetById(id);
            cm.TDelete(commentvalue);
            return RedirectToAction("Index","Comment");
        }

        [HttpGet]
        public IActionResult EditComments(int id)
        {
            var commentvalue = cm.GetById(id);
            return View(commentvalue);
        }
        [HttpPost]
        public IActionResult EditComments(Comment p)
        {
            p.CustomerID = 2;
            p.CommentStatus = true;
            cm.TUpdate(p);
            return RedirectToAction("GetCommentsByCustomer");
        }
    }
}
