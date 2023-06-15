using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace DUPUS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KonumController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public KonumController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public IActionResult GetAllKonumList()
        {
            var entity = _manager.KonumService.GetAllKonumList().Take(5);
            if (entity is null)
                return NotFound();
            return Ok(entity);
        }

        [HttpGet("{KonumTuruId:int}")]
        public IActionResult GetIsEmriByIsEmriId([FromRoute(Name = "KonumTuruId")] byte konumTuruId)
        {
            var entity = _manager.KonumService.GetAllKonumByKonumId(konumTuruId);
            if (entity is null)
                return NotFound();
            return Ok(entity);
        }
    }
}
