using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMC.Common.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMC.Orders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderProvider _orderProvider;

        public OrdersController(IOrderProvider orderProvider)
        {
            _orderProvider = orderProvider;
        }

        // GET: api/Orders
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_orderProvider.GetAllOrders());
        }

        // GET: api/Orders/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get(int id)
        {
            var order = _orderProvider.GetOrder(id);

            if (order == null)
            {
                return NotFound();
            }

            return Ok(_orderProvider.GetOrder(id));
        }

        // POST: api/Orders
        [HttpPost]
        public ActionResult Post([FromBody] string value)
        {
            return Ok();
        }

        // PUT: api/Orders/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] string value)
        {
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
