using ApiEFwithRepository.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiEFwithRepository.Data
{
    public class BookAtticDbContext :DbContext
    {
        public BookAtticDbContext(DbContextOptions<BookAtticDbContext> options) : base(options)
        {

        }

        public DbSet<Author> authors { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<BookAutRelation> book_Authors { get; set; }

        //tablo ile entitimizdeki tablo adlaarini uygunlasdiririq
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Student>().ToTable(nameof(Student));
            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<Author>().ToTable("Author");
            modelBuilder.Entity<BookAutRelation>().ToTable("Book_Author");

            modelBuilder.Entity<BookAutRelation>().HasKey(a => new { a.AuthorId, a.BookId });

        }

       


    }
}
