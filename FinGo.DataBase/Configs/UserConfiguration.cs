using FinGo.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinGo.DataBase.Configs;

internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder
            .HasKey(k => k.Id);

        builder
            .Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder
            .Property(p => p.Email)
            .IsRequired()
            .HasMaxLength(100);

        builder
            .HasOne(e => e.Credential)
            .WithOne(e => e.User)
            .HasForeignKey<Credential>(e => e.Id)
            .IsRequired();

        Seed(builder);
    }

    private void Seed(EntityTypeBuilder<User> builder)
    {
        builder
            .HasData(new User
            {
                Id = 1,
                Name = "superadmin",
                Email = "super@super.com",
            });

        builder
            .HasMany(r => r.Role)
            .WithMany(u => u.User)
            .UsingEntity(c => c.HasData(new { UserId = 1, RoleId = 1 }));
    }
}
