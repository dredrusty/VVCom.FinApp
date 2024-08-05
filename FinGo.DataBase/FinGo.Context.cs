using FinGo.DataBase.Configs;
using FinGo.DataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace FinGo.DataBase;

public class FinGoContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public DbSet<Credential> Credentials { get; set; }

    public DbSet<Wallet> Wallets { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Operation> Operations { get; set; }

    public DbSet<Comment> Comments { get; set; }

    public DbSet<Role> Roles { get; set; }

    public FinGoContext()
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseNpgsql("Host=localhost;Port=5432;Database=FinGo;Username=postgres;Password=vVcoM_14$3022")
            .LogTo(Console.WriteLine)
            .UseLazyLoadingProxies(true);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new WalletConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new OperationConfiguration());
        modelBuilder.ApplyConfiguration(new CommentConfiguration());
        modelBuilder.ApplyConfiguration(new CredentialConfiguration());
        modelBuilder.ApplyConfiguration(new RoleConfiguration());
    }
}
