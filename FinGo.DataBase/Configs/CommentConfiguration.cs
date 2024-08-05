using FinGo.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinGo.DataBase.Configs;

internal class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder
            .HasKey(k => k.Id);

        builder
            .Property(p => p.Text)
            .IsRequired()
            .HasMaxLength(500);

        builder
            .Property(p => p.CreatedAt)
            .IsRequired();
    }
}
