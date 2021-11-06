using Dominio;
using Services.Models;

namespace Services.Interface
{
    interface ISobreService
    {
        Sobre ConverterSobreViewModelParaSobre(Sobre sobre);
        void Criar(SobreViewModel viewModel);
    }
}
