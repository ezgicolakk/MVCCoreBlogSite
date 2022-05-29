using BlogSite.CORE.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.DAL.Concrete
{
    public class BlogSiteDbContext:DbContext
    {
        public BlogSiteDbContext(DbContextOptions<BlogSiteDbContext> options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=DESKTOP-TINAKUE\\SQLEXPRESS;Initial Catalog=BlogSite10;Integrated Security=true;");
        //}

        public DbSet<Author> Authors { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().Property(a => a.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Author>().Property(a => a.Surname).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Author>().Property(a => a.AuthorAbout).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Author>().Ignore(a => a.Photo);
            modelBuilder.Entity<Author>().Property(a => a.Email).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Author>().Property(a => a.Password).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Author>().ToTable("Author");           
            modelBuilder.Entity<Article>().Property(a => a.ArticleDate).IsRequired();
            modelBuilder.Entity<Article>().Property(a => a.IsActive).IsRequired();
            modelBuilder.Entity<Article>().Property(a => a.ReadingCount).IsRequired();
            modelBuilder.Entity<Article>().Property(a => a.Content).IsRequired();
            modelBuilder.Entity<Article>().ToTable("Article");
            modelBuilder.Entity<Topic>().Property(a => a.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Topic>().ToTable("Topic");


        }
    }
}
