using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class PresentacionConfiguration : IEntityTypeConfiguration<Presentacion>
{
    public void Configure(EntityTypeBuilder<Presentacion> builder)
    {
        builder.ToTable("presentacion");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(50);
        
    }
}
