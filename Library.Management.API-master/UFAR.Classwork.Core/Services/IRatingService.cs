using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.Core.Services
{
    public interface IRatingService
    {
        void AddRating(RatingEntity Rating);
        void DeleteRating(int RatingId);
        List<RatingEntity> GetAllRatings();
        RatingEntity GetRatingById(int RatingId);
        List<RatingEntity> GetRatingsByBookId(int bookId);

        double GetAverageRatingByBookId(int bookId);

        void UpdateRating(RatingEntity Rating);

    }
}
