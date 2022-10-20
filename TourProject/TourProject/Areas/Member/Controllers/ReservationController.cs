using BusinessLayer.Concrete;
using DataAccessLayer.Concrate.EFCore;
using EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourProject.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfCoreDestinationRepository());
        ReservationManager reservationManager = new ReservationManager(new EfCoreReservationRepository());
        

        private readonly UserManager<AppUser> _userManager;  //sisteme otantike olmuş kullanıcının bilgilerini almak için bu  işlem yapıldı

        public ReservationController(UserManager<AppUser> userManager) 
        {
            _userManager = userManager;
        }

        public async Task< IActionResult> CurrentReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name); //sisteme otantike olmuş kullanıcının bilgilerini almak  için bu işlem yapıldı
            var valuesList = reservationManager.GetAcceptedReservations(values.Id);
            return View(valuesList);
        }
        public async Task<IActionResult> OldReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name); //sisteme otantike olmuş kullanıcının bilgilerini almak  için bu işlem yapıldı
            var valuesList = reservationManager.GetListOfPreviousReservations(values.Id);
            return View(valuesList);
        }
        public async Task<IActionResult>  PendingApprovalReservation() //await çağırıldığı için async Task kullanıldı
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name); //sisteme otantike olmuş kullanıcının bilgilerini almak  için bu işlem yapıldı
           var valuesList= reservationManager.GetListWithReservationByPendingApproval(values.Id);
            return View(valuesList);
        }
        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in destinationManager.GetList()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.DestinationID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]

        public IActionResult  NewReservation(Reservation p)
        {
            //var values = await _userManager.FindByNameAsync(User.Identity.Name); //sisteme otantike olmuş kullanıcının bilgilerini almak  için bu işlem yapıldı
            //var valuesList = reservationManager.GetAcceptedReservations(values.Id);
            //return View(valuesList);
            var value= User.Claims.FirstOrDefault().Value;
            p.Status = "Onay Bekliyor ";
            reservationManager.TAdd(p);
            return Redirect("/member/Reservation/CurrentReservation");
        }
    }
}
