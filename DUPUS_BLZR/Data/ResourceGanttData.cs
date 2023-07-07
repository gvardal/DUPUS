using Entities.Dtos;
using Services.Contracts;

namespace DUPUS_BLZR.Data
{
    public class ResourceGanttData
    {
        private readonly IServiceManager _manager;

        public ResourceGanttData(IServiceManager manager)
        {
            _manager = manager;
        }

        public List<ResourceModel> GanttResources()
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
