using HW_EF_5.Models;
using HW_EF_5.Repositories;
using System;


class Program
{
    static void Main()
    {
        using (var context = new CarServiceDbContext())
        {
            var userRepository = new UserRepository(context);
            var carRepository = new CarRepository(context);


            //var newUser = new User { Name = "Владислав", Email = "omgpoko@example.com" };
            //userRepository.Add(newUser);
            //Console.WriteLine("Добавлен пользователь!");

            //var newUser2 = new User { Name = "Олег", Email = "fakeEmail@example.com" };
            //userRepository.Add(newUser2);
            //Console.WriteLine("Добавлен пользователь!");


            var newCar = new Car { Model = "Passat", Make = "VW", Year = 2025, UserId = 11 };
            carRepository.Add(newCar);
            Console.WriteLine("Добавлена машина!");

            var newCar2 = new Car { Model = "RS7", Make = "Audi", Year = 2024, UserId = 12 };
            carRepository.Add(newCar2);
            Console.WriteLine("Добавлена машина!");


            var users = userRepository.GetAll();
            Console.WriteLine("Список пользователей:");
            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.Id}, Имя: {user.Name}");
            }

            var carDelete = 1;
            carRepository.Delete(carDelete);
            Console.WriteLine("Машина удалена");





        }
    }
}
