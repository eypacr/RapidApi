using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public async Task<IActionResult> StaffList()
        {
            try
            {
                var staff = await _staffService.TGetAllAsync();
                return Ok(staff);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Sunucu hatası: " + ex.Message); // Server error response
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddStaff(Staff staff)
        {
            await _staffService.TAddAsync(staff);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaff(int id)
        {
            var values = await _staffService.TGetByIdAsync(id);
            await _staffService.TDeleteAsync(values);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStaff(Staff staff)
        {
             await _staffService.TUpdateAsync(staff);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStaff(int id)
        {
            var values = await _staffService.TGetByIdAsync(id);
            return Ok(values);
        }
    }
}
