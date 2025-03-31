using HW_4_EF.Models;  
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        using (var context = new CarServiceDbContext())  
        {
            Console.WriteLine("Проверяем подключение к БД...");

            
            var users = context.Users.ToList();
            if (users.Count == 0)
            {
                Console.WriteLine("В БД пока нет пользователей.");
            }
            else
            {
                Console.WriteLine("Список пользователей:");
                foreach (var user in users)
                {
                    Console.WriteLine($"ID: {user.Id}, Имя: {user.Name}, Email: {user.Email}");
                }
            }
        }
    }
}
