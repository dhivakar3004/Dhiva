using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaOrder.Models
{
    public class OrderDetails
    {   [Key]
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }


       
        public int PizzaId { get; set; }
        [ForeignKey("PizzaId")]
        public virtual Pizza Pizza { get; set; }

        public int quantity { get; set; }
    }

}