using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProje.ViewComponents.AdminDashboard
{
    public class _Cards1StatisticPartial:ViewComponent
    {
        private readonly Context _context;

        public _Cards1StatisticPartial(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = _context.Destinations.Count();
            ViewBag.v2 = _context.Users.Count();
            return View();  
        }
    }
}
