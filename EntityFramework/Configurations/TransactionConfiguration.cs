using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework.Configurations;

public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.Property(x => x.Amount)
            .HasColumnType("decimal(18,2)");
        
        builder.Property(x => x.Purpose)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(x => x.CreateDate)
            .HasDefaultValueSql("GETDATE()");
    }
}