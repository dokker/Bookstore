using Bookstore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookstore.Data.Configurators;

public class BookGenreConfigurator : IEntityTypeConfiguration<BookGenre>
{
    public void Configure(EntityTypeBuilder<BookGenre> builder)
    {
        builder.ToTable(nameof(BookGenre));
        builder.HasKey(x => x.Id);
        builder.HasOne<Book>(x => x.Book);
        builder.HasOne<Genre>(x => x.Genre);
    }
}
