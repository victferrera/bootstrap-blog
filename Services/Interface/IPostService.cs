using Dominio;
using System.Collections.Generic;

namespace Services.Interface
{
    public interface IPostService
    {
        IEnumerable<Post> ListarTodos();
    }
}
