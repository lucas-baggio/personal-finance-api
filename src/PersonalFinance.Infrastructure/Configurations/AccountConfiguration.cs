using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalFinance.Domain.Entities;

namespace PersonalFinance.Infrastructure.Configurations;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.ToTable("Accounts");
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Name).IsRequired().HasMaxLength(100);
        builder.Property(a => a.Balance).HasPrecision(18, 2).IsRequired();
        builder.Property(a => a.Type).IsRequired();
        builder.HasOne(a => a.User).WithMany(u => u.Accounts).HasForeignKey(a => a.UserId).OnDelete(DeleteBehavior.Cascade);
    }
}