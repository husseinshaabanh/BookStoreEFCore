using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineBookStoreWithASPNETCore.Entities;

namespace OnlineBookStoreWithASPNETCore.Configurations
{
    public class OrderBookConfiguration : IEntityTypeConfiguration<OrderBook>
    {
        public void Configure(EntityTypeBuilder<OrderBook> E)
        {
            E.HasKey(OB => new { OB.OrderId, OB.BookId });

            E.HasOne(OB => OB.Order)
             .WithMany(O => O.OrderBooks);

            E.HasOne(OB => OB.Book)
             .WithMany(B => B.BookOrders);
        }
    }
}
