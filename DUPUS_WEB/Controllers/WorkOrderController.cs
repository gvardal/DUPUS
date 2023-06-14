using Microsoft.AspNetCore.Mvc;

namespace DUPUS_WEB.Controllers
{
    public class WorkOrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
