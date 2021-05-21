using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test4b.Models
{
    public class WeatherContext : DbContext
    {
        public WeatherContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Weather> Weathers { get; set; }
    }
}
