using Microsoft.AspNetCore.Mvc;
using Services.Interface;
using Services.Models;

namespace BlogApp.Controllers
{
    [Route("post")]
    public class PostController : Controller
    {
        public IPostService _service;
        public IAutorService _autorService;
        public PostController(IPostService service, IAutorService autorService)
        {
            _service = service;
            _autorService = autorService;
        }
        [Route("index")]
        [HttpGet]
        public IActionResult Index()
        {
            ListarPostsViewModel viewModel = new ListarPostsViewModel
            {
                Posts = _service.ListarTodos()
            };
            return View(viewModel);
        }

        [Route("novo")]
        [HttpGet]
        public IActionResult Criar()
        {
            PostViewModel viewModel = new PostViewModel
            {
                AutoresDisponiveis = _autorService.ListarTodos()
            };

            return View(viewModel);
        }

        [Route("novo")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(PostViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View();

            _service.Criar(viewModel);

            return RedirectToAction(nameof(Index));
        }

        [Route("visualizar")]
        [HttpGet]
        public IActionResult Visualizar(int id)
        {
            return View(_service.Visualizar(id));
        }
    }
}
