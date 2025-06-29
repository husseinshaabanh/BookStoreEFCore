using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineBookStoreWithASPNETCore.Entities;

namespace OnlineBookStoreWithASPNETCore.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> E)
        {
            E.HasOne(B => B.Category)
             .WithMany(C => C.Books)
             .HasForeignKey(B => B.CategoryID)
             .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
