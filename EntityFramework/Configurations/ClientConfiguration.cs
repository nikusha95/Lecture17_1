using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework.Configurations;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.PersonalId)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasMany(x => x.Accounts)
            .WithOne(x => x.Client)
            .HasForeignKey(x => x.ClientId).HasConstraintName("FK_Client_Accounts");
    }
}