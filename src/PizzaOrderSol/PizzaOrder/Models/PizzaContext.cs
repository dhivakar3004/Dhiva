using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace PizzaOrder.Models
{
    public class PizzaContext : DbContext

    {
        public PizzaContext()
        {

        }
        public PizzaContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetail { get; set; }



    }
}