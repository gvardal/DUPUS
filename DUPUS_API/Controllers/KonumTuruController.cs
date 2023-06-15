using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace DUPUS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KonumTuruController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public KonumTuruController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public IActionResult GetAllIsEmri()
        {
            var entity = _manager.KonumTuruService.GetAllKonumTuru();
            if (entity is null)
                return NotFound();
            return Ok(entity);
        }
    }
}
