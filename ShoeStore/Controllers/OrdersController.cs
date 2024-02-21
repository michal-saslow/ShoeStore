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
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _serviceOrder;
        private readonly IMapper _mapper;
        
        public OrdersController(IOrderService serviceOrder,IMapper mapper)
        {
            _serviceOrder = serviceOrder;
            _mapper = mapper;
        }
        // GET: api/<OrdersController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var orders = await _serviceOrder.GetOrdersAsync();
            var ordersDto=_mapper.Map<IEnumerable<OrderDto>>(orders);
            return Ok(ordersDto);
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var order = await _serviceOrder.GetOrderByIdAsync(id);
            var orderDto=_mapper.Map<OrderDto>(order);
            return Ok(orderDto);
        }

        // POST api/<OrdersController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] OrderPostModel order)
        {
            var orderToAdd=_mapper.Map<Order>(order);
            var newOrder = await _serviceOrder.AddAsync(orderToAdd);
            return Ok(_mapper.Map<OrderDto>(newOrder));
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] OrderPostModel order)
        {
            var orderToUpdate= _mapper.Map<Order>(order);
            var updateOrder=await _serviceOrder.UpdateAsync(id, orderToUpdate);
            return Ok(_mapper.Map<OrderDto>(updateOrder));
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var order = await _serviceOrder.GetOrderByIdAsync(id);
            if (order is null)
            {
                return NotFound();
            }
            await _serviceOrder.DeleteAsync(id);
            return NoContent();
        }
    }
}
