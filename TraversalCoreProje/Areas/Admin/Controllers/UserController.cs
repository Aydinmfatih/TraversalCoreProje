using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;

        public UserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public IActionResult Index()
        {
            var values = _appUserService.TGetList();
            return View(values);
        }
        public IActionResult DeleteUser(int id)
        {
            var values = _appUserService.TGetById(id);
            _appUserService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var value = _appUserService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditUser(AppUser user)
        {
            _appUserService.TAdd(user);
            return RedirectToAction("Index");
        }
        public IActionResult CommentUser()
        {
            _appUserService.TGetList();
            return View();
        }
    }
}
