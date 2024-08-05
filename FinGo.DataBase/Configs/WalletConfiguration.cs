using FinGo.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinGo.DataBase.Configs;

internal class WalletConfiguration : IEntityTypeConfiguration<Wallet>
{
    public void Configure(EntityTypeBuilder<Wallet> builder)
    {
        builder
            .HasKey(k => k.Id);

        builder
            .Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(50);
    }
}
