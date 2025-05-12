using IceLibrary.ConnectionString;
using IceLibrary.Library.Models;
using Microsoft.EntityFrameworkCore;

namespace IceLibrary.Contexts
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Book { get; set; }
        public DbSet<Author>? Author { get; set; }
        public DbSet<BookAuthor>? AuthorAuthor { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionStringDB.LibraryConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
