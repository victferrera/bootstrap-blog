using Dominio;

namespace Repository.Interface
{
    public interface ISobreRepository
    {
        void Criar(Sobre sobre);
        void AlterarStatusAtivo(Sobre sobre);
        Sobre ProcurarPorTipoStatus(char status);
    }
}
