using Repository.Interface;
using Services.Interface;
using Services.Models;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class AutorService : IAutorService
    {
        private readonly IAutorRepository _repository;
        public AutorService(IAutorRepository repository)
        {
            _repository = repository;
        }

        public void Criar(AutorViewModel viewModel)
        {
            Autor autor = new Autor()
            {
                Nome = viewModel.Nome,
                Biografia = viewModel.Biografia,
                Youtube = viewModel.Youtube,
                Twitter = viewModel.Twitter,
                Github = viewModel.Github,
                Linkedin = viewModel.Linkedin,
                DataCriacao = DateTime.Now
            };
 
            _repository.Criar(autor);
        }

        public IEnumerable<Autor> ListarTodos()
        {
            return _repository.ListarTodos();
        }

        public Autor ProcurarPorId(int id)
        {
           return _repository.ProcurarPorIdTrazerPosts(id);
        }

        public void Remover(AutorViewModel autor)
        {
            var resultadoBuscaPorId = _repository.ProcurarPorId(autor.Id);
            _repository.Remover(resultadoBuscaPorId);
        }
    }
}
