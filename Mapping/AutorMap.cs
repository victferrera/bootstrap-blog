using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mapping
{
    public class AutorMap : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            builder.ToTable("Autor");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(60).IsRequired();
            builder.Property(x => x.Biografia).IsRequired();
            builder.Property(x => x.Youtube);
            builder.Property(x => x.Linkedin);
            builder.Property(x => x.Twitter);
            builder.Property(x => x.Github);
            builder.Property(x => x.DataCriacao).IsRequired();
            builder.HasMany(x => x.Posts).WithOne(x => x.Autor);
        }
    }
}
