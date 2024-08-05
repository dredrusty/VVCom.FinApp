using FinGo.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinGo.DataBase.Configs;

internal class CredentialConfiguration : IEntityTypeConfiguration<Credential>
{
    public void Configure(EntityTypeBuilder<Credential> builder)
    {
        builder
            .HasKey(k => k.Id);

        builder
            .Property(p => p.Login)
            .IsRequired()
            .HasMaxLength(50);

        builder
            .Property(p => p.Password)
            .IsRequired()
            .HasMaxLength(50);

        Seed(builder);
    }

    private void Seed(EntityTypeBuilder<Credential> builder)
    {
        builder.HasData(new Credential { Id = 1, Login = "superadmin", Password = "super12345" });
    }
}
