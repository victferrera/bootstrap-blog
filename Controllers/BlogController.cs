using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        [Route("index")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [Route("about")]
        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [Route("contact")]
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
