using EFwithAutoMapperAndLinQ.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EFwithAutoMapperAndLinQ.Domain
{
    public class BlogDbConText:DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        //men bunun base ctoruna option gonderen ctorunu yaratmadim, amma isleyir. umumiyyetle o ne ucundu
        //bu errorun hellinde niye ele sey yazdiq ki? cunki many-to-many deyil elaqe? useri silmirik amma rolu silirik userRole tablesinden
        //bu her cedvelin key hansidi onu mutleq hemise demeliyik haskey ile? yoxsa ancaq manyTOmanyde? ozu oftamatik qoyur deyesen 1ci propa gore
       
        public BlogDbConText(DbContextOptions<BlogDbConText> options) : base(options)
        {

        }

        //bunu bele elemkdense start-updaki kimi ediller
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-PHRL2VS;Initial Catalog=BlogLessonDB;Integrated Security=True");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Comment>().HasKey(e => new {e.PostId, e.Id});

            modelBuilder.Entity<Comment>()
                .HasOne<Post>(s => s.Post)
                .WithMany(g => g.Comments)
                .HasForeignKey(s => s.PostId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Post>()
                .HasMany<Comment>(s => s.Comments)
                .WithOne(g => g.Post)
                .HasForeignKey(s => s.PostId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
