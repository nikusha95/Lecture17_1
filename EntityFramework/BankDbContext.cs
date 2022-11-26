using EntityFramework.Configurations;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework;

public class BankDbContext : DbContext
{
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Currency> Currencies { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<TransactionType> TransactionTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=Bank;User Id=sa;Password=Aa123456;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AccountConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new ClientConfiguration());
        modelBuilder.ApplyConfiguration(new CurrencyConfiguration());
        modelBuilder.ApplyConfiguration(new TransactionConfiguration());
        modelBuilder.ApplyConfiguration(new TransactionTypeConfiguration());

        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(AccountConfiguration).Assembly);

        // modelBuilder.Entity<Account>()
        //     .Property(x => x.Balance)
        //     .HasColumnType("decimal(18,2)")
        //     .HasDefaultValue(0);


    }
}