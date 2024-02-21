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
        public async Task<ActionResult> Get()
        {
            var products = await _serviceProduct.GetProductAsync();
            var productsDto=_mapper.Map<IEnumerable<ProductDto>>(products);
            return Ok(productsDto);
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var product = await _serviceProduct.GetProductByIdAsync(id);
            var productDto=_mapper.Map<ProductDto>(product);
           return Ok(productDto);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ProductPostModel p)
        {
            var productToAdd=_mapper.Map<Product>(p);
            var newProduct = await _serviceProduct.AddAsync(productToAdd);
            return Ok(_mapper.Map<ProductDto>(newProduct));
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Product p)
        {
            var productToUpdate=_mapper.Map<Product>(p);
            var updateProduct = await _serviceProduct.UpdateAsync(id, productToUpdate);
            return Ok(_mapper.Map<ProductDto>(updateProduct));
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var product = await _serviceProduct.GetProductByIdAsync(id);
            if (product is null)
            {
                return NotFound();
            }

            await _serviceProduct.DeleteAsync(id);
            return NoContent();
        }
    }
}
