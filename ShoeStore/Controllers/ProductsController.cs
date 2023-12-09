using Microsoft.AspNetCore.Mvc;
using ShoeStore.Core.Entities;
using ShoeStore.Core.Services;
using ShoeStore.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoeStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _serviceProduct;
        public ProductsController(IProductService serviceProduct)
        {
            _serviceProduct = serviceProduct;
        }
        // GET: api/<ProductsController>
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            if (_serviceProduct.GetProduct() == null)
                return NotFound();
            return _serviceProduct.GetProduct();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var product = _serviceProduct.GetProductById(id);
            if (product == null)
                return NotFound();
            return product;
        }

        // POST api/<ProductsController>
        [HttpPost]
        public ActionResult Post([FromBody] Product p)
        {
            _serviceProduct.PostProduct(p);
            return Ok();
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Product p)
        {
            _serviceProduct.PutProduct(id, p);
            return Ok();
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _serviceProduct.DeleteProduct(id);
            return Ok();
        }
    }
}
