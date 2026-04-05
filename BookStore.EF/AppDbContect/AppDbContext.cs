using BookStore.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.EF.AppDbContect
{
    public class AppDbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString2 = "Data Source=BROLOSY\\MSSQLSERVER06;Database=RepoPattern; Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Command Timeout=30";
            optionsBuilder.UseSqlServer(connectionString2);
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category>Categories {  get; set; }

        
    
    }
}
