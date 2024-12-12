using LibraryManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace LibraryManagement.Configurations
{
    public class DevolucaoConfigurations : IEntityTypeConfiguration<Devolucao>
    {
        public void Configure(EntityTypeBuilder<Devolucao> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Id)
                   .HasColumnName($"{nameof(Devolucao)}Id")
                   .ValueGeneratedOnAdd()
                   .IsRequired();

            builder.Property(dv => dv.DataDevolucao)
                   .IsRequired();

            builder.HasOne(dv => dv.Exemplar)
                   .WithMany(ex => ex.Devolucoes)
                   .HasForeignKey(dv => dv.ExemplarId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(dv => dv.Usuario)
                   .WithMany(u => u.Devolucoes)
                   .HasForeignKey(dv => dv.UsuarioId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(dv => dv.Emprestimo)
                   .WithMany(em => em.Devolucoes)
                   .HasForeignKey(dv => dv.EmprestimoId)
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
