using Dominio;
using Repository.Interface;
using System.Linq;
using System.Collections.Generic;
using Data;

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
    }
}
