using Dominio;
using Repository;
using Repository.Interface;
using Services.Interface;
using Services.Models;

namespace Services
{
    public class SobreService : ISobreService
    {
        private readonly ISobreRepository _repository;
        public SobreService(ISobreRepository repository)
        {
            _repository = repository;
        }

        public void AlterarStatusAtivo()
        {
            throw new System.NotImplementedException();
        }

        public Sobre ConverterSobreViewModelParaSobre(SobreViewModel viewModel)
        {
            Sobre sobre = new Sobre
            {
                Descricao = viewModel.Descricao,
                Conteudo = viewModel.Conteudo,
                StatusAtivo = viewModel.StatusAtivo == true ? 'S' : 'N',
                DataCriacao = viewModel.DataCriacao
            };

            return sobre;
        }

        public void Criar(SobreViewModel viewModel)
        {
            if(viewModel.StatusAtivo == true)           
                _repository.AlterarStatusAtivo(_repository.ProcurarPorTipoStatus('S'));
            
            _repository.Criar(ConverterSobreViewModelParaSobre(viewModel));
        }

        public Sobre ProcurarPorTipoStatus()
        {
            throw new System.NotImplementedException();
        }
    }
}
