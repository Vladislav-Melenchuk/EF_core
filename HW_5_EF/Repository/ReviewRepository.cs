using System;
using System.Collections.Generic;
using System.Linq;
using HW_EF_5.Models;
using Microsoft.EntityFrameworkCore;

namespace HW_EF_5.Repositories
{
    public class ReviewRepository
    {
        private readonly CarServiceDbContext _context;

        public ReviewRepository(CarServiceDbContext context)
        {
            _context = context;
        }

        public void Add(Review review)
        {
            _context.Reviews.Add(review);
            _context.SaveChanges();
        }

        public List<Review> GetAll()
        {
            return _context.Reviews.Include(r => r.User).ToList();
        }

        public Review GetById(int id)
        {
            return _context.Reviews.Include(r => r.User).FirstOrDefault(r => r.Id == id);
        }

        public void Update(Review review)
        {
            _context.Reviews.Update(review);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var review = _context.Reviews.Find(id);
            if (review != null)
            {
                _context.Reviews.Remove(review);
                _context.SaveChanges();
            }
        }
    }
}
