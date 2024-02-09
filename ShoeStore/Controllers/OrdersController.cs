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
        public ActionResult Get()
        {
            var orders = _serviceOrder.GetOrders();
            var ordersDto=_mapper.Map<IEnumerable<OrderDto>>(orders);
            return Ok(ordersDto);
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var order = _serviceOrder.GetOrderById(id);
            var orderDto=_mapper.Map<OrderDto>(order);
            return Ok(orderDto);
        }

        // POST api/<OrdersController>
        [HttpPost]
        public ActionResult Post([FromBody] OrderPostModel order)
        {
            var orderToAdd=_mapper.Map<Order>(order);
            var newOrder = _serviceOrder.Add(orderToAdd);
            return Ok(_mapper.Map<OrderDto>(newOrder));
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] OrderPostModel order)
        {
            var orderToUpdate= _mapper.Map<Order>(order);
            var updateOrder=_serviceOrder.Update(id, orderToUpdate);
            return Ok(_mapper.Map<OrderDto>(updateOrder));
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var order = _serviceOrder.GetOrderById(id);
            if (order is null)
            {
                return NotFound();
            }

            _serviceOrder.Delete(id);
            return NoContent();
        }
    }
}
