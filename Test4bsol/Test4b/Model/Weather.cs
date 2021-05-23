
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test4b.Models
{   public class Weather
    {   [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        public float LowTemp { get; set; }
        public float HighTemp { get; set; }
        public string Forcast { get; set; }

    }
}
