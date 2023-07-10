using Entities.Dtos;
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
            var tasks = _manager.IsEmriService.GanttTasks();
            if (tasks != null)
            {
                foreach (var task in tasks)
                {
                    dataCollection.Add(new GanttDataSource
                    {
                        taskId = task.TaskId,
                        taskName = task.TaskName,
                        startDate = task.StartDate,
                        duration = task.Duration,
                        progress = task.Progress,
                        predecessor = task.Predecessor,
                        resources = task.Resources
                    });
                }
            }
            return dataCollection;
        }

        public List<ResourceData> ProjectResources()
        {
            List<ResourceData> GanttResourcesCollection = new List<ResourceData>();
            var resources = _manager.KonumService.GanttResourceGroup(21);
            if (resources is not null)
            {
                foreach (var resource in resources)
                {
                    GanttResourcesCollection.Add(new ResourceData
                    {
                        ResourceId = resource.KonumID,
                        ResourceName = resource.Ad,
                        ResourceGroup = resource.KonumKodu
                    });
                }
            }
            return GanttResourcesCollection;
        }

        public List<ResourceListDto> ResourcesList()
        {
            List<ResourceListDto> ResourcesList = new List<ResourceListDto>();
            var resources = _manager.KonumService.GanttResourceGroup(21);
            if (resources is not null)
            {
                foreach (var resource in resources)
                {
                    ResourcesList.Add(new ResourceListDto
                    {
                        Id = resource.KonumID.ToString(),
                        Text = resource.Ad,
                    });
                }
            }
            return ResourcesList;
        }

    }
}
