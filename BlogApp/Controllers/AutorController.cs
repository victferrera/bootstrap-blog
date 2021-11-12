using Microsoft.AspNetCore.Mvc;
using Services.Models;
using Services.Interface;
using Microsoft.AspNetCore.Authorization;

namespace BlogApp.Controllers
{
    [Authorize]
    [Route("autor")]
    public class AutorController : Controller
    {
        private readonly IAutorService _service;
        public AutorController(IAutorService service)
        {
            _service = service;
        }

        [Route("index")]
        [HttpGet]
        public IActionResult Index()
        {
            ListarAutoresViewModel viewModel = new ListarAutoresViewModel
            {
                Autores = _service.ListarTodos()
            };

            return View(viewModel);
        }

        [Route("novo")]
        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [Route("novo")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(AutorViewModel autor)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _service.Criar(autor);

            return RedirectToAction(nameof(Index));
        }

        [Route("remover")]
        [HttpGet]
        public IActionResult Remover(int id)
        {
            var autor = _service.ProcurarPorIdTrazerPosts(id);
            
            var viewModel = _service.ConverterParaAutorViewModel(autor);

            if ( viewModel == null)
            {
                return RedirectToAction(nameof(Index));
            }
                
            return View(viewModel);
        }

        [Route("remover")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Remover(AutorViewModel autor)
        {
            _service.Remover(autor);

            return RedirectToAction(nameof(Index));
        }

        [Route("editar")]
        [HttpGet]
        public IActionResult Editar(int id)
        {
            AutorViewModel viewModel = new AutorViewModel();
            viewModel = _service.ConverterParaAutorViewModel(_service.ProcurarPorId(id));
            return View(viewModel);
        }

        [Route("editar")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(AutorViewModel viewModel)
        {
            _service.Editar(viewModel);
            return RedirectToAction(nameof(Index));
        }
    }
}

