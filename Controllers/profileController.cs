using Microsoft.AspNetCore.Mvc;

namespace demoApp0818.Controllers
{
    public class profileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
