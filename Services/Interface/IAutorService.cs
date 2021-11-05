using Dominio;
using Services.Models;
using System.Collections.Generic;

namespace Services.Interface
{
    public interface IAutorService
    {
        void Criar(AutorViewModel autor);
        IEnumerable<Autor> ListarTodos();
        Autor ProcurarPorId(int id);
        Autor ProcurarPorIdTrazerPosts(int id);
        void Editar(AutorViewModel viewModel);
        void Remover(AutorViewModel autor);
        AutorViewModel ConverterParaAutorViewModel(Autor autor);
    }
}
