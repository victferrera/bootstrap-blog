using Dominio;
using Repository.Interface;
using Services.Interface;
using Services.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Services
{
    public class PostService : IPostService
    {
        public IPostRepository _repository;
        public IAutorService _autorService;
        public PostService(IPostRepository repository, IAutorService autorService)
        {
            _repository = repository;
            _autorService = autorService;
        }

        public Post ConverterViewModelParaPost(PostViewModel viewModel)
        {
            Post post = new Post
            {
                Id = viewModel.Id,
                Titulo = viewModel.Titulo,
                Subtitulo = viewModel.Subtitulo,
                Conteudo = viewModel.Conteudo,
                DataCriacao = viewModel.DataCriacao.GetHashCode() == 0 ? DateTime.Now : viewModel.DataCriacao,
                AutorId = viewModel.AutorId,
                DataUltimaAlteracao = viewModel.DataUltimaAlteracao,
                AlteradoPor = viewModel.AlteradoPor
            };

            return post;
        }

        public PostViewModel ConverterPostParaViewModel(Post post)
        {
            var viewModel = new PostViewModel
            {
                Id = post.Id,
                Titulo = post.Titulo,
                Subtitulo = post.Subtitulo,
                Conteudo = post.Conteudo,
                DataCriacao = post.DataCriacao,
                Autor = post.Autor,
                AutorId = post.AutorId
            };

            return viewModel;
        }

        public IEnumerable<Post> ListarTodos()
        {
            return _repository.ListarTodos();
        }

        public void Criar(PostViewModel viewModel)
        {
            _repository.Criar(ConverterViewModelParaPost(viewModel));
        }

        public ListarPostsViewModel PostsParaIndex()
        {
            var posts = new ListarPostsViewModel
            {
                Posts = _repository.ListarTodosComAutor()
            };

            return posts;
        }

        public PostViewModel Visualizar(int id)
        {
            return ConverterPostParaViewModel(_repository.ProcurarPorIdEIncluirAutor(id));
        }

        public void Remover(int id)
        {
            _repository.Remover(_repository.ProcurarPorId(id));
        }

        public Post ProcurarPorId(int id)
        {
            return _repository.ProcurarPorId(id);
        }

        public Post ProcurarPorIdEIncluirAutor(int id)
        {
            return _repository.ProcurarPorIdEIncluirAutor(id);
        }

        public void Editar(PostViewModel viewModel)
        {
            var post = ConverterViewModelParaPost(viewModel);
            _repository.Editar(post);
        }

        public IQueryable<Post> ListarTodosQueryable()
        {
            return _repository.ListarTodosQueryable();
        }
    }
}
