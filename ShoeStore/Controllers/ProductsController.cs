using Microsoft.AspNetCore.Mvc;
using ShoeStore.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoeStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public static List<Products> products = new List<Products>();
        // GET: api/<ProductsController>
        [HttpGet]
        public ActionResult<IEnumerable<Products>> Get()
        {
            if (products == null)
                return NotFound();
            return products;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public ActionResult<Products> Get(int id)
        {
            var product = products.Find(x => x.Id == id);
            if (product == null)
                return NotFound();
            return product;
        }

        // POST api/<ProductsController>
        [HttpPost]
        public ActionResult Post([FromBody] Products p)
        {
            products.Add(p);
            return Ok();
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Products p)
        {
            var product = products.Find(x => x.Id == id);
            if (product == null)
                return NotFound(id);
            products.Remove(product);
            products.Add(p);
            return Ok();
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var product = products.Find(x => x.Id == id);
            if (product == null)
                return NotFound();
            products.Remove(product);
            return Ok();
        }
    }
}
