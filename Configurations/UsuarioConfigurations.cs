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
            builder.HasKey(u => u.CPFUsuario);

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
                   .HasForeignKey(u => u.EnderecoID);
        }
    }
}
