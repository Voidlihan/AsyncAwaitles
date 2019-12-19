using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WPFAsyncAwait
{
    public class AsyncDbContext : DbContext
    {   public AsyncDbContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=A-104-09;Database=AsyncDb;Trusted_Connection=true;");
        }
    }
}
