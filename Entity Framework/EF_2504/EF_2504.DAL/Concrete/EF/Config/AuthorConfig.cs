using EF_2504.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EF_2504.DAL.Concrete.EF.Config
{
    public class AuthorConfig : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.AuthorId);
            builder.Property(a => a.AuthorFirstName).IsRequired();
            builder.Property(a => a.AuthorLastName).IsRequired();
            builder.Ignore(a => a.AuthorFullName);
            builder.Property(a => a.AuthorCreatedDate).HasDefaultValue(DateTime.Now);

            builder.HasData(
                new Author { AuthorId = 1, AuthorFirstName = "Ferzan", AuthorLastName = "ÖZPETEK" },
                new Author { AuthorId = 2, AuthorFirstName = "Serdar", AuthorLastName = "CANDAŞ" },
                new Author { AuthorId = 3, AuthorFirstName = "Kübra", AuthorLastName = "SESİÇOK" }
                );
        }
    }
}
