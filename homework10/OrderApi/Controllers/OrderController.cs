using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderContext _context;

        public OrderController(OrderContext context)
        {
            _context = context;

            if (_context.Orders.Count() == 0)
            {
                // Create a new Order if collection is empty,
                // which means you can't delete all Orders.
                OrderDetail odt=new OrderDetail(1,"book",30.0,50);
                List<OrderDetail> list=new List<OrderDetail>();
                list.Add(odt);
                Order od=new Order(1,"jack",System.DateTime.Now,list);
                _context.Orders.Add(od);
                _context.OrderItems.Add(odt);
                _context.SaveChanges();
            }
        }

        // GET: api/Order
[HttpGet]
public async Task<ActionResult<IEnumerable<Order>>> GetOrder()
{
    return await _context.Orders.ToListAsync();
}

// GET: api/Todo/5
[HttpGet("{id}")]
public async Task<ActionResult<Order>> GetOrder(long id)
{
    var order = await _context.Orders.FindAsync(id);

    if (order == null)
    {
        return NotFound();
    }

    return order;
}

// POST: api/Order
[HttpPost]
public async Task<ActionResult<Order>> PostOrder(Order item)
{
    _context.Orders.Add(item);
    await _context.SaveChangesAsync();

    return CreatedAtAction(nameof(GetOrder), new { id = item.Id }, item);
}

// PUT: api/Order/5
[HttpPut("{id}")]
public async Task<IActionResult> PutOrderItem(long id, Order item)
{
    if (id != item.Id)
    {
        return BadRequest();
    }

    _context.Entry(item).State = EntityState.Modified;
    await _context.SaveChangesAsync();

    return NoContent();
}

// DELETE: api/Order/5
[HttpDelete("{id}")]
public async Task<IActionResult> DeleteTodoItem(long id)
{
    var order = await _context.Orders.FindAsync(id);

    if (order == null)
    {
        return NotFound();
    }

    _context.Orders.Remove(order);
    await _context.SaveChangesAsync();

    return NoContent();
}
    }
}