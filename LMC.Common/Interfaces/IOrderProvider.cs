using System;
using System.Collections.Generic;
using System.Text;

namespace LMC.Common.Interfaces
{
    public interface IOrderProvider
    {
        IEnumerable<Order> GetAllOrders();

        IEnumerable<Order> GetOpenOrders();

        Order GetOrder(int orderId);

        void AddOrder(Order newOrder);

        void RemoveOrder(Order order);

        void UpdateOrder(Order order);
    }
}
