using Repository.Interface;
using Data;
using Dominio;

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
    }
}
