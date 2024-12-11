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
            builder.HasKey(dv => dv.Id);

            builder.Property(dv => dv.DataDevolucao)
                   .IsRequired();

            builder.HasOne(dv => dv.Exemplar)
                   .WithMany(ex => ex.Devolucoes)
                   .HasForeignKey(dv => dv.ExemplarID)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(dv => dv.Usuario)
                   .WithMany(u => u.Devolucoes)
                   .HasForeignKey(dv => dv.CPFUsuario)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(dv => dv.Emprestimo)
                   .WithMany(em => em.Devolucoes)
                   .HasForeignKey(dv => dv.EmprestimoID)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
