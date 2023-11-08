using Microsoft.AspNetCore.Mvc;
using ShoeStore.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoeStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly DataContext _context;
        public static int id = 0;
        public OrdersController(DataContext context)
        {
            _context = context;
        }
        // GET: api/<OrdersController>
        [HttpGet]
        public ActionResult<IEnumerable<Order>> Get()
        {
            if (_context.orders == null)
                return NotFound();
            return _context.orders;
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public ActionResult<Order> Get(int id)
        {
            var order = _context.orders.Find(x => x.Id == id);
            if (order == null)
                return NotFound();
            return order;
        }

        // POST api/<OrdersController>
        [HttpPost]
        public ActionResult Post([FromBody] Order o)
        {
            id++;
            o.Id = id;
            _context.orders.Add(o);
            return Ok();
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Order o)
        {
            var order = _context.orders.Find(x => x.Id == id);
            if (order == null)
                return NotFound(id);
            o.Id = order.Id;
            _context.orders.Remove(order);
            _context.orders.Add(o);
            return Ok();
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var order = _context.orders.Find(x => x.Id == id);
            if (order == null)
                return NotFound();
            _context.orders.Remove(order);
            return Ok();
        }
    }
}
