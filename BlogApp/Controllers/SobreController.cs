using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Interface;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Controllers
{
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
            throw new NotImplementedException;
        }
    }
}
