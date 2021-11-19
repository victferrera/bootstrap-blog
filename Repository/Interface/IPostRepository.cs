﻿using Dominio;
using System.Collections.Generic;

namespace Repository.Interface
{
    public interface IPostRepository
    {
        IEnumerable<Post> ListarTodos();
        void Criar(Post post);
        IEnumerable<Post> ListarTodosComAutor();
        Post ProcurarPorId(int id);
        void Remover(Post post);
        void Editar(Post post);
        Post ProcurarPorIdEIncluirAutor(int id);

    }
}
