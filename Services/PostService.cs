using Dominio;
using Repository.Interface;
using Services.Interface;
using System.Collections.Generic;

namespace Services
{
    public class PostService : IPostService
    {
        public IPostRepository _repository;
        public IAutorService _autorService;
        public PostService(IPostRepository repository, IAutorService autorService)
        {
            _repository = repository;
            _autorService = autorService;
        }

        public IEnumerable<Post> ListarTodos()
        {
            return _repository.ListarTodos();
        }
    }
}
