using System;

namespace OrderApp.Domain.Models
{
    public class Order : Entity
    {
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }

        /* EF Relation */
        public Customer Customer { get; set; }
    }
}
