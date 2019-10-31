using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderApp.Domain.Models;

namespace OrderApp.Infrastructure.Mapping
{
    public class CustomerMapping : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Name)
                .HasColumnType("varchar(200)");

            builder.Property(o => o.Email)
                .HasColumnType("varchar(150)");

            // 1 : N => Customer : Orders
            builder.HasMany(c => c.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerId);

            builder.ToTable("Customers");
        }
    }
}