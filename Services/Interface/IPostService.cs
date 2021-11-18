using Dominio;
using Services.Models;
using System.Collections.Generic;

namespace Services.Interface
{
    public interface IPostService
    {
        IEnumerable<Post> ListarTodos();
        Post ConverterViewModelParaPost(PostViewModel viewModel);
        void Criar(PostViewModel viewModel);
        ListarPostsViewModel PostsParaIndex();
        PostViewModel Visualizar(int id);
        PostViewModel ConverterPostParaViewModel(Post post);
        void Remover(int id);
        Post ProcurarPorId(int id);
    }
}
