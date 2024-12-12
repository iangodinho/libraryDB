using LibraryManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace LibraryManagement.Configurations
{
    public class ExemplarConfigurations : IEntityTypeConfiguration<Exemplar>
    {
        public void Configure(EntityTypeBuilder<Exemplar> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                   .HasColumnName($"{nameof(Exemplar)}Id")
                   .ValueGeneratedOnAdd()
                   .IsRequired();

            builder.Property(ex => ex.Status)
                   .IsRequired();

            builder.HasOne(ex => ex.Livro)
                   .WithMany(l => l.Exemplares)
                   .HasForeignKey(ex => ex.LivroId);

            builder.HasOne(ex => ex.Biblioteca)
                   .WithMany(b => b.Exemplares)
                   .HasForeignKey(ex => ex.BibliotecaId);

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
