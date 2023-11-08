using Microsoft.AspNetCore.Mvc;
using ShoeStore.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoeStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly DataContext _context;
        public static int id = 0;
        public ProductsController(DataContext context)
        {
            _context = context;
        }
        // GET: api/<ProductsController>
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            if (_context.products == null)
                return NotFound();
            return _context.products;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var product = _context.products.Find(x => x.Id == id);
            if (product == null)
                return NotFound();
            return product;
        }

        // POST api/<ProductsController>
        [HttpPost]
        public ActionResult Post([FromBody] Product p)
        {
            id++;
            p.Id = id;
            _context.products.Add(p);
            return Ok();
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Product p)
        {
            var product = _context.products.Find(x => x.Id == id);
            if (product == null)
                return NotFound(id);
            p.Id = product.Id;
            _context.products.Remove(product);
            _context.products.Add(p);
            return Ok();
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var product = _context.products.Find(x => x.Id == id);
            if (product == null)
                return NotFound();
            _context.products.Remove(product);
            return Ok();
        }
    }
}
