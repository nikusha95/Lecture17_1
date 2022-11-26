using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework.Configurations;

public class CategoryConfiguration: IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Name)
            .HasMaxLength(100);
        
        builder.HasMany(x => x.Accounts)
            .WithOne(x => x.Category)
            .HasForeignKey(x => x.CategoryId)
            .HasConstraintName("FK_Accounts_Category");
    }
}