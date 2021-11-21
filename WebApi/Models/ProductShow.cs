using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Data;
using WebApi.Entities;

namespace WebApi.Models
{
    public class ProductShow
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public bool InStock { get; set; }

        public virtual ProductDetail ProductDetail { get; set; }

    }
}
