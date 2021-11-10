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
            var lista = new SelectList
            (
                _autorService.ListarTodos(),
                "Id",
                "Nome"
            );

            PostViewModel viewModel = new PostViewModel
            {
                AutoresDisponiveis = lista
            };

            return View(viewModel);
        }

        [Route("novo")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(PostViewModel viewModel)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
