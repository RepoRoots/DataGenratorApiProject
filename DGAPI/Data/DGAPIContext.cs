using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DbGenratorWithBogus.DbModels;

    public class DGAPIContext : DbContext
    {
        public DGAPIContext (DbContextOptions<DGAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; } = default!;

        public DbSet<Order> Orders { get; set; } = default!;

        public DbSet<OrderDetail> OrderDetails { get; set; } = default!;

        public DbSet<Product> Products { get; set; } = default!;
    }
