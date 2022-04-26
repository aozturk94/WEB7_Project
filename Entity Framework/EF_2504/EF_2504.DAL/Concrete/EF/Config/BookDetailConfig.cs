using EF_2504.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EF_2504.DAL.Concrete.EF.Config
{
    public class BookDetailConfig : IEntityTypeConfiguration<BookDetail>
    {
        public void Configure(EntityTypeBuilder<BookDetail> builder)
        {
            builder.HasKey(bd => bd.BookDetailId);
            builder.Property(bd => bd.BookDetailISBN).HasDefaultValue("0000-0000-0000");
            builder.Property(bd => bd.BookDetailYear).HasDefaultValue(DateTime.Now.Year);

            builder
                .HasOne(bd => bd.Book) //1e 1 ilişki bir kitabın bir detayı olacak.
                .WithOne(b => b.BookDetail)
                .HasForeignKey<BookDetail>(bd => bd.BookId) //1e 1 ilişkide foreign keyi belirtmek için generic bir tip (BookDetail'de foreign keyimiz.) istiyor. Hangisi olduğunu belirtmemiz lazım.
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new BookDetail { BookDetailId = 1, BookDetailCity = "İstanbul", BookId=1},
                new BookDetail { BookDetailId = 2, BookDetailCity = "Ankara", BookId=2},
                new BookDetail { BookDetailId = 3, BookDetailCity = "İzmir", BookId=3}
                );
        }
    }
}
