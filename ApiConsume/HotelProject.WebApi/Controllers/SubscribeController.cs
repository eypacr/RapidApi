using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpGet]
        public async Task<IActionResult> SubscribeList()
        {
            try
            {
                var Subscribe = await _subscribeService.TGetAllAsync();
                return Ok(Subscribe);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Sunucu hatası: " + ex.Message); // Server error response
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddSubscribe(Subscribe subscribeService)
        {
            await _subscribeService.TAddAsync(subscribeService);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubscribe(int id)
        {
            var values = await _subscribeService.TGetByIdAsync(id);
            await _subscribeService.TDeleteAsync(values);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSubscribe(Subscribe subscribe)
        {
             await _subscribeService.TUpdateAsync(subscribe);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubscribe(int id)
        {
            var values = await _subscribeService.TGetByIdAsync(id);
            return Ok(values);
        }
    }
}
