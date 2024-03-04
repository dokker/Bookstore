namespace Bookstore.Models;

public class Book
{
    public Guid Id { get; set; }
    public String ISBN { get; set; }
    public String Title { get; set; }
    public DateTime PublicationDate { get; set; }
    public Guid AuthorId { get; set; }
    public Author Author { get; set; }
}