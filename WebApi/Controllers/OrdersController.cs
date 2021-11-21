using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Entities;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly EfDatabaseFirstContext _context;

        public OrdersController(EfDatabaseFirstContext context)
        {
            _context = context;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            return await _context.Orders.ToListAsync();
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }



        // POST: api/Orders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        //public async Task<ActionResult<Order>> PostOrder(Order order)
        //{
        //    _context.Orders.Add(order);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetOrder", new { id = order.Id }, order);
        //}

        public async Task<ActionResult<Order>> PostOrder(OrderCreate model)

        {

            //var _product = await _context.Products.Where(x => x.Name.ToLower() == model.Name.ToLower()).FirstOrDefaultAsync();


            var order = new Order
            {
                Id = model.Id,
                UserId = model.UserId,
                Status = model.Status,
                OrderDate = model.OrderDate,
                DeliveryTypeId = model.DeliveryTypeId,
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            // return CreatedAtAction("GetOrder", new { id = order.Id }, order);
            return order;
        }





    }
}
