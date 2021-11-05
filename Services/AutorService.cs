using Repository.Interface;
using Services.Interface;
using Services.Models;
using Dominio;
using System;
using System.Collections.Generic;

namespace Services
{
    public class AutorService : IAutorService
    {
        private readonly IAutorRepository _repository;
        public AutorService(IAutorRepository repository)
        {
            _repository = repository;
        }

        public Autor ConverterParaAutor(AutorViewModel viewModel)
        {
            Autor autor = new Autor
            {
                Id = viewModel.Id,
                Nome = viewModel.Nome,
                Youtube = viewModel.Youtube,
                Twitter = viewModel.Twitter,
                Linkedin = viewModel.Linkedin,
                Github = viewModel.Github,                
                Biografia = viewModel.Biografia,
                DataCriacao = viewModel.DataCriacao
            };

            return autor;
        }

        public AutorViewModel ConverterParaAutorViewModel(Autor autor)
        {
            AutorViewModel viewModel = new AutorViewModel
            {
                Id = autor.Id,
                Nome = autor.Nome,
                Youtube = autor.Youtube,
                Twitter = autor.Twitter,
                Linkedin = autor.Linkedin,
                Github = autor.Github,
                DataCriacao = autor.DataCriacao,
                Biografia = autor.Biografia,
                Posts = autor.Posts  
            };

            return viewModel;
        }

        public void Criar(AutorViewModel viewModel)
        {
            _repository.Criar(ConverterParaAutor(viewModel));
        }

        public IEnumerable<Autor> ListarTodos()
        {
            return _repository.ListarTodos();
        }

        public Autor ProcurarPorId(int id)
        {
           return _repository.ProcurarPorId(id);
        }

        public Autor ProcurarPorIdTrazerPosts(int id)
        {
           return _repository.ProcurarPorIdTrazerPosts(id);
        }

        public void Remover(AutorViewModel autor)
        {
            var resultadoBuscaPorId = _repository.ProcurarPorId(autor.Id);
            _repository.Remover(resultadoBuscaPorId);
        }

        public void Editar(AutorViewModel viewModel)
        {
            _repository.Editar(ConverterParaAutor(viewModel));
        }
    }
}
