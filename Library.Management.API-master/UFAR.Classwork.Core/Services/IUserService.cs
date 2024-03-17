using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.Core.Services
{
    public interface IUserService
    {
        void AddUser(UserEntity user);
        void DeleteUser(int userId);
        void UpdateUser(UserEntity user);
        List<UserEntity> GetAllUsers();
        UserEntity GetUserById(int userId);
    }
}