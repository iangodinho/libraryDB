using LibraryManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace LibraryManagement.Configurations
{
    public class EnderecosConfigurations : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                   .HasColumnName($"{nameof(Endereco)}Id")
                   .ValueGeneratedOnAdd()
                   .IsRequired();

            builder.Property(e => e.Logradouro)
                   .IsRequired()
                   .HasMaxLength(80);

            builder.Property(e => e.Numero)
                   .IsRequired()
                   .HasMaxLength(10);

            builder.Property(e => e.Complemento)
                   .HasMaxLength(50);

            builder.Property(e => e.Bairro)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(e => e.Cidade)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(e => e.CEP)
                   .IsRequired()
                   .HasMaxLength(8);

            builder.HasOne(e => e.EstadosBrasileiros)
                   .WithMany(eb => eb.Enderecos)
                   .HasForeignKey(e => e.EstadosBrasileirosId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.NoAction);

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
