using Dominio;
using Repository.Interface;
using System.Linq;
using System.Collections.Generic;
using Data;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly AppDbContext _context;
        public PostRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Criar(Post post)
        {
            _context.Post.Add(post);
            _context.SaveChanges();
        }

        public IEnumerable<Post> ListarTodos()
        {
            return _context.Post.ToList();
        }

        public IEnumerable<Post> ListarTodosComAutor()
        {
            return _context.Post.Include(x => x.Autor).ToList();
        }

        public Post ProcurarPorId(int id)
        {
            return _context.Post.SingleOrDefault(x => x.Id == id);
        }

        public void Remover(Post post)
        {
            _context.Post.Remove(post);
            _context.SaveChanges();
        }

        public void Editar(Post post)
        {
            _context.Entry(post).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public Post ProcurarPorIdEIncluirAutor(int id)
        {
            return _context.Post.Include(x => x.Autor).SingleOrDefault(x => x.Id == id);
        }
    }
}
