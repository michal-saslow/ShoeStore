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
        public static int id = 0;
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
            var order = _serviceOrder.GetOrders().Find(x => x.Id == id);
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
            _serviceOrder.GetOrders().Add(o);
            return Ok();
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Order o)
        {
            var order = _serviceOrder.GetOrders().Find(x => x.Id == id);
            if (order == null)
                return NotFound(id);
            o.Id = order.Id;
            _serviceOrder.GetOrders().Remove(order);
            _serviceOrder.GetOrders().Add(o);
            return Ok();
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var order = _serviceOrder.GetOrders().Find(x => x.Id == id);
            if (order == null)
                return NotFound();
            _serviceOrder.GetOrders().Remove(order);
            return Ok();
        }
    }
}
