using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.Entities
{
    public partial class OrderLine
    {
        public Guid OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
