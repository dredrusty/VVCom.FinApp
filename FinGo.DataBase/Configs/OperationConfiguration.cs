using FinGo.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinGo.DataBase.Configs;

internal class OperationConfiguration : IEntityTypeConfiguration<Operation>
{
    public void Configure(EntityTypeBuilder<Operation> builder)
    {
        builder
            .HasKey(k => k.Id);

        builder
            .Property(p => p.Sum)
            .IsRequired()
            .HasPrecision(9, 2);

        builder
            .Property(p => p.CreatedAt)
            .IsRequired();
    }
}
