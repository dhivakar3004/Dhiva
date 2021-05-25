using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaClient.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public float Amount { get; set; }

    }
}