using Dominio;
using System.Collections.Generic;

namespace Repository.Interface
{
    public interface ISobreRepository
    {
        void Criar(Sobre sobre);
        void AlterarStatusAtivo(Sobre sobre);
        Sobre ProcurarPorTipoStatus(char status);
        IEnumerable<Sobre> ListarTodos();
        Sobre ProcurarPorId(int id);
    }
}
