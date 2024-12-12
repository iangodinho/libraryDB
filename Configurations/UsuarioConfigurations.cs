using LibraryManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace LibraryManagement.Configurations
{
    public class UsuarioConfigurations : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
                   .HasColumnName($"{nameof(Usuario)}Id")
                   .ValueGeneratedOnAdd()
                   .IsRequired();

            builder.Property(u => u.CPFUsuario)
                   .IsRequired()
                   .HasMaxLength(11);

            builder.Property(u => u.NomeUsuario)
                   .IsRequired()
                   .HasMaxLength(80);

            builder.Property(u => u.DataNascimentoUsuario)
                   .IsRequired();

            builder.Property(u => u.TelefoneUsuario)
                   .IsRequired()
                   .HasMaxLength(11);

            builder.HasOne(u => u.Endereco)
                   .WithMany(e => e.Usuarios)
                   .HasForeignKey(u => u.EnderecoId);

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
