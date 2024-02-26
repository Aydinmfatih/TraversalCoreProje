using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _PopularDestinationsPartial:ViewComponent
    {
        private readonly IDestinationService _destinationsService;

        public _PopularDestinationsPartial(IDestinationService destinationService)
        {
            _destinationsService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _destinationsService.TGetList();
            return View(values);
        }
    }
}
