using LMC.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
