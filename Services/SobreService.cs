using Dominio;
using System;
using Repository;
using Repository.Interface;
using Services.Interface;
using Services.Models;
using System.Collections.Generic;

namespace Services
{
    public class SobreService : ISobreService
    {
        private readonly ISobreRepository _repository;
        public SobreService(ISobreRepository repository)
        {
            _repository = repository;
        }

        public Sobre ConverterSobreViewModelParaSobre(SobreViewModel viewModel)
        {
            Sobre sobre = new Sobre
            {
                Id = viewModel.Id,
                Descricao = viewModel.Descricao,
                Conteudo = viewModel.Conteudo,
                StatusAtivo = viewModel.StatusAtivo == true ? 'S' : 'N',
                DataUltimaAlteracao = DateTime.Now
                
            };

            return sobre;
        }

        public void Criar(SobreViewModel viewModel)
        {
            if (viewModel.StatusAtivo == true)
                _repository.AlterarStatusAtivo(_repository.ProcurarPorTipoStatus('S'));

            _repository.Criar(ConverterSobreViewModelParaSobre(viewModel));
        }

        public ListarSobresViewModel ListarTodos()
        {
            ListarSobresViewModel viewModel = new ListarSobresViewModel()
            {
                Sobres = _repository.ListarTodos()
            };

            return viewModel;
        }

        public SobreViewModel ProcurarPorId(int id)
        {
            if (_repository.ProcurarPorId(id) == null)
                return null;
            return ConverterParaViewModel(_repository.ProcurarPorId(id));
        }

        public SobreViewModel ConverterParaViewModel(Sobre sobre)
        {
            SobreViewModel viewModel = new SobreViewModel()
            {
                Descricao = sobre.Descricao,
                Conteudo = sobre.Conteudo,
                Id = sobre.Id,
                StatusAtivoFormatoChar = sobre.StatusAtivo,
                DataCriacao = sobre.DataCriacao,
                DataUltimaAlteracao = sobre.DataUltimaAlteracao
            };

            return viewModel;
        }

        public void Remover(SobreViewModel viewModel)
        {
            _repository.Remover(_repository.ProcurarPorId(viewModel.Id));
        }

        public SobreViewModel ProcurarPorStatus(char status)
        {
            return ConverterParaViewModel(_repository.ProcurarPorTipoStatus(status));
        }

        public void Editar(SobreViewModel viewModel)
        {
            _repository.Editar(ConverterSobreViewModelParaSobre(viewModel));
        }
    }
}
