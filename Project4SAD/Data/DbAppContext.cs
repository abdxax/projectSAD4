using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project4SAD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project4SAD.Data
{
    public class DbAppContext:IdentityDbContext
    {
        public DbAppContext(DbContextOptions dbContextOption):base(dbContextOption)
        {

        }
        public DbSet<Pizza> pizzas { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<CustomerOrder> customerOrders { get; set; }
        public DbSet<Order> orders { get; set; }
    }
}
