using Microsoft.EntityFrameworkCore;
using Dominio;
using Mapping;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Contato> Contato { get; set; }
        public DbSet<Sobre> Sobre { get; set; }
        public DbSet<Post> Post { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AutorMap());
            modelBuilder.ApplyConfiguration(new SobreMap());
            modelBuilder.ApplyConfiguration(new ContatoMap());
            modelBuilder.ApplyConfiguration(new PostMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
