using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var values = _destinationService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult DestinationDetail(int id)
        {
            var value = _destinationService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult DestinationDetail(Destination p)
        {
            return View();
        }
    }
}
