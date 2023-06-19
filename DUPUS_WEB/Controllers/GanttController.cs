using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using Syncfusion.EJ2.Base;

namespace DUPUS_WEB.Controllers
{
    public partial class GanttController : Controller
    {
        private readonly IServiceManager _manager;

        public GanttController(IServiceManager manager)
        {
            _manager = manager;
        }

        public List<GanttDataSourceDto> DataList = new();

        public IActionResult Index()
        {
            ViewBag.ProjectResources = GetResource();
            return View();
        }

        public IActionResult UrlDatasource([FromBody] DataManagerRequest dm)
        {
            DataList = GetUrlDataSource();
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


        public List<ResourceGroupCollection> GetResource()
        {
            List<ResourceGroupCollection> GanttResourcesCollection = new List<ResourceGroupCollection>();
            var resources = _manager.KonumService.GanttResourceGroup(21);
            if (resources != null)
            {
                foreach (var resource in resources)
                {
                    GanttResourcesCollection.Add(new ResourceGroupCollection
                    {
                        resourceId = resource.KonumID,
                        resourceName = resource.KonumKoduAdi
                    });
                }
            }
            return GanttResourcesCollection;
        }

        public List<GanttDataSourceDto> GetUrlDataSource()
        {
            List<GanttDataSourceDto> dataCollection = new List<GanttDataSourceDto>();
            dataCollection = _manager.IsEmriService.GanttDataSource().ToList();
            return dataCollection;
        }
    }
}
