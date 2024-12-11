using LibraryManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace LibraryManagement.Configurations
{
    public class EmprestimoConfigurations : IEntityTypeConfiguration<Emprestimo>
    {
        public void Configure(EntityTypeBuilder<Emprestimo> builder)
        {
            builder.HasKey(em => em.Id);

            builder.Property(em => em.DataEmprestimo)
                   .IsRequired();

            builder.Property(em => em.DataDevolucao)
                   .IsRequired();

            builder.Property(em => em.StatusEmprestimo)
                   .IsRequired();

            builder.HasOne(em => em.Usuario)
                   .WithMany(u => u.Emprestimos)
                   .HasForeignKey(em => em.CPFUsuario)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(em => em.Exemplar)
                   .WithMany(ex => ex.Emprestimos)
                   .HasForeignKey(em => em.ExemplarID)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
