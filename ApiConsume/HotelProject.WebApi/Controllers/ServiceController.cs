using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public async Task<IActionResult> ServiceList()
        {
            try
            {
                var Service = await _serviceService.TGetAllAsync();
                return Ok(Service);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Sunucu hatası: " + ex.Message); // Server error response
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddService(Service Service)
        {
            await _serviceService.TAddAsync(Service);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(int id)
        {
            var values = await _serviceService.TGetByIdAsync(id);
            await _serviceService.TDeleteAsync(values);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateService(Service Service)
        {
            await _serviceService.TUpdateAsync(Service);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetService(int id)
        {
            var values = await _serviceService.TGetByIdAsync(id);
            return Ok(values);
        }

    }
}
