﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class _ProfileInformationPartial:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _ProfileInformationPartial(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult>  InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName = values.Name + " " + values.Surname;
            ViewBag.phoneNumber = values.PhoneNumber;
            ViewBag.email = values.Email;
            return View();
        }
    }
}
