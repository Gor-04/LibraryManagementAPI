using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UFAR.Classwork.Data.DAO;
using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.Core.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddUser(UserEntity user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void DeleteUser(int userId)
        {
            var user = _context.Users.Find(userId);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public List<UserEntity> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public UserEntity GetUserById(int userId)
        {
            return _context.Users.Find(userId);
        }

        public void UpdateUser(UserEntity user)
        {
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
