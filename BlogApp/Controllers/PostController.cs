using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;
using Services.Models;

namespace BlogApp.Controllers
{
    [Authorize]
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
        public IActionResult Index(string message = null)
        {
            ListarPostsViewModel viewModel = new ListarPostsViewModel
            {
                Posts = _service.ListarTodos(),
                Message = message
                
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

            return RedirectToAction(nameof(Index), new { message = "Registro criado com sucesso!"});
        }

        [Route("visualizar")]
        [HttpGet]
        public IActionResult Visualizar(int id)
        {
            return View(_service.Visualizar(id));
        }

        [Route("remover")]
        [HttpGet]
        public IActionResult Remover(int id)
        {
            return View(_service.ConverterPostParaViewModel(_service.ProcurarPorId(id)));
        }

        [Route("remover")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Remover(PostViewModel viewModel)
        {
            _service.Remover(viewModel.Id);
            return RedirectToAction("Index", new { message = "Registro removido com sucesso!"});
        }

        [Route("editar")]
        [HttpGet]
        public IActionResult Editar(int id)
        {
            return View(_service.ConverterPostParaViewModel(_service.ProcurarPorId(id)));
        }

        [Route("editar")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(PostViewModel viewModel)
        {
            _service.Editar(viewModel);
            return RedirectToAction("Index", new { message = "Registro alterado com sucesso!" });
        }
    }
}
