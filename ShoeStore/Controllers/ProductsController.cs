using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoeStore.Api.Entities;
using ShoeStore.Core.DTOs;
using ShoeStore.Core.Entities;
using ShoeStore.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoeStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _serviceProduct;
        private readonly IMapper _mapper;
        public ProductsController(IProductService serviceProduct,IMapper mapper)
        {
            _serviceProduct = serviceProduct;
            _mapper = mapper;
        }
        // GET: api/<ProductsController>
        [HttpGet]
        public ActionResult Get()
        {
            var products = _serviceProduct.GetProduct();
            var productsDto=_mapper.Map<IEnumerable<ProductDto>>(products);
            return Ok(productsDto);
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var product = _serviceProduct.GetProductById(id);
            var productDto=_mapper.Map<ProductDto>(product);
           return Ok(productDto);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public ActionResult Post([FromBody] ProductPostModel p)
        {
            var productToAdd=_mapper.Map<Product>(p);
            var newProduct = _serviceProduct.Add(productToAdd);
            return Ok(_mapper.Map<ProductDto>(newProduct));
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Product p)
        {
            var productToUpdate=_mapper.Map<Product>(p);
            var updateProduct = _serviceProduct.Update(id, productToUpdate);
            return Ok(_mapper.Map<ProductDto>(updateProduct));
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var product = _serviceProduct.GetProductById(id);
            if (product is null)
            {
                return NotFound();
            }

            _serviceProduct.Delete(id);
            return NoContent();
        }
    }
}
