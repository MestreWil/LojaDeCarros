using Microsoft.AspNetCore.Mvc;

namespace LojaDeCarros.Controllers
{
	public class CarroController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
