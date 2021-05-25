using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaClient.Models
{

    public class OrderDetails
    {
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }


        [ForeignKey("Pizza")]
        public int PizzaId { get; set; }
        public virtual Pizza Pizza { get; set; }

        public int quantity { get; set; }
    }
}
