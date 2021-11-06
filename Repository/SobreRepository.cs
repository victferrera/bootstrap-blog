using Data;
using Dominio;
using Repository.Interface;

namespace Repository
{
    public class SobreRepository : ISobreRepository
    {
        private readonly AppDbContext _context;
        public SobreRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Criar(Sobre sobre)
        {
            _context.Sobre.Add(sobre);
            _context.SaveChanges();
        }
    }
}
