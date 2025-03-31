using System;
using HW_6_EF.Models;
using HW_EF_6.Repositories;

class Program
{
    static void Main()
    {
        using (var context = new CarServiceDbContext())
        {
            var orderRepository = new OrderRepository(context);
            var carRepository = new CarRepository(context);

            //var carId1 = 5;
            //var carId2 = 6;

            //var car1 = context.Cars.Find(carId1);
            //var car2 = context.Cars.Find(carId2);


            //var order1 = new Order { CarId = car1.Id };
            //var order2 = new Order { CarId = car2.Id };

            //orderRepository.Add(order1);
            //orderRepository.Add(order2);
            //context.SaveChanges();
            //Console.WriteLine($"Созданы заказы: {order1.Id}, {order2.Id}");

            Console.Write("Введите ID пользователя для поиска заказов: ");
            int userId = int.Parse(Console.ReadLine());

            var orders = orderRepository.GetOrdersByUserId(userId);

            if (orders.Any())
            {
                Console.WriteLine($"Заказы пользователя {userId}:");
                foreach (var order in orders)
                {
                    Console.WriteLine($"Заказ #{order.OrderId}, Машина: {order.CarMake} {order.CarModel}, Пользователь: {order.UserName} ({order.UserEmail})");
                }
            }
            else
            {
                Console.WriteLine("У пользователя нет заказов.");
            }


        }
    }
}
