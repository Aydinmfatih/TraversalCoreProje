using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Member.Controllers
{
	[Area("Member")]
	[AllowAnonymous]
	public class ProfileController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
