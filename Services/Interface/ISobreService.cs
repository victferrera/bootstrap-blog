using Dominio;
using Services.Models;
using System.Collections.Generic;

namespace Services.Interface
{
    public interface ISobreService
    {
        Sobre ConverterSobreViewModelParaSobre(SobreViewModel sobre);
        void Criar(SobreViewModel viewModel);
        void AlterarStatusAtivo();
        ListarSobresViewModel ListarTodos();
    }
}
