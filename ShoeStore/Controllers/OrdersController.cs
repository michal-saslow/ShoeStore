using Microsoft.AspNetCore.Mvc;
using ShoeStore.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoeStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        public static List<Orders> orders = new List<Orders>();
        public static int id = 0;
        // GET: api/<OrdersController>
        [HttpGet]
        public ActionResult<IEnumerable<Orders>> Get()
        {
            if (orders == null)
                return NotFound();
            return orders;
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public ActionResult<Orders> Get(int id)
        {
            var order = orders.Find(x => x.Id == id);
            if (order == null)
                return NotFound();
            return order;
        }

        // POST api/<OrdersController>
        [HttpPost]
        public ActionResult Post([FromBody] Orders o)
        {
            id++;
            o.Id = id;
            orders.Add(o);
            return Ok();
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Orders o)
        {
            var order = orders.Find(x => x.Id == id);
            if (order == null)
                return NotFound(id);
            orders.Remove(order);
            orders.Add(o);
            return Ok();
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var order = orders.Find(x => x.Id == id);
            if (order == null)
                return NotFound();
            orders.Remove(order);
            return Ok();
        }
    }
}
