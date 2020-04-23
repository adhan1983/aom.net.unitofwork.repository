using System;
using AOM.UnitOfWorkSln.API.Models;
using AOM.UnitOfWorkSln.API.Interfaces;
using AOM.UnitOfWorkSln.API.Data;
using System.Linq;

namespace AOM.UnitOfWorkSln.API.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _context;
        public OrderRepository(DataContext context)
        {
            _context = context;
        }

        public Order GetOrder(int id)
        {
            var order = _context.Orders.FirstOrDefault(o => o.id == id);

            return order;
        }

        public void Save(Order order)
        {
            _context.Orders.Add(order);            
        }
    }
}
