using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UFAR.Classwork.Core.Services;
using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService _ratingService;

        public RatingController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        [HttpGet("List")]
        public IActionResult GetRatings()
        {
            return Ok(_ratingService.GetAllRatings());
        }

        [HttpGet("GetRatingById")]
        public IActionResult GetRatingById(int ratingId)
        {
            return Ok(_ratingService.GetRatingById(ratingId));
        }

        [HttpPost("AddRating")]
        public IActionResult AddRating(RatingEntity rating)
        {
            _ratingService.AddRating(rating);
            return Ok();
        }

        [HttpDelete("DeleteRating")]
        public IActionResult DeleteRating(int ratingId)
        {
            _ratingService.DeleteRating(ratingId);
            return Ok();
        }
    }
}
