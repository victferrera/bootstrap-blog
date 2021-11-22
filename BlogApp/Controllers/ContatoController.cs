using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;
using Services.Models;

namespace BlogApp.Controllers
{
    [Authorize]
    public class ContatoController : Controller
    {
        public IContatoService _service { get; set; }
        public ContatoController(IContatoService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [Route("salvarContato")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SalvarContato(ContatoViewModel viewModel)
        {
            if(!ModelState.IsValid)
                return View("../Blog/Contact");

            _service.Salvar(viewModel);
            return RedirectToAction("Contact","Blog", new { message = "Mensagem enviada com sucesso! "});
        }
    }
}
