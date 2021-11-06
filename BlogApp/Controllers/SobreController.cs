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
        public IActionResult Index()
        {
            return View();
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
    }
}
