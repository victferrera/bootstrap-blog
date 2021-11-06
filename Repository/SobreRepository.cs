using Data;
using Dominio;
using Microsoft.EntityFrameworkCore;
using Repository.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class SobreRepository : ISobreRepository
    {
        private readonly AppDbContext _context;
        public SobreRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AlterarStatusAtivo(Sobre sobre)
        {
            sobre.StatusAtivo = 'N';
            _context.Entry(sobre).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Criar(Sobre sobre)
        {
            _context.Sobre.Add(sobre);
            _context.SaveChanges();
        }

        public IEnumerable<Sobre> ListarTodos()
        {
            return _context.Sobre.ToList();
        }

        public Sobre ProcurarPorTipoStatus(char status)
        {
            return _context.Sobre.SingleOrDefault(x => x.StatusAtivo == status);
        }
    }
}
