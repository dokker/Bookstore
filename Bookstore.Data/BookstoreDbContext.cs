using Bookstore.Data.Configurators;
using Bookstore.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Data;

public class BookstoreDbContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(new SqlConnection("Server=localhost\\mssql,1433;Database=entityfw;User Id=sa;Password=p4swd!Str0ng;Encrypt=Yes;TrustServerCertificate=Yes"));
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("bookstore");

        modelBuilder.ApplyConfiguration<Author>(new AuthorConfigurator());
        modelBuilder.ApplyConfiguration<Book>(new BookConfigurator());

        base.OnModelCreating(modelBuilder);
    }
}