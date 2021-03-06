using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Interface;
using Services.Models;
using Microsoft.AspNetCore.Authorization;

namespace BlogApp.Controllers
{
    [Authorize]
    [Route("sobre")]
    public class SobreController : Controller
    {
        private readonly ISobreService _service;
        public SobreController(ISobreService service)
        {
            _service = service;
        }
        [Route("index")]
        [HttpGet]
        public IActionResult Index()
        {
            return View(_service.ListarTodos());
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
        public IActionResult Criar(SobreViewModel viewModel)
        {
            _service.Criar(viewModel);
            return RedirectToAction(nameof(Index));
        }

        [Route("remover")]
        [HttpGet]
        public IActionResult Remover(int id)
        {
            if (_service.ProcurarPorId(id) == null)
                return RedirectToAction(nameof(Index));
            return View(_service.ProcurarPorId(id));
        }

        [Route("remover")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Remover(SobreViewModel viewModel)
        {
            _service.Remover(viewModel);
            return RedirectToAction(nameof(Index));
        }

        [Route("editar")]
        [HttpGet]
        public IActionResult Editar(int id)
        {
            return View(_service.ProcurarPorId(id));
        }

        [Route("editar")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(SobreViewModel viewModel)
        {
            _service.Editar(viewModel);
            return RedirectToAction(nameof(Index));
        }
    }
}
