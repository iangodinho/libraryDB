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
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                   .HasColumnName($"{nameof(Emprestimo)}Id")
                   .ValueGeneratedOnAdd()
                   .IsRequired();

            builder.Property(em => em.DataEmprestimo)
                   .IsRequired();

            builder.Property(em => em.DataDevolucao)
                   .IsRequired();

            builder.Property(em => em.StatusEmprestimo)
                   .IsRequired();

            builder.HasOne(em => em.Usuario)
                   .WithMany(u => u.Emprestimos)
                   .HasForeignKey(em => em.UsuarioId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(em => em.Exemplar)
                   .WithMany(ex => ex.Emprestimos)
                   .HasForeignKey(em => em.ExemplarId)
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
