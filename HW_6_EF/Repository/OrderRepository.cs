using System;
using System.Collections.Generic;
using System.Linq;
using HW_6_EF.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace HW_EF_6.Repositories
{
    public class OrderRepository
    {
        private readonly CarServiceDbContext _context;

        public OrderRepository(CarServiceDbContext context)
        {
            _context = context;
        }

        public void Add(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return _context.Orders.Include(o => o.Car).ToList();
        }

        public Order GetById(int id)
        {
            return _context.Orders.Include(o => o.Car).FirstOrDefault(o => o.Id == id);
        }

        public void Update(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var order = _context.Orders.Find(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }

        public List<OrdersView> GetOrdersByUserId(int userId)
        {
            return _context.OrdersView
                .FromSqlRaw("EXEC GetOrdersByUserId @p0", userId)
                .ToList();
        }

    }
}
