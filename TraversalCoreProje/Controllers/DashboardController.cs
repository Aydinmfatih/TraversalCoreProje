using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    [Area("Member")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
