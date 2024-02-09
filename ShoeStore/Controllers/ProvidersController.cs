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
    public class ProvidersController : ControllerBase
    {
        private readonly IProviderService _serviceProvider;
        public readonly IMapper _mapper;
        public ProvidersController(IProviderService serviceProvider,IMapper mapper)
        {
            _serviceProvider = serviceProvider;
            _mapper = mapper;
        }
        // GET: api/<PruvidersController>
        [HttpGet]
        public ActionResult Get()
        {
            var providers = _serviceProvider.GetProvider();
            var providersDto=_mapper.Map<IEnumerable<ProviderDto>>(providers);
            return Ok(providersDto);
        }

        // GET api/<PruvidersController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
           var provider= _serviceProvider.GetProviderById(id);
           var providerDto= _mapper.Map<ProviderDto>(provider);
           return Ok(providerDto);
        }

        // POST api/<PruvidersController>
        [HttpPost]
        public ActionResult Post([FromBody] ProviderPostModel p)
        {
            var providerToAdd=_mapper.Map<Provider>(p);
            var newProvider = _serviceProvider.Add(providerToAdd);
            return Ok(_mapper.Map<ProviderDto>(newProvider));
        }

        // PUT api/<PruvidersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ProviderPostModel p)
        {
            var providerToUpdate=_mapper.Map<Provider>(p);
            var updateProvider = _serviceProvider.Update(id, providerToUpdate);
            return Ok(_mapper.Map<ProviderDto>(updateProvider));
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
