using Dominio;
using Services.Models;

namespace Services.Interface
{
    interface ISobreService
    {
        Sobre ConverterSobreViewModelParaSobre(SobreViewModel sobre);
        void Criar(SobreViewModel viewModel);
    }
}
