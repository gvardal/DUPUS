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

        private List<GanttDataSource> DataList = new();
        private List<ResourceGroupCollection> GanttResourcesCollection = new();

        public IActionResult Index()
        {
            ViewBag.DataSource = ResourceViewData();
            ViewBag.ProjectResources = GetResourceGroup();
            return View();
        }

        public static List<GanttDataSource> ResourceViewData()
        {
            List<GanttDataSource> GanttResourceSampleCollection = new List<GanttDataSource>();

            GanttDataSource Record1 = new GanttDataSource()
            {
                TaskId = 1,
                TaskName = "Project initiation",
                StartDate = new DateTime(2019, 03, 29),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<GanttDataSource>(),
            };
            GanttDataSource Record1Child1 = new GanttDataSource()
            {
                TaskId = 2,
                TaskName = "Identify Site location",
                StartDate = new DateTime(2019, 03, 29),
                Duration = 2,
                Progress = 30,
                Work = 10,
                Resources = new List<ResourceModel>
                {
                   new ResourceModel{  ResourceId = 1, ResourceUnit = 50 }
                }
            };
            GanttDataSource Record1Child2 = new GanttDataSource()
            {
                TaskId = 3,
                TaskName = "Perform soil test",
                StartDate = new DateTime(2019, 03, 29),
                Duration = 4,
                Progress = 30,
                Work = 20,
                Resources = new List<ResourceModel>
                {
                   new ResourceModel {  ResourceId = 2, ResourceUnit = 70 }
                }
            };
            GanttDataSource Record1Child3 = new GanttDataSource()
            {
                TaskId = 4,
                TaskName = "Soil test approval",
                StartDate = new DateTime(2019, 03, 29),
                Duration = 1,
                Progress = 30,
                Work = 10,
                Resources = new List<ResourceModel> {
                   new ResourceModel { ResourceId = 3, ResourceUnit = 25 },
                   new ResourceModel { ResourceId = 1, ResourceUnit = 75 },
                }

            };
            Record1.SubTasks.Add(Record1Child1);
            Record1.SubTasks.Add(Record1Child2);
            Record1.SubTasks.Add(Record1Child3);

            GanttDataSource Record2 = new GanttDataSource()
            {
                TaskId = 5,
                TaskName = "Project estimation",
                StartDate = new DateTime(2019, 03, 29),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<GanttDataSource>(),
            };
            GanttDataSource Record2Child1 = new GanttDataSource()
            {
                TaskId = 6,
                TaskName = "Develop floor plan for estimation",
                StartDate = new DateTime(2019, 03, 29),
                Duration = 3,
                Progress = 30,
                Work = 30,
                Resources = new List<ResourceModel>
                {
                   new ResourceModel{ ResourceId = 4, ResourceUnit = 50 },
                   new ResourceModel{ ResourceId = 2, ResourceUnit = 70 }
                }
            };
            GanttDataSource Record2Child2 = new GanttDataSource()
            {
                TaskId = 7,
                TaskName = "List materials",
                StartDate = new DateTime(2019, 04, 01),
                Duration = 3,
                Progress = 30,
                Work = 40,
                Resources = new List<ResourceModel>
                {
                   new ResourceModel{ ResourceId = 6, ResourceUnit = 40 }
                }
            };
            GanttDataSource Record2Child3 = new GanttDataSource()
            {
                TaskId = 8,
                TaskName = "Estimation approval",
                StartDate = new DateTime(2019, 04, 01),
                Duration = 2,
                Progress = 30,
                Work = 60,
                Resources = new List<ResourceModel>
                {
                   new ResourceModel{ ResourceId = 5, ResourceUnit = 75 }
                }
            };
            Record2.SubTasks.Add(Record2Child1);
            Record2.SubTasks.Add(Record2Child2);
            Record2.SubTasks.Add(Record2Child3);

            GanttDataSource Record3 = new GanttDataSource()
            {
                TaskId = 9,
                TaskName = "Sign contract",
                StartDate = new DateTime(2019, 04, 01),
                Duration = 1,
                Progress = 30,
            };
            GanttResourceSampleCollection.Add(Record1);
            GanttResourceSampleCollection.Add(Record2);
            GanttResourceSampleCollection.Add(Record3);
            return GanttResourceSampleCollection;
        }

        public static List<ResourceGroupCollection> GetResourceGroup()
        {
            List<ResourceGroupCollection> GanttResourcesCollection = new List<ResourceGroupCollection>();

            ResourceGroupCollection Record1 = new ResourceGroupCollection()
            {
                ResourceId = 1,
                ResourceName = "Martin Tamer",
                ResourceGroup = "Planning Team"
            };
            ResourceGroupCollection Record2 = new ResourceGroupCollection()
            {
                ResourceId = 2,
                ResourceName = "Rose Fuller",
                ResourceGroup = "Testing Team"
            };
            ResourceGroupCollection Record3 = new ResourceGroupCollection()
            {
                ResourceId = 3,
                ResourceName = "Margaret Buchanan",
                ResourceGroup = "Approval Team"
            };
            ResourceGroupCollection Record4 = new ResourceGroupCollection()
            {
                ResourceId = 4,
                ResourceName = "Fuller King",
                ResourceGroup = "Development Team"
            };
            ResourceGroupCollection Record5 = new ResourceGroupCollection()
            {
                ResourceId = 5,
                ResourceName = "Davolio Fuller",
                ResourceGroup = "Approval Team"
            };
            ResourceGroupCollection Record6 = new ResourceGroupCollection()
            {
                ResourceId = 6,
                ResourceName = "Van Jack",
                ResourceGroup = "Development Team"
            };
            GanttResourcesCollection.Add(Record1);
            GanttResourcesCollection.Add(Record2);
            GanttResourcesCollection.Add(Record3);
            GanttResourcesCollection.Add(Record4);
            GanttResourcesCollection.Add(Record5);
            GanttResourcesCollection.Add(Record6);
            return GanttResourcesCollection;
        }

        public List<GanttDataSource> GetUrlDataSource()
        {
            List<GanttDataSource> dataCollection = new List<GanttDataSource>();
            dataCollection = ResourceViewData();
            return dataCollection;
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
                    }
                }
                if (batchmodel.Deleted != null)
                {
                    for (var i = 0; i < batchmodel.Deleted.Count(); i++)
                    {
                        var value = batchmodel.Deleted[i];
                        Console.WriteLine(value);
                    }
                }
                if (batchmodel.Added != null)
                {
                    for (var i = 0; i < batchmodel.Added.Count(); i++)
                    {
                        var value = batchmodel.Added[i];
                        Console.WriteLine(value);
                    }
                }
            }
            return Json(new { addedRecords = batchmodel?.Added, changedRecords = batchmodel?.Changed, deletedRecords = batchmodel?.Deleted, result = DataList, count = DataList.Count });
        }


        // Bunu sakın silme
        public List<ResourceGroupCollection> GetResource()
        {
            var resources = _manager.KonumService.GanttResourceGroup(21);
            if (resources != null)
            {
                foreach (var resource in resources)
                {
                    GanttResourcesCollection.Add(new ResourceGroupCollection
                    {
                        ResourceId = resource.KonumID,
                        ResourceName = resource.Ad,
                        ResourceGroup = resource.KonumKodu
                    });
                }
            }
            return GanttResourcesCollection;
        }

        // Bunu sakın silme
        public List<GanttDataSourceDto> ResourceData()
        {
            List<GanttDataSourceDto> GanttResourceSampleCollection = new List<GanttDataSourceDto>();
            var mainTasks = _manager.IsEmriService.GanttMainTasks();
            if (mainTasks is not null)
            {
                foreach (var main in mainTasks.Take(3))
                {
                    GanttResourceSampleCollection.Add(new GanttDataSourceDto
                    {
                        TaskId = main.IsEmriId,
                        TaskName = main.UrunAdi,
                    });
                }
            }
            var subTasks = _manager.IsEmriService.GanttSubTask().ToList();
            foreach (var task in GanttResourceSampleCollection)
            {
                var subTask = subTasks.FirstOrDefault(x => x.IsEmriId.Equals(task.TaskId)); //Burası değişecek tek kayıt gelmemeli
                if (subTask != null)
                {
                    task.SubTasks = new List<GanttDataSourceDto>
                    {
                        new GanttDataSourceDto
                        {
                            TaskId = subTask.TaskId,
                            TaskName = subTask.TaskName,
                            StartDate = subTask.StartDate,
                            EndDate = subTask.EndDate,
                            Resources = subTask.Resources
                        }
                    };
                }
            }
            return GanttResourceSampleCollection;
        }
        
        
        public class GanttDataSource
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; }
            public string TaskType { get; set; }
            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public DateTime BaselineStartDate { get; set; }
            public DateTime BaselineEndDate { get; set; }
            public int? Duration { get; set; }
            public bool IsManual { get; set; }
            public int Progress { get; set; }
            public string Predecessor { get; set; }
            public List<GanttDataSource> SubTasks { get; set; }
            public int[] ResourceId { get; set; }
            public List<ResourceModel> Resources { get; set; }
            public string Notes { get; set; }
            public int? Work { get; set; }
            public int ParentID { get; set; }
            public List<IndicatorsModel> Indicators { get; set; }
        }
        public class ResourceModel
        {
            public int ResourceId { get; set; }
            public Nullable<int> ResourceUnit { get; set; }
        }
        public class IndicatorsModel
        {
            public string date { get; set; }
            public string iconClass { get; set; }
            public string name { get; set; }
            public string tooltip { get; set; }
        }
        public class ResourceGroupCollection
        {
            public int ResourceId { get; set; }
            public string ResourceName { get; set; }
            public string ResourceGroup { get; set; }
        }
    }

}
