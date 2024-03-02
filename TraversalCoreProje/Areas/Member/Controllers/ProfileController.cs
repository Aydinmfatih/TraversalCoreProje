using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using TraversalCoreProje.Areas.Member.Models;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]

    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var userEditViewModel = new UserEditViewModel();
            userEditViewModel.Surname = values.Surname;
            userEditViewModel.Name = values.Name;
            userEditViewModel.PhoneNumber = values.PhoneNumber;
            userEditViewModel.Mail = values.Email;


            return View(userEditViewModel);
        }
        private async Task<string> SaveImageAsync(IFormFile image)
        {
            if (image == null || image.Length == 0)
                return null;

            var extension = Path.GetExtension(image.FileName);
            var imageName = Guid.NewGuid() + extension;
            var saveLocation = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "userImages", imageName);

            using (var stream = new FileStream(saveLocation, FileMode.Create))
            {
                await image.CopyToAsync(stream);
            }

            return imageName;
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel item)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (item.Image != null)
            {
                user.ImageUrl = await SaveImageAsync(item.Image);
            }

            user.Name = item.Name;
            user.Surname = item.Surname;

            if (!string.IsNullOrEmpty(item.Password))
            {
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, item.Password);
            }

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }

            return View();
        }
    }

   
}
