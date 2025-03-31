using System;
using System.Collections.Generic;
using System.Linq;
using HW_6_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace HW_EF_6.Repositories
{
    public class ServiceCategoryRepository
    {
        private readonly CarServiceDbContext _context;

        public ServiceCategoryRepository(CarServiceDbContext context)
        {
            _context = context;
        }

        public void Add(ServiceCategory serviceCategory)
        {
            _context.ServiceCategories.Add(serviceCategory);
            _context.SaveChanges();
        }

        public List<ServiceCategory> GetAll()
        {
            return _context.ServiceCategories.ToList();
        }

        public ServiceCategory GetById(int id)
        {
            return _context.ServiceCategories.Find(id);
        }

        public void Update(ServiceCategory serviceCategory)
        {
            _context.ServiceCategories.Update(serviceCategory);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var serviceCategory = _context.ServiceCategories.Find(id);
            if (serviceCategory != null)
            {
                _context.ServiceCategories.Remove(serviceCategory);
                _context.SaveChanges();
            }
        }
    }
}
