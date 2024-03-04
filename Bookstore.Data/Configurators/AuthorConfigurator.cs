using Bookstore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Logging;

namespace Bookstore.Data.Configurators;

public class AuthorConfigurator : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.ToTable(nameof(Author));
        builder.HasKey(x => x.Id);
        builder.HasMany<Book>(x => x.Books);
    }
}