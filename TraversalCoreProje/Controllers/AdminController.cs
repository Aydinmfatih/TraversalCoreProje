﻿using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
        public PartialViewResult AppBrandDemo()
        {
            return PartialView();
        }

    }
}
