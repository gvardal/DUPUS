using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace DUPUS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrunlerController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public UrunlerController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        [Route("UrunById")]
        public IActionResult GetUrunById([FromQuery] int id)
        {
            var entity = _manager.UrunlerService.GetUrunById(id);
            if (entity is null)
                return NotFound();
            return Ok(entity);
        }
    }
}
