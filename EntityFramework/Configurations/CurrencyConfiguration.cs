using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework.Configurations;

public class CurrencyConfiguration: IEntityTypeConfiguration<Currency>
{
    public void Configure(EntityTypeBuilder<Currency> builder)
    {
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(3);
        
        builder.HasMany(x => x.Accounts)
            .WithOne(x => x.Currency)
            .HasForeignKey(x => x.CurrencyId)
            .HasConstraintName("FK_Accounts_Currency");
    }
}