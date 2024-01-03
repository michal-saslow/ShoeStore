using Microsoft.AspNetCore.Mvc;
using ShoeStore.Core.Entities;
using ShoeStore.Core.Services;
using ShoeStore.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoeStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruvidersController : ControllerBase
    {
        private readonly IProviderService _serviceProvider;
        public PruvidersController(IProviderService serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        // GET: api/<PruvidersController>
        [HttpGet]
        public ActionResult<IEnumerable<Provider>> Get()
        {
            if (_serviceProvider.GetProvider() == null)
                return NotFound();
            return _serviceProvider.GetProvider();
        }

        // GET api/<PruvidersController>/5
        [HttpGet("{id}")]
        public ActionResult<Provider> Get(int id)
        {
           return _serviceProvider.GetProviderById(id);
        }

        // POST api/<PruvidersController>
        [HttpPost]
        public ActionResult Post([FromBody] Provider p)
        {
            return Ok(_serviceProvider.Add(p));
        }

        // PUT api/<PruvidersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Provider p)
        {
            return Ok(_serviceProvider.Update(id, p));
        }

        // DELETE api/<PruvidersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var provider = _serviceProvider.GetProviderById(id);
            if (provider is null)
            {
                return NotFound();
            }

            _serviceProvider.Delete(id);
            return NoContent();
        }
    }
}
