using EF_2504.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EF_2504.DAL.Concrete.EF.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.BookId);
            builder.Property(b => b.BookName).IsRequired();
            builder.Property(b => b.BookPrice).HasDefaultValue(0);
            builder.Property(b => b.BookCreatedDate).HasDefaultValue(DateTime.Now);

            //Book->Category arasındaki 1'e çok ilişki.
            builder
                .HasOne(b => b.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(b => b.CategoryId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasData(
                new Book { BookId = 1, BookName = "Sefiller", BookImageUrl = "http://kbimages1-a.akamaihd.net/Images/6faa402f-1a95-4897-93ff-8286cbe0e94f/255/400/False/image.jpg", BookPrice = 120 },
                new Book { BookId = 2, BookName = "Kaşağı", BookImageUrl = "https://i.dr.com.tr/cache/600x600-0/originals/0000000186269-1.jpg", BookPrice = 90 },
                new Book { BookId = 3, BookName = "A'dan Z'ye PHP", BookImageUrl = "https://www.tdk.com.tr/images_buyuk/f14/A-dan-Z-ye-PHP_8614_1.jpg", BookPrice = 190 });
        }
    }
}
