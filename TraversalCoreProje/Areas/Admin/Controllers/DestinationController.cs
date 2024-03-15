using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    public class DestinationController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
