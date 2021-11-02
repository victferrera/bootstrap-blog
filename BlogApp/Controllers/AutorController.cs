using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    [Route("autor")]
    public class AutorController : Controller
    {
        [Route("novo")]
        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }
    }
}
