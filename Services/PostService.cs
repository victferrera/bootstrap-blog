﻿using Dominio;
using Repository.Interface;
using Services.Interface;
using Services.Models;
using System.Collections.Generic;
using System;

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
                Titulo = viewModel.Titulo,
                Subtitulo = viewModel.Subtitulo,
                Conteudo = viewModel.Conteudo,
                DataCriacao = viewModel.DataCriacao.GetHashCode() == 0 ? DateTime.Now : viewModel.DataCriacao,
                AutorId = viewModel.AutorId
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
                Autor = post.Autor
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
            return ConverterPostParaViewModel(_repository.ProcurarPorId(id));
        }
    }
}
