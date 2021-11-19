using Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Interface
{
    public interface IPostRepository
    {
        IEnumerable<Post> ListarTodos();
        IQueryable<Post> ListarTodosQueryable();
        void Criar(Post post);
        IEnumerable<Post> ListarTodosComAutor();
        Post ProcurarPorId(int id);
        void Remover(Post post);
        void Editar(Post post);
        Post ProcurarPorIdEIncluirAutor(int id);

    }
}
