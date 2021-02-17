using DatabaseProvider;
using DatabaseProvider.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Services.Interfaces;
using System.Threading.Tasks;

namespace BikeManager.Controllers
{
    [Route("api/bike")]
    [ApiController]
    public class BikeController : ControllerBase
    {
        private readonly IBikeService _bikeService;
        private readonly BikeContext _context;

        public BikeController(IBikeService bikeService, BikeContext context)
        {
            _bikeService = bikeService;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _bikeService.GetBikes();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Bike bike)
        {
            if (!_bikeService.CreateBike(bike))
                return new BadRequestObjectResult("Couldn't recognize the bike");

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Bike bike)
        {
            if (bike == null)
                return new BadRequestObjectResult("Couldn't recognize the bike");

            if (!_bikeService.UpdateBike(bike))
                return new BadRequestObjectResult("Couldn't find bike");

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!_bikeService.DeleteBike(id))
                return new BadRequestObjectResult("Couldn't find bike");

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
