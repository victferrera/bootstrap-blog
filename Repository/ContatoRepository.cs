using Data;
using Dominio;
using Repository.Interface;

namespace Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly AppDbContext _context;
        public ContatoRepository(AppDbContext context)
        {
            _context = context;
        }

        public void SalvarContato(Contato contato)
        {
            _context.Contato.Add(contato);
            _context.SaveChanges();
        }
    }
}
