using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _FeaturePartial : ViewComponent
    {
        private readonly IFeature2Service _feature2Service;

        public _FeaturePartial(IFeature2Service feature2Service)
        {
            _feature2Service = feature2Service;
        }

        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
