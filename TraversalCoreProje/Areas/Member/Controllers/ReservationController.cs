using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly IReservationService _reservationService;
        private readonly UserManager<AppUser> _userManager;

        public ReservationController(IDestinationService destinationService, IReservationService reservationService, UserManager<AppUser> userManager)
        {
            _destinationService = destinationService;
            _reservationService = reservationService;
            _userManager = userManager;
        }

        public async Task<IActionResult>  MyCurrentReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var value = _reservationService.GetListWithReservationByWaitAccepted(values.Id);
            return View(value);
        }
        public async Task<IActionResult> MyApprovalReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var value = _reservationService.GetListWithReservationByWaitApproval(values.Id);
            return View(value);
        }
        public async Task<IActionResult>  MyOldReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var value = _reservationService.GetListWithReservationByWaitPrevious(values.Id);
            return View(value);
         
        }
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in _destinationService.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value=x.DestinationId.ToString()

                                           }).ToList();
            ViewBag.v1 = values;

            return View();
        }
        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            reservation.Status = "Onay Bekliyor";
            reservation.AppUserId = 1;
            _reservationService.TAdd(reservation);
            return RedirectToAction("MyCurrentReservation");
        }
    }
}
