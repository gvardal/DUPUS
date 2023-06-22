﻿using Entities.Dtos;
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
                        taskId = task.taskId,
                        taskName = task.taskName,
                        startDate = task.startDate,
                        duration = task.duration,
                        progress = task.progress,
                        predecessor = task.predecessor,
                        resources = task.resources
                    });
                }
            }
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
                        resourceName = resource.Ad,
                        resourceGroup = resource.KonumKodu
                    });
                }
            }
            return GanttResourcesCollection;
        }



    }
}
