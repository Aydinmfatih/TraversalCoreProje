using DataAccessLayer.Migrations;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        public IActionResult MyCurrentReservation()
        {
            return View();
        }
        public IActionResult MyOldReservation()
        {
            return View();
        }
        public IActionResult NewReservation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            
            return View();
        }
    }
}
