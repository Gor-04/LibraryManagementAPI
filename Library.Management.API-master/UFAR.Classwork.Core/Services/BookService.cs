using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using UFAR.Classwork.Data.DAO;
using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.Core.Services
{
    public class BookService : IBookService
    {
        private readonly ApplicationDbContext _context;

        public BookService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddBook(BookEntity book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void DeleteBook(int bookId)
        {
            var book = _context.Books.Find(bookId);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }

        public List<BookEntity> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public BookEntity GetBookById(int bookId)
        {
            return _context.Books.Find(bookId);
        }

        public void UpdateBook(BookEntity book)
        {
            _context.Entry(book).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
