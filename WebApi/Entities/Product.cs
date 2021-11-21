using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.Entities
{
    public partial class Product
    {
        public Product()
        {
            OrderLines = new HashSet<OrderLine>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public bool InStock { get; set; }

        public virtual ProductDetail ProductDetail { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
