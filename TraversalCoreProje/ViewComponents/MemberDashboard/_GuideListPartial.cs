using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class _GuideListPartial:ViewComponent
    {
        private readonly IGuideService _guideService;

        public _GuideListPartial(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _guideService.TGetList();
            return View(values);
        }
    }
}
