using LibraryManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace LibraryManagement.Configurations
{
    public class GeneroConfigurations : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.HasKey(g => g.Id);

            builder.Property(g => g.NomeGenero)
                   .IsRequired()
                   .HasMaxLength(30);
        }
    }
}
