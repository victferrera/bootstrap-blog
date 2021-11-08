using Microsoft.AspNetCore.Mvc;
using Services.Interface;
using Services.Models;

namespace BlogApp.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        private readonly ISobreService _service;
        public BlogController(ISobreService service)
        {
            _service = service;
        }
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
            return View(_service.ProcurarPorStatus('S'));
        }

        [Route("contact")]
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
