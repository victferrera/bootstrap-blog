using Microsoft.AspNetCore.Mvc;
using Services.Interface;
using Services.Models;

namespace BlogApp.Controllers
{
    [Route("post")]
    public class PostController : Controller
    {
        public IPostService _service;
        public PostController(IPostService service)
        {
            _service = service;
        }
        [Route("index")]
        [HttpGet]
        public IActionResult Index()
        {
            ListarPostsViewModel viewModel = new ListarPostsViewModel
            {
                Posts = _service.ListarTodos()
            };
            return View(viewModel);
        }

        [Route("novo")]
        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }
    }
}
