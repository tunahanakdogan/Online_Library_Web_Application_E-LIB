using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using elib_entity;
using Microsoft.EntityFrameworkCore;

namespace elib_data.Concrete.EfCore
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FavList> FavLists { get; set; }
        public DbSet<FavListItem> FavListItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=ElibDb;Integrated Security=SSPI;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookCategory>().HasKey(c => new { c.CategoryId, c.BookId });
        }
    }
}