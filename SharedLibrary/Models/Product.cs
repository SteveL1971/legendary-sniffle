using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class Product
    {
        [Key]
        [DisplayName("Product Id")]
        public int Id { get; set; }

        [Required]
        [DisplayName("Product Name")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Must be between {1} and {2} character in length.")]
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }

        [DisplayName("Short Product Description")]
        [Column(TypeName = "nvarchar(max)")]
        [StringLength(8192, MinimumLength = 5, ErrorMessage = "Must be at least {2} character in length.")]
        public string ShortDescription { get; set; }

        [DisplayName("Long Product Description")]
        [Column(TypeName = "nvarchar(max)")]
        [StringLength(8192, MinimumLength = 5, ErrorMessage = "Must be at least {2} character in length.")]
        public string LongDescription { get; set; }

        [DisplayName("Image URL")]
        [Column(TypeName = "nvarchar(max)")]
        [StringLength(8192, MinimumLength = 5, ErrorMessage = "Must be at least {2} character in length.")]
        public string ImageUrl { get; set; }

        [DisplayName("Product Price (SEK)")]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [DisplayName("SubCategory id")]
        [Column(TypeName = "int")]
        public int SubCategoryId { get; set; }

        [DisplayName("Amount")]
        [Column(TypeName = "int")]
        public int Amount { get; set; }

        public virtual ProductDetailModel ProductDetail { get; set; }

    }
}
