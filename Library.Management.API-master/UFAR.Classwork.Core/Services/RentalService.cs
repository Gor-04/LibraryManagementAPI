using System;
using System.Collections.Generic;
using System.Linq;
using UFAR.Classwork.Data.DAO;
using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.Core.Services
{
    public class RentalService : IRentalService
    {
        private readonly ApplicationDbContext _context;

        public RentalService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void RentBook(int userId, int bookId)
        {
            var rental = new RentalEntity
            {
                UserId = userId,
                BookId = bookId,
                RentalDate = DateTime.Now
            };
            _context.Rentals.Add(rental);
            _context.SaveChanges();
        }

        public void ReturnBook(int rentalId)
        {
            var rental = _context.Rentals.Find(rentalId);
            if (rental != null)
            {
                rental.ReturnDate = DateTime.Now;
                _context.SaveChanges();
            }
        }

        public List<RentalEntity> GetAllRentals()
        {
            return _context.Rentals.ToList();
        }

        public RentalEntity GetRentalById(int rentalId)
        {
            return _context.Rentals.Find(rentalId);
        }

        public List<RentalEntity> GetRentalsByUserId(int userId)
        {
            return _context.Rentals.Where(r => r.UserId == userId).ToList();
        }

        public List<RentalEntity> GetRentalsByBookId(int bookId)
        {
            return _context.Rentals.Where(r => r.BookId == bookId).ToList();
        }
    }
}
