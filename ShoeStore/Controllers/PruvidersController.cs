using Microsoft.AspNetCore.Mvc;
using ShoeStore.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoeStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruvidersController : ControllerBase
    {
        public static List<Pruviders> pruviders = new List<Pruviders>();
        public static int id = 0;
        // GET: api/<PruvidersController>
        [HttpGet]
        public ActionResult<IEnumerable<Pruviders>> Get()
        {
            if (pruviders == null)
                return NotFound();
            return pruviders;
        }

        // GET api/<PruvidersController>/5
        [HttpGet("{id}")]
        public ActionResult<Pruviders> Get(int id)
        {
            var pruvider = pruviders.Find(x => x.Id == id);
            if (pruvider == null)
                return NotFound();
            return pruvider;
        }

        // POST api/<PruvidersController>
        [HttpPost]
        public ActionResult Post([FromBody] Pruviders p)
        {
            id++;
            p.Id = id;
            pruviders.Add(p);
            return Ok();
        }

        // PUT api/<PruvidersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Pruviders p)
        {
            var pruvider = pruviders.Find(x => x.Id == id);
            if (pruvider == null)
                return NotFound(id);
            pruviders.Remove(pruvider);
            pruviders.Add(p);
            return Ok();
        }

        // DELETE api/<PruvidersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var pruvider = pruviders.Find(x => x.Id == id);
            if (pruvider == null)
                return NotFound();
            pruviders.Remove(pruvider);
            return Ok();
        }
    }
}
