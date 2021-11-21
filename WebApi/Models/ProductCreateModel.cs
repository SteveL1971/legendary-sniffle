using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class ProductCreateModel
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; } = "";
        public bool InStock { get; set; } = true;
        public string LongDescription { get; set; } = "";
        public decimal Price { get; set; } = 0;
        public string ImageUrl { get; set; } = "";
        public int SubCategoryId { get; set; }

    }
}
