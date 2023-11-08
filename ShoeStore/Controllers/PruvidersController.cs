using Microsoft.AspNetCore.Mvc;
using ShoeStore.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoeStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruvidersController : ControllerBase
    {
        private readonly DataContext _context;
        public static int id = 0;
        public PruvidersController(DataContext context)
        {
            _context = context;
        }
        // GET: api/<PruvidersController>
        [HttpGet]
        public ActionResult<IEnumerable<Provider>> Get()
        {
            if (_context.pruviders == null)
                return NotFound();
            return _context.pruviders;
        }

        // GET api/<PruvidersController>/5
        [HttpGet("{id}")]
        public ActionResult<Provider> Get(int id)
        {
            var pruvider = _context.pruviders.Find(x => x.Id == id);
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
            _context.pruviders.Add(p);
            return Ok();
        }

        // PUT api/<PruvidersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Provider p)
        {
            var pruvider = _context.pruviders.Find(x => x.Id == id);
            if (pruvider == null)
                return NotFound(id);
            p.Id = pruvider.Id;
            _context.pruviders.Remove(pruvider);
            _context.pruviders.Add(p);
            return Ok();
        }

        // DELETE api/<PruvidersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var pruvider = _context.pruviders.Find(x => x.Id == id);
            if (pruvider == null)
                return NotFound();
            _context.pruviders.Remove(pruvider);
            return Ok();
        }
    }
}
