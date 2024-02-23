using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    public class LayoutPartialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
