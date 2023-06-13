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
        public IActionResult GetAllIsEmri()
        {
            var entity = _manager.IsEmriService.GetAllIsEmri().Take(5);
            if (entity is null)
                return NotFound();
            return Ok(entity);
        }

        [HttpGet("{isEmriId:int}")]
        public IActionResult GetIsEmriByIsEmriId([FromRoute(Name = "isEmriId")] int isEmriId)
        {
            var entity = _manager.IsEmriService.GetIsEmriById(isEmriId);
            if (entity is null)
                return NotFound();
            return Ok(entity);
        }
    }
}
