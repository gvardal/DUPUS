using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;

namespace DUPUS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IsEmriRotasiController : ControllerBase
    {
        private readonly IRepositoryManager _manager;

        public IsEmriRotasiController(IRepositoryManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public IActionResult GetAllIsEmriRotasi()
        {
            var entity = _manager.IsEmriRota.GetAllIsEmriRotaList(false).Take(10);
            if (entity is null)
                return NotFound();
            return Ok(entity);
        }

        [HttpGet("{isEmriId:int}")]
        public IActionResult GetIsEmriRotasiByIsEmriId([FromRoute(Name ="isEmriId")]int isEmriId)
        {
            var entity = _manager.IsEmriRota.IsEmriRotasiById(isEmriId, false);
            if (entity is null)
                return NotFound();
            return Ok(entity);
        }
    }
}
