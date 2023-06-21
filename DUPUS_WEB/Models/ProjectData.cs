using Services.Contracts;

namespace DUPUS_WEB.Models
{
    public class ProjectData
    {
        private readonly IServiceManager _manager;
        public ProjectData(IServiceManager manager)
        {
            _manager = manager;
        }

        public List<GanttDataSource> GetUrlDataSource()
        {
            List<GanttDataSource> dataCollection = new List<GanttDataSource>();
            dataCollection = new List<GanttDataSource>() {
               new GanttDataSource(){
                    taskId = 1,
                    taskName = "Project initiation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                      resources = new List<ResourceModel>
                {
                   new ResourceModel { resourceId = 159, resourceUnit = 70, ActivityId=40 },
                   new ResourceModel { resourceId = 160 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 2,
                    taskName = "Identify Site location",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "2",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                {
                   new ResourceModel { resourceId = 159, resourceUnit = 70, ActivityId=40 },
                   new ResourceModel { resourceId = 160 , ActivityId=40}
                }
                },
               new GanttDataSource(){
                    taskId = 3,
                    taskName = "Perform soil test",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "4",
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                            new ResourceModel { resourceId = 159, ActivityId=40 },
                        }
                },
               new GanttDataSource(){
                    taskId = 4,
                    taskName = "Soil test approval",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "1",
                    progress = 30,
                    parentID = 1,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { resourceId = 159 },
                        new ResourceModel { resourceId = 160, resourceUnit = 50 }
                        }
                },
               new GanttDataSource(){
                    taskId = 5,
                    taskName = "Project estimation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                },
               new GanttDataSource(){
                    taskId = 6,
                    taskName = "Develop floor plan for estimation",
                    startDate = new DateTime(2019, 03, 29),
                    duration = "3",
                    progress = 30,
                    parentID = 5,
                    resources = new List<ResourceModel>
                        {
                           new ResourceModel { resourceId = 159, resourceUnit = 60 }
                        }
                },
               new GanttDataSource()
               {
                   taskId = 7,
                   taskName = "List materials",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "3",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { resourceId = 159 },
                         new ResourceModel{ resourceId = 160 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 8,
                   taskName = "Estimation approval",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "2",
                   parentID = 5,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { resourceId = 159, ActivityId=40 },
                         new ResourceModel{ resourceId = 160, resourceUnit = 70 }
                        }
               },
               new GanttDataSource()
               {
                   taskId = 9,
                   taskName = "Sign contract",
                   startDate = new DateTime(2019, 04, 01),
                   duration = "1",
                   predecessor = "8",
                   progress = 30,
                   resources = new List<ResourceModel>
                        {
                           new ResourceModel { resourceId = 159 }
                    }
               }

            };
            return dataCollection;
        }

        public List<ResourceModel> ProjectResources()
        {
            List<ResourceModel> GanttResourcesCollection = new List<ResourceModel>();
            var resources = _manager.KonumService.GanttResourceGroup(21);
            if (resources is not null)
            {
                foreach (var resource in resources)
                {
                    GanttResourcesCollection.Add(new ResourceModel
                    {
                        resourceId = resource.KonumID,
                        resourceName = resource.Ad
                    });
                }
            }
            return GanttResourcesCollection;
        }

        public class GanttDataSource
        {
            public int taskId { get; set; }
            public string? taskName { get; set; }
            public DateTime? startDate { get; set; }
            public DateTime? endDate { get; set; }
            public string? duration { get; set; }
            public int progress { get; set; }
            public string? predecessor { get; set; }
            public int? parentID { get; set; }
            public List<ResourceModel>? resources { get; set; }
            public string? customColumn { get; set; }

        }
        public class ResourceModel
        {
            public int resourceId { get; set; }
            public string? resourceName { get; set; }
            public int? resourceUnit { get; set; }
            public int? ActivityId { get; set; }
        }

    }
}
