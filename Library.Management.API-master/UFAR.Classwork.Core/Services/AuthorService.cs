using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using UFAR.Classwork.Data.DAO;
using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.Core.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly ApplicationDbContext _context;

        public AuthorService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddAuthor(AuthorEntity author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }

        public void DeleteAuthor(int authorId)
        {
            var author = _context.Authors.Find(authorId);
            if (author != null)
            {
                _context.Authors.Remove(author);
                _context.SaveChanges();
            }
        }

        public List<AuthorEntity> GetAllAuthors()
        {
            return _context.Authors.ToList();
        }

        public AuthorEntity GetAuthorById(int authorId)
        {
            return _context.Authors.Find(authorId);
        }

        public void UpdateAuthor(AuthorEntity author)
        {
            _context.Entry(author).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
