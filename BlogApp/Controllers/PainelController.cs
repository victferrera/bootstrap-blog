using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace BlogApp.Controllers
{
    public class PainelController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
