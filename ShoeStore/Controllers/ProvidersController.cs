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
        public async Task<ActionResult> Get()
        {
            var providers = await _serviceProvider.GetProviderAsync();
            var providersDto=_mapper.Map<IEnumerable<ProviderDto>>(providers);
            return Ok(providersDto);
        }

        // GET api/<PruvidersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
           var provider= await _serviceProvider.GetProviderByIdAsync(id);
           var providerDto= _mapper.Map<ProviderDto>(provider);
           return Ok(providerDto);
        }

        // POST api/<PruvidersController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ProviderPostModel p)
        {
            var providerToAdd=_mapper.Map<Provider>(p);
            var newProvider = await _serviceProvider.AddAsync(providerToAdd);
            return Ok(_mapper.Map<ProviderDto>(newProvider));
        }

        // PUT api/<PruvidersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ProviderPostModel p)
        {
            var providerToUpdate=_mapper.Map<Provider>(p);
            var updateProvider = await _serviceProvider.UpdateAsync(id, providerToUpdate);
            return Ok(_mapper.Map<ProviderDto>(updateProvider));
        }

        // DELETE api/<PruvidersController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var provider = await _serviceProvider.GetProviderByIdAsync(id);
            if (provider is null)
            {
                return NotFound();
            }

            await _serviceProvider.DeleteAsync(id);
            return NoContent();
        }
    }
}
