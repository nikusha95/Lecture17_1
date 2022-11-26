using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework.Configurations;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Balance)
            .HasColumnType("decimal(18,2)")
            .HasDefaultValue(0);
        
        builder.Property(x => x.Iban)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.ExpirationDate)
            .IsRequired();
        
        
    }
}