using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebApi.Data;
using WebApi.Entities;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly EfDatabaseFirstContext _context;

        public ProductsController(EfDatabaseFirstContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductShow>>> GetProducts()
        {
            var _products = new List<ProductShow>();

            foreach (var item in await _context.Products.Include(x => x.ProductDetail).ThenInclude(x => x.SubCategory).OrderByDescending(i => i.Id).ToListAsync())
                
                _products.Add(new ProductShow
                {
                    Id=item.Id,
                    Name = item.Name,
                    ShortDescription = item.ShortDescription,
                    InStock = item.InStock,
                    ProductDetail = new ProductDetail
                    {
                        LongDescription = item.ProductDetail.LongDescription,
                        Price = item.ProductDetail.Price,
                        SubCategoryId = item.ProductDetail.SubCategoryId,
                        ImageUrl = item.ProductDetail.ImageUrl,
                        SubCategory = new SubCategory {Name = item.ProductDetail.SubCategory.Name}
                    },
                });

            return _products;
        }


        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductShow>> GetProduct(int id)
        {
            // var product = await _context.Products.FindAsync(id);
            // var product = await _context.Products.Include(i => i.ProductDetail).FirstOrDefaultAsync(i => i.Id == id);

            var product = await _context.Products.Where(x => x.Id == id).Include(x => x.ProductDetail).ThenInclude(x => x.SubCategory).FirstOrDefaultAsync();

            if (product == null)
            {
                return NotFound();
            }

            var _product = new ProductShow
            {
                Id=product.Id,
                Name = product.Name,
                ShortDescription = product.ShortDescription,
                InStock = product.InStock,
                ProductDetail = new ProductDetail
                {
                    LongDescription = product.ProductDetail.LongDescription,
                    Price = product.ProductDetail.Price,
                    SubCategoryId = product.ProductDetail.SubCategoryId,
                    ImageUrl = product.ProductDetail.ImageUrl,
                    SubCategory = new SubCategory { Name = product.ProductDetail.SubCategory.Name }
                }
            };

            return _product;
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }




        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        //public async Task<ActionResult<Product>> PostProduct(Product product)
        //{
        //    _context.Products.Add(product);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        //}

        public async Task<ActionResult<Product>> PostProduct(ProductCreateModel model)
        {
            var _product = await _context.Products.Where(x => x.Name.ToLower() == model.Name.ToLower()).FirstOrDefaultAsync();
            
            if (_product == null)
            {
                var product = new Product
                {
                    Name = model.Name,
                    ShortDescription = model.ShortDescription,
                    InStock = model.InStock,
                    ProductDetail = new ProductDetail { 
                        LongDescription = model.LongDescription,
                        Price = model.Price,
                        SubCategoryId = model.SubCategoryId,
                        ImageUrl = model.ImageUrl
                    }
                };

                _context.Products.Add(product);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetProduct", new { id = product.Id }, product);
            }

            return new BadRequestObjectResult(JsonConvert.SerializeObject(new { message = $"Product {model.Name} already exists." }));

        }




        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
