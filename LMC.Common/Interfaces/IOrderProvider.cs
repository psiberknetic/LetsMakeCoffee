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
    }
}
