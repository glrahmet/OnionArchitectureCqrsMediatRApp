using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //inmemory data
            modelBuilder.Entity<Product>().HasData(
             new Product() { Id = Guid.NewGuid(), Name = "A1", Quantity = 1, Value = 1 },
             new Product() { Id = Guid.NewGuid(), Name = "A2", Quantity = 2, Value = 2 },
             new Product() { Id = Guid.NewGuid(), Name = "A3", Quantity = 3, Value = 3 },
             new Product() { Id = Guid.NewGuid(), Name = "A4", Quantity = 4, Value = 4 },
             new Product() { Id = Guid.NewGuid(), Name = "A5", Quantity = 5, Value = 5 }
             ); 
            base.OnModelCreating(modelBuilder);
        }
    }
}
