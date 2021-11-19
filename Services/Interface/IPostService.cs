using Dominio;
using Services.Models;
using System.Collections.Generic;
using System.Linq;

namespace Services.Interface
{
    public interface IPostService
    {
        IEnumerable<Post> ListarTodos();
        IQueryable<Post> ListarTodosQueryable();
        Post ConverterViewModelParaPost(PostViewModel viewModel);
        void Criar(PostViewModel viewModel);
        ListarPostsViewModel PostsParaIndex();
        PostViewModel Visualizar(int id);
        PostViewModel ConverterPostParaViewModel(Post post);
        void Remover(int id);
        Post ProcurarPorId(int id);
        void Editar(PostViewModel viewModel);
        Post ProcurarPorIdEIncluirAutor(int id);
    }
}
