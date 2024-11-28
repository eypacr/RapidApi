using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public async Task<IActionResult> RoomList()
        {
            try
            {
                var rooms = await _roomService.TGetAllAsync();
                return Ok(rooms);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Sunucu hatası: " + ex.Message); // Server error response
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddRoom(Room room)
        {
            await _roomService.TAddAsync(room);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            var values = await _roomService.TGetByIdAsync(id);
            await _roomService.TDeleteAsync(values);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRoom(Room room)
        {
             await _roomService.TUpdateAsync(room);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoom(int id)
        {
            var values = await _roomService.TGetByIdAsync(id);
            return Ok(values);
        }
    }
}
