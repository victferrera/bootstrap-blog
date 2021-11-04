using Dominio;
using Services.Models;
using System.Collections.Generic;

namespace Services.Interface
{
    public interface IAutorService
    {
        void Criar(AutorViewModel autor);
        IEnumerable<Autor> ListarTodos();
    }
}
