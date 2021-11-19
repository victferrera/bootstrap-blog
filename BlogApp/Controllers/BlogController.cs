using Microsoft.AspNetCore.Mvc;
using Services.Interface;
using Services.Models;

namespace BlogApp.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        private readonly ISobreService _sobreService;
        private readonly IPostService _postService;
        public BlogController(ISobreService sobreService, IPostService postService)
        {
            _postService = postService;
            _sobreService = sobreService;
        }
        [Route("index")]
        [HttpGet]
        public IActionResult Index()
        {
            return View(_postService.PostsParaIndex());
        }

        [Route("about")]
        [HttpGet]
        public IActionResult About()
        {
            return View(_sobreService.ProcurarPorStatus('S'));
        }

        [Route("contact")]
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("olders")]
        [HttpGet]
        public IActionResult Older()
        {
            return View(_postService.ListarTodosPaged());
        }
    }
}
