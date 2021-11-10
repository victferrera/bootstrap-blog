using Dominio;
using Repository.Interface;
using Services.Interface;
using System.Collections.Generic;


namespace Services
{
    public class PostService : IPostService
    {
        public IPostRepository _repository;
        public PostService(IPostRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<Post> ListarTodos()
        {
            return _repository.ListarTodos();
        }
    }
}
