using DUPUS_WEB.Models;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using Syncfusion.EJ2.Base;

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

        public List<GanttDataSource> DataList = new();

        public IActionResult UrlDatasource([FromBody] DataManagerRequest dm)
        {
            DataList = datasource.GetUrlDataSource();
            var count = DataList.Count();
            return dm.RequiresCounts ? Json(new { result = DataList, count = count }) : Json(DataList);
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
                    }
                }
                if (batchmodel.Deleted != null)
                {
                    for (var i = 0; i < batchmodel.Deleted.Count(); i++)
                    {
                        var value = batchmodel.Deleted[i];
                        //Console.WriteLine(value);
                    }
                }
                if (batchmodel.Added != null)
                {
                    for (var i = 0; i < batchmodel.Added.Count(); i++)
                    {
                        var value = batchmodel.Added[i];
                        //Console.WriteLine(value);
                    }
                }
            }
            return Json(new { addedRecords = batchmodel?.Added, changedRecords = batchmodel?.Changed, deletedRecords = batchmodel?.Deleted, result = DataList, count = DataList.Count });
        }


    }
}
