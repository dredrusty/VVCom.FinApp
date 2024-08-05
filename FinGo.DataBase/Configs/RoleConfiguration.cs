using FinGo.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinGo.DataBase.Configs;

internal class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder
            .HasKey(k => k.Id);

        builder
            .Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100);

        Seed(builder);
    }

    private void Seed(EntityTypeBuilder<Role> builder)
    {
        List<Role> roles =
        [
            new Role { Id = 1, Name = "Admin" },
            new Role { Id = 2, Name = "User" }
        ];

        builder.HasData(roles);
    }
}
