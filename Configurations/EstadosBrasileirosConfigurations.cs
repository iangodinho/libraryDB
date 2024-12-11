using LibraryManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace LibraryManagement.Configurations
{
    public class EstadosBrasileirosConfigurations : IEntityTypeConfiguration<EstadosBrasileiros>
    {
        public void Configure(EntityTypeBuilder<EstadosBrasileiros> builder)
        {
            builder.HasKey(eb => eb.UF);

            builder.Property(eb => eb.Estado)
                   .IsRequired()
                   .HasMaxLength(30);
        }
    }
}
