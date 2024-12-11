using LibraryManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace LibraryManagement.Configurations
{
    public class AutorConfigurations : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.NomeAutor)
                   .IsRequired()
                   .HasMaxLength(80);
        }
    }
}
