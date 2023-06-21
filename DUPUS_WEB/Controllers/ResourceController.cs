using DUPUS_WEB.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using Syncfusion.EJ2.Base;
using static DUPUS_WEB.Models.ProjectData;

namespace DUPUS_WEB.Controllers
{
    public class ResourceController : Controller
    {
        private readonly IServiceManager _serviceManager;
        private ProjectData datasource;
        public ResourceController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
            datasource = new ProjectData(_serviceManager);

        }

        public IActionResult Index()
        {
            ViewBag.projectResources = datasource.ProjectResources();
            return View();
        }

        public static List<GanttDataSource> DataList = null;

        public IActionResult UrlDatasource([FromBody] DataManagerRequest dm)
        {
            if (DataList == null)
            {
                DataList = datasource.GetUrlDataSource();
            }
            var count = DataList.Count();
            return dm.RequiresCounts ? Json(new { result = DataList, count = count }) : Json(DataList);
        }

        public class CRUDModel
        {
            public List<GanttDataSource>? Added { get; set; }
            public List<GanttDataSource>? Changed { get; set; }
            public List<GanttDataSource>? Deleted { get; set; }
            public GanttDataSource? Value { get; set; }
            public int key { get; set; }
            public string action { get; set; }
        }
        public IActionResult BatchUpdate(CRUDModel batchmodel)
        {
            if (batchmodel.Changed != null)
            {
                for (var i = 0; i < batchmodel.Changed.Count(); i++)
                {
                    var value = batchmodel.Changed[i];
                    Console.WriteLine(value);
                    //GanttDataSource result = DataList.Where(or => or.taskId == value.taskId).FirstOrDefault();
                    //result.taskId = value.taskId;
                    //result.taskName = value.taskName;
                    //result.startDate = value.startDate;
                    //result.endDate = value.endDate;
                    //result.duration = value.duration;
                    //result.progress = value.progress;
                    //result.predecessor = value.predecessor;
                    //result.resources = value.resources;
                    //result.parentID = value.parentID;
                    //result.customColumn = value.customColumn;

                }
            }
            if (batchmodel.Deleted != null)
            {
                Console.WriteLine($"deleted {batchmodel.Deleted}");
                //for (var i = 0; i < batchmodel.Deleted.Count(); i++)
                //{
                //    DataList.Remove(DataList.Where(or => or.taskId == batchmodel.Deleted[i].taskId).FirstOrDefault());
                //    RemoveChildRecords(batchmodel.Deleted[i].taskId);
                //}
            }
            if (batchmodel.Added != null)
            {
                Console.WriteLine($"added {batchmodel.Added}");
                //for (var i = 0; i < batchmodel.Added.Count(); i++)
                //{
                //    DataList.Insert(0,batchmodel.Added[i]);                 
                //}
            }
            return Json(new { addedRecords = batchmodel.Added, changedRecords = batchmodel.Changed, deletedRecords = batchmodel.Deleted });
        }
        public void RemoveChildRecords(int key)
        {
            var childList = DataList.Where(x => x.parentID == key).ToList();
            foreach (var item in childList)
            {
                DataList.Remove(item);
                RemoveChildRecords(item.taskId);
            }
        }


    }
}
