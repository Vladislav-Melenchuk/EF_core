using System;
using System.Collections.Generic;
using System.Linq;
using HW_EF_5.Models;
using Microsoft.EntityFrameworkCore;

namespace HW_EF_5.Repositories
{
    public class CarRepository
    {
        private readonly CarServiceDbContext _context;

        public CarRepository(CarServiceDbContext context)
        {
            _context = context;
        }

        public void Add(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
        }

        public List<Car> GetAll()
        {
            return _context.Cars.Include(c => c.User).ToList();
        }

        public Car GetById(int id)
        {
            return _context.Cars.Find(id);
        }


        public void Update(Car car)
        {
            _context.Cars.Update(car);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var car = _context.Cars.Find(id);
            if (car != null)
            {
                _context.Cars.Remove(car);
                _context.SaveChanges();
            }
        }
    }
}
