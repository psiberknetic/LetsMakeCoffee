using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMC.Common;
using LMC.Common.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public IEnumerable<Deal> Get()
        {
            return _dealProvider.GetDeals();
        }

        // GET: api/Deals/Super50Friday
        [HttpGet("{code}", Name = "Get")]
        public Deal Get(string code)
        {
            return _dealProvider.GetDealByCode(code);
        }
    }
}
