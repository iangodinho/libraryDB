using LibraryManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace LibraryManagement.Configurations
{
    public class GeneroConfigurations : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.HasKey(g => g.Id);

            builder.Property(g => g.Id)
                   .HasColumnName($"{nameof(Genero)}Id")
                   .ValueGeneratedOnAdd()
                   .IsRequired();

            builder.Property(g => g.NomeGenero)
                   .IsRequired()
                   .HasMaxLength(30);

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
