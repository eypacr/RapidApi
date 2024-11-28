using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        public async Task<IActionResult> TestimonialList()
        {
            try
            {
                var testimonials = await _testimonialService.TGetAllAsync();
                return Ok(testimonials);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Sunucu hatası: " + ex.Message); // Server error response
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddTestimonial(Testimonial testimonial)
        {
            await _testimonialService.TAddAsync(testimonial);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            var values = await _testimonialService.TGetByIdAsync(id);
            await _testimonialService.TDeleteAsync(values);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(Testimonial testimonial)
        {
             await _testimonialService.TUpdateAsync(testimonial);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestimonial(int id)
        {
            var values = await _testimonialService.TGetByIdAsync(id);
            return Ok(values);
        }
    }
}
