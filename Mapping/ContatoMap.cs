using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio;

namespace Mapping
{
    public class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.ToTable("Contatos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(60).IsRequired();
            builder.Property(x => x.Mensagem).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.DataEnvio);
        }
    }
}
