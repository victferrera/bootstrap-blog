using Microsoft.AspNetCore.Mvc;
using Services.Models;
using Services.Interface;

namespace BlogApp.Controllers
{
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

            ListarAutoresViewModel viewModel = new ListarAutoresViewModel
            {
                Autores = _service.ListarTodos()
            };

            return RedirectToAction("Index", viewModel);
        }
    }
}

