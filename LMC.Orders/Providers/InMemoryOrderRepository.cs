using LMC.Common;
using LMC.Orders.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace LMC.Orders.Providers
{
    public class InMemoryOrderRepository : IOrderRepository
    {
        private ICollection<Order> _orders = new Collection<Order>()
        {
            new Order{Id = 1, Customer = "Paul", Status = OrderStatus.Open,
                Lines = new []{
                    new OrderLine{Item = new MenuItem{Id = Guid.NewGuid(), Name="20 oz. Mocha Latte", Price = 2.49m}
                    , Quantity = 1}
                }
            },
            new Order{Id = 1, Customer = "Steve M", Status = OrderStatus.Open,
                Lines = new []{
                    new OrderLine{Item = new MenuItem{Id = Guid.NewGuid(), Name="20 oz. Chai Latte", Price = 3.49m},
                    Quantity = 2}
                }
            },
            new Order{Id = 1, Customer = "Lori T", Status = OrderStatus.Open,
                Lines = new []{
                    new OrderLine{Item = new MenuItem{Id = Guid.NewGuid(), Name="20 oz. Coffee Plain", Price = 0.99m},
                    Quantity = 2,
                    Comment = "1 cream, 2 sugar"}
                }
            },
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