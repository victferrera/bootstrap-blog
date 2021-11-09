using Microsoft.AspNetCore.Mvc;
using Services.Interface;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Controllers
{
    public class ContatoController : Controller
    {
        public IContatoService _service { get; set; }
        public ContatoController(IContatoService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("salvarContato")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SalvarContato(ContatoViewModel viewModel)
        {
            _service.Salvar(viewModel);
            return RedirectToAction("contact", "Blog");
        }
    }
}
