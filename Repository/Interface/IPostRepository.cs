using Dominio;
using System.Collections.Generic;

namespace Repository.Interface
{
    public interface IPostRepository
    {
        IEnumerable<Post> ListarTodos();
        void Criar(Post post);
        IEnumerable<Post> ListarTodosComAutor();
        Post ProcurarPorId(int id);
    }
}
