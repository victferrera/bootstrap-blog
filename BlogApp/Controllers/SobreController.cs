using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Controllers
{
    [Route("sobre")]
    public class SobreController : Controller
    {
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
    }
}
