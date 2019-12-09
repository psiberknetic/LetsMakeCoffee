using LMC.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LMC.Web.Controllers
{
    public class DealsController : Controller
    {
        private readonly IDealProvider _dealProvider;

        public DealsController(IDealProvider dealProvider)
        {
            _dealProvider = dealProvider;
        }

        // GET: Deals
        public ActionResult Index()
        {
            return View(_dealProvider.GetDeals());
        }

        // GET: Deals/Details/5
        public ActionResult Details(string code)
        {
            var deal = _dealProvider.GetDealByCode(code);

            if (deal == null)
            {
                return NotFound();
            }

            return View(deal);
        }
    }
}