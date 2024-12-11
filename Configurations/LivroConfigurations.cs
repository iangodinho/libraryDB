using LibraryManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace LibraryManagement.Configurations
{
    public class LivroConfigurations : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.HasKey(l => l.ISBN);

            builder.Property(l => l.NomeLivro)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(l => l.QntdPaginas)
                   .IsRequired();

            builder.HasOne(l => l.Editora)
                   .WithMany(e => e.Livros)
                   .HasForeignKey(l => l.EditoraID);
        }
    }
}
