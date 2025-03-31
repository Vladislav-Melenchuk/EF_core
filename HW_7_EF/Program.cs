using System;
using HW_6_EF.Models;
using HW_EF_6.Repositories;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main()
    {
        using (var context = new CarServiceDbContext())
        {
            var orderRepository = new OrderRepository(context);

            
            int userId = 11; 
            int carId1 = 5; 
            int carId2 = 8; 

            
            var userExists = context.Users.Any(u => u.Id == userId);
            if (!userExists)
            {
                Console.WriteLine($"Ошибка: Пользователь с ID {userId} не найден.");
                return;
            }

            
            var order1 = new Order { CarId = carId1, UserId = userId };
            var order2 = new Order { CarId = carId2, UserId = userId };

            orderRepository.Add(order1);
            orderRepository.Add(order2);
            context.SaveChanges();

            Console.WriteLine($"Созданы заказы: {order1.Id}, {order2.Id}");

            
            var orders = orderRepository.GetAllOrdersWithCars();
            foreach (var order in orders)
            {
                Console.WriteLine($"Заказ #{order.Id}, Машина: {order.Car.Make} {order.Car.Model}, Пользователь ID: {order.UserId}");
            }
        }
    }
}
