namespace Bookstore.Models;

public class Genre
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<BookGenre> BookGenres { get; set; }
}