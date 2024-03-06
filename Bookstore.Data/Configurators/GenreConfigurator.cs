using Bookstore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookstore.Data.Configurators;

public class GenreConfigurator : IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {
        builder.ToTable(nameof(Genre));
        builder.HasKey(x => x.Id);
        builder.HasMany<BookGenre>(x => x.BookGenres);
    }
}
