using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("user");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.UserName)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Email)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Password)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasMany(p => p.Rols)
        .WithMany(r => r.Users)
        .UsingEntity<UserRol>(
        j => j
        .HasOne(pt => pt.Rol)
        .WithMany(t => t.UsersRols)
        .HasForeignKey(ut => ut.RolId),

        j => j
        .HasOne(et => et.User)
        .WithMany(et => et.UsersRols)
        .HasForeignKey(el => el.UserId),

        j =>
        {
            j.ToTable("userRol");
            j.HasKey(t => new { t.UserId, t.RolId });
        });
        
        builder.HasMany(p => p.RefreshTokens)
        .WithOne(p => p.User)
        .HasForeignKey(p => p.UserId);
    }
}
