using Repository.Interface;
using Services.Interface;
using Services.Models;
using Dominio;
using System;

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
    }
}
