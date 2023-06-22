using DUPUS_WEB.Models;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Base;
using static DUPUS_WEB.Models.ProjectData2;

namespace DUPUS_WEB.Controllers
{
    public partial class GanttController : Controller
    {
        public List<GanttDataSourceDto> DataList = new();

        public IActionResult Index()
        {
            ViewBag.ProjectResources = GetResource();
            return View();
        }

        public IActionResult UrlDatasource([FromBody] DataManagerRequest dm)
        {
            ProjectData2 projectData = new ProjectData2();
            DataList = projectData.GetUrlDataSource();
            return dm.RequiresCounts ? Json(new { result = DataList, count = DataList.Count }) : Json(DataList);
        }


        public IActionResult BatchUpdate([FromBody] CRUDModel batchmodel)
        {
            if (batchmodel != null)
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
                    for (var i = 0; i < batchmodel.Deleted.Count(); i++)
                    {
                        var value = batchmodel.Deleted[i];
                        Console.WriteLine(value);
                        //DataList.Remove(DataList.Where(or => or.taskId == batchmodel.Deleted[i].taskId).FirstOrDefault());
                        //RemoveChildRecords(batchmodel.Deleted[i].taskId);
                    }
                }
                if (batchmodel.Added != null)
                {
                    for (var i = 0; i < batchmodel.Added.Count(); i++)
                    {
                        var value = batchmodel.Added[i];
                        Console.WriteLine(value);
                        //DataList.Insert(0, batchmodel.Added[i]);
                    }
                }
            }
            return Json(new { addedRecords = batchmodel?.Added, changedRecords = batchmodel?.Changed, deletedRecords = batchmodel?.Deleted, result = DataList, count = DataList.Count });
        }


        public static List<ResourceGroupCollection> GetResource()
        {
            List<ResourceGroupCollection> GanttResourcesCollection = new List<ResourceGroupCollection>();

            ResourceGroupCollection Record1 = new ResourceGroupCollection()
            {
                resourceId = 1,
                resourceName = "Martin Tamer"
            };
            ResourceGroupCollection Record2 = new ResourceGroupCollection()
            {
                resourceId = 2,
                resourceName = "Rose Fuller"
            };
            ResourceGroupCollection Record3 = new ResourceGroupCollection()
            {
                resourceId = 3,
                resourceName = "Margaret Buchanan"
            };
            ResourceGroupCollection Record4 = new ResourceGroupCollection()
            {
                resourceId = 4,
                resourceName = "Fuller King"
            };
            ResourceGroupCollection Record5 = new ResourceGroupCollection()
            {
                resourceId = 5,
                resourceName = "Davolio Fuller"
            };
            ResourceGroupCollection Record6 = new ResourceGroupCollection()
            {
                resourceId = 6,
                resourceName = "Van Jack"
            };
            GanttResourcesCollection.Add(Record1);
            GanttResourcesCollection.Add(Record2);
            GanttResourcesCollection.Add(Record3);
            GanttResourcesCollection.Add(Record4);
            GanttResourcesCollection.Add(Record5);
            GanttResourcesCollection.Add(Record6);
            return GanttResourcesCollection;
        }

        public class ResourceGroupCollection
        {
            public int resourceId { get; set; }
            public string? resourceName { get; set; }
        }
    }
}
