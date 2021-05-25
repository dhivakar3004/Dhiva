using System;
using System.ComponentModel.DataAnnotations;
namespace PizzaOrder.Models
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