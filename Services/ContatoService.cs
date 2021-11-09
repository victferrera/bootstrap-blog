using Dominio;
using Services.Interface;
using Repository.Interface;
using Services.Models;
using System;

namespace Services
{
    public class ContatoService : IContatoService
    {
        private readonly IContatoRepository _repository;
        public ContatoService(IContatoRepository repository)
        {
            _repository = repository;
        }
        public Contato ConverterViewModelParaContato(ContatoViewModel viewModel)
        {
            Contato contato = new Contato
            {
                Nome = viewModel.Nome,
                Email = viewModel.Email,
                Mensagem = viewModel.Mensagem,
                DataEnvio = DateTime.Now
            };

            return contato;
        }
        public void Salvar(ContatoViewModel viewModel)
        {
            _repository.SalvarContato(ConverterViewModelParaContato(viewModel));
        }
    }
}
