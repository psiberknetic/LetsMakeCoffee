using LMC.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace LMC.MenuService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealsController : ControllerBase
    {
        private IDealProvider _dealProvider;

        public DealsController(IDealProvider dealProvider)
        {
            _dealProvider = dealProvider;
        }

        // GET: api/Deals
        [HttpGet]
        public IActionResult Get()
        {
            if (_dealProvider.GetDeals().Any())
            {
                return Ok(_dealProvider.GetDeals());
            }

            return NotFound();
        }

        // GET: api/Deals/Super50Friday
        [HttpGet("{code}", Name = "Get")]
        public IActionResult Get(string code)
        {
            var value = _dealProvider.GetDealByCode(code);

            if (value == null)
            {
                return NotFound();
            }

            return Ok(value);
        }
    }
}
