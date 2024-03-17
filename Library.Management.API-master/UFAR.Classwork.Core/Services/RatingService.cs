using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using UFAR.Classwork.Data.DAO;
using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.Core.Services
{
    public class RatingService : IRatingService
    {
        private readonly ApplicationDbContext _context;

        public RatingService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddRating(RatingEntity Rating)
        {
            _context.Ratings.Add(Rating);
            _context.SaveChanges();
        }

        public void DeleteRating(int RatingId)
        {
            var Rating = _context.Ratings.Find(RatingId);
            if (Rating != null)
            {
                _context.Ratings.Remove(Rating);
                _context.SaveChanges();
            }
        }

        public List<RatingEntity> GetAllRatings()
        {
            return _context.Ratings.ToList();
        }

        public RatingEntity GetRatingById(int RatingId)
        {
            return _context.Ratings.Find(RatingId);
        }

        public List<RatingEntity> GetRatingsByBookId(int bookId)
        {
            return _context.Ratings.Where(br => br.BookId == bookId).ToList();
        }

        public double GetAverageRatingByBookId(int bookId)
        {
            var ratings = _context.Ratings.Where(br => br.BookId == bookId).Select(br => br.Rating);
            if (ratings.Any())
            {
                return ratings.Average();
            }
            return 0; // Return 0 if there are no ratings
        }

        public void UpdateRating(RatingEntity Rating)
        {
            _context.Entry(Rating).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
