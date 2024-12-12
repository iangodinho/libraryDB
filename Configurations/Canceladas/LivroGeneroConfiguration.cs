using LibraryManagement.Entities.Canceladas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace LibraryManagement.Configurations.Canceladas
{
    public class LivroGeneroConfiguration : IEntityTypeConfiguration<LivroGenero>
    {
        public void Configure(EntityTypeBuilder<LivroGenero> builder)
        {
            builder.HasKey(lg => lg.LivroGeneroID);

            builder.HasOne(lg => lg.Livro)
                   .WithMany(l => l.LivroGeneros)
                   .HasForeignKey(lg => lg.ISBN);

            builder.HasOne(lg => lg.Genero)
                   .WithMany(g => g.LivroGeneros)
                   .HasForeignKey(lg => lg.GeneroID);
        }
    }
}
