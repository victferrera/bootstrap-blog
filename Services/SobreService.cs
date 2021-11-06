using Dominio;
using Services.Interface;
using Services.Models;

namespace Services
{
    public class SobreService : ISobreService
    {
        public Sobre ConverterSobreViewModelParaSobre(SobreViewModel viewModel)
        {
            Sobre sobre = new Sobre
            {
                Descricao = viewModel.Descricao,
                Conteudo = viewModel.Conteudo,
                StatusAtivo = viewModel.StatusAtivo == true ? 'S' : 'N'
            };
        }

        public void Criar(SobreViewModel viewModel)
        {
            throw new System.NotImplementedException();
        }
    }
}
