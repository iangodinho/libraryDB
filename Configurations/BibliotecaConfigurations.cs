using LibraryManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace LibraryManagement.Configurations
{
    public class BibliotecaConfigurations : IEntityTypeConfiguration<Biblioteca>
    {
        public void Configure(EntityTypeBuilder<Biblioteca> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Id)
                   .HasColumnName($"{nameof(Biblioteca)}Id")
                   .ValueGeneratedOnAdd()
                   .IsRequired();

            builder.Property(b => b.NomeBiblioteca)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(b => b.TelefoneBiblioteca)
                   .IsRequired()
                   .HasMaxLength(11);

            builder.Property(b => b.EmailBiblioteca)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasOne(b => b.Endereco)
                   .WithMany(e => e.Bibliotecas)
                   .HasForeignKey(b => b.EnderecoId);

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
