using Dominio;
using System.Collections.Generic;

namespace Repository.Interface
{
    public interface IPostRepository
    {
        IEnumerable<Post> ListarTodos();
    }
}
