using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;

namespace DUPUS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IsEmriController : ControllerBase
    {
        private readonly IRepositoryManager _manager;

        public IsEmriController(IRepositoryManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public IActionResult GetAllIsEmri()
        {
            var entity = _manager.IsEmri.GetAllIsEmriList().Take(5);
            if(entity is null) 
                return NotFound();
            return Ok(entity);
        }

        [HttpGet("{isEmriId:int}")]
        public IActionResult GetIsEmriByIsEmriId([FromRoute(Name = "isEmriId")] int isEmriId)
        {
            var entity = _manager.IsEmri.IsEmriById(isEmriId);
            if (entity is null)
                return NotFound();
            return Ok(entity);
        }
    }
}
