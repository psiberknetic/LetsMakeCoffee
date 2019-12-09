using LMC.Common;
using LMC.Orders.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace LMC.Orders.Providers
{
    public class InMemoryOrderRepository : IOrderRepository
    {
        private ICollection<Order> _orders = new Collection<Order>()
        {
            new Order{Id = 1, Customer = "Nate", Status = OrderStatus.Open}
        };

        public void AddOrder(Order newOrder)
        {
            _orders.Add(newOrder);
        }

        public IEnumerable<Order> GetOrders()
        {
            return _orders;
        }

        public Order GetOrder(int orderId)
        {
            return _orders.FirstOrDefault(o => o.Id == orderId);
        }

        public void RemoveOrder(int id)
        {
            var orderToRemove = _orders.FirstOrDefault(o => o.Id == id);
            _orders.Remove(orderToRemove);
        }

        public void UpdateOrder(Order order)
        {
            RemoveOrder(order.Id);
            AddOrder(order);
        }
    }
}
