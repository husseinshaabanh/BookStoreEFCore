using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineBookStoreWithASPNETCore.Entities;

namespace OnlineBookStoreWithASPNETCore.Configurations
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Entities.Customer>
    {
        public void Configure(EntityTypeBuilder<Entities.Customer> E)
        {
            E.HasMany(C => C.Orders)
             .WithOne(O => O.Customer)
             .IsRequired(false)
             .HasForeignKey(O => O.CustomerId)
             .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
