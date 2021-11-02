using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mapping
{
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Posts");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Titulo).IsRequired();
            builder.Property(x => x.Subtitulo).IsRequired();
            builder.Property(x => x.Conteudo).IsRequired();
            builder.Property(x => x.DataCriacao).IsRequired();
            builder.Property(x => x.DataUltimaAlteracao);
            builder.Property(x => x.AlteradoPor);
            builder.HasOne(x => x.Autor).WithMany(x => x.Posts);
        }
    }
}
