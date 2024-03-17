using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UFAR.Classwork.Core.Services;
using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        private readonly IRentalService _rentalService;

        public RentalController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet("List")]
        public IActionResult GetRentals()
        {
            return Ok(_rentalService.GetAllRentals());
        }

        [HttpGet("GetRentalById")]
        public IActionResult GetRentalsByUserId(int rentalId)
        {
            return Ok(_rentalService.GetRentalsByUserId(rentalId));
        }

        [HttpPost("RentBook")]
        public IActionResult RentBook(RentalEntity rental)
        {
            _rentalService.RentBook(rental.UserId, rental.BookId);
            return Ok();
        }

        [HttpPut("ReturnBook")]
        public IActionResult ReturnBook(int rentalId)
        {
            _rentalService.ReturnBook(rentalId);
            return Ok();
        }
    }
}

