using DUPUS_WEB.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace DUPUS_WEB.Controllers
{
    public class ResourceSchedulerController : Controller
    {
        private readonly IServiceManager _serviceManager;
        private ProjectData datasource;

        public ResourceSchedulerController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
            datasource = new ProjectData(_serviceManager);
        }

        public IActionResult Index()
        {
            ViewBag.projectResources = datasource.ResourcesList();
            return View();
        }

        [HttpPost]
        public IActionResult GetValues()
        {
            string value = HttpContext.Request.Form["konumAd"];
            ViewBag.SelectedListItem = value;
            return View("Values");
        }

        public class AppointmentData
        {
            public int Id { get; set; }
            public string Subject { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
        }

       
    }
}
