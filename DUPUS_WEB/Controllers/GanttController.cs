using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace DUPUS_WEB.Controllers
{
    public partial class GanttController : Controller
    {
        private readonly IServiceManager _manager;

        public GanttController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            return View();
        }



    }

}
