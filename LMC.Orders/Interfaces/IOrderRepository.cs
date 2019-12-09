using LMC.Common;
using System.Collections.Generic;

namespace LMC.Orders.Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders();
        Order GetOrder(int id);
        void AddOrder(Order newOrder);
        void UpdateOrder(Order order);
        void RemoveOrder(int id);
    }
}
