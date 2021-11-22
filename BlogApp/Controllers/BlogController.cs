using Dominio;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;
using Services.Models;
using System.Threading.Tasks;

namespace BlogApp.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        private readonly ISobreService _sobreService;
        private readonly IPostService _postService;
        public BlogController(ISobreService sobreService, IPostService postService)
        {
            _postService = postService;
            _sobreService = sobreService;
        }
        [Route("index")]
        public IActionResult Index()
        {
            return View(_postService.PostsParaIndex());
        }

        [Route("about")]
        [HttpGet]
        public IActionResult About()
        {
            return View(_sobreService.ProcurarPorStatus('S'));
        }

        [Route("contact")]
        [HttpGet]
        public IActionResult Contact(string message = null)
        {
            var viewModel = new ContatoViewModel{
                Message = message
            };

            return View(viewModel);
        }

        [Route("olders")]
        [HttpGet]
        public async Task<IActionResult> Older(int? pageNumber)
        {
            var posts = _postService.ListarTodosQueryable();
            return View(await ListarPostsViewModelPaginated<Post>.CreateAsync(posts, pageNumber ?? 1, 3));
        }
    }
}
