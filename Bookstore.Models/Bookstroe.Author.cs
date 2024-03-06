namespace Bookstore.Models;

public class Author
{
    public Guid Id { get; set; }
    public int Birth { get; set; }
    public List<Book> Books { get; set; }
}