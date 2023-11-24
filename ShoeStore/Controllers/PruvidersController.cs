using Microsoft.AspNetCore.Mvc;
using ShoeStore.Core.Entities;
using ShoeStore.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoeStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruvidersController : ControllerBase
    {
        private readonly IProviderService _serviceProvider;
        public static int id = 0;
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
            var pruvider = _serviceProvider.GetProvider().Find(x => x.Id == id);
            if (pruvider == null)
                return NotFound();
            return pruvider;
        }

        // POST api/<PruvidersController>
        [HttpPost]
        public ActionResult Post([FromBody] Provider p)
        {
            id++;
            p.Id = id;
            _serviceProvider.GetProvider().Add(p);
            return Ok();
        }

        // PUT api/<PruvidersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Provider p)
        {
            var pruvider = _serviceProvider.GetProvider().Find(x => x.Id == id);
            if (pruvider == null)
                return NotFound(id);
            p.Id = pruvider.Id;
            _serviceProvider.GetProvider().Remove(pruvider);
            _serviceProvider.GetProvider().Add(p);
            return Ok();
        }

        // DELETE api/<PruvidersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var pruvider = _serviceProvider.GetProvider().Find(x => x.Id == id);
            if (pruvider == null)
                return NotFound();
            _serviceProvider.GetProvider().Remove(pruvider);
            return Ok();
        }
    }
}
