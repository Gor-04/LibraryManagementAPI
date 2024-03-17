using System.Collections.Generic;
using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.Core.Services
{
    public interface IBookService
    {
        void AddBook(BookEntity book);
        void UpdateBook(BookEntity book);
        void DeleteBook(int bookId);
        BookEntity GetBookById(int bookId);
        List<BookEntity> GetAllBooks();
    }
}