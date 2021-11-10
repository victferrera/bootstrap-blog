using Microsoft.AspNetCore.Mvc;
using Services.Interface;
using Services.Models;

namespace BlogApp.Controllers
{
    public class PostController : Controller
    {
        public IPostService _service;
        public PostController(IPostService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            ListarPostsViewModel viewModel = new ListarPostsViewModel
            {
                Posts = _service.ListarTodos()
            };
            return View(viewModel);
        }
    }
}
