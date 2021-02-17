using DatabaseProvider;
using DatabaseProvider.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Services.Interfaces;
using System.Threading.Tasks;

namespace BikeManager.Controllers
{
    [Route("api/typebike")]
    [ApiController]
    public class TypeBikeController : ControllerBase
    {
        private readonly ITypeBikeService _typeBikeService;
        private readonly BikeContext _context;

        public TypeBikeController(ITypeBikeService typeBikeService, BikeContext context)
        {
            _typeBikeService = typeBikeService;
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(TypeBike typeBike)
        {
            if (!_typeBikeService.CreateTypeBike(typeBike))
                return new BadRequestObjectResult("Couldn't recognize the type");

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _typeBikeService.GetTypeBikes();

            return Ok(result);
        }
    }
}
