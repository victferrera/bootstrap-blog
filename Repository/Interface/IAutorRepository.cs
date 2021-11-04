using Dominio;
using System.Collections.Generic;

namespace Repository.Interface
{
    public interface IAutorRepository
    {
        void Criar(Autor autor);
        IEnumerable<Autor> ListarTodos();
        Autor ProcurarPorId(int id);

        void Remover(Autor autor);
    }
}
