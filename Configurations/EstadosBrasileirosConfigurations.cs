using LibraryManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace LibraryManagement.Configurations
{
    public class EstadosBrasileirosConfigurations : IEntityTypeConfiguration<EstadosBrasileiros>
    {
        public void Configure(EntityTypeBuilder<EstadosBrasileiros> builder)
        {
            builder.HasKey(eb => eb.Id);

            builder.Property(eb => eb.Id)
                   .HasColumnName($"{nameof(EstadosBrasileiros)}Id")
                   .ValueGeneratedOnAdd()
                   .IsRequired();

            builder.Property(eb => eb.UF)
                   .IsRequired()
                   .HasMaxLength(2);

            builder.Property(eb => eb.Estado)
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
