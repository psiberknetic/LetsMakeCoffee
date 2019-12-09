using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMC.Common.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMC.Web.Controllers
{
    public class MenuItemsController : Controller
    {
        private readonly IMenuProvider _provider;

        public MenuItemsController(IMenuProvider provider)
        {
            _provider = provider;
        }

        // GET: MenuItems
        public ActionResult Index()
        {
            return View(_provider.GetMenuItems());
        }

        // GET: MenuItems/Details/5
        public ActionResult Details(Guid id)
        {
            var menuItem = _provider.GetMenuItem(id);
            if (menuItem != null)
            {
                return View(menuItem);
            }

            return NotFound();
        }
    }
}