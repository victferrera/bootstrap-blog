using Microsoft.EntityFrameworkCore;
using Dominio;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mapping
{
    public class SobreMap : IEntityTypeConfiguration<Sobre>
    {
        public void Configure(EntityTypeBuilder<Sobre> builder)
        {
            builder.ToTable("Sobre");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descricao).HasMaxLength(60).IsRequired();
            builder.Property(x => x.Conteudo).IsRequired();
            builder.Property(x => x.StatusAtivo).IsRequired();
            builder.Property(x => x.DataCriacao).IsRequired();
            builder.Property(x => x.DataUltimaAlteracao);
        }
    }
}
