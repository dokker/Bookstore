using Bookstore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookstore.Data.Configurators;

public class BookConfigurator : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable(nameof(Book));
        builder.HasKey(x => x.Id);
        builder.HasOne<Author>(x => x.Author);
    }
}