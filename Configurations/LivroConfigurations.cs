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
            builder.HasKey(l => l.Id);

            builder.Property(l => l.Id)
                   .HasColumnName($"{nameof(Livro)}Id")
                   .ValueGeneratedOnAdd()
                   .IsRequired();

            builder.Property(l => l.ISBN)
                   .IsRequired()
                   .HasMaxLength(13);

            builder.Property(l => l.NomeLivro)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(l => l.QntdPaginas)
                   .IsRequired();

            builder.HasOne(l => l.Editora)
                   .WithMany(e => e.Livros)
                   .HasForeignKey(l => l.EditoraId);

            builder.HasMany(g => g.Generos)
                   .WithMany(l => l.Livros)
                   .UsingEntity(j => j.ToTable("LivroGeneros"));

            builder.HasOne(a => a.Autor)
                   .WithMany(l => l.Livros)
                   .HasForeignKey(a => a.AutorId);

            builder.Property(p => p.DataHoraInclusao)
                   .IsRequired();

            builder.Property(p => p.UsuarioInclusao)
                   .HasMaxLength(30)
                   .IsRequired();

            builder.Property(p => p.DataHoraAlteracao)
                   .IsRequired();

            builder.Property(p => p.UsuarioAlteracao)
                   .HasMaxLength(30)
                   .IsRequired();

            builder.Property(p => p.IsActive)
                   .IsRequired();
        }
    }
}
