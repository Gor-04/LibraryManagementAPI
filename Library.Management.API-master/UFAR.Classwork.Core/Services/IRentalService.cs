using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.Core.Services
{
    public interface IRentalService
    {
        void RentBook(int userId, int bookId);
        void ReturnBook(int rentalId);
        List<RentalEntity> GetAllRentals();
        List<RentalEntity> GetRentalsByUserId(int userId);

    }
}
