using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.Entities
{
    public partial class ProductDetail
    {
        public int Id { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int SubCategoryId { get; set; }

        public virtual SubCategory SubCategory { get; set; }

        public virtual Product IdNavigation { get; set; }
    }
}
