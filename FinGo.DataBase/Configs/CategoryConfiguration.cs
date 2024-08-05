using FinGo.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinGo.DataBase.Configs;

internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder
            .HasKey(k => k.Id);

        builder
            .Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100);
    }
}
