using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.Entities

{
    public partial class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
