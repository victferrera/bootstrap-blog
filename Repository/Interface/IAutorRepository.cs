using Dominio;
using System.Collections.Generic;

namespace Repository.Interface
{
    public interface IAutorRepository
    {
        void Criar(Autor autor);
        IEnumerable<Autor> ListarTodos();
    }
}
