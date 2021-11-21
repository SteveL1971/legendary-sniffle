using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class ProductDetailModel
    {
        public int Id { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int SubCategoryId { get; set; }

        public virtual SubCategory SubCategory { get; set; }


    }
}
