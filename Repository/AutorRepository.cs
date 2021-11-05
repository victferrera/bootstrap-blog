using Repository.Interface;
using Data;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class AutorRepository : IAutorRepository
    {
        private readonly AppDbContext _context;
        public AutorRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Criar(Autor autor)
        {

            _context.Autor.Add(autor);
            _context.SaveChanges();

        }

        public IEnumerable<Autor> ListarTodos()
        {
            return _context.Autor.ToList();
        }

        public Autor ProcurarPorIdTrazerPosts(int id)
        {
            return _context.Autor.Include(x => x.Posts).FirstOrDefault(x => x.Id == id);
        }

        public Autor ProcurarPorId(int id)
        {
            return _context.Autor.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(Autor autor)
        {
            _context.Remove(autor);
            _context.SaveChanges();
        }
    }
}
