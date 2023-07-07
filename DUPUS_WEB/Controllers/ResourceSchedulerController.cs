using DUPUS_WEB.Models;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using Syncfusion.EJ2.Base;

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
            ViewBag.ResourceList = datasource.ResourcesList();
            ViewBag.SelectedResource = "KUTULAMA ISTASYONU";
            return View();
        }

        public IActionResult LoadData([FromBody] DataManagerRequest dm)
        {
            List<SchedulerData> appData = new List<SchedulerData>();
            appData.Add(new SchedulerData
            { id = 1, subject = "Explosion of Betelgeuse Star", startTime = new DateTime(2022, 2, 11, 9, 30, 0), endTime = new DateTime(2022, 2, 11, 11, 0, 0) });

            var count = appData.Count();
            return dm.RequiresCounts ? Json(new { result = appData, count = count }) : Json(appData);
        }

        // Here we get the Start and End Date and based on that can filter the data and return to Scheduler
        //public ActionResult LoadData()  
        //{
        //    List<SchedulerData> appData = new List<SchedulerData>();
        //    appData.Add(new SchedulerData
        //    { id = 1, subject = "Explosion of Betelgeuse Star", startTime = new DateTime(2022, 2, 11, 9, 30, 0), endTime = new DateTime(2022, 2, 11, 11, 0, 0) });
        //    //appData.Add(new SchedulerData
        //    //{ Id = 2, Subject = "Thule Air Crash Report", StartTime = new DateTime(2022, 2, 12, 12, 0, 0), EndTime = new DateTime(2022, 2, 12, 14, 0, 0) });
        //    //appData.Add(new SchedulerData
        //    //{ Id = 3, Subject = "Blue Moon Eclipse", StartTime = new DateTime(2022, 2, 13, 9, 30, 0), EndTime = new DateTime(2022, 2, 13, 11, 0, 0) });
        //    //appData.Add(new SchedulerData
        //    //{ Id = 4, Subject = "Meteor Showers in 2022", StartTime = new DateTime(2022, 2, 14, 13, 0, 0), EndTime = new DateTime(2022, 2, 14, 14, 30, 0) });
        //    //appData.Add(new SchedulerData
        //    //{ Id = 5, Subject = "Milky Way as Melting pot", StartTime = new DateTime(2022, 2, 15, 12, 0, 0), EndTime = new DateTime(2022, 2, 15, 14, 0, 0) });

        //    //var data = db.ScheduleEventDatas.ToList();
        //    return Json(appData);
        //}

    }
}
