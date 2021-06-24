using API_Book.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Book.Data
{
    public class App_Context : DbContext
    {
            public App_Context (DbContextOptions<App_Context> options) : base(options)
            {

            }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book() { Id = 1, DateRead = DateTime.Now, Description = "Harry Potter", Genre = "Sci-Fi", Rate = 9, Title = "Harry Potter" },
                new Book() { Id = 2, DateRead = DateTime.Now, Description = "Zorro", Genre = "Adventure", Rate = 7, Title = "Zorro" },
                new Book() { Id = 3, DateRead = DateTime.Now, Description = "Tarzan", Genre = "Adventure", Rate = 6, Title = "Tarzan" });
        }
        public DbSet<Book> Book { get; set; }
    }
}
