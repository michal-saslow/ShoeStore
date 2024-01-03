using Microsoft.AspNetCore.Mvc;
using ShoeStore.Core.Entities;
using ShoeStore.Core.Services;
using ShoeStore.Service;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoeStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _serviceOrder;
        
        public OrdersController(IOrderService serviceOrder)
        {
            _serviceOrder = serviceOrder;
        }
        // GET: api/<OrdersController>
        [HttpGet]
        public ActionResult<IEnumerable<Order>> Get()
        {
            if (_serviceOrder.GetOrders() == null)
                return NotFound();
            return _serviceOrder.GetOrders();
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public ActionResult<Order> Get(int id)
        {
            var order = _serviceOrder.GetOrderById(id);
            if (order==null)
                return NotFound();
            return order;
        }

        // POST api/<OrdersController>
        [HttpPost]
        public ActionResult Post([FromBody] Order o)
        {
            return Ok(_serviceOrder.Add(o));
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Order o)
        {
            return Ok(_serviceOrder.Update(id, o));
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var order = _serviceOrder.GetOrderById(id);
            if (order is null)
            {
                return NotFound();
            }

            _serviceOrder.Delete(id);
            return NoContent();
        }
    }
}
