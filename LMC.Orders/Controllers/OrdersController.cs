using LMC.Common;
using LMC.Orders.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace LMC.Orders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrdersController(IOrderRepository orderProvider)
        {
            _orderRepository = orderProvider;
        }

        // GET: api/Orders
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_orderRepository.GetOrders());
        }

        // GET: api/Orders/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get(int id)
        {
            var order = _orderRepository.GetOrder(id);

            if (order == null)
            {
                return NotFound();
            }

            return Ok(_orderRepository.GetOrder(id));
        }

        // POST: api/Orders
        [HttpPost]
        public ActionResult Post([FromBody] Order value)
        {
            _orderRepository.AddOrder(value);
            return Ok();
        }

        // PUT: api/Orders/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Order value)
        {
            _orderRepository.UpdateOrder(value);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _orderRepository.RemoveOrder(id);
            return Ok();
        }
    }
}
