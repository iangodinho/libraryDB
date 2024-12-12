using LibraryManagement.Entities.Canceladas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace LibraryManagement.Configurations.Canceladas
{
    public class AutorLivroConfigurations : IEntityTypeConfiguration<AutorLivro>
    {
        public void Configure(EntityTypeBuilder<AutorLivro> builder)
        {
            builder.HasKey(al => new { al.ISBN, al.AutorID });

            builder.HasOne(al => al.Livro)
                   .WithMany(l => l.AutorLivros)
                   .HasForeignKey(al => al.ISBN)
                   .IsRequired();

            builder.HasOne(al => al.Autor)
                   .WithMany(a => a.AutorLivros)
                   .HasForeignKey(al => al.AutorID)
                   .IsRequired();
        }
    }
}
