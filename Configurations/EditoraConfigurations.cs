using LibraryManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace LibraryManagement.Configurations
{
    public class EditoraConfigurations : IEntityTypeConfiguration<Editora>
    {
        public void Configure(EntityTypeBuilder<Editora> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                   .HasColumnName($"{nameof(Editora)}Id")
                   .ValueGeneratedOnAdd()
                   .IsRequired();

            builder.Property(e => e.NomeEditora)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.Property(e => e.Cidade)
                   .IsRequired()
                   .HasMaxLength(50);

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
