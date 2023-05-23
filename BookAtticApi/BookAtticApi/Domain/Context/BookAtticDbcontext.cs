using BookAtticApi.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace BookAtticApi.Domain.Context
  
{
    public class BookAtticDbcontext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<BookPublisher> BookPublishers { get; set; }

        public BookAtticDbcontext(DbContextOptions<BookAtticDbcontext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookPublisher>().HasKey(bp => new { bp.PublisherId, bp.BookId });

            modelBuilder.Entity<BookPublisher>()
                .HasOne<Book>(bp => bp.Book)
                .WithMany(b => b.bookPublishers)
                .HasForeignKey(bp => bp.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<BookPublisher>()
                .HasOne<Publisher>(bp => bp.Publisher)
                .WithMany(p => p.bookPublishers)
                .HasForeignKey(bp => bp.PublisherId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
