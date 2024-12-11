using LibraryManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace LibraryManagement.Configurations
{
    public class ExemplarConfigurations : IEntityTypeConfiguration<Exemplar>
    {
        public void Configure(EntityTypeBuilder<Exemplar> builder)
        {
            builder.HasKey(ex => ex.Id);

            builder.Property(ex => ex.Status)
                   .IsRequired();

            builder.HasOne(ex => ex.Livro)
                   .WithMany(l => l.Exemplares)
                   .HasForeignKey(ex => ex.ISBN);

            builder.HasOne(ex => ex.Biblioteca)
                   .WithMany(b => b.Exemplares)
                   .HasForeignKey(ex => ex.BibliotecaID);
        }
    }
}
