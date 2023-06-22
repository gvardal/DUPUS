using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;
using Services.Contracts;

namespace DUPUS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IsEmriController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public IsEmriController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        [Route("IsEmriListesi")]
        public IActionResult GetAllIsEmri()
        {
            var entity = _manager.IsEmriService.GetAllIsEmri().Take(50);
            if (entity is null)
                return NotFound();
            return Ok(entity);
        }

        [HttpGet]
        [Route("IsEmriListesiById")]
        public IActionResult GetIsEmriByIsEmriId([FromQuery] int isEmriId = 385090)
        {
            var entity = _manager.IsEmriService.GetIsEmriById(isEmriId);
            if (entity is null)
                return NotFound();
            return Ok(entity);
        }

        [HttpGet]
        [Route("IsEmriDurumuListesi")]
        public IActionResult GetAllIsEmriDurum()
        {
            var entity = _manager.IsEmriService.GetAllIsEmriDurumu();
            if (entity is null)
                return NotFound();
            return Ok(entity);
        }

        [HttpGet]
        [Route("IsEmriDurumuById")]
        public IActionResult GetIsEmriDurumById([FromQuery] int id)
        {
            var entity = _manager.IsEmriService.GetIsEmriDurumuById(id);
            if (entity is null)
                return NotFound();
            return Ok(entity);
        }

        [HttpGet]
        [Route("GanttTasks")]
        public IActionResult GanttDataSource()
        {
            var entity = _manager.IsEmriService.GanttTasks();
            if (entity is null)
                return NotFound();
            return Ok(entity);
        }

        [HttpGet]
        [Route("GanttMainTasks")]
        public IActionResult GanttMainTasks()
        {
            var entity = _manager.IsEmriService.GanttMainTasks();
            if (entity is null)
                return NotFound();
            return Ok(entity);
        }
    }
}
