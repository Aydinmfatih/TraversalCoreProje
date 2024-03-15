using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class _PlatformSettingsPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
