using Microsoft.AspNetCore.Mvc;

namespace RandomDraw.Controllers
{
    public class RaffleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
