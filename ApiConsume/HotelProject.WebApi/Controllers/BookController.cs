using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public async Task<IActionResult> BookingList()
        {
            try
            {
                var bookings = await _bookingService.TGetAllAsync();
                return Ok(bookings);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Sunucu hatası: " + ex.Message); // Server error response
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddBooking(Booking booking)
        {
            await _bookingService.TAddAsync(booking);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            var values = await _bookingService.TGetByIdAsync(id);
            await _bookingService.TDeleteAsync(values);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBooking(Booking booking)
        {
            await _bookingService.TUpdateAsync(booking);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBooking(int id)
        {
            var values = await _bookingService.TGetByIdAsync(id);
            return Ok(values);
        }
    }
}
