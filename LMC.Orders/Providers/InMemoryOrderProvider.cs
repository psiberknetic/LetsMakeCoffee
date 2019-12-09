using LMC.Common;
using LMC.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMC.Orders.Providers
{
    public class InMemoryOrderProvider : IOrderProvider
    {
        private List<Order> _orders = new List<Order>()
        {
            new Order{Id = 1, Customer = "Nate", Status = OrderStatus.Open}
        };

        public void AddOrder(Order newOrder)
        {
            _orders.Add(newOrder);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orders;
        }

        public IEnumerable<Order> GetOpenOrders()
        {
            return _orders.Where(o => o.Status == OrderStatus.Open);
        }

        public Order GetOrder(int orderId)
        {
            return _orders.FirstOrDefault(o => o.Id == orderId);
        }

        public void RemoveOrder(Order order)
        {
            _orders.RemoveAll(o => o.Id == order.Id);
        }

        public void UpdateOrder(Order order)
        {
            RemoveOrder(order);
            AddOrder(order);
        }
    }
}
