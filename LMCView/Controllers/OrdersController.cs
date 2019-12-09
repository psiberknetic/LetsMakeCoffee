using LMC.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace LMC.Web.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        public async Task<ActionResult> Index()
        {
            var results = await GetAllOrders();
            return View(results.OrderBy(o => o.Id));
        }

        // GET: Orders/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var order = await GetOrder(id);
            return View(order);
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            var order = new Order();
            return View();
        }

        // POST: Orders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Order order)
        {
            try
            {
                await CreateOrder(order);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private async Task CreateOrder(Order order)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            await client.PostAsJsonAsync($"api/Orders", order);
        }

        // GET: Orders/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var order = await GetOrder(id);
            return View(order);
        }

        // POST: Orders/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Order order)
        {
            try
            {
                await UpdateOrder(order);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Orders/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var order = await GetOrder(id);
            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                await DeleteOrder(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private async Task<IEnumerable<Order>> GetAllOrders()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetAsync("api/Orders");

            var orders = await response.Content.ReadAsAsync<IEnumerable<Order>>();

            return orders;
        }

        private async Task<Order> GetOrder(int Id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetAsync($"api/Orders/{Id}");

            var order = await response.Content.ReadAsAsync<Order>();

            return order;
        }



        private async Task DeleteOrder(int Id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.DeleteAsync($"api/Orders/{Id}");
        }

        private async Task UpdateOrder(Order order)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            await client.PutAsJsonAsync<Order>($"api/Orders/{order.Id}", order);
        }
    }
}